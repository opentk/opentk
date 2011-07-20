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
        static StringBuilder translator = new StringBuilder();
        string _name, _type;

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

        Dictionary<string, Constant> _constant_collection = new Dictionary<string, Constant>();

        public IDictionary<string, Constant> ConstantCollection
        {
            get { return _constant_collection; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                
                _constant_collection.Clear();
                foreach (var item in value)
                {
                    _constant_collection.Add(item.Key, item.Value);
                }
            }
        }

        [Obsolete("This code belongs to the various language-specific ISpecWriter implementations")]
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
