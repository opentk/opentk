using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Bind.Generators;
using Bind.Writers.Structure.Projects;

namespace Bind.Writers.Structure
{
    internal class Project
    {
        private IGeneratorSettings _settings;
        private Subsystem _subsystem;
        public const string EnumsSubfolder = "Enums";
        public const string InterfacesSubfolder = "Interfaces";
        public string ExtensionName { get; set; }
        public string CategoryName { get; set; }
        public string ProjectName { get; set; }
        public string Namespace { get; set; }
        public bool IsRoot { get; set; }
        public List<Enum> Enums { get; set; } = new List<Enum>();
        public Dictionary<string, Interface> Interfaces { get; set; } = new Dictionary<string, Interface>();

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

        #region WriteAsync stages

        public async Task WriteProjectFileAsync(string folder)
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

        #endregion
    }
}