using System;
using System.Diagnostics;

using OpenTK;

namespace Examples.Shapes
{
    public sealed partial class SierpinskiTetrahedron: DrawableShape
    {

        public enum eSubdivisions
        {
            /// <summary>Creates a Sierpinski Tetrahedron using 4 triangles.</summary>
            Zero = 0,
            /// <summary>Creates a Sierpinski Tetrahedron using 16 triangles.</summary>
            One = 1,
            /// <summary>Creates a Sierpinski Tetrahedron using 64 triangles.</summary>
            Two = 2,
            /// <summary>Creates a Sierpinski Tetrahedron using 256 triangles.</summary>
            Three = 3,
            /// <summary>Creates a Sierpinski Tetrahedron using 1024 triangles.</summary>
            Four = 4,
            /// <summary>Creates a Sierpinski Tetrahedron using 4096 triangles.</summary>
            Five = 5,
            /// <summary>Creates a Sierpinski Tetrahedron using 16384 triangles.</summary>
            Six = 6,
            /// <summary>Creates a Sierpinski Tetrahedron using 65536 triangles.</summary>
            Seven = 7,
            /// <summary>Creates a Sierpinski Tetrahedron using 262144 triangles.</summary>
            Eight = 8,
            /// <summary>Creates a Sierpinski Tetrahedron using 1048576 triangles.</summary>
            Nine = 9,
        }

        /// <summary>Creates a Sierpinski Tetrahedron which is centered at (0,0,0) and fits into a sphere of radius 1f, or a diameter of 2f</summary>
        /// <param name="scale">Default: 1f.</param>
        /// <param name="subdivs">The number of subdivisions of the Tetrahedron.</param>
        /// <param name="useDL"></param>
        public SierpinskiTetrahedron( double scale, eSubdivisions subdivs, bool useDL )
            : base( useDL )
        {
            TetrahedronFace[] Triangles;

            switch ( subdivs )
            {
            case eSubdivisions.Zero:
                CreateDefaultTetrahedron( scale, out Triangles );
                break;
            case eSubdivisions.One:
            case eSubdivisions.Two:
            case eSubdivisions.Three:
            case eSubdivisions.Four:
            case eSubdivisions.Five:
            case eSubdivisions.Six:
            case eSubdivisions.Seven:
            case eSubdivisions.Eight:
            case eSubdivisions.Nine:
                CreateDefaultTetrahedron( scale, out Triangles );
                for ( int i = 0; i < (int)subdivs; i++ )
                {
                    TetrahedronFace[] temp;
                    SubdivideTetrahedron( ref Triangles, out temp );
                    Triangles = temp;
                }
                break;
            default: throw new ArgumentOutOfRangeException( "Subdivisions other than contained in the enum cause overflows and are not allowed." );
            }

            PrimitiveMode = OpenTK.Graphics.OpenGL.BeginMode.Triangles;
            SierpinskiTetrahedron.GetVertexArray( ref Triangles, out VertexArray );
            IndexArray = null;
        }

        internal static void GetVertexArray( ref TetrahedronFace[] input, out VertexT2dN3dV3d[] output )
        {
            output = new VertexT2dN3dV3d[input.Length * 3];
            int counter = 0;
            for ( int i = 0; i < input.Length; i++ )
            {
                input[i].GetVertices( out output[counter + 0], out output[counter + 1], out output[counter + 2] );
                counter += 3;
            }
        }

        /// <summary>Generates the lowest subdivision mesh, which consists of 4 Triangles.</summary>
        internal static void CreateDefaultTetrahedron( double scale, out TetrahedronFace[] array )
        {
            Vector3d[] Points = new Vector3d[4];
            Points[0] = new Vector3d( 0.0 * scale, 0.0 * scale, 1.0 * scale );
            Points[1] = new Vector3d( -0.816 * scale, 0.471 * scale, -0.333 * scale );
            Points[2] = new Vector3d( 0.816 * scale, 0.471 * scale, -0.333 * scale );
            Points[3] = new Vector3d( 0.0 * scale, -0.943 * scale, -0.333 * scale );

            Vector2d[] TexCoords = new Vector2d[4];
            TexCoords[0] = new Vector2d( 0.0, 0.0 );
            TexCoords[1] = new Vector2d( 1.0, 0.0 );
            TexCoords[2] = new Vector2d( 0.0, 1.0 );
            TexCoords[3] = new Vector2d( 1.0, 1.0 );

            Vector3d Normal;
            array = new TetrahedronFace[4];

            FindNormal( ref Points[0], ref Points[2], ref Points[1], ref Points[3], out Normal );
            array[0] = new TetrahedronFace( ref Points[0], ref TexCoords[2],
                                                   ref Points[2], ref TexCoords[0],
                                                   ref Points[1], ref TexCoords[1],
                                                   ref Points[3],
                                                   ref Normal );

            FindNormal( ref Points[0], ref Points[3], ref Points[2], ref Points[1], out Normal );
            array[1] = new TetrahedronFace( ref Points[0], ref TexCoords[0],
                                                   ref Points[3], ref TexCoords[1],
                                                   ref Points[2], ref TexCoords[2],
                                                   ref Points[1],
                                                   ref Normal );

            FindNormal( ref Points[0], ref Points[1], ref Points[3], ref Points[2], out Normal );
            array[2] = new TetrahedronFace( ref Points[0], ref TexCoords[2],
                                                   ref Points[1], ref TexCoords[1],
                                                   ref Points[3], ref TexCoords[3],
                                                   ref Points[2],
                                                   ref Normal );

            FindNormal( ref Points[1], ref Points[2], ref Points[3], ref Points[0], out Normal );
            array[3] = new TetrahedronFace( ref Points[1], ref TexCoords[3],
                                                   ref Points[2], ref TexCoords[2],
                                                   ref Points[3], ref TexCoords[1],
                                                   ref Points[0],
                                                   ref Normal );
        }

        /// <summary>Subdivides each triangle into 4 new ones.</summary>
        private void SubdivideTetrahedron( ref TetrahedronFace[] source, out TetrahedronFace[] output )
        {

            output = new TetrahedronFace[source.Length * 4];

            int counter = 0;
            for ( int i = 0; i < source.Length; i++ )
            {
                source[i].SubdivideSierpinski( out output[counter + 0], out output[counter + 1], out output[counter + 2], out output[counter + 3] );
                counter += 4; // every source triangle emits 4 new triangles
            }
        }

        /// <summary>A, B and C are the triangle whos normal is to be determined. D is the 4th Point in the Tetraeder which does not belong to the triangle.</summary>
        internal static void FindNormal( ref Vector3d A, ref Vector3d B, ref Vector3d C, ref Vector3d D, out Vector3d result )
        {
            Vector3d temp1, temp2, temp3;

            Vector3d.Subtract( ref A, ref D, out temp1 );
            Vector3d.Subtract( ref B, ref D, out temp2 );
            Vector3d.Subtract( ref C, ref D, out temp3 );

            Vector3d.Add( ref temp1, ref temp2, out result );
            Vector3d.Add(ref result, ref temp3, out result);
            result.Normalize();
        }

        internal static void FindNormal( ref Vector3d A, ref Vector3d B, ref Vector3d C, out Vector3d result )
        {
            Vector3d temp1, temp2;
            Vector3d.Subtract( ref A, ref B, out temp1 );
            temp1.Normalize();
            Vector3d.Subtract(ref C, ref B, out temp2);
            temp2.Normalize();
            Vector3d.Cross( ref temp1, ref temp2, out result );
            result *=  -1.0;
            result.Normalize();
        }

    }
}
