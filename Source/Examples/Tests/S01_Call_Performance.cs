#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Text;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;

using OpenTK.OpenGL;
using System.Security;
using OpenTK.OpenGL.Enums;

namespace Examples.Tests
{
    public class S01_Call_Performance : IExample
    {
        OpenTK.GLContext context;
        const int num_calls = 1000000;
        float[] v = new float[] { 0.0f, 0.0f };
        public static int dummy_variable = 0;

        public void Launch()
        {
            using (Form f = new Form())
            {
                context = new OpenTK.GLContext(new OpenTK.DisplayMode(), new OpenTK.Platform.WindowInfo(f));
                context.CreateContext();

                Trace.WriteLine(String.Format("Number of calls: {0}", num_calls));

                Stopwatch timer = new Stopwatch();

                #region Managed functions

                Trace.Write("Timing empty loop: ");
                timer.Start();
                for (int i = 0; ++i < num_calls; )
                {
                }
                timer.Stop();
                Trace.WriteLine(String.Format("{0} ns", timer.Elapsed.TotalMilliseconds * (1000000.0 / (double)num_calls)));
                timer.Reset();

                Trace.Write("Timing inline .Net functions: ");
                timer.Start();
                for (int i = 0; ++i < num_calls; )
                {
                    InlineFunction();
                }
                timer.Stop();
                Trace.WriteLine(String.Format("{0} ns", timer.Elapsed.TotalMilliseconds * (1000000.0 / (double)num_calls)));
                timer.Reset();

                Trace.Write("Timing virtual .Net functions: ");
                timer.Start();
                for (int i = 0; ++i < num_calls; )
                {
                    VirtualFunction();
                }
                timer.Stop();
                Trace.WriteLine(String.Format("{0} ns", timer.Elapsed.TotalMilliseconds * (1000000.0 / (double)num_calls)));
                timer.Reset();

                #endregion

                #region OpenTK.OpenGL

                Trace.Write("Timing OpenTK.OpenGL core functions: ");
                timer.Start();
                for (int i = 0; ++i < num_calls; )
                {
                    GL.Vertex2(0.0f, 0.0f);
                }
                timer.Stop();
                Trace.WriteLine(String.Format("{0} ns", timer.Elapsed.TotalMilliseconds * (1000000.0 / (double)num_calls)));
                timer.Reset();

                Trace.Write("Timing OpenTK.OpenGL core functions (array): ");
                timer.Start();
                for (int i = 0; ++i < num_calls; )
                {
                    GL.Vertex2(v);
                }
                timer.Stop();
                Trace.WriteLine(String.Format("{0} ns", timer.Elapsed.TotalMilliseconds * (1000000.0 / (double)num_calls)));
                timer.Reset();

                Trace.Write("Timing OpenTK.OpenGL core functions (void*): ");
                timer.Start();
                for (int i = 0; ++i < num_calls; )
                    GL.CallLists(v.Length, ListNameType.Float, v);
                timer.Stop();
                Trace.WriteLine(String.Format("{0} ns", timer.Elapsed.TotalMilliseconds * (1000000.0 / (double)num_calls)));
                timer.Reset();

                Trace.Write("Timing OpenTK.OpenGL extension functions: ");
                timer.Start();
                for (int i = 0; ++i < num_calls; )
                    GL.ActiveTexture(TextureUnit.Texture0);

                timer.Stop();
                Trace.WriteLine(String.Format("{0} ns", timer.Elapsed.TotalMilliseconds * (1000000.0 / (double)num_calls)));
                timer.Reset();

                #endregion

                #region DllImports

                Trace.Write("Timing direct DllImport: ");
                timer.Start();
                for (int i = 0; ++i < num_calls; )
                {
                    glVertex2f(0.0f, 0.0f);
                }
                timer.Stop();
                Trace.WriteLine(String.Format("{0} ns", timer.Elapsed.TotalMilliseconds * (1000000.0 / (double)num_calls)));
                timer.Reset();

                Trace.Write("Timing direct DllImport (array): ");
                timer.Start();
                for (int i = 0; ++i < num_calls; )
                {
                    glVertex2fv(v);
                }
                timer.Stop();
                Trace.WriteLine(String.Format("{0} ns", timer.Elapsed.TotalMilliseconds * (1000000.0 / (double)num_calls)));
                timer.Reset();

                GL.GenLists(1);
                Trace.Write("Timing direct DllImport (void*): ");
                timer.Start();
                for (int i = 0; ++i < num_calls; )
                {
                    glCallLists(v.Length, ListNameType.Float, v);
                }
                timer.Stop();
                Trace.WriteLine(String.Format("{0} ns", timer.Elapsed.TotalMilliseconds * (1000000.0 / (double)num_calls)));
                timer.Reset();

                #endregion
            }
        }

        public static readonly int order = 1;

        public void InlineFunction()
        {
            ++dummy_variable;
        }

        public virtual void VirtualFunction()
        {
            ++dummy_variable;
        }

        [DllImport("opengl32.dll", EntryPoint = "glVertex2f"), SuppressUnmanagedCodeSecurity]
        extern static void glVertex2f(float a, float b);

        [DllImport("opengl32.dll", EntryPoint = "glVertex2fv"), SuppressUnmanagedCodeSecurity]
        extern static void glVertex2fv(float[] v);

        [DllImport("opengl32.dll", EntryPoint = "glCallLists"), SuppressUnmanagedCodeSecurity]
        extern static void glCallLists(int count, ListNameType type, object lists);

    }
}
