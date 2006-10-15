#region License
//Copyright (c) 2006 Stephen Apostolopoulos
//See license.txt for license info
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace OpenTK.OpenGL.Bind
{
    #region WrapperTypes enum

    public enum WrapperTypes
    {
        None,
        VoidArray,
        Array,
        UncheckedParameter,
        ReturnsString,
        ReturnsVoidPointer,
    }

    #endregion

    static class Translation
    {
        public static char[] Separators = { ' ', '\n', ',', '(', ')', ';', '#' };

        #region Dictionaries

        static Dictionary<string, string> parameter_names = new Dictionary<string, string>();

        #region GL types dictionary

        private static Dictionary<string, string> _gl_types;

        public static Dictionary<string, string> GLTypes
        {
            get { return Translation._gl_types; }
            set { Translation._gl_types = value; }
        }

        #endregion

        #region CS types dictionary

        private static Dictionary<string, string> _cs_types;

        public static Dictionary<string, string> CSTypes
        {
            get { return Translation._cs_types; }
            set { Translation._cs_types = value; }
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

        #region Constructor

        static Translation()
        {
            // Names
            parameter_names.Add("base", "@base");
            parameter_names.Add("object", "@object");
            parameter_names.Add("string", "@string");
            parameter_names.Add("ref", "reference");
            parameter_names.Add("params", "parameters");
            parameter_names.Add("in", "@in");
            parameter_names.Add("class", "@class");
        }

        #endregion

        #region Translate enums

        public static void TranslateEnums(System.Collections.Hashtable enums)
        {
            // Add missing enums.
            {
                Enum e = new Enum();
                Constant c;
                e.Name = "SGIX_icc_texture";
                c = new Constant("RGB_ICC_SGIX", "0x8460"); e.ConstantCollection.Add(c.Name, c);
                c = new Constant("RGBA_ICC_SGIX", "0x8461"); e.ConstantCollection.Add(c.Name, c);
                c = new Constant("ALPHA_ICC_SGIX", "0x8462"); e.ConstantCollection.Add(c.Name, c);
                c = new Constant("LUMINANCE_ICC_SGIX", "0x8463"); e.ConstantCollection.Add(c.Name, c);
                c = new Constant("INTENSITY_ICC_SGIX", "0x8464"); e.ConstantCollection.Add(c.Name, c);
                c = new Constant("LUMINANCE_ALPHA_ICC_SGIX", "0x8465"); e.ConstantCollection.Add(c.Name, c);
                c = new Constant("R5_G6_B5_ICC_SGIX", "0x8466"); e.ConstantCollection.Add(c.Name, c);
                c = new Constant("R5_G6_B5_A8_ICC_SGIX", "0x8467"); e.ConstantCollection.Add(c.Name, c);
                c = new Constant("ALPHA16_ICC_SGIX", "0x8468"); e.ConstantCollection.Add(c.Name, c);
                c = new Constant("LUMINANCE16_ICC_SGIX", "0x8469"); e.ConstantCollection.Add(c.Name, c);
                c = new Constant("INTENSITY16_ICC_SGIX", "0x846A"); e.ConstantCollection.Add(c.Name, c);
                c = new Constant("LUMINANCE16_ALPHA8_ICC_SGIX", "0x846B"); e.ConstantCollection.Add(c.Name, c);

                enums.Add(e.Name, e);
            }

            // Translate enums.
            foreach (Enum e in enums.Values)
            {
                if (Char.IsDigit(e.Name[0]))
                    e.Name = e.Name.Insert(0, "_");

                if (e.Name == "Boolean")
                    continue;

                foreach (Constant c in e.ConstantCollection.Values)
                {
                    // Prepend an '_' if the first letter is a number (e.g. 4_BYTES -> _4_BYTES)
                    if (Char.IsDigit(c.Name[0]))
                        c.Name = c.Name.Insert(0, "_");

                    // Prepend an '_' to the aliased value, if it starts with a number (e.g. DataType.4_BYTES -> DataType._4_BYTES)
                    if (c.Value.Contains(".") && Char.IsDigit(c.Value[c.Value.IndexOf('.') + 1]))
                        c.Value = c.Value.Insert(c.Value.IndexOf('.') + 1, "_");

                    // There are cases when a value is not a number but an aliased constant, with no enum specified.
                    // In this case try searching all enums for the correct constant to alias (stupid opengl group).
                    if (!c.Value.Contains(".") && !c.Value.StartsWith("0x") && !Char.IsDigit(c.Value[0]))
                    {
                        if (c.Value.StartsWith("GL_"))
                            c.Value = c.Value.TrimStart('G', 'L', '_');

                        if (Char.IsDigit(c.Value[0]))
                            c.Value = c.Value.Insert(0, "_");

                        foreach (Enum search_enum in enums.Values)
                            foreach (Constant search_constant in search_enum.ConstantCollection.Values)
                                if (search_constant.Name == c.Value || search_constant.Name == c.Value.TrimStart('_'))
                                    c.Value = c.Value.Insert(0, search_enum.Name + ".");
                    }

                    // Handle enum.spec bugs:
                    if (c.Value.Contains("LightProperty"))
                        c.Value = c.Value.Replace("LightProperty", "LightParameter");
                }
            }


        }

        #endregion

        #region Translate functions

        public static void TranslateFunctions(List<Function> functions, Hashtable enums, out List<Function> wrappers)
        {
            foreach (Function f in functions)
            {
                TranslateReturnValue(f, enums);
                TranslateParameters(f, enums);

                if (f.NeedsWrapper)
                    f.Name = f.Name + "_";
            }

            wrappers = GenerateWrappers(functions);
        }

        #region Translate return value

        private static void TranslateReturnValue(Function f, Hashtable enums)
        {
            string s;

            if (f.ReturnValue == "void")
                return;

            if (GLTypes.TryGetValue(f.ReturnValue, out s))
                f.ReturnValue = s;

            if (f.ReturnValue == "void[]")
            {
                f.NeedsWrapper = true;
                f.WrapperType = WrapperTypes.ReturnsVoidPointer;
                f.ReturnValue = "IntPtr";
            }

            if (f.ReturnValue == "GLstring")
            {
                f.NeedsWrapper = true;
                f.WrapperType = WrapperTypes.ReturnsString;
                f.ReturnValue = "IntPtr";
            }
        }

        #endregion

        #region Translate parameters

        private static void TranslateParameters(Function f, Hashtable enums)
        {
            string s;

            foreach (Parameter p in f.Parameters)   // Translate each parameter of the function, and check for needed wrappers.
            {
                #region Translate parameter name

                if (parameter_names.TryGetValue(p.Name, out s))
                    p.Name = s;

                #endregion

                #region Translate parameter type

                //if (p.Type.Contains("Boolean"))
                //{
                //    p.Type = "GLboolean";
                //}
                if (enums.ContainsKey(p.Type))
                {
                    p.Type = "Enums." + p.Type;
                }
                else if (p.Type == "GLenum")
                {
                    if (enums.ContainsKey(f.Category))
                        p.Type = "Enums." + f.Category;
                }
                else if (GLTypes.TryGetValue(p.Type, out s))
                    p.Type = s;


                #endregion

                #region Check for needed wrappers

                if (p.Type.Contains("ushort") && f.Name.Contains("LineStipple"))    // glLineStipple needs wrapper to allow for unchecked mask values.
                {
                    p.NeedsWrapper = true;
                    p.WrapperType = WrapperTypes.UncheckedParameter;
                    p.Unchecked = true;
                }
                else if (p.Array && p.Type.Contains("string"))  // string parameters do not need special wrappers.
                {
                    p.NeedsWrapper = false;
                    p.WrapperType = WrapperTypes.None;
                }
                else if (p.Array && p.Type.Contains("char"))    // GLchar[] parameters should become (in) string or (out) StringBuilder
                {
                    if (p.Flow == Parameter.FlowDirection.Out)
                        p.Type = "StringBuilder";
                    else
                        p.Type = "string";
                    p.Array = false;
                }
                else if (p.Array)                               // All other array parameters need wrappers (around IntPtr).
                {
                    p.NeedsWrapper = true;

                    if (p.Type.Contains("void"))
                        p.WrapperType = WrapperTypes.VoidArray;
                    else
                        p.WrapperType = WrapperTypes.Array;

                    p.Type = "IntPtr";
                    p.Array = false;    // We do not want an array of IntPtrs (IntPtr[]) - it is the IntPtr that points to the array.
                    p.Flow = Parameter.FlowDirection.Undefined; // The same wrapper works for either in or out parameters.
                }

                if (p.NeedsWrapper)     // If there is at least 1 parameter that needs wrappers, mark the funcction for wrapping.
                {
                    f.NeedsWrapper = true;
                    f.WrapperType = p.WrapperType;
                }

                #endregion
            }
        }

        #endregion

        #region Generate wrappers

        private static List<Function> GenerateWrappers(List<Function> functions)
        {
            List<Function> wrappers = new List<Function>();
            Function w;

            foreach (Function f in functions)
            {
                if (f.NeedsWrapper)
                {
                    if (f.WrapperType == WrapperTypes.UncheckedParameter)
                    {
                        w = new Function(f);
                        w.Name = w.Name.TrimEnd('_');

                        // Search and replace ushort parameters with ints.
                        Predicate<Parameter> is_ushort_parameter = new Predicate<Parameter>(delegate(Parameter p) { return p.Type == "GLushort"; });
                        Parameter oldp = w.Parameters.Find(is_ushort_parameter);
                        Parameter newp = new Parameter(oldp);
                        newp.Type = "GLint";
                        w.Parameters = w.Parameters.ReplaceAll(oldp, newp);

                        // Call the low-level function wrapping (all parameters marked with Unchecked will automatically
                        // be decorated with the unchecked keyword).
                        w.Body.Add((f.ReturnValue.Contains("void") ? "" : "return ") + f.CallString() + ";");

                        // Add the wrapper.
                        wrappers.Add(w);

                        continue;
                    }

                    if (f.WrapperType == WrapperTypes.ReturnsString)
                    {
                        w = new Function(f);
                        w.Name = w.Name.TrimEnd('_');

                        // Replace the IntPtr return value with string.
                        w.ReturnValue = "string";

                        // Wrap the call to the low-level function (marshal the IntPtr to string).
                        w.Body.Add("return Marshal.PtrToStringAnsi(" + f.CallString() + ");");

                        // Add the wrapper.
                        wrappers.Add(w);

                        continue;
                    }

                    //if (
                    WrapPointers(f, wrappers);
                    count = 0;
                }
            }

            return wrappers;
        }

        static int count = 0;
        private static void WrapPointers(Function f, List<Function> wrappers)
        {
            if (count == 0)
            {
                wrappers.Add(IntPtrToIntPtr(f));
            }

            if (count >= 0 && count < f.Parameters.Count)
            {
                if (f.Parameters[count].NeedsWrapper)
                {
                    ++count;
                    WrapPointers(f, wrappers);
                    --count;

                    Function w = IntPtrToObject(f, count);
                    wrappers.Add(w);

                    ++count;
                    WrapPointers(w, wrappers);
                    --count;

                    if (f.Parameters[count].WrapperType == WrapperTypes.Array)
                    {
                        w = IntPtrToArray(f, count);
                        wrappers.Add(w);

                        ++count;
                        WrapPointers(w, wrappers);
                        --count;
                    }
                }
                else
                {
                    ++count;
                    WrapPointers(f, wrappers);
                    --count;
                }
            }
        }

        // IntPtr -> IntPtr wrapper.
        private static Function IntPtrToIntPtr(Function f)
        {
            Function w = new Function(f);
            w.Name = w.Name.TrimEnd('_');

            w.Body.Add((f.ReturnValue.Contains("void") ? "" : "return ") + f.CallString() + ";");
            return w;
        }

        // IntPtr -> object wrapper.
        private static Function IntPtrToObject(Function f, int index)
        {
            Function w = new Function(f);
            w.Name = w.Name.TrimEnd('_');

            Parameter newp = new Parameter(f.Parameters[index]);
            newp.Type = "object";
            if (newp.Flow == Parameter.FlowDirection.Out)
                newp.Flow = Parameter.FlowDirection.Undefined;
            w.Parameters = w.Parameters.Replace(f.Parameters[index], newp);

            // In the function body we should pin all objects in memory before calling the
            // low-level function.
            w.Body = GenerateBodyForPins(w);

            return w;
        }
        
        // IntPtr -> GL[...] wrapper.
        private static Function IntPtrToArray(Function f, int index)
        {
            Function w = new Function(f);
            w.Name = w.Name.TrimEnd('_');
            
            // Search and replace IntPtr parameters with the know parameter types:
            Parameter newp = new Parameter(f.Parameters[index]);
            newp.Type = f.Parameters[index].PreviousType;
            newp.Array = true;
            w.Parameters = w.Parameters.Replace(f.Parameters[index], newp);

            // In the function body we should pin all objects in memory before calling the
            // low-level function.
            w.Body = GenerateBodyForPins(w);

            return w;
        }

        private static FunctionBody GenerateBodyForPins(Function w)
        {

            FunctionBody body = new FunctionBody();

            int i = 0;
            StringBuilder sb = new StringBuilder();
            sb.Append("(");
            foreach (Parameter p in w.Parameters)
            {
                if (p.Type == "object" || p.Array && !p.Type.Contains("string")) // we should allow the default marshalling behavior for strings.
                {
                    body.Add("GCHandle h" + i + " = GCHandle.Alloc(" + p.Name + ", GCHandleType.Pinned);");
                    sb.Append("h" + i + ".AddrOfPinnedObject()" + ", ");
                    i++;
                }
                else
                {
                    sb.Append(p.Name + ", ");
                }
            }
            sb.Replace(", ", ")", sb.Length - 2, 2);

            body.Add("try");
            body.Add("{");
            body.Add(
                "    " +
                (w.ReturnValue.Contains("void") ? "" : "return ") +
                w.Name + "_" +
                sb.ToString() +
                ";");
            body.Add("}");
            body.Add("finally");
            body.Add("{");
            while (i > 0)
            {
                body.Add("    h" + --i + ".Free();");
            }
            body.Add("}");

            return body;
        }

        #endregion

        #endregion
    }
}
