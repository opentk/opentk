#version 110
// www.OpenTK.net GLSL Julia Set (c) 2008 Christoph Brandtner

// uniforms from OpenGL
uniform sampler1D COLORTABLE;
uniform float CETX;
uniform float CETY;
uniform float SCALINGX;
uniform float SCALINGY;
uniform float OFFSETX;
uniform float OFFSETY;

// GLSL internal variables. 
const int MAXIterations = 16; // must be greater than zero, 16 is a good blend between detail and speed
float XPos;
float YPos;
float XQuad;
float YQuad; // half precision floating point could be used on those 4 floats for speed, but will throw a warning.
int TableIndex;
int LoopCount;

// this function reduces duplicate code
void Iterate(void)
{
  YPos = 2.0 * XPos * YPos + CETY;
  XPos = XQuad - YQuad + CETX;
  XQuad = pow(XPos, 2.0);
  YQuad = pow(YPos, 2.0);
  TableIndex++;
  if ( (XQuad + YQuad) > 4.0 ) LoopCount = MAXIterations; // skip further iterations for this Pixel
  LoopCount++;
}

// Shader entry point, this is executed per Pixel
void main(void)
{
  XPos = gl_FragCoord.x / SCALINGX - OFFSETX;
  YPos = gl_FragCoord.y / SCALINGY - OFFSETY;
  XQuad = pow(XPos, 2.0);
  YQuad = pow(YPos, 2.0);
  TableIndex = -1;
  LoopCount = 0;
  // the loop is unrolled for SM 2.0 compatibility
  if ( LoopCount <= MAXIterations ) Iterate(); // TableIndex==0
  if ( LoopCount > 1 ) discard; // attempt to early-out, will affect ~1/3 of all Pixels
  if ( LoopCount <= MAXIterations ) Iterate(); 
  if ( LoopCount <= MAXIterations ) Iterate(); 
  if ( LoopCount <= MAXIterations ) Iterate(); 
  if ( LoopCount <= MAXIterations ) Iterate(); 
  if ( LoopCount <= MAXIterations ) Iterate(); 
  if ( LoopCount <= MAXIterations ) Iterate(); 
  if ( LoopCount <= MAXIterations ) Iterate(); 
  if ( LoopCount <= MAXIterations ) Iterate(); 
  if ( LoopCount <= MAXIterations ) Iterate(); 
  if ( LoopCount <= MAXIterations ) Iterate(); 
  if ( LoopCount <= MAXIterations ) Iterate(); 
  if ( LoopCount <= MAXIterations ) Iterate(); 
  if ( LoopCount <= MAXIterations ) Iterate(); 
  if ( LoopCount <= MAXIterations ) Iterate(); 
  if ( LoopCount <= MAXIterations ) Iterate(); 
  if ( LoopCount <= MAXIterations ) Iterate(); // TableIndex==16
  float FinalTableIndex = float( TableIndex ) / float( MAXIterations );
 
  gl_FragColor = texture1D( COLORTABLE, FinalTableIndex ); // lookup texture for output
// gl_FragColor.rgb = vec3(FinalTableIndex); // Debug: output greyscale
}