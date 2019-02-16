using System.Drawing;
using Humanizer;
using Humanizer.Localisation.Formatters;
using OpenToolkit.Windowing.Common;

namespace OpenToolkit.Windowing.Desktop
{
    public class NativeWindowSettings : INativeWindowProperties
    {
        /// <summary>
        /// Gets the default settings for a NativeWinow.
        /// </summary>
        public static readonly NativeWindowSettings Default = new NativeWindowSettings();
        
        public string ClipboardString { get; set; }
        public string Title { get; set; } = "OpenTK Window";
        public bool Focused { get; set; } = true;
        public bool Visible { get; set; } = true;
        public bool Exists { get; }
        public WindowState WindowState { get; set; } = WindowState.Normal;
        public WindowBorder WindowBorder { get; set; } = WindowBorder.Resizable;
        public Rectangle Bounds { get; set; }
        public Point Location { get; set; }
        public Size Size { get; set; }
        public int X { get; set; } = -1;
        public int Y { get; set; } = -1; //TODO: Find a way to set these equal to GLFW_DONT_CARE. For now, -1 will do.
        public int Width { get; set; } = 640;
        public int Height { get; set; } = 480;
        public Rectangle ClientRectangle { get; set; }
        public Size ClientSize { get; }

        public bool IsFullscreen { get; set; } = false;
    }
}