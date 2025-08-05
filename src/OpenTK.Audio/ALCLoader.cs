using OpenTK.Audio.OpenAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Audio
{
    // FIXME: Make a proper loader!
    public static unsafe class ALCLoader
    {
        private static readonly OpenALLibraryNameContainer NameContainer = new OpenALLibraryNameContainer();

        private static readonly IntPtr ALHandle = NativeLibrary.Load(NameContainer.GetLibraryName());

        public static ALCDevice Device;

        private static readonly unsafe delegate* unmanaged<ALCDevice, byte*, IntPtr> alcGetProcAddress;

        static unsafe ALCLoader()
        {
            if (ALHandle == 0)
            {
                throw new DllNotFoundException($"Could not find OpenAL binaries (we looked for '{NameContainer.GetLibraryName()}')");
            }

            NativeLibrary.TryGetExport(ALHandle, "alcGetProcAddress", out IntPtr ptr);
            alcGetProcAddress = (delegate* unmanaged<ALCDevice, byte*, IntPtr>)ptr;
        }

        public static unsafe IntPtr GetProcAddress(string procName)
        {
            if (NativeLibrary.TryGetExport(ALHandle, procName, out IntPtr ret) == false)
            {
                byte* procNamePtr = (byte*)Marshal.StringToCoTaskMemUTF8(procName);
                ret = alcGetProcAddress(Device, procNamePtr);
                Marshal.FreeCoTaskMem((IntPtr)procNamePtr);
            }
            return ret;
        }
    }
}
