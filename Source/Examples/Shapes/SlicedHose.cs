using System;
using System.Collections.Generic;
using OpenTK;

namespace Examples.Shapes
{
	public sealed class SlicedHose : DrawableShape
	{

        public enum eSide:byte
        {
            // Around X Axis
            BottomRight,
            TopRight,
            TopLeft,
            BottomLeft,

            // Around Y Axis

            FrontRight,
            BackRight,
            BackLeft,
            FrontLeft,

            // Around Z Axis
            FrontBottom,
            BackBottom,
            BackTop,
            FrontTop,
        }

        public SlicedHose( eSide side, uint subdivs, double scale, Vector3d offset1, Vector3d offset2, bool useDL )
            : base( useDL )
        {
            PrimitiveMode = OpenTK.Graphics.OpenGL.PrimitiveType.Triangles;

            Vector3d start = Vector3d.Zero,
                     end = Vector3d.Zero;
            double TexCoordStart=0f, TexCoordEnd=0f;

            switch ( side )
            {
            #region Around X Axis
            case eSide.BottomRight:
                start = -Vector3d.UnitY;
                end = Vector3d.UnitZ;
                TexCoordStart = 0.0;
                TexCoordEnd = 0.25;
                break;
            case eSide.TopRight:
                start = Vector3d.UnitZ;
                end = Vector3d.UnitY;
                TexCoordStart = 0.25;
                TexCoordEnd = 0.5;
                break;
            case eSide.TopLeft:
                start = Vector3d.UnitY;
                end = -Vector3d.UnitZ;
                TexCoordStart = 0.5;
                TexCoordEnd = 0.75;
                break;
            case eSide.BottomLeft:
                start = -Vector3d.UnitZ;
                end = -Vector3d.UnitY;
                TexCoordStart = 0.75;
                TexCoordEnd = 1.0;
                break;
            #endregion Around X Axis
            #region Around Y Axis
            case eSide.FrontRight:
                start = Vector3d.UnitX;
                end = Vector3d.UnitZ;
                TexCoordStart = 0.0;
                TexCoordEnd = 0.25;
                break;
            case eSide.BackRight:
                start = Vector3d.UnitZ;
                end = -Vector3d.UnitX;
                TexCoordStart = 0.25;
                TexCoordEnd = 0.5;
                break;
            case eSide.BackLeft:
                start = -Vector3d.UnitX;
                end = -Vector3d.UnitZ;
                TexCoordStart = 0.5;
                TexCoordEnd = 0.75;
                break;
            case eSide.FrontLeft:
                start = -Vector3d.UnitZ;
                end = Vector3d.UnitX;
                TexCoordStart = 0.75;
                TexCoordEnd = 1.0;
                break;
#endregion Around Y Axis
            #region Around Z Axis
            case eSide.FrontBottom:
                start = -Vector3d.UnitY;
                end = Vector3d.UnitX;
                TexCoordStart = 0.0;
                TexCoordEnd = 0.25;
                break;
            case eSide.BackBottom:
                start = -Vector3d.UnitX;
                end = -Vector3d.UnitY;
                TexCoordStart = 0.25;
                TexCoordEnd = 0.5;
                break;
            case eSide.BackTop:
                start = Vector3d.UnitY;
                end = -Vector3d.UnitX;
                TexCoordStart = 0.5;
                TexCoordEnd = 0.75;
                break;
            case eSide.FrontTop:
                start = Vector3d.UnitX;
                end = Vector3d.UnitY;
                TexCoordStart = 0.75;
                TexCoordEnd = 1.0;
                break;
#endregion Around Z Axis

            }

            VertexT2dN3dV3d[] temp = new VertexT2dN3dV3d[2 + subdivs];

            double divisor = 1.0/ ((double)temp.Length-1.0);
            for ( int i = 0; i < temp.Length; i++ )
            {
                float Multiplier = (float)( i * divisor );

                temp[i].TexCoord.X = TexCoordStart * Multiplier + TexCoordEnd * ( 1.0f- Multiplier);

                Slerp( ref start, ref end, Multiplier, out temp[i].Normal );
                temp[i].Normal.Normalize();
                temp[i].Position = temp[i].Normal;
                temp[i].Position *= scale;
            }

            VertexArray = new VertexT2dN3dV3d[temp.Length * 2];
            IndexArray = new uint[( temp.Length - 1 ) * 2 * 3];

            uint VertexCounter = 0,
                 IndexCounter = 0,
                 QuadCounter = 0;

            for ( int i = 0; i < temp.Length; i++ )
            {
                VertexArray[VertexCounter + 0].TexCoord.X = temp[i].TexCoord.X;
                VertexArray[VertexCounter + 0].TexCoord.Y = 0.0;
                VertexArray[VertexCounter + 0].Normal = temp[i].Normal;
                VertexArray[VertexCounter + 0].Position = temp[i].Position + offset1;


                VertexArray[VertexCounter + 1].TexCoord.X = temp[i].TexCoord.X;
                VertexArray[VertexCounter + 1].TexCoord.Y = 1.0;
                VertexArray[VertexCounter + 1].Normal = temp[i].Normal;
                VertexArray[VertexCounter + 1].Position = temp[i].Position + offset2;
                VertexCounter += 2;

                if ( i < temp.Length - 1 )
                {
                    IndexArray[IndexCounter + 0] = QuadCounter + 0;
                    IndexArray[IndexCounter + 1] = QuadCounter + 1;
                    IndexArray[IndexCounter + 2] = QuadCounter + 2;

                    IndexArray[IndexCounter + 3] = QuadCounter + 2;
                    IndexArray[IndexCounter + 4] = QuadCounter + 1;
                    IndexArray[IndexCounter + 5] = QuadCounter + 3;

                    IndexCounter += 6;
                    QuadCounter += 2;
                }
            }

        }
 
    private void Slerp( ref Vector3d a, ref Vector3d b, double factor, out Vector3d result)
    {
        double t1;
        Vector3d.Dot( ref a, ref b, out t1 );
        double theta = System.Math.Acos( t1 );

        double temp = 1.0 / System.Math.Sin( theta );
        double t2 = System.Math.Sin( ( 1.0 - factor ) * theta ) * temp;
        double t3 = System.Math.Sin( factor * theta ) * temp;

        Vector3d v1 = Vector3d.Multiply( a, t2);
        Vector3d v2 = Vector3d.Multiply( b, t3 );
        result = Vector3d.Add( v1, v2 );
    }


    }
}
