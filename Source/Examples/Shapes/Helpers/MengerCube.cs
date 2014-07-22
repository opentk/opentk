using System;
using System.Collections.Generic;

using OpenTK;

namespace Examples.Shapes
{
    public sealed partial class MengerSponge
    {
        private struct MengerCube
        {
            private Vector3d Center;
            private double SideLength;
            private eSides[] VisibleSides;
            private eSides[] VisibilityToInherit;

            public void GetArraySizes( out uint vertexcount, out uint indexcount )
            {
                vertexcount = (uint)VisibleSides.Length * 8 + 6 * 12;
                indexcount = (uint)VisibleSides.Length * 8 * 3 + 6 * 8 * 3;
            }

            public MengerCube( Vector3d center, double sidelength, eSides[] visibleSides, eSides[] parentsVisibility )
            {
                Center = center;
                SideLength = sidelength;

                /*  List<eSides> Sides = new List<eSides>();
                  foreach ( eSides s in visibleSides )
                  {
                      bool isVisible = false;
                      foreach ( eSides p in parentsVisibility )
                      {
                          if ( (int)p == (int)s )
                          {
                              isVisible = true;
                              break;
                          }
                      }
                      if ( isVisible )
                      {
                          Sides.Add( s );
                      }
                  }
                  VisibleSides = Sides.ToArray();*/
                VisibleSides = visibleSides;
                VisibilityToInherit = visibleSides;
            }

            public void Subdivide( out MengerCube[] cubes )
            {
                cubes = new MengerCube[20]; // 8 + 4 + 8

                double NewLength = this.SideLength / 3.0;
                double six = this.SideLength * 2.0 / 3.0;
                // we got 3x3x3 cubes. All center cubes who touch the XYZ-Axis are removed.

                // front
                cubes[0] = new MengerCube( new Vector3d( Center.X - six, Center.Y + six, Center.Z + six ), NewLength, new eSides[] { eSides.Front, eSides.Left, eSides.Top }, this.VisibilityToInherit );
                cubes[1] = new MengerCube( new Vector3d( Center.X + 0.0, Center.Y + six, Center.Z + six ), NewLength, new eSides[] { eSides.Front, eSides.Bottom, eSides.Back, eSides.Top }, this.VisibilityToInherit );
                cubes[2] = new MengerCube( new Vector3d( Center.X + six, Center.Y + six, Center.Z + six ), NewLength, new eSides[] { eSides.Front, eSides.Right, eSides.Top }, this.VisibilityToInherit );

                cubes[3] = new MengerCube( new Vector3d( Center.X - six, Center.Y + 0.0, Center.Z + six ), NewLength, new eSides[] { eSides.Front, eSides.Right, eSides.Back, eSides.Left }, this.VisibilityToInherit );
                cubes[4] = new MengerCube( new Vector3d( Center.X + six, Center.Y + 0.0, Center.Z + six ), NewLength, new eSides[] { eSides.Front, eSides.Right, eSides.Back, eSides.Left }, this.VisibilityToInherit );

                cubes[5] = new MengerCube( new Vector3d( Center.X - six, Center.Y - six, Center.Z + six ), NewLength, new eSides[] { eSides.Front, eSides.Left, eSides.Bottom } , this.VisibilityToInherit );
                cubes[6] = new MengerCube( new Vector3d( Center.X + 0.0, Center.Y - six, Center.Z + six ), NewLength, new eSides[] { eSides.Front, eSides.Top, eSides.Back, eSides.Bottom }, this.VisibilityToInherit );
                cubes[7] = new MengerCube( new Vector3d( Center.X + six, Center.Y - six, Center.Z + six ), NewLength, new eSides[] { eSides.Front, eSides.Right, eSides.Bottom }, this.VisibilityToInherit );

                // center
                cubes[8] = new MengerCube( new Vector3d( Center.X - six, Center.Y + six, Center.Z + 0.0 ), NewLength, new eSides[] { eSides.Top, eSides.Right, eSides.Bottom, eSides.Left }, this.VisibilityToInherit );

                cubes[9] = new MengerCube( new Vector3d( Center.X + six, Center.Y + six, Center.Z + 0.0 ), NewLength, new eSides[] { eSides.Top, eSides.Right, eSides.Bottom, eSides.Left }, this.VisibilityToInherit );

                cubes[10] = new MengerCube( new Vector3d( Center.X - six, Center.Y - six, Center.Z + 0.0 ), NewLength, new eSides[] { eSides.Top, eSides.Right, eSides.Bottom, eSides.Left }, this.VisibilityToInherit );

                cubes[11] = new MengerCube( new Vector3d( Center.X + six, Center.Y - six, Center.Z + 0.0 ), NewLength, new eSides[] { eSides.Top, eSides.Right, eSides.Bottom, eSides.Left }, this.VisibilityToInherit );

                // back
                cubes[12] = new MengerCube( new Vector3d( Center.X - six, Center.Y + six, Center.Z - six ), NewLength, new eSides[] { eSides.Top, eSides.Back, eSides.Left }, this.VisibilityToInherit );
                cubes[13] = new MengerCube( new Vector3d( Center.X + 0.0, Center.Y + six, Center.Z - six ), NewLength, new eSides[] { eSides.Top, eSides.Back, eSides.Bottom, eSides.Front }, this.VisibilityToInherit );
                cubes[14] = new MengerCube( new Vector3d( Center.X + six, Center.Y + six, Center.Z - six ), NewLength, new eSides[] { eSides.Top, eSides.Back, eSides.Right }, this.VisibilityToInherit );

                cubes[15] = new MengerCube( new Vector3d( Center.X - six, Center.Y + 0.0, Center.Z - six ), NewLength, new eSides[] { eSides.Front, eSides.Right, eSides.Back, eSides.Left } , this.VisibilityToInherit );
                cubes[16] = new MengerCube( new Vector3d( Center.X + six, Center.Y + 0.0, Center.Z - six ), NewLength, new eSides[] { eSides.Front, eSides.Right, eSides.Back, eSides.Left } , this.VisibilityToInherit );

                cubes[17] = new MengerCube( new Vector3d( Center.X - six, Center.Y - six, Center.Z - six ), NewLength, new eSides[] { eSides.Back, eSides.Bottom, eSides.Left } , this.VisibilityToInherit );
                cubes[18] = new MengerCube( new Vector3d( Center.X + 0.0, Center.Y - six, Center.Z - six ), NewLength, new eSides[] { eSides.Top, eSides.Back, eSides.Bottom, eSides.Front }, this.VisibilityToInherit );
                cubes[19] = new MengerCube( new Vector3d( Center.X + six, Center.Y - six, Center.Z - six ), NewLength, new eSides[] { eSides.Back, eSides.Bottom, eSides.Right }, this.VisibilityToInherit );

            }

            public enum eSides: byte
            {
                Front,
                Back,
                Right,
                Left,
                Top,
                Bottom
            }

            internal static readonly eSides[] AllSides = new eSides[] { eSides.Front, eSides.Back, eSides.Right, eSides.Left, eSides.Top, eSides.Bottom };

            public void GetVboAndIbo( ref List<Chunk> chunks )
            {
                foreach ( eSides s in AllSides )
                {
                    DrawSide( s, ref chunks );
                }
            }

            private void DrawSide( eSides side, ref List<Chunk> chunks )
            {
                #region Setup constants for current direction

                double _Zero = 0.0; // 0/3
                double _Three = 0.3333333333333; // 1/3
                double _Six = 0.66666666666666; // 2/3
                double _One = 1.0; // 3/3 

                Vector3d C0 = Center + new Vector3d( -SideLength, -SideLength, +SideLength );
                Vector3d C1 = Center + new Vector3d( +SideLength, -SideLength, +SideLength );
                Vector3d C2 = Center + new Vector3d( +SideLength, +SideLength, +SideLength );
                Vector3d C3 = Center + new Vector3d( -SideLength, +SideLength, +SideLength );

                Vector3d C4 = Center + new Vector3d( -SideLength, -SideLength, -SideLength );
                Vector3d C5 = Center + new Vector3d( +SideLength, -SideLength, -SideLength );
                Vector3d C6 = Center + new Vector3d( +SideLength, +SideLength, -SideLength );
                Vector3d C7 = Center + new Vector3d( -SideLength, +SideLength, -SideLength );

                Vector3d P0, P1, P2, P3, P4, P5, P6, P7;

                switch ( side )
                {
                case eSides.Front:
                    P0 = C0;
                    P1 = C1;
                    P2 = C2;
                    P3 = C3;

                    P4 = C4;
                    P5 = C5;
                    P6 = C6;
                    P7 = C7;
                    break;
                case eSides.Back:
                    P0 = C5;
                    P1 = C4;
                    P2 = C7;
                    P3 = C6;

                    P4 = C1;
                    P5 = C0;
                    P6 = C3;
                    P7 = C2;
                    break;
                case eSides.Right:
                    P0 = C1;
                    P1 = C5;
                    P2 = C6;
                    P3 = C2;

                    P4 = C0;
                    P5 = C4;
                    P6 = C7;
                    P7 = C3;
                    break;
                case eSides.Left:
                    P0 = C4;
                    P1 = C0;
                    P2 = C3;
                    P3 = C7;

                    P4 = C5;
                    P5 = C1;
                    P6 = C2;
                    P7 = C6;
                    break;
                case eSides.Top:
                    P0 = C3;
                    P1 = C2;
                    P2 = C6;
                    P3 = C7;

                    P4 = C0;
                    P5 = C1;
                    P6 = C5;
                    P7 = C4;
                    break;
                case eSides.Bottom:
                    P0 = C1;
                    P1 = C0;
                    P2 = C4;
                    P3 = C5;

                    P4 = C2;
                    P5 = C3;
                    P6 = C7;
                    P7 = C6;
                    break;
                default:
                    throw new NotImplementedException( "Unknown enum value: " + side );
                }

                #endregion Setup constants for current direction

                #region Set Normal

                Vector3d FaceNormal;

                switch ( side )
                {
                case eSides.Front:
                    FaceNormal = Vector3d.UnitZ;
                    break;
                case eSides.Back:
                    FaceNormal = -Vector3d.UnitZ;
                    break;
                case eSides.Right:
                    FaceNormal = Vector3d.UnitX;
                    break;
                case eSides.Left:
                    FaceNormal = -Vector3d.UnitX;
                    break;
                case eSides.Top:
                    FaceNormal = Vector3d.UnitY;
                    break;
                case eSides.Bottom:
                    FaceNormal = -Vector3d.UnitY;
                    break;
                default:
                    throw new NotImplementedException( "Unknown enum value: " + side );
                }
                #endregion Set Normal

                bool FaceIsVisible = false;
                foreach ( eSides s in VisibleSides )
                {
                    if ( s == side )
                    {
                        FaceIsVisible = true;
                        break;
                    }
                }

                if ( FaceIsVisible )
                {
                    #region Define Layer1 Vertices
                    Chunk Layer1 = new Chunk( 8, 8 * 3 );

                    Layer1.Vertices[0].TexCoord = new Vector2d( _Zero, _Zero );
                    Layer1.Vertices[0].Normal = FaceNormal;
                    Layer1.Vertices[0].Position = P0;

                    Layer1.Vertices[1].TexCoord = new Vector2d( _One, _Zero );
                    Layer1.Vertices[1].Normal = FaceNormal;
                    Layer1.Vertices[1].Position = P1;

                    Layer1.Vertices[2].TexCoord = new Vector2d( _One, _One );
                    Layer1.Vertices[2].Normal = FaceNormal;
                    Layer1.Vertices[2].Position = P2;

                    Layer1.Vertices[3].TexCoord = new Vector2d( _Zero, _One );
                    Layer1.Vertices[3].Normal = FaceNormal;
                    Layer1.Vertices[3].Position = P3;

                    Layer1.Vertices[4].TexCoord = new Vector2d( _Three, _Three );
                    Layer1.Vertices[4].Normal = FaceNormal;
                    Vector3d.Lerp( ref P0, ref P2, _Three, out Layer1.Vertices[4].Position );

                    Layer1.Vertices[5].TexCoord = new Vector2d( _Six, _Three );
                    Layer1.Vertices[5].Normal = FaceNormal;
                    Vector3d.Lerp( ref P1, ref P3, _Three, out Layer1.Vertices[5].Position );

                    Layer1.Vertices[6].TexCoord = new Vector2d( _Six, _Six );
                    Layer1.Vertices[6].Normal = FaceNormal;
                    Vector3d.Lerp( ref P0, ref P2, _Six, out Layer1.Vertices[6].Position );

                    Layer1.Vertices[7].TexCoord = new Vector2d( _Three, _Six );
                    Layer1.Vertices[7].Normal = FaceNormal;
                    Vector3d.Lerp( ref P1, ref P3, _Six, out Layer1.Vertices[7].Position );
                    #endregion Define Layer1 Vertices

                    #region Define Layer1 Indices
                    Layer1.Indices[0] = 0;
                    Layer1.Indices[1] = 5;
                    Layer1.Indices[2] = 4;

                    Layer1.Indices[3] = 0;
                    Layer1.Indices[4] = 1;
                    Layer1.Indices[5] = 5;

                    Layer1.Indices[6] = 5;
                    Layer1.Indices[7] = 1;
                    Layer1.Indices[8] = 2;

                    Layer1.Indices[9] = 6;
                    Layer1.Indices[10] = 5;
                    Layer1.Indices[11] = 2;

                    Layer1.Indices[12] = 7;
                    Layer1.Indices[13] = 6;
                    Layer1.Indices[14] = 2;

                    Layer1.Indices[15] = 3;
                    Layer1.Indices[16] = 7;
                    Layer1.Indices[17] = 2;

                    Layer1.Indices[18] = 0;
                    Layer1.Indices[19] = 7;
                    Layer1.Indices[20] = 3;

                    Layer1.Indices[21] = 0;
                    Layer1.Indices[22] = 4;
                    Layer1.Indices[23] = 7;

                    chunks.Add( Layer1 );
                    #endregion Define Layer1 Indices
                }

                #region Define Layer2 Vertices
                Chunk Layer2 = new Chunk( 12, 8 * 3 );

                Vector3d T0, T1, T2, T3;
                Vector3d.Lerp( ref P0, ref P4, _Six, out T0 );
                Vector3d.Lerp( ref P1, ref P5, _Six, out T1 );
                Vector3d.Lerp( ref P2, ref P6, _Six, out T2 );
                Vector3d.Lerp( ref P3, ref P7, _Six, out T3 );

                Layer2.Vertices[0].TexCoord = new Vector2d( _Three, _Zero );
                Layer2.Vertices[0].Normal = FaceNormal;
                Vector3d.Lerp( ref T0, ref T1, _Three, out Layer2.Vertices[0].Position );

                Layer2.Vertices[1].TexCoord = new Vector2d( _Six, _Zero );
                Layer2.Vertices[1].Normal = FaceNormal;
                Vector3d.Lerp( ref T0, ref T1, _Six, out Layer2.Vertices[1].Position );

                Layer2.Vertices[3].TexCoord = new Vector2d( _One, _Three );
                Layer2.Vertices[3].Normal = FaceNormal;
                Vector3d.Lerp( ref T1, ref  T2, _Three, out Layer2.Vertices[3].Position );

                Layer2.Vertices[4].TexCoord = new Vector2d( _One, _Six );
                Layer2.Vertices[4].Normal = FaceNormal;
                Vector3d.Lerp( ref T1, ref  T2, _Six, out Layer2.Vertices[4].Position );

                Layer2.Vertices[6].TexCoord = new Vector2d( _Six, _One );
                Layer2.Vertices[6].Normal = FaceNormal;
                Vector3d.Lerp( ref T2, ref T3, _Three, out Layer2.Vertices[6].Position );

                Layer2.Vertices[7].TexCoord = new Vector2d( _Three, _One );
                Layer2.Vertices[7].Normal = FaceNormal;
                Vector3d.Lerp( ref T2, ref  T3, _Six, out Layer2.Vertices[7].Position );

                Layer2.Vertices[9].TexCoord = new Vector2d( _Zero, _Six );
                Layer2.Vertices[9].Normal = FaceNormal;
                Vector3d.Lerp( ref T3, ref  T0, _Three, out Layer2.Vertices[9].Position );

                Layer2.Vertices[10].TexCoord = new Vector2d( _Zero, _Three );
                Layer2.Vertices[10].Normal = FaceNormal;
                Vector3d.Lerp( ref  T3, ref  T0, _Six, out Layer2.Vertices[10].Position );

                Layer2.Vertices[2].TexCoord = new Vector2d( _Six, _Three );
                Layer2.Vertices[2].Normal = FaceNormal;
                Vector3d.Lerp( ref Layer2.Vertices[1].Position, ref Layer2.Vertices[6].Position, _Three, out Layer2.Vertices[2].Position );

                Layer2.Vertices[5].TexCoord = new Vector2d( _Six, _Six );
                Layer2.Vertices[5].Normal = FaceNormal;
                Vector3d.Lerp( ref Layer2.Vertices[1].Position, ref Layer2.Vertices[6].Position, _Six, out Layer2.Vertices[5].Position );

                Layer2.Vertices[8].TexCoord = new Vector2d( _Three, _Six );
                Layer2.Vertices[8].Normal = FaceNormal;
                Vector3d.Lerp( ref Layer2.Vertices[7].Position, ref Layer2.Vertices[0].Position, _Three, out Layer2.Vertices[8].Position );

                Layer2.Vertices[11].TexCoord = new Vector2d( _Three, _Three );
                Layer2.Vertices[11].Normal = FaceNormal;
                Vector3d.Lerp( ref Layer2.Vertices[7].Position, ref Layer2.Vertices[0].Position, _Six, out Layer2.Vertices[11].Position );
                #endregion Define Layer2 Vertices

                #region Define Layer2 Indices
                Layer2.Indices[0] = 0;
                Layer2.Indices[1] = 2;
                Layer2.Indices[2] = 11;

                Layer2.Indices[3] = 0;
                Layer2.Indices[4] = 1;
                Layer2.Indices[5] = 2;

                Layer2.Indices[6] = 2;
                Layer2.Indices[7] = 3;
                Layer2.Indices[8] = 4;

                Layer2.Indices[9] = 2;
                Layer2.Indices[10] = 4;
                Layer2.Indices[11] = 5;

                Layer2.Indices[12] = 5;
                Layer2.Indices[13] = 6;
                Layer2.Indices[14] = 8;

                Layer2.Indices[15] = 8;
                Layer2.Indices[16] = 6;
                Layer2.Indices[17] = 7;

                Layer2.Indices[18] = 11;
                Layer2.Indices[19] = 8;
                Layer2.Indices[20] = 10;

                Layer2.Indices[21] = 10;
                Layer2.Indices[22] = 8;
                Layer2.Indices[23] = 9;

                chunks.Add( Layer2 );
                #endregion Define Layer2 Indices
            }
        }
    }

   
}
