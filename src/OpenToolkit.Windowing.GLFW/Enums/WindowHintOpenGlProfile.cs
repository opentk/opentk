//
// WindowHintOpenGlProfile.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.GraphicsLibraryFramework
{
    /// <summary>
    /// Used to set the OpenGlProfile attribute.
    /// </summary>
    /// <seealso cref="GLFW.WindowHint(WindowHintOpenGlProfile,OpenGlProfile)"/>
    public enum WindowHintOpenGlProfile
    {
        /// <summary>
        /// Indicates the OpenGL profile used by the context.
        /// This is <see cref="GraphicsLibraryFramework.OpenGlProfile.Core"/>
        /// or <see cref="GraphicsLibraryFramework.OpenGlProfile.Compat"/>
        /// if the context uses a known profile, or <see cref="GraphicsLibraryFramework.OpenGlProfile.Any"/>
        /// if the OpenGL profile is unknown or the context is an OpenGL ES context.
        /// Note that the returned profile may not match the profile bits of the context flags,
        /// as GLFW will try other means of detecting the profile when no bits are set. TODO: enum for missing crefs
        /// </summary>
        OpenGlProfile = 0x00022008,
    }
}
