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
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.XPath;
using Bind.Structures;
using Delegate = Bind.Structures.Delegate;

namespace Bind
{
    using Enum = Bind.Structures.Enum;
    using Type = Bind.Structures.Type;

    class FuncProcessor
    {
        static readonly Regex Endings =
            new Regex(@"((((d|f|fi)|(L?(u?i?64)?u?[isb]))_?(64)?v?)|v)", RegexOptions.Compiled | RegexOptions.RightToLeft);
        static readonly Regex EndingsNotToTrim =
            new Regex("(ib|[tdrey]s|[eE]n[vd]|bled|Attrib|Access|Coord|Feedbacks|Flag|Queries|Tess|Status|Pixels|Instanced|Indexed|Varyings|Boolean|IDs|Uniforms)", RegexOptions.Compiled | RegexOptions.RightToLeft);
        static readonly Regex EndingsAddV = new Regex("^0", RegexOptions.Compiled);

        string Overrides { get; set; }

        IBind Generator { get; set; }
        Settings Settings { get { return Generator.Settings; } }

        public FuncProcessor(IBind generator, string overrides)
        {
            if (generator == null)
                throw new ArgumentNullException("generator");
            if (overrides == null)
                throw new ArgumentNullException("overrides");

            Generator = generator;
            Overrides = overrides;
        }

        public FunctionCollection Process(EnumProcessor enum_processor, DelegateCollection delegates, EnumCollection enums,
            string apiname, string apiversion)
        {
            Console.WriteLine("Processing delegates.");
            var nav = new XPathDocument(Overrides).CreateNavigator();
            foreach (var version in apiversion.Split('|'))
            {
                // Translate each delegate:
                // 1st using the <replace> elements in overrides.xml
                // 2nd using the hardcoded rules in FuncProcessor (e.g. char* -> string)
                foreach (var signatures in delegates.Values)
                {
                    foreach (var d in signatures)
                    {
                        var replace = GetFuncOverride(nav, d, apiname, apiversion);

                        TranslateExtension(d);
                        TranslateReturnType(d, replace, nav, enum_processor, enums, apiname, version);
                        TranslateParameters(d, replace, nav, enum_processor, enums, apiname, version);
                        TranslateAttributes(d, replace, nav, apiname, version);
                    }
                }

                // Create overloads for backwards compatibility,
                // by resolving <overload> elements
                var overload_list = new List<Delegate>();
                foreach (var d in delegates.Values.Select(v => v.First()))
                {
                    var overload_elements = GetFuncOverload(nav, d, apiname, apiversion);
                    foreach (XPathNavigator overload_element in overload_elements)
                    {
                        var overload = new Delegate(d);
                        TranslateReturnType(overload, overload_element, nav, enum_processor, enums, apiname, version);
                        TranslateParameters(overload, overload_element, nav, enum_processor, enums, apiname, version);
                        TranslateAttributes(overload, overload_element, nav, apiname, version);
                        overload_list.Add(overload);
                    }
                }
                foreach (var overload in overload_list)
                {
                    delegates.Add(overload);
                }
            }

            Console.WriteLine("Generating convenience overloads.");
            delegates.AddRange(CreateConvenienceOverloads(delegates));

            Console.WriteLine("Generating wrappers.");
            var wrappers = CreateWrappers(delegates, enums);

            Console.WriteLine("Generating CLS compliant overloads.");
            wrappers = CreateCLSCompliantWrappers(wrappers, enums);

            Console.WriteLine("Removing non-CLS compliant duplicates.");
            wrappers = MarkCLSCompliance(wrappers);

            Console.WriteLine("Removing overloaded delegates.");
            RemoveOverloadedDelegates(delegates, wrappers);

            return wrappers;
        }

        #region Private Members

        // When we have a list of overloaded delegates, make sure that
        // all generated wrappers use the first (original) delegate, not
        // the overloaded ones. This allows us to reduce the amount
        // of delegates we need to generate (1 per entry point instead
        // of 1 per overload), which improves loading times.
        static void RemoveOverloadedDelegates(DelegateCollection delegates, FunctionCollection wrappers)
        {
            foreach (var w in wrappers.Values.SelectMany(w => w))
            {
                var d = delegates[w.Name].First();
                w.WrappedDelegate = d;
            }
        }

        static string GetPath(string apipath, string apiname, string apiversion, string function, string extension)
        {
            var path = new StringBuilder();
            path.Append("/signatures/");
            path.Append(apipath);
            if (!String.IsNullOrEmpty(apiname) && !String.IsNullOrEmpty(apiversion))
            {
                path.Append(String.Format(
                    "[contains(concat('|', @name, '|'), '|{0}|') and " +
                    "(contains(concat('|', @version, '|'), '|{1}|') or not(boolean(@version)))]",
                    apiname,
                    apiversion));
            }
            else if (!String.IsNullOrEmpty(apiname))
            {
                path.Append(String.Format("[contains(concat('|', @name, '|'), '|{0}|')]", apiname));
            }
            else if (!String.IsNullOrEmpty(apiversion))
            {
                path.Append(String.Format("[contains(concat('|', @version, '|'), '|{0}|') or not(boolean(@version))]", apiversion));
            }

            if (function != null)
            {
                if (extension != null)
                {
                    // match an override that has this specific extension
                    // *or* one that has no extension at all (equivalent
                    // to "match all possible extensions")
                    path.Append(String.Format(
                        "/function[contains(concat('|', @name, '|'), '|{0}|') and " +
                        "(contains(concat('|', @extension, '|'), '|{1}|') or not(boolean(@extension)))]",
                        function,
                        extension));
                }
                else
                {
                    path.Append(String.Format(
                        "/function[contains(concat('|', @name, '|'), '|{0}|')]",
                        function));
                }
            }

            return path.ToString();
        }

        static string GetOverloadsPath(string apiname, string apiversion, string function, string extension)
        {
            return GetPath("overload", apiname, apiversion, function, extension);
        }

        static string GetOverridesPath(string apiname, string apiversion, string function, string extension)
        {
            return GetPath("replace", apiname, apiversion, function, extension);
        }

        void TranslateType(Bind.Structures.Type type,
            XPathNavigator function_override, XPathNavigator overrides,
            EnumProcessor enum_processor, EnumCollection enums,
            string category, string apiname)
        {
            Bind.Structures.Enum @enum;
            string s;

            category = enum_processor.TranslateEnumName(category);

            // Try to find out if it is an enum. If the type exists in the normal GLEnums list, use this.
            // Special case for Boolean - it is an enum, but it is dumb to use that instead of the 'bool' type.
            bool normal = enums.TryGetValue(type.CurrentType, out @enum);

            // Translate enum types
            type.IsEnum = false;
            if (normal && @enum.Name != "GLenum" && @enum.Name != "Boolean")
            {
                type.IsEnum = true;

                if ((Settings.Compatibility & Settings.Legacy.ConstIntEnums) != Settings.Legacy.None)
                {
                    type.QualifiedType = "int";
                }
                else
                {
                    // Some functions and enums have the same names.
                    // Make sure we reference the enums rather than the functions.
                    if (normal)
                        type.QualifiedType = type.CurrentType.Insert(0, String.Format("{0}.", Settings.EnumsOutput));
                }
            }
            else if (Generator.GLTypes.TryGetValue(type.CurrentType, out s))
            {
                // Check if the parameter is a generic GLenum. If it is, search for a better match,
                // otherwise fallback to Settings.CompleteEnumName (named 'All' by default).
                if (s.Contains("GLenum") /*&& !String.IsNullOrEmpty(category)*/)
                {
                    type.IsEnum = true;

                    if ((Settings.Compatibility & Settings.Legacy.ConstIntEnums) != Settings.Legacy.None)
                    {
                        type.QualifiedType = "int";
                    }
                    else
                    {
                        // Better match: enum.Name == function.Category (e.g. GL_VERSION_1_1 etc)
                        // Note: for backwards compatibility we use "category" only for the gl api.
                        // glcore, gles1 and gles2 use the All enum instead.
                        if (apiname == "gl" && enums.ContainsKey(category))
                        {
                            type.QualifiedType = String.Format("{0}{1}{2}", Settings.EnumsOutput,
                                Settings.NamespaceSeparator, enum_processor.TranslateEnumName(category));
                        }
                        else
                        {
                            type.QualifiedType = String.Format("{0}{1}{2}", Settings.EnumsOutput,
                                Settings.NamespaceSeparator, Settings.CompleteEnumName);
                        }
                    }
                }
                else
                {
                    // Todo: what is the point of this here? It is overwritten below.
                    // A few translations for consistency
                    switch (type.CurrentType.ToLower())
                    {
                        case "string":
                            type.QualifiedType = "String";
                            break;
                    }

                    type.QualifiedType = s;
                }
            }

            type.CurrentType =
                Generator.CSTypes.ContainsKey(type.CurrentType) ?
                Generator.CSTypes[type.CurrentType] : type.CurrentType;

            // Make sure that enum parameters follow enum overrides, i.e.
            // if enum ErrorCodes is overriden to ErrorCode, then parameters
            // of type ErrorCodes should also be overriden to ErrorCode.
            XPathNavigator enum_override = overrides.SelectSingleNode(
                EnumProcessor.GetOverridesPath(apiname, type.CurrentType));
            if (enum_override != null)
            {
                // For consistency - many overrides use string instead of String.
                if (enum_override.Value == "string")
                    type.QualifiedType = "String";
                else if (enum_override.Value == "StringBuilder")
                    type.QualifiedType = "StringBuilder";
                else
                    type.CurrentType = enum_override.Value;
            }

            if (type.CurrentType == "IntPtr" && String.IsNullOrEmpty(type.PreviousType))
                type.Pointer = 0;

            if (type.Pointer >= 3)
            {
                System.Diagnostics.Trace.WriteLine(String.Format(
                    "[Error] Type '{0}' has a high pointer level. Bindings will be incorrect.",
                    type));
            }

            if (!type.IsEnum)
            {
                // Remove qualifier if type is not an enum
                // Resolves issues when replacing / overriding
                // an enum parameter with a non-enum type
                type.QualifiedType = type.CurrentType;
            }
        }

        static string TranslateExtension(string extension)
        {
            extension = extension.ToUpper();
            if (extension.Length > 2)
            {
                extension = extension[0] + extension.Substring(1).ToLower();
            }
            return extension;
        }
        
        void TranslateExtension(Delegate d)
        {
            d.Extension = TranslateExtension(d.Extension);
        }

        static string GetTrimmedExtension(string name, string extension)
        {
            // Extensions are always uppercase
            int index = name.LastIndexOf(extension.ToUpper());
            if (index >= 0)
            {
                name = name.Remove(index);
            }
            return name;
        }

        // Trims unecessary suffices from the specified OpenGL function name.
        static string GetTrimmedName(Delegate d)
        {
            string name = d.Name;
            string extension = d.Extension;
            string trimmed_name = GetTrimmedExtension(name, extension);

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

            // If we have a convenience overload, we should turn the name from
            // plural into singular
            if (d.ReturnType.WrapperType == WrapperTypes.ConvenienceReturnType ||
                d.ReturnType.WrapperType == WrapperTypes.ConvenienceArrayReturnType ||
                d.Parameters.Any(p => p.WrapperType == WrapperTypes.ConvenienceArrayType))
            {
                trimmed_name = trimmed_name.Replace("Queries", "Query");
                trimmed_name = trimmed_name.TrimEnd('s');
            }

            return trimmed_name;
        }

        static XPathNodeIterator GetFuncOverload(XPathNavigator nav, Delegate d, string apiname, string apiversion)
        {
            // Try a few different extension variations that appear in the overrides xml file
            string[] extensions = { d.Extension, TranslateExtension(d.Extension), d.Extension.ToUpper() };
            string trimmed_name = GetTrimmedName(d);
            XPathNodeIterator function_overload = null;

            foreach (var ext in extensions)
            {
                string extensionless_name = GetTrimmedExtension(d.Name, ext);
                function_overload = nav.Select(GetOverloadsPath(apiname, apiversion, d.Name, ext));
                if (function_overload.Count != 0)
                    break;
                function_overload = nav.Select(GetOverloadsPath(apiname, apiversion, extensionless_name, ext));
                if (function_overload.Count != 0)
                    break;
                function_overload = nav.Select(GetOverloadsPath(apiname, apiversion, trimmed_name, ext));
                if (function_overload.Count != 0)
                    break;
            }
            return function_overload;
        }

        static XPathNavigator GetFuncOverride(XPathNavigator nav, Delegate d, string apiname, string apiversion)
        {
            // Try a few different extension variations that appear in the overrides xml file
            string[] extensions = { d.Extension, TranslateExtension(d.Extension), d.Extension.ToUpper() };
            string trimmed_name = GetTrimmedName(d);
            XPathNavigator function_override = null;

            foreach (var ext in extensions)
            {
                string extensionless_name = GetTrimmedExtension(d.Name, ext);
                function_override =
                    nav.SelectSingleNode(GetOverridesPath(apiname, apiversion, d.Name, ext)) ??
                    nav.SelectSingleNode(GetOverridesPath(apiname, apiversion, extensionless_name, ext)) ??
                    nav.SelectSingleNode(GetOverridesPath(apiname, apiversion, trimmed_name, ext));

                if (function_override != null)
                {
                    break;
                }
            }
            return function_override;
        }

        void TrimName(Function f)
        {
            f.TrimmedName = GetTrimmedName(f);
        }

        static void ApplyParameterReplacement(Delegate d, XPathNavigator function_override)
        {
            if (function_override != null)
            {
                for (int i = 0; i < d.Parameters.Count; i++)
                {
                    XPathNavigator param_override = function_override.SelectSingleNode(String.Format("param[@name='{0}']", d.Parameters[i].RawName));
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
                                case "count":
                                    int count;
                                    if (Int32.TryParse(node.Value, out count))
                                        d.Parameters[i].ElementCount = count;
                                    break;
                            }
                        }
                    }
                }
            }
        }

        static void ApplyReturnTypeReplacement(Delegate d, XPathNavigator function_override)
        {
            if (function_override != null)
            {
                XPathNavigator return_override = function_override.SelectSingleNode("returns");
                if (return_override != null)
                {
                    d.ReturnType.CurrentType = return_override.Value;
                }
            }
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
        void TranslateReturnType(Delegate d,
            XPathNavigator function_override, XPathNavigator nav,
            EnumProcessor enum_processor, EnumCollection enums,
            string apiname, string apiversion)
        {
            ApplyReturnTypeReplacement(d, function_override);

            TranslateType(d.ReturnType, function_override, nav, enum_processor,enums, d.Category, apiname);

            if (d.ReturnType.CurrentType.ToLower().Contains("void") && d.ReturnType.Pointer != 0)
            {
                d.ReturnType.QualifiedType = "IntPtr";
                d.ReturnType.Pointer--;
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

            d.ReturnType.CurrentType = GetCLSCompliantType(d.ReturnType);
        }

        Delegate GetCLSCompliantDelegate(Delegate d)
        {
            Delegate f = new Delegate(d);

            for (int i = 0; i < f.Parameters.Count; i++)
            {
                f.Parameters[i].CurrentType = GetCLSCompliantType(f.Parameters[i]);
            }

            f.ReturnType.CurrentType = GetCLSCompliantType(f.ReturnType);

            return f;
        }

        void TranslateParameters(Delegate d,
            XPathNavigator function_override, XPathNavigator nav,
            EnumProcessor enum_processor, EnumCollection enums,
            string apiname, string apiversion)
        {
            ApplyParameterReplacement(d, function_override);

            for (int i = 0; i < d.Parameters.Count; i++)
            {
                TranslateParameter(d.Parameters[i], function_override, nav, enum_processor, enums, d.Category, apiname);
                if (d.Parameters[i].CurrentType == "UInt16" && d.Name.Contains("LineStipple"))
                    d.Parameters[i].WrapperType = WrapperTypes.UncheckedParameter;
            }
        }

        void TranslateParameter(Parameter p,
            XPathNavigator function_override, XPathNavigator overrides,
            EnumProcessor enum_processor, EnumCollection enums,
            string category, string apiname)
        {
            TranslateType(p, function_override, overrides, enum_processor, enums, category, apiname);

            // Find out the necessary wrapper types.
            if (p.Pointer != 0)/* || CurrentType == "IntPtr")*/
            {
                if (p.CurrentType.ToLower().Contains("string") ||
                    p.CurrentType.ToLower().Contains("char") && p.Pointer > 1)
                {
                    // string* -> [In] String[] or [Out] StringBuilder[]
                    p.QualifiedType =
                        p.Flow == FlowDirection.Out ?
                        "StringBuilder[]" :
                        "String[]";

                    p.Pointer = 0;
                    p.WrapperType = WrapperTypes.None;
                }
                else if (p.CurrentType.ToLower().Contains("char"))
                {
                    // char* -> [In] String or [Out] StringBuilder
                    p.QualifiedType =
                        p.Flow == FlowDirection.Out ?
                        "StringBuilder" :
                        "String";

                    p.Pointer = 0;
                    p.WrapperType = WrapperTypes.None;
                }
                else if (p.CurrentType.ToLower().Contains("void") ||
                    (!String.IsNullOrEmpty(p.PreviousType) && p.PreviousType.ToLower().Contains("void")))
                    //|| CurrentType.Contains("IntPtr"))
                {
                    p.CurrentType = "IntPtr";
                    p.Pointer = 0;
                    p.WrapperType = WrapperTypes.GenericParameter;
                }
                else
                {
                    p.WrapperType = WrapperTypes.ArrayParameter;
                }
            }

            if (p.Reference)
                p.WrapperType |= WrapperTypes.ReferenceParameter;

            if (Utilities.Keywords(Settings.Language).Contains(p.Name))
                p.Name = Settings.KeywordEscapeCharacter + p.Name;

            // This causes problems with bool arrays
            //if (CurrentType.ToLower().Contains("bool"))
            //    WrapperType = WrapperTypes.BoolParameter;
        }

        void TranslateAttributes(Delegate d,
            XPathNavigator function_override, XPathNavigator nav,
            string apiname, string apiversion)
        {
            if (function_override != null)
            {
                var version_override = function_override.SelectSingleNode("version");
                if (version_override != null)
                {
                    d.Version = version_override.Value;
                }

                var profile_override = function_override.SelectSingleNode("profile");
                if (profile_override != null)
                {
                    Debug.Print("Profile override not yet implemented");
                }

                var obsolete = function_override.GetAttribute("obsolete", String.Empty);
                if (!String.IsNullOrEmpty(obsolete))
                {
                    d.Obsolete = obsolete;
                }
            }
        }

        FunctionCollection CreateWrappers(DelegateCollection delegates, EnumCollection enums)
        {
            var wrappers = new FunctionCollection();
            foreach (var d in delegates.Values.SelectMany(v => v))
            {
                wrappers.AddRange(CreateNormalWrappers(d, enums));
            }

            if ((Settings.Compatibility & Settings.Legacy.KeepUntypedEnums) != 0)
            {
                // Generate an "All" overload for every function that takes strongly-typed enums
                var overloads = new List<Function>();
                foreach (var list in wrappers.Values)
                {
                    overloads.AddRange(list.Where(f => f.Parameters.Any(p => p.IsEnum)).Select(f =>
                    {
                        var fnew = new Function(f);
                        fnew.Obsolete = "Use strongly-typed overload instead";
                        // Note that we can only overload parameters, not the return type
                        foreach (var p in fnew.Parameters)
                        {
                            if (p.IsEnum)
                            {
                                p.CurrentType = Settings.CompleteEnumName;
                            }
                        }

                        return fnew;
                    }));
                }
                wrappers.AddRange(overloads);
            }
            return wrappers;
        }

        FunctionCollection CreateCLSCompliantWrappers(FunctionCollection functions, EnumCollection enums)
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
                        // The return type must always be cls-compliant,
                        // since we cannot overload on return types alone.
                        f.ReturnType.CurrentType = GetCLSCompliantType(f.ReturnType);

                        // Create a cls-compliant wrapper for the parameters
                        Function cls = new Function(f);
                        bool modified = false;
                        for (int i = 0; i < f.Parameters.Count; i++)
                        {
                            cls.Parameters[i].CurrentType = GetCLSCompliantType(cls.Parameters[i]);
                            if (cls.Parameters[i].CurrentType != f.Parameters[i].CurrentType)
                                modified = true;
                        }

                        // Only add a cls-compliant overload if we have
                        // changed a parameter.
                        if (modified)
                        {
                            wrappers.AddChecked(cls);
                        }
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
                var must_remove = new List<int>();

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
                                    must_remove.Add(i);
                                if (function_j_is_problematic)
                                    must_remove.Add(j);
                            }
                        }
                    }
                }

                int count = 0;
                must_remove.Sort();
                foreach (var i in must_remove)
                {
                    // Careful: whenever we remove a function, the total count
                    // is reduced. We must account for that, or we will remove
                    // the wrong function!
                    wrappers.RemoveAt(i - count);
                    count++;
                }
            }
            return collection;
        }

        string GetCLSCompliantType(Type type)
        {
            if (!type.CLSCompliant)
            {
                if (type.Pointer != 0 && Settings.Compatibility == Settings.Legacy.Tao)
                    return "IntPtr";

                switch (type.CurrentType)
                {
                    case "UInt16":
                    case "ushort":
                        return "Int16";
                    case "UInt32":
                    case "uint":
                        return "Int32";
                    case "UInt64":
                    case "ulong":
                        return "Int64";
                    case "SByte":
                    case "sbyte":
                        return "Byte";
                    case "UIntPtr":
                        return "IntPtr";
                }
            }

            return type.CurrentType;
        }

        IEnumerable<Function> CreateNormalWrappers(Delegate d, EnumCollection enums)
        {
            Function f = new Function(d);
            TrimName(f);

            WrapReturnType(f);
            foreach (var wrapper in WrapParameters(f, enums))
            {
                yield return wrapper;
            }
        }

        IEnumerable<Delegate> CreateConvenienceOverloads(DelegateCollection delegates)
        {
            foreach (var list in delegates.Values)
            {
                var d = list.First();
                if (d.Parameters.Count > 0 && d.Parameters.Count <= 2)
                {
                    var p = d.Parameters.Last();
                    var r = d.ReturnType;

                    var name = GetTrimmedName(d);

                    bool is_candidate = true;
                    is_candidate &=
                        name.StartsWith("Get") || name.StartsWith("Gen") ||
                        name.StartsWith("Delete") || name.StartsWith("New");
                    is_candidate &= p.Pointer > 0;
                    // if there is a specific count set, such as "4", then this function
                    // returns a vector of specific dimensions and it would be wrong
                    // to generate an overload that returns a value of different size.
                    is_candidate &= p.ElementCount == 0 || p.ElementCount == 1;
                    is_candidate &= r.CurrentType == "void" && r.Pointer == 0;

                    if (is_candidate && p.Flow == FlowDirection.Out)
                    {
                        // Match Gen*|Get*|New*([Out] int[] names) methods
                        var f = CreateReturnTypeConvenienceWrapper(d);
                        yield return f;
                    }
                    else if (is_candidate && p.Flow != FlowDirection.Out)
                    {
                        // Match *Delete(int count, int[] names) methods
                        if (d.Parameters.Count == 2)
                        {
                            var f = CreateArrayReturnTypeConvencienceWrapper(d);
                            yield return f;
                        }
                    }
                }
            }
        }

        static Delegate CreateReturnTypeConvenienceWrapper(Delegate d)
        {
            var f = new Delegate(d);
            f.ReturnType = new Type(f.Parameters.Last());
            f.ReturnType.Pointer = 0;
            f.Parameters.RemoveAt(f.Parameters.Count - 1);
            f.ReturnType.WrapperType = WrapperTypes.ConvenienceReturnType;

            if (d.Name.Contains("GetFixed"))
                System.Diagnostics.Debugger.Break();
            if (f.Parameters.Count > 0)
            {
                var p_size = f.Parameters.Last();
                if (p_size.CurrentType.ToLower().StartsWith("int") && p_size.Pointer == 0)
                {
                    f.Parameters.RemoveAt(f.Parameters.Count - 1);
                    f.ReturnType.WrapperType = WrapperTypes.ConvenienceArrayReturnType;
                }
            }
            return f;
        }

        static Delegate CreateArrayReturnTypeConvencienceWrapper(Delegate d)
        {
            var f = new Delegate(d);
            var p_array = f.Parameters.Last();
            var p_size = f.Parameters[f.Parameters.Count - 2];
            f.Parameters.RemoveAt(f.Parameters.Count - 2);
            p_array.WrapperType = WrapperTypes.ConvenienceArrayType;
            p_array.Pointer = 0;
            return f;
        }

        public IEnumerable<Function> WrapParameters(Function func, EnumCollection enums)
        {
            Function f;

            if (func.Parameters.HasPointerParameters)
            {
                Function _this = new Function(func);
                // Array overloads
                foreach (Parameter p in _this.Parameters)
                {
                    if (p.WrapperType == WrapperTypes.ArrayParameter)
                    {
                        if (p.ElementCount != 1)
                        {
                            // Create a proper array
                            p.Reference = false;
                            p.Array++;
                            p.Pointer--;
                        }
                        else
                        {
                            // Create a reference
                            p.Reference = true;
                            p.Array--;
                            p.Pointer--;
                            p.WrapperType = WrapperTypes.ReferenceParameter;
                        }
                    }
                }
                f = new Function(_this);
                yield return f;
                foreach (var w in WrapVoidPointers(f, enums))
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
                        p.WrapperType = WrapperTypes.ReferenceParameter;
                    }
                }
                f = new Function(_this);
                yield return f;
                foreach (var w in WrapVoidPointers(f, enums))
                    yield return w;

                _this = func;
                // Pointer overloads
                // Should be last to work around an Intellisense bug, where
                // array overloads are not reported if there is a pointer overload.
                foreach (Parameter p in _this.Parameters)
                {
                    if (p.WrapperType == WrapperTypes.ArrayParameter)
                    {
                        p.Reference = false;
                        p.WrapperType = WrapperTypes.PointerParameter;
                    }
                }
                f = new Function(_this);
                yield return f;
                foreach (var w in WrapVoidPointers(f, enums))
                    yield return w;
            }
            else
            {
                f = new Function(func);
                yield return f;
            }
        }

        IEnumerable<Function> WrapVoidPointers(Function f, EnumCollection enums)
        {
            // reference wrapper (e.g. void Foo<T1,T2>(int, ref T1, ref T2))
            var func = new Function(f);
            int index = -1;
            foreach (var p in func.Parameters)
            {
                index++;
                if (p.WrapperType == WrapperTypes.GenericParameter)
                {
                    p.Reference = true;
                    p.Array = 0;
                    p.Pointer = 0;
                    p.Generic = true;
                    p.CurrentType = "T" + index.ToString();
                    p.Flow = FlowDirection.Undefined;
                    func.Parameters.Rebuild = true;
                }
            }
            yield return func;

            // 1d-array wrapper (e.g. void Foo<T1, T2>(int, T1[], T2[]))
            func = new Function(f);
            index = -1;
            foreach (var p in func.Parameters)
            {
                index++;
                if (p.WrapperType == WrapperTypes.GenericParameter)
                {
                    p.Reference = false;
                    p.Array = 1;
                    p.Pointer = 0;
                    p.Generic = true;
                    p.CurrentType = "T" + index.ToString();
                    p.Flow = FlowDirection.Undefined;
                    func.Parameters.Rebuild = true;
                }
            }
            yield return func;

            // 2d-array wrapper (e.g. void Foo<T1, T2>(int, T1[,], T2[,]))
            func = new Function(f);
            index = -1;
            foreach (var p in func.Parameters)
            {
                index++;
                if (p.WrapperType == WrapperTypes.GenericParameter)
                {
                    p.Reference = false;
                    p.Array = 2;
                    p.Pointer = 0;
                    p.Generic = true;
                    p.CurrentType = "T" + index.ToString();
                    p.Flow = FlowDirection.Undefined;
                    func.Parameters.Rebuild = true;
                }
            }
            yield return func;

            // 3d-array wrapper (e.g. void Foo<T1, T2>(int, T1[,,], T2[,,]))
            func = new Function(f);
            index = -1;
            foreach (var p in func.Parameters)
            {
                index++;
                if (p.WrapperType == WrapperTypes.GenericParameter)
                {
                    p.Reference = false;
                    p.Array = 3;
                    p.Pointer = 0;
                    p.Generic = true;
                    p.CurrentType = "T" + index.ToString();
                    p.Flow = FlowDirection.Undefined;
                    func.Parameters.Rebuild = true;
                }
            }
            yield return func;
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

        #endregion
    }
}
