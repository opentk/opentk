namespace OpenTK.Tests

open Xunit
open FsCheck
open FsCheck.Xunit
open System
open System.Runtime.InteropServices
open OpenTK
open OpenTK.Mathematics

module Half =
    [<Fact>]
    let ``Casting Half to Single and back to Half is lossless`` () =
        for bits = int System.Int16.MinValue to int System.Int16.MaxValue do
            let bytes = System.BitConverter.GetBytes(int16 bits)
            let half = Half.FromBytes(bytes, 0)
            let single = float32 half
            let roundtrip = Half single

            Assert.True((half.IsNaN && roundtrip.IsNaN) || half = roundtrip)

    [<Fact>]
    let ``Half.ToString and Single.ToString return same string for same value`` () =
        for bits = int System.Int16.MinValue to int System.Int16.MaxValue do
            let bytes = System.BitConverter.GetBytes(int16 bits)
            let half = Half.FromBytes(bytes, 0)
            let single = float32 half
            Assert.Equal(half.ToString(), single.ToString())

    [<Fact>]
    let ``Half can represent all integers from -2048 to 2048 exactly`` () =
        for i = -2048 to 2048 do
            let single = float32 i
            let half = Half single
            Assert.Equal(single, float32 half)

    [<Fact>]
    let ``Single NaN and inifnity can be cast to Half NaN and infinity`` () =
        Assert.True((Half System.Single.NaN).IsNaN)
        Assert.True((Half System.Single.PositiveInfinity).IsPositiveInfinity)
        Assert.True((Half System.Single.NegativeInfinity).IsNegativeInfinity)
