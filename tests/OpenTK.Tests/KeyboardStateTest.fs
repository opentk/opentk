namespace OpenTK.Tests

open OpenTK.Windowing.GraphicsLibraryFramework
open Xunit

module KeyboardState =
    [<Fact>]
    let ``Test Exception on using invalid keys`` () =
        let keyboardState = KeyboardState();

        let fail key =
            (fun() -> keyboardState.IsKeyDown(key) |> ignore) |> Assert.ThrowsArgOutOfRangeExn
            (fun() -> keyboardState.[key] |> ignore) |> Assert.ThrowsArgOutOfRangeExn
            (fun() -> keyboardState.SetKeyState(key, true) |> ignore) |> Assert.ThrowsArgOutOfRangeExn

        let outOfRange = LanguagePrimitives.EnumOfValue((LanguagePrimitives.EnumToValue(Keys.LastKey) + 1))
        fail Keys.Unknown
        fail outOfRange

    [<Fact>]
    let ``Test setting keys️`` () =
        let mutable keyboardState = KeyboardState()

        for value in seq { 1 .. LanguagePrimitives.EnumToValue Keys.LastKey } do
            let value = LanguagePrimitives.EnumOfValue value

            Assert.False(keyboardState.IsKeyDown value)
            keyboardState.SetKeyState(value, true)
            Assert.True(keyboardState.IsKeyDown value)
            keyboardState.SetKeyState(value, false)
            Assert.False(keyboardState.IsKeyDown value)

    [<Fact>]
    let ``Any Key Down`` () =
        let mutable a = KeyboardState()

        Assert.False a.IsAnyKeyDown
        a.SetKeyState(Keys.A, true)
        Assert.True a.IsAnyKeyDown
