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

namespace OpenTK.Platform
{
    // Provides methods to access internal GdiPlus fields. This is necessary for
    // managed <-> native GdiPlus interoperability.
    // Note that the fields are named differently between .Net and Mono.
    // GdiPlus is considered deprecated by Microsoft - it is highly unlikely that
    // future framework upgrades will break this code, but it is something to
    // keep in mind.
    interface IGdiPlusInternals
    {
        IntPtr GetNativeGraphics(System.Drawing.Graphics graphics);

        IntPtr GetNativeFont(System.Drawing.Font font);

        IntPtr GetNativeStringFormat(System.Drawing.StringFormat format);
    }
}
