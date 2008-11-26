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
    public class TextExtents : IDisposable
    {
        #region Fields

        protected RectangleF text_extents;
        protected List<RectangleF> glyph_extents = new List<RectangleF>();

        #endregion

        #region Constructors

        internal TextExtents()
        {
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
            get { return glyph_extents[i]; }
            internal set { glyph_extents[i] = value; }
        }

        public IEnumerable<RectangleF> GlyphExtents
        {
            get
            {
                return (IEnumerable<RectangleF>)glyph_extents;
            }
        }

        public int Count
        {
            get { return glyph_extents.Count; }
        }

        public TextExtents Clone()
        {
            TextExtents extents = new TextExtents();
            extents.glyph_extents.AddRange(GlyphExtents);
            extents.BoundingBox = BoundingBox;
            return extents;
        }

        #endregion

        #region Internal Members

        internal void Add(RectangleF glyphExtent)
        {
            glyph_extents.Add(glyphExtent);
        }

        internal void AddRange(IEnumerable<RectangleF> glyphExtents)
        {
            glyph_extents.AddRange(glyphExtents);
        }

        internal void Clear()
        {
            BoundingBox = RectangleF.Empty;
            glyph_extents.Clear();
        }

        #endregion

        #region IDisposable Members

        public virtual void Dispose()
        {
        }

        #endregion
    }
}
