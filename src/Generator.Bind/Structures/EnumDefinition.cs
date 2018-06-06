/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */

using System;
using System.Collections.Generic;

namespace Bind.Structures
{
    /// <summary>
    /// Represents an enumeration definition.
    /// </summary>
    internal class EnumDefinition
    {
        private string _name, _type;

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumDefinition"/> class.
        /// </summary>
        public EnumDefinition()
        {
            CLSCompliant = true;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the enum contains a collection of flags, i.e. 1, 2, 4, 8, ...
        /// </summary>
        public bool IsFlagCollection
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the name of the enum.
        /// </summary>
        public string Name
        {
            get => _name ?? string.Empty;
            set => _name = value;
        }

        /// <summary>
        /// Gets or sets the type of the enum. Typically 'int', but can be 'long'.
        /// </summary>
        public string Type
        {
            get => string.IsNullOrEmpty(_type) ? "int" : _type;
            set => _type = value;
        }

        private SortedDictionary<string, ConstantDefinition> _constantCollection = new SortedDictionary<string, ConstantDefinition>();

        /// <summary>
        /// Gets or sets the enumeration members, in the form of the member name and constant value.
        /// </summary>
        /// <exception cref="ArgumentNullException">Thrown if the value is null.</exception>
        public IDictionary<string, ConstantDefinition> ConstantCollection
        {
            get => _constantCollection;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                _constantCollection.Clear();
                foreach (var item in value)
                {
                    _constantCollection.Add(item.Key, item.Value);
                }
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"enum {Name} : {Type} {{ {ConstantCollection} }}";
        }

        /// <summary>
        /// Gets or sets the hinting text used if the enumeration is obsolete.
        /// </summary>
        public string Obsolete { get; set; }

        /// <summary>
        /// Gets a value indicating whether the enumeration is obsolete.
        /// </summary>
        public bool IsObsolete => !string.IsNullOrEmpty(Obsolete);

        /// <summary>
        /// Gets or sets a value indicating whether the enumeration is CLS-compliant.
        /// </summary>
        public bool CLSCompliant { get; set; }
    }
}
