// Learn more about F# at http://fsharp.org

open System

open OpenToolkit.Windowing.Desktop
open OpenToolkit.Windowing.Common

type Window() =
    inherit GameWindow(GameWindowSettings.Default, NativeWindowSettings.Default)
    do
        FooBar.GL.glGetError()
        |> printfn "%A"
    override this.OnRenderFrame(sender: obj, e : FrameEventArgs) : unit =
        FooBar.GL.glClear(FooBar.ClearBufferMask.GL_COLOR_BUFFER_BIT |> uint32)
        FooBar.GL.glGetError()
        |> printfn "%A"
        // FooBar.GL.glClearColor(1.f, 0.f, 0.f, 1.f)
        // FooBar.GL.glGetError()
        // |> printfn "%A"
        // FooBar.GL.glFinish()
        base.OnRenderFrame (sender, e) 

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    use window = new Window()
    window.Run()
    0 // return an integer exit code
