using System.Diagnostics;
using System.IO;
using System.Reflection;
using Generator.Utility;
using Generator.Writing;
using Generator.Parsing;
using Generator.Process;
using System.Collections.Generic;

namespace Generator
{
    unsafe class Program
    {
        static void Main(string[] args)
        {
            Stopwatch st = new Stopwatch();
            st.Start();
            using (Logger.CreateLogger(Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location)!, "log.txt")))
            {
                {
                    GeneratorSettings.Settings = new GeneratorSettings()
                    {
                        FunctionPrefix = "gl",
                        EnumPrefixes = new List<string> { "GL_" },
                        ExtensionPrefix = "GL_",
                    };

                    // Reading the gl.xml file and parsing it into data structures.
                    using FileStream specificationStream = Reader.ReadGLSpecFromGithub();
                    Specification2 specification = SpecificationParser.Parse(specificationStream);
                    
                    // Read the documentation folders and parse it into data structures.
                    using DocumentationSource documentationSource = Reader.ReadDocumentationFromGithub();
                    Documentation documentation = DocumentationParser.Parse(documentationSource);
                    
                    // Processer/overloading
                    OutputData outputSpec = Processor.ProcessSpec2(specification, documentation);

                    // Writing cs files.
                    Writer.Write(outputSpec, "GL");

                    st.Stop();
                    Logger.Info($"Generated OpenGL bindings in {st.ElapsedMilliseconds} ms");
                    /**/
                }

                st.Restart();
                {
                    GeneratorSettings.Settings = new GeneratorSettings()
                    {
                        FunctionPrefix = "wgl",
                        EnumPrefixes = new List<string> { "WGL_" },
                        ExtensionPrefix = "WGL_",
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
                        }
                    };

                    // Reading the gl.xml file and parsing it into data structures.
                    using FileStream specificationStream = Reader.ReadWGLSpecFromGithub();
                    Specification2 specification = SpecificationParser.Parse(specificationStream);
                    
                    // FIXME: Does there exist wgl documentation?
                    // Read the documentation folders and parse it into data structures.
                    //using DocumentationSource documentationSource = Reader.ReadDocumentationFromGithub();
                    Documentation documentation = new Documentation(new Dictionary<OutputApi, VersionDocumentation>());

                    // Processer/overloading
                    OutputData outputSpec = Processor.ProcessSpec2(specification, documentation);

                    // Writing cs files.
                    Writer.Write(outputSpec, "WGL");

                    st.Stop();
                    Logger.Info($"Generated WGL bindings in {st.ElapsedMilliseconds} ms");
                }

                st.Restart();
                {
                    GeneratorSettings.Settings = new GeneratorSettings()
                    {
                        FunctionPrefix = "glX",
                        EnumPrefixes = new List<string> { "GLX_", "__GLX_" },
                        ExtensionPrefix = "GLX_",
                        FunctionsWithoutPrefix = new HashSet<string>()
                        {
                            /*"ChoosePixelFormat",
                            "DescribePixelFormat",
                            "GetPixelFormat",
                            "SetPixelFormat",
                            "SwapBuffers",
                            "GetEnhMetaFilePixelFormat",*/
                        },
                        EnumsWithoutPrefix = new HashSet<string>()
                        {
                            /*"ERROR_INVALID_VERSION_ARB",
                            "ERROR_INVALID_PROFILE_ARB",
                            "ERROR_INVALID_PIXEL_TYPE_ARB",
                            "ERROR_INCOMPATIBLE_DEVICE_CONTEXTS_ARB",
                            "ERROR_INVALID_PIXEL_TYPE_EXT",
                            "ERROR_INCOMPATIBLE_AFFINITY_MASKS_NV",
                            "ERROR_MISSING_AFFINITY_MASK_NV",*/
                        },
                        IgnoreFunctions = new List<string>()
                        {
                            // #if _DM_BUFFER_H_
                            "glXAssociateDMPbufferSGIX",
                            // #if _VL_H
                            "glXCreateGLXVideoSourceSGIX",
                            "glXDestroyGLXVideoSourceSGIX"
                        }
                    };

                    // Reading the gl.xml file and parsing it into data structures.
                    using FileStream specificationStream = Reader.ReadGLXSpecFromGithub();
                    Specification2 specification = SpecificationParser.Parse(specificationStream);

                    // FIXME: Does there exist glx documentation?
                    // Read the documentation folders and parse it into data structures.
                    //using DocumentationSource documentationSource = Reader.ReadDocumentationFromGithub();
                    Documentation documentation = new Documentation(new Dictionary<OutputApi, VersionDocumentation>());

                    // Processer/overloading
                    OutputData outputSpec = Processor.ProcessSpec2(specification, documentation);

                    // Writing cs files.
                    Writer.Write(outputSpec, "GLX");

                    st.Stop();
                    Logger.Info($"Generated GLX bindings in {st.ElapsedMilliseconds} ms");
                }
            }
        }
    }
}
