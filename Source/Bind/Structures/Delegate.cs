#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;

namespace Bind.Structures
{
    /// <summary>
    /// Represents an opengl function.
    /// The return value, function name, function parameters and opengl version can be retrieved or set.
    /// </summary>
    public class Delegate
    {
        internal static DelegateCollection Delegates;

        private static bool delegatesLoaded;
        bool? cls_compliance_overriden;
        
        #region internal static void Initialize(string glSpec, string glSpecExt)
        
        internal static void Initialize(string glSpec, string glSpecExt)
        {
            if (!delegatesLoaded)
            {
                using (StreamReader sr = Utilities.OpenSpecFile(Settings.InputPath, glSpec))
                {
                    Delegates = Bind.MainClass.Generator.ReadDelegates(sr);
                }

                if (!String.IsNullOrEmpty(glSpecExt))
                {
                    using (StreamReader sr = Utilities.OpenSpecFile(Settings.InputPath, glSpecExt))
                    {
                        foreach (Delegate d in Bind.MainClass.Generator.ReadDelegates(sr).Values)
                        {
                            Utilities.Merge(Delegates, d);
                        }
                    }
                }
                Console.WriteLine("Marking CLS compliance for wrappers.");
                MarkCLSCompliance(Function.Wrappers);
                delegatesLoaded = true;
            }
        }

        #endregion
        
        #region --- Constructors ---

        public Delegate()
        {
            Parameters = new ParameterCollection();
        }

        public Delegate(Delegate d)
        {
            this.Category = d.Category;
            this.Name = d.Name;
            this.Parameters = new ParameterCollection(d.Parameters);
            this.ReturnType = new Type(d.ReturnType);
            this.Version = d.Version;
            //this.Version = !String.IsNullOrEmpty(d.Version) ? new string(d.Version.ToCharArray()) : "";
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
            set { _category = Enum.TranslateName(value); }
        }

        #endregion

        #region public bool NeedsWrapper

        /// <summary>
        /// Indicates whether this function needs to be wrapped with a Marshaling function.
        /// This flag is set if a function contains an Array parameter, or returns
        /// an Array or string.
        /// </summary>
        public bool NeedsWrapper
        {
            //get { return _needs_wrapper; }
            //set { _needs_wrapper = value; }

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

                if (ReturnType.Pointer)
                    return true;

                foreach (Parameter p in Parameters)
                {
                    if (p.Pointer)
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
            protected set { _parameters = value; }
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
            //get { return _extension; }
            //set { _extension = value; }
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

        #endregion

        #region --- Strings ---

        #region public string CallString()

        public string CallString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Settings.DelegatesClass);
            sb.Append(".");
            sb.Append(Settings.FunctionPrefix);
            sb.Append(Name);
            sb.Append(Parameters.CallString());

            return sb.ToString();
        }

        #endregion

        /// <summary>
        /// Returns a string representing the full non-delegate declaration without decorations.
        /// (ie "(unsafe) void glXxxYyy(int a, float b, IntPtr c)"
        /// </summary>
        #region public string DeclarationString()

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

        #endregion

        #region override public string ToString()

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

        #endregion

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

        #endregion

        #region --- Wrapper Creation ---

        #region MarkCLSCompliance

        static void MarkCLSCompliance(FunctionCollection collection)
        {
            foreach (List<Function> wrappers in Function.Wrappers.Values)
            {
            restart:
                for (int i = 0; i < wrappers.Count; i++)
                {
                    for (int j = i + 1; j < wrappers.Count; j++)
                    {
                        if (wrappers[i].TrimmedName == wrappers[j].TrimmedName && wrappers[i].Parameters.Count == wrappers[j].Parameters.Count)
                        {
                            bool function_i_is_problematic = false;
                            bool function_j_is_problematic = false;

                            int k;
                            for (k = 0; k < wrappers[i].Parameters.Count; k++)
                            {
                                if (wrappers[i].Parameters[k].CurrentType != wrappers[j].Parameters[k].CurrentType)
                                    break;

                                if (wrappers[i].Parameters[k].DiffersOnlyOnReference(wrappers[j].Parameters[k]))
                                    if (wrappers[i].Parameters[k].Reference)
                                        function_i_is_problematic = true;
                                    else
                                        function_j_is_problematic = true;
                            }

                            if (k == wrappers[i].Parameters.Count)
                            {
                                if (function_i_is_problematic)
                                    wrappers.RemoveAt(i);
                                //wrappers[i].CLSCompliant = false;
                                if (function_j_is_problematic)
                                    wrappers.RemoveAt(j);
                                //wrappers[j].CLSCompliant = false;

                                if (function_i_is_problematic || function_j_is_problematic)
                                    goto restart;
                            }
                        }
                    }
                }
            }
        }

        #endregion

        #region CreateWrappers

        void CreateWrappers()
        {
            List<Function> wrappers = new List<Function>();
            if (!NeedsWrapper)
            {
                // No special wrapper needed - just call this delegate:
                Function f = new Function(this);
                f.CreateBody(false);

                wrappers.Add(f);
            }
            else
            {
                Function f = new Function(this);
                f.WrapReturnType();
                f.WrapParameters(wrappers);
            }

            // If the function is not CLS-compliant (e.g. it contains unsigned parameters)
            // we need to create a CLS-Compliant overload. However, we should only do this
            // iff the opengl function does not contain unsigned/signed overloads itself
            // to avoid redefinitions.
            foreach (Function f in wrappers)
            {
                Bind.Structures.Function.Wrappers.AddChecked(f);

                if (!f.CLSCompliant)
                {
                    Function cls = new Function(f);

                    cls.Body.Clear();
                    cls.CreateBody(true);

                    bool somethingChanged = false;
                    for (int i = 0; i < f.Parameters.Count; i++)
                    {
                        cls.Parameters[i].CurrentType = cls.Parameters[i].GetCLSCompliantType();
                        if (cls.Parameters[i].CurrentType != f.Parameters[i].CurrentType)
                            somethingChanged = true;
                    }

                    if (somethingChanged)
                        Bind.Structures.Function.Wrappers.AddChecked(cls);
                }
            }
        }

        #endregion

        #region void TranslateReturnType()

        /// <summary>
        /// Translates the opengl return type to the equivalent C# type.
        /// </summary>
        /// <param name="d">The opengl function to translate.</param>
        /// <remarks>
        /// First, we use the official typemap (gl.tm) to get the correct type.
        /// Then we override this, when it is:
        /// 1) A string (we have to use Marshal.PtrToStringAnsi, to avoid heap corruption)
        /// 2) An array (translates to IntPtr)
        /// 3) A generic object or void* (translates to IntPtr)
        /// 4) A GLenum (translates to int on Legacy.Tao or GL.Enums.GLenum otherwise).
        /// Return types must always be CLS-compliant, because .Net does not support overloading on return types.
        /// </remarks>
        void TranslateReturnType()
        {
            /*
            if (Bind.Structures.Type.GLTypes.ContainsKey(ReturnType.CurrentType))
                ReturnType.CurrentType = Bind.Structures.Type.GLTypes[ReturnType.CurrentType];

            if (Bind.Structures.Type.CSTypes.ContainsKey(ReturnType.CurrentType))
                ReturnType.CurrentType = Bind.Structures.Type.CSTypes[ReturnType.CurrentType];
            */

            ReturnType.Translate(this.Category);

            if (ReturnType.CurrentType.ToLower().Contains("void") && ReturnType.Pointer)
            {
                ReturnType.CurrentType = "IntPtr";
                ReturnType.WrapperType = WrapperTypes.GenericReturnType;
            }

            if (ReturnType.CurrentType.ToLower().Contains("string"))
            {
                ReturnType.CurrentType = "IntPtr";
                ReturnType.WrapperType = WrapperTypes.StringReturnType;
            }

            if (ReturnType.CurrentType.ToLower().Contains("object"))
            {
                ReturnType.CurrentType = "IntPtr";
                ReturnType.WrapperType |= WrapperTypes.GenericReturnType;
            }

            if (ReturnType.CurrentType.Contains("GLenum"))
            {
                if ((Settings.Compatibility & Settings.Legacy.ConstIntEnums) == Settings.Legacy.None)
                    ReturnType.CurrentType = String.Format("{0}.{1}", Settings.EnumsOutput, Settings.CompleteEnumName);
                else
                    ReturnType.CurrentType = "int";
            }

            ReturnType.CurrentType = ReturnType.GetCLSCompliantType();
        }

        #endregion

        #region protected virtual void TranslateParameters()

        protected virtual void TranslateParameters()
        {
            // Iterates through all parameters, calling the Parameter.Translate() function.

            for (int i = 0; i < Parameters.Count; i++)
            {
                Parameters[i].Translate(this.Category);

                if (Parameters[i].CurrentType == "UInt16" && Name.Contains("LineStipple"))
                    Parameters[i].WrapperType = WrapperTypes.UncheckedParameter;

                // Special case: these functions take a string[]
                if (Name.Contains("ShaderSource") && Parameters[i].CurrentType.ToLower().Contains("string"))
                    Parameters[i].Array = 1;
            }
        }

        #endregion

        internal void Translate()
        {
            TranslateReturnType();
            TranslateParameters();

            CreateWrappers();
        }

        #endregion
    }

    #region class DelegateCollection : Dictionary<string, Delegate>

    class DelegateCollection : Dictionary<string, Delegate>
    {
        public void Add(Delegate d)
        {
            if (!this.ContainsKey(d.Name))
            {
                this.Add(d.Name, d);
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
