// #region License
// //
// // The Open Toolkit Library License
// //
// // Copyright (c) 2006 - 2009 the Open Toolkit library.
// //
// // Permission is hereby granted, free of charge, to any person obtaining a copy
// // of this software and associated documentation files (the "Software"), to deal
// // in the Software without restriction, including without limitation the rights to 
// // use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// // the Software, and to permit persons to whom the Software is furnished to do
// // so, subject to the following conditions:
// //
// // The above copyright notice and this permission notice shall be included in all
// // copies or substantial portions of the Software.
// //
// // THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// // EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// // OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// // NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// // HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// // WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// // FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// // OTHER DEALINGS IN THE SOFTWARE.
// //
// #endregion

using System;

namespace OpenTK
{
    /// <summary>
    /// Defines the event arguments for KeyPress events. Instances of this class are cached:
    /// KeyPressEventArgs should only be used inside the relevant event, unless manually cloned.
    /// </summary>
    public class KeyPressEventArgs : EventArgs
    {
        char key_char;
        
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// <param name="keyChar">The ASCII character that was typed.</param>
        public KeyPressEventArgs(char keyChar)
        {
            KeyChar = keyChar;
        }

        /// <summary>
        /// Gets a <see cref="System.Char"/> that defines the ASCII character that was typed.
        /// </summary>
        public char KeyChar
        {
            get { return key_char; }
            internal set { key_char = value; }
        }
    }
}
