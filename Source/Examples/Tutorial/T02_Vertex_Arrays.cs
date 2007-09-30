#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Threading;

using OpenTK;
using OpenTK.OpenGL;
using System.Diagnostics;

namespace Examples.Tutorial
{
    /// <summary>
    /// Demonstrates Vertex Arrays (in system memory).  Example is incomplete (documentation).
    /// </summary>
    class T02_Vertex_Arrays : GameWindow, IExample
    {
        float angle_speed = 3.0f;
        float angle = 0.0f;

        Shapes.Shape shape = new Examples.Shapes.Plane(16, 16, 2.0f, 2.0f);

        System.Threading.Timer info_timer;

        #region Constructor

        public T02_Vertex_Arrays()
        {
            this.CreateWindow(new DisplayMode(800, 600));
            //Thread.CurrentThread.Priority = ThreadPriority.AboveNormal;
            //this.VSync = VSyncMode.Off;
        }

        #endregion

        #region OnLoad

        public override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GL.ClearColor(Color.MidnightBlue);
            GL.Enable(GL.Enums.EnableCap.DEPTH_TEST);
            
            GL.EnableClientState(GL.Enums.EnableCap.VERTEX_ARRAY);
            //GL.EnableClientState(GL.Enums.EnableCap.COLOR_ARRAY);
            GL.VertexPointer(3, GL.Enums.VertexPointerType.FLOAT, 0, shape.Vertices);
            //GL.ColorPointer(4, GL.Enums.ColorPointerType.UNSIGNED_BYTE, 0, shape.Colors);

            factor_target = TargetRenderPeriod / TargetUpdatePeriod;
            info_timer = new Timer(new TimerCallback(PrintDebugInfo), null, 1000, 1000);
        }

        double factor_target;
        void PrintDebugInfo(object o)
        {
            double factor = RenderPeriod / UpdatePeriod;
            Debug.Print("NORMAL: Frame: {0} ({1}), Update: {2} ({3}), Factor: {4}, Error: {5}",
                RenderPeriod.ToString("g8"), RenderFrequency.ToString("g3"), UpdatePeriod.ToString("g8"), UpdateFrequency.ToString("g3"),
                factor.ToString("g8"), Math.Abs(factor_target - factor).ToString("g8"));
        }

        #endregion

        public override void OnUnload(EventArgs e)
        {
            info_timer.Dispose();
        }

        #region OnResize

        /// <summary>
        /// Called when the user resizes the window.
        /// </summary>
        /// <param name="e">Contains the new width/height of the window.</param>
        /// <remarks>
        /// You want the OpenGL viewport to match the window. This is the place to do it!
        /// </remarks>
        protected override void OnResize(OpenTK.Platform.ResizeEventArgs e)
        {
            base.OnResize(e);

            GL.Viewport(0, 0, Width, Height);

            double ratio = e.Width / (double)e.Height;

            GL.MatrixMode(GL.Enums.MatrixMode.PROJECTION);
            GL.LoadIdentity();
            Glu.Perspective(45.0, ratio, 1.0, 64.0);
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
        public override void OnUpdateFrame(UpdateFrameEventArgs e)
        {
            if (Keyboard[OpenTK.Input.Key.Escape])
            {
                this.Exit();
                return;
            }

            if ((Keyboard[OpenTK.Input.Key.AltLeft] || Keyboard[OpenTK.Input.Key.AltRight]) &&
                Keyboard[OpenTK.Input.Key.Enter])
            {
                Fullscreen = !Fullscreen;
            }

            if (Keyboard[OpenTK.Input.Key.Plus])
                TargetRenderFrequency++;
            else if (Keyboard[OpenTK.Input.Key.Minus])
                TargetRenderFrequency--;
            else if (Keyboard[OpenTK.Input.Key.PageUp])
                TargetUpdateFrequency++;
            else if (Keyboard[OpenTK.Input.Key.PageDown])
                TargetUpdateFrequency--;

            if (Keyboard[OpenTK.Input.Key.Space])
                angle_speed = 12.0f;
            else
                angle_speed = 3.0f;
            
            //angle += angle_speed;
        }

        #endregion

        #region OnRenderFrame

        /// <summary>
        /// Place your rendering code here.
        /// </summary>
        public override void OnRenderFrame(RenderFrameEventArgs e)
        {
            GL.Clear(GL.Enums.ClearBufferMask.COLOR_BUFFER_BIT | GL.Enums.ClearBufferMask.DEPTH_BUFFER_BIT);

            GL.MatrixMode(GL.Enums.MatrixMode.MODELVIEW);
            GL.LoadIdentity();
            Glu.LookAt(
                0.0, 5.0, 5.0,
                0.0, 0.0, 0.0,
                0.0, 1.0, 0.0
            );

            //angle += angle_speed * (float)(UpdateFrequency / RenderFrequency);
            //if (e.Time != 0.0)
            if (Math.Abs(e.ScaleFactor - factor_target) > 0.5)
            {
                /*Debug.Print("JITTER: Frame: {0} ({1}), Update: {2} ({3}), Factor: {4}, Error: {5}",
                    RenderPeriod.ToString("g8"), RenderFrequency.ToString("g3"), UpdatePeriod.ToString("g8"), UpdateFrequency.ToString("g3"),
                    e.ScaleFactor.ToString("g8"), Math.Abs(factor_target - e.ScaleFactor).ToString("g8"));*/
            }
            angle += angle_speed * (float)e.ScaleFactor;
            //angle += angle_speed * (float)e.Time;
            if (angle >= 360.0f)
                angle -= 360.0f;
            GL.Rotate(angle, 0.0f, 1.0f, 0.0f);

            GL.DrawElements(GL.Enums.BeginMode.TRIANGLES, shape.Indices.Length,
                GL.Enums.All.UNSIGNED_INT, shape.Indices);

//            GL.DrawArrays(GL.Enums.BeginMode.LINES, 0, shape.Vertices.Length);

            GL.Begin(GL.Enums.BeginMode.TRIANGLES);

            GL.Vertex3(-1.0, -1.0, 5.0);
            GL.Vertex3(1.0, -1.0, 5.0);
            GL.Vertex3(1.0, 1.0, 5.0);

            GL.End();
            
            int zero = GC.CollectionCount(0);
            int one = GC.CollectionCount(1);
            int two = GC.CollectionCount(2);
            
            SwapBuffers();
            //Thread.Sleep(25);
        }

        #endregion

        #region public void Launch()

        /// <summary>
        /// Launches this example.
        /// </summary>
        /// <remarks>
        /// Provides a simple way for the example launcher to launch the examples.
        /// </remarks>
        public void Launch()
        {
            // Lock UpdateFrame rate at 30Hz and RenderFrame rate 85Hz.
            Run(30.0, 20.0);
        }

        #endregion
    }
}
