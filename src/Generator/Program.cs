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
            var st = new Stopwatch();
            st.Start();
            using (Logger.CreateLogger(Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location)!, "log.txt")))
            {
                // Reading the gl.xml file.
                using var stream = Reader.ReadSpecFromGithub();

                // TODO: Documentation.

                // Parsing into data structures.
                var specification = Parser.Parse(stream);

                // Processer/overloading
                var outputSpec = Processor.ProcessSpec(specification);

                // Writing cs files.
                Writer.Write(outputSpec);

                st.Stop();

                Logger.Info($"Generated bidnigns in {st.ElapsedMilliseconds}ms");
            }
        }
    }
}
