// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.Shapes
{
    public sealed class VboShape: DrawableShape
    {
        public VboShape(ref OpenTK.Graphics.OpenGL.PrimitiveType primitives, ref VertexT2dN3dV3d[] vertices, ref uint[] indices, bool useDL)
            : base( useDL )
        {
            PrimitiveMode = primitives;

            VertexArray = new VertexT2dN3dV3d[vertices.Length];
            for ( uint i = 0; i < vertices.Length; i++ )
            {
                VertexArray[i] = vertices[i];
            }

            IndexArray = new uint[indices.Length];
            for ( uint i = 0; i < indices.Length; i++ )
            {
                IndexArray[i] = indices[i];
            }
        }
    }
}
