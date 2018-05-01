namespace OpenTK.Tests

open Xunit
open FsCheck
open FsCheck.Xunit
open System
open OpenTK
open OpenTK.Mathematics

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
