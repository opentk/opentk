#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

using OpenTK.Math;

namespace OpenTK.Graphics
{
    /// <summary>
    /// Defines the interface for TextPrinter implementations.
    /// </summary>
    [Obsolete("Use ITextOutputProvider instead")]
    public interface ITextPrinterImplementation
    {
        /// <summary>
        /// Caches a text fragment for future use.
        /// </summary>
        /// <param name="vertices">The vertex array for the text fragment.</param>
        /// <param name="indices">The index array for the text fragment. Please use the indexCount parameter
        /// instead of indices.Count, as the indices array may be larger than necessary for performance reasons.</param>
        /// <param name="indexCount">The actual number of indices in the text fragment.</param>
        /// <returns>A TextHandle that can be used to draw the text fragment.</returns>
        TextHandle Load(Vector2[] vertices, ushort[] indices, int indexCount);

        /// <summary>
        /// Draws the specified cached text fragment.
        /// </summary>
        /// <param name="handle">The TextHandle corresponding to the desired text fragment.</param>
        void Draw(TextHandle handle);

        /// <summary>
        /// Draws a text fragment, without caching.
        /// </summary>
        /// <param name="vertices">The vertex array for the text fragment.</param>
        /// <param name="indices">The index array for the text fragment. Please use the indexCount parameter
        /// instead of indices.Count, as the indices array may be larger than necessary for performance reasons.</param>
        /// <param name="indexCount">The actual number of indices in the text fragment.</param>
        void Draw(Vector2[] vertices, ushort[] indices, int indexCount);
    }
}
