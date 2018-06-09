/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */

using System;
using System.Runtime.InteropServices;

namespace Bind.Structures
{
    /// <summary>
    /// Represents a single parameter of an opengl function.
    /// </summary>
    internal class ParameterDefinition : TypeDefinition, IComparable<ParameterDefinition>, IEquatable<ParameterDefinition>
    {
        private string _cache;

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterDefinition"/> class.
        /// </summary>
        public ParameterDefinition()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterDefinition"/> class.
        /// Creates a new parameter from the parameter passed (deep copy).
        /// </summary>
        /// <param name="p">The parameter to copy from.</param>
        public ParameterDefinition(ParameterDefinition p)
            : base(p)
        {
            if (p == null)
            {
                return;
            }

            Name = p.Name;
            UnmanagedType = p.UnmanagedType;
            Generic = p.Generic;
            Flow = p.Flow;
            _cache = p._cache;
            ComputeSize = p.ComputeSize;
            //this.rebuild = false;
        }

        /// <summary>
        /// Gets the raw name of the parameter.
        /// </summary>
        public string RawName
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets or sets the name of the parameter.
        /// </summary>
        public string Name
        {
            get => RawName;
            set
            {
                if (RawName != value)
                {
                    while (value.StartsWith("*"))
                    {
                        IndirectionLevel++;
                        value = value.Substring(1);
                    }
                    RawName = value;
                }
            }
        }

        private UnmanagedType _unmanagedType;

        /// <summary>
        /// Gets or sets the name of the parameter.
        /// </summary>
        private UnmanagedType UnmanagedType
        {
            get => _unmanagedType;
            set
            {
                if (_unmanagedType != value)
                {
                    _unmanagedType = value;
                }
            }
        }

        private FlowDirection _flow;

        /// <summary>
        /// Gets or sets the flow of the parameter.
        /// </summary>
        public FlowDirection Flow
        {
            get => _flow;
            set
            {
                if (_flow != value)
                {
                    _flow = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the parameter is a generic parameter.
        /// </summary>
        public bool Generic { get; set; }

        /// <summary>
        /// Gets or sets the parameter size computation hint information.
        /// </summary>
        public string ComputeSize { get; set; }

        /// <summary>
        /// Returns the FlowDirection that matches the specified string
        /// ("out" or "in", otherwise undefined).
        /// </summary>
        /// <param name="direction">The raw direction to parse.</param>
        /// <returns>A flow direction, based on the input.</returns>
        public static FlowDirection GetFlowDirection(string direction)
        {
            return direction == "out" ? FlowDirection.Out : direction == "in" ? FlowDirection.In : FlowDirection.Undefined;
        }


        /// <inheritdoc/>
        public int CompareTo(ParameterDefinition other)
        {
            var result = base.CompareTo(other);
            if (result == 0)
            {
                result = Name.CompareTo(other.Name);
            }
            return result;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var modifier = IsReference ? Flow == FlowDirection.Out ? "out " : "ref " : string.Empty;

            return $"{modifier}{base.ToString()} {Name}";
        }

        /// <inheritdoc/>
        public bool Equals(ParameterDefinition other)
        {
            var result =
                base.Equals(other) &&
                Name.Equals(other.Name);

            return result;
        }
    }
}
