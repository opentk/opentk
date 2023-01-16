// This file is auto generated, do not edit.
using System;
using System.Runtime.InteropServices;
using OpenTK.Graphics;

namespace OpenTK.Graphics.OpenGLES1
{
    public static unsafe partial class GL
    {
        /// <summary> <b>[requires: v1.0]</b> Specify the alpha test function. </summary>
        /// <param name="func">Specifies the alpha comparison function. Symbolic constants GL_NEVER, GL_LESS, GL_EQUAL, GL_LEQUAL, GL_GREATER, GL_NOTEQUAL, GL_GEQUAL, and GL_ALWAYS are accepted. The initial value is GL_ALWAYS. </param>
        /// <param name="reference">Specifies the reference value that incoming alpha values are compared to. This value is clamped to the range [0, 1], where 0 represents the lowest possible alpha value and 1 the highest possible value. The initial reference value is 0. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glAlphaFunc.xml" /></remarks>
        public static void AlphaFunc(AlphaFunction func, float reference) => GLPointers._AlphaFunc_fnptr((uint)func, reference);
        
        /// <summary> <b>[requires: v1.0]</b> Specify clear values for the color buffer. </summary>
        /// <param name="red">Specify the red, green, blue, and alpha values used when the color buffer is cleared. The initial values are all 0.</param>
        /// <param name="green">Specify the red, green, blue, and alpha values used when the color buffer is cleared. The initial values are all 0.</param>
        /// <param name="blue">Specify the red, green, blue, and alpha values used when the color buffer is cleared. The initial values are all 0.</param>
        /// <param name="alpha">Specify the red, green, blue, and alpha values used when the color buffer is cleared. The initial values are all 0.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glClearColor.xml" /></remarks>
        public static void ClearColor(float red, float green, float blue, float alpha) => GLPointers._ClearColor_fnptr(red, green, blue, alpha);
        
        /// <summary> <b>[requires: v1.0]</b> Specify the clear value for the depth buffer. </summary>
        /// <param name="depth">Specifies the depth value used when the depth buffer is cleared. The initial value is 1.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glClearDepth.xml" /></remarks>
        public static void ClearDepthf(float d) => GLPointers._ClearDepthf_fnptr(d);
        
        /// <summary> <b>[requires: v1.0]</b> Specify a plane against which all geometry is    clipped. </summary>
        /// <param name="plane">Specifies which clipping plane is being positioned. Symbolic names of the form GL_CLIP_PLANEi, where i is an integer between 0 and GL_MAX_CLIP_PLANES -1 , are accepted.</param>
        /// <param name="equation">Specifies the address of an array of four fixed-point or floating-point values. These are the coefficients of a plane equation in object coordinates: p1, p2, p3, and p4, in that order.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glClipPlane.xml" /></remarks>
        public static void ClipPlanef(ClipPlaneName p, float* eqn) => GLPointers._ClipPlanef_fnptr((uint)p, eqn);
        
        /// <summary> <b>[requires: v1.0]</b> Set the current color. </summary>
        /// <param name="red">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <param name="green">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <param name="blue">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <param name="alpha">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glColor.xml" /></remarks>
        public static void Color4f(float red, float green, float blue, float alpha) => GLPointers._Color4f_fnptr(red, green, blue, alpha);
        
        /// <summary> <b>[requires: v1.0]</b> Specify mapping of depth values from normalized        device coordinates to window coordinates. </summary>
        /// <param name="near">Specifies the mapping of the near clipping plane to window coordinates. The initial value is 0.</param>
        /// <param name="far">Specifies the mapping of the far clipping plane to window coordinates. The initial value is 1.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glDepthRange.xml" /></remarks>
        public static void DepthRangef(float n, float f) => GLPointers._DepthRangef_fnptr(n, f);
        
        /// <summary> <b>[requires: v1.0]</b> Specify fog parameters. </summary>
        /// <param name="pname">Specifies a single-valued fog parameter. GL_FOG_MODE, GL_FOG_DENSITY, GL_FOG_START, and GL_FOG_END are accepted.</param>
        /// <param name="param">Specifies the value that pname will be set to.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glFog.xml" /></remarks>
        public static void Fogf(FogParameter pname, float param) => GLPointers._Fogf_fnptr((uint)pname, param);
        
        public static void Fogfv(FogParameter pname, float* parameters) => GLPointers._Fogfv_fnptr((uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0]</b> Multiply the current matrix by a perspective matrix. </summary>
        /// <param name="left">Specify the coordinates for the left and right vertical clipping planes.</param>
        /// <param name="right">Specify the coordinates for the left and right vertical clipping planes.</param>
        /// <param name="bottom">Specify the coordinates for the bottom and top horizontal clipping planes.</param>
        /// <param name="top">Specify the coordinates for the bottom and top horizontal clipping planes.</param>
        /// <param name="near">Specify the distances to the near and far depth clipping planes. Both distances must be positive.</param>
        /// <param name="far">Specify the distances to the near and far depth clipping planes. Both distances must be positive.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glFrustum.xml" /></remarks>
        public static void Frustumf(float l, float r, float b, float t, float n, float f) => GLPointers._Frustumf_fnptr(l, r, b, t, n, f);
        
        /// <summary> <b>[requires: v1.0]</b> Return the coefficients of the specified clipping    plane. </summary>
        /// <param name="plane">Specifies a clipping plane. The number of clipping planes depends on the implementation, but at least six clipping planes are supported. Symbolic names of the form GL_CLIP_PLANE i, where i is an integer between 0 and GL_MAX_CLIP_PLANES -1 , are accepted.</param>
        /// <param name="equation">Returns four fixed-point or floating-point values that are the coefficients of the plane equation of plane in eye coordinates in the order p1, p2, p3, and p4. The initial value is (0, 0, 0, 0).</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetClipPlane.xml" /></remarks>
        public static void GetClipPlanef(ClipPlaneName plane, float* equation) => GLPointers._GetClipPlanef_fnptr((uint)plane, equation);
        
        /// <summary> <b>[requires: v1.0]</b> Return the value or values of a selected parameter. </summary>
        /// <param name="pname">Specifies the parameter value to be returned. The symbolic constants in the list below are accepted.</param>
        /// <param name="parameters">Returns the value or values of the specified parameter.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGet.xml" /></remarks>
        public static void GetFloatv(GetPName pname, float* data) => GLPointers._GetFloatv_fnptr((uint)pname, data);
        
        /// <summary> <b>[requires: v1.0]</b> Return light source parameter values. </summary>
        /// <param name="light"> Specifies a light source. The number of possible lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form GL_LIGHTi where 0<i< GL_MAX_LIGHTS </param>
        /// <param name="pname"> Specifies a light source parameter for light. Accepted symbolic names are GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_POSITION, GL_SPOT_DIRECTION, GL_SPOT_EXPONENT, GL_SPOT_CUTOFF, GL_CONSTANT_ATTENUATION, GL_LINEAR_ATTENUATION, and GL_QUADRATIC_ATTENUATION. </param>
        /// <param name="parameters"> Returns the requested data. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetLight.xml" /></remarks>
        public static void GetLightfv(LightName light, LightParameter pname, float* parameters) => GLPointers._GetLightfv_fnptr((uint)light, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0]</b> Return material parameters values. </summary>
        /// <param name="face"> Specifies which of the two materials is being queried. GL_FRONT or GL_BACK are accepted, representing the front and back materials, respectively. </param>
        /// <param name="pname"> Specifies the material parameter to return. Accepted symbolic names are GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_EMISSION, and GL_SHININESS. </param>
        /// <param name="parameters"> Returns the requested data. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetMaterial.xml" /></remarks>
        public static void GetMaterialfv(TriangleFace face, MaterialParameter pname, float* parameters) => GLPointers._GetMaterialfv_fnptr((uint)face, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0]</b> Return texture environment parameters. </summary>
        /// <param name="target"> Specifies a texture environment. May be GL_TEXTURE_ENV or GL_POINT_SPRITE_OES. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture environment parameter. Accepted values are GL_TEXTURE_ENV_MODE, GL_TEXTURE_ENV_COLOR, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE_OES. </param>
        /// <param name="parameters"> Returns the requested data. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetTexEnv.xml" /></remarks>
        public static void GetTexEnvfv(TextureEnvTarget target, TextureEnvParameter pname, float* parameters) => GLPointers._GetTexEnvfv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0]</b> Return texture parameter values. </summary>
        /// <param name="target">Specifies the target texture, which must be GL_TEXTURE_2D.</param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. Which can be one of the following: GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_GENERATE_MIPMAP. </param>
        /// <param name="parameters">Returns texture parameters.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetTexParameter.xml" /></remarks>
        public static void GetTexParameterfv(TextureTarget target, GetTextureParameter pname, float* parameters) => GLPointers._GetTexParameterfv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0]</b> Set the lighting model parameters. </summary>
        /// <param name="pname">Specifies a single-valued lighting model parameter. Must be GL_LIGHT_MODEL_TWO_SIDE.</param>
        /// <param name="param">Specifies the value that param will be set to.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glLightModel.xml" /></remarks>
        public static void LightModelf(LightModelParameter pname, float param) => GLPointers._LightModelf_fnptr((uint)pname, param);
        
        public static void LightModelfv(LightModelParameter pname, float* parameters) => GLPointers._LightModelfv_fnptr((uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0]</b> Set light source parameters. </summary>
        /// <param name="light">Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form GL_LIGHTi where 0 <= i < GL_MAX_LIGHTS . </param>
        /// <param name="pname">Specifies a single-valued light source parameter for light. GL_SPOT_EXPONENT, GL_SPOT_CUTOFF, GL_CONSTANT_ATTENUATION, GL_LINEAR_ATTENUATION, and GL_QUADRATIC_ATTENUATION are accepted.</param>
        /// <param name="param">Specifies the value that parameter pname of light source light will be set to.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glLight.xml" /></remarks>
        public static void Lightf(LightName light, LightParameter pname, float param) => GLPointers._Lightf_fnptr((uint)light, (uint)pname, param);
        
        public static void Lightfv(LightName light, LightParameter pname, float* parameters) => GLPointers._Lightfv_fnptr((uint)light, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0]</b> Specify the width of rasterized lines. </summary>
        /// <param name="width">Specifies the width of rasterized lines. The initial value is 1.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glLineWidth.xml" /></remarks>
        public static void LineWidth(float width) => GLPointers._LineWidth_fnptr(width);
        
        /// <summary> <b>[requires: v1.0]</b> Replace the current matrix with the specifiedmatrix. </summary>
        /// <param name="m">Specifies a pointer to 16 consecutive values, which are used as the elements of a 4x4 column-major matrix.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glLoadMatrix.xml" /></remarks>
        public static void LoadMatrixf(float* m) => GLPointers._LoadMatrixf_fnptr(m);
        
        /// <summary> <b>[requires: v1.0]</b> Specify material parameters for the lighting model. </summary>
        /// <param name="face">Specifies which face or faces are being updated. Must be GL_FRONT_AND_BACK.</param>
        /// <param name="pname">Specifies the single-valued material parameter of the face or faces that is being updated. Must be GL_SHININESS.</param>
        /// <param name="param">Specifies the value that parameter GL_SHININESS will be set to.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glMaterial.xml" /></remarks>
        public static void Materialf(TriangleFace face, MaterialParameter pname, float param) => GLPointers._Materialf_fnptr((uint)face, (uint)pname, param);
        
        public static void Materialfv(TriangleFace face, MaterialParameter pname, float* parameters) => GLPointers._Materialfv_fnptr((uint)face, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0]</b> Multiply the current matrix with the specifiedmatrix. </summary>
        /// <param name="m">Points to 16 consecutive values that are used as the elements of a 4x4 column-major matrix.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glMultMatrix.xml" /></remarks>
        public static void MultMatrixf(float* m) => GLPointers._MultMatrixf_fnptr(m);
        
        /// <summary> <b>[requires: v1.0]</b> Set the current texture coordinates. </summary>
        /// <param name="target">Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least twoone. Symbolic constant must be one of GL_TEXTUREi, where i ranges from 0 to GL_MAX_TEXTURE_UNITS - 1, which is an implementation-dependent value.</param>
        /// <param name="s">Specify s, t, r, and q texture coordinates for target texture unit.</param>
        /// <param name="t">Specify s, t, r, and q texture coordinates for target texture unit.</param>
        /// <param name="r">Specify s, t, r, and q texture coordinates for target texture unit.</param>
        /// <param name="q">Specify s, t, r, and q texture coordinates for target texture unit.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glMultiTexCoord.xml" /></remarks>
        public static void MultiTexCoord4f(TextureUnit target, float s, float t, float r, float q) => GLPointers._MultiTexCoord4f_fnptr((uint)target, s, t, r, q);
        
        /// <summary> <b>[requires: v1.0]</b> Set the current normal vector. </summary>
        /// <param name="nx">Specify the x, y, and z coordinates of the new current normal. The initial value is (0, 0, 1).</param>
        /// <param name="ny">Specify the x, y, and z coordinates of the new current normal. The initial value is (0, 0, 1).</param>
        /// <param name="nz">Specify the x, y, and z coordinates of the new current normal. The initial value is (0, 0, 1).</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glNormal.xml" /></remarks>
        public static void Normal3f(float nx, float ny, float nz) => GLPointers._Normal3f_fnptr(nx, ny, nz);
        
        /// <summary> <b>[requires: v1.0]</b> Multiply the current matrix with an orthographicmatrix. </summary>
        /// <param name="left">Specify the coordinates for the left and right vertical clipping planes.</param>
        /// <param name="right">Specify the coordinates for the left and right vertical clipping planes.</param>
        /// <param name="bottom">Specify the coordinates for the bottom and top horizontal clipping planes.</param>
        /// <param name="top">Specify the coordinates for the bottom and top horizontal clipping planes.</param>
        /// <param name="near">Specify the distances to the nearer and farther depth clipping planes. These values are negative if the plane is to be behind the viewer.</param>
        /// <param name="far">Specify the distances to the nearer and farther depth clipping planes. These values are negative if the plane is to be behind the viewer.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glOrtho.xml" /></remarks>
        public static void Orthof(float l, float r, float b, float t, float n, float f) => GLPointers._Orthof_fnptr(l, r, b, t, n, f);
        
        /// <summary> <b>[requires: v1.0]</b> Specify parameters for point rasterization. </summary>
        /// <param name="pname"> Specifies the single-valued parameter to be updated. Can be either GL_POINT_SIZE_MIN, GL_POINT_SIZE_MAX, or GL_POINT_FADE_THRESHOLD_SIZE. </param>
        /// <param name="param"> Specifies the value that the parameter will be set to. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glPointParameter.xml" /></remarks>
        public static void PointParameterf(PointParameterNameARB pname, float param) => GLPointers._PointParameterf_fnptr((uint)pname, param);
        
        public static void PointParameterfv(PointParameterNameARB pname, float* parameters) => GLPointers._PointParameterfv_fnptr((uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0]</b> Specify the diameter of rasterized points. </summary>
        /// <param name="size">Specifies the diameter of rasterized points. The initial value is 1.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glPointSize.xml" /></remarks>
        public static void PointSize(float size) => GLPointers._PointSize_fnptr(size);
        
        /// <summary> <b>[requires: v1.0]</b> Set the scale and units used to calculate depth        values. </summary>
        /// <param name="factor">Specifies a scale factor that is used to create a variable depth offset for each polygon. The initial value is 0.</param>
        /// <param name="units">Is multiplied by an implementation-specific value to create a constant depth offset. The initial value is 0.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glPolygonOffset.xml" /></remarks>
        public static void PolygonOffset(float factor, float units) => GLPointers._PolygonOffset_fnptr(factor, units);
        
        /// <summary> <b>[requires: v1.0]</b> Multiply the current matrix by a rotation matrix. </summary>
        /// <param name="angle">Specifies the angle of rotation, in degrees.</param>
        /// <param name="x">Specify the x, y, and z coordinates of a vector, respectively.</param>
        /// <param name="y">Specify the x, y, and z coordinates of a vector, respectively.</param>
        /// <param name="z">Specify the x, y, and z coordinates of a vector, respectively.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glRotate.xml" /></remarks>
        public static void Rotatef(float angle, float x, float y, float z) => GLPointers._Rotatef_fnptr(angle, x, y, z);
        
        /// <summary> <b>[requires: v1.0]</b> Multiply the current matrix by a general scalingmatrix. </summary>
        /// <param name="x">Specify scale factors along the x, y, and z axes, respectively.</param>
        /// <param name="y">Specify scale factors along the x, y, and z axes, respectively.</param>
        /// <param name="z">Specify scale factors along the x, y, and z axes, respectively.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glScale.xml" /></remarks>
        public static void Scalef(float x, float y, float z) => GLPointers._Scalef_fnptr(x, y, z);
        
        /// <summary> <b>[requires: v1.0]</b> Set texture environment parameters. </summary>
        /// <param name="target"> Specifies a texture environment. May be GL_TEXTURE_ENV or GL_POINT_SPRITE_OES. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture environment parameter. May be either GL_TEXTURE_ENV_MODE, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE_OES. </param>
        /// <param name="param"> Specifies a single symbolic constant, one of GL_ADD, GL_ADD_SIGNED, GL_DOT3_RGB, GL_DOT3_RGBA, GL_INTERPOLATE, GL_MODULATE, GL_DECAL, GL_BLEND, GL_REPLACE, GL_SUBTRACT, GL_COMBINE, GL_TEXTURE, GL_CONSTANT, GL_PRIMARY_COLOR, GL_PREVIOUS, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, a single boolean value for the point sprite texture coordinate replacement, or 1.0, 2.0, or 4.0 when specifying the GL_RGB_SCALE or GL_ALPHA_SCALE. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glTexEnv.xml" /></remarks>
        public static void TexEnvf(TextureEnvTarget target, TextureEnvParameter pname, float param) => GLPointers._TexEnvf_fnptr((uint)target, (uint)pname, param);
        
        public static void TexEnvfv(TextureEnvTarget target, TextureEnvParameter pname, float* parameters) => GLPointers._TexEnvfv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0]</b> Set texture parameters. </summary>
        /// <param name="target">Specifies the target texture, which must be GL_TEXTURE_2D.</param>
        /// <param name="pname">Specifies the symbolic name of a single-valued texture parameter. Which can be one of the following: GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_GENERATE_MIPMAP.</param>
        /// <param name="param">Specifies the value of pname.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glTexParameter.xml" /></remarks>
        public static void TexParameterf(TextureTarget target, TextureParameterName pname, float param) => GLPointers._TexParameterf_fnptr((uint)target, (uint)pname, param);
        
        public static void TexParameterfv(TextureTarget target, TextureParameterName pname, float* parameters) => GLPointers._TexParameterfv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0]</b> Multiply the current matrix by a translation matrix. </summary>
        /// <param name="x">Specify the x, y, and z coordinates of a translation vector.</param>
        /// <param name="y">Specify the x, y, and z coordinates of a translation vector.</param>
        /// <param name="z">Specify the x, y, and z coordinates of a translation vector.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glTranslate.xml" /></remarks>
        public static void Translatef(float x, float y, float z) => GLPointers._Translatef_fnptr(x, y, z);
        
        /// <summary> <b>[requires: v1.0]</b> Select server-side active texture unit. </summary>
        /// <param name="texture"> Specifies which texture unit to make active. The number of texture units is implementation dependent, but must be at least two. texture must be one of GL_TEXTUREi, where 0 <= i < GL_MAX_TEXTURE_UNITS , which is an implementation-dependent value. The initial value is GL_TEXTURE0. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glActiveTexture.xml" /></remarks>
        public static void ActiveTexture(TextureUnit texture) => GLPointers._ActiveTexture_fnptr((uint)texture);
        
        /// <summary> <b>[requires: v1.0]</b> Specify the alpha test function. </summary>
        /// <param name="func">Specifies the alpha comparison function. Symbolic constants GL_NEVER, GL_LESS, GL_EQUAL, GL_LEQUAL, GL_GREATER, GL_NOTEQUAL, GL_GEQUAL, and GL_ALWAYS are accepted. The initial value is GL_ALWAYS. </param>
        /// <param name="reference">Specifies the reference value that incoming alpha values are compared to. This value is clamped to the range [0, 1], where 0 represents the lowest possible alpha value and 1 the highest possible value. The initial reference value is 0. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glAlphaFunc.xml" /></remarks>
        public static void AlphaFuncx(AlphaFunction func, int reference) => GLPointers._AlphaFuncx_fnptr((uint)func, reference);
        
        /// <summary> <b>[requires: v1.0]</b> Bind a named buffer to a target. </summary>
        /// <param name="target"> Specifies the target to which the buffer is bound. The symbolic constant must be GL_ARRAY_BUFFER or GL_ELEMENT_ARRAY_BUFFER. </param>
        /// <param name="buffer">Specifies the name of a buffer object.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glBindBuffer.xml" /></remarks>
        public static void BindBuffer(BufferTargetARB target, int buffer) => GLPointers._BindBuffer_fnptr((uint)target, buffer);
        
        /// <summary> <b>[requires: v1.0]</b> Bind a named texture to a texturing target. </summary>
        /// <param name="target">Specifies the target to which the texture is bound. Must be GL_TEXTURE_2D.</param>
        /// <param name="texture">Specifies the name of a texture.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glBindTexture.xml" /></remarks>
        public static void BindTexture(TextureTarget target, int texture) => GLPointers._BindTexture_fnptr((uint)target, texture);
        
        /// <summary> <b>[requires: v1.0]</b> Specify pixel arithmetic. </summary>
        /// <param name="sfactor"> Specifies how the red, green, blue, and alpha source blending factors are computed. The following symbolic constants are accepted: GL_ZERO, GL_ONE, GL_DST_COLOR, GL_ONE_MINUS_DST_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, GL_DST_ALPHA, GL_ONE_MINUS_DST_ALPHA, and GL_SRC_ALPHA_SATURATE. The initial value is GL_ONE. </param>
        /// <param name="dfactor">Specifies how the red, green, blue, and alpha destination blending factors are computed. Eight symbolic constants are accepted: GL_ZERO, GL_ONE, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, GL_DST_ALPHA, and GL_ONE_MINUS_DST_ALPHA. The initial value is GL_ZERO.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glBlendFunc.xml" /></remarks>
        public static void BlendFunc(BlendingFactor sfactor, BlendingFactor dfactor) => GLPointers._BlendFunc_fnptr((uint)sfactor, (uint)dfactor);
        
        /// <summary> <b>[requires: v1.0]</b> Creates and initializes a buffer object's data store.. </summary>
        /// <param name="target"> Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER or GL_ELEMENT_ARRAY_BUFFER. </param>
        /// <param name="size">Specifies the size in bytes of the buffer object's new data store.</param>
        /// <param name="data">Specifies a pointer to data that will be copied into the data store for initialization, or NULL if no data is to be copied.</param>
        /// <param name="usage"> Specifies the expected usage pattern of the data store. The symbolic constant must be GL_STATIC_DRAW or GL_DYNAMIC_DRAW. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glBufferData.xml" /></remarks>
        public static void BufferData(BufferTargetARB target, nint size, void* data, BufferUsageARB usage) => GLPointers._BufferData_fnptr((uint)target, size, data, (uint)usage);
        
        /// <summary> <b>[requires: v1.0]</b> Updates a subset of a buffer object's data store.. </summary>
        /// <param name="target"> Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER or GL_ELEMENT_ARRAY_BUFFER. </param>
        /// <param name="offset">Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes.</param>
        /// <param name="size">Specifies the size in bytes of the data store region being replaced.</param>
        /// <param name="data"> Specifies a pointer to the new data that will be copied into the data store.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glBufferSubData.xml" /></remarks>
        public static void BufferSubData(BufferTargetARB target, IntPtr offset, nint size, void* data) => GLPointers._BufferSubData_fnptr((uint)target, offset, size, data);
        
        /// <summary> <b>[requires: v1.0]</b> Clear buffers to preset values. </summary>
        /// <param name="mask">Bitwise OR of masks that indicate the buffers to be cleared. Valid masks are GL_COLOR_BUFFER_BIT, GL_DEPTH_BUFFER_BIT, and GL_STENCIL_BUFFER_BIT.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glClear.xml" /></remarks>
        public static void Clear(ClearBufferMask mask) => GLPointers._Clear_fnptr((uint)mask);
        
        /// <summary> <b>[requires: v1.0]</b> Specify clear values for the color buffer. </summary>
        /// <param name="red">Specify the red, green, blue, and alpha values used when the color buffer is cleared. The initial values are all 0.</param>
        /// <param name="green">Specify the red, green, blue, and alpha values used when the color buffer is cleared. The initial values are all 0.</param>
        /// <param name="blue">Specify the red, green, blue, and alpha values used when the color buffer is cleared. The initial values are all 0.</param>
        /// <param name="alpha">Specify the red, green, blue, and alpha values used when the color buffer is cleared. The initial values are all 0.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glClearColor.xml" /></remarks>
        public static void ClearColorx(int red, int green, int blue, int alpha) => GLPointers._ClearColorx_fnptr(red, green, blue, alpha);
        
        /// <summary> <b>[requires: v1.0]</b> Specify the clear value for the depth buffer. </summary>
        /// <param name="depth">Specifies the depth value used when the depth buffer is cleared. The initial value is 1.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glClearDepth.xml" /></remarks>
        public static void ClearDepthx(int depth) => GLPointers._ClearDepthx_fnptr(depth);
        
        /// <summary> <b>[requires: v1.0]</b> Specify the clear value for the stencil buffer. </summary>
        /// <param name="s">Specifies the index used when the stencil buffer is cleared. The initial value is 0.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glClearStencil.xml" /></remarks>
        public static void ClearStencil(int s) => GLPointers._ClearStencil_fnptr(s);
        
        /// <summary> <b>[requires: v1.0]</b> Select client-side active texture unit. </summary>
        /// <param name="texture"> Specifies which texture unit to make active. The number of texture units is implementation dependent, but must be at least two. texture must be one of GL_TEXTUREi, 0 <= i < GL_MAX_TEXTURE_UNITS , which is an implementation-dependent value. The initial value is GL_TEXTURE0. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glClientActiveTexture.xml" /></remarks>
        public static void ClientActiveTexture(TextureUnit texture) => GLPointers._ClientActiveTexture_fnptr((uint)texture);
        
        /// <summary> <b>[requires: v1.0]</b> Specify a plane against which all geometry is    clipped. </summary>
        /// <param name="plane">Specifies which clipping plane is being positioned. Symbolic names of the form GL_CLIP_PLANEi, where i is an integer between 0 and GL_MAX_CLIP_PLANES -1 , are accepted.</param>
        /// <param name="equation">Specifies the address of an array of four fixed-point or floating-point values. These are the coefficients of a plane equation in object coordinates: p1, p2, p3, and p4, in that order.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glClipPlane.xml" /></remarks>
        public static void ClipPlanex(ClipPlaneName plane, int* equation) => GLPointers._ClipPlanex_fnptr((uint)plane, equation);
        
        /// <summary> <b>[requires: v1.0]</b> Set the current color. </summary>
        /// <param name="red">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <param name="green">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <param name="blue">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <param name="alpha">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glColor.xml" /></remarks>
        public static void Color4ub(byte red, byte green, byte blue, byte alpha) => GLPointers._Color4ub_fnptr(red, green, blue, alpha);
        
        /// <summary> <b>[requires: v1.0]</b> Set the current color. </summary>
        /// <param name="red">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <param name="green">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <param name="blue">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <param name="alpha">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glColor.xml" /></remarks>
        public static void Color4x(int red, int green, int blue, int alpha) => GLPointers._Color4x_fnptr(red, green, blue, alpha);
        
        /// <summary> <b>[requires: v1.0]</b> Enable and disable writing of color buffer        components. </summary>
        /// <param name="red">Specify whether red, green, blue, and alpha can or cannot be written into the color buffer. The initial values are all GL_TRUE, indicating that all color components can be written.</param>
        /// <param name="green">Specify whether red, green, blue, and alpha can or cannot be written into the color buffer. The initial values are all GL_TRUE, indicating that all color components can be written.</param>
        /// <param name="blue">Specify whether red, green, blue, and alpha can or cannot be written into the color buffer. The initial values are all GL_TRUE, indicating that all color components can be written.</param>
        /// <param name="alpha">Specify whether red, green, blue, and alpha can or cannot be written into the color buffer. The initial values are all GL_TRUE, indicating that all color components can be written.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glColorMask.xml" /></remarks>
        public static void ColorMask(bool red, bool green, bool blue, bool alpha) => GLPointers._ColorMask_fnptr((byte)(red ? 1 : 0), (byte)(green ? 1 : 0), (byte)(blue ? 1 : 0), (byte)(alpha ? 1 : 0));
        
        /// <summary> <b>[requires: v1.0]</b> Define an array of colors. </summary>
        /// <param name="size">Specifies the number of components per color. Must be 4. The initial value is 4.</param>
        /// <param name="type">Specifies the data type of each color component in the array. Symbolic constants GL_UNSIGNED_BYTE and GL_FIXED are accepted. However, the initial value is GL_FLOAT.</param>
        /// <param name="stride">Specifies the byte offset between consecutive colors. If stride is 0, the colors are understood to be tightly packed in the array. The initial value is 0.</param>
        /// <param name="pointer">Specifies a pointer to the first component of the first color element in the array.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glColorPointer.xml" /></remarks>
        public static void ColorPointer(int size, ColorPointerType type, int stride, void* pointer) => GLPointers._ColorPointer_fnptr(size, (uint)type, stride, pointer);
        
        /// <summary> <b>[requires: v1.0]</b> Specify a two-dimensional compressed texture image. </summary>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_2D.</param>
        /// <param name="level">Specifies the level-of-detail number. For paletted formats, where all mipmap levels are loaded at once, this parameter is overloaded to represent the negative of the greatest mipmap level included in data. </param>
        /// <param name="internalformat">Specifies the color components in the texture. The following symbolic constants are accepted: GL_PALETTE4_RGB8_OES, GL_PALETTE4_RGBA8_OES, GL_PALETTE4_R5_G6_B5_OES, GL_PALETTE4_RGBA4_OES, GL_PALETTE4_RGB5_A1_OES, GL_PALETTE8_RGB8_OES, GL_PALETTE8_RGBA8_OES, GL_PALETTE8_R5_G6_B5_OES, GL_PALETTE8_RGBA4_OES, and GL_PALETTE8_RGB5_A1_OES.</param>
        /// <param name="width">Specifies the width of the texture image. Must be 2n for some integer n. All implementations support texture images that are at least 64 texels wide.</param>
        /// <param name="height">Specifies the height of the texture image. Must be 2m for some integer m. All implementations support texture images that are at least 64 texels high.</param>
        /// <param name="border">Specifies the width of the border. Must be 0.</param>
        /// <param name="imageSize">Specifies the size of the compressed image data in bytes.</param>
        /// <param name="data">Specifies a pointer to the compressed image data in memory.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glCompressedTexImage2D.xml" /></remarks>
        public static void CompressedTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, void* data) => GLPointers._CompressedTexImage2D_fnptr((uint)target, level, (uint)internalformat, width, height, border, imageSize, data);
        
        /// <summary> <b>[requires: v1.0]</b> Specify a two-dimensional compressed texture subimage. </summary>
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
        public static void CompressedTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, InternalFormat format, int imageSize, void* data) => GLPointers._CompressedTexSubImage2D_fnptr((uint)target, level, xoffset, yoffset, width, height, (uint)format, imageSize, data);
        
        /// <summary> <b>[requires: v1.0]</b> Specify a two-dimensional texture image with pixels from the color buffer. </summary>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_2D.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="internalformat">Specifies the color components of the texture. Must be one of the following symbolic constants: GL_ALPHA, GL_LUMINANCE, GL_LUMINANCE_ALPHA, GL_RGB, or GL_RGBA.</param>
        /// <param name="x">Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.</param>
        /// <param name="y">Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.</param>
        /// <param name="width">Specifies the width of the texture image. Must be 0 or 2n for some integer n.</param>
        /// <param name="height">Specifies the height of the texture image. Must be 0 or 2m for some integer m.</param>
        /// <param name="border">Specifies the width of the border. Must be 0.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glCopyTexImage2D.xml" /></remarks>
        public static void CopyTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int height, int border) => GLPointers._CopyTexImage2D_fnptr((uint)target, level, (uint)internalformat, x, y, width, height, border);
        
        /// <summary> <b>[requires: v1.0]</b> Specify a two-dimensional texture subimage with pixels from the color buffer. </summary>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_2D.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="yoffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="x">Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.</param>
        /// <param name="y">Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glCopyTexSubImage2D.xml" /></remarks>
        public static void CopyTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height) => GLPointers._CopyTexSubImage2D_fnptr((uint)target, level, xoffset, yoffset, x, y, width, height);
        
        /// <summary> <b>[requires: v1.0]</b> Specify whether front- or back-facing polygons are        culled. </summary>
        /// <param name="mode">Specifies whether front- or back-facing polygons are culled. Symbolic constants GL_FRONT, GL_BACK, and GL_FRONT_AND_BACK are accepted. The initial value is GL_BACK.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glCullFace.xml" /></remarks>
        public static void CullFace(TriangleFace mode) => GLPointers._CullFace_fnptr((uint)mode);
        
        /// <summary> <b>[requires: v1.0]</b> Delete named buffer objects. </summary>
        /// <param name="n">Specifies the number of buffer objects to be deleted.</param>
        /// <param name="buffers">Specifies an array of buffer object names to be deleted.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glDeleteBuffers.xml" /></remarks>
        public static void DeleteBuffers(int n, int* buffers) => GLPointers._DeleteBuffers_fnptr(n, buffers);
        
        /// <summary> <b>[requires: v1.0]</b> Delete named textures. </summary>
        /// <param name="n">Specifies the number of textures to be deleted.</param>
        /// <param name="textures">Specifies an array of textures to be deleted.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glDeleteTextures.xml" /></remarks>
        public static void DeleteTextures(int n, int* textures) => GLPointers._DeleteTextures_fnptr(n, textures);
        
        /// <summary> <b>[requires: v1.0]</b> Specify the value used for depth buffer comparisons. </summary>
        /// <param name="func">Specifies the depth comparison function. Symbolic constants GL_NEVER, GL_LESS, GL_EQUAL, GL_LEQUAL, GL_GREATER, GL_NOTEQUAL, GL_GEQUAL, and GL_ALWAYS are accepted. The initial value is GL_LESS.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glDepthFunc.xml" /></remarks>
        public static void DepthFunc(DepthFunction func) => GLPointers._DepthFunc_fnptr((uint)func);
        
        /// <summary> <b>[requires: v1.0]</b> Enable or disable writing into the depth buffer. </summary>
        /// <param name="flag">Specifies whether the depth buffer is enabled for writing. If flag is GL_FALSE, depth buffer writing is disabled, otherwise it is enabled. The initial value is GL_TRUE.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glDepthMask.xml" /></remarks>
        public static void DepthMask(bool flag) => GLPointers._DepthMask_fnptr((byte)(flag ? 1 : 0));
        
        /// <summary> <b>[requires: v1.0]</b> Specify mapping of depth values from normalized        device coordinates to window coordinates. </summary>
        /// <param name="near">Specifies the mapping of the near clipping plane to window coordinates. The initial value is 0.</param>
        /// <param name="far">Specifies the mapping of the far clipping plane to window coordinates. The initial value is 1.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glDepthRange.xml" /></remarks>
        public static void DepthRangex(int n, int f) => GLPointers._DepthRangex_fnptr(n, f);
        
        /// <summary> <b>[requires: v1.0]</b> Enable or disable server-side GL capabilities. </summary>
        /// <param name="cap">Specifies a symbolic constant indicating a GL capability.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glEnable.xml" /></remarks>
        public static void Disable(EnableCap cap) => GLPointers._Disable_fnptr((uint)cap);
        
        /// <summary> <b>[requires: v1.0]</b> Enable or disable client-side capability. </summary>
        /// <param name="array"> Specifies the capability to enable or disable. Symbolic constants GL_COLOR_ARRAY, GL_MATRIX_INDEX_ARRAY_OES, GL_NORMAL_ARRAY, GL_POINT_SIZE_ARRAY_OES, GL_TEXTURE_COORD_ARRAY, and GL_VERTEX_ARRAY, and GL_WEIGHT_ARRAY_OES are accepted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glEnableClientState.xml" /></remarks>
        public static void DisableClientState(EnableCap array) => GLPointers._DisableClientState_fnptr((uint)array);
        
        /// <summary> <b>[requires: v1.0]</b> Render primitives from array data. </summary>
        /// <param name="mode">Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, and GL_TRIANGLES are accepted.</param>
        /// <param name="first">Specifies the starting index in the enabled arrays.</param>
        /// <param name="count">Specifies the number of indices to be rendered.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glDrawArrays.xml" /></remarks>
        public static void DrawArrays(PrimitiveType mode, int first, int count) => GLPointers._DrawArrays_fnptr((uint)mode, first, count);
        
        /// <summary> <b>[requires: v1.0]</b> Render primitives from array data. </summary>
        /// <param name="mode">Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, and GL_TRIANGLES are accepted.</param>
        /// <param name="count">Specifies the number of elements to be rendered.</param>
        /// <param name="type">Specifies the type of the values in indices. Must be either GL_UNSIGNED_BYTE or GL_UNSIGNED_SHORT.</param>
        /// <param name="indices">Specifies a pointer to the location where the indices are stored.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glDrawElements.xml" /></remarks>
        public static void DrawElements(PrimitiveType mode, int count, DrawElementsType type, void* indices) => GLPointers._DrawElements_fnptr((uint)mode, count, (uint)type, indices);
        
        /// <summary> <b>[requires: v1.0]</b> Enable or disable server-side GL capabilities. </summary>
        /// <param name="cap">Specifies a symbolic constant indicating a GL capability.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glEnable.xml" /></remarks>
        public static void Enable(EnableCap cap) => GLPointers._Enable_fnptr((uint)cap);
        
        /// <summary> <b>[requires: v1.0]</b> Enable or disable client-side capability. </summary>
        /// <param name="array"> Specifies the capability to enable or disable. Symbolic constants GL_COLOR_ARRAY, GL_MATRIX_INDEX_ARRAY_OES, GL_NORMAL_ARRAY, GL_POINT_SIZE_ARRAY_OES, GL_TEXTURE_COORD_ARRAY, and GL_VERTEX_ARRAY, and GL_WEIGHT_ARRAY_OES are accepted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glEnableClientState.xml" /></remarks>
        public static void EnableClientState(EnableCap array) => GLPointers._EnableClientState_fnptr((uint)array);
        
        /// <summary> <b>[requires: v1.0]</b> Block until all GL execution is complete. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glFinish.xml" /></remarks>
        public static void Finish() => GLPointers._Finish_fnptr();
        
        /// <summary> <b>[requires: v1.0]</b> Force execution of GL commands in finite time. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glFlush.xml" /></remarks>
        public static void Flush() => GLPointers._Flush_fnptr();
        
        /// <summary> <b>[requires: v1.0]</b> Specify fog parameters. </summary>
        /// <param name="pname">Specifies a single-valued fog parameter. GL_FOG_MODE, GL_FOG_DENSITY, GL_FOG_START, and GL_FOG_END are accepted.</param>
        /// <param name="param">Specifies the value that pname will be set to.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glFog.xml" /></remarks>
        public static void Fogx(FogPName pname, int param) => GLPointers._Fogx_fnptr((uint)pname, param);
        
        public static void Fogxv(FogPName pname, int* param) => GLPointers._Fogxv_fnptr((uint)pname, param);
        
        /// <summary> <b>[requires: v1.0]</b> Define front- and back-facing polygons. </summary>
        /// <param name="mode">Specifies the orientation of front-facing polygons. GL_CW and GL_CCW are accepted. The initial value is GL_CCW.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glFrontFace.xml" /></remarks>
        public static void FrontFace(FrontFaceDirection mode) => GLPointers._FrontFace_fnptr((uint)mode);
        
        /// <summary> <b>[requires: v1.0]</b> Multiply the current matrix by a perspective matrix. </summary>
        /// <param name="left">Specify the coordinates for the left and right vertical clipping planes.</param>
        /// <param name="right">Specify the coordinates for the left and right vertical clipping planes.</param>
        /// <param name="bottom">Specify the coordinates for the bottom and top horizontal clipping planes.</param>
        /// <param name="top">Specify the coordinates for the bottom and top horizontal clipping planes.</param>
        /// <param name="near">Specify the distances to the near and far depth clipping planes. Both distances must be positive.</param>
        /// <param name="far">Specify the distances to the near and far depth clipping planes. Both distances must be positive.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glFrustum.xml" /></remarks>
        public static void Frustumx(int l, int r, int b, int t, int n, int f) => GLPointers._Frustumx_fnptr(l, r, b, t, n, f);
        
        /// <summary> <b>[requires: v1.0]</b> Return the value or values of a selected parameter. </summary>
        /// <param name="pname">Specifies the parameter value to be returned. The symbolic constants in the list below are accepted.</param>
        /// <param name="parameters">Returns the value or values of the specified parameter.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGet.xml" /></remarks>
        public static void GetBooleanv(GetPName pname, bool* data) => GLPointers._GetBooleanv_fnptr((uint)pname, (byte*)data);
        
        /// <summary> <b>[requires: v1.0]</b> Return parameters of a buffer object. </summary>
        /// <param name="target"> Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER or GL_ELEMENT_ARRAY_BUFFER. </param>
        /// <param name="pname"> Specifies the symbolic name of a buffer object parameter. Accepted values are GL_BUFFER_SIZE or GL_BUFFER_USAGE. </param>
        /// <param name="parameters">Returns the requested parameter.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetBufferParameteriv.xml" /></remarks>
        public static void GetBufferParameteriv(BufferTargetARB target, BufferPNameARB pname, int* parameters) => GLPointers._GetBufferParameteriv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0]</b> Return the coefficients of the specified clipping    plane. </summary>
        /// <param name="plane">Specifies a clipping plane. The number of clipping planes depends on the implementation, but at least six clipping planes are supported. Symbolic names of the form GL_CLIP_PLANE i, where i is an integer between 0 and GL_MAX_CLIP_PLANES -1 , are accepted.</param>
        /// <param name="equation">Returns four fixed-point or floating-point values that are the coefficients of the plane equation of plane in eye coordinates in the order p1, p2, p3, and p4. The initial value is (0, 0, 0, 0).</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetClipPlane.xml" /></remarks>
        public static void GetClipPlanex(ClipPlaneName plane, int* equation) => GLPointers._GetClipPlanex_fnptr((uint)plane, equation);
        
        /// <summary> <b>[requires: v1.0]</b> Generate buffer object names. </summary>
        /// <param name="n">Specifies the number of buffer object names to be generated.</param>
        /// <param name="buffers">Specifies an array in which the generated buffer object names are stored.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGenBuffers.xml" /></remarks>
        public static void GenBuffers(int n, int* buffers) => GLPointers._GenBuffers_fnptr(n, buffers);
        
        /// <summary> <b>[requires: v1.0]</b> Generate texture names. </summary>
        /// <param name="n">Specifies the number of texture names to be generated.</param>
        /// <param name="textures">Specifies an array in which the generated texture names are stored.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGenTextures.xml" /></remarks>
        public static void GenTextures(int n, int* textures) => GLPointers._GenTextures_fnptr(n, textures);
        
        /// <summary> <b>[requires: v1.0]</b> Return error information. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetError.xml" /></remarks>
        public static ErrorCode GetError() => (ErrorCode) GLPointers._GetError_fnptr();
        
        /// <summary> <b>[requires: v1.0]</b> Return the value or values of a selected parameter. </summary>
        /// <param name="pname">Specifies the parameter value to be returned. The symbolic constants in the list below are accepted.</param>
        /// <param name="parameters">Returns the value or values of the specified parameter.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGet.xml" /></remarks>
        public static void GetFixedv(GetPName pname, int* parameters) => GLPointers._GetFixedv_fnptr((uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0]</b> Return the value or values of a selected parameter. </summary>
        /// <param name="pname">Specifies the parameter value to be returned. The symbolic constants in the list below are accepted.</param>
        /// <param name="parameters">Returns the value or values of the specified parameter.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGet.xml" /></remarks>
        public static void GetIntegerv(GetPName pname, int* data) => GLPointers._GetIntegerv_fnptr((uint)pname, data);
        
        /// <summary> <b>[requires: v1.0]</b> Return light source parameter values. </summary>
        /// <param name="light"> Specifies a light source. The number of possible lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form GL_LIGHTi where 0<i< GL_MAX_LIGHTS </param>
        /// <param name="pname"> Specifies a light source parameter for light. Accepted symbolic names are GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_POSITION, GL_SPOT_DIRECTION, GL_SPOT_EXPONENT, GL_SPOT_CUTOFF, GL_CONSTANT_ATTENUATION, GL_LINEAR_ATTENUATION, and GL_QUADRATIC_ATTENUATION. </param>
        /// <param name="parameters"> Returns the requested data. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetLight.xml" /></remarks>
        public static void GetLightxv(LightName light, LightParameter pname, int* parameters) => GLPointers._GetLightxv_fnptr((uint)light, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0]</b> Return material parameters values. </summary>
        /// <param name="face"> Specifies which of the two materials is being queried. GL_FRONT or GL_BACK are accepted, representing the front and back materials, respectively. </param>
        /// <param name="pname"> Specifies the material parameter to return. Accepted symbolic names are GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_EMISSION, and GL_SHININESS. </param>
        /// <param name="parameters"> Returns the requested data. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetMaterial.xml" /></remarks>
        public static void GetMaterialxv(TriangleFace face, MaterialParameter pname, int* parameters) => GLPointers._GetMaterialxv_fnptr((uint)face, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0 | GL_KHR_debug]</b> Return the address of the specified pointer. </summary>
        /// <param name="pname"> Specifies the array or buffer pointer to be returned. Accepted symbolic names are GL_COLOR_ARRAY_POINTER, GL_MATRIX_INDEX_ARRAY_POINTER_OES, GL_NORMAL_ARRAY_POINTER, GL_POINT_SIZE_ARRAY_POINTER_OES, GL_TEXTURE_COORD_ARRAY_POINTER, and GL_VERTEX_ARRAY_POINTER., and GL_WEIGHT_ARRAY_POINTER_OES. </param>
        /// <param name="parameters"> Returns the pointer value specified by pname. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetPointerv.xml" /></remarks>
        public static void GetPointerv(GetPointervPName pname, void** parameters) => GLPointers._GetPointerv_fnptr((uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0]</b> Return a string describing the current GL        connection. </summary>
        /// <param name="name">Specifies a symbolic constant, one of GL_VENDOR, GL_RENDERER, GL_VERSION, or GL_EXTENSIONS.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetString.xml" /></remarks>
        public static byte* GetString_(StringName name) => GLPointers._GetString_fnptr((uint)name);
        
        /// <summary> <b>[requires: v1.0]</b> Return texture environment parameters. </summary>
        /// <param name="target"> Specifies a texture environment. May be GL_TEXTURE_ENV or GL_POINT_SPRITE_OES. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture environment parameter. Accepted values are GL_TEXTURE_ENV_MODE, GL_TEXTURE_ENV_COLOR, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE_OES. </param>
        /// <param name="parameters"> Returns the requested data. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetTexEnv.xml" /></remarks>
        public static void GetTexEnviv(TextureEnvTarget target, TextureEnvParameter pname, int* parameters) => GLPointers._GetTexEnviv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0]</b> Return texture environment parameters. </summary>
        /// <param name="target"> Specifies a texture environment. May be GL_TEXTURE_ENV or GL_POINT_SPRITE_OES. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture environment parameter. Accepted values are GL_TEXTURE_ENV_MODE, GL_TEXTURE_ENV_COLOR, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE_OES. </param>
        /// <param name="parameters"> Returns the requested data. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetTexEnv.xml" /></remarks>
        public static void GetTexEnvxv(TextureEnvTarget target, TextureEnvParameter pname, int* parameters) => GLPointers._GetTexEnvxv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0]</b> Return texture parameter values. </summary>
        /// <param name="target">Specifies the target texture, which must be GL_TEXTURE_2D.</param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. Which can be one of the following: GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_GENERATE_MIPMAP. </param>
        /// <param name="parameters">Returns texture parameters.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetTexParameter.xml" /></remarks>
        public static void GetTexParameteriv(TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._GetTexParameteriv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0]</b> Return texture parameter values. </summary>
        /// <param name="target">Specifies the target texture, which must be GL_TEXTURE_2D.</param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. Which can be one of the following: GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_GENERATE_MIPMAP. </param>
        /// <param name="parameters">Returns texture parameters.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetTexParameter.xml" /></remarks>
        public static void GetTexParameterxv(TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._GetTexParameterxv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0]</b> Specify implementation-specific hints. </summary>
        /// <param name="target">Specifies a symbolic constant indicating the behavior to be controlled. GL_FOG_HINT , GL_GENERATE_MIPMAP_HINT , GL_LINE_SMOOTH_HINT , GL_PERSPECTIVE_CORRECTION_HINT, and GL_POINT_SMOOTH_HINT are accepted.</param>
        /// <param name="mode">Specifies a symbolic constant indicating the desired behavior. GL_FASTEST, GL_NICEST, and GL_DONT_CARE are accepted.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glHint.xml" /></remarks>
        public static void Hint(HintTarget target, HintMode mode) => GLPointers._Hint_fnptr((uint)target, (uint)mode);
        
        /// <summary> <b>[requires: v1.0]</b> Determine if a name corresponds to a buffer object. </summary>
        /// <param name="buffer"> Specifies a value that may be the name of a buffer object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glIsBuffer.xml" /></remarks>
        public static bool IsBuffer(int buffer) => GLPointers._IsBuffer_fnptr(buffer) != 0;
        
        /// <summary> <b>[requires: v1.0]</b> Test whether a capability is enabled. </summary>
        /// <param name="cap"> Specifies a symbolic constant indicating a GL capability. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glIsEnabled.xml" /></remarks>
        public static bool IsEnabled(EnableCap cap) => GLPointers._IsEnabled_fnptr((uint)cap) != 0;
        
        /// <summary> <b>[requires: v1.0]</b> Determine if a name corresponds to a texture. </summary>
        /// <param name="texture"> Specifies a value that may be the name of a texture. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glIsTexture.xml" /></remarks>
        public static bool IsTexture(int texture) => GLPointers._IsTexture_fnptr(texture) != 0;
        
        /// <summary> <b>[requires: v1.0]</b> Set the lighting model parameters. </summary>
        /// <param name="pname">Specifies a single-valued lighting model parameter. Must be GL_LIGHT_MODEL_TWO_SIDE.</param>
        /// <param name="param">Specifies the value that param will be set to.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glLightModel.xml" /></remarks>
        public static void LightModelx(LightModelParameter pname, int param) => GLPointers._LightModelx_fnptr((uint)pname, param);
        
        public static void LightModelxv(LightModelParameter pname, int* param) => GLPointers._LightModelxv_fnptr((uint)pname, param);
        
        /// <summary> <b>[requires: v1.0]</b> Set light source parameters. </summary>
        /// <param name="light">Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form GL_LIGHTi where 0 <= i < GL_MAX_LIGHTS . </param>
        /// <param name="pname">Specifies a single-valued light source parameter for light. GL_SPOT_EXPONENT, GL_SPOT_CUTOFF, GL_CONSTANT_ATTENUATION, GL_LINEAR_ATTENUATION, and GL_QUADRATIC_ATTENUATION are accepted.</param>
        /// <param name="param">Specifies the value that parameter pname of light source light will be set to.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glLight.xml" /></remarks>
        public static void Lightx(LightName light, LightParameter pname, int param) => GLPointers._Lightx_fnptr((uint)light, (uint)pname, param);
        
        public static void Lightxv(LightName light, LightParameter pname, int* parameters) => GLPointers._Lightxv_fnptr((uint)light, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0]</b> Specify the width of rasterized lines. </summary>
        /// <param name="width">Specifies the width of rasterized lines. The initial value is 1.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glLineWidth.xml" /></remarks>
        public static void LineWidthx(int width) => GLPointers._LineWidthx_fnptr(width);
        
        /// <summary> <b>[requires: v1.0]</b> Replace the current matrix with the identitymatrix. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glLoadIdentity.xml" /></remarks>
        public static void LoadIdentity() => GLPointers._LoadIdentity_fnptr();
        
        /// <summary> <b>[requires: v1.0]</b> Replace the current matrix with the specifiedmatrix. </summary>
        /// <param name="m">Specifies a pointer to 16 consecutive values, which are used as the elements of a 4x4 column-major matrix.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glLoadMatrix.xml" /></remarks>
        public static void LoadMatrixx(int* m) => GLPointers._LoadMatrixx_fnptr(m);
        
        /// <summary> <b>[requires: v1.0]</b> Specify a logical pixel operation. </summary>
        /// <param name="opcode">Specifies a symbolic constant that selects a logical operation. The following symbols are accepted: GL_CLEAR, GL_SET, GL_COPY, GL_COPY_INVERTED, GL_NOOP, GL_INVERT, GL_AND, GL_NAND, GL_OR, GL_NOR, GL_XOR, GL_EQUIV, GL_AND_REVERSE, GL_AND_INVERTED, GL_OR_REVERSE, and GL_OR_INVERTED. The initial value is GL_COPY.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glLogicOp.xml" /></remarks>
        public static void LogicOp(LogicOp opcode) => GLPointers._LogicOp_fnptr((uint)opcode);
        
        /// <summary> <b>[requires: v1.0]</b> Specify material parameters for the lighting model. </summary>
        /// <param name="face">Specifies which face or faces are being updated. Must be GL_FRONT_AND_BACK.</param>
        /// <param name="pname">Specifies the single-valued material parameter of the face or faces that is being updated. Must be GL_SHININESS.</param>
        /// <param name="param">Specifies the value that parameter GL_SHININESS will be set to.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glMaterial.xml" /></remarks>
        public static void Materialx(TriangleFace face, MaterialParameter pname, int param) => GLPointers._Materialx_fnptr((uint)face, (uint)pname, param);
        
        public static void Materialxv(TriangleFace face, MaterialParameter pname, int* param) => GLPointers._Materialxv_fnptr((uint)face, (uint)pname, param);
        
        /// <summary> <b>[requires: v1.0]</b> Specify which matrix is the current matrix. </summary>
        /// <param name="mode"> Specifies which matrix stack is the target for subsequent matrix operations. These values are accepted: GL_MODELVIEW, GL_PROJECTION, and GL_TEXTURE., and GL_MATRIX_PALETTE_OES. The initial value is GL_MODELVIEW. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glMatrixMode.xml" /></remarks>
        public static void MatrixMode(MatrixMode mode) => GLPointers._MatrixMode_fnptr((uint)mode);
        
        /// <summary> <b>[requires: v1.0]</b> Multiply the current matrix with the specifiedmatrix. </summary>
        /// <param name="m">Points to 16 consecutive values that are used as the elements of a 4x4 column-major matrix.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glMultMatrix.xml" /></remarks>
        public static void MultMatrixx(int* m) => GLPointers._MultMatrixx_fnptr(m);
        
        /// <summary> <b>[requires: v1.0]</b> Set the current texture coordinates. </summary>
        /// <param name="target">Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least twoone. Symbolic constant must be one of GL_TEXTUREi, where i ranges from 0 to GL_MAX_TEXTURE_UNITS - 1, which is an implementation-dependent value.</param>
        /// <param name="s">Specify s, t, r, and q texture coordinates for target texture unit.</param>
        /// <param name="t">Specify s, t, r, and q texture coordinates for target texture unit.</param>
        /// <param name="r">Specify s, t, r, and q texture coordinates for target texture unit.</param>
        /// <param name="q">Specify s, t, r, and q texture coordinates for target texture unit.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glMultiTexCoord.xml" /></remarks>
        public static void MultiTexCoord4x(TextureUnit texture, int s, int t, int r, int q) => GLPointers._MultiTexCoord4x_fnptr((uint)texture, s, t, r, q);
        
        /// <summary> <b>[requires: v1.0]</b> Set the current normal vector. </summary>
        /// <param name="nx">Specify the x, y, and z coordinates of the new current normal. The initial value is (0, 0, 1).</param>
        /// <param name="ny">Specify the x, y, and z coordinates of the new current normal. The initial value is (0, 0, 1).</param>
        /// <param name="nz">Specify the x, y, and z coordinates of the new current normal. The initial value is (0, 0, 1).</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glNormal.xml" /></remarks>
        public static void Normal3x(int nx, int ny, int nz) => GLPointers._Normal3x_fnptr(nx, ny, nz);
        
        /// <summary> <b>[requires: v1.0]</b> Define an array of normals. </summary>
        /// <param name="type">Specifies the data type of each coordinate in the array. Symbolic constants GL_BYTE, GL_SHORT, and GL_FIXED are accepted. However, the initial value is GL_FLOAT.</param>
        /// <param name="stride">Specifies the byte offset between consecutive normals. If stride is 0, the normals are understood to be tightly packed in the array. The initial value is 0.</param>
        /// <param name="pointer">Specifies a pointer to the first coordinate of the first normal in the array. The initial value is 0.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glNormalPointer.xml" /></remarks>
        public static void NormalPointer(NormalPointerType type, int stride, void* pointer) => GLPointers._NormalPointer_fnptr((uint)type, stride, pointer);
        
        /// <summary> <b>[requires: v1.0]</b> Multiply the current matrix with an orthographicmatrix. </summary>
        /// <param name="left">Specify the coordinates for the left and right vertical clipping planes.</param>
        /// <param name="right">Specify the coordinates for the left and right vertical clipping planes.</param>
        /// <param name="bottom">Specify the coordinates for the bottom and top horizontal clipping planes.</param>
        /// <param name="top">Specify the coordinates for the bottom and top horizontal clipping planes.</param>
        /// <param name="near">Specify the distances to the nearer and farther depth clipping planes. These values are negative if the plane is to be behind the viewer.</param>
        /// <param name="far">Specify the distances to the nearer and farther depth clipping planes. These values are negative if the plane is to be behind the viewer.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glOrtho.xml" /></remarks>
        public static void Orthox(int l, int r, int b, int t, int n, int f) => GLPointers._Orthox_fnptr(l, r, b, t, n, f);
        
        /// <summary> <b>[requires: v1.0]</b> Set pixel storage modes. </summary>
        /// <param name="pname">Specifies the symbolic name of the parameter to be set. GL_PACK_ALIGNMENT affects the packing of pixel data into memory. GL_UNPACK_ALIGNMENT affects the unpacking of pixel data from memory.</param>
        /// <param name="param">Specifies the value that pname is set to.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glPixelStorei.xml" /></remarks>
        public static void PixelStorei(PixelStoreParameter pname, int param) => GLPointers._PixelStorei_fnptr((uint)pname, param);
        
        /// <summary> <b>[requires: v1.0]</b> Specify parameters for point rasterization. </summary>
        /// <param name="pname"> Specifies the single-valued parameter to be updated. Can be either GL_POINT_SIZE_MIN, GL_POINT_SIZE_MAX, or GL_POINT_FADE_THRESHOLD_SIZE. </param>
        /// <param name="param"> Specifies the value that the parameter will be set to. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glPointParameter.xml" /></remarks>
        public static void PointParameterx(PointParameterNameARB pname, int param) => GLPointers._PointParameterx_fnptr((uint)pname, param);
        
        public static void PointParameterxv(PointParameterNameARB pname, int* parameters) => GLPointers._PointParameterxv_fnptr((uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0]</b> Specify the diameter of rasterized points. </summary>
        /// <param name="size">Specifies the diameter of rasterized points. The initial value is 1.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glPointSize.xml" /></remarks>
        public static void PointSizex(int size) => GLPointers._PointSizex_fnptr(size);
        
        /// <summary> <b>[requires: v1.0]</b> Set the scale and units used to calculate depth        values. </summary>
        /// <param name="factor">Specifies a scale factor that is used to create a variable depth offset for each polygon. The initial value is 0.</param>
        /// <param name="units">Is multiplied by an implementation-specific value to create a constant depth offset. The initial value is 0.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glPolygonOffset.xml" /></remarks>
        public static void PolygonOffsetx(int factor, int units) => GLPointers._PolygonOffsetx_fnptr(factor, units);
        
        /// <summary> <b>[requires: v1.0]</b> Push and pop the current matrix stack. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glPushMatrix.xml" /></remarks>
        public static void PopMatrix() => GLPointers._PopMatrix_fnptr();
        
        /// <summary> <b>[requires: v1.0]</b> Push and pop the current matrix stack. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glPushMatrix.xml" /></remarks>
        public static void PushMatrix() => GLPointers._PushMatrix_fnptr();
        
        /// <summary> <b>[requires: v1.0]</b> Read a block of pixels from the color buffer. </summary>
        /// <param name="x">Specify the window coordinates of the first pixel that is read from the color buffer. This location is the lower left corner of a rectangular block of pixels.</param>
        /// <param name="y">Specify the window coordinates of the first pixel that is read from the color buffer. This location is the lower left corner of a rectangular block of pixels.</param>
        /// <param name="width">Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.</param>
        /// <param name="height">Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.</param>
        /// <param name="format">Specifies the format of the pixel data. Must be either GL_RGBA or the value of GL_IMPLEMENTATION_COLOR_READ_FORMAT_OES.</param>
        /// <param name="type">Specifies the data type of the pixel data. Must be either GL_UNSIGNED_BYTE or the value of GL_IMPLEMENTATION_COLOR_READ_TYPE_OES.</param>
        /// <param name="pixels">Returns the pixel data.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glReadPixels.xml" /></remarks>
        public static void ReadPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, void* pixels) => GLPointers._ReadPixels_fnptr(x, y, width, height, (uint)format, (uint)type, pixels);
        
        /// <summary> <b>[requires: v1.0]</b> Multiply the current matrix by a rotation matrix. </summary>
        /// <param name="angle">Specifies the angle of rotation, in degrees.</param>
        /// <param name="x">Specify the x, y, and z coordinates of a vector, respectively.</param>
        /// <param name="y">Specify the x, y, and z coordinates of a vector, respectively.</param>
        /// <param name="z">Specify the x, y, and z coordinates of a vector, respectively.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glRotate.xml" /></remarks>
        public static void Rotatex(int angle, int x, int y, int z) => GLPointers._Rotatex_fnptr(angle, x, y, z);
        
        /// <summary> <b>[requires: v1.0]</b> Specify mask to modify multisampled pixel fragments. </summary>
        /// <param name="value">Specifies the coverage of the modification mask. The value is clamped to the range [0, 1], where 0 represents no coverage and 1 full coverage. The initial value is 1.</param>
        /// <param name="invert">Specifies whether the modification mask implied by value is inverted or not. The initial value is GL_FALSE. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glSampleCoverage.xml" /></remarks>
        public static void SampleCoverage(float value, bool invert) => GLPointers._SampleCoverage_fnptr(value, (byte)(invert ? 1 : 0));
        
        /// <summary> <b>[requires: v1.0]</b> Specify mask to modify multisampled pixel fragments. </summary>
        /// <param name="value">Specifies the coverage of the modification mask. The value is clamped to the range [0, 1], where 0 represents no coverage and 1 full coverage. The initial value is 1.</param>
        /// <param name="invert">Specifies whether the modification mask implied by value is inverted or not. The initial value is GL_FALSE. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glSampleCoverage.xml" /></remarks>
        public static void SampleCoveragex(int value, bool invert) => GLPointers._SampleCoveragex_fnptr(value, (byte)(invert ? 1 : 0));
        
        /// <summary> <b>[requires: v1.0]</b> Multiply the current matrix by a general scalingmatrix. </summary>
        /// <param name="x">Specify scale factors along the x, y, and z axes, respectively.</param>
        /// <param name="y">Specify scale factors along the x, y, and z axes, respectively.</param>
        /// <param name="z">Specify scale factors along the x, y, and z axes, respectively.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glScale.xml" /></remarks>
        public static void Scalex(int x, int y, int z) => GLPointers._Scalex_fnptr(x, y, z);
        
        /// <summary> <b>[requires: v1.0]</b> Define the scissor box. </summary>
        /// <param name="x">Specify the lower left corner of the scissor box, in pixels. The initial value is (0, 0).</param>
        /// <param name="y">Specify the lower left corner of the scissor box, in pixels. The initial value is (0, 0).</param>
        /// <param name="width">Specify the width and height of the scissor box. When a GL context is first attached to a surface (e.g. window), width and height are set to the dimensions of that surface.</param>
        /// <param name="height">Specify the width and height of the scissor box. When a GL context is first attached to a surface (e.g. window), width and height are set to the dimensions of that surface.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glScissor.xml" /></remarks>
        public static void Scissor(int x, int y, int width, int height) => GLPointers._Scissor_fnptr(x, y, width, height);
        
        /// <summary> <b>[requires: v1.0]</b> Select flat or smooth shading. </summary>
        /// <param name="mode">Specifies a symbolic value representing a shading technique. Accepted values are GL_FLAT and GL_SMOOTH. The initial value is GL_SMOOTH.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glShadeModel.xml" /></remarks>
        public static void ShadeModel(ShadingModel mode) => GLPointers._ShadeModel_fnptr((uint)mode);
        
        /// <summary> <b>[requires: v1.0]</b> Set function and reference value for stencil        testing. </summary>
        /// <param name="func">Specifies the test function. Eight tokens are valid: GL_NEVER, GL_LESS, GL_LEQUAL, GL_GREATER, GL_GEQUAL, GL_EQUAL, GL_NOTEQUAL, and GL_ALWAYS. The initial value is GL_ALWAYS.</param>
        /// <param name="reference">Specifies the reference value for the stencil test. ref is clamped to the range [ 0 , 2n-1 ] , where n is the number of bitplanes in the stencil buffer. The initial value is 0.</param>
        /// <param name="mask">Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The initial value is all 1's.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glStencilFunc.xml" /></remarks>
        public static void StencilFunc(StencilFunction func, int reference, uint mask) => GLPointers._StencilFunc_fnptr((uint)func, reference, mask);
        
        /// <summary> <b>[requires: v1.0]</b> Control the writing of individual bits in the        stencil planes. </summary>
        /// <param name="mask">Specifies a bit mask to enable and disable writing of individual bits in the stencil planes. The initial value is all 1's.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glStencilMask.xml" /></remarks>
        public static void StencilMask(uint mask) => GLPointers._StencilMask_fnptr(mask);
        
        /// <summary> <b>[requires: v1.0]</b> Set stencil test actions. </summary>
        /// <param name="fail">Specifies the action to take when the stencil test fails. Six symbolic constants are accepted: GL_KEEP, GL_ZERO, GL_REPLACE, GL_INCR, GL_DECR, and GL_INVERT. The initial value is GL_KEEP.</param>
        /// <param name="zfail">Specifies the stencil action when the stencil test passes, but the depth test fails. zfail accepts the same symbolic constants as fail. The initial value is GL_KEEP.</param>
        /// <param name="zpass">Specifies the stencil action when both the stencil test and the depth test pass, or when the stencil test passes and either there is no depth buffer or depth testing is not enabled. zpass accepts the same symbolic constants as fail. The initial value is GL_KEEP.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glStencilOp.xml" /></remarks>
        public static void StencilOp(StencilOp fail, StencilOp zfail, StencilOp zpass) => GLPointers._StencilOp_fnptr((uint)fail, (uint)zfail, (uint)zpass);
        
        /// <summary> <b>[requires: v1.0]</b> Define an array of texture coordinates. </summary>
        /// <param name="size">Specifies the number of coordinates per array element. Must be 2, 3 or 4. The initial value is 4.</param>
        /// <param name="type">Specifies the data type of each texture coordinate. Symbolic constants GL_BYTE, GL_SHORT, and GL_FIXED are accepted. However, the initial value is GL_FLOAT.</param>
        /// <param name="stride">Specifies the byte offset between consecutive array elements. If stride is 0, the array elements are understood to be tightly packed. The initial value is 0.</param>
        /// <param name="pointer">Specifies a pointer to the first coordinate of the first element in the array. The initial value is 0.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glTexCoordPointer.xml" /></remarks>
        public static void TexCoordPointer(int size, TexCoordPointerType type, int stride, void* pointer) => GLPointers._TexCoordPointer_fnptr(size, (uint)type, stride, pointer);
        
        /// <summary> <b>[requires: v1.0]</b> Set texture environment parameters. </summary>
        /// <param name="target"> Specifies a texture environment. May be GL_TEXTURE_ENV or GL_POINT_SPRITE_OES. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture environment parameter. May be either GL_TEXTURE_ENV_MODE, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE_OES. </param>
        /// <param name="param"> Specifies a single symbolic constant, one of GL_ADD, GL_ADD_SIGNED, GL_DOT3_RGB, GL_DOT3_RGBA, GL_INTERPOLATE, GL_MODULATE, GL_DECAL, GL_BLEND, GL_REPLACE, GL_SUBTRACT, GL_COMBINE, GL_TEXTURE, GL_CONSTANT, GL_PRIMARY_COLOR, GL_PREVIOUS, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, a single boolean value for the point sprite texture coordinate replacement, or 1.0, 2.0, or 4.0 when specifying the GL_RGB_SCALE or GL_ALPHA_SCALE. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glTexEnv.xml" /></remarks>
        public static void TexEnvi(TextureEnvTarget target, TextureEnvParameter pname, int param) => GLPointers._TexEnvi_fnptr((uint)target, (uint)pname, param);
        
        /// <summary> <b>[requires: v1.0]</b> Set texture environment parameters. </summary>
        /// <param name="target"> Specifies a texture environment. May be GL_TEXTURE_ENV or GL_POINT_SPRITE_OES. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture environment parameter. May be either GL_TEXTURE_ENV_MODE, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE_OES. </param>
        /// <param name="param"> Specifies a single symbolic constant, one of GL_ADD, GL_ADD_SIGNED, GL_DOT3_RGB, GL_DOT3_RGBA, GL_INTERPOLATE, GL_MODULATE, GL_DECAL, GL_BLEND, GL_REPLACE, GL_SUBTRACT, GL_COMBINE, GL_TEXTURE, GL_CONSTANT, GL_PRIMARY_COLOR, GL_PREVIOUS, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, a single boolean value for the point sprite texture coordinate replacement, or 1.0, 2.0, or 4.0 when specifying the GL_RGB_SCALE or GL_ALPHA_SCALE. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glTexEnv.xml" /></remarks>
        public static void TexEnvx(TextureEnvTarget target, TextureEnvParameter pname, int param) => GLPointers._TexEnvx_fnptr((uint)target, (uint)pname, param);
        
        public static void TexEnviv(TextureEnvTarget target, TextureEnvParameter pname, int* parameters) => GLPointers._TexEnviv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void TexEnvxv(TextureEnvTarget target, TextureEnvParameter pname, int* parameters) => GLPointers._TexEnvxv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0]</b> Specify a two-dimensional texture image. </summary>
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
        public static void TexImage2D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, PixelFormat format, PixelType type, void* pixels) => GLPointers._TexImage2D_fnptr((uint)target, level, (int)internalformat, width, height, border, (uint)format, (uint)type, pixels);
        
        /// <summary> <b>[requires: v1.0]</b> Set texture parameters. </summary>
        /// <param name="target">Specifies the target texture, which must be GL_TEXTURE_2D.</param>
        /// <param name="pname">Specifies the symbolic name of a single-valued texture parameter. Which can be one of the following: GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_GENERATE_MIPMAP.</param>
        /// <param name="param">Specifies the value of pname.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glTexParameter.xml" /></remarks>
        public static void TexParameteri(TextureTarget target, TextureParameterName pname, int param) => GLPointers._TexParameteri_fnptr((uint)target, (uint)pname, param);
        
        /// <summary> <b>[requires: v1.0]</b> Set texture parameters. </summary>
        /// <param name="target">Specifies the target texture, which must be GL_TEXTURE_2D.</param>
        /// <param name="pname">Specifies the symbolic name of a single-valued texture parameter. Which can be one of the following: GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_GENERATE_MIPMAP.</param>
        /// <param name="param">Specifies the value of pname.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glTexParameter.xml" /></remarks>
        public static void TexParameterx(TextureTarget target, GetTextureParameter pname, int param) => GLPointers._TexParameterx_fnptr((uint)target, (uint)pname, param);
        
        public static void TexParameteriv(TextureTarget target, TextureParameterName pname, int* parameters) => GLPointers._TexParameteriv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void TexParameterxv(TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._TexParameterxv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v1.0]</b> Specify a two-dimensional texture subimage. </summary>
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
        public static void TexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, void* pixels) => GLPointers._TexSubImage2D_fnptr((uint)target, level, xoffset, yoffset, width, height, (uint)format, (uint)type, pixels);
        
        /// <summary> <b>[requires: v1.0]</b> Multiply the current matrix by a translation matrix. </summary>
        /// <param name="x">Specify the x, y, and z coordinates of a translation vector.</param>
        /// <param name="y">Specify the x, y, and z coordinates of a translation vector.</param>
        /// <param name="z">Specify the x, y, and z coordinates of a translation vector.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glTranslate.xml" /></remarks>
        public static void Translatex(int x, int y, int z) => GLPointers._Translatex_fnptr(x, y, z);
        
        /// <summary> <b>[requires: v1.0]</b> Define an array of vertex coordinates. </summary>
        /// <param name="size">Specifies the number of coordinates per vertex. Must be 2, 3, or 4. The initial value is 4.</param>
        /// <param name="type">Specifies the data type of each vertex coordinate in the array. Symbolic constants GL_BYTE, GL_SHORT, and GL_FIXED, are accepted. However, the initial value is GL_FLOAT.</param>
        /// <param name="stride">Specifies the byte offset between consecutive vertices. If stride is 0, the vertices are understood to be tightly packed in the array. The initial value is 0.</param>
        /// <param name="pointer">Specifies a pointer to the first coordinate of the first vertex in the array. The initial value is 0.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glVertexPointer.xml" /></remarks>
        public static void VertexPointer(int size, VertexPointerType type, int stride, void* pointer) => GLPointers._VertexPointer_fnptr(size, (uint)type, stride, pointer);
        
        /// <summary> <b>[requires: v1.0]</b> Set the viewport. </summary>
        /// <param name="x">Specify the lower left corner of the viewport rectangle, in pixels. The initial value is (0, 0).</param>
        /// <param name="y">Specify the lower left corner of the viewport rectangle, in pixels. The initial value is (0, 0).</param>
        /// <param name="width">Specify the width and height of the viewport. When a GL context is first attached to a surface (e.g. window), width and height are set to the dimensions of that surface.</param>
        /// <param name="height">Specify the width and height of the viewport. When a GL context is first attached to a surface (e.g. window), width and height are set to the dimensions of that surface.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glViewport.xml" /></remarks>
        public static void Viewport(int x, int y, int width, int height) => GLPointers._Viewport_fnptr(x, y, width, height);
        
        public static unsafe partial class APPLE
        {
            /// <summary> <b>[requires: GL_APPLE_copy_texture_levels]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void CopyTextureLevelsAPPLE(uint destinationTexture, uint sourceTexture, int sourceBaseLevel, int sourceLevelCount) => GLPointers._CopyTextureLevelsAPPLE_fnptr(destinationTexture, sourceTexture, sourceBaseLevel, sourceLevelCount);
            
            /// <summary> <b>[requires: GL_APPLE_framebuffer_multisample]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void RenderbufferStorageMultisampleAPPLE(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => GLPointers._RenderbufferStorageMultisampleAPPLE_fnptr((uint)target, samples, (uint)internalformat, width, height);
            
            /// <summary> <b>[requires: GL_APPLE_framebuffer_multisample]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ResolveMultisampleFramebufferAPPLE() => GLPointers._ResolveMultisampleFramebufferAPPLE_fnptr();
            
            /// <summary> <b>[requires: GL_APPLE_sync]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static GLSync FenceSyncAPPLE(SyncCondition condition, SyncBehaviorFlags flags) => (GLSync) GLPointers._FenceSyncAPPLE_fnptr((uint)condition, (uint)flags);
            
            /// <summary> <b>[requires: GL_APPLE_sync]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static bool IsSyncAPPLE(GLSync sync) => GLPointers._IsSyncAPPLE_fnptr((IntPtr)sync) != 0;
            
            /// <summary> <b>[requires: GL_APPLE_sync]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DeleteSyncAPPLE(GLSync sync) => GLPointers._DeleteSyncAPPLE_fnptr((IntPtr)sync);
            
            /// <summary> <b>[requires: GL_APPLE_sync]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static SyncStatus ClientWaitSyncAPPLE(GLSync sync, SyncObjectMask flags, ulong timeout) => (SyncStatus) GLPointers._ClientWaitSyncAPPLE_fnptr((IntPtr)sync, (uint)flags, timeout);
            
            /// <summary> <b>[requires: GL_APPLE_sync]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void WaitSyncAPPLE(GLSync sync, SyncBehaviorFlags flags, ulong timeout) => GLPointers._WaitSyncAPPLE_fnptr((IntPtr)sync, (uint)flags, timeout);
            
            /// <summary> <b>[requires: GL_APPLE_sync]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetInteger64vAPPLE(GetPName pname, long* parameters) => GLPointers._GetInteger64vAPPLE_fnptr((uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_APPLE_sync]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetSyncivAPPLE(GLSync sync, SyncParameterName pname, int count, int* length, int* values) => GLPointers._GetSyncivAPPLE_fnptr((IntPtr)sync, (uint)pname, count, length, values);
            
        }
        public static unsafe partial class EXT
        {
            /// <summary> <b>[requires: GL_EXT_blend_minmax]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BlendEquationEXT(BlendEquationModeEXT mode) => GLPointers._BlendEquationEXT_fnptr((uint)mode);
            
            /// <summary> <b>[requires: GL_EXT_debug_marker]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void InsertEventMarkerEXT(int length, byte* marker) => GLPointers._InsertEventMarkerEXT_fnptr(length, marker);
            
            /// <summary> <b>[requires: GL_EXT_debug_marker]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PushGroupMarkerEXT(int length, byte* marker) => GLPointers._PushGroupMarkerEXT_fnptr(length, marker);
            
            /// <summary> <b>[requires: GL_EXT_debug_marker]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PopGroupMarkerEXT() => GLPointers._PopGroupMarkerEXT_fnptr();
            
            /// <summary> <b>[requires: GL_EXT_discard_framebuffer]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DiscardFramebufferEXT(FramebufferTarget target, int numAttachments, InvalidateFramebufferAttachment* attachments) => GLPointers._DiscardFramebufferEXT_fnptr((uint)target, numAttachments, (uint*)attachments);
            
            /// <summary> <b>[requires: GL_EXT_map_buffer_range]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void* MapBufferRangeEXT(BufferTargetARB target, IntPtr offset, nint length, MapBufferAccessMask access) => GLPointers._MapBufferRangeEXT_fnptr((uint)target, offset, length, (uint)access);
            
            /// <summary> <b>[requires: GL_EXT_map_buffer_range]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FlushMappedBufferRangeEXT(BufferTargetARB target, IntPtr offset, nint length) => GLPointers._FlushMappedBufferRangeEXT_fnptr((uint)target, offset, length);
            
            /// <summary> <b>[requires: GL_EXT_multi_draw_arrays]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiDrawArraysEXT(PrimitiveType mode, int* first, int* count, int primcount) => GLPointers._MultiDrawArraysEXT_fnptr((uint)mode, first, count, primcount);
            
            /// <summary> <b>[requires: GL_EXT_multi_draw_arrays]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiDrawElementsEXT(PrimitiveType mode, int* count, DrawElementsType type, void** indices, int primcount) => GLPointers._MultiDrawElementsEXT_fnptr((uint)mode, count, (uint)type, indices, primcount);
            
            /// <summary> <b>[requires: GL_EXT_multisampled_render_to_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void RenderbufferStorageMultisampleEXT(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => GLPointers._RenderbufferStorageMultisampleEXT_fnptr((uint)target, samples, (uint)internalformat, width, height);
            
            /// <summary> <b>[requires: GL_EXT_multisampled_render_to_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FramebufferTexture2DMultisampleEXT(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level, int samples) => GLPointers._FramebufferTexture2DMultisampleEXT_fnptr((uint)target, (uint)attachment, (uint)textarget, texture, level, samples);
            
            /// <summary> <b>[requires: GL_EXT_robustness]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static GraphicsResetStatus GetGraphicsResetStatusEXT() => (GraphicsResetStatus) GLPointers._GetGraphicsResetStatusEXT_fnptr();
            
            /// <summary> <b>[requires: GL_EXT_robustness]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ReadnPixelsEXT(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data) => GLPointers._ReadnPixelsEXT_fnptr(x, y, width, height, (uint)format, (uint)type, bufSize, data);
            
            /// <summary> <b>[requires: GL_EXT_robustness]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetnUniformfvEXT(int program, int location, int bufSize, float* parameters) => GLPointers._GetnUniformfvEXT_fnptr(program, location, bufSize, parameters);
            
            /// <summary> <b>[requires: GL_EXT_robustness]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetnUniformivEXT(int program, int location, int bufSize, int* parameters) => GLPointers._GetnUniformivEXT_fnptr(program, location, bufSize, parameters);
            
            /// <summary> <b>[requires: GL_EXT_texture_storage]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexStorage1DEXT(TextureTarget target, int levels, SizedInternalFormat internalformat, int width) => GLPointers._TexStorage1DEXT_fnptr((uint)target, levels, (uint)internalformat, width);
            
            /// <summary> <b>[requires: GL_EXT_texture_storage]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexStorage2DEXT(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height) => GLPointers._TexStorage2DEXT_fnptr((uint)target, levels, (uint)internalformat, width, height);
            
            /// <summary> <b>[requires: GL_EXT_texture_storage]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexStorage3DEXT(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height, int depth) => GLPointers._TexStorage3DEXT_fnptr((uint)target, levels, (uint)internalformat, width, height, depth);
            
            /// <summary> <b>[requires: GL_EXT_texture_storage]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TextureStorage1DEXT(int texture, All target, int levels, SizedInternalFormat internalformat, int width) => GLPointers._TextureStorage1DEXT_fnptr(texture, (uint)target, levels, (uint)internalformat, width);
            
            /// <summary> <b>[requires: GL_EXT_texture_storage]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TextureStorage2DEXT(int texture, All target, int levels, SizedInternalFormat internalformat, int width, int height) => GLPointers._TextureStorage2DEXT_fnptr(texture, (uint)target, levels, (uint)internalformat, width, height);
            
            /// <summary> <b>[requires: GL_EXT_texture_storage]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TextureStorage3DEXT(int texture, All target, int levels, SizedInternalFormat internalformat, int width, int height, int depth) => GLPointers._TextureStorage3DEXT_fnptr(texture, (uint)target, levels, (uint)internalformat, width, height, depth);
            
        }
        public static unsafe partial class IMG
        {
            /// <summary> <b>[requires: GL_IMG_multisampled_render_to_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void RenderbufferStorageMultisampleIMG(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => GLPointers._RenderbufferStorageMultisampleIMG_fnptr((uint)target, samples, (uint)internalformat, width, height);
            
            /// <summary> <b>[requires: GL_IMG_multisampled_render_to_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FramebufferTexture2DMultisampleIMG(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level, int samples) => GLPointers._FramebufferTexture2DMultisampleIMG_fnptr((uint)target, (uint)attachment, (uint)textarget, texture, level, samples);
            
            /// <summary> <b>[requires: GL_IMG_user_clip_plane]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ClipPlanefIMG(ClipPlaneName p, float* eqn) => GLPointers._ClipPlanefIMG_fnptr((uint)p, eqn);
            
            /// <summary> <b>[requires: GL_IMG_user_clip_plane]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ClipPlanexIMG(ClipPlaneName p, int* eqn) => GLPointers._ClipPlanexIMG_fnptr((uint)p, eqn);
            
        }
        public static unsafe partial class KHR
        {
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, bool enabled) => GLPointers._DebugMessageControl_fnptr((uint)source, (uint)type, (uint)severity, count, ids, (byte)(enabled ? 1 : 0));
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* buf) => GLPointers._DebugMessageInsert_fnptr((uint)source, (uint)type, id, (uint)severity, length, buf);
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DebugMessageCallback(IntPtr callback, void* userParam) => GLPointers._DebugMessageCallback_fnptr(callback, userParam);
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static uint GetDebugMessageLog(uint count, int bufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, byte* messageLog) => GLPointers._GetDebugMessageLog_fnptr(count, bufSize, (uint*)sources, (uint*)types, ids, (uint*)severities, lengths, messageLog);
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PushDebugGroup(DebugSource source, uint id, int length, byte* message) => GLPointers._PushDebugGroup_fnptr((uint)source, id, length, message);
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PopDebugGroup() => GLPointers._PopDebugGroup_fnptr();
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ObjectLabel(ObjectIdentifier identifier, uint name, int length, byte* label) => GLPointers._ObjectLabel_fnptr((uint)identifier, name, length, label);
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetObjectLabel(ObjectIdentifier identifier, uint name, int bufSize, int* length, byte* label) => GLPointers._GetObjectLabel_fnptr((uint)identifier, name, bufSize, length, label);
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ObjectPtrLabel(void* ptr, int length, byte* label) => GLPointers._ObjectPtrLabel_fnptr(ptr, length, label);
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetObjectPtrLabel(void* ptr, int bufSize, int* length, byte* label) => GLPointers._GetObjectPtrLabel_fnptr(ptr, bufSize, length, label);
            
            /// <summary> <b>[requires: v1.0 | GL_KHR_debug]</b> Return the address of the specified pointer. </summary>
            /// <param name="pname"> Specifies the array or buffer pointer to be returned. Accepted symbolic names are GL_COLOR_ARRAY_POINTER, GL_MATRIX_INDEX_ARRAY_POINTER_OES, GL_NORMAL_ARRAY_POINTER, GL_POINT_SIZE_ARRAY_POINTER_OES, GL_TEXTURE_COORD_ARRAY_POINTER, and GL_VERTEX_ARRAY_POINTER., and GL_WEIGHT_ARRAY_POINTER_OES. </param>
            /// <param name="parameters"> Returns the pointer value specified by pname. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetPointerv.xml" /></remarks>
            public static void GetPointerv(GetPointervPName pname, void** parameters) => GLPointers._GetPointerv_fnptr((uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DebugMessageControlKHR(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, bool enabled) => GLPointers._DebugMessageControlKHR_fnptr((uint)source, (uint)type, (uint)severity, count, ids, (byte)(enabled ? 1 : 0));
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DebugMessageInsertKHR(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* buf) => GLPointers._DebugMessageInsertKHR_fnptr((uint)source, (uint)type, id, (uint)severity, length, buf);
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DebugMessageCallbackKHR(IntPtr callback, void* userParam) => GLPointers._DebugMessageCallbackKHR_fnptr(callback, userParam);
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static uint GetDebugMessageLogKHR(uint count, int bufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, byte* messageLog) => GLPointers._GetDebugMessageLogKHR_fnptr(count, bufSize, (uint*)sources, (uint*)types, ids, (uint*)severities, lengths, messageLog);
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PushDebugGroupKHR(DebugSource source, uint id, int length, byte* message) => GLPointers._PushDebugGroupKHR_fnptr((uint)source, id, length, message);
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PopDebugGroupKHR() => GLPointers._PopDebugGroupKHR_fnptr();
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ObjectLabelKHR(ObjectIdentifier identifier, uint name, int length, byte* label) => GLPointers._ObjectLabelKHR_fnptr((uint)identifier, name, length, label);
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetObjectLabelKHR(All identifier, uint name, int bufSize, int* length, byte* label) => GLPointers._GetObjectLabelKHR_fnptr((uint)identifier, name, bufSize, length, label);
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ObjectPtrLabelKHR(void* ptr, int length, byte* label) => GLPointers._ObjectPtrLabelKHR_fnptr(ptr, length, label);
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetObjectPtrLabelKHR(void* ptr, int bufSize, int* length, byte* label) => GLPointers._GetObjectPtrLabelKHR_fnptr(ptr, bufSize, length, label);
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetPointervKHR(All pname, void** parameters) => GLPointers._GetPointervKHR_fnptr((uint)pname, parameters);
            
        }
        public static unsafe partial class NV
        {
            /// <summary> <b>[requires: GL_NV_fence]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DeleteFencesNV(int n, uint* fences) => GLPointers._DeleteFencesNV_fnptr(n, fences);
            
            /// <summary> <b>[requires: GL_NV_fence]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GenFencesNV(int n, uint* fences) => GLPointers._GenFencesNV_fnptr(n, fences);
            
            /// <summary> <b>[requires: GL_NV_fence]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static bool IsFenceNV(uint fence) => GLPointers._IsFenceNV_fnptr(fence) != 0;
            
            /// <summary> <b>[requires: GL_NV_fence]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static bool TestFenceNV(uint fence) => GLPointers._TestFenceNV_fnptr(fence) != 0;
            
            /// <summary> <b>[requires: GL_NV_fence]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetFenceivNV(uint fence, FenceParameterNameNV pname, int* parameters) => GLPointers._GetFenceivNV_fnptr(fence, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_NV_fence]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FinishFenceNV(uint fence) => GLPointers._FinishFenceNV_fnptr(fence);
            
            /// <summary> <b>[requires: GL_NV_fence]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void SetFenceNV(uint fence, FenceConditionNV condition) => GLPointers._SetFenceNV_fnptr(fence, (uint)condition);
            
        }
        public static unsafe partial class OES
        {
            /// <summary> <b>[requires: GL_OES_EGL_image]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void EGLImageTargetTexture2DOES(All target, void* image) => GLPointers._EGLImageTargetTexture2DOES_fnptr((uint)target, image);
            
            /// <summary> <b>[requires: GL_OES_EGL_image]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void EGLImageTargetRenderbufferStorageOES(All target, void* image) => GLPointers._EGLImageTargetRenderbufferStorageOES_fnptr((uint)target, image);
            
            /// <summary> <b>[requires: GL_OES_blend_equation_separate]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BlendEquationSeparateOES(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => GLPointers._BlendEquationSeparateOES_fnptr((uint)modeRGB, (uint)modeAlpha);
            
            /// <summary> <b>[requires: GL_OES_blend_func_separate]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BlendFuncSeparateOES(BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha) => GLPointers._BlendFuncSeparateOES_fnptr((uint)srcRGB, (uint)dstRGB, (uint)srcAlpha, (uint)dstAlpha);
            
            /// <summary> <b>[requires: GL_OES_blend_subtract]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BlendEquationOES(BlendEquationModeEXT mode) => GLPointers._BlendEquationOES_fnptr((uint)mode);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiTexCoord1bOES(TextureUnit texture, sbyte s) => GLPointers._MultiTexCoord1bOES_fnptr((uint)texture, s);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiTexCoord1bvOES(TextureUnit texture, sbyte* coords) => GLPointers._MultiTexCoord1bvOES_fnptr((uint)texture, coords);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiTexCoord2bOES(TextureUnit texture, sbyte s, sbyte t) => GLPointers._MultiTexCoord2bOES_fnptr((uint)texture, s, t);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiTexCoord2bvOES(TextureUnit texture, sbyte* coords) => GLPointers._MultiTexCoord2bvOES_fnptr((uint)texture, coords);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiTexCoord3bOES(TextureUnit texture, sbyte s, sbyte t, sbyte r) => GLPointers._MultiTexCoord3bOES_fnptr((uint)texture, s, t, r);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiTexCoord3bvOES(TextureUnit texture, sbyte* coords) => GLPointers._MultiTexCoord3bvOES_fnptr((uint)texture, coords);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiTexCoord4bOES(TextureUnit texture, sbyte s, sbyte t, sbyte r, sbyte q) => GLPointers._MultiTexCoord4bOES_fnptr((uint)texture, s, t, r, q);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiTexCoord4bvOES(TextureUnit texture, sbyte* coords) => GLPointers._MultiTexCoord4bvOES_fnptr((uint)texture, coords);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexCoord1bOES(sbyte s) => GLPointers._TexCoord1bOES_fnptr(s);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexCoord1bvOES(sbyte* coords) => GLPointers._TexCoord1bvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexCoord2bOES(sbyte s, sbyte t) => GLPointers._TexCoord2bOES_fnptr(s, t);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexCoord2bvOES(sbyte* coords) => GLPointers._TexCoord2bvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexCoord3bOES(sbyte s, sbyte t, sbyte r) => GLPointers._TexCoord3bOES_fnptr(s, t, r);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexCoord3bvOES(sbyte* coords) => GLPointers._TexCoord3bvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexCoord4bOES(sbyte s, sbyte t, sbyte r, sbyte q) => GLPointers._TexCoord4bOES_fnptr(s, t, r, q);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexCoord4bvOES(sbyte* coords) => GLPointers._TexCoord4bvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Vertex2bOES(sbyte x, sbyte y) => GLPointers._Vertex2bOES_fnptr(x, y);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Vertex2bvOES(sbyte* coords) => GLPointers._Vertex2bvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Vertex3bOES(sbyte x, sbyte y, sbyte z) => GLPointers._Vertex3bOES_fnptr(x, y, z);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Vertex3bvOES(sbyte* coords) => GLPointers._Vertex3bvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Vertex4bOES(sbyte x, sbyte y, sbyte z, sbyte w) => GLPointers._Vertex4bOES_fnptr(x, y, z, w);
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Vertex4bvOES(sbyte* coords) => GLPointers._Vertex4bvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_draw_texture]</b> Draws a texture rectangle to the screen. </summary>
            /// <param name="x"> Specify the position of the affected screen rectangle. </param>
            /// <param name="y"> Specify the position of the affected screen rectangle. </param>
            /// <param name="z"> Specify the position of the affected screen rectangle. </param>
            /// <param name="width"> Specifies the width and height of the affected screen rectangle in pixels. </param>
            /// <param name="height"> Specifies the width and height of the affected screen rectangle in pixels. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glDrawTex.xml" /></remarks>
            public static void DrawTexsOES(short x, short y, short z, short width, short height) => GLPointers._DrawTexsOES_fnptr(x, y, z, width, height);
            
            /// <summary> <b>[requires: GL_OES_draw_texture]</b> Draws a texture rectangle to the screen. </summary>
            /// <param name="x"> Specify the position of the affected screen rectangle. </param>
            /// <param name="y"> Specify the position of the affected screen rectangle. </param>
            /// <param name="z"> Specify the position of the affected screen rectangle. </param>
            /// <param name="width"> Specifies the width and height of the affected screen rectangle in pixels. </param>
            /// <param name="height"> Specifies the width and height of the affected screen rectangle in pixels. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glDrawTex.xml" /></remarks>
            public static void DrawTexiOES(int x, int y, int z, int width, int height) => GLPointers._DrawTexiOES_fnptr(x, y, z, width, height);
            
            /// <summary> <b>[requires: GL_OES_draw_texture]</b> Draws a texture rectangle to the screen. </summary>
            /// <param name="x"> Specify the position of the affected screen rectangle. </param>
            /// <param name="y"> Specify the position of the affected screen rectangle. </param>
            /// <param name="z"> Specify the position of the affected screen rectangle. </param>
            /// <param name="width"> Specifies the width and height of the affected screen rectangle in pixels. </param>
            /// <param name="height"> Specifies the width and height of the affected screen rectangle in pixels. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glDrawTex.xml" /></remarks>
            public static void DrawTexxOES(int x, int y, int z, int width, int height) => GLPointers._DrawTexxOES_fnptr(x, y, z, width, height);
            
            /// <summary> <b>[requires: GL_OES_draw_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DrawTexsvOES(short* coords) => GLPointers._DrawTexsvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_draw_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DrawTexivOES(int* coords) => GLPointers._DrawTexivOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_draw_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DrawTexxvOES(int* coords) => GLPointers._DrawTexxvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_draw_texture]</b> Draws a texture rectangle to the screen. </summary>
            /// <param name="x"> Specify the position of the affected screen rectangle. </param>
            /// <param name="y"> Specify the position of the affected screen rectangle. </param>
            /// <param name="z"> Specify the position of the affected screen rectangle. </param>
            /// <param name="width"> Specifies the width and height of the affected screen rectangle in pixels. </param>
            /// <param name="height"> Specifies the width and height of the affected screen rectangle in pixels. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glDrawTex.xml" /></remarks>
            public static void DrawTexfOES(float x, float y, float z, float width, float height) => GLPointers._DrawTexfOES_fnptr(x, y, z, width, height);
            
            /// <summary> <b>[requires: GL_OES_draw_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DrawTexfvOES(float* coords) => GLPointers._DrawTexfvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void AlphaFuncxOES(AlphaFunction func, int reference) => GLPointers._AlphaFuncxOES_fnptr((uint)func, reference);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ClearColorxOES(int red, int green, int blue, int alpha) => GLPointers._ClearColorxOES_fnptr(red, green, blue, alpha);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ClearDepthxOES(int depth) => GLPointers._ClearDepthxOES_fnptr(depth);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ClipPlanexOES(ClipPlaneName plane, int* equation) => GLPointers._ClipPlanexOES_fnptr((uint)plane, equation);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Color4xOES(int red, int green, int blue, int alpha) => GLPointers._Color4xOES_fnptr(red, green, blue, alpha);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DepthRangexOES(int n, int f) => GLPointers._DepthRangexOES_fnptr(n, f);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FogxOES(FogPName pname, int param) => GLPointers._FogxOES_fnptr((uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FogxvOES(FogPName pname, int* param) => GLPointers._FogxvOES_fnptr((uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FrustumxOES(int l, int r, int b, int t, int n, int f) => GLPointers._FrustumxOES_fnptr(l, r, b, t, n, f);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetClipPlanexOES(ClipPlaneName plane, int* equation) => GLPointers._GetClipPlanexOES_fnptr((uint)plane, equation);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetFixedvOES(GetPName pname, int* parameters) => GLPointers._GetFixedvOES_fnptr((uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetTexEnvxvOES(TextureEnvTarget target, TextureEnvParameter pname, int* parameters) => GLPointers._GetTexEnvxvOES_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetTexParameterxvOES(TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._GetTexParameterxvOES_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void LightModelxOES(LightModelParameter pname, int param) => GLPointers._LightModelxOES_fnptr((uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void LightModelxvOES(LightModelParameter pname, int* param) => GLPointers._LightModelxvOES_fnptr((uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void LightxOES(LightName light, LightParameter pname, int param) => GLPointers._LightxOES_fnptr((uint)light, (uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void LightxvOES(LightName light, LightParameter pname, int* parameters) => GLPointers._LightxvOES_fnptr((uint)light, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void LineWidthxOES(int width) => GLPointers._LineWidthxOES_fnptr(width);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void LoadMatrixxOES(int* m) => GLPointers._LoadMatrixxOES_fnptr(m);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MaterialxOES(TriangleFace face, MaterialParameter pname, int param) => GLPointers._MaterialxOES_fnptr((uint)face, (uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MaterialxvOES(TriangleFace face, MaterialParameter pname, int* param) => GLPointers._MaterialxvOES_fnptr((uint)face, (uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultMatrixxOES(int* m) => GLPointers._MultMatrixxOES_fnptr(m);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiTexCoord4xOES(TextureUnit texture, int s, int t, int r, int q) => GLPointers._MultiTexCoord4xOES_fnptr((uint)texture, s, t, r, q);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Normal3xOES(int nx, int ny, int nz) => GLPointers._Normal3xOES_fnptr(nx, ny, nz);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void OrthoxOES(int l, int r, int b, int t, int n, int f) => GLPointers._OrthoxOES_fnptr(l, r, b, t, n, f);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PointParameterxvOES(PointParameterNameARB pname, int* parameters) => GLPointers._PointParameterxvOES_fnptr((uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PointSizexOES(int size) => GLPointers._PointSizexOES_fnptr(size);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PolygonOffsetxOES(int factor, int units) => GLPointers._PolygonOffsetxOES_fnptr(factor, units);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void RotatexOES(int angle, int x, int y, int z) => GLPointers._RotatexOES_fnptr(angle, x, y, z);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ScalexOES(int x, int y, int z) => GLPointers._ScalexOES_fnptr(x, y, z);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexEnvxOES(TextureEnvTarget target, TextureEnvParameter pname, int param) => GLPointers._TexEnvxOES_fnptr((uint)target, (uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexEnvxvOES(TextureEnvTarget target, TextureEnvParameter pname, int* parameters) => GLPointers._TexEnvxvOES_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexParameterxOES(TextureTarget target, GetTextureParameter pname, int param) => GLPointers._TexParameterxOES_fnptr((uint)target, (uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexParameterxvOES(TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._TexParameterxvOES_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TranslatexOES(int x, int y, int z) => GLPointers._TranslatexOES_fnptr(x, y, z);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetLightxvOES(LightName light, LightParameter pname, int* parameters) => GLPointers._GetLightxvOES_fnptr((uint)light, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetMaterialxvOES(TriangleFace face, MaterialParameter pname, int* parameters) => GLPointers._GetMaterialxvOES_fnptr((uint)face, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PointParameterxOES(PointParameterNameARB pname, int param) => GLPointers._PointParameterxOES_fnptr((uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void SampleCoveragexOES(int value, bool invert) => GLPointers._SampleCoveragexOES_fnptr(value, (byte)(invert ? 1 : 0));
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void AccumxOES(All op, int value) => GLPointers._AccumxOES_fnptr((uint)op, value);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BitmapxOES(int width, int height, int xorig, int yorig, int xmove, int ymove, byte* bitmap) => GLPointers._BitmapxOES_fnptr(width, height, xorig, yorig, xmove, ymove, bitmap);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BlendColorxOES(int red, int green, int blue, int alpha) => GLPointers._BlendColorxOES_fnptr(red, green, blue, alpha);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ClearAccumxOES(int red, int green, int blue, int alpha) => GLPointers._ClearAccumxOES_fnptr(red, green, blue, alpha);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Color3xOES(int red, int green, int blue) => GLPointers._Color3xOES_fnptr(red, green, blue);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Color3xvOES(int* components) => GLPointers._Color3xvOES_fnptr(components);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Color4xvOES(int* components) => GLPointers._Color4xvOES_fnptr(components);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ConvolutionParameterxOES(ConvolutionTargetEXT target, ConvolutionParameter pname, int param) => GLPointers._ConvolutionParameterxOES_fnptr((uint)target, (uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ConvolutionParameterxvOES(ConvolutionTargetEXT target, ConvolutionParameter pname, int* parameters) => GLPointers._ConvolutionParameterxvOES_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void EvalCoord1xOES(int u) => GLPointers._EvalCoord1xOES_fnptr(u);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void EvalCoord1xvOES(int* coords) => GLPointers._EvalCoord1xvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void EvalCoord2xOES(int u, int v) => GLPointers._EvalCoord2xOES_fnptr(u, v);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void EvalCoord2xvOES(int* coords) => GLPointers._EvalCoord2xvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FeedbackBufferxOES(int n, All type, int* buffer) => GLPointers._FeedbackBufferxOES_fnptr(n, (uint)type, buffer);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetConvolutionParameterxvOES(All target, All pname, int* parameters) => GLPointers._GetConvolutionParameterxvOES_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetHistogramParameterxvOES(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, int* parameters) => GLPointers._GetHistogramParameterxvOES_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetLightxOES(LightName light, LightParameter pname, int* parameters) => GLPointers._GetLightxOES_fnptr((uint)light, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetMapxvOES(MapTarget target, GetMapQuery query, int* v) => GLPointers._GetMapxvOES_fnptr((uint)target, (uint)query, v);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetMaterialxOES(TriangleFace face, MaterialParameter pname, int param) => GLPointers._GetMaterialxOES_fnptr((uint)face, (uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetPixelMapxv(PixelMap map, int size, int* values) => GLPointers._GetPixelMapxv_fnptr((uint)map, size, values);
            
            /// <summary> <b>[requires: GL_OES_fixed_point | GL_OES_texture_cube_map]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetTexGenxvOES(TextureCoordName coord, TextureGenParameter pname, int* parameters) => GLPointers._GetTexGenxvOES_fnptr((uint)coord, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetTexLevelParameterxvOES(TextureTarget target, int level, GetTextureParameter pname, int* parameters) => GLPointers._GetTexLevelParameterxvOES_fnptr((uint)target, level, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void IndexxOES(int component) => GLPointers._IndexxOES_fnptr(component);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void IndexxvOES(int* component) => GLPointers._IndexxvOES_fnptr(component);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void LoadTransposeMatrixxOES(int* m) => GLPointers._LoadTransposeMatrixxOES_fnptr(m);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Map1xOES(MapTarget target, int u1, int u2, int stride, int order, int points) => GLPointers._Map1xOES_fnptr((uint)target, u1, u2, stride, order, points);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Map2xOES(MapTarget target, int u1, int u2, int ustride, int uorder, int v1, int v2, int vstride, int vorder, int points) => GLPointers._Map2xOES_fnptr((uint)target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MapGrid1xOES(int n, int u1, int u2) => GLPointers._MapGrid1xOES_fnptr(n, u1, u2);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MapGrid2xOES(int n, int u1, int u2, int v1, int v2) => GLPointers._MapGrid2xOES_fnptr(n, u1, u2, v1, v2);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultTransposeMatrixxOES(int* m) => GLPointers._MultTransposeMatrixxOES_fnptr(m);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiTexCoord1xOES(TextureUnit texture, int s) => GLPointers._MultiTexCoord1xOES_fnptr((uint)texture, s);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiTexCoord1xvOES(TextureUnit texture, int* coords) => GLPointers._MultiTexCoord1xvOES_fnptr((uint)texture, coords);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiTexCoord2xOES(TextureUnit texture, int s, int t) => GLPointers._MultiTexCoord2xOES_fnptr((uint)texture, s, t);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiTexCoord2xvOES(TextureUnit texture, int* coords) => GLPointers._MultiTexCoord2xvOES_fnptr((uint)texture, coords);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiTexCoord3xOES(TextureUnit texture, int s, int t, int r) => GLPointers._MultiTexCoord3xOES_fnptr((uint)texture, s, t, r);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiTexCoord3xvOES(TextureUnit texture, int* coords) => GLPointers._MultiTexCoord3xvOES_fnptr((uint)texture, coords);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiTexCoord4xvOES(TextureUnit texture, int* coords) => GLPointers._MultiTexCoord4xvOES_fnptr((uint)texture, coords);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Normal3xvOES(int* coords) => GLPointers._Normal3xvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PassThroughxOES(int token) => GLPointers._PassThroughxOES_fnptr(token);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PixelMapx(PixelMap map, int size, int* values) => GLPointers._PixelMapx_fnptr((uint)map, size, values);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PixelStorex(PixelStoreParameter pname, int param) => GLPointers._PixelStorex_fnptr((uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PixelTransferxOES(PixelTransferParameter pname, int param) => GLPointers._PixelTransferxOES_fnptr((uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PixelZoomxOES(int xfactor, int yfactor) => GLPointers._PixelZoomxOES_fnptr(xfactor, yfactor);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PrioritizeTexturesxOES(int n, int* textures, int* priorities) => GLPointers._PrioritizeTexturesxOES_fnptr(n, textures, priorities);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void RasterPos2xOES(int x, int y) => GLPointers._RasterPos2xOES_fnptr(x, y);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void RasterPos2xvOES(int* coords) => GLPointers._RasterPos2xvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void RasterPos3xOES(int x, int y, int z) => GLPointers._RasterPos3xOES_fnptr(x, y, z);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void RasterPos3xvOES(int* coords) => GLPointers._RasterPos3xvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void RasterPos4xOES(int x, int y, int z, int w) => GLPointers._RasterPos4xOES_fnptr(x, y, z, w);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void RasterPos4xvOES(int* coords) => GLPointers._RasterPos4xvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void RectxOES(int x1, int y1, int x2, int y2) => GLPointers._RectxOES_fnptr(x1, y1, x2, y2);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void RectxvOES(int* v1, int* v2) => GLPointers._RectxvOES_fnptr(v1, v2);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexCoord1xOES(int s) => GLPointers._TexCoord1xOES_fnptr(s);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexCoord1xvOES(int* coords) => GLPointers._TexCoord1xvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexCoord2xOES(int s, int t) => GLPointers._TexCoord2xOES_fnptr(s, t);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexCoord2xvOES(int* coords) => GLPointers._TexCoord2xvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexCoord3xOES(int s, int t, int r) => GLPointers._TexCoord3xOES_fnptr(s, t, r);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexCoord3xvOES(int* coords) => GLPointers._TexCoord3xvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexCoord4xOES(int s, int t, int r, int q) => GLPointers._TexCoord4xOES_fnptr(s, t, r, q);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexCoord4xvOES(int* coords) => GLPointers._TexCoord4xvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_fixed_point | GL_OES_texture_cube_map]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexGenxOES(TextureCoordName coord, TextureGenParameter pname, int param) => GLPointers._TexGenxOES_fnptr((uint)coord, (uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_fixed_point | GL_OES_texture_cube_map]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexGenxvOES(TextureCoordName coord, TextureGenParameter pname, int* parameters) => GLPointers._TexGenxvOES_fnptr((uint)coord, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Vertex2xOES(int x) => GLPointers._Vertex2xOES_fnptr(x);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Vertex2xvOES(int* coords) => GLPointers._Vertex2xvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Vertex3xOES(int x, int y) => GLPointers._Vertex3xOES_fnptr(x, y);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Vertex3xvOES(int* coords) => GLPointers._Vertex3xvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Vertex4xOES(int x, int y, int z) => GLPointers._Vertex4xOES_fnptr(x, y, z);
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Vertex4xvOES(int* coords) => GLPointers._Vertex4xvOES_fnptr(coords);
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static bool IsRenderbufferOES(int renderbuffer) => GLPointers._IsRenderbufferOES_fnptr(renderbuffer) != 0;
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BindRenderbufferOES(RenderbufferTarget target, int renderbuffer) => GLPointers._BindRenderbufferOES_fnptr((uint)target, renderbuffer);
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DeleteRenderbuffersOES(int n, int* renderbuffers) => GLPointers._DeleteRenderbuffersOES_fnptr(n, renderbuffers);
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GenRenderbuffersOES(int n, int* renderbuffers) => GLPointers._GenRenderbuffersOES_fnptr(n, renderbuffers);
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void RenderbufferStorageOES(RenderbufferTarget target, InternalFormat internalformat, int width, int height) => GLPointers._RenderbufferStorageOES_fnptr((uint)target, (uint)internalformat, width, height);
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetRenderbufferParameterivOES(RenderbufferTarget target, RenderbufferParameterName pname, int* parameters) => GLPointers._GetRenderbufferParameterivOES_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static bool IsFramebufferOES(int framebuffer) => GLPointers._IsFramebufferOES_fnptr(framebuffer) != 0;
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BindFramebufferOES(FramebufferTarget target, int framebuffer) => GLPointers._BindFramebufferOES_fnptr((uint)target, framebuffer);
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DeleteFramebuffersOES(int n, int* framebuffers) => GLPointers._DeleteFramebuffersOES_fnptr(n, framebuffers);
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GenFramebuffersOES(int n, int* framebuffers) => GLPointers._GenFramebuffersOES_fnptr(n, framebuffers);
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static FramebufferStatus CheckFramebufferStatusOES(FramebufferTarget target) => (FramebufferStatus) GLPointers._CheckFramebufferStatusOES_fnptr((uint)target);
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FramebufferRenderbufferOES(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, int renderbuffer) => GLPointers._FramebufferRenderbufferOES_fnptr((uint)target, (uint)attachment, (uint)renderbuffertarget, renderbuffer);
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FramebufferTexture2DOES(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level) => GLPointers._FramebufferTexture2DOES_fnptr((uint)target, (uint)attachment, (uint)textarget, texture, level);
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetFramebufferAttachmentParameterivOES(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int* parameters) => GLPointers._GetFramebufferAttachmentParameterivOES_fnptr((uint)target, (uint)attachment, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GenerateMipmapOES(TextureTarget target) => GLPointers._GenerateMipmapOES_fnptr((uint)target);
            
            /// <summary> <b>[requires: GL_OES_mapbuffer]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void* MapBufferOES(BufferTargetARB target, BufferAccessARB access) => GLPointers._MapBufferOES_fnptr((uint)target, (uint)access);
            
            /// <summary> <b>[requires: GL_OES_mapbuffer]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static bool UnmapBufferOES(All target) => GLPointers._UnmapBufferOES_fnptr((uint)target) != 0;
            
            /// <summary> <b>[requires: GL_OES_mapbuffer]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetBufferPointervOES(BufferTargetARB target, BufferPointerNameARB pname, void** parameters) => GLPointers._GetBufferPointervOES_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_matrix_palette]</b>         defines which of the palette's matrices is affected by        subsequent matrix operations        . </summary>
            /// <param name="index"> specifies the index into the palette's matrices. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glCurrentPaletteMatrix.xml" /></remarks>
            public static void CurrentPaletteMatrixOES(uint matrixpaletteindex) => GLPointers._CurrentPaletteMatrixOES_fnptr(matrixpaletteindex);
            
            /// <summary> <b>[requires: GL_OES_matrix_palette]</b>         copies the current model view matrix to a        matrix in the current matrix palette        . </summary>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glLoadPaletteFromModelViewMatrix.xml" /></remarks>
            public static void LoadPaletteFromModelViewMatrixOES() => GLPointers._LoadPaletteFromModelViewMatrixOES_fnptr();
            
            /// <summary> <b>[requires: GL_OES_matrix_palette]</b> Define an array of matrix indices. </summary>
            /// <param name="size"> Specifies the number of matrix indices per vertex. Must be is less than or equal to GL_MAX_VERTEX_UNITS_OES. The initial value is 0. </param>
            /// <param name="type"> Specifies the data type of each matrix index in the array. Symbolic constant GL_UNSIGNED_BYTE is accepted. The initial value is GL_UNSIGNED_BYTE. </param>
            /// <param name="stride"> Specifies the byte offset between consecutive matrix indices. If stride is 0, the matrix indices are understood to be tightly packed in the array. The initial value is 0. </param>
            /// <param name="pointer"> Specifies a pointer to the first matrix index of the first vertex in the array. The initial value is 0. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glMatrixIndexPointer.xml" /></remarks>
            public static void MatrixIndexPointerOES(int size, MatrixIndexPointerTypeARB type, int stride, void* pointer) => GLPointers._MatrixIndexPointerOES_fnptr(size, (uint)type, stride, pointer);
            
            /// <summary> <b>[requires: GL_OES_matrix_palette]</b> Define an array of weights. </summary>
            /// <param name="size"> Specifies the number of weights per vertex. Must be is less than or equal to GL_MAX_VERTEX_UNITS_OES. The initial value is 0. </param>
            /// <param name="type"> Specifies the data type of each weight in the array. Symbolic constant GL_FIXED is accepted. However, the common profile also accepts the symbolic constant GL_FLOAT as well. The initial value is GL_FIXED for the common lite profile, or GL_FLOAT for the common profile. </param>
            /// <param name="stride"> Specifies the byte offset between consecutive weights. If stride is 0, the weights are understood to be tightly packed in the array. The initial value is 0. </param>
            /// <param name="pointer"> Specifies a pointer to the first weight of the first vertex in the array. The initial value is 0. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glWeightPointer.xml" /></remarks>
            public static void WeightPointerOES(int size, All type, int stride, void* pointer) => GLPointers._WeightPointerOES_fnptr(size, (uint)type, stride, pointer);
            
            /// <summary> <b>[requires: GL_OES_point_size_array]</b> Define an array of point sizes. </summary>
            /// <param name="type"> Specifies the data type of each point size in the array. Symbolic constant GL_FIXED is accepted. However, the common profile also accepts the symbolic constant GL_FLOAT. The initial value is GL_FIXED for the common lite profile, or GL_FLOAT for the common profile. </param>
            /// <param name="stride"> Specifies the byte offset between consecutive point sizes. If stride is 0, the point sizes are understood to be tightly packed in the array. The initial value is 0. </param>
            /// <param name="pointer"> Specifies a pointer to the point size of the first vertex in the array. The initial value is 0. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glPointSizePointerOES.xml" /></remarks>
            public static void PointSizePointerOES(All type, int stride, void* pointer) => GLPointers._PointSizePointerOES_fnptr((uint)type, stride, pointer);
            
            /// <summary> <b>[requires: GL_OES_query_matrix]</b> Return the values of the current matrix. </summary>
            /// <param name="mantissa">Returns the mantissa values of the current matrix.</param>
            /// <param name="exponent">Returns the exponents of the current matrix.</param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glQueryMatrix.xml" /></remarks>
            public static All QueryMatrixxOES(int* mantissa, int* exponent) => (All) GLPointers._QueryMatrixxOES_fnptr(mantissa, exponent);
            
            /// <summary> <b>[requires: GL_OES_single_precision]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ClearDepthfOES(float depth) => GLPointers._ClearDepthfOES_fnptr(depth);
            
            /// <summary> <b>[requires: GL_OES_single_precision]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ClipPlanefOES(ClipPlaneName plane, float* equation) => GLPointers._ClipPlanefOES_fnptr((uint)plane, equation);
            
            /// <summary> <b>[requires: GL_OES_single_precision]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DepthRangefOES(float n, float f) => GLPointers._DepthRangefOES_fnptr(n, f);
            
            /// <summary> <b>[requires: GL_OES_single_precision]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FrustumfOES(float l, float r, float b, float t, float n, float f) => GLPointers._FrustumfOES_fnptr(l, r, b, t, n, f);
            
            /// <summary> <b>[requires: GL_OES_single_precision]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetClipPlanefOES(ClipPlaneName plane, float* equation) => GLPointers._GetClipPlanefOES_fnptr((uint)plane, equation);
            
            /// <summary> <b>[requires: GL_OES_single_precision]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void OrthofOES(float l, float r, float b, float t, float n, float f) => GLPointers._OrthofOES_fnptr(l, r, b, t, n, f);
            
            /// <summary> <b>[requires: GL_OES_texture_cube_map]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexGenfOES(TextureCoordName coord, TextureGenParameter pname, float param) => GLPointers._TexGenfOES_fnptr((uint)coord, (uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_texture_cube_map]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexGenfvOES(TextureCoordName coord, TextureGenParameter pname, float* parameters) => GLPointers._TexGenfvOES_fnptr((uint)coord, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_texture_cube_map]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexGeniOES(TextureCoordName coord, TextureGenParameter pname, int param) => GLPointers._TexGeniOES_fnptr((uint)coord, (uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_texture_cube_map]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexGenivOES(TextureCoordName coord, TextureGenParameter pname, int* parameters) => GLPointers._TexGenivOES_fnptr((uint)coord, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_texture_cube_map]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetTexGenfvOES(TextureCoordName coord, TextureGenParameter pname, float* parameters) => GLPointers._GetTexGenfvOES_fnptr((uint)coord, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_texture_cube_map]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetTexGenivOES(TextureCoordName coord, TextureGenParameter pname, int* parameters) => GLPointers._GetTexGenivOES_fnptr((uint)coord, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_vertex_array_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BindVertexArrayOES(int array) => GLPointers._BindVertexArrayOES_fnptr(array);
            
            /// <summary> <b>[requires: GL_OES_vertex_array_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DeleteVertexArraysOES(int n, int* arrays) => GLPointers._DeleteVertexArraysOES_fnptr(n, arrays);
            
            /// <summary> <b>[requires: GL_OES_vertex_array_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GenVertexArraysOES(int n, int* arrays) => GLPointers._GenVertexArraysOES_fnptr(n, arrays);
            
            /// <summary> <b>[requires: GL_OES_vertex_array_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static bool IsVertexArrayOES(int array) => GLPointers._IsVertexArrayOES_fnptr(array) != 0;
            
        }
        public static unsafe partial class QCOM
        {
            /// <summary> <b>[requires: GL_QCOM_driver_control]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetDriverControlsQCOM(int* num, int size, uint* driverControls) => GLPointers._GetDriverControlsQCOM_fnptr(num, size, driverControls);
            
            /// <summary> <b>[requires: GL_QCOM_driver_control]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetDriverControlStringQCOM(uint driverControl, int bufSize, int* length, byte* driverControlString) => GLPointers._GetDriverControlStringQCOM_fnptr(driverControl, bufSize, length, driverControlString);
            
            /// <summary> <b>[requires: GL_QCOM_driver_control]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void EnableDriverControlQCOM(uint driverControl) => GLPointers._EnableDriverControlQCOM_fnptr(driverControl);
            
            /// <summary> <b>[requires: GL_QCOM_driver_control]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DisableDriverControlQCOM(uint driverControl) => GLPointers._DisableDriverControlQCOM_fnptr(driverControl);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ExtGetTexturesQCOM(int* textures, int maxTextures, int* numTextures) => GLPointers._ExtGetTexturesQCOM_fnptr(textures, maxTextures, numTextures);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ExtGetBuffersQCOM(int* buffers, int maxBuffers, int* numBuffers) => GLPointers._ExtGetBuffersQCOM_fnptr(buffers, maxBuffers, numBuffers);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ExtGetRenderbuffersQCOM(int* renderbuffers, int maxRenderbuffers, int* numRenderbuffers) => GLPointers._ExtGetRenderbuffersQCOM_fnptr(renderbuffers, maxRenderbuffers, numRenderbuffers);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ExtGetFramebuffersQCOM(int* framebuffers, int maxFramebuffers, int* numFramebuffers) => GLPointers._ExtGetFramebuffersQCOM_fnptr(framebuffers, maxFramebuffers, numFramebuffers);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ExtGetTexLevelParameterivQCOM(int texture, All face, int level, All pname, int* parameters) => GLPointers._ExtGetTexLevelParameterivQCOM_fnptr(texture, (uint)face, level, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ExtTexObjectStateOverrideiQCOM(All target, All pname, int param) => GLPointers._ExtTexObjectStateOverrideiQCOM_fnptr((uint)target, (uint)pname, param);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ExtGetTexSubImageQCOM(All target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* texels) => GLPointers._ExtGetTexSubImageQCOM_fnptr((uint)target, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, (uint)type, texels);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ExtGetBufferPointervQCOM(All target, void** parameters) => GLPointers._ExtGetBufferPointervQCOM_fnptr((uint)target, parameters);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get2]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ExtGetShadersQCOM(int* shaders, int maxShaders, int* numShaders) => GLPointers._ExtGetShadersQCOM_fnptr(shaders, maxShaders, numShaders);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get2]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ExtGetProgramsQCOM(int* programs, int maxPrograms, int* numPrograms) => GLPointers._ExtGetProgramsQCOM_fnptr(programs, maxPrograms, numPrograms);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get2]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static bool ExtIsProgramBinaryQCOM(int program) => GLPointers._ExtIsProgramBinaryQCOM_fnptr(program) != 0;
            
            /// <summary> <b>[requires: GL_QCOM_extended_get2]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ExtGetProgramBinarySourceQCOM(int program, ShaderType shadertype, byte* source, int* length) => GLPointers._ExtGetProgramBinarySourceQCOM_fnptr(program, (uint)shadertype, source, length);
            
            /// <summary> <b>[requires: GL_QCOM_tiled_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void StartTilingQCOM(uint x, uint y, uint width, uint height, BufferBitQCOM preserveMask) => GLPointers._StartTilingQCOM_fnptr(x, y, width, height, (uint)preserveMask);
            
            /// <summary> <b>[requires: GL_QCOM_tiled_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void EndTilingQCOM(BufferBitQCOM preserveMask) => GLPointers._EndTilingQCOM_fnptr((uint)preserveMask);
            
        }
    }
}
