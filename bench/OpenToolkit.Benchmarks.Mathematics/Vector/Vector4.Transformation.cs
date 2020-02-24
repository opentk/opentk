using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using OpenToolkit.Mathematics;

namespace OpenToolkit.Benchmarks.Mathematics.Vector
{
    [SimpleJob(RuntimeMoniker.Net472, baseline: true)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [RPlotExporter]
    [BenchmarkCategory("Vector", "Vector4", "Transformation")]
    public class Vector4Transformation
    {
        private Vector4 _vector = new Vector4(50, 50, 50, 0);
        private Vector4 _result;

        private Matrix4 _matrix;
        private Quaternion _quaternion;

        [GlobalSetup]
        public void Setup()
        {
            _matrix = Matrix4.CreateScale(0.5f) * Matrix4.CreateRotationZ(MathHelper.Pi) * Matrix4.CreateTranslation(-10,-10, -10);
            _quaternion = new Quaternion(0, 0, MathHelper.Pi);
        }

        [Benchmark(Description = "Vector4.Transform(Vector4 vec, Matrix4 mat)")]
        public void Vector4_TransformByValue_Matrix4_LH()
        {
            _result = Vector4.Transform(_vector, _matrix);
        }

        [Benchmark(Description = "Vector4.Transform(Matrix4 mat, Vector4 vec)")]
        public void Vector4_TransformByValue_Matrix4_RH()
        {
            _result = Vector4.Transform(_matrix, _vector);
        }

        [Benchmark(Description = "Vector4.Transform(Vector4 vec, Quaternion quat)")]
        public void Vector4_TransformByValue_Quaternion()
        {
            _result = Vector4.Transform(_vector, _quaternion);
        }

        [Benchmark(Description = "Vector4.Transform(ref Vector4 vec, ref Matrix4 mat, out Vector4 result)")]
        public void Vector4_TransformByReference_Matrix4_LH()
        {
            Vector4.Transform(ref _vector, ref _matrix, out _result);
        }

        [Benchmark(Description = "Vector4.Transform(ref Matrix4 mat, ref Vector4 vec, out Vector4 result)")]
        public void Vector4_TransformByReference_Matrix4_RH()
        {
            Vector4.Transform(ref _matrix, ref _vector, out _result);
        }

        [Benchmark(Description = "Vector4.Transform(ref Vector4 vec, ref Quaternion quat, out Vector4 result)")]
        public void Vector4_TransformByReference_Quaternion()
        {
            Vector4.Transform(ref _vector, ref _quaternion, out _result);
        }

        [Benchmark(Description = "Vector4 * Matrix4")]
        public void Vector4_TransformByOperator_Matrix4_LH()
        {
            _result = _vector * _matrix;
        }

        [Benchmark(Description = "Matrix4 * Vector4")]
        public void Vector4_TransformByOperator_Matrix4_RH()
        {
            _result = _matrix * _vector;
        }

        [Benchmark(Description = "Quaternion * Vector4")]
        public void Vector4_TransformByOperator_Quaternion()
        {
            _result = _quaternion * _vector;
        }
    }
}
