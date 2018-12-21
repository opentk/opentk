using System.Collections.Generic;
using CommandLine;
using CommandLine.Text;
using Generator.Convert.Baking;
using JetBrains.Annotations;

namespace Generator.Convert
{
    /// <summary>
    /// A container class used by <see cref="CommandLine.Parser" /> to parse command line arguments.
    /// </summary>
    public class Options
    {
        /// <summary>
        /// Gets or sets the prefix to remove from parsed functions and constants.
        /// </summary>
        [Option
        (
            'p', "prefix",
            HelpText = "The prefix to remove from parsed functions and constants.",
            Default = "gl"
        )]
        public string Prefix { get; set; } = "gl";

        /// <summary>
        /// Gets or sets the path to the output file. Defaults to stdout if no path is provided.
        /// </summary>
        [Option
        (
            'o', "output-folder",
            HelpText = "The folder that the profiles should be written to.",
            Required = true
        )]
        public string OutputFolder { get; set; }

        /// <summary>
        /// Gets or sets a list of the Khronos XML files to parse into OpenTK XML. Remote resources in the form of URLs are
        /// supported.
        /// </summary>
        [Option
        (
            'i', "input-files",
            HelpText =
                "A list of the Khronos XML files to parse into OpenTK XML. Remote resources in the form of URLs are supported.",
            Required = true
        )]
        public IEnumerable<string> InputFiles { get; set; }

        /// <summary>
        /// Gets or sets a list of paths to JSON <see cref="ProfileBakeryInformation"/> files.
        /// Defaults to <see cref="ProfileBakeryInformation.Default"/>.
        /// </summary>
        [Option('b', "bakery-info", HelpText = "A list of paths to JSON ProfileBakeryInformation files.")]
        public IEnumerable<string> BakeryInformation { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the output files should be pretty printed.
        /// </summary>
        [Option
        (
            'f', "pretty", HelpText = "Indicates that the output files should be pretty printed.",
            Default = false
        )]
        public bool PrettyPrinted { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether the raw (unbaked) API files should be kept.
        /// </summary>
        [Option
        (
            'k', "preserve", HelpText = "Indicates that the raw (unbaked) API files shouldn't be deleted.",
            Default = false
        )]
        public bool PreserveRawAPIs { get; set; } = false;

        /// <summary>
        /// Gets or sets the path of the typemap to be used.
        /// </summary>
        [Option('t', "typemap", HelpText = "The path of the typemap to use.", Required = false)]
        public string Typemap { get; set; }
        
        /// <summary>
        /// Gets a set of usage examples which can be shown to the user.
        /// </summary>
        [Usage(ApplicationAlias = "Convert")]
        public static IEnumerable<Example> Examples
        {
            get
            {
                yield return new Example
                (
                    "Converting local files",
                    new Options {Prefix = "gl", OutputFolder = "Specifications", InputFiles = new[] {"gl.xml"}}
                );

                yield return new Example
                (
                    "Converting latest remote specification",
                    new Options
                    {
                        Prefix = "gl",
                        OutputFolder = "Specifications",
                        InputFiles = new[]
                            {"https://cvs.khronos.org/svn/repos/ogl/trunk/doc/registry/public/api/gl.xml"}
                    }
                );
            }
        }
    }
}
