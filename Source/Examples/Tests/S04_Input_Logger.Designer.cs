namespace Examples.Tests
{
    partial class S04_Input_Logger
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
            this.HID = new System.Windows.Forms.TabPage();
            this.ChooseMouse = new System.Windows.Forms.ComboBox();
            this.MouseButtons = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.MouseX = new System.Windows.Forms.Label();
            this.MouseY = new System.Windows.Forms.Label();
            this.MouseDeltaX = new System.Windows.Forms.Label();
            this.MouseDeltaY = new System.Windows.Forms.Label();
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
            this.Mouse.Controls.Add(this.MouseDeltaY);
            this.Mouse.Controls.Add(this.MouseDeltaX);
            this.Mouse.Controls.Add(this.MouseY);
            this.Mouse.Controls.Add(this.MouseX);
            this.Mouse.Controls.Add(this.textBox4);
            this.Mouse.Controls.Add(this.textBox3);
            this.Mouse.Controls.Add(this.textBox2);
            this.Mouse.Controls.Add(this.textBox1);
            this.Mouse.Controls.Add(this.MouseButtons);
            this.Mouse.Controls.Add(this.ChooseMouse);
            this.Mouse.Location = new System.Drawing.Point(4, 22);
            this.Mouse.Name = "Mouse";
            this.Mouse.Padding = new System.Windows.Forms.Padding(3);
            this.Mouse.Size = new System.Drawing.Size(424, 352);
            this.Mouse.TabIndex = 1;
            this.Mouse.Text = "Mouse";
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
            // ChooseMouse
            // 
            this.ChooseMouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseMouse.FormattingEnabled = true;
            this.ChooseMouse.Location = new System.Drawing.Point(7, 7);
            this.ChooseMouse.Name = "ChooseMouse";
            this.ChooseMouse.Size = new System.Drawing.Size(409, 21);
            this.ChooseMouse.TabIndex = 0;
            // 
            // MouseButtons
            // 
            this.MouseButtons.FormattingEnabled = true;
            this.MouseButtons.Location = new System.Drawing.Point(7, 197);
            this.MouseButtons.Name = "MouseButtons";
            this.MouseButtons.Size = new System.Drawing.Size(409, 147);
            this.MouseButtons.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(73, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(66, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(73, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(66, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(73, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(66, 125);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(73, 20);
            this.textBox4.TabIndex = 5;
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
            // MouseY
            // 
            this.MouseY.AutoSize = true;
            this.MouseY.Location = new System.Drawing.Point(4, 78);
            this.MouseY.Name = "MouseY";
            this.MouseY.Size = new System.Drawing.Size(57, 13);
            this.MouseY.TabIndex = 7;
            this.MouseY.Text = "Position Y:";
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
            // MouseDeltaY
            // 
            this.MouseDeltaY.AutoSize = true;
            this.MouseDeltaY.Location = new System.Drawing.Point(4, 132);
            this.MouseDeltaY.Name = "MouseDeltaY";
            this.MouseDeltaY.Size = new System.Drawing.Size(45, 13);
            this.MouseDeltaY.TabIndex = 9;
            this.MouseDeltaY.Text = "Delta Y:";
            // 
            // S04_Input_Logger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 378);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "S04_Input_Logger";
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
        private System.Windows.Forms.ListBox MouseButtons;
        private System.Windows.Forms.Label MouseDeltaY;
        private System.Windows.Forms.Label MouseDeltaX;
        private System.Windows.Forms.Label MouseY;
        private System.Windows.Forms.Label MouseX;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;

    }
}