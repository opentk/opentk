using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using VkGenerator.Parsing;
using VkGenerator.Process;
using GeneratorBase.Utility;

namespace VkGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            using Logger logger = Logger.CreateLogger(Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location)!, "log.txt"));

            Stopwatch watch = Stopwatch.StartNew();

            // These prevent us to accidently generate wrong code because of
            // locale dependent string functions.
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;

            using FileStream specificationStream = Reader.ReadVKSpecFromGithub();
            using FileStream videoSpecificationStream = Reader.ReadVKVideoSpecFromGithub();

            var specData = SpecificationParser.Parse(specificationStream);

            // Specific parsing for video.xml is it seems to be just slightly different.
            var videoSpecData = SpecificationParser.ParseVideo(videoSpecificationStream);

            Processor.ApplyFeatureEnums(specData);
            Processor.ApplyExtensionEnums(specData);
            Processor.ResolveEnumUnderlyingTypes(specData);
            Processor.ResolveEnumUnderlyingTypes(videoSpecData);
            var typeMap = Processor.BuildTypeMap(specData, videoSpecData);

            Processor.ApplyExtensionConstants(specData);
            Processor.ApplyExtensionConstants(videoSpecData);
            var constMap = Processor.BuildConstantsMap(specData, videoSpecData);

            Processor.ResolveStructMemberTypes(specData, typeMap, constMap);
            Processor.ResolveHandleParent(specData);
            Processor.ResolveCommandTypes(specData, typeMap);
            Processor.ResolveVersionInfo(specData, typeMap);
            Processor.MarkDeprecations(specData);

            Processor.ResolveStructMemberTypes(videoSpecData, typeMap, constMap);
            Processor.ResolveVersionInfo(videoSpecData, typeMap);
            Processor.MarkDeprecations(videoSpecData);

            Processor.SortMembers(specData);
            Processor.SortMembers(videoSpecData);

            NameManglerSettings settings = new NameManglerSettings()
            {
                ExtensionPrefixes = ["VK_"],
                FunctionPrefix = "vk",
                EnumPrefixes = ["VK_", "STD_"],
                FunctionsWithoutPrefix = [],
                EnumsWithoutPrefix = [],
                DefinePrefix = "VK_"
            };

            NameMangler mangler = new NameMangler(settings);

            Writer.Write(specData, videoSpecData, mangler);
            Writer.WriteVideo(videoSpecData, mangler);

            watch.Stop();

            Console.WriteLine($"Wrote vulkan bindings in {watch.Elapsed.TotalMilliseconds}ms");
        }
    }
}
