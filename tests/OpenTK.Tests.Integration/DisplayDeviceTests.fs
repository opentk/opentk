namespace OpenTK.Tests.Integration

open Xunit
open FsCheck
open FsCheck.Xunit
open System
open System.Runtime.InteropServices
open OpenTK

module DisplayDevice =
    let AllIndices = [
        OpenTK.DisplayIndex.Primary;
        OpenTK.DisplayIndex.First;
        OpenTK.DisplayIndex.Second;
        OpenTK.DisplayIndex.Third;
        OpenTK.DisplayIndex.Fourth;
        OpenTK.DisplayIndex.Fifth;
        OpenTK.DisplayIndex.Sixth;]

    let NumberedIndices = [
        OpenTK.DisplayIndex.First;
        OpenTK.DisplayIndex.Second;
        OpenTK.DisplayIndex.Third;
        OpenTK.DisplayIndex.Fourth;
        OpenTK.DisplayIndex.Fifth;
        OpenTK.DisplayIndex.Sixth;]

    module General =
        [<Fact>]
        let ``Default DisplayDevice is not null`` () =
            let device = OpenTK.DisplayDevice.Default
            Assert.NotNull(device)

        [<Fact>]
        let ``DisplayDevice.Default == DisplayDevice.GetDisplay(Default)`` () =
            Assert.Equal(
                OpenTK.DisplayDevice.Default,
                OpenTK.DisplayDevice.GetDisplay(OpenTK.DisplayIndex.Default))

        [<Fact>]
        let ``DisplayDevice.GetDisplay(Default) == DisplayDevice.GetDisplay(Primary)`` () =
            Assert.Equal(
                OpenTK.DisplayDevice.GetDisplay(OpenTK.DisplayIndex.Default),
                OpenTK.DisplayDevice.GetDisplay(OpenTK.DisplayIndex.Primary))

        [<Fact>]
        let ``DisplayDevice.GetDisplay(i) doesn't throw`` () =

            for index in AllIndices do
                let device = OpenTK.DisplayDevice.GetDisplay(index)
                ignore device

        [<Fact>]
        let ``DisplayDevice.Default.IsPrimary == true`` () =
            Assert.True(DisplayDevice.Default.IsPrimary)

        [<Fact>]
        let ``AvailableResolutions contains CurrentResolution`` () =
            for index in NumberedIndices do
                let device = OpenTK.DisplayDevice.GetDisplay(index)
                if not(Object.ReferenceEquals(device, null)) then
                    Assert.Contains(device.CurrentResolution, device.AvailableResolutions)

        [<Fact>]
        let ``Only the primary DisplayDevice has IsPrimary == true`` () =
            let primaryDevice = OpenTK.DisplayDevice.Default

            for index in AllIndices do
                let device = OpenTK.DisplayDevice.GetDisplay(index)
                if not(Object.ReferenceEquals(device, null)) && not(device.Equals(primaryDevice)) then
                    Assert.False(device.IsPrimary)

        [<Fact>]
        let ``CurrentResolution is not zero`` () =
            for index in AllIndices do
                let device = OpenTK.DisplayDevice.GetDisplay(index)
                if not(Object.ReferenceEquals(device, null)) then
                    let resoulution = device.CurrentResolution;
                    Assert.True(resoulution.Width <> 0, "Width")
                    Assert.True(resoulution.Height <> 0, "Height")
                    Assert.True(resoulution.BitsPerPixel <> 0, "BitsPerPixel")
                    // We can't test for RefreshRate, because if on X11 with no randr extension we have no way of getting the refresh rate.
                    //Assert.True(resoulution.RefreshRate <> 0.0f, "RefreshRate")

        [<Fact>]
        let ``ChangeResoultion updates CurrentResolution`` () =
            for index in AllIndices do
                let device = OpenTK.DisplayDevice.GetDisplay(index)
                if not(Object.ReferenceEquals(device, null)) then
                    for resolution in device.AvailableResolutions do
                        device.ChangeResolution(resolution)
                        Assert.Equal(resolution, device.CurrentResolution)

        [<Fact>]
        let ``No numbered device is the same as any other`` () =
            let set = new System.Collections.Generic.HashSet<DisplayDevice>()
            for index in NumberedIndices do
                let device = OpenTK.DisplayDevice.GetDisplay(index)
                if not(Object.ReferenceEquals(device, null)) then
                    Assert.True(set.Add(device))

        [<Fact>]
        let ``No display bounds intersect`` () =
            for index in NumberedIndices do
                let device = OpenTK.DisplayDevice.GetDisplay(index)
                if not(Object.ReferenceEquals(device, null)) then
                    for otherIndex in Seq.except [index] NumberedIndices do
                        let otherDevice = OpenTK.DisplayDevice.GetDisplay(otherIndex)
                        if not(Object.ReferenceEquals(otherDevice, null)) then
                                Assert.False(device.CurrentResolution.Bounds.IntersectsWith(otherDevice.CurrentResolution.Bounds))