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

namespace OpenTK.Platform.X11
{
    struct X11JoyDetails
    {
        public Guid Guid;
        public int FileDescriptor;
        public JoystickState State;
    }

    sealed class X11Joystick : IJoystickDriver2
    {
        #region Fields

        readonly object sync = new object();

        readonly FileSystemWatcher watcher = new FileSystemWatcher(JoystickPath);
        readonly FileSystemWatcher watcher_legacy = new FileSystemWatcher(JoystickPathLegacy);

        readonly Dictionary<int, int> index_to_stick = new Dictionary<int, int>();
        List<JoystickDevice<X11JoyDetails>> sticks = new List<JoystickDevice<X11JoyDetails>>();

        bool disposed;

        #endregion

        #region Constructors

        public X11Joystick()
        {
            watcher.Created += JoystickAdded;
            watcher.Deleted += JoystickRemoved;
            watcher.EnableRaisingEvents = true;

            watcher_legacy.Created += JoystickAdded;
            watcher_legacy.Deleted += JoystickRemoved;
            watcher_legacy.EnableRaisingEvents = true;

            OpenJoysticks();
        }

        #endregion

        #region Private Members

        void OpenJoysticks()
        {
            lock (sync)
            {
                foreach (string file in Directory.GetFiles(JoystickPath))
                {
                    JoystickDevice<X11JoyDetails> stick = OpenJoystick(file);
                    if (stick != null)
                    {
                        //stick.Description = String.Format("USB Joystick {0} ({1} axes, {2} buttons, {3}{0})",
                        //number, stick.Axis.Count, stick.Button.Count, JoystickPath);
                        sticks.Add(stick);
                    }
                }

                foreach (string file in Directory.GetFiles(JoystickPathLegacy))
                {
                    JoystickDevice<X11JoyDetails> stick = OpenJoystick(file);
                    if (stick != null)
                    {
                        //stick.Description = String.Format("USB Joystick {0} ({1} axes, {2} buttons, {3}{0})",
                        //number, stick.Axis.Count, stick.Button.Count, JoystickPathLegacy);
                        sticks.Add(stick);
                    }
                }
            }
        }

        int GetJoystickNumber(string path)
        {
            if (path.StartsWith("js"))
            {
                int num;
                if (Int32.TryParse(path.Substring(2), out num))
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
                    // Find which joystick id matches this number
                    int i;
                    for (i = 0; i < sticks.Count; i++)
                    {
                        if (sticks[i].Id == number)
                        {
                            break;
                        }
                    }

                    if (i == sticks.Count)
                    {
                        Debug.Print("[Evdev] Joystick id {0} does not exist.", number);
                    }
                    else
                    {
                        CloseJoystick(sticks[i]);
                    }
                }
            }
        }

        #endregion

        #region Private Members

        Guid CreateGuid(JoystickDevice<X11JoyDetails> js, string path, int number)
        {
            byte[] bytes = new byte[16];
            for (int i = 0; i < Math.Min(bytes.Length, js.Description.Length); i++)
            {
                bytes[i] = (byte)js.Description[i];
            }
            return new Guid(bytes);
   
#if false // Todo: move to /dev/input/event* from /dev/input/js*
            string evdev_path = Path.Combine(Path.GetDirectoryName(path), "event" + number);
            if (!File.Exists(evdev_path))
                return new Guid();

            int event_fd = UnsafeNativeMethods.open(evdev_path, OpenFlags.NonBlock);
            if (event_fd < 0)
                return new Guid();

            try
            {
                EventInputId id;
                if (UnsafeNativeMethods.ioctl(event_fd, EvdevInputId.Id, out id) < 0)
                    return new Guid();

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
                    for (; i < bytes.Length; i++)
                    {
                        bytes[i] = (byte)js.Description[i];
                    }
                }

                return new Guid(bytes);
            }
            finally
            {
                UnsafeNativeMethods.close(event_fd);
            }
#endif
        }
        
        JoystickDevice<X11JoyDetails> OpenJoystick(string path)
        {
            JoystickDevice<X11JoyDetails> stick = null;

            int number = GetJoystickNumber(Path.GetFileName(path));
            if (number >= 0)
            {
                int fd = -1;
                try
                {
                    fd = UnsafeNativeMethods.open(path, OpenFlags.NonBlock);
                    if (fd == -1)
                        return null;

                    // Check joystick driver version (must be 1.0+)
                    int driver_version = 0x00000800;
                    UnsafeNativeMethods.ioctl(fd, JoystickIoctlCode.Version, ref driver_version);
                    if (driver_version < 0x00010000)
                        return null;

                    // Get number of joystick axes
                    int axes = 0;
                    UnsafeNativeMethods.ioctl(fd, JoystickIoctlCode.Axes, ref axes);

                    // Get number of joystick buttons
                    int buttons = 0;
                    UnsafeNativeMethods.ioctl(fd, JoystickIoctlCode.Buttons, ref buttons);

                    stick = new JoystickDevice<X11JoyDetails>(number, axes, buttons);

                    StringBuilder sb = new StringBuilder(128);
                    UnsafeNativeMethods.ioctl(fd, JoystickIoctlCode.Name128, sb);
                    stick.Description = sb.ToString();

                    stick.Details.FileDescriptor = fd;
                    stick.Details.State.SetIsConnected(true);
                    stick.Details.Guid = CreateGuid(stick, path, number);
                    
                    // Find the first disconnected joystick (if any)
                    int i;
                    for (i = 0; i < sticks.Count; i++)
                    {
                        if (!sticks[i].Details.State.IsConnected)
                        {
                            break;
                        }
                    }

                    // If no disconnected joystick exists, append a new slot
                    if (i == sticks.Count)
                    {
                        sticks.Add(stick);
                    }
                    else
                    {
                        sticks[i] = stick;
                    }

                    // Map player index to joystick
                    index_to_stick.Add(index_to_stick.Count, i);

                    Debug.Print("Found joystick on path {0}", path);
                }
                finally
                {
                    if (stick == null && fd != -1)
                        UnsafeNativeMethods.close(fd);
                }
            }

            return stick;
        }

        void CloseJoystick(JoystickDevice<X11JoyDetails> js)
        {
            UnsafeNativeMethods.close(js.Details.FileDescriptor);
            js.Details.State = new JoystickState(); // clear joystick state
            js.Details.FileDescriptor = -1;
            
            // find and remove the joystick index from index_to_stick
            int key = -1;
            foreach (int i in index_to_stick.Keys)
            {
                if (sticks[index_to_stick[i]] == js)
                {
                    key = i;
                    break;
                }
            }

            if (index_to_stick.ContainsKey(key))
            {
                index_to_stick.Remove(key);
            }
        }

        void PollJoystick(JoystickDevice<X11JoyDetails> js)
        {
            JoystickEvent e;

            unsafe
            {
                while ((long)UnsafeNativeMethods.read(js.Details.FileDescriptor, (void*)&e, (UIntPtr)sizeof(JoystickEvent)) > 0)
                {
                    e.Type &= ~JoystickEventType.Init;

                    switch (e.Type)
                    {
                        case JoystickEventType.Axis:
                            // Flip vertical axes so that +1 point up.
                            if (e.Number % 2 == 0)
                                js.Details.State.SetAxis((JoystickAxis)e.Number, e.Value);
                            else
                                js.Details.State.SetAxis((JoystickAxis)e.Number, unchecked((short)-e.Value));
                            break;

                        case JoystickEventType.Button:
                            js.Details.State.SetButton((JoystickButton)e.Number, e.Value != 0);
                            break;
                    }

                    js.Details.State.SetPacketNumber(unchecked((int)e.Time));
                }
            }
        }

        bool IsValid(int index)
        {
            return index_to_stick.ContainsKey(index);
        }

        #region UnsafeNativeMethods

        struct EvdevInputId
        {
            public ushort BusType;
            public ushort Vendor;
            public ushort Product;
            public ushort Version;
        }

        enum EvdevIoctlCode : uint
        {
            Id = ((byte)'E' << 8) | (0x02 << 0) //EVIOCGID, which is _IOR('E', 0x02, struct input_id)
        }
 

        struct JoystickEvent
        {
            public uint Time;    // (u32) event timestamp in milliseconds
            public short Value;  // (s16) value
            public JoystickEventType Type;    // (u8)  event type
            public byte Number;  // (u8)  axis/button number
        }

        [Flags]
        enum JoystickEventType : byte
        {
            Button = 0x01,    // button pressed/released
            Axis = 0x02,      // joystick moved
            Init = 0x80       // initial state of device
        }

        enum JoystickIoctlCode : uint
        {
            Version = 0x80046a01,
            Axes = 0x80016a11,
            Buttons = 0x80016a12,
            Name128 = (2u << 30) | (0x6A << 8) | (0x13 << 0) | (128 << 16) //JSIOCGNAME(128), which is _IOC(_IO_READ, 'j', 0x13, len)
        }

        static readonly string JoystickPath = "/dev/input";
        static readonly string JoystickPathLegacy = "/dev";

        [Flags]
        enum OpenFlags
        {
            NonBlock = 0x00000800
        }

        static class UnsafeNativeMethods
        {
            [DllImport("libc", SetLastError = true)]
            public static extern int ioctl(int d, JoystickIoctlCode request, ref int data);

            [DllImport("libc", SetLastError = true)]
            public static extern int ioctl(int d, JoystickIoctlCode request, StringBuilder data);

            [DllImport("libc", SetLastError = true)]
            public static extern int ioctl(int d, EvdevIoctlCode request, out EvdevInputId data);

            [DllImport("libc", SetLastError = true)]
            public static extern int open([MarshalAs(UnmanagedType.LPStr)]string pathname, OpenFlags flags);

            [DllImport("libc", SetLastError = true)]
            public static extern int close(int fd);

            [DllImport("libc", SetLastError = true)]
            unsafe public static extern IntPtr read(int fd, void* buffer, UIntPtr count);
        }

        #endregion

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

                foreach (JoystickDevice<X11JoyDetails> js in sticks)
                {
                    CloseJoystick(js);
                }

                disposed = true;
            }
        }

        ~X11Joystick()
        {
            Dispose(false);
        }

        #endregion

        #region IJoystickDriver2 Members

        JoystickState IJoystickDriver2.GetState(int index)
        {
            if (IsValid(index))
            {
                JoystickDevice<X11JoyDetails> js = 
                    sticks[index_to_stick[index]];
                PollJoystick(js);
                return js.Details.State;
            }
            return new JoystickState();
        }

        JoystickCapabilities IJoystickDriver2.GetCapabilities(int index)
        {
            JoystickCapabilities caps = new JoystickCapabilities();
            if (IsValid(index))
            {
                JoystickDevice<X11JoyDetails> js = sticks[index_to_stick[index]];
                caps = new JoystickCapabilities(
                    js.Axis.Count, js.Button.Count, js.Details.State.IsConnected);
            }
            return caps;
        }

        Guid IJoystickDriver2.GetGuid(int index)
        {
            if (IsValid(index))
            {
                JoystickDevice<X11JoyDetails> js = sticks[index_to_stick[index]];
                return js.Details.Guid; 
            }
            return new Guid();
        }

        #endregion
    }
}
