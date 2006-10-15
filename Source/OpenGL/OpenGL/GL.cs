using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace OpenTK.OpenGL
{
    public static partial class GL
    {
        private static Delegate WindowsGetAddress(string function_string, Type function_type)
        {
            IntPtr address = Wgl.GetProcAddress(function_string);
            if (address == IntPtr.Zero)
                return null;
            else
                return Marshal.GetDelegateForFunctionPointer(address, function_type);
        }

        private static Delegate X11GetAddress(string function_string, Type function_type)
        {
            IntPtr address = Glx.GetProcAddress(function_string);
            if (address == IntPtr.Zero)
                return null;
            else
                return Marshal.GetDelegateForFunctionPointer(address, function_type);
        }

        private static Delegate MacOSGetAddress(string function_string, Type function_type)
        {
            throw new NotImplementedException("THis platform is not supported yet. Sorry for the inconvenience.");
        }
    }
}
