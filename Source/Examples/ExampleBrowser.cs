#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Reflection;
using System.Windows.Forms;
using OpenTK.Examples.Properties;
using System.Threading;

namespace Examples
{
    public partial class ExampleBrowser : Form
    {
        #region Fields

        //PrivateFontCollection font_collection = new PrivateFontCollection();

        bool show_warning = true;

        #endregion

        #region Constructors

        public ExampleBrowser()
        {
            Font = SystemFonts.DialogFont;

            InitializeComponent();
            Icon = Resources.App;

            // Windows 6 (Vista) and higher come with Consolas, a high-quality monospace font. Use that or fallback to
            // the generic monospace font on other systems.
            if (System.Environment.OSVersion.Platform == PlatformID.Win32NT &&
                System.Environment.OSVersion.Version.Major >= 6)
            {
                textBoxOutput.Font = richTextBoxSource.Font = new Font("Consolas", 10.0f, FontStyle.Regular);
            }
            else
            {
                textBoxOutput.Font = richTextBoxSource.Font =
                    new Font(FontFamily.GenericMonospace, 10.0f, FontStyle.Regular);
            }
        }

        #endregion

        #region Protected Members

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Debug.Listeners.Add(new TextBoxTraceListener(textBoxOutput));
            treeViewSamples.TreeViewNodeSorter = new SamplesTreeViewSorter();

            LoadSamplesFromAssembly(Assembly.GetExecutingAssembly());
        }

        protected override void OnShown(EventArgs e)
        {
            if (show_warning)
            {
                //MessageBox.Show("The new Sample Browser is not complete. Please report any issues at http://www.opentk.com/project/issues.",
                //    "Work in Progress", MessageBoxButtons.OK, MessageBoxIcon.Information);
                show_warning = false;
            }
        }

        #endregion

        #region Private Members

        #region Events

        #region TreeView

        private void treeViewSamples_AfterSelect(object sender, TreeViewEventArgs e)
        {
            const string no_docs = "Documentation has not been entered.";
            const string no_source = "Source code has not been entered.";
            
            if (e.Node.Tag != null && !String.IsNullOrEmpty(((ExampleInfo)e.Node.Tag).Attribute.Documentation))
            {
                string docs = (string)Resources.ResourceManager.GetObject(((ExampleInfo)e.Node.Tag).Attribute.Documentation + "Doc");
                string source = (string)Resources.ResourceManager.GetObject(((ExampleInfo)e.Node.Tag).Attribute.Documentation);
                
                if (String.IsNullOrEmpty(docs))
                    richTextBoxDescription.Text = no_docs;
                else
                    richTextBoxDescription.Rtf = docs;
                
                if (String.IsNullOrEmpty(source))
                    richTextBoxSource.Text = no_source;
                else
                    richTextBoxSource.Text = source;
            }
            else
            {
                richTextBoxDescription.Text = no_docs;
                richTextBoxSource.Text = no_source;
            }
        }

        private void treeViewSamples_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                ActivateNode(e.Node);
            }
        }

        private void treeViewSamples_KeyDown(object sender, KeyEventArgs e)
        {
            // The enter key activates a node (either expands/collapses or executes its sample).
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    ActivateNode(treeViewSamples.SelectedNode);
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    break;
            }
        }

        private void treeViewSamples_MouseDown(object sender, MouseEventArgs e)
        {
            // Make sure that right-clicking a new node will select that node before displaying
            // the context menu. Without this, right-clicking a node does not select it, which
            // is completely disorienting.
            // As a bonus, make any mouse button select the underlying node,
            TreeNode node = treeViewSamples.HitTest(e.Location).Node;
            if (node != null)
                treeViewSamples.SelectedNode = node;

            // Middle click selects and activates a node (either expands/collapses or executes its sample).
            // Right button displays the context menu.
            // All other mouse buttons simply select the underlying node.
            switch (e.Button)
            {
                case MouseButtons.Middle:
                    ActivateNode(node);
                    break;

                case MouseButtons.Right:
                    treeViewSamples.ContextMenuStrip.Show(sender as Control, e.Location);
                    break;
            }
        }

        private void treeViewSamples_AfterExpand(object sender, TreeViewEventArgs e)
        {
            foreach (TreeNode child in e.Node.Nodes)
                child.EnsureVisible();
        }

        private void contextMenuStripSamples_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "&Run Sample": RunSample(this, (ExampleInfo)treeViewSamples.SelectedNode.Tag); break;
                case "View Description": tabControlSample.SelectedTab = tabDescription; break;
                case "View Source Code": tabControlSample.SelectedTab = tabSource; break;
            }
        }

        #endregion

        #region Description

        private void richTextBoxDescription_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                richTextBoxDescription.ContextMenuStrip.Show(sender as Control, e.X, e.Y);
            }
        }

        private void contextMenuStripDescription_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "&Copy")
            {
                Clipboard.SetText(richTextBoxDescription.SelectedRtf, TextDataFormat.Rtf);
            }
        }

        #endregion

        #region Source Code

        private void richTextBoxSource_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                richTextBoxSource.ContextMenuStrip.Show(sender as Control, e.X, e.Y);
            }
        }

        private void contextMenuStripSource_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "&Copy")
            {
                Clipboard.SetText(richTextBoxSource.SelectedText, TextDataFormat.Text);
            }
        }

        #endregion

        #endregion

        #region Actions

        void LoadSamplesFromAssembly(Assembly assembly)
        {
            if (assembly == null)
                throw new ArgumentNullException("assembly");

            Type[] types = assembly.GetTypes();
            foreach (Type type in types)
            {
                object[] attributes = type.GetCustomAttributes(false);
                ExampleAttribute example = null;
                foreach (object attr in attributes)
                {
                    if (attr is ExampleAttribute)
                    {
                        example = (ExampleAttribute)attr;

                        if (example.Visible)
                        {
                            // Add this example to the sample TreeView.
                            // First check whether the ExampleCategory exists in the tree (and add it if it doesn't).
                            // Then add the example as a child node on this category.

                            if (!treeViewSamples.Nodes.ContainsKey(example.Category.ToString()))
                            {
                                int category_index = GetImageIndexForSample(imageListSampleCategories, example.Category.ToString(), String.Empty);
                                treeViewSamples.Nodes.Add(example.Category.ToString(), String.Format("{0} samples", example.Category),
                                    category_index, category_index);
                            }

                            int image_index = GetImageIndexForSample(imageListSampleCategories, example.Category.ToString(), example.Subcategory);
                            TreeNode node = new TreeNode(example.Title, image_index, image_index);
                            node.Name = example.Title;
                            node.Tag = new ExampleInfo(type, example);
                            treeViewSamples.Nodes[example.Category.ToString()].Nodes.Add(node);
                        }
                    }
                }
            }

            treeViewSamples.Sort();
        }

        void ActivateNode(TreeNode node)
        {
            if (node == null)
                return;

            if (node.Tag == null)
            {
                if (node.IsExpanded)
                    node.Collapse();
                else
                    node.Expand();
            }
            else
            {
                tabControlSample.SelectedTab = tabPageOutput;
                textBoxOutput.Clear();
                RunSample(node.TreeView.TopLevelControl, (ExampleInfo)node.Tag);
            }
        }

        static int GetImageIndexForSample(ImageList list, string category, string subcategory)
        {
            if (list == null)
                throw new ArgumentNullException("list");

            if (list.Images.ContainsKey(subcategory.ToString() + ".jpg"))
                return list.Images.IndexOfKey(subcategory.ToString() + ".jpg");
            if (list.Images.ContainsKey(category.ToString() + ".jpg"))
                return list.Images.IndexOfKey(category.ToString() + ".jpg");
            if (list.Images.ContainsKey(subcategory.ToString() + ".png"))
                return list.Images.IndexOfKey(subcategory.ToString() + ".png");
            if (list.Images.ContainsKey(category.ToString() + ".png"))
                return list.Images.IndexOfKey(category.ToString() + ".png");

            return 0;
        }

        static void RunSample(Control parent, ExampleInfo e)
        {
            if (e == null)
                return;

            MethodInfo main =
                e.Example.GetMethod("Main", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic) ??
                e.Example.GetMethod("Main", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[] { typeof(object), typeof(object) }, null);
            if (main != null)
            {
                try
                {
                    if (parent != null)
                    {
                        parent.Visible = false;
                        Application.DoEvents();
                    }
                    Trace.WriteLine(String.Format("Launching sample: \"{0}\"", e.Attribute.Title));
                    Trace.WriteLine(String.Empty);

                    Thread thread = new Thread((ThreadStart)delegate { main.Invoke(null, null); });
                    thread.IsBackground = true;
                    thread.Start();
                    thread.Join();
                }
                catch (TargetInvocationException expt)
                {
                    string ex_info;
                    if (expt.InnerException != null)
                        ex_info = expt.InnerException.ToString();
                    else
                        ex_info = expt.ToString();
                    MessageBox.Show(ex_info, "An OpenTK example encountered an error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    Debug.Print(expt.ToString());
                }
                catch (NullReferenceException expt)
                {
                    MessageBox.Show(expt.ToString(), "The Example launcher failed to load the example.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    if (parent != null)
                    {
                        parent.Visible = true;
                        Application.DoEvents();
                    }
                }
            }
            else
            {
                MessageBox.Show("The selected example does not define a Main method", "Entry point not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion

        #endregion
    }
}
