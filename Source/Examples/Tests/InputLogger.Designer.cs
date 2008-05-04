namespace Examples.Tests
{
    partial class InputLogger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Keyboard = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Mouse = new System.Windows.Forms.TabPage();
            this.WindowY = new System.Windows.Forms.Label();
            this.WindowX = new System.Windows.Forms.Label();
            this.MouseYWindow = new System.Windows.Forms.TextBox();
            this.MouseXWindow = new System.Windows.Forms.TextBox();
            this.MouseWheelDelta = new System.Windows.Forms.TextBox();
            this.WheelDelta = new System.Windows.Forms.Label();
            this.MouseWheelText = new System.Windows.Forms.TextBox();
            this.MouseWheelLabel = new System.Windows.Forms.Label();
            this.MouseDeltaY = new System.Windows.Forms.Label();
            this.MouseDeltaX = new System.Windows.Forms.Label();
            this.MouseY = new System.Windows.Forms.Label();
            this.MouseX = new System.Windows.Forms.Label();
            this.MouseDYText = new System.Windows.Forms.TextBox();
            this.MouseDXText = new System.Windows.Forms.TextBox();
            this.MouseYText = new System.Windows.Forms.TextBox();
            this.MouseXText = new System.Windows.Forms.TextBox();
            this.MouseButtonsBox = new System.Windows.Forms.ListBox();
            this.ChooseMouse = new System.Windows.Forms.ComboBox();
            this.HID = new System.Windows.Forms.TabPage();
            this.PollTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl.SuspendLayout();
            this.Keyboard.SuspendLayout();
            this.Mouse.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Keyboard);
            this.tabControl.Controls.Add(this.Mouse);
            this.tabControl.Controls.Add(this.HID);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(432, 378);
            this.tabControl.TabIndex = 0;
            // 
            // Keyboard
            // 
            this.Keyboard.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Keyboard.Controls.Add(this.label4);
            this.Keyboard.Controls.Add(this.label3);
            this.Keyboard.Controls.Add(this.label2);
            this.Keyboard.Controls.Add(this.label1);
            this.Keyboard.Controls.Add(this.listBox4);
            this.Keyboard.Controls.Add(this.listBox3);
            this.Keyboard.Controls.Add(this.listBox2);
            this.Keyboard.Controls.Add(this.listBox1);
            this.Keyboard.Location = new System.Drawing.Point(4, 22);
            this.Keyboard.Name = "Keyboard";
            this.Keyboard.Padding = new System.Windows.Forms.Padding(3);
            this.Keyboard.Size = new System.Drawing.Size(424, 352);
            this.Keyboard.TabIndex = 0;
            this.Keyboard.Text = "Keyboard";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Keyboard 4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Keyboard 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Keyboard 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Keyboard 1";
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(210, 197);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(206, 147);
            this.listBox4.TabIndex = 3;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(9, 197);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(195, 147);
            this.listBox3.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(210, 20);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(206, 147);
            this.listBox2.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(195, 147);
            this.listBox1.TabIndex = 0;
            // 
            // Mouse
            // 
            this.Mouse.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Mouse.Controls.Add(this.WindowY);
            this.Mouse.Controls.Add(this.WindowX);
            this.Mouse.Controls.Add(this.MouseYWindow);
            this.Mouse.Controls.Add(this.MouseXWindow);
            this.Mouse.Controls.Add(this.MouseWheelDelta);
            this.Mouse.Controls.Add(this.WheelDelta);
            this.Mouse.Controls.Add(this.MouseWheelText);
            this.Mouse.Controls.Add(this.MouseWheelLabel);
            this.Mouse.Controls.Add(this.MouseDeltaY);
            this.Mouse.Controls.Add(this.MouseDeltaX);
            this.Mouse.Controls.Add(this.MouseY);
            this.Mouse.Controls.Add(this.MouseX);
            this.Mouse.Controls.Add(this.MouseDYText);
            this.Mouse.Controls.Add(this.MouseDXText);
            this.Mouse.Controls.Add(this.MouseYText);
            this.Mouse.Controls.Add(this.MouseXText);
            this.Mouse.Controls.Add(this.MouseButtonsBox);
            this.Mouse.Controls.Add(this.ChooseMouse);
            this.Mouse.Location = new System.Drawing.Point(4, 22);
            this.Mouse.Name = "Mouse";
            this.Mouse.Padding = new System.Windows.Forms.Padding(3);
            this.Mouse.Size = new System.Drawing.Size(424, 352);
            this.Mouse.TabIndex = 1;
            this.Mouse.Text = "Mouse";
            // 
            // WindowY
            // 
            this.WindowY.AutoSize = true;
            this.WindowY.Location = new System.Drawing.Point(4, 239);
            this.WindowY.Name = "WindowY";
            this.WindowY.Size = new System.Drawing.Size(59, 13);
            this.WindowY.TabIndex = 17;
            this.WindowY.Text = "Window Y:";
            // 
            // WindowX
            // 
            this.WindowX.AutoSize = true;
            this.WindowX.Location = new System.Drawing.Point(4, 212);
            this.WindowX.Name = "WindowX";
            this.WindowX.Size = new System.Drawing.Size(59, 13);
            this.WindowX.TabIndex = 16;
            this.WindowX.Text = "Window X:";
            // 
            // MouseYWindow
            // 
            this.MouseYWindow.Location = new System.Drawing.Point(80, 232);
            this.MouseYWindow.Name = "MouseYWindow";
            this.MouseYWindow.ReadOnly = true;
            this.MouseYWindow.Size = new System.Drawing.Size(73, 20);
            this.MouseYWindow.TabIndex = 15;
            // 
            // MouseXWindow
            // 
            this.MouseXWindow.Location = new System.Drawing.Point(80, 205);
            this.MouseXWindow.Name = "MouseXWindow";
            this.MouseXWindow.ReadOnly = true;
            this.MouseXWindow.Size = new System.Drawing.Size(73, 20);
            this.MouseXWindow.TabIndex = 14;
            // 
            // MouseWheelDelta
            // 
            this.MouseWheelDelta.Location = new System.Drawing.Point(80, 178);
            this.MouseWheelDelta.Name = "MouseWheelDelta";
            this.MouseWheelDelta.ReadOnly = true;
            this.MouseWheelDelta.Size = new System.Drawing.Size(73, 20);
            this.MouseWheelDelta.TabIndex = 13;
            // 
            // WheelDelta
            // 
            this.WheelDelta.AutoSize = true;
            this.WheelDelta.Location = new System.Drawing.Point(4, 185);
            this.WheelDelta.Name = "WheelDelta";
            this.WheelDelta.Size = new System.Drawing.Size(69, 13);
            this.WheelDelta.TabIndex = 12;
            this.WheelDelta.Text = "Wheel Delta:";
            // 
            // MouseWheelText
            // 
            this.MouseWheelText.Location = new System.Drawing.Point(80, 152);
            this.MouseWheelText.Name = "MouseWheelText";
            this.MouseWheelText.ReadOnly = true;
            this.MouseWheelText.Size = new System.Drawing.Size(73, 20);
            this.MouseWheelText.TabIndex = 11;
            // 
            // MouseWheelLabel
            // 
            this.MouseWheelLabel.AutoSize = true;
            this.MouseWheelLabel.Location = new System.Drawing.Point(4, 159);
            this.MouseWheelLabel.Name = "MouseWheelLabel";
            this.MouseWheelLabel.Size = new System.Drawing.Size(41, 13);
            this.MouseWheelLabel.TabIndex = 10;
            this.MouseWheelLabel.Text = "Wheel:";
            // 
            // MouseDeltaY
            // 
            this.MouseDeltaY.AutoSize = true;
            this.MouseDeltaY.Location = new System.Drawing.Point(4, 132);
            this.MouseDeltaY.Name = "MouseDeltaY";
            this.MouseDeltaY.Size = new System.Drawing.Size(45, 13);
            this.MouseDeltaY.TabIndex = 9;
            this.MouseDeltaY.Text = "Delta Y:";
            // 
            // MouseDeltaX
            // 
            this.MouseDeltaX.AutoSize = true;
            this.MouseDeltaX.Location = new System.Drawing.Point(4, 105);
            this.MouseDeltaX.Name = "MouseDeltaX";
            this.MouseDeltaX.Size = new System.Drawing.Size(45, 13);
            this.MouseDeltaX.TabIndex = 8;
            this.MouseDeltaX.Text = "Delta X:";
            // 
            // MouseY
            // 
            this.MouseY.AutoSize = true;
            this.MouseY.Location = new System.Drawing.Point(4, 78);
            this.MouseY.Name = "MouseY";
            this.MouseY.Size = new System.Drawing.Size(57, 13);
            this.MouseY.TabIndex = 7;
            this.MouseY.Text = "Position Y:";
            // 
            // MouseX
            // 
            this.MouseX.AutoSize = true;
            this.MouseX.Location = new System.Drawing.Point(4, 51);
            this.MouseX.Name = "MouseX";
            this.MouseX.Size = new System.Drawing.Size(57, 13);
            this.MouseX.TabIndex = 6;
            this.MouseX.Text = "Position X:";
            // 
            // MouseDYText
            // 
            this.MouseDYText.Location = new System.Drawing.Point(80, 125);
            this.MouseDYText.Name = "MouseDYText";
            this.MouseDYText.ReadOnly = true;
            this.MouseDYText.Size = new System.Drawing.Size(73, 20);
            this.MouseDYText.TabIndex = 5;
            // 
            // MouseDXText
            // 
            this.MouseDXText.Location = new System.Drawing.Point(80, 98);
            this.MouseDXText.Name = "MouseDXText";
            this.MouseDXText.ReadOnly = true;
            this.MouseDXText.Size = new System.Drawing.Size(73, 20);
            this.MouseDXText.TabIndex = 4;
            // 
            // MouseYText
            // 
            this.MouseYText.Location = new System.Drawing.Point(80, 71);
            this.MouseYText.Name = "MouseYText";
            this.MouseYText.ReadOnly = true;
            this.MouseYText.Size = new System.Drawing.Size(73, 20);
            this.MouseYText.TabIndex = 3;
            // 
            // MouseXText
            // 
            this.MouseXText.Location = new System.Drawing.Point(80, 44);
            this.MouseXText.Name = "MouseXText";
            this.MouseXText.ReadOnly = true;
            this.MouseXText.Size = new System.Drawing.Size(73, 20);
            this.MouseXText.TabIndex = 2;
            // 
            // MouseButtonsBox
            // 
            this.MouseButtonsBox.FormattingEnabled = true;
            this.MouseButtonsBox.Location = new System.Drawing.Point(256, 44);
            this.MouseButtonsBox.Name = "MouseButtonsBox";
            this.MouseButtonsBox.Size = new System.Drawing.Size(160, 134);
            this.MouseButtonsBox.TabIndex = 1;
            // 
            // ChooseMouse
            // 
            this.ChooseMouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseMouse.FormattingEnabled = true;
            this.ChooseMouse.Location = new System.Drawing.Point(7, 7);
            this.ChooseMouse.Name = "ChooseMouse";
            this.ChooseMouse.Size = new System.Drawing.Size(409, 21);
            this.ChooseMouse.TabIndex = 0;
            this.ChooseMouse.SelectedIndexChanged += new System.EventHandler(this.ChooseMouse_SelectedIndexChanged);
            // 
            // HID
            // 
            this.HID.Location = new System.Drawing.Point(4, 22);
            this.HID.Name = "HID";
            this.HID.Padding = new System.Windows.Forms.Padding(3);
            this.HID.Size = new System.Drawing.Size(424, 352);
            this.HID.TabIndex = 2;
            this.HID.Text = "HID";
            this.HID.UseVisualStyleBackColor = true;
            // 
            // PollTimer
            // 
            this.PollTimer.Interval = 10;
            // 
            // InputLogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 378);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InputLogger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S04: Input Logger";
            this.tabControl.ResumeLayout(false);
            this.Keyboard.ResumeLayout(false);
            this.Keyboard.PerformLayout();
            this.Mouse.ResumeLayout(false);
            this.Mouse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Keyboard;
        private System.Windows.Forms.TabPage Mouse;
        private System.Windows.Forms.TabPage HID;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ChooseMouse;
        private System.Windows.Forms.ListBox MouseButtonsBox;
        private System.Windows.Forms.Label MouseDeltaY;
        private System.Windows.Forms.Label MouseDeltaX;
        private System.Windows.Forms.Label MouseY;
        private System.Windows.Forms.Label MouseX;
        private System.Windows.Forms.TextBox MouseDYText;
        private System.Windows.Forms.TextBox MouseDXText;
        private System.Windows.Forms.TextBox MouseYText;
        private System.Windows.Forms.TextBox MouseXText;
        private System.Windows.Forms.TextBox MouseWheelText;
        private System.Windows.Forms.Label MouseWheelLabel;
        private System.Windows.Forms.TextBox MouseWheelDelta;
        private System.Windows.Forms.Label WheelDelta;
        private System.Windows.Forms.Timer PollTimer;
        private System.Windows.Forms.TextBox MouseXWindow;
        private System.Windows.Forms.Label WindowY;
        private System.Windows.Forms.Label WindowX;
        private System.Windows.Forms.TextBox MouseYWindow;

    }
}