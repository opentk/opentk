//
// IMapper.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using JetBrains.Annotations;

namespace Bind.Translation.Mappers
{
    /// <summary>
    /// Interface for types that can map one instance of an object to another.
    /// </summary>
    /// <typeparam name="TInput">The type that can be mapped.</typeparam>
    public interface IMapper<TInput>
    {
        /// <summary>
        /// Determines whether or not the input instance has a mapping.
        /// </summary>
        /// <param name="input">The instance.</param>
        /// <returns>true if the instance has a mapping; otherwise, false.</returns>
        bool HasMapping([NotNull] TInput input);

        /// <summary>
        /// Maps the given <typeparamref name="TInput"/> to another.
        /// </summary>
        /// <param name="input">The instance to map.</param>
        /// <returns>The mapped instance.</returns>
        [NotNull]
        TInput Map([NotNull] TInput input);
    }
}
