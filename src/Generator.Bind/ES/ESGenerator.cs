using System.IO;
using Bind.GL2;

namespace Bind.ES
{
    // Generator implementation for OpenGL ES 1.0 and 1.1
    internal class ESGenerator : Generator
    {
        public ESGenerator(Settings settings)
            : base(settings)
        {
            Settings.DefaultOutputPath = Path.Combine(
                Settings.DefaultOutputPath, "../ES11");
            Settings.DefaultOutputNamespace = "OpenTK.Graphics.ES11";
            Settings.DefaultImportsFile = "ES11Core.cs";
            Settings.DefaultDelegatesFile = "ES11Delegates.cs";
            Settings.DefaultEnumsFile = "ES11Enums.cs";
            Settings.DefaultWrappersFile = "ES11.cs";
            Settings.DefaultDocPath = Path.Combine(
                Settings.DefaultDocPath, "ES20"); // no ES11 docbook sources available

            Settings.OverridesFiles.Add("GL2/overrides.xml");
            Settings.OverridesFiles.Add("GL2/ES/1.1/");

            // Khronos releases a combined 1.0+1.1 specification,
            // so we cannot distinguish between the two.
            // Todo: add support for common and light profiles.
            Profile = "gles1";
            // no explicit version means both 1.0 and 1.1 versions
        }
    }
}
