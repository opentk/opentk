using System;
using System.Collections.Generic;
using System.Text;
using OpenTK;
using OpenTK.OpenGL;

namespace Examples.Tests
{
    public class S03_Stack_Imbalance : GameWindow//, IExample
    {
        public S03_Stack_Imbalance()
        {
            this.CreateWindow(new DisplayMode(800, 600));
        }

        #region IExample Members

        public void Launch()
        {
            this.Run();
        }

        #endregion

        protected override void OnResize(OpenTK.Platform.ResizeEventArgs e)
        {
            GL.Ortho(-1.0, 1.0, -1.0, 1.0, 1.0, 32.0);
            
            base.OnResize(e);
        }

        float[] proj = new float[16];
        public override void OnRenderFrame(EventArgs e)
        {
            GL.Clear(GL.Enums.ClearBufferMask.COLOR_BUFFER_BIT);

            GL.GetFloat(GL.Enums.GetPName.PROJECTION_MATRIX, proj);

            float sum = 0.0f;
            for (int i = 0; i < 16; i++)
            {
                sum += proj[i];
            }

            if (sum == 0)
            {
                throw new Exception("GetFloat did not return anything!");
            }


            GL.Begin(GL.Enums.BeginMode.TRIANGLES);

            GL.Color3(System.Drawing.Color.Chartreuse);
            GL.Vertex3(-1.0, -1.0, 2.0);
            GL.Color3(System.Drawing.Color.Crimson);
            GL.Vertex3( 1.0, -1.0, 2.0);
            GL.Color3(System.Drawing.Color.DarkGoldenrod);
            GL.Vertex3( 0.0,  1.0, 2.0);

            GL.End();

            Context.SwapBuffers();
            
            base.OnRenderFrame(e);
        }
    }
}
