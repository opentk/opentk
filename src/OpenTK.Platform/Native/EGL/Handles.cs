using OpenTK.Graphics.Egl;
using OpenTK.Platform;
using System;

namespace OpenTK.Platform.Native.EGL
{
    internal class EGLOpenGLContextHandle : OpenGLContextHandle
    {
        public EGLSurface EglSurface;
        public EGLContext EglContext;

        public EGLOpenGLContextHandle? SharedContext;

        public ContextValues ContextValues;

        public int SwapInterval = 0;

        public EGLOpenGLContextHandle(EGLSurface eglSurface, EGLContext eglContext, WindowHandle window, EGLOpenGLContextHandle? sharedContext, ContextValues contextValues)
        {
            EglSurface = eglSurface;
            EglContext = eglContext;
            WindowHandle = window;
            SharedContext = sharedContext;
            ContextValues = contextValues;
        }
    }
}
