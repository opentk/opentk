//
// ITranslator.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using JetBrains.Annotations;

namespace Bind.Translation.Translators
{
    /// <summary>
    /// Interface for a type that can translate the contents an instance from one format to another.
    /// </summary>
    /// <typeparam name="TInput">The type to translate.</typeparam>
    public interface ITranslator<TInput>
    {
        /// <summary>
        /// Translates the given instance.
        /// </summary>
        /// <param name="input">The instance to translate.</param>
        /// <returns>The new, translated, instance.</returns>
        [NotNull]
        TInput Translate([NotNull] TInput input);
    }
}
