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
using Bind.Structures;
using Enum = Bind.Structures.Enum;

namespace Bind
{
    internal class EnumProcessor
    {
        private readonly IEnumerable<string> _overrides;

        public EnumProcessor(IGenerator generator, IEnumerable<string> overrides)
        {
            Generator = generator ?? throw new ArgumentNullException(nameof(generator));
            _overrides = overrides ?? throw new ArgumentNullException(nameof(overrides));
        }

        private IGenerator Generator { get; }

        public EnumCollection Process(EnumCollection enums, string apiname)
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

        public static string GetOverridesPath(string apiname, string enumeration)
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

        private EnumCollection ProcessNames(EnumCollection enums, XPathNavigator nav, string apiname)
        {
            var processedEnums = new EnumCollection();
            foreach (var e in enums.Values)
            {
                // Note that we cannot modify a collection while iterating over it,
                // so we keep a list of modified enums and remove/readd the
                // modified items to refresh their keys.
                var name = e.Name;
                name = ReplaceName(nav, apiname, name);
                name = TranslateEnumName(name);
                e.Name = name;
                processedEnums.Add(e.Name, e);
            }

            // Mark enums differing only in case as not CLS-compliant.
            var list = enums.Values.ToList();
            while (list.Count > 0)
            {
                var e1 = list.Last();
                list.RemoveAt(list.Count - 1);

                var e2 = list.FirstOrDefault(l => string.Compare(e1.Name, l.Name, true) == 0);
                if (e2 != null)
                {
                    e1.CLSCompliant = false;
                    e2.CLSCompliant = false;
                }
            }

            foreach (var e in enums.Values)
            {
            }

            return processedEnums;
        }

        private static string ReplaceName(XPathNavigator nav, string apiname, string name)
        {
            var enumOverride = nav.SelectSingleNode(GetOverridesPath(apiname, name));
            if (enumOverride != null)
            {
                var nameOverride = enumOverride.SelectSingleNode("name");
                if (nameOverride != null)
                {
                    name = nameOverride.Value;
                }
            }

            return name;
        }

        private static bool IsAlreadyProcessed(string name)
        {
            var extension = Utilities.GetExtension(name, true);
            var unprocessed = false;
            unprocessed |= name.Contains("_") || name.Contains("-");
            unprocessed |= char.IsDigit(name[0]);
            unprocessed |= name.All(c => char.IsUpper(c));
            unprocessed |= !string.IsNullOrEmpty(extension) && extension.All(c => char.IsUpper(c));
            return !unprocessed;
        }

        public string TranslateEnumName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return name;
            }

            if (Utilities.CSharpKeywords.Contains(name))
            {
                return name;
            }

            if (!IsAlreadyProcessed(name))
            {
                if (char.IsDigit(name[0]))
                {
                    name = $"{Generator.ConstantPrefix}{name}";
                }

                var translator = new StringBuilder(name);

                // Split on IHV names and acronyms, to ensure that characters appearing after these name are uppercase.
                var match = Utilities.Acronyms.Match(name);
                var offset = 0; // Everytime we insert a match, we must increase offset to compensate.
                while (match.Success)
                {
                    var insertPos = match.Index + match.Length + offset++;
                    translator.Insert(insertPos, "_");
                    match = match.NextMatch();
                }

                name = translator.ToString();
                translator.Remove(0, translator.Length);

                // Process according to these rules:
                //     1. if current char is '_', '-' remove it and make next char uppercase
                //     2. if current char is  or '0-9' keep it and make next char uppercase.
                //     3. if current char is uppercase make next char lowercase.
                //     4. if current char is lowercase, respect next char case.
                var isAfterUnderscoreOrNumber = true;
                var isPreviousUppercase = false;
                foreach (var c in name)
                {
                    char charToAdd;
                    if (c == '_' || c == '-')
                    {
                        isAfterUnderscoreOrNumber = true;
                        continue; // skip this character
                    }

                    if (char.IsDigit(c))
                    {
                        isAfterUnderscoreOrNumber = true;
                    }

                    if (isAfterUnderscoreOrNumber)
                    {
                        charToAdd = char.ToUpper(c);
                    }
                    else if (isPreviousUppercase)
                    {
                        charToAdd = char.ToLower(c);
                    }
                    else
                    {
                        charToAdd = c;
                    }

                    translator.Append(charToAdd);

                    isPreviousUppercase = char.IsUpper(c);
                    isAfterUnderscoreOrNumber = false;
                }

                // First letter should always be uppercase in order
                // to conform to .Net style guidelines.
                translator[0] = char.ToUpper(translator[0]);

                // Replace a number of words that do not play well
                // with the previous process (i.e. they have two
                // consecutive uppercase letters).
                translator.Replace("Pname", "PName");
                translator.Replace("AttribIp", "AttribIP");
                translator.Replace("SRgb", "Srgb");

                name = translator.ToString();
            }

            return name;
        }

        private EnumCollection ProcessConstants(EnumCollection enums, XPathNavigator nav, string apiname)
        {
            foreach (var e in enums.Values)
            {
                var processedConstants = new SortedDictionary<string, Constant>();
                foreach (var c in e.ConstantCollection.Values)
                {
                    c.Name = TranslateConstantName(c.Name, false);
                    c.Value = TranslateConstantValue(c.Value);
                    c.Reference = TranslateEnumName(c.Reference);
                    if (!processedConstants.ContainsKey(c.Name))
                    {
                        processedConstants.Add(c.Name, c);
                    }
                }

                e.ConstantCollection = processedConstants;

                var enumOverride = nav.SelectSingleNode(GetOverridesPath(apiname, e.Name));
                foreach (var c in e.ConstantCollection.Values)
                {
                    ReplaceConstant(enumOverride, c);
                    ResolveBareAlias(c, enums);
                }
            }

            foreach (var e in enums.Values)
            {
                ResolveAliases(e, enums);
            }

            return enums;
        }

        private static void ReplaceConstant(XPathNavigator enumOverride, Constant c)
        {
            if (enumOverride != null)
            {
                var constantOverride = enumOverride.SelectSingleNode($"token[@name='{c.OriginalName}']") ??
                                       enumOverride.SelectSingleNode($"token[@name={c.Name}]");
                if (constantOverride != null)
                {
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
            }
        }

        public string TranslateConstantName(string s, bool isValue)
        {
            if (string.IsNullOrEmpty(s))
            {
                return s;
            }

            var translator = new StringBuilder(s.Length);

            if (isValue)
            {
                translator.Append(s);
            }
            else
            {
                // Translate the constant's name to match .Net naming conventions
                var nameIsAllCaps = s.AsEnumerable().All(c => !char.IsLetter(c) || char.IsUpper(c));
                var nameContainsUnderscore = s.Contains("_");
                if (nameIsAllCaps || nameContainsUnderscore)
                {
                    var nextCharUppercase = true;
                    var isAfterDigit = false;

                    if (!isValue && char.IsDigit(s[0]))
                    {
                        s = Generator.ConstantPrefix + s;
                    }

                    foreach (var c in s)
                    {
                        if (c == '_' || c == '-')
                        {
                            nextCharUppercase = true;
                        }
                        else if (char.IsDigit(c))
                        {
                            translator.Append(c);
                            isAfterDigit = true;
                        }
                        else
                        {
                            // Check for common 'digit'-'letter' abbreviations:
                            // 2D, 3D, R3G3B2, etc. The abbreviated characters
                            // should be made upper case.
                            if (isAfterDigit && (c == 'D' || c == 'R' || c == 'G' || c == 'B' || c == 'A'))
                            {
                                nextCharUppercase = true;
                            }

                            translator.Append(nextCharUppercase ? char.ToUpper(c) : char.ToLower(c));
                            isAfterDigit = nextCharUppercase = false;
                        }
                    }

                    translator[0] = char.ToUpper(translator[0]);
                }
                else
                {
                    translator.Append(s);
                }
            }

            return translator.ToString();
        }

        public string TranslateConstantValue(string value)
        {
            // Remove decorations to get a pure number (e.g. 0x80u -> 80).
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

            return TranslateConstantName(value, IsValue(value));
        }

        // There are cases when a value is an aliased constant, with no enum specified.
        // (e.g. FOG_COORD_ARRAY_TYPE = GL_FOG_COORDINATE_ARRAY_TYPE)
        // In this case try searching all enums for the correct constant to alias (stupid opengl specs).
        // This turns every bare alias into a normal alias that is processed afterwards.
        private static void ResolveBareAlias(Constant c, EnumCollection enums)
        {
            // Constants are considered bare aliases when they don't have a reference and
            // their values are non-numeric.
            if (string.IsNullOrEmpty(c.Reference) && !char.IsDigit(c.Value[0]))
            {
                // Skip generic GLenum, as this doesn't help resolve references.
                foreach (var e in enums.Values.Where(e => e.Name != "GLenum"))
                {
                    if (e.ConstantCollection.ContainsKey(c.Value))
                    {
                        c.Reference = e.Name;
                        break;
                    }
                }
            }
        }

        // Resolve 'use' tokens by searching and replacing the correct
        // value from the enum collection.
        // Tokens that can't be resolved are removed.
        private static void ResolveAliases(Enum e, EnumCollection enums)
        {
            // Note that we have the removal must be a separate step, since
            // we cannot modify a collection while iterating with foreach.
            var brokenReferences = e.ConstantCollection.Values
                .Where(c => !Constant.TranslateConstantWithReference(c, enums))
                .Select(c => c).ToList();
            foreach (var c in brokenReferences)
            {
                Console.WriteLine("[Warning] Reference {0} not found for token {1}.", c.Reference, c);
                e.ConstantCollection.Remove(c.Name);
            }
        }

        private static bool IsValue(string test)
        {
            // Check if the result is a number.
            long number;
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
                    out number);
            }

            return isNumber;
        }
    }
}
