// This code was written for the OpenTK library and has been released
// to the Public Domain.
// It is provided "as is" without express or implied warranty of any kind.

using System;
using System.Drawing;
using System.Collections.Generic;
using System.Diagnostics;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace Examples.Tutorial
{
    [Example( "OpenGL Diagnostics", ExampleCategory.OpenGL, "1.x", Documentation = "OpenGLDiagnostics" )]

    class GLDiagnostics : GameWindow
    {
        /// <summary>Creates a 800x600 window with the specified title.</summary>
        public GLDiagnostics()
            : base(80, 60, GraphicsMode.Default, "OpenTK Quick Start Sample", GameWindowFlags.Default, DisplayDevice.Default, 3, 1, GraphicsContextFlags.Default)
        {
            VSync = VSyncMode.On;
            this.Context.ErrorChecking = false;
        }

        struct TexFormat
        {
            public PixelInternalFormat pif;
            public PixelFormat pf;
            public PixelType pt;

            public TexFormat(PixelInternalFormat _pif, PixelFormat _pf, PixelType _pt)
            {
                pif = _pif;
                pf = _pf;
                pt = _pt;
            }
        }

        TexFormat[] TextureFormats = new TexFormat[]
        {        
            new TexFormat( PixelInternalFormat.Alpha, PixelFormat.Alpha, PixelType.UnsignedByte),
            new TexFormat( PixelInternalFormat.Alpha4, PixelFormat.Alpha, PixelType.UnsignedByte),
            new TexFormat( PixelInternalFormat.Alpha8, PixelFormat.Alpha, PixelType.UnsignedByte),
            new TexFormat( PixelInternalFormat.Alpha12, PixelFormat.Alpha, PixelType.UnsignedByte),
            new TexFormat( PixelInternalFormat.Alpha16, PixelFormat.Alpha, PixelType.UnsignedByte),
            new TexFormat( (PixelInternalFormat)All.Alpha16fArb, PixelFormat.Alpha, PixelType.HalfFloat),
            new TexFormat( (PixelInternalFormat)All.Alpha32fArb, PixelFormat.Alpha, PixelType.Float),

            new TexFormat( PixelInternalFormat.DepthComponent, PixelFormat.DepthComponent, PixelType.Int),
            new TexFormat( PixelInternalFormat.DepthComponent16, PixelFormat.DepthComponent, PixelType.Float),
            new TexFormat( PixelInternalFormat.DepthComponent24, PixelFormat.DepthComponent, PixelType.Float),
            new TexFormat( PixelInternalFormat.DepthComponent32, PixelFormat.DepthComponent, PixelType.Float), 
            new TexFormat( PixelInternalFormat.DepthComponent32f, PixelFormat.DepthComponent, PixelType.Float),  
            new TexFormat( PixelInternalFormat.DepthStencil, PixelFormat.DepthStencil, PixelType.UnsignedInt248),
            new TexFormat( PixelInternalFormat.Depth24Stencil8, PixelFormat.DepthStencil, PixelType.UnsignedInt248),
            new TexFormat( PixelInternalFormat.Depth32fStencil8, PixelFormat.DepthStencil, PixelType.Float32UnsignedInt248Rev),

            new TexFormat( PixelInternalFormat.One, PixelFormat.Red, PixelType.UnsignedByte),
            new TexFormat( PixelInternalFormat.Two, PixelFormat.Rg, PixelType.UnsignedByte),
            new TexFormat( PixelInternalFormat.Rgb, PixelFormat.Rgb, PixelType.UnsignedByte),
            new TexFormat( PixelInternalFormat.Rgba, PixelFormat.Rgba, PixelType.UnsignedByte),

            new TexFormat( PixelInternalFormat.Srgb, PixelFormat.Rgb, PixelType.UnsignedByte),
            new TexFormat( PixelInternalFormat.SrgbAlpha, PixelFormat.Rgb, PixelType.UnsignedByte),
            new TexFormat( PixelInternalFormat.Srgb8, PixelFormat.Rgb, PixelType.UnsignedByte),
            new TexFormat( PixelInternalFormat.Srgb8Alpha8, PixelFormat.Rgba, PixelType.UnsignedByte),

            new TexFormat( PixelInternalFormat.R16f, PixelFormat.Red, PixelType.HalfFloat),
            new TexFormat( PixelInternalFormat.Rg16f, PixelFormat.Rg, PixelType.HalfFloat),
            new TexFormat( PixelInternalFormat.Rgb16f, PixelFormat.Rgb, PixelType.HalfFloat),
            new TexFormat( PixelInternalFormat.Rgba16f, PixelFormat.Rgba, PixelType.HalfFloat),
            new TexFormat( PixelInternalFormat.R32f, PixelFormat.Red, PixelType.Float),
            new TexFormat( PixelInternalFormat.Rg32f, PixelFormat.Rg, PixelType.Float),
            new TexFormat( PixelInternalFormat.Rgb32f, PixelFormat.Rgb, PixelType.Float),
            new TexFormat( PixelInternalFormat.Rgba32f, PixelFormat.Rgba, PixelType.Float), 

            new TexFormat( PixelInternalFormat.R8, PixelFormat.Red, PixelType.UnsignedByte),
            new TexFormat( PixelInternalFormat.Rg8, PixelFormat.Rg, PixelType.UnsignedByte),
            new TexFormat( PixelInternalFormat.Rgb8, PixelFormat.Rgb, PixelType.UnsignedByte),
            new TexFormat( PixelInternalFormat.Rgba8, PixelFormat.Rgba, PixelType.UnsignedByte),

            new TexFormat( PixelInternalFormat.R8ui, PixelFormat.Red, PixelType.UnsignedByte),
            new TexFormat( PixelInternalFormat.Rg8ui, PixelFormat.Rg, PixelType.UnsignedByte),
            new TexFormat( PixelInternalFormat.Rgb8ui, PixelFormat.Rgb, PixelType.UnsignedByte),
            new TexFormat( PixelInternalFormat.Rgba8ui, PixelFormat.Rgba, PixelType.UnsignedByte),
            new TexFormat( PixelInternalFormat.R16ui, PixelFormat.Red, PixelType.UnsignedShort),
            new TexFormat( PixelInternalFormat.Rg16ui, PixelFormat.Rg, PixelType.UnsignedShort),
            new TexFormat( PixelInternalFormat.Rgb16ui, PixelFormat.Rgb, PixelType.UnsignedShort),
            new TexFormat( PixelInternalFormat.Rgba16ui, PixelFormat.Rgba, PixelType.UnsignedShort),
            new TexFormat( PixelInternalFormat.R32ui, PixelFormat.Red, PixelType.UnsignedInt),
            new TexFormat( PixelInternalFormat.Rg32ui, PixelFormat.Rg, PixelType.UnsignedInt),
            new TexFormat( PixelInternalFormat.Rgb32ui, PixelFormat.Rgb, PixelType.UnsignedInt),
            new TexFormat( PixelInternalFormat.Rgba32ui, PixelFormat.Rgba, PixelType.UnsignedInt),

            new TexFormat( PixelInternalFormat.R8i, PixelFormat.Red, PixelType.Byte),
            new TexFormat( PixelInternalFormat.Rg8i, PixelFormat.Rg, PixelType.Byte),
            new TexFormat( PixelInternalFormat.Rgb8i, PixelFormat.Rgb, PixelType.Byte),
            new TexFormat( PixelInternalFormat.Rgba8i, PixelFormat.Rgba, PixelType.Byte),
            new TexFormat( PixelInternalFormat.R16i, PixelFormat.Red, PixelType.Short),
            new TexFormat( PixelInternalFormat.Rg16i, PixelFormat.Rg, PixelType.Short),
            new TexFormat( PixelInternalFormat.Rgb16i, PixelFormat.Rgb, PixelType.Short),
            new TexFormat( PixelInternalFormat.Rgba16i, PixelFormat.Rgba, PixelType.Short),
            new TexFormat( PixelInternalFormat.R32i, PixelFormat.Red, PixelType.Int),
            new TexFormat( PixelInternalFormat.Rg32i, PixelFormat.Rg, PixelType.Int),
            new TexFormat( PixelInternalFormat.Rgb32i, PixelFormat.Rgb, PixelType.Int),
            new TexFormat( PixelInternalFormat.Rgba32i, PixelFormat.Rgba, PixelType.Int),

            new TexFormat( PixelInternalFormat.R3G3B2, PixelFormat.Rgb, PixelType.UnsignedByte),
            new TexFormat( PixelInternalFormat.Rgb10A2, PixelFormat.Rgba, PixelType.UnsignedByte),
            new TexFormat( PixelInternalFormat.Rgb5A1, PixelFormat.Rgb, PixelType.UnsignedByte),
            new TexFormat( PixelInternalFormat.Rgb9E5, PixelFormat.Rgb, PixelType.UnsignedByte),
            new TexFormat( PixelInternalFormat.R11fG11fB10f, PixelFormat.Rgb, PixelType.UnsignedByte),

            new TexFormat( PixelInternalFormat.CompressedAlpha, PixelFormat.Alpha, PixelType.UnsignedByte),
            new TexFormat( PixelInternalFormat.CompressedIntensity, PixelFormat.Luminance, PixelType.UnsignedByte),
            new TexFormat( PixelInternalFormat.CompressedLuminance, PixelFormat.Luminance, PixelType.UnsignedByte),
            new TexFormat( PixelInternalFormat.CompressedLuminanceAlpha, PixelFormat.LuminanceAlpha, PixelType.UnsignedByte),
            new TexFormat( (PixelInternalFormat)All.CompressedLuminanceLatc1Ext, PixelFormat.Luminance, PixelType.UnsignedByte),
            new TexFormat( (PixelInternalFormat)All.CompressedLuminanceAlphaLatc2Ext, PixelFormat.LuminanceAlpha, PixelType.UnsignedByte),

            new TexFormat( PixelInternalFormat.CompressedRed, PixelFormat.Red, PixelType.UnsignedByte),
            new TexFormat( PixelInternalFormat.CompressedRedRgtc1, PixelFormat.Red, PixelType.UnsignedByte),
            new TexFormat( (PixelInternalFormat)All.CompressedRedGreenRgtc2Ext, PixelFormat.Rg, PixelType.UnsignedByte),
            new TexFormat( PixelInternalFormat.CompressedRg, PixelFormat.Rg, PixelType.UnsignedByte), 
            new TexFormat( PixelInternalFormat.CompressedRgRgtc2, PixelFormat.Rg, PixelType.UnsignedByte),
            new TexFormat( PixelInternalFormat.CompressedRgb, PixelFormat.Rgb, PixelType.UnsignedByte), 
            new TexFormat( (PixelInternalFormat)All.CompressedRgbFxt13Dfx, PixelFormat.Rgb, PixelType.UnsignedByte),
            new TexFormat( PixelInternalFormat.CompressedRgba, PixelFormat.Rgba, PixelType.UnsignedByte),
            new TexFormat( (PixelInternalFormat)All.CompressedRgbaFxt13Dfx, PixelFormat.Rgba, PixelType.UnsignedByte),

            new TexFormat( (PixelInternalFormat)All.CompressedSignedLuminanceAlphaLatc2Ext, PixelFormat.LuminanceAlpha, PixelType.UnsignedByte),
            new TexFormat( (PixelInternalFormat)All.CompressedSignedLuminanceLatc1Ext, PixelFormat.Luminance, PixelType.UnsignedByte),
            new TexFormat( PixelInternalFormat.CompressedSignedRedRgtc1, PixelFormat.Red, PixelType.UnsignedByte),  
            new TexFormat( PixelInternalFormat.CompressedSignedRgRgtc2, PixelFormat.Rg, PixelType.UnsignedByte),

            new TexFormat( PixelInternalFormat.CompressedSluminance, PixelFormat.Luminance, PixelType.UnsignedByte),
            new TexFormat( PixelInternalFormat.CompressedSluminanceAlpha, PixelFormat.LuminanceAlpha, PixelType.UnsignedByte),
            new TexFormat( PixelInternalFormat.CompressedSrgb, PixelFormat.Rgb, PixelType.UnsignedByte),
            new TexFormat( PixelInternalFormat.CompressedSrgbAlpha, PixelFormat.Rgba, PixelType.UnsignedByte), 
            new TexFormat( PixelInternalFormat.CompressedSrgbS3tcDxt1Ext, PixelFormat.Rgb, PixelType.UnsignedByte),
            new TexFormat( PixelInternalFormat.CompressedSrgbAlphaS3tcDxt1Ext, PixelFormat.Rgba, PixelType.UnsignedByte),
            new TexFormat( PixelInternalFormat.CompressedSrgbAlphaS3tcDxt3Ext, PixelFormat.Rgba, PixelType.UnsignedByte),
            new TexFormat( PixelInternalFormat.CompressedSrgbAlphaS3tcDxt5Ext, PixelFormat.Rgba, PixelType.UnsignedByte),

            new TexFormat( (PixelInternalFormat)All.CompressedRgbS3tcDxt1Ext, PixelFormat.Rgb, PixelType.UnsignedByte),
            new TexFormat( (PixelInternalFormat)All.CompressedRgbaS3tcDxt1Ext, PixelFormat.Rgba, PixelType.UnsignedByte),
            new TexFormat( (PixelInternalFormat)All.CompressedRgbaS3tcDxt3Ext, PixelFormat.Rgba, PixelType.UnsignedByte),
            new TexFormat( (PixelInternalFormat)All.CompressedRgbaS3tcDxt5Ext, PixelFormat.Rgba, PixelType.UnsignedByte),
          
        };

        #region GL.Get* Helper

        public enum eType
        {
            Boolean,
            Int,
            IntEnum,
            IntArray2,
            IntArray4,
            Float,
            FloatArray2,
            FloatArray4,
        }

        public void Analyze(GetPName pname, eType type)
        {
            bool result1b;
            int result1i;
            int[] result2i = new int[2];
            int[] result4i = new int[4];
            float result1f;
            Vector2 result2f;
            Vector4 result4f;
            string output;

            switch (type)
            {
                case eType.Boolean:
                    GL.GetBoolean(pname, out result1b);
                    output = pname + ": " + result1b;
                    break;
                case eType.Int:
                    GL.GetInteger(pname, out result1i);
                    output = pname + ": " + result1i;
                    break;
                case eType.IntEnum:
                    GL.GetInteger(pname, out result1i);
                    output = pname + ": " + (All)result1i;
                    break;
                case eType.IntArray2:
                    GL.GetInteger(pname, result2i);
                    output = pname + ": ( " + result2i[0] + ", " + result2i[1] + " )";
                    break;
                case eType.IntArray4:
                    GL.GetInteger(pname, result4i);
                    output = pname + ": ( " + result4i[0] + ", " + result4i[1] + " ) ( " + result4i[2] + ", " + result4i[3] + " )";
                    break;
                case eType.Float:
                    GL.GetFloat(pname, out result1f);
                    output = pname + ": " + result1f;
                    break;
                case eType.FloatArray2:
                    GL.GetFloat(pname, out result2f);
                    output = pname + ": ( " + result2f.X + ", " + result2f.Y + " )";
                    break;
                case eType.FloatArray4:
                    GL.GetFloat(pname, out result4f);
                    output = pname + ": ( " + result4f.X + ", " + result4f.Y + ", " + result4f.Z + ", " + result4f.W + " )";
                    break;
                default: throw new NotImplementedException();
            }

            ErrorCode err = GL.GetError();
            if (err != ErrorCode.NoError)
                Trace.WriteLine("Unsupported Token: " + pname);
            else
                Trace.WriteLine(output);

        }

        #endregion GL.Get* Helper

        /// <summary>Load resources here.</summary>
        /// <param name="e">Not used.</param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GL.ClearColor(System.Drawing.Color.MidnightBlue);
            GL.Enable(EnableCap.DepthTest);

            // returns 0 formats, driver broken?
            /*
            int CompressedTextureFormatCount;
            GL.GetInteger(GetPName.NumCompressedTextureFormats, out CompressedTextureFormatCount);
            if (CompressedTextureFormatCount > 0)
            {
                int[] CompressedTextureFormats = new int[CompressedTextureFormatCount];
                GL.GetInteger(GetPName.CompressedTextureFormats, CompressedTextureFormats);
                Trace.WriteLine("Supported compressed Texture formats:");
                for (int i = 0; i < CompressedTextureFormats.Length; i++)
                    Trace.Write((All)CompressedTextureFormats[i] + ", ");
            }
             */

            string Renderer = GL.GetString(StringName.Renderer);
            string GLSLang = GL.GetString(StringName.ShadingLanguageVersion);
            string Vendor = GL.GetString(StringName.Vendor);
            string Version = GL.GetString(StringName.Version);

            string ExtensionsRaw = GL.GetString(StringName.Extensions);
            string[] splitter = new string[] { " " };
            string[] Extensions = ExtensionsRaw.Split(splitter, StringSplitOptions.None);

            Trace.WriteLine("Vendor: " + Vendor);
            Trace.WriteLine("Renderer: " + Renderer);
            Trace.WriteLine("GL Version: " + Version);
            Analyze(GetPName.MajorVersion, eType.Int);
            Analyze(GetPName.MinorVersion, eType.Int);
            Trace.WriteLine("GLSL Version: " + GLSLang);
            Trace.WriteLine("Extensions: ");
            for (int i = 0; i < Extensions.Length; i++)
                Trace.WriteLine(Extensions[i]);

            Trace.WriteLine("--- Framebuffer ---");
            Analyze(GetPName.Doublebuffer, eType.Boolean);
            Analyze(GetPName.MaxColorAttachments, eType.Int);
            Analyze(GetPName.MaxDrawBuffers, eType.Int);
            Analyze(GetPName.AuxBuffers, eType.Int);
            Analyze(GetPName.DrawBuffer, eType.IntEnum);
            Analyze(GetPName.MaxSamples, eType.Int);
            Analyze(GetPName.MaxViewportDims, eType.IntArray2);
            Analyze(GetPName.Viewport, eType.IntArray4);

            Trace.WriteLine("--- Framebuffer channels ---");
            Analyze(GetPName.RedBits, eType.Int);
            Analyze(GetPName.GreenBits, eType.Int);
            Analyze(GetPName.BlueBits, eType.Int);
            Analyze(GetPName.AlphaBits, eType.Int);
            Analyze(GetPName.DepthBits, eType.Int);
            Analyze(GetPName.StencilBits, eType.Int);

            Analyze(GetPName.AccumRedBits, eType.Int);
            Analyze(GetPName.AccumGreenBits, eType.Int);
            Analyze(GetPName.AccumBlueBits, eType.Int);
            Analyze(GetPName.AccumAlphaBits, eType.Int);

            Trace.WriteLine("--- Textures ---");
            Analyze(GetPName.MaxCombinedTextureImageUnits, eType.Int);
            Analyze(GetPName.MaxVertexTextureImageUnits, eType.Int);
            Analyze(GetPName.MaxTextureImageUnits, eType.Int);
            Analyze(GetPName.MaxTextureUnits, eType.Int);
            Analyze(GetPName.MaxTextureSize, eType.Int);
            Analyze(GetPName.Max3DTextureSize, eType.Int);
            Analyze(GetPName.MaxCubeMapTextureSize, eType.Int);
            Analyze(GetPName.MaxRenderbufferSize, eType.Int);
            Analyze(GetPName.MaxTextureLodBias, eType.Int);

            Queue<TexFormat> Supported = new Queue<TexFormat>();
            Queue<TexFormat> Unsupported = new Queue<TexFormat>();
         
            uint DummyTexture;
            foreach (TexFormat t in TextureFormats)
            {
                GL.GenTextures(1, out DummyTexture);
                GL.BindTexture(TextureTarget.Texture2D, DummyTexture);
                GL.TexImage2D(TextureTarget.Texture2D, 0, t.pif, 4, 4, 0, t.pf, t.pt, IntPtr.Zero);
                if (GL.GetError() == ErrorCode.NoError)
                    Supported.Enqueue(t);
                else
                    Unsupported.Enqueue(t);
                GL.DeleteTextures(1, ref DummyTexture);
            }
            GL.BindTexture(TextureTarget.Texture2D, 0);

            Trace.WriteLine("--- UN-supported Texture formats ---");
            while (Unsupported.Count > 0)
            {
                TexFormat tex = Unsupported.Dequeue();
                Trace.Write((All)tex.pif+", ");
            }
            Trace.WriteLine( " " );

            Trace.WriteLine("--- SUPPORTED Texture formats ---");
            while (Supported.Count > 0)
            {
                TexFormat tex = Supported.Dequeue();
                Trace.WriteLine((All)tex.pif+"   " +tex.pf + "  "+tex.pt);
            }
            Trace.WriteLine(" ");

            Trace.WriteLine("--- Point&Line volumes ---");
            Analyze(GetPName.AliasedPointSizeRange, eType.FloatArray2);
            Analyze(GetPName.PointSizeMin, eType.Float);
            Analyze(GetPName.PointSizeMax, eType.Float);
            Analyze(GetPName.PointSizeGranularity, eType.Float);
            Analyze(GetPName.PointSizeRange, eType.FloatArray2);

            Analyze(GetPName.AliasedLineWidthRange, eType.FloatArray2);
            Analyze(GetPName.LineWidthGranularity, eType.Float);
            Analyze(GetPName.LineWidthRange, eType.FloatArray2);

            Trace.WriteLine("--- VBO ---");
            Analyze(GetPName.MaxElementsIndices, eType.Int);
            Analyze(GetPName.MaxElementsVertices, eType.Int);
            Analyze(GetPName.MaxVertexAttribs, eType.Int);

            Trace.WriteLine("--- GLSL ---");
            Analyze(GetPName.MaxCombinedFragmentUniformComponents, eType.Int);
            Analyze(GetPName.MaxCombinedGeometryUniformComponents, eType.Int);
            Analyze(GetPName.MaxCombinedVertexUniformComponents, eType.Int);
            Analyze(GetPName.MaxFragmentUniformComponents, eType.Int);
            Analyze(GetPName.MaxVertexUniformComponents, eType.Int);

            Analyze(GetPName.MaxCombinedUniformBlocks, eType.Int);
            Analyze(GetPName.MaxFragmentUniformBlocks, eType.Int);
            Analyze(GetPName.MaxGeometryUniformBlocks, eType.Int);
            Analyze(GetPName.MaxVertexUniformBlocks, eType.Int);
            Analyze(GetPName.MaxUniformBlockSize, eType.Int);
            Analyze(GetPName.MaxUniformBufferBindings, eType.Int);

            Analyze(GetPName.MaxVaryingFloats, eType.Int);

            Trace.WriteLine("--- Transform Feedback ---");
            Analyze(GetPName.MaxTransformFeedbackInterleavedComponents, eType.Int);
            Analyze(GetPName.MaxTransformFeedbackSeparateAttribs, eType.Int);
            Analyze(GetPName.MaxTransformFeedbackSeparateComponents, eType.Int);

            Trace.WriteLine("--- Fixed-Func Stacks, GL.Push* and GL.Pop* ---");
            Analyze(GetPName.MaxClientAttribStackDepth, eType.Int);
            Analyze(GetPName.MaxAttribStackDepth, eType.Int);
            Analyze(GetPName.MaxProjectionStackDepth, eType.Int);
            Analyze(GetPName.MaxModelviewStackDepth, eType.Int);
            Analyze(GetPName.MaxTextureStackDepth, eType.Int);
            Analyze(GetPName.MaxNameStackDepth, eType.Int);

            Trace.WriteLine("--- Fixed-Func misc. stuff ---");
            Analyze(GetPName.MaxEvalOrder, eType.Int);
            Analyze(GetPName.MaxClipPlanes, eType.Int);
            Analyze(GetPName.MaxArrayTextureLayers, eType.Int);
            Analyze(GetPName.MaxListNesting, eType.Int);
            Analyze(GetPName.MaxLights, eType.Int);
            Analyze(GetPName.MaxTextureCoords, eType.Int);

            this.Exit();
        }

        /// <summary>
        /// Called when your window is resized. Set your viewport here. It is also
        /// a good place to set up your projection matrix (which probably changes
        /// along when the aspect ratio of your window).
        /// </summary>
        /// <param name="e">Not used.</param>
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            GL.Viewport(ClientRectangle);
        }

        /// <summary>
        /// Called when it is time to setup the next frame. Add you game logic here.
        /// </summary>
        /// <param name="e">Contains timing information for framerate independent logic.</param>
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            var keyboard = OpenTK.Input.Keyboard.GetState();
            if (keyboard[Key.Escape])
                Exit();
        }

        /// <summary>
        /// Called when it is time to render the next frame. Add your rendering code here.
        /// </summary>
        /// <param name="e">Contains timing information.</param>
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // The 'using' idiom guarantees proper resource cleanup.
            // We request 30 UpdateFrame events per second, and unlimited
            // RenderFrame events (as fast as the computer can handle).
            using (GLDiagnostics game = new GLDiagnostics())
            {
                game.Run(10.0);
            }
        }
    }
}