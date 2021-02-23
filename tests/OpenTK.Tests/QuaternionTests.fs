namespace OpenTK.Tests

open Xunit
open FsCheck.Xunit
open OpenTK.Mathematics

[<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
module Quaternion =
    [<AutoOpen>]
    module Helpers =
         //To verify the direction of an vector, just respect the 0 values and check against these.
         //The length of the vectors are ignored.
        let verifyDirection(expected:Vector3) (toTest:Vector3) =
            Assert.Equal(sign expected.X, sign toTest.X)
            Assert.Equal(sign expected.Y, sign toTest.Y)
            Assert.Equal(sign expected.Z, sign toTest.Z)
            
        let axes = [
            Vector3.UnitX
            Vector3.UnitY
            Vector3.UnitZ
        ]
        
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Constructors =
        [<Property>]
        let ``Constructors using equivalent constructors should be equivalent``(f1 : float32, f2 : float32, f3 : float32, f4 : float32) =
            let q1 = Quaternion(f1, f2, f3, f4)
            let q2 = Quaternion(Vector3(f1, f2, f3), f4)
            
            Assert.Equal(q1, q2)

            // Euler angles
            let q3 = Quaternion(f1, f2, f3)
            let q4 = Quaternion(Vector3(f1, f2, f3))

            Assert.Equal(q3, q4)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module EulerAngles =
        [<Property>]
        let ``AcuteAngle is in the correct range`` (AcuteAngle f) =
            Assert.True(f <= MathHelper.DegreesToRadians 89.0f)
            Assert.True(f >= MathHelper.DegreesToRadians -89.0f)

        [<Property>]
        let ``Quaternions produce approximatly the same values in euler angle roundtrip``(AcuteAngle a1, AcuteAngle a2, AcuteAngle a3) =
            let v1 = Vector3(a1, a2, a3)
            // q1 is mutable because CI is probably not recognizing the C# 'in' keyword and just treats it as a byref
            let mutable q1 = Quaternion.FromEulerAngles(v1)
            let v2 = Quaternion.ToEulerAngles(&q1)
            let q2 = Quaternion.FromEulerAngles(v2)

            Assert.ApproximatelyEqual(q1.X, q2.X);
            Assert.ApproximatelyEqual(q1.Y, q2.Y);
            Assert.ApproximatelyEqual(q1.Z, q2.Z);
            Assert.ApproximatelyEqual(q1.W, q2.W);
            
    [<Fact>]
    let ``Single axis as euler angles is converted to correct quaternion components``() =
        let test(v:Vector3) =
            let cut = Quaternion(v.X, v.Y, v.Z)
            verifyDirection cut.Xyz v
            
        axes |> List.iter test
        
    [<Fact>]
    let ``Single axis euler angles in vector3 is converted to correct quaternion components``() =
        let test(v:Vector3) =
            let cut = Quaternion(v)
            verifyDirection cut.Xyz v
            
        axes |> List.iter test
    
    [<Property>]
    let ``Quaternion euler angle construction methods produce consistent results``(v:Vector3) =
        let q1 = Quaternion(v)
        let q2 = Quaternion(v.X, v.Y, v.Z)
        let q3 = Quaternion.FromEulerAngles(v)
        let q4 = Quaternion.FromEulerAngles(v.X, v.Y, v.Z)
        let mutable q5 = Quaternion.Identity
        let mutable inV = v
        Quaternion.FromEulerAngles(&inV, &q5)
        
        let cases = [q2; q3; q4; q5]
        for case in cases do
             Assert.Equal(q1, case)
    
    [<Fact>]
    let ``Single rotation axis quaternion converts to correct axis angle representation``() =
        let test(v:Vector3) =
            let q = Quaternion(v)
            let mutable vec = Vector3()
            let mutable dontCare = 0.0f
            q.ToAxisAngle(&vec, &dontCare)
            verifyDirection v vec
            
        axes |> List.iter test

    //[<Property>]
    //let ``Quaternion to euler angle``(q:Quaternion) =
    //    let v1 = q.ToEulerAngles()
    //    let mutable inQ = q
    //    let mutable v2 = Vector3.Zero
    //    Quaternion.ToEulerAngles(&inQ, &v2)

    //    Assert.Equal(v1, v2)

