using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using OpenTK.OpenGL;
using System.Threading;
using System.Runtime.InteropServices;

namespace Examples.Tests
{
    public partial class S01_Call_Performance : Form, IExample
    {
        public S01_Call_Performance()
        {
            InitializeComponent();

            Application.Idle += new EventHandler(Application_Idle);

            // Force opengl functions
            GL.Viewport(0, 0, this.Width, this.Height);

            this.ShowDialog();
        }

        bool run = false;

        float[] v = new float[] { 0.0f, 0.0f };

        int i = 0;
        void dummy()
        {
            unsafe
            {
                //fixed (int* i_ptr = &i)
                {
                    GCHandle h = GCHandle.Alloc(i, GCHandleType.Pinned);//.FromIntPtr((IntPtr)i_ptr);
                    try
                    {
                        i = (int)h.AddrOfPinnedObject();
                    }
                    finally
                    {
                        h.Free();
                    }
                }
            }
        }

        [DllImport("opengl32.dll", EntryPoint = "glVertex2f")]
        extern static void glVertex2f_1(float a, float b);

        [System.Security.SuppressUnmanagedCodeSecurity()]
        [DllImport("opengl32.dll", EntryPoint = "glVertex2f")]
        extern static void glVertex2f_2(float a, float b);

        [System.Security.SuppressUnmanagedCodeSecurity()]
        [DllImport("opengl32.dll", EntryPoint = "glVertex2fv")]
        extern static void glVertex2fv(float[] v);

        void Application_Idle(object sender, EventArgs e)
        {
            long count = 0;
            bool stop = false;

            if (!run)
            {
                run = true;

                GL.Clear(
                    GL.Enums.ClearBufferMask.COLOR_BUFFER_BIT |
                    GL.Enums.ClearBufferMask.DEPTH_BUFFER_BIT);

                //GL.Begin(GL.Enums.BeginMode.POINTS);

                System.Threading.Timer timer = new System.Threading.Timer(
                    new TimerCallback(delegate { stop = true; }), null, 5000, Timeout.Infinite);

                while (!stop)
                {
                    GL.Vertex2(0.0f, 0.0f);
                    GL.Vertex2(v);
                    //GL.ARB.ActiveTexture(GL.Enums.ARB_multitexture.TEXTURE0_ARB);
                    //dummy();
                    GL.ColorPointer(2, GL.Enums.ColorPointerType.FLOAT, 0, v);
                    //glVertex2f_1(0.0f, 0.0f);
                    //glVertex2f_2(0.0f, 0.0f);
                    //glVertex2fv(v);
                    count++;
                }

                //GL.End();

                //glControl1.Context.SwapBuffers();

                timer.Dispose();
                this.Hide();
                MessageBox.Show(String.Format("{0} calls/second.", count / 5.0));
                Application.Idle -= Application_Idle;
                this.Close();
            }
        }
    }
}