//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
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

using System;

namespace OpenTK.Platform
{
    /// <summary>
    /// Enumeration for all available platform abstraction layer components.
    /// </summary>
    [Flags]
    public enum PalComponents
    {
        /// <summary>
        /// Abstraction layer provides the OpenGL component.
        /// </summary>
        OpenGL = 1 << 0,

        /// <summary>
        /// Abstraction layer provides the Vulkan component.
        /// </summary>
        Vulkan = 1 << 1,

        /// <summary>
        /// Abstraction layer provides the window icon component.
        /// </summary>
        WindowIcon = 1 << 2,

        /// <summary>
        /// Abstraction layer provides the cursor component.
        /// </summary>
        MouseCursor = 1 << 3,

        /// <summary>
        /// Abstraction layer provides the window component.
        /// </summary>
        Window = 1 << 4,

        /// <summary>
        /// Abstraction layer provides the surface component.
        /// </summary>
        Surface = 1 << 5,

        /// <summary>
        /// Abstraction layer provides the display component.
        /// </summary>
        Display = 1 << 6,

        /// <summary>
        /// Abstraction layer provides the mouse input component.
        /// </summary>
        MiceInput = 1 << 7,

        /// <summary>
        /// Abstraction layer provides the keyboard input component.
        /// </summary>
        KeyboardInput = 1 << 8,

        /// <summary>
        /// Abstraction layer provides the controller input component.
        /// </summary>
        ControllerInput = 1 << 9,

        /// <summary>
        /// Abstraction layer provides the clipboard component.
        /// </summary>
        Clipboard = 1 << 10,

        /// <summary>
        /// Abstraction layer provides the shell component.
        /// </summary>
        Shell = 1 << 11,

        /// <summary>
        /// Abstraction layer provides the joystick component.
        /// </summary>
        Joystick = 1 << 12,

        /// <summary>
        /// Abstraction layer provides the dialog component.
        /// </summary>
        Dialog = 1 << 13,
    }
}
