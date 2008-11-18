#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;

[assembly: CLSCompliant(true)]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("OpenTK.Utilities")]

namespace OpenTK
{
    /// <summary>Provides information about the underlying OS and runtime.</summary>
    public static class Configuration
    {
        static bool runningOnWindows, runningOnX11, runningOnOSX, runningOnLinux, runningOnMono;

        #region --- Constructors ---

        // Detects the underlying OS and runtime.
        static Configuration()
        {
            if (System.Environment.OSVersion.Platform == PlatformID.Win32NT ||
                System.Environment.OSVersion.Platform == PlatformID.Win32S ||
                System.Environment.OSVersion.Platform == PlatformID.Win32Windows ||
                System.Environment.OSVersion.Platform == PlatformID.WinCE)
                runningOnWindows = true;
            else if (System.Environment.OSVersion.Platform == PlatformID.Unix ||
                     System.Environment.OSVersion.Platform == (PlatformID)4)
            {
                // Distinguish between Unix and Mac OS X kernels.
                switch (DetectUnixKernel())
                {
                    case "Unix":
                        runningOnX11 = true;
                        break;

                    case "Linux":
                        runningOnLinux = runningOnX11 = true;
                        break;

                    case "Darwin":
                        runningOnOSX = true;
                        break;

                    default:
                        throw new PlatformNotSupportedException(
                            DetectUnixKernel() + ": Unknown Unix platform. Please report this error at http://www.opentk.com.");
                }
            }
            else
                throw new PlatformNotSupportedException("Unknown platform. Please report this error at http://www.opentk.com.");

            // Detect the Mono runtime (code taken from http://mono.wikia.com/wiki/Detecting_if_program_is_running_in_Mono).
            Type t = Type.GetType("Mono.Runtime");
            if (t != null)
                runningOnMono = true;
        }

        #endregion

        #region --- Public Methods ---

        #region public static bool RunningOnWindows

        /// <summary>Gets a System.Boolean indicating whether OpenTK is running on a Windows platform.</summary>
        public static bool RunningOnWindows { get { return runningOnWindows; } }

        #endregion

        #region public static bool  RunningOnX11

        /// <summary>Gets a System.Boolean indicating whether OpenTK is running on an X11 platform.</summary>
        public static bool RunningOnX11 { get { return runningOnX11; } }

        #endregion

        #region public static bool RunningOnLinux

        /// <summary>Gets a System.Boolean indicating whether OpenTK is running on an X11 platform.</summary>
        public static bool RunningOnLinux { get { return runningOnLinux; } }

        #endregion

        #region public static bool  RunningOnOSX

        /// <summary>Gets a System.Boolean indicating whether OpenTK is running on a MacOS platform.</summary>
        public static bool RunningOnOSX { get { return runningOnOSX; } }

        #endregion

        #region public static bool RunningOnMono

        /// <summary>
        /// Gets a System.Boolean indicating whether OpenTK is running on the Mono runtime.
        /// </summary>
        public static bool RunningOnMono { get { return runningOnMono; } }

        #endregion

        #region --- Private Methods ---

        #region private static string DetectUnixKernel()

        // <summary>
        // Executes "uname" which returns a string representing the name of the
        // underlying Unix kernel.
        // </summary>
        // <returns>"Unix", "Linux", "Darwin" or null.</returns>
        // <remarks>Source code from "Mono: A Developer's Notebook"</remarks>
        private static string DetectUnixKernel()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.Arguments = "-s";
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;
            foreach (string unameprog in new string[] { "/usr/bin/uname", "/bin/uname", "uname" })
            {
                try
                {
                    startInfo.FileName = unameprog;
                    Process uname = Process.Start(startInfo);
                    StreamReader stdout = uname.StandardOutput;
                    return stdout.ReadLine().Trim();
                }
                catch (System.IO.FileNotFoundException)
                {
                    // The requested executable doesn't exist, try next one.
                    continue;
                }
                catch (System.ComponentModel.Win32Exception)
                {
                    continue;
                }
            }
            return null;
        }

        #endregion

        #endregion

        #endregion
    }
}
