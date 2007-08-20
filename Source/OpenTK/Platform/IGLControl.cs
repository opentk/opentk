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
        bool IsIdle { get; }
        bool Fullscreen { get; set; }
        IGLContext Context { get; }
    }
}
