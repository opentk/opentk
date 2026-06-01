using GeneratorBase;
using GeneratorBase.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGenerator.Parsing
{
    internal record Documentation(
        Dictionary<string, EnumMemberDocumentation> EnumDocs,
        Dictionary<string, FunctionDocumentation> CommandDocs
        ) : IDocumentation
    {
        public Dictionary<Function, FunctionDocumentation> CreateFunctionDocumentation(OutputApi api, List<VendorFunctions> functions)
        {
            Dictionary<Function, FunctionDocumentation> functionsDocumentation = new Dictionary<Function, FunctionDocumentation>();
            foreach (var vendorFunctions in functions)
            {
                foreach (var function in vendorFunctions.Functions)
                {
                    FunctionDocumentation? functionDocumentation = GetFunctionDocumentation(function.NativeFunction);

                    List<Link> urls = [];
                    if (function.NativeFunction.VersionInfo!.Version != null &&
                        functionDocumentation?.RefPagesLinks.Count == 0)
                    {
                        // We use a google docs link to be able to link directly to a readable PDF
                        // so the user doesn't get prompted to download the PDF.
                        // - Noggin_bops 2025-12-07
                        const string googleDocsPdfViewerLink = "https://docs.google.com/viewer?url={0}";
                        const string al1_1Reflink = "https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/master/Specification/spec%201.1/OpenAL1-1Spec.pdf";

                        urls.Add(new Link(string.Format(googleDocsPdfViewerLink, al1_1Reflink), "OpenAL 1.1 specification"));
                    }

                    foreach (var extension in function.NativeFunction.VersionInfo!.Extensions)
                    {
                        string ext = extension.Name;

                        string? apiString;
                        if (extension.Name.StartsWith("AL_") || extension.Name.StartsWith("EAX"))
                        {
                            apiString = "AL%20Extensions";
                        }
                        else if (extension.Name.StartsWith("ALC_"))
                        {
                            apiString = "ALC%20Extensions";
                        }
                        else
                        {
                            apiString = null;
                            Logger.Warning($"Unable to figure out the reflink for the '{extension.Name}' extension.");
                        }

                        if (apiString != null)
                        {
                            string url = $"https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/{apiString}/{ext}.txt";
                            urls.Add(new Link(url, $"{ext}.txt"));
                        }
                    }

                    if (functionDocumentation != null)
                    {
                        // Here we assume this will produce identical documentation even if this is done multiple times...
                        functionsDocumentation[function.NativeFunction] = functionDocumentation with
                        {
                            VersionInfo = function.NativeFunction.VersionInfo,
                            RefPagesLinks = [.. functionDocumentation.RefPagesLinks, .. urls]
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
                            RefPagesLinks = urls,
                            VersionInfo = function.NativeFunction.VersionInfo,
                        };
                    }
                }
            }
            return functionsDocumentation;
        }

        private FunctionDocumentation? GetFunctionDocumentation(Function function)
        {
            CommandDocs.TryGetValue(function.EntryPoint, out FunctionDocumentation? docs);
            return docs;
        }

        public Dictionary<string, EnumMemberDocumentation> CreateEnumMemberDocumentation(OutputApi api, List<EnumMember> enums)
        {
            return EnumDocs;
        }
    }
}
