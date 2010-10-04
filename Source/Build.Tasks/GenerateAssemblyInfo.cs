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
using System.IO;
using System.Text;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace Build.Tasks
{
    public class GenerateAssemblyInfo : Task
    {
        [Required]
        public string OutputFile { get; set; }
        public string AssemblyCompany { get; set; }
        public string AssemblyProduct { get; set; }
        public string AssemblyCopyright { get; set; }
        public string AssemblyTrademark { get; set; }
        public string Major { get; set; }
        public string Minor { get; set; }

        string Build { get; set; }
        string Revision { get; set; }

        public GenerateAssemblyInfo()
        {
            // Build number is defined as the number of days since 1/1/2010.
            // Revision number is defined as the fraction of the current day, expressed in seconds.
            double timespan = DateTime.UtcNow.Subtract(new DateTime(2010, 1, 1)).TotalDays;
            Build = ((int)timespan).ToString();
            Revision = ((int)((timespan - (int)timespan) * UInt16.MaxValue)).ToString();
            Major = Major ?? "0";
            Minor = Minor ?? "0";
        }
    
        public override bool Execute()
        {
            Encoding utf8 = new UTF8Encoding(true);

            using (StreamWriter sw = new StreamWriter(OutputFile, false, utf8))
            {
                sw.WriteLine("// This file is auto-generated through Source.Build.Tasks/AssemblyInfo.cs.");
                sw.WriteLine("// Do not edit by hand!");
                sw.WriteLine();

                foreach (var import in new string[] { "System", "System.Reflection", "System.Resources",
                    "System.Runtime.CompilerServices", "System.Runtime.InteropServices" })
                {
                    sw.WriteLine("using {0};", import);
                }
                sw.WriteLine();

                sw.WriteLine("[assembly: AssemblyCompany(\"{0}\")]", AssemblyCompany ?? "");
                sw.WriteLine("[assembly: AssemblyProduct(\"{0}\")]", AssemblyProduct ?? "");
                sw.WriteLine("[assembly: AssemblyCopyright(\"{0}\")]", AssemblyCopyright ?? "");
                sw.WriteLine("[assembly: AssemblyTrademark(\"{0}\")]", AssemblyTrademark ?? "");
                sw.WriteLine("[assembly: AssemblyVersion(\"{0}.{1}.0.0\")]", Major, Minor);
                sw.WriteLine("[assembly: AssemblyFileVersion(\"{0}.{1}.{2}.{3}\")]", Major, Minor, Build, Revision);

                sw.Flush();
                sw.Close();
                Log.LogMessage("Created AssemblyInfo file \"{0}\".", OutputFile);
            }

            return true;
        }
    }
}
