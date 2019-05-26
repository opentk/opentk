//
// ITrimmer.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using JetBrains.Annotations;

namespace Bind.Translation.Trimmers
{
    /// <summary>
    /// Represents a class that can trim the identifier for some type in some fashion.
    /// </summary>
    /// <typeparam name="TTrimmable">The trimmable type.</typeparam>
    public interface ITrimmer<TTrimmable>
    {
        /// <summary>
        /// Determines if the name trimmer is relevant for the given type.
        /// </summary>
        /// <param name="trimmable">The type to check.</param>
        /// <returns>true if the name trimmer is relevant; otherwise, false.</returns>
        bool IsRelevant([NotNull] TTrimmable trimmable);

        /// <summary>
        /// Trims the given type.
        /// </summary>
        /// <param name="trimmable">The type to trim.</param>
        /// <returns>The trimmed type.</returns>
        [NotNull]
        [Pure]
        TTrimmable Trim([NotNull] TTrimmable trimmable);
    }
}
