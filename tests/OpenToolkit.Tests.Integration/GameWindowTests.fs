namespace OpenToolkit.Tests.Integration

open Xunit
open FsCheck
open FsCheck.Xunit
open System
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
        let openGW() = new GameWindow(GameWindowSettings.Default, NativeWindowSettings.Default)
    
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

        [<Fact(Skip = "This causes the test runner to freeze. needs investigation")>]
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
            gw.Close()
            Assert.Equal([], signals)
            gw.ProcessEvents()
            Assert.Equal(["Closing"; "Closed"], signals)

    module Sizes =
        [<Fact>]
        let ``Updates to Width take effect`` () =
            use gw = openGW()
            let oldWidth = gw.Width
            let newWidth = oldWidth + 1
            gw.Width <- newWidth
            Assert.Equal(newWidth, gw.Width)
//
        [<Fact>]
        let ``Updates to Height take effect`` () =
            use gw = openGW()
            let oldHeight = gw.Height
            let newHeight = oldHeight + 1
            gw.Height <- newHeight
            Assert.Equal(newHeight, gw.Height)
//
        [<Fact>]
        let ``Updates to Size take effect`` () =
            use gw = openGW()
            let oldSize = gw.Size
            let newSize = new Vector2i(oldSize.X + 1, oldSize.Y + 1)
            gw.Size <- newSize
            Assert.Equal(newSize, gw.Size)
//
        [<Fact>]
        let ``Updates to ClientRectangle.Size take effect`` () =
            use gw = openGW()
            let oldSize = gw.ClientRectangle.Size
            let newSize = Vector2i(oldSize.X + 1, oldSize.Y + 1)
            let newRect = Box2i(gw.ClientRectangle.Min, gw.ClientRectangle.Min + newSize)
            gw.ClientRectangle <- newRect
            Assert.Equal(newRect, gw.ClientRectangle)
//
        [<Fact>]
        let ``Updates to Bounds.Size take effect`` () =
            use gw = openGW()
            let oldSize = gw.Bounds.Size
            let newSize = Vector2i(oldSize.X + 1, oldSize.Y + 1)
            let newRect = Box2i(gw.ClientRectangle.Min, gw.ClientRectangle.Min + newSize)
            gw.Bounds <- newRect
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
            Assert.Equal(newX, gw.X)

        [<Fact>]
        let ``Updates to Y take effect`` () =
            use gw = openGW()
            let oldY = gw.Y
            let newY = oldY + 1
            gw.Y <- newY
            Assert.Equal(newY, gw.Y)

        [<Fact>]
        let ``Updates to Location take effect`` () =
            use gw = openGW()
            let oldLocation = gw.Location
            let newLocation = Vector2i(oldLocation.X + 1, oldLocation.Y + 1)
            gw.Location <- newLocation
            Assert.Equal(newLocation, gw.Location)

        [<Fact>]
        let ``Location equals Bounds.Min`` () =
            use gw = openGW()
            Assert.Equal(gw.Location, gw.Bounds.Min)

        [<Fact>]
        let ``X and Y equals Location`` () =
            use gw = openGW()
            Assert.Equal(Vector2i(gw.X, gw.Y), gw.Location)

        [<Fact>]
        let ``ClientRectangle.Location is zero`` () =
            use gw = openGW()
            Assert.Equal(Vector2i.Zero, gw.ClientRectangle.Min)

    module Borders =
        [<Fact>]
        let ``Updates to BorderStyle take effect`` () =
            use gw = openGW()
            gw.WindowBorder <- WindowBorder.Fixed
            Assert.Equal(WindowBorder.Fixed, gw.WindowBorder)
            gw.WindowBorder <- WindowBorder.Hidden
            Assert.Equal(WindowBorder.Hidden, gw.WindowBorder)
            gw.WindowBorder <- WindowBorder.Resizable
            Assert.Equal(WindowBorder.Resizable, gw.WindowBorder)
//
        [<Fact>]
        let ``Can resize fixed borders`` () =
            use gw = openGW()
            gw.WindowBorder <- WindowBorder.Fixed
            let oldSize = gw.Size
            let newSize = Vector2i(oldSize.X + 1, oldSize.Y + 1)
            gw.Size <- newSize
            Assert.Equal(newSize, gw.Size)

        [<Fact>]
        let ``Can resize hidden borders`` () =
            use gw = openGW()
            gw.WindowBorder <- WindowBorder.Hidden
            let oldSize = gw.Size
            let newSize = Vector2i(oldSize.X + 1, oldSize.Y + 1)
            gw.Size <- newSize
            Assert.Equal(newSize, gw.Size)
