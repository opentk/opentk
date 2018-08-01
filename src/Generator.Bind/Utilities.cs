/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Bind.Structures;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis.CSharp;

namespace Bind
{
    /// <summary>
    /// Various utilities for use by the tool.
    /// </summary>
    internal static class Utilities
    {
        /// <summary>
        /// Gets a regular expression that matches against three or more consecutive capital characters at the end of a
        /// string.
        /// </summary>
        public static readonly Regex UnprocessedEndingRegex = new Regex("[A-Z]{3,}$", RegexOptions.Compiled);

        /// <summary>
        /// Gets a list of keywords in the C# language.
        /// </summary>
        [NotNull]
        public static List<string> CSharpKeywords => new List<string>
        {
            "abstract",
            "event",
            "new",
            "struct",
            "as",
            "explicit",
            "null",
            "switch",
            "base",
            "extern",
            "object",
            "this",
            "bool",
            "false",
            "operator",
            "throw",
            "break",
            "finally",
            "out",
            "true",
            "byte",
            "fixed",
            "override",
            "try",
            "case",
            "float",
            "params",
            "typeof",
            "catch",
            "for",
            "private",
            "uint",
            "char",
            "foreach",
            "protected",
            "ulong",
            "checked",
            "goto",
            "public",
            "unchecked",
            "class",
            "if",
            "readonly",
            "unsafe",
            "const",
            "implicit",
            "ref",
            "ushort",
            "continue",
            "in",
            "return",
            "using",
            "decimal",
            "int",
            "sbyte",
            "virtual",
            "default",
            "interface",
            "sealed",
            "volatile",
            "delegate",
            "internal",
            "short",
            "void",
            "do",
            "is",
            "sizeof",
            "while",
            "double",
            "lock",
            "stackalloc",
            "else",
            "long",
            "static",
            "enum",
            "namespace",
            "string"
        };

        /// <summary>
        /// Merges one enum collection into another.
        /// </summary>
        /// <param name="currentEnums">The enum collection to merge into.</param>
        /// <param name="newEnums">The enums to merge.</param>
        internal static void Merge(EnumCollection currentEnums, [NotNull] EnumCollection newEnums)
        {
            foreach (var e in newEnums)
            {
                Merge(currentEnums, e.Value);
            }
        }

        /// <summary>
        /// Merges the given enum into the enum list. If an enum of the same name exists,
        /// it merges their respective constants.
        /// </summary>
        /// <param name="currentEnums">The enums.</param>
        /// <param name="newEnum">The new enum.</param>
        internal static void Merge([NotNull] EnumCollection currentEnums, [NotNull] EnumDefinition newEnum)
        {
            if (!currentEnums.ContainsKey(newEnum.Name))
            {
                currentEnums.Add(newEnum.Name, newEnum);
            }
            else
            {
                var e = currentEnums[newEnum.Name];
                foreach (var c in newEnum.ConstantCollection.Values)
                {
                    Merge(e, c);
                }
            }
        }

        /// <summary>
        /// Places a new constant in the specified enum, if it doesn't already exist.
        /// The existing constant is replaced if the new has a numeric value and the old
        /// has a reference value (eg 0x5 is preferred over AttribMask.Foo).
        /// </summary>
        /// <param name="enumDefinition">The enumeration definiton.</param>
        /// <param name="constantDefinition">The constant definition.</param>
        internal static void Merge([NotNull] EnumDefinition enumDefinition, [NotNull] ConstantDefinition constantDefinition)
        {
            if (!enumDefinition.ConstantCollection.ContainsKey(constantDefinition.Name))
            {
                enumDefinition.ConstantCollection.Add(constantDefinition.Name, constantDefinition);
            }
            else
            {
                // Tried to add a constant that already exists. If one constant
                // is like: 'Foo = 0x5' and the other like: 'Foo = Bar.Foo', then
                // keep the first one.
                if (!string.IsNullOrEmpty(enumDefinition.ConstantCollection[constantDefinition.Name].Reference))
                {
                    enumDefinition.ConstantCollection[constantDefinition.Name] = constantDefinition;
                }
            }
        }

        /// <summary>
        /// Gets an array declaration string that matches the given level of array dimensions.
        /// </summary>
        /// <param name="arrayDimensions">The dimension.</param>
        /// <returns>The string.</returns>
        [NotNull]
        public static string GetArrayDimensionString(int arrayDimensions)
        {
            if (arrayDimensions == 0)
            {
                return string.Empty;
            }

            var builder = new StringBuilder();
            builder.Append('[');
            builder.Append(new string(',', arrayDimensions - 1));
            builder.Append(']');

            return builder.ToString();
        }

        /// <summary>
        /// Determines whether or not the given identifier has already been translated.
        /// </summary>
        /// <param name="identifier">The identifier.</param>
        /// <returns>true if the identifier has been translated; otherwise, false.</returns>
        public static bool IsIdentifierTranslated([NotNull] string identifier)
        {
            if (!SyntaxFacts.IsValidIdentifier(identifier))
            {
                return false;
            }

            if (identifier.Contains("_") || identifier.Contains("-"))
            {
                return false;
            }

            if (identifier.Where(c => !char.IsDigit(c)).All(char.IsUpper))
            {
                return false;
            }

            if (UnprocessedEndingRegex.IsMatch(identifier))
            {
                return false;
            }

            return true;
        }
    }
}
