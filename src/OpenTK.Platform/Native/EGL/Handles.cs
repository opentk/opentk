using OpenTK.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform.Native.ANGLE
{
    internal class EGLOpenGLContextHandle : OpenGLContextHandle
    {
        public IntPtr EglSurface;
        public IntPtr EglContext;

        public EGLOpenGLContextHandle? SharedContext;

        public EGLOpenGLContextHandle(IntPtr eglSurface, IntPtr eglContext, EGLOpenGLContextHandle? sharedContext)
        {
            EglSurface = eglSurface;
            EglContext = eglContext;
            SharedContext = sharedContext;
        }
    }
}
