namespace OpenTK.Tests

open Xunit
open FsCheck
open FsCheck.Xunit
open System
open System.Runtime.InteropServices
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

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Clamping =
        //
        [<Property>]
        let ``Clamping one vector between two other vectors clamps all components between corresponding components`` (a : Vector2, b : Vector2, w : Vector2) =
            let res = Vector2.Clamp(w, a, b)

            let expX = if w.X < a.X then a.X else if w.X > b.X then b.X else w.X
            let expY = if w.Y < a.Y then a.Y else if w.Y > b.Y then b.Y else w.Y

            Assert.Equal(expX, res.X)
            Assert.Equal(expY, res.Y)

        [<Property>]
        let ``Clamping one vector between two other vectors by reference clamps all components`` (a : Vector2, b : Vector2, w : Vector2) =
            let res = Vector2.Clamp(ref w, ref a, ref b)

            let expX = if w.X < a.X then a.X else if w.X > b.X then b.X else w.X
            let expY = if w.Y < a.Y then a.Y else if w.Y > b.Y then b.Y else w.Y

            Assert.Equal(expX, res.X)
            Assert.Equal(expY, res.Y)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Length =
        //
        [<Property>]
        let ``Length is always >= 0`` (a : Vector2) =
            //
            Assert.True(a.Length >= 0.0f)

        [<Property>]
        let ``Length follows the pythagorean theorem`` (a, b) =
            let v = Vector2(a, b)
            let l = System.Math.Sqrt((float)(a * a + b * b))

            Assert.Equal((float32)l, v.Length)

        [<Property>]
        let ``Fast length method works`` (a, b) =
            let v = Vector2(a, b)
            let l = 1.0f / MathHelper.InverseSqrtFast(a * a + b * b)

            Assert.Equal(l, v.LengthFast)

        [<Property>]
        let ``Length squared method works`` (a, b) =
            let v = Vector2(a, b)
            let lsq = a * a + b * b

            Assert.Equal(lsq, v.LengthSquared)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module ``Unit vectors and perpendicularity`` =
        //
        [<Property>]
        let ``Perpendicular vector to the right is correct`` (a, b) =
            let v = Vector2(a, b)
            let perp = Vector2(b, -a)

            Assert.Equal(perp, v.PerpendicularRight)

        [<Property>]
        let ``Perpendicular vector to the left is correct`` (a, b) =
            let v = Vector2(a, b)
            let perp = Vector2(-b, a)

            Assert.Equal(perp, v.PerpendicularLeft)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Indexing =
        //
        [<Property>]
        let ``Index operator accesses the correct components`` (x, y) =
            let v = Vector2(x, y)

            Assert.Equal(x, v.[0])
            Assert.Equal(y, v.[1])

        [<Property>]
        let ``Indexed set operator throws exception for negative indices`` (x, y) =
            let mutable v = Vector2(x, y)

            (fun() -> v.[-1] <- x) |> Assert.Throws<IndexOutOfRangeException> |> ignore

        [<Property>]
        let ``Indexed get operator throws exception for negative indices`` (x, y) =
            let mutable v = Vector2(x, y)

            (fun() -> v.[-1] |> ignore) |> Assert.Throws<IndexOutOfRangeException> |> ignore

        [<Property>]
        let ``Indexed set operator throws exception for large indices`` (x, y) =
            let mutable v = Vector2(x, y)

            (fun() -> v.[2] <- x) |> Assert.Throws<IndexOutOfRangeException> |> ignore

        [<Property>]
        let ``Indexed get operator throws exception for large indices`` (x, y) =
            let mutable v = Vector2(x, y)

            (fun() -> v.[2] |> ignore) |> Assert.Throws<IndexOutOfRangeException> |> ignore

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

        [<Property>]
        let ``Static Vector2 addition method is the same as component addition`` (a : Vector2, b : Vector2) =

            let v1 = Vector2(a.X + b.X, a.Y + b.Y)
            let sum = Vector2.Add(a, b)

            Assert.ApproximatelyEqual(v1, sum)

        [<Property>]
        let ``Static Vector2 addition method by reference is the same as component addition`` (a : Vector2, b : Vector2) =

            let v1 = Vector2(a.X + b.X, a.Y + b.Y)
            let sum = Vector2.Add(ref a, ref b)

            Assert.ApproximatelyEqual(v1, sum)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Multiplication =
        //
        [<Property>]
        let ``Vector2 multiplication is the same as component multiplication`` (a : Vector2, b : Vector2) =
            let c = a * b
            Assert.Equal(a.X * b.X,c.X)
            Assert.Equal(a.Y * b.Y,c.Y)

        [<Property>]
        let ``Vector2 multiplication is commutative`` (a : Vector2, b : Vector2) =
            let r1 = a * b
            let r2 = b * a
            Assert.Equal(r1,r2)

        [<Property>]
        let ``Left-handed Vector2-scalar multiplication is the same as component-scalar multiplication`` (a : Vector2, f : float32) =
            let r = a * f

            Assert.Equal(a.X * f,r.X)
            Assert.Equal(a.Y * f,r.Y)

        [<Property>]
        let ``Right-handed Vector2-scalar multiplication is the same as component-scalar multiplication`` (a : Vector2, f : float32) =
            let r = f * a
            Assert.Equal(a.X * f,r.X)
            Assert.Equal(a.Y * f,r.Y)

        [<Property>]
        let ``Static Vector2 multiplication method is the same as component multiplication`` (a : Vector2, b : Vector2) =

            let v1 = Vector2(a.X * b.X, a.Y * b.Y)
            let sum = Vector2.Multiply(a, b)

            Assert.ApproximatelyEqual(v1, sum)

        [<Property>]
        let ``Static Vector2 multiplication method by reference is the same as component multiplication`` (a : Vector2, b : Vector2) =

            let v1 = Vector2(a.X * b.X, a.Y * b.Y)
            let sum = Vector2.Multiply(ref a, ref b)

            Assert.ApproximatelyEqual(v1, sum)

        [<Property>]
        let ``Static method Vector2-scalar multiplication is the same as component-scalar multiplication`` (a : Vector2, f : float32) =
            let r = Vector2.Multiply(a, f)

            Assert.Equal(a.X * f,r.X)
            Assert.Equal(a.Y * f,r.Y)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Subtraction =
        //
        [<Property>]
        let ``Vector2 subtraction is the same as component subtraction`` (a : Vector2, b : Vector2) =
            let c = a - b
            Assert.Equal(a.X - b.X,c.X)
            Assert.Equal(a.Y - b.Y,c.Y)

        [<Property>]
        let ``Static Vector2 subtraction method is the same as component addition`` (a : Vector2, b : Vector2) =

            let v1 = Vector2(a.X - b.X, a.Y - b.Y)
            let sum = Vector2.Subtract(a, b)

            Assert.ApproximatelyEqual(v1, sum)

        [<Property>]
        let ``Static Vector2 subtraction method by reference is the same as component addition`` (a : Vector2, b : Vector2) =

            let v1 = Vector2(a.X - b.X, a.Y - b.Y)
            let sum = Vector2.Subtract(ref a, ref b)

            Assert.ApproximatelyEqual(v1, sum)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Division =
        //
        [<Property>]
        let ``Vector2-float division is the same as component-float division`` (a : Vector2, f : float32) =
            let r = a / f

            Assert.ApproximatelyEqual(a.X / f,r.X)
            Assert.ApproximatelyEqual(a.Y / f,r.Y)

        [<Property>]
        let ``Static Vector2-Vector2 division method is the same as component division`` (a : Vector2, b : Vector2) =

            let v1 = Vector2(a.X / b.X, a.Y / b.Y)
            let sum = Vector2.Divide(a, b)

            Assert.ApproximatelyEqual(v1, sum)

        [<Property>]
        let ``Static Vector2-Vector2 divison method by reference `` (a : Vector2, b : Vector2) =

            let v1 = Vector2(a.X / b.X, a.Y / b.Y)
            let sum = Vector2.Divide(ref a, ref b)

            Assert.ApproximatelyEqual(v1, sum)

        [<Property>]
        let ``Static Vector2-scalar division method is the same as component division`` (a : Vector2, b : float32) =

            let v1 = Vector2(a.X / b, a.Y / b)
            let sum = Vector2.Divide(a, b)

            Assert.ApproximatelyEqual(v1, sum)

        [<Property>]
        let ``Static Vector2-scalar divison method by reference is the same as component division`` (a : Vector2, b : float32) =

            let v1 = Vector2(a.X / b, a.Y / b)
            let sum = Vector2.Divide(ref a, b)

            Assert.ApproximatelyEqual(v1, sum)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Negation =
        //
        [<Property>]
        let ``Vector negation operator negates all components`` (x, y) =
            let v = Vector2(x, y)
            let vNeg = -v
            Assert.Equal(-x, vNeg.X)
            Assert.Equal(-y, vNeg.Y)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Equality =
        //
        [<Property>]
        let ``Vector equality operator is by component`` (x, y) =
            let v1 = Vector2(x, y)
            let v2 = Vector2(x, y)
            let equality = v1 = v2

            Assert.True(equality)

        [<Property>]
        let ``Vector inequality operator is by component`` (x, y) =
            let v1 = Vector2(x, y)
            let v2 = Vector2(x + 1.0f , y + 1.0f)
            let inequality = v1 <> v2

            Assert.True(inequality)

        [<Property>]
        let ``Vector equality method is by component`` (x, y) =
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
        let ``Vector swizzling returns the correct composites`` (x, y) =
            let v1 = Vector2(x, y)
            let v2 = Vector2(y, x)

            let v1yx = v1.Yx;
            Assert.Equal(v2, v1yx);

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Interpolation =
        //
        [<Property>]
        let ``Linear interpolation is by component`` (a : Vector2, b : Vector2, q) =

            let blend = q

            let rX = blend * (b.X - a.X) + a.X
            let rY = blend * (b.Y - a.Y) + a.Y
            let vExp = Vector2(rX, rY)

            Assert.Equal(vExp, Vector2.Lerp(a, b, q))

            let vRes = Vector2.Lerp(ref a, ref b, q)
            Assert.Equal(vExp, vRes)

        [<Property>]
        let ``Barycentric interpolation follows the barycentric formula`` (a : Vector2, b : Vector2, c : Vector2, u, v) =

            let r = a + u * (b - a) + v * (c - a)

            Assert.Equal(r, Vector2.BaryCentric(a, b, c, u, v))

            let vRes = Vector2.BaryCentric(ref a, ref b, ref c, u, v)
            Assert.Equal(r, vRes)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module ``Vector products`` =
        //
        [<Property>]
        let ``Dot product follows the dot product formula`` (a : Vector2, b : Vector2) =
            let dot = a.X * b.X + a.Y * b.Y

            Assert.Equal(dot, Vector2.Dot(a, b));

            let vRes = Vector2.Dot(ref a, ref b)
            Assert.Equal(dot, vRes)

        [<Property>]
        let ``Perpendicular dot product follows the perpendicular dot product formula`` (a : Vector2, b : Vector2) =
            let perpDot = a.X * b.Y - a.Y * b.X

            Assert.Equal(perpDot, Vector2.PerpDot(a, b));

            let vRes = Vector2.PerpDot(ref a, ref b)
            Assert.Equal(perpDot, vRes)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Normalization =
        //
        [<Property>]
        let ``Normalization creates a new unit length vector with the correct components`` (a, b) =
            let v = Vector2(a, b)
            let l = v.Length

            // Dividing by zero is not supported
            if not (approxEq l 0.0f) then
                let norm = v.Normalized()

                Assert.ApproximatelyEqual(v.X / l, norm.X)
                Assert.ApproximatelyEqual(v.Y / l, norm.Y)

        [<Property>]
        let ``Normalization of instance transforms the instance into a unit length vector with the correct components`` (a, b) =
            let v = Vector2(a, b)
            let l = v.Length

            if not (approxEq l 0.0f) then
                let norm = Vector2(a, b)
                norm.Normalize()

                Assert.ApproximatelyEqual(v.X / l, norm.X)
                Assert.ApproximatelyEqual(v.Y / l, norm.Y)

        [<Property>]
        let ``Fast approximate normalization of instance transforms the instance into a unit length vector with the correct components`` (a, b) =
            let v = Vector2(a, b)
            let norm = Vector2(a, b)
            norm.NormalizeFast()

            let scale = MathHelper.InverseSqrtFast(a * a + b * b)

            Assert.ApproximatelyEqual(v.X * scale, norm.X)
            Assert.ApproximatelyEqual(v.Y * scale, norm.Y)

        [<Property>]
        let ``Normalization by reference is the same as division by magnitude`` (a : Vector2) =
            let norm = a / a.Length
            let vRes = Vector2.Normalize(ref a)

            Assert.ApproximatelyEqual(norm, vRes)

        [<Property>]
        let ``Normalization is the same as division by magnitude`` (a : Vector2) =
            let norm = a / a.Length

            Assert.ApproximatelyEqual(norm, Vector2.Normalize(a));

        [<Property>]
        let ``Fast approximate normalization by reference is the same as multiplication by the fast inverse square`` (a : Vector2) =
            let scale = MathHelper.InverseSqrtFast(a.X * a.X + a.Y * a.Y)

            let norm = a * scale
            let vRes = Vector2.NormalizeFast(ref a)

            Assert.ApproximatelyEqual(norm, vRes)

        [<Property>]
        let ``Fast approximate normalization is the same as multiplication by the fast inverse square`` (a : Vector2) =
            let scale = MathHelper.InverseSqrtFast(a.X * a.X + a.Y * a.Y)

            let norm = a * scale

            Assert.ApproximatelyEqual(norm, Vector2.NormalizeFast(a));

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module ``Component min and max`` =
        //
        [<Property>]
        let ``ComponentMin produces a new vector from the smallest components of the given vectors`` (x, y, u, w) =
            let v1 = Vector2(x, y)
            let v2 = Vector2(u, w)

            let vMin = Vector2.ComponentMin(v1, v2)

            Assert.True(vMin.X <= v1.X)
            Assert.True(vMin.X <= v2.X)

            Assert.True(vMin.Y <= v1.Y)
            Assert.True(vMin.Y <= v2.Y)

        [<Property>]
        let ``ComponentMax produces a new vector from the largest components of the given vectors`` (x, y, u, w) =
            let v1 = Vector2(x, y)
            let v2 = Vector2(u, w)

            let vMax = Vector2.ComponentMax(v1, v2)

            Assert.True(vMax.X >= v1.X)
            Assert.True(vMax.X >= v2.X)

            Assert.True(vMax.Y >= v1.Y)
            Assert.True(vMax.Y >= v2.Y)

        [<Property>]
        let ``ComponentMin by reference produces a new vector from the smallest components of the given vectors`` (x, y, u, w) =
            let v1 = Vector2(x, y)
            let v2 = Vector2(u, w)

            let vMin = Vector2.ComponentMin(ref v1, ref v2)

            Assert.True(vMin.X <= v1.X)
            Assert.True(vMin.X <= v2.X)

            Assert.True(vMin.Y <= v1.Y)
            Assert.True(vMin.Y <= v2.Y)

        [<Property>]
        let ``ComponentMax by reference produces a new vector from the largest components of the given vectors`` (x, y, u, w) =
            let v1 = Vector2(x, y)
            let v2 = Vector2(u, w)

            let vMax = Vector2.ComponentMax(ref v1, ref v2)

            Assert.True(vMax.X >= v1.X)
            Assert.True(vMax.X >= v2.X)

            Assert.True(vMax.Y >= v1.Y)
            Assert.True(vMax.Y >= v2.Y)

        [<Property>]
        let ``Min selects the vector with lesser magnitude given two vectors`` (x, y, u, w) =
            let v1 = Vector2(x, y)
            let v2 = Vector2(u, w)

            let l1 = v1.LengthSquared
            let l2 = v2.LengthSquared

            let vMin = Vector2.Min(v1, v2)

            if l1 < l2 then
                let equalsFirst = vMin = v1
                Assert.True(equalsFirst)
            else
                let equalsLast = vMin = v2
                Assert.True(equalsLast)

        [<Property>]
        let ``Max selects the vector with greater magnitude given two vectors`` (x, y, u, w) =
            let v1 = Vector2(x, y)
            let v2 = Vector2(u, w)

            let l1 = v1.LengthSquared
            let l2 = v2.LengthSquared

            let vMin = Vector2.Max(v1, v2)

            if l1 >= l2 then
                let equalsFirst = vMin = v1
                Assert.True(equalsFirst)
            else
                let equalsLast = vMin = v2
                Assert.True(equalsLast)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Transformation =
        //
        [<Property>]
        let ``Transformation by quaternion is the same as multiplication by quaternion and its conjugate`` (v : Vector2, q : Quaternion) =
            let vectorQuat = Quaternion(v.X, v.Y, 0.0f, 0.0f)
            let inverse = Quaternion.Invert(q)

            let transformedQuat = q * vectorQuat * inverse
            let transformedVector = Vector2(transformedQuat.X, transformedQuat.Y)

            Assert.Equal(transformedVector, Vector2.Transform(v, q))

        [<Property>]
        let ``Transformation by quaternion by reference is the same as multiplication by quaternion and its conjugate`` (v : Vector2, q : Quaternion) =
            let vectorQuat = Quaternion(v.X, v.Y, 0.0f, 0.0f)
            let inverse = Quaternion.Invert(q)

            let transformedQuat = q * vectorQuat * inverse
            let transformedVector = Vector2(transformedQuat.X, transformedQuat.Y)

            Assert.Equal(transformedVector, Vector2.Transform(ref v, ref q))

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Serialization =
        //
        [<Property>]
        let ``The absolute size of a Vector2 is always the size of its components`` (v : Vector2) =
            let expectedSize = sizeof<float32> * 2

            Assert.Equal(expectedSize, Vector2.SizeInBytes)
            Assert.Equal(expectedSize, Marshal.SizeOf(Vector2()))