//
// KeyboardKeyEventArgs.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using OpenToolkit.Windowing.Common.Input;

namespace OpenToolkit.Windowing.Common
{
    /// <summary>
    /// Defines the event data for <see cref="IWindowEvents.KeyDown"/> and <see cref="IWindowEvents.KeyUp"/> events.
    /// </summary>
    /// <remarks>
    ///  <para>
    /// Do not cache instances of this type outside their event handler.
    /// If necessary, you can clone a KeyboardEventArgs instance using the
    ///  <see cref="KeyboardKeyEventArgs" /> constructor.
    ///  </para>
    /// </remarks>
    public class KeyboardKeyEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KeyboardKeyEventArgs"/> class.
        /// </summary>
        public KeyboardKeyEventArgs()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyboardKeyEventArgs"/> class.
        /// </summary>
        /// <param name="args">An existing <see cref="KeyboardKeyEventArgs"/> instance to clone.</param>
        public KeyboardKeyEventArgs(KeyboardKeyEventArgs args)
        {
            Key = args.Key;
        }

        /// <summary>
        /// Gets the <see cref="Key" /> that generated this event.
        /// </summary>
        public Key Key { get; internal set; }

        /// <summary>
        /// Gets the Unicode scancode which generated this event.
        /// </summary>
        public int ScanCode { get; internal set; }
        
        /// <summary>
        /// Gets a bitwise combination representing the <see cref="OpenToolkit.Windowing.Common.Input.KeyModifiers" />
        /// that are currently pressed.
        /// </summary>
        /// <value>The modifiers.</value>
        public KeyModifiers Modifiers { get; internal set; }

        /// <summary>
        /// Gets a value indicating whether
        /// this key event is a repeat.
        /// </summary>
        /// <value>
        /// true, if this event was caused by the user holding down
        /// a key; false, if this was caused by the user pressing a
        /// key for the first time.
        /// </value>
        public bool IsRepeat { get; internal set; }

        /// <summary>
        /// Gets a value indicating whether <see cref="OpenToolkit.Windowing.Common.Input.KeyModifiers.Alt" /> is pressed.
        /// </summary>
        /// <value><c>true</c> if pressed; otherwise, <c>false</c>.</value>
        public bool Alt => (Modifiers & KeyModifiers.Alt) != 0;

        /// <summary>
        /// Gets a value indicating whether <see cref="OpenToolkit.Windowing.Common.Input.KeyModifiers.Control" /> is pressed.
        /// </summary>
        /// <value><c>true</c> if pressed; otherwise, <c>false</c>.</value>
        public bool Control => (Modifiers & KeyModifiers.Control) != 0;

        /// <summary>
        /// Gets a value indicating whether <see cref="OpenToolkit.Windowing.Common.Input.KeyModifiers.Shift" /> is pressed.
        /// </summary>
        /// <value><c>true</c> if pressed; otherwise, <c>false</c>.</value>
        public bool Shift => (Modifiers & KeyModifiers.Shift) != 0;
    }
}
