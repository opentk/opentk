//
// ConnectedState.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.GraphicsLibraryFramework
{
    /// <summary>
    /// Specifies connected state of devices.
    /// </summary>
    public enum ConnectedState
    {
        /// <summary>
        /// Indicates that a device is connected.
        /// </summary>
        Connected = 0x00040001,

        /// <summary>
        /// Indicates that a device is disconnected.
        /// </summary>
        Disconnected = 0x00040002
    }
}
