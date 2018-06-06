using System.Collections.Generic;
using System.Linq;

namespace Bind.Structures
{
    internal class DelegateCollection : IDictionary<string, List<DelegateDefinition>>
    {
        private readonly SortedDictionary<string, List<DelegateDefinition>> _delegates =
            new SortedDictionary<string, List<DelegateDefinition>>();

        public void Add(DelegateDefinition d)
        {
            if (!ContainsKey(d.Name))
            {
                Add(d.Name, new List<DelegateDefinition> { d });
            }
            else
            {
                var list = _delegates[d.Name];
                var index = list.FindIndex(w => w.CompareTo(d) == 0);
                if (index < 0)
                {
                    // Function not defined - add it!
                    list.Add(d);
                }
                else
                {
                    // Function redefined with identical parameters:
                    // merge their version and category properties and
                    // discard the duplicate definition
                    if (!list[index].Category.Contains(d.Category))
                    {
                        list[index].Category += "|" + d.Category;
                    }
                    if (string.IsNullOrEmpty(list[index].Version))
                    {
                        list[index].Version = d.Version;
                    }
                }
            }
        }

        public void AddRange(DelegateCollection delegates)
        {
            foreach (var d in delegates.Values.SelectMany(v => v))
            {
                Add(d);
            }
        }

        public void Add(string key, List<DelegateDefinition> value)
        {
            _delegates.Add(key, value.ToList());
        }

        public bool ContainsKey(string key)
        {
            return _delegates.ContainsKey(key);
        }

        public bool Remove(string key)
        {
            return _delegates.Remove(key);
        }

        public bool TryGetValue(string key, out List<DelegateDefinition> value)
        {
            return _delegates.TryGetValue(key, out value);
        }

        public List<DelegateDefinition> this[string index]
        {
            get => _delegates[index];
            set => _delegates[index] = value;
        }

        public ICollection<string> Keys => _delegates.Keys;

        public ICollection<List<DelegateDefinition>> Values => _delegates.Values;

        public void Add(KeyValuePair<string, List<DelegateDefinition>> item)
        {
            _delegates.Add(item.Key, item.Value.ToList());
        }

        public void Clear()
        {
            _delegates.Clear();
        }

        public bool Contains(KeyValuePair<string, List<DelegateDefinition>> item)
        {
            return _delegates.Contains(item);
        }

        public void CopyTo(KeyValuePair<string, List<DelegateDefinition>>[] array, int arrayIndex)
        {
            _delegates.CopyTo(array, arrayIndex);
        }

        public bool Remove(KeyValuePair<string, List<DelegateDefinition>> item)
        {
            return _delegates.Remove(item.Key);
        }

        public int Count => _delegates.Count;

        public bool IsReadOnly => false;

        public IEnumerator<KeyValuePair<string, List<DelegateDefinition>>> GetEnumerator()
        {
            return _delegates.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _delegates.GetEnumerator();
        }
    }
}
