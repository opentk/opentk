#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.XPath;

namespace Bind.Structures
{
    /// <summary>
    /// Represents an opengl function.
    /// The return value, function name, function parameters and opengl version can be retrieved or set.
    /// </summary>
    class Delegate : IComparable<Delegate>, IEquatable<Delegate>
    {
        //internal static DelegateCollection Delegates;

        bool? cls_compliance_overriden;

        protected static Regex endings = new Regex(@"((((d|f|fi)|u?[isb])_?v?)|v)", RegexOptions.Compiled | RegexOptions.RightToLeft);
        protected static Regex endingsNotToTrim = new Regex("(ib|[tdrey]s|[eE]n[vd]|bled|Flag|Tess|Status|Pixels|Instanced|Indexed|Varyings|Boolean|IDs)", RegexOptions.Compiled | RegexOptions.RightToLeft);

        // Add a trailing v to functions matching this regex. Used to differntiate between overloads taking both
        // a 'type' and a 'ref type' (such overloads are not CLS Compliant).
        // The default Regex matches no functions. Create a new Regex in Bind.Generator classes to override the default behavior. 
        internal static Regex endingsAddV = new Regex("^0", RegexOptions.Compiled);

        #region --- Constructors ---

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
            ReturnType = (Type)d.ReturnType.Clone();
            Version = d.Version;
            //this.Version = !String.IsNullOrEmpty(d.Version) ? new string(d.Version.ToCharArray()) : "";
            Deprecated = d.Deprecated;
            DeprecatedVersion = d.DeprecatedVersion;
            EntryPoint = d.EntryPoint;
            Obsolete = d.Obsolete;
            CLSCompliant = d.CLSCompliant;
            Slot = d.Slot;
            IsExtensionMethod = d.IsExtensionMethod;
        }

        #endregion

        #region --- Properties ---

        #region public bool CLSCompliant

        /// <summary>
        ///  Gets the CLSCompliant property. True if the delegate is not CLSCompliant.
        /// </summary>
        public virtual bool CLSCompliant
        {
            get
            {
                if (cls_compliance_overriden != null)
                    return (bool)cls_compliance_overriden;

                if (Unsafe)
                    return false;

                if (!ReturnType.CLSCompliant)
                    return false;

                foreach (Parameter p in Parameters)
                {
                    if (!p.Type.CLSCompliant)
                        return false;
                }
                return true;
            }
            set
            {
                cls_compliance_overriden = value;
            }
        }

        #endregion

        #region public string Category

        private string _category;

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        #endregion

        #region public bool NeedsWrapper

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
                    return true;

                foreach (Parameter p in Parameters)
                {
                    if (p.Type.WrapperType != WrapperTypes.None)
                        return true;
                }

                return false;
            }
        }

        #endregion

        #region public virtual bool Unsafe

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
                    return true;

                foreach (Parameter p in Parameters)
                {
                    if (p.Type.Pointer != 0)
                    {
                        return true;
                    }
                }

                return false;
            }
        }

        #endregion

        #region public Parameter ReturnType

        Type _return_type = new Type();
        /// <summary>
        /// Gets or sets the return value of the opengl function.
        /// </summary>
        public Type ReturnType
        {
            get { return _return_type; }
            set
            {
                _return_type = value;
            }
        }

        #endregion

        #region public virtual string Name

        string _name;
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

        #endregion

        #region public ParameterCollection Parameters

        ParameterCollection _parameters;

        public ParameterCollection Parameters
        {
            get { return _parameters; }
            set { _parameters = value; }
        }

        #endregion

        #region public string Version

        string _version;

        /// <summary>
        /// Defines the opengl version that introduced this function.
        /// </summary>
        public string Version
        {
            get { return _version; }
            set { _version = value; }
        }

        #endregion

        #region public bool Extension

        public string Extension
        {
            get;
            set;
        }

        #endregion

        public bool Deprecated { get; set; }
        public string DeprecatedVersion { get; set; }
        public string EntryPoint { get; set; }
        public string Obsolete { get; set; }

        /// <summary>
        /// True, if this instance is a .Net extension method; false otherwise.
        /// </summary>
        public bool IsExtensionMethod { get; set; }

        /// <summary>
        /// True, if this instance is a static method.
        /// Only used for class generation.
        /// </summary>
        public bool IsStaticMethod { get; set; }


        // Slot index in the address table
        public int Slot { get; set; }

        #endregion

        // This method should only be used for debugging purposes, not for code generation!
        // Returns a string representing the full delegate declaration without decorations.
        // (ie "(unsafe) void delegate glXxxYyy(int a, float b, IntPtr c)"
        override public string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Unsafe ? "unsafe " : "");
            sb.Append("delegate ");
            sb.Append(ReturnType.CurrentType);
            sb.Append(" ");
            sb.Append(Name);
            sb.Append(Parameters.ToString());

            return sb.ToString();
        }

        #region IComparable<Delegate> Members

        public int CompareTo(Delegate other)
        {
            int ret = (Extension != "Core").CompareTo(other.Extension != "Core");
            if (ret == 0)
                ret = Extension.CompareTo(other.Extension);
            if (ret == 0)
                ret = Name.CompareTo(other.Name);
            if (ret == 0)
                ret = Parameters.CompareTo(other.Parameters);
            if (ret == 0)
                ret = ReturnType.CompareTo(other.ReturnType);
            return ret;
        }

        #endregion

        #region IEquatable<Delegate> Members

        public bool Equals(Delegate other)
        {
            return
                Name.Equals(other.Name) &&
                Parameters.Equals(other.Parameters) &&
                ReturnType.Equals(other.ReturnType);
        }

        #endregion
    }

    #region DelegateCollection

    class DelegateCollection : GenericCollection<Delegate>
    {
        public override void Add(Delegate d)
        {
            if (!ContainsKey(d.Name))
            {
                Add(d.Name, new List<Delegate> { d });
            }
            else
            {
                var list = Collection[d.Name];
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

        public void AddRange(DelegateCollection delegates)
        {
            foreach (var d in delegates.Values.SelectMany(v => v))
            {
                Add(d);
            }
        }
    }

    #endregion
}
