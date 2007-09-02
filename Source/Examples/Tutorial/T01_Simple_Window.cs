#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Diagnostics;

using OpenTK;
using OpenTK.OpenGL;

namespace Examples.Tutorial
{
    public class T01_Simple_Window : GameWindow, IExample
    {
        public T01_Simple_Window()
        {
            this.CreateWindow(new DisplayMode(800, 600));
        }

        /// <summary>
        /// Override the OnRenderFrame method to add your drawing code.
        /// Do not forget to call base.OnRenderFrame() so that event listeners
        /// will be notified every time a frame is drawn!
        /// </summary>
        /// <param name="e">Not used.</param>
        public override void OnRenderFrame(EventArgs e)
        {
            GL.Clear(GL.Enums.ClearBufferMask.COLOR_BUFFER_BIT);

            GL.Begin(GL.Enums.BeginMode.TRIANGLES);

            GL.Color3(Color.SpringGreen);
            GL.Vertex2(-1.0f, 1.0f);
            GL.Color3(Color.SteelBlue);
            GL.Vertex2(0.0f, -1.0f);
            GL.Color3(Color.PeachPuff);
            GL.Vertex2(1.0f, 1.0f);

            GL.End();

            Context.SwapBuffers();

            base.OnRenderFrame(e);
        }

        #region IExample Members

        public void Launch()
        {
            this.Run();
        }

        #endregion
    }
}
