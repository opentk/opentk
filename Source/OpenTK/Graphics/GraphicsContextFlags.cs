// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.


using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Graphics
{
    /// <summary>
    /// Enumerates various flags that affect the creation of new GraphicsContexts.
    /// </summary>
    [Flags]
    public enum GraphicsContextFlags
    {
        /// <summary>
        /// The default value of the GraphicsContextFlags enumeration.
        /// </summary>
        Default = 0x0000,
        /// <summary>
        /// Indicates that this is a debug GraphicsContext. Debug contexts may provide
        /// additional debugging information at the cost of performance.
        /// </summary>
        /// <remarks></remarks>
        Debug = 0x0001,
        /// <summary>
        /// Indicates that this is a forward compatible GraphicsContext. Forward-compatible contexts
        /// do not support functionality marked as deprecated in the current GraphicsContextVersion.
        /// </summary>
        /// <remarks>Forward-compatible contexts are defined only for OpenGL versions 3.0 and later.</remarks>
        ForwardCompatible = 0x0002,
        /// <summary>
        /// Indicates that this GraphicsContext is targeting OpenGL|ES.
        /// </summary>
        Embedded = 0x0004
    }
}
