namespace OpenToolkit.Tests

open Xunit
open FsCheck
open FsCheck.Xunit
open System
open System.Runtime.InteropServices
open OpenToolkit
open OpenToolkit.Mathematics

module Vector4 =
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Constructors =
        //
        [<Property>]
        let ``Triple value constructor sets all components to the correct values`` (x, y, z, w) =
            let v = Vector4(x, y, z, w)

            Assert.Equal(x, v.X)
            Assert.Equal(y, v.Y)
            Assert.Equal(z, v.Z)
            Assert.Equal(w, v.W)

        [<Property>]
        let ``Single value constructor sets all components to the correct values`` (a : float32) =
            let v = Vector4(a)

            Assert.Equal(a, v.X)
            Assert.Equal(a, v.Y)
            Assert.Equal(a, v.Z)
            Assert.Equal(a, v.W)

        [<Property>]
        let ``Vector2 value constructor sets all components to the correct values`` (x, y) =
            let v1 = Vector2(x, y)
            let v2 = Vector4(v1)

            Assert.Equal(v1.X, v2.X)
            Assert.Equal(v1.Y, v2.Y)

            Assert.Equal(x, v2.X)
            Assert.Equal(y, v2.Y)
            Assert.Equal(0.0f, v2.Z)
            Assert.Equal(0.0f, v2.W)

        [<Property>]
        let ``Vector3 value constructor sets all components to the correct values`` (x, y, z) =
            let v1 = Vector3(x, y, z)
            let v2 = Vector4(v1)

            Assert.Equal(v1.X, v2.X)
            Assert.Equal(v1.Y, v2.Y)
            Assert.Equal(v1.Z, v2.Z)

            Assert.Equal(x, v2.X)
            Assert.Equal(y, v2.Y)
            Assert.Equal(z, v2.Z)
            Assert.Equal(0.0f, v2.W)

        [<Property>]
        let ``Vector3 value and scalar constructor sets all components to the correct values`` (x, y, z, w) =
            let v1 = Vector3(x, y, z)
            let v2 = Vector4(v1, w)

            Assert.Equal(v1.X, v2.X)
            Assert.Equal(v1.Y, v2.Y)
            Assert.Equal(v1.Z, v2.Z)

            Assert.Equal(x, v2.X)
            Assert.Equal(y, v2.Y)
            Assert.Equal(z, v2.Z)
            Assert.Equal(w, v2.W)

        [<Property>]
        let ``Vector4 value constructor sets all components to the correct values`` (x, y, z, w) =
            let v1 = Vector4(x, y, z, w)
            let v2 = Vector4(v1)

            Assert.Equal(v1.X, v2.X)
            Assert.Equal(v1.Y, v2.Y)
            Assert.Equal(v1.Z, v2.Z)
            Assert.Equal(v1.W, v2.W)

            Assert.Equal(x, v2.X)
            Assert.Equal(y, v2.Y)
            Assert.Equal(z, v2.Z)
            Assert.Equal(w, v2.W)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Indexing =
        //
        [<Property>]
        let ``Index operator accesses the correct components`` (x, y, z, w) =
            let v = Vector4(x, y, z, w)

            Assert.Equal(x, v.[0])
            Assert.Equal(y, v.[1])
            Assert.Equal(z, v.[2])
            Assert.Equal(w, v.[3])

        [<Property>]
        let ``Indexed set operator throws exception for negative indices`` (x, y, z, w) =
            let mutable v = Vector4(x, y, z, w)

            (fun() -> v.[-1] <- x) |> Assert.ThrowsIndexExn

        [<Property>]
        let ``Indexed get operator throws exception for negative indices`` (x, y, z, w) =
            let mutable v = Vector4(x, y, z, w)

            (fun() -> v.[-1] |> ignore) |> Assert.ThrowsIndexExn

        [<Property>]
        let ``Indexed set operator throws exception for large indices`` (x, y, z, w) =
            let mutable v = Vector4(x, y, z, w)

            (fun() -> v.[4] <- x) |> Assert.ThrowsIndexExn

        [<Property>]
        let ``Indexed get operator throws exception for large indices`` (x, y, z, w) =
            let mutable v = Vector4(x, y, z, w)

            (fun() -> v.[4] |> ignore) |> Assert.ThrowsIndexExn

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Length =
        //
        [<Property>]
        let ``Length method follows the pythagorean theorem`` (x, y, z, w) =
            let v = Vector4(x, y, z, w)
            let l = System.Math.Sqrt((float)(x * x + y * y + z * z + w * w))

            Assert.Equal((float32)l, v.Length)

        [<Property>]
        let ``Fast length method is the same as one divided by the fast inverse square`` (x, y, z, w) =
            let v = Vector4(x, y, z, w)
            let l = 1.0f / MathHelper.InverseSqrtFast(x * x + y * y + z * z + w * w)

            Assert.Equal(l, v.LengthFast)

        [<Property>]
        let ``Length squared method returns each component squared and summed`` (x, y, z, w) =
            let v = Vector4(x, y, z, w)
            let lsq = x * x + y * y + z * z + w * w

            Assert.Equal(lsq, v.LengthSquared)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Normalization =
        //
        [<Property>]
        let ``Normalization creates a new unit length vector with the correct components`` (x, y, z, w) =
            let v = Vector4(x, y, z, w)
            let l = v.Length

            // Zero-length vectors can't be normalized
            if not (approxEq l 0.0f) then
                let norm = v.Normalized()

                Assert.ApproximatelyEquivalent(v.X / l, norm.X)
                Assert.ApproximatelyEquivalent(v.Y / l, norm.Y)
                Assert.ApproximatelyEquivalent(v.Z / l, norm.Z)
                Assert.ApproximatelyEquivalent(v.W / l, norm.W)

        [<Property>]
        let ``Normalization of instance transforms the instance into a unit length vector with the correct components`` (x, y, z, w) =
            let v = Vector4(x, y, z, w)
            let l = v.Length

            // Zero-length vectors can't be normalized
            if not (approxEq l 0.0f) then
                let norm = Vector4(x, y, z, w)
                norm.Normalize()

                Assert.ApproximatelyEquivalent(v.X / l, norm.X)
                Assert.ApproximatelyEquivalent(v.Y / l, norm.Y)
                Assert.ApproximatelyEquivalent(v.Z / l, norm.Z)
                Assert.ApproximatelyEquivalent(v.W / l, norm.W)

        [<Property>]
        let ``Fast approximate normalization of instance transforms the instance into a unit length vector with the correct components`` (x, y, z, w) =
            let v = Vector4(x, y, z, w)
            let norm = Vector4(x, y, z, w)
            norm.NormalizeFast()

            let scale = MathHelper.InverseSqrtFast(x * x + y * y + z * z + w * w)

            Assert.ApproximatelyEquivalent(v.X * scale, norm.X)
            Assert.ApproximatelyEquivalent(v.Y * scale, norm.Y)
            Assert.ApproximatelyEquivalent(v.Z * scale, norm.Z)
            Assert.ApproximatelyEquivalent(v.W * scale, norm.W)

        [<Property>]
        let ``Normalization by reference is the same as division by magnitude`` (a : Vector4) =
            // Zero-length vectors can't be normalized
            if not (approxEq a.Length 0.0f) then
                let norm = a / a.Length
                let vRes = Vector4.Normalize(&a)

                Assert.ApproximatelyEquivalent(norm, vRes)

        [<Property>]
        let ``Normalization is the same as division by magnitude`` (a : Vector4) =
            // Zero-length vectors can't be normalized
            if not (approxEq a.Length 0.0f) then
                let norm = a / a.Length

                Assert.ApproximatelyEquivalent(norm, Vector4.Normalize(a));

        [<Property>]
        let ``Fast approximate normalization by reference is the same as multiplication by the fast inverse square`` (a : Vector4) =
            let scale = MathHelper.InverseSqrtFast(a.X * a.X + a.Y * a.Y + a.Z * a.Z + a.W * a.W)

            let norm = a * scale
            let vRes = Vector4.NormalizeFast(&a)

            Assert.ApproximatelyEquivalent(norm, vRes)

        [<Property>]
        let ``Fast approximate normalization is the same as multiplication by the fast inverse square`` (a : Vector4) =
            let scale = MathHelper.InverseSqrtFast(a.X * a.X + a.Y * a.Y + a.Z * a.Z + a.W * a.W)
            let norm = a * scale

            Assert.ApproximatelyEquivalent(norm, Vector4.NormalizeFast(a));

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Addition =
        //
        [<Property>]
        let ``Vector4 addition is the same as component addition`` (a : Vector4, b : Vector4) =
            let c = a + b

            Assert.ApproximatelyEquivalent(a.X + b.X,c.X)
            Assert.ApproximatelyEquivalent(a.Y + b.Y,c.Y)
            Assert.ApproximatelyEquivalent(a.Z + b.Z,c.Z)
            Assert.ApproximatelyEquivalent(a.W + b.W,c.W)

        [<Property>]
        let ``Vector4 addition is commutative`` (a : Vector4, b : Vector4) =
            let c = a + b
            let c2 = b + a

            Assert.ApproximatelyEquivalent(c, c2)

        [<Property>]
        let ``Vector4 addition is associative`` (a : Vector4, b : Vector4, c : Vector4) =
            let r1 = (a + b) + c
            let r2 = a + (b + c)

            Assert.ApproximatelyEquivalent(r1, r2)

        [<Property>]
        let ``Static Vector4 addition method is the same as component addition`` (a : Vector4, b : Vector4) =

            let v1 = Vector4(a.X + b.X, a.Y + b.Y, a.Z + b.Z, a.W + b.W)
            let sum = Vector4.Add(a, b)

            Assert.ApproximatelyEquivalent(v1, sum)

        [<Property>]
        let ``Static Vector4 addition method by reference is the same as component addition`` (a : Vector4, b : Vector4) =

            let v1 = Vector4(a.X + b.X, a.Y + b.Y, a.Z + b.Z, a.W + b.W)
            let sum = Vector4.Add(&a, &b)

            Assert.ApproximatelyEquivalent(v1, sum)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Subtraction =
        //
        [<Property>]
        let ``Vector4 subtraction is the same as component subtraction`` (a : Vector4, b : Vector4) =
            let c = a - b

            Assert.Equal(a.X - b.X,c.X)
            Assert.Equal(a.Y - b.Y,c.Y)
            Assert.Equal(a.Z - b.Z,c.Z)
            Assert.Equal(a.W - b.W,c.W)

        [<Property>]
        let ``Static Vector4 subtraction method is the same as component addition`` (a : Vector4, b : Vector4) =

            let v1 = Vector4(a.X - b.X, a.Y - b.Y, a.Z - b.Z, a.W - b.W)
            let sum = Vector4.Subtract(a, b)

            Assert.ApproximatelyEquivalent(v1, sum)

        [<Property>]
        let ``Static Vector4 subtraction method by reference is the same as component addition`` (a : Vector4, b : Vector4) =

            let v1 = Vector4(a.X - b.X, a.Y - b.Y, a.Z - b.Z, a.W - b.W)
            let sum = Vector4.Subtract(&a, &b)

            Assert.ApproximatelyEquivalent(v1, sum)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Multiplication =
        //
        [<Property>]
        let ``Vector4 multiplication is the same as component multiplication`` (a : Vector4, b : Vector4) =
            let c = a * b

            Assert.Equal(a.X * b.X,c.X)
            Assert.Equal(a.Y * b.Y,c.Y)
            Assert.Equal(a.Z * b.Z,c.Z)
            Assert.Equal(a.W * b.W,c.W)


        [<Property>]
        let ``Vector4 multiplication is commutative`` (a : Vector4, b : Vector4) =
            let r1 = a * b
            let r2 = b * a

            Assert.Equal(r1, r2)

        [<Property>]
        let ``Left-handed Vector4-scalar multiplication is the same as component-scalar multiplication`` (a : Vector4, f : float32) =
            let r = a * f

            Assert.Equal(a.X * f,r.X)
            Assert.Equal(a.Y * f,r.Y)
            Assert.Equal(a.Z * f,r.Z)
            Assert.Equal(a.W * f,r.W)

        [<Property>]
        let ``Right-handed Vector4-scalar multiplication is the same as component-scalar multiplication`` (a : Vector4, f : float32) =
            let r = f * a
            Assert.Equal(a.X * f,r.X)
            Assert.Equal(a.Y * f,r.Y)
            Assert.Equal(a.Z * f,r.Z)
            Assert.Equal(a.W * f,r.W)

        [<Property>]
        let ``Static method Vector4-scalar multiplication is the same as component-scalar multiplication`` (a : Vector4, f : float32) =
            let r = Vector4.Multiply(a, f)

            Assert.Equal(a.X * f,r.X)
            Assert.Equal(a.Y * f,r.Y)
            Assert.Equal(a.Z * f,r.Z)
            Assert.Equal(a.W * f,r.W)

        [<Property>]
        let ``Vector4-Matrix4 multiplication using right-handed notation is the same as vector/row multiplication and summation`` (a : Matrix4, b : Vector4) =
            let res = a*b

            let c1 = b.X * a.M11 + b.Y * a.M12 + b.Z * a.M13 + b.W * a.M14
            let c2 = b.X * a.M21 + b.Y * a.M22 + b.Z * a.M23 + b.W * a.M24
            let c3 = b.X * a.M31 + b.Y * a.M32 + b.Z * a.M33 + b.W * a.M34
            let c4 = b.X * a.M41 + b.Y * a.M42 + b.Z * a.M43 + b.W * a.M44

            let exp = Vector4(c1, c2, c3, c4)

            Assert.Equal(exp, res)

        [<Property>]
        let ``Vector4-Matrix4 multiplication using left-handed notation is the same as vector/column multiplication and summation`` (a : Matrix4, b : Vector4) =
            let res = b*a

            let c1 = b.X * a.M11 + b.Y * a.M21 + b.Z * a.M31 + b.W * a.M41
            let c2 = b.X * a.M12 + b.Y * a.M22 + b.Z * a.M32 + b.W * a.M42
            let c3 = b.X * a.M13 + b.Y * a.M23 + b.Z * a.M33 + b.W * a.M43
            let c4 = b.X * a.M14 + b.Y * a.M24 + b.Z * a.M34 + b.W * a.M44

            let exp = Vector4(c1, c2, c3, c4)

            Assert.Equal(exp, res)

        [<Property>]
        let ``Static Vector4 multiplication method is the same as component multiplication`` (a : Vector4, b : Vector4) =

            let v1 = Vector4(a.X * b.X, a.Y * b.Y, a.Z * b.Z, a.W * b.W)
            let sum = Vector4.Multiply(a, b)

            Assert.ApproximatelyEquivalent(v1, sum)

        [<Property>]
        let ``Static Vector4 multiplication method by reference is the same as component multiplication`` (a : Vector4, b : Vector4) =

            let v1 = Vector4(a.X * b.X, a.Y * b.Y, a.Z * b.Z, a.W * b.W)
            let sum = Vector4.Multiply(&a, &b)

            Assert.ApproximatelyEquivalent(v1, sum)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Division =
        //
        [<Property>]
        let ``Vector4-float division is the same as component-float division`` (a : Vector4, f : float32) =
            if not (approxEq f 0.0f) then // we don't support diving by zero.
                let r = a / f

                Assert.ApproximatelyEquivalent(a.X / f, r.X)
                Assert.ApproximatelyEquivalent(a.Y / f, r.Y)
                Assert.ApproximatelyEquivalent(a.Z / f, r.Z)
                Assert.ApproximatelyEquivalent(a.W / f, r.W)

        [<Property>]
        let ``Static Vector4-Vector4 division method is the same as component division`` (a : Vector4, b : Vector4) =
            if not (anyZero4 a || anyZero4 b) then
                let v1 = Vector4(a.X / b.X, a.Y / b.Y, a.Z / b.Z, a.W / b.W)
                let sum = Vector4.Divide(a, b)

                Assert.ApproximatelyEquivalent(v1, sum)

        [<Property>]
        let ``Static Vector4-Vector4 divison method by reference is the same as component division`` (a : Vector4, b : Vector4) =
            if not (anyZero4 a || anyZero4 b) then
                let v1 = Vector4(a.X / b.X, a.Y / b.Y, a.Z / b.Z, a.W / b.W)
                let sum = Vector4.Divide(&a, &b)

                Assert.ApproximatelyEquivalent(v1, sum)

        [<Property>]
        let ``Static Vector4-scalar division method is the same as component division`` (a : Vector4, b : float32) =
            if not (approxEq b 0.0f) then // we don't support diving by zero.
                let v1 = Vector4(a.X / b, a.Y / b, a.Z / b, a.W / b)
                let sum = Vector4.Divide(a, b)

                Assert.ApproximatelyEquivalent(v1, sum)

        [<Property>]
        let ``Static Vector4-scalar divison method by reference is the same as component division`` (a : Vector4, b : float32) =
            if not (approxEq b 0.0f) then // we don't support diving by zero.
                let v1 = Vector4(a.X / b, a.Y / b, a.Z / b, a.W / b)
                let sum = Vector4.Divide(&a, b)

                Assert.ApproximatelyEquivalent(v1, sum)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Negation =
        //
        [<Property>]
        let ``Vector negation operator negates all components`` (x, y, z, w) =
            let v = Vector4(x, y, z, w)
            let vNeg = -v
            Assert.Equal(-x, vNeg.X)
            Assert.Equal(-y, vNeg.Y)
            Assert.Equal(-z, vNeg.Z)
            Assert.Equal(-w, vNeg.W)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Equality =
        //
        [<Property>]
        let ``Vector equality operator is by component`` (x, y, z, w) =
            let v1 = Vector4(x, y, z, w)
            let v2 = Vector4(x, y, z, w)
            let equality = v1 = v2

            Assert.True(equality)

        [<Property>]
        let ``Vector inequality operator is by component`` (x, y, z, w) =
            let v1 = Vector4(x, y, z, w)
            let v2 = Vector4(x + 1.0f , y + 1.0f, z + 1.0f, w + 1.0f)
            let inequality = v1 <> v2

            Assert.True(inequality)

        [<Property>]
        let ``Vector equality method is by component`` (x, y, z, w) =
            let v1 = Vector4(x, y, z, w)
            let v2 = Vector4(x, y, z, w)
            let notVector = Matrix2()

            let equality = v1.Equals(v2)
            let inequalityByOtherType = v1.Equals(notVector)

            Assert.True(equality)
            Assert.False(inequalityByOtherType)

        [<Property>]
        let ``Vector equality method returns false for other classes`` (x, y, z, w) =
            let v1 = Vector4(x, y, z, w)
            let notVector = Matrix2()

            let inequalityByOtherType = v1.Equals(notVector)

            Assert.False(inequalityByOtherType)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Swizzling =
        //
        [<Property>]
        let ``Vector swizzling returns the correct composite for X-primary components`` (x, y, z, w) =

            let v = Vector4(x, y, z, w)

            let xyzw = v
            let xywz = Vector4(x, y, w, z)
            let xzyw = Vector4(x, z, y, w)
            let xzwy = Vector4(x, z, w, y)
            let xwyz = Vector4(x, w, y, z)
            let xwzy = Vector4(x, w, z, y)

            let xyz = Vector3(x, y, z)
            let xyw = Vector3(x, y, w)
            let xzy = Vector3(x, z, y)
            let xzw = Vector3(x, z, w)
            let xwy = Vector3(x, w, y)
            let xwz = Vector3(x, w, z)

            let xy = Vector2(x, y)
            let xz = Vector2(x, z)
            let xw = Vector2(x, w)

            // X primary
            Assert.Equal(xyzw, v)
            Assert.Equal(xywz, v.Xywz)
            Assert.Equal(xzyw, v.Xzyw)
            Assert.Equal(xzwy, v.Xzwy)
            Assert.Equal(xwyz, v.Xwyz)
            Assert.Equal(xwzy, v.Xwzy)

            Assert.Equal(xyz, v.Xyz)
            Assert.Equal(xyw, v.Xyw)
            Assert.Equal(xzy, v.Xzy)
            Assert.Equal(xzw, v.Xzw)
            Assert.Equal(xwy, v.Xwy)
            Assert.Equal(xwz, v.Xwz)

            Assert.Equal(xy, v.Xy)
            Assert.Equal(xz, v.Xz)
            Assert.Equal(xw, v.Xw)

        [<Property>]
        let ``Vector swizzling returns the correct composite for Y-primary components`` (x, y, z, w) =

            let v = Vector4(x, y, z, w)

            let yxzw = Vector4(y, x, z, w)
            let yxwz = Vector4(y, x, w, z)
            let yyzw = Vector4(y, y, z, w)
            let yywz = Vector4(y, y, w, z)
            let yzxw = Vector4(y, z, x, w)
            let yzwx = Vector4(y, z, w, x)
            let ywxz = Vector4(y, w, x, z)
            let ywzx = Vector4(y, w, z, x)

            let yxz = Vector3(y, x, z)
            let yxw = Vector3(y, x, w)
            let yzx = Vector3(y, z, x)
            let yzw = Vector3(y, z, w)
            let ywx = Vector3(y, w, x)
            let ywz = Vector3(y, w, z)

            let yx = Vector2(y, x)
            let yz = Vector2(y, z)
            let yw = Vector2(y, w)

            // Y primary
            Assert.Equal(yxzw, v.Yxzw)
            Assert.Equal(yxwz, v.Yxwz)
            Assert.Equal(yyzw, v.Yyzw)
            Assert.Equal(yywz, v.Yywz)
            Assert.Equal(yzxw, v.Yzxw)
            Assert.Equal(yzwx, v.Yzwx)
            Assert.Equal(ywxz, v.Ywxz)
            Assert.Equal(ywzx, v.Ywzx)

            Assert.Equal(yxz, v.Yxz)
            Assert.Equal(yxw, v.Yxw)
            Assert.Equal(yzx, v.Yzx)
            Assert.Equal(yzw, v.Yzw)
            Assert.Equal(ywx, v.Ywx)
            Assert.Equal(ywz, v.Ywz)

            Assert.Equal(yx, v.Yx)
            Assert.Equal(yz, v.Yz)
            Assert.Equal(yw, v.Yw)

        [<Property>]
        let ``Vector swizzling returns the correct composite for Z-primary components`` (x, y, z, w) =

            let v = Vector4(x, y, z, w)

            let zxyw = Vector4(z, x, y, w)
            let zxwy = Vector4(z, x, w, y)
            let zyxw = Vector4(z, y, x, w)
            let zywx = Vector4(z, y, w, x)
            let zwxy = Vector4(z, w, x, y)
            let zwyx = Vector4(z, w, y, x)
            let zwzy = Vector4(z, w, z, y)

            let zxy = Vector3(z, x, y)
            let zxw = Vector3(z, x, w)
            let zyx = Vector3(z, y, x)
            let zyw = Vector3(z, y, w)
            let zwx = Vector3(z, w, x)
            let zwy = Vector3(z, w, y)

            let zx = Vector2(z, x)
            let zy = Vector2(z, y)
            let zw = Vector2(z, w)

            // Z primary
            Assert.Equal(zxyw, v.Zxyw)
            Assert.Equal(zxwy, v.Zxwy)
            Assert.Equal(zyxw, v.Zyxw)
            Assert.Equal(zywx, v.Zywx)
            Assert.Equal(zwxy, v.Zwxy)
            Assert.Equal(zwyx, v.Zwyx)
            Assert.Equal(zwzy, v.Zwzy)

            Assert.Equal(zxy, v.Zxy)
            Assert.Equal(zxw, v.Zxw)
            Assert.Equal(zyx, v.Zyx)
            Assert.Equal(zyw, v.Zyw)
            Assert.Equal(zwx, v.Zwx)
            Assert.Equal(zwy, v.Zwy)

            Assert.Equal(zx, v.Zx)
            Assert.Equal(zy, v.Zy)
            Assert.Equal(zw, v.Zw)

        [<Property>]
        let ``Vector swizzling returns the correct composite for W-primary components`` (x, y, z, w) =

            let v = Vector4(x, y, z, w)

            let wxyz = Vector4(w, x, y, z)
            let wxzy = Vector4(w, x, z, y)
            let wyxz = Vector4(w, y, x, z)
            let wyzx = Vector4(w, y, z, x)
            let wzxy = Vector4(w, z, x, y)
            let wzyx = Vector4(w, z, y, x)
            let wzyw = Vector4(w, z, y, w)

            let wxy = Vector3(w, x, y)
            let wxz = Vector3(w, x, z)
            let wyx = Vector3(w, y, x)
            let wyz = Vector3(w, y, z)
            let wzx = Vector3(w, z, x)
            let wzy = Vector3(w, z, y)

            let wx = Vector2(w, x)
            let wy = Vector2(w, y)
            let wz = Vector2(w, z)

            // W primary
            Assert.Equal(wxyz, v.Wxyz)
            Assert.Equal(wxzy, v.Wxzy)
            Assert.Equal(wyxz, v.Wyxz)
            Assert.Equal(wyzx, v.Wyzx)
            Assert.Equal(wzxy, v.Wzxy)
            Assert.Equal(wzyx, v.Wzyx)
            Assert.Equal(wzyw, v.Wzyw)

            Assert.Equal(wxy, v.Wxy)
            Assert.Equal(wxz, v.Wxz)
            Assert.Equal(wyx, v.Wyx)
            Assert.Equal(wyz, v.Wyz)
            Assert.Equal(wzx, v.Wzx)
            Assert.Equal(wzy, v.Wzy)

            Assert.Equal(wx, v.Wx)
            Assert.Equal(wy, v.Wy)
            Assert.Equal(wz, v.Wz)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Interpolation =
        //
        [<Property>]
        let ``Linear interpolation is by component`` (a : Vector4, b : Vector4, q) =

            let blend = q

            let rX = blend * (b.X - a.X) + a.X
            let rY = blend * (b.Y - a.Y) + a.Y
            let rZ = blend * (b.Z - a.Z) + a.Z
            let rW = blend * (b.W - a.W) + a.W
            let vExp = Vector4(rX, rY, rZ, rW)

            Assert.Equal(vExp, Vector4.Lerp(a, b, q))

            let vRes = Vector4.Lerp(&a, &b, q)
            Assert.Equal(vExp, vRes)

        [<Property>]
        let ``Barycentric interpolation follows the barycentric formula`` (a : Vector4, b : Vector4, c : Vector4, u, v) =

            let r = a + u * (b - a) + v * (c - a)

            Assert.Equal(r, Vector4.BaryCentric(a, b, c, u, v))

            let vRes = Vector4.BaryCentric(&a, &b, &c, u, v)
            Assert.Equal(r, vRes)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module ``Vector products`` =
        //
        [<Property>]
        let ``Dot product method follows the dot product formula`` (a : Vector4, b : Vector4) =
            let dot = a.X * b.X + a.Y * b.Y + a.Z * b.Z + a.W * b.W

            Assert.Equal(dot, Vector4.Dot(a, b));

            let vRes = Vector4.Dot(&a, &b)
            Assert.Equal(dot, vRes)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module ``Magnitude min and max`` =
        //
        [<Property>]
        let ``MagnitudeMin selects the vector with equal or lesser magnitude given two vectors`` (v1 : Vector4, v2: Vector4) =
            // Results do not matter for equal vectors
            if not (v1 = v2) then
                let l1 = v1.LengthSquared
                let l2 = v2.LengthSquared

                let vMin = Vector4.MagnitudeMin(v1, v2)

                if vMin = v1 then
                    let v1ShorterThanv2 = l1 < l2
                    Assert.True(v1ShorterThanv2)
                else
                    let v2ShorterThanOrEqualTov1 = l2 <= l1
                    Assert.True(v2ShorterThanOrEqualTov1)

        [<Property>]
        let ``MagnitudeMax selects the vector with equal or greater magnitude given two vectors`` (v1 : Vector4, v2: Vector4) =
            // Results do not matter for equal vectors
            if not (v1 = v2) then
                let l1 = v1.LengthSquared
                let l2 = v2.LengthSquared

                let vMin = Vector4.MagnitudeMax(v1, v2)

                if vMin = v1 then
                    let v1LongerThanOrEqualTov2 = l1 >= l2
                    Assert.True(v1LongerThanOrEqualTov2)
                else
                    let v2LongerThanv1 = l2 > l1
                    Assert.True(v2LongerThanv1)

        [<Property>]
        let ``MagnitudeMin by reference selects the vector with equal or lesser magnitude given two vectors`` (v1 : Vector4, v2: Vector4) =
            // Results do not matter for equal vectors
            if not (v1 = v2) then
                let l1 = v1.LengthSquared
                let l2 = v2.LengthSquared

                let vMin = Vector4.MagnitudeMin(&v1, &v2)

                if vMin = v1 then
                    let v1ShorterThanv2 = l1 < l2
                    Assert.True(v1ShorterThanv2)
                else
                    let v2ShorterThanOrEqualTov1 = l2 <= l1
                    Assert.True(v2ShorterThanOrEqualTov1)

        [<Property>]
        let ``MagnitudeMax by reference selects the vector with equal or greater magnitude given two vectors`` (v1 : Vector4, v2: Vector4) =
            // Results do not matter for equal vectors
            if not (v1 = v2) then
                let l1 = v1.LengthSquared
                let l2 = v2.LengthSquared

                let vMin = Vector4.MagnitudeMax(&v1, &v2)

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
        let ``ComponentMin creates a new vector from the smallest components of given vectors`` (v1 : Vector4, v2: Vector4) =
            let vMin = Vector4.ComponentMin(v1, v2)
            let isComponentSmallest smallComp comp1 comp2 = smallComp <= comp1 && smallComp <= comp2

            Assert.True(isComponentSmallest vMin.X v1.X v2.X)
            Assert.True(isComponentSmallest vMin.Y v1.Y v2.Y)
            Assert.True(isComponentSmallest vMin.Z v1.Z v2.Z)
            Assert.True(isComponentSmallest vMin.W v1.W v2.W)

        [<Property>]
        let ``ComponentMax creates a new vector from the greatest components of given vectors`` (v1 : Vector4, v2: Vector4) =
            let vMax = Vector4.ComponentMax(v1, v2)
            let isComponentLargest largeComp comp1 comp2 = largeComp >= comp1 && largeComp >= comp2

            Assert.True(isComponentLargest vMax.X v1.X v2.X)
            Assert.True(isComponentLargest vMax.Y v1.Y v2.Y)
            Assert.True(isComponentLargest vMax.Z v1.Z v2.Z)
            Assert.True(isComponentLargest vMax.W v1.W v2.W)

        [<Property>]
        let ``ComponentMin by reference creates a new vector from the smallest components of given vectors`` (v1 : Vector4, v2: Vector4) =
            let vMin = Vector4.ComponentMin(&v1, &v2)
            let isComponentSmallest smallComp comp1 comp2 = smallComp <= comp1 && smallComp <= comp2

            Assert.True(isComponentSmallest vMin.X v1.X v2.X)
            Assert.True(isComponentSmallest vMin.Y v1.Y v2.Y)
            Assert.True(isComponentSmallest vMin.Z v1.Z v2.Z)
            Assert.True(isComponentSmallest vMin.W v1.W v2.W)

        [<Property>]
        let ``ComponentMax by reference creates a new vector from the greatest components of given vectors`` (v1 : Vector4, v2: Vector4) =
            let vMax = Vector4.ComponentMax(&v1, &v2)
            let isComponentLargest largeComp comp1 comp2 = largeComp >= comp1 && largeComp >= comp2

            Assert.True(isComponentLargest vMax.X v1.X v2.X)
            Assert.True(isComponentLargest vMax.Y v1.Y v2.Y)
            Assert.True(isComponentLargest vMax.Z v1.Z v2.Z)
            Assert.True(isComponentLargest vMax.W v1.W v2.W)


    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Clamping =
        //
        [<Property>]
        let ``Clamping one vector between two other vectors clamps all components between corresponding components`` (a : Vector4, b : Vector4, w : Vector4) =
            let expX = if w.X < a.X then a.X else if w.X > b.X then b.X else w.X
            let expY = if w.Y < a.Y then a.Y else if w.Y > b.Y then b.Y else w.Y
            let expZ = if w.Z < a.Z then a.Z else if w.Z > b.Z then b.Z else w.Z
            let expW = if w.W < a.W then a.W else if w.W > b.W then b.W else w.W

            let res = Vector4.Clamp(w, a, b)

            Assert.Equal(expX, res.X)
            Assert.Equal(expY, res.Y)
            Assert.Equal(expZ, res.Z)
            Assert.Equal(expW, res.W)

        [<Property>]
        let ``Clamping one vector between two other vectors by reference clamps all components between corresponding components`` (a : Vector4, b : Vector4, w : Vector4) =
            let expX = if w.X < a.X then a.X else if w.X > b.X then b.X else w.X
            let expY = if w.Y < a.Y then a.Y else if w.Y > b.Y then b.Y else w.Y
            let expZ = if w.Z < a.Z then a.Z else if w.Z > b.Z then b.Z else w.Z
            let expW = if w.W < a.W then a.W else if w.W > b.W then b.W else w.W

            let res = Vector4.Clamp(&w, &a, &b)

            Assert.Equal(expX, res.X)
            Assert.Equal(expY, res.Y)
            Assert.Equal(expZ, res.Z)
            Assert.Equal(expW, res.W)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module ``Unit vectors``=
        //
        [<Property>]
        let ``Unit X is correct``  =
            let unitX = Vector4(1.0f, 0.0f, 0.0f, 0.0f)

            Assert.Equal(Vector4.UnitX, unitX)

        [<Property>]
        let ``Unit Y is correct``  =
            let unitY = Vector4(0.0f, 1.0f, 0.0f, 0.0f)

            Assert.Equal(Vector4.UnitY, unitY)

        [<Property>]
        let ``Unit Z is correct``  =
            let unitZ = Vector4(0.0f, 0.0f, 1.0f, 0.0f)

            Assert.Equal(Vector4.UnitZ, unitZ)

        [<Property>]
        let ``Unit W is correct``  =
            let unitW = Vector4(0.0f, 0.0f, 0.0f, 1.0f)

            Assert.Equal(Vector4.UnitW, unitW)

        [<Property>]
        let ``Unit zero is correct``  =
            let unitZero = Vector4(0.0f, 0.0f, 0.0f, 0.0f)

            Assert.Equal(Vector4.Zero, unitZero)

        [<Property>]
        let ``Unit one is correct``  =
            let unitOne = Vector4(1.0f, 1.0f, 1.0f, 1.0f)

            Assert.Equal(Vector4.One, unitOne)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Serialization =
        //
        [<Property>]
        let ``The absolute size of a Vector4 is always the size of its components`` (v : Vector4) =
            let expectedSize = sizeof<float32> * 4

            Assert.Equal(expectedSize, Vector4.SizeInBytes)
            Assert.Equal(expectedSize, Marshal.SizeOf(Vector4()))

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Transformation =
        //
        [<Property>]
        let ``Transformation by quaternion with static method is the same as multiplication by quaternion and its conjugate`` (v : Vector4, q : Quaternion) =
            let vectorQuat = Quaternion(v.X, v.Y, v.Z, v.W)
            let inverse = Quaternion.Invert(q)

            let transformedQuat = q * vectorQuat * inverse
            let transformedVector = Vector4(transformedQuat.X, transformedQuat.Y, transformedQuat.Z, transformedQuat.W)

            Assert.ApproximatelyEquivalent(transformedVector, Vector4.Transform(v, q))

        [<Property>]
        let ``Transformation by quaternion with static method by reference is the same as multiplication by quaternion and its conjugate`` (v : Vector4, q : Quaternion) =
            let vectorQuat = Quaternion(v.X, v.Y, v.Z, v.W)
            let inverse = Quaternion.Invert(q)

            let transformedQuat = q * vectorQuat * inverse
            let transformedVector = Vector4(transformedQuat.X, transformedQuat.Y,transformedQuat.Z, transformedQuat.W)

            Assert.ApproximatelyEquivalent(transformedVector, Vector4.Transform(&v, &q))

        [<Property>]
        let ``Transformation by quaternion by multiplication using right-handed notation is the same as multiplication by quaternion and its conjugate`` (v : Vector4, q : Quaternion) =
            let vectorQuat = Quaternion(v.X, v.Y, v.Z, v.W)
            let inverse = Quaternion.Invert(q)

            let transformedQuat = q * vectorQuat * inverse
            let transformedVector = Vector4(transformedQuat.X, transformedQuat.Y, transformedQuat.Z, transformedQuat.W)

            Assert.ApproximatelyEquivalent(transformedVector, q * v)
