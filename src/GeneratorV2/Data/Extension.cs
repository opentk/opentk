using GeneratorV2.Data;

namespace GeneratorV2
{
    public class Extension : CommandEnumCollection
    {
        public string Vendor { get; }

        public Extension(string api, string name, string vendorName)
            : base(api, name)
        {
            Vendor = vendorName;
        }
    }
}
