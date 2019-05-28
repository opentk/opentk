namespace OpenTK.Tests.Integration

open Xunit
open FsCheck
open FsCheck.Xunit
open System
open System.Runtime.InteropServices
open OpenTK

module GameWindow =
    module General =
        [<Fact>]
        let ``Can create and close GameWindow`` () =
            use gw = new OpenTK.GameWindow()
            gw.Close()

        [<Fact>]
        let ``Exit works like Close`` () =
            use gw = new OpenTK.GameWindow()
            gw.Exit()

        [<Fact>]
        let ``GameWindow exists after creation`` () =
            use gw = new OpenTK.GameWindow()
            Assert.True(gw.Exists)
            gw.Exit()

        [<Fact>]
        let ``Can close GameWindow on UpdateFrame`` () =
            use gw = new OpenTK.GameWindow()
            gw.UpdateFrame.Add(fun _ -> gw.Close())
            gw.Run()

        [<Fact>]
        let ``Closing event is sent before closed`` () =
            use gw = new OpenTK.GameWindow()
            let signals = System.Collections.Generic.List<string>()
            gw.Closing.Add(fun _ -> signals.Add("Closing"))
            gw.Closed.Add(fun _ -> signals.Add("Closed"))
            gw.Close()
            Assert.Equal([], signals)
            gw.ProcessEvents()
            Assert.Equal(["Closing"; "Closed"], signals)

    module Constructors =
        [<Fact>]
        let ``Width and Height can be set via constructor`` () =
            use gw = new OpenTK.GameWindow(200, 100)
            Assert.Equal(200, gw.Width)
            Assert.Equal(100, gw.Height)

    module Sizes =
        [<Fact>]
        let ``Updates to Width take effect`` () =
            use gw = new OpenTK.GameWindow()
            let oldWidth = gw.Width
            let newWidth = oldWidth + 1
            gw.Width <- newWidth
            Assert.Equal(newWidth, gw.Width)

        [<Fact>]
        let ``Updates to Height take effect`` () =
            use gw = new OpenTK.GameWindow()
            let oldHeight = gw.Height
            let newHeight = oldHeight + 1
            gw.Height <- newHeight
            Assert.Equal(newHeight, gw.Height)

        [<Fact>]
        let ``Updates to Size take effect`` () =
            use gw = new OpenTK.GameWindow()
            let oldSize = gw.Size
            let newSize = System.Drawing.Size(oldSize.Width + 1, oldSize.Height + 1)
            gw.Size <- newSize
            Assert.Equal(newSize, gw.Size)

        [<Fact>]
        let ``Updates to ClientSize take effect`` () =
            use gw = new OpenTK.GameWindow()
            let oldSize = gw.ClientSize
            let newSize = System.Drawing.Size(oldSize.Width + 1, oldSize.Height + 1)
            gw.ClientSize <- newSize
            Assert.Equal(newSize, gw.ClientSize)

        [<Fact>]
        let ``Updates to ClientRectangle.Size take effect`` () =
            use gw = new OpenTK.GameWindow()
            let oldSize = gw.ClientRectangle.Size
            let newSize = System.Drawing.Size(oldSize.Width + 1, oldSize.Height + 1)
            let newRect = System.Drawing.Rectangle(gw.ClientRectangle.Location, newSize)
            gw.ClientRectangle <- newRect
            Assert.Equal(newRect, gw.ClientRectangle)

        [<Fact>]
        let ``Updates to Bounds.Size take effect`` () =
            use gw = new OpenTK.GameWindow()
            let oldSize = gw.Bounds.Size
            let newSize = System.Drawing.Size(oldSize.Width + 1, oldSize.Height + 1)
            let newRect = System.Drawing.Rectangle(gw.Bounds.Location, newSize)
            gw.Bounds <- newRect
            Assert.Equal(newRect, gw.Bounds)

        [<Fact>]
        let ``ClientSize equals ClientRectangle.Size`` () =
            use gw = new OpenTK.GameWindow()
            Assert.Equal(gw.ClientSize, gw.ClientRectangle.Size)

        [<Fact>]
        let ``Size equals Bounds.Size`` () =
            use gw = new OpenTK.GameWindow()
            Assert.Equal(gw.Size, gw.Bounds.Size)

        [<Fact>]
        let ``Width and Height equals ClientSize`` () =
            use gw = new OpenTK.GameWindow()
            Assert.Equal(System.Drawing.Size(gw.Width, gw.Height), gw.ClientSize)

    module Locations =
        [<Fact>]
        let ``Updates to X take effect`` () =
            use gw = new OpenTK.GameWindow()
            let oldX = gw.X
            let newX = oldX + 1
            gw.X <- newX
            Assert.Equal(newX, gw.X)

        [<Fact>]
        let ``Updates to Y take effect`` () =
            use gw = new OpenTK.GameWindow()
            let oldY = gw.Y
            let newY = oldY + 1
            gw.Y <- newY
            Assert.Equal(newY, gw.Y)

        [<Fact>]
        let ``Updates to Location take effect`` () =
            use gw = new OpenTK.GameWindow()
            let oldLocation = gw.Location
            let newLocation = System.Drawing.Point(oldLocation.X + 1, oldLocation.Y + 1)
            gw.Location <- newLocation
            Assert.Equal(newLocation, gw.Location)

        [<Fact>]
        let ``Updates to Bounds.Location take effect`` () =
            use gw = new OpenTK.GameWindow()
            let oldLocation = gw.Bounds.Location
            let newLocation = System.Drawing.Point(oldLocation.X + 1, oldLocation.Y + 1)
            let newRect = System.Drawing.Rectangle(newLocation, gw.ClientRectangle.Size)
            gw.Bounds <- newRect
            Assert.Equal(newRect, gw.Bounds)

        [<Fact>]
        let ``Location equals Bounds.Location`` () =
            use gw = new OpenTK.GameWindow()
            Assert.Equal(gw.Location, gw.Bounds.Location)

        [<Fact>]
        let ``X and Y equals Location`` () =
            use gw = new OpenTK.GameWindow()
            Assert.Equal(System.Drawing.Point(gw.X, gw.Y), gw.Location)

        [<Fact>]
        let ``ClientRectangle.Location is zero`` () =
            use gw = new OpenTK.GameWindow()
            Assert.Equal(System.Drawing.Point.Empty, gw.ClientRectangle.Location)

    module Borders =
        [<Fact>]
        let ``Updates to BorderStyle take effect`` () =
            use gw = new OpenTK.GameWindow()
            gw.WindowBorder <- WindowBorder.Fixed
            Assert.Equal(WindowBorder.Fixed, gw.WindowBorder)
            gw.WindowBorder <- WindowBorder.Hidden
            Assert.Equal(WindowBorder.Hidden, gw.WindowBorder)
            gw.WindowBorder <- WindowBorder.Resizable
            Assert.Equal(WindowBorder.Resizable, gw.WindowBorder)

        [<Fact>]
        let ``Can resize fixed borders`` () =
            use gw = new OpenTK.GameWindow()
            gw.WindowBorder <- WindowBorder.Fixed
            let oldSize = gw.Size
            let newSize = System.Drawing.Size(oldSize.Width + 1, oldSize.Height + 1)
            gw.Size <- newSize
            Assert.Equal(newSize, gw.Size)

        [<Fact>]
        let ``Can resize hidden borders`` () =
            use gw = new OpenTK.GameWindow()
            gw.WindowBorder <- WindowBorder.Hidden
            let oldSize = gw.Size
            let newSize = System.Drawing.Size(oldSize.Width + 1, oldSize.Height + 1)
            gw.Size <- newSize
            Assert.Equal(newSize, gw.Size)
