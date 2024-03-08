using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Windowing.GraphicsLibraryFramework
{
    public enum Platform
    {
        Any = 0x00060000,
        Win32 = 0x00060001,
        Cocoa = 0x00060002,
        Wayland = 0x00060003,
        X11 = 0x00060004,
        Null = 0x00060005,
    }
}
