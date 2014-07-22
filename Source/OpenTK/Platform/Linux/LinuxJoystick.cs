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
    struct LinuxJoyDetails
    {
        public Guid Guid;
        public int FileDescriptor;
        public JoystickState State;
    }

    // Note: despite what the name says, this class is Linux-specific.
    sealed class LinuxJoystick : IJoystickDriver2
    {
        #region Fields

        readonly object sync = new object();

        readonly FileSystemWatcher watcher = new FileSystemWatcher();

        readonly Dictionary<int, int> index_to_stick = new Dictionary<int, int>();
        List<JoystickDevice<LinuxJoyDetails>> sticks = new List<JoystickDevice<LinuxJoyDetails>>();

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
                    JoystickDevice<LinuxJoyDetails> stick = OpenJoystick(file);
                    if (stick != null)
                    {
                        //stick.Description = String.Format("USB Joystick {0} ({1} axes, {2} buttons, {3}{0})",
                        //number, stick.Axis.Count, stick.Button.Count, path);
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

        Guid CreateGuid(JoystickDevice<LinuxJoyDetails> js, string path, int number)
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
        
        JoystickDevice<LinuxJoyDetails> OpenJoystick(string path)
        {
            JoystickDevice<LinuxJoyDetails> stick = null;

            int number = GetJoystickNumber(Path.GetFileName(path));
            if (number >= 0)
            {
                int fd = -1;
                try
                {
                    fd = Libc.open(path, OpenFlags.NonBlock);
                    if (fd == -1)
                        return null;

                    // Check joystick driver version (must be 1.0+)
                    int driver_version = 0x00000800;
                    Libc.ioctl(fd, JoystickIoctlCode.Version, ref driver_version);
                    if (driver_version < 0x00010000)
                        return null;

                    // Get number of joystick axes
                    int axes = 0;
                    Libc.ioctl(fd, JoystickIoctlCode.Axes, ref axes);

                    // Get number of joystick buttons
                    int buttons = 0;
                    Libc.ioctl(fd, JoystickIoctlCode.Buttons, ref buttons);

                    stick = new JoystickDevice<LinuxJoyDetails>(number, axes, buttons);

                    StringBuilder sb = new StringBuilder(128);
                    Libc.ioctl(fd, JoystickIoctlCode.Name128, sb);
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
                        Libc.close(fd);
                }
            }

            return stick;
        }

        void CloseJoystick(JoystickDevice<LinuxJoyDetails> js)
        {
            Libc.close(js.Details.FileDescriptor);
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

        void PollJoystick(JoystickDevice<LinuxJoyDetails> js)
        {
            JoystickEvent e;

            unsafe
            {
                while ((long)Libc.read(js.Details.FileDescriptor, (void*)&e, (UIntPtr)sizeof(JoystickEvent)) > 0)
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
                foreach (JoystickDevice<LinuxJoyDetails> js in sticks)
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
            if (IsValid(index))
            {
                JoystickDevice<LinuxJoyDetails> js = 
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
                JoystickDevice<LinuxJoyDetails> js = sticks[index_to_stick[index]];
                caps = new JoystickCapabilities(
                    js.Axis.Count,
                    js.Button.Count,
                    0, // hats not supported by /dev/js
                    js.Details.State.IsConnected);
            }
            return caps;
        }

        Guid IJoystickDriver2.GetGuid(int index)
        {
            if (IsValid(index))
            {
                JoystickDevice<LinuxJoyDetails> js = sticks[index_to_stick[index]];
                return js.Details.Guid; 
            }
            return new Guid();
        }

        #endregion
    }
}
