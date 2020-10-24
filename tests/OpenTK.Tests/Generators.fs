namespace OpenTK.Tests

open Xunit
open FsCheck
open FsCheck.Xunit
open System
open OpenTK
open OpenTK.Mathematics

/// An angle from -89 to +89
[<Struct>]
type AcuteAngle = AcuteAngle of float32

[<Struct>]
type Color4LDR = Color4LDR of Color4

[<AutoOpen>]
module private Generators =
    let private isValidFloat f = not (Single.IsNaN f || Single.IsInfinity f || Single.IsInfinity (f * f) || f = Single.MinValue || f = Single.MaxValue )
    let private isValidDouble d = not (Double.IsNaN d || Double.IsInfinity d || Double.IsInfinity (d * d)|| d = Double.MinValue || d = Double.MaxValue)
    let singleArb = Arb.Default.Float32() |> Arb.toGen |> Gen.filter isValidFloat
    let single = singleArb |> Arb.fromGen

    let double =
        Arb.Default.Float() |> Arb.toGen
        |> Gen.filter isValidDouble
        |> Arb.fromGen

    let vec2 =
        singleArb
        |> Gen.two
        |> Gen.map Vector2
        |> Gen.filter (fun v -> not <| (Single.IsNaN v.Length || Single.IsInfinity v.Length ))
        |> Arb.fromGen

    let vec3 =
        singleArb
        |> Gen.three
        |> Gen.map Vector3
        |> Gen.filter (fun v -> not <| (Single.IsNaN v.Length || Single.IsInfinity v.Length ))
        |> Arb.fromGen

    let vec4 =
        singleArb
        |> Gen.four
        |> Gen.map Vector4
        |> Gen.filter (fun v -> not <| (Single.IsNaN v.Length || Single.IsInfinity v.Length ))
        |> Arb.fromGen

    let quat =
        singleArb
        |> Gen.three
        |> Gen.map (fun (x,y,z) -> Quaternion(x,y,z,0.0f) |> Quaternion.Normalize)
        |> Gen.filter (fun q -> not <| (Single.IsNaN q.Length || Single.IsInfinity q.Length ))
        |> Arb.fromGen

    let mat2 =
        singleArb
        |> Gen.four
        |> Gen.map Matrix2
        |> Arb.fromGen

    let mat3 =
        vec3
        |> Arb.toGen
        |> Gen.three
        |> Gen.map Matrix3
        |> Arb.fromGen

    let mat4 =
        vec4
        |> Arb.toGen
        |> Gen.four
        |> Gen.map Matrix4
        |> Arb.fromGen

    let box2 =
        vec2
        |> Arb.toGen
        |> Gen.two
        |> Gen.map Box2
        |> Arb.fromGen

    let box3 =
        vec3
        |> Arb.toGen
        |> Gen.two
        |> Gen.map Box3
        |> Arb.fromGen

    /// Magical value taken from FsCheck source.
    /// Generates a float in the range [0;1] in a roughly uniform distribution.
    let stdFloatGen = Arb.generate<DoNotSize<uint64>> |> Gen.map (fun (DoNotSize n) -> (float (n >>> 11)) * (1.0 / float (1UL <<< 53)))     
    let acuteAngle = stdFloatGen |> Gen.map (fun f -> (float32 f - 0.5f) * MathHelper.DegreesToRadians 178.0f |> AcuteAngle) |> Arb.fromGen
    
    let color4HDR =
        singleArb
        |> Gen.filter (fun x -> x >= 0.0f)
        |> Gen.four
        |> Gen.map Color4
        |> Arb.fromGen

    let color4LDR =
        singleArb
        |> Gen.filter (fun x -> (x >= 0.0f && x <= 1.0f))
        |> Gen.four
        |> Gen.map Color4
        |> Arb.fromGen
        
type OpenTKGen =
    static member Single() = single
    static member float32() = single
    static member Double() = double
    static member float() = double
    static member Vector2() = vec2
    static member Vector3() = vec3
    static member Vector4() = vec4
    static member Quaternion() = quat
    static member Matrix2() = mat2
    static member Matrix3() = mat3
    static member Matrix4() = mat4
    static member Box2() = box2
    static member Box3() = box3
    static member AcuteAngle() = acuteAngle
    static member Color4LDR() = color4LDR
    static member Color4() = color4HDR
