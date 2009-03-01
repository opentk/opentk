#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2008 the Open Toolkit library, except where noted.
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
using System.Runtime.InteropServices;
using OpenTK.Input;

namespace OpenTK.Platform.Windows
{
    sealed class WinMMJoystick : IJoystickDriver
    {
        #region Fields

        List<JoystickDevice> sticks = new List<JoystickDevice>();
        IList<JoystickDevice> sticks_readonly;

        bool disposed;

        #endregion

        #region Constructors

        public WinMMJoystick()
        {
            sticks_readonly = sticks.AsReadOnly();

            int number = 0, max_sticks = 25;
            while (number < max_sticks)
            {
                JoystickDevice<WinMMJoyDetails> stick = OpenJoystick(number++);
                if (stick != null)
                {
                    stick.Description = String.Format("USB Joystick {0} ({1} axes, {2} buttons)", number, stick.Axis.Count, stick.Button.Count);
                    sticks.Add(stick);
                }
            }
        }

        #endregion

        #region Private Members

        JoystickDevice<WinMMJoyDetails> OpenJoystick(int number)
        {
            JoystickDevice<WinMMJoyDetails> stick = null;

            JoyCaps caps;
            JoystickError result = UnsafeNativeMethods.joyGetDevCaps(number, out caps, JoyCaps.SizeInBytes);
            if (result != JoystickError.NoError)
                return null;

            stick = new JoystickDevice<WinMMJoyDetails>(number, caps.NumAxes, caps.NumButtons);
            stick.Details = new WinMMJoyDetails(caps.NumAxes);
            int axis = 0;
            if (axis < caps.NumAxes)
            { stick.Details.Min[axis] = caps.XMin; stick.Details.Max[axis] = caps.XMax; axis++; }
            if (axis < caps.NumAxes)
            { stick.Details.Min[axis] = caps.YMin; stick.Details.Max[axis] = caps.YMax; axis++; }
            if (axis < caps.NumAxes)
            { stick.Details.Min[axis] = caps.ZMin; stick.Details.Max[axis] = caps.ZMax; axis++; }
            if (axis < caps.NumAxes)
            { stick.Details.Min[axis] = caps.RMin; stick.Details.Max[axis] = caps.RMax; axis++; }
            if (axis < caps.NumAxes)
            { stick.Details.Min[axis] = caps.UMin; stick.Details.Max[axis] = caps.UMax; axis++; }
            if (axis < caps.NumAxes)
            { stick.Details.Min[axis] = caps.VMin; stick.Details.Max[axis] = caps.VMax; axis++; }

            return stick;
        }

        #endregion

        #region IJoystickDriver

        public int DeviceCount
        {
            get { return sticks.Count; }
        }

        public IList<JoystickDevice> Joysticks
        {
            get { return sticks_readonly; }
        }

        public void Poll()
        {
            foreach (JoystickDevice<WinMMJoyDetails> js in sticks)
            {
                JoyInfoEx info = new JoyInfoEx();
                info.Size = JoyInfoEx.SizeInBytes;
                info.Flags = JoystickFlags.All;
                UnsafeNativeMethods.joyGetPosEx(js.Id, ref info);

                int axis = 0;
                if (axis < js.Axis.Count)
                { js.SetAxis((JoystickAxis)axis, js.Details.CalculateOffset((float)info.XPos, axis)); axis++; }
                if (axis < js.Axis.Count)
                { js.SetAxis((JoystickAxis)axis, js.Details.CalculateOffset((float)info.YPos, axis)); axis++; }
                if (axis < js.Axis.Count)
                { js.SetAxis((JoystickAxis)axis, js.Details.CalculateOffset((float)info.ZPos, axis)); axis++; }
                if (axis < js.Axis.Count)
                { js.SetAxis((JoystickAxis)axis, js.Details.CalculateOffset((float)info.RPos, axis)); axis++; }
                if (axis < js.Axis.Count)
                { js.SetAxis((JoystickAxis)axis, js.Details.CalculateOffset((float)info.UPos, axis)); axis++; }
                if (axis < js.Axis.Count)
                { js.SetAxis((JoystickAxis)axis, js.Details.CalculateOffset((float)info.VPos, axis)); axis++; }

                int button = 0;
                while (button < js.Button.Count)
                {
                    js.SetButton((JoystickButton)button, (info.Buttons & (1 << button)) != 0);
                    button++;
                }
            }
        }

        #endregion

        #region IDisposable

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        void Dispose(bool manual)
        {
            if (!disposed)
            {
                if (manual)
                {
                }

                disposed = true;
            }
        }

        ~WinMMJoystick()
        {
            Dispose(false);
        }

        #endregion

        #region UnsafeNativeMethods

        [Flags]
        enum JoystickFlags
        {
            X = 0x1,
            Y = 0x2,
            Z = 0x4,
            R = 0x8,
            U = 0x10,
            V = 0x20,
            Pov = 0x40,
            Buttons = 0x80,
            All = X | Y | Z | R | U | V | Pov | Buttons
        }

        enum JoystickError : uint
        {
            NoError = 0,
            InvalidParameters = 165,
            NoCanDo = 166,
            Unplugged = 167
            //MM_NoDriver = 6,
            //MM_InvalidParameter = 11
        }


        struct JoyCaps
        {
            public ushort Mid;
            public ushort Pid;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string Pname;
            public int XMin;
            public int XMax;
            public int YMin;
            public int YMax;
            public int ZMin;
            public int ZMax;
            public int NumButtons;
            public int PeriodMin;
            public int PeriodMax;
            public int RMin;
            public int RMax;
            public int UMin;
            public int UMax;
            public int VMin;
            public int VMax;
            public int Caps;
            public int MaxAxes;
            public int NumAxes;
            public int MaxButtons;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string RegKey;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string OemVxD;

            public static readonly int SizeInBytes;

            static JoyCaps()
            {
                SizeInBytes = Marshal.SizeOf(default(JoyCaps));
            }
        }

        struct JoyInfoEx
        {
            public int Size;
            [MarshalAs(UnmanagedType.I4)]
            public JoystickFlags Flags;
            public int XPos;
            public int YPos;
            public int ZPos;
            public int RPos;
            public int UPos;
            public int VPos;
            public uint Buttons;
            public uint ButtonNumber;
            public int Pov;
            uint Reserved1;
            uint Reserved2;

            public static readonly int SizeInBytes;

            static JoyInfoEx()
            {
                SizeInBytes = Marshal.SizeOf(default(JoyInfoEx));
            }
        }

        static class UnsafeNativeMethods
        {
            [DllImport("Winmm.dll")]
            public static extern JoystickError joyGetDevCaps(int uJoyID, out JoyCaps pjc, int cbjc);
            [DllImport("Winmm.dll")]
            public static extern uint joyGetPosEx(int uJoyID, ref JoyInfoEx pji);
        }

        #endregion

        #region struct WinMMJoyDetails

        struct WinMMJoyDetails
        {
            public readonly float[] Min, Max; // Minimum and maximum offset of each axis.

            public WinMMJoyDetails(int num_axes)
            {
                Min = new float[num_axes];
                Max = new float[num_axes];
            }

            public float CalculateOffset(float pos, int axis)
            {
                float offset = (2 * (pos - Min[axis])) / (Max[axis] - Min[axis]) - 1;
                if (offset > 1)
                    return 1;
                else if (offset < -1)
                    return -1;
                else if (offset < 0.001f && offset > -0.001f)
                    return 0;
                else
                    return offset;
            }
        }

        #endregion
    }
}
