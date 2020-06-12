using System.Collections.Generic;

namespace GeneratorV2.Data
{
    public class Api
    {
        public string Name { get; }

        public ApiExtension Extensions { get; } = new ApiExtension();

        public List<Feature> Features { get; } = new List<Feature>();

        public EnumEntryCollection AllEnum { get; } = new EnumEntryCollection();

        public Api(string name)
        {
            this.Name = name;
        }

        public void AddEnums(CommandEnumCollection collection)
        {
            foreach ((string _, EnumEntry entry) in collection.EnumEntries)
                this.AllEnum.Add(entry);
        }
    }
}
