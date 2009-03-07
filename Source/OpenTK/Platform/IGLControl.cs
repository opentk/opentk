#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

using OpenTK.Graphics;

namespace OpenTK.Platform
{
    internal interface IGLControl
    {
        GraphicsContext CreateContext(int major, int minor, GraphicsContextFlags flags);
        bool IsIdle { get; }
        IWindowInfo WindowInfo { get; }
    }
}
