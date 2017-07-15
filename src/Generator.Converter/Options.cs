using System.Collections.Generic;
using CommandLine;
using CommandLine.Text;

namespace OpenTK.Convert
{
    public class Options
    {
        [Option('p', "prefix",
            HelpText = "The prefix to remove from parsed functions and constants.",
            Required = true,
            Default = "gl")]
        public string Prefix { get; set; }

        [Option('o', "output-file",
            HelpText = "The path to the output file. Defaults to stdout if no path is provided.")]
        public string OutputFile { get; set; }

        [Option('i', "input-files",
            HelpText = "A list of the Khronos XML files to parse into OpenTK XML. Remote resources in the form of URLs are supported.",
            Required = true)]
        public IEnumerable<string> InputFiles { get; set; }

        [Usage(ApplicationAlias = "Convert.exe")]
        public static IEnumerable<Example> Examples
        {
            get
            {
                yield return new Example
                (
                    "Converting local files",
                    new Options { Prefix = "gl", OutputFile = "signatures.xml", InputFiles = new []{ "gl.xml" } }
                );

                yield return new Example
                (
                    "Converting latest remote specification",
                    new Options { Prefix = "gl", OutputFile = "signatures.xml", InputFiles = new []{ "https://cvs.khronos.org/svn/repos/ogl/trunk/doc/registry/public/api/gl.xml" } }
                );
            }
        }
    }
}