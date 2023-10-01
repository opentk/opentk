using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using OpenTK.Graphics.Egl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform.Native.ANGLE
{
    public class ANGLEOpenGLComponent : IOpenGLComponent
    {
        public string Name => nameof(ANGLEOpenGLComponent);

        public PalComponents Provides => PalComponents.OpenGL;

        public ILogger? Logger { get; set; }

        internal IntPtr eglDisplay;
        internal Version eglVersion;

        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.OpenGL)
            {
                throw new Exception("ANGLEOpenGLComponent can only initialize the OpenGL component.");
            }

            const IntPtr EGL_NO_DISPLAY = 0;
            IntPtr extensionsPtr = Egl.QueryString(EGL_NO_DISPLAY, Egl.EXTENSIONS);
            string extensionsStr = Marshal.PtrToStringAnsi(extensionsPtr)!;
            string[] extensions = extensionsStr.Split(" ");
            Console.WriteLine(extensionsStr);

            if (extensions.Contains("EGL_ANGLE_platform_angle") == false)
            {
                throw new PalException(this, "To create an ANGLE context 'EGL_ANGLE_platform_angle' extension must be supported.");
            }

            int[] attribs = new int[] { Egl.RENDERABLE_TYPE, Egl.OPENGL_ES3_BIT, Egl.NONE };

            eglDisplay = Egl.GetPlatformDisplayEXT(Egl.PLATFORM_ANGLE_ANGLE, Egl.DEFAULT_DISPLAY, attribs);

            bool success = Egl.Initialize(eglDisplay, out int major, out int minor);
            if (success == false)
            {
                // FIXME: eglGetError?
                throw new PalException(this, "EGL couldn't initialize successfully.");
            }

            eglVersion = new Version(major, minor);
        }

        public bool CanShareContexts => throw new NotImplementedException();

        public bool CanCreateFromWindow => true;

        public bool CanCreateFromSurface => throw new NotImplementedException();

        public OpenGLContextHandle CreateFromSurface()
        {
            throw new NotImplementedException();
        }

        public OpenGLContextHandle CreateFromWindow(WindowHandle handle)
        {
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

            //Egl.CreatePlatformWindowSurfaceEXT(eglDisplay, config, windowHandle, null);

            // FIXME:
            int[] config_attribs = { Egl.SURFACE_TYPE, Egl.WINDOW_BIT, Egl.RENDERABLE_TYPE, Egl.OPENGL_ES3_BIT, Egl.NONE };
            IntPtr[] configs = new IntPtr[1];
            bool success = Egl.ChooseConfig(eglDisplay, config_attribs, configs, configs.Length, out int num_configs);

            IntPtr eglSurface = Egl.CreatePlatformWindowSurfaceEXT(eglDisplay, configs[0], windowHandle, null);

            // FIXME
            Egl.BindAPI(RenderApi.ES);

            // FIXME: Share context
            int[] context_attribs = new int[] { Egl.CONTEXT_MAJOR_VERSION, 3, Egl.CONTEXT_MINOR_VERSION, 1, Egl.NONE };
            IntPtr contextPtr = Egl.CreateContext(eglDisplay, configs[0], (IntPtr)null, context_attribs);

            ANGLEOpenGLContextHandle context = new ANGLEOpenGLContextHandle(eglSurface, contextPtr);

            return context;
        }

        public void DestroyContext(OpenGLContextHandle handle)
        {
            throw new NotImplementedException();
        }

        public IBindingsContext GetBindingsContext(OpenGLContextHandle handle)
        {
            ANGLEOpenGLContextHandle context = handle.As<ANGLEOpenGLContextHandle>(this); 
            return new Pal2BindingsContext(this, context);
        }

        public nint GetProcedureAddress(OpenGLContextHandle handle, string procedureName)
        {
            return Egl.GetProcAddress(procedureName);
        }

        public OpenGLContextHandle? GetCurrentContext()
        {
            throw new NotImplementedException();
        }

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

        public void SwapBuffers(OpenGLContextHandle handle)
        {
            ANGLEOpenGLContextHandle context = handle.As<ANGLEOpenGLContextHandle>(this);
            Egl.SwapBuffers(eglDisplay, context.EglSurface);
        }
    }
}
