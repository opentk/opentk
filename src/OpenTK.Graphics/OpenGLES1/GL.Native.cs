// This file is auto generated, do not edit.
using System;
using System.Runtime.InteropServices;
using OpenTK.Graphics;

namespace OpenTK.Graphics.OpenGLES1
{
    public static unsafe partial class GL
    {
        private static IntPtr[] EntryPoints;
        
        /// <summary> <b>[requires: v1.0]</b> Specify the alpha test function. </summary>
        /// <param name="func">Specifies the alpha comparison function. Symbolic constants GL_NEVER, GL_LESS, GL_EQUAL, GL_LEQUAL, GL_GREATER, GL_NOTEQUAL, GL_GEQUAL, and GL_ALWAYS are accepted. The initial value is GL_ALWAYS. </param>
        /// <param name="reference">Specifies the reference value that incoming alpha values are compared to. This value is clamped to the range [0, 1], where 0 represents the lowest possible alpha value and 1 the highest possible value. The initial reference value is 0. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glAlphaFunc.xml" /></remarks>
        public static void AlphaFunc(AlphaFunction func, float reference) => ((delegate* unmanaged<AlphaFunction, float, void>)EntryPoints[0])(func, reference);
        [UnmanagedCallersOnly]
        private static void AlphaFunc_Lazy(AlphaFunction func, float reference)
        {
            EntryPoints[0] = GLLoader.BindingsContext.GetProcAddress("glAlphaFunc");
            ((delegate* unmanaged<AlphaFunction, float, void>)EntryPoints[0])(func, reference);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Specify clear values for the color buffer. </summary>
        /// <param name="red">Specify the red, green, blue, and alpha values used when the color buffer is cleared. The initial values are all 0.</param>
        /// <param name="green">Specify the red, green, blue, and alpha values used when the color buffer is cleared. The initial values are all 0.</param>
        /// <param name="blue">Specify the red, green, blue, and alpha values used when the color buffer is cleared. The initial values are all 0.</param>
        /// <param name="alpha">Specify the red, green, blue, and alpha values used when the color buffer is cleared. The initial values are all 0.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glClearColor.xml" /></remarks>
        public static void ClearColor(float red, float green, float blue, float alpha) => ((delegate* unmanaged<float, float, float, float, void>)EntryPoints[1])(red, green, blue, alpha);
        [UnmanagedCallersOnly]
        private static void ClearColor_Lazy(float red, float green, float blue, float alpha)
        {
            EntryPoints[1] = GLLoader.BindingsContext.GetProcAddress("glClearColor");
            ((delegate* unmanaged<float, float, float, float, void>)EntryPoints[1])(red, green, blue, alpha);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Specify the clear value for the depth buffer. </summary>
        /// <param name="depth">Specifies the depth value used when the depth buffer is cleared. The initial value is 1.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glClearDepth.xml" /></remarks>
        public static void ClearDepthf(float d) => ((delegate* unmanaged<float, void>)EntryPoints[2])(d);
        [UnmanagedCallersOnly]
        private static void ClearDepthf_Lazy(float d)
        {
            EntryPoints[2] = GLLoader.BindingsContext.GetProcAddress("glClearDepthf");
            ((delegate* unmanaged<float, void>)EntryPoints[2])(d);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Specify a plane against which all geometry is    clipped. </summary>
        /// <param name="plane">Specifies which clipping plane is being positioned. Symbolic names of the form GL_CLIP_PLANEi, where i is an integer between 0 and GL_MAX_CLIP_PLANES -1 , are accepted.</param>
        /// <param name="equation">Specifies the address of an array of four fixed-point or floating-point values. These are the coefficients of a plane equation in object coordinates: p1, p2, p3, and p4, in that order.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glClipPlane.xml" /></remarks>
        public static void ClipPlanef(ClipPlaneName p, float* eqn) => ((delegate* unmanaged<ClipPlaneName, float*, void>)EntryPoints[3])(p, eqn);
        [UnmanagedCallersOnly]
        private static void ClipPlanef_Lazy(ClipPlaneName p, float* eqn)
        {
            EntryPoints[3] = GLLoader.BindingsContext.GetProcAddress("glClipPlanef");
            ((delegate* unmanaged<ClipPlaneName, float*, void>)EntryPoints[3])(p, eqn);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Set the current color. </summary>
        /// <param name="red">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <param name="green">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <param name="blue">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <param name="alpha">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glColor.xml" /></remarks>
        public static void Color4f(float red, float green, float blue, float alpha) => ((delegate* unmanaged<float, float, float, float, void>)EntryPoints[4])(red, green, blue, alpha);
        [UnmanagedCallersOnly]
        private static void Color4f_Lazy(float red, float green, float blue, float alpha)
        {
            EntryPoints[4] = GLLoader.BindingsContext.GetProcAddress("glColor4f");
            ((delegate* unmanaged<float, float, float, float, void>)EntryPoints[4])(red, green, blue, alpha);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Specify mapping of depth values from normalized        device coordinates to window coordinates. </summary>
        /// <param name="near">Specifies the mapping of the near clipping plane to window coordinates. The initial value is 0.</param>
        /// <param name="far">Specifies the mapping of the far clipping plane to window coordinates. The initial value is 1.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glDepthRange.xml" /></remarks>
        public static void DepthRangef(float n, float f) => ((delegate* unmanaged<float, float, void>)EntryPoints[5])(n, f);
        [UnmanagedCallersOnly]
        private static void DepthRangef_Lazy(float n, float f)
        {
            EntryPoints[5] = GLLoader.BindingsContext.GetProcAddress("glDepthRangef");
            ((delegate* unmanaged<float, float, void>)EntryPoints[5])(n, f);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Specify fog parameters. </summary>
        /// <param name="pname">Specifies a single-valued fog parameter. GL_FOG_MODE, GL_FOG_DENSITY, GL_FOG_START, and GL_FOG_END are accepted.</param>
        /// <param name="param">Specifies the value that pname will be set to.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glFog.xml" /></remarks>
        public static void Fogf(FogParameter pname, float param) => ((delegate* unmanaged<FogParameter, float, void>)EntryPoints[6])(pname, param);
        [UnmanagedCallersOnly]
        private static void Fogf_Lazy(FogParameter pname, float param)
        {
            EntryPoints[6] = GLLoader.BindingsContext.GetProcAddress("glFogf");
            ((delegate* unmanaged<FogParameter, float, void>)EntryPoints[6])(pname, param);
        }
        
        public static void Fogfv(FogParameter pname, float* parameters) => ((delegate* unmanaged<FogParameter, float*, void>)EntryPoints[7])(pname, parameters);
        [UnmanagedCallersOnly]
        private static void Fogfv_Lazy(FogParameter pname, float* parameters)
        {
            EntryPoints[7] = GLLoader.BindingsContext.GetProcAddress("glFogfv");
            ((delegate* unmanaged<FogParameter, float*, void>)EntryPoints[7])(pname, parameters);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Multiply the current matrix by a perspective matrix. </summary>
        /// <param name="left">Specify the coordinates for the left and right vertical clipping planes.</param>
        /// <param name="right">Specify the coordinates for the left and right vertical clipping planes.</param>
        /// <param name="bottom">Specify the coordinates for the bottom and top horizontal clipping planes.</param>
        /// <param name="top">Specify the coordinates for the bottom and top horizontal clipping planes.</param>
        /// <param name="near">Specify the distances to the near and far depth clipping planes. Both distances must be positive.</param>
        /// <param name="far">Specify the distances to the near and far depth clipping planes. Both distances must be positive.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glFrustum.xml" /></remarks>
        public static void Frustumf(float l, float r, float b, float t, float n, float f) => ((delegate* unmanaged<float, float, float, float, float, float, void>)EntryPoints[8])(l, r, b, t, n, f);
        [UnmanagedCallersOnly]
        private static void Frustumf_Lazy(float l, float r, float b, float t, float n, float f)
        {
            EntryPoints[8] = GLLoader.BindingsContext.GetProcAddress("glFrustumf");
            ((delegate* unmanaged<float, float, float, float, float, float, void>)EntryPoints[8])(l, r, b, t, n, f);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Return the coefficients of the specified clipping    plane. </summary>
        /// <param name="plane">Specifies a clipping plane. The number of clipping planes depends on the implementation, but at least six clipping planes are supported. Symbolic names of the form GL_CLIP_PLANE i, where i is an integer between 0 and GL_MAX_CLIP_PLANES -1 , are accepted.</param>
        /// <param name="equation">Returns four fixed-point or floating-point values that are the coefficients of the plane equation of plane in eye coordinates in the order p1, p2, p3, and p4. The initial value is (0, 0, 0, 0).</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetClipPlane.xml" /></remarks>
        public static void GetClipPlanef(ClipPlaneName plane, float* equation) => ((delegate* unmanaged<ClipPlaneName, float*, void>)EntryPoints[9])(plane, equation);
        [UnmanagedCallersOnly]
        private static void GetClipPlanef_Lazy(ClipPlaneName plane, float* equation)
        {
            EntryPoints[9] = GLLoader.BindingsContext.GetProcAddress("glGetClipPlanef");
            ((delegate* unmanaged<ClipPlaneName, float*, void>)EntryPoints[9])(plane, equation);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Return the value or values of a selected parameter. </summary>
        /// <param name="pname">Specifies the parameter value to be returned. The symbolic constants in the list below are accepted.</param>
        /// <param name="parameters">Returns the value or values of the specified parameter.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGet.xml" /></remarks>
        public static void GetFloatv(GetPName pname, float* data) => ((delegate* unmanaged<GetPName, float*, void>)EntryPoints[10])(pname, data);
        [UnmanagedCallersOnly]
        private static void GetFloatv_Lazy(GetPName pname, float* data)
        {
            EntryPoints[10] = GLLoader.BindingsContext.GetProcAddress("glGetFloatv");
            ((delegate* unmanaged<GetPName, float*, void>)EntryPoints[10])(pname, data);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Return light source parameter values. </summary>
        /// <param name="light"> Specifies a light source. The number of possible lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form GL_LIGHTi where 0<i< GL_MAX_LIGHTS </param>
        /// <param name="pname"> Specifies a light source parameter for light. Accepted symbolic names are GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_POSITION, GL_SPOT_DIRECTION, GL_SPOT_EXPONENT, GL_SPOT_CUTOFF, GL_CONSTANT_ATTENUATION, GL_LINEAR_ATTENUATION, and GL_QUADRATIC_ATTENUATION. </param>
        /// <param name="parameters"> Returns the requested data. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetLight.xml" /></remarks>
        public static void GetLightfv(LightName light, LightParameter pname, float* parameters) => ((delegate* unmanaged<LightName, LightParameter, float*, void>)EntryPoints[11])(light, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetLightfv_Lazy(LightName light, LightParameter pname, float* parameters)
        {
            EntryPoints[11] = GLLoader.BindingsContext.GetProcAddress("glGetLightfv");
            ((delegate* unmanaged<LightName, LightParameter, float*, void>)EntryPoints[11])(light, pname, parameters);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Return material parameters values. </summary>
        /// <param name="face"> Specifies which of the two materials is being queried. GL_FRONT or GL_BACK are accepted, representing the front and back materials, respectively. </param>
        /// <param name="pname"> Specifies the material parameter to return. Accepted symbolic names are GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_EMISSION, and GL_SHININESS. </param>
        /// <param name="parameters"> Returns the requested data. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetMaterial.xml" /></remarks>
        public static void GetMaterialfv(MaterialFace face, MaterialParameter pname, float* parameters) => ((delegate* unmanaged<MaterialFace, MaterialParameter, float*, void>)EntryPoints[12])(face, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetMaterialfv_Lazy(MaterialFace face, MaterialParameter pname, float* parameters)
        {
            EntryPoints[12] = GLLoader.BindingsContext.GetProcAddress("glGetMaterialfv");
            ((delegate* unmanaged<MaterialFace, MaterialParameter, float*, void>)EntryPoints[12])(face, pname, parameters);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Return texture environment parameters. </summary>
        /// <param name="target"> Specifies a texture environment. May be GL_TEXTURE_ENV or GL_POINT_SPRITE_OES. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture environment parameter. Accepted values are GL_TEXTURE_ENV_MODE, GL_TEXTURE_ENV_COLOR, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE_OES. </param>
        /// <param name="parameters"> Returns the requested data. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetTexEnv.xml" /></remarks>
        public static void GetTexEnvfv(TextureEnvTarget target, TextureEnvParameter pname, float* parameters) => ((delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, float*, void>)EntryPoints[13])(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetTexEnvfv_Lazy(TextureEnvTarget target, TextureEnvParameter pname, float* parameters)
        {
            EntryPoints[13] = GLLoader.BindingsContext.GetProcAddress("glGetTexEnvfv");
            ((delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, float*, void>)EntryPoints[13])(target, pname, parameters);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Return texture parameter values. </summary>
        /// <param name="target">Specifies the target texture, which must be GL_TEXTURE_2D.</param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. Which can be one of the following: GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_GENERATE_MIPMAP. </param>
        /// <param name="parameters">Returns texture parameters.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetTexParameter.xml" /></remarks>
        public static void GetTexParameterfv(TextureTarget target, GetTextureParameter pname, float* parameters) => ((delegate* unmanaged<TextureTarget, GetTextureParameter, float*, void>)EntryPoints[14])(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetTexParameterfv_Lazy(TextureTarget target, GetTextureParameter pname, float* parameters)
        {
            EntryPoints[14] = GLLoader.BindingsContext.GetProcAddress("glGetTexParameterfv");
            ((delegate* unmanaged<TextureTarget, GetTextureParameter, float*, void>)EntryPoints[14])(target, pname, parameters);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Set the lighting model parameters. </summary>
        /// <param name="pname">Specifies a single-valued lighting model parameter. Must be GL_LIGHT_MODEL_TWO_SIDE.</param>
        /// <param name="param">Specifies the value that param will be set to.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glLightModel.xml" /></remarks>
        public static void LightModelf(LightModelParameter pname, float param) => ((delegate* unmanaged<LightModelParameter, float, void>)EntryPoints[15])(pname, param);
        [UnmanagedCallersOnly]
        private static void LightModelf_Lazy(LightModelParameter pname, float param)
        {
            EntryPoints[15] = GLLoader.BindingsContext.GetProcAddress("glLightModelf");
            ((delegate* unmanaged<LightModelParameter, float, void>)EntryPoints[15])(pname, param);
        }
        
        public static void LightModelfv(LightModelParameter pname, float* parameters) => ((delegate* unmanaged<LightModelParameter, float*, void>)EntryPoints[16])(pname, parameters);
        [UnmanagedCallersOnly]
        private static void LightModelfv_Lazy(LightModelParameter pname, float* parameters)
        {
            EntryPoints[16] = GLLoader.BindingsContext.GetProcAddress("glLightModelfv");
            ((delegate* unmanaged<LightModelParameter, float*, void>)EntryPoints[16])(pname, parameters);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Set light source parameters. </summary>
        /// <param name="light">Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form GL_LIGHTi where 0 <= i < GL_MAX_LIGHTS . </param>
        /// <param name="pname">Specifies a single-valued light source parameter for light. GL_SPOT_EXPONENT, GL_SPOT_CUTOFF, GL_CONSTANT_ATTENUATION, GL_LINEAR_ATTENUATION, and GL_QUADRATIC_ATTENUATION are accepted.</param>
        /// <param name="param">Specifies the value that parameter pname of light source light will be set to.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glLight.xml" /></remarks>
        public static void Lightf(LightName light, LightParameter pname, float param) => ((delegate* unmanaged<LightName, LightParameter, float, void>)EntryPoints[17])(light, pname, param);
        [UnmanagedCallersOnly]
        private static void Lightf_Lazy(LightName light, LightParameter pname, float param)
        {
            EntryPoints[17] = GLLoader.BindingsContext.GetProcAddress("glLightf");
            ((delegate* unmanaged<LightName, LightParameter, float, void>)EntryPoints[17])(light, pname, param);
        }
        
        public static void Lightfv(LightName light, LightParameter pname, float* parameters) => ((delegate* unmanaged<LightName, LightParameter, float*, void>)EntryPoints[18])(light, pname, parameters);
        [UnmanagedCallersOnly]
        private static void Lightfv_Lazy(LightName light, LightParameter pname, float* parameters)
        {
            EntryPoints[18] = GLLoader.BindingsContext.GetProcAddress("glLightfv");
            ((delegate* unmanaged<LightName, LightParameter, float*, void>)EntryPoints[18])(light, pname, parameters);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Specify the width of rasterized lines. </summary>
        /// <param name="width">Specifies the width of rasterized lines. The initial value is 1.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glLineWidth.xml" /></remarks>
        public static void LineWidth(float width) => ((delegate* unmanaged<float, void>)EntryPoints[19])(width);
        [UnmanagedCallersOnly]
        private static void LineWidth_Lazy(float width)
        {
            EntryPoints[19] = GLLoader.BindingsContext.GetProcAddress("glLineWidth");
            ((delegate* unmanaged<float, void>)EntryPoints[19])(width);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Replace the current matrix with the specifiedmatrix. </summary>
        /// <param name="m">Specifies a pointer to 16 consecutive values, which are used as the elements of a 4x4 column-major matrix.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glLoadMatrix.xml" /></remarks>
        public static void LoadMatrixf(float* m) => ((delegate* unmanaged<float*, void>)EntryPoints[20])(m);
        [UnmanagedCallersOnly]
        private static void LoadMatrixf_Lazy(float* m)
        {
            EntryPoints[20] = GLLoader.BindingsContext.GetProcAddress("glLoadMatrixf");
            ((delegate* unmanaged<float*, void>)EntryPoints[20])(m);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Specify material parameters for the lighting model. </summary>
        /// <param name="face">Specifies which face or faces are being updated. Must be GL_FRONT_AND_BACK.</param>
        /// <param name="pname">Specifies the single-valued material parameter of the face or faces that is being updated. Must be GL_SHININESS.</param>
        /// <param name="param">Specifies the value that parameter GL_SHININESS will be set to.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glMaterial.xml" /></remarks>
        public static void Materialf(MaterialFace face, MaterialParameter pname, float param) => ((delegate* unmanaged<MaterialFace, MaterialParameter, float, void>)EntryPoints[21])(face, pname, param);
        [UnmanagedCallersOnly]
        private static void Materialf_Lazy(MaterialFace face, MaterialParameter pname, float param)
        {
            EntryPoints[21] = GLLoader.BindingsContext.GetProcAddress("glMaterialf");
            ((delegate* unmanaged<MaterialFace, MaterialParameter, float, void>)EntryPoints[21])(face, pname, param);
        }
        
        public static void Materialfv(MaterialFace face, MaterialParameter pname, float* parameters) => ((delegate* unmanaged<MaterialFace, MaterialParameter, float*, void>)EntryPoints[22])(face, pname, parameters);
        [UnmanagedCallersOnly]
        private static void Materialfv_Lazy(MaterialFace face, MaterialParameter pname, float* parameters)
        {
            EntryPoints[22] = GLLoader.BindingsContext.GetProcAddress("glMaterialfv");
            ((delegate* unmanaged<MaterialFace, MaterialParameter, float*, void>)EntryPoints[22])(face, pname, parameters);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Multiply the current matrix with the specifiedmatrix. </summary>
        /// <param name="m">Points to 16 consecutive values that are used as the elements of a 4x4 column-major matrix.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glMultMatrix.xml" /></remarks>
        public static void MultMatrixf(float* m) => ((delegate* unmanaged<float*, void>)EntryPoints[23])(m);
        [UnmanagedCallersOnly]
        private static void MultMatrixf_Lazy(float* m)
        {
            EntryPoints[23] = GLLoader.BindingsContext.GetProcAddress("glMultMatrixf");
            ((delegate* unmanaged<float*, void>)EntryPoints[23])(m);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Set the current texture coordinates. </summary>
        /// <param name="target">Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least twoone. Symbolic constant must be one of GL_TEXTUREi, where i ranges from 0 to GL_MAX_TEXTURE_UNITS - 1, which is an implementation-dependent value.</param>
        /// <param name="s">Specify s, t, r, and q texture coordinates for target texture unit.</param>
        /// <param name="t">Specify s, t, r, and q texture coordinates for target texture unit.</param>
        /// <param name="r">Specify s, t, r, and q texture coordinates for target texture unit.</param>
        /// <param name="q">Specify s, t, r, and q texture coordinates for target texture unit.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glMultiTexCoord.xml" /></remarks>
        public static void MultiTexCoord4f(TextureUnit target, float s, float t, float r, float q) => ((delegate* unmanaged<TextureUnit, float, float, float, float, void>)EntryPoints[24])(target, s, t, r, q);
        [UnmanagedCallersOnly]
        private static void MultiTexCoord4f_Lazy(TextureUnit target, float s, float t, float r, float q)
        {
            EntryPoints[24] = GLLoader.BindingsContext.GetProcAddress("glMultiTexCoord4f");
            ((delegate* unmanaged<TextureUnit, float, float, float, float, void>)EntryPoints[24])(target, s, t, r, q);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Set the current normal vector. </summary>
        /// <param name="nx">Specify the x, y, and z coordinates of the new current normal. The initial value is (0, 0, 1).</param>
        /// <param name="ny">Specify the x, y, and z coordinates of the new current normal. The initial value is (0, 0, 1).</param>
        /// <param name="nz">Specify the x, y, and z coordinates of the new current normal. The initial value is (0, 0, 1).</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glNormal.xml" /></remarks>
        public static void Normal3f(float nx, float ny, float nz) => ((delegate* unmanaged<float, float, float, void>)EntryPoints[25])(nx, ny, nz);
        [UnmanagedCallersOnly]
        private static void Normal3f_Lazy(float nx, float ny, float nz)
        {
            EntryPoints[25] = GLLoader.BindingsContext.GetProcAddress("glNormal3f");
            ((delegate* unmanaged<float, float, float, void>)EntryPoints[25])(nx, ny, nz);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Multiply the current matrix with an orthographicmatrix. </summary>
        /// <param name="left">Specify the coordinates for the left and right vertical clipping planes.</param>
        /// <param name="right">Specify the coordinates for the left and right vertical clipping planes.</param>
        /// <param name="bottom">Specify the coordinates for the bottom and top horizontal clipping planes.</param>
        /// <param name="top">Specify the coordinates for the bottom and top horizontal clipping planes.</param>
        /// <param name="near">Specify the distances to the nearer and farther depth clipping planes. These values are negative if the plane is to be behind the viewer.</param>
        /// <param name="far">Specify the distances to the nearer and farther depth clipping planes. These values are negative if the plane is to be behind the viewer.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glOrtho.xml" /></remarks>
        public static void Orthof(float l, float r, float b, float t, float n, float f) => ((delegate* unmanaged<float, float, float, float, float, float, void>)EntryPoints[26])(l, r, b, t, n, f);
        [UnmanagedCallersOnly]
        private static void Orthof_Lazy(float l, float r, float b, float t, float n, float f)
        {
            EntryPoints[26] = GLLoader.BindingsContext.GetProcAddress("glOrthof");
            ((delegate* unmanaged<float, float, float, float, float, float, void>)EntryPoints[26])(l, r, b, t, n, f);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Specify parameters for point rasterization. </summary>
        /// <param name="pname"> Specifies the single-valued parameter to be updated. Can be either GL_POINT_SIZE_MIN, GL_POINT_SIZE_MAX, or GL_POINT_FADE_THRESHOLD_SIZE. </param>
        /// <param name="param"> Specifies the value that the parameter will be set to. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glPointParameter.xml" /></remarks>
        public static void PointParameterf(PointParameterNameARB pname, float param) => ((delegate* unmanaged<PointParameterNameARB, float, void>)EntryPoints[27])(pname, param);
        [UnmanagedCallersOnly]
        private static void PointParameterf_Lazy(PointParameterNameARB pname, float param)
        {
            EntryPoints[27] = GLLoader.BindingsContext.GetProcAddress("glPointParameterf");
            ((delegate* unmanaged<PointParameterNameARB, float, void>)EntryPoints[27])(pname, param);
        }
        
        public static void PointParameterfv(PointParameterNameARB pname, float* parameters) => ((delegate* unmanaged<PointParameterNameARB, float*, void>)EntryPoints[28])(pname, parameters);
        [UnmanagedCallersOnly]
        private static void PointParameterfv_Lazy(PointParameterNameARB pname, float* parameters)
        {
            EntryPoints[28] = GLLoader.BindingsContext.GetProcAddress("glPointParameterfv");
            ((delegate* unmanaged<PointParameterNameARB, float*, void>)EntryPoints[28])(pname, parameters);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Specify the diameter of rasterized points. </summary>
        /// <param name="size">Specifies the diameter of rasterized points. The initial value is 1.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glPointSize.xml" /></remarks>
        public static void PointSize(float size) => ((delegate* unmanaged<float, void>)EntryPoints[29])(size);
        [UnmanagedCallersOnly]
        private static void PointSize_Lazy(float size)
        {
            EntryPoints[29] = GLLoader.BindingsContext.GetProcAddress("glPointSize");
            ((delegate* unmanaged<float, void>)EntryPoints[29])(size);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Set the scale and units used to calculate depth        values. </summary>
        /// <param name="factor">Specifies a scale factor that is used to create a variable depth offset for each polygon. The initial value is 0.</param>
        /// <param name="units">Is multiplied by an implementation-specific value to create a constant depth offset. The initial value is 0.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glPolygonOffset.xml" /></remarks>
        public static void PolygonOffset(float factor, float units) => ((delegate* unmanaged<float, float, void>)EntryPoints[30])(factor, units);
        [UnmanagedCallersOnly]
        private static void PolygonOffset_Lazy(float factor, float units)
        {
            EntryPoints[30] = GLLoader.BindingsContext.GetProcAddress("glPolygonOffset");
            ((delegate* unmanaged<float, float, void>)EntryPoints[30])(factor, units);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Multiply the current matrix by a rotation matrix. </summary>
        /// <param name="angle">Specifies the angle of rotation, in degrees.</param>
        /// <param name="x">Specify the x, y, and z coordinates of a vector, respectively.</param>
        /// <param name="y">Specify the x, y, and z coordinates of a vector, respectively.</param>
        /// <param name="z">Specify the x, y, and z coordinates of a vector, respectively.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glRotate.xml" /></remarks>
        public static void Rotatef(float angle, float x, float y, float z) => ((delegate* unmanaged<float, float, float, float, void>)EntryPoints[31])(angle, x, y, z);
        [UnmanagedCallersOnly]
        private static void Rotatef_Lazy(float angle, float x, float y, float z)
        {
            EntryPoints[31] = GLLoader.BindingsContext.GetProcAddress("glRotatef");
            ((delegate* unmanaged<float, float, float, float, void>)EntryPoints[31])(angle, x, y, z);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Multiply the current matrix by a general scalingmatrix. </summary>
        /// <param name="x">Specify scale factors along the x, y, and z axes, respectively.</param>
        /// <param name="y">Specify scale factors along the x, y, and z axes, respectively.</param>
        /// <param name="z">Specify scale factors along the x, y, and z axes, respectively.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glScale.xml" /></remarks>
        public static void Scalef(float x, float y, float z) => ((delegate* unmanaged<float, float, float, void>)EntryPoints[32])(x, y, z);
        [UnmanagedCallersOnly]
        private static void Scalef_Lazy(float x, float y, float z)
        {
            EntryPoints[32] = GLLoader.BindingsContext.GetProcAddress("glScalef");
            ((delegate* unmanaged<float, float, float, void>)EntryPoints[32])(x, y, z);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Set texture environment parameters. </summary>
        /// <param name="target"> Specifies a texture environment. May be GL_TEXTURE_ENV or GL_POINT_SPRITE_OES. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture environment parameter. May be either GL_TEXTURE_ENV_MODE, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE_OES. </param>
        /// <param name="param"> Specifies a single symbolic constant, one of GL_ADD, GL_ADD_SIGNED, GL_DOT3_RGB, GL_DOT3_RGBA, GL_INTERPOLATE, GL_MODULATE, GL_DECAL, GL_BLEND, GL_REPLACE, GL_SUBTRACT, GL_COMBINE, GL_TEXTURE, GL_CONSTANT, GL_PRIMARY_COLOR, GL_PREVIOUS, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, a single boolean value for the point sprite texture coordinate replacement, or 1.0, 2.0, or 4.0 when specifying the GL_RGB_SCALE or GL_ALPHA_SCALE. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glTexEnv.xml" /></remarks>
        public static void TexEnvf(TextureEnvTarget target, TextureEnvParameter pname, float param) => ((delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, float, void>)EntryPoints[33])(target, pname, param);
        [UnmanagedCallersOnly]
        private static void TexEnvf_Lazy(TextureEnvTarget target, TextureEnvParameter pname, float param)
        {
            EntryPoints[33] = GLLoader.BindingsContext.GetProcAddress("glTexEnvf");
            ((delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, float, void>)EntryPoints[33])(target, pname, param);
        }
        
        public static void TexEnvfv(TextureEnvTarget target, TextureEnvParameter pname, float* parameters) => ((delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, float*, void>)EntryPoints[34])(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void TexEnvfv_Lazy(TextureEnvTarget target, TextureEnvParameter pname, float* parameters)
        {
            EntryPoints[34] = GLLoader.BindingsContext.GetProcAddress("glTexEnvfv");
            ((delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, float*, void>)EntryPoints[34])(target, pname, parameters);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Set texture parameters. </summary>
        /// <param name="target">Specifies the target texture, which must be GL_TEXTURE_2D.</param>
        /// <param name="pname">Specifies the symbolic name of a single-valued texture parameter. Which can be one of the following: GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_GENERATE_MIPMAP.</param>
        /// <param name="param">Specifies the value of pname.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glTexParameter.xml" /></remarks>
        public static void TexParameterf(TextureTarget target, TextureParameterName pname, float param) => ((delegate* unmanaged<TextureTarget, TextureParameterName, float, void>)EntryPoints[35])(target, pname, param);
        [UnmanagedCallersOnly]
        private static void TexParameterf_Lazy(TextureTarget target, TextureParameterName pname, float param)
        {
            EntryPoints[35] = GLLoader.BindingsContext.GetProcAddress("glTexParameterf");
            ((delegate* unmanaged<TextureTarget, TextureParameterName, float, void>)EntryPoints[35])(target, pname, param);
        }
        
        public static void TexParameterfv(TextureTarget target, TextureParameterName pname, float* parameters) => ((delegate* unmanaged<TextureTarget, TextureParameterName, float*, void>)EntryPoints[36])(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void TexParameterfv_Lazy(TextureTarget target, TextureParameterName pname, float* parameters)
        {
            EntryPoints[36] = GLLoader.BindingsContext.GetProcAddress("glTexParameterfv");
            ((delegate* unmanaged<TextureTarget, TextureParameterName, float*, void>)EntryPoints[36])(target, pname, parameters);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Multiply the current matrix by a translation matrix. </summary>
        /// <param name="x">Specify the x, y, and z coordinates of a translation vector.</param>
        /// <param name="y">Specify the x, y, and z coordinates of a translation vector.</param>
        /// <param name="z">Specify the x, y, and z coordinates of a translation vector.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glTranslate.xml" /></remarks>
        public static void Translatef(float x, float y, float z) => ((delegate* unmanaged<float, float, float, void>)EntryPoints[37])(x, y, z);
        [UnmanagedCallersOnly]
        private static void Translatef_Lazy(float x, float y, float z)
        {
            EntryPoints[37] = GLLoader.BindingsContext.GetProcAddress("glTranslatef");
            ((delegate* unmanaged<float, float, float, void>)EntryPoints[37])(x, y, z);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Select server-side active texture unit. </summary>
        /// <param name="texture"> Specifies which texture unit to make active. The number of texture units is implementation dependent, but must be at least two. texture must be one of GL_TEXTUREi, where 0 <= i < GL_MAX_TEXTURE_UNITS , which is an implementation-dependent value. The initial value is GL_TEXTURE0. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glActiveTexture.xml" /></remarks>
        public static void ActiveTexture(TextureUnit texture) => ((delegate* unmanaged<TextureUnit, void>)EntryPoints[38])(texture);
        [UnmanagedCallersOnly]
        private static void ActiveTexture_Lazy(TextureUnit texture)
        {
            EntryPoints[38] = GLLoader.BindingsContext.GetProcAddress("glActiveTexture");
            ((delegate* unmanaged<TextureUnit, void>)EntryPoints[38])(texture);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Specify the alpha test function. </summary>
        /// <param name="func">Specifies the alpha comparison function. Symbolic constants GL_NEVER, GL_LESS, GL_EQUAL, GL_LEQUAL, GL_GREATER, GL_NOTEQUAL, GL_GEQUAL, and GL_ALWAYS are accepted. The initial value is GL_ALWAYS. </param>
        /// <param name="reference">Specifies the reference value that incoming alpha values are compared to. This value is clamped to the range [0, 1], where 0 represents the lowest possible alpha value and 1 the highest possible value. The initial reference value is 0. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glAlphaFunc.xml" /></remarks>
        public static void AlphaFuncx(AlphaFunction func, int reference) => ((delegate* unmanaged<AlphaFunction, int, void>)EntryPoints[39])(func, reference);
        [UnmanagedCallersOnly]
        private static void AlphaFuncx_Lazy(AlphaFunction func, int reference)
        {
            EntryPoints[39] = GLLoader.BindingsContext.GetProcAddress("glAlphaFuncx");
            ((delegate* unmanaged<AlphaFunction, int, void>)EntryPoints[39])(func, reference);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Bind a named buffer to a target. </summary>
        /// <param name="target"> Specifies the target to which the buffer is bound. The symbolic constant must be GL_ARRAY_BUFFER or GL_ELEMENT_ARRAY_BUFFER. </param>
        /// <param name="buffer">Specifies the name of a buffer object.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glBindBuffer.xml" /></remarks>
        public static void BindBuffer(BufferTargetARB target, BufferHandle buffer) => ((delegate* unmanaged<BufferTargetARB, BufferHandle, void>)EntryPoints[40])(target, buffer);
        [UnmanagedCallersOnly]
        private static void BindBuffer_Lazy(BufferTargetARB target, BufferHandle buffer)
        {
            EntryPoints[40] = GLLoader.BindingsContext.GetProcAddress("glBindBuffer");
            ((delegate* unmanaged<BufferTargetARB, BufferHandle, void>)EntryPoints[40])(target, buffer);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Bind a named texture to a texturing target. </summary>
        /// <param name="target">Specifies the target to which the texture is bound. Must be GL_TEXTURE_2D.</param>
        /// <param name="texture">Specifies the name of a texture.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glBindTexture.xml" /></remarks>
        public static void BindTexture(TextureTarget target, TextureHandle texture) => ((delegate* unmanaged<TextureTarget, TextureHandle, void>)EntryPoints[41])(target, texture);
        [UnmanagedCallersOnly]
        private static void BindTexture_Lazy(TextureTarget target, TextureHandle texture)
        {
            EntryPoints[41] = GLLoader.BindingsContext.GetProcAddress("glBindTexture");
            ((delegate* unmanaged<TextureTarget, TextureHandle, void>)EntryPoints[41])(target, texture);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Specify pixel arithmetic. </summary>
        /// <param name="sfactor"> Specifies how the red, green, blue, and alpha source blending factors are computed. The following symbolic constants are accepted: GL_ZERO, GL_ONE, GL_DST_COLOR, GL_ONE_MINUS_DST_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, GL_DST_ALPHA, GL_ONE_MINUS_DST_ALPHA, and GL_SRC_ALPHA_SATURATE. The initial value is GL_ONE. </param>
        /// <param name="dfactor">Specifies how the red, green, blue, and alpha destination blending factors are computed. Eight symbolic constants are accepted: GL_ZERO, GL_ONE, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, GL_DST_ALPHA, and GL_ONE_MINUS_DST_ALPHA. The initial value is GL_ZERO.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glBlendFunc.xml" /></remarks>
        public static void BlendFunc(BlendingFactor sfactor, BlendingFactor dfactor) => ((delegate* unmanaged<BlendingFactor, BlendingFactor, void>)EntryPoints[42])(sfactor, dfactor);
        [UnmanagedCallersOnly]
        private static void BlendFunc_Lazy(BlendingFactor sfactor, BlendingFactor dfactor)
        {
            EntryPoints[42] = GLLoader.BindingsContext.GetProcAddress("glBlendFunc");
            ((delegate* unmanaged<BlendingFactor, BlendingFactor, void>)EntryPoints[42])(sfactor, dfactor);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Creates and initializes a buffer object's data store.. </summary>
        /// <param name="target"> Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER or GL_ELEMENT_ARRAY_BUFFER. </param>
        /// <param name="size">Specifies the size in bytes of the buffer object's new data store.</param>
        /// <param name="data">Specifies a pointer to data that will be copied into the data store for initialization, or NULL if no data is to be copied.</param>
        /// <param name="usage"> Specifies the expected usage pattern of the data store. The symbolic constant must be GL_STATIC_DRAW or GL_DYNAMIC_DRAW. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glBufferData.xml" /></remarks>
        public static void BufferData(BufferTargetARB target, nint size, void* data, BufferUsageARB usage) => ((delegate* unmanaged<BufferTargetARB, nint, void*, BufferUsageARB, void>)EntryPoints[43])(target, size, data, usage);
        [UnmanagedCallersOnly]
        private static void BufferData_Lazy(BufferTargetARB target, nint size, void* data, BufferUsageARB usage)
        {
            EntryPoints[43] = GLLoader.BindingsContext.GetProcAddress("glBufferData");
            ((delegate* unmanaged<BufferTargetARB, nint, void*, BufferUsageARB, void>)EntryPoints[43])(target, size, data, usage);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Updates a subset of a buffer object's data store.. </summary>
        /// <param name="target"> Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER or GL_ELEMENT_ARRAY_BUFFER. </param>
        /// <param name="offset">Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes.</param>
        /// <param name="size">Specifies the size in bytes of the data store region being replaced.</param>
        /// <param name="data"> Specifies a pointer to the new data that will be copied into the data store.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glBufferSubData.xml" /></remarks>
        public static void BufferSubData(BufferTargetARB target, IntPtr offset, nint size, void* data) => ((delegate* unmanaged<BufferTargetARB, IntPtr, nint, void*, void>)EntryPoints[44])(target, offset, size, data);
        [UnmanagedCallersOnly]
        private static void BufferSubData_Lazy(BufferTargetARB target, IntPtr offset, nint size, void* data)
        {
            EntryPoints[44] = GLLoader.BindingsContext.GetProcAddress("glBufferSubData");
            ((delegate* unmanaged<BufferTargetARB, IntPtr, nint, void*, void>)EntryPoints[44])(target, offset, size, data);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Clear buffers to preset values. </summary>
        /// <param name="mask">Bitwise OR of masks that indicate the buffers to be cleared. Valid masks are GL_COLOR_BUFFER_BIT, GL_DEPTH_BUFFER_BIT, and GL_STENCIL_BUFFER_BIT.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glClear.xml" /></remarks>
        public static void Clear(ClearBufferMask mask) => ((delegate* unmanaged<ClearBufferMask, void>)EntryPoints[45])(mask);
        [UnmanagedCallersOnly]
        private static void Clear_Lazy(ClearBufferMask mask)
        {
            EntryPoints[45] = GLLoader.BindingsContext.GetProcAddress("glClear");
            ((delegate* unmanaged<ClearBufferMask, void>)EntryPoints[45])(mask);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Specify clear values for the color buffer. </summary>
        /// <param name="red">Specify the red, green, blue, and alpha values used when the color buffer is cleared. The initial values are all 0.</param>
        /// <param name="green">Specify the red, green, blue, and alpha values used when the color buffer is cleared. The initial values are all 0.</param>
        /// <param name="blue">Specify the red, green, blue, and alpha values used when the color buffer is cleared. The initial values are all 0.</param>
        /// <param name="alpha">Specify the red, green, blue, and alpha values used when the color buffer is cleared. The initial values are all 0.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glClearColor.xml" /></remarks>
        public static void ClearColorx(int red, int green, int blue, int alpha) => ((delegate* unmanaged<int, int, int, int, void>)EntryPoints[46])(red, green, blue, alpha);
        [UnmanagedCallersOnly]
        private static void ClearColorx_Lazy(int red, int green, int blue, int alpha)
        {
            EntryPoints[46] = GLLoader.BindingsContext.GetProcAddress("glClearColorx");
            ((delegate* unmanaged<int, int, int, int, void>)EntryPoints[46])(red, green, blue, alpha);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Specify the clear value for the depth buffer. </summary>
        /// <param name="depth">Specifies the depth value used when the depth buffer is cleared. The initial value is 1.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glClearDepth.xml" /></remarks>
        public static void ClearDepthx(int depth) => ((delegate* unmanaged<int, void>)EntryPoints[47])(depth);
        [UnmanagedCallersOnly]
        private static void ClearDepthx_Lazy(int depth)
        {
            EntryPoints[47] = GLLoader.BindingsContext.GetProcAddress("glClearDepthx");
            ((delegate* unmanaged<int, void>)EntryPoints[47])(depth);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Specify the clear value for the stencil buffer. </summary>
        /// <param name="s">Specifies the index used when the stencil buffer is cleared. The initial value is 0.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glClearStencil.xml" /></remarks>
        public static void ClearStencil(int s) => ((delegate* unmanaged<int, void>)EntryPoints[48])(s);
        [UnmanagedCallersOnly]
        private static void ClearStencil_Lazy(int s)
        {
            EntryPoints[48] = GLLoader.BindingsContext.GetProcAddress("glClearStencil");
            ((delegate* unmanaged<int, void>)EntryPoints[48])(s);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Select client-side active texture unit. </summary>
        /// <param name="texture"> Specifies which texture unit to make active. The number of texture units is implementation dependent, but must be at least two. texture must be one of GL_TEXTUREi, 0 <= i < GL_MAX_TEXTURE_UNITS , which is an implementation-dependent value. The initial value is GL_TEXTURE0. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glClientActiveTexture.xml" /></remarks>
        public static void ClientActiveTexture(TextureUnit texture) => ((delegate* unmanaged<TextureUnit, void>)EntryPoints[49])(texture);
        [UnmanagedCallersOnly]
        private static void ClientActiveTexture_Lazy(TextureUnit texture)
        {
            EntryPoints[49] = GLLoader.BindingsContext.GetProcAddress("glClientActiveTexture");
            ((delegate* unmanaged<TextureUnit, void>)EntryPoints[49])(texture);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Specify a plane against which all geometry is    clipped. </summary>
        /// <param name="plane">Specifies which clipping plane is being positioned. Symbolic names of the form GL_CLIP_PLANEi, where i is an integer between 0 and GL_MAX_CLIP_PLANES -1 , are accepted.</param>
        /// <param name="equation">Specifies the address of an array of four fixed-point or floating-point values. These are the coefficients of a plane equation in object coordinates: p1, p2, p3, and p4, in that order.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glClipPlane.xml" /></remarks>
        public static void ClipPlanex(ClipPlaneName plane, int* equation) => ((delegate* unmanaged<ClipPlaneName, int*, void>)EntryPoints[50])(plane, equation);
        [UnmanagedCallersOnly]
        private static void ClipPlanex_Lazy(ClipPlaneName plane, int* equation)
        {
            EntryPoints[50] = GLLoader.BindingsContext.GetProcAddress("glClipPlanex");
            ((delegate* unmanaged<ClipPlaneName, int*, void>)EntryPoints[50])(plane, equation);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Set the current color. </summary>
        /// <param name="red">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <param name="green">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <param name="blue">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <param name="alpha">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glColor.xml" /></remarks>
        public static void Color4ub(byte red, byte green, byte blue, byte alpha) => ((delegate* unmanaged<byte, byte, byte, byte, void>)EntryPoints[51])(red, green, blue, alpha);
        [UnmanagedCallersOnly]
        private static void Color4ub_Lazy(byte red, byte green, byte blue, byte alpha)
        {
            EntryPoints[51] = GLLoader.BindingsContext.GetProcAddress("glColor4ub");
            ((delegate* unmanaged<byte, byte, byte, byte, void>)EntryPoints[51])(red, green, blue, alpha);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Set the current color. </summary>
        /// <param name="red">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <param name="green">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <param name="blue">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <param name="alpha">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glColor.xml" /></remarks>
        public static void Color4x(int red, int green, int blue, int alpha) => ((delegate* unmanaged<int, int, int, int, void>)EntryPoints[52])(red, green, blue, alpha);
        [UnmanagedCallersOnly]
        private static void Color4x_Lazy(int red, int green, int blue, int alpha)
        {
            EntryPoints[52] = GLLoader.BindingsContext.GetProcAddress("glColor4x");
            ((delegate* unmanaged<int, int, int, int, void>)EntryPoints[52])(red, green, blue, alpha);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Enable and disable writing of color buffer        components. </summary>
        /// <param name="red">Specify whether red, green, blue, and alpha can or cannot be written into the color buffer. The initial values are all GL_TRUE, indicating that all color components can be written.</param>
        /// <param name="green">Specify whether red, green, blue, and alpha can or cannot be written into the color buffer. The initial values are all GL_TRUE, indicating that all color components can be written.</param>
        /// <param name="blue">Specify whether red, green, blue, and alpha can or cannot be written into the color buffer. The initial values are all GL_TRUE, indicating that all color components can be written.</param>
        /// <param name="alpha">Specify whether red, green, blue, and alpha can or cannot be written into the color buffer. The initial values are all GL_TRUE, indicating that all color components can be written.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glColorMask.xml" /></remarks>
        public static void ColorMask(byte red, byte green, byte blue, byte alpha) => ((delegate* unmanaged<byte, byte, byte, byte, void>)EntryPoints[53])(red, green, blue, alpha);
        [UnmanagedCallersOnly]
        private static void ColorMask_Lazy(byte red, byte green, byte blue, byte alpha)
        {
            EntryPoints[53] = GLLoader.BindingsContext.GetProcAddress("glColorMask");
            ((delegate* unmanaged<byte, byte, byte, byte, void>)EntryPoints[53])(red, green, blue, alpha);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Define an array of colors. </summary>
        /// <param name="size">Specifies the number of components per color. Must be 4. The initial value is 4.</param>
        /// <param name="type">Specifies the data type of each color component in the array. Symbolic constants GL_UNSIGNED_BYTE and GL_FIXED are accepted. However, the initial value is GL_FLOAT.</param>
        /// <param name="stride">Specifies the byte offset between consecutive colors. If stride is 0, the colors are understood to be tightly packed in the array. The initial value is 0.</param>
        /// <param name="pointer">Specifies a pointer to the first component of the first color element in the array.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glColorPointer.xml" /></remarks>
        public static void ColorPointer(int size, ColorPointerType type, int stride, void* pointer) => ((delegate* unmanaged<int, ColorPointerType, int, void*, void>)EntryPoints[54])(size, type, stride, pointer);
        [UnmanagedCallersOnly]
        private static void ColorPointer_Lazy(int size, ColorPointerType type, int stride, void* pointer)
        {
            EntryPoints[54] = GLLoader.BindingsContext.GetProcAddress("glColorPointer");
            ((delegate* unmanaged<int, ColorPointerType, int, void*, void>)EntryPoints[54])(size, type, stride, pointer);
        }
        
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
        public static void CompressedTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, void* data) => ((delegate* unmanaged<TextureTarget, int, InternalFormat, int, int, int, int, void*, void>)EntryPoints[55])(target, level, internalformat, width, height, border, imageSize, data);
        [UnmanagedCallersOnly]
        private static void CompressedTexImage2D_Lazy(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, void* data)
        {
            EntryPoints[55] = GLLoader.BindingsContext.GetProcAddress("glCompressedTexImage2D");
            ((delegate* unmanaged<TextureTarget, int, InternalFormat, int, int, int, int, void*, void>)EntryPoints[55])(target, level, internalformat, width, height, border, imageSize, data);
        }
        
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
        public static void CompressedTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, InternalFormat format, int imageSize, void* data) => ((delegate* unmanaged<TextureTarget, int, int, int, int, int, InternalFormat, int, void*, void>)EntryPoints[56])(target, level, xoffset, yoffset, width, height, format, imageSize, data);
        [UnmanagedCallersOnly]
        private static void CompressedTexSubImage2D_Lazy(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, InternalFormat format, int imageSize, void* data)
        {
            EntryPoints[56] = GLLoader.BindingsContext.GetProcAddress("glCompressedTexSubImage2D");
            ((delegate* unmanaged<TextureTarget, int, int, int, int, int, InternalFormat, int, void*, void>)EntryPoints[56])(target, level, xoffset, yoffset, width, height, format, imageSize, data);
        }
        
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
        public static void CopyTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int height, int border) => ((delegate* unmanaged<TextureTarget, int, InternalFormat, int, int, int, int, int, void>)EntryPoints[57])(target, level, internalformat, x, y, width, height, border);
        [UnmanagedCallersOnly]
        private static void CopyTexImage2D_Lazy(TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int height, int border)
        {
            EntryPoints[57] = GLLoader.BindingsContext.GetProcAddress("glCopyTexImage2D");
            ((delegate* unmanaged<TextureTarget, int, InternalFormat, int, int, int, int, int, void>)EntryPoints[57])(target, level, internalformat, x, y, width, height, border);
        }
        
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
        public static void CopyTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height) => ((delegate* unmanaged<TextureTarget, int, int, int, int, int, int, int, void>)EntryPoints[58])(target, level, xoffset, yoffset, x, y, width, height);
        [UnmanagedCallersOnly]
        private static void CopyTexSubImage2D_Lazy(TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height)
        {
            EntryPoints[58] = GLLoader.BindingsContext.GetProcAddress("glCopyTexSubImage2D");
            ((delegate* unmanaged<TextureTarget, int, int, int, int, int, int, int, void>)EntryPoints[58])(target, level, xoffset, yoffset, x, y, width, height);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Specify whether front- or back-facing polygons are        culled. </summary>
        /// <param name="mode">Specifies whether front- or back-facing polygons are culled. Symbolic constants GL_FRONT, GL_BACK, and GL_FRONT_AND_BACK are accepted. The initial value is GL_BACK.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glCullFace.xml" /></remarks>
        public static void CullFace(CullFaceMode mode) => ((delegate* unmanaged<CullFaceMode, void>)EntryPoints[59])(mode);
        [UnmanagedCallersOnly]
        private static void CullFace_Lazy(CullFaceMode mode)
        {
            EntryPoints[59] = GLLoader.BindingsContext.GetProcAddress("glCullFace");
            ((delegate* unmanaged<CullFaceMode, void>)EntryPoints[59])(mode);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Delete named buffer objects. </summary>
        /// <param name="n">Specifies the number of buffer objects to be deleted.</param>
        /// <param name="buffers">Specifies an array of buffer object names to be deleted.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glDeleteBuffers.xml" /></remarks>
        public static void DeleteBuffers(int n, BufferHandle* buffers) => ((delegate* unmanaged<int, BufferHandle*, void>)EntryPoints[60])(n, buffers);
        [UnmanagedCallersOnly]
        private static void DeleteBuffers_Lazy(int n, BufferHandle* buffers)
        {
            EntryPoints[60] = GLLoader.BindingsContext.GetProcAddress("glDeleteBuffers");
            ((delegate* unmanaged<int, BufferHandle*, void>)EntryPoints[60])(n, buffers);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Delete named textures. </summary>
        /// <param name="n">Specifies the number of textures to be deleted.</param>
        /// <param name="textures">Specifies an array of textures to be deleted.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glDeleteTextures.xml" /></remarks>
        public static void DeleteTextures(int n, TextureHandle* textures) => ((delegate* unmanaged<int, TextureHandle*, void>)EntryPoints[61])(n, textures);
        [UnmanagedCallersOnly]
        private static void DeleteTextures_Lazy(int n, TextureHandle* textures)
        {
            EntryPoints[61] = GLLoader.BindingsContext.GetProcAddress("glDeleteTextures");
            ((delegate* unmanaged<int, TextureHandle*, void>)EntryPoints[61])(n, textures);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Specify the value used for depth buffer comparisons. </summary>
        /// <param name="func">Specifies the depth comparison function. Symbolic constants GL_NEVER, GL_LESS, GL_EQUAL, GL_LEQUAL, GL_GREATER, GL_NOTEQUAL, GL_GEQUAL, and GL_ALWAYS are accepted. The initial value is GL_LESS.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glDepthFunc.xml" /></remarks>
        public static void DepthFunc(DepthFunction func) => ((delegate* unmanaged<DepthFunction, void>)EntryPoints[62])(func);
        [UnmanagedCallersOnly]
        private static void DepthFunc_Lazy(DepthFunction func)
        {
            EntryPoints[62] = GLLoader.BindingsContext.GetProcAddress("glDepthFunc");
            ((delegate* unmanaged<DepthFunction, void>)EntryPoints[62])(func);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Enable or disable writing into the depth buffer. </summary>
        /// <param name="flag">Specifies whether the depth buffer is enabled for writing. If flag is GL_FALSE, depth buffer writing is disabled, otherwise it is enabled. The initial value is GL_TRUE.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glDepthMask.xml" /></remarks>
        public static void DepthMask(byte flag) => ((delegate* unmanaged<byte, void>)EntryPoints[63])(flag);
        [UnmanagedCallersOnly]
        private static void DepthMask_Lazy(byte flag)
        {
            EntryPoints[63] = GLLoader.BindingsContext.GetProcAddress("glDepthMask");
            ((delegate* unmanaged<byte, void>)EntryPoints[63])(flag);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Specify mapping of depth values from normalized        device coordinates to window coordinates. </summary>
        /// <param name="near">Specifies the mapping of the near clipping plane to window coordinates. The initial value is 0.</param>
        /// <param name="far">Specifies the mapping of the far clipping plane to window coordinates. The initial value is 1.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glDepthRange.xml" /></remarks>
        public static void DepthRangex(int n, int f) => ((delegate* unmanaged<int, int, void>)EntryPoints[64])(n, f);
        [UnmanagedCallersOnly]
        private static void DepthRangex_Lazy(int n, int f)
        {
            EntryPoints[64] = GLLoader.BindingsContext.GetProcAddress("glDepthRangex");
            ((delegate* unmanaged<int, int, void>)EntryPoints[64])(n, f);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Enable or disable server-side GL capabilities. </summary>
        /// <param name="cap">Specifies a symbolic constant indicating a GL capability.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glEnable.xml" /></remarks>
        public static void Disable(EnableCap cap) => ((delegate* unmanaged<EnableCap, void>)EntryPoints[65])(cap);
        [UnmanagedCallersOnly]
        private static void Disable_Lazy(EnableCap cap)
        {
            EntryPoints[65] = GLLoader.BindingsContext.GetProcAddress("glDisable");
            ((delegate* unmanaged<EnableCap, void>)EntryPoints[65])(cap);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Enable or disable client-side capability. </summary>
        /// <param name="array"> Specifies the capability to enable or disable. Symbolic constants GL_COLOR_ARRAY, GL_MATRIX_INDEX_ARRAY_OES, GL_NORMAL_ARRAY, GL_POINT_SIZE_ARRAY_OES, GL_TEXTURE_COORD_ARRAY, and GL_VERTEX_ARRAY, and GL_WEIGHT_ARRAY_OES are accepted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glEnableClientState.xml" /></remarks>
        public static void DisableClientState(EnableCap array) => ((delegate* unmanaged<EnableCap, void>)EntryPoints[66])(array);
        [UnmanagedCallersOnly]
        private static void DisableClientState_Lazy(EnableCap array)
        {
            EntryPoints[66] = GLLoader.BindingsContext.GetProcAddress("glDisableClientState");
            ((delegate* unmanaged<EnableCap, void>)EntryPoints[66])(array);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Render primitives from array data. </summary>
        /// <param name="mode">Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, and GL_TRIANGLES are accepted.</param>
        /// <param name="first">Specifies the starting index in the enabled arrays.</param>
        /// <param name="count">Specifies the number of indices to be rendered.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glDrawArrays.xml" /></remarks>
        public static void DrawArrays(PrimitiveType mode, int first, int count) => ((delegate* unmanaged<PrimitiveType, int, int, void>)EntryPoints[67])(mode, first, count);
        [UnmanagedCallersOnly]
        private static void DrawArrays_Lazy(PrimitiveType mode, int first, int count)
        {
            EntryPoints[67] = GLLoader.BindingsContext.GetProcAddress("glDrawArrays");
            ((delegate* unmanaged<PrimitiveType, int, int, void>)EntryPoints[67])(mode, first, count);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Render primitives from array data. </summary>
        /// <param name="mode">Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, and GL_TRIANGLES are accepted.</param>
        /// <param name="count">Specifies the number of elements to be rendered.</param>
        /// <param name="type">Specifies the type of the values in indices. Must be either GL_UNSIGNED_BYTE or GL_UNSIGNED_SHORT.</param>
        /// <param name="indices">Specifies a pointer to the location where the indices are stored.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glDrawElements.xml" /></remarks>
        public static void DrawElements(PrimitiveType mode, int count, DrawElementsType type, void* indices) => ((delegate* unmanaged<PrimitiveType, int, DrawElementsType, void*, void>)EntryPoints[68])(mode, count, type, indices);
        [UnmanagedCallersOnly]
        private static void DrawElements_Lazy(PrimitiveType mode, int count, DrawElementsType type, void* indices)
        {
            EntryPoints[68] = GLLoader.BindingsContext.GetProcAddress("glDrawElements");
            ((delegate* unmanaged<PrimitiveType, int, DrawElementsType, void*, void>)EntryPoints[68])(mode, count, type, indices);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Enable or disable server-side GL capabilities. </summary>
        /// <param name="cap">Specifies a symbolic constant indicating a GL capability.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glEnable.xml" /></remarks>
        public static void Enable(EnableCap cap) => ((delegate* unmanaged<EnableCap, void>)EntryPoints[69])(cap);
        [UnmanagedCallersOnly]
        private static void Enable_Lazy(EnableCap cap)
        {
            EntryPoints[69] = GLLoader.BindingsContext.GetProcAddress("glEnable");
            ((delegate* unmanaged<EnableCap, void>)EntryPoints[69])(cap);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Enable or disable client-side capability. </summary>
        /// <param name="array"> Specifies the capability to enable or disable. Symbolic constants GL_COLOR_ARRAY, GL_MATRIX_INDEX_ARRAY_OES, GL_NORMAL_ARRAY, GL_POINT_SIZE_ARRAY_OES, GL_TEXTURE_COORD_ARRAY, and GL_VERTEX_ARRAY, and GL_WEIGHT_ARRAY_OES are accepted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glEnableClientState.xml" /></remarks>
        public static void EnableClientState(EnableCap array) => ((delegate* unmanaged<EnableCap, void>)EntryPoints[70])(array);
        [UnmanagedCallersOnly]
        private static void EnableClientState_Lazy(EnableCap array)
        {
            EntryPoints[70] = GLLoader.BindingsContext.GetProcAddress("glEnableClientState");
            ((delegate* unmanaged<EnableCap, void>)EntryPoints[70])(array);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Block until all GL execution is complete. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glFinish.xml" /></remarks>
        public static void Finish() => ((delegate* unmanaged<void>)EntryPoints[71])();
        [UnmanagedCallersOnly]
        private static void Finish_Lazy()
        {
            EntryPoints[71] = GLLoader.BindingsContext.GetProcAddress("glFinish");
            ((delegate* unmanaged<void>)EntryPoints[71])();
        }
        
        /// <summary> <b>[requires: v1.0]</b> Force execution of GL commands in finite time. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glFlush.xml" /></remarks>
        public static void Flush() => ((delegate* unmanaged<void>)EntryPoints[72])();
        [UnmanagedCallersOnly]
        private static void Flush_Lazy()
        {
            EntryPoints[72] = GLLoader.BindingsContext.GetProcAddress("glFlush");
            ((delegate* unmanaged<void>)EntryPoints[72])();
        }
        
        /// <summary> <b>[requires: v1.0]</b> Specify fog parameters. </summary>
        /// <param name="pname">Specifies a single-valued fog parameter. GL_FOG_MODE, GL_FOG_DENSITY, GL_FOG_START, and GL_FOG_END are accepted.</param>
        /// <param name="param">Specifies the value that pname will be set to.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glFog.xml" /></remarks>
        public static void Fogx(FogPName pname, int param) => ((delegate* unmanaged<FogPName, int, void>)EntryPoints[73])(pname, param);
        [UnmanagedCallersOnly]
        private static void Fogx_Lazy(FogPName pname, int param)
        {
            EntryPoints[73] = GLLoader.BindingsContext.GetProcAddress("glFogx");
            ((delegate* unmanaged<FogPName, int, void>)EntryPoints[73])(pname, param);
        }
        
        public static void Fogxv(FogPName pname, int* param) => ((delegate* unmanaged<FogPName, int*, void>)EntryPoints[74])(pname, param);
        [UnmanagedCallersOnly]
        private static void Fogxv_Lazy(FogPName pname, int* param)
        {
            EntryPoints[74] = GLLoader.BindingsContext.GetProcAddress("glFogxv");
            ((delegate* unmanaged<FogPName, int*, void>)EntryPoints[74])(pname, param);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Define front- and back-facing polygons. </summary>
        /// <param name="mode">Specifies the orientation of front-facing polygons. GL_CW and GL_CCW are accepted. The initial value is GL_CCW.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glFrontFace.xml" /></remarks>
        public static void FrontFace(FrontFaceDirection mode) => ((delegate* unmanaged<FrontFaceDirection, void>)EntryPoints[75])(mode);
        [UnmanagedCallersOnly]
        private static void FrontFace_Lazy(FrontFaceDirection mode)
        {
            EntryPoints[75] = GLLoader.BindingsContext.GetProcAddress("glFrontFace");
            ((delegate* unmanaged<FrontFaceDirection, void>)EntryPoints[75])(mode);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Multiply the current matrix by a perspective matrix. </summary>
        /// <param name="left">Specify the coordinates for the left and right vertical clipping planes.</param>
        /// <param name="right">Specify the coordinates for the left and right vertical clipping planes.</param>
        /// <param name="bottom">Specify the coordinates for the bottom and top horizontal clipping planes.</param>
        /// <param name="top">Specify the coordinates for the bottom and top horizontal clipping planes.</param>
        /// <param name="near">Specify the distances to the near and far depth clipping planes. Both distances must be positive.</param>
        /// <param name="far">Specify the distances to the near and far depth clipping planes. Both distances must be positive.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glFrustum.xml" /></remarks>
        public static void Frustumx(int l, int r, int b, int t, int n, int f) => ((delegate* unmanaged<int, int, int, int, int, int, void>)EntryPoints[76])(l, r, b, t, n, f);
        [UnmanagedCallersOnly]
        private static void Frustumx_Lazy(int l, int r, int b, int t, int n, int f)
        {
            EntryPoints[76] = GLLoader.BindingsContext.GetProcAddress("glFrustumx");
            ((delegate* unmanaged<int, int, int, int, int, int, void>)EntryPoints[76])(l, r, b, t, n, f);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Return the value or values of a selected parameter. </summary>
        /// <param name="pname">Specifies the parameter value to be returned. The symbolic constants in the list below are accepted.</param>
        /// <param name="parameters">Returns the value or values of the specified parameter.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGet.xml" /></remarks>
        public static void GetBooleanv(GetPName pname, byte* data) => ((delegate* unmanaged<GetPName, byte*, void>)EntryPoints[77])(pname, data);
        [UnmanagedCallersOnly]
        private static void GetBooleanv_Lazy(GetPName pname, byte* data)
        {
            EntryPoints[77] = GLLoader.BindingsContext.GetProcAddress("glGetBooleanv");
            ((delegate* unmanaged<GetPName, byte*, void>)EntryPoints[77])(pname, data);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Return parameters of a buffer object. </summary>
        /// <param name="target"> Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER or GL_ELEMENT_ARRAY_BUFFER. </param>
        /// <param name="pname"> Specifies the symbolic name of a buffer object parameter. Accepted values are GL_BUFFER_SIZE or GL_BUFFER_USAGE. </param>
        /// <param name="parameters">Returns the requested parameter.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetBufferParameteriv.xml" /></remarks>
        public static void GetBufferParameteriv(BufferTargetARB target, BufferPNameARB pname, int* parameters) => ((delegate* unmanaged<BufferTargetARB, BufferPNameARB, int*, void>)EntryPoints[78])(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetBufferParameteriv_Lazy(BufferTargetARB target, BufferPNameARB pname, int* parameters)
        {
            EntryPoints[78] = GLLoader.BindingsContext.GetProcAddress("glGetBufferParameteriv");
            ((delegate* unmanaged<BufferTargetARB, BufferPNameARB, int*, void>)EntryPoints[78])(target, pname, parameters);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Return the coefficients of the specified clipping    plane. </summary>
        /// <param name="plane">Specifies a clipping plane. The number of clipping planes depends on the implementation, but at least six clipping planes are supported. Symbolic names of the form GL_CLIP_PLANE i, where i is an integer between 0 and GL_MAX_CLIP_PLANES -1 , are accepted.</param>
        /// <param name="equation">Returns four fixed-point or floating-point values that are the coefficients of the plane equation of plane in eye coordinates in the order p1, p2, p3, and p4. The initial value is (0, 0, 0, 0).</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetClipPlane.xml" /></remarks>
        public static void GetClipPlanex(ClipPlaneName plane, int* equation) => ((delegate* unmanaged<ClipPlaneName, int*, void>)EntryPoints[79])(plane, equation);
        [UnmanagedCallersOnly]
        private static void GetClipPlanex_Lazy(ClipPlaneName plane, int* equation)
        {
            EntryPoints[79] = GLLoader.BindingsContext.GetProcAddress("glGetClipPlanex");
            ((delegate* unmanaged<ClipPlaneName, int*, void>)EntryPoints[79])(plane, equation);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Generate buffer object names. </summary>
        /// <param name="n">Specifies the number of buffer object names to be generated.</param>
        /// <param name="buffers">Specifies an array in which the generated buffer object names are stored.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGenBuffers.xml" /></remarks>
        public static void GenBuffers(int n, BufferHandle* buffers) => ((delegate* unmanaged<int, BufferHandle*, void>)EntryPoints[80])(n, buffers);
        [UnmanagedCallersOnly]
        private static void GenBuffers_Lazy(int n, BufferHandle* buffers)
        {
            EntryPoints[80] = GLLoader.BindingsContext.GetProcAddress("glGenBuffers");
            ((delegate* unmanaged<int, BufferHandle*, void>)EntryPoints[80])(n, buffers);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Generate texture names. </summary>
        /// <param name="n">Specifies the number of texture names to be generated.</param>
        /// <param name="textures">Specifies an array in which the generated texture names are stored.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGenTextures.xml" /></remarks>
        public static void GenTextures(int n, TextureHandle* textures) => ((delegate* unmanaged<int, TextureHandle*, void>)EntryPoints[81])(n, textures);
        [UnmanagedCallersOnly]
        private static void GenTextures_Lazy(int n, TextureHandle* textures)
        {
            EntryPoints[81] = GLLoader.BindingsContext.GetProcAddress("glGenTextures");
            ((delegate* unmanaged<int, TextureHandle*, void>)EntryPoints[81])(n, textures);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Return error information. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetError.xml" /></remarks>
        public static ErrorCode GetError() => ((delegate* unmanaged<ErrorCode>)EntryPoints[82])();
        [UnmanagedCallersOnly]
        private static ErrorCode GetError_Lazy()
        {
            EntryPoints[82] = GLLoader.BindingsContext.GetProcAddress("glGetError");
            return ((delegate* unmanaged<ErrorCode>)EntryPoints[82])();
        }
        
        /// <summary> <b>[requires: v1.0]</b> Return the value or values of a selected parameter. </summary>
        /// <param name="pname">Specifies the parameter value to be returned. The symbolic constants in the list below are accepted.</param>
        /// <param name="parameters">Returns the value or values of the specified parameter.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGet.xml" /></remarks>
        public static void GetFixedv(GetPName pname, int* parameters) => ((delegate* unmanaged<GetPName, int*, void>)EntryPoints[83])(pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetFixedv_Lazy(GetPName pname, int* parameters)
        {
            EntryPoints[83] = GLLoader.BindingsContext.GetProcAddress("glGetFixedv");
            ((delegate* unmanaged<GetPName, int*, void>)EntryPoints[83])(pname, parameters);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Return the value or values of a selected parameter. </summary>
        /// <param name="pname">Specifies the parameter value to be returned. The symbolic constants in the list below are accepted.</param>
        /// <param name="parameters">Returns the value or values of the specified parameter.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGet.xml" /></remarks>
        public static void GetIntegerv(GetPName pname, int* data) => ((delegate* unmanaged<GetPName, int*, void>)EntryPoints[84])(pname, data);
        [UnmanagedCallersOnly]
        private static void GetIntegerv_Lazy(GetPName pname, int* data)
        {
            EntryPoints[84] = GLLoader.BindingsContext.GetProcAddress("glGetIntegerv");
            ((delegate* unmanaged<GetPName, int*, void>)EntryPoints[84])(pname, data);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Return light source parameter values. </summary>
        /// <param name="light"> Specifies a light source. The number of possible lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form GL_LIGHTi where 0<i< GL_MAX_LIGHTS </param>
        /// <param name="pname"> Specifies a light source parameter for light. Accepted symbolic names are GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_POSITION, GL_SPOT_DIRECTION, GL_SPOT_EXPONENT, GL_SPOT_CUTOFF, GL_CONSTANT_ATTENUATION, GL_LINEAR_ATTENUATION, and GL_QUADRATIC_ATTENUATION. </param>
        /// <param name="parameters"> Returns the requested data. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetLight.xml" /></remarks>
        public static void GetLightxv(LightName light, LightParameter pname, int* parameters) => ((delegate* unmanaged<LightName, LightParameter, int*, void>)EntryPoints[85])(light, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetLightxv_Lazy(LightName light, LightParameter pname, int* parameters)
        {
            EntryPoints[85] = GLLoader.BindingsContext.GetProcAddress("glGetLightxv");
            ((delegate* unmanaged<LightName, LightParameter, int*, void>)EntryPoints[85])(light, pname, parameters);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Return material parameters values. </summary>
        /// <param name="face"> Specifies which of the two materials is being queried. GL_FRONT or GL_BACK are accepted, representing the front and back materials, respectively. </param>
        /// <param name="pname"> Specifies the material parameter to return. Accepted symbolic names are GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_EMISSION, and GL_SHININESS. </param>
        /// <param name="parameters"> Returns the requested data. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetMaterial.xml" /></remarks>
        public static void GetMaterialxv(MaterialFace face, MaterialParameter pname, int* parameters) => ((delegate* unmanaged<MaterialFace, MaterialParameter, int*, void>)EntryPoints[86])(face, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetMaterialxv_Lazy(MaterialFace face, MaterialParameter pname, int* parameters)
        {
            EntryPoints[86] = GLLoader.BindingsContext.GetProcAddress("glGetMaterialxv");
            ((delegate* unmanaged<MaterialFace, MaterialParameter, int*, void>)EntryPoints[86])(face, pname, parameters);
        }
        
        /// <summary> <b>[requires: v1.0 | GL_KHR_debug]</b> Return the address of the specified pointer. </summary>
        /// <param name="pname"> Specifies the array or buffer pointer to be returned. Accepted symbolic names are GL_COLOR_ARRAY_POINTER, GL_MATRIX_INDEX_ARRAY_POINTER_OES, GL_NORMAL_ARRAY_POINTER, GL_POINT_SIZE_ARRAY_POINTER_OES, GL_TEXTURE_COORD_ARRAY_POINTER, and GL_VERTEX_ARRAY_POINTER., and GL_WEIGHT_ARRAY_POINTER_OES. </param>
        /// <param name="parameters"> Returns the pointer value specified by pname. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetPointerv.xml" /></remarks>
        public static void GetPointerv(GetPointervPName pname, void** parameters) => ((delegate* unmanaged<GetPointervPName, void**, void>)EntryPoints[87])(pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetPointerv_Lazy(GetPointervPName pname, void** parameters)
        {
            EntryPoints[87] = GLLoader.BindingsContext.GetProcAddress("glGetPointerv");
            ((delegate* unmanaged<GetPointervPName, void**, void>)EntryPoints[87])(pname, parameters);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Return a string describing the current GL        connection. </summary>
        /// <param name="name">Specifies a symbolic constant, one of GL_VENDOR, GL_RENDERER, GL_VERSION, or GL_EXTENSIONS.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetString.xml" /></remarks>
        public static byte* GetString_(StringName name) => ((delegate* unmanaged<StringName, byte*>)EntryPoints[88])(name);
        [UnmanagedCallersOnly]
        private static byte* GetString__Lazy(StringName name)
        {
            EntryPoints[88] = GLLoader.BindingsContext.GetProcAddress("glGetString");
            return ((delegate* unmanaged<StringName, byte*>)EntryPoints[88])(name);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Return texture environment parameters. </summary>
        /// <param name="target"> Specifies a texture environment. May be GL_TEXTURE_ENV or GL_POINT_SPRITE_OES. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture environment parameter. Accepted values are GL_TEXTURE_ENV_MODE, GL_TEXTURE_ENV_COLOR, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE_OES. </param>
        /// <param name="parameters"> Returns the requested data. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetTexEnv.xml" /></remarks>
        public static void GetTexEnviv(TextureEnvTarget target, TextureEnvParameter pname, int* parameters) => ((delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int*, void>)EntryPoints[89])(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetTexEnviv_Lazy(TextureEnvTarget target, TextureEnvParameter pname, int* parameters)
        {
            EntryPoints[89] = GLLoader.BindingsContext.GetProcAddress("glGetTexEnviv");
            ((delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int*, void>)EntryPoints[89])(target, pname, parameters);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Return texture environment parameters. </summary>
        /// <param name="target"> Specifies a texture environment. May be GL_TEXTURE_ENV or GL_POINT_SPRITE_OES. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture environment parameter. Accepted values are GL_TEXTURE_ENV_MODE, GL_TEXTURE_ENV_COLOR, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE_OES. </param>
        /// <param name="parameters"> Returns the requested data. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetTexEnv.xml" /></remarks>
        public static void GetTexEnvxv(TextureEnvTarget target, TextureEnvParameter pname, int* parameters) => ((delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int*, void>)EntryPoints[90])(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetTexEnvxv_Lazy(TextureEnvTarget target, TextureEnvParameter pname, int* parameters)
        {
            EntryPoints[90] = GLLoader.BindingsContext.GetProcAddress("glGetTexEnvxv");
            ((delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int*, void>)EntryPoints[90])(target, pname, parameters);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Return texture parameter values. </summary>
        /// <param name="target">Specifies the target texture, which must be GL_TEXTURE_2D.</param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. Which can be one of the following: GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_GENERATE_MIPMAP. </param>
        /// <param name="parameters">Returns texture parameters.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetTexParameter.xml" /></remarks>
        public static void GetTexParameteriv(TextureTarget target, GetTextureParameter pname, int* parameters) => ((delegate* unmanaged<TextureTarget, GetTextureParameter, int*, void>)EntryPoints[91])(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetTexParameteriv_Lazy(TextureTarget target, GetTextureParameter pname, int* parameters)
        {
            EntryPoints[91] = GLLoader.BindingsContext.GetProcAddress("glGetTexParameteriv");
            ((delegate* unmanaged<TextureTarget, GetTextureParameter, int*, void>)EntryPoints[91])(target, pname, parameters);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Return texture parameter values. </summary>
        /// <param name="target">Specifies the target texture, which must be GL_TEXTURE_2D.</param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. Which can be one of the following: GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_GENERATE_MIPMAP. </param>
        /// <param name="parameters">Returns texture parameters.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetTexParameter.xml" /></remarks>
        public static void GetTexParameterxv(TextureTarget target, GetTextureParameter pname, int* parameters) => ((delegate* unmanaged<TextureTarget, GetTextureParameter, int*, void>)EntryPoints[92])(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetTexParameterxv_Lazy(TextureTarget target, GetTextureParameter pname, int* parameters)
        {
            EntryPoints[92] = GLLoader.BindingsContext.GetProcAddress("glGetTexParameterxv");
            ((delegate* unmanaged<TextureTarget, GetTextureParameter, int*, void>)EntryPoints[92])(target, pname, parameters);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Specify implementation-specific hints. </summary>
        /// <param name="target">Specifies a symbolic constant indicating the behavior to be controlled. GL_FOG_HINT , GL_GENERATE_MIPMAP_HINT , GL_LINE_SMOOTH_HINT , GL_PERSPECTIVE_CORRECTION_HINT, and GL_POINT_SMOOTH_HINT are accepted.</param>
        /// <param name="mode">Specifies a symbolic constant indicating the desired behavior. GL_FASTEST, GL_NICEST, and GL_DONT_CARE are accepted.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glHint.xml" /></remarks>
        public static void Hint(HintTarget target, HintMode mode) => ((delegate* unmanaged<HintTarget, HintMode, void>)EntryPoints[93])(target, mode);
        [UnmanagedCallersOnly]
        private static void Hint_Lazy(HintTarget target, HintMode mode)
        {
            EntryPoints[93] = GLLoader.BindingsContext.GetProcAddress("glHint");
            ((delegate* unmanaged<HintTarget, HintMode, void>)EntryPoints[93])(target, mode);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Determine if a name corresponds to a buffer object. </summary>
        /// <param name="buffer"> Specifies a value that may be the name of a buffer object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glIsBuffer.xml" /></remarks>
        public static byte IsBuffer(BufferHandle buffer) => ((delegate* unmanaged<BufferHandle, byte>)EntryPoints[94])(buffer);
        [UnmanagedCallersOnly]
        private static byte IsBuffer_Lazy(BufferHandle buffer)
        {
            EntryPoints[94] = GLLoader.BindingsContext.GetProcAddress("glIsBuffer");
            return ((delegate* unmanaged<BufferHandle, byte>)EntryPoints[94])(buffer);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Test whether a capability is enabled. </summary>
        /// <param name="cap"> Specifies a symbolic constant indicating a GL capability. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glIsEnabled.xml" /></remarks>
        public static byte IsEnabled(EnableCap cap) => ((delegate* unmanaged<EnableCap, byte>)EntryPoints[95])(cap);
        [UnmanagedCallersOnly]
        private static byte IsEnabled_Lazy(EnableCap cap)
        {
            EntryPoints[95] = GLLoader.BindingsContext.GetProcAddress("glIsEnabled");
            return ((delegate* unmanaged<EnableCap, byte>)EntryPoints[95])(cap);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Determine if a name corresponds to a texture. </summary>
        /// <param name="texture"> Specifies a value that may be the name of a texture. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glIsTexture.xml" /></remarks>
        public static byte IsTexture(TextureHandle texture) => ((delegate* unmanaged<TextureHandle, byte>)EntryPoints[96])(texture);
        [UnmanagedCallersOnly]
        private static byte IsTexture_Lazy(TextureHandle texture)
        {
            EntryPoints[96] = GLLoader.BindingsContext.GetProcAddress("glIsTexture");
            return ((delegate* unmanaged<TextureHandle, byte>)EntryPoints[96])(texture);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Set the lighting model parameters. </summary>
        /// <param name="pname">Specifies a single-valued lighting model parameter. Must be GL_LIGHT_MODEL_TWO_SIDE.</param>
        /// <param name="param">Specifies the value that param will be set to.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glLightModel.xml" /></remarks>
        public static void LightModelx(LightModelParameter pname, int param) => ((delegate* unmanaged<LightModelParameter, int, void>)EntryPoints[97])(pname, param);
        [UnmanagedCallersOnly]
        private static void LightModelx_Lazy(LightModelParameter pname, int param)
        {
            EntryPoints[97] = GLLoader.BindingsContext.GetProcAddress("glLightModelx");
            ((delegate* unmanaged<LightModelParameter, int, void>)EntryPoints[97])(pname, param);
        }
        
        public static void LightModelxv(LightModelParameter pname, int* param) => ((delegate* unmanaged<LightModelParameter, int*, void>)EntryPoints[98])(pname, param);
        [UnmanagedCallersOnly]
        private static void LightModelxv_Lazy(LightModelParameter pname, int* param)
        {
            EntryPoints[98] = GLLoader.BindingsContext.GetProcAddress("glLightModelxv");
            ((delegate* unmanaged<LightModelParameter, int*, void>)EntryPoints[98])(pname, param);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Set light source parameters. </summary>
        /// <param name="light">Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form GL_LIGHTi where 0 <= i < GL_MAX_LIGHTS . </param>
        /// <param name="pname">Specifies a single-valued light source parameter for light. GL_SPOT_EXPONENT, GL_SPOT_CUTOFF, GL_CONSTANT_ATTENUATION, GL_LINEAR_ATTENUATION, and GL_QUADRATIC_ATTENUATION are accepted.</param>
        /// <param name="param">Specifies the value that parameter pname of light source light will be set to.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glLight.xml" /></remarks>
        public static void Lightx(LightName light, LightParameter pname, int param) => ((delegate* unmanaged<LightName, LightParameter, int, void>)EntryPoints[99])(light, pname, param);
        [UnmanagedCallersOnly]
        private static void Lightx_Lazy(LightName light, LightParameter pname, int param)
        {
            EntryPoints[99] = GLLoader.BindingsContext.GetProcAddress("glLightx");
            ((delegate* unmanaged<LightName, LightParameter, int, void>)EntryPoints[99])(light, pname, param);
        }
        
        public static void Lightxv(LightName light, LightParameter pname, int* parameters) => ((delegate* unmanaged<LightName, LightParameter, int*, void>)EntryPoints[100])(light, pname, parameters);
        [UnmanagedCallersOnly]
        private static void Lightxv_Lazy(LightName light, LightParameter pname, int* parameters)
        {
            EntryPoints[100] = GLLoader.BindingsContext.GetProcAddress("glLightxv");
            ((delegate* unmanaged<LightName, LightParameter, int*, void>)EntryPoints[100])(light, pname, parameters);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Specify the width of rasterized lines. </summary>
        /// <param name="width">Specifies the width of rasterized lines. The initial value is 1.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glLineWidth.xml" /></remarks>
        public static void LineWidthx(int width) => ((delegate* unmanaged<int, void>)EntryPoints[101])(width);
        [UnmanagedCallersOnly]
        private static void LineWidthx_Lazy(int width)
        {
            EntryPoints[101] = GLLoader.BindingsContext.GetProcAddress("glLineWidthx");
            ((delegate* unmanaged<int, void>)EntryPoints[101])(width);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Replace the current matrix with the identitymatrix. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glLoadIdentity.xml" /></remarks>
        public static void LoadIdentity() => ((delegate* unmanaged<void>)EntryPoints[102])();
        [UnmanagedCallersOnly]
        private static void LoadIdentity_Lazy()
        {
            EntryPoints[102] = GLLoader.BindingsContext.GetProcAddress("glLoadIdentity");
            ((delegate* unmanaged<void>)EntryPoints[102])();
        }
        
        /// <summary> <b>[requires: v1.0]</b> Replace the current matrix with the specifiedmatrix. </summary>
        /// <param name="m">Specifies a pointer to 16 consecutive values, which are used as the elements of a 4x4 column-major matrix.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glLoadMatrix.xml" /></remarks>
        public static void LoadMatrixx(int* m) => ((delegate* unmanaged<int*, void>)EntryPoints[103])(m);
        [UnmanagedCallersOnly]
        private static void LoadMatrixx_Lazy(int* m)
        {
            EntryPoints[103] = GLLoader.BindingsContext.GetProcAddress("glLoadMatrixx");
            ((delegate* unmanaged<int*, void>)EntryPoints[103])(m);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Specify a logical pixel operation. </summary>
        /// <param name="opcode">Specifies a symbolic constant that selects a logical operation. The following symbols are accepted: GL_CLEAR, GL_SET, GL_COPY, GL_COPY_INVERTED, GL_NOOP, GL_INVERT, GL_AND, GL_NAND, GL_OR, GL_NOR, GL_XOR, GL_EQUIV, GL_AND_REVERSE, GL_AND_INVERTED, GL_OR_REVERSE, and GL_OR_INVERTED. The initial value is GL_COPY.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glLogicOp.xml" /></remarks>
        public static void LogicOp(LogicOp opcode) => ((delegate* unmanaged<LogicOp, void>)EntryPoints[104])(opcode);
        [UnmanagedCallersOnly]
        private static void LogicOp_Lazy(LogicOp opcode)
        {
            EntryPoints[104] = GLLoader.BindingsContext.GetProcAddress("glLogicOp");
            ((delegate* unmanaged<LogicOp, void>)EntryPoints[104])(opcode);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Specify material parameters for the lighting model. </summary>
        /// <param name="face">Specifies which face or faces are being updated. Must be GL_FRONT_AND_BACK.</param>
        /// <param name="pname">Specifies the single-valued material parameter of the face or faces that is being updated. Must be GL_SHININESS.</param>
        /// <param name="param">Specifies the value that parameter GL_SHININESS will be set to.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glMaterial.xml" /></remarks>
        public static void Materialx(MaterialFace face, MaterialParameter pname, int param) => ((delegate* unmanaged<MaterialFace, MaterialParameter, int, void>)EntryPoints[105])(face, pname, param);
        [UnmanagedCallersOnly]
        private static void Materialx_Lazy(MaterialFace face, MaterialParameter pname, int param)
        {
            EntryPoints[105] = GLLoader.BindingsContext.GetProcAddress("glMaterialx");
            ((delegate* unmanaged<MaterialFace, MaterialParameter, int, void>)EntryPoints[105])(face, pname, param);
        }
        
        public static void Materialxv(MaterialFace face, MaterialParameter pname, int* param) => ((delegate* unmanaged<MaterialFace, MaterialParameter, int*, void>)EntryPoints[106])(face, pname, param);
        [UnmanagedCallersOnly]
        private static void Materialxv_Lazy(MaterialFace face, MaterialParameter pname, int* param)
        {
            EntryPoints[106] = GLLoader.BindingsContext.GetProcAddress("glMaterialxv");
            ((delegate* unmanaged<MaterialFace, MaterialParameter, int*, void>)EntryPoints[106])(face, pname, param);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Specify which matrix is the current matrix. </summary>
        /// <param name="mode"> Specifies which matrix stack is the target for subsequent matrix operations. These values are accepted: GL_MODELVIEW, GL_PROJECTION, and GL_TEXTURE., and GL_MATRIX_PALETTE_OES. The initial value is GL_MODELVIEW. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glMatrixMode.xml" /></remarks>
        public static void MatrixMode(MatrixMode mode) => ((delegate* unmanaged<MatrixMode, void>)EntryPoints[107])(mode);
        [UnmanagedCallersOnly]
        private static void MatrixMode_Lazy(MatrixMode mode)
        {
            EntryPoints[107] = GLLoader.BindingsContext.GetProcAddress("glMatrixMode");
            ((delegate* unmanaged<MatrixMode, void>)EntryPoints[107])(mode);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Multiply the current matrix with the specifiedmatrix. </summary>
        /// <param name="m">Points to 16 consecutive values that are used as the elements of a 4x4 column-major matrix.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glMultMatrix.xml" /></remarks>
        public static void MultMatrixx(int* m) => ((delegate* unmanaged<int*, void>)EntryPoints[108])(m);
        [UnmanagedCallersOnly]
        private static void MultMatrixx_Lazy(int* m)
        {
            EntryPoints[108] = GLLoader.BindingsContext.GetProcAddress("glMultMatrixx");
            ((delegate* unmanaged<int*, void>)EntryPoints[108])(m);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Set the current texture coordinates. </summary>
        /// <param name="target">Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least twoone. Symbolic constant must be one of GL_TEXTUREi, where i ranges from 0 to GL_MAX_TEXTURE_UNITS - 1, which is an implementation-dependent value.</param>
        /// <param name="s">Specify s, t, r, and q texture coordinates for target texture unit.</param>
        /// <param name="t">Specify s, t, r, and q texture coordinates for target texture unit.</param>
        /// <param name="r">Specify s, t, r, and q texture coordinates for target texture unit.</param>
        /// <param name="q">Specify s, t, r, and q texture coordinates for target texture unit.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glMultiTexCoord.xml" /></remarks>
        public static void MultiTexCoord4x(TextureUnit texture, int s, int t, int r, int q) => ((delegate* unmanaged<TextureUnit, int, int, int, int, void>)EntryPoints[109])(texture, s, t, r, q);
        [UnmanagedCallersOnly]
        private static void MultiTexCoord4x_Lazy(TextureUnit texture, int s, int t, int r, int q)
        {
            EntryPoints[109] = GLLoader.BindingsContext.GetProcAddress("glMultiTexCoord4x");
            ((delegate* unmanaged<TextureUnit, int, int, int, int, void>)EntryPoints[109])(texture, s, t, r, q);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Set the current normal vector. </summary>
        /// <param name="nx">Specify the x, y, and z coordinates of the new current normal. The initial value is (0, 0, 1).</param>
        /// <param name="ny">Specify the x, y, and z coordinates of the new current normal. The initial value is (0, 0, 1).</param>
        /// <param name="nz">Specify the x, y, and z coordinates of the new current normal. The initial value is (0, 0, 1).</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glNormal.xml" /></remarks>
        public static void Normal3x(int nx, int ny, int nz) => ((delegate* unmanaged<int, int, int, void>)EntryPoints[110])(nx, ny, nz);
        [UnmanagedCallersOnly]
        private static void Normal3x_Lazy(int nx, int ny, int nz)
        {
            EntryPoints[110] = GLLoader.BindingsContext.GetProcAddress("glNormal3x");
            ((delegate* unmanaged<int, int, int, void>)EntryPoints[110])(nx, ny, nz);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Define an array of normals. </summary>
        /// <param name="type">Specifies the data type of each coordinate in the array. Symbolic constants GL_BYTE, GL_SHORT, and GL_FIXED are accepted. However, the initial value is GL_FLOAT.</param>
        /// <param name="stride">Specifies the byte offset between consecutive normals. If stride is 0, the normals are understood to be tightly packed in the array. The initial value is 0.</param>
        /// <param name="pointer">Specifies a pointer to the first coordinate of the first normal in the array. The initial value is 0.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glNormalPointer.xml" /></remarks>
        public static void NormalPointer(NormalPointerType type, int stride, void* pointer) => ((delegate* unmanaged<NormalPointerType, int, void*, void>)EntryPoints[111])(type, stride, pointer);
        [UnmanagedCallersOnly]
        private static void NormalPointer_Lazy(NormalPointerType type, int stride, void* pointer)
        {
            EntryPoints[111] = GLLoader.BindingsContext.GetProcAddress("glNormalPointer");
            ((delegate* unmanaged<NormalPointerType, int, void*, void>)EntryPoints[111])(type, stride, pointer);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Multiply the current matrix with an orthographicmatrix. </summary>
        /// <param name="left">Specify the coordinates for the left and right vertical clipping planes.</param>
        /// <param name="right">Specify the coordinates for the left and right vertical clipping planes.</param>
        /// <param name="bottom">Specify the coordinates for the bottom and top horizontal clipping planes.</param>
        /// <param name="top">Specify the coordinates for the bottom and top horizontal clipping planes.</param>
        /// <param name="near">Specify the distances to the nearer and farther depth clipping planes. These values are negative if the plane is to be behind the viewer.</param>
        /// <param name="far">Specify the distances to the nearer and farther depth clipping planes. These values are negative if the plane is to be behind the viewer.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glOrtho.xml" /></remarks>
        public static void Orthox(int l, int r, int b, int t, int n, int f) => ((delegate* unmanaged<int, int, int, int, int, int, void>)EntryPoints[112])(l, r, b, t, n, f);
        [UnmanagedCallersOnly]
        private static void Orthox_Lazy(int l, int r, int b, int t, int n, int f)
        {
            EntryPoints[112] = GLLoader.BindingsContext.GetProcAddress("glOrthox");
            ((delegate* unmanaged<int, int, int, int, int, int, void>)EntryPoints[112])(l, r, b, t, n, f);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Set pixel storage modes. </summary>
        /// <param name="pname">Specifies the symbolic name of the parameter to be set. GL_PACK_ALIGNMENT affects the packing of pixel data into memory. GL_UNPACK_ALIGNMENT affects the unpacking of pixel data from memory.</param>
        /// <param name="param">Specifies the value that pname is set to.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glPixelStorei.xml" /></remarks>
        public static void PixelStorei(PixelStoreParameter pname, int param) => ((delegate* unmanaged<PixelStoreParameter, int, void>)EntryPoints[113])(pname, param);
        [UnmanagedCallersOnly]
        private static void PixelStorei_Lazy(PixelStoreParameter pname, int param)
        {
            EntryPoints[113] = GLLoader.BindingsContext.GetProcAddress("glPixelStorei");
            ((delegate* unmanaged<PixelStoreParameter, int, void>)EntryPoints[113])(pname, param);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Specify parameters for point rasterization. </summary>
        /// <param name="pname"> Specifies the single-valued parameter to be updated. Can be either GL_POINT_SIZE_MIN, GL_POINT_SIZE_MAX, or GL_POINT_FADE_THRESHOLD_SIZE. </param>
        /// <param name="param"> Specifies the value that the parameter will be set to. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glPointParameter.xml" /></remarks>
        public static void PointParameterx(PointParameterNameARB pname, int param) => ((delegate* unmanaged<PointParameterNameARB, int, void>)EntryPoints[114])(pname, param);
        [UnmanagedCallersOnly]
        private static void PointParameterx_Lazy(PointParameterNameARB pname, int param)
        {
            EntryPoints[114] = GLLoader.BindingsContext.GetProcAddress("glPointParameterx");
            ((delegate* unmanaged<PointParameterNameARB, int, void>)EntryPoints[114])(pname, param);
        }
        
        public static void PointParameterxv(PointParameterNameARB pname, int* parameters) => ((delegate* unmanaged<PointParameterNameARB, int*, void>)EntryPoints[115])(pname, parameters);
        [UnmanagedCallersOnly]
        private static void PointParameterxv_Lazy(PointParameterNameARB pname, int* parameters)
        {
            EntryPoints[115] = GLLoader.BindingsContext.GetProcAddress("glPointParameterxv");
            ((delegate* unmanaged<PointParameterNameARB, int*, void>)EntryPoints[115])(pname, parameters);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Specify the diameter of rasterized points. </summary>
        /// <param name="size">Specifies the diameter of rasterized points. The initial value is 1.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glPointSize.xml" /></remarks>
        public static void PointSizex(int size) => ((delegate* unmanaged<int, void>)EntryPoints[116])(size);
        [UnmanagedCallersOnly]
        private static void PointSizex_Lazy(int size)
        {
            EntryPoints[116] = GLLoader.BindingsContext.GetProcAddress("glPointSizex");
            ((delegate* unmanaged<int, void>)EntryPoints[116])(size);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Set the scale and units used to calculate depth        values. </summary>
        /// <param name="factor">Specifies a scale factor that is used to create a variable depth offset for each polygon. The initial value is 0.</param>
        /// <param name="units">Is multiplied by an implementation-specific value to create a constant depth offset. The initial value is 0.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glPolygonOffset.xml" /></remarks>
        public static void PolygonOffsetx(int factor, int units) => ((delegate* unmanaged<int, int, void>)EntryPoints[117])(factor, units);
        [UnmanagedCallersOnly]
        private static void PolygonOffsetx_Lazy(int factor, int units)
        {
            EntryPoints[117] = GLLoader.BindingsContext.GetProcAddress("glPolygonOffsetx");
            ((delegate* unmanaged<int, int, void>)EntryPoints[117])(factor, units);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Push and pop the current matrix stack. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glPushMatrix.xml" /></remarks>
        public static void PopMatrix() => ((delegate* unmanaged<void>)EntryPoints[118])();
        [UnmanagedCallersOnly]
        private static void PopMatrix_Lazy()
        {
            EntryPoints[118] = GLLoader.BindingsContext.GetProcAddress("glPopMatrix");
            ((delegate* unmanaged<void>)EntryPoints[118])();
        }
        
        /// <summary> <b>[requires: v1.0]</b> Push and pop the current matrix stack. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glPushMatrix.xml" /></remarks>
        public static void PushMatrix() => ((delegate* unmanaged<void>)EntryPoints[119])();
        [UnmanagedCallersOnly]
        private static void PushMatrix_Lazy()
        {
            EntryPoints[119] = GLLoader.BindingsContext.GetProcAddress("glPushMatrix");
            ((delegate* unmanaged<void>)EntryPoints[119])();
        }
        
        /// <summary> <b>[requires: v1.0]</b> Read a block of pixels from the color buffer. </summary>
        /// <param name="x">Specify the window coordinates of the first pixel that is read from the color buffer. This location is the lower left corner of a rectangular block of pixels.</param>
        /// <param name="y">Specify the window coordinates of the first pixel that is read from the color buffer. This location is the lower left corner of a rectangular block of pixels.</param>
        /// <param name="width">Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.</param>
        /// <param name="height">Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.</param>
        /// <param name="format">Specifies the format of the pixel data. Must be either GL_RGBA or the value of GL_IMPLEMENTATION_COLOR_READ_FORMAT_OES.</param>
        /// <param name="type">Specifies the data type of the pixel data. Must be either GL_UNSIGNED_BYTE or the value of GL_IMPLEMENTATION_COLOR_READ_TYPE_OES.</param>
        /// <param name="pixels">Returns the pixel data.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glReadPixels.xml" /></remarks>
        public static void ReadPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, void* pixels) => ((delegate* unmanaged<int, int, int, int, PixelFormat, PixelType, void*, void>)EntryPoints[120])(x, y, width, height, format, type, pixels);
        [UnmanagedCallersOnly]
        private static void ReadPixels_Lazy(int x, int y, int width, int height, PixelFormat format, PixelType type, void* pixels)
        {
            EntryPoints[120] = GLLoader.BindingsContext.GetProcAddress("glReadPixels");
            ((delegate* unmanaged<int, int, int, int, PixelFormat, PixelType, void*, void>)EntryPoints[120])(x, y, width, height, format, type, pixels);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Multiply the current matrix by a rotation matrix. </summary>
        /// <param name="angle">Specifies the angle of rotation, in degrees.</param>
        /// <param name="x">Specify the x, y, and z coordinates of a vector, respectively.</param>
        /// <param name="y">Specify the x, y, and z coordinates of a vector, respectively.</param>
        /// <param name="z">Specify the x, y, and z coordinates of a vector, respectively.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glRotate.xml" /></remarks>
        public static void Rotatex(int angle, int x, int y, int z) => ((delegate* unmanaged<int, int, int, int, void>)EntryPoints[121])(angle, x, y, z);
        [UnmanagedCallersOnly]
        private static void Rotatex_Lazy(int angle, int x, int y, int z)
        {
            EntryPoints[121] = GLLoader.BindingsContext.GetProcAddress("glRotatex");
            ((delegate* unmanaged<int, int, int, int, void>)EntryPoints[121])(angle, x, y, z);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Specify mask to modify multisampled pixel fragments. </summary>
        /// <param name="value">Specifies the coverage of the modification mask. The value is clamped to the range [0, 1], where 0 represents no coverage and 1 full coverage. The initial value is 1.</param>
        /// <param name="invert">Specifies whether the modification mask implied by value is inverted or not. The initial value is GL_FALSE. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glSampleCoverage.xml" /></remarks>
        public static void SampleCoverage(float value, byte invert) => ((delegate* unmanaged<float, byte, void>)EntryPoints[122])(value, invert);
        [UnmanagedCallersOnly]
        private static void SampleCoverage_Lazy(float value, byte invert)
        {
            EntryPoints[122] = GLLoader.BindingsContext.GetProcAddress("glSampleCoverage");
            ((delegate* unmanaged<float, byte, void>)EntryPoints[122])(value, invert);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Specify mask to modify multisampled pixel fragments. </summary>
        /// <param name="value">Specifies the coverage of the modification mask. The value is clamped to the range [0, 1], where 0 represents no coverage and 1 full coverage. The initial value is 1.</param>
        /// <param name="invert">Specifies whether the modification mask implied by value is inverted or not. The initial value is GL_FALSE. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glSampleCoverage.xml" /></remarks>
        public static void SampleCoveragex(int value, byte invert) => ((delegate* unmanaged<int, byte, void>)EntryPoints[123])(value, invert);
        [UnmanagedCallersOnly]
        private static void SampleCoveragex_Lazy(int value, byte invert)
        {
            EntryPoints[123] = GLLoader.BindingsContext.GetProcAddress("glSampleCoveragex");
            ((delegate* unmanaged<int, byte, void>)EntryPoints[123])(value, invert);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Multiply the current matrix by a general scalingmatrix. </summary>
        /// <param name="x">Specify scale factors along the x, y, and z axes, respectively.</param>
        /// <param name="y">Specify scale factors along the x, y, and z axes, respectively.</param>
        /// <param name="z">Specify scale factors along the x, y, and z axes, respectively.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glScale.xml" /></remarks>
        public static void Scalex(int x, int y, int z) => ((delegate* unmanaged<int, int, int, void>)EntryPoints[124])(x, y, z);
        [UnmanagedCallersOnly]
        private static void Scalex_Lazy(int x, int y, int z)
        {
            EntryPoints[124] = GLLoader.BindingsContext.GetProcAddress("glScalex");
            ((delegate* unmanaged<int, int, int, void>)EntryPoints[124])(x, y, z);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Define the scissor box. </summary>
        /// <param name="x">Specify the lower left corner of the scissor box, in pixels. The initial value is (0, 0).</param>
        /// <param name="y">Specify the lower left corner of the scissor box, in pixels. The initial value is (0, 0).</param>
        /// <param name="width">Specify the width and height of the scissor box. When a GL context is first attached to a surface (e.g. window), width and height are set to the dimensions of that surface.</param>
        /// <param name="height">Specify the width and height of the scissor box. When a GL context is first attached to a surface (e.g. window), width and height are set to the dimensions of that surface.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glScissor.xml" /></remarks>
        public static void Scissor(int x, int y, int width, int height) => ((delegate* unmanaged<int, int, int, int, void>)EntryPoints[125])(x, y, width, height);
        [UnmanagedCallersOnly]
        private static void Scissor_Lazy(int x, int y, int width, int height)
        {
            EntryPoints[125] = GLLoader.BindingsContext.GetProcAddress("glScissor");
            ((delegate* unmanaged<int, int, int, int, void>)EntryPoints[125])(x, y, width, height);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Select flat or smooth shading. </summary>
        /// <param name="mode">Specifies a symbolic value representing a shading technique. Accepted values are GL_FLAT and GL_SMOOTH. The initial value is GL_SMOOTH.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glShadeModel.xml" /></remarks>
        public static void ShadeModel(ShadingModel mode) => ((delegate* unmanaged<ShadingModel, void>)EntryPoints[126])(mode);
        [UnmanagedCallersOnly]
        private static void ShadeModel_Lazy(ShadingModel mode)
        {
            EntryPoints[126] = GLLoader.BindingsContext.GetProcAddress("glShadeModel");
            ((delegate* unmanaged<ShadingModel, void>)EntryPoints[126])(mode);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Set function and reference value for stencil        testing. </summary>
        /// <param name="func">Specifies the test function. Eight tokens are valid: GL_NEVER, GL_LESS, GL_LEQUAL, GL_GREATER, GL_GEQUAL, GL_EQUAL, GL_NOTEQUAL, and GL_ALWAYS. The initial value is GL_ALWAYS.</param>
        /// <param name="reference">Specifies the reference value for the stencil test. ref is clamped to the range [ 0 , 2n-1 ] , where n is the number of bitplanes in the stencil buffer. The initial value is 0.</param>
        /// <param name="mask">Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The initial value is all 1's.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glStencilFunc.xml" /></remarks>
        public static void StencilFunc(StencilFunction func, int reference, uint mask) => ((delegate* unmanaged<StencilFunction, int, uint, void>)EntryPoints[127])(func, reference, mask);
        [UnmanagedCallersOnly]
        private static void StencilFunc_Lazy(StencilFunction func, int reference, uint mask)
        {
            EntryPoints[127] = GLLoader.BindingsContext.GetProcAddress("glStencilFunc");
            ((delegate* unmanaged<StencilFunction, int, uint, void>)EntryPoints[127])(func, reference, mask);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Control the writing of individual bits in the        stencil planes. </summary>
        /// <param name="mask">Specifies a bit mask to enable and disable writing of individual bits in the stencil planes. The initial value is all 1's.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glStencilMask.xml" /></remarks>
        public static void StencilMask(uint mask) => ((delegate* unmanaged<uint, void>)EntryPoints[128])(mask);
        [UnmanagedCallersOnly]
        private static void StencilMask_Lazy(uint mask)
        {
            EntryPoints[128] = GLLoader.BindingsContext.GetProcAddress("glStencilMask");
            ((delegate* unmanaged<uint, void>)EntryPoints[128])(mask);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Set stencil test actions. </summary>
        /// <param name="fail">Specifies the action to take when the stencil test fails. Six symbolic constants are accepted: GL_KEEP, GL_ZERO, GL_REPLACE, GL_INCR, GL_DECR, and GL_INVERT. The initial value is GL_KEEP.</param>
        /// <param name="zfail">Specifies the stencil action when the stencil test passes, but the depth test fails. zfail accepts the same symbolic constants as fail. The initial value is GL_KEEP.</param>
        /// <param name="zpass">Specifies the stencil action when both the stencil test and the depth test pass, or when the stencil test passes and either there is no depth buffer or depth testing is not enabled. zpass accepts the same symbolic constants as fail. The initial value is GL_KEEP.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glStencilOp.xml" /></remarks>
        public static void StencilOp(StencilOp fail, StencilOp zfail, StencilOp zpass) => ((delegate* unmanaged<StencilOp, StencilOp, StencilOp, void>)EntryPoints[129])(fail, zfail, zpass);
        [UnmanagedCallersOnly]
        private static void StencilOp_Lazy(StencilOp fail, StencilOp zfail, StencilOp zpass)
        {
            EntryPoints[129] = GLLoader.BindingsContext.GetProcAddress("glStencilOp");
            ((delegate* unmanaged<StencilOp, StencilOp, StencilOp, void>)EntryPoints[129])(fail, zfail, zpass);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Define an array of texture coordinates. </summary>
        /// <param name="size">Specifies the number of coordinates per array element. Must be 2, 3 or 4. The initial value is 4.</param>
        /// <param name="type">Specifies the data type of each texture coordinate. Symbolic constants GL_BYTE, GL_SHORT, and GL_FIXED are accepted. However, the initial value is GL_FLOAT.</param>
        /// <param name="stride">Specifies the byte offset between consecutive array elements. If stride is 0, the array elements are understood to be tightly packed. The initial value is 0.</param>
        /// <param name="pointer">Specifies a pointer to the first coordinate of the first element in the array. The initial value is 0.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glTexCoordPointer.xml" /></remarks>
        public static void TexCoordPointer(int size, TexCoordPointerType type, int stride, void* pointer) => ((delegate* unmanaged<int, TexCoordPointerType, int, void*, void>)EntryPoints[130])(size, type, stride, pointer);
        [UnmanagedCallersOnly]
        private static void TexCoordPointer_Lazy(int size, TexCoordPointerType type, int stride, void* pointer)
        {
            EntryPoints[130] = GLLoader.BindingsContext.GetProcAddress("glTexCoordPointer");
            ((delegate* unmanaged<int, TexCoordPointerType, int, void*, void>)EntryPoints[130])(size, type, stride, pointer);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Set texture environment parameters. </summary>
        /// <param name="target"> Specifies a texture environment. May be GL_TEXTURE_ENV or GL_POINT_SPRITE_OES. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture environment parameter. May be either GL_TEXTURE_ENV_MODE, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE_OES. </param>
        /// <param name="param"> Specifies a single symbolic constant, one of GL_ADD, GL_ADD_SIGNED, GL_DOT3_RGB, GL_DOT3_RGBA, GL_INTERPOLATE, GL_MODULATE, GL_DECAL, GL_BLEND, GL_REPLACE, GL_SUBTRACT, GL_COMBINE, GL_TEXTURE, GL_CONSTANT, GL_PRIMARY_COLOR, GL_PREVIOUS, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, a single boolean value for the point sprite texture coordinate replacement, or 1.0, 2.0, or 4.0 when specifying the GL_RGB_SCALE or GL_ALPHA_SCALE. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glTexEnv.xml" /></remarks>
        public static void TexEnvi(TextureEnvTarget target, TextureEnvParameter pname, int param) => ((delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int, void>)EntryPoints[131])(target, pname, param);
        [UnmanagedCallersOnly]
        private static void TexEnvi_Lazy(TextureEnvTarget target, TextureEnvParameter pname, int param)
        {
            EntryPoints[131] = GLLoader.BindingsContext.GetProcAddress("glTexEnvi");
            ((delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int, void>)EntryPoints[131])(target, pname, param);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Set texture environment parameters. </summary>
        /// <param name="target"> Specifies a texture environment. May be GL_TEXTURE_ENV or GL_POINT_SPRITE_OES. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture environment parameter. May be either GL_TEXTURE_ENV_MODE, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE_OES. </param>
        /// <param name="param"> Specifies a single symbolic constant, one of GL_ADD, GL_ADD_SIGNED, GL_DOT3_RGB, GL_DOT3_RGBA, GL_INTERPOLATE, GL_MODULATE, GL_DECAL, GL_BLEND, GL_REPLACE, GL_SUBTRACT, GL_COMBINE, GL_TEXTURE, GL_CONSTANT, GL_PRIMARY_COLOR, GL_PREVIOUS, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, a single boolean value for the point sprite texture coordinate replacement, or 1.0, 2.0, or 4.0 when specifying the GL_RGB_SCALE or GL_ALPHA_SCALE. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glTexEnv.xml" /></remarks>
        public static void TexEnvx(TextureEnvTarget target, TextureEnvParameter pname, int param) => ((delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int, void>)EntryPoints[132])(target, pname, param);
        [UnmanagedCallersOnly]
        private static void TexEnvx_Lazy(TextureEnvTarget target, TextureEnvParameter pname, int param)
        {
            EntryPoints[132] = GLLoader.BindingsContext.GetProcAddress("glTexEnvx");
            ((delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int, void>)EntryPoints[132])(target, pname, param);
        }
        
        public static void TexEnviv(TextureEnvTarget target, TextureEnvParameter pname, int* parameters) => ((delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int*, void>)EntryPoints[133])(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void TexEnviv_Lazy(TextureEnvTarget target, TextureEnvParameter pname, int* parameters)
        {
            EntryPoints[133] = GLLoader.BindingsContext.GetProcAddress("glTexEnviv");
            ((delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int*, void>)EntryPoints[133])(target, pname, parameters);
        }
        
        public static void TexEnvxv(TextureEnvTarget target, TextureEnvParameter pname, int* parameters) => ((delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int*, void>)EntryPoints[134])(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void TexEnvxv_Lazy(TextureEnvTarget target, TextureEnvParameter pname, int* parameters)
        {
            EntryPoints[134] = GLLoader.BindingsContext.GetProcAddress("glTexEnvxv");
            ((delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int*, void>)EntryPoints[134])(target, pname, parameters);
        }
        
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
        public static void TexImage2D(TextureTarget target, int level, int internalformat, int width, int height, int border, PixelFormat format, PixelType type, void* pixels) => ((delegate* unmanaged<TextureTarget, int, int, int, int, int, PixelFormat, PixelType, void*, void>)EntryPoints[135])(target, level, internalformat, width, height, border, format, type, pixels);
        [UnmanagedCallersOnly]
        private static void TexImage2D_Lazy(TextureTarget target, int level, int internalformat, int width, int height, int border, PixelFormat format, PixelType type, void* pixels)
        {
            EntryPoints[135] = GLLoader.BindingsContext.GetProcAddress("glTexImage2D");
            ((delegate* unmanaged<TextureTarget, int, int, int, int, int, PixelFormat, PixelType, void*, void>)EntryPoints[135])(target, level, internalformat, width, height, border, format, type, pixels);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Set texture parameters. </summary>
        /// <param name="target">Specifies the target texture, which must be GL_TEXTURE_2D.</param>
        /// <param name="pname">Specifies the symbolic name of a single-valued texture parameter. Which can be one of the following: GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_GENERATE_MIPMAP.</param>
        /// <param name="param">Specifies the value of pname.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glTexParameter.xml" /></remarks>
        public static void TexParameteri(TextureTarget target, TextureParameterName pname, int param) => ((delegate* unmanaged<TextureTarget, TextureParameterName, int, void>)EntryPoints[136])(target, pname, param);
        [UnmanagedCallersOnly]
        private static void TexParameteri_Lazy(TextureTarget target, TextureParameterName pname, int param)
        {
            EntryPoints[136] = GLLoader.BindingsContext.GetProcAddress("glTexParameteri");
            ((delegate* unmanaged<TextureTarget, TextureParameterName, int, void>)EntryPoints[136])(target, pname, param);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Set texture parameters. </summary>
        /// <param name="target">Specifies the target texture, which must be GL_TEXTURE_2D.</param>
        /// <param name="pname">Specifies the symbolic name of a single-valued texture parameter. Which can be one of the following: GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_GENERATE_MIPMAP.</param>
        /// <param name="param">Specifies the value of pname.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glTexParameter.xml" /></remarks>
        public static void TexParameterx(TextureTarget target, GetTextureParameter pname, int param) => ((delegate* unmanaged<TextureTarget, GetTextureParameter, int, void>)EntryPoints[137])(target, pname, param);
        [UnmanagedCallersOnly]
        private static void TexParameterx_Lazy(TextureTarget target, GetTextureParameter pname, int param)
        {
            EntryPoints[137] = GLLoader.BindingsContext.GetProcAddress("glTexParameterx");
            ((delegate* unmanaged<TextureTarget, GetTextureParameter, int, void>)EntryPoints[137])(target, pname, param);
        }
        
        public static void TexParameteriv(TextureTarget target, TextureParameterName pname, int* parameters) => ((delegate* unmanaged<TextureTarget, TextureParameterName, int*, void>)EntryPoints[138])(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void TexParameteriv_Lazy(TextureTarget target, TextureParameterName pname, int* parameters)
        {
            EntryPoints[138] = GLLoader.BindingsContext.GetProcAddress("glTexParameteriv");
            ((delegate* unmanaged<TextureTarget, TextureParameterName, int*, void>)EntryPoints[138])(target, pname, parameters);
        }
        
        public static void TexParameterxv(TextureTarget target, GetTextureParameter pname, int* parameters) => ((delegate* unmanaged<TextureTarget, GetTextureParameter, int*, void>)EntryPoints[139])(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void TexParameterxv_Lazy(TextureTarget target, GetTextureParameter pname, int* parameters)
        {
            EntryPoints[139] = GLLoader.BindingsContext.GetProcAddress("glTexParameterxv");
            ((delegate* unmanaged<TextureTarget, GetTextureParameter, int*, void>)EntryPoints[139])(target, pname, parameters);
        }
        
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
        public static void TexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, void* pixels) => ((delegate* unmanaged<TextureTarget, int, int, int, int, int, PixelFormat, PixelType, void*, void>)EntryPoints[140])(target, level, xoffset, yoffset, width, height, format, type, pixels);
        [UnmanagedCallersOnly]
        private static void TexSubImage2D_Lazy(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, void* pixels)
        {
            EntryPoints[140] = GLLoader.BindingsContext.GetProcAddress("glTexSubImage2D");
            ((delegate* unmanaged<TextureTarget, int, int, int, int, int, PixelFormat, PixelType, void*, void>)EntryPoints[140])(target, level, xoffset, yoffset, width, height, format, type, pixels);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Multiply the current matrix by a translation matrix. </summary>
        /// <param name="x">Specify the x, y, and z coordinates of a translation vector.</param>
        /// <param name="y">Specify the x, y, and z coordinates of a translation vector.</param>
        /// <param name="z">Specify the x, y, and z coordinates of a translation vector.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glTranslate.xml" /></remarks>
        public static void Translatex(int x, int y, int z) => ((delegate* unmanaged<int, int, int, void>)EntryPoints[141])(x, y, z);
        [UnmanagedCallersOnly]
        private static void Translatex_Lazy(int x, int y, int z)
        {
            EntryPoints[141] = GLLoader.BindingsContext.GetProcAddress("glTranslatex");
            ((delegate* unmanaged<int, int, int, void>)EntryPoints[141])(x, y, z);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Define an array of vertex coordinates. </summary>
        /// <param name="size">Specifies the number of coordinates per vertex. Must be 2, 3, or 4. The initial value is 4.</param>
        /// <param name="type">Specifies the data type of each vertex coordinate in the array. Symbolic constants GL_BYTE, GL_SHORT, and GL_FIXED, are accepted. However, the initial value is GL_FLOAT.</param>
        /// <param name="stride">Specifies the byte offset between consecutive vertices. If stride is 0, the vertices are understood to be tightly packed in the array. The initial value is 0.</param>
        /// <param name="pointer">Specifies a pointer to the first coordinate of the first vertex in the array. The initial value is 0.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glVertexPointer.xml" /></remarks>
        public static void VertexPointer(int size, VertexPointerType type, int stride, void* pointer) => ((delegate* unmanaged<int, VertexPointerType, int, void*, void>)EntryPoints[142])(size, type, stride, pointer);
        [UnmanagedCallersOnly]
        private static void VertexPointer_Lazy(int size, VertexPointerType type, int stride, void* pointer)
        {
            EntryPoints[142] = GLLoader.BindingsContext.GetProcAddress("glVertexPointer");
            ((delegate* unmanaged<int, VertexPointerType, int, void*, void>)EntryPoints[142])(size, type, stride, pointer);
        }
        
        /// <summary> <b>[requires: v1.0]</b> Set the viewport. </summary>
        /// <param name="x">Specify the lower left corner of the viewport rectangle, in pixels. The initial value is (0, 0).</param>
        /// <param name="y">Specify the lower left corner of the viewport rectangle, in pixels. The initial value is (0, 0).</param>
        /// <param name="width">Specify the width and height of the viewport. When a GL context is first attached to a surface (e.g. window), width and height are set to the dimensions of that surface.</param>
        /// <param name="height">Specify the width and height of the viewport. When a GL context is first attached to a surface (e.g. window), width and height are set to the dimensions of that surface.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glViewport.xml" /></remarks>
        public static void Viewport(int x, int y, int width, int height) => ((delegate* unmanaged<int, int, int, int, void>)EntryPoints[143])(x, y, width, height);
        [UnmanagedCallersOnly]
        private static void Viewport_Lazy(int x, int y, int width, int height)
        {
            EntryPoints[143] = GLLoader.BindingsContext.GetProcAddress("glViewport");
            ((delegate* unmanaged<int, int, int, int, void>)EntryPoints[143])(x, y, width, height);
        }
        
        static GL()
        {
            EntryPoints = new IntPtr[144];
            EntryPoints[0] = (IntPtr)(delegate* unmanaged<AlphaFunction, float, void>)&AlphaFunc_Lazy;
            EntryPoints[1] = (IntPtr)(delegate* unmanaged<float, float, float, float, void>)&ClearColor_Lazy;
            EntryPoints[2] = (IntPtr)(delegate* unmanaged<float, void>)&ClearDepthf_Lazy;
            EntryPoints[3] = (IntPtr)(delegate* unmanaged<ClipPlaneName, float*, void>)&ClipPlanef_Lazy;
            EntryPoints[4] = (IntPtr)(delegate* unmanaged<float, float, float, float, void>)&Color4f_Lazy;
            EntryPoints[5] = (IntPtr)(delegate* unmanaged<float, float, void>)&DepthRangef_Lazy;
            EntryPoints[6] = (IntPtr)(delegate* unmanaged<FogParameter, float, void>)&Fogf_Lazy;
            EntryPoints[7] = (IntPtr)(delegate* unmanaged<FogParameter, float*, void>)&Fogfv_Lazy;
            EntryPoints[8] = (IntPtr)(delegate* unmanaged<float, float, float, float, float, float, void>)&Frustumf_Lazy;
            EntryPoints[9] = (IntPtr)(delegate* unmanaged<ClipPlaneName, float*, void>)&GetClipPlanef_Lazy;
            EntryPoints[10] = (IntPtr)(delegate* unmanaged<GetPName, float*, void>)&GetFloatv_Lazy;
            EntryPoints[11] = (IntPtr)(delegate* unmanaged<LightName, LightParameter, float*, void>)&GetLightfv_Lazy;
            EntryPoints[12] = (IntPtr)(delegate* unmanaged<MaterialFace, MaterialParameter, float*, void>)&GetMaterialfv_Lazy;
            EntryPoints[13] = (IntPtr)(delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, float*, void>)&GetTexEnvfv_Lazy;
            EntryPoints[14] = (IntPtr)(delegate* unmanaged<TextureTarget, GetTextureParameter, float*, void>)&GetTexParameterfv_Lazy;
            EntryPoints[15] = (IntPtr)(delegate* unmanaged<LightModelParameter, float, void>)&LightModelf_Lazy;
            EntryPoints[16] = (IntPtr)(delegate* unmanaged<LightModelParameter, float*, void>)&LightModelfv_Lazy;
            EntryPoints[17] = (IntPtr)(delegate* unmanaged<LightName, LightParameter, float, void>)&Lightf_Lazy;
            EntryPoints[18] = (IntPtr)(delegate* unmanaged<LightName, LightParameter, float*, void>)&Lightfv_Lazy;
            EntryPoints[19] = (IntPtr)(delegate* unmanaged<float, void>)&LineWidth_Lazy;
            EntryPoints[20] = (IntPtr)(delegate* unmanaged<float*, void>)&LoadMatrixf_Lazy;
            EntryPoints[21] = (IntPtr)(delegate* unmanaged<MaterialFace, MaterialParameter, float, void>)&Materialf_Lazy;
            EntryPoints[22] = (IntPtr)(delegate* unmanaged<MaterialFace, MaterialParameter, float*, void>)&Materialfv_Lazy;
            EntryPoints[23] = (IntPtr)(delegate* unmanaged<float*, void>)&MultMatrixf_Lazy;
            EntryPoints[24] = (IntPtr)(delegate* unmanaged<TextureUnit, float, float, float, float, void>)&MultiTexCoord4f_Lazy;
            EntryPoints[25] = (IntPtr)(delegate* unmanaged<float, float, float, void>)&Normal3f_Lazy;
            EntryPoints[26] = (IntPtr)(delegate* unmanaged<float, float, float, float, float, float, void>)&Orthof_Lazy;
            EntryPoints[27] = (IntPtr)(delegate* unmanaged<PointParameterNameARB, float, void>)&PointParameterf_Lazy;
            EntryPoints[28] = (IntPtr)(delegate* unmanaged<PointParameterNameARB, float*, void>)&PointParameterfv_Lazy;
            EntryPoints[29] = (IntPtr)(delegate* unmanaged<float, void>)&PointSize_Lazy;
            EntryPoints[30] = (IntPtr)(delegate* unmanaged<float, float, void>)&PolygonOffset_Lazy;
            EntryPoints[31] = (IntPtr)(delegate* unmanaged<float, float, float, float, void>)&Rotatef_Lazy;
            EntryPoints[32] = (IntPtr)(delegate* unmanaged<float, float, float, void>)&Scalef_Lazy;
            EntryPoints[33] = (IntPtr)(delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, float, void>)&TexEnvf_Lazy;
            EntryPoints[34] = (IntPtr)(delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, float*, void>)&TexEnvfv_Lazy;
            EntryPoints[35] = (IntPtr)(delegate* unmanaged<TextureTarget, TextureParameterName, float, void>)&TexParameterf_Lazy;
            EntryPoints[36] = (IntPtr)(delegate* unmanaged<TextureTarget, TextureParameterName, float*, void>)&TexParameterfv_Lazy;
            EntryPoints[37] = (IntPtr)(delegate* unmanaged<float, float, float, void>)&Translatef_Lazy;
            EntryPoints[38] = (IntPtr)(delegate* unmanaged<TextureUnit, void>)&ActiveTexture_Lazy;
            EntryPoints[39] = (IntPtr)(delegate* unmanaged<AlphaFunction, int, void>)&AlphaFuncx_Lazy;
            EntryPoints[40] = (IntPtr)(delegate* unmanaged<BufferTargetARB, BufferHandle, void>)&BindBuffer_Lazy;
            EntryPoints[41] = (IntPtr)(delegate* unmanaged<TextureTarget, TextureHandle, void>)&BindTexture_Lazy;
            EntryPoints[42] = (IntPtr)(delegate* unmanaged<BlendingFactor, BlendingFactor, void>)&BlendFunc_Lazy;
            EntryPoints[43] = (IntPtr)(delegate* unmanaged<BufferTargetARB, nint, void*, BufferUsageARB, void>)&BufferData_Lazy;
            EntryPoints[44] = (IntPtr)(delegate* unmanaged<BufferTargetARB, IntPtr, nint, void*, void>)&BufferSubData_Lazy;
            EntryPoints[45] = (IntPtr)(delegate* unmanaged<ClearBufferMask, void>)&Clear_Lazy;
            EntryPoints[46] = (IntPtr)(delegate* unmanaged<int, int, int, int, void>)&ClearColorx_Lazy;
            EntryPoints[47] = (IntPtr)(delegate* unmanaged<int, void>)&ClearDepthx_Lazy;
            EntryPoints[48] = (IntPtr)(delegate* unmanaged<int, void>)&ClearStencil_Lazy;
            EntryPoints[49] = (IntPtr)(delegate* unmanaged<TextureUnit, void>)&ClientActiveTexture_Lazy;
            EntryPoints[50] = (IntPtr)(delegate* unmanaged<ClipPlaneName, int*, void>)&ClipPlanex_Lazy;
            EntryPoints[51] = (IntPtr)(delegate* unmanaged<byte, byte, byte, byte, void>)&Color4ub_Lazy;
            EntryPoints[52] = (IntPtr)(delegate* unmanaged<int, int, int, int, void>)&Color4x_Lazy;
            EntryPoints[53] = (IntPtr)(delegate* unmanaged<byte, byte, byte, byte, void>)&ColorMask_Lazy;
            EntryPoints[54] = (IntPtr)(delegate* unmanaged<int, ColorPointerType, int, void*, void>)&ColorPointer_Lazy;
            EntryPoints[55] = (IntPtr)(delegate* unmanaged<TextureTarget, int, InternalFormat, int, int, int, int, void*, void>)&CompressedTexImage2D_Lazy;
            EntryPoints[56] = (IntPtr)(delegate* unmanaged<TextureTarget, int, int, int, int, int, InternalFormat, int, void*, void>)&CompressedTexSubImage2D_Lazy;
            EntryPoints[57] = (IntPtr)(delegate* unmanaged<TextureTarget, int, InternalFormat, int, int, int, int, int, void>)&CopyTexImage2D_Lazy;
            EntryPoints[58] = (IntPtr)(delegate* unmanaged<TextureTarget, int, int, int, int, int, int, int, void>)&CopyTexSubImage2D_Lazy;
            EntryPoints[59] = (IntPtr)(delegate* unmanaged<CullFaceMode, void>)&CullFace_Lazy;
            EntryPoints[60] = (IntPtr)(delegate* unmanaged<int, BufferHandle*, void>)&DeleteBuffers_Lazy;
            EntryPoints[61] = (IntPtr)(delegate* unmanaged<int, TextureHandle*, void>)&DeleteTextures_Lazy;
            EntryPoints[62] = (IntPtr)(delegate* unmanaged<DepthFunction, void>)&DepthFunc_Lazy;
            EntryPoints[63] = (IntPtr)(delegate* unmanaged<byte, void>)&DepthMask_Lazy;
            EntryPoints[64] = (IntPtr)(delegate* unmanaged<int, int, void>)&DepthRangex_Lazy;
            EntryPoints[65] = (IntPtr)(delegate* unmanaged<EnableCap, void>)&Disable_Lazy;
            EntryPoints[66] = (IntPtr)(delegate* unmanaged<EnableCap, void>)&DisableClientState_Lazy;
            EntryPoints[67] = (IntPtr)(delegate* unmanaged<PrimitiveType, int, int, void>)&DrawArrays_Lazy;
            EntryPoints[68] = (IntPtr)(delegate* unmanaged<PrimitiveType, int, DrawElementsType, void*, void>)&DrawElements_Lazy;
            EntryPoints[69] = (IntPtr)(delegate* unmanaged<EnableCap, void>)&Enable_Lazy;
            EntryPoints[70] = (IntPtr)(delegate* unmanaged<EnableCap, void>)&EnableClientState_Lazy;
            EntryPoints[71] = (IntPtr)(delegate* unmanaged<void>)&Finish_Lazy;
            EntryPoints[72] = (IntPtr)(delegate* unmanaged<void>)&Flush_Lazy;
            EntryPoints[73] = (IntPtr)(delegate* unmanaged<FogPName, int, void>)&Fogx_Lazy;
            EntryPoints[74] = (IntPtr)(delegate* unmanaged<FogPName, int*, void>)&Fogxv_Lazy;
            EntryPoints[75] = (IntPtr)(delegate* unmanaged<FrontFaceDirection, void>)&FrontFace_Lazy;
            EntryPoints[76] = (IntPtr)(delegate* unmanaged<int, int, int, int, int, int, void>)&Frustumx_Lazy;
            EntryPoints[77] = (IntPtr)(delegate* unmanaged<GetPName, byte*, void>)&GetBooleanv_Lazy;
            EntryPoints[78] = (IntPtr)(delegate* unmanaged<BufferTargetARB, BufferPNameARB, int*, void>)&GetBufferParameteriv_Lazy;
            EntryPoints[79] = (IntPtr)(delegate* unmanaged<ClipPlaneName, int*, void>)&GetClipPlanex_Lazy;
            EntryPoints[80] = (IntPtr)(delegate* unmanaged<int, BufferHandle*, void>)&GenBuffers_Lazy;
            EntryPoints[81] = (IntPtr)(delegate* unmanaged<int, TextureHandle*, void>)&GenTextures_Lazy;
            EntryPoints[82] = (IntPtr)(delegate* unmanaged<ErrorCode>)&GetError_Lazy;
            EntryPoints[83] = (IntPtr)(delegate* unmanaged<GetPName, int*, void>)&GetFixedv_Lazy;
            EntryPoints[84] = (IntPtr)(delegate* unmanaged<GetPName, int*, void>)&GetIntegerv_Lazy;
            EntryPoints[85] = (IntPtr)(delegate* unmanaged<LightName, LightParameter, int*, void>)&GetLightxv_Lazy;
            EntryPoints[86] = (IntPtr)(delegate* unmanaged<MaterialFace, MaterialParameter, int*, void>)&GetMaterialxv_Lazy;
            EntryPoints[87] = (IntPtr)(delegate* unmanaged<GetPointervPName, void**, void>)&GetPointerv_Lazy;
            EntryPoints[88] = (IntPtr)(delegate* unmanaged<StringName, byte*>)&GetString__Lazy;
            EntryPoints[89] = (IntPtr)(delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int*, void>)&GetTexEnviv_Lazy;
            EntryPoints[90] = (IntPtr)(delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int*, void>)&GetTexEnvxv_Lazy;
            EntryPoints[91] = (IntPtr)(delegate* unmanaged<TextureTarget, GetTextureParameter, int*, void>)&GetTexParameteriv_Lazy;
            EntryPoints[92] = (IntPtr)(delegate* unmanaged<TextureTarget, GetTextureParameter, int*, void>)&GetTexParameterxv_Lazy;
            EntryPoints[93] = (IntPtr)(delegate* unmanaged<HintTarget, HintMode, void>)&Hint_Lazy;
            EntryPoints[94] = (IntPtr)(delegate* unmanaged<BufferHandle, byte>)&IsBuffer_Lazy;
            EntryPoints[95] = (IntPtr)(delegate* unmanaged<EnableCap, byte>)&IsEnabled_Lazy;
            EntryPoints[96] = (IntPtr)(delegate* unmanaged<TextureHandle, byte>)&IsTexture_Lazy;
            EntryPoints[97] = (IntPtr)(delegate* unmanaged<LightModelParameter, int, void>)&LightModelx_Lazy;
            EntryPoints[98] = (IntPtr)(delegate* unmanaged<LightModelParameter, int*, void>)&LightModelxv_Lazy;
            EntryPoints[99] = (IntPtr)(delegate* unmanaged<LightName, LightParameter, int, void>)&Lightx_Lazy;
            EntryPoints[100] = (IntPtr)(delegate* unmanaged<LightName, LightParameter, int*, void>)&Lightxv_Lazy;
            EntryPoints[101] = (IntPtr)(delegate* unmanaged<int, void>)&LineWidthx_Lazy;
            EntryPoints[102] = (IntPtr)(delegate* unmanaged<void>)&LoadIdentity_Lazy;
            EntryPoints[103] = (IntPtr)(delegate* unmanaged<int*, void>)&LoadMatrixx_Lazy;
            EntryPoints[104] = (IntPtr)(delegate* unmanaged<LogicOp, void>)&LogicOp_Lazy;
            EntryPoints[105] = (IntPtr)(delegate* unmanaged<MaterialFace, MaterialParameter, int, void>)&Materialx_Lazy;
            EntryPoints[106] = (IntPtr)(delegate* unmanaged<MaterialFace, MaterialParameter, int*, void>)&Materialxv_Lazy;
            EntryPoints[107] = (IntPtr)(delegate* unmanaged<MatrixMode, void>)&MatrixMode_Lazy;
            EntryPoints[108] = (IntPtr)(delegate* unmanaged<int*, void>)&MultMatrixx_Lazy;
            EntryPoints[109] = (IntPtr)(delegate* unmanaged<TextureUnit, int, int, int, int, void>)&MultiTexCoord4x_Lazy;
            EntryPoints[110] = (IntPtr)(delegate* unmanaged<int, int, int, void>)&Normal3x_Lazy;
            EntryPoints[111] = (IntPtr)(delegate* unmanaged<NormalPointerType, int, void*, void>)&NormalPointer_Lazy;
            EntryPoints[112] = (IntPtr)(delegate* unmanaged<int, int, int, int, int, int, void>)&Orthox_Lazy;
            EntryPoints[113] = (IntPtr)(delegate* unmanaged<PixelStoreParameter, int, void>)&PixelStorei_Lazy;
            EntryPoints[114] = (IntPtr)(delegate* unmanaged<PointParameterNameARB, int, void>)&PointParameterx_Lazy;
            EntryPoints[115] = (IntPtr)(delegate* unmanaged<PointParameterNameARB, int*, void>)&PointParameterxv_Lazy;
            EntryPoints[116] = (IntPtr)(delegate* unmanaged<int, void>)&PointSizex_Lazy;
            EntryPoints[117] = (IntPtr)(delegate* unmanaged<int, int, void>)&PolygonOffsetx_Lazy;
            EntryPoints[118] = (IntPtr)(delegate* unmanaged<void>)&PopMatrix_Lazy;
            EntryPoints[119] = (IntPtr)(delegate* unmanaged<void>)&PushMatrix_Lazy;
            EntryPoints[120] = (IntPtr)(delegate* unmanaged<int, int, int, int, PixelFormat, PixelType, void*, void>)&ReadPixels_Lazy;
            EntryPoints[121] = (IntPtr)(delegate* unmanaged<int, int, int, int, void>)&Rotatex_Lazy;
            EntryPoints[122] = (IntPtr)(delegate* unmanaged<float, byte, void>)&SampleCoverage_Lazy;
            EntryPoints[123] = (IntPtr)(delegate* unmanaged<int, byte, void>)&SampleCoveragex_Lazy;
            EntryPoints[124] = (IntPtr)(delegate* unmanaged<int, int, int, void>)&Scalex_Lazy;
            EntryPoints[125] = (IntPtr)(delegate* unmanaged<int, int, int, int, void>)&Scissor_Lazy;
            EntryPoints[126] = (IntPtr)(delegate* unmanaged<ShadingModel, void>)&ShadeModel_Lazy;
            EntryPoints[127] = (IntPtr)(delegate* unmanaged<StencilFunction, int, uint, void>)&StencilFunc_Lazy;
            EntryPoints[128] = (IntPtr)(delegate* unmanaged<uint, void>)&StencilMask_Lazy;
            EntryPoints[129] = (IntPtr)(delegate* unmanaged<StencilOp, StencilOp, StencilOp, void>)&StencilOp_Lazy;
            EntryPoints[130] = (IntPtr)(delegate* unmanaged<int, TexCoordPointerType, int, void*, void>)&TexCoordPointer_Lazy;
            EntryPoints[131] = (IntPtr)(delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int, void>)&TexEnvi_Lazy;
            EntryPoints[132] = (IntPtr)(delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int, void>)&TexEnvx_Lazy;
            EntryPoints[133] = (IntPtr)(delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int*, void>)&TexEnviv_Lazy;
            EntryPoints[134] = (IntPtr)(delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int*, void>)&TexEnvxv_Lazy;
            EntryPoints[135] = (IntPtr)(delegate* unmanaged<TextureTarget, int, int, int, int, int, PixelFormat, PixelType, void*, void>)&TexImage2D_Lazy;
            EntryPoints[136] = (IntPtr)(delegate* unmanaged<TextureTarget, TextureParameterName, int, void>)&TexParameteri_Lazy;
            EntryPoints[137] = (IntPtr)(delegate* unmanaged<TextureTarget, GetTextureParameter, int, void>)&TexParameterx_Lazy;
            EntryPoints[138] = (IntPtr)(delegate* unmanaged<TextureTarget, TextureParameterName, int*, void>)&TexParameteriv_Lazy;
            EntryPoints[139] = (IntPtr)(delegate* unmanaged<TextureTarget, GetTextureParameter, int*, void>)&TexParameterxv_Lazy;
            EntryPoints[140] = (IntPtr)(delegate* unmanaged<TextureTarget, int, int, int, int, int, PixelFormat, PixelType, void*, void>)&TexSubImage2D_Lazy;
            EntryPoints[141] = (IntPtr)(delegate* unmanaged<int, int, int, void>)&Translatex_Lazy;
            EntryPoints[142] = (IntPtr)(delegate* unmanaged<int, VertexPointerType, int, void*, void>)&VertexPointer_Lazy;
            EntryPoints[143] = (IntPtr)(delegate* unmanaged<int, int, int, int, void>)&Viewport_Lazy;
        }
        public static void LoadAllFunctions(IBindingsContext context)
        {
            EntryPoints[0] = context.GetProcAddress("glAlphaFunc");
            EntryPoints[1] = context.GetProcAddress("glClearColor");
            EntryPoints[2] = context.GetProcAddress("glClearDepthf");
            EntryPoints[3] = context.GetProcAddress("glClipPlanef");
            EntryPoints[4] = context.GetProcAddress("glColor4f");
            EntryPoints[5] = context.GetProcAddress("glDepthRangef");
            EntryPoints[6] = context.GetProcAddress("glFogf");
            EntryPoints[7] = context.GetProcAddress("glFogfv");
            EntryPoints[8] = context.GetProcAddress("glFrustumf");
            EntryPoints[9] = context.GetProcAddress("glGetClipPlanef");
            EntryPoints[10] = context.GetProcAddress("glGetFloatv");
            EntryPoints[11] = context.GetProcAddress("glGetLightfv");
            EntryPoints[12] = context.GetProcAddress("glGetMaterialfv");
            EntryPoints[13] = context.GetProcAddress("glGetTexEnvfv");
            EntryPoints[14] = context.GetProcAddress("glGetTexParameterfv");
            EntryPoints[15] = context.GetProcAddress("glLightModelf");
            EntryPoints[16] = context.GetProcAddress("glLightModelfv");
            EntryPoints[17] = context.GetProcAddress("glLightf");
            EntryPoints[18] = context.GetProcAddress("glLightfv");
            EntryPoints[19] = context.GetProcAddress("glLineWidth");
            EntryPoints[20] = context.GetProcAddress("glLoadMatrixf");
            EntryPoints[21] = context.GetProcAddress("glMaterialf");
            EntryPoints[22] = context.GetProcAddress("glMaterialfv");
            EntryPoints[23] = context.GetProcAddress("glMultMatrixf");
            EntryPoints[24] = context.GetProcAddress("glMultiTexCoord4f");
            EntryPoints[25] = context.GetProcAddress("glNormal3f");
            EntryPoints[26] = context.GetProcAddress("glOrthof");
            EntryPoints[27] = context.GetProcAddress("glPointParameterf");
            EntryPoints[28] = context.GetProcAddress("glPointParameterfv");
            EntryPoints[29] = context.GetProcAddress("glPointSize");
            EntryPoints[30] = context.GetProcAddress("glPolygonOffset");
            EntryPoints[31] = context.GetProcAddress("glRotatef");
            EntryPoints[32] = context.GetProcAddress("glScalef");
            EntryPoints[33] = context.GetProcAddress("glTexEnvf");
            EntryPoints[34] = context.GetProcAddress("glTexEnvfv");
            EntryPoints[35] = context.GetProcAddress("glTexParameterf");
            EntryPoints[36] = context.GetProcAddress("glTexParameterfv");
            EntryPoints[37] = context.GetProcAddress("glTranslatef");
            EntryPoints[38] = context.GetProcAddress("glActiveTexture");
            EntryPoints[39] = context.GetProcAddress("glAlphaFuncx");
            EntryPoints[40] = context.GetProcAddress("glBindBuffer");
            EntryPoints[41] = context.GetProcAddress("glBindTexture");
            EntryPoints[42] = context.GetProcAddress("glBlendFunc");
            EntryPoints[43] = context.GetProcAddress("glBufferData");
            EntryPoints[44] = context.GetProcAddress("glBufferSubData");
            EntryPoints[45] = context.GetProcAddress("glClear");
            EntryPoints[46] = context.GetProcAddress("glClearColorx");
            EntryPoints[47] = context.GetProcAddress("glClearDepthx");
            EntryPoints[48] = context.GetProcAddress("glClearStencil");
            EntryPoints[49] = context.GetProcAddress("glClientActiveTexture");
            EntryPoints[50] = context.GetProcAddress("glClipPlanex");
            EntryPoints[51] = context.GetProcAddress("glColor4ub");
            EntryPoints[52] = context.GetProcAddress("glColor4x");
            EntryPoints[53] = context.GetProcAddress("glColorMask");
            EntryPoints[54] = context.GetProcAddress("glColorPointer");
            EntryPoints[55] = context.GetProcAddress("glCompressedTexImage2D");
            EntryPoints[56] = context.GetProcAddress("glCompressedTexSubImage2D");
            EntryPoints[57] = context.GetProcAddress("glCopyTexImage2D");
            EntryPoints[58] = context.GetProcAddress("glCopyTexSubImage2D");
            EntryPoints[59] = context.GetProcAddress("glCullFace");
            EntryPoints[60] = context.GetProcAddress("glDeleteBuffers");
            EntryPoints[61] = context.GetProcAddress("glDeleteTextures");
            EntryPoints[62] = context.GetProcAddress("glDepthFunc");
            EntryPoints[63] = context.GetProcAddress("glDepthMask");
            EntryPoints[64] = context.GetProcAddress("glDepthRangex");
            EntryPoints[65] = context.GetProcAddress("glDisable");
            EntryPoints[66] = context.GetProcAddress("glDisableClientState");
            EntryPoints[67] = context.GetProcAddress("glDrawArrays");
            EntryPoints[68] = context.GetProcAddress("glDrawElements");
            EntryPoints[69] = context.GetProcAddress("glEnable");
            EntryPoints[70] = context.GetProcAddress("glEnableClientState");
            EntryPoints[71] = context.GetProcAddress("glFinish");
            EntryPoints[72] = context.GetProcAddress("glFlush");
            EntryPoints[73] = context.GetProcAddress("glFogx");
            EntryPoints[74] = context.GetProcAddress("glFogxv");
            EntryPoints[75] = context.GetProcAddress("glFrontFace");
            EntryPoints[76] = context.GetProcAddress("glFrustumx");
            EntryPoints[77] = context.GetProcAddress("glGetBooleanv");
            EntryPoints[78] = context.GetProcAddress("glGetBufferParameteriv");
            EntryPoints[79] = context.GetProcAddress("glGetClipPlanex");
            EntryPoints[80] = context.GetProcAddress("glGenBuffers");
            EntryPoints[81] = context.GetProcAddress("glGenTextures");
            EntryPoints[82] = context.GetProcAddress("glGetError");
            EntryPoints[83] = context.GetProcAddress("glGetFixedv");
            EntryPoints[84] = context.GetProcAddress("glGetIntegerv");
            EntryPoints[85] = context.GetProcAddress("glGetLightxv");
            EntryPoints[86] = context.GetProcAddress("glGetMaterialxv");
            EntryPoints[87] = context.GetProcAddress("glGetPointerv");
            EntryPoints[88] = context.GetProcAddress("glGetString");
            EntryPoints[89] = context.GetProcAddress("glGetTexEnviv");
            EntryPoints[90] = context.GetProcAddress("glGetTexEnvxv");
            EntryPoints[91] = context.GetProcAddress("glGetTexParameteriv");
            EntryPoints[92] = context.GetProcAddress("glGetTexParameterxv");
            EntryPoints[93] = context.GetProcAddress("glHint");
            EntryPoints[94] = context.GetProcAddress("glIsBuffer");
            EntryPoints[95] = context.GetProcAddress("glIsEnabled");
            EntryPoints[96] = context.GetProcAddress("glIsTexture");
            EntryPoints[97] = context.GetProcAddress("glLightModelx");
            EntryPoints[98] = context.GetProcAddress("glLightModelxv");
            EntryPoints[99] = context.GetProcAddress("glLightx");
            EntryPoints[100] = context.GetProcAddress("glLightxv");
            EntryPoints[101] = context.GetProcAddress("glLineWidthx");
            EntryPoints[102] = context.GetProcAddress("glLoadIdentity");
            EntryPoints[103] = context.GetProcAddress("glLoadMatrixx");
            EntryPoints[104] = context.GetProcAddress("glLogicOp");
            EntryPoints[105] = context.GetProcAddress("glMaterialx");
            EntryPoints[106] = context.GetProcAddress("glMaterialxv");
            EntryPoints[107] = context.GetProcAddress("glMatrixMode");
            EntryPoints[108] = context.GetProcAddress("glMultMatrixx");
            EntryPoints[109] = context.GetProcAddress("glMultiTexCoord4x");
            EntryPoints[110] = context.GetProcAddress("glNormal3x");
            EntryPoints[111] = context.GetProcAddress("glNormalPointer");
            EntryPoints[112] = context.GetProcAddress("glOrthox");
            EntryPoints[113] = context.GetProcAddress("glPixelStorei");
            EntryPoints[114] = context.GetProcAddress("glPointParameterx");
            EntryPoints[115] = context.GetProcAddress("glPointParameterxv");
            EntryPoints[116] = context.GetProcAddress("glPointSizex");
            EntryPoints[117] = context.GetProcAddress("glPolygonOffsetx");
            EntryPoints[118] = context.GetProcAddress("glPopMatrix");
            EntryPoints[119] = context.GetProcAddress("glPushMatrix");
            EntryPoints[120] = context.GetProcAddress("glReadPixels");
            EntryPoints[121] = context.GetProcAddress("glRotatex");
            EntryPoints[122] = context.GetProcAddress("glSampleCoverage");
            EntryPoints[123] = context.GetProcAddress("glSampleCoveragex");
            EntryPoints[124] = context.GetProcAddress("glScalex");
            EntryPoints[125] = context.GetProcAddress("glScissor");
            EntryPoints[126] = context.GetProcAddress("glShadeModel");
            EntryPoints[127] = context.GetProcAddress("glStencilFunc");
            EntryPoints[128] = context.GetProcAddress("glStencilMask");
            EntryPoints[129] = context.GetProcAddress("glStencilOp");
            EntryPoints[130] = context.GetProcAddress("glTexCoordPointer");
            EntryPoints[131] = context.GetProcAddress("glTexEnvi");
            EntryPoints[132] = context.GetProcAddress("glTexEnvx");
            EntryPoints[133] = context.GetProcAddress("glTexEnviv");
            EntryPoints[134] = context.GetProcAddress("glTexEnvxv");
            EntryPoints[135] = context.GetProcAddress("glTexImage2D");
            EntryPoints[136] = context.GetProcAddress("glTexParameteri");
            EntryPoints[137] = context.GetProcAddress("glTexParameterx");
            EntryPoints[138] = context.GetProcAddress("glTexParameteriv");
            EntryPoints[139] = context.GetProcAddress("glTexParameterxv");
            EntryPoints[140] = context.GetProcAddress("glTexSubImage2D");
            EntryPoints[141] = context.GetProcAddress("glTranslatex");
            EntryPoints[142] = context.GetProcAddress("glVertexPointer");
            EntryPoints[143] = context.GetProcAddress("glViewport");
        }
        public static unsafe partial class APPLE
        {
            private static IntPtr[] EntryPoints;
            
            /// <summary> <b>[requires: GL_APPLE_copy_texture_levels]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void CopyTextureLevelsAPPLE(uint destinationTexture, uint sourceTexture, int sourceBaseLevel, int sourceLevelCount) => ((delegate* unmanaged<uint, uint, int, int, void>)EntryPoints[0])(destinationTexture, sourceTexture, sourceBaseLevel, sourceLevelCount);
            [UnmanagedCallersOnly]
            private static void CopyTextureLevelsAPPLE_Lazy(uint destinationTexture, uint sourceTexture, int sourceBaseLevel, int sourceLevelCount)
            {
                EntryPoints[0] = GLLoader.BindingsContext.GetProcAddress("glCopyTextureLevelsAPPLE");
                ((delegate* unmanaged<uint, uint, int, int, void>)EntryPoints[0])(destinationTexture, sourceTexture, sourceBaseLevel, sourceLevelCount);
            }
            
            /// <summary> <b>[requires: GL_APPLE_framebuffer_multisample]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void RenderbufferStorageMultisampleAPPLE(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => ((delegate* unmanaged<RenderbufferTarget, int, InternalFormat, int, int, void>)EntryPoints[1])(target, samples, internalformat, width, height);
            [UnmanagedCallersOnly]
            private static void RenderbufferStorageMultisampleAPPLE_Lazy(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height)
            {
                EntryPoints[1] = GLLoader.BindingsContext.GetProcAddress("glRenderbufferStorageMultisampleAPPLE");
                ((delegate* unmanaged<RenderbufferTarget, int, InternalFormat, int, int, void>)EntryPoints[1])(target, samples, internalformat, width, height);
            }
            
            /// <summary> <b>[requires: GL_APPLE_framebuffer_multisample]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ResolveMultisampleFramebufferAPPLE() => ((delegate* unmanaged<void>)EntryPoints[2])();
            [UnmanagedCallersOnly]
            private static void ResolveMultisampleFramebufferAPPLE_Lazy()
            {
                EntryPoints[2] = GLLoader.BindingsContext.GetProcAddress("glResolveMultisampleFramebufferAPPLE");
                ((delegate* unmanaged<void>)EntryPoints[2])();
            }
            
            /// <summary> <b>[requires: GL_APPLE_sync]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static GLSync FenceSyncAPPLE(SyncCondition condition, SyncBehaviorFlags flags) => (GLSync) ((delegate* unmanaged<SyncCondition, SyncBehaviorFlags, IntPtr>)EntryPoints[3])(condition, flags);
            [UnmanagedCallersOnly]
            private static IntPtr FenceSyncAPPLE_Lazy(SyncCondition condition, SyncBehaviorFlags flags)
            {
                EntryPoints[3] = GLLoader.BindingsContext.GetProcAddress("glFenceSyncAPPLE");
                return ((delegate* unmanaged<SyncCondition, SyncBehaviorFlags, IntPtr>)EntryPoints[3])(condition, flags);
            }
            
            /// <summary> <b>[requires: GL_APPLE_sync]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static byte IsSyncAPPLE(GLSync sync) => ((delegate* unmanaged<GLSync, byte>)EntryPoints[4])(sync);
            [UnmanagedCallersOnly]
            private static byte IsSyncAPPLE_Lazy(GLSync sync)
            {
                EntryPoints[4] = GLLoader.BindingsContext.GetProcAddress("glIsSyncAPPLE");
                return ((delegate* unmanaged<GLSync, byte>)EntryPoints[4])(sync);
            }
            
            /// <summary> <b>[requires: GL_APPLE_sync]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DeleteSyncAPPLE(GLSync sync) => ((delegate* unmanaged<GLSync, void>)EntryPoints[5])(sync);
            [UnmanagedCallersOnly]
            private static void DeleteSyncAPPLE_Lazy(GLSync sync)
            {
                EntryPoints[5] = GLLoader.BindingsContext.GetProcAddress("glDeleteSyncAPPLE");
                ((delegate* unmanaged<GLSync, void>)EntryPoints[5])(sync);
            }
            
            /// <summary> <b>[requires: GL_APPLE_sync]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static SyncStatus ClientWaitSyncAPPLE(GLSync sync, SyncObjectMask flags, ulong timeout) => ((delegate* unmanaged<GLSync, SyncObjectMask, ulong, SyncStatus>)EntryPoints[6])(sync, flags, timeout);
            [UnmanagedCallersOnly]
            private static SyncStatus ClientWaitSyncAPPLE_Lazy(GLSync sync, SyncObjectMask flags, ulong timeout)
            {
                EntryPoints[6] = GLLoader.BindingsContext.GetProcAddress("glClientWaitSyncAPPLE");
                return ((delegate* unmanaged<GLSync, SyncObjectMask, ulong, SyncStatus>)EntryPoints[6])(sync, flags, timeout);
            }
            
            /// <summary> <b>[requires: GL_APPLE_sync]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void WaitSyncAPPLE(GLSync sync, SyncBehaviorFlags flags, ulong timeout) => ((delegate* unmanaged<GLSync, SyncBehaviorFlags, ulong, void>)EntryPoints[7])(sync, flags, timeout);
            [UnmanagedCallersOnly]
            private static void WaitSyncAPPLE_Lazy(GLSync sync, SyncBehaviorFlags flags, ulong timeout)
            {
                EntryPoints[7] = GLLoader.BindingsContext.GetProcAddress("glWaitSyncAPPLE");
                ((delegate* unmanaged<GLSync, SyncBehaviorFlags, ulong, void>)EntryPoints[7])(sync, flags, timeout);
            }
            
            /// <summary> <b>[requires: GL_APPLE_sync]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetInteger64vAPPLE(GetPName pname, long* parameters) => ((delegate* unmanaged<GetPName, long*, void>)EntryPoints[8])(pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetInteger64vAPPLE_Lazy(GetPName pname, long* parameters)
            {
                EntryPoints[8] = GLLoader.BindingsContext.GetProcAddress("glGetInteger64vAPPLE");
                ((delegate* unmanaged<GetPName, long*, void>)EntryPoints[8])(pname, parameters);
            }
            
            /// <summary> <b>[requires: GL_APPLE_sync]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetSyncivAPPLE(GLSync sync, SyncParameterName pname, int count, int* length, int* values) => ((delegate* unmanaged<GLSync, SyncParameterName, int, int*, int*, void>)EntryPoints[9])(sync, pname, count, length, values);
            [UnmanagedCallersOnly]
            private static void GetSyncivAPPLE_Lazy(GLSync sync, SyncParameterName pname, int count, int* length, int* values)
            {
                EntryPoints[9] = GLLoader.BindingsContext.GetProcAddress("glGetSyncivAPPLE");
                ((delegate* unmanaged<GLSync, SyncParameterName, int, int*, int*, void>)EntryPoints[9])(sync, pname, count, length, values);
            }
            
            static APPLE()
            {
                EntryPoints = new IntPtr[10];
                EntryPoints[0] = (IntPtr)(delegate* unmanaged<uint, uint, int, int, void>)&CopyTextureLevelsAPPLE_Lazy;
                EntryPoints[1] = (IntPtr)(delegate* unmanaged<RenderbufferTarget, int, InternalFormat, int, int, void>)&RenderbufferStorageMultisampleAPPLE_Lazy;
                EntryPoints[2] = (IntPtr)(delegate* unmanaged<void>)&ResolveMultisampleFramebufferAPPLE_Lazy;
                EntryPoints[3] = (IntPtr)(delegate* unmanaged<SyncCondition, SyncBehaviorFlags, IntPtr>)&FenceSyncAPPLE_Lazy;
                EntryPoints[4] = (IntPtr)(delegate* unmanaged<GLSync, byte>)&IsSyncAPPLE_Lazy;
                EntryPoints[5] = (IntPtr)(delegate* unmanaged<GLSync, void>)&DeleteSyncAPPLE_Lazy;
                EntryPoints[6] = (IntPtr)(delegate* unmanaged<GLSync, SyncObjectMask, ulong, SyncStatus>)&ClientWaitSyncAPPLE_Lazy;
                EntryPoints[7] = (IntPtr)(delegate* unmanaged<GLSync, SyncBehaviorFlags, ulong, void>)&WaitSyncAPPLE_Lazy;
                EntryPoints[8] = (IntPtr)(delegate* unmanaged<GetPName, long*, void>)&GetInteger64vAPPLE_Lazy;
                EntryPoints[9] = (IntPtr)(delegate* unmanaged<GLSync, SyncParameterName, int, int*, int*, void>)&GetSyncivAPPLE_Lazy;
            }
            public static void LoadAllFunctions(IBindingsContext context)
            {
                EntryPoints[0] = context.GetProcAddress("glCopyTextureLevelsAPPLE");
                EntryPoints[1] = context.GetProcAddress("glRenderbufferStorageMultisampleAPPLE");
                EntryPoints[2] = context.GetProcAddress("glResolveMultisampleFramebufferAPPLE");
                EntryPoints[3] = context.GetProcAddress("glFenceSyncAPPLE");
                EntryPoints[4] = context.GetProcAddress("glIsSyncAPPLE");
                EntryPoints[5] = context.GetProcAddress("glDeleteSyncAPPLE");
                EntryPoints[6] = context.GetProcAddress("glClientWaitSyncAPPLE");
                EntryPoints[7] = context.GetProcAddress("glWaitSyncAPPLE");
                EntryPoints[8] = context.GetProcAddress("glGetInteger64vAPPLE");
                EntryPoints[9] = context.GetProcAddress("glGetSyncivAPPLE");
            }
        }
        public static unsafe partial class EXT
        {
            private static IntPtr[] EntryPoints;
            
            /// <summary> <b>[requires: GL_EXT_blend_minmax]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BlendEquationEXT(BlendEquationModeEXT mode) => ((delegate* unmanaged<BlendEquationModeEXT, void>)EntryPoints[0])(mode);
            [UnmanagedCallersOnly]
            private static void BlendEquationEXT_Lazy(BlendEquationModeEXT mode)
            {
                EntryPoints[0] = GLLoader.BindingsContext.GetProcAddress("glBlendEquationEXT");
                ((delegate* unmanaged<BlendEquationModeEXT, void>)EntryPoints[0])(mode);
            }
            
            /// <summary> <b>[requires: GL_EXT_debug_marker]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void InsertEventMarkerEXT(int length, byte* marker) => ((delegate* unmanaged<int, byte*, void>)EntryPoints[1])(length, marker);
            [UnmanagedCallersOnly]
            private static void InsertEventMarkerEXT_Lazy(int length, byte* marker)
            {
                EntryPoints[1] = GLLoader.BindingsContext.GetProcAddress("glInsertEventMarkerEXT");
                ((delegate* unmanaged<int, byte*, void>)EntryPoints[1])(length, marker);
            }
            
            /// <summary> <b>[requires: GL_EXT_debug_marker]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PushGroupMarkerEXT(int length, byte* marker) => ((delegate* unmanaged<int, byte*, void>)EntryPoints[2])(length, marker);
            [UnmanagedCallersOnly]
            private static void PushGroupMarkerEXT_Lazy(int length, byte* marker)
            {
                EntryPoints[2] = GLLoader.BindingsContext.GetProcAddress("glPushGroupMarkerEXT");
                ((delegate* unmanaged<int, byte*, void>)EntryPoints[2])(length, marker);
            }
            
            /// <summary> <b>[requires: GL_EXT_debug_marker]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PopGroupMarkerEXT() => ((delegate* unmanaged<void>)EntryPoints[3])();
            [UnmanagedCallersOnly]
            private static void PopGroupMarkerEXT_Lazy()
            {
                EntryPoints[3] = GLLoader.BindingsContext.GetProcAddress("glPopGroupMarkerEXT");
                ((delegate* unmanaged<void>)EntryPoints[3])();
            }
            
            /// <summary> <b>[requires: GL_EXT_discard_framebuffer]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DiscardFramebufferEXT(FramebufferTarget target, int numAttachments, InvalidateFramebufferAttachment* attachments) => ((delegate* unmanaged<FramebufferTarget, int, InvalidateFramebufferAttachment*, void>)EntryPoints[4])(target, numAttachments, attachments);
            [UnmanagedCallersOnly]
            private static void DiscardFramebufferEXT_Lazy(FramebufferTarget target, int numAttachments, InvalidateFramebufferAttachment* attachments)
            {
                EntryPoints[4] = GLLoader.BindingsContext.GetProcAddress("glDiscardFramebufferEXT");
                ((delegate* unmanaged<FramebufferTarget, int, InvalidateFramebufferAttachment*, void>)EntryPoints[4])(target, numAttachments, attachments);
            }
            
            /// <summary> <b>[requires: GL_EXT_map_buffer_range]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void* MapBufferRangeEXT(BufferTargetARB target, IntPtr offset, nint length, MapBufferAccessMask access) => ((delegate* unmanaged<BufferTargetARB, IntPtr, nint, MapBufferAccessMask, void*>)EntryPoints[5])(target, offset, length, access);
            [UnmanagedCallersOnly]
            private static void* MapBufferRangeEXT_Lazy(BufferTargetARB target, IntPtr offset, nint length, MapBufferAccessMask access)
            {
                EntryPoints[5] = GLLoader.BindingsContext.GetProcAddress("glMapBufferRangeEXT");
                return ((delegate* unmanaged<BufferTargetARB, IntPtr, nint, MapBufferAccessMask, void*>)EntryPoints[5])(target, offset, length, access);
            }
            
            /// <summary> <b>[requires: GL_EXT_map_buffer_range]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FlushMappedBufferRangeEXT(BufferTargetARB target, IntPtr offset, nint length) => ((delegate* unmanaged<BufferTargetARB, IntPtr, nint, void>)EntryPoints[6])(target, offset, length);
            [UnmanagedCallersOnly]
            private static void FlushMappedBufferRangeEXT_Lazy(BufferTargetARB target, IntPtr offset, nint length)
            {
                EntryPoints[6] = GLLoader.BindingsContext.GetProcAddress("glFlushMappedBufferRangeEXT");
                ((delegate* unmanaged<BufferTargetARB, IntPtr, nint, void>)EntryPoints[6])(target, offset, length);
            }
            
            /// <summary> <b>[requires: GL_EXT_multi_draw_arrays]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiDrawArraysEXT(PrimitiveType mode, int* first, int* count, int primcount) => ((delegate* unmanaged<PrimitiveType, int*, int*, int, void>)EntryPoints[7])(mode, first, count, primcount);
            [UnmanagedCallersOnly]
            private static void MultiDrawArraysEXT_Lazy(PrimitiveType mode, int* first, int* count, int primcount)
            {
                EntryPoints[7] = GLLoader.BindingsContext.GetProcAddress("glMultiDrawArraysEXT");
                ((delegate* unmanaged<PrimitiveType, int*, int*, int, void>)EntryPoints[7])(mode, first, count, primcount);
            }
            
            /// <summary> <b>[requires: GL_EXT_multi_draw_arrays]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiDrawElementsEXT(PrimitiveType mode, int* count, DrawElementsType type, void** indices, int primcount) => ((delegate* unmanaged<PrimitiveType, int*, DrawElementsType, void**, int, void>)EntryPoints[8])(mode, count, type, indices, primcount);
            [UnmanagedCallersOnly]
            private static void MultiDrawElementsEXT_Lazy(PrimitiveType mode, int* count, DrawElementsType type, void** indices, int primcount)
            {
                EntryPoints[8] = GLLoader.BindingsContext.GetProcAddress("glMultiDrawElementsEXT");
                ((delegate* unmanaged<PrimitiveType, int*, DrawElementsType, void**, int, void>)EntryPoints[8])(mode, count, type, indices, primcount);
            }
            
            /// <summary> <b>[requires: GL_EXT_multisampled_render_to_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void RenderbufferStorageMultisampleEXT(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => ((delegate* unmanaged<RenderbufferTarget, int, InternalFormat, int, int, void>)EntryPoints[9])(target, samples, internalformat, width, height);
            [UnmanagedCallersOnly]
            private static void RenderbufferStorageMultisampleEXT_Lazy(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height)
            {
                EntryPoints[9] = GLLoader.BindingsContext.GetProcAddress("glRenderbufferStorageMultisampleEXT");
                ((delegate* unmanaged<RenderbufferTarget, int, InternalFormat, int, int, void>)EntryPoints[9])(target, samples, internalformat, width, height);
            }
            
            /// <summary> <b>[requires: GL_EXT_multisampled_render_to_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FramebufferTexture2DMultisampleEXT(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, TextureHandle texture, int level, int samples) => ((delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureTarget, TextureHandle, int, int, void>)EntryPoints[10])(target, attachment, textarget, texture, level, samples);
            [UnmanagedCallersOnly]
            private static void FramebufferTexture2DMultisampleEXT_Lazy(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, TextureHandle texture, int level, int samples)
            {
                EntryPoints[10] = GLLoader.BindingsContext.GetProcAddress("glFramebufferTexture2DMultisampleEXT");
                ((delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureTarget, TextureHandle, int, int, void>)EntryPoints[10])(target, attachment, textarget, texture, level, samples);
            }
            
            /// <summary> <b>[requires: GL_EXT_robustness]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static GraphicsResetStatus GetGraphicsResetStatusEXT() => ((delegate* unmanaged<GraphicsResetStatus>)EntryPoints[11])();
            [UnmanagedCallersOnly]
            private static GraphicsResetStatus GetGraphicsResetStatusEXT_Lazy()
            {
                EntryPoints[11] = GLLoader.BindingsContext.GetProcAddress("glGetGraphicsResetStatusEXT");
                return ((delegate* unmanaged<GraphicsResetStatus>)EntryPoints[11])();
            }
            
            /// <summary> <b>[requires: GL_EXT_robustness]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ReadnPixelsEXT(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data) => ((delegate* unmanaged<int, int, int, int, PixelFormat, PixelType, int, void*, void>)EntryPoints[12])(x, y, width, height, format, type, bufSize, data);
            [UnmanagedCallersOnly]
            private static void ReadnPixelsEXT_Lazy(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data)
            {
                EntryPoints[12] = GLLoader.BindingsContext.GetProcAddress("glReadnPixelsEXT");
                ((delegate* unmanaged<int, int, int, int, PixelFormat, PixelType, int, void*, void>)EntryPoints[12])(x, y, width, height, format, type, bufSize, data);
            }
            
            /// <summary> <b>[requires: GL_EXT_robustness]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetnUniformfvEXT(ProgramHandle program, int location, int bufSize, float* parameters) => ((delegate* unmanaged<ProgramHandle, int, int, float*, void>)EntryPoints[13])(program, location, bufSize, parameters);
            [UnmanagedCallersOnly]
            private static void GetnUniformfvEXT_Lazy(ProgramHandle program, int location, int bufSize, float* parameters)
            {
                EntryPoints[13] = GLLoader.BindingsContext.GetProcAddress("glGetnUniformfvEXT");
                ((delegate* unmanaged<ProgramHandle, int, int, float*, void>)EntryPoints[13])(program, location, bufSize, parameters);
            }
            
            /// <summary> <b>[requires: GL_EXT_robustness]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetnUniformivEXT(ProgramHandle program, int location, int bufSize, int* parameters) => ((delegate* unmanaged<ProgramHandle, int, int, int*, void>)EntryPoints[14])(program, location, bufSize, parameters);
            [UnmanagedCallersOnly]
            private static void GetnUniformivEXT_Lazy(ProgramHandle program, int location, int bufSize, int* parameters)
            {
                EntryPoints[14] = GLLoader.BindingsContext.GetProcAddress("glGetnUniformivEXT");
                ((delegate* unmanaged<ProgramHandle, int, int, int*, void>)EntryPoints[14])(program, location, bufSize, parameters);
            }
            
            /// <summary> <b>[requires: GL_EXT_texture_storage]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexStorage1DEXT(TextureTarget target, int levels, SizedInternalFormat internalformat, int width) => ((delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, void>)EntryPoints[15])(target, levels, internalformat, width);
            [UnmanagedCallersOnly]
            private static void TexStorage1DEXT_Lazy(TextureTarget target, int levels, SizedInternalFormat internalformat, int width)
            {
                EntryPoints[15] = GLLoader.BindingsContext.GetProcAddress("glTexStorage1DEXT");
                ((delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, void>)EntryPoints[15])(target, levels, internalformat, width);
            }
            
            /// <summary> <b>[requires: GL_EXT_texture_storage]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexStorage2DEXT(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height) => ((delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, int, void>)EntryPoints[16])(target, levels, internalformat, width, height);
            [UnmanagedCallersOnly]
            private static void TexStorage2DEXT_Lazy(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height)
            {
                EntryPoints[16] = GLLoader.BindingsContext.GetProcAddress("glTexStorage2DEXT");
                ((delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, int, void>)EntryPoints[16])(target, levels, internalformat, width, height);
            }
            
            /// <summary> <b>[requires: GL_EXT_texture_storage]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexStorage3DEXT(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height, int depth) => ((delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, int, int, void>)EntryPoints[17])(target, levels, internalformat, width, height, depth);
            [UnmanagedCallersOnly]
            private static void TexStorage3DEXT_Lazy(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height, int depth)
            {
                EntryPoints[17] = GLLoader.BindingsContext.GetProcAddress("glTexStorage3DEXT");
                ((delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, int, int, void>)EntryPoints[17])(target, levels, internalformat, width, height, depth);
            }
            
            /// <summary> <b>[requires: GL_EXT_texture_storage]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TextureStorage1DEXT(TextureHandle texture, All target, int levels, SizedInternalFormat internalformat, int width) => ((delegate* unmanaged<TextureHandle, All, int, SizedInternalFormat, int, void>)EntryPoints[18])(texture, target, levels, internalformat, width);
            [UnmanagedCallersOnly]
            private static void TextureStorage1DEXT_Lazy(TextureHandle texture, All target, int levels, SizedInternalFormat internalformat, int width)
            {
                EntryPoints[18] = GLLoader.BindingsContext.GetProcAddress("glTextureStorage1DEXT");
                ((delegate* unmanaged<TextureHandle, All, int, SizedInternalFormat, int, void>)EntryPoints[18])(texture, target, levels, internalformat, width);
            }
            
            /// <summary> <b>[requires: GL_EXT_texture_storage]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TextureStorage2DEXT(TextureHandle texture, All target, int levels, SizedInternalFormat internalformat, int width, int height) => ((delegate* unmanaged<TextureHandle, All, int, SizedInternalFormat, int, int, void>)EntryPoints[19])(texture, target, levels, internalformat, width, height);
            [UnmanagedCallersOnly]
            private static void TextureStorage2DEXT_Lazy(TextureHandle texture, All target, int levels, SizedInternalFormat internalformat, int width, int height)
            {
                EntryPoints[19] = GLLoader.BindingsContext.GetProcAddress("glTextureStorage2DEXT");
                ((delegate* unmanaged<TextureHandle, All, int, SizedInternalFormat, int, int, void>)EntryPoints[19])(texture, target, levels, internalformat, width, height);
            }
            
            /// <summary> <b>[requires: GL_EXT_texture_storage]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TextureStorage3DEXT(TextureHandle texture, All target, int levels, SizedInternalFormat internalformat, int width, int height, int depth) => ((delegate* unmanaged<TextureHandle, All, int, SizedInternalFormat, int, int, int, void>)EntryPoints[20])(texture, target, levels, internalformat, width, height, depth);
            [UnmanagedCallersOnly]
            private static void TextureStorage3DEXT_Lazy(TextureHandle texture, All target, int levels, SizedInternalFormat internalformat, int width, int height, int depth)
            {
                EntryPoints[20] = GLLoader.BindingsContext.GetProcAddress("glTextureStorage3DEXT");
                ((delegate* unmanaged<TextureHandle, All, int, SizedInternalFormat, int, int, int, void>)EntryPoints[20])(texture, target, levels, internalformat, width, height, depth);
            }
            
            static EXT()
            {
                EntryPoints = new IntPtr[21];
                EntryPoints[0] = (IntPtr)(delegate* unmanaged<BlendEquationModeEXT, void>)&BlendEquationEXT_Lazy;
                EntryPoints[1] = (IntPtr)(delegate* unmanaged<int, byte*, void>)&InsertEventMarkerEXT_Lazy;
                EntryPoints[2] = (IntPtr)(delegate* unmanaged<int, byte*, void>)&PushGroupMarkerEXT_Lazy;
                EntryPoints[3] = (IntPtr)(delegate* unmanaged<void>)&PopGroupMarkerEXT_Lazy;
                EntryPoints[4] = (IntPtr)(delegate* unmanaged<FramebufferTarget, int, InvalidateFramebufferAttachment*, void>)&DiscardFramebufferEXT_Lazy;
                EntryPoints[5] = (IntPtr)(delegate* unmanaged<BufferTargetARB, IntPtr, nint, MapBufferAccessMask, void*>)&MapBufferRangeEXT_Lazy;
                EntryPoints[6] = (IntPtr)(delegate* unmanaged<BufferTargetARB, IntPtr, nint, void>)&FlushMappedBufferRangeEXT_Lazy;
                EntryPoints[7] = (IntPtr)(delegate* unmanaged<PrimitiveType, int*, int*, int, void>)&MultiDrawArraysEXT_Lazy;
                EntryPoints[8] = (IntPtr)(delegate* unmanaged<PrimitiveType, int*, DrawElementsType, void**, int, void>)&MultiDrawElementsEXT_Lazy;
                EntryPoints[9] = (IntPtr)(delegate* unmanaged<RenderbufferTarget, int, InternalFormat, int, int, void>)&RenderbufferStorageMultisampleEXT_Lazy;
                EntryPoints[10] = (IntPtr)(delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureTarget, TextureHandle, int, int, void>)&FramebufferTexture2DMultisampleEXT_Lazy;
                EntryPoints[11] = (IntPtr)(delegate* unmanaged<GraphicsResetStatus>)&GetGraphicsResetStatusEXT_Lazy;
                EntryPoints[12] = (IntPtr)(delegate* unmanaged<int, int, int, int, PixelFormat, PixelType, int, void*, void>)&ReadnPixelsEXT_Lazy;
                EntryPoints[13] = (IntPtr)(delegate* unmanaged<ProgramHandle, int, int, float*, void>)&GetnUniformfvEXT_Lazy;
                EntryPoints[14] = (IntPtr)(delegate* unmanaged<ProgramHandle, int, int, int*, void>)&GetnUniformivEXT_Lazy;
                EntryPoints[15] = (IntPtr)(delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, void>)&TexStorage1DEXT_Lazy;
                EntryPoints[16] = (IntPtr)(delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, int, void>)&TexStorage2DEXT_Lazy;
                EntryPoints[17] = (IntPtr)(delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, int, int, void>)&TexStorage3DEXT_Lazy;
                EntryPoints[18] = (IntPtr)(delegate* unmanaged<TextureHandle, All, int, SizedInternalFormat, int, void>)&TextureStorage1DEXT_Lazy;
                EntryPoints[19] = (IntPtr)(delegate* unmanaged<TextureHandle, All, int, SizedInternalFormat, int, int, void>)&TextureStorage2DEXT_Lazy;
                EntryPoints[20] = (IntPtr)(delegate* unmanaged<TextureHandle, All, int, SizedInternalFormat, int, int, int, void>)&TextureStorage3DEXT_Lazy;
            }
            public static void LoadAllFunctions(IBindingsContext context)
            {
                EntryPoints[0] = context.GetProcAddress("glBlendEquationEXT");
                EntryPoints[1] = context.GetProcAddress("glInsertEventMarkerEXT");
                EntryPoints[2] = context.GetProcAddress("glPushGroupMarkerEXT");
                EntryPoints[3] = context.GetProcAddress("glPopGroupMarkerEXT");
                EntryPoints[4] = context.GetProcAddress("glDiscardFramebufferEXT");
                EntryPoints[5] = context.GetProcAddress("glMapBufferRangeEXT");
                EntryPoints[6] = context.GetProcAddress("glFlushMappedBufferRangeEXT");
                EntryPoints[7] = context.GetProcAddress("glMultiDrawArraysEXT");
                EntryPoints[8] = context.GetProcAddress("glMultiDrawElementsEXT");
                EntryPoints[9] = context.GetProcAddress("glRenderbufferStorageMultisampleEXT");
                EntryPoints[10] = context.GetProcAddress("glFramebufferTexture2DMultisampleEXT");
                EntryPoints[11] = context.GetProcAddress("glGetGraphicsResetStatusEXT");
                EntryPoints[12] = context.GetProcAddress("glReadnPixelsEXT");
                EntryPoints[13] = context.GetProcAddress("glGetnUniformfvEXT");
                EntryPoints[14] = context.GetProcAddress("glGetnUniformivEXT");
                EntryPoints[15] = context.GetProcAddress("glTexStorage1DEXT");
                EntryPoints[16] = context.GetProcAddress("glTexStorage2DEXT");
                EntryPoints[17] = context.GetProcAddress("glTexStorage3DEXT");
                EntryPoints[18] = context.GetProcAddress("glTextureStorage1DEXT");
                EntryPoints[19] = context.GetProcAddress("glTextureStorage2DEXT");
                EntryPoints[20] = context.GetProcAddress("glTextureStorage3DEXT");
            }
        }
        public static unsafe partial class IMG
        {
            private static IntPtr[] EntryPoints;
            
            /// <summary> <b>[requires: GL_IMG_multisampled_render_to_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void RenderbufferStorageMultisampleIMG(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => ((delegate* unmanaged<RenderbufferTarget, int, InternalFormat, int, int, void>)EntryPoints[0])(target, samples, internalformat, width, height);
            [UnmanagedCallersOnly]
            private static void RenderbufferStorageMultisampleIMG_Lazy(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height)
            {
                EntryPoints[0] = GLLoader.BindingsContext.GetProcAddress("glRenderbufferStorageMultisampleIMG");
                ((delegate* unmanaged<RenderbufferTarget, int, InternalFormat, int, int, void>)EntryPoints[0])(target, samples, internalformat, width, height);
            }
            
            /// <summary> <b>[requires: GL_IMG_multisampled_render_to_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FramebufferTexture2DMultisampleIMG(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, TextureHandle texture, int level, int samples) => ((delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureTarget, TextureHandle, int, int, void>)EntryPoints[1])(target, attachment, textarget, texture, level, samples);
            [UnmanagedCallersOnly]
            private static void FramebufferTexture2DMultisampleIMG_Lazy(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, TextureHandle texture, int level, int samples)
            {
                EntryPoints[1] = GLLoader.BindingsContext.GetProcAddress("glFramebufferTexture2DMultisampleIMG");
                ((delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureTarget, TextureHandle, int, int, void>)EntryPoints[1])(target, attachment, textarget, texture, level, samples);
            }
            
            /// <summary> <b>[requires: GL_IMG_user_clip_plane]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ClipPlanefIMG(ClipPlaneName p, float* eqn) => ((delegate* unmanaged<ClipPlaneName, float*, void>)EntryPoints[2])(p, eqn);
            [UnmanagedCallersOnly]
            private static void ClipPlanefIMG_Lazy(ClipPlaneName p, float* eqn)
            {
                EntryPoints[2] = GLLoader.BindingsContext.GetProcAddress("glClipPlanefIMG");
                ((delegate* unmanaged<ClipPlaneName, float*, void>)EntryPoints[2])(p, eqn);
            }
            
            /// <summary> <b>[requires: GL_IMG_user_clip_plane]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ClipPlanexIMG(ClipPlaneName p, int* eqn) => ((delegate* unmanaged<ClipPlaneName, int*, void>)EntryPoints[3])(p, eqn);
            [UnmanagedCallersOnly]
            private static void ClipPlanexIMG_Lazy(ClipPlaneName p, int* eqn)
            {
                EntryPoints[3] = GLLoader.BindingsContext.GetProcAddress("glClipPlanexIMG");
                ((delegate* unmanaged<ClipPlaneName, int*, void>)EntryPoints[3])(p, eqn);
            }
            
            static IMG()
            {
                EntryPoints = new IntPtr[4];
                EntryPoints[0] = (IntPtr)(delegate* unmanaged<RenderbufferTarget, int, InternalFormat, int, int, void>)&RenderbufferStorageMultisampleIMG_Lazy;
                EntryPoints[1] = (IntPtr)(delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureTarget, TextureHandle, int, int, void>)&FramebufferTexture2DMultisampleIMG_Lazy;
                EntryPoints[2] = (IntPtr)(delegate* unmanaged<ClipPlaneName, float*, void>)&ClipPlanefIMG_Lazy;
                EntryPoints[3] = (IntPtr)(delegate* unmanaged<ClipPlaneName, int*, void>)&ClipPlanexIMG_Lazy;
            }
            public static void LoadAllFunctions(IBindingsContext context)
            {
                EntryPoints[0] = context.GetProcAddress("glRenderbufferStorageMultisampleIMG");
                EntryPoints[1] = context.GetProcAddress("glFramebufferTexture2DMultisampleIMG");
                EntryPoints[2] = context.GetProcAddress("glClipPlanefIMG");
                EntryPoints[3] = context.GetProcAddress("glClipPlanexIMG");
            }
        }
        public static unsafe partial class KHR
        {
            private static IntPtr[] EntryPoints;
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, byte enabled) => ((delegate* unmanaged<DebugSource, DebugType, DebugSeverity, int, uint*, byte, void>)EntryPoints[0])(source, type, severity, count, ids, enabled);
            [UnmanagedCallersOnly]
            private static void DebugMessageControl_Lazy(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, byte enabled)
            {
                EntryPoints[0] = GLLoader.BindingsContext.GetProcAddress("glDebugMessageControl");
                ((delegate* unmanaged<DebugSource, DebugType, DebugSeverity, int, uint*, byte, void>)EntryPoints[0])(source, type, severity, count, ids, enabled);
            }
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* buf) => ((delegate* unmanaged<DebugSource, DebugType, uint, DebugSeverity, int, byte*, void>)EntryPoints[1])(source, type, id, severity, length, buf);
            [UnmanagedCallersOnly]
            private static void DebugMessageInsert_Lazy(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* buf)
            {
                EntryPoints[1] = GLLoader.BindingsContext.GetProcAddress("glDebugMessageInsert");
                ((delegate* unmanaged<DebugSource, DebugType, uint, DebugSeverity, int, byte*, void>)EntryPoints[1])(source, type, id, severity, length, buf);
            }
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DebugMessageCallback(IntPtr callback, void* userParam) => ((delegate* unmanaged<IntPtr, void*, void>)EntryPoints[2])(callback, userParam);
            [UnmanagedCallersOnly]
            private static void DebugMessageCallback_Lazy(IntPtr callback, void* userParam)
            {
                EntryPoints[2] = GLLoader.BindingsContext.GetProcAddress("glDebugMessageCallback");
                ((delegate* unmanaged<IntPtr, void*, void>)EntryPoints[2])(callback, userParam);
            }
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static uint GetDebugMessageLog(uint count, int bufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, byte* messageLog) => ((delegate* unmanaged<uint, int, DebugSource*, DebugType*, uint*, DebugSeverity*, int*, byte*, uint>)EntryPoints[3])(count, bufSize, sources, types, ids, severities, lengths, messageLog);
            [UnmanagedCallersOnly]
            private static uint GetDebugMessageLog_Lazy(uint count, int bufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, byte* messageLog)
            {
                EntryPoints[3] = GLLoader.BindingsContext.GetProcAddress("glGetDebugMessageLog");
                return ((delegate* unmanaged<uint, int, DebugSource*, DebugType*, uint*, DebugSeverity*, int*, byte*, uint>)EntryPoints[3])(count, bufSize, sources, types, ids, severities, lengths, messageLog);
            }
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PushDebugGroup(DebugSource source, uint id, int length, byte* message) => ((delegate* unmanaged<DebugSource, uint, int, byte*, void>)EntryPoints[4])(source, id, length, message);
            [UnmanagedCallersOnly]
            private static void PushDebugGroup_Lazy(DebugSource source, uint id, int length, byte* message)
            {
                EntryPoints[4] = GLLoader.BindingsContext.GetProcAddress("glPushDebugGroup");
                ((delegate* unmanaged<DebugSource, uint, int, byte*, void>)EntryPoints[4])(source, id, length, message);
            }
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PopDebugGroup() => ((delegate* unmanaged<void>)EntryPoints[5])();
            [UnmanagedCallersOnly]
            private static void PopDebugGroup_Lazy()
            {
                EntryPoints[5] = GLLoader.BindingsContext.GetProcAddress("glPopDebugGroup");
                ((delegate* unmanaged<void>)EntryPoints[5])();
            }
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ObjectLabel(ObjectIdentifier identifier, uint name, int length, byte* label) => ((delegate* unmanaged<ObjectIdentifier, uint, int, byte*, void>)EntryPoints[6])(identifier, name, length, label);
            [UnmanagedCallersOnly]
            private static void ObjectLabel_Lazy(ObjectIdentifier identifier, uint name, int length, byte* label)
            {
                EntryPoints[6] = GLLoader.BindingsContext.GetProcAddress("glObjectLabel");
                ((delegate* unmanaged<ObjectIdentifier, uint, int, byte*, void>)EntryPoints[6])(identifier, name, length, label);
            }
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetObjectLabel(ObjectIdentifier identifier, uint name, int bufSize, int* length, byte* label) => ((delegate* unmanaged<ObjectIdentifier, uint, int, int*, byte*, void>)EntryPoints[7])(identifier, name, bufSize, length, label);
            [UnmanagedCallersOnly]
            private static void GetObjectLabel_Lazy(ObjectIdentifier identifier, uint name, int bufSize, int* length, byte* label)
            {
                EntryPoints[7] = GLLoader.BindingsContext.GetProcAddress("glGetObjectLabel");
                ((delegate* unmanaged<ObjectIdentifier, uint, int, int*, byte*, void>)EntryPoints[7])(identifier, name, bufSize, length, label);
            }
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ObjectPtrLabel(void* ptr, int length, byte* label) => ((delegate* unmanaged<void*, int, byte*, void>)EntryPoints[8])(ptr, length, label);
            [UnmanagedCallersOnly]
            private static void ObjectPtrLabel_Lazy(void* ptr, int length, byte* label)
            {
                EntryPoints[8] = GLLoader.BindingsContext.GetProcAddress("glObjectPtrLabel");
                ((delegate* unmanaged<void*, int, byte*, void>)EntryPoints[8])(ptr, length, label);
            }
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetObjectPtrLabel(void* ptr, int bufSize, int* length, byte* label) => ((delegate* unmanaged<void*, int, int*, byte*, void>)EntryPoints[9])(ptr, bufSize, length, label);
            [UnmanagedCallersOnly]
            private static void GetObjectPtrLabel_Lazy(void* ptr, int bufSize, int* length, byte* label)
            {
                EntryPoints[9] = GLLoader.BindingsContext.GetProcAddress("glGetObjectPtrLabel");
                ((delegate* unmanaged<void*, int, int*, byte*, void>)EntryPoints[9])(ptr, bufSize, length, label);
            }
            
            /// <summary> <b>[requires: v1.0 | GL_KHR_debug]</b> Return the address of the specified pointer. </summary>
            /// <param name="pname"> Specifies the array or buffer pointer to be returned. Accepted symbolic names are GL_COLOR_ARRAY_POINTER, GL_MATRIX_INDEX_ARRAY_POINTER_OES, GL_NORMAL_ARRAY_POINTER, GL_POINT_SIZE_ARRAY_POINTER_OES, GL_TEXTURE_COORD_ARRAY_POINTER, and GL_VERTEX_ARRAY_POINTER., and GL_WEIGHT_ARRAY_POINTER_OES. </param>
            /// <param name="parameters"> Returns the pointer value specified by pname. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glGetPointerv.xml" /></remarks>
            public static void GetPointerv(GetPointervPName pname, void** parameters) => ((delegate* unmanaged<GetPointervPName, void**, void>)EntryPoints[10])(pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetPointerv_Lazy(GetPointervPName pname, void** parameters)
            {
                EntryPoints[10] = GLLoader.BindingsContext.GetProcAddress("glGetPointerv");
                ((delegate* unmanaged<GetPointervPName, void**, void>)EntryPoints[10])(pname, parameters);
            }
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DebugMessageControlKHR(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, byte enabled) => ((delegate* unmanaged<DebugSource, DebugType, DebugSeverity, int, uint*, byte, void>)EntryPoints[11])(source, type, severity, count, ids, enabled);
            [UnmanagedCallersOnly]
            private static void DebugMessageControlKHR_Lazy(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, byte enabled)
            {
                EntryPoints[11] = GLLoader.BindingsContext.GetProcAddress("glDebugMessageControlKHR");
                ((delegate* unmanaged<DebugSource, DebugType, DebugSeverity, int, uint*, byte, void>)EntryPoints[11])(source, type, severity, count, ids, enabled);
            }
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DebugMessageInsertKHR(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* buf) => ((delegate* unmanaged<DebugSource, DebugType, uint, DebugSeverity, int, byte*, void>)EntryPoints[12])(source, type, id, severity, length, buf);
            [UnmanagedCallersOnly]
            private static void DebugMessageInsertKHR_Lazy(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* buf)
            {
                EntryPoints[12] = GLLoader.BindingsContext.GetProcAddress("glDebugMessageInsertKHR");
                ((delegate* unmanaged<DebugSource, DebugType, uint, DebugSeverity, int, byte*, void>)EntryPoints[12])(source, type, id, severity, length, buf);
            }
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DebugMessageCallbackKHR(IntPtr callback, void* userParam) => ((delegate* unmanaged<IntPtr, void*, void>)EntryPoints[13])(callback, userParam);
            [UnmanagedCallersOnly]
            private static void DebugMessageCallbackKHR_Lazy(IntPtr callback, void* userParam)
            {
                EntryPoints[13] = GLLoader.BindingsContext.GetProcAddress("glDebugMessageCallbackKHR");
                ((delegate* unmanaged<IntPtr, void*, void>)EntryPoints[13])(callback, userParam);
            }
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static uint GetDebugMessageLogKHR(uint count, int bufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, byte* messageLog) => ((delegate* unmanaged<uint, int, DebugSource*, DebugType*, uint*, DebugSeverity*, int*, byte*, uint>)EntryPoints[14])(count, bufSize, sources, types, ids, severities, lengths, messageLog);
            [UnmanagedCallersOnly]
            private static uint GetDebugMessageLogKHR_Lazy(uint count, int bufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, byte* messageLog)
            {
                EntryPoints[14] = GLLoader.BindingsContext.GetProcAddress("glGetDebugMessageLogKHR");
                return ((delegate* unmanaged<uint, int, DebugSource*, DebugType*, uint*, DebugSeverity*, int*, byte*, uint>)EntryPoints[14])(count, bufSize, sources, types, ids, severities, lengths, messageLog);
            }
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PushDebugGroupKHR(DebugSource source, uint id, int length, byte* message) => ((delegate* unmanaged<DebugSource, uint, int, byte*, void>)EntryPoints[15])(source, id, length, message);
            [UnmanagedCallersOnly]
            private static void PushDebugGroupKHR_Lazy(DebugSource source, uint id, int length, byte* message)
            {
                EntryPoints[15] = GLLoader.BindingsContext.GetProcAddress("glPushDebugGroupKHR");
                ((delegate* unmanaged<DebugSource, uint, int, byte*, void>)EntryPoints[15])(source, id, length, message);
            }
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PopDebugGroupKHR() => ((delegate* unmanaged<void>)EntryPoints[16])();
            [UnmanagedCallersOnly]
            private static void PopDebugGroupKHR_Lazy()
            {
                EntryPoints[16] = GLLoader.BindingsContext.GetProcAddress("glPopDebugGroupKHR");
                ((delegate* unmanaged<void>)EntryPoints[16])();
            }
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ObjectLabelKHR(ObjectIdentifier identifier, uint name, int length, byte* label) => ((delegate* unmanaged<ObjectIdentifier, uint, int, byte*, void>)EntryPoints[17])(identifier, name, length, label);
            [UnmanagedCallersOnly]
            private static void ObjectLabelKHR_Lazy(ObjectIdentifier identifier, uint name, int length, byte* label)
            {
                EntryPoints[17] = GLLoader.BindingsContext.GetProcAddress("glObjectLabelKHR");
                ((delegate* unmanaged<ObjectIdentifier, uint, int, byte*, void>)EntryPoints[17])(identifier, name, length, label);
            }
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetObjectLabelKHR(All identifier, uint name, int bufSize, int* length, byte* label) => ((delegate* unmanaged<All, uint, int, int*, byte*, void>)EntryPoints[18])(identifier, name, bufSize, length, label);
            [UnmanagedCallersOnly]
            private static void GetObjectLabelKHR_Lazy(All identifier, uint name, int bufSize, int* length, byte* label)
            {
                EntryPoints[18] = GLLoader.BindingsContext.GetProcAddress("glGetObjectLabelKHR");
                ((delegate* unmanaged<All, uint, int, int*, byte*, void>)EntryPoints[18])(identifier, name, bufSize, length, label);
            }
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ObjectPtrLabelKHR(void* ptr, int length, byte* label) => ((delegate* unmanaged<void*, int, byte*, void>)EntryPoints[19])(ptr, length, label);
            [UnmanagedCallersOnly]
            private static void ObjectPtrLabelKHR_Lazy(void* ptr, int length, byte* label)
            {
                EntryPoints[19] = GLLoader.BindingsContext.GetProcAddress("glObjectPtrLabelKHR");
                ((delegate* unmanaged<void*, int, byte*, void>)EntryPoints[19])(ptr, length, label);
            }
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetObjectPtrLabelKHR(void* ptr, int bufSize, int* length, byte* label) => ((delegate* unmanaged<void*, int, int*, byte*, void>)EntryPoints[20])(ptr, bufSize, length, label);
            [UnmanagedCallersOnly]
            private static void GetObjectPtrLabelKHR_Lazy(void* ptr, int bufSize, int* length, byte* label)
            {
                EntryPoints[20] = GLLoader.BindingsContext.GetProcAddress("glGetObjectPtrLabelKHR");
                ((delegate* unmanaged<void*, int, int*, byte*, void>)EntryPoints[20])(ptr, bufSize, length, label);
            }
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetPointervKHR(All pname, void** parameters) => ((delegate* unmanaged<All, void**, void>)EntryPoints[21])(pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetPointervKHR_Lazy(All pname, void** parameters)
            {
                EntryPoints[21] = GLLoader.BindingsContext.GetProcAddress("glGetPointervKHR");
                ((delegate* unmanaged<All, void**, void>)EntryPoints[21])(pname, parameters);
            }
            
            static KHR()
            {
                EntryPoints = new IntPtr[22];
                EntryPoints[0] = (IntPtr)(delegate* unmanaged<DebugSource, DebugType, DebugSeverity, int, uint*, byte, void>)&DebugMessageControl_Lazy;
                EntryPoints[1] = (IntPtr)(delegate* unmanaged<DebugSource, DebugType, uint, DebugSeverity, int, byte*, void>)&DebugMessageInsert_Lazy;
                EntryPoints[2] = (IntPtr)(delegate* unmanaged<IntPtr, void*, void>)&DebugMessageCallback_Lazy;
                EntryPoints[3] = (IntPtr)(delegate* unmanaged<uint, int, DebugSource*, DebugType*, uint*, DebugSeverity*, int*, byte*, uint>)&GetDebugMessageLog_Lazy;
                EntryPoints[4] = (IntPtr)(delegate* unmanaged<DebugSource, uint, int, byte*, void>)&PushDebugGroup_Lazy;
                EntryPoints[5] = (IntPtr)(delegate* unmanaged<void>)&PopDebugGroup_Lazy;
                EntryPoints[6] = (IntPtr)(delegate* unmanaged<ObjectIdentifier, uint, int, byte*, void>)&ObjectLabel_Lazy;
                EntryPoints[7] = (IntPtr)(delegate* unmanaged<ObjectIdentifier, uint, int, int*, byte*, void>)&GetObjectLabel_Lazy;
                EntryPoints[8] = (IntPtr)(delegate* unmanaged<void*, int, byte*, void>)&ObjectPtrLabel_Lazy;
                EntryPoints[9] = (IntPtr)(delegate* unmanaged<void*, int, int*, byte*, void>)&GetObjectPtrLabel_Lazy;
                EntryPoints[10] = (IntPtr)(delegate* unmanaged<GetPointervPName, void**, void>)&GetPointerv_Lazy;
                EntryPoints[11] = (IntPtr)(delegate* unmanaged<DebugSource, DebugType, DebugSeverity, int, uint*, byte, void>)&DebugMessageControlKHR_Lazy;
                EntryPoints[12] = (IntPtr)(delegate* unmanaged<DebugSource, DebugType, uint, DebugSeverity, int, byte*, void>)&DebugMessageInsertKHR_Lazy;
                EntryPoints[13] = (IntPtr)(delegate* unmanaged<IntPtr, void*, void>)&DebugMessageCallbackKHR_Lazy;
                EntryPoints[14] = (IntPtr)(delegate* unmanaged<uint, int, DebugSource*, DebugType*, uint*, DebugSeverity*, int*, byte*, uint>)&GetDebugMessageLogKHR_Lazy;
                EntryPoints[15] = (IntPtr)(delegate* unmanaged<DebugSource, uint, int, byte*, void>)&PushDebugGroupKHR_Lazy;
                EntryPoints[16] = (IntPtr)(delegate* unmanaged<void>)&PopDebugGroupKHR_Lazy;
                EntryPoints[17] = (IntPtr)(delegate* unmanaged<ObjectIdentifier, uint, int, byte*, void>)&ObjectLabelKHR_Lazy;
                EntryPoints[18] = (IntPtr)(delegate* unmanaged<All, uint, int, int*, byte*, void>)&GetObjectLabelKHR_Lazy;
                EntryPoints[19] = (IntPtr)(delegate* unmanaged<void*, int, byte*, void>)&ObjectPtrLabelKHR_Lazy;
                EntryPoints[20] = (IntPtr)(delegate* unmanaged<void*, int, int*, byte*, void>)&GetObjectPtrLabelKHR_Lazy;
                EntryPoints[21] = (IntPtr)(delegate* unmanaged<All, void**, void>)&GetPointervKHR_Lazy;
            }
            public static void LoadAllFunctions(IBindingsContext context)
            {
                EntryPoints[0] = context.GetProcAddress("glDebugMessageControl");
                EntryPoints[1] = context.GetProcAddress("glDebugMessageInsert");
                EntryPoints[2] = context.GetProcAddress("glDebugMessageCallback");
                EntryPoints[3] = context.GetProcAddress("glGetDebugMessageLog");
                EntryPoints[4] = context.GetProcAddress("glPushDebugGroup");
                EntryPoints[5] = context.GetProcAddress("glPopDebugGroup");
                EntryPoints[6] = context.GetProcAddress("glObjectLabel");
                EntryPoints[7] = context.GetProcAddress("glGetObjectLabel");
                EntryPoints[8] = context.GetProcAddress("glObjectPtrLabel");
                EntryPoints[9] = context.GetProcAddress("glGetObjectPtrLabel");
                EntryPoints[10] = context.GetProcAddress("glGetPointerv");
                EntryPoints[11] = context.GetProcAddress("glDebugMessageControlKHR");
                EntryPoints[12] = context.GetProcAddress("glDebugMessageInsertKHR");
                EntryPoints[13] = context.GetProcAddress("glDebugMessageCallbackKHR");
                EntryPoints[14] = context.GetProcAddress("glGetDebugMessageLogKHR");
                EntryPoints[15] = context.GetProcAddress("glPushDebugGroupKHR");
                EntryPoints[16] = context.GetProcAddress("glPopDebugGroupKHR");
                EntryPoints[17] = context.GetProcAddress("glObjectLabelKHR");
                EntryPoints[18] = context.GetProcAddress("glGetObjectLabelKHR");
                EntryPoints[19] = context.GetProcAddress("glObjectPtrLabelKHR");
                EntryPoints[20] = context.GetProcAddress("glGetObjectPtrLabelKHR");
                EntryPoints[21] = context.GetProcAddress("glGetPointervKHR");
            }
        }
        public static unsafe partial class NV
        {
            private static IntPtr[] EntryPoints;
            
            /// <summary> <b>[requires: GL_NV_fence]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DeleteFencesNV(int n, uint* fences) => ((delegate* unmanaged<int, uint*, void>)EntryPoints[0])(n, fences);
            [UnmanagedCallersOnly]
            private static void DeleteFencesNV_Lazy(int n, uint* fences)
            {
                EntryPoints[0] = GLLoader.BindingsContext.GetProcAddress("glDeleteFencesNV");
                ((delegate* unmanaged<int, uint*, void>)EntryPoints[0])(n, fences);
            }
            
            /// <summary> <b>[requires: GL_NV_fence]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GenFencesNV(int n, uint* fences) => ((delegate* unmanaged<int, uint*, void>)EntryPoints[1])(n, fences);
            [UnmanagedCallersOnly]
            private static void GenFencesNV_Lazy(int n, uint* fences)
            {
                EntryPoints[1] = GLLoader.BindingsContext.GetProcAddress("glGenFencesNV");
                ((delegate* unmanaged<int, uint*, void>)EntryPoints[1])(n, fences);
            }
            
            /// <summary> <b>[requires: GL_NV_fence]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static byte IsFenceNV(uint fence) => ((delegate* unmanaged<uint, byte>)EntryPoints[2])(fence);
            [UnmanagedCallersOnly]
            private static byte IsFenceNV_Lazy(uint fence)
            {
                EntryPoints[2] = GLLoader.BindingsContext.GetProcAddress("glIsFenceNV");
                return ((delegate* unmanaged<uint, byte>)EntryPoints[2])(fence);
            }
            
            /// <summary> <b>[requires: GL_NV_fence]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static byte TestFenceNV(uint fence) => ((delegate* unmanaged<uint, byte>)EntryPoints[3])(fence);
            [UnmanagedCallersOnly]
            private static byte TestFenceNV_Lazy(uint fence)
            {
                EntryPoints[3] = GLLoader.BindingsContext.GetProcAddress("glTestFenceNV");
                return ((delegate* unmanaged<uint, byte>)EntryPoints[3])(fence);
            }
            
            /// <summary> <b>[requires: GL_NV_fence]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetFenceivNV(uint fence, FenceParameterNameNV pname, int* parameters) => ((delegate* unmanaged<uint, FenceParameterNameNV, int*, void>)EntryPoints[4])(fence, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetFenceivNV_Lazy(uint fence, FenceParameterNameNV pname, int* parameters)
            {
                EntryPoints[4] = GLLoader.BindingsContext.GetProcAddress("glGetFenceivNV");
                ((delegate* unmanaged<uint, FenceParameterNameNV, int*, void>)EntryPoints[4])(fence, pname, parameters);
            }
            
            /// <summary> <b>[requires: GL_NV_fence]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FinishFenceNV(uint fence) => ((delegate* unmanaged<uint, void>)EntryPoints[5])(fence);
            [UnmanagedCallersOnly]
            private static void FinishFenceNV_Lazy(uint fence)
            {
                EntryPoints[5] = GLLoader.BindingsContext.GetProcAddress("glFinishFenceNV");
                ((delegate* unmanaged<uint, void>)EntryPoints[5])(fence);
            }
            
            /// <summary> <b>[requires: GL_NV_fence]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void SetFenceNV(uint fence, FenceConditionNV condition) => ((delegate* unmanaged<uint, FenceConditionNV, void>)EntryPoints[6])(fence, condition);
            [UnmanagedCallersOnly]
            private static void SetFenceNV_Lazy(uint fence, FenceConditionNV condition)
            {
                EntryPoints[6] = GLLoader.BindingsContext.GetProcAddress("glSetFenceNV");
                ((delegate* unmanaged<uint, FenceConditionNV, void>)EntryPoints[6])(fence, condition);
            }
            
            static NV()
            {
                EntryPoints = new IntPtr[7];
                EntryPoints[0] = (IntPtr)(delegate* unmanaged<int, uint*, void>)&DeleteFencesNV_Lazy;
                EntryPoints[1] = (IntPtr)(delegate* unmanaged<int, uint*, void>)&GenFencesNV_Lazy;
                EntryPoints[2] = (IntPtr)(delegate* unmanaged<uint, byte>)&IsFenceNV_Lazy;
                EntryPoints[3] = (IntPtr)(delegate* unmanaged<uint, byte>)&TestFenceNV_Lazy;
                EntryPoints[4] = (IntPtr)(delegate* unmanaged<uint, FenceParameterNameNV, int*, void>)&GetFenceivNV_Lazy;
                EntryPoints[5] = (IntPtr)(delegate* unmanaged<uint, void>)&FinishFenceNV_Lazy;
                EntryPoints[6] = (IntPtr)(delegate* unmanaged<uint, FenceConditionNV, void>)&SetFenceNV_Lazy;
            }
            public static void LoadAllFunctions(IBindingsContext context)
            {
                EntryPoints[0] = context.GetProcAddress("glDeleteFencesNV");
                EntryPoints[1] = context.GetProcAddress("glGenFencesNV");
                EntryPoints[2] = context.GetProcAddress("glIsFenceNV");
                EntryPoints[3] = context.GetProcAddress("glTestFenceNV");
                EntryPoints[4] = context.GetProcAddress("glGetFenceivNV");
                EntryPoints[5] = context.GetProcAddress("glFinishFenceNV");
                EntryPoints[6] = context.GetProcAddress("glSetFenceNV");
            }
        }
        public static unsafe partial class OES
        {
            private static IntPtr[] EntryPoints;
            
            /// <summary> <b>[requires: GL_OES_EGL_image]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void EGLImageTargetTexture2DOES(All target, void* image) => ((delegate* unmanaged<All, void*, void>)EntryPoints[0])(target, image);
            [UnmanagedCallersOnly]
            private static void EGLImageTargetTexture2DOES_Lazy(All target, void* image)
            {
                EntryPoints[0] = GLLoader.BindingsContext.GetProcAddress("glEGLImageTargetTexture2DOES");
                ((delegate* unmanaged<All, void*, void>)EntryPoints[0])(target, image);
            }
            
            /// <summary> <b>[requires: GL_OES_EGL_image]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void EGLImageTargetRenderbufferStorageOES(All target, void* image) => ((delegate* unmanaged<All, void*, void>)EntryPoints[1])(target, image);
            [UnmanagedCallersOnly]
            private static void EGLImageTargetRenderbufferStorageOES_Lazy(All target, void* image)
            {
                EntryPoints[1] = GLLoader.BindingsContext.GetProcAddress("glEGLImageTargetRenderbufferStorageOES");
                ((delegate* unmanaged<All, void*, void>)EntryPoints[1])(target, image);
            }
            
            /// <summary> <b>[requires: GL_OES_blend_equation_separate]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BlendEquationSeparateOES(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => ((delegate* unmanaged<BlendEquationModeEXT, BlendEquationModeEXT, void>)EntryPoints[2])(modeRGB, modeAlpha);
            [UnmanagedCallersOnly]
            private static void BlendEquationSeparateOES_Lazy(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha)
            {
                EntryPoints[2] = GLLoader.BindingsContext.GetProcAddress("glBlendEquationSeparateOES");
                ((delegate* unmanaged<BlendEquationModeEXT, BlendEquationModeEXT, void>)EntryPoints[2])(modeRGB, modeAlpha);
            }
            
            /// <summary> <b>[requires: GL_OES_blend_func_separate]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BlendFuncSeparateOES(BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha) => ((delegate* unmanaged<BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void>)EntryPoints[3])(srcRGB, dstRGB, srcAlpha, dstAlpha);
            [UnmanagedCallersOnly]
            private static void BlendFuncSeparateOES_Lazy(BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha)
            {
                EntryPoints[3] = GLLoader.BindingsContext.GetProcAddress("glBlendFuncSeparateOES");
                ((delegate* unmanaged<BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void>)EntryPoints[3])(srcRGB, dstRGB, srcAlpha, dstAlpha);
            }
            
            /// <summary> <b>[requires: GL_OES_blend_subtract]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BlendEquationOES(BlendEquationModeEXT mode) => ((delegate* unmanaged<BlendEquationModeEXT, void>)EntryPoints[4])(mode);
            [UnmanagedCallersOnly]
            private static void BlendEquationOES_Lazy(BlendEquationModeEXT mode)
            {
                EntryPoints[4] = GLLoader.BindingsContext.GetProcAddress("glBlendEquationOES");
                ((delegate* unmanaged<BlendEquationModeEXT, void>)EntryPoints[4])(mode);
            }
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiTexCoord1bOES(TextureUnit texture, sbyte s) => ((delegate* unmanaged<TextureUnit, sbyte, void>)EntryPoints[5])(texture, s);
            [UnmanagedCallersOnly]
            private static void MultiTexCoord1bOES_Lazy(TextureUnit texture, sbyte s)
            {
                EntryPoints[5] = GLLoader.BindingsContext.GetProcAddress("glMultiTexCoord1bOES");
                ((delegate* unmanaged<TextureUnit, sbyte, void>)EntryPoints[5])(texture, s);
            }
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiTexCoord1bvOES(TextureUnit texture, sbyte* coords) => ((delegate* unmanaged<TextureUnit, sbyte*, void>)EntryPoints[6])(texture, coords);
            [UnmanagedCallersOnly]
            private static void MultiTexCoord1bvOES_Lazy(TextureUnit texture, sbyte* coords)
            {
                EntryPoints[6] = GLLoader.BindingsContext.GetProcAddress("glMultiTexCoord1bvOES");
                ((delegate* unmanaged<TextureUnit, sbyte*, void>)EntryPoints[6])(texture, coords);
            }
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiTexCoord2bOES(TextureUnit texture, sbyte s, sbyte t) => ((delegate* unmanaged<TextureUnit, sbyte, sbyte, void>)EntryPoints[7])(texture, s, t);
            [UnmanagedCallersOnly]
            private static void MultiTexCoord2bOES_Lazy(TextureUnit texture, sbyte s, sbyte t)
            {
                EntryPoints[7] = GLLoader.BindingsContext.GetProcAddress("glMultiTexCoord2bOES");
                ((delegate* unmanaged<TextureUnit, sbyte, sbyte, void>)EntryPoints[7])(texture, s, t);
            }
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiTexCoord2bvOES(TextureUnit texture, sbyte* coords) => ((delegate* unmanaged<TextureUnit, sbyte*, void>)EntryPoints[8])(texture, coords);
            [UnmanagedCallersOnly]
            private static void MultiTexCoord2bvOES_Lazy(TextureUnit texture, sbyte* coords)
            {
                EntryPoints[8] = GLLoader.BindingsContext.GetProcAddress("glMultiTexCoord2bvOES");
                ((delegate* unmanaged<TextureUnit, sbyte*, void>)EntryPoints[8])(texture, coords);
            }
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiTexCoord3bOES(TextureUnit texture, sbyte s, sbyte t, sbyte r) => ((delegate* unmanaged<TextureUnit, sbyte, sbyte, sbyte, void>)EntryPoints[9])(texture, s, t, r);
            [UnmanagedCallersOnly]
            private static void MultiTexCoord3bOES_Lazy(TextureUnit texture, sbyte s, sbyte t, sbyte r)
            {
                EntryPoints[9] = GLLoader.BindingsContext.GetProcAddress("glMultiTexCoord3bOES");
                ((delegate* unmanaged<TextureUnit, sbyte, sbyte, sbyte, void>)EntryPoints[9])(texture, s, t, r);
            }
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiTexCoord3bvOES(TextureUnit texture, sbyte* coords) => ((delegate* unmanaged<TextureUnit, sbyte*, void>)EntryPoints[10])(texture, coords);
            [UnmanagedCallersOnly]
            private static void MultiTexCoord3bvOES_Lazy(TextureUnit texture, sbyte* coords)
            {
                EntryPoints[10] = GLLoader.BindingsContext.GetProcAddress("glMultiTexCoord3bvOES");
                ((delegate* unmanaged<TextureUnit, sbyte*, void>)EntryPoints[10])(texture, coords);
            }
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiTexCoord4bOES(TextureUnit texture, sbyte s, sbyte t, sbyte r, sbyte q) => ((delegate* unmanaged<TextureUnit, sbyte, sbyte, sbyte, sbyte, void>)EntryPoints[11])(texture, s, t, r, q);
            [UnmanagedCallersOnly]
            private static void MultiTexCoord4bOES_Lazy(TextureUnit texture, sbyte s, sbyte t, sbyte r, sbyte q)
            {
                EntryPoints[11] = GLLoader.BindingsContext.GetProcAddress("glMultiTexCoord4bOES");
                ((delegate* unmanaged<TextureUnit, sbyte, sbyte, sbyte, sbyte, void>)EntryPoints[11])(texture, s, t, r, q);
            }
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiTexCoord4bvOES(TextureUnit texture, sbyte* coords) => ((delegate* unmanaged<TextureUnit, sbyte*, void>)EntryPoints[12])(texture, coords);
            [UnmanagedCallersOnly]
            private static void MultiTexCoord4bvOES_Lazy(TextureUnit texture, sbyte* coords)
            {
                EntryPoints[12] = GLLoader.BindingsContext.GetProcAddress("glMultiTexCoord4bvOES");
                ((delegate* unmanaged<TextureUnit, sbyte*, void>)EntryPoints[12])(texture, coords);
            }
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexCoord1bOES(sbyte s) => ((delegate* unmanaged<sbyte, void>)EntryPoints[13])(s);
            [UnmanagedCallersOnly]
            private static void TexCoord1bOES_Lazy(sbyte s)
            {
                EntryPoints[13] = GLLoader.BindingsContext.GetProcAddress("glTexCoord1bOES");
                ((delegate* unmanaged<sbyte, void>)EntryPoints[13])(s);
            }
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexCoord1bvOES(sbyte* coords) => ((delegate* unmanaged<sbyte*, void>)EntryPoints[14])(coords);
            [UnmanagedCallersOnly]
            private static void TexCoord1bvOES_Lazy(sbyte* coords)
            {
                EntryPoints[14] = GLLoader.BindingsContext.GetProcAddress("glTexCoord1bvOES");
                ((delegate* unmanaged<sbyte*, void>)EntryPoints[14])(coords);
            }
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexCoord2bOES(sbyte s, sbyte t) => ((delegate* unmanaged<sbyte, sbyte, void>)EntryPoints[15])(s, t);
            [UnmanagedCallersOnly]
            private static void TexCoord2bOES_Lazy(sbyte s, sbyte t)
            {
                EntryPoints[15] = GLLoader.BindingsContext.GetProcAddress("glTexCoord2bOES");
                ((delegate* unmanaged<sbyte, sbyte, void>)EntryPoints[15])(s, t);
            }
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexCoord2bvOES(sbyte* coords) => ((delegate* unmanaged<sbyte*, void>)EntryPoints[16])(coords);
            [UnmanagedCallersOnly]
            private static void TexCoord2bvOES_Lazy(sbyte* coords)
            {
                EntryPoints[16] = GLLoader.BindingsContext.GetProcAddress("glTexCoord2bvOES");
                ((delegate* unmanaged<sbyte*, void>)EntryPoints[16])(coords);
            }
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexCoord3bOES(sbyte s, sbyte t, sbyte r) => ((delegate* unmanaged<sbyte, sbyte, sbyte, void>)EntryPoints[17])(s, t, r);
            [UnmanagedCallersOnly]
            private static void TexCoord3bOES_Lazy(sbyte s, sbyte t, sbyte r)
            {
                EntryPoints[17] = GLLoader.BindingsContext.GetProcAddress("glTexCoord3bOES");
                ((delegate* unmanaged<sbyte, sbyte, sbyte, void>)EntryPoints[17])(s, t, r);
            }
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexCoord3bvOES(sbyte* coords) => ((delegate* unmanaged<sbyte*, void>)EntryPoints[18])(coords);
            [UnmanagedCallersOnly]
            private static void TexCoord3bvOES_Lazy(sbyte* coords)
            {
                EntryPoints[18] = GLLoader.BindingsContext.GetProcAddress("glTexCoord3bvOES");
                ((delegate* unmanaged<sbyte*, void>)EntryPoints[18])(coords);
            }
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexCoord4bOES(sbyte s, sbyte t, sbyte r, sbyte q) => ((delegate* unmanaged<sbyte, sbyte, sbyte, sbyte, void>)EntryPoints[19])(s, t, r, q);
            [UnmanagedCallersOnly]
            private static void TexCoord4bOES_Lazy(sbyte s, sbyte t, sbyte r, sbyte q)
            {
                EntryPoints[19] = GLLoader.BindingsContext.GetProcAddress("glTexCoord4bOES");
                ((delegate* unmanaged<sbyte, sbyte, sbyte, sbyte, void>)EntryPoints[19])(s, t, r, q);
            }
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexCoord4bvOES(sbyte* coords) => ((delegate* unmanaged<sbyte*, void>)EntryPoints[20])(coords);
            [UnmanagedCallersOnly]
            private static void TexCoord4bvOES_Lazy(sbyte* coords)
            {
                EntryPoints[20] = GLLoader.BindingsContext.GetProcAddress("glTexCoord4bvOES");
                ((delegate* unmanaged<sbyte*, void>)EntryPoints[20])(coords);
            }
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Vertex2bOES(sbyte x, sbyte y) => ((delegate* unmanaged<sbyte, sbyte, void>)EntryPoints[21])(x, y);
            [UnmanagedCallersOnly]
            private static void Vertex2bOES_Lazy(sbyte x, sbyte y)
            {
                EntryPoints[21] = GLLoader.BindingsContext.GetProcAddress("glVertex2bOES");
                ((delegate* unmanaged<sbyte, sbyte, void>)EntryPoints[21])(x, y);
            }
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Vertex2bvOES(sbyte* coords) => ((delegate* unmanaged<sbyte*, void>)EntryPoints[22])(coords);
            [UnmanagedCallersOnly]
            private static void Vertex2bvOES_Lazy(sbyte* coords)
            {
                EntryPoints[22] = GLLoader.BindingsContext.GetProcAddress("glVertex2bvOES");
                ((delegate* unmanaged<sbyte*, void>)EntryPoints[22])(coords);
            }
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Vertex3bOES(sbyte x, sbyte y, sbyte z) => ((delegate* unmanaged<sbyte, sbyte, sbyte, void>)EntryPoints[23])(x, y, z);
            [UnmanagedCallersOnly]
            private static void Vertex3bOES_Lazy(sbyte x, sbyte y, sbyte z)
            {
                EntryPoints[23] = GLLoader.BindingsContext.GetProcAddress("glVertex3bOES");
                ((delegate* unmanaged<sbyte, sbyte, sbyte, void>)EntryPoints[23])(x, y, z);
            }
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Vertex3bvOES(sbyte* coords) => ((delegate* unmanaged<sbyte*, void>)EntryPoints[24])(coords);
            [UnmanagedCallersOnly]
            private static void Vertex3bvOES_Lazy(sbyte* coords)
            {
                EntryPoints[24] = GLLoader.BindingsContext.GetProcAddress("glVertex3bvOES");
                ((delegate* unmanaged<sbyte*, void>)EntryPoints[24])(coords);
            }
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Vertex4bOES(sbyte x, sbyte y, sbyte z, sbyte w) => ((delegate* unmanaged<sbyte, sbyte, sbyte, sbyte, void>)EntryPoints[25])(x, y, z, w);
            [UnmanagedCallersOnly]
            private static void Vertex4bOES_Lazy(sbyte x, sbyte y, sbyte z, sbyte w)
            {
                EntryPoints[25] = GLLoader.BindingsContext.GetProcAddress("glVertex4bOES");
                ((delegate* unmanaged<sbyte, sbyte, sbyte, sbyte, void>)EntryPoints[25])(x, y, z, w);
            }
            
            /// <summary> <b>[requires: GL_OES_byte_coordinates]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Vertex4bvOES(sbyte* coords) => ((delegate* unmanaged<sbyte*, void>)EntryPoints[26])(coords);
            [UnmanagedCallersOnly]
            private static void Vertex4bvOES_Lazy(sbyte* coords)
            {
                EntryPoints[26] = GLLoader.BindingsContext.GetProcAddress("glVertex4bvOES");
                ((delegate* unmanaged<sbyte*, void>)EntryPoints[26])(coords);
            }
            
            /// <summary> <b>[requires: GL_OES_draw_texture]</b> Draws a texture rectangle to the screen. </summary>
            /// <param name="x"> Specify the position of the affected screen rectangle. </param>
            /// <param name="y"> Specify the position of the affected screen rectangle. </param>
            /// <param name="z"> Specify the position of the affected screen rectangle. </param>
            /// <param name="width"> Specifies the width and height of the affected screen rectangle in pixels. </param>
            /// <param name="height"> Specifies the width and height of the affected screen rectangle in pixels. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glDrawTex.xml" /></remarks>
            public static void DrawTexsOES(short x, short y, short z, short width, short height) => ((delegate* unmanaged<short, short, short, short, short, void>)EntryPoints[27])(x, y, z, width, height);
            [UnmanagedCallersOnly]
            private static void DrawTexsOES_Lazy(short x, short y, short z, short width, short height)
            {
                EntryPoints[27] = GLLoader.BindingsContext.GetProcAddress("glDrawTexsOES");
                ((delegate* unmanaged<short, short, short, short, short, void>)EntryPoints[27])(x, y, z, width, height);
            }
            
            /// <summary> <b>[requires: GL_OES_draw_texture]</b> Draws a texture rectangle to the screen. </summary>
            /// <param name="x"> Specify the position of the affected screen rectangle. </param>
            /// <param name="y"> Specify the position of the affected screen rectangle. </param>
            /// <param name="z"> Specify the position of the affected screen rectangle. </param>
            /// <param name="width"> Specifies the width and height of the affected screen rectangle in pixels. </param>
            /// <param name="height"> Specifies the width and height of the affected screen rectangle in pixels. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glDrawTex.xml" /></remarks>
            public static void DrawTexiOES(int x, int y, int z, int width, int height) => ((delegate* unmanaged<int, int, int, int, int, void>)EntryPoints[28])(x, y, z, width, height);
            [UnmanagedCallersOnly]
            private static void DrawTexiOES_Lazy(int x, int y, int z, int width, int height)
            {
                EntryPoints[28] = GLLoader.BindingsContext.GetProcAddress("glDrawTexiOES");
                ((delegate* unmanaged<int, int, int, int, int, void>)EntryPoints[28])(x, y, z, width, height);
            }
            
            /// <summary> <b>[requires: GL_OES_draw_texture]</b> Draws a texture rectangle to the screen. </summary>
            /// <param name="x"> Specify the position of the affected screen rectangle. </param>
            /// <param name="y"> Specify the position of the affected screen rectangle. </param>
            /// <param name="z"> Specify the position of the affected screen rectangle. </param>
            /// <param name="width"> Specifies the width and height of the affected screen rectangle in pixels. </param>
            /// <param name="height"> Specifies the width and height of the affected screen rectangle in pixels. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glDrawTex.xml" /></remarks>
            public static void DrawTexxOES(int x, int y, int z, int width, int height) => ((delegate* unmanaged<int, int, int, int, int, void>)EntryPoints[29])(x, y, z, width, height);
            [UnmanagedCallersOnly]
            private static void DrawTexxOES_Lazy(int x, int y, int z, int width, int height)
            {
                EntryPoints[29] = GLLoader.BindingsContext.GetProcAddress("glDrawTexxOES");
                ((delegate* unmanaged<int, int, int, int, int, void>)EntryPoints[29])(x, y, z, width, height);
            }
            
            /// <summary> <b>[requires: GL_OES_draw_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DrawTexsvOES(short* coords) => ((delegate* unmanaged<short*, void>)EntryPoints[30])(coords);
            [UnmanagedCallersOnly]
            private static void DrawTexsvOES_Lazy(short* coords)
            {
                EntryPoints[30] = GLLoader.BindingsContext.GetProcAddress("glDrawTexsvOES");
                ((delegate* unmanaged<short*, void>)EntryPoints[30])(coords);
            }
            
            /// <summary> <b>[requires: GL_OES_draw_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DrawTexivOES(int* coords) => ((delegate* unmanaged<int*, void>)EntryPoints[31])(coords);
            [UnmanagedCallersOnly]
            private static void DrawTexivOES_Lazy(int* coords)
            {
                EntryPoints[31] = GLLoader.BindingsContext.GetProcAddress("glDrawTexivOES");
                ((delegate* unmanaged<int*, void>)EntryPoints[31])(coords);
            }
            
            /// <summary> <b>[requires: GL_OES_draw_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DrawTexxvOES(int* coords) => ((delegate* unmanaged<int*, void>)EntryPoints[32])(coords);
            [UnmanagedCallersOnly]
            private static void DrawTexxvOES_Lazy(int* coords)
            {
                EntryPoints[32] = GLLoader.BindingsContext.GetProcAddress("glDrawTexxvOES");
                ((delegate* unmanaged<int*, void>)EntryPoints[32])(coords);
            }
            
            /// <summary> <b>[requires: GL_OES_draw_texture]</b> Draws a texture rectangle to the screen. </summary>
            /// <param name="x"> Specify the position of the affected screen rectangle. </param>
            /// <param name="y"> Specify the position of the affected screen rectangle. </param>
            /// <param name="z"> Specify the position of the affected screen rectangle. </param>
            /// <param name="width"> Specifies the width and height of the affected screen rectangle in pixels. </param>
            /// <param name="height"> Specifies the width and height of the affected screen rectangle in pixels. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glDrawTex.xml" /></remarks>
            public static void DrawTexfOES(float x, float y, float z, float width, float height) => ((delegate* unmanaged<float, float, float, float, float, void>)EntryPoints[33])(x, y, z, width, height);
            [UnmanagedCallersOnly]
            private static void DrawTexfOES_Lazy(float x, float y, float z, float width, float height)
            {
                EntryPoints[33] = GLLoader.BindingsContext.GetProcAddress("glDrawTexfOES");
                ((delegate* unmanaged<float, float, float, float, float, void>)EntryPoints[33])(x, y, z, width, height);
            }
            
            /// <summary> <b>[requires: GL_OES_draw_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DrawTexfvOES(float* coords) => ((delegate* unmanaged<float*, void>)EntryPoints[34])(coords);
            [UnmanagedCallersOnly]
            private static void DrawTexfvOES_Lazy(float* coords)
            {
                EntryPoints[34] = GLLoader.BindingsContext.GetProcAddress("glDrawTexfvOES");
                ((delegate* unmanaged<float*, void>)EntryPoints[34])(coords);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void AlphaFuncxOES(AlphaFunction func, int reference) => ((delegate* unmanaged<AlphaFunction, int, void>)EntryPoints[35])(func, reference);
            [UnmanagedCallersOnly]
            private static void AlphaFuncxOES_Lazy(AlphaFunction func, int reference)
            {
                EntryPoints[35] = GLLoader.BindingsContext.GetProcAddress("glAlphaFuncxOES");
                ((delegate* unmanaged<AlphaFunction, int, void>)EntryPoints[35])(func, reference);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ClearColorxOES(int red, int green, int blue, int alpha) => ((delegate* unmanaged<int, int, int, int, void>)EntryPoints[36])(red, green, blue, alpha);
            [UnmanagedCallersOnly]
            private static void ClearColorxOES_Lazy(int red, int green, int blue, int alpha)
            {
                EntryPoints[36] = GLLoader.BindingsContext.GetProcAddress("glClearColorxOES");
                ((delegate* unmanaged<int, int, int, int, void>)EntryPoints[36])(red, green, blue, alpha);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ClearDepthxOES(int depth) => ((delegate* unmanaged<int, void>)EntryPoints[37])(depth);
            [UnmanagedCallersOnly]
            private static void ClearDepthxOES_Lazy(int depth)
            {
                EntryPoints[37] = GLLoader.BindingsContext.GetProcAddress("glClearDepthxOES");
                ((delegate* unmanaged<int, void>)EntryPoints[37])(depth);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ClipPlanexOES(ClipPlaneName plane, int* equation) => ((delegate* unmanaged<ClipPlaneName, int*, void>)EntryPoints[38])(plane, equation);
            [UnmanagedCallersOnly]
            private static void ClipPlanexOES_Lazy(ClipPlaneName plane, int* equation)
            {
                EntryPoints[38] = GLLoader.BindingsContext.GetProcAddress("glClipPlanexOES");
                ((delegate* unmanaged<ClipPlaneName, int*, void>)EntryPoints[38])(plane, equation);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Color4xOES(int red, int green, int blue, int alpha) => ((delegate* unmanaged<int, int, int, int, void>)EntryPoints[39])(red, green, blue, alpha);
            [UnmanagedCallersOnly]
            private static void Color4xOES_Lazy(int red, int green, int blue, int alpha)
            {
                EntryPoints[39] = GLLoader.BindingsContext.GetProcAddress("glColor4xOES");
                ((delegate* unmanaged<int, int, int, int, void>)EntryPoints[39])(red, green, blue, alpha);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DepthRangexOES(int n, int f) => ((delegate* unmanaged<int, int, void>)EntryPoints[40])(n, f);
            [UnmanagedCallersOnly]
            private static void DepthRangexOES_Lazy(int n, int f)
            {
                EntryPoints[40] = GLLoader.BindingsContext.GetProcAddress("glDepthRangexOES");
                ((delegate* unmanaged<int, int, void>)EntryPoints[40])(n, f);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FogxOES(FogPName pname, int param) => ((delegate* unmanaged<FogPName, int, void>)EntryPoints[41])(pname, param);
            [UnmanagedCallersOnly]
            private static void FogxOES_Lazy(FogPName pname, int param)
            {
                EntryPoints[41] = GLLoader.BindingsContext.GetProcAddress("glFogxOES");
                ((delegate* unmanaged<FogPName, int, void>)EntryPoints[41])(pname, param);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FogxvOES(FogPName pname, int* param) => ((delegate* unmanaged<FogPName, int*, void>)EntryPoints[42])(pname, param);
            [UnmanagedCallersOnly]
            private static void FogxvOES_Lazy(FogPName pname, int* param)
            {
                EntryPoints[42] = GLLoader.BindingsContext.GetProcAddress("glFogxvOES");
                ((delegate* unmanaged<FogPName, int*, void>)EntryPoints[42])(pname, param);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FrustumxOES(int l, int r, int b, int t, int n, int f) => ((delegate* unmanaged<int, int, int, int, int, int, void>)EntryPoints[43])(l, r, b, t, n, f);
            [UnmanagedCallersOnly]
            private static void FrustumxOES_Lazy(int l, int r, int b, int t, int n, int f)
            {
                EntryPoints[43] = GLLoader.BindingsContext.GetProcAddress("glFrustumxOES");
                ((delegate* unmanaged<int, int, int, int, int, int, void>)EntryPoints[43])(l, r, b, t, n, f);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetClipPlanexOES(ClipPlaneName plane, int* equation) => ((delegate* unmanaged<ClipPlaneName, int*, void>)EntryPoints[44])(plane, equation);
            [UnmanagedCallersOnly]
            private static void GetClipPlanexOES_Lazy(ClipPlaneName plane, int* equation)
            {
                EntryPoints[44] = GLLoader.BindingsContext.GetProcAddress("glGetClipPlanexOES");
                ((delegate* unmanaged<ClipPlaneName, int*, void>)EntryPoints[44])(plane, equation);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetFixedvOES(GetPName pname, int* parameters) => ((delegate* unmanaged<GetPName, int*, void>)EntryPoints[45])(pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetFixedvOES_Lazy(GetPName pname, int* parameters)
            {
                EntryPoints[45] = GLLoader.BindingsContext.GetProcAddress("glGetFixedvOES");
                ((delegate* unmanaged<GetPName, int*, void>)EntryPoints[45])(pname, parameters);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetTexEnvxvOES(TextureEnvTarget target, TextureEnvParameter pname, int* parameters) => ((delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int*, void>)EntryPoints[46])(target, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetTexEnvxvOES_Lazy(TextureEnvTarget target, TextureEnvParameter pname, int* parameters)
            {
                EntryPoints[46] = GLLoader.BindingsContext.GetProcAddress("glGetTexEnvxvOES");
                ((delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int*, void>)EntryPoints[46])(target, pname, parameters);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetTexParameterxvOES(TextureTarget target, GetTextureParameter pname, int* parameters) => ((delegate* unmanaged<TextureTarget, GetTextureParameter, int*, void>)EntryPoints[47])(target, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetTexParameterxvOES_Lazy(TextureTarget target, GetTextureParameter pname, int* parameters)
            {
                EntryPoints[47] = GLLoader.BindingsContext.GetProcAddress("glGetTexParameterxvOES");
                ((delegate* unmanaged<TextureTarget, GetTextureParameter, int*, void>)EntryPoints[47])(target, pname, parameters);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void LightModelxOES(LightModelParameter pname, int param) => ((delegate* unmanaged<LightModelParameter, int, void>)EntryPoints[48])(pname, param);
            [UnmanagedCallersOnly]
            private static void LightModelxOES_Lazy(LightModelParameter pname, int param)
            {
                EntryPoints[48] = GLLoader.BindingsContext.GetProcAddress("glLightModelxOES");
                ((delegate* unmanaged<LightModelParameter, int, void>)EntryPoints[48])(pname, param);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void LightModelxvOES(LightModelParameter pname, int* param) => ((delegate* unmanaged<LightModelParameter, int*, void>)EntryPoints[49])(pname, param);
            [UnmanagedCallersOnly]
            private static void LightModelxvOES_Lazy(LightModelParameter pname, int* param)
            {
                EntryPoints[49] = GLLoader.BindingsContext.GetProcAddress("glLightModelxvOES");
                ((delegate* unmanaged<LightModelParameter, int*, void>)EntryPoints[49])(pname, param);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void LightxOES(LightName light, LightParameter pname, int param) => ((delegate* unmanaged<LightName, LightParameter, int, void>)EntryPoints[50])(light, pname, param);
            [UnmanagedCallersOnly]
            private static void LightxOES_Lazy(LightName light, LightParameter pname, int param)
            {
                EntryPoints[50] = GLLoader.BindingsContext.GetProcAddress("glLightxOES");
                ((delegate* unmanaged<LightName, LightParameter, int, void>)EntryPoints[50])(light, pname, param);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void LightxvOES(LightName light, LightParameter pname, int* parameters) => ((delegate* unmanaged<LightName, LightParameter, int*, void>)EntryPoints[51])(light, pname, parameters);
            [UnmanagedCallersOnly]
            private static void LightxvOES_Lazy(LightName light, LightParameter pname, int* parameters)
            {
                EntryPoints[51] = GLLoader.BindingsContext.GetProcAddress("glLightxvOES");
                ((delegate* unmanaged<LightName, LightParameter, int*, void>)EntryPoints[51])(light, pname, parameters);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void LineWidthxOES(int width) => ((delegate* unmanaged<int, void>)EntryPoints[52])(width);
            [UnmanagedCallersOnly]
            private static void LineWidthxOES_Lazy(int width)
            {
                EntryPoints[52] = GLLoader.BindingsContext.GetProcAddress("glLineWidthxOES");
                ((delegate* unmanaged<int, void>)EntryPoints[52])(width);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void LoadMatrixxOES(int* m) => ((delegate* unmanaged<int*, void>)EntryPoints[53])(m);
            [UnmanagedCallersOnly]
            private static void LoadMatrixxOES_Lazy(int* m)
            {
                EntryPoints[53] = GLLoader.BindingsContext.GetProcAddress("glLoadMatrixxOES");
                ((delegate* unmanaged<int*, void>)EntryPoints[53])(m);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MaterialxOES(MaterialFace face, MaterialParameter pname, int param) => ((delegate* unmanaged<MaterialFace, MaterialParameter, int, void>)EntryPoints[54])(face, pname, param);
            [UnmanagedCallersOnly]
            private static void MaterialxOES_Lazy(MaterialFace face, MaterialParameter pname, int param)
            {
                EntryPoints[54] = GLLoader.BindingsContext.GetProcAddress("glMaterialxOES");
                ((delegate* unmanaged<MaterialFace, MaterialParameter, int, void>)EntryPoints[54])(face, pname, param);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MaterialxvOES(MaterialFace face, MaterialParameter pname, int* param) => ((delegate* unmanaged<MaterialFace, MaterialParameter, int*, void>)EntryPoints[55])(face, pname, param);
            [UnmanagedCallersOnly]
            private static void MaterialxvOES_Lazy(MaterialFace face, MaterialParameter pname, int* param)
            {
                EntryPoints[55] = GLLoader.BindingsContext.GetProcAddress("glMaterialxvOES");
                ((delegate* unmanaged<MaterialFace, MaterialParameter, int*, void>)EntryPoints[55])(face, pname, param);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultMatrixxOES(int* m) => ((delegate* unmanaged<int*, void>)EntryPoints[56])(m);
            [UnmanagedCallersOnly]
            private static void MultMatrixxOES_Lazy(int* m)
            {
                EntryPoints[56] = GLLoader.BindingsContext.GetProcAddress("glMultMatrixxOES");
                ((delegate* unmanaged<int*, void>)EntryPoints[56])(m);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiTexCoord4xOES(TextureUnit texture, int s, int t, int r, int q) => ((delegate* unmanaged<TextureUnit, int, int, int, int, void>)EntryPoints[57])(texture, s, t, r, q);
            [UnmanagedCallersOnly]
            private static void MultiTexCoord4xOES_Lazy(TextureUnit texture, int s, int t, int r, int q)
            {
                EntryPoints[57] = GLLoader.BindingsContext.GetProcAddress("glMultiTexCoord4xOES");
                ((delegate* unmanaged<TextureUnit, int, int, int, int, void>)EntryPoints[57])(texture, s, t, r, q);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Normal3xOES(int nx, int ny, int nz) => ((delegate* unmanaged<int, int, int, void>)EntryPoints[58])(nx, ny, nz);
            [UnmanagedCallersOnly]
            private static void Normal3xOES_Lazy(int nx, int ny, int nz)
            {
                EntryPoints[58] = GLLoader.BindingsContext.GetProcAddress("glNormal3xOES");
                ((delegate* unmanaged<int, int, int, void>)EntryPoints[58])(nx, ny, nz);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void OrthoxOES(int l, int r, int b, int t, int n, int f) => ((delegate* unmanaged<int, int, int, int, int, int, void>)EntryPoints[59])(l, r, b, t, n, f);
            [UnmanagedCallersOnly]
            private static void OrthoxOES_Lazy(int l, int r, int b, int t, int n, int f)
            {
                EntryPoints[59] = GLLoader.BindingsContext.GetProcAddress("glOrthoxOES");
                ((delegate* unmanaged<int, int, int, int, int, int, void>)EntryPoints[59])(l, r, b, t, n, f);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PointParameterxvOES(PointParameterNameARB pname, int* parameters) => ((delegate* unmanaged<PointParameterNameARB, int*, void>)EntryPoints[60])(pname, parameters);
            [UnmanagedCallersOnly]
            private static void PointParameterxvOES_Lazy(PointParameterNameARB pname, int* parameters)
            {
                EntryPoints[60] = GLLoader.BindingsContext.GetProcAddress("glPointParameterxvOES");
                ((delegate* unmanaged<PointParameterNameARB, int*, void>)EntryPoints[60])(pname, parameters);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PointSizexOES(int size) => ((delegate* unmanaged<int, void>)EntryPoints[61])(size);
            [UnmanagedCallersOnly]
            private static void PointSizexOES_Lazy(int size)
            {
                EntryPoints[61] = GLLoader.BindingsContext.GetProcAddress("glPointSizexOES");
                ((delegate* unmanaged<int, void>)EntryPoints[61])(size);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PolygonOffsetxOES(int factor, int units) => ((delegate* unmanaged<int, int, void>)EntryPoints[62])(factor, units);
            [UnmanagedCallersOnly]
            private static void PolygonOffsetxOES_Lazy(int factor, int units)
            {
                EntryPoints[62] = GLLoader.BindingsContext.GetProcAddress("glPolygonOffsetxOES");
                ((delegate* unmanaged<int, int, void>)EntryPoints[62])(factor, units);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void RotatexOES(int angle, int x, int y, int z) => ((delegate* unmanaged<int, int, int, int, void>)EntryPoints[63])(angle, x, y, z);
            [UnmanagedCallersOnly]
            private static void RotatexOES_Lazy(int angle, int x, int y, int z)
            {
                EntryPoints[63] = GLLoader.BindingsContext.GetProcAddress("glRotatexOES");
                ((delegate* unmanaged<int, int, int, int, void>)EntryPoints[63])(angle, x, y, z);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ScalexOES(int x, int y, int z) => ((delegate* unmanaged<int, int, int, void>)EntryPoints[64])(x, y, z);
            [UnmanagedCallersOnly]
            private static void ScalexOES_Lazy(int x, int y, int z)
            {
                EntryPoints[64] = GLLoader.BindingsContext.GetProcAddress("glScalexOES");
                ((delegate* unmanaged<int, int, int, void>)EntryPoints[64])(x, y, z);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexEnvxOES(TextureEnvTarget target, TextureEnvParameter pname, int param) => ((delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int, void>)EntryPoints[65])(target, pname, param);
            [UnmanagedCallersOnly]
            private static void TexEnvxOES_Lazy(TextureEnvTarget target, TextureEnvParameter pname, int param)
            {
                EntryPoints[65] = GLLoader.BindingsContext.GetProcAddress("glTexEnvxOES");
                ((delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int, void>)EntryPoints[65])(target, pname, param);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexEnvxvOES(TextureEnvTarget target, TextureEnvParameter pname, int* parameters) => ((delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int*, void>)EntryPoints[66])(target, pname, parameters);
            [UnmanagedCallersOnly]
            private static void TexEnvxvOES_Lazy(TextureEnvTarget target, TextureEnvParameter pname, int* parameters)
            {
                EntryPoints[66] = GLLoader.BindingsContext.GetProcAddress("glTexEnvxvOES");
                ((delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int*, void>)EntryPoints[66])(target, pname, parameters);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexParameterxOES(TextureTarget target, GetTextureParameter pname, int param) => ((delegate* unmanaged<TextureTarget, GetTextureParameter, int, void>)EntryPoints[67])(target, pname, param);
            [UnmanagedCallersOnly]
            private static void TexParameterxOES_Lazy(TextureTarget target, GetTextureParameter pname, int param)
            {
                EntryPoints[67] = GLLoader.BindingsContext.GetProcAddress("glTexParameterxOES");
                ((delegate* unmanaged<TextureTarget, GetTextureParameter, int, void>)EntryPoints[67])(target, pname, param);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexParameterxvOES(TextureTarget target, GetTextureParameter pname, int* parameters) => ((delegate* unmanaged<TextureTarget, GetTextureParameter, int*, void>)EntryPoints[68])(target, pname, parameters);
            [UnmanagedCallersOnly]
            private static void TexParameterxvOES_Lazy(TextureTarget target, GetTextureParameter pname, int* parameters)
            {
                EntryPoints[68] = GLLoader.BindingsContext.GetProcAddress("glTexParameterxvOES");
                ((delegate* unmanaged<TextureTarget, GetTextureParameter, int*, void>)EntryPoints[68])(target, pname, parameters);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TranslatexOES(int x, int y, int z) => ((delegate* unmanaged<int, int, int, void>)EntryPoints[69])(x, y, z);
            [UnmanagedCallersOnly]
            private static void TranslatexOES_Lazy(int x, int y, int z)
            {
                EntryPoints[69] = GLLoader.BindingsContext.GetProcAddress("glTranslatexOES");
                ((delegate* unmanaged<int, int, int, void>)EntryPoints[69])(x, y, z);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetLightxvOES(LightName light, LightParameter pname, int* parameters) => ((delegate* unmanaged<LightName, LightParameter, int*, void>)EntryPoints[70])(light, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetLightxvOES_Lazy(LightName light, LightParameter pname, int* parameters)
            {
                EntryPoints[70] = GLLoader.BindingsContext.GetProcAddress("glGetLightxvOES");
                ((delegate* unmanaged<LightName, LightParameter, int*, void>)EntryPoints[70])(light, pname, parameters);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetMaterialxvOES(MaterialFace face, MaterialParameter pname, int* parameters) => ((delegate* unmanaged<MaterialFace, MaterialParameter, int*, void>)EntryPoints[71])(face, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetMaterialxvOES_Lazy(MaterialFace face, MaterialParameter pname, int* parameters)
            {
                EntryPoints[71] = GLLoader.BindingsContext.GetProcAddress("glGetMaterialxvOES");
                ((delegate* unmanaged<MaterialFace, MaterialParameter, int*, void>)EntryPoints[71])(face, pname, parameters);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PointParameterxOES(PointParameterNameARB pname, int param) => ((delegate* unmanaged<PointParameterNameARB, int, void>)EntryPoints[72])(pname, param);
            [UnmanagedCallersOnly]
            private static void PointParameterxOES_Lazy(PointParameterNameARB pname, int param)
            {
                EntryPoints[72] = GLLoader.BindingsContext.GetProcAddress("glPointParameterxOES");
                ((delegate* unmanaged<PointParameterNameARB, int, void>)EntryPoints[72])(pname, param);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void SampleCoveragexOES(int value, byte invert) => ((delegate* unmanaged<int, byte, void>)EntryPoints[73])(value, invert);
            [UnmanagedCallersOnly]
            private static void SampleCoveragexOES_Lazy(int value, byte invert)
            {
                EntryPoints[73] = GLLoader.BindingsContext.GetProcAddress("glSampleCoveragexOES");
                ((delegate* unmanaged<int, byte, void>)EntryPoints[73])(value, invert);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void AccumxOES(All op, int value) => ((delegate* unmanaged<All, int, void>)EntryPoints[74])(op, value);
            [UnmanagedCallersOnly]
            private static void AccumxOES_Lazy(All op, int value)
            {
                EntryPoints[74] = GLLoader.BindingsContext.GetProcAddress("glAccumxOES");
                ((delegate* unmanaged<All, int, void>)EntryPoints[74])(op, value);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BitmapxOES(int width, int height, int xorig, int yorig, int xmove, int ymove, byte* bitmap) => ((delegate* unmanaged<int, int, int, int, int, int, byte*, void>)EntryPoints[75])(width, height, xorig, yorig, xmove, ymove, bitmap);
            [UnmanagedCallersOnly]
            private static void BitmapxOES_Lazy(int width, int height, int xorig, int yorig, int xmove, int ymove, byte* bitmap)
            {
                EntryPoints[75] = GLLoader.BindingsContext.GetProcAddress("glBitmapxOES");
                ((delegate* unmanaged<int, int, int, int, int, int, byte*, void>)EntryPoints[75])(width, height, xorig, yorig, xmove, ymove, bitmap);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BlendColorxOES(int red, int green, int blue, int alpha) => ((delegate* unmanaged<int, int, int, int, void>)EntryPoints[76])(red, green, blue, alpha);
            [UnmanagedCallersOnly]
            private static void BlendColorxOES_Lazy(int red, int green, int blue, int alpha)
            {
                EntryPoints[76] = GLLoader.BindingsContext.GetProcAddress("glBlendColorxOES");
                ((delegate* unmanaged<int, int, int, int, void>)EntryPoints[76])(red, green, blue, alpha);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ClearAccumxOES(int red, int green, int blue, int alpha) => ((delegate* unmanaged<int, int, int, int, void>)EntryPoints[77])(red, green, blue, alpha);
            [UnmanagedCallersOnly]
            private static void ClearAccumxOES_Lazy(int red, int green, int blue, int alpha)
            {
                EntryPoints[77] = GLLoader.BindingsContext.GetProcAddress("glClearAccumxOES");
                ((delegate* unmanaged<int, int, int, int, void>)EntryPoints[77])(red, green, blue, alpha);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Color3xOES(int red, int green, int blue) => ((delegate* unmanaged<int, int, int, void>)EntryPoints[78])(red, green, blue);
            [UnmanagedCallersOnly]
            private static void Color3xOES_Lazy(int red, int green, int blue)
            {
                EntryPoints[78] = GLLoader.BindingsContext.GetProcAddress("glColor3xOES");
                ((delegate* unmanaged<int, int, int, void>)EntryPoints[78])(red, green, blue);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Color3xvOES(int* components) => ((delegate* unmanaged<int*, void>)EntryPoints[79])(components);
            [UnmanagedCallersOnly]
            private static void Color3xvOES_Lazy(int* components)
            {
                EntryPoints[79] = GLLoader.BindingsContext.GetProcAddress("glColor3xvOES");
                ((delegate* unmanaged<int*, void>)EntryPoints[79])(components);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Color4xvOES(int* components) => ((delegate* unmanaged<int*, void>)EntryPoints[80])(components);
            [UnmanagedCallersOnly]
            private static void Color4xvOES_Lazy(int* components)
            {
                EntryPoints[80] = GLLoader.BindingsContext.GetProcAddress("glColor4xvOES");
                ((delegate* unmanaged<int*, void>)EntryPoints[80])(components);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ConvolutionParameterxOES(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, int param) => ((delegate* unmanaged<ConvolutionTargetEXT, ConvolutionParameterEXT, int, void>)EntryPoints[81])(target, pname, param);
            [UnmanagedCallersOnly]
            private static void ConvolutionParameterxOES_Lazy(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, int param)
            {
                EntryPoints[81] = GLLoader.BindingsContext.GetProcAddress("glConvolutionParameterxOES");
                ((delegate* unmanaged<ConvolutionTargetEXT, ConvolutionParameterEXT, int, void>)EntryPoints[81])(target, pname, param);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ConvolutionParameterxvOES(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, int* parameters) => ((delegate* unmanaged<ConvolutionTargetEXT, ConvolutionParameterEXT, int*, void>)EntryPoints[82])(target, pname, parameters);
            [UnmanagedCallersOnly]
            private static void ConvolutionParameterxvOES_Lazy(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, int* parameters)
            {
                EntryPoints[82] = GLLoader.BindingsContext.GetProcAddress("glConvolutionParameterxvOES");
                ((delegate* unmanaged<ConvolutionTargetEXT, ConvolutionParameterEXT, int*, void>)EntryPoints[82])(target, pname, parameters);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void EvalCoord1xOES(int u) => ((delegate* unmanaged<int, void>)EntryPoints[83])(u);
            [UnmanagedCallersOnly]
            private static void EvalCoord1xOES_Lazy(int u)
            {
                EntryPoints[83] = GLLoader.BindingsContext.GetProcAddress("glEvalCoord1xOES");
                ((delegate* unmanaged<int, void>)EntryPoints[83])(u);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void EvalCoord1xvOES(int* coords) => ((delegate* unmanaged<int*, void>)EntryPoints[84])(coords);
            [UnmanagedCallersOnly]
            private static void EvalCoord1xvOES_Lazy(int* coords)
            {
                EntryPoints[84] = GLLoader.BindingsContext.GetProcAddress("glEvalCoord1xvOES");
                ((delegate* unmanaged<int*, void>)EntryPoints[84])(coords);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void EvalCoord2xOES(int u, int v) => ((delegate* unmanaged<int, int, void>)EntryPoints[85])(u, v);
            [UnmanagedCallersOnly]
            private static void EvalCoord2xOES_Lazy(int u, int v)
            {
                EntryPoints[85] = GLLoader.BindingsContext.GetProcAddress("glEvalCoord2xOES");
                ((delegate* unmanaged<int, int, void>)EntryPoints[85])(u, v);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void EvalCoord2xvOES(int* coords) => ((delegate* unmanaged<int*, void>)EntryPoints[86])(coords);
            [UnmanagedCallersOnly]
            private static void EvalCoord2xvOES_Lazy(int* coords)
            {
                EntryPoints[86] = GLLoader.BindingsContext.GetProcAddress("glEvalCoord2xvOES");
                ((delegate* unmanaged<int*, void>)EntryPoints[86])(coords);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FeedbackBufferxOES(int n, All type, int* buffer) => ((delegate* unmanaged<int, All, int*, void>)EntryPoints[87])(n, type, buffer);
            [UnmanagedCallersOnly]
            private static void FeedbackBufferxOES_Lazy(int n, All type, int* buffer)
            {
                EntryPoints[87] = GLLoader.BindingsContext.GetProcAddress("glFeedbackBufferxOES");
                ((delegate* unmanaged<int, All, int*, void>)EntryPoints[87])(n, type, buffer);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetConvolutionParameterxvOES(All target, All pname, int* parameters) => ((delegate* unmanaged<All, All, int*, void>)EntryPoints[88])(target, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetConvolutionParameterxvOES_Lazy(All target, All pname, int* parameters)
            {
                EntryPoints[88] = GLLoader.BindingsContext.GetProcAddress("glGetConvolutionParameterxvOES");
                ((delegate* unmanaged<All, All, int*, void>)EntryPoints[88])(target, pname, parameters);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetHistogramParameterxvOES(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, int* parameters) => ((delegate* unmanaged<HistogramTargetEXT, GetHistogramParameterPNameEXT, int*, void>)EntryPoints[89])(target, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetHistogramParameterxvOES_Lazy(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, int* parameters)
            {
                EntryPoints[89] = GLLoader.BindingsContext.GetProcAddress("glGetHistogramParameterxvOES");
                ((delegate* unmanaged<HistogramTargetEXT, GetHistogramParameterPNameEXT, int*, void>)EntryPoints[89])(target, pname, parameters);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetLightxOES(LightName light, LightParameter pname, int* parameters) => ((delegate* unmanaged<LightName, LightParameter, int*, void>)EntryPoints[90])(light, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetLightxOES_Lazy(LightName light, LightParameter pname, int* parameters)
            {
                EntryPoints[90] = GLLoader.BindingsContext.GetProcAddress("glGetLightxOES");
                ((delegate* unmanaged<LightName, LightParameter, int*, void>)EntryPoints[90])(light, pname, parameters);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetMapxvOES(MapTarget target, GetMapQuery query, int* v) => ((delegate* unmanaged<MapTarget, GetMapQuery, int*, void>)EntryPoints[91])(target, query, v);
            [UnmanagedCallersOnly]
            private static void GetMapxvOES_Lazy(MapTarget target, GetMapQuery query, int* v)
            {
                EntryPoints[91] = GLLoader.BindingsContext.GetProcAddress("glGetMapxvOES");
                ((delegate* unmanaged<MapTarget, GetMapQuery, int*, void>)EntryPoints[91])(target, query, v);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetMaterialxOES(MaterialFace face, MaterialParameter pname, int param) => ((delegate* unmanaged<MaterialFace, MaterialParameter, int, void>)EntryPoints[92])(face, pname, param);
            [UnmanagedCallersOnly]
            private static void GetMaterialxOES_Lazy(MaterialFace face, MaterialParameter pname, int param)
            {
                EntryPoints[92] = GLLoader.BindingsContext.GetProcAddress("glGetMaterialxOES");
                ((delegate* unmanaged<MaterialFace, MaterialParameter, int, void>)EntryPoints[92])(face, pname, param);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetPixelMapxv(PixelMap map, int size, int* values) => ((delegate* unmanaged<PixelMap, int, int*, void>)EntryPoints[93])(map, size, values);
            [UnmanagedCallersOnly]
            private static void GetPixelMapxv_Lazy(PixelMap map, int size, int* values)
            {
                EntryPoints[93] = GLLoader.BindingsContext.GetProcAddress("glGetPixelMapxv");
                ((delegate* unmanaged<PixelMap, int, int*, void>)EntryPoints[93])(map, size, values);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point | GL_OES_texture_cube_map]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetTexGenxvOES(TextureCoordName coord, TextureGenParameter pname, int* parameters) => ((delegate* unmanaged<TextureCoordName, TextureGenParameter, int*, void>)EntryPoints[94])(coord, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetTexGenxvOES_Lazy(TextureCoordName coord, TextureGenParameter pname, int* parameters)
            {
                EntryPoints[94] = GLLoader.BindingsContext.GetProcAddress("glGetTexGenxvOES");
                ((delegate* unmanaged<TextureCoordName, TextureGenParameter, int*, void>)EntryPoints[94])(coord, pname, parameters);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetTexLevelParameterxvOES(TextureTarget target, int level, GetTextureParameter pname, int* parameters) => ((delegate* unmanaged<TextureTarget, int, GetTextureParameter, int*, void>)EntryPoints[95])(target, level, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetTexLevelParameterxvOES_Lazy(TextureTarget target, int level, GetTextureParameter pname, int* parameters)
            {
                EntryPoints[95] = GLLoader.BindingsContext.GetProcAddress("glGetTexLevelParameterxvOES");
                ((delegate* unmanaged<TextureTarget, int, GetTextureParameter, int*, void>)EntryPoints[95])(target, level, pname, parameters);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void IndexxOES(int component) => ((delegate* unmanaged<int, void>)EntryPoints[96])(component);
            [UnmanagedCallersOnly]
            private static void IndexxOES_Lazy(int component)
            {
                EntryPoints[96] = GLLoader.BindingsContext.GetProcAddress("glIndexxOES");
                ((delegate* unmanaged<int, void>)EntryPoints[96])(component);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void IndexxvOES(int* component) => ((delegate* unmanaged<int*, void>)EntryPoints[97])(component);
            [UnmanagedCallersOnly]
            private static void IndexxvOES_Lazy(int* component)
            {
                EntryPoints[97] = GLLoader.BindingsContext.GetProcAddress("glIndexxvOES");
                ((delegate* unmanaged<int*, void>)EntryPoints[97])(component);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void LoadTransposeMatrixxOES(int* m) => ((delegate* unmanaged<int*, void>)EntryPoints[98])(m);
            [UnmanagedCallersOnly]
            private static void LoadTransposeMatrixxOES_Lazy(int* m)
            {
                EntryPoints[98] = GLLoader.BindingsContext.GetProcAddress("glLoadTransposeMatrixxOES");
                ((delegate* unmanaged<int*, void>)EntryPoints[98])(m);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Map1xOES(MapTarget target, int u1, int u2, int stride, int order, int points) => ((delegate* unmanaged<MapTarget, int, int, int, int, int, void>)EntryPoints[99])(target, u1, u2, stride, order, points);
            [UnmanagedCallersOnly]
            private static void Map1xOES_Lazy(MapTarget target, int u1, int u2, int stride, int order, int points)
            {
                EntryPoints[99] = GLLoader.BindingsContext.GetProcAddress("glMap1xOES");
                ((delegate* unmanaged<MapTarget, int, int, int, int, int, void>)EntryPoints[99])(target, u1, u2, stride, order, points);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Map2xOES(MapTarget target, int u1, int u2, int ustride, int uorder, int v1, int v2, int vstride, int vorder, int points) => ((delegate* unmanaged<MapTarget, int, int, int, int, int, int, int, int, int, void>)EntryPoints[100])(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
            [UnmanagedCallersOnly]
            private static void Map2xOES_Lazy(MapTarget target, int u1, int u2, int ustride, int uorder, int v1, int v2, int vstride, int vorder, int points)
            {
                EntryPoints[100] = GLLoader.BindingsContext.GetProcAddress("glMap2xOES");
                ((delegate* unmanaged<MapTarget, int, int, int, int, int, int, int, int, int, void>)EntryPoints[100])(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MapGrid1xOES(int n, int u1, int u2) => ((delegate* unmanaged<int, int, int, void>)EntryPoints[101])(n, u1, u2);
            [UnmanagedCallersOnly]
            private static void MapGrid1xOES_Lazy(int n, int u1, int u2)
            {
                EntryPoints[101] = GLLoader.BindingsContext.GetProcAddress("glMapGrid1xOES");
                ((delegate* unmanaged<int, int, int, void>)EntryPoints[101])(n, u1, u2);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MapGrid2xOES(int n, int u1, int u2, int v1, int v2) => ((delegate* unmanaged<int, int, int, int, int, void>)EntryPoints[102])(n, u1, u2, v1, v2);
            [UnmanagedCallersOnly]
            private static void MapGrid2xOES_Lazy(int n, int u1, int u2, int v1, int v2)
            {
                EntryPoints[102] = GLLoader.BindingsContext.GetProcAddress("glMapGrid2xOES");
                ((delegate* unmanaged<int, int, int, int, int, void>)EntryPoints[102])(n, u1, u2, v1, v2);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultTransposeMatrixxOES(int* m) => ((delegate* unmanaged<int*, void>)EntryPoints[103])(m);
            [UnmanagedCallersOnly]
            private static void MultTransposeMatrixxOES_Lazy(int* m)
            {
                EntryPoints[103] = GLLoader.BindingsContext.GetProcAddress("glMultTransposeMatrixxOES");
                ((delegate* unmanaged<int*, void>)EntryPoints[103])(m);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiTexCoord1xOES(TextureUnit texture, int s) => ((delegate* unmanaged<TextureUnit, int, void>)EntryPoints[104])(texture, s);
            [UnmanagedCallersOnly]
            private static void MultiTexCoord1xOES_Lazy(TextureUnit texture, int s)
            {
                EntryPoints[104] = GLLoader.BindingsContext.GetProcAddress("glMultiTexCoord1xOES");
                ((delegate* unmanaged<TextureUnit, int, void>)EntryPoints[104])(texture, s);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiTexCoord1xvOES(TextureUnit texture, int* coords) => ((delegate* unmanaged<TextureUnit, int*, void>)EntryPoints[105])(texture, coords);
            [UnmanagedCallersOnly]
            private static void MultiTexCoord1xvOES_Lazy(TextureUnit texture, int* coords)
            {
                EntryPoints[105] = GLLoader.BindingsContext.GetProcAddress("glMultiTexCoord1xvOES");
                ((delegate* unmanaged<TextureUnit, int*, void>)EntryPoints[105])(texture, coords);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiTexCoord2xOES(TextureUnit texture, int s, int t) => ((delegate* unmanaged<TextureUnit, int, int, void>)EntryPoints[106])(texture, s, t);
            [UnmanagedCallersOnly]
            private static void MultiTexCoord2xOES_Lazy(TextureUnit texture, int s, int t)
            {
                EntryPoints[106] = GLLoader.BindingsContext.GetProcAddress("glMultiTexCoord2xOES");
                ((delegate* unmanaged<TextureUnit, int, int, void>)EntryPoints[106])(texture, s, t);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiTexCoord2xvOES(TextureUnit texture, int* coords) => ((delegate* unmanaged<TextureUnit, int*, void>)EntryPoints[107])(texture, coords);
            [UnmanagedCallersOnly]
            private static void MultiTexCoord2xvOES_Lazy(TextureUnit texture, int* coords)
            {
                EntryPoints[107] = GLLoader.BindingsContext.GetProcAddress("glMultiTexCoord2xvOES");
                ((delegate* unmanaged<TextureUnit, int*, void>)EntryPoints[107])(texture, coords);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiTexCoord3xOES(TextureUnit texture, int s, int t, int r) => ((delegate* unmanaged<TextureUnit, int, int, int, void>)EntryPoints[108])(texture, s, t, r);
            [UnmanagedCallersOnly]
            private static void MultiTexCoord3xOES_Lazy(TextureUnit texture, int s, int t, int r)
            {
                EntryPoints[108] = GLLoader.BindingsContext.GetProcAddress("glMultiTexCoord3xOES");
                ((delegate* unmanaged<TextureUnit, int, int, int, void>)EntryPoints[108])(texture, s, t, r);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiTexCoord3xvOES(TextureUnit texture, int* coords) => ((delegate* unmanaged<TextureUnit, int*, void>)EntryPoints[109])(texture, coords);
            [UnmanagedCallersOnly]
            private static void MultiTexCoord3xvOES_Lazy(TextureUnit texture, int* coords)
            {
                EntryPoints[109] = GLLoader.BindingsContext.GetProcAddress("glMultiTexCoord3xvOES");
                ((delegate* unmanaged<TextureUnit, int*, void>)EntryPoints[109])(texture, coords);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiTexCoord4xvOES(TextureUnit texture, int* coords) => ((delegate* unmanaged<TextureUnit, int*, void>)EntryPoints[110])(texture, coords);
            [UnmanagedCallersOnly]
            private static void MultiTexCoord4xvOES_Lazy(TextureUnit texture, int* coords)
            {
                EntryPoints[110] = GLLoader.BindingsContext.GetProcAddress("glMultiTexCoord4xvOES");
                ((delegate* unmanaged<TextureUnit, int*, void>)EntryPoints[110])(texture, coords);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Normal3xvOES(int* coords) => ((delegate* unmanaged<int*, void>)EntryPoints[111])(coords);
            [UnmanagedCallersOnly]
            private static void Normal3xvOES_Lazy(int* coords)
            {
                EntryPoints[111] = GLLoader.BindingsContext.GetProcAddress("glNormal3xvOES");
                ((delegate* unmanaged<int*, void>)EntryPoints[111])(coords);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PassThroughxOES(int token) => ((delegate* unmanaged<int, void>)EntryPoints[112])(token);
            [UnmanagedCallersOnly]
            private static void PassThroughxOES_Lazy(int token)
            {
                EntryPoints[112] = GLLoader.BindingsContext.GetProcAddress("glPassThroughxOES");
                ((delegate* unmanaged<int, void>)EntryPoints[112])(token);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PixelMapx(PixelMap map, int size, int* values) => ((delegate* unmanaged<PixelMap, int, int*, void>)EntryPoints[113])(map, size, values);
            [UnmanagedCallersOnly]
            private static void PixelMapx_Lazy(PixelMap map, int size, int* values)
            {
                EntryPoints[113] = GLLoader.BindingsContext.GetProcAddress("glPixelMapx");
                ((delegate* unmanaged<PixelMap, int, int*, void>)EntryPoints[113])(map, size, values);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PixelStorex(PixelStoreParameter pname, int param) => ((delegate* unmanaged<PixelStoreParameter, int, void>)EntryPoints[114])(pname, param);
            [UnmanagedCallersOnly]
            private static void PixelStorex_Lazy(PixelStoreParameter pname, int param)
            {
                EntryPoints[114] = GLLoader.BindingsContext.GetProcAddress("glPixelStorex");
                ((delegate* unmanaged<PixelStoreParameter, int, void>)EntryPoints[114])(pname, param);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PixelTransferxOES(PixelTransferParameter pname, int param) => ((delegate* unmanaged<PixelTransferParameter, int, void>)EntryPoints[115])(pname, param);
            [UnmanagedCallersOnly]
            private static void PixelTransferxOES_Lazy(PixelTransferParameter pname, int param)
            {
                EntryPoints[115] = GLLoader.BindingsContext.GetProcAddress("glPixelTransferxOES");
                ((delegate* unmanaged<PixelTransferParameter, int, void>)EntryPoints[115])(pname, param);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PixelZoomxOES(int xfactor, int yfactor) => ((delegate* unmanaged<int, int, void>)EntryPoints[116])(xfactor, yfactor);
            [UnmanagedCallersOnly]
            private static void PixelZoomxOES_Lazy(int xfactor, int yfactor)
            {
                EntryPoints[116] = GLLoader.BindingsContext.GetProcAddress("glPixelZoomxOES");
                ((delegate* unmanaged<int, int, void>)EntryPoints[116])(xfactor, yfactor);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PrioritizeTexturesxOES(int n, TextureHandle* textures, int* priorities) => ((delegate* unmanaged<int, TextureHandle*, int*, void>)EntryPoints[117])(n, textures, priorities);
            [UnmanagedCallersOnly]
            private static void PrioritizeTexturesxOES_Lazy(int n, TextureHandle* textures, int* priorities)
            {
                EntryPoints[117] = GLLoader.BindingsContext.GetProcAddress("glPrioritizeTexturesxOES");
                ((delegate* unmanaged<int, TextureHandle*, int*, void>)EntryPoints[117])(n, textures, priorities);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void RasterPos2xOES(int x, int y) => ((delegate* unmanaged<int, int, void>)EntryPoints[118])(x, y);
            [UnmanagedCallersOnly]
            private static void RasterPos2xOES_Lazy(int x, int y)
            {
                EntryPoints[118] = GLLoader.BindingsContext.GetProcAddress("glRasterPos2xOES");
                ((delegate* unmanaged<int, int, void>)EntryPoints[118])(x, y);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void RasterPos2xvOES(int* coords) => ((delegate* unmanaged<int*, void>)EntryPoints[119])(coords);
            [UnmanagedCallersOnly]
            private static void RasterPos2xvOES_Lazy(int* coords)
            {
                EntryPoints[119] = GLLoader.BindingsContext.GetProcAddress("glRasterPos2xvOES");
                ((delegate* unmanaged<int*, void>)EntryPoints[119])(coords);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void RasterPos3xOES(int x, int y, int z) => ((delegate* unmanaged<int, int, int, void>)EntryPoints[120])(x, y, z);
            [UnmanagedCallersOnly]
            private static void RasterPos3xOES_Lazy(int x, int y, int z)
            {
                EntryPoints[120] = GLLoader.BindingsContext.GetProcAddress("glRasterPos3xOES");
                ((delegate* unmanaged<int, int, int, void>)EntryPoints[120])(x, y, z);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void RasterPos3xvOES(int* coords) => ((delegate* unmanaged<int*, void>)EntryPoints[121])(coords);
            [UnmanagedCallersOnly]
            private static void RasterPos3xvOES_Lazy(int* coords)
            {
                EntryPoints[121] = GLLoader.BindingsContext.GetProcAddress("glRasterPos3xvOES");
                ((delegate* unmanaged<int*, void>)EntryPoints[121])(coords);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void RasterPos4xOES(int x, int y, int z, int w) => ((delegate* unmanaged<int, int, int, int, void>)EntryPoints[122])(x, y, z, w);
            [UnmanagedCallersOnly]
            private static void RasterPos4xOES_Lazy(int x, int y, int z, int w)
            {
                EntryPoints[122] = GLLoader.BindingsContext.GetProcAddress("glRasterPos4xOES");
                ((delegate* unmanaged<int, int, int, int, void>)EntryPoints[122])(x, y, z, w);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void RasterPos4xvOES(int* coords) => ((delegate* unmanaged<int*, void>)EntryPoints[123])(coords);
            [UnmanagedCallersOnly]
            private static void RasterPos4xvOES_Lazy(int* coords)
            {
                EntryPoints[123] = GLLoader.BindingsContext.GetProcAddress("glRasterPos4xvOES");
                ((delegate* unmanaged<int*, void>)EntryPoints[123])(coords);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void RectxOES(int x1, int y1, int x2, int y2) => ((delegate* unmanaged<int, int, int, int, void>)EntryPoints[124])(x1, y1, x2, y2);
            [UnmanagedCallersOnly]
            private static void RectxOES_Lazy(int x1, int y1, int x2, int y2)
            {
                EntryPoints[124] = GLLoader.BindingsContext.GetProcAddress("glRectxOES");
                ((delegate* unmanaged<int, int, int, int, void>)EntryPoints[124])(x1, y1, x2, y2);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void RectxvOES(int* v1, int* v2) => ((delegate* unmanaged<int*, int*, void>)EntryPoints[125])(v1, v2);
            [UnmanagedCallersOnly]
            private static void RectxvOES_Lazy(int* v1, int* v2)
            {
                EntryPoints[125] = GLLoader.BindingsContext.GetProcAddress("glRectxvOES");
                ((delegate* unmanaged<int*, int*, void>)EntryPoints[125])(v1, v2);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexCoord1xOES(int s) => ((delegate* unmanaged<int, void>)EntryPoints[126])(s);
            [UnmanagedCallersOnly]
            private static void TexCoord1xOES_Lazy(int s)
            {
                EntryPoints[126] = GLLoader.BindingsContext.GetProcAddress("glTexCoord1xOES");
                ((delegate* unmanaged<int, void>)EntryPoints[126])(s);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexCoord1xvOES(int* coords) => ((delegate* unmanaged<int*, void>)EntryPoints[127])(coords);
            [UnmanagedCallersOnly]
            private static void TexCoord1xvOES_Lazy(int* coords)
            {
                EntryPoints[127] = GLLoader.BindingsContext.GetProcAddress("glTexCoord1xvOES");
                ((delegate* unmanaged<int*, void>)EntryPoints[127])(coords);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexCoord2xOES(int s, int t) => ((delegate* unmanaged<int, int, void>)EntryPoints[128])(s, t);
            [UnmanagedCallersOnly]
            private static void TexCoord2xOES_Lazy(int s, int t)
            {
                EntryPoints[128] = GLLoader.BindingsContext.GetProcAddress("glTexCoord2xOES");
                ((delegate* unmanaged<int, int, void>)EntryPoints[128])(s, t);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexCoord2xvOES(int* coords) => ((delegate* unmanaged<int*, void>)EntryPoints[129])(coords);
            [UnmanagedCallersOnly]
            private static void TexCoord2xvOES_Lazy(int* coords)
            {
                EntryPoints[129] = GLLoader.BindingsContext.GetProcAddress("glTexCoord2xvOES");
                ((delegate* unmanaged<int*, void>)EntryPoints[129])(coords);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexCoord3xOES(int s, int t, int r) => ((delegate* unmanaged<int, int, int, void>)EntryPoints[130])(s, t, r);
            [UnmanagedCallersOnly]
            private static void TexCoord3xOES_Lazy(int s, int t, int r)
            {
                EntryPoints[130] = GLLoader.BindingsContext.GetProcAddress("glTexCoord3xOES");
                ((delegate* unmanaged<int, int, int, void>)EntryPoints[130])(s, t, r);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexCoord3xvOES(int* coords) => ((delegate* unmanaged<int*, void>)EntryPoints[131])(coords);
            [UnmanagedCallersOnly]
            private static void TexCoord3xvOES_Lazy(int* coords)
            {
                EntryPoints[131] = GLLoader.BindingsContext.GetProcAddress("glTexCoord3xvOES");
                ((delegate* unmanaged<int*, void>)EntryPoints[131])(coords);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexCoord4xOES(int s, int t, int r, int q) => ((delegate* unmanaged<int, int, int, int, void>)EntryPoints[132])(s, t, r, q);
            [UnmanagedCallersOnly]
            private static void TexCoord4xOES_Lazy(int s, int t, int r, int q)
            {
                EntryPoints[132] = GLLoader.BindingsContext.GetProcAddress("glTexCoord4xOES");
                ((delegate* unmanaged<int, int, int, int, void>)EntryPoints[132])(s, t, r, q);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexCoord4xvOES(int* coords) => ((delegate* unmanaged<int*, void>)EntryPoints[133])(coords);
            [UnmanagedCallersOnly]
            private static void TexCoord4xvOES_Lazy(int* coords)
            {
                EntryPoints[133] = GLLoader.BindingsContext.GetProcAddress("glTexCoord4xvOES");
                ((delegate* unmanaged<int*, void>)EntryPoints[133])(coords);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point | GL_OES_texture_cube_map]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexGenxOES(TextureCoordName coord, TextureGenParameter pname, int param) => ((delegate* unmanaged<TextureCoordName, TextureGenParameter, int, void>)EntryPoints[134])(coord, pname, param);
            [UnmanagedCallersOnly]
            private static void TexGenxOES_Lazy(TextureCoordName coord, TextureGenParameter pname, int param)
            {
                EntryPoints[134] = GLLoader.BindingsContext.GetProcAddress("glTexGenxOES");
                ((delegate* unmanaged<TextureCoordName, TextureGenParameter, int, void>)EntryPoints[134])(coord, pname, param);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point | GL_OES_texture_cube_map]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexGenxvOES(TextureCoordName coord, TextureGenParameter pname, int* parameters) => ((delegate* unmanaged<TextureCoordName, TextureGenParameter, int*, void>)EntryPoints[135])(coord, pname, parameters);
            [UnmanagedCallersOnly]
            private static void TexGenxvOES_Lazy(TextureCoordName coord, TextureGenParameter pname, int* parameters)
            {
                EntryPoints[135] = GLLoader.BindingsContext.GetProcAddress("glTexGenxvOES");
                ((delegate* unmanaged<TextureCoordName, TextureGenParameter, int*, void>)EntryPoints[135])(coord, pname, parameters);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Vertex2xOES(int x) => ((delegate* unmanaged<int, void>)EntryPoints[136])(x);
            [UnmanagedCallersOnly]
            private static void Vertex2xOES_Lazy(int x)
            {
                EntryPoints[136] = GLLoader.BindingsContext.GetProcAddress("glVertex2xOES");
                ((delegate* unmanaged<int, void>)EntryPoints[136])(x);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Vertex2xvOES(int* coords) => ((delegate* unmanaged<int*, void>)EntryPoints[137])(coords);
            [UnmanagedCallersOnly]
            private static void Vertex2xvOES_Lazy(int* coords)
            {
                EntryPoints[137] = GLLoader.BindingsContext.GetProcAddress("glVertex2xvOES");
                ((delegate* unmanaged<int*, void>)EntryPoints[137])(coords);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Vertex3xOES(int x, int y) => ((delegate* unmanaged<int, int, void>)EntryPoints[138])(x, y);
            [UnmanagedCallersOnly]
            private static void Vertex3xOES_Lazy(int x, int y)
            {
                EntryPoints[138] = GLLoader.BindingsContext.GetProcAddress("glVertex3xOES");
                ((delegate* unmanaged<int, int, void>)EntryPoints[138])(x, y);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Vertex3xvOES(int* coords) => ((delegate* unmanaged<int*, void>)EntryPoints[139])(coords);
            [UnmanagedCallersOnly]
            private static void Vertex3xvOES_Lazy(int* coords)
            {
                EntryPoints[139] = GLLoader.BindingsContext.GetProcAddress("glVertex3xvOES");
                ((delegate* unmanaged<int*, void>)EntryPoints[139])(coords);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Vertex4xOES(int x, int y, int z) => ((delegate* unmanaged<int, int, int, void>)EntryPoints[140])(x, y, z);
            [UnmanagedCallersOnly]
            private static void Vertex4xOES_Lazy(int x, int y, int z)
            {
                EntryPoints[140] = GLLoader.BindingsContext.GetProcAddress("glVertex4xOES");
                ((delegate* unmanaged<int, int, int, void>)EntryPoints[140])(x, y, z);
            }
            
            /// <summary> <b>[requires: GL_OES_fixed_point]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Vertex4xvOES(int* coords) => ((delegate* unmanaged<int*, void>)EntryPoints[141])(coords);
            [UnmanagedCallersOnly]
            private static void Vertex4xvOES_Lazy(int* coords)
            {
                EntryPoints[141] = GLLoader.BindingsContext.GetProcAddress("glVertex4xvOES");
                ((delegate* unmanaged<int*, void>)EntryPoints[141])(coords);
            }
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static byte IsRenderbufferOES(RenderbufferHandle renderbuffer) => ((delegate* unmanaged<RenderbufferHandle, byte>)EntryPoints[142])(renderbuffer);
            [UnmanagedCallersOnly]
            private static byte IsRenderbufferOES_Lazy(RenderbufferHandle renderbuffer)
            {
                EntryPoints[142] = GLLoader.BindingsContext.GetProcAddress("glIsRenderbufferOES");
                return ((delegate* unmanaged<RenderbufferHandle, byte>)EntryPoints[142])(renderbuffer);
            }
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BindRenderbufferOES(RenderbufferTarget target, RenderbufferHandle renderbuffer) => ((delegate* unmanaged<RenderbufferTarget, RenderbufferHandle, void>)EntryPoints[143])(target, renderbuffer);
            [UnmanagedCallersOnly]
            private static void BindRenderbufferOES_Lazy(RenderbufferTarget target, RenderbufferHandle renderbuffer)
            {
                EntryPoints[143] = GLLoader.BindingsContext.GetProcAddress("glBindRenderbufferOES");
                ((delegate* unmanaged<RenderbufferTarget, RenderbufferHandle, void>)EntryPoints[143])(target, renderbuffer);
            }
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DeleteRenderbuffersOES(int n, RenderbufferHandle* renderbuffers) => ((delegate* unmanaged<int, RenderbufferHandle*, void>)EntryPoints[144])(n, renderbuffers);
            [UnmanagedCallersOnly]
            private static void DeleteRenderbuffersOES_Lazy(int n, RenderbufferHandle* renderbuffers)
            {
                EntryPoints[144] = GLLoader.BindingsContext.GetProcAddress("glDeleteRenderbuffersOES");
                ((delegate* unmanaged<int, RenderbufferHandle*, void>)EntryPoints[144])(n, renderbuffers);
            }
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GenRenderbuffersOES(int n, RenderbufferHandle* renderbuffers) => ((delegate* unmanaged<int, RenderbufferHandle*, void>)EntryPoints[145])(n, renderbuffers);
            [UnmanagedCallersOnly]
            private static void GenRenderbuffersOES_Lazy(int n, RenderbufferHandle* renderbuffers)
            {
                EntryPoints[145] = GLLoader.BindingsContext.GetProcAddress("glGenRenderbuffersOES");
                ((delegate* unmanaged<int, RenderbufferHandle*, void>)EntryPoints[145])(n, renderbuffers);
            }
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void RenderbufferStorageOES(RenderbufferTarget target, InternalFormat internalformat, int width, int height) => ((delegate* unmanaged<RenderbufferTarget, InternalFormat, int, int, void>)EntryPoints[146])(target, internalformat, width, height);
            [UnmanagedCallersOnly]
            private static void RenderbufferStorageOES_Lazy(RenderbufferTarget target, InternalFormat internalformat, int width, int height)
            {
                EntryPoints[146] = GLLoader.BindingsContext.GetProcAddress("glRenderbufferStorageOES");
                ((delegate* unmanaged<RenderbufferTarget, InternalFormat, int, int, void>)EntryPoints[146])(target, internalformat, width, height);
            }
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetRenderbufferParameterivOES(RenderbufferTarget target, RenderbufferParameterName pname, int* parameters) => ((delegate* unmanaged<RenderbufferTarget, RenderbufferParameterName, int*, void>)EntryPoints[147])(target, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetRenderbufferParameterivOES_Lazy(RenderbufferTarget target, RenderbufferParameterName pname, int* parameters)
            {
                EntryPoints[147] = GLLoader.BindingsContext.GetProcAddress("glGetRenderbufferParameterivOES");
                ((delegate* unmanaged<RenderbufferTarget, RenderbufferParameterName, int*, void>)EntryPoints[147])(target, pname, parameters);
            }
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static byte IsFramebufferOES(FramebufferHandle framebuffer) => ((delegate* unmanaged<FramebufferHandle, byte>)EntryPoints[148])(framebuffer);
            [UnmanagedCallersOnly]
            private static byte IsFramebufferOES_Lazy(FramebufferHandle framebuffer)
            {
                EntryPoints[148] = GLLoader.BindingsContext.GetProcAddress("glIsFramebufferOES");
                return ((delegate* unmanaged<FramebufferHandle, byte>)EntryPoints[148])(framebuffer);
            }
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BindFramebufferOES(FramebufferTarget target, FramebufferHandle framebuffer) => ((delegate* unmanaged<FramebufferTarget, FramebufferHandle, void>)EntryPoints[149])(target, framebuffer);
            [UnmanagedCallersOnly]
            private static void BindFramebufferOES_Lazy(FramebufferTarget target, FramebufferHandle framebuffer)
            {
                EntryPoints[149] = GLLoader.BindingsContext.GetProcAddress("glBindFramebufferOES");
                ((delegate* unmanaged<FramebufferTarget, FramebufferHandle, void>)EntryPoints[149])(target, framebuffer);
            }
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DeleteFramebuffersOES(int n, FramebufferHandle* framebuffers) => ((delegate* unmanaged<int, FramebufferHandle*, void>)EntryPoints[150])(n, framebuffers);
            [UnmanagedCallersOnly]
            private static void DeleteFramebuffersOES_Lazy(int n, FramebufferHandle* framebuffers)
            {
                EntryPoints[150] = GLLoader.BindingsContext.GetProcAddress("glDeleteFramebuffersOES");
                ((delegate* unmanaged<int, FramebufferHandle*, void>)EntryPoints[150])(n, framebuffers);
            }
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GenFramebuffersOES(int n, FramebufferHandle* framebuffers) => ((delegate* unmanaged<int, FramebufferHandle*, void>)EntryPoints[151])(n, framebuffers);
            [UnmanagedCallersOnly]
            private static void GenFramebuffersOES_Lazy(int n, FramebufferHandle* framebuffers)
            {
                EntryPoints[151] = GLLoader.BindingsContext.GetProcAddress("glGenFramebuffersOES");
                ((delegate* unmanaged<int, FramebufferHandle*, void>)EntryPoints[151])(n, framebuffers);
            }
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static FramebufferStatus CheckFramebufferStatusOES(FramebufferTarget target) => ((delegate* unmanaged<FramebufferTarget, FramebufferStatus>)EntryPoints[152])(target);
            [UnmanagedCallersOnly]
            private static FramebufferStatus CheckFramebufferStatusOES_Lazy(FramebufferTarget target)
            {
                EntryPoints[152] = GLLoader.BindingsContext.GetProcAddress("glCheckFramebufferStatusOES");
                return ((delegate* unmanaged<FramebufferTarget, FramebufferStatus>)EntryPoints[152])(target);
            }
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FramebufferRenderbufferOES(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, RenderbufferHandle renderbuffer) => ((delegate* unmanaged<FramebufferTarget, FramebufferAttachment, RenderbufferTarget, RenderbufferHandle, void>)EntryPoints[153])(target, attachment, renderbuffertarget, renderbuffer);
            [UnmanagedCallersOnly]
            private static void FramebufferRenderbufferOES_Lazy(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, RenderbufferHandle renderbuffer)
            {
                EntryPoints[153] = GLLoader.BindingsContext.GetProcAddress("glFramebufferRenderbufferOES");
                ((delegate* unmanaged<FramebufferTarget, FramebufferAttachment, RenderbufferTarget, RenderbufferHandle, void>)EntryPoints[153])(target, attachment, renderbuffertarget, renderbuffer);
            }
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FramebufferTexture2DOES(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, TextureHandle texture, int level) => ((delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureTarget, TextureHandle, int, void>)EntryPoints[154])(target, attachment, textarget, texture, level);
            [UnmanagedCallersOnly]
            private static void FramebufferTexture2DOES_Lazy(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, TextureHandle texture, int level)
            {
                EntryPoints[154] = GLLoader.BindingsContext.GetProcAddress("glFramebufferTexture2DOES");
                ((delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureTarget, TextureHandle, int, void>)EntryPoints[154])(target, attachment, textarget, texture, level);
            }
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetFramebufferAttachmentParameterivOES(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int* parameters) => ((delegate* unmanaged<FramebufferTarget, FramebufferAttachment, FramebufferAttachmentParameterName, int*, void>)EntryPoints[155])(target, attachment, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetFramebufferAttachmentParameterivOES_Lazy(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int* parameters)
            {
                EntryPoints[155] = GLLoader.BindingsContext.GetProcAddress("glGetFramebufferAttachmentParameterivOES");
                ((delegate* unmanaged<FramebufferTarget, FramebufferAttachment, FramebufferAttachmentParameterName, int*, void>)EntryPoints[155])(target, attachment, pname, parameters);
            }
            
            /// <summary> <b>[requires: GL_OES_framebuffer_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GenerateMipmapOES(TextureTarget target) => ((delegate* unmanaged<TextureTarget, void>)EntryPoints[156])(target);
            [UnmanagedCallersOnly]
            private static void GenerateMipmapOES_Lazy(TextureTarget target)
            {
                EntryPoints[156] = GLLoader.BindingsContext.GetProcAddress("glGenerateMipmapOES");
                ((delegate* unmanaged<TextureTarget, void>)EntryPoints[156])(target);
            }
            
            /// <summary> <b>[requires: GL_OES_mapbuffer]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void* MapBufferOES(BufferTargetARB target, BufferAccessARB access) => ((delegate* unmanaged<BufferTargetARB, BufferAccessARB, void*>)EntryPoints[157])(target, access);
            [UnmanagedCallersOnly]
            private static void* MapBufferOES_Lazy(BufferTargetARB target, BufferAccessARB access)
            {
                EntryPoints[157] = GLLoader.BindingsContext.GetProcAddress("glMapBufferOES");
                return ((delegate* unmanaged<BufferTargetARB, BufferAccessARB, void*>)EntryPoints[157])(target, access);
            }
            
            /// <summary> <b>[requires: GL_OES_mapbuffer]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static byte UnmapBufferOES(All target) => ((delegate* unmanaged<All, byte>)EntryPoints[158])(target);
            [UnmanagedCallersOnly]
            private static byte UnmapBufferOES_Lazy(All target)
            {
                EntryPoints[158] = GLLoader.BindingsContext.GetProcAddress("glUnmapBufferOES");
                return ((delegate* unmanaged<All, byte>)EntryPoints[158])(target);
            }
            
            /// <summary> <b>[requires: GL_OES_mapbuffer]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetBufferPointervOES(BufferTargetARB target, BufferPointerNameARB pname, void** parameters) => ((delegate* unmanaged<BufferTargetARB, BufferPointerNameARB, void**, void>)EntryPoints[159])(target, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetBufferPointervOES_Lazy(BufferTargetARB target, BufferPointerNameARB pname, void** parameters)
            {
                EntryPoints[159] = GLLoader.BindingsContext.GetProcAddress("glGetBufferPointervOES");
                ((delegate* unmanaged<BufferTargetARB, BufferPointerNameARB, void**, void>)EntryPoints[159])(target, pname, parameters);
            }
            
            /// <summary> <b>[requires: GL_OES_matrix_palette]</b>         defines which of the palette's matrices is affected by        subsequent matrix operations        . </summary>
            /// <param name="index"> specifies the index into the palette's matrices. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glCurrentPaletteMatrix.xml" /></remarks>
            public static void CurrentPaletteMatrixOES(uint matrixpaletteindex) => ((delegate* unmanaged<uint, void>)EntryPoints[160])(matrixpaletteindex);
            [UnmanagedCallersOnly]
            private static void CurrentPaletteMatrixOES_Lazy(uint matrixpaletteindex)
            {
                EntryPoints[160] = GLLoader.BindingsContext.GetProcAddress("glCurrentPaletteMatrixOES");
                ((delegate* unmanaged<uint, void>)EntryPoints[160])(matrixpaletteindex);
            }
            
            /// <summary> <b>[requires: GL_OES_matrix_palette]</b>         copies the current model view matrix to a        matrix in the current matrix palette        . </summary>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glLoadPaletteFromModelViewMatrix.xml" /></remarks>
            public static void LoadPaletteFromModelViewMatrixOES() => ((delegate* unmanaged<void>)EntryPoints[161])();
            [UnmanagedCallersOnly]
            private static void LoadPaletteFromModelViewMatrixOES_Lazy()
            {
                EntryPoints[161] = GLLoader.BindingsContext.GetProcAddress("glLoadPaletteFromModelViewMatrixOES");
                ((delegate* unmanaged<void>)EntryPoints[161])();
            }
            
            /// <summary> <b>[requires: GL_OES_matrix_palette]</b> Define an array of matrix indices. </summary>
            /// <param name="size"> Specifies the number of matrix indices per vertex. Must be is less than or equal to GL_MAX_VERTEX_UNITS_OES. The initial value is 0. </param>
            /// <param name="type"> Specifies the data type of each matrix index in the array. Symbolic constant GL_UNSIGNED_BYTE is accepted. The initial value is GL_UNSIGNED_BYTE. </param>
            /// <param name="stride"> Specifies the byte offset between consecutive matrix indices. If stride is 0, the matrix indices are understood to be tightly packed in the array. The initial value is 0. </param>
            /// <param name="pointer"> Specifies a pointer to the first matrix index of the first vertex in the array. The initial value is 0. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glMatrixIndexPointer.xml" /></remarks>
            public static void MatrixIndexPointerOES(int size, MatrixIndexPointerTypeARB type, int stride, void* pointer) => ((delegate* unmanaged<int, MatrixIndexPointerTypeARB, int, void*, void>)EntryPoints[162])(size, type, stride, pointer);
            [UnmanagedCallersOnly]
            private static void MatrixIndexPointerOES_Lazy(int size, MatrixIndexPointerTypeARB type, int stride, void* pointer)
            {
                EntryPoints[162] = GLLoader.BindingsContext.GetProcAddress("glMatrixIndexPointerOES");
                ((delegate* unmanaged<int, MatrixIndexPointerTypeARB, int, void*, void>)EntryPoints[162])(size, type, stride, pointer);
            }
            
            /// <summary> <b>[requires: GL_OES_matrix_palette]</b> Define an array of weights. </summary>
            /// <param name="size"> Specifies the number of weights per vertex. Must be is less than or equal to GL_MAX_VERTEX_UNITS_OES. The initial value is 0. </param>
            /// <param name="type"> Specifies the data type of each weight in the array. Symbolic constant GL_FIXED is accepted. However, the common profile also accepts the symbolic constant GL_FLOAT as well. The initial value is GL_FIXED for the common lite profile, or GL_FLOAT for the common profile. </param>
            /// <param name="stride"> Specifies the byte offset between consecutive weights. If stride is 0, the weights are understood to be tightly packed in the array. The initial value is 0. </param>
            /// <param name="pointer"> Specifies a pointer to the first weight of the first vertex in the array. The initial value is 0. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glWeightPointer.xml" /></remarks>
            public static void WeightPointerOES(int size, All type, int stride, void* pointer) => ((delegate* unmanaged<int, All, int, void*, void>)EntryPoints[163])(size, type, stride, pointer);
            [UnmanagedCallersOnly]
            private static void WeightPointerOES_Lazy(int size, All type, int stride, void* pointer)
            {
                EntryPoints[163] = GLLoader.BindingsContext.GetProcAddress("glWeightPointerOES");
                ((delegate* unmanaged<int, All, int, void*, void>)EntryPoints[163])(size, type, stride, pointer);
            }
            
            /// <summary> <b>[requires: GL_OES_point_size_array]</b> Define an array of point sizes. </summary>
            /// <param name="type"> Specifies the data type of each point size in the array. Symbolic constant GL_FIXED is accepted. However, the common profile also accepts the symbolic constant GL_FLOAT. The initial value is GL_FIXED for the common lite profile, or GL_FLOAT for the common profile. </param>
            /// <param name="stride"> Specifies the byte offset between consecutive point sizes. If stride is 0, the point sizes are understood to be tightly packed in the array. The initial value is 0. </param>
            /// <param name="pointer"> Specifies a pointer to the point size of the first vertex in the array. The initial value is 0. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glPointSizePointerOES.xml" /></remarks>
            public static void PointSizePointerOES(All type, int stride, void* pointer) => ((delegate* unmanaged<All, int, void*, void>)EntryPoints[164])(type, stride, pointer);
            [UnmanagedCallersOnly]
            private static void PointSizePointerOES_Lazy(All type, int stride, void* pointer)
            {
                EntryPoints[164] = GLLoader.BindingsContext.GetProcAddress("glPointSizePointerOES");
                ((delegate* unmanaged<All, int, void*, void>)EntryPoints[164])(type, stride, pointer);
            }
            
            /// <summary> <b>[requires: GL_OES_query_matrix]</b> Return the values of the current matrix. </summary>
            /// <param name="mantissa">Returns the mantissa values of the current matrix.</param>
            /// <param name="exponent">Returns the exponents of the current matrix.</param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es1.1/xhtml/glQueryMatrix.xml" /></remarks>
            public static All QueryMatrixxOES(int* mantissa, int* exponent) => ((delegate* unmanaged<int*, int*, All>)EntryPoints[165])(mantissa, exponent);
            [UnmanagedCallersOnly]
            private static All QueryMatrixxOES_Lazy(int* mantissa, int* exponent)
            {
                EntryPoints[165] = GLLoader.BindingsContext.GetProcAddress("glQueryMatrixxOES");
                return ((delegate* unmanaged<int*, int*, All>)EntryPoints[165])(mantissa, exponent);
            }
            
            /// <summary> <b>[requires: GL_OES_single_precision]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ClearDepthfOES(float depth) => ((delegate* unmanaged<float, void>)EntryPoints[166])(depth);
            [UnmanagedCallersOnly]
            private static void ClearDepthfOES_Lazy(float depth)
            {
                EntryPoints[166] = GLLoader.BindingsContext.GetProcAddress("glClearDepthfOES");
                ((delegate* unmanaged<float, void>)EntryPoints[166])(depth);
            }
            
            /// <summary> <b>[requires: GL_OES_single_precision]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ClipPlanefOES(ClipPlaneName plane, float* equation) => ((delegate* unmanaged<ClipPlaneName, float*, void>)EntryPoints[167])(plane, equation);
            [UnmanagedCallersOnly]
            private static void ClipPlanefOES_Lazy(ClipPlaneName plane, float* equation)
            {
                EntryPoints[167] = GLLoader.BindingsContext.GetProcAddress("glClipPlanefOES");
                ((delegate* unmanaged<ClipPlaneName, float*, void>)EntryPoints[167])(plane, equation);
            }
            
            /// <summary> <b>[requires: GL_OES_single_precision]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DepthRangefOES(float n, float f) => ((delegate* unmanaged<float, float, void>)EntryPoints[168])(n, f);
            [UnmanagedCallersOnly]
            private static void DepthRangefOES_Lazy(float n, float f)
            {
                EntryPoints[168] = GLLoader.BindingsContext.GetProcAddress("glDepthRangefOES");
                ((delegate* unmanaged<float, float, void>)EntryPoints[168])(n, f);
            }
            
            /// <summary> <b>[requires: GL_OES_single_precision]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FrustumfOES(float l, float r, float b, float t, float n, float f) => ((delegate* unmanaged<float, float, float, float, float, float, void>)EntryPoints[169])(l, r, b, t, n, f);
            [UnmanagedCallersOnly]
            private static void FrustumfOES_Lazy(float l, float r, float b, float t, float n, float f)
            {
                EntryPoints[169] = GLLoader.BindingsContext.GetProcAddress("glFrustumfOES");
                ((delegate* unmanaged<float, float, float, float, float, float, void>)EntryPoints[169])(l, r, b, t, n, f);
            }
            
            /// <summary> <b>[requires: GL_OES_single_precision]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetClipPlanefOES(ClipPlaneName plane, float* equation) => ((delegate* unmanaged<ClipPlaneName, float*, void>)EntryPoints[170])(plane, equation);
            [UnmanagedCallersOnly]
            private static void GetClipPlanefOES_Lazy(ClipPlaneName plane, float* equation)
            {
                EntryPoints[170] = GLLoader.BindingsContext.GetProcAddress("glGetClipPlanefOES");
                ((delegate* unmanaged<ClipPlaneName, float*, void>)EntryPoints[170])(plane, equation);
            }
            
            /// <summary> <b>[requires: GL_OES_single_precision]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void OrthofOES(float l, float r, float b, float t, float n, float f) => ((delegate* unmanaged<float, float, float, float, float, float, void>)EntryPoints[171])(l, r, b, t, n, f);
            [UnmanagedCallersOnly]
            private static void OrthofOES_Lazy(float l, float r, float b, float t, float n, float f)
            {
                EntryPoints[171] = GLLoader.BindingsContext.GetProcAddress("glOrthofOES");
                ((delegate* unmanaged<float, float, float, float, float, float, void>)EntryPoints[171])(l, r, b, t, n, f);
            }
            
            /// <summary> <b>[requires: GL_OES_texture_cube_map]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexGenfOES(TextureCoordName coord, TextureGenParameter pname, float param) => ((delegate* unmanaged<TextureCoordName, TextureGenParameter, float, void>)EntryPoints[172])(coord, pname, param);
            [UnmanagedCallersOnly]
            private static void TexGenfOES_Lazy(TextureCoordName coord, TextureGenParameter pname, float param)
            {
                EntryPoints[172] = GLLoader.BindingsContext.GetProcAddress("glTexGenfOES");
                ((delegate* unmanaged<TextureCoordName, TextureGenParameter, float, void>)EntryPoints[172])(coord, pname, param);
            }
            
            /// <summary> <b>[requires: GL_OES_texture_cube_map]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexGenfvOES(TextureCoordName coord, TextureGenParameter pname, float* parameters) => ((delegate* unmanaged<TextureCoordName, TextureGenParameter, float*, void>)EntryPoints[173])(coord, pname, parameters);
            [UnmanagedCallersOnly]
            private static void TexGenfvOES_Lazy(TextureCoordName coord, TextureGenParameter pname, float* parameters)
            {
                EntryPoints[173] = GLLoader.BindingsContext.GetProcAddress("glTexGenfvOES");
                ((delegate* unmanaged<TextureCoordName, TextureGenParameter, float*, void>)EntryPoints[173])(coord, pname, parameters);
            }
            
            /// <summary> <b>[requires: GL_OES_texture_cube_map]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexGeniOES(TextureCoordName coord, TextureGenParameter pname, int param) => ((delegate* unmanaged<TextureCoordName, TextureGenParameter, int, void>)EntryPoints[174])(coord, pname, param);
            [UnmanagedCallersOnly]
            private static void TexGeniOES_Lazy(TextureCoordName coord, TextureGenParameter pname, int param)
            {
                EntryPoints[174] = GLLoader.BindingsContext.GetProcAddress("glTexGeniOES");
                ((delegate* unmanaged<TextureCoordName, TextureGenParameter, int, void>)EntryPoints[174])(coord, pname, param);
            }
            
            /// <summary> <b>[requires: GL_OES_texture_cube_map]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexGenivOES(TextureCoordName coord, TextureGenParameter pname, int* parameters) => ((delegate* unmanaged<TextureCoordName, TextureGenParameter, int*, void>)EntryPoints[175])(coord, pname, parameters);
            [UnmanagedCallersOnly]
            private static void TexGenivOES_Lazy(TextureCoordName coord, TextureGenParameter pname, int* parameters)
            {
                EntryPoints[175] = GLLoader.BindingsContext.GetProcAddress("glTexGenivOES");
                ((delegate* unmanaged<TextureCoordName, TextureGenParameter, int*, void>)EntryPoints[175])(coord, pname, parameters);
            }
            
            /// <summary> <b>[requires: GL_OES_texture_cube_map]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetTexGenfvOES(TextureCoordName coord, TextureGenParameter pname, float* parameters) => ((delegate* unmanaged<TextureCoordName, TextureGenParameter, float*, void>)EntryPoints[176])(coord, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetTexGenfvOES_Lazy(TextureCoordName coord, TextureGenParameter pname, float* parameters)
            {
                EntryPoints[176] = GLLoader.BindingsContext.GetProcAddress("glGetTexGenfvOES");
                ((delegate* unmanaged<TextureCoordName, TextureGenParameter, float*, void>)EntryPoints[176])(coord, pname, parameters);
            }
            
            /// <summary> <b>[requires: GL_OES_texture_cube_map]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetTexGenivOES(TextureCoordName coord, TextureGenParameter pname, int* parameters) => ((delegate* unmanaged<TextureCoordName, TextureGenParameter, int*, void>)EntryPoints[177])(coord, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetTexGenivOES_Lazy(TextureCoordName coord, TextureGenParameter pname, int* parameters)
            {
                EntryPoints[177] = GLLoader.BindingsContext.GetProcAddress("glGetTexGenivOES");
                ((delegate* unmanaged<TextureCoordName, TextureGenParameter, int*, void>)EntryPoints[177])(coord, pname, parameters);
            }
            
            /// <summary> <b>[requires: GL_OES_vertex_array_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BindVertexArrayOES(VertexArrayHandle array) => ((delegate* unmanaged<VertexArrayHandle, void>)EntryPoints[178])(array);
            [UnmanagedCallersOnly]
            private static void BindVertexArrayOES_Lazy(VertexArrayHandle array)
            {
                EntryPoints[178] = GLLoader.BindingsContext.GetProcAddress("glBindVertexArrayOES");
                ((delegate* unmanaged<VertexArrayHandle, void>)EntryPoints[178])(array);
            }
            
            /// <summary> <b>[requires: GL_OES_vertex_array_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DeleteVertexArraysOES(int n, VertexArrayHandle* arrays) => ((delegate* unmanaged<int, VertexArrayHandle*, void>)EntryPoints[179])(n, arrays);
            [UnmanagedCallersOnly]
            private static void DeleteVertexArraysOES_Lazy(int n, VertexArrayHandle* arrays)
            {
                EntryPoints[179] = GLLoader.BindingsContext.GetProcAddress("glDeleteVertexArraysOES");
                ((delegate* unmanaged<int, VertexArrayHandle*, void>)EntryPoints[179])(n, arrays);
            }
            
            /// <summary> <b>[requires: GL_OES_vertex_array_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GenVertexArraysOES(int n, VertexArrayHandle* arrays) => ((delegate* unmanaged<int, VertexArrayHandle*, void>)EntryPoints[180])(n, arrays);
            [UnmanagedCallersOnly]
            private static void GenVertexArraysOES_Lazy(int n, VertexArrayHandle* arrays)
            {
                EntryPoints[180] = GLLoader.BindingsContext.GetProcAddress("glGenVertexArraysOES");
                ((delegate* unmanaged<int, VertexArrayHandle*, void>)EntryPoints[180])(n, arrays);
            }
            
            /// <summary> <b>[requires: GL_OES_vertex_array_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static byte IsVertexArrayOES(VertexArrayHandle array) => ((delegate* unmanaged<VertexArrayHandle, byte>)EntryPoints[181])(array);
            [UnmanagedCallersOnly]
            private static byte IsVertexArrayOES_Lazy(VertexArrayHandle array)
            {
                EntryPoints[181] = GLLoader.BindingsContext.GetProcAddress("glIsVertexArrayOES");
                return ((delegate* unmanaged<VertexArrayHandle, byte>)EntryPoints[181])(array);
            }
            
            static OES()
            {
                EntryPoints = new IntPtr[182];
                EntryPoints[0] = (IntPtr)(delegate* unmanaged<All, void*, void>)&EGLImageTargetTexture2DOES_Lazy;
                EntryPoints[1] = (IntPtr)(delegate* unmanaged<All, void*, void>)&EGLImageTargetRenderbufferStorageOES_Lazy;
                EntryPoints[2] = (IntPtr)(delegate* unmanaged<BlendEquationModeEXT, BlendEquationModeEXT, void>)&BlendEquationSeparateOES_Lazy;
                EntryPoints[3] = (IntPtr)(delegate* unmanaged<BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void>)&BlendFuncSeparateOES_Lazy;
                EntryPoints[4] = (IntPtr)(delegate* unmanaged<BlendEquationModeEXT, void>)&BlendEquationOES_Lazy;
                EntryPoints[5] = (IntPtr)(delegate* unmanaged<TextureUnit, sbyte, void>)&MultiTexCoord1bOES_Lazy;
                EntryPoints[6] = (IntPtr)(delegate* unmanaged<TextureUnit, sbyte*, void>)&MultiTexCoord1bvOES_Lazy;
                EntryPoints[7] = (IntPtr)(delegate* unmanaged<TextureUnit, sbyte, sbyte, void>)&MultiTexCoord2bOES_Lazy;
                EntryPoints[8] = (IntPtr)(delegate* unmanaged<TextureUnit, sbyte*, void>)&MultiTexCoord2bvOES_Lazy;
                EntryPoints[9] = (IntPtr)(delegate* unmanaged<TextureUnit, sbyte, sbyte, sbyte, void>)&MultiTexCoord3bOES_Lazy;
                EntryPoints[10] = (IntPtr)(delegate* unmanaged<TextureUnit, sbyte*, void>)&MultiTexCoord3bvOES_Lazy;
                EntryPoints[11] = (IntPtr)(delegate* unmanaged<TextureUnit, sbyte, sbyte, sbyte, sbyte, void>)&MultiTexCoord4bOES_Lazy;
                EntryPoints[12] = (IntPtr)(delegate* unmanaged<TextureUnit, sbyte*, void>)&MultiTexCoord4bvOES_Lazy;
                EntryPoints[13] = (IntPtr)(delegate* unmanaged<sbyte, void>)&TexCoord1bOES_Lazy;
                EntryPoints[14] = (IntPtr)(delegate* unmanaged<sbyte*, void>)&TexCoord1bvOES_Lazy;
                EntryPoints[15] = (IntPtr)(delegate* unmanaged<sbyte, sbyte, void>)&TexCoord2bOES_Lazy;
                EntryPoints[16] = (IntPtr)(delegate* unmanaged<sbyte*, void>)&TexCoord2bvOES_Lazy;
                EntryPoints[17] = (IntPtr)(delegate* unmanaged<sbyte, sbyte, sbyte, void>)&TexCoord3bOES_Lazy;
                EntryPoints[18] = (IntPtr)(delegate* unmanaged<sbyte*, void>)&TexCoord3bvOES_Lazy;
                EntryPoints[19] = (IntPtr)(delegate* unmanaged<sbyte, sbyte, sbyte, sbyte, void>)&TexCoord4bOES_Lazy;
                EntryPoints[20] = (IntPtr)(delegate* unmanaged<sbyte*, void>)&TexCoord4bvOES_Lazy;
                EntryPoints[21] = (IntPtr)(delegate* unmanaged<sbyte, sbyte, void>)&Vertex2bOES_Lazy;
                EntryPoints[22] = (IntPtr)(delegate* unmanaged<sbyte*, void>)&Vertex2bvOES_Lazy;
                EntryPoints[23] = (IntPtr)(delegate* unmanaged<sbyte, sbyte, sbyte, void>)&Vertex3bOES_Lazy;
                EntryPoints[24] = (IntPtr)(delegate* unmanaged<sbyte*, void>)&Vertex3bvOES_Lazy;
                EntryPoints[25] = (IntPtr)(delegate* unmanaged<sbyte, sbyte, sbyte, sbyte, void>)&Vertex4bOES_Lazy;
                EntryPoints[26] = (IntPtr)(delegate* unmanaged<sbyte*, void>)&Vertex4bvOES_Lazy;
                EntryPoints[27] = (IntPtr)(delegate* unmanaged<short, short, short, short, short, void>)&DrawTexsOES_Lazy;
                EntryPoints[28] = (IntPtr)(delegate* unmanaged<int, int, int, int, int, void>)&DrawTexiOES_Lazy;
                EntryPoints[29] = (IntPtr)(delegate* unmanaged<int, int, int, int, int, void>)&DrawTexxOES_Lazy;
                EntryPoints[30] = (IntPtr)(delegate* unmanaged<short*, void>)&DrawTexsvOES_Lazy;
                EntryPoints[31] = (IntPtr)(delegate* unmanaged<int*, void>)&DrawTexivOES_Lazy;
                EntryPoints[32] = (IntPtr)(delegate* unmanaged<int*, void>)&DrawTexxvOES_Lazy;
                EntryPoints[33] = (IntPtr)(delegate* unmanaged<float, float, float, float, float, void>)&DrawTexfOES_Lazy;
                EntryPoints[34] = (IntPtr)(delegate* unmanaged<float*, void>)&DrawTexfvOES_Lazy;
                EntryPoints[35] = (IntPtr)(delegate* unmanaged<AlphaFunction, int, void>)&AlphaFuncxOES_Lazy;
                EntryPoints[36] = (IntPtr)(delegate* unmanaged<int, int, int, int, void>)&ClearColorxOES_Lazy;
                EntryPoints[37] = (IntPtr)(delegate* unmanaged<int, void>)&ClearDepthxOES_Lazy;
                EntryPoints[38] = (IntPtr)(delegate* unmanaged<ClipPlaneName, int*, void>)&ClipPlanexOES_Lazy;
                EntryPoints[39] = (IntPtr)(delegate* unmanaged<int, int, int, int, void>)&Color4xOES_Lazy;
                EntryPoints[40] = (IntPtr)(delegate* unmanaged<int, int, void>)&DepthRangexOES_Lazy;
                EntryPoints[41] = (IntPtr)(delegate* unmanaged<FogPName, int, void>)&FogxOES_Lazy;
                EntryPoints[42] = (IntPtr)(delegate* unmanaged<FogPName, int*, void>)&FogxvOES_Lazy;
                EntryPoints[43] = (IntPtr)(delegate* unmanaged<int, int, int, int, int, int, void>)&FrustumxOES_Lazy;
                EntryPoints[44] = (IntPtr)(delegate* unmanaged<ClipPlaneName, int*, void>)&GetClipPlanexOES_Lazy;
                EntryPoints[45] = (IntPtr)(delegate* unmanaged<GetPName, int*, void>)&GetFixedvOES_Lazy;
                EntryPoints[46] = (IntPtr)(delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int*, void>)&GetTexEnvxvOES_Lazy;
                EntryPoints[47] = (IntPtr)(delegate* unmanaged<TextureTarget, GetTextureParameter, int*, void>)&GetTexParameterxvOES_Lazy;
                EntryPoints[48] = (IntPtr)(delegate* unmanaged<LightModelParameter, int, void>)&LightModelxOES_Lazy;
                EntryPoints[49] = (IntPtr)(delegate* unmanaged<LightModelParameter, int*, void>)&LightModelxvOES_Lazy;
                EntryPoints[50] = (IntPtr)(delegate* unmanaged<LightName, LightParameter, int, void>)&LightxOES_Lazy;
                EntryPoints[51] = (IntPtr)(delegate* unmanaged<LightName, LightParameter, int*, void>)&LightxvOES_Lazy;
                EntryPoints[52] = (IntPtr)(delegate* unmanaged<int, void>)&LineWidthxOES_Lazy;
                EntryPoints[53] = (IntPtr)(delegate* unmanaged<int*, void>)&LoadMatrixxOES_Lazy;
                EntryPoints[54] = (IntPtr)(delegate* unmanaged<MaterialFace, MaterialParameter, int, void>)&MaterialxOES_Lazy;
                EntryPoints[55] = (IntPtr)(delegate* unmanaged<MaterialFace, MaterialParameter, int*, void>)&MaterialxvOES_Lazy;
                EntryPoints[56] = (IntPtr)(delegate* unmanaged<int*, void>)&MultMatrixxOES_Lazy;
                EntryPoints[57] = (IntPtr)(delegate* unmanaged<TextureUnit, int, int, int, int, void>)&MultiTexCoord4xOES_Lazy;
                EntryPoints[58] = (IntPtr)(delegate* unmanaged<int, int, int, void>)&Normal3xOES_Lazy;
                EntryPoints[59] = (IntPtr)(delegate* unmanaged<int, int, int, int, int, int, void>)&OrthoxOES_Lazy;
                EntryPoints[60] = (IntPtr)(delegate* unmanaged<PointParameterNameARB, int*, void>)&PointParameterxvOES_Lazy;
                EntryPoints[61] = (IntPtr)(delegate* unmanaged<int, void>)&PointSizexOES_Lazy;
                EntryPoints[62] = (IntPtr)(delegate* unmanaged<int, int, void>)&PolygonOffsetxOES_Lazy;
                EntryPoints[63] = (IntPtr)(delegate* unmanaged<int, int, int, int, void>)&RotatexOES_Lazy;
                EntryPoints[64] = (IntPtr)(delegate* unmanaged<int, int, int, void>)&ScalexOES_Lazy;
                EntryPoints[65] = (IntPtr)(delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int, void>)&TexEnvxOES_Lazy;
                EntryPoints[66] = (IntPtr)(delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int*, void>)&TexEnvxvOES_Lazy;
                EntryPoints[67] = (IntPtr)(delegate* unmanaged<TextureTarget, GetTextureParameter, int, void>)&TexParameterxOES_Lazy;
                EntryPoints[68] = (IntPtr)(delegate* unmanaged<TextureTarget, GetTextureParameter, int*, void>)&TexParameterxvOES_Lazy;
                EntryPoints[69] = (IntPtr)(delegate* unmanaged<int, int, int, void>)&TranslatexOES_Lazy;
                EntryPoints[70] = (IntPtr)(delegate* unmanaged<LightName, LightParameter, int*, void>)&GetLightxvOES_Lazy;
                EntryPoints[71] = (IntPtr)(delegate* unmanaged<MaterialFace, MaterialParameter, int*, void>)&GetMaterialxvOES_Lazy;
                EntryPoints[72] = (IntPtr)(delegate* unmanaged<PointParameterNameARB, int, void>)&PointParameterxOES_Lazy;
                EntryPoints[73] = (IntPtr)(delegate* unmanaged<int, byte, void>)&SampleCoveragexOES_Lazy;
                EntryPoints[74] = (IntPtr)(delegate* unmanaged<All, int, void>)&AccumxOES_Lazy;
                EntryPoints[75] = (IntPtr)(delegate* unmanaged<int, int, int, int, int, int, byte*, void>)&BitmapxOES_Lazy;
                EntryPoints[76] = (IntPtr)(delegate* unmanaged<int, int, int, int, void>)&BlendColorxOES_Lazy;
                EntryPoints[77] = (IntPtr)(delegate* unmanaged<int, int, int, int, void>)&ClearAccumxOES_Lazy;
                EntryPoints[78] = (IntPtr)(delegate* unmanaged<int, int, int, void>)&Color3xOES_Lazy;
                EntryPoints[79] = (IntPtr)(delegate* unmanaged<int*, void>)&Color3xvOES_Lazy;
                EntryPoints[80] = (IntPtr)(delegate* unmanaged<int*, void>)&Color4xvOES_Lazy;
                EntryPoints[81] = (IntPtr)(delegate* unmanaged<ConvolutionTargetEXT, ConvolutionParameterEXT, int, void>)&ConvolutionParameterxOES_Lazy;
                EntryPoints[82] = (IntPtr)(delegate* unmanaged<ConvolutionTargetEXT, ConvolutionParameterEXT, int*, void>)&ConvolutionParameterxvOES_Lazy;
                EntryPoints[83] = (IntPtr)(delegate* unmanaged<int, void>)&EvalCoord1xOES_Lazy;
                EntryPoints[84] = (IntPtr)(delegate* unmanaged<int*, void>)&EvalCoord1xvOES_Lazy;
                EntryPoints[85] = (IntPtr)(delegate* unmanaged<int, int, void>)&EvalCoord2xOES_Lazy;
                EntryPoints[86] = (IntPtr)(delegate* unmanaged<int*, void>)&EvalCoord2xvOES_Lazy;
                EntryPoints[87] = (IntPtr)(delegate* unmanaged<int, All, int*, void>)&FeedbackBufferxOES_Lazy;
                EntryPoints[88] = (IntPtr)(delegate* unmanaged<All, All, int*, void>)&GetConvolutionParameterxvOES_Lazy;
                EntryPoints[89] = (IntPtr)(delegate* unmanaged<HistogramTargetEXT, GetHistogramParameterPNameEXT, int*, void>)&GetHistogramParameterxvOES_Lazy;
                EntryPoints[90] = (IntPtr)(delegate* unmanaged<LightName, LightParameter, int*, void>)&GetLightxOES_Lazy;
                EntryPoints[91] = (IntPtr)(delegate* unmanaged<MapTarget, GetMapQuery, int*, void>)&GetMapxvOES_Lazy;
                EntryPoints[92] = (IntPtr)(delegate* unmanaged<MaterialFace, MaterialParameter, int, void>)&GetMaterialxOES_Lazy;
                EntryPoints[93] = (IntPtr)(delegate* unmanaged<PixelMap, int, int*, void>)&GetPixelMapxv_Lazy;
                EntryPoints[94] = (IntPtr)(delegate* unmanaged<TextureCoordName, TextureGenParameter, int*, void>)&GetTexGenxvOES_Lazy;
                EntryPoints[95] = (IntPtr)(delegate* unmanaged<TextureTarget, int, GetTextureParameter, int*, void>)&GetTexLevelParameterxvOES_Lazy;
                EntryPoints[96] = (IntPtr)(delegate* unmanaged<int, void>)&IndexxOES_Lazy;
                EntryPoints[97] = (IntPtr)(delegate* unmanaged<int*, void>)&IndexxvOES_Lazy;
                EntryPoints[98] = (IntPtr)(delegate* unmanaged<int*, void>)&LoadTransposeMatrixxOES_Lazy;
                EntryPoints[99] = (IntPtr)(delegate* unmanaged<MapTarget, int, int, int, int, int, void>)&Map1xOES_Lazy;
                EntryPoints[100] = (IntPtr)(delegate* unmanaged<MapTarget, int, int, int, int, int, int, int, int, int, void>)&Map2xOES_Lazy;
                EntryPoints[101] = (IntPtr)(delegate* unmanaged<int, int, int, void>)&MapGrid1xOES_Lazy;
                EntryPoints[102] = (IntPtr)(delegate* unmanaged<int, int, int, int, int, void>)&MapGrid2xOES_Lazy;
                EntryPoints[103] = (IntPtr)(delegate* unmanaged<int*, void>)&MultTransposeMatrixxOES_Lazy;
                EntryPoints[104] = (IntPtr)(delegate* unmanaged<TextureUnit, int, void>)&MultiTexCoord1xOES_Lazy;
                EntryPoints[105] = (IntPtr)(delegate* unmanaged<TextureUnit, int*, void>)&MultiTexCoord1xvOES_Lazy;
                EntryPoints[106] = (IntPtr)(delegate* unmanaged<TextureUnit, int, int, void>)&MultiTexCoord2xOES_Lazy;
                EntryPoints[107] = (IntPtr)(delegate* unmanaged<TextureUnit, int*, void>)&MultiTexCoord2xvOES_Lazy;
                EntryPoints[108] = (IntPtr)(delegate* unmanaged<TextureUnit, int, int, int, void>)&MultiTexCoord3xOES_Lazy;
                EntryPoints[109] = (IntPtr)(delegate* unmanaged<TextureUnit, int*, void>)&MultiTexCoord3xvOES_Lazy;
                EntryPoints[110] = (IntPtr)(delegate* unmanaged<TextureUnit, int*, void>)&MultiTexCoord4xvOES_Lazy;
                EntryPoints[111] = (IntPtr)(delegate* unmanaged<int*, void>)&Normal3xvOES_Lazy;
                EntryPoints[112] = (IntPtr)(delegate* unmanaged<int, void>)&PassThroughxOES_Lazy;
                EntryPoints[113] = (IntPtr)(delegate* unmanaged<PixelMap, int, int*, void>)&PixelMapx_Lazy;
                EntryPoints[114] = (IntPtr)(delegate* unmanaged<PixelStoreParameter, int, void>)&PixelStorex_Lazy;
                EntryPoints[115] = (IntPtr)(delegate* unmanaged<PixelTransferParameter, int, void>)&PixelTransferxOES_Lazy;
                EntryPoints[116] = (IntPtr)(delegate* unmanaged<int, int, void>)&PixelZoomxOES_Lazy;
                EntryPoints[117] = (IntPtr)(delegate* unmanaged<int, TextureHandle*, int*, void>)&PrioritizeTexturesxOES_Lazy;
                EntryPoints[118] = (IntPtr)(delegate* unmanaged<int, int, void>)&RasterPos2xOES_Lazy;
                EntryPoints[119] = (IntPtr)(delegate* unmanaged<int*, void>)&RasterPos2xvOES_Lazy;
                EntryPoints[120] = (IntPtr)(delegate* unmanaged<int, int, int, void>)&RasterPos3xOES_Lazy;
                EntryPoints[121] = (IntPtr)(delegate* unmanaged<int*, void>)&RasterPos3xvOES_Lazy;
                EntryPoints[122] = (IntPtr)(delegate* unmanaged<int, int, int, int, void>)&RasterPos4xOES_Lazy;
                EntryPoints[123] = (IntPtr)(delegate* unmanaged<int*, void>)&RasterPos4xvOES_Lazy;
                EntryPoints[124] = (IntPtr)(delegate* unmanaged<int, int, int, int, void>)&RectxOES_Lazy;
                EntryPoints[125] = (IntPtr)(delegate* unmanaged<int*, int*, void>)&RectxvOES_Lazy;
                EntryPoints[126] = (IntPtr)(delegate* unmanaged<int, void>)&TexCoord1xOES_Lazy;
                EntryPoints[127] = (IntPtr)(delegate* unmanaged<int*, void>)&TexCoord1xvOES_Lazy;
                EntryPoints[128] = (IntPtr)(delegate* unmanaged<int, int, void>)&TexCoord2xOES_Lazy;
                EntryPoints[129] = (IntPtr)(delegate* unmanaged<int*, void>)&TexCoord2xvOES_Lazy;
                EntryPoints[130] = (IntPtr)(delegate* unmanaged<int, int, int, void>)&TexCoord3xOES_Lazy;
                EntryPoints[131] = (IntPtr)(delegate* unmanaged<int*, void>)&TexCoord3xvOES_Lazy;
                EntryPoints[132] = (IntPtr)(delegate* unmanaged<int, int, int, int, void>)&TexCoord4xOES_Lazy;
                EntryPoints[133] = (IntPtr)(delegate* unmanaged<int*, void>)&TexCoord4xvOES_Lazy;
                EntryPoints[134] = (IntPtr)(delegate* unmanaged<TextureCoordName, TextureGenParameter, int, void>)&TexGenxOES_Lazy;
                EntryPoints[135] = (IntPtr)(delegate* unmanaged<TextureCoordName, TextureGenParameter, int*, void>)&TexGenxvOES_Lazy;
                EntryPoints[136] = (IntPtr)(delegate* unmanaged<int, void>)&Vertex2xOES_Lazy;
                EntryPoints[137] = (IntPtr)(delegate* unmanaged<int*, void>)&Vertex2xvOES_Lazy;
                EntryPoints[138] = (IntPtr)(delegate* unmanaged<int, int, void>)&Vertex3xOES_Lazy;
                EntryPoints[139] = (IntPtr)(delegate* unmanaged<int*, void>)&Vertex3xvOES_Lazy;
                EntryPoints[140] = (IntPtr)(delegate* unmanaged<int, int, int, void>)&Vertex4xOES_Lazy;
                EntryPoints[141] = (IntPtr)(delegate* unmanaged<int*, void>)&Vertex4xvOES_Lazy;
                EntryPoints[142] = (IntPtr)(delegate* unmanaged<RenderbufferHandle, byte>)&IsRenderbufferOES_Lazy;
                EntryPoints[143] = (IntPtr)(delegate* unmanaged<RenderbufferTarget, RenderbufferHandle, void>)&BindRenderbufferOES_Lazy;
                EntryPoints[144] = (IntPtr)(delegate* unmanaged<int, RenderbufferHandle*, void>)&DeleteRenderbuffersOES_Lazy;
                EntryPoints[145] = (IntPtr)(delegate* unmanaged<int, RenderbufferHandle*, void>)&GenRenderbuffersOES_Lazy;
                EntryPoints[146] = (IntPtr)(delegate* unmanaged<RenderbufferTarget, InternalFormat, int, int, void>)&RenderbufferStorageOES_Lazy;
                EntryPoints[147] = (IntPtr)(delegate* unmanaged<RenderbufferTarget, RenderbufferParameterName, int*, void>)&GetRenderbufferParameterivOES_Lazy;
                EntryPoints[148] = (IntPtr)(delegate* unmanaged<FramebufferHandle, byte>)&IsFramebufferOES_Lazy;
                EntryPoints[149] = (IntPtr)(delegate* unmanaged<FramebufferTarget, FramebufferHandle, void>)&BindFramebufferOES_Lazy;
                EntryPoints[150] = (IntPtr)(delegate* unmanaged<int, FramebufferHandle*, void>)&DeleteFramebuffersOES_Lazy;
                EntryPoints[151] = (IntPtr)(delegate* unmanaged<int, FramebufferHandle*, void>)&GenFramebuffersOES_Lazy;
                EntryPoints[152] = (IntPtr)(delegate* unmanaged<FramebufferTarget, FramebufferStatus>)&CheckFramebufferStatusOES_Lazy;
                EntryPoints[153] = (IntPtr)(delegate* unmanaged<FramebufferTarget, FramebufferAttachment, RenderbufferTarget, RenderbufferHandle, void>)&FramebufferRenderbufferOES_Lazy;
                EntryPoints[154] = (IntPtr)(delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureTarget, TextureHandle, int, void>)&FramebufferTexture2DOES_Lazy;
                EntryPoints[155] = (IntPtr)(delegate* unmanaged<FramebufferTarget, FramebufferAttachment, FramebufferAttachmentParameterName, int*, void>)&GetFramebufferAttachmentParameterivOES_Lazy;
                EntryPoints[156] = (IntPtr)(delegate* unmanaged<TextureTarget, void>)&GenerateMipmapOES_Lazy;
                EntryPoints[157] = (IntPtr)(delegate* unmanaged<BufferTargetARB, BufferAccessARB, void*>)&MapBufferOES_Lazy;
                EntryPoints[158] = (IntPtr)(delegate* unmanaged<All, byte>)&UnmapBufferOES_Lazy;
                EntryPoints[159] = (IntPtr)(delegate* unmanaged<BufferTargetARB, BufferPointerNameARB, void**, void>)&GetBufferPointervOES_Lazy;
                EntryPoints[160] = (IntPtr)(delegate* unmanaged<uint, void>)&CurrentPaletteMatrixOES_Lazy;
                EntryPoints[161] = (IntPtr)(delegate* unmanaged<void>)&LoadPaletteFromModelViewMatrixOES_Lazy;
                EntryPoints[162] = (IntPtr)(delegate* unmanaged<int, MatrixIndexPointerTypeARB, int, void*, void>)&MatrixIndexPointerOES_Lazy;
                EntryPoints[163] = (IntPtr)(delegate* unmanaged<int, All, int, void*, void>)&WeightPointerOES_Lazy;
                EntryPoints[164] = (IntPtr)(delegate* unmanaged<All, int, void*, void>)&PointSizePointerOES_Lazy;
                EntryPoints[165] = (IntPtr)(delegate* unmanaged<int*, int*, All>)&QueryMatrixxOES_Lazy;
                EntryPoints[166] = (IntPtr)(delegate* unmanaged<float, void>)&ClearDepthfOES_Lazy;
                EntryPoints[167] = (IntPtr)(delegate* unmanaged<ClipPlaneName, float*, void>)&ClipPlanefOES_Lazy;
                EntryPoints[168] = (IntPtr)(delegate* unmanaged<float, float, void>)&DepthRangefOES_Lazy;
                EntryPoints[169] = (IntPtr)(delegate* unmanaged<float, float, float, float, float, float, void>)&FrustumfOES_Lazy;
                EntryPoints[170] = (IntPtr)(delegate* unmanaged<ClipPlaneName, float*, void>)&GetClipPlanefOES_Lazy;
                EntryPoints[171] = (IntPtr)(delegate* unmanaged<float, float, float, float, float, float, void>)&OrthofOES_Lazy;
                EntryPoints[172] = (IntPtr)(delegate* unmanaged<TextureCoordName, TextureGenParameter, float, void>)&TexGenfOES_Lazy;
                EntryPoints[173] = (IntPtr)(delegate* unmanaged<TextureCoordName, TextureGenParameter, float*, void>)&TexGenfvOES_Lazy;
                EntryPoints[174] = (IntPtr)(delegate* unmanaged<TextureCoordName, TextureGenParameter, int, void>)&TexGeniOES_Lazy;
                EntryPoints[175] = (IntPtr)(delegate* unmanaged<TextureCoordName, TextureGenParameter, int*, void>)&TexGenivOES_Lazy;
                EntryPoints[176] = (IntPtr)(delegate* unmanaged<TextureCoordName, TextureGenParameter, float*, void>)&GetTexGenfvOES_Lazy;
                EntryPoints[177] = (IntPtr)(delegate* unmanaged<TextureCoordName, TextureGenParameter, int*, void>)&GetTexGenivOES_Lazy;
                EntryPoints[178] = (IntPtr)(delegate* unmanaged<VertexArrayHandle, void>)&BindVertexArrayOES_Lazy;
                EntryPoints[179] = (IntPtr)(delegate* unmanaged<int, VertexArrayHandle*, void>)&DeleteVertexArraysOES_Lazy;
                EntryPoints[180] = (IntPtr)(delegate* unmanaged<int, VertexArrayHandle*, void>)&GenVertexArraysOES_Lazy;
                EntryPoints[181] = (IntPtr)(delegate* unmanaged<VertexArrayHandle, byte>)&IsVertexArrayOES_Lazy;
            }
            public static void LoadAllFunctions(IBindingsContext context)
            {
                EntryPoints[0] = context.GetProcAddress("glEGLImageTargetTexture2DOES");
                EntryPoints[1] = context.GetProcAddress("glEGLImageTargetRenderbufferStorageOES");
                EntryPoints[2] = context.GetProcAddress("glBlendEquationSeparateOES");
                EntryPoints[3] = context.GetProcAddress("glBlendFuncSeparateOES");
                EntryPoints[4] = context.GetProcAddress("glBlendEquationOES");
                EntryPoints[5] = context.GetProcAddress("glMultiTexCoord1bOES");
                EntryPoints[6] = context.GetProcAddress("glMultiTexCoord1bvOES");
                EntryPoints[7] = context.GetProcAddress("glMultiTexCoord2bOES");
                EntryPoints[8] = context.GetProcAddress("glMultiTexCoord2bvOES");
                EntryPoints[9] = context.GetProcAddress("glMultiTexCoord3bOES");
                EntryPoints[10] = context.GetProcAddress("glMultiTexCoord3bvOES");
                EntryPoints[11] = context.GetProcAddress("glMultiTexCoord4bOES");
                EntryPoints[12] = context.GetProcAddress("glMultiTexCoord4bvOES");
                EntryPoints[13] = context.GetProcAddress("glTexCoord1bOES");
                EntryPoints[14] = context.GetProcAddress("glTexCoord1bvOES");
                EntryPoints[15] = context.GetProcAddress("glTexCoord2bOES");
                EntryPoints[16] = context.GetProcAddress("glTexCoord2bvOES");
                EntryPoints[17] = context.GetProcAddress("glTexCoord3bOES");
                EntryPoints[18] = context.GetProcAddress("glTexCoord3bvOES");
                EntryPoints[19] = context.GetProcAddress("glTexCoord4bOES");
                EntryPoints[20] = context.GetProcAddress("glTexCoord4bvOES");
                EntryPoints[21] = context.GetProcAddress("glVertex2bOES");
                EntryPoints[22] = context.GetProcAddress("glVertex2bvOES");
                EntryPoints[23] = context.GetProcAddress("glVertex3bOES");
                EntryPoints[24] = context.GetProcAddress("glVertex3bvOES");
                EntryPoints[25] = context.GetProcAddress("glVertex4bOES");
                EntryPoints[26] = context.GetProcAddress("glVertex4bvOES");
                EntryPoints[27] = context.GetProcAddress("glDrawTexsOES");
                EntryPoints[28] = context.GetProcAddress("glDrawTexiOES");
                EntryPoints[29] = context.GetProcAddress("glDrawTexxOES");
                EntryPoints[30] = context.GetProcAddress("glDrawTexsvOES");
                EntryPoints[31] = context.GetProcAddress("glDrawTexivOES");
                EntryPoints[32] = context.GetProcAddress("glDrawTexxvOES");
                EntryPoints[33] = context.GetProcAddress("glDrawTexfOES");
                EntryPoints[34] = context.GetProcAddress("glDrawTexfvOES");
                EntryPoints[35] = context.GetProcAddress("glAlphaFuncxOES");
                EntryPoints[36] = context.GetProcAddress("glClearColorxOES");
                EntryPoints[37] = context.GetProcAddress("glClearDepthxOES");
                EntryPoints[38] = context.GetProcAddress("glClipPlanexOES");
                EntryPoints[39] = context.GetProcAddress("glColor4xOES");
                EntryPoints[40] = context.GetProcAddress("glDepthRangexOES");
                EntryPoints[41] = context.GetProcAddress("glFogxOES");
                EntryPoints[42] = context.GetProcAddress("glFogxvOES");
                EntryPoints[43] = context.GetProcAddress("glFrustumxOES");
                EntryPoints[44] = context.GetProcAddress("glGetClipPlanexOES");
                EntryPoints[45] = context.GetProcAddress("glGetFixedvOES");
                EntryPoints[46] = context.GetProcAddress("glGetTexEnvxvOES");
                EntryPoints[47] = context.GetProcAddress("glGetTexParameterxvOES");
                EntryPoints[48] = context.GetProcAddress("glLightModelxOES");
                EntryPoints[49] = context.GetProcAddress("glLightModelxvOES");
                EntryPoints[50] = context.GetProcAddress("glLightxOES");
                EntryPoints[51] = context.GetProcAddress("glLightxvOES");
                EntryPoints[52] = context.GetProcAddress("glLineWidthxOES");
                EntryPoints[53] = context.GetProcAddress("glLoadMatrixxOES");
                EntryPoints[54] = context.GetProcAddress("glMaterialxOES");
                EntryPoints[55] = context.GetProcAddress("glMaterialxvOES");
                EntryPoints[56] = context.GetProcAddress("glMultMatrixxOES");
                EntryPoints[57] = context.GetProcAddress("glMultiTexCoord4xOES");
                EntryPoints[58] = context.GetProcAddress("glNormal3xOES");
                EntryPoints[59] = context.GetProcAddress("glOrthoxOES");
                EntryPoints[60] = context.GetProcAddress("glPointParameterxvOES");
                EntryPoints[61] = context.GetProcAddress("glPointSizexOES");
                EntryPoints[62] = context.GetProcAddress("glPolygonOffsetxOES");
                EntryPoints[63] = context.GetProcAddress("glRotatexOES");
                EntryPoints[64] = context.GetProcAddress("glScalexOES");
                EntryPoints[65] = context.GetProcAddress("glTexEnvxOES");
                EntryPoints[66] = context.GetProcAddress("glTexEnvxvOES");
                EntryPoints[67] = context.GetProcAddress("glTexParameterxOES");
                EntryPoints[68] = context.GetProcAddress("glTexParameterxvOES");
                EntryPoints[69] = context.GetProcAddress("glTranslatexOES");
                EntryPoints[70] = context.GetProcAddress("glGetLightxvOES");
                EntryPoints[71] = context.GetProcAddress("glGetMaterialxvOES");
                EntryPoints[72] = context.GetProcAddress("glPointParameterxOES");
                EntryPoints[73] = context.GetProcAddress("glSampleCoveragexOES");
                EntryPoints[74] = context.GetProcAddress("glAccumxOES");
                EntryPoints[75] = context.GetProcAddress("glBitmapxOES");
                EntryPoints[76] = context.GetProcAddress("glBlendColorxOES");
                EntryPoints[77] = context.GetProcAddress("glClearAccumxOES");
                EntryPoints[78] = context.GetProcAddress("glColor3xOES");
                EntryPoints[79] = context.GetProcAddress("glColor3xvOES");
                EntryPoints[80] = context.GetProcAddress("glColor4xvOES");
                EntryPoints[81] = context.GetProcAddress("glConvolutionParameterxOES");
                EntryPoints[82] = context.GetProcAddress("glConvolutionParameterxvOES");
                EntryPoints[83] = context.GetProcAddress("glEvalCoord1xOES");
                EntryPoints[84] = context.GetProcAddress("glEvalCoord1xvOES");
                EntryPoints[85] = context.GetProcAddress("glEvalCoord2xOES");
                EntryPoints[86] = context.GetProcAddress("glEvalCoord2xvOES");
                EntryPoints[87] = context.GetProcAddress("glFeedbackBufferxOES");
                EntryPoints[88] = context.GetProcAddress("glGetConvolutionParameterxvOES");
                EntryPoints[89] = context.GetProcAddress("glGetHistogramParameterxvOES");
                EntryPoints[90] = context.GetProcAddress("glGetLightxOES");
                EntryPoints[91] = context.GetProcAddress("glGetMapxvOES");
                EntryPoints[92] = context.GetProcAddress("glGetMaterialxOES");
                EntryPoints[93] = context.GetProcAddress("glGetPixelMapxv");
                EntryPoints[94] = context.GetProcAddress("glGetTexGenxvOES");
                EntryPoints[95] = context.GetProcAddress("glGetTexLevelParameterxvOES");
                EntryPoints[96] = context.GetProcAddress("glIndexxOES");
                EntryPoints[97] = context.GetProcAddress("glIndexxvOES");
                EntryPoints[98] = context.GetProcAddress("glLoadTransposeMatrixxOES");
                EntryPoints[99] = context.GetProcAddress("glMap1xOES");
                EntryPoints[100] = context.GetProcAddress("glMap2xOES");
                EntryPoints[101] = context.GetProcAddress("glMapGrid1xOES");
                EntryPoints[102] = context.GetProcAddress("glMapGrid2xOES");
                EntryPoints[103] = context.GetProcAddress("glMultTransposeMatrixxOES");
                EntryPoints[104] = context.GetProcAddress("glMultiTexCoord1xOES");
                EntryPoints[105] = context.GetProcAddress("glMultiTexCoord1xvOES");
                EntryPoints[106] = context.GetProcAddress("glMultiTexCoord2xOES");
                EntryPoints[107] = context.GetProcAddress("glMultiTexCoord2xvOES");
                EntryPoints[108] = context.GetProcAddress("glMultiTexCoord3xOES");
                EntryPoints[109] = context.GetProcAddress("glMultiTexCoord3xvOES");
                EntryPoints[110] = context.GetProcAddress("glMultiTexCoord4xvOES");
                EntryPoints[111] = context.GetProcAddress("glNormal3xvOES");
                EntryPoints[112] = context.GetProcAddress("glPassThroughxOES");
                EntryPoints[113] = context.GetProcAddress("glPixelMapx");
                EntryPoints[114] = context.GetProcAddress("glPixelStorex");
                EntryPoints[115] = context.GetProcAddress("glPixelTransferxOES");
                EntryPoints[116] = context.GetProcAddress("glPixelZoomxOES");
                EntryPoints[117] = context.GetProcAddress("glPrioritizeTexturesxOES");
                EntryPoints[118] = context.GetProcAddress("glRasterPos2xOES");
                EntryPoints[119] = context.GetProcAddress("glRasterPos2xvOES");
                EntryPoints[120] = context.GetProcAddress("glRasterPos3xOES");
                EntryPoints[121] = context.GetProcAddress("glRasterPos3xvOES");
                EntryPoints[122] = context.GetProcAddress("glRasterPos4xOES");
                EntryPoints[123] = context.GetProcAddress("glRasterPos4xvOES");
                EntryPoints[124] = context.GetProcAddress("glRectxOES");
                EntryPoints[125] = context.GetProcAddress("glRectxvOES");
                EntryPoints[126] = context.GetProcAddress("glTexCoord1xOES");
                EntryPoints[127] = context.GetProcAddress("glTexCoord1xvOES");
                EntryPoints[128] = context.GetProcAddress("glTexCoord2xOES");
                EntryPoints[129] = context.GetProcAddress("glTexCoord2xvOES");
                EntryPoints[130] = context.GetProcAddress("glTexCoord3xOES");
                EntryPoints[131] = context.GetProcAddress("glTexCoord3xvOES");
                EntryPoints[132] = context.GetProcAddress("glTexCoord4xOES");
                EntryPoints[133] = context.GetProcAddress("glTexCoord4xvOES");
                EntryPoints[134] = context.GetProcAddress("glTexGenxOES");
                EntryPoints[135] = context.GetProcAddress("glTexGenxvOES");
                EntryPoints[136] = context.GetProcAddress("glVertex2xOES");
                EntryPoints[137] = context.GetProcAddress("glVertex2xvOES");
                EntryPoints[138] = context.GetProcAddress("glVertex3xOES");
                EntryPoints[139] = context.GetProcAddress("glVertex3xvOES");
                EntryPoints[140] = context.GetProcAddress("glVertex4xOES");
                EntryPoints[141] = context.GetProcAddress("glVertex4xvOES");
                EntryPoints[142] = context.GetProcAddress("glIsRenderbufferOES");
                EntryPoints[143] = context.GetProcAddress("glBindRenderbufferOES");
                EntryPoints[144] = context.GetProcAddress("glDeleteRenderbuffersOES");
                EntryPoints[145] = context.GetProcAddress("glGenRenderbuffersOES");
                EntryPoints[146] = context.GetProcAddress("glRenderbufferStorageOES");
                EntryPoints[147] = context.GetProcAddress("glGetRenderbufferParameterivOES");
                EntryPoints[148] = context.GetProcAddress("glIsFramebufferOES");
                EntryPoints[149] = context.GetProcAddress("glBindFramebufferOES");
                EntryPoints[150] = context.GetProcAddress("glDeleteFramebuffersOES");
                EntryPoints[151] = context.GetProcAddress("glGenFramebuffersOES");
                EntryPoints[152] = context.GetProcAddress("glCheckFramebufferStatusOES");
                EntryPoints[153] = context.GetProcAddress("glFramebufferRenderbufferOES");
                EntryPoints[154] = context.GetProcAddress("glFramebufferTexture2DOES");
                EntryPoints[155] = context.GetProcAddress("glGetFramebufferAttachmentParameterivOES");
                EntryPoints[156] = context.GetProcAddress("glGenerateMipmapOES");
                EntryPoints[157] = context.GetProcAddress("glMapBufferOES");
                EntryPoints[158] = context.GetProcAddress("glUnmapBufferOES");
                EntryPoints[159] = context.GetProcAddress("glGetBufferPointervOES");
                EntryPoints[160] = context.GetProcAddress("glCurrentPaletteMatrixOES");
                EntryPoints[161] = context.GetProcAddress("glLoadPaletteFromModelViewMatrixOES");
                EntryPoints[162] = context.GetProcAddress("glMatrixIndexPointerOES");
                EntryPoints[163] = context.GetProcAddress("glWeightPointerOES");
                EntryPoints[164] = context.GetProcAddress("glPointSizePointerOES");
                EntryPoints[165] = context.GetProcAddress("glQueryMatrixxOES");
                EntryPoints[166] = context.GetProcAddress("glClearDepthfOES");
                EntryPoints[167] = context.GetProcAddress("glClipPlanefOES");
                EntryPoints[168] = context.GetProcAddress("glDepthRangefOES");
                EntryPoints[169] = context.GetProcAddress("glFrustumfOES");
                EntryPoints[170] = context.GetProcAddress("glGetClipPlanefOES");
                EntryPoints[171] = context.GetProcAddress("glOrthofOES");
                EntryPoints[172] = context.GetProcAddress("glTexGenfOES");
                EntryPoints[173] = context.GetProcAddress("glTexGenfvOES");
                EntryPoints[174] = context.GetProcAddress("glTexGeniOES");
                EntryPoints[175] = context.GetProcAddress("glTexGenivOES");
                EntryPoints[176] = context.GetProcAddress("glGetTexGenfvOES");
                EntryPoints[177] = context.GetProcAddress("glGetTexGenivOES");
                EntryPoints[178] = context.GetProcAddress("glBindVertexArrayOES");
                EntryPoints[179] = context.GetProcAddress("glDeleteVertexArraysOES");
                EntryPoints[180] = context.GetProcAddress("glGenVertexArraysOES");
                EntryPoints[181] = context.GetProcAddress("glIsVertexArrayOES");
            }
        }
        public static unsafe partial class QCOM
        {
            private static IntPtr[] EntryPoints;
            
            /// <summary> <b>[requires: GL_QCOM_driver_control]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetDriverControlsQCOM(int* num, int size, uint* driverControls) => ((delegate* unmanaged<int*, int, uint*, void>)EntryPoints[0])(num, size, driverControls);
            [UnmanagedCallersOnly]
            private static void GetDriverControlsQCOM_Lazy(int* num, int size, uint* driverControls)
            {
                EntryPoints[0] = GLLoader.BindingsContext.GetProcAddress("glGetDriverControlsQCOM");
                ((delegate* unmanaged<int*, int, uint*, void>)EntryPoints[0])(num, size, driverControls);
            }
            
            /// <summary> <b>[requires: GL_QCOM_driver_control]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetDriverControlStringQCOM(uint driverControl, int bufSize, int* length, byte* driverControlString) => ((delegate* unmanaged<uint, int, int*, byte*, void>)EntryPoints[1])(driverControl, bufSize, length, driverControlString);
            [UnmanagedCallersOnly]
            private static void GetDriverControlStringQCOM_Lazy(uint driverControl, int bufSize, int* length, byte* driverControlString)
            {
                EntryPoints[1] = GLLoader.BindingsContext.GetProcAddress("glGetDriverControlStringQCOM");
                ((delegate* unmanaged<uint, int, int*, byte*, void>)EntryPoints[1])(driverControl, bufSize, length, driverControlString);
            }
            
            /// <summary> <b>[requires: GL_QCOM_driver_control]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void EnableDriverControlQCOM(uint driverControl) => ((delegate* unmanaged<uint, void>)EntryPoints[2])(driverControl);
            [UnmanagedCallersOnly]
            private static void EnableDriverControlQCOM_Lazy(uint driverControl)
            {
                EntryPoints[2] = GLLoader.BindingsContext.GetProcAddress("glEnableDriverControlQCOM");
                ((delegate* unmanaged<uint, void>)EntryPoints[2])(driverControl);
            }
            
            /// <summary> <b>[requires: GL_QCOM_driver_control]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DisableDriverControlQCOM(uint driverControl) => ((delegate* unmanaged<uint, void>)EntryPoints[3])(driverControl);
            [UnmanagedCallersOnly]
            private static void DisableDriverControlQCOM_Lazy(uint driverControl)
            {
                EntryPoints[3] = GLLoader.BindingsContext.GetProcAddress("glDisableDriverControlQCOM");
                ((delegate* unmanaged<uint, void>)EntryPoints[3])(driverControl);
            }
            
            /// <summary> <b>[requires: GL_QCOM_extended_get]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ExtGetTexturesQCOM(TextureHandle* textures, int maxTextures, int* numTextures) => ((delegate* unmanaged<TextureHandle*, int, int*, void>)EntryPoints[4])(textures, maxTextures, numTextures);
            [UnmanagedCallersOnly]
            private static void ExtGetTexturesQCOM_Lazy(TextureHandle* textures, int maxTextures, int* numTextures)
            {
                EntryPoints[4] = GLLoader.BindingsContext.GetProcAddress("glExtGetTexturesQCOM");
                ((delegate* unmanaged<TextureHandle*, int, int*, void>)EntryPoints[4])(textures, maxTextures, numTextures);
            }
            
            /// <summary> <b>[requires: GL_QCOM_extended_get]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ExtGetBuffersQCOM(BufferHandle* buffers, int maxBuffers, int* numBuffers) => ((delegate* unmanaged<BufferHandle*, int, int*, void>)EntryPoints[5])(buffers, maxBuffers, numBuffers);
            [UnmanagedCallersOnly]
            private static void ExtGetBuffersQCOM_Lazy(BufferHandle* buffers, int maxBuffers, int* numBuffers)
            {
                EntryPoints[5] = GLLoader.BindingsContext.GetProcAddress("glExtGetBuffersQCOM");
                ((delegate* unmanaged<BufferHandle*, int, int*, void>)EntryPoints[5])(buffers, maxBuffers, numBuffers);
            }
            
            /// <summary> <b>[requires: GL_QCOM_extended_get]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ExtGetRenderbuffersQCOM(RenderbufferHandle* renderbuffers, int maxRenderbuffers, int* numRenderbuffers) => ((delegate* unmanaged<RenderbufferHandle*, int, int*, void>)EntryPoints[6])(renderbuffers, maxRenderbuffers, numRenderbuffers);
            [UnmanagedCallersOnly]
            private static void ExtGetRenderbuffersQCOM_Lazy(RenderbufferHandle* renderbuffers, int maxRenderbuffers, int* numRenderbuffers)
            {
                EntryPoints[6] = GLLoader.BindingsContext.GetProcAddress("glExtGetRenderbuffersQCOM");
                ((delegate* unmanaged<RenderbufferHandle*, int, int*, void>)EntryPoints[6])(renderbuffers, maxRenderbuffers, numRenderbuffers);
            }
            
            /// <summary> <b>[requires: GL_QCOM_extended_get]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ExtGetFramebuffersQCOM(FramebufferHandle* framebuffers, int maxFramebuffers, int* numFramebuffers) => ((delegate* unmanaged<FramebufferHandle*, int, int*, void>)EntryPoints[7])(framebuffers, maxFramebuffers, numFramebuffers);
            [UnmanagedCallersOnly]
            private static void ExtGetFramebuffersQCOM_Lazy(FramebufferHandle* framebuffers, int maxFramebuffers, int* numFramebuffers)
            {
                EntryPoints[7] = GLLoader.BindingsContext.GetProcAddress("glExtGetFramebuffersQCOM");
                ((delegate* unmanaged<FramebufferHandle*, int, int*, void>)EntryPoints[7])(framebuffers, maxFramebuffers, numFramebuffers);
            }
            
            /// <summary> <b>[requires: GL_QCOM_extended_get]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ExtGetTexLevelParameterivQCOM(TextureHandle texture, All face, int level, All pname, int* parameters) => ((delegate* unmanaged<TextureHandle, All, int, All, int*, void>)EntryPoints[8])(texture, face, level, pname, parameters);
            [UnmanagedCallersOnly]
            private static void ExtGetTexLevelParameterivQCOM_Lazy(TextureHandle texture, All face, int level, All pname, int* parameters)
            {
                EntryPoints[8] = GLLoader.BindingsContext.GetProcAddress("glExtGetTexLevelParameterivQCOM");
                ((delegate* unmanaged<TextureHandle, All, int, All, int*, void>)EntryPoints[8])(texture, face, level, pname, parameters);
            }
            
            /// <summary> <b>[requires: GL_QCOM_extended_get]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ExtTexObjectStateOverrideiQCOM(All target, All pname, int param) => ((delegate* unmanaged<All, All, int, void>)EntryPoints[9])(target, pname, param);
            [UnmanagedCallersOnly]
            private static void ExtTexObjectStateOverrideiQCOM_Lazy(All target, All pname, int param)
            {
                EntryPoints[9] = GLLoader.BindingsContext.GetProcAddress("glExtTexObjectStateOverrideiQCOM");
                ((delegate* unmanaged<All, All, int, void>)EntryPoints[9])(target, pname, param);
            }
            
            /// <summary> <b>[requires: GL_QCOM_extended_get]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ExtGetTexSubImageQCOM(All target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* texels) => ((delegate* unmanaged<All, int, int, int, int, int, int, int, PixelFormat, PixelType, void*, void>)EntryPoints[10])(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, texels);
            [UnmanagedCallersOnly]
            private static void ExtGetTexSubImageQCOM_Lazy(All target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* texels)
            {
                EntryPoints[10] = GLLoader.BindingsContext.GetProcAddress("glExtGetTexSubImageQCOM");
                ((delegate* unmanaged<All, int, int, int, int, int, int, int, PixelFormat, PixelType, void*, void>)EntryPoints[10])(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, texels);
            }
            
            /// <summary> <b>[requires: GL_QCOM_extended_get]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ExtGetBufferPointervQCOM(All target, void** parameters) => ((delegate* unmanaged<All, void**, void>)EntryPoints[11])(target, parameters);
            [UnmanagedCallersOnly]
            private static void ExtGetBufferPointervQCOM_Lazy(All target, void** parameters)
            {
                EntryPoints[11] = GLLoader.BindingsContext.GetProcAddress("glExtGetBufferPointervQCOM");
                ((delegate* unmanaged<All, void**, void>)EntryPoints[11])(target, parameters);
            }
            
            /// <summary> <b>[requires: GL_QCOM_extended_get2]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ExtGetShadersQCOM(ShaderHandle* shaders, int maxShaders, int* numShaders) => ((delegate* unmanaged<ShaderHandle*, int, int*, void>)EntryPoints[12])(shaders, maxShaders, numShaders);
            [UnmanagedCallersOnly]
            private static void ExtGetShadersQCOM_Lazy(ShaderHandle* shaders, int maxShaders, int* numShaders)
            {
                EntryPoints[12] = GLLoader.BindingsContext.GetProcAddress("glExtGetShadersQCOM");
                ((delegate* unmanaged<ShaderHandle*, int, int*, void>)EntryPoints[12])(shaders, maxShaders, numShaders);
            }
            
            /// <summary> <b>[requires: GL_QCOM_extended_get2]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ExtGetProgramsQCOM(ProgramHandle* programs, int maxPrograms, int* numPrograms) => ((delegate* unmanaged<ProgramHandle*, int, int*, void>)EntryPoints[13])(programs, maxPrograms, numPrograms);
            [UnmanagedCallersOnly]
            private static void ExtGetProgramsQCOM_Lazy(ProgramHandle* programs, int maxPrograms, int* numPrograms)
            {
                EntryPoints[13] = GLLoader.BindingsContext.GetProcAddress("glExtGetProgramsQCOM");
                ((delegate* unmanaged<ProgramHandle*, int, int*, void>)EntryPoints[13])(programs, maxPrograms, numPrograms);
            }
            
            /// <summary> <b>[requires: GL_QCOM_extended_get2]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static byte ExtIsProgramBinaryQCOM(ProgramHandle program) => ((delegate* unmanaged<ProgramHandle, byte>)EntryPoints[14])(program);
            [UnmanagedCallersOnly]
            private static byte ExtIsProgramBinaryQCOM_Lazy(ProgramHandle program)
            {
                EntryPoints[14] = GLLoader.BindingsContext.GetProcAddress("glExtIsProgramBinaryQCOM");
                return ((delegate* unmanaged<ProgramHandle, byte>)EntryPoints[14])(program);
            }
            
            /// <summary> <b>[requires: GL_QCOM_extended_get2]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ExtGetProgramBinarySourceQCOM(ProgramHandle program, ShaderType shadertype, byte* source, int* length) => ((delegate* unmanaged<ProgramHandle, ShaderType, byte*, int*, void>)EntryPoints[15])(program, shadertype, source, length);
            [UnmanagedCallersOnly]
            private static void ExtGetProgramBinarySourceQCOM_Lazy(ProgramHandle program, ShaderType shadertype, byte* source, int* length)
            {
                EntryPoints[15] = GLLoader.BindingsContext.GetProcAddress("glExtGetProgramBinarySourceQCOM");
                ((delegate* unmanaged<ProgramHandle, ShaderType, byte*, int*, void>)EntryPoints[15])(program, shadertype, source, length);
            }
            
            /// <summary> <b>[requires: GL_QCOM_tiled_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void StartTilingQCOM(uint x, uint y, uint width, uint height, BufferBitQCOM preserveMask) => ((delegate* unmanaged<uint, uint, uint, uint, BufferBitQCOM, void>)EntryPoints[16])(x, y, width, height, preserveMask);
            [UnmanagedCallersOnly]
            private static void StartTilingQCOM_Lazy(uint x, uint y, uint width, uint height, BufferBitQCOM preserveMask)
            {
                EntryPoints[16] = GLLoader.BindingsContext.GetProcAddress("glStartTilingQCOM");
                ((delegate* unmanaged<uint, uint, uint, uint, BufferBitQCOM, void>)EntryPoints[16])(x, y, width, height, preserveMask);
            }
            
            /// <summary> <b>[requires: GL_QCOM_tiled_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void EndTilingQCOM(BufferBitQCOM preserveMask) => ((delegate* unmanaged<BufferBitQCOM, void>)EntryPoints[17])(preserveMask);
            [UnmanagedCallersOnly]
            private static void EndTilingQCOM_Lazy(BufferBitQCOM preserveMask)
            {
                EntryPoints[17] = GLLoader.BindingsContext.GetProcAddress("glEndTilingQCOM");
                ((delegate* unmanaged<BufferBitQCOM, void>)EntryPoints[17])(preserveMask);
            }
            
            static QCOM()
            {
                EntryPoints = new IntPtr[18];
                EntryPoints[0] = (IntPtr)(delegate* unmanaged<int*, int, uint*, void>)&GetDriverControlsQCOM_Lazy;
                EntryPoints[1] = (IntPtr)(delegate* unmanaged<uint, int, int*, byte*, void>)&GetDriverControlStringQCOM_Lazy;
                EntryPoints[2] = (IntPtr)(delegate* unmanaged<uint, void>)&EnableDriverControlQCOM_Lazy;
                EntryPoints[3] = (IntPtr)(delegate* unmanaged<uint, void>)&DisableDriverControlQCOM_Lazy;
                EntryPoints[4] = (IntPtr)(delegate* unmanaged<TextureHandle*, int, int*, void>)&ExtGetTexturesQCOM_Lazy;
                EntryPoints[5] = (IntPtr)(delegate* unmanaged<BufferHandle*, int, int*, void>)&ExtGetBuffersQCOM_Lazy;
                EntryPoints[6] = (IntPtr)(delegate* unmanaged<RenderbufferHandle*, int, int*, void>)&ExtGetRenderbuffersQCOM_Lazy;
                EntryPoints[7] = (IntPtr)(delegate* unmanaged<FramebufferHandle*, int, int*, void>)&ExtGetFramebuffersQCOM_Lazy;
                EntryPoints[8] = (IntPtr)(delegate* unmanaged<TextureHandle, All, int, All, int*, void>)&ExtGetTexLevelParameterivQCOM_Lazy;
                EntryPoints[9] = (IntPtr)(delegate* unmanaged<All, All, int, void>)&ExtTexObjectStateOverrideiQCOM_Lazy;
                EntryPoints[10] = (IntPtr)(delegate* unmanaged<All, int, int, int, int, int, int, int, PixelFormat, PixelType, void*, void>)&ExtGetTexSubImageQCOM_Lazy;
                EntryPoints[11] = (IntPtr)(delegate* unmanaged<All, void**, void>)&ExtGetBufferPointervQCOM_Lazy;
                EntryPoints[12] = (IntPtr)(delegate* unmanaged<ShaderHandle*, int, int*, void>)&ExtGetShadersQCOM_Lazy;
                EntryPoints[13] = (IntPtr)(delegate* unmanaged<ProgramHandle*, int, int*, void>)&ExtGetProgramsQCOM_Lazy;
                EntryPoints[14] = (IntPtr)(delegate* unmanaged<ProgramHandle, byte>)&ExtIsProgramBinaryQCOM_Lazy;
                EntryPoints[15] = (IntPtr)(delegate* unmanaged<ProgramHandle, ShaderType, byte*, int*, void>)&ExtGetProgramBinarySourceQCOM_Lazy;
                EntryPoints[16] = (IntPtr)(delegate* unmanaged<uint, uint, uint, uint, BufferBitQCOM, void>)&StartTilingQCOM_Lazy;
                EntryPoints[17] = (IntPtr)(delegate* unmanaged<BufferBitQCOM, void>)&EndTilingQCOM_Lazy;
            }
            public static void LoadAllFunctions(IBindingsContext context)
            {
                EntryPoints[0] = context.GetProcAddress("glGetDriverControlsQCOM");
                EntryPoints[1] = context.GetProcAddress("glGetDriverControlStringQCOM");
                EntryPoints[2] = context.GetProcAddress("glEnableDriverControlQCOM");
                EntryPoints[3] = context.GetProcAddress("glDisableDriverControlQCOM");
                EntryPoints[4] = context.GetProcAddress("glExtGetTexturesQCOM");
                EntryPoints[5] = context.GetProcAddress("glExtGetBuffersQCOM");
                EntryPoints[6] = context.GetProcAddress("glExtGetRenderbuffersQCOM");
                EntryPoints[7] = context.GetProcAddress("glExtGetFramebuffersQCOM");
                EntryPoints[8] = context.GetProcAddress("glExtGetTexLevelParameterivQCOM");
                EntryPoints[9] = context.GetProcAddress("glExtTexObjectStateOverrideiQCOM");
                EntryPoints[10] = context.GetProcAddress("glExtGetTexSubImageQCOM");
                EntryPoints[11] = context.GetProcAddress("glExtGetBufferPointervQCOM");
                EntryPoints[12] = context.GetProcAddress("glExtGetShadersQCOM");
                EntryPoints[13] = context.GetProcAddress("glExtGetProgramsQCOM");
                EntryPoints[14] = context.GetProcAddress("glExtIsProgramBinaryQCOM");
                EntryPoints[15] = context.GetProcAddress("glExtGetProgramBinarySourceQCOM");
                EntryPoints[16] = context.GetProcAddress("glStartTilingQCOM");
                EntryPoints[17] = context.GetProcAddress("glEndTilingQCOM");
            }
        }
    }
}
