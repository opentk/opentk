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
    [BenchmarkCategory("Matrix", "Matrix4", "Inversion")]
    public class Matrix4Inversion
    {
        private Matrix4 _matrix;
        private Matrix4 _result;

        [GlobalSetup]
        public void Setup()
        {
            _matrix = Matrix4.CreateOrthographicOffCenter(-1, -1, 2, 2, -1, 1);
        }

        [Benchmark(Description = "Matrix4.Invert(Matrix4 mat)")]
        public Matrix4 Matrix4_InvertByValue()
        {
            return Matrix4.Invert(_matrix);
        }

        [Benchmark(Description = "Matrix4.Invert(ref Matrix4 mat, out Matrix4 result)")]
        public void Matrix4_InvertByReference()
        {
            Matrix4.Invert(ref _matrix, out _result);
        }
    }
}
