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
    class Delegate : IComparable<Delegate>
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
            Name = d.Name;
            Parameters = new ParameterCollection(d.Parameters);
            ReturnType = new Type(d.ReturnType);
            Version = d.Version;
            //this.Version = !String.IsNullOrEmpty(d.Version) ? new string(d.Version.ToCharArray()) : "";
            Deprecated = d.Deprecated;
            DeprecatedVersion = d.DeprecatedVersion;
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
                    if (!p.CLSCompliant)
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
                    if (p.WrapperType != WrapperTypes.None)
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
                    if (p.Pointer != 0)
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

        string _extension;

        public string Extension
        {
            get
            {
                if (!String.IsNullOrEmpty(Name))
                {
                    _extension = Utilities.GetGL2Extension(Name);
                    return String.IsNullOrEmpty(_extension) ? "Core" : _extension;
                }
                else
                {
                    return null;
                }
            }
        }

        #endregion

        public bool Deprecated { get; set; }
        public string DeprecatedVersion { get; set; }

        #endregion

        /// <summary>
        /// Returns a string that represents an invocation of this delegate.
        /// </summary>
        public string CallString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Settings.DelegatesClass);
            sb.Append(Settings.NamespaceSeparator);
            sb.Append(Settings.FunctionPrefix);
            sb.Append(Name);
            sb.Append(Parameters.CallString());

            return sb.ToString();
        }

        /// <summary>
        /// Returns a string representing the full non-delegate declaration without decorations.
        /// (ie "(unsafe) void glXxxYyy(int a, float b, IntPtr c)"
        /// </summary>
        public string DeclarationString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Unsafe ? "unsafe " : "");
            sb.Append(ReturnType);
            sb.Append(" ");
            sb.Append(Name);
            sb.Append(Parameters.ToString(true));

            return sb.ToString();
        }

        /// <summary>
        /// Returns a string representing the full delegate declaration without decorations.
        /// (ie "(unsafe) void delegate glXxxYyy(int a, float b, IntPtr c)"
        /// </summary>
        override public string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Unsafe ? "unsafe " : "");
            sb.Append("delegate ");
            sb.Append(ReturnType);
            sb.Append(" ");
            sb.Append(Name);
            sb.Append(Parameters.ToString(true));

            return sb.ToString();
        }

        public Delegate GetCLSCompliantDelegate()
        {
            Delegate f = new Delegate(this);

            for (int i = 0; i < f.Parameters.Count; i++)
            {
                f.Parameters[i].CurrentType = f.Parameters[i].GetCLSCompliantType();
            }

            f.ReturnType.CurrentType = f.ReturnType.GetCLSCompliantType();

            return f;
        }

        #region IComparable<Delegate> Members

        public int CompareTo(Delegate other)
        {
            return Name.CompareTo(other.Name);
        }

        #endregion
    }

    #region class DelegateCollection : SortedDictionary<string, Delegate>

    class DelegateCollection : SortedDictionary<string, Delegate>
    {
        public void Add(Delegate d)
        {
            if (!ContainsKey(d.Name))
            {
                Add(d.Name, d);
            }
            else
            {
                Trace.WriteLine(String.Format(
                    "Spec error: function {0} redefined, ignoring second definition.",
                    d.Name));
            }
        }
    }

    #endregion
}
