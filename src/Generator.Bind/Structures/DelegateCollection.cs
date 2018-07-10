using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace Bind.Structures
{
    /// <summary>
    /// Represents a collection of delegate definitions, mapped as a pair of a name and a list of overloads.
    /// </summary>
    internal class DelegateCollection : IDictionary<string, List<DelegateDefinition>>
    {
        private readonly SortedDictionary<string, List<DelegateDefinition>> _delegates =
            new SortedDictionary<string, List<DelegateDefinition>>();

        /// <summary>
        /// Adds a new <see cref="DelegateDefinition"/> to the collection, creating a new overload list if it's not
        /// already in the collection, or adding it to an existing one if there is.
        /// </summary>
        /// <param name="d">The delegate definition.</param>
        public void Add([NotNull] DelegateDefinition d)
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

        /// <summary>
        /// Adds a range of new <see cref="DelegateDefinition"/>s to the collection, creating a new overload list for
        /// each definition in the new collection if it's not already in the collection, or adding it to an existing
        /// one if there is.
        /// </summary>
        /// <param name="delegates">The set of delegate definitions.</param>
        public void AddRange([NotNull] DelegateCollection delegates)
        {
            foreach (var d in delegates.Values.SelectMany(v => v))
            {
                Add(d);
            }
        }

        /// <inheritdoc/>
        public void Add(string key, [NotNull] List<DelegateDefinition> value)
        {
            _delegates.Add(key, value.ToList());
        }

        /// <inheritdoc/>
        public bool ContainsKey(string key)
        {
            return _delegates.ContainsKey(key);
        }

        /// <inheritdoc/>
        public bool Remove(string key)
        {
            return _delegates.Remove(key);
        }

        /// <inheritdoc/>
        public bool TryGetValue(string key, out List<DelegateDefinition> value)
        {
            return _delegates.TryGetValue(key, out value);
        }

        /// <inheritdoc/>
        public List<DelegateDefinition> this[string index]
        {
            get => _delegates[index];
            set => _delegates[index] = value;
        }

        /// <inheritdoc/>
        public ICollection<string> Keys => _delegates.Keys;

        /// <inheritdoc/>
        public ICollection<List<DelegateDefinition>> Values => _delegates.Values;

        /// <inheritdoc/>
        public void Add(KeyValuePair<string, List<DelegateDefinition>> item)
        {
            _delegates.Add(item.Key, item.Value.ToList());
        }

        /// <inheritdoc/>
        public void Clear()
        {
            _delegates.Clear();
        }

        /// <inheritdoc/>
        public bool Contains(KeyValuePair<string, List<DelegateDefinition>> item)
        {
            return _delegates.Contains(item);
        }

        /// <inheritdoc/>
        public void CopyTo(KeyValuePair<string, List<DelegateDefinition>>[] array, int arrayIndex)
        {
            _delegates.CopyTo(array, arrayIndex);
        }

        /// <inheritdoc/>
        public bool Remove(KeyValuePair<string, List<DelegateDefinition>> item)
        {
            return _delegates.Remove(item.Key);
        }

        /// <inheritdoc/>
        public int Count => _delegates.Count;

        /// <inheritdoc/>
        public bool IsReadOnly => false;

        /// <inheritdoc/>
        public IEnumerator<KeyValuePair<string, List<DelegateDefinition>>> GetEnumerator()
        {
            return _delegates.GetEnumerator();
        }

        /// <inheritdoc/>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _delegates.GetEnumerator();
        }
    }
}
