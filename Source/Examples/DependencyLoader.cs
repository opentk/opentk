using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using OpenTK;

namespace Examples
{
    class DependencyLoader : IDisposable
    {
        bool disposed;
        readonly List<IntPtr> LoadedLibraries = new List<IntPtr>();

        enum TargetCpu
        {
            x86,
            x86_64,
        }

        static readonly TargetCpu Cpu = IntPtr.Size == 4 ? TargetCpu.x86 : TargetCpu.x86_64;

        public void LoadDependencies()
        {
            string path = Path.Combine("Dependencies", Cpu == TargetCpu.x86 ? "x86" : "x64");

            if (Directory.Exists(path))
            {
                if (Configuration.RunningOnWindows)
                {
                    foreach (var file in Directory.GetFiles(path, "*.dll"))
                    {
                        IntPtr lib = NativeMethods.LoadLibrary(file);
                        if (lib == IntPtr.Zero)
                        {
                            Debug.Print("Failed to load dependency {0} with {1}", file,
                                Marshal.GetLastWin32Error());
                        }
                        else
                        {
                            LoadedLibraries.Add(lib);
                            Debug.Print("Loaded dependency {0}", file);
                        }
                    }
                }
            }
        }

        static class NativeMethods
        {
            [DllImport("kernel32.dll", SetLastError = true)]
            internal static extern IntPtr LoadLibrary(string dllName);

            [DllImport("kernel32.dll", SetLastError = true)]
            internal static extern int FreeLibrary(IntPtr dll);
        }

        #region IDisposable Members

        void Dispose(bool manual)
        {
            if (!disposed)
            {
                if (manual)
                {
                    foreach (var lib in LoadedLibraries)
                    {
                        NativeMethods.FreeLibrary(lib);
                    }
                }

                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~DependencyLoader()
        {
            Dispose(false);
        }

        #endregion
    }
}
