namespace OpenTK.Tests

open FsCheck
open System
open OpenTK.Mathematics

/// An angle from -89 to +89
[<Struct>]
type AcuteAngle = AcuteAngle of float32

[<Struct>]
type Range = 
    struct
        val Start: float32
        val Stop: float32
        new(start: float32, stop: float32) = { Start = start; Stop = stop }
        override this.ToString (): string = $"({this.Start}, {this.Stop})"
    end

[<Struct>]
type PositiveRange = 
    struct
        val Start: float32
        val Stop: float32
        new(start: float32, stop: float32) = { Start = start; Stop = stop }
        override this.ToString (): string = $"({this.Start}, {this.Stop})"
    end

[<Struct>]
type PositiveFloat = PositiveFloat of float32

[<AutoOpen>]
module private Generators =
    let private isValidFloat f = not (Single.IsNaN f || Single.IsInfinity f || Single.IsInfinity (f * f) || f = Single.MinValue || f = Single.MaxValue)
    let private isValidDouble d = not (Double.IsNaN d || Double.IsInfinity d || Double.IsInfinity (d * d)|| d = Double.MinValue || d = Double.MaxValue)
    let singleArb = Arb.Default.Float32() |> Arb.toGen |> Gen.filter isValidFloat
    let single = singleArb |> Arb.fromGen

    let doubleArb = Arb.Default.Float() |> Arb.toGen |> Gen.filter isValidDouble
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

    let vec2d =
        doubleArb
        |> Gen.two
        |> Gen.map Vector2d
        |> Gen.filter (fun v -> not <| (Double.IsNaN v.Length || Double.IsInfinity v.Length ))
        |> Arb.fromGen

    let vec3 =
        singleArb
        |> Gen.three
        |> Gen.map Vector3
        |> Gen.filter (fun v -> not <| (Single.IsNaN v.Length || Single.IsInfinity v.Length ))
        |> Arb.fromGen

    let vec3d =
        doubleArb
        |> Gen.three
        |> Gen.map Vector3d
        |> Gen.filter (fun v -> not <| (Double.IsNaN v.Length || Double.IsInfinity v.Length))
        |> Arb.fromGen

    let vec4 =
        singleArb
        |> Gen.four
        |> Gen.map Vector4
        |> Gen.filter (fun v -> not <| (Single.IsNaN v.Length || Single.IsInfinity v.Length ))
        |> Arb.fromGen

    let vec4d =
        doubleArb
        |> Gen.four
        |> Gen.map Vector4d
        |> Gen.filter (fun v -> not <| (Double.IsNaN v.Length || Double.IsInfinity v.Length ))
        |> Arb.fromGen
    
    let vec2b =
        Arb.Default.Bool() |> Arb.toGen
        |> Gen.two
        |> Gen.map Vector2b
        |> Arb.fromGen

    let vec3b =
        Arb.Default.Bool() |> Arb.toGen
        |> Gen.three
        |> Gen.map Vector3b
        |> Arb.fromGen

    let vec4b =
        Arb.Default.Bool() |> Arb.toGen
        |> Gen.four
        |> Gen.map Vector4b
        |> Arb.fromGen

    let quat =
        singleArb
        |> Gen.four
        |> Gen.map (fun (x,y,z,w) -> Quaternion(x,y,z,w) |> Quaternion.Normalize)
        |> Gen.filter (fun q -> not <| (Single.IsNaN q.Length || Single.IsInfinity q.Length ))
        |> Arb.fromGen

    let mat2 =
        singleArb
        |> Gen.four
        |> Gen.map Matrix2
        |> Arb.fromGen

    let mat2x3 =
        vec3
        |> Arb.toGen
        |> Gen.two
        |> Gen.map Matrix2x3
        |> Arb.fromGen

    let mat2x3d =
        vec3d
        |> Arb.toGen
        |> Gen.two
        |> Gen.map Matrix2x3d
        |> Arb.fromGen

    let mat2x4 =
        vec4
        |> Arb.toGen
        |> Gen.two
        |> Gen.map Matrix2x4
        |> Arb.fromGen

    let mat2x4d =
        vec4d
        |> Arb.toGen
        |> Gen.two
        |> Gen.map Matrix2x4d
        |> Arb.fromGen

    let mat3x2 =
        vec2
        |> Arb.toGen
        |> Gen.three
        |> Gen.map Matrix3x2
        |> Arb.fromGen

    let mat3x2d =
        vec2d
        |> Arb.toGen
        |> Gen.three
        |> Gen.map Matrix3x2d
        |> Arb.fromGen

    let mat3 =
        vec3
        |> Arb.toGen
        |> Gen.three
        |> Gen.map Matrix3
        |> Arb.fromGen

    let mat3x4 =
        vec4
        |> Arb.toGen
        |> Gen.three
        |> Gen.map Matrix3x4
        |> Arb.fromGen

    let mat3x4d =
        vec4d
        |> Arb.toGen
        |> Gen.three
        |> Gen.map Matrix3x4d
        |> Arb.fromGen

    let mat4x2 =
        vec2
        |> Arb.toGen
        |> Gen.four
        |> Gen.map Matrix4x2
        |> Arb.fromGen

    let mat4x2d =
        vec2d
        |> Arb.toGen
        |> Gen.four
        |> Gen.map Matrix4x2d
        |> Arb.fromGen

    let mat4x3 =
        vec3
        |> Arb.toGen
        |> Gen.four
        |> Gen.map Matrix4x3
        |> Arb.fromGen

    let mat4x3d =
        vec3d
        |> Arb.toGen
        |> Gen.four
        |> Gen.map Matrix4x3d
        |> Arb.fromGen

    let mat4 =
        vec4
        |> Arb.toGen
        |> Gen.four
        |> Gen.map Matrix4
        |> Arb.fromGen

    let mat4d =
        vec4d
        |> Arb.toGen
        |> Gen.four
        |> Gen.map Matrix4d
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
    
    
    let color4<'T when 'T :> IColorSpace4> =
        singleArb
        |> Gen.filter (fun x -> (0.0f <= x && x <= 1.0f))
        |> Gen.four
        |> Gen.map Color4<'T>
        |> Arb.fromGen

    let color3<'T when 'T :> IColorSpace3> =
        singleArb
        |> Gen.filter (fun x -> (0.0f <= x && x <= 1.0f))
        |> Gen.three
        |> Gen.map Color3<'T>
        |> Arb.fromGen
        
    let positiveFloat =
        singleArb
        |> Gen.map (fun x -> MathF.Abs(x))
        |> Arb.fromGen

    let range =
        singleArb
        // FIXME: As we are using this for parameters in projection matrices,
        // making the values too small will cause a loss of precision
        // in the entire matrix. So we avoid this.
        // - Noggin_bops 2024-11-25
        |> Gen.filter (fun x -> x > 0.0000001f)
        |> Gen.two
        |> Gen.filter (fun (x, y) -> (x < y))
        |> Gen.map Range
        |> Arb.fromGen

    let positiveRange =
        singleArb
        |> Gen.map (fun x -> MathF.Abs(x))
        // FIXME: As we are using this for the near and far plane of projection
        // matrices, making the near plane too close will cause a loss of precision
        // in the entire matrix. So we avoid this.
        // - Noggin_bops 2024-11-25
        |> Gen.filter (fun x -> x > 0.000001f)
        |> Gen.two
        |> Gen.filter (fun (x, y) -> (x < y))
        |> Gen.map PositiveRange
        |> Arb.fromGen

type OpenTKGen =
    static member Single() = single
    static member float32() = single
    static member Double() = double
    static member float() = double
    static member PositiveFloat() = positiveFloat
    static member Vector2() = vec2
    static member Vector2d() = vec2d
    static member Vector3() = vec3
    static member Vector3d() = vec3d
    static member Vector4() = vec4
    static member Vector4d() = vec4d
    static member Vector2b() = vec2b
    static member Vector3b() = vec3b
    static member Vector4b() = vec4b
    static member Quaternion() = quat
    static member Matrix2() = mat2
    static member Matrix2x3() = mat2x3
    static member Matrix2x3d() = mat2x3d
    static member Matrix2x4() = mat2x4
    static member Matrix2x4d() = mat2x4d
    static member Matrix3x2() = mat3x2
    static member Matrix3x2d() = mat3x2d
    static member Matrix3() = mat3
    static member Matrix3x4() = mat3x4
    static member Matrix3x4d() = mat3x4d
    static member Matrix4x2() = mat4x2
    static member Matrix4x2d() = mat4x2d
    static member Matrix4x3() = mat4x3
    static member Matrix4x3d() = mat4x3d
    static member Matrix4() = mat4
    static member Matrix4d() = mat4d
    static member Box2() = box2
    static member Box3() = box3
    static member AcuteAngle() = acuteAngle
    static member Color4() = color4
    static member Color3() = color3
    static member Range() = range
    static member PositiveRange() = positiveRange
