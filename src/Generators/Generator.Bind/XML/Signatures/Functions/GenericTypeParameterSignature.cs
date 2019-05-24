using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Bind.XML.Signatures.Functions
{
    /// <summary>
    /// Represents a generic type parameter in an API.
    /// </summary>
    public class GenericTypeParameterSignature
    {
        /// <summary>
        /// Gets the name of the generic type parameter.
        /// </summary>
        [NotNull]
        public string Name { get; }

        /// <summary>
        /// Gets the type constraints on the parameter.
        /// </summary>
        [NotNull]
        public IReadOnlyList<string> Constraints { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericTypeParameterSignature"/> class.
        /// </summary>
        /// <param name="name">The name of the generic parameter.</param>
        /// <param name="constraints">The constraints on the parameter, if any.</param>
        public GenericTypeParameterSignature
        (
            [NotNull] string name,
            [CanBeNull] IReadOnlyList<string> constraints = null
        )
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Constraints = constraints ?? new List<string>();
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return Name;
        }
    }
}
