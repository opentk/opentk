//
// MULAWFormat.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using OpenTK.Core.Extensions;
using OpenTK.Core.Loader;
using OpenTK.OpenAL.Extensions.EXT.MULAWFormat.Enums;
using OpenTK.OpenAL.Extensions.EXT.MULAWFormat.Interfaces;

namespace OpenTK.OpenAL.Extensions.EXT.MULAWFormat
{
    /// <summary>
    /// Exposes the multi-channel buffers extension by Creative Labs.
    /// </summary>
    [Extension("AL_EXT_MULAW")]
    public abstract class MULAWFormat : FormatExtensionBase<MULAWBufferFormat>, IMULAWFormat
    {
        /// <inheritdoc cref="ExtensionBase"/>
        protected MULAWFormat(string path, ImplementationOptions options)
            : base(path, options)
        {
        }
    }
}
