using System;
using System.Collections.Generic;

namespace GeneratorV2.Data
{
    public class Feature : CommandEnumCollection
    {
        public Version Version {get;}

        public Feature(string api, string name, Version version)
            : base(api, name)
        {
            Version = version;
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
