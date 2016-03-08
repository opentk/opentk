// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Graphics.Text
{
    class TextBlockComparer : IComparer<TextBlock>
    {
        #region Constructors

        public TextBlockComparer() { }

        #endregion

        #region IComparer<TextBlock> Members

        public int Compare(TextBlock x, TextBlock y)
        {
            return x.UsageCount.CompareTo(y.UsageCount);
        }

        #endregion
    }
}
