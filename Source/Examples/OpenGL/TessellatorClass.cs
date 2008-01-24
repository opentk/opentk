#region --- License ---
/* Copyright (c) 2006-2008 the OpenTK team
 * See license.txt for licensing details
 */
#endregion

using System;
using System.Diagnostics;

using OpenTK;
using OpenTK.OpenGL;
using OpenTK.OpenGL.Enums;
using OpenTK.OpenAL;
using OpenTK.OpenAL.Enums;
using OpenTK.Audio;
using OpenTK.Input;
using System.Runtime.InteropServices;
using OpenTK.Math;

namespace Examples
{
#if false
    /// <summary>
    /// Defines a single Vertex in 3d space, with double-precision numerals.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    class Vertex : CustomVertex
    {
        #region --- Constructors ---

        /// <summary>
        /// Constructs a new Vertex.
        /// </summary>
        /// <param name="x">The position of the Vertex on the x-axis.</param>
        /// <param name="y">The position of the Vertex on the y-axis.</param>
        /// <param name="z">The position of the Vertex on the z-axis.</param>
        public Vertex(double x, double y, double z)
            : this(new Vector3d(x, y, z)) { }

        /// <summary>
        /// Constructs a new Vertex.
        /// </summary>
        /// <param name="v">The position of the Vertex.</param>
        public Vertex(Vector3d v)
        {
            Position = v;
        }

        #endregion

        /// <summary>
        /// The position of this verrtex.
        /// </summary>
        public Vector3d Position;

        public override double[] ToArray()
        {
            return new double[] { Position.X, Position.Y, Position.Z };
        }
    }

    [Example("GLU Tesselation Functions Test", ExampleCategory.OpenGL)]
    public class GluTesselation : GameWindow
    {
        /*
        Vertex[] rect = new Vertex[4]
        {
            new Vertex(50.0f, 50.0f, 0.0f),
            new Vertex(200.0f, 50.0f, 0.0f),
            new Vertex(200.0f, 200.0f, 0.0f),
            new Vertex(50.0f, 200.0f, 0.0f)
        };
        */

        Vertex[] rect = new Vertex[4]
        {
                new Vertex(50.0, 50.0, 0.0),
                new Vertex(200.0, 50.0, 0.0),
                new Vertex(200.0, 200.0, 0.0),
                new Vertex(50.0, 200.0, 0.0)
        };
        Vertex[] tri = new Vertex[3]
        {
                new Vertex(75.0f, 75.0f, 0.0f),
                new Vertex(125.0f, 175.0f, 0.0f),
                new Vertex(175.0f, 75.0f, 0.0f)
        };
        double[][] star = new double[5][] {
                new double[] {250.0f, 50.0f, 0.0f, 1.0f, 0.0f, 1.0f},
                new double[] {325.0f, 200.0f, 0.0f, 1.0f, 1.0f, 0.0f},
                new double[] {400.0f, 50.0f, 0.0f, 0.0f, 1.0f, 1.0f},
                new double[] {250.0f, 150.0f, 0.0f, 1.0f, 0.0f, 0.0f},
                new double[] {400.0f, 150.0f, 0.0f, 0.0f, 1.0f, 0.0f}
            };

        Tessellator<double[]> tess = new Tessellator<double[]>();
        int startList;

        public GluTesselation()
            : base()
        {
            Keyboard.KeyDown += KeyDownHandler;
        }

        #region --- GLU Tessellation callbacks ---

        #region BeginHandler

        void BeginHandler(BeginMode mode)
        {
            GL.Begin(mode);
        }

        #endregion

        #region EndHandler

        void EndHandler()
        {
            GL.End();
        }

        #endregion

        #region VertexHandler

        void VertexHandler(IntPtr v)
        {
            unsafe { GL.Vertex3((double*)v); }
        }

        #endregion

        #region ErrorHandler

        void ErrorHandler(GluErrorCode code)
        {
            System.Windows.Forms.MessageBox.Show(
                String.Format("GLU Error {0}: {1}", code.ToString(), Glu.ErrorString(code)),
                "An error occured while tesselating.");
            this.Exit();
        }

        #endregion

        #region CombineHandler

        unsafe double*[] combineData = new double*[16];
        int data_index = 0;
        unsafe void CombineHandler(double[] coordinates, CustomVertex[] dataIn, float[] weight, out CustomVertex[] dataOut)
        {
            Vertex[] results = new Vertex[2];
            Vertex[] data = (Vertex[])dataIn;

            results[0].Position.X = coordinates[0];
            results[0].Position.Y = coordinates[1];
            results[0].Position.Z = coordinates[2];

            results[1].Position.X = weight[0] * data[0].Position.X +
                                    weight[1] * data[0].Position.X +
                                    weight[2] * data[0].Position.X +
                                    weight[3] * data[0].Position.X;

            results[1].Position.Y = weight[0] * data[0].Position.Y +
                                    weight[1] * data[0].Position.Y +
                                    weight[2] * data[0].Position.Y +
                                    weight[3] * data[0].Position.Y;


            results[1].Position.Z = weight[0] * data[0].Position.Z +
                                    weight[1] * data[0].Position.Z +
                                    weight[2] * data[0].Position.Z +
                                    weight[3] * data[0].Position.Z;

            dataOut = (CustomVertex[])results;
        }

        #endregion

        #endregion

        #region KeyDownHandler

        public void KeyDownHandler(KeyboardDevice sender, Key key)
        {
            switch (key)
            {
                case Key.Escape:
                    this.Exit();
                    return;
            }
        }

        #endregion

        #region OnResize

        protected override void OnResize(OpenTK.Platform.ResizeEventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            Glu.Ortho2D(0.0, (double)Width, 0.0, (double)Height);
        }

        #endregion

        #region OnLoad

        public override void OnLoad(EventArgs e)
        {
            GL.ClearColor(System.Drawing.Color.SteelBlue);

            // Create a rectangle with a triangle cut out from its middle.
            tess.BeginCallback += this.BeginHandler;
            tess.EndCallback += this.EndHandler;
            tess.ErrorCallback += this.ErrorHandler;
            tess.CombineCallback += this.CombineHandler;
            tess.VertexCallback += this.VertexHandler;

            startList = GL.GenLists(2);
            GL.NewList(startList, ListMode.Compile);
            GL.ShadeModel(ShadingModel.Flat);

            tess.BeginPolygon(null);

            tess.BeginContour();
            tess.Vertex(rect[0], rect[0]);
            tess.Vertex(rect[1], rect[1]);
            tess.Vertex(rect[2], rect[2]);
            tess.Vertex(rect[3], rect[3]);
            tess.EndContour();

            tess.BeginContour();
            tess.Vertex(tri[0], tri[0]);
            tess.Vertex(tri[1], tri[1]);
            tess.Vertex(tri[2], tri[2]);
            tess.EndContour();

            tess.EndPolygon();

            GL.EndList();

            ErrorCode code = GL.GetError();
            if (code != ErrorCode.NoError)
                throw new Exception(String.Format("OpenGL Error \"{0}\": {1}", code.ToString(), Glu.ErrorString(code)));

            tess.Dispose();
            
            // Create a self-intersecting star
            tess = new Tessellator<double[]>();
            tess.BeginCallback += this.BeginHandler;
            tess.EndCallback += this.EndHandler;
            tess.ErrorCallback += this.ErrorHandler;
            tess.CombineCallback += this.CombineHandler;
            tess.VertexCallback += this.VertexHandler;

            GL.NewList(startList + 1, ListMode.Compile);
            GL.ShadeModel(ShadingModel.Smooth);
            tess.WindingRule(TessWinding.TessWindingPositive);
            
            tess.BeginPolygon(null);
            
            tess.BeginContour();
            tess.Vertex(star[0], star[0]);
            tess.Vertex(star[1], star[1]);
            tess.Vertex(star[2], star[2]);
            tess.Vertex(star[3], star[3]);
            //tess.Vertex(star[4], star[4]);
            tess.EndContour();
            
            tess.EndPolygon();

            GL.EndList();

            tess.Dispose();
            tess = null;

            code = GL.GetError();
            if (code != ErrorCode.NoError)
                throw new Exception(String.Format("OpenGL Error \"{0}\": {1}", code.ToString(), Glu.ErrorString(code)));
        }

        #endregion

        #region OnUnload

        public override void OnUnload(EventArgs e)
        {
            GL.DeleteLists(startList, 3);
        }

        #endregion

        #region OnRenderFrame

        public override void OnRenderFrame(RenderFrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);

            GL.Color3(1.0f, 1.0f, 1.0f);
            GL.CallList(startList);
            GL.CallList(startList + 1);
            GL.Flush();

            this.SwapBuffers();
        }

        #endregion

        public static void Main()
        {
            using (GluTesselation test = new GluTesselation())
            {
                Utilities.SetWindowTitle(test);
                test.Run(30.0, 0.0);
            }
        }
    }
#endif
}