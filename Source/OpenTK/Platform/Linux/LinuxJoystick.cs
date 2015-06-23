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
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using OpenTK.Input;

namespace OpenTK.Platform.Linux
{
    struct AxisInfo
    {
        public JoystickAxis Axis;
        public InputAbsInfo Info;
    }

    class LinuxJoystickDetails
    {
        public Guid Guid;
        public string Name;
        public int FileDescriptor;
        public int PathIndex; // e.g. "0" for "/dev/input/event0". Used as a hardware id
        public JoystickState State;
        public JoystickCapabilities Caps;

        public readonly Dictionary<EvdevAxis, AxisInfo> AxisMap =
            new Dictionary<EvdevAxis, AxisInfo>();
        public readonly Dictionary<EvdevButton, JoystickButton> ButtonMap =
            new Dictionary<EvdevButton, JoystickButton>();
    }

    sealed class LinuxJoystick : IJoystickDriver2
    {
        #region Fields

        static readonly HatPosition[,] HatPositions = new HatPosition[,]
        {
            { HatPosition.UpLeft, HatPosition.Up, HatPosition.UpRight },
            { HatPosition.Left, HatPosition.Centered, HatPosition.Right },
            { HatPosition.DownLeft, HatPosition.Down, HatPosition.DownRight }
        };

        readonly object sync = new object();

        readonly FileSystemWatcher watcher = new FileSystemWatcher();

        readonly DeviceCollection<LinuxJoystickDetails> Sticks =
            new DeviceCollection<LinuxJoystickDetails>();

        bool disposed;

        #endregion

        #region Constructors

        public LinuxJoystick()
        {
            string path =
                Directory.Exists(JoystickPath) ? JoystickPath :
                Directory.Exists(JoystickPathLegacy) ? JoystickPathLegacy :
                String.Empty;

            if (!String.IsNullOrEmpty(path))
            {
                watcher.Path = path;

                watcher.Created += JoystickAdded;
                watcher.Deleted += JoystickRemoved;
                watcher.EnableRaisingEvents = true;

                OpenJoysticks(path);
            }
        }

        #endregion

        #region Private Members

        void OpenJoysticks(string path)
        {
            lock (sync)
            {
                foreach (string file in Directory.GetFiles(path))
                {
                    LinuxJoystickDetails stick = OpenJoystick(file);
                    if (stick != null)
                    {
                        Sticks.Add(stick.PathIndex, stick);
                    }
                }
            }
        }

        int GetJoystickNumber(string path)
        {
            const string evdev = "event";
            if (path.StartsWith(evdev))
            {
                int num;
                if (Int32.TryParse(path.Substring(evdev.Length), out num))
                {
                    return num;
                }
            }
            return -1;
        }

        void JoystickAdded(object sender, FileSystemEventArgs e)
        {
            lock (sync)
            {
                OpenJoystick(e.FullPath);
            }
        }

        void JoystickRemoved(object sender, FileSystemEventArgs e)
        {
            lock (sync)
            {
                string file = Path.GetFileName(e.FullPath);
                int number = GetJoystickNumber(file);
                if (number != -1)
                {
                    var stick = Sticks.FromHardwareId(number);
                    if (stick != null)
                    {
                        CloseJoystick(stick);
                    }
                }
            }
        }

        #endregion

        #region Private Members

        Guid CreateGuid(EvdevInputId id, string name)
        {
            // Note: the first 8bytes of the Guid are byteswapped
            // in three parts when using `new Guid(byte[])`:
            // (int, short, short).
            // We need to take that into account to match the expected
            // Guid in the database. Ugh.

            byte[] bytes = new byte[16];

            int i = 0;
            byte[] bus = BitConverter.GetBytes((int)id.BusType);
            bytes[i++] = bus[3];
            bytes[i++] = bus[2];
            bytes[i++] = bus[1];
            bytes[i++] = bus[0];

            if (id.Vendor != 0 && id.Product != 0 && id.Version != 0)
            {
                byte[] vendor = BitConverter.GetBytes(id.Vendor);
                byte[] product = BitConverter.GetBytes(id.Product);
                byte[] version = BitConverter.GetBytes(id.Version);
                bytes[i++] = vendor[1];
                bytes[i++] = vendor[0];
                bytes[i++] = 0;
                bytes[i++] = 0;
                bytes[i++] = product[0]; // no byteswapping
                bytes[i++] = product[1];
                bytes[i++] = 0;
                bytes[i++] = 0;
                bytes[i++] = version[0]; // no byteswapping
                bytes[i++] = version[1];
                bytes[i++] = 0;
                bytes[i++] = 0;
            }
            else
            {
                for (int j = 0; j < bytes.Length - i; j++)
                {
                    bytes[i + j] = (byte)name[j];
                }
            }

            return new Guid(bytes);
        }

        unsafe static bool TestBit(byte* ptr, int bit)
        {
            int byte_offset = bit / 8;
            int bit_offset = bit % 8;
            return (*(ptr + byte_offset) & (1 << bit_offset)) != 0;
        }

        unsafe static void QueryCapabilities(LinuxJoystickDetails stick,
            byte* axisbit, int axisbytes,
            byte* keybit, int keybytes,
            out int axes, out int buttons, out int hats)
        {
            // Note: since we are trying to be compatible with the SDL2 gamepad database,
            // we have to match SDL2 behavior bug-for-bug. This means:
            // HAT0-HAT3 are all reported as hats (even if the docs say that HAT1 and HAT2 can be analogue triggers)
            // DPAD buttons are reported as buttons, not as hats (unlike Windows and Mac OS X)

            axes = buttons = hats = 0;
            for (EvdevAxis axis = 0; axis < EvdevAxis.CNT && (int)axis < axisbytes * 8; axis++)
            {
                InputAbsInfo info;
                bool is_valid = true;
                is_valid &= TestBit(axisbit, (int)axis);
                is_valid &= Evdev.GetAbs(stick.FileDescriptor, axis, out info) >= 0;
                if (is_valid)
                {
                    if (axis >= EvdevAxis.HAT0X && axis <= EvdevAxis.HAT3Y)
                    {
                        // Analogue hat
                        stick.AxisMap.Add(axis, new AxisInfo
                        {
                            Axis = (JoystickAxis)(JoystickHat)hats++,
                            Info = info
                        });
                    }
                    else
                    {
                        // Regular axis
                        stick.AxisMap.Add(axis, new AxisInfo
                        {
                            Axis = (JoystickAxis)axes++,
                            Info = info
                        });
                    }
                }
            }

            for (EvdevButton button = 0; button < EvdevButton.Last && (int)button < keybytes * 8; button++)
            {
                if (TestBit(keybit, (int)button))
                {
                    stick.ButtonMap.Add(button, (JoystickButton)buttons++);
                }
            }
        }

        LinuxJoystickDetails OpenJoystick(string path)
        {
            LinuxJoystickDetails stick = null;

            int number = GetJoystickNumber(Path.GetFileName(path));
            if (number >= 0)
            {
                int fd = -1;
                try
                {
                    fd = Libc.open(path, OpenFlags.NonBlock);
                    if (fd == -1)
                        return null;

                    unsafe
                    {
                        const int evsize = Evdev.EventCount / 8;
                        const int axissize = Evdev.AxisCount / 8;
                        const int keysize = Evdev.KeyCount / 8;
                        byte* evbit = stackalloc byte[evsize];
                        byte* axisbit = stackalloc byte[axissize];
                        byte* keybit = stackalloc byte[keysize];

                        string name;
                        EvdevInputId id;

                        // Ensure this is a joystick device
                        bool is_valid = true;

                        is_valid &= Evdev.GetBit(fd, 0, evsize, new IntPtr(evbit)) >= 0;
                        is_valid &= Evdev.GetBit(fd, EvdevType.ABS, axissize, new IntPtr(axisbit)) >= 0;
                        is_valid &= Evdev.GetBit(fd, EvdevType.KEY, keysize, new IntPtr(keybit)) >= 0;

                        is_valid &= TestBit(evbit, (int)EvdevType.KEY);
                        is_valid &= TestBit(evbit, (int)EvdevType.ABS);
                        is_valid &= TestBit(axisbit, (int)EvdevAxis.X);
                        is_valid &= TestBit(axisbit, (int)EvdevAxis.Y);

                        is_valid &= Evdev.GetName(fd, out name) >= 0;
                        is_valid &= Evdev.GetId(fd, out id) >= 0;

                        if (is_valid)
                        {
                            stick = new LinuxJoystickDetails
                            {
                                FileDescriptor = fd,
                                PathIndex = number,
                                State = new JoystickState(),
                                Name = name,
                                Guid = CreateGuid(id, name),
                            };

                            int axes, buttons, hats;
                            QueryCapabilities(stick, axisbit, axissize, keybit, keysize,
                                out axes, out buttons, out hats);

                            stick.Caps = new JoystickCapabilities(axes, buttons, hats, false);

                            // Poll the joystick once, to initialize its state
                            PollJoystick(stick);
                        }
                    }

                    Debug.Print("Found joystick on path {0}", path);
                }
                catch (Exception e)
                {
                    Debug.Print("Error opening joystick: {0}", e.ToString());
                }
                finally
                {
                    if (stick == null && fd != -1)
                    {
                        // Not a joystick
                        Libc.close(fd);
                    }
                }
            }

            return stick;
        }

        void CloseJoystick(LinuxJoystickDetails js)
        {
            Sticks.Remove(js.FileDescriptor);

            Libc.close(js.FileDescriptor);
            js.FileDescriptor = -1;
            js.State = new JoystickState(); // clear joystick state
            js.Caps = new JoystickCapabilities();
        }

        JoystickHatState TranslateHat(int x, int y)
        {
            return new JoystickHatState(HatPositions[x, y]);
        }

        void PollJoystick(LinuxJoystickDetails js)
        {
            unsafe
            {
                const int EventCount = 32;
                InputEvent* events = stackalloc InputEvent[EventCount];

                long length = 0;
                while (true)
                {
                    length = (long)Libc.read(js.FileDescriptor, (void*)events, (UIntPtr)(sizeof(InputEvent) * EventCount));
                    if (length <= 0)
                        break;

                    // Only mark the joystick as connected when we actually start receiving events.
                    // Otherwise, the Xbox wireless receiver will register 4 joysticks even if no
                    // actual joystick is connected to the receiver.
                    js.Caps.SetIsConnected(true);
                    js.State.SetIsConnected(true);

                    length /= sizeof(InputEvent);
                    for (int i = 0; i < length; i++)
                    {
                        InputEvent *e = events + i;
                        switch (e->Type)
                        {
                            case EvdevType.ABS:
                                {
                                    AxisInfo axis;
                                    if (js.AxisMap.TryGetValue((EvdevAxis)e->Code, out axis))
                                    {
                                        if (axis.Info.Maximum > axis.Info.Minimum)
                                        {
                                            if (e->Code >= (int)EvdevAxis.HAT0X && e->Code <= (int)EvdevAxis.HAT3Y)
                                            {
                                                // We currently treat analogue hats as digital hats
                                                // to maintain compatibility with SDL2. We can do
                                                // better than this, however.
                                                JoystickHat hat = JoystickHat.Hat0 + (e->Code - (int)EvdevAxis.HAT0X) / 2;
                                                JoystickHatState pos = js.State.GetHat(hat);
                                                int xy_axis = (int)axis.Axis & 0x1;
                                                switch (xy_axis)
                                                {
                                                    case 0:
                                                        // X-axis
                                                        pos = TranslateHat(
                                                            e->Value.CompareTo(0) + 1,
                                                            pos.IsUp ? 0 : pos.IsDown ? 2 : 1);
                                                        break;

                                                    case 1:
                                                        // Y-axis
                                                        pos = TranslateHat(
                                                            pos.IsLeft ? 0 : pos.IsRight ? 2 : 1,
                                                            e->Value.CompareTo(0) + 1);
                                                        break;
                                                }

                                                js.State.SetHat(hat, pos);
                                            }
                                            else
                                            {
                                                // This axis represents a regular axis or trigger
                                                js.State.SetAxis(
                                                    axis.Axis,
                                                    (short)Common.HidHelper.ScaleValue(e->Value,
                                                        axis.Info.Minimum, axis.Info.Maximum,
                                                        short.MinValue, short.MaxValue));
                                            }
                                        }
                                    }
                                    break;
                                }

                            case EvdevType.KEY:
                                {
                                    JoystickButton button;
                                    if (js.ButtonMap.TryGetValue((EvdevButton)e->Code, out button))
                                    {
                                        js.State.SetButton(button, e->Value != 0);
                                    }
                                    break;
                                }
                        }

                        // Create a serial number (total seconds in 24.8 fixed point format)
                        int sec = (int)((long)e->Time.Seconds & 0xffffffff);
                        int msec = (int)e->Time.MicroSeconds / 1000;
                        int packet =
                            ((sec & 0x00ffffff) << 24) |
                            Common.HidHelper.ScaleValue(msec, 0, 1000, 0, 255);
                        js.State.SetPacketNumber(packet);
                    }
                }
            }
        }

        static readonly string JoystickPath = "/dev/input";
        static readonly string JoystickPathLegacy = "/dev";

        #endregion

        #region IDisposable Members

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

                watcher.Dispose();
                foreach (LinuxJoystickDetails js in Sticks)
                {
                    CloseJoystick(js);
                }

                disposed = true;
            }
        }

        ~LinuxJoystick()
        {
            Dispose(false);
        }

        #endregion

        #region IJoystickDriver2 Members

        JoystickState IJoystickDriver2.GetState(int index)
        {
            LinuxJoystickDetails js = Sticks.FromIndex(index);
            if (js != null)
            {
                PollJoystick(js);
                return js.State;
            }
            return new JoystickState();
        }

        JoystickCapabilities IJoystickDriver2.GetCapabilities(int index)
        {
            LinuxJoystickDetails js = Sticks.FromIndex(index);
            if (js != null)
            {
                return js.Caps;
            }
            return new JoystickCapabilities();
        }

        Guid IJoystickDriver2.GetGuid(int index)
        {
            LinuxJoystickDetails js = Sticks.FromIndex(index);
            if (js != null)
            {
                return js.Guid;
            }
            return Guid.Empty;
        }

        #endregion
    }
}
