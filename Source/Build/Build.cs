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
        static string ToolPath = "Build\\";
        static string PrebuildPath = ToolPath + "Prebuild.exe";
        static string BinPath = "Binaries\\";
        //string ObjPath 

        static string PrebuildXml = RootPath + "Prebuild.xml";

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

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
            }
        }

        static void DeleteDirectories(string root_path, string search)
        {
            Console.WriteLine("Deleting {0} directories", search);
            List<string> matches = new List<string>();
            DirectorySearch(root_path, search, matches);
            foreach (string m in matches)
            {
                Directory.Delete(m, true);
            }
        }

        static void DirectorySearch(string directory, string search, List<string> matches) 
        {
	        try	
	        {
                foreach (string d in Directory.GetDirectories(directory)) 
                {
                    foreach (string f in Directory.GetDirectories(d, search))
                    {
                        matches.Add(f);
                    }
                    DirectorySearch(d, search, matches);
                }
	        }
	        catch (System.Exception e) 
	        {
		        Console.WriteLine(e.Message);
	        }
        }

        static void ExecuteProcess(string path, string args)
        {
            Process p = new Process();
            p.StartInfo.FileName = path;
            p.StartInfo.Arguments = args;
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
