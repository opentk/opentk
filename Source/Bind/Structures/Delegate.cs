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
        internal static void Initialize()
        {
            if (!delegatesLoaded)
            {
                using (StreamReader sr = Utilities.OpenSpecFile(Settings.InputPath, "gl2\\gl.spec"))
                {
                    Delegates = Bind.MainClass.Generator.ReadDelegates(sr);
                }

                delegatesLoaded = true;
            }
        }

        #region --- Constructors ---

        public Delegate()
        {
            Parameters = new ParameterCollection();
        }

        public Delegate(Delegate d)
        {
            this.Category = new string(d.Category.ToCharArray());
            //this.Extension = !String.IsNullOrEmpty(d.Extension) ? new string(d.Extension.ToCharArray()) : "";
            this.Name = new string(d.Name.ToCharArray());
            //this.NeedsWrapper = d.NeedsWrapper;
            this.Parameters = new ParameterCollection(d.Parameters);
            this.ReturnType = new Type(d.ReturnType);
            this.Version = !String.IsNullOrEmpty(d.Version) ? new string(d.Version.ToCharArray()) : "";
            //this.Unsafe = d.Unsafe;
        }

        #endregion

        #region --- Properties ---

        #region public bool CLSCompliant

        /// <summary>
        ///  Gets the CLSCompliant property. True if the delegate is not CLSCompliant.
        /// </summary>
        public bool CLSCompliant
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

        bool _needs_wrapper;

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
                _return_type = Type.Translate(value);
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
                    _name = value.Trim();
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
            sb.Append(".gl");
            sb.Append(Name);
            sb.Append(Parameters.CallString());

            return sb.ToString();
        }

        #endregion

        #region public string DeclarationString()

        public string DeclarationString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Unsafe ? "unsafe " : "");
            sb.Append(ReturnType);
            sb.Append(" ");
            sb.Append(Name);
            sb.Append(Parameters.ToString());

            return sb.ToString();
        }

        #endregion

        #region override public string ToString()

        /// <summary>
        /// Gets the string representing the full function declaration without decorations
        /// (ie "void glClearColor(float red, float green, float blue, float alpha)"
        /// </summary>
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

        public IEnumerable<Function> CreateWrappers()
        {
            if (this.Name.Contains("GetString"))
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
                Function f = WrapReturnType();


                WrapParameters(new Function((Function)f ?? this), wrappers);
            }

            return wrappers;
        }

        #endregion

        #region protected Function WrapReturnType()

        protected Function WrapReturnType()
        {
            // We have to add wrappers for all possible WrapperTypes.
            Function f;

            // First, check if the return type needs wrapping:
            switch (this.ReturnType.WrapperType)
            {
                // If the function returns a string (glGetString) we must manually marshal it
                // using Marshal.PtrToStringXXX. Otherwise, the GC will try to free the memory
                // used by the string, resulting in corruption (the memory belongs to the
                // unmanaged boundary).
                case WrapperTypes.StringReturnType:
                    f = new Function(this);
                    f.ReturnType.CurrentType = "System.String";

                    f.Body.Add(
                        String.Format(
                            "return System.Runtime.InteropServices.Marshal.PtrToStringAnsi({0});",
                            this.CallString()
                        )
                    );

                    return f;         // Only occurs in glGetString, there's no need to check parameters.

                // If the function returns a void* (GenericReturnValue), we'll have to return an IntPtr.
                // The user will unfortunately need to marshal this IntPtr to a data type manually.
                case WrapperTypes.GenericReturnType:
                    ReturnType.CurrentType = "IntPtr";
                    ReturnType.Pointer = false;

                    break;

                case WrapperTypes.None:
                default:
                    // No return wrapper needed
                    break;
            }

            return null;
        }
        
        #endregion

        #region protected void WrapParameters(Function function, List<Function> wrappers)

        protected static int index = 0;

        /// <summary>
        /// This function needs some heavy refactoring. I'm ashamed I ever wrote it, but it works...
        /// What it does is this: it adds to the wrapper list all possible wrapper permutations
        /// for functions that have more than one IntPtr parameter. Example:
        /// "void Delegates.f(IntPtr p, IntPtr q)" where p and q are pointers to void arrays needs the following wrappers:
        /// "void f(IntPtr p, IntPtr q)"
        /// "void f(IntPtr p, object q)"
        /// "void f(object p, IntPtr q)"
        /// "void f(object p, object q)"
        /// </summary>
        protected void WrapParameters(Function function, List<Function> wrappers)
        {
            if (function.Name == "GetString")
            {
            }

            if (index == 0)
            {
                bool containsPointerParameters = false;
                // Check if there are any IntPtr parameters (we may have come here from a ReturnType wrapper
                // such as glGetString, which contains no IntPtr parameters)
                foreach (Parameter p in function.Parameters)
                {
                    if (p.Pointer)
                    {
                        containsPointerParameters = true;
                        break;
                    }
                }

                if (containsPointerParameters)
                {
                    wrappers.Add(DefaultWrapper(function));
                }
                else
                {
                    if (function.Body.Count == 0)
                        wrappers.Add(DefaultWrapper(function));
                    else
                        wrappers.Add(function);
                    return;
                }
            }

            if (index >= 0 && index < function.Parameters.Count)
            {
                Function f;

                if (function.Parameters[index].WrapperType == WrapperTypes.None)
                {
                    // No wrapper needed, visit the next parameter
                    ++index;
                    WrapParameters(function, wrappers);
                    --index;
                }
                else
                {
                    switch (function.Parameters[index].WrapperType)
                    {
                        case WrapperTypes.ArrayParameter:
                            // Recurse to the last parameter
                            ++index;
                            WrapParameters(function, wrappers);
                            --index;

                            // On stack rewind, create array wrappers
                            f = ArrayWrapper(new Function(function), index);
                            wrappers.Add(f);

                            // Recurse to the last parameter again, keeping the Array wrappers
                            ++index;
                            WrapParameters(f, wrappers);
                            --index;

                            // On stack rewind, create Ref wrappers.
                            f = ReferenceWrapper(new Function(function), index);
                            wrappers.Add(f);

                            // Keeping the current Ref wrapper, visit all other parameters once more
                            ++index;
                            WrapParameters(f, wrappers);
                            --index;

                            break;

                        case WrapperTypes.GenericParameter:
                            // Recurse to the last parameter
                            ++index;
                            WrapParameters(function, wrappers);
                            --index;

                            // On stack rewind, create array wrappers
                            f = GenericWrapper(new Function(function), index);
                            wrappers.Add(f);

                            // Keeping the current Object wrapper, visit all other parameters once more
                            ++index;
                            WrapParameters(f, wrappers);
                            --index;

                            break;
                    }
                }
            }
        }

        #endregion

        #region protected Function GenericWrapper(Function function, int index)

        protected Function GenericWrapper(Function function, int index)
        {
            // Search and replace IntPtr parameters with the known parameter types:
            function.Parameters[index].Reference = false;
            function.Parameters[index].Array = 0;
            function.Parameters[index].Pointer = false;
            function.Parameters[index].CurrentType = "object";
            function.Parameters[index].Flow = Parameter.FlowDirection.Undefined;

            // In the function body we should pin all objects in memory before calling the
            // low-level function.
            function.Body.Clear();
            //function.Body.AddRange(GetBodyWithFixedPins(function));
            function.Body.AddRange(function.GetBodyWithPins(false));

            return function;
        }

        #endregion

        #region protected Function ReferenceWrapper(Function function, int index)

        protected Function ReferenceWrapper(Function function, int index)
        {
            // Search and replace IntPtr parameters with the known parameter types:
            function.Parameters[index].Reference = true;
            function.Parameters[index].Array = 0;
            function.Parameters[index].Pointer = false;

            // In the function body we should pin all objects in memory before calling the
            // low-level function.
            function.Body.Clear();
            function.Body.AddRange(function.GetBodyWithPins(false));

            return function;
        }

        #endregion

        #region protected Function ArrayWrapper(Function function, int index)

        protected Function ArrayWrapper(Function function, int index)
        {
            // Search and replace IntPtr parameters with the known parameter types:
            function.Parameters[index].Array = 1;
            function.Parameters[index].Pointer = false;
            function.Parameters[index].Flow = Parameter.FlowDirection.Undefined;

            // In the function body we should pin all objects in memory before calling the
            // low-level function.
            function.Body.Clear();
            function.Body.AddRange(function.GetBodyWithPins(false));

            return function;
        }

        #endregion

        #region protected Function DefaultWrapper(Function f)

        protected Function DefaultWrapper(Function f)
        {
            bool returns = f.ReturnType.CurrentType.ToLower().Contains("void") && !f.ReturnType.Pointer;
            string callString = String.Format(
                "{0} {1}{2}; {3}",
                Unsafe ? "unsafe {" : "",
                returns ? "" : "return ",
                this.CallString(),
                Unsafe ? "}" : "");

            f.Body.Add(callString);

            return f;
        }

        #endregion

        #region protected FunctionBody GetBodyWithPins(bool wantCLSCompliance)

        /// <summary>
        /// Generates a body which calls the specified function, pinning all needed parameters.
        /// </summary>
        /// <param name="function"></param>
        protected FunctionBody GetBodyWithPins(bool wantCLSCompliance)
        {
            // We'll make changes, but we want the original intact.
            //Function function = this as Function ?? new Function(this);
            //Function f = new Function(function);
            Function f = new Function(this);
            f.Body.Clear();
            // Unsafe only if 
            //function.Unsafe = false;

            // Add default initliazers for out parameters:
            foreach (Parameter p in this.Parameters)
            {
                if (p.Flow == Parameter.FlowDirection.Out)
                {
                    f.Body.Add(
                        String.Format(
                            "{0} = default({1});",
                            p.Name,
                            p.GetFullType(Bind.Structures.Type.CSTypes, wantCLSCompliance)
                        )
                    );
                }
            }
            // All GCHandles statements will go here. This will allow to place only one opening '{'
            // on fixed statements.
            int handleStart = f.Body.Count;

            // Indicates the index where the last GCHandle statement is. Used to add an unsafe stamement
            // (if needed) at exactl that spot, i.e. after the GCHandles but before the fixed statements.
            int handleEnd = f.Body.Count;

            // True if at least on GCHandle is allocated. Used to remove the try { } finally { }
            // block if no handle has been allocated.
            bool handleAllocated = false;

            // True if function body contains at least one fixed statement. Add a statement-level
            // unsafe block if true (and the function is not unsafe at the function-level).
            bool fixedAllocated = false;

            // Obtain pointers by pinning the parameters
            foreach (Parameter p in f.Parameters)
            {
                if (p.NeedsPin)
                {
                    // Use GCHandle to obtain pointer to generic parameters and 'fixed' for arrays.
                    // This is because fixed can only take the address of fields, not managed objects.
                    if (p.WrapperType == WrapperTypes.GenericParameter)
                    {
                        f.Body.Insert(
                            handleStart,
                            String.Format(
                                "{0} {1} = {0}.Alloc({2}, System.Runtime.InteropServices.GCHandleType.Pinned);",
                                "System.Runtime.InteropServices.GCHandle",
                                p.Name + "_ptr",
                                p.Name
                            )
                        );
                        // Note! The following line modifies f.Parameters, *not* function.Parameters
                        p.Name = "(void*)" + p.Name + "_ptr.AddrOfPinnedObject()";

                        handleAllocated = true;

                        handleEnd++;
                    }
                    else
                    {
                        f.Body.Add(
                            String.Format(
                                "    fixed ({0}* {1} = {2})",
                                wantCLSCompliance && !p.CLSCompliant ?
                                    p.GetCLSCompliantType() :
                                    p.CurrentType,
                                p.Name + "_ptr",
                                p.Array > 0 ? p.Name : "&" + p.Name
                            )
                        );
                        p.Name = p.Name + "_ptr";

                        fixedAllocated = true;
                    }
                }
            }

            if (!this.Unsafe)
            {
                f.Body.Insert(handleEnd, "unsafe");
                f.Body.Insert(handleEnd + 1, "{");
            }

            if (handleAllocated)
            {
                f.Body.Add("    try");
            }

            f.Body.Add("    {");
            // Add delegate call:
            if (f.ReturnType.CurrentType.ToLower().Contains("void"))
                f.Body.Add(String.Format("        {0};", f.CallString()));
            else
                f.Body.Add(String.Format("        {0} {1} = {2};", f.ReturnType.CurrentType, "retval", f.CallString()));

            // Assign out parameters:
            foreach (Parameter p in this.Parameters)
            {
                if (p.Flow == Parameter.FlowDirection.Out)
                {
                    // Check each out parameter. If it has been pinned, get the Target of the GCHandle.
                    // Otherwise, nothing needs be done.
                    if (p.NeedsPin)
                    {
                        if (p.WrapperType == WrapperTypes.GenericParameter)
                        {
                            f.Body.Add(
                                String.Format(
                                    "        {0} = ({1}){2}.Target;",
                                    p.Name,
                                    p.CurrentType,
                                    p.Name + "_ptr"
                                )
                            );
                        }
                        else
                        {
                            f.Body.Add(
                                String.Format(
                                    "        {0} = *{0}_ptr;",
                                    p.Name
                                )
                            );
                        }
                    }
                }
            }

            // Return:
            if (!f.ReturnType.CurrentType.ToLower().Contains("void"))
            {
                f.Body.Add("        return retval;");
            }

            if (handleAllocated)
            {
                f.Body.Add("    }");
                f.Body.Add("    finally");
                f.Body.Add("    {");
                foreach (Parameter p in this.Parameters)
                {
                    // Free all allocated GCHandles
                    if (p.NeedsPin)
                    {
                        if (p.WrapperType == WrapperTypes.GenericParameter)
                            f.Body.Add(String.Format("        {0}_ptr.Free();", p.Name));
                        //else
                        //    f.Body.Add("}");
                    }
                }
            }
            f.Body.Add("    }");

            if (!this.Unsafe)
            {
                f.Body.Add("}");
            }

            return f.Body;
        }

        #endregion

        #endregion

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
        protected virtual void TranslateReturnType()
        {
            if (Bind.Structures.Type.GLTypes.ContainsKey(ReturnType.CurrentType))
                ReturnType.CurrentType = Bind.Structures.Type.GLTypes[ReturnType.CurrentType];

            if (Bind.Structures.Type.CSTypes.ContainsKey(ReturnType.CurrentType))
                ReturnType.CurrentType = Bind.Structures.Type.CSTypes[ReturnType.CurrentType];

            if (ReturnType.CurrentType.ToLower().Contains("void") && ReturnType.Pointer)
            {
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
                if (Settings.Compatibility == Settings.Legacy.None)
                    ReturnType.CurrentType = ReturnType.CurrentType.Insert(0, Settings.GLEnumsClass + ".");
                else
                    ReturnType.CurrentType = "int";
            }

            if (ReturnType.CurrentType.ToLower().Contains("bool"))
            {
                if (Settings.Compatibility == Settings.Legacy.Tao)
                    ReturnType.CurrentType = "int";
                else
                {
                }

                //ReturnType.WrapperType = WrapperTypes.ReturnsBool;
            }

            ReturnType.CurrentType = ReturnType.GetCLSCompliantType();
        }

        protected virtual void TranslateParameters()
        {
            if (this.Name.Contains("MultiTexCoord1"))
            {
            }
            for (int i = 0; i < Parameters.Count; i++)
            {
                Parameters[i] = Parameter.Translate(Parameters[i], this.Category);

                // Special cases: glLineStipple and gl(Get)ShaderSource:
                // Check for LineStipple (should be unchecked)
                if (Parameters[i].CurrentType == "UInt16" && Name.Contains("LineStipple"))
                {
                    Parameters[i].WrapperType = WrapperTypes.UncheckedParameter;
                }

                if (Name.Contains("ShaderSource") && Parameters[i].CurrentType.ToLower().Contains("string"))
                {
                    // Special case: these functions take a string[]
                    //IsPointer = true;
                    Parameters[i].Array = 1;
                }
            }
        }

        internal void Translate()
        {
            TranslateReturnType();
            TranslateParameters();

            List<Function> wrappers = (List<Function>)CreateWrappers();

            // If the function is not CLS-compliant (e.g. it contains unsigned parameters)
            // we need to create a CLS-Compliant overload. However, we should only do this
            // iff the opengl function does not contain unsigned/signed overloads itself
            // to avoid redefinitions.
            foreach (Function f in wrappers)
            {
                if (this.Name.Contains("Weightub"))
                {
                }

                bool createCLS = !f.CLSCompliant;
                //createCLS &= String.IsNullOrEmpty(f.TrimmedName);
                string nameWithoutExtension = Utilities.StripGL2Extension(f.Name).TrimEnd('v');
                createCLS &=
                    String.IsNullOrEmpty(f.TrimmedName) ||
                    nameWithoutExtension.EndsWith("u") &&
                    !nameWithoutExtension.EndsWith("b");

                if (createCLS)
                {
                    Function clsFunction = f.GetCLSCompliantFunction(Bind.Structures.Type.CSTypes);
                    // avoid redefinitions
                    if (clsFunction.Parameters.ToString(true) != f.Parameters.ToString(true))
                    {
                        bool defined = false;
                        if (Bind.Structures.Function.Wrappers.ContainsKey(f.Extension))
                        {
                            foreach (Function fun in Bind.Structures.Function.Wrappers[clsFunction.Extension])
                            {
                                if (clsFunction.Name == fun.Name &&
                                    clsFunction.Parameters.ToString() == fun.Parameters.ToString())
                                    defined = true;
                            }
                        }

                        if (!defined)
                            Bind.Structures.Function.Wrappers.Add(clsFunction);
                        //wrappers.Add(f);
                    }
                }
                Bind.Structures.Function.Wrappers.Add(f);
            }
        }
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
