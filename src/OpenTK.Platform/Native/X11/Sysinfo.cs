using System.Runtime.InteropServices;

namespace OpenTK.Platform.Native.X11
{
    internal static class Sysinfo
    {
        // Only valid since Linux 2.3.48
        internal unsafe struct sysinfo_struct {
            public long uptime;             /* Seconds since boot */
            public nuint loads0;  /* 1, 5, and 15 minute load averages */
            public nuint loads1;  /* 1, 5, and 15 minute load averages */
            public nuint loads2;  /* 1, 5, and 15 minute load averages */
            public nuint totalram;  /* Total usable main memory size */
            public nuint freeram;   /* Available memory size */
            public nuint sharedram; /* Amount of shared memory */
            public nuint bufferram; /* Memory used by buffers */
            public nuint totalswap; /* Total swap space size */
            public nuint freeswap;  /* Swap space still available */
            public ushort procs;    /* Number of current processes */
            public nuint totalhigh; /* Total high memory size */
            public nuint freehigh;  /* Available high memory size */
            public int mem_unit;    /* Memory unit size in bytes */
            // FIXME: This is not correct!! sizeof(long) translates to sizeof(nint) in c# which can't be put in the fixed expression.
            //public fixed byte _f[20 - 2 * sizeof(ulong) - sizeof(int)];
            /* Padding to 64 bytes */
        }

        [DllImport("libc", SetLastError = true)]
        internal static extern int sysinfo(out sysinfo_struct info);

        [DllImport("libc")]
        internal static unsafe extern byte* strerror(int errnum);
    }
}
