#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2010 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.XPath;
using Bind.Structures;
using Delegate = Bind.Structures.Delegate;

namespace Bind
{
    class FuncProcessor
    {
        const string Path = "/signatures/replace/function[@name='{0}' and @extension='{1}']";
        static readonly Regex Endings =
            new Regex(@"((((d|f|fi)|(L?(u?i?64)?u?[isb]))_?(64)?v?)|v)", RegexOptions.Compiled | RegexOptions.RightToLeft);
        static readonly Regex EndingsNotToTrim =
            new Regex("(ib|[tdrey]s|[eE]n[vd]|bled|Attrib|Access|Coord|Flag|Tess|Status|Pixels|Instanced|Indexed|Varyings|Boolean|IDs|Uniforms)", RegexOptions.Compiled | RegexOptions.RightToLeft);
        static readonly Regex EndingsAddV = new Regex("^0", RegexOptions.Compiled);

        string Overrides { get; set; }

        public FuncProcessor(string overrides)
        {
            if (overrides == null)
                throw new ArgumentNullException("overrides");

            Overrides = overrides;
        }

        public FunctionCollection Process(DelegateCollection delegates, EnumCollection enums)
        {
            Console.WriteLine("Processing delegates.");
            var nav = new XPathDocument(Overrides).CreateNavigator();
            foreach (var d in delegates.Values)
            {
                TranslateReturnType(nav, d, enums);
                TranslateParameters(nav, d, enums);
            }

            Console.WriteLine("Generating wrappers.");
            var wrappers = CreateWrappers(delegates, enums);
            Console.WriteLine("Creating CLS compliant overloads.");
            wrappers = CreateCLSCompliantWrappers(wrappers, enums);
            Console.WriteLine("Removing non-CLS compliant duplicates.");

            return MarkCLSCompliance(wrappers);
        }

        // Trims unecessary suffices from the specified OpenGL function name.
        public static string TrimName(string name, bool keep_extension)
        {
            string trimmed_name = Utilities.StripGL2Extension(name);
            string extension = Utilities.GetGL2Extension(name);

            // Note: some endings should not be trimmed, for example: 'b' from Attrib.
            // Check the endingsNotToTrim regex for details.
            Match m = EndingsNotToTrim.Match(trimmed_name);
            if ((m.Index + m.Length) != trimmed_name.Length)
            {
                m = Endings.Match(trimmed_name);

                if (m.Length > 0 && m.Index + m.Length == trimmed_name.Length)
                {
                    // Only trim endings, not internal matches.
                    if (m.Value[m.Length - 1] == 'v' && EndingsAddV.IsMatch(name) &&
                        !name.StartsWith("Get") && !name.StartsWith("MatrixIndex"))
                    {
                        // Only trim ending 'v' when there is a number
                        trimmed_name = trimmed_name.Substring(0, m.Index) + "v";
                    }
                    else
                    {
                        if (!trimmed_name.EndsWith("xedv"))
                        {
                            trimmed_name = trimmed_name.Substring(0, m.Index);
                        }
                        else
                        {
                            trimmed_name = trimmed_name.Substring(0, m.Index + 1);
                        }
                    }
                }
            }

            return trimmed_name;
        }

        static XPathNavigator GetFuncOverride(XPathNavigator nav, Delegate d)
        {
            string name = TrimName(d.Name, false);
            string ext = d.Extension;

            var function_override =
                nav.SelectSingleNode(String.Format(Path, name, ext)) ??
                nav.SelectSingleNode(String.Format(Path, d.Name, ext)) ??
                nav.SelectSingleNode(String.Format(Path, Utilities.StripGL2Extension(d.Name), ext));
            return function_override;
        }

        // Translates the opengl return type to the equivalent C# type.
        //
        // First, we use the official typemap (gl.tm) to get the correct type.
        // Then we override this, when it is:
        // 1) A string (we have to use Marshal.PtrToStringAnsi, to avoid heap corruption)
        // 2) An array (translates to IntPtr)
        // 3) A generic object or void* (translates to IntPtr)
        // 4) A GLenum (translates to int on Legacy.Tao or GL.Enums.GLenum otherwise).
        // Return types must always be CLS-compliant, because .Net does not support overloading on return types.
        static void TranslateReturnType(XPathNavigator nav, Delegate d, EnumCollection enums)
        {
            var function_override = GetFuncOverride(nav, d);

            if (function_override != null)
            {
                XPathNavigator return_override = function_override.SelectSingleNode("returns");
                if (return_override != null)
                {
                    d.ReturnType.CurrentType = return_override.Value;
                }
            }

            d.ReturnType.Translate(nav, d.Category, enums);

            if (d.ReturnType.CurrentType.ToLower().Contains("void") && d.ReturnType.Pointer != 0)
            {
                d.ReturnType.QualifiedType = "IntPtr";
                d.ReturnType.WrapperType = WrapperTypes.GenericReturnType;
            }

            if (d.ReturnType.CurrentType.ToLower().Contains("string"))
            {
                d.ReturnType.QualifiedType = "IntPtr";
                d.ReturnType.WrapperType = WrapperTypes.StringReturnType;
            }

            if (d.ReturnType.CurrentType.ToLower() == "object")
            {
                d.ReturnType.QualifiedType = "IntPtr";
                d.ReturnType.WrapperType |= WrapperTypes.GenericReturnType;
            }

            if (d.ReturnType.CurrentType.Contains("GLenum"))
            {
                if ((Settings.Compatibility & Settings.Legacy.ConstIntEnums) == Settings.Legacy.None)
                    d.ReturnType.QualifiedType = String.Format("{0}{1}{2}",
                        Settings.EnumsOutput, Settings.NamespaceSeparator, Settings.CompleteEnumName);
                else
                    d.ReturnType.QualifiedType = "int";
            }

            d.ReturnType.CurrentType = d.ReturnType.GetCLSCompliantType();
        }

        static void TranslateParameters(XPathNavigator nav, Delegate d, EnumCollection enums)
        {
            var function_override = GetFuncOverride(nav, d);

            for (int i = 0; i < d.Parameters.Count; i++)
            {
                if (function_override != null)
                {
                    XPathNavigator param_override = function_override.SelectSingleNode(
                            String.Format("param[@name='{0}']", d.Parameters[i].RawName));
                    if (param_override != null)
                    {
                        foreach (XPathNavigator node in param_override.SelectChildren(XPathNodeType.Element))
                        {
                            switch (node.Name)
                            {
                                case "type":
                                    d.Parameters[i].CurrentType = (string)node.TypedValue;
                                    break;
                                case "name":
                                    d.Parameters[i].Name = (string)node.TypedValue;
                                    break;
                                case "flow":
                                    d.Parameters[i].Flow = Parameter.GetFlowDirection((string)node.TypedValue);
                                    break;
                            }
                        }
                    }
                }

                d.Parameters[i].Translate(nav, d.Category, enums);
                if (d.Parameters[i].CurrentType == "UInt16" && d.Name.Contains("LineStipple"))
                    d.Parameters[i].WrapperType = WrapperTypes.UncheckedParameter;
            }
        }

        static FunctionCollection CreateWrappers(DelegateCollection delegates, EnumCollection enums)
        {
            var wrappers = new FunctionCollection();
            foreach (var d in delegates.Values)
            {
                wrappers.AddRange(CreateNormalWrappers(d, enums));
            }
            return wrappers;
        }

        static FunctionCollection CreateCLSCompliantWrappers(FunctionCollection functions, EnumCollection enums)
        {
            // If the function is not CLS-compliant (e.g. it contains unsigned parameters)
            // we need to create a CLS-Compliant overload. However, we should only do this
            // iff the opengl function does not contain unsigned/signed overloads itself
            // to avoid redefinitions.
            var wrappers = new FunctionCollection();
            foreach (var list in functions.Values)
            {
                foreach (var f in list)
                {
                    wrappers.AddChecked(f);

                    if (!f.CLSCompliant)
                    {
                        Function cls = new Function(f);

                        cls.Body.Clear();
                        CreateBody(cls, true, enums);

                        bool modified = false;
                        for (int i = 0; i < f.Parameters.Count; i++)
                        {
                            cls.Parameters[i].CurrentType = cls.Parameters[i].GetCLSCompliantType();
                            if (cls.Parameters[i].CurrentType != f.Parameters[i].CurrentType)
                                modified = true;
                        }

                        if (modified)
                            wrappers.AddChecked(cls);
                    }
                }
            }
            return wrappers;
        }

        static FunctionCollection MarkCLSCompliance(FunctionCollection collection)
        {
            //foreach (var w in
            //    (from list in collection
            //    from w1 in list.Value
            //    from w2 in list.Value
            //    where 
            //        w1.TrimmedName == w2.TrimmedName &&
            //        w1.Parameters.Count == w2.Parameters.Count &&
            //        ParametersDifferOnlyInReference(w1.Parameters, w2.Parameters)
            //    select !w1.Parameters.HasReferenceParameters ? w1 : w2))
            //    {
            //        results.Add(w);
            //    }

            foreach (List<Function> wrappers in collection.Values)
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
            return collection;
        }

        static IEnumerable<Function> CreateNormalWrappers(Delegate d, EnumCollection enums)
        {
            Function f = new Function(d);
            WrapReturnType(f);
            foreach (var wrapper in WrapParameters(f, enums))
            {
                yield return wrapper;
            }
        }

        public static IEnumerable<Function> WrapParameters(Function func, EnumCollection enums)
        {
            Function f;

            if (func.Parameters.HasPointerParameters)
            {
                Function _this = new Function(func);
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
                CreateBody(f, false, enums);
                yield return f;
                foreach (var w in WrapVoidPointers(new Function(f), enums))
                    yield return w;

                _this = new Function(func);
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
                CreateBody(f, false, enums);
                yield return f;
                foreach (var w in WrapVoidPointers(new Function(f), enums))
                    yield return w;

                _this = func;
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
                CreateBody(f, false, enums);
                yield return f;
                foreach (var w in WrapVoidPointers(new Function(f), enums))
                    yield return w;
            }
            else
            {
                f = new Function(func);
                CreateBody(f, false, enums);
                yield return f;
            }
        }

        static int index;
        static IEnumerable<Function> WrapVoidPointers(Function func, EnumCollection enums)
        {
            if (index >= 0 && index < func.Parameters.Count)
            {
                if (func.Parameters[index].WrapperType == WrapperTypes.GenericParameter)
                {
                    // Recurse to the last parameter
                    ++index;
                    foreach (var w in WrapVoidPointers(func, enums))
                        yield return w;
                    --index;

                    // On stack rewind, create generic wrappers
                    func.Parameters[index].Reference = true;
                    func.Parameters[index].Array = 0;
                    func.Parameters[index].Pointer = 0;
                    func.Parameters[index].Generic = true;
                    func.Parameters[index].CurrentType = "T" + index.ToString();
                    func.Parameters[index].Flow = FlowDirection.Undefined;
                    func.Parameters.Rebuild = true;
                    CreateBody(func, false, enums);
                    yield return new Function(func);

                    func.Parameters[index].Reference = false;
                    func.Parameters[index].Array = 1;
                    func.Parameters[index].Pointer = 0;
                    func.Parameters[index].Generic = true;
                    func.Parameters[index].CurrentType = "T" + index.ToString();
                    func.Parameters[index].Flow = FlowDirection.Undefined;
                    func.Parameters.Rebuild = true;
                    CreateBody(func, false, enums);
                    yield return new Function(func);

                    func.Parameters[index].Reference = false;
                    func.Parameters[index].Array = 2;
                    func.Parameters[index].Pointer = 0;
                    func.Parameters[index].Generic = true;
                    func.Parameters[index].CurrentType = "T" + index.ToString();
                    func.Parameters[index].Flow = FlowDirection.Undefined;
                    func.Parameters.Rebuild = true;
                    CreateBody(func, false, enums);
                    yield return new Function(func);

                    func.Parameters[index].Reference = false;
                    func.Parameters[index].Array = 3;
                    func.Parameters[index].Pointer = 0;
                    func.Parameters[index].Generic = true;
                    func.Parameters[index].CurrentType = "T" + index.ToString();
                    func.Parameters[index].Flow = FlowDirection.Undefined;
                    func.Parameters.Rebuild = true;
                    CreateBody(func, false, enums);
                    yield return new Function(func);
                }
                else
                {
                    // Recurse to the last parameter
                    ++index;
                    foreach (var w in WrapVoidPointers(func, enums))
                        yield return w;
                    --index;
                }
            }
        }

        static void WrapReturnType(Function func)
        {
            switch (func.ReturnType.WrapperType)
            {
                case WrapperTypes.StringReturnType:
                    func.ReturnType.QualifiedType = "String";
                    break;
            }
        }

        readonly static List<string> handle_statements = new List<string>();
        readonly static List<string> handle_release_statements = new List<string>();
        readonly static List<string> fixed_statements = new List<string>();
        readonly static List<string> assign_statements = new List<string>();

        // For example, if parameter foo has indirection level = 1, then it
        // is consumed as 'foo*' in the fixed_statements and the call string.
        readonly static string[] indirection_levels = new string[] { "", "*", "**", "***", "****" };

        static void CreateBody(Function func, bool wantCLSCompliance, EnumCollection enums)
        {
            Function f = new Function(func);

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
                    if (IsEnum(p.Name, enums) && p.QualifiedType != f.WrappedDelegate.Parameters[parameter_index].QualifiedType)
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
                else if (func.ReturnType.CurrentType.ToLower().Contains("string"))
                    f.Body.Add(String.Format("{0} {1} = null; unsafe {{ {1} = new string((sbyte*){2}); }}",
                        func.ReturnType.QualifiedType, "retval", method_call));
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
                else if (func.ReturnType.CurrentType.ToLower().Contains("string"))
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

            func.Body = f.Body;
        }

        static bool IsEnum(string s, EnumCollection enums)
        {
            return enums.ContainsKey(s);
        }
    }
}
