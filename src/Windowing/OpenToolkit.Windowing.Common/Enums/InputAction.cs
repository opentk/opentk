//
// InputAction.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using OpenToolkit.Windowing.Common;

namespace OpenToolkit.Windowing.Common
{
    /// <summary>
    /// Defines event information for <see cref="MouseButtonEventArgs.Action"/>.
    /// </summary>
    public enum InputAction
    {
        /// <summary>
        /// The key or mouse button was pressed.
        /// </summary>
        Press = 0,

        /// <summary>
        /// The key or mouse button was released.
        /// </summary>
        Release = 1,

        /// <summary>
        /// The key was held down until it repeated.
        /// </summary>
        Repeat = 2
    }
}
