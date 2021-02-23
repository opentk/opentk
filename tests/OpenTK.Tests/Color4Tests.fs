namespace OpenTK.Tests

open Xunit
open FsCheck
open FsCheck.Xunit
open System
open System.Runtime.InteropServices
open OpenTK
open OpenTK.Mathematics

module Color4 =
    [<Literal>]
    let private epsilon:float32 = 1.0e-6f
    let private epsilonXYZ:float32 = 1.0e-4f

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Covertions =
        [<Property>]
        let ``RGB to sRGB to RGB roundtrip`` (c : Color4) =
            let srgb = Color4.ToSrgb c
            let rgb = Color4.FromSrgb srgb
            Assert.ApproximatelyEquivalent(c, rgb, epsilon)

        [<Property>]
        let ``RGB to HSL to RGB roundtrip`` (Color4LDR c) =
            let hsl = Color4.ToHsl c
            let rgb = Color4.FromHsl hsl
            Assert.ApproximatelyEquivalent(c, rgb, epsilon)

        [<Property>]
        let ``RGB to HSV to RGB roundtrip`` (c : Color4) =
            let hsv = Color4.ToHsv c
            let rgb = Color4.FromHsv hsv
            Assert.ApproximatelyEquivalent(c, rgb, epsilon)

        [<Property>]
        let ``RGB to XYZ to RGB roundtrip`` (Color4LDR c) =
            let xyz = Color4.ToXyz c
            let rgb = Color4.FromXyz xyz
            Assert.ApproximatelyEquivalent(c, rgb, epsilonXYZ)
        
        [<Property>]
        let ``RGB to YCbCr to RGB roundtrip`` (Color4LDR c) =
            let ycbcr = Color4.ToYcbcr c
            let rgb = Color4.FromYcbcr ycbcr
            Assert.ApproximatelyEquivalent(c, rgb, epsilon)

        [<Property>]
        let ``RGB to HCY to RGB roundtrip`` (Color4LDR c) =
            let hcy = Color4.ToHcy c
            let rgb = Color4.FromHcy hcy
            Assert.ApproximatelyEquivalent(c, rgb, epsilon)

            


