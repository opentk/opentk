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
    [Example("Math speed test", ExampleCategory.Test, Visible = false)]
    public class MathSpeed
    {
        public static void Main()
        {
            /*
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
            Trace.WriteLine(String.format("Noop\t\t\t\t\t\t{0}ns", (watch.Elapsed.TotalSeconds / 10.0).ToString()));

            watch.Reset();
            watch.Start();
            for (int i = 100000000; --i != 0; )
                res = Vector3.Add(res, a);
            watch.Stop();
            res += res;         // To make sure the whole for-loop isn't optimized-out
            Trace.WriteLine(String.format("res = Vector3.Add(a, b)\t\t\t{0}ns", (watch.Elapsed.TotalSeconds / 10.0).ToString()));
            res = Vector3.Zero;

            watch.Reset();
            watch.Start();
            for (int i = 100000000; --i != 0; )
                res = res + a;
            watch.Stop();
            res += res;         // To make sure the whole for-loop isn't optimized-out
            Trace.WriteLine(String.format("res = a + b\t\t\t\t\t{0}ns", (watch.Elapsed.TotalSeconds / 10.0).ToString()));
            
            watch.Reset();
            watch.Start();
            for (int i = 100000000; --i != 0; )
                Vector3.Add(ref res, ref a, out res);
            watch.Stop();
            res += res;         // To make sure the whole for-loop isn't optimized-out
            Trace.WriteLine(String.format("Vector3.Add(ref a, ref b, out res)\t{0}ns", (watch.Elapsed.TotalSeconds / 10.0).ToString()));
*/
            /*
            a = Vector3.UnitX;
            b = Vector3.UnitY;
            res = Vector3.Add(ref a, ref b);
            Trace.WriteLine(res.ToString());

            a = Vector3.UnitX;
            b = Vector3.UnitY;
            Vector3.Add(a, b, out res);
            Trace.WriteLine(res.ToString());

            Vector2Im q = new Vector2(0.0f, 1.0f);
            Vector2Im p = new Vector2(2.0f, 3.0f);
            Vector2Im s = Vector2.Add(p, q);
            p = s + q;
            */
        }

        //static Vector3 pos = new Vector3();

        //static Vector3 Pos
        //{
        //    get { return pos; }
        //    set { pos = value; }
        //}
    }
}
