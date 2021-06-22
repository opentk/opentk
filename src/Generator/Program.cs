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
                //TODO: Documentation.
                //Reading
                using var stream = Reader.ReadSpecFromGithub();

                //Parsing
                var specification = Parser.Parse(stream);

                // WIP
                var outputSpec = Processor.ProcessSpec(specification);

                Writer.Write(outputSpec);

                st.Stop();

                Logger.Info($"{st.ElapsedMilliseconds}");
            }
        }
    }
}
/*
 * TODO:
 * Work on some manual overloading system.
 */

/*TODO: Look into enum overloads for extensions
 * 1) Only use the ALL enum - Currently doing
 * 2) Create a struct with implicit conversions
 * 3) Create a ton of overloads
 * 4) Extra enum group per extension (downside: name collision)
 * */

//TODO:
//Overloading
//Documentation
//Trimmer
//Buildscript
// - .gitignore

/*
 * OpenToolkit.Graphics
 *     /[API]opengl
 *         /All.cs
 *         /extensions
 *             /AMD
 *                  /Methods.cs
 *                  /Overloads.cs
 *             /NV
 *             /EXT
 *         /versions
 *             /V32
 *                  /Methods.cs
 *                  /Overloads.cs
 *                  /Enums.cs
 *             /V42
 *             /V46
 *     /[API]gles
 */
