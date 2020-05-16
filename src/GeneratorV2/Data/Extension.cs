using GeneratorV2.Data;
using System.Collections.Generic;

namespace GeneratorV2
{
    public class Extension
    {
        public string Vendor { get; }
        public string Name { get; }
        public string[] SupportedApis { get; }
        public Dictionary<string, List<EnumEntry>> EnumGroups { get; } = new Dictionary<string, List<EnumEntry>>();
        public Dictionary<string, EnumEntry> EnumEntries { get; } = new Dictionary<string, EnumEntry>();
        public Dictionary<string, Command> Commands { get; } = new Dictionary<string, Command>();

        public Extension(string vendorName, string name, string[] supportedApis)
        {
            Vendor = vendorName;
            Name = name;
            SupportedApis = supportedApis;
        }

        public void Add(EnumEntry entry)
        {
            foreach (var group in entry.Groups)
            {
                if (!EnumGroups.TryGetValue(group, out var groupEntries))
                {
                    groupEntries = new List<EnumEntry>();
                    EnumGroups.Add(group, groupEntries);
                }
                groupEntries.Add(entry);
            }
            EnumEntries.TryAdd(entry.Name, entry);
        }
        public void Add(Command command)
        {
            Commands.TryAdd(command.Method.EntryPoint, command);
        }
    }
}
