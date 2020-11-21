using GeneratorV2.Data;
using System.IO;
using System.Xml.Linq;


#nullable enable
namespace GeneratorV2.Parsing
{
    public class Parser
    {
        public Specification Parse(Stream input)
        {
            var xdocument = XDocument.Load(input);
            var commands = new CommandParser().Parse(xdocument.Root);
            var enums =  new EnumParser().Parse(xdocument.Root);
            var features = new FeatureParser().Parse(xdocument.Root, commands, enums);
            var extensions = new ExtensionParser().Parse(xdocument.Root, commands, enums);

            return new Specification(null, commands, enums);
        }
    }
}
