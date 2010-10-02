#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing details.
 */
#endregion

using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

using Examples.TextureLoaders;

namespace Examples.Tutorial
{
    /// <summary>Demonstrates Swizzled DXT5 Parallax Mapping
    /// The idea is described in more detail right here: http://www.opentk.com/node/394
    /// </summary>
    [Example("Swizzled Parallax Mapping", ExampleCategory.OpenGL, "2.x", Documentation = "SwizzledParallax")]
    public class T12_GLSL_Parallax: GameWindow
    {
        public T12_GLSL_Parallax( )
            : base( 800, 600 )
        {
        }

        #region internal Fields

        // Shader
        int VertexShaderObject, FragmentShaderObject, ProgramObject;
        const string VertexShaderFilename = "Data/Shaders/Parallax_VS.glsl";
        const string FragmentShaderFilename = "Data/Shaders/Parallax_FS.glsl";

        const int AttribTangent = 5; // slot where to pass tangents to VS, not sure which are reserved besides 0
        Vector3 Tangent = new Vector3( 1f, 0f, 0f );
        Vector3 Normal = new Vector3( 0f, 0f, 1f );

        // Material parameter
        //Vector3 MaterialScaleAndBiasAndShininess = new Vector3( 0.07f, 0.0f, 38.0f ); // for Metal tex
         Vector3 MaterialScaleAndBiasAndShininess = new Vector3( 0.04f, 0.0f, 92.0f ); // for Rock tex

        // Textures
        const TextureUnit TMU0_Unit = TextureUnit.Texture0;
        const int TMU0_UnitInteger = 0;
        const string TMU0_Filename = "Data/Textures/swizzled-rock-diffuse-height.dds";
        uint TMU0_Handle;
        TextureTarget TMU0_Target;

        const TextureUnit TMU1_Unit = TextureUnit.Texture1;
        const int TMU1_UnitInteger = 1;
        const string TMU1_Filename = "Data/Textures/swizzled-rock-normal-gloss.dds";
        uint TMU1_Handle;
        TextureTarget TMU1_Target;

        // Camera
        Vector3 EyePos = new Vector3( 0.0f, 0.0f, 3.0f );

        // Light
        Vector3 LightPosition = new Vector3( 0.0f, 1.0f, 1.0f );
        Vector3 LightDiffuse = new Vector3( 0.5f, 0.5f, 0.5f );
        Vector3 LightSpecular = new Vector3( 1f, 1f, 1f );

        #endregion internal Fields

        /// <summary>Setup OpenGL and load resources here.</summary>
        /// <param name="e">Not used.</param>
        protected override void OnLoad(EventArgs e)
        {
            this.VSync = VSyncMode.Off;

            // Check for necessary capabilities:
            string extensions = GL.GetString(StringName.Extensions);
            if ( !GL.GetString(StringName.Extensions).Contains("GL_ARB_shading_language"))
            {
                throw new NotSupportedException(String.Format("This example requires OpenGL 2.0. Found {0}. Aborting.",
                    GL.GetString(StringName.Version).Substring(0, 3)));
            }

            if (!extensions.Contains("GL_ARB_texture_compression") || 
                 !extensions.Contains("GL_EXT_texture_compression_s3tc"))
            {
                throw new NotSupportedException("This example requires support for texture compression. Aborting.");
            }

            int[] temp = new int[1];
            GL.GetInteger( GetPName.MaxTextureImageUnits, out temp[0] );
            Trace.WriteLine( temp[0] + " TMU's for Fragment Shaders found. (2 required)" );

            GL.GetInteger( GetPName.MaxVaryingFloats, out temp[0] );
            Trace.WriteLine( temp[0] + " varying floats between VS and FS allowed. (6 required)" );

            GL.GetInteger( GetPName.MaxVertexUniformComponents, out temp[0] );
            Trace.WriteLine( temp[0] + " uniform components allowed in Vertex Shader. (6 required)" );

            GL.GetInteger( GetPName.MaxFragmentUniformComponents, out temp[0] );
            Trace.WriteLine( temp[0] + " uniform components allowed in Fragment Shader. (11 required)" );
            Trace.WriteLine("" );

            #region GL State

            GL.ClearColor( 0.2f, 0f, 0.4f, 0f );

            GL.PointSize( 10f );

            GL.Disable( EnableCap.Dither );

            GL.FrontFace( FrontFaceDirection.Ccw );
            GL.PolygonMode( MaterialFace.Front, PolygonMode.Fill );
            GL.PolygonMode( MaterialFace.Back, PolygonMode.Line );

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

            // must bind the attribute before linking
            GL.BindAttribLocation( ProgramObject, AttribTangent, "AttributeTangent" );

            // link it all together
            GL.LinkProgram( ProgramObject );

           // flag ShaderObjects for delete when not used anymore
            GL.DeleteShader( VertexShaderObject );
            GL.DeleteShader( FragmentShaderObject );

            GL.GetProgram( ProgramObject, ProgramParameter.LinkStatus, out temp[0] );
            Trace.WriteLine( "Linking Program (" + ProgramObject + ") " + ( ( temp[0] == 1 ) ? "succeeded." : "FAILED!" ) );
            if ( temp[0] != 1 )
            {
                GL.GetProgramInfoLog( ProgramObject, out LogInfo );
                Trace.WriteLine( "Program Log:\n" + LogInfo );
            }

            GL.GetProgram( ProgramObject, ProgramParameter.ActiveAttributes, out temp[0] );
            Trace.WriteLine( "Program registered " + temp[0] + " Attributes. (Should be 4: Pos, UV, Normal, Tangent)" );

            Trace.WriteLine( "Tangent attribute bind location: " + GL.GetAttribLocation( ProgramObject, "AttributeTangent" ) );

            Trace.WriteLine( "End of Shader build. GL Error: " + GL.GetError( ) );

            #endregion Shaders

            #region Textures

            TextureLoaderParameters.MagnificationFilter = TextureMagFilter.Linear;
            TextureLoaderParameters.MinificationFilter = TextureMinFilter.LinearMipmapLinear;
            TextureLoaderParameters.WrapModeS = TextureWrapMode.ClampToBorder;
            TextureLoaderParameters.WrapModeT = TextureWrapMode.ClampToBorder;
            TextureLoaderParameters.EnvMode = TextureEnvMode.Modulate;

            ImageDDS.LoadFromDisk( TMU0_Filename, out TMU0_Handle, out TMU0_Target );
            Trace.WriteLine( "Loaded " + TMU0_Filename + " with handle " + TMU0_Handle + " as " + TMU0_Target );
           
            ImageDDS.LoadFromDisk( TMU1_Filename, out TMU1_Handle, out TMU1_Target );
            Trace.WriteLine( "Loaded " + TMU1_Filename + " with handle " + TMU1_Handle + " as " + TMU1_Target );

            #endregion Textures

            Trace.WriteLine( "End of Texture Loading. GL Error: " + GL.GetError( ) );
            Trace.WriteLine( "");
        }

        protected override void OnUnload(EventArgs e)
        {
            GL.DeleteProgram( ProgramObject );
            GL.DeleteTextures( 1, ref TMU0_Handle );
            GL.DeleteTextures( 1, ref TMU1_Handle );

            base.OnUnload( e );
        }

        /// <summary>Respond to resize events here.</summary>
        /// <param name="e">Contains information on the new GameWindow size.</param>
        /// <remarks>There is no need to call the base implementation.</remarks>
        protected override void OnResize( EventArgs e )
        {
            GL.Viewport( 0, 0, Width, Height );

            GL.MatrixMode( MatrixMode.Projection );
            Matrix4 p = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, Width / (float)Height, 0.1f, 100.0f);
            GL.LoadMatrix(ref p);

            GL.MatrixMode( MatrixMode.Modelview );
            GL.LoadIdentity( );

            base.OnResize( e );
        }

        /// <summary>Add your game logic here.</summary>
        /// <param name="e">Contains timing information.</param>
        /// <remarks>There is no need to call the base implementation.</remarks>
      protected override void OnUpdateFrame( FrameEventArgs e )
        {
            base.OnUpdateFrame( e );

            if ( Keyboard[OpenTK.Input.Key.Escape] )
                this.Exit( );
            if ( Keyboard[OpenTK.Input.Key.Space] )
                Trace.WriteLine( "GL: " + GL.GetError( ) );
            if ( Keyboard[OpenTK.Input.Key.Q] )
            {
                MaterialScaleAndBiasAndShininess.X += 0.01f;
                Trace.WriteLine( "Scale: " + MaterialScaleAndBiasAndShininess.X + " Bias: " + MaterialScaleAndBiasAndShininess.Y );
            }
            if ( Keyboard[OpenTK.Input.Key.A] )
            {
                MaterialScaleAndBiasAndShininess.X -= 0.01f;
                Trace.WriteLine( "Scale: " + MaterialScaleAndBiasAndShininess.X + " Bias: " + MaterialScaleAndBiasAndShininess.Y );
            }
            if ( Keyboard[OpenTK.Input.Key.W] )
            {
                MaterialScaleAndBiasAndShininess.Y += 0.01f;
                Trace.WriteLine( "Scale: " + MaterialScaleAndBiasAndShininess.X + " Bias: " + MaterialScaleAndBiasAndShininess.Y );
            }
            if ( Keyboard[OpenTK.Input.Key.S] )
            {
                MaterialScaleAndBiasAndShininess.Y -= 0.01f;
                Trace.WriteLine( "Scale: " + MaterialScaleAndBiasAndShininess.X + " Bias: " + MaterialScaleAndBiasAndShininess.Y );
            }
            if ( Keyboard[OpenTK.Input.Key.E] )
            {
                MaterialScaleAndBiasAndShininess.Z += 1f;
                Trace.WriteLine( "Shininess: " + MaterialScaleAndBiasAndShininess.Z );
            }
            if ( Keyboard[OpenTK.Input.Key.D] )
            {
                MaterialScaleAndBiasAndShininess.Z -= 1f;
                Trace.WriteLine( "Shininess: " + MaterialScaleAndBiasAndShininess.Z );
            }

            LightPosition.X = ( -( this.Width / 2 ) + Mouse.X ) / 100f;
            LightPosition.Y = ( ( this.Height / 2 ) - Mouse.Y ) / 100f;

            EyePos.Y = Mouse.Wheel * 0.5f;
        }

        /// <summary>Add your game rendering code here.</summary>
        /// <param name="e">Contains timing information.</param>
        /// <remarks>There is no need to call the base implementation.</remarks>
       protected override void OnRenderFrame( FrameEventArgs e )
        {
            this.Title = "FPS: " + (1 / e.Time).ToString("0.");

            GL.Clear( ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit );

            GL.UseProgram( ProgramObject );

            #region Textures

            GL.ActiveTexture( TMU0_Unit );
            GL.BindTexture( TMU0_Target, TMU0_Handle );
            GL.ActiveTexture( TMU1_Unit );
            GL.BindTexture( TMU1_Target, TMU1_Handle );

            #endregion Textures

            #region Uniforms

            // first Material's uniforms      
            GL.Uniform1( GL.GetUniformLocation( ProgramObject, "Material_DiffuseAndHeight" ), TMU0_UnitInteger );
            GL.Uniform1( GL.GetUniformLocation( ProgramObject, "Material_NormalAndGloss" ), TMU1_UnitInteger );
            GL.Uniform3( GL.GetUniformLocation( ProgramObject, "Material_ScaleBiasShininess" ), MaterialScaleAndBiasAndShininess.X, MaterialScaleAndBiasAndShininess.Y, MaterialScaleAndBiasAndShininess.Z );

            // the rest are vectors
            GL.Uniform3( GL.GetUniformLocation( ProgramObject, "Camera_Position" ), EyePos.X, EyePos.Y, EyePos.Z );
            GL.Uniform3( GL.GetUniformLocation( ProgramObject, "Light_Position" ), LightPosition.X, LightPosition.Y, LightPosition.Z );
            GL.Uniform3( GL.GetUniformLocation( ProgramObject, "Light_DiffuseColor" ), LightDiffuse.X, LightDiffuse.Y, LightDiffuse.Z );
            GL.Uniform3( GL.GetUniformLocation( ProgramObject, "Light_SpecularColor" ), LightSpecular.X, LightSpecular.Y, LightSpecular.Z );

            #endregion Uniforms

            GL.PushMatrix( );
            Matrix4 t = Matrix4.LookAt( EyePos, Vector3.Zero, Vector3.UnitY );
            GL.MultMatrix(ref t);

            #region Draw Quad

            GL.Color3( 1f, 1f, 1f );

            GL.Begin( BeginMode.Quads );
            {
                GL.Normal3( Normal );
                GL.VertexAttrib3( AttribTangent, ref Tangent );
                GL.MultiTexCoord2( TextureUnit.Texture0, 0f, 1f );
                GL.Vertex3( -1.0f, 1.0f, 0.0f );

                GL.Normal3( Normal );
                GL.VertexAttrib3( AttribTangent, ref Tangent );
                GL.MultiTexCoord2( TextureUnit.Texture0, 0f, 0f );
                GL.Vertex3( -1.0f, -1.0f, 0.0f );

                GL.Normal3( Normal );
                GL.VertexAttrib3( AttribTangent, ref Tangent );
                GL.MultiTexCoord2( TextureUnit.Texture0, 1f, 0f );
                GL.Vertex3( 1.0f, -1.0f, 0.0f );

                GL.Normal3( Normal );
                GL.VertexAttrib3( AttribTangent, ref Tangent );
                GL.MultiTexCoord2( TextureUnit.Texture0, 1f, 1f );
                GL.Vertex3( 1.0f, 1.0f, 0.0f );
            }
            GL.End( );

            #endregion Draw Quad

            GL.UseProgram( 0 );

            // visualize the light position 'somehow'
            GL.Begin( BeginMode.Points );
            {
                GL.Color3( LightSpecular );
                GL.Vertex3( LightPosition );
            }
            GL.End( );

            GL.PopMatrix( );

            this.SwapBuffers( );
        }

        /// <summary>Entry point</summary>
        [STAThread]
        public static void Main( )
        {
            using ( T12_GLSL_Parallax example = new T12_GLSL_Parallax( ) )
            {
                Utilities.SetWindowTitle( example );
                example.Run( 30.0, 0.0 );
            }
        }
    }
}
