using AdvancedDLSupport;

namespace OpenToolkit.Windowing.GraphicsLibraryFramework.Interfaces
{
    /// <summary>
    /// Defines the public interface of the GLFW 3.2 library
    /// </summary>
    [NativeSymbols(Prefix = "glfw")]
    public interface IGLFW
    {
        bool Init();
        void Terminate();
        unsafe Window* CreateWindow(int width, int height, string title, Monitor* monitor, Window* share);
        unsafe Monitor* GetPrimaryMonitor();
        unsafe void DestroyWindow(Window* window);
        unsafe VideoMode* GetVideoMode(Monitor* monitor);
        void WindowHint(WindowHint hint, int value);
    }
}
