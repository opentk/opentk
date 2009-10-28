using System;
using System.Collections.Generic;
using System.Text;

using OpenTK;

namespace Examples.Shapes
{
    public sealed class SlicedSphere: DrawableShape
    {
        public enum eSubdivisions
        {
            Zero = 0,
            One = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five=5,
            Six=6,
            Seven=7,
            Eight=8,
        }

        public enum eDir
        {
            All,
            FrontTopRight,
            FrontBottomRight,
            FrontBottomLeft,
            FrontTopLeft,
            BackTopRight,
            BackBottomRight,
            BackBottomLeft,
            BackTopLeft,

        }

        public SlicedSphere( double radius, Vector3d offset, eSubdivisions subdivs, eDir[] sides, bool useDL )
            : base( useDL )
        {
            double Diameter = radius;

            PrimitiveMode = OpenTK.Graphics.OpenGL.BeginMode.Triangles;

            if ( sides[0] == eDir.All )
            {
                sides = new eDir[] {  eDir.FrontTopRight,
            eDir.FrontBottomRight,
            eDir.FrontBottomLeft,
            eDir.FrontTopLeft,
            eDir.BackTopRight,
            eDir.BackBottomRight,
            eDir.BackBottomLeft,
            eDir.BackTopLeft,};
            }

            VertexArray = new VertexT2dN3dV3d[sides.Length * 3];
            IndexArray = new uint[sides.Length * 3];

            uint counter = 0;
            foreach ( eDir s in sides )
            {
                GetDefaultVertices( s, Diameter, out VertexArray[counter + 0], out VertexArray[counter + 1], out VertexArray[counter + 2] );
                IndexArray[counter + 0] = counter + 0;
                IndexArray[counter + 1] = counter + 1;
                IndexArray[counter + 2] = counter + 2;
                counter += 3;
            }

            if ( subdivs != eSubdivisions.Zero )
            {

                for ( int s = 0; s < (int)subdivs; s++ )
                {
                    #region Assemble Chunks and convert to Arrays
                    List<Chunk> AllChunks = new List<Chunk>();
                    for ( uint i = 0; i < IndexArray.Length; i += 3 )
                    {
                        Chunk chu;
                        Subdivide( Diameter,
                                   ref VertexArray[IndexArray[i + 0]],
                                   ref VertexArray[IndexArray[i + 1]],
                                   ref VertexArray[IndexArray[i + 2]],
                                   out chu );
                        AllChunks.Add( chu );
                    }

                    Chunk.GetArray( ref AllChunks, out VertexArray, out IndexArray );
                    AllChunks.Clear();
                    #endregion Assemble Chunks and convert to Arrays
                }
            }

            for (int i=0; i<VertexArray.Length;i++)
            {
            VertexArray[i].Position.Add( ref offset );
            }
        }

        private void GetDefaultVertices( eDir s, double scale, out VertexT2dN3dV3d first, out VertexT2dN3dV3d second, out VertexT2dN3dV3d third )
        {
            VertexT2dN3dV3d t1 = new VertexT2dN3dV3d(),
                            t2 = new VertexT2dN3dV3d(),
                            t3 = new VertexT2dN3dV3d();
            switch ( s )
            {
            case eDir.FrontTopRight:
                t1 = new VertexT2dN3dV3d( new Vector2d( 0.5, 1.0 ), Vector3d.UnitY, Vector3d.UnitY * scale );
                t2 = new VertexT2dN3dV3d( new Vector2d( 0.0, 0.0 ), Vector3d.UnitZ, Vector3d.UnitZ * scale );
                t3 = new VertexT2dN3dV3d( new Vector2d( 0.5, 0.0 ), Vector3d.UnitX, Vector3d.UnitX * scale );
                break;
            case eDir.FrontBottomRight:
                t1 = new VertexT2dN3dV3d( new Vector2d( 0.5, 0.0 ), Vector3d.UnitX, Vector3d.UnitX * scale );
                t2 = new VertexT2dN3dV3d( new Vector2d( 0.0, 0.0 ), Vector3d.UnitZ, Vector3d.UnitZ * scale );
                t3 = new VertexT2dN3dV3d( new Vector2d( 0.5, 1.0 ), -Vector3d.UnitY, -Vector3d.UnitY * scale );
                break;
            case eDir.FrontBottomLeft: 
                t1 = new VertexT2dN3dV3d( new Vector2d( 0.5, 0.0 ), Vector3d.UnitX, Vector3d.UnitX * scale );
                t2 = new VertexT2dN3dV3d( new Vector2d( 0.5, 1.0 ), -Vector3d.UnitY, -Vector3d.UnitY * scale );
                t3 = new VertexT2dN3dV3d( new Vector2d( 1.0, 0.0 ), -Vector3d.UnitZ, -Vector3d.UnitZ * scale );
                break;
            case eDir.FrontTopLeft:
                t1 = new VertexT2dN3dV3d( new Vector2d( 1.0, 0.0 ), -Vector3d.UnitZ, -Vector3d.UnitZ * scale );
                t2 = new VertexT2dN3dV3d( new Vector2d( 0.5, 1.0 ), Vector3d.UnitY, Vector3d.UnitY * scale );
                t3 = new VertexT2dN3dV3d( new Vector2d( 0.5, 0.0 ), Vector3d.UnitX, Vector3d.UnitX * scale );
                break;
            case eDir.BackTopRight:
                t1 = new VertexT2dN3dV3d( new Vector2d( 0.5, 1.0 ), Vector3d.UnitY, Vector3d.UnitY * scale );
                t2 = new VertexT2dN3dV3d( new Vector2d( 0.0, 1.0 ), -Vector3d.UnitX, -Vector3d.UnitX * scale );
                t3 = new VertexT2dN3dV3d( new Vector2d( 0.0, 0.0 ), Vector3d.UnitZ, Vector3d.UnitZ * scale );
                break;
            case eDir.BackBottomRight:
                t1 = new VertexT2dN3dV3d( new Vector2d( 0.5, 1.0 ), -Vector3d.UnitY, -Vector3d.UnitY * scale );
                t2 = new VertexT2dN3dV3d( new Vector2d( 0.0, 0.0 ), Vector3d.UnitZ, Vector3d.UnitZ * scale );
                t3 = new VertexT2dN3dV3d( new Vector2d( 0.0, 1.0 ), -Vector3d.UnitX, -Vector3d.UnitX * scale );
                break;
            case eDir.BackBottomLeft:
                t1 = new VertexT2dN3dV3d( new Vector2d( 0.5, 1.0 ), -Vector3d.UnitY, -Vector3d.UnitY * scale );
                t2 = new VertexT2dN3dV3d( new Vector2d( 1.0, 1.0 ), -Vector3d.UnitX, -Vector3d.UnitX * scale );
                t3 = new VertexT2dN3dV3d( new Vector2d( 1.0, 0.0 ), -Vector3d.UnitZ, -Vector3d.UnitZ * scale );
                break;
            case eDir.BackTopLeft:
                t1 = new VertexT2dN3dV3d( new Vector2d( 0.5, 1.0 ), Vector3d.UnitY, Vector3d.UnitY * scale );
                t2 = new VertexT2dN3dV3d( new Vector2d( 1.0, 0.0 ), -Vector3d.UnitZ, -Vector3d.UnitZ * scale );
                t3 = new VertexT2dN3dV3d( new Vector2d( 1.0, 1.0 ), -Vector3d.UnitX, -Vector3d.UnitX * scale );
                break;
            }
            first = t1;
            second = t2;
            third = t3;
        }


        private void Subdivide( double Scale, ref VertexT2dN3dV3d first, ref VertexT2dN3dV3d second, ref VertexT2dN3dV3d third, out Chunk c )
        {
            c = new Chunk(6, 12);

            c.Vertices[0] = first;
            
            Vector3d.Lerp(ref first.Position, ref second.Position, 0.5,out c.Vertices[1].Normal );
            c.Vertices[1].Normal.Normalize();
            c.Vertices[1].Position = c.Vertices[1].Normal * Scale;
            Vector2d.Lerp( ref first.TexCoord, ref second.TexCoord, 0.5, out c.Vertices[1].TexCoord );

            Vector3d.Lerp( ref third.Position, ref first.Position, 0.5, out c.Vertices[2].Normal );
            c.Vertices[2].Normal.Normalize();
            c.Vertices[2].Position = c.Vertices[2].Normal * Scale;
            Vector2d.Lerp( ref third.TexCoord, ref first.TexCoord, 0.5, out c.Vertices[2].TexCoord );

            c.Vertices[3] = second;
    
            Vector3d.Lerp( ref second.Position, ref third.Position, 0.5, out c.Vertices[4].Normal );
            c.Vertices[4].Normal.Normalize();
            c.Vertices[4].Position = c.Vertices[4].Normal * Scale;
            Vector2d.Lerp( ref second.TexCoord, ref third.TexCoord, 0.5, out c.Vertices[4].TexCoord );

            c.Vertices[5] = third;

            #region Indices
            c.Indices[0]=0;
            c.Indices[1]=1;
            c.Indices[2]=2;
            c.Indices[3]=2;
            c.Indices[4]=1;
            c.Indices[5]=4;
            c.Indices[6]=1;
            c.Indices[7]=3;
            c.Indices[8]=4;
            c.Indices[9]=2;
            c.Indices[10]=4;
            c.Indices[11]=5;
            #endregion Indices
        }

    }
}
