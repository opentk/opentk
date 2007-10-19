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
                case WindowMessage.MOUSEMOVE:
                    break;

                case WindowMessage.MOUSEWHEEL:
                    break;

                case WindowMessage.KEYDOWN:
                    break;

                case WindowMessage.KEYUP:
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

        #region IDisposable Members

        public void Dispose()
        {
            
        }

        #endregion
    }
}
