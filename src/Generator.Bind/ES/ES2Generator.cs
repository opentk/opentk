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
                Settings.DefaultOutputPath, "../ES20");
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
        }
    }
}
