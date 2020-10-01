//
// WindowAttributeGetterInt.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenTK.Windowing.GraphicsLibraryFramework
{
    /// <summary>
    ///     Used to get window related attributes.
    /// </summary>
    /// <seealso cref="GLFW.GetWindowAttrib(Window*, WindowAttributeGetInt)" />
    public enum WindowAttributeGetInt
    {
        /// <summary>
        ///     Indicate the client API version(major part) of the window's context.
        /// </summary>
        ContextVersionMajor = WindowHintInt.ContextVersionMajor,

        /// <summary>
        ///     Indicate the client API version(minor part) of the window's context.
        /// </summary>
        ContextVersionMinor = WindowHintInt.ContextVersionMinor,

        /// <summary>
        ///     Indicate the client API version(revision part) of the window's context.
        /// </summary>
        ContextVersionRevision = WindowHintInt.ContextRevision
    }
}
