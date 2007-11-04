namespace Examples.WinForms
{
    partial class W04_Multiple_GLControls
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
            this.derivedGLControl1 = new Examples.WinForms.DerivedGLControl();
            this.derivedGLControl2 = new Examples.WinForms.DerivedGLControl();
            this.SuspendLayout();
            // 
            // derivedGLControl1
            // 
            this.derivedGLControl1.BackColor = System.Drawing.Color.Black;
            this.derivedGLControl1.ClearColor = System.Drawing.Color.Blue;
            this.derivedGLControl1.Location = new System.Drawing.Point(12, 12);
            this.derivedGLControl1.Name = "derivedGLControl1";
            this.derivedGLControl1.Size = new System.Drawing.Size(300, 225);
            this.derivedGLControl1.TabIndex = 0;
            this.derivedGLControl1.VSync = false;
            // 
            // derivedGLControl2
            // 
            this.derivedGLControl2.BackColor = System.Drawing.Color.Black;
            this.derivedGLControl2.ClearColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.derivedGLControl2.Location = new System.Drawing.Point(319, 13);
            this.derivedGLControl2.Name = "derivedGLControl2";
            this.derivedGLControl2.Size = new System.Drawing.Size(293, 224);
            this.derivedGLControl2.TabIndex = 1;
            this.derivedGLControl2.VSync = false;
            // 
            // W04_Multiple_GLControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 444);
            this.Controls.Add(this.derivedGLControl2);
            this.Controls.Add(this.derivedGLControl1);
            this.Name = "W04_Multiple_GLControls";
            this.Text = "W04_Multiple_GLControls";
            this.ResumeLayout(false);

        }

        #endregion

        private DerivedGLControl derivedGLControl1;
        private DerivedGLControl derivedGLControl2;

    }
}