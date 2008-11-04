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
using OpenTK.Graphics;
using OpenTK.Input;

namespace Examples.Tutorial
{
    /// <summary>
    /// Shows how to render and scroll large amounts of text.
    /// </summary>
    [Example("Text", ExampleCategory.Tutorial, 4)]
    public class Text : GameWindow
    {
        TextureFont serif = new TextureFont(new Font(FontFamily.GenericSerif, 24.0f));
        TextureFont sans = new TextureFont(new Font(FontFamily.GenericSansSerif, 14.0f));
        TextHandle poem_handle;
        ITextPrinter text = new TextPrinter();

 	    string poem = new StreamReader("Data/Poem.txt").ReadToEnd();
        int lines;  // How many lines the poem contains.
        
        float scroll_speed;
        float initial_position;
        float warparound_position;
        float current_position;

        public Text()
            : base(800, 600)
        { }

        #region OnLoad

        public override void OnLoad(EventArgs e)
        {
            GL.ClearColor(Color.SteelBlue);

            current_position = initial_position;
            scroll_speed = -1.0f;
            text.Prepare(poem, serif, out poem_handle);

            // Count the amount of lines in the text, to find out the correct
            // warparound position. We want the text to scroll until the last
            // line moves outside the screen, then warp it around from the
            // other side of the screen.
            foreach (char c in poem)
                if (c == '\n')
                    lines++;

            warparound_position =
                -(lines + 1) * serif.Height;
        }

        #endregion

        #region OnUnload

        public override void OnUnload(EventArgs e)
        {
            if (poem_handle != null) poem_handle.Dispose();
            if (serif != null) serif.Dispose();
        }

        #endregion

        #region OnResize

        protected override void OnResize(OpenTK.Platform.ResizeEventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);

            initial_position = Height + serif.Height;   // Start one line below the screen.

            warparound_position =
                -(lines + 1) * serif.Height;
        }

        #endregion

        #region OnUpdateFrame

        public override void OnUpdateFrame(UpdateFrameEventArgs e)
        {
            if (Keyboard[Key.Space])
                scroll_speed = 0.0f;
            if (Keyboard[Key.Down])
                scroll_speed += 1;
            if (Keyboard[Key.Up])
                scroll_speed -= 1;
            if (Keyboard[Key.Escape])
                this.Exit();
        }

        #endregion

        #region OnRenderFrame

        public override void OnRenderFrame(RenderFrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);

            // We'll start printing from the lower left corner of the screen. The text
            // will slowly move updwards - the user can control the movement speed with
            // the keyboard arrows and the space bar.
            current_position += scroll_speed * (float)e.ScaleFactor;
            if (scroll_speed > 0.0f && current_position > initial_position)
                current_position = warparound_position;
            else if (scroll_speed < 0.0f && current_position < warparound_position)
                current_position = initial_position;

            // TextPrinter.Begin() sets up a 2d orthographic projection, with the x axis
            // moving from 0 to viewport.Width (left to right) and the y axis from
            // 0 to viewport.Height (top to bottom). This is the typical coordinate system
            // used in 2d graphics, and is necessary for achieving pixel-perfect glyph rendering.
            // TextPrinter.End() restores your previous projection/modelview matrices.
            text.Begin();
            GL.Color3(Color.LightBlue);
            text.Draw((1.0 / e.Time).ToString("F2"), sans);
            GL.Translate(0.0f, current_position, 0.0f);
            GL.Color3(Color.White);
            text.Draw(poem_handle);
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
            using (Text example = new Text())
            {
                // Get the title and category  of this example using reflection.
                ExampleAttribute info = ((ExampleAttribute)example.GetType().GetCustomAttributes(false)[0]);
                example.Title = String.Format("OpenTK | {0} {1}: {2}", info.Category, info.Difficulty, info.Title);
                example.Run(30.0, 0.0);
            }
        }

        #endregion
    }
}
