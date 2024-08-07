using System;
namespace OpenTK.Platform.Native.macOS
{
    [Flags]
    internal enum NSDragOperation : ulong
    {
        None = 0,
        Copy = 1,
        Link = 2,
        Generic = 4,
        Private = 8,
        Move = 16,
        Delete = 32,
        Every = ulong.MaxValue,
    }
    
    internal enum CFStringEncoding : uint
    {
        // Incomplete enum...
        UTF8 = 0x0800_0100,
        UTF16 = 0x0000_0100,
        UTF16BE = 0x1000_0100,
        UTF16LE = 0x1400_0100,
        ASCII = 0x0000_0600,
    }

    internal enum NSAlertStyle : uint
    {
        NSAlertStyleWarning = 0,
        NSAlertStyleInformational = 1,
        NSAlertStyleCritical = 2,
    }

    internal enum NSStringEncoding : ulong
    {
        // Incomplete enum...
        ASCII = 1,
        UTF8 = 4,
        UTF16 = 10,
        UTF16BE = 0x90000100,
        UTF16LE = 0x94000100,
    }

    // On watchOS this is a uint...
    [Flags]
    internal enum NSWindowStyleMask : ulong
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

    internal enum NSBackingStoreType : ulong
    {
        [Obsolete]
        Retained = 0,
        [Obsolete]
        Nonretained = 1,
        Buffered  = 2,
    }

    internal enum NSEventType : ulong
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
    internal enum NSEventMask : ulong
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

    internal enum NSApplicationActivationpolicy : long
    {
        Regular,
        Accessory,
        Prohibited,
    }

    internal enum NSRequestUserAttentionType : ulong
    {
        CriticalRequest = 0,
        InformationalRequest = 10,
    }

    internal enum NSWindowLevel : long
    {
        Normal = 0,
        Floating = 3,
        Submenu = 3,
        TornOffMenu = 3,
        MainMenu = 24,
        Status = 25,
        ModalPanel = 8,
        PopUpMenu = 101,
        ScreenSaver = 1000,
    }

    // This is defined as nsuinteger
    [Flags]
    internal enum NSTrackingAreaOptions : uint
    {
        MouseEnteredAndExited = 0x01,
        MouseMoved = 0x02,
        CursorUpdate = 0x04,
        NSTrackingActiveWhenFirstResponder = 0x10,
        ActiveInKeyWindow = 0x20,
        ActiveInActiveApp = 0x40,
        ActiveAlways = 0x80,
        InVisibleRect = 0x200,
        EnabledDuringMouseDrag = 0x400,
    }

    // From https://github.com/gnustep/libs-gui/blob/master/Headers/AppKit/NSGraphicsContext.h
    // These are not the formal defintions of the "operator" instead these are the old ones...
    internal enum NSCompositingOperator : uint
    {
        Clear,
        Copy,
        SourceOver,
        SourceIn,
        SourceOut,
        SourceAtop,
        DestinationOver,
        DestinationIn,
        DestinationOut,
        DestinationAtop,
        XOR,
        PlusDarker,
        Highlight,
        PlusLighter,
    }

    [Flags]
    internal enum NSBitmapFormat : uint
    {
        AlphaFirst = 1 << 0,
        AlphaNonpremultiplied = 1 << 1,
        FloatingPointSamples = 1 << 2,

        SixteenBitLittleEndian = 1 << 8,
        ThirtyTwoBitLittleEndian = 1 << 9,

        SixteenBitBigEndian = 1 << 10,
        ThirtyTwoBitBigEndian = 1 << 11,
    }

    internal enum NSImageSymbolScale : int
    {
        Small = 1,
        Medium = 2,
        Large = 3,
    }

    internal enum NSModalResponse : int
    {
        OK = 1,
        Cancel = 0,

        Stop = (-1000), // Also used as the default response for sheets
        Abort = (-1001),
        Continue = (-1002),

        AlertFirstButtonReturn = 1000,
        AlertSecondButtonReturn = 1001,
        AlertThirdButtonReturn = 1002,
    }

    [Flags]
    internal enum ModifierFlags : ulong
    {
        NX_DEVICELCTLKEYMASK = 1 << 0,
        NX_DEVICELSHIFTKEYMASK = 1 << 1,
        NX_DEVICERSHIFTKEYMASK = 1 << 2,
        NX_DEVICELCMDKEYMASK = 1 << 3,
        NX_DEVICERCMDKEYMASK = 1 << 4,
        NX_DEVICELALTKEYMASK = 1 << 5,
        NX_DEVICERALTKEYMASK = 1 << 6,
        NX_DEVICERCTLKEYMASK = 1 << 13,

        CapsLock = 1 << 16,
        Shift = 1 << 17,
        Control = 1 << 18,
        Option = 1 << 19,
        Command = 1 << 20,
        NumericPad = 1 << 21,
        Help = 1 << 22,
        Function = 1 << 23,
    }

    internal enum VK
    {
        kVK_ANSI_A = 0x00,
        kVK_ANSI_S = 0x01,
        kVK_ANSI_D = 0x02,
        kVK_ANSI_F = 0x03,
        kVK_ANSI_H = 0x04,
        kVK_ANSI_G = 0x05,
        kVK_ANSI_Z = 0x06,
        kVK_ANSI_X = 0x07,
        kVK_ANSI_C = 0x08,
        kVK_ANSI_V = 0x09,
        kVK_ANSI_B = 0x0B,
        kVK_ANSI_Q = 0x0C,
        kVK_ANSI_W = 0x0D,
        kVK_ANSI_E = 0x0E,
        kVK_ANSI_R = 0x0F,
        kVK_ANSI_Y = 0x10,
        kVK_ANSI_T = 0x11,
        kVK_ANSI_1 = 0x12,
        kVK_ANSI_2 = 0x13,
        kVK_ANSI_3 = 0x14,
        kVK_ANSI_4 = 0x15,
        kVK_ANSI_6 = 0x16,
        kVK_ANSI_5 = 0x17,
        kVK_ANSI_Equal = 0x18,
        kVK_ANSI_9 = 0x19,
        kVK_ANSI_7 = 0x1A,
        kVK_ANSI_Minus = 0x1B,
        kVK_ANSI_8 = 0x1C,
        kVK_ANSI_0 = 0x1D,
        kVK_ANSI_RightBracket = 0x1E,
        kVK_ANSI_O = 0x1F,
        kVK_ANSI_U = 0x20,
        kVK_ANSI_LeftBracket = 0x21,
        kVK_ANSI_I = 0x22,
        kVK_ANSI_P = 0x23,
        kVK_ANSI_L = 0x25,
        kVK_ANSI_J = 0x26,
        kVK_ANSI_Quote = 0x27,
        kVK_ANSI_K = 0x28,
        kVK_ANSI_Semicolon = 0x29,
        kVK_ANSI_Backslash = 0x2A,
        kVK_ANSI_Comma = 0x2B,
        kVK_ANSI_Slash = 0x2C,
        kVK_ANSI_N = 0x2D,
        kVK_ANSI_M = 0x2E,
        kVK_ANSI_Period = 0x2F,
        kVK_ANSI_Grave = 0x32,
        kVK_ANSI_KeypadDecimal = 0x41,
        kVK_ANSI_KeypadMultiply = 0x43,
        kVK_ANSI_KeypadPlus = 0x45,
        kVK_ANSI_KeypadClear = 0x47,
        kVK_ANSI_KeypadDivide = 0x4B,
        kVK_ANSI_KeypadEnter = 0x4C,
        kVK_ANSI_KeypadMinus = 0x4E,
        kVK_ANSI_KeypadEquals = 0x51,
        kVK_ANSI_Keypad0 = 0x52,
        kVK_ANSI_Keypad1 = 0x53,
        kVK_ANSI_Keypad2 = 0x54,
        kVK_ANSI_Keypad3 = 0x55,
        kVK_ANSI_Keypad4 = 0x56,
        kVK_ANSI_Keypad5 = 0x57,
        kVK_ANSI_Keypad6 = 0x58,
        kVK_ANSI_Keypad7 = 0x59,
        kVK_ANSI_Keypad8 = 0x5B,
        kVK_ANSI_Keypad9 = 0x5C,

        kVK_Return = 0x24,
        kVK_Tab = 0x30,
        kVK_Space = 0x31,
        kVK_Delete = 0x33,
        kVK_Escape = 0x35,
        kVK_Command = 0x37,
        kVK_Shift = 0x38,
        kVK_CapsLock = 0x39,
        kVK_Option = 0x3A,
        kVK_Control = 0x3B,
        kVK_RightShift = 0x3C,
        kVK_RightOption = 0x3D,
        kVK_RightControl = 0x3E,
        kVK_Function = 0x3F,
        kVK_F17 = 0x40,
        kVK_VolumeUp = 0x48,
        kVK_VolumeDown = 0x49,
        kVK_Mute = 0x4A,
        kVK_F18 = 0x4F,
        kVK_F19 = 0x50,
        kVK_F20 = 0x5A,
        kVK_F5 = 0x60,
        kVK_F6 = 0x61,
        kVK_F7 = 0x62,
        kVK_F3 = 0x63,
        kVK_F8 = 0x64,
        kVK_F9 = 0x65,
        kVK_F11 = 0x67,
        kVK_F13 = 0x69,
        kVK_F16 = 0x6A,
        kVK_F14 = 0x6B,
        kVK_F10 = 0x6D,
        kVK_F12 = 0x6F,
        kVK_F15 = 0x71,
        kVK_Help = 0x72,
        kVK_Home = 0x73,
        kVK_PageUp = 0x74,
        kVK_ForwardDelete = 0x75,
        kVK_F4 = 0x76,
        kVK_End = 0x77,
        kVK_F2 = 0x78,
        kVK_PageDown = 0x79,
        kVK_F1 = 0x7A,
        kVK_LeftArrow = 0x7B,
        kVK_RightArrow = 0x7C,
        kVK_DownArrow = 0x7D,
        kVK_UpArrow = 0x7E,

        kVK_ISO_Section = 0x0A,

        kVK_JIS_Yen = 0x5D,
        kVK_JIS_Underscore = 0x5E,
        kVK_JIS_KeypadComma = 0x5F,
        kVK_JIS_Eisu = 0x66,
        kVK_JIS_Kana = 0x68,
    }
}

