namespace OpenTK.Tests

open Xunit
open FsCheck.Xunit
open OpenTK.Mathematics

module Vector3d =
    //
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Multiplication =
        //
        [<Property>]
        let ``Vector3d-Matrix3x2d multiplication is the same as vector/column multiplication and summation`` (a : Matrix3x2d, b : Vector3d) =
            let res = b * a

            let c1 = b.X * a.M11 + b.Y * a.M21 + b.Z * a.M31
            let c2 = b.X * a.M12 + b.Y * a.M22 + b.Z * a.M32

            let exp = Vector2d(c1, c2)

            Assert.Equal(exp, res)

        [<Property>]
        let ``Vector3d-Matrix3x2d multiplication is consistent across overloads`` (a : Matrix3x2d, b : Vector3d) =
            let r1 = b * a;
            let r2 = Vector3d.TransformTwoDimensions(b, a);
            let r3 = Vector3d.TransformTwoDimensions(&b, &a);

            Assert.Equal(r1, r2)
            Assert.Equal(r2, r3)

        [<Property>]
        let ``Vector3d-Matrix3x4d multiplication is the same as vector/column multiplication and summation`` (a : Matrix3x4d, b : Vector3d) =
            let res = b * a

            let c1 = b.X * a.M11 + b.Y * a.M21 + b.Z * a.M31
            let c2 = b.X * a.M12 + b.Y * a.M22 + b.Z * a.M32
            let c3 = b.X * a.M13 + b.Y * a.M23 + b.Z * a.M33
            let c4 = b.X * a.M14 + b.Y * a.M24 + b.Z * a.M34

            let exp = Vector4d(c1, c2, c3, c4)

            Assert.Equal(exp, res)

        [<Property>]
        let ``Vector3-Matrix3x4d multiplication is consistent across overloads`` (a : Matrix3x4d, b : Vector3d) =
            let r1 = b * a;
            let r2 = Vector3d.TransformFourDimensions(b, a);
            let r3 = Vector3d.TransformFourDimensions(&b, &a);

            Assert.Equal(r1, r2)
            Assert.Equal(r2, r3)