using AngleSharp.Html.Parser;
using GeneratorBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace CLGenerator.Parsing
{
    static class DocumentationParser
    {
        public static Documentation Parse(DocumentationSource source)
        {
            HtmlParser parser = new HtmlParser();
            Dictionary<OutputApi, Dictionary<string, FunctionDocumentation>> documentation = new Dictionary<OutputApi, Dictionary<string, FunctionDocumentation>>();

            foreach (var folder in source.Folders)
            {
                Dictionary<string, FunctionDocumentation> docFolder = new Dictionary<string, FunctionDocumentation>();

                OutputApi api = folder.Folder switch
                {
                    "cl" => OutputApi.CL,
                    _ => throw new NotImplementedException()
                };

                foreach (var (function, file) in folder.FunctionFiles)
                {
                    var doc = parser.ParseDocument(file);

                    var nameDescription = doc.QuerySelector("#_name + div > p")!;
                    string functionDesc = nameDescription.TextContent.Split(" - ")[1];

                    // FIXME: Sometimes a list item documents more than one parameter.
                    // Here are some common patterns for parameter descriptions that
                    // document one or more parameters in one list item.
                    // <em>name</em> ...
                    // <em>name1</em> and <em>name2</em> ...
                    // <em>name1</em>, <em>name2</em> ...
                    // - Noggin_bops 2026-11-26
                    // FIXME: Sometime "_ret" parameters are not documented in the normal
                    // parameter list but instead in the "Description" part.
                    // See: https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clCreateCommandQueue.html
                    // - Noggin_bops 2026-11-26
                    var parameterDescriptions = doc.QuerySelectorAll("#_parameters + div > div:nth-child(1) > ul > li > p");

                    List<ParameterDocumentation> parameters = new List<ParameterDocumentation>(parameterDescriptions.Count);
                    foreach (var parameterDescription in parameterDescriptions)
                    {
                        string parameterName = parameterDescription.QuerySelector("em")!.TextContent;
                        string parameterDesc = parameterDescription.TextContent;
                        parameters.Add(new ParameterDocumentation(parameterName, parameterDesc));
                    }

                    // FIXME: Parse return value documentation.
                    docFolder.Add(function, new FunctionDocumentation() {
                        FunctionName = function,
                        Purpose = functionDesc,
                        Parameters = parameters.ToArray(),
                        RefPagesLinks = [],
                        VersionInfo = default,
                    });
                }

                documentation.Add(OutputApi.CL, docFolder);
            }

            return new Documentation(documentation);
        }

    }
}
