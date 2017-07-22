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
    internal class Delegate : IComparable<Delegate>, IEquatable<Delegate>
    {
        //internal static DelegateCollection Delegates;

        private bool? cls_compliance_overriden;

        protected static Regex endings = new Regex(@"((((d|f|fi)|u?[isb])_?v?)|v)", RegexOptions.Compiled | RegexOptions.RightToLeft);
        protected static Regex endingsNotToTrim = new Regex("(ib|[tdrey]s|[eE]n[vd]|bled|Flag|Tess|Status|Pixels|Instanced|Indexed|Varyings|Boolean|IDs)", RegexOptions.Compiled | RegexOptions.RightToLeft);

        // Add a trailing v to functions matching this regex. Used to differntiate between overloads taking both
        // a 'type' and a 'ref type' (such overloads are not CLS Compliant).
        // The default Regex matches no functions. Create a new Regex in Bind.Generator classes to override the default behavior.
        internal static Regex endingsAddV = new Regex("^0", RegexOptions.Compiled);

        public Delegate()
        {
            Parameters = new ParameterCollection();
        }

        public Delegate(Delegate d)
        {
            Category = d.Category;
            Extension = d.Extension;
            Name = d.Name;
            Parameters = new ParameterCollection(d.Parameters);
            ReturnType = new Type(d.ReturnType);
            Version = d.Version;
            //this.Version = !String.IsNullOrEmpty(d.Version) ? new string(d.Version.ToCharArray()) : "";
            Deprecated = d.Deprecated;
            DeprecatedVersion = d.DeprecatedVersion;
            EntryPoint = d.EntryPoint;
            Obsolete = d.Obsolete;
            cls_compliance_overriden = d.cls_compliance_overriden;
            Slot = d.Slot;
        }

        /// <summary>
        ///  Gets the CLSCompliant property. True if the delegate is not CLSCompliant.
        /// </summary>
        public virtual bool CLSCompliant
        {
            get
            {
                if (cls_compliance_overriden != null)
                {
                    return (bool)cls_compliance_overriden;
                }

                if (Unsafe)
                {
                    return false;
                }

                if (!ReturnType.CLSCompliant)
                {
                    return false;
                }

                foreach (Parameter p in Parameters)
                {
                    if (!p.CLSCompliant)
                    {
                        return false;
                    }
                }
                return true;
            }
            set
            {
                cls_compliance_overriden = value;
            }
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

                if (ReturnType.WrapperType != WrapperTypes.None)
                {
                    return true;
                }

                foreach (Parameter p in Parameters)
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

                if (ReturnType.Pointer != 0)
                {
                    return true;
                }

                foreach (Parameter p in Parameters)
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
        public Type ReturnType { get; set; } = new Type();

        private string _name;
        /// <summary>
        /// Gets or sets the name of the opengl function.
        /// </summary>
        public virtual string Name
        {
            get { return _name; }
            set
            {
                if (!String.IsNullOrEmpty(value))
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
            sb.Append(ReturnType);
            sb.Append(" ");
            sb.Append(Name);
            sb.Append(Parameters.ToString());

            return sb.ToString();
        }

        public int CompareTo(Delegate other)
        {
            int ret = Name.CompareTo(other.Name);
            if (ret == 0)
            {
                ret = Parameters.CompareTo(other.Parameters);
            }
            if (ret == 0)
            {
                ret = ReturnType.CompareTo(other.ReturnType);
            }
            return ret;
        }

        public bool Equals(Delegate other)
        {
            return
                Name.Equals(other.Name) &&
                Parameters.Equals(other.Parameters) &&
                ReturnType.Equals(other.ReturnType);
        }
    }

    internal class DelegateCollection : IDictionary<string, List<Delegate>>
    {
        private readonly SortedDictionary<string, List<Delegate>> Delegates =
            new SortedDictionary<string, List<Delegate>>();

        public void Add(Delegate d)
        {
            if (!ContainsKey(d.Name))
            {
                Add(d.Name, new List<Delegate> { d });
            }
            else
            {
                var list = Delegates[d.Name];
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
                    if (String.IsNullOrEmpty(list[index].Version))
                    {
                        list[index].Version = d.Version;
                    }
                }
            }
        }

        public void AddRange(IEnumerable<Delegate> delegates)
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

        public void Add(string key, List<Delegate> value)
        {
            Delegates.Add(key, value.ToList());
        }

        public bool ContainsKey(string key)
        {
            return Delegates.ContainsKey(key);
        }

        public bool Remove(string key)
        {
            return Delegates.Remove(key);
        }

        public bool TryGetValue(string key, out List<Delegate> value)
        {
            return Delegates.TryGetValue(key, out value);
        }

        public List<Delegate> this[string index]
        {
            get
            {
                return Delegates[index];
            }
            set
            {
                Delegates[index] = value;
            }
        }

        public ICollection<string> Keys
        {
            get
            {
                return Delegates.Keys;
            }
        }

        public ICollection<List<Delegate>> Values
        {
            get
            {
                return Delegates.Values;
            }
        }

        public void Add(KeyValuePair<string, List<Delegate>> item)
        {
            Delegates.Add(item.Key, item.Value.ToList());
        }

        public void Clear()
        {
            Delegates.Clear();
        }

        public bool Contains(KeyValuePair<string, List<Delegate>> item)
        {
            return Delegates.Contains(item);
        }

        public void CopyTo(KeyValuePair<string, List<Delegate>>[] array, int arrayIndex)
        {
            Delegates.CopyTo(array, arrayIndex);
        }

        public bool Remove(KeyValuePair<string, List<Delegate>> item)
        {
            return Delegates.Remove(item.Key);
        }

        public int Count
        {
            get
            {
                return Delegates.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public IEnumerator<KeyValuePair<string, List<Delegate>>> GetEnumerator()
        {
            return Delegates.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return Delegates.GetEnumerator();
        }
    }
}
