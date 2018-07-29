using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Bind.XML.Documentation
{
    /// <summary>
    /// Represents documentation of a function.
    /// </summary>
    public class FunctionDocumentation
    {
        /// <summary>
        /// Gets the name of the function. This is the function's entry point.
        /// </summary>
        [NotNull]
        public string Name { get; }

        /// <summary>
        /// Gets the purpose of the function.
        /// </summary>
        [NotNull]
        public string Purpose { get; }

        /// <summary>
        /// Gets the function's parameters.
        /// </summary>
        [NotNull, ItemNotNull]
        public IReadOnlyList<ParameterDocumentation> Parameters { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDocumentation"/> class.
        /// </summary>
        /// <param name="name">The name of the function.</param>
        /// <param name="purpose">The purpose of the function.</param>
        /// <param name="parameters">The parameters of the function.</param>
        public FunctionDocumentation
        (
            [NotNull] string name,
            [NotNull] string purpose,
            [NotNull, ItemNotNull] IReadOnlyList<ParameterDocumentation> parameters
        )
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Purpose = purpose ?? throw new ArgumentNullException(nameof(purpose));
            Parameters = parameters ?? throw new ArgumentNullException(nameof(parameters));
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{Name} - {Purpose}";
        }
    }
}
