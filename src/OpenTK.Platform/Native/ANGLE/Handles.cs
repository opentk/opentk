using OpenTK.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform.Native.ANGLE
{
    internal class ANGLEOpenGLContextHandle : OpenGLContextHandle
    {
        public IntPtr EglSurface;
        public IntPtr EglContext;

        public ANGLEOpenGLContextHandle? SharedContext;

        public ANGLEOpenGLContextHandle(IntPtr eglSurface, IntPtr eglContext, ANGLEOpenGLContextHandle? sharedContext)
        {
            EglSurface = eglSurface;
            EglContext = eglContext;
            SharedContext = sharedContext;
        }
    }
}
