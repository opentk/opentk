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
        /// Creates a new Parameter without type and name.
        /// </summary>
        public ParameterDefinition()
        {
        }

        /// <summary>
        /// Creates a new parameter from the parameters passed (deep copy).
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
            Unchecked = p.Unchecked;
            UnmanagedType = p.UnmanagedType;
            Generic = p.Generic;
            Flow = p.Flow;
            _cache = p._cache;
            ComputeSize = p.ComputeSize;
            //this.rebuild = false;
        }

        /// <summary>
        /// Gets or sets the raw name of the parameter.
        /// </summary>
        public string RawName
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the name of the parameter. If the name matches a keyword of the current language,
        /// then it is escaped with <see cref="Settings.KeywordEscapeCharacter"/>.
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
                        Pointer++;
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

        private bool _unchecked;

        public bool Unchecked
        {
            get => _unchecked;
            set
            {
                if (_unchecked != value)
                {
                    _unchecked = value;
                }
            }
        }

        public bool Generic { get; set; }

        public string ComputeSize { get; set; }

        // Returns the FlowDirection that matches the specified string
        // ("out" or "in", otherwise undefined).
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
            return string.Format("{2}{0} {1}",
                base.ToString(),
                Name,
                Reference ?
                    Flow == FlowDirection.Out ? "out " : "ref " :
                    string.Empty);
        }

        public bool Equals(ParameterDefinition other)
        {
            var result =
                base.Equals(other) &&
                Name.Equals(other.Name);

            return result;
        }
    }
}
