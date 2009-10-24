using System;
using System.Collections.Generic;

using OpenTK;

namespace Examples.Shapes
{
    public sealed partial class MengerSponge: DrawableShape
    {

        public enum eSubdivisions
        {
            None = 0,
            One = 1,
            Two = 2,
            Three = 3,
        }

        public MengerSponge( double scale, eSubdivisions subdivs, bool useDL )
            : base( useDL )
        {
            List<MengerCube> Cubes;
            switch ( subdivs )
            {
            case eSubdivisions.None:
                CreateDefaultMengerSponge( scale, out Cubes );
                break;
            case eSubdivisions.One:
            case eSubdivisions.Two:
            case eSubdivisions.Three:
                CreateDefaultMengerSponge( scale, out Cubes );
                for ( int i = 0; i < (int)subdivs; i++ )
                {
                    List<MengerCube> temp;
                    SubdivideMengerSponge( ref Cubes, out temp );
                    Cubes = temp;
                }
                break;
            default: throw new ArgumentOutOfRangeException( "Subdivisions other than contained in the enum cause overflows and are not allowed." );
            }

            PrimitiveMode = OpenTK.Graphics.OpenGL.BeginMode.Triangles;

            #region Get Array Dimensions
            uint
                VertexCount = 0,
                IndexCount = 0;

            foreach ( MengerCube c in Cubes )
            {
                uint t1, t2;
                c.GetArraySizes( out t1, out t2 );
                VertexCount += t1;
                IndexCount += t2;
            }

            VertexArray = new VertexT2dN3dV3d[VertexCount];
            IndexArray = new uint[IndexCount];
            #endregion Get Array Dimensions

            List<Chunk> AllChunks = new List<Chunk>();

            #region Build a temporary List of all loose pieces
            foreach ( MengerCube c in Cubes )
            {
                c.GetVboAndIbo( ref AllChunks );
            }
            #endregion Build a temporary List of all loose pieces

            #region Assemble pieces into a single VBO and IBO
            VertexCount = 0;
            IndexCount = 0;

            foreach ( Chunk ch in AllChunks )
            {
                for ( int i = 0; i < ch.Vertices.Length; i++ )
                {
                    VertexArray[VertexCount + i] = ch.Vertices[i];
                }

                for ( int i = 0; i < ch.Indices.Length; i++ )
                {
                    IndexArray[IndexCount + i] = ch.Indices[i] + VertexCount;
                }

                VertexCount += (uint)ch.Vertices.Length;
                IndexCount += (uint)ch.Indices.Length;
            }

            #endregion Assemble pieces into a single VBO and IBO

            AllChunks.Clear();
        }

        private void CreateDefaultMengerSponge( double halfwidth, out List<MengerCube> output )
        {
            output = new List<MengerCube>( 1 );
            output.Add( new MengerCube( Vector3d.Zero, halfwidth, MengerCube.AllSides, MengerCube.AllSides ) );
        }

        private void SubdivideMengerSponge( ref List<MengerCube> input, out List<MengerCube> output )
        {
            output = new List<MengerCube>( input.Count * 20 );
            foreach ( MengerCube InputCube in input )
            {
                MengerCube[] SubdividedCubes;
                InputCube.Subdivide( out SubdividedCubes );
                for ( int i = 0; i < SubdividedCubes.Length; i++ )
                {
                    output.Add( SubdividedCubes[i] );
                }
            }
        }

    }
}
