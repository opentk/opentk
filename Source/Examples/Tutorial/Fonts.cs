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
using System.IO;

namespace Examples.Tutorial
{
    class Fonts : GameWindow, IExample
    {
        public Fonts() : base(new DisplayMode(800, 600), String.Format("OpenTK | Tutorial {0}: Fonts", order))
        {
            this.VSync = VSyncMode.On;
        }

        TextureFont serif = new TextureFont(new Font(FontFamily.GenericSerif, 16.0f));

        string[] poem = new StreamReader("Data/Poem.txt").ReadToEnd().Replace('\r', ' ').Split('\n');
        float scroll_speed;
        float scroll_position;
        float initial_position;
        float warparound_position;
        float current_position;

        int display_list;

        public override void OnLoad(EventArgs e)
        {
            GL.Enable(GL.Enums.EnableCap.TEXTURE_2D);
            serif.LoadGlyphs("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz,.!?;()\'- ");

            current_position = initial_position;
            scroll_speed = -1.0f;

            display_list = GL.GenLists(1);
            GL.NewList(1, GL.Enums.ListMode.COMPILE);

            GL.PushMatrix();

            GL.MatrixMode(GL.Enums.MatrixMode.PROJECTION);
            GL.LoadIdentity();
            GL.Ortho(0.0, Width, Height, 0.0, 0.0, 1.0);
            GL.MatrixMode(GL.Enums.MatrixMode.MODELVIEW);
            GL.LoadIdentity();
            
            int i = 0, line = 0;
            float x_pos, accum_x_pos = 0.0f;
            foreach (string str in poem)
            {
                GL.Translate(0.0f, serif.LineSpacing * line, 0.0f);
                foreach (char c in str)
                {
                    serif.PrintFast(c);
                    x_pos = serif.MeasureWidth(str.Substring(i++, 1));
                    accum_x_pos += x_pos;

                    GL.Translate((int)(x_pos + 0.5f), 0.0f, 0.0f);
                }
                GL.LoadIdentity();
                i = 0;
                ++line;
            }

            GL.PopMatrix();

            GL.EndList();
        }

        protected override void OnResize(OpenTK.Platform.ResizeEventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);

            initial_position = Height + serif.LineSpacing;
            warparound_position = -(poem.Length + 1) * serif.LineSpacing;
        }

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

        public override void OnRenderFrame(RenderFrameEventArgs e)
        {
            // We'll start printing from the lower left corner of the screen. The text
            // will slowly move updwards - the user can control the movement speed with
            // the keyboard arrows and the space bar.
            current_position += scroll_speed * (float)e.ScaleFactor;
            if (scroll_speed > 0.0f && current_position > initial_position)
                current_position = warparound_position;
            else if (scroll_speed < 0.0f && current_position < warparound_position)
                current_position = initial_position;
            scroll_position = current_position;

            GL.Clear(GL.Enums.ClearBufferMask.COLOR_BUFFER_BIT);

            //GL.Translate(0.0f, scroll_position, 0.0f);
            GL.CallList(display_list);

            SwapBuffers();
        }


        #region IExample Members

        public void Launch() 
        {
            Run(30.0, 0.0);
        }

        public static readonly int order = 6;

        #endregion
    }
}
