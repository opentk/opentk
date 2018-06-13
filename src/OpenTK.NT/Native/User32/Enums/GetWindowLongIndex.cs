using LONG = System.Int32;

namespace OpenTK.NT.Native
{
    public enum GetWindowLongIndex : LONG
    {
        /// <summary>
        /// Retrieves the address of the window procedure, or a handle
        /// representing the address of the window procedure.
        /// You must use the CallWindowProc function to call the window procedure.
        /// </summary>
        WindowProcedure = -4,

        /// <summary>
        /// Retrieves a handle to the application instance.
        /// </summary>
        HInstance = -6,

        /// <summary>
        /// Retrieves a handle to the parent window, if any.<br/>
        /// Not supported in <see cref="User32.Window.SetWindowLong"/>.
        /// </summary>
        HWndParent = -8,

        /// <summary>
        /// Retrieves the identifier of the window.
        /// </summary>
        ID = -12,

        /// <summary>
        /// Retrieves the window styles.
        /// </summary>
        Style = -16,

        /// <summary>
        /// Retrieves the extended window styles.
        /// </summary>
        ExStyle = -20,

        /// <summary>
        /// Retrieves the user data associated with the window.
        /// This data is intended for use by the application that created the window.
        /// Its value is initially zero.
        /// </summary>
        UserData = -21
    }
}
