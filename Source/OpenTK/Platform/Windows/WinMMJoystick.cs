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
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using Microsoft.Win32;
using OpenTK.Input;

namespace OpenTK.Platform.Windows
{
    sealed class WinMMJoystick : IJoystickDriver2
    {
        #region Fields

        readonly object sync = new object();

        List<JoystickDevice> sticks = new List<JoystickDevice>();

        // Matches a WinMM device index to a specific stick above
        readonly Dictionary<int, int> index_to_stick =
            new Dictionary<int, int>();
        // Matches a player index to a WinMM device index
        readonly Dictionary<int, int> player_to_index =
            new Dictionary<int, int>();

        // Todo: Read the joystick name from the registry.
        //static readonly string RegistryJoyConfig = @"Joystick%dConfiguration";
        //static readonly string RegistryJoyName = @"Joystick%dOEMName";
        //static readonly string RegstryJoyCurrent = @"CurrentJoystickSettings";

        bool disposed;

        #endregion

        #region Constructors

        public WinMMJoystick()
        {
            RefreshDevices();
        }

        #endregion

        #region Internal Members

        internal void RefreshDevices()
        {
            for (int i = 0; i < sticks.Count; i++)
            {
                CloseJoystick(i);
            }

            // WinMM supports up to 16 joysticks.
            for (int i = 0; i < UnsafeNativeMethods.joyGetNumDevs(); i++)
            {
                OpenJoystick(i);
            }
        }

        #endregion

        #region Private Members

        JoystickDevice<WinMMJoyDetails> OpenJoystick(int number)
        {
            lock (sync)
            {
                JoystickDevice<WinMMJoyDetails> stick = null;

                JoyCaps caps;
                JoystickError result = UnsafeNativeMethods.joyGetDevCaps(number, out caps, JoyCaps.SizeInBytes);
                if (result == JoystickError.NoError)
                {
                    if (caps.NumAxes > JoystickState.MaxAxes)
                    {
                        Debug.Print("[Input] Device has {0} axes, which is higher than OpenTK maximum {1}. Please report a bug at http://www.opentk.com",
                            caps.NumAxes, JoystickState.MaxAxes);
                        caps.NumAxes = JoystickState.MaxAxes;
                    }

                    if (caps.NumAxes > JoystickState.MaxButtons)
                    {
                        Debug.Print("[Input] Device has {0} buttons, which is higher than OpenTK maximum {1}. Please report a bug at http://www.opentk.com",
                            caps.NumButtons, JoystickState.MaxButtons);
                        caps.NumButtons = JoystickState.MaxButtons;
                    }

                    JoystickCapabilities joycaps = new JoystickCapabilities(
                        caps.NumAxes,
                        caps.NumButtons,
                        (caps.Capabilities & JoystCapsFlags.HasPov) != 0 ? 1 : 0,
                        true);

                    int num_axes = caps.NumAxes;
                    if ((caps.Capabilities & JoystCapsFlags.HasPov) != 0)
                        num_axes += 2;

                    stick = new JoystickDevice<WinMMJoyDetails>(number, num_axes, caps.NumButtons);
                    stick.Details = new WinMMJoyDetails(joycaps);

                    // Make sure to reverse the vertical axes, so that +1 points up and -1 points down.
                    for (int axis = 0; axis < caps.NumAxes; axis++)
                    {
                        if (axis % 2 == 1)
                        {
                            stick.Details.Min[axis] = caps.GetMax(axis);
                            stick.Details.Max[axis] = caps.GetMin(axis);
                        }
                        else
                        {
                            stick.Details.Min[axis] = caps.GetMin(axis);
                            stick.Details.Max[axis] = caps.GetMax(axis);
                        }
                    }

                    if ((caps.Capabilities & JoystCapsFlags.HasPov) != 0)
                    {
                        stick.Details.PovType = PovType.Exists;
                        if ((caps.Capabilities & JoystCapsFlags.HasPov4Dir) != 0)
                            stick.Details.PovType |= PovType.Discrete;
                        if ((caps.Capabilities & JoystCapsFlags.HasPovContinuous) != 0)
                            stick.Details.PovType |= PovType.Continuous;
                    }

                    // Todo: Implement joystick name detection for WinMM.
                    stick.Description = String.Format("Joystick/Joystick #{0} ({1} axes, {2} buttons)", number, stick.Axis.Count, stick.Button.Count);
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

                    Debug.Print("Found joystick on device number {0}", number);
                    index_to_stick.Add(number, sticks.Count);
                    player_to_index.Add(player_to_index.Count, number);
                    sticks.Add(stick);
                }

                return stick;
            }
        }

        void UnplugJoystick(int player_index)
        {
            // Reset the system configuration. Without this,
            // joysticks that are reconnected on different
            // ports are given different ids, making it
            // impossible to reconnect a disconnected user.
            UnsafeNativeMethods.joyConfigChanged(0);
            Debug.Print("[Win] WinMM joystick {0} unplugged", player_index);
            CloseJoystick(player_index);
        }

        void CloseJoystick(int player_index)
        {
            lock (sync)
            {
                if (IsValid(player_index))
                {
                    int device_index = player_to_index[player_index];

                    JoystickDevice<WinMMJoyDetails> stick =
                        sticks[index_to_stick[device_index]] as JoystickDevice<WinMMJoyDetails>;

                    if (stick != null)
                    {
                        index_to_stick.Remove(device_index);
                        player_to_index.Remove(player_index);
                    }
                }
            }
        }

        bool IsValid(int player_index)
        {
            if (player_to_index.ContainsKey(player_index))
            {
                return true;
            }
            //else if (index >= 0 && index < UnsafeNativeMethods.joyGetNumDevs())
            //{
            //    return OpenJoystick(index) != null;
            //}
            return false;
        }

        static short CalculateOffset(int pos, int min, int max)
        {
            int offset = (ushort.MaxValue * (pos - min)) / (max - min) - short.MaxValue;
            return (short)offset;
        }

        #endregion

        #region IJoystickDriver2 Members

        public JoystickCapabilities GetCapabilities(int player_index)
        {
            lock (sync)
            {
                if (IsValid(player_index))
                {
                    int device_index = player_to_index[player_index];
                    JoystickDevice<WinMMJoyDetails> stick =
                        sticks[index_to_stick[device_index]] as JoystickDevice<WinMMJoyDetails>;

                    return stick.Details.Capabilities;
                }

                return new JoystickCapabilities();
            }
        }

        public JoystickState GetState(int player_index)
        {
            lock (sync)
            {
                JoystickState state = new JoystickState();

                if (IsValid(player_index))
                {
                    int device_index = player_to_index[player_index];
                    int index = index_to_stick[device_index];
                    JoystickDevice<WinMMJoyDetails> stick =
                        sticks[index] as JoystickDevice<WinMMJoyDetails>;

                    // For joysticks with fewer than three axes or four buttons, we must
                    // use joyGetPos; otherwise, joyGetPosEx. This is not just a cosmetic
                    // difference, simple devices will return incorrect results if we use
                    // joyGetPosEx on them.
                    if (stick.Details.Capabilities.AxisCount <= 3 || stick.Details.Capabilities.ButtonCount <= 4)
                    {
                        // Use joyGetPos
                        JoyInfo info = new JoyInfo();

                        JoystickError result = UnsafeNativeMethods.joyGetPos(device_index, ref info);
                        if (result == JoystickError.NoError)
                        {
                            for (int i = 0; i < stick.Details.Capabilities.AxisCount; i++)
                            {
                                state.SetAxis(JoystickAxis.Axis0 + i, CalculateOffset(info.GetAxis(i), stick.Details.Min[i], stick.Details.Max[i]));
                            }

                            for (int i = 0; i < stick.Details.Capabilities.ButtonCount; i++)
                            {
                                state.SetButton(JoystickButton.Button0 + i, (info.Buttons & 1 << i) != 0);
                            }

                            state.SetIsConnected(true);
                        }
                        else if (result == JoystickError.Unplugged)
                        {
                            UnplugJoystick(player_index);
                        }
                    }
                    else
                    {
                        // Use joyGetPosEx
                        JoyInfoEx info_ex = new JoyInfoEx();
                        info_ex.Size = JoyInfoEx.SizeInBytes;
                        info_ex.Flags = JoystickFlags.All;

                        JoystickError result = UnsafeNativeMethods.joyGetPosEx(device_index, ref info_ex);
                        if (result == JoystickError.NoError)
                        {
                            for (int i = 0; i < stick.Details.Capabilities.AxisCount; i++)
                            {
                                state.SetAxis(JoystickAxis.Axis0 + i, CalculateOffset(info_ex.GetAxis(i), stick.Details.Min[i], stick.Details.Max[i]));
                            }

                            for (int i = 0; i < stick.Details.Capabilities.ButtonCount; i++)
                            {
                                state.SetButton(JoystickButton.Button0 + i, (info_ex.Buttons & 1 << i) != 0);
                            }

                            for (int i = 0; i < stick.Details.Capabilities.HatCount; i++)
                            {
                                // A discrete POV returns specific values for left, right, etc.
                                // A continuous POV returns an integer indicating an angle in degrees * 100, e.g. 18000 == 180.00 degrees.
                                // The vast majority of joysticks have discrete POVs, so we'll treat all of them as discrete for simplicity.
                                if ((JoystickPovPosition)info_ex.Pov != JoystickPovPosition.Centered)
                                {
                                    HatPosition hatpos = HatPosition.Centered;
                                    if (info_ex.Pov < 4500 || info_ex.Pov >= 31500)
                                        hatpos |= HatPosition.Up;
                                    if (info_ex.Pov >= 4500 && info_ex.Pov < 13500)
                                        hatpos |= HatPosition.Right;
                                    if (info_ex.Pov >= 13500 && info_ex.Pov < 22500)
                                        hatpos |= HatPosition.Down;
                                    if (info_ex.Pov >= 22500 && info_ex.Pov < 31500)
                                        hatpos |= HatPosition.Left;

                                    state.SetHat(JoystickHat.Hat0 + i, new JoystickHatState(hatpos));
                                }
                            }

                            state.SetIsConnected(true);
                        }
                        else if (result == JoystickError.Unplugged)
                        {
                            UnplugJoystick(player_index);
                        }
                    }
                }

                return state;
            }
        }

        public Guid GetGuid(int index)
        {
            lock (sync)
            {
                Guid guid = new Guid();

                if (IsValid(index))
                {
                    // Todo: implement WinMM Guid retrieval
                }

                return guid;
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

            public int GetMin(int i)
            {
                switch (i)
                {
                    case 0: return XMin;
                    case 1: return YMin;
                    case 2: return ZMin;
                    case 3: return RMin;
                    case 4: return UMin;
                    case 5: return VMin;
                    default: return 0;
                }
            }

            public int GetMax(int i)
            {
                switch (i)
                {
                    case 0: return XMax;
                    case 1: return YMax;
                    case 2: return ZMax;
                    case 3: return RMax;
                    case 4: return UMax;
                    case 5: return VMax;
                    default: return 0;
                }
            }
        }

        struct JoyInfo
        {
            public int XPos;
            public int YPos;
            public int ZPos;
            public uint Buttons;

            public int GetAxis(int i)
            {
                switch (i)
                {
                    case 0: return XPos;
                    case 1: return YPos;
                    case 2: return ZPos;
                    default: return 0;
                }
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
            #pragma warning disable 0169
            uint Reserved1;
            uint Reserved2;
            #pragma warning restore 0169

            public static readonly int SizeInBytes;

            static JoyInfoEx()
            {
                SizeInBytes = Marshal.SizeOf(default(JoyInfoEx));
            }

            public int GetAxis(int i)
            {
                switch (i)
                {
                    case 0: return XPos;
                    case 1: return YPos;
                    case 2: return ZPos;
                    case 3: return RPos;
                    case 4: return UPos;
                    case 5: return VPos;
                    default: return 0;
                }
            }
        }

        static class UnsafeNativeMethods
        {
            [DllImport("Winmm.dll"), SuppressUnmanagedCodeSecurity]
            public static extern JoystickError joyGetDevCaps(int uJoyID, out JoyCaps pjc, int cbjc);
            [DllImport("Winmm.dll"), SuppressUnmanagedCodeSecurity]
            public static extern JoystickError joyGetPos(int uJoyID, ref JoyInfo pji);
            [DllImport("Winmm.dll"), SuppressUnmanagedCodeSecurity]
            public static extern JoystickError joyGetPosEx(int uJoyID, ref JoyInfoEx pji);
            [DllImport("Winmm.dll"), SuppressUnmanagedCodeSecurity]
            public static extern int joyGetNumDevs();
            [DllImport("Winmm.dll"), SuppressUnmanagedCodeSecurity]
            public static extern JoystickError joyConfigChanged(int flags);
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
            public readonly int[] Min, Max; // Minimum and maximum offset of each axis.
            public PovType PovType;
            public JoystickCapabilities Capabilities;

            public WinMMJoyDetails(JoystickCapabilities caps)
                : this()
            {
                Min = new int[caps.AxisCount];
                Max = new int[caps.AxisCount];
                Capabilities = caps;
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
