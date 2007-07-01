#region --- License ---
/*
MIT License
Copyright ©2006-2007 Tao Framework Team
http://www.taoframework.com
Copyright ©2005-2007 OpenTK
http://sourceforge.net/projects/opentk

All rights reserved.

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
#endregion License

#region --- Using Directives ---

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.CodeDom;

#endregion

namespace OpenTK.OpenGL.Bind
{
    static class SpecReader
    {
        #region internal static string FilePath
        internal static string FilePath
        {
            get
            {
                string filePath = Path.Combine("..", "..");
                string fileDirectory = Settings.InputPath;
                string fileName = "gl.spec";

                if (File.Exists(fileName))
                {
                    filePath = "";
                    fileDirectory = "";
                }
                else if (File.Exists(Path.Combine(fileDirectory, fileName)))
                {
                    filePath = "";
                }
                return Path.Combine(filePath, fileDirectory);
            }
        }
        #endregion

        #region private static StreamReader OpenSpecFile(string file)
        private static StreamReader OpenSpecFile(string file)
        {
            string path = Path.Combine(FilePath, file);
            StreamReader sr;

            try
            {
                sr = new StreamReader(path);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error opening spec file: {0}", path);
                Console.WriteLine("Error: {0}", e.Message);
                throw e;
            }

            return sr;
        }
        #endregion

        #region private static bool IsExtension(string function_name)
        private static bool IsExtension(string function_name)
        {
            return (function_name.EndsWith("ARB") ||
                    function_name.EndsWith("EXT") ||
                    function_name.EndsWith("ATI") ||
                    function_name.EndsWith("NV") ||
                    function_name.EndsWith("SUN") ||
                    function_name.EndsWith("SUNX") ||
                    function_name.EndsWith("SGI") ||
                    function_name.EndsWith("SGIS") ||
                    function_name.EndsWith("SGIX") ||
                    function_name.EndsWith("MESA") ||
                    function_name.EndsWith("3DFX") ||
                    function_name.EndsWith("IBM") ||
                    function_name.EndsWith("GREMEDY") ||
                    function_name.EndsWith("HP") ||
                    function_name.EndsWith("INTEL") ||
                    function_name.EndsWith("PGI") ||
                    function_name.EndsWith("INGR") ||
                    function_name.EndsWith("APPLE") ||
                    function_name.EndsWith("OML") ||
                    function_name.EndsWith("I3D"));
        }
        #endregion

        #region private static string NextValidLine(StreamReader sr)
        private static string NextValidLine(StreamReader sr)
        {
            string line;

            do
            {
                if (sr.EndOfStream)
                    return null;

                line = sr.ReadLine().Trim();

                if (String.IsNullOrEmpty(line) ||
                    line.StartsWith("#") ||                 // Disregard comments.
                    line.StartsWith("passthru") ||          // Disregard passthru statements.
                    line.StartsWith("required-props:") ||
                    line.StartsWith("param:") ||
                    line.StartsWith("dlflags:") ||
                    line.StartsWith("glxflags:") ||
                    line.StartsWith("vectorequiv:") ||
                    //line.StartsWith("category:") ||
                    line.StartsWith("version:") ||
                    line.StartsWith("glxsingle:") ||
                    line.StartsWith("glxropcode:") ||
                    line.StartsWith("glxvendorpriv:") ||
                    line.StartsWith("glsflags:") ||
                    line.StartsWith("glsopcode:") ||
                    line.StartsWith("glsalias:") ||
                    line.StartsWith("wglflags:") ||
                    line.StartsWith("extension:") ||
                    line.StartsWith("alias:") ||
                    line.StartsWith("offset:"))
                    continue;

                return line;
            }
            while (true);
        }
        #endregion

        #region public static void ReadFunctionSpecs(string file, out List<CodeTypeDelegate> delegates, out List<CodeMemberMethod> functions)
        public static List<CodeTypeDelegate> ReadFunctionSpecs(string file)
        {
            StreamReader sr = OpenSpecFile(file);
            Console.WriteLine("Reading function specs from file: {0}", file);

            List<CodeTypeDelegate> delegates = new List<CodeTypeDelegate>();

            do
            {
                string line = NextValidLine(sr);
                if (String.IsNullOrEmpty(line))
                    break;

                // Get next OpenGL function
                while (line.Contains("(") && !sr.EndOfStream)
                {
                    CodeTypeDelegate d = new CodeTypeDelegate();
                    d.Attributes = MemberAttributes.Static;
                    d.CustomAttributes.Add(new CodeAttributeDeclaration("System.Security.SuppressUnmanagedCodeSecurity"));

                    // Get function name:
                    d.Name = line.Split(SpecTranslator.Separators, StringSplitOptions.RemoveEmptyEntries)[0];
                    if (IsExtension(d.Name))
                    {
                        d.UserData.Add("Extension", true);
                    }
                    else
                    {
                        d.UserData.Add("Extension", false);
                    }

                    //d.StartDirectives.Add(new CodeRegionDirective(CodeRegionMode.Start, d.Name));
                    //d.EndDirectives.Add(new CodeRegionDirective(CodeRegionMode.End, d.Name));

                    // Get function parameters and return value:
                    do
                    {
                        line = sr.ReadLine();
                        List<string> words = new List<string>(
                            line.Replace('\t', ' ').Split(SpecTranslator.Separators, StringSplitOptions.RemoveEmptyEntries));

                        if (words.Count == 0)
                            break;

                        // Identify line:
                        switch (words[0])
                        {
                            case "return":  // Line denotes return value
                                CodeTypeReference tr = new CodeTypeReference(
                                    words[1]
                                );

                                //if (tr.BaseType == "GLvoid")
                                //    tr.BaseType = "System.Void";

                                d.ReturnType = tr;
                                break;

                            case "param":   // Line denotes parameter
                                CodeParameterDeclarationExpression p =
                                    new CodeParameterDeclarationExpression();
                                p.Name = words[1];
                                p.Type = new CodeTypeReference(words[2]);
                                p.Direction = words[3] == "in" ? FieldDirection.In : FieldDirection.Out;
                                if (words[3] != "in")
                                    p.CustomAttributes.Add(new CodeAttributeDeclaration("In, Out"));
                                p.Type.ArrayRank = words[4] == "array" ? 1 : 0;

                                d.Parameters.Add(p);
                                break;

                            /* version directive is not used. GetTexParameterIivEXT and GetTexParameterIuivEXT define two(!) versions (why?)
                            case "version": // Line denotes function version (i.e. 1.0, 1.2, 1.5)
                                d.UserData.Add("version", words[1]);
                                break;
                            */

                            case "category":
                                d.UserData.Add("Category", words[1]);
                                break;
                        }
                    }
                    while (!sr.EndOfStream);

                    delegates.Add(d);
                }
            }
            while (!sr.EndOfStream);

            return delegates;
        }

        #endregion

        #region public static void ReadEnumSpecs(string file, out List<CodeMemberField> enums)
        public static void ReadEnumSpecs(string file, out CodeTypeDeclarationCollection enums)
        {
            enums = new CodeTypeDeclarationCollection();
            // comple_enum contains all opengl enumerants.
            CodeTypeDeclaration complete_enum = new CodeTypeDeclaration();
            complete_enum.IsEnum = true;
            complete_enum.Name = "GLenum";

            StreamReader sr = OpenSpecFile(file);
            Console.WriteLine("Reading constant specs from file: {0}", file);

            do
            {
                string line = NextValidLine(sr);
                if (String.IsNullOrEmpty(line))
                    break;

                line = line.Replace('\t', ' ');

                // We just encountered the start of a new enumerant:
                while (!String.IsNullOrEmpty(line) && line.Contains("enum"))
                {
                    string[] words = line.Split(SpecTranslator.Separators, StringSplitOptions.RemoveEmptyEntries);
                    if (words.Length == 0)
                        continue;

                    // Declare a new enumerant
                    CodeTypeDeclaration e = new CodeTypeDeclaration();
                    e.IsEnum = true;
                    e.Name = SpecTranslator.GetTranslatedEnum(words[0]);
                    //d.Attributes = MemberAttributes.Const | MemberAttributes.Public;

                    // And fill in the values for this enumerant
                    do
                    {
                        line = NextValidLine(sr);

                        if (String.IsNullOrEmpty(line) || line.StartsWith("#"))
                            continue;

                        if (line.Contains("enum:") || sr.EndOfStream)
                            break;

                        line = line.Replace('\t', ' ');
                        words = line.Split(SpecTranslator.Separators, StringSplitOptions.RemoveEmptyEntries);

                        if (words.Length == 0)
                            continue;

                        // If we reach this point, we have found a new value for the current enumerant
                        CodeMemberField c = new CodeMemberField();
                        if (line.Contains("="))
                        {
                            c.Name = SpecTranslator.GetTranslatedEnum(words[0]);
                            
                            uint number;
                            if (UInt32.TryParse(words[2].Replace("0x", String.Empty), System.Globalization.NumberStyles.AllowHexSpecifier, null, out number))
                            {
                                if (number > 0x7FFFFFFF)
                                {
                                    words[2] = "unchecked((Int32)" + words[2] + ")";
                                }
                            }
                            else if (words[2].StartsWith("GL_"))
                            {
                                words[2] = words[2].Substring(3);
                            }

                            //c.InitExpression = new CodeFieldReferenceExpression(null, words[2]);
                            //c.UserData.Add("InitExpression", " = " + words[2]);
                            c.UserData.Add("ObjectReference", null);
                            c.UserData.Add("FieldReference", words[2]);
                        }
                        else if (words[0] == "use")
                        {
                            c.Name = SpecTranslator.GetTranslatedEnum(words[2]);

                            //c.InitExpression = new CodeFieldReferenceExpression(new CodeSnippetExpression(words[1]), SpecTranslator.GetTranslatedEnum(words[2]));
                            //c.UserData.Add("InitExpression", " = " + words[1] + "." + SpecTranslator.GetTranslatedEnum(words[2]));
                            c.UserData.Add("ObjectReference", words[1]);
                            c.UserData.Add("FieldReference", words[2]);
                        }

                        //if (!String.IsNullOrEmpty(c.Name) && !e.Members.Contains.Contains(c))
                        SpecTranslator.Merge(e.Members, c);

                        // Insert the current constant in the list of all constants.
                        SpecTranslator.Merge(complete_enum.Members, c);
                    }
                    while (!sr.EndOfStream);

                    // At this point, the complete value list for the current enumerant has been read, so add this
                    // enumerant to the list.
                    e.StartDirectives.Add(new CodeRegionDirective(CodeRegionMode.Start, "public enum " + e.Name));
                    e.EndDirectives.Add(new CodeRegionDirective(CodeRegionMode.End, "public enum " + e.Name));
                    
                    // (disabled) Hack - discard Boolean enum, it fsucks up the fragile translation code ahead.
                    //if (!e.Name.Contains("Bool"))
                    SpecTranslator.Merge(enums, e);
                }
                SpecTranslator.Merge(enums, complete_enum);
            }
            while (!sr.EndOfStream);
        }

        #endregion

        #region public static bool ListContainsConstant(List<CodeMemberField> enums, CodeMemberField c)
        public static bool ListContainsConstant(List<CodeMemberField> constants, CodeMemberField c)
        {
            foreach (CodeMemberField d in constants)
                if (d.Name == c.Name)
                    return true;
            return false;
        }
        #endregion

        #region public static Dictionary<string, CodeTypeReference> ReadTypeMap(string file)
        public static Dictionary<string, CodeTypeReference> ReadTypeMap(string file)
        {
            Dictionary<string, CodeTypeReference> map =
                new Dictionary<string, CodeTypeReference>();

            string path = Path.Combine(FilePath, file);
            StreamReader sr;

            try
            {
                sr = new StreamReader(path);
            }
            catch (Exception)
            {
                Console.WriteLine("Error opening typemap file: {0}", path);
                return null;
            }
            Console.WriteLine("Reading typemaps from file: {0}", file);

            do
            {
                string line = sr.ReadLine();

                if (String.IsNullOrEmpty(line) || line.StartsWith("#"))
                    continue;

                string[] words = line.Split(new char[] { ' ', ',', '*', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                if (words[0] == "void")
                {
                    // Special case for "void" -> ""
                    map.Add(words[0], new CodeTypeReference(String.Empty));
                }
                else if (words[0] == "VoidPointer")
                { // Special case for "VoidPointer" -> "GLvoid*"
                    map.Add(words[0], new CodeTypeReference("System.Object"));
                }
                else if (words[0] == "CharPointer" || words[0] == "charPointerARB")
                {
                    map.Add(words[0], new CodeTypeReference("System.String"));
                }
                else if (words[0].Contains("Pointer"))
	            {
                    map.Add(words[0], new CodeTypeReference(words[1], 1));
	            }
                //else if (words[1].Contains("Boolean"))
                //{
                //    // Do not add this to the typemap!
                //}
                /*else if (words[1] == "GLenum")
                {
                    // Do not throw away the type to generic GLenum. We want type checking!
                }*/
                else
                {
                    map.Add(words[0], new CodeTypeReference(words[1]));
                }
            }
            while (!sr.EndOfStream);

            return map;
        }
        #endregion
    }
}
