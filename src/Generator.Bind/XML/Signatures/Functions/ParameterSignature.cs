using System;
using JetBrains.Annotations;

namespace Bind.XML.Signatures.Functions
{
    /// <summary>
    /// Represents a parameter signature in an API, held within a function.
    /// </summary>
    public class ParameterSignature
    {
        /// <summary>
        /// Gets the name of the parameter.
        /// </summary>
        [NotNull]
        public string Name { get; }

        /// <summary>
        /// Gets the type of the parameter.
        /// </summary>
        [NotNull]
        public TypeSignature Type { get; }

        /// <summary>
        /// Gets the flow of the parameter, that is, if it's an input or output parameter.
        /// </summary>
        public FlowDirection Flow { get; }

        /// <summary>
        /// Gets the computed or static count of the parameter, that is, how many elements the parameter contains.
        ///
        /// This is primarily used when marshalling pointers or arrays - for example, a three-element vector into an
        /// element pointer.
        /// </summary>
        [CanBeNull]
        public CountSignature Count { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterSignature"/> class.
        /// </summary>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="type">The type of the parameter.</param>
        /// <param name="flow">The flow of the parameter. Defaults to <see cref="FlowDirection.In"/>.</param>
        /// <param name="count">The count of the parameter. Optional.</param>
        public ParameterSignature
        (
            [NotNull] string name,
            [NotNull] TypeSignature type,
            FlowDirection flow = FlowDirection.In,
            [CanBeNull] CountSignature count = null
        )
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Type = type ?? throw new ArgumentNullException(nameof(type));
            Flow = flow;
            Count = count;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{Type} {(Utilities.CSharpKeywords.Contains(Name) ? $"@{Name}" : Name)}";
        }
    }
}
