/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Bind
{
    /// <summary>
    /// Helps resolve the path for the binder.
    /// </summary>
    public static class PathResolver
    {
        /// <summary>
        /// Helper enum that holds Path IDs.
        /// Each Path ID represents an argument.
        /// </summary>
        private enum PathID
        {
            Input,
            Output,
            Documentation,
            License
        }

        /// <summary>
        /// Default path values in case of missing arguments.
        /// </summary>
        private static Dictionary<PathID, string> _defaultPaths = new Dictionary<PathID, string>()
        {
            { PathID.Input, Path.Combine("src", "Generator.Bind", "Specifications") },
            { PathID.Output, Path.Combine("src", "OpenTK", "Graphics") },
            { PathID.Documentation, Path.Combine("src", "Generator.Bind", "Specifications", "Docs", "docs.gl") },
            { PathID.License, Path.Combine("src", "Generator.Bind", "Specifications", "License.txt") }
        };

        /// <summary>
        /// How to represent values in program. Cosmetic usage only.
        /// Note: Index order is hardcoded.
        /// </summary>
        private static Dictionary<PathID, string> _pathValues = new Dictionary<PathID, string>()
        {
            { PathID.Input, "Input Path" },
            { PathID.Output, "Output Path" },
            { PathID.Documentation, "Documentation Path" },
            { PathID.License, "License Path" }
        };

        /// <summary>
        /// Resolves the path in case of empty arguments and Ensures that the paths are configured properly.
        /// Should allow the user to manually build and execute the Binder from within the bin folder.
        /// </summary>
        public static void ValidateArguments()
        {
            // Scan for missing arguments
            Console.WriteLine("Checking Arguments");
            Console.WriteLine("...");
            Console.WriteLine();
            CheckForEmptyArguments(Program.Arguments.InputPath, Program.Arguments.OutputPath, Program.Arguments.DocumentationPath, Program.Arguments.LicenseFile);

            // Check if paths are valid.
            Console.WriteLine("Validating Paths");
            Console.WriteLine("...");
            Console.WriteLine();
            ValidatePaths(false, Program.Arguments.InputPath, Program.Arguments.OutputPath, Program.Arguments.DocumentationPath, Program.Arguments.LicenseFile);

            // Check again. Initiate program exit if a path is not valid.
            ValidatePaths(true, Program.Arguments.InputPath, Program.Arguments.OutputPath, Program.Arguments.DocumentationPath, Program.Arguments.LicenseFile);
        }

        /// <summary>
        /// Scan the arguments and replace any missing ones with the default argument value.
        /// </summary>
        /// <param name="args">Arguments to check.</param>
        private static void CheckForEmptyArguments(params string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (string.IsNullOrEmpty(args[i]))
                {
                    Console.WriteLine($"Argument {_pathValues.ElementAt(i).Value} wasn't specified. Setting default value.");
                    SetDefaultPath(_pathValues.ElementAt(i).Key);
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Path validation.
        /// </summary>
        /// <param name="quitIfNotFound">Specify if program exit be initiated on fail.</param>
        /// <param name="args">Paths to check for integrity.</param>
        private static void ValidatePaths(bool quitIfNotFound, params string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                var fullPath = Path.GetFullPath(args[i]);
                bool dirExists = Directory.Exists(fullPath) || File.Exists(fullPath);

                if (!dirExists && !quitIfNotFound)
                {
                    Console.WriteLine($"Path {fullPath} doesn't exist.");
                    Console.WriteLine("...Replacing with solution directory.");
                    Console.WriteLine();
                    UpdatePath(_pathValues.ElementAt(i).Key);
                }
                else if (!dirExists && quitIfNotFound)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Failed to resolve directory for {_pathValues.ElementAt(i).Value}.");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey(true);
                    Environment.Exit(-1);
                }
            }
        }

        private static void SetDefaultPath(PathID argID)
        {
            if (argID == PathID.Input)
            {
                Program.Arguments.InputPath = _defaultPaths[argID];
            }
            else if (argID == PathID.Output)
            {
                Program.Arguments.OutputPath = _defaultPaths[argID];
            }
            else if (argID == PathID.Documentation)
            {
                Program.Arguments.DocumentationPath = _defaultPaths[argID];
            }
            else if (argID == PathID.License)
            {
                Program.Arguments.LicenseFile = _defaultPaths[argID];
            }
        }

        private static void UpdatePath(PathID argID)
        {
            var fullPath = Path.GetFullPath(Program.Arguments.InputPath);
            string solutionPath = fullPath.Substring(0, fullPath.IndexOf(@"src"));
            string InsertSolutionDir(string str) => str.Insert(0, solutionPath);

            if (argID == PathID.Input)
            {
                Program.Arguments.InputPath = InsertSolutionDir(Program.Arguments.InputPath);
            }
            else if (argID == PathID.Output)
            {
                Program.Arguments.OutputPath = InsertSolutionDir(Program.Arguments.OutputPath);
            }
            else if (argID == PathID.Documentation)
            {
                Program.Arguments.DocumentationPath = InsertSolutionDir(Program.Arguments.DocumentationPath);
            }
            else if (argID == PathID.License)
            {
                Program.Arguments.LicenseFile = InsertSolutionDir(Program.Arguments.LicenseFile);
            }
        }
    }
}
