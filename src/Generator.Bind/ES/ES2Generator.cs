using System.IO;
using Bind.GL2;

namespace Bind.ES
{
    // Generation implementation for OpenGL ES 2.0 and 3.0
    internal class ES2Generator : Generator
    {
        public ES2Generator(Settings settings)
            : base(settings)
        {
            Settings.DefaultOutputPath = Path.Combine(
                Settings.DefaultOutputPath, "./ES20");
            Settings.DefaultOutputNamespace = "OpenTK.Graphics.ES20";
            Settings.DefaultImportsFile = "ES20Core.cs";
            Settings.DefaultDelegatesFile = "ES20Delegates.cs";
            Settings.DefaultEnumsFile = "ES20Enums.cs";
            Settings.DefaultWrappersFile = "ES20.cs";
            Settings.DefaultDocPath = Path.Combine(
                Settings.DefaultDocPath, "ES20");

            Settings.OverridesFiles.Add("GL2/overrides.xml");

            Profile = "gles2";
            Version = "2.0";

            // For compatibility with OpenTK 1.0 and Xamarin, generate
            // overloads using the "All" enum in addition to strongly-typed enums.
            // This can be disabled by passing "-o:-keep_untyped_enums" as a cmdline parameter.
            Settings.DefaultCompatibility |= Settings.Legacy.KeepUntypedEnums;
            //Settings.DefaultCompatibility |= Settings.Legacy.UseDllImports;
        }
    }
}
