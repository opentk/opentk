using System.IO;
using Bind.GL2;

namespace Bind.ES
{
    // Generation implementation for OpenGL ES 3.0
    internal class ES3Generator : Generator
    {
        public ES3Generator(Settings settings)
            : base(settings)
        {
            Settings.DefaultOutputPath = Path.Combine(
                Settings.DefaultOutputPath, "../ES30");
            Settings.DefaultOutputNamespace = "OpenTK.Graphics.ES30";
            Settings.DefaultImportsFile = "ES30Core.cs";
            Settings.DefaultDelegatesFile = "ES30Delegates.cs";
            Settings.DefaultEnumsFile = "ES30Enums.cs";
            Settings.DefaultWrappersFile = "ES30.cs";
            Settings.DefaultDocPath = Path.Combine(
                Settings.DefaultDocPath, "ES30");

            Settings.OverridesFiles.Add("GL2/overrides.xml");

            Profile = "gles2"; // The 3.0 spec reuses the gles2 apiname
            Version = "2.0|3.0";
        }
    }
}
