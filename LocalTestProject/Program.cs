

using OpenTK.Core.Platform;
using OpenTK.Core.Platform.Implementations.Windows;

namespace LocalTestProject;

public class Program
{
    public static void Main(string[] args)
    {
        WindowComponent windowComp = new WindowComponent();

        windowComp.Initialize(PalComponents.Window);

        var handle = windowComp.Create();

        windowComp.SetTitle(handle, "Cool test window");

        windowComp.SetSize(handle, 600, 400);
        windowComp.SetPosition(handle, 100, 100);

        windowComp.SetBorderStyle(handle, WindowStyle.Borderless);
        WindowStyle border = windowComp.GetBorderStyle(handle);
        Console.WriteLine($"Border: {border}");

        windowComp.SetBorderStyle(handle, WindowStyle.FixedBorder);
        border = windowComp.GetBorderStyle(handle);
        Console.WriteLine($"Border: {border}");

        windowComp.SetBorderStyle(handle, WindowStyle.ResizableBorder);
        border = windowComp.GetBorderStyle(handle);
        Console.WriteLine($"Border: {border}");

        windowComp.GetPosition(handle, out var x, out var y);
        windowComp.GetSize(handle, out var width, out var height);
        windowComp.GetClientPosition(handle, out var cx, out var cy);
        windowComp.GetClientSize(handle, out var cwidth, out var cheight);
        Console.WriteLine($"Window: X: {x}, Y: {y}, Width: {width}, Height: {height}");
        Console.WriteLine($"Client: X: {cx}, Y {cy} Width: {cwidth}, Height: {cheight}");

        windowComp.SetClientSize(handle, 600, 400);
        windowComp.SetClientPosition(handle, 100, 100);

        windowComp.GetPosition(handle, out x, out y);
        windowComp.GetSize(handle, out width, out height);
        windowComp.GetClientPosition(handle, out cx, out cy);
        windowComp.GetClientSize(handle, out cwidth, out cheight);
        Console.WriteLine($"Window: X: {x}, Y: {y}, Width: {width}, Height: {height}");
        Console.WriteLine($"Client: X: {cx}, Y {cy} Width: {cwidth}, Height: {cheight}");

        var mode = windowComp.GetMode(handle);
        Console.WriteLine($"Mode: {mode}");

        windowComp.SetMode(handle, WindowMode.Normal);

        mode = windowComp.GetMode(handle);
        Console.WriteLine($"Mode: {mode}");

        windowComp.Loop(handle);
    }
}
