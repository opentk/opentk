// This code was written for the OpenTK library and has been released
// to the Public Domain.
// It is provided "as is" without express or implied warranty of any kind.

using System;
using System.Diagnostics;
using System.Drawing;

using OpenTK;
using OpenTK.Input;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace Examples.Tutorial
{
    [Example("Framebuffer Objects", ExampleCategory.OpenGL, "1.x", Documentation = "FramebufferObject")]
    public class SimpleFBO : GameWindow
    {
        public SimpleFBO()
            : base(800, 400)
        {
        }

        uint ColorTexture;
        uint DepthTexture;
        uint FBOHandle;

        const int TextureSize = 512;

        Examples.Shapes.DrawableShape Object;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (!GL.GetString(StringName.Extensions).Contains("GL_EXT_framebuffer_object"))
            {
                throw new NotSupportedException(
                     "GL_EXT_framebuffer_object extension is required. Please update your drivers.");
            }

            Object = new Shapes.TorusKnot(256, 16, 0.2, 7,8, 1, true);

            GL.Enable(EnableCap.DepthTest);
            GL.ClearDepth(1.0);
            GL.DepthFunc(DepthFunction.Lequal);

            GL.Enable(EnableCap.CullFace);
            
            // Create Color Tex
            GL.GenTextures(1, out ColorTexture);
            GL.BindTexture(TextureTarget.Texture2D, ColorTexture);
            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba8, TextureSize, TextureSize, 0, PixelFormat.Rgba, PixelType.UnsignedByte, IntPtr.Zero);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int)TextureWrapMode.ClampToBorder);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (int)TextureWrapMode.ClampToBorder);
            // GL.Ext.GenerateMipmap( GenerateMipmapTarget.Texture2D );

            // Create Depth Tex
            GL.GenTextures(1, out DepthTexture);
            GL.BindTexture(TextureTarget.Texture2D, DepthTexture);
            GL.TexImage2D(TextureTarget.Texture2D, 0, (PixelInternalFormat)All.DepthComponent32, TextureSize, TextureSize, 0, PixelFormat.DepthComponent, PixelType.UnsignedInt, IntPtr.Zero);
            // things go horribly wrong if DepthComponent's Bitcount does not match the main Framebuffer's Depth
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int)TextureWrapMode.ClampToBorder);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (int)TextureWrapMode.ClampToBorder);
            // GL.Ext.GenerateMipmap( GenerateMipmapTarget.Texture2D );

            // Create a FBO and attach the textures
            GL.Ext.GenFramebuffers(1, out FBOHandle);
            GL.Ext.BindFramebuffer(FramebufferTarget.FramebufferExt, FBOHandle);
            GL.Ext.FramebufferTexture2D(FramebufferTarget.FramebufferExt, FramebufferAttachment.ColorAttachment0Ext, TextureTarget.Texture2D, ColorTexture, 0);
            GL.Ext.FramebufferTexture2D(FramebufferTarget.FramebufferExt, FramebufferAttachment.DepthAttachmentExt, TextureTarget.Texture2D, DepthTexture, 0);

            #region Test for Error

            switch (GL.Ext.CheckFramebufferStatus(FramebufferTarget.FramebufferExt))
            {
                case FramebufferErrorCode.FramebufferCompleteExt:
                    {
                        Console.WriteLine("FBO: The framebuffer is complete and valid for rendering.");
                        break;
                    }
                case FramebufferErrorCode.FramebufferIncompleteAttachmentExt:
                    {
                        Console.WriteLine("FBO: One or more attachment points are not framebuffer attachment complete. This could mean there’s no texture attached or the format isn’t renderable. For color textures this means the base format must be RGB or RGBA and for depth textures it must be a DEPTH_COMPONENT format. Other causes of this error are that the width or height is zero or the z-offset is out of range in case of render to volume.");
                        break;
                    }
                case FramebufferErrorCode.FramebufferIncompleteMissingAttachmentExt:
                    {
                        Console.WriteLine("FBO: There are no attachments.");
                        break;
                    }
                /* case  FramebufferErrorCode.GL_FRAMEBUFFER_INCOMPLETE_DUPLICATE_ATTACHMENT_EXT: 
                     {
                         Console.WriteLine("FBO: An object has been attached to more than one attachment point.");
                         break;
                     }*/
                case FramebufferErrorCode.FramebufferIncompleteDimensionsExt:
                    {
                        Console.WriteLine("FBO: Attachments are of different size. All attachments must have the same width and height.");
                        break;
                    }
                case FramebufferErrorCode.FramebufferIncompleteFormatsExt:
                    {
                        Console.WriteLine("FBO: The color attachments have different format. All color attachments must have the same format.");
                        break;
                    }
                case FramebufferErrorCode.FramebufferIncompleteDrawBufferExt:
                    {
                        Console.WriteLine("FBO: An attachment point referenced by GL.DrawBuffers() doesn’t have an attachment.");
                        break;
                    }
                case FramebufferErrorCode.FramebufferIncompleteReadBufferExt:
                    {
                        Console.WriteLine("FBO: The attachment point referenced by GL.ReadBuffers() doesn’t have an attachment.");
                        break;
                    }
                case FramebufferErrorCode.FramebufferUnsupportedExt:
                    {
                        Console.WriteLine("FBO: This particular FBO configuration is not supported by the implementation.");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("FBO: Status unknown. (yes, this is really bad.)");
                        break;
                    }
            }

            // using FBO might have changed states, e.g. the FBO might not support stereoscopic views or double buffering
            int[] queryinfo = new int[6];
            GL.GetInteger(GetPName.MaxColorAttachmentsExt, out queryinfo[0]);
            GL.GetInteger(GetPName.AuxBuffers, out queryinfo[1]);
            GL.GetInteger(GetPName.MaxDrawBuffers, out queryinfo[2]);
            GL.GetInteger(GetPName.Stereo, out queryinfo[3]);
            GL.GetInteger(GetPName.Samples, out queryinfo[4]);
            GL.GetInteger(GetPName.Doublebuffer, out queryinfo[5]);
            Console.WriteLine("max. ColorBuffers: " + queryinfo[0] + " max. AuxBuffers: " + queryinfo[1] + " max. DrawBuffers: " + queryinfo[2] +
                               "\nStereo: " + queryinfo[3] + " Samples: " + queryinfo[4] + " DoubleBuffer: " + queryinfo[5]);

            Console.WriteLine("Last GL Error: " + GL.GetError());

            #endregion Test for Error

            GL.PushAttrib(AttribMask.ViewportBit);
            {
                GL.Viewport(0, 0, TextureSize, TextureSize);

                // clear the screen in red, to make it very obvious what the clear affected. only the FBO, not the real framebuffer
                GL.ClearColor(1f, 0f, 0f, 0f);
                GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

                OpenTK.Matrix4 perspective = OpenTK.Matrix4.CreatePerspectiveFieldOfView( MathHelper.PiOver4, TextureSize / (float)TextureSize, 2.5f, 6f );
                GL.MatrixMode( MatrixMode.Projection );
                GL.LoadMatrix( ref perspective );

                Matrix4 lookat = Matrix4.LookAt( 0f, 0f, 4.5f, 0f, 0f, 0f, 0f, 1f, 0f );
                GL.MatrixMode( MatrixMode.Modelview );
                GL.LoadMatrix( ref lookat );

                // draw some complex object into the FBO's textures
                GL.Enable( EnableCap.Lighting );
                GL.Enable( EnableCap.Light0 );
                GL.Enable( EnableCap.ColorMaterial );
                GL.Color3( 0f, 1f, 0f );
                Object.Draw();
                GL.Disable( EnableCap.ColorMaterial );
                GL.Disable( EnableCap.Light0 );
                GL.Disable( EnableCap.Lighting );
                
            }
            GL.PopAttrib();
            GL.Ext.BindFramebuffer(FramebufferTarget.FramebufferExt, 0); // disable rendering into the FBO

            GL.ClearColor(.1f, .2f, .3f, 0f);
            GL.Color3(1f, 1f, 1f);

            GL.Enable(EnableCap.Texture2D); // enable Texture Mapping
            GL.BindTexture(TextureTarget.Texture2D, 0); // bind default texture
        }

        protected override void OnUnload(EventArgs e)
        {
            Object.Dispose();

            // Clean up what we allocated before exiting
            if (ColorTexture != 0)
                GL.DeleteTextures(1, ref ColorTexture);

            if (DepthTexture != 0)
                GL.DeleteTextures(1, ref DepthTexture);

            if (FBOHandle != 0)
                GL.Ext.DeleteFramebuffers(1, ref FBOHandle);
        }

        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);

            double aspect_ratio = Width / (double)Height;

            OpenTK.Matrix4 perspective = OpenTK.Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, (float)aspect_ratio, 1, 64);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref perspective);

            Matrix4 lookat = Matrix4.LookAt(0, 0, 3, 0, 0, 0, 0, 1, 0);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref lookat);

            base.OnResize(e);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            var keyboard = OpenTK.Input.Keyboard.GetState();
            if (keyboard[Key.Escape])
                this.Exit();
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.PushMatrix();
            {
                // Draw the Color Texture
                GL.Translate(-1.1f, 0f, 0f);
                GL.BindTexture(TextureTarget.Texture2D, ColorTexture);
                GL.Begin(PrimitiveType.Quads);
                {
                    GL.TexCoord2(0f, 1f);
                    GL.Vertex2(-1.0f, 1.0f);
                    GL.TexCoord2(0.0f, 0.0f);
                    GL.Vertex2(-1.0f, -1.0f);
                    GL.TexCoord2(1.0f, 0.0f);
                    GL.Vertex2(1.0f, -1.0f);
                    GL.TexCoord2(1.0f, 1.0f);
                    GL.Vertex2(1.0f, 1.0f);
                }
                GL.End();

                // Draw the Depth Texture
                GL.Translate(+2.2f, 0f, 0f);
                GL.BindTexture(TextureTarget.Texture2D, DepthTexture);
                GL.Begin(PrimitiveType.Quads);
                {
                    GL.TexCoord2(0f, 1f);
                    GL.Vertex2(-1.0f, 1.0f);
                    GL.TexCoord2(0.0f, 0.0f);
                    GL.Vertex2(-1.0f, -1.0f);
                    GL.TexCoord2(1.0f, 0.0f);
                    GL.Vertex2(1.0f, -1.0f);
                    GL.TexCoord2(1.0f, 1.0f);
                    GL.Vertex2(1.0f, 1.0f);
                }
                GL.End();
            }
            GL.PopMatrix();

            this.SwapBuffers();
        }

        #region public static void Main()

        /// <summary>
        /// Entry point of this example.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            using (SimpleFBO example = new SimpleFBO())
            {
                Utilities.SetWindowTitle(example);
                example.Run(30.0, 0.0);
            }
        }

        #endregion
    }
}