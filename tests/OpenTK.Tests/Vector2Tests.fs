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
        
        //[<Property>]
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
    module Indexing = 
        //
        [<Property>]
        let ``Index operators work for the correct components`` (x,y) = 
            let v = Vector2(x,y)
            Assert.Equal(v.[0],v.X)
            Assert.Equal(v.[1],v.Y)
            
        [<Property>]
        let ``Vector indexing throws index out of range exception correctly`` (x, y) =
            let mutable v = Vector2(x, y)
            let invalidIndexingAccess = fun() -> v.[2] |> ignore
            Assert.Throws<IndexOutOfRangeException>(invalidIndexingAccess) |> ignore
            
            let invalidIndexingAssignment = (fun() -> v.[2] <- x) 
            Assert.Throws<IndexOutOfRangeException>(invalidIndexingAssignment) |> ignore
        
        [<Property>]
        let ``Component assignment by indexing works`` (x, y) =
            let mutable v = Vector2()
            v.[0] <- x
            v.[1] <- y
            Assert.Equal(x, v.X)
            Assert.Equal(y, v.Y)
 
 
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
            
            // Inverse direction
            let r = f * a
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

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Negation =
        //
        [<Property>]
        let ``Vector negation operator works`` (x, y) =
            let v = Vector2(x, y)
            let vNeg = -v
            Assert.Equal(-x, vNeg.X)
            Assert.Equal(-y, vNeg.Y)
            
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Equality =
        //
        [<Property>]
        let ``Vector equality operator works`` (x, y) =
            let v1 = Vector2(x, y)
            let v2 = Vector2(x, y)
            let equality = v1 = v2
            
            Assert.True(equality)
            
        [<Property>]
        let ``Vector inequality operator works`` (x, y) =
            let v1 = Vector2(x, y)
            let v2 = Vector2(x + (float32)1 , y + (float32)1)
            let inequality = v1 <> v2
            
            Assert.True(inequality)
            
        [<Property>]
        let ``Vector equality method works`` (x, y) =
            let v1 = Vector2(x, y)
            let v2 = Vector2(x, y)
            let notVector = Matrix2()
            
            let equality = v1.Equals(v2)
            let inequalityByOtherType = v1.Equals(notVector)
            
            Assert.True(equality)
            Assert.False(inequalityByOtherType)
            
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Swizzling =
        //
        [<Property>]
        let ``Vector swizzling works`` (x, y) =
            let v1 = Vector2(x, y)
            let v2 = Vector2(y, x)
            
            let v1yx = v1.Yx;
            Assert.Equal(v2, v1yx);

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Interpolation =
        //
        [<Property>]
        let ``Linear interpolation works`` (a : Vector2, b : Vector2, q) =

            let blend = q
            
            let rX = blend * (b.X - a.X) + a.X 
            let rY = blend * (b.Y - a.Y) + a.Y
            let vExp = Vector2(rX, rY)
            
            Assert.Equal(vExp, Vector2.Lerp(a, b, q))
            
            let vRes = Vector2.Lerp(ref a, ref b, q)
            Assert.Equal(vExp, vRes)
            
        [<Property>]
        let ``Barycentric interpolation works`` (a : Vector2, b : Vector2, c : Vector2, u, v) =

            let r = a + u * (b - a) + v * (c - a)
            
            Assert.Equal(r, Vector2.BaryCentric(a, b, c, u, v))
            
            let vRes = Vector2.BaryCentric(ref a, ref b, ref c, u, v)
            Assert.Equal(r, vRes)
            
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module ``Vector products`` =
        //
        [<Property>]
        let ``Dot product works`` (a : Vector2, b : Vector2) =
            let dot = a.X * b.X + a.Y * b.Y
            
            Assert.Equal(dot, Vector2.Dot(a, b));
            
            let vRes = Vector2.Dot(ref a, ref b)
            Assert.Equal(dot, vRes)
            
        [<Property>]
        let ``Perpendicular dot product works`` (a : Vector2, b : Vector2) =
            let dot = a.X * b.Y - a.Y * b.X
            
            Assert.Equal(dot, Vector2.PerpDot(a, b));
            
            let vRes = Vector2.PerpDot(ref a, ref b)
            Assert.Equal(dot, vRes)
            
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Normalization =
        //
        [<Property>]
        let ``Normalization works`` (a : Vector2) =
            let scale = 1.0f / a.Length
            let norm = Vector2(a.X * scale, a.Y * scale)
            let vRes = Vector2.Normalize(ref a)
            Assert.Equal(norm, Vector2.Normalize(a));
            Assert.Equal(norm, vRes)
            
        [<Property>]
        let ``Fast approximate normalization works`` (a : Vector2, b : Vector2) =
            let scale = MathHelper.InverseSqrtFast(a.X * a.X + a.Y * a.Y)
            let norm = Vector2(a.X * scale, a.Y * scale)
            let vRes = Vector2.NormalizeFast(ref a)
            
            Assert.Equal(norm, Vector2.NormalizeFast(a));
            Assert.Equal(norm, vRes)