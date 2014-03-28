#region License
//
// JoystickAxis.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2006-2014 Stefanos Apostolopoulos
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Input
{
    /// <summary>
    /// Defines available JoystickDevice axes.
    /// </summary>
    public enum JoystickAxis
    {
        /// <summary>The first axis of the JoystickDevice.</summary>
        Axis0 = 0,
        /// <summary>The second axis of the JoystickDevice.</summary>
        Axis1,
        /// <summary>The third axis of the JoystickDevice.</summary>
        Axis2,
        /// <summary>The fourth axis of the JoystickDevice.</summary>
        Axis3,
        /// <summary>The fifth axis of the JoystickDevice.</summary>
        Axis4,
        /// <summary>The sixth axis of the JoystickDevice.</summary>
        Axis5,
        /// <summary>The seventh axis of the JoystickDevice.</summary>
        Axis6,
        /// <summary>The eighth axis of the JoystickDevice.</summary>
        Axis7,
        /// <summary>The ninth axis of the JoystickDevice.</summary>
        Axis8,
        /// <summary>The tenth axis of the JoystickDevice.</summary>
        Axis9,
        /// <summary>The eleventh axis of the JoystickDevice.</summary>
        Axis10,
        /// <summary>The highest supported axis of the JoystickDevice.</summary>
        Last = Axis10,
    }
}
