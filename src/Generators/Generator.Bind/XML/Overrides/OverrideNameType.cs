//
// OverrideNameType.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace Bind.XML.Overrides
{
    /// <summary>
    /// Indicates whether the name of an override refers to the native entrypoint or the public-facing API name.
    /// </summary>
    public enum OverrideNameType
    {
        /// <summary>
        /// Indicates that the name is an entry point.
        /// </summary>
        EntryPoint,

        /// <summary>
        /// Indicates that the name is a name.
        /// </summary>
        Name,
    }
}
