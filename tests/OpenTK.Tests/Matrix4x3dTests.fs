namespace OpenTK.Tests

open Xunit
open FsCheck.Xunit
open OpenTK.Mathematics

module Matrix4x3d =
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Multiplication =
        //
        [<Property>]
        let ``Matrix4x3d-Matrix3x2d multiplication is done by row/column multiplication and summation`` (a, b, c, d, e, f, g, h, i, j, k, l) =
            let A = Matrix4x3d(a, b, c, d, e, f, g, h, i, j, k, l)
            let B = Matrix3x2d(a, b, c, d, e, f)

            let R11 = a*a + b*c + c*e
            let R12 = a*b + b*d + c*f

            let R21 = d*a + e*c + f*e
            let R22 = d*b + e*d + f*f

            let R31 = g*a + h*c + i*e
            let R32 = g*b + h*d + i*f

            let R41 = j*a + k*c + l*e
            let R42 = j*b + k*d + l*f

            let AB = A * B

            Assert.Equal(R11, AB.M11)
            Assert.Equal(R12, AB.M12)

            Assert.Equal(R21, AB.M21)
            Assert.Equal(R22, AB.M22)

            Assert.Equal(R31, AB.M31)
            Assert.Equal(R32, AB.M32)

            Assert.Equal(R41, AB.M41)
            Assert.Equal(R42, AB.M42)

        [<Property>]
        let ``Matrix4x3d-Matrix3d is done by row/column multiplication and summation`` (a, b, c, d, e, f, g, h, i, j, k, l) =
            let A = Matrix4x3d(a, b, c, d, e, f, g, h, i, j, k, l)
            let B = Matrix3d(a, b, c, d, e, f, g, h, i)

            let R11 = a*a + b*d + c*g
            let R12 = a*b + b*e + c*h
            let R13 = a*c + b*f + c*i

            let R21 = d*a + e*d + f*g
            let R22 = d*b + e*e + f*h
            let R23 = d*c + e*f + f*i

            let R31 = g*a + h*d + i*g
            let R32 = g*b + h*e + i*h
            let R33 = g*c + h*f + i*i

            let R41 = j*a + k*d + l*g
            let R42 = j*b + k*e + l*h
            let R43 = j*c + k*f + l*i

            let AB = A * B

            Assert.Equal(R11, AB.M11)
            Assert.Equal(R12, AB.M12)
            Assert.Equal(R13, AB.M13)

            Assert.Equal(R21, AB.M21)
            Assert.Equal(R22, AB.M22)
            Assert.Equal(R23, AB.M23)

            Assert.Equal(R31, AB.M31)
            Assert.Equal(R32, AB.M32)
            Assert.Equal(R33, AB.M33)

            Assert.Equal(R41, AB.M41)
            Assert.Equal(R42, AB.M42)
            Assert.Equal(R43, AB.M43)
