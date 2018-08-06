/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Bind.Baking;
using Bind.Baking.Overloading;
using Bind.Generators;
using Bind.Generators.ES;
using Bind.Generators.GL2;
using Bind.Translation.Mappers;
using Bind.Typemap;
using Bind.Versioning;
using Bind.XML.Documentation;
using Bind.XML.Overrides;
using Bind.XML.Signatures;
using CommandLine;

namespace Bind
{
    /// <summary>
    /// Main class for the program.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Gets the command-line arguments that were passed to the program.
        /// </summary>
        internal static CommandLineArguments Arguments { get; private set; }

        private static readonly List<IGenerator> Generators = new List<IGenerator>();

        private static async Task<int> Main(string[] args)
        {
            Console.WriteLine($"OpenGL binding generator {Assembly.GetExecutingAssembly().GetName().Version} for OpenTK.");
            Console.WriteLine("For comments, bugs and suggestions visit http://github.com/opentk/opentk");
            Console.WriteLine();

            Parser.Default.ParseArguments<CommandLineArguments>(args)
                .WithParsed(r => Arguments = r);

            if (Arguments is null)
            {
                return 1;
            }

            var es31GeneratorSettings = new ES31Generator();

            var profiles = SignatureReader.GetAvailableProfiles(Path.Combine(Arguments.InputPath, "GL2", "signatures.xml")).ToList();
            var profileOverrides = OverrideReader.GetProfileOverrides(es31GeneratorSettings.OverrideFiles.ToArray()).ToList();

            var baker = new ProfileBaker(profiles, profileOverrides);
            var bakedProfile = baker.BakeProfile("gles2", new VersionRange(new Version(3, 1)));

            var docs = DocumentationReader.ReadProfileDocumentation(Path.Combine(Arguments.InputPath, "Docs", "docs.gl", "es3"));
            var bakedDocs = new DocumentationBaker(bakedProfile).BakeDocumentation(docs);

            ApiProfile mappedProfile;
            using (var csharpFs = File.OpenRead(Path.Combine(Arguments.InputPath, "csharp.tm")))
            {
                using (var apiFs = File.OpenRead(Path.Combine(Arguments.InputPath, "GL2", "gl.tm")))
                {
                    var mappingReader = new TypemapReader();

                    var csharpMap = mappingReader.ReadTypemap(csharpFs);
                    var apiMap = mappingReader.ReadTypemap(apiFs);

                    var bakedMap = TypemapBaker.BakeTypemaps(apiMap, csharpMap);

                    var mapper = new ProfileMapper(bakedMap);
                    mappedProfile = mapper.Map(bakedProfile);
                }
            }

            var overloadedProfile = OverloadBaker.BakeOverloads(mappedProfile);

            CreateGenerators();

            var bindingsWriter = new BindingsWriterAsync(es31GeneratorSettings, overloadedProfile, bakedDocs);

            foreach (var generator in Generators)
            {
                var ticks = DateTime.Now.Ticks;

                generator.LoadData();

                var writer = new LegacyBindingsWriter();
                writer.LegacyWriteBindings(generator);

                ticks = DateTime.Now.Ticks - ticks;

                Console.WriteLine();
                Console.WriteLine("Bindings generated in {0} seconds.", ticks / 10000000.0);
            }

            return 0;
        }

        private static void CreateGenerators()
        {
            if (Arguments.TargetAPIs.Contains(TargetAPI.All))
            {
                Generators.Add(new GL2Generator());
                Generators.Add(new GL4Generator());
                Generators.Add(new ES10Generator());
                Generators.Add(new ES11Generator());
                Generators.Add(new ES2Generator());
                Generators.Add(new ES3Generator());
                Generators.Add(new ES31Generator());
            }
            else
            {
                foreach (var targetAPI in Arguments.TargetAPIs)
                {
                    switch (targetAPI)
                    {
                        case TargetAPI.GL2:
                        {
                            Generators.Add(new GL2Generator());
                            break;
                        }
                        case TargetAPI.GL3:
                        case TargetAPI.GL4:
                        {
                            Generators.Add(new GL4Generator());
                            break;
                        }
                        case TargetAPI.ES10:
                        {
                            Generators.Add(new ES10Generator());
                            break;
                        }
                        case TargetAPI.ES11:
                        {
                            Generators.Add(new ES11Generator());
                            break;
                        }
                        case TargetAPI.ES20:
                        {
                            Generators.Add(new ES2Generator());
                            break;
                        }
                        case TargetAPI.ES30:
                        {
                            Generators.Add(new ES3Generator());
                            break;
                        }
                        case TargetAPI.ES31:
                        {
                            Generators.Add(new ES31Generator());
                            break;
                        }
                    }
                }
            }
        }
    }
}
