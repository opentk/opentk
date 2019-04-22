using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Humanizer;

namespace Bind.XML.Documentation
{
    /// <summary>
    /// Contains methods for reading docs.gl XHTML files.
    /// </summary>
    public class DocumentationReader
    {
        private static readonly Regex RedirectRegex = new Regex
            ("<script>window\\.location\\.replace\\(\"(?<redirect>.*)\"\\);<\\/script>");

        /// <summary>
        /// Reads function documentation from a directory containing docs.gl XHTML files.
        /// </summary>
        /// <param name="directory">The directory which contains the docs.gl XHTML files.</param>
        /// <returns>A dictionary where the function name is the key, and its documentation is the value.</returns>
        public static async Task<ProfileDocumentation> ReadDocumentationAsync(string directory)
        {
            return new ProfileDocumentation
            (
                await Task.WhenAll
                (
                    Directory.GetFiles(directory, "*.xhtml")
                        .Select(x => ReadFunctionDocumentationAsync(x))
                )
            );
        }

        private static Task<FunctionDocumentation> ReadFunctionDocumentationAsync(string xhtmlFile, string nameO = null)
        {
            if (!File.Exists(xhtmlFile))
            {
                return Task.FromResult
                (
                    new FunctionDocumentation
                    (
                        nameO ?? Path.GetFileNameWithoutExtension(xhtmlFile),
                        "To be added.",
                        new ParameterDocumentation[0],
                        null
                    )
                );
            }

            var file = File.ReadAllText(xhtmlFile);
            if (RedirectRegex.IsMatch(file))
            {
                var m = RedirectRegex.Match(file);
                var redirected = Path.Combine(Path.GetDirectoryName(xhtmlFile), m.Groups["redirect"].Value + ".xhtml");
                return Task.FromResult
                (
                    ReadFunctionDocumentationAsync(redirected, Path.GetFileNameWithoutExtension(xhtmlFile))
                        .GetAwaiter()
                        .GetResult()
                );
            }

            var document = new HtmlDocument();
            document.LoadHtml(file);
            var div = document.DocumentNode.ChildNodes.FirstOrDefault(x => x.Name == "div")
                ?.ChildNodes.FirstOrDefault
                (
                    x => x.HasClass("refsect1") && x.ChildNodes.Any(y => y.Name == "h2" && y.InnerText == "Parameters")
                );

            var parameters = new Dictionary<string, ParameterDocumentation>();
            if (div != null)
            {
                var variableList = div?.ChildNodes.FirstOrDefault(x => x.HasClass("variablelist"))
                    ?
                    .ChildNodes
                    .FirstOrDefault(x => x.Name == "dl")
                    ?
                    .ChildNodes;
                var dt = string.Empty; // parameter name
                foreach (var child in variableList)
                {
                    if (child.Name == "dt")
                    {
                        dt = MegaTrim(child.InnerText);
                    }
                    else if (child.Name == "dd")
                    {
                        parameters[dt] = new ParameterDocumentation(dt, child.InnerText);
                        dt = string.Empty;
                    }
                }
            }

            div = document.DocumentNode.ChildNodes.FirstOrDefault(x => x.Name == "div")
                ?.ChildNodes.FirstOrDefault
                (
                    x => x.HasClass("refnamediv") && x.ChildNodes.Any(y => y.Name == "h2" && y.InnerText == "Name")
                );
            div.RemoveChild(div.ChildNodes.FirstOrDefault(x => x.Name == "h2"));
            var description = StyleGuideCompliance
                                  (
                                      FixWhitespace
                                      (
                                          MegaTrim
                                          (
                                              div.InnerText.Substring
                                                      (div.InnerText.IndexOf("—", StringComparison.Ordinal) + 2)
                                                  .Transform(To.SentenceCase)
                                                  .Trim()
                                          )
                                      )
                                  )
                                  .TrimEnd('.') + ".";

            return Task.FromResult
            (
                new FunctionDocumentation
                (
                    nameO ?? Path.GetFileNameWithoutExtension(xhtmlFile),
                    description,
                    new ParameterDocumentation[0],
                    null
                )
            );
        }

        private static string FixWhitespace(string str)
        {
            return Regex.Replace(str, @"\s+", " ");
        }

        private static string MegaTrim(string str)
        {
            return string.Join
                (" ", str.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()));
        }

        private static string StyleGuideCompliance(string longString)
        {
            var s = Regex.Split(longString, @"(.{1,100})(?:\s|$)");
            return string.Join
            (
                "\n",
                s.Where(x => !string.IsNullOrWhiteSpace(x)).ToList()
            );
        }

        /// <summary>
        /// Reads all documentation from the given directory, and trims the given prefix from the function names.
        /// </summary>
        /// <param name="directory">The directory containing the documentation.</param>
        /// <param name="prefix">The prefix to trim from the function names.</param>
        /// <returns>The parsed documentation.</returns>
        public static ProfileDocumentation ReadProfileDocumentation(string directory, string prefix)
        {
            return ReadDocumentationAsync(directory).GetAwaiter().GetResult();
        }
    }
}
