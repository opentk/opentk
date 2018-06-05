using System;

namespace OpenTK.NT.Native
{
    [Flags]
    internal enum ExtendedWindowStyle : uint
    {
        DialogModalFrame = 0x00000001,
        NoParentNotify = 0x00000004,
        Topmost = 0x00000008,
        AcceptFiles = 0x00000010,
        Transparent = 0x00000020,

        // #if(WINVER >= 0x0400)
        MdiChild = 0x00000040,
        ToolWindow = 0x00000080,
        WindowEdge = 0x00000100,
        ClientEdge = 0x00000200,
        ContextHelp = 0x00000400,
        // #endif

        // #if(WINVER >= 0x0400)
        Right = 0x00001000,
        Left = 0x00000000,
        RightToLeftReading = 0x00002000,
        LeftToRightReading = 0x00000000,
        LeftScrollbar = 0x00004000,
        RightScrollbar = 0x00000000,

        ControlParent = 0x00010000,
        StaticEdge = 0x00020000,
        ApplicationWindow = 0x00040000,

        OverlappedWindow = WindowEdge | ClientEdge,
        PaletteWindow = WindowEdge | ToolWindow | Topmost,
        // #endif

        // #if(_WIN32_WINNT >= 0x0500)
        Layered = 0x00080000,
        // #endif

        // #if(WINVER >= 0x0500)
        NoInheritLayout = 0x00100000, // Disable inheritence of mirroring by children
        RightToLeftLayout = 0x00400000, // Right to left mirroring
        // #endif /* WINVER >= 0x0500 */

        // #if(_WIN32_WINNT >= 0x0501)
        Composited = 0x02000000,
        // #endif /* _WIN32_WINNT >= 0x0501 */

        // #if(_WIN32_WINNT >= 0x0500)
        NoActivate = 0x08000000
        // #endif /* _WIN32_WINNT >= 0x0500 */
    }
}
