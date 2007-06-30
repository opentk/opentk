using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace OpenTK.Build
{
    class Project
    {
        static string RootPath;
        static string SourcePath;
        static string ToolPath = "Build\\";
        static string PrebuildPath = Path.Combine(ToolPath, "Prebuild.exe");
        static string BinPath = "Binaries\\";
        static string ExePath = Path.Combine(BinPath, "Exe");
        static string LibPath = Path.Combine(BinPath, "Libraries");
        static string ExamplePath = Path.Combine(BinPath, "Examples");
 
        static string PrebuildXml = "Prebuild.xml";

        enum BuildMode
        {
            Default = 0,
            Release = 0,
            Debug
        }

        enum BuildTarget
        {
            Default = 0,
            Net = 0,
            Mono,
            VS2005,
            SharpDevelop,
            MonoDevelop,
            Clean,
            DistClean,
            SVNClean
        }

        static BuildMode mode = BuildMode.Default;
        static BuildTarget target = BuildTarget.Default;

        static void Main(string[] args)
        {
            RootPath = Directory.GetCurrentDirectory();
            RootPath = RootPath.Substring(
                0,
                Directory.GetCurrentDirectory().LastIndexOf("Build"));
            Directory.SetCurrentDirectory(RootPath);
            SourcePath = Path.Combine(RootPath, "Source");

            // Workaroung for nant on x64 windows (safe for other platforms too, as this affects
            // only the current process).
            Environment.SetEnvironmentVariable("CommonProgramFiles(x86)", String.Empty, EnvironmentVariableTarget.Process);
            Environment.SetEnvironmentVariable("ProgramFiles(x86)", String.Empty, EnvironmentVariableTarget.Process);

            if (args.Length == 0)
            {
                Console.WriteLine("Usage: OpenTK.Build.exe BuildMode BuildTarget");
                Console.WriteLine("\tBuildMode: debug/release");
                Console.WriteLine("\tBuildTarget: mono/net/monodev/sharpdev/vs2005 or clean/distclean/svnclean");
            }
            else
            {
                foreach (string s in args)
                {
                    string arg = s.ToLower();
                    switch (arg)
                    {
                        case "debug":
                        case "d":
                            mode = BuildMode.Debug;
                            break;

                        case "release":
                        case "r":
                            mode = BuildMode.Release;
                            break;

                        case "mono":
                            target = BuildTarget.Mono;
                            break;

                        case "net":
                            target = BuildTarget.Net;
                            break;

                        case "monodev":
                        case "monodevelop":
                        case "md":
                            target = BuildTarget.MonoDevelop;
                            break;

                        case "sharpdev":
                        case "sharpdevelop":
                        case "sd":
                            target = BuildTarget.SharpDevelop;
                            break;

                        case "vs2005":
                        case "vs":
                            target = BuildTarget.VS2005;
                            break;

                        case "clean":
                            target = BuildTarget.Clean;
                            break;
                        
                        case "svnclean":
                            target = BuildTarget.SVNClean;
                            break;

                        case "distclean":
                            target = BuildTarget.DistClean;
                            break;

                        default:
                            Console.WriteLine("Unknown command: {0}", s);
                            break;
                    }
                }

                ExePath = Path.Combine(
                    BinPath,
                    Path.Combine(mode == BuildMode.Debug ? "Debug" : "Release", "Exe"));
                LibPath = Path.Combine(
                    BinPath,
                    Path.Combine(mode == BuildMode.Debug ? "Debug" : "Release", "Libraries"));
                ExamplePath = Path.Combine(
                    BinPath,
                    Path.Combine(mode == BuildMode.Debug ? "Debug" : "Release", "Examples"));

                switch (target)
                {
                    case BuildTarget.Mono:
                        Console.WriteLine("Building OpenTK using Mono.");
                        ExecuteProcess(PrebuildPath, "/target nant /file " + PrebuildXml);
                        ExecuteProcess("nant", "-t:mono-2.0");

                        break;

                    case BuildTarget.Net:
                        Console.WriteLine("Building OpenTK using .Net");
                        ExecuteProcess(PrebuildPath, "/target nant /file " + PrebuildXml);
                        ExecuteProcess("nant", "-t:net-2.0");
                        CopyBinaries();
                        break;

                    case BuildTarget.MonoDevelop:
                        Console.WriteLine("Creating MonoDevelop project files");
                        ExecuteProcess(PrebuildPath, "/target monodev /file " + PrebuildXml);
                        break;

                    case BuildTarget.SharpDevelop:
                        Console.WriteLine("Creating SharpDevelop project files");
                        ExecuteProcess(PrebuildPath, "/target monodev /file " + PrebuildXml);
                        break;

                    case BuildTarget.VS2005:
                        Console.WriteLine("Creating VS2005 project files");
                        ExecuteProcess(PrebuildPath, "/target vs2005 /file " + PrebuildXml);
                        break;

                    case BuildTarget.Clean:
                        Console.WriteLine("Cleaning intermediate object files.");
                        ExecuteProcess(PrebuildPath, "/clean /yes /file " + PrebuildXml);
                        DeleteDirectories(RootPath, "obj");
                        break;

                    case BuildTarget.DistClean:
                        Console.WriteLine("Cleaning intermediate and final object files.");
                        ExecuteProcess(PrebuildPath, "/clean /yes /file " + PrebuildXml);
                        DeleteDirectories(RootPath, "obj");
                        DeleteDirectories(RootPath, "bin");
                        if (Directory.Exists(RootPath + "Binaries"))
                            Directory.Delete(RootPath + "Binaries", true);
                        break;

                    case BuildTarget.SVNClean:
                        Console.WriteLine("Deleting svn directories.");
                        DeleteDirectories(RootPath, ".svn");
                        break;

                    default:
                        Console.WriteLine("Unknown target.");
                        break;
                }

                //Console.WriteLine("Press any key to continue...");
                //Console.ReadKey(true);
            }
        }

        static void DeleteDirectories(string root_path, string search)
        {
            Console.WriteLine("Deleting {0} directories", search);
            List<string> matches = new List<string>();
            FindDirectories(root_path, search, matches);
            foreach (string m in matches)
            {
                Directory.Delete(m, true);
            }
        }

        static void CopyBinaries()
        {
            List<string> example_matches = new List<string>();
            List<string> exe_matches = new List<string>();
            List<string> dll_matches = new List<string>();
            List<string> dll_config_matches = new List<string>();
            
            Directory.CreateDirectory(BinPath);
            Directory.CreateDirectory(ExePath);
            Directory.CreateDirectory(LibPath);
            Directory.CreateDirectory(ExamplePath);

            // Move the libraries and the config files.
            FindFiles(SourcePath, "*.dll", dll_matches);
            foreach (string m in dll_matches)
            {
                File.Delete(Path.Combine(LibPath, Path.GetFileName(m)));
                File.Copy(m, Path.Combine(LibPath, Path.GetFileName(m)));
                File.Delete(Path.Combine(ExamplePath, Path.GetFileName(m)));
                File.Copy(m, Path.Combine(ExamplePath, Path.GetFileName(m)));
            }

            FindFiles(SourcePath, "*.config", dll_config_matches);
            foreach (string m in dll_config_matches)
            {
                File.Delete(Path.Combine(LibPath, Path.GetFileName(m)));
                File.Copy(m, Path.Combine(LibPath, Path.GetFileName(m)));
                File.Delete(Path.Combine(ExamplePath, Path.GetFileName(m)));
                File.Copy(m, Path.Combine(ExamplePath, Path.GetFileName(m)));
            }

            // Then the examples.
            FindFiles(Path.Combine(SourcePath, "Examples"), "*.exe", example_matches);
            foreach (string m in example_matches)
            {
                File.Delete(Path.Combine(ExamplePath, Path.GetFileName(m)));
                File.Move(m, Path.Combine(ExamplePath, Path.GetFileName(m)));
            }

            // Then the rest of the exes.
            FindFiles(SourcePath, "*.exe", exe_matches);
            foreach (string m in exe_matches)
            {
                File.Delete(Path.Combine(ExePath, Path.GetFileName(m)));
                File.Move(m, Path.Combine(ExePath, Path.GetFileName(m)));
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
                foreach (string f in Directory.GetFiles(directory, search, SearchOption.AllDirectories))
                {
                    matches.Add(f);
                }
                //FindFiles(d, search, matches);
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        static void ExecuteProcess(string path, string args)
        {
            Process p = new Process();
            if (Environment.OSVersion.Platform == PlatformID.Unix && !path.ToLower().Contains("nant"))
            {
                p.StartInfo.FileName = "mono";
                p.StartInfo.Arguments = path + " " + args;
            }
            else
            {
                p.StartInfo.FileName = path;
                p.StartInfo.Arguments = args;
            }

            p.StartInfo.WorkingDirectory = RootPath;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.UseShellExecute = false;
            p.Start();
            Console.Write(p.StandardOutput.ReadToEnd());
            p.WaitForExit();
        }
    }
}
