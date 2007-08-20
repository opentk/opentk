#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using OpenTK;
using OpenTK.OpenGL;
using System.Threading;
using System.Runtime.Serialization;
using System.IO;
using System.Diagnostics;

namespace Examples.Tests
{
    public class S02_RawInput_Logger : GameWindow, IExample
    {
        #region IExample Members

        public void Launch()
        {
            try
            {
                Run();
            }
            catch (Exception expt)
            {
                System.Diagnostics.Debug.WriteLine(
                    String.Format(
                        "Exception: {3}{0}Stacktrace:{0}{1}{0}{0}{2}",
                        System.Environment.NewLine,
                        expt.TargetSite,
                        expt.StackTrace,
                        expt.Message
                    )
                );
                /*MessageBox.Show(
                    String.Format(
                        "Stacktrace:{0}{1}{0}{0}{2}",
                        System.Environment.NewLine,
                        expt.TargetSite,
                        expt.StackTrace
                    ),
                    expt.Message
                );*/
                throw;
            }
            Debug.Flush();
            Debug.Close();

        }

        #endregion

        public S02_RawInput_Logger()
        {
            this.CreateWindow(new OpenTK.Platform.DisplayMode(100, 100));
        }

        public override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GL.ClearColor(0.0f, 0.0f, 0.0f, 0.0f);
        }

        public override void OnRenderFrame(EventArgs e)
        {
            base.OnRenderFrame(e);

            GL.Clear(GL.Enums.ClearBufferMask.COLOR_BUFFER_BIT);
            Context.SwapBuffers();
        }
    }
}
