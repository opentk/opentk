#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK team.
 * This notice may not be removed.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Graphics
{
    internal interface IDisplayDeviceDriver
    {
        bool TryChangeResolution(DisplayDevice device, DisplayResolution resolution);
        bool TryRestoreResolution(DisplayDevice device);
    }
}
