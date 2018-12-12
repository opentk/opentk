using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Bind.Writers.Structure.Projects
{
    /// <summary>
    /// Represents a C# enum.
    /// </summary>
    internal class Enum
    {
        /// <summary>
        /// Gets or sets a list of tokens contained within this enum.
        /// </summary>
        public List<Token> Tokens { get; set; } = new List<Token>();

        /// <summary>
        /// Gets or sets the name of this enum.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the attributes to be applied to this enum.
        /// </summary>
        public List<Attribute> Attributes { get; set; } = new List<Attribute>();

        /// <summary>
        /// Asynchronously writes this enum to a file.
        /// </summary>
        /// <param name="file">The file to write to.</param>
        /// <param name="subsystem">The subsystem containing this enum.</param>
        /// <param name="project">The project containing this enum.</param>
        /// <returns>The asynchronous task.</returns>
        public async Task WriteAsync(string file, Subsystem subsystem, Project project)
        {
            if (File.Exists(file))
            {
                return;
            }

            var sw = new StreamWriter(file);
            await sw.WriteLineAsync(EmbeddedResources.LicenseText);
            await sw.WriteLineAsync();
            await sw.WriteLineAsync("using System;");
            await sw.WriteLineAsync();
            await sw.WriteLineAsync("namespace " + project.Namespace + ".Enums");
            await sw.WriteLineAsync("{");
            foreach (var attr in Attributes)
            {
                await sw.WriteLineAsync("    " + attr);
            }

            await sw.WriteLineAsync("    public enum " + Name);
            await sw.WriteLineAsync("    {");
            for (var index = 0; index < Tokens.Count; index++)
            {
                var token = Tokens[index];

                await sw.WriteLineAsync
                (
                    "        " + token.Name + " = " + token.Value +
                    (index != Tokens.Count ? "," : string.Empty)
                );
            }

            await sw.WriteLineAsync("    }");
            await sw.WriteLineAsync("}");
            await sw.FlushAsync();
            sw.Dispose();
        }
    }
}
