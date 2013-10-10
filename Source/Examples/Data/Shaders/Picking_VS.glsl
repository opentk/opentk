#version 120

flat varying vec4 vColor; // must be flat, cannot have this interpolated in any way

void main(void)
{
  vColor = gl_Color;
  gl_Position = gl_ModelViewProjectionMatrix * gl_Vertex; // ftransform();
}