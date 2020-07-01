using GeneratorV2.Data;
using System.IO;
using System.Xml.Linq;


#nullable enable
namespace GeneratorV2.Parsing
{
    public class Parser : IParser<Stream>
    {
        public void Parse(Stream input, Specification output)
        {
            var xdocument = XDocument.Load(input);
            new CommandParser().Parse(xdocument.Root, output);
            new EnumParser().Parse(xdocument.Root, output);
            new FeatureParser().Parse(xdocument.Root, output);
            new ExtensionParser().Parse(xdocument.Root, output);
        }

        public int Priority
        {
            get
            {
                return -1;
            }
        }
    }
}
