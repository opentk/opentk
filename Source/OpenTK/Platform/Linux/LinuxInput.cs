#region License
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
#endregion

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using OpenTK.Input;

namespace OpenTK.Platform.Linux
{
    class LinuxInput : IKeyboardDriver2, IMouseDriver2, IDisposable
    {
        IntPtr udev;
        IntPtr input_context;
        InputInterface input_interface = new InputInterface(
            OpenRestricted, CloseRestricted);
        int fd;
        Thread input_thread;
        long exit;

        public LinuxInput()
        {
            Debug.Print("[Linux] Initializing {0}", GetType().Name);

            input_thread = new Thread(ProcessEvents);
            input_thread.IsBackground = true;

            // Todo: add static path fallback when udev is not installed.
            udev = Udev.New();
            if (udev == IntPtr.Zero)
            {
                throw new NotSupportedException("[Input] Udev.New() failed.");
            }

            input_context = LibInput.CreateContext(input_interface,
                IntPtr.Zero, udev, "seat0");
            if (input_context == IntPtr.Zero)
            {
                throw new NotSupportedException(
                    String.Format("[Input] LibInput.CreateContext({0:x}) failed.", udev));
            }

            fd = LibInput.GetFD(input_context);
            if (fd < 0)
            {
                throw new NotSupportedException(
                    String.Format("[Input] LibInput.GetFD({0:x}) failed.", input_context));
            }

            input_thread.Start();
        }

        #region Private Members

        static CloseRestrictedCallback CloseRestricted = CloseRestrictedHandler;
        static void CloseRestrictedHandler(int fd, IntPtr data)
        {
            Debug.Print("[Input] Closing fd {0}", fd);
            Libc.close(fd);
        }

        static OpenRestrictedCallback OpenRestricted = OpenRestrictedHandler;
        static int OpenRestrictedHandler(IntPtr path, int flags, IntPtr data) 
        {
            int fd = Libc.open(path, (OpenFlags)flags);
            Debug.Print("[Input] Opening '{0}' with flags {1}. fd:{2}",
                Marshal.PtrToStringAnsi(path), (OpenFlags)flags, fd);

            return fd;
        }

        void ProcessEvents()
        {
            PollFD poll_fd = new PollFD();
            poll_fd.fd = fd;
            poll_fd.events = PollFlags.In;

            while (Interlocked.Read(ref exit) == 0)
            {
                int ret = Libc.poll(ref poll_fd, 1, -1);
                if (ret > 0 && (poll_fd.revents & PollFlags.In) != 0)
                {
                    // Data available
                    ret = LibInput.Dispatch(input_context);
                    if (ret != 0)
                    {
                        Debug.Print("[Input] LibInput.Dispatch({0:x}) failed. Error: {1}",
                            input_context, ret);
                        continue;
                    }

                    IntPtr pevent = LibInput.GetEvent(input_context);
                    if (pevent == IntPtr.Zero)
                    {
                        Debug.Print("[Input] LibInput.GetEvent({0:x}) failed.",
                            input_context);
                        continue;
                    }

                    InputEventType type = LibInput.GetEventType(pevent);
                    Debug.Print(type.ToString());

                    LibInput.DestroyEvent(pevent);
                }
                else if (ret < 0)
                {
                    // An error has occurred
                    Debug.Print("[Input] Exiting input thread {0} [ret:{1} events:{2}]",
                        input_thread.ManagedThreadId, ret, poll_fd.revents);
                    Interlocked.Increment(ref exit);
                }
            }
        }

        #endregion

        #region IKeyboardDriver2 implementation

        KeyboardState IKeyboardDriver2.GetState()
        {
            return new KeyboardState();
        }

        KeyboardState IKeyboardDriver2.GetState(int index)
        {
            return new KeyboardState();
        }

        string IKeyboardDriver2.GetDeviceName(int index)
        {
            return String.Empty;
        }

        #endregion

        #region IMouseDriver2 implementation

        MouseState IMouseDriver2.GetState()
        {
            throw new NotImplementedException();
        }

        MouseState IMouseDriver2.GetState(int index)
        {
            throw new NotImplementedException();
        }

        void IMouseDriver2.SetPosition(double x, double y)
        {
            throw new NotImplementedException();
        }

        MouseState IMouseDriver2.GetCursorState()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IDisposable implementation

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (input_context != IntPtr.Zero)
                {
                    LibInput.Suspend(input_context);
                    Interlocked.Increment(ref exit);

                    LibInput.DestroyContext(input_context);
                    input_context = IntPtr.Zero;
                }

                if (udev != IntPtr.Zero)
                {
                    Udev.Destroy(udev);
                    udev = IntPtr.Zero;
                }

                input_interface = null;
            }
        }

        ~LinuxInput()
        {
            Dispose(false);
        }

        #endregion
    }
}

