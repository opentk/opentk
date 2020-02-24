using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using OpenToolkit.Mathematics;

namespace OpenToolkit.Benchmarks.Mathematics.Vector
{
    [SimpleJob(RuntimeMoniker.Net472, baseline: true)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [RPlotExporter]
    [BenchmarkCategory("Vector", "Vector3", "Subtraction")]
    public class Vector3Subtraction
    {
        private Vector3 _first = new Vector3(1, 2, 3);
        private Vector3 _second = new Vector3(3, 2, 1);

        private Vector3 _result;

        [Benchmark(Description = "Vector3.Subtract(Vector3 a, Vector3 b)")]
        public void Vector3_SubtractByValue()
        {
            _result = Vector3.Subtract(_first, _second);
        }

        [Benchmark(Description = "Vector3.Subtract(ref Vector3 a, ref Vector3 b, out Vector3 result)")]
        public void Vector3_SubtractByReference()
        {
            Vector3.Subtract(ref _first, ref _second, out _result);
        }

        [Benchmark(Description = "Vector3 - Vector3")]
        public void Vector3_SubtractByOperator()
        {
            _result = _first - _second;
        }
    }
}
