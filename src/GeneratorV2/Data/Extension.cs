using GeneratorV2.Data;

namespace GeneratorV2
{
    public class Extension : CommandEnumCollection
    {
        public string Vendor { get; }
        public string Name { get; }
        public string SupportedApi { get; }

        public Extension(string vendorName, string name, string supportedApi)
        {
            Vendor = vendorName;
            Name = name;
            SupportedApi = supportedApi;
        }
    }
}
