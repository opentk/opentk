namespace OpenToolkit.Tests

open Xunit
open FsCheck
open FsCheck.Xunit
open System
open System.Runtime.InteropServices
open OpenToolkit
open OpenToolkit.Mathematics

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
            Assert.Equal(0.0f, v2.Z)

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
        let ``Index operator accesses the correct components`` (x, y, z) =
            let v = Vector3(x, y, z)

            Assert.Equal(x, v.[0])
            Assert.Equal(y, v.[1])
            Assert.Equal(z, v.[2])

        [<Property>]
        let ``Indexed set operator throws exception for negative indices`` (x, y, z) =
            let mutable v = Vector3(x, y, z)

            (fun() -> v.[-1] <- x) |> Assert.ThrowsIndexExn

        [<Property>]
        let ``Indexed get operator throws exception for negative indices`` (x, y, z) =
            let mutable v = Vector3(x, y, z)

            (fun() -> v.[-1] |> ignore) |> Assert.ThrowsIndexExn

        [<Property>]
        let ``Indexed set operator throws exception for large indices`` (x, y, z) =
            let mutable v = Vector3(x, y, z)

            (fun() -> v.[4] <- x) |> Assert.ThrowsIndexExn

        [<Property>]
        let ``Indexed get operator throws exception for large indices`` (x, y, z) =
            let mutable v = Vector3(x, y, z)

            (fun() -> v.[4] |> ignore) |> Assert.ThrowsIndexExn

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Length =
        //
        [<Property>]
        let ``Length method follows the pythagorean theorem`` (a, b, c) =
            let v = Vector3(a, b, c)
            let l = System.Math.Sqrt((float)(a * a + b * b + c * c))

            Assert.Equal((float32)l, v.Length)

        [<Property>]
        let ``Fast length method is the same as one divided by the fast inverse square`` (a, b, c) =
            let v = Vector3(a, b, c)
            let l = 1.0f / MathHelper.InverseSqrtFast(a * a + b * b + c * c)

            Assert.Equal(l, v.LengthFast)

        [<Property>]
        let ``Length squared method returns each component squared and summed`` (a, b, c) =
            let v = Vector3(a, b, c)
            let lsq = a * a + b * b + c * c

            Assert.Equal(lsq, v.LengthSquared)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Distance =
        [<Property>]
        let ``Distance(a, b) = (b - a).Length`` (a : Vector3, b : Vector3) =
            Assert.ApproximatelyEqual(Vector3.Distance(a, b), (b - a).Length)

        [<Property>]
        let ``DistanceSquared(a, b) = (b - a).LengthSquared`` (a : Vector3, b : Vector3) =
            Assert.ApproximatelyEqual(Vector3.DistanceSquared(a, b), (b - a).LengthSquared)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Normalization =
        //
        [<Property>]
        let ``Normalization creates a new unit length vector with the correct components`` (a, b, c) =
            let v = Vector3(a, b, c)
            let l = v.Length

            // Dividing by zero is not supported
            if not (approxEq l 0.0f) then
                let norm = v.Normalized()

                Assert.ApproximatelyEquivalent(v.X / l, norm.X)
                Assert.ApproximatelyEquivalent(v.Y / l, norm.Y)
                Assert.ApproximatelyEquivalent(v.Z / l, norm.Z)

        [<Property>]
        let ``Normalization of instance transforms the instance into a unit length vector with the correct components`` (a, b, c) =
            let v = Vector3(a, b, c)
            let l = v.Length

            if not (approxEq l 0.0f) then
                let norm = Vector3(a, b, c)
                norm.Normalize()

                Assert.ApproximatelyEquivalent(v.X / l, norm.X)
                Assert.ApproximatelyEquivalent(v.Y / l, norm.Y)
                Assert.ApproximatelyEquivalent(v.Z / l, norm.Z)

        [<Property>]
        let ``Fast approximate normalization of instance transforms the instance into a unit length vector with the correct components`` (a, b, c) =
            let v = Vector3(a, b, c)
            let norm = Vector3(a, b, c)
            norm.NormalizeFast()

            let scale = MathHelper.InverseSqrtFast(a * a + b * b + c * c)

            Assert.ApproximatelyEquivalent(v.X * scale, norm.X)
            Assert.ApproximatelyEquivalent(v.Y * scale, norm.Y)
            Assert.ApproximatelyEquivalent(v.Z * scale, norm.Z)

        [<Property>]
        let ``Normalization by reference is the same as division by magnitude`` (a : Vector3) =
            // Zero-length vectors can't be normalized
            if not (approxEq a.Length 0.0f) then
                let norm = a / a.Length
                let vRes = Vector3.Normalize(&a)

                Assert.ApproximatelyEquivalent(norm, vRes)

        [<Property>]
        let ``Normalization is the same as division by magnitude`` (a : Vector3) =
            // Zero-length vectors can't be normalized
            if not (approxEq a.Length 0.0f) then
                let norm = a / a.Length

                Assert.ApproximatelyEquivalent(norm, Vector3.Normalize(a));

        [<Property>]
        let ``Fast approximate normalization by reference is the same as multiplication by the fast inverse square`` (a : Vector3) =
            let scale = MathHelper.InverseSqrtFast(a.X * a.X + a.Y * a.Y + a.Z * a.Z)

            let norm = a * scale
            let vRes = Vector3.NormalizeFast(&a)

            Assert.ApproximatelyEquivalent(norm, vRes)

        [<Property>]
        let ``Fast approximate normalization is the same as multiplication by fast inverse square`` (a : Vector3) =
            let scale = MathHelper.InverseSqrtFast(a.X * a.X + a.Y * a.Y + a.Z * a.Z)

            let norm = a * scale

            Assert.ApproximatelyEquivalent(norm, Vector3.NormalizeFast(a));

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Addition =
        //
        [<Property>]
        let ``Vector3 addition is the same as component addition`` (a : Vector3, b : Vector3) =
            let c = a + b

            Assert.ApproximatelyEquivalent(a.X + b.X,c.X)
            Assert.ApproximatelyEquivalent(a.Y + b.Y,c.Y)
            Assert.ApproximatelyEquivalent(a.Z + b.Z,c.Z)

        [<Property>]
        let ``Vector3 addition is commutative`` (a : Vector3, b : Vector3) =
            let c = a + b
            let c2 = b + a

            Assert.ApproximatelyEquivalent(c, c2)

        [<Property>]
        let ``Vector3 addition is associative`` (a : Vector3, b : Vector3, c : Vector3) =
            let r1 = (a + b) + c
            let r2 = a + (b + c)

            Assert.ApproximatelyEquivalent(r1, r2)

        [<Property>]
        let ``Static Vector3 addition method is the same as component addition`` (a : Vector3, b : Vector3) =

            let v1 = Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z)
            let sum = Vector3.Add(a, b)

            Assert.ApproximatelyEquivalent(v1, sum)

        [<Property>]
        let ``Static Vector3 addition method by reference is the same as component addition`` (a : Vector3, b : Vector3) =

            let v1 = Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z)
            let sum = Vector3.Add(&a, &b)

            Assert.ApproximatelyEquivalent(v1, sum)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Subtraction =
        //
        [<Property>]
        let ``Vector3 subtraction is the same as component subtraction`` (a : Vector3, b : Vector3) =
            let c = a - b

            Assert.Equal(a.X - b.X,c.X)
            Assert.Equal(a.Y - b.Y,c.Y)
            Assert.Equal(a.Z - b.Z,c.Z)

        [<Property>]
        let ``Static Vector3 subtraction method is the same as component addition`` (a : Vector3, b : Vector3) =

            let v1 = Vector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z)
            let sum = Vector3.Subtract(a, b)

            Assert.ApproximatelyEquivalent(v1, sum)

        [<Property>]
        let ``Static Vector3 subtraction method by reference is the same as component addition`` (a : Vector3, b : Vector3) =

            let v1 = Vector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z)
            let sum = Vector3.Subtract(&a, &b)

            Assert.ApproximatelyEquivalent(v1, sum)

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
        let ``Left-handed Vector3-scalar multiplication is the same as component-scalar multiplication`` (a : Vector3, f : float32) =
            let r = a * f

            Assert.Equal(a.X * f,r.X)
            Assert.Equal(a.Y * f,r.Y)
            Assert.Equal(a.Z * f,r.Z)

        [<Property>]
        let ``Right-handed Vector3-scalar multiplication is the same as component-scalar multiplication`` (a : Vector3, f : float32) =
            let r = f * a
            Assert.Equal(a.X * f,r.X)
            Assert.Equal(a.Y * f,r.Y)
            Assert.Equal(a.Z * f,r.Z)

        [<Property>]
        let ``Static method Vector3-scalar multiplication is the same as component-scalar multiplication`` (a : Vector3, f : float32) =
            let r = Vector3.Multiply(a, f)

            Assert.Equal(a.X * f,r.X)
            Assert.Equal(a.Y * f,r.Y)
            Assert.Equal(a.Z * f,r.Z)

        [<Property>]
        let ``Vector3-Matrix3 multiplication using right-handed notation is the same as vector/row multiplication and summation`` (a : Matrix3, b : Vector3) =
            let res = a*b

            let c1 = b.X * a.M11 + b.Y * a.M12 + b.Z * a.M13
            let c2 = b.X * a.M21 + b.Y * a.M22 + b.Z * a.M23
            let c3 = b.X * a.M31 + b.Y * a.M32 + b.Z * a.M33

            let exp = Vector3(c1, c2, c3)

            Assert.Equal(exp, res)

        [<Property>]
        let ``Vector3-Matrix3 multiplication using right-handed notation is consistent across overloads`` (a : Matrix3, b : Vector3) =
            let r1 = a * b;
            let r2 = Vector3.TransformColumn(a, b);
            let r3 = Vector3.TransformColumn(&a, &b);

            Assert.Equal(r1, r2)
            Assert.Equal(r2, r3)

        [<Property>]
        let ``Vector3-Matrix3 multiplication using left-handed notation is the same as vector/column multiplication and summation`` (a : Matrix3, b : Vector3) =
            let res = b*a

            let c1 = b.X * a.M11 + b.Y * a.M21 + b.Z * a.M31
            let c2 = b.X * a.M12 + b.Y * a.M22 + b.Z * a.M32
            let c3 = b.X * a.M13 + b.Y * a.M23 + b.Z * a.M33

            let exp = Vector3(c1, c2, c3)

            Assert.Equal(exp, res)

        [<Property>]
        let ``Vector3-Matrix3 multiplication using left-handed notation is consistent across overloads`` (a : Matrix3, b : Vector3) =
            let r1 = b * a;
            let r2 = Vector3.TransformRow(b, a);
            let r3 = Vector3.TransformRow(&b, &a);

            Assert.Equal(r1, r2)
            Assert.Equal(r2, r3)

        [<Property>]
        let ``Static Vector3 multiplication method is the same as component multiplication`` (a : Vector3, b : Vector3) =

            let v1 = Vector3(a.X * b.X, a.Y * b.Y, a.Z * b.Z)
            let sum = Vector3.Multiply(a, b)

            Assert.ApproximatelyEquivalent(v1, sum)

        [<Property>]
        let ``Static Vector3 multiplication method by reference is the same as component multiplication`` (a : Vector3, b : Vector3) =

            let v1 = Vector3(a.X * b.X, a.Y * b.Y, a.Z * b.Z)
            let sum = Vector3.Multiply(&a, &b)

            Assert.ApproximatelyEquivalent(v1, sum)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Division =
        //
        [<Property>]
        let ``Vector3-float division is the same as component-float division`` (a : Vector3, f : float32) =
            if not (approxEq f 0.0f) then // we don't support diving by zero.
                let r = a / f

                Assert.ApproximatelyEquivalent(a.X / f,r.X)
                Assert.ApproximatelyEquivalent(a.Y / f,r.Y)
                Assert.ApproximatelyEquivalent(a.Z / f,r.Z)

        [<Property>]
        let ``Static Vector3-Vector3 division method is the same as component division`` (a : Vector3, b : Vector3) =
            if not (anyZero3 a || anyZero3 b) then
                let v1 = Vector3(a.X / b.X, a.Y / b.Y, a.Z / b.Z)
                let sum = Vector3.Divide(a, b)

                Assert.ApproximatelyEquivalent(v1, sum)

        [<Property>]
        let ``Static Vector3-Vector3 divison method by reference is the same as component division`` (a : Vector3, b : Vector3) =
            if not (anyZero3 a || anyZero3 b) then
                let v1 = Vector3(a.X / b.X, a.Y / b.Y, a.Z / b.Z)
                let sum = Vector3.Divide(&a, &b)

                Assert.ApproximatelyEquivalent(v1, sum)

        [<Property>]
        let ``Static Vector3-scalar division method is the same as component division`` (a : Vector3, b : float32) =
            if not (approxEq b 0.0f) then // we don't support diving by zero.
                let v1 = Vector3(a.X / b, a.Y / b, a.Z / b)
                let sum = Vector3.Divide(a, b)

                Assert.ApproximatelyEquivalent(v1, sum)

        [<Property>]
        let ``Static Vector3-scalar divison method by reference is the same as component division`` (a : Vector3, b : float32) =
            if not (approxEq b 0.0f) then // we don't support diving by zero.
                let v1 = Vector3(a.X / b, a.Y / b, a.Z / b)
                let sum = Vector3.Divide(&a, b)

                Assert.ApproximatelyEquivalent(v1, sum)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Negation =
        //
        [<Property>]
        let ``Vector negation operator negates all components`` (x, y, z) =
            let v = Vector3(x, y, z)
            let vNeg = -v
            Assert.Equal(-x, vNeg.X)
            Assert.Equal(-y, vNeg.Y)
            Assert.Equal(-z, vNeg.Z)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Equality =
        //
        [<Property>]
        let ``Vector equality operator is by component`` (x, y, z) =
            let v1 = Vector3(x, y, z)
            let v2 = Vector3(x, y, z)
            let equality = v1 = v2

            Assert.True(equality)

        [<Property>]
        let ``Vector inequality operator is by component`` (x, y, z) =
            let v1 = Vector3(x, y, z)
            let v2 = Vector3(x + 1.0f , y + 1.0f, z + 1.0f)
            let inequality = v1 <> v2

            Assert.True(inequality)

        [<Property>]
        let ``Vector equality method is by component`` (x, y, z) =
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
        let ``Vector swizzling returns the correct composite for X-primary components`` (x, y, z) =
            let v = Vector3(x, y, z)

            let xyz = Vector3(x, y, z)
            let xzy = Vector3(x, z, y)
            let xy = Vector2(x, y)
            let xz = Vector2(x, z)

            Assert.Equal(xyz, v);
            Assert.Equal(xzy, v.Xzy);
            Assert.Equal(xy, v.Xy);
            Assert.Equal(xz, v.Xz);

        [<Property>]
        let ``Vector swizzling returns the correct composite for Y-primary components`` (x, y, z) =
            let v = Vector3(x, y, z)

            let yxz = Vector3(y, x, z)
            let yzx = Vector3(y, z, x)
            let yx = Vector2(y, x)
            let yz = Vector2(y, z)

            Assert.Equal(yxz, v.Yxz);
            Assert.Equal(yzx, v.Yzx);
            Assert.Equal(yx, v.Yx);
            Assert.Equal(yz, v.Yz);

        [<Property>]
        let ``Vector swizzling returns the correct composite for Z-primary components`` (x, y, z) =
            let v = Vector3(x, y, z)

            let zxy = Vector3(z, x, y)
            let zyx = Vector3(z, y, x)
            let zx = Vector2(z, x)
            let zy = Vector2(z, y);

            Assert.Equal(zxy, v.Zxy);
            Assert.Equal(zyx, v.Zyx);
            Assert.Equal(zx, v.Zx);
            Assert.Equal(zy, v.Zy);

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Interpolation =
        //
        [<Property>]
        let ``Linear interpolation is by component`` (a : Vector3, b : Vector3, q) =

            let blend = q

            let rX = blend * (b.X - a.X) + a.X
            let rY = blend * (b.Y - a.Y) + a.Y
            let rZ = blend * (b.Z - a.Z) + a.Z
            let vExp = Vector3(rX, rY, rZ)

            Assert.Equal(vExp, Vector3.Lerp(a, b, q))

            let vRes = Vector3.Lerp(&a, &b, q)
            Assert.Equal(vExp, vRes)

        [<Property>]
        let ``Barycentric interpolation follows the barycentric formula`` (a : Vector3, b : Vector3, c : Vector3, u, v) =

            let r = a + u * (b - a) + v * (c - a)

            Assert.Equal(r, Vector3.BaryCentric(a, b, c, u, v))

            let vRes = Vector3.BaryCentric(&a, &b, &c, u, v)
            Assert.Equal(r, vRes)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module ``Vector products`` =
        //
        [<Property>]
        let ``Dot product follows the dot product formula`` (a : Vector3, b : Vector3) =
            let dot = a.X * b.X + a.Y * b.Y + a.Z * b.Z

            Assert.Equal(dot, Vector3.Dot(a, b));

            let vRes = Vector3.Dot(&a, &b)
            Assert.Equal(dot, vRes)

        [<Property>]
        let ``Cross product follows the cross product formula`` (a : Vector3, b : Vector3) =
            let crossX = a.Y * b.Z - a.Z * b.Y
            let crossY = a.Z * b.X - a.X * b.Z
            let crossZ = a.X * b.Y - a.Y * b.X
            let cross = Vector3(crossX, crossY, crossZ)

            Assert.Equal(cross, Vector3.Cross(a, b));

            let vRes = Vector3.Cross(&a, &b)
            Assert.Equal(cross, vRes)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module ``Magnitude min and max`` =
        //
        [<Property>]
        let ``MagnitudeMin selects the vector with equal or lesser magnitude given two vectors`` (v1 : Vector3, v2: Vector3) =
            // Results do not matter for equal vectors
            if not (v1 = v2) then
                let l1 = v1.LengthSquared
                let l2 = v2.LengthSquared

                let vMin = Vector3.MagnitudeMin(v1, v2)

                if vMin = v1 then
                    let v1ShorterThanv2 = l1 < l2
                    Assert.True(v1ShorterThanv2)
                else
                    let v2ShorterThanOrEqualTov1 = l2 <= l1
                    Assert.True(v2ShorterThanOrEqualTov1)

        [<Property>]
        let ``MagnitudeMax selects the vector with equal or greater magnitude given two vectors`` (v1 : Vector3, v2: Vector3) =
            // Results do not matter for equal vectors
            if not (v1 = v2) then
                let l1 = v1.LengthSquared
                let l2 = v2.LengthSquared

                let vMin = Vector3.MagnitudeMax(v1, v2)

                if vMin = v1 then
                    let v1LongerThanOrEqualTov2 = l1 >= l2
                    Assert.True(v1LongerThanOrEqualTov2)
                else
                    let v2LongerThanv1 = l2 > l1
                    Assert.True(v2LongerThanv1)

        [<Property>]
        let ``MagnitudeMin by reference selects the vector with equal or lesser magnitude given two vectors`` (v1 : Vector3, v2: Vector3) =
            // Results do not matter for equal vectors
            if not (v1 = v2) then
                let l1 = v1.LengthSquared
                let l2 = v2.LengthSquared

                let vMin = Vector3.MagnitudeMin(&v1, &v2)

                if vMin = v1 then
                    let v1ShorterThanv2 = l1 < l2
                    Assert.True(v1ShorterThanv2)
                else
                    let v2ShorterThanOrEqualTov1 = l2 <= l1
                    Assert.True(v2ShorterThanOrEqualTov1)

        [<Property>]
        let ``MagnitudeMax by reference selects the vector with equal or greater magnitude given two vectors`` (v1 : Vector3, v2: Vector3) =
            // Results do not matter for equal vectors
            if not (v1 = v2) then
                let l1 = v1.LengthSquared
                let l2 = v2.LengthSquared

                let vMin = Vector3.MagnitudeMax(&v1, &v2)

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
        let ``ComponentMin creates a new vector from the smallest components of given vectors`` (v1 : Vector3, v2: Vector3) =
            let vMin = Vector3.ComponentMin(v1, v2)
            let isComponentSmallest smallComp comp1 comp2 = smallComp <= comp1 && smallComp <= comp2

            Assert.True(isComponentSmallest vMin.X v1.X v2.X)
            Assert.True(isComponentSmallest vMin.Y v1.Y v2.Y)
            Assert.True(isComponentSmallest vMin.Z v1.Z v2.Z)

        [<Property>]
        let ``ComponentMax creates a new vector from the greatest components of given vectors`` (v1 : Vector3, v2: Vector3) =
            let vMax = Vector3.ComponentMax(v1, v2)
            let isComponentLargest largeComp comp1 comp2 = largeComp >= comp1 && largeComp >= comp2

            Assert.True(isComponentLargest vMax.X v1.X v2.X)
            Assert.True(isComponentLargest vMax.Y v1.Y v2.Y)
            Assert.True(isComponentLargest vMax.Z v1.Z v2.Z)

        [<Property>]
        let ``ComponentMin by reference creates a new vector from the smallest components of given vectors`` (v1 : Vector3, v2: Vector3) =
            let vMin = Vector3.ComponentMin(&v1, &v2)
            let isComponentSmallest smallComp comp1 comp2 = smallComp <= comp1 && smallComp <= comp2

            Assert.True(isComponentSmallest vMin.X v1.X v2.X)
            Assert.True(isComponentSmallest vMin.Y v1.Y v2.Y)
            Assert.True(isComponentSmallest vMin.Z v1.Z v2.Z)

        [<Property>]
        let ``ComponentMax by reference creates a new vector from the greatest components of given vectors`` (v1 : Vector3, v2: Vector3) =
            let vMax = Vector3.ComponentMax(&v1, &v2)
            let isComponentLargest largeComp comp1 comp2 = largeComp >= comp1 && largeComp >= comp2

            Assert.True(isComponentLargest vMax.X v1.X v2.X)
            Assert.True(isComponentLargest vMax.Y v1.Y v2.Y)
            Assert.True(isComponentLargest vMax.Z v1.Z v2.Z)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Clamping =
        //
        [<Property>]
        let ``Clamping one vector between two other vectors clamps all components between corresponding components`` (a : Vector3, b : Vector3, w : Vector3) =
            let res = Vector3.Clamp(w, a, b)

            let expX = if w.X < a.X then a.X else if w.X > b.X then b.X else w.X
            let expY = if w.Y < a.Y then a.Y else if w.Y > b.Y then b.Y else w.Y
            let expZ = if w.Z < a.Z then a.Z else if w.Z > b.Z then b.Z else w.Z

            Assert.Equal(expX, res.X)
            Assert.Equal(expY, res.Y)
            Assert.Equal(expZ, res.Z)

        [<Property>]
        let ``Clamping one vector between two other vectors by reference clamps all components between corresponding components`` (a : Vector3, b : Vector3, w : Vector3) =
            let res = Vector3.Clamp(&w, &a, &b)

            let expX = if w.X < a.X then a.X else if w.X > b.X then b.X else w.X
            let expY = if w.Y < a.Y then a.Y else if w.Y > b.Y then b.Y else w.Y
            let expZ = if w.Z < a.Z then a.Z else if w.Z > b.Z then b.Z else w.Z

            Assert.Equal(expX, res.X)
            Assert.Equal(expY, res.Y)
            Assert.Equal(expZ, res.Z)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module ``Unit vectors``=
        //
        [<Property>]
        let ``Unit X is correct``  =
            let unitX = Vector3(1.0f, 0.0f, 0.0f)

            Assert.Equal(Vector3.UnitX, unitX)

        [<Property>]
        let ``Unit Y is correct``  =
            let unitY = Vector3(0.0f, 1.0f, 0.0f)

            Assert.Equal(Vector3.UnitY, unitY)

        [<Property>]
        let ``Unit Z is correct``  =
            let unitZ = Vector3(0.0f, 0.0f, 1.0f)

            Assert.Equal(Vector3.UnitZ, unitZ)

        [<Property>]
        let ``Unit zero is correct``  =
            let unitZero = Vector3(0.0f, 0.0f, 0.0f)

            Assert.Equal(Vector3.Zero, unitZero)

        [<Property>]
        let ``Unit one is correct``  =
            let unitOne = Vector3(1.0f, 1.0f, 1.0f)

            Assert.Equal(Vector3.One, unitOne)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Serialization =
        //
        [<Property>]
        let ``The absolute size of a Vector3 is always the size of its components`` (v : Vector3) =
            let expectedSize = sizeof<float32> * 3

            Assert.Equal(expectedSize, Vector3.SizeInBytes)
            Assert.Equal(expectedSize, Marshal.SizeOf(Vector3()))

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Transformation =
        //
        [<Property>]
        let ``Transformation by quaternion is the same as multiplication by quaternion and its conjugate`` (v : Vector3, q : Quaternion) =
            let vectorQuat = Quaternion(v.X, v.Y, v.Z, 0.0f)
            let inverse = Quaternion.Invert(q)

            let transformedQuat = q * vectorQuat * inverse
            let transformedVector = transformedQuat.Xyz

            Assert.ApproximatelyEquivalent(transformedVector, Vector3.Transform(v, q))

        [<Property>]
        let ``Transformation by quaternion by reference is the same as multiplication by quaternion and its conjugate`` (v : Vector3, q : Quaternion) =
            let vectorQuat = Quaternion(v.X, v.Y, v.Z, 0.0f)
            let inverse = Quaternion.Invert(q)

            let transformedQuat = q * vectorQuat * inverse
            let transformedVector = transformedQuat.Xyz

            Assert.ApproximatelyEquivalent(transformedVector, Vector3.Transform(&v, &q))

        [<Property>]
        let ``Transformation by quaternion by multiplication using right-handed notation is the same as multiplication by quaternion and its conjugate`` (v : Vector3, q : Quaternion) =
            let vectorQuat = Quaternion(v.X, v.Y, v.Z, 0.0f)
            let inverse = Quaternion.Invert(q)

            let transformedQuat = q * vectorQuat * inverse
            let transformedVector = transformedQuat.Xyz

            Assert.ApproximatelyEquivalent(transformedVector, q * v)

        [<Property>]
        let ``Transformation by identity quaternion does not alter vector`` (v : Vector3) =
            let q = Quaternion.Identity
            let vectorQuat = Quaternion(v.X, v.Y, v.Z, 0.0f)
            let inverse = Quaternion.Invert(q)

            let transformedQuat = q * vectorQuat * inverse
            let transformedVector = transformedQuat.Xyz

            Assert.ApproximatelyEquivalent(v, transformedVector)
            Assert.ApproximatelyEquivalent(v, Vector3.Transform(v, q))
            Assert.ApproximatelyEquivalent(transformedVector, Vector3.Transform(v, q))
