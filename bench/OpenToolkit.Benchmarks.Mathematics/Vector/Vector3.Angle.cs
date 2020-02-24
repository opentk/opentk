using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using OpenToolkit.Mathematics;

namespace OpenToolkit.Benchmarks.Mathematics.Vector
{
    [SimpleJob(RuntimeMoniker.Net472, baseline: true)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [RPlotExporter]
    [BenchmarkCategory("Vector", "Vector3", "Angle")]
    public class Vector3Angle
    {
        private Vector3 _first = Vector3.One;
        private Vector3 _second = Vector3.One / 2;

        private float _result;

        [Benchmark(Description = "Vector3.CalculateAngle(Vector3 first, Vector3 second)")]
        public void Vector3_CalculateAngleByValue()
        {
            _result = Vector3.CalculateAngle(_first, _second);
        }

        [Benchmark(Description = "Vector3.CalculateAngle(ref Vector3 first, ref Vector3 second, out float result)")]
        public void Vector3_CalculateAngleByReference()
        {
            Vector3.CalculateAngle(ref _first, ref _second, out _result);
        }
    }
}
