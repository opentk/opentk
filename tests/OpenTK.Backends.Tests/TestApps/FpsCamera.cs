using System;
using System.Diagnostics;
using OpenTK.Core.Platform;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using OpenTK.Platform.Native;
using OpenTK.Platform.Native.macOS;

namespace OpenTK.Backends.Tests
{
    [TestApp]
    public class FpsCamera : ITestApp
    {
        public string Name => "Fps Camera";

        struct Vertex
        {
            public Vector3 Position;
            public Vector3 Normal;
            public Vector3 Color;

            public Vertex(Vector3 position, Vector3 normal, Vector3 color)
            {
                Position = position;
                Normal = normal;
                Color = color;
            }
        }

        WindowHandle window;
        OpenGLContextHandle context;

        const float D2R = MathF.PI / 180.0f;

        const float RoomWidth = 10;
        static readonly Vector3 FloorColor = (0.5f, 0.5f, 0.5f);
        static readonly Vertex[] env_data = {
            // Floor
            new Vertex((-RoomWidth, -2,  RoomWidth), (0, 1, 0), FloorColor),
            new Vertex(( RoomWidth, -2,  RoomWidth), (0, 1, 0), FloorColor),
            new Vertex(( RoomWidth, -2, -RoomWidth), (0, 1, 0), FloorColor),
            new Vertex((-RoomWidth, -2, -RoomWidth), (0, 1, 0), FloorColor),
        };
        static readonly int[] env_idx = {
            // Floor
            0, 1, 2, 0, 2, 3
        };

        int env_vao;
        int env_vbo;
        int env_ebo;

        // FIXME: Make the version dynamically changeable to support gles...
        const string vertex_shader =
@"#version 330 core

layout(location = 0) in vec3 in_position;
layout(location = 1) in vec3 in_normal;
layout(location = 2) in vec3 in_color;

out vec3 f_color;

uniform mat4 mvp;

void main() {
    gl_Position = vec4(in_position, 1.0) * mvp;
    f_color = in_color;
}
";

        // FIXME: Make the version dynamically changeable to support gles...
        const string fragment_shader =
@"#version 330 core
in vec3 f_color;

out vec3 out_color;

void main() {
    out_color = f_color;
}
";

        int env_program;
        int env_program_mvp_location;

        float cameraFov = 90;
        float cameraNear = 0.01f;
        float cameraFar = 1000;

        Vector3 cameraPosition = (0, 0, 0);
        Quaternion cameraRotation = Quaternion.Identity;
        float cameraRotationX = 0;
        float cameraRotationY = 0;
        const float cameraMovementSpeed = 10;

        readonly Vector2 cameraRotationSpeed = (0.3f, 0.3f);

        public unsafe void Initialize(WindowHandle window, OpenGLContextHandle context, bool useGLES)
        {
            Debug.Assert(useGLES == false, "We don't support gles here yet.");

            this.window = window;
            this.context = context;

            env_vao = GL.GenVertexArray();
            GL.BindVertexArray(env_vao);

            env_vbo = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, env_vbo);
            GL.BufferData(BufferTarget.ArrayBuffer, env_data, BufferUsage.StaticDraw);

            GL.EnableVertexAttribArray(0);
            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, sizeof(Vertex), 0*sizeof(Vector3));
            GL.EnableVertexAttribArray(1);
            GL.VertexAttribPointer(1, 3, VertexAttribPointerType.Float, false, sizeof(Vertex), 1*sizeof(Vector3));
            GL.EnableVertexAttribArray(2);
            GL.VertexAttribPointer(2, 3, VertexAttribPointerType.Float, false, sizeof(Vertex), 2*sizeof(Vector3));

            env_ebo = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, env_ebo);
            GL.BufferData(BufferTarget.ElementArrayBuffer, env_idx, BufferUsage.StaticDraw);

            int vert = GL.CreateShader(ShaderType.VertexShader);
            GL.ShaderSource(vert, vertex_shader);
            GL.CompileShader(vert);
            if (GL.GetShaderi(vert, ShaderParameterName.CompileStatus) == 0)
            {
                GL.GetShaderInfoLog(vert, out string info);
                Debug.Assert(false, $"Vertex shader compilation error: {info}");
            }

            int frag = GL.CreateShader(ShaderType.FragmentShader);
            GL.ShaderSource(frag, fragment_shader);
            GL.CompileShader(frag);
            if (GL.GetShaderi(frag, ShaderParameterName.CompileStatus) == 0)
            {
                GL.GetShaderInfoLog(frag, out string info);
                Debug.Assert(false, $"Fragment shader compilation error: {info}");
            }

            env_program = GL.CreateProgram();
            GL.AttachShader(env_program, vert);
            GL.AttachShader(env_program, frag);
            GL.LinkProgram(env_program);
            if (GL.GetProgrami(env_program, ProgramProperty.LinkStatus) == 0)
            {
                GL.GetProgramInfoLog(env_program, out string info);
                Debug.Assert(false, $"Shader link error: {info}");
            }
            GL.DetachShader(env_program, vert);
            GL.DetachShader(env_program, frag);

            GL.DeleteShader(vert);
            GL.DeleteShader(frag);

            env_program_mvp_location = GL.GetUniformLocation(env_program, "mvp");

            Toolkit.Window.SetCursorCaptureMode(window, CursorCaptureMode.Locked);
            Toolkit.Window.SetCursor(window, null);
        }

        public void Deinitialize()
        {
            GL.DeleteVertexArray(env_vao);
            GL.DeleteBuffer(env_vbo);
            GL.DeleteBuffer(env_ebo);

            GL.DeleteProgram(env_program);
        }

        public void Render()
        {
            GL.ClearColor(Color4.Darkslategray);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.BindVertexArray(env_vao);

            GL.UseProgram(env_program);

            // FIXME: Framebuffer size...
            Toolkit.Window.GetClientSize(window, out int width, out int height);
            if (Toolkit.Window is MacOSWindowComponent macOSWindowComp)
            {
                macOSWindowComp.GetFramebufferSize(window, out width, out height);
            }
            float aspect = width / (float)height;
            
            Matrix4 model = Matrix4.Identity;
            Matrix4 camera = Matrix4.CreateFromQuaternion(cameraRotation) * Matrix4.CreateTranslation(cameraPosition);
            Matrix4 view = camera.Inverted();
            Matrix4 proj = Matrix4.CreatePerspectiveFieldOfView(cameraFov * MathHelper.DegreesToRadians(1), aspect, cameraNear, cameraFar);

            Matrix4 mvp = model * view * proj;

            GL.UniformMatrix4f(env_program_mvp_location, 1, true, mvp);

            GL.DrawElements(PrimitiveType.Triangles, env_idx.Length, DrawElementsType.UnsignedInt, 0);

            Toolkit.OpenGL.SwapBuffers(context);
        }

        Vector2 delta;
        readonly bool[] keyboardState = new bool[256];
        public bool Update(float deltaTime)
        {
            bool shouldClose = false;

            if (Toolkit.Mouse != null)
            {
                // FIXME: Because we can't check input focus atm we accumulate a
                // mouse delta from events instead of doing this.
                //Program.MouseComponent.GetMouseState(out MouseState state);
                //Vector2 delta = prevPos - state.Position;
                //prevPos = state.Position;

                cameraRotationY += delta.X * cameraRotationSpeed.X * deltaTime;
                cameraRotationX += delta.Y * cameraRotationSpeed.Y * deltaTime;
                cameraRotationX = MathHelper.Clamp(cameraRotationX, -80 * D2R, 80 * D2R);

                cameraRotation = Quaternion.FromAxisAngle(Vector3.UnitY, cameraRotationY) *
                                 Quaternion.FromAxisAngle(Vector3.UnitX, cameraRotationX);

                delta = (0, 0);
            }

            if (Toolkit.Keyboard != null)
            {
                // FIXME: Check input focus...
                Toolkit.Keyboard.GetKeyboardState(keyboardState);
                if (keyboardState[(int)Scancode.A])
                {
                    cameraPosition += (cameraRotation * -Vector3.UnitX) * cameraMovementSpeed * deltaTime;
                }

                if (keyboardState[(int)Scancode.D])
                {
                    cameraPosition += (cameraRotation * Vector3.UnitX) * cameraMovementSpeed * deltaTime;
                }

                if (keyboardState[(int)Scancode.W])
                {
                    cameraPosition += (cameraRotation * -Vector3.UnitZ) * cameraMovementSpeed * deltaTime;
                }

                if (keyboardState[(int)Scancode.S])
                {
                    cameraPosition += (cameraRotation * Vector3.UnitZ) * cameraMovementSpeed * deltaTime;
                }

                if (keyboardState[(int)Scancode.Escape])
                {
                    // FIXME: If we destroy a window while a key is pressed we
                    // never get the KeyUp event this leads to escape
                    // to stay pressed after closing the window.
                    shouldClose = true;
                }
            }

            return shouldClose;
        }

        Vector2 prevPos;
        public void HandleEvent(EventArgs args)
        {
            if (args is MouseMoveEventArgs mouseMove)
            {
                delta += prevPos - mouseMove.Position;
                prevPos = mouseMove.Position;

                Console.WriteLine($"Mouse move: {mouseMove.Position}");
            }
            else if (args is FocusEventArgs focus)
            {
                if (focus.GotFocus)
                {
                    if (Toolkit.Mouse != null)
                    {
                        Toolkit.Mouse.GetPosition(out int x, out int y);
                        prevPos = (x, y);
                    }
                }
            }
        }
    }
}

