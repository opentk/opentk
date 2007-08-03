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
            using (StreamWriter sw = new StreamWriter(Path.Combine(System.Environment.CurrentDirectory, "keymap.log")))
            {
                //Debug.Listeners.Clear();
                Debug.Listeners.Add(new TextWriterTraceListener(sw));
                Debug.AutoFlush = true;
                Debug.WriteLine("Starting key dump");

                //using (S02_RawInput_Logger ex = new S02_RawInput_Logger())
                {
                    try
                    {
                        //ex.Run();
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
                }
                Debug.Flush();
                Debug.Close();
            }
        }

        #endregion

        public S02_RawInput_Logger()
        {
            GL.ClearColor(0.0f, 0.0f, 0.0f, 0.0f);
        }

        public override void RenderFrame()
        {
            base.RenderFrame();

            GL.Clear(GL.Enums.ClearBufferMask.COLOR_BUFFER_BIT);
            Context.SwapBuffers();
        }
    }
}
