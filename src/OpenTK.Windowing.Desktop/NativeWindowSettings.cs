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
            IsEventDriven = false;
            
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
        }

        public bool IsEventDriven { get; set; }

        public string ClipboardString { get; set; }

        public string Title { get; set; }

        public Monitor CurrentMonitor { get; set; }
        
        public bool Focused { get; set; }

        public bool Visible { get; set; }

        public bool Exists { get; }

        public WindowState WindowState { get; set; }

        public WindowBorder WindowBorder { get; set; }

        public Box2 Bounds
        {
            get => Box2.FromDimensions(Location, Size);
            set
            {
                _location = new Vector2(value.Left, value.Left);
                _size = new Vector2(value.Width, value.Height);
            }
        }

        private Vector2 _location;

        public Vector2 Location
        {
            get => _location;
            set => _location = value;
        }

        private Vector2 _size;

        public Vector2 Size
        {
            get => _size;
            set => _size = value;
        }

        public int X
        {
            get => (int)Location.X;
            set => _location.X = value;
        }

        public int Y
        {
            get => (int)Location.Y;
            set => _location.Y = value;
        }

        public int Width
        {
            get => (int)Size.X;
            set => _size.X = value;
        }

        public int Height
        {
            get => (int)Size.Y;
            set => _size.Y = value;
        }

        public Box2 ClientRectangle
        {
            get => Box2.FromDimensions(Location, Size);
            
            set
            {
                Location = new Vector2(value.Right, value.Top);
                Size = new Vector2(value.Width, value.Height);
            }
        }
        
        public Vector2 ClientSize { get; }

        public bool IsFullscreen { get; set; }
    }
}