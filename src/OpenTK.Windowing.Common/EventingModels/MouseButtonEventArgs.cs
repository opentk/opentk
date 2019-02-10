using OpenToolkit.Windowing.Common.Input;

namespace OpenToolkit.Windowing.EventingModels
{
    /// <summary>
    /// Defines the event data for <see cref="MouseDevice.ButtonDown" /> and <see cref="MouseDevice.ButtonUp" /> events.
    /// </summary>
    /// <remarks>
    ///  <para>
    /// Do not cache instances of this type outside their event handler.
    /// If necessary, you can clone an instance using the
    ///  <see cref="MouseButtonEventArgs(MouseButtonEventArgs)" /> constructor.
    ///  </para>
    /// </remarks>
    public class MouseButtonEventArgs : MouseEventArgs
    {
        /// <summary>
        /// Constructs a new <see cref="MouseButtonEventArgs" /> instance.
        /// </summary>
        public MouseButtonEventArgs()
        {
        }

        /// <summary>
        /// Constructs a new <see cref="MouseButtonEventArgs" /> instance.
        /// </summary>
        /// <param name="x">The X position.</param>
        /// <param name="y">The Y position.</param>
        /// <param name="button">The mouse button for the event.</param>
        /// <param name="pressed">The current state of the button.</param>
        public MouseButtonEventArgs(int x, int y, MouseButton button, bool pressed)
            : base(x, y)
        {
            Button = button;
            IsPressed = pressed;
        }

        /// <summary>
        /// Constructs a new <see cref="MouseButtonEventArgs" /> instance.
        /// </summary>
        /// <param name="args">The <see cref="MouseButtonEventArgs" /> instance to clone.</param>
        public MouseButtonEventArgs(MouseButtonEventArgs args)
            : this(args.X, args.Y, args.Button, args.IsPressed)
        {
        }

        /// <summary>
        /// Gets the <see cref="MouseButton" /> that triggered this event.
        /// </summary>
        public MouseButton Button { get; internal set; }

        /// <summary>
        /// Gets a System.Boolean representing the state of the mouse button for the event.
        /// </summary>
        public bool IsPressed
        {
            get => GetButton(Button) == ButtonState.Pressed;
            internal set => SetButton(Button, value ? ButtonState.Pressed : ButtonState.Released);
        }
    }
}