using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using OpenToolkit.Mathematics;

namespace OpenToolkit.Benchmarks.Mathematics.Vector
{
    [SimpleJob(RuntimeMoniker.Net472, baseline: true)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [RPlotExporter]
    [BenchmarkCategory("Vector", "Vector3", "Addition")]
    public class Vector3Addition
    {
        private Vector3 _first = new Vector3(1,2,3);
        private Vector3 _second = new Vector3(3, 2, 1);

        [Benchmark(Description = "Vector3.Add(Vector3 a, Vector3 b)")]
        public Vector3 Vector3_AddByValue()
        {
            return Vector3.Add(_first, _second);
        }

        [Benchmark(Description = "Vector3.Add(ref Vector3 a, ref Vector3 b, out Vector3 result)")]
        public Vector3 Vector3_AddByReference()
        {
            Vector3.Add(ref _first, ref _second, out var result);

            return result;
        }

        [Benchmark(Description = "Vector3 + Vector3")]
        public Vector3 Vector3_AddByOperator()
        {
            return _first + _second;
        }
    }
}
