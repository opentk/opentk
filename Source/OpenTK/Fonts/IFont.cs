#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace OpenTK.Fonts
{
    public interface IFont : IDisposable
    {
        void LoadGlyphs(string glyphs);
        RectangleF FindRectangle(char c);
        float Height { get; }
        SizeF MeasureString(string str);
    }
}
