using ALGenerator.Parsing;
using GeneratorBase;
using GeneratorBase.Overloading;
using GeneratorBase.Process;
using GeneratorBase.Utility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
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
            
            // These prevent us to accidently generate wrong code because of
            // locale dependent string functions.
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;

            using (Logger.CreateLogger(Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location)!, "log.txt")))
            {
                SpecificationFile alSpecification;
                {
                    NameManglerSettings alSettings = new NameManglerSettings()
                    {
                        FunctionPrefix = "al",
                        // FIXME: This removes the "Format" prefix in the All enum as well...
                        // Do we want that?
                        // - Noggin_bops 2025-09-08
                        EnumPrefixes = new List<string> { "AL_FORMAT_", "AL_", "ALC_" },
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
                        ],
                        EnumAcronymsToKeepCapitalization = [ "UHJ", "MSADPCM", "IMA4", "IMA", "ADPCM", "ALAW", "MULAW", "SN3D", "N3D", "2D", "3D" ],
                    };

                    // Reading the gl.xml file and parsing it into data structures.
                    using FileStream alSpecificationStream = Reader.ReadALSpecFromGithub();
                    alSpecification = SpecificationParser.Parse(alSpecificationStream, new NameMangler(alSettings), ApiFile.AL, new List<string>());
                }

                SpecificationFile alcSpecification;
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
                    alcSpecification = SpecificationParser.Parse(alcSpecificationStream, new NameMangler(alcSettings), ApiFile.ALC, new List<string>());
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

                SpecificationFile[] files = [alSpecification, alcSpecification];
                Processor.CrossReferenceEnums(files);
                List<API> apis = Processor.MakeApis(files);
                List<ResolvedApi> resolvedApis = Processor.ResolveReferences(apis, files);

                // Read the documentation folders and parse it into data structures.
                //using DocumentationSource documentationSource = Reader.ReadDocumentationFromGithub();
                //Documentation documentation = DocumentationParser.Parse(documentationSource);
                Documentation documentation;
                {
                    using FileStream alSOFTSpecificationStream = Reader.ReadALSOFTSpecFromGithub();

                    documentation = DocumentationParser.Parse(alSOFTSpecificationStream);
                }

                IOverloader[] overloaders = [
                    new TrimNameOverloader(TrimNameOverloader.EndingsNotToTrimOpenAL),

                    new StringReturnOverloader(),
                    new BoolReturnOverloader(),

                    new ColorTypeOverloader(),
                    new MathTypeOverloader(),
                    new FunctionPtrToDelegateOverloader(),
                    new PointerToOffsetOverloader(),
                    new VoidPtrToIntPtrOverloader(),
                    new GenCreateAndDeleteOverloader(
                        GenCreateAndDeleteOverloader.PluralNameToSingularNameOpenAL,
                        GenCreateAndDeleteOverloader.PluralParameterNameToSingularNameOpenAL),
                    new StringOverloader(),
                    new StringArrayOverloader(),
                    new SpanAndArrayOverloader(),
                    new RefInsteadOfPointerOverloader(),
                    new OutToReturnOverloader(),
                ];

                // Processer/overloading
                OutputData outputSpec = Processor.ProcessSpec(resolvedApis, files, documentation, overloaders);

                // Writing cs files.
                Writer.Write(outputSpec);

                Writer.WriteEFXPresets(efxPresets);

                st.Stop();
                Logger.Info($"Generated OpenAL bindings in {st.ElapsedMilliseconds} ms");
            }
        }
    }
}
