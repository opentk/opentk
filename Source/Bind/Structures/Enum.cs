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

    class Enum
    {
        string _name, _type;

        public Enum()
        {
            CLSCompliant = true;
        }

        // Returns true if the enum contains a collection of flags, i.e. 1, 2, 4, 8, ...
        public bool IsFlagCollection
        {
            get; set;
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

        SortedDictionary<string, Constant> _constant_collection = new SortedDictionary<string, Constant>();

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

        // Use only for debugging, not for code generation.
        public override string ToString()
        {
            return String.Format("enum {0} : {1} {{ {2} }}",
                Name,
                Type,
                ConstantCollection);
        }

        public void Add(Constant constant)
        {
            ConstantCollection.Add(constant.Name, constant);
        }

        public string Obsolete { get; set; }
        public bool IsObsolete { get { return !String.IsNullOrEmpty(Obsolete); } }

        public bool CLSCompliant { get; set; }
    }

    #endregion

    #region class EnumCollection

    class EnumCollection : IDictionary<string, Enum>
    {
        SortedDictionary<string, Enum> Enumerations = new SortedDictionary<string, Enum>();

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

        #region Public Members

        public void Add(Enum e)
        {
            Add(e.Name, e);
        }

        public void AddRange(EnumCollection enums)
        {
            foreach (Enum e in enums.Values)
            {
                Add(e);
            }
        }

        #endregion

        #region IDictionary<string, Enum> Members

        public void Add(string key, Enum value)
        {
            if (ContainsKey(key))
            {
                var e = this[key];
                foreach (var token in value.ConstantCollection.Values)
                {
                    Utilities.Merge(e, token);
                }
            }
            else
            {
                Enumerations.Add(key, value);
            }
        }

        public bool ContainsKey(string key)
        {
            return Enumerations.ContainsKey(key);
        }

        public ICollection<string> Keys
        {
            get { return Enumerations.Keys; }
        }

        public bool Remove(string key)
        {
            return Enumerations.Remove(key);
        }

        public bool TryGetValue(string key, out Enum value)
        {
            return Enumerations.TryGetValue(key, out value);
        }

        public ICollection<Enum> Values
        {
            get { return Enumerations.Values; }
        }

        public Enum this[string key]
        {
            get
            {
                return Enumerations[key];
            }
            set
            {
                Enumerations[key] = value;
            }
        }

        public void Add(KeyValuePair<string, Enum> item)
        {
            Enumerations.Add(item.Key, item.Value);
        }

        public void Clear()
        {
            Enumerations.Clear();
        }

        public bool Contains(KeyValuePair<string, Enum> item)
        {
            return Enumerations.Contains(item);
        }

        public void CopyTo(KeyValuePair<string, Enum>[] array, int arrayIndex)
        {
            Enumerations.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return Enumerations.Count; }
        }

        public bool IsReadOnly
        {
            get { return (Enumerations as IDictionary<string, Enum>).IsReadOnly; }
        }

        public bool Remove(KeyValuePair<string, Enum> item)
        {
            return Enumerations.Remove(item.Key);
        }

        public IEnumerator<KeyValuePair<string, Enum>> GetEnumerator()
        {
            return Enumerations.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return Enumerations.GetEnumerator();
        }

        #endregion
    }

    #endregion
}
