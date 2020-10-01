//
// ContextProfile.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenTK.Windowing.Common
{
    /// <summary>
    ///     Selects the profile for the context's graphics API. This only applies on OpenGL 3.2 upwards, and has no effect on older versions.
    /// </summary>
    public enum ContextProfile
    {
        /// <summary>
        ///     Used for unknown OpenGL profile or OpenGL ES.
        /// </summary>
        Any,

        /// <summary>
        ///     Selects compatability profile. You should only use this if maintaining legacy code.
        /// </summary>
        Compatability,

        /// <summary>
        ///     Selects core profile. All new projects should use this unless they have a good reason not to.
        /// </summary>
        Core
    }
}
