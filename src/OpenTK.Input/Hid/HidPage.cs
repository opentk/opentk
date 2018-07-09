namespace OpenTK.Input.Hid
{
    /// <summary>
    /// The usage page identifies both the intended usage and the measured values of a human interface device.
    /// </summary>
    public enum HidPage : ushort
    {
        /// <summary>
        /// This page describes an undefined usage.
        /// </summary>
        Undefined = 0x00,

        /// <summary>
        /// This page describes generic desktop controls.
        /// </summary>
        GenericDesktop = 0x01,

        /// <summary>
        /// This page provides detailed descriptions of the usages employed by simulation devices.
        /// </summary>
        Simulation = 0x02,

        /// <summary>
        /// Describes virtual reality controls. The usages depend on designators to identify the individual controls.
        /// </summary>
        VR = 0x03,

        /// <summary>
        /// This page describes sport controls.
        /// </summary>
        Sport = 0x04,

        /// <summary>
        /// This page describes game controls.
        /// </summary>
        Game = 0x05,

        /// <summary>
        /// This page provides usage definitions for controls that can be on any type of device.
        /// </summary>
        GenericDevice = 0x06,

        /// <summary>
        /// This page is for key codes to be used in implementing a USB keyboard.
        /// </summary>
        /// <remarks>
        /// The usage type of all key codes is Selectors (Sel), except for the modifier keys 'Keyboard Left Control'
        /// (0x224) to 'Keyboard Right GUI' (0x231) which are Dynamic Flags (DV).
        /// </remarks>
        KeyboardOrKeypad = 0x07,

        /// <summary>
        /// This page describes an LED or indicator that is implemented as an On/Off control (OOC)
        /// using the "Single button toggle" mode,
        /// where a value of 1 will turn on the indicator, and a value of 0 will turn it off.
        /// </summary>
        LEDs = 0x08,

        /// <summary>
        /// This page describes a set of buttons which can be defined as Sel, OOC, MC or OSC depending on
        /// the context of their declaration.
        /// </summary>
        Button = 0x09,

        /// <summary>
        /// This page allows multiple instances of a control or sets of controls to be declared without
        /// requiring indiviual enumeration in the native usage page.
        /// </summary>
        Ordinal = 0x0A,

        /// <summary>
        /// This page defines the keytop and control usages for telephony devices.
        /// </summary>
        /// <remarks>
        /// Note that in many cases usage definitions are intentionally vague, since it is assumed that
        /// the controls are interpreted by the telephone software application.
        /// </remarks>
        Telephony = 0x0B,

        /// <summary>
        /// This page describes application-specific controls.
        /// They only affect a specific device, not the system as a whole.
        /// </summary>
        Consumer = 0x0C,

        /// <summary>
        /// This section provides detailed descriptions of the usages employed by Digitizer Devices.
        /// </summary>
        Digitizer = 0x0D,

        // 0x0E                     // Reserved

        /// <summary>
        /// Describes force feedback and related devices.
        /// </summary>
        PID = 0x0F,

        /// <summary>
        /// The Unicode page directly maps to the two-octet form defined in the Unicode Standard.
        /// </summary>
        Unicode = 0x10,

        // 0x11 - 0x13              // Reserved

        /// <summary>
        /// The Alphanumeric display page is intended for use by simple alphanumeric
        /// displays that are used on consumer devices.
        /// </summary>
        AlphanumericDisplay = 0x14,

        // 0x15 - 0x3F              // Reserved

        /// <summary>
        /// This page provides usage definitions for medical instruments.
        /// </summary>
        MedicalInstruments = 0x40,

        // 0x41 - 0x7F

        // 0x80 - 0x83              // USB Device Class Definition for Monitor Devices

        /// <summary>
        /// Power device page.
        /// </summary>
        PowerDevice = 0x84,

        /// <summary>
        /// Battery system page.
        /// </summary>
        BatterySystem = 0x85,

        // 0x86 - 0x87              // USB Device Class Definition for Power Devices (also includes 0x84 and 0x85)

        // 0x88 - 0x8B              // Reserved

        /// <summary>
        /// This page describes the USB Device Class definition for a bar code scanner ("Point of Sale" device).
        /// </summary>
        BarCodeScanner = 0x8C,

        /// <summary>
        /// This page describes the USB Device Class definition for a scale ("Point of Sale" device).
        /// </summary>
        Scale = 0x8D,

        /// <summary>
        /// This page describes the USB Device Class definition for a magnetic stripe reading device
        /// ("Point of Sale" device).
        /// </summary>
        MagneticStripeReader = 0x8E,

        // 0x8F                     // Reserved Point of Sale pages

        /// <summary>
        /// This page describes the USB Device Class definition for "Image Class Devices".
        /// </summary>
        CameraControl = 0x90,

        /// <summary>
        /// This page describes the OAAF definitions for arcade and coinop related devices.
        /// </summary>
        Arcade = 0x91,

        // 0x92 - 0xFEFF            // Reserved

        /// <summary>
        /// Marks the beginning of vendor-defined usage pages.
        /// </summary>
        VendorDefinedStart = 0xFF00,

        // 0xFF00 - 0xFFFF          // Vendor-defined
    }
}
