using DWORD = System.UInt32;

namespace OpenTK.NT.Native
{
    public enum MonitorFromEnum : DWORD
    {
        /// <summary>
        /// Returns null.
        /// </summary>
        DefaultToNull = 0,

        /// <summary>
        /// Returns a handle to the primary display monitor.
        /// </summary>
        DefaultToPrimary = 1,

        /// <summary>
        /// Returns a handle to the display monitor that is nearest to the window.
        /// </summary>
        DefaultToNearest = 2
    }
}
