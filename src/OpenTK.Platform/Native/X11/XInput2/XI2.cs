using System.Runtime.InteropServices;

namespace OpenTK.Platform.Native.X11.XI2
{
    internal static unsafe class XI2
    {

        // FIXME: Figure this out.
        private const string LibXI2 = "XI2";

        // Macros
        internal static unsafe void XISetMask(byte* ptr, XI2EventType @event) => ptr[(int)@event >> 3] |= (byte)(1 << ((int)@event & 7));
        internal static unsafe void XIClearMask(byte* ptr, XI2EventType @event) => ptr[(int)@event >> 3] &= (byte)~(1 << ((int)@event & 7));
        internal static unsafe bool XIMaskIsSet(byte* ptr, XI2EventType @event) => (ptr[(int)@event >> 3] & (1 << ((int)@event & 7))) != 0;
        internal static int XIMaskLen(XI2EventType @event) => ((int)@event >> 3) + 1;

        [DllImport(LibXI2, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int /* Bool */     XIQueryPointer(
            XDisplayPtr display,
            int deviceid,
            XWindow win,
            XWindow* root,
            XWindow* child,
            double* root_x,
            double* root_y,
            double* win_x,
            double* win_y,
            XIButtonState* buttons,
            XIModifierState* mods,
            XIGroupState* group
        );

        [DllImport(LibXI2, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int /* Bool */     XIWarpPointer(
            XDisplayPtr display,
            int deviceid,
            XWindow src_win,
            XWindow dst_win,
            double src_x,
            double src_y,
            uint src_width,
            uint src_height,
            double dst_x,
            double dst_y
        );

        [DllImport(LibXI2, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XStatus XIDefineXCursor(
            XDisplayPtr display,
            int deviceid,
            XWindow win,
            XCursor cursor
        );

        [DllImport(LibXI2, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XStatus XIUndefineXCursor(
            XDisplayPtr display,
            int deviceid,
            XWindow win
        );

        [DllImport(LibXI2, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XStatus XIChangeHierarchy(
            XDisplayPtr display,
            XIAnyHierarchyChangeInfo* changes,
            int num_changes
        );

        [DllImport(LibXI2, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XStatus XISetClientPointer(
            XDisplayPtr dpy,
            XWindow win,
            int deviceid
        );

        [DllImport(LibXI2, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int /* Bool */     XIGetClientPointer(
            XDisplayPtr dpy,
            XWindow win,
            int* deviceid
        );

        [DllImport(LibXI2, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XISelectEvents(
            XDisplayPtr dpy,
            XWindow win,
            XIEventMask* masks,
            int num_masks
        );

        [DllImport(LibXI2, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XIEventMask* IGetSelectedEvents(
            XDisplayPtr dpy,
            XWindow win,
            int* num_masks_return
        );

        [DllImport(LibXI2, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XStatus XIQueryVersion(
            XDisplayPtr dpy,
            ref int major_version_inout,
            ref int minor_version_inout
        );

        [DllImport(LibXI2, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XIDeviceInfo* XIQueryDevice(
            XDisplayPtr dpy,
            int deviceid,
            int* ndevices_return
        );

        [DllImport(LibXI2, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XStatus XISetFocus(
            XDisplayPtr dpy,
            int deviceid,
            XWindow focus,
            XTime time
        );

        [DllImport(LibXI2, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XStatus XIGetFocus(
            XDisplayPtr dpy,
            int deviceid,
            XWindow* focus_return
        );

        [DllImport(LibXI2, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XStatus XIGrabDevice(
            XDisplayPtr dpy,
            int deviceid,
            XWindow grab_XWindow,
            XTime time,
            XCursor cursor,
            int grab_mode,
            int paired_device_mode,
            int /* Bool */     owner_events,
            XIEventMask* mask
        );

        [DllImport(LibXI2, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XStatus XIUngrabDevice(
            XDisplayPtr dpy,
            int deviceid,
            XTime time
        );

        [DllImport(LibXI2, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XStatus XIAllowEvents(
            XDisplayPtr display,
            int deviceid,
            int event_mode,
            XTime time
        );

        [DllImport(LibXI2, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XStatus XIAllowTouchEvents(
            XDisplayPtr display,
            int deviceid,
            uint touchid,
            XWindow grab_window,
            int event_mode
        );

        [DllImport(LibXI2, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XIGrabButton(
            XDisplayPtr display,
            int deviceid,
            int button,
            XWindow grab_window,
            XCursor cursor,
            int grab_mode,
            int paired_device_mode,
            int owner_events,
            XIEventMask* mask,
            int num_modifiers,
            XIGrabModifiers* modifiers_inout
        );

        [DllImport(LibXI2, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XIGrabKeycode(
            XDisplayPtr display,
            int deviceid,
            int keycode,
            XWindow grab_window,
            int grab_mode,
            int paired_device_mode,
            int owner_events,
            XIEventMask* mask,
            int num_modifiers,
            XIGrabModifiers* modifiers_inout
        );

        [DllImport(LibXI2, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XIGrabEnter(
            XDisplayPtr display,
            int deviceid,
            XWindow grab_window,
            XCursor cursor,
            int grab_mode,
            int paired_device_mode,
            int owner_events,
            XIEventMask* mask,
            int num_modifiers,
            XIGrabModifiers* modifiers_inout
        );

        [DllImport(LibXI2, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XIGrabFocusIn(
            XDisplayPtr display,
            int deviceid,
            XWindow grab_window,
            int grab_mode,
            int paired_device_mode,
            int owner_events,
            XIEventMask* mask,
            int num_modifiers,
            XIGrabModifiers* modifiers_inout
        );

        [DllImport(LibXI2, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XIGrabTouchBegin(
            XDisplayPtr display,
            int deviceid,
            XWindow grab_window,
            int owner_events,
            XIEventMask* mask,
            int num_modifiers,
            XIGrabModifiers* modifiers_inout
        );

        [DllImport(LibXI2, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XStatus XIUngrabButton(
            XDisplayPtr display,
            int deviceid,
            int button,
            XWindow grab_window,
            int num_modifiers,
            XIGrabModifiers* modifiers
        );

        [DllImport(LibXI2, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XStatus XIUngrabKeycode(
            XDisplayPtr display,
            int deviceid,
            int keycode,
            XWindow grab_window,
            int num_modifiers,
            XIGrabModifiers* modifiers
        );

        [DllImport(LibXI2, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XStatus XIUngrabEnter(
            XDisplayPtr display,
            int deviceid,
            XWindow grab_window,
            int num_modifiers,
            XIGrabModifiers* modifiers
        );

        [DllImport(LibXI2, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XStatus XIUngrabFocusIn(
            XDisplayPtr display,
            int deviceid,
            XWindow grab_window,
            int num_modifiers,
            XIGrabModifiers* modifiers
        );

        [DllImport(LibXI2, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XStatus XIUngrabTouchBegin(
            XDisplayPtr display,
            int deviceid,
            XWindow grab_window,
            int num_modifiers,
            XIGrabModifiers* modifiers
        );

        [DllImport(LibXI2, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XAtom* XIListProperties(
            XDisplayPtr display,
            int deviceid,
            int* num_props_return
        );

        [DllImport(LibXI2, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XIChangeProperty(
            XDisplayPtr display,
            int deviceid,
            XAtom property,
            XAtom type,
            int format,
            int mode,
            byte* data,
            int num_items
        );

        [DllImport(LibXI2, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XIDeleteProperty(
            XDisplayPtr display,
            int deviceid,
            XAtom property
        );

        [DllImport(LibXI2, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XStatus XIGetProperty(
            XDisplayPtr display,
            int deviceid,
            XAtom property,
            long offset,
            long length,
            int /* Bool */      delete_property,
            XAtom type,
            XAtom* type_return,
            int* format_return,
            ulong* num_items_return,
            ulong* bytes_after_return,
            byte** data
        );

        [DllImport(LibXI2, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void
        XIBarrierReleasePointers(
            XDisplayPtr display,
            XIBarrierReleasePointerInfo* barriers,
            int num_barriers
        );

        [DllImport(LibXI2, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void
        XIBarrierReleasePointer(
            XDisplayPtr display,
            int deviceid,
            XPointerBarrier barrier,
            uint /* BarrierEventID */   eventid
        );

        [DllImport(LibXI2, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XIFreeDeviceInfo(XIDeviceInfo* info);
    }
}