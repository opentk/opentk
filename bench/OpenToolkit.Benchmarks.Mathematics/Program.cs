using BenchmarkDotNet.Running;

namespace OpenToolkit.Benchmarks.Mathematics
{
    class Program
    {
        static void Main(string[] args) => BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
    }
}
