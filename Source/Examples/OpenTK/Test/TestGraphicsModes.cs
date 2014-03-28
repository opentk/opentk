// This code was written for the OpenTK library and has been released
// to the Public Domain.
// It is provided "as is" without express or implied warranty of any kind.

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using OpenTK.Graphics;
using OpenTK;
using System.Windows.Forms;

namespace Examples.Tests
{
    [Example("Test GraphicsModes", ExampleCategory.OpenTK, "Test", Documentation = "TestGraphicsModes")]
    public class TestGraphicsModes
    {
        static void Main()
        {
            Dictionary<GraphicsMode, GraphicsMode> modes = new Dictionary<GraphicsMode, GraphicsMode>();
            Trace.WriteLine("Cl (RGBA): Color format (total bits and bits per channel).");
            Trace.WriteLine("Dp       : Depth buffer bits.");
            Trace.WriteLine("St       : Stencil buffer bits.");
            Trace.WriteLine("AA       : Sample count for anti-aliasing.");
            Trace.WriteLine("Stereo   : Stereoscoping rendering supported.");
            Trace.WriteLine("");
            Trace.WriteLine("Cl (RGBA), Dp, St, AA, Stereo");
            Trace.WriteLine("-----------------------------");
            foreach (ColorFormat color in new ColorFormat[] { 32, 24, 16, 8 })
                foreach (int depth in new int[] { 24, 16 })
                    foreach (int stencil in new int[] { 8, 0 })
                        foreach (int samples in new int[] { 0, 2, 4, 6, 8, 16 })
                                foreach (bool stereo in new bool[] { false, true })
                                {
                                    try
                                    {
                                        GraphicsMode mode = new GraphicsMode(color, depth, stencil, samples, 0, 2, stereo);
                                        if (!modes.ContainsKey(mode))
                                            modes.Add(mode, mode);
                                    }
                                    catch
                                    { }
                                }

            foreach (GraphicsMode mode in modes.Keys)
                Trace.WriteLine(String.Format("{0}, {1:00}, {2:00}, {3:00}, {4}", mode.ColorFormat, mode.Depth, mode.Stencil, mode.Samples, mode.Stereo));
        }
    }
}
