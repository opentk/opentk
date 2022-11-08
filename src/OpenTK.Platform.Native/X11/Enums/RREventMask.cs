namespace OpenTK.Platform.Native.X11
{
    /// <summary>
    /// Event mask for XRandR event types.
    /// </summary>
    public enum RREventMask : int
    {
        ScreenChangeNotify           = (1 << 0),
        CrtcChangeNotify             = (1 << 1),
        OutputChangeNotify           = (1 << 2),
        OutputPropertyNotify         = (1 << 3),
        ProviderChangeNotify         = (1 << 4),
        ProviderPropertyChangeNotify = (1 << 5),
        ResourceChangeNotify         = (1 << 6),
        LeaseNotify                  = (1 << 7)
    }
}
