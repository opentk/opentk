/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */

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
using Bind.Baking.Overloading;
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
        private static async Task<int> Main(string[] args)
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
            var generatorTasks = Generators.Select(GenerateBindingsAsync);
            await Task.WhenAll(generatorTasks);
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
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        private static async Task GenerateBindingsAsync([NotNull] IGeneratorSettings generatorSettings)
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
            var bakedProfile = baker.BakeProfile
            (
                generatorSettings.ProfileName,
                generatorSettings.Versions,
                generatorSettings.BaseProfileName
            );

            var documentationPath = Path.Combine
            (
                Arguments.DocumentationPath,
                generatorSettings.SpecificationDocumentationPath
            );

            var docs = DocumentationReader.ReadProfileDocumentation(documentationPath);
            var bakedDocs = new DocumentationBaker(bakedProfile).BakeDocumentation(docs);

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

            var overloadedProfile = OverloadBaker.BakeOverloads(mappedProfile);

            var bindingsWriter = new BindingWriter(generatorSettings, overloadedProfile, bakedDocs);
            await bindingsWriter.WriteBindingsAsync();
        }

        /// <summary>
        /// Populates the <see cref="Generators"/> field with the generators relevant for the current run.
        /// </summary>
        private static void CreateGenerators()
        {
            if (Arguments.TargetAPIs.Contains(TargetAPI.All))
            {
                Generators.Add(new GL2GeneratorSettings());
                Generators.Add(new GLCore4GeneratorSettings());
                Generators.Add(new ES20GeneratorSettings());
                Generators.Add(new ES30GeneratorSettings());
                Generators.Add(new ES31GeneratorSettings());
            }
            else
            {
                foreach (var targetAPI in Arguments.TargetAPIs)
                {
                    switch (targetAPI)
                    {
                        case TargetAPI.GL2:
                        {
                            Generators.Add(new GL2GeneratorSettings());
                            break;
                        }
                        case TargetAPI.GL3:
                        case TargetAPI.GL4:
                        {
                            Generators.Add(new GLCore4GeneratorSettings());
                            break;
                        }
                        case TargetAPI.ES20:
                        {
                            Generators.Add(new ES20GeneratorSettings());
                            break;
                        }
                        case TargetAPI.ES30:
                        {
                            Generators.Add(new ES30GeneratorSettings());
                            break;
                        }
                        case TargetAPI.ES31:
                        {
                            Generators.Add(new ES31GeneratorSettings());
                            break;
                        }
                    }
                }
            }
        }
    }
}
