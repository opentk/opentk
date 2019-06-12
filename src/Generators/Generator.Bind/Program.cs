//
// Program.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime;
using System.Threading.Tasks;
using Bind.Baking;
using Bind.Generators;
using Bind.Generators.ES;
using Bind.Generators.GL.Compatibility;
using Bind.Generators.GL.Core;
using Bind.Translation.Mappers;
using Bind.Typemap;
using Bind.Writers;
using Bind.XML.Documentation;
using Bind.XML.Overrides;
using Bind.XML.Signatures;
using Bind.XML.Signatures.Functions;
using CommandLine;
using JetBrains.Annotations;

namespace Bind
{
    /// <summary>
    /// Main class for the program.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Gets the command-line arguments that were passed to the program.
        /// </summary>
        internal static CommandLineArguments Arguments { get; private set; }

        /// <summary>
        /// Gets a list of generator settings for which bindings should be generated.
        /// </summary>
        private static readonly List<IGeneratorSettings> Generators = new List<IGeneratorSettings>();

        /// <summary>
        /// Gets a dictionary of cached profiles that have been read from signature files.
        /// </summary>
        private static readonly ConcurrentDictionary<string, IReadOnlyList<ApiProfile>> _cachedProfiles =
            new ConcurrentDictionary<string, IReadOnlyList<ApiProfile>>();

        /// <summary>
        /// Gets a dictionary of cached typemaps that have been read from file.
        /// </summary>
        private static readonly ConcurrentDictionary<string, IReadOnlyDictionary<TypeSignature, TypeSignature>> _cachedTypemaps =
            new ConcurrentDictionary<string, IReadOnlyDictionary<TypeSignature, TypeSignature>>();

        /// <summary>
        /// The main entry point of the application.
        /// </summary>
        /// <param name="args">A set of command-line arguments and switches to be parsed.</param>
        /// <returns>An integer, indicating success or failure. On a failure, a nonzero value is returned.</returns>
        private static int Main(string[] args)
        {
            // force the GC to a suitable mode.
            GCSettings.LatencyMode = GCLatencyMode.Batch;
            Console.WriteLine($"OpenGL binding generator {Assembly.GetExecutingAssembly().GetName().Version} for OpenTK.");
            Console.WriteLine("For comments, bugs and suggestions visit http://github.com/opentk/opentk");
            Console.WriteLine();

            Parser.Default.ParseArguments<CommandLineArguments>(args)
                .WithParsed(r => Arguments = r);

            if (Arguments is null)
            {
                return 1;
            }

            CreateGenerators();

            var stopwatch = Stopwatch.StartNew();
            Generators.ForEach(GenerateBindings);
            stopwatch.Stop();

            Console.WriteLine();
            Console.WriteLine("Bindings generated in {0} seconds.", stopwatch.Elapsed.TotalSeconds);

            return 0;
        }

        /// <summary>
        /// Asynchronously generates bindings for the API described by the given <see cref="IGeneratorSettings"/>
        /// object.
        ///
        /// Broadly, this takes the following steps:
        /// 1) Load the base API.
        /// 2) Bake overrides into the API
        /// 3) Bake Documentation into the API
        /// 4) Create mappings between OpenGL types and C# types
        /// 5) Apply the mappings to the API
        /// 6) Bake convenience overloads into the API (adding unsafe, etc)
        /// 7) Write the bindings to the files.
        ///
        /// </summary>
        /// <param name="generatorSettings">The settings describing the API.</param>
        private static void GenerateBindings([NotNull] IGeneratorSettings generatorSettings)
        {
            var signaturePath = Path.Combine(Arguments.InputPath, generatorSettings.SpecificationFile);
            if (!_cachedProfiles.TryGetValue(signaturePath, out var profiles))
            {
                profiles = SignatureReader.GetAvailableProfiles(signaturePath).ToList();
                _cachedProfiles.TryAdd(signaturePath, profiles);
            }

            var profileOverrides = OverrideReader
                .GetProfileOverrides(generatorSettings.OverrideFiles.ToArray())
                .ToList();

            var baker = new ProfileBaker(profiles, profileOverrides);
            var bakedProfile = baker.BakeProfile(
                generatorSettings.ProfileName,
                generatorSettings.Versions,
                generatorSettings.BaseProfileName);

            var documentationPath = Path.Combine(
                Arguments.DocumentationPath,
                generatorSettings.SpecificationDocumentationPath);

            var doc = DocumentationReader.ReadProfileDocumentation(documentationPath, generatorSettings.FunctionPrefix);
            var bakedDocs = new DocumentationBaker(bakedProfile).BakeDocumentation(doc);

            var languageTypemapPath = Path.Combine(Arguments.InputPath, generatorSettings.LanguageTypemap);
            if (!_cachedTypemaps.TryGetValue(languageTypemapPath, out var languageTypemap))
            {
                using (var fs = File.OpenRead(languageTypemapPath))
                {
                    languageTypemap = new TypemapReader().ReadTypemap(fs);
                    _cachedTypemaps.TryAdd(languageTypemapPath, languageTypemap);
                }
            }

            var apiTypemapPath = Path.Combine(Arguments.InputPath, generatorSettings.APITypemap);
            if (!_cachedTypemaps.TryGetValue(apiTypemapPath, out var apiTypemap))
            {
                using (var fs = File.OpenRead(apiTypemapPath))
                {
                    apiTypemap = new TypemapReader().ReadTypemap(fs);
                    _cachedTypemaps.TryAdd(apiTypemapPath, apiTypemap);
                }
            }

            var bakedMap = TypemapBaker.BakeTypemaps(apiTypemap, languageTypemap);

            var mapper = new ProfileMapper(bakedMap);
            var mappedProfile = mapper.Map(bakedProfile);

            // var bindingsWriter = new BindingWriter(generatorSettings, overloadedProfile, bakedDocs);
            // await bindingsWriter.WriteBindingsAsync();
            ProfileWriter.Write(
                generatorSettings,
                mappedProfile,
                bakedDocs,
                generatorSettings.NameContainer);
        }

        /// <summary>
        /// Populates the <see cref="Generators"/> field with the generators relevant for the current run.
        /// </summary>
        private static void CreateGenerators()
        {
            if (Arguments.TargetAPIs.Contains(TargetAPI.All))
            {
                Generators.Add(new DesktopCompatibilitySettings());
                Generators.Add(new DesktopSettings());
                Generators.Add(new EmbeddedSettings());
            }
            else
            {
                foreach (var targetAPI in Arguments.TargetAPIs)
                {
                    switch (targetAPI)
                    {
                        case TargetAPI.DesktopCompatibility:
                            Generators.Add(new DesktopCompatibilitySettings());
                            break;
                        case TargetAPI.Desktop:
                            Generators.Add(new DesktopSettings());
                            break;
                        case TargetAPI.Embedded:
                            Generators.Add(new EmbeddedSettings());
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
            }
        }
    }
}
