﻿//
// ListenerVector3.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.OpenAL
{
    /// <summary>
    /// A list of valid Math.Vector3 Listener/GetListener parameters.
    /// </summary>
    public enum ListenerVector3
    {
        /// <summary>
        /// Specify the current location in three dimensional space. OpenAL, like OpenGL, uses a right handed coordinate
        /// system, where in a frontal default view X (thumb) points right, Y points up (index finger), and Z points towards
        /// the viewer/camera (middle finger). To switch from a left handed coordinate system, flip the sign on the Z
        /// coordinate. Listener position is always in the world coordinate system.
        /// </summary>
        Position = 0x1004,

        /// <summary>
        /// Specify the current velocity in three dimensional space.
        /// </summary>
        Velocity = 0x1006,
    }
}
