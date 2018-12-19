//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2018 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

namespace OpenToolkit.Input
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
        /// Gets an OpenToolkit.Input.InputDeviceType value, representing the device type of this IInputDevice instance.
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
