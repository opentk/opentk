using System.Collections.Generic;
using System.IO;
using CommandLine;

namespace Generator.Bind
{
    /// <summary>
    /// Holds command-line arguments, parsed from the command line.
    /// </summary>
    public sealed class Options
    {
        /// <summary>
        /// Gets or sets the base input path where the binder looks for specification files.
        /// </summary>
        [Option
        (
            'i',
            "input-files",
            HelpText = "The input files to write.",
            Required = true
        )]
        public IEnumerable<string> InputFiles { get; set; }

        /// <summary>
        /// Gets or sets the base output path where the binder will write the generated files.
        /// </summary>
        [Option
        (
            'o',
            "output-path",
            HelpText = "The base output path where the binder will write the generated files.",
            Required = true
        )]
        public string OutputPath { get; set; }
    }
}
