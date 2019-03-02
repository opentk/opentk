//
// Image.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.IO;
using System.Runtime.InteropServices;

namespace OpenToolkit.GraphicsLibraryFramework
{
    /// <summary>
    /// Opaque handle to a GLFW image.
    /// </summary>
    public struct Image: IDisposable
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public unsafe IntPtr Pixels { get; }


        public Image(Stream imageStream)
        {
            var image = SixLabors.ImageSharp.Image.Load(imageStream); // HIGH: Need to create boundary utility class to prevent tight coupling with ImageSharp dependency
            Width = image.Width;
            Height = image.Height;
            Pixels = Marshal.AllocHGlobal((int)imageStream.Length); // HIGH: This is not the raw image data size and could be smaller/larger due to header data and compression
        }

        public void Dispose()
        {
            Marshal.FreeHGlobal(Pixels);
        }
    }
}
