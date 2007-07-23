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
using System.Collections;
using System.CodeDom;

#endregion

namespace OpenTK.OpenGL.Bind
{
    #region WrapperTypes enum

    public enum WrapperTypes
    {
        /// <summary>
        /// No wrapper needed.
        /// </summary>
        None,
        /// <summary>
        /// Function takes bool parameter - C uses Int for bools, so we have to marshal.
        /// </summary>
        BoolParameter,
        /// <summary>
        /// Function takes generic parameters - add ref/out generic and generic overloads.
        /// </summary>
        GenericParameter,
        /// <summary>
        /// Function takes arrays as parameters - add ref/out and ([Out]) array overloads.
        /// </summary>
        ArrayParameter,
        /// <summary>
        /// Function with bitmask parameters. Bitmask parameters map to UInt, but since we can only use signed
        /// types (for CLS compliance), we must add the unchecked keyword.
        /// Usually found in bitmasks
        /// </summary>
        UncheckedParameter,
        /// <summary>
        /// Function that takes (in/ref/out) a naked pointer as a parameter - we pass an IntPtr.
        /// </summary>
        PointerParameter,
        /// <summary>
        /// Function returns string - needs manual marshalling through IntPtr to prevent the managed GC
        /// from freeing memory allocated on the unmanaged side (e.g. glGetString).
        /// </summary>
        StringReturnValue,
        /// <summary>
        /// Function returns a void pointer - maps to IntPtr, and the user has to manually marshal the type.
        /// </summary>
        GenericReturnValue,
        /// <summary>
        /// Function returns a typed pointer - we have to copy the data to an array to protect it from the GC.
        /// </summary>
        ArrayReturnValue
    }

    #endregion

    static class SpecTranslator
    {
        #region static SpecTranslator()
        // Do not remove! - forces BeforeFieldInit to false.
        static SpecTranslator()
        {
        }
        #endregion

        #region Fields and Properties
        public static char[] Separators = { ' ', '\n', ',', '(', ')', ';', '#' };

        #region GL types dictionary

        private static Dictionary<string, CodeTypeReference> _gl_types = SpecReader.ReadTypeMap("gl.tm");

        public static Dictionary<string, CodeTypeReference> GLTypes
        {
            get { return SpecTranslator._gl_types; }
            set { SpecTranslator._gl_types = value; }
        }

        #endregion

        #region CS types dictionary

        private static Dictionary<string, CodeTypeReference> _cs_types = SpecReader.ReadTypeMap("csharp.tm");

        public static Dictionary<string, CodeTypeReference> CSTypes
        {
            get { return SpecTranslator._cs_types; }
            set { SpecTranslator._cs_types = value; }
        }

        #endregion

        #region GLX types dictionary

        private static Dictionary<string, string> _glx_types;

        public static Dictionary<string, string> GLXTypes
        {
            get { return _glx_types; }
            set { _glx_types = value; }
        }

        #endregion

        #region WGL types dictionary

        private static Dictionary<string, string> _wgl_types;

        public static Dictionary<string, string> WGLTypes
        {
            get { return _wgl_types; }
            set { _wgl_types = value; }
        }

        #endregion
        #endregion

        #region public static List<CodeMemberMethod> TranslateDelegates(List<CodeTypeDelegate> delegates, CodeTypeDeclarationCollection enums)
        public static List<CodeMemberMethod> TranslateDelegates(List<CodeTypeDelegate> delegates, CodeTypeDeclarationCollection enums)
        {
            List<CodeMemberMethod> functions = new List<CodeMemberMethod>();
            foreach (CodeTypeDelegate d in delegates)
            {
                TranslateReturnValue(d);
                TranslateParameters(d, enums);
                functions.AddRange(CreateWrappers(d));
            }

            return functions;
        }
        #endregion

        #region private static void TranslateReturnValue(CodeTypeDelegate d)
        private static void TranslateReturnValue(CodeTypeDelegate d)
        {
            CodeTypeReference s;

            if (d.ReturnType.BaseType == "void")
                d.ReturnType.BaseType = "System.Void";

            if (GLTypes.TryGetValue(d.ReturnType.BaseType, out s))
                d.ReturnType = s;

            if (d.ReturnType.BaseType == "GLstring")
            {
                d.ReturnType = new CodeTypeReference("IntPtr");
                d.ReturnType.UserData.Add("Wrapper", WrapperTypes.StringReturnValue);
            }

            if (d.ReturnType.BaseType.ToLower().Contains("object"))
            {
                d.ReturnType.BaseType = "IntPtr";
                d.ReturnType.UserData.Add("Wrapper", WrapperTypes.GenericReturnValue);
                d.ReturnType.ArrayRank = 0;
            }

            if (d.ReturnType.BaseType == "GLenum")
            {
                d.ReturnType.BaseType = "Enums.GLenum";
            }

            if (d.ReturnType.UserData.Contains("Wrapper"))
            {
                d.UserData.Add("Wrapper", null);
            }
        }
        #endregion

        #region private static void TranslateParameters(CodeTypeDelegate d)
        private static void TranslateParameters(CodeTypeDelegate d, CodeTypeDeclarationCollection enums)
        {
            CodeTypeReference s;

            if (d.Name == "CreateShader")
            {
            }

            // Translate each parameter of the function while checking for needed wrappers:
            foreach (CodeParameterDeclarationExpression p in d.Parameters)   
            {
                if (Search(enums, p.Type.BaseType) && p.Type.BaseType != "GLenum")
                {
                    // If there is a specific enumerant entry for this parameter, then take this.
                    p.Type.BaseType = "Enums." + p.Type.BaseType;
                }
                else if (GLTypes.TryGetValue(p.Type.BaseType, out s))
                {
                    if (s.BaseType == "GLenum" && d.UserData.Contains("Category"))
                    {
                        // If there isn't, try to see if any of the generic enumerants
                        // (category: VERSION_1_1 etc) match the needed name.
                        bool found = false;
                        foreach (CodeTypeDeclaration enumerant in enums)
                        {
                            if (enumerant.Name == (string)d.UserData["Category"])
                            {
                                p.Type.BaseType = "Enums." + (string)d.UserData["Category"];
                                found = true;
                                break;
                            }
                        }

                        // If none match, then fall back to the global enum list.
                        if (!found)
                        {
                            p.Type.BaseType = "Enums.GLenum";
                        }
                    }
                    else
                    {
                        p.Type.BaseType = s.BaseType;
                    }
                }

                if (p.Type.ArrayRank == 0 && p.Type.BaseType.ToLower().Contains("enums."))
                {
                    // Do nothing
                }
                else if (p.Type.ArrayRank > 0 && p.Type.BaseType.Contains("char") ||
                        p.Type.ArrayRank == 0 && p.Type.BaseType.ToLower().Contains("string"))
                {
                    // GLchar[] parameters should become (in) string or (out) StringBuilder
                    if (p.Direction == FieldDirection.Out || p.Direction == FieldDirection.Ref)
                        p.Type = new CodeTypeReference("System.Text.StringBuilder");
                    else
                        p.Type = new CodeTypeReference("System.String");
                }
                else if (p.Type.ArrayRank > 0 && p.Type.BaseType.ToLower().Contains("string"))
                {
                    // string parameters do not need special wrappers. We add this here
                    // to simplify the next if-statements.
                    // p.Type.ArrayRank = 0;
                }
                else if (p.Type.ArrayRank > 0)
                {
                    // All other array parameters need wrappers (around IntPtr).
                    if (p.Type.BaseType.Contains("void") || p.Type.BaseType.Contains("Void"))
                    {
                        p.UserData.Add("Wrapper", WrapperTypes.GenericParameter);
                    }
                    else if (p.Type.BaseType.Contains("IntPtr"))
                    {
                        //p.UserData.Add("Wrapper", WrapperTypes.PointerParameter);
                    }
                    else
                    {
                        p.UserData.Add("Wrapper", WrapperTypes.ArrayParameter);
                        p.UserData.Add("OriginalType", new string(p.Type.BaseType.ToCharArray()));
                    }

                    // We do not want an array of IntPtrs (IntPtr[]) - it is the IntPtr that points to the array.
                    p.Type = new CodeTypeReference();
                    p.Type.BaseType = "System.IntPtr";
                    p.Type.ArrayRank = 0;
                    p.UserData.Add("Flow", p.Direction);
                    // The same wrapper works for either in or out parameters.
                    //p.CustomAttributes.Add(new CodeAttributeDeclaration("In, Out"));
                }
                else if (p.Type.BaseType.Contains("ushort") && d.Name.Contains("LineStipple"))
                {
                    // glLineStipple needs wrapper to allow large unsigned mask values.
                    p.UserData.Add("Wrapper", WrapperTypes.UncheckedParameter);
                }


                if (p.Type.BaseType.ToLower().Contains("boolean"))
                {
                    p.Type.BaseType = "System.Boolean";
                    //p.UserData.Add("Wrapper", WrapperTypes.BoolParameter);
                    p.CustomAttributes.Add(
                        new CodeAttributeDeclaration(
                        "MarshalAs",
                        new CodeAttributeArgument(new CodeSnippetExpression("UnmanagedType.Bool"))
                        )
                    );
                }

                if (p.UserData.Contains("Wrapper") && !d.UserData.Contains("Wrapper"))
                {
                    // If there is at least 1 parameter that needs wrappers, mark the funcction for wrapping.
                    d.UserData.Add("Wrapper", null);
                }

                //p.Direction = FieldDirection.In;
            }
        }
        #endregion

        #region private static bool Search(CodeTypeDeclarationCollection enums, string name)

        private static bool Search(CodeTypeDeclarationCollection enums, string name)
        {
            foreach (CodeTypeDeclaration enumerant in enums)
            {
                if (enumerant.Name == name)
                {
                    return true;
                }
            }

            return false;
        }

        #endregion

        #region private static List<CodeMemberMethod> CreateWrappers(CodeTypeDelegate d)
        private static List<CodeMemberMethod> CreateWrappers(CodeTypeDelegate d)
        {
            List<CodeMemberMethod> wrappers = new List<CodeMemberMethod>();
            CodeMemberMethod f = new CodeMemberMethod();

            // Check if a wrapper is needed:
            if (!d.UserData.Contains("Wrapper"))
            {
                // If not, add just add a function that calls the delegate.
                f = CreatePrototype(d);

                if (!f.ReturnType.BaseType.Contains("Void"))
                    f.Statements.Add(new CodeMethodReturnStatement(GenerateInvokeExpression(f)));
                else
                    f.Statements.Add(GenerateInvokeExpression(f));

                wrappers.Add(f);
            }
            else
            {
                // We have to add wrappers for all possible WrapperTypes.

                // First, check if the return type needs wrapping:
                if (d.ReturnType.UserData.Contains("Wrapper"))
                {
                    switch ((WrapperTypes)d.ReturnType.UserData["Wrapper"])
                    {
                        // If the function returns a string (glGetString) we must manually marshal it
                        // using Marshal.PtrToStringXXX. Otherwise, the GC will try to free the memory
                        // used by the string, resulting in corruption (the memory belongs to the
                        // unmanaged boundary).
                        case WrapperTypes.StringReturnValue:
                            f = CreatePrototype(d);
                            f.ReturnType = new CodeTypeReference("System.String");

                            f.Statements.Add(
                                new CodeMethodReturnStatement(
                                    new CodeMethodInvokeExpression(
                                        new CodeTypeReferenceExpression("Marshal"),
                                        "PtrToStringAnsi",
                                        new CodeExpression[] { GenerateInvokeExpression(f) }
                                    )
                                )
                            );
                            
                            wrappers.Add(f);
                            break;

                        // If the function returns a void* (GenericReturnValue), we'll have to return an IntPtr.
                        // The user will unfortunately need to marshal this IntPtr to a data type manually.
                        case WrapperTypes.GenericReturnValue:
                            f = CreatePrototype(d);

                            if (!f.ReturnType.BaseType.Contains("Void"))
                                f.Statements.Add(new CodeMethodReturnStatement(GenerateInvokeExpression(f)));
                            else
                                f.Statements.Add(GenerateInvokeExpression(f));

                            wrappers.Add(f);
                            break;
                    }
                }

                if (d.Name.Contains("LineStipple"))
                {
                    // glLineStipple accepts a GLushort bitfield. Since GLushort is mapped to Int16, not UInt16
                    // (for CLS compliance), we'll have to add the unchecked keyword.
                    f = CreatePrototype(d);

                    CodeSnippetExpression e =
                        new CodeSnippetExpression("Delegates.glLineStipple(factor, unchecked((GLushort)pattern))");
                    f.Statements.Add(e);

                    wrappers.Add(f);
                }

                WrapPointersMonsterFunctionMK2(String.IsNullOrEmpty(f.Name) ? CreatePrototype(d) : f, wrappers);
            }

            return wrappers;
        }
        #endregion

        #region private static void WrapPointersMonsterFunctionMK2(CodeTypeDelegate d, List<CodeMemberMethod> wrappers)
        // This function needs some heavy refactoring. I'm ashamed I ever wrote it, but it works...
        // What it does is this: it adds to the wrapper list all possible wrapper permutations
        // for functions that have more than one IntPtr parameter. Example:
        // "void Delegates.f(IntPtr p, IntPtr q)" where p and q are pointers to void arrays needs the following wrappers:
        // "void f(IntPtr p, IntPtr q)"
        // "void f(IntPtr p, object q)"
        // "void f(object p, IntPtr q)"
        // "void f(object p, object q)"
        private static int count = 0;
        private static void WrapPointersMonsterFunctionMK2(CodeMemberMethod f, List<CodeMemberMethod> wrappers)
        {
            if (count == 0)
            {
                bool functionContainsIntPtrParameters = false;
                // Check if there are any IntPtr parameters (we may have come here from a ReturnType wrapper
                // such as glGetString, which contains no IntPtr parameters)
                foreach (CodeParameterDeclarationExpression p in f.Parameters)
                {
                    if (p.Type.BaseType.Contains("IntPtr"))
                    {
                        functionContainsIntPtrParameters = true;
                        break;
                    }
                }

                if (functionContainsIntPtrParameters)
                {
                    wrappers.Add(IntPtrToIntPtr(f));
                }
                else
                {
                    return;
                }
            }

            if (count >= 0 && count < f.Parameters.Count)
            {
                if (f.Parameters[count].UserData.Contains("Wrapper"))
                {
                    //++count;
                    //WrapPointersMonsterFunctionMK2(d, wrappers);
                    //--count;

                    if ((WrapperTypes)f.Parameters[count].UserData["Wrapper"] == WrapperTypes.ArrayParameter)
                    {
                        ++count;
                        WrapPointersMonsterFunctionMK2(f, wrappers);
                        --count;

                        CodeMemberMethod w = IntPtrToArray(f, count);
                        wrappers.Add(w);

                        ++count;
                        WrapPointersMonsterFunctionMK2(w, wrappers);
                        --count;

                        w = IntPtrToReference(f, count);
                        wrappers.Add(w);

                        ++count;
                        WrapPointersMonsterFunctionMK2(w, wrappers);
                        --count;
                    }
                    else if ((WrapperTypes)f.Parameters[count].UserData["Wrapper"] == WrapperTypes.GenericParameter)
                    {
                        ++count;
                        WrapPointersMonsterFunctionMK2(f, wrappers);
                        --count;

                        CodeMemberMethod w = IntPtrToObject(f, count);
                        wrappers.Add(w);

                        ++count;
                        WrapPointersMonsterFunctionMK2(w, wrappers);
                        --count;
                    }
                }
                else
                {
                    ++count;
                    WrapPointersMonsterFunctionMK2(f, wrappers);
                    --count;
                }
            }
        }

        #endregion

        #region private static CodeMemberMethod IntPtrToIntPtr(CodeMemberMethod f)
        private static CodeMemberMethod IntPtrToIntPtr(CodeMemberMethod f)
        {
            CodeMemberMethod w = CreatePrototype(f);
            if (!w.ReturnType.BaseType.Contains("Void"))
            {
                w.Statements.Add(new CodeMethodReturnStatement(GenerateInvokeExpression(w)));
            }
            else
            {
                w.Statements.Add(GenerateInvokeExpression(w));
            }
            return w;
        }
        #endregion

        #region private static CodeMemberMethod IntPtrToObject(CodeMemberMethod f, int index)
        private static CodeMemberMethod IntPtrToObject(CodeMemberMethod f, int index)
        {
            CodeMemberMethod w = CreatePrototype(f);

            CodeParameterDeclarationExpression newp = new CodeParameterDeclarationExpression();
            newp.Name = f.Parameters[index].Name;
            newp.Type = new CodeTypeReference("System.Object");
            //if (newp.Flow == Parameter.FlowDirection.Out)
            //    newp.Flow = Parameter.FlowDirection.Undefined;
            w.Parameters[index] = newp;

            // In the function body we should pin all objects in memory before calling the
            // low-level function.
            w.Statements.AddRange(GenerateInvokeExpressionWithPins(w));

            return w;
        }
        #endregion

        #region private static CodeMemberMethod IntPtrToArray(CodeMemberMethod f, int index)
        // IntPtr -> GL[...] wrapper.
        private static CodeMemberMethod IntPtrToArray(CodeMemberMethod f, int index)
        {
            CodeMemberMethod w = CreatePrototype(f);

            // Search and replace IntPtr parameters with the known parameter types:
            CodeParameterDeclarationExpression newp = new CodeParameterDeclarationExpression();
            newp.Name = f.Parameters[index].Name;
            newp.Type.BaseType = (string)f.Parameters[index].UserData["OriginalType"];
            newp.Type.ArrayRank = 1;
            w.Parameters[index] = newp;

            // In the function body we should pin all objects in memory before calling the
            // low-level function.
            w.Statements.AddRange(GenerateInvokeExpressionWithPins(w));

            return w;
        }
        #endregion

        #region private static CodeMemberMethod IntPtrToReference(CodeMemberMethod f, int index)
        /// <summary>
        /// Obtain an IntPtr to the reference passed by the user.
        /// </summary>
        /// <param name="f"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        private static CodeMemberMethod IntPtrToReference(CodeMemberMethod f, int index)
        {
            CodeMemberMethod w = CreatePrototype(f);

            // Search and replace IntPtr parameters with the known parameter types:
            CodeParameterDeclarationExpression newp = new CodeParameterDeclarationExpression();
            newp.Name = f.Parameters[index].Name;
            newp.Type.BaseType = (string)f.Parameters[index].UserData["OriginalType"];
            if (f.Parameters[index].UserData.Contains("Flow") &&
                (FieldDirection)f.Parameters[index].UserData["Flow"] == FieldDirection.Out)
                newp.Direction = FieldDirection.Out;
            else
                newp.Direction = FieldDirection.Ref;
            w.Parameters[index] = newp;

            // In the function body we should pin all objects in memory before calling the
            // low-level function.
            w.Statements.AddRange(GenerateInvokeExpressionWithPins(w));

            return w;
        }
        #endregion

        #region private static CodeMemberMethod CreatePrototype(CodeTypeDelegate d)
        private static CodeMemberMethod CreatePrototype(CodeTypeDelegate d)
        {
            CodeMemberMethod f = new CodeMemberMethod();

            f.Name = Settings.GLFunctionPrepend + d.Name;
            f.Parameters.AddRange(d.Parameters);
            f.ReturnType = d.ReturnType;
            f.Attributes = MemberAttributes.Static | MemberAttributes.Public;

            //f.StartDirectives.Add(new CodeRegionDirective(CodeRegionMode.Start, f.Name));
            //f.EndDirectives.Add(new CodeRegionDirective(CodeRegionMode.End, f.Name));

            /*f.Comments.Add(new CodeCommentStatement("<summary>", true));
            f.Comments.Add(new CodeCommentStatement(" ", true));
            f.Comments.Add(new CodeCommentStatement("</summary>", true));*/

            return f;
        }
        #endregion

        #region private static CodeMemberMethod CreatePrototype(CodeMemberMethod d)
        private static CodeMemberMethod CreatePrototype(CodeMemberMethod d)
        {
            CodeMemberMethod f = new CodeMemberMethod();

            f.Name = d.Name;
            f.Parameters.AddRange(d.Parameters);
            f.ReturnType = d.ReturnType;
            f.Attributes = MemberAttributes.Static | MemberAttributes.Public;

            //f.StartDirectives.Add(new CodeRegionDirective(CodeRegionMode.Start, f.Name));
            //f.EndDirectives.Add(new CodeRegionDirective(CodeRegionMode.End, f.Name));

            foreach (object key in d.UserData.Keys)
            {
                f.UserData.Add(key, d.UserData[key]);
            }

            /*f.Comments.Add(new CodeCommentStatement("<summary>", true));
            f.Comments.Add(new CodeCommentStatement(" ", true));
            f.Comments.Add(new CodeCommentStatement("</summary>", true));*/

            return f;
        }
        #endregion

        #region private static CodeExpression GenerateInvokeExpression(CodeMemberMethod f)
        private static CodeExpression GenerateInvokeExpression(CodeMemberMethod f)
        {
            CodeVariableReferenceExpression[] parameters = new CodeVariableReferenceExpression[f.Parameters.Count];
            int i = 0;
            foreach (CodeParameterDeclarationExpression p in f.Parameters)
            {
                parameters[i++] = new CodeVariableReferenceExpression(p.Name);
            }

            return new CodeMethodInvokeExpression(
                new CodeTypeReferenceExpression("Delegates"),
                "gl" + f.Name,
                parameters
            );
        }
        #endregion

        #region private static CodeStatementCollection GenerateInvokeExpressionWithPins(CodeMemberMethod f)
        private static CodeStatementCollection GenerateInvokeExpressionWithPins(CodeMemberMethod f)
        {
            CodeVariableReferenceExpression[] parameters = new CodeVariableReferenceExpression[f.Parameters.Count];
            CodeTryCatchFinallyStatement m = new CodeTryCatchFinallyStatement();
            CodeStatementCollection statements = new CodeStatementCollection();

            int h = 0;
            int i = 0;
            foreach (CodeParameterDeclarationExpression p in f.Parameters)
            {
                // Do manual marshalling for objects and arrays, but not strings.
                if (p.Type.BaseType == "object" || p.Type.BaseType == "System.Object" ||
                   (p.Type.ArrayRank > 0 && !p.Type.BaseType.ToLower().Contains("string")) ||
                   ((p.Direction == FieldDirection.Ref || p.Direction == FieldDirection.Out) &&
                    !p.Type.BaseType.ToLower().Contains("string")))
                {
                    if (p.Direction == FieldDirection.Out)
                    {
                        statements.Add(
                            new CodeAssignStatement(
                                new CodeVariableReferenceExpression(p.Name),
                                new CodeSnippetExpression("default(" + p.Type.BaseType + ")")
                            )
                        );
                    }

                    // Pin the object and store the resulting GCHandle to h0, h1, ...
                    CodeVariableDeclarationStatement s = new CodeVariableDeclarationStatement();
                    s.Type = new CodeTypeReference("GCHandle");
                    s.Name = "h" + h;
                    s.InitExpression =
                        new CodeMethodInvokeExpression(
                            new CodeTypeReferenceExpression("GCHandle"),
                            "Alloc",
                            new CodeTypeReferenceExpression[] {
                                new CodeTypeReferenceExpression(p.Name),
                                new CodeTypeReferenceExpression("GCHandleType.Pinned")
                            }
                        );
                    statements.Add(s);

                    // Free the object using the h0, h1, ... variables
                    m.FinallyStatements.Add(
                        new CodeMethodInvokeExpression(
                            new CodeTypeReferenceExpression("h" + h),
                            "Free"
                        )
                    );

                    // Add the h(n) variable to the list of parameters
                    parameters[i] = new CodeVariableReferenceExpression("h" + h + ".AddrOfPinnedObject()");

                    // Add an assignment statement: "variable_name = (variable_type)h(n).Target" for out parameters.
                    if (p.Direction == FieldDirection.Out)
                    {
                        m.TryStatements.Add(
                            new CodeAssignStatement(
                                new CodeVariableReferenceExpression(p.Name),
                                new CodeSnippetExpression("(" + p.Type.BaseType + ")h" + h + ".Target")
                            )
                        );
                    }

                    h++;
                }
                else
                {
                    // Add the normal paramater to the parameter list
                    parameters[i] = new CodeVariableReferenceExpression(p.Name);
                }
                i++;
            }

            if (f.ReturnType.BaseType.Contains("Void"))
            {
                m.TryStatements.Insert(0,
                    new CodeExpressionStatement(
                        new CodeMethodInvokeExpression(
                            new CodeTypeReferenceExpression("Delegates"),
                            "gl" + f.Name,
                            parameters
                        )
                    )
                );
            }
            else
            {
                m.TryStatements.Insert(0, new CodeVariableDeclarationStatement(f.ReturnType, "retval"));
                m.TryStatements.Insert(1,
                    new CodeAssignStatement(
                        new CodeVariableReferenceExpression("retval"),
                        new CodeMethodInvokeExpression(
                            new CodeTypeReferenceExpression("Delegates"),
                            "gl" + f.Name,
                            parameters
                        )
                    )
                );

                m.TryStatements.Add(
                    new CodeMethodReturnStatement(new CodeVariableReferenceExpression("retval"))
                );
            }

            statements.Add(m);

            return statements;
        }
        #endregion

        #region public static CodeTypeDeclarationCollection Merge(CodeTypeDeclarationCollection list1, CodeTypeDeclarationCollection list2)
        public static CodeTypeDeclarationCollection Merge(CodeTypeDeclarationCollection list1, CodeTypeDeclarationCollection list2)
        {
            foreach (CodeTypeDeclaration d in list2)
            {
                Merge(list1, d);
            }

            return list1;
        }
        #endregion

        #region public static CodeTypeDeclarationCollection Merge(CodeTypeDeclarationCollection list, CodeTypeDeclaration item)
        public static CodeTypeDeclarationCollection Merge(CodeTypeDeclarationCollection list, CodeTypeDeclaration item)
        {
            bool t_exists = false;
            foreach (CodeTypeDeclaration d in list)
            {
                if (d.Name == item.Name)
                {
                    t_exists = true;
                    foreach (CodeTypeMember m in item.Members)
                    {
                        Merge(d.Members, m);
                    }
                }
            }

            if (!t_exists)
            {
                list.Add(item);
            }

            return list;
        }
        #endregion

        #region public static CodeTypeMemberCollection Merge(CodeTypeMemberCollection list, CodeTypeMember item)
        public static CodeTypeMemberCollection Merge(CodeTypeMemberCollection list, CodeTypeMember item)
        {
            bool t_exists = false;
            foreach (CodeTypeMember d in list)
            {
                if (d.Name == item.Name)
                {
                    t_exists = true;
                }
            }

            if (!t_exists)
            {
                list.Add(item);
            }

            return list;
        }
        #endregion

        #region public static CodeTypeDeclarationCollection TranslateEnums(CodeTypeDeclarationCollection enums)
        public static CodeTypeDeclarationCollection TranslateEnums(CodeTypeDeclarationCollection enums)
        {
            // Add missing enums.
            {
                CodeTypeDeclaration e = new CodeTypeDeclaration("SGIX_icc_texture");
                e.IsEnum = true;
                CodeMemberField c;
                c = new CodeMemberField(); c.Name = "RGB_ICC_SGIX"; c.InitExpression = new CodeFieldReferenceExpression(null, "0x8460"); e.Members.Add(c);
                c = new CodeMemberField(); c.Name = "RGBA_ICC_SGIX"; c.InitExpression = new CodeFieldReferenceExpression(null, "0x8461"); e.Members.Add(c);
                c = new CodeMemberField(); c.Name = "ALPHA_ICC_SGIX"; c.InitExpression = new CodeFieldReferenceExpression(null, "0x8462"); e.Members.Add(c);
                c = new CodeMemberField(); c.Name = "LUMINANCE_ICC_SGIX"; c.InitExpression = new CodeFieldReferenceExpression(null, "0x8463"); e.Members.Add(c);
                c = new CodeMemberField(); c.Name = "INTENSITY_ICC_SGIX"; c.InitExpression = new CodeFieldReferenceExpression(null, "0x8464"); e.Members.Add(c);
                c = new CodeMemberField(); c.Name = "LUMINANCE_ALPHA_ICC_SGIX"; c.InitExpression = new CodeFieldReferenceExpression(null, "0x8465"); e.Members.Add(c);
                c = new CodeMemberField(); c.Name = "R5_G6_B5_ICC_SGIX"; c.InitExpression = new CodeFieldReferenceExpression(null, "0x8466"); e.Members.Add(c);
                c = new CodeMemberField(); c.Name = "R5_G6_B5_A8_ICC_SGIX"; c.InitExpression = new CodeFieldReferenceExpression(null, "0x8467"); e.Members.Add(c);
                c = new CodeMemberField(); c.Name = "ALPHA16_ICC_SGIX"; c.InitExpression = new CodeFieldReferenceExpression(null, "0x8468"); e.Members.Add(c);
                c = new CodeMemberField(); c.Name = "LUMINANCE16_ICC_SGIX"; c.InitExpression = new CodeFieldReferenceExpression(null, "0x8469"); e.Members.Add(c);
                c = new CodeMemberField(); c.Name = "INTENSITY16_ICC_SGIX"; c.InitExpression = new CodeFieldReferenceExpression(null, "0x846A"); e.Members.Add(c);
                c = new CodeMemberField(); c.Name = "LUMINANCE16_ALPHA8_ICC_SGIX"; c.InitExpression = new CodeFieldReferenceExpression(null, "0x846B"); e.Members.Add(c);
                
                enums.Add(e);
            }

            // Translate enums.
            foreach (CodeTypeDeclaration e in enums)
            {
                if (Char.IsDigit(e.Name[0]))
                    e.Name = e.Name.Insert(0, "_");

                if (e.Name == "Boolean")
                    continue;

                foreach (CodeMemberField c in e.Members)
                {
                    // Prepend an '_' if the first letter is a number (e.g. 4_BYTES -> _4_BYTES)
                    if (Char.IsDigit(c.Name[0]))
                        c.Name = c.Name.Insert(0, "_");

                    if (c.UserData["FieldReference"] == null)
                        continue;

                    c.UserData["ObjectReference"] = GetTranslatedEnum((string)c.UserData["ObjectReference"]);
                    c.UserData["FieldReference"] = GetTranslatedEnum((string)c.UserData["FieldReference"]);

                    // There are cases when a value is not a number but an aliased constant, with no enum specified.
                    // In this case try searching all enums for the correct constant to alias (stupid opengl specs).
                    if (c.UserData["ObjectReference"] == null &&
                        !((string)c.UserData["FieldReference"]).StartsWith("0x") &&
                        !Char.IsDigit(((string)c.UserData["FieldReference"])[0]))
                    {
                        if (((string)c.UserData["FieldReference"]).StartsWith("GL_"))
                            c.UserData["FieldReference"] = ((string)c.UserData["FieldReference"]).Substring(3);

                        foreach (CodeTypeDeclaration enumerant in enums)
                        {
                            foreach (CodeTypeMember member in enumerant.Members)
                            {
                                if (member.Name == (string)c.UserData["FieldReference"] ||
                                    member.Name == ((string)c.UserData["FieldReference"]).TrimStart('_'))
                                {
                                    c.UserData["ObjectReference"] = enumerant.Name;
                                }
                            }
                        }
                    }

                    c.InitExpression =
                        new CodeFieldReferenceExpression(
                            c.UserData["ObjectReference"] == null ? null : new CodeSnippetExpression((string)c.UserData["ObjectReference"]),
                            (string)c.UserData["FieldReference"]
                        );
                }
            }

            return enums;
        }
        #endregion

        #region public static string GetTranslatedEnum(string name)
        public static string GetTranslatedEnum(string name)
        {
            int useless;

            if (String.IsNullOrEmpty(name))
                return null;

            // Check if the name starts with a number, and prepend a "_" if yes.
            if (!name.StartsWith("0x") && 
                !Int32.TryParse(name, out useless) &&
                Char.IsDigit(name[0]))
            {
                return name.Insert(0, "_");
            }

            if (name == "LightProperty")
            {
                return "LightParameter";
            }

            return name;
        }
        #endregion
    }
}
