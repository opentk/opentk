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
    class LinuxJoystickDetails
    {
        public Guid Guid;
        public string Name;
        public int FileDescriptor;
        public int PathIndex; // e.g. "0" for "/dev/input/event0". Used as a hardware id
        public JoystickState State;
        public JoystickCapabilities Caps;

        public readonly Dictionary<EvdevAxis, JoystickAxis> AxisMap =
            new Dictionary<EvdevAxis, JoystickAxis>();
        public readonly Dictionary<EvdevButton, JoystickButton> ButtonMap =
            new Dictionary<EvdevButton, JoystickButton>();
        public readonly Dictionary<int, JoystickHat> HatMap =
            new Dictionary<int, JoystickHat>();
    }

    sealed class LinuxJoystick : IJoystickDriver2
    {
        #region Fields

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
                        Sticks.TryRemove(number);
                    }
                }
            }
        }

        #endregion

        #region Private Members

        Guid CreateGuid(EvdevInputId id, string name)
        {
            byte[] bytes = new byte[16];

            int i = 0;
            byte[] bus = BitConverter.GetBytes(id.BusType);
            bytes[i++] = bus[0];
            bytes[i++] = bus[1];
            bytes[i++] = 0;
            bytes[i++] = 0;

            if (id.Vendor != 0 && id.Product != 0 && id.Version != 0)
            {
                byte[] vendor = BitConverter.GetBytes(id.Vendor);
                byte[] product = BitConverter.GetBytes(id.Product);
                byte[] version = BitConverter.GetBytes(id.Version);
                bytes[i++] = vendor[0];
                bytes[i++] = vendor[1];
                bytes[i++] = 0;
                bytes[i++] = 0;
                bytes[i++] = product[0];
                bytes[i++] = product[1];
                bytes[i++] = 0;
                bytes[i++] = 0;
                bytes[i++] = version[0];
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

        unsafe static int AddAxes(LinuxJoystickDetails stick, byte* axisbit, int bytecount)
        {
            JoystickAxis axes = 0;
            JoystickHat hats = 0;
            int bitcount = bytecount * 8;
            for (EvdevAxis axis = 0; axis < EvdevAxis.CNT && (int)axis < bitcount; axis++)
            {
                if (axis >= EvdevAxis.HAT0X && axis <= EvdevAxis.HAT3Y)
                {
                    // Axis is analogue hat - skip
                    continue;
                }

                if (TestBit(axisbit, (int)axis))
                {
                    stick.AxisMap.Add(axis, axes++);
                }
                else
                {
                    stick.AxisMap.Add(axis, (JoystickAxis)(-1));
                }
            }
            return (int)axes;
        }

        unsafe static int AddButtons(LinuxJoystickDetails stick, byte* keybit, int bytecount)
        {
            JoystickButton buttons = 0;
            int bitcount = bytecount * 8;
            for (EvdevButton button = 0; button < EvdevButton.Last && (int)button < bitcount; button++)
            {
                if (button >= EvdevButton.DPAD_UP && button <= EvdevButton.DPAD_RIGHT)
                {
                    // Button is dpad (hat) - skip
                    continue;
                }

                if (TestBit(keybit, (int)button))
                {
                    stick.ButtonMap.Add(button, buttons++);
                }
                else
                {
                    stick.ButtonMap.Add(button, (JoystickButton)(-1));
                }
            }
            return (int)buttons;
        }

        unsafe static int AddHats(LinuxJoystickDetails stick,
            byte* axisbit, int axiscount,
            byte* keybit, int keycount)
        {
            JoystickHat hats = 0;
            for (EvdevAxis hat = EvdevAxis.HAT0X; hat < EvdevAxis.HAT3Y && (int)hat < axiscount * 8; hat++)
            {
                if (TestBit(axisbit, (int)hat))
                {
                    stick.HatMap.Add((int)hat, hats++);
                }
            }

            for (EvdevButton dpad = EvdevButton.DPAD_UP; dpad < EvdevButton.DPAD_RIGHT && (int)dpad < keycount * 8; dpad++)
            {
                if (TestBit(axisbit, (int)dpad))
                {
                    stick.HatMap.Add((int)dpad, hats++);
                }
            }

            return (int)hats;
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
                            stick.Caps = new JoystickCapabilities(
                                AddAxes(stick, axisbit, axissize),
                                AddButtons(stick, keybit, keysize),
                                AddHats(stick, axisbit, axissize, keybit, keysize),
                                true);
                            stick.State.SetIsConnected(true);
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

                    length /= sizeof(InputEvent);
                    for (int i = 0; i < length; i++)
                    {
                        InputEvent *e = events + i;
                        switch (e->Type)
                        {
                            case EvdevType.ABS:
                                break;

                            case EvdevType.KEY:
                                break;
                        }

                        //js.State.SetPacketNumber(unchecked((int)e->Time.Seconds));
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
