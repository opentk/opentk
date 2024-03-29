//
// WindowAttributeSetter.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenTK.Windowing.GraphicsLibraryFramework
{
    /// <summary>
    /// Used to set window related attributes.
    /// </summary>
    /// <seealso cref="GLFW.SetWindowAttrib"/>
    public enum WindowAttribute
    {
        /// <summary>
        /// Indicates whether the specified window is resizable by the user.
        /// This is set on creation with the window hint with the same name.
        /// </summary>
        Resizable = WindowHintBool.Resizable,

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
        /// Specifies whether the window will be given input focus when <see cref="GLFW.ShowWindow"/> is called.
        /// Possible values are <c>true</c> and <c>false</c>.
        /// </summary>
        FocusOnShow = WindowHintBool.FocusOnShow,

        /// <summary>
        /// Specifies whether the window is transparent to mouse input, letting any mouse events pass through to whatever window is behind it.
        /// This can be set before creation with the <see cref="WindowHintBool.MousePassthrough"/> window hint or after with <see cref="GLFW.SetWindowAttrib(Window*, WindowAttribute, bool)"/>.
        /// This is only supported for undecorated windows.
        /// Decorated windows with this enabled will behave differently between platforms.
        /// </summary>
        MousePassthrough = WindowHintBool.MousePassthrough,
    }
}
