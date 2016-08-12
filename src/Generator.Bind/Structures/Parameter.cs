#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.XPath;

namespace Bind.Structures
{
    /// <summary>
    /// Represents a single parameter of an opengl function.
    /// </summary>
    class Parameter : Type, IComparable<Parameter>, IEquatable<Parameter>
    {
        string cache;

        #region Constructors

        /// <summary>
        /// Creates a new Parameter without type and name.
        /// </summary>
        public Parameter()
            :base()
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
                return;

            Name = p.Name;
            Unchecked = p.Unchecked;
            UnmanagedType = p.UnmanagedType;
            Generic = p.Generic;
            Flow = p.Flow;
            cache = p.cache;
            ComputeSize = p.ComputeSize;
            //this.rebuild = false;
        }

        #endregion

        #region RawName

        /// <summary>
        /// Gets or sets the raw name of the parameter.
        /// </summary>
        public string RawName
        {
            get;
            private set;
        }

        #endregion

        #region Name

        /// <summary>
        /// Gets the name of the parameter. If the name matches a keyword of the current language,
        /// then it is escaped with <see cref="Settings.KeywordEscapeCharacter"/>.
        /// </summary>
        public string Name
        {
            get
            {
                return RawName;
            }
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

        #endregion

        #region UnmanagedType

        UnmanagedType _unmanaged_type;
        /// <summary>
        /// Gets or sets the name of the parameter.
        /// </summary>
        private UnmanagedType UnmanagedType
        {
            get { return _unmanaged_type; }
            set
            {
                if (_unmanaged_type != value)
                {
                    _unmanaged_type = value;
                }
            }
        }

        #endregion

        #region public FlowDirection Flow

        FlowDirection _flow;

        /// <summary>
        /// Gets or sets the flow of the parameter.
        /// </summary>
        public FlowDirection Flow
        {
            get { return _flow; }
            set
            {
                if (_flow != value)
                {
                    _flow = value;
                }
            }
        }

        #endregion

        #region public bool NeedsPin

        public bool NeedsPin
        {
            get
            {
                return (Array > 0 || Reference || CurrentType == "object") &&
                        !CurrentType.ToLower().Contains("string");
            }
        }

        #endregion

        #region public bool Unchecked

        private bool _unchecked;

        public bool Unchecked
        {
            get { return _unchecked; }
            set
            {
                if (_unchecked != value)
                {
                    _unchecked = value;
                }
            }
        }

        #endregion

        #region public bool Generic
        
        bool generic;
        public bool Generic
        {
            get { return generic; }
            set { generic = value; }
        }

        #endregion

        #region public bool DiffersOnlyOnReference

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

        #endregion

        #region public string ComputeSize

        string computeSize;
        public string ComputeSize
        {
            get { return computeSize; }
            set { computeSize = value; }
        }

        #endregion

        #region Static Members

        // Returns the FlowDirection that matches the specified string
        // ("out" or "in", otherwise undefined).
        public static FlowDirection GetFlowDirection(string direction)
        {
            return direction == "out" ? FlowDirection.Out : direction == "in" ? FlowDirection.In : FlowDirection.Undefined;
        }
        
        #endregion

        #region IComparable<Parameter> Members

        public int CompareTo(Parameter other)
        {
            int result = base.CompareTo(other);
            if (result == 0)
                result = Name.CompareTo(other.Name);
            return result;
        }

        #endregion

        #region ToString

        public override string ToString()
        {
            return String.Format("{2}{0} {1}",
                base.ToString(),
                Name,
                Reference ? 
                    Flow == FlowDirection.Out ? "out " : "ref " :
                    String.Empty);
        }

        #endregion

        #region IEquatable<Parameter> Members

        public bool Equals(Parameter other)
        {
            bool result =
                base.Equals(other as Type) &&
                Name.Equals(other.Name);

            return result;
        }

        #endregion
    }

    /// <summary>
    /// Holds the parameter list of an opengl function.
    /// </summary>
    class ParameterCollection : IList<Parameter>, IComparable<ParameterCollection>, IEquatable<ParameterCollection>
    {
        readonly List<Parameter> Parameters = new List<Parameter>();

        bool hasPointerParameters;
        bool hasReferenceParameters;
        bool hasUnsignedParameters;
        bool hasGenericParameters;

        public bool Rebuild { get; set; }
        Settings Settings { get; set; }

        #region Constructors

        public ParameterCollection()
        {
        }

        public ParameterCollection(ParameterCollection pc)
        {
            foreach (Parameter p in pc)
            {
                Add(new Parameter(p));
            }
        }

        public ParameterCollection(IEnumerable<Parameter> parameters)
        {
            foreach (Parameter p in parameters)
                Add(new Parameter(p));
        }

        #endregion

        #region BuildCache

        void BuildCache()
        {
            BuildReferenceAndPointerParametersCache();
            Rebuild = false;
        }

        #endregion

        #region public bool HasPointerParameters

        public bool HasPointerParameters
        {
            get
            {
                if (Rebuild)
                {
                    BuildCache();
                }

                return hasPointerParameters;
            }
        }

        #endregion

        #region public bool HasReferenceParameters

        public bool HasReferenceParameters
        {
            get
            {
                if (Rebuild)
                {
                    BuildCache();
                }

                return hasReferenceParameters;
            }
        }

        #endregion

        #region public bool HasUnsignedParameters

        public bool HasUnsignedParameters
        {
            get
            {
                if (Rebuild)
                {
                    BuildCache();
                }

                return hasUnsignedParameters;
            }
        }

        #endregion

        #region public bool HasGenericParameters

        public bool HasGenericParameters
        {
            get
            {
                if (Rebuild)
                {
                    BuildCache();
                }

                return hasGenericParameters;
            }
        }
        
        #endregion

        #region void BuildReferenceAndPointerParametersCache()

        void BuildReferenceAndPointerParametersCache()
        {
            foreach (Parameter p in this)
            {
                if (p.Pointer != 0 || p.CurrentType.Contains("IntPtr"))
                    hasPointerParameters = true;

                if (p.Reference)
                    hasReferenceParameters = true;

                if (p.Unsigned)
                    hasUnsignedParameters = true;

                if (p.Generic)
                    hasGenericParameters = true;
            }
        }

        #endregion

        #region ToString

        // Only use for debugging, not for code generation!
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("(");
            if (Count > 0)
            {
                foreach (Parameter p in this)
                {
                    sb.Append(p.ToString());
                    sb.Append(", ");
                }
                sb.Replace(", ", ")", sb.Length - 2, 2);
            }
            else
                sb.Append(")");

            return sb.ToString();
        }

        #endregion

        #region ContainsType

        public bool ContainsType(string type)
        {
            foreach (Parameter p in this)
                if (p.CurrentType == type)
                    return true;
            return false;
        }

        #endregion

        #region IList<Parameter> Members
        
        public void Add(Parameter p)
        {
            Parameters.Add(p);
            Rebuild = true;
        }

        public void Clear()
        {
            Parameters.Clear();
            Rebuild = true;
        }

        public bool Contains(Parameter item)
        {
            return Parameters.Contains(item);
        }

        public void CopyTo(Parameter[] array, int arrayIndex)
        {
            Parameters.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return Parameters.Count; }
        }

        public bool IsReadOnly
        {
            get { return (Parameters as ICollection<Parameter>).IsReadOnly; }
        }

        public bool Remove(Parameter item)
        {
            var result = Parameters.Remove(item);
            if (result)
            {
                Rebuild = true;
            }
            return result;
        }

        public IEnumerator<Parameter> GetEnumerator()
        {
            return Parameters.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return Parameters.GetEnumerator();
        }

        public int IndexOf(Parameter item)
        {
            return Parameters.IndexOf(item);
        }

        public void Insert(int index, Parameter item)
        {
            Parameters.Insert(index, item);
            Rebuild = true;
        }

        public void RemoveAt(int index)
        {
            Parameters.RemoveAt(index);
            Rebuild = true;
        }

        public Parameter this[int index]
        {
            get
            {
                return Parameters[index];
            }
            set
            {
                Parameters[index] = value;
            }
        }

        #endregion

        #region IComparable<ParameterCollection> Members

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
                for (int i = 0; i < Count; i++)
                {
                    int result = this[i].CompareTo(other[i]);
                    if (result != 0)
                        return result;
                }
                return 0;
            }
        }

        #endregion

        #region IEquatable<ParameterCollection> Members

        public bool Equals(ParameterCollection other)
        {
            if (Count != other.Count)
                return false;

            bool result = true;
            for (int i = 0; i < Count && result; i++)
            {
                result &= this[i].Equals(other[i]);
            }
            return result;
        }

        #endregion
    }
}
