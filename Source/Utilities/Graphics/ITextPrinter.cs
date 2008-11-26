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
        void Print(string text, Font font, Color color);
        void Print(string text, Font font, Color color, RectangleF layoutRectangle);
        void Print(string text, Font font, Color color, RectangleF layoutRectangle, TextPrinterOptions options);
        TextExtents Measure(string text, Font font);
        TextExtents Measure(string text, Font font, RectangleF layoutRectangle);
        TextExtents Measure(string text, Font font, RectangleF layoutRectangle, TextPrinterOptions options);

        [Obsolete("Use TextPrinter.Print instead")]
        void Draw(TextHandle handle);

        [Obsolete("Use TextPrinter.Print instead")]
        void Draw(string text, TextureFont font);

        [Obsolete("Use TextPrinter.Print instead")]
        void Prepare(string text, TextureFont font, out TextHandle handle);
    }
}
