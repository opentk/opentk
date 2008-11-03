using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.Math;

namespace OpenTK.Input
{
#if false
    /// <summary>
    /// Represents a joystick device and provides methods to query its state.
    /// </summary>
    public class JoystickDevice : IInputDevice
    {
        string description;
        Vector2[] axis_position;

    #region --- IInputDevice Members ---

        /// <summary>
        /// Gets a string describing this JoystickDevice.
        /// </summary>
        public string Description
        {
            get { return description; }
            internal set { description = value; }
        }

        /// <summary>
        /// Gets a value indicating the InputDeviceType of this InputDevice. 
        /// </summary>
        public InputDeviceType DeviceType
        {
            get { return InputDeviceType.HID; }
        }

        #endregion

    #region --- Public Methods ---

        //public Vector2 Axis1
        //{
        //    get { return axis_position.Clone(); }
        //    internal set { 
        //}

        #endregion
    }
#endif
}
