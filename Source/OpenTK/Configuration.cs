#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
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
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Reflection;

namespace OpenTK
{
    /// <summary>Provides information about the underlying OS and runtime.</summary>
    public static class Configuration
    {
        static bool runningOnWindows, runningOnUnix, runningOnX11, runningOnMacOS, runningOnLinux, runningOnMono;

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
                // Distinguish between Linux, Mac OS X and other Unix operating systems.
                string kernel_name = DetectUnixKernel();
                switch (kernel_name)
                {
                    case null:
                    case "":
                        throw new PlatformNotSupportedException(
                            "Unknown platform. Please file a bug report at http://www.opentk.com/node/add/project-issue/opentk");

                    case "Linux":
                        runningOnLinux = runningOnUnix = true;
                        break;

                    case "Darwin":
                        runningOnMacOS = runningOnUnix = true;
                        break;

                    default:
                        runningOnUnix = true;
                        break;
                }
            }
            else
                throw new PlatformNotSupportedException("Unknown platform. Please report this error at http://www.opentk.com.");

            // Detect whether X is present.
            // Hack: it seems that this check will cause X to initialize itself on Mac OS X Leopard and newer.
            // We don't want that (we'll be using the native interfaces anyway), so we'll avoid this check
            // when we detect Mac OS X.
            if (!RunningOnMacOS)
            {
                try { runningOnX11 = OpenTK.Platform.X11.API.DefaultDisplay != IntPtr.Zero; }
                catch { }
            }

            // Detect the Mono runtime (code taken from http://mono.wikia.com/wiki/Detecting_if_program_is_running_in_Mono).
            Type t = Type.GetType("Mono.Runtime");
            if (t != null)
                runningOnMono = true;
            
            Debug.Print("Detected configuration: {0} / {1}",
                RunningOnWindows ? "Windows" : RunningOnLinux ? "Linux" : RunningOnMacOS ? "MacOS" :
                runningOnUnix ? "Unix" : RunningOnX11 ? "X11" : "Unknown Platform",
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
        public static bool RunningOnX11
        {
            get { return runningOnX11; }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> indicating whether OpenTK is running on a Unix platform.
        /// </summary>
        public static bool RunningOnUnix
        {
            get { return runningOnUnix; }
        }

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
        /// Detects the unix kernel by p/invoking uname (libc).
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
