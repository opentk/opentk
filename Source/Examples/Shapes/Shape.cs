#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

using OpenTK.Math;

namespace Examples.Shapes
{
    public abstract class Shape
    {
        private Vector3[] vertices, normals;
        private Vector2[] texcoords;
        private int[] indices;
        unsafe int* index_ptr;
        unsafe float* vertex_ptr, normal_ptr, texcoord_ptr;

        public Vector3[] Vertices
        {
            get { return vertices; }
            protected set
            {
                unsafe
                {
                    vertices = value;
                    //fixed (float* ptr = (float*)vertices[0])
                    {
                        vertex_ptr = (float*)vertices[0];
                    }
                }
            }
        }

        public Vector3[] Normals
        {
            get { return normals; }
            protected set
            {
                unsafe
                {
                    normals = value;
                    //fixed (float* ptr = (float*)normals[0])
                    {
                        normal_ptr = (float*)normals[0];
                    }
                }
            }
        }

        public Vector2[] Texcoords
        {
            get { return texcoords; }
            protected set
            {
                unsafe
                {
                    texcoords = value;
                    //fixed (float* ptr = (float*)texcoords[0])
                    {
                        texcoord_ptr = (float*)texcoords[0];
                    }
                }
            }
        }

        public int[] Indices
        {
            get { return indices; }
            protected set
            {
                unsafe
                {
                    indices = value;
                    fixed (int* ptr = indices)
                    {
                        index_ptr = ptr;
                    }
                }
            }
        }
    }
}
