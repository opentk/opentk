#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing details.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Diagnostics;

using OpenTK.Math;
using OpenTK.Graphics;
using OpenTK.Graphics.Text;
using OpenTK.Platform;

namespace OpenTK.Fonts { }

namespace OpenTK.Graphics
{
    /// <summary>
    /// Provides methods to perform layout and print hardware accelerated text.
    /// </summary>
    public sealed class TextPrinter : ITextPrinter
    {
        #region Fields

        IGlyphRasterizer glyph_rasterizer;
        ITextOutputProvider text_output;
        TextQuality text_quality;

        bool disposed;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a new TextPrinter object.
        /// </summary>
        public TextPrinter()
            : this(null, null, TextQuality.Default) { }

        public TextPrinter(TextQuality quality)
            : this(null, null, quality) { }

        TextPrinter(IGlyphRasterizer rasterizer, ITextOutputProvider output, TextQuality quality)
        {
            glyph_rasterizer = rasterizer;
            text_output = output;
            text_quality = quality;
        }

        #endregion

        #region ITextPrinter Members

        #region Print

        public void Print(string text, Font font, Color color)
        {
            Print(text, font, color, SizeF.Empty, TextPrinterOptions.Default);
        }

        public void Print(string text, Font font, Color color, SizeF size)
        {
            Print(text, font, color, size, TextPrinterOptions.Default);
        }

        public void Print(string text, Font font, Color color, SizeF size, TextPrinterOptions options)
        {
            if (disposed)
                throw new ObjectDisposedException(this.GetType().ToString());

            if (!ValidateParameters(text, font, size))
                return;

            TextOutput.Print(new TextBlock(text, font, options, size), color, Rasterizer);
        }

        #endregion

        #region Measure

        public TextExtents Measure(string text, Font font)
        {
            return Measure(text, font, SizeF.Empty, TextPrinterOptions.Default);
        }

        public TextExtents Measure(string text, Font font, SizeF size)
        {
            return Measure(text, font, size, TextPrinterOptions.Default);
        }

        public TextExtents Measure(string text, Font font, SizeF size, TextPrinterOptions options)
        {
            if (disposed)
                throw new ObjectDisposedException(this.GetType().ToString());

            if (!ValidateParameters(text, font, size))
                return TextExtents.Empty;

            return Rasterizer.MeasureText(new TextBlock(text, font, options, size));
        }

        #endregion

        #region Clear()

        public void Clear()
        {
            if (disposed)
                throw new ObjectDisposedException(this.GetType().ToString());

            TextOutput.Clear();
            Rasterizer.Clear();
        }

        #endregion

        #region Obsolete

        /// <summary>
        /// Sets up OpenGL state for drawing text.
        /// </summary>
        [Obsolete]
        public void Begin()
        {
            if (disposed)
                throw new ObjectDisposedException(this.GetType().ToString());

            GraphicsContext.Assert();

            float[] viewport = new float[4];

            GL.GetFloat(GetPName.Viewport, viewport);

            // Prepare to draw text. We want pixel perfect precision, so we setup a 2D mode,
            // with size equal to the window (in pixels). 
            // While we could also render text in 3D mode, it would be very hard to get
            // pixel-perfect precision.
            GL.MatrixMode(MatrixMode.Projection);
            GL.PushMatrix();
            GL.LoadIdentity();
            GL.Ortho(viewport[0], viewport[2], viewport[3], viewport[1], -1.0, 1.0);

            GL.MatrixMode(MatrixMode.Modelview);
            GL.PushMatrix();
            GL.LoadIdentity();
        }

        /// <summary>
        /// Restores OpenGL state.
        /// </summary>
        [Obsolete]
        public void End()
        {
            if (disposed)
                throw new ObjectDisposedException(this.GetType().ToString());

            GraphicsContext.Assert();

            GL.MatrixMode(MatrixMode.Modelview);
            GL.PopMatrix();

            GL.MatrixMode(MatrixMode.Projection);
            GL.PopMatrix();
        }

        [Obsolete("Use TextPrinter.Print instead")]
        public void Draw(TextHandle handle)
        {
            Print(handle.Text, handle.GdiPFont, Color.White);
        }

        [Obsolete("Use TextPrinter.Print instead")]
        public void Draw(string text, TextureFont font)
        {
            Print(text, font.font, Color.White);
        }

        [Obsolete("Use TextPrinter.Print instead")]
        public void Prepare(string text, TextureFont font, out TextHandle handle)
        {
            handle = new TextHandle(text, font.font);
        }

        #endregion

        #endregion

        #region Private Members

        IGlyphRasterizer Rasterizer
        {
            get
            {
                if (glyph_rasterizer == null)
                    glyph_rasterizer = new GdiPlusGlyphRasterizer();

                return glyph_rasterizer;
            }

        }

        ITextOutputProvider TextOutput
        {
            get
            {
                if (text_output == null)
                    text_output = GL1TextOutputProvider.Create(text_quality);

                return text_output;
            }
        }

        #endregion

        #region Static Members

        static bool ValidateParameters(string text, Font font, SizeF size)
        {
            if (String.IsNullOrEmpty(text))
                return false;
            if (font == null)
                throw new ArgumentNullException("font");
            if (size.Width < 0 || size.Height < 0)
                throw new ArgumentOutOfRangeException("size");

            return true;
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            if (!disposed)
            {
                TextOutput.Dispose();
                disposed = true;
            }
        }

        #endregion
    }
}
