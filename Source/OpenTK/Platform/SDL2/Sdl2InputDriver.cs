#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2013 Stefanos Apostolopoulos for the Open Toolkit library.
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
using System.Threading;
using OpenTK.Input;

namespace OpenTK.Platform.SDL2
{
    class Sdl2InputDriver : IInputDriver2, IInputDriver
    {
        readonly static Dictionary<IntPtr, Sdl2InputDriver> DriverHandles =
            new Dictionary<IntPtr, Sdl2InputDriver>();

        readonly IntPtr driver_handle;

        readonly Sdl2Keyboard keyboard_driver = new Sdl2Keyboard();
        readonly Sdl2Mouse mouse_driver = new Sdl2Mouse();
        readonly Sdl2JoystickDriver joystick_driver = new Sdl2JoystickDriver();

        readonly EventFilter EventFilterDelegate_GCUnsafe = FilterInputEvents;
        readonly IntPtr EventFilterDelegate;

        static int count;
        bool disposed;

        public Sdl2InputDriver()
        {
            lock (SDL.Sync)
            {
                EventFilterDelegate = Marshal.GetFunctionPointerForDelegate(EventFilterDelegate_GCUnsafe);
                driver_handle = new IntPtr(count++);
                DriverHandles.Add(driver_handle, this);
                SDL.AddEventWatch(EventFilterDelegate, driver_handle);
            }
        }

        #region Private Members

        unsafe static int FilterInputEvents(IntPtr driver_handle, IntPtr e)
        {
            try
            {
                Event ev = *(Event*)e;

                Sdl2InputDriver driver;
                if (DriverHandles.TryGetValue(driver_handle, out driver))
                {
                    switch (ev.Type)
                    {
                        case EventType.KEYDOWN:
                        case EventType.KEYUP:
                            driver.keyboard_driver.ProcessKeyboardEvent(ev.Key);
                            break;

                        case EventType.MOUSEBUTTONDOWN:
                        case EventType.MOUSEBUTTONUP:
                            driver.mouse_driver.ProcessMouseEvent(ev.Button);
                            break;

                        case EventType.MOUSEMOTION:
                            driver.mouse_driver.ProcessMouseEvent(ev.Motion);
                            break;

                        case EventType.MOUSEWHEEL:
                            driver.mouse_driver.ProcessWheelEvent(ev.Wheel);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
            }

            return 0;
        }

        #endregion

        #region IInputDriver Members

        public void Poll()
        {
            joystick_driver.Poll();
        }

        #endregion

        #region IJoystickDriver Members

        public IList<JoystickDevice> Joysticks
        {
            get
            {
                return joystick_driver.Joysticks;
            }
        }

        #endregion

        #region IMouseDriver Members

        public IList<MouseDevice> Mouse
        {
            get
            {
                return mouse_driver.Mouse;
            }
        }

        #endregion

        #region IKeyboardDriver Members

        public IList<KeyboardDevice> Keyboard
        {
            get
            {
                return keyboard_driver.Keyboard;
            }
        }

        #endregion

        #region IInputDriver2 Members

        public IMouseDriver2 MouseDriver
        {
            get
            {
                return mouse_driver;
            }
        }

        public IKeyboardDriver2 KeyboardDriver
        {
            get
            {
                return keyboard_driver;
            }
        }

        public IGamePadDriver GamePadDriver
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #region IDisposable Members

        void Dispose(bool manual)
        {
            if (!disposed)
            {
                if (manual)
                {
                    Debug.Print("Disposing {0}", GetType());
                    joystick_driver.Dispose();
                    lock (SDL.Sync)
                    {
                        SDL.DelEventWatch(EventFilterDelegate, driver_handle);
                    }
                    DriverHandles.Remove(driver_handle);
                }
                else
                {
                    Debug.WriteLine("Sdl2InputDriver leaked, did you forget to call Dispose()?");
                }
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~Sdl2InputDriver()
        {
            Dispose(false);
        }

        #endregion
    }
}

