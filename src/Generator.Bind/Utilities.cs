/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */

using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bind.Translation.Trimmers;
using Bind.XML.Overrides.Functions;
using JetBrains.Annotations;

namespace Bind
{
    /// <summary>
    /// Various utilities for use by the tool.
    /// </summary>
    internal static class Utilities
    {
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
        /// Gets the possible variations on the base name of the given override. Typically, this boils down to the
        /// following three cases, in order:
        ///
        /// * FunctionNamefvEXT
        /// * FunctionNamefv
        /// * FunctionName
        ///
        /// Care should be taken when creating new overrides that the intended function is targeted.
        /// </summary>
        /// <param name="functionOverride">The override to create variations of.</param>
        /// <returns>The name variations, ordered by length, starting with the longest.</returns>
        [NotNull, ItemNotNull]
        public static IEnumerable<string> GetNameVariations([NotNull] FunctionOverride functionOverride)
        {
            var extensionTrimmer = new OpenGLFunctionExtensionTrimmer();
            var dataTypeTrimmer = new OpenGLFunctionDataTypeTrimmer();

            var variations = new List<string>();
            var currentVariation = functionOverride.BaseName;

            variations.Add(currentVariation);

            if (extensionTrimmer.IsRelevant(functionOverride))
            {
                currentVariation = extensionTrimmer.Trim(functionOverride);
                variations.Add(currentVariation);
            }

            if (dataTypeTrimmer.IsRelevant(currentVariation))
            {
                variations.Add(dataTypeTrimmer.Trim(currentVariation));
            }

            return variations.Distinct().OrderByDescending(v => v.Length);
        }

        /// <summary>
        /// Gets the possible variations on the given entry point. Typically, this boils down to the
        /// following three cases, in order:
        ///
        /// * FunctionNamefvEXT
        /// * FunctionNamefv
        /// * FunctionName
        ///
        /// Care should be taken when creating new overrides that the intended function is targeted.
        /// </summary>
        /// <param name="functionEntrypoint">The entrypoint to create variations of.</param>
        /// <returns>The name variations, ordered by length, starting with the longest.</returns>
        [NotNull, ItemNotNull]
        public static IEnumerable<string> GetNameVariations(string functionEntrypoint)
        {
            var extensionTrimmer = new OpenGLFunctionExtensionTrimmer();
            var dataTypeTrimmer = new OpenGLFunctionDataTypeTrimmer();

            var variations = new List<string>();
            var currentVariation = functionEntrypoint;

            variations.Add(currentVariation);

            if (extensionTrimmer.IsRelevant(currentVariation))
            {
                currentVariation = extensionTrimmer.Trim(currentVariation);
                variations.Add(currentVariation);
            }

            if (dataTypeTrimmer.IsRelevant(currentVariation))
            {
                variations.Add(dataTypeTrimmer.Trim(currentVariation));
            }

            return variations.Distinct().OrderByDescending(v => v.Length);
        }
    }
}
