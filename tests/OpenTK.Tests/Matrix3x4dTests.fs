namespace OpenTK.Tests

open Xunit
open FsCheck.Xunit
open OpenTK.Mathematics

module Matrix3x4d =
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Multiplication =
        //
        [<Property>]
        let ``Matrix3x4d-Matrix4x2d multiplication is done by row/column multiplication and summation`` (a, b, c, d, e, f, g, h, i, j, k, l) =
            let A = Matrix3x4d(a, b, c, d, e, f, g, h, i, j, k, l)
            let B = Matrix4x2d(a, b, c, d, e, f, g, h)

            let R11 = a*a + b*c + c*e + d*g
            let R12 = a*b + b*d + c*f + d*h

            let R21 = e*a + f*c + g*e + h*g
            let R22 = e*b + f*d + g*f + h*h

            let R31 = i*a + j*c + k*e + l*g
            let R32 = i*b + j*d + k*f + l*h

            let AB = A * B

            Assert.Equal(R11, AB.M11)
            Assert.Equal(R12, AB.M12)

            Assert.Equal(R21, AB.M21)
            Assert.Equal(R22, AB.M22)

            Assert.Equal(R31, AB.M31)
            Assert.Equal(R32, AB.M32)

        [<Property>]
        let ``Matrix3x4-Matrix4 is done by row/column multiplication and summation`` (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) =
            let A = Matrix3x4d(a, b, c, d, e, f, g, h, i, j, k, l)
            let B = Matrix4d(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p)

            let R11 = a*a + b*e + c*i + d*m
            let R12 = a*b + b*f + c*j + d*n
            let R13 = a*c + b*g + c*k + d*o
            let R14 = a*d + b*h + c*l + d*p

            let R21 = e*a + f*e + g*i + h*m
            let R22 = e*b + f*f + g*j + h*n
            let R23 = e*c + f*g + g*k + h*o
            let R24 = e*d + f*h + g*l + h*p

            let R31 = i*a + j*e + k*i + l*m
            let R32 = i*b + j*f + k*j + l*n
            let R33 = i*c + j*g + k*k + l*o
            let R34 = i*d + j*h + k*l + l*p

            let AB = A * B

            Assert.Equal(R11, AB.M11)
            Assert.Equal(R12, AB.M12)
            Assert.Equal(R13, AB.M13)
            Assert.Equal(R14, AB.M14)

            Assert.Equal(R21, AB.M21)
            Assert.Equal(R22, AB.M22)
            Assert.Equal(R23, AB.M23)
            Assert.Equal(R24, AB.M24)

            Assert.Equal(R31, AB.M31)
            Assert.Equal(R32, AB.M32)
            Assert.Equal(R33, AB.M33)
            Assert.Equal(R34, AB.M34)
