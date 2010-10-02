#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2010 the Open Toolkit library, except where noted.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

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
