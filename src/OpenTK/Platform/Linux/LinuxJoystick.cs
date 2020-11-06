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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using OpenTK.Input;

namespace OpenTK.Platform.Linux
{
    internal struct AxisInfo
    {
        public int Axis;
        public InputAbsInfo Info;
    }

    internal class LinuxJoystickDetails
    {
        public Guid Guid;
        public string Name;
        public int FileDescriptor;
        public int PathIndex; // e.g. "0" for "/dev/input/event0". Used as a hardware id
        public JoystickState State;
        public JoystickCapabilities Caps;

        public readonly Dictionary<EvdevAxis, AxisInfo> AxisMap =
            new Dictionary<EvdevAxis, AxisInfo>();
        public readonly Dictionary<EvdevButton, int> ButtonMap =
            new Dictionary<EvdevButton, int>();

        internal int[,] hatStates =
        {
            {0, 0},
            {0, 0},
            {0, 0},
            {0, 0}
        };
    }

    internal sealed class LinuxJoystick : IJoystickDriver2
    {
        private static readonly HatPosition[,] HatPositions = new HatPosition[,]
        {
            { HatPosition.UpLeft, HatPosition.Up, HatPosition.UpRight },
            { HatPosition.Left, HatPosition.Centered, HatPosition.Right },
            { HatPosition.DownLeft, HatPosition.Down, HatPosition.DownRight }
        };

        private readonly object sync = new object();

        private readonly DeviceCollection<LinuxJoystickDetails> Sticks =
            new DeviceCollection<LinuxJoystickDetails>();

        private volatile bool disposed;

        private const string InputDevicePath = "/proc/bus/input/devices";
        /// <summary>The evdev path on recent Xorg versions</summary>
        private static readonly string JoystickPath = "/dev/input";
        /// <summary>The legacy evdev fallback Xorg path</summary>
        private static readonly string JoystickPathLegacy = "/dev";

        /// <summary>Thread used to monitor ProcFS for changes in order to support hotplugging of joysticks</summary>
        private readonly Thread ProcFSMonitorThread;

        /// <summary>Gets the actual evdev path used by the XOrg server</summary>
        /// <remarks>See <see href="https://www.kernel.org/doc/Documentation/input/input.txt">the Linux kernel documentation</see> for further details.</remarks>
        private string EvdevPath
        {
            get
            {
                return Directory.Exists(JoystickPath) ? JoystickPath :
                    Directory.Exists(JoystickPathLegacy) ? JoystickPathLegacy :
                    String.Empty;
            }
        }

        public LinuxJoystick()
        {
            ProcFSMonitorThread = new Thread(ProcessEvents);
            ProcFSMonitorThread.IsBackground = true;
            ProcFSMonitorThread.Start();
            //Populate the initial list of joysticks
            if (!String.IsNullOrEmpty(EvdevPath))
            {
                OpenJoysticks(EvdevPath);
            }
        }

        private readonly MD5 Hasher = MD5.Create();

        private string procHash;

        private void ProcessEvents()
        {
            if (!File.Exists(InputDevicePath))
            {
                //BSD may not have the Linux ProcFS, no use running a pointless loop
                return;
            }

            while (!disposed)
            {
                /*
                 * Rather hacky filesystemwatcher equivilant, as it doesn't work on ProcFS
                 * As the thing is psuedo-files, we can't use the last modified date either
                 * We have to load the thing into a stream and hash. At least it's only a few bytes.....
                 *
                 * Note: We could possibly override the Mono filesystem watcher backend, but this is a global variable only
                 * and so may break user code
                 */
                Thread.Sleep(750); //750ms is the Mono default for the file hashing version of FileSystemWatcher backend
                List<int> connectedDevices;
                
                using (FileStream stream = new FileStream(InputDevicePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    string newHash = BitConverter.ToString(Hasher.ComputeHash(stream));
                    if (newHash == procHash)
                    {
                        //Hash of /proc/bus/input/devices has not changed, hence no new devices added / removed
                        continue;
                    }
                    stream.Seek( 0, 0);
                    connectedDevices = GetConnectedDevices(stream);
                    procHash = newHash;
                    OpenJoysticks(EvdevPath);
                }

                List<int> xboxPadCandidates = new List<int>();

                foreach (LinuxJoystickDetails stick in Sticks)
                {
                    if (connectedDevices.Contains(stick.PathIndex))
                    {
                        if (stick.Caps.AxisCount == 6 && stick.Caps.ButtonCount == 11 && stick.Caps.HatCount == 2)
                        {
                            xboxPadCandidates.Add(stick.PathIndex);
                        }
                        else
                        {
                            stick.Caps.SetIsConnected(true);
                            stick.State.SetIsConnected(true);
                        }
                    }
                    else
                    {
                        stick.State.SetIsConnected(false);
                        stick.Caps.SetIsConnected(false);
                    }
                }

                if (xboxPadCandidates.Count < 4)
                {
                    /*
                     * The XBox wireless reciever generates 4 sticks which may not have anything connected to them
                     * If there are less than 4, this can't be this (or it's been fixed evdev side in the meantime)
                     * so let's set them as connected
                     */
                    foreach (int idx in xboxPadCandidates)
                    {
                        LinuxJoystickDetails stick = Sticks.FromHardwareId(idx);
                        if (stick != null)
                        {
                            stick.Caps.SetIsConnected(true);
                            stick.State.SetIsConnected(true);
                        }
                    }
                }
            }
        }

        /// <summary>Gets the list of connected device IDs</summary>
        /// <param name="stream">The filestream to /proc/bus/input/devices</param>
        /// <returns>The list of connected device IDs, or an empty list if no devices are connected</returns>
        private List<int> GetConnectedDevices(FileStream stream)
        {
            List<int> connectedDevices = new List<int>();
            using (StreamReader reader = new StreamReader(stream))
            {
                while (!reader.EndOfStream)
                {
                    string currentLine = reader.ReadLine();
                    if (string.IsNullOrEmpty(currentLine))
                    {
                        continue;
                    }

                    switch (char.ToLower(currentLine[0]))
                    {
                        case 'h':
                            string[] handlers = currentLine.Substring(currentLine.IndexOf('=') + 1).Trim().Split(' ');

                            foreach (string handler in handlers)
                            {
                                if (handler.StartsWith("event", StringComparison.InvariantCultureIgnoreCase))
                                {
                                    //As device is in /proc/bus/input/devices it is connected, so pull out the evdev ID
                                    int evdevID = int.Parse(handler.Substring(5));
                                    connectedDevices.Add(evdevID);
                                }
                            }
                            break;
                    }
                }
            }
            return connectedDevices;
        }


        private void OpenJoysticks(string path)
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

        private int GetJoystickNumber(string path)
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

        private Guid CreateGuid(EvdevInputId id, string name)
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

        private unsafe static bool TestBit(byte* ptr, int bit)
        {
            int byte_offset = bit / 8;
            int bit_offset = bit % 8;
            return (*(ptr + byte_offset) & (1 << bit_offset)) != 0;
        }

        private unsafe static void QueryCapabilities(LinuxJoystickDetails stick,
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
                            Axis = (int)(JoystickHat)hats++,
                            Info = info
                        });
                    }
                    else
                    {
                        // Regular axis
                        stick.AxisMap.Add(axis, new AxisInfo
                        {
                            Axis = axes++,
                            Info = info
                        });
                    }
                }
            }

            for (EvdevButton button = 0; button < EvdevButton.Last && (int)button < keybytes * 8; button++)
            {
                if (TestBit(keybit, (int)button))
                {
                    stick.ButtonMap.Add(button, buttons++);
                }
            }
        }

        private LinuxJoystickDetails OpenJoystick(string path)
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
                    {
                        return null;
                    }

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

        private void CloseJoystick(LinuxJoystickDetails js)
        {
            Sticks.Remove(js.FileDescriptor);

            Libc.close(js.FileDescriptor);
            js.FileDescriptor = -1;
            js.State = new JoystickState(); // clear joystick state
            js.Caps = new JoystickCapabilities();
        }

        private JoystickHatState TranslateHat(int x, int y)
        {
            return new JoystickHatState(HatPositions[x, y]);
        }

        
        private void PollJoystick(LinuxJoystickDetails js)
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
                    {
                        break;
                    }
                    //As we've received an event, this must be connected!
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
                                                int hat = (e->Code - (int)EvdevAxis.HAT0X) / 2;
                                                int xy_axis = (int)axis.Axis & 0x1;
                                                int value = e->Value.CompareTo(0) + 1;
                                                switch (xy_axis)
                                                {
                                                    case 0:
                                                        // X-axis
                                                        js.hatStates[hat, 1] = value;
                                                        break;

                                                    case 1:
                                                        // Y-axis
                                                        js.hatStates[hat, 0] = value;
                                                        break;
                                                }
                                                js.State.SetHat((JoystickHat)hat, TranslateHat(js.hatStates[hat, 0], js.hatStates[hat, 1]));
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
                                    int button;
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

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool manual)
        {
            if (!disposed)
            {
                if (manual)
                {
                }
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

        string IJoystickDriver2.GetName(int index)
        {
            LinuxJoystickDetails js = Sticks.FromIndex(index);
            if (js != null)
            {
                return js.Name;
            }
            return String.Empty;
        }
    }
}
