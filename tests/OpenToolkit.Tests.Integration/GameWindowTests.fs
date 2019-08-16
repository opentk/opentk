namespace OpenToolkit.Tests.Integration

open Xunit
open FsCheck
open FsCheck.Xunit
open System
open System.Diagnostics
open System.Runtime.InteropServices
open OpenToolkit
open OpenToolkit.Mathematics
open OpenToolkit.Windowing.Common
open OpenToolkit.Windowing.Desktop

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
            gw.UpdateFrame.Add(fun _ -> gw.Close())
            gw.Run()

        [<Fact>]
        let ``Closing event is sent before closed`` () =
            use gw = openGW()
            let signals = System.Collections.Generic.List<string>()
            gw.Closing.Add(fun _ -> signals.Add("Closing"))
            gw.Closed.Add(fun _ -> signals.Add("Closed"))
            
            Assert.Equal([], signals)
            gw.Close()
            TryProcessEvents(gw)
            Assert.Equal(["Closing"; "Closed"], signals)

    module Sizes =
        [<Fact>]
        let ``Updates to Width take effect`` () =
            use gw = openGW()
            let oldWidth = gw.Width
            let newWidth = oldWidth + 1
            gw.Width <- newWidth
            TryProcessEvents(gw)
            Assert.Equal(newWidth, gw.Width)
//
        [<Fact>]
        let ``Updates to Height take effect`` () =
            use gw = openGW()
            let oldHeight = gw.Height
            let newHeight = oldHeight + 1
            Console.WriteLine("Did not set yet")
            gw.Height <- newHeight
            Console.WriteLine("Did not process yet")
            TryProcessEvents(gw)
            Assert.Equal(newHeight, gw.Height)
//
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

        [<Fact>]
        let ``Width and Height equals ClientSize`` () =
            use gw = openGW()
            Assert.Equal(Vector2i(gw.Width, gw.Height), gw.ClientSize)

    module Locations =
        [<Fact>]
        let ``Updates to X take effect`` () =
            use gw = openGW()
            let oldX = gw.X
            let newX = oldX + 1
            gw.X <- newX
            TryProcessEvents(gw)
            Assert.Equal(newX, gw.X)

        [<Fact>]
        let ``Updates to Y take effect`` () =
            use gw = openGW()
            let oldY = gw.Y
            let newY = oldY + 1
            gw.Y <- newY
            TryProcessEvents(gw)
            Assert.Equal(newY, gw.Y)

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

        [<Fact>]
        let ``X and Y equals Location`` () =
            use gw = openGW()
            Assert.Equal(Vector2i(gw.X, gw.Y), gw.Location)

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
