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
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Microsoft.Build.BuildEngine;

namespace OpenTK.Build
{
    partial class Project
    {
        static void BuildProject()
        {
            Engine engine = new Engine();
            engine.BinPath = RuntimeEnvironment.GetRuntimeDirectory();
            engine.RegisterLogger(new ConsoleLogger());
            engine.OnlyLogCriticalEvents = true;

            string project_path = Path.Combine(RootPath, "OpenTK.sln");
            Microsoft.Build.BuildEngine.Project project = new Microsoft.Build.BuildEngine.Project(engine);

            project.Load(project_path);
            project.GlobalProperties.SetProperty("Configuration", "Release");
            project.Build();

            project.Load(project_path);
            project.GlobalProperties.SetProperty("Configuration", "Debug"); 
            project.Build();

            // For some reason, xbuild doesn't copy xml docs to the output directory.
            // Let's do that by hand.
            CopyXMLDocs();
        }

        static void CopyXMLDocs()
        {
            string binaries_path = Path.Combine(Path.Combine(RootPath, "Binaries"), "OpenTK");
            foreach (string file in Directory.GetFiles(SourcePath, "OpenTK*.xml", SearchOption.AllDirectories))
            {
                if (Path.GetFileName(file).Contains("Prebuild"))
                    continue;

                File.Copy(file, Path.Combine(Path.Combine(binaries_path, "Release"), Path.GetFileName(file)), true);
                File.Copy(file, Path.Combine(Path.Combine(binaries_path, "Debug"), Path.GetFileName(file)), true);
            }
        }
    }
}
