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
