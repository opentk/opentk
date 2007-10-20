#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

using OpenTK;
using OpenTK.Fonts;
using OpenTK.OpenGL;
using OpenTK.Input;

namespace Examples.Tutorial
{
    class Fonts : GameWindow, IExample
    {
        public Fonts() : base(new DisplayMode(800, 600), String.Format("OpenTK | Tutorial {0}: Fonts", order))
        {
            this.VSync = VSyncMode.On;
        }

        TextureFont serif;

        string[] poem = Resources.Poem.Replace('\r', ' ').Split('\n');
        float scroll_speed;
        float scroll_position;
        float initial_position;
        float warparound_position;
        float current_position;

        public override void OnLoad(EventArgs e)
        {
            GL.Enable(GL.Enums.EnableCap.TEXTURE_2D);
            serif = new TextureFont(new Font(FontFamily.GenericSerif, 24, FontStyle.Regular, GraphicsUnit.Pixel));
            serif.LoadGlyphs("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz,.!?");

            scroll_speed = 4/(float)Height;
            initial_position = -1.0f - 64 / (float)Height;  // 64 pixels below the bottom of the screen;
            warparound_position = 7.0f;
            current_position = initial_position;
        }

        protected override void OnResize(OpenTK.Platform.ResizeEventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
            GL.MatrixMode(GL.Enums.MatrixMode.PROJECTION);
            GL.LoadIdentity();
            GL.Ortho(-1.0, 1.0, -1.0, 1.0, 0.0, 16.0);
        }

        public override void OnUpdateFrame(UpdateFrameEventArgs e)
        {
            if (Keyboard[Key.Space])
                scroll_speed = 0.0f;
            if (Keyboard[Key.Down])
                scroll_speed -= 1 / (float)Height;
            if (Keyboard[Key.Up])
                scroll_speed += 1 / (float)Height;
            if (Keyboard[Key.Escape])
                this.Exit();
        }

        public override void OnRenderFrame(RenderFrameEventArgs e)
        {
            GL.MatrixMode(GL.Enums.MatrixMode.MODELVIEW);
            GL.LoadIdentity();

            // We'll start printing from the lower left corner of the screen. The text
            // will slowly move updwards - the user can control the movement speed with
            // the keyboard arrows and the space bar.
            current_position += scroll_speed * (float)e.ScaleFactor;
            if (current_position > 0.0f && current_position > warparound_position)
                current_position = initial_position;
            else if (current_position < 0.0f && current_position < initial_position)
                current_position = warparound_position;
            scroll_position = ((int)(current_position * (float)Height)) / (float)Height;    // Round to closest pixel.

            GL.Translate(-1.0f, scroll_position, 0.0f);

            GL.Clear(GL.Enums.ClearBufferMask.COLOR_BUFFER_BIT);
            
            float line_spacing = -2.0f * serif.LineSpacing / (float)Height;
            foreach (string line in poem)
            {
                serif.Print(line);
                GL.Translate(0.0f, line_spacing, 0.0f);   // Move to the next line.
            }

            SwapBuffers();
        }


        #region IExample Members

        public void Launch() 
        {
            Run(30.0, 85.0);
        }

        public static readonly int order = 6;

        #endregion
    }
}
