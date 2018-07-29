﻿//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2010 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml.XPath;
using Bind.Generators;
using Bind.Structures;
using Bind.Translation.Translators;
using JetBrains.Annotations;

namespace Bind
{
    /// <summary>
    /// Generator class for enumerations.
    /// </summary>
    internal class EnumProcessor
    {
        private readonly IEnumerable<string> _overrides;

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumProcessor"/> class.
        /// </summary>
        /// <param name="generator">The API generator.</param>
        /// <param name="overrides">The override file paths.</param>
        public EnumProcessor([NotNull] IGenerator generator, [NotNull] IEnumerable<string> overrides)
        {
            Generator = generator ?? throw new ArgumentNullException(nameof(generator));
            _overrides = overrides ?? throw new ArgumentNullException(nameof(overrides));
        }

        private IGenerator Generator { get; }

        /// <summary>
        /// Generates a collection of enumerations using the given API name.
        /// </summary>
        /// <param name="enums">The base enum collection to use.</param>
        /// <param name="apiname">The name of the API.</param>
        /// <returns>A collection of enums.</returns>
        [NotNull]
        public EnumCollection Process([NotNull] EnumCollection enums, [NotNull] string apiname)
        {
            foreach (var file in _overrides)
            {
                Console.WriteLine("Processing enums in {0}.", file);

                var nav = new XPathDocument(file).CreateNavigator();
                enums = ProcessNames(enums, nav, apiname);
                enums = ProcessConstants(enums, nav, apiname);
            }

            return enums;
        }

        /// <summary>
        /// Gets an XML path to an enumeration overrides node, given the API name and enumeration name.
        /// </summary>
        /// <param name="apiname">The API name.</param>
        /// <param name="enumeration">The enumeration name.</param>
        /// <returns>The node path.</returns>
        /// <exception cref="ArgumentNullException">Thrown if <paramref name="enumeration"/> is null.</exception>
        [NotNull]
        public static string GetOverridesNodePath([CanBeNull] string apiname, [NotNull] string enumeration)
        {
            if (enumeration == null)
            {
                throw new ArgumentNullException(nameof(enumeration));
            }

            var path = new StringBuilder();
            path.Append("/signatures/replace");
            if (apiname != null)
            {
                path.Append($"[contains(concat('|', @name, '|'), '|{apiname}|')]");
            }

            path.Append($"/enum[contains(concat('|', @name, '|'), '|{enumeration}|')]");

            return path.ToString();
        }

        [NotNull]
        private EnumCollection ProcessNames([NotNull] EnumCollection enums, [NotNull] XPathNavigator nav, [NotNull] string apiname)
        {
            var processedEnums = new EnumCollection();
            foreach (var e in enums.Values)
            {
                // Note that we cannot modify a collection while iterating over it,
                // so we keep a list of modified enums and remove/readd the
                // modified items to refresh their keys.
                var name = e.Name;
                name = ReplaceName(nav, apiname, name);

                if (!Utilities.IsIdentifierTranslated(name))
                {
                    name = NativeIdentifierTranslator.TranslateIdentifierName(name);
                }

                e.Name = name;
                processedEnums.Add(e.Name, e);
            }

            return processedEnums;
        }

        [NotNull]
        private static string ReplaceName([NotNull] XPathNavigator nav, [NotNull] string apiname, [NotNull] string name)
        {
            var enumOverride = nav.SelectSingleNode(GetOverridesNodePath(apiname, name));
            var nameOverride = enumOverride?.SelectSingleNode("name");

            if (nameOverride != null)
            {
                name = nameOverride.Value;
            }

            return name;
        }

        [NotNull]
        private EnumCollection ProcessConstants([NotNull] EnumCollection enums, [NotNull] XPathNavigator nav, [NotNull] string apiname)
        {
            foreach (var e in enums.Values)
            {
                var processedConstants = new SortedDictionary<string, ConstantDefinition>();
                foreach (var c in e.ConstantCollection.Values)
                {
                    c.Name = NativeIdentifierTranslator.TranslateIdentifierName(c.Name);
                    c.Value = TranslateConstantValue(c.Value);

                    if (!string.IsNullOrWhiteSpace(c.Reference))
                    {
                        if (!Utilities.IsIdentifierTranslated(c.Reference))
                        {
                            c.Reference = NativeIdentifierTranslator.TranslateIdentifierName(c.Reference);
                        }
                    }

                    if (!processedConstants.ContainsKey(c.Name))
                    {
                        processedConstants.Add(c.Name, c);
                    }
                }

                e.ConstantCollection = processedConstants;

                var enumOverride = nav.SelectSingleNode(GetOverridesNodePath(apiname, e.Name));
                if (!(enumOverride is null))
                {
                    foreach (var c in e.ConstantCollection.Values)
                    {
                        ReplaceConstant(enumOverride, c);
                    }
                }

                foreach (var c in e.ConstantCollection.Values)
                {
                    ResolveBareAlias(c, enums);
                }
            }

            foreach (var e in enums.Values)
            {
                ResolveAliases(e, enums);
            }

            return enums;
        }

        private static void ReplaceConstant([NotNull] XPathNavigator enumOverride, [NotNull] ConstantDefinition c)
        {
            var constantOverride = enumOverride.SelectSingleNode($"token[@name='{c.OriginalName}']") ??
                                   enumOverride.SelectSingleNode($"token[@name={c.Name}]");

            if (constantOverride == null)
            {
                return;
            }

            foreach (XPathNavigator node in constantOverride.SelectChildren(XPathNodeType.Element))
            {
                switch (node.Name)
                {
                    case "name":
                        c.Name = (string)node.TypedValue;
                        break;
                    case "value":
                        c.Value = (string)node.TypedValue;
                        break;
                    case "reference":
                        c.Reference = (string)node.TypedValue;
                        break;
                }
            }
        }

        [NotNull]
        private string TranslateConstantValue([NotNull] string value)
        {
            // Remove decorations to get a pure number (e.g. 0x80u -> 0x80).
            if (value.ToLower().StartsWith("0x"))
            {
                // Trim the unsigned or long specifiers used in C constants ('u' or 'ull').
                if (value.ToLower().EndsWith("ull"))
                {
                    value = value.Substring(0, value.Length - 3);
                }

                if (value.ToLower().EndsWith("u"))
                {
                    value = value.Substring(0, value.Length - 1);
                }
            }

            // Strip the prefix, if any.
            if (value.StartsWith(Generator.ConstantPrefix))
            {
                value = value.Substring(Generator.ConstantPrefix.Length);
            }

            if (IsValue(value))
            {
                return value;
            }

            if (!Utilities.IsIdentifierTranslated(value))
            {
                return NativeIdentifierTranslator.TranslateIdentifierName(value);
            }

            return value;
        }

        // There are cases when a value is an aliased constant, with no enum specified.
        // (e.g. FOG_COORD_ARRAY_TYPE = GL_FOG_COORDINATE_ARRAY_TYPE)
        // In this case try searching all enums for the correct constant to alias (stupid opengl specs).
        // This turns every bare alias into a normal alias that is processed afterwards.
        private static void ResolveBareAlias([NotNull] ConstantDefinition c, [NotNull] EnumCollection enums)
        {
            // Constants are considered bare aliases when they don't have a reference and
            // their values are non-numeric.
            if (!string.IsNullOrEmpty(c.Reference) || char.IsDigit(c.Value[0]))
            {
                return;
            }

            // Skip generic GLenum, as this doesn't help resolve references.
            foreach (var e in enums.Values.Where(e => e.Name != "GLenum"))
            {
                if (!e.ConstantCollection.ContainsKey(c.Value))
                {
                    continue;
                }

                c.Reference = e.Name;
                break;
            }
        }

        // Resolve 'use' tokens by searching and replacing the correct
        // value from the enum collection.
        // Tokens that can't be resolved are removed.
        private static void ResolveAliases([NotNull] EnumDefinition e, [NotNull] EnumCollection enums)
        {
            // Note that we have the removal must be a separate step, since
            // we cannot modify a collection while iterating with foreach.
            var brokenReferences = e.ConstantCollection.Values
                .Where(c => !ConstantDefinition.TranslateConstantWithReference(c, enums))
                .Select(c => c).ToList();
            foreach (var c in brokenReferences)
            {
                Console.WriteLine("[Warning] Reference {0} not found for token {1}.", c.Reference, c);
                e.ConstantCollection.Remove(c.Name);
            }
        }

        private static bool IsValue([NotNull] string test)
        {
            // Check if the result is a number.
            bool isNumber;
            if (test.ToLower().StartsWith("0x"))
            {
                isNumber = true;
            }
            else
            {
                isNumber = long.TryParse(
                    test,
                    NumberStyles.Number,
                    CultureInfo.InvariantCulture,
                    out _);
            }

            return isNumber;
        }
    }
}
