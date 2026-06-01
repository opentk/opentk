using GeneratorBase;
using GeneratorBase.Overloading;
using GeneratorBase.Process;
using GeneratorBase.Utility;
using GeneratorBase.Utility.Extensions;
using GLGenerator.Parsing;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace GLGenerator
{
    unsafe class Program
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
                SpecificationFile glSpecification;
                {
                    NameManglerSettings glSettings = new NameManglerSettings()
                    {
                        FunctionPrefix = "gl",
                        EnumPrefixes = new List<string> { "GL_" },
                        ExtensionPrefixes = ["GL_"],
                        EnumGroupNameTranslationTable =
                        {
                            { "BufferTargetARB", "BufferTarget" },
                            { "BufferAccessARB", "BufferAccess" },
                            { "BufferUsageARB", "BufferUsage" },
                            { "BufferPNameARB", "BufferPName" },
                            { "ProgramPropertyARB", "ProgramProperty" },
                            { "BlendEquationModeEXT", "BlendEquationMode" },
                        },
                        EnumAcronymsToKeepCapitalization = [ "1D", "2D", "3dfx", "3D" ],
                    };

                    // Reading the gl.xml file and parsing it into data structures.
                    using FileStream specificationStream = Reader.ReadGLSpecFromGithub();
                    glSpecification = SpecificationParser.Parse(specificationStream, new NameMangler(glSettings), ApiFile.GL, new List<string>());
                }

                SpecificationFile wglSpecification;
                {
                    NameManglerSettings wglSettings = new NameManglerSettings()
                    {
                        FunctionPrefix = "wgl",
                        EnumPrefixes = new List<string> { "WGL_" },
                        ExtensionPrefixes = ["WGL_"],
                        FunctionsWithoutPrefix = new HashSet<string>()
                        {
                            "ChoosePixelFormat",
                            "DescribePixelFormat",
                            "GetPixelFormat",
                            "SetPixelFormat",
                            "SwapBuffers",
                            "GetEnhMetaFilePixelFormat",
                        },
                        EnumsWithoutPrefix = new HashSet<string>()
                        {
                            "ERROR_INVALID_VERSION_ARB",
                            "ERROR_INVALID_PROFILE_ARB",
                            "ERROR_INVALID_PIXEL_TYPE_ARB",
                            "ERROR_INCOMPATIBLE_DEVICE_CONTEXTS_ARB",
                            "ERROR_INVALID_PIXEL_TYPE_EXT",
                            "ERROR_INCOMPATIBLE_AFFINITY_MASKS_NV",
                            "ERROR_MISSING_AFFINITY_MASK_NV",
                        },
                        EnumAcronymsToKeepCapitalization = ["1D", "2D", "3dfx", "3D"],
                    };

                    // Reading the gl.xml file and parsing it into data structures.
                    using FileStream wglSpecificationStream = Reader.ReadWGLSpecFromGithub();
                    wglSpecification = SpecificationParser.Parse(wglSpecificationStream, new NameMangler(wglSettings), ApiFile.WGL, new List<string>());
                }

                SpecificationFile glxSpecification;
                {
                    NameManglerSettings glxSettings = new NameManglerSettings()
                    {
                        FunctionPrefix = "glX",
                        EnumPrefixes = new List<string> { "GLX_", "__GLX_" },
                        ExtensionPrefixes = ["GLX_"],
                        FunctionsWithoutPrefix = new HashSet<string>()
                        {
                        },
                        EnumsWithoutPrefix = new HashSet<string>()
                        {
                        },
                        EnumAcronymsToKeepCapitalization = ["1D", "2D", "3dfx", "3D"],
                    };

                    List<string> glxIgnoreFunctions = new List<string>()
                    {
                        // #if _DM_BUFFER_H_
                        "glXAssociateDMPbufferSGIX",
                        // #if _VL_H
                        "glXCreateGLXVideoSourceSGIX",
                        "glXDestroyGLXVideoSourceSGIX"
                    };

                    // Reading the gl.xml file and parsing it into data structures.
                    using FileStream glxSpecificationStream = Reader.ReadGLXSpecFromGithub();
                    glxSpecification = SpecificationParser.Parse(glxSpecificationStream, new NameMangler(glxSettings), ApiFile.GLX, glxIgnoreFunctions);
                }

                SpecificationFile eglAndAngleSpecification;
                {
                    NameManglerSettings eglSettings = new NameManglerSettings()
                    {
                        FunctionPrefix = "egl",
                        EnumPrefixes = new List<string> { "EGL_" },
                        ExtensionPrefixes = ["EGL_"],
                        FunctionsWithoutPrefix = new HashSet<string>()
                        {
                        },
                        EnumsWithoutPrefix = new HashSet<string>()
                        {
                        },
                        EnumAcronymsToKeepCapitalization = ["1D", "2D", "3dfx", "3D"],
                    };

                    List<string> eglIgnoreFunctions = new List<string>()
                    {
                    };

                    // Reading the gl.xml file and parsing it into data structures.
                    using Stream eglAndAngleSpecificationStream = Reader.ReadEGLAndAngleSpecFromGithub();
                    eglAndAngleSpecification = SpecificationParser.Parse(eglAndAngleSpecificationStream, new NameMangler(eglSettings), ApiFile.EGL, eglIgnoreFunctions);
                }

                SpecificationFile[] files = [glSpecification, wglSpecification, glxSpecification, eglAndAngleSpecification];
                Processor.CrossReferenceEnums(files);
                List<API> apis = Processor.MakeApis(files);
                List<ResolvedApi> resolvedApis = Processor.ResolveReferences(apis, files);

                // Read the documentation folders and parse it into data structures.
                using DocumentationSource documentationSource = Reader.ReadDocumentationFromGithub();
                Documentation documentation = DocumentationParser.Parse(documentationSource);

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

                // Writing cs files.
                Writer.Write(outputSpec);

                st.Stop();
                Logger.Info($"Generated OpenGL bindings in {st.ElapsedMilliseconds} ms");
            }
        }
    }
}
