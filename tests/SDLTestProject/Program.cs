using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using OpenTK.Platform.Native;
using OpenTK.Platform.Native.SDL;
using OpenTK.Platform.Native.Windows;

namespace SDLTestProject
{
    internal class Program
    {
        static IWindowComponent WindowComp;
        static IOpenGLComponent OpenGLComponent;
        static IDisplayComponent DisplayComponent;
        static IMouseComponent MouseComponent;
        static IClipboardComponent ClipboardComponent;
        static IIconComponent IconComponent;
        static IShellComponent ShellComponent;

        static WindowHandle WindowHandle;
        static OpenGLContextHandle ContextHandle;
        static IconHandle IconHandle;

        const string vertexShaderSource =
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

        const string fragmentShaderSource =
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
            Console.WriteLine(System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture);
            Console.WriteLine(System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription);
            Console.WriteLine(System.Runtime.InteropServices.RuntimeInformation.OSArchitecture);
            Console.WriteLine(System.Runtime.InteropServices.RuntimeInformation.OSDescription);
            Console.WriteLine(System.Runtime.InteropServices.RuntimeInformation.RuntimeIdentifier);
            Console.WriteLine($"Is OS 64 bit: {System.Environment.Is64BitOperatingSystem}");
            Console.WriteLine($"Is process 64 bit: {System.Environment.Is64BitProcess}");
            
            PlatformComponents.PreferSDL2 = true;
            WindowComp = PlatformComponents.CreateWindowComponent();
            OpenGLComponent = PlatformComponents.CreateOpenGLComponent();
            DisplayComponent = PlatformComponents.CreateDisplayComponent();
            MouseComponent = PlatformComponents.CreateMouseComponent();
            ClipboardComponent = PlatformComponents.CreateClipboardComponent();
            IconComponent = PlatformComponents.CreateIconComponent();
            ShellComponent = PlatformComponents.CreateShellComponent();

            Debug.Assert(WindowComp.GetType() == typeof(SDLWindowComponent));

            var logger = new ConsoleLogger();
            WindowComp.Logger = logger;
            OpenGLComponent.Logger = logger;
            DisplayComponent.Logger = logger;
            MouseComponent.Logger = logger;
            ClipboardComponent.Logger = logger;
            IconComponent.Logger = logger;
            ShellComponent.Logger = logger;

            WindowComp.Initialize(PalComponents.Window);
            OpenGLComponent.Initialize(PalComponents.OpenGL);
            DisplayComponent.Initialize(PalComponents.Display);
            MouseComponent.Initialize(PalComponents.MiceInput);
            ClipboardComponent.Initialize(PalComponents.Clipboard);
            IconComponent.Initialize(PalComponents.WindowIcon);

            WindowHandle = WindowComp.Create(new OpenGLGraphicsApiHints());
            WindowComp.SetTitle(WindowHandle, "SDL Test Window");
            WindowComp.SetSize(WindowHandle, 800, 600);

            WindowComp.SetMaxClientSize(WindowHandle, 1000, 1000);
            WindowComp.SetMinClientSize(WindowHandle, 100, 100);

            // Generate and set window icon 
            {
                byte[] icon = new byte[16 * 16 * 4];
                for (int ccx = 0; ccx < 16; ccx++)
                {
                    for (int ccy = 0; ccy < 16; ccy++)
                    {
                        int index = (ccy * 16 + ccx) * 4;

                        if (ccx < 5)
                        {
                            icon[index + 0] = 255;
                            icon[index + 1] = 0;
                            icon[index + 2] = 0;
                        }
                        else if (ccx < 10)
                        {
                            icon[index + 0] = 0;
                            icon[index + 1] = 255;
                            icon[index + 2] = 0;
                        }
                        else
                        {
                            icon[index + 0] = 0;
                            icon[index + 1] = 0;
                            icon[index + 2] = 255;
                        }

                        icon[index + 3] = 255;
                        if (ccy < 5) icon[index + 3] = 50;
                    }
                }

                IconHandle = IconComponent.Create();
                IconComponent.Load(IconHandle, 16, 16, icon);

                WindowComp.SetIcon(WindowHandle, IconHandle);

                {
                    IconComponent.GetDimensions(IconHandle, out int iw, out int ih);

                    int bytes = IconComponent.GetBitmapByteSize(IconHandle);
                    byte[] data = new byte[bytes];

                    IconComponent.GetBitmapData(IconHandle, data);

                    Debug.Assert(iw == 16);
                    Debug.Assert(ih == 16);
                    Debug.Assert(bytes == 1024);
                    Debug.Assert(data.SequenceEqual(icon));
                }
            }

            WindowComp.SetMode(WindowHandle, WindowMode.Normal);

            ContextHandle = OpenGLComponent.CreateFromWindow(WindowHandle);
            OpenGLComponent.SetCurrentContext(ContextHandle);

            GLLoader.LoadBindings(OpenGLComponent.GetBindingsContext(ContextHandle));

            EventQueue.EventRaised += EventQueue_EventRaised;

            int noDisp = DisplayComponent.GetDisplayCount();
            for (int i = 0; i < noDisp; i++)
            {
                DisplayHandle handle = DisplayComponent.Create(i);

                string name = DisplayComponent.GetName(handle);
                bool isPrimary = DisplayComponent.IsPrimary(handle);
                DisplayComponent.GetVideoMode(handle, out VideoMode mode);
                int modeCount = DisplayComponent.GetSupportedVideoModeCount(handle);
                VideoMode[] modes = new VideoMode[modeCount];
                DisplayComponent.GetSupportedVideoModes(handle, modes);
                DisplayComponent.GetVirtualPosition(handle, out int px, out int py);
                DisplayComponent.GetResolution(handle, out int resx, out int resy);
                DisplayComponent.GetWorkArea(handle, out Box2i workArea);
                DisplayComponent.GetRefreshRate(handle, out float refreshRate);
                DisplayComponent.GetDisplayScale(handle, out float scaleX, out float scaleY);

                Console.WriteLine($"Display {i}: {name}{(isPrimary ? " (primary)" : "")}");
                Console.WriteLine($"  Current Mode: {mode}");
                Console.WriteLine($"  Modes: {modeCount}");
                for (int m = 0; m < modeCount; m++)
                {
                    Console.WriteLine($"    Mode {m}: {modes[m]}");
                }
                Console.WriteLine($"  Position: {new Vector2i(px, py)}, Resolution: {new Vector2i(resx, resy)}");
                Console.WriteLine($"  Work Area: {workArea}");
                Console.WriteLine($"  Refresh rate: {refreshRate}");
                Console.WriteLine($"  Scale X: {scaleX}, Scale Y: {scaleY}");
            }

            float[] vertices = new float[]
            {
                -1f * 0.5f, -1f * 0.5f, 0f,     0f, 0f,     1f, 0f, 0f,
                 1f * 0.5f, -1f * 0.5f, 0f,     1f, 0f,     0f, 1f, 0f,
                 1f * 0.5f,  1f * 0.5f, 0f,     1f, 1f,     0f, 0f, 1f,

                 1f * 0.5f,  1f * 0.5f, 0f,     1f, 1f,     0f, 0f, 1f,
                -1f * 0.5f,  1f * 0.5f, 0f,     0f, 1f,     0f, 1f, 0f,
                -1f * 0.5f, -1f * 0.5f, 0f,     0f, 0f,     1f, 0f, 0f,
            };

            int buffer = CreateBuffer(vertices);
            int vao = CreateVAO(buffer);

            int shader = CreateShader("", vertexShaderSource, fragmentShaderSource);

            while (WindowComp.IsWindowDestroyed(WindowHandle) == false)
            {
                WindowComp.ProcessEvents();

                GL.ClearColor(Color4.Coral);
                GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit | ClearBufferMask.StencilBufferBit);

                GL.UseProgram(shader);
                GL.BindVertexArray(vao);

                GL.DrawArrays(PrimitiveType.Triangles, 0, 6);

                WindowComp.SwapBuffers(WindowHandle);
            }
        }

        private static void EventQueue_EventRaised(PalHandle? handle, PlatformEventType type, EventArgs args)
        {
            if (args is CloseEventArgs close)
            {
                WindowComp.Destroy(close.Window);
            }
            else if (args is MouseButtonDownEventArgs mouseDown)
            {

            }
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

            CheckError("buffer");

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

        static void CheckError(string place)
        {
            var error = GL.GetError();
            while (error != ErrorCode.NoError)
            {
                Console.WriteLine($"{place} Error: {error}");
                error = GL.GetError();
            }
        }
    }
}
