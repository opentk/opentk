#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Input
{
    /// <summary>
    /// Defines a common interface for all input devices.
    /// </summary>
    public interface IInputDevice
    {
        /// <summary>
        /// Gets a System.String with a unique description of this IInputDevice instance.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Gets an OpenTK.Input.InputDeviceType value, representing the device type of this IInputDevice instance.
        /// </summary>
        InputDeviceType DeviceType { get; }
    }

    /// <summary>
    /// The type of the input device.
    /// </summary>
    public enum InputDeviceType
    {
        /// <summary>
        /// Device is a keyboard.
        /// </summary>
        Keyboard,
        /// <summary>
        /// Device is a mouse.
        /// </summary>
        Mouse,
        /// <summary>
        /// Device is a Human Interface Device. Joysticks, joypads, pens
        /// and some specific usb keyboards/mice fall into this category.
        /// </summary>
        Hid
    }
}
