using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SN = System.Numerics;

namespace OpenTK.Benchmarks
{
    [SimpleJob]
    [DisassemblyDiagnoser]
    public class VectorBenchmark
    {
        public Vector3 A;
        public Vector3 B;
        public SN.Vector3 SNA;
        public SN.Vector3 SNB;

        [GlobalSetup]
        public void Setup()
        {
            Random random = Random.Shared;
            A = new Vector3(NextFloat(random), NextFloat(random), NextFloat(random));
            B = new Vector3(NextFloat(random), NextFloat(random), NextFloat(random));
            SNA = new SN.Vector3(NextFloat(random), NextFloat(random), NextFloat(random));
            SNB = new SN.Vector3(NextFloat(random), NextFloat(random), NextFloat(random));

            static float NextFloat(Random random)
            {
                return Unsafe.BitCast<uint, float>(NextUint(random));
            }

            static uint NextUint(Random random)
            {
                uint thirtyBits = (uint)random.Next(1 << 30);
                uint twoBits = (uint)random.Next(1 << 2);
                uint fullRange = (thirtyBits << 2) | twoBits;
                return fullRange;
            }
        }

        [Benchmark(Baseline = true)]
        public Vector3 ComponentMinIEEE()
        {
            return Vector3.ComponentMin(A, B);
        }

        [Benchmark]
        public Vector3 ComponentMinNumber()
        {
            return Vector3.ComponentMinNumber(A, B);
        }

        [Benchmark]
        public Vector3 ComponentMinNative()
        {
            return Vector3.ComponentMinNative(A, B);
        }

        [Benchmark()]
        public SN.Vector3 SNComponentMinIEEE()
        {
            return SN.Vector3.Min(SNA, SNB);
        }

        [Benchmark]
        public SN.Vector3 SNComponentMinNumber()
        {
            return SN.Vector3.MinNumber(SNA, SNB);
        }

        [Benchmark]
        public SN.Vector3 SNComponentMinNative()
        {
            return SN.Vector3.MinNative(SNA, SNB);
        }
    }
}
