#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

using OpenTK;
using OpenTK.Graphics.OpenGL;
using Examples.Shapes;

namespace Examples.Tutorial
{
    /// <summary>
    /// Demonstrates fixed-function OpenGL lighting.  Example is incomplete (documentation).
    /// </summary>
    [Example("Vertex Lighting", ExampleCategory.OpenGL, "1.1", false)]
    public class T04_Vertex_Lighting : GameWindow
    {
        float x_angle, zoom;
        Shape shape = new Plane(16, 16, 4.0f, 4.0f);

        #region Constructor

        public T04_Vertex_Lighting() : base(800, 600)
        {
        }

        #endregion

        #region OnLoad

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GL.ClearColor(Color.MidnightBlue);
            GL.Enable(EnableCap.DepthTest);
            //GL.Enable(GL.Enums.EnableCap.CULL_FACE);
            
            GL.EnableClientState(EnableCap.VertexArray);
            GL.EnableClientState(EnableCap.NormalArray);
            GL.VertexPointer(3, VertexPointerType.Float, 0, shape.Vertices);
            GL.NormalPointer(NormalPointerType.Float, 0, shape.Normals);

            // Enable Light 0 and set its parameters.
            GL.Light(LightName.Light0, LightParameter.Position, new float[] { 1.0f, 1.0f, -0.5f });
            GL.Light(LightName.Light0, LightParameter.Ambient, new float[] { 0.3f, 0.3f, 0.3f, 1.0f });
            GL.Light(LightName.Light0, LightParameter.Diffuse, new float[] { 1.0f, 1.0f, 1.0f, 1.0f });
            GL.Light(LightName.Light0, LightParameter.Specular, new float[] { 1.0f, 1.0f, 1.0f, 1.0f });
            GL.Light(LightName.Light0, LightParameter.SpotExponent, new float[] { 1.0f, 1.0f, 1.0f, 1.0f });
            GL.LightModel(LightModelParameter.LightModelAmbient, new float[] { 0.2f, 0.2f, 0.2f, 1.0f });
            GL.LightModel(LightModelParameter.LightModelTwoSide, 1);
            GL.LightModel(LightModelParameter.LightModelLocalViewer, 1);
            GL.Enable(EnableCap.Lighting);
            GL.Enable(EnableCap.Light0);

            // Use GL.Material to set your object's material parameters.
            GL.Material(MaterialFace.Front, MaterialParameter.Ambient, new float[] { 0.3f, 0.3f, 0.3f, 1.0f });
            GL.Material(MaterialFace.Front, MaterialParameter.Diffuse, new float[] { 1.0f, 1.0f, 1.0f, 1.0f });
            GL.Material(MaterialFace.Front, MaterialParameter.Specular, new float[] { 1.0f, 1.0f, 1.0f, 1.0f });
            GL.Material(MaterialFace.Front, MaterialParameter.Emission, new float[] { 0.0f, 0.0f, 0.0f, 1.0f });
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
            base.OnResize(e);

            GL.Viewport(0, 0, Width, Height);

            float aspect_ratio = Width / (float)Height;
            Matrix4 perpective = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, aspect_ratio, 1, 64);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref perpective);
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

            if (Keyboard[OpenTK.Input.Key.F11])
                if (WindowState != WindowState.Fullscreen)
                    WindowState = WindowState.Fullscreen;
                else
                    WindowState = WindowState.Normal;

            if (Mouse[OpenTK.Input.MouseButton.Left])
                x_angle = Mouse.X;
            else
                x_angle += 0.5f;

             zoom = Mouse.Wheel * 0.5f;   // Mouse.Wheel is broken on both Linux and Windows.

            // Do not leave x_angle drift too far away, as this will cause inaccuracies.
            if (x_angle > 360.0f)
                x_angle -= 360.0f;
            else if (x_angle < -360.0f)
                x_angle += 360.0f;
        }

        #endregion

        #region OnRenderFrame

        /// <summary>
        /// Place your rendering code here.
        /// </summary>
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            Matrix4 lookat = Matrix4.LookAt(0, 0, -7.5f + zoom, 0, 0, 0, 0, 1, 0);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref lookat);

            GL.Rotate(x_angle, 0.0f, 1.0f, 0.0f);

            GL.Begin(BeginMode.Triangles);
            foreach (int index in shape.Indices)
            {
                GL.Normal3(shape.Normals[index]);
                GL.Vertex3(shape.Vertices[index]);
            }
            GL.End();

            SwapBuffers();
        }

        #endregion

        #region public void Launch()

        /// <summary>
        /// Launches this example.
        /// </summary>
        /// <remarks>
        /// Provides a simple way for the example launcher to launch the examples.
        /// </remarks>
        public static void Main()
        {
            using (T04_Vertex_Lighting example = new T04_Vertex_Lighting())
            {
                Utilities.SetWindowTitle(example);
                example.Run(30.0, 0.0);
            }
        }

        #endregion
    }
}
