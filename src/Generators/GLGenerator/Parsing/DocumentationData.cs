using GeneratorBase;
using GeneratorBase.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLGenerator.Parsing
{
    internal record Documentation(
        // FIXME: Better name
        Dictionary<OutputApi, Dictionary<string, FunctionDocumentation>> VersionDocumentation
        ) : IDocumentation
    {
        public Dictionary<Function, FunctionDocumentation> CreateFunctionDocumentation(OutputApi api, List<VendorFunctions> functions)
        {
            Dictionary<Function, FunctionDocumentation> functionsDocumentation = new Dictionary<Function, FunctionDocumentation>();
            foreach (var vendorFunctions in functions)
            {
                foreach (var function in vendorFunctions.Functions)
                {
                    List<Link> extensionURLs = [];
                    foreach (var extension in function.NativeFunction.VersionInfo!.Extensions)
                    {
                        string ext = NameMangler.MaybeRemoveStart(extension.Name, "GL_");

                        string url;
                        if (extension.Vendor == "ANGLE" || extension.Vendor == "CHROMIUM")
                        {
                            url = $"https://chromium.googlesource.com/angle/angle/+/refs/heads/main/extensions/{ext}.txt";
                        }
                        else
                        {
                            string apiString = api switch
                            {
                                OutputApi.GL => "OpenGL",
                                OutputApi.GLCompat => "OpenGL",
                                OutputApi.GLES1 => "OpenGL",
                                OutputApi.GLES2 => "OpenGL",
                                OutputApi.WGL => "OpenGL",
                                OutputApi.GLX => "OpenGL",
                                OutputApi.EGL => "EGL",
                                _ => throw new Exception()
                            };

                            url = $"https://registry.khronos.org/{apiString}/extensions/{extension.Vendor}/{ext}.txt";
                        }
                        extensionURLs.Add(new Link(url, $"{ext}.txt"));
                    }

                    FunctionDocumentation? functionDocumentation = GetFunctionDocumentation(api, function.NativeFunction);
                    if (functionDocumentation != null)
                    {
                        // Here we assume this will produce identical documentation even if this is done multiple times...
                        functionsDocumentation[function.NativeFunction] = functionDocumentation with
                        {
                            VersionInfo = function.NativeFunction.VersionInfo,
                            RefPagesLinks = [.. functionDocumentation.RefPagesLinks, .. extensionURLs]
                        };
                    }
                    else
                    {
                        // Extensions don't have documentation, so we don't warn about them.
                        if (vendorFunctions.Vendor == "")
                        {
                            if (api == OutputApi.GL || api == OutputApi.GLCompat || api == OutputApi.GLES1 || api == OutputApi.GLES2)
                            {
                                Logger.Warning($"{function.NativeFunction.EntryPoint} doesn't have any documentation for {api}");
                            }
                        }

                        // Here we assume this will produce identical documentation even if this is done multiple times...
                        functionsDocumentation[function.NativeFunction] = new FunctionDocumentation()
                        {
                            FunctionName = function.NativeFunction.EntryPoint,
                            Purpose = "",
                            Parameters = [],
                            RefPagesLinks = extensionURLs,
                            VersionInfo = function.NativeFunction.VersionInfo,
                        };
                    }
                }
            }
            return functionsDocumentation;
        }

        private FunctionDocumentation? GetFunctionDocumentation(OutputApi api, Function function)
        {
            FunctionDocumentation? functionDocumentation = GetFunctionDocumentation(api, function.EntryPoint);
            if (functionDocumentation != null)
            {
                if (function.Parameters.Count != functionDocumentation.Parameters.Length)
                {
                    Logger.Warning($"Function {function.EntryPoint} has differnet number of parameters than the parsed documentation. (gl.xml:{function.Parameters.Count}, documentation:{functionDocumentation.Parameters.Length})");
                }

                for (int i = 0; i < Math.Min(function.Parameters.Count, functionDocumentation.Parameters.Length); i++)
                {
                    if (function.Parameters[i].OriginalName != functionDocumentation.Parameters[i].ParameterName)
                    {
                        //Logger.Warning($"[{version}][{function.EntryPoint}] Function parameter '{function.Parameters[i].OriginalName}' doesn't have the same name in the documentation. ('{commandDoc.Parameters[i].ParameterName}')");
                    }
                }

                return functionDocumentation;
            }
            else
            {
                return null;
            }
        }

        private FunctionDocumentation? GetFunctionDocumentation(OutputApi api, string entryPoint)
        {
            if (VersionDocumentation.TryGetValue(api, out var apiFunctions))
                if (apiFunctions.TryGetValue(entryPoint, out var function))
                    return function;
            return null;
        }

        public Dictionary<string, EnumMemberDocumentation> CreateEnumMemberDocumentation(OutputApi api, List<EnumMember> enums)
        {
            return [];
        }
    }
}
