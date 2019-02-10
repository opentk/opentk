namespace OpenToolkit.Windowing.EventingModels
{
    /// <summary>
    /// Defines the event data for <see cref="MouseDevice.Move" /> events.
    /// </summary>
    /// <remarks>
    ///  <para>
    /// Do not cache instances of this type outside their event handler.
    /// If necessary, you can clone an instance using the
    ///  <see cref="MouseMoveEventArgs(MouseMoveEventArgs)" /> constructor.
    ///  </para>
    /// </remarks>
    public class MouseMoveEventArgs : MouseEventArgs
    {
        /// <summary>
        /// Constructs a new <see cref="MouseMoveEventArgs" /> instance.
        /// </summary>
        public MouseMoveEventArgs()
        {
        }

        /// <summary>
        /// Constructs a new <see cref="MouseMoveEventArgs" /> instance.
        /// </summary>
        /// <param name="x">The X position.</param>
        /// <param name="y">The Y position.</param>
        /// <param name="xDelta">The change in X position produced by this event.</param>
        /// <param name="yDelta">The change in Y position produced by this event.</param>
        public MouseMoveEventArgs(int x, int y, int xDelta, int yDelta)
            : base(x, y)
        {
            XDelta = xDelta;
            YDelta = yDelta;
        }

        /// <summary>
        /// Constructs a new <see cref="MouseMoveEventArgs" /> instance.
        /// </summary>
        /// <param name="args">The <see cref="MouseMoveEventArgs" /> instance to clone.</param>
        public MouseMoveEventArgs(MouseMoveEventArgs args)
            : this(args.X, args.Y, args.XDelta, args.YDelta)
        {
        }

        /// <summary>
        /// Gets the change in X position produced by this event.
        /// </summary>
        public int XDelta { get; internal set; }

        /// <summary>
        /// Gets the change in Y position produced by this event.
        /// </summary>
        public int YDelta { get; internal set; }
    }
}