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
        static string RootPath;
        static string SourcePath;

        const string bindings = "Generator.Prebuild.xml";
        const string opentk = "OpenTK.Prebuild.xml";
        const string quickstart = "QuickStart.Prebuild.xml";

        static readonly Assembly Prebuild = Assembly.Load(Resources.Prebuild);

        enum BuildTarget
        {
            VS2005,
            VS2008,
            Mono,
            Net,
            Clean,
            DistClean,
        }

        static BuildTarget target = BuildTarget.VS2005;

        static void PrintUsage()
        {
            Console.WriteLine("Usage: Build.exe target");
            Console.WriteLine("    target: one of vs, vs9, clean, distclean");
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

            RootPath = Directory.GetCurrentDirectory();
            SourcePath = Path.Combine(RootPath, "Source");

            File.WriteAllText(bindings, Resources.Generator);
            File.WriteAllText(opentk, Resources.OpenTK);
            File.WriteAllText(quickstart, Resources.QuickStart);

            // Workaroung for nant on x64 windows (safe for other platforms too, as this affects only the current process).
            Environment.SetEnvironmentVariable("CommonProgramFiles(x86)", String.Empty, EnvironmentVariableTarget.Process);
            Environment.SetEnvironmentVariable("ProgramFiles(x86)", String.Empty, EnvironmentVariableTarget.Process);

            foreach (string s in args)
            {
                string arg = s.ToLower().Trim();
                switch (arg)
                {
                    case "":
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

                    case "clean":
                        target = BuildTarget.Clean;
                        break;

                    case "distclean":
                        target = BuildTarget.DistClean;
                        break;

                    default:
                        Console.WriteLine("Unknown command: {0}", s);
                        PrintUsage();
                        return;
                }
            }

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
                
                case BuildTarget.Clean:
                    Console.WriteLine("Cleaning intermediate object files.");
                    ExecutePrebuild("/clean", "/yes", "/file", bindings);
                    ExecutePrebuild("/clean", "/yes", "/file", opentk);
                    ExecutePrebuild("/clean", "/yes", "/file", quickstart);
                    DeleteDirectories(RootPath, "obj");
                    break;

                case BuildTarget.DistClean:
                    Console.WriteLine("Cleaning intermediate and final object files.");
                    ExecutePrebuild("/clean", "/yes", "/file", bindings);
                    ExecutePrebuild("/clean", "/yes", "/file", opentk);
                    ExecutePrebuild("/clean", "/yes", "/file", quickstart); 
                    DeleteDirectories(RootPath, "obj");
                    DeleteDirectories(RootPath, "bin");

                    string binaries_path = Path.Combine(RootPath, "Binaries");
                    if (Directory.Exists(binaries_path))
                        Directory.Delete(binaries_path, true);

                    break;

                default:
                    Console.WriteLine("Unknown target: {0}", target);
                    PrintUsage();
                    return;
            }

            // Wait until Prebuild releases the input files.
            System.Threading.Thread.Sleep(1000);

            File.Delete(bindings);
            File.Delete(opentk);
            File.Delete(quickstart);

            if (Debugger.IsAttached)
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
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

        static void ExecutePrebuild(params string[] options)
        {
            Prebuild.EntryPoint.Invoke(null, new object[] { options });
        }
    }
}

