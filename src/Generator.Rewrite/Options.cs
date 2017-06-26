using CommandLine;

namespace OpenTK.Rewrite
{
    public class Options
    {
        [Option('d', "debug", DefaultValue = false,
            HelpText = "Enable calls to GL.GetError(), wrapped around each native call.")]
        public bool EnableDebugCalls { get; set; }

        [Option("dllimport", DefaultValue = false,
            HelpText = "Force native calls to use DllImport instead of GetProcAddress.")]
        public bool UseDLLImport { get; set; }

        [Option('i', "assembly", Required = true,
            HelpText = "The path to the target assembly that should be rewritten.")]
        public string TargetAssembly { get; set; }

        [Option('k', "signing-key",
            HelpText = "The path to the strong name key which should be used to sign or resign the assembly.")]
        public string StrongNameKey { get; set; }
    }
}