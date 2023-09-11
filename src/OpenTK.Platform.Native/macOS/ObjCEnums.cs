using System;
namespace OpenTK.Platform.Native.macOS
{
    public enum CFStringEncoding : uint
    {
        UTF8 = 0x0800_0100,
        UTF16 = 0x0000_0100,
        UTF16BE = 0x1000_0100,
        UTF16LE = 0x1400_0100,
        ASCII = 0x0000_0600,
    }

    // On watchOS this is a uint...
    [Flags]
    public enum NSWindowStyleMask : ulong
    {
        Borderless = 0,
        Titled = 1 << 0,
        Closable = 1 << 1,
        Miniaturizable = 1 << 2,
        Resizable = 1 << 3,
        [Obsolete]
        TexturedBackground = 1 << 8,
        UnifiedTitleAndToolbar = 1 << 12,
        FullScreen = 1 << 14,
        FullSizeContentView = 1 << 15,
        UtilityWindow = 1 << 4,
        DocModalWindow = 1 << 6,
        NonactivatingPanel = 1 << 7,
        HUDWindow = 1 << 13,
    }

    public enum NSBackingStoreType : ulong
    {
        [Obsolete]
        Retained = 0,
        [Obsolete]
        Nonretained = 1,
        Buffered  = 2,
    }

    public enum NSEventType : ulong
    {
        LeftMouseDown = 1,
        LeftMouseUp = 2,
        RightMouseDown = 3,
        RightMouseUp = 4,
        MouseMoved = 5,
        LeftMouseDragged = 6,
        RightMouseDragged = 7,
        MouseEntered = 8,
        MouseExited = 9,
        KeyDown = 10,
        KeyUp = 11,
        FlagsChanged = 12,
        AppKitDefined = 13,
        SystemDefined = 14,
        ApplicationDefined = 15,
        Periodic = 16,
        CursorUpdate = 17,
        ScrollWheel = 22,
        TabletPoint = 23,
        TabletProximity = 24,
        OtherMouseDown = 25,
        OtherMouseUp = 26,
        OtherMouseDragged = 27,

        // The following events are available on some hardward on 10.5.2 and later.
        Gesture = 29,
        Magnify = 30,
        Swipe = 31,
        Rotate = 18,
        BeginGesture = 19,
        EndGesture = 20,

        // If __LP64__ is defined.
        // 10_8
        SmartMagnify = 32,

        // 10_8
        QuickLook = 33,

        // If __LP64__ is defined.
        // 10_10_3
        Pressure = 34,

    }

    [Flags]
    public enum NSEventMask : ulong
    {
        Any = 0xFFFF_FFFF_FFFF_FFFF,

        LeftMouseDown = 1ul << (int)NSEventType.LeftMouseDown,
        LeftMouseUp = 1ul << (int)NSEventType.LeftMouseUp,
        RightMouseDown = 1ul << (int)NSEventType.RightMouseDown,
        RightMouseUp = 1ul << (int)NSEventType.RightMouseUp,
        MouseMoved = 1ul << (int)NSEventType.MouseMoved,
        LeftMouseDragged = 1ul << (int)NSEventType.LeftMouseDragged,
        RightMouseDragged = 1ul << (int)NSEventType.RightMouseDragged,
        MouseEntered = 1ul << (int)NSEventType.MouseEntered,
        MouseExited = 1ul << (int)NSEventType.MouseExited,
        KeyDown = 1ul << (int)NSEventType.KeyDown,
        KeyUp = 1ul << (int)NSEventType.KeyUp,
        FlagsChanged = 1ul << (int)NSEventType.FlagsChanged,
        AppKitDefined = 1ul << (int)NSEventType.AppKitDefined,
        SystemDefined = 1ul << (int)NSEventType.SystemDefined,
        ApplicationDefined = 1ul << (int)NSEventType.ApplicationDefined,
        Periodic = 1ul << (int)NSEventType.Periodic,
        CursorUpdate = 1ul << (int)NSEventType.CursorUpdate,
        ScrollWheel = 1ul << (int)NSEventType.ScrollWheel,
        TabletPoint = 1ul << (int)NSEventType.TabletPoint,
        TabletProximity = 1ul << (int)NSEventType.TabletProximity,
        OtherMouseDown = 1ul << (int)NSEventType.OtherMouseDown,
        OtherMouseUp = 1ul << (int)NSEventType.OtherMouseUp,
        OtherMouseDragged = 1ul << (int)NSEventType.OtherMouseDragged,

        // 10.5.2
        Gesture = 1ul << (int)NSEventType.Gesture,
        Magnify = 1ul << (int)NSEventType.Magnify,
        Swipe = 1ul << (int)NSEventType.Swipe,
        Rotate = 1ul << (int)NSEventType.Rotate,
        BeginGesture = 1ul << (int)NSEventType.BeginGesture,
        EndGesture = 1ul << (int)NSEventType.EndGesture,

        // Only when __LP64__ is defined.
        // 10_8
        SmartMagnify = 1ul << (int)NSEventType.SmartMagnify,
        // 10_10_3
        Pressure = 1ul << (int)NSEventType.Pressure,

    }

    public enum NSApplicationActivationpolicy : long
    {
        Regular,
        Accessory,
        Prohibited,
    }
}

