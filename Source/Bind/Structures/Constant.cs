#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Bind.Structures
{
    /// <summary>
    /// Represents an opengl constant in C# format. Both the constant name and value
    /// can be retrieved or set. The value can be either a number, another constant
    /// or an alias to a constant 
    /// </summary>
    public class Constant
    {
        static StringBuilder translator = new StringBuilder();

        #region PreviousName

        string previous_name;

        // Gets the name prior to translation.
        public string PreviousName
        {
            get { return previous_name; }
            private set { previous_name = value; }
        }

        #endregion

        #region public string Name

        string _name;

        /// <summary>
        /// Gets or sets the name of the opengl constant (eg. GL_LINES).
        /// Undergoes processing unless the Settings.Legacy.NoAdvancedEnumProcessing flag is set.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set 
            {
                if (!String.IsNullOrEmpty(value))
                    _name = Translate(value.Trim(), false);
                else _name = value;
                
                PreviousName = value;
            }
        }

        #endregion

        #region public string Value

        string _value;

        /// <summary>
        /// Gets or sets the value of the opengl constant (eg. 0x00000001).
        /// </summary>
        public string Value
        {
            get 
            {
                return _value;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    value = value.Trim();

                    if (value.ToLower() == " 0xffffffffffffffff") Debugger.Break();
                    // Check whether this value is a number and make sure the Unchecked property is set correctly.
                    ulong number;
                    if (value.ToLower().StartsWith("0x"))
                    {
                        // Trim the unsigned or long specifiers used in C constants ('u' or 'ull').
                        if (value.ToLower().EndsWith("ull"))
                            value = value.Substring(0, value.Length - 3);
                        if (value.ToLower().EndsWith("u"))
                            value = value.Substring(0, value.Length - 1);
                    }
                    if (UInt64.TryParse(value.ToLower().Replace("0x", String.Empty), NumberStyles.AllowHexSpecifier, null, out number))
                    {
                        // The value is a number, check if it should be unchecked.
                        if (number > 0x7FFFFFFF)
                            Unchecked = true;
                    }
                    else
                    {
                        // The value is not a number. Strip the prefix.
                        if (value.StartsWith(Settings.ConstantPrefix))
                            value = value.Substring(Settings.ConstantPrefix.Length);

                        // If the name now starts with a digit (doesn't matter whether we
                        // stripped "GL_" above), add a "GL_" prefix.
                        // (e.g. GL_4_BYTES).
                        if (Char.IsDigit(value[0]))
                            value = Settings.ConstantPrefix + value;
                    }
                }

                _value = Translate(value, true);
            }
        }

        #endregion

        #region public string Reference

        string _reference;

        /// <summary>
        /// Gets or sets a string indicating the OpenGL enum reference by this constant.
        /// Can be null.
        /// </summary>
        public string Reference
        {
            get { return _reference; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    _reference = Enum.TranslateName(value.Trim());
                else _reference = value;
            }
        }

        #endregion

        #region public bool Unchecked

        private bool @unchecked;

        public bool Unchecked
        {
            get { return @unchecked; }
            set { @unchecked = value; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Creates an empty Constant.
        /// </summary>
        public Constant()
        {
        }

        /// <summary>
        /// Creates a Constant with the given name and value.
        /// </summary>
        /// <param name="name">The Name of the Constant.</param>
        /// <param name="value">The Type of the Constant.</param>
        public Constant(string name, string value)
        {
            Name = name;
            Value = value;
        }

        #endregion

        #region Translate

        public static string Translate(string s, bool isValue)
        {
            translator.Remove(0, translator.Length);

            // Translate the constant's name to match .Net naming conventions
            bool name_is_all_caps = s.AsEnumerable().All(c => Char.IsLetter(c) ? Char.IsUpper(c) : true);
            bool name_contains_underscore = s.Contains("_");
            if ((Settings.Compatibility & Settings.Legacy.NoAdvancedEnumProcessing) == Settings.Legacy.None &&
                (name_is_all_caps || name_contains_underscore))
            {
                bool next_char_uppercase = true;
                bool is_after_digit = false;

                if (!isValue && Char.IsDigit(s[0]))
                    translator.Insert(0, Settings.ConstantPrefix);

                foreach (char c in s)
                {
                    if (c == '_')
                        next_char_uppercase = true;
                    else if (Char.IsDigit(c))
                    {
                        is_after_digit = true;
                        translator.Append(c);
                    }
                    else
                    {
                        translator.Append(next_char_uppercase || (is_after_digit && c == 'd') ? Char.ToUpper(c) : Char.ToLower(c));
                        is_after_digit = next_char_uppercase = false;
                    }
                }

                translator[0] = Char.ToUpper(translator[0]);
            }
            else
                translator.Append(s);

            return translator.ToString();
        }

        #endregion

        /// <summary>
        /// Replces the Value of the given constant with the value referenced by the [c.Reference, c.Value] pair.
        /// </summary>
        /// <param name="c">The Constant to translate</param>
        /// <param name="enums">The list of enums to check.</param>
        /// <param name="auxEnums">The list of auxilliary enums to check.</param>
        /// <returns>True if the reference was found; false otherwise.</returns>
        public static bool TranslateConstantWithReference(Constant c, EnumCollection enums, EnumCollection auxEnums)
        {
            if (!String.IsNullOrEmpty(c.Reference))
            {
                Constant referenced_constant;

                if (enums.ContainsKey(c.Reference) && enums[c.Reference].ConstantCollection.ContainsKey(c.Value))
                {
                    TranslateConstantWithReference(enums[c.Reference].ConstantCollection[c.Value] as Constant, enums, auxEnums);
                    referenced_constant = (enums[c.Reference].ConstantCollection[c.Value] as Constant);
                }
                else if (auxEnums.ContainsKey(c.Reference) && auxEnums[c.Reference].ConstantCollection.ContainsKey(c.Value))
                {
                    TranslateConstantWithReference(auxEnums[c.Reference].ConstantCollection[c.Value] as Constant, enums, auxEnums);
                    referenced_constant = (auxEnums[c.Reference].ConstantCollection[c.Value] as Constant);
                }
                else
                {
                    Console.WriteLine("[Warning] Reference {0} not found for token {1}.", c.Reference, c);
                    return false;
                }
                //else throw new InvalidOperationException(String.Format("Unknown Enum \"{0}\" referenced by Constant \"{1}\"",
                //                                                       c.Reference, c.ToString()));

                c.Value = referenced_constant.Value;
                c.Reference = null;
                c.Unchecked = referenced_constant.Unchecked;
            }

            return true;
        }

        #region public override string ToString()

        /// <summary>
        /// Returns a string that represents the full constant declaration without decorations
        /// (eg GL_XXX_YYY = (int)0xDEADBEEF or GL_XXX_YYY = GL_ZZZ.FOOBAR).
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (String.IsNullOrEmpty(Name))
                return "";
            return String.Format("{0} = {1}((int){2}{3})",
                Name, Unchecked ? "unchecked" : "",
                !String.IsNullOrEmpty(Reference) ? Reference + "." : "", Value);

            //return String.Format("{0} = {1}((int){2})", Name, Unchecked ? "unchecked" : "", Value);
        }

        #endregion
    }
}
