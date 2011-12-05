#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Bind.Structures;
using Delegate=Bind.Structures.Delegate;
using Enum=Bind.Structures.Enum;

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
        public static readonly char[] Separators = { ' ', '\n', ',', '(', ')', ';', '#' };
        public static readonly Regex Extensions = new Regex(
            "ARB|EXT|ATIX|ATI|AMDX|AMD|NV|NVX|SUNX|SUN|SGIS|SGIX|SGI|MESAX|MESA|3DFX|IBM|GREMEDY|HP|INTEL|PGI|INGR|APPLE|OML|I3D|ARM|ANGLE|OES|QCOM|VIV|IMG",
            RegexOptions.Compiled);
        public static readonly Regex Acronyms = new Regex(Extensions.ToString() + "|EGL|3TC|DXT|ES|GL|CL|RGBA|BGRA|RGB|BGR|ETC",
            RegexOptions.Compiled);

        #region internal StreamReader OpenSpecFile(string file)

        internal static StreamReader OpenSpecFile(string folder, string file)
        {
            if (String.IsNullOrEmpty(folder) || String.IsNullOrEmpty(file))
                return null;

            Console.WriteLine(folder);
            Console.WriteLine(file);
            string path = Path.Combine(folder, file);
            Console.WriteLine(path);
            return new StreamReader(path);
        }

        #endregion

        #region Keywords

        public static List<string> Keywords
        {
            get
            {
                switch (Settings.Language)
                {
                    case GeneratorLanguage.CSharp: return CSharpKeywords;
                    case GeneratorLanguage.Cpp: return CppKeywords;
                    case GeneratorLanguage.Java: return JavaKeywords;
                    default: throw new NotImplementedException();
                }
            }
        }

        static readonly List<string> CSharpKeywords = new List<string>(
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

        static readonly List<string> JavaKeywords = new List<string>(
            new string[]
            {
                "abstract", "continue", "for", "new", "switch",
                "assert", "default", "goto", "package", "synchronized",
                "boolean", "do", "if", "private", "this",
                "break", "double", "implements", "protected", "throw",
                "byte", "else", "import", "public", "throws",
                "case", "enum", "instanceof", "return", "transient",
                "catch", "extends", "int", "short", "try",
                "char", "final", "interface", "static", "void",
                "class", "finally", "long", "strictfp", "volatile",
                "const", "float", "native", "super", "while",
                "callback"
            });

        static readonly List<string> CppKeywords = new List<string>();

        #endregion

        #region Merge

        // Merges the specified enum collections.
        internal static void Merge(EnumCollection enums, EnumCollection new_enums)
        {
            foreach (var e in new_enums)
            {
                Merge(enums, e.Value);
            }
        }

        /// <summary>
        /// Merges the given enum into the enum list. If an enum of the same name exists,
        /// it merges their respective constants.
        /// </summary>
        /// <param name="enums"></param>
        /// <param name="t"></param>
        internal static void Merge(EnumCollection enums, Enum t)
        {
            if (!enums.ContainsKey(t.Name))
            {
                enums.Add(t.Name, t);
            }
            else
            {
                Enum e = enums[t.Name];
                foreach (Constant c in t.ConstantCollection.Values)
                {
                    Merge(e, c);
                }
            }
        }

        /// <summary>
        /// Places a new constant in the specified enum, if it doesn't already exist.
        /// The existing constant is replaced iff the new has a numeric value and the old
        /// has a reference value (eg 0x5 is preferred over AttribMask.Foo)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        internal static Enum Merge(Enum s, Constant t)
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

        // Merges the specified delegate collections.
        internal static void Merge(DelegateCollection delegates, DelegateCollection new_delegates)
        {
            foreach (var d in new_delegates)
            {
                Merge(delegates, d.Value);
            }
        }

        // Merges the given delegate into the delegate list.
        internal static void Merge(DelegateCollection delegates, Delegate t)
        {
            delegates.Add(t.Name, t);
        }

        #endregion

        #region internal static string GetGL2Extension(string name)

        internal static string GetGL2Extension(string name)
        {
            var match = Extensions.Match(name);
            if (match.Success)
            {
                string ext = match.Value;
                if (ext.Length > 2)
                {
                    ext = ext[0] + ext.Substring(1).ToLower();
                }
                return ext;
            }
            else
            {
                return String.Empty;
            }
        }

        #endregion

        #region private static bool IsGL2Extension(string function)

        private static bool IsGL2Extension(string function)
        {
            return !String.IsNullOrEmpty(GetGL2Extension(function));
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
