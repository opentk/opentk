using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using XrGenerator.Parsing;
using XrGenerator.Process;
using XrGenerator.Utility;

namespace XrGenerator
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

            using FileStream specificationStream = Reader.ReadXRSpecFromGithub();

            var specData = SpecificationParser.Parse(specificationStream);

            Processor.ApplyFeatureEnums(specData);
            Processor.ApplyExtensionEnums(specData);
            
            Processor.ResolveEnumUnderlyingTypes(specData);
            var typeMap = Processor.BuildTypeMap(specData);
            
            Processor.ApplyExtensionConstants(specData);
            var constMap = Processor.BuildConstantsMap(specData);
            
            Processor.ResolveStructMemberTypes(specData, typeMap, constMap);
            Processor.ResolveHandleParent(specData);
            Processor.ResolveCommandTypes(specData, typeMap);
            Processor.ResolveVersionInfo(specData, typeMap);
            
            Processor.SortMembers(specData);

            Writer.Write(specData);
            //Writer.WriteVideo(videoSpecData);

            watch.Stop();

            Console.WriteLine($"Wrote OpenXR bindings in {watch.Elapsed.TotalMilliseconds}ms");
        }
    }
}
