using System.Runtime.InteropServices;

using DWORD = System.UInt32;
using WORD = System.UInt16;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// Specifies characteristics of display and print devices.
    /// </summary>
    [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
    public struct DeviceMode
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string DeviceName;

        [FieldOffset(64)]
        public WORD SpecVersion;

        [FieldOffset(66)]
        public WORD DriverVersion;

        [FieldOffset(68)]
        public WORD Size;

        [FieldOffset(70)]
        public WORD DriverExtra;

        [FieldOffset(72)]
        public DeviceModeFieldFlags Fields;

        [FieldOffset(80)]
        public PrinterDeviceOptions PrinterOptions;

        [FieldOffset(80)]
        public Point Position;

        [FieldOffset(80)]
        public DisplayDeviceOptions DisplayOptions;

        [FieldOffset(96)]
        public short Color;

        [FieldOffset(98)]
        public short Duplex;

        [FieldOffset(100)]
        public short YResolution;

        [FieldOffset(102)]
        public short TTOption;

        [FieldOffset(104)]
        public short Collate;

        [FieldOffset(106)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string FormName;

        [FieldOffset(170)]
        public WORD LogPixels;

        [FieldOffset(172)]
        public DWORD BitsPerPel;

        [FieldOffset(176)]
        public DWORD PelsWidth;

        [FieldOffset(180)]
        public DWORD PelsHeight;

        [FieldOffset(184)]
        public DWORD DisplayFlags;

        [FieldOffset(184)]
        public DWORD Nup;

        [FieldOffset(188)]
        public DWORD DisplayFrequency;

        [FieldOffset(192)]
        public DWORD ICMMethod;

        [FieldOffset(196)]
        public DWORD ICMIntent;

        [FieldOffset(200)]
        public DWORD MediaType;

        [FieldOffset(204)]
        public DWORD DitherType;

        [FieldOffset(208)]
        public DWORD Reserved1;

        [FieldOffset(212)]
        public DWORD Reserved2;

        [FieldOffset(216)]
        public DWORD PanningWidth;

        [FieldOffset(220)]
        public DWORD PanningHeight;

        /// <summary>
        /// The size of the structure in bytes.
        /// </summary>
        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<DeviceMode>();

        public struct PrinterDeviceOptions
        {
            public short Orientation;
            public short PaperSize;
            public short PaperLength;
            public short PaperWidth;
            public short Scale;
            public short Copies;
            public short DefaultSource;
            public short PrintQuality;
        }

        public struct DisplayDeviceOptions
        {
            public Point Position;
            public DWORD DisplayOrientation;
            public DWORD DisplayFixedOutput;
        }
    }
}
