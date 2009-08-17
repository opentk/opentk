#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2008 the Open Toolkit library, except where noted.
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
using System.Drawing;

namespace OpenTK.Graphics.Text
{
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
