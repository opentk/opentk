using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Windowing.GraphicsLibraryFramework
{
    public enum ANGLEPlatformType
    {
        None = 0x00037001,
        OpenGL = 0x00037002,
        OpenGLES = 0x00037003,
        D3D9 = 0x00037004,
        D3D11 = 0x00037005,
        Vulkan = 0x00037007,
        Metal = 0x00037008,
    }
}
