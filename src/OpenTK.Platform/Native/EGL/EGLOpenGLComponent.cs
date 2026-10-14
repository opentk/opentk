using System;
using System.Collections.Generic;
using System.ComponentModel;
using OpenTK.Core.Utility;
using OpenTK.Graphics.Egl;

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

        internal EGLDisplay eglDisplay;
        internal Version eglVersion;

        internal static readonly Dictionary<EGLContext, EGLOpenGLContextHandle> ContextDict = new Dictionary<EGLContext, EGLOpenGLContextHandle>();

        /// <inheritdoc/>
        public void Initialize(ToolkitOptions options)
        {
            string? extensions = Egl.QueryString(EGLDisplay.NoDisplay, StringName.Extensions);
            if (extensions == null)
                throw new PalException(this, "EGL extensions string could not be retrieved.");

            Extensions = extensions.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Logger?.LogDebug($"EGL extensions: {string.Join(", ", Extensions)}");

            eglDisplay = Egl.GetDisplay(IntPtr.Zero);
            if (eglDisplay.Value == IntPtr.Zero)
            {
                var error = Egl.GetError();
                throw new PalException(this, $"EGL couldn't get a display. {error}");
            }

            bool success = Egl.Initialize(eglDisplay, out int major, out int minor);
            if (success == false)
            {
                ErrorCode error = Egl.GetError();
                throw new PalException(this, $"EGL couldn't initialize successfully. {error}");
            }

            eglVersion = new Version(major, minor);

            // FIXME
            Egl.BindAPI(RenderApi.OpenglEsApi);
        }

        /// <inheritdoc/>
        public void Uninitialize()
        {
            Egl.Terminate(eglDisplay);
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

            // FIXME: Can we use an SDL window to create an EGL context?
            IntPtr windowHandle = handle switch
            {
                Windows.HWND hwnd => hwnd.HWnd,
                X11.XWindowHandle => (IntPtr)(&xwin),
                macOS.NSWindowHandle nswindow => nswindow.Window,

                _ => throw new PlatformNotSupportedException($"OpenTK doesn't support creating an EGL context using {handle.GetType()}.")
            };

            EGLGraphicsApiHints? settings = handle.GraphicsApiHints as EGLGraphicsApiHints;
            if (settings == null)
            {
                // FIXME: Exception message
                throw new PalException(this, "Window has no graphics settings.");
            }

            bool success = Egl.GetConfig(eglDisplay, null, 0, out int numConfigs);
            EGLConfig[] availableConfigs = new EGLConfig[numConfigs];
            success = Egl.GetConfig(eglDisplay, availableConfigs, numConfigs, out numConfigs);

            List<ContextValues> possibleContextValues = new List<ContextValues>();
            for (int i = 0; i < numConfigs; i++)
            {
                EGLConfig config = availableConfigs[i];

                // We only want configs that can render to a window.
                Egl.GetConfigAttrib(eglDisplay, config, ConfigAttribute.SurfaceType, out int configSupportedSurfaceTypes);
                if (((SurfaceTypeMask)configSupportedSurfaceTypes & SurfaceTypeMask.WindowBit) == 0)
                    continue;

                Egl.GetConfigAttrib(eglDisplay, config, ConfigAttribute.RenderableType, out int renderableType);
                if (((RenderableTypeMask)renderableType & RenderableTypeMask.OpenglEsBit) == 0 &&
                    ((RenderableTypeMask)renderableType & RenderableTypeMask.OpenglEs2Bit) == 0 &&
                    ((RenderableTypeMask)renderableType & RenderableTypeMask.OpenglEs3Bit) == 0)
                {
                    continue;
                }

                Egl.GetConfigAttrib(eglDisplay, config, ConfigAttribute.RedSize, out int configRedBits);
                Egl.GetConfigAttrib(eglDisplay, config, ConfigAttribute.GreenSize, out int configGreenBits);
                Egl.GetConfigAttrib(eglDisplay, config, ConfigAttribute.BlueSize, out int configBlueBits);
                Egl.GetConfigAttrib(eglDisplay, config, ConfigAttribute.AlphaSize, out int configAlphaBits);
                Egl.GetConfigAttrib(eglDisplay, config, ConfigAttribute.DepthSize, out int configDepthBits);
                Egl.GetConfigAttrib(eglDisplay, config, ConfigAttribute.StencilSize, out int configStencilBits);
                Egl.GetConfigAttrib(eglDisplay, config, ConfigAttribute.Samples, out int configSamples);

                ContextValues values;
                values.ID = (ulong)(nint)config;
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
                values.SupportsFramebufferTransparency = false;
                // EGL 1.5 nor any extensions specify how to create or query support for stereo display.
                // - Noggin_bops 2025-08-11
                values.Stereo = false;

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
            requested.SupportsFramebufferTransparency = settings.SupportTransparentFramebufferX11;
            requested.Stereo = settings.Stereo;

            int selectedFormatIndex = settings.Selector(possibleContextValues, requested, Logger);
            if (selectedFormatIndex < 0 || selectedFormatIndex >= possibleContextValues.Count)
            {
                throw new IndexOutOfRangeException($"The selected format index ({selectedFormatIndex}) is outside the range of valid indices. This is either an OpenTK bug or an issue with your custom ContextValueSelector.");
            }

            EGLConfig selectedConfig = new EGLConfig((nint)possibleContextValues[selectedFormatIndex].ID);
            ContextValues chosenValues = possibleContextValues[selectedFormatIndex];

            List<int> surface_attribs_list = new List<int>();
            surface_attribs_list.Add((int)SurfaceCreateAttribute.RenderBuffer);
            surface_attribs_list.Add(settings.DoubleBuffer ? (int)RenderBuffer.BackBuffer : (int)RenderBuffer.SingleBuffer);

            // ANGLE doesn't support COLORSPACE option.
            if (!settings.IsAngle)
            {
                surface_attribs_list.Add((int)SurfaceCreateAttribute.GlColorspaceKhr);
                surface_attribs_list.Add(settings.sRGBFramebuffer ? (int)All.GlColorspaceSrgb : (int)All.GlColorspaceLinear);
            }

            surface_attribs_list.Add((int)SurfaceAttribute.None);

            EGLSurface eglSurface = Egl.CreateWindowSurface(eglDisplay, selectedConfig, windowHandle, surface_attribs_list.ToArray());
            if (eglSurface == EGLSurface.NoSurface)
            {
                var error = Egl.GetError();
                throw new PalException(this, $"Was not able to create egl surface. {error}");
            }

            // FIXME: Share context
            List<int> context_attribs = new List<int>() { (int)ContextAttribute.ContextMajorVersion, settings.Version.Major, (int)ContextAttribute.ContextMinorVersion, settings.Version.Minor };
            if (settings.DebugFlag)
            {
                context_attribs.Add((int)ContextAttribute.ContextOpenglDebug);
                context_attribs.Add(1);
            }

            context_attribs.Add((int)ContextAttribute.None);

            EGLOpenGLContextHandle? shared = settings.SharedContext?.As<EGLOpenGLContextHandle>(this);
            EGLContext shareContext = shared?.EglContext ?? EGLContext.NoContext;

            EGLContext contextPtr = Egl.CreateContext(eglDisplay, selectedConfig, shareContext, context_attribs.ToArray());

            EGLOpenGLContextHandle context = new EGLOpenGLContextHandle(eglSurface, contextPtr, handle, shared, chosenValues);

            ContextDict.Add(contextPtr, context);

            handle.OpenGLContextHandle = context;

            return context;
        }

        public void DestroyContext(OpenGLContextHandle handle)
        {
            EGLOpenGLContextHandle context = handle.As<EGLOpenGLContextHandle>(this);

            ContextDict.Remove(context.EglContext);

            if (context.WindowHandle != null)
            {
                context.WindowHandle.OpenGLContextHandle = null;
            }

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
        public ContextValues GetContextValues(OpenGLContextHandle handle)
        {
            EGLOpenGLContextHandle context = handle.As<EGLOpenGLContextHandle>(this);

            return context.ContextValues;
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
            EGLContext ptr = Egl.GetCurrentContext();
            if (ptr == EGLContext.NoContext)
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
                return Egl.MakeCurrent(eglDisplay, EGLSurface.NoSurface, EGLSurface.NoSurface, EGLContext.NoContext);
            }
        }

        /// <inheritdoc/>
        public OpenGLContextHandle? GetSharedContext(OpenGLContextHandle handle)
        {
            EGLOpenGLContextHandle context = handle.As<EGLOpenGLContextHandle>(this);
            return context.SharedContext;
        }

        /// <inheritdoc/>
        public void SetSwapInterval(int interval)
        {
            EGLOpenGLContextHandle? context = GetCurrentContext()?.As<EGLOpenGLContextHandle>(this);
            if (context != null)
            {
                Egl.SwapInterval(eglDisplay, interval);
                context.SwapInterval = interval;
            }
            else
            {
                Logger?.LogWarning("No context current on the calling thread, can't set swap interval.");
            }
        }

        /// <inheritdoc/>
        public int GetSwapInterval()
        {
            EGLOpenGLContextHandle? context = GetCurrentContext()?.As<EGLOpenGLContextHandle>(this);
            return context?.SwapInterval ?? -1;
        }

        /// <inheritdoc/>
        public void SwapBuffers(OpenGLContextHandle handle)
        {
            EGLOpenGLContextHandle context = handle.As<EGLOpenGLContextHandle>(this);
            bool success = Egl.SwapBuffers(eglDisplay, context.EglSurface);
            if (success == false)
            {
                Logger?.LogWarning($"Unable to swap buffers: {Egl.GetError()}");
            }
        }

        /// <inheritdoc/>
        public WindowHandle? GetWindow(OpenGLContextHandle handle)
        {
            EGLOpenGLContextHandle context = handle.As<EGLOpenGLContextHandle>(this);
            return context.WindowHandle;
        }

        /// <summary>
        /// Returns the <c>EGLDisplay</c> used by OpenTK.
        /// </summary>
        /// <returns>The <c>EGLDisplay</c> used by OpenTK.</returns>
        public EGLDisplay GetEglDisplay()
        {
            return eglDisplay;
        }

        /// <summary>
        /// Returns the <c>EGLContext</c> associated with the specified context handle.
        /// </summary>
        /// <param name="handle">A handle to an OpenGL context to get the associated <c>EGLContext</c> from.</param>
        /// <returns>The <c>EGLContext</c> associated with the context handle.</returns>
        public EGLContext GetEglContext(OpenGLContextHandle handle)
        {
            EGLOpenGLContextHandle context = handle.As<EGLOpenGLContextHandle>(this);

            return context.EglContext;
        }

        /// <summary>
        /// Returns the <c>EGLSurface</c> associated with the specified context handle.
        /// </summary>
        /// <param name="handle">A handle to an OpenGL context to get the associated <c>EGLSurface</c> from.</param>
        /// <returns>The <c>EGLSurface</c> associated with the context handle.</returns>
        public EGLSurface GetEglSurface(OpenGLContextHandle handle)
        {
            EGLOpenGLContextHandle context = handle.As<EGLOpenGLContextHandle>(this);

            return context.EglSurface;
        }
    }
}
