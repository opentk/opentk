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
    public interface IWindowInfo
    {
        IntPtr Handle { get; }
        IWindowInfo Parent { get; }
    }
}
