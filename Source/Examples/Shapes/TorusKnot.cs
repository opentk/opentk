using System;
using System.Diagnostics;

using OpenTK;

namespace Examples.Shapes
{
    public sealed class TorusKnot: DrawableShape
    {
        #region Constants
        // hard minimums to make sure the created Torusknot is 3D
        private const int MINShapeVertices = 3;
        private const int MINPathSteps = 32;
        private const double TwoPi = ( 2.0 * System.Math.PI );
        #endregion Constants

        public TorusKnot( int pathsteps, int shapevertices, double radius, int p, int q, int TexCount, bool useDL )
            : base( useDL )
        {
            Trace.Assert( pathsteps >= MINPathSteps, "A Path must have at least " + MINPathSteps + " Steps to form a volume." );
            Trace.Assert( shapevertices >= MINShapeVertices, "A Shape must contain at least " + MINShapeVertices + " Vertices to be considered valid and create a volume." );
            Trace.Assert( TexCount > 1, "at least 1 Texture set is required." );

            PrimitiveMode = OpenTK.Graphics.OpenGL.BeginMode.TriangleStrip;

            Vector3d[] PathPositions = new Vector3d[pathsteps];

            #region Find the center Points for each step on the path

            for ( int i = 0; i < pathsteps; i++ )
            {
                double Angle = ( i / (double)pathsteps ) * TwoPi;
                double AngleTimesP = Angle * p;
                double AngleTimesQ = Angle * q;
                double r = ( 0.5 * ( 2.0 + System.Math.Sin( AngleTimesQ ) ) );

                PathPositions[i] = new Vector3d( ( r * System.Math.Cos( AngleTimesP ) ),
                                                 ( r * System.Math.Cos( AngleTimesQ ) ),
                                                 ( r * System.Math.Sin( AngleTimesP ) ) );

            }
            #endregion Find the center Points for each step on the path

            #region Find the Torus length
            Vector3d result;
            double[] Lengths = new double[pathsteps];
            Vector3d.Subtract( ref PathPositions[pathsteps - 1], ref PathPositions[0], out result );
            Lengths[0] = result.Length;
            double TotalLength = result.Length;
            for ( int i = 1; i < pathsteps; i++ ) // skipping 
            {
                Vector3d.Subtract( ref PathPositions[i - 1], ref PathPositions[i], out result );
                Lengths[i] = result.Length;
                TotalLength += result.Length;
            }
            Trace.WriteLine( "the TorusKnot's length is: " + TotalLength + " " );
            #endregion Find the Torus length

            VertexArray = new VertexT2dN3dV3d[pathsteps * shapevertices];

            #region Loft a circle Shape along the path
            double TwoPiThroughVert = TwoPi / shapevertices; // precalc for reuse
            for ( uint i = 0; i < pathsteps; i++ )
            {
                Vector3d last, next, normal, tangent;
                if ( i == pathsteps - 1 )
                    next = PathPositions[0];
                else
                    next = PathPositions[i + 1];
                if ( i == 0 )
                    last = PathPositions[pathsteps - 1];
                else
                    last = PathPositions[i - 1];

                Vector3d.Subtract( ref next, ref last, out tangent ); // Guesstimate tangent
                tangent.Normalize();

                Vector3d.Add( ref next, ref last, out normal ); // Approximate N
                normal.Normalize();
                Vector3d.Multiply( ref normal, radius, out normal );// scale the shape to desired radius

                for ( uint j = 0; j < shapevertices; j++ )
                {
                    uint index = i * (uint)shapevertices + j;

                    // Create a point on the plane and rotate it
                    Matrix4d RotationMatrix = Matrix4d.Rotate( tangent, -( j * TwoPiThroughVert ) );
                    Vector3d point = Vector3d.TransformVector( normal, RotationMatrix );
                    Vector3d.Add( ref PathPositions[i], ref point, out VertexArray[index].Position );
                    // Since the used shape is a circle, the Vertex normal's heading is easy to find
                    Vector3d.Subtract( ref VertexArray[index].Position, ref PathPositions[i], out VertexArray[index].Normal );
                    VertexArray[index].Normal.Normalize();
                    // just generate some semi-useful UVs to fill blanks
                    VertexArray[index].TexCoord = new Vector2d( (double)( i / TotalLength/ TexCount  ), j / ( shapevertices - 1.0 ) );
                }
            }
            #endregion Loft a circle Shape along the path

            PathPositions = null; // not needed anymore

            uint currentindex = 0;

            #region Build a Triangle strip from the Vertices
            IndexArray = new uint[pathsteps * ( shapevertices * 2 + 2 )]; // 2 triangles per vertex, +2 due to added degenerate triangles
            for ( uint i = 0; i < pathsteps; i++ )
            {
                uint RowCurrent = i * (uint)shapevertices;
                uint RowBelow;
                if ( i == pathsteps - 1 )
                    RowBelow = 0; // for the last row, the first row is the following
                else
                    RowBelow = ( i + 1 ) * (uint)shapevertices;

                // new ring begins here
                for ( uint j = 0; j < shapevertices; j++ )
                {
                    IndexArray[currentindex++] = RowCurrent + j;
                    IndexArray[currentindex++] = RowBelow + j;
                }
                // ring ends here, repeat first 2 vertices to insert 2 degenerate triangles to reach following ring
                IndexArray[currentindex++] = RowCurrent;
                IndexArray[currentindex++] = RowBelow;
            }
            #endregion Build a Triangle strip from the Vertices
        }

    }
}
