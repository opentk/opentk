using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Benchmarks
{
    internal class Program
    {
        public static void Main()
        {
            //BenchmarkRunner.Run<SlerpBenchmarks>();
            //BenchmarkRunner.Run<MatrixBenchmark>();
            BenchmarkRunner.Run<JsonBenchmarks>();
        }
    }
}
