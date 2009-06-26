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
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Examples
{
    class SamplesTreeViewSorter : IComparer<TreeNode>, IComparer
    {
        #region IComparer<TreeNode> Members

        public int Compare(TreeNode x, TreeNode y)
        {
            ExampleInfo x_info = x.Tag as ExampleInfo;
            ExampleInfo y_info = y.Tag as ExampleInfo;
            if (x_info == null || y_info == null)
            {
                return x.Text.CompareTo(y.Text);
            }
            else
            {
                int result = x_info.Attribute.Category.CompareTo(y_info.Attribute.Category);
                if (result == 0)
                    result = x_info.Attribute.Subcategory.CompareTo(y_info.Attribute.Subcategory);
                if (result == 0)
                    result = x_info.Attribute.Difficulty.CompareTo(y_info.Attribute.Difficulty);
                if (result == 0)
                    result = x_info.Attribute.Title.CompareTo(y_info.Attribute.Title);

                return result;
            }
        }

        #endregion

        #region IComparer Members

        public int Compare(object x, object y)
        {
            if (x is TreeNode && y is TreeNode)
                return Compare(x as TreeNode, y as TreeNode);
            else
                return 0;
        }

        #endregion
    }
}
