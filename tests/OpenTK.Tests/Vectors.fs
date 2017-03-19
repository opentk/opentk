namespace OpenTK.Tests

open Xunit
open FsCheck
open FsCheck.Xunit
open System
open OpenTK

[<RequireQualifiedAccess>]
module internal Generators = 
    let private isValidFloat f = not (Single.IsNaN f || Single.IsInfinity f)
    
    let Vec2 = 
        Arb.generate<float32>
        |> Gen.filter isValidFloat
        |> Gen.two
        |> Gen.map Vector2
        |> Arb.fromGen
    
    let Vec3 = 
        Arb.generate<float32>
        |> Gen.filter isValidFloat
        |> Gen.three
        |> Gen.map Vector3
        |> Arb.fromGen
    
    let Vec4 = 
        Arb.generate<float32>
        |> Gen.filter isValidFloat
        |> Gen.four
        |> Gen.map Vector4
        |> Arb.fromGen

type VectorGen = 
    static member Vector2() = Generators.Vec2
    static member Vector3() = Generators.Vec3
    static member Vector4() = Generators.Vec4

module Vector2 = 
    [<Properties(Arbitrary = [| typeof<VectorGen> |])>]
    module ``Simple Properties`` = 
        //
        [<Property>]
        let ``Vector equality is by component`` (a : Vector2,b : Vector2) = 
            //
            Assert.Equal((a.X = b.X && a.Y = b.Y),(a = b))
        
        [<Property>]
        let ``Vector length is always >= 0`` (a : Vector2) = 
            //
            Assert.True(a.Length >= 0.0f)
    
    [<Properties(Arbitrary = [| typeof<VectorGen> |])>]
    module Addition = 
        //
        [<Property>]
        let ``Vector addition is the same as component addition`` (a : Vector2,b : Vector2) = 
            let c = a + b
            Assert.Equal(a.X + b.X,c.X)
            Assert.Equal(a.Y + b.Y,c.Y)
        
        [<Property>]
        let ``Vector addition is commutative`` (a : Vector2,b : Vector2) = 
            let c = a + b
            let c2 = b + a
            Assert.Equal(c,c2)
        
        [<Property>]
        let ``Vector addition is associative`` (a : Vector2,b : Vector2,c : Vector2) = 
            let r1 = (a + b) + c
            let r2 = a + (b + c)
            Assert.Equal(r1,r2)
    
    [<Properties(Arbitrary = [| typeof<VectorGen> |])>]
    module Multiplication = 
        //
        [<Property>]
        let ``Vector multiplication is the same as component multiplication`` (a : Vector2,b : Vector2) = 
            let c = a * b
            Assert.Equal(a.X * b.X,c.X)
            Assert.Equal(a.Y * b.Y,c.Y)
        
        [<Property>]
        let ``Vector multiplication is commutative`` (a : Vector2,b : Vector2) = 
            let r1 = a * b
            let r2 = b * a
            Assert.Equal(r1,r2)
        
        [<Property>]
        let ``Vector-float multiplication is the same as component-float multiplication`` (a : Vector2,f : float32) = 
            let r = a * f
            Assert.Equal(a.X * f,r.X)
            Assert.Equal(a.Y * f,r.Y)
    
    [<Properties(Arbitrary = [| typeof<VectorGen> |])>]
    module Subtraction = 
        //
        [<Property>]
        let ``Vector subtraction is the same as component subtraction`` (a : Vector2,b : Vector2) = 
            let c = a - b
            Assert.Equal(a.X - b.X,c.X)
            Assert.Equal(a.Y - b.Y,c.Y)
    
    [<Properties(Arbitrary = [| typeof<VectorGen> |])>]
    module Division = 
        //
        [<Property>]
        let ``Vector-float division is the same as component-float division`` (a : Vector2,f : float32) = 
            if f <> 0.0f then 
                let r = a / f
                Assert.Equal(a.X / f,r.X)
                Assert.Equal(a.Y / f,r.Y)
