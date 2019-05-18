using System.IO;
using System.Threading.Tasks;

namespace Bind.Writers
{
    /// <summary>
    /// Contains methods to write MSBuild project files for projects in a profile.
    /// </summary>
    public static class ProjectFileWriter
    {
        /// <summary>
        /// Writes an MSBuild project file with the given namespace, directories, and base project.
        /// </summary>
        /// <param name="ns">The namespace of this project.</param>
        /// <param name="dir">The directory in which the project file should be contained.</param>
        /// <param name="subDir">The subdirectory of the "src" folder to which the current profile is contained.</param>
        /// <param name="coreProj">The subdirectory of subDir containing the project for the core specification.</param>
        /// <param name="ext">Whether or not this project file is for an extension or not.</param>
        /// <returns>An asynchronous task.</returns>
        public static async Task WriteProjectFileAsync(string ns, string dir, string subDir, string coreProj, bool ext)
        {
            if (File.Exists(Path.Combine(dir, ns + ".csproj")))
            {
                return;
            }

            using (var csproj = new StreamWriter(Path.Combine(dir, ns + ".csproj")))
            {
                csproj.WriteLine("<Project Sdk=\"Microsoft.NET.Sdk\">");
                csproj.WriteLine();
                csproj.WriteLine("  <PropertyGroup>");
                csproj.WriteLine("    <TargetFramework>netstandard2.0</TargetFramework>");
                csproj.WriteLine("    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>");
                csproj.WriteLine("    <LangVersion>latest</LangVersion>");
                csproj.WriteLine("    <RootNamespace>" + ns + "</RootNamespace>");
                csproj.WriteLine("    <AssemblyName>" + ns + "</AssemblyName>");
                csproj.WriteLine("  </PropertyGroup>");
                csproj.WriteLine();
                csproj.WriteLine("  <ItemGroup>");
                if (ext)
                {
                    csproj.WriteLine
                    (
                        "    <ProjectReference Include=\"$(OpenTKSolutionRoot)\\src\\" +
                        subDir + "\\" + coreProj
                        + "\\" + coreProj + ".csproj\" />"
                    );
                }
                else
                {
                    csproj.WriteLine
                    (
                        "    <ProjectReference Include=\"$(OpenTKSolutionRoot)\\src\\OpenTK.Core\\OpenTK.Core.csproj\" />"
                    );
                }

                csproj.WriteLine("  </ItemGroup>");
                csproj.WriteLine();
                if (ext)
                {
                    csproj.WriteLine("  <Import Project=\"..\\..\\..\\..\\props\\common.props\" />");
                }
                else
                {
                    csproj.WriteLine("  <Import Project=\"..\\..\\..\\props\\common.props\" />");
                }

                csproj.WriteLine("  <Import Project=\"$(OpenTKSolutionRoot)\\props\\nuget-common.props\" />");
                csproj.WriteLine("  <Import Project=\"$(OpenTKSolutionRoot)\\props\\stylecop.props\" />");
                csproj.WriteLine("</Project>");
                await csproj.FlushAsync();
            }
        }
    }
}
