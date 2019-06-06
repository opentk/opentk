namespace OpenToolkit.Tests

open Xunit
open FsCheck.Xunit
open OpenToolkit.Mathematics

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
