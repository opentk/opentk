using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.IO;

namespace OpenTK.Rewrite
{
    /// This is based on the Mono.Cecil BaseAssemblyResolver. But with
    /// additions to GetCorlib but with some extra code to check for -api
    /// directories which we're added by mono in the 4.4 release. Without this
    /// we can end up adding assembly references to mscorlib 4.0 even though
    /// OpenTK is compiled for 2.0.
    internal sealed class OpenTKAssemblyResolver : IAssemblyResolver
    {
        static readonly bool on_mono = Type.GetType("Mono.Runtime") != null;

        readonly List<string> directories;

        List<string> gac_paths;

        public OpenTKAssemblyResolver()
        {
            directories = new List<string>(2) { ".", "bin" };
        }

        AssemblyDefinition GetAssembly(string file, ReaderParameters parameters)
        {
            if (parameters.AssemblyResolver == null)
                parameters.AssemblyResolver = this;

            return ModuleDefinition.ReadModule(file, parameters).Assembly;
        }

        public AssemblyDefinition Resolve(AssemblyNameReference name)
        {
            return Resolve(name, new ReaderParameters());
        }

        public AssemblyDefinition Resolve(AssemblyNameReference name, ReaderParameters parameters)
        {
            var assembly = SearchDirectory(name, directories, parameters);
            if (assembly != null)
                return assembly;

            if (name.IsRetargetable)
            {
                // if the reference is retargetable, zero it
                name = new AssemblyNameReference(name.Name, new Version(0, 0, 0, 0))
                {
                    PublicKeyToken = new byte[0],
                };
            }

            var framework_dir = Path.GetDirectoryName(typeof(object).Module.FullyQualifiedName);
            var framework_dirs = on_mono
                ? new[] { framework_dir, Path.Combine(framework_dir, "Facades") }
                : new[] { framework_dir };

            if (IsZero(name.Version))
            {
                assembly = SearchDirectory(name, framework_dirs, parameters);
                if (assembly != null)
                    return assembly;
            }

            if (name.Name == "mscorlib")
            {
                assembly = GetCorlib(name, parameters);
                if (assembly != null)
                    return assembly;
            }

            assembly = GetAssemblyInGac(name, parameters);
            if (assembly != null)
                return assembly;

            assembly = SearchDirectory(name, framework_dirs, parameters);
            if (assembly != null)
                return assembly;

            throw new AssemblyResolutionException(name);
        }

        AssemblyDefinition SearchDirectory(AssemblyNameReference name, IEnumerable<string> directories, ReaderParameters parameters)
        {
            var extensions = name.IsWindowsRuntime ? new[] { ".winmd", ".dll" } : new[] { ".exe", ".dll" };
            foreach (var directory in directories)
            {
                foreach (var extension in extensions)
                {
                    string file = Path.Combine(directory, name.Name + extension);
                    if (!File.Exists(file))
                        continue;
                    try
                    {
                        var assembly = GetAssembly(file, parameters);
                        if (assembly.Name.Version == name.Version || IsZero(name.Version))
                        {
                            return assembly;
                        }
                    }
                    catch (System.BadImageFormatException)
                    {
                        continue;
                    }
                }
            }

            return null;
        }

        static bool IsZero(Version version)
        {
            return version.Major == 0 && version.Minor == 0 && version.Build == 0 && version.Revision == 0;
        }

        AssemblyDefinition GetCorlib(AssemblyNameReference reference, ReaderParameters parameters)
        {
            var version = reference.Version;
            var corlib = typeof(object).Assembly.GetName();

            if (corlib.Version == version || IsZero(version))
                return GetAssembly(typeof(object).Module.FullyQualifiedName, parameters);

            var path = Directory.GetParent(
                Directory.GetParent(
                    typeof(object).Module.FullyQualifiedName).FullName
                ).FullName;

            if (on_mono)
            {
                if (version.Major == 1)
                    path = Path.Combine(path, "1.0");
                else if (version.Major == 2)
                {
                    if (version.MajorRevision == 5)
                        path = Path.Combine(path, "2.1");
                    else
                        path = Path.Combine(path, "2.0");
                }
                else if (version.Major == 4)
                    path = Path.Combine(path, "4.0");
                else
                    throw new NotSupportedException("Version not supported: " + version);
            }
            else
            {
                switch (version.Major)
                {
                    case 1:
                        if (version.MajorRevision == 3300)
                            path = Path.Combine(path, "v1.0.3705");
                        else
                            path = Path.Combine(path, "v1.0.5000.0");
                        break;
                    case 2:
                        path = Path.Combine(path, "v2.0.50727");
                        break;
                    case 4:
                        path = Path.Combine(path, "v4.0.30319");
                        break;
                    default:
                        throw new NotSupportedException("Version not supported: " + version);
                }
            }

            var file = Path.Combine(path, "mscorlib.dll");
            if (File.Exists(file))
                return GetAssembly(file, parameters);
            else if (on_mono && Directory.Exists(path + "-api"))
            {
                path = path + "-api";
                file = Path.Combine(path, "mscorlib.dll");
                if (File.Exists(file))
                    return GetAssembly(file, parameters);
            }

            return null;
        }

        static List<string> GetGacPaths()
        {
            if (on_mono)
                return GetDefaultMonoGacPaths();

            var paths = new List<string>(2);
            var windir = Environment.GetEnvironmentVariable("WINDIR");
            if (windir == null)
                return paths;

            paths.Add(Path.Combine(windir, "assembly"));
            paths.Add(Path.Combine(windir, Path.Combine("Microsoft.NET", "assembly")));
            return paths;
        }

        static List<string> GetDefaultMonoGacPaths()
        {
            var paths = new List<string>(1);
            var gac = GetCurrentMonoGac();
            if (gac != null)
                paths.Add(gac);

            var gac_paths_env = Environment.GetEnvironmentVariable("MONO_GAC_PREFIX");
            if (string.IsNullOrEmpty(gac_paths_env))
                return paths;

            var prefixes = gac_paths_env.Split(Path.PathSeparator);
            foreach (var prefix in prefixes)
            {
                if (string.IsNullOrEmpty(prefix))
                    continue;

                var gac_path = Path.Combine(Path.Combine(Path.Combine(prefix, "lib"), "mono"), "gac");
                if (Directory.Exists(gac_path) && !paths.Contains(gac))
                    paths.Add(gac_path);
            }

            return paths;
        }

        static string GetCurrentMonoGac()
        {
            return Path.Combine(
                Directory.GetParent(
                    Path.GetDirectoryName(typeof(object).Module.FullyQualifiedName)).FullName,
                "gac");
        }

        AssemblyDefinition GetAssemblyInGac(AssemblyNameReference reference, ReaderParameters parameters)
        {
            if (reference.PublicKeyToken == null || reference.PublicKeyToken.Length == 0)
                return null;

            if (gac_paths == null)
                gac_paths = GetGacPaths();

            if (on_mono)
                return GetAssemblyInMonoGac(reference, parameters);

            return GetAssemblyInNetGac(reference, parameters);
        }

        AssemblyDefinition GetAssemblyInMonoGac(AssemblyNameReference reference, ReaderParameters parameters)
        {
            for (int i = 0; i < gac_paths.Count; i++)
            {
                var gac_path = gac_paths[i];
                var file = GetAssemblyFile(reference, string.Empty, gac_path);
                if (File.Exists(file))
                {
                    var assembly = GetAssembly(file, parameters);
                    if (assembly.Name.Version == reference.Version || IsZero(reference.Version))
                    {
                        return assembly;
                    }
                }
            }

            return null;
        }

        AssemblyDefinition GetAssemblyInNetGac(AssemblyNameReference reference, ReaderParameters parameters)
        {
            var gacs = new[] { "GAC_MSIL", "GAC_32", "GAC_64", "GAC" };
            var prefixes = new[] { string.Empty, "v4.0_" };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < gacs.Length; j++)
                {
                    var gac = Path.Combine(gac_paths[i], gacs[j]);
                    var file = GetAssemblyFile(reference, prefixes[i], gac);
                    if (Directory.Exists(gac) && File.Exists(file))
                    {
                        var assembly = GetAssembly(file, parameters);
                        if (assembly.Name.Version == reference.Version || IsZero(reference.Version))
                        {
                            return assembly;
                        }
                    }
                }
            }

            return null;
        }

        static string GetAssemblyFile(AssemblyNameReference reference, string prefix, string gac)
        {
            var gac_folder = new System.Text.StringBuilder()
                .Append(prefix)
                .Append(reference.Version)
                .Append("__");

            for (int i = 0; i < reference.PublicKeyToken.Length; i++)
                gac_folder.Append(reference.PublicKeyToken[i].ToString("x2"));

            return Path.Combine(
                Path.Combine(
                    Path.Combine(gac, reference.Name), gac_folder.ToString()),
                reference.Name + ".dll");
        }

        void IDisposable.Dispose() { }
    }
}
