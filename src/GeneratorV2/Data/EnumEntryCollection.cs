using System.Collections;
using System.Collections.Generic;
using System.Linq;


#nullable enable
namespace GeneratorV2.Data
{
    public class EnumEntryCollection : IEnumerable<KeyValuePair<string, EnumEntry>>, IEnumerable
    {
        private readonly IEnumerable<KeyValuePair<string, EnumEntry>> _enumerable;

        private Dictionary<string, EnumEntry> Enums { get; } = new Dictionary<string, EnumEntry>();

        private Dictionary<string, List<EnumEntry>> ApiSpecificEnums { get; } = new Dictionary<string, List<EnumEntry>>();

        public EnumEntryCollection()
        {
            _enumerable = Enums.Concat(ApiSpecificEnums.SelectMany(x => x.Value, (kvp, enumEntry) => new KeyValuePair<string, EnumEntry>(kvp.Key, enumEntry)));
        }

        public int Count => Enums.Count + ApiSpecificEnums.Count;

        public void Add(EnumEntry entry)
        {
            if (entry.Api == null)
            {
                Enums.TryAdd(entry.Name, entry);
            }
            else
            {
                List<EnumEntry> enumEntryList;
                if (!ApiSpecificEnums.TryGetValue(entry.Name, out enumEntryList))
                {
                    enumEntryList = new List<EnumEntry>();
                    ApiSpecificEnums.Add(entry.Name, enumEntryList);
                }
                enumEntryList.Add(entry);
            }
        }

        public bool TryGetValue(string name, string api, out EnumEntry entry)
        {
            if (Enums.TryGetValue(name, out entry))
            {
                return true;
            }
            List<EnumEntry> source;
            if (!ApiSpecificEnums.TryGetValue(name, out source))
            {
                return false;
            }
            entry = source.FirstOrDefault(x => x.Api == api);
            return entry != null;
        }

        public EnumEntry[] GetValues(string name, string api)
        {
            EnumEntry enumEntry;
            List<EnumEntry> source;
            if (Enums.TryGetValue(name, out enumEntry))
            {
                return new [] { enumEntry };
            }
            if (ApiSpecificEnums.TryGetValue(name, out source))
            {
                return source.Where(e => e.Api == null || api == e.Api).ToArray();
            }
            return new EnumEntry[0];
        }

        public IEnumerator<KeyValuePair<string, EnumEntry>> GetEnumerator()
        {
            return _enumerable.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
