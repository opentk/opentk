using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using OpenToolkit.Mathematics;

namespace OpenToolkit.Benchmarks.Mathematics.Vector
{
    [SimpleJob(RuntimeMoniker.Net472, baseline: true)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [RPlotExporter]
    [BenchmarkCategory("Vector", "Vector3", "Interpolation")]
    public class Vector3Interpolation
    {
        private Vector3 _a = new Vector3(1, 2, 3);
        private Vector3 _b = new Vector3(3, 2, 1);
        private Vector3 _c = new Vector3(4, 5, 6);

        private const float U = 0.4f;
        private const float V = 0.8f;

        [Benchmark(Description = "Vector3.Lerp(Vector3 a, Vector3 b, float blend)")]
        public Vector3 Vector3_LerpByValue()
        {
            return Vector3.Lerp(_a, _b, U);
        }

        [Benchmark(Description = "Vector3.Lerp(ref Vector3 a, ref Vector3 b, float blend, out Vector3 result)")]
        public Vector3 Vector3_LerpByReference()
        {
            Vector3.Lerp(ref _a, ref _b, U, out var result);

            return result;
        }

        [Benchmark(Description = "Vector3.BaryCentric(Vector3 a, Vector3 b, Vector3 c, float u, float v)")]
        public Vector3 Vector3_BarycentricByValue()
        {
            return Vector3.BaryCentric(_a, _b, _c, U, V);
        }

        [Benchmark(Description = "Vector3.BaryCentric(ref Vector3 a, ref Vector3 b, ref Vector3 c, float u, float v, out Vector3 result)")]
        public Vector3 Vector3_BarycentricByReference()
        {
            Vector3.BaryCentric(ref _a, ref _b, ref _c, U, V, out var result);

            return result;
        }
    }
}
