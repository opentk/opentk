using System;
using System.Runtime.InteropServices;

namespace OpenToolkit.GraphicsLibraryFramework
{
    internal static unsafe class GLFWNative
    {
        private const string LibraryName = "glfw3.dll";

        public const int GLFW_TRUE = 1;
        public const int GLFW_FALSE = 0;

#if NETCOREAPP
        static GLFWNative()
        {
            // Register DllImport resolver so that the correct dynamic library is loaded on all platforms.
            // On net472, we rely on Mono's DllMap for this. See the .dll.config file.
            NativeLibrary.SetDllImportResolver(typeof(GLFWNative).Assembly, (name, assembly, path) =>
            {
                if (name != "glfw3.dll")
                {
                    return IntPtr.Zero;
                }

                if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    return NativeLibrary.Load("libglfw.so.3", assembly, path);
                }

                if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    return NativeLibrary.Load("libglfw.3.dylib", assembly, path);
                }

                return IntPtr.Zero;
            });
        }
#endif

        [DllImport(LibraryName)]
        public static extern int glfwInit();

        [DllImport(LibraryName)]
        public static extern void glfwTerminate();

        [DllImport(LibraryName)]
        public static extern void glfwInitHint(int hint, int value);

        [DllImport(LibraryName)]
        public static extern void glfwGetVersion(int* major, int* minor, int* revision);

        [DllImport(LibraryName)]
        public static extern byte* glfwGetVersionString();

        [DllImport(LibraryName)]
        public static extern ErrorCode glfwGetError(byte** description);

        [DllImport(LibraryName)]
        public static extern Monitor** glfwGetMonitors(int* count);

        [DllImport(LibraryName)]
        public static extern void glfwGetMonitorPos(Monitor* monitor, int* x, int* y);

        [DllImport(LibraryName)]
        public static extern void glfwGetMonitorPhysicalSize(Monitor* monitor, int* width, int* height);

        [DllImport(LibraryName)]
        public static extern void glfwGetMonitorContentScale(Monitor* monitor, float* xscale, float* yscale);

        [DllImport(LibraryName)]
        public static extern byte* glfwGetMonitorName(Monitor* monitor);

        [DllImport(LibraryName)]
        public static extern void glfwSetMonitorUserPointer(Monitor* monitor, void* pointer);

        [DllImport(LibraryName)]
        public static extern void* glfwGetMonitorUserPointer(Monitor* monitor);

        [DllImport(LibraryName)]
        public static extern VideoMode* glfwGetVideoModes(Monitor* monitor, int* count);

        [DllImport(LibraryName)]
        public static extern void glfwSetGamma(Monitor* monitor, float gamma);

        [DllImport(LibraryName)]
        public static extern GammaRamp* glfwGetGammaRamp(Monitor* monitor);

        [DllImport(LibraryName)]
        public static extern void glfwSetGammaRamp(Monitor* monitor, GammaRamp* ramp);

        [DllImport(LibraryName)]
        public static extern void glfwDefaultWindowHints();

        [DllImport(LibraryName)]
        public static extern void glfwWindowHintString(int hint, byte* value);

        [DllImport(LibraryName)]
        public static extern void glfwSetWindowSizeLimits(Window* window, int minwidth, int minheight, int maxwidth, int maxheight);

        [DllImport(LibraryName)]
        public static extern void glfwSetWindowAspectRatio(Window* window, int numer, int denom);

        [DllImport(LibraryName)]
        public static extern void glfwGetWindowFrameSize(Window* window, int* left, int* top, int* right, int* bottom);

        [DllImport(LibraryName)]
        public static extern void glfwGetWindowContentScale(Window* window, float* xscale, float* yscale);

        [DllImport(LibraryName)]
        public static extern float glfwGetWindowOpacity(Window* window);

        [DllImport(LibraryName)]
        public static extern void glfwSetWindowOpacity(Window* window, float opacity);

        [DllImport(LibraryName)]
        public static extern void glfwRequestWindowAttention(Window* window);

        [DllImport(LibraryName)]
        public static extern void glfwSetWindowAttrib(Window* window, WindowAttributeSetter attrib, int value);

        [DllImport(LibraryName)]
        public static extern int glfwRawMouseMotionSupported();

        [DllImport(LibraryName)]
        public static extern byte* glfwGetKeyName(Keys key, int scancode);

        [DllImport(LibraryName)]
        public static extern int glfwGetKeyScancode(Keys key);

        [DllImport(LibraryName)]
        public static extern InputAction glfwGetKey(Window* window, Keys key);

        [DllImport(LibraryName)]
        public static extern InputAction glfwGetMouseButton(Window* window, MouseButton button);

        [DllImport(LibraryName)]
        public static extern void glfwGetCursorPos(Window* window, double* xpos, double* ypos);

        [DllImport(LibraryName)]
        public static extern void glfwSetCursorPos(Window* window, double xpos, double ypos);

        [DllImport(LibraryName)]
        public static extern Cursor* glfwCreateCursor(Image* image, int xhot, int yhot);

        [DllImport(LibraryName)]
        public static extern Cursor* glfwCreateStandardCursor(CursorShape shape);

        [DllImport(LibraryName)]
        public static extern void glfwDestroyCursor(Cursor* cursor);

        [DllImport(LibraryName)]
        public static extern void glfwSetCursor(Window* window, Cursor* cursor);

        [DllImport(LibraryName)]
        public static extern int glfwJoystickPresent(int jid);

        [DllImport(LibraryName)]
        public static extern float* glfwGetJoystickAxes(int jid, int* count);

        [DllImport(LibraryName)]
        public static extern InputAction* glfwGetJoystickButtons(int jid, int* count);

        [DllImport(LibraryName)]
        public static extern JoystickHats* glfwGetJoystickHats(int jid, int* count);

        [DllImport(LibraryName)]
        public static extern byte* glfwGetJoystickName(int jid);

        [DllImport(LibraryName)]
        public static extern byte* glfwGetJoystickGUID(int jid);

        [DllImport(LibraryName)]
        public static extern void glfwSetJoystickUserPointer(int jid, void* ptr);

        [DllImport(LibraryName)]
        public static extern void* glfwGetJoystickUserPointer(int jid);

        [DllImport(LibraryName)]
        public static extern int glfwJoystickIsGamepad(int jid);

        [DllImport(LibraryName)]
        public static extern int glfwUpdateGamepadMappings(byte* newMapping);

        [DllImport(LibraryName)]
        public static extern byte* glfwGetGamepadName(int jid);

        [DllImport(LibraryName)]
        public static extern int glfwGetGamepadState(int jid, GamepadState* state);

        [DllImport(LibraryName)]
        public static extern double glfwGetTime();

        [DllImport(LibraryName)]
        public static extern void glfwSetTime(double time);

        [DllImport(LibraryName)]
        public static extern long glfwGetTimerValue();

        [DllImport(LibraryName)]
        public static extern long glfwGetTimerFrequency();

        [DllImport(LibraryName)]
        public static extern Window* glfwGetCurrentContext();

        [DllImport(LibraryName)]
        public static extern void glfwSwapBuffers(Window* window);

        [DllImport(LibraryName)]
        public static extern int glfwExtensionSupported(byte* extensionName);

        [DllImport(LibraryName)]
        public static extern IntPtr glfwGetProcAddress(byte* procame);

        [DllImport(LibraryName)]
        public static extern Window* glfwCreateWindow(int width, int height, byte* title, Monitor* monitor, Window* share);

        [DllImport(LibraryName)]
        public static extern Monitor* glfwGetPrimaryMonitor();

        [DllImport(LibraryName)]
        public static extern void glfwDestroyWindow(Window* window);

        [DllImport(LibraryName)]
        public static extern void glfwFocusWindow(Window* window);

        [DllImport(LibraryName)]
        public static extern void glfwGetFramebufferSize(Window* window, int* width, int* height);

        [DllImport(LibraryName)]
        public static extern CursorModeValue glfwGetInputMode(Window* window, CursorStateAttribute mode);

        [DllImport(LibraryName)]
        public static extern int glfwGetInputMode(Window* window, StickyAttributes mode);

        [DllImport(LibraryName)]
        public static extern void glfwRestoreWindow(Window* window);

        [DllImport(LibraryName)]
        public static extern VideoMode* glfwGetVideoMode(Monitor* monitor);

        [DllImport(LibraryName)]
        public static extern int glfwGetWindowAttrib(Window* window, WindowAttributeGetter attribute);

        [DllImport(LibraryName)]
        public static extern void glfwGetWindowSize(Window* window, int* width, int* height);

        [DllImport(LibraryName)]
        public static extern void glfwGetWindowPos(Window* window, int* x, int* y);

        [DllImport(LibraryName)]
        public static extern Monitor* glfwGetWindowMonitor(Window* window);

        [DllImport(LibraryName)]
        public static extern void glfwHideWindow(Window* window);

        [DllImport(LibraryName)]
        public static extern void glfwIconifyWindow(Window* window);

        [DllImport(LibraryName)]
        public static extern void glfwMakeContextCurrent(Window* window);

        [DllImport(LibraryName)]
        public static extern void glfwMaximizeWindow(Window* window);

        [DllImport(LibraryName)]
        public static extern void glfwPollEvents();

        [DllImport(LibraryName)]
        public static extern void glfwPostEmptyEvent();

        [DllImport(LibraryName)]
        public static extern void glfwWindowHint(WindowHintInt hint, int value);

        [DllImport(LibraryName)]
        public static extern void glfwWindowHint(WindowHintBool hint, int value);

        [DllImport(LibraryName)]
        public static extern void glfwWindowHint(WindowHintClientApi hint, ClientApi value);

        [DllImport(LibraryName)]
        public static extern void glfwWindowHint(WindowHintReleaseBehavior hint, ReleaseBehavior value);

        [DllImport(LibraryName)]
        public static extern void glfwWindowHint(WindowHintContextApi hint, ContextApi value);

        [DllImport(LibraryName)]
        public static extern void glfwWindowHint(WindowHintRobustness hint, Robustness value);

        [DllImport(LibraryName)]
        public static extern void glfwWindowHint(WindowHintOpenGlProfile hint, OpenGlProfile value);

        [DllImport(LibraryName)]
        public static extern int glfwWindowShouldClose(Window* window);

        [DllImport(LibraryName)]
        public static extern void glfwSetWindowUserPointer(Window* window, void* pointer);

        [DllImport(LibraryName)]
        public static extern void* glfwGetWindowUserPointer(Window* window);

        [DllImport(LibraryName)]
        public static extern IntPtr glfwSetCharCallback(Window* window, IntPtr callback);

        [DllImport(LibraryName)]
        public static extern IntPtr glfwSetCharModsCallback(Window* window, IntPtr callback);

        [DllImport(LibraryName)]
        public static extern IntPtr glfwSetCursorEnterCallback(Window* window, IntPtr callback);

        [DllImport(LibraryName)]
        public static extern IntPtr glfwSetCursorPosCallback(Window* window, IntPtr callback);

        [DllImport(LibraryName)]
        public static extern IntPtr glfwSetDropCallback(Window* window, IntPtr callback);

        [DllImport(LibraryName)]
        public static extern IntPtr glfwSetErrorCallback(IntPtr callback);

        [DllImport(LibraryName)]
        public static extern void glfwSetInputMode(Window* window, CursorStateAttribute mode, CursorModeValue value);

        [DllImport(LibraryName)]
        public static extern void glfwSetInputMode(Window* window, StickyAttributes mode, int value);

        [DllImport(LibraryName)]
        public static extern IntPtr glfwSetJoystickCallback(IntPtr callback);

        [DllImport(LibraryName)]
        public static extern IntPtr glfwSetKeyCallback(Window* window, IntPtr callback);

        [DllImport(LibraryName)]
        public static extern IntPtr glfwSetScrollCallback(Window* window, IntPtr callback);

        [DllImport(LibraryName)]
        public static extern IntPtr glfwSetMonitorCallback(IntPtr callback);

        [DllImport(LibraryName)]
        public static extern IntPtr glfwSetMouseButtonCallback(Window* window, IntPtr callback);

        [DllImport(LibraryName)]
        public static extern IntPtr glfwSetWindowCloseCallback(Window* window, IntPtr callback);

        [DllImport(LibraryName)]
        public static extern IntPtr glfwSetWindowFocusCallback(Window* window, IntPtr callback);

        [DllImport(LibraryName)]
        public static extern void glfwSetWindowIcon(Window* window, int count, Image* images);

        [DllImport(LibraryName)]
        public static extern IntPtr glfwSetWindowIconifyCallback(Window* window, IntPtr callback);

        [DllImport(LibraryName)]
        public static extern IntPtr glfwSetWindowMaximizeCallback(Window* window, IntPtr callback);

        [DllImport(LibraryName)]
        public static extern IntPtr glfwSetFramebufferSizeCallback(Window* window, IntPtr callback);

        [DllImport(LibraryName)]
        public static extern IntPtr glfwSetWindowContentScaleCallback(Window* window, IntPtr callback);

        [DllImport(LibraryName)]
        public static extern void glfwSetWindowTitle(Window* window, byte* title);

        [DllImport(LibraryName)]
        public static extern void glfwShowWindow(Window* window);

        [DllImport(LibraryName)]
        public static extern void glfwSetWindowSize(Window* window, int width, int height);

        [DllImport(LibraryName)]
        public static extern IntPtr glfwSetWindowSizeCallback(Window* window, IntPtr callback);

        [DllImport(LibraryName)]
        public static extern void glfwSetWindowShouldClose(Window* window, int value);

        [DllImport(LibraryName)]
        public static extern void glfwSetWindowMonitor(Window* window, Monitor* monitor, int x, int y, int width, int height, int refreshRate);

        [DllImport(LibraryName)]
        public static extern void glfwSetWindowPos(Window* window, int x, int y);

        [DllImport(LibraryName)]
        public static extern IntPtr glfwSetWindowPosCallback(Window* window, IntPtr callback);

        [DllImport(LibraryName)]
        public static extern IntPtr glfwSetWindowRefreshCallback(Window* window, IntPtr callback);

        [DllImport(LibraryName)]
        public static extern void glfwSwapInterval(int interval);

        [DllImport(LibraryName)]
        public static extern void glfwWaitEvents();

        [DllImport(LibraryName)]
        public static extern void glfwWaitEventsTimeout(double timeout);

        [DllImport(LibraryName)]
        public static extern byte* glfwGetClipboardString(Window* window);

        [DllImport(LibraryName)]
        public static extern void glfwSetClipboardString(Window* window, byte* data);

        [DllImport(LibraryName)]
        public static extern int glfwVulkanSupported();

        [DllImport(LibraryName)]
        public static extern byte** glfwGetRequiredInstanceExtensions(uint* count);

        [DllImport(LibraryName)]
        public static extern IntPtr glfwGetInstanceProcAddress(VkHandle instance, byte* procName);

        [DllImport(LibraryName)]
        public static extern int glfwGetPhysicalDevicePresentationSupport(VkHandle instance, VkHandle device, int queueFamily);

        [DllImport(LibraryName)]
        public static extern int glfwCreateWindowSurface(VkHandle instance, Window* window, void* allocator, VkHandle surface);
    }
}
