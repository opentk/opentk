using System.Diagnostics;
using System.IO;
using System.Reflection;
using Generator.Utility;
using Generator.Writing;
using Generator.Parsing;
using Generator.Process;

namespace Generator
{
    unsafe class Program
    {
        static void Main(string[] args)
        {
            Stopwatch? st = new Stopwatch();
            st.Start();
            using (Logger.CreateLogger(Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location)!, "log.txt")))
            {
                // Reading the gl.xml file and parsing it into data structures.
                using FileStream specificationStream = Reader.ReadSpecFromGithub();
                Specification specification = SpecificationParser.Parse(specificationStream);

                // Read the documentation folders and parse it into data structures.
                using DocumentationSource? documentationSource = Reader.ReadDocumentationFromGithub();
                Documentation documentation = DocumentationParser.Parse(documentationSource);

                // Processer/overloading
                OutputData outputSpec = Processor.ProcessSpec(specification);

                // Writing cs files.
                Writer.Write(outputSpec);

                st.Stop();
                Logger.Info($"{st.ElapsedMilliseconds}");
            }
        }
    }
}
