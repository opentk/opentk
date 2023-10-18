//
// WindowAttributeGetterClientApi.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenTK.Windowing.GraphicsLibraryFramework.Enums
{
    /// <summary>
    /// Used to get window related attributes.
    /// </summary>
    /// <seealso cref="GLFW.GetWindowAttrib(Window*, WindowAttributeGetClientApi)"/>
    public enum WindowAttributeGetClientApi
    {
        /// <summary>
        /// Indicates the client API provided by the window's context;
        /// either <see cref="Enums.ClientApi.OpenGlApi"/>,
        /// <see cref="Enums.ClientApi.OpenGlEsApi"/> or
        /// <see cref="Enums.ClientApi.NoApi"/>.
        /// </summary>
        ClientApi = WindowHintClientApi.ClientApi
    }
}
