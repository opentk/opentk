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
    [BenchmarkCategory("Matrix", "Matrix3", "Multiplication")]
    public class Matrix3Multiplication
    {
        private Matrix3 _left;
        private Matrix3 _right;

        private Matrix3 _result;

        [GlobalSetup]
        public void Setup()
        {
            var rand = new Random(123);

            _left = rand.NextMatrix3();
            _right = rand.NextMatrix3();
        }

        [Benchmark(Description = "Matrix3.Mult(Matrix3 left, Matrix3 right)")]
        public void Matrix3_MultiplyByValue_Matrix3()
        {
            _result = Matrix3.Mult(_left, _right);
        }

        [Benchmark(Description = "Matrix3.Mult(ref Matrix3 left, ref Matrix3 right, out Matrix3 result)")]
        public void Matrix3_MultiplyByReference_Matrix3()
        {
            Matrix3.Mult(ref _left, ref _right, out _result);
        }
    }
}
