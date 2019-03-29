//
// ContextApi.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.GraphicsLibraryFramework
{
    /// <summary>
    /// The context API used to create the window context.
    /// </summary>
    public enum ContextApi
    {
        /// <summary>
        /// Uses the native context API to create the window context.
        /// </summary>
        NativeContextApi = 0x00036001,

        /// <summary>
        /// Uses Egl to create the window context.
        /// </summary>
        EglContextApi = 0x00036002
    }
}
