namespace OpenTK.Platform.Native.X11
{
    public enum XEventMask : long
    {
        None = 0,
        KeyPress = (1 << 0),
        KeyRelease = (1 << 1),
        ButtonPress = (1 << 2),
        ButtonRelease = (1 << 3),
        EnterWindow = (1 << 4),
        LeaveWindow = (1 << 5),
        PointerMotion = (1 << 6),
        PointerMotionHint = (1<< 7),
        Button1Motion = (1 << 8),
        Button2Motion = (1 << 9),
        Button3Motion = (1 << 10),
        Button4Motion = (1 << 11),
        Button5Motion = (1 << 12),
        ButtonMotion = (1 << 13),
        KeymapState = (1 << 14),
        Exposure = (1 << 15),
        VisibilityChanged = (1 << 16),
        StructureNotify = (1 << 17),
        ResizeRedirect = (1 << 18),
        SubstructureNotify = (1 << 19),
        SubstructureRedirect = (1 << 20),
        FocusChange = (1 << 21),
        PropertyChange = (1 << 22),
        ColormapChange = (1 << 23),
        OwnerGrabButton = (1 << 24),
        All = 0x00FFFFFF
    }
}
