using System.Diagnostics;
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

            Stopwatch watch = Stopwatch.StartNew();

            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;

            using FileStream specificationStream = Reader.ReadVKSpecFromGithub();

            var specData = SpecificationParser.Parse(specificationStream);

            Processor.ApplyFeatureEnums(specData);
            Processor.ApplyExtensionEnums(specData);

            var typeMap = Processor.BuildTypeMap(specData);
            Processor.ResolveStructMemberTypes(specData, typeMap);
            Processor.ResolveCommandTypes(specData, typeMap);

            Writer.Write(specData);

            watch.Stop();

            Console.WriteLine($"Wrote vulkan bindings in {watch.Elapsed.TotalMilliseconds}ms");
        }
    }
}
