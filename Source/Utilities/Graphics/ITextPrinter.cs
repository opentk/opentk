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
    public interface ITextPrinter : IDisposable
    {
        void Begin();
        void End();
        void Print(string text, Font font, Color color);
        void Print(string text, Font font, Color color, SizeF size);
        void Print(string text, Font font, Color color, SizeF size, TextPrinterOptions options);
        TextExtents Measure(string text, Font font);
        TextExtents Measure(string text, Font font, SizeF size);
        TextExtents Measure(string text, Font font, SizeF size, TextPrinterOptions options);

        [Obsolete("Use TextPrinter.Print instead")]
        void Draw(TextHandle handle);

        [Obsolete("Use TextPrinter.Print instead")]
        void Draw(string text, TextureFont font);

        [Obsolete("Use TextPrinter.Print instead")]
        void Prepare(string text, TextureFont font, out TextHandle handle);
    }
}
