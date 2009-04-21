namespace Examples
{
    partial class ExampleBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExampleBrowser));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeViewSamples = new System.Windows.Forms.TreeView();
            this.contextMenuStripSamples = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.runSampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.viewDescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListSampleCategories = new System.Windows.Forms.ImageList(this.components);
            this.tabControlSample = new System.Windows.Forms.TabControl();
            this.tabDescription = new System.Windows.Forms.TabPage();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.contextMenuStripDescription = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabSource = new System.Windows.Forms.TabPage();
            this.richTextBoxSource = new System.Windows.Forms.RichTextBox();
            this.contextMenuStripSource = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageOutput = new System.Windows.Forms.TabPage();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.contextMenuStripOutput = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTipSamples = new System.Windows.Forms.ToolTip(this.components);
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStripSamples.SuspendLayout();
            this.tabControlSample.SuspendLayout();
            this.tabDescription.SuspendLayout();
            this.contextMenuStripDescription.SuspendLayout();
            this.tabSource.SuspendLayout();
            this.contextMenuStripSource.SuspendLayout();
            this.tabPageOutput.SuspendLayout();
            this.contextMenuStripOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeViewSamples);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControlSample);
            this.splitContainer1.Size = new System.Drawing.Size(784, 564);
            this.splitContainer1.SplitterDistance = 261;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeViewSamples
            // 
            this.treeViewSamples.ContextMenuStrip = this.contextMenuStripSamples;
            this.treeViewSamples.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewSamples.FullRowSelect = true;
            this.treeViewSamples.HideSelection = false;
            this.treeViewSamples.HotTracking = true;
            this.treeViewSamples.ImageIndex = 0;
            this.treeViewSamples.ImageList = this.imageListSampleCategories;
            this.treeViewSamples.Indent = 71;
            this.treeViewSamples.Location = new System.Drawing.Point(0, 0);
            this.treeViewSamples.Name = "treeViewSamples";
            this.treeViewSamples.SelectedImageIndex = 0;
            this.treeViewSamples.Size = new System.Drawing.Size(261, 564);
            this.treeViewSamples.TabIndex = 0;
            this.toolTipSamples.SetToolTip(this.treeViewSamples, "Right-click a sample for more options.");
            this.treeViewSamples.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewSamples_NodeMouseDoubleClick);
            this.treeViewSamples.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewSamples_AfterSelect);
            this.treeViewSamples.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeViewSamples_MouseDown);
            this.treeViewSamples.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeViewSamples_KeyDown);
            this.treeViewSamples.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeViewSamples_AfterExpand);
            // 
            // contextMenuStripSamples
            // 
            this.contextMenuStripSamples.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runSampleToolStripMenuItem,
            this.toolStripMenuItem1,
            this.viewDescriptionToolStripMenuItem,
            this.viewSourceToolStripMenuItem});
            this.contextMenuStripSamples.Name = "contextMenuStripSamples";
            this.contextMenuStripSamples.Size = new System.Drawing.Size(170, 76);
            this.contextMenuStripSamples.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripSamples_ItemClicked);
            // 
            // runSampleToolStripMenuItem
            // 
            this.runSampleToolStripMenuItem.Name = "runSampleToolStripMenuItem";
            this.runSampleToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.runSampleToolStripMenuItem.Text = "&Run Sample";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(166, 6);
            // 
            // viewDescriptionToolStripMenuItem
            // 
            this.viewDescriptionToolStripMenuItem.Name = "viewDescriptionToolStripMenuItem";
            this.viewDescriptionToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.viewDescriptionToolStripMenuItem.Text = "View Description";
            // 
            // viewSourceToolStripMenuItem
            // 
            this.viewSourceToolStripMenuItem.Name = "viewSourceToolStripMenuItem";
            this.viewSourceToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.viewSourceToolStripMenuItem.Text = "View Source Code";
            // 
            // imageListSampleCategories
            // 
            this.imageListSampleCategories.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSampleCategories.ImageStream")));
            this.imageListSampleCategories.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSampleCategories.Images.SetKeyName(0, "OpenAL.jpg");
            this.imageListSampleCategories.Images.SetKeyName(1, "OpenGL.jpg");
            this.imageListSampleCategories.Images.SetKeyName(2, "1.1.jpg");
            this.imageListSampleCategories.Images.SetKeyName(3, "1.2.jpg");
            this.imageListSampleCategories.Images.SetKeyName(4, "1.3.jpg");
            this.imageListSampleCategories.Images.SetKeyName(5, "1.4.jpg");
            this.imageListSampleCategories.Images.SetKeyName(6, "1.5.jpg");
            this.imageListSampleCategories.Images.SetKeyName(7, "2.0.jpg");
            this.imageListSampleCategories.Images.SetKeyName(8, "2.1.jpg");
            this.imageListSampleCategories.Images.SetKeyName(9, "3.0.jpg");
            this.imageListSampleCategories.Images.SetKeyName(10, "3.1.jpg");
            this.imageListSampleCategories.Images.SetKeyName(11, "GLSL.jpg");
            this.imageListSampleCategories.Images.SetKeyName(12, "FBO.jpg");
            this.imageListSampleCategories.Images.SetKeyName(13, "EFX.jpg");
            this.imageListSampleCategories.Images.SetKeyName(14, "GameWindow.jpg");
            this.imageListSampleCategories.Images.SetKeyName(15, "GLControl.jpg");
            this.imageListSampleCategories.Images.SetKeyName(16, "Test.jpg");
            this.imageListSampleCategories.Images.SetKeyName(17, "Fonts.jpg");
            this.imageListSampleCategories.Images.SetKeyName(18, "OpenTK.jpg");
            // 
            // tabControlSample
            // 
            this.tabControlSample.Controls.Add(this.tabDescription);
            this.tabControlSample.Controls.Add(this.tabSource);
            this.tabControlSample.Controls.Add(this.tabPageOutput);
            this.tabControlSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSample.Location = new System.Drawing.Point(0, 0);
            this.tabControlSample.Name = "tabControlSample";
            this.tabControlSample.SelectedIndex = 0;
            this.tabControlSample.Size = new System.Drawing.Size(519, 564);
            this.tabControlSample.TabIndex = 0;
            // 
            // tabDescription
            // 
            this.tabDescription.Controls.Add(this.richTextBoxDescription);
            this.tabDescription.Location = new System.Drawing.Point(4, 22);
            this.tabDescription.Name = "tabDescription";
            this.tabDescription.Padding = new System.Windows.Forms.Padding(3);
            this.tabDescription.Size = new System.Drawing.Size(511, 538);
            this.tabDescription.TabIndex = 0;
            this.tabDescription.Text = "Description";
            this.tabDescription.UseVisualStyleBackColor = true;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.richTextBoxDescription.ContextMenuStrip = this.contextMenuStripDescription;
            this.richTextBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxDescription.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.ReadOnly = true;
            this.richTextBoxDescription.Size = new System.Drawing.Size(505, 532);
            this.richTextBoxDescription.TabIndex = 0;
            this.richTextBoxDescription.Text = "";
            this.richTextBoxDescription.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTextBoxDescription_MouseDown);
            // 
            // contextMenuStripDescription
            // 
            this.contextMenuStripDescription.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.contextMenuStripDescription.Name = "contextMenuStripDescription";
            this.contextMenuStripDescription.Size = new System.Drawing.Size(103, 26);
            this.contextMenuStripDescription.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripDescription_ItemClicked);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // tabSource
            // 
            this.tabSource.Controls.Add(this.richTextBoxSource);
            this.tabSource.Location = new System.Drawing.Point(4, 22);
            this.tabSource.Name = "tabSource";
            this.tabSource.Padding = new System.Windows.Forms.Padding(3);
            this.tabSource.Size = new System.Drawing.Size(511, 538);
            this.tabSource.TabIndex = 1;
            this.tabSource.Text = "Source Code";
            this.tabSource.UseVisualStyleBackColor = true;
            // 
            // richTextBoxSource
            // 
            this.richTextBoxSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(242)))), ((int)(((byte)(240)))));
            this.richTextBoxSource.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.richTextBoxSource.ContextMenuStrip = this.contextMenuStripSource;
            this.richTextBoxSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxSource.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxSource.Name = "richTextBoxSource";
            this.richTextBoxSource.ReadOnly = true;
            this.richTextBoxSource.Size = new System.Drawing.Size(505, 532);
            this.richTextBoxSource.TabIndex = 0;
            this.richTextBoxSource.Text = "";
            this.richTextBoxSource.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTextBoxSource_MouseDown);
            // 
            // contextMenuStripSource
            // 
            this.contextMenuStripSource.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem1});
            this.contextMenuStripSource.Name = "contextMenuStripSource";
            this.contextMenuStripSource.Size = new System.Drawing.Size(103, 26);
            this.contextMenuStripSource.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripSource_ItemClicked);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem1.Text = "&Copy";
            // 
            // tabPageOutput
            // 
            this.tabPageOutput.Controls.Add(this.textBoxOutput);
            this.tabPageOutput.Location = new System.Drawing.Point(4, 22);
            this.tabPageOutput.Name = "tabPageOutput";
            this.tabPageOutput.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOutput.Size = new System.Drawing.Size(511, 538);
            this.tabPageOutput.TabIndex = 2;
            this.tabPageOutput.Text = "Output";
            this.tabPageOutput.UseVisualStyleBackColor = true;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(242)))), ((int)(((byte)(240)))));
            this.textBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.textBoxOutput.ContextMenuStrip = this.contextMenuStripOutput;
            this.textBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutput.Location = new System.Drawing.Point(3, 3);
            this.textBoxOutput.MaxLength = 1048576;
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(505, 532);
            this.textBoxOutput.TabIndex = 0;
            // 
            // contextMenuStripOutput
            // 
            this.contextMenuStripOutput.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem2});
            this.contextMenuStripOutput.Name = "contextMenuStripOutput";
            this.contextMenuStripOutput.Size = new System.Drawing.Size(103, 26);
            // 
            // copyToolStripMenuItem2
            // 
            this.copyToolStripMenuItem2.Name = "copyToolStripMenuItem2";
            this.copyToolStripMenuItem2.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem2.Text = "&Copy";
            // 
            // ExampleBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 564);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ExampleBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Open Toolkit Sample Browser";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStripSamples.ResumeLayout(false);
            this.tabControlSample.ResumeLayout(false);
            this.tabDescription.ResumeLayout(false);
            this.contextMenuStripDescription.ResumeLayout(false);
            this.tabSource.ResumeLayout(false);
            this.contextMenuStripSource.ResumeLayout(false);
            this.tabPageOutput.ResumeLayout(false);
            this.tabPageOutput.PerformLayout();
            this.contextMenuStripOutput.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControlSample;
        private System.Windows.Forms.TabPage tabDescription;
        private System.Windows.Forms.TabPage tabSource;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.RichTextBox richTextBoxSource;
        private System.Windows.Forms.TreeView treeViewSamples;
        private System.Windows.Forms.ImageList imageListSampleCategories;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDescription;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSource;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSamples;
        private System.Windows.Forms.ToolStripMenuItem runSampleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewDescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSourceToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTipSamples;
        private System.Windows.Forms.TabPage tabPageOutput;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripOutput;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem2;
    }
}