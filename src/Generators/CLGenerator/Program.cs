using CLGenerator.Parsing;
using GeneratorBase;
using GeneratorBase.Overloading;
using GeneratorBase.Process;
using GeneratorBase.Utility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime;
using System.Xml.Linq;

namespace CLGenerator
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
                SpecificationFile clSpecification;
                Dictionary<string, SpecificationParser.TypeEntry> typeMap;
                {
                    NameManglerSettings clSettings = new NameManglerSettings()
                    {
                        FunctionPrefix = "cl",
                        EnumPrefixes = new List<string> { "CL_" },
                        ExtensionPrefixes = ["cl_"],
                        EnumAcronymsToKeepCapitalization = ["1D", "2D", "3dfx", "3D"],
                        EnumGroupPrefixes = ["cl_"],
                        MangleUnderscoresInEnumGroupNames = true,
                        EnumGroupNameTranslationTable = new Dictionary<string, string> {
                            { "clCommandExecutionStatus", "CommandExecutionStatus" },
                        }
                    };

                    // Reading the gl.xml file and parsing it into data structures.
                    using FileStream specificationStream = Reader.ReadCLSpecFromGithub();
                    clSpecification = SpecificationParser.Parse(specificationStream, new NameMangler(clSettings), ApiFile.CL, new List<string>(), out typeMap);
                }

                SpecificationFile[] files = [clSpecification];
                Processor.CrossReferenceEnums(files);
                List<API> apis = Processor.MakeApis(files);
                List<ResolvedApi> resolvedApis = Processor.ResolveReferences(apis, files);

                // FIXME: Documentation.
                Documentation documentation = new Documentation(new Dictionary<OutputApi, Dictionary<string, FunctionDocumentation>>());

                IOverloader[] overloaders = [
                   new TrimNameOverloader(TrimNameOverloader.EndingsNotToTrimOpenGL),

                    new StringReturnOverloader(),
                    new BoolReturnOverloader(),

                    new ColorTypeOverloader(),
                    new MathTypeOverloader(),
                    new FunctionPtrToDelegateOverloader(),
                    new PointerToOffsetOverloader(),
                    new ObjectPtrLabelOverloader(),
                    new VoidPtrToIntPtrOverloader(),
                    new GenCreateAndDeleteOverloader(
                        GenCreateAndDeleteOverloader.PluralNameToSingularNameOpenGL,
                        GenCreateAndDeleteOverloader.PluralParameterNameToSingularNameOpenGL),
                    new StringOverloader(),
                    new StringArrayOverloader(),
                    new SpanAndArrayOverloader(),
                    new RefInsteadOfPointerOverloader(),
                    new OutToReturnOverloader(),
                ];

                // Processer/overloading
                OutputData outputSpec = Processor.ProcessSpec(resolvedApis, files, documentation, overloaders);

                FixupEnumTypes(outputSpec, typeMap);

                // FIXME: Don't use this here.
                NameManglerSettings nameManglerSettings = new NameManglerSettings()
                {
                    FunctionPrefix = "cl",
                    EnumPrefixes = new List<string> { "CL_" },
                    ExtensionPrefixes = ["cl_"],
                    EnumAcronymsToKeepCapitalization = ["1D", "2D", "3dfx", "3D"],
                };
                Writer.Write(outputSpec, new NameMangler(nameManglerSettings));

                st.Stop();
                Logger.Info($"Generated OpenCL bindings in {st.ElapsedMilliseconds} ms");
            }
        }

        // Use the typemap derived from cl.xml typedefs and change the types of the enum types to the correct types.
        // FIXME: This is done quite late in the processing so there is a high risk of bugs due to earlier assumptions about enum types...
        static void FixupEnumTypes(OutputData data, Dictionary<string, SpecificationParser.TypeEntry> typeMap)
        {
            foreach (OutputApiData @namespace in data.Namespaces)
            {
                foreach (EnumType enumType in @namespace.Enums)
                {
                    if (typeMap.TryGetValue(enumType.OriginalName, out var typeEntry))
                    {
                        CSPrimitive primitive;
                        if (typeEntry.CSType is CSPrimitive)
                        {
                            primitive = (CSPrimitive)typeEntry.CSType;
                        }
                        else if (typeEntry.CSType is CSEnum @enum)
                        {
                            primitive = @enum.PrimitiveType;
                        }
                        else throw new Exception("The underlying type of enums needs to be a CSPrimitive or CSEnum");

                        enumType.UnderlyingSize = primitive.TypeName switch
                        {
                            "int" => EnumSize.Int32,
                            "uint" => EnumSize.Uint32,
                            "long" => EnumSize.Int64,
                            "ulong" => EnumSize.Uint64,
                            "IntPtr" => EnumSize.Int32,
                            _ => throw new Exception($"Unsupported enum type '{primitive.ToCSString()}'"),
                        };

                        enumType.StrongUnderlyingType = primitive;
                        if (primitive.TypeName == "IntPtr")
                            enumType.StrongUnderlyingType = CSPrimitive.Int(primitive.Constant);
                    }
                }
            }
        }
    }
}
