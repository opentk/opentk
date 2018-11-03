namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Identifiers for the <see cref="Gdi32.GetStockObject(GetStockObjectType)"/> function.
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

        /// <summary>
        /// This member is not officially documented. Use with care.
        /// </summary>
        OemFixedFont = 10,

        /// <summary>
        /// This member is not officially documented. Use with care.
        /// </summary>
        AnsiFixedFont = 11,

        /// <summary>
        /// This member is not officially documented. Use with care.
        /// </summary>
        AnsiVariableFont = 12,

        /// <summary>
        /// System font. By default, the system uses the system font to draw menus, dialog box controls, and text.
        /// </summary>
        SystemFont = 13,

        /// <summary>
        /// This member is not officially documented. Use with care.
        /// </summary>
        DeviceDefaultFont = 14,

        /// <summary>
        /// Default palette. This palette consists of the static colors in the system palette.
        /// </summary>
        DefaultPalette = 15,

        /// <summary>
        /// This member is not officially documented. Use with care.
        /// </summary>
        SystemFixedFont = 16,

        /// <summary>
        /// This member is not officially documented. Use with care.
        /// </summary>
        DefaultGuiFont = 17,

        /// <summary>
        /// This member is not officially documented. Use with care.
        /// </summary>
        DeviceContextBrush = 18,

        /// <summary>
        /// This member is not officially documented. Use with care.
        /// </summary>
        DeviceContextPen = 19
    }
}
