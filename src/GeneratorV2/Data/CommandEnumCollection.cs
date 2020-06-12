using System.Collections.Generic;

namespace GeneratorV2.Data
{
    public class CommandEnumCollection
    {
        public Dictionary<string, HashSet<EnumEntry>> EnumGroups { get; } = new Dictionary<string, HashSet<EnumEntry>>();

        public EnumEntryCollection EnumEntries { get; } = new EnumEntryCollection();

        public Dictionary<string, Command> Commands { get; } = new Dictionary<string, Command>();

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

        public void Add(Command command)
        {
            Commands.TryAdd(command.Method.EntryPoint, command);
        }
    }
}
