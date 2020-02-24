using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using OpenToolkit.Mathematics;

namespace OpenToolkit.Benchmarks.Mathematics.Matrix
{
    [SimpleJob(RuntimeMoniker.Net472, baseline: true)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [RPlotExporter]
    [BenchmarkCategory("Matrix", "Matrix4", "Multiplication")]
    public class Matrix4Multiplication
    {
        private Matrix4 _left;
        private Matrix4 _right;

        private Matrix4 _result;

        private const float Scalar = 0.5f;

        [GlobalSetup]
        public void Setup()
        {
            var rand = new Random(123);

            _left = rand.NextMatrix4();
            _right = rand.NextMatrix4();
        }

        [Benchmark(Description = "Matrix4.Mult(Matrix4 left, Matrix4 right)")]
        public void Matrix4_MultiplyByValue_Matrix4()
        {
            _result = Matrix4.Mult(_left, _right);
        }

        [Benchmark(Description = "Matrix4.Mult(Matrix4 left, float right)")]
        public void Matrix4_MultiplyByValue_Single()
        {
            _result = Matrix4.Mult(_left, Scalar);
        }

        [Benchmark(Description = "Matrix4.Mult(ref Matrix4 left, ref Matrix4 right, out Matrix4 result)")]
        public void Matrix4_MultiplyByReference_Matrix4()
        {
            Matrix4.Mult(ref _left, ref _right, out _result);
        }

        [Benchmark(Description = "Matrix4.Mult(ref Matrix4 left, ref float right, out Matrix4 result)")]
        public void Matrix4_MultiplyByReference_Single()
        {
            Matrix4.Mult(ref _left, ref _right, out _result);
        }

        [Benchmark(Description = "Matrix4 * Single")]
        public void Matrix4_MultiplyByOperator_Single()
        {
            _result = _left * Scalar;
        }

        [Benchmark(Description = "Matrix4 * Matrix4")]
        public void Matrix4_MultiplyByOperator_Matrix4()
        {
            _result = _left * Scalar;
        }
    }
}
