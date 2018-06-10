using LONG = System.Int32;

namespace OpenTK.NT.Native
{
    internal enum GetWindowLongIndex : LONG
    {
        /// <summary>
        /// Retrieves the address of the window procedure, or a handle
        /// representing the address of the window procedure.
        /// You must use the CallWindowProc function to call the window procedure.
        /// </summary>
        WNDPROC = -4,

        /// <summary>
        /// Retrieves a handle to the application instance.
        /// </summary>
        HINSTANCE = -6,

        /// <summary>
        /// Retrieves a handle to the parent window, if any.<br/>
        /// Not supported in <see cref="User32.Window.SetWindowLong"/>.
        /// </summary>
        HWNDPARENT = -8,

        /// <summary>
        /// Retrieves the identifier of the window.
        /// </summary>
        ID = -12,

        /// <summary>
        /// Retrieves the window styles.
        /// </summary>
        STYLE = -16,

        /// <summary>
        /// Retrieves the extended window styles.
        /// </summary>
        EXSTYLE = -20,

        /// <summary>
        /// Retrieves the user data associated with the window.
        /// This data is intended for use by the application that created the window.
        /// Its value is initially zero.
        /// </summary>
        USERDATA = -21
    }
}
