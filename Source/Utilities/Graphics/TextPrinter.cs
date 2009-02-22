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
        /// Constructs a new TextPrinter instance.
        /// </summary>
        public TextPrinter()
            : this(null, null, TextQuality.Default) { }

        /// <summary>
        /// Constructs a new TextPrinter instance with the specified TextQuality level.
        /// </summary>
        /// <param name="quality">The desired TextQuality of this TextPrinter.</param>
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

        /// <summary>
        /// Prints text using the specified color and layout options.
        /// </summary>
        /// <param name="text">The System.String to print.</param>
        /// <param name="font">The System.Drawing.Font that will be used to print text.</param>
        /// <param name="color">The System.Drawing.Color that will be used to print text.</param>
        public void Print(string text, Font font, Color color)
        {
            Print(text, font, color, RectangleF.Empty, TextPrinterOptions.Default, TextAlignment.Near, TextDirection.LeftToRight);
        }

        /// <summary>
        /// Prints text using the specified color and layout options.
        /// </summary>
        /// <param name="text">The System.String to print.</param>
        /// <param name="font">The System.Drawing.Font that will be used to print text.</param>
        /// <param name="color">The System.Drawing.Color that will be used to print text.</param>
        /// <param name="rect">The System.Drawing.Rectangle that defines the bounds for text layout.</param>
        public void Print(string text, Font font, Color color, RectangleF rect)
        {
            Print(text, font, color, rect, TextPrinterOptions.Default, TextAlignment.Near, TextDirection.LeftToRight);
        }

        /// <summary>
        /// Prints text using the specified color and layout options.
        /// </summary>
        /// <param name="text">The System.String to print.</param>
        /// <param name="font">The System.Drawing.Font that will be used to print text.</param>
        /// <param name="color">The System.Drawing.Color that will be used to print text.</param>
        /// <param name="rect">The System.Drawing.Rectangle that defines the bounds for text layout.</param>
        /// <param name="options">The OpenTK.Graphics.TextPrinterOptions that will be used to print text.</param>
        public void Print(string text, Font font, Color color, RectangleF rect, TextPrinterOptions options)
        {
            Print(text, font, color, rect, options, TextAlignment.Near, TextDirection.LeftToRight);
        }

        /// <summary>
        /// Prints text using the specified color and layout options.
        /// </summary>
        /// <param name="text">The System.String to print.</param>
        /// <param name="font">The System.Drawing.Font that will be used to print text.</param>
        /// <param name="color">The System.Drawing.Color that will be used to print text.</param>
        /// <param name="rect">The System.Drawing.Rectangle that defines the bounds for text layout.</param>
        /// <param name="options">The OpenTK.Graphics.TextPrinterOptions that will be used to print text.</param>
        /// <param name="alignment">The OpenTK.Graphics.TextAlignment that will be used to print text.</param>
        public void Print(string text, Font font, Color color, RectangleF rect, TextPrinterOptions options, TextAlignment alignment)
        {
            Print(text, font, color, rect, options, alignment, TextDirection.LeftToRight);
        }

        /// <summary>
        /// Prints text using the specified color and layout options.
        /// </summary>
        /// <param name="text">The System.String to print.</param>
        /// <param name="font">The System.Drawing.Font that will be used to print text.</param>
        /// <param name="color">The System.Drawing.Color that will be used to print text.</param>
        /// <param name="rect">The System.Drawing.Rectangle that defines the bounds for text layout.</param>
        /// <param name="options">The OpenTK.Graphics.TextPrinterOptions that will be used to print text.</param>
        /// <param name="alignment">The OpenTK.Graphics.TextAlignment that will be used to print text.</param>
        /// <param name="direction">The OpenTK.Graphics.TextDirection that will be used to print text.</param>
        public void Print(string text, Font font, Color color, RectangleF rect, TextPrinterOptions options, TextAlignment alignment, TextDirection direction)
        {
            if (disposed)
                throw new ObjectDisposedException(this.GetType().ToString());

            if (!ValidateParameters(text, font, rect))
                return;

            TextOutput.Print(new TextBlock(text, font, rect, options, alignment, direction), color, Rasterizer);
        }

        #endregion

        #region Measure

        /// <summary>
        /// Measures text using the specified layout options.
        /// </summary>
        /// <param name="text">The System.String to measure.</param>
        /// <param name="font">The System.Drawing.Font that will be used to measure text.</param>
        /// <returns>An OpenTK.Graphics.TextExtents instance that contains the results of the measurement.</returns>
        public TextExtents Measure(string text, Font font)
        {
            return Measure(text, font, RectangleF.Empty, TextPrinterOptions.Default, TextAlignment.Near, TextDirection.LeftToRight);
        }

        /// <summary>
        /// Measures text using the specified layout options.
        /// </summary>
        /// <param name="text">The System.String to measure.</param>
        /// <param name="font">The System.Drawing.Font that will be used to measure text.</param>
        /// <param name="rect">The System.Drawing.Rectangle that defines the bounds for text layout.</param>
        /// <returns>An OpenTK.Graphics.TextExtents instance that contains the results of the measurement.</returns>
        public TextExtents Measure(string text, Font font, RectangleF rect)
        {
            return Measure(text, font, rect, TextPrinterOptions.Default, TextAlignment.Near, TextDirection.LeftToRight);
        }

        /// <summary>
        /// Measures text using the specified layout options.
        /// </summary>
        /// <param name="text">The System.String to measure.</param>
        /// <param name="font">The System.Drawing.Font that will be used to measure text.</param>
        /// <param name="rect">The System.Drawing.Rectangle that defines the bounds for text layout.</param>
        /// <param name="options">The OpenTK.Graphics.TextPrinterOptions that will be used to measure text.</param>
        /// <returns>An OpenTK.Graphics.TextExtents instance that contains the results of the measurement.</returns>
        public TextExtents Measure(string text, Font font, RectangleF rect, TextPrinterOptions options)
        {
            return Measure(text, font, rect, options, TextAlignment.Near, TextDirection.LeftToRight);
        }

        /// <summary>
        /// Measures text using the specified layout options.
        /// </summary>
        /// <param name="text">The System.String to measure.</param>
        /// <param name="font">The System.Drawing.Font that will be used to measure text.</param>
        /// <param name="rect">The System.Drawing.Rectangle that defines the bounds for text layout.</param>
        /// <param name="options">The OpenTK.Graphics.TextPrinterOptions that will be used to measure text.</param>
        /// <param name="alignment">The OpenTK.Graphics.TextAlignment that will be used to measure text.</param>
        /// <returns>An OpenTK.Graphics.TextExtents instance that contains the results of the measurement.</returns>
        public TextExtents Measure(string text, Font font, RectangleF rect, TextPrinterOptions options, TextAlignment alignment)
        {
            return Measure(text, font, rect, options, alignment, TextDirection.LeftToRight);
        }

        /// <summary>
        /// Measures text using the specified layout options.
        /// </summary>
        /// <param name="text">The System.String to measure.</param>
        /// <param name="font">The System.Drawing.Font that will be used to measure text.</param>
        /// <param name="rect">The System.Drawing.Rectangle that defines the bounds for text layout.</param>
        /// <param name="options">The OpenTK.Graphics.TextPrinterOptions that will be used to measure text.</param>
        /// <param name="alignment">The OpenTK.Graphics.TextAlignment that will be used to measure text.</param>
        /// <param name="direction">The OpenTK.Graphics.TextDirection that will be used to measure text.</param>
        /// <returns>An OpenTK.Graphics.TextExtents instance that contains the results of the measurement.</returns>
        public TextExtents Measure(string text, Font font, RectangleF rect, TextPrinterOptions options, TextAlignment alignment, TextDirection direction)
        {
            if (disposed)
                throw new ObjectDisposedException(this.GetType().ToString());

            if (!ValidateParameters(text, font, rect))
                return TextExtents.Empty;

            return Rasterizer.MeasureText(new TextBlock(text, font, rect, options, alignment, direction));
        }

        #endregion

        #region Clear

        public void Clear()
        {
            if (disposed)
                throw new ObjectDisposedException(this.GetType().ToString());

            TextOutput.Clear();
            Rasterizer.Clear();
        }

        #endregion

        #region Begin

        /// <summary>
        /// Sets up a resolution-dependent orthographic projection.
        /// </summary>
        public void Begin()
        {
            TextOutput.Begin();
        }

        #endregion

        #region Begin

        /// <summary>
        /// Restores the projection and modelview matrices to their previous state.
        /// </summary>
        public void End()
        {
            TextOutput.End();
        }

        #endregion

        #region Obsolete

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

        static bool ValidateParameters(string text, Font font, RectangleF rect)
        {
            if (String.IsNullOrEmpty(text))
                return false;
            if (font == null)
                throw new ArgumentNullException("font");
            if (rect.Width < 0 || rect.Height < 0)
                throw new ArgumentOutOfRangeException("size");

            return true;
        }

        #endregion

        #region IDisposable Members

        /// <summary>
        /// Frees the resources consumed by this TextPrinter object.
        /// </summary>
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
