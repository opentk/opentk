namespace OpenTK.Tests

open Xunit
open FsCheck
open FsCheck.Xunit
open System
open OpenTK
open OpenTK.Mathematics
open OpenTK.Tests

module MathHelper =
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module ``ApproximatelyEqual (delta)`` =
        /// This test ensures that approximately equal can never get it 'wrong' about the values.
        [<Property>]
        let ``ApproximatelyEqual is never incorrect`` (a : float32,b : float32,bits : int32) =
            let clamped = max 0 (min bits 24)
            let areApproxEqual = MathHelper.ApproximatelyEqual(a,b,clamped)
            let areExactlyEqual = a = b
            let isWrong = areExactlyEqual && not areApproxEqual
            Assert.False(isWrong)

        [<Property>]
        let ``ApproximatelyEqual can return true if some values are not exactly equal`` (a : float32,b : float32,bits : int32) =
            let clamped = max 0 (min bits 24)
            let areApproxEqual = MathHelper.ApproximatelyEqual(a,b,clamped)
            let areExactlyEqual = a = b
            let isWrong = areExactlyEqual && not areApproxEqual
            let p = new PropertyAttribute()
            Assert.False(isWrong)

        [<Fact>]
        let ``ApproximatelyEqual correctly approximates equality``() =
            let a = 0.000000001f
            let b = 0.0000000010000001f
            Assert.NotEqual(a,b)
            [ 1..24 ] |> List.iter (fun i -> Assert.True(MathHelper.ApproximatelyEqual(a,b,i)))

        [<Fact>]
        let ``ApproximatelyEqual reports very different values as non-equal even with high bit count``() =
            let a = 2.0f
            let b = 1.0f
            Assert.NotEqual(a,b)
            Assert.False(MathHelper.ApproximatelyEqual(a,b,10))

        [<Fact>]
        let ``ApproximatelyEqual works with single zero value``() =
            let a = 1.0f
            let b = 0.0f
            Assert.NotEqual(a,b)
            Assert.False(MathHelper.ApproximatelyEqual(a,b,0))

        [<Fact>]
        let ``ApproximatelyEqual works with both zero values``() =
            let a = 0.0f
            let b = 0.0f
            Assert.Equal(a,b)
            Assert.True(MathHelper.ApproximatelyEqual(a,b,0))

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module ``ApproximatelyEqual (single-precision epsilon)`` =
        //
        [<Fact>]
        let ``ApproximatelyEqual (single precision) is correct for large positive values``() =
            Assert.ApproximatelyEqualEpsilon(1000000.0f, 1000001.0f);
            Assert.ApproximatelyEqualEpsilon(1000001.0f, 1000000.0f);
            Assert.NotApproximatelyEqualEpsilon(10000.0f, 10001.0f);
            Assert.NotApproximatelyEqualEpsilon(10001.0f, 10000.0f);

        [<Fact>]
        let ``ApproximatelyEqual (single precision) is correct for large negative values``() =
            Assert.ApproximatelyEqualEpsilon(-1000000.0f, -1000001.0f);
            Assert.ApproximatelyEqualEpsilon(-1000001.0f, -1000000.0f);
            Assert.NotApproximatelyEqualEpsilon(-10000.0f, -10001.0f);
            Assert.NotApproximatelyEqualEpsilon(-10001.0f, -10000.0f);

        [<Fact>]
        let ``ApproximatelyEqual (single precision) is correct for positive values around 1``() =
            Assert.ApproximatelyEqualEpsilon(1.0000001f, 1.0000002f);
            Assert.ApproximatelyEqualEpsilon(1.0000002f, 1.0000001f);
            Assert.NotApproximatelyEqualEpsilon(1.0002f, 1.0001f);
            Assert.NotApproximatelyEqualEpsilon(1.0001f, 1.0002f);

        [<Fact>]
        let ``ApproximatelyEqual (single precision) is correct for negative values around -1``() =
            Assert.ApproximatelyEqualEpsilon(-1.000001f, -1.000002f);
            Assert.ApproximatelyEqualEpsilon(-1.000002f, -1.000001f);
            Assert.NotApproximatelyEqualEpsilon(-1.0001f, -1.0002f);
            Assert.NotApproximatelyEqualEpsilon(-1.0002f, -1.0001f);

        [<Fact>]
        let ``ApproximatelyEqual (single precision) is correct for values between 1 and 0``() =
            Assert.ApproximatelyEqualEpsilon(0.000000001000001f, 0.000000001000002f);
            Assert.ApproximatelyEqualEpsilon(0.000000001000002f, 0.000000001000001f);
            Assert.NotApproximatelyEqualEpsilon(0.000000000001002f, 0.000000000001001f);
            Assert.NotApproximatelyEqualEpsilon(0.000000000001001f, 0.000000000001002f);

        [<Fact>]
        let ``ApproximatelyEqual (single precision) is correct for values between -1 and 0``() =
            Assert.ApproximatelyEqualEpsilon(-0.000000001000001f, -0.000000001000002f);
            Assert.ApproximatelyEqualEpsilon(-0.000000001000002f, -0.000000001000001f);
            Assert.NotApproximatelyEqualEpsilon(-0.000000000001002f, -0.000000000001001f);
            Assert.NotApproximatelyEqualEpsilon(-0.000000000001001f, -0.000000000001002f);

        [<Fact>]
        let ``ApproximatelyEqual (single precision) is correct for comparisons involving 0``() =
            Assert.ApproximatelyEqualEpsilon(0.0f, 0.0f);
            Assert.ApproximatelyEqualEpsilon(0.0f, -0.0f);
            Assert.ApproximatelyEqualEpsilon(-0.0f, -0.0f);
            Assert.NotApproximatelyEqualEpsilon(0.00000001f, 0.0f);
            Assert.NotApproximatelyEqualEpsilon(0.0f, 0.00000001f);
            Assert.NotApproximatelyEqualEpsilon(-0.00000001f, 0.0f);
            Assert.NotApproximatelyEqualEpsilon(0.0f, -0.00000001f);

            Assert.ApproximatelyEqualEpsilon(0.0f, 1.0e-40f, 0.01f);
            Assert.ApproximatelyEqualEpsilon(1.0e-40f, 0.0f, 0.01f);
            Assert.NotApproximatelyEqualEpsilon(1.0e-40f, 0.0f, 0.000001f);
            Assert.NotApproximatelyEqualEpsilon(0.0f, 1.0e-40f, 0.000001f);

            Assert.ApproximatelyEqualEpsilon(0.0f, -1.0e-40f, 0.1f);
            Assert.ApproximatelyEqualEpsilon(-1.0e-40f, 0.0f, 0.1f);
            Assert.NotApproximatelyEqualEpsilon(-1.0e-40f, 0.0f, 0.00000001f);
            Assert.NotApproximatelyEqualEpsilon(0.0f, -1.0e-40f, 0.00000001f);

        [<Fact>]
        let ``ApproximatelyEqual (single precision) is correct for extreme values with overflow potential``() =
            Assert.ApproximatelyEqualEpsilon(System.Single.MaxValue, System.Single.MaxValue);
            Assert.NotApproximatelyEqualEpsilon(System.Single.MaxValue, -System.Single.MaxValue);
            Assert.NotApproximatelyEqualEpsilon(-System.Single.MaxValue, System.Single.MaxValue);
            Assert.NotApproximatelyEqualEpsilon(System.Single.MaxValue, System.Single.MaxValue / 2.0f);
            Assert.NotApproximatelyEqualEpsilon(System.Single.MaxValue, -System.Single.MaxValue / 2.0f);
            Assert.NotApproximatelyEqualEpsilon(-System.Single.MaxValue, System.Single.MaxValue / 2.0f);

        [<Fact>]
        let ``ApproximatelyEqual (single precision) is correct for values involving infinities``() =
            Assert.ApproximatelyEqualEpsilon(System.Single.PositiveInfinity, System.Single.PositiveInfinity);
            Assert.ApproximatelyEqualEpsilon(System.Single.NegativeInfinity, System.Single.NegativeInfinity);
            Assert.NotApproximatelyEqualEpsilon(System.Single.NegativeInfinity, System.Single.PositiveInfinity);
            Assert.NotApproximatelyEqualEpsilon(System.Single.PositiveInfinity, System.Single.MaxValue);
            Assert.NotApproximatelyEqualEpsilon(System.Single.NegativeInfinity, -System.Single.MaxValue);

        [<Fact>]
        let ``ApproximatelyEqual (single precision) is correct for values involving NaN``() =
            Assert.NotApproximatelyEqualEpsilon(System.Single.NaN, System.Single.NaN);
            Assert.NotApproximatelyEqualEpsilon(System.Single.NaN, 0.0f);
            Assert.NotApproximatelyEqualEpsilon(-0.0f, System.Single.NaN);
            Assert.NotApproximatelyEqualEpsilon(System.Single.NaN, -0.0f);
            Assert.NotApproximatelyEqualEpsilon(0.0f, System.Single.NaN);
            Assert.NotApproximatelyEqualEpsilon(System.Single.NaN, System.Single.PositiveInfinity);
            Assert.NotApproximatelyEqualEpsilon(System.Single.PositiveInfinity, System.Single.NaN);
            Assert.NotApproximatelyEqualEpsilon(System.Single.NaN, System.Single.NegativeInfinity);
            Assert.NotApproximatelyEqualEpsilon(System.Single.NegativeInfinity, System.Single.NaN);
            Assert.NotApproximatelyEqualEpsilon(System.Single.NaN, System.Single.MaxValue);
            Assert.NotApproximatelyEqualEpsilon(System.Single.MaxValue, System.Single.NaN);
            Assert.NotApproximatelyEqualEpsilon(System.Single.NaN, -System.Single.MaxValue);
            Assert.NotApproximatelyEqualEpsilon(-System.Single.MaxValue, System.Single.NaN);
            Assert.NotApproximatelyEqualEpsilon(System.Single.NaN, System.Single.Epsilon);
            Assert.NotApproximatelyEqualEpsilon(System.Single.Epsilon, System.Single.NaN);
            Assert.NotApproximatelyEqualEpsilon(System.Single.NaN, -System.Single.Epsilon);
            Assert.NotApproximatelyEqualEpsilon(-System.Single.Epsilon, System.Single.NaN);

        [<Fact>]
        let ``ApproximatelyEqual (single precision) is correct for values on opposite sides of 0``() =
            Assert.NotApproximatelyEqualEpsilon(1.000000001f, -1.0f);
            Assert.NotApproximatelyEqualEpsilon(-1.0f, 1.000000001f);
            Assert.NotApproximatelyEqualEpsilon(-1.000000001f, 1.0f);
            Assert.NotApproximatelyEqualEpsilon(1.0f, -1.000000001f);
            Assert.ApproximatelyEqualEpsilon(10.0f * System.Single.Epsilon, 10.0f * -System.Single.Epsilon);
            Assert.NotApproximatelyEqualEpsilon(10000.0f * System.Single.Epsilon, 10000.0f * -System.Single.Epsilon);

        [<Fact>]
        let ``ApproximatelyEqual (single precision) is correct for values very close to 0``() =
            Assert.ApproximatelyEqualEpsilon(System.Single.Epsilon, System.Single.Epsilon);
            Assert.ApproximatelyEqualEpsilon(System.Single.Epsilon, -System.Single.Epsilon);
            Assert.ApproximatelyEqualEpsilon(-System.Single.Epsilon, System.Single.Epsilon);
            Assert.ApproximatelyEqualEpsilon(System.Single.Epsilon, 0.0f);
            Assert.ApproximatelyEqualEpsilon(0.0f, System.Single.Epsilon);
            Assert.ApproximatelyEqualEpsilon(-System.Single.Epsilon, 0.0f);
            Assert.ApproximatelyEqualEpsilon(0.0f, -System.Single.Epsilon);

            Assert.NotApproximatelyEqualEpsilon(0.000000001f, -System.Single.Epsilon);
            Assert.NotApproximatelyEqualEpsilon(0.000000001f, System.Single.Epsilon);
            Assert.NotApproximatelyEqualEpsilon(System.Single.Epsilon, 0.000000001f);
            Assert.NotApproximatelyEqualEpsilon(-System.Single.Epsilon, 0.000000001f);

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module ``ApproximatelyEqual (double-precision epsilon)`` =
        //
        [<Fact>]
        let ``ApproximatelyEqual (double precision) is correct for large positive values``() =
            Assert.ApproximatelyEqualEpsilon(1000000.0, 1000001.0);
            Assert.ApproximatelyEqualEpsilon(1000001.0, 1000000.0);
            Assert.NotApproximatelyEqualEpsilon(10000.0, 10001.0);
            Assert.NotApproximatelyEqualEpsilon(10001.0, 10000.0);

        [<Fact>]
        let ``ApproximatelyEqual (double precision) is correct for large negative values``() =
            Assert.ApproximatelyEqualEpsilon(-1000000.0, -1000001.0);
            Assert.ApproximatelyEqualEpsilon(-1000001.0, -1000000.0);
            Assert.NotApproximatelyEqualEpsilon(-10000.0, -10001.0);
            Assert.NotApproximatelyEqualEpsilon(-10001.0, -10000.0);

        [<Fact>]
        let ``ApproximatelyEqual (double precision) is correct for positive values around 1``() =
            Assert.ApproximatelyEqualEpsilon(1.0000001, 1.0000002);
            Assert.ApproximatelyEqualEpsilon(1.0000002, 1.0000001);
            Assert.NotApproximatelyEqualEpsilon(1.0002, 1.0001);
            Assert.NotApproximatelyEqualEpsilon(1.0001, 1.0002);

        [<Fact>]
        let ``ApproximatelyEqual (double precision) is correct for negative values around -1``() =
            Assert.ApproximatelyEqualEpsilon(-1.000001, -1.000002);
            Assert.ApproximatelyEqualEpsilon(-1.000002, -1.000001);
            Assert.NotApproximatelyEqualEpsilon(-1.0001, -1.0002);
            Assert.NotApproximatelyEqualEpsilon(-1.0002, -1.0001);

        [<Fact>]
        let ``ApproximatelyEqual (double precision) is correct for values between 1 and 0``() =
            Assert.ApproximatelyEqualEpsilon(0.000000001000001, 0.000000001000002);
            Assert.ApproximatelyEqualEpsilon(0.000000001000002, 0.000000001000001);
            Assert.NotApproximatelyEqualEpsilon(0.000000000001002, 0.000000000001001);
            Assert.NotApproximatelyEqualEpsilon(0.000000000001001, 0.000000000001002);

        [<Fact>]
        let ``ApproximatelyEqual (double precision) is correct for values between -1 and 0``() =
            Assert.ApproximatelyEqualEpsilon(-0.000000001000001, -0.000000001000002);
            Assert.ApproximatelyEqualEpsilon(-0.000000001000002, -0.000000001000001);
            Assert.NotApproximatelyEqualEpsilon(-0.000000000001002, -0.000000000001001);
            Assert.NotApproximatelyEqualEpsilon(-0.000000000001001, -0.000000000001002);

        [<Fact>]
        let ``ApproximatelyEqual (double precision) is correct for comparisons involving 0``() =
            Assert.ApproximatelyEqualEpsilon(0.0, 0.0);
            Assert.ApproximatelyEqualEpsilon(0.0, -0.0);
            Assert.ApproximatelyEqualEpsilon(-0.0, -0.0);
            Assert.NotApproximatelyEqualEpsilon(0.00000001, 0.0);
            Assert.NotApproximatelyEqualEpsilon(0.0, 0.00000001);
            Assert.NotApproximatelyEqualEpsilon(-0.00000001, 0.0);
            Assert.NotApproximatelyEqualEpsilon(0.0, -0.00000001);

            Assert.ApproximatelyEqualEpsilon(0.0, 1e-310, 0.01);
            Assert.ApproximatelyEqualEpsilon(1e-310, 0.0, 0.01);
            Assert.NotApproximatelyEqualEpsilon(1e-310, 0.0, 0.000001);
            Assert.NotApproximatelyEqualEpsilon(0.0, 1e-310, 0.000001);

            Assert.ApproximatelyEqualEpsilon(0.0, -1e-310, 0.1);
            Assert.ApproximatelyEqualEpsilon(-1e-310, 0.0, 0.1);
            Assert.NotApproximatelyEqualEpsilon(-1e-310, 0.0, 0.00000001);
            Assert.NotApproximatelyEqualEpsilon(0.0, -1e-310, 0.00000001);

        [<Fact>]
        let ``ApproximatelyEqual (double precision) is correct for extreme values with overflow potential``() =
            Assert.ApproximatelyEqualEpsilon(System.Double.MaxValue, System.Double.MaxValue);
            Assert.NotApproximatelyEqualEpsilon(System.Double.MaxValue, -System.Double.MaxValue);
            Assert.NotApproximatelyEqualEpsilon(-System.Double.MaxValue, System.Double.MaxValue);
            Assert.NotApproximatelyEqualEpsilon(System.Double.MaxValue, System.Double.MaxValue / 2.0);
            Assert.NotApproximatelyEqualEpsilon(System.Double.MaxValue, -System.Double.MaxValue / 2.0);
            Assert.NotApproximatelyEqualEpsilon(-System.Double.MaxValue, System.Double.MaxValue / 2.0);

        [<Fact>]
        let ``ApproximatelyEqual (double precision) is correct for values involving infinities``() =
            Assert.ApproximatelyEqualEpsilon(System.Double.PositiveInfinity, System.Double.PositiveInfinity);
            Assert.ApproximatelyEqualEpsilon(System.Double.NegativeInfinity, System.Double.NegativeInfinity);
            Assert.NotApproximatelyEqualEpsilon(System.Double.NegativeInfinity, System.Double.PositiveInfinity);
            Assert.NotApproximatelyEqualEpsilon(System.Double.PositiveInfinity, System.Double.MaxValue);
            Assert.NotApproximatelyEqualEpsilon(System.Double.NegativeInfinity, -System.Double.MaxValue);

        [<Fact>]
        let ``ApproximatelyEqual (double precision) is correct for values involving NaN``() =
            Assert.NotApproximatelyEqualEpsilon(System.Double.NaN, System.Double.NaN);
            Assert.NotApproximatelyEqualEpsilon(System.Double.NaN, 0.0);
            Assert.NotApproximatelyEqualEpsilon(-0.0, System.Double.NaN);
            Assert.NotApproximatelyEqualEpsilon(System.Double.NaN, -0.0);
            Assert.NotApproximatelyEqualEpsilon(0.0, System.Double.NaN);
            Assert.NotApproximatelyEqualEpsilon(System.Double.NaN, System.Double.PositiveInfinity);
            Assert.NotApproximatelyEqualEpsilon(System.Double.PositiveInfinity, System.Double.NaN);
            Assert.NotApproximatelyEqualEpsilon(System.Double.NaN, System.Double.NegativeInfinity);
            Assert.NotApproximatelyEqualEpsilon(System.Double.NegativeInfinity, System.Double.NaN);
            Assert.NotApproximatelyEqualEpsilon(System.Double.NaN, System.Double.MaxValue);
            Assert.NotApproximatelyEqualEpsilon(System.Double.MaxValue, System.Double.NaN);
            Assert.NotApproximatelyEqualEpsilon(System.Double.NaN, -System.Double.MaxValue);
            Assert.NotApproximatelyEqualEpsilon(-System.Double.MaxValue, System.Double.NaN);
            Assert.NotApproximatelyEqualEpsilon(System.Double.NaN, System.Double.Epsilon);
            Assert.NotApproximatelyEqualEpsilon(System.Double.Epsilon, System.Double.NaN);
            Assert.NotApproximatelyEqualEpsilon(System.Double.NaN, -System.Double.Epsilon);
            Assert.NotApproximatelyEqualEpsilon(-System.Double.Epsilon, System.Double.NaN);

        [<Fact>]
        let ``ApproximatelyEqual (double precision) is correct for values on opposite sides of 0``() =
            Assert.NotApproximatelyEqualEpsilon(1.000000001, -1.0);
            Assert.NotApproximatelyEqualEpsilon(-1.0, 1.000000001);
            Assert.NotApproximatelyEqualEpsilon(-1.000000001, 1.0);
            Assert.NotApproximatelyEqualEpsilon(1.0, -1.000000001);
            Assert.ApproximatelyEqualEpsilon(10.0 * System.Double.Epsilon, 10.0 * -System.Double.Epsilon);
            Assert.NotApproximatelyEqualEpsilon(100000000000.0 * System.Double.Epsilon, 100000000000.0 * -System.Double.Epsilon);

        [<Fact>]
        let ``ApproximatelyEqual (double precision) is correct for values very close to 0``() =
            Assert.ApproximatelyEqualEpsilon(System.Double.Epsilon, System.Double.Epsilon);
            Assert.ApproximatelyEqualEpsilon(System.Double.Epsilon, -System.Double.Epsilon);
            Assert.ApproximatelyEqualEpsilon(-System.Double.Epsilon, System.Double.Epsilon);
            Assert.ApproximatelyEqualEpsilon(System.Double.Epsilon, 0.0);
            Assert.ApproximatelyEqualEpsilon(0.0, System.Double.Epsilon);
            Assert.ApproximatelyEqualEpsilon(-System.Double.Epsilon, 0.0);
            Assert.ApproximatelyEqualEpsilon(0.0, -System.Double.Epsilon);

            Assert.NotApproximatelyEqualEpsilon(0.000000001, -System.Double.Epsilon);
            Assert.NotApproximatelyEqualEpsilon(0.000000001, System.Double.Epsilon);
            Assert.NotApproximatelyEqualEpsilon(System.Double.Epsilon, 0.000000001);
            Assert.NotApproximatelyEqualEpsilon(-System.Double.Epsilon, 0.000000001);

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module ``ApproximatelyEquivalent (tolerance diff)`` =
        [<Fact>]
        let ``ApproximatelyEquivalent correctly approximates equivalence where the difference falls below the tolerance``() =
            let a = 0.0001f
            let b = 0.00019f
            Assert.NotEqual(a,b)
            Assert.True(MathHelper.ApproximatelyEquivalent(a, b, 0.0001f))

        [<Fact>]
        let ``ApproximatelyEquivalent correctly approximates equivalence where the difference is the tolerance``() =
            let a = 0.0001f
            let b = 0.0002f
            Assert.NotEqual(a,b)
            Assert.True(MathHelper.ApproximatelyEquivalent(a, b, 0.0001f))

        [<Fact>]
        let ``ApproximatelyEquivalent correctly approximates inequivalence where the difference exceeds the tolerance``() =
            let a = 0.0001f
            let b = 0.00021f
            Assert.NotEqual(a,b)
            Assert.False(MathHelper.ApproximatelyEquivalent(a, b, 0.0001f))

        [<Fact>]
        let ``ApproximatelyEquivalent reports very different values as non-equal even with a high tolerance``() =
            let a = 3.0f
            let b = 1.0f
            Assert.NotEqual(a,b)
            Assert.False(MathHelper.ApproximatelyEquivalent(a, b, 1.0f))

        [<Fact>]
        let ``ApproximatelyEquivalent works with single zero value``() =
            let a = 1.0f
            let b = 0.0f
            Assert.NotEqual(a,b)
            Assert.False(MathHelper.ApproximatelyEquivalent(a, b, 0.0001f))

        [<Fact>]
        let ``ApproximatelyEquivalent works with both zero values``() =
            let a = 0.0f
            let b = 0.0f
            Assert.Equal(a,b)
            Assert.True(MathHelper.ApproximatelyEquivalent(a, b, 0.0001f))
