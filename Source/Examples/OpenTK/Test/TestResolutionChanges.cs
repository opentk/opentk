#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK team.
 * This notice may not be removed.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

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
            foreach (DisplayDevice dev in DisplayDevice.AvailableDisplays)
            {
                Trace.WriteLine(dev.ToString());
                MessageBox.Show(dev.ToString());
                dev.ChangeResolution(dev.SelectResolution(640, 480, 32, 60.0f));
                Thread.Sleep(1000);
                MessageBox.Show(dev.ToString());
                dev.RestoreResolution();
                Thread.Sleep(1000);
                MessageBox.Show(dev.ToString());
            }
        }
    }
}
