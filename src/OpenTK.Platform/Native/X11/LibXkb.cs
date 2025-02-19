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

        internal const uint XkbKeycodesNameMask = (1<<0);
        internal const uint XkbGeometryNameMask = (1<<1);
        internal const uint XkbSymbolsNameMask = (1<<2);
        internal const uint XkbPhysSymbolsNameMask = (1<<3);
        internal const uint XkbTypesNameMask = (1<<4);
        internal const uint XkbCompatNameMask = (1<<5);
        internal const uint XkbKeyTypeNamesMask = (1<<6);
        internal const uint XkbKTLevelNamesMask = (1<<7);
        internal const uint XkbIndicatorNamesMask = (1<<8);
        internal const uint XkbKeyNamesMask = (1<<9);
        internal const uint XkbKeyAliasesMask = (1<<10);
        internal const uint XkbVirtualModNamesMask = (1<<11);
        internal const uint XkbGroupNamesMask = (1<<12);
        internal const uint XkbRGNamesMask = (1<<13);
        internal const uint XkbComponentNamesMask = (0x3f);
        internal const uint XkbAllNamesMask = (0x3fff);

        internal const ulong XkbRepeatKeysMask = (1L<<0);
        internal const ulong XkbSlowKeysMask = (1L<<1);
        internal const ulong XkbBounceKeysMask = (1L<<2);
        internal const ulong XkbStickyKeysMask = (1L<<3);
        internal const ulong XkbMouseKeysMask = (1L<<4);
        internal const ulong XkbMouseKeysAccelMask = (1L<<5);
        internal const ulong XkbAccessXKeysMask = (1L<<6);
        internal const ulong XkbAccessXTimeoutMask = (1L<<7);
        internal const ulong XkbAccessXFeedbackMask = (1L<<8);
        internal const ulong XkbAudibleBellMask =  (1L<<9);
        internal const ulong XkbOverlay1Mask =  (1L<<10);
        internal const ulong XkbOverlay2Mask =  (1L<<11);
        internal const ulong XkbIgnoreGroupLockMask =  (1L<<12);
        internal const ulong XkbGroupsWrapMask =  (1L<<27);
        internal const ulong XkbInternalModsMask =  (1L<<28);
        internal const ulong XkbIgnoreLockModsMask =  (1L<<29);
        internal const ulong XkbPerKeyRepeatMask =  (1L<<30);
        internal const ulong XkbControlsEnabledMask =  (1L<<31);
        internal const ulong XkbAccessXOptionsMask = (XkbStickyKeysMask | XkbAccessXFeedbackMask);
        internal const ulong XkbAllBooleanCtrlsMask =  (0x00001FFF);
        internal const ulong XkbAllControlsMask =  (0xF8001FFF);

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
        internal static unsafe extern XStatus XkbGetNames(XDisplayPtr display, uint which, XkbDescRec* xkb);

        [DllImport(Xkb, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern XStatus XkbGetControls(XDisplayPtr display, ulong which, XkbDescRec* xkb);

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
