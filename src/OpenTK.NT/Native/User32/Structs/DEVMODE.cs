using System.Runtime.InteropServices;

namespace OpenTK.NT.Native
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public class DEVMODE
    {
        internal int BitsPerPel;
        internal short Collate;

        internal short Color;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        internal string DeviceName;

        internal int DisplayFixedOutput;
        internal int DisplayFlags;
        internal int DisplayFrequency;
        internal int DisplayOrientation;
        internal int DitherType;
        internal short DriverExtra;
        internal short DriverVersion;
        internal short Duplex;
        internal int Fields;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        internal string FormName;

        internal int ICMIntent;
        internal int ICMMethod;
        internal short LogPixels;
        internal int MediaType;
        internal int PanningHeight;
        internal int PanningWidth;
        internal int PelsHeight;
        internal int PelsWidth;

        //internal short Orientation;
        //internal short PaperSize;
        //internal short PaperLength;
        //internal short PaperWidth;
        //internal short Scale;
        //internal short Copies;
        //internal short DefaultSource;
        //internal short PrintQuality;

        internal POINT Position;
        internal int Reserved1;
        internal int Reserved2;
        private short Size;
        internal short SpecVersion;
        internal short TTOption;
        internal short YResolution;

        internal DEVMODE()
        {
            Size = (short)Marshal.SizeOf(this);
        }
    }
}
