using UINT = System.UInt32;

namespace OpenTK.NT.Native
{
    public enum WindowMessage : UINT
    {
        Null = 0x0000,
        Create = 0x0001,
        Destroy = 0x0002,
        Move = 0x0003,
        Size = 0x0005,
        Activate = 0x0006,
        SetFocus = 0x0007,
        KillFocus = 0x0008,

        //              public const uint SETVISIBLE           = 0x0009;
        Enable = 0x000A,
        SetRedraw = 0x000B,
        SetText = 0x000C,
        GetText = 0x000D,
        GetTextLength = 0x000E,
        Paint = 0x000F,
        Close = 0x0010,
        QueryEndSession = 0x0011,
        Quit = 0x0012,
        QueryOpen = 0x0013,
        EraseBackground = 0x0014,
        SysColorChange = 0x0015,
        EndSession = 0x0016,

        //              public const uint SYSTEMERROR          = 0x0017;
        ShowWindow = 0x0018,
        CtlColor = 0x0019,
        WinIniChange = 0x001A,
        SettingChange = 0x001A,
        DeviceModeChange = 0x001B,
        ActivateApp = 0x001C,
        FontChange = 0x001D,
        TimeChange = 0x001E,
        CancelMode = 0x001F,
        SetCursor = 0x0020,
        MouseActivate = 0x0021,
        ChildActivate = 0x0022,
        QueueSync = 0x0023,
        GetMinMaxInfo = 0x0024,
        PaintIcon = 0x0026,
        IconEraseBackground = 0x0027,
        NextDialogCtl = 0x0028,

        //              public const uint ALTTABACTIVE         = 0x0029;
        SpoolerStatus = 0x002A,
        DrawItem = 0x002B,
        MeasureItem = 0x002C,
        DeleteItem = 0x002D,
        VKeyToItem = 0x002E,
        CharToItem = 0x002F,
        SetFont = 0x0030,
        GetFont = 0x0031,
        SetHotkey = 0x0032,
        GetHotkey = 0x0033,

        //              public const uint FILESYSCHANGE        = 0x0034;
        //              public const uint ISACTIVEICON         = 0x0035;
        //              public const uint QUERYPARKICON        = 0x0036;
        QueryDragIcon = 0x0037,
        CompareItem = 0x0039,

        //              public const uint TESTING              = 0x003a;
        //              public const uint OTHERWINDOWCREATED = 0x003c;
        GetObject = 0x003D,

        //                      public const uint ACTIVATESHELLWINDOW        = 0x003e;
        Compacting = 0x0041,
        CommNotify = 0x0044,
        WindowPosChanging = 0x0046,
        WindowPosChanged = 0x0047,
        Power = 0x0048,
        CopyData = 0x004A,
        CancelJournal = 0x004B,
        Notify = 0x004E,
        InputLanguageChangeRequest = 0x0050,
        InputLanguageChange = 0x0051,
        TCard = 0x0052,
        Help = 0x0053,
        UserChanged = 0x0054,
        NotifyFormat = 0x0055,
        ContextMenu = 0x007B,
        StyleChanging = 0x007C,
        StyleChanged = 0x007D,
        DisplayChange = 0x007E,
        GetIcon = 0x007F,

        // Non-Client messages
        SetIcon = 0x0080,
        NCCreate = 0x0081,
        NCDestroy = 0x0082,
        NCCalcSize = 0x0083,
        NCHitTest = 0x0084,
        NCPaint = 0x0085,
        NCActivate = 0x0086,
        GetDialogCode = 0x0087,
        SyncPaint = 0x0088,

        //              public const uint SYNCTASK       = 0x0089;
        NCMouseMove = 0x00A0,
        NCLButtonDown = 0x00A1,
        NCLButtonUp = 0x00A2,
        NCLButtonDoubleClick = 0x00A3,
        NCRButtonDown = 0x00A4,
        NCRButtonUp = 0x00A5,
        NCRButtonDoubleClick = 0x00A6,
        NCMButtonDown = 0x00A7,
        NCMButtonUp = 0x00A8,
        NCMButtonDoubleClick = 0x00A9,

        /// <summary>
        /// Only supported on Windows 2000 and higher.
        /// </summary>
        NCXButtonDown = 0x00ab,

        /// <summary>
        /// Only supported on Windows 2000 and higher.
        /// </summary>
        NCXButtonUp = 0x00ac,

        /// <summary>
        /// Only supported on Windows 2000 and higher.
        /// </summary>
        NXButtonDoubleClick = 0x00ad,

        Input = 0x00FF,

        KeyDown = 0x0100,
        KeyFirst = 0x0100,
        KeyUp = 0x0101,
        Char = 0x0102,
        DeadChar = 0x0103,
        SystemKeyDown = 0x0104,
        SystemKeyUp = 0x0105,
        SystemChar = 0x0106,
        SystemDeadChar = 0x0107,
        KeyLast = 0x0108,
        ImeStartComposition = 0x010D,
        ImeEndComposition = 0x010E,
        ImeComposition = 0x010F,
        ImeKeylast = 0x010F,
        InitDialog = 0x0110,
        Command = 0x0111,
        SystemCommand = 0x0112,
        Timer = 0x0113,
        HScroll = 0x0114,
        VScroll = 0x0115,
        InitMenu = 0x0116,
        InitMenuPopup = 0x0117,

        //              public const uint SYSTIMER       = 0x0118;
        MenuSelect = 0x011F,
        MenuChar = 0x0120,
        EnterIdle = 0x0121,
        MenuRButtonUp = 0x0122,
        MenuDrag = 0x0123,
        MenuGetObject = 0x0124,
        UninitMenuPopup = 0x0125,
        MenuCommand = 0x0126,

        ChangeUIState = 0x0127,
        UpdateUIState = 0x0128,
        QueryUIState = 0x0129,

        //              public const uint LBTRACKPOINT     = 0x0131;
        CtlColorMsgBox = 0x0132,
        CtlColorEdit = 0x0133,
        CtlColorListBox = 0x0134,
        CtlColorButton = 0x0135,
        CtlColorDialog = 0x0136,
        CtlColorScrollbar = 0x0137,
        CtlColorStatic = 0x0138,
        MouseMove = 0x0200,
        MouseFirst = 0x0200,
        LButtonDown = 0x0201,
        LButtonUp = 0x0202,
        LButtonDoubleClick = 0x0203,
        RButtonDown = 0x0204,
        RButtonUp = 0x0205,
        RButtonDoubleClick = 0x0206,
        MButtonDown = 0x0207,
        MButtonUp = 0x0208,
        MButtonDoubleClick = 0x0209,
        MouseWheel = 0x020A,

        /// <summary>
        /// Only supported on Windows 2000 and higher.
        /// </summary>
        XButtonDown = 0x020B,

        /// <summary>
        /// Only supported on Windows 2000 and higher.
        /// </summary>
        XButtonUp = 0x020C,

        /// <summary>
        /// Only supported on Windows 2000 and higher.
        /// </summary>
        XButtonDoubleClick = 0x020D,

        /// <summary>
        /// Only supported on Vista and higher.
        /// </summary>
        MouseHWheel = 0x020E,
        ParentNotify = 0x0210,
        EnterMenuLoop = 0x0211,
        ExitMenuLoop = 0x0212,
        NextMenu = 0x0213,
        Sizing = 0x0214,
        CaptureChanged = 0x0215,
        Moving = 0x0216,

        //              public const uint POWERBROADCAST   = 0x0218;
        DeviceChange = 0x0219,
        MdiCreate = 0x0220,
        MdiDestroy = 0x0221,
        MdiActivate = 0x0222,
        MdiRestore = 0x0223,
        MdiNext = 0x0224,
        MdiMaximize = 0x0225,
        MdiTitle = 0x0226,
        MdiCascade = 0x0227,
        MdiIconArrange = 0x0228,
        MdiGetActive = 0x0229,

        /* D&D messages */
        //              public const uint DROPOBJECT     = 0x022A;
        //              public const uint QUERYDROPOBJECT  = 0x022B;
        //              public const uint BEGINDRAG      = 0x022C;
        //              public const uint DRAGLOOP       = 0x022D;
        //              public const uint DRAGSELECT     = 0x022E;
        //              public const uint DRAGMOVE       = 0x022F;
        MdiSetMenu = 0x0230,
        EnterSizeMove = 0x0231,
        ExitSizeMove = 0x0232,
        DropFiles = 0x0233,
        MdiRefreshMenu = 0x0234,
        ImeSetContext = 0x0281,
        ImeNotify = 0x0282,
        ImeControl = 0x0283,
        ImeCompositionFull = 0x0284,
        ImeSelect = 0x0285,
        ImeChar = 0x0286,
        ImeRequest = 0x0288,
        ImeKeydown = 0x0290,
        ImeKeyup = 0x0291,
        NCMouseHover = 0x02A0,
        MouseHover = 0x02A1,
        NCMouseLeave = 0x02A2,
        MouseLeave = 0x02A3,
        Cut = 0x0300,
        Copy = 0x0301,
        Paste = 0x0302,
        Clear = 0x0303,
        Undo = 0x0304,
        RenderFormat = 0x0305,
        RenderAllFormats = 0x0306,
        DestroyClipboard = 0x0307,
        DrawClipboard = 0x0308,
        PaintClipboard = 0x0309,
        VScrollClipboard = 0x030A,
        SizeClipboard = 0x030B,
        AskCBFormatName = 0x030C,
        ChangeCBChain = 0x030D,
        HScrollClipboard = 0x030E,
        QueryNewPalette = 0x030F,
        PaletteIsChanging = 0x0310,
        PaletteChanged = 0x0311,
        Hotkey = 0x0312,
        Print = 0x0317,
        PrintClient = 0x0318,
        HandheldFirst = 0x0358,
        HandheldLast = 0x035F,
        AfxFirst = 0x0360,
        AfxLast = 0x037F,
        PenWinFirst = 0x0380,
        PenWinLast = 0x038F,
        App = 0x8000,
        User = 0x0400,

        // Our "private" ones
        MouseEnter = 0x0401,
        AsyncMessage = 0x0403,
        Reflect = User + 0x1c00,
        CloseInternal = User + 0x1c01,

        // NotifyIcon (Systray) Balloon messages
        BalloonShow = User + 0x0002,
        BalloonHide = User + 0x0003,
        BalloonTimeout = User + 0x0004,
        BalloonUserClick = User + 0x0005
    }
}
