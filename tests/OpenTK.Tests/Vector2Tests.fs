namespace OpenTK.Tests

open Xunit
open FsCheck
open FsCheck.Xunit
open System
open OpenTK

module Vector2 = 
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Constructors = 
        //
        [<Property>]
        let ``Single value constructor sets all components to the same value`` (f : float32) = 
            let v = Vector2(f)
            Assert.Equal(f,v.X)
            Assert.Equal(f,v.Y)
        
        [<Property>]
        let ``Two value constructor sets all components correctly`` (x,y) = 
            let v = Vector2(x,y)
            Assert.Equal(x,v.X)
            Assert.Equal(y,v.Y)
        
        [<Property>]
        let ``Index operators work for the correct components`` (x,y) = 
            let v = Vector2(x,y)
            Assert.Equal(v.[0],v.X)
            Assert.Equal(v.[1],v.Y)
        
//        [<Property>]
        // disabled - behaviour needs discussion
        let ``Clamping works for each component`` (a : Vector2,b : Vector2,c : Vector2) = 
            let inline clamp (value : float32) minV maxV = MathHelper.Clamp(value,minV,maxV)
            let r = Vector2.Clamp(a,b,c)
            Assert.Equal(clamp a.X b.X c.X,r.X)
            Assert.Equal(clamp a.Y b.Y c.Y,r.Y)
        
        [<Property>]
        let ``Length is always >= 0`` (a : Vector2) = 
            //
            Assert.True(a.Length >= 0.0f)
    
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
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
    
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Addition = 
        //
        [<Property>]
        let ``Vector addition is the same as component addition`` (a : Vector2,b : Vector2) = 
            let c = a + b
            Assert.ApproximatelyEqual(a.X + b.X,c.X)
            Assert.ApproximatelyEqual(a.Y + b.Y,c.Y)
        
        [<Property>]
        let ``Vector addition is commutative`` (a : Vector2,b : Vector2) = 
            let c = a + b
            let c2 = b + a
            Assert.ApproximatelyEqual(c,c2)
        
        [<Property>]
        let ``Vector addition is associative`` (a : Vector2,b : Vector2,c : Vector2) = 
            let r1 = (a + b) + c
            let r2 = a + (b + c)
            Assert.ApproximatelyEqual(r1,r2)
    
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
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
    
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Subtraction = 
        //
        [<Property>]
        let ``Vector subtraction is the same as component subtraction`` (a : Vector2,b : Vector2) = 
            let c = a - b
            Assert.Equal(a.X - b.X,c.X)
            Assert.Equal(a.Y - b.Y,c.Y)
    
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Division = 
        //
        [<Property>]
        let ``Vector-float division is the same as component-float division`` (a : Vector2,f : float32) = 
            if not (approxEq f 0.0f) then // we don't support diving by zero.
                let r = a / f
                Assert.ApproximatelyEqual(a.X / f,r.X)
                Assert.ApproximatelyEqual(a.Y / f,r.Y)
