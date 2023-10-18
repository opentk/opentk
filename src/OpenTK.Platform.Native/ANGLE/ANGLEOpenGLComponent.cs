﻿using OpenTK.Core.Platform;
using OpenTK.OpenGL.Egl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using OpenTK.Core;
using OpenTK.Core.Platform.Enums;
using OpenTK.Core.Platform.Handles;
using OpenTK.Core.Platform.Interfaces;

namespace OpenTK.Platform.Native.ANGLE
{
    public class ANGLEOpenGLComponent : IOpenGLComponent
    {
        /// <inheritdoc/>
        public string Name => nameof(ANGLEOpenGLComponent);

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.OpenGL;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        internal string[] Extensions;

        internal IntPtr eglDisplay;
        internal Version eglVersion;

        internal static readonly Dictionary<IntPtr, ANGLEOpenGLContextHandle> ContextDict = new Dictionary<IntPtr, ANGLEOpenGLContextHandle>();

        /// <inheritdoc/>
        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.OpenGL)
            {
                throw new Exception("ANGLEOpenGLComponent can only initialize the OpenGL component.");
            }

            const IntPtr EGL_NO_DISPLAY = 0;
            IntPtr extensionsPtr = Egl.QueryString(EGL_NO_DISPLAY, Egl.EXTENSIONS);
            string extensionsStr = Marshal.PtrToStringAnsi(extensionsPtr)!;
            Extensions = extensionsStr.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(Extensions);

            if (Extensions.Contains("EGL_ANGLE_platform_angle") == false)
            {
                throw new PalException(this, "To create an ANGLE context 'EGL_ANGLE_platform_angle' extension must be supported.");
            }

            // FIXME: What should we really set here?
            int[] attribs = new int[] { Egl.RENDERABLE_TYPE, Egl.OPENGL_ES3_BIT, Egl.NONE };

            eglDisplay = Egl.GetPlatformDisplayEXT(Egl.PLATFORM_ANGLE_ANGLE, Egl.DEFAULT_DISPLAY, attribs);

            bool success = Egl.Initialize(eglDisplay, out int major, out int minor);
            if (success == false)
            {
                // FIXME: eglGetError?
                throw new PalException(this, "EGL couldn't initialize successfully.");
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
        public OpenGLContextHandle CreateFromWindow(WindowHandle handle)
        {
            // FIXME: Can we use an SDL window to create an ANGLE context?
            IntPtr windowHandle = handle switch
            {
                Windows.HWND hwnd => hwnd.HWnd,
                X11.XWindowHandle xwindow => (IntPtr)xwindow.Window.Id,
                macOS.NSWindowHandle nswindow => nswindow.Window,

                _ => throw new PlatformNotSupportedException($"OpenTK doesn't support creating an ANGLE context using {handle.GetType()}.")
            };
            // FIXME: OpenGL ES settings? ANGLE specific settings?
            OpenGLGraphicsApiHints? settings = handle.GraphicsApiHints as OpenGLGraphicsApiHints;
            if (settings == null)
            {
                // FIXME: Exception message
                throw new Exception("No settings");
            }

            List<int> config_attribs = new List<int>() { Egl.SURFACE_TYPE, Egl.WINDOW_BIT, Egl.RENDERABLE_TYPE, Egl.OPENGL_ES3_BIT };

            if (settings.Multisamples > 0)
            {
                config_attribs.Add(Egl.SAMPLE_BUFFERS);
                config_attribs.Add(1);

                config_attribs.Add(Egl.SAMPLES);
                config_attribs.Add(settings.Multisamples);
            }

            if (settings.sRGBFramebuffer && Extensions.Contains("EGL_KHR_gl_colorspace"))
            {
                config_attribs.Add(Egl.COLORSPACE);
                config_attribs.Add(Egl.COLORSPACE_sRGB);
            }

            config_attribs.Add(Egl.RED_SIZE);
            config_attribs.Add(settings.RedColorBits);
            config_attribs.Add(Egl.GREEN_SIZE);
            config_attribs.Add(settings.GreenColorBits);
            config_attribs.Add(Egl.BLUE_SIZE);
            config_attribs.Add(settings.BlueColorBits);
            config_attribs.Add(Egl.ALPHA_SIZE);
            config_attribs.Add(settings.AlphaColorBits);

            if (settings.DepthBits != ContextDepthBits.None)
            {
                int depthBits;
                switch (settings.DepthBits)
                {
                    case ContextDepthBits.Depth24: depthBits = 24; break;
                    case ContextDepthBits.Depth32: depthBits = 32; break;
                    default: throw new InvalidEnumArgumentException(nameof(settings.DepthBits), (int)settings.DepthBits, settings.DepthBits.GetType());
                }

                config_attribs.Add(Egl.DEPTH_SIZE);
                config_attribs.Add(depthBits);
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

                config_attribs.Add(Egl.STENCIL_SIZE);
                config_attribs.Add(stencilBits);
            }

            config_attribs.Add(Egl.NONE);

            // FIXME:
            IntPtr[] configs = new IntPtr[1];
            bool success = Egl.ChooseConfig(eglDisplay, config_attribs.ToArray(), configs, configs.Length, out int num_configs);
            if (success == false)
            {
                var error = Egl.GetError();
                throw new PalException(this, $"eglChooseConfig failed with: {error}");
            }

            List<int> surface_attribs = new List<int>();
            surface_attribs.Add(Egl.RENDER_BUFFER);
            surface_attribs.Add(settings.DoubleBuffer ? Egl.BACK_BUFFER : Egl.SINGLE_BUFFER);
            surface_attribs.Add(Egl.NONE);

            IntPtr eglSurface = Egl.CreatePlatformWindowSurfaceEXT(eglDisplay, configs[0], windowHandle, surface_attribs.ToArray());

            // FIXME: Share context
            List<int> context_attribs = new List<int>() { Egl.CONTEXT_MAJOR_VERSION, settings.Version.Major, Egl.CONTEXT_MINOR_VERSION, settings.Version.Minor };
            if (settings.DebugFlag)
            {
                context_attribs.Add(Egl.CONTEXT_OPENGL_DEBUG);
                context_attribs.Add(1);
            }

            context_attribs.Add(Egl.NONE);

            ANGLEOpenGLContextHandle? shared = settings.SharedContext?.As<ANGLEOpenGLContextHandle>(this);
            IntPtr shareContext = shared?.EglContext ?? IntPtr.Zero;

            IntPtr contextPtr = Egl.CreateContext(eglDisplay, configs[0], shareContext, context_attribs.ToArray());

            ANGLEOpenGLContextHandle context = new ANGLEOpenGLContextHandle(eglSurface, contextPtr, shared);

            ContextDict.Add(contextPtr, context);

            return context;
        }

        /// <inheritdoc/>
        public void DestroyContext(OpenGLContextHandle handle)
        {
            ANGLEOpenGLContextHandle context = handle.As<ANGLEOpenGLContextHandle>(this);

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
            ANGLEOpenGLContextHandle context = handle.As<ANGLEOpenGLContextHandle>(this);
            return new Pal2BindingsContext(this, context);
        }

        /// <inheritdoc/>
        public nint GetProcedureAddress(OpenGLContextHandle handle, string procedureName)
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
            ANGLEOpenGLContextHandle? context = handle?.As<ANGLEOpenGLContextHandle>(this);
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
            ANGLEOpenGLContextHandle context = handle.As<ANGLEOpenGLContextHandle>(this);
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
            ANGLEOpenGLContextHandle context = handle.As<ANGLEOpenGLContextHandle>(this);
            Egl.SwapBuffers(eglDisplay, context.EglSurface);
        }
    }
}
