﻿using System;
using System.Diagnostics;
using OpenTK.Core;
using OpenTK.Core.Platform;
using OpenTK.Core.Platform.Enums;
using OpenTK.Core.Platform.Handles;
using OpenTK.Core.Platform.Interfaces;
using OpenTK.Mathematics.Colors;
using OpenTK.Platform.Native;
using OpenTK.Platform.Native.SDL;

namespace PAL2ContextSharingTest
{
    class Window
    {
        static IWindowComponent WindowComp;
        static IOpenGLComponent OpenGLComponent;

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
            PlatformComponents.PreferSDL2 = true;
            WindowComp = PlatformComponents.CreateWindowComponent();
            OpenGLComponent = PlatformComponents.CreateOpenGLComponent();

            if (PlatformComponents.PreferSDL2)
            {
                Debug.Assert(WindowComp.GetType() == typeof(SDLWindowComponent));
            }

            var logger = new ConsoleLogger();
            WindowComp.Logger = logger;
            OpenGLComponent.Logger = logger;

            WindowComp.Initialize(PalComponents.Window);
            OpenGLComponent.Initialize(PalComponents.OpenGL);

            WindowHandle1 = WindowComp.Create(new OpenGLGraphicsApiHints()
            {
                Version = new Version(4, 1),
                Profile = OpenGLProfile.Core,
                DebugFlag = true,
                ForwardCompatibleFlag = true,
                DoubleBuffer = true,
                DepthBits = ContextDepthBits.Depth24,
                StencilBits = ContextStencilBits.Stencil8,
            });
            ContextHandle1 = OpenGLComponent.CreateFromWindow(WindowHandle1);

            WindowHandle2 = WindowComp.Create(new OpenGLGraphicsApiHints()
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
            ContextHandle2 = OpenGLComponent.CreateFromWindow(WindowHandle2);

            OpenGLComponent.SetCurrentContext(ContextHandle1);
            GLLoader.LoadBindings(OpenGLComponent.GetBindingsContext(ContextHandle1));

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

            OpenGLComponent.SetCurrentContext(ContextHandle2);

            // Load context 2
            {
                VAO2 = CreateVAO(SharedBuffer);

                Program2 = CreateShader("Context 2", VertexShaderSource, FragmentShaderSource);
            }

            WindowComp.GetPosition(WindowHandle1, out int x1, out int y1);
            WindowComp.SetPosition(WindowHandle2, x1 + 800, y1);

            WindowComp.SetTitle(WindowHandle1, $"{PlatformComponents.GetBackend()} Test Window 1");
            WindowComp.SetSize(WindowHandle1, 800, 600);
            WindowComp.SetMode(WindowHandle1, WindowMode.Normal);
            WindowComp.SetTitle(WindowHandle2, $"{PlatformComponents.GetBackend()} Test Window 2");
            WindowComp.SetSize(WindowHandle2, 800, 600);
            WindowComp.SetMode(WindowHandle2, WindowMode.Normal);

            EventQueue.EventRaised += EventQueue_EventRaised;

            while (true)
            {
                WindowComp.ProcessEvents();

                // If both of our windows are closed, we exit the application.
                if (WindowComp.IsWindowDestroyed(WindowHandle1) &&
                    WindowComp.IsWindowDestroyed(WindowHandle2))
                {
                    break;
                }

                if (Render() == false)
                {
                    break;
                }
            }

            WindowComp.ProcessEvents();
            WindowComp.ProcessEvents();
            WindowComp.ProcessEvents();
            WindowComp.ProcessEvents();
            WindowComp.ProcessEvents();
        }

        private static void EventQueue_EventRaised(PalHandle? handle, PlatformEventType type, EventArgs args)
        {
            if (args is CloseEventArgs close)
            {
                WindowComp.Destroy(close.Window);
            }
        }

        static bool Render()
        {
            if (WindowComp.IsWindowDestroyed(WindowHandle1) == false)
            {
                OpenGLComponent.SetCurrentContext(ContextHandle1);

                GL.ClearColor(Color4.Red);
                GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit | ClearBufferMask.StencilBufferBit);

                WindowComp.GetClientSize(WindowHandle1, out int width, out int height);
                GL.Viewport(0, 0, width, height);

                GL.UseProgram(Program1);
                GL.BindVertexArray(VAO1);

                GL.DrawArrays(PrimitiveType.Triangles, 0, 6);

                WindowComp.SwapBuffers(WindowHandle1);
            }

            if (WindowComp.IsWindowDestroyed(WindowHandle2) == false)
            {
                OpenGLComponent.SetCurrentContext(ContextHandle2);

                GL.ClearColor(Color4.Blue);
                GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit | ClearBufferMask.StencilBufferBit);

                WindowComp.GetClientSize(WindowHandle2, out int width, out int height);
                GL.Viewport(0, 0, width, height);

                GL.UseProgram(Program2);
                GL.BindVertexArray(VAO2);

                GL.DrawArrays(PrimitiveType.Triangles, 0, 6);

                WindowComp.SwapBuffers(WindowHandle2);
            }

            return true;
        }

        public static int CreateBuffer(float[] vertices)
        {
            var buffer = GL.GenBuffer();

            GL.BindBuffer(BufferTargetARB.ArrayBuffer, buffer);
            GL.BufferData(BufferTargetARB.ArrayBuffer, vertices, BufferUsageARB.StaticDraw);

            return buffer;
        }

        public static int CreateVAO(int buffer)
        {
            var vao = GL.GenVertexArray();

            GL.BindVertexArray(vao);
            GL.BindBuffer(BufferTargetARB.ArrayBuffer, buffer);

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

            int success = 0;
            GL.GetShaderi(vert, ShaderParameterName.CompileStatus, ref success);
            if (success == 0)
            {
                GL.GetShaderInfoLog(vert, out string info);
                Console.WriteLine(info);
            }
            GL.GetShaderi(frag, ShaderParameterName.CompileStatus, ref success);
            if (success == 0)
            {
                GL.GetShaderInfoLog(frag, out string info);
                Console.WriteLine(info);
            }

            var program = GL.CreateProgram();

            GL.AttachShader(program, vert);
            GL.AttachShader(program, frag);

            GL.LinkProgram(program);

            GL.GetProgrami(program, ProgramPropertyARB.LinkStatus, ref success);
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
