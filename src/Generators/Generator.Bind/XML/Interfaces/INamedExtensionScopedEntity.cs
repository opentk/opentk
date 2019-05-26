//
// INamedExtensionScopedEntity.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using JetBrains.Annotations;

namespace Bind.XML
{
    /// <summary>
    /// Interface for a named entity that can exist within an API extension.
    /// </summary>
    public interface INamedExtensionScopedEntity
    {
        /// <summary>
        /// Gets the name of the entity.
        /// </summary>
        [NotNull]
        string Name { get; }

        /// <summary>
        /// Gets the extension the entity belongs to.
        /// </summary>
        [CanBeNull]
        string Extension { get; }
    }
}
