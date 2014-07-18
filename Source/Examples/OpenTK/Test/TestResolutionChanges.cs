// This code was written for the OpenTK library and has been released
// to the Public Domain.
// It is provided "as is" without express or implied warranty of any kind.

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

using OpenTK;

namespace Examples.Tests
{
    [Example("Test Resolution Changes", ExampleCategory.OpenTK, "Test", Documentation="TestResolutionChanges")]
    public class TestResolutionChanges
    {
        public static void Main()
        {
            for (int i = 0; i < 6; i++)
            {
                DisplayDevice dev = DisplayDevice.GetDisplay(DisplayIndex.First + i);
                if (dev != null)
                {
                    Print(dev.ToString());

                    dev.ChangeResolution(dev.SelectResolution(640, 480, 32, 60.0f));
                    Thread.Sleep(1000);
                    Print(dev.ToString());

                    dev.RestoreResolution();
                    Thread.Sleep(1000);
                    Print(dev.ToString());
                }
            }
        }

        static void Print(string msg)
        {
            Trace.WriteLine(msg);

            // Also display a MessageBox when running on a platform
            // with WinForms support.
            try
            {
                if (Configuration.RunningOnWindows || Configuration.RunningOnX11 || Configuration.RunningOnMacOS)
                {
                    MessageBox.Show(msg);
                }
            }
            catch
            {
            }
        }
    }
}
