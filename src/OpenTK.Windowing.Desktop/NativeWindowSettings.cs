using System;
using System.Security.Cryptography.X509Certificates;
using OpenToolkit.GraphicsLibraryFramework;
using OpenToolkit.Mathematics;
using OpenToolkit.Windowing.Common;
using Monitor = OpenToolkit.Windowing.Common.Monitor;

namespace OpenToolkit.Windowing.Desktop
{
    /// <summary>
    /// Implementation of <see cref="INativeWindowProperties"/>.
    /// <see cref="NativeWindow"/> related settings.
    /// </summary>
    public class NativeWindowSettings : INativeWindowProperties
    {
        /// <summary>
        /// Gets the default settings for a <see cref="NativeWindow"/>.
        /// </summary>
        public static readonly NativeWindowSettings Default = new NativeWindowSettings();

        /// <summary>
        /// Initializes a new instance of the <see cref="NativeWindowSettings"/> class.
        /// </summary>
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

        /// <inheritdoc />
        public bool IsEventDriven { get; set; }

        /// <inheritdoc />
        public string ClipboardString { get; set; }

        /// <inheritdoc />
        public Monitor CurrentMonitor { get; set; }

        /// <inheritdoc />
        public string Title { get; set; }

        /// <inheritdoc />
        public bool Focused { get; set; }

        /// <inheritdoc />
        public bool Visible { get; set; }

        /// <inheritdoc />
        public bool Exists { get; }

        /// <inheritdoc />
        public WindowState WindowState { get; set; }

        /// <inheritdoc />
        public WindowBorder WindowBorder { get; set; }

        /// <inheritdoc />
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

        /// <inheritdoc />
        public Vector2 Location
        {
            get => _location;
            set => _location = value;
        }

        private Vector2 _size;

        /// <inheritdoc />
        public Vector2 Size
        {
            get => _size;
            set => _size = value;
        }

        /// <inheritdoc />
        public int X
        {
            get => (int)Location.X;
            set => _location.X = value;
        }

        /// <inheritdoc />
        public int Y
        {
            get => (int)Location.Y;
            set => _location.Y = value;
        }

        /// <inheritdoc />
        public int Width
        {
            get => (int)Size.X;
            set => _size.X = value;
        }

        /// <inheritdoc />
        public int Height
        {
            get => (int)Size.Y;
            set => _size.Y = value;
        }

        /// <inheritdoc />
        public Box2 ClientRectangle
        {
            get => Box2.FromDimensions(Location, Size);

            set
            {
                Location = new Vector2(value.Right, value.Top);
                Size = new Vector2(value.Width, value.Height);
            }
        }

        /// <inheritdoc />
        public Vector2 ClientSize { get; }

        /// <inheritdoc />
        public bool IsFullscreen { get; set; }
    }
}
