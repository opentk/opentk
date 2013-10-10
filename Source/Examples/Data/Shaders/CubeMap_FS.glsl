// Copyright (c) 2008 the OpenTK Team. See license.txt for legal bla

uniform samplerCube Earth;
varying vec3 Normal;

void main()
{ 
  gl_FragColor = textureCube( Earth, Normal.xyz ); 
}