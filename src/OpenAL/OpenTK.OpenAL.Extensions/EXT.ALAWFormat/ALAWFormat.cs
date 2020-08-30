//
// ALAWFormat.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using AdvancedDLSupport;
using OpenTK.Core.Extensions;
using OpenTK.Core.Loader;

namespace OpenTK.OpenAL.Extensions.EXT.ALAWFormat
{
    /// <summary>
    /// Exposes the multi-channel buffers extension by Creative Labs.
    /// </summary>
    [Extension("AL_EXT_ALAW")]
    public abstract class ALAWFormat : FormatExtensionBase<ALAWBufferFormat>, IALAWFormat
    {
        /// <inheritdoc cref="ExtensionBase"/>
        protected ALAWFormat(string path, ImplementationOptions options)
            : base(path, options)
        {
        }
    }
}
