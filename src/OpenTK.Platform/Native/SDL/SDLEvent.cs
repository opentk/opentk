using OpenTK.Platform.Native.Windows;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform.Native.SDL
{
    [StructLayout(LayoutKind.Explicit, Size = 128)]
    internal struct SDLEvent
    {
        [FieldOffset(0)]
        public SDL_EventType Type;

        [FieldOffset(0)]
        public SDL_DisplayEvent DisplayEvent;

        [FieldOffset(0)]
        public SDL_WindowEvent Window;

        [FieldOffset(0)]
        public SDL_MouseMotionEvent MouseMotion;

        [FieldOffset(0)]
        public SDL_MouseButtonEvent MouseButton;

        [FieldOffset(0)]
        public SDL_MouseWheelEvent MouseWheel;

        [FieldOffset(0)]
        public SDL_DropEvent DropEvent;

        [FieldOffset(0)]
        public SDL_TextEditingEvent TextEditingEvent;

        [FieldOffset(0)]
        public SDL_TextInputEvent TextInputEvent;

        [FieldOffset(0)]
        public SDL_KeyboardEvent KeyboardEvent;

        [FieldOffset(0)]
        public SDL_ControllerDeviceEvent ControllerDeviceEvent;

        [FieldOffset(0)]
        public SDL_JoyDeviceEvent JoyDeviceEvent;

        [FieldOffset(0)]
        public SDL_UserEvent UserEvent;
    }

    internal struct SDL_DisplayEvent
    {
        public SDL_EventType type;        /* ::SDL_DISPLAYEVENT */
        public uint timestamp;            /* In milliseconds, populated using SDL_GetTicks() */
        public uint display;              /* The associated display index */
        public SDL_DisplayEventID @event; /* ::SDL_DisplayEventID */
        public byte padding1;
        public byte padding2;
        public byte padding3;
        public int data1;                 /* event dependent data */
    }

    internal struct SDL_WindowEvent
    {
        public SDL_EventType Type;        /* ::SDL_WINDOWEVENT */
        public uint timestamp;   /* In milliseconds, populated using SDL_GetTicks() */
        public uint windowID;    /* The associated window */
        public SDL_WindowEventID @event;        /* ::SDL_WindowEventID */
        public byte padding1;
        public byte padding2;
        public byte padding3;
        public int data1;       /* event dependent data */
        public int data2;       /* event dependent data */
    }

    internal struct SDL_Keysym
    {
        public SDL_Scancode scancode;      /* SDL physical key code - see ::SDL_Scancode for details */
        public SDL_Keycode sym;            /* SDL virtual key code - see ::SDL_Keycode for details */
        public ushort mod;                 /* current key modifiers */
        public ushort unused;
    }

    internal struct SDL_KeyboardEvent
    {
        public SDL_EventType type;        /* ::SDL_KEYDOWN or ::SDL_KEYUP */
        public uint timestamp;   /* In milliseconds, populated using SDL_GetTicks() */
        public uint windowID;    /* The window with keyboard focus, if any */
        public byte state;        /* ::SDL_PRESSED or ::SDL_RELEASED */
        public byte repeat;       /* Non-zero if this is a key repeat */
        public byte padding2;
        public byte padding3;
        public SDL_Keysym keysym;  /* The key that was pressed or released */
    }

    internal unsafe struct SDL_TextEditingEvent
    {
        public const int SDL_TEXTEDITINGEVENT_TEXT_SIZE = 32;

        public SDL_EventType type;          /* ::SDL_TEXTEDITING */
        public uint timestamp;     /* In milliseconds, populated using SDL_GetTicks() */
        public uint windowID;      /* The window with keyboard focus, if any */
        public fixed char text[SDL_TEXTEDITINGEVENT_TEXT_SIZE];  /* The editing text */
        public int start;          /* The start cursor of selected editing text */
        public int length;         /* The length of selected editing text */
    }

    internal unsafe struct SDL_TextInputEvent
    {
        public const int SDL_TEXTINPUTEVENT_TEXT_SIZE = 32;

        public SDL_EventType type;      /* ::SDL_TEXTINPUT */
        public uint timestamp; /* In milliseconds, populated using SDL_GetTicks() */
        public uint windowID;  /* The window with keyboard focus, if any */
        public fixed byte text[SDL_TEXTINPUTEVENT_TEXT_SIZE];  /* The input text */
    }

    internal struct SDL_MouseMotionEvent
    {
        public SDL_EventType type; /* ::SDL_MOUSEMOTION */
        public uint timestamp;     /* In milliseconds, populated using SDL_GetTicks() */
        public uint windowID;      /* The window with mouse focus, if any */
        public uint which;         /* The mouse instance id, or SDL_TOUCH_MOUSEID */
        public uint state;         /* The current button state */
        public int x;              /* X coordinate, relative to window */
        public int y;              /* Y coordinate, relative to window */
        public int xrel;           /* The relative motion in the X direction */
        public int yrel;           /* The relative motion in the Y direction */
    }

    internal struct SDL_MouseButtonEvent
    {
        public SDL_EventType type; /* ::SDL_MOUSEBUTTONDOWN or ::SDL_MOUSEBUTTONUP */
        public uint timestamp;     /* In milliseconds, populated using SDL_GetTicks() */
        public uint windowID;      /* The window with mouse focus, if any */
        public uint which;         /* The mouse instance id, or SDL_TOUCH_MOUSEID */
        public SDL_BUTTON button;  /* The mouse button index */
        public byte state;         /* ::SDL_PRESSED or ::SDL_RELEASED */
        public byte clicks;        /* 1 for single-click, 2 for double-click, etc. */
        public byte padding1;
        public int x;              /* X coordinate, relative to window */
        public int y;              /* Y coordinate, relative to window */
    }

    internal struct SDL_MouseWheelEvent
    {
        public SDL_EventType type;         /* ::SDL_MOUSEWHEEL */
        public uint timestamp;    /* In milliseconds, populated using SDL_GetTicks() */
        public uint windowID;     /* The window with mouse focus, if any */
        public uint which;        /* The mouse instance id, or SDL_TOUCH_MOUSEID */
        public int x;             /* The amount scrolled horizontally, positive to the right and negative to the left */
        public int y;             /* The amount scrolled vertically, positive away from the user and negative toward the user */
        public uint direction;    /* Set to one of the SDL_MOUSEWHEEL_* defines. When FLIPPED the values in X and Y will be opposite. Multiply by -1 to change them back */
        public float preciseX;    /* The amount scrolled horizontally, positive to the right and negative to the left, with float precision (added in 2.0.18) */
        public float preciseY;    /* The amount scrolled vertically, positive away from the user and negative toward the user, with float precision (added in 2.0.18) */
        public int mouseX;        /* X coordinate, relative to window (added in 2.26.0) */
        public int mouseY;        /* Y coordinate, relative to window (added in 2.26.0) */
    }

    internal unsafe struct SDL_DropEvent
    {
        public SDL_EventType type; /* ::SDL_DROPBEGIN or ::SDL_DROPFILE or ::SDL_DROPTEXT or ::SDL_DROPCOMPLETE */
        public uint timestamp;     /* In milliseconds, populated using SDL_GetTicks() */
        public char* file;         /* The file name, which should be freed with SDL_free(), is NULL on begin/complete */
        public uint windowID;      /* The window that was dropped on, if any */
    }

    internal struct SDL_ControllerDeviceEvent
    {
        public SDL_EventType type; /* ::SDL_CONTROLLERDEVICEADDED, ::SDL_CONTROLLERDEVICEREMOVED, or ::SDL_CONTROLLERDEVICEREMAPPED */
        public uint timestamp;     /* In milliseconds, populated using SDL_GetTicks() */
        public int which;          /* The joystick device index for the ADDED event, instance id for the REMOVED or REMAPPED event */
    }

    struct SDL_JoyDeviceEvent
    {
        public SDL_EventType type; /* SDL_JOYDEVICEADDED or SDL_JOYDEVICEREMOVED */
        public uint timestamp;     /* In milliseconds, populated using SDL_GetTicks() */
        public int which;          /* The joystick device index for the ADDED event, instance id for the REMOVED event */
    }

    internal struct SDL_UserEvent
    {
        public SDL_EventType type; /*< SDL_EVENT_USER through SDL_EVENT_LAST-1, Uint32 because these are not in the SDL_EventType enumeration */
        public uint reserved;
        public ulong timestamp;    /*< In nanoseconds, populated using SDL_GetTicksNS() */
        public uint windowID;      /*< The associated window if any */
        public int code;           /*< User defined event code */
        public IntPtr data1;       /*< User defined data pointer */
        public IntPtr data2;       /*< User defined data pointer */
    }

    internal enum SDL_EventType
    {
        SDL_FIRSTEVENT = 0,     /* Unused (do not remove) */

        /* Application events */
        SDL_QUIT = 0x100, /* User-requested quit */

        /* These application events have special meaning on iOS, see README-ios.md for details */
        SDL_APP_TERMINATING,        /* The application is being terminated by the OS
                                     Called on iOS in applicationWillTerminate()
                                     Called on Android in onDestroy()
                                */
        SDL_APP_LOWMEMORY,          /* The application is low on memory, free memory if possible.
                                     Called on iOS in applicationDidReceiveMemoryWarning()
                                     Called on Android in onLowMemory()
                                */
        SDL_APP_WILLENTERBACKGROUND, /* The application is about to enter the background
                                     Called on iOS in applicationWillResignActive()
                                     Called on Android in onPause()
                                */
        SDL_APP_DIDENTERBACKGROUND, /* The application did enter the background and may not get CPU for some time
                                     Called on iOS in applicationDidEnterBackground()
                                     Called on Android in onPause()
                                */
        SDL_APP_WILLENTERFOREGROUND, /* The application is about to enter the foreground
                                     Called on iOS in applicationWillEnterForeground()
                                     Called on Android in onResume()
                                */
        SDL_APP_DIDENTERFOREGROUND, /* The application is now interactive
                                     Called on iOS in applicationDidBecomeActive()
                                     Called on Android in onResume()
                                */

        SDL_LOCALECHANGED,  /* The user's locale preferences have changed. */

        /* Display events */
        SDL_DISPLAYEVENT = 0x150,  /* Display state change */

        /* Window events */
        SDL_WINDOWEVENT = 0x200, /* Window state change */
        SDL_SYSWMEVENT,             /* System specific event */

        /* Keyboard events */
        SDL_KEYDOWN = 0x300, /* Key pressed */
        SDL_KEYUP,                  /* Key released */
        SDL_TEXTEDITING,            /* Keyboard text editing (composition) */
        SDL_TEXTINPUT,              /* Keyboard text input */
        SDL_KEYMAPCHANGED,          /* Keymap changed due to a system event such as an
                                     input language or keyboard layout change.
                                */
        SDL_TEXTEDITING_EXT,       /* Extended keyboard text editing (composition) */

        /* Mouse events */
        SDL_MOUSEMOTION = 0x400, /* Mouse moved */
        SDL_MOUSEBUTTONDOWN,        /* Mouse button pressed */
        SDL_MOUSEBUTTONUP,          /* Mouse button released */
        SDL_MOUSEWHEEL,             /* Mouse wheel motion */

        /* Joystick events */
        SDL_JOYAXISMOTION = 0x600, /* Joystick axis motion */
        SDL_JOYBALLMOTION,          /* Joystick trackball motion */
        SDL_JOYHATMOTION,           /* Joystick hat position change */
        SDL_JOYBUTTONDOWN,          /* Joystick button pressed */
        SDL_JOYBUTTONUP,            /* Joystick button released */
        SDL_JOYDEVICEADDED,         /* A new joystick has been inserted into the system */
        SDL_JOYDEVICEREMOVED,       /* An opened joystick has been removed */
        SDL_JOYBATTERYUPDATED,      /* Joystick battery level change */

        /* Game controller events */
        SDL_CONTROLLERAXISMOTION = 0x650, /* Game controller axis motion */
        SDL_CONTROLLERBUTTONDOWN,          /* Game controller button pressed */
        SDL_CONTROLLERBUTTONUP,            /* Game controller button released */
        SDL_CONTROLLERDEVICEADDED,         /* A new Game controller has been inserted into the system */
        SDL_CONTROLLERDEVICEREMOVED,       /* An opened Game controller has been removed */
        SDL_CONTROLLERDEVICEREMAPPED,      /* The controller mapping was updated */
        SDL_CONTROLLERTOUCHPADDOWN,        /* Game controller touchpad was touched */
        SDL_CONTROLLERTOUCHPADMOTION,      /* Game controller touchpad finger was moved */
        SDL_CONTROLLERTOUCHPADUP,          /* Game controller touchpad finger was lifted */
        SDL_CONTROLLERSENSORUPDATE,        /* Game controller sensor was updated */

        /* Touch events */
        SDL_FINGERDOWN = 0x700,
        SDL_FINGERUP,
        SDL_FINGERMOTION,

        /* Gesture events */
        SDL_DOLLARGESTURE = 0x800,
        SDL_DOLLARRECORD,
        SDL_MULTIGESTURE,

        /* Clipboard events */
        SDL_CLIPBOARDUPDATE = 0x900, /* The clipboard or primary selection changed */

        /* Drag and drop events */
        SDL_DROPFILE = 0x1000, /* The system requests a file open */
        SDL_DROPTEXT,                 /* text/plain drag-and-drop event */
        SDL_DROPBEGIN,                /* A new set of drops is beginning (NULL filename) */
        SDL_DROPCOMPLETE,             /* Current set of drops is now complete (NULL filename) */

        /* Audio hotplug events */
        SDL_AUDIODEVICEADDED = 0x1100, /* A new audio device is available */
        SDL_AUDIODEVICEREMOVED,        /* An audio device has been removed. */

        /* Sensor events */
        SDL_SENSORUPDATE = 0x1200,     /* A sensor was updated */

        /* Render events */
        SDL_RENDER_TARGETS_RESET = 0x2000, /* The render targets have been reset and their contents need to be updated */
        SDL_RENDER_DEVICE_RESET, /* The device has been reset and all textures need to be recreated */

        /* Internal events */
        SDL_POLLSENTINEL = 0x7F00, /* Signals the end of an event poll cycle */

        /* Events ::SDL_USEREVENT through ::SDL_LASTEVENT are for your use,
         *  and should be allocated with SDL_RegisterEvents()
         */
        SDL_USEREVENT = 0x8000,

        /*
         *  This last event is only for bounding internal arrays
         */
        SDL_LASTEVENT = 0xFFFF
    }

    internal enum SDL_WindowEventID : byte
    {
        SDL_WINDOWEVENT_NONE,           /* Never used */
        SDL_WINDOWEVENT_SHOWN,          /* Window has been shown */
        SDL_WINDOWEVENT_HIDDEN,         /* Window has been hidden */
        SDL_WINDOWEVENT_EXPOSED,        /* Window has been exposed and should be
                                         redrawn */
        SDL_WINDOWEVENT_MOVED,          /* Window has been moved to data1, data2
                                     */
        SDL_WINDOWEVENT_RESIZED,        /* Window has been resized to data1xdata2 */
        SDL_WINDOWEVENT_SIZE_CHANGED,   /* The window size has changed, either as
                                         a result of an API call or through the
                                         system or user changing the window size. */
        SDL_WINDOWEVENT_MINIMIZED,      /* Window has been minimized */
        SDL_WINDOWEVENT_MAXIMIZED,      /* Window has been maximized */
        SDL_WINDOWEVENT_RESTORED,       /* Window has been restored to normal size
                                         and position */
        SDL_WINDOWEVENT_ENTER,          /* Window has gained mouse focus */
        SDL_WINDOWEVENT_LEAVE,          /* Window has lost mouse focus */
        SDL_WINDOWEVENT_FOCUS_GAINED,   /* Window has gained keyboard focus */
        SDL_WINDOWEVENT_FOCUS_LOST,     /* Window has lost keyboard focus */
        SDL_WINDOWEVENT_CLOSE,          /* The window manager requests that the window be closed */
        SDL_WINDOWEVENT_TAKE_FOCUS,     /* Window is being offered a focus (should SetWindowInputFocus() on itself or a subwindow, or ignore) */
        SDL_WINDOWEVENT_HIT_TEST,       /* Window had a hit test that wasn't SDL_HITTEST_NORMAL. */
        SDL_WINDOWEVENT_ICCPROF_CHANGED,/* The ICC profile of the window's display has changed. */
        SDL_WINDOWEVENT_DISPLAY_CHANGED /* Window has been moved to display data1. */
    }

    internal enum SDL_DisplayEventID : byte
    {
        SDL_DISPLAYEVENT_NONE,          /* Never used */
        SDL_DISPLAYEVENT_ORIENTATION,   /* Display orientation has changed to data1 */
        SDL_DISPLAYEVENT_CONNECTED,     /* Display has been added to the system */
        SDL_DISPLAYEVENT_DISCONNECTED,  /* Display has been removed from the system */
        SDL_DISPLAYEVENT_MOVED          /* Display has changed position */
    }
}
