/* Copyright (c) 2006 Stephen Apostolopoulos
 * See license.txt for license info
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace OpenTK.OpenGL.Bind
{
    static class Translation
    {
        public static char[] Separators = { ' ', '\n', ',', '(', ')', ';', '#' };

        #region Dictionaries

        static Dictionary<string, string> parameter_names = new Dictionary<string, string>();
        //static Dictionary<string, string> parameter_types = new Dictionary<string, string>();

        private static Dictionary<string, string> _gl_types;
        public static Dictionary<string, string> GLtypes
        {
            get { return Translation._gl_types; }
            set { Translation._gl_types = value; }
        }

        private static Dictionary<string, string> _cs_types;

        public static Dictionary<string, string> CStypes
        {
            get { return Translation._cs_types; }
            set { Translation._cs_types = value; }
        }

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

            #region Commented out
            
            //// Types
            //parameter_types.Add("Boolean", "bool");
            //parameter_types.Add("BooleanPointer", "bool[]");
            //parameter_types.Add("Char", "char");
            //parameter_types.Add("CharPointer", "string");

            //parameter_types.Add("CheckedFloat32", "float");
            //parameter_types.Add("CheckedInt32", "int");

            //parameter_types.Add("ClampedColorF", "float");
            //parameter_types.Add("ClampedFloat32", "float");
            //parameter_types.Add("ClampedFloat64", "double");
            //parameter_types.Add("ClampedStencilValue", "int");

            //parameter_types.Add("ColorB", "byte");
            //parameter_types.Add("ColorS", "short");
            //parameter_types.Add("ColorI", "int");
            //parameter_types.Add("ColorUB", "byte");
            //parameter_types.Add("ColorUS", "ushort");
            //parameter_types.Add("ColorUI", "uint");
            //parameter_types.Add("ColorF", "float");
            //parameter_types.Add("ColorD", "double");

            //parameter_types.Add("ColorIndexValueD", "double");
            //parameter_types.Add("ColorIndexValueF", "float");
            //parameter_types.Add("ColorIndexValueI", "int");
            //parameter_types.Add("ColorIndexValueS", "short");
            //parameter_types.Add("ColorIndexValueUB", "byte");

            //parameter_types.Add("CompressedTextureARB", "void");
            //parameter_types.Add("ControlPointNV", "void");

            //parameter_types.Add("CoordF", "float");
            //parameter_types.Add("CoordD", "double");
            //parameter_types.Add("CoordI", "int");
            //parameter_types.Add("CoordS", "short");

            //parameter_types.Add("FeedbackElement", "float");
            //parameter_types.Add("FenceNV", "uint");

            ///////////////////////////////////////
            //parameter_types.Add("Int8", "byte");
            //parameter_types.Add("Int16", "short");
            //parameter_types.Add("Int32", "int");
            //parameter_types.Add("UInt8", "byte");
            //parameter_types.Add("UInt16", "ushort");
            //parameter_types.Add("UInt32", "uint");
            //parameter_types.Add("Float32", "float");
            //parameter_types.Add("Float64", "double");

            //parameter_types.Add("ConstFloat32", "float");
            //parameter_types.Add("ConstInt32", "double");
            //parameter_types.Add("ConstUInt32", "uint");
            //parameter_types.Add("ConstVoid", "void");
            //parameter_types.Add("ConstVoidPointer", "void[]");
            
            //parameter_types.Add("String", "string");
            //parameter_types.Add("Void", "void");
            //parameter_types.Add("VoidPointer", "void[]");
            //parameter_types.Add("void", "void");
            
            //parameter_types.Add("Float32Pointer", "float");
            //parameter_types.Add("Float32Double", "double");
            /////////////////////////////////////////

            //parameter_types.Add("List", "uint");
            //parameter_types.Add("SizeI", "int");
            //parameter_types.Add("LineStipple", "ushort");
            //parameter_types.Add("WinCoord", "int");

            //parameter_types.Add("Texture", "uint");
            //parameter_types.Add("TextureComponentCount", "int");
            
            //parameter_types.Add("SelectName", "uint");
            
            //parameter_types.Add("MaskedColorIndexValueF", "float");
            //parameter_types.Add("MaskedColorIndexValueI", "uint");
            //parameter_types.Add("MaskedStencilValue", "uint");
            //parameter_types.Add("StencilValue", "int");

            //parameter_types.Add("handleARB", "uint");
            //parameter_types.Add("charARB", "char"); // Maybe this should be byte?
            //parameter_types.Add("charPointerARB", "string");

            //parameter_types.Add("GLenum", "uint");
            
            //parameter_types.Add("VertexBufferSize", "IntPtr");
            //parameter_types.Add("VertexBufferOffset", "IntPtr");
            //parameter_types.Add("VertexBufferSizeARB", "IntPtr");
            //parameter_types.Add("VertexBufferOffsetARB", "IntPtr");

            //parameter_types.Add("IglooParameterSGIX", "IntPtr");
                        
            //parameter_types.Add("Half16NV", "ushort");
            //parameter_types.Add("PixelDataRangeTargetNV", "uint");

            #endregion
        }

        #endregion

        #region Translate constants
        public static List<Constant> TranslateConstants(List<Constant> constants)
        {
            uint value;

            foreach (Constant c in constants)
            {
                c.Name = "GL_" + c.Name;
                if (!Char.IsDigit(c.Value[0]) && !c.Value.StartsWith("GL_"))
                    c.Value = "GL_" + c.Value;
                //if (String.CompareOrdinal(c.Value, "0x7FFFFFFF") > 0)
                if (UInt32.TryParse(c.Value.Replace("0x", String.Empty), System.Globalization.NumberStyles.AllowHexSpecifier, null, out value))
                    if (value > 0x7FFFFFFF)
                        c.Value = "unchecked((int)" + c.Value + ")";
            }
            return constants;
        }
        #endregion

        #region Translate functions
        public static void TranslateFunctions(List<Function> functions, Hashtable enums, out List<Function> wrappers)
        {
            wrappers = new List<Function>();

            foreach (Function f in functions)
            {
                TranslateReturnValue(f, enums);
                TranslateParameters(f, enums);
                Function wrapper = GenerateWrapper(f);
                if (wrapper != null)
                    wrappers.Add(wrapper);

                if (f.NeedsWrapper)
                    f.Name = f.Name + "_";
            }
        }
        #endregion

        #region TranslateReturnValue
        private static void TranslateReturnValue(Function f, Hashtable enums)
        {
            string s;

            if (f.ReturnValue == "void")
                return;

            if (GLtypes.TryGetValue(f.ReturnValue, out s))
                f.ReturnValue = s;
            //if (CStypes.TryGetValue(f.ReturnValue, out s))
            //    f.ReturnValue = s;

            if (f.ReturnValue == "void[]")
            {
                f.ReturnValue = "IntPtr";
            }

            if (f.ReturnValue == "string")
            {
                f.ReturnValue = "IntPtr";
            }

            if (f.ReturnValue == "IntPtr")
            {
                f.NeedsWrapper = true;
            }
        }
        #endregion

        #region TranslateParameters
        private static void TranslateParameters(Function f, Hashtable enums)
        {
            string s;

            // Map parameters.
            foreach (Parameter p in f.Parameters)
            {
                if (parameter_names.TryGetValue(p.Name, out s))
                    p.Name = s;

                if (enums.ContainsKey(p.Type))
                {
                    p.Type = "Enums." + p.Type;
                    continue;
                }
                else if (GLtypes.TryGetValue(p.Type, out s))
                    p.Type = s;
                //if (CStypes.TryGetValue(p.Type, out s))
                //    p.Type = s;

                if (p.Array && !p.Type.Contains("void"))
                {
                    p.UnmanagedType = System.Runtime.InteropServices.UnmanagedType.LPArray;
                }
                else if (p.Array && p.Type.Contains("void"))
                {
                    p.Array = false;
                    p.Type = "IntPtr";
                    f.NeedsWrapper = true;
                }
               
                //if (p.Flow == Parameter.FlowDirection.Out && p.Type.Contains("string"))
                //    p.Type.Replace("string", "StringBuilder");

                //if (p.Type.Contains("[][]"))
                //{
                //    p.Type = "ref " + p.Type.Replace("[][]", "[]");
                //}
            }
        }
        #endregion

        #region GenerateWrapper
        private static Function GenerateWrapper(Function f)
        {
            if (!f.NeedsWrapper)
                return null;

            // These do not need wrapping!
            if (f.Name.Contains("TexImage") || f.Name.Contains("TexSubImage"))
            {
                f.NeedsWrapper = false;
                return null;
            }

            return f;
        }
        #endregion

        #region Translate enums

        public static void TranslateEnums(System.Collections.Hashtable enums)
        {
            foreach (Enum e in enums.Values)
            {
                if (Char.IsDigit(e.Name[0]))
                    e.Name = e.Name.Insert(0, "_");

                if (e.Name == "Boolean")
                    continue;

                foreach (Constant c in e.ConstantCollection.Values)
                {
                    if (Char.IsDigit(c.Name[0]))
                        c.Name = c.Name.Insert(0, "_");

                    if (c.Value.Contains(".") && Char.IsDigit(c.Value[c.Value.IndexOf('.') + 1]))
                        c.Value = c.Value.Insert(c.Value.IndexOf('.') + 1, "_");
                }
            }
        }

        #endregion
    }
}
