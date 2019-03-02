//
// WindowAttribute.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.GraphicsLibraryFramework
{
    public enum WindowAttribute
    {
        Focused = 0x00020001,
        Iconified = 0x00020002,
        Resizable = 0x00020003,
        Visible = 0x00020004,
        Decorated = 0x00020005,
        AutoIconify = 0x00020006,
        Floating = 0x00020007,
        Maximized = 0x00020008,
        TransparentFramebuffer = 0x0002000A,
        Hovered = 0x0002000B,
        FocusOnShow = 0x0002000C
    }
}