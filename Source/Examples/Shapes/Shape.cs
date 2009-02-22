#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

using OpenTK.Math;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Examples.Shapes
{
    public abstract class Shape
    {
        private Vector3[] vertices, normals;
        private Vector2[] texcoords;
        private int[] indices;
        private int[] colors;

        public Vector3[] Vertices
        {
            get { return vertices; }
            protected set
            {
                vertices = value;
            }
        }

        public Vector3[] Normals
        {
            get { return normals; }
            protected set
            {
                normals = value;
            }
        }

        public Vector2[] Texcoords
        {
            get { return texcoords; }
            protected set
            {
                texcoords = value;
            }
        }

        public int[] Indices
        {
            get { return indices; }
            protected set
            {
                indices = value;
            }
        }

        public int[] Colors
        {
            get { return colors; }
            protected set
            {
                colors = value;
            }
        }
    }
}
