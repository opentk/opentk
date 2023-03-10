using System;

namespace OpenTK.Platform.Native.X11
{
    internal enum XEventType : int
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
        MapRequest = 20,
        ReparentNotify = 21,
        ConfigureNotify = 22,
        ConfigureRequest = 23,
        GravityNotify = 24,
        ResizeRequest = 25,
        CirculateNotify = 26,
        CirculateRequest = 27,
        PropertyNotify = 28,
        SelectionClear = 29,
        SelectionRequest = 30,
        SelectionNotify = 31,
        ColormapNotify = 32,
        ClientMessage = 33,
        MappingNotify = 34,
        GenericEvent = 35,
        LastEvent = 36
    }

    internal enum FocusChangeMode : int
    {
        NotifyNormal = 0,
        NotifyGrab = 1,
        NotifyUngrab = 2,
    }

    internal enum FocusChangeDetail : int
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

    internal enum PropertyState : int
    {
        PropertyNewValue = 0,
        PropertyDelete = 1,
    }

    internal enum GrabMode : int
    {
        GrabModeSync = 0,
        GrabModeAsync = 1,
    }

    internal enum GrabResult : int
    {
        GrabSuccess = 0,
        AlreadyGrabbed = 1,
        GrabInvalidTime = 2,
        GrabNotViewable = 3,
        GrabFrozen = 4,
    }

    [Flags]
    internal enum XWMHintsMask : long {
        InputHint = (1L << 0),
        StateHint = (1L << 1),
        IconPixmapHint = (1L << 2),
        IconWindowHint = (1L << 3),
        IconPositionHint = (1L << 4),
        IconMaskHint = (1L << 5),
        WindowGroupHint = (1L << 6),
        UrgencyHint = (1L << 8),
        AllHints = (InputHint|StateHint|IconPixmapHint|IconWindowHint|IconPositionHint|IconMaskHint|WindowGroupHint),
    }

    internal enum MapState : int
    {
        IsUnmapped,
        IsUnviewable,
        IsViewable,
    }

    internal enum RevertTo : int
    {
        RevertToNone = 0,
        RevertToPointerRoot = 1,
        RevertToParent = 2,
    }

    /// <summary>
    /// Enum for keeping track of _NET_WM_STATE
    /// </summary>
    [Flags]
    internal enum WMState
    {
        None = 0,
        Modal = 1 << 0,
        Sticky = 1 << 1,
        MaximizedVert = 1 << 2,
        MaximizedHorz = 1 << 3,
        Shaded = 1 << 4,
        SkipTaskbar = 1 << 5,
        SkipPager = 1 << 6,
        Hidden = 1 << 7,
        Fullscreen = 1 << 8,
        Above = 1 << 9,
        Below = 1 << 10,
        DemandsAttention = 1 << 11,
        Focused = 1 << 12,
    }

    internal enum XEventsQueuedMode
    {
        QueuedAlready = 0,
        QueuedAfterFlush = 1,
        QueuedAfterReading = 2
    }

    [Flags]
    internal enum XWindowChangesMask
    {
        CWX = (1 << 0),
        CWY = (1 << 1),
        CWWidth = (1 << 2),
        CWHeight = (1 << 3),
        CWBorderWidth = (1 << 4),
        CWSibling = (1 << 5),
        CWStackMode = (1 << 6),
    }

    internal enum XCursorShape : uint
    {
        XCursor = 0,
        Arrow = 2,
        BasedArrowDown = 4,
        BasedArrowUp = 6,
        Boat = 8,
        Bogosity = 10,
        BottomLeftCorner = 12,
        BottomRightCorner = 14,
        BottomSide = 16,
        BottomTee = 18,
        BoxSpiral = 20,
        CenterPtr = 22,
        Circle = 24,
        Clock = 26,
        CoffeeMug = 28,
        Cross = 30,
        CrossReverse = 32,
        Crosshair = 34,
        DiamondCross = 36,
        Dot = 38,
        DotBoxMask = 40,
        DoubleArrow = 42,
        DraftLarge = 44,
        DraftSmall = 46,
        DrapedBox = 48,
        Exchange = 50,
        Fleur = 52,
        Gobbler = 54,
        Gumby = 56,
        Hand1 = 58,
        Hand2 = 60,
        Heart = 62,
        Icon = 64,
        IronCross = 66,
        LeftPtr = 68,
        LeftSide = 70,
        LeftTee = 72,
        Leftbutton = 74,
        LowerLeftAngle = 76,
        LowerRightAngle = 78,
        Man = 80,
        Middlebutton = 82,
        Mouse = 84,
        Pencil = 86,
        Pirate = 88,
        Plus = 90,
        QuestionArrow = 92,
        RightPtr = 94,
        RightSide = 96,
        RightTee = 98,
        Rightbutton = 100,
        RTLLogo = 102,
        Sailboat = 104,
        SBDownArrow = 106,
        SBHorizontalDoubleArrow = 108,
        SBLeftArrow = 110,
        SBRightArrow = 112,
        SBUpArrow = 114,
        SBVerticalDoubleArrow = 116,
        Shuttle = 118,
        Sizing = 120,
        Spider = 122,
        Spraycan = 124,
        Star = 126,
        Target = 128,
        TCross = 130,
        TopLeftArrow = 132,
        TopLeftCorner = 134,
        TopRightCorner = 136,
        TopSide = 138,
        TopTee = 140,
        Trek = 142,
        UpperLeftAngle = 144,
        Umbrella = 146,
        UpperRightAngle = 148,
        Watch = 150,
        XTerm = 152,
    }

    internal enum XError : byte
    {
        /// <summary>
        /// No error.
        /// </summary>
        Success = 0,

        /// <summary>
        /// The major or minor opcode does not specify a valid request.
        /// This usually is an Xlib or server error.
        /// </summary>
        BadRequest = 1,

        /// <summary>
        /// <para>
        /// A client attempts to grab a key/button combination already grabbed by another client.
        /// </para>
        /// <para>
        /// A client attempts to free a colormap entry that it had not already allocated or to free
        /// an entry in a colormap that was created with all entries writable.
        /// </para>
        /// <para>
        /// A client attempts to store into a read-only or unallocated colormap entry.
        /// </para>
        /// <para>
        /// A client attempts to modify the access control list from other than the local (or otherwise authorized) host.
        /// </para>
        /// <para>
        /// A client attempts to select an event type that another client has already selected.
        /// </para>
        /// </summary>
        BadAccess = 10,

        /// <summary>
        /// The server fails to allocate the requested resource.
        /// Note that the explicit listing of BadAlloc errors in requests only covers allocation errors at
        /// a very coarse level and is not intended to (nor can it in practice hope to)
        /// cover all cases of a server running out of allocation space in the middle of service.
        /// The semantics when a server runs out of allocation space are left unspecified,
        /// but a server may generate a BadAlloc error on any request for this reason,
        /// and clients should be prepared to receive such errors and handle or discard them.
        /// </summary>
        BadAlloc = 11,

        /// <summary>
        /// A value for a colormap argument does not name a defined colormap.
        /// </summary>
        BadColor = 12,

        /// <summary>
        /// A value for a GContext argument does not name a defined GContext.
        /// </summary>
        BadGC = 13,

        /// <summary>
        /// The value chosen for a resource identifier either is not included
        /// in the range assigned to the client or is already in use.
        /// Under normal circumstances,
        /// this cannot occur and should be considered a server or Xlib error.
        /// </summary>
        BadIDChoice = 14,

        /// <summary>
        /// A font or color of the specified name does not exist.
        /// </summary>
        BadName = 15,

        /// <summary>
        /// <para>
        /// The length of a request is shorter or longer than that required to contain the arguments.
        /// This is an internal Xlib or server error.
        /// </para>
        /// <para>
        /// The length of a request exceeds the maximum length accepted by the server.
        /// </para>
        /// </summary>
        BadLength = 16,

        /// <summary>
        /// The server does not implement some aspect of the request.
        /// A server that generates this error for a core request is deficient.
        /// As such, this error is not listed for any of the requests,
        /// but clients should be prepared to receive such errors and handle or discard them.
        /// </summary>
        BadImplementation = 17,

        /// <summary>
        /// Some numeric value falls outside of the range of values accepted by the request.
        /// Unless a specific range is specified for an argument,
        /// the full range defined by the argument's type is accepted.
        /// Any argument defined as a set of alternatives typically can generate this error (due to the encoding).
        /// </summary>
        BadValue = 2,

        /// <summary>
        /// A value for a window argument does not name a defined window.
        /// </summary>
        BadWindow = 3,

        /// <summary>
        /// A value for a pixmap argument does not name a defined pixmap.
        /// </summary>
        BadPixmap = 4,

        /// <summary>
        /// A value for an atom argument does not name a defined atom.
        /// </summary>
        BadAtom = 5,

        /// <summary>
        /// A value for a cursor argument does not name a defined cursor.
        /// </summary>
        BadCursor = 6,

        /// <summary>
        /// A value for a font argument does not name a defined font (or, in some cases, GContext).
        /// </summary>
        BadFont = 7,

        /// <summary>
        /// <para>
        /// In a graphics request, the root and depth of the graphics context does not match that of the drawable.
        /// </para>
        /// <para>
        /// An InputOnly window is used as a drawable.
        /// </para>
        /// <para>
        /// Some argument or pair of arguments has the correct type and range, but it fails to match in some other way required by the request.
        /// </para>
        /// <para>
        /// An InputOnly window lacks this attribute.
        /// </para>
        /// </summary>
        BadMatch = 8,

        /// <summary>
        /// A value for a drawable argument does not name a defined window or pixmap.
        /// </summary>
        BadDrawable = 9,

        FirstExtensionError = 128,
        LastExtensionError = 255,
    }

    [Flags]
    internal enum XEventMask : long
    {
        None = 0,
        KeyPress = (1 << 0),
        KeyRelease = (1 << 1),
        ButtonPress = (1 << 2),
        ButtonRelease = (1 << 3),
        EnterWindow = (1 << 4),
        LeaveWindow = (1 << 5),
        PointerMotion = (1 << 6),
        PointerMotionHint = (1 << 7),
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

    internal enum XPropertyMode
    {
        Replace = 0,
        Prepend = 1,
        Append = 2
    }

    internal enum XRequestCode : byte
    {
        X_CreateWindow = 1,
        X_ChangeWindowAttributes = 2,
        X_GetWindowAttributes = 3,
        X_DestroyWindow = 4,
        X_DestroySubwindows = 5,
        X_ChangeSaveSet = 6,
        X_ReparentWindow = 7,
        X_MapWindow = 8,
        X_MapSubwindows = 9,
        X_UnmapWindow = 10,
        X_UnmapSubwindows = 11,
        X_ConfigureWindow = 12,
        X_CirculateWindow = 13,
        X_GetGeometry = 14,
        X_QueryTree = 15,
        X_InternAtom = 16,
        X_GetAtomName = 17,
        X_ChangeProperty = 18,
        X_DeleteProperty = 19,
        X_GetProperty = 20,
        X_ListProperties = 21,
        X_SetSelectionOwner = 22,
        X_GetSelectionOwner = 23,
        X_ConvertSelection = 24,
        X_SendEvent = 25,
        X_GrabPointer = 26,
        X_UngrabPointer = 27,
        X_GrabButton = 28,
        X_UngrabButton = 29,
        X_ChangeActivePointerGrab = 30,
        X_GrabKeyboard = 31,
        X_UngrabKeyboard = 32,
        X_GrabKey = 33,
        X_UngrabKey = 34,
        X_AllowEvents = 35,
        X_GrabServer = 36,
        X_UngrabServer = 37,
        X_QueryPointer = 38,
        X_GetMotionEvents = 39,
        X_TranslateCoords = 40,
        X_WarpPointer = 41,
        X_SetInputFocus = 42,
        X_GetInputFocus = 43,
        X_QueryKeymap = 44,
        X_OpenFont = 45,
        X_CloseFont = 46,
        X_QueryFont = 47,
        X_QueryTextExtents = 48,
        X_ListFonts = 49,
        X_ListFontsWithInfo = 50,
        X_SetFontPath = 51,
        X_GetFontPath = 52,
        X_CreatePixmap = 53,
        X_FreePixmap = 54,
        X_CreateGC = 55,
        X_ChangeGC = 56,
        X_CopyGC = 57,
        X_SetDashes = 58,
        X_SetClipRectangles = 59,
        X_FreeGC = 60,
        X_ClearArea = 61,
        X_CopyArea = 62,
        X_CopyPlane = 63,
        X_PolyPoint = 64,
        X_PolyLine = 65,
        X_PolySegment = 66,
        X_PolyRectangle = 67,
        X_PolyArc = 68,
        X_FillPoly = 69,
        X_PolyFillRectangle = 70,
        X_PolyFillArc = 71,
        X_PutImage = 72,
        X_GetImage = 73,
        X_PolyText8 = 74,
        X_PolyText16 = 75,
        X_ImageText8 = 76,
        X_ImageText16 = 77,
        X_CreateColormap = 78,
        X_FreeColormap = 79,
        X_CopyColormapAndFree = 80,
        X_InstallColormap = 81,
        X_UninstallColormap = 82,
        X_ListInstalledColormaps = 83,
        X_AllocColor = 84,
        X_AllocNamedColor = 85,
        X_AllocColorCells = 86,
        X_AllocColorPlanes = 87,
        X_FreeColors = 88,
        X_StoreColors = 89,
        X_StoreNamedColor = 90,
        X_QueryColors = 91,
        X_LookupColor = 92,
        X_CreateCursor = 93,
        X_CreateGlyphCursor = 94,
        X_FreeCursor = 95,
        X_RecolorCursor = 96,
        X_QueryBestSize = 97,
        X_QueryExtension = 98,
        X_ListExtensions = 99,
        X_ChangeKeyboardMapping = 100,
        X_GetKeyboardMapping = 101,
        X_ChangeKeyboardControl = 102,
        X_GetKeyboardControl = 103,
        X_Bell = 104,
        X_ChangePointerControl = 105,
        X_GetPointerControl = 106,
        X_SetScreenSaver = 107,
        X_GetScreenSaver = 108,
        X_ChangeHosts = 109,
        X_ListHosts = 110,
        X_SetAccessControl = 111,
        X_SetCloseDownMode = 112,
        X_KillClient = 113,
        X_RotateProperties = 114,
        X_ForceScreenSaver = 115,
        X_SetPointerMapping = 116,
        X_GetPointerMapping = 117,
        X_SetModifierMapping = 118,
        X_GetModifierMapping = 119,
        X_NoOperation = 127,
    }

    [Flags]
    internal enum XSizeHintFlags : long
    {
        UserPosition = (1 << 0),
        UserSize = (1 << 1),
        ProgramPosition = (1 << 2),
        ProgramSize = (1 << 3),
        MinSize = (1 << 4),
        MaxSize = (1 << 5),
        ResizeIncrements = (1 << 6),
        Aspect = (1 << 7),
        BaseSize = (1 << 8),
        WindowGravity = (1 << 9),
        AllProgramHints = ProgramPosition | ProgramSize | MinSize | MaxSize | ResizeIncrements | Aspect
    }

    [Flags]
    internal enum XWindowAttributeValueMask : long
    {
        BackPixmap = 1 << 0,
        BackPixel = 1 << 1,
        BorderPixmap = 1 << 2,
        BorderPixel = 1 << 3,
        BitGravity = 1 << 4,
        WindowGravity = 1 << 5,
        BackingStore = 1 << 6,
        BackingPlanes = 1 << 7,
        BackingPixel = 1 << 8,
        OverrideRedirect = 1 << 9,
        SaveUnder = 1 << 10,
        EventMask = 1 << 11,
        DontPropagate = 1 << 12,
        Colormap = 1 << 13,
        Cursor = 1 << 14
    }

    [Flags]
    internal enum XColorFlags : byte
    {
        DoRed = (1 << 0),
        DoGreen = (1 << 1),
        DoBlue = (1 << 2),
    }

    internal enum BarrierDirection : int
    {
        BarrierPositiveX = 1 << 0,
		BarrierPositiveY = 1 << 1,
		BarrierNegativeX = 1 << 2,
		BarrierNegativeY = 1 << 3,
    }
}
