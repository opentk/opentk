namespace OpenToolkit.Tests

open Xunit
open OpenToolkit.Windowing.Common.Input

module KeyboardState =
    [<Fact>]
    let ``Test Exception on using invalid keys`` () =
        let keyboardState = KeyboardState();

        let fail key =
            (fun() -> keyboardState.IsKeyDown(key) |> ignore) |> Assert.ThrowsArgOutOfRangeExn
            (fun() -> keyboardState.IsKeyUp(key) |> ignore) |> Assert.ThrowsArgOutOfRangeExn
            (fun() -> keyboardState.[key] |> ignore) |> Assert.ThrowsArgOutOfRangeExn
            (fun() -> keyboardState.SetKeyState(key, true) |> ignore) |> Assert.ThrowsArgOutOfRangeExn

        let outOfRange = LanguagePrimitives.EnumOfValue((LanguagePrimitives.EnumToValue(Key.LastKey) + 1))
        fail Key.Unknown
        fail outOfRange

    [<Fact>]
    let ``Test setting keys️`` () =
        let mutable keyboardState = KeyboardState()

        for value in seq { 1 .. LanguagePrimitives.EnumToValue Key.LastKey } do
            let value = LanguagePrimitives.EnumOfValue value

            Assert.False(keyboardState.IsKeyDown value)
            keyboardState.SetKeyState(value, true)
            Assert.True(keyboardState.IsKeyDown value)
            keyboardState.SetKeyState(value, false)
            Assert.False(keyboardState.IsKeyDown value)

    [<Fact>]
    let ``Equality`` () =
        let mutable a = KeyboardState()
        let mutable b = KeyboardState()

        Assert.Equal(a, b);
        Assert.Equal(a.GetHashCode(), b.GetHashCode());
        a.SetKeyState(Key.A, true);
        Assert.NotEqual(a, b);
        b.SetKeyState(Key.A, true);
        Assert.Equal(a, b);
        Assert.Equal(a.GetHashCode(), b.GetHashCode());

    [<Fact>]
    let ``Any Key Down`` () =
        let mutable a = KeyboardState()

        Assert.False a.IsAnyKeyDown
        a.SetKeyState(Key.A, true)
        Assert.True a.IsAnyKeyDown
