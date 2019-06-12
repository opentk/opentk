//
// NameContainerWriter.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System.IO;
using System.Threading.Tasks;
using Bind.Generators;

namespace Bind.Writers
{
    /// <summary>
    /// Contains methods to write <see cref="NameContainer"/>s to C# source files.
    /// </summary>
    public static class NameContainerWriter
    {
        /// <summary>
        /// Writes a name container to the given file.
        /// </summary>
        /// <param name="file">The file to write the name container to.</param>
        /// <param name="ns">The namespace of the name container.</param>
        /// <param name="name">The full name of the profile (i.e. OpenGL, OpenGLES).</param>
        /// <param name="val">The name container to write.</param>
        public static void WriteNameContainer(string file, string ns, string name, NameContainer val)
        {
            using (var sw = new StreamWriter(File.Open(file, FileMode.Create, FileAccess.ReadWrite, FileShare.Inheritable)))
            {
                sw.WriteLine("using OpenToolkit.Core.Loader;");
                sw.WriteLine();
                sw.WriteLine("namespace " + ns);
                sw.WriteLine("{");
                sw.WriteLine("    /// <summary>");
                sw.WriteLine($"    /// Contains the library name of {name}.");
                sw.WriteLine("    /// </summary>");
                sw.WriteLine($"    internal class {val.ClassName} : PlatformLibraryNameContainerBase");
                sw.WriteLine("    {");
                sw.WriteLine("        /// <inheritdoc />");
                sw.WriteLine($"        public override string Linux => \"{val.Linux}\";");
                sw.WriteLine();
                sw.WriteLine("        /// <inheritdoc />");
                sw.WriteLine($"        public override string MacOS => \"{val.MacOS}\";");
                sw.WriteLine();
                sw.WriteLine("        /// <inheritdoc />");
                sw.WriteLine($"        public override string Android => \"{val.Android}\";");
                sw.WriteLine();
                sw.WriteLine("        /// <inheritdoc />");
                sw.WriteLine($"        public override string IOS => \"{val.IOS}\";");
                sw.WriteLine();
                sw.WriteLine("        /// <inheritdoc />");
                sw.WriteLine($"        public override string Windows => \"{val.Windows}\";");
                sw.WriteLine("    }");
                sw.WriteLine("}");
            }
        }
    }
}
