#region License
//
// LinuxKeyboardLibInput.cs
//
// Author:
//       thefiddler <stapostol@gmail.com>
//
// Copyright (c) 2006-2014 
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
using System.Diagnostics;
using OpenTK.Input;

namespace OpenTK.Platform.Linux
{
    class LinuxKeyboardLibInput : IKeyboardDriver2
    {
        IntPtr udev;
        IntPtr input_context;
        InputInterface input_interface = InputInterface.Default;

        public LinuxKeyboardLibInput()
        {
            // Todo: add static path fallback when udev is not installed.
            udev = Udev.New();
            if (udev == IntPtr.Zero)
                throw new NotSupportedException("[Input] Udev.New() failed.");

            input_context = LibInput.CreateContext(input_interface,
                IntPtr.Zero, udev, "seat0");
            if (input_context == IntPtr.Zero)
                throw new NotSupportedException("[Input] Udev.New() failed.");


        }

        #region IKeyboardDriver2 implementation

        public KeyboardState GetState()
        {
            throw new NotImplementedException();
        }

        public KeyboardState GetState(int index)
        {
            throw new NotImplementedException();
        }

        public string GetDeviceName(int index)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

