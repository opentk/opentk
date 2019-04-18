using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace Bind.XML.Signatures.Functions
{
    /// <summary>
    /// Represents a computed or static element count of a parameter. A computed parameter varies its count based on the
    /// input arguments the user provides, and is extremely difficult (if not wholly impossible) to predict accurately.
    ///
    /// Therefore, these counts tend to generate a set of catch-all signatures (such as a single element, a pointer, an
    /// array, and a ref).
    /// </summary>
    public class CountSignature
    {
        /// <summary>
        /// Backing field for <see cref="Count"/>.
        /// </summary>
        private int _count;

        /// <summary>
        /// Gets the static count of the parameter.
        /// </summary>
        /// <exception cref="InvalidOperationException">Thrown if the count varies based on other parameters.</exception>
        public int Count
        {
            get
            {
                if (IsComputed)
                {
                    throw new InvalidOperationException
                    (
                        $"The count varies based on other parameters. Use {nameof(ComputedFrom)} instead."
                    );
                }

                if (IsReference)
                {
                    throw new InvalidOperationException
                    (
                        $"The count is a reference to a value in another parameter. Use {nameof(ValueReference)} instead."
                    );
                }

                return _count;
            }
        }

        /// <summary>
        /// Gets the parameter that the count is taken from.
        /// </summary>
        [CanBeNull]
        public ParameterSignature ValueReference { get; }

        /// <summary>
        /// Gets the parameters that the count is computed from.
        /// </summary>
        [NotNull]
        public IReadOnlyList<ParameterSignature> ComputedFrom { get; }

        /// <summary>
        /// Gets a value indicating whether the count is computed from other parameters.
        /// </summary>
        public bool IsComputed => ComputedFrom.Any();

        /// <summary>
        /// Gets a value indicating whether the count is a reference to the value of another parameter.
        /// </summary>
        public bool IsReference => !(ValueReference is null);

        /// <summary>
        /// Gets a value indicating whether the count is a static count.
        /// </summary>
        public bool IsStatic => !(IsComputed || IsReference);

        /// <summary>
        /// Initializes a new instance of the <see cref="CountSignature"/> class.
        /// </summary>
        /// <param name="count">The static count.</param>
        public CountSignature(int count)
        {
            _count = count;
            ComputedFrom = new List<ParameterSignature>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CountSignature"/> class.
        /// </summary>
        /// <param name="computedFrom">The parameters the count is computed from.</param>
        public CountSignature([NotNull] IReadOnlyList<ParameterSignature> computedFrom)
        {
            ComputedFrom = computedFrom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CountSignature"/> class.
        /// </summary>
        /// <param name="valueReference">The parameter the count is taken from.</param>
        public CountSignature([CanBeNull] ParameterSignature valueReference)
        {
            ValueReference = valueReference;
            ComputedFrom = new List<ParameterSignature>();
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            if (IsComputed)
            {
                return $"COMPSIZE({string.Join(", ", ComputedFrom.Select(p => p.Name))})";
            }

            if (IsReference)
            {
                return $"valueof({ValueReference.Name})";
            }

            return Count.ToString();
        }
    }
}
