using System.Runtime.InteropServices;

namespace OpenTK.Platform.Native.X11
{
    public enum XEventType : int
    {
        KeyPress = 2,
        KeyRelease = 3,
        ButtonPress = 4,
        ButtonRelease = 5,
        MotionNotify = 6,
        EnterNotify = 7,
        LeaveNotify = 8,
        FocusIn = 9,
        FocusOut = 10,
        KeymapNotify = 11,
        Expose = 12,
        GraphicsExpose = 13,
        NoExpose = 14,
        VisibilityNotify = 15,
        CreateNotify = 16,
        DestroyNotify = 17,
        UnmapNotify = 18,
        MapNotify = 19,
        ReparentNotify = 20,
        ConfigureNotify = 21,
        ConfigureRequest = 22,
        GravityNotify = 23,
        ResizeRequest = 24,
        CirculateNotify = 25,
        CirculateRequest = 26,
        PropertyNotify = 27,
        SelectionClear = 28,
        SelectionRequest = 30,
        SelectionNotify = 31,
        ColormapNotify = 32,
        ClientMessage = 33,
        MappingNotify = 34,
        GenericEvent = 35,
        LastEvent = 36
    }

    public enum FocusChangeMode : int
    {
        NotifyNormal = 0,
        NotifyGrab = 1,
        NotifyUngrab = 2,
    }

    public enum FocusChangeDetail : int
    {
        NotifyAncestor = 0,
        NotifyVirtual = 1,
        NotifyInferior = 2, 
        NotifyNonlinear = 3,
        NotifyNonlinearVirtual = 4,
        NotifyPointer = 5,
        NotifyPointerRoot = 6,
        NotifyDetailNone = 7,
    }

    public enum PropertyState : int
    {
        PropertyNewValue = 0,
        PropertyDelete = 1,
    }
}
