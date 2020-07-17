namespace OpenToolkit.Tests

open Xunit
open FsCheck
open FsCheck.Xunit
open System
open System.Runtime.InteropServices
open OpenToolkit
open OpenToolkit.Mathematics

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
            let res = Vector2.Clamp(&w, &a, &b)

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
    module Distance =
        [<Property>]
        let ``Distance(a, b) = (b - a).Length`` (a : Vector2, b : Vector2) =
            Assert.ApproximatelyEqual(Vector2.Distance(a, b), (b - a).Length)

        [<Property>]
        let ``DistanceSquared(a, b) = (b - a).LengthSquared`` (a : Vector2, b : Vector2) =
            Assert.ApproximatelyEqual(Vector2.DistanceSquared(a, b), (b - a).LengthSquared)

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

            (fun() -> v.[-1] <- x) |> Assert.ThrowsIndexExn

        [<Property>]
        let ``Indexed get operator throws exception for negative indices`` (x, y) =
            let mutable v = Vector2(x, y)

            (fun() -> v.[-1] |> ignore) |> Assert.ThrowsIndexExn

        [<Property>]
        let ``Indexed set operator throws exception for large indices`` (x, y) =
            let mutable v = Vector2(x, y)

            (fun() -> v.[2] <- x) |> Assert.ThrowsIndexExn

        [<Property>]
        let ``Indexed get operator throws exception for large indices`` (x, y) =
            let mutable v = Vector2(x, y)

            (fun() -> v.[2] |> ignore) |> Assert.ThrowsIndexExn

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
            Assert.ApproximatelyEquivalent(a.X + b.X,c.X)
            Assert.ApproximatelyEquivalent(a.Y + b.Y,c.Y)

        [<Property>]
        let ``Vector addition is commutative`` (a : Vector2,b : Vector2) =
            let c = a + b
            let c2 = b + a
            Assert.ApproximatelyEquivalent(c,c2)

        [<Property>]
        let ``Vector addition is associative`` (a : Vector2,b : Vector2,c : Vector2) =
            let r1 = (a + b) + c
            let r2 = a + (b + c)
            Assert.ApproximatelyEquivalent(r1,r2)

        [<Property>]
        let ``Static Vector2 addition method is the same as component addition`` (a : Vector2, b : Vector2) =

            let v1 = Vector2(a.X + b.X, a.Y + b.Y)
            let sum = Vector2.Add(a, b)

            Assert.ApproximatelyEquivalent(v1, sum)

        [<Property>]
        let ``Static Vector2 addition method by reference is the same as component addition`` (a : Vector2, b : Vector2) =

            let v1 = Vector2(a.X + b.X, a.Y + b.Y)
            let sum = Vector2.Add(&a, &b)

            Assert.ApproximatelyEquivalent(v1, sum)

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
        let ``Vector2-Matrix2 multiplication using right-handed notation is the same as vector/row multiplication and summation`` (a : Matrix2, b : Vector2) =
            let res = a * b

            let c1 = b.X * a.M11 + b.Y * a.M12
            let c2 = b.X * a.M21 + b.Y * a.M22

            let exp = Vector2(c1, c2)

            Assert.Equal(exp, res)

        [<Property>]
        let ``Vector2-Matrix2 multiplication using right-handed notation is consistent across overloads`` (a : Matrix2, b : Vector2) =
            let r1 = a * b;
            let r2 = Vector2.TransformColumn(a, b);
            let r3 = Vector2.TransformColumn(&a, &b);

            Assert.Equal(r1, r2)
            Assert.Equal(r2, r3)

        [<Property>]
        let ``Vector2-Matrix2 multiplication using left-handed notation is the same as vector/column multiplication and summation`` (a : Matrix2, b : Vector2) =
            let res = b * a

            let c1 = b.X * a.M11 + b.Y * a.M21
            let c2 = b.X * a.M12 + b.Y * a.M22

            let exp = Vector2(c1, c2)

            Assert.Equal(exp, res)

        [<Property>]
        let ``Vector2-Matrix2 multiplication using left-handed notation is consistent across overloads`` (a : Matrix2, b : Vector2) =
            let r1 = b * a;
            let r2 = Vector2.TransformRow(b, a);
            let r3 = Vector2.TransformRow(&b, &a);

            Assert.Equal(r1, r2)
            Assert.Equal(r2, r3)

        [<Property>]
        let ``Static Vector2 multiplication method is the same as component multiplication`` (a : Vector2, b : Vector2) =

            let v1 = Vector2(a.X * b.X, a.Y * b.Y)
            let sum = Vector2.Multiply(a, b)

            Assert.ApproximatelyEquivalent(v1, sum)

        [<Property>]
        let ``Static Vector2 multiplication method by reference is the same as component multiplication`` (a : Vector2, b : Vector2) =

            let v1 = Vector2(a.X * b.X, a.Y * b.Y)
            let sum = Vector2.Multiply(&a, &b)

            Assert.ApproximatelyEquivalent(v1, sum)

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

            Assert.ApproximatelyEquivalent(v1, sum)

        [<Property>]
        let ``Static Vector2 subtraction method by reference is the same as component addition`` (a : Vector2, b : Vector2) =

            let v1 = Vector2(a.X - b.X, a.Y - b.Y)
            let sum = Vector2.Subtract(&a, &b)

            Assert.ApproximatelyEquivalent(v1, sum)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Division =
        //
        [<Property>]
        let ``Vector2-float division is the same as component-float division`` (a : Vector2, f : float32) =
            if not (approxEq f 0.0f) then
                let r = a / f

                Assert.ApproximatelyEquivalent(a.X / f,r.X)
                Assert.ApproximatelyEquivalent(a.Y / f,r.Y)

        [<Property>]
        let ``Static Vector2-Vector2 division method is the same as component division`` (a : Vector2, b : Vector2) =
            if not (anyZero2 a || anyZero2 b) then
                let v1 = Vector2(a.X / b.X, a.Y / b.Y)
                let sum = Vector2.Divide(a, b)

                Assert.ApproximatelyEquivalent(v1, sum)

        [<Property>]
        let ``Static Vector2-Vector2 divison method by reference `` (a : Vector2, b : Vector2) =
            if not (anyZero2 a || anyZero2 b) then
                let v1 = Vector2(a.X / b.X, a.Y / b.Y)
                let sum = Vector2.Divide(&a, &b)

                Assert.ApproximatelyEquivalent(v1, sum)

        [<Property>]
        let ``Static Vector2-scalar division method is the same as component division`` (a : Vector2, b : float32) =
            if not (approxEq b 0.0f) then
                let v1 = Vector2(a.X / b, a.Y / b)
                let sum = Vector2.Divide(a, b)

                Assert.ApproximatelyEquivalent(v1, sum)

        [<Property>]
        let ``Static Vector2-scalar divison method by reference is the same as component division`` (a : Vector2, b : float32) =
            if not (approxEq b 0.0f) then
                let v1 = Vector2(a.X / b, a.Y / b)
                let sum = Vector2.Divide(&a, b)

                Assert.ApproximatelyEquivalent(v1, sum)

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

            let vRes = Vector2.Lerp(&a, &b, q)
            Assert.Equal(vExp, vRes)

        [<Property>]
        let ``Barycentric interpolation follows the barycentric formula`` (a : Vector2, b : Vector2, c : Vector2, u, v) =

            let r = a + u * (b - a) + v * (c - a)

            Assert.Equal(r, Vector2.BaryCentric(a, b, c, u, v))

            let vRes = Vector2.BaryCentric(&a, &b, &c, u, v)
            Assert.Equal(r, vRes)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module ``Vector products`` =
        //
        [<Property>]
        let ``Dot product follows the dot product formula`` (a : Vector2, b : Vector2) =
            let dot = a.X * b.X + a.Y * b.Y

            Assert.Equal(dot, Vector2.Dot(a, b));

            let vRes = Vector2.Dot(&a, &b)
            Assert.Equal(dot, vRes)

        [<Property>]
        let ``Perpendicular dot product follows the perpendicular dot product formula`` (a : Vector2, b : Vector2) =
            let perpDot = a.X * b.Y - a.Y * b.X

            Assert.Equal(perpDot, Vector2.PerpDot(a, b));

            let vRes = Vector2.PerpDot(&a, &b)
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

                Assert.ApproximatelyEquivalent(v.X / l, norm.X)
                Assert.ApproximatelyEquivalent(v.Y / l, norm.Y)

        [<Property>]
        let ``Normalization of instance transforms the instance into a unit length vector with the correct components`` (a, b) =
            let v = Vector2(a, b)
            let l = v.Length

            if not (approxEq l 0.0f) then
                let norm = Vector2(a, b)
                norm.Normalize()

                Assert.ApproximatelyEquivalent(v.X / l, norm.X)
                Assert.ApproximatelyEquivalent(v.Y / l, norm.Y)

        [<Property>]
        let ``Fast approximate normalization of instance transforms the instance into a unit length vector with the correct components`` (a, b) =
            let v = Vector2(a, b)
            let norm = Vector2(a, b)
            norm.NormalizeFast()

            let scale = MathHelper.InverseSqrtFast(a * a + b * b)

            Assert.ApproximatelyEquivalent(v.X * scale, norm.X)
            Assert.ApproximatelyEquivalent(v.Y * scale, norm.Y)

        [<Property>]
        let ``Normalization by reference is the same as division by magnitude`` (a : Vector2) =
            // Zero-length vectors can't be normalized
            if not (approxEq a.Length 0.0f) then
                let norm = a / a.Length
                let vRes = Vector2.Normalize(&a)

                Assert.ApproximatelyEquivalent(norm, vRes)

        [<Property>]
        let ``Normalization is the same as division by magnitude`` (a : Vector2) =
            // Zero-length vectors can't be normalized
            if not (approxEq a.Length 0.0f) then
                let norm = a / a.Length

                Assert.ApproximatelyEquivalent(norm, Vector2.Normalize(a));

        [<Property>]
        let ``Fast approximate normalization by reference is the same as multiplication by the fast inverse square`` (a : Vector2) =
            let scale = MathHelper.InverseSqrtFast(a.X * a.X + a.Y * a.Y)

            let norm = a * scale
            let vRes = Vector2.NormalizeFast(&a)

            Assert.ApproximatelyEquivalent(norm, vRes)

        [<Property>]
        let ``Fast approximate normalization is the same as multiplication by the fast inverse square`` (a : Vector2) =
            let scale = MathHelper.InverseSqrtFast(a.X * a.X + a.Y * a.Y)

            let norm = a * scale

            Assert.ApproximatelyEquivalent(norm, Vector2.NormalizeFast(a));

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module ``Magnitude min and max`` =
        //
        [<Property>]
        let ``MagnitudeMin selects the vector with equal or lesser magnitude given two vectors`` (v1 : Vector2, v2: Vector2) =
            // Results do not matter for equal vectors
            if not (v1 = v2) then
                let l1 = v1.LengthSquared
                let l2 = v2.LengthSquared

                let vMin = Vector2.MagnitudeMin(v1, v2)

                if vMin = v1 then
                    let v1ShorterThanv2 = l1 < l2
                    Assert.True(v1ShorterThanv2)
                else
                    let v2ShorterThanOrEqualTov1 = l2 <= l1
                    Assert.True(v2ShorterThanOrEqualTov1)

        [<Property>]
        let ``MagnitudeMax selects the vector with equal or greater magnitude given two vectors`` (v1 : Vector2, v2: Vector2) =
            // Results do not matter for equal vectors
            if not (v1 = v2) then
                let l1 = v1.LengthSquared
                let l2 = v2.LengthSquared

                let vMin = Vector2.MagnitudeMax(v1, v2)

                if vMin = v1 then
                    let v1LongerThanOrEqualTov2 = l1 >= l2
                    Assert.True(v1LongerThanOrEqualTov2)
                else
                    let v2LongerThanv1 = l2 > l1
                    Assert.True(v2LongerThanv1)

        [<Property>]
        let ``MagnitudeMin by reference selects the vector with equal or lesser magnitude given two vectors`` (v1 : Vector2, v2: Vector2) =
            // Results do not matter for equal vectors
            if not (v1 = v2) then
                let l1 = v1.LengthSquared
                let l2 = v2.LengthSquared

                let vMin = Vector2.MagnitudeMin(&v1, &v2)

                if vMin = v1 then
                    let v1ShorterThanv2 = l1 < l2
                    Assert.True(v1ShorterThanv2)
                else
                    let v2ShorterThanOrEqualTov1 = l2 <= l1
                    Assert.True(v2ShorterThanOrEqualTov1)

        [<Property>]
        let ``MagnitudeMax by reference selects the vector with equal greater magnitude given two vectors`` (v1 : Vector2, v2: Vector2) =
            // Results do not matter for equal vectors
            if not (v1 = v2) then
                let l1 = v1.LengthSquared
                let l2 = v2.LengthSquared

                let vMin = Vector2.MagnitudeMax(&v1, &v2)

                if vMin = v1 then
                    let v1LongerThanOrEqualTov2 = l1 >= l2
                    Assert.True(v1LongerThanOrEqualTov2)
                else
                    let v2LongerThanv1 = l2 > l1
                    Assert.True(v2LongerThanv1)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module ``Component min and max`` =
        //
        [<Property>]
        let ``ComponentMin creates a new vector from the smallest components of given vectors`` (v1 : Vector2, v2: Vector2) =
            let vMin = Vector2.ComponentMin(v1, v2)
            let isComponentSmallest smallComp comp1 comp2 = smallComp <= comp1 && smallComp <= comp2

            Assert.True(isComponentSmallest vMin.X v1.X v2.X)
            Assert.True(isComponentSmallest vMin.Y v1.Y v2.Y)

        [<Property>]
        let ``ComponentMax creates a new vector from the greatest components of given vectors`` (v1 : Vector2, v2: Vector2) =
            let vMax = Vector2.ComponentMax(v1, v2)
            let isComponentLargest largeComp comp1 comp2 = largeComp >= comp1 && largeComp >= comp2

            Assert.True(isComponentLargest vMax.X v1.X v2.X)
            Assert.True(isComponentLargest vMax.Y v1.Y v2.Y)

        [<Property>]
        let ``ComponentMin by reference creates a new vector from the smallest components of given vectors`` (v1 : Vector2, v2: Vector2) =
            let vMin = Vector2.ComponentMin(&v1, &v2)
            let isComponentSmallest smallComp comp1 comp2 = smallComp <= comp1 && smallComp <= comp2

            Assert.True(isComponentSmallest vMin.X v1.X v2.X)
            Assert.True(isComponentSmallest vMin.Y v1.Y v2.Y)

        [<Property>]
        let ``ComponentMax by reference creates a new vector from the greatest components of given vectors`` (v1 : Vector2, v2: Vector2) =
            let vMax = Vector2.ComponentMax(&v1, &v2)
            let isComponentLargest largeComp comp1 comp2 = largeComp >= comp1 && largeComp >= comp2

            Assert.True(isComponentLargest vMax.X v1.X v2.X)
            Assert.True(isComponentLargest vMax.Y v1.Y v2.Y)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Transformation =
        //
        [<Property>]
        let ``Transformation by quaternion is the same as multiplication by quaternion and its conjugate`` (v : Vector2, q : Quaternion) =
            let vectorQuat = Quaternion(v.X, v.Y, 0.0f, 0.0f)
            let inverse = Quaternion.Invert(q)

            let transformedQuat = q * vectorQuat * inverse
            let transformedVector = Vector2(transformedQuat.X, transformedQuat.Y)

            Assert.ApproximatelyEquivalent(transformedVector, Vector2.Transform(v, q))

        [<Property>]
        let ``Transformation by quaternion by reference is the same as multiplication by quaternion and its conjugate`` (v : Vector2, q : Quaternion) =
            let vectorQuat = Quaternion(v.X, v.Y, 0.0f, 0.0f)
            let inverse = Quaternion.Invert(q)

            let transformedQuat = q * vectorQuat * inverse
            let transformedVector = Vector2(transformedQuat.X, transformedQuat.Y)

            Assert.ApproximatelyEquivalent(transformedVector, Vector2.Transform(&v, &q))

        [<Property>]
        let ``Transformation by quaternion by multiplication using right-handed notation is the same as multiplication by quaternion and its conjugate`` (v : Vector2, q : Quaternion) =
            let vectorQuat = Quaternion(v.X, v.Y, 0.0f, 0.0f)
            let inverse = Quaternion.Invert(q)

            let transformedQuat = q * vectorQuat * inverse
            let transformedVector = Vector2(transformedQuat.X, transformedQuat.Y)

            Assert.ApproximatelyEquivalent(transformedVector, q * v)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Serialization =
        //
        [<Property>]
        let ``The absolute size of a Vector2 is always the size of its components`` (v : Vector2) =
            let expectedSize = sizeof<float32> * 2

            Assert.Equal(expectedSize, Vector2.SizeInBytes)
            Assert.Equal(expectedSize, Marshal.SizeOf(Vector2()))
