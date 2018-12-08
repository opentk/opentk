using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Bind.Generators;
using Bind.Writers.Structure.Projects;

namespace Bind.Writers.Structure
{
    /// <summary>
    /// Represents a project, whether root or extension, containing <see cref="Interface"/>s and <see cref="Enum"/>s.
    /// </summary>
    internal class Project
    {
        /// <summary>
        /// The name of the subfolder containing <see cref="Enum"/>s.
        /// </summary>
        public const string EnumsSubfolder = "Enums";

        /// <summary>
        /// The name of the subfolder containing <see cref="Interface"/>s.
        /// </summary>
        public const string InterfacesSubfolder = "Interfaces";

        private IGeneratorSettings _settings;
        private Subsystem _subsystem;

        /// <summary>
        /// Gets or sets the name of the extension this project is categorised under.
        /// </summary>
        public string ExtensionName { get; set; }

        /// <summary>
        /// Gets or sets the category name of this project.
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// Gets or sets the name of this project. Note that this is not the assembly name.
        /// </summary>
        public string ProjectName { get; set; }

        /// <summary>
        /// Gets or sets the root namespace of this project. This is also used as the assembly name.
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this project is the root project, or an extension.
        /// </summary>
        public bool IsRoot { get; set; }

        /// <summary>
        /// Gets or sets a list of <see cref="Enum"/>s contained within this <see cref="Project"/>.
        /// </summary>
        public List<Enum> Enums { get; set; } = new List<Enum>();

        /// <summary>
        /// Gets or sets a dictionary where the category names are the keys, and <see cref="Interface"/>s
        /// are the values.
        /// </summary>
        public Dictionary<string, Interface> Interfaces { get; set; } = new Dictionary<string, Interface>();

        /// <summary>
        /// Asynchronously writes this project in the given folder, with the given settings and parent subsystem.
        /// </summary>
        /// <param name="folder">The folder to write this project to.</param>
        /// <param name="settings">The generator settings to use.</param>
        /// <param name="subsystem">The parent subsystem.</param>
        /// <returns>The asynchronous task.</returns>
        public async Task WriteAsync(string folder, IGeneratorSettings settings, Subsystem subsystem)
        {
            _settings = settings;
            _subsystem = subsystem;
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
            await WriteProjectFileAsync(folder);

            var interfaceTasks = Interfaces.Select
            (
                x => x.Value.WriteAsync(Path.Combine(folder, InterfacesSubfolder, x.Value.Name + ".cs"), subsystem, this)
            );
            var enumTasks = Enums.Select
            (
                x => x.WriteAsync(Path.Combine(folder, EnumsSubfolder, x.Name + ".cs"), subsystem, this)
            );
            await Task.WhenAll(interfaceTasks.Concat(enumTasks));
        }

        /// <summary>
        /// Asynchronously writes the project file to the given folder.
        /// </summary>
        /// <param name="folder">The folder that should contain the project file.</param>
        /// <returns>The asynchronous task.</returns>
        private async Task WriteProjectFileAsync(string folder)
        {
            if (File.Exists(Path.Combine(folder, ProjectName + ".csproj")))
            {
                return;
            }
            var csproj = new StreamWriter(Path.Combine(folder, ProjectName + ".csproj"));
            await csproj.WriteLineAsync("<Project Sdk=\"Microsoft.NET.Sdk\"");
            await csproj.WriteLineAsync();
            await csproj.WriteLineAsync("  <PropertyGroup>");
            await csproj.WriteLineAsync("    <TargetFramework>netstandard2.0</TargetFramework>");
            await csproj.WriteLineAsync("    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>");
            await csproj.WriteLineAsync("    <LangVersion>latest</LangVersion>");
            await csproj.WriteLineAsync("    <RootNamespace>" + Namespace + "</AllowUnsafeBlocks>");
            await csproj.WriteLineAsync("    <AssemblyName>" + Namespace + "</AssemblyName>");
            await csproj.WriteLineAsync("  </PropertyGroup>");
            await csproj.WriteLineAsync();
            await csproj.WriteLineAsync("  <ItemGroup>");
            if (!IsRoot)
            {
                await csproj.WriteLineAsync("    <ProjectReference Include=\"$(OpenTKSolutionRoot)\\src\\" +
                                 _settings.OutputFolder + "\\" + _subsystem.Projects["Core"].ProjectName + "\\" +
                                 _subsystem.Projects["Core"].ProjectName + ".csproj\" />");
            }
            else
            {
                await csproj.WriteLineAsync("    <ProjectReference Include=\"$(OpenTKSolutionRoot)\\src\\OpenTK.Core\\OpenTK.Core.csproj\" />");
            }

            await csproj.WriteLineAsync("  </ItemGroup>");
            await csproj.WriteLineAsync();
            if (!IsRoot)
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
    }
}
