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
    public class Constant : IComparable<Constant>
    {
        static StringBuilder translator = new StringBuilder();
        static readonly int MaxReferenceDepth = 8;
        static int CurrentReferenceDepth = 0;

        #region PreviousName

        string original_name;

        // Gets the name prior to translation.
        public string OriginalName
        {
            get { return original_name; }
            private set { original_name = value; }
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
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("value");

                if (OriginalName == null)
                    OriginalName = _name;

                _name = value;
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
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("value");

                _value = value;
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
                _reference = value;
            }
        }

        #endregion

        #region public bool Unchecked

        public bool Unchecked
        {
            get
            {
                // Check if the value is a number larger than Int32.MaxValue.
                ulong number;
                string test = Value;
                return UInt64.TryParse(test.ToLower().Replace("0x", String.Empty),
                    NumberStyles.AllowHexSpecifier, null, out number) &&
                    number > Int32.MaxValue; 
            }
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

        /// <summary>
        /// Replces the Value of the given constant with the value referenced by the [c.Reference, c.Value] pair.
        /// </summary>
        /// <param name="c">The Constant to translate</param>
        /// <param name="enums">The list of enums to check.</param>
        /// <param name="auxEnums">The list of auxilliary enums to check.</param>
        /// <returns>True if the reference was found; false otherwise.</returns>
        public static bool TranslateConstantWithReference(Constant c, EnumCollection enums)
        {
            if (c == null)
                throw new ArgumentNullException("c");
            if (enums == null)
                throw new ArgumentNullException("enums");

            if (++CurrentReferenceDepth >= MaxReferenceDepth)
                throw new InvalidOperationException(String.Format(
                    "Enum specification contains cycle: {0}",
                    c.ToString()));

            if (!String.IsNullOrEmpty(c.Reference))
            {
                Constant referenced_constant;

                if (enums.ContainsKey(c.Reference) && enums[c.Reference].ConstantCollection.ContainsKey(c.Value))
                {
                    // Transitively translate the referenced token
                    // Todo: this may cause loops if two tokens reference each other.
                    // Add a max reference depth and bail out?
                    TranslateConstantWithReference(enums[c.Reference].ConstantCollection[c.Value], enums);
                    referenced_constant = (enums[c.Reference].ConstantCollection[c.Value]);
                }
                else if (enums.ContainsKey(Settings.CompleteEnumName) &&
                    enums[Settings.CompleteEnumName].ConstantCollection.ContainsKey(c.Value))
                {
                    // Try the All enum
                    var reference = enums[Settings.CompleteEnumName].ConstantCollection[c.Value];
                    if (reference.Reference == null)
                        referenced_constant = (enums[Settings.CompleteEnumName].ConstantCollection[c.Value]);
                    else
                    {
                        --CurrentReferenceDepth;
                        return false;
                    }
                }
                else
                {
                    --CurrentReferenceDepth;
                    return false;
                }
                //else throw new InvalidOperationException(String.Format("Unknown Enum \"{0}\" referenced by Constant \"{1}\"",
                //                                                       c.Reference, c.ToString()));

                c.Value = referenced_constant.Value;
                c.Reference = null;
            }

            --CurrentReferenceDepth;
            return true;
        }

        #region public override string ToString()

        /// <summary>
        /// Returns a string that represents the full constant declaration without decorations
        /// (eg GL_XXX_YYY = (int)0xDEADBEEF or GL_XXX_YYY = GL_ZZZ.FOOBAR).
        /// </summary>
        /// <returns></returns>
        [Obsolete("This belongs to the language-specific ISpecWriter implementations.")]
        public override string ToString()
        {
            if (String.IsNullOrEmpty(Name))
                return "";
            return String.Format("{0} = {1}((int){2}{3})",
                Name, Unchecked ? "unchecked" : "",
                !String.IsNullOrEmpty(Reference) ? Reference + Settings.NamespaceSeparator : "", Value);

            //return String.Format("{0} = {1}((int){2})", Name, Unchecked ? "unchecked" : "", Value);
        }

        #endregion

        #region IComparable <Constant>Members

        public int CompareTo(Constant other)
        {
            int ret = Value.CompareTo(other.Value);
            if (ret == 0)
                return Name.CompareTo(other.Name);
            return ret;
        }

        #endregion
    }
}
