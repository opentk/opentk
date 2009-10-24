using System;
using System.Collections.Generic;

using OpenTK;

namespace Examples.Shapes
{
    public sealed class ChamferCube: DrawableShape
    {

        public enum SubDivs: byte
        {
            Zero,
            One,
            Two,
            Three,
            Four,
        }

        public ChamferCube( double Width, double Height, double Length, SubDivs subdivs, double radius, bool useDL )
            : base( useDL )
        {   
            SlicedSphere.eSubdivisions sphereSubDivs = SlicedSphere.eSubdivisions.Zero;
            uint hoseSubDivs = 0;

            switch ( subdivs )
            {
            case SubDivs.Zero:
                sphereSubDivs = SlicedSphere.eSubdivisions.Zero;
                hoseSubDivs = 0;
                break;
            case SubDivs.One:
                sphereSubDivs = SlicedSphere.eSubdivisions.One;
                hoseSubDivs = 1;
                break;
            case SubDivs.Two:
                sphereSubDivs = SlicedSphere.eSubdivisions.Two;
                hoseSubDivs = 3;
                break;
            case SubDivs.Three:
                sphereSubDivs = SlicedSphere.eSubdivisions.Three;
                hoseSubDivs = 7;
                break;
            case SubDivs.Four:
                sphereSubDivs = SlicedSphere.eSubdivisions.Four;
                hoseSubDivs = 15;
                break;
            }

            #region Temporary Storage

            List<Chunk> AllChunks = new List<Chunk>();
            OpenTK.Graphics.OpenGL.BeginMode TemporaryMode;
            VertexT2dN3dV3d[] TemporaryVBO;
            uint[] TemporaryIBO;

            #endregion Temporary Storage

            Vector3d FrontTopRightEdge = new Vector3d( +Width - radius, +Height - radius, +Length - radius );
            Vector3d FrontTopLeftEdge = new Vector3d( +Width - radius, +Height - radius, -Length + radius );
            Vector3d FrontBottomRightEdge = new Vector3d( +Width - radius, -Height + radius, +Length - radius );
            Vector3d FrontBottomLeftEdge = new Vector3d( +Width - radius, -Height + radius, -Length + radius );
            Vector3d BackTopRightEdge = new Vector3d( -Width + radius, +Height - radius, +Length - radius );
            Vector3d BackTopLeftEdge = new Vector3d( -Width + radius, +Height - radius, -Length + radius );
            Vector3d BackBottomRightEdge = new Vector3d( -Width + radius, -Height + radius, +Length - radius );
            Vector3d BackBottomLeftEdge = new Vector3d( -Width + radius, -Height + radius, -Length + radius );

            #region 8 sliced Spheres
            SlicedSphere tempSphere;
            Vector3d tempVector = Vector3d.Zero;
            SlicedSphere.eDir[] tempEdge = new SlicedSphere.eDir[1];

            for ( int i = 0; i < 8; i++ )
            {
                switch ( i )
                {
                case 0:
                    tempVector = FrontTopRightEdge;
                    tempEdge = new SlicedSphere.eDir[] { SlicedSphere.eDir.FrontTopRight };
                    break;
                case 1:
                    tempVector = FrontTopLeftEdge;
                    tempEdge = new SlicedSphere.eDir[] { SlicedSphere.eDir.FrontTopLeft };
                    break;
                case 2:
                    tempVector = FrontBottomRightEdge;
                    tempEdge = new SlicedSphere.eDir[] { SlicedSphere.eDir.FrontBottomRight };
                    break;
                case 3:
                    tempVector = FrontBottomLeftEdge;
                    tempEdge = new SlicedSphere.eDir[] { SlicedSphere.eDir.FrontBottomLeft };
                    break;
                case 4:
                    tempVector = BackBottomRightEdge;
                    tempEdge = new SlicedSphere.eDir[] { SlicedSphere.eDir.BackBottomRight };
                    break;
                case 5:
                    tempVector = BackBottomLeftEdge;
                    tempEdge = new SlicedSphere.eDir[] { SlicedSphere.eDir.BackBottomLeft };
                    break;
                case 6:
                    tempVector = BackTopRightEdge;
                    tempEdge = new SlicedSphere.eDir[] { SlicedSphere.eDir.BackTopRight };
                    break;
                case 7:
                    tempVector = BackTopLeftEdge;
                    tempEdge = new SlicedSphere.eDir[] { SlicedSphere.eDir.BackTopLeft };
                    break;
                }
                tempSphere = new SlicedSphere( radius,
                                                 tempVector,
                                                 sphereSubDivs,
                                                 tempEdge,
                                                 false );
                tempSphere.GetArraysforVBO( out TemporaryMode, out TemporaryVBO, out TemporaryIBO );
                tempSphere.Dispose();
                AllChunks.Add( new Chunk( ref TemporaryVBO, ref TemporaryIBO ) );
            }
            #endregion 8 sliced Spheres

            #region 12 sliced Hoses

            SlicedHose tempHose;
            SlicedHose.eSide tempSide = SlicedHose.eSide.BackBottom;
            Vector3d tempHoseStart = Vector3d.Zero;
            Vector3d tempHoseEnd = Vector3d.Zero;

            for ( int i = 0; i < 12; i++ )
            {
                switch ( i )
                {
                #region Around X Axis
                case 0:
                    tempSide = SlicedHose.eSide.BottomRight;
                    tempHoseStart = BackBottomRightEdge;
                    tempHoseEnd = FrontBottomRightEdge;
                    break;
                case 1:
                    tempSide = SlicedHose.eSide.TopRight;
                    tempHoseStart = BackTopRightEdge;
                    tempHoseEnd = FrontTopRightEdge;
                    break;
                case 2:
                    tempSide = SlicedHose.eSide.TopLeft;
                    tempHoseStart = BackTopLeftEdge;
                    tempHoseEnd = FrontTopLeftEdge;
                    break;
                case 3:
                    tempSide = SlicedHose.eSide.BottomLeft;
                    tempHoseStart = BackBottomLeftEdge;
                    tempHoseEnd = FrontBottomLeftEdge;
                    break;
                #endregion Around X Axis
                #region Around Y Axis
                case 4:
                    tempSide = SlicedHose.eSide.FrontRight;
                    tempHoseStart = FrontBottomRightEdge;
                    tempHoseEnd = FrontTopRightEdge;
                    break;
                case 5:
                    tempSide = SlicedHose.eSide.BackRight;
                    tempHoseStart = BackBottomRightEdge;
                    tempHoseEnd = BackTopRightEdge;
                    break;
                case 6:
                    tempSide = SlicedHose.eSide.BackLeft;
                    tempHoseStart = BackBottomLeftEdge;
                    tempHoseEnd = BackTopLeftEdge;
                    break;
                case 7:
                    tempSide = SlicedHose.eSide.FrontLeft;
                    tempHoseStart = FrontBottomLeftEdge;
                    tempHoseEnd = FrontTopLeftEdge;
                    break;
                #endregion Around Y Axis
                #region Around Z Axis
                case 8:
                    tempSide = SlicedHose.eSide.FrontTop;
                    tempHoseStart = FrontTopRightEdge;
                    tempHoseEnd = FrontTopLeftEdge;
                    break;
                case 9:
                    tempSide = SlicedHose.eSide.BackTop;
                    tempHoseStart = BackTopRightEdge;
                    tempHoseEnd = BackTopLeftEdge;
                    break;
                case 10:
                    tempSide = SlicedHose.eSide.BackBottom;
                    tempHoseStart = BackBottomRightEdge;
                    tempHoseEnd = BackBottomLeftEdge;
                    break;
                case 11:
                    tempSide = SlicedHose.eSide.FrontBottom;
                    tempHoseStart = FrontBottomRightEdge;
                    tempHoseEnd = FrontBottomLeftEdge;
                    break;
                #endregion Around Z Axis
                }
                tempHose = new SlicedHose( tempSide,
                                             hoseSubDivs,
                                             radius,
                                             tempHoseStart,
                                             tempHoseEnd,
                                             false );
                tempHose.GetArraysforVBO( out TemporaryMode, out TemporaryVBO, out TemporaryIBO );
                tempHose.Dispose();
                AllChunks.Add( new Chunk( ref TemporaryVBO, ref TemporaryIBO ) );
            }
            #endregion 12 sliced Hoses

            #region 6 quads for the sides

            VertexT2dN3dV3d[] tempVBO = new VertexT2dN3dV3d[4];
            uint[] tempIBO = new uint[6] { 0, 1, 2, 0, 2, 3 }; // all quads share this IBO

            // all quads use the same texcoords
            tempVBO[0].TexCoord = new Vector2d( 0.0, 1.0 );
            tempVBO[1].TexCoord = new Vector2d( 0.0, 0.0 );
            tempVBO[2].TexCoord = new Vector2d( 1.0, 0.0 );
            tempVBO[3].TexCoord = new Vector2d( 1.0, 1.0 );

            // front face
            tempVBO[0].Normal = tempVBO[1].Normal = tempVBO[2].Normal = tempVBO[3].Normal = Vector3d.UnitX;
            tempVBO[0].Position = FrontTopRightEdge + new Vector3d( radius, 0.0, 0.0 );
            tempVBO[1].Position = FrontBottomRightEdge + new Vector3d( radius, 0.0, 0.0 );
            tempVBO[2].Position = FrontBottomLeftEdge + new Vector3d( radius, 0.0, 0.0 );
            tempVBO[3].Position = FrontTopLeftEdge + new Vector3d( radius, 0.0, 0.0 );
            AllChunks.Add( new Chunk( ref tempVBO, ref tempIBO ) );

            // back face
            tempVBO[0].Normal = tempVBO[1].Normal = tempVBO[2].Normal = tempVBO[3].Normal = -Vector3d.UnitX;
            tempVBO[0].Position = BackTopLeftEdge - new Vector3d( radius, 0.0, 0.0 );
            tempVBO[1].Position = BackBottomLeftEdge - new Vector3d( radius, 0.0, 0.0 );
            tempVBO[2].Position = BackBottomRightEdge - new Vector3d( radius, 0.0, 0.0 );
            tempVBO[3].Position = BackTopRightEdge - new Vector3d( radius, 0.0, 0.0 );
            AllChunks.Add( new Chunk( ref tempVBO, ref tempIBO ) );

            // top face
            tempVBO[0].Normal = tempVBO[1].Normal = tempVBO[2].Normal = tempVBO[3].Normal = Vector3d.UnitY;
            tempVBO[0].Position = BackTopRightEdge + new Vector3d( 0.0, radius, 0.0 );
            tempVBO[1].Position = FrontTopRightEdge + new Vector3d( 0.0, radius, 0.0 );
            tempVBO[2].Position = FrontTopLeftEdge + new Vector3d( 0.0, radius, 0.0 );
            tempVBO[3].Position = BackTopLeftEdge + new Vector3d( 0.0, radius, 0.0 );
            AllChunks.Add( new Chunk( ref tempVBO, ref tempIBO ) );

            // bottom face
            tempVBO[0].Normal = tempVBO[1].Normal = tempVBO[2].Normal = tempVBO[3].Normal = -Vector3d.UnitY;
            tempVBO[0].Position = BackBottomLeftEdge - new Vector3d( 0.0, radius, 0.0 );
            tempVBO[1].Position = FrontBottomLeftEdge - new Vector3d( 0.0, radius, 0.0 );
            tempVBO[2].Position = FrontBottomRightEdge - new Vector3d( 0.0, radius, 0.0 );
            tempVBO[3].Position = BackBottomRightEdge - new Vector3d( 0.0, radius, 0.0 );
            AllChunks.Add( new Chunk( ref tempVBO, ref tempIBO ) );

            // right face
            tempVBO[0].Normal = tempVBO[1].Normal = tempVBO[2].Normal = tempVBO[3].Normal = Vector3d.UnitZ;
            tempVBO[0].Position = BackTopRightEdge + new Vector3d( 0.0, 0.0, radius );
            tempVBO[1].Position = BackBottomRightEdge + new Vector3d( 0.0, 0.0, radius );
            tempVBO[2].Position = FrontBottomRightEdge + new Vector3d( 0.0, 0.0, radius );
            tempVBO[3].Position = FrontTopRightEdge + new Vector3d( 0.0, 0.0, radius );
            AllChunks.Add( new Chunk( ref tempVBO, ref tempIBO ) );

            // left face
            tempVBO[0].Normal = tempVBO[1].Normal = tempVBO[2].Normal = tempVBO[3].Normal = -Vector3d.UnitZ;
            tempVBO[0].Position = FrontTopLeftEdge - new Vector3d( 0.0, 0.0, radius );
            tempVBO[1].Position = FrontBottomLeftEdge - new Vector3d( 0.0, 0.0, radius );
            tempVBO[2].Position = BackBottomLeftEdge - new Vector3d( 0.0, 0.0, radius );
            tempVBO[3].Position = BackTopLeftEdge - new Vector3d( 0.0, 0.0, radius );
            AllChunks.Add( new Chunk( ref tempVBO, ref tempIBO ) );


            #endregion 6 quads for the sides

            #region Final Assembly of Chunks
            PrimitiveMode = OpenTK.Graphics.OpenGL.BeginMode.Triangles;
            Chunk.GetArray( ref AllChunks, out VertexArray, out IndexArray );
            AllChunks.Clear();
            #endregion Final Assembly of Chunks
        }
    }
}
