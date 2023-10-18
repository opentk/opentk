//
// ALAWFormat.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using OpenTK.Core.Extensions;
using OpenTK.Core.Loader;
using OpenTK.OpenAL.Extensions.EXT.ALAWFormat.Enums;
using OpenTK.OpenAL.Extensions.EXT.ALAWFormat.Interfaces;

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
