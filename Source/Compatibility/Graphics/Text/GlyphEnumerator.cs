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
    class GlyphEnumerator : IEnumerator<Glyph>
    {
        #region Fields

        string text;
        Font font;

        IEnumerator<char> implementation;

        #endregion

        #region Constructors

        public GlyphEnumerator(string text, Font font)
        {
            if (text == null)
                throw new ArgumentNullException("text");

            if (font == null)
                throw new ArgumentNullException("font");

            this.text = text;
            this.font = font;

            implementation = text.GetEnumerator();
        }

        #endregion
        
        #region IEnumerator<Glyph> Members

        public Glyph Current
        {
            get { return new Glyph(implementation.Current, font); }
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            implementation.Dispose();
        }

        #endregion

        #region IEnumerator Members

        object System.Collections.IEnumerator.Current
        {
            get { return new Glyph(implementation.Current, font); }
        }

        public bool MoveNext()
        {
            bool status;
            do
            {
                status = implementation.MoveNext();
            } while (status && (implementation.Current == '\n' || implementation.Current == '\r'));

            return status;
        }

        public void Reset()
        {
            implementation.Reset();
        }

        #endregion
    }
}
