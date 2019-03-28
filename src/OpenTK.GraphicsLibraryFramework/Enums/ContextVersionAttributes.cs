//
// ContextVersionAttributes.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.GraphicsLibraryFramework
{
    /// <summary>
    /// Context related attributes.
    /// </summary>
    /// <seealso cref="IGLFW.WindowHint(ContextVersionAttributes,int)"/>
    public enum ContextVersionAttributes
    {
        /// <summary>
        /// Indicate the client API version(major part) of the window's context.
        /// </summary>
        ContextVersionMajor = 0x00022002,

        /// <summary>
        /// Indicate the client API version(minor part) of the window's context.
        /// </summary>
        ContextVersionMinor = 0x00022003,

        /// <summary>
        /// Indicate the client API version(revision part) of the window's context.
        /// </summary>
        ContextRevision = 0x00022004,
    }
}
