//
// IALC.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using AdvancedDLSupport;
using OpenToolkit.Core.API;
using OpenToolkit.Core.Loader;

namespace OpenToolkit.OpenAL.Interfaces
{
    /// <summary>
    /// Defines the public interface of the context in the OpenAL 1.1 library.
    /// </summary>
    [NativeSymbols(Prefix = "alc")]
    [DefaultPlatformLibrary(typeof(OpenALLibraryNameContainer))]
    internal interface IALC : IAPI, IContext, IContextDevices, IContextErrors, IContextExtensions, IContextState
    {
    }
}
