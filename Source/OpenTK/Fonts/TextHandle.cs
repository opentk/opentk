#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Fonts
{
    /// <summary>
    /// Represents a handle to cached text.
    /// </summary>
    public class TextHandle : IDisposable
    {
        internal TextHandle(int handle)
        {
            Handle = handle;
        }

        /// <summary>
        /// The handle of the cached text. Call the OpenTK.Fonts.ITextPrinter.Draw() method
        /// to draw the text represented by this TextHandle.
        /// </summary>
        public readonly int Handle;
        internal TextureFont font;
        protected bool disposed;

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
