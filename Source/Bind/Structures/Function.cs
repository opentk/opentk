#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Bind.Structures
{
    public class Function : Delegate, IEquatable<Function>
    {
        internal static FunctionCollection Wrappers;

        private static bool loaded;
        
        #region internal static void Initialize()
        
        internal static void Initialize()
        {
            if (!loaded)
            {
                Wrappers = new FunctionCollection();
                loaded = true;
            }
        }
        
        #endregion

        static Regex endings = new Regex(@"((([df]|u?[isb])v?)|v)", RegexOptions.Compiled | RegexOptions.RightToLeft);
        static Regex endingsNotToTrim = new Regex("(ib|[tdrey]s|[eE]n[vd]|bled|Flagv|Tess|Status|Pixels)", RegexOptions.Compiled | RegexOptions.RightToLeft);

        /// <summary>
        /// Add a trailing v to functions matching this regex. Used to differntiate between overloads taking both
        /// a 'type' and a 'ref type' (such overloads are not CLS Compliant).
        /// </summary>
        /// <remarks>
        /// The default Regex matches no functions. Create a new Regex in Bind.Generator classes to override the default behavior. 
        /// </remarks>
        internal static Regex endingsAddV = new Regex("^0", RegexOptions.Compiled);
        
        #region --- Constructors ---

        public Function()
            : base()
        {
            Body = new FunctionBody();
        }

        public Function(Delegate d)
            : base(d)
        {
            if (d is Function)
                this.Body = new FunctionBody((d as Function).Body);
            else
                this.Body = new FunctionBody();
            this.Name = d.Name;
        }

        #endregion

        public void TurnVoidPointersToIntPtr()
        {
            foreach (Parameter p in this.Parameters)
            {
                if (p.Pointer && p.CurrentType == "void")
                {
                    p.CurrentType = "IntPtr";
                    p.Pointer = false;
                }
            }
        }

        #region public override bool Unsafe

        public override bool Unsafe
        {
            get
            {
                if ((Settings.Compatibility & Settings.Legacy.NoPublicUnsafeFunctions) != Settings.Legacy.None)
                    return false;

                return base.Unsafe;
            }
        }

        #endregion

        #region public FunctionBody Body

        FunctionBody _body;

        public FunctionBody Body
        {
            get { return _body; }
            set { _body = value; }
        }

        #endregion

        #region public string TrimmedName

        public string TrimmedName;

        #endregion

        #region public override string Name

        /// <summary>
        /// Gets or sets the name of the opengl function.
        /// If no Tao compatibility is set, set TrimmedName to Name, after removing
        /// [u][bsifd][v].
        /// </summary>
        public override string Name
        {
            get { return base.Name; }
            set
            {
                base.Name = value;

                if ((Settings.Compatibility & Settings.Legacy.NoTrimFunctionEnding) != Settings.Legacy.None)
                {
                    // If we don't need compatibility with Tao,
                    // remove the Extension and the overload information from the name
                    // (Extension == "ARB", "EXT", etc, overload == [u][bsidf][v])
                    // TODO: Use some regex's here, to reduce clutter.
                    TrimmedName = value;
                }
                else
                {
                    TrimmedName = Utilities.StripGL2Extension(value);

                    //if (Name.Contains("BooleanIndexed"))
                    {
                    }
                    Match m = endingsNotToTrim.Match(TrimmedName);
                    if ((m.Index + m.Length) != TrimmedName.Length)
                    {
                        // Some endings should not be trimmed, for example: 'b' from Attrib

                        m = endings.Match(TrimmedName);

                        if (m.Length > 0 && m.Index + m.Length == TrimmedName.Length)
                        {
                            // Only trim endings, not internal matches.
                            if (m.Value[m.Length - 1] == 'v' && endingsAddV.IsMatch(Name) &&
                                !Name.StartsWith("Get") && !Name.StartsWith("MatrixIndex"))
                            {
                                // Only trim ending 'v' when there is a number
                                TrimmedName = TrimmedName.Substring(0, m.Index) + "v";
                            }
                            else
                            {
                                if (!TrimmedName.EndsWith("xedv"))
                                    TrimmedName = TrimmedName.Substring(0, m.Index);
                                else
                                    TrimmedName = TrimmedName.Substring(0, m.Index + 1);
                            }
                        }
                    }
                }
            }
        }

        #endregion

        #region public override string ToString()

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Unsafe ? "unsafe " : "");
            sb.Append(ReturnType);
            sb.Append(" ");
            if ((Settings.Compatibility & Settings.Legacy.NoTrimFunctionEnding) != Settings.Legacy.None)
            {
                sb.Append(Settings.FunctionPrefix);
            }
            sb.Append(!String.IsNullOrEmpty(TrimmedName) ? TrimmedName : Name);
            sb.Append(Parameters.ToString(false));
            if (Body.Count > 0)
            {
                sb.AppendLine();
                sb.Append(Body.ToString());
            }

            return sb.ToString();
        }

        #endregion

        #region IEquatable<Function> Members

        public bool Equals(Function other)
        {
            return
                !String.IsNullOrEmpty(this.TrimmedName) && !String.IsNullOrEmpty(other.TrimmedName) &&
                this.TrimmedName == other.TrimmedName &&
                this.Parameters.ToString(true) == other.Parameters.ToString(true);
        }

        #endregion

        #region public void WrapParameters(List<Function> wrappers)

        public void WrapParameters(List<Function> wrappers)
        {
            Function f;

            if (this.Name.Contains("TessVertex"))
            {
            }

            if (Parameters.HasPointerParameters)
            {
                // Array overloads
                foreach (Parameter p in this.Parameters)
                {
                    if (p.WrapperType == WrapperTypes.ArrayParameter)
                    {
                        p.Reference = false;
                        p.Array = 1;
                        p.Pointer = false;
                    }
                }
                f = new Function(this);
                f.CreateBody(false);
                wrappers.Add(f);
                new Function(f).WrapVoidPointers(wrappers);

                // Reference overloads
                foreach (Parameter p in this.Parameters)
                {
                    if (p.WrapperType == WrapperTypes.ArrayParameter)
                    {
                        p.Reference = true;
                        p.Array = 0;
                        p.Pointer = false;
                    }
                }
                f = new Function(this);
                f.CreateBody(false);
                wrappers.Add(f);
                new Function(f).WrapVoidPointers(wrappers);

                // Pointer overloads
                // Should be last to work around Intellisense bug, where
                // array overloads are not reported if there is a pointer overload.
                foreach (Parameter p in this.Parameters)
                {
                    if (p.WrapperType == WrapperTypes.ArrayParameter)
                    {
                        p.Reference = false;
                        p.Array = 0;
                        p.Pointer = true;
                    }
                }
                f = new Function(this);
                f.CreateBody(false);
                wrappers.Add(f);
                new Function(f).WrapVoidPointers(wrappers);
            }
            else
            {
                //wrappers.Add(DefaultWrapper(new Function(this)));
                f = new Function(this);
                f.CreateBody(false);
                wrappers.Add(f);
            }
        }

        #endregion

        #region public void WrapParametersComplete(List<Function> wrappers)

        static int index = 0;

        /// <summary>
        /// Adds to the wrapper list all possible wrapper permutations for every possible parameter combination.
        /// "void Delegates.f(IntPtr p, IntPtr q)" where p and q are pointers to void arrays needs the following wrappers:
        /// "void f(IntPtr p, IntPtr q)"
        /// "void f(IntPtr p, object q)"
        /// "void f(object p, IntPtr q)"
        /// "void f(object p, object q)"
        /// </summary>
        /// <param name="wrappers"></param>
        public void WrapParametersComplete(List<Function> wrappers)
        {
            if (index == 0)
            {
                //if (this.Parameters.HasPointerParameters)
                {
                    Function f = new Function(this);
                    f.CreateBody(false);
                    wrappers.Add(f);
                }
                //else
                //{
                //    if (this.Body.Count == 0)
                //        wrappers.Add(DefaultWrapper(this));
                //    else
                //        wrappers.Add(this);
                //    return;
                //}
            }
            
            if (index >= 0 && index < this.Parameters.Count)
            {
                Function f;

                switch (this.Parameters[index].WrapperType)
                {
                    case WrapperTypes.None:
                        // No wrapper needed, visit the next parameter
                        ++index;
                        WrapParametersComplete(wrappers);
                        --index;
                        break;

                    case WrapperTypes.ArrayParameter:
                        // Recurse to the last parameter
                        ++index;
                        WrapParametersComplete(wrappers);
                        --index;

                        // On stack rewind, create array wrappers
                        f = new Function(this);
                        f.Parameters[index].Reference = false;
                        f.Parameters[index].Array = 1;
                        f.Parameters[index].Pointer = false;
                        f.CreateBody(false);
                        wrappers.Add(f);

                        // Recurse to the last parameter again, keeping the Array wrappers
                        ++index;
                        f.WrapParametersComplete(wrappers);
                        --index;

                        // On stack rewind create reference wrappers.
                        f = new Function(this);
                        f.Parameters[index].Reference = true;
                        f.Parameters[index].Array = 0;
                        f.Parameters[index].Pointer = false;
                        f.CreateBody(false);
                        wrappers.Add(f);

                        // Keeping the current reference wrapper, revisit all other parameters.
                        ++index;
                        f.WrapParametersComplete(wrappers);
                        --index;

                        break;

                    case WrapperTypes.GenericParameter:
                        // Recurse to the last parameter
                        ++index;
                        WrapParametersComplete(wrappers);
                        --index;

                        // On stack rewind, create object wrappers
                        f = new Function(this);
                        f.Parameters[index].Reference = false;
                        f.Parameters[index].Array = 0;
                        f.Parameters[index].Pointer = false;
                        f.Parameters[index].CurrentType = "object";
                        f.Parameters[index].Flow = Parameter.FlowDirection.Undefined;

                        f.CreateBody(false);
                        wrappers.Add(f);

                        // Keeping the current Object wrapper, visit all other parameters once more
                        ++index;
                        f.WrapParametersComplete(wrappers);
                        --index;

                        break;

                    //case WrapperTypes.ReferenceParameter:
                    //    // Recurse to the last parameter
                    //    ++index;
                    //    WrapParameters(this, wrappers);
                    //    --index;

                    //    // On stack rewind, create reference wrappers
                    //    f = new this(this);
                    //    f.Parameters[index].Reference = true;
                    //    f.Parameters[index].Array = 0;
                    //    f.Parameters[index].Pointer = false;
                    //    f.Body = CreateBody(f, false);
                    //    //f = ReferenceWrapper(new this(this), index);
                    //    wrappers.Add(f);

                    //    // Keeping the current Object wrapper, visit all other parameters once more
                    //    ++index;
                    //    WrapParameters(f, wrappers);
                    //    --index;

                    //    break;
                }
            }
        }

        #endregion

        #region public void WrapVoidPointers(List<Function> wrappers)

        public void WrapVoidPointers(List<Function> wrappers)
        {
            if (this.Name.Contains("TessVertex"))
            {
            }

            if (index >= 0 && index < Parameters.Count)
            {
                if (Parameters[index].WrapperType == WrapperTypes.GenericParameter)
                {
                    // Recurse to the last parameter
                    ++index;
                    WrapVoidPointers(wrappers);
                    --index;

                    // On stack rewind, create object wrappers
                    Parameters[index].Reference = false;
                    Parameters[index].Array = 0;
                    Parameters[index].Pointer = false;
                    Parameters[index].CurrentType = "object";
                    Parameters[index].Flow = Parameter.FlowDirection.Undefined;
                    Parameters.Rebuild = true;
                    CreateBody(false);
                    wrappers.Add(this);

                    // Keeping the current Object wrapper, visit all other parameters once more
                    ++index;
                    //if ((Settings.Compatibility & Settings.Legacy.GenerateAllPermutations) == Settings.Legacy.None)
                    //    WrapParameters(wrappers);
                    //else
                    //    WrapParametersComplete(wrappers);
                    --index;
                }
                else
                {
                    // Recurse to the last parameter
                    ++index;
                    WrapVoidPointers(wrappers);
                    --index;
                }
            }
        }

        #endregion

        #region public void WrapReturnType()

        public void WrapReturnType()
        {
            switch (ReturnType.WrapperType)
            {
                case WrapperTypes.StringReturnType:
                    ReturnType.CurrentType = "string";
                    break;
            }
        }

        #endregion

        #region public void CreateBody(bool wantCLSCompliance)

        static List<string> handle_statements = new List<string>();
        static List<string> handle_release_statements = new List<string>();
        static List<string> fixed_statements = new List<string>();
        static List<string> assign_statements = new List<string>();

        public void CreateBody(bool wantCLSCompliance)
        {
            Function f = new Function(this);

            f.Body.Clear();
            handle_statements.Clear();
            handle_release_statements.Clear();
            fixed_statements.Clear();
            assign_statements.Clear();

            if (f.Name == "TessVertex")
            { 
            }

            // Obtain pointers by pinning the parameters
            foreach (Parameter p in f.Parameters)
            {
                if (p.NeedsPin)
                {
                    if (p.WrapperType == WrapperTypes.GenericParameter)
                    {
                        // Use GCHandle to obtain pointer to generic parameters and 'fixed' for arrays.
                        // This is because fixed can only take the address of fields, not managed objects.
                        handle_statements.Add(String.Format(
                            "{0} {1}_ptr = {0}.Alloc({1}, System.Runtime.InteropServices.GCHandleType.Pinned);",
                            "System.Runtime.InteropServices.GCHandle", p.Name));

                        handle_release_statements.Add(String.Format("{0}_ptr.Free();", p.Name));

                        if (p.Flow == Parameter.FlowDirection.Out)
                        {
                            assign_statements.Add(String.Format(
                                "{0} = ({1}){0}_ptr.Target;",
                                p.Name, p.CurrentType));
                        }

                        // Note! The following line modifies f.Parameters, *not* this.Parameters
                        p.Name = "(IntPtr)" + p.Name + "_ptr.AddrOfPinnedObject()";
                    }
                    else if (p.WrapperType == WrapperTypes.PointerParameter ||
                        p.WrapperType == WrapperTypes.ArrayParameter ||
                        p.WrapperType == WrapperTypes.ReferenceParameter)
                    {
                        // A fixed statement is issued for all non-generic pointers, arrays and references.
                        fixed_statements.Add(String.Format(
                            "fixed ({0}* {1} = {2})",
                            wantCLSCompliance && !p.CLSCompliant ? p.GetCLSCompliantType() : p.CurrentType,
                            p.Name + "_ptr",
                            p.Array > 0 ? p.Name : "&" + p.Name));

                        if (p.Flow == Parameter.FlowDirection.Out && p.Array == 0)  // Fixed Arrays of blittable types don't need explicit assignment.
                        {
                            assign_statements.Add(String.Format("{0} = *{0}_ptr;", p.Name));
                        }

                        p.Name = p.Name + "_ptr";
                    }
                    else
                    {
                        throw new ApplicationException("Unknown parameter type");
                    }
                }
            }

            if (!f.Unsafe || fixed_statements.Count > 0)
            {
                f.Body.Add("unsafe");
                f.Body.Add("{");
                f.Body.Indent();
            }
            
            if (fixed_statements.Count > 0)
            {
                f.Body.AddRange(fixed_statements);
                f.Body.Add("{");
                f.Body.Indent();
            }
            
            if (handle_statements.Count > 0)
            {
                f.Body.AddRange(handle_statements);
                f.Body.Add("try");
                f.Body.Add("{");
                f.Body.Indent();
            }

            if (assign_statements.Count > 0)
            {
                // Call function
                if (f.ReturnType.CurrentType.ToLower().Contains("void"))
                    f.Body.Add(String.Format("{0};", f.CallString()));
                else if (ReturnType.CurrentType.ToLower().Contains("string"))
                    f.Body.Add(String.Format("{0} {1} = System.Runtime.InteropServices.Marshal.PtrToStringAnsi({2});",
                        ReturnType.CurrentType, "retval", CallString()));
                else
                    f.Body.Add(String.Format("{0} {1} = {2};", f.ReturnType.CurrentType, "retval", f.CallString()));

                // Assign out parameters
                f.Body.AddRange(assign_statements);

                // Return
                if (!f.ReturnType.CurrentType.ToLower().Contains("void"))
                {
                    f.Body.Add("return retval;");
                }
            }
            else
            {
                // Call function and return
                if (f.ReturnType.CurrentType.ToLower().Contains("void"))
                    f.Body.Add(String.Format("{0};", f.CallString()));
                else if (ReturnType.CurrentType.ToLower().Contains("string"))
                    f.Body.Add(String.Format("return System.Runtime.InteropServices.Marshal.PtrToStringAnsi({0});",
                        CallString()));
                else
                    f.Body.Add(String.Format("return {0};", f.CallString()));
            }


            // Free all allocated GCHandles
            if (handle_statements.Count > 0)
            {
                f.Body.Unindent();
                f.Body.Add("}");
                f.Body.Add("finally");
                f.Body.Add("{");
                f.Body.Indent();

                f.Body.AddRange(handle_release_statements);

                f.Body.Unindent();
                f.Body.Add("}");
            }

            if (!f.Unsafe || fixed_statements.Count > 0)
            {
                f.Body.Unindent();
                f.Body.Add("}");
            }

            if (fixed_statements.Count > 0)
            {
                f.Body.Unindent();
                f.Body.Add("}");
            }

            this.Body = f.Body;
        }

        #endregion
    }

    #region class FunctionBody : List<string>

    public class FunctionBody : List<string>
    {
        public FunctionBody()
        {
        }

        public FunctionBody(FunctionBody fb)
        {
            foreach (string s in fb)
            {
                this.Add(s);
            }
        }

        private string indent = "";

        public void Indent()
        {
            indent += "    ";
        }

        public void Unindent()
        {
            if (indent.Length >= 4)
                indent = indent.Substring(4);
        }

        new public void Add(string s)
        {
            base.Add(indent + s);
        }

        new public void AddRange(IEnumerable<string> collection)
        {
            foreach (string t in collection)
            {
                this.Add(t);
            }
        }

        public override string ToString()
        {
            if (this.Count == 0)
                return String.Empty;

            StringBuilder sb = new StringBuilder(this.Count);

            sb.AppendLine("{");
            foreach (string s in this)
            {
                sb.AppendLine("    " + s);
            }
            sb.Append("}");

            return sb.ToString();
        }
    }

    #endregion

    #region class FunctionCollection : Dictionary<string, List<Function>>

    class FunctionCollection : Dictionary<string, List<Function>>
    {
        Regex unsignedFunctions = new Regex(@".+(u[dfisb]v?)", RegexOptions.Compiled);

        public void Add(Function f)
        {
            if (!this.ContainsKey(f.Extension))
            {
                this.Add(f.Extension, new List<Function>());
                this[f.Extension].Add(f);
            }
            else
            {
                this[f.Extension].Add(f);
            }
        }

        public void AddRange(IEnumerable<Function> functions)
        {
            foreach (Function f in functions)
            {
                this.Add(f);
            }
        }

        /// <summary>
        /// Adds the function to the collection, if a function with the same
        /// name and parameters doesn't already exist.
        /// </summary>
        /// <param name="f">The Function to add.</param>
        public void AddChecked(Function f)
        {
            if (f.Name.Contains("Bitmap"))
            {
            }

            if (Bind.Structures.Function.Wrappers.ContainsKey(f.Extension))
            {
                int index = Bind.Structures.Function.Wrappers[f.Extension].IndexOf(f);
                if (index == -1)
                {
                    Bind.Structures.Function.Wrappers.Add(f);
                }
                else
                {
                    if (unsignedFunctions.IsMatch(Utilities.StripGL2Extension(f.Name)))// &&
                        //!unsignedFunctions.IsMatch(
                        //    Utilities.StripGL2Extension(Bind.Structures.Function.Wrappers[f.Extension][index].Name)))
                    {
                        Bind.Structures.Function.Wrappers[f.Extension].RemoveAt(index);
                        Bind.Structures.Function.Wrappers[f.Extension].Add(f);
                    }
                }
            }
            else
            {
                Bind.Structures.Function.Wrappers.Add(f);
            }
        }
    }

    #endregion
}
