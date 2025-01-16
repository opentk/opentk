using System;

namespace OpenTK.Platform.Native.SDL
{
    [Flags]
    internal enum SDL_INIT : uint
    {
        SDL_INIT_TIMER = 0x00000001u,
        SDL_INIT_AUDIO = 0x00000010u,
        /* SDL_INIT_VIDEO implies SDL_INIT_EVENTS */
        SDL_INIT_VIDEO = 0x00000020u,
        /* SDL_INIT_JOYSTICK implies SDL_INIT_EVENTS */
        SDL_INIT_JOYSTICK = 0x00000200u,
        SDL_INIT_HAPTIC = 0x00001000u,
        /* SDL_INIT_GAMECONTROLLER implies SDL_INIT_JOYSTICK */
        SDL_INIT_GAMECONTROLLER = 0x00002000u,
        SDL_INIT_EVENTS = 0x00004000u,
        SDL_INIT_SENSOR = 0x00008000u,
        /* compatibility; this flag is ignored. */
        SDL_INIT_NOPARACHUTE = 0x00100000u,
    }

    [Flags]
    internal enum SDL_WindowFlags : uint
    {
        SDL_WINDOW_FULLSCREEN = 0x00000001,         /* fullscreen window */
        SDL_WINDOW_OPENGL = 0x00000002,             /* window usable with OpenGL context */
        SDL_WINDOW_SHOWN = 0x00000004,              /* window is visible */
        SDL_WINDOW_HIDDEN = 0x00000008,             /* window is not visible */
        SDL_WINDOW_BORDERLESS = 0x00000010,         /* no window decoration */
        SDL_WINDOW_RESIZABLE = 0x00000020,          /* window can be resized */
        SDL_WINDOW_MINIMIZED = 0x00000040,          /* window is minimized */
        SDL_WINDOW_MAXIMIZED = 0x00000080,          /* window is maximized */
        SDL_WINDOW_MOUSE_GRABBED = 0x00000100,      /* window has grabbed mouse input */
        SDL_WINDOW_INPUT_FOCUS = 0x00000200,        /* window has input focus */
        SDL_WINDOW_MOUSE_FOCUS = 0x00000400,        /* window has mouse focus */
        SDL_WINDOW_FULLSCREEN_DESKTOP = (SDL_WINDOW_FULLSCREEN | 0x00001000),
        SDL_WINDOW_FOREIGN = 0x00000800,            /* window not created by SDL */
        SDL_WINDOW_ALLOW_HIGHDPI = 0x00002000,      /* window should be created in high-DPI mode if supported.
                                                     On macOS NSHighResolutionCapable must be set true in the
                                                     application's Info.plist for this to have any effect. */
        SDL_WINDOW_MOUSE_CAPTURE = 0x00004000,   /* window has mouse captured (unrelated to MOUSE_GRABBED) */
        SDL_WINDOW_ALWAYS_ON_TOP = 0x00008000,   /* window should always be above others */
        SDL_WINDOW_SKIP_TASKBAR = 0x00010000,   /* window should not be added to the taskbar */
        SDL_WINDOW_UTILITY = 0x00020000,   /* window should be treated as a utility window */
        SDL_WINDOW_TOOLTIP = 0x00040000,   /* window should be treated as a tooltip */
        SDL_WINDOW_POPUP_MENU = 0x00080000,   /* window should be treated as a popup menu */
        SDL_WINDOW_KEYBOARD_GRABBED = 0x00100000,   /* window has grabbed keyboard input */
        SDL_WINDOW_VULKAN = 0x10000000,   /* window usable for Vulkan surface */
        SDL_WINDOW_METAL = 0x20000000,   /* window usable for Metal view */

        SDL_WINDOW_INPUT_GRABBED = SDL_WINDOW_MOUSE_GRABBED, /* equivalent to SDL_WINDOW_MOUSE_GRABBED for compatibility */
    }

    internal enum SDL_FullscreenMode : uint
    {
        SDL_WINDOW_FULLSCREEN = 0x00000001,         /* fullscreen window */
        SDL_WINDOW_FULLSCREEN_DESKTOP = (SDL_WINDOW_FULLSCREEN | 0x00001000),
    }

    internal enum SDL_BUTTON : byte
    {
        SDL_BUTTON_LEFT = 1,
        SDL_BUTTON_MIDDLE = 2,
        SDL_BUTTON_RIGHT = 3,
        SDL_BUTTON_X1 = 4,
        SDL_BUTTON_X2 = 5,
    }

    internal enum SDL_FlashOperation : int
    {
        SDL_FLASH_CANCEL,                   /* Cancel any window flash state */
        SDL_FLASH_BRIEFLY,                  /* Flash the window briefly to get attention */
        SDL_FLASH_UNTIL_FOCUSED             /* Flash the window until it gets focus */
    }

    enum SDL_GLattr : int
    {
        SDL_GL_RED_SIZE,
        SDL_GL_GREEN_SIZE,
        SDL_GL_BLUE_SIZE,
        SDL_GL_ALPHA_SIZE,
        SDL_GL_BUFFER_SIZE,
        SDL_GL_DOUBLEBUFFER,
        SDL_GL_DEPTH_SIZE,
        SDL_GL_STENCIL_SIZE,
        SDL_GL_ACCUM_RED_SIZE,
        SDL_GL_ACCUM_GREEN_SIZE,
        SDL_GL_ACCUM_BLUE_SIZE,
        SDL_GL_ACCUM_ALPHA_SIZE,
        SDL_GL_STEREO,
        SDL_GL_MULTISAMPLEBUFFERS,
        SDL_GL_MULTISAMPLESAMPLES,
        SDL_GL_ACCELERATED_VISUAL,
        SDL_GL_RETAINED_BACKING,
        SDL_GL_CONTEXT_MAJOR_VERSION,
        SDL_GL_CONTEXT_MINOR_VERSION,
        SDL_GL_CONTEXT_EGL,
        SDL_GL_CONTEXT_FLAGS,
        SDL_GL_CONTEXT_PROFILE_MASK,
        SDL_GL_SHARE_WITH_CURRENT_CONTEXT,
        SDL_GL_FRAMEBUFFER_SRGB_CAPABLE,
        SDL_GL_CONTEXT_RELEASE_BEHAVIOR,
        SDL_GL_CONTEXT_RESET_NOTIFICATION,
        SDL_GL_CONTEXT_NO_ERROR,
        SDL_GL_FLOATBUFFERS
    }

    enum SDL_GLprofile
    {
        SDL_GL_CONTEXT_PROFILE_CORE = 0x0001,
        SDL_GL_CONTEXT_PROFILE_COMPATIBILITY = 0x0002,
        SDL_GL_CONTEXT_PROFILE_ES = 0x0004 /* GLX_CONTEXT_ES2_PROFILE_BIT_EXT */
    }

    [Flags]
    enum SDL_GLcontextFlag
    {
        SDL_GL_CONTEXT_DEBUG_FLAG = 0x0001,
        SDL_GL_CONTEXT_FORWARD_COMPATIBLE_FLAG = 0x0002,
        SDL_GL_CONTEXT_ROBUST_ACCESS_FLAG = 0x0004,
        SDL_GL_CONTEXT_RESET_ISOLATION_FLAG = 0x0008
    }

    enum SDL_HitTestResult
    {
        SDL_HITTEST_NORMAL,  /* Region is normal. No special properties. */
        SDL_HITTEST_DRAGGABLE,  /* Region can drag entire window. */
        SDL_HITTEST_RESIZE_TOPLEFT,
        SDL_HITTEST_RESIZE_TOP,
        SDL_HITTEST_RESIZE_TOPRIGHT,
        SDL_HITTEST_RESIZE_RIGHT,
        SDL_HITTEST_RESIZE_BOTTOMRIGHT,
        SDL_HITTEST_RESIZE_BOTTOM,
        SDL_HITTEST_RESIZE_BOTTOMLEFT,
        SDL_HITTEST_RESIZE_LEFT
    }

    /* Pixel type. */
    enum SDL_PixelType
    {
        SDL_PIXELTYPE_UNKNOWN,
        SDL_PIXELTYPE_INDEX1,
        SDL_PIXELTYPE_INDEX4,
        SDL_PIXELTYPE_INDEX8,
        SDL_PIXELTYPE_PACKED8,
        SDL_PIXELTYPE_PACKED16,
        SDL_PIXELTYPE_PACKED32,
        SDL_PIXELTYPE_ARRAYU8,
        SDL_PIXELTYPE_ARRAYU16,
        SDL_PIXELTYPE_ARRAYU32,
        SDL_PIXELTYPE_ARRAYF16,
        SDL_PIXELTYPE_ARRAYF32
    }

    /* Bitmap pixel order, high bit -> low bit. */
    enum SDL_BitmapOrder
    {
        SDL_BITMAPORDER_NONE,
        SDL_BITMAPORDER_4321,
        SDL_BITMAPORDER_1234
    }

    /* Packed component order, high bit -> low bit. */
    enum SDL_PackedOrder
    {
        SDL_PACKEDORDER_NONE,
        SDL_PACKEDORDER_XRGB,
        SDL_PACKEDORDER_RGBX,
        SDL_PACKEDORDER_ARGB,
        SDL_PACKEDORDER_RGBA,
        SDL_PACKEDORDER_XBGR,
        SDL_PACKEDORDER_BGRX,
        SDL_PACKEDORDER_ABGR,
        SDL_PACKEDORDER_BGRA
    }

    /* Array component order, low byte -> high byte. */
    enum SDL_ArrayOrder
    {
        SDL_ARRAYORDER_NONE,
        SDL_ARRAYORDER_RGB,
        SDL_ARRAYORDER_BGR,
    }

    /* Packed component layout. */
    enum SDL_PackedLayout
    {
        SDL_PACKEDLAYOUT_NONE,
        SDL_PACKEDLAYOUT_332,
        SDL_PACKEDLAYOUT_4444,
        SDL_PACKEDLAYOUT_1555,
        SDL_PACKEDLAYOUT_5551,
        SDL_PACKEDLAYOUT_565,
        SDL_PACKEDLAYOUT_8888,
        SDL_PACKEDLAYOUT_2101010,
        SDL_PACKEDLAYOUT_1010102
    }

    // Incomplete, porting over all enum constants seemed like a pain.
    enum SDL_PixelFormatEnum : uint
    {
        /*
        #define SDL_DEFINE_PIXELFORMAT(type, order, layout, bits, bytes) \
            ((1 << 28) | ((type) << 24) | ((order) << 20) | ((layout) << 16) | \
            ((bits) << 8) | ((bytes) << 0))
        */

        SDL_PIXELFORMAT_RGB332 =
            (1 << 28) |
            (SDL_PixelType.SDL_PIXELTYPE_PACKED8 << 24) |
            (SDL_PackedOrder.SDL_PACKEDORDER_XRGB << 20) |
            (SDL_PackedLayout.SDL_PACKEDLAYOUT_332 << 16) |
            (8 << 8) |
            (1 << 0),

        SDL_PIXELFORMAT_RGB565 =
            (1 << 28) |
            (SDL_PixelType.SDL_PIXELTYPE_PACKED16 << 24) |
            (SDL_PackedOrder.SDL_PACKEDORDER_XRGB << 20) |
            (SDL_PackedLayout.SDL_PACKEDLAYOUT_565 << 16) |
            (16 << 8) |
            (2 << 0),

        SDL_PIXELFORMAT_XRGB8888 =
            (1 << 28) |
            (SDL_PixelType.SDL_PIXELTYPE_PACKED32 << 24) |
            (SDL_PackedOrder.SDL_PACKEDORDER_XRGB << 20) |
            (SDL_PackedLayout.SDL_PACKEDLAYOUT_8888 << 16) |
            (24 << 8) |
            (4 << 0),
        SDL_PIXELFORMAT_RGB888 = SDL_PIXELFORMAT_XRGB8888,

        SDL_PIXELFORMAT_RGBA8888 =
            (1 << 28) |
            (SDL_PixelType.SDL_PIXELTYPE_PACKED32 << 24) |
            (SDL_PackedOrder.SDL_PACKEDORDER_RGBA << 20) |
            (SDL_PackedLayout.SDL_PACKEDLAYOUT_8888 << 16) |
            (32 << 8) |
            (4 << 0),

        SDL_PIXELFORMAT_ARGB8888 =
            (1 << 28) |
            (SDL_PixelType.SDL_PIXELTYPE_PACKED32 << 24) |
            (SDL_PackedOrder.SDL_PACKEDORDER_ARGB << 20) |
            (SDL_PackedLayout.SDL_PACKEDLAYOUT_8888 << 16) |
            (32 << 8) |
            (4 << 0),

        SDL_PIXELFORMAT_ABGR8888 =
           (1 << 28) |
           (SDL_PixelType.SDL_PIXELTYPE_PACKED32 << 24) |
           (SDL_PackedOrder.SDL_PACKEDORDER_ABGR << 20) |
           (SDL_PackedLayout.SDL_PACKEDLAYOUT_8888 << 16) |
           (32 << 8) |
           (4 << 0),
    }

    enum SDL_PowerState : int
    {
        SDL_POWERSTATE_UNKNOWN,      /* cannot determine power status */
        SDL_POWERSTATE_ON_BATTERY,   /* Not plugged in, running on the battery */
        SDL_POWERSTATE_NO_BATTERY,   /* Plugged in, no battery available */
        SDL_POWERSTATE_CHARGING,     /* Plugged in, charging battery */
        SDL_POWERSTATE_CHARGED       /* Plugged in, battery charged */
    }

    enum SDL_SystemCursor : int
    {
        SDL_SYSTEM_CURSOR_ARROW,     /* Arrow */
        SDL_SYSTEM_CURSOR_IBEAM,     /* I-beam */
        SDL_SYSTEM_CURSOR_WAIT,      /* Wait */
        SDL_SYSTEM_CURSOR_CROSSHAIR, /* Crosshair */
        SDL_SYSTEM_CURSOR_WAITARROW, /* Small wait cursor (or Wait if not available) */
        SDL_SYSTEM_CURSOR_SIZENWSE,  /* Double arrow pointing northwest and southeast */
        SDL_SYSTEM_CURSOR_SIZENESW,  /* Double arrow pointing northeast and southwest */
        SDL_SYSTEM_CURSOR_SIZEWE,    /* Double arrow pointing west and east */
        SDL_SYSTEM_CURSOR_SIZENS,    /* Double arrow pointing north and south */
        SDL_SYSTEM_CURSOR_SIZEALL,   /* Four pointed arrow pointing north, south, east, and west */
        SDL_SYSTEM_CURSOR_NO,        /* Slashed circle or crossbones */
        SDL_SYSTEM_CURSOR_HAND,      /* Hand */
        SDL_NUM_SYSTEM_CURSORS
    }

    enum SDL_GameControllerAxis : int
    {
        SDL_CONTROLLER_AXIS_INVALID = -1,
        SDL_CONTROLLER_AXIS_LEFTX,
        SDL_CONTROLLER_AXIS_LEFTY,
        SDL_CONTROLLER_AXIS_RIGHTX,
        SDL_CONTROLLER_AXIS_RIGHTY,
        SDL_CONTROLLER_AXIS_TRIGGERLEFT,
        SDL_CONTROLLER_AXIS_TRIGGERRIGHT,
        SDL_CONTROLLER_AXIS_MAX
    }

    enum SDL_GameControllerButton : int
    {
        SDL_CONTROLLER_BUTTON_INVALID = -1,
        SDL_CONTROLLER_BUTTON_A,
        SDL_CONTROLLER_BUTTON_B,
        SDL_CONTROLLER_BUTTON_X,
        SDL_CONTROLLER_BUTTON_Y,
        SDL_CONTROLLER_BUTTON_BACK,
        SDL_CONTROLLER_BUTTON_GUIDE,
        SDL_CONTROLLER_BUTTON_START,
        SDL_CONTROLLER_BUTTON_LEFTSTICK,
        SDL_CONTROLLER_BUTTON_RIGHTSTICK,
        SDL_CONTROLLER_BUTTON_LEFTSHOULDER,
        SDL_CONTROLLER_BUTTON_RIGHTSHOULDER,
        SDL_CONTROLLER_BUTTON_DPAD_UP,
        SDL_CONTROLLER_BUTTON_DPAD_DOWN,
        SDL_CONTROLLER_BUTTON_DPAD_LEFT,
        SDL_CONTROLLER_BUTTON_DPAD_RIGHT,
        SDL_CONTROLLER_BUTTON_MISC1,    /* Xbox Series X share button, PS5 microphone button, Nintendo Switch Pro capture button, Amazon Luna microphone button */
        SDL_CONTROLLER_BUTTON_PADDLE1,  /* Xbox Elite paddle P1 (upper left, facing the back) */
        SDL_CONTROLLER_BUTTON_PADDLE2,  /* Xbox Elite paddle P3 (upper right, facing the back) */
        SDL_CONTROLLER_BUTTON_PADDLE3,  /* Xbox Elite paddle P2 (lower left, facing the back) */
        SDL_CONTROLLER_BUTTON_PADDLE4,  /* Xbox Elite paddle P4 (lower right, facing the back) */
        SDL_CONTROLLER_BUTTON_TOUCHPAD, /* PS4/PS5 touchpad button */
        SDL_CONTROLLER_BUTTON_MAX
    }

    enum SDL_JoystickPowerLevel : int
    {
        SDL_JOYSTICK_POWER_UNKNOWN = -1,
        SDL_JOYSTICK_POWER_EMPTY,   /* <= 5% */
        SDL_JOYSTICK_POWER_LOW,     /* <= 20% */
        SDL_JOYSTICK_POWER_MEDIUM,  /* <= 70% */
        SDL_JOYSTICK_POWER_FULL,    /* <= 100% */
        SDL_JOYSTICK_POWER_WIRED,
        SDL_JOYSTICK_POWER_MAX
    }

    [Flags]
    enum SDL_Keymod : int
    {
        KMOD_NONE = 0x0000,
        KMOD_LSHIFT = 0x0001,
        KMOD_RSHIFT = 0x0002,
        KMOD_LCTRL = 0x0040,
        KMOD_RCTRL = 0x0080,
        KMOD_LALT = 0x0100,
        KMOD_RALT = 0x0200,
        KMOD_LGUI = 0x0400,
        KMOD_RGUI = 0x0800,
        KMOD_NUM = 0x1000,
        KMOD_CAPS = 0x2000,
        KMOD_MODE = 0x4000,
        KMOD_SCROLL = 0x8000,

        KMOD_CTRL = KMOD_LCTRL | KMOD_RCTRL,
        KMOD_SHIFT = KMOD_LSHIFT | KMOD_RSHIFT,
        KMOD_ALT = KMOD_LALT | KMOD_RALT,
        KMOD_GUI = KMOD_LGUI | KMOD_RGUI,

        KMOD_RESERVED = KMOD_SCROLL /* This is for source-level compatibility with SDL 2.0.0. */
    }
}
