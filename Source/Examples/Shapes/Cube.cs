#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

using OpenTK.Math;
using System.Runtime.InteropServices;

namespace Examples.Shapes
{
    public class Cube : Shape
    {
        public Cube()
        {
            Vertices = new Vector3[]
            {
                new Vector3(-1.0f, -1.0f,  1.0f),
                new Vector3( 1.0f, -1.0f,  1.0f),
                new Vector3( 1.0f,  1.0f,  1.0f),
                new Vector3(-1.0f,  1.0f,  1.0f),
                new Vector3(-1.0f, -1.0f, -1.0f),
                new Vector3( 1.0f, -1.0f, -1.0f), 
                new Vector3( 1.0f,  1.0f, -1.0f),
                new Vector3(-1.0f,  1.0f, -1.0f)
            };

            Indices = new int[]
            {
                // front face
                0, 1, 2, 2, 3, 0,
                // top face
                3, 2, 6, 6, 7, 3,
                // back face
                7, 6, 5, 5, 4, 7,
                // left face
                4, 0, 3, 3, 7, 4,
                // bottom face
                0, 1, 5, 5, 4, 0,
                // right face
                1, 5, 6, 6, 2, 1,
            };

            Normals = new Vector3[]
            {
                new Vector3(-1.0f, -1.0f,  1.0f),
                new Vector3( 1.0f, -1.0f,  1.0f),
                new Vector3( 1.0f,  1.0f,  1.0f),
                new Vector3(-1.0f,  1.0f,  1.0f),
                new Vector3(-1.0f, -1.0f, -1.0f),
                new Vector3( 1.0f, -1.0f, -1.0f),
                new Vector3( 1.0f,  1.0f, -1.0f),
                new Vector3(-1.0f,  1.0f, -1.0f),
            };

            Colors = new int[]
            {
                Utilities.ColorToRgba32(Color.DarkRed),
                Utilities.ColorToRgba32(Color.DarkRed),
                Utilities.ColorToRgba32(Color.Gold),
                Utilities.ColorToRgba32(Color.Gold),
                Utilities.ColorToRgba32(Color.DarkRed),
                Utilities.ColorToRgba32(Color.DarkRed),
                Utilities.ColorToRgba32(Color.Gold),
                Utilities.ColorToRgba32(Color.Gold),
            };
        }
    }
}
