using GeneratorV2.Data;
using System.Collections.Generic;

namespace GeneratorV2
{
    public class Extension : CommandEnumCollection
    {
        public string Vendor { get; }
        public string Name { get; }
        public string[] SupportedApis { get; }

        public Extension(string vendorName, string name, string[] supportedApis)
        {
            Vendor = vendorName;
            Name = name;
            SupportedApis = supportedApis;
        }
    }
}
