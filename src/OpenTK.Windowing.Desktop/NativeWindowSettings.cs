using System;
using System.Security.Cryptography.X509Certificates;
using OpenToolkit.GraphicsLibraryFramework;
using OpenToolkit.Mathematics;
using OpenToolkit.Windowing.Common;
using Monitor = OpenToolkit.Windowing.Common.Monitor;

namespace OpenToolkit.Windowing.Desktop
{
    public class NativeWindowSettings : INativeWindowProperties
    {
        /// <summary>
        /// Gets the default settings for a NativeWinow.
        /// </summary>
        public static readonly NativeWindowSettings Default = new NativeWindowSettings();

        public NativeWindowSettings()
        {
            unsafe
            {
                CurrentMonitor = new Monitor((IntPtr)GLFWProvider.GLFW.Value.GetPrimaryMonitor());
            }

            Title = "OpenTK Window";
            Focused = true;
            Visible = true;

            WindowState = WindowState.Normal;
            WindowBorder = WindowBorder.Resizable;

            X = -1;
            Y = -1;

            Width = 640;
            Height = 480;

            IsFullscreen = false;
            IsEventDriven = false;
        }

        public bool IsEventDriven { get; set; }

        public Monitor CurrentMonitor { get; set; }
        
        public string ClipboardString { get; set; }
        public string Title { get; set; }
        public bool Focused { get; set; }
        public bool Visible { get; set; }
        public bool Exists { get; }
        public WindowState WindowState { get; set; }
        public WindowBorder WindowBorder { get; set; }
        public Box2 Bounds { get; set; }
        public Vector2 Location { get; set; }
        public Vector2 Size { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Box2 ClientRectangle { get; set; }
        public Vector2 ClientSize { get; }

        public bool IsFullscreen { get; set; }
    }
}