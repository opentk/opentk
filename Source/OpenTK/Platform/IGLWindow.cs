#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

using OpenTK.OpenGL;

namespace OpenTK.Platform
{
    public interface IGLControl : IDisposable
    {
        void ProcessEvents();

        event CreateEvent Create;

        bool IsIdle { get; }
        //bool Quit { get; set; }
        bool Fullscreen { get; set; }
        IGLContext Context { get; }
    }

    public delegate void CreateEvent(object sender, EventArgs e);
}
