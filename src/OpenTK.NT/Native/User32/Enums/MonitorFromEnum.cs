using DWORD = System.UInt32;

namespace OpenTK.NT.Native
{
    public enum MonitorFromEnum : DWORD
    {
        /// <summary>
        /// Returns <see cref="null"/>.
        /// </summary>
        DEFAULTTONULL = 0,

        /// <summary>
        /// Returns a handle to the primary display monitor.
        /// </summary>
        DEFAULTTOPRIMARY = 1,

        /// <summary>
        /// Returns a handle to the display monitor that is nearest to the window.
        /// </summary>
        DEFAULTTONEAREST = 2
    }
}
