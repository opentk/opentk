//
// VSyncMode.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenTK.Windowing.Common
{
    /// <summary>
    ///     Enumerates available VSync modes.
    /// </summary>
    public enum VSyncMode
    {
        /// <summary>
        ///     Vsync disabled.
        /// </summary>
        Off = 0,

        /// <summary>
        ///     VSync enabled.
        /// </summary>
        On,

        /// <summary>
        ///     VSync enabled, unless framerate falls below one half of target framerate.
        ///     If no target framerate is specified, this behaves exactly like <see cref="VSyncMode.On" />.
        /// </summary>
        Adaptive
    }
}
