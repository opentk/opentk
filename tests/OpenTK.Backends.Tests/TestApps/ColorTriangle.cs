using ImGuiNET;
using OpenTK.Core.Platform;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using OpenTK.Platform.Native;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        private bool KHRDebugAvailable;

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

        const string VertexShaderES = @"#version 300 es

precision highp float;

layout(location = 0) in vec2 v_Position;
layout(location = 1) in vec3 v_Color;

out vec3 f_Color;

void main()
{
    gl_Position = vec4(v_Position, 0.0, 1.0);
    f_Color = v_Color;
}
";
        const string FragmentShaderES = @"#version 300 es

precision highp float;

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

        public void Initialize(WindowHandle window, OpenGLContextHandle context, bool useGLES)
        {
            Window = window;
            Context = context;

            static bool IsExtensionSupported(string name)
            {
                int n = GL.GetInteger(GetPName.NumExtensions);
                for (int i = 0; i < n; i++)
                {
                    string extension = GL.GetStringi(StringName.Extensions, (uint)i)!;
                    if (extension == name) return true;
                }

                return false;
            }

            int major = GL.GetInteger(GetPName.MajorVersion);
            int minor = GL.GetInteger(GetPName.MinorVersion);
            KHRDebugAvailable = (major == 4 && minor >= 3) || IsExtensionSupported("KHR_debug") || IsExtensionSupported("GL_KHR_debug");

            if (KHRDebugAvailable)
            {
                GL.DebugMessageCallback(Program.DebugProcCallback, IntPtr.Zero);
                GL.Enable(EnableCap.DebugOutput);
                GL.Enable(EnableCap.DebugOutputSynchronous);
            }

            if (useGLES)
            {
                ShaderProgram = CompileShader(VertexShaderES, FragmentShaderES);
            }
            else
            {
                ShaderProgram = CompileShader(VertexShader, FragmentShader);
            }
            if (KHRDebugAvailable) GL.ObjectLabel(ObjectIdentifier.Program, (uint)ShaderProgram, -1, "Program: Color Triangle");

            VAO = GL.GenVertexArray();
            GL.BindVertexArray(VAO);
            if (KHRDebugAvailable) GL.ObjectLabel(ObjectIdentifier.VertexArray, (uint)VAO, -1, "VAO: Color Triangle");

            VBO = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, VBO);
            if (KHRDebugAvailable) GL.ObjectLabel(ObjectIdentifier.Buffer, (uint)VBO, -1, "VBO: Color Triangle");

            GL.BufferData(BufferTarget.ArrayBuffer, Vertices, BufferUsage.StaticDraw);

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
                GL.GetProgrami(program, ProgramProperty.LinkStatus, ref status);
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
            if (args is WindowResizeEventArgs resize)
            {
                var prevContext = Toolkit.OpenGL.GetCurrentContext();
                Toolkit.OpenGL.SetCurrentContext(Context);

                GL.Viewport(0, 0, resize.NewSize.X, resize.NewSize.Y);

                // Re-render the window to make resize live.
                Render();

                Toolkit.OpenGL.SetCurrentContext(prevContext);
            }
        }

        public bool Update(float deltaTime)
        {
            return false;
        }

        public void Render()
        {
            GL.ClearColor(new Color4<Rgba>(0.05f, 0.05f, 0.1f, 1.0f));
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.UseProgram(ShaderProgram);
            GL.BindVertexArray(VAO);
            GL.DrawArrays(PrimitiveType.Triangles, 0, 3);

            Toolkit.OpenGL.SwapBuffers(Context);
        }

        public void Deinitialize()
        {
            GL.BindVertexArray(0);
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            GL.UseProgram(0);

            GL.DeleteVertexArray(VAO);
            GL.DeleteBuffer(VBO);

            GL.DeleteProgram(ShaderProgram);
        }
    }
}
