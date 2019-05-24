//
// ProfileWriter.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bind.Baking.Overloading;
using Bind.Generators;
using Bind.Structure;
using Bind.Translation.Translators;
using Bind.XML.Documentation;
using Bind.XML.Signatures;
using Bind.XML.Signatures.Enumerations;
using Bind.XML.Signatures.Functions;

namespace Bind.Writers
{
    /// <summary>
    /// Handles asynchronous writing of bindings to files.
    /// </summary>
    internal static class ProfileWriter
    {
        /// <summary>
        /// The subfolder in which extensions are contained.
        /// </summary>
        public const string ExtensionsFolder = "Extensions";

        /// <summary>
        /// The subfolder in which interfaces are contained.
        /// </summary>
        public const string InterfacesFolder = "Interfaces";

        /// <summary>
        /// The subfolder in which enumerations are contained.
        /// </summary>
        public const string EnumsFolder = "Enums";

        /// <summary>
        /// Asynchronously writes the given profile to a directory.
        /// </summary>
        /// <param name="generatorSettings">The generator settings to use for the profile writer.</param>
        /// <param name="profile">The profile to write.</param>
        /// <param name="docs">The profile's documentation.</param>
        /// <param name="nc">The name container for this profile.</param>
        /// <returns>An asynchronous task.</returns>
        public static Task WriteAsync(
            IGeneratorSettings generatorSettings,
            ApiProfile profile,
            ProfileDocumentation docs,
            NameContainer nc)
        {
            var rootFolder = Path.Combine(Program.Arguments.OutputPath, generatorSettings.OutputSubfolder);
            var rootNamespace = generatorSettings.Namespace;
            if (!Directory.Exists(rootFolder))
            {
                Directory.CreateDirectory(rootFolder);
            }

            if (!Directory.Exists(Path.Combine(rootFolder, rootNamespace)))
            {
                Directory.CreateDirectory(Path.Combine(rootFolder, rootNamespace));
            }

            if (!Directory.Exists(Path.Combine(rootFolder, ExtensionsFolder)))
            {
                Directory.CreateDirectory(Path.Combine(rootFolder, ExtensionsFolder));
            }

            return Task.WhenAll(
                GetProjects(profile)
                    .Select(
                        x => WriteProjectAsync(
                            x,
                            generatorSettings,
                            nc,
                            docs)));
        }

        private static async Task WriteProjectAsync(
            Project project,
            IGeneratorSettings settings,
            NameContainer nc,
            ProfileDocumentation doc)
        {
            var folder = Path.Combine(Program.Arguments.OutputPath, settings.OutputSubfolder);
            var ns = project.Extension == "Core" ? settings.Namespace : settings.ExtensionNamespace + "." + Utilities.ConvertExtensionNameToNamespace(project.Extension);
            var dir = project.Extension == "Core"
                ? Path.Combine(folder, ns, settings.ClassName)
                : Path.Combine(folder, ExtensionsFolder, ns);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            if (!Directory.Exists(Path.Combine(dir, InterfacesFolder)))
            {
                Directory.CreateDirectory(Path.Combine(dir, InterfacesFolder));
            }

            if (!Directory.Exists(Path.Combine(dir, EnumsFolder)))
            {
                Directory.CreateDirectory(Path.Combine(dir, EnumsFolder));
            }

            await Task.WhenAll(
                project.Interfaces.Select(
                        x => InterfaceWriter.WriteInterfaceAsync(
                            x, Path.Combine(dir, InterfacesFolder, x.InterfaceName + ".cs"), ns, settings.FunctionPrefix, doc, settings.Namespace))
                    .Concat(
                        project.Enums.Select(
                            x => EnumWriter.WriteEnumAsync(
                                x,
                                Path.Combine(dir, EnumsFolder, x.Name + ".cs"),
                                ns,
                                settings.ConstantPrefix))));

            if (project.Extension == "Core")
            {
                await InterfaceWriter.WriteMetaInterfaceAsync(
                    ns,
                    Path.Combine(dir, InterfacesFolder, "I" + settings.ClassName + ".cs"),
                    settings.ClassName,
                    project.Interfaces.Select(x => x.InterfaceName));
                await NameContainerWriter.WriteNameContainerAsync(Path.Combine(dir, $"{settings.APIIdentifier}LibraryNameContainer.cs"), ns, settings.APIIdentifier, nc);
            }
            else
            {
                // we expect the project file to already be created
                await ProjectFileWriter.WriteProjectFileAsync(ns, dir, settings.OutputSubfolder, settings.Namespace, project.Extension != "Core");
            }

            await ClassWriter.WriteMixedModeClassAsync(project, settings, doc);
        }

        /// <summary>
        /// Splits a profile into a group of projects, each containing the interfaces and enums specific to that
        /// extension or profile.
        /// </summary>
        /// <param name="profile">The profile to split.</param>
        /// <returns>A collection of projects.</returns>
        private static IEnumerable<Project> GetProjects(ApiProfile profile)
        {
            return GetWithoutEnums(profile.NativeSignatures)
                .Select(
                    x => new Project(
                        x.Item1,
                        x.Item2,
                        x.Item1 == "Core" ? profile.Enumerations : new EnumerationSignature[0],
                        x.Item3.ToList()));
        }

        private static IEnumerable<(string, IEnumerable<Interface>, IEnumerable<(FunctionSignature, StringBuilder)>)> GetWithoutEnums(IEnumerable<FunctionSignature> fns)
        {
            // extension or core, (interface name, functions)
            var projects = new Dictionary<string, Dictionary<string, List<FunctionSignature>>>();
            foreach (var function in fns)
            {
                foreach (var category in function.Categories)
                {
                    // check that the root project exists
                    if (!projects.ContainsKey("Core"))
                    {
                        projects.Add(
                            "Core",
                            new Dictionary<string, List<FunctionSignature>>());
                    }

                    // check that the extension project exists, if applicable
                    if (function.Extension != "Core" && !projects.ContainsKey(category))
                    {
                        projects.Add(
                            category,
                            new Dictionary<string, List<FunctionSignature>>());
                    }

                    // check that the interface exists
                    if (!projects[function.Extension == "Core" ? "Core" : category]
                        .ContainsKey("I" + NativeIdentifierTranslator.TranslateIdentifierName(category)))
                    {
                        projects[function.Extension == "Core" ? "Core" : category]
                            .Add(
                                "I" + NativeIdentifierTranslator.TranslateIdentifierName(category),
                                new List<FunctionSignature>());
                    }

                    // add the function to the interface
                    projects[function.Extension == "Core" ? "Core" : category][
                        "I" + NativeIdentifierTranslator.TranslateIdentifierName(category)]
                        .Add(function);
                }
            }

            return projects.Select(
                x =>
                (
                    x.Key,
                    x.Value.Select(y => new Interface(y.Key, y.Value)),
                    x.Value.SelectMany(y => OverloadBaker.GetOverloads(y.Value))));
        }
    }
}
