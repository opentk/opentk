#region License
//
// XInputJoystick.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2006-2013 Stefanos Apostolopoulos
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
using OpenTK.Input;
using System.Runtime.InteropServices;
using System.Security;
using System.Diagnostics;

namespace OpenTK.Platform.Windows
{
    /// \internal
    /// <summary>
    /// Combined XInput + WinMM joystick driver.
    /// Devices with XInput drivers are accessed through XInput
    /// Devices without XInput drivers are accessed through WinMM.
    /// This ensures proper support for e.g. the XBox360 controller
    /// triggers, which are not reported correctly on WinMM.
    /// </summary>
    class WinCombinedJoystick : IJoystickDriver2, IDisposable
    {
        readonly XInputJoystick xinput;
        readonly WinMMJoystick winmm;

        readonly Dictionary<int, int> index_to_winmm =
            new Dictionary<int, int>();

        #region Constructors

        public WinCombinedJoystick(XInputJoystick xinput, WinMMJoystick winmm)
        {
            if (xinput == null)
                throw new ArgumentNullException("xinput");
            if (winmm == null)
                throw new ArgumentNullException("winmm");

            this.xinput = xinput;
            this.winmm = winmm;
        }

        #endregion

        #region IJoystickDriver2 Members

        public JoystickState GetState(int index)
        {
            JoystickState state = xinput.GetState(index);
            if (!state.IsConnected)
                state = winmm.GetState(index);
            return state;
        }

        public JoystickCapabilities GetCapabilities(int index)
        {
            JoystickCapabilities state = xinput.GetCapabilities(index);
            if (!state.IsConnected)
                state = winmm.GetCapabilities(index);
            return state;
        }

        public Guid GetGuid(int index)
        {
            Guid guid = xinput.GetGuid(index);
            if (guid == Guid.Empty)
                guid = winmm.GetGuid(index);
            return guid;
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        void Dispose(bool manual)
        {
            if (manual)
            {
                xinput.Dispose();
                winmm.Dispose();
            }
            else
            {
                Debug.Print("{0} leaked, did you forget to call Dispose()?", typeof(XInputJoystick).Name);
            }
        }

#if DEBUG
        ~WinCombinedJoystick()
        {
            Dispose(false);
        }
#endif

        #endregion
    }
}
