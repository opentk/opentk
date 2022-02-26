using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Core.Platform.Implementations.Windows
{
    public class Win32BindingsContext : IBindingsContext
    {
        public OpenGLComponent OpenGLComp { get; private set; }

        public OpenGLContextHandle ContextHandle { get; private set; }

        public Win32BindingsContext(OpenGLComponent openGLComp, OpenGLContextHandle contextHandle)
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
