using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using OpenToolkit.Mathematics;

namespace OpenToolkit.Benchmarks.Mathematics.Vector
{
    [SimpleJob(RuntimeMoniker.Net472, baseline: true)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [RPlotExporter]
    [BenchmarkCategory("Vector", "Vector4", "Interpolation")]
    public class Vector4Interpolation
    {
        private Vector4 _a = new Vector4(1, 2, 3, 4);
        private Vector4 _b = new Vector4(4, 3, 2, 1);
        private Vector4 _c = new Vector4(5, 6, 7, 8);

        private Vector4 _result;

        private const float U = 0.4f;
        private const float V = 0.8f;

        [Benchmark(Description = "Vector4.Lerp(Vector4 a, Vector4 b, float blend)")]
        public void Vector4_LerpByValue()
        {
            _result = Vector4.Lerp(_a, _b, U);
        }

        [Benchmark(Description = "Vector4.Lerp(ref Vector4 a, ref Vector4 b, float blend, out Vector4 result)")]
        public void Vector4_LerpByReference()
        {
            Vector4.Lerp(ref _a, ref _b, U, out _result);
        }

        [Benchmark(Description = "Vector4.BaryCentric(Vector4 a, Vector4 b, Vector4 c, float u, float v)")]
        public void Vector4_BarycentricByValue()
        {
            _result = Vector4.BaryCentric(_a, _b, _c, U, V);
        }

        [Benchmark(Description = "Vector4.BaryCentric(ref Vector4 a, ref Vector4 b, ref Vector4 c, float u, float v, out Vector4 result)")]
        public void Vector4_BarycentricByReference()
        {
            Vector4.BaryCentric(ref _a, ref _b, ref _c, U, V, out _result);
        }
    }
}
