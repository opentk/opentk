using ALGenerator.Parsing;
using ALGenerator.Process;
using GeneratorBase;
using GeneratorBase.Utility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace ALGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch st = new Stopwatch();
            st.Start();
            using (Logger.CreateLogger(Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location)!, "log.txt")))
            {
                Specification alSpecification;
                {
                    NameManglerSettings alSettings = new NameManglerSettings()
                    {
                        FunctionPrefix = "al",
                        EnumPrefixes = new List<string> { "AL_", "ALC_" },
                        ExtensionPrefixes = ["AL_", "ALC_"],
                        ExtensionsWithoutPrefixes =
                        [
                            "EAX-AC3",
                            "EAX-RAM",
                            "EAX",
                            "EAX2.0",
                            "EAX3.0",
                            "EAX3.0EMULATED",
                            "EAX4.0",
                            "EAX4.0EMULATED",
                            "EAX5.0",
                        ],
                        EnumGroupNameTranslationTable =
                        {
                        },
                        FunctionsWithoutPrefix =
                        [
                            "AttenuationScale_LOKI",
                            "BufferDataWithCallback_LOKI",
                            "EAXSetBufferMode",
                            "EAXGetBufferMode",
                            "EAXSet",
                            "EAXGet",
                        ]
                    };

                    // Reading the gl.xml file and parsing it into data structures.
                    using FileStream alSpecificationStream = Reader.ReadALSpecFromGithub();
                    alSpecification = SpecificationParser.Parse(alSpecificationStream, new NameMangler(alSettings), APIFile.AL, new List<string>());
                }

                Specification alcSpecification;
                {
                    NameManglerSettings alcSettings = new NameManglerSettings()
                    {
                        FunctionPrefix = "alc",
                        EnumPrefixes = new List<string> { "ALC_", "AL_" },
                        ExtensionPrefixes = ["ALC_"],
                        FunctionsWithoutPrefix = new HashSet<string>()
                        {
                            "GetAudioChannel_LOKI",
                            "SetAudioChannel_LOKI",
                        },
                        EnumsWithoutPrefix = new HashSet<string>()
                        {
                        }
                    };

                    using FileStream alcSpecificationStream = Reader.ReadALCSpecFromGithub();
                    alcSpecification = SpecificationParser.Parse(alcSpecificationStream, new NameMangler(alcSettings), APIFile.ALC, new List<string>());
                }

                List<EFXPreset> efxPresets;
                {
                    NameManglerSettings efxSettings = new NameManglerSettings()
                    {
                        FunctionPrefix = "",
                        EnumPrefixes = ["EFX_REVERB_PRESET_"],
                        ExtensionPrefixes = [],
                        FunctionsWithoutPrefix = new HashSet<string>()
                        {
                        },
                        EnumsWithoutPrefix = new HashSet<string>()
                        {
                        }
                    };

                    using FileStream efxPresetsStream = Reader.ReadEFXPresetsSpecFromGithub();
                    efxPresets = SpecificationParser.ParseEFXPresets(efxPresetsStream, new NameMangler(efxSettings));
                }

                List<Function> functions = [
                    .. alSpecification.Functions,
                    .. alcSpecification.Functions
                ];

                List<EnumEntry> enums = [
                    .. alSpecification.Enums,
                    .. alcSpecification.Enums
                ];

                // FIXME: This is one point where we could do some processing to move things from one namespace to another.
                // Alternatively we can try and do this later in processing. See comment with the same date.
                // - Noggin_bops 2023-08-26
                List<API> apis = new List<API>(Enum.GetValues<InputAPI>().Length);
                foreach (API api in alSpecification.APIs.Concat(alcSpecification.APIs))
                {
                    if (apis.Find(x => x.Name == api.Name) != null)
                    {
                        // We already have this API. Merge it?
                        throw new NotImplementedException();
                    }
                    else
                    {
                        apis.Add(api);
                    }
                }

                {
                    foreach (var api in apis)
                    {
                        foreach (var @enum in enums)
                        {
                            if (MatchesAPI(@enum.Apis, api.Name))
                            {
                                bool found = false;
                                foreach (var @ref in api.Enums)
                                {
                                    if (@ref.EnumName == @enum.Name)
                                    {
                                        found = true;
                                        break;
                                    }
                                }

                                // Check that the enum is a part of all the groups it's supposed to be part of.

                                if (found == false)
                                {
                                    // Add the reference to the enum.
                                    //api.Enums.Add(new EnumReference(@enum.Name, null, null, new List<ExtensionReference>(), GLProfile.None));
                                    //Logger.Info($"Adding enum entry '{@enum.MangledName}' into {api.Name}.");
                                }
                            }

                            static bool MatchesAPI(OutputApiFlags flags, InputAPI api)
                            {
                                switch (api)
                                {
                                    case InputAPI.AL: return flags.HasFlag(OutputApiFlags.AL);
                                    case InputAPI.ALC: return flags.HasFlag(OutputApiFlags.ALC);
                                    default: throw new Exception();
                                }
                            }
                        }
                    }
                }

                Specification finalSpecification = new Specification(functions, enums, apis);

                // Read the documentation folders and parse it into data structures.
                //using DocumentationSource documentationSource = Reader.ReadDocumentationFromGithub();
                //Documentation documentation = DocumentationParser.Parse(documentationSource);
                Documentation documentation = new Documentation([]);

                // Processer/overloading
                OutputData outputSpec = Processor.ProcessSpec(finalSpecification, documentation);

                // Writing cs files.
                Writer.Write(outputSpec);

                Writer.WriteEFXPresets(efxPresets);

                st.Stop();
                Logger.Info($"Generated OpenAL bindings in {st.ElapsedMilliseconds} ms");
            }
        }
    }
}
