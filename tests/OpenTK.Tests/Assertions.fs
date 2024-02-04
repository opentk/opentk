namespace OpenTK.Tests

open Xunit
open FsCheck
open FsCheck.Xunit
open System
open System
open System
open OpenTK
open OpenTK.Mathematics

[<AutoOpen>]
module private AssertHelpers =
    [<Literal>]
    let private BitAccuracy = 16

    [<Literal>]
    let private EquivalenceTolerance = 0.00005f

    let approxEq a b = MathHelper.ApproximatelyEquivalent(a, b, EquivalenceTolerance)
    let approxEqEpsilon a b eps = MathHelper.ApproximatelyEquivalent(a, b, float32(eps))

    let approxEqDelta a b = MathHelper.ApproximatelyEqual(a, b, BitAccuracy)

    let approxEqSingleEpsilon a b = MathHelper.ApproximatelyEqualEpsilon(a, b, 0.00001f)
    let approxEqDoubleEpsilon a b = MathHelper.ApproximatelyEqualEpsilon(a, b, 0.00001)

    let approxEqSingleEpsilonWithError (a, b, c : float32) = MathHelper.ApproximatelyEqualEpsilon(a, b, c)
    let approxEqDoubleEpsilonWithError (a, b, c : float) = MathHelper.ApproximatelyEqualEpsilon(a, b, c)

    let anyZero2 (a : Vector2) = (approxEq a.X 0.0f || approxEq a.Y 0.0f)
    let anyZero3 (a : Vector3) = (approxEq a.X 0.0f || approxEq a.Y 0.0f || approxEq a.Z 0.0f)
    let anyZero4 (a : Vector4) = (approxEq a.X 0.0f || approxEq a.Y 0.0f || approxEq a.Z 0.0f || approxEq a.W 0.0f)
    
    /// not equal with an epsilon value.
    let neqEpsilon a b epsilon = not <| approxEqSingleEpsilonWithError(a, b, epsilon)

    let neqTolerance a b tol = not <| approxEqEpsilon a b tol

/// We use a full type here instead of a module, as the overloading semantics are more suitable for our desired goal.
[<Sealed>]
type internal Assert =

    static member ApproximatelyEquivalent(a : Vector2,b : Vector2) =
        if not <| approxEq a.X b.X && approxEq a.Y b.Y then raise <| new Xunit.Sdk.EqualException(a,b)

    static member ApproximatelyEquivalent(a : Vector3,b : Vector3) =
        if not <| approxEq a.X b.X && approxEq a.Y b.Y && approxEq a.Z b.Z then raise <| new Xunit.Sdk.EqualException(a,b)

    static member ApproximatelyEquivalent(a : Vector4,b : Vector4) =
        if not <| approxEq a.X b.X && approxEq a.Y b.Y && approxEq a.Z b.Z && approxEq a.W b.W then
            raise <| new Xunit.Sdk.EqualException(a,b)

    static member ApproximatelyEquivalent(a : float32,b : float32) =
        if not <| approxEq a b then raise <| new Xunit.Sdk.EqualException(a,b)

    static member ApproximatelyEquivalent(a : Color4, b : Color4, epsilon:float32) =
        if not <| approxEqEpsilon a.R b.R epsilon && approxEqEpsilon a.G b.G epsilon && approxEqEpsilon a.B b.B epsilon && approxEqEpsilon a.A b.A epsilon then
            raise <| new Xunit.Sdk.EqualException(a,b)

    static member ApproximatelyEqualEpsilon(a : Vector2, b : Vector2, epsilon:float32) =
        if neqEpsilon a.X b.X epsilon || neqEpsilon a.Y b.Y epsilon then
            raise <| new Xunit.Sdk.EqualException(a,b)

    static member ApproximatelyEqualEpsilon(a : Vector3, b : Vector3, epsilon:float32) =
        if neqEpsilon a.X b.X epsilon || neqEpsilon a.Y b.Y epsilon || neqEpsilon a.Z b.Z epsilon then
            raise <| new Xunit.Sdk.EqualException(a,b)

    static member ApproximatelyEqualEpsilon(a : Vector3, b : Vector3, epsilon:Vector3) =
        if neqEpsilon a.X b.X epsilon.X || neqEpsilon a.Y b.Y epsilon.Y || neqEpsilon a.Z b.Z epsilon.Z then
            raise <| new Xunit.Sdk.EqualException(a,b)

    static member ApproximatelyEqualEpsilon(a : Vector4, b : Vector4, epsilon:float32) =
        if neqEpsilon a.X b.X epsilon || neqEpsilon a.Y b.Y epsilon || neqEpsilon a.Z b.Z epsilon || neqEpsilon a.W b.W epsilon then
            raise <| new Xunit.Sdk.EqualException(a,b)

    static member ApproximatelyEqualEpsilon(a : float32, b : float32) =
        if not <| approxEqSingleEpsilon a b then raise <| new Xunit.Sdk.EqualException(a,b)

    static member ApproximatelyEqualEpsilon(a : float32, b : float32, c : float32) =
        if not <| approxEqSingleEpsilonWithError(a, b, c) then raise <| new Xunit.Sdk.EqualException(a,b)

    static member ApproximatelyEqualEpsilon(a : float, b : float) =
        if not <| approxEqDoubleEpsilon a b then raise <| new Xunit.Sdk.EqualException(a,b)

    static member ApproximatelyEqualEpsilon(a : float, b : float, c : float) =
        if not <| approxEqDoubleEpsilonWithError(a, b, c) then raise <| new Xunit.Sdk.EqualException(a,b)

    static member ApproximatelyEqualDelta(a : float32, b : float32, c : float32) =
        if not <| approxEqEpsilon a b c then raise <| new Xunit.Sdk.EqualException(a,b)

    static member ApproximatelyEqualDelta(a : Vector3, b : Vector3, tol : Vector3) =
        if neqTolerance a.X b.X tol.X || neqTolerance a.Y b.Y tol.Y || neqTolerance a.Z b.Z tol.Z then
            raise <| new Xunit.Sdk.EqualException(a,b)

    static member ApproximatelyEqualDelta(a : Vector2, b : Vector2, tol : Vector2) =
        if neqTolerance a.X b.X tol.X || neqTolerance a.Y b.Y tol.Y then
            raise <| new Xunit.Sdk.EqualException(a,b)

    static member NotApproximatelyEqualEpsilon(a : float32, b : float32) =
        if approxEqSingleEpsilon a b then raise <| new Xunit.Sdk.EqualException(a,b)

    static member NotApproximatelyEqualEpsilon(a : float32, b : float32, c : float32) =
        if approxEqSingleEpsilonWithError(a, b, c) then raise <| new Xunit.Sdk.EqualException(a,b)


    static member NotApproximatelyEqualEpsilon(a : float, b : float) =
        if approxEqDoubleEpsilon a b then raise <| new Xunit.Sdk.EqualException(a,b)

    static member NotApproximatelyEqualEpsilon(a : float, b : float, c : float) =
        if approxEqDoubleEpsilonWithError(a, b, c) then raise <| new Xunit.Sdk.EqualException(a,b)

    static member ThrowsIndexExn(f:unit -> unit) = Assert.Throws<IndexOutOfRangeException>(f) |> ignore

    static member ThrowsArgOutOfRangeExn(f:unit -> unit) = Assert.Throws<ArgumentOutOfRangeException>(f) |> ignore

    static member ApproximatelyEqual(a : float32, b : float32) =
        if not <| approxEqDelta a b then raise <| new Xunit.Sdk.EqualException(a, b)

    static member EpsilonFromValue4Digits(v : float32) =
        MathF.Max(MathF.Pow(10.0f, MathF.Floor(MathF.Log10(MathF.Abs(v))) - 4.0f), 0.0001f)

    static member AllComponentsPositiveOrZero(v : Vector2) =
        if not (v.X >= 0.0f && v.Y >= 0.0f) then
            raise <| new Xunit.Sdk.NotInRangeException(v, Vector2.Zero, null);

    static member AllComponentsPositiveOrZero(v : Vector3) =
        if not (v.X >= 0.0f && v.Y >= 0.0f && v.Z >= 0.0f) then
            raise <| new Xunit.Sdk.NotInRangeException(v, Vector3.Zero, null);
