#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2010 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

using System;
using System.Diagnostics;
using System.IO;

namespace Build.UpdateVersion
{
    class Program
    {
        const string Major = "1";
        const string Minor = "1";

        static string RootDirectory;
        static string SourceDirectory;

        public static void Main()
        {
            string wdir = Environment.CurrentDirectory;
            if (Directory.GetParent(wdir).Name == "Source")
            {
                // Running through msbuild inside Source/Build.UpdateVersion/
                RootDirectory = "../..";
                SourceDirectory = "..";
            }
            else
            {
                // Running manually inside Binaries/OpenTK/[Debug|Release]/
                RootDirectory = "../../..";
                SourceDirectory = "../../../Source";
            }

            DateTime now = DateTime.UtcNow;
            string timestamp = now.ToString("u").Split(' ')[0];
            // Build number is defined as the number of days since 1/1/2010.
            double timespan = now.Subtract(new DateTime(2010, 1, 1)).TotalDays;
            string build = ((int)timespan).ToString();
            // Revision number is defined as the number of (git/svn/bzr) commits,
            // or as the fraction of the current day, expressed in seconds, in case the
            // working directory is not under source control.
            string revision = RetrieveRevisionNumber(now);

            string major = Major;
            string minor = Minor;

            // Version is defined as {Major}.{Minor}.{Build}.{Revision}
            string version = String.Format("{0}.{1}.{2}.{3}", major, minor, build, revision);

            Console.WriteLine("API compatibility key: {0}.{1}", major, minor);
            Console.WriteLine("Build date: {0}", timestamp);

            GenerateTimestamp(timestamp, Path.Combine(RootDirectory, "Timestamp.txt"));
            GenerateVersion(version, Path.Combine(RootDirectory, "Version.txt"));
            GenerateAssemblyInfo(major, minor, version, Path.Combine(SourceDirectory, "GlobalAssemblyInfo.cs"));
        }

        static void GenerateTimestamp(string timestamp, string file)
        {
            System.IO.File.WriteAllLines(file, new string[] { timestamp });
        }

        static void GenerateVersion(string version, string file)
        {
            File.WriteAllLines(file, new string[] { version });
        }

        static void GenerateAssemblyInfo(string major, string minor, string version, string file)
        {
            File.WriteAllLines(file, new string[]
            {
                "// This file is auto-generated through Source/Build.Tasks/GenerateAssemblyInfo.cs.",
                "// Do not edit by hand!",
                "",
                "using System;",
                "using System.Reflection;",
                "using System.Resources;",
                "using System.Runtime.CompilerServices;",
                "using System.Runtime.InteropServices;",
                "",
                "[assembly: AssemblyCompany(\"The Open Toolkit Library\")]",
                "[assembly: AssemblyProduct(\"The Open Toolkit Library\")]",
                "[assembly: AssemblyCopyright(\"Copyright © 2006 - 2014 the Open Toolkit Library\")]",
                "[assembly: AssemblyTrademark(\"OpenTK\")]",
                String.Format("[assembly: AssemblyVersion(\"{0}.{1}.0.0\")]", major, minor),
                String.Format("[assembly: AssemblyFileVersion(\"{0}\")]", version),
            });
        }

        static string RetrieveRevisionNumber(DateTime now)
        {
            double timespan = now.Subtract(new DateTime(2010, 1, 1)).TotalDays;
            string revision = RetrieveGitRevision() ?? RetrieveSvnRevision() ?? RetrieveBzrRevision() ?? "0";
            revision = revision.Trim();
            return revision;
        }

        static string RetrieveSeconds(double timespan)
        {
            string revision = ((int)((timespan - (int)timespan) * UInt16.MaxValue)).ToString();
            return revision;
        }

        static string RetrieveGitRevision()
        {
            try
            {
                string output = RunProcess("git", "rev-list HEAD --count", RootDirectory);
                return output.Trim(' ', '\n');
            }
            catch (Exception e)
            {
                Debug.Print("Failed to retrieve git revision. Error: {0}", e);
            }
            return null;
        }


        static string RetrieveSvnRevision()
        {
            try
            {
                string output = RunProcess("svn", "info", RootDirectory);

                const string RevisionText = "Revision: ";
                int index = output.IndexOf(RevisionText);
                if (index > -1)
                    return output.Substring(index + RevisionText.Length, 5)
                        .Replace('\r', ' ').Replace('\n', ' ').Trim();
            }
            catch (Exception e)
            {
                Debug.Print("Failed to retrieve svn revision. Error: {0}", e);
            }
            return null;
        }

        static string RetrieveBzrRevision()
        {
            try
            {
                string output = RunProcess("bzr", "revno", RootDirectory);
                return output != null && !output.StartsWith("bzr") ? output : null;
            }
            catch (Exception e)
            {
                Debug.Print("Failed to retrieve svn revision. Error: {0}", e);
            }
            return null;
        }

        static string RunProcess(string cmd, string args, string wdir)
        {
            ProcessStartInfo info = new ProcessStartInfo(cmd, args);
            info.WorkingDirectory = wdir;
            info.RedirectStandardOutput = true;
            info.RedirectStandardError = true;
            info.UseShellExecute = false;
            Process p = new Process();
            p.StartInfo = info;
            p.Start();
            p.WaitForExit();
            string output = p.StandardOutput.ReadToEnd();
            return output;
        }
    }
}