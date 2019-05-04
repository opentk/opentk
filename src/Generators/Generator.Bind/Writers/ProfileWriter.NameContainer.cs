using System.IO;
using System.Threading.Tasks;
using Bind.Generators;

namespace Bind.Writers
{
    internal partial class ProfileWriter
    {
        /// <summary>
        /// Writes a name container to the given file.
        /// </summary>
        /// <param name="file">The file to write the name container to.</param>
        /// <param name="ns">The namespace of the name container.</param>
        /// <param name="name">The full name of the profile (i.e. OpenGL, OpenGLES).</param>
        /// <param name="val">The name container to write.</param>
        /// <returns>An asynchronous task.</returns>
        public static async Task WriteNameContainerAsync(string file, string ns, string name, NameContainer val)
        {
            var sw = new StreamWriter(File.Open(file, FileMode.Create, FileAccess.ReadWrite, FileShare.Inheritable));
            await sw.WriteLineAsync("using OpenToolkit.Core.Loader;");
            await sw.WriteLineAsync();
            await sw.WriteLineAsync("namespace " + ns);
            await sw.WriteLineAsync("{");
            await sw.WriteLineAsync("    /// <summary>");
            await sw.WriteLineAsync($"    /// Contains the library name of {name}.");
            await sw.WriteLineAsync("    /// </summary>");
            await sw.WriteLineAsync($"    internal class {val.ClassName} : PlatformLibraryNameContainerBase");
            await sw.WriteLineAsync("    {");
            await sw.WriteLineAsync("        /// <inheritdoc />");
            await sw.WriteLineAsync($"        public override string Linux => \"{val.Linux}\";");
            await sw.WriteLineAsync();
            await sw.WriteLineAsync("        /// <inheritdoc />");
            await sw.WriteLineAsync($"        public override string MacOS => \"{val.MacOS}\";");
            await sw.WriteLineAsync();
            await sw.WriteLineAsync("        /// <inheritdoc />");
            await sw.WriteLineAsync($"        public override string Android => \"{val.Android}\";");
            await sw.WriteLineAsync();
            await sw.WriteLineAsync("        /// <inheritdoc />");
            await sw.WriteLineAsync($"        public override string IOS => \"{val.IOS}\";");
            await sw.WriteLineAsync();
            await sw.WriteLineAsync("        /// <inheritdoc />");
            await sw.WriteLineAsync($"        public override string Windows => \"{val.Windows}\";");
            await sw.WriteLineAsync("    }");
            await sw.WriteLineAsync("}");
            sw.Dispose();
        }
    }
}
