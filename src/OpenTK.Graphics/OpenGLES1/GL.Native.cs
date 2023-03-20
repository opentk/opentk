// This file is auto generated, do not edit.
using System;
using System.Runtime.InteropServices;
using OpenTK.Graphics;

namespace OpenTK.Graphics.OpenGLES1
{
    public static unsafe partial class GL
    {
        /// <summary> <b>[requires: v1.0] [glAlphaFunc]</b> Specify the alpha test function. </summary>
        /// <param name="func">Specifies the alpha comparison function. Symbolic constants GL_NEVER, GL_LESS, GL_EQUAL, GL_LEQUAL, GL_GREATER, GL_NOTEQUAL, GL_GEQUAL, and GL_ALWAYS are accepted. The initial value is GL_ALWAYS. </param>
        /// <param name="reference">Specifies the reference value that incoming alpha values are compared to. This value is clamped to the range [0, 1], where 0 represents the lowest possible alpha value and 1 the highest possible value. The initial reference value is 0. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glAlphaFunc.xml" /></remarks>
        public static void AlphaFunc(AlphaFunction func, float reference) => GLPointers._glAlphaFunc_fnptr((uint)func, reference);
        
        /// <summary> <b>[requires: v1.0] [glClearColor]</b> Specify clear values for the color buffer. </summary>
        /// <param name="red">Specify the red, green, blue, and alpha values used when the color buffer is cleared. The initial values are all 0.</param>
        /// <param name="green">Specify the red, green, blue, and alpha values used when the color buffer is cleared. The initial values are all 0.</param>
        /// <param name="blue">Specify the red, green, blue, and alpha values used when the color buffer is cleared. The initial values are all 0.</param>
        /// <param name="alpha">Specify the red, green, blue, and alpha values used when the color buffer is cleared. The initial values are all 0.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glClearColor.xml" /></remarks>
        public static void ClearColor(float red, float green, float blue, float alpha) => GLPointers._glClearColor_fnptr(red, green, blue, alpha);
        
        /// <summary> <b>[requires: v1.0] [glClearDepthf]</b> Specify the clear value for the depth buffer. </summary>
        /// <param name="depth">Specifies the depth value used when the depth buffer is cleared. The initial value is 1.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glClearDepth.xml" /></remarks>
        public static void ClearDepthf(float d) => GLPointers._glClearDepthf_fnptr(d);
        
        /// <summary> <b>[requires: v1.0] [glClipPlanef]</b> Specify a plane against which all geometry is    clipped. </summary>
        /// <param name="plane">Specifies which clipping plane is being positioned. Symbolic names of the form GL_CLIP_PLANEi, where i is an integer between 0 and GL_MAX_CLIP_PLANES -1 , are accepted.</param>
        /// <param name="equation">Specifies the address of an array of four fixed-point or floating-point values. These are the coefficients of a plane equation in object coordinates: p1, p2, p3, and p4, in that order.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glClipPlane.xml" /></remarks>
        public static void ClipPlanef(ClipPlaneName p, float* eqn) => GLPointers._glClipPlanef_fnptr((uint)p, eqn);
        
        /// <summary> <b>[requires: v1.0] [glColor4f]</b> Set the current color. </summary>
        /// <param name="red">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <param name="green">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <param name="blue">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <param name="alpha">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glColor.xml" /></remarks>
        public static void Color4f(float red, float green, float blue, float alpha) => GLPointers._glColor4f_fnptr(red, green, blue, alpha);
        
        /// <summary> <b>[requires: v1.0] [glDepthRangef]</b> Specify mapping of depth values from normalized        device coordinates to window coordinates. </summary>
        /// <param name="near">Specifies the mapping of the near clipping plane to window coordinates. The initial value is 0.</param>
        /// <param name="far">Specifies the mapping of the far clipping plane to window coordinates. The initial value is 1.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glDepthRange.xml" /></remarks>
        public static void DepthRangef(float n, float f) => GLPointers._glDepthRangef_fnptr(n, f);
        
        /// <summary> <b>[requires: v1.0] [glFogf]</b> Specify fog parameters. </summary>
        /// <param name="pname">Specifies a single-valued fog parameter. GL_FOG_MODE, GL_FOG_DENSITY, GL_FOG_START, and GL_FOG_END are accepted.</param>
        /// <param name="param">Specifies the value that pname will be set to.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glFog.xml" /></remarks>
        public static void Fogf(FogParameter pname, float param) => GLPointers._glFogf_fnptr((uint)pname, param);
        
        /// <summary> <b>[requires: v1.0] [glFogfv]</b>  </summary>
        public static void Fogfv(FogParameter pname, float* parameters) => GLPointers._glFogfv_fnptr((uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0] [glFrustumf]</b> Multiply the current matrix by a perspective matrix. </summary>
        /// <param name="left">Specify the coordinates for the left and right vertical clipping planes.</param>
        /// <param name="right">Specify the coordinates for the left and right vertical clipping planes.</param>
        /// <param name="bottom">Specify the coordinates for the bottom and top horizontal clipping planes.</param>
        /// <param name="top">Specify the coordinates for the bottom and top horizontal clipping planes.</param>
        /// <param name="near">Specify the distances to the near and far depth clipping planes. Both distances must be positive.</param>
        /// <param name="far">Specify the distances to the near and far depth clipping planes. Both distances must be positive.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glFrustum.xml" /></remarks>
        public static void Frustumf(float l, float r, float b, float t, float n, float f) => GLPointers._glFrustumf_fnptr(l, r, b, t, n, f);
        
        /// <summary> <b>[requires: v1.0] [glGetClipPlanef]</b> Return the coefficients of the specified clipping    plane. </summary>
        /// <param name="plane">Specifies a clipping plane. The number of clipping planes depends on the implementation, but at least six clipping planes are supported. Symbolic names of the form GL_CLIP_PLANE i, where i is an integer between 0 and GL_MAX_CLIP_PLANES -1 , are accepted.</param>
        /// <param name="equation">Returns four fixed-point or floating-point values that are the coefficients of the plane equation of plane in eye coordinates in the order p1, p2, p3, and p4. The initial value is (0, 0, 0, 0).</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetClipPlane.xml" /></remarks>
        public static void GetClipPlanef(ClipPlaneName plane, float* equation) => GLPointers._glGetClipPlanef_fnptr((uint)plane, equation);
        
        /// <summary> <b>[requires: v1.0] [glGetFloatv]</b> Return the value or values of a selected parameter. </summary>
        /// <param name="pname">Specifies the parameter value to be returned. The symbolic constants in the list below are accepted.</param>
        /// <param name="parameters">Returns the value or values of the specified parameter.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGet.xml" /></remarks>
        public static void GetFloatv(GetPName pname, float* data) => GLPointers._glGetFloatv_fnptr((uint)pname, data);
        
        /// <summary> <b>[requires: v1.0] [glGetLightfv]</b> Return light source parameter values. </summary>
        /// <param name="light"> Specifies a light source. The number of possible lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form GL_LIGHTi where 0&lt;i&lt; GL_MAX_LIGHTS </param>
        /// <param name="pname"> Specifies a light source parameter for light. Accepted symbolic names are GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_POSITION, GL_SPOT_DIRECTION, GL_SPOT_EXPONENT, GL_SPOT_CUTOFF, GL_CONSTANT_ATTENUATION, GL_LINEAR_ATTENUATION, and GL_QUADRATIC_ATTENUATION. </param>
        /// <param name="parameters"> Returns the requested data. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetLight.xml" /></remarks>
        public static void GetLightfv(LightName light, LightParameter pname, float* parameters) => GLPointers._glGetLightfv_fnptr((uint)light, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0] [glGetMaterialfv]</b> Return material parameters values. </summary>
        /// <param name="face"> Specifies which of the two materials is being queried. GL_FRONT or GL_BACK are accepted, representing the front and back materials, respectively. </param>
        /// <param name="pname"> Specifies the material parameter to return. Accepted symbolic names are GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_EMISSION, and GL_SHININESS. </param>
        /// <param name="parameters"> Returns the requested data. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetMaterial.xml" /></remarks>
        public static void GetMaterialfv(TriangleFace face, MaterialParameter pname, float* parameters) => GLPointers._glGetMaterialfv_fnptr((uint)face, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0] [glGetTexEnvfv]</b> Return texture environment parameters. </summary>
        /// <param name="target"> Specifies a texture environment. May be GL_TEXTURE_ENV or GL_POINT_SPRITE_OES. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture environment parameter. Accepted values are GL_TEXTURE_ENV_MODE, GL_TEXTURE_ENV_COLOR, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE_OES. </param>
        /// <param name="parameters"> Returns the requested data. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetTexEnv.xml" /></remarks>
        public static void GetTexEnvfv(TextureEnvTarget target, TextureEnvParameter pname, float* parameters) => GLPointers._glGetTexEnvfv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0] [glGetTexParameterfv]</b> Return texture parameter values. </summary>
        /// <param name="target">Specifies the target texture, which must be GL_TEXTURE_2D.</param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. Which can be one of the following: GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_GENERATE_MIPMAP. </param>
        /// <param name="parameters">Returns texture parameters.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetTexParameter.xml" /></remarks>
        public static void GetTexParameterfv(TextureTarget target, GetTextureParameter pname, float* parameters) => GLPointers._glGetTexParameterfv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0] [glLightModelf]</b> Set the lighting model parameters. </summary>
        /// <param name="pname">Specifies a single-valued lighting model parameter. Must be GL_LIGHT_MODEL_TWO_SIDE.</param>
        /// <param name="param">Specifies the value that param will be set to.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glLightModel.xml" /></remarks>
        public static void LightModelf(LightModelParameter pname, float param) => GLPointers._glLightModelf_fnptr((uint)pname, param);
        
        /// <summary> <b>[requires: v1.0] [glLightModelfv]</b>  </summary>
        public static void LightModelfv(LightModelParameter pname, float* parameters) => GLPointers._glLightModelfv_fnptr((uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0] [glLightf]</b> Set light source parameters. </summary>
        /// <param name="light">Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form GL_LIGHTi where 0 &lt;= i &lt; GL_MAX_LIGHTS . </param>
        /// <param name="pname">Specifies a single-valued light source parameter for light. GL_SPOT_EXPONENT, GL_SPOT_CUTOFF, GL_CONSTANT_ATTENUATION, GL_LINEAR_ATTENUATION, and GL_QUADRATIC_ATTENUATION are accepted.</param>
        /// <param name="param">Specifies the value that parameter pname of light source light will be set to.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glLight.xml" /></remarks>
        public static void Lightf(LightName light, LightParameter pname, float param) => GLPointers._glLightf_fnptr((uint)light, (uint)pname, param);
        
        /// <summary> <b>[requires: v1.0] [glLightfv]</b>  </summary>
        public static void Lightfv(LightName light, LightParameter pname, float* parameters) => GLPointers._glLightfv_fnptr((uint)light, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0] [glLineWidth]</b> Specify the width of rasterized lines. </summary>
        /// <param name="width">Specifies the width of rasterized lines. The initial value is 1.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glLineWidth.xml" /></remarks>
        public static void LineWidth(float width) => GLPointers._glLineWidth_fnptr(width);
        
        /// <summary> <b>[requires: v1.0] [glLoadMatrixf]</b> Replace the current matrix with the specifiedmatrix. </summary>
        /// <param name="m">Specifies a pointer to 16 consecutive values, which are used as the elements of a 4x4 column-major matrix.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glLoadMatrix.xml" /></remarks>
        public static void LoadMatrixf(float* m) => GLPointers._glLoadMatrixf_fnptr(m);
        
        /// <summary> <b>[requires: v1.0] [glMaterialf]</b> Specify material parameters for the lighting model. </summary>
        /// <param name="face">Specifies which face or faces are being updated. Must be GL_FRONT_AND_BACK.</param>
        /// <param name="pname">Specifies the single-valued material parameter of the face or faces that is being updated. Must be GL_SHININESS.</param>
        /// <param name="param">Specifies the value that parameter GL_SHININESS will be set to.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glMaterial.xml" /></remarks>
        public static void Materialf(TriangleFace face, MaterialParameter pname, float param) => GLPointers._glMaterialf_fnptr((uint)face, (uint)pname, param);
        
        /// <summary> <b>[requires: v1.0] [glMaterialfv]</b>  </summary>
        public static void Materialfv(TriangleFace face, MaterialParameter pname, float* parameters) => GLPointers._glMaterialfv_fnptr((uint)face, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0] [glMultMatrixf]</b> Multiply the current matrix with the specifiedmatrix. </summary>
        /// <param name="m">Points to 16 consecutive values that are used as the elements of a 4x4 column-major matrix.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glMultMatrix.xml" /></remarks>
        public static void MultMatrixf(float* m) => GLPointers._glMultMatrixf_fnptr(m);
        
        /// <summary> <b>[requires: v1.0] [glMultiTexCoord4f]</b> Set the current texture coordinates. </summary>
        /// <param name="target">Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least twoone. Symbolic constant must be one of GL_TEXTUREi, where i ranges from 0 to GL_MAX_TEXTURE_UNITS - 1, which is an implementation-dependent value.</param>
        /// <param name="s">Specify s, t, r, and q texture coordinates for target texture unit.</param>
        /// <param name="t">Specify s, t, r, and q texture coordinates for target texture unit.</param>
        /// <param name="r">Specify s, t, r, and q texture coordinates for target texture unit.</param>
        /// <param name="q">Specify s, t, r, and q texture coordinates for target texture unit.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glMultiTexCoord.xml" /></remarks>
        public static void MultiTexCoord4f(TextureUnit target, float s, float t, float r, float q) => GLPointers._glMultiTexCoord4f_fnptr((uint)target, s, t, r, q);
        
        /// <summary> <b>[requires: v1.0] [glNormal3f]</b> Set the current normal vector. </summary>
        /// <param name="nx">Specify the x, y, and z coordinates of the new current normal. The initial value is (0, 0, 1).</param>
        /// <param name="ny">Specify the x, y, and z coordinates of the new current normal. The initial value is (0, 0, 1).</param>
        /// <param name="nz">Specify the x, y, and z coordinates of the new current normal. The initial value is (0, 0, 1).</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glNormal.xml" /></remarks>
        public static void Normal3f(float nx, float ny, float nz) => GLPointers._glNormal3f_fnptr(nx, ny, nz);
        
        /// <summary> <b>[requires: v1.0] [glOrthof]</b> Multiply the current matrix with an orthographicmatrix. </summary>
        /// <param name="left">Specify the coordinates for the left and right vertical clipping planes.</param>
        /// <param name="right">Specify the coordinates for the left and right vertical clipping planes.</param>
        /// <param name="bottom">Specify the coordinates for the bottom and top horizontal clipping planes.</param>
        /// <param name="top">Specify the coordinates for the bottom and top horizontal clipping planes.</param>
        /// <param name="near">Specify the distances to the nearer and farther depth clipping planes. These values are negative if the plane is to be behind the viewer.</param>
        /// <param name="far">Specify the distances to the nearer and farther depth clipping planes. These values are negative if the plane is to be behind the viewer.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glOrtho.xml" /></remarks>
        public static void Orthof(float l, float r, float b, float t, float n, float f) => GLPointers._glOrthof_fnptr(l, r, b, t, n, f);
        
        /// <summary> <b>[requires: v1.0] [glPointParameterf]</b> Specify parameters for point rasterization. </summary>
        /// <param name="pname"> Specifies the single-valued parameter to be updated. Can be either GL_POINT_SIZE_MIN, GL_POINT_SIZE_MAX, or GL_POINT_FADE_THRESHOLD_SIZE. </param>
        /// <param name="param"> Specifies the value that the parameter will be set to. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glPointParameter.xml" /></remarks>
        public static void PointParameterf(PointParameterNameARB pname, float param) => GLPointers._glPointParameterf_fnptr((uint)pname, param);
        
        /// <summary> <b>[requires: v1.0] [glPointParameterfv]</b>  </summary>
        public static void PointParameterfv(PointParameterNameARB pname, float* parameters) => GLPointers._glPointParameterfv_fnptr((uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0] [glPointSize]</b> Specify the diameter of rasterized points. </summary>
        /// <param name="size">Specifies the diameter of rasterized points. The initial value is 1.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glPointSize.xml" /></remarks>
        public static void PointSize(float size) => GLPointers._glPointSize_fnptr(size);
        
        /// <summary> <b>[requires: v1.0] [glPolygonOffset]</b> Set the scale and units used to calculate depth        values. </summary>
        /// <param name="factor">Specifies a scale factor that is used to create a variable depth offset for each polygon. The initial value is 0.</param>
        /// <param name="units">Is multiplied by an implementation-specific value to create a constant depth offset. The initial value is 0.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glPolygonOffset.xml" /></remarks>
        public static void PolygonOffset(float factor, float units) => GLPointers._glPolygonOffset_fnptr(factor, units);
        
        /// <summary> <b>[requires: v1.0] [glRotatef]</b> Multiply the current matrix by a rotation matrix. </summary>
        /// <param name="angle">Specifies the angle of rotation, in degrees.</param>
        /// <param name="x">Specify the x, y, and z coordinates of a vector, respectively.</param>
        /// <param name="y">Specify the x, y, and z coordinates of a vector, respectively.</param>
        /// <param name="z">Specify the x, y, and z coordinates of a vector, respectively.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glRotate.xml" /></remarks>
        public static void Rotatef(float angle, float x, float y, float z) => GLPointers._glRotatef_fnptr(angle, x, y, z);
        
        /// <summary> <b>[requires: v1.0] [glScalef]</b> Multiply the current matrix by a general scalingmatrix. </summary>
        /// <param name="x">Specify scale factors along the x, y, and z axes, respectively.</param>
        /// <param name="y">Specify scale factors along the x, y, and z axes, respectively.</param>
        /// <param name="z">Specify scale factors along the x, y, and z axes, respectively.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glScale.xml" /></remarks>
        public static void Scalef(float x, float y, float z) => GLPointers._glScalef_fnptr(x, y, z);
        
        /// <summary> <b>[requires: v1.0] [glTexEnvf]</b> Set texture environment parameters. </summary>
        /// <param name="target"> Specifies a texture environment. May be GL_TEXTURE_ENV or GL_POINT_SPRITE_OES. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture environment parameter. May be either GL_TEXTURE_ENV_MODE, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE_OES. </param>
        /// <param name="param"> Specifies a single symbolic constant, one of GL_ADD, GL_ADD_SIGNED, GL_DOT3_RGB, GL_DOT3_RGBA, GL_INTERPOLATE, GL_MODULATE, GL_DECAL, GL_BLEND, GL_REPLACE, GL_SUBTRACT, GL_COMBINE, GL_TEXTURE, GL_CONSTANT, GL_PRIMARY_COLOR, GL_PREVIOUS, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, a single boolean value for the point sprite texture coordinate replacement, or 1.0, 2.0, or 4.0 when specifying the GL_RGB_SCALE or GL_ALPHA_SCALE. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glTexEnv.xml" /></remarks>
        public static void TexEnvf(TextureEnvTarget target, TextureEnvParameter pname, float param) => GLPointers._glTexEnvf_fnptr((uint)target, (uint)pname, param);
        
        /// <summary> <b>[requires: v1.0] [glTexEnvfv]</b>  </summary>
        public static void TexEnvfv(TextureEnvTarget target, TextureEnvParameter pname, float* parameters) => GLPointers._glTexEnvfv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0] [glTexParameterf]</b> Set texture parameters. </summary>
        /// <param name="target">Specifies the target texture, which must be GL_TEXTURE_2D.</param>
        /// <param name="pname">Specifies the symbolic name of a single-valued texture parameter. Which can be one of the following: GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_GENERATE_MIPMAP.</param>
        /// <param name="param">Specifies the value of pname.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glTexParameter.xml" /></remarks>
        public static void TexParameterf(TextureTarget target, TextureParameterName pname, float param) => GLPointers._glTexParameterf_fnptr((uint)target, (uint)pname, param);
        
        /// <summary> <b>[requires: v1.0] [glTexParameterfv]</b>  </summary>
        public static void TexParameterfv(TextureTarget target, TextureParameterName pname, float* parameters) => GLPointers._glTexParameterfv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0] [glTranslatef]</b> Multiply the current matrix by a translation matrix. </summary>
        /// <param name="x">Specify the x, y, and z coordinates of a translation vector.</param>
        /// <param name="y">Specify the x, y, and z coordinates of a translation vector.</param>
        /// <param name="z">Specify the x, y, and z coordinates of a translation vector.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glTranslate.xml" /></remarks>
        public static void Translatef(float x, float y, float z) => GLPointers._glTranslatef_fnptr(x, y, z);
        
        /// <summary> <b>[requires: v1.0] [glActiveTexture]</b> Select server-side active texture unit. </summary>
        /// <param name="texture"> Specifies which texture unit to make active. The number of texture units is implementation dependent, but must be at least two. texture must be one of GL_TEXTUREi, where 0 &lt;= i &lt; GL_MAX_TEXTURE_UNITS , which is an implementation-dependent value. The initial value is GL_TEXTURE0. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glActiveTexture.xml" /></remarks>
        public static void ActiveTexture(TextureUnit texture) => GLPointers._glActiveTexture_fnptr((uint)texture);
        
        /// <summary> <b>[requires: v1.0] [glAlphaFuncx]</b> Specify the alpha test function. </summary>
        /// <param name="func">Specifies the alpha comparison function. Symbolic constants GL_NEVER, GL_LESS, GL_EQUAL, GL_LEQUAL, GL_GREATER, GL_NOTEQUAL, GL_GEQUAL, and GL_ALWAYS are accepted. The initial value is GL_ALWAYS. </param>
        /// <param name="reference">Specifies the reference value that incoming alpha values are compared to. This value is clamped to the range [0, 1], where 0 represents the lowest possible alpha value and 1 the highest possible value. The initial reference value is 0. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glAlphaFunc.xml" /></remarks>
        public static void AlphaFuncx(AlphaFunction func, int reference) => GLPointers._glAlphaFuncx_fnptr((uint)func, reference);
        
        /// <summary> <b>[requires: v1.0] [glBindBuffer]</b> Bind a named buffer to a target. </summary>
        /// <param name="target"> Specifies the target to which the buffer is bound. The symbolic constant must be GL_ARRAY_BUFFER or GL_ELEMENT_ARRAY_BUFFER. </param>
        /// <param name="buffer">Specifies the name of a buffer object.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glBindBuffer.xml" /></remarks>
        public static void BindBuffer(BufferTargetARB target, int buffer) => GLPointers._glBindBuffer_fnptr((uint)target, buffer);
        
        /// <summary> <b>[requires: v1.0] [glBindTexture]</b> Bind a named texture to a texturing target. </summary>
        /// <param name="target">Specifies the target to which the texture is bound. Must be GL_TEXTURE_2D.</param>
        /// <param name="texture">Specifies the name of a texture.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glBindTexture.xml" /></remarks>
        public static void BindTexture(TextureTarget target, int texture) => GLPointers._glBindTexture_fnptr((uint)target, texture);
        
        /// <summary> <b>[requires: v1.0] [glBlendFunc]</b> Specify pixel arithmetic. </summary>
        /// <param name="sfactor"> Specifies how the red, green, blue, and alpha source blending factors are computed. The following symbolic constants are accepted: GL_ZERO, GL_ONE, GL_DST_COLOR, GL_ONE_MINUS_DST_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, GL_DST_ALPHA, GL_ONE_MINUS_DST_ALPHA, and GL_SRC_ALPHA_SATURATE. The initial value is GL_ONE. </param>
        /// <param name="dfactor">Specifies how the red, green, blue, and alpha destination blending factors are computed. Eight symbolic constants are accepted: GL_ZERO, GL_ONE, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, GL_DST_ALPHA, and GL_ONE_MINUS_DST_ALPHA. The initial value is GL_ZERO.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glBlendFunc.xml" /></remarks>
        public static void BlendFunc(BlendingFactor sfactor, BlendingFactor dfactor) => GLPointers._glBlendFunc_fnptr((uint)sfactor, (uint)dfactor);
        
        /// <summary> <b>[requires: v1.0] [glBufferData]</b> Creates and initializes a buffer object&apos;s data store.. </summary>
        /// <param name="target"> Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER or GL_ELEMENT_ARRAY_BUFFER. </param>
        /// <param name="size">Specifies the size in bytes of the buffer object&apos;s new data store.</param>
        /// <param name="data">Specifies a pointer to data that will be copied into the data store for initialization, or NULL if no data is to be copied.</param>
        /// <param name="usage"> Specifies the expected usage pattern of the data store. The symbolic constant must be GL_STATIC_DRAW or GL_DYNAMIC_DRAW. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glBufferData.xml" /></remarks>
        public static void BufferData(BufferTargetARB target, nint size, void* data, BufferUsageARB usage) => GLPointers._glBufferData_fnptr((uint)target, size, data, (uint)usage);
        
        /// <summary> <b>[requires: v1.0] [glBufferSubData]</b> Updates a subset of a buffer object&apos;s data store.. </summary>
        /// <param name="target"> Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER or GL_ELEMENT_ARRAY_BUFFER. </param>
        /// <param name="offset">Specifies the offset into the buffer object&apos;s data store where data replacement will begin, measured in bytes.</param>
        /// <param name="size">Specifies the size in bytes of the data store region being replaced.</param>
        /// <param name="data"> Specifies a pointer to the new data that will be copied into the data store.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glBufferSubData.xml" /></remarks>
        public static void BufferSubData(BufferTargetARB target, IntPtr offset, nint size, void* data) => GLPointers._glBufferSubData_fnptr((uint)target, offset, size, data);
        
        /// <summary> <b>[requires: v1.0] [glClear]</b> Clear buffers to preset values. </summary>
        /// <param name="mask">Bitwise OR of masks that indicate the buffers to be cleared. Valid masks are GL_COLOR_BUFFER_BIT, GL_DEPTH_BUFFER_BIT, and GL_STENCIL_BUFFER_BIT.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glClear.xml" /></remarks>
        public static void Clear(ClearBufferMask mask) => GLPointers._glClear_fnptr((uint)mask);
        
        /// <summary> <b>[requires: v1.0] [glClearColorx]</b> Specify clear values for the color buffer. </summary>
        /// <param name="red">Specify the red, green, blue, and alpha values used when the color buffer is cleared. The initial values are all 0.</param>
        /// <param name="green">Specify the red, green, blue, and alpha values used when the color buffer is cleared. The initial values are all 0.</param>
        /// <param name="blue">Specify the red, green, blue, and alpha values used when the color buffer is cleared. The initial values are all 0.</param>
        /// <param name="alpha">Specify the red, green, blue, and alpha values used when the color buffer is cleared. The initial values are all 0.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glClearColor.xml" /></remarks>
        public static void ClearColorx(int red, int green, int blue, int alpha) => GLPointers._glClearColorx_fnptr(red, green, blue, alpha);
        
        /// <summary> <b>[requires: v1.0] [glClearDepthx]</b> Specify the clear value for the depth buffer. </summary>
        /// <param name="depth">Specifies the depth value used when the depth buffer is cleared. The initial value is 1.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glClearDepth.xml" /></remarks>
        public static void ClearDepthx(int depth) => GLPointers._glClearDepthx_fnptr(depth);
        
        /// <summary> <b>[requires: v1.0] [glClearStencil]</b> Specify the clear value for the stencil buffer. </summary>
        /// <param name="s">Specifies the index used when the stencil buffer is cleared. The initial value is 0.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glClearStencil.xml" /></remarks>
        public static void ClearStencil(int s) => GLPointers._glClearStencil_fnptr(s);
        
        /// <summary> <b>[requires: v1.0] [glClientActiveTexture]</b> Select client-side active texture unit. </summary>
        /// <param name="texture"> Specifies which texture unit to make active. The number of texture units is implementation dependent, but must be at least two. texture must be one of GL_TEXTUREi, 0 &lt;= i &lt; GL_MAX_TEXTURE_UNITS , which is an implementation-dependent value. The initial value is GL_TEXTURE0. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glClientActiveTexture.xml" /></remarks>
        public static void ClientActiveTexture(TextureUnit texture) => GLPointers._glClientActiveTexture_fnptr((uint)texture);
        
        /// <summary> <b>[requires: v1.0] [glClipPlanex]</b> Specify a plane against which all geometry is    clipped. </summary>
        /// <param name="plane">Specifies which clipping plane is being positioned. Symbolic names of the form GL_CLIP_PLANEi, where i is an integer between 0 and GL_MAX_CLIP_PLANES -1 , are accepted.</param>
        /// <param name="equation">Specifies the address of an array of four fixed-point or floating-point values. These are the coefficients of a plane equation in object coordinates: p1, p2, p3, and p4, in that order.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glClipPlane.xml" /></remarks>
        public static void ClipPlanex(ClipPlaneName plane, int* equation) => GLPointers._glClipPlanex_fnptr((uint)plane, equation);
        
        /// <summary> <b>[requires: v1.0] [glColor4ub]</b> Set the current color. </summary>
        /// <param name="red">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <param name="green">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <param name="blue">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <param name="alpha">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glColor.xml" /></remarks>
        public static void Color4ub(byte red, byte green, byte blue, byte alpha) => GLPointers._glColor4ub_fnptr(red, green, blue, alpha);
        
        /// <summary> <b>[requires: v1.0] [glColor4x]</b> Set the current color. </summary>
        /// <param name="red">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <param name="green">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <param name="blue">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <param name="alpha">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glColor.xml" /></remarks>
        public static void Color4x(int red, int green, int blue, int alpha) => GLPointers._glColor4x_fnptr(red, green, blue, alpha);
        
        /// <summary> <b>[requires: v1.0] [glColorMask]</b> Enable and disable writing of color buffer        components. </summary>
        /// <param name="red">Specify whether red, green, blue, and alpha can or cannot be written into the color buffer. The initial values are all GL_TRUE, indicating that all color components can be written.</param>
        /// <param name="green">Specify whether red, green, blue, and alpha can or cannot be written into the color buffer. The initial values are all GL_TRUE, indicating that all color components can be written.</param>
        /// <param name="blue">Specify whether red, green, blue, and alpha can or cannot be written into the color buffer. The initial values are all GL_TRUE, indicating that all color components can be written.</param>
        /// <param name="alpha">Specify whether red, green, blue, and alpha can or cannot be written into the color buffer. The initial values are all GL_TRUE, indicating that all color components can be written.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glColorMask.xml" /></remarks>
        public static void ColorMask(bool red, bool green, bool blue, bool alpha) => GLPointers._glColorMask_fnptr((byte)(red ? 1 : 0), (byte)(green ? 1 : 0), (byte)(blue ? 1 : 0), (byte)(alpha ? 1 : 0));
        
        /// <summary> <b>[requires: v1.0] [glColorPointer]</b> Define an array of colors. </summary>
        /// <param name="size">Specifies the number of components per color. Must be 4. The initial value is 4.</param>
        /// <param name="type">Specifies the data type of each color component in the array. Symbolic constants GL_UNSIGNED_BYTE and GL_FIXED are accepted. However, the initial value is GL_FLOAT.</param>
        /// <param name="stride">Specifies the byte offset between consecutive colors. If stride is 0, the colors are understood to be tightly packed in the array. The initial value is 0.</param>
        /// <param name="pointer">Specifies a pointer to the first component of the first color element in the array.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glColorPointer.xml" /></remarks>
        public static void ColorPointer(int size, ColorPointerType type, int stride, void* pointer) => GLPointers._glColorPointer_fnptr(size, (uint)type, stride, pointer);
        
        /// <summary> <b>[requires: v1.0] [glCompressedTexImage2D]</b> Specify a two-dimensional compressed texture image. </summary>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_2D.</param>
        /// <param name="level">Specifies the level-of-detail number. For paletted formats, where all mipmap levels are loaded at once, this parameter is overloaded to represent the negative of the greatest mipmap level included in data. </param>
        /// <param name="internalformat">Specifies the color components in the texture. The following symbolic constants are accepted: GL_PALETTE4_RGB8_OES, GL_PALETTE4_RGBA8_OES, GL_PALETTE4_R5_G6_B5_OES, GL_PALETTE4_RGBA4_OES, GL_PALETTE4_RGB5_A1_OES, GL_PALETTE8_RGB8_OES, GL_PALETTE8_RGBA8_OES, GL_PALETTE8_R5_G6_B5_OES, GL_PALETTE8_RGBA4_OES, and GL_PALETTE8_RGB5_A1_OES.</param>
        /// <param name="width">Specifies the width of the texture image. Must be 2n for some integer n. All implementations support texture images that are at least 64 texels wide.</param>
        /// <param name="height">Specifies the height of the texture image. Must be 2m for some integer m. All implementations support texture images that are at least 64 texels high.</param>
        /// <param name="border">Specifies the width of the border. Must be 0.</param>
        /// <param name="imageSize">Specifies the size of the compressed image data in bytes.</param>
        /// <param name="data">Specifies a pointer to the compressed image data in memory.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glCompressedTexImage2D.xml" /></remarks>
        public static void CompressedTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, void* data) => GLPointers._glCompressedTexImage2D_fnptr((uint)target, level, (uint)internalformat, width, height, border, imageSize, data);
        
        /// <summary> <b>[requires: v1.0] [glCompressedTexSubImage2D]</b> Specify a two-dimensional compressed texture subimage. </summary>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_2D.</param>
        /// <param name="level">Specifies the level-of-detail number.</param>
        /// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="yoffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="format">Specifies the format of the pixel data. Currently, there is no supported format.</param>
        /// <param name="imageSize">Specifies the size of the compressed pixel data in bytes.</param>
        /// <param name="data">Specifies a pointer to the compressed image data in memory.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glCompressedTexSubImage2D.xml" /></remarks>
        public static void CompressedTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, InternalFormat format, int imageSize, void* data) => GLPointers._glCompressedTexSubImage2D_fnptr((uint)target, level, xoffset, yoffset, width, height, (uint)format, imageSize, data);
        
        /// <summary> <b>[requires: v1.0] [glCopyTexImage2D]</b> Specify a two-dimensional texture image with pixels from the color buffer. </summary>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_2D.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="internalformat">Specifies the color components of the texture. Must be one of the following symbolic constants: GL_ALPHA, GL_LUMINANCE, GL_LUMINANCE_ALPHA, GL_RGB, or GL_RGBA.</param>
        /// <param name="x">Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.</param>
        /// <param name="y">Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.</param>
        /// <param name="width">Specifies the width of the texture image. Must be 0 or 2n for some integer n.</param>
        /// <param name="height">Specifies the height of the texture image. Must be 0 or 2m for some integer m.</param>
        /// <param name="border">Specifies the width of the border. Must be 0.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glCopyTexImage2D.xml" /></remarks>
        public static void CopyTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int height, int border) => GLPointers._glCopyTexImage2D_fnptr((uint)target, level, (uint)internalformat, x, y, width, height, border);
        
        /// <summary> <b>[requires: v1.0] [glCopyTexSubImage2D]</b> Specify a two-dimensional texture subimage with pixels from the color buffer. </summary>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_2D.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="yoffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="x">Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.</param>
        /// <param name="y">Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glCopyTexSubImage2D.xml" /></remarks>
        public static void CopyTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height) => GLPointers._glCopyTexSubImage2D_fnptr((uint)target, level, xoffset, yoffset, x, y, width, height);
        
        /// <summary> <b>[requires: v1.0] [glCullFace]</b> Specify whether front- or back-facing polygons are        culled. </summary>
        /// <param name="mode">Specifies whether front- or back-facing polygons are culled. Symbolic constants GL_FRONT, GL_BACK, and GL_FRONT_AND_BACK are accepted. The initial value is GL_BACK.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glCullFace.xml" /></remarks>
        public static void CullFace(TriangleFace mode) => GLPointers._glCullFace_fnptr((uint)mode);
        
        /// <summary> <b>[requires: v1.0] [glDeleteBuffers]</b> Delete named buffer objects. </summary>
        /// <param name="n">Specifies the number of buffer objects to be deleted.</param>
        /// <param name="buffers">Specifies an array of buffer object names to be deleted.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glDeleteBuffers.xml" /></remarks>
        public static void DeleteBuffers(int n, int* buffers) => GLPointers._glDeleteBuffers_fnptr(n, buffers);
        
        /// <summary> <b>[requires: v1.0] [glDeleteTextures]</b> Delete named textures. </summary>
        /// <param name="n">Specifies the number of textures to be deleted.</param>
        /// <param name="textures">Specifies an array of textures to be deleted.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glDeleteTextures.xml" /></remarks>
        public static void DeleteTextures(int n, int* textures) => GLPointers._glDeleteTextures_fnptr(n, textures);
        
        /// <summary> <b>[requires: v1.0] [glDepthFunc]</b> Specify the value used for depth buffer comparisons. </summary>
        /// <param name="func">Specifies the depth comparison function. Symbolic constants GL_NEVER, GL_LESS, GL_EQUAL, GL_LEQUAL, GL_GREATER, GL_NOTEQUAL, GL_GEQUAL, and GL_ALWAYS are accepted. The initial value is GL_LESS.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glDepthFunc.xml" /></remarks>
        public static void DepthFunc(DepthFunction func) => GLPointers._glDepthFunc_fnptr((uint)func);
        
        /// <summary> <b>[requires: v1.0] [glDepthMask]</b> Enable or disable writing into the depth buffer. </summary>
        /// <param name="flag">Specifies whether the depth buffer is enabled for writing. If flag is GL_FALSE, depth buffer writing is disabled, otherwise it is enabled. The initial value is GL_TRUE.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glDepthMask.xml" /></remarks>
        public static void DepthMask(bool flag) => GLPointers._glDepthMask_fnptr((byte)(flag ? 1 : 0));
        
        /// <summary> <b>[requires: v1.0] [glDepthRangex]</b> Specify mapping of depth values from normalized        device coordinates to window coordinates. </summary>
        /// <param name="near">Specifies the mapping of the near clipping plane to window coordinates. The initial value is 0.</param>
        /// <param name="far">Specifies the mapping of the far clipping plane to window coordinates. The initial value is 1.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glDepthRange.xml" /></remarks>
        public static void DepthRangex(int n, int f) => GLPointers._glDepthRangex_fnptr(n, f);
        
        /// <summary> <b>[requires: v1.0] [glDisable]</b> Enable or disable server-side GL capabilities. </summary>
        /// <param name="cap">Specifies a symbolic constant indicating a GL capability.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glEnable.xml" /></remarks>
        public static void Disable(EnableCap cap) => GLPointers._glDisable_fnptr((uint)cap);
        
        /// <summary> <b>[requires: v1.0] [glDisableClientState]</b> Enable or disable client-side capability. </summary>
        /// <param name="array"> Specifies the capability to enable or disable. Symbolic constants GL_COLOR_ARRAY, GL_MATRIX_INDEX_ARRAY_OES, GL_NORMAL_ARRAY, GL_POINT_SIZE_ARRAY_OES, GL_TEXTURE_COORD_ARRAY, and GL_VERTEX_ARRAY, and GL_WEIGHT_ARRAY_OES are accepted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glEnableClientState.xml" /></remarks>
        public static void DisableClientState(EnableCap array) => GLPointers._glDisableClientState_fnptr((uint)array);
        
        /// <summary> <b>[requires: v1.0] [glDrawArrays]</b> Render primitives from array data. </summary>
        /// <param name="mode">Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, and GL_TRIANGLES are accepted.</param>
        /// <param name="first">Specifies the starting index in the enabled arrays.</param>
        /// <param name="count">Specifies the number of indices to be rendered.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glDrawArrays.xml" /></remarks>
        public static void DrawArrays(PrimitiveType mode, int first, int count) => GLPointers._glDrawArrays_fnptr((uint)mode, first, count);
        
        /// <summary> <b>[requires: v1.0] [glDrawElements]</b> Render primitives from array data. </summary>
        /// <param name="mode">Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, and GL_TRIANGLES are accepted.</param>
        /// <param name="count">Specifies the number of elements to be rendered.</param>
        /// <param name="type">Specifies the type of the values in indices. Must be either GL_UNSIGNED_BYTE or GL_UNSIGNED_SHORT.</param>
        /// <param name="indices">Specifies a pointer to the location where the indices are stored.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glDrawElements.xml" /></remarks>
        public static void DrawElements(PrimitiveType mode, int count, DrawElementsType type, void* indices) => GLPointers._glDrawElements_fnptr((uint)mode, count, (uint)type, indices);
        
        /// <summary> <b>[requires: v1.0] [glEnable]</b> Enable or disable server-side GL capabilities. </summary>
        /// <param name="cap">Specifies a symbolic constant indicating a GL capability.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glEnable.xml" /></remarks>
        public static void Enable(EnableCap cap) => GLPointers._glEnable_fnptr((uint)cap);
        
        /// <summary> <b>[requires: v1.0] [glEnableClientState]</b> Enable or disable client-side capability. </summary>
        /// <param name="array"> Specifies the capability to enable or disable. Symbolic constants GL_COLOR_ARRAY, GL_MATRIX_INDEX_ARRAY_OES, GL_NORMAL_ARRAY, GL_POINT_SIZE_ARRAY_OES, GL_TEXTURE_COORD_ARRAY, and GL_VERTEX_ARRAY, and GL_WEIGHT_ARRAY_OES are accepted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glEnableClientState.xml" /></remarks>
        public static void EnableClientState(EnableCap array) => GLPointers._glEnableClientState_fnptr((uint)array);
        
        /// <summary> <b>[requires: v1.0] [glFinish]</b> Block until all GL execution is complete. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glFinish.xml" /></remarks>
        public static void Finish() => GLPointers._glFinish_fnptr();
        
        /// <summary> <b>[requires: v1.0] [glFlush]</b> Force execution of GL commands in finite time. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glFlush.xml" /></remarks>
        public static void Flush() => GLPointers._glFlush_fnptr();
        
        /// <summary> <b>[requires: v1.0] [glFogx]</b> Specify fog parameters. </summary>
        /// <param name="pname">Specifies a single-valued fog parameter. GL_FOG_MODE, GL_FOG_DENSITY, GL_FOG_START, and GL_FOG_END are accepted.</param>
        /// <param name="param">Specifies the value that pname will be set to.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glFog.xml" /></remarks>
        public static void Fogx(FogPName pname, int param) => GLPointers._glFogx_fnptr((uint)pname, param);
        
        /// <summary> <b>[requires: v1.0] [glFogxv]</b>  </summary>
        public static void Fogxv(FogPName pname, int* param) => GLPointers._glFogxv_fnptr((uint)pname, param);
        
        /// <summary> <b>[requires: v1.0] [glFrontFace]</b> Define front- and back-facing polygons. </summary>
        /// <param name="mode">Specifies the orientation of front-facing polygons. GL_CW and GL_CCW are accepted. The initial value is GL_CCW.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glFrontFace.xml" /></remarks>
        public static void FrontFace(FrontFaceDirection mode) => GLPointers._glFrontFace_fnptr((uint)mode);
        
        /// <summary> <b>[requires: v1.0] [glFrustumx]</b> Multiply the current matrix by a perspective matrix. </summary>
        /// <param name="left">Specify the coordinates for the left and right vertical clipping planes.</param>
        /// <param name="right">Specify the coordinates for the left and right vertical clipping planes.</param>
        /// <param name="bottom">Specify the coordinates for the bottom and top horizontal clipping planes.</param>
        /// <param name="top">Specify the coordinates for the bottom and top horizontal clipping planes.</param>
        /// <param name="near">Specify the distances to the near and far depth clipping planes. Both distances must be positive.</param>
        /// <param name="far">Specify the distances to the near and far depth clipping planes. Both distances must be positive.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glFrustum.xml" /></remarks>
        public static void Frustumx(int l, int r, int b, int t, int n, int f) => GLPointers._glFrustumx_fnptr(l, r, b, t, n, f);
        
        /// <summary> <b>[requires: v1.0] [glGetBooleanv]</b> Return the value or values of a selected parameter. </summary>
        /// <param name="pname">Specifies the parameter value to be returned. The symbolic constants in the list below are accepted.</param>
        /// <param name="parameters">Returns the value or values of the specified parameter.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGet.xml" /></remarks>
        public static void GetBooleanv(GetPName pname, bool* data) => GLPointers._glGetBooleanv_fnptr((uint)pname, (byte*)data);
        
        /// <summary> <b>[requires: v1.0] [glGetBufferParameteriv]</b> Return parameters of a buffer object. </summary>
        /// <param name="target"> Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER or GL_ELEMENT_ARRAY_BUFFER. </param>
        /// <param name="pname"> Specifies the symbolic name of a buffer object parameter. Accepted values are GL_BUFFER_SIZE or GL_BUFFER_USAGE. </param>
        /// <param name="parameters">Returns the requested parameter.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetBufferParameteriv.xml" /></remarks>
        public static void GetBufferParameteriv(BufferTargetARB target, BufferPNameARB pname, int* parameters) => GLPointers._glGetBufferParameteriv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0] [glGetClipPlanex]</b> Return the coefficients of the specified clipping    plane. </summary>
        /// <param name="plane">Specifies a clipping plane. The number of clipping planes depends on the implementation, but at least six clipping planes are supported. Symbolic names of the form GL_CLIP_PLANE i, where i is an integer between 0 and GL_MAX_CLIP_PLANES -1 , are accepted.</param>
        /// <param name="equation">Returns four fixed-point or floating-point values that are the coefficients of the plane equation of plane in eye coordinates in the order p1, p2, p3, and p4. The initial value is (0, 0, 0, 0).</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetClipPlane.xml" /></remarks>
        public static void GetClipPlanex(ClipPlaneName plane, int* equation) => GLPointers._glGetClipPlanex_fnptr((uint)plane, equation);
        
        /// <summary> <b>[requires: v1.0] [glGenBuffers]</b> Generate buffer object names. </summary>
        /// <param name="n">Specifies the number of buffer object names to be generated.</param>
        /// <param name="buffers">Specifies an array in which the generated buffer object names are stored.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGenBuffers.xml" /></remarks>
        public static void GenBuffers(int n, int* buffers) => GLPointers._glGenBuffers_fnptr(n, buffers);
        
        /// <summary> <b>[requires: v1.0] [glGenTextures]</b> Generate texture names. </summary>
        /// <param name="n">Specifies the number of texture names to be generated.</param>
        /// <param name="textures">Specifies an array in which the generated texture names are stored.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGenTextures.xml" /></remarks>
        public static void GenTextures(int n, int* textures) => GLPointers._glGenTextures_fnptr(n, textures);
        
        /// <summary> <b>[requires: v1.0] [glGetError]</b> Return error information. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetError.xml" /></remarks>
        public static ErrorCode GetError() => (ErrorCode) GLPointers._glGetError_fnptr();
        
        /// <summary> <b>[requires: v1.0] [glGetFixedv]</b> Return the value or values of a selected parameter. </summary>
        /// <param name="pname">Specifies the parameter value to be returned. The symbolic constants in the list below are accepted.</param>
        /// <param name="parameters">Returns the value or values of the specified parameter.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGet.xml" /></remarks>
        public static void GetFixedv(GetPName pname, int* parameters) => GLPointers._glGetFixedv_fnptr((uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0] [glGetIntegerv]</b> Return the value or values of a selected parameter. </summary>
        /// <param name="pname">Specifies the parameter value to be returned. The symbolic constants in the list below are accepted.</param>
        /// <param name="parameters">Returns the value or values of the specified parameter.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGet.xml" /></remarks>
        public static void GetIntegerv(GetPName pname, int* data) => GLPointers._glGetIntegerv_fnptr((uint)pname, data);
        
        /// <summary> <b>[requires: v1.0] [glGetLightxv]</b> Return light source parameter values. </summary>
        /// <param name="light"> Specifies a light source. The number of possible lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form GL_LIGHTi where 0&lt;i&lt; GL_MAX_LIGHTS </param>
        /// <param name="pname"> Specifies a light source parameter for light. Accepted symbolic names are GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_POSITION, GL_SPOT_DIRECTION, GL_SPOT_EXPONENT, GL_SPOT_CUTOFF, GL_CONSTANT_ATTENUATION, GL_LINEAR_ATTENUATION, and GL_QUADRATIC_ATTENUATION. </param>
        /// <param name="parameters"> Returns the requested data. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetLight.xml" /></remarks>
        public static void GetLightxv(LightName light, LightParameter pname, int* parameters) => GLPointers._glGetLightxv_fnptr((uint)light, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0] [glGetMaterialxv]</b> Return material parameters values. </summary>
        /// <param name="face"> Specifies which of the two materials is being queried. GL_FRONT or GL_BACK are accepted, representing the front and back materials, respectively. </param>
        /// <param name="pname"> Specifies the material parameter to return. Accepted symbolic names are GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_EMISSION, and GL_SHININESS. </param>
        /// <param name="parameters"> Returns the requested data. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetMaterial.xml" /></remarks>
        public static void GetMaterialxv(TriangleFace face, MaterialParameter pname, int* parameters) => GLPointers._glGetMaterialxv_fnptr((uint)face, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0 | GL_KHR_debug] [glGetPointerv]</b> Return the address of the specified pointer. </summary>
        /// <param name="pname"> Specifies the array or buffer pointer to be returned. Accepted symbolic names are GL_COLOR_ARRAY_POINTER, GL_MATRIX_INDEX_ARRAY_POINTER_OES, GL_NORMAL_ARRAY_POINTER, GL_POINT_SIZE_ARRAY_POINTER_OES, GL_TEXTURE_COORD_ARRAY_POINTER, and GL_VERTEX_ARRAY_POINTER., and GL_WEIGHT_ARRAY_POINTER_OES. </param>
        /// <param name="parameters"> Returns the pointer value specified by pname. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetPointerv.xml" /></remarks>
        public static void GetPointerv(GetPointervPName pname, void** parameters) => GLPointers._glGetPointerv_fnptr((uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0] [glGetString]</b> Return a string describing the current GL        connection. </summary>
        /// <param name="name">Specifies a symbolic constant, one of GL_VENDOR, GL_RENDERER, GL_VERSION, or GL_EXTENSIONS.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetString.xml" /></remarks>
        public static byte* GetString_(StringName name) => GLPointers._glGetString_fnptr((uint)name);
        
        /// <summary> <b>[requires: v1.0] [glGetTexEnviv]</b> Return texture environment parameters. </summary>
        /// <param name="target"> Specifies a texture environment. May be GL_TEXTURE_ENV or GL_POINT_SPRITE_OES. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture environment parameter. Accepted values are GL_TEXTURE_ENV_MODE, GL_TEXTURE_ENV_COLOR, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE_OES. </param>
        /// <param name="parameters"> Returns the requested data. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetTexEnv.xml" /></remarks>
        public static void GetTexEnviv(TextureEnvTarget target, TextureEnvParameter pname, int* parameters) => GLPointers._glGetTexEnviv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0] [glGetTexEnvxv]</b> Return texture environment parameters. </summary>
        /// <param name="target"> Specifies a texture environment. May be GL_TEXTURE_ENV or GL_POINT_SPRITE_OES. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture environment parameter. Accepted values are GL_TEXTURE_ENV_MODE, GL_TEXTURE_ENV_COLOR, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE_OES. </param>
        /// <param name="parameters"> Returns the requested data. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetTexEnv.xml" /></remarks>
        public static void GetTexEnvxv(TextureEnvTarget target, TextureEnvParameter pname, int* parameters) => GLPointers._glGetTexEnvxv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0] [glGetTexParameteriv]</b> Return texture parameter values. </summary>
        /// <param name="target">Specifies the target texture, which must be GL_TEXTURE_2D.</param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. Which can be one of the following: GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_GENERATE_MIPMAP. </param>
        /// <param name="parameters">Returns texture parameters.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetTexParameter.xml" /></remarks>
        public static void GetTexParameteriv(TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._glGetTexParameteriv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0] [glGetTexParameterxv]</b> Return texture parameter values. </summary>
        /// <param name="target">Specifies the target texture, which must be GL_TEXTURE_2D.</param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. Which can be one of the following: GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_GENERATE_MIPMAP. </param>
        /// <param name="parameters">Returns texture parameters.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetTexParameter.xml" /></remarks>
        public static void GetTexParameterxv(TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._glGetTexParameterxv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0] [glHint]</b> Specify implementation-specific hints. </summary>
        /// <param name="target">Specifies a symbolic constant indicating the behavior to be controlled. GL_FOG_HINT , GL_GENERATE_MIPMAP_HINT , GL_LINE_SMOOTH_HINT , GL_PERSPECTIVE_CORRECTION_HINT, and GL_POINT_SMOOTH_HINT are accepted.</param>
        /// <param name="mode">Specifies a symbolic constant indicating the desired behavior. GL_FASTEST, GL_NICEST, and GL_DONT_CARE are accepted.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glHint.xml" /></remarks>
        public static void Hint(HintTarget target, HintMode mode) => GLPointers._glHint_fnptr((uint)target, (uint)mode);
        
        /// <summary> <b>[requires: v1.0] [glIsBuffer]</b> Determine if a name corresponds to a buffer object. </summary>
        /// <param name="buffer"> Specifies a value that may be the name of a buffer object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glIsBuffer.xml" /></remarks>
        public static bool IsBuffer(int buffer) => GLPointers._glIsBuffer_fnptr(buffer) != 0;
        
        /// <summary> <b>[requires: v1.0] [glIsEnabled]</b> Test whether a capability is enabled. </summary>
        /// <param name="cap"> Specifies a symbolic constant indicating a GL capability. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glIsEnabled.xml" /></remarks>
        public static bool IsEnabled(EnableCap cap) => GLPointers._glIsEnabled_fnptr((uint)cap) != 0;
        
        /// <summary> <b>[requires: v1.0] [glIsTexture]</b> Determine if a name corresponds to a texture. </summary>
        /// <param name="texture"> Specifies a value that may be the name of a texture. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glIsTexture.xml" /></remarks>
        public static bool IsTexture(int texture) => GLPointers._glIsTexture_fnptr(texture) != 0;
        
        /// <summary> <b>[requires: v1.0] [glLightModelx]</b> Set the lighting model parameters. </summary>
        /// <param name="pname">Specifies a single-valued lighting model parameter. Must be GL_LIGHT_MODEL_TWO_SIDE.</param>
        /// <param name="param">Specifies the value that param will be set to.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glLightModel.xml" /></remarks>
        public static void LightModelx(LightModelParameter pname, int param) => GLPointers._glLightModelx_fnptr((uint)pname, param);
        
        /// <summary> <b>[requires: v1.0] [glLightModelxv]</b>  </summary>
        public static void LightModelxv(LightModelParameter pname, int* param) => GLPointers._glLightModelxv_fnptr((uint)pname, param);
        
        /// <summary> <b>[requires: v1.0] [glLightx]</b> Set light source parameters. </summary>
        /// <param name="light">Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form GL_LIGHTi where 0 &lt;= i &lt; GL_MAX_LIGHTS . </param>
        /// <param name="pname">Specifies a single-valued light source parameter for light. GL_SPOT_EXPONENT, GL_SPOT_CUTOFF, GL_CONSTANT_ATTENUATION, GL_LINEAR_ATTENUATION, and GL_QUADRATIC_ATTENUATION are accepted.</param>
        /// <param name="param">Specifies the value that parameter pname of light source light will be set to.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glLight.xml" /></remarks>
        public static void Lightx(LightName light, LightParameter pname, int param) => GLPointers._glLightx_fnptr((uint)light, (uint)pname, param);
        
        /// <summary> <b>[requires: v1.0] [glLightxv]</b>  </summary>
        public static void Lightxv(LightName light, LightParameter pname, int* parameters) => GLPointers._glLightxv_fnptr((uint)light, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0] [glLineWidthx]</b> Specify the width of rasterized lines. </summary>
        /// <param name="width">Specifies the width of rasterized lines. The initial value is 1.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glLineWidth.xml" /></remarks>
        public static void LineWidthx(int width) => GLPointers._glLineWidthx_fnptr(width);
        
        /// <summary> <b>[requires: v1.0] [glLoadIdentity]</b> Replace the current matrix with the identitymatrix. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glLoadIdentity.xml" /></remarks>
        public static void LoadIdentity() => GLPointers._glLoadIdentity_fnptr();
        
        /// <summary> <b>[requires: v1.0] [glLoadMatrixx]</b> Replace the current matrix with the specifiedmatrix. </summary>
        /// <param name="m">Specifies a pointer to 16 consecutive values, which are used as the elements of a 4x4 column-major matrix.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glLoadMatrix.xml" /></remarks>
        public static void LoadMatrixx(int* m) => GLPointers._glLoadMatrixx_fnptr(m);
        
        /// <summary> <b>[requires: v1.0] [glLogicOp]</b> Specify a logical pixel operation. </summary>
        /// <param name="opcode">Specifies a symbolic constant that selects a logical operation. The following symbols are accepted: GL_CLEAR, GL_SET, GL_COPY, GL_COPY_INVERTED, GL_NOOP, GL_INVERT, GL_AND, GL_NAND, GL_OR, GL_NOR, GL_XOR, GL_EQUIV, GL_AND_REVERSE, GL_AND_INVERTED, GL_OR_REVERSE, and GL_OR_INVERTED. The initial value is GL_COPY.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glLogicOp.xml" /></remarks>
        public static void LogicOp(LogicOp opcode) => GLPointers._glLogicOp_fnptr((uint)opcode);
        
        /// <summary> <b>[requires: v1.0] [glMaterialx]</b> Specify material parameters for the lighting model. </summary>
        /// <param name="face">Specifies which face or faces are being updated. Must be GL_FRONT_AND_BACK.</param>
        /// <param name="pname">Specifies the single-valued material parameter of the face or faces that is being updated. Must be GL_SHININESS.</param>
        /// <param name="param">Specifies the value that parameter GL_SHININESS will be set to.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glMaterial.xml" /></remarks>
        public static void Materialx(TriangleFace face, MaterialParameter pname, int param) => GLPointers._glMaterialx_fnptr((uint)face, (uint)pname, param);
        
        /// <summary> <b>[requires: v1.0] [glMaterialxv]</b>  </summary>
        public static void Materialxv(TriangleFace face, MaterialParameter pname, int* param) => GLPointers._glMaterialxv_fnptr((uint)face, (uint)pname, param);
        
        /// <summary> <b>[requires: v1.0] [glMatrixMode]</b> Specify which matrix is the current matrix. </summary>
        /// <param name="mode"> Specifies which matrix stack is the target for subsequent matrix operations. These values are accepted: GL_MODELVIEW, GL_PROJECTION, and GL_TEXTURE., and GL_MATRIX_PALETTE_OES. The initial value is GL_MODELVIEW. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glMatrixMode.xml" /></remarks>
        public static void MatrixMode(MatrixMode mode) => GLPointers._glMatrixMode_fnptr((uint)mode);
        
        /// <summary> <b>[requires: v1.0] [glMultMatrixx]</b> Multiply the current matrix with the specifiedmatrix. </summary>
        /// <param name="m">Points to 16 consecutive values that are used as the elements of a 4x4 column-major matrix.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glMultMatrix.xml" /></remarks>
        public static void MultMatrixx(int* m) => GLPointers._glMultMatrixx_fnptr(m);
        
        /// <summary> <b>[requires: v1.0] [glMultiTexCoord4x]</b> Set the current texture coordinates. </summary>
        /// <param name="target">Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least twoone. Symbolic constant must be one of GL_TEXTUREi, where i ranges from 0 to GL_MAX_TEXTURE_UNITS - 1, which is an implementation-dependent value.</param>
        /// <param name="s">Specify s, t, r, and q texture coordinates for target texture unit.</param>
        /// <param name="t">Specify s, t, r, and q texture coordinates for target texture unit.</param>
        /// <param name="r">Specify s, t, r, and q texture coordinates for target texture unit.</param>
        /// <param name="q">Specify s, t, r, and q texture coordinates for target texture unit.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glMultiTexCoord.xml" /></remarks>
        public static void MultiTexCoord4x(TextureUnit texture, int s, int t, int r, int q) => GLPointers._glMultiTexCoord4x_fnptr((uint)texture, s, t, r, q);
        
        /// <summary> <b>[requires: v1.0] [glNormal3x]</b> Set the current normal vector. </summary>
        /// <param name="nx">Specify the x, y, and z coordinates of the new current normal. The initial value is (0, 0, 1).</param>
        /// <param name="ny">Specify the x, y, and z coordinates of the new current normal. The initial value is (0, 0, 1).</param>
        /// <param name="nz">Specify the x, y, and z coordinates of the new current normal. The initial value is (0, 0, 1).</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glNormal.xml" /></remarks>
        public static void Normal3x(int nx, int ny, int nz) => GLPointers._glNormal3x_fnptr(nx, ny, nz);
        
        /// <summary> <b>[requires: v1.0] [glNormalPointer]</b> Define an array of normals. </summary>
        /// <param name="type">Specifies the data type of each coordinate in the array. Symbolic constants GL_BYTE, GL_SHORT, and GL_FIXED are accepted. However, the initial value is GL_FLOAT.</param>
        /// <param name="stride">Specifies the byte offset between consecutive normals. If stride is 0, the normals are understood to be tightly packed in the array. The initial value is 0.</param>
        /// <param name="pointer">Specifies a pointer to the first coordinate of the first normal in the array. The initial value is 0.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glNormalPointer.xml" /></remarks>
        public static void NormalPointer(NormalPointerType type, int stride, void* pointer) => GLPointers._glNormalPointer_fnptr((uint)type, stride, pointer);
        
        /// <summary> <b>[requires: v1.0] [glOrthox]</b> Multiply the current matrix with an orthographicmatrix. </summary>
        /// <param name="left">Specify the coordinates for the left and right vertical clipping planes.</param>
        /// <param name="right">Specify the coordinates for the left and right vertical clipping planes.</param>
        /// <param name="bottom">Specify the coordinates for the bottom and top horizontal clipping planes.</param>
        /// <param name="top">Specify the coordinates for the bottom and top horizontal clipping planes.</param>
        /// <param name="near">Specify the distances to the nearer and farther depth clipping planes. These values are negative if the plane is to be behind the viewer.</param>
        /// <param name="far">Specify the distances to the nearer and farther depth clipping planes. These values are negative if the plane is to be behind the viewer.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glOrtho.xml" /></remarks>
        public static void Orthox(int l, int r, int b, int t, int n, int f) => GLPointers._glOrthox_fnptr(l, r, b, t, n, f);
        
        /// <summary> <b>[requires: v1.0] [glPixelStorei]</b> Set pixel storage modes. </summary>
        /// <param name="pname">Specifies the symbolic name of the parameter to be set. GL_PACK_ALIGNMENT affects the packing of pixel data into memory. GL_UNPACK_ALIGNMENT affects the unpacking of pixel data from memory.</param>
        /// <param name="param">Specifies the value that pname is set to.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glPixelStorei.xml" /></remarks>
        public static void PixelStorei(PixelStoreParameter pname, int param) => GLPointers._glPixelStorei_fnptr((uint)pname, param);
        
        /// <summary> <b>[requires: v1.0] [glPointParameterx]</b> Specify parameters for point rasterization. </summary>
        /// <param name="pname"> Specifies the single-valued parameter to be updated. Can be either GL_POINT_SIZE_MIN, GL_POINT_SIZE_MAX, or GL_POINT_FADE_THRESHOLD_SIZE. </param>
        /// <param name="param"> Specifies the value that the parameter will be set to. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glPointParameter.xml" /></remarks>
        public static void PointParameterx(PointParameterNameARB pname, int param) => GLPointers._glPointParameterx_fnptr((uint)pname, param);
        
        /// <summary> <b>[requires: v1.0] [glPointParameterxv]</b>  </summary>
        public static void PointParameterxv(PointParameterNameARB pname, int* parameters) => GLPointers._glPointParameterxv_fnptr((uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0] [glPointSizex]</b> Specify the diameter of rasterized points. </summary>
        /// <param name="size">Specifies the diameter of rasterized points. The initial value is 1.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glPointSize.xml" /></remarks>
        public static void PointSizex(int size) => GLPointers._glPointSizex_fnptr(size);
        
        /// <summary> <b>[requires: v1.0] [glPolygonOffsetx]</b> Set the scale and units used to calculate depth        values. </summary>
        /// <param name="factor">Specifies a scale factor that is used to create a variable depth offset for each polygon. The initial value is 0.</param>
        /// <param name="units">Is multiplied by an implementation-specific value to create a constant depth offset. The initial value is 0.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glPolygonOffset.xml" /></remarks>
        public static void PolygonOffsetx(int factor, int units) => GLPointers._glPolygonOffsetx_fnptr(factor, units);
        
        /// <summary> <b>[requires: v1.0] [glPopMatrix]</b> Push and pop the current matrix stack. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glPushMatrix.xml" /></remarks>
        public static void PopMatrix() => GLPointers._glPopMatrix_fnptr();
        
        /// <summary> <b>[requires: v1.0] [glPushMatrix]</b> Push and pop the current matrix stack. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glPushMatrix.xml" /></remarks>
        public static void PushMatrix() => GLPointers._glPushMatrix_fnptr();
        
        /// <summary> <b>[requires: v1.0] [glReadPixels]</b> Read a block of pixels from the color buffer. </summary>
        /// <param name="x">Specify the window coordinates of the first pixel that is read from the color buffer. This location is the lower left corner of a rectangular block of pixels.</param>
        /// <param name="y">Specify the window coordinates of the first pixel that is read from the color buffer. This location is the lower left corner of a rectangular block of pixels.</param>
        /// <param name="width">Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.</param>
        /// <param name="height">Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.</param>
        /// <param name="format">Specifies the format of the pixel data. Must be either GL_RGBA or the value of GL_IMPLEMENTATION_COLOR_READ_FORMAT_OES.</param>
        /// <param name="type">Specifies the data type of the pixel data. Must be either GL_UNSIGNED_BYTE or the value of GL_IMPLEMENTATION_COLOR_READ_TYPE_OES.</param>
        /// <param name="pixels">Returns the pixel data.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glReadPixels.xml" /></remarks>
        public static void ReadPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, void* pixels) => GLPointers._glReadPixels_fnptr(x, y, width, height, (uint)format, (uint)type, pixels);
        
        /// <summary> <b>[requires: v1.0] [glRotatex]</b> Multiply the current matrix by a rotation matrix. </summary>
        /// <param name="angle">Specifies the angle of rotation, in degrees.</param>
        /// <param name="x">Specify the x, y, and z coordinates of a vector, respectively.</param>
        /// <param name="y">Specify the x, y, and z coordinates of a vector, respectively.</param>
        /// <param name="z">Specify the x, y, and z coordinates of a vector, respectively.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glRotate.xml" /></remarks>
        public static void Rotatex(int angle, int x, int y, int z) => GLPointers._glRotatex_fnptr(angle, x, y, z);
        
        /// <summary> <b>[requires: v1.0] [glSampleCoverage]</b> Specify mask to modify multisampled pixel fragments. </summary>
        /// <param name="value">Specifies the coverage of the modification mask. The value is clamped to the range [0, 1], where 0 represents no coverage and 1 full coverage. The initial value is 1.</param>
        /// <param name="invert">Specifies whether the modification mask implied by value is inverted or not. The initial value is GL_FALSE. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glSampleCoverage.xml" /></remarks>
        public static void SampleCoverage(float value, bool invert) => GLPointers._glSampleCoverage_fnptr(value, (byte)(invert ? 1 : 0));
        
        /// <summary> <b>[requires: v1.0] [glSampleCoveragex]</b> Specify mask to modify multisampled pixel fragments. </summary>
        /// <param name="value">Specifies the coverage of the modification mask. The value is clamped to the range [0, 1], where 0 represents no coverage and 1 full coverage. The initial value is 1.</param>
        /// <param name="invert">Specifies whether the modification mask implied by value is inverted or not. The initial value is GL_FALSE. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glSampleCoverage.xml" /></remarks>
        public static void SampleCoveragex(int value, bool invert) => GLPointers._glSampleCoveragex_fnptr(value, (byte)(invert ? 1 : 0));
        
        /// <summary> <b>[requires: v1.0] [glScalex]</b> Multiply the current matrix by a general scalingmatrix. </summary>
        /// <param name="x">Specify scale factors along the x, y, and z axes, respectively.</param>
        /// <param name="y">Specify scale factors along the x, y, and z axes, respectively.</param>
        /// <param name="z">Specify scale factors along the x, y, and z axes, respectively.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glScale.xml" /></remarks>
        public static void Scalex(int x, int y, int z) => GLPointers._glScalex_fnptr(x, y, z);
        
        /// <summary> <b>[requires: v1.0] [glScissor]</b> Define the scissor box. </summary>
        /// <param name="x">Specify the lower left corner of the scissor box, in pixels. The initial value is (0, 0).</param>
        /// <param name="y">Specify the lower left corner of the scissor box, in pixels. The initial value is (0, 0).</param>
        /// <param name="width">Specify the width and height of the scissor box. When a GL context is first attached to a surface (e.g. window), width and height are set to the dimensions of that surface.</param>
        /// <param name="height">Specify the width and height of the scissor box. When a GL context is first attached to a surface (e.g. window), width and height are set to the dimensions of that surface.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glScissor.xml" /></remarks>
        public static void Scissor(int x, int y, int width, int height) => GLPointers._glScissor_fnptr(x, y, width, height);
        
        /// <summary> <b>[requires: v1.0] [glShadeModel]</b> Select flat or smooth shading. </summary>
        /// <param name="mode">Specifies a symbolic value representing a shading technique. Accepted values are GL_FLAT and GL_SMOOTH. The initial value is GL_SMOOTH.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glShadeModel.xml" /></remarks>
        public static void ShadeModel(ShadingModel mode) => GLPointers._glShadeModel_fnptr((uint)mode);
        
        /// <summary> <b>[requires: v1.0] [glStencilFunc]</b> Set function and reference value for stencil        testing. </summary>
        /// <param name="func">Specifies the test function. Eight tokens are valid: GL_NEVER, GL_LESS, GL_LEQUAL, GL_GREATER, GL_GEQUAL, GL_EQUAL, GL_NOTEQUAL, and GL_ALWAYS. The initial value is GL_ALWAYS.</param>
        /// <param name="reference">Specifies the reference value for the stencil test. ref is clamped to the range [ 0 , 2n-1 ] , where n is the number of bitplanes in the stencil buffer. The initial value is 0.</param>
        /// <param name="mask">Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The initial value is all 1&apos;s.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glStencilFunc.xml" /></remarks>
        public static void StencilFunc(StencilFunction func, int reference, uint mask) => GLPointers._glStencilFunc_fnptr((uint)func, reference, mask);
        
        /// <summary> <b>[requires: v1.0] [glStencilMask]</b> Control the writing of individual bits in the        stencil planes. </summary>
        /// <param name="mask">Specifies a bit mask to enable and disable writing of individual bits in the stencil planes. The initial value is all 1&apos;s.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glStencilMask.xml" /></remarks>
        public static void StencilMask(uint mask) => GLPointers._glStencilMask_fnptr(mask);
        
        /// <summary> <b>[requires: v1.0] [glStencilOp]</b> Set stencil test actions. </summary>
        /// <param name="fail">Specifies the action to take when the stencil test fails. Six symbolic constants are accepted: GL_KEEP, GL_ZERO, GL_REPLACE, GL_INCR, GL_DECR, and GL_INVERT. The initial value is GL_KEEP.</param>
        /// <param name="zfail">Specifies the stencil action when the stencil test passes, but the depth test fails. zfail accepts the same symbolic constants as fail. The initial value is GL_KEEP.</param>
        /// <param name="zpass">Specifies the stencil action when both the stencil test and the depth test pass, or when the stencil test passes and either there is no depth buffer or depth testing is not enabled. zpass accepts the same symbolic constants as fail. The initial value is GL_KEEP.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glStencilOp.xml" /></remarks>
        public static void StencilOp(StencilOp fail, StencilOp zfail, StencilOp zpass) => GLPointers._glStencilOp_fnptr((uint)fail, (uint)zfail, (uint)zpass);
        
        /// <summary> <b>[requires: v1.0] [glTexCoordPointer]</b> Define an array of texture coordinates. </summary>
        /// <param name="size">Specifies the number of coordinates per array element. Must be 2, 3 or 4. The initial value is 4.</param>
        /// <param name="type">Specifies the data type of each texture coordinate. Symbolic constants GL_BYTE, GL_SHORT, and GL_FIXED are accepted. However, the initial value is GL_FLOAT.</param>
        /// <param name="stride">Specifies the byte offset between consecutive array elements. If stride is 0, the array elements are understood to be tightly packed. The initial value is 0.</param>
        /// <param name="pointer">Specifies a pointer to the first coordinate of the first element in the array. The initial value is 0.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glTexCoordPointer.xml" /></remarks>
        public static void TexCoordPointer(int size, TexCoordPointerType type, int stride, void* pointer) => GLPointers._glTexCoordPointer_fnptr(size, (uint)type, stride, pointer);
        
        /// <summary> <b>[requires: v1.0] [glTexEnvi]</b> Set texture environment parameters. </summary>
        /// <param name="target"> Specifies a texture environment. May be GL_TEXTURE_ENV or GL_POINT_SPRITE_OES. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture environment parameter. May be either GL_TEXTURE_ENV_MODE, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE_OES. </param>
        /// <param name="param"> Specifies a single symbolic constant, one of GL_ADD, GL_ADD_SIGNED, GL_DOT3_RGB, GL_DOT3_RGBA, GL_INTERPOLATE, GL_MODULATE, GL_DECAL, GL_BLEND, GL_REPLACE, GL_SUBTRACT, GL_COMBINE, GL_TEXTURE, GL_CONSTANT, GL_PRIMARY_COLOR, GL_PREVIOUS, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, a single boolean value for the point sprite texture coordinate replacement, or 1.0, 2.0, or 4.0 when specifying the GL_RGB_SCALE or GL_ALPHA_SCALE. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glTexEnv.xml" /></remarks>
        public static void TexEnvi(TextureEnvTarget target, TextureEnvParameter pname, int param) => GLPointers._glTexEnvi_fnptr((uint)target, (uint)pname, param);
        
        /// <summary> <b>[requires: v1.0] [glTexEnvx]</b> Set texture environment parameters. </summary>
        /// <param name="target"> Specifies a texture environment. May be GL_TEXTURE_ENV or GL_POINT_SPRITE_OES. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture environment parameter. May be either GL_TEXTURE_ENV_MODE, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE_OES. </param>
        /// <param name="param"> Specifies a single symbolic constant, one of GL_ADD, GL_ADD_SIGNED, GL_DOT3_RGB, GL_DOT3_RGBA, GL_INTERPOLATE, GL_MODULATE, GL_DECAL, GL_BLEND, GL_REPLACE, GL_SUBTRACT, GL_COMBINE, GL_TEXTURE, GL_CONSTANT, GL_PRIMARY_COLOR, GL_PREVIOUS, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, a single boolean value for the point sprite texture coordinate replacement, or 1.0, 2.0, or 4.0 when specifying the GL_RGB_SCALE or GL_ALPHA_SCALE. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glTexEnv.xml" /></remarks>
        public static void TexEnvx(TextureEnvTarget target, TextureEnvParameter pname, int param) => GLPointers._glTexEnvx_fnptr((uint)target, (uint)pname, param);
        
        /// <summary> <b>[requires: v1.0] [glTexEnviv]</b>  </summary>
        public static void TexEnviv(TextureEnvTarget target, TextureEnvParameter pname, int* parameters) => GLPointers._glTexEnviv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0] [glTexEnvxv]</b>  </summary>
        public static void TexEnvxv(TextureEnvTarget target, TextureEnvParameter pname, int* parameters) => GLPointers._glTexEnvxv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0] [glTexImage2D]</b> Specify a two-dimensional texture image. </summary>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_2D.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. Must be greater or equal 0.</param>
        /// <param name="internalformat">Specifies the color components in the texture. Must be same as format. The following symbolic values are accepted: GL_ALPHA, GL_RGB, GL_RGBA, GL_LUMINANCE, or GL_LUMINANCE_ALPHA.</param>
        /// <param name="width">Specifies the width of the texture image. Must be 2n for some integer n. All implementations support texture images that are at least 64 texels wide.</param>
        /// <param name="height">Specifies the height of the texture image. Must be 2m for some integer m. All implementations support texture images that are at least 64 texels high.</param>
        /// <param name="border">Specifies the width of the border. Must be 0.</param>
        /// <param name="format">Specifies the format of the pixel data. Must be same as internalformat. The following symbolic values are accepted: GL_ALPHA, GL_RGB, GL_RGBA, GL_LUMINANCE, and GL_LUMINANCE_ALPHA.</param>
        /// <param name="type">Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_4_4_4_4, and GL_UNSIGNED_SHORT_5_5_5_1.</param>
        /// <param name="pixels">Specifies a pointer to the image data in memory.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glTexImage2D.xml" /></remarks>
        public static void TexImage2D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTexImage2D_fnptr((uint)target, level, (int)internalformat, width, height, border, (uint)format, (uint)type, pixels);
        
        /// <summary> <b>[requires: v1.0] [glTexParameteri]</b> Set texture parameters. </summary>
        /// <param name="target">Specifies the target texture, which must be GL_TEXTURE_2D.</param>
        /// <param name="pname">Specifies the symbolic name of a single-valued texture parameter. Which can be one of the following: GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_GENERATE_MIPMAP.</param>
        /// <param name="param">Specifies the value of pname.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glTexParameter.xml" /></remarks>
        public static void TexParameteri(TextureTarget target, TextureParameterName pname, int param) => GLPointers._glTexParameteri_fnptr((uint)target, (uint)pname, param);
        
        /// <summary> <b>[requires: v1.0] [glTexParameterx]</b> Set texture parameters. </summary>
        /// <param name="target">Specifies the target texture, which must be GL_TEXTURE_2D.</param>
        /// <param name="pname">Specifies the symbolic name of a single-valued texture parameter. Which can be one of the following: GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_GENERATE_MIPMAP.</param>
        /// <param name="param">Specifies the value of pname.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glTexParameter.xml" /></remarks>
        public static void TexParameterx(TextureTarget target, GetTextureParameter pname, int param) => GLPointers._glTexParameterx_fnptr((uint)target, (uint)pname, param);
        
        /// <summary> <b>[requires: v1.0] [glTexParameteriv]</b>  </summary>
        public static void TexParameteriv(TextureTarget target, TextureParameterName pname, int* parameters) => GLPointers._glTexParameteriv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0] [glTexParameterxv]</b>  </summary>
        public static void TexParameterxv(TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._glTexParameterxv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0] [glTexSubImage2D]</b> Specify a two-dimensional texture subimage. </summary>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_2D.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="yoffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="format">Specifies the of the pixel data. The following symbolic values are accepted: GL_ALPHA, GL_RGB, GL_RGBA, GL_LUMINANCE, and GL_LUMINANCE_ALPHA.</param>
        /// <param name="type">Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_4_4_4_4, and GL_UNSIGNED_SHORT_5_5_5_1.</param>
        /// <param name="pixels">Specifies a pointer to the image data in memory.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glTexSubImage2D.xml" /></remarks>
        public static void TexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTexSubImage2D_fnptr((uint)target, level, xoffset, yoffset, width, height, (uint)format, (uint)type, pixels);
        
        /// <summary> <b>[requires: v1.0] [glTranslatex]</b> Multiply the current matrix by a translation matrix. </summary>
        /// <param name="x">Specify the x, y, and z coordinates of a translation vector.</param>
        /// <param name="y">Specify the x, y, and z coordinates of a translation vector.</param>
        /// <param name="z">Specify the x, y, and z coordinates of a translation vector.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glTranslate.xml" /></remarks>
        public static void Translatex(int x, int y, int z) => GLPointers._glTranslatex_fnptr(x, y, z);
        
        /// <summary> <b>[requires: v1.0] [glVertexPointer]</b> Define an array of vertex coordinates. </summary>
        /// <param name="size">Specifies the number of coordinates per vertex. Must be 2, 3, or 4. The initial value is 4.</param>
        /// <param name="type">Specifies the data type of each vertex coordinate in the array. Symbolic constants GL_BYTE, GL_SHORT, and GL_FIXED, are accepted. However, the initial value is GL_FLOAT.</param>
        /// <param name="stride">Specifies the byte offset between consecutive vertices. If stride is 0, the vertices are understood to be tightly packed in the array. The initial value is 0.</param>
        /// <param name="pointer">Specifies a pointer to the first coordinate of the first vertex in the array. The initial value is 0.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glVertexPointer.xml" /></remarks>
        public static void VertexPointer(int size, VertexPointerType type, int stride, void* pointer) => GLPointers._glVertexPointer_fnptr(size, (uint)type, stride, pointer);
        
        /// <summary> <b>[requires: v1.0] [glViewport]</b> Set the viewport. </summary>
        /// <param name="x">Specify the lower left corner of the viewport rectangle, in pixels. The initial value is (0, 0).</param>
        /// <param name="y">Specify the lower left corner of the viewport rectangle, in pixels. The initial value is (0, 0).</param>
        /// <param name="width">Specify the width and height of the viewport. When a GL context is first attached to a surface (e.g. window), width and height are set to the dimensions of that surface.</param>
        /// <param name="height">Specify the width and height of the viewport. When a GL context is first attached to a surface (e.g. window), width and height are set to the dimensions of that surface.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glViewport.xml" /></remarks>
        public static void Viewport(int x, int y, int width, int height) => GLPointers._glViewport_fnptr(x, y, width, height);
        
        /// <summary>APPLE extensions.</summary>
        public static unsafe partial class APPLE
        {
            /// <summary> <b>[requires: GL_APPLE_copy_texture_levels] [glCopyTextureLevelsAPPLE]</b>  </summary>
            public static void CopyTextureLevels(uint destinationTexture, uint sourceTexture, int sourceBaseLevel, int sourceLevelCount) => GLPointers._glCopyTextureLevelsAPPLE_fnptr(destinationTexture, sourceTexture, sourceBaseLevel, sourceLevelCount);
            
            /// <summary> <b>[requires: GL_APPLE_framebuffer_multisample] [glRenderbufferStorageMultisampleAPPLE]</b>  </summary>
            public static void RenderbufferStorageMultisample(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => GLPointers._glRenderbufferStorageMultisampleAPPLE_fnptr((uint)target, samples, (uint)internalformat, width, height);
            
            /// <summary> <b>[requires: GL_APPLE_framebuffer_multisample] [glResolveMultisampleFramebufferAPPLE]</b>  </summary>
            public static void ResolveMultisampleFramebuffer() => GLPointers._glResolveMultisampleFramebufferAPPLE_fnptr();
            
            /// <summary> <b>[requires: GL_APPLE_sync] [glFenceSyncAPPLE]</b>  </summary>
            public static GLSync FenceSync(SyncCondition condition, SyncBehaviorFlags flags) => (GLSync) GLPointers._glFenceSyncAPPLE_fnptr((uint)condition, (uint)flags);
            
            /// <summary> <b>[requires: GL_APPLE_sync] [glIsSyncAPPLE]</b>  </summary>
            public static bool IsSync(GLSync sync) => GLPointers._glIsSyncAPPLE_fnptr((IntPtr)sync) != 0;
            
            /// <summary> <b>[requires: GL_APPLE_sync] [glDeleteSyncAPPLE]</b>  </summary>
            public static void DeleteSync(GLSync sync) => GLPointers._glDeleteSyncAPPLE_fnptr((IntPtr)sync);
            
            /// <summary> <b>[requires: GL_APPLE_sync] [glClientWaitSyncAPPLE]</b>  </summary>
            public static SyncStatus ClientWaitSync(GLSync sync, SyncObjectMask flags, ulong timeout) => (SyncStatus) GLPointers._glClientWaitSyncAPPLE_fnptr((IntPtr)sync, (uint)flags, timeout);
            
            /// <summary> <b>[requires: GL_APPLE_sync] [glWaitSyncAPPLE]</b>  </summary>
            public static void WaitSync(GLSync sync, SyncBehaviorFlags flags, ulong timeout) => GLPointers._glWaitSyncAPPLE_fnptr((IntPtr)sync, (uint)flags, timeout);
            
            /// <summary> <b>[requires: GL_APPLE_sync] [glGetInteger64vAPPLE]</b>  </summary>
            public static void GetInteger64v(GetPName pname, long* parameters) => GLPointers._glGetInteger64vAPPLE_fnptr((uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_APPLE_sync] [glGetSyncivAPPLE]</b>  </summary>
            public static void GetSynciv(GLSync sync, SyncParameterName pname, int count, int* length, int* values) => GLPointers._glGetSyncivAPPLE_fnptr((IntPtr)sync, (uint)pname, count, length, values);
            
        }
        /// <summary>EXT extensions.</summary>
        public static unsafe partial class EXT
        {
            /// <summary> <b>[requires: GL_EXT_blend_minmax] [glBlendEquationEXT]</b>  </summary>
            public static void BlendEquation(BlendEquationModeEXT mode) => GLPointers._glBlendEquationEXT_fnptr((uint)mode);
            
            /// <summary> <b>[requires: GL_EXT_debug_marker] [glInsertEventMarkerEXT]</b>  </summary>
            public static void InsertEventMarker(int length, byte* marker) => GLPointers._glInsertEventMarkerEXT_fnptr(length, marker);
            
            /// <summary> <b>[requires: GL_EXT_debug_marker] [glPushGroupMarkerEXT]</b>  </summary>
            public static void PushGroupMarker(int length, byte* marker) => GLPointers._glPushGroupMarkerEXT_fnptr(length, marker);
            
            /// <summary> <b>[requires: GL_EXT_debug_marker] [glPopGroupMarkerEXT]</b>  </summary>
            public static void PopGroupMarker() => GLPointers._glPopGroupMarkerEXT_fnptr();
            
            /// <summary> <b>[requires: GL_EXT_discard_framebuffer] [glDiscardFramebufferEXT]</b>  </summary>
            public static void DiscardFramebuffer(FramebufferTarget target, int numAttachments, InvalidateFramebufferAttachment* attachments) => GLPointers._glDiscardFramebufferEXT_fnptr((uint)target, numAttachments, (uint*)attachments);
            
            /// <summary> <b>[requires: GL_EXT_map_buffer_range] [glMapBufferRangeEXT]</b>  </summary>
            public static void* MapBufferRange(BufferTargetARB target, IntPtr offset, nint length, MapBufferAccessMask access) => GLPointers._glMapBufferRangeEXT_fnptr((uint)target, offset, length, (uint)access);
            
            /// <summary> <b>[requires: GL_EXT_map_buffer_range] [glFlushMappedBufferRangeEXT]</b>  </summary>
            public static void FlushMappedBufferRange(BufferTargetARB target, IntPtr offset, nint length) => GLPointers._glFlushMappedBufferRangeEXT_fnptr((uint)target, offset, length);
            
            /// <summary> <b>[requires: GL_EXT_multi_draw_arrays] [glMultiDrawArraysEXT]</b>  </summary>
            public static void MultiDrawArrays(PrimitiveType mode, int* first, int* count, int primcount) => GLPointers._glMultiDrawArraysEXT_fnptr((uint)mode, first, count, primcount);
            
            /// <summary> <b>[requires: GL_EXT_multi_draw_arrays] [glMultiDrawElementsEXT]</b>  </summary>
            public static void MultiDrawElements(PrimitiveType mode, int* count, DrawElementsType type, void** indices, int primcount) => GLPointers._glMultiDrawElementsEXT_fnptr((uint)mode, count, (uint)type, indices, primcount);
            
            /// <summary> <b>[requires: GL_EXT_multisampled_render_to_texture] [glRenderbufferStorageMultisampleEXT]</b>  </summary>
            public static void RenderbufferStorageMultisample(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => GLPointers._glRenderbufferStorageMultisampleEXT_fnptr((uint)target, samples, (uint)internalformat, width, height);
            
            /// <summary> <b>[requires: GL_EXT_multisampled_render_to_texture] [glFramebufferTexture2DMultisampleEXT]</b>  </summary>
            public static void FramebufferTexture2DMultisample(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level, int samples) => GLPointers._glFramebufferTexture2DMultisampleEXT_fnptr((uint)target, (uint)attachment, (uint)textarget, texture, level, samples);
            
            /// <summary> <b>[requires: GL_EXT_robustness] [glGetGraphicsResetStatusEXT]</b>  </summary>
            public static GraphicsResetStatus GetGraphicsResetStatus() => (GraphicsResetStatus) GLPointers._glGetGraphicsResetStatusEXT_fnptr();
            
            /// <summary> <b>[requires: GL_EXT_robustness] [glReadnPixelsEXT]</b>  </summary>
            public static void ReadnPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data) => GLPointers._glReadnPixelsEXT_fnptr(x, y, width, height, (uint)format, (uint)type, bufSize, data);
            
            /// <summary> <b>[requires: GL_EXT_robustness] [glGetnUniformfvEXT]</b>  </summary>
            public static void GetnUniformfv(int program, int location, int bufSize, float* parameters) => GLPointers._glGetnUniformfvEXT_fnptr(program, location, bufSize, parameters);
            
            /// <summary> <b>[requires: GL_EXT_robustness] [glGetnUniformivEXT]</b>  </summary>
            public static void GetnUniformiv(int program, int location, int bufSize, int* parameters) => GLPointers._glGetnUniformivEXT_fnptr(program, location, bufSize, parameters);
            
            /// <summary> <b>[requires: GL_EXT_texture_storage] [glTexStorage1DEXT]</b>  </summary>
            public static void TexStorage1D(TextureTarget target, int levels, SizedInternalFormat internalformat, int width) => GLPointers._glTexStorage1DEXT_fnptr((uint)target, levels, (uint)internalformat, width);
            
            /// <summary> <b>[requires: GL_EXT_texture_storage] [glTexStorage2DEXT]</b>  </summary>
            public static void TexStorage2D(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height) => GLPointers._glTexStorage2DEXT_fnptr((uint)target, levels, (uint)internalformat, width, height);
            
            /// <summary> <b>[requires: GL_EXT_texture_storage] [glTexStorage3DEXT]</b>  </summary>
            public static void TexStorage3D(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height, int depth) => GLPointers._glTexStorage3DEXT_fnptr((uint)target, levels, (uint)internalformat, width, height, depth);
            
            /// <summary> <b>[requires: GL_EXT_texture_storage] [glTextureStorage1DEXT]</b>  </summary>
            public static void TextureStorage1D(int texture, All target, int levels, SizedInternalFormat internalformat, int width) => GLPointers._glTextureStorage1DEXT_fnptr(texture, (uint)target, levels, (uint)internalformat, width);
            
            /// <summary> <b>[requires: GL_EXT_texture_storage] [glTextureStorage2DEXT]</b>  </summary>
            public static void TextureStorage2D(int texture, All target, int levels, SizedInternalFormat internalformat, int width, int height) => GLPointers._glTextureStorage2DEXT_fnptr(texture, (uint)target, levels, (uint)internalformat, width, height);
            
            /// <summary> <b>[requires: GL_EXT_texture_storage] [glTextureStorage3DEXT]</b>  </summary>
            public static void TextureStorage3D(int texture, All target, int levels, SizedInternalFormat internalformat, int width, int height, int depth) => GLPointers._glTextureStorage3DEXT_fnptr(texture, (uint)target, levels, (uint)internalformat, width, height, depth);
            
        }
        /// <summary>IMG extensions.</summary>
        public static unsafe partial class IMG
        {
            /// <summary> <b>[requires: GL_IMG_multisampled_render_to_texture] [glRenderbufferStorageMultisampleIMG]</b>  </summary>
            public static void RenderbufferStorageMultisample(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => GLPointers._glRenderbufferStorageMultisampleIMG_fnptr((uint)target, samples, (uint)internalformat, width, height);
            
            /// <summary> <b>[requires: GL_IMG_multisampled_render_to_texture] [glFramebufferTexture2DMultisampleIMG]</b>  </summary>
            public static void FramebufferTexture2DMultisample(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level, int samples) => GLPointers._glFramebufferTexture2DMultisampleIMG_fnptr((uint)target, (uint)attachment, (uint)textarget, texture, level, samples);
            
            /// <summary> <b>[requires: GL_IMG_user_clip_plane] [glClipPlanefIMG]</b>  </summary>
            public static void ClipPlanef(ClipPlaneName p, float* eqn) => GLPointers._glClipPlanefIMG_fnptr((uint)p, eqn);
            
            /// <summary> <b>[requires: GL_IMG_user_clip_plane] [glClipPlanexIMG]</b>  </summary>
            public static void ClipPlanex(ClipPlaneName p, int* eqn) => GLPointers._glClipPlanexIMG_fnptr((uint)p, eqn);
            
        }
        /// <summary>KHR extensions.</summary>
        public static unsafe partial class KHR
        {
            /// <summary> <b>[requires: GL_KHR_debug] [glDebugMessageControl]</b>  </summary>
            public static void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, bool enabled) => GLPointers._glDebugMessageControl_fnptr((uint)source, (uint)type, (uint)severity, count, ids, (byte)(enabled ? 1 : 0));
            
            /// <summary> <b>[requires: GL_KHR_debug] [glDebugMessageInsert]</b>  </summary>
            public static void DebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* buf) => GLPointers._glDebugMessageInsert_fnptr((uint)source, (uint)type, id, (uint)severity, length, buf);
            
            /// <summary> <b>[requires: GL_KHR_debug] [glDebugMessageCallback]</b>  </summary>
            public static void DebugMessageCallback(IntPtr callback, void* userParam) => GLPointers._glDebugMessageCallback_fnptr(callback, userParam);
            
            /// <summary> <b>[requires: GL_KHR_debug] [glGetDebugMessageLog]</b>  </summary>
            public static uint GetDebugMessageLog(uint count, int bufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, byte* messageLog) => GLPointers._glGetDebugMessageLog_fnptr(count, bufSize, (uint*)sources, (uint*)types, ids, (uint*)severities, lengths, messageLog);
            
            /// <summary> <b>[requires: GL_KHR_debug] [glPushDebugGroup]</b>  </summary>
            public static void PushDebugGroup(DebugSource source, uint id, int length, byte* message) => GLPointers._glPushDebugGroup_fnptr((uint)source, id, length, message);
            
            /// <summary> <b>[requires: GL_KHR_debug] [glPopDebugGroup]</b>  </summary>
            public static void PopDebugGroup() => GLPointers._glPopDebugGroup_fnptr();
            
            /// <summary> <b>[requires: GL_KHR_debug] [glObjectLabel]</b>  </summary>
            public static void ObjectLabel(ObjectIdentifier identifier, uint name, int length, byte* label) => GLPointers._glObjectLabel_fnptr((uint)identifier, name, length, label);
            
            /// <summary> <b>[requires: GL_KHR_debug] [glGetObjectLabel]</b>  </summary>
            public static void GetObjectLabel(ObjectIdentifier identifier, uint name, int bufSize, int* length, byte* label) => GLPointers._glGetObjectLabel_fnptr((uint)identifier, name, bufSize, length, label);
            
            /// <summary> <b>[requires: GL_KHR_debug] [glObjectPtrLabel]</b>  </summary>
            public static void ObjectPtrLabel(void* ptr, int length, byte* label) => GLPointers._glObjectPtrLabel_fnptr(ptr, length, label);
            
            /// <summary> <b>[requires: GL_KHR_debug] [glGetObjectPtrLabel]</b>  </summary>
            public static void GetObjectPtrLabel(void* ptr, int bufSize, int* length, byte* label) => GLPointers._glGetObjectPtrLabel_fnptr(ptr, bufSize, length, label);
            
            /// <summary> <b>[requires: v1.0 | GL_KHR_debug] [glGetPointerv]</b> Return the address of the specified pointer. </summary>
            /// <param name="pname"> Specifies the array or buffer pointer to be returned. Accepted symbolic names are GL_COLOR_ARRAY_POINTER, GL_MATRIX_INDEX_ARRAY_POINTER_OES, GL_NORMAL_ARRAY_POINTER, GL_POINT_SIZE_ARRAY_POINTER_OES, GL_TEXTURE_COORD_ARRAY_POINTER, and GL_VERTEX_ARRAY_POINTER., and GL_WEIGHT_ARRAY_POINTER_OES. </param>
            /// <param name="parameters"> Returns the pointer value specified by pname. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetPointerv.xml" /></remarks>
            public static void GetPointerv(GetPointervPName pname, void** parameters) => GLPointers._glGetPointerv_fnptr((uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_KHR_debug] [glDebugMessageControlKHR]</b>  </summary>
            public static void DebugMessageControlKHR(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, bool enabled) => GLPointers._glDebugMessageControlKHR_fnptr((uint)source, (uint)type, (uint)severity, count, ids, (byte)(enabled ? 1 : 0));
            
            /// <summary> <b>[requires: GL_KHR_debug] [glDebugMessageInsertKHR]</b>  </summary>
            public static void DebugMessageInsertKHR(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* buf) => GLPointers._glDebugMessageInsertKHR_fnptr((uint)source, (uint)type, id, (uint)severity, length, buf);
            
            /// <summary> <b>[requires: GL_KHR_debug] [glDebugMessageCallbackKHR]</b>  </summary>
            public static void DebugMessageCallbackKHR(IntPtr callback, void* userParam) => GLPointers._glDebugMessageCallbackKHR_fnptr(callback, userParam);
            
            /// <summary> <b>[requires: GL_KHR_debug] [glGetDebugMessageLogKHR]</b>  </summary>
            public static uint GetDebugMessageLogKHR(uint count, int bufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, byte* messageLog) => GLPointers._glGetDebugMessageLogKHR_fnptr(count, bufSize, (uint*)sources, (uint*)types, ids, (uint*)severities, lengths, messageLog);
            
            /// <summary> <b>[requires: GL_KHR_debug] [glPushDebugGroupKHR]</b>  </summary>
            public static void PushDebugGroupKHR(DebugSource source, uint id, int length, byte* message) => GLPointers._glPushDebugGroupKHR_fnptr((uint)source, id, length, message);
            
            /// <summary> <b>[requires: GL_KHR_debug] [glPopDebugGroupKHR]</b>  </summary>
            public static void PopDebugGroupKHR() => GLPointers._glPopDebugGroupKHR_fnptr();
            
            /// <summary> <b>[requires: GL_KHR_debug] [glObjectLabelKHR]</b>  </summary>
            public static void ObjectLabelKHR(ObjectIdentifier identifier, uint name, int length, byte* label) => GLPointers._glObjectLabelKHR_fnptr((uint)identifier, name, length, label);
            
            /// <summary> <b>[requires: GL_KHR_debug] [glGetObjectLabelKHR]</b>  </summary>
            public static void GetObjectLabelKHR(All identifier, uint name, int bufSize, int* length, byte* label) => GLPointers._glGetObjectLabelKHR_fnptr((uint)identifier, name, bufSize, length, label);
            
            /// <summary> <b>[requires: GL_KHR_debug] [glObjectPtrLabelKHR]</b>  </summary>
            public static void ObjectPtrLabelKHR(void* ptr, int length, byte* label) => GLPointers._glObjectPtrLabelKHR_fnptr(ptr, length, label);
            
            /// <summary> <b>[requires: GL_KHR_debug] [glGetObjectPtrLabelKHR]</b>  </summary>
            public static void GetObjectPtrLabelKHR(void* ptr, int bufSize, int* length, byte* label) => GLPointers._glGetObjectPtrLabelKHR_fnptr(ptr, bufSize, length, label);
            
            /// <summary> <b>[requires: GL_KHR_debug] [glGetPointervKHR]</b>  </summary>
            public static void GetPointervKHR(All pname, void** parameters) => GLPointers._glGetPointervKHR_fnptr((uint)pname, parameters);
            
        }
        /// <summary>NV extensions.</summary>
        public static unsafe partial class NV
        {
            /// <summary> <b>[requires: GL_NV_fence] [glDeleteFencesNV]</b>  </summary>
            public static void DeleteFences(int n, uint* fences) => GLPointers._glDeleteFencesNV_fnptr(n, fences);
            
            /// <summary> <b>[requires: GL_NV_fence] [glGenFencesNV]</b>  </summary>
            public static void GenFences(int n, uint* fences) => GLPointers._glGenFencesNV_fnptr(n, fences);
            
            /// <summary> <b>[requires: GL_NV_fence] [glIsFenceNV]</b>  </summary>
            public static bool IsFence(uint fence) => GLPointers._glIsFenceNV_fnptr(fence) != 0;
            
            /// <summary> <b>[requires: GL_NV_fence] [glTestFenceNV]</b>  </summary>
            public static bool TestFence(uint fence) => GLPointers._glTestFenceNV_fnptr(fence) != 0;
            
            /// <summary> <b>[requires: GL_NV_fence] [glGetFenceivNV]</b>  </summary>
            public static void GetFenceiv(uint fence, FenceParameterNameNV pname, int* parameters) => GLPointers._glGetFenceivNV_fnptr(fence, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_NV_fence] [glFinishFenceNV]</b>  </summary>
            public static void FinishFence(uint fence) => GLPointers._glFinishFenceNV_fnptr(fence);
            
            /// <summary> <b>[requires: GL_NV_fence] [glSetFenceNV]</b>  </summary>
            public static void SetFence(uint fence, FenceConditionNV condition) => GLPointers._glSetFenceNV_fnptr(fence, (uint)condition);
            
        }
        /// <summary>OES extensions.</summary>
        public static unsafe partial class OES
        {
            /// <summary> <b>[requires: GL_OES_EGL_image] [glEGLImageTargetTexture2DOES]</b>  </summary>
            public static void EGLImageTargetTexture2D(All target, void* image) => GLPointers._glEGLImageTargetTexture2DOES_fnptr((uint)target, image);
            
            /// <summary> <b>[requires: GL_OES_EGL_image] [glEGLImageTargetRenderbufferStorageOES]</b>  </summary>
            public static void EGLImageTargetRenderbufferStorage(All target, void* image) => GLPointers._glEGLImageTargetRenderbufferStorageOES_fnptr((uint)target, image);
            
            /// <summary> <b>[requires: GL_OES_blend_equation_separate] [glBlendEquationSeparateOES]</b>  </summary>
            public static void BlendEquationSeparate(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => GLPointers._glBlendEquationSeparateOES_fnptr((uint)modeRGB, (uint)modeAlpha);
            
            /// <summary> <b>[requires: GL_OES_blend_func_separate] [glBlendFuncSeparateOES]</b>  </summary>
            public static void BlendFuncSeparate(BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha) => GLPointers._glBlendFuncSeparateOES_fnptr((uint)srcRGB, (uint)dstRGB, (uint)srcAlpha, (uint)dstAlpha);
            
            /// <summary> <b>[requires: GL_OES_blend_subtract] [glBlendEquationOES]</b>  </summary>
            public static void BlendEquation(BlendEquationModeEXT mode) => GLPointers._glBlendEquationOES_fnptr((uint)mode);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates] [glMultiTexCoord1bOES]</b>  </summary>
            public static void MultiTexCoord1b(TextureUnit texture, sbyte s) => GLPointers._glMultiTexCoord1bOES_fnptr((uint)texture, s);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates] [glMultiTexCoord1bvOES]</b>  </summary>
            public static void MultiTexCoord1bv(TextureUnit texture, sbyte* coords) => GLPointers._glMultiTexCoord1bvOES_fnptr((uint)texture, coords);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates] [glMultiTexCoord2bOES]</b>  </summary>
            public static void MultiTexCoord2b(TextureUnit texture, sbyte s, sbyte t) => GLPointers._glMultiTexCoord2bOES_fnptr((uint)texture, s, t);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates] [glMultiTexCoord2bvOES]</b>  </summary>
            public static void MultiTexCoord2bv(TextureUnit texture, sbyte* coords) => GLPointers._glMultiTexCoord2bvOES_fnptr((uint)texture, coords);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates] [glMultiTexCoord3bOES]</b>  </summary>
            public static void MultiTexCoord3b(TextureUnit texture, sbyte s, sbyte t, sbyte r) => GLPointers._glMultiTexCoord3bOES_fnptr((uint)texture, s, t, r);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates] [glMultiTexCoord3bvOES]</b>  </summary>
            public static void MultiTexCoord3bv(TextureUnit texture, sbyte* coords) => GLPointers._glMultiTexCoord3bvOES_fnptr((uint)texture, coords);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates] [glMultiTexCoord4bOES]</b>  </summary>
            public static void MultiTexCoord4b(TextureUnit texture, sbyte s, sbyte t, sbyte r, sbyte q) => GLPointers._glMultiTexCoord4bOES_fnptr((uint)texture, s, t, r, q);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates] [glMultiTexCoord4bvOES]</b>  </summary>
            public static void MultiTexCoord4bv(TextureUnit texture, sbyte* coords) => GLPointers._glMultiTexCoord4bvOES_fnptr((uint)texture, coords);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates] [glTexCoord1bOES]</b>  </summary>
            public static void TexCoord1b(sbyte s) => GLPointers._glTexCoord1bOES_fnptr(s);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates] [glTexCoord1bvOES]</b>  </summary>
            public static void TexCoord1bv(sbyte* coords) => GLPointers._glTexCoord1bvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates] [glTexCoord2bOES]</b>  </summary>
            public static void TexCoord2b(sbyte s, sbyte t) => GLPointers._glTexCoord2bOES_fnptr(s, t);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates] [glTexCoord2bvOES]</b>  </summary>
            public static void TexCoord2bv(sbyte* coords) => GLPointers._glTexCoord2bvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates] [glTexCoord3bOES]</b>  </summary>
            public static void TexCoord3b(sbyte s, sbyte t, sbyte r) => GLPointers._glTexCoord3bOES_fnptr(s, t, r);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates] [glTexCoord3bvOES]</b>  </summary>
            public static void TexCoord3bv(sbyte* coords) => GLPointers._glTexCoord3bvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates] [glTexCoord4bOES]</b>  </summary>
            public static void TexCoord4b(sbyte s, sbyte t, sbyte r, sbyte q) => GLPointers._glTexCoord4bOES_fnptr(s, t, r, q);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates] [glTexCoord4bvOES]</b>  </summary>
            public static void TexCoord4bv(sbyte* coords) => GLPointers._glTexCoord4bvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates] [glVertex2bOES]</b>  </summary>
            public static void Vertex2b(sbyte x, sbyte y) => GLPointers._glVertex2bOES_fnptr(x, y);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates] [glVertex2bvOES]</b>  </summary>
            public static void Vertex2bv(sbyte* coords) => GLPointers._glVertex2bvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates] [glVertex3bOES]</b>  </summary>
            public static void Vertex3b(sbyte x, sbyte y, sbyte z) => GLPointers._glVertex3bOES_fnptr(x, y, z);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates] [glVertex3bvOES]</b>  </summary>
            public static void Vertex3bv(sbyte* coords) => GLPointers._glVertex3bvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates] [glVertex4bOES]</b>  </summary>
            public static void Vertex4b(sbyte x, sbyte y, sbyte z, sbyte w) => GLPointers._glVertex4bOES_fnptr(x, y, z, w);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates] [glVertex4bvOES]</b>  </summary>
            public static void Vertex4bv(sbyte* coords) => GLPointers._glVertex4bvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_draw_texture] [glDrawTexsOES]</b> Draws a texture rectangle to the screen. </summary>
            /// <param name="x"> Specify the position of the affected screen rectangle. </param>
            /// <param name="y"> Specify the position of the affected screen rectangle. </param>
            /// <param name="z"> Specify the position of the affected screen rectangle. </param>
            /// <param name="width"> Specifies the width and height of the affected screen rectangle in pixels. </param>
            /// <param name="height"> Specifies the width and height of the affected screen rectangle in pixels. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glDrawTex.xml" /></remarks>
            public static void DrawTexs(short x, short y, short z, short width, short height) => GLPointers._glDrawTexsOES_fnptr(x, y, z, width, height);
            
            /// <summary> <b>[requires: GL_OES_draw_texture] [glDrawTexiOES]</b> Draws a texture rectangle to the screen. </summary>
            /// <param name="x"> Specify the position of the affected screen rectangle. </param>
            /// <param name="y"> Specify the position of the affected screen rectangle. </param>
            /// <param name="z"> Specify the position of the affected screen rectangle. </param>
            /// <param name="width"> Specifies the width and height of the affected screen rectangle in pixels. </param>
            /// <param name="height"> Specifies the width and height of the affected screen rectangle in pixels. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glDrawTex.xml" /></remarks>
            public static void DrawTexi(int x, int y, int z, int width, int height) => GLPointers._glDrawTexiOES_fnptr(x, y, z, width, height);
            
            /// <summary> <b>[requires: GL_OES_draw_texture] [glDrawTexxOES]</b> Draws a texture rectangle to the screen. </summary>
            /// <param name="x"> Specify the position of the affected screen rectangle. </param>
            /// <param name="y"> Specify the position of the affected screen rectangle. </param>
            /// <param name="z"> Specify the position of the affected screen rectangle. </param>
            /// <param name="width"> Specifies the width and height of the affected screen rectangle in pixels. </param>
            /// <param name="height"> Specifies the width and height of the affected screen rectangle in pixels. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glDrawTex.xml" /></remarks>
            public static void DrawTexx(int x, int y, int z, int width, int height) => GLPointers._glDrawTexxOES_fnptr(x, y, z, width, height);
            
            /// <summary> <b>[requires: GL_OES_draw_texture] [glDrawTexsvOES]</b>  </summary>
            public static void DrawTexsv(short* coords) => GLPointers._glDrawTexsvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_draw_texture] [glDrawTexivOES]</b>  </summary>
            public static void DrawTexiv(int* coords) => GLPointers._glDrawTexivOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_draw_texture] [glDrawTexxvOES]</b>  </summary>
            public static void DrawTexxv(int* coords) => GLPointers._glDrawTexxvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_draw_texture] [glDrawTexfOES]</b> Draws a texture rectangle to the screen. </summary>
            /// <param name="x"> Specify the position of the affected screen rectangle. </param>
            /// <param name="y"> Specify the position of the affected screen rectangle. </param>
            /// <param name="z"> Specify the position of the affected screen rectangle. </param>
            /// <param name="width"> Specifies the width and height of the affected screen rectangle in pixels. </param>
            /// <param name="height"> Specifies the width and height of the affected screen rectangle in pixels. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glDrawTex.xml" /></remarks>
            public static void DrawTexf(float x, float y, float z, float width, float height) => GLPointers._glDrawTexfOES_fnptr(x, y, z, width, height);
            
            /// <summary> <b>[requires: GL_OES_draw_texture] [glDrawTexfvOES]</b>  </summary>
            public static void DrawTexfv(float* coords) => GLPointers._glDrawTexfvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glAlphaFuncxOES]</b>  </summary>
            public static void AlphaFuncx(AlphaFunction func, int reference) => GLPointers._glAlphaFuncxOES_fnptr((uint)func, reference);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glClearColorxOES]</b>  </summary>
            public static void ClearColorx(int red, int green, int blue, int alpha) => GLPointers._glClearColorxOES_fnptr(red, green, blue, alpha);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glClearDepthxOES]</b>  </summary>
            public static void ClearDepthx(int depth) => GLPointers._glClearDepthxOES_fnptr(depth);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glClipPlanexOES]</b>  </summary>
            public static void ClipPlanex(ClipPlaneName plane, int* equation) => GLPointers._glClipPlanexOES_fnptr((uint)plane, equation);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glColor4xOES]</b>  </summary>
            public static void Color4x(int red, int green, int blue, int alpha) => GLPointers._glColor4xOES_fnptr(red, green, blue, alpha);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glDepthRangexOES]</b>  </summary>
            public static void DepthRangex(int n, int f) => GLPointers._glDepthRangexOES_fnptr(n, f);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glFogxOES]</b>  </summary>
            public static void Fogx(FogPName pname, int param) => GLPointers._glFogxOES_fnptr((uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glFogxvOES]</b>  </summary>
            public static void Fogxv(FogPName pname, int* param) => GLPointers._glFogxvOES_fnptr((uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glFrustumxOES]</b>  </summary>
            public static void Frustumx(int l, int r, int b, int t, int n, int f) => GLPointers._glFrustumxOES_fnptr(l, r, b, t, n, f);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glGetClipPlanexOES]</b>  </summary>
            public static void GetClipPlanex(ClipPlaneName plane, int* equation) => GLPointers._glGetClipPlanexOES_fnptr((uint)plane, equation);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glGetFixedvOES]</b>  </summary>
            public static void GetFixedv(GetPName pname, int* parameters) => GLPointers._glGetFixedvOES_fnptr((uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glGetTexEnvxvOES]</b>  </summary>
            public static void GetTexEnvxv(TextureEnvTarget target, TextureEnvParameter pname, int* parameters) => GLPointers._glGetTexEnvxvOES_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glGetTexParameterxvOES]</b>  </summary>
            public static void GetTexParameterxv(TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._glGetTexParameterxvOES_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glLightModelxOES]</b>  </summary>
            public static void LightModelx(LightModelParameter pname, int param) => GLPointers._glLightModelxOES_fnptr((uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glLightModelxvOES]</b>  </summary>
            public static void LightModelxv(LightModelParameter pname, int* param) => GLPointers._glLightModelxvOES_fnptr((uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glLightxOES]</b>  </summary>
            public static void Lightx(LightName light, LightParameter pname, int param) => GLPointers._glLightxOES_fnptr((uint)light, (uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glLightxvOES]</b>  </summary>
            public static void Lightxv(LightName light, LightParameter pname, int* parameters) => GLPointers._glLightxvOES_fnptr((uint)light, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glLineWidthxOES]</b>  </summary>
            public static void LineWidthx(int width) => GLPointers._glLineWidthxOES_fnptr(width);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glLoadMatrixxOES]</b>  </summary>
            public static void LoadMatrixx(int* m) => GLPointers._glLoadMatrixxOES_fnptr(m);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glMaterialxOES]</b>  </summary>
            public static void Materialx(TriangleFace face, MaterialParameter pname, int param) => GLPointers._glMaterialxOES_fnptr((uint)face, (uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glMaterialxvOES]</b>  </summary>
            public static void Materialxv(TriangleFace face, MaterialParameter pname, int* param) => GLPointers._glMaterialxvOES_fnptr((uint)face, (uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glMultMatrixxOES]</b>  </summary>
            public static void MultMatrixx(int* m) => GLPointers._glMultMatrixxOES_fnptr(m);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glMultiTexCoord4xOES]</b>  </summary>
            public static void MultiTexCoord4x(TextureUnit texture, int s, int t, int r, int q) => GLPointers._glMultiTexCoord4xOES_fnptr((uint)texture, s, t, r, q);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glNormal3xOES]</b>  </summary>
            public static void Normal3x(int nx, int ny, int nz) => GLPointers._glNormal3xOES_fnptr(nx, ny, nz);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glOrthoxOES]</b>  </summary>
            public static void Orthox(int l, int r, int b, int t, int n, int f) => GLPointers._glOrthoxOES_fnptr(l, r, b, t, n, f);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glPointParameterxvOES]</b>  </summary>
            public static void PointParameterxv(PointParameterNameARB pname, int* parameters) => GLPointers._glPointParameterxvOES_fnptr((uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glPointSizexOES]</b>  </summary>
            public static void PointSizex(int size) => GLPointers._glPointSizexOES_fnptr(size);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glPolygonOffsetxOES]</b>  </summary>
            public static void PolygonOffsetx(int factor, int units) => GLPointers._glPolygonOffsetxOES_fnptr(factor, units);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glRotatexOES]</b>  </summary>
            public static void Rotatex(int angle, int x, int y, int z) => GLPointers._glRotatexOES_fnptr(angle, x, y, z);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glScalexOES]</b>  </summary>
            public static void Scalex(int x, int y, int z) => GLPointers._glScalexOES_fnptr(x, y, z);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glTexEnvxOES]</b>  </summary>
            public static void TexEnvx(TextureEnvTarget target, TextureEnvParameter pname, int param) => GLPointers._glTexEnvxOES_fnptr((uint)target, (uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glTexEnvxvOES]</b>  </summary>
            public static void TexEnvxv(TextureEnvTarget target, TextureEnvParameter pname, int* parameters) => GLPointers._glTexEnvxvOES_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glTexParameterxOES]</b>  </summary>
            public static void TexParameterx(TextureTarget target, GetTextureParameter pname, int param) => GLPointers._glTexParameterxOES_fnptr((uint)target, (uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glTexParameterxvOES]</b>  </summary>
            public static void TexParameterxv(TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._glTexParameterxvOES_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glTranslatexOES]</b>  </summary>
            public static void Translatex(int x, int y, int z) => GLPointers._glTranslatexOES_fnptr(x, y, z);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glGetLightxvOES]</b>  </summary>
            public static void GetLightxv(LightName light, LightParameter pname, int* parameters) => GLPointers._glGetLightxvOES_fnptr((uint)light, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glGetMaterialxvOES]</b>  </summary>
            public static void GetMaterialxv(TriangleFace face, MaterialParameter pname, int* parameters) => GLPointers._glGetMaterialxvOES_fnptr((uint)face, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glPointParameterxOES]</b>  </summary>
            public static void PointParameterx(PointParameterNameARB pname, int param) => GLPointers._glPointParameterxOES_fnptr((uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glSampleCoveragexOES]</b>  </summary>
            public static void SampleCoveragex(int value, bool invert) => GLPointers._glSampleCoveragexOES_fnptr(value, (byte)(invert ? 1 : 0));
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glAccumxOES]</b>  </summary>
            public static void Accumx(All op, int value) => GLPointers._glAccumxOES_fnptr((uint)op, value);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glBitmapxOES]</b>  </summary>
            public static void Bitmapx(int width, int height, int xorig, int yorig, int xmove, int ymove, byte* bitmap) => GLPointers._glBitmapxOES_fnptr(width, height, xorig, yorig, xmove, ymove, bitmap);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glBlendColorxOES]</b>  </summary>
            public static void BlendColorx(int red, int green, int blue, int alpha) => GLPointers._glBlendColorxOES_fnptr(red, green, blue, alpha);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glClearAccumxOES]</b>  </summary>
            public static void ClearAccumx(int red, int green, int blue, int alpha) => GLPointers._glClearAccumxOES_fnptr(red, green, blue, alpha);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glColor3xOES]</b>  </summary>
            public static void Color3x(int red, int green, int blue) => GLPointers._glColor3xOES_fnptr(red, green, blue);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glColor3xvOES]</b>  </summary>
            public static void Color3xv(int* components) => GLPointers._glColor3xvOES_fnptr(components);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glColor4xvOES]</b>  </summary>
            public static void Color4xv(int* components) => GLPointers._glColor4xvOES_fnptr(components);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glConvolutionParameterxOES]</b>  </summary>
            public static void ConvolutionParameterx(ConvolutionTargetEXT target, ConvolutionParameter pname, int param) => GLPointers._glConvolutionParameterxOES_fnptr((uint)target, (uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glConvolutionParameterxvOES]</b>  </summary>
            public static void ConvolutionParameterxv(ConvolutionTargetEXT target, ConvolutionParameter pname, int* parameters) => GLPointers._glConvolutionParameterxvOES_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glEvalCoord1xOES]</b>  </summary>
            public static void EvalCoord1x(int u) => GLPointers._glEvalCoord1xOES_fnptr(u);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glEvalCoord1xvOES]</b>  </summary>
            public static void EvalCoord1xv(int* coords) => GLPointers._glEvalCoord1xvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glEvalCoord2xOES]</b>  </summary>
            public static void EvalCoord2x(int u, int v) => GLPointers._glEvalCoord2xOES_fnptr(u, v);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glEvalCoord2xvOES]</b>  </summary>
            public static void EvalCoord2xv(int* coords) => GLPointers._glEvalCoord2xvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glFeedbackBufferxOES]</b>  </summary>
            public static void FeedbackBufferx(int n, All type, int* buffer) => GLPointers._glFeedbackBufferxOES_fnptr(n, (uint)type, buffer);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glGetConvolutionParameterxvOES]</b>  </summary>
            public static void GetConvolutionParameterxv(All target, All pname, int* parameters) => GLPointers._glGetConvolutionParameterxvOES_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glGetHistogramParameterxvOES]</b>  </summary>
            public static void GetHistogramParameterxv(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, int* parameters) => GLPointers._glGetHistogramParameterxvOES_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glGetLightxOES]</b>  </summary>
            public static void GetLightx(LightName light, LightParameter pname, int* parameters) => GLPointers._glGetLightxOES_fnptr((uint)light, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glGetMapxvOES]</b>  </summary>
            public static void GetMapxv(MapTarget target, GetMapQuery query, int* v) => GLPointers._glGetMapxvOES_fnptr((uint)target, (uint)query, v);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glGetMaterialxOES]</b>  </summary>
            public static void GetMaterialx(TriangleFace face, MaterialParameter pname, int param) => GLPointers._glGetMaterialxOES_fnptr((uint)face, (uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glGetPixelMapxv]</b>  </summary>
            public static void GetPixelMapxv(PixelMap map, int size, int* values) => GLPointers._glGetPixelMapxv_fnptr((uint)map, size, values);
            
            /// <summary> <b>[requires: GL_OES_fixed_point | GL_OES_texture_cube_map] [glGetTexGenxvOES]</b>  </summary>
            public static void GetTexGenxv(TextureCoordName coord, TextureGenParameter pname, int* parameters) => GLPointers._glGetTexGenxvOES_fnptr((uint)coord, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glGetTexLevelParameterxvOES]</b>  </summary>
            public static void GetTexLevelParameterxv(TextureTarget target, int level, GetTextureParameter pname, int* parameters) => GLPointers._glGetTexLevelParameterxvOES_fnptr((uint)target, level, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glIndexxOES]</b>  </summary>
            public static void Indexx(int component) => GLPointers._glIndexxOES_fnptr(component);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glIndexxvOES]</b>  </summary>
            public static void Indexxv(int* component) => GLPointers._glIndexxvOES_fnptr(component);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glLoadTransposeMatrixxOES]</b>  </summary>
            public static void LoadTransposeMatrixx(int* m) => GLPointers._glLoadTransposeMatrixxOES_fnptr(m);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glMap1xOES]</b>  </summary>
            public static void Map1x(MapTarget target, int u1, int u2, int stride, int order, int points) => GLPointers._glMap1xOES_fnptr((uint)target, u1, u2, stride, order, points);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glMap2xOES]</b>  </summary>
            public static void Map2x(MapTarget target, int u1, int u2, int ustride, int uorder, int v1, int v2, int vstride, int vorder, int points) => GLPointers._glMap2xOES_fnptr((uint)target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glMapGrid1xOES]</b>  </summary>
            public static void MapGrid1x(int n, int u1, int u2) => GLPointers._glMapGrid1xOES_fnptr(n, u1, u2);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glMapGrid2xOES]</b>  </summary>
            public static void MapGrid2x(int n, int u1, int u2, int v1, int v2) => GLPointers._glMapGrid2xOES_fnptr(n, u1, u2, v1, v2);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glMultTransposeMatrixxOES]</b>  </summary>
            public static void MultTransposeMatrixx(int* m) => GLPointers._glMultTransposeMatrixxOES_fnptr(m);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glMultiTexCoord1xOES]</b>  </summary>
            public static void MultiTexCoord1x(TextureUnit texture, int s) => GLPointers._glMultiTexCoord1xOES_fnptr((uint)texture, s);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glMultiTexCoord1xvOES]</b>  </summary>
            public static void MultiTexCoord1xv(TextureUnit texture, int* coords) => GLPointers._glMultiTexCoord1xvOES_fnptr((uint)texture, coords);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glMultiTexCoord2xOES]</b>  </summary>
            public static void MultiTexCoord2x(TextureUnit texture, int s, int t) => GLPointers._glMultiTexCoord2xOES_fnptr((uint)texture, s, t);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glMultiTexCoord2xvOES]</b>  </summary>
            public static void MultiTexCoord2xv(TextureUnit texture, int* coords) => GLPointers._glMultiTexCoord2xvOES_fnptr((uint)texture, coords);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glMultiTexCoord3xOES]</b>  </summary>
            public static void MultiTexCoord3x(TextureUnit texture, int s, int t, int r) => GLPointers._glMultiTexCoord3xOES_fnptr((uint)texture, s, t, r);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glMultiTexCoord3xvOES]</b>  </summary>
            public static void MultiTexCoord3xv(TextureUnit texture, int* coords) => GLPointers._glMultiTexCoord3xvOES_fnptr((uint)texture, coords);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glMultiTexCoord4xvOES]</b>  </summary>
            public static void MultiTexCoord4xv(TextureUnit texture, int* coords) => GLPointers._glMultiTexCoord4xvOES_fnptr((uint)texture, coords);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glNormal3xvOES]</b>  </summary>
            public static void Normal3xv(int* coords) => GLPointers._glNormal3xvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glPassThroughxOES]</b>  </summary>
            public static void PassThroughx(int token) => GLPointers._glPassThroughxOES_fnptr(token);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glPixelMapx]</b>  </summary>
            public static void PixelMapx(PixelMap map, int size, int* values) => GLPointers._glPixelMapx_fnptr((uint)map, size, values);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glPixelStorex]</b>  </summary>
            public static void PixelStorex(PixelStoreParameter pname, int param) => GLPointers._glPixelStorex_fnptr((uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glPixelTransferxOES]</b>  </summary>
            public static void PixelTransferx(PixelTransferParameter pname, int param) => GLPointers._glPixelTransferxOES_fnptr((uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glPixelZoomxOES]</b>  </summary>
            public static void PixelZoomx(int xfactor, int yfactor) => GLPointers._glPixelZoomxOES_fnptr(xfactor, yfactor);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glPrioritizeTexturesxOES]</b>  </summary>
            public static void PrioritizeTexturesx(int n, int* textures, int* priorities) => GLPointers._glPrioritizeTexturesxOES_fnptr(n, textures, priorities);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glRasterPos2xOES]</b>  </summary>
            public static void RasterPos2x(int x, int y) => GLPointers._glRasterPos2xOES_fnptr(x, y);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glRasterPos2xvOES]</b>  </summary>
            public static void RasterPos2xv(int* coords) => GLPointers._glRasterPos2xvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glRasterPos3xOES]</b>  </summary>
            public static void RasterPos3x(int x, int y, int z) => GLPointers._glRasterPos3xOES_fnptr(x, y, z);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glRasterPos3xvOES]</b>  </summary>
            public static void RasterPos3xv(int* coords) => GLPointers._glRasterPos3xvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glRasterPos4xOES]</b>  </summary>
            public static void RasterPos4x(int x, int y, int z, int w) => GLPointers._glRasterPos4xOES_fnptr(x, y, z, w);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glRasterPos4xvOES]</b>  </summary>
            public static void RasterPos4xv(int* coords) => GLPointers._glRasterPos4xvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glRectxOES]</b>  </summary>
            public static void Rectx(int x1, int y1, int x2, int y2) => GLPointers._glRectxOES_fnptr(x1, y1, x2, y2);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glRectxvOES]</b>  </summary>
            public static void Rectxv(int* v1, int* v2) => GLPointers._glRectxvOES_fnptr(v1, v2);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glTexCoord1xOES]</b>  </summary>
            public static void TexCoord1x(int s) => GLPointers._glTexCoord1xOES_fnptr(s);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glTexCoord1xvOES]</b>  </summary>
            public static void TexCoord1xv(int* coords) => GLPointers._glTexCoord1xvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glTexCoord2xOES]</b>  </summary>
            public static void TexCoord2x(int s, int t) => GLPointers._glTexCoord2xOES_fnptr(s, t);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glTexCoord2xvOES]</b>  </summary>
            public static void TexCoord2xv(int* coords) => GLPointers._glTexCoord2xvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glTexCoord3xOES]</b>  </summary>
            public static void TexCoord3x(int s, int t, int r) => GLPointers._glTexCoord3xOES_fnptr(s, t, r);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glTexCoord3xvOES]</b>  </summary>
            public static void TexCoord3xv(int* coords) => GLPointers._glTexCoord3xvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glTexCoord4xOES]</b>  </summary>
            public static void TexCoord4x(int s, int t, int r, int q) => GLPointers._glTexCoord4xOES_fnptr(s, t, r, q);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glTexCoord4xvOES]</b>  </summary>
            public static void TexCoord4xv(int* coords) => GLPointers._glTexCoord4xvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_fixed_point | GL_OES_texture_cube_map] [glTexGenxOES]</b>  </summary>
            public static void TexGenx(TextureCoordName coord, TextureGenParameter pname, int param) => GLPointers._glTexGenxOES_fnptr((uint)coord, (uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_fixed_point | GL_OES_texture_cube_map] [glTexGenxvOES]</b>  </summary>
            public static void TexGenxv(TextureCoordName coord, TextureGenParameter pname, int* parameters) => GLPointers._glTexGenxvOES_fnptr((uint)coord, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glVertex2xOES]</b>  </summary>
            public static void Vertex2x(int x) => GLPointers._glVertex2xOES_fnptr(x);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glVertex2xvOES]</b>  </summary>
            public static void Vertex2xv(int* coords) => GLPointers._glVertex2xvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glVertex3xOES]</b>  </summary>
            public static void Vertex3x(int x, int y) => GLPointers._glVertex3xOES_fnptr(x, y);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glVertex3xvOES]</b>  </summary>
            public static void Vertex3xv(int* coords) => GLPointers._glVertex3xvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glVertex4xOES]</b>  </summary>
            public static void Vertex4x(int x, int y, int z) => GLPointers._glVertex4xOES_fnptr(x, y, z);
            
            /// <summary> <b>[requires: GL_OES_fixed_point] [glVertex4xvOES]</b>  </summary>
            public static void Vertex4xv(int* coords) => GLPointers._glVertex4xvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object] [glIsRenderbufferOES]</b>  </summary>
            public static bool IsRenderbuffer(int renderbuffer) => GLPointers._glIsRenderbufferOES_fnptr(renderbuffer) != 0;
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object] [glBindRenderbufferOES]</b>  </summary>
            public static void BindRenderbuffer(RenderbufferTarget target, int renderbuffer) => GLPointers._glBindRenderbufferOES_fnptr((uint)target, renderbuffer);
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object] [glDeleteRenderbuffersOES]</b>  </summary>
            public static void DeleteRenderbuffers(int n, int* renderbuffers) => GLPointers._glDeleteRenderbuffersOES_fnptr(n, renderbuffers);
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object] [glGenRenderbuffersOES]</b>  </summary>
            public static void GenRenderbuffers(int n, int* renderbuffers) => GLPointers._glGenRenderbuffersOES_fnptr(n, renderbuffers);
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object] [glRenderbufferStorageOES]</b>  </summary>
            public static void RenderbufferStorage(RenderbufferTarget target, InternalFormat internalformat, int width, int height) => GLPointers._glRenderbufferStorageOES_fnptr((uint)target, (uint)internalformat, width, height);
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object] [glGetRenderbufferParameterivOES]</b>  </summary>
            public static void GetRenderbufferParameteriv(RenderbufferTarget target, RenderbufferParameterName pname, int* parameters) => GLPointers._glGetRenderbufferParameterivOES_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object] [glIsFramebufferOES]</b>  </summary>
            public static bool IsFramebuffer(int framebuffer) => GLPointers._glIsFramebufferOES_fnptr(framebuffer) != 0;
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object] [glBindFramebufferOES]</b>  </summary>
            public static void BindFramebuffer(FramebufferTarget target, int framebuffer) => GLPointers._glBindFramebufferOES_fnptr((uint)target, framebuffer);
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object] [glDeleteFramebuffersOES]</b>  </summary>
            public static void DeleteFramebuffers(int n, int* framebuffers) => GLPointers._glDeleteFramebuffersOES_fnptr(n, framebuffers);
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object] [glGenFramebuffersOES]</b>  </summary>
            public static void GenFramebuffers(int n, int* framebuffers) => GLPointers._glGenFramebuffersOES_fnptr(n, framebuffers);
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object] [glCheckFramebufferStatusOES]</b>  </summary>
            public static FramebufferStatus CheckFramebufferStatus(FramebufferTarget target) => (FramebufferStatus) GLPointers._glCheckFramebufferStatusOES_fnptr((uint)target);
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object] [glFramebufferRenderbufferOES]</b>  </summary>
            public static void FramebufferRenderbuffer(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, int renderbuffer) => GLPointers._glFramebufferRenderbufferOES_fnptr((uint)target, (uint)attachment, (uint)renderbuffertarget, renderbuffer);
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object] [glFramebufferTexture2DOES]</b>  </summary>
            public static void FramebufferTexture2D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level) => GLPointers._glFramebufferTexture2DOES_fnptr((uint)target, (uint)attachment, (uint)textarget, texture, level);
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object] [glGetFramebufferAttachmentParameterivOES]</b>  </summary>
            public static void GetFramebufferAttachmentParameteriv(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int* parameters) => GLPointers._glGetFramebufferAttachmentParameterivOES_fnptr((uint)target, (uint)attachment, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object] [glGenerateMipmapOES]</b>  </summary>
            public static void GenerateMipmap(TextureTarget target) => GLPointers._glGenerateMipmapOES_fnptr((uint)target);
            
            /// <summary> <b>[requires: GL_OES_mapbuffer] [glMapBufferOES]</b>  </summary>
            public static void* MapBuffer(BufferTargetARB target, BufferAccessARB access) => GLPointers._glMapBufferOES_fnptr((uint)target, (uint)access);
            
            /// <summary> <b>[requires: GL_OES_mapbuffer] [glUnmapBufferOES]</b>  </summary>
            public static bool UnmapBuffer(All target) => GLPointers._glUnmapBufferOES_fnptr((uint)target) != 0;
            
            /// <summary> <b>[requires: GL_OES_mapbuffer] [glGetBufferPointervOES]</b>  </summary>
            public static void GetBufferPointerv(BufferTargetARB target, BufferPointerNameARB pname, void** parameters) => GLPointers._glGetBufferPointervOES_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_matrix_palette] [glCurrentPaletteMatrixOES]</b>         defines which of the palette&apos;s matrices is affected by        subsequent matrix operations        . </summary>
            /// <param name="index"> specifies the index into the palette&apos;s matrices. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glCurrentPaletteMatrix.xml" /></remarks>
            public static void CurrentPaletteMatrix(uint matrixpaletteindex) => GLPointers._glCurrentPaletteMatrixOES_fnptr(matrixpaletteindex);
            
            /// <summary> <b>[requires: GL_OES_matrix_palette] [glLoadPaletteFromModelViewMatrixOES]</b>         copies the current model view matrix to a        matrix in the current matrix palette        . </summary>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glLoadPaletteFromModelViewMatrix.xml" /></remarks>
            public static void LoadPaletteFromModelViewMatrix() => GLPointers._glLoadPaletteFromModelViewMatrixOES_fnptr();
            
            /// <summary> <b>[requires: GL_OES_matrix_palette] [glMatrixIndexPointerOES]</b> Define an array of matrix indices. </summary>
            /// <param name="size"> Specifies the number of matrix indices per vertex. Must be is less than or equal to GL_MAX_VERTEX_UNITS_OES. The initial value is 0. </param>
            /// <param name="type"> Specifies the data type of each matrix index in the array. Symbolic constant GL_UNSIGNED_BYTE is accepted. The initial value is GL_UNSIGNED_BYTE. </param>
            /// <param name="stride"> Specifies the byte offset between consecutive matrix indices. If stride is 0, the matrix indices are understood to be tightly packed in the array. The initial value is 0. </param>
            /// <param name="pointer"> Specifies a pointer to the first matrix index of the first vertex in the array. The initial value is 0. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glMatrixIndexPointer.xml" /></remarks>
            public static void MatrixIndexPointer(int size, MatrixIndexPointerTypeARB type, int stride, void* pointer) => GLPointers._glMatrixIndexPointerOES_fnptr(size, (uint)type, stride, pointer);
            
            /// <summary> <b>[requires: GL_OES_matrix_palette] [glWeightPointerOES]</b> Define an array of weights. </summary>
            /// <param name="size"> Specifies the number of weights per vertex. Must be is less than or equal to GL_MAX_VERTEX_UNITS_OES. The initial value is 0. </param>
            /// <param name="type"> Specifies the data type of each weight in the array. Symbolic constant GL_FIXED is accepted. However, the common profile also accepts the symbolic constant GL_FLOAT as well. The initial value is GL_FIXED for the common lite profile, or GL_FLOAT for the common profile. </param>
            /// <param name="stride"> Specifies the byte offset between consecutive weights. If stride is 0, the weights are understood to be tightly packed in the array. The initial value is 0. </param>
            /// <param name="pointer"> Specifies a pointer to the first weight of the first vertex in the array. The initial value is 0. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glWeightPointer.xml" /></remarks>
            public static void WeightPointer(int size, All type, int stride, void* pointer) => GLPointers._glWeightPointerOES_fnptr(size, (uint)type, stride, pointer);
            
            /// <summary> <b>[requires: GL_OES_point_size_array] [glPointSizePointerOES]</b> Define an array of point sizes. </summary>
            /// <param name="type"> Specifies the data type of each point size in the array. Symbolic constant GL_FIXED is accepted. However, the common profile also accepts the symbolic constant GL_FLOAT. The initial value is GL_FIXED for the common lite profile, or GL_FLOAT for the common profile. </param>
            /// <param name="stride"> Specifies the byte offset between consecutive point sizes. If stride is 0, the point sizes are understood to be tightly packed in the array. The initial value is 0. </param>
            /// <param name="pointer"> Specifies a pointer to the point size of the first vertex in the array. The initial value is 0. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glPointSizePointerOES.xml" /></remarks>
            public static void PointSizePointer(All type, int stride, void* pointer) => GLPointers._glPointSizePointerOES_fnptr((uint)type, stride, pointer);
            
            /// <summary> <b>[requires: GL_OES_query_matrix] [glQueryMatrixxOES]</b> Return the values of the current matrix. </summary>
            /// <param name="mantissa">Returns the mantissa values of the current matrix.</param>
            /// <param name="exponent">Returns the exponents of the current matrix.</param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glQueryMatrix.xml" /></remarks>
            public static uint QueryMatrixx(int* mantissa, int* exponent) => GLPointers._glQueryMatrixxOES_fnptr(mantissa, exponent);
            
            /// <summary> <b>[requires: GL_OES_single_precision] [glClearDepthfOES]</b>  </summary>
            public static void ClearDepthf(float depth) => GLPointers._glClearDepthfOES_fnptr(depth);
            
            /// <summary> <b>[requires: GL_OES_single_precision] [glClipPlanefOES]</b>  </summary>
            public static void ClipPlanef(ClipPlaneName plane, float* equation) => GLPointers._glClipPlanefOES_fnptr((uint)plane, equation);
            
            /// <summary> <b>[requires: GL_OES_single_precision] [glDepthRangefOES]</b>  </summary>
            public static void DepthRangef(float n, float f) => GLPointers._glDepthRangefOES_fnptr(n, f);
            
            /// <summary> <b>[requires: GL_OES_single_precision] [glFrustumfOES]</b>  </summary>
            public static void Frustumf(float l, float r, float b, float t, float n, float f) => GLPointers._glFrustumfOES_fnptr(l, r, b, t, n, f);
            
            /// <summary> <b>[requires: GL_OES_single_precision] [glGetClipPlanefOES]</b>  </summary>
            public static void GetClipPlanef(ClipPlaneName plane, float* equation) => GLPointers._glGetClipPlanefOES_fnptr((uint)plane, equation);
            
            /// <summary> <b>[requires: GL_OES_single_precision] [glOrthofOES]</b>  </summary>
            public static void Orthof(float l, float r, float b, float t, float n, float f) => GLPointers._glOrthofOES_fnptr(l, r, b, t, n, f);
            
            /// <summary> <b>[requires: GL_OES_texture_cube_map] [glTexGenfOES]</b>  </summary>
            public static void TexGenf(TextureCoordName coord, TextureGenParameter pname, float param) => GLPointers._glTexGenfOES_fnptr((uint)coord, (uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_texture_cube_map] [glTexGenfvOES]</b>  </summary>
            public static void TexGenfv(TextureCoordName coord, TextureGenParameter pname, float* parameters) => GLPointers._glTexGenfvOES_fnptr((uint)coord, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_texture_cube_map] [glTexGeniOES]</b>  </summary>
            public static void TexGeni(TextureCoordName coord, TextureGenParameter pname, int param) => GLPointers._glTexGeniOES_fnptr((uint)coord, (uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_texture_cube_map] [glTexGenivOES]</b>  </summary>
            public static void TexGeniv(TextureCoordName coord, TextureGenParameter pname, int* parameters) => GLPointers._glTexGenivOES_fnptr((uint)coord, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_texture_cube_map] [glGetTexGenfvOES]</b>  </summary>
            public static void GetTexGenfv(TextureCoordName coord, TextureGenParameter pname, float* parameters) => GLPointers._glGetTexGenfvOES_fnptr((uint)coord, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_texture_cube_map] [glGetTexGenivOES]</b>  </summary>
            public static void GetTexGeniv(TextureCoordName coord, TextureGenParameter pname, int* parameters) => GLPointers._glGetTexGenivOES_fnptr((uint)coord, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_vertex_array_object] [glBindVertexArrayOES]</b>  </summary>
            public static void BindVertexArray(int array) => GLPointers._glBindVertexArrayOES_fnptr(array);
            
            /// <summary> <b>[requires: GL_OES_vertex_array_object] [glDeleteVertexArraysOES]</b>  </summary>
            public static void DeleteVertexArrays(int n, int* arrays) => GLPointers._glDeleteVertexArraysOES_fnptr(n, arrays);
            
            /// <summary> <b>[requires: GL_OES_vertex_array_object] [glGenVertexArraysOES]</b>  </summary>
            public static void GenVertexArrays(int n, int* arrays) => GLPointers._glGenVertexArraysOES_fnptr(n, arrays);
            
            /// <summary> <b>[requires: GL_OES_vertex_array_object] [glIsVertexArrayOES]</b>  </summary>
            public static bool IsVertexArray(int array) => GLPointers._glIsVertexArrayOES_fnptr(array) != 0;
            
        }
        /// <summary>QCOM extensions.</summary>
        public static unsafe partial class QCOM
        {
            /// <summary> <b>[requires: GL_QCOM_driver_control] [glGetDriverControlsQCOM]</b>  </summary>
            public static void GetDriverControls(int* num, int size, uint* driverControls) => GLPointers._glGetDriverControlsQCOM_fnptr(num, size, driverControls);
            
            /// <summary> <b>[requires: GL_QCOM_driver_control] [glGetDriverControlStringQCOM]</b>  </summary>
            public static void GetDriverControlString(uint driverControl, int bufSize, int* length, byte* driverControlString) => GLPointers._glGetDriverControlStringQCOM_fnptr(driverControl, bufSize, length, driverControlString);
            
            /// <summary> <b>[requires: GL_QCOM_driver_control] [glEnableDriverControlQCOM]</b>  </summary>
            public static void EnableDriverControl(uint driverControl) => GLPointers._glEnableDriverControlQCOM_fnptr(driverControl);
            
            /// <summary> <b>[requires: GL_QCOM_driver_control] [glDisableDriverControlQCOM]</b>  </summary>
            public static void DisableDriverControl(uint driverControl) => GLPointers._glDisableDriverControlQCOM_fnptr(driverControl);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get] [glExtGetTexturesQCOM]</b>  </summary>
            public static void ExtGetTextures(int* textures, int maxTextures, int* numTextures) => GLPointers._glExtGetTexturesQCOM_fnptr(textures, maxTextures, numTextures);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get] [glExtGetBuffersQCOM]</b>  </summary>
            public static void ExtGetBuffers(int* buffers, int maxBuffers, int* numBuffers) => GLPointers._glExtGetBuffersQCOM_fnptr(buffers, maxBuffers, numBuffers);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get] [glExtGetRenderbuffersQCOM]</b>  </summary>
            public static void ExtGetRenderbuffers(int* renderbuffers, int maxRenderbuffers, int* numRenderbuffers) => GLPointers._glExtGetRenderbuffersQCOM_fnptr(renderbuffers, maxRenderbuffers, numRenderbuffers);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get] [glExtGetFramebuffersQCOM]</b>  </summary>
            public static void ExtGetFramebuffers(int* framebuffers, int maxFramebuffers, int* numFramebuffers) => GLPointers._glExtGetFramebuffersQCOM_fnptr(framebuffers, maxFramebuffers, numFramebuffers);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get] [glExtGetTexLevelParameterivQCOM]</b>  </summary>
            public static void ExtGetTexLevelParameteriv(int texture, All face, int level, All pname, int* parameters) => GLPointers._glExtGetTexLevelParameterivQCOM_fnptr(texture, (uint)face, level, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get] [glExtTexObjectStateOverrideiQCOM]</b>  </summary>
            public static void ExtTexObjectStateOverridei(All target, All pname, int param) => GLPointers._glExtTexObjectStateOverrideiQCOM_fnptr((uint)target, (uint)pname, param);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get] [glExtGetTexSubImageQCOM]</b>  </summary>
            public static void ExtGetTexSubImage(All target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* texels) => GLPointers._glExtGetTexSubImageQCOM_fnptr((uint)target, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, (uint)type, texels);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get] [glExtGetBufferPointervQCOM]</b>  </summary>
            public static void ExtGetBufferPointerv(All target, void** parameters) => GLPointers._glExtGetBufferPointervQCOM_fnptr((uint)target, parameters);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get2] [glExtGetShadersQCOM]</b>  </summary>
            public static void ExtGetShaders(int* shaders, int maxShaders, int* numShaders) => GLPointers._glExtGetShadersQCOM_fnptr(shaders, maxShaders, numShaders);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get2] [glExtGetProgramsQCOM]</b>  </summary>
            public static void ExtGetPrograms(int* programs, int maxPrograms, int* numPrograms) => GLPointers._glExtGetProgramsQCOM_fnptr(programs, maxPrograms, numPrograms);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get2] [glExtIsProgramBinaryQCOM]</b>  </summary>
            public static bool ExtIsProgramBinary(int program) => GLPointers._glExtIsProgramBinaryQCOM_fnptr(program) != 0;
            
            /// <summary> <b>[requires: GL_QCOM_extended_get2] [glExtGetProgramBinarySourceQCOM]</b>  </summary>
            public static void ExtGetProgramBinarySource(int program, ShaderType shadertype, byte* source, int* length) => GLPointers._glExtGetProgramBinarySourceQCOM_fnptr(program, (uint)shadertype, source, length);
            
            /// <summary> <b>[requires: GL_QCOM_tiled_rendering] [glStartTilingQCOM]</b>  </summary>
            public static void StartTiling(uint x, uint y, uint width, uint height, BufferBitQCOM preserveMask) => GLPointers._glStartTilingQCOM_fnptr(x, y, width, height, (uint)preserveMask);
            
            /// <summary> <b>[requires: GL_QCOM_tiled_rendering] [glEndTilingQCOM]</b>  </summary>
            public static void EndTiling(BufferBitQCOM preserveMask) => GLPointers._glEndTilingQCOM_fnptr((uint)preserveMask);
            
        }
    }
}
