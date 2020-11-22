using GeneratorV2.Data;
using System.Collections.Generic;

namespace GeneratorV2
{
    public class Extension
    {
        public readonly string Name;
        public readonly string Vendor;
        public readonly GLAPI[] SupportedApis;
        public readonly string? Comment;
        public List<RequireEntry> Requires;

        public Extension(string name, string vendor, GLAPI[] supportedApis, string? comment, List<RequireEntry> requires)
        {
            Name = name;
            Vendor = vendor;
            SupportedApis = supportedApis;
            Comment = comment;
            Requires = requires;
        }
    }
}
