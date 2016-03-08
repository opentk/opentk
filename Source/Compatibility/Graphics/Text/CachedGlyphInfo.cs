// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace OpenTK.Graphics.Text
{
    [Obsolete]
    struct CachedGlyphInfo
    {
        public readonly Texture2D Texture;
        public readonly RectangleF RectangleNormalized;
        public Rectangle Rectangle
        {
            get
            {
                return new Rectangle(
                    (int)(RectangleNormalized.X * Texture.Width),
                    (int)(RectangleNormalized.Y * Texture.Height),
                    (int)(RectangleNormalized.Width * Texture.Width),
                    (int)(RectangleNormalized.Height * Texture.Height));
            }
        }

        // Rect denotes the absolute position of the glyph in the texture [0, Texture.Width], [0, Texture.Height].
        public CachedGlyphInfo(Texture2D texture, Rectangle rect)
        {
            Texture = texture;
            RectangleNormalized = new RectangleF(
                rect.X / (float)texture.Width,
                rect.Y / (float)texture.Height,
                rect.Width / (float)texture.Width,
                rect.Height / (float)texture.Height);
        }
    }
}
