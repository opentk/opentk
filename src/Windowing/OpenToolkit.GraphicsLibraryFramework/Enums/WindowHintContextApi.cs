//
// WindowHintContextApi.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.GraphicsLibraryFramework
{
    /// <summary>
    /// Used to specify the context creation API.
    /// </summary>
    /// <seealso cref="GLFW.WindowHint(WindowHintContextApi,ContextApi)"/>
    public enum WindowHintContextApi
    {
        /// <summary>
        /// Indicates the context creation API used to create the window's context;
        /// either <see cref="ContextApi.NativeContextApi"/> or <see cref="ContextApi.EglContextApi"/>.
        /// </summary>
        ContextCreationApi = 0x0002200B,
    }
}
