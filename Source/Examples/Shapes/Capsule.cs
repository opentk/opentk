using System;
using System.Collections.Generic;

using OpenTK;

namespace Examples.Shapes
{
    public sealed class Capsule: DrawableShape
    {
        public enum eSubdivisions
        {
            None = 0,
            One = 1,
            Two = 2,
            Three = 3,
            Four = 4,
        }


        public Capsule( double radius, double height, eSubdivisions subdivs, bool useDL )
            : base( useDL )
        {
            uint HoseSubDivs = 0;
            SlicedSphere.eSubdivisions spheresubdivs = SlicedSphere.eSubdivisions.Zero;

            switch ( subdivs )
            {
            case eSubdivisions.None:
                spheresubdivs = SlicedSphere.eSubdivisions.Zero;
                HoseSubDivs = 0;
                break;
            case eSubdivisions.One:
                spheresubdivs = SlicedSphere.eSubdivisions.One;
                HoseSubDivs = 1;
                break;
            case eSubdivisions.Two:
                spheresubdivs = SlicedSphere.eSubdivisions.Two;
                HoseSubDivs = 3;
                break;
            case eSubdivisions.Three:
                spheresubdivs = SlicedSphere.eSubdivisions.Three;
                HoseSubDivs = 7;
                break;
            case eSubdivisions.Four:
                spheresubdivs = SlicedSphere.eSubdivisions.Four;
                HoseSubDivs = 15;
                break;
            }
            PrimitiveMode = OpenTK.Graphics.OpenGL.PrimitiveType.Triangles;

            OpenTK.Graphics.OpenGL.PrimitiveType TemporaryMode;
            VertexT2dN3dV3d[] TemporaryVBO;
            uint[] TemporaryIBO;

            List<Chunk> AllChunks = new List<Chunk>();
            Vector3d offset1 = new Vector3d( 0.0, 0.0, height ),
                     offset2 = new Vector3d( 0.0, 0.0, -height );
            for ( int i = 0; i < 4; i++ )
            {
                SlicedHose.eSide tempSide = SlicedHose.eSide.FrontTop;
                switch ( i )
                {
                case 0:
                    tempSide = SlicedHose.eSide.FrontBottom;
                    break;
                case 1:
                    tempSide = SlicedHose.eSide.BackBottom;
                    break;
                case 2:
                    tempSide = SlicedHose.eSide.BackTop;
                    break;
                case 3:
                    tempSide = SlicedHose.eSide.FrontTop;
                    break;
                }
                SlicedHose tempHose = new SlicedHose( tempSide, HoseSubDivs, radius, offset1, offset2, false );
                tempHose.GetArraysforVBO( out TemporaryMode, out TemporaryVBO, out TemporaryIBO );
                tempHose.Dispose();
                AllChunks.Add( new Chunk( ref TemporaryVBO, ref TemporaryIBO ) );
            }

            SlicedSphere front = new SlicedSphere( radius, offset1, spheresubdivs,
                                                       new SlicedSphere.eDir[] {
                                                           SlicedSphere.eDir.BackBottomRight,
                                                           SlicedSphere.eDir.FrontTopRight,
                                                           SlicedSphere.eDir.BackTopRight,
                                                           SlicedSphere.eDir.FrontBottomRight, 
                                                          },
                                                       false );

            front.GetArraysforVBO( out TemporaryMode, out TemporaryVBO, out TemporaryIBO );
            AllChunks.Add( new Chunk( ref TemporaryVBO, ref TemporaryIBO ) );
            front.Dispose();

            SlicedSphere back = new SlicedSphere( radius, offset2, spheresubdivs,
                                                      new SlicedSphere.eDir[] { 
                                                          SlicedSphere.eDir.FrontBottomLeft,
                                                          SlicedSphere.eDir.FrontTopLeft, 
                                                          SlicedSphere.eDir.BackTopLeft,
                                                          SlicedSphere.eDir.BackBottomLeft },
                                                      false );
            back.GetArraysforVBO( out TemporaryMode, out TemporaryVBO, out TemporaryIBO );
            AllChunks.Add( new Chunk( ref TemporaryVBO, ref TemporaryIBO ) );
            back.Dispose();

            Chunk.GetArray( ref AllChunks, out VertexArray, out IndexArray );
            AllChunks.Clear();
        }
    }
}
