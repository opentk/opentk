using OpenTK.Platform;
using OpenTK.Core.Utility;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using OpenTK.Platform.Native;
using OpenTK.Platform.Native.SDL;
using System;
using System.Diagnostics;

namespace LocalTest
{
    class Window
    {
        static WindowHandle WindowHandle1;
        static OpenGLContextHandle ContextHandle1;

        static WindowHandle WindowHandle2;
        static OpenGLContextHandle ContextHandle2;

        static int SharedBuffer;

        static int VAO1, VAO2;
        static int Program1, Program2;

        const string VertexShaderSource =
    @"#version 330 core
layout (location = 0) in vec3 aPos;
layout (location = 1) in vec2 aUV;
layout (location = 2) in vec3 aColor;

out vec2 oUV;
out vec3 oColor;

void main()
{
    gl_Position = vec4(aPos.x, aPos.y, aPos.z, 1.0);
    oUV = aUV;
    oColor = aColor;
}";

        const string FragmentShaderSource =
    @"#version 330 core
in vec2 oUV;
in vec3 oColor;

out vec4 FragColor;

uniform sampler2D tex;

void main()
{
    FragColor = vec4(oUV, 0, 1);
}";

        static void Main(string[] args)
        {
            //PlatformComponents.PreferSDL2 = true;
            Toolkit.Init(new ToolkitOptions() { ApplicationName = "PAL2 Context Sharing Test", Logger = new ConsoleLogger() });
            
            if (PlatformComponents.PreferSDL2)
            {
                Debug.Assert(Toolkit.Window.GetType() == typeof(SDLWindowComponent));
            }

            WindowHandle1 = Toolkit.Window.Create(new OpenGLGraphicsApiHints()
            {
                Version = new Version(4, 1),
                Profile = OpenGLProfile.Core,
                DebugFlag = true,
                ForwardCompatibleFlag = true,
                DoubleBuffer = true,
                DepthBits = ContextDepthBits.Depth24,
                StencilBits = ContextStencilBits.Stencil8,
            });
            ContextHandle1 = Toolkit.OpenGL.CreateFromWindow(WindowHandle1);

            WindowHandle2 = Toolkit.Window.Create(new OpenGLGraphicsApiHints()
            {
                Version = new Version(4, 1),
                Profile = OpenGLProfile.Core,
                DebugFlag = true,
                ForwardCompatibleFlag = true,
                DoubleBuffer = true,
                DepthBits = ContextDepthBits.Depth24,
                StencilBits = ContextStencilBits.Stencil8,
                SharedContext = ContextHandle1,
            });
            ContextHandle2 = Toolkit.OpenGL.CreateFromWindow(WindowHandle2);

            Toolkit.OpenGL.SetCurrentContext(ContextHandle1);
            GLLoader.LoadBindings(Toolkit.OpenGL.GetBindingsContext(ContextHandle1));

            // Load shared
            {
                float[] vertices = new float[]
                {
                    -1f * 0.5f, -1f * 0.5f, 0f,     0f, 0f,     1f, 0f, 0f,
                     1f * 0.5f, -1f * 0.5f, 0f,     1f, 0f,     0f, 1f, 0f,
                     1f * 0.5f,  1f * 0.5f, 0f,     1f, 1f,     0f, 0f, 1f,

                     1f * 0.5f,  1f * 0.5f, 0f,     1f, 1f,     0f, 0f, 1f,
                    -1f * 0.5f,  1f * 0.5f, 0f,     0f, 1f,     0f, 1f, 0f,
                    -1f * 0.5f, -1f * 0.5f, 0f,     0f, 0f,     1f, 0f, 0f,
                };

                SharedBuffer = CreateBuffer(vertices);
            }

            // Load context 1
            {
                VAO1 = CreateVAO(SharedBuffer);

                Program1 = CreateShader("Context 1", VertexShaderSource, FragmentShaderSource);
            }

            Toolkit.OpenGL.SetCurrentContext(ContextHandle2);

            // Load context 2
            {
                VAO2 = CreateVAO(SharedBuffer);

                Program2 = CreateShader("Context 2", VertexShaderSource, FragmentShaderSource);
            }

            Toolkit.Window.GetClientPosition(WindowHandle1, out Vector2i p1);
            Toolkit.Window.SetClientPosition(WindowHandle2, (p1.X + 800, p1.Y));

            Toolkit.Window.SetTitle(WindowHandle1, $"{PlatformComponents.GetBackend()} Test Window 1");
            Toolkit.Window.SetClientSize(WindowHandle1, (800, 600));
            Toolkit.Window.SetMode(WindowHandle1, WindowMode.Normal);
            Toolkit.Window.SetTitle(WindowHandle2, $"{PlatformComponents.GetBackend()} Test Window 2");
            Toolkit.Window.SetClientSize(WindowHandle2, (800, 600));
            Toolkit.Window.SetMode(WindowHandle2, WindowMode.Normal);

            EventQueue.EventRaised += EventQueue_EventRaised;

            while (true)
            {
                Toolkit.Window.ProcessEvents(false);

                // If both of our windows are closed, we exit the application.
                if (Toolkit.Window.IsWindowDestroyed(WindowHandle1) &&
                    Toolkit.Window.IsWindowDestroyed(WindowHandle2))
                {
                    break;
                }

                if (Render() == false)
                {
                    break;
                }
            }

            Toolkit.Window.ProcessEvents(false);
            Toolkit.Window.ProcessEvents(false);
            Toolkit.Window.ProcessEvents(false);
            Toolkit.Window.ProcessEvents(false);
            Toolkit.Window.ProcessEvents(false);
        }

        private static void EventQueue_EventRaised(PalHandle? handle, PlatformEventType type, EventArgs args)
        {
            if (args is CloseEventArgs close)
            {
                Toolkit.Window.Destroy(close.Window);
            }
        }

        static bool Render()
        {
            if (Toolkit.Window.IsWindowDestroyed(WindowHandle1) == false)
            {
                Toolkit.OpenGL.SetCurrentContext(ContextHandle1);

                GL.ClearColor(Color4.Red);
                GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit | ClearBufferMask.StencilBufferBit);

                Toolkit.Window.GetFramebufferSize(WindowHandle1, out Vector2i fbSize);
                GL.Viewport(0, 0, fbSize.X, fbSize.Y);

                GL.UseProgram(Program1);
                GL.BindVertexArray(VAO1);

                GL.DrawArrays(PrimitiveType.Triangles, 0, 6);

                Toolkit.OpenGL.SwapBuffers(ContextHandle1);
            }

            if (Toolkit.Window.IsWindowDestroyed(WindowHandle2) == false)
            {
                Toolkit.OpenGL.SetCurrentContext(ContextHandle2);

                GL.ClearColor(Color4.Blue);
                GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit | ClearBufferMask.StencilBufferBit);

                Toolkit.Window.GetFramebufferSize(WindowHandle2, out Vector2i fbSize);
                GL.Viewport(0, 0, fbSize.X, fbSize.Y);

                GL.UseProgram(Program2);
                GL.BindVertexArray(VAO2);

                GL.DrawArrays(PrimitiveType.Triangles, 0, 6);

                Toolkit.OpenGL.SwapBuffers(ContextHandle2);
            }

            return true;
        }

        public static int CreateBuffer(float[] vertices)
        {
            var buffer = GL.GenBuffer();

            GL.BindBuffer(BufferTarget.ArrayBuffer, buffer);
            GL.BufferData(BufferTarget.ArrayBuffer, vertices.Length * sizeof(float), vertices, BufferUsage.StaticDraw);

            return buffer;
        }

        public static int CreateVAO(int buffer)
        {
            var vao = GL.GenVertexArray();

            GL.BindVertexArray(vao);
            GL.BindBuffer(BufferTarget.ArrayBuffer, buffer);

            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, sizeof(float) * 8, 0);
            GL.EnableVertexAttribArray(0);

            GL.VertexAttribPointer(1, 2, VertexAttribPointerType.Float, false, sizeof(float) * 8, sizeof(float) * 3);
            GL.EnableVertexAttribArray(1);

            GL.VertexAttribPointer(2, 3, VertexAttribPointerType.Float, false, sizeof(float) * 8, sizeof(float) * 5);
            GL.EnableVertexAttribArray(2);

            return vao;
        }

        public static int CreateShader(string name, string vertexSource, string fragmentSource)
        {
            var vert = GL.CreateShader(ShaderType.VertexShader);
            var frag = GL.CreateShader(ShaderType.FragmentShader);

            GL.ShaderSource(vert, vertexSource);
            GL.ShaderSource(frag, fragmentSource);

            GL.CompileShader(vert);
            GL.CompileShader(frag);

            int success;
            GL.GetShaderi(vert, ShaderParameterName.CompileStatus, out success);
            if (success == 0)
            {
                GL.GetShaderInfoLog(vert, out string info);
                Console.WriteLine(info);
            }
            GL.GetShaderi(frag, ShaderParameterName.CompileStatus, out success);
            if (success == 0)
            {
                GL.GetShaderInfoLog(frag, out string info);
                Console.WriteLine(info);
            }

            var program = GL.CreateProgram();

            GL.AttachShader(program, vert);
            GL.AttachShader(program, frag);

            GL.LinkProgram(program);

            GL.GetProgrami(program, ProgramProperty.LinkStatus, out success);
            if (success == 0)
            {
                GL.GetProgramInfoLog(program, out string info);
                Console.WriteLine(info);
            }

            GL.DetachShader(program, vert);
            GL.DetachShader(program, frag);

            GL.DeleteShader(vert);
            GL.DeleteShader(frag);

            return program;
        }
    }
}
