#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Bind.Structures
{
    /// <summary>
    /// Represents a single parameter of an opengl function.
    /// </summary>
    public class Parameter : Type
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

            this.Name = p.Name;
            this.Unchecked = p.Unchecked;
            this.UnmanagedType = p.UnmanagedType;
            this.Flow = p.Flow;
            this.cache = p.cache;
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
                    _name = value;
                    rebuild = true;
                }
            }
        }

        #endregion

        #region UnmanagedType property

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

        /// <summary>
        /// Enumarates the possible flows of a parameter (ie. is this parameter
        /// used as input or as output?)
        /// </summary>
        public enum FlowDirection
        {
            Undefined = 0,
            In,
            Out
        }

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

        public override string ToString()
        {
            return ToString(false);
        }

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
                    sb.Append("[Out] ");
                else if (Flow == FlowDirection.Undefined)
                    sb.Append("[In, Out] ");

                if (Reference)
                {
                    if (Flow == FlowDirection.Out)
                        sb.Append("out ");
                    else
                        sb.Append("ref ");
                }

                if (!override_unsafe_setting && ((Settings.Compatibility & Settings.Legacy.NoPublicUnsafeFunctions) != Settings.Legacy.None))
                {
                    if (Pointer)
                    {
                        sb.Append("IntPtr");
                    }
                    else
                    {
                        sb.Append(CurrentType);
                        if (Array > 0)
                            sb.Append("[]");
                    }
                }
                else
                {
                    sb.Append(CurrentType);
                    if (Pointer)
                        sb.Append("*");
                    if (Array > 0)
                        sb.Append("[]");
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

        #region override public void Translate(string category)

        override public void Translate(string category)
        {
            base.Translate(category);

            // Find out the necessary wrapper types.
            if (Pointer)/* || CurrentType == "IntPtr")*/
            {
                WrapperType = WrapperTypes.ArrayParameter;

                if (CurrentType.ToLower().Contains("char") || CurrentType.ToLower().Contains("string"))
                {
                    // char* or string -> [In] String or [Out] StringBuilder
                    CurrentType =
                        Flow == Parameter.FlowDirection.Out ?
                        "System.Text.StringBuilder" :
                        "System.String";

                    Pointer = false;
                    WrapperType = WrapperTypes.None;
                }
                else if (CurrentType.ToLower().Contains("void") || PreviousType.ToLower().Contains("void")) /*|| CurrentType.Contains("IntPtr"))*/
                {
                    CurrentType = "IntPtr";
                    Pointer = false;
                    WrapperType = WrapperTypes.GenericParameter;
                }
            }

            if (Reference)
                WrapperType = WrapperTypes.ReferenceParameter;

            // This causes problems with bool arrays
            //if (CurrentType.ToLower().Contains("bool"))
            //    WrapperType = WrapperTypes.BoolParameter;
        }

        #endregion
    }

    /// <summary>
    /// Holds the parameter list of an opengl function.
    /// </summary>
    public class ParameterCollection : List<Parameter>
    {
        string cache = String.Empty;
        string callStringCache = String.Empty;
        private bool rebuild = true;
        bool hasPointerParameters;
        bool hasReferenceParameters;
        bool unsafe_types_allowed;
        private bool Rebuild
        {
            get { return rebuild; }
            set
            {
                rebuild = value;
            }
        }

        #region Constructors

        public ParameterCollection()
        {
        }

        public ParameterCollection(ParameterCollection pc)
        {
            foreach (Parameter p in pc)
            {
                this.Add(new Parameter(p));
            }
        }

        #endregion

        #region void BuildCache()

        void BuildCache()
        {
            BuildCallStringCache();
            BuildToStringCache(unsafe_types_allowed);
            BuildReferenceAndPointerParametersCache();
            Rebuild = false;
        }

        #endregion

        #region public bool HasPointerParameters

        public bool HasPointerParameters
        {
            get
            {
                if (!rebuild)
                {
                    return hasPointerParameters;
                }
                else
                {
                    BuildCache();
                    return hasPointerParameters;
                }
            }
        }

        #endregion

        #region public bool HasReferenceParameters

        public bool HasReferenceParameters
        {
            get
            {
                if (!Rebuild)
                {
                    return hasReferenceParameters;
                }
                else
                {
                    BuildCache();
                    return hasReferenceParameters;
                }
            }
        }

        #endregion

        #region void BuildReferenceAndPointerParametersCache()

        void BuildReferenceAndPointerParametersCache()
        {
            foreach (Parameter p in this)
            {
                if (p.Pointer || p.CurrentType.Contains("IntPtr"))
                    hasPointerParameters = true;

                if (p.Reference)
                    hasReferenceParameters = true;
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
            if (this.Count > 0)
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

            if (this.Count > 0)
            {
                foreach (Parameter p in this)
                {
                    if (p.Unchecked)
                        sb.Append("unchecked((" + p.CurrentType + ")");

                    if (p.CurrentType != "object")
                    {
                        if (p.CurrentType.ToLower().Contains("string"))
                        {
                            sb.Append(String.Format("({0}{1})",
                                p.CurrentType, (p.Array > 0) ? "[]" : ""));
                        }
                        else if (p.Pointer || p.Array > 0 || p.Reference)
                        {
                            if (((Settings.Compatibility & Settings.Legacy.TurnVoidPointersToIntPtr) != Settings.Legacy.None) &&
                                p.Pointer && p.CurrentType.Contains("void"))
                                sb.Append("(IntPtr)");
                            else 
                                sb.Append(String.Format("({0}*)", p.CurrentType));
                        }
                        else
                        {
                            sb.Append(String.Format("({0})", p.CurrentType));
                        }
                    }

                    sb.Append(
                        Utilities.Keywords.Contains(p.Name) ? "@" + p.Name : p.Name
                    );

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
    }
}
