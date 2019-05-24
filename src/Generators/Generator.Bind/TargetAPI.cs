//
// TargetAPI.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace Bind
{
    /// <summary>
    /// Holds target APIs that the binder can generate.
    /// </summary>
    public enum TargetAPI
    {
        /// <summary>
        /// All APIs should be generated.
        /// </summary>
        All,

        /// <summary>
        /// Generate API bindings for OpenGL Compatibility Profile.
        /// </summary>
        DesktopCompatibility,

        /// <summary>
        /// Generate API bindings for OpenGL Core Profile.
        /// </summary>
        Desktop,

        /// <summary>
        /// Generate API bindings for OpenGL ES.
        /// </summary>
        Embedded,
    }
}
