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
using System.Runtime.InteropServices;

[assembly: CLSCompliant(true)]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("OpenTK.Utilities")]

namespace OpenTK
{
    /// <summary>Provides information about the underlying OS and runtime.</summary>
    public static class Configuration
    {
        static bool runningOnWindows, runningOnX11, runningOnMacOS, runningOnLinux, runningOnMono;

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
                        runningOnMacOS = true;
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

            Debug.Print("Detected configuration: {0} / {1}",
                RunningOnWindows ? "Windows" : RunningOnLinux ? "Linux" : RunningOnMacOS ? "MacOS" : RunningOnX11 ? "X11" : "Unknown Platform",
                RunningOnMono ? "Mono" : ".Net");
        }

        #endregion

        #region --- Public Methods ---

        #region public static bool RunningOnWindows

        /// <summary>Gets a System.Boolean indicating whether OpenTK is running on a Windows platform.</summary>
        public static bool RunningOnWindows { get { return runningOnWindows; } }

        #endregion

        #region public static bool RunningOnX11

        /// <summary>Gets a System.Boolean indicating whether OpenTK is running on an X11 platform.</summary>
        public static bool RunningOnX11 { get { return runningOnX11; } }

        #endregion

        #region public static bool RunningOnLinux

        /// <summary>Gets a System.Boolean indicating whether OpenTK is running on an X11 platform.</summary>
        public static bool RunningOnLinux { get { return runningOnLinux; } }

        #endregion

        #region public static bool RunningOnMacOS

        /// <summary>Gets a System.Boolean indicating whether OpenTK is running on a MacOS platform.</summary>
        public static bool RunningOnMacOS { get { return runningOnMacOS; } }

        #endregion

        #region public static bool RunningOnMono

        /// <summary>
        /// Gets a System.Boolean indicating whether OpenTK is running on the Mono runtime.
        /// </summary>
        public static bool RunningOnMono { get { return runningOnMono; } }

        #endregion

        #region --- Private Methods ---

        #region private static string DetectUnixKernel()

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        struct utsname
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string sysname;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string nodename;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string release;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string version;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string machine;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1024)]
            public string extraJustInCase;

        }

        /// <summary>
        /// Detects the unix kernel by p/invoking the uname call in libc.
        /// </summary>
        /// <returns></returns>
        private static string DetectUnixKernel()
        {
            Debug.Print("Size: {0}", Marshal.SizeOf(typeof(utsname)).ToString());
            Debug.Flush();
            utsname uts = new utsname();
            uname(out uts);

            Debug.WriteLine("System:");
            Debug.Indent();
            Debug.WriteLine(uts.sysname);
            Debug.WriteLine(uts.nodename);
            Debug.WriteLine(uts.release);
            Debug.WriteLine(uts.version);
            Debug.WriteLine(uts.machine);
            Debug.Unindent();

            return uts.sysname.ToString();
        }

        [DllImport("libc")]
        private static extern void uname(out utsname uname_struct);

        #endregion

        #endregion

        #endregion
    }
}
