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

using OpenTK;
using OpenTK.Fonts;
using OpenTK.OpenGL;
using OpenTK.Input;
using OpenTK.OpenGL.Enums;
using System.Diagnostics;

namespace Examples.Tutorial
{
    /// <summary>
    /// Shows how to render and scroll large amounts of text.
    /// </summary>
    [Example("Text", ExampleCategory.Tutorial, 4)]
    public class Text : GameWindow
    {
        TextureFont serif = new TextureFont(new Font(FontFamily.GenericSerif, 24.0f));
        TextHandle poem_handle;
        ITextPrinter text = new TextPrinter();

        public Text() : base(new DisplayMode(800, 600))
        { }

 	    string poem = new StreamReader("Data/Poem.txt").ReadToEnd();
        int lines;  // How many lines the poem contains.
        
        float scroll_speed;
        float initial_position;
        float warparound_position;
        float current_position;

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
            poem_handle.Dispose();
            serif.Dispose();
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

            // Prepare to draw text. We want pixel perfect precision, so we setup a 2D mode,
            // with size equal to the window (in pixels). 
            // While we could also render text in 3D mode, it would be very hard to get
            // pixel-perfect precision.
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(0.0, Width, Height, 0.0, 0.0, 1.0);

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();

            GL.Translate(0.0f, current_position, 0.0f);
            text.Draw(poem_handle);

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
