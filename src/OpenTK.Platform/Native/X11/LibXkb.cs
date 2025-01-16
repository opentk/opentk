using System.Runtime.InteropServices;

namespace OpenTK.Platform.Native.X11
{
    internal static class LibXkb
    {
        static LibXkb()
        {
            DllResolver.InitLoader();
        }

        const string Xkb = "Xkb";

        internal const uint XkbUseCoreKbd = 0x0100;

        internal const uint XkbKeycodesNameMask = (1 << 0);
        internal const uint XkbGeometryNameMask = (1 << 1);
        internal const uint XkbSymbolsNameMask = (1 << 2);
        internal const uint XkbPhysSymbolsNameMask = (1 << 3);
        internal const uint XkbTypesNameMask = (1 << 4);
        internal const uint XkbCompatNameMask = (1 << 5);
        internal const uint XkbKeyTypeNamesMask = (1 << 6);
        internal const uint XkbKTLevelNamesMask = (1 << 7);
        internal const uint XkbIndicatorNamesMask = (1 << 8);
        internal const uint XkbKeyNamesMask = (1 << 9);
        internal const uint XkbKeyAliasesMask = (1 << 10);
        internal const uint XkbVirtualModNamesMask = (1 << 11);
        internal const uint XkbGroupNamesMask = (1 << 12);
        internal const uint XkbRGNamesMask = (1 << 13);
        internal const uint XkbComponentNamesMask = (0x3f);
        internal const uint XkbAllNamesMask = (0x3fff);

        [DllImport(Xkb, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool XkbLibraryVersion(ref int lib_major_in_out, ref int lib_minor_in_out);

        [DllImport(Xkb, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool XkbQueryExtension(XDisplayPtr dpy, out int opcode_rtrn, out int event_rtrn, out int error_rtrn, ref int major_in_out, ref int minor_in_out);

        [DllImport(Xkb, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool XkbSelectEvents(XDisplayPtr display, uint device_spec, ulong bits_to_change, ulong values_for_bits);

        [DllImport(Xkb, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern XkbDescRec* XkbGetMap(XDisplayPtr display, uint which, uint device_spec);

        [DllImport(Xkb, CallingConvention = CallingConvention.Cdecl)]
        // FIXME: Double check that int is the correct type for status
        internal static unsafe extern int /* Status */ XkbGetNames(XDisplayPtr display, uint which, XkbDescRec* xkb);

        [DllImport(Xkb, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool XkbGetDetectableAutoRepeat(XDisplayPtr display, out bool supported_rtrn);

        [DllImport(Xkb, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool XkbSetDetectableAutoRepeat(XDisplayPtr display, bool detectable, out bool detectable_rtrn);

        [DllImport(Xkb, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern void XkbFreeKeyboard(XkbDescRec* xkb, uint which, bool free_all);
    }
}
