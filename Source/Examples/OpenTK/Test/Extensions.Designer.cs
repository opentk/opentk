namespace Examples.WinForms
{
    partial class Extensions
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LabelVendor = new System.Windows.Forms.Label();
            this.LabelRenderer = new System.Windows.Forms.Label();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.TextBoxVendor = new System.Windows.Forms.TextBox();
            this.TextBoxRenderer = new System.Windows.Forms.TextBox();
            this.TextBoxVersion = new System.Windows.Forms.TextBox();
            this.LabelSupport = new System.Windows.Forms.Label();
            this.TextBoxSupport = new System.Windows.Forms.TextBox();
            this.SupportedColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExtensionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnmanagedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupportedColumn,
            this.NameColumn,
            this.CategoryColumn,
            this.Version,
            this.ExtensionColumn,
            this.UnmanagedName});
            this.dataGridView1.Location = new System.Drawing.Point(0, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(939, 397);
            this.dataGridView1.TabIndex = 1;
            // 
            // LabelVendor
            // 
            this.LabelVendor.AutoSize = true;
            this.LabelVendor.Location = new System.Drawing.Point(12, 9);
            this.LabelVendor.Name = "LabelVendor";
            this.LabelVendor.Size = new System.Drawing.Size(41, 13);
            this.LabelVendor.TabIndex = 2;
            this.LabelVendor.Text = "Vendor";
            // 
            // LabelRenderer
            // 
            this.LabelRenderer.AutoSize = true;
            this.LabelRenderer.Location = new System.Drawing.Point(12, 35);
            this.LabelRenderer.Name = "LabelRenderer";
            this.LabelRenderer.Size = new System.Drawing.Size(51, 13);
            this.LabelRenderer.TabIndex = 3;
            this.LabelRenderer.Text = "Renderer";
            // 
            // LabelVersion
            // 
            this.LabelVersion.AutoSize = true;
            this.LabelVersion.Location = new System.Drawing.Point(12, 61);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(42, 13);
            this.LabelVersion.TabIndex = 4;
            this.LabelVersion.Text = "Version";
            // 
            // TextBoxVendor
            // 
            this.TextBoxVendor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxVendor.Location = new System.Drawing.Point(70, 6);
            this.TextBoxVendor.Name = "TextBoxVendor";
            this.TextBoxVendor.ReadOnly = true;
            this.TextBoxVendor.Size = new System.Drawing.Size(856, 20);
            this.TextBoxVendor.TabIndex = 5;
            // 
            // TextBoxRenderer
            // 
            this.TextBoxRenderer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxRenderer.Location = new System.Drawing.Point(70, 32);
            this.TextBoxRenderer.Name = "TextBoxRenderer";
            this.TextBoxRenderer.ReadOnly = true;
            this.TextBoxRenderer.Size = new System.Drawing.Size(856, 20);
            this.TextBoxRenderer.TabIndex = 6;
            // 
            // TextBoxVersion
            // 
            this.TextBoxVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxVersion.Location = new System.Drawing.Point(70, 58);
            this.TextBoxVersion.Name = "TextBoxVersion";
            this.TextBoxVersion.ReadOnly = true;
            this.TextBoxVersion.Size = new System.Drawing.Size(856, 20);
            this.TextBoxVersion.TabIndex = 7;
            // 
            // LabelSupport
            // 
            this.LabelSupport.AutoSize = true;
            this.LabelSupport.Location = new System.Drawing.Point(12, 87);
            this.LabelSupport.Name = "LabelSupport";
            this.LabelSupport.Size = new System.Drawing.Size(44, 13);
            this.LabelSupport.TabIndex = 8;
            this.LabelSupport.Text = "Support";
            // 
            // TextBoxSupport
            // 
            this.TextBoxSupport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSupport.Location = new System.Drawing.Point(70, 84);
            this.TextBoxSupport.Name = "TextBoxSupport";
            this.TextBoxSupport.ReadOnly = true;
            this.TextBoxSupport.Size = new System.Drawing.Size(856, 20);
            this.TextBoxSupport.TabIndex = 9;
            // 
            // SupportedColumn
            // 
            this.SupportedColumn.HeaderText = "";
            this.SupportedColumn.Name = "SupportedColumn";
            this.SupportedColumn.ReadOnly = true;
            this.SupportedColumn.Width = 24;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 852;
            // 
            // CategoryColumn
            // 
            this.CategoryColumn.HeaderText = "Category";
            this.CategoryColumn.Name = "CategoryColumn";
            this.CategoryColumn.ReadOnly = true;
            this.CategoryColumn.Width = 5;
            // 
            // Version
            // 
            this.Version.HeaderText = "Introduced";
            this.Version.Name = "Version";
            this.Version.ReadOnly = true;
            this.Version.Width = 5;
            // 
            // ExtensionColumn
            // 
            this.ExtensionColumn.HeaderText = "Extension";
            this.ExtensionColumn.Name = "ExtensionColumn";
            this.ExtensionColumn.ReadOnly = true;
            this.ExtensionColumn.Width = 5;
            // 
            // UnmanagedName
            // 
            this.UnmanagedName.HeaderText = "Unmanaged Name";
            this.UnmanagedName.Name = "UnmanagedName";
            this.UnmanagedName.ReadOnly = true;
            this.UnmanagedName.Width = 5;
            // 
            // Extensions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(938, 508);
            this.Controls.Add(this.TextBoxSupport);
            this.Controls.Add(this.LabelSupport);
            this.Controls.Add(this.TextBoxVersion);
            this.Controls.Add(this.TextBoxRenderer);
            this.Controls.Add(this.TextBoxVendor);
            this.Controls.Add(this.LabelVersion);
            this.Controls.Add(this.LabelRenderer);
            this.Controls.Add(this.LabelVendor);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Extensions";
            this.Text = "W03_Extensions";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LabelVendor;
        private System.Windows.Forms.Label LabelRenderer;
        private System.Windows.Forms.Label LabelVersion;
        private System.Windows.Forms.TextBox TextBoxVendor;
        private System.Windows.Forms.TextBox TextBoxRenderer;
        private System.Windows.Forms.TextBox TextBoxVersion;
        private System.Windows.Forms.Label LabelSupport;
        private System.Windows.Forms.TextBox TextBoxSupport;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SupportedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Version;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtensionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnmanagedName;
    }
}