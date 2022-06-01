using System;
using OpenTK.Core.Platform;

namespace OpenTK.Platform.Native.X11
{
    public partial class X11AbstractionLayer : IOpenGLComponent
    {
        public bool CanShareContexts => false;
        public bool CanCreateFromWindow => true;
        public bool CanCreateFromSurface => false;
        public OpenGLContextHandle CreateFromSurface()
        {
            throw new PalNotImplementedException(this);
        }

        public OpenGLContextHandle CreateFromWindow(WindowHandle handle, ContextSettings settings)
        {
            throw new NotImplementedException();
        }

        public void DestroyContext(OpenGLContextHandle handle)
        {
            throw new NotImplementedException();
        }

        public OpenGLContextHandle GetCurrentContext()
        {
            throw new NotImplementedException();
        }

        public IntPtr GetProcedureAddress(OpenGLContextHandle handle, string procedureName)
        {
            throw new NotImplementedException();
        }

        public OpenGLContextHandle GetSharedContext()
        {
            throw new NotImplementedException();
        }

        public OpenGLContextHandle GetSharedContext(OpenGLContextHandle handle)
        {
            throw new NotImplementedException();
        }

        public bool SetCurrentContext(OpenGLContextHandle handle)
        {
            throw new NotImplementedException();
        }

        public void SetSharedContext(OpenGLContextHandle handle)
        {
            throw new NotImplementedException();
        }
    }
}
