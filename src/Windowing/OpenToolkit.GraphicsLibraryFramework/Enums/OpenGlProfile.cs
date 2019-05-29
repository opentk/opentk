//
// OpenGlProfile.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.GraphicsLibraryFramework
{
    /// <summary>
    /// The OpenGL context profiles.
    /// </summary>
    public enum OpenGlProfile
    {
        /// <summary>
        /// Used for unknown OpenGL profile or OpenGL ES.
        /// </summary>
        Any = 0,

        /// <summary>
        /// Known OpenGL Core profile.
        /// </summary>
        Core = 0x00032001,

        /// <summary>
        /// Known OpenGL compatibility profile.
        /// </summary>
        Compat = 0x00032002
    }
}
