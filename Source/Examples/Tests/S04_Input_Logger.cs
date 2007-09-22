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
    public partial class S04_Input_Logger : Form, IExample
    {
        InputDriver driver;
        Dictionary<IntPtr, ListBox> keyboardListBoxes = new Dictionary<IntPtr, ListBox>(4);

        public S04_Input_Logger()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            WindowInfo info = new WindowInfo(this);
            driver = new InputDriver(info);
            Trace.WriteLine(String.Format("Keyboard count: {0}", driver.Keyboard.Count));
            Trace.WriteLine(String.Format("Mouse count: {0}", driver.Mouse.Count));

            switch (driver.Keyboard.Count)
            {
                case 0:
                    Debug.Print("No keyboard present, or keyboard driver failed to load");
                    break;

                case 1:
                    keyboardListBoxes.Add(driver.Keyboard[0].DeviceID, listBox1);
                    break;

                case 2:
                    keyboardListBoxes.Add(driver.Keyboard[0].DeviceID, listBox1);
                    keyboardListBoxes.Add(driver.Keyboard[1].DeviceID, listBox2);
                    break;

                case 3:
                    keyboardListBoxes.Add(driver.Keyboard[0].DeviceID, listBox1);
                    keyboardListBoxes.Add(driver.Keyboard[1].DeviceID, listBox2);
                    keyboardListBoxes.Add(driver.Keyboard[2].DeviceID, listBox3);
                    break;

                case 4:
                    keyboardListBoxes.Add(driver.Keyboard[0].DeviceID, listBox1);
                    keyboardListBoxes.Add(driver.Keyboard[1].DeviceID, listBox2);
                    keyboardListBoxes.Add(driver.Keyboard[2].DeviceID, listBox3);
                    keyboardListBoxes.Add(driver.Keyboard[3].DeviceID, listBox4);
                    break;

                default:
                    Debug.Print("Only the first 4 keyboards will be shown in the keyboard logger.");
                    keyboardListBoxes.Add(driver.Keyboard[0].DeviceID, listBox1);
                    keyboardListBoxes.Add(driver.Keyboard[1].DeviceID, listBox2);
                    keyboardListBoxes.Add(driver.Keyboard[2].DeviceID, listBox3);
                    keyboardListBoxes.Add(driver.Keyboard[3].DeviceID, listBox4);
                    break;
            }

            // Add available mice to the mouse input logger.
            if (driver.Mouse.Count > 0)
            {
                int i = 0;
                foreach (Mouse m in driver.Mouse)
                {
                    ChooseMouse.Items.Add(String.Format("Mouse {0} ({1})", ++i, m.Description));
                    m.ButtonDown += LogMouseButtonDown;
                    m.ButtonUp += LogMouseButtonUp;
                }
                ChooseMouse.SelectedIndex = 0;
            }

            foreach (OpenTK.Input.Keyboard k in driver.Keyboard)
            {
                k.KeyDown += new KeyDownEvent(LogKeyDown);
                k.KeyUp += new KeyUpEvent(LogKeyUp);
            }

            Application.Idle += new EventHandler(UpdateDevices);
        }

        void UpdateDevices(object sender, EventArgs e)
        {
            driver.Poll();

            // Update mouse coordinates.
            MouseXText.Text = driver.Mouse[ChooseMouse.SelectedIndex].X.ToString();
            MouseYText.Text = driver.Mouse[ChooseMouse.SelectedIndex].Y.ToString();
            MouseDXText.Text = driver.Mouse[ChooseMouse.SelectedIndex].XDelta.ToString();
            MouseDYText.Text = driver.Mouse[ChooseMouse.SelectedIndex].YDelta.ToString();
            MouseWheelText.Text = driver.Mouse[ChooseMouse.SelectedIndex].Wheel.ToString();
            //MouseWheelDelta.Text = driver.Mouse[ChooseMouse.SelectedIndex].WheelDelta.ToString();
        }

        void LogMouseButtonDown(IMouse sender, MouseButton button)
        {
            //Trace.WriteLine(String.Format("Mouse button down: {0} on device: {1}", button, sender.DeviceID));
            if (sender.DeviceID == driver.Mouse[ChooseMouse.SelectedIndex].DeviceID)
                MouseButtons.Items.Add(button);
        }

        void LogMouseButtonUp(IMouse sender, MouseButton button)
        {
            //Trace.WriteLine(String.Format("Mouse button up: {0} on device: {1}", button, sender.DeviceID));
            if (sender.DeviceID == driver.Mouse[ChooseMouse.SelectedIndex].DeviceID)
                MouseButtons.Items.Remove(button);
        }

        void LogKeyDown(object sender, Key key)
        {
            Trace.WriteLine(String.Format("Key down: {0} on device: {1}", key, (sender as Keyboard).DeviceID));
            keyboardListBoxes[(sender as Keyboard).DeviceID].Items.Add(key);
        }

        void LogKeyUp(object sender, Key key)
        {
            Trace.WriteLine(String.Format("Key up: {0} on device: {1}", key, (sender as Keyboard).DeviceID));
            keyboardListBoxes[(sender as Keyboard).DeviceID].Items.Remove(key);
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