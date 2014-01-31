#region License
//
// HatPosition.cs
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

namespace OpenTK.Input
{
    /// <summary>
    /// Enumerates discrete positions for a joystick hat.
    /// </summary>
    public enum HatPosition : byte
    {
        /// <summary>
        /// The hat is in its centered (neutral) position
        /// </summary>
        Centered = 0,
        /// <summary>
        /// The hat is in its top position.
        /// </summary>
        Up,
        /// <summary>
        /// The hat is in its top-right position.
        /// </summary>
        UpRight,
        /// <summary>
        /// The hat is in its right position.
        /// </summary>
        Right,
        /// <summary>
        /// The hat is in its bottom-right position.
        /// </summary>
        DownRight,
        /// <summary>
        /// The hat is in its bottom position.
        /// </summary>
        Down,
        /// <summary>
        /// The hat is in its bottom-left position.
        /// </summary>
        DownLeft,
        /// <summary>
        /// The hat is in its left position.
        /// </summary>
        Left,
        /// <summary>
        /// The hat is in its top-left position.
        /// </summary>
        UpLeft,
    }
}

