namespace OpenTK.Tests

open Xunit
open FsCheck.Xunit
open OpenTK.Mathematics

module Vector4d =
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Multiplication =
        //
        [<Property>]
        let ``Vector4d-Matrix4x2d multiplication is the same as vector/column multiplication and summation`` (a : Matrix4x2d, b : Vector4d) =
            let res = b * a

            let c1 = b.X * a.M11 + b.Y * a.M21 + b.Z * a.M31 + b.W * a.M41
            let c2 = b.X * a.M12 + b.Y * a.M22 + b.Z * a.M32 + b.W * a.M42

            let exp = Vector2d(c1, c2)

            Assert.Equal(exp, res)

        [<Property>]
        let ``Vector4d-Matrix4x2d multiplication is consistent across overloads`` (a : Matrix4x2d, b : Vector4d) =
            let r1 = b * a;
            let r2 = Vector4d.TransformTwoDimensionsRow(b, a);
            let r3 = Vector4d.TransformTwoDimensionsRow(&b, &a);

            Assert.Equal(r1, r2)
            Assert.Equal(r2, r3)

        [<Property>]
        let ``Matrix2x4d-Vector4d multiplication is the same as vector/column multiplication and summation`` (a : Matrix2x4d, b : Vector4d) =
            let res = a * b

            let c1 = b.X * a.M11 + b.Y * a.M12 + b.Z * a.M13 + b.W * a.M14
            let c2 = b.X * a.M21 + b.Y * a.M22 + b.Z * a.M23 + b.W * a.M24

            let exp = Vector2d(c1, c2)

            Assert.Equal(exp, res)

        [<Property>]
        let ``Matrix2x4d-Vector4d multiplication is consistent across overloads`` (a : Matrix2x4d, b : Vector4d) =
            let r1 = a * b;
            let r2 = Vector4d.TransformTwoDimensionsColumn(a, b);
            let r3 = Vector4d.TransformTwoDimensionsColumn(&a, &b);

            Assert.Equal(r1, r2)
            Assert.Equal(r2, r3)

        [<Property>]
        let ``Vector4d-Matrix4x3d multiplication is the same as vector/column multiplication and summation`` (a : Matrix4x3d, b : Vector4d) =
            let res = b * a

            let c1 = b.X * a.M11 + b.Y * a.M21 + b.Z * a.M31 + b.W * a.M41
            let c2 = b.X * a.M12 + b.Y * a.M22 + b.Z * a.M32 + b.W * a.M42
            let c3 = b.X * a.M13 + b.Y * a.M23 + b.Z * a.M33 + b.W * a.M43

            let exp = Vector3d(c1, c2, c3)

            Assert.Equal(exp, res)

        [<Property>]
        let ``Vector4-Matrix4x3 multiplication is consistent across overloads`` (a : Matrix4x3, b : Vector4) =
            let r1 = b * a;
            let r2 = Vector4.TransformThreeDimensionsRow(b, a);
            let r3 = Vector4.TransformThreeDimensionsRow(&b, &a);

            Assert.Equal(r1, r2)
            Assert.Equal(r2, r3)
