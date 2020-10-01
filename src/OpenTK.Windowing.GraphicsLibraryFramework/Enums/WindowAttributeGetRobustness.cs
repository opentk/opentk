//
// WindowAttributeGetterRobustness.cs
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
    /// <seealso cref="GLFW.GetWindowAttrib(Window*, WindowAttributeGetRobustness)" />
    public enum WindowAttributeGetRobustness
    {
        /// <summary>
        ///     Indicates the robustness strategy used by the context.
        ///     This is <see cref="Robustness.LoseContextOnReset" /> or <see cref="Robustness.NoResetNotification" />
        ///     if the window's context supports robustness, or <see cref="Robustness.NoRobustness" /> otherwise.
        /// </summary>
        ContextRobustness = WindowHintRobustness.ContextRobustness
    }
}
