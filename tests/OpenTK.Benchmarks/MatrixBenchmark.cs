using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenTK.Benchmarks
{
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    public class MatrixBenchmark
    {

        [ParamsSource(nameof(Quaternions))]
        public Quaternion Quat { get; set; }

        public Random Rand = new Random();
        public float NextFloat() => (float)Rand.Next();

        [GlobalSetup]
        public void Setup()
        {
            Rand = new Random();
        }

        public IEnumerable<Quaternion> Quaternions => Enumerable.Range(0, 1).Select(_ => new Quaternion(NextFloat(), NextFloat(), NextFloat(), NextFloat()));

        /*
        [BenchmarkCategory("Matrix3")]
        [Benchmark]
        public Matrix3 Matrix3FromQuaternion()
        {
            return Matrix3.CreateFromQuaternion(Quat);
        }

        [BenchmarkCategory("Matrix3")]
        [Benchmark(Baseline = true)]
        public Matrix3 Matrix3FromQuaternionOld()
        {
            Quat.ToAxisAngle(out Vector3 axis, out float angle);
            Matrix3.CreateFromAxisAngle(axis, angle, out Matrix3 result);
            return result;
        }*/

        [BenchmarkCategory("Matrix4")]
        [Benchmark]
        public Matrix4 Matrix4FromQuaternion()
        {
            return Matrix4.CreateFromQuaternion(Quat);
        }

        [BenchmarkCategory("Matrix4")]
        [Benchmark(Baseline = true)]
        public Matrix4 Matrix4FromQuaternionOld()
        {
            Quat.ToAxisAngle(out Vector3 axis, out float angle);
            Matrix4.CreateFromAxisAngle(axis, angle, out Matrix4 result);
            return result;
        }
    }
}
