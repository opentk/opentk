using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using OpenToolkit.Mathematics;

namespace OpenToolkit.Benchmarks.Mathematics.Vector
{
    [SimpleJob(RuntimeMoniker.Net472, baseline: true)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [RPlotExporter]
    [BenchmarkCategory("Vector", "Vector4", "Division")]
    public class Vector4Division
    {
        private Vector4 _left = new Vector4(1, 2, 3, 4);
        private Vector4 _right = new Vector4(4, 3, 2, 1);

        private Vector4 _result;

        private const float Scalar = 2;

        [Benchmark(Description = "Vector4.Divide(Vector4 vector, float scale)")]
        public void Vector4_DivideByValue_Single()
        {
            _result = Vector4.Divide(_left, Scalar);
        }

        [Benchmark(Description = "Vector4.Divide(Vector4 vector, Vector4 scale)")]
        public void Vector4_DivideByValue_Vector4()
        {
            _result = Vector4.Divide(_left, _right);
        }

        [Benchmark(Description = "Vector4.Divide(ref Vector4 vector, ref float scale, out Vector4 result)")]
        public void Vector4_DivideByReference_Single()
        {
            Vector4.Divide(ref _left, Scalar, out _result);
        }

        [Benchmark(Description = "Vector4.Divide(ref Vector4 vector, ref Vector4 scale, out Vector4 result)")]
        public void Vector4_DivideByReference_Vector4()
        {
            Vector4.Divide(ref _left, ref _right, out _result);
        }

        [Benchmark(Description = "Vector4 / Single")]
        public void Vector4_DivideByOperator_Single()
        {
            _result = _left / Scalar;
        }

        [Benchmark(Description = "Vector4 / Vector4")]
        public void Vector4_DivideByOperator_Vector4()
        {
            _result = _left * _right;
        }
    }
}
