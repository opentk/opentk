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
    [BenchmarkCategory("Vector", "Vector3", "Component")]
    public class Vector3Component
    {
        private Vector3 _left = new Vector3(1, 2, 3);
        private Vector3 _right = new Vector3(3, 2, 1);

        [Benchmark(Description = "Vector3.ComponentMin(Vector3 left, Vector3 right)")]
        public Vector3 Vector3_ComponentMinByValue()
        {
            return Vector3.ComponentMin(_left, _right);
        }

        [Benchmark(Description = "Vector3.ComponentMax(Vector3 left, Vector3 right)")]
        public Vector3 Vector3_ComponentMaxByValue()
        {
            return Vector3.ComponentMax(_left, _right);
        }

        [Benchmark(Description = "Vector3.ComponentMin(ref Vector3 left, ref Vector3 right, out Vector3 result)")]
        public Vector3 Vector3_ComponentMinByReference()
        {
            Vector3.ComponentMin(ref _left, ref _right, out var result);

            return result;
        }

        [Benchmark(Description = "Vector3.ComponentMax(ref Vector3 left, ref Vector3 right, out Vector3 result)")]
        public Vector3 Vector3_ComponentMaxByReference()
        {
            Vector3.ComponentMax(ref _left, ref _right, out var result);

            return result;
        }
    }
}
