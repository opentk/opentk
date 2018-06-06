/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */

using System;

namespace Bind.Structures
{
    internal class FunctionDefinition : DelegateDefinition, IEquatable<FunctionDefinition>, IComparable<FunctionDefinition>
    {
        public FunctionDefinition(DelegateDefinition d)
            : base(d)
        {
            TrimmedName = Name = d.Name;
            WrappedDelegateDefinition = d;
        }

        public FunctionDefinition(FunctionDefinition f)
            : this(f.WrappedDelegateDefinition)
        {
            Parameters = new ParameterCollection(f.Parameters);
            ReturnTypeDefinition = new TypeDefinition(f.ReturnTypeDefinition);
            TrimmedName = f.TrimmedName;
            Obsolete = f.Obsolete;
            DocumentationDefinition = f.DocumentationDefinition;
        }

        public DelegateDefinition WrappedDelegateDefinition { get; set; }

        public string TrimmedName { get; set; }

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
            var ret = String.Compare(Name, other.Name, StringComparison.Ordinal);
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
