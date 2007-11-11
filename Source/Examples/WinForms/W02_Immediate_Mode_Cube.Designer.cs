namespace Examples.WinForms
{
    partial class W02_Immediate_Mode_Cube
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
            this.glControl = new OpenTK.GLControl();
            this.SuspendLayout();
            // 
            // glControl
            // 
            this.glControl.BackColor = System.Drawing.Color.Black;
            this.glControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glControl.Location = new System.Drawing.Point(0, 0);
            this.glControl.Name = "glControl";
            this.glControl.Size = new System.Drawing.Size(784, 564);
            this.glControl.TabIndex = 0;
            this.glControl.VSync = false;
            this.glControl.Layout += new System.Windows.Forms.LayoutEventHandler(this.glControl_Layout);
            // 
            // W02_Immediate_Mode_Cube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 564);
            this.Controls.Add(this.glControl);
            this.Name = "W02_Immediate_Mode_Cube";
            this.Text = "Cube";
            this.ResumeLayout(false);

        }

        #endregion

        private OpenTK.GLControl glControl;
    }
}