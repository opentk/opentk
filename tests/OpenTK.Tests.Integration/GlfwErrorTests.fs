namespace OpenTK.Tests.Integration

open System
open Xunit
open OpenTK.Windowing.Common
open OpenTK.Windowing.Desktop
open OpenTK.Windowing.GraphicsLibraryFramework

[<Collection("Gamewindow tests")>]
module GlfwErrors =
    [<Fact>]
    let ``Native errors return safely and remain available through GetError`` () =
        GLFWProvider.CheckForMainThread <- false
        GLFWProvider.EnsureInitialized()
        let mutable description = ""
        GLFW.GetError(&description) |> ignore

        // This deterministically invokes the default callback through GLFW.
        // Throwing across that native frame aborts the process on Linux.
        GLFW.InitHint(enum<InitHintInt> 0, 0)
        Assert.Equal(ErrorCode.InvalidEnum, GLFW.GetError(&description))
        Assert.False(String.IsNullOrEmpty(description))
        Assert.Equal(ErrorCode.NoError, GLFW.GetError(&description))

    [<Fact>]
    let ``Clipboard getter tolerates unavailable text`` () =
        GLFWProvider.CheckForMainThread <- false
        let settings = NativeWindowSettings()
        settings.API <- ContextAPI.NoAPI
        settings.StartVisible <- false
        use window = new NativeWindow(settings)
        let mutable description = ""
        GLFW.GetError(&description) |> ignore

        let text = window.ClipboardString
        let error = GLFW.GetError(&description)
        if isNull text then
            Assert.Equal(ErrorCode.FormatUnavailable, error)
        else
            Assert.Equal(ErrorCode.NoError, error)
