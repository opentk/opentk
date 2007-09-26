#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Input
{
    public interface IMouseDriver
    {
        /// <summary>
        /// Gets the list of available mouse devices.
        /// </summary>
        IList<MouseDevice> Mouse { get; }
    }
}
