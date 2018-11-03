using System;
using System.Runtime.InteropServices;

namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Specifies characteristics of display and print devices.<para/>
    /// Before accessing a field, check the <see cref="Fields"/> field to determine whether any given field is set.
    /// </summary>
    [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
    public struct DeviceMode
    {
        /// <summary>
        /// Length of the <see cref="DeviceName"/> in characters.
        /// </summary>
        public const int DeviceNameLength = 32;

        /// <summary>
        /// Length of the <see cref="FormName"/> in characters.
        /// </summary>
        public const int FormNameLength = 32;

        /// <summary>
        /// Default value for <see cref="SpecVersion"/> and <see cref="DriverVersion"/> (see the documentation of those
        /// fields for more information).
        /// </summary>
        public const ushort DefaultSpecVersion = 800;

        /// <summary>
        /// A zero-terminated character array that specifies the "friendly" name of the printer or display.
        /// </summary>
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string DeviceName;

        /// <summary>
        /// The version number of the initialization data specification on which the structure is based.
        /// The current version number is identified by <see cref="DefaultSpecVersion"/>.
        /// </summary>
        [FieldOffset(64)]
        public ushort SpecVersion;

        /// <summary>
        /// For a printer, specifies the printer driver version number assigned by the printer driver developer.<para/>
        /// Display drivers can set this member to <see cref="DefaultSpecVersion"/>.
        /// </summary>
        [FieldOffset(66)]
        public ushort DriverVersion;

        /// <summary>
        /// Specifies the size in bytes of the public DEVMODEW structure, not including any private,
        /// driver-specified members identified by the dmDriverExtra member.<para/>
        /// Set this to <see cref="SizeInBytes"/>.
        /// </summary>
        [FieldOffset(68)]
        public ushort Size;

        /// <summary>
        /// Specifies the number of bytes of private driver data that follow the public structure members.
        /// If a device driver does not provide private members, this member should be set to zero.
        /// </summary>
        [FieldOffset(70)]
        public ushort DriverExtra;

        /// <summary>
        /// Specifies bit flags identifying which of the following members are in use.
        /// For example, the <see cref="DeviceModeFieldFlags.Orientation"/> flag is set when the
        /// <see cref="PrinterDeviceOptions.Orientation"/> member contains valid data.
        /// </summary>
        [FieldOffset(72)]
        public DeviceModeFieldFlags Fields;

        /// <summary>
        /// Provides printer-specific device mode options.
        /// </summary>
        [FieldOffset(76)]
        public PrinterDeviceOptions PrinterOptions;

        /// <summary>
        /// Provides display-specific device mode options.
        /// </summary>
        [FieldOffset(76)]
        public DisplayDeviceOptions DisplayOptions;

        /// <summary>
        /// For printers, specifies whether a color printer should print color or monochrome.
        /// </summary>
        [FieldOffset(92)]
        public PrinterColor Color;

        /// <summary>
        /// For printers, specifies duplex (double-sided) printing for duplex-capable printers.
        /// </summary>
        [FieldOffset(94)]
        public PrinterDuplex Duplex;

        /// <summary>
        /// For printers, specifies the y resolution of the printer, in DPI. If this member is used,
        /// the <see cref="PrinterDeviceOptions.PrintQuality"/> member specifies the x resolution.
        /// </summary>
        [FieldOffset(96)]
        public short YResolution;

        /// <summary>
        /// For printers, specifies how TrueType fonts should be printed.
        /// </summary>
        [FieldOffset(98)]
        public PrinterTrueTypeOption TrueTypeOption;

        /// <summary>
        /// For printers, specifies whether multiple copies should be collated. 1 == true, 0 == false.
        /// </summary>
        [FieldOffset(100)]
        public short Collate;

        /// <summary>
        /// Gets the name of the printer form to use; such as "Letter" or "Legal".
        /// This must be a name that can be obtain by calling the Win32 EnumForms function.
        /// </summary>
        public unsafe string FormName
        {
            get
            {
                fixed (char* formNamePtr = &_formName)
                {
                    return Marshal.PtrToStringUni((IntPtr)formNamePtr);
                }
            }
        }

        /// <summary>
        /// With the current struct layout (which is set in stone because of interoperability with the Windows API),
        /// there is no way to put a `string` type at this position(string is a reference type -> there is a pointer
        /// here, which is either 4 or 8 bytes depending on the platform). This means that a string can never be
        /// properly aligned at position 102 (which, again, can't be changed). This is why the <see cref="FormName"/>
        /// property exists.
        /// </summary>
        [FieldOffset(102)]
        private char _formName;

        /// <summary>
        /// For displays, specifies the number of logical pixels per inch of a display device and should be equal
        /// to the ulLogPixels member of the GDIINFO structure.
        /// </summary>
        [FieldOffset(166)]
        public ushort LogPixels;

        /// <summary>
        /// For displays, specifies the color resolution, in bits per pixel, of a display device.
        /// </summary>
        [FieldOffset(168)]
        public uint BitsPerPixel;

        /// <summary>
        /// For displays, specifies the width, in pixels, of the visible device surface.
        /// </summary>
        [FieldOffset(172)]
        public uint WidthInPixels;

        /// <summary>
        /// For displays, specifies the height, in pixels, of the visible device surface.
        /// </summary>
        [FieldOffset(176)]
        public uint HeightInPixels;

        /// <summary>
        /// For displays, specifies a display device's display mode.
        /// </summary>
        [FieldOffset(180)]
        public DisplayFlags DisplayFlags;

        /// <summary>
        /// For printers, specifies whether the print system handles "N-up" printing
        /// (playing multiple EMF logical pages onto a single physical page).
        /// </summary>
        [FieldOffset(180)]
        public uint Nup;

        /// <summary>
        /// For displays, specifies the frequency, in hertz, of a display device in its current mode.
        /// </summary>
        [FieldOffset(184)]
        public uint DisplayFrequency;

        /// <summary>
        /// For printers, specifies how Image Color Management (ICM) is handled. For a non-ICM application, this field
        /// determines if ICM is enabled or disabled. For ICM applications, the system examines this field to determine
        /// how to handle ICM support.<para/>
        /// The value of this field can be one of the pre-defined <see cref="PrinterIcmMethod"/> values or a printer
        /// driver-defined value greater than or equal to <see cref="PrinterIcmMethod.User"/>.
        /// </summary>
        [FieldOffset(188)]
        public PrinterIcmMethod IcmMethod;

        /// <summary>
        /// For printers, specifies which color matching method, or intent, is used by default. This field is primarily
        /// for non-ICM applications. ICM applications can establish intents by using the ICM functions.<para/>
        /// The value of this field can be one of the pre-defined <see cref="PrinterIcmIntent"/> values or a printer
        /// driver-defined value greater than or equal to <see cref="PrinterIcmIntent.User"/>.
        /// </summary>
        [FieldOffset(192)]
        public PrinterIcmIntent IcmIntent;

        /// <summary>
        /// For printers, specifies the type of media being printed on.<para/>
        /// The value of this field can be one of the pre-defined <see cref="PrinterMediaType"/> values or a printer
        /// driver-defined value greater than or equal to <see cref="PrinterMediaType.User"/>.
        /// </summary>
        [FieldOffset(196)]
        public PrinterMediaType MediaType;

        /// <summary>
        /// Specifies how dithering is to be done.<para/>
        /// The value of this field can be one of the pre-defined <see cref="PrinterDitherType"/> values or a printer
        /// driver-defined value greater than or equal to <see cref="PrinterDitherType.User"/>.
        /// </summary>
        [FieldOffset(200)]
        public PrinterDitherType DitherType;

        /// <summary>
        /// Is reserved for system use and must be zero.
        /// </summary>
        [FieldOffset(204)]
        public uint Reserved1;

        /// <summary>
        /// Is reserved for system use and must be zero.
        /// </summary>
        [FieldOffset(208)]
        public uint Reserved2;

        /// <summary>
        /// Must be zero.
        /// </summary>
        [FieldOffset(212)]
        public uint PanningWidth;

        /// <summary>
        /// Must be zero.
        /// </summary>
        [FieldOffset(216)]
        public uint PanningHeight;

        /// <summary>
        /// The size of the structure in bytes.
        /// </summary>
        public static readonly ushort SizeInBytes = (ushort)Marshal.SizeOf<DeviceMode>();

        /// <summary>
        /// Contains printer-specific device options.
        /// </summary>
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

        /// <summary>
        /// Contains display-specific device options.
        /// </summary>
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
