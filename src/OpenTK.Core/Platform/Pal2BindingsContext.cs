using System;

namespace OpenTK.Core.Platform
{
    public class Pal2BindingsContext : IBindingsContext
    {
        public IOpenGLComponent OpenGLComp { get; private set; }

        public OpenGLContextHandle ContextHandle { get; private set; }

        public Pal2BindingsContext(IOpenGLComponent openGLComp, OpenGLContextHandle contextHandle)
        {
            OpenGLComp = openGLComp;
            ContextHandle = contextHandle;
        }

        public IntPtr GetProcAddress(string procName)
        {
            return OpenGLComp.GetProcedureAddress(ContextHandle, procName);
        }
    }
}
