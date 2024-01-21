using System;

namespace OpenTK.Platform.Native.X11.XI2
{
    internal enum PropertyEventFlags
    {
        XIPropertyDeleted = 0,
        XIPropertyCreated = 1,
        XIPropertyModified = 2,
    }

    internal enum PropertyMode
    {
        XIPropModeReplace = 0,
        XIPropModePrepend = 1,
        XIPropModeAppend = 2,
    }

    // FIXME: Better name
    /* Enter/Leave and Focus In/Out modes */
    internal enum FocusMode
    {
        XINotifyNormal = 0,
        XINotifyGrab = 1,
        XINotifyUngrab = 2,
        XINotifyWhileGrabbed = 3,
        XINotifyPassiveGrab = 4,
        XINotifyPassiveUngrab = 5,
    }

    /* Enter/Leave and focus In/out detail */
    internal enum FocusDetail
    {
        XINotifyAncestor = 0,
        XINotifyVirtual = 1,
        XINotifyInferior = 2,
        XINotifyNonlinear = 3,
        XINotifyNonlinearVirtual = 4,
        XINotifyPointer = 5,
        XINotifyPointerRoot = 6,
        XINotifyDetailNone = 7,
    }

    internal enum GrabMode
    {
        XIGrabModeSync = 0,
        XIGrabModeAsync = 1,
        XIGrabModeTouch = 2,
    }

    /* Grab reply status codes */
    internal enum GrabReplyStatus
    {
        XIGrabSuccess = 0,
        XIAlreadyGrabbed = 1,
        XIGrabInvalidTime = 2,
        XIGrabNotViewable = 3,
        XIGrabFrozen = 4,
    }

    /* Grab owner events values */
    internal enum GrabOwner 
    {
        XIOwnerEvents = 1,
        XINoOwnerEvents = 0,
    }

    /* Passive grab types */
    internal enum PassiveGrabType
    {
        XIGrabtypeButton = 0,
        XIGrabtypeKeycode = 1,
        XIGrabtypeEnter = 2,
        XIGrabtypeFocusIn = 3,
        XIGrabtypeTouchBegin = 4,
    }

    internal enum PassiveGrabModifier : uint
    {
        XIAnyModifier = 1U << 31,
        XIAnyButton = 0,
        XIAnyKeycode = 0,
    }

    /* XIAllowEvents event-modes */
    internal enum AllowEventMode
    {
        XIAsyncDevice = 0,
        XISyncDevice = 1,
        XIReplayDevice = 2,
        XIAsyncPairedDevice = 3,
        XIAsyncPair = 4,
        XISyncPair = 5,
        XIAcceptTouch = 6,
        XIRejectTouch = 7,
    }

    /* DeviceChangedEvent change reasons */
    internal enum DeviceChangedReason
    {
        XISlaveSwitch = 1,
        XIDeviceChange = 2,
    }

    internal enum HierarcyFlag
    {
        XIMasterAdded = 1 << 0,
        XIMasterRemoved = 1 << 1,
        XISlaveAdded = 1 << 2,
        XISlaveRemoved = 1 << 3,
        XISlaveAttached = 1 << 4,
        XISlaveDetached = 1 << 5,
        XIDeviceEnabled = 1 << 6,
        XIDeviceDisabled = 1 << 7,
    }

    /* ChangeHierarchy constants */
    internal enum HierarchyChangeType
    {
        XIAddMaster = 1,
        XIRemoveMaster = 2,
        XIAttachSlave = 3,
        XIDetachSlave = 4,
        XIAttachToMaster = 1,
        XIFloating = 2,
    }

    internal enum ValuatorMode
    {
        XIModeRelative = 0,
        XIModeAbsolute = 1,
    }

    internal enum DeviceTypes
    {
        XIMasterPointer = 1,
        XIMasterKeyboard = 2,
        XISlavePointer = 3,
        XISlaveKeyboard = 4,
        XIFloatingSlave = 5,
    }

    internal enum DeviceClass
    {
        XIKeyClass = 0,
        XIButtonClass = 1,
        XIValuatorClass = 2,
        XIScrollClass = 3,
        XITouchClass = 8,
    }

    internal enum ScrollType : int
    {
        XIScrollTypeVertical = 1,
        XIScrollTypeHorizontal = 2,
    }

    [Flags]
    internal enum ScrollFlags
    {
        XIScrollFlagNoEmulation = 1 << 0,
        XIScrollFlagPreferred = 1 << 1,
    }

    [Flags]
    internal enum DeviceEventFlags
    {
        /* Device event flags (key events only) */
        XIKeyRepeat = 1 << 16,
        /* Device event flags (pointer events only) */
        XIPointerEmulated = 1 << 16,
        /* Device event flags (touch events only) */
        XITouchPendingEnd = 1 << 16,
        XITouchEmulatingPointer = 1 << 17,
    }

    internal enum BarrierEventFlags
    {
        XIBarrierPointerReleased = 1 << 0,
        XIBarrierDeviceIsGrabbed = 1 << 1,
    }

    internal enum TouchMode
    {
        XIDirectTouch = 1,
        XIDependentTouch = 2,
    }

    /* Fake device ID's for event selection */
    internal enum DeviceID : int
    {
        XIAllDevices = 0,
        XIAllMasterDevices = 1,
    }

    internal enum XI2EventType
    {
        DeviceChanged = 1,
        KeyPress = 2,
        KeyRelease = 3,
        ButtonPress = 4,
        ButtonRelease = 5,
        Motion = 6,
        Enter = 7,
        Leave = 8,
        FocusIn = 9,
        FocusOut = 10,
        HierarchyChanged = 11,
        PropertyEvent = 12,
        RawKeyPress = 13,
        RawKeyRelease = 14,
        RawButtonPress = 15,
        RawButtonRelease = 16,
        RawMotion = 17,
        TouchBegin = 18, /* XI 2.2 */
        TouchUpdate = 19,
        TouchEnd = 20,
        TouchOwnership = 21,
        RawTouchBegin = 22,
        RawTouchUpdate = 23,
        RawTouchEnd = 24,
        BarrierHit = 25, /* XI 2.3 */
        BarrierLeave = 26,
        LASTEVENT = BarrierLeave,
    }

    [Flags]
    internal enum XI2EventMask
    {
        DeviceChangedMask = 1 << XI2EventType.DeviceChanged,
        KeyPressMask = 1 << XI2EventType.KeyPress,
        KeyReleaseMask = 1 << XI2EventType.KeyRelease,
        ButtonPressMask = 1 << XI2EventType.ButtonPress,
        ButtonReleaseMask = 1 << XI2EventType.ButtonRelease,
        MotionMask = 1 << XI2EventType.Motion,
        EnterMask = 1 << XI2EventType.Enter,
        LeaveMask = 1 << XI2EventType.Leave,
        FocusInMask = 1 << XI2EventType.FocusIn,
        FocusOutMask = 1 << XI2EventType.FocusOut,
        HierarchyChangedMask = 1 << XI2EventType.HierarchyChanged,
        PropertyEventMask = 1 << XI2EventType.PropertyEvent,
        RawKeyPressMask = 1 << XI2EventType.RawKeyPress,
        RawKeyReleaseMask = 1 << XI2EventType.RawKeyRelease,
        RawButtonPressMask = 1 << XI2EventType.RawButtonPress,
        RawButtonReleaseMask = 1 << XI2EventType.RawButtonRelease,
        RawMotionMask = 1 << XI2EventType.RawMotion,
        TouchBeginMask = 1 << XI2EventType.TouchBegin,
        TouchEndMask = 1 << XI2EventType.TouchEnd,
        TouchOwnershipChangedMask = 1 << XI2EventType.TouchOwnership,
        TouchUpdateMask = 1 << XI2EventType.TouchUpdate,
        RawTouchBeginMask = 1 << XI2EventType.RawTouchBegin,
        RawTouchEndMask = 1 << XI2EventType.RawTouchEnd,
        RawTouchUpdateMask = 1 << XI2EventType.RawTouchUpdate,
        BarrierHitMask = 1 << XI2EventType.BarrierHit,
        BarrierLeaveMask = 1 << XI2EventType.BarrierLeave,

    }

    // FIXME: Remove this.
    internal static class Constants
    {
        /* Special property type used for XIGetProperty */
        internal const long XIAnyPropertyType = 0L;
        /* XI2 event mask macros */
        // FIXME:
        /*
        internal const int XISetMask = (ptr, event)   (((unsigned char*)(ptr))[(event)>>3] |=  (1 << ((event) & 7)));
        internal const int XIClearMask = (ptr, event) (((unsigned char*)(ptr))[(event)>>3] &= ~(1 << ((event) & 7)));
        internal const int XIMaskIsSet = (ptr, event) (((unsigned char*)(ptr))[(event)>>3] &   (1 << ((event) & 7)));
        internal const int XIMaskLen = (event)        (((event) >> 3) + 1);
        */
    }
}