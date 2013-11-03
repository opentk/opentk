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
    class Constant : IComparable<Constant>
    {
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

            if (!String.IsNullOrEmpty(c.Reference))
            {
                // Resolve the referenced Constant. Be careful
                // to avoid loops in the definitions.
                Constant reference = c;
                do
                {
                    reference =
                        enums.ContainsKey(reference.Reference) &&
                        enums[reference.Reference].ConstantCollection.ContainsKey(reference.Value) ?
                        enums[reference.Reference].ConstantCollection[reference.Value] : null;
                } while (reference != null && reference.Reference != null && reference.Reference != c.Reference);

                // If we haven't managed to locate the reference, do
                // a brute-force search through all enums.
                if (reference == null || reference.Reference != null)
                {
                    reference = enums.Values.Select(e =>
                        e.ConstantCollection.Values.FirstOrDefault(t =>
                            t.Reference == null && t.Name == c.Name))
                        .FirstOrDefault(t => t != null);
                }

                // Resolve the value for this Constant
                if (reference != null)
                {
                    c.Value = reference.Value;
                    c.Reference = null;
                    return true;
                }
                else
                {
                    Trace.WriteLine(String.Format("[Warning] Failed to resolve token: {0}", c));
                    return false;
                }
            }
            return true;
        }

        #region ToString

        public override string ToString()
        {
            return
                String.Format("{0} = {1}((int){2}{3})",
                Name,
                Unchecked ? "unchecked" : String.Empty,
                !String.IsNullOrEmpty(Reference) ? Reference + "." : String.Empty,
                Value);
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
