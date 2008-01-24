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

using OpenTK.Graphics;

namespace Examples.Tests
{
    [Example("Test Resolution Changes", ExampleCategory.Test)]
    public class TestResolutionChanges
    {
        public static void Main()
        {
            foreach (DisplayDevice dev in DisplayDevice.AvailableDisplays)
            {
                Trace.WriteLine(dev.ToString());
                MessageBox.Show(dev.ToString());
                // Switch to the first available resolution that has the same bpp as the current one (usually 640x480@60Hz)
                dev.ChangeResolution(dev.SelectResolution(0, 0, dev.BitsPerPixel, 0));
                MessageBox.Show(dev.ToString());
                dev.RestoreResolution();
            }
        }
    }
}
