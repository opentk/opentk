// Copyright (c) 2008 the OpenTK Team. See license.txt for legal bla

// MUST be written to for FS
varying vec3 Normal;

void main()
{
  gl_Position = ftransform();
  Normal = /*gl_NormalMatrix * */ gl_Normal ;
}