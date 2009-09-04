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
    /// Encapsulates the state of a Keyboard device.
    /// </summary>
    public struct KeyboardState : IEquatable<KeyboardState>
    {
        #region Fields

        const int NumKeys = ((int)Key.LastKey + 16) / 32;
        // Todo: The following line triggers bogus CS0214 in gmcs 2.0.1, sigh...
        // Need to add a workaround using either ExplicitLayout or another trick.
        //unsafe fixed int Keys[NumKeys];

        #endregion

        #region Constructors

        #endregion

        #region Public Members

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> indicating whether this key is down.
        /// </summary>
        /// <param name="key">The <see cref="OpenTK.Input.Key"/> to check.</param>
        public bool IsKeyDown(Key key)
        {
            return ReadBit((int)key) != 0;
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> indicating whether this key is up.
        /// </summary>
        /// <param name="key">The <see cref="OpenTK.Input.Key"/> to check.</param>
        public bool IsKeyUp(Key key)
        {
            return ReadBit((int)key) == 0;
        }

        #endregion

        #region Internal Members

        internal int ReadBit(int offset)
        {
            return 0;
            //unsafe { return (Keys[(offset / 32)] & (1 << (offset % 32))); }
        }

        internal enum BitValue { Zero = 0, One = 1 }
        internal void WriteBit(int offset, BitValue bit)
        {
            // Todo: this is completely broken.
            //unsafe { Keys[offset / 32] = Keys[offset / 32] ^ (~(int)bit << (offset % 32)); }
        }

        #endregion

        #region IEquatable<KeyboardState> Members

        /// <summary>
        /// Compares two KeyboardState instances.
        /// </summary>
        /// <param name="other">The instance to compare two.</param>
        /// <returns>True, if both instances are equal; false otherwise.</returns>
        public bool Equals(KeyboardState other)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
