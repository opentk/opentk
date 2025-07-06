using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace OpenTK.Windowing.GraphicsLibraryFramework
{
    internal static unsafe class GLFWNative
    {
        private const string LibraryName = "glfw3.dll";
        private const CallingConvention Cdecl = CallingConvention.Cdecl;

        public const int GLFW_TRUE = 1;
        public const int GLFW_FALSE = 0;

        static GLFWNative()
        {
            // Register DllImport resolver so that the correct dynamic library is loaded on all platforms.
            // On net472, we rely on Mono's DllMap for this. See the .dll.config file.
            NativeLibrary.SetDllImportResolver(Assembly.GetExecutingAssembly(), (name, assembly, path) =>
            {
                if (name != LibraryName)
                {
                    return IntPtr.Zero;
                }

                return LoadLibrary("glfw", new Version(3, 3), assembly, path);
            });
        }

        private static IntPtr LoadLibrary(string libraryName, Version version, Assembly assembly, DllImportSearchPath? searchPath)
        {
            IEnumerable<string> GetNextVersion()
            {
                for (var i = 2; i >= 0; i--)
                {
                    yield return version.ToString(i);
                }
            }

            Func<string, string, string> libNameFormatter;
            if (OperatingSystem.IsLinux() || OperatingSystem.IsFreeBSD())
            {
                libNameFormatter = (libName, ver) =>
                        libName + ".so" + (string.IsNullOrEmpty(ver) ? string.Empty : "." + ver);
            }
            else if (OperatingSystem.IsMacOS())
            {
                libNameFormatter = (libName, ver) =>
                    libName + (string.IsNullOrEmpty(ver) ? string.Empty : "." + ver) + ".dylib";
            }
            else if (OperatingSystem.IsWindows())
            {
                libNameFormatter = (libName, ver) =>
                    libName + (string.IsNullOrEmpty(ver) ? string.Empty : ver) + ".dll";
            }
            else
            {
                return IntPtr.Zero;
            }

            foreach (var ver in GetNextVersion())
            {
                if (NativeLibrary.TryLoad(libNameFormatter(libraryName, ver), assembly, searchPath, out var handle))
                {
                    return handle;
                }
            }
            return NativeLibrary.Load(libraryName, assembly, searchPath);
        }

#pragma warning disable IDE1006 // Naming Styles

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern int glfwInit();

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwTerminate();

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwInitHint(int hint, int value);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwInitAllocator(in GLFWallocator allocator);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwInitVulkanLoader(IntPtr loader);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwGetVersion(int* major, int* minor, int* revision);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern byte* glfwGetVersionString();

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern ErrorCode glfwGetError(byte** description);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern IntPtr glfwSetErrorCallback(GLFWCallbacks.ErrorCallback callback);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern Platform glfwGetPlatform();

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern int glfwPlatformSupported(Platform platform);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern Monitor** glfwGetMonitors(int* count);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern Monitor* glfwGetPrimaryMonitor();

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwGetMonitorPos(Monitor* monitor, int* x, int* y);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwGetMonitorWorkarea(Monitor* monitor, int* xpos, int* ypos, int* width, int* height);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwGetMonitorPhysicalSize(Monitor* monitor, int* width, int* height);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwGetMonitorContentScale(Monitor* monitor, float* xscale, float* yscale);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern byte* glfwGetMonitorName(Monitor* monitor);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwSetMonitorUserPointer(Monitor* monitor, void* pointer);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void* glfwGetMonitorUserPointer(Monitor* monitor);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern IntPtr glfwSetMonitorCallback(GLFWCallbacks.MonitorCallback callback);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern VideoMode* glfwGetVideoModes(Monitor* monitor, int* count);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern VideoMode* glfwGetVideoMode(Monitor* monitor);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwSetGamma(Monitor* monitor, float gamma);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern GammaRamp* glfwGetGammaRamp(Monitor* monitor);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwSetGammaRamp(Monitor* monitor, GammaRamp* ramp);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwDefaultWindowHints();

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwWindowHint(WindowHintInt hint, int value);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwWindowHint(WindowHintBool hint, int value);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwWindowHint(WindowHintClientApi hint, ClientApi value);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwWindowHint(WindowHintReleaseBehavior hint, ReleaseBehavior value);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwWindowHint(WindowHintContextApi hint, ContextApi value);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwWindowHint(WindowHintRobustness hint, Robustness value);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwWindowHint(WindowHintOpenGlProfile hint, OpenGlProfile value);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwWindowHintString(int hint, byte* value);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern Window* glfwCreateWindow(int width, int height, byte* title, Monitor* monitor, Window* share);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwDestroyWindow(Window* window);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern int glfwWindowShouldClose(Window* window);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwSetWindowShouldClose(Window* window, int value);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern byte* glfwGetWindowTitle(Window* window);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwSetWindowTitle(Window* window, byte* title);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwSetWindowIcon(Window* window, int count, Image* images);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwGetWindowPos(Window* window, int* x, int* y);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwSetWindowPos(Window* window, int x, int y);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwGetWindowSize(Window* window, int* width, int* height);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwSetWindowSizeLimits(Window* window, int minwidth, int minheight, int maxwidth, int maxheight);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwSetWindowAspectRatio(Window* window, int numer, int denom);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwSetWindowSize(Window* window, int width, int height);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwGetFramebufferSize(Window* window, int* width, int* height);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwGetWindowFrameSize(Window* window, int* left, int* top, int* right, int* bottom);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwGetWindowContentScale(Window* window, float* xscale, float* yscale);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern float glfwGetWindowOpacity(Window* window);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwSetWindowOpacity(Window* window, float opacity);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwIconifyWindow(Window* window);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwRestoreWindow(Window* window);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwMaximizeWindow(Window* window);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwShowWindow(Window* window);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwHideWindow(Window* window);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwFocusWindow(Window* window);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwRequestWindowAttention(Window* window);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern Monitor* glfwGetWindowMonitor(Window* window);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwSetWindowMonitor(Window* window, Monitor* monitor, int x, int y, int width, int height, int refreshRate);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern int glfwGetWindowAttrib(Window* window, WindowAttributeGetBool attribute);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern int glfwGetWindowAttrib(Window* window, WindowAttributeGetInt attribute);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern ClientApi glfwGetWindowAttrib(Window* window, WindowAttributeGetClientApi attribute);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern ContextApi glfwGetWindowAttrib(Window* window, WindowAttributeGetContextApi attribute);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern OpenGlProfile glfwGetWindowAttrib(Window* window, WindowAttributeGetOpenGlProfile attribute);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern ReleaseBehavior glfwGetWindowAttrib(Window* window, WindowAttributeGetReleaseBehavior attribute);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern Robustness glfwGetWindowAttrib(Window* window, WindowAttributeGetRobustness attribute);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwSetWindowAttrib(Window* window, WindowAttribute attrib, int value);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwSetWindowUserPointer(Window* window, void* pointer);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void* glfwGetWindowUserPointer(Window* window);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern IntPtr glfwSetWindowPosCallback(Window* window, GLFWCallbacks.WindowPosCallback callback);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern IntPtr glfwSetWindowSizeCallback(Window* window, GLFWCallbacks.WindowSizeCallback callback);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern IntPtr glfwSetWindowCloseCallback(Window* window, GLFWCallbacks.WindowCloseCallback callback);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern IntPtr glfwSetWindowRefreshCallback(Window* window, GLFWCallbacks.WindowRefreshCallback callback);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern IntPtr glfwSetWindowFocusCallback(Window* window, GLFWCallbacks.WindowFocusCallback callback);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern IntPtr glfwSetWindowIconifyCallback(Window* window, GLFWCallbacks.WindowIconifyCallback callback);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern IntPtr glfwSetWindowMaximizeCallback(Window* window, GLFWCallbacks.WindowMaximizeCallback callback);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern IntPtr glfwSetFramebufferSizeCallback(Window* window, GLFWCallbacks.FramebufferSizeCallback callback);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern IntPtr glfwSetWindowContentScaleCallback(Window* window, GLFWCallbacks.WindowContentScaleCallback callback);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwPollEvents();

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwWaitEvents();

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwWaitEventsTimeout(double timeout);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwPostEmptyEvent();

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern CursorModeValue glfwGetInputMode(Window* window, CursorStateAttribute mode);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern int glfwGetInputMode(Window* window, StickyAttributes mode);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern int glfwGetInputMode(Window* window, LockKeyModAttribute mode);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern int glfwGetInputMode(Window* window, RawMouseMotionAttribute mode);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwSetInputMode(Window* window, CursorStateAttribute mode, CursorModeValue value);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwSetInputMode(Window* window, StickyAttributes mode, int value);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwSetInputMode(Window* window, LockKeyModAttribute mode, int value);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwSetInputMode(Window* window, RawMouseMotionAttribute mode, int value);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern int glfwRawMouseMotionSupported();

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern byte* glfwGetKeyName(Keys key, int scancode);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern int glfwGetKeyScancode(Keys key);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern InputAction glfwGetKey(Window* window, Keys key);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern InputAction glfwGetMouseButton(Window* window, MouseButton button);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwGetCursorPos(Window* window, double* xpos, double* ypos);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwSetCursorPos(Window* window, double xpos, double ypos);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern Cursor* glfwCreateCursor(Image* image, int xhot, int yhot);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern Cursor* glfwCreateStandardCursor(CursorShape shape);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwDestroyCursor(Cursor* cursor);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwSetCursor(Window* window, Cursor* cursor);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern IntPtr glfwSetKeyCallback(Window* window, GLFWCallbacks.KeyCallback callback);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern IntPtr glfwSetCharCallback(Window* window, GLFWCallbacks.CharCallback callback);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern IntPtr glfwSetCharModsCallback(Window* window, GLFWCallbacks.CharModsCallback callback);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern IntPtr glfwSetMouseButtonCallback(Window* window, GLFWCallbacks.MouseButtonCallback callback);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern IntPtr glfwSetCursorPosCallback(Window* window, GLFWCallbacks.CursorPosCallback callback);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern IntPtr glfwSetCursorEnterCallback(Window* window, GLFWCallbacks.CursorEnterCallback callback);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern IntPtr glfwSetScrollCallback(Window* window, GLFWCallbacks.ScrollCallback callback);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern IntPtr glfwSetDropCallback(Window* window, GLFWCallbacks.DropCallback callback);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern int glfwJoystickPresent(int jid);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern float* glfwGetJoystickAxes(int jid, int* count);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern JoystickInputAction* glfwGetJoystickButtons(int jid, int* count);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern JoystickHats* glfwGetJoystickHats(int jid, int* count);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern byte* glfwGetJoystickName(int jid);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern byte* glfwGetJoystickGUID(int jid);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwSetJoystickUserPointer(int jid, void* ptr);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void* glfwGetJoystickUserPointer(int jid);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern int glfwJoystickIsGamepad(int jid);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern IntPtr glfwSetJoystickCallback(GLFWCallbacks.JoystickCallback callback);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern int glfwUpdateGamepadMappings(byte* newMapping);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern byte* glfwGetGamepadName(int jid);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern int glfwGetGamepadState(int jid, GamepadState* state);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwSetClipboardString(Window* window, byte* data);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern byte* glfwGetClipboardString(Window* window);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern double glfwGetTime();

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwSetTime(double time);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern long glfwGetTimerValue();

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern long glfwGetTimerFrequency();

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwMakeContextCurrent(Window* window);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern Window* glfwGetCurrentContext();

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwSwapBuffers(Window* window);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwSwapInterval(int interval);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern int glfwExtensionSupported(byte* extensionName);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern IntPtr glfwGetProcAddress(byte* procName);

        [DllImport(LibraryName, CharSet = CharSet.Ansi)]
        public static extern IntPtr glfwGetProcAddress(string procName);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern int glfwVulkanSupported();

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern byte** glfwGetRequiredInstanceExtensions(uint* count);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern IntPtr glfwGetInstanceProcAddress(VkHandle instance, byte* procName);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern int glfwGetPhysicalDevicePresentationSupport(VkHandle instance, VkHandle device, int queueFamily);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern int glfwCreateWindowSurface(VkHandle instance, Window* window, void* allocator, out VkHandle surface);

#pragma warning disable SA1124 // Do not use regions
        #region GLFW Native functions

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern byte* glfwGetWin32Adapter(Monitor* monitor);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern byte* glfwGetWin32Monitor(Monitor* monitor);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern IntPtr glfwGetWin32Window(Window* window);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern IntPtr glfwGetWGLContext(Window* window);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern uint glfwGetCocoaMonitor(Monitor* monitor);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern IntPtr glfwGetCocoaWindow(Window* window);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern IntPtr glfwGetCocoaView(Window* window);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern IntPtr glfwGetNSGLContext(Window* window);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern IntPtr glfwGetX11Display();

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern UIntPtr glfwGetX11Adapter(Monitor* monitor);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern UIntPtr glfwGetX11Monitor(Monitor* monitor);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern UIntPtr glfwGetX11Window(Window* window);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern void glfwSetX11SelectionString(byte* @string);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern byte* glfwGetX11SelectionString();

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern uint glfwGetGLXContext(Window* window);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern uint glfwGetGLXWindow(Window* window);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern IntPtr glfwGetWaylandDisplay();

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern IntPtr glfwGetWaylandMonitor(Monitor* monitor);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern IntPtr glfwGetWaylandWindow(Window* window);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern IntPtr glfwGetEGLDisplay();

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern IntPtr glfwGetEGLContext(Window* window);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern IntPtr glfwGetEGLSurface(Window* window);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern int glfwGetOSMesaColorBuffer(Window* window, int* width, int* height, int* format, void** buffer);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern int glfwGetOSMesaDepthBuffer(Window* window, int* width, int* height, int* bytesPerValue, void** buffer);

        [DllImport(LibraryName, CallingConvention = Cdecl)]
        public static extern IntPtr glfwGetOSMesaContext(Window* window);

        #endregion
#pragma warning restore SA1124 // Do not use regions

#pragma warning restore IDE1006 // Naming Styles
    }
}
