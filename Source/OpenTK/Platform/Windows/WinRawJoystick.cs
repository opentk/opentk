#region License
//
// WinRawJoystick.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2014 Stefanos Apostolopoulos
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
using System.Diagnostics;
using System.Text;
using OpenTK.Input;

namespace OpenTK.Platform.Windows
{
    class WinRawJoystick : IJoystickDriver2
    {
        readonly IntPtr Window;
        readonly object UpdateLock = new object();

        public WinRawJoystick(IntPtr window)
        {
            Debug.WriteLine("Using WinRawMouse.");
            Debug.Indent();

            if (window == IntPtr.Zero)
                throw new ArgumentNullException("window");

            Window = window;
            RefreshDevices();

            Debug.Unindent();
        }

        public void RefreshDevices()
        {
            
        }

        public bool ProcessEvent(ref RawInput data)
        {
            throw new NotImplementedException();
        }

        public JoystickState GetState(int index)
        {
            throw new NotImplementedException();
        }

        public JoystickCapabilities GetCapabilities(int index)
        {
            throw new NotImplementedException();
        }

        public Guid GetGuid(int index)
        {
            throw new NotImplementedException();
        }
    }
}
