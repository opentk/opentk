using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using OpenToolkit.Mathematics;

namespace OpenToolkit.Benchmarks.Mathematics.Vector
{
    [SimpleJob(RuntimeMoniker.Net472, baseline: true)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [RPlotExporter]
    [BenchmarkCategory("Vector", "Vector3", "Transformation")]
    public class Vector3Transformation
    {
        private Vector3 _vector = new Vector3(50, 50, 0);
        private Vector3 _result;

        private Matrix3 _matrix;
        private Quaternion _quaternion;

        [GlobalSetup]
        public void Setup()
        {
            _matrix = Matrix3.CreateRotationZ(MathHelper.Pi);
            _quaternion = new Quaternion(0, 0, MathHelper.Pi);
        }

        [Benchmark(Description = "Vector3.Transform(Vector3 vec, Matrix3 mat)")]
        public void Vector3_TransformByValue_Matrix3_LH()
        {
            _result = Vector3.Transform(_vector, _matrix);
        }

        [Benchmark(Description = "Vector3.Transform(Matrix3 mat, Vector3 vec)")]
        public void Vector3_TransformByValue_Matrix3_RH()
        {
            _result = Vector3.Transform(_matrix, _vector);
        }

        [Benchmark(Description = "Vector3.Transform(Vector3 vec, Quaternion quat)")]
        public void Vector3_TransformByValue_Quaternion()
        {
            _result = Vector3.Transform(_vector, _quaternion);
        }

        [Benchmark(Description = "Vector3.Transform(ref Vector3 vec, ref Matrix3 mat, out Vector3 result)")]
        public void Vector3_TransformByReference_Matrix3_LH()
        {
            Vector3.Transform(ref _vector, ref _matrix, out _result);
        }

        [Benchmark(Description = "Vector3.Transform(ref Matrix3 mat, ref Vector3 vec, out Vector3 result)")]
        public void Vector3_TransformByReference_Matrix3_RH()
        {
            Vector3.Transform(ref _matrix, ref _vector, out _result);
        }

        [Benchmark(Description = "Vector3.Transform(ref Vector3 vec, ref Quaternion quat, out Vector3 result)")]
        public void Vector3_TransformByReference_Quaternion()
        {
            Vector3.Transform(ref _vector, ref _quaternion, out _result);
        }

        [Benchmark(Description = "Vector3 * Matrix3")]
        public void Vector3_TransformByOperator_Matrix3_LH()
        {
            _result = _vector * _matrix;
        }

        [Benchmark(Description = "Matrix3 * Vector3")]
        public void Vector3_TransformByOperator_Matrix3_RH()
        {
            _result = _matrix * _vector;
        }

        [Benchmark(Description = "Quaternion * Vector3")]
        public void Vector3_TransformByOperator_Quaternion()
        {
            _result = _quaternion * _vector;
        }
    }
}
