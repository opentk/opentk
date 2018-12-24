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
        [Option('i', "input", HelpText = "The base input path where the binder looks for specification files.")]
        public string InputPath { get; set; } = Path.Combine("generators", "Generator.Bind", "Specifications");

        /// <summary>
        /// Gets or sets the base output path where the binder will write the generated files.
        /// </summary>
        [Option('o', "output", HelpText = "The base output path where the binder will write the generated files.")]
        public string OutputPath { get; set; } = Path.Combine("src");
    }
}
