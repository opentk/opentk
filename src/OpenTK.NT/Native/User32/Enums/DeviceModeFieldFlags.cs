using System;

namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Used in the <see cref="DeviceMode"/> structure to specify whether certain members of the structure
    /// have been initialized.<para/>
    /// If a member is initialized, its corresponding bit is set, otherwise the bit is clear.
    /// A driver supports only those <see cref="DeviceMode"/> members that are appropriate for the
    /// printer or display technology.
    /// </summary>
    [Flags]
    public enum DeviceModeFieldFlags : uint
    {
        /// <summary>
        /// Specifies whether the <see cref="DeviceMode.PrinterDeviceOptions.Orientation"/> field is set.
        /// </summary>
        Orientation = 0x00000001,

        /// <summary>
        /// Specifies whether the <see cref="DeviceMode.PrinterDeviceOptions.PaperSize"/> field is set.
        /// </summary>
        PaperSize = 0x00000002,

        /// <summary>
        /// Specifies whether the <see cref="DeviceMode.PrinterDeviceOptions.PaperLength"/> field is set.
        /// </summary>
        PaperLength = 0x00000004,

        /// <summary>
        /// Specifies whether the <see cref="DeviceMode.PrinterDeviceOptions.PaperWidth"/> field is set.
        /// </summary>
        PaperWidth = 0x00000008,

        /// <summary>
        /// Specifies whether the <see cref="DeviceMode.PrinterDeviceOptions.Scale"/> field is set.
        /// </summary>
        Scale = 0x00000010,

        /// <summary>
        /// Specifies whether the <see cref="DeviceMode.DisplayDeviceOptions.Position"/> field is set.
        /// </summary>
        Position = 0x00000020,

        /// <summary>
        /// Specifies whether the <see cref="DeviceMode.Nup"/> field is set.
        /// </summary>
        Nup = 0x00000040,

        /// <summary>
        /// Specifies whether the <see cref="DeviceMode.DisplayDeviceOptions.DisplayOrientation"/> field is set.
        /// </summary>
        DisplayOrientation = 0x00000080,

        /// <summary>
        /// Specifies whether the <see cref="DeviceMode.PrinterDeviceOptions.Copies"/> field is set.
        /// </summary>
        Copies = 0x00000100,

        /// <summary>
        /// Specifies whether the <see cref="DeviceMode.PrinterDeviceOptions.DefaultSource"/> field is set.
        /// </summary>
        DefaultSource = 0x00000200,

        /// <summary>
        /// Specifies whether the <see cref="DeviceMode.PrinterDeviceOptions.PrintQuality"/> field is set.
        /// </summary>
        PrintQuality = 0x00000400,

        /// <summary>
        /// Specifies whether the <see cref="DeviceMode.Color"/> field is set.
        /// </summary>
        Color = 0x00000800,

        /// <summary>
        /// Specifies whether the <see cref="DeviceMode.Duplex"/> field is set.
        /// </summary>
        Duplex = 0x00001000,

        /// <summary>
        /// Specifies whether the <see cref="DeviceMode.YResolution"/> field is set.
        /// </summary>
        YResolution = 0x00002000,

        /// <summary>
        /// Specifies whether the <see cref="DeviceMode.TrueTypeOption"/> field is set.
        /// </summary>
        TrueTypeOption = 0x00004000,

        /// <summary>
        /// Specifies whether the <see cref="DeviceMode.Collate"/> field is set.
        /// </summary>
        Collate = 0x00008000,

        /// <summary>
        /// Specifies whether the <see cref="DeviceMode.FormName"/> field is set.
        /// </summary>
        FormName = 0x00010000,

        /// <summary>
        /// Specifies whether the <see cref="DeviceMode.LogPixels"/> field is set.
        /// </summary>
        LogPixels = 0x00020000,

        /// <summary>
        /// Specifies whether the <see cref="DeviceMode.BitsPerPixel"/> field is set.
        /// </summary>
        BitsPerPixel = 0x00040000,

        /// <summary>
        /// Specifies whether the <see cref="DeviceMode.WidthInPixels"/> field is set.
        /// </summary>
        WidthInPixels = 0x00080000,

        /// <summary>
        /// Specifies whether the <see cref="DeviceMode.HeightInPixels"/> field is set.
        /// </summary>
        HeightInPixels = 0x00100000,

        /// <summary>
        /// Specifies whether the <see cref="DeviceMode.DisplayFlags"/> field is set.
        /// </summary>
        DisplayFlags = 0x00200000,

        /// <summary>
        /// Specifies whether the <see cref="DeviceMode.DisplayFrequency"/> field is set.
        /// </summary>
        DisplayFrequency = 0x00400000,

        /// <summary>
        /// Specifies whether the <see cref="DeviceMode.IcmMethod"/> field is set.
        /// </summary>
        IcmMethod = 0x00800000,

        /// <summary>
        /// Specifies whether the <see cref="DeviceMode.IcmIntent"/> field is set.
        /// </summary>
        IcmIntent = 0x01000000,

        /// <summary>
        /// Specifies whether the <see cref="DeviceMode.MediaType"/> field is set.
        /// </summary>
        MediaType = 0x02000000,

        /// <summary>
        /// Specifies whether the <see cref="DeviceMode.DitherType"/> field is set.
        /// </summary>
        DitherType = 0x04000000,

        /// <summary>
        /// Specifies whether the <see cref="DeviceMode.PanningWidth"/> field is set.
        /// </summary>
        PanningWidth = 0x08000000,

        /// <summary>
        /// Specifies whether the <see cref="DeviceMode.PanningHeight"/> field is set.
        /// </summary>
        PanningHeight = 0x10000000,

        /// <summary>
        /// Specifies whether the <see cref="DeviceMode.DisplayDeviceOptions.DisplayFixedOutput"/> field is set.
        /// </summary>
        DisplayFixedOutput = 0x20000000,
    }
}
