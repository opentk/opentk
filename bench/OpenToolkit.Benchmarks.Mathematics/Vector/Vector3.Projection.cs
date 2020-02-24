using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using OpenToolkit.Mathematics;

namespace OpenToolkit.Benchmarks.Mathematics.Vector
{
    [SimpleJob(RuntimeMoniker.Net472, baseline: true)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [RPlotExporter]
    [BenchmarkCategory("Vector", "Vector3", "Projection")]
    public class Vector3Projection
    {
        private readonly Vector3 _vector = new Vector3(1, 2, 3);
        private readonly Matrix4 _matrix = Matrix4.Identity;

        private Matrix4 _inverse;
        private Vector3 _result;

        [GlobalSetup]
        public void Setup()
        {
            _inverse = _matrix;
            _inverse.Invert();
        }

        [Benchmark(Description = "Vector3.Project(Vector3 vector, float x, float y, float width, float height, float minZ, float maxZ, Matrix4 worldViewProjection)")]
        public void Vector3_ProjectByValue()
        {
            _result = Vector3.Project(_vector, -1, -1, 2, 2, -1, 1, _matrix);
        }

        [Benchmark(Description = "Vector3.Unproject(Vector3 vector, float x, float y, float width, float height, float minZ, float maxZ, Matrix4 inverseWorldViewProjection)")]
        public void Vector3_UnprojectByValue()
        {
            _result = Vector3.Unproject(_vector, -1, -1, 2, 2, -1, 1, _inverse);
        }
    }
}
