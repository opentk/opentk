/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */

using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Bind.Structures;

namespace Bind
{
    /// <summary>
    /// Various utilities for use by the tool.
    /// </summary>
    internal static class Utilities
    {
        /// <summary>
        /// Gets a regex that matches known extension names in the specification.
        /// </summary>
        public static Regex Extensions { get; private set; }

        /// <summary>
        /// Gets a regex that matches known acronyms used by the specification.
        /// </summary>
        public static Regex Acronyms { get; private set; }

        // Both GL and ES contains SGI extension enums, even though no function
        // uses them. This is a remnant from the glory days of gl.spec and GL 1.1.
        // Note: REMOVING THESE WILL BREAK BINARY-COMPATIBILITY WITH OPENTK 1.0,
        // WRT THE ES 1.1 API.
        // You have been warned.
        private static List<string> _extensionNames = new List<string>
        {
            "SGI", "SGIS", "SGIX", "IBM", "AMD", "INTEL",
        };

        /// <summary>
        /// Merges the given extensions into the current set of extensions.
        /// </summary>
        /// <param name="extensions">The extensions to merge in.</param>
        public static void AddExtensions(IEnumerable<string> extensions)
        {
            // Merge the new extensions with the current list of extensions
            var extensionCount = _extensionNames.Count;
            _extensionNames.AddRange(
                extensions.Where(n => !_extensionNames.Contains(n)));

            // If any new extensions have been added,
            // recreate the Extensions regex.
            if (_extensionNames.Count != extensionCount)
            {
                // Sort longest extensions first, otherwise SGIS may be
                // incorrectly matched as SGI.
                _extensionNames.Sort((a, b) => b.Length.CompareTo(a.Length));

                Extensions = new Regex(
                    string.Join("|", _extensionNames.ToArray()),
                    RegexOptions.Compiled);

                var acronyms = new[]
                {
                    "EGL",  "ES", "GL", "CL",
                    "RGBA", "BGRA", "RGB", "BGR",
                    "SRGB", "YCBCR",
                    "3TC", "DXT", "BPTC", "RGTC",
                    "3DC", "ATC", "ETC",
                    "ANGLE",  "MESAX", "MESA",
                    "ATI"
                };

                var acronymNames = extensions.Concat(acronyms).ToList();
                acronymNames.Sort((a, b) => b.Length.CompareTo(a.Length));
                Acronyms = new Regex(string.Join("|", acronymNames.ToArray()), RegexOptions.Compiled);
            }
        }

        /// <summary>
        /// Gets a list of keywords in the C# language.
        /// </summary>
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
        internal static void Merge(EnumCollection currentEnums, EnumCollection newEnums)
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
        internal static void Merge(EnumCollection currentEnums, EnumDefinition newEnum)
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
        internal static void Merge(EnumDefinition enumDefinition, ConstantDefinition constantDefinition)
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
        /// Gets the name of the specification extension that the given name is a part of.
        /// </summary>
        /// <param name="name">The name to inspect.</param>
        /// <param name="returnUnmodified">
        /// Whether or not to return the extension name unmodified. If false, the extension name will be turned to title
        /// case.
        /// </param>
        /// <returns>The extension name.</returns>
        internal static string GetExtension(string name, bool returnUnmodified)
        {
            var match = Extensions.Match(name);
            if (!match.Success)
            {
                return string.Empty;
            }

            var ext = match.Value;

            if (returnUnmodified)
            {
                return ext;
            }

            if (ext.Length > 2)
            {
                ext = ext[0] + ext.Substring(1).ToLower();
            }

            return ext;
        }
    }
}
