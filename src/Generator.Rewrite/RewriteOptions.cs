using CommandLine;

namespace OpenTK.Rewrite
{
    /// <summary>
    /// A class containing all command line options used when rewriting an assembly.
    /// </summary>
    public class RewriteOptions
    {
        /// <summary>
        /// Gets or sets the path to the target assembly that should be rewritten.
        /// </summary>
        [Option(
            'a',
            "assembly",
            Required = true,
            HelpText = "The path to the target assembly that should be rewritten."
        )]
        public string TargetAssembly { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether calls to GL.GetError() are wrapped around each native call.
        /// </summary>
        [Option(
            'd',
            "debug",
            Default = false,
            HelpText = "Enable calls to GL.GetError(), wrapped around each native call."
        )]
        public bool EnableDebugCalls { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether native calls are forced to use DllImport instead of GetProcAddress.
        /// </summary>
        [Option(
            "dllimport",
            Default = false,
            HelpText = "Force native calls to use DllImport instead of GetProcAddress."
        )]
        public bool UseDllImport { get; set; }
    }
}
