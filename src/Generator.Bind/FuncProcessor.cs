//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2013 Stefanos Apostolopoulos for the Open Toolkit library.
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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.XPath;
using Bind.Structures;
using Delegate = Bind.Structures.Delegate;

namespace Bind
{
    using Type = Bind.Structures.Type;

    internal class FuncProcessor
    {
        private static readonly Regex Endings = new Regex(
            @"([fd]v?|u?[isb](64)?v?|v|i_v|fi)$",
            RegexOptions.Compiled);

        private static readonly Regex EndingsNotToTrim = new Regex(
            "(sh|ib|[tdrey]s|[eE]n[vd]|bled" +
            "|Attrib|Access|Boolean|Coord|Depth|Feedbacks|Finish|Flag" +
            "|Groups|IDs|Indexed|Instanced|Pixels|Queries|Status|Tess|Through" +
            "|Uniforms|Varyings|Weight|Width)$",
            RegexOptions.Compiled);

        private static readonly Regex EndingsAddV = new Regex("^0", RegexOptions.Compiled);

        private readonly IEnumerable<string> _overrides;

        private IBind Generator { get; set; }
        private Settings Settings => Generator.Settings;

        public FuncProcessor(IBind generator, IEnumerable<string> overrides)
        {
            Generator = generator ?? throw new ArgumentNullException(nameof(generator));
            _overrides = overrides ?? throw new ArgumentNullException(nameof(overrides));
        }

        public FunctionCollection Process(EnumProcessor enumProcessor, DocProcessor docProcessor,
            DelegateCollection delegates, EnumCollection enums, string apiname, string apiversion)
        {
            foreach (var file in _overrides)
            {
                Console.WriteLine("Processing funcs in {0}.", file);

                var nav = new XPathDocument(file).CreateNavigator();
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
                            TranslateReturnType(d, replace, nav, enumProcessor, enums, apiname, version);
                            TranslateParameters(d, replace, nav, enumProcessor, enums, apiname, version);
                            TranslateAttributes(d, replace, nav, apiname, version);
                        }
                    }

                    // Create overloads for backwards compatibility,
                    // by resolving <overload> elements
                    var overloadList = new List<Delegate>();
                    foreach (var d in delegates.Values.Select(v => v.First()))
                    {
                        var overloadElements = GetFuncOverload(nav, d, apiname, apiversion);
                        foreach (XPathNavigator overloadElement in overloadElements)
                        {
                            var overload = new Delegate(d);
                            TranslateReturnType(overload, overloadElement, nav, enumProcessor, enums, apiname, version);
                            TranslateParameters(overload, overloadElement, nav, enumProcessor, enums, apiname, version);
                            TranslateAttributes(overload, overloadElement, nav, apiname, version);
                            overloadList.Add(overload);
                        }
                    }
                    foreach (var overload in overloadList)
                    {
                        delegates.Add(overload);
                    }
                }
            }

            Console.WriteLine("Generating wrappers.");
            var wrappers = CreateWrappers(delegates, enums);

            Console.WriteLine("Generating convenience overloads.");
            wrappers.AddRange(CreateConvenienceOverloads(wrappers));

            Console.WriteLine("Generating CLS compliant overloads.");
            wrappers = CreateCLSCompliantWrappers(wrappers, enums);

            Console.WriteLine("Removing non-CLS compliant duplicates.");
            wrappers = MarkCLSCompliance(wrappers);

            Console.WriteLine("Removing overloaded delegates.");
            RemoveOverloadedDelegates(delegates, wrappers);

            Console.WriteLine("Generating address table.");
            GenerateAddressTable(delegates);

            Console.WriteLine("Generating documentation.");
            GenerateDocumentation(wrappers, enumProcessor, docProcessor);

            return wrappers;
        }

        private void GenerateDocumentation(FunctionCollection wrappers,
            EnumProcessor enumProcessor, DocProcessor docProcessor)
        {
            foreach (var list in wrappers)
            {
                foreach (var f in list.Value)
                {
                    f.Documentation = docProcessor.Process(f,
                        enumProcessor);
                }
            }
        }

        private void GenerateAddressTable(DelegateCollection delegates)
        {
            // We allocate one slot per entry point. Rules:
            // - All extensions get a slot
            // - Core functions get a slot, unless UseDllImports is enabled
            // - On Windows, core functions with version > 1.1 must be treated as extensions.
            //   This is controlled via the UseWindowsCompatibleGL setting.
            // Entry points without a slot are assigned the magic slot index -1.
            // Generator.Rewrite detects this and generates a static DllImport call
            // instead of a calli instruction for these functions.

            int slot = -1;
            foreach (var list in delegates.Values)
            {
                var func = list.First();
                if (func.RequiresSlot(Settings))
                {
                    slot++;
                    foreach (var d in list)
                    {
                        d.Slot = slot;
                    }
                }
                else
                {
                    // Core function routed through DllImport - no slot generated
                    foreach (var d in list)
                    {
                        d.Slot = -1;
                    }
                }
            }
        }

        // When we have a list of overloaded delegates, make sure that
        // all generated wrappers use the first (original) delegate, not
        // the overloaded ones. This allows us to reduce the amount
        // of delegates we need to generate (1 per entry point instead
        // of 1 per overload), which improves loading times.
        private static void RemoveOverloadedDelegates(DelegateCollection delegates, FunctionCollection wrappers)
        {
            foreach (var w in wrappers.Values.SelectMany(w => w))
            {
                var d = delegates[w.Name].First();
                w.WrappedDelegate = d;
            }
        }

        private static string GetPath(string apipath, string apiname, string apiversion, string function, string extension)
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

        private static string GetOverloadsPath(string apiname, string apiversion, string function, string extension)
        {
            return GetPath("overload", apiname, apiversion, function, extension);
        }

        private static string GetOverridesPath(string apiname, string apiversion, string function, string extension)
        {
            return GetPath("replace", apiname, apiversion, function, extension);
        }

        private void TranslateType(Bind.Structures.Type type,
            XPathNavigator functionOverride, XPathNavigator overrides,
            EnumProcessor enumProcessor, EnumCollection enums,
            string category, string apiname)
        {
            Bind.Structures.Enum @enum;
            string s;

            category = enumProcessor.TranslateEnumName(category);

            // Try to find out if it is an enum. If the type exists in the normal GLEnums list, use this.
            // Special case for Boolean which is there simply because C89 does not support bool types.
            // We don't really need that in C#
            bool normal =
                enums.TryGetValue(type.CurrentType, out @enum) ||
                enums.TryGetValue(enumProcessor.TranslateEnumName(type.CurrentType), out @enum);

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
                    {
                        type.QualifiedType = String.Format("{0}.{1}", Settings.EnumsOutput, @enum.Name);
                    }
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
                                Settings.NamespaceSeparator, enumProcessor.TranslateEnumName(category));
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
                    type.QualifiedType = s;
                }
            }

            if ((type.Array == 0 && type.Pointer == 0 && !type.Reference) &&
                (type.QualifiedType.ToLower().Contains("buffersize") ||
                type.QualifiedType.ToLower().Contains("sizeiptr") ||
                type.QualifiedType.Contains("size_t")))
            {
                type.WrapperType |= WrapperTypes.SizeParameter;
            }

            type.CurrentType =
                Generator.CSTypes.ContainsKey(type.CurrentType) ?
                Generator.CSTypes[type.CurrentType] : type.CurrentType;

            // Make sure that enum parameters follow enum overrides, i.e.
            // if enum ErrorCodes is overriden to ErrorCode, then parameters
            // of type ErrorCodes should also be overriden to ErrorCode.
            XPathNavigator enumOverride = overrides.SelectSingleNode(
                EnumProcessor.GetOverridesPath(apiname, type.CurrentType));
            if (enumOverride != null)
            {
                // For consistency - many overrides use string instead of String.
                if (enumOverride.Value == "string")
                {
                    type.QualifiedType = "String";
                }
                else if (enumOverride.Value == "StringBuilder")
                {
                    throw new NotSupportedException("StringBuilder enum overrides are no longer supported");
                }
                else
                {
                    type.CurrentType = enumOverride.Value;
                }
            }

            if (type.CurrentType == "IntPtr" && String.IsNullOrEmpty(type.PreviousType))
            {
                type.Pointer = 0;
            }

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

        private static string TranslateExtension(string extension)
        {
            extension = extension.ToUpper();
            if (extension.Length > 2)
            {
                extension = extension[0] + extension.Substring(1).ToLower();
            }
            return extension;
        }

        private void TranslateExtension(Delegate d)
        {
            d.Extension = TranslateExtension(d.Extension);
        }

        private static string GetTrimmedExtension(string name, string extension)
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
        private static string GetTrimmedName(Delegate d)
        {
            string name = d.Name;
            string extension = d.Extension;
            string trimmedName = GetTrimmedExtension(name, extension);

            // Note: some endings should not be trimmed, for example: 'b' from Attrib.
            // Check the endingsNotToTrim regex for details.
            Match m = EndingsNotToTrim.Match(trimmedName);
            if ((m.Index + m.Length) != trimmedName.Length)
            {
                m = Endings.Match(trimmedName);

                if (m.Length > 0 && m.Index + m.Length == trimmedName.Length)
                {
                    // Only trim endings, not internal matches.
                    if (m.Value[m.Length - 1] == 'v' && EndingsAddV.IsMatch(name) &&
                        !name.StartsWith("Get") && !name.StartsWith("MatrixIndex"))
                    {
                        // Only trim ending 'v' when there is a number
                        trimmedName = trimmedName.Substring(0, m.Index) + "v";
                    }
                    else
                    {
                        if (!trimmedName.EndsWith("xedv"))
                        {
                            trimmedName = trimmedName.Substring(0, m.Index);
                        }
                        else
                        {
                            trimmedName = trimmedName.Substring(0, m.Index + 1);
                        }
                    }
                }
            }

            return trimmedName;
        }

        private static XPathNodeIterator GetFuncOverload(XPathNavigator nav, Delegate d, string apiname, string apiversion)
        {
            // Try a few different extension variations that appear in the overrides xml file
            string[] extensions = { d.Extension, TranslateExtension(d.Extension), d.Extension.ToUpper() };
            string trimmedName = GetTrimmedName(d);
            XPathNodeIterator functionOverload = null;

            foreach (var ext in extensions)
            {
                string extensionlessName = GetTrimmedExtension(d.Name, ext);
                functionOverload = nav.Select(GetOverloadsPath(apiname, apiversion, d.Name, ext));
                if (functionOverload.Count != 0)
                {
                    break;
                }
                functionOverload = nav.Select(GetOverloadsPath(apiname, apiversion, extensionlessName, ext));
                if (functionOverload.Count != 0)
                {
                    break;
                }
                functionOverload = nav.Select(GetOverloadsPath(apiname, apiversion, trimmedName, ext));
                if (functionOverload.Count != 0)
                {
                    break;
                }
            }
            return functionOverload;
        }

        private static XPathNavigator GetFuncOverride(XPathNavigator nav, Delegate d, string apiname, string apiversion)
        {
            // Try a few different extension variations that appear in the overrides xml file
            string[] extensions = { d.Extension, TranslateExtension(d.Extension), d.Extension.ToUpper() };
            string trimmedName = GetTrimmedName(d);
            XPathNavigator functionOverride = null;

            foreach (var ext in extensions)
            {
                string extensionlessName = GetTrimmedExtension(d.Name, ext);
                functionOverride =
                    nav.SelectSingleNode(GetOverridesPath(apiname, apiversion, d.Name, ext)) ??
                    nav.SelectSingleNode(GetOverridesPath(apiname, apiversion, extensionlessName, ext)) ??
                    nav.SelectSingleNode(GetOverridesPath(apiname, apiversion, trimmedName, ext));

                if (functionOverride != null)
                {
                    break;
                }
            }
            return functionOverride;
        }

        private void TrimName(Function f)
        {
            f.TrimmedName = GetTrimmedName(f);
        }

        private static void ApplyParameterReplacement(Delegate d, XPathNavigator functionOverride)
        {
            if (functionOverride != null)
            {
                for (int i = 0; i < d.Parameters.Count; i++)
                {
                    XPathNavigator paramOverride = functionOverride.SelectSingleNode(String.Format(
                        "param[@name='{0}' or @index='{1}']",
                        d.Parameters[i].RawName,
                        i));
                    if (paramOverride != null)
                    {
                        foreach (XPathNavigator node in paramOverride.SelectChildren(XPathNodeType.Element))
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
                                    d.Parameters[i].ComputeSize = node.Value.Trim();
                                    int count;
                                    if (Int32.TryParse(d.Parameters[i].ComputeSize, out count))
                                    {
                                        d.Parameters[i].ElementCount = count;
                                    }
                                    else
                                    {
                                        d.Parameters[i].ElementCount = 0;
                                    }
                                    break;
                            }
                        }
                    }
                }
            }
        }

        private static void ApplyReturnTypeReplacement(Delegate d, XPathNavigator functionOverride)
        {
            if (functionOverride != null)
            {
                XPathNavigator returnOverride = functionOverride.SelectSingleNode("returns");
                if (returnOverride != null)
                {
                    d.ReturnType.CurrentType = returnOverride.Value;
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
        private void TranslateReturnType(Delegate d,
            XPathNavigator functionOverride, XPathNavigator nav,
            EnumProcessor enumProcessor, EnumCollection enums,
            string apiname, string apiversion)
        {
            ApplyReturnTypeReplacement(d, functionOverride);

            TranslateType(d.ReturnType, functionOverride, nav, enumProcessor, enums, d.Category, apiname);

            if (d.ReturnType.CurrentType.ToLower() == "void" && d.ReturnType.Pointer != 0)
            {
                d.ReturnType.QualifiedType = "IntPtr";
                d.ReturnType.Pointer--;
                d.ReturnType.WrapperType |= WrapperTypes.GenericReturnType;
            }

            if (d.ReturnType.CurrentType.ToLower() == "string")
            {
                d.ReturnType.QualifiedType = "IntPtr";
                d.ReturnType.WrapperType |= WrapperTypes.StringReturnType;
            }

            if (d.ReturnType.CurrentType.ToLower() == "object")
            {
                d.ReturnType.QualifiedType = "IntPtr";
                d.ReturnType.WrapperType |= WrapperTypes.GenericReturnType;
            }

            if (d.ReturnType.CurrentType.Contains("GLenum"))
            {
                if ((Settings.Compatibility & Settings.Legacy.ConstIntEnums) == Settings.Legacy.None)
                {
                    d.ReturnType.QualifiedType = String.Format("{0}{1}{2}",
                        Settings.EnumsOutput, Settings.NamespaceSeparator, Settings.CompleteEnumName);
                }
                else
                {
                    d.ReturnType.QualifiedType = "int";
                }
            }

            if (d.ReturnType.CurrentType.ToLower().Contains("bool"))
            {
                d.ReturnType.QualifiedType = "byte";
                d.ReturnType.WrapperType |= WrapperTypes.BoolParameter;
            }

            d.ReturnType.CurrentType = GetCLSCompliantType(d.ReturnType);
        }

        private Delegate GetCLSCompliantDelegate(Delegate d)
        {
            Delegate f = new Delegate(d);

            for (int i = 0; i < f.Parameters.Count; i++)
            {
                f.Parameters[i].CurrentType = GetCLSCompliantType(f.Parameters[i]);
            }

            f.ReturnType.CurrentType = GetCLSCompliantType(f.ReturnType);

            return f;
        }

        private void TranslateParameters(Delegate d,
            XPathNavigator functionOverride, XPathNavigator nav,
            EnumProcessor enumProcessor, EnumCollection enums,
            string apiname, string apiversion)
        {
            ApplyParameterReplacement(d, functionOverride);

            for (int i = 0; i < d.Parameters.Count; i++)
            {
                TranslateParameter(d.Parameters[i], functionOverride, nav, enumProcessor, enums, d.Category, apiname);
                if (d.Parameters[i].CurrentType == "UInt16" && d.Name.Contains("LineStipple"))
                {
                    d.Parameters[i].WrapperType |= WrapperTypes.UncheckedParameter;
                }

                if (functionOverride != null)
                {
                    XPathNavigator paramOverride = functionOverride.SelectSingleNode(String.Format(
                           "param[@name='{0}' or @index='{1}']",
                           d.Parameters[i].RawName,
                           i));
                    if (paramOverride != null)
                    {
                        var legacyArrayParameter = paramOverride.GetAttribute("legacyArrayParameter", String.Empty);
                        if (!String.IsNullOrEmpty(legacyArrayParameter))
                        {
                            d.Parameters[i].WrapperType |= WrapperTypes.LegacyArrayParameter;
                        }
                    }
                }
            }
        }

        private void TranslateParameter(Parameter p,
            XPathNavigator functionOverride, XPathNavigator overrides,
            EnumProcessor enumProcessor, EnumCollection enums,
            string category, string apiname)
        {
            TranslateType(p, functionOverride, overrides, enumProcessor, enums, category, apiname);

            // Translate char* -> string. This simplifies the rest of the logic below
            if (p.CurrentType.ToLower().Contains("char") && p.Pointer > 0)
            {
                p.CurrentType = "string";
                p.Pointer--;
            }

            // Find out the necessary wrapper types.
            if (p.CurrentType.ToLower() == "string" && p.Pointer == 0)
            {
                // char* -> IntPtr
                // Due to a bug in the Mono runtime, we need
                // to marshal [out] string parameters ourselves.
                // StringBuilder crashes at runtime.
                // For symmetry, and to avoid potential runtime bugs,
                // we will also marshal [in] string types manually.
                p.QualifiedType = "IntPtr";
                p.WrapperType |= WrapperTypes.StringParameter;
            }

            if (p.CurrentType.ToLower() == "string" && p.Pointer >= 1)
            {
                // string* -> [In] String[]
                // [Out] StringBuilder[] parameter is not currently supported
                // Higher indirection levels are also not supported
                if (p.Flow == FlowDirection.Out)
                {
                    throw new NotSupportedException("[Out] String* parameters are not currently supported.");
                }
                if (p.Pointer >= 2)
                {
                    throw new NotSupportedException("String arrays with arity >= 2 are not currently supported.");
                }

                p.QualifiedType = "IntPtr";
                p.Pointer = 0;
                p.Array = 0;
                p.WrapperType |= WrapperTypes.StringArrayParameter;
            }

            if (p.Pointer > 0 && p.WrapperType == 0)
            {
                if (p.QualifiedType.ToLower().StartsWith("void"))
                {
                    p.QualifiedType = "IntPtr";
                    p.Pointer = 0; // Generic parameters cannot have pointers
                    p.WrapperType |= WrapperTypes.GenericParameter;
                    p.WrapperType |= WrapperTypes.ArrayParameter;
                    p.WrapperType |= WrapperTypes.ReferenceParameter;
                }
                else
                {
                    p.WrapperType |= WrapperTypes.ArrayParameter;
                    p.WrapperType |= WrapperTypes.ReferenceParameter;
                    p.WrapperType |= WrapperTypes.PointerParameter;
                }
            }

            if (Utilities.CSharpKeywords.Contains(p.Name))
            {
                p.Name = Settings.KeywordEscapeCharacter + p.Name;
            }

            // This causes problems with bool arrays
            //if (CurrentType.ToLower().Contains("bool"))
            //    WrapperType = WrapperTypes.BoolParameter;
        }

        private void TranslateAttributes(Delegate d,
            XPathNavigator functionOverride, XPathNavigator nav,
            string apiname, string apiversion)
        {
            if (functionOverride != null)
            {
                var versionOverride = functionOverride.SelectSingleNode("version");
                if (versionOverride != null)
                {
                    d.Version = versionOverride.Value;
                }

                var profileOverride = functionOverride.SelectSingleNode("profile");
                if (profileOverride != null)
                {
                    Debug.Print("Profile override not yet implemented");
                }

                var nameOverride = functionOverride.SelectSingleNode("name");
                if (nameOverride != null)
                {
                    d.Name = nameOverride.Value;
                }

                var obsolete = functionOverride.GetAttribute("obsolete", String.Empty);
                if (!String.IsNullOrEmpty(obsolete))
                {
                    d.Obsolete = obsolete;
                }
            }
        }

        private FunctionCollection CreateWrappers(DelegateCollection delegates, EnumCollection enums)
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

        private FunctionCollection CreateCLSCompliantWrappers(FunctionCollection functions, EnumCollection enums)
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
                            {
                                modified = true;
                            }
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

        private static FunctionCollection MarkCLSCompliance(FunctionCollection collection)
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
                var mustRemove = new List<int>();

                for (int i = 0; i < wrappers.Count; i++)
                {
                    for (int j = i + 1; j < wrappers.Count; j++)
                    {
                        if (wrappers[i].TrimmedName == wrappers[j].TrimmedName && wrappers[i].Parameters.Count == wrappers[j].Parameters.Count)
                        {
                            bool functionIIsProblematic = false;
                            bool functionJIsProblematic = false;

                            int k;
                            for (k = 0; k < wrappers[i].Parameters.Count; k++)
                            {
                                if (wrappers[i].Parameters[k].CurrentType != wrappers[j].Parameters[k].CurrentType)
                                {
                                    break;
                                }

                                if (wrappers[i].Parameters[k].DiffersOnlyOnReference(wrappers[j].Parameters[k]))
                                {
                                    if (wrappers[i].Parameters[k].Reference)
                                    {
                                        functionIIsProblematic = true;
                                    }
                                    else
                                    {
                                        functionJIsProblematic = true;
                                    }
                                }
                            }

                            if (k == wrappers[i].Parameters.Count)
                            {
                                if (functionIIsProblematic)
                                {
                                    mustRemove.Add(i);
                                }
                                if (functionJIsProblematic)
                                {
                                    mustRemove.Add(j);
                                }
                            }
                        }
                    }
                }

                int count = 0;
                mustRemove.Sort();
                foreach (var i in mustRemove)
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

        private string GetCLSCompliantType(Type type)
        {
            if (!type.CLSCompliant)
            {
                if (type.Pointer != 0 && Settings.Compatibility == Settings.Legacy.Tao)
                {
                    return "IntPtr";
                }

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

        private IEnumerable<Function> CreateNormalWrappers(Delegate d, EnumCollection enums)
        {
            Function f = new Function(d);
            TrimName(f);

            WrapReturnType(f);
            foreach (var wrapper in WrapParameters(f, enums))
            {
                yield return wrapper;
            }
        }

        private IEnumerable<Function> CreateConvenienceOverloads(FunctionCollection wrappers)
        {
            var convenienceWrappers = new List<Function>();
            foreach (var d in wrappers.Values.SelectMany(w => w))
            {
                if (d.Parameters.Count > 0 && d.Parameters.Count <= 2)
                {
                    var p = d.Parameters.Last();
                    var r = d.ReturnType;

                    var name = d.Name;

                    bool isCandidate = true;
                    isCandidate &=
                        name.StartsWith("Get") || name.StartsWith("Gen") ||
                        name.StartsWith("Delete") || name.StartsWith("New");
                    isCandidate &= p.Pointer > 0;
                    // if there is a specific count set, such as "4", then this function
                    // returns a vector of specific dimensions and it would be wrong
                    // to generate an overload that returns a value of different size.
                    isCandidate &= p.ElementCount == 0 || p.ElementCount == 1;
                    isCandidate &= r.CurrentType == "void" && r.Pointer == 0;

                    Function f = null;
                    if (isCandidate && p.Flow == FlowDirection.Out)
                    {
                        // Match Gen*|Get*|New*([Out] int[] names) methods
                        f = CreateReturnTypeConvenienceWrapper(d);
                    }
                    else if (isCandidate && p.Flow != FlowDirection.Out)
                    {
                        // Match *Delete(int count, int[] names) methods
                        if (d.Parameters.Count == 2)
                        {
                            f = CreateArrayReturnTypeConvenienceWrapper(d);
                        }
                    }

                    if (f != null)
                    {
                        // If we have a convenience overload, we should turn its name from plural into singular
                        f.TrimmedName = f.TrimmedName.Replace("Queries", "Query").TrimEnd('s');

                        convenienceWrappers.Add(f);
                    }
                }

                // Check for IntPtr parameters that correspond to size_t (e.g. GLsizei)
                // and add Int32 overloads for convenience.
                {
                    Function f = null;
                    int i = 0;
                    foreach (var p in d.Parameters)
                    {
                        if ((p.WrapperType & WrapperTypes.SizeParameter) != 0)
                        {
                            f = f ?? new Function(d);
                            f.Parameters[i].QualifiedType = "Int32";
                        }
                        i++;
                    }

                    if (f != null)
                    {
                        convenienceWrappers.Add(f);
                    }
                }
            }
            return convenienceWrappers;
        }

        private static Function CreateReturnTypeConvenienceWrapper(Function d)
        {
            var f = new Function(d);
            f.ReturnType = new Type(f.Parameters.Last());
            f.ReturnType.Pointer = 0;
            f.Parameters.RemoveAt(f.Parameters.Count - 1);
            f.ReturnType.WrapperType |= WrapperTypes.ConvenienceReturnType;

            if (f.Parameters.Count > 0)
            {
                var pSize = f.Parameters.Last();
                if (pSize.CurrentType.ToLower().StartsWith("int") && pSize.Pointer == 0)
                {
                    f.Parameters.RemoveAt(f.Parameters.Count - 1);
                    f.ReturnType.WrapperType |= WrapperTypes.ConvenienceArrayReturnType;
                }
            }
            return f;
        }

        private static Function CreateArrayReturnTypeConvenienceWrapper(Function d)
        {
            var f = new Function(d);
            var pArray = f.Parameters.Last();
            var pSize = f.Parameters[f.Parameters.Count - 2];
            f.Parameters.RemoveAt(f.Parameters.Count - 2);
            pArray.WrapperType |= WrapperTypes.ConvenienceArrayType;
            // Since this is a 1-element overload, we don't need
            // array or reference wrappers.
            pArray.WrapperType &= ~(
                WrapperTypes.ReferenceParameter |
                WrapperTypes.ArrayParameter);
            pArray.Array = pArray.Pointer = 0;
            pArray.Reference = false;
            return f;
        }

        private List<Function> GetWrapper(IDictionary<WrapperTypes, List<Function>> dictionary, WrapperTypes key, Function raw)
        {
            if (!dictionary.ContainsKey(key))
            {
                dictionary.Add(key, new List<Function>());
                if (raw != null)
                {
                    dictionary[key].Add(new Function(raw));
                }
            }
            return dictionary[key];
        }

        public IEnumerable<Function> WrapParameters(Function func, EnumCollection enums)
        {
            if (func.Parameters.Count == 0)
            {
                // Functions without parameters do not need
                // parameter wrappers
                yield return func;
                yield break;
            }

            var wrappers = new Dictionary<WrapperTypes, List<Function>>();
            for (int i = 0; i < func.Parameters.Count; i++)
            {
                var parameter = func.Parameters[i];

                // Handle all non-generic parameters first.
                // Generics are handled in a second pass.
                if ((parameter.WrapperType & WrapperTypes.GenericParameter) == 0)
                {
                    if ((parameter.WrapperType & WrapperTypes.LegacyArrayParameter) != 0)
                    {
                        foreach (var wrapper in GetWrapper(wrappers, WrapperTypes.LegacyArrayParameter, func))
                        {
                            wrapper.Obsolete = "Use out overload instead";
                            var p = wrapper.Parameters[i];
                            p.Array++;
                            p.Pointer--;
                        }
                    }

                    if ((parameter.WrapperType & WrapperTypes.ArrayParameter) != 0)
                    {
                        foreach (var wrapper in GetWrapper(wrappers, WrapperTypes.ArrayParameter, func))
                        {
                            var p = wrapper.Parameters[i];

                            if (p.ElementCount == 1)
                            {
                                p.Reference = true;
                            }
                            else
                            {
                                p.Array++;
                            }
                            p.Pointer--;
                        }
                    }

                    if ((parameter.WrapperType & WrapperTypes.ReferenceParameter) != 0)
                    {
                        foreach (var wrapper in GetWrapper(wrappers, WrapperTypes.ReferenceParameter, func))
                        {
                            var p = wrapper.Parameters[i];

                            p.Reference = true;
                            p.Pointer--;
                        }
                    }

                    if ((parameter.WrapperType & WrapperTypes.PointerParameter) != 0)
                    {
                        foreach (var wrapper in GetWrapper(wrappers, WrapperTypes.PointerParameter, func))
                        {
                            var p = wrapper.Parameters[i];

                            if (Settings.IsEnabled(Settings.Legacy.NoPublicUnsafeFunctions))
                            {
                                p.QualifiedType = "IntPtr";
                                p.Pointer = 0;
                            }
                        }
                    }

                    if (parameter.WrapperType == 0 ||
                        (parameter.WrapperType & WrapperTypes.ConvenienceArrayType) != 0 ||
                        (parameter.WrapperType & WrapperTypes.ConvenienceReturnType) != 0 ||
                        (parameter.WrapperType & WrapperTypes.ConvenienceArrayReturnType) != 0)
                    {
                        // We don't need to do anything, just add this function directly
                        // to the list of wrappers.
                        GetWrapper(wrappers, parameter.WrapperType, func);
                    }
                }
            }

            // Handle generic parameters
            if (wrappers.Count == 0)
            {
                // Some functions, such as VDPAUInit, only have generic parameters
                // This means no wrapper has been generated by any of the previous
                // transformations. Since the generic translation below operates on
                // existing wrappers, add one here to get the process started.
                wrappers.Add(WrapperTypes.None, new List<Function> { new Function(func) });
            }
            var list = new List<Function>();
            foreach (var wrapper in wrappers.Values.SelectMany(v => v))
            {
                // Add generic 'ref T' wrapper
                Function genericWrapper = null;
                for (int i = 0; i < wrapper.Parameters.Count; i++)
                {
                    var parameter = wrapper.Parameters[i];
                    if ((parameter.WrapperType & WrapperTypes.GenericParameter) != 0)
                    {
                        genericWrapper = genericWrapper ?? new Function(wrapper);
                        var p = genericWrapper.Parameters[i];

                        p.Reference = true;
                        p.Pointer = 0;
                        p.Array = 0;
                        p.Generic = true;
                        p.QualifiedType = "T" + i.ToString();
                        p.Flow = FlowDirection.Undefined;
                    }
                }
                if (genericWrapper != null)
                {
                    list.Add(genericWrapper);
                }

                // Add the following wrappers:
                // 'IntPtr', 'T[]', 'T[,]' and 'T[,,]'
                for (int arity = 0; arity < 4; arity++)
                {
                    genericWrapper = null;
                    for (int i = 0; i < wrapper.Parameters.Count; i++)
                    {
                        var parameter = wrapper.Parameters[i];
                        if ((parameter.WrapperType & WrapperTypes.GenericParameter) != 0)
                        {
                            genericWrapper = genericWrapper ?? new Function(wrapper);
                            if (arity > 0)
                            {
                                // Overloading on array arity is not CLS-compliant
                                genericWrapper.CLSCompliant = false;
                            }
                            var p = genericWrapper.Parameters[i];

                            p.Reference = false;
                            p.Pointer = 0;
                            p.Array = arity;
                            if (arity == 0)
                            {
                                p.QualifiedType = "IntPtr";
                            }
                            else
                            {
                                p.Generic = true;
                                p.QualifiedType = "T" + i.ToString();
                                p.Flow = FlowDirection.Undefined;
                            }
                        }
                    }
                    if (genericWrapper != null)
                    {
                        list.Add(genericWrapper);
                    }
                }
            }
            GetWrapper(wrappers, WrapperTypes.GenericParameter, null)
                .AddRange(list);

            // Handle string parameters
            foreach (var wrapper in wrappers.Values.SelectMany(v => v))
            {
                for (int i = 0; i < wrapper.Parameters.Count; i++)
                {
                    var p = wrapper.Parameters[i];
                    if ((p.WrapperType & WrapperTypes.StringParameter) != 0)
                    {
                        p.QualifiedType = "String";
                        if (p.Flow == FlowDirection.Out)
                        {
                            p.Reference = true;
                        }
                    }

                    if ((p.WrapperType & WrapperTypes.StringArrayParameter) != 0)
                    {
                        if (p.Flow == FlowDirection.Out)
                        {
                            throw new NotImplementedException();
                        }
                        else
                        {
                            p.QualifiedType = "String";
                            p.Pointer = 0;
                            p.Array = 1;
                        }
                    }
                }
            }

            // Return all generated wrappers
            foreach (var w in wrappers.Values.SelectMany(v => v).OrderBy(v => v))
            {
                yield return w;
            }
        }

        private static void WrapReturnType(Function func)
        {
            if ((func.ReturnType.WrapperType & WrapperTypes.StringReturnType) != 0)
            {
                func.ReturnType.QualifiedType = "String";
            }

            if ((func.ReturnType.WrapperType & WrapperTypes.GenericReturnType) != 0)
            {
                // Nothing else we can do, using generics will break the runtime
                func.ReturnType.QualifiedType = "IntPtr";
            }

            if ((func.ReturnType.WrapperType & WrapperTypes.BoolParameter) != 0)
            {
                func.ReturnType.QualifiedType = "bool";
            }
        }
    }
}
