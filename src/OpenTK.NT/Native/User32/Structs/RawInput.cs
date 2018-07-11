using System.Runtime.InteropServices;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// Contains the raw input from a device.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct RawInput
    {
        /// <summary>
        /// The raw input data.
        /// </summary>
        public RawInputHeader Header;

        /// <summary>
        /// Contains device-specific raw input data.
        /// </summary>
        public RawInputData Data;

        /// <summary>
        /// The size of this structure in bytes.
        /// </summary>
        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<RawInput>();
    }
}
