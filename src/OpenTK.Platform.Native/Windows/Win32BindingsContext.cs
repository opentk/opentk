using OpenTK.Core.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform.Native.Windows
{
    // FIXME: There is nothing Win32 specific about this class anymore.
    public class Win32BindingsContext : IBindingsContext
    {
        public IOpenGLComponent OpenGLComp { get; private set; }

        public OpenGLContextHandle ContextHandle { get; private set; }

        public Win32BindingsContext(IOpenGLComponent openGLComp, OpenGLContextHandle contextHandle)
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
