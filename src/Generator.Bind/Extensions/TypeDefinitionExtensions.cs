using System;
using System.Collections.Generic;
using Bind.Structures;

namespace Bind.Extensions
{
    /// <summary>
    /// Extension methods for the <see cref="TypeDefinition"/> class.
    /// </summary>
    public static class TypeDefinitionExtensions
    {
        private static readonly Dictionary<string, string> Aliases = new Dictionary<string, string>
        {
            { nameof(SByte), "sbyte" },
            { nameof(Byte), "byte" },
            { nameof(Int16), "short" },
            { nameof(UInt16), "ushort" },
            { nameof(Int32), "int" },
            { nameof(UInt32), "uint" },
            { nameof(Int64), "long" },
            { nameof(UInt64), "ulong" },
            { nameof(Single), "float" },
            { nameof(Double), "double" },
            { nameof(String), "string" },
            { nameof(Boolean), "bool" },
        };

        /// <summary>
        /// Gets the qualified type name of the definition, or the CLR alias of the type (if there is one).
        /// </summary>
        /// <param name="this">The type definition.</param>
        /// <returns>The qualified type name or alias.</returns>
        public static string GetQualifiedTypeOrAlias(this TypeDefinition @this)
        {
            if (Aliases.ContainsKey(@this.QualifiedTypeName))
            {
                return Aliases[@this.QualifiedTypeName];
            }

            return @this.QualifiedTypeName;
        }
    }
}
