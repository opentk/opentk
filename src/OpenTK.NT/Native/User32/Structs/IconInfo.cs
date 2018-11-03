using BOOL = System.Boolean;
using DWORD = System.UInt32;
using HBITMAP = System.IntPtr;

namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Contains information about an icon or a cursor.
    /// </summary>
    public struct IconInfo
    {
        /// <summary>
        /// Specifies whether this structure defines an icon or a cursor. A
        /// value of true specifies an icon; false specifies a cursor.
        /// </summary>
        public BOOL Icon;

        /// <summary>
        /// The x-coordinate of a cursor's hot spot. If this structure defines
        /// an icon, the hot spot is always in the center of the icon, and
        /// this member is ignored.
        /// </summary>
        public DWORD XHotspot;

        /// <summary>
        /// The y-coordinate of a cursor's hot spot. If this structure defines
        /// an icon, the hot spot is always in the center of the icon, and
        /// this member is ignored.
        /// </summary>
        public DWORD YHotspot;

        /// <summary>
        /// The icon bitmask bitmap. If this structure defines a black and
        /// white icon, this bitmask is formatted so that the upper half is
        /// the icon AND bitmask and the lower half is the icon XOR bitmask.
        /// Under this condition, the height should be an even multiple of
        /// two. If this structure defines a color icon, this mask only
        /// defines the AND bitmask of the icon.
        /// </summary>
        public HBITMAP BitmapMask;

        /// <summary>
        /// A handle to the icon color bitmap. This member can be optional if
        /// this structure defines a black and white icon. The AND bitmask of
        /// <see cref="BitmapMask"/> is applied with the SRCAND flag to the destination;
        /// subsequently, the color bitmap is applied (using XOR) to the
        /// destination by using the SRCINVERT flag.
        /// </summary>
        public HBITMAP BitmapColor;
    }
}
