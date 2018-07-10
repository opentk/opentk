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
        /// <summary>
        /// A zero-terminated character array that specifies the "friendly" name of the printer or display.
        /// </summary>
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string DeviceName;

        /// <summary>
        /// The version number of the initialization data specification on which the structure is based.
        /// The current version number is identified by <see cref="SPEC_VERSION"/>.
        /// </summary>
        [FieldOffset(64)]
        public WORD SpecVersion;

        /// <summary>
        /// For a printer, specifies the printer driver version number assigned by the printer driver developer.<para/>
        /// Display drivers can set this member to <see cref="SPEC_VERSION"/>.
        /// </summary>
        [FieldOffset(66)]
        public WORD DriverVersion;

        /// <summary>
        /// Specifies the size in bytes of the public DEVMODEW structure, not including any private,
        /// driver-specified members identified by the dmDriverExtra member.<para/>
        /// Set this to <see cref="SizeInBytes"/>.
        /// </summary>
        [FieldOffset(68)]
        public WORD Size;

        /// <summary>
        /// Specifies the number of bytes of private driver data that follow the public structure members.
        /// If a device driver does not provide private members, this member should be set to zero.
        /// </summary>
        [FieldOffset(70)]
        public WORD DriverExtra;

        /// <summary>
        /// Specifies bit flags identifying which of the following members are in use.
        /// For example, the <see cref="DeviceModeFieldFlags.Orientation"/> flag is set when the 
        /// <see cref="PrinterDeviceOptions.Orientation"/> member contains valid data.
        /// </summary>
        [FieldOffset(72)]
        public DeviceModeFieldFlags Fields;

        [FieldOffset(80)]
        public PrinterDeviceOptions PrinterOptions;

        [FieldOffset(80)]
        public Point Position;

        [FieldOffset(80)]
        public DisplayDeviceOptions DisplayOptions;

        /// <summary>
        /// For printers, specifies whether a color printer should print color or monochrome.
        /// </summary>
        [FieldOffset(96)]
        public PrinterColor Color;

        /// <summary>
        /// For printers, specifies duplex (double-sided) printing for duplex-capable printers.
        /// </summary>
        [FieldOffset(98)]
        public PrinterDuplex Duplex;

        /// <summary>
        /// For printers, specifies the y resolution of the printer, in DPI. If this member is used,
        /// the <see cref="PrinterDeviceOptions.PrintQuality"/> member specifies the x resolution.
        /// </summary>
        [FieldOffset(100)]
        public short YResolution;

        /// <summary>
        /// For printers, specifies how TrueType fonts should be printed.
        /// </summary>
        [FieldOffset(102)]
        public PrinterTrueTypeOption TrueTypeOption;

        /// <summary>
        /// For printers, specifies whether multiple copies should be collated.
        /// </summary>
        /// <remarks>
        /// This is a <see cref="short"/> in the windows API (and has pre-defined values for true (1) and false (0)), 
        /// but I abused this fact to represent this as a bool in our struct. Might have to be changed when
        /// there are more possible values than true and false.
        /// </remarks>
        [FieldOffset(104)]
        [MarshalAs(UnmanagedType.I2)]
        public bool Collate;

        /// <summary>
        /// For printers, specifies the name of the form to use; such as "Letter" or "Legal".
        /// This must be a name that can be obtain by calling the Win32 EnumForms function.
        /// </summary>
        [FieldOffset(106)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string FormName;

        /// <summary>
        /// For displays, specifies the number of logical pixels per inch of a display device and should be equal
        /// to the ulLogPixels member of the GDIINFO structure.
        /// </summary>
        [FieldOffset(170)]
        public WORD LogPixels;

        /// <summary>
        /// For displays, specifies the color resolution, in bits per pixel, of a display device.
        /// </summary>
        [FieldOffset(172)]
        public DWORD BitsPerPixel;

        /// <summary>
        /// For displays, specifies the width, in pixels, of the visible device surface.
        /// </summary>
        [FieldOffset(176)]
        public DWORD WidthInPixels;

        /// <summary>
        /// For displays, specifies the height, in pixels, of the visible device surface.
        /// </summary>
        [FieldOffset(180)]
        public DWORD HeightInPixels;

        /// <summary>
        /// For displays, specifies a display device's display mode.
        /// </summary>
        [FieldOffset(184)]
        public DWORD DisplayFlags; //todo: find enum type for this (docs don't show it >:[ )

        /// <summary>
        /// For printers, specifies whether the print system handles "N-up" printing
        /// (playing multiple EMF logical pages onto a single physical page).
        /// </summary>
        [FieldOffset(184)]
        public DWORD Nup;

        /// <summary>
        /// For displays, specifies the frequency, in hertz, of a display device in its current mode.
        /// </summary>
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

        /// <summary>
        /// Is reserved for system use and should be ignored by the driver.
        /// </summary>
        [FieldOffset(208)]
        public DWORD Reserved1;

        /// <summary>
        /// Is reserved for system use and should be ignored by the driver.
        /// </summary>
        [FieldOffset(212)]
        public DWORD Reserved2;

        /// <summary>
        /// Is reserved for system use and should be ignored by the driver.
        /// </summary>
        [FieldOffset(216)]
        public DWORD PanningWidth;

        /// <summary>
        /// Is reserved for system use and should be ignored by the driver.
        /// </summary>
        [FieldOffset(220)]
        public DWORD PanningHeight;


        public const WORD SPEC_VERSION = 800;

        /// <summary>
        /// The size of the structure in bytes.
        /// </summary>
        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<DeviceMode>();

        public struct PrinterDeviceOptions
        {
            /// <summary>
            /// For printers, specifies the paper orientation.
            /// </summary>
            public PrinterPaperOrientation Orientation;

            /// <summary>
            /// For printers, specifies the size of the paper to be printed on. This member must be zero if the length
            /// and width of the paper are specified by the <see cref="PaperLength"/> and <see cref="PaperWidth"/> 
            /// members.
            /// </summary>
            public PrinterPaperSize PaperSize;

            /// <summary>
            /// For printers, specifies the length of the paper, in units of 1/10 of a millimeter.
            /// This value overrides the length of the paper specified by the <see cref="PaperSize"/> member,
            /// and is used if the paper is of a custom size, or if the device is a dot matrix printer,
            /// which can print a page of arbitrary length.
            /// </summary>
            public short PaperLength;

            /// <summary>
            /// For printers, specifies the width of the paper, in units of 1/10 of a millimeter.
            /// This value overrides the width of the paper specified by the <see cref="PaperSize"/> member.
            /// This member must be used if <see cref="PaperLength"/> is used.
            /// </summary>
            public short PaperWidth;

            /// <summary>
            /// For printers, specifies the percentage by which the image is to be scaled for printing. The image's
            /// page size is scaled to the physical page by a factor of <see cref="Scale"/>/100. For example,
            /// a 17-inch by 22-inch image with a scale value of 100 requires 17x22-inch paper, while the same image
            /// with a scale value of 50 should print as half-sized and fit on letter-sized paper.
            /// </summary>
            public short Scale;

            /// <summary>
            /// For printers, specifies the number of copies to be printed, if the device supports multiple copies.
            /// </summary>
            public short Copies;

            /// <summary>
            /// For printers, specifies the printer's default input bin. If the specified constant is 
            /// <see cref="PrinterDefaultSource.FormSource"/>, the input bin should be selected automatically.
            /// </summary>
            public PrinterDefaultSource DefaultSource;

            /// <summary>
            /// For printers, specifies the printer resolution. Either set this to one of the 
            /// <see cref="PrinterPrintQuality"/> values, or use a positive value specifying the number of DPI for the
            /// x resolution, with the y resolution being specified by <see cref="YResolution"/>.
            /// </summary>
            public PrinterPrintQuality PrintQuality;
        }

        public struct DisplayDeviceOptions
        {
            /// <summary>
            /// For displays, specifies a <see cref="Point"/> structure containing the x- and y-coordinates of the
            /// upper-left corner of the display, in desktop coordinates. This member is used to determine the
            /// relative position of monitors in a multiple monitor environment.
            /// </summary>
            public Point Position;

            /// <summary>
            /// For displays, specifies the orientation at which images should be presented.
            /// </summary>
            public DisplayOrientation DisplayOrientation;

            /// <summary>
            /// For fixed-resolution displays, specifies how the device can present a lower-resolution mode on a
            /// higher-resolution display. For example, if a display device's resolution is fixed at 1024 X 768,
            /// and its mode is set to 640 x 480, the device can either display a 640 X 480 image within the 1024 X 768
            /// screen space, or stretch the 640 X 480 image to fill the larger screen space.
            /// </summary>
            public DisplayFixedOutputType DisplayFixedOutput;
        }
    }
}
