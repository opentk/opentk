// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK
{
    /// <summary>
    /// Defines <see cref="DisplayDevice"/> indices.
    /// </summary>
    public enum DisplayIndex
    {
        /// <summary>
        /// The first DisplayDevice.
        /// </summary>
        First = 0,
        /// <summary>
        /// The second DisplayDevice.
        /// </summary>
        Second,
        /// <summary>
        /// The third DisplayDevice.
        /// </summary>
        Third,
        /// <summary>
        /// The fourth DisplayDevice.
        /// </summary>
        Fourth,
        /// <summary>
        /// The fifth DisplayDevice.
        /// </summary>
        Fifth,
        /// <summary>
        /// The sixth DisplayDevice.
        /// </summary>
        Sixth,
        /// <summary>
        /// The default (primary) DisplayDevice.
        /// </summary>
        Primary = -1,
        /// <summary>
        /// The default (primary) DisplayDevice.
        /// </summary>
        Default = Primary,
    }
}
