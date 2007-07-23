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
using System.Runtime.InteropServices;
using System.CodeDom;

#endregion

namespace OpenTK.OpenGL.Bind
{
    static class SpecWriter
    {
        #region internal class CodeTypeNameComparer<T> : Comparer<T> where T : CodeTypeMember
        internal class CodeTypeNameComparer<T> : Comparer<T> where T : CodeTypeMember
        {
            public override int Compare(T x, T y)
            {
                return x.Name.CompareTo(y.Name);
            }
        }
        #endregion

        #region Generate

        public static void Generate(
            List<CodeTypeDelegate> delegates,
            List<CodeMemberMethod> functions,
            CodeTypeDeclarationCollection enums
        )
        {
            if (!Directory.Exists(Settings.OutputPath))
                Directory.CreateDirectory(Settings.OutputPath);

            CodeNamespace ns = new CodeNamespace(Settings.OutputNamespace);

            ns.Imports.Add(new CodeNamespaceImport("System"));
            ns.Imports.Add(new CodeNamespaceImport("System.Runtime.InteropServices"));
            ns.Imports.Add(new CodeNamespaceImport("System.Text"));
            //ns.Imports.Add(new CodeNamespaceImport(Settings.OutputNamespace + ".Enums"));

            foreach (string key in SpecTranslator.CSTypes.Keys)
            {
                ns.Imports.Add(new CodeNamespaceImport(key + " = System." + SpecTranslator.CSTypes[key].BaseType));
            }

            functions.Sort(new CodeTypeNameComparer<CodeMemberMethod>());
            delegates.Sort(new CodeTypeNameComparer<CodeTypeDelegate>());


            ns.Types.Add(GenerateGLClass(functions));
            ns.Types.Add(GenerateDelegatesClass(delegates));
            ns.Types.Add(GenerateImportsClass(delegates));

            CodeCompileUnit cu = new CodeCompileUnit();

            cu.StartDirectives.Add(new CodeDirective());
            cu.Namespaces.Add(ns);

            using (StreamWriter sw = new StreamWriter(Path.Combine(Settings.OutputPath, Settings.GLClass + ".cs"), false))
            {
                Console.WriteLine("Writing {0} class", Settings.OutputNamespace + "." + Settings.GLClass);

                Microsoft.CSharp.CSharpCodeProvider cs = new Microsoft.CSharp.CSharpCodeProvider();
                System.CodeDom.Compiler.CodeGeneratorOptions options = new System.CodeDom.Compiler.CodeGeneratorOptions();
                options.BracingStyle = "C";
                options.BlankLinesBetweenMembers = false;
                options.VerbatimOrder = true;

                cs.GenerateCodeFromCompileUnit(cu, sw, options);

                sw.Flush();
            }

            ns.Name = Settings.OutputNamespace + ".Enums";
            ns.Imports.Clear();
            ns.Imports.Add(new CodeNamespaceImport("System"));
            ns.Types.Clear();
            //enums.Sort(new CodeTypeNameComparer<CodeTypeDeclaration>());
            //CodeTypeDeclaration d = new CodeTypeDeclaration("Enums");
            //d.IsStruct = true;
            //d.Members.AddRange(enums);
            //ns.Types.Add(d);
            ns.Types.AddRange(enums);

            using (StreamWriter sw = new StreamWriter(Path.Combine(Settings.OutputPath, Settings.GLClass + "enums.cs"), false))
            {
                Console.WriteLine("Writing {0} enums", Settings.OutputNamespace + "." + Settings.GLClass);

                Microsoft.CSharp.CSharpCodeProvider cs = new Microsoft.CSharp.CSharpCodeProvider();
                System.CodeDom.Compiler.CodeGeneratorOptions options = new System.CodeDom.Compiler.CodeGeneratorOptions();
                options.BracingStyle = "C";
                options.BlankLinesBetweenMembers = false;
                options.VerbatimOrder = true;

                cs.GenerateCodeFromCompileUnit(cu, sw, options);

                sw.Flush();
            }
        }

        #endregion

        #region private static CodeTypeDeclaration GenerateGLClass(List<CodeMemberMethod> functions, List<CodeMemberField> enums)
        private static CodeTypeDeclaration GenerateGLClass(List<CodeMemberMethod> functions)
        {
            CodeTypeDeclaration gl_class = new CodeTypeDeclaration(Settings.GLClass);
            gl_class.IsClass = true;
            gl_class.IsPartial = true;
            gl_class.TypeAttributes = System.Reflection.TypeAttributes.Public;

            gl_class.StartDirectives.Add(new CodeRegionDirective(CodeRegionMode.Start, "GL class"));
            gl_class.EndDirectives.Add(new CodeRegionDirective(CodeRegionMode.End, "GL class"));

            gl_class.Members.Add(new CodeSnippetTypeMember("        #pragma warning disable 1591"));

            gl_class.Members.Add(new CodeSnippetTypeMember(
@"
        #region Private Constants

        #region string GL_NATIVE_LIBRARY
        /// <summary>
        /// Specifies OpenGl's native library archive.
        /// </summary>
        /// <remarks>
        /// Specifies opengl32.dll everywhere; will be mapped via .config for mono.
        /// </remarks>
        internal const string GL_NATIVE_LIBRARY = ""opengl32.dll"";
        #endregion string GL_NATIVE_LIBRARY

        #endregion Private Constants
"));
            /*
            if (constants.Count > 0)
            {
                constants[0].StartDirectives.Add(new CodeRegionDirective(CodeRegionMode.Start, "OpenGL constants"));
                constants[constants.Count - 1].EndDirectives.Add(new CodeRegionDirective(CodeRegionMode.End, "OpenGL constants"));
            }
            gl_class.Members.AddRange(constants.ToArray());
            */
            if (functions.Count > 0)
            {
                functions[0].StartDirectives.Add(new CodeRegionDirective(CodeRegionMode.Start, "OpenGL functions"));
                functions[functions.Count - 1].EndDirectives.Add(new CodeRegionDirective(CodeRegionMode.End, "OpenGL functions"));
            }
            gl_class.Members.AddRange(functions.ToArray());

            return gl_class;
        }                 
        #endregion

        #region private static CodeTypeDeclaration GenerateDelegatesClass(List<CodeTypeDelegate> delegates)
        private static CodeTypeDeclaration GenerateDelegatesClass(List<CodeTypeDelegate> delegates)
        {
            CodeTypeDeclaration delegate_class = new CodeTypeDeclaration("Delegates");
            delegate_class.TypeAttributes = System.Reflection.TypeAttributes.NotPublic;

            CodeStatementCollection statements = new CodeStatementCollection();

            foreach (CodeTypeDelegate d in delegates)
            {
                // Hack - turn FieldDirection.Out parameters to FieldDirection.In. The parameter flow
                // is handle by the [In, Out()] parameter attribute.
                foreach (CodeParameterDeclarationExpression p in d.Parameters)
                {
                    p.Direction = FieldDirection.In;
                }
                delegate_class.Members.Add(d);

                CodeMemberField m = new CodeMemberField();
                m.Name = "gl" + d.Name;
                m.Type = new CodeTypeReference(d.Name);
                m.Attributes = MemberAttributes.Public | MemberAttributes.Static;
                
                //m.InitExpression =
                    //new CodeCastExpression(
                    //    "Delegates." + d.Name,
                    //    new CodeMethodInvokeExpression(
                    //        new CodeMethodReferenceExpression(
                    //            new CodeTypeReferenceExpression(Properties.Bind.Default.OutputClass),
                    //            "GetDelegateForExtensionMethod"
                    //        ),
                    //        new CodeExpression[] { 
                    //            new CodeSnippetExpression("\"gl" + d.Name + "\""),
                    //            new CodeTypeOfExpression("Delegates." + d.Name)
                    //        }
                    //    )
                    //);

                // Hack - generate inline initialisers in the form:
                // public static Accum glAccum = GetDelegate[...] ?? new Accum(Imports.Accum);
                CodeSnippetExpression expr = new CodeSnippetExpression();
                //expr.Value = "public static " + d.Name + " gl" + d.Name + " = ";
                expr.Value +=
                    "((" + d.Name + ")(" + Settings.GLClass +".GetDelegateForExtensionMethod(\"" + "gl" + d.Name + "\", typeof(" + d.Name + "))))";
                if (d.UserData.Contains("Extension") && !(bool)d.UserData["Extension"])
                {
                    expr.Value += " ?? ";
                    expr.Value += "new " + d.Name + "(Imports." + d.Name + ")";
                }

                m.InitExpression = expr;
                delegate_class.Members.Add(m);

                /*
                if (!(bool)d.UserData["Extension"])
                {
                    statements.Add(
                        new CodeSnippetExpression(
                            "Delegates.gl" + d.Name + " = Delegates.gl" + d.Name + " ?? new Delegates." + d.Name + "(Imports." + d.Name + ")"
                        )
                    );
                }
                */
            }

            // Disable BeforeFieldInit attribute and initialize OpenGL core.
            CodeTypeConstructor con = new CodeTypeConstructor();
            //con.Statements.AddRange(statements);
            delegate_class.Members.Add(con);

            delegate_class.StartDirectives.Add(new CodeRegionDirective(CodeRegionMode.Start, delegate_class.Name));
            delegate_class.EndDirectives.Add(new CodeRegionDirective(CodeRegionMode.End, delegate_class.Name));

            return delegate_class;
        }
        #endregion

        #region private static CodeTypeDeclaration GenerateImportsClass(List<CodeTypeDelegate> delegates)
        private static CodeTypeDeclaration GenerateImportsClass(List<CodeTypeDelegate> delegates)
        {
            CodeTypeDeclaration import_class = new CodeTypeDeclaration("Imports");
            import_class.TypeAttributes = System.Reflection.TypeAttributes.NotPublic;
            import_class.Members.Add(new CodeTypeConstructor());

            foreach (CodeTypeDelegate d in delegates)
            {
                if (!(bool)d.UserData["Extension"])
                {
                    CodeMemberMethodImport m = new CodeMemberMethodImport();
                    
                    m.Name = d.Name;
                    m.CustomAttributes.Add(new CodeAttributeDeclaration("System.Security.SuppressUnmanagedCodeSecurity()"));
                    m.CustomAttributes.Add(
                        new CodeAttributeDeclaration(
                            "DllImport(" + Settings.GLClass + ".GL_NATIVE_LIBRARY, EntryPoint = \"" + "gl" + m.Name + "\", ExactSpelling = true)"
                            )
                        );
                    m.Parameters.AddRange(d.Parameters);
                    m.ReturnType = d.ReturnType;

                    import_class.Members.Add(new CodeSnippetTypeMember(m.Text));
                    
                }
            }

            import_class.StartDirectives.Add(new CodeRegionDirective(CodeRegionMode.Start, import_class.Name));
            import_class.EndDirectives.Add(new CodeRegionDirective(CodeRegionMode.End, import_class.Name));

            return import_class;
        }
        #endregion
    }

    #region class CodeMemberMethodImport : CodeMemberMethod
    /// <summary>
    /// A hack to create the C# code for a DllImported function;
    /// CodeDom does not directly support static extern methods.
    /// </summary>
    class CodeMemberMethodImport : CodeMemberMethod
    {
        public string Text
        {
            get
            {
                string s;
                //m.Attributes = MemberAttributes.Static | MemberAttributes.Public;
                s = "        #region " + this.Name + Environment.NewLine;
                s += "        [System.Security.SuppressUnmanagedCodeSecurity()]" + Environment.NewLine;
                s += "        [DllImport(" + Settings.GLClass + ".GL_NATIVE_LIBRARY, EntryPoint = \"" + "gl" + this.Name + "\", ExactSpelling = true)]" + Environment.NewLine;
                s += "        public extern static ";
                if (this.ReturnType.BaseType == "System.Void")
                {
                    s += "void";
                }
                else
                {
                    s += this.ReturnType.BaseType;
                }

                s += " " + this.Name + "(";
                foreach (CodeParameterDeclarationExpression p in this.Parameters)
                {
                    s += p.Type.BaseType;
                    if (p.Type.ArrayRank > 0)
                        s += "[]";
                    s += " ";
                    if (p.Name == "base")
                        s += "@base";
                    else if (p.Name == "params")
                        s += "@params";
                    else if (p.Name == "string")
                        s += "@string";
                    else if (p.Name == "ref")
                        s += "@ref";
                    else
                        s += p.Name;
                    s += ", ";
                }
                s = s.TrimEnd(',', ' ') + ");" + Environment.NewLine;
                s += "        #endregion" + Environment.NewLine;

                return s;
            }
        }
    }
    #endregion
}
