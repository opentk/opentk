using System;
using System.Runtime.InteropServices;
using static OpenTK.Platform.Native.X11.LibX11;

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

        internal const uint XkbKeycodesNameMask = (1u << 0);
        internal const uint XkbGeometryNameMask = (1u << 1);
        internal const uint XkbSymbolsNameMask = (1u << 2);
        internal const uint XkbPhysSymbolsNameMask = (1u << 3);
        internal const uint XkbTypesNameMask = (1u << 4);
        internal const uint XkbCompatNameMask = (1u << 5);
        internal const uint XkbKeyTypeNamesMask = (1u << 6);
        internal const uint XkbKTLevelNamesMask = (1u << 7);
        internal const uint XkbIndicatorNamesMask = (1u << 8);
        internal const uint XkbKeyNamesMask = (1u << 9);
        internal const uint XkbKeyAliasesMask = (1u << 10);
        internal const uint XkbVirtualModNamesMask = (1u << 11);
        internal const uint XkbGroupNamesMask = (1u << 12);
        internal const uint XkbRGNamesMask = (1u << 13);
        internal const uint XkbComponentNamesMask = (0x3f);
        internal const uint XkbAllNamesMask = (0x3fff);

        internal const uint XkbRepeatKeysMask = (1u << 0);
        internal const uint XkbSlowKeysMask = (1u << 1);
        internal const uint XkbBounceKeysMask = (1u << 2);
        internal const uint XkbStickyKeysMask = (1u << 3);
        internal const uint XkbMouseKeysMask = (1u << 4);
        internal const uint XkbMouseKeysAccelMask = (1u << 5);
        internal const uint XkbAccessXKeysMask = (1u << 6);
        internal const uint XkbAccessXTimeoutMask = (1u << 7);
        internal const uint XkbAccessXFeedbackMask = (1u << 8);
        internal const uint XkbAudibleBellMask =  (1u << 9);
        internal const uint XkbOverlay1Mask =  (1u << 10);
        internal const uint XkbOverlay2Mask =  (1u << 11);
        internal const uint XkbIgnoreGroupLockMask =  (1u << 12);
        internal const uint XkbGroupsWrapMask =  (1u << 27);
        internal const uint XkbInternalModsMask =  (1u << 28);
        internal const uint XkbIgnoreLockModsMask =  (1u << 29);
        internal const uint XkbPerKeyRepeatMask =  (1u << 30);
        internal const uint XkbControlsEnabledMask =  (1u << 31);
        internal const uint XkbAccessXOptionsMask = (XkbStickyKeysMask | XkbAccessXFeedbackMask);
        internal const uint XkbAllBooleanCtrlsMask =  (0x00001FFF);
        internal const uint XkbAllControlsMask =  (0xF8001FFF);

        [DllImport(Xkb, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool XkbLibraryVersion(ref int lib_major_in_out, ref int lib_minor_in_out);

        [DllImport(Xkb, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool XkbQueryExtension(XDisplayPtr dpy, out int opcode_rtrn, out int event_rtrn, out int error_rtrn, ref int major_in_out, ref int minor_in_out);

        [DllImport(Xkb, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool XkbSelectEvents(XDisplayPtr display, uint device_spec, nuint bits_to_change, nuint values_for_bits);

        [DllImport(Xkb, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern XkbDescRec* XkbGetMap(XDisplayPtr display, uint which, uint device_spec);

        [DllImport(Xkb, CallingConvention = CallingConvention.Cdecl)]
        // FIXME: Double check that int is the correct type for status
        internal static unsafe extern XStatus XkbGetNames(XDisplayPtr display, uint which, XkbDescRec* xkb);

        [DllImport(Xkb, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern XStatus XkbGetControls(XDisplayPtr display, nuint which, XkbDescRec* xkb);

        [DllImport(Xkb, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool XkbGetDetectableAutoRepeat(XDisplayPtr display, out bool supported_rtrn);

        [DllImport(Xkb, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool XkbSetDetectableAutoRepeat(XDisplayPtr display, bool detectable, out bool detectable_rtrn);

        [DllImport(Xkb, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern void XkbFreeKeyboard(XkbDescRec* xkb, uint which, bool free_all);

        [DllImport(Xkb, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern XStatus XkbGetState(XDisplayPtr display, uint device_spec, out XkbStateRec state_return);

        [DllImport(Xkb, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern XKeySym XkbKeycodeToKeysym(XDisplayPtr dpy, byte /* KeyCode */ kc, uint group, uint level);
    }
}
