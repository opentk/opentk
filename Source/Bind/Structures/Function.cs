#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Bind.Structures
{
    public class Function : Delegate, IEquatable<Function>, IComparable<Function>
    {
        #region Static Members

        internal static FunctionCollection Wrappers;

        static bool loaded;
        
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

        #endregion

        #region Fields

        Delegate wrapped_delegate;
        int index;

        #endregion
        
        #region --- Constructors ---

        public Function(Delegate d)
            : base(d)
        {
            Name = d.Name;
            Body = new FunctionBody();
            WrappedDelegate = d;
        }

        public Function(Function f)
            : this(f.WrappedDelegate)
        {
            Parameters = new ParameterCollection(f.Parameters);
            ReturnType = new Type(f.ReturnType);
            Body.AddRange(f.Body);
        }

        #endregion

        #region public Delegate WrappedDelegate

        public Delegate WrappedDelegate
        {
            get { return wrapped_delegate; }
            set { wrapped_delegate = value; }
        }

        #endregion

        #region public void TurnVoidPointersToIntPtr()

        public void TurnVoidPointersToIntPtr()
        {
            foreach (Parameter p in Parameters)
            {
                if (p.Pointer != 0 && p.CurrentType == "void")
                {
                    p.CurrentType = "IntPtr";
                    p.Pointer = 0;
                }
            }
        }

        #endregion

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
            
            if (Parameters.HasGenericParameters)
            {
                sb.Append("<");
                foreach (Parameter p in Parameters)
                {
                    if (p.Generic)
                    {
                        sb.Append(p.CurrentType);
                        sb.Append(",");
                    }
                }
                sb.Remove(sb.Length - 1, 1);
                sb.Append(">");
            }
            sb.AppendLine(Parameters.ToString(false));
            if (Parameters.HasGenericParameters)
            {
                foreach (Parameter p in Parameters)
                {
                    if (p.Generic)
                        sb.AppendLine(String.Format("    where {0} : struct", p.CurrentType));
                }
                
            }

            if (Body.Count > 0)
            {
                sb.Append(Body.ToString());
            }

            return sb.ToString();
        }

        #endregion

        #region IEquatable<Function> Members

        public bool Equals(Function other)
        {
            return
                !String.IsNullOrEmpty(TrimmedName) && !String.IsNullOrEmpty(other.TrimmedName) &&
                TrimmedName == other.TrimmedName &&
                Parameters.ToString(true) == other.Parameters.ToString(true);
        }

        #endregion

        #region public void WrapParameters(List<Function> wrappers)

        public void WrapParameters(List<Function> wrappers)
        {
            Function f;

            if (Parameters.HasPointerParameters)
            {
                Function _this = new Function(this);
                // Array overloads
                foreach (Parameter p in _this.Parameters)
                {
                    if (p.WrapperType == WrapperTypes.ArrayParameter && p.ElementCount != 1)
                    {
                        p.Reference = false;
                        p.Array++;
                        p.Pointer--;
                    }
                }
                f = new Function(_this);
                f.CreateBody(false);
                wrappers.Add(f);
                new Function(f).WrapVoidPointers(wrappers);

                _this = new Function(this);
                // Reference overloads
                foreach (Parameter p in _this.Parameters)
                {
                    if (p.WrapperType == WrapperTypes.ArrayParameter)
                    {
                        p.Reference = true;
                        p.Array--;
                        p.Pointer--;
                    }
                }
                f = new Function(_this);
                f.CreateBody(false);
                wrappers.Add(f);
                new Function(f).WrapVoidPointers(wrappers);

                _this = this;
                // Pointer overloads
                // Should be last to work around Intellisense bug, where
                // array overloads are not reported if there is a pointer overload.
                foreach (Parameter p in _this.Parameters)
                {
                    if (p.WrapperType == WrapperTypes.ArrayParameter)
                    {
                        p.Reference = false;
                        //p.Array--;
                        //p.Pointer++;
                    }
                }
                f = new Function(_this);
                f.CreateBody(false);
                wrappers.Add(f);
                new Function(f).WrapVoidPointers(wrappers);
            }
            else
            {
                f = new Function(this);
                f.CreateBody(false);
                wrappers.Add(f);
            }
        }

        #endregion

        #region public void WrapVoidPointers(List<Function> wrappers)

        public void WrapVoidPointers(List<Function> wrappers)
        {
            if (index >= 0 && index < Parameters.Count)
            {
                if (Parameters[index].WrapperType == WrapperTypes.GenericParameter)
                {
                    // Recurse to the last parameter
                    ++index;
                    WrapVoidPointers(wrappers);
                    --index;

                    // On stack rewind, create generic wrappers
                    Parameters[index].Reference = true;
                    Parameters[index].Array = 0;
                    Parameters[index].Pointer = 0;
                    Parameters[index].Generic = true;
                    Parameters[index].CurrentType = "T" + index.ToString();
                    Parameters[index].Flow = FlowDirection.Undefined;
                    Parameters.Rebuild = true;
                    CreateBody(false);
                    wrappers.Add(new Function(this));

                    Parameters[index].Reference = false;
                    Parameters[index].Array = 1;
                    Parameters[index].Pointer = 0;
                    Parameters[index].Generic = true;
                    Parameters[index].CurrentType = "T" + index.ToString();
                    Parameters[index].Flow = FlowDirection.Undefined;
                    Parameters.Rebuild = true;
                    CreateBody(false);
                    wrappers.Add(new Function(this));

                    Parameters[index].Reference = false;
                    Parameters[index].Array = 2;
                    Parameters[index].Pointer = 0;
                    Parameters[index].Generic = true;
                    Parameters[index].CurrentType = "T" + index.ToString();
                    Parameters[index].Flow = FlowDirection.Undefined;
                    Parameters.Rebuild = true;
                    CreateBody(false);
                    wrappers.Add(new Function(this));

                    Parameters[index].Reference = false;
                    Parameters[index].Array = 3;
                    Parameters[index].Pointer = 0;
                    Parameters[index].Generic = true;
                    Parameters[index].CurrentType = "T" + index.ToString();
                    Parameters[index].Flow = FlowDirection.Undefined;
                    Parameters.Rebuild = true;
                    CreateBody(false);
                    wrappers.Add(new Function(this));
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
                    ReturnType.QualifiedType = "String";
                    break;
            }
        }

        #endregion

        #region public void CreateBody(bool wantCLSCompliance)

        readonly static List<string> handle_statements = new List<string>();
        readonly static List<string> handle_release_statements = new List<string>();
        readonly static List<string> fixed_statements = new List<string>();
        readonly static List<string> assign_statements = new List<string>();

        // For example, if parameter foo has indirection level = 1, then it
        // is consumed as 'foo*' in the fixed_statements and the call string.
        string[] indirection_levels = new string[] { "", "*", "**", "***", "****" };

        public void CreateBody(bool wantCLSCompliance)
        {
            Function f = new Function(this);

            f.Body.Clear();
            handle_statements.Clear();
            handle_release_statements.Clear();
            fixed_statements.Clear();
            assign_statements.Clear();

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
                            "{0} {1}_ptr = {0}.Alloc({1}, GCHandleType.Pinned);",
                            "GCHandle", p.Name));

                        handle_release_statements.Add(String.Format("{0}_ptr.Free();", p.Name));

                        // Due to the GCHandle-style pinning (which boxes value types), we need to assign the modified
                        // value back to the reference parameter (but only if it has an out or in/out flow direction).
                        if ((p.Flow == FlowDirection.Out || p.Flow == FlowDirection.Undefined) && p.Reference)
                        {
                            assign_statements.Add(String.Format(
                                "{0} = ({1}){0}_ptr.Target;",
                                p.Name, p.QualifiedType));
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
                            "fixed ({0}{3} {1} = {2})",
                            wantCLSCompliance && !p.CLSCompliant ? p.GetCLSCompliantType() : p.QualifiedType,
                            p.Name + "_ptr",
                            p.Array > 0 ? p.Name : "&" + p.Name,
                            indirection_levels[p.IndirectionLevel]));

                        if (p.Name == "pixels_ptr")
                            System.Diagnostics.Debugger.Break();

                        // Arrays are not value types, so we don't need to do anything for them.
                        // Pointers are passed directly by value, so we don't need to assign them back either (they don't change).
                        if ((p.Flow == FlowDirection.Out || p.Flow == FlowDirection.Undefined) && p.Reference)
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

            // Automatic OpenGL error checking.
            // See OpenTK.Graphics.ErrorHelper for more information.
            // Make sure that no error checking is added to the GetError function,
            // as that would cause infinite recursion!
            if ((Settings.Compatibility & Settings.Legacy.NoDebugHelpers) == 0)
            {
                if (f.TrimmedName != "GetError")
                {
                    f.Body.Add("#if DEBUG");
                    f.Body.Add("using (new ErrorHelper(GraphicsContext.CurrentContext))");
                    f.Body.Add("{");
                    if (f.TrimmedName == "Begin")
                        f.Body.Add("GraphicsContext.CurrentContext.ErrorChecking = false;");
                    f.Body.Add("#endif");
                }
            }

            if (!f.Unsafe && fixed_statements.Count > 0)
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

            // Hack: When creating untyped enum wrappers, it is possible that the wrapper uses an "All"
            // enum, while the delegate uses a specific enum (e.g. "TextureUnit"). For this reason, we need
            // to modify the parameters before generating the call string.
            // Note: We cannot generate a callstring using WrappedDelegate directly, as its parameters will
            // typically be different than the parameters of the wrapper. We need to modify the parameters
            // of the wrapper directly.
            if ((Settings.Compatibility & Settings.Legacy.KeepUntypedEnums) != 0)
            {
                int parameter_index = -1; // Used for comparing wrapper parameters with delegate parameters
                foreach (Parameter p in f.Parameters)
                {
                    parameter_index++;
                    if (p.IsEnum && p.QualifiedType != f.WrappedDelegate.Parameters[parameter_index].QualifiedType)
                    {
                        p.QualifiedType = f.WrappedDelegate.Parameters[parameter_index].QualifiedType;
                    }
                }
            }

            if (assign_statements.Count > 0)
            {
                // Call function
                string method_call = f.CallString();
                if (f.ReturnType.CurrentType.ToLower().Contains("void"))
                    f.Body.Add(String.Format("{0};", method_call));
                else if (ReturnType.CurrentType.ToLower().Contains("string"))
                    f.Body.Add(String.Format("{0} {1} = null; unsafe {{ {1} = new string((sbyte*){2}); }}",
                        ReturnType.QualifiedType, "retval", method_call));
                else
                    f.Body.Add(String.Format("{0} {1} = {2};", f.ReturnType.QualifiedType, "retval", method_call));

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
                    f.Body.Add(String.Format("unsafe {{ return new string((sbyte*){0}); }}",
                        f.CallString()));
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

            if (!f.Unsafe && fixed_statements.Count > 0)
            {
                f.Body.Unindent();
                f.Body.Add("}");
            }

            if (fixed_statements.Count > 0)
            {
                f.Body.Unindent();
                f.Body.Add("}");
            }

            if ((Settings.Compatibility & Settings.Legacy.NoDebugHelpers) == 0)
            {
                if (f.TrimmedName != "GetError")
                {
                    f.Body.Add("#if DEBUG");
                    if (f.TrimmedName == "End")
                        f.Body.Add("GraphicsContext.CurrentContext.ErrorChecking = true;");
                    f.Body.Add("}");
                    f.Body.Add("#endif");
                }
            }

            Body = f.Body;
        }

        #endregion

        #region IComparable<Function> Members

        public int CompareTo(Function other)
        {
            int ret = Name.CompareTo(other.Name);
            if (ret == 0)
                ret = Parameters.CompareTo(other.Parameters);
            if (ret == 0)
                ret = ReturnType.CompareTo(other.ReturnType);
            return ret;
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
                Add(s);
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
                Add(t);
            }
        }

        public override string ToString()
        {
            if (Count == 0)
                return String.Empty;

            StringBuilder sb = new StringBuilder(Count);

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

    #region class FunctionCollection : SortedDictionary<string, List<Function>>

    class FunctionCollection : SortedDictionary<string, List<Function>>
    {
        Regex unsignedFunctions = new Regex(@".+(u[dfisb]v?)", RegexOptions.Compiled);

        public void Add(Function f)
        {
            if (!ContainsKey(f.Extension))
            {
                Add(f.Extension, new List<Function>());
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
                Add(f);
            }
        }

        /// <summary>
        /// Adds the function to the collection, if a function with the same name and parameters doesn't already exist.
        /// </summary>
        /// <param name="f">The Function to add.</param>
        public void AddChecked(Function f)
        {
            if (Function.Wrappers.ContainsKey(f.Extension))
            {
                int index = Function.Wrappers[f.Extension].IndexOf(f);
                if (index == -1)
                {
                    Function.Wrappers.Add(f);
                }
                else
                {
                    Function existing = Function.Wrappers[f.Extension][index];
                    if ((existing.Parameters.HasUnsignedParameters && !unsignedFunctions.IsMatch(existing.Name) && unsignedFunctions.IsMatch(f.Name)) ||
                        (!existing.Parameters.HasUnsignedParameters && unsignedFunctions.IsMatch(existing.Name) && !unsignedFunctions.IsMatch(f.Name)))
                    {
                        Function.Wrappers[f.Extension].RemoveAt(index);
                        Function.Wrappers[f.Extension].Add(f);
                    }
                }
            }
            else
            {
                Function.Wrappers.Add(f);
            }
        }
    }

    #endregion
}
