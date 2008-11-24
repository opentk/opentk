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
