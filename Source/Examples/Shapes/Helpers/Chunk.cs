using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.Shapes
{
    public class Chunk
    {
        public VertexT2dN3dV3d[] Vertices;
        public uint[] Indices;

        public uint VertexCount
        {
            get
            {
                return (uint)Vertices.Length;
            }
        }
        public uint IndexCount
        {
            get
            {
                return (uint)Indices.Length;
            }
        }

        public Chunk( uint vertexcount, uint indexcount )
        {
            Vertices = new VertexT2dN3dV3d[vertexcount];
            Indices = new uint[indexcount];
        }

        public Chunk( ref VertexT2dN3dV3d[] vbo, ref uint[] ibo )
        {
            Vertices = new VertexT2dN3dV3d[vbo.Length];
            for ( int i = 0; i < Vertices.Length; i++ )
            {
                Vertices[i] = vbo[i];
            } 
            Indices = new uint[ibo.Length];
            for ( int i = 0; i < Indices.Length; i++ )
            {
                Indices[i] = ibo[i];
            }
        }

        public static void GetArray( ref List<Chunk> c, out VertexT2dN3dV3d[] vbo, out uint[] ibo )
        {

            uint VertexCounter = 0;
            uint IndexCounter = 0;

            foreach ( Chunk ch in c )
            {
                VertexCounter += ch.VertexCount;
                IndexCounter += ch.IndexCount;
            }

            vbo = new VertexT2dN3dV3d[VertexCounter];
            ibo = new uint[IndexCounter];

            VertexCounter = 0;
            IndexCounter = 0;

            foreach ( Chunk ch in c )
            {
                for ( int i = 0; i < ch.Vertices.Length; i++ )
                {
                    vbo[VertexCounter + i] = ch.Vertices[i];
                }

                for ( int i = 0; i < ch.Indices.Length; i++ )
                {
                    ibo[IndexCounter + i] = ch.Indices[i] + VertexCounter;
                }

                VertexCounter += (uint)ch.VertexCount;
                IndexCounter += (uint)ch.IndexCount;
            }
        }
    }
}
