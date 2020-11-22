using System.Collections.Generic;

namespace GeneratorV2.Data
{
    public class Api
    {
        public string Name { get; }

        public readonly List<Extension> Extensions;

        public readonly List<Feature> Features;

        public readonly EnumEntryCollection AllEnums;

        public Api(string name, List<Extension> extensions, List<Feature> features, EnumEntryCollection allEnums)
        {
            this.Name = name;
            Extensions = extensions;
            Features = features;
            AllEnums = allEnums;
        }
    }
}
