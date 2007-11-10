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

        #region public IEnumerable<Function> CreateWrappers()

        public void CreateWrappers()
        {
            if (this.Name.Contains("ReadPixels"))
            {
            }

            List<Function> wrappers = new List<Function>();
            if (!NeedsWrapper)
            {
                // No special wrapper needed - just call this delegate:
                Function f = new Function(this);

                if (f.ReturnType.CurrentType.ToLower().Contains("void"))
                    f.Body.Add(String.Format("{0};", f.CallString()));
                else
                    f.Body.Add(String.Format("return {0};", f.CallString()));

                wrappers.Add(f);
            }
            else
            {
                Function f = new Function(this);
                f.WrapReturnType();
                if ((Settings.Compatibility & Settings.Legacy.GenerateAllPermutations) == Settings.Legacy.None)
                    f.WrapParameters(wrappers);
                else
                    f.WrapParametersComplete(wrappers);
            }

            // If the function is not CLS-compliant (e.g. it contains unsigned parameters)
            // we need to create a CLS-Compliant overload. However, we should only do this
            // iff the opengl function does not contain unsigned/signed overloads itself
            // to avoid redefinitions.
            foreach (Function f in wrappers)
            {
                Bind.Structures.Function.Wrappers.AddChecked(f);
                //Bind.Structures.Function.Wrappers.Add(f);

                if (!f.CLSCompliant)
                {
                    Function cls = new Function(f);

                    cls.Body.Clear();
                    if (!cls.NeedsWrapper)
                    {
                        cls.Body.Add((f.ReturnType.CurrentType != "void" ? "return " + this.CallString() : this.CallString()) + ";");
                    }
                    else
                    {
                        cls.CreateBody(true);
                        //cls.Body.AddRange(this.CreateBody(cls, true));
                    }

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

            if (ReturnType.CurrentType.ToLower().Contains("bool"))
            {
                // TODO: Is the translation to 'int' needed 100%? It breaks WGL.
                /*
                if (Settings.Compatibility == Settings.Legacy.Tao)
                {
                    ReturnType.CurrentType = "int";
                }
                else
                {
                }
                */

                //ReturnType.WrapperType = WrapperTypes.ReturnsBool;
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
            if (Name.Contains("GetError"))
            {
            }
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
