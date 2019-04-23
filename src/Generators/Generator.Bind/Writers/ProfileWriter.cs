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
using Bind.XML.Signatures.Functions;

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
        /// <param name="c">The name for the core project's mixed mode class.</param>
        /// <param name="profile">The profile to write.</param>
        /// <param name="docs">The profile's documentation.</param>
        /// <returns>An asynchronous task.</returns>
        public static Task WriteAsync
        (
            string rootFolder,
            string rootNamespace,
            string extensionNamespace,
            string functionPrefix,
            string subD,
            string c,
            ApiProfile profile,
            ProfileDocumentation docs
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
                            x.Extension == "Core" ? c : NativeIdentifierTranslator.TranslateIdentifierName(x.Extension),
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
                            x, Path.Combine(dir, InterfacesFolder, x.InterfaceName + ".cs"), ns, prefix, doc
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
            }
            else
            {
                // we expect the project file to already be created
                await WriteProjectFileAsync(ns, dir, subfolder, rns, project.Extension != "Core");
            }

            await WriteMixedModeClassAsync(project, className, dir, ns, project.Extension != "Core");
        }

        private static async Task WriteMetaInterfaceAsync(string ns, string file, string name, IEnumerable<string> ints)
        {
            var interfaces = ints.ToArray();
            var sw = new StreamWriter(file);
            await sw.WriteAsync(EmbeddedResources.LicenseText);
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

        private static async Task WriteMixedModeClassAsync
        (
            string file,
            string ns,
            string nm,
            bool ext,
            IEnumerable<(string, IEnumerable<FunctionSignature>)> @interface,
            NameContainer names
        )
        {
            // public abstract class MixedModeClass : IMixedModeClass
            // {
            // }
            var sw = new StreamWriter(file);
            await sw.WriteAsync(EmbeddedResources.LicenseText);
            await sw.WriteLineAsync("using System;");
            await sw.WriteLineAsync("using System.Runtime.InteropServices;");
            await sw.WriteLineAsync("using System.Text;");
            await sw.WriteLineAsync("using OpenToolkit.Core;");
            await sw.WriteLineAsync("using AdvancedDLSupport;");
            await sw.WriteLineAsync();
            await sw.WriteLineAsync("namespace " + ns);
            await sw.WriteLineAsync("{");
            var @base = !ext ? "NativeLibraryBase" : "ExtensionBase";
            await sw.WriteLineAsync("    public abstract class " + nm + " : " + @base + ", I" + nm);
            await sw.WriteLineAsync("    {");
            await sw.WriteLineAsync("        /// <inheritdoc cref=\"" + @base + "\"/>");
            await sw.WriteLineAsync("        protected " + nm + "(string path, ImplementationOptions options)");
            await sw.WriteLineAsync("            : base(path, options)");
            await sw.WriteLineAsync("        {");
            await sw.WriteLineAsync("        }");
            if (!ext)
            {
                await sw.WriteLineAsync();
                await sw.WriteLineAsync
                (
                    "        public IPlatformLibraryNameContainer NameContainer { get; } = new " +
                    names.ClassName + "();"
                );
            }

            foreach (var kvp in @interface)
            {
                await sw.WriteLineAsync();
                await sw.WriteLineAsync("        // " + kvp.Item1);
                foreach (var function in kvp.Item2)
                {
                    await sw.WriteLineAsync();
                    var lines = GetDeclarationString(function).Split('\n');
                    await sw.WriteLineAsync("        /// <inheritdoc />");
                    await sw.WriteLineAsync("        public abstract " + lines[0]);
                    for (var i = 1; i < lines.Length; i++)
                    {
                        await sw.WriteLineAsync("        " + lines[i]);
                    }
                }
            }

            //if (project.IsRoot) TODO
            //{
            //    await sw.WriteLineAsync();
            //    await sw.WriteLineAsync("    public static "+nm+" GetApi()");
            //    await sw.WriteLineAsync("    {");
            //}

            await sw.FlushAsync();
        }
    }
}
