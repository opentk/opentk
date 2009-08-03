//
// Copyright (C) 2009 the Open Toolkit (http://www.opentk.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Diagnostics;

namespace CHeaderToXML
{
    // Todo: Array parameters are copied as-is, e.g.: int foo[4] -> <param type="int" name="foo[4]" />.
    // This should become <param type="int*" name="foo" count="4" />.
    // Todo: Fails to parse ES extension headers, which mix enum and function definitions.

    // Parses ES and CL header files.
    sealed class ESCLParser
    {
        Regex extensions = new Regex("(ARB|EXT|AMD|NV|OES|QCOM)", RegexOptions.RightToLeft | RegexOptions.Compiled);
        Regex array_size = new Regex(@"\[.+\]", RegexOptions.RightToLeft | RegexOptions.Compiled);
        Regex EnumToken  = new Regex(@"^#define \w+\s+\w+$", RegexOptions.Compiled);

        public ESCLParser()
        {
        }

        public string Prefix {get; set;}
        public string Version {get; set;}

        public IEnumerable<XElement> Parse(string filename)
        {
            return Parse(File.ReadAllLines(filename));
        }

        public IEnumerable<XElement> Parse(string[] lines)
        {
            char[] splitters = new char[] { ' ', '\t', ',', '(', ')', ';', '\n', '\r' };

            // Line splitter
            Func<string, string[]> split = line =>
                line.Split(splitters, StringSplitOptions.RemoveEmptyEntries);

            // Adds new enum to the accumulator (acc)
            Func<string, List<XElement>, List<XElement>> enum_name = (line, acc) =>
            {
                Func<string, string[]> get_tokens = (_) =>
                    line.Trim("/*. ".ToCharArray()).Split(" _-+".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(t =>
                    {
                        switch (t.ToLower())
                        {
                            case ("bitfield"): return "Flags";
                            default:
                                if (t.ToLower() == Prefix)
                                    return "";
                                else
                                    return t;
                        }
                        /* gmcs bug 336258 */ return "";
                    }).ToArray();

                Func<string[], string> get_name = tokens =>
                {
                    // Some comments do not indicate enums. Cull them!
                    if (tokens[0].StartsWith("$"))
                        return null;
                    
                    // Some names consist of more than one tokens. Concatenate them.
                    return tokens.Aggregate(
                        "",
                        (string n, string token) =>
                        {
                            n += String.IsNullOrEmpty(token) ? "" : Char.ToUpper(token[0]).ToString() + token.Substring(1);
                            return n;
                        },
                        n => n);
                };

                Func<string, string> translate_name = name =>
                {
                    // Patch some names that are known to be problematic
                    switch (name)
                    {
                        case "OpenGLEScoreversions":
                        case "EGLVersioning":
                        case "OpenCLVersion": return "Version";
                        case "ShaderPrecision-SpecifiedTypes": return "ShaderPrecision";
                        case "Texturecombine+dot3": return "TextureCombine";
                        case "MacroNamesAndCorrespondingValuesDefinedByOpenCL": return null;
                        default: return name;
                    }
                };

                Func<string, List<XElement>> add_enum = @enum =>
                {
                    switch (@enum)
                    {
                        case null:
                        case "":
                            return acc;
                        default:
                            acc.Add(new XElement("enum", new XAttribute("name", @enum)));
                            return acc;
                    }
                };

                return add_enum(translate_name(get_name(get_tokens(line))));
            };

            // Adds new token to last enum in accumulator
            Func<string, List<XElement>, List<XElement>> enum_token = (line, acc) =>
            {
                if (EnumToken.IsMatch(line))
                {
                    if (acc.Count == 0 || acc.Last().Name.LocalName != "enum")
                        acc.Add(new XElement("enum", new XAttribute("name", "Unknown")));

                    var tokens = split(line);

                    // Check whether this is an include guard (e.g. #define __OPENCL_CL_H)
                    if (tokens[1].StartsWith("__"))
                        return acc;

                    acc[acc.Count - 1].Add(new XElement("token",
                        new XAttribute("name", tokens[1].Substring(Prefix.Length + 1)),   // removes prefix
                        new XAttribute("value", tokens[2])));
                }
                return acc;
            };

            // Parses a function declaration
            var function_string = ""; // Used to concatenate functions that are split in different lines. (e.g. "void\nclFoo(int /* a */,\nint b);")
            Func<string, List<XElement>, List<XElement>> function = (line, acc) =>
            {
                if (!line.EndsWith(";"))
                {
                    function_string += line + " ";
                    return acc;
                }

                line = function_string + line;
                function_string = "";

                Func<string, string> GetExtension = name =>
                {
                    var match = extensions.Match(name);
                    return match != null && String.IsNullOrEmpty(match.Value) ? "Core" : match.Value;
                };

                var words = line.Split(splitters, StringSplitOptions.RemoveEmptyEntries);
                //var words = line.Replace("/*", "").Replace("*/", "").Split(" ()".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                // ES does not start methods with 'extern', while CL does.
                // Remove the 'extern' keyword to create a single code-path.
                if (words[0] == "extern")
                    words = words.Skip(1).ToArray();

                string rettype = null;
                string funcname = null;
                GetFunctionNameAndType(words, out funcname, out rettype);

                var fun =
                    new
                    {
                        Name = funcname,
                        Return = rettype,
                        Version = Version,
                        Extension = GetExtension(funcname),
                        Profile = String.Empty,
                        Parameters =
                            from item in line.Split("()".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)[1].Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                            let tokens = item.Trim().Split(' ')
                            let param_name = (tokens.Last().Trim() != "*/" ? tokens.Last() : tokens[tokens.Length - 2]).Trim()
                            let param_type = (tokens.First().Trim() != "const" ? tokens.First().Trim() : tokens[tokens.Length - 2]).Trim()
                            let has_array_size = array_size.IsMatch(param_name)
                            let indirection_level = (from c in param_name where c == '*' select c).Count() + (from c in param_type where c == '*' select c).Count() + (has_array_size ? 1 : 0)
                            let pointers = new string[] { "*", "*", "*", "*" } // for adding indirection levels (pointers) to param_type
                            where tokens.Length > 1
                            select new
                            {
                                Name = (has_array_size ? array_size.Replace(param_name, "") : param_name).Replace("*", ""),
                                Type = param_type.Replace("*", "") + String.Join("", pointers, 0, indirection_level),
                                Count = has_array_size ? Int32.Parse(array_size.Match(param_name).Value.Trim('[', ']')) : 0
                            }
                    };

                XElement func = new XElement("function", new XAttribute("name", fun.Name));
                func.Add(new XAttribute("extension", fun.Extension));
                func.Add(new XAttribute("profile", fun.Profile));
                func.Add(new XAttribute("category", fun.Version));
                func.Add(new XAttribute("version", fun.Version));

                func.Add(new XElement("returns", new XAttribute("type", fun.Return)));
                foreach (var p in fun.Parameters)
                {
                    var param = new XElement("param", new XAttribute("type", p.Type), new XAttribute("name", p.Name));
                    if (p.Count > 0)
                        param.Add(new XAttribute("count", p.Count));
                    func.Add(param);
                }

                acc.Add(func);
                return acc;
            };

            Func<string, bool> is_comment = line => line.StartsWith("/*") || line.StartsWith("//");
            Func<string, bool> is_enum = line => {
                if (!is_comment(line))
                    return false;

                // Some enum tokens are commented out and should not be confused with new enum declarations.
                // Since tokens are always in ALL_CAPS, while enum names always contain at least one lower case
                // character, we'll try to use this information to distinguish between the two.
                // Warning: rather fragile.
                if (Regex.IsMatch(line, @"/\*\s+([A-Z]+_?[0-9]*_?)+\s+\*/"))
                        return false;
                
                var toks = split(line);
                return toks.Length > 1;// && toks[1].StartsWith("GL");
            };
            Func<string, bool> is_function = line =>
                (line.StartsWith("GL_APICALL") || line.StartsWith("GL_API") ||
                line.StartsWith("GLAPI") || line.StartsWith("EGLAPI") ||
                line.StartsWith("extern CL_API_ENTRY"));


            var signatures = lines.Aggregate(
                new List<XElement>(),
                (List<XElement> acc, string line) =>
                {
                    return
                        is_function(line) || !String.IsNullOrEmpty(function_string) ? function(line, acc) :
                        is_enum(line) ? enum_name(line, acc) :
                        enum_token(line, acc);
                },
                acc =>
                    from elem in acc
                    where !elem.IsEmpty
                    select elem);

            return signatures;
        }

        void GetFunctionNameAndType(string[] words, out string funcname, out string rettype)
        {
            funcname = null;
            rettype  = null;

            bool inRettype = false;
            bool quit = false;
            for (int i = 0; !quit && i < words.Length; ++i) {
                switch (words [i]) {
                    case "const":
                        // ignore
                        break;
                    case "GL_API":
                        inRettype = true;
                        break;
                    case "GL_APIENTRY":
                        inRettype = false;
                        funcname = words [i+1].Substring(Prefix.Length);
                        quit = true;
                        break;
                    default:
                        if (inRettype)
                            rettype += words [i];
                        break;
                }
            }
        }
    }
}