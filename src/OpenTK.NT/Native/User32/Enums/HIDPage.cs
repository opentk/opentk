namespace OpenTK.NT.Native
{
    public enum HIDPage : ushort
    {
        Undefined = 0x00,
        GenericDesktop = 0x01,
        Simulation = 0x02,
        VR = 0x03,
        Sport = 0x04,
        Game = 0x05,

        // Reserved 0x06
        KeyboardOrKeypad =
            0x07, // USB Device Class Definition for Human Interface Devices (HID). Note: the usage type for all key codes is Selector (Sel).
        LEDs = 0x08,
        Button = 0x09,
        Ordinal = 0x0A,
        Telephony = 0x0B,
        Consumer = 0x0C,
        Digitizer = 0x0D,

        // Reserved 0x0E
        PID = 0x0F, // USB Physical Interface Device definitions for force feedback and related devices.
        Unicode = 0x10,

        // Reserved 0x11 - 0x13
        AlphanumericDisplay = 0x14,

        // Reserved 0x15 - 0x7F
        // Monitor 0x80 - 0x83   USB Device Class Definition for Monitor Devices
        // Power 0x84 - 0x87     USB Device Class Definition for Power Devices
        PowerDevice = 0x84, // Power Device Page
        BatterySystem = 0x85, // Battery System Page

        // Reserved 0x88 - 0x8B
        BarCodeScanner = 0x8C, // (Point of Sale) USB Device Class Definition for Bar Code Scanner Devices
        WeighingDevice = 0x8D, // (Point of Sale) USB Device Class Definition for Weighing Devices
        Scale = 0x8D, // (Point of Sale) USB Device Class Definition for Scale Devices
        MagneticStripeReader = 0x8E,

        // ReservedPointofSalepages 0x8F
        CameraControl = 0x90, // USB Device Class Definition for Image Class Devices
        Arcade = 0x91, // OAAF Definitions for arcade and coinop related Devices

        // Reserved 0x92 - 0xFEFF
        // VendorDefined 0xFF00 - 0xFFFF
        VendorDefinedStart = 0xFF00
    }
}
