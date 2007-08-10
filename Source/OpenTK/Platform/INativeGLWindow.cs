#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

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
        void DestroyWindow();
        void ProcessEvents();

        void OnCreate(EventArgs e);
        void OnDestroy(EventArgs e);

        bool Exists { get; }
        //bool IsExiting { get; }
        IWindowInfo WindowInfo { get; }

        event CreateEvent Create;
        event DestroyEvent Destroy;
    }

    public delegate void CreateEvent(object sender, EventArgs e);
    public delegate void DestroyEvent(object sender, EventArgs e);
}
