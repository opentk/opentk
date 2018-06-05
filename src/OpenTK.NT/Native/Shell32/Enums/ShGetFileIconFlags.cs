using System;

namespace OpenTK.NT.Native
{
    [Flags]
    public enum ShGetFileIconFlags
    {
        /// <summary>
        /// get large icon
        /// </summary>
        LargeIcon = 0x000000000,

        /// <summary>
        /// get small icon
        /// </summary>
        SmallIcon = 0x000000001,

        /// <summary>
        /// get open icon
        /// </summary>
        OpenIcon = 0x000000002,

        /// <summary>
        /// get shell size icon
        /// </summary>
        ShellIconSize = 0x000000004,

        /// <summary>
        /// pszPath is a pidl
        /// </summary>
        PIDL = 0x000000008,

        /// <summary>
        /// use passed dwFileAttribute
        /// </summary>
        UseFileAttributes = 0x000000010,

        /// <summary>
        /// apply the appropriate overlays
        /// </summary>
        AddOverlays = 0x000000020,

        /// <summary>
        /// Get the index of the overlay in the upper 8 bits of the iIcon
        /// </summary>
        OverlayIndex = 0x000000040,

        /// <summary>
        /// get icon
        /// </summary>
        Icon = 0x000000100,

        /// <summary>
        /// get display name
        /// </summary>
        DisplayName = 0x000000200,

        /// <summary>
        /// get type name
        /// </summary>
        TypeName = 0x000000400,

        /// <summary>
        /// get attributes
        /// </summary>
        Attributes = 0x000000800,

        /// <summary>
        /// get icon location
        /// </summary>
        IconLocation = 0x000001000,

        /// <summary>
        /// return exe type
        /// </summary>
        ExeType = 0x000002000,

        /// <summary>
        /// get system icon index
        /// </summary>
        SysIconIndex = 0x000004000,

        /// <summary>
        /// put a link overlay on icon
        /// </summary>
        LinkOverlay = 0x000008000,

        /// <summary>
        /// show icon in selected state
        /// </summary>
        Selected = 0x000010000,

        /// <summary>
        /// get only specified attributes
        /// </summary>
        Attr_Specified = 0x000020000,
    }
}
