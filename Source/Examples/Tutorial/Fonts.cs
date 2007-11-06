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
using OpenTK.OpenGL.Enums;
using OpenTK.Math;

namespace Examples.Tutorial
{
    class Fonts : GameWindow, IExample
    {
        public Fonts() : base(new DisplayMode(800, 600), String.Format("OpenTK | Tutorial {0}: Fonts", order))
        { }

        ITextPrinter text = new TextPrinter();

        // Load some different TextureFont sizes to compare their quality.
        TextureFont[] fonts = new TextureFont[]
        {
            new TextureFont(new Font(FontFamily.GenericSerif, 8.0f)),
            new TextureFont(new Font(FontFamily.GenericSerif, 10.0f)),
            new TextureFont(new Font(FontFamily.GenericSerif, 12.0f)),
            new TextureFont(new Font(FontFamily.GenericSerif, 14.0f)),

            new TextureFont(new Font(FontFamily.GenericSerif, 16.0f)),
            new TextureFont(new Font(FontFamily.GenericSerif, 18.0f)),
            new TextureFont(new Font(FontFamily.GenericSerif, 20.0f)),
            new TextureFont(new Font(FontFamily.GenericSerif, 22.0f)),

            new TextureFont(new Font(FontFamily.GenericSerif, 24.0f)),
            new TextureFont(new Font(FontFamily.GenericSerif, 26.0f)),
            new TextureFont(new Font(FontFamily.GenericSerif, 28.0f)),
            new TextureFont(new Font(FontFamily.GenericSerif, 30.0f)),

            new TextureFont(new Font(FontFamily.GenericSerif, 32.0f)),
            new TextureFont(new Font(FontFamily.GenericSerif, 34.0f)),
            new TextureFont(new Font(FontFamily.GenericSerif, 36.0f)),
            new TextureFont(new Font(FontFamily.GenericSerif, 38.0f)),
        };
        TextHandle[] handles;       // Used to cache the strings we want to print.

        public override void OnLoad(EventArgs e)
        {
            GL.ClearColor(Color.SteelBlue);

            handles = new TextHandle[fonts.Length];
            for (int i = handles.Length; --i >= 0; )
                text.Prepare("Hello, world!", fonts[i], out handles[i]);
        }

        protected override void OnResize(OpenTK.Platform.ResizeEventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
        }

        public override void OnUpdateFrame(UpdateFrameEventArgs e)
        {
            if (Keyboard[Key.Escape])
                this.Exit();
        }

        public override void OnRenderFrame(RenderFrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(0.0, Width, Height, 0.0, 0.0, 1.0);

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();

            // Font size test:
            for (int i = 0; i < handles.Length; i++)
            {
                text.Draw(handles[i]);
                GL.Translate(0, fonts[i].Height, 0);
            }

            SwapBuffers();
        }


        #region IExample Members

        public static readonly int order = 6;

        public void Launch() 
        {
            Run(30.0, 0.0);
        }

        #endregion
    }
}
