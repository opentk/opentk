namespace Examples.Windowing
{
    partial class W02_Multiple_GLControls
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.create1 = new System.Windows.Forms.Button();
            this.dispose1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.create2 = new System.Windows.Forms.Button();
            this.dispose2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 131);
            this.panel1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(12, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 130);
            this.panel2.TabIndex = 0;
            // 
            // create1
            // 
            this.create1.Location = new System.Drawing.Point(6, 19);
            this.create1.Name = "create1";
            this.create1.Size = new System.Drawing.Size(63, 23);
            this.create1.TabIndex = 0;
            this.create1.Text = "Create";
            this.create1.UseVisualStyleBackColor = true;
            this.create1.Click += new System.EventHandler(this.create1_Click);
            // 
            // dispose1
            // 
            this.dispose1.Enabled = false;
            this.dispose1.Location = new System.Drawing.Point(6, 48);
            this.dispose1.Name = "dispose1";
            this.dispose1.Size = new System.Drawing.Size(63, 23);
            this.dispose1.TabIndex = 0;
            this.dispose1.Text = "Dispose";
            this.dispose1.UseVisualStyleBackColor = true;
            this.dispose1.Click += new System.EventHandler(this.dispose1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.create1);
            this.groupBox1.Controls.Add(this.dispose1);
            this.groupBox1.Location = new System.Drawing.Point(301, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(75, 77);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Context";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.create2);
            this.groupBox2.Controls.Add(this.dispose2);
            this.groupBox2.Location = new System.Drawing.Point(301, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(75, 77);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Context";
            // 
            // create2
            // 
            this.create2.Location = new System.Drawing.Point(6, 19);
            this.create2.Name = "create2";
            this.create2.Size = new System.Drawing.Size(63, 23);
            this.create2.TabIndex = 0;
            this.create2.Text = "Create";
            this.create2.UseVisualStyleBackColor = true;
            this.create2.Click += new System.EventHandler(this.create2_Click);
            // 
            // dispose2
            // 
            this.dispose2.Enabled = false;
            this.dispose2.Location = new System.Drawing.Point(6, 48);
            this.dispose2.Name = "dispose2";
            this.dispose2.Size = new System.Drawing.Size(63, 23);
            this.dispose2.TabIndex = 0;
            this.dispose2.Text = "Dispose";
            this.dispose2.UseVisualStyleBackColor = true;
            this.dispose2.Click += new System.EventHandler(this.dispose2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Press F1 to toggle FullScreen / Windowed.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 310);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button create1;
        private System.Windows.Forms.Button dispose1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button create2;
        private System.Windows.Forms.Button dispose2;
        private System.Windows.Forms.Label label1;
    }
}

