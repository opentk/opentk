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

namespace OpenTK.Build
{
    partial class Project
    {
        static readonly string NsisPath = Path.Combine("Installers", "Nsis");

        // Constructs NSIS installer.
        // Note 1: for this to work correctly, we need to construct VS projects,
        // compile them and build documentation first. This is not handled here.
        // Note 2: if version numbers are not specified, we ask the user explicitly.
        static void BuildNsis(string pversion, string prevision, string pextra)
        {
            if (!CheckNsisInstallation())
                return;

            Console.WriteLine("IMPORTANT: for a correct NSIS installer, you need to create VS projects, compile them and build documentation first. Use \"Build.exe all\" to do all this automatically.");

            if (String.IsNullOrEmpty(pversion) || String.IsNullOrEmpty(prevision) ||
                String.IsNullOrEmpty(pextra))
                RequestVersionInfo(out pversion, out prevision, out pextra);

            string source_nsi = Path.Combine(NsisPath, "opentk.nsi");
            string actual_nsi = Path.Combine(NsisPath, "opentk-actual.nsi");
            File.WriteAllText(actual_nsi, File.ReadAllText(source_nsi)
                .Replace("{{version}}", pversion)
                .Replace("{{revision}}", prevision)
                .Replace("{{extra}}", pextra));

            ExecuteCommand("makensis", NsisPath, Path.GetFullPath(actual_nsi));
            File.Delete(actual_nsi);
        }

        static bool CheckNsisInstallation()
        {
            Console.WriteLine("Checking for NSIS installation.");
            try
            {
                ExecuteCommand("makensis", null, null);
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not detect \"makensis\" command.");
                Console.WriteLine("Please install NSIS and ensure its installation folder exists in your path.");
                Console.WriteLine("Windows users: download from http://nsis.sourceforge.net");
                Console.WriteLine("Ubuntu/Debian users: type \"sudo apt-get install nsis\"");
                Console.WriteLine();
                Console.WriteLine("Exact error message:");
                Console.WriteLine(e.ToString());
                return false;
            }
            Console.WriteLine("Working fine.");
            return true;
        }

        static void RequestVersionInfo(out string pversion, out string prevision, out string pextra)
        {
            Console.WriteLine("Please specify the following information (press enter for defaults)");
            Console.Write("Product version ({0}): ", ProductVersion);
            pversion = Console.ReadLine();
            Console.Write("Product revision ({0}): ", ProductVersionRevision);
            prevision = Console.ReadLine();
            Console.Write("Product version extra ({0}): ", ProductVersionExtra);
            pextra = Console.ReadLine();

            if (String.IsNullOrEmpty(pversion))
                pversion = ProductVersion;
            if (String.IsNullOrEmpty(prevision))
                prevision = ProductVersionRevision;
            if (String.IsNullOrEmpty(pextra))
                pextra = ProductVersionExtra;
        }

        static void CleanNsisFiles()
        {
            DeleteFiles(Path.Combine("Installers", "Nsis"), "opentk-actual.nsi");
        }

        static void DistCleanNsisFiles()
        {
            CleanNsisFiles();
            DeleteFiles(Path.Combine("Installers", "Nsis"), "*.exe");
        }
    }
}