namespace OpenTK.Input.Hid
{
    /// <summary>
    /// Describes usages for the <see cref="HidPage.GenericDesktop"/> page.
    /// </summary>
    public enum HidGenericDesktopUsage : ushort
    {
        /// <summary>
        /// A collection of axes that generates a value to direct, indicate, or point
        /// user intentions to an application.
        /// </summary>
        Pointer = 0x01,

        /// <summary>
        /// A hand-held, button-activated input device that when rolled along a flat surface,
        /// directs an indicator to move correspondingly about a computer screen, allowing the
        /// operator to move the indicator freely in select operations or to manipulate text or graphics.
        /// </summary>
        Mouse = 0x02,

        // 0x03                     // Reserved

        /// <summary>
        /// A manual control or cursor device.
        /// </summary>
        Joystick = 0x04,

        /// <summary>
        /// A manual control or cursor device.
        /// </summary>
        GamePad = 0x05,

        /// <summary>
        /// The primary computer input device.
        /// </summary>
        Keyboard = 0x06,

        /// <summary>
        /// Any keyboard configuration that does not meet the minimum requirements of the Boot Keyboard.
        /// </summary>
        Keypad = 0x07,

        /// <summary>
        /// An input device used to orient eyepoints and or objects in 3 dimensional space.
        /// </summary>
        MultiAxisController = 0x08,

        // 0x09 - 0x2F              // Reserved

        /// <summary>
        /// A linear translation in the X direction.
        /// </summary>
        X = 0x30,

        /// <summary>
        /// A linear translation in the Y direction.
        /// </summary>
        Y = 0x31,

        /// <summary>
        /// A linear translation in the Z direction.
        /// </summary>
        Z = 0x32,

        /// <summary>
        /// A rotation about the X axis. Angular position report values follow the righthand rule.
        /// </summary>
        RotationX = 0x33,

        /// <summary>
        /// A rotation about the Y axis. Angular position report values follow the righthand rule.
        /// </summary>
        RotationY = 0x34,

        /// <summary>
        /// A rotation about the Z axis. Angular position report values follow the righthand rule.
        /// </summary>
        RotationZ = 0x35,

        /// <summary>
        /// A linear control for generating a variable value, normally in the form of a thumb slide in a slot.
        /// </summary>
        Slider = 0x36,

        /// <summary>
        /// A rotary control for generating a variable value,
        /// normally in the form of a knob spun by the index finger and thumb.
        /// </summary>
        Dial = 0x37,

        /// <summary>
        /// A rotary control for generating a variable value, normally rolled, unlike a dial.
        /// </summary>
        Wheel = 0x38,

        /// <summary>
        /// A specialized mechanical configuration of switches generating a variable value with a null state.
        /// </summary>
        Hatswitch = 0x39,

        /// <summary>
        /// Used with buffered –byte data to indicate the number of valid bytes in the buffered-byte field.
        /// </summary>
        CountedBuffer = 0x3A,

        /// <summary>
        /// Defines a report field that indicates the number of meaningful data bytes
        /// in an associated buffered-byte field.
        /// </summary>
        ByteCount = 0x3B,

        /// <summary>
        /// Enables the generation of a USB remote wakeup when the device detects motion.
        /// </summary>
        MotionWakeup = 0x3C,

        /// <summary>
        /// Session start button.
        /// </summary>
        Start = 0x3D,

        /// <summary>
        /// Application option select button.
        /// </summary>
        Select = 0x3E,

        // 0x3F                     // Reserved

        /// <summary>
        /// A vector in the X direction.
        /// </summary>
        VectorX = 0x40,

        /// <summary>
        /// A vector in the Y direction.
        /// </summary>
        VectorY = 0x41,

        /// <summary>
        /// A vector in the Z direction.
        /// </summary>
        VectorZ = 0x42,

        /// <summary>
        /// A vector in the X direction relative to the body of an object.
        /// </summary>
        VectorXBodyRelative = 0x43,

        /// <summary>
        /// A vector in the Y direction relative to the body of an object.
        /// </summary>
        VectorYBodyRelative = 0x44,

        /// <summary>
        /// A vector in the Z direction relative to the body of an object.
        /// </summary>
        VectorZBodyRelative = 0x45,

        /// <summary>
        /// A non oriented vector or value.
        /// </summary>
        VectorNonOriented = 0x46,

        // 0x47 - 0x7F              // Reserved

        /// <summary>
        /// An application-level collection that contains system-software-specific usages.
        /// </summary>
        SystemControl = 0x80,

        /// <summary>
        /// Asserted when the intended action is to initiate system-wide power down now from
        /// Full Power or Sleep states.
        /// </summary>
        SystemPowerDown = 0x81,

        /// <summary>
        /// Asserted when the intended action is to initiate system-wide low power mode now.
        /// </summary>
        SystemSleep = 0x82,

        /// <summary>
        /// Asserted when the intended action is to initiate system-wide Full Power state now.
        /// </summary>
        SystemWakeUp = 0x83,

        /// <summary>
        /// Evokes a context-sensitive menu.
        /// </summary>
        SystemContextMenu = 0x84,

        /// <summary>
        /// Evokes the OS main-level selection menu.
        /// </summary>
        SystemMainMenu = 0x85,

        /// <summary>
        /// Displays an application-specific menu.
        /// </summary>
        SystemAppMenu = 0x86,

        /// <summary>
        /// Displays the help menu.
        /// </summary>
        SystemMenuHelp = 0x87,

        /// <summary>
        /// Exits a menu.
        /// </summary>
        SystemMenuExit = 0x88,

        /// <summary>
        /// Selects a menu item.
        /// </summary>
        SystemMenuSelect = 0x89,

        /// <summary>
        /// Menu select right.
        /// </summary>
        SystemMenuRight = 0x8A,

        /// <summary>
        /// Menu select left.
        /// </summary>
        SystemMenuLeft = 0x8B,

        /// <summary>
        /// Menu select up.
        /// </summary>
        SystemMenuUp = 0x8C,

        /// <summary>
        /// Menu select down.
        /// </summary>
        SystemMenuDown = 0x8D,

        // 0x8E - 0x8F              // Reserved

        /// <summary>
        /// Indicates that top of a Direction Pad is pressed.
        /// </summary>
        DPadUp = 0x90,

        /// <summary>
        /// Indicates that bottom of a Direction Pad is pressed
        /// </summary>
        DPadDown = 0x91,

        /// <summary>
        /// Indicates that right side of a Direction Pad is pressed
        /// </summary>
        DPadRight = 0x92,

        /// <summary>
        /// Indicates that left side of a Direction Pad is pressed
        /// </summary>
        DPadLeft = 0x93,

        // 0x94 - 0xFFFF            // Reserved
    }
}
