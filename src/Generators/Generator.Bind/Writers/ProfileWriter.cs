using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Bind.Generators;
using Bind.Structure;
using Bind.Translation.Translators;
using Bind.XML.Documentation;
using Bind.XML.Signatures;
using Bind.XML.Signatures.Enumerations;

namespace Bind.Writers
{
    /// <summary>
    /// Handles asynchronous writing of bindings to files.
    /// </summary>
    internal partial class ProfileWriter
    {
        /// <summary>
        /// The subfolder in which extensions are contained.
        /// </summary>
        public const string ExtensionsFolder = "Extensions";

        /// <summary>
        /// The subfolder in which interfaces are contained.
        /// </summary>
        public const string InterfacesFolder = "Interfaces";

        /// <summary>
        /// The subfolder in which enumerations are contained.
        /// </summary>
        public const string EnumsFolder = "Enums";

        /// <summary>
        /// Asynchronously writes the given profile to a directory.
        /// </summary>
        /// <param name="rootFolder">The directory to write the profile to.</param>
        /// <param name="rootNamespace">The namespace for the core specification.</param>
        /// <param name="extensionNamespace">The root namespace for extensions.</param>
        /// <param name="functionPrefix">The prefix for native functions.</param>
        /// <param name="subD">The subdirectory in which all projects for this profile are contained.</param>
        /// <param name="className">The name for the core project's mixed mode class.</param>
        /// <param name="fullName">The profile's full name.</param>
        /// <param name="profile">The profile to write.</param>
        /// <param name="docs">The profile's documentation.</param>
        /// <param name="nc">The name container for this profile.</param>
        /// <returns>An asynchronous task.</returns>
        public static Task WriteAsync
        (
            string rootFolder,
            string rootNamespace,
            string extensionNamespace,
            string functionPrefix,
            string subD,
            string className,
            string fullName,
            ApiProfile profile,
            ProfileDocumentation docs,
            NameContainer nc
        )
        {
            if (!Directory.Exists(rootFolder))
            {
                Directory.CreateDirectory(rootFolder);
            }

            if (!Directory.Exists(Path.Combine(rootFolder, rootNamespace)))
            {
                Directory.CreateDirectory(Path.Combine(rootFolder, rootNamespace));
            }

            if (!Directory.Exists(Path.Combine(rootFolder, ExtensionsFolder)))
            {
                Directory.CreateDirectory(Path.Combine(rootFolder, ExtensionsFolder));
            }

            return Task.WhenAll
            (
                GetProjects(profile)
                    .Select
                    (
                        x => WriteProjectAsync
                        (
                            x,
                            rootFolder,
                            rootNamespace,
                            extensionNamespace,
                            functionPrefix,
                            subD,
                            x.Extension == "Core" ? className : NativeIdentifierTranslator.TranslateIdentifierName(x.Extension),
                            fullName,
                            nc,
                            docs
                        )
                    )
            );
        }

        private static async Task WriteProjectAsync
        (
            Project project,
            string folder,
            string rns,
            string ens,
            string prefix,
            string subfolder,
            string className,
            string fullName,
            NameContainer nc,
            ProfileDocumentation doc
        )
        {
            var ns = project.Extension == "Core" ? rns : ens + "." + ConvertExtensionNameToNamespace(project.Extension);
            var dir = project.Extension == "Core"
                ? Path.Combine(folder, ns, className)
                : Path.Combine(folder, ExtensionsFolder, ns);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            if (!Directory.Exists(Path.Combine(dir, InterfacesFolder)))
            {
                Directory.CreateDirectory(Path.Combine(dir, InterfacesFolder));
            }

            if (!Directory.Exists(Path.Combine(dir, EnumsFolder)))
            {
                Directory.CreateDirectory(Path.Combine(dir, EnumsFolder));
            }

            await Task.WhenAll
            (
                project.Interfaces.Select
                    (
                        x => WriteInterfaceAsync
                        (
                            x, Path.Combine(dir, InterfacesFolder, x.InterfaceName + ".cs"), ns, prefix, doc, rns
                        )
                    )
                    .Concat
                    (
                        project.Enums.Select
                        (
                            x => x.WriteEnumAsync
                            (
                                Path.Combine(dir, EnumsFolder, x.Name + ".cs"),
                                ns,
                                prefix.ToUpper() + "_"
                            )
                        )
                    )
            );

            if (project.Extension == "Core")
            {
                await WriteMetaInterfaceAsync
                (
                    ns,
                    Path.Combine(dir, InterfacesFolder, "I" + className + ".cs"),
                    className,
                    project.Interfaces.Select(x => x.InterfaceName)
                );
                await WriteNameContainerAsync(Path.Combine(dir, $"{fullName}LibraryNameContainer.cs"), ns, fullName, nc);
            }
            else
            {
                // we expect the project file to already be created
                await WriteProjectFileAsync(ns, dir, subfolder, rns, project.Extension != "Core");
            }

            await WriteMixedModeClassAsync(project, className, dir, ns, project.Extension != "Core", prefix, className, project.Extension, rns);
        }

        private static async Task WriteMetaInterfaceAsync(string ns, string file, string name, IEnumerable<string> ints)
        {
            var interfaces = ints.ToArray();
            var sw = new StreamWriter(File.Open(file, FileMode.Create, FileAccess.ReadWrite, FileShare.Inheritable));
            await sw.WriteLineAsync("// <auto-generated />");
            await sw.WriteAsync(EmbeddedResources.LicenseText(Path.GetFileName(file)));
            await sw.WriteLineAsync();
            await sw.WriteLineAsync("namespace " + ns);
            await sw.WriteLineAsync("{");
            await sw.WriteAsync("    internal interface I" + name + " : " + interfaces[0]);
            for (var i = 1; i < interfaces.Length; i++)
            {
                await sw.WriteLineAsync(",");
                await sw.WriteAsync("        " + interfaces[i]);
            }

            await sw.WriteLineAsync();
            await sw.WriteLineAsync("    {");
            await sw.WriteLineAsync("    }");
            await sw.WriteLineAsync("}");
            await sw.FlushAsync();
            sw.Close();
        }
    }
}
