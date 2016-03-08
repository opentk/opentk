// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
ns.Generic;
using System.Text;

namespace OpenTK.Input
{
    /// <summary>
    /// Defines the interface for MouseDevice drivers.
    /// </summary>
    [Obsolete]
    public interface IMouseDriver
    {
        /// <summary>
        /// Gets the list of available MouseDevices.
        /// </summary>
        IList<MouseDevice> Mouse { get; }
    }
}
