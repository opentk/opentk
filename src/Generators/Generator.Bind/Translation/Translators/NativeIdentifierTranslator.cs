//
// NativeIdentifierTranslator.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Humanizer;
using JetBrains.Annotations;

namespace Bind.Translation.Translators
{
    /// <summary>
    /// Translates an identifier (a type name, a constant name, etc) into a .NET-style identifier.
    /// </summary>
    public class NativeIdentifierTranslator : ITranslator<string>
    {
        /// <summary>
        /// Gets a regular expression that matches against isolated long acronyms (3+ capital characters).
        /// </summary>
        private static readonly Regex LongAcronymsRegex = new Regex("(?<![A-Z])[A-Z]{3,}(?![A-Z])", RegexOptions.Compiled);

        /// <summary>
        /// Gets a regular expression that matches against short acronym candidates, which should still be transformed.
        /// </summary>
        private static readonly Regex ShortNonAcronymsRegex = new Regex("(?<![A-Z])(IS|AS|NO|ON|TO|OP|BY|OF|IN|UP|OR)(?![A-Z])", RegexOptions.Compiled);

        /// <summary>
        /// Gets a regular expression that matches against simple data type identifiers in other identifiers.
        /// </summary>
        private static readonly Regex DataTypeIdentifersRegex = new Regex("\\dU?(F|I)", RegexOptions.Compiled);

        /// <summary>
        /// Gets a set of overrides used for name translation when dealing with complicated extensions and acronyms.
        /// </summary>
        public static readonly IReadOnlyDictionary<string, string> ExtensionAndAcronymOverrides = new Dictionary<string, string>
        {
            { "CMAAINTEL", "CmaaIntel" },
            { "QCOM", "QCom" },
            { "SNORM", "SNorm" },
        };

        /// <summary>
        /// Translates an identifier name into a C#-style PascalCase name.
        /// </summary>
        /// <param name="name">The name to translate.</param>
        /// <returns>The translated name.</returns>
        [NotNull]
        public static string TranslateIdentifierName([NotNull] string name)
        {
            var builder = new StringBuilder(name);

            foreach (var match in LongAcronymsRegex.Matches(builder.ToString()).Cast<Match>())
            {
                if (!ExtensionAndAcronymOverrides.TryGetValue(match.Value, out var replacement))
                {
                    replacement = match.Value.Transform(To.LowerCase, To.TitleCase);
                }

                builder.Remove(match.Index, match.Length);
                builder.Insert(match.Index, replacement);
            }

            foreach (var match in ShortNonAcronymsRegex.Matches(builder.ToString()).Cast<Match>())
            {
                builder.Remove(match.Index, match.Length);
                builder.Insert(match.Index, match.Value.Transform(To.LowerCase, To.TitleCase));
            }

            foreach (var match in DataTypeIdentifersRegex.Matches(builder.ToString()).Cast<Match>())
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

        /// <inheritdoc/>
        public string Translate(string input)
        {
            return TranslateIdentifierName(input);
        }
    }
}
