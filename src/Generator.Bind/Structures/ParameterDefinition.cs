/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using JetBrains.Annotations;

namespace Bind.Structures
{
    /// <summary>
    /// Represents a single parameter of an opengl function.
    /// </summary>
    internal class ParameterDefinition : IComparable<ParameterDefinition>, IEquatable<ParameterDefinition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterDefinition"/> class.
        /// </summary>
        public ParameterDefinition()
        {
            ParameterType = new TypeDefinition();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterDefinition"/> class.
        /// Creates a new parameter from the parameter passed (deep copy).
        /// </summary>
        /// <param name="p">The parameter to copy from.</param>
        public ParameterDefinition([NotNull] ParameterDefinition p)
        {
            Name = p.Name;
            UnmanagedType = p.UnmanagedType;
            Generic = p.Generic;
            Flow = p.Flow;
            ComputeSize = p.ComputeSize;

            ParameterType = new TypeDefinition(p.ParameterType);
        }

        /// <summary>
        /// Gets or sets the type of the parameter.
        /// </summary>
        public TypeDefinition ParameterType { get; set; }

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
                        ParameterType.IndirectionLevel++;
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
        public static FlowDirection GetFlowDirection([NotNull] string direction)
        {
            return direction == "out" ? FlowDirection.Out : direction == "in" ? FlowDirection.In : FlowDirection.Undefined;
        }

        /// <summary>
        /// Gets a string that would declare this object in C# source code.
        /// </summary>
        /// <returns>The declaration string.</returns>
        [NotNull]
        public string GetDeclarationString()
        {
            var sb = new StringBuilder();

            var attributes = new List<string>();
            if (Flow == FlowDirection.Out)
            {
                attributes.Add("OutAttribute");
            }
            else if (Flow == FlowDirection.Undefined)
            {
                attributes.Add("InAttribute");
                attributes.Add("OutAttribute");
            }

            if (!string.IsNullOrEmpty(ComputeSize))
            {
                if (int.TryParse(ComputeSize, out var count))
                {
                    attributes.Add($"CountAttribute(Count = {count})");
                }
                else
                {
                    if (ComputeSize.StartsWith("COMPSIZE"))
                    {
                        //remove the compsize hint, just keep comma delimited param names
                        var len = "COMPSIZE(".Length;
                        var computed = ComputeSize.Substring(len, ComputeSize.Length - len - 1);
                        attributes.Add($"CountAttribute(Computed = \"{computed}\")");
                    }
                    else
                    {
                        attributes.Add($"CountAttribute(Parameter = \"{ComputeSize}\")");
                    }
                }
            }

            if (attributes.Count != 0)
            {
                sb.Append("[");
                sb.Append(string.Join(", ", attributes));
                sb.Append("] ");
            }

            if (ParameterType.IsReference)
            {
                if (Flow == FlowDirection.Out)
                {
                    sb.Append("out ");
                }
                else
                {
                    sb.Append("ref ");
                }
            }

            sb.Append(ParameterType.GetDeclarationString());

            if (!string.IsNullOrEmpty(Name))
            {
                sb.Append(" ");
                sb.Append(Name);
            }

            return sb.ToString();
        }

        /// <inheritdoc/>
        public int CompareTo([NotNull] ParameterDefinition other)
        {
            var result = ParameterType.CompareTo(other.ParameterType);

            if (result == 0)
            {
                result = string.Compare(Name, other.Name, StringComparison.Ordinal);
            }
            return result;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var modifier = ParameterType.IsReference ? Flow == FlowDirection.Out ? "out " : "ref " : string.Empty;

            return $"{modifier}{base.ToString()} {Name}";
        }

        /// <inheritdoc/>
        public bool Equals(ParameterDefinition other)
        {
            if (other is null)
            {
                return false;
            }

            var result =
                ParameterType.Equals(other.ParameterType) &&
                Name.Equals(other.Name);

            return result;
        }
    }
}
