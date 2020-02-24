using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using OpenToolkit.Mathematics;

namespace OpenToolkit.Benchmarks.Mathematics.Vector
{
    [SimpleJob(RuntimeMoniker.Net472, baseline: true)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [RPlotExporter]
    [BenchmarkCategory("Vector", "Vector4", "Addition")]
    public class Vector4Addition
    {
        private Vector4 _first = new Vector4(1,2,3, 4);
        private Vector4 _second = new Vector4(4, 3, 2, 1);

        private Vector4 _result;

        [Benchmark(Description = "Vector4.Add(Vector4 a, Vector4 b)")]
        public void Vector4_AddByValue()
        {
            _result = Vector4.Add(_first, _second);
        }

        [Benchmark(Description = "Vector4.Add(ref Vector4 a, ref Vector4 b, out Vector4 result)")]
        public void Vector4_AddByReference()
        {
            Vector4.Add(ref _first, ref _second, out _result);
        }

        [Benchmark(Description = "Vector4 + Vector4")]
        public void Vector4_AddByOperator()
        {
            _result = _first + _second;
        }
    }
}
