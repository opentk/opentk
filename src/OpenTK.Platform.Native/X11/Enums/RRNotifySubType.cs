namespace OpenTK.Platform.Native.X11
{
    /// <summary>
    /// Notification subcodes for XRandR.
    /// </summary>
    public enum RRNotifySubType : int
    {
        CrtcChange       = 0,
        OutputChange     = 1,
        OutputProperty   = 2,
        ProviderChange   = 3,
        ProviderProperty = 4,
        ResourceChange   = 5
    }
}
