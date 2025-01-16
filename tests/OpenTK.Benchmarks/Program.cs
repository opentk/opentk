using BenchmarkDotNet.Running;

namespace OpenTK.Benchmarks
{
    internal class Program
    {
        public static void Main()
        {
            //BenchmarkRunner.Run<SlerpBenchmarks>();
            BenchmarkRunner.Run<MatrixBenchmark>();
        }
    }
}
