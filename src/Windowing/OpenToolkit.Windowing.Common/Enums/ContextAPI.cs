//
// ContextAPI.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.Windowing.Common
{
    /// <summary>
    /// Describes the graphics API and version you want the context to use.
    /// </summary>
    public enum ContextAPI
    {
        /// <summary>
        /// Selects no context. You'll have to create your own context externally.
        /// </summary>
        NoContext,

        /// <summary>
        /// Selects OpenGL 3.3
        /// </summary>
        GLVersion33,

        /// <summary>
        /// Selects OpenGL 4.0
        /// </summary>
        GLVersion40,
    }
}
