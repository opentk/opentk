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

namespace Examples.Tests
{
    public partial class S04_Input_Logger : Form, IExample
    {
        InputDriver driver;
        Dictionary<IntPtr, ListBox> keyboardListBoxes = new Dictionary<IntPtr, ListBox>(4);

        public S04_Input_Logger()
        {
            InitializeComponent();

            Application.Idle += new EventHandler(Application_Idle);
        }

        void Application_Idle(object sender, EventArgs e)
        {
            // Update mouse coordinates.
            textBox1.Text = driver.Mouse[ChooseMouse.SelectedIndex].X.ToString();
            textBox2.Text = driver.Mouse[ChooseMouse.SelectedIndex].Y.ToString();
            textBox3.Text = driver.Mouse[ChooseMouse.SelectedIndex].DeltaX.ToString();
            textBox4.Text = driver.Mouse[ChooseMouse.SelectedIndex].DeltaY.ToString();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            WindowInfo info = new WindowInfo(this);
            driver = new InputDriver(info);
            Debug.Print("Keyboard count: {0}", driver.Keyboard.Count);
            Debug.Print("Mouse count: {0}", driver.Mouse.Count);

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
            int i = 0;
            foreach (Mouse m in driver.Mouse)
            {
                ChooseMouse.Items.Add(String.Format("Mouse {0} ({1})", ++i, m.Description));
                m.ButtonDown += LogMouseButtonDown;
                m.ButtonUp += LogMouseButtonUp;
            }
            if (i > 0)
            {
                ChooseMouse.SelectedIndex = 0;
            }

            foreach (OpenTK.Input.Keyboard k in driver.Keyboard)
            {
                k.KeyDown += new KeyDownEvent(LogKeyDown);
                k.KeyUp += new KeyUpEvent(LogKeyUp);
            }
        }

        void LogMouseButtonDown(IMouse sender, MouseButton button)
        {
            Debug.Print("Mouse button down: {0} on device: {1}", button, sender.DeviceID);
            MouseButtons.Items.Add(button);
        }

        void LogMouseButtonUp(IMouse sender, MouseButton button)
        {
            Debug.Print("Mouse button up: {0} on device: {1}", button, sender.DeviceID);
            MouseButtons.Items.Remove(button);
        }

        void LogKeyDown(object sender, Key key)
        {
            Debug.Print("Key down: {0} on device: {1}", key, (sender as Keyboard).DeviceID);
            keyboardListBoxes[(sender as Keyboard).DeviceID].Items.Add(key);
        }

        void LogKeyUp(object sender, Key key)
        {
            Debug.Print("Key up: {0} on device: {1}", key, (sender as Keyboard).DeviceID);
            keyboardListBoxes[(sender as Keyboard).DeviceID].Items.Remove(key);
        }

        #region IExample Members

        public void Launch()
        {
            // Empty
        }

        #endregion
    }
}