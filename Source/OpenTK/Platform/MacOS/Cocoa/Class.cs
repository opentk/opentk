using System.Runtime.InteropServices;
using System;

namespace OpenTK.Platform.MacOS
{
    static class Class
    {
        [DllImport (Cocoa.LibObjC)]
        extern static IntPtr objc_getClass(string name);

        public static IntPtr Get(string name)
        {
            var id = objc_getClass(name);
            if (id == IntPtr.Zero)
            {
                throw new ArgumentException("Unknown class: " + name);
            }
            return id;
        }
    }
}
