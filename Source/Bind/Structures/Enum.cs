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
    #region class Enum

    public class Enum
    {
        internal static EnumCollection GLEnums = new EnumCollection();
        internal static EnumCollection AuxEnums = new EnumCollection();

        static StringBuilder translator = new StringBuilder();
        string _name;
        static bool enumsLoaded;

        #region Initialize

        internal static void Initialize(string enumFile, string enumextFile, string auxFile)
        {
            Initialize(enumFile, enumextFile);

            using (System.IO.StreamReader sr = new System.IO.StreamReader(Path.Combine(Settings.InputPath, auxFile)))
            {
                AuxEnums = Bind.MainClass.Generator.ReadEnums(sr);
            }
        }

        internal static void Initialize(string enumFile, string enumextFile)
        {
            if (!enumsLoaded)
            {
                if (!String.IsNullOrEmpty(enumFile))
                {
                    using (StreamReader sr = Utilities.OpenSpecFile(Settings.InputPath, enumFile))
                    {
                        GLEnums = Bind.MainClass.Generator.ReadEnums(sr);
                    }
                }

                if (!String.IsNullOrEmpty(enumextFile))
                {
                    using (StreamReader sr = Utilities.OpenSpecFile(Settings.InputPath, enumextFile))
                    {
                        foreach (Bind.Structures.Enum e in Bind.MainClass.Generator.ReadEnums(sr).Values)
                        {
                            //enums.Add(e.Name, e);
                            Utilities.Merge(GLEnums, e);
                        }
                    }
                }

                enumsLoaded = true;
            }
        }

        #endregion

        #region Constructors

        public Enum()
        { }

        public Enum(string name)
        {
            Name = name;
        }

        #endregion

        #region public string Name

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        #endregion

        System.Collections.Hashtable _constant_collection = new System.Collections.Hashtable();

        public System.Collections.Hashtable ConstantCollection
        {
            get { return _constant_collection; }
            //set { _constant_collection = value; }
        }

        public static string TranslateName(string name)
        {
            translator.Remove(0, translator.Length);    // Trick to avoid allocating a new StringBuilder.

            // Translate the constant's name to match .Net naming conventions
            if ((Settings.Compatibility & Settings.Legacy.NoAdvancedEnumProcessing) == Settings.Legacy.None)
            {
                bool is_after_underscore = true;    // Detect if we just passed a '_' and make the next char
                                                    // uppercase.
                bool is_previous_uppercase = false; // Detect if previous character was uppercase, and turn
                                                    // the current one to lowercase.

                foreach (char c in name)
                {
                    char char_to_add;
                    if (c != '_')
                    {
                        char_to_add = is_after_underscore ? Char.ToUpper(c) :
                            is_previous_uppercase ? Char.ToLower(c) : c;
                        is_previous_uppercase = Char.IsUpper(c);
                        translator.Append(char_to_add);
                        is_after_underscore = false;
                    }
                    else
                        is_after_underscore = true;
                }

                translator[0] = Char.ToUpper(translator[0]);
            }
            else
                translator.Append(name);

            translator.Replace("Pname", "PName");
            translator.Replace("SRgb", "Srgb");
            return translator.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("public enum " + Name);
            sb.AppendLine("{");
            foreach (Constant c in ConstantCollection.Values)
            {
                sb.Append("    ");
                sb.Append(c.ToString());
                if (!String.IsNullOrEmpty(c.ToString()))
                    sb.AppendLine(",");
            }
            sb.Append("}");

            return sb.ToString();
        }
    }

    #endregion

    #region class EnumCollection

    public class EnumCollection : Dictionary<string, Enum>
    {
        internal void AddRange(EnumCollection enums)
        {
            foreach (Enum e in enums.Values)
                Utilities.Merge(this, e);
        }

        internal void Translate()
        {
            // Translate enum names.
            {
                List<string> keys_to_update = new List<string>();
                foreach (Enum e in this.Values)
                {
                    string name = Enum.TranslateName(e.Name);
                    if (name != e.Name)
                    {
                        keys_to_update.Add(e.Name);
                        e.Name = name;
                    }
                }

                foreach (string name in keys_to_update)
                {
                    Enum e = this[name];
                    this.Remove(name);
                    this.Add(e.Name, e);
                }

                keys_to_update = null;
            }

            foreach (Enum e in this.Values)
            {
                foreach (Constant c in e.ConstantCollection.Values)
                {
                    // There are cases when a value is an aliased constant, with no enum specified.
                    // (e.g. FOG_COORD_ARRAY_TYPE = GL_FOG_COORDINATE_ARRAY_TYPE)
                    // In this case try searching all enums for the correct constant to alias (stupid opengl specs).
                    if (String.IsNullOrEmpty(c.Reference) && !Char.IsDigit(c.Value[0]))
                    {
                        foreach (Enum @enum in this.Values)
                        {
                            // Skip generic GLenum
                            if (@enum.Name == "GLenum")
                                continue;

                            if (@enum.ConstantCollection.ContainsKey(c.Value))
                            {
                                c.Reference = @enum.Name;
                                break;
                            }
                        }
                    }
                }
            }

            foreach (Enum e in this.Values)
                foreach (Constant c in e.ConstantCollection.Values)
                    Constant.TranslateConstantWithReference(c, Enum.GLEnums, Enum.AuxEnums);

            // When there are multiple tokens with the same value but different extension
            // drop the duplicates. Order of preference: core > ARB > EXT > vendor specific
            foreach (Enum e in this.Values)
            {
                if (e.Name == "All")
                    continue;

                foreach (Constant c in e.ConstantCollection.Values)
                    foreach (Constant c2 in e.ConstantCollection.Values)
                    {
                        if (c.Name != c2.Name && c.Value == c2.Value)
                        {
                            if (c.Name.Contains(Constant.Translate("TEXTURE_DEFORMATION_BIT_SGIX")) ||
                                c2.Name.Contains(Constant.Translate("TEXTURE_DEFORMATION_BIT_SGIX")))
                            {
                            }

                            int prefer = OrderOfPreference(Utilities.GetGL2Extension(c.Name), Utilities.GetGL2Extension(c2.Name));
                            if (prefer == -1)
                            {
                                c2.Name = "";
                                c2.Value = "";
                            }
                            else if (prefer == 1)
                            {
                                c.Name = "";
                                c.Value = "";
                            }
                        }
                    }
            }
        }

        // Return -1 for ext1, 1 for ext2 or 0 if no preference.
        int OrderOfPreference(string ext1, string ext2)
        {
            // If one is empty and the other note, prefer the empty one.
            // (empty == core)
            // Otherwise check for Arb and Ext. To reuse the logic for the
            // empty check, let's try to remove first Arb, then Ext from the strings.
            int ret;
            ret = OrderOfPreferenceInternal(ext1, ext2);
            if (ret != 0) return ret;
            ext1 = ext1.Replace("Arb", ""); ext2 = ext2.Replace("Arb", "");
            ret = OrderOfPreferenceInternal(ext1, ext2);
            if (ret != 0) return ret;
            ext1 = ext1.Replace("Ext", ""); ext2 = ext2.Replace("Ext", "");
            return ret;
        }

        // Prefer the empty string over the non-empty.
        int OrderOfPreferenceInternal(string ext1, string ext2)
        {
            if (String.IsNullOrEmpty(ext1) && !String.IsNullOrEmpty(ext2))
                return -1;
            else if (String.IsNullOrEmpty(ext2) && !String.IsNullOrEmpty(ext1))
                return 1;
            else
                return 0;
        }

        new bool TryGetValue(string key, out Enum value)
        {
            return base.TryGetValue(key, out value);
        }
    }

    #endregion
}
