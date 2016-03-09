// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using OpenTK.Input;

namespace OpenTK.Platform.SDL2
{
    class Sdl2InputDriver : IInputDriver2
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
                SDL.GameControllerEventState(EventState.Enable);
                SDL.JoystickEventState(EventState.Enable);

                EventFilterDelegate = Marshal.GetFunctionPointerForDelegate(EventFilterDelegate_GCUnsafe);
                driver_handle = new IntPtr(count++);
                DriverHandles.Add(driver_handle, this);
                SDL.AddEventWatch(EventFilterDelegate, driver_handle);
                if (SDL.InitSubSystem(SystemFlags.JOYSTICK) < 0)
                {
                    Debug.Print("[SDL2] InputDriver failed to init Joystick subsystem. Error: {0}", SDL.GetError());
                }
                if (SDL.InitSubSystem(SystemFlags.GAMECONTROLLER) < 0)
                {
                    Debug.Print("[SDL2] InputDriver failed to init GameController subsystem. Error: {0}", SDL.GetError());
                }
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

                        case EventType.JOYDEVICEADDED:
                        case EventType.JOYDEVICEREMOVED:
                            driver.joystick_driver.ProcessJoystickEvent(ev.JoyDevice);
                            break;

                        case EventType.JOYAXISMOTION:
                            driver.joystick_driver.ProcessJoystickEvent(ev.JoyAxis);
                            break;

                        case EventType.JOYBALLMOTION:
                            driver.joystick_driver.ProcessJoystickEvent(ev.JoyBall);
                            break;

                        case EventType.JOYBUTTONDOWN:
                        case EventType.JOYBUTTONUP:
                            driver.joystick_driver.ProcessJoystickEvent(ev.JoyButton);
                            break;

                        case EventType.JOYHATMOTION:
                            driver.joystick_driver.ProcessJoystickEvent(ev.JoyHat);
                            break;

#if USE_SDL2_GAMECONTROLLER
                        case EventType.CONTROLLERDEVICEADDED:
                        case EventType.CONTROLLERDEVICEREMOVED:
                            driver.joystick_driver.ProcessControllerEvent(ev.ControllerDevice);
                            break;

                        case EventType.CONTROLLERAXISMOTION:
                            driver.joystick_driver.ProcessControllerEvent(ev.ControllerAxis);
                            break;

                        case EventType.CONTROLLERBUTTONDOWN:
                        case EventType.CONTROLLERBUTTONUP:
                            driver.joystick_driver.ProcessControllerEvent(ev.ControllerButton);
                            break;
#endif
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
                return joystick_driver;
            }
        }

        public IJoystickDriver2 JoystickDriver
        {
            get
            {
                return joystick_driver;
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

