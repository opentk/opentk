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

    sealed class Enum : Type, IComparable<Enum>
    {
        string _name, _type;

        public Enum()
        {
        }

        public Enum(Type type, Enum e)
            : base(type)
        {
            Name = e.Name;
            BaseType = e.BaseType;
            foreach (var c in e.ConstantCollection)
            {
                ConstantCollection.Add(c);
            }
        }

        public override object Clone()
        {
            return new Enum(this, this);
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

        public override string CurrentType
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        // Typically 'long' or 'int'. Default is 'int'.
        public string BaseType
        {
            get { return String.IsNullOrEmpty(_type) ? "int" : _type; }
            set { _type = value; }
        }

        public override bool IsEnum
        {
            get
            {
                return true;
            }
        }

        public string Obsolete { get; set; }

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

        // Use only for debugging, not for code generation.
        public override string ToString()
        {
            return String.Format("enum {0} : {1} {{ {2} }}",
                Name,
                BaseType,
                String.Join(";", ConstantCollection.Values.Select(v => v.Name).ToArray()));
        }

        public void Add(Constant constant)
        {
            ConstantCollection.Add(constant.Name, constant);
        }

        #region IComparable<Enum> Members

        public override int CompareTo(Type other)
        {
            if (other is Enum)
            {
                return CompareTo((Enum)other);
            }
            return base.CompareTo(other);
        }

        public int CompareTo(Enum e)
        {
            int result = Name.CompareTo(e.Name);
            if (result == 0)
                result = base.CompareTo(e);
            return result;
        }

        #endregion
    }

    #endregion

    #region class EnumCollection

    class EnumCollection : IDictionary<string, Enum>
    {
        Dictionary<string, Enum> Enumerations = new Dictionary<string, Enum>();

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
                foreach (var token in e.ConstantCollection.Values)
                {
                    Utilities.Merge(value, token);
                }
                this[key] = value; // Make sure the Enum properties are up-to-date
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
            Array.Copy(Enumerations.ToArray(), 0, array, arrayIndex, array.Length);
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
