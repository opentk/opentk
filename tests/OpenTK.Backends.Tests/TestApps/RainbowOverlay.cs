using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using OpenTK.Platform;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace OpenTK.Backends.Tests
{
    [TestApp]
    internal class RainbowOverlay : ITestApp
    {
        public static string Name => "Rainbow Overlay";

        public WindowHandle Window;
        public OpenGLContextHandle Context;

        private int VAO;
        private int VBO;

        private int ShaderProgram;
        const string VertexShader = @"#version 450 core

out vec2 f_UV;
 
void main()
{
    float x = -1.0 + float((gl_VertexID & 1) << 2);
    float y = -1.0 + float((gl_VertexID & 2) << 1);
    f_UV.x = (x + 1.0) * 0.5;
    f_UV.y = (y + 1.0) * 0.5;
    gl_Position = vec4(x, y, 0.0, 1.0);
}";
        const string FragmentShader = @"#version 330 core

in vec2 f_UV;

out vec4 color;

uniform float uAlpha;

//Inner radius
#define inner .5
//Outer radius
#define outer 1.2
//Vignette strength/intensity
#define strength .8
//Vignette roundness, higher = smoother, lower = sharper
#define curvature .5

vec3 hsv2rgb(vec3 c)
{
    vec4 K = vec4(1.0, 2.0 / 3.0, 1.0 / 3.0, 3.0);
    vec3 p = abs(fract(c.xxx + K.xyz) * 6.0 - K.www);
    return c.z * mix(K.xxx, clamp(p - K.xxx, 0.0, 1.0), c.y);
}

void main()
{
    vec2 curve = pow(abs(f_UV * 2.0 - 1.0), vec2(1.0 / curvature));
    float edge = pow(length(curve), curvature);
    float vignette = 1.0 - strength * smoothstep(inner, outer, edge);

    vec2 centered = f_UV * 2.0 - 1.0;
    float hue = (atan(centered.y, centered.x) + 3.14) / 6.28;
    vec3 c = hsv2rgb(vec3(hue, 1.0, 1.0));

    color = vec4(c, 1.0) * uAlpha * (1.0  - vignette);
}";

        public void Initialize(WindowHandle window, OpenGLContextHandle context, bool useGLES)
        {
            Window = window;
            Context = context;
            Debug.Assert(useGLES == false, "This app doesn't support GLES atm.");

            Toolkit.Window.SetMousePassthrough(window, true);
            Toolkit.Window.SetWindowType(window, WindowType.ToolBox);
            Toolkit.Window.SetBorderStyle(window, WindowBorderStyle.Borderless);
            Toolkit.Window.SetTransparencyMode(window, WindowTransparencyMode.TransparentFramebuffer);
            Toolkit.Window.SetAlwaysOnTop(window, true);
            Toolkit.Window.SetMode(window, WindowMode.Maximized);
            Toolkit.Window.FocusWindow(Program.Window);

            ShaderProgram = CompileShader(VertexShader, FragmentShader);

            VAO = GL.GenVertexArray();
            GL.BindVertexArray(VAO);

            static int CompileShader(string vertexSource, string fragmentSource)
            {
                int program = GL.CreateProgram();

                int status = default;

                int vertex = GL.CreateShader(ShaderType.VertexShader);
                GL.ShaderSource(vertex, vertexSource);
                GL.CompileShader(vertex);
                GL.GetShaderi(vertex, ShaderParameterName.CompileStatus, out status);
                if (status == 0)
                {
                    GL.GetShaderInfoLog(vertex, out string info);
                    Console.WriteLine($"Vertex shader: {info}");
                }

                int fragment = GL.CreateShader(ShaderType.FragmentShader);
                GL.ShaderSource(fragment, fragmentSource);
                GL.CompileShader(fragment);
                GL.GetShaderi(fragment, ShaderParameterName.CompileStatus, out status);
                if (status == 0)
                {
                    GL.GetShaderInfoLog(fragment, out string info);
                    Console.WriteLine($"Fragment shader: {info}");
                }

                GL.AttachShader(program, vertex);
                GL.AttachShader(program, fragment);

                GL.LinkProgram(program);
                GL.GetProgrami(program, ProgramProperty.LinkStatus, out status);
                if (status == 0)
                {
                    GL.GetProgramInfoLog(program, out string info);
                    Console.WriteLine($"Program link: {info}");
                }

                GL.DetachShader(program, vertex);
                GL.DetachShader(program, fragment);

                GL.DeleteShader(vertex);
                GL.DeleteShader(fragment);

                return program;
            }
        }

        public void HandleEvent(EventArgs args)
        {
            
        }

        public bool Update(float deltaTime)
        {
            return false;
        }

        public void Render()
        {
            Toolkit.Window.GetFramebufferSize(Window, out Vector2i fbSize);
            Toolkit.Mouse.GetGlobalPosition(out Vector2 mousePos);
            GL.Viewport(0, 0, fbSize.X, fbSize.Y);

            GL.ClearColor(new Color4<Rgba>(0.05f, 0.05f, 0.1f, 1.0f));
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.UseProgram(ShaderProgram);
            GL.Uniform1f(GL.GetUniformLocation(ShaderProgram, "uAlpha"), float.Clamp(mousePos.X / fbSize.X, 0.0f, 1.0f));
            GL.BindVertexArray(VAO);
            GL.DrawArrays(PrimitiveType.Triangles, 0, 3);

            Toolkit.OpenGL.SwapBuffers(Context);
        }

        public void Deinitialize()
        {
            
        }
    }
}
