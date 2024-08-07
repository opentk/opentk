namespace OpenTK.Platform
{
    /// <summary>
    /// Event handler delegate for processing window events.
    /// </summary>
    /// <param name="handle">The window handle receiving the event.</param>
    /// <param name="type">The type of the event.</param>
    /// <param name="args">Arguments associated with the event.</param>
    /// <example>
    /// <code>
    /// void MyWindowEventHandler(WindowHandle handle, WindowEventType type, WindowEventArgs args)
    /// {
    ///     switch(type)
    ///     {
    ///         case WindowEventType.Move:
    ///             // Implementation of which is left as an exercise to the reader:
    ///             MyMoveEventHandler(handle, (WindowMoveEventArgs)args);
    ///             break;
    ///         default:
    ///             OpenTK.Platform.Window.DefaultEventHandler(handle, type, args);
    ///             break;
    ///     }
    /// }
    ///
    /// // Usage:
    /// OpenTK.Platform.Window.ProcessEvents(handle, MyWindowEventHandler);
    /// </code>
    /// </example>
    public delegate void WindowEventHandler(WindowHandle handle, PlatformEventType type, WindowEventArgs args);
}
