#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

using OpenTK.Input;

namespace OpenTK.Platform
{
    /// <summary>
    /// This interface supports OpenTK, and is not intended for use by OpenTK programs.
    /// </summary>
    interface INativeGLWindow : IResizable, IDisposable
    {
        void CreateWindow(DisplayMode mode, GLContext context);
        void DestroyWindow();
        void ProcessEvents();
        void PointToClient(ref System.Drawing.Point p);
        void PointToScreen(ref System.Drawing.Point p);

        bool Exists { get; }
        IWindowInfo WindowInfo { get; }

        string Title { get; set; }
        bool Visible { get; set; }
        bool IsIdle { get; }
        //IGLContext Context { get; }
        IInputDriver InputDriver { get; }

        event CreateEvent Create;
        event DestroyEvent Destroy;
    }

    public delegate void CreateEvent(object sender, EventArgs e);
    public delegate void DestroyEvent(object sender, EventArgs e);
}
