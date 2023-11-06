using System;
using System.Runtime.InteropServices;
using static OpenTK.Platform.Native.X11.LibX11;

namespace OpenTK.Platform.Native.X11 
{
    internal static class LibXkb
    {
        const string Xkb = "Xkb";

        [DllImport(Xkb, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool XkbLibraryVersion(ref int lib_major_in_out, ref int lib_minor_in_out);

        [DllImport(Xkb, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool XkbQueryExtension(XDisplayPtr dpy, out int opcode_rtrn, out int event_rtrn, out int error_rtrn, ref int major_in_out, ref int minor_in_out);

        [DllImport(Xkb, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool XkbSelectEvents(XDisplayPtr display, uint device_spec, ulong bits_to_change, ulong values_for_bits);

        [DllImport(Xkb, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr /* XkbDescPtr */ XkbGetMap(XDisplayPtr display, uint which, uint device_spec);
    }
}
