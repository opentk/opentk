#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Drawing;
using System.Diagnostics;

using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace Examples.Tutorial
{
#if false
    /// <summary>
    /// Shows how to render and scroll large amounts of text.
    /// </summary>
    [Example("Font rendering (advanced)", ExampleCategory.OpenTK, "Fonts", 2, Documentation="FontRenderingAdvanced")]
    public class FontRenderingAdvanced : GameWindow
    {
        Font serif = new Font(FontFamily.GenericSerif, 16.0f);
        Font sans = new Font(FontFamily.GenericSansSerif, 18.0f);
        TextPrinter text = new TextPrinter();

 	    string poem = new StreamReader("Data/Poem.txt").ReadToEnd();
        int lines;  // How many lines the poem contains.
        
        float scroll_speed;
        float initial_position;
        float wraparound_position;
        float current_position;

        public FontRenderingAdvanced()
            : base(800, 600)
        { }

        #region OnLoad

        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(Color.MidnightBlue);

            current_position = initial_position;
            scroll_speed = -1.0f;

            // Count the amount of lines in the text, to find out the correct
            // warparound position. We want the text to scroll until the last
            // line moves outside the screen, then warp it around from the
            // other side of the screen.
            foreach (char c in poem)
                if (c == '\n')
                    lines++;

            wraparound_position = -(lines + 1) * serif.Height;
        }

        #endregion

        #region OnUnload

        public override void OnUnload(EventArgs e)
        {
            if (serif != null)
                serif.Dispose();
            if (sans != null)
                sans.Dispose();
        }

        #endregion

        #region OnResize

        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);

            initial_position = Height + serif.Height;   // Start one line below the screen.
            wraparound_position = -(lines + 1) * serif.Height;
        }

        #endregion

        #region OnUpdateFrame

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            if (Keyboard[Key.Space])
                scroll_speed = 0;
            if (Keyboard[Key.Down])
                scroll_speed += 10;
            if (Keyboard[Key.Up])
                scroll_speed -= 10;
            if (Keyboard[Key.Escape])
                this.Exit();
        }

        #endregion

        #region OnRenderFrame

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);

            // We'll start printing from the lower left corner of the screen. The text
            // will slowly move updwards - the user can control the movement speed with
            // the keyboard arrows and the space bar.
            current_position += scroll_speed * (float)e.Time;
            if (scroll_speed > 0.0f && current_position > initial_position)
                current_position = wraparound_position;
            else if (scroll_speed < 0.0f && current_position < wraparound_position)
                current_position = initial_position;

            // TextPrinter.Begin() sets up a 2d orthographic projection, with the x axis
            // moving from 0 to viewport.Width (left to right) and the y axis from
            // 0 to viewport.Height (top to bottom). This is the typical coordinate system
            // used in 2d graphics, and is necessary for achieving pixel-perfect glyph rendering.
            // TextPrinter.End() restores your previous projection/modelview matrices.
            text.Begin();

            // Print FPS counter. Since the counter changes per frame,
            // it shouldn't be cached (TextPrinterOptions.NoCache).
            text.Print((1.0 / e.Time).ToString("F2"), sans, Color.SpringGreen, new RectangleF(0, 0, Width, 0), TextPrinterOptions.NoCache, TextAlignment.Far);

            // Print the actual text.
            GL.Translate(0, current_position, 0);
            text.Print(poem, serif, Color.White, new RectangleF(Width / 2, 0, Width / 2, 0), TextPrinterOptions.Default, TextAlignment.Far);
            text.Print(poem, serif, Color.White, new RectangleF(0, 0, Width / 2, 0));

            text.End();

            SwapBuffers();
        }

        #endregion

        #region public static void Main()

        /// <summary>
        /// Entry point of this example.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            using (FontRenderingAdvanced example = new FontRenderingAdvanced())
            {
                // Get the title and category  of this example using reflection.
                ExampleAttribute info = ((ExampleAttribute)example.GetType().GetCustomAttributes(false)[0]);
                example.Title = String.Format("OpenTK | {0} {1}: {2}", info.Category, info.Difficulty, info.Title);
                example.Run(30.0, 0.0);
            }
        }

        #endregion
    }
#endif
}
