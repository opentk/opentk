/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */

using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace Generator.Common
{
    /// <summary>
    /// Various utilities for use by the tool.
    /// </summary>
    public static class Utilities
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
        /// Gets a namespace suffix from the given category name. This will convert something
        /// like EXT_extension_name to EXT.ExtensionName.
        /// </summary>
        /// <param name="name">The category name.</param>
        /// <returns>The namespace name for this category.</returns>
        public static string ConvertExtensionNameToNamespace(string name)
        {
            var ret = string.Empty;
            var split = name.Split('_');
            foreach (var chunk in split)
            {
                var cl = chunk.ToList();
                cl[0] = chunk.Substring(0, 1).ToUpper()[0];
                ret += new string(cl.ToArray()) + ".";
            }

            var firstDot = ret.IndexOf('.');
            var firstHalf = ret.Substring(0, firstDot);
            var secondHalf = ret.Substring(firstDot).Replace(".", string.Empty);

            return firstHalf + "." + secondHalf;
        }

        /// <summary>
        /// Gets the given category name formatted as CamelCase. This will convert something
        /// like EXT_extension_name to EXTExtensionName.
        /// </summary>
        /// <param name="name">The category name.</param>
        /// <returns>The CamelCase version of the category name.</returns>
        public static string ConvertCategoryNameToCamel(string name)
        {
            var ret = string.Empty;
            var split = name.Split('_');
            foreach (var chunk in split)
            {
                var cl = chunk.ToList();
                cl[0] = chunk.Substring(0, 1).ToUpper()[0];
                ret += new string(cl.ToArray());
            }

            return ret;
        }

        /// <summary>
        /// An extension method which returns the given enumerable without duplicate elements.
        /// </summary>
        /// <param name="enumerable">The enumerable to process.</param>
        /// <typeparam name="T">The type contained within this enumerable.</typeparam>
        /// <returns>An enumerable with no duplicates.</returns>
        public static IEnumerable<T> RemoveDuplicates<T>(this IEnumerable<T> enumerable)
        {
            // note: this is required because ApiProfile.GetCategories() returns duplicates.
            var ret = new List<T>();
            foreach (var item in enumerable)
            {
                if (!ret.Contains(item))
                {
                    ret.Add(item);
                }
            }

            return ret;
        }
    }
}
