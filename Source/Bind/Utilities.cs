#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        BoolParameter = 1 << 0,
        /// <summary>
        /// Function takes generic parameters - add ref/out generic and generic overloads.
        /// </summary>
        GenericParameter = 1 << 1,
        /// <summary>
        /// Function takes arrays as parameters - add ref/out and ([Out]) array overloads.
        /// </summary>
        ArrayParameter = 1 << 2,
        /// <summary>
        /// Function with bitmask parameters. Bitmask parameters map to UInt, but since we can only use signed
        /// types (for CLS compliance), we must add the unchecked keyword.
        /// Usually found in bitmasks
        /// </summary>
        UncheckedParameter = 1 << 3,
        /// <summary>
        /// Function that takes (in/ref/out) a naked pointer as a parameter - we pass an IntPtr.
        /// </summary>
        PointerParameter = 1 << 4,
        /// <summary>
        /// Function that takes a reference to a struct.
        /// </summary>
        ReferenceParameter = 1 << 5,
        /// <summary>
        /// Function returns string - needs manual marshalling through IntPtr to prevent the managed GC
        /// from freeing memory allocated on the unmanaged side (e.g. glGetString).
        /// </summary>
        StringReturnType = 1 << 6,
        /// <summary>
        /// Function returns a void pointer - maps to IntPtr, and the user has to manually marshal the type.
        /// </summary>
        GenericReturnType = 1 << 7,
        /// <summary>
        /// Function returns a typed pointer - we have to copy the data to an array to protect it from the GC.
        /// </summary>
        ArrayReturnType = 1 << 8,
        /// <summary>
        /// Function normally returns a value via an out parameter.
        /// This overload returns a single item directly.
        /// e.g. void GetIntegerv(enum pname, out int value) => int GetInteger(enum pname)
        /// </summary>
        ConvenienceReturnType = 1 << 9,
        /// <summary>
        /// Function normally returns an array via an out parameter.
        /// This overload returns a single item directly.
        /// e.g. void GenBuffers(int count, int[] ids) => int GenBuffer()
        /// </summary>
        ConvenienceArrayReturnType = 1 << 10,
        /// <summary>
        /// Function normally takes an array in parameter.
        /// This overload takes a single item directly.
        /// e.g. void DeleteBuffers(int count, int[] ids) => DeleteBuffer(int id)
        /// </summary>
        ConvenienceArrayType = 1 << 11,
        /// <summary>
        /// Function takes a String or StringBuilder parameter
        /// </summary>
        StringParameter = 1 << 12,
        /// <summary>
        /// Function takes a String[] parameter
        /// </summary>
        StringArrayParameter = 1 << 13,
        /// <summary>
        /// Functions takes an IntPtr that corresponds to a size_t.
        /// Add an int32 overload for convenience.
        /// </summary>
        SizeParameter = 1 << 14,
    }

    #endregion

    static class Utilities
    {
        public static readonly char[] Separators = { ' ', '\n', ',', '(', ')', ';', '#' };
        public static Regex Extensions { get; private set; }
        public static Regex Acronyms { get; private set; }

        // Both GL and ES contains SGI extension enums, even though no function
        // uses them. This is a remnant from the glory days of gl.spec and GL 1.1.
        // Note: REMOVING THESE WILL BREAK BINARY-COMPATIBILITY WITH OPENTK 1.0,
        // WRT THE ES 1.1 API.
        // You have been warned.
        static List<string> extension_names = new List<string>
        {
            "SGI", "SGIS", "SGIX", "IBM", "AMD", "INTEL", 
        };

        public static void AddExtensions(IEnumerable<string> extensions)
        {
            // Merge the new extensions with the current list of extensions
            int extension_count = extension_names.Count;
            extension_names.AddRange(
                extensions.Where(n => !extension_names.Contains(n)));

            // If any new extensions have been added,
            // recreate the Extensions regex.
            if (extension_names.Count != extension_count)
            {
                // Sort longest extensions first, otherwise SGIS may be
                // incorrectly matched as SGI.
                extension_names.Sort((a, b) => b.Length.CompareTo(a.Length));

                Extensions = new Regex(
                    String.Join("|", extension_names.ToArray()),
                    RegexOptions.Compiled);

                var acronyms = new string[]
                {
                    "EGL",  "ES", "GL", "CL",
                    "RGBA", "BGRA", "RGB", "BGR",
                    "SRGB", "YCBCR",
                    "3TC", "DXT", "BPTC", "RGTC",
                    "3DC", "ATC", "ETC",
                    "ANGLE",  "MESAX", "MESA",
                };

                var acronym_names = extensions.Concat(acronyms).ToList();
                acronym_names.Sort((a, b) => b.Length.CompareTo(a.Length));
                Acronyms = new Regex(String.Join("|", acronym_names.ToArray()), RegexOptions.Compiled);
            }
        }

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

        public static readonly List<string> CSharpKeywords = new List<string>(
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
                if (!String.IsNullOrEmpty(s.ConstantCollection[t.Name].Reference))
                {
                    s.ConstantCollection[t.Name] = t;
                }
            }

            return s;
        }

        #endregion

        #region internal static string GetGL2Extension(string name)

        internal static string GetGL2Extension(string name)
        {
            return GetExtension(name, false);
        }

        internal static string GetExtension(string name, bool return_unmodified)
        {
            var match = Extensions.Match(name);
            if (match.Success)
            {
                string ext = match.Value;
                if (!return_unmodified)
                {
                    if (ext.Length > 2)
                    {
                        ext = ext[0] + ext.Substring(1).ToLower();
                    }
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

        public static bool RequiresSlot(this Delegate d, Settings settings)
        {
            double version;
            Double.TryParse(
                d.Version,
                System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture,
                out version);
            return
                !settings.IsEnabled(Settings.Legacy.UseDllImports) ||
                (settings.IsEnabled(Settings.Legacy.UseWindowsCompatibleGL) && version > 1.1) ||
                d.Extension != "Core";
        }
    }
}
