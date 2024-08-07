using System;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.Native.X11.XI2
{
#pragma warning disable CS0649
    internal unsafe struct XIAddMasterInfo {
        public HierarchyChangeType type;
        public byte*               name;
        public int /* Bool */      send_core;
        public int /* Bool */      enable;
    }

    internal unsafe struct XIRemoveMasterInfo {
        public HierarchyChangeType type;
        public int                 deviceid;
        public int                 return_mode; /* AttachToMaster, Floating */
        public int                 return_pointer;
        public int                 return_keyboard;
    }

    internal unsafe struct XIAttachSlaveInfo {
        public HierarchyChangeType type;
        public int                 deviceid;
        public int                 new_master;
    }

    internal unsafe struct XIDetachSlaveInfo {
        public HierarchyChangeType type;
        public int deviceid;
    }

    [StructLayout(LayoutKind.Explicit)]
    internal unsafe struct XIAnyHierarchyChangeInfo {
        [FieldOffset(0)]
        public HierarchyChangeType type; /* must be first element */
        [FieldOffset(0)]
        public XIAddMasterInfo     add;
        [FieldOffset(0)]
        public XIRemoveMasterInfo  remove;
        [FieldOffset(0)]
        public XIAttachSlaveInfo   attach;
        [FieldOffset(0)]
        public XIDetachSlaveInfo   detach;
    }

    internal unsafe struct XIModifierState
    {
        public int @base;
        public int latched;
        public int locked;
        public int effective;
    }

    internal unsafe struct XIGroupState
    {
        public int @base;
        public int latched;
        public int locked;
        public int effective;
    }

    internal unsafe struct XIButtonState {
        public int   mask_len;
        public byte* ask;
    }

    internal unsafe struct XIValuatorState {
        public int     mask_len;
        public byte*   ask;
        public double* alues;
    }

    internal unsafe struct XIEventMask
    {
        public int   deviceid;
        public int   mask_len;
        public byte* mask;
    }

    internal unsafe struct XIAnyClassInfo
    {
        public int         type;
        public int         sourceid;
    }

    internal unsafe struct XIButtonClassInfo
    {
        public int         type;
        public int         sourceid;
        public int         num_buttons;
        public XAtom*       abels;
        public XIButtonState state;
    }

    internal unsafe struct XIKeyClassInfo
    {
        public int         type;
        public int         sourceid;
        public int         num_keycodes;
        public int*         eycodes;
    }

    internal unsafe struct XIValuatorClassInfo
    {
        public int         type;
        public int         sourceid;
        public int         number;
        public XAtom       label;
        public double      min;
        public double      max;
        public double      value;
        public int         resolution;
        public int         mode;
    }

    /* new in XI 2.1 */
    internal unsafe struct XIScrollClassInfo
    {
        public ScrollType  type;
        public int         sourceid;
        public int         number;
        public int         scroll_type;
        public double      increment;
        public int         flags;
    }

    internal unsafe struct XITouchClassInfo
    {
        public int         type;
        public int         sourceid;
        public int         mode;
        public int         num_touches;
    }

    internal unsafe struct XIDeviceInfo
    {
        public int                 deviceid;
        public byte*                ame;
        public int                 use;
        public int                 attachment;
        public int /* Bool */      enabled;
        public int                 num_classes;
        public XIAnyClassInfo**    classes;
    }

    internal unsafe struct XIGrabModifiers
    {
        public int                 modifiers;
        public int                 status;
    }

    internal unsafe struct XIBarrierReleasePointerInfo
    {
        public int                 deviceid;
        public XPointerBarrier      barrier;
        public uint /* BarrierEventID */      eventid;
    }

    /**
*    Generic LibXI2 event. All LibXI2 events have the same header.
    */
    internal unsafe struct XIEvent {
        public int            type;         /* GenericEvent */
        public ulong          serial;       /* # of last request processed by server */
        public int /* Bool */ send_event;   /* true if this came from a SendEvent request */
        public XDisplayPtr    display;     /* Display the event was read from */
        public int            extension;    /* XI extension offset */
        public int            evtype;
        public XTime          time;
    }

    internal unsafe struct XIHierarchyInfo {
        public int            deviceid;
        public int            attachment;
        public int            use;
        public int /* Bool */ enabled;
        public int            flags;
    }

    /*
*    Notifies the client that the device hierarchy has been changed. The client
*    is expected to re-query the server for the device hierarchy.
    */
    internal unsafe struct XIHierarchyEvent {
        public int              type;         /* GenericEvent */
        public ulong            serial;       /* # of last request processed by server */
        public int /* Bool */   send_event;   /* true if this came from a SendEvent request */
        public XDisplayPtr      display;     /* Display the event was read from */
        public int              extension;    /* XI extension offset */
        public int              evtype;       /* XI_HierarchyChanged */
        public XTime            time;
        public int              flags;
        public int              num_info;
        public XIHierarchyInfo* nfo;
    }

    /*
*    Notifies the client that the classes have been changed. This happens when
*    the slave device that sends through the master changes.
    */
    internal unsafe struct XIDeviceChangedEvent {
        public int              type;         /* GenericEvent */
        public ulong            serial;       /* # of last request processed by server */
        public int /* Bool */   send_event;   /* true if this came from a SendEvent request */
        public XDisplayPtr      display;     /* Display the event was read from */
        public int              extension;    /* XI extension offset */
        public int              evtype;       /* XI_DeviceChanged */
        public XTime            time;
        public int              deviceid;     /* id of the device that changed */
        public int              sourceid;     /* Source for the new classes. */
        public int              reason;       /* Reason for the change */
        public int              num_classes;
        public XIAnyClassInfo** classes; /* same as in XIDeviceInfo */
    }

    internal unsafe struct XIDeviceEvent {
        public int             type;         /* GenericEvent */
        public ulong           serial;       /* # of last request processed by server */
        public int /* Bool */  send_event;   /* true if this came from a SendEvent request */
        public XDisplayPtr     display;     /* Display the event was read from */
        public int             extension;    /* XI extension offset */
        public int             evtype;
        public XTime           time;
        public int             deviceid;
        public int             sourceid;
        public int             detail;
        public XWindow         root;
        public XWindow         @event;
        public XWindow         child;
        public double          root_x;
        public double          root_y;
        public double          event_x;
        public double          event_y;
        public int             flags;
        public XIButtonState   buttons;
        public XIValuatorState valuators;
        public XIModifierState mods;
        public XIGroupState    group;
    }
    
    internal unsafe struct XIRawEvent {
        public int             type;         /* GenericEvent */
        public ulong           serial;       /* # of last request processed by server */
        public int /* Bool */  send_event;   /* true if this came from a SendEvent request */
        public XDisplayPtr     display;     /* Display the event was read from */
        public int             extension;    /* XI extension offset */
        public int             evtype;       /* XI_RawKeyPress, XI_RawKeyRelease, etc. */
        public XTime           time;
        public int             deviceid;
        public int             sourceid;     /* Bug: Always 0. https://bugs.freedesktop.org//show_bug.cgi?id=34240 */
        public int             detail;
        public int             flags;
        public XIValuatorState valuators;
        public double*         aw_values;
    }
    
    internal unsafe struct XIEnterEvent {
        public int             type;         /* GenericEvent */
        public ulong           serial;       /* # of last request processed by server */
        public int /* Bool */  send_event;   /* true if this came from a SendEvent request */
        public XDisplayPtr     display;     /* Display the event was read from */
        public int             extension;    /* XI extension offset */
        public int             evtype;
        public XTime           time;
        public int             deviceid;
        public int             sourceid;
        public int             detail;
        public XWindow         root;
        public XWindow         @event;
        public XWindow         child;
        public double          root_x;
        public double          root_y;
        public double          event_x;
        public double          event_y;
        public int             mode;
        public int /* Bool */  focus;
        public int /* Bool */  same_screen;
        public XIButtonState   buttons;
        public XIModifierState mods;
        public XIGroupState    group;
    }

    // FIXME: Put these into some union?
    /*
    typedef XIEnterEvent XILeaveEvent;
    typedef XIEnterEvent XIFocusInEvent;
    typedef XIEnterEvent XIFocusOutEvent;
    */

    internal unsafe struct XIPropertyEvent {
        public int            type;         /* GenericEvent */
        public ulong          serial;       /* # of last request processed by server */
        public int /* Bool */ send_event;   /* true if this came from a SendEvent request */
        public XDisplayPtr    display;     /* Display the event was read from */
        public int            extension;    /* XI extension offset */
        public int            evtype;       /* XI_PropertyEvent */
        public XTime          time;
        public int            deviceid;     /* id of the device that changed */
        public XAtom          property;
        public int            what;
    }

    internal unsafe struct XITouchOwnershipEvent {
        public int            type;         /* GenericEvent */
        public ulong          serial;       /* # of last request processed by server */
        public int /* Bool */ send_event;   /* true if this came from a SendEvent request */
        public XDisplayPtr    display;     /* Display the event was read from */
        public int            extension;    /* XI extension offset */
        public int            evtype;
        public XTime          time;
        public int            deviceid;
        public int            sourceid;
        public uint           touchid;
        public XWindow        root;
        public XWindow        @event;
        public XWindow        child;
        public int            flags;
    }

    internal unsafe struct XIBarrierEvent {
        public int                       type;         /* GenericEvent */
        public ulong                     serial;       /* # of last request processed by server */
        public int /* Bool */            send_event;   /* true if this came from a SendEvent request */
        public XDisplayPtr               display;     /* Display the event was read from */
        public int                       extension;    /* XI extension offset */
        public int                       evtype;
        public XTime                     time;
        public int                       deviceid;
        public int                       sourceid;
        public XWindow                   @event;
        public XWindow                   root;
        public double                    root_x;
        public double                    root_y;
        public double                    dx;
        public double                    dy;
        public int                       dtime;
        public int                       flags;
        public XPointerBarrier           barrier;
        public uint /* BarrierEventID */ eventid;
    }
#pragma warning restore CS0649
}

