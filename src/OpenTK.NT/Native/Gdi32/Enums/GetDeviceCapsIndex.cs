namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Used in <see cref="Gdi32.GetDeviceCaps(System.IntPtr, GetDeviceCapsIndex)"/> to specify the type of
    /// information to retrieve for the specified device.
    /// </summary>
    public enum GetDeviceCapsIndex
    {
        /// <summary>
        /// The device driver version.
        /// </summary>
        DriverVersion = 0,

        /// <summary>
        /// Device technology.
        /// </summary>
        Technology = 2,

        /// <summary>
        /// Width, in millimeters, of the physical screen.
        /// </summary>
        HorizontalSize = 3,

        /// <summary>
        /// Height, in millimeters, of the physical screen.
        /// </summary>
        VerticalSize = 6,

        /// <summary>
        /// Width, in pixels, of the screen; or for printers, the width, in pixels, of the printable area of the page.
        /// </summary>
        HorizontalResolution = 8,

        /// <summary>
        /// Height, in raster lines, of the screen; or for printers, the height, in pixels,
        /// of the printable area of the page.
        /// </summary>
        VerticalResolution = 10,

        /// <summary>
        /// Number of pixels per logical inch along the screen width.
        /// In a system with multiple display monitors, this value is the same for all monitors.
        /// </summary>
        LogicalPixelsX = 88,

        /// <summary>
        /// Number of pixels per logical inch along the screen height.
        /// In a system with multiple display monitors, this value is the same for all monitors.
        /// </summary>
        LogicalPixelsY = 90,

        /// <summary>
        /// Number of adjacent color bits for each pixel.
        /// </summary>
        BitsPerPixel = 12,

        /// <summary>
        /// Number of color planes.
        /// </summary>
        Planes = 14,

        /// <summary>
        /// Number of device-specific brushes.
        /// </summary>
        NumberOfBrushes = 16,

        /// <summary>
        /// Number of device-specific pens.
        /// </summary>
        NumberOfPens = 18,

        /// <summary>
        /// Number of device-specific fonts.
        /// </summary>
        NumberOfFonts = 22,

        /// <summary>
        /// Number of entries in the device's color table, if the device has a color depth of no more than
        /// 8 bits per pixel. For devices with greater color depths, 1 is returned.
        /// </summary>
        NumberOfColors = 24,

        /// <summary>
        /// Relative width of a device pixel used for line drawing.
        /// </summary>
        AspectX = 40,

        /// <summary>
        /// Relative height of a device pixel used for line drawing.
        /// </summary>
        AspectY = 42,

        /// <summary>
        /// Diagonal width of the device pixel used for line drawing.
        /// </summary>
        AspectXY = 44,

        /// <summary>
        /// Reserved.
        /// </summary>
        PDeviceSize = 26,

        /// <summary>
        /// Flag that indicates the clipping capabilities of the device.
        /// If the device can clip to a rectangle, it is 1. Otherwise, it is 0.
        /// </summary>
        ClippingCapabilities = 36,

        /// <summary>
        /// Number of entries in the system palette. This index is valid only if the device driver sets the RC_PALETTE
        /// bit in the RASTERCAPS index and is available only if the driver is compatible with 16-bit Windows.
        /// </summary>
        SizePalette = 104,

        /// <summary>
        /// Number of reserved entries in the system palette.
        /// This index is valid only if the device driver sets the RC_PALETTE bit
        /// in the RASTERCAPS index and is available only if the driver is compatible with 16-bit Windows.
        /// </summary>
        NumberOfReserved = 106,

        /// <summary>
        /// Actual color resolution of the device, in bits per pixel.
        /// This index is valid only if the device driver sets the RC_PALETTE bit in
        /// the RASTERCAPS index and is available only if the driver is compatible with 16-bit Windows.
        /// </summary>
        ColorResolution = 108,

        /// <summary>
        /// For printing devices: the width of the physical page, in device units. For example, a printer set to print
        /// at 600 dpi on 8.5-x11-inch paper has a physical width value of 5100 device units. Note that the physical
        /// page is almost always greater than the printable area of the page, and never smaller.
        /// </summary>
        PhysicalWidth = 110,

        /// <summary>
        /// For printing devices: the height of the physical page, in device units. For example, a printer set to print
        /// at 600 dpi on 8.5-by-11-inch paper has a physical height value of 6600 device units. Note that the physical
        /// page is almost always greater than the printable area of the page, and never smaller.
        /// </summary>
        PhysicalHeight = 111,

        /// <summary>
        /// For printing devices: the distance from the left edge of the physical page to the left edge
        /// of the printable area, in device units. For example, a printer set to print at 600 dpi on
        /// 8.5-by-11-inch paper, that cannot print on the leftmost 0.25-inch of paper,
        /// has a horizontal physical offset of 150 device units.
        /// </summary>
        PhysicalOffsetX = 112,

        /// <summary>
        /// For printing devices: the distance from the top edge of the physical page to the top edge
        /// of the printable area, in device units. For example, a printer set to print at 600 dpi on
        /// 8.5-by-11-inch paper, that cannot print on the topmost 0.5-inch of paper,
        /// has a vertical physical offset of 300 device units.
        /// </summary>
        PhysicalOffsetY = 113,

        /// <summary>
        /// For display devices: the current vertical refresh rate of the device, in cycles per second (Hz).<para/>
        /// A vertical refresh rate value of 0 or 1 represents the display hardware's default refresh rate.
        /// This default rate is typically set by switches on a display card or computer motherboard,
        /// or by a configuration program that does not use display functions such as
        /// <see cref="User32.DeviceContext.ChangeDisplaySettings"/>.
        /// </summary>
        VRefreshRate = 116,

        /// <summary>
        /// Scaling factor for the x-axis of the printer.
        /// </summary>
        ScalingFactorX = 114,

        /// <summary>
        /// Scaling factor for the y-axis of the printer.
        /// </summary>
        ScalingFactorY = 115,

        /// <summary>
        /// Preferred horizontal drawing alignment, expressed as a multiple of pixels.
        /// For best drawing performance, windows should be horizontally aligned to a multiple of this value.
        /// A value of zero indicates that the device is accelerated, and any alignment may be used.
        /// </summary>
        BltAlignment = 119,

        /// <summary>
        /// Value that indicates the shading and blending capabilities of the device.
        /// Only supported on XP and higher.
        /// </summary>
        ShadingBlendingCapabilities = 120,

        /// <summary>
        /// Value that indicates the raster capabilities of the device.
        /// </summary>
        RasterCapabilities = 38,

        /// <summary>
        /// Value that indicates the curve capabilities of the device.
        /// </summary>
        CurveCapabilities = 28,

        /// <summary>
        /// Value that indicates the line capabilities of the device.
        /// </summary>
        LineCapabilities = 30,

        /// <summary>
        /// Value that indicates the polygon capabilities of the device.
        /// </summary>
        PolygonalCapabilities = 32,

        /// <summary>
        /// Value that indicates the text capabilities of the device.
        /// </summary>
        TextCapabilities = 34,

        /// <summary>
        /// Value that indicates the color management capabilities of the device.
        /// Only supported on XP and higher.
        /// </summary>
        ColorManagementCapabilities = 121
    }
}
