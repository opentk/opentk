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
            var videoSpecData = SpecificationParser.ParseVideo(videoSpecificationStream);

            Processor.ApplyFeatureEnums(specData);
            Processor.ApplyExtensionEnums(specData);
            Processor.ApplyVideoEnums(specData, videoSpecData);
            Processor.ResolveEnumUnderlyingTypes(specData);
            Processor.ResolveEnumUnderlyingTypes(videoSpecData);
            var typeMap = Processor.BuildTypeMap(specData, videoSpecData);

            Processor.ApplyExtensionConstants(specData);
            Processor.ApplyExtensionConstants(videoSpecData);
            var constMap = Processor.BuildConstantsMap(specData, videoSpecData);

            Processor.ResolveStructMemberTypes(specData, typeMap, constMap);
            Processor.ResolveCommandTypes(specData, typeMap);
            Processor.ResolveVersionInfo(specData, typeMap);

            Processor.ResolveStructMemberTypes(videoSpecData, typeMap, constMap);

            Processor.SortMembers(specData);
            Processor.SortMembers(videoSpecData);

            Writer.Write(specData, videoSpecData);
            Writer.WriteVideo(videoSpecData);

            watch.Stop();

            Console.WriteLine($"Wrote vulkan bindings in {watch.Elapsed.TotalMilliseconds}ms");
        }
    }
}
