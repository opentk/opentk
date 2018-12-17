using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MoreLinq.Extensions;
using Newtonsoft.Json;
using OpenTK.BuildTools.Convert;

namespace OpenTK.BuildTools.Common
{
    /// <summary>
    /// Represents a subsystem as defined in GitHub issue #823.
    /// </summary>
    public class Profile
    {
        /// <summary>
        /// Gets or sets a dictionary where the category names (or "Core", if the project isn't an extension)
        /// are the keys and <see cref="Project"/>s are the values.
        /// </summary>
        public Dictionary<string, Project> Projects { get; set; } = new Dictionary<string, Project>();

        public string Namespace { get; set; }

        public string ExtensionsNamespace { get; set; }

        [JsonIgnore]
        public string OutputFolder { get; set; }

        public string Name { get; set; }

        public string Version { get; set; }

        [JsonIgnore]
        public Dictionary<string, string> TypeMap { get; set; } = new Dictionary<string, string>();

        public void WriteFunctions(IEnumerable<Function> functions)
        {
            foreach (var function in functions)
            {
                foreach (var category in function.Categories)
                {
                    // check that the root project exists
                    if (!Projects.ContainsKey("Core"))
                    {
                        Projects.Add
                        (
                            "Core",
                            new Project()
                            {
                                CategoryName = "Core", ExtensionName = "Core", IsRoot = true,
                                Namespace = string.Empty,
                            }
                        );
                    }
                    // check that the extension project exists, if applicable
                    if (function.ExtensionName != "Core" && !Projects.ContainsKey(category))
                    {
                        Projects.Add
                        (
                            category,
                            new Project()
                            {
                                CategoryName = category, ExtensionName = function.ExtensionName, IsRoot = false,
                                Namespace = "." + Utilities.ConvertExtensionNameToNamespace(category),
                            }
                        );
                    }
                    // check that the interface exists
                    if
                    (
                        !Projects[function.ExtensionName == "Core" ? "Core" : category]
                        .Interfaces.ContainsKey(category)
                    )
                    {
                        Projects[function.ExtensionName == "Core" ? "Core" : category].Interfaces.Add
                        (
                            category,
                            new Interface()
                                {Name = "I" + NativeIdentifierTranslator.TranslateIdentifierName(category)}
                        );
                    }
                    // add the function to the interface
                    Projects[function.ExtensionName == "Core" ? "Core" : category]
                        .Interfaces[category]
                        .Functions.Add(function);
                }
            }
        }

        /// <summary>
        /// Asynchronously writes all of the projects, interfaces, and enums to disk.
        /// </summary>
        /// <returns>The asynchronous task.</returns>
        public async Task FlushAsync(string outputFolder, Profile profile)
        {
            var rootFolder = Path.Combine("src", outputFolder);
            if (!Directory.Exists(rootFolder))
            {
                Directory.CreateDirectory(rootFolder);
            }

            if (Directory.Exists(Path.Combine(rootFolder, Projects["Core"].GetProjectName(profile))))
            {
                Console.WriteLine
                (
                    Namespace.Split('.').Last() + " - Bindings already written. Please delete the " + outputFolder +
                    " folder to write bindings again."
                );
            }

            if (!Directory.Exists(Path.Combine(rootFolder, "Extensions")))
            {
                Directory.CreateDirectory(Path.Combine(rootFolder, "Extensions"));
            }

            var projectTasks = Projects.Select
            (
                x =>
                    x.Value.WriteAsync
                    (
                        x.Key == "Core"
                            ? Path.Combine(rootFolder, x.Value.GetProjectName(profile))
                            : Path.Combine(rootFolder, "Extensions", x.Value.GetProjectName(profile)),
                        this
                    )
            );
            await Task.WhenAll(projectTasks);
        }

        public void ParseXml(IEnumerable<XElement> enums, IEnumerable<XElement> functions)
        {
            Projects.Add
            (
                "Core",
                new Project() {CategoryName = "Core", ExtensionName = "Core", IsRoot = true, Namespace = string.Empty}
            );
            Projects["Core"].Enums.AddRange(enums.Select(Enum.Parse));
            var funs = functions.ToList();
            var parsed = funs.Select(Function.Parse).ToList();
            TypeMapper.Map
            (
                TypeMap
                    .Concat(Projects["Core"].Enums.ToDictionary(x => x.NativeName, x => x.Name))
                    .ToDictionary(),
                parsed
            );
            WriteFunctions(parsed);
        }
    }
}