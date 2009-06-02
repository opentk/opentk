//
//  
//  Carbon.cs
//
//  Created by Erik Ylvisaker on 3/17/08.
//  Copyright 2008. All rights reserved.
//
//

using System;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace OpenTK.Platform.MacOS.Carbon
{

    #region --- Types defined in MacTypes.h ---

    [StructLayout(LayoutKind.Sequential)]
    internal struct Point
    {
        internal short V;
        internal short H;

        public Point(int x, int y)
        {
            V = (short)x;
            H = (short)y;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct Rect
    {
        short top;
        short left;
        short bottom;
        short right;

        internal Rect(short _left, short _top, short _width, short _height)
        {
            top = _top;
            left = _left;
            bottom = (short)(_top + _height);
            right = (short)(_left + _width);
        }

        internal short X
        {
            get { return left; }
            set
            {
                short width = Width;
                left = value;
                right = (short)(left + width);
            }
        }
        internal short Y
        {
            get { return top; }
            set
            {
                short height = Height;
                top = value;
                bottom = (short)(top + height);
            }
        }
        internal short Width 
        { 
            get { return (short)(right - left); } 
            set { right = (short)(left + value); }
        }
        internal short Height 
        { 
            get { return (short)(bottom - top); } 
            set { bottom = (short)(top + value); }
           }

        public override string ToString()
        {
            return string.Format(
                "Rect: [{0}, {1}, {2}, {3}]", X, Y, Width, Height);
        }

        public System.Drawing.Rectangle ToRectangle()
        {
            return new System.Drawing.Rectangle(X, Y, Width, Height);
        }
    }

    #endregion
    #region --- Types defined in HIGeometry.h ---

    [StructLayout(LayoutKind.Sequential)]
    internal struct HIPoint
    {
        public float X;
        public float Y;
    }
    [StructLayout(LayoutKind.Sequential)]
    internal struct HISize
    {
        public float Width;
        public float Height;
    }
    [StructLayout(LayoutKind.Sequential)]
    internal struct HIRect
    {
        public HIPoint Origin;
        public HISize Size;

        public override string ToString()
        {
            return string.Format(
                "Rect: [{0}, {1}, {2}, {3}]", Origin.X, Origin.Y, Size.Width, Size.Height);
        }
    }

    #endregion

    #region --- Types defined in CarbonEvents.h ---

    [StructLayout(LayoutKind.Sequential)]
    internal struct EventTypeSpec
    {
        internal EventTypeSpec(EventClass evtClass, AppEventKind evtKind)
        {
            this.EventClass = evtClass;
            this.EventKind = (uint)evtKind;
        }
        internal EventTypeSpec(EventClass evtClass, AppleEventKind appleKind)
        {
            this.EventClass = evtClass;
            this.EventKind = (uint)appleKind;
        }
        internal EventTypeSpec(EventClass evtClass, MouseEventKind evtKind)
        {
            this.EventClass = evtClass;
            this.EventKind = (uint)evtKind;
        }
        internal EventTypeSpec(EventClass evtClass, KeyboardEventKind evtKind)
        {
            this.EventClass = evtClass;
            this.EventKind = (uint)evtKind;
        }
        internal EventTypeSpec(EventClass evtClass, WindowEventKind evtKind)
        {
            this.EventClass = evtClass;
            this.EventKind = (uint)evtKind;
        }

        internal EventClass EventClass;
        internal uint EventKind;
    }

    public enum EventClass : int
    {
        /*
        kEventClassMouse            = FOUR_CHAR_CODE('mous'),
        kEventClassKeyboard         = FOUR_CHAR_CODE('keyb'),
        kEventClassTextInput        = FOUR_CHAR_CODE('text'),
        kEventClassApplication      = FOUR_CHAR_CODE('appl'),
        kEventClassAppleEvent       = FOUR_CHAR_CODE('eppc'),
        kEventClassMenu             = FOUR_CHAR_CODE('menu'),
        kEventClassWindow           = FOUR_CHAR_CODE('wind'),
        kEventClassControl          = FOUR_CHAR_CODE('cntl'),
        kEventClassCommand          = FOUR_CHAR_CODE('cmds')
        */
        Mouse = 0x6d6f7573,
        Keyboard = 0x6b657962,
        Application = 0x6170706c,
        AppleEvent = 0x65707063,
        Menu = 0x6d656e75,
        Window = 0x77696e64,
    }
    public enum WindowEventKind : int
    {
        // window events
        WindowUpdate = 1,
        WindowDrawContent = 2,
        WindowDrawStructure = 3,
        WindowEraseContent = 4,
        WindowActivate = 5,
        WindowDeactivate = 6,
        WindowSizeChanged = 23,
        WindowBoundsChanging = 26,
        WindowBoundsChanged = 27,
        WindowClickDragRgn    = 32,
        WindowClickResizeRgn  = 33,
        WindowClickCollapseRgn = 34,
        WindowClickCloseRgn   = 35,
        WindowClickZoomRgn    = 36,
        WindowClickContentRgn = 37,
        WindowClickProxyIconRgn = 38,
        WindowClose = 72,
        WindowClosed = 73,
    }
    public enum MouseEventKind : int
    {
        MouseDown = 1,
        MouseUp = 2,
        MouseMoved = 5,
        MouseDragged = 6,
        MouseEntered = 8,
        MouseExited = 9,
        WheelMoved = 10,
    }
    public enum MouseButton : short
    {
        Primary = 1,
        Secondary = 2,
        Tertiary = 3,
    }

    public enum KeyboardEventKind : int
    {
        // raw keyboard events
        RawKeyDown = 1,
        RawKeyRepeat = 2,
        RawKeyUp = 3,
        RawKeyModifiersChanged = 4,
    }

    public enum AppEventKind : int
    {
        // application events
        AppActivated = 1,
        AppDeactivated = 2,
        AppQuit = 3,
        AppLaunchNotification = 4,
    }

    enum AppleEventKind : int
    {
        AppleEvent = 1,
    }

    internal enum EventParamName : int 
    {
        // Mouse Events
        MouseLocation = 0x6d6c6f63,       // typeHIPoint
        WindowMouseLocation = 0x776d6f75, // typeHIPoint
        MouseButton = 0x6d62746e,         // typeMouseButton
        ClickCount = 0x63636e74,          // typeUInt32
        MouseWheelAxis = 0x6d776178,      // typeMouseWheelAxis
        MouseWheelDelta = 0x6d77646c,     // typeSInt32
        MouseDelta = 0x6d647461,          // typeHIPoint

        // Keyboard events
        KeyCode = 0x6b636f64,             // typeUInt32
        KeyMacCharCode = 0x6b636872,      // typechar
        KeyModifiers = 0x6b6d6f64,        // typeUInt32
        
    }
    internal enum EventParamType : int
    {
        typeMouseButton = 0x6d62746e,
        typeMouseWheelAxis = 0x6d776178,
        typeHIPoint = 0x68697074,
        typeHISize = 0x6869737a,
        typeHIRect = 0x68697263,

        typeChar = 0x54455854,

        typeUInt32 = 0x6d61676e,
        typeSInt32 = 0x6c6f6e67,
        typeSInt16 = 0x73686f72,
        typeSInt64 = 0x636f6d70,
        typeIEEE32BitFloatingPoint = 0x73696e67,
        typeIEEE64BitFloatingPoint = 0x646f7562,
    }

    public enum EventMouseButton : int
    {
        Primary = 0,
        Secondary = 1,
        Tertiary = 2,
    }

    internal enum WindowRegionCode : int 
    {
        TitleBarRegion = 0,
        TitleTextRegion = 1,
        CloseBoxRegion = 2,
        ZoomBoxRegion = 3,
        DragRegion = 5,
        GrowRegion = 6,
        CollapseBoxRegion = 7,
        TitleProxyIconRegion = 8,
        StructureRegion = 32,
        ContentRegion = 33,
        UpdateRegion = 34,
        OpaqueRegion = 35,
        GlobalPortRegion = 40,
        ToolbarButtonRegion = 41
    };

    #endregion

    #region --- MacWindows.h ---

    internal enum WindowClass : uint
    {
        Alert            = 1,             /* "I need your attention now."*/
        MovableAlert     = 2,             /* "I need your attention now, but I'm kind enough to let you switch out of this app to do other things."*/
        Modal            = 3,             /* system modal, not draggable*/
        MovableModal     = 4,             /* application modal, draggable*/
        Floating         = 5,             /* floats above all other application windows*/
        Document         = 6,             /* document windows*/
        Desktop          = 7,             /* desktop window (usually only one of these exists) - OS X only in CarbonLib 1.0*/
        Utility          = 8,             /* Available in CarbonLib 1.1 and later, and in Mac OS X*/
        Help             = 10,            /* Available in CarbonLib 1.1 and later, and in Mac OS X*/
        Sheet            = 11,            /* Available in CarbonLib 1.3 and later, and in Mac OS X*/
        Toolbar          = 12,            /* Available in CarbonLib 1.1 and later, and in Mac OS X*/
        Plain            = 13,            /* Available in CarbonLib 1.2.5 and later, and Mac OS X*/
        Overlay          = 14,            /* Available in Mac OS X*/
        SheetAlert       = 15,            /* Available in CarbonLib 1.3 and later, and in Mac OS X 10.1 and later*/
        AltPlain         = 16,            /* Available in CarbonLib 1.3 and later, and in Mac OS X 10.1 and later*/
        Drawer           = 20,            /* Available in Mac OS X 10.2 or later*/
        All              = 0xFFFFFFFFu    /* for use with GetFrontWindowOfClass, FindWindowOfClass, GetNextWindowOfClass*/
    }

    [Flags]
    internal enum WindowAttributes : uint
    {
        NoAttributes         = 0u,         /* no attributes*/
        CloseBox             = (1u << 0),  /* window has a close box*/
        HorizontalZoom       = (1u << 1),  /* window has horizontal zoom box*/
        VerticalZoom         = (1u << 2),  /* window has vertical zoom box*/
        FullZoom             = (VerticalZoom | HorizontalZoom),
        CollapseBox          = (1u << 3),  /* window has a collapse box*/
        Resizable            = (1u << 4),  /* window is resizable*/
        SideTitlebar         = (1u << 5),  /* window wants a titlebar on the side    (floating window class only)*/
        NoUpdates            = (1u << 16), /* this window receives no update events*/
        NoActivates          = (1u << 17), /* this window receives no activate events*/
        NoBuffering          = (1u << 20), /* this window is not buffered (Mac OS X only)*/
        StandardHandler      = (1u << 25),
        InWindowMenu         = (1u << 27),
        LiveResize           = (1u << 28),
        StandardDocument     = (CloseBox | FullZoom | CollapseBox | Resizable),
        StandardFloating     = (CloseBox | CollapseBox)
    }

    internal enum WindowPositionMethod : uint
    {
        CenterOnMainScreen = 1,
        CenterOnParentWindow = 2,
        CenterOnParentWindowScreen = 3,
        CascadeOnMainScreen = 4,
        CascadeOnParentWindow = 5,
        CascadeOnParentWindowScreen = 6,
        CascadeStartAtParentWindowScreen = 10,
        AlertPositionOnMainScreen = 7,
        AlertPositionOnParentWindow = 8,
        AlertPositionOnParentWindowScreen = 9
    }

    internal delegate OSStatus MacOSEventHandler(IntPtr inCaller, IntPtr inEvent, IntPtr userData);

    internal enum WindowPartCode : short 
    {
        inDesk = 0,
        inNoWindow = 0,
        inMenuBar = 1,
        inSysWindow = 2,
        inContent = 3,
        inDrag = 4,
        inGrow = 5,
        inGoAway = 6,
        inZoomIn = 7,
        inZoomOut = 8,
        inCollapseBox = 11,
        inProxyIcon = 12,
        inToolbarButton = 13,
        inStructure = 15,
    }

    #endregion
    #region --- Enums from gestalt.h ---

    internal enum GestaltSelector
    {
        SystemVersion       = 0x73797376,  // FOUR_CHAR_CODE("sysv"), /* system version*/
        SystemVersionMajor  = 0x73797331,  // FOUR_CHAR_CODE("sys1"), /* The major system version number; in 10.4.17 this would be the decimal value 10 */
        SystemVersionMinor  = 0x73797332,  // FOUR_CHAR_CODE("sys2"), /* The minor system version number; in 10.4.17 this would be the decimal value 4 */
        SystemVersionBugFix = 0x73797333,  // FOUR_CHAR_CODE("sys3") /* The bug fix system version number; in 10.4.17 this would be the decimal value 17 */
    };

    #endregion

    enum HICoordinateSpace 
    {
        _72DPIGlobal      = 1,
        ScreenPixel      = 2,
        Window           = 3,
        View             = 4
};

    #region --- Carbon API Methods ---

    public partial class API
    {
        const string carbon = "/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon";
        
        [DllImport(carbon)]
        internal static extern EventClass GetEventClass(IntPtr inEvent);
        [DllImport(carbon)]
        internal static extern uint GetEventKind(IntPtr inEvent);

        #region --- Window Construction ---

        [DllImport(carbon,EntryPoint="CreateNewWindow")]
        private static extern OSStatus _CreateNewWindow(WindowClass @class, WindowAttributes attributes, ref Rect r, out IntPtr window);

        internal static IntPtr CreateNewWindow(WindowClass @class, WindowAttributes attributes, Rect r)
        {
            IntPtr retval;
            OSStatus stat = _CreateNewWindow(@class, attributes, ref r, out retval);

            Debug.Print("Created Window: {0}", retval);

            if (stat != OSStatus.NoError)
            {
                throw new MacOSException(stat);
            }

            return retval;
        }

        [DllImport(carbon)]
        internal static extern void DisposeWindow(IntPtr window);

        #endregion
        #region --- Showing / Hiding Windows ---

        [DllImport(carbon)]
        internal static extern void ShowWindow(IntPtr window);
        [DllImport(carbon)]
        internal static extern void HideWindow(IntPtr window);
        [DllImport(carbon)]
        internal static extern bool IsWindowVisible(IntPtr window);
        [DllImport(carbon)]
        internal static extern void SelectWindow(IntPtr window);

        #endregion
        #region --- Window Boundaries ---

        [DllImport(carbon)]
        internal static extern OSStatus RepositionWindow(IntPtr window, IntPtr parentWindow, WindowPositionMethod method);
        [DllImport(carbon)]
        internal static extern void SizeWindow(IntPtr window, short w, short h, bool fUpdate);
        [DllImport(carbon)]
        internal static extern void MoveWindow(IntPtr window, short x, short y, bool fUpdate);

        [DllImport(carbon)]
        static extern OSStatus GetWindowBounds(IntPtr window, WindowRegionCode regionCode, out Rect globalBounds);
        internal static Rect GetWindowBounds(IntPtr window, WindowRegionCode regionCode)
        {
            Rect retval;
            OSStatus result = GetWindowBounds(window, regionCode, out retval);

            if (result != OSStatus.NoError)
                throw new MacOSException(result);

            return retval;
        }

        //[DllImport(carbon)]
        //internal static extern void MoveWindow(IntPtr window, short hGlobal, short vGlobal, bool front);

        #endregion
        #region --- Processing Events ---

        [DllImport(carbon)]
        static extern IntPtr GetEventDispatcherTarget();

        [DllImport(carbon,EntryPoint="ReceiveNextEvent")]
        static extern OSStatus ReceiveNextEvent(uint inNumTypes,
            IntPtr inList,
            double inTimeout,
            bool inPullEvent,
            out IntPtr outEvent);

        [DllImport(carbon)]
        static extern void SendEventToEventTarget(IntPtr theEvent, IntPtr theTarget);

        [DllImport(carbon)]
        static extern void ReleaseEvent(IntPtr theEvent);

        // Processes events in the queue and then returns.
        internal static void ProcessEvents()
        {
            IntPtr theEvent;
            IntPtr theTarget = GetEventDispatcherTarget();
            
            for (;;)
            {
                OSStatus status = ReceiveNextEvent(0, IntPtr.Zero, 0.0, true, out theEvent);

                if (status == OSStatus.EventLoopTimedOut)
                    break;

                if (status != OSStatus.NoError)
                {
                    Debug.Print("Message Loop status: {0}", status);
                    break;
                }
                if (theEvent == IntPtr.Zero)
                    break;

                try
                {
                    SendEventToEventTarget(theEvent, theTarget);
                }
                catch (System.ExecutionEngineException e)
                {
                    Console.Error.WriteLine("ExecutionEngineException caught.");
                    Console.Error.WriteLine("theEvent: " + new EventInfo(theEvent).ToString());
                    Console.Error.WriteLine(e.Message);
                    Console.Error.WriteLine(e.StackTrace);
                }

                ReleaseEvent(theEvent);
            }

        }

        #region --- Processing apple event ---

        [StructLayout(LayoutKind.Sequential)]

        struct EventRecord 
        {
            public ushort what;
            public uint message;
            public uint when;
            public Point where;
            public uint modifiers;
        }

        [DllImport(carbon)]
        static extern bool ConvertEventRefToEventRecord(IntPtr inEvent, out EventRecord outEvent);

        [DllImport(carbon)]
        static extern OSStatus AEProcessAppleEvent(ref EventRecord theEventRecord);

        static internal void ProcessAppleEvent(IntPtr inEvent)
        {
            EventRecord record;

            ConvertEventRefToEventRecord(inEvent, out record);
            AEProcessAppleEvent(ref record);
        }

        #endregion

        #endregion
        #region --- Getting Event Parameters ---

        [DllImport(carbon)]
        static extern OSStatus GetEventParameter(
            IntPtr inEvent, EventParamName inName, EventParamType inDesiredType,
            IntPtr outActualType, uint inBufferSize, IntPtr outActualSize, IntPtr outData);

        static internal MacOSKeyCode GetEventKeyboardKeyCode(IntPtr inEvent)
        {
            int code;

            unsafe
            {
                int* codeAddr = &code;

                OSStatus result = API.GetEventParameter(inEvent,
                     EventParamName.KeyCode, EventParamType.typeUInt32, IntPtr.Zero,
                     (uint)System.Runtime.InteropServices.Marshal.SizeOf(typeof(UInt32)), IntPtr.Zero,
                     (IntPtr) codeAddr);

                if (result != OSStatus.NoError)
                {
                    throw new MacOSException(result);
                }
            }

            return (MacOSKeyCode)code;
        }

        internal static char GetEventKeyboardChar(IntPtr inEvent)
        {
            char code;

            unsafe
            {
                char* codeAddr = &code;

                OSStatus result = API.GetEventParameter(inEvent,
                     EventParamName.KeyMacCharCode, EventParamType.typeChar, IntPtr.Zero,
                     (uint)System.Runtime.InteropServices.Marshal.SizeOf(typeof(char)), IntPtr.Zero,
                     (IntPtr)codeAddr);

                if (result != OSStatus.NoError)
                {
                    throw new MacOSException(result);
                }
            }

            return code;
        }

        static internal MouseButton GetEventMouseButton(IntPtr inEvent)
        {
            int button;

            unsafe
            {
                int* btn = &button;

                OSStatus result = API.GetEventParameter(inEvent,
                        EventParamName.MouseButton, EventParamType.typeMouseButton, IntPtr.Zero,
                        (uint)System.Runtime.InteropServices.Marshal.SizeOf(typeof(short)), IntPtr.Zero,
                        (IntPtr)btn);

                if (result != OSStatus.NoError)
                    throw new MacOSException(result);
            }

            return (MouseButton)button;
        }
        static internal OSStatus GetEventWindowMouseLocation(IntPtr inEvent, out HIPoint pt)
        {
            HIPoint point;

            unsafe
            {
                HIPoint* parm = &point;

                OSStatus result = API.GetEventParameter(inEvent,
                        EventParamName.WindowMouseLocation, EventParamType.typeHIPoint, IntPtr.Zero,
                        (uint)System.Runtime.InteropServices.Marshal.SizeOf(typeof(HIPoint)), IntPtr.Zero,
                        (IntPtr)parm);

                pt = point;

                return result;
            }

        }
        static internal OSStatus GetEventMouseLocation(IntPtr inEvent, out HIPoint pt)
        {
            HIPoint point;

            unsafe
            {
                HIPoint* parm = &point;

                OSStatus result = API.GetEventParameter(inEvent,
                        EventParamName.MouseLocation, EventParamType.typeHIPoint, IntPtr.Zero,
                        (uint)System.Runtime.InteropServices.Marshal.SizeOf(typeof(HIPoint)), IntPtr.Zero,
                        (IntPtr)parm);

                pt = point;

                return result;
            }

        }
        static internal MacOSKeyModifiers GetEventKeyModifiers(IntPtr inEvent)
        {
            uint code;

            unsafe
            {
                uint* codeAddr = &code;

                OSStatus result = API.GetEventParameter(inEvent,
                     EventParamName.KeyModifiers, EventParamType.typeUInt32, IntPtr.Zero,
                     (uint)System.Runtime.InteropServices.Marshal.SizeOf(typeof(uint)), IntPtr.Zero,
                     (IntPtr)codeAddr);

                if (result != OSStatus.NoError)
                {
                    throw new MacOSException(result);
                }
            }

            return (MacOSKeyModifiers)code;
        }

        #endregion
        #region --- Event Handlers ---

        [DllImport(carbon,EntryPoint="InstallEventHandler")]
        static extern OSStatus _InstallEventHandler(
                                IntPtr eventTargetRef, IntPtr handlerProc, 
                                int numtypes, EventTypeSpec[] typeList, 
                                IntPtr userData, IntPtr handlerRef);

        internal static void InstallWindowEventHandler(IntPtr windowRef, IntPtr uppHandlerProc, 
                EventTypeSpec[] eventTypes, IntPtr userData, IntPtr handlerRef)
        {
            IntPtr windowTarget = GetWindowEventTarget(windowRef);

            Debug.Print("Window: {0}", windowRef);
            Debug.Print("Window Target: {0}", windowTarget);
            Debug.Print("Handler: {0}", uppHandlerProc);
            Debug.Print("Num Events: {0}", eventTypes.Length);
            Debug.Print("User Data: {0}", userData);
            Debug.Print("Handler Ref: {0}", handlerRef);

            OSStatus error = _InstallEventHandler(windowTarget, uppHandlerProc, 
                                    eventTypes.Length, eventTypes,
                                    userData, handlerRef);

            Debug.Print("Status: {0}", error);

            if (error != OSStatus.NoError)
            {
                throw new MacOSException(error);
            }
        }

        internal static void InstallApplicationEventHandler(IntPtr uppHandlerProc, 
                EventTypeSpec[] eventTypes, IntPtr userData, IntPtr handlerRef)
        {

            OSStatus error = _InstallEventHandler(GetApplicationEventTarget(), uppHandlerProc, 
                                    eventTypes.Length, eventTypes,
                                    userData, handlerRef);

            if (error != OSStatus.NoError)
            {
                throw new MacOSException(error);
            }

        }

        [DllImport(carbon)]
        internal static extern OSStatus RemoveEventHandler(IntPtr inHandlerRef);

        #endregion
        #region --- GetWindowEventTarget ---

        [DllImport(carbon)]
        internal static extern IntPtr GetWindowEventTarget(IntPtr window);

        [DllImport(carbon)]
        internal static extern IntPtr GetApplicationEventTarget();

        #endregion
        #region --- UPP Event Handlers ---
        
        [DllImport(carbon)]
        internal static extern IntPtr NewEventHandlerUPP(MacOSEventHandler handler);

        [DllImport(carbon)]
        internal static extern void DisposeEventHandlerUPP(IntPtr userUPP);

        #endregion

        [DllImport(carbon)]
        static extern IntPtr GetControlBounds(IntPtr control, out Rect bounds);

        internal static Rect GetControlBounds(IntPtr control)
        {
            Rect retval;
            GetControlBounds(control, out retval);

            return retval;
        }

        [DllImport(carbon)]
        internal static extern OSStatus ActivateWindow (IntPtr inWindow, bool inActivate);

        [DllImport(carbon)]
        internal static extern void RunApplicationEventLoop();

        [DllImport(carbon)]
        internal static extern void QuitApplicationEventLoop();

        [DllImport(carbon)]
        internal static extern IntPtr GetControlOwner(IntPtr control);

        [DllImport(carbon)]
        internal static extern IntPtr HIViewGetWindow(IntPtr inView);

        [DllImport(carbon)]
        static extern OSStatus HIViewGetFrame(IntPtr inView, out HIRect outRect);
        internal static HIRect HIViewGetFrame(IntPtr inView)
        {
            HIRect retval;
            OSStatus result = HIViewGetFrame(inView, out retval);

            if (result != OSStatus.NoError)
                throw new MacOSException(result);

            return retval;
        }
        #region --- SetWindowTitle ---

        [DllImport(carbon)]
        static extern void SetWindowTitleWithCFString(IntPtr windowRef, IntPtr title);

        internal static void SetWindowTitle(IntPtr windowRef, string title)
        {
            IntPtr str = __CFStringMakeConstantString(title);

            Debug.Print("Setting window title: {0},   CFstring : {1},  Text : {2}", windowRef, str, title);

            SetWindowTitleWithCFString(windowRef, str);

            // Apparently releasing this reference to the CFConstantString here
            // causes the program to crash on the fourth window created.  But I am 
            // afraid that not releasing the string would result in a memory leak, but that would
            // only be a serious issue if the window title is changed a lot.
            //CFRelease(str);
        }

        #endregion
        
        [DllImport(carbon,EntryPoint="ChangeWindowAttributes")]
        static extern OSStatus _ChangeWindowAttributes(IntPtr windowRef, WindowAttributes setTheseAttributes, WindowAttributes clearTheseAttributes); 
          internal static void ChangeWindowAttributes(IntPtr windowRef, WindowAttributes setTheseAttributes, WindowAttributes clearTheseAttributes)
          {
              OSStatus error = _ChangeWindowAttributes(windowRef, setTheseAttributes, clearTheseAttributes);
              
            if (error != OSStatus.NoError)
            {
                throw new MacOSException(error);
            }
          }
  
        [DllImport(carbon)]
        static extern IntPtr __CFStringMakeConstantString(string cStr);

        [DllImport(carbon)]
        static extern void CFRelease(IntPtr cfStr);

        [DllImport(carbon)]
        internal static extern OSStatus CallNextEventHandler(IntPtr nextHandler, IntPtr theEvent);

        [DllImport(carbon)]
        internal static extern IntPtr GetWindowPort(IntPtr windowRef);
  
        #region --- Menus ---

        [DllImport(carbon)]
        internal static extern IntPtr AcquireRootMenu();


        #endregion

        [DllImport(carbon)]
        internal static extern bool IsWindowCollapsed(IntPtr windowRef);

        [DllImport(carbon, EntryPoint = "CollapseWindow")]
        static extern OSStatus _CollapseWindow(IntPtr windowRef, bool collapse);

        internal static void CollapseWindow(IntPtr windowRef, bool collapse)
        {
            OSStatus error = _CollapseWindow(windowRef, collapse);

            if (error != OSStatus.NoError)
            {
                throw new MacOSException(error);
            }
        }

        [DllImport(carbon, EntryPoint="IsWindowInStandardState")]
        static extern bool _IsWindowInStandardState(IntPtr windowRef, IntPtr inIdealSize, IntPtr outIdealStandardState);

        internal static bool IsWindowInStandardState(IntPtr windowRef)
        {
            return _IsWindowInStandardState(windowRef, IntPtr.Zero, IntPtr.Zero);
        }

        [DllImport(carbon, EntryPoint = "ZoomWindowIdeal")]
        unsafe static extern OSStatus _ZoomWindowIdeal(IntPtr windowRef, short inPartCode, IntPtr toIdealSize);

        internal static void ZoomWindowIdeal(IntPtr windowRef, WindowPartCode inPartCode, ref Point toIdealSize)
        {
            Point pt = toIdealSize;
            OSStatus error ;
            IntPtr handle = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Point)));
            Marshal.StructureToPtr(toIdealSize, handle, false);

            error = _ZoomWindowIdeal(windowRef, (short)inPartCode, handle);

            toIdealSize = (Point)Marshal.PtrToStructure(handle,typeof(Point));

            Marshal.FreeHGlobal(handle);

            if (error != OSStatus.NoError)
            {
                throw new MacOSException(error);
            }
        }

        [DllImport(carbon)]
        internal unsafe static extern OSStatus DMGetGDeviceByDisplayID(
            IntPtr displayID, out IntPtr displayDevice, Boolean failToMain);

        #region Nonworking HIPointConvert routines

        // These seem to crash when called, and I haven't figured out why.
        // Currently a workaround is used to convert from screen to client coordinates.

        //[DllImport(carbon, EntryPoint="HIPointConvert")]
        //extern static OSStatus _HIPointConvert(ref HIPoint ioPoint,
        //    HICoordinateSpace inSourceSpace, IntPtr inSourceObject,
        //    HICoordinateSpace inDestinationSpace, IntPtr inDestinationObject);

        //internal static HIPoint HIPointConvert(HIPoint inPoint,
        //    HICoordinateSpace inSourceSpace, IntPtr inSourceObject,
        //    HICoordinateSpace inDestinationSpace, IntPtr inDestinationObject)
        //{
        //    OSStatus error = _HIPointConvert(ref inPoint, inSourceSpace, inSourceObject, inDestinationSpace, inDestinationObject);

        //    if (error != OSStatus.NoError)
        //    {
        //        throw new MacOSException(error);
        //    }

        //    return inPoint;
        //}

        //[DllImport(carbon, EntryPoint = "HIViewConvertPoint")]
        //extern static OSStatus _HIViewConvertPoint(ref HIPoint inPoint, IntPtr inSourceView, IntPtr inDestView);

        //internal static HIPoint HIViewConvertPoint( HIPoint point, IntPtr sourceHandle, IntPtr destHandle)
        //{
        //    //Carbon.Rect window_bounds = new Carbon.Rect();
        //    //Carbon.API.GetWindowBounds(handle, WindowRegionCode.StructureRegion /*32*/, out window_bounds);

        //    //point.X -= window_bounds.X;
        //    //point.Y -= window_bounds.Y;

        //    OSStatus error = _HIViewConvertPoint(ref point, sourceHandle, destHandle);

        //    if (error != OSStatus.NoError)
        //    {
        //        throw new MacOSException(error);
        //    }

        //   return point;
        //}

        #endregion

        const string gestaltlib = "/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon";


        [DllImport(gestaltlib)]
        internal static extern OSStatus Gestalt(GestaltSelector selector, out int response);
    }

    #endregion
    
}


