using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace OpenTK.Fonts
{
    interface ILayoutProvider
    {
        void PerformLayout(string text, IFont font, RectangleF layoutRect, StringAlignment alignment, bool rightToLeft);
    }
}
