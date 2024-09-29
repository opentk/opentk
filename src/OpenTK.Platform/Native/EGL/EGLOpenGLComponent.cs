using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using OpenTK.Core.Utility;
using OpenTK.Graphics.Egl;
using OpenTK.Platform.Native.ANGLE;

namespace OpenTK.Platform.Native.EGL
{
    public class EGLOpenGLComponent : IOpenGLComponent
    {
        /// <inheritdoc/>
        public string Name => nameof(EGLOpenGLComponent);

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.OpenGL;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        internal string[] Extensions;

        internal IntPtr eglDisplay;
        internal Version eglVersion;

        internal static readonly Dictionary<IntPtr, EGLOpenGLContextHandle> ContextDict = new Dictionary<IntPtr, EGLOpenGLContextHandle>();

        /// <inheritdoc/>
        public void Initialize(ToolkitOptions options)
        {
            const IntPtr EGL_NO_DISPLAY = 0;
            IntPtr extensionsPtr = Egl.QueryString(EGL_NO_DISPLAY, Egl.EXTENSIONS);
            string extensionsStr = Marshal.PtrToStringAnsi(extensionsPtr)!;
            Extensions = extensionsStr.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Logger?.LogDebug($"EGL extensions: {string.Join(", ", Extensions)}");

            eglDisplay = Egl.GetDisplay(Egl.DEFAULT_DISPLAY);

            bool success = Egl.Initialize(eglDisplay, out int major, out int minor);
            if (success == false)
            {
                ErrorCode error = Egl.GetError();
                throw new PalException(this, $"EGL couldn't initialize successfully. {error}");
            }

            eglVersion = new Version(major, minor);

            // FIXME
            Egl.BindAPI(RenderApi.ES);
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
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public unsafe OpenGLContextHandle CreateFromWindow(WindowHandle handle)
        {
            // We have to send a Window* to egl, so we need a local variable we can store the Window in
            // so we can take the pointer to this variable.
            // - Noggin_bops 2024-03-07
            IntPtr xwin = ((IntPtr?)(handle as X11.XWindowHandle)?.Window.Id) ?? 0;

            // FIXME: Can we use an SDL window to create an ANGLE context?
            IntPtr windowHandle = handle switch
            {
                Windows.HWND hwnd => hwnd.HWnd,
                X11.XWindowHandle => (IntPtr)(&xwin),
                macOS.NSWindowHandle nswindow => nswindow.Window,

                _ => throw new PlatformNotSupportedException($"OpenTK doesn't support creating an ANGLE context using {handle.GetType()}.")
            };

            EGLGraphicsApiHints? settings = handle.GraphicsApiHints as EGLGraphicsApiHints;
            if (settings == null)
            {
                // FIXME: Exception message
                throw new PalException(this, "Window has no graphics settings.");
            }

            bool success = Egl.GetConfigs(eglDisplay, null, 0, out int numConfigs);
            IntPtr[] availableConfigs = new IntPtr[numConfigs];
            success = Egl.GetConfigs(eglDisplay, availableConfigs, numConfigs, out numConfigs);

            List<ContextValues> possibleContextValues = new List<ContextValues>();
            for (int i = 0; i < numConfigs; i++)
            {
                IntPtr config = availableConfigs[i];

                // We only want configs that can render to a window.
                Egl.GetConfigAttrib(eglDisplay, config, Egl.SURFACE_TYPE, out int configSupportedSurfaceTypes);
                if ((configSupportedSurfaceTypes & Egl.WINDOW_BIT) == 0)
                    continue;

                Egl.GetConfigAttrib(eglDisplay, config, Egl.RENDERABLE_TYPE, out int renderableType);
                if ((renderableType & Egl.OPENGL_ES_BIT) == 0 &&
                    (renderableType & Egl.OPENGL_ES2_BIT) == 0 &&
                    (renderableType & Egl.OPENGL_ES3_BIT) == 0)
                {
                    continue;
                }

                Egl.GetConfigAttrib(eglDisplay, config, Egl.RED_SIZE, out int configRedBits);
                Egl.GetConfigAttrib(eglDisplay, config, Egl.GREEN_SIZE, out int configGreenBits);
                Egl.GetConfigAttrib(eglDisplay, config, Egl.BLUE_SIZE, out int configBlueBits);
                Egl.GetConfigAttrib(eglDisplay, config, Egl.ALPHA_SIZE, out int configAlphaBits);
                Egl.GetConfigAttrib(eglDisplay, config, Egl.DEPTH_SIZE, out int configDepthBits);
                Egl.GetConfigAttrib(eglDisplay, config, Egl.STENCIL_SIZE, out int configStencilBits);
                Egl.GetConfigAttrib(eglDisplay, config, Egl.SAMPLES, out int configSamples);

                ContextValues values;
                values.ID = (ulong)config;
                values.RedBits = configRedBits;
                values.GreenBits = configGreenBits;
                values.BlueBits = configBlueBits;
                values.AlphaBits = configAlphaBits;
                values.DepthBits = configDepthBits;
                values.StencilBits = configStencilBits;
                // FIXME: Add two values one with double buffering, and one without.
                // We don't seem to be able to guarantee double buffering when using EGL.
                // - Noggin_bops 2024-07-21
                values.DoubleBuffered = true;
                // FIXME: This is something we can only set for the surface attributes
                // so we can't really know this property either...
                // - Noggin_bops 2024-07-21
                values.SRGBFramebuffer = false;
                // FIXME: Potentially use EGL_KHR_gl_colorspace with EGL_EXT_gl_colorspace_bt2020_linear
                // to query this. But these extensions are currently not supported on ANGLE so it's
                // not that important.
                // - Noggin_bops 2024-07-21
                values.PixelFormat = ContextPixelFormat.RGBA;
                // With eglSurfaceAttrib it's possible for us to set the swap method of the
                // surface, but this would have to be done after we've created the surface
                // so we couldn't really guarantee it's available. For now we just say undefined.
                // - Noggin_bops 2024-07-22
                values.SwapMethod = ContextSwapMethod.Undefined;
                values.Samples = configSamples;

                possibleContextValues.Add(values);
            }


            int depthBits;
            switch (settings.DepthBits)
            {
                case ContextDepthBits.Depth24: depthBits = 24; break;
                case ContextDepthBits.Depth32: depthBits = 32; break;
                default: throw new InvalidEnumArgumentException(nameof(settings.DepthBits), (int)settings.DepthBits, settings.DepthBits.GetType());
            }

            int stencilBits;
            switch (settings.StencilBits)
            {
                case ContextStencilBits.Stencil1: stencilBits = 1; break;
                case ContextStencilBits.Stencil8: stencilBits = 8; break;
                default: throw new InvalidEnumArgumentException(nameof(settings.StencilBits), (int)settings.StencilBits, settings.StencilBits.GetType());
            }

            ContextValues requested = new ContextValues();
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

            int selectedFormatIndex = settings.Selector(possibleContextValues, requested, Logger);
            if (selectedFormatIndex < 0 || selectedFormatIndex >= possibleContextValues.Count)
            {
                throw new IndexOutOfRangeException($"The selected format index ({selectedFormatIndex}) is outside the range of valid indices. This is either an OpenTK bug or an issue with your custom ContextValueSelector.");
            }

            IntPtr selectedConfig = (IntPtr)possibleContextValues[selectedFormatIndex].ID;

            List<int> surface_attribs_list = new List<int>();
            surface_attribs_list.Add(Egl.RENDER_BUFFER);
            surface_attribs_list.Add(settings.DoubleBuffer ? Egl.BACK_BUFFER : Egl.SINGLE_BUFFER);

            // ANGLE doesn't support COLORSPACE option.
            if (!settings.IsAngle)
            {
                surface_attribs_list.Add(Egl.COLORSPACE);
                surface_attribs_list.Add(settings.sRGBFramebuffer ? Egl.COLORSPACE_sRGB : Egl.COLORSPACE_LINEAR);
            }

            surface_attribs_list.Add(Egl.NONE);

            int[] structure_attribs = surface_attribs_list.ToArray();

            IntPtr eglSurface;
            fixed (int* structure_attribs_ptr = structure_attribs)
            {
                eglSurface = Egl.CreateWindowSurface(eglDisplay, selectedConfig, windowHandle, (IntPtr)structure_attribs_ptr);
                if (eglSurface == IntPtr.Zero)
                {
                    throw new PalException(this, $"Was not able to create egl surface. {Egl.GetError()}");
                }
            }

            // FIXME: Share context
            List<int> context_attribs = new List<int>() { Egl.CONTEXT_MAJOR_VERSION, settings.Version.Major, Egl.CONTEXT_MINOR_VERSION, settings.Version.Minor };
            if (settings.DebugFlag)
            {
                context_attribs.Add(Egl.CONTEXT_OPENGL_DEBUG);
                context_attribs.Add(1);
            }

            context_attribs.Add(Egl.NONE);

            EGLOpenGLContextHandle? shared = settings.SharedContext?.As<EGLOpenGLContextHandle>(this);
            IntPtr shareContext = shared?.EglContext ?? IntPtr.Zero;

            IntPtr contextPtr = Egl.CreateContext(eglDisplay, selectedConfig, shareContext, context_attribs.ToArray());

            EGLOpenGLContextHandle context = new EGLOpenGLContextHandle(eglSurface, contextPtr, shared);

            ContextDict.Add(contextPtr, context);

            return context;
        }

        public void DestroyContext(OpenGLContextHandle handle)
        {
            EGLOpenGLContextHandle context = handle.As<EGLOpenGLContextHandle>(this);

            ContextDict.Remove(context.EglContext);

            bool success = Egl.DestroyContext(eglDisplay, context.EglContext);
            if (success == false)
            {
                Logger?.LogError($"Failed to destroy egl context: {Egl.GetError()}");
            }

            success = Egl.DestroySurface(eglDisplay, context.EglSurface);
            if (success == false)
            {
                Logger?.LogError($"Failed to destroy egl surface: {Egl.GetError()}");
            }
        }

        /// <inheritdoc/>
        public IBindingsContext GetBindingsContext(OpenGLContextHandle handle)
        {
            EGLOpenGLContextHandle context = handle.As<EGLOpenGLContextHandle>(this);
            return new Pal2BindingsContext(this, context);
        }

        /// <inheritdoc/>
        public IntPtr GetProcedureAddress(OpenGLContextHandle handle, string procedureName)
        {
            return Egl.GetProcAddress(procedureName);
        }

        /// <inheritdoc/>
        public OpenGLContextHandle? GetCurrentContext()
        {
            IntPtr ptr = Egl.GetCurrentContext();
            if (ptr == IntPtr.Zero)
            {
                return null;
            }
            else
            {
                return ContextDict[ptr];
            }
        }

        /// <inheritdoc/>
        public bool SetCurrentContext(OpenGLContextHandle? handle)
        {
            EGLOpenGLContextHandle? context = handle?.As<EGLOpenGLContextHandle>(this);
            if (context != null)
            {
                return Egl.MakeCurrent(eglDisplay, context.EglSurface, context.EglSurface, context.EglContext);
            }
            else
            {
                return Egl.MakeCurrent(eglDisplay, Egl.NO_SURFACE, Egl.NO_SURFACE, Egl.NO_CONTEXT);
            }
        }

        /// <inheritdoc/>
        public OpenGLContextHandle? GetSharedContext(OpenGLContextHandle handle)
        {
            EGLOpenGLContextHandle context = handle.As<EGLOpenGLContextHandle>(this);
            return context.SharedContext;
        }

        private int swapInterval = 1;

        /// <inheritdoc/>
        public void SetSwapInterval(int interval)
        {
            Egl.SwapInterval(eglDisplay, interval);
            swapInterval = interval;
        }

        /// <inheritdoc/>
        public int GetSwapInterval()
        {
            return swapInterval;
        }

        /// <inheritdoc/>
        public void SwapBuffers(OpenGLContextHandle handle)
        {
            EGLOpenGLContextHandle context = handle.As<EGLOpenGLContextHandle>(this);
            Egl.SwapBuffers(eglDisplay, context.EglSurface);
        }

        /// <summary>
        /// Returns the <c>EGLDisplay</c> used by OpenTK.
        /// </summary>
        /// <returns>The <c>EGLDisplay</c> used by OpenTK.</returns>
        public IntPtr GetEglDisplay()
        {
            return eglDisplay;
        }

        /// <summary>
        /// Returns the <c>EGLContext</c> associated with the specified context handle.
        /// </summary>
        /// <param name="handle">A handle to an OpenGL context to get the associated <c>EGLContext</c> from.</param>
        /// <returns>The <c>EGLContext</c> associated with the context handle.</returns>
        public IntPtr GetEglContext(OpenGLContextHandle handle)
        {
            ANGLEOpenGLContextHandle context = handle.As<ANGLEOpenGLContextHandle>(this);

            return context.EglContext;
        }

        /// <summary>
        /// Returns the <c>EGLSurface</c> associated with the specified context handle.
        /// </summary>
        /// <param name="handle">A handle to an OpenGL context to get the associated <c>EGLSurface</c> from.</param>
        /// <returns>The <c>EGLSurface</c> associated with the context handle.</returns>
        public IntPtr GetEglSurface(OpenGLContextHandle handle)
        {
            ANGLEOpenGLContextHandle context = handle.As<ANGLEOpenGLContextHandle>(this);

            return context.EglSurface;
        }
    }
}
