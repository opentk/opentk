//
// WindowHintClientApi.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.GraphicsLibraryFramework
{
    /// <summary>
    /// Context related client API attribute.
    /// </summary>
    /// <seealso cref="GLFW.WindowHint(WindowHintClientApi,ClientApi)"/>
    public enum WindowHintClientApi
    {
        /// <summary>
        /// Indicates the client API provided by the window's context;
        /// either <see cref="GraphicsLibraryFramework.ClientApi.OpenGlApi"/>,
        /// <see cref="GraphicsLibraryFramework.ClientApi.OpenGlEsApi"/> or
        /// <see cref="GraphicsLibraryFramework.ClientApi.NoApi"/>.
        /// </summary>
        ClientApi = 0x00022001,
    }
}
