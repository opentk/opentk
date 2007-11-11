#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using OpenTK.Math;

namespace Examples.Tests
{
    [Example("Math speed test", ExampleCategory.Test, 2, false)]
    public class MathSpeed
    {
        public static void Main()
        {
            Stopwatch watch = new Stopwatch();

            Vector3 a = new Vector3(0.0f, 0.0f, 0.0f);
            Vector3 b = new Vector3(1.0f, 1.0f, 1.0f);
            Vector3 c = new Vector3(3.0f, 3.0f, 3.0f);
            Vector3 d = new Vector3(4.0f, 4.0f, 4.0f);
            Vector3 e = Vector3.Zero;
            Vector3 res;

            // Force the JIT to compile the functions.
            Vector3.Add(a, b);
            Vector3.Add(ref a, ref b, out res);
            res = a + b;
            res = Vector3.Zero;

            watch.Reset();
            watch.Start();
            for (int i = 100000000; --i != 0; )
                ;
            watch.Stop();
            Trace.WriteLine(String.Format("Noop\t\t\t\t\t\t{0}ns", (watch.Elapsed.TotalSeconds / 10.0).ToString()));

            watch.Reset();
            watch.Start();
            for (int i = 100000000; --i != 0; )
                res = Vector3.Add(res, a);
            watch.Stop();
            res += res;         // To make sure the whole for-loop isn't optimized-out
            Trace.WriteLine(String.Format("res = Vector3.Add(a, b)\t\t\t{0}ns", (watch.Elapsed.TotalSeconds / 10.0).ToString()));
            res = Vector3.Zero;

            watch.Reset();
            watch.Start();
            for (int i = 100000000; --i != 0; )
                res = res + a;
            watch.Stop();
            res += res;         // To make sure the whole for-loop isn't optimized-out
            Trace.WriteLine(String.Format("res = a + b\t\t\t\t\t{0}ns", (watch.Elapsed.TotalSeconds / 10.0).ToString()));
            
            watch.Reset();
            watch.Start();
            for (int i = 100000000; --i != 0; )
                Vector3.Add(ref res, ref a, out res);
            watch.Stop();
            res += res;         // To make sure the whole for-loop isn't optimized-out
            Trace.WriteLine(String.Format("Vector3.Add(ref a, ref b, out res)\t{0}ns", (watch.Elapsed.TotalSeconds / 10.0).ToString()));
        }
    }
}
