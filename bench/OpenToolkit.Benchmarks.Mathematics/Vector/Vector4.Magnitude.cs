using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using OpenToolkit.Mathematics;

namespace OpenToolkit.Benchmarks.Mathematics.Vector
{
    [SimpleJob(RuntimeMoniker.Net472, baseline: true)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [RPlotExporter]
    [BenchmarkCategory("Vector", "Vector4", "Magnitude")]
    public class Vector4Magnitude
    {
        private Vector4 _left = new Vector4(1, 2, 3, 4);
        private Vector4 _right = new Vector4(4, 3, 2, 1);

        private Vector4 _result;

        [Benchmark(Description = "Vector4.MagnitudeMin(Vector4 left, Vector4 right)")]
        public void Vector4_MagnitudeMinByValue()
        {
            _result = Vector4.MagnitudeMin(_left, _right);
        }

        [Benchmark(Description = "Vector4.MagnitudeMax(Vector4 left, Vector4 right)")]
        public void Vector4_MagnitudeMaxByValue()
        {
            _result = Vector4.MagnitudeMax(_left, _right);
        }

        [Benchmark(Description = "Vector4.MagnitudeMin(ref Vector4 left, ref Vector4 right, out Vector4 result)")]
        public void Vector4_MagnitudeMinByReference()
        {
            Vector4.MagnitudeMin(ref _left, ref _right, out _result);
        }

        [Benchmark(Description = "Vector4.MagnitudeMax(ref Vector4 left, ref Vector4 right, out Vector4 result)")]
        public void Vector4_MagnitudeMaxByReference()
        {
            Vector4.MagnitudeMax(ref _left, ref _right, out _result);
        }
    }
}
