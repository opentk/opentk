using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorV2.Data
{
    public class Feature
    {
        public string Name {get;}
        public string Api {get;}
        public Version Version {get;}
        public Dictionary<string, EnumEntry> EnumEntries { get; } = new Dictionary<string, EnumEntry>();
        public Dictionary<string, Command> Commands { get; } = new Dictionary<string, Command>();

        public Feature(string api, string name, Version version)
        {
            Api = api;
            Name = name;
            Version = version;
        }

        public void Add(EnumEntry entry)
        {
            EnumEntries.TryAdd(entry.Name, entry);
        }
        public void Add(Command command)
        {
            Commands.TryAdd(command.Method.EntryPoint, command);
        }
        public void Add(Feature feature, HashSet<string> excludeEnums, HashSet<string> excludeCommands)
        {
            foreach(var (eName, eEntry) in feature.EnumEntries)
            {
                if (!excludeEnums.Contains(eName))
                {
                    Add(eEntry);
                }
            }
            foreach(var (cName, cEntry) in feature.Commands)
            {
                if (!excludeCommands.Contains(cName))
                {
                    Add(cEntry);
                }
            }
        }
    }
}
