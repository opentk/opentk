namespace OpenTK.Tests

open Xunit
open FsCheck
open FsCheck.Xunit
open System
open OpenTK

[<AutoOpen>]
module private AssertHelpers =
    [<Literal>]
    let private BitAccuracy = 10

    let approxEq a b = MathHelper.ApproximatelyEqual(a,b,BitAccuracy)

/// We use a full type here instead of a module, as the overloading semantics are more suitable for our desired goal.
[<Sealed>]
type internal Assert =

    static member ApproximatelyEqual(a : Vector2,b : Vector2) =
        if not <| approxEq a.X b.X && approxEq a.Y b.Y then raise <| new Xunit.Sdk.EqualException(a,b)

    static member ApproximatelyEqual(a : Vector3,b : Vector3) =
        if not <| approxEq a.X b.X && approxEq a.Y b.Y && approxEq a.Z b.Z then raise <| new Xunit.Sdk.EqualException(a,b)

    static member ApproximatelyEqual(a : Vector4,b : Vector4) =
        if not <| approxEq a.X b.X && approxEq a.Y b.Y && approxEq a.Z b.Z && approxEq a.W b.W then
            raise <| new Xunit.Sdk.EqualException(a,b)

    static member ApproximatelyEqual(a : float32,b : float32) =
        if not <| approxEq a b then raise <| new Xunit.Sdk.EqualException(a,b)
