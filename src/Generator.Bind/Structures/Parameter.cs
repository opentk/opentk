/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Bind.Structures
{
    /// <summary>
    /// Represents a single parameter of an opengl function.
    /// </summary>
    internal class Parameter : Type, IComparable<Parameter>, IEquatable<Parameter>
    {
        private string _cache;

        /// <summary>
        /// Creates a new Parameter without type and name.
        /// </summary>
        public Parameter()
        {
        }

        /// <summary>
        /// Creates a new parameter from the parameters passed (deep copy).
        /// </summary>
        /// <param name="p">The parameter to copy from.</param>
        public Parameter(Parameter p)
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

        public bool NeedsPin => (Array > 0 || Reference || CurrentType == "object") &&
                                !CurrentType.ToLower().Contains("string");

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

        // Returns true if this parameter differs only on reference compared to another parameter, i.e:
        // returns true for 'int' & 'ref int'
        // returns true for 'ref float' & 'float'
        // returns false 'int' & 'int*'
        // returns false 'int' & 'int[]'
        // returns false 'int' & 'float'
        public bool DiffersOnlyOnReference(Parameter other)
        {
            return
                CurrentType == other.CurrentType &&
                (Reference && !(other.Reference || other.Array > 0 || other.Pointer != 0) ||
                other.Reference && !(Reference || Array > 0 || Pointer != 0));
        }

        public string ComputeSize { get; set; }

        // Returns the FlowDirection that matches the specified string
        // ("out" or "in", otherwise undefined).
        public static FlowDirection GetFlowDirection(string direction)
        {
            return direction == "out" ? FlowDirection.Out : direction == "in" ? FlowDirection.In : FlowDirection.Undefined;
        }


        public int CompareTo(Parameter other)
        {
            var result = base.CompareTo(other);
            if (result == 0)
            {
                result = Name.CompareTo(other.Name);
            }
            return result;
        }

        public override string ToString()
        {
            return string.Format("{2}{0} {1}",
                base.ToString(),
                Name,
                Reference ?
                    Flow == FlowDirection.Out ? "out " : "ref " :
                    string.Empty);
        }

        public bool Equals(Parameter other)
        {
            var result =
                base.Equals(other) &&
                Name.Equals(other.Name);

            return result;
        }
    }

    /// <summary>
    /// Holds the parameter list of an opengl function.
    /// </summary>
    internal class ParameterCollection : IList<Parameter>, IComparable<ParameterCollection>, IEquatable<ParameterCollection>
    {
        private readonly List<Parameter> _parameters = new List<Parameter>();

        private bool _hasPointerParameters;
        private bool _hasReferenceParameters;
        private bool _hasUnsignedParameters;
        private bool _hasGenericParameters;

        public bool Rebuild { get; set; }
        private Settings Settings { get; set; }

        public ParameterCollection()
        {
        }

        public ParameterCollection(ParameterCollection pc)
        {
            foreach (var p in pc)
            {
                Add(new Parameter(p));
            }
        }

        public ParameterCollection(IEnumerable<Parameter> parameters)
        {
            foreach (var p in parameters)
            {
                Add(new Parameter(p));
            }
        }

        private void BuildCache()
        {
            BuildReferenceAndPointerParametersCache();
            Rebuild = false;
        }

        public bool HasPointerParameters
        {
            get
            {
                if (Rebuild)
                {
                    BuildCache();
                }

                return _hasPointerParameters;
            }
        }

        public bool HasReferenceParameters
        {
            get
            {
                if (Rebuild)
                {
                    BuildCache();
                }

                return _hasReferenceParameters;
            }
        }

        public bool HasUnsignedParameters
        {
            get
            {
                if (Rebuild)
                {
                    BuildCache();
                }

                return _hasUnsignedParameters;
            }
        }

        public bool HasGenericParameters
        {
            get
            {
                if (Rebuild)
                {
                    BuildCache();
                }

                return _hasGenericParameters;
            }
        }


        private void BuildReferenceAndPointerParametersCache()
        {
            foreach (var p in this)
            {
                if (p.Pointer != 0 || p.CurrentType.Contains("IntPtr"))
                {
                    _hasPointerParameters = true;
                }

                if (p.Reference)
                {
                    _hasReferenceParameters = true;
                }

                if (p.Unsigned)
                {
                    _hasUnsignedParameters = true;
                }

                if (p.Generic)
                {
                    _hasGenericParameters = true;
                }
            }
        }

        // Only use for debugging, not for code generation!
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("(");
            if (Count > 0)
            {
                foreach (var p in this)
                {
                    sb.Append(p.ToString());
                    sb.Append(", ");
                }
                sb.Replace(", ", ")", sb.Length - 2, 2);
            }
            else
            {
                sb.Append(")");
            }

            return sb.ToString();
        }

        public bool ContainsType(string type)
        {
            foreach (var p in this)
            {
                if (p.CurrentType == type)
                {
                    return true;
                }
            }
            return false;
        }

        public void Add(Parameter p)
        {
            _parameters.Add(p);
            Rebuild = true;
        }

        public void Clear()
        {
            _parameters.Clear();
            Rebuild = true;
        }

        public bool Contains(Parameter item)
        {
            return _parameters.Contains(item);
        }

        public void CopyTo(Parameter[] array, int arrayIndex)
        {
            _parameters.CopyTo(array, arrayIndex);
        }

        public int Count => _parameters.Count;

        public bool IsReadOnly => (_parameters as ICollection<Parameter>).IsReadOnly;

        public bool Remove(Parameter item)
        {
            var result = _parameters.Remove(item);
            if (result)
            {
                Rebuild = true;
            }
            return result;
        }

        public IEnumerator<Parameter> GetEnumerator()
        {
            return _parameters.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _parameters.GetEnumerator();
        }

        public int IndexOf(Parameter item)
        {
            return _parameters.IndexOf(item);
        }

        public void Insert(int index, Parameter item)
        {
            _parameters.Insert(index, item);
            Rebuild = true;
        }

        public void RemoveAt(int index)
        {
            _parameters.RemoveAt(index);
            Rebuild = true;
        }

        public Parameter this[int index]
        {
            get => _parameters[index];
            set => _parameters[index] = value;
        }

        public int CompareTo(ParameterCollection other)
        {
            if (Count < other.Count)
            {
                return -1;
            }
            else if (Count > other.Count)
            {
                return 1;
            }
            else
            {
                for (var i = 0; i < Count; i++)
                {
                    var result = this[i].CompareTo(other[i]);
                    if (result != 0)
                    {
                        return result;
                    }
                }
                return 0;
            }
        }

        public bool Equals(ParameterCollection other)
        {
            if (Count != other.Count)
            {
                return false;
            }

            var result = true;
            for (var i = 0; i < Count && result; i++)
            {
                result &= this[i].Equals(other[i]);
            }
            return result;
        }
    }
}
