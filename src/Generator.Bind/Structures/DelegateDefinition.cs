/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Bind.Structures
{
    /// <summary>
    /// Represents an opengl function.
    /// The return value, function name, function parameters and opengl version can be retrieved or set.
    /// </summary>
    internal class DelegateDefinition : IComparable<DelegateDefinition>, IEquatable<DelegateDefinition>
    {
        //internal static DelegateCollection Delegates;

        private bool? _clsComplianceOverriden;

        // Add a trailing v to functions matching this regex. Used to differntiate between overloads taking both
        // a 'type' and a 'ref type' (such overloads are not CLS Compliant).
        // The default Regex matches no functions. Create a new Regex in Bind.Generator classes to override the default behavior.
        internal static Regex EndingsAddV = new Regex("^0", RegexOptions.Compiled);

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
            _clsComplianceOverriden = d._clsComplianceOverriden;
            Slot = d.Slot;
        }

        /// <summary>
        ///  Gets the CLSCompliant property. True if the delegate is not CLSCompliant.
        /// </summary>
        public virtual bool CLSCompliant
        {
            get
            {
                if (_clsComplianceOverriden != null)
                {
                    return (bool)_clsComplianceOverriden;
                }

                if (Unsafe)
                {
                    return false;
                }

                if (!ReturnTypeDefinition.CLSCompliant)
                {
                    return false;
                }

                foreach (ParameterDefinition p in Parameters)
                {
                    if (!p.CLSCompliant)
                    {
                        return false;
                    }
                }
                return true;
            }
            set => _clsComplianceOverriden = value;
        }

        public string Category { get; set; }

        /// <summary>
        /// Gets a value that indicates whether this function needs to be wrapped with a Marshaling function.
        /// This flag is set if a function contains an Array parameter, or returns
        /// an Array or string.
        /// </summary>
        public bool NeedsWrapper
        {
            get
            {
                // TODO: Add special cases for (Get)ShaderSource.

                if (ReturnTypeDefinition.WrapperType != WrapperTypes.None)
                {
                    return true;
                }

                foreach (ParameterDefinition p in Parameters)
                {
                    if (p.WrapperType != WrapperTypes.None)
                    {
                        return true;
                    }
                }

                return false;
            }
        }

        /// <summary>
        /// True if the delegate must be declared as 'unsafe'.
        /// </summary>
        public virtual bool Unsafe
        {
            //get { return @unsafe; }
            //set { @unsafe = value; }
            get
            {
                //if ((Settings.Compatibility & Settings.Legacy.NoPublicUnsafeFunctions) != Settings.Legacy.None)
                //    return false;

                if (ReturnTypeDefinition.Pointer != 0)
                {
                    return true;
                }

                foreach (ParameterDefinition p in Parameters)
                {
                    if (p.Pointer != 0)
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
        public virtual string Name
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

        // This method should only be used for debugging purposes, not for code generation!
        // Returns a string representing the full delegate declaration without decorations.
        // (ie "(unsafe) void delegate glXxxYyy(int a, float b, IntPtr c)"
        override public string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Unsafe ? "unsafe " : "");
            sb.Append("delegate ");
            sb.Append(ReturnTypeDefinition);
            sb.Append(" ");
            sb.Append(Name);
            sb.Append(Parameters);

            return sb.ToString();
        }

        public int CompareTo(DelegateDefinition other)
        {
            int ret = Name.CompareTo(other.Name);
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

        public bool Equals(DelegateDefinition other)
        {
            return
                Name.Equals(other.Name) &&
                Parameters.Equals(other.Parameters) &&
                ReturnTypeDefinition.Equals(other.ReturnTypeDefinition);
        }
    }

    internal class DelegateCollection : IDictionary<string, List<DelegateDefinition>>
    {
        private readonly SortedDictionary<string, List<DelegateDefinition>> _delegates =
            new SortedDictionary<string, List<DelegateDefinition>>();

        public void Add(DelegateDefinition d)
        {
            if (!ContainsKey(d.Name))
            {
                Add(d.Name, new List<DelegateDefinition> { d });
            }
            else
            {
                var list = _delegates[d.Name];
                var index = list.FindIndex(w => w.CompareTo(d) == 0);
                if (index < 0)
                {
                    // Function not defined - add it!
                    list.Add(d);
                }
                else
                {
                    // Function redefined with identical parameters:
                    // merge their version and category properties and
                    // discard the duplicate definition
                    if (!list[index].Category.Contains(d.Category))
                    {
                        list[index].Category += "|" + d.Category;
                    }
                    if (string.IsNullOrEmpty(list[index].Version))
                    {
                        list[index].Version = d.Version;
                    }
                }
            }
        }

        public void AddRange(IEnumerable<DelegateDefinition> delegates)
        {
            foreach (var d in delegates)
            {
                Add(d);
            }
        }

        public void AddRange(DelegateCollection delegates)
        {
            foreach (var d in delegates.Values.SelectMany(v => v))
            {
                Add(d);
            }
        }

        public void Add(string key, List<DelegateDefinition> value)
        {
            _delegates.Add(key, value.ToList());
        }

        public bool ContainsKey(string key)
        {
            return _delegates.ContainsKey(key);
        }

        public bool Remove(string key)
        {
            return _delegates.Remove(key);
        }

        public bool TryGetValue(string key, out List<DelegateDefinition> value)
        {
            return _delegates.TryGetValue(key, out value);
        }

        public List<DelegateDefinition> this[string index]
        {
            get => _delegates[index];
            set => _delegates[index] = value;
        }

        public ICollection<string> Keys => _delegates.Keys;

        public ICollection<List<DelegateDefinition>> Values => _delegates.Values;

        public void Add(KeyValuePair<string, List<DelegateDefinition>> item)
        {
            _delegates.Add(item.Key, item.Value.ToList());
        }

        public void Clear()
        {
            _delegates.Clear();
        }

        public bool Contains(KeyValuePair<string, List<DelegateDefinition>> item)
        {
            return _delegates.Contains(item);
        }

        public void CopyTo(KeyValuePair<string, List<DelegateDefinition>>[] array, int arrayIndex)
        {
            _delegates.CopyTo(array, arrayIndex);
        }

        public bool Remove(KeyValuePair<string, List<DelegateDefinition>> item)
        {
            return _delegates.Remove(item.Key);
        }

        public int Count => _delegates.Count;

        public bool IsReadOnly => false;

        public IEnumerator<KeyValuePair<string, List<DelegateDefinition>>> GetEnumerator()
        {
            return _delegates.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _delegates.GetEnumerator();
        }
    }
}
