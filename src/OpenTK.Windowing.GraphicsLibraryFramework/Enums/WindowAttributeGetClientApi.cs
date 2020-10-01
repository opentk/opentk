//
// WindowAttributeGetterClientApi.cs
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
    /// <seealso cref="GLFW.GetWindowAttrib(Window*, WindowAttributeGetClientApi)" />
    public enum WindowAttributeGetClientApi
    {
        /// <summary>
        ///     Indicates the client API provided by the window's context;
        ///     either <see cref="GraphicsLibraryFramework.ClientApi.OpenGlApi" />,
        ///     <see cref="GraphicsLibraryFramework.ClientApi.OpenGlEsApi" /> or
        ///     <see cref="GraphicsLibraryFramework.ClientApi.NoApi" />.
        /// </summary>
        ClientApi = WindowHintClientApi.ClientApi
    }
}
