// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System.Drawing;
using System.Runtime.InteropServices;
using OpenTK;

namespace Examples.Tutorial
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    struct VertexPositionColor
    {
        public Vector3 Position;
        public uint Color;

        public VertexPositionColor(float x, float y, float z, Color color)
        {
            Position = new Vector3(x, y, z);
            Color = ToRgba(color);
        }

        static uint ToRgba(Color color)
        {
            return (uint)color.A << 24 | (uint)color.B << 16 | (uint)color.G << 8 | (uint)color.R;
        }
    }
}
