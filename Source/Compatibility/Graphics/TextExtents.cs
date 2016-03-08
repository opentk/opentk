// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace OpenTK.Graphics
{
    /// <summary>
    /// Holds the results of a text measurement.
    /// </summary>
    public class TextExtents : IDisposable
    {
        #region Fields

        protected RectangleF text_extents;
        protected List<RectangleF> glyph_extents = new List<RectangleF>();

        public static readonly TextExtents Empty = new TextExtents();

        #endregion

        #region Constructors

        internal TextExtents()
        {
        }

        #endregion

        #region Public Members

        /// <summary>
        /// Gets the bounding box of the measured text.
        /// </summary>
        public RectangleF BoundingBox
        {
            get { return text_extents; }
            internal set { text_extents = value; }
        }

        /// <summary>
        /// Gets the extents of each glyph in the measured text.
        /// </summary>
        /// <param name="i">The index of the glyph.</param>
        /// <returns>The extents of the specified glyph.</returns>
        public RectangleF this[int i]
        {
            get { return glyph_extents[i]; }
            internal set { glyph_extents[i] = value; }
        }

        /// <summary>
        /// Gets the extents of each glyph in the measured text.
        /// </summary>
        public IEnumerable<RectangleF> GlyphExtents
        {
            get { return (IEnumerable<RectangleF>)glyph_extents; }
        }

        /// <summary>
        /// Gets the number of the measured glyphs.
        /// </summary>
        public int Count
        {
            get { return glyph_extents.Count; }
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

        internal TextExtents Clone()
        {
            TextExtents extents = new TextExtents();
            extents.glyph_extents.AddRange(GlyphExtents);
            extents.BoundingBox = BoundingBox;
            return extents;
        }

        #endregion

        #region IDisposable Members

        /// <summary>
        /// Frees the resources consumed by this TextExtents instance.
        /// </summary>
        public virtual void Dispose()
        {
        }

        #endregion
    }
}
