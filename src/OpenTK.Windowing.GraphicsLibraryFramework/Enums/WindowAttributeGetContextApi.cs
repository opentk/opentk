//
// WindowAttributeGetterContextApi.cs
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
    /// <seealso cref="GLFW.GetWindowAttrib(Window*, WindowAttributeGetContextApi)" />
    public enum WindowAttributeGetContextApi
    {
        /// <summary>
        ///     Indicates the context creation API used to create the window's context;
        ///     either <see cref="ContextApi.NativeContextApi" /> or <see cref="ContextApi.EglContextApi" />.
        /// </summary>
        ContextCreationApi = WindowHintContextApi.ContextCreationApi
    }
}
