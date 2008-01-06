#region --- License ---
/* Copyright (c) 2007 Stefanos Apostolopoulos
 * See license.txt for license information
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using OpenTK.Input;
using System.Diagnostics;

namespace OpenTK.Platform.Windows
{
    /// <summary>
    /// Input driver for legacy (pre XP) Windows platforms.
    /// </summary>
    internal sealed class WMInput : NativeWindow, IInputDriver
    {
        // Driver supports only one keyboard and mouse;
        KeyboardDevice keyboard = new KeyboardDevice();
        MouseDevice mouse = new MouseDevice();
        IList<KeyboardDevice> keyboards = new List<KeyboardDevice>(1);
        IList<MouseDevice> mice = new List<MouseDevice>(1);
        internal static readonly KeyMap KeyMap = new KeyMap();

        #region --- Constructor ---

        public WMInput(IWindowInfo parent)
        {
            Debug.WriteLine("Initalizing WMInput driver.");
            Debug.Indent();

            AssignHandle(parent.Handle);
            Debug.Print("Input window attached to parent {0}", parent);
            
            Debug.Unindent();

            keyboard.Description = "Standard Windows keyboard";
            keyboard.NumberOfFunctionKeys = 12;
            keyboard.NumberOfKeys = 101;
            keyboard.NumberOfLeds = 3;

            mouse.Description = "Standard Windows mouse";
            mouse.NumberOfButtons = 3;
            mouse.NumberOfWheels = 1;

            keyboards.Add(keyboard);
            mice.Add(mouse);
        }

        #endregion

        protected override void WndProc(ref Message msg)
        {
            switch ((WindowMessage)msg.Msg)
            {
                // Mouse events:
                case WindowMessage.MOUSEMOVE:
                //case WindowMessage.NCMOUSEMOVE:
                    mouse.X = msg.LParam.ToInt32() & 0x0000FFFF;
                    mouse.Y = (int)(msg.LParam.ToInt32() & 0xFFFF0000) >> 16;
                    return;

                case WindowMessage.MOUSEWHEEL:
                    mouse.Wheel += (int)(msg.WParam.ToInt32() >> 16) / 120;
                    return;

                case WindowMessage.LBUTTONDOWN:
                    mouse[MouseButton.Left] = true;
                    return;

                case WindowMessage.MBUTTONDOWN:
                    mouse[MouseButton.Middle] = true;
                    return;

                case WindowMessage.RBUTTONDOWN:
                    mouse[MouseButton.Right] = true;
                    return;

                case WindowMessage.XBUTTONDOWN:
                    mouse[((msg.WParam.ToInt32() & 0xFFFF0000) >> 16) != (int)MouseKeys.XButton1 ? MouseButton.Button1 : MouseButton.Button2] = true;
                    return;

                case WindowMessage.LBUTTONUP:
                    mouse[MouseButton.Left] = false;
                    return;

                case WindowMessage.MBUTTONUP:
                    mouse[MouseButton.Middle] = false;
                    return;

                case WindowMessage.RBUTTONUP:
                    mouse[MouseButton.Right] = false;
                    return;

                case WindowMessage.XBUTTONUP:
                    mouse[((msg.WParam.ToInt32() & 0xFFFF0000) >> 16) != (int)MouseKeys.XButton1 ? MouseButton.Button1 : MouseButton.Button2] = false;
                    return;

                // Keyboard events:
                case WindowMessage.KEYDOWN:
                case WindowMessage.KEYUP:
                case WindowMessage.SYSKEYDOWN:
                case WindowMessage.SYSKEYUP:
                    bool pressed = (WindowMessage)msg.Msg == WindowMessage.KEYDOWN ||
                                   (WindowMessage)msg.Msg == WindowMessage.SYSKEYDOWN;
                    switch ((VirtualKeys)msg.WParam)
                    {
                        case VirtualKeys.SHIFT:
                            keyboard[Input.Key.ShiftLeft] = keyboard[Input.Key.ShiftRight] = pressed;
                            return;

                        case VirtualKeys.CONTROL:
                            keyboard[Input.Key.ControlLeft] = keyboard[Input.Key.ControlRight] = pressed;
                            return;

                        case VirtualKeys.MENU:
                            keyboard[Input.Key.AltLeft] = keyboard[Input.Key.AltRight] = pressed;
                            return;

                        default:
                            if (!WMInput.KeyMap.ContainsKey((VirtualKeys)msg.WParam))
                            {
                                Debug.Print("Virtual key {0} ({1}) not mapped.", (VirtualKeys)msg.WParam, (int)msg.WParam);
                                break;
                            }
                            else
                            {
                                keyboard[WMInput.KeyMap[(VirtualKeys)msg.WParam]] = pressed;
                                return;
                            }
                    }
                    break;
            }

            base.WndProc(ref msg);
        }

        #region IInputDriver Members

        public void Poll()
        {
            // No polling needed.
        }

        #endregion

        #region IKeyboardDriver Members

        public IList<KeyboardDevice> Keyboard
        {
            get { return keyboards; }
        }

        #endregion

        #region IMouseDriver Members

        public IList<MouseDevice> Mouse
        {
            get { return mice; }
        }

        #endregion

        #region --- IDisposable Members ---

        private bool disposed;

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
                    this.ReleaseHandle();

                disposed = true;
            }
        }

        ~WMInput()
        {
            Dispose(false);
        }

        #endregion
    }
}
