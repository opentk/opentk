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
    /// <summary>
    /// Tests Font loading and rendering.
    /// </summary>
    [Example("Fonts", ExampleCategory.Tutorial, 3)]
    class Fonts : GameWindow
    {
        public Fonts() : base(new DisplayMode(800, 600))
        { }

        #region --- Fields ---

        ITextPrinter printer = new TextPrinter();
        const string text = "Hello, world!";

        TextHandle[] handles;       // Used to cache the strings we want to print.

        // Load some different TextureFont sizes to compare their quality.
        // You'll never need to load that many fonts in your application,
        // 3 or 4 should be more than enough.
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

            new TextureFont(new Font(FontFamily.GenericSerif, 24.0f, FontStyle.Bold)),
            new TextureFont(new Font(FontFamily.GenericSerif, 26.0f)),
            new TextureFont(new Font(FontFamily.GenericSerif, 28.0f)),
            new TextureFont(new Font(FontFamily.GenericSerif, 30.0f)),

            new TextureFont(new Font(FontFamily.GenericSerif, 32.0f, FontStyle.Italic)),
            new TextureFont(new Font(FontFamily.GenericSerif, 34.0f)),
            new TextureFont(new Font(FontFamily.GenericSerif, 36.0f)),
            new TextureFont(new Font(FontFamily.GenericSerif, 38.0f)),

            new TextureFont(new Font(FontFamily.GenericSansSerif, 8.0f)),
            new TextureFont(new Font(FontFamily.GenericSansSerif, 10.0f)),
            new TextureFont(new Font(FontFamily.GenericSansSerif, 12.0f)),
            new TextureFont(new Font(FontFamily.GenericSansSerif, 14.0f)),

            new TextureFont(new Font(FontFamily.GenericSansSerif, 16.0f)),
            new TextureFont(new Font(FontFamily.GenericSansSerif, 18.0f)),
            new TextureFont(new Font(FontFamily.GenericSansSerif, 20.0f)),
            new TextureFont(new Font(FontFamily.GenericSansSerif, 22.0f)),

            new TextureFont(new Font(FontFamily.GenericSansSerif, 24.0f, FontStyle.Bold)),
            new TextureFont(new Font(FontFamily.GenericSansSerif, 26.0f)),
            new TextureFont(new Font(FontFamily.GenericSansSerif, 28.0f)),
            new TextureFont(new Font(FontFamily.GenericSansSerif, 30.0f)),

            new TextureFont(new Font(FontFamily.GenericSansSerif, 32.0f, FontStyle.Italic)),
            new TextureFont(new Font(FontFamily.GenericSansSerif, 34.0f)),
            new TextureFont(new Font(FontFamily.GenericSansSerif, 36.0f)),
            new TextureFont(new Font(FontFamily.GenericSansSerif, 38.0f)),
        };

        #endregion

        #region OnLoad

        /// <summary>
        /// To maintain high rendering performance, we need to cache the text
        /// we wish to draw, for each font we want to draw it with. To achieve
        /// this, we use the TextPrinter.Prepare() method, which returns a
        /// TextHandle - i.e. a handle to the cached text.
        /// <para>
        /// We can use these TextHandles with the TextPrinter.Draw() method
        /// to draw text with very high performance.
        /// </para>
        /// </summary>
        /// <param name="e"></param>
        public override void OnLoad(EventArgs e)
        {
            GL.ClearColor(Color.SteelBlue);

            handles = new TextHandle[fonts.Length];
            for (int i = handles.Length; --i >= 0; )
                printer.Prepare(text, fonts[i], out handles[i]);
        }

        #endregion

        #region OnUnload

        /// <summary>
        /// It is important that we need to call the Dispose() methods to reclaim of
        /// each and every TextHandle and TextureFont to reclaim the unamanged
        /// (OpenGL) resources they are using.
        /// </summary>
        /// <param name="e"></param>
        public override void OnUnload(EventArgs e)
        {
            foreach (TextHandle h in handles)
                h.Dispose();
            foreach (TextureFont f in fonts)
                f.Dispose();
        }

        #endregion

        #region OnResize

        protected override void OnResize(OpenTK.Platform.ResizeEventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
        }

        #endregion

        #region OnUpdateFrame

        public override void OnUpdateFrame(UpdateFrameEventArgs e)
        {
            if (Keyboard[Key.Escape])
                this.Exit();
        }

        #endregion

        #region OnRenderFrame

        /// <summary>
        /// To render pixel-perfect text, we have to setup a 2d display projection
        /// with a width/height that corresponds to our current Viewport.
        /// In OpenGL this can be easily achieved using the GL.Ortho method.
        /// <para>
        /// It is still possible to render text in a 3d projection, but it will
        /// be very hard to achieve pixel-perfect precision.
        /// </para>
        /// <para>
        /// To achieve the highest possible performance, render your 3d scene first.
        /// At the end of the RenderFrame call, setup a 2d projection and render all
        /// text in one go.
        /// </para>
        /// </summary>
        /// <param name="e"></param>
        public override void OnRenderFrame(RenderFrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);

            printer.Begin();

            // Print using the first font.
            for (int i = 0; i < handles.Length / 2; i++)
            {
                printer.Draw(handles[i]);
                GL.Translate(0, fonts[i].Height, 0);
            }

            // Move to the right, and print using the second font.
            float width, height;
            fonts[handles.Length / 2 - 1].MeasureString(text, out width, out height);
            GL.LoadIdentity();
            GL.Translate(width + 32.0f, 0, 0);
            for (int i = handles.Length / 2; i < handles.Length; i++)
            {
                printer.Draw(handles[i]);
                GL.Translate(0, fonts[i].Height, 0);
            }

            printer.End();

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
            using (Fonts example = new Fonts())
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
