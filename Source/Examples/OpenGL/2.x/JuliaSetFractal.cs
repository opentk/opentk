#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 * 
 * Written by Christoph Brandtner
 */
#endregion

using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace Examples.Tutorial
{
    /// <summary>
    /// Demonstrates how to render an animated Julia Set in real-time. Quality is sacrificed for speed.
    /// Info about the fractal: http://en.wikipedia.org/wiki/Julia_set
    /// One more major optimization could be applied (exploit the symmetry of the image with RTT), but
    /// that would make the program alot more complicated to follow. You can do this as an exercise.
    /// </summary>
    [Example("Julia Set Fractal", ExampleCategory.OpenGL, "2.x", Documentation = "JuliaSetFractal")]
    public class JuliaSetFractal : GameWindow
    {
        public JuliaSetFractal()
            : base(512, 512)
        {
        }

        #region Private Fields

        // GLSL Objects
        int VertexShaderObject, FragmentShaderObject, ProgramObject;
        int TextureObject;

        // Julia Variables for animation
        float AnimOffsetX = 0.213f; // using non-zero as starting point to make it more interesting
        float AnimOffsetY = 0.63f;

        const double AnimSpeedX = 0.65; // anim speed scaling is solely used to make the anim more interesting
        const double AnimSpeedY = 1.05;
        const double AnimCosinusPercent = 0.85f; // scales the cosinus down to 85% to avoid the (boring) borders

        float UniformScaleFactorX; // fractal horizontal scaling is only affected by window resize
        float UniformScaleFactorY; // fractal vertical scaling is only affected by window resize
        float UniformOffsetX = 1.8f; // fractal horizontal offset
        float UniformOffsetY = 1.8f; // fractal vertical offset

        #endregion private Fields

        #region OnLoad

        /// <summary>
        /// Setup OpenGL and load resources here.
        /// </summary>
        /// <param name="e">Not used.</param>
        protected override void OnLoad(EventArgs e)
        {
            // Check for necessary capabilities:
            string version = GL.GetString(StringName.Version);
            int major = (int)version[0];
            int minor = (int)version[2];
            if (major < 2)
            {
                MessageBox.Show("You need at least OpenGL 2.0 to run this example. Aborting.",
                                 "GLSL not supported", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Exit();
            }

            this.VSync = VSyncMode.On;

            GL.Disable(EnableCap.Dither);
            GL.ClearColor(0.2f, 0f, 0.4f, 0f);

            // declare some variables for tracking which shader did compile, and which texture to use
            string[] ShaderFilenames = new string[2];
            ShaderFilenames[0] = "Data/Shaders/JuliaSet_SM3_FS.glsl";
            ShaderFilenames[1] = "Data/Shaders/JuliaSet_SM2_FS.glsl";

            byte CurrentOption = 0;
            string LogInfo;

            #region Shaders
            // Load&Compile Vertex Shader
            using (StreamReader sr = new StreamReader("Data/Shaders/JuliaSet_VS.glsl"))
            {
                VertexShaderObject = GL.CreateShader(ShaderType.VertexShader);
                GL.ShaderSource(VertexShaderObject, sr.ReadToEnd());
                GL.CompileShader(VertexShaderObject);
            }

            GL.GetShaderInfoLog(VertexShaderObject, out LogInfo);
            if (LogInfo.Length > 0 && !LogInfo.Contains("hardware"))
                Trace.WriteLine("Vertex Shader Log:\n" + LogInfo);
            else
                Trace.WriteLine("Vertex Shader compiled without complaint.");

            // Load&Compile Fragment Shader


            FragmentShaderObject = GL.CreateShader(ShaderType.FragmentShader);
            do
            {
                using (StreamReader sr = new StreamReader(ShaderFilenames[CurrentOption]))
                {

                    GL.ShaderSource(FragmentShaderObject, sr.ReadToEnd());
                    GL.CompileShader(FragmentShaderObject);
                }
                GL.GetShaderInfoLog(FragmentShaderObject, out LogInfo);

                if (LogInfo.Length > 0 && !LogInfo.Contains("hardware"))
                    Trace.WriteLine("Compiling " + ShaderFilenames[CurrentOption] + " failed!\nLog:\n" + LogInfo);
                else
                {
                    Trace.WriteLine("Fragment Shader compiled without complaint.");
                    break;
                }

                if (++CurrentOption > 1)
                {
                    MessageBox.Show("Neither SM2 nor SM3 Fragment Shader compiled successfully. Aborting.",
                                     "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Exit();
                }
            } while (true);

            // Link the Shaders to a usable Program
            ProgramObject = GL.CreateProgram();
            GL.AttachShader(ProgramObject, VertexShaderObject);
            GL.AttachShader(ProgramObject, FragmentShaderObject);
            GL.LinkProgram(ProgramObject);

            // make current
            GL.UseProgram(ProgramObject);

            // Flag ShaderObjects for delete when app exits
            GL.DeleteShader(VertexShaderObject);
            GL.DeleteShader(FragmentShaderObject);
            #endregion Shaders

            #region Textures

            // Load&Bind the 1D texture for color lookups
            GL.ActiveTexture(TextureUnit.Texture0); // select TMU0
            GL.GenTextures(1, out TextureObject);
            GL.TexParameter(TextureTarget.Texture1D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);
            GL.TexParameter(TextureTarget.Texture1D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.Texture1D, TextureParameterName.TextureWrapS, (int)(TextureWrapMode)All.ClampToEdge);

            using (Bitmap bitmap = new Bitmap("Data/Textures/JuliaColorTable.bmp"))
            {
                BitmapData data = bitmap.LockBits(new System.Drawing.Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly,
                                                  System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                GL.TexImage1D(TextureTarget.Texture1D, 0, PixelInternalFormat.Rgb8, data.Width, 0, OpenTK.Graphics.OpenGL.PixelFormat.Bgr,
                              PixelType.UnsignedByte, data.Scan0);
                bitmap.UnlockBits(data);
            }
            #endregion Textures
            
            Keyboard.KeyUp += KeyUp;
        }

        int i = 0;
        void KeyUp(object sender, KeyboardKeyEventArgs e)
        {
            if (e.Key == Key.F12)
            {
                Bitmap bmp = new Bitmap(this.Width, this.Height);
                System.Drawing.Imaging.BitmapData data = 
                    bmp.LockBits(new System.Drawing.Rectangle(0, 0, this.Width, this.Height),
                                 System.Drawing.Imaging.ImageLockMode.WriteOnly,
                                 System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                GL.ReadPixels(0, 0, this.Width, this.Height,
                              OpenTK.Graphics.OpenGL.PixelFormat.Bgr,
                              OpenTK.Graphics.OpenGL.PixelType.UnsignedByte,
                              data.Scan0);
                bmp.UnlockBits(data);
                bmp.RotateFlip(RotateFlipType.RotateNoneFlipY);
                bmp.Save("Screenshot" + (i++).ToString() + ".png", ImageFormat.Png);
            }
        }
        
        #endregion

        #region OnUnload

        protected override void OnUnload(EventArgs e)
        {
            if (TextureObject != 0)
                GL.DeleteTextures(1, ref TextureObject);

            if (ProgramObject != 0)
                GL.DeleteProgram(ProgramObject); // implies deleting the previously flagged ShaderObjects
        }

        #endregion

        #region OnResize

        /// <summary>
        /// Respond to resize events here.
        /// </summary>
        /// <param name="e">Contains information on the new GameWindow size.</param>
        /// <remarks>There is no need to call the base implementation.</remarks>
        protected override void OnResize(EventArgs e)
        {
            // Magic numbers so the fractal almost fits inside the window.
            // If changing this, also change the -1.6f offset in the fragment shader accordingly.
            UniformScaleFactorX = Width / (UniformOffsetX * 2f);
            UniformScaleFactorY = Height / (UniformOffsetY * 2f);

            GL.Viewport(0, 0, Width, Height);

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-1.0, 1.0, -1.0, 1.0, 0.0, 1.0); // 2D setup

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
        }

        #endregion

        #region OnUpdateFrame

        /// <summary>
        /// Add your game logic here.
        /// </summary>
        /// <param name="e">Contains timing information.</param>
        /// <remarks>There is no need to call the base implementation.</remarks>
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            if (Keyboard[OpenTK.Input.Key.Escape])
            {
                this.Exit();
            }
        }

        #endregion

        #region OnRenderFrame

        /// <summary>
        /// Add your game rendering code here.
        /// </summary>
        /// <param name="e">Contains timing information.</param>
        /// <remarks>There is no need to call the base implementation.</remarks>
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            //this.Title = "FPS: " + 1 / e.Time;
            GL.Clear(ClearBufferMask.ColorBufferBit);

            // First, render the next frame of the Julia fractal.
            GL.UseProgram(ProgramObject);

            // advance the animation by elapsed time, scaling is solely used to make the anim more interesting
            AnimOffsetX += (float)(e.Time * AnimSpeedX);
            AnimOffsetY += (float)(e.Time * AnimSpeedY);

            // pass uniforms into the fragment shader
            // first the texture
            GL.Uniform1(GL.GetUniformLocation(ProgramObject, "COLORTABLE"), TextureObject);
            // the rest are floats
            GL.Uniform1(GL.GetUniformLocation(ProgramObject, "CETX"), (float)(Math.Cos(AnimOffsetX) * AnimCosinusPercent));
            GL.Uniform1(GL.GetUniformLocation(ProgramObject, "CETY"), (float)(Math.Cos(AnimOffsetY) * AnimCosinusPercent));
            GL.Uniform1(GL.GetUniformLocation(ProgramObject, "SCALINGX"), UniformScaleFactorX);
            GL.Uniform1(GL.GetUniformLocation(ProgramObject, "SCALINGY"), UniformScaleFactorY);
            GL.Uniform1(GL.GetUniformLocation(ProgramObject, "OFFSETX"), UniformOffsetX);
            GL.Uniform1(GL.GetUniformLocation(ProgramObject, "OFFSETY"), UniformOffsetY);

            // Fullscreen quad. Using immediate mode, since this app is fragment shader limited anyways.
            GL.Begin(BeginMode.Quads);
            {
                GL.Vertex2(-1.0f, -1.0f);
                GL.Vertex2(1.0f, -1.0f);
                GL.Vertex2(1.0f, 1.0f);
                GL.Vertex2(-1.0f, 1.0f);
            }
            GL.End();

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
            using (JuliaSetFractal example = new JuliaSetFractal())
            {
                Utilities.SetWindowTitle(example);
                example.Run(30.0);
            }
        }

        #endregion
    }
}
