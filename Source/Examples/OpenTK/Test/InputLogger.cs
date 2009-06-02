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

using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace Examples.Tests
{
    [Example("Input Logger", ExampleCategory.OpenTK, "Test", Documentation="InputLogger")]
    public partial class InputLogger : Form
    {
        #region Fields

        Thread thread;
        GameWindow hidden;
        bool start;
        Dictionary<IntPtr, ListBox> keyboardListBoxes = new Dictionary<IntPtr, ListBox>(4);

        #endregion

        #region Constructors

        public InputLogger()
        {
            InitializeComponent();
        }

        #endregion

        #region GameWindow

        void LaunchGameWindow()
        {
            hidden = new GameWindow(320, 240, GraphicsMode.Default, "OpenTK | Hidden input window");
            hidden.Load += hidden_Load;
            hidden.Unload += hidden_Unload;
            hidden.RenderFrame += hidden_RenderFrame;
            hidden.Run(60.0, 0.0);
        }

        void hidden_RenderFrame(object sender, FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
            ((GameWindow)sender).SwapBuffers();
        }

        void hidden_Load(object sender, EventArgs e)
        {
            hidden.VSync = VSyncMode.On;
            start = true;
            GL.ClearColor(Color.Black);
        }

        void hidden_Unload(object sender, EventArgs e)
        {
            this.BeginInvoke(on_hidden_unload, sender, e, this);
        }

        delegate void CloseTrigger(GameWindow sender, EventArgs e, Form f);
        CloseTrigger on_hidden_unload = delegate(GameWindow sender, EventArgs e, Form f) { f.Close(); };

        #endregion

        #region Protected Members

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            thread = new Thread(LaunchGameWindow);
            thread.Start();

            while (!start)
                Thread.Sleep(100);

            keyboardListBoxes.Add(hidden.Keyboard.DeviceID, listBox1);

            // Add available mice to the mouse input logger.
            ChooseMouse.Items.Add(String.Format("Mouse {0} ({1})", 0, hidden.Mouse.Description));
            ChooseMouse.SelectedIndex = 0;

            hidden.Mouse.Move += LogMouseMove;
            hidden.Mouse.WheelChanged += LogMouseWheelChanged;
            hidden.Mouse.ButtonDown += LogMouseButtonDown;
            hidden.Mouse.ButtonUp += LogMouseButtonUp;

            hidden.Keyboard.KeyDown += LogKeyDown;
            hidden.Keyboard.KeyUp += LogKeyUp;

            #region Joysticks

            foreach (JoystickDevice joystick in hidden.Joysticks)
            {
                comboBoxActiveJoystick.Items.Add(joystick.Description);

                joystick.Move += delegate(object sender, JoystickMoveEventArgs args)
                {
                    this.BeginInvoke(ControlLogJoystickMoved, this, sender, args);
                };
                joystick.ButtonDown += delegate(object sender, JoystickButtonEventArgs args)
                {
                    this.BeginInvoke(ControlLogJoystickButtonDown, this, sender, args);
                };
                joystick.ButtonUp += delegate(object sender, JoystickButtonEventArgs args)
                {
                    this.BeginInvoke(ControlLogJoystickButtonUp, this, sender, args);
                };
            }
            if (comboBoxActiveJoystick.Items.Count > 0)
                comboBoxActiveJoystick.SelectedIndex = 0;

            #endregion
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            hidden.Exit();

            while (hidden.Exists)
                Thread.Sleep(100);

            e.Cancel = false;
        }

        #endregion

        #region Private Members

        private void ChooseMouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            MouseButtonsBox.Items.Clear();
        }

        #endregion

        #region Logging Delegates

        #region Mice

        delegate void ControlLogMouseKey(GameWindow input_window, InputLogger control, object sender, MouseButtonEventArgs e);
        ControlLogMouseKey ControlLogMouseKeyDown =
            delegate(GameWindow input_window, InputLogger control, object sender, MouseButtonEventArgs e)
            {
                if ((sender as MouseDevice).DeviceID == input_window.Mouse.DeviceID)
                {
                    control.MouseButtonsBox.Items.Add(e.Button);
                    System.Diagnostics.Debug.Print("Button down: {0}", e.Button);
                }
            };
        ControlLogMouseKey ControlLogMouseKeyUp =
            delegate(GameWindow input_window, InputLogger control, object sender, MouseButtonEventArgs e)
            {
                if ((sender as MouseDevice).DeviceID == input_window.Mouse.DeviceID)
                {
                    control.MouseButtonsBox.Items.Remove(e.Button);
                    System.Diagnostics.Debug.Print("Button up: {0}", e.Button);
                }
            };

        delegate void ControlLogMouseMove(GameWindow input_window, InputLogger control, object sender, MouseMoveEventArgs e);
        ControlLogMouseMove ControlLogMouseMoveChanges =
            delegate(GameWindow input_window, InputLogger control, object sender, MouseMoveEventArgs e)
            {
                control.MouseXText.Text = e.X.ToString();
                control.MouseYText.Text = e.Y.ToString();
            };

        delegate void ControlLogMouseWheel(GameWindow input_window, InputLogger control, object sender, MouseWheelEventArgs e);
        ControlLogMouseWheel ControlLogMouseWheelChanges =
            delegate(GameWindow input_window, InputLogger control, object sender, MouseWheelEventArgs e)
            {
                control.MouseWheelText.Text = e.Value.ToString();
            };

        #endregion

        #region Keyboards

        delegate void ControlLogKeyboard(GameWindow input_window, InputLogger control, OpenTK.Input.KeyboardDevice sender, Key key);
        ControlLogKeyboard ControlLogKeyboardDown =
            delegate(GameWindow input_window, InputLogger control, KeyboardDevice sender, Key key)
            {
                control.keyboardListBoxes[sender.DeviceID].Items.Add(key);
            };
        ControlLogKeyboard ControlLogKeyboardUp =
            delegate(GameWindow input_window, InputLogger control, KeyboardDevice sender, Key key)
            {
                control.keyboardListBoxes[sender.DeviceID].Items.Remove(key);
            };

        #endregion

        #region Joysticks

        delegate void ControlLogJoystickMove(InputLogger control, object sender, JoystickMoveEventArgs e);
        ControlLogJoystickMove ControlLogJoystickMoved =
            delegate(InputLogger control, object sender, JoystickMoveEventArgs e)
            {
                // Yes, there are things such as arrays. Tell that to the visual studio designer!
                switch (e.Axis)
                {
                    case JoystickAxis.Axis0: control.textBoxAxis1.Text = e.Value.ToString(); break;
                    case JoystickAxis.Axis1: control.textBoxAxis2.Text = e.Value.ToString(); break;
                    case JoystickAxis.Axis2: control.textBoxAxis3.Text = e.Value.ToString(); break;
                    case JoystickAxis.Axis3: control.textBoxAxis4.Text = e.Value.ToString(); break;
                    case JoystickAxis.Axis4: control.textBoxAxis5.Text = e.Value.ToString(); break;
                    case JoystickAxis.Axis5: control.textBoxAxis6.Text = e.Value.ToString(); break;
                    case JoystickAxis.Axis6: control.textBoxAxis7.Text = e.Value.ToString(); break;
                    case JoystickAxis.Axis7: control.textBoxAxis8.Text = e.Value.ToString(); break;
                    case JoystickAxis.Axis8: control.textBoxAxis9.Text = e.Value.ToString(); break;
                    case JoystickAxis.Axis9: control.textBoxAxis10.Text = e.Value.ToString(); break;
                }
            };

        delegate void ControlLogJoystickButton(InputLogger control, object sender, JoystickButtonEventArgs e);
        ControlLogJoystickButton ControlLogJoystickButtonDown =
            delegate(InputLogger control, object sender, JoystickButtonEventArgs e)
            {
                if ((sender as JoystickDevice).Description == control.comboBoxActiveJoystick.Text)
                {
                    control.JoystickButtonsBox.Items.Add(e.Button);
                    System.Diagnostics.Debug.Print("Joystick button down: {0}", e.Button);
                }
            };
        ControlLogJoystickButton ControlLogJoystickButtonUp =
            delegate(InputLogger control, object sender, JoystickButtonEventArgs e)
            {
                if ((sender as JoystickDevice).Description == control.comboBoxActiveJoystick.Text)
                {
                    control.JoystickButtonsBox.Items.Remove(e.Button);
                    System.Diagnostics.Debug.Print("Joystick button down: {0}", e.Button);
                }
            };

        #endregion

        #endregion

        #region Input Event Handlers

        void LogMouseMove(object sender, MouseMoveEventArgs e)
        {
            this.BeginInvoke(ControlLogMouseMoveChanges, hidden, this, sender, e);
        }

        void LogMouseWheelChanged(object sender, MouseWheelEventArgs e)
        {
            this.BeginInvoke(ControlLogMouseWheelChanges, hidden, this, sender, e);
        }

        void LogMouseButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.BeginInvoke(ControlLogMouseKeyDown, hidden, this, sender, e);
        }

        void LogMouseButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.BeginInvoke(ControlLogMouseKeyUp, hidden, this, sender, e);
        }

        void LogKeyDown(KeyboardDevice sender, Key key)
        {
            this.BeginInvoke(ControlLogKeyboardDown, hidden, this, sender, key);
        }

        void LogKeyUp(KeyboardDevice sender, Key key)
        {
            this.BeginInvoke(ControlLogKeyboardUp, hidden, this, sender, key);
        }

        #endregion

        #region public static void Main()

        /// <summary>
        /// Entry point of this example.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            using (InputLogger example = new InputLogger())
            {
                // Get the title and category of this example using reflection.
                ExampleAttribute info = ((ExampleAttribute)example.GetType().GetCustomAttributes(false)[0]);
                example.Text = String.Format("OpenTK | {0} {1}: {2}", info.Category, info.Difficulty, info.Title);
                example.ShowDialog();
            }
        }

        #endregion
    }
}
