using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using OpenTK.Platform;
using StbImageSharp;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace BejeweledStandalone
{
    internal class SplashWindow
    {
        static int CompileShader(ShaderType type, string source)
        {
            int shader = GL.CreateShader(type);
            GL.ShaderSource(shader, source);
            GL.CompileShader(shader);
            int success = GL.GetShaderi(shader, ShaderParameterName.CompileStatus);
            if (success == 0)
            {
                GL.GetShaderInfoLog(shader, out string log);
                Bejeweled.Program.Logger.LogError($"{type} shader error: {log}");
            }
            return shader;
        }

        static int CompileProgram(string vertexSource, string fragmentSource)
        {
            int vertex = CompileShader(ShaderType.VertexShader, vertexSource);
            int fragment = CompileShader(ShaderType.FragmentShader, fragmentSource);

            int program = GL.CreateProgram();

            GL.AttachShader(program, vertex);
            GL.AttachShader(program, fragment);

            GL.LinkProgram(program);

            int success = GL.GetProgrami(program, ProgramProperty.LinkStatus);
            if (success == 0)
            {
                GL.GetProgramInfoLog(program, out string log);
                Bejeweled.Program.Logger.LogError($"program link error: {log}");
            }

            GL.DetachShader(program, vertex);
            GL.DetachShader(program, fragment);

            GL.DeleteShader(vertex);
            GL.DeleteShader(fragment);

            return program;
        }

        const string VertexShader =
            """
            #version 330 core

            out vec2 fUV;

            void main()
            {
                float x = -1.0 + float((gl_VertexID & 1) << 2);
                float y = -1.0 + float((gl_VertexID & 2) << 1);
                fUV.x = (x+1.0)*0.5;
                fUV.y = (y+1.0)*0.5;
                gl_Position = vec4(x, y, 0.0, 1.0);
            }
            """;

        const string FragmentShader =
            """
            #version 330 core

            in vec2 fUV;

            out vec4 oColor;

            uniform float uAlphaFactor;
            uniform sampler2D texImage;

            void main()
            {
                vec4 color = texture(texImage, fUV);
                color.a *= uAlphaFactor;
                oColor = color;
            }
            """;

        static int LoadImage(string path)
        {
            StbImage.stbi_set_flip_vertically_on_load(1);
            ImageResult image = ImageResult.FromStream(File.OpenRead(path), ColorComponents.RedGreenBlueAlpha);

            int tex = GL.GenTexture();
            GL.BindTexture(TextureTarget.Texture2d, tex);

            GL.TexImage2D(TextureTarget.Texture2d, 0, InternalFormat.Srgb8Alpha8, image.Width, image.Height, 0, PixelFormat.Rgba, PixelType.UnsignedByte, image.Data);
            GL.GenerateMipmap(TextureTarget.Texture2d);

            GL.TexParameteri(TextureTarget.Texture2d, TextureParameterName.TextureWrapS, (int)TextureWrapMode.ClampToEdge);
            GL.TexParameteri(TextureTarget.Texture2d, TextureParameterName.TextureWrapT, (int)TextureWrapMode.ClampToEdge);

            GL.TexParameteri(TextureTarget.Texture2d, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);
            GL.TexParameteri(TextureTarget.Texture2d, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.LinearMipmapLinear);

            return tex;
        }

        public static void DisplaySplashWindow(float fadeInTime, Task waitTask, float fadeOutTime)
        {
            OpenGLGraphicsApiHints openglHints = new OpenGLGraphicsApiHints()
            {
                Version = new Version(3, 3),
                RedColorBits = 8,
                GreenColorBits = 8,
                BlueColorBits = 8,
                AlphaColorBits = 8,
                DepthBits = 0,
                StencilBits = 0,
                DoubleBuffer = true,
                Multisamples = 0,
                DebugFlag = false,
                ForwardCompatibleFlag = true,
                Profile = OpenGLProfile.Core,
                sRGBFramebuffer = true,
            };

            WindowHandle splashWindow = Toolkit.Window.Create(openglHints);
            DisplayHandle display = Toolkit.Window.GetDisplay(splashWindow);
            Toolkit.Display.GetWorkArea(display, out Box2i workArea);
            Toolkit.Window.SetClientBounds(splashWindow, (workArea.Width - 512) / 2, (workArea.Height - 512) / 2, 512, 512);
            Toolkit.Window.SetBorderStyle(splashWindow, WindowBorderStyle.Borderless);
            Toolkit.Window.SetAlwaysOnTop(splashWindow, true);
            Toolkit.Window.SetTransparencyMode(splashWindow, WindowTransparencyMode.TransparentFramebuffer);
            Toolkit.Window.SetCursor(splashWindow, Toolkit.Cursor.Create(SystemCursorType.Default));

            Toolkit.Window.SetHitTestCallback(splashWindow, SplashWindowHitTest);

            OpenGLContextHandle splashContext = Toolkit.OpenGL.CreateFromWindow(splashWindow);
            Toolkit.OpenGL.SetCurrentContext(splashContext);
            Toolkit.OpenGL.SetSwapInterval(1);

            GLLoader.LoadBindings(Toolkit.OpenGL.GetBindingsContext(splashContext));

            GL.Enable(EnableCap.FramebufferSrgb);
            GL.Enable(EnableCap.Blend);
            GL.BlendFuncSeparate(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha, BlendingFactor.SrcAlpha, BlendingFactor.DstAlpha);
            GL.BlendEquationSeparate(BlendEquationMode.FuncAdd, BlendEquationMode.FuncAdd);

            int VAO = GL.GenVertexArray();
            GL.BindVertexArray(VAO);

            int shader = CompileProgram(VertexShader, FragmentShader);
            GL.UseProgram(shader);

            int splashImage = LoadImage("./Splash/Splash.png");

            int alphaFactorLocation = GL.GetUniformLocation(shader, "uAlphaFactor");

            GL.Uniform1i(GL.GetUniformLocation(shader, "texImage"), 0);
            GL.ActiveTexture(TextureUnit.Texture0);
            GL.BindTexture(TextureTarget.Texture2d, splashImage);

            Toolkit.Window.SetMode(splashWindow, WindowMode.Normal);

            float startFadeOutTime = 0;

            Stopwatch watch = Stopwatch.StartNew();
            while (true)
            {
                Toolkit.Window.ProcessEvents(false);

                GL.ClearColor(new Color4<Rgba>(0, 0, 0, 0));
                GL.Clear(ClearBufferMask.ColorBufferBit);

                float currentTime = (float)watch.Elapsed.TotalSeconds;

                if (currentTime < fadeInTime)
                {
                    float fadeTime = currentTime / fadeInTime;
                    GL.Uniform1f(alphaFactorLocation, fadeTime);
                }
                else if (waitTask.Status == TaskStatus.Running)
                {
                    GL.Uniform1f(alphaFactorLocation, 1);
                }
                else
                {
                    if (startFadeOutTime == 0)
                        startFadeOutTime = currentTime;

                    if (currentTime < startFadeOutTime + fadeOutTime)
                    {
                        float fadeTime = (currentTime - startFadeOutTime) / fadeOutTime;
                        GL.Uniform1f(alphaFactorLocation, 1 - fadeTime);
                    }
                    else
                    {
                        break;
                    }
                }

                GL.DrawArrays(PrimitiveType.Triangles, 0, 3);

                Toolkit.OpenGL.SwapBuffers(splashContext);
            }

            Toolkit.OpenGL.DestroyContext(splashContext);
            Toolkit.Window.Destroy(splashWindow);
        }

        public static HitType SplashWindowHitTest(WindowHandle window, Vector2 pos)
        {
            return HitType.Draggable;
        }
    }
}
