//
// InputAction.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenTK.Windowing.GraphicsLibraryFramework
{
    /// <summary>
    ///     Defines event information for <see cref="GLFWCallbacks.KeyCallback" />
    ///     or <see cref="GLFWCallbacks.MouseButtonCallback" />.
    /// </summary>
    public enum InputAction
    {
        /// <summary>
        ///     The key or mouse button was released.
        /// </summary>
        Release = 0,

        /// <summary>
        ///     The key or mouse button was pressed.
        /// </summary>
        Press = 1,

        /// <summary>
        ///     The key was held down until it repeated.
        /// </summary>
        Repeat = 2
    }
}
