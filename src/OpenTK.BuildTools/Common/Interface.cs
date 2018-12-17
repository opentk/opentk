using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace OpenTK.BuildTools.Common
{
    /// <summary>
    /// Represents an AdvancedDLSupport interface.
    /// </summary>
    public class Interface
    {
        /// <summary>
        /// Gets or sets the name of this interface.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the functions contained within this interface.
        /// </summary>
        public List<Function> Functions { get; set; } = new List<Function>();

        /// <summary>
        /// Gets or sets a list of attributes to be applied to this interface.
        /// </summary>
        public List<Attribute> Attributes { get; set; } = new List<Attribute>();

        /// <summary>
        /// Asynchronously writes this interface to a file.
        /// </summary>
        /// <param name="file">The file to write to.</param>
        /// <param name="profile">The subsystem containing this interface.</param>
        /// <param name="project">The project containing this interface.</param>
        /// <returns>The asynchronous task.</returns>
        public async Task WriteAsync(string file, Profile profile, Project project)
        {
            if (File.Exists(file))
            {
                return;
            }

            var sw = new StreamWriter(file);
            await sw.WriteAsync(EmbeddedResources.LicenseText);
            await sw.WriteLineAsync("using System;");
            await sw.WriteLineAsync("using System.Runtime.InteropServices;");
            await sw.WriteLineAsync("using System.Text;");
            await sw.WriteLineAsync("using " + profile.Projects["Core"].Namespace + ";");
            await sw.WriteLineAsync("using " + profile.Projects["Core"].Namespace + ".Enums;");
            await sw.WriteLineAsync("using AdvancedDLSupport;");
            await sw.WriteLineAsync();
            await sw.WriteLineAsync("namespace " + project.Namespace + ".Interfaces");
            await sw.WriteLineAsync("{");
            foreach (var attr in Attributes)
            {
                await sw.WriteLineAsync("    " + attr);
            }

            await sw.WriteLineAsync("    internal interface " + Name);
            await sw.WriteLineAsync("    {");
            for (var index = 0; index < Functions.Count; index++)
            {
                var function = Functions[index];
                foreach (var line in function.Doc.Split('\n'))
                {
                    if (line == null)
                    {
                        continue;
                    }

                    await sw.WriteLineAsync("        " + line);
                }

                foreach (var attr in function.Attributes)
                {
                    await sw.WriteLineAsync("        " + attr);
                }

                await sw.WriteLineAsync("        " + function);
                if (index != Functions.Count)
                {
                    await sw.WriteLineAsync(); // style guide
                }
            }

            await sw.WriteLineAsync("    }");
            await sw.WriteLineAsync("}");
            await sw.FlushAsync();
            sw.Dispose();
        }
    }
}