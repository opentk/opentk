// Copyright (c) 2008 the OpenTK Team. See license.txt for legal bla

// Material uniforms
uniform sampler2D Material_DiffuseAndHeight;
uniform sampler2D Material_NormalAndGloss;
uniform vec3 Material_ScaleBiasShininess; // x=Scale, y=Bias, z=Shininess

// Light uniforms
uniform vec3 Light_DiffuseColor;
uniform vec3 Light_SpecularColor;

// from VS
varying vec3 VaryingLightVector;
varying vec3 VaryingEyeVector;

vec3 normal;

void main()
{ 
  vec3 lightVector = normalize( VaryingLightVector );
  vec3 eyeVector = normalize( VaryingEyeVector );

  // first, find the parallax displacement by reading only the height map
  float parallaxOffset = texture2D( Material_DiffuseAndHeight, gl_TexCoord[0].st ).a *
                         Material_ScaleBiasShininess.x - Material_ScaleBiasShininess.y;
  vec2 newTexCoords = gl_TexCoord[0].st + ( parallaxOffset * eyeVector.xy ); // displace texcoords according to viewer

  // knowing the displacement, read RGB, Normal and Gloss
  vec3 diffuseColor = texture2D( Material_DiffuseAndHeight, newTexCoords.st ).rgb;
  vec4 temp = texture2D( Material_NormalAndGloss, newTexCoords.st );
  
  // build a usable normal vector
  normal.xy = temp.ag * 2.0 - 1.0; // swizzle alpha and green to x/y and scale to [-1..+1]
  normal.z = sqrt( 1.0 - normal.x*normal.x - normal.y*normal.y ); // z = sqrt(1-x²-y²)
  
  // move other properties to be better readable
  float gloss = temp.r;
  
//  float alpha = temp.b;
//  if ( alpha < 0.2 ) // optimization: should move this test before reading RGB texture
//    discard;
  
  // tweaked phong lighting
  float lambert = max( dot( lightVector, normal ), 0.0 );

  gl_FragColor = vec4( Light_DiffuseColor * diffuseColor, 1.0 ) * 
                 lambert;

  if ( lambert > 0.0 )
  {
    float specular = pow(
                         clamp( dot( reflect( -lightVector, normal ), eyeVector ), 0.0, 1.0 ), 
                         Material_ScaleBiasShininess.z );

    gl_FragColor += vec4( Light_SpecularColor * diffuseColor, 1.0 ) * ( specular * gloss );
  }
}