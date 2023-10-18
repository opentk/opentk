﻿using System.Diagnostics;
using System.IO;
using System.Reflection;
using Generator.Utility;
using Generator.Writing;
using Generator.Parsing;
using Generator.Process;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading;
using System.Runtime.CompilerServices;

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
                Specification2 glSpecification;
                {
                    NameManglerSettings glSettings = new NameManglerSettings()
                    {
                        FunctionPrefix = "gl",
                        EnumPrefixes = new List<string> { "GL_" },
                        ExtensionPrefix = "GL_",
                    };

                    // Reading the gl.xml file and parsing it into data structures.
                    using FileStream specificationStream = Reader.ReadGLSpecFromGithub();
                    glSpecification = SpecificationParser.Parse(specificationStream, new NameMangler(glSettings), GLFile.GL, new List<string>());
                }

                Specification2 wglSpecification;
                {
                    NameManglerSettings wglSettings = new NameManglerSettings()
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
                    using FileStream wglSpecificationStream = Reader.ReadWGLSpecFromGithub();
                    wglSpecification = SpecificationParser.Parse(wglSpecificationStream, new NameMangler(wglSettings), GLFile.WGL, new List<string>());
                }

                Specification2 glxSpecification;
                {
                    NameManglerSettings glxSettings = new NameManglerSettings()
                    {
                        FunctionPrefix = "glX",
                        EnumPrefixes = new List<string> { "GLX_", "__GLX_" },
                        ExtensionPrefix = "GLX_",
                        FunctionsWithoutPrefix = new HashSet<string>()
                        {
                        },
                        EnumsWithoutPrefix = new HashSet<string>()
                        {
                        },
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
                    glxSpecification = SpecificationParser.Parse(glxSpecificationStream, new NameMangler(glxSettings), GLFile.GLX, glxIgnoreFunctions);
                }

                List<NativeFunction> functions = new List<NativeFunction>(glSpecification.Functions.Count + wglSpecification.Functions.Count + glxSpecification.Functions.Count);
                functions.AddRange(glSpecification.Functions);
                functions.AddRange(wglSpecification.Functions);
                functions.AddRange(glxSpecification.Functions);

                List<EnumEntry> enums = new List<EnumEntry>(glSpecification.Enums.Count + wglSpecification.Enums.Count + glxSpecification.Enums.Count);
                enums.AddRange(glSpecification.Enums);
                enums.AddRange(wglSpecification.Enums);
                enums.AddRange(glxSpecification.Enums);

                // FIXME: This is one point where we could do some processing to move things from one namespace to another.
                // Alternatively we can try and do this later in processing. See comment with the same date.
                // - Noggin_bops 2023-08-26
                List<API> apis = new List<API>(Enum.GetValues<InputAPI>().Length);
                foreach (API api in glSpecification.APIs.Concat(wglSpecification.APIs).Concat(glxSpecification.APIs))
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
                                    case InputAPI.GL: return (flags & (OutputApiFlags.GL | OutputApiFlags.GLCompat)) != 0;
                                    case InputAPI.GLES1: return flags.HasFlag(OutputApiFlags.GLES1);
                                    case InputAPI.GLES2: return flags.HasFlag(OutputApiFlags.GLES2);
                                    case InputAPI.WGL: return flags.HasFlag(OutputApiFlags.WGL);
                                    case InputAPI.GLX: return flags.HasFlag(OutputApiFlags.GLX);
                                    default: throw new Exception();
                                }
                            }
                        }
                    }
                }

                Specification2 finalSpecification = new Specification2(functions, enums, apis);

                // Read the documentation folders and parse it into data structures.
                using DocumentationSource documentationSource = Reader.ReadDocumentationFromGithub();
                Documentation documentation = DocumentationParser.Parse(documentationSource);

                // Processer/overloading
                OutputData outputSpec = Processor.ProcessSpec(finalSpecification, documentation);

                // Writing cs files.
                Writer.Write(outputSpec);

                st.Stop();
                Logger.Info($"Generated OpenGL bindings in {st.ElapsedMilliseconds} ms");
            }
        }
    }
}
