using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using OpenToolkit.Mathematics;

namespace OpenToolkit.Benchmarks.Mathematics.Vector
{
    [SimpleJob(RuntimeMoniker.Net472, baseline: true)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [RPlotExporter]
    [BenchmarkCategory("Vector", "Vector3", "Division")]
    public class Vector3Division
    {
        private Vector3 _left = new Vector3(1, 2, 3);
        private Vector3 _right = new Vector3(3, 2, 1);

        private Vector3 _result;

        private const float Scalar = 2;

        [Benchmark(Description = "Vector3.Divide(Vector3 vector, float scale)")]
        public void Vector3_DivideByValue_Single()
        {
            _result = Vector3.Divide(_left, Scalar);
        }

        [Benchmark(Description = "Vector3.Divide(Vector3 vector, Vector3 scale)")]
        public void Vector3_DivideByValue_Vector3()
        {
            _result = Vector3.Divide(_left, _right);
        }

        [Benchmark(Description = "Vector3.Divide(ref Vector3 vector, ref float scale, out Vector3 result)")]
        public void Vector3_DivideByReference_Single()
        {
            Vector3.Divide(ref _left, Scalar, out _result);
        }

        [Benchmark(Description = "Vector3.Divide(ref Vector3 vector, ref Vector3 scale, out Vector3 result)")]
        public void Vector3_DivideByReference_Vector3()
        {
            Vector3.Divide(ref _left, ref _right, out _result);
        }

        [Benchmark(Description = "Vector3 / Single")]
        public void Vector3_DivideByOperator_Single()
        {
            _result = _left / Scalar;
        }
    }
}
