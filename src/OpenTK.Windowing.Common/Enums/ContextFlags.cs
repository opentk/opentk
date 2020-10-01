//
// ContextFlags.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;

namespace OpenTK.Windowing.Common
{
    /// <summary>
    ///     Enumerates various flags that affect the creation of new GraphicsContexts.
    /// </summary>
    [Flags]
    public enum ContextFlags
    {
        /// <summary>
        ///     The default value of the GraphicsContextFlags enumeration.
        /// </summary>
        Default = 0,

        /// <summary>
        ///     Indicates that this is a debug GraphicsContext. Debug contexts may provide
        ///     additional debugging information at the cost of performance.
        /// </summary>
        Debug = 1,

        /// <summary>
        ///     Indicates that this is a forward compatible GraphicsContext. Forward-compatible contexts
        ///     do not support functionality marked as deprecated in the current GraphicsContextVersion.
        /// </summary>
        /// <remarks>Forward-compatible contexts are defined only for OpenGL versions 3.0 and later.</remarks>
        ForwardCompatible = 2,

        /// <summary>
        ///     Indicates that this GraphicsContext is intended for offscreen rendering.
        /// </summary>
        Offscreen = 4
    }
}
