using System.Drawing;
using OpenToolkit.Windowing.Common;

namespace OpenToolkit.Windowing.Desktop
{
    public class NativeWindowSettings : INativeWindowProperties
    {
        public string ClipboardString { get; set; }
        public string Title { get; set; }
        public bool Focused { get; set; }
        public bool Visible { get; set; }
        public bool Exists { get; }
        public WindowState WindowState { get; set; }
        public WindowBorder WindowBorder { get; set; }
        public Rectangle Bounds { get; set; }
        public Point Location { get; set; }
        public Size Size { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle ClientRectangle { get; set; }
        public Size ClientSize { get; }
        
        public bool IsFullscreen { get; set; }
    }
}