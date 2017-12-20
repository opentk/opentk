/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */

using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace Bind.Structures
{
    /// <summary>
    /// Represents an opengl constant in C# format. Both the constant name and value
    /// can be retrieved or set. The value can be either a number, another constant
    /// or an alias to a constant
    /// </summary>
    internal class Constant : IComparable<Constant>
    {
        // Gets the name prior to translation.
        public string OriginalName { get; private set; }

        private string _name;

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
                {
                    throw new ArgumentNullException("value");
                }

                if (OriginalName == null)
                {
                    OriginalName = _name;
                }

                _name = value;
            }
        }

        private string _value;

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
                {
                    throw new ArgumentNullException("value");
                }

                _value = value;
            }
        }

        /// <summary>
        /// Gets or sets a string indicating the OpenGL enum reference by this constant.
        /// Can be null.
        /// </summary>
        public string Reference { get; set; }

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

        /// <summary>
        /// Replces the Value of the given constant with the value referenced by the [c.Reference, c.Value] pair.
        /// </summary>
        /// <param name="c">The Constant to translate</param>
        /// <param name="enums">The list of enums to check.</param>
        /// <returns>True if the reference was found; false otherwise.</returns>
        public static bool TranslateConstantWithReference(Constant c, EnumCollection enums)
        {
            if (c == null)
            {
                throw new ArgumentNullException("c");
            }
            if (enums == null)
            {
                throw new ArgumentNullException("enums");
            }

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

        public override string ToString()
        {
            return
                String.Format("{0} = {1}((int){2}{3})",
                Name,
                Unchecked ? "unchecked" : String.Empty,
                !String.IsNullOrEmpty(Reference) ? Reference + "." : String.Empty,
                Value);
        }

        public int CompareTo(Constant other)
        {
            int ret = Value.CompareTo(other.Value);
            if (ret == 0)
            {
                return Name.CompareTo(other.Name);
            }
            return ret;
        }
    }
}
