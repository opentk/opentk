using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using OpenToolkit.Mathematics;

namespace OpenToolkit.Benchmarks.Mathematics.Matrix
{
    [SimpleJob(RuntimeMoniker.Net472, baseline: true)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [RPlotExporter]
    [BenchmarkCategory("Matrix", "Matrix3", "Inversion")]
    public class Matrix3Inversion
    {
        private Matrix3 _matrix;
        private Matrix3 _result;

        [GlobalSetup]
        public void Setup()
        {
            _matrix = Matrix3.CreateRotationZ(MathHelper.PiOver2);
        }

        [Benchmark(Description = "Matrix3.Invert(Matrix3 mat)")]
        public void Matrix3_InvertByValue()
        {
            _matrix = Matrix3.Invert(_matrix);
        }

        [Benchmark(Description = "Matrix3.Invert(ref Matrix3 mat, out Matrix3 result)")]
        public void Matrix3_InvertByReference()
        {
            Matrix3.Invert(ref _matrix, out _result);
        }
    }
}
