#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;

using System.Drawing;
using System.Drawing.Imaging;

using OpenTK;
using OpenTK.OpenGL;
using OpenTK.Fonts;
using OpenTK.OpenGL.Enums;

namespace Examples.Tutorial
{
    /// <summary>
    /// Demonstrates simple OpenGL Texturing.
    /// </summary>
    public class Textures : GameWindow, IExample
    {
        Bitmap bitmap = new Bitmap("Data\\metal.jpg");
        int texture;
        TextureFont sans = new TextureFont(new Font(FontFamily.GenericSansSerif, 24.0f));

        public Textures() : base(new DisplayMode(800, 600), "OpenTK | Tutorial 5: Texturing") { }

        #region OnLoad

        /// <summary>
        /// Setup OpenGL and load resources here.
        /// </summary>
        /// <param name="e">Not used.</param>
        public override void OnLoad(EventArgs e)
        {
            GL.ClearColor(Color.MidnightBlue);
            GL.Enable(EnableCap.Texture2d);

            GL.Hint(HintTarget.PerspectiveCorrectionHint, HintMode.Nicest);
            
            //bitmap = new OpenTK.Fonts.Renderer().bmp;
            //bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
            GL.GenTextures(1, out texture);
            GL.BindTexture(TextureTarget.Texture2d, texture);
            
            BitmapData data = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            GL.TexImage2D(TextureTarget.Texture2d, 0, PixelInternalFormat.Three, bitmap.Width, bitmap.Height, 0,
                OpenTK.OpenGL.Enums.PixelFormat.Bgr, PixelType.UnsignedByte, data.Scan0);
            
            bitmap.UnlockBits(data);
            
            GL.TexParameter(TextureTarget.Texture2d, TextureParameterName.TextureMinFilter, (int)All.Linear);
            GL.TexParameter(TextureTarget.Texture2d, TextureParameterName.TextureMagFilter, (int)All.Linear);
        }

        #endregion

        #region OnResize

        /// <summary>
        /// Respond to resize events here.
        /// </summary>
        /// <param name="e">Contains information on the new GameWindow size.</param>
        /// <remarks>There is no need to call the base implementation.</remarks>
        protected override void OnResize(OpenTK.Platform.ResizeEventArgs e)
        {
            GL.Viewport(0, 0, e.Width, e.Height);

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-1.0, 1.0, -1.0, 1.0, 0.0, 4.0);
        }

        #endregion

        #region OnUpdateFrame

        /// <summary>
        /// Add your game logic here.
        /// </summary>
        /// <param name="e">Contains timing information.</param>
        /// <remarks>There is no need to call the base implementation.</remarks>
        public override void OnUpdateFrame(UpdateFrameEventArgs e)
        {
            if (Keyboard[OpenTK.Input.Key.Escape])
                this.Exit();
        }

        #endregion

        #region OnRenderFrame

        /// <summary>
        /// Add your game rendering code here.
        /// </summary>
        /// <param name="e">Contains timing information.</param>
        /// <remarks>There is no need to call the base implementation.</remarks>
        public override void OnRenderFrame(RenderFrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);

            GL.LoadIdentity();
            GL.BindTexture(TextureTarget.Texture2d, texture);

            GL.Begin(BeginMode.Quads);

            GL.TexCoord2(0.0f, 1.0f); GL.Vertex2(-0.8f + 0.0375f, -0.8f + 0.0375f);
            GL.TexCoord2(1.0f, 1.0f); GL.Vertex2(0.8f + 0.0375f, -0.8f + 0.0375f);
            GL.TexCoord2(1.0f, 0.0f); GL.Vertex2(0.8f + 0.0375f, 0.8f + 0.0375f);
            GL.TexCoord2(0.0f, 0.0f); GL.Vertex2(-0.8f + 0.0375f, 0.8f + 0.0375f);

            GL.End();

            //sans.
            GL.Scale(2.0f / Width, 2.0f / Height, 1.0f);
            //sans.Print('A');

            SwapBuffers();
        }

        #endregion

        #region IExample Members

        /// <summary>
        /// Only used by the ExampleLauncher application, no need to add a Launch() method in your code.
        /// Add a call to Run() in your Main() function instead.
        /// </summary>
        public void Launch()
        {
            this.Run(10.0, 5.0);
        }

        #endregion

        public static readonly int order = 5;
    }
}
