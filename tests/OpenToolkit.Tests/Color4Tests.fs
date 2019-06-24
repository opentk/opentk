namespace OpenToolkit.Tests

open Xunit
open FsCheck
open FsCheck.Xunit
open System
open System.Runtime.InteropServices
open OpenToolkit
open OpenToolkit.Mathematics

module Color4 =
    [<Literal>]
    let private epsilon:float32 = 1e-6f

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Covertions =
        [<Property>]
        let ``RGB to sRGB to RGB roundtrip`` (c : Color4) =
            let srgb = Color4.ToSrgb c
            let rgb = Color4.FromSrgb srgb
            Assert.ApproximatelyEqualEpsilon(c, rgb, epsilon)

        [<Property>]
        let ``RGB to HSL to RGB roundtrip`` (Color4LDR c) =
            let hsl = Color4.ToHsl c
            let rgb = Color4.FromHsl hsl
            Assert.ApproximatelyEqualEpsilon(c, rgb, epsilon)

        [<Property>]
        let ``RGB to HSV to RGB roundtrip`` (c : Color4) =
            let hsv = Color4.ToHsv c
            let rgb = Color4.FromHsv hsv
            Assert.ApproximatelyEqualEpsilon(c, rgb, epsilon)

        [<Property>]
        let ``RGB to XYZ to RGB roundtrip`` (Color4LDR c) =
            let xyz = Color4.ToXyz c
            let rgb = Color4.FromXyz xyz
            Assert.ApproximatelyEqualEpsilon(c, rgb, epsilon)
        
        [<Property>]
        let ``RGB to YCbCr to RGB roundtrip`` (c : Color4) =
            let ycbcr = Color4.ToYcbcr c
            let rgb = Color4.FromYcbcr ycbcr
            Assert.ApproximatelyEqualEpsilon(c, rgb, epsilon)

        [<Property>]
        let ``RGB to HCY to RGB roundtrip`` (Color4LDR c) =
            let hcy = Color4.ToHcy c
            let rgb = Color4.FromHcy hcy
            Assert.ApproximatelyEqualEpsilon(c, rgb, epsilon)

            


