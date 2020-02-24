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
    [BenchmarkCategory("Vector", "Vector3", "Magnitude")]
    public class Vector3Magnitude
    {
        private Vector3 _left = new Vector3(1, 2, 3);
        private Vector3 _right = new Vector3(3, 2, 1);

        [Benchmark(Description = "Vector3.MagnitudeMin(Vector3 left, Vector3 right)")]
        public Vector3 Vector3_MagnitudeMinByValue()
        {
            return Vector3.MagnitudeMin(_left, _right);
        }

        [Benchmark(Description = "Vector3.MagnitudeMax(Vector3 left, Vector3 right)")]
        public Vector3 Vector3_MagnitudeMaxByValue()
        {
            return Vector3.MagnitudeMax(_left, _right);
        }

        [Benchmark(Description = "Vector3.MagnitudeMin(ref Vector3 left, ref Vector3 right, out Vector3 result)")]
        public Vector3 Vector3_MagnitudeMinByReference()
        {
            Vector3.MagnitudeMin(ref _left, ref _right, out var result);

            return result;
        }

        [Benchmark(Description = "Vector3.MagnitudeMax(ref Vector3 left, ref Vector3 right, out Vector3 result)")]
        public Vector3 Vector3_MagnitudeMaxByReference()
        {
            Vector3.MagnitudeMax(ref _left, ref _right, out var result);

            return result;
        }
    }
}
