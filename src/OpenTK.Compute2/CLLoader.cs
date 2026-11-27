using System;
using System.Runtime.InteropServices;

namespace OpenTK.Compute2
{
    /// <summary>
    /// Used to load the OpenCL bindings.
    /// </summary>
    public static class CLLoader
    {
        /// <summary>
        /// The bindings context for CL.
        /// </summary>
        public static class BindingsContext
        {
            public static IntPtr GetProcAddress(string procName)
            {
                return NativeLibrary.GetExport(CLHandle, procName);
            }
        }

        private static readonly IntPtr CLHandle = NativeLibrary.Load("opencl");
    }
}
