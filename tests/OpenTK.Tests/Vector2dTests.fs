namespace OpenTK.Tests

open Xunit
open FsCheck.Xunit
open OpenTK.Mathematics

module Vector2d =
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Multiplication =
        //
        [<Property>]
        let ``Vector2d-Matrix2x3d multiplication is the same as vector/column multiplication and summation`` (a : Matrix2x3d, b : Vector2d) =
            let res = b * a;

            let c1 = b.X * a.M11 + b.Y * a.M21
            let c2 = b.X * a.M12 + b.Y * a.M22
            let c3 = b.X * a.M13 + b.Y * a.M23

            let exp = Vector3d(c1, c2, c3)

            Assert.Equal(exp, res)

        [<Property>]
        let ``Vector2d-Matrix2x3d multiplication is consistent across overloads`` (a : Matrix2x3d, b : Vector2d) =
            let r1 = b * a;
            let r2 = Vector2d.TransformToThreeDimensions(b, a);
            let r3 = Vector2d.TransformToThreeDimensions(&b, &a);

            Assert.Equal(r1, r2)
            Assert.Equal(r2, r3)

        [<Property>]
        let ``Vector2d-Matrix2x4d multiplication is the same as vector/column multiplication and summation`` (a : Matrix2x4d, b : Vector2d) =
            let res = b * a;

            let c1 = b.X * a.M11 + b.Y * a.M21
            let c2 = b.X * a.M12 + b.Y * a.M22
            let c3 = b.X * a.M13 + b.Y * a.M23
            let c4 = b.X * a.M14 + b.Y * a.M24

            let exp = Vector4d(c1, c2, c3, c4)

            Assert.Equal(exp, res)

        [<Property>]
        let ``Vector2d-Matrix2x4d multiplication is consistent across overloads`` (a : Matrix2x4d, b : Vector2d) =
            let r1 = b * a;
            let r2 = Vector2d.TransformToFourDimensions(b, a);
            let r3 = Vector2d.TransformToFourDimensions(&b, &a);

            Assert.Equal(r1, r2)
            Assert.Equal(r2, r3)