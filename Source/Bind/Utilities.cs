#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Bind.Structures;

namespace Bind
{
    #region WrapperTypes enum

    [Flags]
    public enum WrapperTypes
    {
        /// <summary>
        /// No wrapper needed.
        /// </summary>
        None = 0,
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
        /// Function that takes a reference to a struct.
        /// </summary>
        ReferenceParameter,
        /// <summary>
        /// Function returns string - needs manual marshalling through IntPtr to prevent the managed GC
        /// from freeing memory allocated on the unmanaged side (e.g. glGetString).
        /// </summary>
        StringReturnType,
        /// <summary>
        /// Function returns a void pointer - maps to IntPtr, and the user has to manually marshal the type.
        /// </summary>
        GenericReturnType,
        /// <summary>
        /// Function returns a typed pointer - we have to copy the data to an array to protect it from the GC.
        /// </summary>
        ArrayReturnType
    }

    #endregion

    public static class Utilities
    {
        public static char[] Separators = { ' ', '\n', ',', '(', ')', ';', '#' };

        #region internal StreamReader OpenSpecFile(string file)

        internal static StreamReader OpenSpecFile(string folder, string file)
        {
            string path = Path.Combine(folder, file);
            return new StreamReader(path);
        }

        #endregion

        #region C# keywords

        public static readonly List<string> Keywords = new List<string>(
            new string[]
            {
                "abstract", "event", "new", "struct",
                "as", "explicit", "null", "switch",
                "base", "extern", "object", "this",
                "bool", "false", "operator", "throw",
                "break", "finally", "out", "true",
                "byte", "fixed", "override", "try",
                "case", "float", "params", "typeof",
                "catch", "for", "private", "uint",
                "char", "foreach", "protected", "ulong",
                "checked", "goto", "public", "unchecked",
                "class", "if", "readonly", "unsafe",
                "const", "implicit", "ref", "ushort",
                "continue", "in", "return", "using",
                "decimal", "int", "sbyte", "virtual",
                "default", "interface", "sealed", "volatile",
                "delegate", "internal", "short", "void",
                "do", "is", "sizeof", "while",
                "double", "lock", "stackalloc",
                "else", "long", "static",
                "enum", "namespace", "string"
            }
        );

        #endregion

        #region internal static void Merge(EnumCollection enums, Bind.Structures.Enum t)

        /// <summary>
        /// Merges the given enum into the enum list. If an enum of the same name exists,
        /// it merges their respective constants.
        /// </summary>
        /// <param name="enums"></param>
        /// <param name="t"></param>
        internal static void Merge(EnumCollection enums, Bind.Structures.Enum t)
        {
            if (!enums.ContainsKey(t.Name))
            {
                enums.Add(t.Name, t);
            }
            else
            {
                Bind.Structures.Enum e = enums[t.Name];
                foreach (Bind.Structures.Constant c in t.ConstantCollection.Values)
                {
                    Merge(e, c);
                }
            }
        }

        #endregion

        #region internal static Bind.Structures.Enum Merge(Bind.Structures.Enum s, Bind.Structures.Constant t)

        /// <summary>
        /// Places a new constant in the specified enum, if it doesn't already exist.
        /// The existing constant is replaced iff the new has a numeric value and the old
        /// has a reference value (eg 0x5 is preferred over AttribMask.Foo)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        internal static Bind.Structures.Enum Merge(Bind.Structures.Enum s, Bind.Structures.Constant t)
        {
            if (!s.ConstantCollection.ContainsKey(t.Name))
            {
                s.ConstantCollection.Add(t.Name, t);
            }
            else
            {
                // Tried to add a constant that already exists. If one constant
                // is like: 'Foo = 0x5' and the other like: 'Foo = Bar.Foo', then 
                // keep the first one.
                if (!Char.IsDigit(((Constant)s.ConstantCollection[t.Name]).Value[0]))
                {
                    s.ConstantCollection.Remove(t.Name);
                    s.ConstantCollection.Add(t.Name, t);
                }
            }

            return s;
        }

        #endregion

        #region internal static void Merge(EnumCollection enums, Bind.Structures.Enum t)

        /// <summary>
        /// Merges the given enum into the enum list. If an enum of the same name exists,
        /// it merges their respective constants.
        /// </summary>
        /// <param name="enums"></param>
        /// <param name="t"></param>
        internal static void Merge(DelegateCollection delegates, Bind.Structures.Delegate t)
        {
            if (!delegates.ContainsKey(t.Name))
            {
                delegates.Add(t.Name, t);
            }
        }

        #endregion

        #region internal static string GetGL2Extension(string name)

        internal static string GetGL2Extension(string name)
        {
            if (name.EndsWith("ARB")) { return "ARB"; }
            if (name.EndsWith("EXT")) { return "EXT"; }
            if (name.EndsWith("ATI")) { return "ATI"; }
            if (name.EndsWith("ATIX")) { return "ATIX"; }
            if (name.EndsWith("NV")) { return "NV"; }
            if (name.EndsWith("SUN")) { return "SUN"; }
            if (name.EndsWith("SUNX")) { return "SUNX"; }
            if (name.EndsWith("SGI")) { return "SGI"; }
            if (name.EndsWith("SGIS")) { return "SGIS"; }
            if (name.EndsWith("SGIX")) { return "SGIX"; }
            if (name.EndsWith("MESA")) { return "MESA"; }
            if (name.EndsWith("3DFX")) { return "3DFX"; }
            if (name.EndsWith("INTEL")) { return "INTEL"; }
            if (name.EndsWith("IBM")) { return "IBM"; }
            if (name.EndsWith("GREMEDY")) { return "GREMEDY"; }
            if (name.EndsWith("HP")) { return "HP"; }
            if (name.EndsWith("PGI")) { return "PGI"; }
            if (name.EndsWith("INGR")) { return "INGR"; }
            if (name.EndsWith("APPLE")) { return "APPLE"; }
            if (name.EndsWith("OML")) { return "OML"; }
            if (name.EndsWith("I3D")) { return "I3D"; }
            return "";
        }

        #endregion

        #region private static bool IsGL2Extension(string function)

        private static bool IsGL2Extension(string function)
        {
            return (function.EndsWith("ARB") ||
                    function.EndsWith("EXT") ||
                    function.EndsWith("ATI") ||
                    function.EndsWith("NV") ||
                    function.EndsWith("SUN") ||
                    function.EndsWith("SUNX") ||
                    function.EndsWith("SGI") ||
                    function.EndsWith("SGIS") ||
                    function.EndsWith("SGIX") ||
                    function.EndsWith("MESA") ||
                    function.EndsWith("3DFX") ||
                    function.EndsWith("IBM") ||
                    function.EndsWith("GREMEDY") ||
                    function.EndsWith("HP") ||
                    function.EndsWith("INTEL") ||
                    function.EndsWith("PGI") ||
                    function.EndsWith("INGR") ||
                    function.EndsWith("APPLE") ||
                    function.EndsWith("OML") ||
                    function.EndsWith("I3D"));
        }

        #endregion

        #region internal static string StripGL2Extension(string p)
        
        internal static string StripGL2Extension(string p)
        {
            return p.Substring(0, p.Length - GetGL2Extension(p).Length);
        }
        
        #endregion
    }
}
