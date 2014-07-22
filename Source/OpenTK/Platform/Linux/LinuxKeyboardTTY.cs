#region License
//
// LinuxKeyboardTTY.cs
//
// Author:
//       thefiddler <stapostol@gmail.com>
//
// Copyright (c) 2006-2014 
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
using System.IO;
using System.Threading;
using OpenTK.Input;

namespace OpenTK.Platform.Linux
{
    // Todo: this has terrible side-effects on process exit
    // (the keyboard remains tied up.) We need to find a
    // proper way to clean up after ourselves, even in case
    // of a crash.
    #if EXPERIMENTAL
    class LinuxKeyboardTTY : IKeyboardDriver2, IDisposable
    {
        const int stdin = 0; // STDIN_FILENO
        readonly object sync = new object();
        Thread input_thread;
        long exit;
        KeyboardState state;

        TerminalState original_state;
        TerminalState current_state;

        IntPtr original_mode = new IntPtr(-1);
        int original_stdin;

        public LinuxKeyboardTTY()
        {
            Debug.Print("[Linux] Using TTY keyboard input.");

            if (!SetupTTY(stdin))
            {
                throw new NotSupportedException();
            }

            input_thread = new Thread(ProcessEvents);
            input_thread.IsBackground = true;
            input_thread.Start();
        }

        #region Private Members

        bool SetupTTY(int stdin)
        {
            // Ensure that we are using a real terminal,
            // rather than some short of file redirection.thing.
            if (!Terminal.IsTerminal(stdin))
            {
                Debug.Print("[Linux] Terminal.IsTerminal({0}) returned false.", stdin);
                return false;
            }

            //original_stdin = Libc.dup(stdin);

            int ret = Terminal.GetAttributes(stdin, out original_state);
            if (ret < 0)
            {
                Debug.Print("[Linux] Terminal.GetAttributes({0}) failed. Error: {1}",
                    stdin, ret);
                return false;
            }

            // Retrieve current keyboard mode
            ret = Libc.ioctl(stdin, KeyboardIoctlCode.GetMode, ref original_mode);
            if (ret != 0)
            {
                Debug.Print("[Linux] Libc.ioctl({0}, KeyboardIoctlCode.GetMode) failed. Error: {1}",
                    stdin, ret);
                return false;
            }

            // Update terminal state
            current_state = original_state;
            current_state.LocalMode &= ~(/*LocalFlags.ECHO |*/ LocalFlags.ICANON | LocalFlags.ISIG);
            current_state.InputMode &= ~(
                InputFlags.ISTRIP | InputFlags.IGNCR | InputFlags.ICRNL |
                InputFlags.INLCR | InputFlags.IXOFF | InputFlags.IXON);
            current_state.ControlCharacters.VMIN = 0;
            current_state.ControlCharacters.VTIME = 0;
            Terminal.SetAttributes(stdin, OptionalActions.FLUSH, ref current_state);

            // Request keycodes
            int mode = 0x02; // K_MEDIUMRAW
            ret = Libc.ioctl(stdin, KeyboardIoctlCode.SetMode, mode);
            if (ret != 0)
            {
                Debug.Print("[Linux] Libc.ioctl({0}, KeyboardIoctlCode.SetMode, {1}) failed. Error: {2}",
                    stdin, mode, ret);
                ExitTTY(this, EventArgs.Empty);
                return false;
            }

            // Ensure we reset the original keyboard/terminal state on exit,
            // even if we crash.
            HookEvents();

            return true;
        }

        void ExitTTY(object sender, EventArgs e)
        {
            if (original_mode != new IntPtr(-1))
            {
                Debug.Print("[Linux] Exiting TTY keyboard input.");

                Libc.ioctl(stdin, KeyboardIoctlCode.SetMode, ref original_mode);
                Terminal.SetAttributes(stdin, OptionalActions.FLUSH, ref original_state);
                original_mode = new IntPtr(-1);

                UnhookEvents();
            }
        }

        void HookEvents()
        {
            Process.GetCurrentProcess().Exited += ExitTTY;
            Console.CancelKeyPress += ExitTTY;
        }

        void UnhookEvents()
        {
            Process.GetCurrentProcess().Exited -= ExitTTY;
            Console.CancelKeyPress -= ExitTTY;
        }

        void ProcessEvents()
        {
            state.SetIsConnected(true);

            while (Interlocked.Read(ref exit) == 0)
            {
                byte scancode;
                short extended;

                while (Libc.read(stdin, out scancode) > 0)
                {
                    bool pressed = (scancode & 0x80) == 0;
                    int key = scancode & ~0x80;
                    KeyModifiers mods;
                    Debug.Print("{0}:{1} is {2}", key, (int)TranslateKey(key, out mods), pressed);

                    if (key == 0)
                    {
                        // This is an extended scancode, ignore
                        Libc.read(stdin, out extended);
                    }
                    else
                    {
                        lock (sync)
                        {
                            state[(Key)key] = pressed;
                        }
                    }

                }
            }

            input_thread = null;
        }

        Key TranslateKey(int key, out KeyModifiers mods)
        {
            int k = MathHelper.Clamp((int)key, 0, KeyMap.Length);
            Key result = KeyMap[k];
            mods = 0;
            mods |= (result == Key.AltLeft || result == Key.AltRight) ? KeyModifiers.Alt : 0;
            mods |= (result == Key.ControlLeft || result == Key.ControlRight) ? KeyModifiers.Control : 0;
            mods |= (result == Key.ShiftLeft || result == Key.ShiftRight) ? KeyModifiers.Shift : 0;
            return KeyMap[k];
        }

        static readonly Key[] KeyMap = Evdev.KeyMap;

        #endregion

        #region IKeyboardDriver2 implementation

        public KeyboardState GetState()
        {
            lock (this)
            {
                return state;
            }
        }

        public KeyboardState GetState(int index)
        {
            lock (this)
            {
                if (index == 0)
                    return state;
                else
                    return new KeyboardState();
            }
        }

        public string GetDeviceName(int index)
        {
            if (index == 0)
                return "Standard Input";
            else
                return String.Empty;
        }

        #endregion

        #region IDisposable Implementation

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        void Dispose(bool disposing)
        {
            Interlocked.Increment(ref exit);

            if (disposing)
            {
                ExitTTY(this, EventArgs.Empty);
            }
            else
            {
                Debug.Print("{0} leaked, did you forget to call Dispose()?", typeof(LinuxKeyboardTTY).FullName);
            }
        }

        ~LinuxKeyboardTTY()
        {
            Dispose(false);
        }

        #endregion
    }
    #endif
}

