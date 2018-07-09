namespace OpenTK.NT.Native
{
    /// <summary>
    /// Identifiers for the GetStockObject method.
    /// </summary>
    public enum GetStockObjectType
    {
        /// <summary>
        /// White brush.
        /// </summary>
        WhiteBrush = 0,

        /// <summary>
        /// Light gray brush.
        /// </summary>
        LightGrayBrush = 1,

        /// <summary>
        /// Gray brush.
        /// </summary>
        GrayBrush = 2,

        /// <summary>
        /// Dark gray brush.
        /// </summary>
        DarkGrayBrush = 3,

        /// <summary>
        /// Black brush.
        /// </summary>
        BlackBrush = 4,

        /// <summary>
        /// Null brush (equivalent to <see cref="HollowBrush"/>).
        /// </summary>
        NullBrush = 5,

        /// <summary>
        /// Hollow brush (equivalent to <see cref="NullBrush"/>).
        /// </summary>
        HollowBrush = NullBrush,

        /// <summary>
        /// White pen.
        /// </summary>
        WhitePen = 6,

        /// <summary>
        /// Black pen.
        /// </summary>
        BlackPen = 7,

        /// <summary>
        /// Null pen.
        /// </summary>
        NullPen = 8,
        OemFixedFont = 10,
        AnsiFixedFont = 11,
        AnsiVariableFont = 12,

        /// <summary>
        /// System font. By default, the system uses the system font to draw menus, dialog box controls, and text.
        /// </summary>
        SystemFont = 13,
        DeviceDefaultFont = 14,

        /// <summary>
        /// Default palette. This palette consists of the static colors in the system palette.
        /// </summary>
        DefaultPalette = 15,
        SystemFixedFont = 16,
        DefaultGuiFont = 17,
        DeviceContextBrush = 18,
        DeviceContextPen = 19
    }
}
