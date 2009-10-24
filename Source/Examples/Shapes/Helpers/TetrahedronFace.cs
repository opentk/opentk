using System;

using OpenTK;

namespace Examples.Shapes
{

    /// <summary>winding always assumed CCW (Counter-ClockWise)</summary>
    internal struct TetrahedronFace
    {
        private Vector3d APosition, BPosition, CPosition;
        private Vector3d DPosition, Normal;
        private Vector2d ATexCoord, BTexCoord, CTexCoord;

        public TetrahedronFace( ref Vector3d apos, ref Vector2d atc,
                                   ref Vector3d bpos, ref Vector2d btc,
                                   ref Vector3d cpos, ref Vector2d ctc,
                                   ref Vector3d dpos,
                                   ref Vector3d normal )
        {
            APosition = apos; ATexCoord = atc;
            BPosition = bpos; BTexCoord = btc;
            CPosition = cpos; CTexCoord = ctc;
            DPosition = dpos;
            Normal = normal;
        }

        /// <summary>Expects CCW triangle order as input, emits 4 new CCW triangles.</summary>
        /// <param name="first">1st output Triangle</param>
        /// <param name="second">2nd output Triangle</param>
        /// <param name="third">3rd output Triangle</param>
        /// <param name="fourth">4th output Triangle</param>
        public void SubdivideSierpinski( out TetrahedronFace first, out TetrahedronFace second, out TetrahedronFace third, out TetrahedronFace fourth )
        {
            Vector3d temp;

            // find the 3 points AB, BC, CA 
            Vector3d CenterAB;
            Vector3d.Add( ref this.APosition, ref this.BPosition, out temp );
            Vector3d.Mult( ref temp, 0.5f, out CenterAB );

            Vector3d CenterBC;
            Vector3d.Add( ref this.BPosition, ref this.CPosition, out temp );
            Vector3d.Mult( ref temp, 0.5f, out CenterBC );

            Vector3d CenterCA;
            Vector3d.Add( ref this.CPosition, ref this.APosition, out temp );
            Vector3d.Mult( ref temp, 0.5f, out CenterCA );

            // find the 3 points AD, BD, CD 
            Vector3d CenterAD;
            Vector3d.Lerp( ref this.APosition, ref this.DPosition, 0.5, out CenterAD );

            Vector3d CenterBD;
            Vector3d.Lerp( ref this.BPosition, ref this.DPosition, 0.5, out CenterBD );

            Vector3d CenterCD;
            Vector3d.Lerp( ref this.CPosition, ref this.DPosition, 0.5, out CenterCD );

            // emit 4 new CCW triangles
            first = new TetrahedronFace( ref this.APosition, ref this.ATexCoord,
                              ref CenterAB, ref this.BTexCoord,
                              ref CenterCA, ref this.CTexCoord,
                              ref CenterAD,
                              ref this.Normal );

            second = new TetrahedronFace( ref CenterAB, ref this.ATexCoord,
                               ref this.BPosition, ref this.BTexCoord,
                               ref CenterBC, ref this.CTexCoord,
                               ref CenterBD,
                               ref this.Normal );

            third = new TetrahedronFace( ref CenterCA, ref this.ATexCoord,
                              ref CenterBC, ref this.BTexCoord,
                              ref this.CPosition, ref this.CTexCoord,
                              ref CenterCD,
                              ref this.Normal );

            fourth = new TetrahedronFace( ref CenterAD, ref this.ATexCoord,
                               ref CenterBD, ref this.BTexCoord,
                               ref CenterCD, ref this.CTexCoord,
                               ref this.DPosition,
                               ref this.Normal );
        }


        internal void SubdivideKoch( double height, out TetrahedronFace first, out TetrahedronFace second, out TetrahedronFace third, out TetrahedronFace fourth, out TetrahedronFace fifth, out TetrahedronFace sixth )
        {
            Vector3d CenterAB, CenterBC, CenterCA, CenterD;
            Vector2d TexCoordAB, TexCoordBC, TexCoordCA, TexCoordD;

            Vector3d.Lerp( ref this.APosition, ref this.BPosition, 0.5, out CenterAB );
            Vector3d.Lerp( ref this.BPosition, ref this.CPosition, 0.5, out CenterBC );
            Vector3d.Lerp( ref this.CPosition, ref this.APosition, 0.5, out CenterCA );
            CenterD = CenterAB;
            CenterD.Add( ref CenterBC );
            CenterD.Add( ref CenterCA );
            CenterD.Div( 3.0 );
            Vector3d E = CenterD + ( this.Normal * 0.5 );
            Vector3d temp = this.Normal;
            temp.Mult( height );
            CenterD.Add( temp );

            Vector2d.Lerp( ref this.ATexCoord, ref this.BTexCoord, 0.5, out TexCoordAB );
            Vector2d.Lerp( ref this.BTexCoord, ref this.CTexCoord, 0.5, out TexCoordBC );
            Vector2d.Lerp( ref this.CTexCoord, ref this.ATexCoord, 0.5, out TexCoordCA );
            TexCoordD = TexCoordAB;
            TexCoordD.Add( ref TexCoordBC );
            TexCoordD.Add( ref TexCoordCA );
            TexCoordD.Div( 3.0 );
            #region 1
            first.APosition = this.APosition;
            first.ATexCoord = this.ATexCoord;

            first.BPosition = CenterAB;
            first.BTexCoord = TexCoordAB;

            first.CPosition = CenterCA;
            first.CTexCoord = TexCoordCA;

            first.Normal = this.Normal;
            temp = ( this.APosition + CenterAB + CenterCA );
            temp.Div( 3.0 );
            temp.Add( this.Normal * -1.0 );
            first.DPosition = temp;
            #endregion 1
            #region 2
            second.APosition = CenterAB;
            second.ATexCoord = TexCoordAB;

            second.BPosition = this.BPosition;
            second.BTexCoord = this.BTexCoord;

            second.CPosition = CenterBC;
            second.CTexCoord = TexCoordBC;

            second.Normal = this.Normal;

            temp = CenterAB + this.BPosition + CenterBC;
            temp.Div( 3.0 );
            temp.Add( this.Normal * -1.0 );
            second.DPosition = temp;

            #endregion 2
            #region 3
            third.APosition = CenterBC;
            third.ATexCoord = TexCoordBC;

            third.BPosition = this.CPosition;
            third.BTexCoord = this.CTexCoord;

            third.CPosition = CenterCA;
            third.CTexCoord = TexCoordCA;

            third.Normal = this.Normal;
            temp = CenterBC + this.CPosition + CenterCA;
            temp.Div( 3.0 );
            temp.Add( this.Normal * -1.0 );
            third.DPosition = temp;
            #endregion 3
            #region 4
            fourth.APosition = CenterAB;
            fourth.ATexCoord = TexCoordAB;

            fourth.BPosition = CenterD;
            fourth.BTexCoord = TexCoordD;

            fourth.CPosition = CenterCA;
            fourth.CTexCoord = TexCoordCA;

            SierpinskiTetrahedron.FindNormal( ref CenterAB, ref CenterD, ref CenterCA, out fourth.Normal );
            fourth.DPosition = E;
            #endregion 4
            #region 5
            fifth.APosition = CenterAB;
            fifth.ATexCoord = TexCoordAB;

            fifth.BPosition = CenterBC;
            fifth.BTexCoord = TexCoordBC;

            fifth.CPosition = CenterD;
            fifth.CTexCoord = TexCoordD;

            SierpinskiTetrahedron.FindNormal( ref CenterAB, ref CenterBC, ref CenterD, out fifth.Normal );
            fifth.DPosition = E;

            #endregion 5
            #region 6
            sixth.APosition = CenterBC;
            sixth.ATexCoord = TexCoordBC;

            sixth.BPosition = CenterCA;
            sixth.BTexCoord = TexCoordCA;

            sixth.CPosition = CenterD;
            sixth.CTexCoord = TexCoordD;

            SierpinskiTetrahedron.FindNormal( ref CenterBC, ref CenterCA, ref CenterD, out sixth.Normal );
            sixth.DPosition = E;
            #endregion 6
        }

        /// <summary>Returns 3 Vertices which form a CCW triangle.</summary>
        public void GetVertices( out VertexT2dN3dV3d first, out VertexT2dN3dV3d second, out VertexT2dN3dV3d third )
        {
            first.TexCoord = this.ATexCoord;
            first.Normal = this.Normal;
            first.Position = this.APosition;

            second.TexCoord = this.BTexCoord;
            second.Normal = this.Normal;
            second.Position = this.BPosition;

            third.TexCoord = this.CTexCoord;
            third.Normal = this.Normal;
            third.Position = this.CPosition;
        }

        /// <summary>Debugging Aid, no real purpose</summary>
        public override string ToString()
        {
            return "A= " + this.APosition.ToString() + " TexCoord: " + this.ATexCoord.ToString() + "\n" +
                   "B= " + this.BPosition.ToString() + " TexCoord: " + this.ATexCoord.ToString() + "\n" +
                   "C= " + this.CPosition.ToString() + " TexCoord: " + this.ATexCoord.ToString() + "\n" +
                   "Normal= " + this.Normal.ToString();
        }
    }


}
