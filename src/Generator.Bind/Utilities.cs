/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Bind.Structures;
using Humanizer;
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
        /// Gets a set of overrides used for name translation when dealing with complicated extensions and acronyms.
        /// </summary>
        public static readonly IReadOnlyDictionary<string, string> ExtensionAndAcronymOverrides = new Dictionary<string, string>
        {
            { "CMAAINTEL", "CmaaIntel" },
            { "QCOM", "QCom" },
            { "SNORM", "SNorm" }
        };

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
        /// Translates an identifer name into a C#-style PascalCase name.
        /// </summary>
        /// <param name="name">The name to translate.</param>
        /// <returns>The translated name.</returns>
        [NotNull]
        public static string TranslateIdentifierName([NotNull] string name)
        {
            // TODO: Remove this once we're no longer calling this method more than once on a given name
            if (IsIdentifierTranslated(name))
            {
                return name;
            }

            var builder = new StringBuilder(name);

            var longAcronymsRegex = new Regex("(?<![A-Z])[A-Z]{3,}(?![A-Z])");
            foreach (var match in longAcronymsRegex.Matches(builder.ToString()).Cast<Match>())
            {
                if (!ExtensionAndAcronymOverrides.TryGetValue(match.Value, out var replacement))
                {
                    replacement = match.Value.Transform(To.LowerCase, To.TitleCase);
                }

                builder.Remove(match.Index, match.Length);
                builder.Insert(match.Index, replacement);
            }

            var shortNonAcronymsRegex = new Regex("(?<![A-Z])(IS|AS|NO|ON|TO|OP|BY|OF|IN|UP|OR)(?![A-Z])");
            foreach (var match in shortNonAcronymsRegex.Matches(builder.ToString()).Cast<Match>())
            {
                builder.Remove(match.Index, match.Length);
                builder.Insert(match.Index, match.Value.Transform(To.LowerCase, To.TitleCase));
            }

            var dataTypeIdentifiersRegex = new Regex("\\dU?(F|I)");
            foreach (var match in dataTypeIdentifiersRegex.Matches(builder.ToString()).Cast<Match>())
            {
                builder.Remove(match.Index, match.Length);
                builder.Insert(match.Index, match.Value.Transform(To.LowerCase, To.TitleCase));
            }

            if (char.IsDigit(builder[0]))
            {
                builder.Insert(0, "C");
            }

            var newName = builder.ToString().Pascalize();
            return newName;
        }

        private static bool IsIdentifierTranslated([NotNull] string identifier)
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

            var unprocessedEndingRegex = new Regex("[A-Z]{3,}$");
            if (unprocessedEndingRegex.IsMatch(identifier))
            {
                return false;
            }

            return true;
        }
    }
}
