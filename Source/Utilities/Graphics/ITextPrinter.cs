#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using OpenTK.Graphics.Text;

namespace OpenTK.Graphics
{
    /// <summary>
    /// Defines the interface for a TextPrinter.
    /// </summary>
    public interface ITextPrinter : IDisposable
    {
        #region Print

        /// <summary>
        /// Prints text using the specified color and layout options.
        /// </summary>
        /// <param name="text">The System.String to print.</param>
        /// <param name="font">The System.Drawing.Font that will be used to print text.</param>
        /// <param name="color">The System.Drawing.Color that will be used to print text.</param>
        void Print(string text, Font font, Color color);

        /// <summary>
        /// Prints text using the specified color and layout options.
        /// </summary>
        /// <param name="text">The System.String to print.</param>
        /// <param name="font">The System.Drawing.Font that will be used to print text.</param>
        /// <param name="color">The System.Drawing.Color that will be used to print text.</param>
        /// <param name="rect">The System.Drawing.Rectangle that defines the bounds for text layout.</param>
        void Print(string text, Font font, Color color, RectangleF rect);

        /// <summary>
        /// Prints text using the specified color and layout options.
        /// </summary>
        /// <param name="text">The System.String to print.</param>
        /// <param name="font">The System.Drawing.Font that will be used to print text.</param>
        /// <param name="color">The System.Drawing.Color that will be used to print text.</param>
        /// <param name="rect">The System.Drawing.Rectangle that defines the bounds for text layout.</param>
        /// <param name="options">The OpenTK.Graphics.TextPrinterOptions that will be used to print text.</param>
        void Print(string text, Font font, Color color, RectangleF rect, TextPrinterOptions options);

        /// <summary>
        /// Prints text using the specified color and layout options.
        /// </summary>
        /// <param name="text">The System.String to print.</param>
        /// <param name="font">The System.Drawing.Font that will be used to print text.</param>
        /// <param name="color">The System.Drawing.Color that will be used to print text.</param>
        /// <param name="rect">The System.Drawing.Rectangle that defines the bounds for text layout.</param>
        /// <param name="options">The OpenTK.Graphics.TextPrinterOptions that will be used to print text.</param>
        /// <param name="alignment">The OpenTK.Graphics.TextAlignment that will be used to print text.</param>
        void Print(string text, Font font, Color color, RectangleF rect, TextPrinterOptions options, TextAlignment alignment);

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
        void Print(string text, Font font, Color color, RectangleF rect, TextPrinterOptions options, TextAlignment alignment, TextDirection direction);

        #endregion

        #region Measure

        /// <summary>
        /// Measures text using the specified layout options.
        /// </summary>
        /// <param name="text">The System.String to measure.</param>
        /// <param name="font">The System.Drawing.Font that will be used to measure text.</param>
        /// <returns>An OpenTK.Graphics.TextExtents instance that contains the results of the measurement.</returns>
        TextExtents Measure(string text, Font font);

        /// <summary>
        /// Measures text using the specified layout options.
        /// </summary>
        /// <param name="text">The System.String to measure.</param>
        /// <param name="font">The System.Drawing.Font that will be used to measure text.</param>
        /// <param name="rect">The System.Drawing.Rectangle that defines the bounds for text layout.</param>
        /// <returns>An OpenTK.Graphics.TextExtents instance that contains the results of the measurement.</returns>
        TextExtents Measure(string text, Font font, RectangleF rect);

        /// <summary>
        /// Measures text using the specified layout options.
        /// </summary>
        /// <param name="text">The System.String to measure.</param>
        /// <param name="font">The System.Drawing.Font that will be used to measure text.</param>
        /// <param name="rect">The System.Drawing.Rectangle that defines the bounds for text layout.</param>
        /// <param name="options">The OpenTK.Graphics.TextPrinterOptions that will be used to measure text.</param>
        /// <returns>An OpenTK.Graphics.TextExtents instance that contains the results of the measurement.</returns>
        TextExtents Measure(string text, Font font, RectangleF rect, TextPrinterOptions options);

        /// <summary>
        /// Measures text using the specified layout options.
        /// </summary>
        /// <param name="text">The System.String to measure.</param>
        /// <param name="font">The System.Drawing.Font that will be used to measure text.</param>
        /// <param name="rect">The System.Drawing.Rectangle that defines the bounds for text layout.</param>
        /// <param name="options">The OpenTK.Graphics.TextPrinterOptions that will be used to measure text.</param>
        /// <param name="alignment">The OpenTK.Graphics.TextAlignment that will be used to measure text.</param>
        /// <returns>An OpenTK.Graphics.TextExtents instance that contains the results of the measurement.</returns>
        TextExtents Measure(string text, Font font, RectangleF rect, TextPrinterOptions options, TextAlignment alignment);

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
        TextExtents Measure(string text, Font font, RectangleF rect, TextPrinterOptions options, TextAlignment alignment, TextDirection direction);

        #endregion

        #region Begin

        /// <summary>
        /// Sets up a resolution-dependent orthographic projection.
        /// </summary>
        void Begin();

        #endregion

        /// <summary>
        /// Restores the projection and modelview matrices to their previous state.
        /// </summary>
        #region End

        void End();

        #endregion

        #region Obsolete

        [Obsolete("Use TextPrinter.Print instead")]
        void Draw(TextHandle handle);

        [Obsolete("Use TextPrinter.Print instead")]
        void Draw(string text, TextureFont font);

        [Obsolete("Use TextPrinter.Print instead")]
        void Prepare(string text, TextureFont font, out TextHandle handle);

        #endregion
    }
}
