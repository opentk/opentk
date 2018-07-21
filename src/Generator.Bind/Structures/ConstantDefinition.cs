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
    /// or an alias to a constant.
    /// </summary>
    internal class ConstantDefinition : IComparable<ConstantDefinition>
    {
        /// <summary>
        /// Gets the name prior to translation into a C#-style name.
        /// </summary>
        public string OriginalName { get; private set; }

        private string _name;

        /// <summary>
        /// Gets or sets the name of the opengl constant (eg. GL_LINES).
        /// Undergoes processing unless the Settings.Legacy.NoAdvancedEnumProcessing flag is set.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value));
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
            get => _value;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value));
                }

                _value = value;
            }
        }

        /// <summary>
        /// Gets or sets a string indicating the OpenGL enum reference by this constant.
        /// Can be null.
        /// </summary>
        public string Reference { get; set; }

        /// <summary>
        /// Gets a value indicating whether the constant requires unchecked casting.
        /// </summary>
        public bool Unchecked
        {
            get
            {
                // Check if the value is a number larger than Int32.MaxValue.
                var test = Value;
                return ulong.TryParse
               (
                   test.ToLower().Replace("0x", string.Empty),
                   NumberStyles.AllowHexSpecifier,
                   null,
                   out var number
               )
               &&
               number > int.MaxValue;
            }
        }

        /// <summary>
        /// Replces the Value of the given constant with the value referenced by the [c.Reference, c.Value] pair.
        /// </summary>
        /// <param name="c">The Constant to translate.</param>
        /// <param name="enums">The list of enums to check.</param>
        /// <returns>True if the reference was found; false otherwise.</returns>
        public static bool TranslateConstantWithReference(ConstantDefinition c, EnumCollection enums)
        {
            if (c == null)
            {
                throw new ArgumentNullException(nameof(c));
            }
            if (enums == null)
            {
                throw new ArgumentNullException(nameof(enums));
            }

            if (!string.IsNullOrEmpty(c.Reference))
            {
                // Resolve the referenced Constant. Be careful
                // to avoid loops in the definitions.
                var reference = c;
                do
                {
                    reference =
                        enums.ContainsKey(reference.Reference) &&
                        enums[reference.Reference].ConstantCollection.ContainsKey(reference.Value) ?
                        enums[reference.Reference].ConstantCollection[reference.Value] : null;
                }
                while (reference?.Reference != null && reference.Reference != c.Reference);

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

                Trace.WriteLine($"[Warning] Failed to resolve token: {c}");
                return false;
            }
            return true;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return
                $"{Name} = {(Unchecked ? "unchecked" : string.Empty)}((int){(!string.IsNullOrEmpty(Reference) ? Reference + "." : string.Empty)}{Value})";
        }

        /// <inheritdoc/>
        public int CompareTo(ConstantDefinition other)
        {
            var ret = string.Compare(Value, other.Value, StringComparison.Ordinal);
            if (ret == 0)
            {
                return string.Compare(Name, other.Name, StringComparison.Ordinal);
            }
            return ret;
        }
    }
}
