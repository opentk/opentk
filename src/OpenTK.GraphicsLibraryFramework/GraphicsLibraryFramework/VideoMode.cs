//
// VideoMode.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.Windowing.GraphicsLibraryFramework
{
    /// <summary>
    /// Replicated handle to a GLFW VideoMode.
    /// </summary>
    public struct VideoMode
    {
        public int width;
        public int height;
        public int redBits;
        public int greenBits;
        public int blueBits;
        public int refreshRate;
    }
}
