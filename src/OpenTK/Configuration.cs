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

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace OpenTK
{
    /// <summary>
    /// Provides information about the underlying OS and runtime.
    /// You must call <c>Toolkit.Init</c> before accessing members
    /// of this class.
    /// </summary>
    public sealed class Configuration
    {
        private static bool runningOnUnix, runningOnMacOS, runningOnLinux;
        private volatile static bool initialized;
        private readonly static object InitLock = new object();

        private Configuration() { }

        /// <summary>Gets a System.Boolean indicating whether OpenTK is running on a Windows platform.</summary>
        public static bool RunningOnWindows { get; private set; }

        /// <summary>Gets a System.Boolean indicating whether OpenTK is running on an X11 platform.</summary>
        public static bool RunningOnX11 { get; private set; }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> indicating whether OpenTK is running on a Unix platform.
        /// </summary>
        public static bool RunningOnUnix
        {
            get { return runningOnUnix; }
        }

        /// <summary>
        /// Gets a System.Boolean indicating whether OpenTK is running on the SDL2 backend.
        /// </summary>
        public static bool RunningOnSdl2
        {
            get;
            private set;
        }

        /// <summary>Gets a System.Boolean indicating whether OpenTK is running on the Linux kernel.</summary>
        public static bool RunningOnLinux { get { return runningOnLinux; } }

        /// <summary>Gets a System.Boolean indicating whether OpenTK is running on a MacOS platform.</summary>
        public static bool RunningOnMacOS { get { return runningOnMacOS; } }

        /// <summary>
        /// Gets a System.Boolean indicating whether OpenTK is running on the Mono runtime.
        /// </summary>
        public static bool RunningOnMono { get; private set; }

        /// <summary>
        /// Gets a <c>System.Boolean</c> indicating whether
        /// OpenTK is running on an Android device.
        /// </summary>
        public static bool RunningOnAndroid
        {
            get
            {
#if ANDROID
                return true;
#else
                return false;
#endif
            }
        }

        /// <summary>
        /// Gets a <c>System.Boolean</c> indicating whether
        /// OpenTK is running on an Android device.
        /// </summary>
        public static bool RunningOnIOS
        {
            get
            {
#if IPHONE
                return true;
#else
                return false;
#endif
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        private struct utsname
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

        private static bool DetectMono()
        {
            // Detect the Mono runtime (code taken from http://mono.wikia.com/wiki/Detecting_if_program_is_running_in_Mono).
            Type t = Type.GetType("Mono.Runtime");
            return t != null;
        }

        #if SDL2
        private static bool DetectSdl2()
        {
            bool supported = false;

            // Detect whether SDL2 is supported
            // We require:
            // - SDL2 version 2.0.0 or higher (previous beta
            //   versions are not ABI-compatible)
            // - Successful SDL2 initialization (sometimes the
            //   binary exists but fails to initialize correctly)
            var version = new Platform.SDL2.Version();
            try
            {
                version = Platform.SDL2.SDL.Version;
                    if (version.Number >= 2000)
                {
                    if (Platform.SDL2.SDL.WasInit(0))
                    {
                        supported = true;
                    }
                    else
                    {
                        // Attempt to initialize SDL2.
                        var flags =
                            Platform.SDL2.SystemFlags.VIDEO |
                            Platform.SDL2.SystemFlags.TIMER;

                        if (Platform.SDL2.SDL.Init(flags) == 0)
                        {
                            supported = true;
                        }
                        else
                        {
                            Debug.Print("SDL2 init failed with error: {0}",
                                Platform.SDL2.SDL.GetError());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Debug.Print("SDL2 init failed with exception: {0}", e);
            }

            if (!supported)
            {
                Debug.Print("SDL2 is not supported");
            }
            else
            {
                Debug.Print("SDL2 is supported. Version is {0}.{1}.{2}",
                    version.Major, version.Minor, version.Patch);
            }

            return supported;
        }
        #endif

        private static void DetectUnix(out bool unix, out bool linux, out bool macos)
        {
            unix = linux = macos = false;

            string kernel_name = DetectUnixKernel();
            switch (kernel_name)
            {
                case null:
                case "":
                    throw new PlatformNotSupportedException(
                        "Unknown platform. Please file a bug report at https://github.com/opentk/opentk/issues");

                case "Linux":
                    linux = unix = true;
                    break;

                case "Darwin":
                    macos = unix = true;
                    break;

                default:
                    unix = true;
                    break;
            }
        }

        private static bool DetectWindows()
        {
            return
                System.Environment.OSVersion.Platform == PlatformID.Win32NT ||
                System.Environment.OSVersion.Platform == PlatformID.Win32S ||
                System.Environment.OSVersion.Platform == PlatformID.Win32Windows ||
                System.Environment.OSVersion.Platform == PlatformID.WinCE;
        }

        private static bool DetectX11()
        {
            #if X11
            // Detect whether X is present.
            try { return OpenTK.Platform.X11.API.DefaultDisplay != IntPtr.Zero; }
            catch { return false; }
            #else
            return false;
            #endif
        }

        // Detects the underlying OS and runtime.
        internal static void Init(ToolkitOptions options)
        {
            lock (InitLock)
            {
                if (!initialized)
                {
#if ANDROID || IPHONE
                    RunningOnMono = true;
#else
                    RunningOnMono = DetectMono();
                    RunningOnWindows = DetectWindows();
                    if (!RunningOnWindows)
                    {
                        DetectUnix(out runningOnUnix, out runningOnLinux, out runningOnMacOS);
                    }

                    if (options.Backend == PlatformBackend.Default)
                    {
                        RunningOnSdl2 = DetectSdl2();
                    }

                    if ((runningOnLinux && !RunningOnSdl2) || options.Backend == PlatformBackend.PreferX11)
                    {
                        RunningOnX11 = DetectX11();
                    }

                    initialized = true;
#endif
                    Debug.Print("Detected configuration: {0} / {1}",
                        RunningOnWindows ? "Windows" : RunningOnLinux ? "Linux" : RunningOnMacOS ? "MacOS" :
                        runningOnUnix ? "Unix" : RunningOnX11 ? "X11" : "Unknown Platform",
                        RunningOnMono ? "Mono" : ".Net");
                }
            }
        }
    }
}
