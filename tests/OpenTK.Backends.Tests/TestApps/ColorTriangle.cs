using ImGuiNET;
using OpenTK.Core.Platform;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Backends.Tests
{
    [TestApp]
    public class ColorTriangle : ITestApp
    {
        public string Name => "Color Triangle";

        public struct Vertex
        {
            public Vector2 Position;
            public Vector3 Color;

            public Vertex(Vector2 position, Vector3 color)
            {
                Position = position;
                Color = color;
            }
        }

        private WindowHandle Window;
        private OpenGLContextHandle Context;

        private int VAO;
        private int VBO;

        private int ShaderProgram;
        const string VertexShader = @"#version 330 core

layout(location = 0) in vec2 v_Position;
layout(location = 1) in vec3 v_Color;

out vec3 f_Color;

void main()
{
    gl_Position = vec4(v_Position, 0.0, 1.0);
    f_Color = v_Color;
}
";
        const string FragmentShader = @"#version 330 core

in vec3 f_Color;

out vec3 color;

void main()
{
    color = f_Color;
}
";

        static readonly Vertex[] Vertices = {
            new Vertex((-0.5f, -0.5f), (1, 0, 0)),
            new Vertex((+0.5f, -0.5f), (0, 1, 0)),
            new Vertex(( 0.0f, +0.5f), (0, 0, 1)),
        };

        public void Initialize(WindowHandle window, OpenGLContextHandle context)
        {
            Window = window;
            Context = context;

            ShaderProgram = CompileShader(VertexShader, FragmentShader);

            VAO = GL.CreateVertexArray();
            VBO = GL.CreateBuffer();

            GL.BindVertexArray(VAO);

            GL.BindBuffer(BufferTargetARB.ArrayBuffer, VBO);
            GL.BufferData(BufferTargetARB.ArrayBuffer, Vertices, BufferUsageARB.StaticDraw);

            GL.EnableVertexAttribArray(0);
            GL.VertexAttribPointer(0, 2, VertexAttribPointerType.Float, false, Unsafe.SizeOf<Vertex>(), 0);

            GL.EnableVertexAttribArray(1);
            GL.VertexAttribPointer(1, 3, VertexAttribPointerType.Float, false, Unsafe.SizeOf<Vertex>(), Vector2.SizeInBytes);

            static int CompileShader(string vertexSource, string fragmentSource)
            {
                int program = GL.CreateProgram();

                int status = default;

                int vertex = GL.CreateShader(ShaderType.VertexShader);
                GL.ShaderSource(vertex, vertexSource);
                GL.CompileShader(vertex);
                GL.GetShaderi(vertex, ShaderParameterName.CompileStatus, ref status);
                if (status == 0)
                {
                    GL.GetShaderInfoLog(vertex, out string info);
                    Console.WriteLine($"Vertex shader: {info}");
                }

                int fragment = GL.CreateShader(ShaderType.FragmentShader);
                GL.ShaderSource(fragment, fragmentSource);
                GL.CompileShader(fragment);
                GL.GetShaderi(fragment, ShaderParameterName.CompileStatus, ref status);
                if (status == 0)
                {
                    GL.GetShaderInfoLog(fragment, out string info);
                    Console.WriteLine($"Fragment shader: {info}");
                }

                GL.AttachShader(program, vertex);
                GL.AttachShader(program, fragment);

                GL.LinkProgram(program);
                GL.GetProgrami(program, ProgramPropertyARB.LinkStatus, ref status);
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

        public void Render()
        {
            GL.ClearColor(Color4.Black);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.UseProgram(ShaderProgram);
            GL.BindVertexArray(VAO);
            GL.DrawArrays(PrimitiveType.Triangles, 0, 3);

            Program.WindowComp.SwapBuffers(Window);
        }

        public void Deinitialize()
        {
            GL.BindVertexArray(0);
            GL.BindBuffer(BufferTargetARB.ArrayBuffer, 0);
            GL.UseProgram(0);

            GL.DeleteVertexArray(VAO);
            GL.DeleteBuffer(VBO);

            GL.DeleteProgram(ShaderProgram);
        }
    }
}
