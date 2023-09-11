using System;
using OpenTK.Core.Platform;
using OpenTK.Platform.Native.macOS;

namespace MacOSTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MacOSWindowComponent windowComponent = new MacOSWindowComponent();

            windowComponent.Initialize(PalComponents.Window);
        }
    }
}