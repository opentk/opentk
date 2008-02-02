#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Bind.Structures
{
    public class Type
    {
        internal static Dictionary<string, string> GLTypes;
        internal static Dictionary<string, string> CSTypes;

        private static bool typesLoaded;

        #region internal static void Initialize(string glTypes, string csTypes)
        
        internal static void Initialize(string glTypes, string csTypes)
        {
            if (!typesLoaded)
            {
                if (GLTypes == null)
                {
                    using (StreamReader sr = Utilities.OpenSpecFile(Settings.InputPath, glTypes))
                    {
                        GLTypes = Bind.MainClass.Generator.ReadTypeMap(sr);
                    }
                }
                if (CSTypes == null)
                {
                    using (StreamReader sr = Utilities.OpenSpecFile(Settings.InputPath, csTypes))
                    {
                        CSTypes = Bind.MainClass.Generator.ReadCSTypeMap(sr);
                    }
                }
                typesLoaded = true;
            }
        }
        
        #endregion

        #region --- Constructors ---
        
        public Type()
        {
        }

        public Type(Type t)
        {
            if (t != null)
            {
                this.CurrentType = t.CurrentType;
                this.PreviousType = t.PreviousType;
                this.WrapperType = t.WrapperType;
                this.Array = t.Array;
                this.Pointer = t.Pointer;
                this.Reference = t.Reference;
            }
        }
        
        #endregion

        #region public string Type

        string type;
        /// <summary>
        /// Gets the type of the parameter.
        /// </summary>
        public virtual string CurrentType
        {
            //get { return _type; }
            get
            {
                if (((Settings.Compatibility & Settings.Legacy.TurnVoidPointersToIntPtr) != Settings.Legacy.None) && Pointer && type.Contains("void"))
                    return "IntPtr";

                return type;
            }
            set
            {
                if (!String.IsNullOrEmpty(type))
                    PreviousType = type;
                if (!String.IsNullOrEmpty(value))
                    type = value.Trim();

                //Translate();

                if (type.EndsWith("*"))
                {
                    type = type.TrimEnd('*');
                    Pointer = true;
                }
            }
        }

        #endregion

        #region public string PreviousType

        private string _previous_type;

        public string PreviousType
        {
            get { return _previous_type; }
            set { _previous_type = value; }
        }


        #endregion

        #region public bool Reference

        bool reference;

        public bool Reference
        {
            get { return reference; }
            set { reference = value; }
        }

        #endregion

        #region public bool Array

        int array;

        public int Array
        {
            get { return array; }
            set { array = value > 0 ? value : 0; }
        }

        #endregion

        #region public bool Pointer

        bool pointer;

        public bool Pointer
        {
            get { return pointer; }
            set { pointer = value; }
        }

        #endregion

        #region public bool CLSCompliant

        public bool CLSCompliant
        {
            get
            {
                bool compliant = !(CurrentType.Contains("UInt") || CurrentType.Contains("SByte"));
                if (Pointer)
                {
                    compliant &= CurrentType.Contains("IntPtr");    // IntPtr's are CLSCompliant.
                    // If the NoPublicUnsageFunctions is set, the pointer will be CLSCompliant.
                    compliant |= (Settings.Compatibility & Settings.Legacy.NoPublicUnsafeFunctions) != Settings.Legacy.None;
                }
                return compliant;
                //return compliant && (!Pointer || CurrentType.Contains("IntPtr"));
                //return compliant && !(Pointer && ((Settings.Compatibility & Settings.Legacy.NoPublicUnsafeFunctions) == Settings.Legacy.None));
                
                /*
                 * return !(
                    (Pointer && ((Settings.Compatibility & Settings.Legacy.NoPublicUnsafeFunctions) == Settings.Legacy.None ) ||
                    CurrentType.Contains("UInt") ||
                    CurrentType.Contains("SByte")));
                */

                /*(Type.Contains("GLu") && !Type.Contains("GLubyte")) ||
                Type == "GLbitfield" ||
                Type.Contains("GLhandle") ||
                Type.Contains("GLhalf") ||
                Type == "GLbyte");*/
            }
        }

        #endregion

        #region public WrapperTypes WrapperType

        private WrapperTypes _wrapper_type = WrapperTypes.None;

        public WrapperTypes WrapperType
        {
            get { return _wrapper_type; }
            set { _wrapper_type = value; }
        }

        #endregion

        #region public string GetFullType()

        public string GetFullType(Dictionary<string, string> CSTypes, bool compliant)
        {
            //if (Pointer && ((Settings.Compatibility & Settings.Legacy.NoPublicUnsafeFunctions) != Settings.Legacy.None))
            //    return "IntPtr";

            if (!compliant)
            {
                return
                    CurrentType +
                    (Pointer ? "*" : "") +
                    (Array > 0 ? "[]" : "");
            }

            return
                GetCLSCompliantType() +
                (Pointer ? "*" : "") +
                (Array > 0 ? "[]" : "");

        }

        #endregion

        #region public string GetCLSCompliantType()

        public string GetCLSCompliantType()
        {
            if (!CLSCompliant)
            {
                if (Pointer && Settings.Compatibility == Settings.Legacy.Tao)
                    return "IntPtr";

                switch (CurrentType)
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

            return CurrentType;
        }

        #endregion

        #region public override string ToString()
        
        public override string ToString()
        {
            return CurrentType;
        }
        
        #endregion

        #region public virtual void Translate(string category)

        public virtual void Translate(string category)
        {
            Enum @enum;
            string s;

            if (this.CurrentType == "SGIS_texture_filter4")
            {
            }

            // Try to find out if it is an enum. If the type exists in the normal GLEnums list, use this.
            // Otherwise, try to find it in the aux enums list. If it exists in neither, it is not an enum.
            // Special case for Boolean - it is an enum, but it is dumb to use that instead of the 'bool' type.
            bool normal = false;
            bool aux = false;
            normal = Enum.GLEnums.TryGetValue(CurrentType, out @enum);
            if (!normal)
                aux = Enum.AuxEnums != null && Enum.AuxEnums.TryGetValue(CurrentType, out @enum);

            // Translate enum types
            if ((normal || aux) && @enum.Name != "GLenum" && @enum.Name != "Boolean")
            {
                if ((Settings.Compatibility & Settings.Legacy.ConstIntEnums) != Settings.Legacy.None)
                    CurrentType = "int";
                else
                {
                    if (normal)
                        CurrentType = CurrentType.Insert(0, String.Format("{0}.", Settings.EnumsOutput));
                    else if (aux)
                        CurrentType = CurrentType.Insert(0, String.Format("{0}.", Settings.EnumsAuxOutput));
                }
            }
            else if (Bind.Structures.Type.GLTypes.TryGetValue(CurrentType, out s))
            {
                // Check if the parameter is a generic GLenum. If yes,
                // check if a better match exists:
                if (s.Contains("GLenum") && !String.IsNullOrEmpty(category))
                {
                    if ((Settings.Compatibility & Settings.Legacy.ConstIntEnums) != Settings.Legacy.None)
                        CurrentType = "int";
                    else
                        // Better match: enum.Name == function.Category (e.g. GL_VERSION_1_1 etc)
                        if (Enum.GLEnums.ContainsKey(category))
                            CurrentType = String.Format("{0}.{1}", Settings.EnumsOutput, Enum.TranslateName(category));
                        else
                            CurrentType = String.Format("{0}.{1}", Settings.EnumsOutput, Settings.CompleteEnumName);
                }
                else
                {
                    // This is not enum, default translation:
                    if (CurrentType == "PIXELFORMATDESCRIPTOR" || CurrentType == "LAYERPLANEDESCRIPTOR" ||
                        CurrentType == "GLYPHMETRICSFLOAT")
                    {
                        if (Settings.Compatibility == Settings.Legacy.Tao)
                            CurrentType = CurrentType.Insert(0, "Gdi.");
                        else
                        {
                            if (CurrentType == "PIXELFORMATDESCRIPTOR")
                                CurrentType = "PixelFormatDescriptor";
                            else if (CurrentType == "LAYERPLANEDESCRIPTOR")
                                CurrentType = "LayerPlaneDescriptor";
                            else if (CurrentType == "GLYPHMETRICSFLOAT")
                                CurrentType = "GlyphMetricsFloat";
                        }
                    }
                    else if (CurrentType == "XVisualInfo")
                    {
                        //p.Pointer = false;
                        //p.Reference = true;

                    }
                    else
                        CurrentType = s;
                }

                CurrentType =
                    Bind.Structures.Type.CSTypes.ContainsKey(CurrentType) ?
                    Bind.Structures.Type.CSTypes[CurrentType] : CurrentType;

                if (CurrentType == "IntPtr" && String.IsNullOrEmpty(PreviousType))
                    Pointer = false;
            }
        }

        #endregion
    }
}
