using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using OpenToolkit.Mathematics;

namespace OpenToolkit.Benchmarks.Mathematics.Vector
{
    [SimpleJob(RuntimeMoniker.Net472, baseline: true)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [RPlotExporter]
    [BenchmarkCategory("Vector", "Vector3", "Multiplication")]
    public class Vector3Multiplication
    {
        private Vector3 _left = new Vector3(1, 2, 3);
        private Vector3 _right = new Vector3(3, 2, 1);

        private const float Scalar = 2;

        [Benchmark(Description = "Vector3.Multiply(Vector3 vector, float scale)")]
        public Vector3 Vector3_MultiplyByValue_Single()
        {
            return Vector3.Multiply(_left, Scalar);
        }

        [Benchmark(Description = "Vector3.Multiply(Vector3 vector, Vector3 scale)")]
        public Vector3 Vector3_MultiplyByValue_Vector3()
        {
            return Vector3.Multiply(_left, _right);
        }

        [Benchmark(Description = "Vector3.Multiply(ref Vector3 vector, ref float scale, out Vector3 result)")]
        public Vector3 Vector3_MultiplyByReference_Single()
        {
            Vector3.Multiply(ref _left, Scalar, out var result);

            return result;
        }

        [Benchmark(Description = "Vector3.Multiply(ref Vector3 vector, ref Vector3 scale, out Vector3 result)")]
        public Vector3 Vector3_MultiplyByReference_Vector3()
        {
            Vector3.Multiply(ref _left, ref _right, out var result);

            return result;
        }

        [Benchmark(Description = "Single * Vector3")]
        public Vector3 Vector3_MultiplyByOperator_Single_LH()
        {
            return Scalar * _right;
        }

        [Benchmark(Description = "Vector3 * Single")]
        public Vector3 Vector3_MultiplyByOperator_Single_RH()
        {
            return _left * Scalar;
        }

        [Benchmark(Description = "Vector3 * Vector3")]
        public Vector3 Vector3_MultiplyByOperator_Vector3()
        {
            return _left * _right;
        }
    }
}
