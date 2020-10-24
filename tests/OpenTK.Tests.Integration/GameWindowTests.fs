namespace OpenTK.Tests.Integration

open Xunit
open FsCheck
open FsCheck.Xunit
open System
open System.Diagnostics
open System.Runtime.InteropServices
open OpenTK
open OpenTK.Mathematics
open OpenTK.Windowing.Common
open OpenTK.Windowing.Desktop

/// we mark this as a collection so they run in a single thread; this avoids race conditions on the windowing.
[<Collection("Gamewindow tests")>]
module GameWindow =
    [<AutoOpen>]
    module Helpers =
        let settings = NativeWindowSettings.Default
        let TryProcessEvents (window:NativeWindow) =
            let st = new Stopwatch()
            let mutable run = true
            while st.ElapsedMilliseconds < 1000L && run do
                st.Restart()
                run <- (window.ProcessEvents(1.0))
        let openGW() =
            let gw = new GameWindow(GameWindowSettings.Default, NativeWindowSettings.Default)
            gw
    
    module General =
        [<Fact>]
        let ``Can create and close GameWindow`` () =
            use gw = openGW()
            gw.Close()

        [<Fact>]
        let ``GameWindow exists after creation`` () =
            use gw = openGW()
            Assert.True(gw.Exists)
            gw.Close()

        [<Fact()>]
        let ``Can close GameWindow on UpdateFrame`` () =
            use gw = openGW()
            gw.add_UpdateFrame(fun _ -> gw.Close())
            gw.Run()

        [<Fact>]
        let ``Closing event is sent before closed`` () =
            use gw = openGW()
            let signals = System.Collections.Generic.List<string>()
            gw.add_Closing(fun _ -> signals.Add("Closing"))
            gw.add_Closed(fun _ -> signals.Add("Closed"))
            
            Assert.Equal([], signals)
            gw.Close()
            TryProcessEvents(gw)
            Assert.Equal(["Closing"; "Closed"], signals)

    module Sizes =
        [<Fact>]
        let ``Updates to Size take effect`` () =
            use gw = openGW()
            let oldSize = gw.Size
            let newSize = new Vector2i(oldSize.X + 1, oldSize.Y + 1)
            gw.Size <- newSize
            TryProcessEvents(gw)
            Assert.Equal(newSize, gw.Size)
//
        [<Fact>]
        let ``Updates to ClientRectangle.Size take effect`` () =
            use gw = openGW()
            let oldSize = gw.ClientRectangle.Size
            let newSize = Vector2i(oldSize.X + 1, oldSize.Y + 1)
            let newRect = Box2i(gw.ClientRectangle.Min, gw.ClientRectangle.Min + newSize)
            gw.ClientRectangle <- newRect
            TryProcessEvents(gw)
            Assert.Equal(newRect, gw.ClientRectangle)
//
        [<Fact>]
        let ``Updates to Bounds.Size take effect`` () =
            use gw = openGW()
            let oldSize = gw.Bounds.Size
            let newSize = Vector2i(oldSize.X + 1, oldSize.Y + 1)
            let newRect = Box2i(gw.ClientRectangle.Min, gw.ClientRectangle.Min + newSize)
            gw.Bounds <- newRect
            TryProcessEvents(gw)
            Assert.Equal(newRect, gw.Bounds)

        [<Fact>]
        let ``ClientSize equals ClientRectangle.Size`` () =
            use gw = openGW()
            Assert.Equal(gw.ClientSize, gw.ClientRectangle.Size)

        [<Fact>]
        let ``Size equals Bounds.Size`` () =
            use gw = openGW()
            Assert.Equal(gw.Size, gw.Bounds.Size)

    module Locations =
        [<Fact>]
        let ``Updates to Location take effect`` () =
            use gw = openGW()
            let oldLocation = gw.Location
            let newLocation = Vector2i(oldLocation.X + 1, oldLocation.Y + 1)
            gw.Location <- newLocation
            TryProcessEvents(gw)
            Assert.Equal(newLocation, gw.Location)

        [<Fact>]
        let ``Location equals Bounds.Min`` () =
            use gw = openGW()
            Assert.Equal(gw.Location, gw.Bounds.Min)

        [<Fact(Skip = "Initial position not correct on some systems.")>]
        let ``ClientRectangle.Location is zero`` () =
            use gw = openGW()
            Assert.Equal(Vector2i.Zero, gw.ClientRectangle.Min)

    module Borders =
        [<Fact>]
        let ``Updates to BorderStyle take effect`` () =
            use gw = openGW()
            gw.WindowBorder <- WindowBorder.Fixed
            TryProcessEvents(gw)
            Assert.Equal(WindowBorder.Fixed, gw.WindowBorder)
            gw.WindowBorder <- WindowBorder.Hidden
            TryProcessEvents(gw)
            Assert.Equal(WindowBorder.Hidden, gw.WindowBorder)
            gw.WindowBorder <- WindowBorder.Resizable
            TryProcessEvents(gw)
            Assert.Equal(WindowBorder.Resizable, gw.WindowBorder)
//
        [<Fact>]
        let ``Can resize fixed borders`` () =
            use gw = openGW()
            gw.WindowBorder <- WindowBorder.Fixed
            TryProcessEvents(gw)
            let oldSize = gw.Size
            let newSize = Vector2i(oldSize.X + 1, oldSize.Y + 1)
            gw.Size <- newSize
            TryProcessEvents(gw)
            Assert.Equal(newSize, gw.Size)

        [<Fact>]
        let ``Can resize hidden borders`` () =
            use gw = openGW()
            gw.WindowBorder <- WindowBorder.Hidden
            TryProcessEvents(gw)
            let oldSize = gw.Size
            let newSize = Vector2i(oldSize.X + 1, oldSize.Y + 1)
            gw.Size <- newSize
            TryProcessEvents(gw)
            Assert.Equal(newSize, gw.Size)
//
    module Dpi =
        [<Fact>]
        let ``Can get monitor dpi`` () =
            use gw = openGW()
            let (success, dpix, dpiy) = gw.TryGetCurrentMonitorDpi()
            () |> ignore

        [<Fact>]
        let ``Can get monitor scale`` () =
            use gw = openGW()
            let (success, scalex, scaley) = gw.TryGetCurrentMonitorScale()
            () |> ignore

        [<Fact>]
        let ``Can get monitor raw dpi`` () =
            use gw = openGW()
            let (success, dpix, dpiy) = gw.TryGetCurrentMonitorScale()
            () |> ignore

        let defaultDpi () =
            if RuntimeInformation.IsOSPlatform(OSPlatform.OSX) then
                72.0f
            else
                96.0f
    
        let fuzzyequals(a : float32, b : float32, epsilon : float32) =
            -epsilon < a - b && a - b < epsilon

        [<Fact>]
        let ``Does scale and monitor dpi match`` () =
            use gw = openGW()
            let (dpisuccess, dpix, dpiy) = gw.TryGetCurrentMonitorDpi()
            let (scalesuccess, scalex, scaley) = gw.TryGetCurrentMonitorScale()
            Assert.Equal(dpisuccess, scalesuccess) // basically a fake xor.
            if dpisuccess && scalesuccess then
                Assert.True(fuzzyequals(dpix/scalex, defaultDpi(), 1.0f)) // precision is up to discussion.
                Assert.True(fuzzyequals(dpiy/scaley, defaultDpi(), 1.0f))

// module UpdateFrequency =
        [<Fact>]
        let ``Does UpdateFrequency limit the timing of UpdateFrame`` () =
            use gw = openGW()
            gw.UpdateFrequency <- 10.0
            let mutable calls = 0
            let mutable reportedElapsed = 0.0
            let totalCalls = 10
            let expectedElapsed = 1.0/gw.UpdateFrequency * (float totalCalls)
            gw.add_UpdateFrame(fun e -> calls <- calls+1; reportedElapsed <- reportedElapsed+e.Time; if calls = totalCalls then gw.Close())
            let st = new Stopwatch()
            st.Start()
            gw.Run()
            st.Stop();
            let realElapsed = st.Elapsed.TotalSeconds
            Assert.True(Math.Abs(realElapsed - reportedElapsed) <= 0.1, sprintf "Reported %f but actually took %f" reportedElapsed realElapsed)
            Assert.True(Math.Abs(expectedElapsed - realElapsed) <= 0.1, sprintf "Took %f instead of the expected %f" realElapsed expectedElapsed)

//
    module RenderFrequency =
        [<Fact>]
        let ``Does RenderFrequency limit the timing of RenderFrame`` () =
            use gw = openGW()
            gw.RenderFrequency <- 10.0
            let mutable calls = 0
            let mutable reportedElapsed = 0.0
            let totalCalls = 10
            let expectedElapsed = 1.0/gw.RenderFrequency * (float totalCalls)
            gw.add_RenderFrame(fun e -> calls <- calls+1; reportedElapsed <- reportedElapsed+e.Time; if calls = totalCalls then gw.Close())
            let st = new Stopwatch()
            st.Start()
            gw.Run()
            st.Stop();
            let realElapsed = st.Elapsed.TotalSeconds
            Assert.True(Math.Abs(realElapsed - reportedElapsed) <= 0.1, sprintf "Reported %f but actually took %f" reportedElapsed realElapsed)
            Assert.True(Math.Abs(expectedElapsed - realElapsed) <= 0.1, sprintf "Took %f instead of the expected %f" realElapsed expectedElapsed)
