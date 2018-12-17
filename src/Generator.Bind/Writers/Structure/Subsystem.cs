using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bind.Generators;
using Bind.Translation.Translators;
using Bind.Writers.Structure.Projects;
using Bind.XML.Documentation;
using Bind.XML.Signatures;
using Bind.XML.Signatures.Functions;
using Humanizer;
using JetBrains.Annotations;
using Attribute = Bind.Writers.Structure.Projects.Attribute;
using Enum = Bind.Writers.Structure.Projects.Enum;

namespace Bind.Writers.Structure
{
    /// <summary>
    /// Represents a subsystem as defined in GitHub issue #823.
    /// </summary>
    internal class Subsystem
    {
        private readonly IGeneratorSettings _settings;
        private readonly ApiProfile _profile;
        private readonly ProfileDocumentation _docs;
        private Dictionary<string, string> _internalTypemap;

        /// <summary>
        /// Initializes a new instance of the <see cref="Subsystem"/> class from the given generator settings, API specification.
        /// and API documentation.
        /// </summary>
        /// <param name="settings">The generator settings to use.</param>
        /// <param name="profile">The API specification to use.</param>
        /// <param name="docs">The API documentation to use.</param>
        public Subsystem(IGeneratorSettings settings, ApiProfile profile, ProfileDocumentation docs)
        {
            _settings = settings;
            _profile = profile;
            _docs = docs;
        }

        /// <summary>
        /// Gets or sets a dictionary where the category names (or "Core", if the project isn't an extension)
        /// are the keys and <see cref="Project"/>s are the values.
        /// </summary>
        public Dictionary<string, Project> Projects { get; set; }

        /// <summary>
        /// Asynchronously generates all of the projects, interfaces, and enums in memory so
        /// that they can then be written to disk using <see cref="FlushAsync"/>.
        /// </summary>
        /// <returns>The asynchronous task.</returns>
        public async Task GenerateAsync()
        {
            // Initialization
            Projects = new Dictionary<string, Project>();

            // Project Generation
            await PopulateProjectsAsync();

            // Interface Generation
            await GenerateInterfacesAsync();

            // Enum Generation
            await WriteEnumsAsync();

            // Function Generation
            await WriteFunctionsAsync();

            // XMLDoc Generation
            await WriteDocumentationAsync();
        }

        private Task PopulateProjectsAsync()
        {
            foreach (var keyValuePair in _profile.GetExtensionDictionary())
            {
                var extension = keyValuePair.Key;
                var categories = keyValuePair.Value;
                if (extension == "Core")
                {
                    if (Projects.ContainsKey("Core"))
                    {
                        continue;
                    }

                    Projects.Add
                    (
                        "Core",
                        new Project()
                        {
                            CategoryName = "Core", ExtensionName = "Core", IsRoot = true,
                            Namespace = _settings.Namespace,
                            // TODO: Remove this line when we rename the projects
                            ProjectName = _settings.Namespace.Replace("OpenToolkit", "OpenTK")
                        }
                    );
                }
                else
                {
                    foreach (var category in keyValuePair.Value)
                    {
                        if (Projects.ContainsKey(category))
                        {
                            continue;
                        }

                        Projects.Add
                        (
                            category,
                            new Project()
                            {
                                CategoryName = category, ExtensionName = keyValuePair.Key, IsRoot = false,
                                Namespace = _settings.ExtensionsNamespace + "." +
                                            Utilities.ConvertExtensionNameToNamespace(category),
                                // TODO: Remove this line when we rename the projects
                                ProjectName = _settings.ExtensionsNamespace.Replace("OpenToolkit", "OpenTK") + "." +
                                              Utilities.ConvertExtensionNameToNamespace(category)
                            }
                        );
                    }
                }
            }

            return Task.CompletedTask;
        }

        private Task GenerateInterfacesAsync()
        {
            foreach (var kvp in _profile.GetExtensionDictionary())
            {
                foreach (var category in kvp.Value)
                {
                    var camelCat = "I" + Utilities.ConvertCategoryNameToCamel(category.ToLower());
                    if (kvp.Key == "Core")
                    {
                        if (!Projects["Core"].Interfaces.ContainsKey(category))
                        {
                            Projects["Core"].Interfaces.Add
                            (
                                category,
                                new Interface()
                                {
                                    Name = camelCat
                                });
                        }
                    }
                    else
                    {
                        if (!Projects[category].Interfaces.ContainsKey(category))
                        {
                            Projects[category].Interfaces.Add(category, new Interface() { Name = camelCat });
                        }
                    }
                }
            }

            return Task.CompletedTask;
        }

        private Task WriteFunctionsAsync()
        {
            var functions = _profile.NativeSignatures.Concat(_profile.Overloads);
            foreach (var function in functions)
            {
                var generated = new Function() { };
                //generated.Parameters.AddRange(function.Parameters);
                // Workaround for the enum translation bug, see ProfileEnumerationTranslator.cs
                foreach (var param in function.Parameters)
                {
                    if (_internalTypemap.ContainsKey(param.Type.Name))
                    {
                        generated.Parameters.Add
                        (
                            new ParameterSignature
                            (
                                param.Name,
                                new TypeSignature
                                (
                                    _internalTypemap[param.Type.Name],
                                    param.Type.IndirectionLevel,
                                    param.Type.ArrayDimensions,
                                    param.Type.IsByRef,
                                    param.Type.IsOut
                                )
                            )
                        );
                    }
                    else
                    {
                        generated.Parameters.Add(param);
                    }
                }
                generated.Name = function.Name;
                generated.GenericTypeParameters.AddRange(function.GenericTypeParameters);
                generated.IsUnsafe = generated.Parameters.Any(x => x.Type.IsPointer);
                generated.ReturnType = function.ReturnType;
                generated.NativeName = _settings.FunctionPrefix + function.NativeEntrypoint;
                generated.Attributes.Add
                (
                    new Attribute()
                    {
                        Name = "AdvancedDLSupport.NativeSymbolAttribute",
                        Arguments = new List<string>() { "\"" + generated.NativeName + "\"" }
                    }
                );
                if (function.IsDeprecated)
                {
                    generated.Attributes.Add(new Attribute()
                    {
                        Name = "System.ObsoleteAttribute",
                        Arguments = new List<string>()
                        {
                            "\"Deprecated in " + function.DeprecatedIn +
                            (!string.IsNullOrEmpty(function.DeprecationReason)
                                ? " - " + function.DeprecationReason + "\""
                                : "\"")
                        }
                    });
                }

                foreach (var category in function.Categories.RemoveDuplicates())
                {
                    Projects[function.Extension == "Core" ? "Core" : category].Interfaces[category].Functions
                        .Add(generated);
                }
            }

            return Task.CompletedTask;
        }

        private Task WriteEnumsAsync()
        {
            _internalTypemap = new Dictionary<string, string>();
            var enums = _profile.Enumerations;
            foreach (var @enum in enums)
            {
                _internalTypemap[@enum.Name] = translato.Translate(@enum.Name);
                var generated = new Enum() { Name = _internalTypemap[@enum.Name] };
                foreach (var tokenSignature in @enum.Tokens)
                {
                    var token = new Token()
                    {
                        Name = tokenSignature.Name,
                        Value = tokenSignature.Value + string.Empty, NativeName = tokenSignature.Name
                    };
                    if (tokenSignature.IsDeprecated)
                    {
                        token.Attributes.Add(new Attribute()
                        {
                            Name = "System.ObsoleteAttribute",
                            Arguments = new List<string>()
                            {
                                "\"Deprecated in " + tokenSignature.DeprecatedIn + "\""
                            }
                        });
                    }
                    generated.Tokens.Add(token);
                }

                // XML doesn't categorize enums, so we can't add extension-specific enums
                Projects["Core"].Enums.Add(generated);
            }

            return Task.CompletedTask;
        }

        private async Task WriteDocumentationAsync()
        {
            var documentation = _docs.Functions.ToDictionary(x => x.Name, x => x);
            var tasks = new List<Task>();
            foreach (var project in Projects)
            {
                tasks.Add(Task.Run(() =>
                {
                    foreach (var @interface in project.Value.Interfaces)
                    {
                        foreach (var function in @interface.Value.Functions)
                        {
                            if (!documentation.ContainsKey(function.NativeName))
                            {
                                function.Doc = "/// <summary>\n" +
                                               "/// To be added.\n" +
                                               "/// </summary>";
                                Debug.WriteLine
                                (
                                    $"The function \"{function.NativeName}\" lacks documentation. Consider adding a documentation file for " +
                                    $"the function."
                                );
                                continue;
                            }

                            var doc = documentation[function.NativeName];
                            var sb = new StringBuilder();
                            sb.AppendLine("/// <summary>");
                            var summaryLines = doc.Purpose.TrimEnd().Split('\n');
                            foreach (var summaryLine in summaryLines)
                            {
                                sb.AppendLine($"/// {summaryLine}");
                            }

                            sb.AppendLine("/// </summary>");

                            foreach (var parameter in function.Parameters)
                            {
                                var parameterDocumentation =
                                    doc.Parameters.FirstOrDefault(dp => dp.Name == parameter.Name);
                                if (parameterDocumentation is null)
                                {
                                    sb.AppendLine(
                                        $"/// <param name=\"{parameter.Name}\">To be added.</param>");
                                    continue;
                                }

                                // XML documentation doesn't require keyword escaping.
                                if (parameter.Name.TrimStart('@') != parameterDocumentation.Name)
                                {
                                    Debug.WriteLine
                                    (
                                        $"Parameter {parameter.Name} in function {function.Name} has incorrect documentation name " +
                                        $"{parameterDocumentation.Name}."
                                    );
                                }

                                sb.AppendLine($"/// <param name=\"{parameterDocumentation.Name}\">");
                                if (!(parameter.Count is null))
                                {
                                    if (parameter.Count.IsStatic)
                                    {
                                        sb.AppendLine($"/// This parameter contains {parameter.Count.Count} elements.");
                                        sb.AppendLine("///");
                                    }

                                    if (parameter.Count.IsComputed)
                                    {
                                        var parameterList = parameter.Count.ComputedFrom.Select(cf => cf.Name)
                                            .Humanize();
                                        sb.AppendLine(
                                            $"/// This parameter's element count is computed from {parameterList}.");
                                        sb.AppendLine("///");
                                    }

                                    if (parameter.Count.IsReference)
                                    {
                                        // ReSharper disable once PossibleNullReferenceException
                                        sb.AppendLine(
                                            $"/// This parameter's element count is taken from {parameter.Count.ValueReference.Name}.");
                                        sb.AppendLine("///");
                                    }
                                }

                                var descriptionLines = parameterDocumentation.Description.TrimEnd().Split('\n');
                                foreach (var descriptionLine in descriptionLines)
                                {
                                    sb.AppendLine($"/// {descriptionLine}");
                                }

                                sb.AppendLine("/// </param>");
                            }

                            foreach (var genericTypeParameter in function.GenericTypeParameters)
                            {
                                var referencingParameter =
                                    function.Parameters.First(f => f.Type.Name == genericTypeParameter.Name);
                                sb.AppendLine
                                (
                                    $"/// <typeparam name=\"{genericTypeParameter.Name}\">The generic type of " +
                                    $"{referencingParameter.Name}.</typeparam>"
                                );
                            }

                            function.Doc = sb.ToString();
                        }
                    }
                }));
            }

            await Task.WhenAll(tasks);
        }

        /// <summary>
        /// Asynchronously writes all of the projects, interfaces, and enums to disk.
        /// </summary>
        /// <returns>The asynchronous task.</returns>
        public async Task FlushAsync()
        {
            var rootFolder = Path.Combine("src", _settings.OutputFolder);
            if (!Directory.Exists(rootFolder))
            {
                Directory.CreateDirectory(rootFolder);
            }

            if (Directory.Exists(Path.Combine(rootFolder, Projects["Core"].ProjectName)))
            {
                Console.WriteLine(_settings.Namespace.Split('.').Last() + " - Bindings already written. Please delete the " + _settings.OutputFolder + " folder to write bindings again.");
            }

            if (!Directory.Exists(Path.Combine(rootFolder, "Extensions")))
            {
                Directory.CreateDirectory(Path.Combine(rootFolder, "Extensions"));
            }

            var projectTasks = Projects.Select(x =>
                x.Value.WriteAsync
                (
                    x.Key == "Core"
                    ? Path.Combine(rootFolder, x.Value.ProjectName)
                    : Path.Combine(rootFolder, "Extensions", x.Value.ProjectName),
                    _settings,
                    this
                ));
            await Task.WhenAll(projectTasks);
        }
    }
}
