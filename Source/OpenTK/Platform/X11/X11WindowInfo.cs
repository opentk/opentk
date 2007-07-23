using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform.X11
{
    public class X11WindowInfo : IWindowInfo
    {
        public IntPtr RootWindow;
        public IntPtr Window;
        public IntPtr TopLevelWindow;
        public IntPtr Display;
        public int Screen;
    }
}
