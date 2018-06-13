namespace OpenTK.NT.Native
{
    /// <summary>
    /// Identifiers for the GetStockObject method.
    /// </summary>
    public enum GetStockObjectType
    {
        WhiteBrush = 0,
        LightGrayBrush = 1,
        GrayBrush = 2,
        DarkGrayBrush = 3,
        BlackBrush = 4,
        NullBrush = 5,
        HollowBrush = NullBrush,
        WhitePen = 6,
        BlackPen = 7,
        NullPen = 8,
        OemFixedFont = 10,
        AnsiFixedFont = 11,
        AnsiVariableFont = 12,
        SystemFont = 13,
        DeviceDefaultFont = 14,
        DefaultPalette = 15,
        SystemFixedFont = 16,
        DefaultGuiFont = 17,
        DeviceContextBrush = 18,
        DeviceContextPen = 19
    }
}
