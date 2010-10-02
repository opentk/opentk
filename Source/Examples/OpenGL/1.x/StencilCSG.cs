using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Diagnostics;

using OpenTK;
using OpenTK.Input;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

using Examples.Shapes;

namespace Examples.Tutorial
{

    [Example("Stencil CSG", ExampleCategory.OpenGL, "1.x", Documentation = "StencilCSG")]
    partial class StencilCSG: GameWindow
    {
        #region Model Related
        DrawableShape OperandB;
        DrawableShape OperandA;
        float MySphereZOffset = 0f;
        float MySphereXOffset = 0f;

        int Texture;
        #endregion Model Related

        string WindowTitle;
        bool ShowDebugWireFrame = true;

        float CameraZoom;
        float CameraRotX;
        float CameraRotY;
        Vector3 EyePosition = new Vector3( 0f, 0f, 15f );

        #region Window
        public StencilCSG()
            : base( 800, 600, new GraphicsMode( new ColorFormat( 8, 8, 8, 8 ), 24, 8 ) ) // request 8-bit stencil buffer
        {
            base.VSync = VSyncMode.Off;
            Keyboard.KeyDown += delegate(object sender, KeyboardKeyEventArgs e)
            {
                switch (e.Key)
                {
                    case Key.Escape: this.Exit(); break;
                    case Key.Space: ShowDebugWireFrame = !ShowDebugWireFrame; break;
                }
            };
        }

        protected override void OnResize(EventArgs e )
        {
            GL.Viewport( 0, 0, Width, Height );
            GL.MatrixMode( MatrixMode.Projection );
            Matrix4 p = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, Width / (float)Height, 0.1f, 64.0f);
            GL.LoadMatrix(ref p);
        }
        #endregion Window

        protected override void OnLoad(EventArgs e)
        {
            #region Abort on platforms which will not be able to execute the ops properly
            /*
            if (!GL.SupportsExtension("VERSION_1_2"))
            {
                Trace.WriteLine("Aborting. OpenGL 1.2 or later required.");
                this.Exit();
            }

            int[] t = new int[2];
            GL.GetInteger(GetPName.MajorVersion, out t[0]);
            GL.GetInteger(GetPName.MinorVersion, out t[1]);
            Trace.WriteLine("OpenGL Context Version: " + t[0] + "." + t[1]);

            GL.GetInteger(GetPName.DepthBits, out t[0]);
            Trace.WriteLine("Depth Bits: " + t[0]);
            GL.GetInteger(GetPName.StencilBits, out t[1]);
            Trace.WriteLine("Stencil Bits: " + t[1]);

            if (t[0] < 16)
            {
                Trace.WriteLine("Aborting. Need at least 16 depth bits, only " + t[0] + " available.");
                this.Exit();
            }

            if (t[1] < 1)
            {
                Trace.WriteLine("Aborting. Need at least 1 stencil bit, only " + t[1] + " available.");
                this.Exit();
            }
            */
            #endregion Abort on platforms which will not be able to execute the ops properly

            WindowTitle = "Cube-Sphere Stencil CSG  " + GL.GetString(StringName.Renderer) + " (GL " + GL.GetString(StringName.Version) + ")";

            #region GL States
            GL.ClearColor(.08f, .12f, .16f, 1f);

            GL.Enable(EnableCap.DepthTest);
            GL.DepthFunc(DepthFunction.Less);
            GL.ClearDepth(1.0);

            GL.Enable(EnableCap.StencilTest);
            GL.ClearStencil(0);
            GL.StencilMask(0xFFFFFFFF); // read&write

            GL.Enable(EnableCap.CullFace);
            GL.FrontFace(FrontFaceDirection.Ccw);
            GL.CullFace(CullFaceMode.Back);

            GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Fill);

            GL.Color4(1f, 1f, 1f, 1f);

            GL.Enable(EnableCap.Lighting);
            GL.Enable(EnableCap.Light0);
            GL.ShadeModel(ShadingModel.Smooth);

            #endregion GL States

            #region Load Texture
            Bitmap bitmap = new Bitmap("Data/Textures/logo-dark.jpg");
            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);

            GL.GenTextures(1, out Texture);
            GL.BindTexture(TextureTarget.Texture2D, Texture);

            BitmapData data = bitmap.LockBits(new System.Drawing.Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, data.Width, data.Height, 0, OpenTK.Graphics.OpenGL.PixelFormat.Bgra, PixelType.UnsignedByte, data.Scan0);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);
            GL.Finish();
            bitmap.UnlockBits(data);
            #endregion Load Texture

            OperandA = new ChamferCube(1.5, 2.0, 2.5, ChamferCube.SubDivs.Four, 0.42, true);
            OperandB = new SlicedSphere(2.0f, Vector3d.Zero,
                                           SlicedSphere.eSubdivisions.Three,
                                           new SlicedSphere.eDir[] { SlicedSphere.eDir.All },
                                           true);

            #region Invert Operand B's Normals
            // only the inside of the operand is ever drawn to color buffers and lighting requires this.
            BeginMode tempPrimMode;
            VertexT2dN3dV3d[] tempVertices;
            uint[] tempIndices;

            OperandB.GetArraysforVBO(out tempPrimMode, out tempVertices, out tempIndices);
            OperandB.Dispose();

            for (int i = 0; i < tempVertices.Length; i++)
            {
                tempVertices[i].Normal *= -1.0;
                tempVertices[i].Normal.Normalize();
            }

            OperandB = new VboShape(ref tempPrimMode, ref tempVertices, ref tempIndices, true);
            #endregion Invert Operand B's Normals
        }

        protected override void OnUnload(EventArgs e)
        {
            GL.DeleteTextures( 1, ref Texture );

            OperandA.Dispose();
            OperandB.Dispose();

            base.OnUnload( e );
        }

        protected override void OnUpdateFrame( FrameEventArgs e )
        {
            #region Magic numbers for camera
            CameraRotX = -Mouse.X * .5f;
            CameraRotY = Mouse.Y * .5f;
            CameraZoom = Mouse.Wheel * .2f;
            #endregion Magic numbers for camera
        }

        public void DrawOperandB()
        {
            GL.PushMatrix();
            GL.Translate( Math.Cos(MySphereXOffset), -1f, Math.Cos(MySphereZOffset) );
            OperandB.Draw();
            GL.PopMatrix();
        }

        public void DrawOperandA()
        {
            GL.Enable( EnableCap.Texture2D );
            OperandA.Draw();
            GL.Disable( EnableCap.Texture2D );
        }

        public void RenderCsg()
        {
            // first pass
            GL.Disable( EnableCap.StencilTest );
           
            GL.ColorMask( false, false, false, false );
            GL.CullFace( CullFaceMode.Front );
            DrawOperandB();// draw front-faces into depth buffer

            // use stencil plane to find parts of b in a 
            GL.DepthMask( false );
            GL.Enable( EnableCap.StencilTest );
            GL.StencilFunc( StencilFunction.Always, 0, 0 );

            GL.StencilOp( StencilOp.Keep, StencilOp.Keep, StencilOp.Incr );
            GL.CullFace( CullFaceMode.Back );
            DrawOperandA(); // increment the stencil where the front face of a is drawn

            GL.StencilOp( StencilOp.Keep, StencilOp.Keep, StencilOp.Decr );
            GL.CullFace( CullFaceMode.Front );
            DrawOperandA(); // decrement the stencil buffer where the back face of a is drawn

            GL.DepthMask( true );
            GL.Disable( EnableCap.DepthTest );

            GL.ColorMask( true, true, true, true );
            GL.StencilFunc( StencilFunction.Notequal, 0, 1 );
            DrawOperandB(); // draw the part of b that's in a

            // fix depth
            GL.ColorMask( false, false, false, false );
            GL.Enable( EnableCap.DepthTest );
            GL.Disable( EnableCap.StencilTest );
            GL.DepthFunc( DepthFunction.Always );
            DrawOperandA();
            GL.DepthFunc( DepthFunction.Less );

            // second pass
            GL.CullFace( CullFaceMode.Back );
            DrawOperandA();

            GL.DepthMask( false );
            GL.Enable( EnableCap.StencilTest );

            GL.StencilFunc( StencilFunction.Always, 0, 0 );
            GL.StencilOp( StencilOp.Keep, StencilOp.Keep, StencilOp.Incr );
            DrawOperandB(); // increment the stencil where the front face of b is drawn

            GL.StencilOp( StencilOp.Keep, StencilOp.Keep, StencilOp.Decr );
            GL.CullFace( CullFaceMode.Front );
            DrawOperandB(); // decrement the stencil buffer where the back face of b is drawn

            GL.DepthMask( true );
            GL.Disable( EnableCap.DepthTest );

            GL.ColorMask( true, true, true, true );
            GL.StencilFunc( StencilFunction.Equal, 0, 1 );
            GL.CullFace( CullFaceMode.Back );
            DrawOperandA(); // draw the part of a that's in b

            GL.Enable( EnableCap.DepthTest );
        }

        protected override void OnRenderFrame( FrameEventArgs e )
        {
            this.Title = WindowTitle + "  FPS: " + ( 1f / e.Time ).ToString("0.");

            MySphereZOffset += (float)( e.Time * 3.1 );
            MySphereXOffset += (float)( e.Time * 4.2 );

            #region Transform setup
            GL.Clear( ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit | ClearBufferMask.StencilBufferBit );

            // Camera
            GL.MatrixMode( MatrixMode.Modelview );
            Matrix4 mv = Matrix4.LookAt( EyePosition, Vector3.Zero, Vector3.UnitY );
            GL.LoadMatrix(ref mv);

            GL.Translate( 0f, 0f, CameraZoom );
            GL.Rotate( CameraRotX, Vector3.UnitY );
            GL.Rotate( CameraRotY, Vector3.UnitX );
            #endregion Transform setup

            RenderCsg();

            // ---------------------------------

            if ( ShowDebugWireFrame )
            {
                GL.Color3(System.Drawing.Color.LightGray);
                GL.Disable( EnableCap.StencilTest );
                GL.Disable( EnableCap.Lighting );
                //GL.Disable( EnableCap.DepthTest );
                GL.PolygonMode( MaterialFace.Front, PolygonMode.Line );
                DrawOperandB();
                GL.PolygonMode( MaterialFace.Front, PolygonMode.Fill );
                GL.Enable( EnableCap.DepthTest );
                GL.Enable( EnableCap.Lighting );
                GL.Enable( EnableCap.StencilTest );
            }
            this.SwapBuffers();
        }

        [STAThread]
        static void Main()
        {
            using ( StencilCSG example = new StencilCSG() )
            {
                Utilities.SetWindowTitle(example);
                example.Run( 30.0, 0.0 );
            }
        }

    }
}
