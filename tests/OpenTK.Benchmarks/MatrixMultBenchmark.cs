using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.Mathematics;

namespace OpenTK.Benchmarks
{

    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net10_0)]
    [DisassemblyDiagnoser(maxDepth: 2, syntax: BenchmarkDotNet.Diagnosers.DisassemblySyntax.Intel, exportHtml: true)]
    public class MatrixMultBenchmark
    {
        public Matrix4 A { get; set; }

        public Matrix4 B { get; set; }

        public System.Numerics.Matrix4x4 ASN { get; set; }

        public System.Numerics.Matrix4x4 BSN { get; set; }

        [Benchmark(Baseline = true)]
        public Matrix4 MultScalar()
        {
            Matrix4.MultFallback(A, B, out Matrix4 result);
            return result;
        }

        [Benchmark]
        public Matrix4 MultSSE1()
        {
            Matrix4.MultSSE1(A, B, out Matrix4 result);
            return result;
        }

        [Benchmark]
        public Matrix4 MultAVX2_FMA()
        {
            Matrix4.MultAVX_FMA(A, B, out Matrix4 result);
            return result;
        }

#if NET8_0_OR_GREATER
        [Benchmark]
        public Matrix4 MultAVX512_FMA()
        {
            Matrix4.MultAVX512_FMA(A, B, out Matrix4 result);
            return result;
        }
#endif

        [Benchmark]
        public System.Numerics.Matrix4x4 MultSN()
        {
            return ASN * BSN;
        }
    }
}
