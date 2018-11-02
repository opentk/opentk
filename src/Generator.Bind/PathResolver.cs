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
        /// Helper enum that holds Argument IDs.
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
            List<PathID> pathsToCheck = new List<PathID>()
            {
                    PathID.Input,
                    PathID.Output,
                    PathID.Documentation,
                    PathID.License
            };

            // Store the previous color before switching.
            ConsoleColor previousColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;

            // Scan for missing arguments
            CheckForEmptyArguments(ref pathsToCheck);

            // Check if paths are valid.
            ValidatePaths(ref pathsToCheck, false);

            // Check again. Initiate program exit if a path is not valid.
            ValidatePaths(ref pathsToCheck, true);

            // Set back the original color.
            Console.ForegroundColor = previousColor;
        }

        /// <summary>
        /// Scan the arguments and replace any missing ones with the default argument value.
        /// If a path was specified on program arguments, validates it's integrity.
        /// </summary>
        /// <param name="args">Arguments to check.</param>
        private static void CheckForEmptyArguments(ref List<PathID> args)
        {
            for (int i = args.Count - 1; i >= 0; i--)
            {
                if (string.IsNullOrEmpty(GetPathByID(args[i])))
                {
                    Console.WriteLine($"Argument {_pathValues[args[i]]} wasn't specified. Setting default value.");
                    SetDefaultPath(args[i]);
                }
                else
                {
                    var fullPath = Path.GetFullPath(GetPathByID(args[i]));
                    bool dirExists = Directory.Exists(fullPath) || File.Exists(fullPath);
                    if (!dirExists)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine();
                        Console.WriteLine($"Failed to resolve directory for {_pathValues[args[i]]}.");
                        Console.WriteLine($"Argument specified: {GetPathByID(args[i])}");
                        Console.WriteLine($"Result path: {fullPath}");
                        Console.WriteLine();
                        Console.WriteLine("Please check the specified arguments and try again.");
                        Console.WriteLine("Press any key to exit...");
                        Console.ReadKey(true);
                        Environment.Exit(-1);
                    }
                    args.RemoveAt(i);
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Path validation.
        /// </summary>
        /// <param name="args">Paths to check for integrity.</param>
        /// <param name="quitIfPathInvalid">Specify if program exit should be initiated if the path is invalid.</param>
        private static void ValidatePaths(ref List<PathID> args, bool quitIfPathInvalid)
        {
            for (int i = 0; i < args.Count; i++)
            {
                var fullPath = Path.GetFullPath(GetPathByID(args[i]));
                bool dirExists = Directory.Exists(fullPath) || File.Exists(fullPath);

                if (!dirExists && !quitIfPathInvalid)
                {
                    Console.WriteLine($"Path {fullPath} doesn't exist.");
                    Console.WriteLine("...Replacing with solution directory.");
                    Console.WriteLine();
                    UpdatePath(args[i]);
                }
                else if (!dirExists && quitIfPathInvalid)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine($"Failed to resolve directory for {_pathValues[args[i]]}.");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey(true);
                    Environment.Exit(-1);
                }
            }
        }

        private static string GetPathByID(PathID argID)
        {
            string path = string.Empty;

            if (argID == PathID.Input)
            {
                path = Program.Arguments.InputPath;
            }
            else if (argID == PathID.Output)
            {
                path = Program.Arguments.OutputPath;
            }
            else if (argID == PathID.Documentation)
            {
                path = Program.Arguments.DocumentationPath;
            }
            else if (argID == PathID.License)
            {
                path = Program.Arguments.LicenseFile;
            }

            return path;
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
