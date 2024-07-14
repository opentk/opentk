using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using VkGenerator.Parsing;
using VkGenerator.Process;
using VkGenerator.Utility;

namespace VkGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            using Logger logger = Logger.CreateLogger(Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location)!, "log.txt"));

            Stopwatch watch = Stopwatch.StartNew();

            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;

            using FileStream specificationStream = Reader.ReadVKSpecFromGithub();
            using FileStream videoSpecificationStream = Reader.ReadVKVideoSpecFromGithub();

            var specData = SpecificationParser.Parse(specificationStream);

            // Specific parsing for video.xml is it seems to be just slightly different.
            //var videoSpecData = SpecificationParser.Parse(videoSpecificationStream);

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
