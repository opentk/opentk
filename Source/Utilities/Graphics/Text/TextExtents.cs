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
    // Holds layout information about a TextBlock.
    public struct TextExtents
    {
        #region Fields

        RectangleF text_extents;
        List<RectangleF> glyph_extents;

        #endregion

        #region Constructors

        public TextExtents(RectangleF bbox)
            : this(bbox, null)
        {
        }

        public TextExtents(RectangleF bbox, IEnumerable<RectangleF> glyphExtents)
            : this()
        {
            BoundingBox = bbox;

            if (glyphExtents != null)
                AddRange(glyphExtents);
        }

        #endregion

        #region Public Members

        public RectangleF BoundingBox
        {
            get { return text_extents; }
            internal set { text_extents = value; }
        }

        public RectangleF this[int i]
        {
            get { return (GlyphExtents as List<RectangleF>)[i]; }
            internal set { (GlyphExtents as List<RectangleF>)[i] = value; }
        }

        public IEnumerable<RectangleF> GlyphExtents
        {
            get
            {
                if (glyph_extents == null)
                    glyph_extents = new List<RectangleF>();
                return (IEnumerable<RectangleF>)glyph_extents;
            }
        }

        public int Count
        {
            get { return (GlyphExtents as List<RectangleF>).Count; }
        }

        #endregion

        #region Internal Members

        internal void Add(RectangleF glyphExtent)
        {
            (GlyphExtents as List<RectangleF>).Add(glyphExtent);
        }

        internal void AddRange(IEnumerable<RectangleF> glyphExtents)
        {
            (GlyphExtents as List<RectangleF>).AddRange(glyphExtents);
        }

        internal void Clear()
        {
            BoundingBox = RectangleF.Empty;
            (GlyphExtents as List<RectangleF>).Clear();
        }

        #endregion
    }
}
