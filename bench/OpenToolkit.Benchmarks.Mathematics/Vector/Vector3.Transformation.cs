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

        private Matrix3 _matrix;
        private Quaternion _quaternion;

        [GlobalSetup]
        public void Setup()
        {
            _matrix = Matrix3.CreateRotationZ(MathHelper.Pi);
            _quaternion = new Quaternion(0, 0, MathHelper.Pi);
        }

        [Benchmark(Description = "Vector3.Transform(Vector3 vec, Matrix3 mat)")]
        public Vector3 Vector3_TransformByValue_Matrix3_LH()
        {
            return Vector3.Transform(_vector, _matrix);
        }

        [Benchmark(Description = "Vector3.Transform(Matrix3 mat, Vector3 vec)")]
        public Vector3 Vector3_TransformByValue_Matrix3_RH()
        {
            return Vector3.Transform(_matrix, _vector);
        }

        [Benchmark(Description = "Vector3.Transform(Vector3 vec, Quaternion quat)")]
        public Vector3 Vector3_TransformByValue_Quaternion()
        {
            return Vector3.Transform(_vector, _quaternion);
        }

        [Benchmark(Description = "Vector3.Transform(ref Vector3 vec, ref Matrix3 mat, out Vector3 result)")]
        public Vector3 Vector3_TransformByReference_Matrix3_LH()
        {
            Vector3.Transform(ref _vector, ref _matrix, out var result);

            return result;
        }

        [Benchmark(Description = "Vector3.Transform(ref Matrix3 mat, ref Vector3 vec, out Vector3 result)")]
        public Vector3 Vector3_TransformByReference_Matrix3_RH()
        {
            Vector3.Transform(ref _matrix, ref _vector, out var result);

            return result;
        }

        [Benchmark(Description = "Vector3.Transform(ref Vector3 vec, ref Quaternion quat, out Vector3 result)")]
        public Vector3 Vector3_TransformByReference_Quaternion()
        {
            Vector3.Transform(ref _vector, ref _quaternion, out var result);

            return result;
        }

        [Benchmark(Description = "Vector3 * Matrix3")]
        public Vector3 Vector3_TransformByOperator_Matrix3_LH()
        {
            return _vector * _matrix;
        }

        [Benchmark(Description = "Matrix3 * Vector3")]
        public Vector3 Vector3_TransformByOperator_Matrix3_RH()
        {
            return _matrix * _vector;
        }

        [Benchmark(Description = "Quaternion * Vector3")]
        public Vector3 Vector3_TransformByOperator_Quaternion()
        {
            return _quaternion * _vector;
        }
    }
}
