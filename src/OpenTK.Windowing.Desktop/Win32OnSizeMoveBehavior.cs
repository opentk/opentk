using OpenTK.Windowing.Common;

namespace OpenTK.Windowing.Desktop
{
    /// <summary>
    /// Selects the way a <see cref="GameWindow"/> will deal with the modal event loop when moving or resizing windows.
    /// </summary>
    public enum Win32OnSizeMoveBehavior
    {
        /// <summary>
        /// Do nothing to deal with the modal event loop, meaning <see cref="GameWindow.OnRenderFrame(Common.FrameEventArgs)"/> will not be called while the window is being moved or resized.
        /// The frame time counter will also not be paused, possibly causing a big jump in <see cref="FrameEventArgs.Time"/> for the first frame after the windows was moved or resized.
        /// </summary>
        DoNothing = 0,

        /// <summary>
        /// Pause the internal frame time counter when windows enters a modal event loop.
        /// Thius means <see cref="GameWindow.OnRenderFrame(FrameEventArgs)"/> will not be called while the window is being moved or resized,
        /// but the <see cref="FrameEventArgs.Time"/> for the first frame after moving or resizing will not count the time that passed while moving or resizing.
        /// </summary>
        SuspendTimer = 1,

        /// <summary>
        /// Send <see cref="GameWindow.OnRenderFrame(FrameEventArgs)"/> events in reguar intervals while the window is being moved or resized.
        /// </summary>
        /// <remarks>
        /// When windows enters a modal reisze and move event loop OpenTK will start a win32 timer that will send regular events that are used to send <see cref="GameWindow.OnRenderFrame(FrameEventArgs)"/>.
        /// This does not mean that <see cref="NativeWindow.ProcessEvents(double)"/> returns for each call to <see cref="GameWindow.OnRenderFrame(FrameEventArgs)"/>.
        /// <para>
        /// Because windows timers have a minimum timeout of 10ms that is the maximum speed that updates will be received.
        /// </para>
        /// <para>
        /// This also has the consequence that if <see cref="GameWindow.OnRenderFrame(FrameEventArgs)"/> takes a lot of time the window movement will stutter as the repaint is happening within the modal resize move loop.
        /// This might degrade the user experience in these scenarios.
        /// </para>
        /// </remarks>
        SendFrameEvents = 2,
    }
}
