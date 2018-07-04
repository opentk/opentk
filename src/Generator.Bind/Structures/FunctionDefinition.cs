/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */

using System;

namespace Bind.Structures
{
    /// <summary>
    /// Represents a documented, name-trimmed function that wraps a delegate definition.
    /// </summary>
    internal class FunctionDefinition : DelegateDefinition, IEquatable<FunctionDefinition>, IComparable<FunctionDefinition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDefinition"/> class.
        /// </summary>
        /// <param name="d">The delegate definition to wrap.</param>
        public FunctionDefinition(DelegateDefinition d)
            : base(d)
        {
            TrimmedName = Name = d.Name;
            WrappedDelegateDefinition = d;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDefinition"/> class.
        /// This constructor performs a deep copy of the given definition.
        /// </summary>
        /// <param name="f">The definition to copy.</param>
        public FunctionDefinition(FunctionDefinition f)
            : this(f.WrappedDelegateDefinition)
        {
            Parameters = new ParameterCollection(f.Parameters);
            ReturnTypeDefinition = new TypeDefinition(f.ReturnTypeDefinition);
            TrimmedName = f.TrimmedName;
            ObsoletionReason = f.ObsoletionReason;
            DocumentationDefinition = f.DocumentationDefinition;
        }

        /// <summary>
        /// Gets or sets the delegate definition that the function definition wraps.
        /// </summary>
        public DelegateDefinition WrappedDelegateDefinition { get; set; }

        /// <summary>
        /// Gets or sets the trimmed name of this function.
        /// </summary>
        public string TrimmedName { get; set; }

        /// <summary>
        /// Gets or sets the documentation definition for this function.
        /// </summary>
        public DocumentationDefinition DocumentationDefinition { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{ReturnTypeDefinition} {TrimmedName}{Parameters}";
        }

        /// <inheritdoc/>
        public bool Equals(FunctionDefinition other)
        {
            var result =
                !string.IsNullOrEmpty(TrimmedName) && !string.IsNullOrEmpty(other.TrimmedName) &&
                TrimmedName.Equals(other.TrimmedName) &&
                Parameters.Equals(other.Parameters);
            return result;
        }

        /// <inheritdoc/>
        public int CompareTo(FunctionDefinition other)
        {
            var ret = string.Compare(Name, other.Name, StringComparison.Ordinal);
            if (ret == 0)
            {
                ret = Parameters.CompareTo(other.Parameters);
            }
            if (ret == 0)
            {
                ret = ReturnTypeDefinition.CompareTo(other.ReturnTypeDefinition);
            }
            return ret;
        }
    }
}
