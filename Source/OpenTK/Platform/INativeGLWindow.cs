// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
#if !MINIMAL
using System.Drawing;
#endif
using System.Text;

using OpenTK.Input;
using OpenTK.Graphics;

namespace OpenTK.Platform
{
    [Obsolete]
    internal interface INativeGLWindow : IDisposable
    {
        void CreateWindow(int width, int height, GraphicsMode mode, int major, int minor, GraphicsContextFlags flags, out IGraphicsContext context);
        void DestroyWindow();
        void ProcessEvents();
        Point PointToClient(Point point);
        Point PointToScreen(Point point);

        bool Exists { get; }
        IWindowInfo WindowInfo { get; }

        string Title { get; set; }
        bool Visible { get; set; }
        bool IsIdle { get; }
        IInputDriver InputDriver { get; }
        WindowState WindowState { get; set; }
        WindowBorder WindowBorder { get; set; }

        event CreateEvent Create;
        event DestroyEvent Destroy;
    }

    [Obsolete]
    internal delegate void CreateEvent(object sender, EventArgs e);
    [Obsolete]
    internal delegate void DestroyEvent(object sender, EventArgs e);
}
