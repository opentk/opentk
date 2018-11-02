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
        /// Resolves the path in case of empty arguments and Ensures that the paths are configured properly.
        /// Should allow the user to manually build and execute the Binder from within the bin folder.
        /// </summary>
        public static void ResolvePath()
        {
            Console.WriteLine("Arguments were not found. Attempting to resolve");
            var fullPath = Path.GetFullPath(Program.Arguments.InputPath);
            bool dirExists = Directory.Exists(fullPath);

            if (!dirExists)
            {
                string solutionPath = fullPath.Substring(0, fullPath.IndexOf(@"src"));
                string InsertSolutionDir(string str) => str.Insert(0, solutionPath);

                Program.Arguments.InputPath = InsertSolutionDir(Program.Arguments.InputPath);
                Program.Arguments.OutputPath = InsertSolutionDir(Program.Arguments.OutputPath);
                Program.Arguments.DocumentationPath = InsertSolutionDir(Program.Arguments.DocumentationPath);
                Program.Arguments.LicenseFile = InsertSolutionDir(Program.Arguments.LicenseFile);

                fullPath = Path.GetFullPath(Program.Arguments.InputPath);
                dirExists = Directory.Exists(fullPath);

                if (!dirExists)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Failed to resolve path for binder.");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey(true);
                    Environment.Exit(-1);
                }

                Console.WriteLine("...Path successfully resolved.");
            }
        }
    }
}
