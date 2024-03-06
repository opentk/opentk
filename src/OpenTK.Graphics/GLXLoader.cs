using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Graphics
{
    // FIXME: Actually implement this properly.
    public static class GLXLoader
    {
        public static class BindingsContext
        {
            // FIXME: Extend this to be able to use glXGetProcAddress and glXGetProcAddressARB?
            // Alternatively allow for user provided bindings contexts to be used...
            // - Noggin_bops 2024-03-06
            public static IntPtr GetProcAddress(string procName) => NativeLibrary.GetExport(GLXHandle, procName);
        }

        // FIXME: More advanced resolution?
        private static readonly IntPtr GLXHandle = NativeLibrary.Load("libGL.so");
    }
}
