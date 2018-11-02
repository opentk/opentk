/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */

using System;
using System.IO;
using System.Linq;

namespace Bind
{
    /// <summary>
    /// Helps resolve the path for the binder.
    /// </summary>
    public static class PathResolver
    {
        // Default path values in case of missing arguments.
        private static string DefaultInputPath = Path.Combine("src", "Generator.Bind", "Specifications");
        private static string DefaultOutputPath = Path.Combine("src", "OpenTK", "Graphics");
        private static string DefaultDocumentationPath = Path.Combine("src", "Generator.Bind", "Specifications", "Docs", "docs.gl");
        private static string DefaultLicenseFile = Path.Combine("src", "Generator.Bind", "Specifications", "License.txt");

        /// <summary>
        /// Ensures that the paths are configured properly.
        /// </summary>
        public static void EnsureCorrectArguments()
        {
            bool AnyEmpty(params string[] args) => args.Any(x => string.IsNullOrEmpty(x));

            if (AnyEmpty(Program.Arguments.InputPath, Program.Arguments.OutputPath, Program.Arguments.DocumentationPath, Program.Arguments.LicenseFile))
            {
                SetDefaults();
                ResolvePath();
                return;
            }

            // Continue checking for invalid paths, just in case.
            bool AnyWrong(params string[] args)
            {
                bool markedWrong = false;
                foreach (var path in args)
                {
                    var dummyFullPath = Path.GetFullPath(path);
                    if (!Directory.Exists(path))
                    {
                        Console.WriteLine(path + " doesn't exist.");
                        markedWrong = true;
                    }
                }
                return markedWrong;
            }

            if (AnyWrong(Program.Arguments.InputPath, Program.Arguments.OutputPath, Program.Arguments.DocumentationPath, Program.Arguments.LicenseFile))
            {
                ResolvePath();
            }
        }

        /// <summary>
        /// Resolves the path in case of empty arguments.
        /// Should allow the user to manually build and execute the Binder from within the bin folder.
        /// </summary>
        private static void ResolvePath()
        {
            var dummyFullPath = Path.GetFullPath(Program.Arguments.InputPath);
            if (Directory.Exists(dummyFullPath))
            {
                Console.WriteLine("No path arguments passed but directory is valid..");
                Console.WriteLine("Press F to fix directory, or any other key to continue");

                string userInput = Console.ReadKey(true).Key.ToString().ToLower();
                if (userInput != "f")
                {
                    return;
                }
            }

            System.Console.WriteLine("Adding solution path to directory");
            UpdateArguments(dummyFullPath);

            dummyFullPath = Path.GetFullPath(Program.Arguments.InputPath);

            if (!Directory.Exists(dummyFullPath))
            {
                Console.WriteLine("Failed to resolve directory.");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey(true);
                Environment.Exit(-1);
            }
            Console.ReadKey(true);
        }

        /// <summary>
        /// Inserts the solution path to the arguments paths.
        /// </summary>
        /// <param name="fullPath">Dummy full path.</param>
        private static void UpdateArguments(string fullPath)
        {
            string solutionPath = fullPath.Substring(0, fullPath.IndexOf(@"src"));
            string InsertSolutionDir(string str) => str.Insert(0, solutionPath);

            Program.Arguments.InputPath = InsertSolutionDir(Program.Arguments.InputPath);
            Program.Arguments.OutputPath = InsertSolutionDir(Program.Arguments.OutputPath);
            Program.Arguments.DocumentationPath = InsertSolutionDir(Program.Arguments.DocumentationPath);
            Program.Arguments.LicenseFile = InsertSolutionDir(Program.Arguments.LicenseFile);
        }

        private static void SetDefaults()
        {
            Program.Arguments.InputPath = DefaultInputPath;
            Program.Arguments.OutputPath = DefaultOutputPath;
            Program.Arguments.DocumentationPath = DefaultDocumentationPath;
            Program.Arguments.LicenseFile = DefaultLicenseFile;
        }
    }
}
