namespace OpenTK.Input.Hid
{
    // Generic desktop usage
    public enum HidUsageGD : ushort
    {
        Pointer = 0x01,             // Physical Collection
        Mouse = 0x02,               // Application Collection

        // 0x03                     // Reserved
        Joystick = 0x04,            // Application Collection
        GamePad = 0x05,             // Application Collection
        Keyboard = 0x06,            // Application Collection
        Keypad = 0x07,              // Application Collection
        MultiAxisController = 0x08, // Application Collection

        // 0x09 - 0x2F              // Reserved
        X = 0x30,                   // Dynamic Value
        Y = 0x31,                   // Dynamic Value
        Z = 0x32,                   // Dynamic Value
        Rx = 0x33,                  // Dynamic Value
        Ry = 0x34,                  // Dynamic Value
        Rz = 0x35,                  // Dynamic Value
        Slider = 0x36,              // Dynamic Value
        Dial = 0x37,                // Dynamic Value
        Wheel = 0x38,               // Dynamic Value
        Hatswitch = 0x39,           // Dynamic Value
        CountedBuffer = 0x3A,       // Logical Collection
        ByteCount = 0x3B,           // Dynamic Value
        MotionWakeup = 0x3C,        // One-Shot Control
        Start = 0x3D,               // On/Off Control
        Select = 0x3E,              // On/Off Control

        // 0x3F                     // Reserved
        Vx = 0x40,                  // Dynamic Value
        Vy = 0x41,                  // Dynamic Value
        Vz = 0x42,                  // Dynamic Value
        Vbrx = 0x43,                // Dynamic Value
        Vbry = 0x44,                // Dynamic Value
        Vbrz = 0x45,                // Dynamic Value
        Vno = 0x46,                 // Dynamic Value

        // 0x47 - 0x7F              // Reserved
        SystemControl = 0x80,       // Application Collection
        SystemPowerDown = 0x81,     // One-Shot Control
        SystemSleep = 0x82,         // One-Shot Control
        SystemWakeUp = 0x83,        // One-Shot Control
        SystemContextMenu = 0x84,   // One-Shot Control
        SystemMainMenu = 0x85,      // One-Shot Control
        SystemAppMenu = 0x86,       // One-Shot Control
        SystemMenuHelp = 0x87,      // One-Shot Control
        SystemMenuExit = 0x88,      // One-Shot Control
        SystemMenu = 0x89,          // Selector
        SystemMenuRight = 0x8A,     // Re-Trigger Control
        SystemMenuLeft = 0x8B,      // Re-Trigger Control
        SystemMenuUp = 0x8C,        // Re-Trigger Control
        SystemMenuDown = 0x8D,      // Re-Trigger Control

        // 0x8E - 0x8F              // Reserved
        DPadUp = 0x90,              // On/Off Control
        DPadDown = 0x91,            // On/Off Control
        DPadRight = 0x92,           // On/Off Control
        DPadLeft = 0x93,            // On/Off Control

        // 0x94 - 0xFFFF            // Reserved
        Reserved = 0xFFFF
    }
}
