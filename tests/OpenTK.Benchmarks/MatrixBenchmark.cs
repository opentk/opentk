using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenTK.Benchmarks
{
    [DisassemblyDiagnoser]
    [SimpleJob(RuntimeMoniker.Net10_0)]
    public class MatrixBenchmark
    {
        [Params(1, 10, 1000)]
        public int N { get; set; }
        public Matrix4[] InMatrices { get; set; }
        public Quaternion[] Output { get; set; }

        public Random Rand = new Random();
        public float NextFloat() => (float)Rand.Next();

        [GlobalSetup]
        public void Setup()
        {
            Rand = new Random();
            InMatrices = new Matrix4[N];
            Output = new Quaternion[N];
            for (int i = 0; i < InMatrices.Length; i++)
            {
                InMatrices[i] = new Matrix4(NextFloat(), NextFloat(), NextFloat(), NextFloat(), NextFloat(), NextFloat(), NextFloat(), NextFloat(), NextFloat(), NextFloat(), NextFloat(), NextFloat(), NextFloat(), NextFloat(), NextFloat(), NextFloat());
            }
        }

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
        }

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
        */

        [Benchmark(Baseline = true)]
        public void ExtractRotationOld()
        {
            Matrix4[] matrices = InMatrices;
            Quaternion[] output = Output;
            for (int i = 0; i < InMatrices.Length; i++)
            {
                Output[i] = matrices[i].ExtractRotation();
            }
        }

        [Benchmark]
        public void ExtractRotationNew()
        {
            Matrix4[] matrices = InMatrices;
            Quaternion[] output = Output;
            for (int i = 0; i < InMatrices.Length; i++)
            {
                Output[i] = matrices[i].ExtractRotationNew();
            }
        }
    }
}
