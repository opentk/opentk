namespace OpenToolkit.Tests

open Xunit
open FsCheck
open System
open FsCheck.Xunit
open System.Runtime.InteropServices
open OpenToolkit
open OpenToolkit.Mathematics

module Box2 =
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Constructors =
        [<Property>]
        let ``Vector constructor sets all values accordingly`` (v1 : Vector2, v2 : Vector2) =
            let b = Box2(v1, v2)
            let vMin = Vector2(Math.Min(v1.X, v2.X), Math.Min(v1.Y, v2.Y))
            let vMax = Vector2(Math.Max(v1.X, v2.X), Math.Max(v1.Y, v2.Y))

            Assert.Equal(vMin, b.Min)
            Assert.Equal(vMax, b.Max)

        [<Property>]
        let ``Float constructor should be the same as creating vectors and using the vector constructor`` (f1 : float32, f2 : float32, f3 : float32, f4 : float32) =
            let b1 = Box2(f1, f2, f3, f4)
            let b2 = Box2(Vector2(f1, f2), Vector2(f3, f4))

            Assert.Equal(b1, b2)
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Size =
        [<Property>]
        let ``The size of a given box must be greater than or equal to 0`` (b : Box2) =
            Assert.True(b.Size.X * b.Size.Y >= (float32)0)