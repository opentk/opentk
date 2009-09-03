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
using System.Security;
using Microsoft.Win32;
using System.Diagnostics;

namespace OpenTK.Platform.Windows
{
    sealed class WinMMJoystick : IJoystickDriver
    {
        #region Fields

        List<JoystickDevice> sticks = new List<JoystickDevice>();
        IList<JoystickDevice> sticks_readonly;

        // Todo: Read the joystick name from the registry.
        //static readonly string RegistryJoyConfig = @"Joystick%dConfiguration";
        //static readonly string RegistryJoyName = @"Joystick%dOEMName";
        //static readonly string RegstryJoyCurrent = @"CurrentJoystickSettings";

        bool disposed;

        #endregion

        #region Constructors

        public WinMMJoystick()
        {
            sticks_readonly = sticks.AsReadOnly();

            // WinMM supports up to 16 joysticks.
            int number = 0;
            while (number < UnsafeNativeMethods.joyGetNumDevs())
            {
                JoystickDevice<WinMMJoyDetails> stick = OpenJoystick(number++);
                if (stick != null)
                {
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

            int num_axes = caps.NumAxes;
            if ((caps.Capabilities & JoystCapsFlags.HasPov) != 0)
                num_axes += 2;

            stick = new JoystickDevice<WinMMJoyDetails>(number, num_axes, caps.NumButtons);            
            stick.Details = new WinMMJoyDetails(num_axes);

            // Make sure to reverse the vertical axes, so that +1 points up and -1 points down.
            int axis = 0;
            if (axis < caps.NumAxes)
            { stick.Details.Min[axis] = caps.XMin; stick.Details.Max[axis] = caps.XMax; axis++; }
            if (axis < caps.NumAxes)
            { stick.Details.Min[axis] = caps.YMax; stick.Details.Max[axis] = caps.YMin; axis++; }
            if (axis < caps.NumAxes)
            { stick.Details.Min[axis] = caps.ZMax; stick.Details.Max[axis] = caps.ZMin; axis++; }
            if (axis < caps.NumAxes)
            { stick.Details.Min[axis] = caps.RMin; stick.Details.Max[axis] = caps.RMax; axis++; }
            if (axis < caps.NumAxes)
            { stick.Details.Min[axis] = caps.UMin; stick.Details.Max[axis] = caps.UMax; axis++; }
            if (axis < caps.NumAxes)
            { stick.Details.Min[axis] = caps.VMax; stick.Details.Max[axis] = caps.VMin; axis++; }

            if ((caps.Capabilities & JoystCapsFlags.HasPov) != 0)
            {
                stick.Details.PovType = PovType.Exists;
                if ((caps.Capabilities & JoystCapsFlags.HasPov4Dir) != 0)
                    stick.Details.PovType |= PovType.Discrete;
                if ((caps.Capabilities & JoystCapsFlags.HasPovContinuous) != 0)
                    stick.Details.PovType |= PovType.Continuous;
            }

            // Todo: Try to get the device name from the registry. Oh joy!
            //string key_path = String.Format("{0}\\{1}\\{2}", RegistryJoyConfig, caps.RegKey, RegstryJoyCurrent);
            //RegistryKey key = Registry.LocalMachine.OpenSubKey(key_path, false);
            //if (key == null)
            //    key = Registry.CurrentUser.OpenSubKey(key_path, false);
            //if (key == null)
            //    stick.Description = String.Format("USB Joystick {0} ({1} axes, {2} buttons)", number, stick.Axis.Count, stick.Button.Count);
            //else
            //{
            //    key.Close();
            //}

            if (stick != null)
                Debug.Print("Found joystick on device number {0}", number);
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

                int num_axes = js.Axis.Count;
                if ((js.Details.PovType & PovType.Exists) != 0)
                    num_axes -= 2; // Because the last two axis are used for POV input.

                int axis = 0;
                if (axis < num_axes)
                { js.SetAxis((JoystickAxis)axis, js.Details.CalculateOffset((float)info.XPos, axis)); axis++; }
                if (axis < num_axes)
                { js.SetAxis((JoystickAxis)axis, js.Details.CalculateOffset((float)info.YPos, axis)); axis++; }
                if (axis < num_axes)
                { js.SetAxis((JoystickAxis)axis, js.Details.CalculateOffset((float)info.ZPos, axis)); axis++; }
                if (axis < num_axes)
                { js.SetAxis((JoystickAxis)axis, js.Details.CalculateOffset((float)info.RPos, axis)); axis++; }
                if (axis < num_axes)
                { js.SetAxis((JoystickAxis)axis, js.Details.CalculateOffset((float)info.UPos, axis)); axis++; }
                if (axis < num_axes)
                { js.SetAxis((JoystickAxis)axis, js.Details.CalculateOffset((float)info.VPos, axis)); axis++; }

                if ((js.Details.PovType & PovType.Exists) != 0)
                {
                    float x = 0, y = 0;

                    // A discrete POV returns specific values for left, right, etc.
                    // A continuous POV returns an integer indicating an angle in degrees * 100, e.g. 18000 == 180.00 degrees.
                    // The vast majority of joysticks have discrete POVs, so we'll treat all of them as discrete for simplicity.
                    if ((JoystickPovPosition)info.Pov != JoystickPovPosition.Centered)
                    {
                        if (info.Pov > (int)JoystickPovPosition.Left || info.Pov < (int)JoystickPovPosition.Right)
                        { y = 1; }
                        if ((info.Pov > (int)JoystickPovPosition.Forward) && (info.Pov < (int)JoystickPovPosition.Backward))
                        { x = 1; }
                        if ((info.Pov > (int)JoystickPovPosition.Right) && (info.Pov < (int)JoystickPovPosition.Left))
                        { y = -1; }
                        if (info.Pov > (int)JoystickPovPosition.Backward)
                        { x = -1; }
                    }  
                    //if ((js.Details.PovType & PovType.Discrete) != 0)
                    //{
                    //    if ((JoystickPovPosition)info.Pov == JoystickPovPosition.Centered)
                    //    { x = 0; y = 0; }
                    //    else if ((JoystickPovPosition)info.Pov == JoystickPovPosition.Forward)
                    //    { x = 0; y = -1; }
                    //    else if ((JoystickPovPosition)info.Pov == JoystickPovPosition.Left)
                    //    { x = -1; y = 0; }
                    //    else if ((JoystickPovPosition)info.Pov == JoystickPovPosition.Backward)
                    //    { x = 0; y = 1; }
                    //    else if ((JoystickPovPosition)info.Pov == JoystickPovPosition.Right)
                    //    { x = 1; y = 0; }
                    //}
                    //else if ((js.Details.PovType & PovType.Continuous) != 0)
                    //{
                    //    if ((JoystickPovPosition)info.Pov == JoystickPovPosition.Centered)
                    //    {
                    //        // This approach moves the hat on a circle, not a square as it should.
                    //        float angle = (float)(System.Math.PI * info.Pov / 18000.0 + System.Math.PI / 2);
                    //        x = (float)System.Math.Cos(angle);
                    //        y = (float)System.Math.Sin(angle);
                    //        if (x < 0.001)
                    //            x = 0;
                    //        if (y < 0.001)
                    //            y = 0;
                    //    }
                    //}
                    //else
                    //    throw new NotImplementedException("Please post an issue report at http://www.opentk.com/issues");

                    js.SetAxis((JoystickAxis)axis++, x);
                    js.SetAxis((JoystickAxis)axis++, y);
                }

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

        [Flags]
        enum JoystCapsFlags
        {
            HasZ = 0x1,
            HasR = 0x2,
            HasU = 0x4,
            HasV = 0x8,
            HasPov = 0x16,
            HasPov4Dir = 0x32,
            HasPovContinuous = 0x64
        }

        enum JoystickPovPosition : ushort
        {
            Centered = 0xFFFF,
            Forward = 0,
            Right = 9000,
            Backward = 18000,
            Left = 27000
        }
        struct JoyCaps
        {
            public ushort Mid;
            public ushort ProductId;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string ProductName;
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
            public JoystCapsFlags Capabilities;
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
            [DllImport("Winmm.dll"), SuppressUnmanagedCodeSecurity]
            public static extern JoystickError joyGetDevCaps(int uJoyID, out JoyCaps pjc, int cbjc);
            [DllImport("Winmm.dll"), SuppressUnmanagedCodeSecurity]
            public static extern uint joyGetPosEx(int uJoyID, ref JoyInfoEx pji);
            [DllImport("Winmm.dll"), SuppressUnmanagedCodeSecurity]
            public static extern int joyGetNumDevs();
        }

        #endregion

        #region enum PovType

        [Flags]
        enum PovType
        {
            None = 0x0,
            Exists = 0x1,
            Discrete = 0x2,
            Continuous = 0x4
        }

        #endregion

        #region struct WinMMJoyDetails

        struct WinMMJoyDetails
        {
            public readonly float[] Min, Max; // Minimum and maximum offset of each axis.
            public PovType PovType;

            public WinMMJoyDetails(int num_axes)
            {
                Min = new float[num_axes];
                Max = new float[num_axes];
                PovType = PovType.None;
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
