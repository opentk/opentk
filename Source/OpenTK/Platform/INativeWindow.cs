using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform
{
    interface INativeWindow : IGLControl, IResizable
    {
        void CreateWindow(DisplayMode mode);
        void ProcessEvents();
        void Exit();

        bool Created { get; }
        bool Quit { get; }
        IntPtr Handle { get; }
    }
}
