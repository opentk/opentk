using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.Shapes
{
    public sealed class VboShape: DrawableShape
    {
        public VboShape( ref OpenTK.Graphics.OpenGL.BeginMode primitives, ref VertexT2dN3dV3d[] vertices, ref uint[] indices, bool useDL )
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
