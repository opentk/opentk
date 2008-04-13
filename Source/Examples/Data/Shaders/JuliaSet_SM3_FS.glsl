#version 120
// www.OpenTK.net GLSL Julia Set (c) 2008 Christoph Brandtner

uniform sampler1D COLORTABLE;
uniform float CETX;
uniform float CETY;
uniform float SCALINGX;
uniform float SCALINGY;
uniform float OFFSETX;
uniform float OFFSETY;

const int MAXIterations = 32; // *must* be > 0

void main(void)
{
  float XPos = gl_FragCoord.x / SCALINGX - OFFSETX;
  float YPos = gl_FragCoord.y / SCALINGY - OFFSETY;
  float XQuad = pow( XPos, 2.0 );
  float YQuad = pow( YPos, 2.0 );
  int TableIndex = -1;
  int LoopCount = 0;
  while ( LoopCount <= MAXIterations )
    {
      YPos = 2.0 * XPos * YPos + CETY;
      XPos = XQuad - YQuad + CETX;
      XQuad = pow( XPos, 2.0 );
      YQuad = pow( YPos, 2.0 );
      TableIndex++;
      if ( (XQuad + YQuad) > 4.0 )
      { 
         if (TableIndex == 0)
           discard;
         LoopCount = MAXIterations;
      }
      LoopCount++;
    }
  float FinalTableIndex = float( TableIndex ) / float( MAXIterations );

  gl_FragColor = texture1D( COLORTABLE, FinalTableIndex ); // lookup texture for output
  // gl_FragColor.rgb = vec3( FinalTableIndex ); // Debug: output greyscale
}