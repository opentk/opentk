using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using OpenToolkit.Mathematics;

namespace OpenToolkit.Benchmarks.Mathematics.Vector
{
    [SimpleJob(RuntimeMoniker.Net472, baseline: true)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [RPlotExporter]
    [BenchmarkCategory("Vector", "Vector4", "Subtraction")]
    public class Vector4Subtraction
    {
        private Vector4 _first = new Vector4(1, 2, 3, 4);
        private Vector4 _second = new Vector4(4, 3, 2, 1);

        private Vector4 _result;

        [Benchmark(Description = "Vector4.Subtract(Vector4 a, Vector4 b)")]
        public void Vector4_SubtractByValue()
        {
            _result = Vector4.Subtract(_first, _second);
        }

        [Benchmark(Description = "Vector4.Subtract(ref Vector4 a, ref Vector4 b, out Vector4 result)")]
        public void Vector4_SubtractByReference()
        {
            Vector4.Subtract(ref _first, ref _second, out _result);
        }

        [Benchmark(Description = "Vector4 - Vector4")]
        public void Vector4_SubtractByOperator()
        {
            _result = _first - _second;
        }
    }
}
