#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using OpenTK.Graphics.Text;

namespace OpenTK.Graphics
{
    /// <summary>
    /// Defines the interface for a TextPrinter.
    /// </summary>
    public interface ITextPrinter
    {
        void Begin();
        void End();
        void Print(string text, Font font);
        void Print(string text, Font font, TextPrinterOptions options);
        void Print(string text, Font font, TextPrinterOptions options, RectangleF layoutRectangle);
        TextExtents Measure(string text, Font font);
        TextExtents Measure(string text, Font font, TextPrinterOptions options);
        TextExtents Measure(string text, Font font, TextPrinterOptions options, RectangleF layoutRectangle);
    }
}
