using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using OpenTK.Platform;
using OpenTK.Core.Utility;
using static OpenTK.Platform.Native.macOS.ObjC;

namespace OpenTK.Platform.Native.macOS
{
    public unsafe class MacOSOpenGLComponent : IOpenGLComponent
    {
        internal static readonly ObjCClass NSOpenGLContextClass = objc_getClass("NSOpenGLContext"u8);
        internal static readonly ObjCClass NSOpenGLPixelFormatClass = objc_getClass("NSOpenGLPixelFormat"u8);

        internal static readonly SEL selInitWithAttributes = sel_registerName("initWithAttributes:"u8);
        internal static readonly SEL selInitWithCGLPixelFormatObj = sel_registerName("initWithCGLPixelFormatObj:"u8);
        internal static readonly SEL selCGLPixelFormatObj = sel_registerName("CGLPixelFormatObj"u8);
        internal static readonly SEL selInitWithFormatShareContext = sel_registerName("initWithFormat:shareContext:"u8);
        internal static readonly SEL selSetView = sel_registerName("setView:"u8);
        internal static readonly SEL selSetWantsBestResolutionOpenGLSurface = sel_registerName("setWantsBestResolutionOpenGLSurface:"u8);
        internal static readonly SEL selUpdate = sel_registerName("update"u8);
        internal static readonly SEL selClearCurrentContext = sel_registerName("clearCurrentContext"u8);
        internal static readonly SEL selCurrentContext = sel_registerName("currentContext"u8);
        internal static readonly SEL selMakeCurrentContext = sel_registerName("makeCurrentContext"u8);
        internal static readonly SEL selClearDrawable = sel_registerName("clearDrawable"u8);
        internal static readonly SEL selFlushBuffer = sel_registerName("flushBuffer"u8);
        internal static readonly SEL selSetValues_ForParameter = sel_registerName("setValues:forParameter:"u8);

        internal static readonly IntPtr opengl = LoadLibrary("/System/Library/Frameworks/OpenGl.framework/OpenGL"u8, true);

        internal static Dictionary<IntPtr, NSOpenGLContext> NSOpenGLContextDict = new Dictionary<nint, NSOpenGLContext>();

        /// <inheritdoc/>
        public string Name => nameof(MacOSOpenGLComponent);

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.OpenGL;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        /// <inheritdoc/>
        public void Initialize(ToolkitOptions options)
        {
            // FIXME: Do something?
        }

        /// <inheritdoc/>
        public void Uninitialize()
        {
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

        internal void GetContextValuesFromCGLPixelFormatObj(IntPtr pixelFormatObj, out ContextValues values)
        {
            CGL.CGLDescribePixelFormat(pixelFormatObj, 0, CGLPixelFormatAttribute.kCGLPFAColorSize, out int colorSize);
            CGL.CGLDescribePixelFormat(pixelFormatObj, 0, CGLPixelFormatAttribute.kCGLPFAAlphaSize, out int alphaSize);
            CGL.CGLDescribePixelFormat(pixelFormatObj, 0, CGLPixelFormatAttribute.kCGLPFADepthSize, out int depthSize);
            CGL.CGLDescribePixelFormat(pixelFormatObj, 0, CGLPixelFormatAttribute.kCGLPFAStencilSize, out int stencilSize);
            CGL.CGLDescribePixelFormat(pixelFormatObj, 0, CGLPixelFormatAttribute.kCGLPFASamples, out int samples);
            CGL.CGLDescribePixelFormat(pixelFormatObj, 0, CGLPixelFormatAttribute.kCGLPFADoubleBuffer, out int hasDoubleBuffer);
            CGL.CGLDescribePixelFormat(pixelFormatObj, 0, CGLPixelFormatAttribute.kCGLPFAColorFloat, out int colorFloat);
            CGL.CGLDescribePixelFormat(pixelFormatObj, 0, CGLPixelFormatAttribute.kCGLPFABackingStore, out int hasBackingStore);

            // FIXME: change ID to ulong?
            values.ID = (ulong)pixelFormatObj;
            values.RedBits = (colorSize - alphaSize) / 3;
            values.GreenBits = (colorSize - alphaSize) / 3;
            values.BlueBits = (colorSize - alphaSize) / 3;
            values.AlphaBits = alphaSize;
            values.DepthBits = depthSize;
            values.StencilBits = stencilSize;
            values.DoubleBuffered = hasDoubleBuffer == 1;
            values.SRGBFramebuffer = false;
            values.PixelFormat = (colorFloat == 1) ? ContextPixelFormat.RGBAFloat : ContextPixelFormat.RGBA;
            values.SwapMethod = (hasBackingStore == 1) ? ContextSwapMethod.Copy : ContextSwapMethod.Undefined;
            // FIXME: Maybe querying samples is not enough...
            values.Samples = samples;
            values.SupportsFramebufferTransparency = true;
        }

        internal void EnumerateContextValues(List<ContextValues> options, CGLOpenGLProfile profile)
        {
            HashSet<ContextValues> optionsSet = new HashSet<ContextValues>();
            {
                Span<int> attribs = stackalloc int[12 + 4 + 3 + 1 + 1];

                // RGBA8 (32), RGB10A2 (32), RGBA16F (64), RGBA32F (128)
                ReadOnlySpan<(int colorBits, int alphaBits)> colorAlphaBits = stackalloc (int, int)[4] { (32, 8), (32, 2), (64, 16), (128, 32) };
                ReadOnlySpan<(int depthBits, int stencilBits)> depthStencilBits = stackalloc (int, int)[7] { (0, 0), (16, 0), (16, 8), (24, 0), (24, 8), (32, 0), (32, 8) };
                ReadOnlySpan<int> msaaSamples = stackalloc int[7] { 0, 2, 4, 6, 8, 16, 32 };
                ReadOnlySpan<bool> doubleBuffer = stackalloc bool[2] { false, true };
                ReadOnlySpan<bool> pixelFormatFloat = stackalloc bool[2] { false, true };
                ReadOnlySpan<bool> backingStore = stackalloc bool[2] { false, true };
                for (int cai = 0; cai < colorAlphaBits.Length; cai++)
                {
                    for (int dsi = 0; dsi < depthStencilBits.Length; dsi++)
                    {
                        for (int msi = 0; msi < msaaSamples.Length; msi++)
                        {
                            for (int dbi = 0; dbi < doubleBuffer.Length; dbi++)
                            {
                                for (int pffi = 0; pffi < pixelFormatFloat.Length; pffi++)
                                {
                                    for (int bsi = 0; bsi < backingStore.Length; bsi++)
                                    {
                                        int length = 0;

                                        attribs[length++] = (int)CGLPixelFormatAttribute.kCGLPFAAccelerated;
                                        if (profile == CGLOpenGLProfile.kCGLOGLPVersion_Legacy)
                                        {
                                            attribs[length++] = (int)CGLPixelFormatAttribute.kCGLPFAWindow;
                                        }
                                        attribs[length++] = (int)CGLPixelFormatAttribute.kCGLPFAOpenGLProfile;
                                        attribs[length++] = (int)profile;

                                        attribs[length++] = (int)CGLPixelFormatAttribute.kCGLPFAColorSize;
                                        attribs[length++] = colorAlphaBits[cai].colorBits;

                                        attribs[length++] = (int)CGLPixelFormatAttribute.kCGLPFAAlphaSize;
                                        attribs[length++] = colorAlphaBits[cai].alphaBits;

                                        attribs[length++] = (int)CGLPixelFormatAttribute.kCGLPFADepthSize;
                                        attribs[length++] = depthStencilBits[dsi].depthBits;

                                        attribs[length++] = (int)CGLPixelFormatAttribute.kCGLPFAStencilSize;
                                        attribs[length++] = depthStencilBits[dsi].stencilBits;

                                        if (msaaSamples[msi] > 0)
                                        {
                                            attribs[length++] = (int)CGLPixelFormatAttribute.kCGLPFASampleBuffers;
                                            attribs[length++] = 1;

                                            attribs[length++] = (int)CGLPixelFormatAttribute.kCGLPFASamples;
                                            attribs[length++] = msaaSamples[msi];
                                        }

                                        if (doubleBuffer[dbi])
                                        {
                                            attribs[length++] = (int)CGLPixelFormatAttribute.kCGLPFADoubleBuffer;
                                        }

                                        if (pixelFormatFloat[pffi])
                                        {
                                            // 8 bpp can't be float
                                            if (colorAlphaBits[cai].colorBits < 64)
                                                continue;

                                            attribs[length++] = (int)CGLPixelFormatAttribute.kCGLPFAColorFloat;
                                        }

                                        if (backingStore[bsi])
                                        {
                                            attribs[length++] = (int)CGLPixelFormatAttribute.kCGLPFABackingStore;
                                        }

                                        attribs[length++] = (int)CGLPixelFormatAttribute.kCGLPFAMaximumPolicy;

                                        // Terminate the list
                                        attribs[length] = 0;

                                        unsafe
                                        {
                                            IntPtr pixFormat;
                                            int npix;
                                            fixed (int* attribsPtr = attribs)
                                            {
                                                CGLError error = CGL.CGLChoosePixelFormat((CGLPixelFormatAttribute*)attribsPtr, out pixFormat, out npix);
                                                if (error != CGLError.kCGLNoError)
                                                {
                                                    continue;
                                                }
                                            }

                                            if (pixFormat == 0)
                                            {
                                                continue;
                                            }

                                            // FIXME: The pixel format could be different for every virtual screen...
                                            CGL.CGLDescribePixelFormat(pixFormat, 0, CGLPixelFormatAttribute.kCGLPFAAccelerated, out int accelerated);
                                            if (accelerated == 0)
                                            {
                                                continue;
                                            }
                                            if (profile == CGLOpenGLProfile.kCGLOGLPVersion_Legacy)
                                            {
                                                CGL.CGLDescribePixelFormat(pixFormat, 0, CGLPixelFormatAttribute.kCGLPFAWindow, out int window);
                                                if (window == 0)
                                                {
                                                    continue;
                                                }
                                            }

                                            GetContextValuesFromCGLPixelFormatObj(pixFormat, out ContextValues option);

                                            // Deduplicate using optionsSet.
                                            if (optionsSet.Add(option))
                                            {
                                                Logger?.LogDebug(option.ToString());
                                                options.Add(option);
                                            }
                                            else
                                            {
                                                CGL.CGLReleasePixelFormat(pixFormat);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

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

            int depthBits;
            switch (settings.DepthBits)
            {
                case ContextDepthBits.None: depthBits = 0; break;
                case ContextDepthBits.Depth16: depthBits = 16; break;
                case ContextDepthBits.Depth24: depthBits = 24; break;
                case ContextDepthBits.Depth32: depthBits = 32; break;
                default: throw new InvalidEnumArgumentException(nameof(settings.DepthBits), (int)settings.DepthBits, settings.DepthBits.GetType());
            }

            int stencilBits;
            switch (settings.StencilBits)
            {
                case ContextStencilBits.None: stencilBits = 0; break;
                case ContextStencilBits.Stencil1: stencilBits = 1; break;
                case ContextStencilBits.Stencil8: stencilBits = 8; break;
                default: throw new InvalidEnumArgumentException(nameof(settings.StencilBits), (int)settings.StencilBits, settings.StencilBits.GetType());
            }

            NSOpenGLProfileVersion profileVersion = NSOpenGLProfileVersion.Legacy;
            CGLOpenGLProfile cglProfile = CGLOpenGLProfile.kCGLOGLPVersion_Legacy;
            if (settings.Version.Major > 4 || (settings.Version.Major >= 4 && settings.Version.Minor >= 1))
            {
                profileVersion = NSOpenGLProfileVersion.Version4_1Core;
                cglProfile = CGLOpenGLProfile.kCGLOGLPVersion_GL4_Core;
            }
            else if (settings.Version.Major > 3 || (settings.Version.Major >= 3 && settings.Version.Minor >= 2))
            {
                profileVersion = NSOpenGLProfileVersion.Version3_2Core;
                cglProfile = CGLOpenGLProfile.kCGLOGLPVersion_GL3_Core;
            }

            IntPtr pixelFormat;
            if (settings.UseSelectorOnMacOS)
            {
                ContextValues requested;
                requested.ID = 0;
                requested.RedBits = settings.RedColorBits;
                requested.GreenBits = settings.GreenColorBits;
                requested.BlueBits = settings.BlueColorBits;
                requested.AlphaBits = settings.AlphaColorBits;
                requested.DepthBits = depthBits;
                requested.StencilBits = stencilBits;
                requested.DoubleBuffered = settings.DoubleBuffer;
                requested.SRGBFramebuffer = settings.sRGBFramebuffer;
                requested.PixelFormat = settings.PixelFormat;
                requested.SwapMethod = settings.SwapMethod;
                requested.Samples = settings.Multisamples;
                requested.SupportsFramebufferTransparency = true;

                List<ContextValues> options = new List<ContextValues>();
                Stopwatch watch = Stopwatch.StartNew();
                EnumerateContextValues(options, cglProfile);
                watch.Stop();
                Logger?.LogDebug($"Enumerating ContextValues took: {watch.Elapsed.TotalSeconds}s");

                int index = settings.Selector(options, requested, Logger);
                if (index < 0 || index >= options.Count)
                {
                    throw new IndexOutOfRangeException($"The selected format index ({index}) is outside the range of valid indices. This is either an OpenTK bug or an issue with your custom ContextValueSelector.");
                }

                pixelFormat = objc_msgSend_IntPtr((IntPtr)NSOpenGLPixelFormatClass, Alloc);
                pixelFormat = objc_msgSend_IntPtr(pixelFormat, selInitWithCGLPixelFormatObj, (IntPtr)options[index].ID);

                IntPtr format = objc_msgSend_IntPtr(pixelFormat, selCGLPixelFormatObj);
                GetContextValuesFromCGLPixelFormatObj(format, out ContextValues selected);

                // Release all pixel formats, the one we selected is retained by the NSOpenGLPixelFormat object.
                for (int i = 0; i < options.Count; i++)
                {
                    CGL.CGLReleasePixelFormat((IntPtr)options[i].ID);
                }
            }
            else
            {
                List<NSOpenGLPixelFormatAttribute> attributes = new List<NSOpenGLPixelFormatAttribute>();
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
                    attributes.Add(NSOpenGLPixelFormatAttribute.DepthSize);
                    attributes.Add((NSOpenGLPixelFormatAttribute)depthBits);
                }

                if (settings.StencilBits != ContextStencilBits.None)
                {
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

                attributes.Add(0);

                pixelFormat = objc_msgSend_IntPtr((IntPtr)NSOpenGLPixelFormatClass, Alloc);

                fixed (NSOpenGLPixelFormatAttribute* attributePtr = CollectionsMarshal.AsSpan(attributes))
                {
                    pixelFormat = objc_msgSend_IntPtr(pixelFormat, selInitWithAttributes, (IntPtr)attributePtr);
                }

                if (pixelFormat == IntPtr.Zero)
                {
                    // FIXME: Better error message!
                    throw new PalException(this, $"Failed to create pixel format matching settings.");
                }
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

            // If we've set the framebuffer to be transparent before we 
            // created the context we need to make the context transparent.
            // - Noggin_bops 2024-11-02
            if (nswindow.TransparencyMode == WindowTransparencyMode.TransparentFramebuffer)
            {
                int opaque = 0;
                objc_msgSend(nswindow.Context.Context, selSetValues_ForParameter, (IntPtr)(&opaque), (long)NSOpenGLContextParameter.SurfaceOpacity);
            }

            // Release the pixelFormat
            objc_msgSend(pixelFormat, Release);

            objc_msgSend(context, selSetView, nswindow.View);
            // FIXME: BOOL
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
                objc_msgSend(nscontext.Context, selSetValues_ForParameter, (IntPtr)(&interval), (long)NSOpenGLContextParameter.SwapInterval);
            }
        }

        /// <inheritdoc/>
        public int GetSwapInterval()
        {
            NSOpenGLContext? nscontext = (NSOpenGLContext?)GetCurrentContext();

            int interval = default;
            if (nscontext != null)
            {
                objc_msgSend(nscontext.Context, selSetValues_ForParameter, (IntPtr)(&interval), (long)NSOpenGLContextParameter.SwapInterval);
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

