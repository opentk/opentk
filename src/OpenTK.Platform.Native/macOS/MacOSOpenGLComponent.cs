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
        internal static ObjCClass NSOpenGLContextClass = objc_getClass("NSOpenGLContext");
        internal static ObjCClass NSOpenGlPixelFormatClass = objc_getClass("NSOpenGLPixelFormat");

        internal static SEL selInitWithAttributes = sel_registerName("initWithAttributes:"u8);
        internal static SEL selInitWithFormatShareContext = sel_registerName("initWithFormat:shareContext:"u8);
        internal static SEL selSetView = sel_registerName("setView:"u8);
        internal static SEL selSetWantsBestResolutionOpenGLSurface = sel_registerName("setWantsBestResolutionOpenGLSurface:"u8);
        internal static SEL selUpdate = sel_registerName("update"u8);
        internal static SEL selMakeCurrentContext = sel_registerName("makeCurrentContext"u8);
        internal static SEL selClearCurrentContext = sel_registerName("clearCurrentContext"u8);
        internal static SEL selFlushBuffer = sel_registerName("flushBuffer"u8);

        internal static IntPtr opengl = LoadLibrary("/System/Library/Frameworks/OpenGl.framework/OpenGL"u8, true);

        public string Name => nameof(MacOSOpenGLComponent);

        public PalComponents Provides => PalComponents.OpenGL;

        public ILogger? Logger { get; set; }

        public void Initialize(PalComponents which)
        {
            // FIXME:
        }

        public bool CanShareContexts => throw new NotImplementedException();

        public bool CanCreateFromWindow => throw new NotImplementedException();

        public bool CanCreateFromSurface => throw new NotImplementedException();

        public OpenGLContextHandle CreateFromSurface()
        {
            throw new NotImplementedException();
        }

        public OpenGLContextHandle CreateFromWindow(WindowHandle handle)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            if (nswindow.GraphicsApiHints is not OpenGLGraphicsApiHints settings)
            {
                throw new PalException(this, $"Can't create an OpenGL context from a window that was not created with {nameof(OpenGLGraphicsApiHints)}");
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

            // FIXME: context sharing!
            IntPtr context = objc_msgSend_IntPtr(
                objc_msgSend_IntPtr((IntPtr)NSOpenGLContextClass, Alloc),
                selInitWithFormatShareContext,
                pixelFormat, IntPtr.Zero);

            NSOpenGLContext nscontext = new NSOpenGLContext(context);

            // We do this so the window component can implement SwapBuffers.
            nswindow.Context = nscontext;

            // Release the pixelFormat
            objc_msgSend(pixelFormat, Release);

            objc_msgSend(context, selSetView, nswindow.View);
            // FIXME: This is a BOOL property, so this might not work
            objc_msgSend(nswindow.View, selSetWantsBestResolutionOpenGLSurface, true);

            objc_msgSend(nswindow.Window, selUpdate);

            return nscontext;
        }

        public void DestroyContext(OpenGLContextHandle handle)
        {
            throw new NotImplementedException();
        }

        public IBindingsContext GetBindingsContext(OpenGLContextHandle handle)
        {
            return new Pal2BindingsContext(this, handle);
        }

        public nint GetProcedureAddress(OpenGLContextHandle handle, string procedureName)
        {
            // FIXME: Maybe more complicated logic?
            return GetSymbol(opengl, procedureName);
        }

        public OpenGLContextHandle? GetCurrentContext()
        {
            throw new NotImplementedException();
        }

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

        public OpenGLContextHandle? GetSharedContext(OpenGLContextHandle handle)
        {
            throw new NotImplementedException();
        }

        public void SetSwapInterval(int interval)
        {
            throw new NotImplementedException();
        }

        public int GetSwapInterval()
        {
            throw new NotImplementedException();
        }
    }
}

