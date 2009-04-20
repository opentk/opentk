namespace Examples.WinForms
{
    partial class FontRenderingBasic
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
            this.glControl1 = new OpenTK.GLControl();
            this.changeFont = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(0, 40);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(700, 521);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = false;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            this.glControl1.Resize += new System.EventHandler(this.glControl1_Resize);
            // 
            // changeFont
            // 
            this.changeFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeFont.Location = new System.Drawing.Point(568, 10);
            this.changeFont.Name = "changeFont";
            this.changeFont.Size = new System.Drawing.Size(120, 23);
            this.changeFont.TabIndex = 1;
            this.changeFont.Text = "Change Font";
            this.changeFont.UseVisualStyleBackColor = true;
            this.changeFont.Click += new System.EventHandler(this.changeFont_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(550, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "The quick brown fox jumped over the lazy dogs. 0123456789";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FontRendering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 561);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.changeFont);
            this.Controls.Add(this.glControl1);
            this.Name = "FontRendering";
            this.Text = "FontRendering";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.Button changeFont;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FontDialog fontDialog;
    }
}