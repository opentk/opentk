// This code was written for the OpenTK library and has been released
// to the Public Domain.
// It is provided "as is" without express or implied warranty of any kind.

using System;
using System.Collections.Generic;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.ES11;

namespace Examples.Tutorial
{
    public class SimpleES11Window : GameWindow
    {
        float rotation_speed = 3.0f;
        float angle;

        // OpenGL ES resources
        int vbo;
        int ebo;

        struct Vertex
        {
            public Vector3 Position;
            public Color4 Color;

            public Vertex(float x, float y, float z, Color4 color)
            {
                Position = new Vector3(x, y, z);
                Color = color;
            }
        }

        readonly Vertex[] CubeVertices = new Vertex[]
        {
            new Vertex(-1.0f, -1.0f,  1.0f, Color4.DarkRed),
            new Vertex( 1.0f, -1.0f,  1.0f, Color4.DarkRed),
            new Vertex( 1.0f,  1.0f,  1.0f, Color4.Gold),
            new Vertex(-1.0f,  1.0f,  1.0f, Color4.Gold),
            new Vertex(-1.0f, -1.0f, -1.0f, Color4.DarkRed),
            new Vertex( 1.0f, -1.0f, -1.0f, Color4.DarkRed), 
            new Vertex( 1.0f,  1.0f, -1.0f, Color4.Gold),
            new Vertex(-1.0f,  1.0f, -1.0f, Color4.Gold) 
        };

        readonly short[] CubeElements = new short[]
        {
            0, 1, 2, 2, 3, 0, // front face
            3, 2, 6, 6, 7, 3, // top face
            7, 6, 5, 5, 4, 7, // back face
            4, 0, 3, 3, 7, 4, // left face
            0, 1, 5, 5, 4, 0, // bottom face
            1, 5, 6, 6, 2, 1, // right face
        };

        public SimpleES11Window()
            : base(
                800, 600,
                GraphicsMode.Default,
                "OpenTK - ES 1.1 Example",
                GameWindowFlags.Default,
                DisplayDevice.Default,
                1, 1,
                GraphicsContextFlags.Embedded)
        { }

        #region OnLoad

        protected override void OnLoad(EventArgs e)
        {
            Color4 color = Color4.MidnightBlue;
            GL.ClearColor(color.R, color.G, color.B, color.A);

            GL.Enable(EnableCap.DepthTest);

            // Create VBO
            vbo = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo);
            GL.BufferData(BufferTarget.ArrayBuffer,
                (IntPtr)(CubeVertices.Length * BlittableValueType.StrideOf(CubeVertices)),
                CubeVertices,
                BufferUsageHint.StaticDraw);

            ebo = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, ebo);
            GL.BufferData(BufferTarget.ElementArrayBuffer,
                (IntPtr)(CubeElements.Length * BlittableValueType.StrideOf(CubeElements)),
                CubeElements,
                BufferUsageHint.StaticDraw);

            // Ensure the VBO has been created correctly
            int size;
            GL.GetBufferParameter(BufferTarget.ArrayBuffer, BufferParameterName.BufferSize, out size);
            if (CubeVertices.Length * BlittableValueType.StrideOf(CubeVertices) != size)
            {
                throw new ApplicationException("Vertex data not uploaded correctly");
            }

            GL.GetBufferParameter(BufferTarget.ElementArrayBuffer, BufferParameterName.BufferSize, out size);
            if (CubeElements.Length * BlittableValueType.StrideOf(CubeElements) != size)
            {
                throw new ApplicationException("Element data not uploaded correctly");
            }
        }

        #endregion

        #region OnResize

        /// <summary>
        /// Called when the user resizes the window.
        /// </summary>
        /// <param name="e">Contains the new width/height of the window.</param>
        /// <remarks>
        /// You want the OpenGL viewport to match the window. This is the place to do it!
        /// </remarks>
        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
        }

        #endregion

        #region OnUpdateFrame

        /// <summary>
        /// Prepares the next frame for rendering.
        /// </summary>
        /// <remarks>
        /// Place your control logic here. This is the place to respond to user input,
        /// update object positions etc.
        /// </remarks>
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            if (Keyboard[OpenTK.Input.Key.Escape])
            {
                this.Exit();
                return;
            }
        }

        #endregion

        #region OnRenderFrame

        /// <summary>
        /// Place your rendering code here.
        /// </summary>
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            float aspect_ratio = Width / (float)Height;
            Matrix4 perspective = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, aspect_ratio, 1, 64);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref perspective.Row0.X);

            Matrix4 lookat = Matrix4.LookAt(0, 5, 5, 0, 0, 0, 0, 1, 0);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref lookat.Row0.X);

            angle += rotation_speed * (float)e.Time;
            GL.Rotate(angle, 0.0f, 1.0f, 0.0f);

            DrawCube();

            SwapBuffers();
        }

        #endregion

        #region private void DrawCube()

        private void DrawCube()
        {
            GL.EnableClientState(ArrayCap.ColorArray);
            GL.EnableClientState(ArrayCap.VertexArray);

            GL.BindBuffer(BufferTarget.ArrayBuffer,vbo);
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, ebo);

            GL.VertexPointer(3, VertexPointerType.Float,
                BlittableValueType.StrideOf(CubeVertices),
                new IntPtr(0));
            GL.ColorPointer(4, ColorPointerType.Float,
                BlittableValueType.StrideOf(CubeVertices),
                new IntPtr(BlittableValueType<Vector3>.Stride));

            GL.DrawElements(PrimitiveType.Triangles,
                CubeElements.Length,
                DrawElementsType.UnsignedShort,
                IntPtr.Zero);
        }

        #endregion

        #region public static void Main()

        /// <summary>
        /// Entry point of this example.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            using (SimpleES11Window example = new SimpleES11Window())
            {
                example.Run(30.0, 0.0);
            }
        }

        #endregion
    }
}
