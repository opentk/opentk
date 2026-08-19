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
        [Params(1000, 10_000, 100_000, 1_000_000)]
        public int N;

        public Matrix4[] Matrices { get; set; }

        public System.Numerics.Matrix4x4[] SNMatrices { get; set; }

        [GlobalSetup]
        public void Setup()
        {
            Matrices = new Matrix4[N];
            SNMatrices = new System.Numerics.Matrix4x4[N];

            Random rand = new Random();
            for (int i = 0; i < Matrices.Length; i++)
            {
                Matrices[i] = new Matrix4(
                    rand.NextSingle(), rand.NextSingle(), rand.NextSingle(), rand.NextSingle(),
                    rand.NextSingle(), rand.NextSingle(), rand.NextSingle(), rand.NextSingle(),
                    rand.NextSingle(), rand.NextSingle(), rand.NextSingle(), rand.NextSingle(),
                    rand.NextSingle(), rand.NextSingle(), rand.NextSingle(), rand.NextSingle());

                SNMatrices[i] = new System.Numerics.Matrix4x4(
                    rand.NextSingle(), rand.NextSingle(), rand.NextSingle(), rand.NextSingle(),
                    rand.NextSingle(), rand.NextSingle(), rand.NextSingle(), rand.NextSingle(),
                    rand.NextSingle(), rand.NextSingle(), rand.NextSingle(), rand.NextSingle(),
                    rand.NextSingle(), rand.NextSingle(), rand.NextSingle(), rand.NextSingle());
            }
        }

        [Benchmark(Baseline = true)]
        public Matrix4 MultScalar()
        {
            Matrix4 result = Matrices[0];
            for (int i = 1; i < Matrices.Length; i++)
            {
                Matrix4.MultFallback(result, Matrices[i], out result);
            }
            return result;
        }

        [Benchmark]
        public Matrix4 MultSSE1()
        {
            Matrix4 result = Matrices[0];
            for (int i = 1; i < Matrices.Length; i++)
            {
                Matrix4.MultSSE1(result, Matrices[i], out result);
            }
            return result;
        }

        [Benchmark]
        public Matrix4 MultAVX2_FMA()
        {
            Matrix4 result = Matrices[0];
            for (int i = 1; i < Matrices.Length; i++)
            {
                Matrix4.MultAVX_FMA(result, Matrices[i], out result);
            }
            return result;
        }

#if NET8_0_OR_GREATER
        [Benchmark]
        public Matrix4 MultAVX512_FMA()
        {
            Matrix4 result = Matrices[0];
            for (int i = 1; i < Matrices.Length; i++)
            {
                Matrix4.MultAVX512_FMA(result, Matrices[i], out result);
            }
            return result;
        }
#endif

        [Benchmark]
        public System.Numerics.Matrix4x4 MultSN()
        {
            System.Numerics.Matrix4x4 result = SNMatrices[0];
            for (int i = 1; i < Matrices.Length; i++)
            {
                result = result * SNMatrices[i];
            }
            return result;
        }
    }
}
