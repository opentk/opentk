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
    public partial class S04_Input_Logger : Form//, IExample
    {
        Thread thread;
        GameWindow hidden;
        bool start;
        Dictionary<IntPtr, ListBox> keyboardListBoxes = new Dictionary<IntPtr, ListBox>(4);

        public S04_Input_Logger()
        {
            InitializeComponent();

            thread = new Thread(LaunchGameWindow);
            thread.Start();
        }

        void LaunchGameWindow()
        {
            hidden = new GameWindow();
            hidden.Load += hidden_Load;
            hidden.CreateWindow(new DisplayMode(30, 30), "OpenTK | Hidden input window");
            hidden.Run(60.0, 1.0);
        }

        void hidden_Load(object sender, EventArgs e)
        {
            start = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            while (!start)
            {
                Thread.Sleep(100);
            }

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

        void hidden_UpdateFrame(object sender, UpdateFrameEventArgs e)
        {
            //hidden.Poll();

            // Update mouse coordinates.
            MouseXText.Text = hidden.Mouse.X.ToString();
            MouseYText.Text = hidden.Mouse.Y.ToString();
            MouseDXText.Text = hidden.Mouse.XDelta.ToString();
            MouseDYText.Text = hidden.Mouse.YDelta.ToString();
            MouseWheelText.Text = hidden.Mouse.Wheel.ToString();
            //MouseWheelDelta.Text = driver.Mouse[ChooseMouse.SelectedIndex].WheelDelta.ToString();
        }

        void LogMouseButtonDown(MouseDevice sender, MouseButton button)
        {
            //Trace.WriteLine(String.Format("Mouse button down: {0} on device: {1}", button, sender.DeviceID));
            if (sender.DeviceID == hidden.Mouse.DeviceID)
                MouseButtons.Items.Add(button);
        }

        void LogMouseButtonUp(MouseDevice sender, MouseButton button)
        {
            //Trace.WriteLine(String.Format("Mouse button up: {0} on device: {1}", button, sender.DeviceID));
            if (sender.DeviceID == hidden.Mouse.DeviceID)
                MouseButtons.Items.Remove(button);
        }

        void LogKeyDown(KeyboardDevice sender, Key key)
        {
            Trace.WriteLine(String.Format("Key down: {0} on device: {1}", key, (sender as KeyboardDevice).DeviceID));
            keyboardListBoxes[(sender as KeyboardDevice).DeviceID].Items.Add(key);
        }

        void LogKeyUp(KeyboardDevice sender, Key key)
        {
            Trace.WriteLine(String.Format("Key up: {0} on device: {1}", key, (sender as KeyboardDevice).DeviceID));
            keyboardListBoxes[(sender as KeyboardDevice).DeviceID].Items.Remove(key);
        }

        #region IExample Members

        public void Launch()
        {
            // Empty
        }

        #endregion

        private void ChooseMouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            MouseButtons.Items.Clear();
        }
    }
}