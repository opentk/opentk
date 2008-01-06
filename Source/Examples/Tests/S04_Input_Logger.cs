#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using OpenTK;
using OpenTK.Platform;
using OpenTK.Input;
using System.Diagnostics;
using System.Threading;

namespace Examples.Tests
{
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    struct TryMouse
    {
        ushort usFlags;
        ushort usButtonFlags;
        ushort usButtonData;
        uint ulRawButtons;
        int lLastX;
        int lLastY;
        uint ulExtraInformation;
    }

    [Example("Input Logger", ExampleCategory.Test, 4)]
    public partial class S04_Input_Logger : Form
    {
        Thread thread;
        GameWindow hidden;
        bool start;
        Dictionary<IntPtr, ListBox> keyboardListBoxes = new Dictionary<IntPtr, ListBox>(4);

        public S04_Input_Logger()
        {
            //Console.WriteLine(sizeof(TryMouse));
            Console.WriteLine(System.Runtime.InteropServices.Marshal.SizeOf(typeof(TryMouse)));
            InitializeComponent();
        }

        void LaunchGameWindow()
        {
            hidden = new GameWindow(new DisplayMode(30, 30), "OpenTK | Hidden input window");
            hidden.Load += hidden_Load;
            hidden.Unload += hidden_Unload;
            hidden.Run(60.0, 1.0);
        }

        void hidden_Load(GameWindow sender, EventArgs e)
        {
            start = true;
        }

        void hidden_Unload(GameWindow sender, EventArgs e)
        {
            this.BeginInvoke(on_hidden_unload, sender, e, this);
        }

        delegate void CloseTrigger(GameWindow sender, EventArgs e, Form f);
        CloseTrigger on_hidden_unload = delegate(GameWindow sender, EventArgs e, Form f) { f.Close(); };

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            thread = new Thread(LaunchGameWindow);
            thread.Start();

            while (!start)
                Thread.Sleep(100);

            WindowInfo info = new WindowInfo(this);

            keyboardListBoxes.Add(hidden.Keyboard.DeviceID, listBox1);

            // Add available mice to the mouse input logger.
            ChooseMouse.Items.Add(String.Format("Mouse {0} ({1})", 0, hidden.Mouse.Description));
            hidden.Mouse.ButtonDown += LogMouseButtonDown;
            hidden.Mouse.ButtonUp += LogMouseButtonUp;

            hidden.Keyboard.KeyDown += LogKeyDown;
            hidden.Keyboard.KeyUp += LogKeyUp;

            //Application.Idle += new EventHandler(UpdateDevices);
            hidden.UpdateFrame += hidden_UpdateFrame;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            hidden.Exit();
            while (hidden.Exists)
                Thread.Sleep(100);

            e.Cancel = false;
        }

        delegate void ControlLogMouseKey(GameWindow input_window, S04_Input_Logger control, MouseDevice sender, MouseButton button);
        ControlLogMouseKey ControlLogMouseKeyDown =
            delegate(GameWindow input_window, S04_Input_Logger control, MouseDevice sender, MouseButton button)
            {
                if (sender.DeviceID == input_window.Mouse.DeviceID)
                    control.MouseButtonsBox.Items.Add(button);
            };
        ControlLogMouseKey ControlLogMouseKeyUp = 
            delegate(GameWindow input_window, S04_Input_Logger control, MouseDevice sender, MouseButton button)
            {
                if (sender.DeviceID == input_window.Mouse.DeviceID)
                    control.MouseButtonsBox.Items.Remove(button);
            };

        delegate void ControlLogMousePosition(GameWindow input_window, S04_Input_Logger control);
        ControlLogMousePosition ControlLogMousePositionChanges =
            delegate(GameWindow input_window, S04_Input_Logger control)
            {
                // Update mouse coordinates.
                control.MouseXText.Text = input_window.Mouse.X.ToString();
                control.MouseYText.Text = input_window.Mouse.Y.ToString();
                control.MouseDXText.Text = input_window.Mouse.XDelta.ToString();
                control.MouseDYText.Text = input_window.Mouse.YDelta.ToString();
                control.MouseWheelText.Text = input_window.Mouse.Wheel.ToString();
                //System.Drawing.Point p = input_window.PointToClient(input_window.Mouse.Position);
                //System.Drawing.Point p = control.PointToClient(input_window.Mouse.Position);
                //control.MouseXWindow.Text = p.X.ToString();
                //control.MouseYWindow.Text = p.Y.ToString();
                //MouseWheelDelta.Text = driver.Mouse[ChooseMouse.SelectedIndex].WheelDelta.ToString();
            };

        delegate void ControlLogKeyboard(GameWindow input_window, S04_Input_Logger control, OpenTK.Input.KeyboardDevice sender, Key key);
        ControlLogKeyboard ControlLogKeyboardDown =
            delegate(GameWindow input_window, S04_Input_Logger control, KeyboardDevice sender, Key key)
            {
                control.keyboardListBoxes[(sender as KeyboardDevice).DeviceID].Items.Add(key);
            };
        ControlLogKeyboard ControlLogKeyboardUp =
            delegate(GameWindow input_window, S04_Input_Logger control, KeyboardDevice sender, Key key)
            {
                control.keyboardListBoxes[(sender as KeyboardDevice).DeviceID].Items.Remove(key);
            };

        void hidden_UpdateFrame(object sender, UpdateFrameEventArgs e)
        {
            this.BeginInvoke(ControlLogMousePositionChanges, hidden, this);
        }

        void LogMouseButtonDown(MouseDevice sender, MouseButton button)
        {
            this.BeginInvoke(ControlLogMouseKeyDown, hidden, this, sender, button);
        }

        void LogMouseButtonUp(MouseDevice sender, MouseButton button)
        {
            this.BeginInvoke(ControlLogMouseKeyUp, hidden, this, sender, button);
        }

        void LogKeyDown(KeyboardDevice sender, Key key)
        {
            this.BeginInvoke(ControlLogKeyboardDown, hidden, this, sender, key);
        }

        void LogKeyUp(KeyboardDevice sender, Key key)
        {
            this.BeginInvoke(ControlLogKeyboardUp, hidden, this, sender, key);
        }

        private void ChooseMouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            MouseButtonsBox.Items.Clear();
        }

        #region public static void Main()

        /// <summary>
        /// Entry point of this example.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            using (S04_Input_Logger example = new S04_Input_Logger())
            {
                // Get the title and category  of this example using reflection.
                ExampleAttribute info = ((ExampleAttribute)example.GetType().GetCustomAttributes(false)[0]);
                example.Text = String.Format("OpenTK | {0} {1}: {2}", info.Category, info.Difficulty, info.Title);
                example.ShowDialog();
            }
        }

        #endregion
    }
}