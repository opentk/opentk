/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */

using System;
using System.Text;
using JetBrains.Annotations;

namespace Bind.Structures
{
    /// <summary>
    /// Represents an opengl function.
    /// The return value, function name, function parameters and opengl version can be retrieved or set.
    /// </summary>
    internal class DelegateDefinition : IComparable<DelegateDefinition>, IEquatable<DelegateDefinition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DelegateDefinition"/> class.
        /// </summary>
        public DelegateDefinition()
        {
            Parameters = new ParameterCollection();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DelegateDefinition"/> class.
        /// This constructor performs a deep copy of the given delegate definition.
        /// </summary>
        /// <param name="d">The definition to copy.</param>
        public DelegateDefinition([NotNull] DelegateDefinition d)
        {
            Category = d.Category;
            ExtensionName = d.ExtensionName;
            Name = d.Name;
            Parameters = new ParameterCollection(d.Parameters);
            ReturnTypeDefinition = new TypeDefinition(d.ReturnTypeDefinition);
            Version = d.Version;
            DeprecatedVersion = d.DeprecatedVersion;
            EntryPoint = d.EntryPoint;
            ObsoletionReason = d.ObsoletionReason;
            Slot = d.Slot;
        }

        /// <summary>
        /// Gets or sets the category that the function is part of.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Gets a value indicating whether the function needs to be declared as "unsafe".
        /// </summary>
        public bool RequiresUnsafeDeclaration
        {
            get
            {
                if (ReturnTypeDefinition.IsPointer)
                {
                    return true;
                }

                foreach (var p in Parameters)
                {
                    if (p.ParameterType.IsPointer)
                    {
                        return true;
                    }
                }

                return false;
            }
        }

        /// <summary>
        /// Gets or sets the return value of the opengl function.
        /// </summary>
        public TypeDefinition ReturnTypeDefinition { get; set; } = new TypeDefinition();

        private string _name;

        /// <summary>
        /// Gets or sets the name of the opengl function.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value.Trim();
                }
            }
        }

        /// <summary>
        /// Gets or sets the set of parameters that the function takes.
        /// </summary>
        public ParameterCollection Parameters { get; set; }

        /// <summary>
        /// Gets or sets the OpenGL version that introduced this function.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets the name of the OpenGL extension that the function is a part of.
        /// </summary>
        public string ExtensionName { get; set; }

        /// <summary>
        /// Gets a value indicating whether the function is deprecated.
        /// </summary>
        public bool IsDeprecated => !string.IsNullOrWhiteSpace(DeprecatedVersion);

        /// <summary>
        /// Gets or sets the version that the function was deprecated in.
        /// </summary>
        public string DeprecatedVersion { get; set; }

        /// <summary>
        /// Gets or sets the name of the function's entry point.
        /// </summary>
        public string EntryPoint { get; set; }

        /// <summary>
        /// Gets or sets the reason why the function is obsolete.
        /// </summary>
        public string ObsoletionReason { get; set; }

        /// <summary>
        /// Gets a value indicating whether the function is obsolete.
        /// </summary>
        public bool IsObsolete => !string.IsNullOrWhiteSpace(ObsoletionReason);

        /// <summary>
        /// Gets or sets the slot index in the address table.
        /// </summary>
        public int Slot { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var sb = new StringBuilder();

            if (RequiresUnsafeDeclaration)
            {
                sb.Append("unsafe ");
            }

            sb.Append("delegate ");
            sb.Append(ReturnTypeDefinition);
            sb.Append(" ");
            sb.Append(Name);
            sb.Append(Parameters);

            return sb.ToString();
        }

        /// <inheritdoc/>
        public int CompareTo([NotNull] DelegateDefinition other)
        {
            var ret = string.Compare(Name, other.Name, StringComparison.Ordinal);

            if (ret == 0)
            {
                ret = Parameters.CompareTo(other.Parameters);
            }
            if (ret == 0)
            {
                ret = ReturnTypeDefinition.CompareTo(other.ReturnTypeDefinition);
            }
            return ret;
        }

        /// <inheritdoc/>
        public bool Equals(DelegateDefinition other)
        {
            if (other is null)
            {
                return false;
            }

            return
                Name.Equals(other.Name) &&
                Parameters.Equals(other.Parameters) &&
                ReturnTypeDefinition.Equals(other.ReturnTypeDefinition);
        }
    }
}
