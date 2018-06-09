/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */

using System;
using System.Text;

namespace Bind.Structures
{
    /// <summary>
    /// Represents an opengl function.
    /// The return value, function name, function parameters and opengl version can be retrieved or set.
    /// </summary>
    internal class DelegateDefinition : IComparable<DelegateDefinition>, IEquatable<DelegateDefinition>
    {
        public DelegateDefinition()
        {
            Parameters = new ParameterCollection();
        }

        public DelegateDefinition(DelegateDefinition d)
        {
            Category = d.Category;
            Extension = d.Extension;
            Name = d.Name;
            Parameters = new ParameterCollection(d.Parameters);
            ReturnTypeDefinition = new TypeDefinition(d.ReturnTypeDefinition);
            Version = d.Version;
            //this.Version = !String.IsNullOrEmpty(d.Version) ? new string(d.Version.ToCharArray()) : "";
            Deprecated = d.Deprecated;
            DeprecatedVersion = d.DeprecatedVersion;
            EntryPoint = d.EntryPoint;
            Obsolete = d.Obsolete;
            Slot = d.Slot;
        }

        public string Category { get; set; }

        /// <summary>
        /// True if the delegate must be declared as 'unsafe'.
        /// </summary>
        public bool Unsafe
        {
            //get { return @unsafe; }
            //set { @unsafe = value; }
            get
            {
                //if ((Settings.Compatibility & Settings.Legacy.NoPublicUnsafeFunctions) != Settings.Legacy.None)
                //    return false;

                if (ReturnTypeDefinition.IsPointer)
                {
                    return true;
                }

                foreach (var p in Parameters)
                {
                    if (p.IsPointer)
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

        public ParameterCollection Parameters { get; set; }

        /// <summary>
        /// Defines the opengl version that introduced this function.
        /// </summary>
        public string Version { get; set; }

        public string Extension
        {
            get;
            set;
        }

        public bool Deprecated { get; set; }

        public string DeprecatedVersion { get; set; }

        public string EntryPoint { get; set; }

        public string Obsolete { get; set; }

        // Slot index in the address table
        public int Slot { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append(Unsafe ? "unsafe " : "");
            sb.Append("delegate ");
            sb.Append(ReturnTypeDefinition);
            sb.Append(" ");
            sb.Append(Name);
            sb.Append(Parameters);

            return sb.ToString();
        }

        /// <inheritdoc/>
        public int CompareTo(DelegateDefinition other)
        {
            var ret = Name.CompareTo(other.Name);
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
            return
                Name.Equals(other.Name) &&
                Parameters.Equals(other.Parameters) &&
                ReturnTypeDefinition.Equals(other.ReturnTypeDefinition);
        }
    }
}
