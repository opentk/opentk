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
    public class Parameter : Type, IComparable<Parameter>
    {
        string cache;
        bool rebuild;
        bool unsafe_allowed;        // True if the cache may contain unsafe types, false otherwise.

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
            //this.rebuild = false;
        }

        #endregion

        #region public string Name

        string _name = String.Empty;
        /// <summary>
        /// Gets or sets the name of the parameter.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    while (value.StartsWith("*"))
                    {
                        Pointer++;
                        value = value.Substring(1);
                    }
                    _name = value;
                    rebuild = true;
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
                    rebuild = true;
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
                    rebuild = true;
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
                    rebuild = true;
                }
            }
        }

        #endregion

        #region public bool Generic
        
        bool generic;
        public bool Generic
        {
            get { return generic; }
            set { generic = value; }
        }

        #endregion

        #region public override string CurrentType

        public override string CurrentType
        {
            get
            {
                return base.CurrentType;
            }
            set
            {
                base.CurrentType = value;
                rebuild = true;
            }
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

        #region public override string ToString()

        public override string ToString()
        {
            return ToString(false);
        }

        #endregion

        #region public string ToString(bool override_unsafe_setting)

        public string ToString(bool override_unsafe_setting)
        {
            rebuild |= unsafe_allowed |= override_unsafe_setting;
            unsafe_allowed = override_unsafe_setting;

            if (!String.IsNullOrEmpty(cache) && !rebuild)
            {
               return cache;
            }
            else
            {
                StringBuilder sb = new StringBuilder();

                if (Flow == FlowDirection.Out)
                    sb.Append("[OutAttribute] ");
                else if (Flow == FlowDirection.Undefined)
                    sb.Append("[InAttribute, OutAttribute] ");

                if (Reference)
                {
                    if (Flow == FlowDirection.Out)
                        sb.Append("out ");
                    else
                        sb.Append("ref ");
                }

                if (!override_unsafe_setting && ((Settings.Compatibility & Settings.Legacy.NoPublicUnsafeFunctions) != Settings.Legacy.None))
                {
                    if (Pointer != 0)
                    {
                        sb.Append("IntPtr");
                    }
                    else
                    {
                        sb.Append(base.ToString());
                        if (Array > 0)
                        {
                            sb.Append("[");
                            for (int i = 1; i < Array; i++)
                                sb.Append(",");
                            sb.Append("]");
                        }
                    }
                }
                else
                {
                    sb.Append(base.ToString());
                    for (int i = 0; i < Pointer; i++)
                        sb.Append("*");
                    if (Array > 0)
                    {
                        sb.Append("[");
                        for (int i = 1; i < Array; i++)
                            sb.Append(",");
                        sb.Append("]");
                    }
                }
                if (!String.IsNullOrEmpty(Name))
                {
                    sb.Append(" ");
                    sb.Append(Utilities.Keywords.Contains(Name) ? "@" + Name : Name);
                }

                rebuild = false;
                cache = sb.ToString();
                return cache;
            }
        }

        #endregion

        #region override public void Translate(XPathNavigator overrides, string category)

        override public void Translate(XPathNavigator overrides, string category)
        {
            base.Translate(overrides, category);

            // Find out the necessary wrapper types.
            if (Pointer != 0)/* || CurrentType == "IntPtr")*/
            {
                if (CurrentType.ToLower().Contains("string"))
                {
                    // string* -> [In] String[] or [Out] StringBuilder[]
                    QualifiedType =
                        Flow == FlowDirection.Out ?
                        "StringBuilder[]" :
                        "String[]";

                    Pointer = 0;
                    WrapperType = WrapperTypes.None;
                }
                else if (CurrentType.ToLower().Contains("char"))
                {
                    // char* -> [In] String or [Out] StringBuilder
                    QualifiedType =
                        Flow == FlowDirection.Out ?
                        "StringBuilder" :
                        "String";

                    Pointer = 0;
                    WrapperType = WrapperTypes.None;
                }
                else if (CurrentType.ToLower().Contains("void") ||
                    (!String.IsNullOrEmpty(PreviousType) && PreviousType.ToLower().Contains("void"))) /*|| CurrentType.Contains("IntPtr"))*/
                {
                    CurrentType = "IntPtr";
                    Pointer = 0;
                    WrapperType = WrapperTypes.GenericParameter;
                }
                else
                {
                    WrapperType = WrapperTypes.ArrayParameter;
                }
            }

            if (Reference)
                WrapperType |= WrapperTypes.ReferenceParameter;

            if (Name == "params")
                Name = "@params";
            if (Name == "event")
                Name = "@event";

            // This causes problems with bool arrays
            //if (CurrentType.ToLower().Contains("bool"))
            //    WrapperType = WrapperTypes.BoolParameter;
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
    }

    /// <summary>
    /// Holds the parameter list of an opengl function.
    /// </summary>
    public class ParameterCollection : List<Parameter>, IComparable<ParameterCollection>
    {
        string cache = String.Empty;
        string callStringCache = String.Empty;
        private bool rebuild = true;
        bool hasPointerParameters;
        bool hasReferenceParameters;
        bool hasUnsignedParameters;
        bool hasGenericParameters;
        bool unsafe_types_allowed;
        public bool Rebuild
        {
            private get { return rebuild; }
            set { rebuild = true;/*value;*/ }
        }

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

        #region void BuildCache()

        void BuildCache()
        {
            BuildReferenceAndPointerParametersCache();
            BuildCallStringCache();
            BuildToStringCache(unsafe_types_allowed);
            Rebuild = false;
        }

        #endregion

        #region public bool HasPointerParameters

        public bool HasPointerParameters
        {
            get
            {
                if (Rebuild)
                    BuildCache();

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
                    BuildCache();
                
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
                    BuildCache();

                return hasUnsignedParameters;
            }
        }

        #endregion

        #region public bool HasGenericParameters

        public bool HasGenericParameters
        {
            get
            {
                if (Rebuild)
                    BuildCache();

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

        #region new public void Add(Parameter p)

        new public void Add(Parameter p)
        {
            Rebuild = true;
            base.Add(p);
        }

        #endregion

        public override string ToString()
        {
            return ToString(false);
        }

        #region public string ToString(bool override_unsafe_setting)

        /// <summary>
        /// Gets the parameter declaration string.
        /// </summary>
        /// <param name="override_unsafe_setting">
        /// If true, unsafe types will be used even if the Settings.Compatibility.NoPublicUnsafeFunctions flag is set.
        /// </param>
        /// <returns>The parameter list of an opengl function in the form ( [parameters] )</returns>
        public string ToString(bool override_unsafe_setting)
        {
            Rebuild |= unsafe_types_allowed != override_unsafe_setting;
            unsafe_types_allowed = override_unsafe_setting;

            if (!Rebuild)
            {
                return cache;
            }
            else
            {
                BuildCache();
                return cache;
            }
        }

        #endregion

        #region void BuildToStringCache(bool override_unsafe_setting)

        void BuildToStringCache(bool override_unsafe_setting)
        {
            unsafe_types_allowed = override_unsafe_setting;

            StringBuilder sb = new StringBuilder();
            sb.Append("(");
            if (Count > 0)
            {
                foreach (Parameter p in this)
                {
                    sb.Append(p.ToString(override_unsafe_setting));
                    sb.Append(", ");
                }
                sb.Replace(", ", ")", sb.Length - 2, 2);
            }
            else
                sb.Append(")");

            cache = sb.ToString();
        }

        #endregion

        #region public string CallString()

        public string CallString()
        {
            if (!Rebuild)
            {
                return callStringCache;
            }
            else
            {
                BuildCache();
                return callStringCache;
            }
        }

        #endregion

        #region private void BuildCallStringCache()

        /// <summary>
        /// Builds a call string instance and caches it.
        /// </summary>
        private void BuildCallStringCache()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("(");

            if (Count > 0)
            {
                foreach (Parameter p in this)
                {
                    if (p.Unchecked)
                        sb.Append("unchecked((" + p.QualifiedType + ")");

                    if (!p.Generic && p.CurrentType != "object")
                    {
                        if (p.CurrentType.ToLower().Contains("string"))
                        {
                            sb.Append(String.Format("({0}{1})",
                                p.QualifiedType, (p.Array > 0) ? "[]" : ""));
                        }
                        else if (p.IndirectionLevel != 0)
                        {
                            if (((Settings.Compatibility & Settings.Legacy.TurnVoidPointersToIntPtr) != Settings.Legacy.None) &&
                                p.Pointer != 0 && p.CurrentType.Contains("void"))
                                sb.Append("(System.IntPtr)");
                            else
                            {
                                sb.Append("(");
                                sb.Append(p.QualifiedType);
                                for (int i = 0; i < p.IndirectionLevel; i++)
                                    sb.Append("*");
                                sb.Append(")");
                            }
                        }
                        else
                        {
                            sb.Append(String.Format("({0})", p.QualifiedType));
                        }
                    }

                    sb.Append(Utilities.Keywords.Contains(p.Name) ? "@" + p.Name : p.Name);

                    if (p.Unchecked)
                        sb.Append(")");

                    sb.Append(", ");
                }
                sb.Replace(", ", ")", sb.Length - 2, 2);
            }
            else
            {
                sb.Append(")");
            }

            callStringCache = sb.ToString();
        }

        #endregion

        public bool ContainsType(string type)
        {
            foreach (Parameter p in this)
                if (p.CurrentType == type)
                    return true;
            return false;
        }

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
    }
}
