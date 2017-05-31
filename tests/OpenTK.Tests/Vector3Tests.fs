namespace OpenTK.Tests

open Xunit
open FsCheck
open FsCheck.Xunit
open System
open OpenTK

module Vector3 = 
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Constructors = 
        //
        [<Property>]
        let ``Triple value constructor sets all components to the correct values`` (a, b, c) = 
            let v = Vector3(a, b, c)

            Assert.Equal(a, v.X)
            Assert.Equal(b, v.Y)
            Assert.Equal(c, v.Z)
            
        [<Property>]
        let ``Single value constructor sets all components to the correct values`` (a : float32) = 
            let v = Vector3(a)

            Assert.Equal(a, v.X)
            Assert.Equal(a, v.Y)
            Assert.Equal(a, v.Z)
            
        [<Property>]
        let ``Vector2 value constructor sets all components to the correct values`` (a, b) = 
            let v1 = Vector2(a, b)
            let v2 = Vector3(v1)

            Assert.Equal(v1.X, v2.X)
            Assert.Equal(v1.Y, v2.Y)

            Assert.Equal(a, v2.X)
            Assert.Equal(b, v2.Y)
            Assert.Equal((float32)0, v2.Z)
            
        [<Property>]
        let ``Vector3 value constructor sets all components to the correct values`` (a, b, c) = 
            let v1 = Vector3(a, b, c)
            let v2 = Vector3(v1)

            Assert.Equal(v1.X, v2.X)
            Assert.Equal(v1.Y, v2.Y)
            Assert.Equal(v1.Z, v2.Z)

            Assert.Equal(a, v2.X)
            Assert.Equal(b, v2.Y)
            Assert.Equal(c, v2.Z)
            
        [<Property>]
        let ``Vector4 value constructor sets all components to the correct values`` (a, b, c, d) = 
            let v1 = Vector4(a, b, c, d)
            let v2 = Vector3(v1)

            Assert.Equal(v1.X, v2.X)
            Assert.Equal(v1.Y, v2.Y)
            Assert.Equal(v1.Z, v2.Z)

            Assert.Equal(a, v2.X)
            Assert.Equal(b, v2.Y)
            Assert.Equal(c, v2.Z)
            
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Indexing = 
        //
        [<Property>]
        let ``Index operator accesses the correct components`` (a, b, c) = 
            let v = Vector3(a, b, c)
            
            Assert.Equal(a, v.[0])
            Assert.Equal(b, v.[1])
            Assert.Equal(c, v.[2])
            
        [<Property>]
        let ``Index operator throws exception for negative indices`` (a, b, c) = 
            let mutable v = Vector3(a, b, c)
            
            let invalidIndexingAccess = fun() -> v.[-1] |> ignore
            let invalidIndexingAssignment = fun() -> v.[-1] <- a

            Assert.Throws<IndexOutOfRangeException>(invalidIndexingAccess) |> ignore
            Assert.Throws<IndexOutOfRangeException>(invalidIndexingAssignment) |> ignore
            
        [<Property>]
        let ``Index operator throws exception for large indices`` (a, b, c) = 
            let mutable v = Vector3(a, b, c)
            
            let invalidIndexingAccess = fun() -> v.[3] |> ignore
            let invalidIndexingAssignment = fun() -> v.[3] <- a

            Assert.Throws<IndexOutOfRangeException>(invalidIndexingAccess) |> ignore
            Assert.Throws<IndexOutOfRangeException>(invalidIndexingAssignment) |> ignore
            
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Length = 
        //
        [<Property>]
        let ``Length method works`` (a, b, c) = 
            let v = Vector3(a, b, c)
            let l = System.Math.Sqrt((float)(a * a + b * b + c * c))
            
            Assert.Equal((float32)l, v.Length)
            
        [<Property>]
        let ``Fast length method works`` (a, b, c) = 
            let v = Vector3(a, b, c)
            let l = 1.0f / MathHelper.InverseSqrtFast(a * a + b * b + c * c)
            
            Assert.Equal(l, v.LengthFast)
            
        [<Property>]
        let ``Length squared method works`` (a, b, c) = 
            let v = Vector3(a, b, c)
            let lsq = a * a + b * b + c * c
            
            Assert.Equal(lsq, v.LengthSquared)
            
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Normalization = 
        //
        [<Property>]
        let ``Normalization of instance, creating a new vector, works`` (a, b, c) = 
            let v = Vector3(a, b, c)
            let l = v.Length
            
            // Dividing by zero is not supported
            if not (approxEq l 0.0f) then
                let norm = v.Normalized()
    
                Assert.ApproximatelyEqual(v.X / l, norm.X)
                Assert.ApproximatelyEqual(v.Y / l, norm.Y)
                Assert.ApproximatelyEqual(v.Z / l, norm.Z)

        [<Property>]
        let ``Normalization of instance works`` (a, b, c) = 
            let v = Vector3(a, b, c)
            let l = v.Length
            
            if not (approxEq l 0.0f) then
                let norm = Vector3(a, b, c)
                norm.Normalize()
    
                
    
                Assert.ApproximatelyEqual(v.X / l, norm.X)
                Assert.ApproximatelyEqual(v.Y / l, norm.Y)
                Assert.ApproximatelyEqual(v.Z / l, norm.Z)

        [<Property>]
        let ``Fast approximate normalization of instance works`` (a, b, c) = 
            let v = Vector3(a, b, c)
            let norm = Vector3(a, b, c)
            norm.NormalizeFast()

            let scale = MathHelper.InverseSqrtFast(a * a + b * b + c * c)

            Assert.ApproximatelyEqual(v.X * scale, norm.X)
            Assert.ApproximatelyEqual(v.Y * scale, norm.Y)
            Assert.ApproximatelyEqual(v.Z * scale, norm.Z)
            
        [<Property>]
        let ``Normalization by reference works`` (a : Vector3) =
            if not (approxEq a.Length 0.0f) then
                let scale = 1.0f / a.Length
                let norm = Vector3(a.X * scale, a.Y * scale, a.Z * scale)
                let vRes = Vector3.Normalize(ref a)
                
                Assert.ApproximatelyEqual(norm, vRes)
            
        [<Property>]
        let ``Normalization works`` (a : Vector3) =
            if not (approxEq a.Length 0.0f) then
                let scale = 1.0f / a.Length
                let norm = Vector3(a.X * scale, a.Y * scale, a.Z * scale)
                
                Assert.ApproximatelyEqual(norm, Vector3.Normalize(a));
            
        [<Property>]
        let ``Fast approximate normalization by reference works`` (a : Vector3) =
            let scale = MathHelper.InverseSqrtFast(a.X * a.X + a.Y * a.Y)
            
            let norm = Vector3(a.X * scale, a.Y * scale, a.Z * scale)
            let vRes = Vector3.NormalizeFast(ref a)
            
            Assert.ApproximatelyEqual(norm, vRes)
            
        [<Property>]
        let ``Fast approximate normalization works`` (a : Vector3) =
            let scale = MathHelper.InverseSqrtFast(a.X * a.X + a.Y * a.Y)
            
            let norm = Vector3(a.X * scale, a.Y * scale, a.Z * scale)
            
            Assert.ApproximatelyEqual(norm, Vector3.NormalizeFast(a));

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Addition = 
        //
        [<Property>]
        let ``Vector3 addition is the same as component addition`` (a : Vector3, b : Vector3) = 
            let c = a + b
            
            Assert.ApproximatelyEqual(a.X + b.X,c.X)
            Assert.ApproximatelyEqual(a.Y + b.Y,c.Y)
        
        [<Property>]
        let ``Vector3 addition is commutative`` (a : Vector3, b : Vector3) = 
            let c = a + b
            let c2 = b + a
            
            Assert.ApproximatelyEqual(c, c2)
        
        [<Property>]
        let ``Vector3 addition is associative`` (a : Vector3, b : Vector3, c : Vector3) = 
            let r1 = (a + b) + c
            let r2 = a + (b + c)
            
            Assert.ApproximatelyEqual(r1, r2)
            
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Subtraction = 
        //
        [<Property>]
        let ``Vector3 subtraction is the same as component subtraction`` (a : Vector3, b : Vector3) = 
            let c = a - b
            
            Assert.Equal(a.X - b.X,c.X)
            Assert.Equal(a.Y - b.Y,c.Y)
            Assert.Equal(a.Z - b.Z,c.Z)
            
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Multiplication = 
        //
        [<Property>]
        let ``Vector3 multiplication is the same as component multiplication`` (a : Vector3, b : Vector3) = 
            let c = a * b
            
            Assert.Equal(a.X * b.X,c.X)
            Assert.Equal(a.Y * b.Y,c.Y)
            Assert.Equal(a.Z * b.Z,c.Z)
        
        [<Property>]
        let ``Vector3 multiplication is commutative`` (a : Vector3, b : Vector3) = 
            let r1 = a * b
            let r2 = b * a
            
            Assert.Equal(r1, r2)
        
        [<Property>]
        let ``Vector3-float multiplication is the same as component-float multiplication`` (a : Vector3, f : float32) = 
            let r = a * f
            
            Assert.Equal(a.X * f,r.X)
            Assert.Equal(a.Y * f,r.Y)
            Assert.Equal(a.Z * f,r.Z)
            
            // Inverse direction
            let r = f * a
            Assert.Equal(a.X * f,r.X)
            Assert.Equal(a.Y * f,r.Y)
            Assert.Equal(a.Z * f,r.Z)
        
        [<Property>]
        let ``Vector3-Matrix3 multiplication works`` (a : Matrix3, b : Vector3) = 
            let res = a*b
            
            let c1 = b.X * a.M11 + b.Y * a.M12 + b.Z * a.M13
            let c2 = b.X * a.M21 + b.Y * a.M22 + b.Z * a.M23
            let c3 = b.X * a.M31 + b.Y * a.M32 + b.Z * a.M33
            
            let exp = Vector3(c1, c2, c3)
            
            Assert.Equal(exp, res)
                    
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Division = 
        //
        [<Property>]
        let ``Vector3-float division is the same as component-float division`` (a : Vector3, f : float32) = 
            if not (approxEq f 0.0f) then // we don't support diving by zero.
                let r = a / f
                
                Assert.ApproximatelyEqual(a.X / f,r.X)
                Assert.ApproximatelyEqual(a.Y / f,r.Y)
                Assert.ApproximatelyEqual(a.Z / f,r.Z)
                
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Negation =
        //
        [<Property>]
        let ``Vector negation operator works`` (x, y, z) =
            let v = Vector3(x, y, z)
            let vNeg = -v
            Assert.Equal(-x, vNeg.X)
            Assert.Equal(-y, vNeg.Y)
            Assert.Equal(-z, vNeg.Z)
            
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Equality =
        //
        [<Property>]
        let ``Vector equality operator works`` (x, y, z) =
            let v1 = Vector3(x, y, z)
            let v2 = Vector3(x, y, z)
            let equality = v1 = v2
            
            Assert.True(equality)
            
        [<Property>]
        let ``Vector inequality operator works`` (x, y, z) =
            let v1 = Vector3(x, y, z)
            let v2 = Vector3(x + (float32)1 , y + (float32)1, z + (float32)1)
            let inequality = v1 <> v2
            
            Assert.True(inequality)
            
        [<Property>]
        let ``Vector equality method works`` (x, y, z) =
            let v1 = Vector3(x, y, z)
            let v2 = Vector3(x, y, z)
            let notVector = Matrix2()
            
            let equality = v1.Equals(v2)
            let inequalityByOtherType = v1.Equals(notVector)
            
            Assert.True(equality)
            Assert.False(inequalityByOtherType)
            
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Swizzling =
        //
        [<Property>]
        let ``Vector swizzling works`` (x, y, z) =
            let v = Vector3(x, y, z)
        
            let xyz = Vector3(x, y, z)
            let xzy = Vector3(x, z, y)
            let xy = Vector2(x, y)
            let xz = Vector2(x, z)
            
            let yxz = Vector3(y, x, z)
            let yzx = Vector3(y, z, x)
            let yx = Vector2(y, x)
            let yz = Vector2(y, z)
            
            let zxy = Vector3(z, x, y)
            let zyx = Vector3(z, y, x)
            let zx = Vector2(z, x)
            let zy = Vector2(z, y)
            
            Assert.Equal(xyz, v);
            Assert.Equal(xzy, v.Xzy);
            Assert.Equal(xy, v.Xy);
            Assert.Equal(xz, v.Xz);
            
            Assert.Equal(yxz, v.Yxz);
            Assert.Equal(yzx, v.Yzx);
            Assert.Equal(yx, v.Yx);
            Assert.Equal(yz, v.Yz);
            
            Assert.Equal(zxy, v.Zxy);
            Assert.Equal(zyx, v.Zyx);
            Assert.Equal(zx, v.Zx);
            Assert.Equal(zy, v.Zy);
            
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Interpolation =
        //
        [<Property>]
        let ``Linear interpolation works`` (a : Vector3, b : Vector3, q) =

            let blend = q
            
            let rX = blend * (b.X - a.X) + a.X 
            let rY = blend * (b.Y - a.Y) + a.Y
            let rZ = blend * (b.Z - a.Z) + a.Z
            let vExp = Vector3(rX, rY, rZ)
            
            Assert.Equal(vExp, Vector3.Lerp(a, b, q))
            
            let vRes = Vector3.Lerp(ref a, ref b, q)
            Assert.Equal(vExp, vRes)
            
        [<Property>]
        let ``Barycentric interpolation works`` (a : Vector3, b : Vector3, c : Vector3, u, v) =

            let r = a + u * (b - a) + v * (c - a)
            
            Assert.Equal(r, Vector3.BaryCentric(a, b, c, u, v))
            
            let vRes = Vector3.BaryCentric(ref a, ref b, ref c, u, v)
            Assert.Equal(r, vRes)
            
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module ``Vector products`` =
        //
        [<Property>]
        let ``Dot product works`` (a : Vector3, b : Vector3) =
            let dot = a.X * b.X + a.Y * b.Y + a.Z * b.Z
            
            Assert.Equal(dot, Vector3.Dot(a, b));
            
            let vRes = Vector3.Dot(ref a, ref b)
            Assert.Equal(dot, vRes)
            
        [<Property>]
        let ``Cross product works`` (a : Vector3, b : Vector3) =
            let crossX = a.Y * b.Z - a.Z * b.Y
            let crossY = a.Z * b.X - a.X * b.Z
            let crossZ = a.X * b.Y - a.Y * b.X
            let cross = Vector3(crossX, crossY, crossZ)
            
            Assert.Equal(cross, Vector3.Cross(a, b));
            
            let vRes = Vector3.Cross(ref a, ref b)
            Assert.Equal(cross, vRes)
            
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module ``Component min and max`` =
        //
        [<Property>]
        let ``Producing a new vector from the smallest components of given vectors works`` (x, y, z, u, w, q) =
            let v1 = Vector3(x, y, z)
            let v2 = Vector3(u, w, q)
            
            let vMin = Vector3.ComponentMin(v1, v2)
            
            Assert.True(vMin.X <= v1.X)
            Assert.True(vMin.X <= v2.X)
            
            Assert.True(vMin.Y <= v1.Y)
            Assert.True(vMin.Y <= v2.Y)
            
            Assert.True(vMin.Z <= v1.Z)
            Assert.True(vMin.Z <= v2.Z)
            
        [<Property>]
        let ``Producing a new vector from the largest components of given vectors works`` (x, y, z, u, w, q) =
            let v1 = Vector3(x, y, z)
            let v2 = Vector3(u, w, q)
            
            let vMax = Vector3.ComponentMax(v1, v2)
            
            Assert.True(vMax.X >= v1.X)
            Assert.True(vMax.X >= v2.X)
            
            Assert.True(vMax.Y >= v1.Y)
            Assert.True(vMax.Y >= v2.Y)
            
            Assert.True(vMax.Z >= v1.Z)
            Assert.True(vMax.Z >= v2.Z)
            
        [<Property>]
        let ``Producing a new vector from the smallest components of given vectors by reference works`` (x, y, z, u, w, q) =
            let v1 = Vector3(x, y, z)
            let v2 = Vector3(u, w, q)
            
            let vMin = Vector3.ComponentMin(ref v1, ref v2)
            
            Assert.True(vMin.X <= v1.X)
            Assert.True(vMin.X <= v2.X)
            
            Assert.True(vMin.Y <= v1.Y)
            Assert.True(vMin.Y <= v2.Y)
            
            Assert.True(vMin.Z <= v1.Z)
            Assert.True(vMin.Z <= v2.Z)
            
        [<Property>]
        let ``Producing a new vector from the largest components of given vectors by reference works`` (x, y, z, u, w, q) =
            let v1 = Vector3(x, y, z)
            let v2 = Vector3(u, w, q)
            
            let vMax = Vector3.ComponentMax(ref v1, ref v2)
            
            Assert.True(vMax.X >= v1.X)
            Assert.True(vMax.X >= v2.X)
            
            Assert.True(vMax.Y >= v1.Y)
            Assert.True(vMax.Y >= v2.Y)
            
            Assert.True(vMax.Z >= v1.Z)
            Assert.True(vMax.Z >= v2.Z)
            
        [<Property>]
        let ``Selecting the lesser of two vectors works`` (x, y, z, u, w, q) =
            let v1 = Vector3(x, y, z)
            let v2 = Vector3(u, w, q)
            
            let l1 = v1.LengthSquared
            let l2 = v2.LengthSquared
            
            let vMin = Vector3.Min(v1, v2)
            
            if l1 < l2 then
                let equalsFirst = vMin = v1 
                Assert.True(equalsFirst)
            else 
                let equalsLast = vMin = v2 
                Assert.True(equalsLast) 
            
        [<Property>]
        let ``Selecting the greater of two vectors works`` (x, y, z, u, w, q) =
            let v1 = Vector3(x, y, z)
            let v2 = Vector3(u, w, q)
            
            let l1 = v1.LengthSquared
            let l2 = v2.LengthSquared
            
            let vMin = Vector3.Max(v1, v2)
            
            if l1 >= l2 then
                let equalsFirst = vMin = v1 
                Assert.True(equalsFirst)
            else 
                let equalsLast = vMin = v2 
                Assert.True(equalsLast) 
                
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Clamping =
        //
        [<Property>]
        let ``Clamping one vector between two other vectors works`` (a : Vector3, b : Vector3, w : Vector3) =
            let res = Vector3.Clamp(w, a, b)
            
            let expX = if w.X < a.X then a.X else if w.X > b.X then b.X else w.X
            let expY = if w.Y < a.Y then a.Y else if w.Y > b.Y then b.Y else w.Y
            let expZ = if w.Z < a.Z then a.Z else if w.Z > b.Z then b.Z else w.Z
            
            Assert.Equal(expX, res.X)
            Assert.Equal(expY, res.Y)
            Assert.Equal(expZ, res.Z)
            
        [<Property>]
        let ``Clamping one vector between two other vectors works by reference`` (a : Vector3, b : Vector3, w : Vector3) =
            let res = Vector3.Clamp(ref w, ref a, ref b)
            
            let expX = if w.X < a.X then a.X else if w.X > b.X then b.X else w.X
            let expY = if w.Y < a.Y then a.Y else if w.Y > b.Y then b.Y else w.Y
            let expZ = if w.Z < a.Z then a.Z else if w.Z > b.Z then b.Z else w.Z
            
            Assert.Equal(expX, res.X)
            Assert.Equal(expY, res.Y)
            Assert.Equal(expZ, res.Z)