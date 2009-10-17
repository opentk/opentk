#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.XPath;

namespace Bind.Structures
{
    #region class Enum

    public class Enum
    {
        internal static EnumCollection GLEnums = new EnumCollection();
        internal static EnumCollection AuxEnums = new EnumCollection();

        static StringBuilder translator = new StringBuilder();
        string _name, _type;
        static bool enumsLoaded;

        #region Initialize

        internal static void Initialize(string enumFile, string enumextFile, string auxFile)
        {
            Initialize(enumFile, enumextFile);

            if (!String.IsNullOrEmpty(auxFile))
                using (StreamReader sr = new StreamReader(Path.Combine(Settings.InputPath, auxFile)))
                {
                    AuxEnums = MainClass.Generator.ReadEnums(sr);
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
                        GLEnums = MainClass.Generator.ReadEnums(sr);
                    }
                }

                if (!String.IsNullOrEmpty(enumextFile))
                {
                    using (StreamReader sr = Utilities.OpenSpecFile(Settings.InputPath, enumextFile))
                    {
                        foreach (Enum e in MainClass.Generator.ReadEnums(sr).Values)
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
        {
		}

        #endregion

        #region Public Members

        // Returns true if the enum contains a collection of flags, i.e. 1, 2, 4, 8, ...
        public bool IsFlagCollection
        {
            get
            {
                // It seems that all flag collections contain "Mask" in their names.
                // This looks like a heuristic, but it holds 100% in practice
                // (checked all enums to make sure).
                return Name.Contains("Mask");
            }
        }

        #region public string Name

        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value; }
        }
		
		// Typically 'long' or 'int'. Default is 'int'.
		public string Type
		{
			get { return String.IsNullOrEmpty(_type) ? "int" : _type; }
			set { _type = value; }
		}

        #endregion

        #region ConstantCollection

        Dictionary<string, Constant> _constant_collection = new Dictionary<string, Constant>();

        public IDictionary<string, Constant> ConstantCollection
        {
            get { return _constant_collection; }
        }

        #endregion

        #region TranslateName

        // Translate the constant's name to match .Net naming conventions
        public static string TranslateName(string name)
        {
            if (String.IsNullOrEmpty(name))
                return name;

            if (Utilities.Keywords.Contains(name))
                return name;

            translator.Remove(0, translator.Length);    // Trick to avoid allocating a new StringBuilder.

            if ((Settings.Compatibility & Settings.Legacy.NoAdvancedEnumProcessing) == Settings.Legacy.None)
            {
                // Detect if we just passed a '_' or a number and make the next char uppercase.
                bool is_after_underscore_or_number = true;
                // Detect if previous character was uppercase, and turn the current one to lowercase.
                bool is_previous_uppercase = false;

                foreach (char c in name)
                {
                    char char_to_add;
                    if (c == '_' || c == '-')
                        is_after_underscore_or_number = true;
                    else 
                    {
                        if (Char.IsDigit(c))
                            is_after_underscore_or_number = true;

                        char_to_add = is_after_underscore_or_number ? Char.ToUpper(c) :
                            is_previous_uppercase ? Char.ToLower(c) : c;
                        translator.Append(char_to_add);

                        is_previous_uppercase = Char.IsUpper(c);
                        is_after_underscore_or_number = false;
                    }
                }

                translator[0] = Char.ToUpper(translator[0]);
            }
            else
                translator.Append(name);

            translator.Replace("Pname", "PName");
            translator.Replace("SRgb", "Srgb");

            string ret = translator.ToString();
            if (ret.StartsWith(Settings.EnumPrefix))
                return ret.Substring(Settings.EnumPrefix.Length);
            return ret;
        }

        #endregion

        #region ToString

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            List<Constant> constants = new List<Constant>(ConstantCollection.Values);
            constants.Sort(delegate(Constant c1, Constant c2)
            {
                int ret = String.Compare(c1.Value, c2.Value);
                if (ret == 0)
                    return String.Compare(c1.Name, c2.Name);
                return ret;
            });

            if (IsFlagCollection)
                sb.AppendLine("[Flags]");
            sb.Append("public enum ");
			sb.Append(Name);
			sb.Append(" : ");
			sb.AppendLine(Type);
            sb.AppendLine("{");

            foreach (Constant c in constants)
            {
                sb.Append("    ");
                sb.Append(c.ToString());
                if (!String.IsNullOrEmpty(c.ToString()))
                    sb.AppendLine(",");
            }
            sb.Append("}");

            return sb.ToString();
        }

        #endregion

        #endregion
    }

    #endregion

    #region class EnumCollection

    public class EnumCollection : SortedDictionary<string, Enum>
    {
        internal void AddRange(EnumCollection enums)
        {
            foreach (Enum e in enums.Values)
                Utilities.Merge(this, e);
        }

        internal void Translate(XPathDocument overrides)
        {
            if (overrides == null)
                throw new ArgumentNullException("overrides");

            string path = "/overrides/replace/enum[@name='{0}']";

            // Translate enum names.
            {
                List<string> keys_to_update = new List<string>();
                foreach (Enum e in Values)
                {
                    string name = e.Name;

                    XPathNavigator enum_override = overrides.CreateNavigator().SelectSingleNode(String.Format(path, name));
                    if (enum_override != null)
                    {
                        XPathNavigator name_override = enum_override.SelectSingleNode("name");
                        if (name_override != null)
                        {
                            name = name_override.Value;
                        }
                    }

                    name = Enum.TranslateName(name);
                    if (name != e.Name)
                    {
                        keys_to_update.Add(e.Name);
                        e.Name = name;
                    }
                }

                foreach (string name in keys_to_update)
                {
                    Enum e = this[name];
                    Remove(name);
                    Add(e.Name, e);
                }

                keys_to_update = null;
            }

            foreach (Enum e in Values)
            {
                XPathNavigator enum_override = overrides.CreateNavigator().SelectSingleNode(String.Format(path, e.Name));
                foreach (Constant c in e.ConstantCollection.Values)
                {
                    if (enum_override != null)
                    {
                        XPathNavigator constant_override = enum_override.SelectSingleNode(String.Format("token[@name='{0}']", c.PreviousName)) ??
                            enum_override.SelectSingleNode(String.Format("token[@name={0}]", c.Name));
                        if (constant_override != null)
                        {
                            foreach (XPathNavigator node in constant_override.SelectChildren(XPathNodeType.Element))
                            {
                                switch (node.Name)
                                {
                                    case "name": c.Name = (string)node.TypedValue; break;
                                    case "value": c.Value = (string)node.TypedValue; break;
                                }
                            }
                        }
                    }

                    // There are cases when a value is an aliased constant, with no enum specified.
                    // (e.g. FOG_COORD_ARRAY_TYPE = GL_FOG_COORDINATE_ARRAY_TYPE)
                    // In this case try searching all enums for the correct constant to alias (stupid opengl specs).
                    if (String.IsNullOrEmpty(c.Reference) && !Char.IsDigit(c.Value[0]))
                    {
                        foreach (Enum @enum in Values)
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

            foreach (Enum e in Values)
            {
            restart:
                foreach (Constant c in e.ConstantCollection.Values)
                {
                    bool result = Constant.TranslateConstantWithReference(c, Enum.GLEnums, Enum.AuxEnums);
                    if (!result)
                    {
                        e.ConstantCollection.Remove(c.Name);
                        goto restart;
                    }
                }
            }

            if (Settings.DropMultipleTokens)
            {
                // When there are multiple tokens with the same value but different extension
                // drop the duplicates. Order of preference: core > ARB > EXT > vendor specific

                List<Constant> removed_tokens = new List<Constant>();

                foreach (Enum e in Values)
                {
                    if (e.Name == "All")
                        continue;

                    // This implementation is a not very bright O(n^2).
                    foreach (Constant c in e.ConstantCollection.Values)
                    {
                        foreach (Constant c2 in e.ConstantCollection.Values)
                        {
                            if (c.Name != c2.Name && c.Value == c2.Value)
                            {
                                int prefer = OrderOfPreference(Utilities.GetGL2Extension(c.Name), Utilities.GetGL2Extension(c2.Name));
                                if (prefer == -1)
                                    removed_tokens.Add(c2);
                                else if (prefer == 1)
                                    removed_tokens.Add(c);
                            }
                        }
                    }

                    foreach (Constant c in removed_tokens)
                        e.ConstantCollection.Remove(c.Name);
                    removed_tokens.Clear();
                }
            }
        }

        // Return -1 for ext1, 1 for ext2 or 0 if no preference.
        int OrderOfPreference(string ext1, string ext2)
        {
            // If one is empty and the other not, prefer the empty one (empty == core)
            // Otherwise check for Arb and Ext. To reuse the logic for the
            // empty check, let's try to remove first Arb, then Ext from the strings.
            int ret = PreferEmpty(ext1, ext2);
            if (ret != 0)
                return ret;
            
            ext1 = ext1.Replace("Arb", ""); ext2 = ext2.Replace("Arb", "");
            ret = PreferEmpty(ext1, ext2);
            if (ret != 0)
                return ret;
            
            ext1 = ext1.Replace("Ext", ""); ext2 = ext2.Replace("Ext", "");
            return PreferEmpty(ext1, ext2);
        }

        // Prefer the empty string over the non-empty.
        int PreferEmpty(string ext1, string ext2)
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
