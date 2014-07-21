#region License
//
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
#endregion

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.XPath;
using Bind.Structures;
using Enum = Bind.Structures.Enum;

namespace Bind
{
    class EnumProcessor
    {
        string Overrides { get; set; }

        IBind Generator { get; set; }
        Settings Settings { get { return Generator.Settings; } }

        public EnumProcessor(IBind generator, string overrides)
        {
            if (generator == null)
                throw new ArgumentNullException("generator");
            if (overrides == null)
                throw new ArgumentNullException("overrides");

            Generator = generator;
            Overrides = overrides;
        }

        public EnumCollection Process(EnumCollection enums, string apiname)
        {
            var nav = new XPathDocument(Overrides).CreateNavigator();
            enums = ProcessNames(enums, nav, apiname);
            enums = ProcessConstants(enums, nav, apiname);
            return enums;
        }

        public static string GetOverridesPath(string apiname, string enumeration)
        {
            if (enumeration == null)
                throw new ArgumentNullException("enumeration");

            var path = new StringBuilder();
            path.Append("/signatures/replace");
            if (apiname != null)
            {
                path.Append(String.Format("[contains(concat('|', @name, '|'), '|{0}|')]", apiname));
            }

            path.Append(String.Format(
                "/enum[contains(concat('|', @name, '|'), '|{0}|')]",
                enumeration));

            return path.ToString();
        }

        #region Private Members

        EnumCollection ProcessNames(EnumCollection enums, XPathNavigator nav, string apiname)
        {
            EnumCollection processed_enums = new EnumCollection();
            foreach (var e in enums.Values)
            {
                // Note that we cannot modify a collection while iterating over it,
                // so we keep a list of modified enums and remove/readd the
                // modified items to refresh their keys.
                string name = e.Name;
                name = ReplaceName(nav, apiname, name);
                name = TranslateEnumName(name);
                e.Name = name;
                processed_enums.Add(e.Name, e);
            }

            // Mark enums differing only in case as not CLS-compliant.
            var list = enums.Values.ToList();
            while (list.Count > 0)
            {
                var e1 = list.Last();
                list.RemoveAt(list.Count - 1);

                var e2 = list.FirstOrDefault(l => String.Compare(e1.Name, l.Name, true) == 0);
                if (e2 != null)
                {
                    e1.CLSCompliant = false;
                    e2.CLSCompliant = false;
                }
            }
            foreach (var e in enums.Values)
            {
            }

            return processed_enums;
        }

        static string ReplaceName(XPathNavigator nav, string apiname, string name)
        {
            var enum_override = nav.SelectSingleNode(GetOverridesPath(apiname, name));
            if (enum_override != null)
            {
                var name_override = enum_override.SelectSingleNode("name");
                if (name_override != null)
                {
                    name = name_override.Value;
                }
            }
            return name;
        }

        public string TranslateEnumName(string name)
        {
            if (String.IsNullOrEmpty(name))
                return name;

            if (Utilities.Keywords(Settings.Language).Contains(name))
                return name;

            if (Char.IsDigit(name[0]))
                name = Settings.ConstantPrefix + name;

            StringBuilder translator = new StringBuilder(name);

            // Split on IHV names and acronyms, to ensure that characters appearing after these name are uppercase.
            var match = Utilities.Acronyms.Match(name);
            int offset = 0; // Everytime we insert a match, we must increase offset to compensate.
            while (match.Success)
            {
                int insert_pos = match.Index + match.Length + offset++;
                translator.Insert(insert_pos, "_");
                match = match.NextMatch();
            }
            name = translator.ToString();
            translator.Remove(0, translator.Length);

            // Process according to these rules:
            //     1. if current char is '_', '-' remove it and make next char uppercase
            //     2. if current char is  or '0-9' keep it and make next char uppercase.
            //     3. if current char is uppercase make next char lowercase.
            //     4. if current char is lowercase, respect next char case.
            bool is_after_underscore_or_number = true;
            bool is_previous_uppercase = false;
            foreach (char c in name)
            {
                char char_to_add;
                if (c == '_' || c == '-')
                {
                    is_after_underscore_or_number = true;
                    continue; // skip this character
                }
                else if (Char.IsDigit(c))
                {
                    is_after_underscore_or_number = true;
                }

                if (is_after_underscore_or_number)
                    char_to_add = Char.ToUpper(c);
                else if (is_previous_uppercase)
                    char_to_add = Char.ToLower(c);
                else
                    char_to_add = c;

                translator.Append(char_to_add);

                is_previous_uppercase = Char.IsUpper(c);
                is_after_underscore_or_number = false;
            }

            // First letter should always be uppercase in order 
            // to conform to .Net style guidelines.
            translator[0] = Char.ToUpper(translator[0]);

            // Replace a number of words that do not play well
            // with the previous process (i.e. they have two
            // consecutive uppercase letters).
            translator.Replace("Pname", "PName");
            translator.Replace("AttribIp", "AttribIP");
            translator.Replace("SRgb", "Srgb");

            name = translator.ToString();
            if (name.StartsWith(Settings.EnumPrefix))
                name = name.Substring(Settings.EnumPrefix.Length);

            return name;
        }

        EnumCollection ProcessConstants(EnumCollection enums, XPathNavigator nav, string apiname)
        {
            foreach (var e in enums.Values)
            {
                var processed_constants = new SortedDictionary<string, Constant>();
                foreach (Constant c in e.ConstantCollection.Values)
                {
                    c.Name = TranslateConstantName(c.Name, false);
                    c.Value = TranslateConstantValue(c.Value);
                    c.Reference = TranslateEnumName(c.Reference);
                    if (!processed_constants.ContainsKey(c.Name))
                    {
                        processed_constants.Add(c.Name, c);
                    }
                }
                e.ConstantCollection = processed_constants;

                var enum_override = nav.SelectSingleNode(GetOverridesPath(apiname, e.Name));
                foreach (Constant c in e.ConstantCollection.Values)
                {
                    ReplaceConstant(enum_override, c);
                    ResolveBareAlias(c, enums);
                }
            }

            foreach (var e in enums.Values)
            {
                ResolveAliases(e, enums);
            }

            return enums;
        }

        static void ReplaceConstant(XPathNavigator enum_override, Constant c)
        {
            if (enum_override != null)
            {
                XPathNavigator constant_override = enum_override.SelectSingleNode(String.Format("token[@name='{0}']", c.OriginalName)) ??
                    enum_override.SelectSingleNode(String.Format("token[@name={0}]", c.Name));
                if (constant_override != null)
                {
                    foreach (XPathNavigator node in constant_override.SelectChildren(XPathNodeType.Element))
                    {
                        switch (node.Name)
                        {
                            case "name": c.Name = (string)node.TypedValue; break;
                            case "value": c.Value = (string)node.TypedValue; break;
                            case "reference": c.Reference = (string)node.TypedValue; break;
                        }
                    }
                }
            }
        }

        public string TranslateConstantName(string s, bool isValue)
        {
            if (String.IsNullOrEmpty(s))
                return s;

            StringBuilder translator = new StringBuilder(s.Length);

            if (isValue)
            {
                translator.Append(s);
            }
            else
            {
                // Translate the constant's name to match .Net naming conventions
                bool name_is_all_caps = s.AsEnumerable().All(c => Char.IsLetter(c) ? Char.IsUpper(c) : true);
                bool name_contains_underscore = s.Contains("_");
                if ((Settings.Compatibility & Settings.Legacy.NoAdvancedEnumProcessing) == Settings.Legacy.None &&
                (name_is_all_caps || name_contains_underscore))
                {
                    bool next_char_uppercase = true;
                    bool is_after_digit = false;

                    if (!isValue && Char.IsDigit(s[0]))
                        s = Settings.ConstantPrefix + s;

                    foreach (char c in s)
                    {
                        if (c == '_' || c == '-')
                        {
                            next_char_uppercase = true;
                            continue; // do not add these chars to output
                        }
                        else if (Char.IsDigit(c))
                        {
                            translator.Append(c);
                            is_after_digit = true;
                        }
                        else
                        {
                            // Check for common 'digit'-'letter' abbreviations:
                            // 2D, 3D, R3G3B2, etc. The abbreviated characters
                            // should be made upper case.
                            if (is_after_digit && (c == 'D' || c == 'R' || c == 'G' || c == 'B' || c == 'A'))
                            {
                                next_char_uppercase = true;
                            }
                            translator.Append(next_char_uppercase ? Char.ToUpper(c) : Char.ToLower(c));
                            is_after_digit = next_char_uppercase = false;
                        }
                    }

                    translator[0] = Char.ToUpper(translator[0]);
                }
                else
                    translator.Append(s);
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
                    value = value.Substring(0, value.Length - 3);
                if (value.ToLower().EndsWith("u"))
                    value = value.Substring(0, value.Length - 1);
            }

            // Strip the prefix, if any.
            if (value.StartsWith(Settings.ConstantPrefix))
                value = value.Substring(Settings.ConstantPrefix.Length);

            return TranslateConstantName(value, IsValue(value));
        }

        // There are cases when a value is an aliased constant, with no enum specified.
        // (e.g. FOG_COORD_ARRAY_TYPE = GL_FOG_COORDINATE_ARRAY_TYPE)
        // In this case try searching all enums for the correct constant to alias (stupid opengl specs).
        // This turns every bare alias into a normal alias that is processed afterwards.
        static void ResolveBareAlias(Constant c, EnumCollection enums)
        {
            // Constants are considered bare aliases when they don't have a reference and
            // their values are non-numeric.
            if (String.IsNullOrEmpty(c.Reference) && !Char.IsDigit(c.Value[0]))
            {
                // Skip generic GLenum, as this doesn't help resolve references.
                foreach (Enum e in enums.Values.Where(e => e.Name != "GLenum"))
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
        static void ResolveAliases(Enum e, EnumCollection enums)
        {
            // Note that we have the removal must be a separate step, since
            // we cannot modify a collection while iterating with foreach.
            var broken_references = e.ConstantCollection.Values
                .Where(c => !Constant.TranslateConstantWithReference(c, enums))
                .Select(c => c).ToList();
            foreach (var c in broken_references)
            {
                Console.WriteLine("[Warning] Reference {0} not found for token {1}.", c.Reference, c);
                e.ConstantCollection.Remove(c.Name);
            }
        }

        static bool IsValue(string test)
        {
            // Check if the result is a number.
            long number;
            bool is_number = false;
            if (test.ToLower().StartsWith("0x"))
            {
                is_number = true;
            }
            else
            {
                is_number = Int64.TryParse(
                    test,
                    NumberStyles.Number,
                    System.Globalization.CultureInfo.InvariantCulture,
                    out number);
            }
            return is_number;
        }

        #endregion
    }
}
