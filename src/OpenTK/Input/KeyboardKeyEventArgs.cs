#region License
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
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Input
{
    /// <summary>
    /// Defines the event data for <see cref="KeyboardDevice"/> events.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Do not cache instances of this type outside their event handler.
    /// If necessary, you can clone a KeyboardEventArgs instance using the 
    /// <see cref="KeyboardKeyEventArgs(KeyboardKeyEventArgs)"/> constructor.
    /// </para>
    /// </remarks>
    public class KeyboardKeyEventArgs : EventArgs
    {
        #region Fields

        Key key;
        bool repeat;
        KeyboardState state;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a new KeyboardEventArgs instance.
        /// </summary>
        public KeyboardKeyEventArgs() { }

        /// <summary>
        /// Constructs a new KeyboardEventArgs instance.
        /// </summary>
        /// <param name="args">An existing KeyboardEventArgs instance to clone.</param>
        public KeyboardKeyEventArgs(KeyboardKeyEventArgs args)
        {
            Key = args.Key;
        }

        #endregion

        #region Public Members

        /// <summary>
        /// Gets the <see cref="Key"/> that generated this event.
        /// </summary>
        public Key Key
        {
            get { return key; }
            internal set { key = value; }
        }

        /// <summary>
        /// Gets the scancode which generated this event.
        /// </summary>
        [CLSCompliant(false)]
        public uint ScanCode
        {
            get { return (uint)Key; }
        }

        /// <summary>
        /// Gets a value indicating whether <see cref="OpenTK.Input.KeyModifiers.Alt"/> is pressed.
        /// </summary>
        /// <value><c>true</c> if pressed; otherwise, <c>false</c>.</value>
        public bool Alt
        {
            get { return state[Key.AltLeft] || state[Key.AltRight]; }
        }

        /// <summary>
        /// Gets a value indicating whether <see cref="OpenTK.Input.KeyModifiers.Control"/> is pressed.
        /// </summary>
        /// <value><c>true</c> if pressed; otherwise, <c>false</c>.</value>
        public bool Control
        {
            get { return state[Key.ControlLeft] || state[Key.ControlRight]; }
        }

        /// <summary>
        /// Gets a value indicating whether <see cref="OpenTK.Input.KeyModifiers.Shift"/> is pressed.
        /// </summary>
        /// <value><c>true</c> if pressed; otherwise, <c>false</c>.</value>
        public bool Shift
        {
            get { return state[Key.ShiftLeft] || state[Key.ShiftRight]; }
        }

        /// <summary>
        /// Gets a bitwise combination representing the <see cref="OpenTK.Input.KeyModifiers"/>
        /// that are currently pressed.
        /// </summary>
        /// <value>The modifiers.</value>
        public KeyModifiers Modifiers
        {
            get
            {
                KeyModifiers mods = 0;
                mods |= Alt ? KeyModifiers.Alt : 0;
                mods |= Control ? KeyModifiers.Control : 0;
                mods |= Shift ? KeyModifiers.Shift : 0;
                return mods;
            }
        }

        /// <summary>
        /// Gets the current <see cref="OpenTK.Input.KeyboardState"/>.
        /// </summary>
        /// <value>The keyboard.</value>
        public KeyboardState Keyboard
        {
            get { return state; }
            internal set { state = value; }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> indicating whether
        /// this key event is a repeat.
        /// </summary>
        /// <value>
        /// true, if this event was caused by the user holding down
        /// a key; false, if this was caused by the user pressing a
        /// key for the first time.
        /// </value>
        public bool IsRepeat
        {
            get { return repeat; }
            internal set { repeat = value; }
        }

        #endregion
    }
}
