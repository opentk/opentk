using System;
using System.Collections.Generic;

namespace Examples.Shapes
{
    public sealed class KochTetrahedron: DrawableShape
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

        public KochTetrahedron( double scale, double extrusionHeight, double extrusionMultiplier, eSubdivisions subdivs, bool useDL )
            : base( useDL )
        {
            TetrahedronFace[] Triangles;

            switch ( subdivs )
            {
            case eSubdivisions.Zero:
                SierpinskiTetrahedron.CreateDefaultTetrahedron( scale, out Triangles );
                break;
            case eSubdivisions.One:
            case eSubdivisions.Two:
            case eSubdivisions.Three:
            case eSubdivisions.Four:
            case eSubdivisions.Five:
            case eSubdivisions.Six:
            case eSubdivisions.Seven:
            case eSubdivisions.Eight:
                SierpinskiTetrahedron.CreateDefaultTetrahedron( scale, out Triangles );
                for ( int i = 0; i < (int)subdivs; i++ )
                {
                    TetrahedronFace[] temp;
                    this.SubdivideKoch( extrusionHeight, ref Triangles, out temp );
                    Triangles = temp;
                    extrusionHeight *= extrusionMultiplier;
                }
                break;
            default: throw new ArgumentOutOfRangeException( "Subdivisions other than contained in the enum cause overflows and are not allowed." );

            }

            PrimitiveMode = OpenTK.Graphics.OpenGL.BeginMode.Triangles;
            SierpinskiTetrahedron.GetVertexArray( ref Triangles, out VertexArray );
            IndexArray = null;
        }

        private void SubdivideKoch( double height, ref TetrahedronFace[] input, out TetrahedronFace[] output )
        {
            output = new TetrahedronFace[input.Length * 6];

            int counter = 0;
            for ( int i = 0; i < input.Length; i++ )
            {
                input[i].SubdivideKoch(height, out output[counter + 0], out output[counter + 1], out output[counter + 2], out output[counter + 3], out output[counter + 4], out output[counter + 5] );
                counter += 6; // every source triangle emits 6 new triangles
            }

        }
    }
}
