// This code was written for the OpenTK library and has been released
// to the Public Domain.
// It is provided "as is" without express or implied warranty of any kind.

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL4;

namespace Examples.Tutorial
{
    [Example("OpenGL 4.0", ExampleCategory.OpenGL, "4.x", Documentation = "HelloGL4")]
    public class HelloGL4 : GameWindow
    {
        private readonly Vector3[] positionVboData = new[]
        {
            new Vector3(-1.0f, -1.0f, 0.0f),
            new Vector3(1.0f, -1.0f, 0.0f),
            new Vector3(0.0f, 1.0f, 0.0f),
        };

        private readonly int[] indexBufferData = new[]
        {
            0, 1, 2
        };

        private readonly DrawElementsIndirectCommand[] indirectDrawCommand = new [] { new DrawElementsIndirectCommand
        {
            count = 3,
            primCount = 1,
            firstIndex = 0,
            baseInstance = 0,
            baseVertex = 0
        } };

        private const string vertexShaderSource = @"
#version 450 core
#extension GL_ARB_shader_draw_parameters : require
#extension GL_ARB_shader_storage_buffer_object : require

layout(location = 0) in vec3 vertexPosition_modelspace;
uniform mat4 ModelView;
uniform mat4 Projection;

void main(){
    gl_Position = Projection * ModelView * vec4(vertexPosition_modelspace,1);
}
";

        private const string fragmentShaderSource = @"
#version 450 core

out vec3 color;

void main(){
    color = vec3(1,1,1);
}
";

        private int vertexArrayId,
                    vertexBufferId,
                    elementBufferId,
                    drawIndirectBufferId;

        private int vertexShaderHandle,
                    fragmentShaderHandle,
                    shaderProgramHandle,
                    projectionMatrixLocation,
                    modelviewMatrixLocation;

        Matrix4 projectionMatrix, modelviewMatrix;

        public HelloGL4()
            : base(640, 480,
            new GraphicsMode(), "OpenGL 4 Example", 0,
			DisplayDevice.Default, 4, 5,
            GraphicsContextFlags.ForwardCompatible | GraphicsContextFlags.Debug)
        { }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.BindVertexArray(vertexArrayId);
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, elementBufferId);
            GL.BindBuffer(BufferTarget.DrawIndirectBuffer, drawIndirectBufferId);
            GL.MultiDrawElementsIndirect(PrimitiveType.Triangles, DrawElementsType.UnsignedInt, IntPtr.Zero, 1, Marshal.SizeOf(indirectDrawCommand[0]));

            SwapBuffers();
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            Matrix4 rotation = Matrix4.CreateRotationY((float)e.Time);
            Matrix4.Mult(ref rotation, ref modelviewMatrix, out modelviewMatrix);
            GL.UniformMatrix4(modelviewMatrixLocation, false, ref modelviewMatrix);

            var keyboard = OpenTK.Input.Keyboard.GetState();
            if (keyboard[OpenTK.Input.Key.Escape])
                Exit();
        }

        protected override void OnResize(EventArgs e)
        {
            float aspectRatio = ClientSize.Width / (float)(ClientSize.Height);
            Matrix4.CreatePerspectiveFieldOfView((float)Math.PI / 4, aspectRatio, 1, 100, out projectionMatrix);
            modelviewMatrix = Matrix4.LookAt(new Vector3(0, 3, 5), new Vector3(0, 0, 0), new Vector3(0, 1, 0));

            GL.UniformMatrix4(projectionMatrixLocation, false, ref projectionMatrix);
        }

        protected override void OnLoad(System.EventArgs e)
        {
            VSync = VSyncMode.On;

            CreateBuffers();
            CreateShaders();

            // Other state
            GL.Enable(EnableCap.DepthTest);
            GL.ClearColor(System.Drawing.Color.MidnightBlue);
        }

        private void CreateShaders()
        {
            // compile our vertex and fragment shaders
            fragmentShaderHandle = GL.CreateShader(ShaderType.FragmentShader);
            vertexShaderHandle = GL.CreateShader(ShaderType.VertexShader);

            GL.ShaderSource(fragmentShaderHandle, fragmentShaderSource);
            GL.ShaderSource(vertexShaderHandle, vertexShaderSource);

            GL.CompileShader(fragmentShaderHandle);
            GL.CompileShader(vertexShaderHandle);

            Debug.WriteLine(GL.GetShaderInfoLog(fragmentShaderHandle));
            Debug.WriteLine(GL.GetShaderInfoLog(vertexShaderHandle));
            CheckErrors();

            // put these into a program that we can use
            shaderProgramHandle = GL.CreateProgram();

            GL.AttachShader(shaderProgramHandle, vertexShaderHandle);
            GL.AttachShader(shaderProgramHandle, fragmentShaderHandle);

            GL.LinkProgram(shaderProgramHandle);
            Debug.WriteLine(GL.GetProgramInfoLog(shaderProgramHandle));
            GL.UseProgram(shaderProgramHandle);
            CheckErrors();

            // set the uniforms for this shader program
            projectionMatrixLocation = GL.GetUniformLocation(shaderProgramHandle, "Projection");
            modelviewMatrixLocation = GL.GetUniformLocation(shaderProgramHandle, "ModelView");

            float aspectRatio = ClientSize.Width / (float)(ClientSize.Height);
            Matrix4.CreatePerspectiveFieldOfView((float)Math.PI / 4, aspectRatio, 1, 100, out projectionMatrix);
            modelviewMatrix = Matrix4.LookAt(new Vector3(0, 3, 5), new Vector3(0, 0, 0), new Vector3(0, 1, 0));

            GL.UniformMatrix4(projectionMatrixLocation, false, ref projectionMatrix);
            GL.UniformMatrix4(modelviewMatrixLocation, false, ref modelviewMatrix);
            CheckErrors();
        }

        private void CreateBuffers()
        {
            // this buffer will store our vertex data
            GL.CreateBuffers(1, out vertexBufferId);
            GL.NamedBufferStorage(vertexBufferId, positionVboData.Length * Vector3.SizeInBytes, positionVboData, BufferStorageFlags.None);
            CheckErrors();

            // this buffer will tell OpenGL what data to put where
            GL.CreateVertexArrays(1, out vertexArrayId);
            GL.EnableVertexArrayAttrib(vertexArrayId, 0);
            GL.VertexArrayAttribBinding(vertexArrayId, 0, 0);
            GL.VertexArrayAttribFormat(vertexArrayId, 0, 3, VertexAttribType.Float, false, 0);
            GL.VertexArrayVertexBuffer(vertexArrayId, 0, vertexBufferId, IntPtr.Zero, 3 * sizeof(float));
            CheckErrors();

            // this buffer specifies the indices of the vertex data in the first buffer
            GL.CreateBuffers(1, out elementBufferId);
            GL.NamedBufferStorage(elementBufferId, indexBufferData.Length * Vector3.SizeInBytes, indexBufferData, BufferStorageFlags.None);
            CheckErrors();

            // this buffer tells OpenGL how many of what to attempt to draw
            GL.CreateBuffers(1, out drawIndirectBufferId);
            GL.NamedBufferStorage(drawIndirectBufferId, indirectDrawCommand.Length * Marshal.SizeOf(indirectDrawCommand[0]), indirectDrawCommand, BufferStorageFlags.None);
            CheckErrors();
        }

        private void CheckErrors()
        {
            var error = GL.GetError();
            if (error != ErrorCode.NoError)
            {
                Debug.Print("Encountered OpenGL Error: " + error);
                throw new InvalidOperationException(error.ToString());
            }
        }

        [STAThread]
        public static void Main()
        {
            using (var example = new HelloGL4())
            {
                Utilities.SetWindowTitle(example);
                example.Run(60);
            }
        }

        private struct DrawElementsIndirectCommand
        {
            public uint count;
            public uint primCount;
            public uint firstIndex;
            public uint baseVertex;
            public uint baseInstance;
        }
    }
}
