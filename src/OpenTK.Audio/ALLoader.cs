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
    public static unsafe class ALLoader
    {
        private static readonly OpenALLibraryNameContainer NameContainer = new OpenALLibraryNameContainer();

        private static readonly IntPtr ALHandle = NativeLibrary.Load(NameContainer.GetLibraryName());


        private static readonly unsafe delegate* unmanaged<ALCDevice, byte*, IntPtr> alcGetProcAddress;
        private static readonly unsafe delegate* unmanaged<byte*, IntPtr> alGetProcAddress;

        static ALLoader()
        {
            if (ALHandle == 0)
            {
                throw new DllNotFoundException($"Could not find OpenAL binaries (we looked for '{NameContainer.GetLibraryName()}')");
            }

            NativeLibrary.TryGetExport(ALHandle, "alcGetProcAddress", out IntPtr ptr);
            alcGetProcAddress = (delegate* unmanaged<ALCDevice, byte*, IntPtr>)ptr;

            NativeLibrary.TryGetExport(ALHandle, "alGetProcAddress", out ptr);
            alGetProcAddress = (delegate* unmanaged<byte*, IntPtr>)ptr;
        }

        // FIXME: This is bad as it only ever allows one device...
        // - Noggin_bops 2025-08-05
        public static ALCDevice Device;

        public static void SetALCDevice(ALCDevice device)
        {
            Device = device;
        }

        public static unsafe IntPtr ALCGetProcAddress(string procName)
        {
            byte* procNamePtr = (byte*)Marshal.StringToCoTaskMemUTF8(procName);
            IntPtr ret = alcGetProcAddress(Device, procNamePtr);
            Marshal.FreeCoTaskMem((IntPtr)procNamePtr);
            return ret;
        }

        public static unsafe IntPtr ALGetProcAddress(string procName)
        {
            byte* procNamePtr = (byte*)Marshal.StringToCoTaskMemUTF8(procName);
            IntPtr ret = alGetProcAddress(procNamePtr);
            Marshal.FreeCoTaskMem((IntPtr)procNamePtr);
            return ret;
        }
    }
}
