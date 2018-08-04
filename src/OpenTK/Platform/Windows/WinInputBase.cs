//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2010 the Open Toolkit library.
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
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using OpenTK.Core.Platform;
using OpenTK.Input;
using OpenTK.NT.Native;

namespace OpenTK.Platform.Windows
{
    internal abstract class WinInputBase
    {
        private static readonly IntPtr Unhandled = new IntPtr(-1);
        private readonly AutoResetEvent InputReady = new AutoResetEvent(false);
        private readonly Thread InputThread;
        private readonly WindowProc WindowProc;

        protected bool Disposed;

        private IntPtr OldWndProc;

        public WinInputBase()
        {
            WindowProc = WindowProcedure;

            InputThread = new Thread(ProcessEvents);
            InputThread.SetApartmentState(ApartmentState.STA);
            InputThread.IsBackground = true;
            InputThread.Start();

            InputReady.WaitOne();
        }

        protected INativeWindow Native { get; private set; }

        protected WinWindowInfo Parent => (WinWindowInfo)Native.WindowInfo;

        public abstract IMouseDriver2 MouseDriver { get; }

        public abstract IKeyboardDriver2 KeyboardDriver { get; }

        public abstract IJoystickDriver2 JoystickDriver { get; }

        private INativeWindow ConstructMessageWindow()
        {
            Debug.WriteLine("Initializing input driver.");
            Debug.Indent();

            // Create a new message-only window to retrieve WM_INPUT messages.
            INativeWindow native = new NativeWindow();
            native.ProcessEvents();
            var parent = native.WindowInfo as WinWindowInfo;
            User32.Window.SetParent(parent.Handle, new IntPtr(-3)); // HWND_MESSAGE, a message-only window
            native.ProcessEvents();

            Debug.Unindent();
            return native;
        }


        private void ProcessEvents()
        {
            Native = ConstructMessageWindow();
            CreateDrivers();

            // Subclass the window to retrieve the events we are interested in.
            OldWndProc = User32.Window.SetWindowLong(Parent.Handle, WindowProc);
            Debug.Print("Input window attached to {0}", Parent);

            InputReady.Set();

            while (Native.Exists)
            {
                var ret = User32.Message.GetMessage(out Msg msg, Parent.Handle, 0, 0);
                if (ret == -1)
                {
                    throw new PlatformException(
                        $"An error happened while processing the message queue. Windows error: {Marshal.GetLastWin32Error()}");
                }

                User32.Message.TranslateMessage(ref msg);
                User32.Message.DispatchMessage(ref msg);
            }
        }

        private IntPtr WndProcHandler(
            IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            var ret = WindowProcedure(handle, message, wParam, lParam);
            if (ret == Unhandled)
            {
                return User32.Window.CallWindowProc(OldWndProc, handle, message, wParam, lParam);
            }

            return ret;
        }

        protected virtual IntPtr WindowProcedure(
            IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            return Unhandled;
        }

        // Note: this method is called through the input thread.
        protected abstract void CreateDrivers();

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool manual)
        {
            if (!Disposed)
            {
                if (manual)
                {
                    if (Native != null)
                    {
                        Native.Close();
                        Native.Dispose();
                    }
                }

                Disposed = true;
            }
        }

        ~WinInputBase()
        {
            Debug.Print("[Warning] Resource leaked: {0}.", this);
            Dispose(false);
        }
    }
}