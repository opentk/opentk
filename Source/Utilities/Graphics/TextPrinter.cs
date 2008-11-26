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

        GlyphCache glyph_cache;
        IGlyphRasterizer glyph_rasterizer;
        ITextOutputProvider text_output;

        float[] viewport = new float[4];

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a new TextPrinter object.
        /// </summary>
        public TextPrinter()
            : this(null, null)
        {
        }

        TextPrinter(IGlyphRasterizer rasterizer, ITextOutputProvider output/*, IGlyphCacheProvider, ITextOutputProvider */)
        {
            if (rasterizer == null)
                rasterizer = new GdiPlusGlyphRasterizer();

            if (output == null)
                output = new GL1TextOutputProvider();

            glyph_rasterizer = rasterizer;
            glyph_cache = new GlyphCache(rasterizer);
            text_output = output;
        }

        #endregion

        #region ITextPrinter Members

        #region public void Begin()

        /// <summary>
        /// Sets up OpenGL state for drawing text.
        /// </summary>
        public void Begin()
        {
            if (GraphicsContext.CurrentContext == null)
                throw new GraphicsContextException("No GraphicsContext is current in the calling thread.");

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

            GL.PushAttrib(AttribMask.TextureBit | AttribMask.EnableBit | AttribMask.ColorBufferBit);

            //GL.TexEnv(TextureEnvTarget.TextureEnv, TextureEnvParameter.TextureEnvMode, (int)TextureEnvMode.Modulate);

            //GL.Enable(EnableCap.ColorMaterial);
            GL.Enable(EnableCap.Texture2D);
            GL.Enable(EnableCap.Blend);
            //GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);  // For grayscale
            GL.BlendFunc(BlendingFactorSrc.One, BlendingFactorDest.OneMinusSrcColor);   // For subpixel
            //GL.BlendFunc(BlendingFactorSrc.ConstantColorExt, BlendingFactorDest.OneMinusSrcColor);   // For subpixel with color


            GL.Disable(EnableCap.DepthTest);
        }

        #endregion

        #region public void End()

        /// <summary>
        /// Restores OpenGL state.
        /// </summary>
        public void End()
        {
            GL.PopAttrib();

            GL.MatrixMode(MatrixMode.Modelview);
            GL.PopMatrix();

            GL.MatrixMode(MatrixMode.Projection);
            GL.PopMatrix();
        }

        #endregion

        #region Print

        public void Print(string text, Font font, Color color)
        {
            Print(text, font, color, RectangleF.Empty, TextPrinterOptions.Default);
        }

        public void Print(string text, Font font, Color color, RectangleF layoutRectangle)
        {
            Print(text, font, color, layoutRectangle, TextPrinterOptions.Default);
        }

        public void Print(string text, Font font, Color color, RectangleF layoutRectangle, TextPrinterOptions options)
        {
            if (String.IsNullOrEmpty(text))
                return;

            if (font == null)
                throw new ArgumentNullException("font");

            text_output.Print(new TextBlock(text, font, options, layoutRectangle.Size), layoutRectangle.Location, color, glyph_rasterizer, glyph_cache);
        }

        #endregion

        #region Measure

        public TextExtents Measure(string text, Font font)
        {
            return Measure(text, font, RectangleF.Empty, TextPrinterOptions.Default);
        }

        public TextExtents Measure(string text, Font font, RectangleF layoutRectangle)
        {
            return Measure(text, font, layoutRectangle, TextPrinterOptions.Default);
        }

        public TextExtents Measure(string text, Font font, RectangleF layoutRectangle, TextPrinterOptions options)
        {
            return glyph_rasterizer.MeasureText(new TextBlock(text, font, options, layoutRectangle.Size), layoutRectangle.Location);
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
    }
}
