/* Copyright (c) 2006 Stephen Apostolopoulos
 * See license.txt for license info
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.OpenGL.Bind
{
    static class Translation
    {
        public static char[] Separators = { ' ', '\n', ',', '(', ')', ';', '#' };
        public static char[] Whitespace = { ' ' };
        public static char[] Braces = { '(', ')' };
        public static char[] Comma = { ',' };

        /// <summary>
        /// Searches for a possible translation for the parameter given.
        /// </summary>
        /// <param name="str">The parameter to be translated.</param>
        /// <returns>The translation of the parameter, or the parameter itself if no translation is found.</returns>
        public static string Get(string str)
        {
            foreach (KeyValuePair<string, string> pair in translations)
                if (pair.Key == str)
                    return pair.Value;

            return str;
        }

        static Dictionary<string, string> parameter_names = new Dictionary<string, string>();
        static Dictionary<string, string> parameter_types = new Dictionary<string, string>();
        static Dictionary<string, string> old_dictionary = new Dictionary<string, string>();

        #region Constructor

        static Translation()
        {
            parameter_names.Add("base", "@base");
            parameter_names.Add("object", "@object");
            parameter_names.Add("string", "@string");
            parameter_names.Add("ref", "reference");
            parameter_names.Add("params", "parameters");
            parameter_names.Add("in", "@in");

            parameter_types.Add("Boolean", "bool");
            parameter_types.Add("BooleanPointer", "bool[]");
            parameter_types.Add("Char", "char");
            parameter_types.Add("CharPointer", "string");

            parameter_types.Add("CheckedFloat32", "float");
            parameter_types.Add("CheckedInt32", "int");

            parameter_types.Add("ClampedColorF", "float");
            parameter_types.Add("ClampedFloat32", "float");
            parameter_types.Add("ClampedFloat64", "double");
            parameter_types.Add("ClampedStencilValue", "int");

            parameter_types.Add("ColorB", "byte");
            parameter_types.Add("ColorS", "short");
            parameter_types.Add("ColorI", "int");
            parameter_types.Add("ColorUB", "byte");
            parameter_types.Add("ColorUS", "ushort");
            parameter_types.Add("ColorUI", "uint");
            parameter_types.Add("ColorF", "float");
            parameter_types.Add("ColorD", "double");

            parameter_types.Add("ColorIndexValueD", "double");
            parameter_types.Add("ColorIndexValueF", "float");
            parameter_types.Add("ColorIndexValueI", "int");
            parameter_types.Add("ColorIndexValueS", "short");
            parameter_types.Add("ColorIndexValueUB", "byte");

            parameter_types.Add("CompressedTextureARB", "void");
            parameter_types.Add("ControlPointNV", "void");

            parameter_types.Add("CoordF", "float");
            parameter_types.Add("CoordD", "double");
            parameter_types.Add("CoordI", "int");
            parameter_types.Add("CoordS", "short");

            parameter_types.Add("FeedbackElement", "float");
            parameter_types.Add("FenceNV", "uint");

            /////////////////////////////////////
            parameter_types.Add("Int8", "byte");
            parameter_types.Add("Int16", "short");
            parameter_types.Add("Int32", "int");
            parameter_types.Add("UInt8", "byte");
            parameter_types.Add("UInt16", "ushort");
            parameter_types.Add("UInt32", "uint");
            parameter_types.Add("Float32", "float");
            parameter_types.Add("Float64", "double");

            parameter_types.Add("ConstFloat32", "float");
            parameter_types.Add("ConstInt32", "double");
            parameter_types.Add("ConstUInt32", "uint");
            parameter_types.Add("ConstVoid", "object");
            parameter_types.Add("ConstVoidPointer", "object");
            
            parameter_types.Add("String", "string");
            parameter_types.Add("Void", "object");
            parameter_types.Add("VoidPointer", "object");
            parameter_types.Add("void", "void");
            
            parameter_types.Add("Float32Pointer", "float");
            parameter_types.Add("Float32Double", "double");
            ///////////////////////////////////////

            parameter_types.Add("List", "uint");
            parameter_types.Add("SizeI", "int");
            parameter_types.Add("LineStipple", "ushort");
            parameter_types.Add("WinCoord", "int");

            parameter_types.Add("Texture", "uint");
            parameter_types.Add("TextureComponentCount", "int");
            
            parameter_types.Add("SelectName", "uint");
            
            parameter_types.Add("MaskedColorIndexValueF", "float");
            parameter_types.Add("MaskedColorIndexValueI", "uint");
            parameter_types.Add("MaskedStencilValue", "uint");
            parameter_types.Add("StencilValue", "int");
            
            parameter_types.Add("DrawElementsType", "uint");

            parameter_types.Add("BlendEquationMode", "Enums.BlendEquationModeEXT");

            parameter_types.Add("ColorTableTarget", "Enums.ColorTableTargetSGI");
            parameter_types.Add("ColorTableParameterPName", "Enums.ColorTableParameterPNameSGI");
            parameter_types.Add("ConvolutionTarget", "Enums.ConvolutionTargetEXT");
            parameter_types.Add("ConvolutionParameter", "Enums.ConvolutionParameterEXT");
            parameter_types.Add("GetColorTableParameterPName", "Enums.GetColorTableParameterPNameSGI");
            parameter_types.Add("GetConvolutionParameterPName", "Enums.GetConvolutionParameter");   // May not be correct, but was the closest I could find.
            parameter_types.Add("SeparableTarget", "Enums.SeparableTargetEXT");
            parameter_types.Add("HistogramTarget", "Enums.HistogramTargetEXT");
            parameter_types.Add("GetHistogramParameterPName", "Enums.GetHistogramParameterPNameEXT");
            parameter_types.Add("MinmaxTarget", "Enums.MinmaxTargetEXT");
            parameter_types.Add("GetMinmaxParameterPName", "Enums.GetMinmaxParameterPNameEXT");
            
            parameter_types.Add("TextureUnit", "uint");
            parameter_types.Add("BlendFuncSeparateParameterEXT", "uint");
            parameter_types.Add("FogPointerTypeEXT", "uint");
            parameter_types.Add("PointParameterNameARB", "Enums.PointParameterNameSGIS");
            parameter_types.Add("GLenum", "uint");
            
            parameter_types.Add("VertexBufferTargetARB", "uint");
            parameter_types.Add("VertexBufferUsageARB", "uint");
            parameter_types.Add("VertexBufferSize", "IntPtr");
            parameter_types.Add("VertexBufferOffset", "IntPtr");
            parameter_types.Add("VertexBufferPNameARB", "uint");
            parameter_types.Add("VertexBufferAccessARB", "uint");
            parameter_types.Add("VertexBufferPointerNameARB", "uint");
            parameter_types.Add("VertexAttribPropertyARB", "uint");
            parameter_types.Add("VertexAttribPointerPropertyARB", "uint");
            parameter_types.Add("VertexAttribPointerTypeARB", "uint");
            parameter_types.Add("VertexBufferSizeARB", "IntPtr");
            parameter_types.Add("VertexBufferOffsetARB", "IntPtr");

            parameter_types.Add("DrawBufferModeATI", "Enums.DrawBufferMode");
            
            parameter_types.Add("StencilFaceDirection", "uint");
            parameter_types.Add("WeightPointerTypeARB", "uint");
            parameter_types.Add("MatrixIndexPointerTypeARB", "uint");
            parameter_types.Add("ProgramFormatARB", "uint");
            parameter_types.Add("ProgramPropertyARB", "uint");
            parameter_types.Add("ProgramTargetARB", "uint");
            parameter_types.Add("ProgramStringPropertyARB", "uint");

            parameter_types.Add("handleARB", "uint");
            parameter_types.Add("charARB", "char"); // Maybe this should be byte?
            parameter_types.Add("charPointerARB", "string");
            
            parameter_types.Add("ClampColorTargetARB", "uint");
            parameter_types.Add("ClampColorModeARB", "uint");
            parameter_types.Add("TextureFilterSGIS", "uint");
            parameter_types.Add("PixelTexGenModeSGIX", "uint");
            parameter_types.Add("SpriteParameterNameSGIX", "uint");
            parameter_types.Add("ImageTransformTargetHP", "uint");
            parameter_types.Add("ImageTransformPNameHP", "uint");
            parameter_types.Add("HintTargetPGI", "uint");
            parameter_types.Add("IndexMaterialParameterEXT", "uint");
            parameter_types.Add("IndexFunctionEXT", "uint");
            parameter_types.Add("CullParameterEXT", "uint");
            parameter_types.Add("FragmentLightParameterSGIX", "uint");
            parameter_types.Add("FragmentLightNameSGIX", "uint");
            parameter_types.Add("LightTextureModeEXT", "uint");
            parameter_types.Add("LightTexturePNameEXT", "uint");
            parameter_types.Add("PixelTransformTargetEXT", "uint");
            parameter_types.Add("PixelTransformPNameEXT", "uint");
            parameter_types.Add("TextureNormalModeEXT", "uint");
            parameter_types.Add("TangentPointerTypeEXT", "uint");
            parameter_types.Add("BinormalPointerTypeEXT", "uint");
            parameter_types.Add("ReplacementCodeTypeSUN", "uint");
            parameter_types.Add("ReplacementCodeSUN", "uint");
            parameter_types.Add("VertexWeightPointerTypeEXT", "uint");
            
            parameter_types.Add("CombinerParameterNV", "uint");
            parameter_types.Add("CombinerMappingNV", "uint");
            parameter_types.Add("CombinerPortionNV", "uint");
            parameter_types.Add("CombinerRegisterNV", "uint");
            parameter_types.Add("CombinerStageNV", "uint");
            parameter_types.Add("CombinerVariableNV", "uint");
            parameter_types.Add("CombinerScaleNV", "uint");
            parameter_types.Add("CombinerBiasNV", "uint");
            parameter_types.Add("CombinerComponentUsageNV", "uint");

            parameter_types.Add("SecondaryColorPointerTypeIBM", "uint");
            parameter_types.Add("FogPointerTypeIBM", "uint");
            parameter_types.Add("SamplePatternEXT", "uint");
            parameter_types.Add("IglooParameterSGIX", "object");
            parameter_types.Add("IglooFunctionSelectSGIX", "uint");
            parameter_types.Add("FenceParameterNameNV", "uint");
            parameter_types.Add("FenceConditionNV", "uint");
            parameter_types.Add("MapTypeNV", "uint");
            parameter_types.Add("EvalTargetNV", "uint");
            parameter_types.Add("MapParameterNV", "uint");
            parameter_types.Add("MapAttribParameterNV", "uint");
            parameter_types.Add("EvalMapsModeNV", "uint");
            parameter_types.Add("VertexAttribEnumNV", "uint");
            parameter_types.Add("ProgramCharacterNV", "uint");

            parameter_types.Add("TexBumpParameterATI", "uint");
            parameter_types.Add("GetTexBumpParameterATI", "uint");
            parameter_types.Add("SwizzleOpATI", "uint");
            parameter_types.Add("FragmentOpATI", "uint");
            parameter_types.Add("PNTrianglesPNameATI", "uint");
            parameter_types.Add("ArrayObjectUsageATI", "uint");
            parameter_types.Add("PreserveModeATI", "uint");
            parameter_types.Add("ArrayObjectPNameATI", "uint");
            parameter_types.Add("ScalarType", "uint");
            
            parameter_types.Add("VertexShaderOpEXT", "uint");
            parameter_types.Add("VertexShaderCoordOutEXT", "uint");
            parameter_types.Add("VertexShaderWriteMaskEXT", "uint");
            parameter_types.Add("ParameterRangeEXT", "uint");
            parameter_types.Add("DataTypeEXT", "uint");
            parameter_types.Add("VertexShaderStorageTypeEXT", "uint");
            parameter_types.Add("VertexShaderTextureUnitParameter", "uint");
            parameter_types.Add("VertexShaderParameterEXT", "uint");
            parameter_types.Add("VariantCapEXT", "uint");
            parameter_types.Add("GetVariantValueEXT", "uint");
            parameter_types.Add("VertexStreamATI", "uint");
            parameter_types.Add("ElementPointerTypeATI", "uint");
            parameter_types.Add("OcclusionQueryParameterNameNV", "uint");
            parameter_types.Add("ObjectTypeAPPLE", "uint");
            parameter_types.Add("VertexArrayPNameAPPLE", "uint");

            parameter_types.Add("Half16NV", "ushort");
            parameter_types.Add("PixelDataRangeTargetNV", "uint");
            //parameter_types.Add("", "");
            //parameter_types.Add("", "");
            //parameter_types.Add("", "");
            //parameter_types.Add("", "");
            //parameter_types.Add("", "");
            //parameter_types.Add("", "");
            //parameter_types.Add("", "");
            //parameter_types.Add("", "");
        }

        #endregion

        #region Old key pairs

        static KeyValuePair<string, string>[] translations = new KeyValuePair<string, string>[]
            {
                // Pointer types.
                //new KeyValuePair<string, string>("GLhandleARB*", "IntPtr"),
                //new KeyValuePair<string, string>("GLhalfARB*", "IntPtr"),
                //new KeyValuePair<string, string>("GLhalfNV*", "IntPtr"),
                //new KeyValuePair<string, string>("GLcharARB*", "IntPtr"),
                //new KeyValuePair<string, string>("GLenum*", "IntPtr"),
                //new KeyValuePair<string, string>("GLboolean*", "IntPtr"),
                //new KeyValuePair<string, string>("GLbitfield*", "IntPtr"),
                //new KeyValuePair<string, string>("GLvoid*", "IntPtr"),
                //new KeyValuePair<string, string>("GLchar*", "IntPtr"),
                //new KeyValuePair<string, string>("GLbyte*", "IntPtr"),
                //new KeyValuePair<string, string>("GLshort*", "IntPtr"),
                //new KeyValuePair<string, string>("GLint*", "IntPtr"),
                //new KeyValuePair<string, string>("GLubyte*", "IntPtr"),
                //new KeyValuePair<string, string>("GLushort*", "IntPtr"),
                //new KeyValuePair<string, string>("GLuint*", "IntPtr"),
                //new KeyValuePair<string, string>("GLsizei*", "IntPtr"),
                //new KeyValuePair<string, string>("GLfloat*", "IntPtr"),
                //new KeyValuePair<string, string>("GLclampf*", "IntPtr"),
                //new KeyValuePair<string, string>("GLdouble*", "IntPtr"),
                //new KeyValuePair<string, string>("GLclampd*", "IntPtr"),
                
                new KeyValuePair<string, string>("GLvoid*", "Array"),

                // ARB and NV types (these should come before normal types to guard against double translation).
                new KeyValuePair<string, string>("GLsizeiptrARB", "IntPtr"),
                new KeyValuePair<string, string>("GLintptrARB", "IntPtr"),
                new KeyValuePair<string, string>("GLhandleARB", "uint"),
                new KeyValuePair<string, string>("GLhalfARB", "ushort"),
                new KeyValuePair<string, string>("GLhalfNV", "ushort"),
                new KeyValuePair<string, string>("GLcharARB", "char"),

                // Normal types.
                new KeyValuePair<string, string>("GLsizeiptr", "IntPtr"),
                new KeyValuePair<string, string>("GLintptr", "IntPtr"),
                new KeyValuePair<string, string>("GLenum", "uint"),
                new KeyValuePair<string, string>("GLboolean", "bool"),
                new KeyValuePair<string, string>("GLbitfield", "uint"),
                new KeyValuePair<string, string>("GLvoid", "void"),
                new KeyValuePair<string, string>("GLchar", "char"),
                new KeyValuePair<string, string>("GLbyte", "sbyte"),
                new KeyValuePair<string, string>("GLshort", "short"),
                new KeyValuePair<string, string>("GLint", "int"),
                new KeyValuePair<string, string>("GLubyte", "byte"),
                new KeyValuePair<string, string>("GLushort", "ushort"),
                new KeyValuePair<string, string>("GLuint", "uint"),
                new KeyValuePair<string, string>("GLsizei", "int"),
                new KeyValuePair<string, string>("GLfloat", "float"),
                new KeyValuePair<string, string>("GLclampf", "float"),
                new KeyValuePair<string, string>("GLdouble", "double"),
                new KeyValuePair<string, string>("GLclampd", "double"),
                
                new KeyValuePair<string, string>("void", "void"),       // For return parameters.

                // Special.
                //new KeyValuePair<string, string>("*", "[]"),
                new KeyValuePair<string, string>("const", String.Empty),

                // Since we cannot marshal nested arrays...
                //new KeyValuePair<string, string>("char[][]", "string[]"),

                //new KeyValuePair<string, string>("#define", "const uint "),
                //new KeyValuePair<string, string>(" *", "[] "),
                //new KeyValuePair<string, string>("GLAPI", String.Empty),
                //new KeyValuePair<string, string>("APIENTRY", String.Empty),
                //new KeyValuePair<string, string>("APIENTRYP", String.Empty),
                //new KeyValuePair<string, string>("\n", ""),
                //new KeyValuePair<string, string>(" out", " output"),
                //new KeyValuePair<string, string>("  ", " "),
            };

        #endregion

        #region Translate function list

        public static void Translate(List<Function> function_list, List<Function> wrapper_list)
        {
            string s;

            foreach (Function f in function_list)
            {
                Function wf = new Function();
                wf.ReturnValue = f.ReturnValue;
                wf.Name = f.Name;

                if (parameter_types.TryGetValue(f.ReturnValue, out s))
                    f.ReturnValue = s;
                else
                    f.ReturnValue = "Enums." + f.ReturnValue;

                // You may not marshal by return type (the return type must be defined).
                if (f.ReturnValue == "object")
                {
                    f.ReturnValue = "IntPtr";
                    wf.ReturnValue = "object";

                    f.NeedsWrapper = true;
                }

                foreach (Parameter p in f.Parameters)
                {
                    Parameter wp = new Parameter();
                    wp.Name = p.Name;
                    wp.Type = p.Type;
                    wp.Array = p.Array;
                    wp.Flow = p.Flow;
                    wf.Parameters.Add(wp);

                    if (parameter_names.TryGetValue(p.Name, out s))
                    {
                        p.Name = s;
                        wp.Name = s;
                    }

                    if (parameter_types.TryGetValue(p.Type, out s))
                    {
                        p.Type = s;
                        wp.Type = s;
                    }
                    else
                    {
                        p.Type = "Enums." + p.Type;
                        wp.Type = p.Type;
                    }

                    if (p.Type == "object")
                    {
                        p.Array = false;
                        p.Type = "object";
                        p.UnmanagedType = System.Runtime.InteropServices.UnmanagedType.AsAny;
                        //p.Type = "IntPtr";
                        //wp.Array = false;
                        //f.NeedsWrapper = true;
                    }

                    if (p.Type == "void" && p.Array)
                    {
                        p.Array = false;
                        p.Type = "object";
                        p.UnmanagedType = System.Runtime.InteropServices.UnmanagedType.AsAny;
                        //p.Type = "IntPtr";
                        //wp.Type = "object";
                        //wp.Array = true;
                        //f.NeedsWrapper = true;
                    }

                    if (p.Array)
                    {
                        p.Type = p.Type + "[]";
                        wp.Type = wp.Type + "[]";
                    }

                    //if (p.Flow == Parameter.FlowDirection.Out && p.Type.Contains("string"))
                    //    p.Type.Replace("string", "StringBuilder");

                    if (p.Type.Contains("[][]"))
                    {
                        p.Type = "ref " + p.Type.Replace("[][]", "[]");
                        wp.Type = "ref " + wp.Type.Replace("[][]", "[]");
                    }
                }

                if (f.NeedsWrapper)
                {
                    f.Name = f.Name + "_";
                    wrapper_list.Add(wf);
                }
            }
        }

        #endregion

        #region Translate enum hashtable

        public static void Translate(System.Collections.Hashtable e_table)
        {
            foreach (Enum e in e_table.Values)
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
