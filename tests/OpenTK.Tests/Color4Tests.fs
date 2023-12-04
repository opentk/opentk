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
    let private epsilon:float32 = 1e-6f

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Covertions =
        [<Property>]
        let ``Rgba to rgb roundtrip`` (rgba1 : Color4<Rgba>) =
            let rgb = rgba1.ToRgb()
            let rgba2 = rgb.ToRgba(rgba1.W)
            Assert.ApproximatelyEquivalent(rgba1, rgba2, epsilon)

        [<Property>]
        let ``Rgba to argb roundtrip`` (rgba1 : Color4<Rgba>) =
            let argb = rgba1.ToArgb()
            let rgba2 = argb.ToRgba()
            Assert.ApproximatelyEquivalent(rgba1, rgba2, epsilon)

        [<Property>]
        let ``Rgba to hsva roundtrip`` (rgba1 : Color4<Rgba>) =
            let hsva = rgba1.ToHsva()
            let rgba2 = hsva.ToRgba()
            Assert.ApproximatelyEquivalent(rgba1, rgba2, epsilon)

        [<Property>]
        let ``Rgba to hsla roundtrip`` (rgba1 : Color4<Rgba>) =
            let hsla = rgba1.ToHsla()
            let rgba2 = hsla.ToRgba()
            Assert.ApproximatelyEquivalent(rgba1, rgba2, epsilon)
            
        // FIXME: This is very numerically unstable with the current implementation.
        // We want a better implementation for this that doesn't suffer from the numericals issues this method has....
        //[<Property>]
        //let ``Hsla to hsva roundtrip`` (hsla1 : Color4<Hsla>) =
        //    let hsva = hsla1.ToHsva()
        //    let hsla2 = hsva.ToHsla()
        //    Assert.ApproximatelyEquivalent(hsla1, hsla2, epsilon)