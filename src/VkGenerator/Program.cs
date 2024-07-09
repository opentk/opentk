using System.Globalization;
using VkGenerator.Parsing;
using VkGenerator.Process;

namespace VkGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;

            using FileStream specificationStream = Reader.ReadVKSpecFromGithub();

            var specData = SpecificationParser.Parse(specificationStream);

            Processor.ResolveStructMemberTypes(specData);

            Writer.Write(specData);
        }
    }
}
