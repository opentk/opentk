namespace OpenTK.Input.Hid
{
    //todo: XMLdoc here
    public enum HidPage : ushort
    {
        Undefined = 0x00,
        GenericDesktop = 0x01,
        Simulation = 0x02,
        VR = 0x03,
        Sport = 0x04,
        Game = 0x05,

        // 0x06                     // Reserved
        KeyboardOrKeypad = 0x07,    // USB Device Class Definition for Human Interface Devices (HID). 
                                    // Note: the usage type for all key codes is Selector (Sel).
        LEDs = 0x08,
        Button = 0x09,
        Ordinal = 0x0A,
        Telephony = 0x0B,
        Consumer = 0x0C,
        Digitizer = 0x0D,

        // 0x0E                     // Reserved
        PID = 0x0F,                 // USB Physical Interface Device definitions for force feedback and related devices.
        Unicode = 0x10,

        // 0x11 - 0x13              // Reserved
        AlphanumericDisplay = 0x14,

        // 0x15 - 0x7F              // Reserved
        // 0x80 - 0x83              // USB Device Class Definition for Monitor Devices
        // 0x84 - 0x87              // USB Device Class Definition for Power Devices
        PowerDevice = 0x84,         // Power Device Page
        BatterySystem = 0x85,       // Battery System Page

        // 0x88 - 0x8B              // Reserved
        BarCodeScanner = 0x8C,      // (Point of Sale) USB Device Class Definition for Bar Code Scanner Devices
        WeighingDevice = 0x8D,      // (Point of Sale) USB Device Class Definition for Weighing Devices
        Scale = 0x8D,               // (Point of Sale) USB Device Class Definition for Scale Devices
        MagneticStripeReader = 0x8E,

        // 0x8F                     // Reserved Point of Sale pages
        CameraControl = 0x90,       // USB Device Class Definition for Image Class Devices
        Arcade = 0x91,              // OAAF Definitions for arcade and coinop related Devices

        // 0x92 - 0xFEFF            // Reserved
        // 0xFF00 - 0xFFFF          // Vendor-defined
        VendorDefinedStart = 0xFF00
    }
}
