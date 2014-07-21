// This code was written for the OpenTK library and has been released
// to the Public Domain.
// It is provided "as is" without express or implied warranty of any kind.

using System;
using System.Drawing;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Text;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

using Examples.Shapes;
using Examples.TextureLoaders;

namespace Examples.Tutorial
{
    [Example("DDS Cube Map", ExampleCategory.OpenGL, "2.x", Documentation = "DDSCubeMap")]
    public class T13_GLSL_Earth: GameWindow
    {
        public T13_GLSL_Earth( )
            : base( 800, 800 )
        {
        }

        #region internal Fields

        // Shader
        int VertexShaderObject, FragmentShaderObject, ProgramObject;
        const string VertexShaderFilename = "Data/Shaders/CubeMap_VS.glsl";
        const string FragmentShaderFilename = "Data/Shaders/CubeMap_FS.glsl";

        // Textures
        const TextureUnit TMU0_Unit = TextureUnit.Texture0;
        const int TMU0_UnitInteger = 0;
        const string TMU0_Filename = "Data/Textures/earth-cubemap.dds";
        uint TMU0_Handle;
        TextureTarget TMU0_Target;

        // DL
        DrawableShape sphere;

        // Camera
        Vector3 EyePos = new Vector3( 0.0f, 0.0f, 6.0f );
        Vector3 Trackball = Vector3.Zero;

        #endregion internal Fields

        /// <summary>Setup OpenGL and load resources here.</summary>
        /// <param name="e">Not used.</param>
        protected override void OnLoad(EventArgs e)
        {
            this.VSync = VSyncMode.Off;

            // Check for necessary capabilities:
            string extensions = GL.GetString(StringName.Extensions);
            if (!GL.GetString(StringName.Extensions).Contains("GL_ARB_shading_language"))
            {
                throw new NotSupportedException(String.Format("This example requires OpenGL 2.0. Found {0}. Aborting.",
                    GL.GetString(StringName.Version).Substring(0, 3)));
            }

            if (!extensions.Contains("GL_ARB_texture_compression") ||
                 !extensions.Contains("GL_EXT_texture_compression_s3tc"))
            {
                throw new NotSupportedException("This example requires support for texture compression. Aborting.");
            }

            #region GL State

            GL.ClearColor( 0f, 0f, 0f, 0f );

            GL.Disable( EnableCap.Dither );

            GL.Enable( EnableCap.CullFace );
            GL.FrontFace( FrontFaceDirection.Ccw );
            GL.PolygonMode( MaterialFace.Front, PolygonMode.Fill );
            //  GL.PolygonMode( MaterialFace.Back, PolygonMode.Line );

            #endregion GL State

            #region Shaders

            string LogInfo;

            // Load&Compile Vertex Shader

            using ( StreamReader sr = new StreamReader( VertexShaderFilename ) )
            {
                VertexShaderObject = GL.CreateShader( ShaderType.VertexShader );
                GL.ShaderSource( VertexShaderObject, sr.ReadToEnd( ) );
                GL.CompileShader( VertexShaderObject );
            }

            GL.GetShaderInfoLog( VertexShaderObject, out LogInfo );
            if ( LogInfo.Length > 0 && !LogInfo.Contains( "hardware" ) )
                Trace.WriteLine( "Vertex Shader failed!\nLog:\n" + LogInfo );
            else
                Trace.WriteLine( "Vertex Shader compiled without complaint." );

            // Load&Compile Fragment Shader

            using ( StreamReader sr = new StreamReader( FragmentShaderFilename ) )
            {
                FragmentShaderObject = GL.CreateShader( ShaderType.FragmentShader );
                GL.ShaderSource( FragmentShaderObject, sr.ReadToEnd( ) );
                GL.CompileShader( FragmentShaderObject );
            }
            GL.GetShaderInfoLog( FragmentShaderObject, out LogInfo );

            if ( LogInfo.Length > 0 && !LogInfo.Contains( "hardware" ) )
                Trace.WriteLine( "Fragment Shader failed!\nLog:\n" + LogInfo );
            else
                Trace.WriteLine( "Fragment Shader compiled without complaint." );

            // Link the Shaders to a usable Program
            ProgramObject = GL.CreateProgram( );
            GL.AttachShader( ProgramObject, VertexShaderObject );
            GL.AttachShader( ProgramObject, FragmentShaderObject );

            // link it all together
            GL.LinkProgram( ProgramObject );

            // flag ShaderObjects for delete when not used anymore
            GL.DeleteShader( VertexShaderObject );
            GL.DeleteShader( FragmentShaderObject );

            int[] temp = new int[1];
            GL.GetProgram(ProgramObject, GetProgramParameterName.LinkStatus, out temp[0]);
            Trace.WriteLine( "Linking Program (" + ProgramObject + ") " + ( ( temp[0] == 1 ) ? "succeeded." : "FAILED!" ) );
            if ( temp[0] != 1 )
            {
                GL.GetProgramInfoLog( ProgramObject, out LogInfo );
                Trace.WriteLine( "Program Log:\n" + LogInfo );
            }

            GL.GetProgram(ProgramObject, GetProgramParameterName.ActiveAttributes, out temp[0]);
            Trace.WriteLine( "Program registered " + temp[0] + " Attributes. (Should be 4: Pos, UV, Normal, Tangent)" );

            Trace.WriteLine( "Tangent attribute bind location: " + GL.GetAttribLocation( ProgramObject, "AttributeTangent" ) );

            Trace.WriteLine( "End of Shader build. GL Error: " + GL.GetError( ) );

            #endregion Shaders

            #region Textures

            TextureLoaderParameters.FlipImages = false;
            TextureLoaderParameters.MagnificationFilter = TextureMagFilter.Linear;
            TextureLoaderParameters.MinificationFilter = TextureMinFilter.Linear;
            TextureLoaderParameters.WrapModeS = TextureWrapMode.ClampToEdge;
            TextureLoaderParameters.WrapModeT = TextureWrapMode.ClampToEdge;
            TextureLoaderParameters.EnvMode = TextureEnvMode.Modulate;

            ImageDDS.LoadFromDisk( TMU0_Filename, out TMU0_Handle, out TMU0_Target );
            Trace.WriteLine( "Loaded " + TMU0_Filename + " with handle " + TMU0_Handle + " as " + TMU0_Target );

            #endregion Textures

            Trace.WriteLine( "End of Texture Loading. GL Error: " + GL.GetError( ) );
            Trace.WriteLine( "");

            sphere = new SlicedSphere(1.5f, Vector3d.Zero, SlicedSphere.eSubdivisions.Four, new SlicedSphere.eDir[] { SlicedSphere.eDir.All }, true);

        }

        protected override void OnUnload(EventArgs e)
        {
            sphere.Dispose();

            GL.DeleteProgram( ProgramObject );
            GL.DeleteTextures( 1, ref TMU0_Handle );

            base.OnUnload( e );
        }

        /// <summary>Respond to resize events here.</summary>
        /// <param name="e">Contains information on the new GameWindow size.</param>
        /// <remarks>There is no need to call the base implementation.</remarks>
        protected override void OnResize( EventArgs e )
        {
            GL.Viewport( 0, 0, Width, Height );

            GL.MatrixMode( MatrixMode.Projection );
            Matrix4 p = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, Width / (float)Height, 0.1f, 10.0f);
            GL.LoadMatrix(ref p);

            GL.MatrixMode( MatrixMode.Modelview );
            GL.LoadIdentity( );

            base.OnResize( e );
        }

        /// <summary>Add your game logic here.</summary>
        /// <param name="e">Contains timing information.</param>
        /// <remarks>There is no need to call the base implementation.</remarks>
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            var keyboard = OpenTK.Input.Keyboard.GetState();
            var mouse = OpenTK.Input.Mouse.GetState();

            if (keyboard[OpenTK.Input.Key.Escape])
                this.Exit();
            if (keyboard[OpenTK.Input.Key.Space])
                Trace.WriteLine("GL: " + GL.GetError());

            Trackball.X = mouse.X;
            Trackball.Y = mouse.Y;
            Trackball.Z = mouse.Scroll.Y * 0.5f;
        }

        /// <summary>Add your game rendering code here.</summary>
        /// <param name="e">Contains timing information.</param>
        /// <remarks>There is no need to call the base implementation.</remarks>
       protected override void OnRenderFrame(FrameEventArgs e)
       {
           this.Title = "FPS: " + (1 / e.Time).ToString("0.");

           GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

           GL.UseProgram(ProgramObject);

           #region Textures

           GL.ActiveTexture(TMU0_Unit);
           GL.BindTexture(TMU0_Target, TMU0_Handle);

           #endregion Textures

           #region Uniforms

           GL.Uniform1(GL.GetUniformLocation(ProgramObject, "Earth"), TMU0_UnitInteger);

           #endregion Uniforms

           GL.PushMatrix();
           Matrix4 temp = Matrix4.LookAt(EyePos, Vector3.Zero, Vector3.UnitY);
           GL.MultMatrix(ref temp);

           GL.Rotate(Trackball.X, Vector3.UnitY);
           GL.Rotate(Trackball.Y, Vector3.UnitX);

           #region Draw

           GL.Color3(1f, 1f, 1f);

           sphere.Draw();

           #endregion Draw

           GL.PopMatrix();

           this.SwapBuffers();
       }

        /// <summary>Entry point</summary>
        [STAThread]
        public static void Main( )
        {
            using ( T13_GLSL_Earth example = new T13_GLSL_Earth( ) )
            {
                Utilities.SetWindowTitle(example);
                example.Run( 30.0, 0.0 );
            }
        }
    }
}
