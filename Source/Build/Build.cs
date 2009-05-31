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

#endregion

namespace OpenTK.Build
{
    class Project
    {
        static string RootPath;
        static string SourcePath;
        static string ToolPath = "Build";
        static string PrebuildPath = Path.Combine(ToolPath, "Prebuild.exe");
        static string BinPath;
        static string ExePath;
        static string LibPath;
        static string ExamplePath;
        static string DataSourcePath;
        static string DataPath;

        static string PrebuildXml = Path.Combine(ToolPath, "Prebuild.xml");

        static Regex DataFiles = new Regex(@"^.*\.(bmp|png|jpg|txt|glsl|wav|ogg)$",
                                           RegexOptions.Compiled | RegexOptions.IgnoreCase);

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
            SharpDevelop2,
            MonoDevelop,
            Clean,
            DistClean,
            SVNClean
        }

        static BuildMode mode = BuildMode.Default;
        static BuildTarget target = BuildTarget.Default;

        static void PrintUsage()
        {
            Console.WriteLine("Usage: Build.exe BuildTarget [BuildMode]");
            Console.WriteLine("\tBuildTarget: vs (recommended) or one of clean/distclean/mono/net");
            Console.WriteLine("\tBuildMode: debug/release");
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

                if (args[0] != "vs")
                {
                    Console.Write("Select build mode (optional): ");
                    args[1] = Console.ReadLine();
                    if (args[1] == String.Empty)
                        args[1] = "release";
                }
            }

            RootPath = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
            Directory.SetCurrentDirectory(RootPath);
            SourcePath = Path.Combine(RootPath, "Source");
            DataSourcePath = Path.Combine(SourcePath, Path.Combine("Examples", "Data"));

            // Workaroung for nant on x64 windows (safe for other platforms too, as this affects only the current process).
            Environment.SetEnvironmentVariable("CommonProgramFiles(x86)", String.Empty, EnvironmentVariableTarget.Process);
            Environment.SetEnvironmentVariable("ProgramFiles(x86)", String.Empty, EnvironmentVariableTarget.Process);

            foreach (string s in args)
            {
                string arg = s.ToLower().Trim();
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

                    case "sharpdev2":
                    case "sharpdevelop2":
                    case "sd2":
                        target = BuildTarget.SharpDevelop2;
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

                    case "distclean":
                        target = BuildTarget.DistClean;
                        break;

                    case "":
                        break;

                    default:
                        Console.WriteLine("Unknown command: {0}", s);
                        PrintUsage();
                        return;
                }
            }

            BinPath = Path.Combine("Binaries", mode == BuildMode.Debug ? "Debug" : "Release");
            ExePath = Path.Combine(BinPath, "Exe");
            LibPath = Path.Combine(BinPath, "Libraries");
            ExamplePath = Path.Combine(BinPath, "Examples");
            DataPath = Path.Combine(ExamplePath, "Data");

            switch (target)
            {
                case BuildTarget.Mono:
                    Console.WriteLine("Building OpenTK using Mono.");
                    ExecuteProcess(PrebuildPath, "/target nant /file " + PrebuildXml);
                    Console.WriteLine();
                    ExecuteProcess(
                        "nant",
                        "-buildfile:./Build/OpenTK.build -t:mono-2.0 " + (mode == BuildMode.Debug ? "build-debug" : "build-release"));
                    CopyBinaries();
                    break;

                case BuildTarget.Net:
                    Console.WriteLine("Building OpenTK using .Net");
                    ExecuteProcess(PrebuildPath, "/target nant /file " + PrebuildXml);
                    Console.WriteLine();
                    ExecuteProcess(
                        "nant",
                        "-buildfile:./Build/OpenTK.build -t:net-2.0 " + (mode == BuildMode.Debug ? "build-debug" : "build-release"));
                    CopyBinaries();
                    break;

                case BuildTarget.MonoDevelop:
                    Console.WriteLine("Creating MonoDevelop project files");
                    ExecuteProcess(PrebuildPath, "/target monodev /file " + PrebuildXml);
                    break;

                case BuildTarget.SharpDevelop:
                    Console.WriteLine("Creating SharpDevelop project files");
                    ExecuteProcess(PrebuildPath, "/target sharpdev /file " + PrebuildXml);
                    break;

                case BuildTarget.SharpDevelop2:
                    Console.WriteLine("Creating SharpDevelop project files");
                    ExecuteProcess(PrebuildPath, "/target sharpdev2 /file " + PrebuildXml);
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
                    Console.WriteLine("Unknown target: {0}", target);
                    PrintUsage();
                    return;
            }

            //Console.WriteLine("Press any key to continue...");
            //Console.ReadKey(true);
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
            Directory.CreateDirectory(DataPath);

            // Move the libraries and the config files.
            FindFiles(SourcePath, "*.dll", dll_matches);
            FindFiles(SourcePath, "OpenTK.pdb", dll_matches);
            FindFiles(SourcePath, "OpenTK.dll.mdb", dll_matches);
            foreach (string m in dll_matches)
            {
                File.Delete(Path.Combine(LibPath, Path.GetFileName(m)));
                File.Copy(m, Path.Combine(LibPath, Path.GetFileName(m)));
                File.Delete(Path.Combine(ExamplePath, Path.GetFileName(m)));
                File.Copy(m, Path.Combine(ExamplePath, Path.GetFileName(m)));
            }

            FindFiles(SourcePath, "*.dll.config", dll_config_matches);
            foreach (string m in dll_config_matches)
            {
                File.Delete(Path.Combine(LibPath, Path.GetFileName(m)));
                File.Copy(m, Path.Combine(LibPath, Path.GetFileName(m)));
                File.Delete(Path.Combine(ExamplePath, Path.GetFileName(m)));
                File.Copy(m, Path.Combine(ExamplePath, Path.GetFileName(m)));
            }

            // Then the examples.
            FindFiles(Path.Combine(SourcePath, "Examples"), "*.exe", example_matches);
            FindFiles(SourcePath, "Examples.pdb", example_matches);
            FindFiles(SourcePath, "Examples.exe.mdb", example_matches);
            foreach (string m in example_matches)
            {
                File.Delete(Path.Combine(ExamplePath, Path.GetFileName(m)));
                File.Move(m, Path.Combine(ExamplePath, Path.GetFileName(m)));
            }

            // Copy example data.
            FileCopy(DataSourcePath, DataPath, DataFiles);

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
            ProcessStartInfo sinfo = new ProcessStartInfo();
            using (Process p = new Process())
            {
                try
                {
                    if (Environment.OSVersion.Platform == PlatformID.Unix && !path.ToLower().Contains("nant"))
                    {
                        sinfo.FileName = "mono";
                        sinfo.Arguments = path + " " + args;
                    }
                    else
                    {
                        sinfo.FileName = path;
                        sinfo.Arguments = args;
                    }

                    sinfo.WorkingDirectory = RootPath;
                    sinfo.CreateNoWindow = true;
                    sinfo.RedirectStandardOutput = true;
                    sinfo.UseShellExecute = false;
                    p.StartInfo = sinfo;
                    p.OutputDataReceived += new DataReceivedEventHandler(p_OutputDataReceived);
                    p.Start();
                    p.BeginOutputReadLine();
                    //StreamReader sr = p.StandardOutput;
                    //while (!p.HasExited)
                    //{
                    //    Console.WriteLine(sr.ReadLine());
                    //    Console.Out.Flush();
                    //}

                    p.WaitForExit();
                }
                catch (Exception)
                {
                    Console.WriteLine("Failed to execute process: {0}", sinfo.FileName);
                }
            }

        }

        static void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!String.IsNullOrEmpty(e.Data))
            {
                // Eat the last \n, we use WriteLine instead. This way we get the same result
                // in both windows and linux (linux would interpret both \n and WriteLine).
                Console.WriteLine(e.Data.TrimEnd('\n'));
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
    }
}

