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
    /// <summary>
    /// Defines the interface for KeyboardDevice drivers.
    /// </summary>
    [Obsolete]
    public interface IKeyboardDriver
    {
        /// <summary>
        /// Gets the list of available KeyboardDevices.
        /// </summary>
        IList<KeyboardDevice> Keyboard { get; }
    }
}
