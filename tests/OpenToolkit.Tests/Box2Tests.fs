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
        //
        [<Property>]
        let ``Vector constructor sets all values accordingly`` (v1 : Vector2, v2 : Vector2) =
            let b = Box2(v1, v2)
            let vMin = Vector2(Math.Min(v1.X, v2.X), Math.Min(v1.Y, v2.Y))
            let vMax = Vector2(Math.Max(v1.X, v2.X), Math.Max(v1.Y, v2.Y))
            
            Assert.Equal(vMin, b.Min)
            Assert.Equal(vMax, b.Max)
        [<Property>]
        let ``Float constructor sets all values accordingly`` (f1 : float32, f2 : float32, f3 : float32, f4 : float32) =
            let b = Box2(f1, f2, f3, f4)
            let vMin = Vector2(Math.Min(f1, f3), Math.Min(f1, f3))
            let vMax = Vector2(Math.Max(f2, f4), Math.Max(f2, f4))
            
            Assert.Equal(vMin, b.Min)
            Assert.Equal(vMax, b.Max)