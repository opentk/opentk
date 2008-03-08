#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace OpenTK.Graphics
{
    /// <summary>
    /// Defines the interface for a TextPrinter.
    /// </summary>
    public interface ITextPrinter
    {
        void Prepare(string text, TextureFont font, out TextHandle handle);
        void Prepare(string text, TextureFont font, out TextHandle handle, float width, bool wordWarp);
        void Prepare(string text, TextureFont font, out TextHandle handle, float width, bool wordWarp, StringAlignment alignment);
        void Prepare(string text, TextureFont font, out TextHandle handle, float width, bool wordWarp, StringAlignment alignment, bool rightToLeft);
        void Draw(TextHandle handle);
        void Draw(string text, TextureFont font);
        void Begin();
        void End();
    }
}
