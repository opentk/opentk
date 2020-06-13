using GeneratorV2.Parsing;
using System.IO;
using System.Reflection;

namespace GeneratorV2.Writing
{
    public class Writer : IWriter
    {
        public void Write(string namespaceName, string outputPath, Specification input)
        {
            var folderPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                "..", "..", "..", "..", "OpenToolkit.Graphics");
            
            if (Directory.Exists(folderPath))
            {
                Directory.Delete(folderPath, true);
            }
            Directory.CreateDirectory(folderPath);
            WriteProject(Path.Combine(folderPath, "OpenToolkit.Graphics.csproj"));

            WriteDelegates(Path.Combine(folderPath, "Types.cs"));

            foreach (var (apiName, api) in spec.Apis)
            {
                WriteApi(api, folderPath);
            }
        }
    }
}
