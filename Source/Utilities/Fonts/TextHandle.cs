#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Graphics
{
    /// <summary>
    /// Represents a handle to cached text.
    /// </summary>
    [Obsolete("Use TextPrinter.Print instead")]
    public class TextHandle : IDisposable
    {
        internal string Text;
        internal System.Drawing.Font GdiPFont;

        /// <summary>
        /// Constructs a new TextHandle,
        /// </summary>
        /// <param name="handle"></param>
        internal TextHandle(int handle)
        {
            Handle = handle;
        }

        internal TextHandle(string text, System.Drawing.Font font)
        {
            Text = text;
            GdiPFont = font;
        }

        private int handle;
        protected TextureFont font;
        protected bool disposed;

        /// <summary>
        /// Gets the handle of the cached text run. Call the OpenTK.Graphics.ITextPrinter.Draw() method
        /// to draw the text represented by this TextHandle.
        /// </summary>
        public int Handle
        {
            get { return handle; }
            protected set { handle = value; }
        }

        /// <summary>
        /// Gets the TextureFont used for this text run.
        /// </summary>
        public TextureFont Font
        {
            get { return font; }
            internal set { font = value; }
        }

        #region public override string ToString()

        /// <summary>
        /// Returns a System.String that represents the current TextHandle.
        /// </summary>
        /// <returns>a System.String that descibes the current TextHandle.</returns>
        public override string ToString()
        {
            return String.Format("TextHandle: {0}", Handle);
        }

        #endregion

        #region --- IDisposable Members ---

        /// <summary>
        /// Frees the resource consumed by the TextHandle.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool manual) { }
        ~TextHandle() { this.Dispose(false); }

        #endregion
    }
}
