//
// ClientApi.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.GraphicsLibraryFramework
{
    /// <summary>
    /// The context client APIs.
    /// </summary>
    /// <seealso cref="GLFW.WindowHint(WindowHintClientApi,ClientApi)"/>
    public enum ClientApi
    {
        /// <summary>
        /// No context API is created.
        /// </summary>
        NoApi = 0,

        /// <summary>
        /// OpenGL context is created.
        /// </summary>
        OpenGlApi = 0x00030001,

        /// <summary>
        /// OpenGL ES context is created.
        /// </summary>
        OpenGlEsApi = 0x00030002
    }
}
