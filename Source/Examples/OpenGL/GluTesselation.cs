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

namespace Examples
{
    [Example("GLU Tesselation Functions Test", ExampleCategory.OpenGL)]
    public class Test : GameWindow
    {
        int startList;
        IntPtr tess;

        delegate void ErrorCallbackDelegate(GluErrorCode code);
        ErrorCallbackDelegate tessError;

        unsafe delegate void CombineCallbackDelegate(
            [MarshalAs(UnmanagedType.LPArray, SizeConst = 3)]double[] coordinates,
            [MarshalAs(UnmanagedType.LPArray, SizeConst = 4)]IntPtr[] vertexData,
            [MarshalAs(UnmanagedType.LPArray, SizeConst = 4)]float[] weight,
            void** dataOut);
        CombineCallbackDelegate tessCombine;

        delegate void BeginCallbackDelegate(BeginMode mode);
        BeginCallbackDelegate tessBegin;

        delegate void EndCallbackDelegate();
        EndCallbackDelegate tessEnd;

        unsafe delegate void VertexCallbackDelegate(IntPtr v);
        VertexCallbackDelegate tessVertex;

        public Test() : base()
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
        unsafe void CombineHandler(double[] coordinates, IntPtr[] data, float[] weight, void** dataOut)
        {
            double* out_data = combineData[data_index] = (double*)Marshal.AllocHGlobal(6 * sizeof(double));
            int i;

            out_data[0] = coordinates[0];
            out_data[1] = coordinates[1];
            out_data[2] = coordinates[2];

            for (i = 3; i < 6; i++)
            {
                double* real_data = (double*)data[i-3];
                out_data[i] = weight[0] * real_data[0] +
                              weight[1] * real_data[1] +
                              weight[2] * real_data[2] +
                              weight[3] * real_data[3];
            }
            data_index++;

            *dataOut = out_data;
        }

        #endregion

        #endregion

        #region KeyDownHandler

        public void KeyDownHandler(KeyboardDevice sender, Key key)
        {
            if (Keyboard[Key.Escape])
                this.Exit();
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
            IntPtr tess;

            double[][] rect = new double[4][] {
                new double[] {50.0, 50.0, 0.0},
                new double[] {200.0, 50.0, 0.0},
                new double[] {200.0, 200.0, 0.0},
                new double[] {50.0, 200.0, 0.0}
            };
            double[][] tri = new double[3][] {
                new double[] {75.0, 75.0, 0.0},
                new double[] {125.0, 175.0, 0.0},
                new double[] {175.0, 75.0, 0.0}
            };
            double[][] star = new double[5][] {
                new double[] {250.0, 50.0, 0.0, 1.0, 0.0, 1.0},
                new double[] {325.0, 200.0, 0.0, 1.0, 1.0, 0.0},
                new double[] {400.0, 50.0, 0.0, 0.0, 1.0, 1.0},
                new double[] {250.0, 150.0, 0.0, 1.0, 0.0, 0.0},
                new double[] {400.0, 150.0, 0.0, 0.0, 1.0, 0.0}
            };

            GL.ClearColor(0.0f, 0.0f, 0.0f, 0.0f);

            tess = Glu.NewTess();
            startList = GL.GenLists(3);

            //tessVertex = GL.GetDelegate("glVertex3fv");
            //tessBegin = GL.GetDelegate("glBegin");
            //tessEnd = GL.GetDelegate("glEnd");
            unsafe { tessVertex = this.VertexHandler; }
            tessBegin = this.BeginHandler;
            tessEnd = this.EndHandler;
            tessError = this.ErrorHandler;
            unsafe { tessCombine = this.CombineHandler; }
            Trace.Assert(tessVertex != null, "Failed to load tesselator callback function.");
            Trace.Assert(tessBegin != null, "Failed to load tesselator begin callback function.");
            Trace.Assert(tessEnd != null, "Failed to load tesselator end callback function.");
            Trace.Assert(tessError != null, "Failed to load tesselator error callback function.");
            Trace.Assert(tessCombine != null, "Failed to load tesselator combine callback function.");

            Glu.TessCallback(tess, TessCallback.TessVertex, tessVertex);
            Glu.TessCallback(tess, TessCallback.TessBegin, tessBegin);
            Glu.TessCallback(tess, TessCallback.TessEnd, tessEnd);
            Glu.TessCallback(tess, TessCallback.TessError, tessError);

            // rectangle with triangular hole inside
            GL.NewList(startList, ListMode.Compile);
            GL.ShadeModel(ShadingModel.Flat);
            Glu.TessBeginPolygon(tess, IntPtr.Zero);
            Glu.TessBeginContour(tess);
            Glu.TessVertex(tess, rect[0], rect[0]);
            Glu.TessVertex(tess, rect[1], rect[1]);
            Glu.TessVertex(tess, rect[2], rect[2]);
            Glu.TessVertex(tess, rect[3], rect[3]);
            Glu.TessEndContour(tess);
            Glu.TessBeginContour(tess);
            Glu.TessVertex(tess, tri[0], tri[0]);
            Glu.TessVertex(tess, tri[1], tri[1]);
            Glu.TessVertex(tess, tri[2], tri[2]);
            Glu.TessEndContour(tess);
            Glu.TessEndPolygon(tess);
            GL.EndList();
            
            Glu.TessCallback(tess, TessCallback.TessVertex, tessVertex);
            Glu.TessCallback(tess, TessCallback.TessBegin, tessBegin);
            Glu.TessCallback(tess, TessCallback.TessEnd, tessEnd);
            Glu.TessCallback(tess, TessCallback.TessError, tessError);
            Glu.TessCallback(tess, TessCallback.TessCombine, tessCombine);

            // smooth shaded, self-intersecting star
            GL.NewList(startList + 1, ListMode.Compile);
            GL.ShadeModel(ShadingModel.Smooth);
            Glu.TessWindingRuleProperty(tess, TessWinding.TessWindingPositive);
            Glu.TessBeginPolygon(tess, IntPtr.Zero);
            Glu.TessBeginContour(tess);
            Glu.TessVertex(tess, star[0], star[0]);
            Glu.TessVertex(tess, star[1], star[1]);
            Glu.TessVertex(tess, star[2], star[2]);
            Glu.TessVertex(tess, star[3], star[3]);
            Glu.TessVertex(tess, star[4], star[4]);
            Glu.TessEndContour(tess);
            Glu.TessEndPolygon(tess);
            GL.EndList();
            
            /*
            double[][] v = new double[][]
            {
                new double[] {50.0, 50.0, 0.0},
                new double[] {200.0, 50.0, 0.0},
                new double[] {200.0, 200.0, 0.0},
                new double[] {100.0, 100.0, 0.0},
                new double[] {150.0, 100.0, 0.0},
                new double[] {150.0, 150.0, 0.0},
                new double[] {100.0, 150.0, 0.0}
            };

            tess = Glu.NewTess();

            GL.NewList(startList, ListMode.Compile);
            Glu.TessBeginPolygon(tess, IntPtr.Zero);
            Glu.TessBeginContour(tess);
            Glu.TessVertex(tess, v[0], v[0]);
            Glu.TessVertex(tess, v[1], v[1]);
            Glu.TessVertex(tess, v[2], v[2]);
            Glu.TessVertex(tess, v[3], v[3]);
            Glu.TessEndContour(tess);
            Glu.TessBeginContour(tess);
            Glu.TessVertex(tess, v[4], v[4]);
            Glu.TessVertex(tess, v[5], v[5]);
            Glu.TessVertex(tess, v[6], v[6]);
            Glu.TessEndContour(tess);
            Glu.TessEndPolygon(tess);
            GL.EndList();

            GL.NewList(startList + 2, ListMode.Compile);
            GL.Begin(BeginMode.Triangles);
            GL.Vertex2(0, 0);
            GL.Vertex2(Width/16, Height/16);
            GL.Vertex2(0, Height/16);
            GL.End();
            GL.EndList();
            */
        }

        #endregion

        #region OnUnload

        public override void OnUnload(EventArgs e)
        {
            if (tess != IntPtr.Zero)
                Glu.DeleteTess(tess);
            GL.DeleteLists(startList, 3);
            while (data_index != 0)
            {
                unsafe { Marshal.FreeHGlobal((IntPtr)combineData[data_index--]); }
            }
            
        }

        #endregion

        #region OnRenderFrame

        public override void OnRenderFrame(RenderFrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);

            GL.Color3(1.0f, 1.0f, 1.0f);
            GL.CallList(startList);
            GL.CallList(startList + 1);
            //GL.CallList(startList + 2);
            GL.Flush();

            this.SwapBuffers();
        }

        #endregion

        public static void Main()
        {
            using (Test test = new Test())
            {
                Utilities.SetWindowTitle(test);
                test.Run(30.0, 0.0);
            }
        }
    }
}