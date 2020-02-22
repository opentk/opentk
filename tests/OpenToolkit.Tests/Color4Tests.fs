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
    let private epsilon:float32 = 1e-3f

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Covertions =
        [<Property>]
        let ``Rgba to rgb roundtrip`` (c : Color4<Rgba>) =
            let rgb = c.ToRgb()
            let rgba = rgb.ToRgba(c.W)
            Assert.ApproximatelyEquivalent(c, rgba, epsilon)

        [<Property>]
        let ``Rgba to hsva roundtrip`` (c : Color4<Rgba>) =
            let hsva = c.ToHsva()
            let rgba = hsva.ToRgba()
            Assert.ApproximatelyEquivalent(c, rgba, epsilon)

        [<Property>]
        let ``Rgba to hsla roundtrip`` (c : Color4<Rgba>) =
            let hsla = c.ToHsla()
            let rgba = hsla.ToRgba()
            Assert.ApproximatelyEquivalent(c.X, rgba.X)
            Assert.ApproximatelyEquivalent(c.Y, rgba.Y)
            Assert.ApproximatelyEquivalent(c.Z, rgba.Z)
            Assert.ApproximatelyEquivalent(c.W, rgba.W)

        [<Property>]
        let ``Hsva to hsv roundtrip`` (c : Color4<Hsva>) =
            let hsv = c.ToHsv()
            let hsva = hsv.ToHsva(c.W)
            Assert.ApproximatelyEquivalent(c, hsva, epsilon)

        [<Property>]
        let ``Hsva to rgba roundtrip`` (c : Color4<Hsva>) =
            let rgba = c.ToRgba()
            let hsva = rgba.ToHsva()
            Assert.ApproximatelyEquivalent(c, hsva, epsilon)

        [<Property>]
        let ``Hsva to hsla roundtrip`` (c : Color4<Hsva>) =
            let hsla = c.ToHsla()
            let hsva = hsla.ToHsva()
            Assert.ApproximatelyEquivalent(c, hsva, epsilon)
        
        [<Property>]
        let ``Hsla to hsl roundtrip`` (c : Color4<Hsla>) =
            let hsl = c.ToHsl()
            let hsla = hsl.ToHsla(c.W)
            Assert.ApproximatelyEquivalent(c, hsla, epsilon)
            
        [<Property>]
        let ``Hsla to rgba roundtrip`` (c : Color4<Hsla>) =
            let rgba = c.ToRgba()
            let hsla = rgba.ToHsla()
            Assert.ApproximatelyEquivalent(c.X, hsla.X)
            Assert.ApproximatelyEquivalent(c.Y, hsla.Y)
            Assert.ApproximatelyEquivalent(c.Z, hsla.Z)
            Assert.ApproximatelyEquivalent(c.W, hsla.W)
            
        [<Property>]
        let ``Hsla to hsva roundtrip`` (c : Color4<Hsla>) =
            let hsva = c.ToHsva()
            let hsla = hsva.ToHsla()
            Assert.ApproximatelyEquivalent(c, hsla, epsilon)