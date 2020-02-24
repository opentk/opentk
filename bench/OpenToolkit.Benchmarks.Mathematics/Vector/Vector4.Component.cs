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
    [BenchmarkCategory("Vector", "Vector4", "Component")]
    public class Vector4Component
    {
        private Vector4 _left = new Vector4(1, 2, 3, 4);
        private Vector4 _right = new Vector4(4, 3, 2, 1);

        private Vector4 _result;

        [Benchmark(Description = "Vector4.ComponentMin(Vector4 left, Vector4 right)")]
        public void Vector4_ComponentMinByValue()
        {
            _result = Vector4.ComponentMin(_left, _right);
        }

        [Benchmark(Description = "Vector4.ComponentMax(Vector4 left, Vector4 right)")]
        public void Vector4_ComponentMaxByValue()
        {
            _result = Vector4.ComponentMax(_left, _right);
        }

        [Benchmark(Description = "Vector4.ComponentMin(ref Vector4 left, ref Vector4 right, out Vector4 result)")]
        public void Vector4_ComponentMinByReference()
        {
            Vector4.ComponentMin(ref _left, ref _right, out _result);
        }

        [Benchmark(Description = "Vector4.ComponentMax(ref Vector4 left, ref Vector4 right, out Vector4 result)")]
        public void Vector4_ComponentMaxByReference()
        {
            Vector4.ComponentMax(ref _left, ref _right, out _result);
        }
    }
}
