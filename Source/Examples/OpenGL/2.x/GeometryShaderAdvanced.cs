#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

using System;
using System.Diagnostics;
using System.Drawing;

using OpenTK;
using OpenTK.Input;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

/*
 * The idea is to make a simple scene: A box with a checker texture with a sphere inside it. The
 * camera will be inside the box looking at the sphere.
 * 
 * Rendering will be done in two passes.  The first pass will render the box from within the
 * sphere, looking in along all three axes in the positive and negative directions.  These six
 * different camara orientations will be rendered to individual faces of a cubemap, in one
 * single pass using the gl_Layer token in the geometry shader. This cubemap will be used the
 * the second pass.  
 * 
 * The second pass will render both the box and the sphere. The box will have the checker
 * texture, and the sphere will use the cubemap from the first pass.
 * 
 * Keys:
 * F1 - switch to cubemap cross texture view
 * F2 - switch to the normal scene render
 * 
 * F5 - Polygon mode points
 * F6 - Polygon mode lines
 * F7 - Polygon mode fill
 * 
 * References:
 * http://www.opengl.org/wiki/GL_EXT_framebuffer_object#Quick_example.2C_render_to_texture_.28Cubemap.29
 * http://www.opengl.org/registry/specs/EXT/framebuffer_object.txt
 * http://www.opengl.org/registry/specs/EXT/geometry_shader4.txt
 */

namespace Examples.Tutorial
{
    [Example("Advanced Geometry Shader", ExampleCategory.OpenGL, "2.x", Documentation = "Advanced usage of EXT_geometry_shader4")]
    public class SimpleGeometryShader2 : GameWindow
    {
        public SimpleGeometryShader2()
            : base(800, 600)
        {
            Keyboard.KeyDown += Keyboard_KeyDown;
        }

        enum ViewMode
        {
            CubemapCross,
            Scene,
        }

        struct VertexPositionNormalTexture
        {
            public Vector3 Position, Normal;
            public Vector2 Texture;
            
            public VertexPositionNormalTexture(Vector3 position, Vector3 normal, Vector2 texture)
            {
                Position = position;
                Normal = normal;
                Texture = texture;
            }
        }

        #region Fields

        int shaderProgramBox;
        int shaderProgramSphere;
        int shaderProgramCubemap;

        int textureCubeColor;
        int textureCubeDepth;
        int textureCubeFBO;

        int vboCube;
        int vboCubeStride;
        int vboSphere;
        int vboSphereStride = BlittableValueType<VertexPositionNormalTexture>.Stride;
        int eboSphere;
        int sphereElementCount;

        ViewMode mode = ViewMode.Scene;
        Vector3 eyePos = new Vector3(0, -8, 0);
        Vector3 eyeLookat = new Vector3(0, -9, -0);
        Vector3 spherePos = new Vector3(0, -9, 0);
        DateTime startTime = DateTime.Now;

        #endregion

        #region keyboard handler

        void Keyboard_KeyDown(object sender, KeyboardKeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.F1:
                    switchToMode(ViewMode.CubemapCross);
                    break;
                case Key.F2:
                    switchToMode(ViewMode.Scene);
                    break;
                case Key.F5:
                    GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Point);
                    break;
                case Key.F6:
                    GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Line);
                    break;
                case Key.F7:
                    GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Fill);
                    break;
                case Key.Escape:
                    this.Exit();
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region init methods

        void initShaderProgramBox()
        {
            // create a program object.
            shaderProgramBox = GL.CreateProgram();
            // create shader objects.
            int vert = GL.CreateShader(ShaderType.VertexShader);
            int frag = GL.CreateShader(ShaderType.FragmentShader);

            // GLSL for fragment shader.
            // diagonal checker
            String fragSource = @"
                varying vec3 normal;
                void main( void )
                {   
                    float s = gl_TexCoord[0].s * 6.28 * 8.0;
                    float t = gl_TexCoord[0].t * 6.28 * 8.0;
                    gl_FragColor = gl_TexCoord[1] * vec4(sign(cos(s)+cos(t)));
                    //gl_FragColor = vec4(normal*vec3(0.5)+vec3(0.5), 1);
                }
            ";

            // GLSL for vertex shader.
            String vertSource = @"
                varying vec3 normal;
                void main( void )
                {
                    gl_Position = ftransform();
                    normal = gl_Normal;
                    gl_TexCoord[0] = gl_MultiTexCoord0;
                    gl_TexCoord[1] = normalize(gl_Vertex)*0.5+0.5;
                }   
            ";

            // compile shaders.
            compileShader(frag, fragSource);
            compileShader(vert, vertSource);

            // attach shaders and link the program.
            GL.AttachShader(shaderProgramBox, frag);
            GL.AttachShader(shaderProgramBox, vert);
            GL.LinkProgram(shaderProgramBox);

            // output link info log.
            string info;
            GL.GetProgramInfoLog(shaderProgramBox, out info);
            Debug.WriteLine(info);

            // Clean up resources. Note the program object is not deleted.
            if (frag != 0)
                GL.DeleteShader(frag);
            if (vert != 0)
                GL.DeleteShader(vert);
        }

        void initShaderProgramSphere()
        {
            // create a program object.
            shaderProgramSphere = GL.CreateProgram();
            // create shader objects.
            int vert = GL.CreateShader(ShaderType.VertexShader);
            int frag = GL.CreateShader(ShaderType.FragmentShader);

            // GLSL for fragment shader.
            String fragSource = @"
                varying vec3 normal;
                varying vec3 eyevec;
                uniform samplerCube tex;

                void main( void )
                {
                    gl_FragColor = textureCube(tex, reflect(normalize(-eyevec), normalize(normal)));
                }   
            ";

            // GLSL for vertex shader.
            String vertSource = @"
                varying vec3 normal;
                varying vec3 eyevec;

                void main( void )
                {
                    gl_Position = ftransform();
                    eyevec = -gl_Vertex.xyz;
                    normal = gl_Normal;
                }   
            ";

            // compile shaders.
            compileShader(frag, fragSource);
            compileShader(vert, vertSource);

            // attach shaders and link the program.
            GL.AttachShader(shaderProgramSphere, frag);
            GL.AttachShader(shaderProgramSphere, vert);
            GL.LinkProgram(shaderProgramSphere);

            // output link info log.
            string info;
            GL.GetProgramInfoLog(shaderProgramSphere, out info);
            Debug.WriteLine(info);

            // Clean up resources. Note the program object is not deleted.
            if (frag != 0)
                GL.DeleteShader(frag);
            if (vert != 0)
                GL.DeleteShader(vert);
        }

        void initShaderProgramCubemap()
        {
            // create a program object.
            shaderProgramCubemap = GL.CreateProgram();
            // create shader objects.
            int vert = GL.CreateShader(ShaderType.VertexShader);
            int frag = GL.CreateShader(ShaderType.FragmentShader);
            int geom = GL.CreateShader(ShaderType.GeometryShaderExt);

            // GLSL for fragment shader.
            // Checkerboard :)
            String fragSource = @"
                #version 120
                #extension GL_EXT_gpu_shader4 : enable

                void main( void )
                {
                    float s = gl_TexCoord[0].s * 6.28 * 8.0;
                    float t = gl_TexCoord[0].t * 6.28 * 8.0;
                    gl_FragColor = gl_TexCoord[2] * vec4(sign(cos(s)+cos(t)))/* * gl_TexCoord[1]*/;
//                  gl_FragColor = gl_TexCoord[1];
                }   
            ";

            // GLSL for vertex shader.
            String vertSource = @"
                #version 120
                #extension GL_EXT_gpu_shader4 : enable

                //varying vec4 p[2];
                //varying vec4 nx;

                void main( void )
                {
                    gl_Position = gl_Vertex;
                    gl_TexCoord[2] = normalize(gl_Vertex)*0.5+0.5;
                    gl_TexCoord[0] = gl_MultiTexCoord0;
                }
            ";

            // GLSL for geometry shader.
            String geomSource = @"
                #version 120
                #extension GL_EXT_geometry_shader4 : enable
                #extension GL_EXT_gpu_shader4 : enable
                uniform mat4 matrixPX;
                uniform mat4 matrixNX;
                uniform mat4 matrixPY;
                uniform mat4 matrixNY;
                uniform mat4 matrixPZ;
                uniform mat4 matrixNZ;

                void main(void) {
                    int i, layer;
                    gl_Layer = 0;
                    gl_TexCoord[1] = vec4(1, 0, 0, 1);
                    for (i = 0; i < gl_VerticesIn; i++) {
                            gl_Position = matrixPX * gl_PositionIn[i];
                            gl_TexCoord[0] = gl_TexCoordIn[i][0];
                            gl_TexCoord[2] = gl_TexCoordIn[i][2];
                            EmitVertex();
                    }
                    EndPrimitive();
                    gl_Layer = 1;
                    gl_TexCoord[1] = vec4(0, 0, 1, 1);
                    for (i = 0; i < gl_VerticesIn; i++) {
                            gl_Position = matrixNX * gl_PositionIn[i];
                            gl_TexCoord[0] = gl_TexCoordIn[i][0];
                            gl_TexCoord[2] = gl_TexCoordIn[i][2];
                            EmitVertex();
                    }
                    EndPrimitive();
                    gl_Layer = 2;
                    gl_TexCoord[1] = vec4(0, 1, 0, 1);
                    for (i = 0; i < gl_VerticesIn; i++) {
                            gl_Position = matrixPY* gl_PositionIn[i];
                            gl_TexCoord[0] = gl_TexCoordIn[i][0];
                            gl_TexCoord[2] = gl_TexCoordIn[i][2];
                            EmitVertex();
                    }
                    EndPrimitive();
                    gl_Layer = 3;
                    gl_TexCoord[1] = vec4(1, 1, 0, 1);
                    for (i = 0; i < gl_VerticesIn; i++) {
                            gl_Position = matrixNY * gl_PositionIn[i];
                            gl_TexCoord[0] = gl_TexCoordIn[i][0];
                            gl_TexCoord[2] = gl_TexCoordIn[i][2];
                            EmitVertex();
                    }
                    EndPrimitive();
                    gl_Layer = 4;
                    gl_TexCoord[1] = vec4(1, 1, 1, 1);
                    for (i = 0; i < gl_VerticesIn; i++) {
                            gl_Position = matrixPZ * gl_PositionIn[i];
                            gl_TexCoord[0] = gl_TexCoordIn[i][0];
                            gl_TexCoord[2] = gl_TexCoordIn[i][2];
                            EmitVertex();
                    }
                    EndPrimitive();
                    gl_Layer = 5;
                    gl_TexCoord[1] = vec4(1, 0, 1, 1);
                    for (i = 0; i < gl_VerticesIn; i++) {
                            gl_Position = matrixNZ * gl_PositionIn[i];
                            gl_TexCoord[0] = gl_TexCoordIn[i][0];
                            gl_TexCoord[2] = gl_TexCoordIn[i][2];
                            EmitVertex();
                    }
                    EndPrimitive();
                }
            ";

            // compile shaders.
            compileShader(frag, fragSource);
            compileShader(vert, vertSource);
            compileShader(geom, geomSource);

            int tmp;
            GL.GetInteger((GetPName)ExtGeometryShader4.MaxGeometryOutputVerticesExt, out tmp);
            GL.Ext.ProgramParameter(shaderProgramCubemap, ExtGeometryShader4.GeometryVerticesOutExt, 18);

            GL.Ext.ProgramParameter(shaderProgramCubemap, ExtGeometryShader4.GeometryInputTypeExt, (int)All.Triangles);
            GL.Ext.ProgramParameter(shaderProgramCubemap, ExtGeometryShader4.GeometryOutputTypeExt, (int)All.TriangleStrip);

            // attach shaders and link the program.
            GL.AttachShader(shaderProgramCubemap, frag);
            GL.AttachShader(shaderProgramCubemap, vert);
            GL.AttachShader(shaderProgramCubemap, geom);
            GL.LinkProgram(shaderProgramCubemap);

            // output link info log.
            string info;
            GL.GetProgramInfoLog(shaderProgramCubemap, out info);
            Debug.WriteLine(info);

            // Clean up resources. Note the program object is not deleted.
            if (frag != 0)
                GL.DeleteShader(frag);
            if (vert != 0)
                GL.DeleteShader(vert);
            if (geom != 0)
                GL.DeleteShader(geom);
        }

        /// <summary>
        /// Helper method to avoid code duplication.
        /// Compiles a shader and prints results using Debug.WriteLine.
        /// </summary>
        /// <param name="shader">A shader object, gotten from GL.CreateShader.</param>
        /// <param name="source">The GLSL source to compile.</param>
        void compileShader(int shader, string source)
        {
            GL.ShaderSource(shader, source);
            GL.CompileShader(shader);

            string info;
            GL.GetShaderInfoLog(shader, out info);
            Debug.WriteLine(info);

            int compileResult;
            GL.GetShader(shader, ShaderParameter.CompileStatus, out compileResult);
            if (compileResult != 1)
            {
                Debug.WriteLine("Compile Error!");
                Debug.WriteLine(source);
            }
        }

        void initTextureCube()
        {
            textureCubeColor = GL.GenTexture();
            GL.BindTexture(TextureTarget.TextureCubeMap, textureCubeColor);
            GL.TexParameter(TextureTarget.TextureCubeMap, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.TextureCubeMap, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);
            GL.TexParameter(TextureTarget.TextureCubeMap, TextureParameterName.TextureWrapS, (int)TextureWrapMode.ClampToEdge);
            GL.TexParameter(TextureTarget.TextureCubeMap, TextureParameterName.TextureWrapT, (int)TextureWrapMode.ClampToEdge);
            GL.TexParameter(TextureTarget.TextureCubeMap, TextureParameterName.TextureWrapR, (int)TextureWrapMode.ClampToEdge);
            foreach (TextureTarget target in new TextureTarget[] {
                TextureTarget.TextureCubeMapPositiveX,
                TextureTarget.TextureCubeMapNegativeX,
                TextureTarget.TextureCubeMapPositiveY,
                TextureTarget.TextureCubeMapNegativeY,
                TextureTarget.TextureCubeMapPositiveZ,
                TextureTarget.TextureCubeMapNegativeZ,
            })
            {
                GL.TexImage2D(target, 0, PixelInternalFormat.Rgba8, 512, 512, 0, PixelFormat.Rgba, PixelType.UnsignedByte, IntPtr.Zero);
            }

            /*
            GL.BindTexture(TextureTarget.TextureCubeMap, textureCubeDepth);
            GL.TexParameter(TextureTarget.TextureCubeMap, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Nearest);
            GL.TexParameter(TextureTarget.TextureCubeMap, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Nearest);
            GL.TexParameter(TextureTarget.TextureCubeMap, TextureParameterName.TextureWrapS, (int)TextureWrapMode.ClampToEdge);
            GL.TexParameter(TextureTarget.TextureCubeMap, TextureParameterName.TextureWrapT, (int)TextureWrapMode.ClampToEdge);
            GL.TexParameter(TextureTarget.TextureCubeMap, TextureParameterName.TextureWrapR, (int)TextureWrapMode.ClampToEdge);
            foreach (TextureTarget target in new TextureTarget[] {
                TextureTarget.TextureCubeMapPositiveX,
                TextureTarget.TextureCubeMapNegativeX,
                TextureTarget.TextureCubeMapPositiveY,
                TextureTarget.TextureCubeMapNegativeY,
                TextureTarget.TextureCubeMapPositiveZ,
                TextureTarget.TextureCubeMapNegativeZ,
            }) {
                GL.TexImage2D(target, 0, (PixelInternalFormat)All.DepthComponent32, 512, 512, 0, PixelFormat.DepthComponent, PixelType.UnsignedInt, IntPtr.Zero);
            }
            */
            GL.Ext.GenFramebuffers(1, out textureCubeFBO);
            GL.Ext.GenRenderbuffers(1, out textureCubeDepth);

            GL.Ext.BindFramebuffer(FramebufferTarget.FramebufferExt, textureCubeFBO);
            GL.Ext.FramebufferTexture(FramebufferTarget.FramebufferExt, FramebufferAttachment.ColorAttachment0Ext, textureCubeColor, 0);

            //GL.Ext.BindRenderbuffer(RenderbufferTarget.RenderbufferExt, textureCubeDepth);
            //GL.Ext.RenderbufferStorage(RenderbufferTarget.RenderbufferExt, (RenderbufferStorage)All.DepthComponent24, 512, 512);
            //GL.Ext.FramebufferRenderbuffer(FramebufferTarget.FramebufferExt, FramebufferAttachment.DepthAttachmentExt, RenderbufferTarget.RenderbufferExt, textureCubeDepth);

            #region Test for Error
            FramebufferErrorCode e = GL.Ext.CheckFramebufferStatus(FramebufferTarget.FramebufferExt);
            switch (e)
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
                /*               case  FramebufferErrorCode.GL_FRAMEBUFFER_INCOMPLETE_DUPLICATE_ATTACHMENT_EXT: 
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
                case (FramebufferErrorCode)All.FramebufferIncompleteLayerTargetsExt:
                    {
                        Console.WriteLine("FBO: Framebuffer Incomplete Layer Targets.");
                        break;
                    }
                case (FramebufferErrorCode)All.FramebufferIncompleteLayerCountExt:
                    {
                        Console.WriteLine("FBO: Framebuffer Incomplete Layer Count.");
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

            GL.Ext.BindFramebuffer(FramebufferTarget.FramebufferExt, 0); // disable rendering into the FBO
        }

        void initVBOCube()
        {
            GL.GenBuffers(1, out vboCube);
            // vertex 3 floats
            // normal 3 floats
            // texcoord 2 floats
            // 3+3+2=8 floats = 8*4 = 32 bytes
            vboCubeStride = 32;
            GL.BindBuffer(BufferTarget.ArrayBuffer, vboCube);
            GL.BufferData(BufferTarget.ArrayBuffer, new IntPtr(cubeData.Length * vboCubeStride), cubeData, BufferUsageHint.StaticDraw);
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
        }

        void initVBOSpere()
        {
            VertexPositionNormalTexture[] sphereVertices = CalculateSphereVertices(1, 1, 16, 16);
            ushort[] sphereElements = CalculateSphereElements(1, 1, 16, 16);
            sphereElementCount = sphereElements.Length;

            GL.GenBuffers(1, out vboSphere);
            GL.BindBuffer(BufferTarget.ArrayBuffer, vboSphere);
            GL.BufferData(BufferTarget.ArrayBuffer, new IntPtr(BlittableValueType.StrideOf(sphereVertices) * sphereVertices.Length), sphereVertices, BufferUsageHint.StaticDraw);

            GL.GenBuffers(1, out eboSphere);
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, eboSphere);
            GL.BufferData(BufferTarget.ElementArrayBuffer, new IntPtr(BlittableValueType.StrideOf(sphereElements) * sphereElements.Length), sphereElements, BufferUsageHint.StaticDraw);

            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
        }

        #endregion

        #region perspective

        void setOrtho()
        {
            OpenTK.Matrix4 proj;
            proj = OpenTK.Matrix4.CreateOrthographicOffCenter(-1, 1, -1, 1, 1, -1);
            GL.LoadMatrix(ref proj);
        }

        void setPerspective()
        {
            OpenTK.Matrix4 proj;
            proj = OpenTK.Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, Width / (float)Height, 0.1f, 200f);
            GL.LoadMatrix(ref proj);
        }

        void switchToMode(ViewMode m)
        {
            mode = m;
            // force update of projection matrix by calling OnResize
            this.OnResize(EventArgs.Empty);
        }

        #endregion

        #region render methods

        void drawCubemapCross()
        {
            GL.ClearColor(0.1f, 0.1f, 0.1f, 0.1f);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.PushAttrib(AttribMask.PolygonBit);
            GL.Enable(EnableCap.TextureCubeMap);
            GL.BindTexture(TextureTarget.TextureCubeMap, textureCubeColor);
            GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Fill);

            /*
             * 
             *     +---+
             *     | 4 |
             * +---+---+---+---+
             * | 0 | 1 | 2 | 3 |
             * +---+---+---+---+
             *     | 5 |
             *     +---+
             * 0 -x
             * 1 +z
             * 2 +x
             * 3 -z
             * 4 +y
             * 5 -y
             */


            GL.PushMatrix();
            GL.LoadIdentity();
            GL.Begin(BeginMode.Quads);

            // 0 -x
            GL.TexCoord3(-1.0f, +1.0f, -1.0f);
            GL.Vertex2(-1.0f, +0.3333f);
            GL.TexCoord3(-1.0f, +1.0f, +1.0f);
            GL.Vertex2(-0.5f, +0.3333f);
            GL.TexCoord3(-1.0f, -1.0f, +1.0f);
            GL.Vertex2(-0.5f, -0.3333f);
            GL.TexCoord3(-1.0f, -1.0f, -1.0f);
            GL.Vertex2(-1.0f, -0.3333f);

            // 1 +z
            GL.TexCoord3(-1.0f, +1.0f, +1.0f);
            GL.Vertex2(-0.5f, +0.3333f);
            GL.TexCoord3(+1.0f, +1.0f, +1.0f);
            GL.Vertex2(+0.0f, +0.3333f);
            GL.TexCoord3(+1.0f, -1.0f, +1.0f);
            GL.Vertex2(+0.0f, -0.3333f);
            GL.TexCoord3(-1.0f, -1.0f, +1.0f);
            GL.Vertex2(-0.5f, -0.3333f);

            // 2 +x
            GL.TexCoord3(+1.0f, +1.0f, +1.0f);
            GL.Vertex2(+0.0f, +0.3333f);
            GL.TexCoord3(+1.0f, +1.0f, -1.0f);
            GL.Vertex2(+0.5f, +0.3333f);
            GL.TexCoord3(+1.0f, -1.0f, -1.0f);
            GL.Vertex2(+0.5f, -0.3333f);
            GL.TexCoord3(+1.0f, -1.0f, +1.0f);
            GL.Vertex2(+0.0f, -0.3333f);

            // 3 -z
            GL.TexCoord3(+1.0f, +1.0f, -1.0f);
            GL.Vertex2(+0.5f, +0.3333f);
            GL.TexCoord3(-1.0f, +1.0f, -1.0f);
            GL.Vertex2(+1.0f, +0.3333f);
            GL.TexCoord3(-1.0f, -1.0f, -1.0f);
            GL.Vertex2(+1.0f, -0.3333f);
            GL.TexCoord3(+1.0f, -1.0f, -1.0f);
            GL.Vertex2(+0.5f, -0.3333f);

            // 4 +y
            GL.TexCoord3(-1.0f, +1.0f, -1.0f);
            GL.Vertex2(-0.5f, +1.0f);
            GL.TexCoord3(+1.0f, +1.0, -1.0f);
            GL.Vertex2(+0.0f, +1.0);
            GL.TexCoord3(+1.0f, +1.0f, +1.0f);
            GL.Vertex2(+0.0f, +0.3333f);
            GL.TexCoord3(-1.0f, +1.0f, +1.0f);
            GL.Vertex2(-0.5f, +0.3333f);

            // 5 -y
            GL.TexCoord3(-1.0f, -1.0f, +1.0f);
            GL.Vertex2(-0.5f, -0.3333f);
            GL.TexCoord3(+1.0f, -1.0, +1.0f);
            GL.Vertex2(+0.0f, -0.3333f);
            GL.TexCoord3(+1.0f, -1.0f, -1.0f);
            GL.Vertex2(+0.0f, -1.0f);
            GL.TexCoord3(-1.0f, -1.0f, -1.0f);
            GL.Vertex2(-0.5f, -1.0f);

            GL.End();
            GL.PopMatrix();

            GL.Disable(EnableCap.TextureCubeMap);
            GL.PopAttrib();
        }

        void renderCubeVBO()
        {
            GL.EnableClientState(EnableCap.VertexArray);
            GL.EnableClientState(EnableCap.NormalArray);
            GL.EnableClientState(EnableCap.TextureCoordArray);
            //GL.ClientActiveTexture(TextureUnit.Texture0 + 0);

            GL.BindBuffer(BufferTarget.ArrayBuffer, vboCube);
            GL.VertexPointer(3, VertexPointerType.Float, vboCubeStride, new IntPtr(0));
            GL.NormalPointer(NormalPointerType.Float, vboCubeStride, new IntPtr(Vector3.SizeInBytes));
            GL.TexCoordPointer(2, TexCoordPointerType.Float, vboCubeStride, new IntPtr(Vector3.SizeInBytes + Vector3.SizeInBytes));

            //GL.Arb.DrawArraysInstanced(BeginMode.Triangles, 0, cubeData.Length/8, 1);
            GL.DrawArrays(BeginMode.Triangles, 0, cubeData.Length / (vboCubeStride / sizeof(float)));

            GL.DisableClientState(EnableCap.VertexArray);
            GL.DisableClientState(EnableCap.NormalArray);
            GL.DisableClientState(EnableCap.TextureCoordArray);
        }

        void renderSphereVBO()
        {
            GL.EnableClientState(EnableCap.VertexArray);
            GL.EnableClientState(EnableCap.NormalArray);
            GL.EnableClientState(EnableCap.TextureCoordArray);
            //GL.ClientActiveTexture(TextureUnit.Texture0 + 0);

            GL.BindBuffer(BufferTarget.ArrayBuffer, vboSphere);
            GL.VertexPointer(3, VertexPointerType.Float, vboSphereStride, new IntPtr(0));
            GL.NormalPointer(NormalPointerType.Float, vboSphereStride, new IntPtr(Vector3.SizeInBytes));
            GL.TexCoordPointer(2, TexCoordPointerType.Float, vboSphereStride, new IntPtr(Vector3.SizeInBytes + Vector3.SizeInBytes));

            GL.BindBuffer(BufferTarget.ElementArrayBuffer, eboSphere);
            GL.DrawElements(BeginMode.Triangles, 16 * 16 * 6, DrawElementsType.UnsignedShort, IntPtr.Zero);

            //GL.Arb.DrawArraysInstanced(BeginMode.Triangles, 0, cubeData.Length/8, 1);
            //GL.DrawArrays(BeginMode.Triangles, 0, sphereData.Length / (vboSphereStride / sizeof(float)));

            GL.DisableClientState(EnableCap.VertexArray);
            GL.DisableClientState(EnableCap.NormalArray);
            GL.DisableClientState(EnableCap.TextureCoordArray);
        }

        void renderCubemap()
        {
            GL.Disable(EnableCap.DepthTest);

            // draw onto cubemap FBO using geometry shader
            GL.Ext.BindFramebuffer(FramebufferTarget.FramebufferExt, textureCubeFBO);
            GL.UseProgram(shaderProgramCubemap);
            GL.PushAttrib(AttribMask.ViewportBit);
            {
                GL.Viewport(0, 0, 512, 512);

                // clear all cubemap faces to blue
                GL.ClearColor(0f, 0f, 1f, 0f);
                for (int i = 0; i < 6; i++)
                {
                    GL.Ext.FramebufferTexture2D(FramebufferTarget.FramebufferExt, FramebufferAttachment.ColorAttachment0, TextureTarget.TextureCubeMapPositiveX + i, textureCubeColor, 0);
                    //todo select depth renderbuffer face and trun depth_test on again
                    GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
                }
                GL.Ext.FramebufferTexture(FramebufferTarget.FramebufferExt, FramebufferAttachment.ColorAttachment0, textureCubeColor, 0);
                // Create 6 ModelViewProjection matrices, one to look in each direction
                // proj with 90 degrees (1/2 pi) fov
                // translate negative to place cam insize sphere
                Matrix4 model = Matrix4.Scale(-1) * Matrix4.CreateTranslation(spherePos);
                Matrix4 proj = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver2, 1, 0.1f, 100f);

                Matrix4[] m = new Matrix4[6];

                m[0] = model * Matrix4.LookAt(Vector3.Zero, Vector3.UnitX, -Vector3.UnitY) * proj;
                m[1] = model * Matrix4.LookAt(Vector3.Zero, -Vector3.UnitX, -Vector3.UnitY) * proj;
                m[2] = model * Matrix4.LookAt(Vector3.Zero, Vector3.UnitY, Vector3.UnitZ) * proj;
                m[3] = model * Matrix4.LookAt(Vector3.Zero, -Vector3.UnitY, -Vector3.UnitZ) * proj;
                m[4] = model * Matrix4.LookAt(Vector3.Zero, Vector3.UnitZ, -Vector3.UnitY) * proj;
                m[5] = model * Matrix4.LookAt(Vector3.Zero, -Vector3.UnitZ, -Vector3.UnitY) * proj;
                GL.UniformMatrix4(GL.GetUniformLocation(shaderProgramCubemap, "matrixPX"), false, ref m[0]);
                GL.UniformMatrix4(GL.GetUniformLocation(shaderProgramCubemap, "matrixNX"), false, ref m[1]);
                GL.UniformMatrix4(GL.GetUniformLocation(shaderProgramCubemap, "matrixPY"), false, ref m[2]);
                GL.UniformMatrix4(GL.GetUniformLocation(shaderProgramCubemap, "matrixNY"), false, ref m[3]);
                GL.UniformMatrix4(GL.GetUniformLocation(shaderProgramCubemap, "matrixPZ"), false, ref m[4]);
                GL.UniformMatrix4(GL.GetUniformLocation(shaderProgramCubemap, "matrixNZ"), false, ref m[5]);


                renderCubeVBO();
            }
            GL.PopAttrib();
            GL.Ext.BindFramebuffer(FramebufferTarget.FramebufferExt, 0);
            GL.UseProgram(0);
            GL.Enable(EnableCap.DepthTest);
        }

        void renderScene()
        {
            GL.MatrixMode(MatrixMode.Projection);
            GL.PushMatrix();
            setPerspective();
            GL.MatrixMode(MatrixMode.Modelview);
            GL.PushMatrix();
            Matrix4 lookat = Matrix4.LookAt(eyePos, eyeLookat, Vector3.UnitY);
            GL.LoadMatrix(ref lookat);


            GL.UseProgram(shaderProgramBox);
            renderCubeVBO();
            GL.UseProgram(shaderProgramSphere);
            GL.BindTexture(TextureTarget.TextureCubeMap, textureCubeColor);
            GL.Uniform1(GL.GetUniformLocation(shaderProgramSphere, "tex"), 0);
            GL.Translate(spherePos);
            GL.Enable(EnableCap.DepthTest);
            renderSphereVBO();
            GL.UseProgram(0);

            GL.MatrixMode(MatrixMode.Projection);
            GL.PopMatrix();
            GL.MatrixMode(MatrixMode.Modelview);
            GL.PopMatrix();
        }

        #endregion

        #region overrides

        protected override void OnLoad(EventArgs e)
        {
            if (!GL.GetString(StringName.Extensions).Contains("EXT_geometry_shader4"))
            {
                System.Windows.Forms.MessageBox.Show(
                     "Your video card does not support EXT_geometry_shader4. Please update your drivers.",
                     "EXT_geometry_shader4 not supported",
                     System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
                Exit();
            }

            //int tmp;
            //GL.GetInteger(GetPName.MaxVertexUniformComponents, out tmp);
            //0x0400
            // 6 * 4x4 mat (0x10) = 0x60

            // init shaders
            initShaderProgramBox();
            initShaderProgramSphere();
            initShaderProgramCubemap();
            // init textures / fbos
            initTextureCube();
            // init vbos
            initVBOCube();
            initVBOSpere();

            //switchToMode(ViewMode.Scene);

        }

        protected override void OnUnload(EventArgs e)
        {
            if (shaderProgramBox != 0)
                GL.DeleteProgram(shaderProgramBox);
            if (shaderProgramSphere != 0)
                GL.DeleteProgram(shaderProgramSphere);
            if (shaderProgramCubemap != 0)
                GL.DeleteProgram(shaderProgramCubemap);
            if (textureCubeColor != 0)
                GL.DeleteTexture(textureCubeColor);
            if (textureCubeDepth != 0)
                GL.DeleteTexture(textureCubeDepth);
            if (textureCubeFBO != 0)
                GL.DeleteFramebuffers(1, ref textureCubeFBO);
            base.OnUnload(e);
        }

        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);

            // Set projection matrix
            GL.MatrixMode(MatrixMode.Projection);
            switch (mode)
            {
                case ViewMode.CubemapCross:
                    setOrtho();
                    break;
                case ViewMode.Scene:
                    setPerspective();
                    break;
                default:
                    GL.LoadIdentity();
                    break;
            }

            // Set selector state back to ModelView matrix mode
            GL.MatrixMode(MatrixMode.Modelview);
            base.OnResize(e);

        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            // elapsed time in ms since last start
            double elapsed = (DateTime.Now - startTime).TotalMilliseconds;

            spherePos.X = (float)Math.Sin(elapsed / 5000) * 3;
            spherePos.Z = (float)Math.Cos(elapsed / 5000) * 3;
            eyePos.X = (float)Math.Cos(elapsed / 3000) * 8;
            eyePos.Z = (float)Math.Sin(elapsed / 2000) * 8;

            if (Keyboard[Key.Space])
            {
                ErrorCode err = GL.GetError();
                //Console.WriteLine(err + "  " + Glu.ErrorString((GluErrorCode)err));
                Console.WriteLine("GL error code: {0}", err);
            }
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            if (mode == ViewMode.CubemapCross)
            {
                renderCubemap();
                drawCubemapCross();
            }
            if (mode == ViewMode.Scene)
            {
                renderCubemap();
                GL.ClearColor(0.1f, 0.1f, 0.1f, 0.1f);
                GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
                renderScene();
            }

            this.SwapBuffers();
        }

        #endregion

        #region public static void Main()

        /// <summary>
        /// Entry point of this example.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            using (SimpleGeometryShader2 example = new SimpleGeometryShader2())
            {
                Utilities.SetWindowTitle(example);
                example.Run(60.0, 0.0);
            }
        }

        #endregion

        #region data
        //structure: vec3 pos, vec3 normal, vec2 texcoord
        static float[] cubeData = {
            -10,-10,-10, 0,0,-10, 1.0f,0.0f,
            -10,10,-10, 0,0,-10, 1.0f,1.0f,
            10,10,-10, 0,0,-10, 0.0f,1.0f,

            10,10,-10, 0,0,-10, 0.0f,1.0f,
            10,-10,-10, 0,0,-10, 0.0f,0.0f,
            -10,-10,-10, 0,0,-10, 1.0f,0.0f,

            -10,-10,10, 0,0,10, 0.0f,0.0f,
            10,-10,10, 0,0,10, 1.0f,0.0f,
            10,10,10, 0,0,10, 1.0f,1.0f,

            10,10,10, 0,0,10, 1.0f,1.0f,
            -10,10,10, 0,0,10, 0.0f,1.0f,
            -10,-10,10, 0,0,10, 0.0f,0.0f,

            -10,-10,-10, 0,-10,0, 0.0f,0.0f,
            10,-10,-10, 0,-10,0, 1.0f,0.0f,
            10,-10,10, 0,-10,0, 1.0f,1.0f,

            10,-10,10, 0,-10,0, 1.0f,1.0f,
            -10,-10,10, 0,-10,0, 0.0f,1.0f,
            -10,-10,-10, 0,-10,0, 0.0f,0.0f,

            10,-10,-10, 10,0,0, 0.0f,0.0f,
            10,10,-10, 10,0,0, 1.0f,0.0f,
            10,10,10, 10,0,0, 1.0f,1.0f,

            10,10,10, 10,0,0, 1.0f,1.0f,
            10,-10,10, 10,0,0, 0.0f,1.0f,
            10,-10,-10, 10,0,0, 0.0f,0.0f,

            10,10,-10, 0,10,0, 0.0f,0.0f,
            -10,10,-10, 0,10,0, 1.0f,0.0f,
            -10,10,10, 0,10,0, 1.0f,1.0f,

            -10,10,10, 0,10,0, 1.0f,1.0f,
            10,10,10, 0,10,0, 0.0f,1.0f,
            10,10,-10, 0,10,0, 0.0f,0.0f,

            -10,10,-10, -10,0,0, 0.0f,0.0f,
            -10,-10,-10, -10,0,0, 1.0f,0.0f,
            -10,-10,10, -10,0,0, 1.0f,1.0f,

            -10,-10,10, -10,0,0, 1.0f,1.0f,
            -10,10,10, -10,0,0, 0.0f,1.0f,
            -10,10,-10, -10,0,0, 0.0f,0.0f,
        };

        static VertexPositionNormalTexture[] CalculateSphereVertices(float radius, float height, byte segments, byte rings)
        {
            VertexPositionNormalTexture[] data = new VertexPositionNormalTexture[segments * rings];

            int i = 0;

            for (double y = 0; y < rings; y++)
            {
                double phi = (y / (rings - 1)) * Math.PI;
                for (double x = 0; x < segments; x++)
                {
                    double theta = (x / (segments - 1)) * 2 * Math.PI;

                    Vector3 v = new Vector3(
                        (float)(radius * Math.Sin(phi) * Math.Cos(theta)),
                        (float)(height * Math.Cos(phi)),
                        (float)(radius * Math.Sin(phi) * Math.Sin(theta)));
                    Vector3 n = Vector3.Normalize(v);
                    Vector2 uv = new Vector2(
                        (float)(x / (segments - 1)),
                        (float)(y / (rings - 1)));
                    // Using data[i++] causes i to be incremented multiple times in Mono 2.2 (bug #479506).
                    data[i] = new VertexPositionNormalTexture(v, n, uv);
                    i++;
                }

            }

            return data;
        }

        static ushort[] CalculateSphereElements(float radius, float height, byte segments, byte rings)
        {
            int num_vertices = segments * rings;
            ushort[] data = new ushort[num_vertices * 6];

            ushort i = 0;

            for (byte y = 0; y < rings - 1; y++)
            {
                for (byte x = 0; x < segments - 1; x++)
                {
                    data[i++] = (ushort)((y + 0) * segments + x);
                    data[i++] = (ushort)((y + 1) * segments + x);
                    data[i++] = (ushort)((y + 1) * segments + x + 1);

                    data[i++] = (ushort)((y + 1) * segments + x + 1);
                    data[i++] = (ushort)((y + 0) * segments + x + 1);
                    data[i++] = (ushort)((y + 0) * segments + x);
                }
            }

            // Verify that we don't access any vertices out of bounds:
            foreach (int index in data)
                if (index >= segments * rings)
                    throw new IndexOutOfRangeException();

            return data;
        }

        #endregion
    }
}