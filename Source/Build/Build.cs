#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

#region --- Using Directives ---

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Reflection;
using OpenTK.Build.Properties;

#endregion

namespace OpenTK.Build
{
    class Project
    {
        static readonly string RootPath = Directory.GetCurrentDirectory();
        static readonly string SourcePath = Path.Combine(RootPath, "Source");
        static readonly string DocPath = Path.Combine(RootPath, "Documentation");

        const string bindings = "Generator.Prebuild.xml";
        const string opentk = "OpenTK.Prebuild.xml";
        const string quickstart = "QuickStart.Prebuild.xml";
        const string DoxyFile = "Doxyfile";
        const string ReferenceFile = "Reference.pdf";

        const string KeyFile = "OpenTK.snk"; // Do not change

        const string Usage =  @"Usage: Build.exe target
    target: one of vs, vs9, doc, clean, distclean, help";

        const string Help = Usage + @"

Available targets:
    vs:        Create Visual Studio 2005 project files.
    vs9:       Create Visual Studio 2008 project files.
    doc:       Builds html and pdf documentation.
    clean:     Delete intermediate files but leave final binaries and project
               files intact.
    distclean: Delete intermediate files, final binaries and project files.
    help:      Display this help.

Assembly signing:
    To create strongly-named assemblies, place a keypair file named OpenTK.snk
    to the root folder (the same folder as Build.exe). If OpenTK.snk does not
    exist the resulting assemblies will not be signed.
";

        static readonly Assembly Prebuild = Assembly.Load(Resources.Prebuild);

        enum BuildTarget
        {
            None = 0,
            VS2005,
            VS2008,
            Mono,
            Net,
            Clean,
            DistClean,
            Docs,
        }

        static void PrintUsage()
        {
            Console.WriteLine(Usage);
        }

        static void PrintHelp()
        {
            Console.WriteLine(Help);
        }

        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                PrintUsage();

                args = new string[2] { String.Empty, String.Empty };
                Console.Write("Select build target: ");
                args[0] = Console.ReadLine();
                if (args[0] == String.Empty)
                    args[0] = "vs";
            }

            try
            {
                PrepareBuildFiles();
                PrepareEnvironment();

                BuildTarget target = SelectTarget(args);
                if (target != BuildTarget.None)
                {
                    Build(target);
                    foreach (string file in Directory.GetFiles("Source", "*.csproj", SearchOption.AllDirectories))
                        ApplyMonoDevelopWorkarounds(file);
                }
            }
            finally
            {
                // Wait until Prebuild releases the input files.
                System.Threading.Thread.Sleep(2000);
                DeleteBuildFiles();
            }

            WaitForExit();
        }

        private static void PrepareEnvironment()
        {
            // Workaroung for nant on x64 windows (safe for other platforms too, as this affects only the current process).
            Environment.SetEnvironmentVariable("CommonProgramFiles(x86)", String.Empty, EnvironmentVariableTarget.Process);
            Environment.SetEnvironmentVariable("ProgramFiles(x86)", String.Empty, EnvironmentVariableTarget.Process);
        }

        private static void PrepareBuildFiles()
        {
            //string sign_assembly = CheckKeyFile(keyfile) ? "SIGN_ASSEMBLY" : "";
            string sign_assembly = CheckKeyFile(KeyFile) ? @"<KeyFile>" + KeyFile + @"</KeyFile>" : "";
            if (sign_assembly != "")
                DistributeKeyFile(KeyFile);

            File.WriteAllText(bindings, String.Format(Resources.Generator, sign_assembly));
            File.WriteAllText(opentk, String.Format(Resources.OpenTK, sign_assembly));
            File.WriteAllText(quickstart, String.Format(Resources.QuickStart, sign_assembly));
            
            string doxy = Regex.Replace(Resources.DoxyFile, @"(\{\}|\{\w+\})", "");
            File.WriteAllText(DoxyFile, String.Format(doxy, GetVersion()));
        }

        // Returns the version of the executing assembly.
        static string GetVersion()
        {
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            return version;
        }

        // Copies keyfile to the various source directories. This is necessary
        // as Visual Studio won't pick up the file otherwise.
        static void DistributeKeyFile(string keyfile)
        {
            foreach (string dir in Directory.GetDirectories("Source"))
            {
                File.Copy(keyfile, Path.Combine(dir, keyfile), true);
            }
        }

        static BuildTarget SelectTarget(string[] args)
        {
            BuildTarget target = BuildTarget.None;

            foreach (string s in args)
            {
                string arg = s.ToLower().Trim();
                switch (arg)
                {
                    case "":
                        break;

                    case "help":
                        PrintHelp();
                        break;

                    case "mono":
                    case "xbuild":
                        target = BuildTarget.Mono;
                        break;

                    case "net":
                    case "msbuild":
                        target = BuildTarget.Net;
                        break;

                    case "vs2005":
                    case "vs8":
                    case "vs":
                        target = BuildTarget.VS2005;
                        break;

                    case "vs2008":
                    case "vs9":
                        target = BuildTarget.VS2008;
                        break;

                    case "doc":
                    case "docs":
                        target = BuildTarget.Docs;
                        break;

                    case "clean":
                        target = BuildTarget.Clean;
                        break;

                    case "distclean":
                        target = BuildTarget.DistClean;
                        break;

                    default:
                        Console.WriteLine("Unknown command: {0}", s);
                        PrintUsage();
                        break;
                }
            }

            return target;
        }

        static void Build(BuildTarget target)
        {
            switch (target)
            {
                //case BuildTarget.Mono:
                //    Console.WriteLine("Building OpenTK using Mono/XBuild.");
                //    ExecuteProcess(PrebuildPath, "/target nant /file " + PrebuildXml);
                //    Console.WriteLine();
                //    ExecuteProcess(
                //        "nant",
                //        "-buildfile:./Build/OpenTK.build -t:mono-2.0 " + (mode == BuildMode.Debug ? "build-debug" : "build-release"));
                //    CopyBinaries();
                //    break;

                //case BuildTarget.Net:
                //    Console.WriteLine("Building OpenTK using .Net");
                //    ExecuteProcess(PrebuildPath, "/target nant /file " + PrebuildXml);
                //    Console.WriteLine();
                //    ExecuteProcess(
                //        "nant",
                //        "-buildfile:./Build/OpenTK.build -t:net-2.0 " + (mode == BuildMode.Debug ? "build-debug" : "build-release"));
                //    CopyBinaries();
                //    break;

                case BuildTarget.VS2005:
                    Console.WriteLine("Creating VS2005 project files");
                    ExecutePrebuild("/target", "vs2008", "/file", bindings);
                    ExecutePrebuild("/target", "vs2005", "/file", opentk);
                    ExecutePrebuild("/target", "vs2005", "/file", quickstart);
                    break;

                case BuildTarget.VS2008:
                    Console.WriteLine("Creating VS2008 project files");
                    ExecutePrebuild("/target", "vs2008", "/file", bindings);
                    ExecutePrebuild("/target", "vs2008", "/file", opentk);
                    ExecutePrebuild("/target", "vs2008", "/file", quickstart);
                    break;

                case BuildTarget.Docs:
                    Console.WriteLine("Generating reference documentation (this may take several minutes)...");
                    Console.WriteLine("Generating html sources...");
                    try { ExecuteCommand("doxygen", null, null); }
                    catch
                    {
                        Console.WriteLine("Failed to run \"doxygen\".");
                        Console.WriteLine("Please consult the documentation for more information.");
                    }

                    string latex_path = Path.Combine(Path.Combine(DocPath, "Source"), "latex");
                    Console.WriteLine("Compiling sources to pdf...");
                    try
                    {
                        ExecuteCommand("pdflatex", latex_path, "-interaction=batchmode", "refman.tex");
                        ExecuteCommand("makeindex", latex_path, "-q", "refman.idx");
                        ExecuteCommand("pdflatex", latex_path, "-interaction=batchmode", "refman.tex");
                    }
                    catch
                    {
                        Console.WriteLine("Failed to run \"pdflatex\" or \"makeindex\".");
                        Console.WriteLine("Please consult the documentation for more information");
                    }
                    File.Copy(Path.Combine(latex_path, "refman.pdf"),
                        Path.Combine(DocPath, ReferenceFile), true);
                    break;

                case BuildTarget.Clean:
                    Console.WriteLine("Cleaning intermediate object files.");
                    ExecutePrebuild("/clean", "/yes", "/file", bindings);
                    ExecutePrebuild("/clean", "/yes", "/file", opentk);
                    ExecutePrebuild("/clean", "/yes", "/file", quickstart);
                    DeleteDirectories(RootPath, "obj");
                    DeleteFiles(SourcePath, KeyFile);
                    break;

                case BuildTarget.DistClean:
                    Console.WriteLine("Cleaning intermediate and final object files.");
                    ExecutePrebuild("/clean", "/yes", "/file", bindings);
                    ExecutePrebuild("/clean", "/yes", "/file", opentk);
                    ExecutePrebuild("/clean", "/yes", "/file", quickstart);
                    DeleteDirectories(RootPath, "obj");
                    DeleteDirectories(RootPath, "bin");
                    DeleteDirectories(DocPath, "Source");
                    DeleteFiles(DocPath, ReferenceFile);
                    DeleteFiles(SourcePath, KeyFile);

                    string binaries_path = Path.Combine(RootPath, "Binaries");
                    try
                    {
                        if (Directory.Exists(binaries_path))
                            Directory.Delete(binaries_path, true);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Failed to delete directory \"{0}\".", binaries_path);
                        Console.WriteLine(e.ToString());
                    }

                    break;

                default:
                    Console.WriteLine("Unknown target: {0}", target);
                    PrintUsage();
                    break;
            }
        }

        static void WaitForExit()
        {
            if (Debugger.IsAttached)
            {
                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
            }
        }

        static void DeleteBuildFiles()
        {
            try
            {
                File.Delete(bindings);
                File.Delete(opentk);
                File.Delete(quickstart);
                File.Delete(DoxyFile);
            }
            catch (IOException e)
            {
                Console.WriteLine("[Warning] Failed to delete prebuild files, error follows:");
                Console.WriteLine(e.ToString());
            }
        }

        static void ApplyMonoDevelopWorkarounds(string solution)
        {
            // Both workarounds cause problems in visual studio...
            //File.WriteAllText(solution, File.ReadAllText(solution)
            //    .Replace("AssemblyOriginatorKeyFile", "AssemblyKeyFile"));
            //    .Replace(@"..\", @"../"));
        }

        static void DeleteDirectories(string root_path, string search)
        {
            Console.WriteLine("Deleting {0} directories", search);
            foreach (string m in Directory.GetDirectories(root_path, search, SearchOption.AllDirectories))
            {
                Directory.Delete(m, true);
            }
        }

        static void DeleteFiles(string root_path, string search)
        {
            Console.WriteLine("Deleting {0} files", search);
            foreach (string m in Directory.GetFiles(root_path, search, SearchOption.AllDirectories))
            {
                File.Delete(m);
            }
        }

        static void FindDirectories(string directory, string search, List<string> matches) 
        {
            try    
            {
                foreach (string d in Directory.GetDirectories(directory)) 
                {
                    foreach (string f in Directory.GetDirectories(d, search))
                    {
                        matches.Add(f);
                    }
                    FindDirectories(d, search, matches);
                }
            }
            catch (System.Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }

        static void FindFiles(string directory, string search, List<string> matches)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(directory))
                {
                    foreach (string f in Directory.GetFiles(d, search))
                    {
                        matches.Add(f);
                    }
                    FindFiles(d, search, matches);
                }
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void FileCopy(string srcdir, string destdir, Regex match)
        {
            //DirectoryInfo dir;
            //FileInfo[] files;
            //DirectoryInfo[] dirs;
            //string tmppath;

            //determine if the destination directory exists, if not create it
            if (!Directory.Exists(destdir))
                Directory.CreateDirectory(destdir);

            if (!Directory.Exists(srcdir))
                throw new ArgumentException("source dir doesn't exist -> " + srcdir);

            string[] files = Directory.GetFiles(srcdir);
            foreach (string f in files)
                //if (Path.GetExtension(f).ToLower() == ext.ToLower())
                if (match.IsMatch(Path.GetExtension(f)))
                    File.Copy(f, Path.Combine(destdir, Path.GetFileName(f)), true);

            foreach (string dir in Directory.GetDirectories(srcdir))
            {
                string name = dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar)+1);
                if (!name.StartsWith("."))
                    FileCopy(dir, Path.Combine(destdir, name), match);
            }
        }

        static void ExecutePrebuild(params string[] options)
        {
            Prebuild.EntryPoint.Invoke(null, new object[] { options });
        }

        static void ExecuteCommand(string command, string workingDirectory, params string[] options)
        {
            ProcessStartInfo psi = new ProcessStartInfo(command);
            
            if (options != null)
            {
                StringBuilder sb = new StringBuilder();
                foreach (string opt in options)
                {
                    sb.Append(opt);
                    sb.Append(" ");
                }
                psi.Arguments = sb.ToString();
            }

            if (!String.IsNullOrEmpty(workingDirectory))
            {
                psi.WorkingDirectory = workingDirectory;
                psi.UseShellExecute = false;
            }

            Process p = Process.Start(psi);
            p.WaitForExit();
        }

        static bool CheckKeyFile(string keyfile)
        {
            if (!File.Exists(keyfile))
            {
                //Console.WriteLine("Keyfile {0} not found. Generating temporary key pair.", keyfile);
                //Process keygen = Process.Start("sn", "-k " + keyfile);
                //keygen.WaitForExit();
                Console.WriteLine("Keyfile {0} not found. Assemblies will not be signed.", keyfile);
                Console.WriteLine();
                return false;
            }
            else
            {
                Console.WriteLine("Keyfile {0} found. Assemblies will be signed.", keyfile);
                Console.WriteLine();
                return true;
            }
        }
    }
}

