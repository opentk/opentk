//
// WindowHintClientApi.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenTK.Windowing.GraphicsLibraryFramework.Enums
{
    /// <summary>
    /// Context related client API attribute.
    /// </summary>
    /// <seealso cref="GLFW.WindowHint(WindowHintClientApi,ClientApi)"/>
    public enum WindowHintClientApi
    {
        /// <summary>
        /// Indicates the client API provided by the window's context;
        /// either <see cref="Enums.ClientApi.OpenGlApi"/>,
        /// <see cref="Enums.ClientApi.OpenGlEsApi"/> or
        /// <see cref="Enums.ClientApi.NoApi"/>.
        /// </summary>
        ClientApi = 0x00022001,
    }
}
