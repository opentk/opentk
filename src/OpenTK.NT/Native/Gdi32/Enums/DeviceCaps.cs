namespace OpenTK.NT.Native
{
    public enum GetDeviceCapsIndex
    {
        /// <summary>
        /// The device driver version.
        /// </summary>
        DRIVERVERSION = 0,

        /// <summary>
        /// Device technology.
        /// </summary>
        TECHNOLOGY = 2,

        /// <summary>
        /// Width, in millimeters, of the physical screen.
        /// </summary>
        HORZSIZE = 3,

        /// <summary>
        /// Height, in millimeters, of the physical screen.
        /// </summary>
        VERTSIZE = 6,

        /// <summary>
        /// Width, in pixels, of the screen; or for printers, the width, in pixels, of the printable area of the page.
        /// </summary>
        HORZRES = 8,

        /// <summary>
        /// Height, in raster lines, of the screen; or for printers, the height, in pixels, of the printable area of the page.
        /// </summary>
        VERTRES = 10,

        /// <summary>
        /// Number of pixels per logical inch along the screen width.
        /// In a system with multiple display monitors, this value is the same for all monitors.
        /// </summary>
        LOGPIXELSX = 88,

        /// <summary>
        /// Number of pixels per logical inch along the screen height. 
        /// In a system with multiple display monitors, this value is the same for all monitors.
        /// </summary>
        LOGPIXELSY = 90,

        /// <summary>
        /// Number of adjacent color bits for each pixel.
        /// </summary>
        BITSPIXEL = 12,

        /// <summary>
        /// Number of color planes.
        /// </summary>
        PLANES = 14,

        /// <summary>
        /// Number of device-specific brushes.
        /// </summary>
        NUMBRUSHES = 16,

        /// <summary>
        /// Number of device-specific pens.
        /// </summary>
        NUMPENS = 18,

        /// <summary>
        /// Number of device-specific fonts.
        /// </summary>
        NUMFONTS = 22,

        /// <summary>
        /// Number of entries in the device's color table, if the device has a color depth of no more than
        /// 8 bits per pixel. For devices with greater color depths, 1 is returned.
        /// </summary>
        NUMCOLORS = 24,

        /// <summary>
        /// Relative width of a device pixel used for line drawing.
        /// </summary>
        ASPECTX = 40,

        /// <summary>
        /// Relative height of a device pixel used for line drawing.
        /// </summary>
        ASPECTY = 42,

        /// <summary>
        /// Diagonal width of the device pixel used for line drawing.
        /// </summary>
        ASPECTXY = 44,

        /// <summary>
        /// Reserved.
        /// </summary>
        PDEVICESIZE = 26,

        /// <summary>
        /// Flag that indicates the clipping capabilities of the device. 
        /// If the device can clip to a rectangle, it is 1. Otherwise, it is 0.
        /// </summary>
        CLIPCAPS = 36,

        /// <summary>
        /// Number of entries in the system palette. This index is valid only if
        /// the device driver sets the RC_PALETTE bit in the RASTERCAPS index and is
        /// available only if the driver is compatible with 16-bit Windows.
        /// </summary>
        SIZEPALETTE = 104,

        /// <summary>
        /// Number of reserved entries in the system palette. 
        /// This index is valid only if the device driver sets the RC_PALETTE bit
        /// in the RASTERCAPS index and is available only if the driver is compatible with 16-bit Windows.
        /// </summary>
        NUMRESERVED = 106,

        /// <summary>
        /// Actual color resolution of the device, in bits per pixel.
        /// This index is valid only if the device driver sets the RC_PALETTE bit in
        /// the RASTERCAPS index and is available only if the driver is compatible with 16-bit Windows.
        /// </summary>
        COLORRES = 108,

        /// <summary>
        /// For printing devices: the width of the physical page, in device units. For example,
        /// a printer set to print at 600 dpi on 8.5-x11-inch paper has a physical width value of 5100 device units. 
        /// Note that the physical page is almost always greater than the printable area of the page, and never smaller.
        /// </summary>
        PHYSICALWIDTH = 110,

        /// <summary>
        /// For printing devices: the height of the physical page, in device units. For example,
        /// a printer set to print at 600 dpi on 8.5-by-11-inch paper has a physical height value of 6600 device units.
        /// Note that the physical page is almost always greater than the printable area of the page, and never smaller.
        /// </summary>
        PHYSICALHEIGHT = 111,

        /// <summary>
        /// For printing devices: the distance from the left edge of the physical page to the left edge 
        /// of the printable area, in device units. For example, a printer set to print at 600 dpi on
        /// 8.5-by-11-inch paper, that cannot print on the leftmost 0.25-inch of paper,
        /// has a horizontal physical offset of 150 device units.
        /// </summary>
        PHYSICALOFFSETX = 112,

        /// <summary>
        /// For printing devices: the distance from the top edge of the physical page to the top edge 
        /// of the printable area, in device units. For example, a printer set to print at 600 dpi on
        /// 8.5-by-11-inch paper, that cannot print on the topmost 0.5-inch of paper, 
        /// has a vertical physical offset of 300 device units.
        /// </summary>
        PHYSICALOFFSETY = 113,

        /// <summary>
        /// For display devices: the current vertical refresh rate of the device, in cycles per second (Hz).<br/>
        /// A vertical refresh rate value of 0 or 1 represents the display hardware's default refresh rate.
        /// This default rate is typically set by switches on a display card or computer motherboard, 
        /// or by a configuration program that does not use display functions such as 
        /// <see cref="User32.DeviceContext.ChangeDisplaySettings"/>.
        /// </summary>
        VREFRESH = 116,

        /// <summary>
        /// Scaling factor for the x-axis of the printer.
        /// </summary>
        SCALINGFACTORX = 114,

        /// <summary>
        /// Scaling factor for the y-axis of the printer.
        /// </summary>
        SCALINGFACTORY = 115,

        /// <summary>
        /// Preferred horizontal drawing alignment, expressed as a multiple of pixels. 
        /// For best drawing performance, windows should be horizontally aligned to a multiple of this value.
        /// A value of zero indicates that the device is accelerated, and any alignment may be used.
        /// </summary>
        BLTALIGNMENT = 119,

        /// <summary>
        /// Value that indicates the shading and blending capabilities of the device.
        /// Only supported on XP and higher.
        /// </summary>
        SHADEBLENDCAPS = 120,

        /// <summary>
        /// Value that indicates the raster capabilities of the device.
        /// </summary>
        RASTERCAPS = 38,

        /// <summary>
        /// Value that indicates the curve capabilities of the device.
        /// </summary>
        CURVECAPS = 28,

        /// <summary>
        /// Value that indicates the line capabilities of the device.
        /// </summary>
        LINECAPS = 30,

        /// <summary>
        /// Value that indicates the polygon capabilities of the device.
        /// </summary>
        POLYGONALCAPS = 32,

        /// <summary>
        /// Value that indicates the text capabilities of the device.
        /// </summary>
        TEXTCAPS = 34,

        /// <summary>
        /// Value that indicates the color management capabilities of the device.
        /// Only supported on XP and higher.
        /// </summary>
        COLORMGMTCAPS = 121
    }
}
