using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using static OpenTK.Platform.Native.macOS.ObjC;

namespace OpenTK.Platform.Native.macOS
{
    public unsafe class MacOSOpenGLComponent : IOpenGLComponent
    {
        internal static readonly ObjCClass NSOpenGLContextClass = objc_getClass("NSOpenGLContext");
        internal static readonly ObjCClass NSOpenGlPixelFormatClass = objc_getClass("NSOpenGLPixelFormat");

        internal static readonly SEL selInitWithAttributes = sel_registerName("initWithAttributes:"u8);
        internal static readonly SEL selInitWithFormatShareContext = sel_registerName("initWithFormat:shareContext:"u8);
        internal static readonly SEL selSetView = sel_registerName("setView:"u8);
        internal static readonly SEL selSetWantsBestResolutionOpenGLSurface = sel_registerName("setWantsBestResolutionOpenGLSurface:"u8);
        internal static readonly SEL selUpdate = sel_registerName("update"u8);
        internal static readonly SEL selClearCurrentContext = sel_registerName("clearCurrentContext"u8);
        internal static readonly SEL selCurrentContext = sel_registerName("currentContext"u8);
        internal static readonly SEL selMakeCurrentContext = sel_registerName("makeCurrentContext"u8);
        internal static readonly SEL selClearDrawable = sel_registerName("clearDrawable"u8);
        internal static readonly SEL selFlushBuffer = sel_registerName("flushBuffer"u8);

        internal static readonly IntPtr opengl = LoadLibrary("/System/Library/Frameworks/OpenGl.framework/OpenGL"u8, true);

        internal static Dictionary<IntPtr, NSOpenGLContext> NSOpenGLContextDict = new Dictionary<nint, NSOpenGLContext>();

        /// <inheritdoc/>
        public string Name => nameof(MacOSOpenGLComponent);

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.OpenGL;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        /// <inheritdoc/>
        public void Initialize(PalComponents which)
        {
            // FIXME: Do something?
        }

        /// <inheritdoc/>
        public bool CanShareContexts => true;

        /// <inheritdoc/>
        public bool CanCreateFromWindow => true;

        /// <inheritdoc/>
        public bool CanCreateFromSurface => false;

        /// <inheritdoc/>
        public OpenGLContextHandle CreateFromSurface()
        {
            throw new NotSupportedException("We currently do not support surfaces.");
        }

        /// <inheritdoc/>
        public OpenGLContextHandle CreateFromWindow(WindowHandle handle)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            if (nswindow.GraphicsApiHints is not OpenGLGraphicsApiHints settings)
            {
                throw new PalException(this, $"Can't create an OpenGL context from a window that was not created with {nameof(OpenGLGraphicsApiHints)}");
            }

            // FIXME: Make this a parameter to this function instead?
            NSOpenGLContext? nsShareContext = null;
            if (settings.SharedContext != null)
            {
                if (settings.SharedContext is NSOpenGLContext nsShare)
                {
                    nsShareContext = nsShare;
                }
                else
                {
                    throw new PalException(this, $"Can't create a shared context with a non-macOS OpenGL context. {settings.SharedContext}");
                }
            }

            List<NSOpenGLPixelFormatAttribute> attributes = new List<NSOpenGLPixelFormatAttribute>();

            NSOpenGLProfileVersion profileVersion = NSOpenGLProfileVersion.Legacy;
            if (settings.Version.Major > 4 || (settings.Version.Major >= 4 && settings.Version.Minor >= 1))
            {
                // FIXME: Should we specify this?
                profileVersion = NSOpenGLProfileVersion.Version4_1Core;
            }
            else if (settings.Version.Major > 3 || (settings.Version.Major >= 3 && settings.Version.Minor >= 2))
            {
                profileVersion = NSOpenGLProfileVersion.Version3_2Core;
            }
            attributes.Add(NSOpenGLPixelFormatAttribute.OpenGLProfile);
            attributes.Add((NSOpenGLPixelFormatAttribute)profileVersion);

            attributes.Add(NSOpenGLPixelFormatAttribute.ColorSize);
            // FIXME: How to set this correctly?
            attributes.Add((NSOpenGLPixelFormatAttribute)(settings.RedColorBits + settings.GreenColorBits + settings.BlueColorBits));

            // FIXME: Detect if there are any hardware accelerated formats, if there are
            // set NSOpenGLPixelFormatAttribute.Accelerated.

            // FIXME: Setting for tripple buffering?
            if (settings.DoubleBuffer)
            {
                attributes.Add(NSOpenGLPixelFormatAttribute.DoubleBuffer);
            }

            if (settings.DepthBits != ContextDepthBits.None)
            {
                int depthBits;
                switch (settings.DepthBits)
                {
                    case ContextDepthBits.Depth24: depthBits = 24; break;
                    case ContextDepthBits.Depth32: depthBits = 32; break;
                    default: throw new InvalidEnumArgumentException(nameof(settings.DepthBits), (int)settings.DepthBits, settings.DepthBits.GetType());
                }

                attributes.Add(NSOpenGLPixelFormatAttribute.DepthSize);
                attributes.Add((NSOpenGLPixelFormatAttribute)depthBits);
            }

            if (settings.StencilBits != ContextStencilBits.None)
            {
                int stencilBits;
                switch (settings.StencilBits)
                {
                    case ContextStencilBits.Stencil1: stencilBits = 1; break;
                    case ContextStencilBits.Stencil8: stencilBits = 8; break;
                    default: throw new InvalidEnumArgumentException(nameof(settings.StencilBits), (int)settings.StencilBits, settings.StencilBits.GetType());
                }

                attributes.Add(NSOpenGLPixelFormatAttribute.StencilSize);
                attributes.Add((NSOpenGLPixelFormatAttribute)stencilBits);
            }

            if (settings.Multisamples > 0)
            {
                attributes.Add(NSOpenGLPixelFormatAttribute.SampleBuffers);
                attributes.Add((NSOpenGLPixelFormatAttribute)1);
                attributes.Add(NSOpenGLPixelFormatAttribute.Samples);
                attributes.Add((NSOpenGLPixelFormatAttribute)settings.Multisamples);
            }

            // FIXME: Can we create an sRGB framebuffer?

            attributes.Add(0);

            IntPtr pixelFormat = objc_msgSend_IntPtr((IntPtr)NSOpenGlPixelFormatClass, Alloc);

            fixed(NSOpenGLPixelFormatAttribute* attributePtr = CollectionsMarshal.AsSpan(attributes))
            {
                pixelFormat = objc_msgSend_IntPtr(pixelFormat, selInitWithAttributes, (IntPtr)attributePtr);
            }

            if (pixelFormat == IntPtr.Zero)
            {
                // FIXME: Better error message!
                throw new PalException(this, $"Failed to create pixel format matching settings.");
            }

            IntPtr share = nsShareContext?.Context ?? IntPtr.Zero;

            IntPtr context = objc_msgSend_IntPtr(
                objc_msgSend_IntPtr((IntPtr)NSOpenGLContextClass, Alloc),
                selInitWithFormatShareContext,
                pixelFormat, share);

            NSOpenGLContext nscontext = new NSOpenGLContext(context, nsShareContext);

            // We do this so the window component can implement SwapBuffers.
            // And so we can call [Context update] when the window resizes or moves
            // - Noggin_bops 2023-11-11
            nswindow.Context = nscontext;

            NSOpenGLContextDict.Add(nscontext.Context, nscontext);

            // Release the pixelFormat
            objc_msgSend(pixelFormat, Release);

            objc_msgSend(context, selSetView, nswindow.View);
            // FIXME: This is a BOOL property, so this might not work
            objc_msgSend(nswindow.View, selSetWantsBestResolutionOpenGLSurface, true);

            objc_msgSend(nswindow.Window, selUpdate);

            return nscontext;
        }

        /// <inheritdoc/>
        public void DestroyContext(OpenGLContextHandle handle)
        {
            NSOpenGLContext nscontext = handle.As<NSOpenGLContext>(this);

            NSOpenGLContextDict.Remove(nscontext.Context);

            objc_msgSend(nscontext.Context, selClearDrawable);
            objc_msgSend(nscontext.Context, Release);

            nscontext.Context = IntPtr.Zero;
        }

        /// <inheritdoc/>
        public IBindingsContext GetBindingsContext(OpenGLContextHandle handle)
        {
            return new Pal2BindingsContext(this, handle);
        }

        /// <inheritdoc/>
        public nint GetProcedureAddress(OpenGLContextHandle handle, string procedureName)
        {
            // FIXME: Maybe more complicated logic?
            return GetSymbol(opengl, procedureName);
        }

        /// <inheritdoc/>
        public OpenGLContextHandle? GetCurrentContext()
        {
            IntPtr contextPtr = objc_msgSend_IntPtr((IntPtr)NSOpenGLContextClass, selCurrentContext);

            if (contextPtr == IntPtr.Zero)
            {
                return null;
            }
            else
            {
                return NSOpenGLContextDict[contextPtr];
            }
        }

        /// <inheritdoc/>
        public bool SetCurrentContext(OpenGLContextHandle? handle)
        {
            NSOpenGLContext? nscontext = handle?.As<NSOpenGLContext>(this);

            if (nscontext != null)
            {
                objc_msgSend(nscontext.Context, selMakeCurrentContext);
            }
            else
            {
                objc_msgSend((IntPtr)NSOpenGLContextClass, selClearCurrentContext);
            }

            return true;
        }

        /// <inheritdoc/>
        public OpenGLContextHandle? GetSharedContext(OpenGLContextHandle handle)
        {
            NSOpenGLContext nscontext = handle.As<NSOpenGLContext>(this);
            return nscontext.SharedContext;
        }

        /// <inheritdoc/>
        public unsafe void SetSwapInterval(int interval)
        {
            NSOpenGLContext? nscontext = (NSOpenGLContext?)GetCurrentContext();

            if (nscontext != null)
            {
                objc_msgSend(nscontext.Context, sel_registerName("setValues:forParameter:"u8), (IntPtr)(&interval), (long)NSOpenGLContextParameter.SwapInterval);
            }
        }

        /// <inheritdoc/>
        public int GetSwapInterval()
        {
            NSOpenGLContext? nscontext = (NSOpenGLContext?)GetCurrentContext();

            int interval = default;
            if (nscontext != null)
            {
                objc_msgSend(nscontext.Context, sel_registerName("getValues:forParameter:"u8), (IntPtr)(&interval), (long)NSOpenGLContextParameter.SwapInterval);
            }

            return interval;
        }

        /// <inheritdoc/>
        public void SwapBuffers(OpenGLContextHandle handle)
        {
            NSOpenGLContext nscontext = handle.As<NSOpenGLContext>(this);
            objc_msgSend(nscontext.Context, selFlushBuffer);
        }

        /// <summary>
        /// Returns the <c>NSOpenGLContext</c> associated with the specified context handle.
        /// </summary>
        /// <param name="handle">A handle to an OpenGL context to get the associated <c>NSOpenGLContext</c> from.</param>
        /// <returns>The <c>NSOpenGLContext</c> associated with the context handle.</returns>
        public IntPtr GetNSOpenGLContext(OpenGLContextHandle handle)
        {
            NSOpenGLContext nscontext = handle.As<NSOpenGLContext>(this);

            return nscontext.Context;
        }
    }
}

