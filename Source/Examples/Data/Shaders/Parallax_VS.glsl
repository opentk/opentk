// Copyright (c) 2008 the OpenTK Team. See license.txt for legal bla

// custom vertex attribute
attribute vec3 AttributeTangent; 

// world uniforms
uniform vec3 Light_Position;
uniform vec3 Camera_Position;

// MUST be written to for FS
varying vec3 VaryingLightVector; 
varying vec3 VaryingEyeVector;

void main()
{
  gl_Position = ftransform();
  gl_TexCoord[0] = gl_TextureMatrix[0] * gl_MultiTexCoord0;

  vec3 nor = normalize( gl_NormalMatrix * gl_Normal );
  vec3 tan = normalize( gl_NormalMatrix * AttributeTangent );
  vec3 bi = cross(nor, tan);
  
  // need positions in tangent space
  vec3 vertex = vec3( gl_ModelViewMatrix * gl_Vertex );

  vec3 temp = Light_Position - vertex;
  VaryingLightVector.x = dot(temp, tan); // optimization, calculate dot products rather than building TBN matrix
  VaryingLightVector.y = dot(temp, bi);
  VaryingLightVector.z = dot(temp, nor);

  temp = Camera_Position - vertex;
  VaryingEyeVector.x = dot(temp, tan);
  VaryingEyeVector.y = dot(temp, bi);
  VaryingEyeVector.z = dot(temp, nor);
}