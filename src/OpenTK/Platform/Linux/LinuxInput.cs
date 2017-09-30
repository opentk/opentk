//
// LinuxKeyboardLibInput.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2006-2014 Stefanos Apostolopoulos
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

using System;
using System.Diagnostics;
#if !MINIMAL
using System.Drawing;
#endif
using System.Runtime.InteropServices;
using System.Threading;
using OpenTK.Input;

namespace OpenTK.Platform.Linux
{
    internal class LinuxInput : IKeyboardDriver2, IMouseDriver2, IDisposable
    {
        private class DeviceBase
        {
            private readonly IntPtr Device;
            private string name;
            private string output;
            private string logical_seat;
            private string physical_seat;

            public DeviceBase(IntPtr device, int id)
            {
                Device = device;
                Id = id;
            }

            public int Id
            {
                get
                {
                    return GetId(Device);
                }
                set
                {
                    LibInput.DeviceSetData(Device, (IntPtr)value);
                }
            }

            public string Name
            {
                get
                {
                    name = name ?? LibInput.DeviceGetName(Device);
                    return name;
                }
            }

            public IntPtr Seat
            {
                get
                {
                    return LibInput.DeviceGetSeat(Device);
                }
            }

            public string LogicalSeatName
            {
                get
                {
                    logical_seat = logical_seat ?? LibInput.SeatGetLogicalName(Seat);
                    return logical_seat;
                }
            }

            public string PhysicalSeatName
            {
                get
                {
                    physical_seat = physical_seat ?? LibInput.SeatGetPhysicalName(Seat);
                    return physical_seat;
                }
            }

            public string Output
            {
                get
                {
                    output = output ?? LibInput.DeviceGetOutputName(Device);
                    return output;
                }
            }
        }

        private class KeyboardDevice : DeviceBase
        {
            public KeyboardState State;

            public KeyboardDevice(IntPtr device, int id)
                : base(device, id)
            {
            }
        }

        private class MouseDevice : DeviceBase
        {
            public MouseState State;

            public MouseDevice(IntPtr device, int id)
                : base(device, id)
            {
            }
        }

        private static readonly object Sync = new object();
        private static readonly Key[] KeyMap = Evdev.KeyMap;
        private static long DeviceFDCount;

        // libinput returns various devices with keyboard/pointer even though
        // they are not traditional keyboards/mice (for example "Integrated Camera"
        // can be detected as a keyboard.)
        // Since there is no API to retrieve actual device capabilities,
        // we add all detected devices to a "candidate" list and promote them
        // to an actual keyboard/mouse only when we receive a valid input event.
        // This is far from optimal, but it appears to be the only viable solution
        // unless a new API is added to libinput.
        private DeviceCollection<KeyboardDevice> KeyboardCandidates = new DeviceCollection<KeyboardDevice>();

        private DeviceCollection<MouseDevice> MouseCandidates = new DeviceCollection<MouseDevice>();
        private DeviceCollection<KeyboardDevice> Keyboards = new DeviceCollection<KeyboardDevice>();
        private DeviceCollection<MouseDevice> Mice = new DeviceCollection<MouseDevice>();

        // Todo: do we need to maintain the geometry of each display separately?
        private Rectangle bounds;

        // Global mouse cursor state
        private Vector2 CursorPosition = Vector2.Zero;
        // Global mouse cursor offset (used for emulating SetPosition)
        private Vector2 CursorOffset = Vector2.Zero;

        private IntPtr udev;
        private IntPtr input_context;

        private InputInterface input_interface = new InputInterface(
            OpenRestricted, CloseRestricted);

        private int fd;
        private Thread input_thread;
        private long exit;

        public LinuxInput()
        {
            Debug.Print("[Linux] Initializing {0}", GetType().Name);
            Debug.Indent();
            try
            {
                Semaphore ready = new Semaphore(0, 1);
                input_thread = new Thread(InputThreadLoop);
                input_thread.IsBackground = true;
                input_thread.Start(ready);

                // Wait until the input thread is ready.
                // Note: it would be nicer if we could avoid this.
                // however we need to marshal errors back to the caller
                // as exceptions.
                // Todo: in a future version, we should add an "Application" object
                // to handle all communication with the OS (including event processing.)
                // Once we do that, we can remove all separate input threads.
                ready.WaitOne();
                if (exit != 0)
                {
                    throw new NotSupportedException();
                }
            }
            finally
            {
                Debug.Print("Initialization {0}", exit == 0 ?
                    "complete" : "failed");
                Debug.Unindent();
            }
        }

        private static CloseRestrictedCallback CloseRestricted = CloseRestrictedHandler;

        private static void CloseRestrictedHandler(int fd, IntPtr data)
        {
            Debug.Print("[Input] Closing fd {0}", fd);
            int ret = Libc.close(fd);

            if (ret < 0)
            {
                Debug.Print("[Input] Failed to close fd {0}. Error: {1}", fd, ret);
            }
            else
            {
                Interlocked.Decrement(ref DeviceFDCount);
            }
        }

        private static OpenRestrictedCallback OpenRestricted = OpenRestrictedHandler;

        private static int OpenRestrictedHandler(IntPtr path, int flags, IntPtr data)
        {
            int fd = Libc.open(path, (OpenFlags)flags);
            Debug.Print("[Input] Opening '{0}' with flags {1}. fd:{2}",
                Marshal.PtrToStringAnsi(path), (OpenFlags)flags, fd);

            if (fd >= 0)
            {
                Interlocked.Increment(ref DeviceFDCount);
            }

            return fd;
        }

        private void InputThreadLoop(object semaphore)
        {
            Debug.Print("[Input] Running on thread {0}", Thread.CurrentThread.ManagedThreadId);
            Setup();

            // Inform the parent thread that initialization has completed successfully
            (semaphore as Semaphore).Release();
            Debug.Print("[Input] Released main thread.", input_context);

            // Use a blocking poll for input messages, in order to reduce CPU usage
            PollFD poll_fd = new PollFD();
            poll_fd.fd = fd;
            poll_fd.events = PollFlags.In;
            Debug.Print("[Input] Created PollFD({0}, {1})", poll_fd.fd, poll_fd.events);

            Debug.Print("[Input] Entering input loop.", poll_fd.fd, poll_fd.events);
            while (Interlocked.Read(ref exit) == 0)
            {
                int ret = Libc.poll(ref poll_fd, 1, -1);
                ErrorNumber error = (ErrorNumber)Marshal.GetLastWin32Error();
                bool is_error =
                    ret < 0 && !(error == ErrorNumber.Again || error == ErrorNumber.Interrupted) ||
                    (poll_fd.revents & (PollFlags.Hup | PollFlags.Error | PollFlags.Invalid)) != 0;

                // We need to query the desktop bounds in order to position the mouse cursor correctly.
                // This value will be used for the current bunch of input events. If a monitor changes
                // resolution in the meantime, we might be slightly off in our calculations - this error
                // will be corrected when the next bunch of input events arrives.
                UpdateDisplayBounds();

                if (ret > 0 && (poll_fd.revents & (PollFlags.In | PollFlags.Pri)) != 0)
                {
                    ProcessEvents(input_context);
                }

                if (is_error)
                {
                    Debug.Print("[Input] Exiting input loop {0} due to poll error [ret:{1} events:{2}]. Error: {3}.",
                        input_thread.ManagedThreadId, ret, poll_fd.revents, error);
                    Interlocked.Increment(ref exit);
                }
            }
            Debug.Print("[Input] Exited input loop.", poll_fd.fd, poll_fd.events);
        }

        private void UpdateDisplayBounds()
        {
            bounds = Rectangle.Empty;
            for (DisplayIndex i = DisplayIndex.First; i < DisplayIndex.Sixth; i++)
            {
                DisplayDevice display = DisplayDevice.GetDisplay(i);
                if (display != null)
                {
                    bounds = Rectangle.Union(bounds, display.Bounds);
                }
            }
        }

        private void UpdateCursor()
        {
            Point p = new Point(
                (int)Math.Round(CursorPosition.X + CursorOffset.X),
                (int)Math.Round(CursorPosition.Y + CursorOffset.Y));

            DisplayDevice display = DisplayDevice.FromPoint(p.X, p.Y) ?? DisplayDevice.Default;
            if (display != null)
            {
                LinuxDisplay d = (LinuxDisplay)display.Id;
                Drm.MoveCursor(d.FD, d.Id, p.X, p.Y);
            }
        }

        private void Setup()
        {
            // Todo: add static path fallback when udev is not installed.
            udev = Udev.New();
            if (udev == IntPtr.Zero)
            {
                Debug.Print("[Input] Udev.New() failed.");
                Interlocked.Increment(ref exit);
                return;
            }
            Debug.Print("[Input] Udev.New() = {0:x}", udev);

            input_context = LibInput.CreateContext(input_interface, IntPtr.Zero, udev);
            if (input_context == IntPtr.Zero)
            {
                Debug.Print("[Input] LibInput.CreateContext({0:x}) failed.", udev);
                Interlocked.Increment(ref exit);
                return;
            }
            Debug.Print("[Input] LibInput.CreateContext({0:x}) = {1:x}", udev, input_context);

            string seat_id = "seat0";
            int seat_assignment = LibInput.AssignSeat(input_context, seat_id);
            if (seat_assignment == -1)
            {
                Debug.Print("[Input] LibInput.AssignSeat({0:x}) = {1} failed.", input_context, seat_id);
                Interlocked.Increment(ref exit);
                return;
            }
            Debug.Print("[Input] LibInput.AssignSeat({0:x}) = {1}", input_context, seat_id);

            fd = LibInput.GetFD(input_context);
            if (fd < 0)
            {
                Debug.Print("[Input] LibInput.GetFD({0:x}) failed.", input_context);
                Interlocked.Increment(ref exit);
                return;
            }
            Debug.Print("[Input] LibInput.GetFD({0:x}) = {1}.", input_context, fd);

            ProcessEvents(input_context);
            LibInput.Resume(input_context);
            Debug.Print("[Input] LibInput.Resume({0:x})", input_context);

            if (Interlocked.Read(ref DeviceFDCount) <= 0)
            {
                Debug.Print("[Error] Failed to open any input devices.");
                Debug.Print("[Error] Ensure that you have access to '/dev/input/event*'.");
                Interlocked.Increment(ref exit);
            }
        }

        private void ProcessEvents(IntPtr input_context)
        {
            // Process all events in the event queue
            while (true)
            {
                // Data available
                int ret = LibInput.Dispatch(input_context);
                if (ret != 0)
                {
                    Debug.Print("[Input] LibInput.Dispatch({0:x}) failed. Error: {1}",
                        input_context, ret);
                    break;
                }

                IntPtr pevent = LibInput.GetEvent(input_context);
                if (pevent == IntPtr.Zero)
                {
                    break;
                }

                IntPtr device = LibInput.GetDevice(pevent);
                InputEventType type = LibInput.GetEventType(pevent);

                lock (Sync)
                {
                    switch (type)
                    {
                        case InputEventType.DeviceAdded:
                            HandleDeviceAdded(input_context, device);
                            break;

                        case InputEventType.DeviceRemoved:
                            HandleDeviceRemoved(input_context, device);
                            break;

                        case InputEventType.KeyboardKey:
                            HandleKeyboard(GetKeyboard(device), LibInput.GetKeyboardEvent(pevent));
                            break;

                        case InputEventType.PointerAxis:
                            HandlePointerAxis(GetMouse(device), LibInput.GetPointerEvent(pevent));
                            break;

                        case InputEventType.PointerButton:
                            HandlePointerButton(GetMouse(device), LibInput.GetPointerEvent(pevent));
                            break;

                        case InputEventType.PointerMotion:
                            HandlePointerMotion(GetMouse(device), LibInput.GetPointerEvent(pevent));
                            break;

                        case InputEventType.PointerMotionAbsolute:
                            HandlePointerMotionAbsolute(GetMouse(device), LibInput.GetPointerEvent(pevent));
                            break;
                    }
                }

                LibInput.DestroyEvent(pevent);
            }
        }

        private void HandleDeviceAdded(IntPtr context, IntPtr device)
        {
            if (LibInput.DeviceHasCapability(device, DeviceCapability.Keyboard))
            {
                KeyboardDevice keyboard = new KeyboardDevice(device, Keyboards.Count);
                KeyboardCandidates.Add(keyboard.Id, keyboard);
                Debug.Print("[Input] Added keyboard device {0} '{1}' on '{2}' ('{3}')",
                    keyboard.Id, keyboard.Name, keyboard.LogicalSeatName, keyboard.PhysicalSeatName);
            }

            if (LibInput.DeviceHasCapability(device, DeviceCapability.Mouse))
            {
                MouseDevice mouse = new MouseDevice(device, Mice.Count);
                MouseCandidates.Add(mouse.Id, mouse);
                Debug.Print("[Input] Added mouse device {0} '{1}' on '{2}' ('{3}')",
                    mouse.Id, mouse.Name, mouse.LogicalSeatName, mouse.PhysicalSeatName);
            }

            if (LibInput.DeviceHasCapability(device, DeviceCapability.Touch))
            {
                Debug.Print("[Input] Todo: touch device.");
            }
        }

        private void HandleDeviceRemoved(IntPtr context, IntPtr device)
        {
            if (LibInput.DeviceHasCapability(device, DeviceCapability.Keyboard))
            {
                int id = GetId(device);
                Keyboards.TryRemove(id);
                KeyboardCandidates.TryRemove(id);
            }

            if (LibInput.DeviceHasCapability(device, DeviceCapability.Mouse))
            {
                int id = GetId(device);
                Mice.TryRemove(id);
                MouseCandidates.TryRemove(id);
            }
        }

        private void HandleKeyboard(KeyboardDevice device, KeyboardEvent e)
        {
            if (device != null)
            {
                device.State.SetIsConnected(true);
                Debug.Print("[Input] Added keyboard {0}", device.Id);

                Key key = Key.Unknown;
                uint raw = e.Key;
                if (raw >= 0 && raw < KeyMap.Length)
                {
                    key = KeyMap[raw];
                }

                if (key == Key.Unknown)
                {
                    Debug.Print("[Linux] Unknown key with code '{0}'", raw);
                }

                device.State.SetKeyState(key, e.KeyState == KeyState.Pressed);
            }
        }

        private void HandlePointerAxis(MouseDevice mouse, PointerEvent e)
        {
            if (mouse != null)
            {
                mouse.State.SetIsConnected(true);

                if (e.HasAxis(PointerAxis.HorizontalScroll))
                {
                    mouse.State.SetScrollRelative((float)e.AxisValue(PointerAxis.HorizontalScroll), 0);
                }
                if (e.HasAxis(PointerAxis.VerticalScroll))
                {
                    mouse.State.SetScrollRelative(0, (float)e.AxisValue(PointerAxis.VerticalScroll));
                }
            }
        }

        private void HandlePointerButton(MouseDevice mouse, PointerEvent e)
        {
            if (mouse != null)
            {
                mouse.State.SetIsConnected(true);

                MouseButton button = Evdev.GetMouseButton(e.Button);
                ButtonState state = e.ButtonState;
                mouse.State[(MouseButton)button] = state == ButtonState.Pressed;
            }
        }

        private void HandlePointerMotion(MouseDevice mouse, PointerEvent e)
        {
            Vector2 delta = new Vector2((float)e.DeltaX, (float)e.DeltaY);
            if (mouse != null)
            {
                mouse.State.SetIsConnected(true);
                mouse.State.Position += delta;
            }

            CursorPosition = new Vector2(
                MathHelper.Clamp(CursorPosition.X + delta.X, bounds.Left, bounds.Right - 1),
                MathHelper.Clamp(CursorPosition.Y + delta.Y, bounds.Top, bounds.Bottom - 1));
            UpdateCursor();
        }

        private void HandlePointerMotionAbsolute(MouseDevice mouse, PointerEvent e)
        {
            if (mouse != null)
            {
                mouse.State.SetIsConnected(true);
                mouse.State.Position = new Vector2((float)e.X, (float)e.Y);
            }

            CursorPosition = new Vector2(
                (float)e.TransformedX(bounds.Width),
                (float)e.TransformedY(bounds.Height));
            UpdateCursor();
        }

        private static int GetId(IntPtr device)
        {
            return LibInput.DeviceGetData(device).ToInt32();
        }

        private KeyboardDevice GetKeyboard(IntPtr device)
        {
            int id = GetId(device);
            KeyboardDevice keyboard = KeyboardCandidates.FromHardwareId(id);
            if (keyboard != null)
            {
                Keyboards.Add(id, keyboard);
            }
            else
            {
                Debug.Print("[Input] Keyboard {0} does not exist in device list.", id);
            }
            return keyboard;
        }

        private MouseDevice GetMouse(IntPtr device)
        {
            int id = GetId(device);
            MouseDevice mouse = MouseCandidates.FromHardwareId(id);
            if (mouse != null)
            {
                Mice.Add(id, mouse);
            }
            else
            {
                Debug.Print("[Input] Mouse {0} does not exist in device list.", id);
            }
            return mouse;
        }

        KeyboardState IKeyboardDriver2.GetState()
        {
            lock (Sync)
            {
                KeyboardState state = new KeyboardState();
                foreach (KeyboardDevice keyboard in Keyboards)
                {
                    state.MergeBits(keyboard.State);
                }
                return state;
            }
        }

        KeyboardState IKeyboardDriver2.GetState(int index)
        {
            lock (Sync)
            {
                KeyboardDevice device = Keyboards.FromIndex(index);
                if (device != null)
                {
                    return device.State;
                }
                else
                {
                    return new KeyboardState();
                }
            }
        }

        string IKeyboardDriver2.GetDeviceName(int index)
        {
            lock (Sync)
            {
                KeyboardDevice device = Keyboards.FromIndex(index);
                if (device != null)
                {
                    return device.Name;
                }
                else
                {
                    return String.Empty;
                }
            }
        }

        MouseState IMouseDriver2.GetState()
        {
            lock (Sync)
            {
                MouseState state = new MouseState();
                foreach (MouseDevice mouse in Mice)
                {
                    state.MergeBits(mouse.State);
                }
                return state;
            }
        }

        MouseState IMouseDriver2.GetState(int index)
        {
            lock (Sync)
            {
                MouseDevice device = Mice.FromIndex(index);
                if (device != null)
                {
                    return device.State;
                }
                else
                {
                    return new MouseState();
                }
            }
        }

        void IMouseDriver2.SetPosition(double x, double y)
        {
            // Todo: this does not appear to be supported in libinput.
            // We will have to emulate this in the KMS mouse rendering code.
            CursorOffset = new Vector2(
                (float)x - CursorPosition.X,
                (float)y - CursorPosition.Y);
            UpdateCursor();
        }

        MouseState IMouseDriver2.GetCursorState()
        {
            MouseState state = (this as IMouseDriver2).GetState();
            state.Position = CursorPosition + CursorOffset;
            return state;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (input_context != IntPtr.Zero)
                {
                    Debug.Print("[Input] Destroying libinput context");
                    LibInput.Suspend(input_context);
                    Interlocked.Increment(ref exit);

                    LibInput.DestroyContext(input_context);
                    input_context = IntPtr.Zero;
                }

                if (udev != IntPtr.Zero)
                {
                    Debug.Print("[Input] Destroying udev context");
                    Udev.Destroy(udev);
                    udev = IntPtr.Zero;
                }

                input_interface = null;
            }
            else
            {
                Debug.Print("[Input] {0} leaked. Did you forget to call Dispose()?", GetType().FullName);
            }
        }

        ~LinuxInput()
        {
            Dispose(false);
        }
    }
}

