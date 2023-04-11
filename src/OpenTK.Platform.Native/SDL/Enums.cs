using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform.Native.SDL
{
    [Flags]
    internal enum SDL_INIT : uint
    {
        SDL_INIT_TIMER = 0x00000001u,
        SDL_INIT_AUDIO = 0x00000010u,
        /**< SDL_INIT_VIDEO implies SDL_INIT_EVENTS */
        SDL_INIT_VIDEO = 0x00000020u,
        /**< SDL_INIT_JOYSTICK implies SDL_INIT_EVENTS */
        SDL_INIT_JOYSTICK = 0x00000200u,
        SDL_INIT_HAPTIC = 0x00001000u,
        /**< SDL_INIT_GAMECONTROLLER implies SDL_INIT_JOYSTICK */
        SDL_INIT_GAMECONTROLLER = 0x00002000u,
        SDL_INIT_EVENTS = 0x00004000u,
        SDL_INIT_SENSOR = 0x00008000u,
        /**< compatibility; this flag is ignored. */
        SDL_INIT_NOPARACHUTE = 0x00100000u,
    }

    [Flags]
    internal enum SDL_WindowFlags : uint
    {
        SDL_WINDOW_FULLSCREEN = 0x00000001,         /**< fullscreen window */
        SDL_WINDOW_OPENGL = 0x00000002,             /**< window usable with OpenGL context */
        SDL_WINDOW_SHOWN = 0x00000004,              /**< window is visible */
        SDL_WINDOW_HIDDEN = 0x00000008,             /**< window is not visible */
        SDL_WINDOW_BORDERLESS = 0x00000010,         /**< no window decoration */
        SDL_WINDOW_RESIZABLE = 0x00000020,          /**< window can be resized */
        SDL_WINDOW_MINIMIZED = 0x00000040,          /**< window is minimized */
        SDL_WINDOW_MAXIMIZED = 0x00000080,          /**< window is maximized */
        SDL_WINDOW_MOUSE_GRABBED = 0x00000100,      /**< window has grabbed mouse input */
        SDL_WINDOW_INPUT_FOCUS = 0x00000200,        /**< window has input focus */
        SDL_WINDOW_MOUSE_FOCUS = 0x00000400,        /**< window has mouse focus */
        SDL_WINDOW_FULLSCREEN_DESKTOP = (SDL_WINDOW_FULLSCREEN | 0x00001000),
        SDL_WINDOW_FOREIGN = 0x00000800,            /**< window not created by SDL */
        SDL_WINDOW_ALLOW_HIGHDPI = 0x00002000,      /**< window should be created in high-DPI mode if supported.
                                                     On macOS NSHighResolutionCapable must be set true in the
                                                     application's Info.plist for this to have any effect. */
        SDL_WINDOW_MOUSE_CAPTURE = 0x00004000,   /**< window has mouse captured (unrelated to MOUSE_GRABBED) */
        SDL_WINDOW_ALWAYS_ON_TOP = 0x00008000,   /**< window should always be above others */
        SDL_WINDOW_SKIP_TASKBAR = 0x00010000,   /**< window should not be added to the taskbar */
        SDL_WINDOW_UTILITY = 0x00020000,   /**< window should be treated as a utility window */
        SDL_WINDOW_TOOLTIP = 0x00040000,   /**< window should be treated as a tooltip */
        SDL_WINDOW_POPUP_MENU = 0x00080000,   /**< window should be treated as a popup menu */
        SDL_WINDOW_KEYBOARD_GRABBED = 0x00100000,   /**< window has grabbed keyboard input */
        SDL_WINDOW_VULKAN = 0x10000000,   /**< window usable for Vulkan surface */
        SDL_WINDOW_METAL = 0x20000000,   /**< window usable for Metal view */

        SDL_WINDOW_INPUT_GRABBED = SDL_WINDOW_MOUSE_GRABBED /**< equivalent to SDL_WINDOW_MOUSE_GRABBED for compatibility */
    }

    internal enum SDL_BUTTON : byte
    {
        SDL_BUTTON_LEFT     = 1,
        SDL_BUTTON_MIDDLE   = 2,
        SDL_BUTTON_RIGHT    = 3,
        SDL_BUTTON_X1       = 4,
        SDL_BUTTON_X2       = 5,
    }

    internal enum SDL_FlashOperation : int
    {
        SDL_FLASH_CANCEL,                   /**< Cancel any window flash state */
        SDL_FLASH_BRIEFLY,                  /**< Flash the window briefly to get attention */
        SDL_FLASH_UNTIL_FOCUSED             /**< Flash the window until it gets focus */
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
        SDL_GL_CONTEXT_PROFILE_ES = 0x0004 /**< GLX_CONTEXT_ES2_PROFILE_BIT_EXT */
    }

    [Flags]
    enum SDL_GLcontextFlag
    {
        SDL_GL_CONTEXT_DEBUG_FLAG = 0x0001,
        SDL_GL_CONTEXT_FORWARD_COMPATIBLE_FLAG = 0x0002,
        SDL_GL_CONTEXT_ROBUST_ACCESS_FLAG = 0x0004,
        SDL_GL_CONTEXT_RESET_ISOLATION_FLAG = 0x0008
    }
    
}
