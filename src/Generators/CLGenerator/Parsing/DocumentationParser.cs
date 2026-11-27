using AngleSharp.Dom;
using AngleSharp.Html.Parser;
using GeneratorBase;
using GeneratorBase.Utility;
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

                    // FIXME: Sometime "_ret" parameters are not documented in the normal
                    // parameter list but instead in the "Description" part.
                    // See: https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clCreateCommandQueue.html
                    // - Noggin_bops 2026-11-26
                    var parameterDescriptions = doc.QuerySelectorAll("#_parameters + div > div:nth-child(1) > ul > li > p");

                    List<ParameterDocumentation> parameters = new List<ParameterDocumentation>(parameterDescriptions.Count);
                    foreach (var parameterDescription in parameterDescriptions)
                    {
                        
                        string parameterDesc = parameterDescription.TextContent;
                        parameterDesc = HtmlToXml(parameterDescription);

                        // Sometimes a list item documents more than one parameter.
                        // Here are some common patterns for parameter descriptions that
                        // document one or more parameters in one list item.
                        // <em>name</em> ...
                        // <em>name1</em> and <em>name2</em> ...
                        // <em>name1</em>, <em>name2</em> ...
                        // So we do a best effort to catch these cases and duplicate the documentation for these parameters.
                        // - Noggin_bops 2026-11-26
                        if (parameterDescription.ChildNodes.Length > 3 &&
                            parameterDescription.ChildNodes[0].NodeName == "EM" &&
                            (parameterDescription.ChildNodes[1].TextContent == ", " || parameterDescription.ChildNodes[1].TextContent == " and ") &&
                            parameterDescription.ChildNodes[2].NodeName == "EM")
                        {
                            // FIXME: possibly convert the InnerHtml to xml documentation to retain formatting.
                            string parameterName1 = parameterDescription.ChildNodes[0].TextContent;
                            string parameterName2 = parameterDescription.ChildNodes[2].TextContent;
                            parameters.Add(new ParameterDocumentation(parameterName1, parameterDesc));
                            parameters.Add(new ParameterDocumentation(parameterName2, parameterDesc));
                        }
                        else
                        {
                            string parameterName = parameterDescription.QuerySelector("em")!.TextContent;
                            parameters.Add(new ParameterDocumentation(parameterName, parameterDesc));
                        }
                    }

                    // Here we could theoretically set the RefPagesLinks value definitively for the functions that we know have documentation
                    // because we've downloaded the documentation from the link in the first place.
                    // But for now we do it later when we apply the extension ref links because it's "easier", but might be slightly error prone.
                    // - Noggin_bops 2026-11-27

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

        private static string HtmlToXml(IElement element)
        {
            StringBuilder sb = new StringBuilder();
            AppendHtmlElementToXml(sb, element);
            return sb.ToString();

            static void AppendHtmlElementToXml(StringBuilder sb, INode node)
            {
                string? xmlTag = null;
                if (node.NodeType == NodeType.Element)
                {
                    IElement element = (node as IElement)!;
                    string htmlTagName = element.TagName;
                    xmlTag = htmlTagName switch
                    {
                        "P" => "para",
                        "EM" => "i",
                        "B" => "b",
                        "U" => "u",
                        "CODE" => "c",
                        "A" => "a",
                        _ => null,
                    };

                    string? href = element.GetAttribute("href");

                    if (xmlTag != null && href != null)
                    {
                        sb.Append($"<{xmlTag} href=\"{href}\">");
                    }
                    else if (xmlTag != null)
                    {
                        sb.Append($"<{xmlTag}>");
                    }
                    else if (htmlTagName == "BR")
                    {
                        sb.Append("<br/>");
                    }
                }
                else if (node.NodeType == NodeType.Text)
                {
                    // We don't insert <br/> on \n because the html should contain br tags on it's own.
                    sb.Append(NameMangler.XmlEscapeMultiLine(node.TextContent, false));
                }

                foreach (var child in node.ChildNodes)
                {
                    AppendHtmlElementToXml(sb, child);
                }

                if (xmlTag != null)
                {
                    sb.Append($"</{xmlTag}>");
                }
            }
        }
    }
}
