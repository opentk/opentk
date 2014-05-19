using System;
using System.Diagnostics;
using System.Drawing;
using OpenTK;

namespace Examples.Tests
{
    [Example("PointToClient Test", ExampleCategory.OpenTK, "NativeWindow")]
    public class PointToClientTest
    {
        public static void Main()
        {
            using (var window = new NativeWindow())
            {
                Trace.WriteLine(String.Format("Window bounds: {0}", window.Bounds));
                Trace.WriteLine(String.Format("Window client: {0}", window.ClientRectangle));

                Point pclient = new Point(100, 100);
                Point pscreen = window.PointToScreen(pclient);
                Point ptest = window.PointToClient(pscreen);
                Trace.WriteLine(String.Format("Client: {0} -> Screen: {1} -> Client: {2}",
                    pclient, pscreen, ptest));
                Trace.WriteLine(String.Format("Test {0}",
                    ptest == pclient ? "succeeded" : "failed"));

                pscreen = new Point(100, 100);
                pclient = window.PointToClient(pscreen);
                ptest = window.PointToScreen(pclient);
                Trace.WriteLine(String.Format("Screen: {0} -> Client: {1} -> Screen: {2}",
                    pscreen, pclient, ptest));
                Trace.WriteLine(String.Format("Test {0}",
                    ptest == pscreen ? "succeeded" : "failed"));
            }
        }
    }
}

