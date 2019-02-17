using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Generator.Common;
using Generator.Common.Enums;
using Enum = Generator.Common.Enums.Enum;

namespace Generator.Bind
{
    /// <summary>
    /// Contains methods for writing profiles to disk.
    /// </summary>
    public static class ProfileWriter
    {
        /// <summary>
        /// The name of the subfolder containing <see cref="Enum"/>s.
        /// </summary>
        public const string EnumsSubfolder = "Enums";

        /// <summary>
        /// The name of the subfolder containing <see cref="Interface"/>s.
        /// </summary>
        public const string InterfacesSubfolder = "Interfaces";

        /// <summary>
        /// Asynchronously writes this enum to a file.
        /// </summary>
        /// <param name="enum">The enum to write.</param>
        /// <param name="file">The file to write to.</param>
        /// <param name="profile">The subsystem containing this enum.</param>
        /// <param name="project">The project containing this enum.</param>
        /// <returns>The asynchronous task.</returns>
        public static async Task WriteEnumAsync(this Enum @enum, string file, Profile profile, Project project)
        {
            var sw = new StreamWriter(file);
            await sw.WriteLineAsync(EmbeddedResources.LicenseText);
            await sw.WriteLineAsync();
            await sw.WriteLineAsync("using System;");
            await sw.WriteLineAsync();
            await sw.WriteLineAsync("namespace " + project.Namespace);
            await sw.WriteLineAsync("{");
            foreach (var attr in @enum.Attributes)
            {
                await sw.WriteLineAsync("    " + attr);
            }

            await sw.WriteLineAsync("    public enum " + @enum.Name);
            await sw.WriteLineAsync("    {");
            for (var index = 0; index < @enum.Tokens.Count; index++)
            {
                var token = @enum.Tokens[index];

                await sw.WriteLineAsync
                (
                    "        " + token.Name + " = " + token.Value +
                    (index != @enum.Tokens.Count ? "," : string.Empty)
                );
            }

            await sw.WriteLineAsync("    }");
            await sw.WriteLineAsync("}");
            await sw.FlushAsync();
            sw.Dispose();
        }

        /// <summary>
        /// Asynchronously writes this interface to a file.
        /// </summary>
        /// <param name="interface">The interface.</param>
        /// <param name="file">The file to write to.</param>
        /// <param name="profile">The subsystem containing this interface.</param>
        /// <param name="project">The project containing this interface.</param>
        /// <returns>The asynchronous task.</returns>
        public static async Task WriteInterfaceAsync(this Interface @interface, string file, Profile profile, Project project)
        {
            var sw = new StreamWriter(file);
            await sw.WriteAsync(EmbeddedResources.LicenseText);
            await sw.WriteLineAsync("using System;");
            await sw.WriteLineAsync("using System.Runtime.InteropServices;");
            await sw.WriteLineAsync("using System.Text;");
            await sw.WriteLineAsync("using AdvancedDLSupport;");
            await sw.WriteLineAsync();
            var ns = project.IsRoot ? profile.Namespace : profile.ExtensionsNamespace;
            await sw.WriteLineAsync("namespace " + ns + project.Namespace);
            await sw.WriteLineAsync("{");
            foreach (var attr in @interface.Attributes)
            {
                await sw.WriteLineAsync("    " + attr);
            }

            await sw.WriteLineAsync("    internal interface " + @interface.Name);
            await sw.WriteAsync("    {");
            for (var index = 0; index < @interface.Functions.Count; index++)
            {
                await sw.WriteLineAsync();
                var function = @interface.Functions[index];
                using (var sr = new StringReader(function.Doc))
                {
                    string line;
                    while ((line = await sr.ReadLineAsync()) != null)
                    {
                        await sw.WriteLineAsync("        " + line);
                    }
                }

                foreach (var attr in function.Attributes)
                {
                    await sw.WriteLineAsync("        " + attr);
                }

                await sw.WriteLineAsync
                (
                    "        [NativeSymbol(\"" + profile.FunctionPrefix + function.NativeName + "\")]"
                );
                await sw.WriteLineAsync("        " + function);
            }

            await sw.WriteLineAsync("    }");
            await sw.WriteLineAsync("}");
            await sw.FlushAsync();
            sw.Dispose();
        }

        public static async Task WriteMixedModeClassAsync(this Project project, Profile profile, string file)
        {
            // public abstract class MixedModeClass : IMixedModeClass
            // {
            // }
            var sw = new StreamWriter(file);
            await sw.WriteAsync(EmbeddedResources.LicenseText);
            await sw.WriteLineAsync("using System;");
            await sw.WriteLineAsync("using System.Runtime.InteropServices;");
            await sw.WriteLineAsync("using System.Text;");
            await sw.WriteLineAsync("using AdvancedDLSupport;");
            await sw.WriteLineAsync();
            var ns = project.IsRoot ? profile.Namespace : profile.ExtensionsNamespace;
            await sw.WriteLineAsync("namespace " + ns + project.Namespace);
            await sw.WriteLineAsync("{");
            var nm = project.IsRoot ? profile.FunctionPrefix.ToUpper() : project.Namespace.Split('.').Last();
            var @base = project.IsRoot ? "NativeLibraryBase" : "ExtensionBase";
            await sw.WriteLineAsync("    public abstract class " + nm + " : " + @base + ", I" + nm);
            await sw.WriteLineAsync("    {");
            await sw.WriteLineAsync("        /// <inheritdoc cref=\"" + @base + "\"/>");
            await sw.WriteLineAsync("        protected " + nm + "(string path, ImplementationOptions options)");
            await sw.WriteLineAsync("            : base(path, options)");
            await sw.WriteLineAsync("        {");
            await sw.WriteLineAsync("        }");
            await sw.WriteLineAsync();
            if (project.IsRoot)
            {
                await sw.WriteLineAsync
                (
                    "        public IPlatformLibraryNameContainer NameContainer { get; } = new " +
                    profile.Names.ClassName + "();"
                );
                await sw.WriteLineAsync();
            }
            foreach (var kvp in project.Interfaces)
            {
                await sw.WriteLineAsync("        // " + kvp.Key);
                foreach (var function in kvp.Value.Functions)
                {
                    await sw.WriteLineAsync("        //// <inheritdoc />");
                    await sw.WriteLineAsync("        public abstract " + function);
                    await sw.WriteLineAsync();
                }
            }
        }

        /// <summary>
        /// Asynchronously writes this project in the given folder, with the given settings and parent subsystem.
        /// </summary>
        /// <param name="project">The project to write.</param>
        /// <param name="folder">The folder to write this project to.</param>
        /// <param name="profile">The parent subsystem.</param>
        /// <returns>The asynchronous task.</returns>
        public static async Task WriteAsync(this Project project, string folder, Profile profile)
        {
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            if (!Directory.Exists(Path.Combine(folder, EnumsSubfolder)))
            {
                Directory.CreateDirectory(Path.Combine(folder, EnumsSubfolder));
            }

            if (!Directory.Exists(Path.Combine(folder, InterfacesSubfolder)))
            {
                Directory.CreateDirectory(Path.Combine(folder, InterfacesSubfolder));
            }

            await project.WriteProjectFileAsync(folder, profile);

            var interfaceTasks = project.Interfaces.Select
            (
                x => x.Value.WriteInterfaceAsync(Path.Combine(folder, InterfacesSubfolder, x.Value.Name + ".cs"), profile, project)
            );
            var enumTasks = project.Enums.Select
            (
                x => x.WriteEnumAsync(Path.Combine(folder, EnumsSubfolder, x.Name + ".cs"), profile, project)
            );
            await Task.WhenAll(interfaceTasks.Concat(enumTasks));
        }

        /// <summary>
        /// Asynchronously writes the project file to the given folder.
        /// </summary>
        /// <param name="project">The project to write.</param>
        /// <param name="folder">The folder that should contain the project file.</param>
        /// <param name="prof">The parent profile.</param>
        /// <returns>The asynchronous task.</returns>
        private static async Task WriteProjectFileAsync(this Project project, string folder, Profile prof)
        {
            if (File.Exists(Path.Combine(folder, project.GetProjectName(prof) + ".csproj")))
            {
                return;
            }

            Debug.WriteLine(folder + "/" + project.GetProjectName(prof) + ".csproj");
            var csproj = new StreamWriter(Path.Combine(folder, project.GetProjectName(prof) + ".csproj"));
            await csproj.WriteLineAsync("<Project Sdk=\"Microsoft.NET.Sdk\">");
            await csproj.WriteLineAsync();
            await csproj.WriteLineAsync("  <PropertyGroup>");
            await csproj.WriteLineAsync("    <TargetFramework>netstandard2.0</TargetFramework>");
            await csproj.WriteLineAsync("    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>");
            await csproj.WriteLineAsync("    <LangVersion>latest</LangVersion>");
            await csproj.WriteLineAsync("    <RootNamespace>" + project.GetNamespace(prof) + "</RootNamespace>");
            await csproj.WriteLineAsync("    <AssemblyName>" + project.GetNamespace(prof) + "</AssemblyName>");
            await csproj.WriteLineAsync("  </PropertyGroup>");
            await csproj.WriteLineAsync();
            await csproj.WriteLineAsync("  <ItemGroup>");
            if (!project.IsRoot)
            {
                await csproj.WriteLineAsync
                (
                    "    <ProjectReference Include=\"$(OpenTKSolutionRoot)\\src\\" +
                    prof.OutputFolder + "\\" + prof.Projects["Core"].GetProjectName(prof)
                    + "\\" + prof.Projects["Core"].GetProjectName(prof) + ".csproj\" />"
                );
            }
            else
            {
                await csproj.WriteLineAsync
                (
                    "    <ProjectReference Include=\"$(OpenTKSolutionRoot)\\src\\OpenTK.Core\\OpenTK.Core.csproj\" />"
                );
            }

            await csproj.WriteLineAsync("  </ItemGroup>");
            await csproj.WriteLineAsync();
            if (!project.IsRoot)
            {
                await csproj.WriteLineAsync("  <Import Project=\"..\\..\\..\\..\\props\\common.props\" />");
            }
            else
            {
                await csproj.WriteLineAsync("  <Import Project=\"..\\..\\..\\props\\common.props\" />");
            }

            await csproj.WriteLineAsync("  <Import Project=\"$(OpenTKSolutionRoot)\\props\\nuget-common.props\" />");
            await csproj.WriteLineAsync("  <Import Project=\"$(OpenTKSolutionRoot)\\props\\stylecop.props\" />");
            await csproj.WriteLineAsync("</Project>");
            await csproj.FlushAsync();
            csproj.Dispose();
        }

        /// <summary>
        /// Asynchronously writes all of the projects, interfaces, and enums to disk.
        /// </summary>
        /// <param name="profile">The profile containing the profiles, interfaces, and enums.</param>
        /// <returns>The asynchronous task.</returns>
        public static async Task FlushAsync(this Profile profile)
        {
            var outFolder = profile.OutputFolder;
            var rootFolder = Path.Combine(Program.CliOptions.OutputPath, outFolder);
            if (!Directory.Exists(rootFolder))
            {
                Directory.CreateDirectory(rootFolder);
            }

            if (!Directory.Exists(Path.Combine(rootFolder, "Extensions")))
            {
                Directory.CreateDirectory(Path.Combine(rootFolder, "Extensions"));
            }

            var projectTasks = profile.Projects.Select
            (
                x =>
                    x.Value.WriteAsync
                    (
                        x.Key == "Core"
                            ? Path.Combine(rootFolder, x.Value.GetProjectName(profile))
                            : Path.Combine(rootFolder, "Extensions", x.Value.GetProjectName(profile)),
                        profile
                    )
            );
            await Task.WhenAll(projectTasks);
        }
    }
}