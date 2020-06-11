using System.ComponentModel;
using OpenToolkit.Graphics.OpenGL4;
using OpenToolkit.Windowing.Common;
using OpenToolkit.Windowing.Common.Input;
using OpenToolkit.Windowing.Desktop;
using OpenToolkit.Windowing.GraphicsLibraryFramework;

namespace HelloTriangle
{
    internal static class Program
    {
        private static int _vao, _vbo, _ebo, _program;
        private static GameWindow _window;

        private static readonly float[] Vertices =
        {
            -0.5f, -0.5f,
             0.5f, -0.5f,
             0.0f,  0.5f
        };

        private static readonly uint[] Indices =
        {
            0, 1, 2
        };

        private static readonly string VertexSrc = @"#version 330 core
layout (location = 0) in vec2 vPosition;

void main(){
    gl_Position = vec4(vPosition, 0, 1);
}";

        private static readonly string FragmentSrc = @"#version 330 core
out vec4 _color;

void main(){
    _color = vec4(1, 0.4, 0.2, 1);
}";

        public static void Main(string[] args)
        {
            _window = new GameWindow(GameWindowSettings.Default, NativeWindowSettings.Default);
            Initialize();
            _window.UpdateFrame += Update;
            _window.KeyDown += KeyDown;
            _window.Closing += Closing;

            _window.Run();
        }

        private static void KeyDown(KeyboardKeyEventArgs obj)
        {
            if (obj.Key == Key.Escape)
            {
                _window.Close();
            }
        }

        private static void Initialize()
        {
            //Initialize context
            _window.MakeCurrent();
            GL.LoadBindings(new GLFWBindingsContext());

            //Create VAO
            _vao = GL.GenVertexArray();
            GL.BindVertexArray(_vao);

            //Create EBO
            _ebo = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, _ebo);
            GL.BufferData(BufferTarget.ElementArrayBuffer, Indices.Length * sizeof(uint), Indices,
                BufferUsageHint.StaticDraw);

            //Create VBO
            _vbo = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, _vbo);
            GL.BufferData(BufferTarget.ArrayBuffer, Vertices.Length * sizeof(float), Vertices,
                BufferUsageHint.StaticDraw);

            //Enable attributes
            GL.EnableVertexAttribArray(0);
            GL.VertexAttribPointer(0, 2, VertexAttribPointerType.Float, false, 2 * sizeof(float), 0);

            //Create vertex shader
            var vert = GL.CreateShader(ShaderType.VertexShader);
            GL.ShaderSource(vert, VertexSrc);
            GL.CompileShader(vert);

            //Create fragment shader
            var frag = GL.CreateShader(ShaderType.FragmentShader);
            GL.ShaderSource(frag, FragmentSrc);
            GL.CompileShader(frag);

            //Create shader program
            _program = GL.CreateProgram();
            GL.AttachShader(_program, vert);
            GL.AttachShader(_program, frag);
            GL.LinkProgram(_program);

            //Dispose individual shaders
            GL.DetachShader(_program, vert);
            GL.DeleteShader(vert);
            GL.DetachShader(_program, frag);
            GL.DeleteShader(frag);

            //Set clear color
            GL.ClearColor(1, 0, 1, 1);
        }

        private static void Update(FrameEventArgs obj)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);

            GL.BindVertexArray(_vao);
            GL.UseProgram(_program);

            GL.DrawElements(PrimitiveType.Triangles, Indices.Length, DrawElementsType.UnsignedInt, 0);

            _window.SwapBuffers();
        }

        private static void Closing(CancelEventArgs obj)
        {
            _window.Dispose();
            GL.DeleteVertexArray(_vao);
            GL.DeleteBuffer(_vbo);
            GL.DeleteBuffer(_ebo);
            GL.DeleteProgram(_program);
        }
    }
}
