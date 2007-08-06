using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform
{
    /// <summary>
    /// This interface supports OpenTK, and is not intended for use by OpenTK programs.
    /// </summary>
    interface INativeGLWindow : IGLControl, IResizable
    {
        void CreateWindow(DisplayMode mode);
        void ProcessEvents();
        void Exit();

        bool Exists { get; }
        bool Quit { get; }
        IWindowInfo WindowInfo { get; }
    }
}
