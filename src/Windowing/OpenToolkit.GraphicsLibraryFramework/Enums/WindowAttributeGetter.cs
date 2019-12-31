//
// WindowAttributeSetter.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.GraphicsLibraryFramework
{
    /// <summary>
    /// Used to get window related attributes.
    /// </summary>
    /// <seealso cref="GLFW.GetWindowAttrib"/>
    public enum WindowAttributeGetter
    {
        /// <summary>
        /// Indicates whether the specified window has input focus.
        /// Initial input focus is controlled by the window hint with the same name
        /// </summary>
        Focused = WindowHintBool.Focused,

        /// <summary>
        /// Indicates whether the specified window is iconified,
        /// whether by the user or with <see cref="GLFW.IconifyWindow"/>.
        /// </summary>
        Iconified = WindowHintBool.Iconified,

        /// <summary>
        /// Indicates whether the specified window is resizable by the user.
        /// This is set on creation with the window hint with the same name.
        /// </summary>
        Resizable = WindowHintBool.Resizable,

        /// <summary>
        /// Indicates whether the specified window is visible.
        /// Window visibility can be controlled with <see cref="GLFW.ShowWindow"/> and <see cref="GLFW.HideWindow"/>
        /// and initial visibility is controlled by the window hint with the same name.
        /// </summary>
        Visible = WindowHintBool.Visible,

        /// <summary>
        /// Indicates whether the specified window has decorations such as a border,a close widget, etc.
        /// This is set on creation with the window hint with the same name.
        /// </summary>
        Decorated = WindowHintBool.Decorated,

        /// <summary>
        /// Specifies whether the full screen window will automatically iconify and restore
        /// the previous video mode on input focus loss.
        /// Possible values are <c>true</c> and <c>false</c>. This hint is ignored for windowed mode windows.
        /// </summary>
        AutoIconify = WindowHintBool.AutoIconify,

        /// <summary>
        /// Indicates whether the specified window is floating, also called topmost or always-on-top.
        /// This is controlled by the window hint with the same name.
        /// </summary>
        Floating = WindowHintBool.Floating,

        /// <summary>
        /// Indicates whether the specified window is maximized,
        /// whether by the user or with <see cref="GLFW.MaximizeWindow"/>.
        /// </summary>
        Maximized = WindowHintBool.Maximized,

        /// <summary>
        /// Specifies whether the cursor should be centered over newly created full screen windows.
        /// Possible values are <c>true</c> and <c>false</c>. This hint is ignored for windowed mode windows.
        /// </summary>
        CenterCursor = WindowHintBool.CenterCursor,

        /// <summary>
        /// Specifies whether the window framebuffer will be transparent.
        /// If enabled and supported by the system, the window framebuffer alpha channel will be used
        /// to combine the framebuffer with the background.
        /// This does not affect window decorations. Possible values are <c>true</c> and <c>false</c>.
        /// </summary>
        TransparentFramebuffer = WindowHintBool.TransparentFramebuffer,

        /// <summary>
        /// indicates whether the cursor is currently directly over the client area of the window,
        /// with no other windows between.
        /// See <a href="https://www.glfw.org/docs/3.3/input_guide.html#cursor_enter">Cursor enter/leave events</a>
        /// for details.
        /// </summary>
        Hovered = WindowHintBool.Hovered,

        /// <summary>
        /// Specifies whether the window will be given input focus when <see cref="GLFW.ShowWindow"/> is called.
        /// Possible values are <c>true</c> and <c>false</c>.
        /// </summary>
        FocusOnShow = WindowHintBool.FocusOnShow,
    }
}
