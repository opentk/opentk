#region --- License ---
/* This source file is released under the MIT license. See License.txt for more information.
 * Coded by Stephen Apostolopoulos.
 */
#endregion

#region --- Using Directives ---

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using OpenTK.OpenGL;

#endregion --- Using Directives ---

namespace OpenTK.Examples.OpenGL.Basic.DisplayLists
{
    public partial class DisplayLists : Framework
    {
        #region --- Variables ---

        List<DisplayList> lists = new List<DisplayList>();

        #endregion --- Variables ---

        #region --- Methods ---

        [STAThread]
        public static void Main()
        {
            new DisplayLists().Run();
        }

        #endregion --- Methods ---

        #region --- Event Handlers ---

        #region OnLoad

        protected override void OnLoad(object sender, EventArgs e)
        {
            base.OnLoad(sender, e);

            Text =
                "DisplayLists example (" +
                GL.GetString(Enums.StringName.RENDERER) + " " +
                GL.GetString(Enums.StringName.VERSION)
                + ")";

            GL.ClearColor(0.1f, 0.1f, 0.5f, 0.0f);
            GL.Enable(Enums.EnableCap.DEPTH_TEST);

            // Build some display lists.
            float c = 0;
            const int numDisplayLists = 9;
            for (int i = numDisplayLists; i > 0; i--)
            {
                DisplayList d = new DisplayList();

                d.Begin();

                GL.Color3d(
                    1.0,
                    c,
                    1 - c
                );

                GL.Begin(Enums.BeginMode.QUADS);

                GL.Vertex3f(-1.0f, -1.0f, 1.0f);
                GL.Vertex3f( 1.0f, -1.0f, 1.0f);
                GL.Vertex3f( 1.0f,  1.0f, 1.0f);
                GL.Vertex3f(-1.0f,  1.0f, 1.0f);

                GL.End();

                d.End();

                lists.Add(d);

                c += 1 / (float)numDisplayLists;
            }

            OnResize(this, null);
        }

        #endregion

        #region OnResize

        protected override void OnResize(object sender, EventArgs e)
        {
            base.OnResize(sender, e);

            if (ClientSize.Height == 0)
                ClientSize = new System.Drawing.Size(ClientSize.Width, 1);

            GL.Viewport(0, 0, ClientSize.Width, ClientSize.Height);

            double ratio = 0.0;
            ratio = ClientSize.Width / (double)ClientSize.Height;

            GL.MatrixMode(Enums.MatrixMode.PROJECTION);
            GL.LoadIdentity();
            Glu.Perspective(45.0, ratio, 1.0, 64.0);
            Glu.LookAt(
                0.0, 0.0, 16.0,
                0.0, 0.0, 0.0,
                0.0, 1.0, 0.0
            );
        }

        #endregion

        #region OnPaint

        protected override void OnPaint()
        {
            GL.MatrixMode(Enums.MatrixMode.MODELVIEW);
            GL.LoadIdentity();

            GL.Clear(Enums.ClearBufferMask.COLOR_BUFFER_BIT | Enums.ClearBufferMask.DEPTH_BUFFER_BIT);

            double angle = 0.0;
            foreach (DisplayList d in lists)
            {
                GL.LoadIdentity();
                GL.Rotated(angle, 0.0, 0.0, 1.0);
                GL.Translated(5.0, 0.0, 0.0);

                d.Render();
                angle += 360 / lists.Count;
            }


            ActiveContext.SwapBuffers();
        }

        #endregion

        #region OnKeyDown

        protected override void OnKeyDown(object sender, KeyEventArgs e)
        {
            base.OnKeyDown(sender, e);

            switch (e.KeyData)
            {
                case Keys.Escape:
                    Application.Exit();
                    break;

                case Keys.F1:
                    this.SetResolution(this.Width, this.Height, this.ColorDepth, !this.IsFullscreen);
                    break;
            }
        }

        #endregion

        #endregion --- Event Handlers ---
    }
}