using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Linq;
using OpenTK.BuildTools.Convert;

namespace OpenTK.BuildTools.Common
{
    /// <summary>
    /// Represents a C# enum.
    /// </summary>
    public class Enum
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
        /// Gets or sets the name of this enum as defined by the Khronos spec.
        /// </summary>
        public string NativeName { get; set; }

        /// <summary>
        /// Gets or sets the attributes to be applied to this enum.
        /// </summary>
        public List<Attribute> Attributes { get; set; } = new List<Attribute>();

        /// <summary>
        /// Asynchronously writes this enum to a file.
        /// </summary>
        /// <param name="file">The file to write to.</param>
        /// <param name="profile">The subsystem containing this enum.</param>
        /// <param name="project">The project containing this enum.</param>
        /// <returns>The asynchronous task.</returns>
        public async Task WriteAsync(string file, Profile profile, Project project)
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

        public static Enum Parse(XElement element)
        {
            var result = new Enum
            {
                Name = NativeIdentifierTranslator.TranslateIdentifierName
                (
                    element.Attribute("name")?.Value ?? throw new InvalidOperationException("No name attribute.")
                ),
                NativeName = element.Attribute("name")?.Value
            };
            foreach (var child in element.Elements("token"))
            {
                result.Tokens.Add
                (
                    new Token()
                    {
                        Name = NativeIdentifierTranslator.TranslateIdentifierName(child.Attribute("name")?.Value),
                        NativeName = child.Attribute("name")?.Value,
                        Value = child.Attribute("value")?.Value
                        // TODO: deprecation
                    }
                );
            }

            return result;
        }
    }
}