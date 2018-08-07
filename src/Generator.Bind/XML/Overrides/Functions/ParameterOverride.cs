using System;
using Bind.XML.Signatures;
using Bind.XML.Signatures.Functions;
using JetBrains.Annotations;

namespace Bind.XML.Overrides.Functions
{
    /// <summary>
    /// Represents an overridden parameter.
    /// </summary>
    public class ParameterOverride
    {
        /// <summary>
        /// Gets the name of the parameter that the override affects.
        /// </summary>
        [NotNull]
        public string BaseName { get; }

        /// <summary>
        /// Gets the new name of the parameter.
        /// </summary>
        [CanBeNull]
        public string NewName { get; }

        /// <summary>
        /// Gets the new type of the parameter.
        /// </summary>
        [CanBeNull]
        public TypeSignature NewType { get; }

        /// <summary>
        /// Gets the new flow of the parameter.
        /// </summary>
        [CanBeNull]
        public FlowDirection? NewFlow { get; }

        /// <summary>
        /// Gets the new count of the parameter. The count is validated and built into a <see cref="CountSignature"/> in
        /// the baking step.
        /// </summary>
        [CanBeNull]
        public string NewCount { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterOverride"/> class.
        /// </summary>
        /// <param name="name">The base name of the parameter.</param>
        /// <param name="newName">The new name of the parameter.</param>
        /// <param name="newType">The new type of the parameter.</param>
        /// <param name="newFlow">The new flow of the parameter.</param>
        /// <param name="newCount">The new count of the parameter.</param>
        public ParameterOverride
        (
            [NotNull] string name,
            [CanBeNull] string newName,
            [CanBeNull] TypeSignature newType,
            FlowDirection? newFlow,
            [CanBeNull] string newCount
        )
        {
            BaseName = name ?? throw new ArgumentNullException(nameof(name));
            NewName = newName;
            NewType = newType;
            NewFlow = newFlow;
            NewCount = newCount;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{NewType} {NewName ?? BaseName}".Trim();
        }
    }
}
