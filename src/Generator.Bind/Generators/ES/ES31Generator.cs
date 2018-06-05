using System.IO;
using Bind.Generators.GL2;
using Bind.GL2;

namespace Bind.Generators.ES
{
    // Generation implementation for OpenGL ES 3.1
    internal class ES31Generator : Generator
    {
        public ES31Generator(Settings settings)
            : base(settings)
        {
            Settings.DefaultOutputPath = Path.Combine(
                Settings.DefaultOutputPath, "../ES31");
            Settings.DefaultOutputNamespace = "OpenTK.Graphics.ES31";
            Settings.DefaultImportsFile = "ES31.Core.cs";
            Settings.DefaultDelegatesFile = "ES31.Delegates.cs";
            Settings.DefaultEnumsFile = "ES31.Enums.cs";
            Settings.DefaultWrappersFile = "ES31.cs";
            Settings.DefaultDocPath = Path.Combine(
                Settings.DefaultDocPath, "ES31");

            Settings.OverridesFiles.Add("GL2/overrides.xml");
            Settings.OverridesFiles.Add("GL2/ES/3.1");

            Profile = "gles2";
            Version = "2.0|3.0|3.1";
        }
    }
}
