using System;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.Native.macOS
{
#pragma warning disable CS0649
    struct vm_statistics
    {
        public uint free_count;
        public uint active_count;
        public uint inactive_count;
        public uint wire_count;
        public uint zero_fill_count;
        public uint reactivations;
        public uint pageins;
        public uint pageouts;
        public uint faults;
        public uint cow_faults;
        public uint lookups;
        public uint hits;

        // rev1
        public uint purgable_count;
        public uint purges;

        // rev2
        public uint speculative;
    }

    // FIXME: Needs to be 8 bytes aligned.
    struct vm_statistics64
    {
        public uint free_count;
        public uint active_count;
        public uint inactive_count;
        public uint wire_count;
        public ulong zero_fill_count;
        public ulong reactivations;
        public ulong pageins;
        public ulong pageouts;
        public ulong faults;
        public ulong cow_faults;
        public ulong lookups;
        public ulong hits;
        public ulong purges;
        public uint purgable_count;
        public uint speculative_count;

        // rev1
        public ulong decompressions;
        public ulong compressions;
        public ulong swapins;
        public ulong swapouts;
        public uint compressor_page_count;
        public uint throttled_count;
        public uint external_page_count;
        public uint internal_page_count;
        public ulong total_uncompressed_pages_in_compressor;
    }


    internal static class Mach
    {
        internal const int KERN_SUCCESS = 0;

        // FIXME: Make into enum.
        internal const int /* host_flavor_t */ HOST_LOAD_INFO = 1;
        internal const int /* host_flavor_t */ HOST_VM_INFO = 2;
        internal const int /* host_flavor_t */ HOST_CPU_LOAD_INFO = 3;

        internal static readonly unsafe uint HOST_VM_INFO_COUNT = (uint)sizeof(vm_statistics) / sizeof(uint);
        internal static readonly unsafe uint HOST_VM_INFO64_COUNT = (uint)sizeof(vm_statistics64) / sizeof(uint);


        [DllImport("libSystem")]
        internal static extern int /* kern_return_t */ host_statistics(IntPtr /* host_t */ host_priv, int /* host_flavor_t */ flavor, out vm_statistics /* host_info_t */ host_info_out, ref uint /* mach_msg_type_number_t */ host_info_outCnt);

        [DllImport("libSystem")]
        internal static extern int /* kern_return_t */ host_statistics64(IntPtr /* host_t */ host_priv, int /* host_flavor_t */ flavor, out vm_statistics64 /* host_info_t */ host_info_out, ref uint /* mach_msg_type_number_t */ host_info_outCnt);

        [DllImport("libSystem")]
        internal static extern IntPtr /* mach_port_t */ mach_host_self();

        [DllImport("libSystem")]
        internal static extern int /* kern_return_t */ host_page_size(IntPtr /* host_t */ host, out nuint /* vm_size_t */ out_page_size);
    }
#pragma warning restore CS0649
}

