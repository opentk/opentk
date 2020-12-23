using System.Collections.Generic;

namespace GeneratorV2.Data
{
    public abstract class CommandEnumCollection
    {
        public Dictionary<string, HashSet<EnumEntry>> EnumGroups { get; } = new Dictionary<string, HashSet<EnumEntry>>();

        public EnumEntryCollection EnumEntries { get; } = new EnumEntryCollection();

        public Dictionary<string, Command2> Commands { get; } = new Dictionary<string, Command2>();

        public string Api { get; }
        public string Name { get; }

        protected CommandEnumCollection(string api, string name)
        {
            Api = api;
            Name = name;
        }

        public void Add(EnumEntry entry)
        {
            foreach (string group in entry.Groups)
            {
                if (!EnumGroups.TryGetValue(group, out var enumEntrySet))
                {
                    enumEntrySet = new HashSet<EnumEntry>();
                    EnumGroups.Add(group, enumEntrySet);
                }
                enumEntrySet.Add(entry);
            }
            EnumEntries.Add(entry);
        }
    }
}
