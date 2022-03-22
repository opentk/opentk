// This file is auto generated, do not edit.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using OpenTK.Mathematics;
using OpenTK.Graphics;

namespace OpenTK.Graphics.OpenGLES1
{
    public static unsafe partial class GL
    {
        /// <summary> Specify a plane against which all geometry is    clipped. </summary>
        public static unsafe void ClipPlanef(ClipPlaneName p, ReadOnlySpan<float> eqn)
        {
            fixed (float* eqn_ptr = eqn)
            {
                ClipPlanef(p, eqn_ptr);
            }
        }
        /// <summary> Specify a plane against which all geometry is    clipped. </summary>
        public static unsafe void ClipPlanef(ClipPlaneName p, float[] eqn)
        {
            fixed (float* eqn_ptr = eqn)
            {
                ClipPlanef(p, eqn_ptr);
            }
        }
        /// <summary> Specify a plane against which all geometry is    clipped. </summary>
        public static unsafe void ClipPlanef(ClipPlaneName p, in float eqn)
        {
            fixed (float* eqn_ptr = &eqn)
            {
                ClipPlanef(p, eqn_ptr);
            }
        }
        public static unsafe void Fogf(FogParameter pname, ReadOnlySpan<float> parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                Fogfv(pname, parameters_ptr);
            }
        }
        public static unsafe void Fogf(FogParameter pname, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                Fogfv(pname, parameters_ptr);
            }
        }
        public static unsafe void Fogf(FogParameter pname, in float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                Fogfv(pname, parameters_ptr);
            }
        }
        /// <summary> Return the coefficients of the specified clipping    plane. </summary>
        /// <param name="plane">Specifies a clipping plane. The number of clipping planes depends on the implementation, but at least six clipping planes are supported. Symbolic names of the form GL_CLIP_PLANE i, where i is an integer between 0 and GL_MAX_CLIP_PLANES -1 , are accepted.</param>
        /// <param name="equation">Returns four fixed-point or floating-point values that are the coefficients of the plane equation of plane in eye coordinates in the order p1, p2, p3, and p4. The initial value is (0, 0, 0, 0).</param>
        public static unsafe void GetClipPlanef(ClipPlaneName plane, Span<float> equation)
        {
            fixed (float* equation_ptr = equation)
            {
                GetClipPlanef(plane, equation_ptr);
            }
        }
        /// <summary> Return the coefficients of the specified clipping    plane. </summary>
        /// <param name="plane">Specifies a clipping plane. The number of clipping planes depends on the implementation, but at least six clipping planes are supported. Symbolic names of the form GL_CLIP_PLANE i, where i is an integer between 0 and GL_MAX_CLIP_PLANES -1 , are accepted.</param>
        /// <param name="equation">Returns four fixed-point or floating-point values that are the coefficients of the plane equation of plane in eye coordinates in the order p1, p2, p3, and p4. The initial value is (0, 0, 0, 0).</param>
        public static unsafe void GetClipPlanef(ClipPlaneName plane, float[] equation)
        {
            fixed (float* equation_ptr = equation)
            {
                GetClipPlanef(plane, equation_ptr);
            }
        }
        /// <summary> Return the coefficients of the specified clipping    plane. </summary>
        /// <param name="plane">Specifies a clipping plane. The number of clipping planes depends on the implementation, but at least six clipping planes are supported. Symbolic names of the form GL_CLIP_PLANE i, where i is an integer between 0 and GL_MAX_CLIP_PLANES -1 , are accepted.</param>
        /// <param name="equation">Returns four fixed-point or floating-point values that are the coefficients of the plane equation of plane in eye coordinates in the order p1, p2, p3, and p4. The initial value is (0, 0, 0, 0).</param>
        public static unsafe void GetClipPlanef(ClipPlaneName plane, ref float equation)
        {
            fixed (float* equation_ptr = &equation)
            {
                GetClipPlanef(plane, equation_ptr);
            }
        }
        /// <summary> Return the value or values of a selected parameter. </summary>
        /// <param name="pname">Specifies the parameter value to be returned. The symbolic constants in the list below are accepted.</param>
        public static unsafe void GetFloat(GetPName pname, Span<float> data)
        {
            fixed (float* data_ptr = data)
            {
                GetFloatv(pname, data_ptr);
            }
        }
        /// <summary> Return the value or values of a selected parameter. </summary>
        /// <param name="pname">Specifies the parameter value to be returned. The symbolic constants in the list below are accepted.</param>
        public static unsafe void GetFloat(GetPName pname, float[] data)
        {
            fixed (float* data_ptr = data)
            {
                GetFloatv(pname, data_ptr);
            }
        }
        /// <summary> Return the value or values of a selected parameter. </summary>
        /// <param name="pname">Specifies the parameter value to be returned. The symbolic constants in the list below are accepted.</param>
        public static unsafe void GetFloat(GetPName pname, ref float data)
        {
            fixed (float* data_ptr = &data)
            {
                GetFloatv(pname, data_ptr);
            }
        }
        /// <summary> Return light source parameter values. </summary>
        /// <param name="light"> Specifies a light source. The number of possible lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form GL_LIGHTi where 0<i< GL_MAX_LIGHTS </param>
        /// <param name="pname"> Specifies a light source parameter for light. Accepted symbolic names are GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_POSITION, GL_SPOT_DIRECTION, GL_SPOT_EXPONENT, GL_SPOT_CUTOFF, GL_CONSTANT_ATTENUATION, GL_LINEAR_ATTENUATION, and GL_QUADRATIC_ATTENUATION. </param>
        public static unsafe void GetLightf(LightName light, LightParameter pname, Span<float> parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetLightfv(light, pname, parameters_ptr);
            }
        }
        /// <summary> Return light source parameter values. </summary>
        /// <param name="light"> Specifies a light source. The number of possible lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form GL_LIGHTi where 0<i< GL_MAX_LIGHTS </param>
        /// <param name="pname"> Specifies a light source parameter for light. Accepted symbolic names are GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_POSITION, GL_SPOT_DIRECTION, GL_SPOT_EXPONENT, GL_SPOT_CUTOFF, GL_CONSTANT_ATTENUATION, GL_LINEAR_ATTENUATION, and GL_QUADRATIC_ATTENUATION. </param>
        public static unsafe void GetLightf(LightName light, LightParameter pname, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetLightfv(light, pname, parameters_ptr);
            }
        }
        /// <summary> Return light source parameter values. </summary>
        /// <param name="light"> Specifies a light source. The number of possible lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form GL_LIGHTi where 0<i< GL_MAX_LIGHTS </param>
        /// <param name="pname"> Specifies a light source parameter for light. Accepted symbolic names are GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_POSITION, GL_SPOT_DIRECTION, GL_SPOT_EXPONENT, GL_SPOT_CUTOFF, GL_CONSTANT_ATTENUATION, GL_LINEAR_ATTENUATION, and GL_QUADRATIC_ATTENUATION. </param>
        public static unsafe void GetLightf(LightName light, LightParameter pname, ref float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                GetLightfv(light, pname, parameters_ptr);
            }
        }
        /// <summary> Return material parameters values. </summary>
        /// <param name="face"> Specifies which of the two materials is being queried. GL_FRONT or GL_BACK are accepted, representing the front and back materials, respectively. </param>
        /// <param name="pname"> Specifies the material parameter to return. Accepted symbolic names are GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_EMISSION, and GL_SHININESS. </param>
        public static unsafe void GetMaterialf(MaterialFace face, MaterialParameter pname, Span<float> parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetMaterialfv(face, pname, parameters_ptr);
            }
        }
        /// <summary> Return material parameters values. </summary>
        /// <param name="face"> Specifies which of the two materials is being queried. GL_FRONT or GL_BACK are accepted, representing the front and back materials, respectively. </param>
        /// <param name="pname"> Specifies the material parameter to return. Accepted symbolic names are GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_EMISSION, and GL_SHININESS. </param>
        public static unsafe void GetMaterialf(MaterialFace face, MaterialParameter pname, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetMaterialfv(face, pname, parameters_ptr);
            }
        }
        /// <summary> Return material parameters values. </summary>
        /// <param name="face"> Specifies which of the two materials is being queried. GL_FRONT or GL_BACK are accepted, representing the front and back materials, respectively. </param>
        /// <param name="pname"> Specifies the material parameter to return. Accepted symbolic names are GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_EMISSION, and GL_SHININESS. </param>
        public static unsafe void GetMaterialf(MaterialFace face, MaterialParameter pname, ref float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                GetMaterialfv(face, pname, parameters_ptr);
            }
        }
        /// <summary> Return texture environment parameters. </summary>
        /// <param name="target"> Specifies a texture environment. May be GL_TEXTURE_ENV or GL_POINT_SPRITE_OES. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture environment parameter. Accepted values are GL_TEXTURE_ENV_MODE, GL_TEXTURE_ENV_COLOR, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE_OES. </param>
        public static unsafe void GetTexEnvf(TextureEnvTarget target, TextureEnvParameter pname, Span<float> parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetTexEnvfv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Return texture environment parameters. </summary>
        /// <param name="target"> Specifies a texture environment. May be GL_TEXTURE_ENV or GL_POINT_SPRITE_OES. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture environment parameter. Accepted values are GL_TEXTURE_ENV_MODE, GL_TEXTURE_ENV_COLOR, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE_OES. </param>
        public static unsafe void GetTexEnvf(TextureEnvTarget target, TextureEnvParameter pname, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetTexEnvfv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Return texture environment parameters. </summary>
        /// <param name="target"> Specifies a texture environment. May be GL_TEXTURE_ENV or GL_POINT_SPRITE_OES. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture environment parameter. Accepted values are GL_TEXTURE_ENV_MODE, GL_TEXTURE_ENV_COLOR, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE_OES. </param>
        public static unsafe void GetTexEnvf(TextureEnvTarget target, TextureEnvParameter pname, ref float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                GetTexEnvfv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Return texture parameter values. </summary>
        /// <param name="target">Specifies the target texture, which must be GL_TEXTURE_2D.</param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. Which can be one of the following: GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_GENERATE_MIPMAP. </param>
        public static unsafe void GetTexParameterf(TextureTarget target, GetTextureParameter pname, Span<float> parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetTexParameterfv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Return texture parameter values. </summary>
        /// <param name="target">Specifies the target texture, which must be GL_TEXTURE_2D.</param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. Which can be one of the following: GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_GENERATE_MIPMAP. </param>
        public static unsafe void GetTexParameterf(TextureTarget target, GetTextureParameter pname, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetTexParameterfv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Return texture parameter values. </summary>
        /// <param name="target">Specifies the target texture, which must be GL_TEXTURE_2D.</param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. Which can be one of the following: GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_GENERATE_MIPMAP. </param>
        public static unsafe void GetTexParameterf(TextureTarget target, GetTextureParameter pname, ref float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                GetTexParameterfv(target, pname, parameters_ptr);
            }
        }
        public static unsafe void LightModelf(LightModelParameter pname, ReadOnlySpan<float> parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                LightModelfv(pname, parameters_ptr);
            }
        }
        public static unsafe void LightModelf(LightModelParameter pname, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                LightModelfv(pname, parameters_ptr);
            }
        }
        public static unsafe void LightModelf(LightModelParameter pname, in float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                LightModelfv(pname, parameters_ptr);
            }
        }
        public static unsafe void Lightf(LightName light, LightParameter pname, ReadOnlySpan<float> parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                Lightfv(light, pname, parameters_ptr);
            }
        }
        public static unsafe void Lightf(LightName light, LightParameter pname, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                Lightfv(light, pname, parameters_ptr);
            }
        }
        public static unsafe void Lightf(LightName light, LightParameter pname, in float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                Lightfv(light, pname, parameters_ptr);
            }
        }
        /// <summary> Replace the current matrix with the specifiedmatrix. </summary>
        /// <param name="m">Specifies a pointer to 16 consecutive values, which are used as the elements of a 4x4 column-major matrix.</param>
        public static unsafe void LoadMatrixf(ReadOnlySpan<float> m)
        {
            fixed (float* m_ptr = m)
            {
                LoadMatrixf(m_ptr);
            }
        }
        /// <summary> Replace the current matrix with the specifiedmatrix. </summary>
        /// <param name="m">Specifies a pointer to 16 consecutive values, which are used as the elements of a 4x4 column-major matrix.</param>
        public static unsafe void LoadMatrixf(float[] m)
        {
            fixed (float* m_ptr = m)
            {
                LoadMatrixf(m_ptr);
            }
        }
        /// <summary> Replace the current matrix with the specifiedmatrix. </summary>
        /// <param name="m">Specifies a pointer to 16 consecutive values, which are used as the elements of a 4x4 column-major matrix.</param>
        public static unsafe void LoadMatrixf(in float m)
        {
            fixed (float* m_ptr = &m)
            {
                LoadMatrixf(m_ptr);
            }
        }
        public static unsafe void Materialf(MaterialFace face, MaterialParameter pname, ReadOnlySpan<float> parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                Materialfv(face, pname, parameters_ptr);
            }
        }
        public static unsafe void Materialf(MaterialFace face, MaterialParameter pname, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                Materialfv(face, pname, parameters_ptr);
            }
        }
        public static unsafe void Materialf(MaterialFace face, MaterialParameter pname, in float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                Materialfv(face, pname, parameters_ptr);
            }
        }
        /// <summary> Multiply the current matrix with the specifiedmatrix. </summary>
        /// <param name="m">Points to 16 consecutive values that are used as the elements of a 4x4 column-major matrix.</param>
        public static unsafe void MultMatrixf(ReadOnlySpan<float> m)
        {
            fixed (float* m_ptr = m)
            {
                MultMatrixf(m_ptr);
            }
        }
        /// <summary> Multiply the current matrix with the specifiedmatrix. </summary>
        /// <param name="m">Points to 16 consecutive values that are used as the elements of a 4x4 column-major matrix.</param>
        public static unsafe void MultMatrixf(float[] m)
        {
            fixed (float* m_ptr = m)
            {
                MultMatrixf(m_ptr);
            }
        }
        /// <summary> Multiply the current matrix with the specifiedmatrix. </summary>
        /// <param name="m">Points to 16 consecutive values that are used as the elements of a 4x4 column-major matrix.</param>
        public static unsafe void MultMatrixf(in float m)
        {
            fixed (float* m_ptr = &m)
            {
                MultMatrixf(m_ptr);
            }
        }
        public static unsafe void PointParameterf(PointParameterNameARB pname, ReadOnlySpan<float> parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                PointParameterfv(pname, parameters_ptr);
            }
        }
        public static unsafe void PointParameterf(PointParameterNameARB pname, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                PointParameterfv(pname, parameters_ptr);
            }
        }
        public static unsafe void PointParameterf(PointParameterNameARB pname, in float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                PointParameterfv(pname, parameters_ptr);
            }
        }
        public static unsafe void TexEnvf(TextureEnvTarget target, TextureEnvParameter pname, ReadOnlySpan<float> parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                TexEnvfv(target, pname, parameters_ptr);
            }
        }
        public static unsafe void TexEnvf(TextureEnvTarget target, TextureEnvParameter pname, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                TexEnvfv(target, pname, parameters_ptr);
            }
        }
        public static unsafe void TexEnvf(TextureEnvTarget target, TextureEnvParameter pname, in float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                TexEnvfv(target, pname, parameters_ptr);
            }
        }
        public static unsafe void TexParameterf(TextureTarget target, TextureParameterName pname, ReadOnlySpan<float> parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                TexParameterfv(target, pname, parameters_ptr);
            }
        }
        public static unsafe void TexParameterf(TextureTarget target, TextureParameterName pname, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                TexParameterfv(target, pname, parameters_ptr);
            }
        }
        public static unsafe void TexParameterf(TextureTarget target, TextureParameterName pname, in float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                TexParameterfv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Creates and initializes a buffer object's data store.. </summary>
        /// <param name="target"> Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER or GL_ELEMENT_ARRAY_BUFFER. </param>
        /// <param name="size">Specifies the size in bytes of the buffer object's new data store.</param>
        /// <param name="data">Specifies a pointer to data that will be copied into the data store for initialization, or NULL if no data is to be copied.</param>
        /// <param name="usage"> Specifies the expected usage pattern of the data store. The symbolic constant must be GL_STATIC_DRAW or GL_DYNAMIC_DRAW. </param>
        public static unsafe void BufferData(BufferTargetARB target, nint size, IntPtr data, BufferUsageARB usage)
        {
            void* data_vptr = (void*)data;
            BufferData(target, size, data_vptr, usage);
        }
        /// <summary> Creates and initializes a buffer object's data store.. </summary>
        /// <param name="target"> Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER or GL_ELEMENT_ARRAY_BUFFER. </param>
        /// <param name="data">Specifies a pointer to data that will be copied into the data store for initialization, or NULL if no data is to be copied.</param>
        /// <param name="usage"> Specifies the expected usage pattern of the data store. The symbolic constant must be GL_STATIC_DRAW or GL_DYNAMIC_DRAW. </param>
        public static unsafe void BufferData<T1>(BufferTargetARB target, ReadOnlySpan<T1> data, BufferUsageARB usage)
            where T1 : unmanaged
        {
            nint size = (nint)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                BufferData(target, size, data_ptr, usage);
            }
        }
        /// <summary> Creates and initializes a buffer object's data store.. </summary>
        /// <param name="target"> Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER or GL_ELEMENT_ARRAY_BUFFER. </param>
        /// <param name="data">Specifies a pointer to data that will be copied into the data store for initialization, or NULL if no data is to be copied.</param>
        /// <param name="usage"> Specifies the expected usage pattern of the data store. The symbolic constant must be GL_STATIC_DRAW or GL_DYNAMIC_DRAW. </param>
        public static unsafe void BufferData<T1>(BufferTargetARB target, T1[] data, BufferUsageARB usage)
            where T1 : unmanaged
        {
            nint size = (nint)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                BufferData(target, size, data_ptr, usage);
            }
        }
        /// <summary> Creates and initializes a buffer object's data store.. </summary>
        /// <param name="target"> Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER or GL_ELEMENT_ARRAY_BUFFER. </param>
        /// <param name="size">Specifies the size in bytes of the buffer object's new data store.</param>
        /// <param name="data">Specifies a pointer to data that will be copied into the data store for initialization, or NULL if no data is to be copied.</param>
        /// <param name="usage"> Specifies the expected usage pattern of the data store. The symbolic constant must be GL_STATIC_DRAW or GL_DYNAMIC_DRAW. </param>
        public static unsafe void BufferData<T1>(BufferTargetARB target, nint size, in T1 data, BufferUsageARB usage)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = &data)
            {
                BufferData(target, size, data_ptr, usage);
            }
        }
        /// <summary> Updates a subset of a buffer object's data store.. </summary>
        /// <param name="target"> Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER or GL_ELEMENT_ARRAY_BUFFER. </param>
        /// <param name="offset">Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes.</param>
        /// <param name="size">Specifies the size in bytes of the data store region being replaced.</param>
        /// <param name="data"> Specifies a pointer to the new data that will be copied into the data store.</param>
        public static unsafe void BufferSubData(BufferTargetARB target, IntPtr offset, nint size, IntPtr data)
        {
            void* data_vptr = (void*)data;
            BufferSubData(target, offset, size, data_vptr);
        }
        /// <summary> Updates a subset of a buffer object's data store.. </summary>
        /// <param name="target"> Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER or GL_ELEMENT_ARRAY_BUFFER. </param>
        /// <param name="offset">Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes.</param>
        /// <param name="data"> Specifies a pointer to the new data that will be copied into the data store.</param>
        public static unsafe void BufferSubData<T1>(BufferTargetARB target, IntPtr offset, ReadOnlySpan<T1> data)
            where T1 : unmanaged
        {
            nint size = (nint)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                BufferSubData(target, offset, size, data_ptr);
            }
        }
        /// <summary> Updates a subset of a buffer object's data store.. </summary>
        /// <param name="target"> Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER or GL_ELEMENT_ARRAY_BUFFER. </param>
        /// <param name="offset">Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes.</param>
        /// <param name="data"> Specifies a pointer to the new data that will be copied into the data store.</param>
        public static unsafe void BufferSubData<T1>(BufferTargetARB target, IntPtr offset, T1[] data)
            where T1 : unmanaged
        {
            nint size = (nint)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                BufferSubData(target, offset, size, data_ptr);
            }
        }
        /// <summary> Updates a subset of a buffer object's data store.. </summary>
        /// <param name="target"> Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER or GL_ELEMENT_ARRAY_BUFFER. </param>
        /// <param name="offset">Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes.</param>
        /// <param name="size">Specifies the size in bytes of the data store region being replaced.</param>
        /// <param name="data"> Specifies a pointer to the new data that will be copied into the data store.</param>
        public static unsafe void BufferSubData<T1>(BufferTargetARB target, IntPtr offset, nint size, in T1 data)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = &data)
            {
                BufferSubData(target, offset, size, data_ptr);
            }
        }
        /// <summary> Specify a plane against which all geometry is    clipped. </summary>
        /// <param name="plane">Specifies which clipping plane is being positioned. Symbolic names of the form GL_CLIP_PLANEi, where i is an integer between 0 and GL_MAX_CLIP_PLANES -1 , are accepted.</param>
        /// <param name="equation">Specifies the address of an array of four fixed-point or floating-point values. These are the coefficients of a plane equation in object coordinates: p1, p2, p3, and p4, in that order.</param>
        public static unsafe void ClipPlanex(ClipPlaneName plane, ReadOnlySpan<int> equation)
        {
            fixed (int* equation_ptr = equation)
            {
                ClipPlanex(plane, equation_ptr);
            }
        }
        /// <summary> Specify a plane against which all geometry is    clipped. </summary>
        /// <param name="plane">Specifies which clipping plane is being positioned. Symbolic names of the form GL_CLIP_PLANEi, where i is an integer between 0 and GL_MAX_CLIP_PLANES -1 , are accepted.</param>
        /// <param name="equation">Specifies the address of an array of four fixed-point or floating-point values. These are the coefficients of a plane equation in object coordinates: p1, p2, p3, and p4, in that order.</param>
        public static unsafe void ClipPlanex(ClipPlaneName plane, int[] equation)
        {
            fixed (int* equation_ptr = equation)
            {
                ClipPlanex(plane, equation_ptr);
            }
        }
        /// <summary> Specify a plane against which all geometry is    clipped. </summary>
        /// <param name="plane">Specifies which clipping plane is being positioned. Symbolic names of the form GL_CLIP_PLANEi, where i is an integer between 0 and GL_MAX_CLIP_PLANES -1 , are accepted.</param>
        /// <param name="equation">Specifies the address of an array of four fixed-point or floating-point values. These are the coefficients of a plane equation in object coordinates: p1, p2, p3, and p4, in that order.</param>
        public static unsafe void ClipPlanex(ClipPlaneName plane, in int equation)
        {
            fixed (int* equation_ptr = &equation)
            {
                ClipPlanex(plane, equation_ptr);
            }
        }
        /// <summary> Set the current color. </summary>
        /// <param name="red">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <param name="green">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <param name="blue">Specify new red, green, blue, and alpha values for the current color.</param>
        /// <param name="alpha">Specify new red, green, blue, and alpha values for the current color.</param>
        public static unsafe void Color4(byte red, byte green, byte blue, byte alpha)
        {
            Color4ub(red, green, blue, alpha);
        }
        /// <summary> Enable and disable writing of color buffer        components. </summary>
        /// <param name="red">Specify whether red, green, blue, and alpha can or cannot be written into the color buffer. The initial values are all GL_TRUE, indicating that all color components can be written.</param>
        /// <param name="green">Specify whether red, green, blue, and alpha can or cannot be written into the color buffer. The initial values are all GL_TRUE, indicating that all color components can be written.</param>
        /// <param name="blue">Specify whether red, green, blue, and alpha can or cannot be written into the color buffer. The initial values are all GL_TRUE, indicating that all color components can be written.</param>
        /// <param name="alpha">Specify whether red, green, blue, and alpha can or cannot be written into the color buffer. The initial values are all GL_TRUE, indicating that all color components can be written.</param>
        public static unsafe void ColorMask(bool red, bool green, bool blue, bool alpha)
        {
            byte red_byte = (byte)(red ? 1 : 0);
            byte green_byte = (byte)(green ? 1 : 0);
            byte blue_byte = (byte)(blue ? 1 : 0);
            byte alpha_byte = (byte)(alpha ? 1 : 0);
            ColorMask(red_byte, green_byte, blue_byte, alpha_byte);
        }
        /// <summary> Define an array of colors. </summary>
        /// <param name="size">Specifies the number of components per color. Must be 4. The initial value is 4.</param>
        /// <param name="type">Specifies the data type of each color component in the array. Symbolic constants GL_UNSIGNED_BYTE and GL_FIXED are accepted. However, the initial value is GL_FLOAT.</param>
        /// <param name="stride">Specifies the byte offset between consecutive colors. If stride is 0, the colors are understood to be tightly packed in the array. The initial value is 0.</param>
        /// <param name="pointer">Specifies a pointer to the first component of the first color element in the array.</param>
        public static unsafe void ColorPointer(int size, ColorPointerType type, int stride, IntPtr pointer)
        {
            void* pointer_vptr = (void*)pointer;
            ColorPointer(size, type, stride, pointer_vptr);
        }
        /// <summary> Define an array of colors. </summary>
        /// <param name="size">Specifies the number of components per color. Must be 4. The initial value is 4.</param>
        /// <param name="type">Specifies the data type of each color component in the array. Symbolic constants GL_UNSIGNED_BYTE and GL_FIXED are accepted. However, the initial value is GL_FLOAT.</param>
        /// <param name="stride">Specifies the byte offset between consecutive colors. If stride is 0, the colors are understood to be tightly packed in the array. The initial value is 0.</param>
        /// <param name="pointer">Specifies a pointer to the first component of the first color element in the array.</param>
        public static unsafe void ColorPointer<T1>(int size, ColorPointerType type, int stride, ReadOnlySpan<T1> pointer)
            where T1 : unmanaged
        {
            fixed (void* pointer_ptr = pointer)
            {
                ColorPointer(size, type, stride, pointer_ptr);
            }
        }
        /// <summary> Define an array of colors. </summary>
        /// <param name="size">Specifies the number of components per color. Must be 4. The initial value is 4.</param>
        /// <param name="type">Specifies the data type of each color component in the array. Symbolic constants GL_UNSIGNED_BYTE and GL_FIXED are accepted. However, the initial value is GL_FLOAT.</param>
        /// <param name="stride">Specifies the byte offset between consecutive colors. If stride is 0, the colors are understood to be tightly packed in the array. The initial value is 0.</param>
        /// <param name="pointer">Specifies a pointer to the first component of the first color element in the array.</param>
        public static unsafe void ColorPointer<T1>(int size, ColorPointerType type, int stride, T1[] pointer)
            where T1 : unmanaged
        {
            fixed (void* pointer_ptr = pointer)
            {
                ColorPointer(size, type, stride, pointer_ptr);
            }
        }
        /// <summary> Define an array of colors. </summary>
        /// <param name="size">Specifies the number of components per color. Must be 4. The initial value is 4.</param>
        /// <param name="type">Specifies the data type of each color component in the array. Symbolic constants GL_UNSIGNED_BYTE and GL_FIXED are accepted. However, the initial value is GL_FLOAT.</param>
        /// <param name="stride">Specifies the byte offset between consecutive colors. If stride is 0, the colors are understood to be tightly packed in the array. The initial value is 0.</param>
        /// <param name="pointer">Specifies a pointer to the first component of the first color element in the array.</param>
        public static unsafe void ColorPointer<T1>(int size, ColorPointerType type, int stride, in T1 pointer)
            where T1 : unmanaged
        {
            fixed (void* pointer_ptr = &pointer)
            {
                ColorPointer(size, type, stride, pointer_ptr);
            }
        }
        /// <summary> Specify a two-dimensional compressed texture image. </summary>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_2D.</param>
        /// <param name="level">Specifies the level-of-detail number. For paletted formats, where all mipmap levels are loaded at once, this parameter is overloaded to represent the negative of the greatest mipmap level included in data. </param>
        /// <param name="internalformat">Specifies the color components in the texture. The following symbolic constants are accepted: GL_PALETTE4_RGB8_OES, GL_PALETTE4_RGBA8_OES, GL_PALETTE4_R5_G6_B5_OES, GL_PALETTE4_RGBA4_OES, GL_PALETTE4_RGB5_A1_OES, GL_PALETTE8_RGB8_OES, GL_PALETTE8_RGBA8_OES, GL_PALETTE8_R5_G6_B5_OES, GL_PALETTE8_RGBA4_OES, and GL_PALETTE8_RGB5_A1_OES.</param>
        /// <param name="width">Specifies the width of the texture image. Must be 2n for some integer n. All implementations support texture images that are at least 64 texels wide.</param>
        /// <param name="height">Specifies the height of the texture image. Must be 2m for some integer m. All implementations support texture images that are at least 64 texels high.</param>
        /// <param name="border">Specifies the width of the border. Must be 0.</param>
        /// <param name="imageSize">Specifies the size of the compressed image data in bytes.</param>
        /// <param name="data">Specifies a pointer to the compressed image data in memory.</param>
        public static unsafe void CompressedTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, IntPtr data)
        {
            void* data_vptr = (void*)data;
            CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data_vptr);
        }
        /// <summary> Specify a two-dimensional compressed texture image. </summary>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_2D.</param>
        /// <param name="level">Specifies the level-of-detail number. For paletted formats, where all mipmap levels are loaded at once, this parameter is overloaded to represent the negative of the greatest mipmap level included in data. </param>
        /// <param name="internalformat">Specifies the color components in the texture. The following symbolic constants are accepted: GL_PALETTE4_RGB8_OES, GL_PALETTE4_RGBA8_OES, GL_PALETTE4_R5_G6_B5_OES, GL_PALETTE4_RGBA4_OES, GL_PALETTE4_RGB5_A1_OES, GL_PALETTE8_RGB8_OES, GL_PALETTE8_RGBA8_OES, GL_PALETTE8_R5_G6_B5_OES, GL_PALETTE8_RGBA4_OES, and GL_PALETTE8_RGB5_A1_OES.</param>
        /// <param name="width">Specifies the width of the texture image. Must be 2n for some integer n. All implementations support texture images that are at least 64 texels wide.</param>
        /// <param name="height">Specifies the height of the texture image. Must be 2m for some integer m. All implementations support texture images that are at least 64 texels high.</param>
        /// <param name="border">Specifies the width of the border. Must be 0.</param>
        /// <param name="data">Specifies a pointer to the compressed image data in memory.</param>
        public static unsafe void CompressedTexImage2D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, ReadOnlySpan<T1> data)
            where T1 : unmanaged
        {
            int imageSize = (int)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data_ptr);
            }
        }
        /// <summary> Specify a two-dimensional compressed texture image. </summary>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_2D.</param>
        /// <param name="level">Specifies the level-of-detail number. For paletted formats, where all mipmap levels are loaded at once, this parameter is overloaded to represent the negative of the greatest mipmap level included in data. </param>
        /// <param name="internalformat">Specifies the color components in the texture. The following symbolic constants are accepted: GL_PALETTE4_RGB8_OES, GL_PALETTE4_RGBA8_OES, GL_PALETTE4_R5_G6_B5_OES, GL_PALETTE4_RGBA4_OES, GL_PALETTE4_RGB5_A1_OES, GL_PALETTE8_RGB8_OES, GL_PALETTE8_RGBA8_OES, GL_PALETTE8_R5_G6_B5_OES, GL_PALETTE8_RGBA4_OES, and GL_PALETTE8_RGB5_A1_OES.</param>
        /// <param name="width">Specifies the width of the texture image. Must be 2n for some integer n. All implementations support texture images that are at least 64 texels wide.</param>
        /// <param name="height">Specifies the height of the texture image. Must be 2m for some integer m. All implementations support texture images that are at least 64 texels high.</param>
        /// <param name="border">Specifies the width of the border. Must be 0.</param>
        /// <param name="data">Specifies a pointer to the compressed image data in memory.</param>
        public static unsafe void CompressedTexImage2D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, T1[] data)
            where T1 : unmanaged
        {
            int imageSize = (int)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data_ptr);
            }
        }
        /// <summary> Specify a two-dimensional compressed texture image. </summary>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_2D.</param>
        /// <param name="level">Specifies the level-of-detail number. For paletted formats, where all mipmap levels are loaded at once, this parameter is overloaded to represent the negative of the greatest mipmap level included in data. </param>
        /// <param name="internalformat">Specifies the color components in the texture. The following symbolic constants are accepted: GL_PALETTE4_RGB8_OES, GL_PALETTE4_RGBA8_OES, GL_PALETTE4_R5_G6_B5_OES, GL_PALETTE4_RGBA4_OES, GL_PALETTE4_RGB5_A1_OES, GL_PALETTE8_RGB8_OES, GL_PALETTE8_RGBA8_OES, GL_PALETTE8_R5_G6_B5_OES, GL_PALETTE8_RGBA4_OES, and GL_PALETTE8_RGB5_A1_OES.</param>
        /// <param name="width">Specifies the width of the texture image. Must be 2n for some integer n. All implementations support texture images that are at least 64 texels wide.</param>
        /// <param name="height">Specifies the height of the texture image. Must be 2m for some integer m. All implementations support texture images that are at least 64 texels high.</param>
        /// <param name="border">Specifies the width of the border. Must be 0.</param>
        /// <param name="imageSize">Specifies the size of the compressed image data in bytes.</param>
        /// <param name="data">Specifies a pointer to the compressed image data in memory.</param>
        public static unsafe void CompressedTexImage2D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, in T1 data)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = &data)
            {
                CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data_ptr);
            }
        }
        /// <summary> Specify a two-dimensional compressed texture subimage. </summary>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_2D.</param>
        /// <param name="level">Specifies the level-of-detail number.</param>
        /// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="yoffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="format">Specifies the format of the pixel data. Currently, there is no supported format.</param>
        /// <param name="imageSize">Specifies the size of the compressed pixel data in bytes.</param>
        /// <param name="data">Specifies a pointer to the compressed image data in memory.</param>
        public static unsafe void CompressedTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, IntPtr data)
        {
            void* data_vptr = (void*)data;
            CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data_vptr);
        }
        /// <summary> Specify a two-dimensional compressed texture subimage. </summary>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_2D.</param>
        /// <param name="level">Specifies the level-of-detail number.</param>
        /// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="yoffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="format">Specifies the format of the pixel data. Currently, there is no supported format.</param>
        /// <param name="data">Specifies a pointer to the compressed image data in memory.</param>
        public static unsafe void CompressedTexSubImage2D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, ReadOnlySpan<T1> data)
            where T1 : unmanaged
        {
            int imageSize = (int)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data_ptr);
            }
        }
        /// <summary> Specify a two-dimensional compressed texture subimage. </summary>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_2D.</param>
        /// <param name="level">Specifies the level-of-detail number.</param>
        /// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="yoffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="format">Specifies the format of the pixel data. Currently, there is no supported format.</param>
        /// <param name="data">Specifies a pointer to the compressed image data in memory.</param>
        public static unsafe void CompressedTexSubImage2D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, T1[] data)
            where T1 : unmanaged
        {
            int imageSize = (int)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data_ptr);
            }
        }
        /// <summary> Specify a two-dimensional compressed texture subimage. </summary>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_2D.</param>
        /// <param name="level">Specifies the level-of-detail number.</param>
        /// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="yoffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="format">Specifies the format of the pixel data. Currently, there is no supported format.</param>
        /// <param name="imageSize">Specifies the size of the compressed pixel data in bytes.</param>
        /// <param name="data">Specifies a pointer to the compressed image data in memory.</param>
        public static unsafe void CompressedTexSubImage2D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, in T1 data)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = &data)
            {
                CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data_ptr);
            }
        }
        /// <summary> Delete named buffer objects. </summary>
        /// <param name="buffers">Specifies an array of buffer object names to be deleted.</param>
        public static unsafe void DeleteBuffer(in BufferHandle buffers)
        {
            int n = 1;
            fixed(BufferHandle* buffers_handle = &buffers)
            {
                DeleteBuffers(n, buffers_handle);
            }
        }
        /// <summary> Delete named buffer objects. </summary>
        /// <param name="buffers">Specifies an array of buffer object names to be deleted.</param>
        public static unsafe void DeleteBuffers(ReadOnlySpan<BufferHandle> buffers)
        {
            int n = (int)(buffers.Length);
            fixed (BufferHandle* buffers_ptr = buffers)
            {
                DeleteBuffers(n, buffers_ptr);
            }
        }
        /// <summary> Delete named buffer objects. </summary>
        /// <param name="buffers">Specifies an array of buffer object names to be deleted.</param>
        public static unsafe void DeleteBuffers(BufferHandle[] buffers)
        {
            int n = (int)(buffers.Length);
            fixed (BufferHandle* buffers_ptr = buffers)
            {
                DeleteBuffers(n, buffers_ptr);
            }
        }
        /// <summary> Delete named buffer objects. </summary>
        /// <param name="n">Specifies the number of buffer objects to be deleted.</param>
        /// <param name="buffers">Specifies an array of buffer object names to be deleted.</param>
        public static unsafe void DeleteBuffers(int n, in BufferHandle buffers)
        {
            fixed (BufferHandle* buffers_ptr = &buffers)
            {
                DeleteBuffers(n, buffers_ptr);
            }
        }
        /// <summary> Delete named textures. </summary>
        /// <param name="textures">Specifies an array of textures to be deleted.</param>
        public static unsafe void DeleteTexture(in TextureHandle textures)
        {
            int n = 1;
            fixed(TextureHandle* textures_handle = &textures)
            {
                DeleteTextures(n, textures_handle);
            }
        }
        /// <summary> Delete named textures. </summary>
        /// <param name="textures">Specifies an array of textures to be deleted.</param>
        public static unsafe void DeleteTextures(ReadOnlySpan<TextureHandle> textures)
        {
            int n = (int)(textures.Length);
            fixed (TextureHandle* textures_ptr = textures)
            {
                DeleteTextures(n, textures_ptr);
            }
        }
        /// <summary> Delete named textures. </summary>
        /// <param name="textures">Specifies an array of textures to be deleted.</param>
        public static unsafe void DeleteTextures(TextureHandle[] textures)
        {
            int n = (int)(textures.Length);
            fixed (TextureHandle* textures_ptr = textures)
            {
                DeleteTextures(n, textures_ptr);
            }
        }
        /// <summary> Delete named textures. </summary>
        /// <param name="n">Specifies the number of textures to be deleted.</param>
        /// <param name="textures">Specifies an array of textures to be deleted.</param>
        public static unsafe void DeleteTextures(int n, in TextureHandle textures)
        {
            fixed (TextureHandle* textures_ptr = &textures)
            {
                DeleteTextures(n, textures_ptr);
            }
        }
        /// <summary> Enable or disable writing into the depth buffer. </summary>
        /// <param name="flag">Specifies whether the depth buffer is enabled for writing. If flag is GL_FALSE, depth buffer writing is disabled, otherwise it is enabled. The initial value is GL_TRUE.</param>
        public static unsafe void DepthMask(bool flag)
        {
            byte flag_byte = (byte)(flag ? 1 : 0);
            DepthMask(flag_byte);
        }
        /// <summary> Render primitives from array data. </summary>
        /// <param name="mode">Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, and GL_TRIANGLES are accepted.</param>
        /// <param name="count">Specifies the number of elements to be rendered.</param>
        /// <param name="type">Specifies the type of the values in indices. Must be either GL_UNSIGNED_BYTE or GL_UNSIGNED_SHORT.</param>
        public static unsafe void DrawElements(PrimitiveType mode, int count, DrawElementsType type, nint offset)
        {
            void* indices = (void*)offset;
            DrawElements(mode, count, type, indices);
        }
        public static unsafe void Fogx(FogPName pname, ReadOnlySpan<int> param)
        {
            fixed (int* param_ptr = param)
            {
                Fogxv(pname, param_ptr);
            }
        }
        public static unsafe void Fogx(FogPName pname, int[] param)
        {
            fixed (int* param_ptr = param)
            {
                Fogxv(pname, param_ptr);
            }
        }
        public static unsafe void Fogx(FogPName pname, in int param)
        {
            fixed (int* param_ptr = &param)
            {
                Fogxv(pname, param_ptr);
            }
        }
        /// <summary> Return the value or values of a selected parameter. </summary>
        /// <param name="pname">Specifies the parameter value to be returned. The symbolic constants in the list below are accepted.</param>
        public static unsafe void GetBoolean(GetPName pname, Span<byte> data)
        {
            fixed (byte* data_ptr = data)
            {
                GetBooleanv(pname, data_ptr);
            }
        }
        /// <summary> Return the value or values of a selected parameter. </summary>
        /// <param name="pname">Specifies the parameter value to be returned. The symbolic constants in the list below are accepted.</param>
        public static unsafe void GetBoolean(GetPName pname, byte[] data)
        {
            fixed (byte* data_ptr = data)
            {
                GetBooleanv(pname, data_ptr);
            }
        }
        /// <summary> Return the value or values of a selected parameter. </summary>
        /// <param name="pname">Specifies the parameter value to be returned. The symbolic constants in the list below are accepted.</param>
        public static unsafe void GetBoolean(GetPName pname, ref byte data)
        {
            fixed (byte* data_ptr = &data)
            {
                GetBooleanv(pname, data_ptr);
            }
        }
        /// <summary> Return parameters of a buffer object. </summary>
        /// <param name="target"> Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER or GL_ELEMENT_ARRAY_BUFFER. </param>
        /// <param name="pname"> Specifies the symbolic name of a buffer object parameter. Accepted values are GL_BUFFER_SIZE or GL_BUFFER_USAGE. </param>
        public static unsafe void GetBufferParameteri(BufferTargetARB target, BufferPNameARB pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetBufferParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Return parameters of a buffer object. </summary>
        /// <param name="target"> Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER or GL_ELEMENT_ARRAY_BUFFER. </param>
        /// <param name="pname"> Specifies the symbolic name of a buffer object parameter. Accepted values are GL_BUFFER_SIZE or GL_BUFFER_USAGE. </param>
        public static unsafe void GetBufferParameteri(BufferTargetARB target, BufferPNameARB pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetBufferParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Return parameters of a buffer object. </summary>
        /// <param name="target"> Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER or GL_ELEMENT_ARRAY_BUFFER. </param>
        /// <param name="pname"> Specifies the symbolic name of a buffer object parameter. Accepted values are GL_BUFFER_SIZE or GL_BUFFER_USAGE. </param>
        public static unsafe void GetBufferParameteri(BufferTargetARB target, BufferPNameARB pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetBufferParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Return the coefficients of the specified clipping    plane. </summary>
        /// <param name="plane">Specifies a clipping plane. The number of clipping planes depends on the implementation, but at least six clipping planes are supported. Symbolic names of the form GL_CLIP_PLANE i, where i is an integer between 0 and GL_MAX_CLIP_PLANES -1 , are accepted.</param>
        /// <param name="equation">Returns four fixed-point or floating-point values that are the coefficients of the plane equation of plane in eye coordinates in the order p1, p2, p3, and p4. The initial value is (0, 0, 0, 0).</param>
        public static unsafe void GetClipPlanex(ClipPlaneName plane, Span<int> equation)
        {
            fixed (int* equation_ptr = equation)
            {
                GetClipPlanex(plane, equation_ptr);
            }
        }
        /// <summary> Return the coefficients of the specified clipping    plane. </summary>
        /// <param name="plane">Specifies a clipping plane. The number of clipping planes depends on the implementation, but at least six clipping planes are supported. Symbolic names of the form GL_CLIP_PLANE i, where i is an integer between 0 and GL_MAX_CLIP_PLANES -1 , are accepted.</param>
        /// <param name="equation">Returns four fixed-point or floating-point values that are the coefficients of the plane equation of plane in eye coordinates in the order p1, p2, p3, and p4. The initial value is (0, 0, 0, 0).</param>
        public static unsafe void GetClipPlanex(ClipPlaneName plane, int[] equation)
        {
            fixed (int* equation_ptr = equation)
            {
                GetClipPlanex(plane, equation_ptr);
            }
        }
        /// <summary> Return the coefficients of the specified clipping    plane. </summary>
        /// <param name="plane">Specifies a clipping plane. The number of clipping planes depends on the implementation, but at least six clipping planes are supported. Symbolic names of the form GL_CLIP_PLANE i, where i is an integer between 0 and GL_MAX_CLIP_PLANES -1 , are accepted.</param>
        /// <param name="equation">Returns four fixed-point or floating-point values that are the coefficients of the plane equation of plane in eye coordinates in the order p1, p2, p3, and p4. The initial value is (0, 0, 0, 0).</param>
        public static unsafe void GetClipPlanex(ClipPlaneName plane, ref int equation)
        {
            fixed (int* equation_ptr = &equation)
            {
                GetClipPlanex(plane, equation_ptr);
            }
        }
        /// <summary> Generate buffer object names. </summary>
        public static unsafe BufferHandle GenBuffer()
        {
            BufferHandle buffers;
            int n = 1;
            Unsafe.SkipInit(out buffers);
            // FIXME: This could be a problem for the overloads that take an out parameter
            // as this parameter could *potentially* move while inside of this function
            // which would mean that the new value never gets written to the out parameter.
            // Making for a nasty bug.
            // The reason we don't use a fixed expression here is because of the "single out parameter to return value" overloading step
            // that will make it so this tries to fix a local variable which is not allowed in C# for some reason.
            // If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk
            // - 2021-05-18
            BufferHandle* buffers_handle = (BufferHandle*)Unsafe.AsPointer(ref buffers);
            GenBuffers(n, buffers_handle);
            return buffers;
        }
        /// <summary> Generate buffer object names. </summary>
        /// <param name="buffers">Specifies an array in which the generated buffer object names are stored.</param>
        public static unsafe void GenBuffer(out BufferHandle buffers)
        {
            int n = 1;
            Unsafe.SkipInit(out buffers);
            // FIXME: This could be a problem for the overloads that take an out parameter
            // as this parameter could *potentially* move while inside of this function
            // which would mean that the new value never gets written to the out parameter.
            // Making for a nasty bug.
            // The reason we don't use a fixed expression here is because of the "single out parameter to return value" overloading step
            // that will make it so this tries to fix a local variable which is not allowed in C# for some reason.
            // If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk
            // - 2021-05-18
            BufferHandle* buffers_handle = (BufferHandle*)Unsafe.AsPointer(ref buffers);
            GenBuffers(n, buffers_handle);
        }
        /// <summary> Generate buffer object names. </summary>
        /// <param name="buffers">Specifies an array in which the generated buffer object names are stored.</param>
        public static unsafe void GenBuffers(Span<BufferHandle> buffers)
        {
            int n = (int)(buffers.Length);
            fixed (BufferHandle* buffers_ptr = buffers)
            {
                GenBuffers(n, buffers_ptr);
            }
        }
        /// <summary> Generate buffer object names. </summary>
        /// <param name="buffers">Specifies an array in which the generated buffer object names are stored.</param>
        public static unsafe void GenBuffers(BufferHandle[] buffers)
        {
            int n = (int)(buffers.Length);
            fixed (BufferHandle* buffers_ptr = buffers)
            {
                GenBuffers(n, buffers_ptr);
            }
        }
        /// <summary> Generate buffer object names. </summary>
        /// <param name="n">Specifies the number of buffer object names to be generated.</param>
        /// <param name="buffers">Specifies an array in which the generated buffer object names are stored.</param>
        public static unsafe void GenBuffers(int n, ref BufferHandle buffers)
        {
            fixed (BufferHandle* buffers_ptr = &buffers)
            {
                GenBuffers(n, buffers_ptr);
            }
        }
        /// <summary> Generate texture names. </summary>
        public static unsafe TextureHandle GenTexture()
        {
            TextureHandle textures;
            int n = 1;
            Unsafe.SkipInit(out textures);
            // FIXME: This could be a problem for the overloads that take an out parameter
            // as this parameter could *potentially* move while inside of this function
            // which would mean that the new value never gets written to the out parameter.
            // Making for a nasty bug.
            // The reason we don't use a fixed expression here is because of the "single out parameter to return value" overloading step
            // that will make it so this tries to fix a local variable which is not allowed in C# for some reason.
            // If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk
            // - 2021-05-18
            TextureHandle* textures_handle = (TextureHandle*)Unsafe.AsPointer(ref textures);
            GenTextures(n, textures_handle);
            return textures;
        }
        /// <summary> Generate texture names. </summary>
        /// <param name="textures">Specifies an array in which the generated texture names are stored.</param>
        public static unsafe void GenTexture(out TextureHandle textures)
        {
            int n = 1;
            Unsafe.SkipInit(out textures);
            // FIXME: This could be a problem for the overloads that take an out parameter
            // as this parameter could *potentially* move while inside of this function
            // which would mean that the new value never gets written to the out parameter.
            // Making for a nasty bug.
            // The reason we don't use a fixed expression here is because of the "single out parameter to return value" overloading step
            // that will make it so this tries to fix a local variable which is not allowed in C# for some reason.
            // If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk
            // - 2021-05-18
            TextureHandle* textures_handle = (TextureHandle*)Unsafe.AsPointer(ref textures);
            GenTextures(n, textures_handle);
        }
        /// <summary> Generate texture names. </summary>
        /// <param name="textures">Specifies an array in which the generated texture names are stored.</param>
        public static unsafe void GenTextures(Span<TextureHandle> textures)
        {
            int n = (int)(textures.Length);
            fixed (TextureHandle* textures_ptr = textures)
            {
                GenTextures(n, textures_ptr);
            }
        }
        /// <summary> Generate texture names. </summary>
        /// <param name="textures">Specifies an array in which the generated texture names are stored.</param>
        public static unsafe void GenTextures(TextureHandle[] textures)
        {
            int n = (int)(textures.Length);
            fixed (TextureHandle* textures_ptr = textures)
            {
                GenTextures(n, textures_ptr);
            }
        }
        /// <summary> Generate texture names. </summary>
        /// <param name="n">Specifies the number of texture names to be generated.</param>
        /// <param name="textures">Specifies an array in which the generated texture names are stored.</param>
        public static unsafe void GenTextures(int n, ref TextureHandle textures)
        {
            fixed (TextureHandle* textures_ptr = &textures)
            {
                GenTextures(n, textures_ptr);
            }
        }
        /// <summary> Return the value or values of a selected parameter. </summary>
        /// <param name="pname">Specifies the parameter value to be returned. The symbolic constants in the list below are accepted.</param>
        public static unsafe void GetFixedv(GetPName pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetFixedv(pname, parameters_ptr);
            }
        }
        /// <summary> Return the value or values of a selected parameter. </summary>
        /// <param name="pname">Specifies the parameter value to be returned. The symbolic constants in the list below are accepted.</param>
        public static unsafe void GetInteger(GetPName pname, Span<int> data)
        {
            fixed (int* data_ptr = data)
            {
                GetIntegerv(pname, data_ptr);
            }
        }
        /// <summary> Return the value or values of a selected parameter. </summary>
        /// <param name="pname">Specifies the parameter value to be returned. The symbolic constants in the list below are accepted.</param>
        public static unsafe void GetInteger(GetPName pname, int[] data)
        {
            fixed (int* data_ptr = data)
            {
                GetIntegerv(pname, data_ptr);
            }
        }
        /// <summary> Return the value or values of a selected parameter. </summary>
        /// <param name="pname">Specifies the parameter value to be returned. The symbolic constants in the list below are accepted.</param>
        public static unsafe void GetInteger(GetPName pname, ref int data)
        {
            fixed (int* data_ptr = &data)
            {
                GetIntegerv(pname, data_ptr);
            }
        }
        /// <summary> Return light source parameter values. </summary>
        /// <param name="light"> Specifies a light source. The number of possible lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form GL_LIGHTi where 0<i< GL_MAX_LIGHTS </param>
        /// <param name="pname"> Specifies a light source parameter for light. Accepted symbolic names are GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_POSITION, GL_SPOT_DIRECTION, GL_SPOT_EXPONENT, GL_SPOT_CUTOFF, GL_CONSTANT_ATTENUATION, GL_LINEAR_ATTENUATION, and GL_QUADRATIC_ATTENUATION. </param>
        public static unsafe void GetLightx(LightName light, LightParameter pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetLightxv(light, pname, parameters_ptr);
            }
        }
        /// <summary> Return light source parameter values. </summary>
        /// <param name="light"> Specifies a light source. The number of possible lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form GL_LIGHTi where 0<i< GL_MAX_LIGHTS </param>
        /// <param name="pname"> Specifies a light source parameter for light. Accepted symbolic names are GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_POSITION, GL_SPOT_DIRECTION, GL_SPOT_EXPONENT, GL_SPOT_CUTOFF, GL_CONSTANT_ATTENUATION, GL_LINEAR_ATTENUATION, and GL_QUADRATIC_ATTENUATION. </param>
        public static unsafe void GetLightx(LightName light, LightParameter pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetLightxv(light, pname, parameters_ptr);
            }
        }
        /// <summary> Return light source parameter values. </summary>
        /// <param name="light"> Specifies a light source. The number of possible lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form GL_LIGHTi where 0<i< GL_MAX_LIGHTS </param>
        /// <param name="pname"> Specifies a light source parameter for light. Accepted symbolic names are GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_POSITION, GL_SPOT_DIRECTION, GL_SPOT_EXPONENT, GL_SPOT_CUTOFF, GL_CONSTANT_ATTENUATION, GL_LINEAR_ATTENUATION, and GL_QUADRATIC_ATTENUATION. </param>
        public static unsafe void GetLightx(LightName light, LightParameter pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetLightxv(light, pname, parameters_ptr);
            }
        }
        /// <summary> Return material parameters values. </summary>
        /// <param name="face"> Specifies which of the two materials is being queried. GL_FRONT or GL_BACK are accepted, representing the front and back materials, respectively. </param>
        /// <param name="pname"> Specifies the material parameter to return. Accepted symbolic names are GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_EMISSION, and GL_SHININESS. </param>
        public static unsafe void GetMaterialx(MaterialFace face, MaterialParameter pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetMaterialxv(face, pname, parameters_ptr);
            }
        }
        /// <summary> Return material parameters values. </summary>
        /// <param name="face"> Specifies which of the two materials is being queried. GL_FRONT or GL_BACK are accepted, representing the front and back materials, respectively. </param>
        /// <param name="pname"> Specifies the material parameter to return. Accepted symbolic names are GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_EMISSION, and GL_SHININESS. </param>
        public static unsafe void GetMaterialx(MaterialFace face, MaterialParameter pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetMaterialxv(face, pname, parameters_ptr);
            }
        }
        /// <summary> Return material parameters values. </summary>
        /// <param name="face"> Specifies which of the two materials is being queried. GL_FRONT or GL_BACK are accepted, representing the front and back materials, respectively. </param>
        /// <param name="pname"> Specifies the material parameter to return. Accepted symbolic names are GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_EMISSION, and GL_SHININESS. </param>
        public static unsafe void GetMaterialx(MaterialFace face, MaterialParameter pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetMaterialxv(face, pname, parameters_ptr);
            }
        }
        /// <summary> Return the address of the specified pointer. </summary>
        /// <param name="pname"> Specifies the array or buffer pointer to be returned. Accepted symbolic names are GL_COLOR_ARRAY_POINTER, GL_MATRIX_INDEX_ARRAY_POINTER_OES, GL_NORMAL_ARRAY_POINTER, GL_POINT_SIZE_ARRAY_POINTER_OES, GL_TEXTURE_COORD_ARRAY_POINTER, and GL_VERTEX_ARRAY_POINTER., and GL_WEIGHT_ARRAY_POINTER_OES. </param>
        public static unsafe void GetPointer(GetPointervPName pname, void** parameters)
        {
            GetPointerv(pname, parameters);
        }
        /// <summary> Return a string describing the current GL        connection. </summary>
        /// <param name="name">Specifies a symbolic constant, one of GL_VENDOR, GL_RENDERER, GL_VERSION, or GL_EXTENSIONS.</param>
        public static unsafe string? GetString(StringName name)
        {
            byte* returnValue;
            string? returnValue_str;
            returnValue = GetString_(name);
            returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
            return returnValue_str;
        }
        /// <summary> Return texture environment parameters. </summary>
        /// <param name="target"> Specifies a texture environment. May be GL_TEXTURE_ENV or GL_POINT_SPRITE_OES. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture environment parameter. Accepted values are GL_TEXTURE_ENV_MODE, GL_TEXTURE_ENV_COLOR, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE_OES. </param>
        public static unsafe void GetTexEnvi(TextureEnvTarget target, TextureEnvParameter pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetTexEnviv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Return texture environment parameters. </summary>
        /// <param name="target"> Specifies a texture environment. May be GL_TEXTURE_ENV or GL_POINT_SPRITE_OES. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture environment parameter. Accepted values are GL_TEXTURE_ENV_MODE, GL_TEXTURE_ENV_COLOR, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE_OES. </param>
        public static unsafe void GetTexEnvi(TextureEnvTarget target, TextureEnvParameter pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetTexEnviv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Return texture environment parameters. </summary>
        /// <param name="target"> Specifies a texture environment. May be GL_TEXTURE_ENV or GL_POINT_SPRITE_OES. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture environment parameter. Accepted values are GL_TEXTURE_ENV_MODE, GL_TEXTURE_ENV_COLOR, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE_OES. </param>
        public static unsafe void GetTexEnvi(TextureEnvTarget target, TextureEnvParameter pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetTexEnviv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Return texture environment parameters. </summary>
        /// <param name="target"> Specifies a texture environment. May be GL_TEXTURE_ENV or GL_POINT_SPRITE_OES. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture environment parameter. Accepted values are GL_TEXTURE_ENV_MODE, GL_TEXTURE_ENV_COLOR, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE_OES. </param>
        public static unsafe void GetTexEnvx(TextureEnvTarget target, TextureEnvParameter pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetTexEnvxv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Return texture environment parameters. </summary>
        /// <param name="target"> Specifies a texture environment. May be GL_TEXTURE_ENV or GL_POINT_SPRITE_OES. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture environment parameter. Accepted values are GL_TEXTURE_ENV_MODE, GL_TEXTURE_ENV_COLOR, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE_OES. </param>
        public static unsafe void GetTexEnvx(TextureEnvTarget target, TextureEnvParameter pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetTexEnvxv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Return texture environment parameters. </summary>
        /// <param name="target"> Specifies a texture environment. May be GL_TEXTURE_ENV or GL_POINT_SPRITE_OES. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture environment parameter. Accepted values are GL_TEXTURE_ENV_MODE, GL_TEXTURE_ENV_COLOR, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE_OES. </param>
        public static unsafe void GetTexEnvx(TextureEnvTarget target, TextureEnvParameter pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetTexEnvxv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Return texture parameter values. </summary>
        /// <param name="target">Specifies the target texture, which must be GL_TEXTURE_2D.</param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. Which can be one of the following: GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_GENERATE_MIPMAP. </param>
        public static unsafe void GetTexParameteri(TextureTarget target, GetTextureParameter pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetTexParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Return texture parameter values. </summary>
        /// <param name="target">Specifies the target texture, which must be GL_TEXTURE_2D.</param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. Which can be one of the following: GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_GENERATE_MIPMAP. </param>
        public static unsafe void GetTexParameteri(TextureTarget target, GetTextureParameter pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetTexParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Return texture parameter values. </summary>
        /// <param name="target">Specifies the target texture, which must be GL_TEXTURE_2D.</param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. Which can be one of the following: GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_GENERATE_MIPMAP. </param>
        public static unsafe void GetTexParameteri(TextureTarget target, GetTextureParameter pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetTexParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Return texture parameter values. </summary>
        /// <param name="target">Specifies the target texture, which must be GL_TEXTURE_2D.</param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. Which can be one of the following: GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_GENERATE_MIPMAP. </param>
        public static unsafe void GetTexParameterx(TextureTarget target, GetTextureParameter pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetTexParameterxv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Return texture parameter values. </summary>
        /// <param name="target">Specifies the target texture, which must be GL_TEXTURE_2D.</param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. Which can be one of the following: GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_GENERATE_MIPMAP. </param>
        public static unsafe void GetTexParameterx(TextureTarget target, GetTextureParameter pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetTexParameterxv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Return texture parameter values. </summary>
        /// <param name="target">Specifies the target texture, which must be GL_TEXTURE_2D.</param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. Which can be one of the following: GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_GENERATE_MIPMAP. </param>
        public static unsafe void GetTexParameterx(TextureTarget target, GetTextureParameter pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetTexParameterxv(target, pname, parameters_ptr);
            }
        }
        public static unsafe void LightModelx(LightModelParameter pname, ReadOnlySpan<int> param)
        {
            fixed (int* param_ptr = param)
            {
                LightModelxv(pname, param_ptr);
            }
        }
        public static unsafe void LightModelx(LightModelParameter pname, int[] param)
        {
            fixed (int* param_ptr = param)
            {
                LightModelxv(pname, param_ptr);
            }
        }
        public static unsafe void LightModelx(LightModelParameter pname, in int param)
        {
            fixed (int* param_ptr = &param)
            {
                LightModelxv(pname, param_ptr);
            }
        }
        public static unsafe void Lightx(LightName light, LightParameter pname, ReadOnlySpan<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                Lightxv(light, pname, parameters_ptr);
            }
        }
        public static unsafe void Lightx(LightName light, LightParameter pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                Lightxv(light, pname, parameters_ptr);
            }
        }
        public static unsafe void Lightx(LightName light, LightParameter pname, in int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                Lightxv(light, pname, parameters_ptr);
            }
        }
        /// <summary> Replace the current matrix with the specifiedmatrix. </summary>
        /// <param name="m">Specifies a pointer to 16 consecutive values, which are used as the elements of a 4x4 column-major matrix.</param>
        public static unsafe void LoadMatrixx(ReadOnlySpan<int> m)
        {
            fixed (int* m_ptr = m)
            {
                LoadMatrixx(m_ptr);
            }
        }
        /// <summary> Replace the current matrix with the specifiedmatrix. </summary>
        /// <param name="m">Specifies a pointer to 16 consecutive values, which are used as the elements of a 4x4 column-major matrix.</param>
        public static unsafe void LoadMatrixx(int[] m)
        {
            fixed (int* m_ptr = m)
            {
                LoadMatrixx(m_ptr);
            }
        }
        /// <summary> Replace the current matrix with the specifiedmatrix. </summary>
        /// <param name="m">Specifies a pointer to 16 consecutive values, which are used as the elements of a 4x4 column-major matrix.</param>
        public static unsafe void LoadMatrixx(in int m)
        {
            fixed (int* m_ptr = &m)
            {
                LoadMatrixx(m_ptr);
            }
        }
        public static unsafe void Materialx(MaterialFace face, MaterialParameter pname, ReadOnlySpan<int> param)
        {
            fixed (int* param_ptr = param)
            {
                Materialxv(face, pname, param_ptr);
            }
        }
        public static unsafe void Materialx(MaterialFace face, MaterialParameter pname, int[] param)
        {
            fixed (int* param_ptr = param)
            {
                Materialxv(face, pname, param_ptr);
            }
        }
        public static unsafe void Materialx(MaterialFace face, MaterialParameter pname, in int param)
        {
            fixed (int* param_ptr = &param)
            {
                Materialxv(face, pname, param_ptr);
            }
        }
        /// <summary> Multiply the current matrix with the specifiedmatrix. </summary>
        /// <param name="m">Points to 16 consecutive values that are used as the elements of a 4x4 column-major matrix.</param>
        public static unsafe void MultMatrixx(ReadOnlySpan<int> m)
        {
            fixed (int* m_ptr = m)
            {
                MultMatrixx(m_ptr);
            }
        }
        /// <summary> Multiply the current matrix with the specifiedmatrix. </summary>
        /// <param name="m">Points to 16 consecutive values that are used as the elements of a 4x4 column-major matrix.</param>
        public static unsafe void MultMatrixx(int[] m)
        {
            fixed (int* m_ptr = m)
            {
                MultMatrixx(m_ptr);
            }
        }
        /// <summary> Multiply the current matrix with the specifiedmatrix. </summary>
        /// <param name="m">Points to 16 consecutive values that are used as the elements of a 4x4 column-major matrix.</param>
        public static unsafe void MultMatrixx(in int m)
        {
            fixed (int* m_ptr = &m)
            {
                MultMatrixx(m_ptr);
            }
        }
        /// <summary> Define an array of normals. </summary>
        /// <param name="type">Specifies the data type of each coordinate in the array. Symbolic constants GL_BYTE, GL_SHORT, and GL_FIXED are accepted. However, the initial value is GL_FLOAT.</param>
        /// <param name="stride">Specifies the byte offset between consecutive normals. If stride is 0, the normals are understood to be tightly packed in the array. The initial value is 0.</param>
        /// <param name="pointer">Specifies a pointer to the first coordinate of the first normal in the array. The initial value is 0.</param>
        public static unsafe void NormalPointer(NormalPointerType type, int stride, IntPtr pointer)
        {
            void* pointer_vptr = (void*)pointer;
            NormalPointer(type, stride, pointer_vptr);
        }
        /// <summary> Define an array of normals. </summary>
        /// <param name="type">Specifies the data type of each coordinate in the array. Symbolic constants GL_BYTE, GL_SHORT, and GL_FIXED are accepted. However, the initial value is GL_FLOAT.</param>
        /// <param name="stride">Specifies the byte offset between consecutive normals. If stride is 0, the normals are understood to be tightly packed in the array. The initial value is 0.</param>
        /// <param name="pointer">Specifies a pointer to the first coordinate of the first normal in the array. The initial value is 0.</param>
        public static unsafe void NormalPointer<T1>(NormalPointerType type, int stride, ReadOnlySpan<T1> pointer)
            where T1 : unmanaged
        {
            fixed (void* pointer_ptr = pointer)
            {
                NormalPointer(type, stride, pointer_ptr);
            }
        }
        /// <summary> Define an array of normals. </summary>
        /// <param name="type">Specifies the data type of each coordinate in the array. Symbolic constants GL_BYTE, GL_SHORT, and GL_FIXED are accepted. However, the initial value is GL_FLOAT.</param>
        /// <param name="stride">Specifies the byte offset between consecutive normals. If stride is 0, the normals are understood to be tightly packed in the array. The initial value is 0.</param>
        /// <param name="pointer">Specifies a pointer to the first coordinate of the first normal in the array. The initial value is 0.</param>
        public static unsafe void NormalPointer<T1>(NormalPointerType type, int stride, T1[] pointer)
            where T1 : unmanaged
        {
            fixed (void* pointer_ptr = pointer)
            {
                NormalPointer(type, stride, pointer_ptr);
            }
        }
        /// <summary> Define an array of normals. </summary>
        /// <param name="type">Specifies the data type of each coordinate in the array. Symbolic constants GL_BYTE, GL_SHORT, and GL_FIXED are accepted. However, the initial value is GL_FLOAT.</param>
        /// <param name="stride">Specifies the byte offset between consecutive normals. If stride is 0, the normals are understood to be tightly packed in the array. The initial value is 0.</param>
        /// <param name="pointer">Specifies a pointer to the first coordinate of the first normal in the array. The initial value is 0.</param>
        public static unsafe void NormalPointer<T1>(NormalPointerType type, int stride, in T1 pointer)
            where T1 : unmanaged
        {
            fixed (void* pointer_ptr = &pointer)
            {
                NormalPointer(type, stride, pointer_ptr);
            }
        }
        public static unsafe void PointParameterx(PointParameterNameARB pname, ReadOnlySpan<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                PointParameterxv(pname, parameters_ptr);
            }
        }
        public static unsafe void PointParameterx(PointParameterNameARB pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                PointParameterxv(pname, parameters_ptr);
            }
        }
        public static unsafe void PointParameterx(PointParameterNameARB pname, in int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                PointParameterxv(pname, parameters_ptr);
            }
        }
        /// <summary> Read a block of pixels from the color buffer. </summary>
        /// <param name="x">Specify the window coordinates of the first pixel that is read from the color buffer. This location is the lower left corner of a rectangular block of pixels.</param>
        /// <param name="y">Specify the window coordinates of the first pixel that is read from the color buffer. This location is the lower left corner of a rectangular block of pixels.</param>
        /// <param name="width">Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.</param>
        /// <param name="height">Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.</param>
        /// <param name="format">Specifies the format of the pixel data. Must be either GL_RGBA or the value of GL_IMPLEMENTATION_COLOR_READ_FORMAT_OES.</param>
        /// <param name="type">Specifies the data type of the pixel data. Must be either GL_UNSIGNED_BYTE or the value of GL_IMPLEMENTATION_COLOR_READ_TYPE_OES.</param>
        /// <param name="pixels">Returns the pixel data.</param>
        public static unsafe void ReadPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, IntPtr pixels)
        {
            void* pixels_vptr = (void*)pixels;
            ReadPixels(x, y, width, height, format, type, pixels_vptr);
        }
        /// <summary> Read a block of pixels from the color buffer. </summary>
        /// <param name="x">Specify the window coordinates of the first pixel that is read from the color buffer. This location is the lower left corner of a rectangular block of pixels.</param>
        /// <param name="y">Specify the window coordinates of the first pixel that is read from the color buffer. This location is the lower left corner of a rectangular block of pixels.</param>
        /// <param name="width">Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.</param>
        /// <param name="height">Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.</param>
        /// <param name="format">Specifies the format of the pixel data. Must be either GL_RGBA or the value of GL_IMPLEMENTATION_COLOR_READ_FORMAT_OES.</param>
        /// <param name="type">Specifies the data type of the pixel data. Must be either GL_UNSIGNED_BYTE or the value of GL_IMPLEMENTATION_COLOR_READ_TYPE_OES.</param>
        /// <param name="pixels">Returns the pixel data.</param>
        public static unsafe void ReadPixels<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, Span<T1> pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels)
            {
                ReadPixels(x, y, width, height, format, type, pixels_ptr);
            }
        }
        /// <summary> Read a block of pixels from the color buffer. </summary>
        /// <param name="x">Specify the window coordinates of the first pixel that is read from the color buffer. This location is the lower left corner of a rectangular block of pixels.</param>
        /// <param name="y">Specify the window coordinates of the first pixel that is read from the color buffer. This location is the lower left corner of a rectangular block of pixels.</param>
        /// <param name="width">Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.</param>
        /// <param name="height">Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.</param>
        /// <param name="format">Specifies the format of the pixel data. Must be either GL_RGBA or the value of GL_IMPLEMENTATION_COLOR_READ_FORMAT_OES.</param>
        /// <param name="type">Specifies the data type of the pixel data. Must be either GL_UNSIGNED_BYTE or the value of GL_IMPLEMENTATION_COLOR_READ_TYPE_OES.</param>
        /// <param name="pixels">Returns the pixel data.</param>
        public static unsafe void ReadPixels<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, T1[] pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels)
            {
                ReadPixels(x, y, width, height, format, type, pixels_ptr);
            }
        }
        /// <summary> Read a block of pixels from the color buffer. </summary>
        /// <param name="x">Specify the window coordinates of the first pixel that is read from the color buffer. This location is the lower left corner of a rectangular block of pixels.</param>
        /// <param name="y">Specify the window coordinates of the first pixel that is read from the color buffer. This location is the lower left corner of a rectangular block of pixels.</param>
        /// <param name="width">Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.</param>
        /// <param name="height">Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.</param>
        /// <param name="format">Specifies the format of the pixel data. Must be either GL_RGBA or the value of GL_IMPLEMENTATION_COLOR_READ_FORMAT_OES.</param>
        /// <param name="type">Specifies the data type of the pixel data. Must be either GL_UNSIGNED_BYTE or the value of GL_IMPLEMENTATION_COLOR_READ_TYPE_OES.</param>
        /// <param name="pixels">Returns the pixel data.</param>
        public static unsafe void ReadPixels<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, ref T1 pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = &pixels)
            {
                ReadPixels(x, y, width, height, format, type, pixels_ptr);
            }
        }
        /// <summary> Specify mask to modify multisampled pixel fragments. </summary>
        /// <param name="value">Specifies the coverage of the modification mask. The value is clamped to the range [0, 1], where 0 represents no coverage and 1 full coverage. The initial value is 1.</param>
        /// <param name="invert">Specifies whether the modification mask implied by value is inverted or not. The initial value is GL_FALSE. </param>
        public static unsafe void SampleCoverage(float value, bool invert)
        {
            byte invert_byte = (byte)(invert ? 1 : 0);
            SampleCoverage(value, invert_byte);
        }
        /// <summary> Specify mask to modify multisampled pixel fragments. </summary>
        /// <param name="value">Specifies the coverage of the modification mask. The value is clamped to the range [0, 1], where 0 represents no coverage and 1 full coverage. The initial value is 1.</param>
        /// <param name="invert">Specifies whether the modification mask implied by value is inverted or not. The initial value is GL_FALSE. </param>
        public static unsafe void SampleCoveragex(int value, bool invert)
        {
            byte invert_byte = (byte)(invert ? 1 : 0);
            SampleCoveragex(value, invert_byte);
        }
        /// <summary> Define an array of texture coordinates. </summary>
        /// <param name="size">Specifies the number of coordinates per array element. Must be 2, 3 or 4. The initial value is 4.</param>
        /// <param name="type">Specifies the data type of each texture coordinate. Symbolic constants GL_BYTE, GL_SHORT, and GL_FIXED are accepted. However, the initial value is GL_FLOAT.</param>
        /// <param name="stride">Specifies the byte offset between consecutive array elements. If stride is 0, the array elements are understood to be tightly packed. The initial value is 0.</param>
        /// <param name="pointer">Specifies a pointer to the first coordinate of the first element in the array. The initial value is 0.</param>
        public static unsafe void TexCoordPointer(int size, TexCoordPointerType type, int stride, IntPtr pointer)
        {
            void* pointer_vptr = (void*)pointer;
            TexCoordPointer(size, type, stride, pointer_vptr);
        }
        /// <summary> Define an array of texture coordinates. </summary>
        /// <param name="size">Specifies the number of coordinates per array element. Must be 2, 3 or 4. The initial value is 4.</param>
        /// <param name="type">Specifies the data type of each texture coordinate. Symbolic constants GL_BYTE, GL_SHORT, and GL_FIXED are accepted. However, the initial value is GL_FLOAT.</param>
        /// <param name="stride">Specifies the byte offset between consecutive array elements. If stride is 0, the array elements are understood to be tightly packed. The initial value is 0.</param>
        /// <param name="pointer">Specifies a pointer to the first coordinate of the first element in the array. The initial value is 0.</param>
        public static unsafe void TexCoordPointer<T1>(int size, TexCoordPointerType type, int stride, ReadOnlySpan<T1> pointer)
            where T1 : unmanaged
        {
            fixed (void* pointer_ptr = pointer)
            {
                TexCoordPointer(size, type, stride, pointer_ptr);
            }
        }
        /// <summary> Define an array of texture coordinates. </summary>
        /// <param name="size">Specifies the number of coordinates per array element. Must be 2, 3 or 4. The initial value is 4.</param>
        /// <param name="type">Specifies the data type of each texture coordinate. Symbolic constants GL_BYTE, GL_SHORT, and GL_FIXED are accepted. However, the initial value is GL_FLOAT.</param>
        /// <param name="stride">Specifies the byte offset between consecutive array elements. If stride is 0, the array elements are understood to be tightly packed. The initial value is 0.</param>
        /// <param name="pointer">Specifies a pointer to the first coordinate of the first element in the array. The initial value is 0.</param>
        public static unsafe void TexCoordPointer<T1>(int size, TexCoordPointerType type, int stride, T1[] pointer)
            where T1 : unmanaged
        {
            fixed (void* pointer_ptr = pointer)
            {
                TexCoordPointer(size, type, stride, pointer_ptr);
            }
        }
        /// <summary> Define an array of texture coordinates. </summary>
        /// <param name="size">Specifies the number of coordinates per array element. Must be 2, 3 or 4. The initial value is 4.</param>
        /// <param name="type">Specifies the data type of each texture coordinate. Symbolic constants GL_BYTE, GL_SHORT, and GL_FIXED are accepted. However, the initial value is GL_FLOAT.</param>
        /// <param name="stride">Specifies the byte offset between consecutive array elements. If stride is 0, the array elements are understood to be tightly packed. The initial value is 0.</param>
        /// <param name="pointer">Specifies a pointer to the first coordinate of the first element in the array. The initial value is 0.</param>
        public static unsafe void TexCoordPointer<T1>(int size, TexCoordPointerType type, int stride, in T1 pointer)
            where T1 : unmanaged
        {
            fixed (void* pointer_ptr = &pointer)
            {
                TexCoordPointer(size, type, stride, pointer_ptr);
            }
        }
        public static unsafe void TexEnvi(TextureEnvTarget target, TextureEnvParameter pname, ReadOnlySpan<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                TexEnviv(target, pname, parameters_ptr);
            }
        }
        public static unsafe void TexEnvi(TextureEnvTarget target, TextureEnvParameter pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                TexEnviv(target, pname, parameters_ptr);
            }
        }
        public static unsafe void TexEnvi(TextureEnvTarget target, TextureEnvParameter pname, in int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                TexEnviv(target, pname, parameters_ptr);
            }
        }
        public static unsafe void TexEnvx(TextureEnvTarget target, TextureEnvParameter pname, ReadOnlySpan<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                TexEnvxv(target, pname, parameters_ptr);
            }
        }
        public static unsafe void TexEnvx(TextureEnvTarget target, TextureEnvParameter pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                TexEnvxv(target, pname, parameters_ptr);
            }
        }
        public static unsafe void TexEnvx(TextureEnvTarget target, TextureEnvParameter pname, in int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                TexEnvxv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Specify a two-dimensional texture image. </summary>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_2D.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. Must be greater or equal 0.</param>
        /// <param name="internalformat">Specifies the color components in the texture. Must be same as format. The following symbolic values are accepted: GL_ALPHA, GL_RGB, GL_RGBA, GL_LUMINANCE, or GL_LUMINANCE_ALPHA.</param>
        /// <param name="width">Specifies the width of the texture image. Must be 2n for some integer n. All implementations support texture images that are at least 64 texels wide.</param>
        /// <param name="height">Specifies the height of the texture image. Must be 2m for some integer m. All implementations support texture images that are at least 64 texels high.</param>
        /// <param name="border">Specifies the width of the border. Must be 0.</param>
        /// <param name="format">Specifies the format of the pixel data. Must be same as internalformat. The following symbolic values are accepted: GL_ALPHA, GL_RGB, GL_RGBA, GL_LUMINANCE, and GL_LUMINANCE_ALPHA.</param>
        /// <param name="type">Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_4_4_4_4, and GL_UNSIGNED_SHORT_5_5_5_1.</param>
        /// <param name="pixels">Specifies a pointer to the image data in memory.</param>
        public static unsafe void TexImage2D(TextureTarget target, int level, int internalformat, int width, int height, int border, PixelFormat format, PixelType type, IntPtr pixels)
        {
            void* pixels_vptr = (void*)pixels;
            TexImage2D(target, level, internalformat, width, height, border, format, type, pixels_vptr);
        }
        /// <summary> Specify a two-dimensional texture image. </summary>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_2D.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. Must be greater or equal 0.</param>
        /// <param name="internalformat">Specifies the color components in the texture. Must be same as format. The following symbolic values are accepted: GL_ALPHA, GL_RGB, GL_RGBA, GL_LUMINANCE, or GL_LUMINANCE_ALPHA.</param>
        /// <param name="width">Specifies the width of the texture image. Must be 2n for some integer n. All implementations support texture images that are at least 64 texels wide.</param>
        /// <param name="height">Specifies the height of the texture image. Must be 2m for some integer m. All implementations support texture images that are at least 64 texels high.</param>
        /// <param name="border">Specifies the width of the border. Must be 0.</param>
        /// <param name="format">Specifies the format of the pixel data. Must be same as internalformat. The following symbolic values are accepted: GL_ALPHA, GL_RGB, GL_RGBA, GL_LUMINANCE, and GL_LUMINANCE_ALPHA.</param>
        /// <param name="type">Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_4_4_4_4, and GL_UNSIGNED_SHORT_5_5_5_1.</param>
        /// <param name="pixels">Specifies a pointer to the image data in memory.</param>
        public static unsafe void TexImage2D<T1>(TextureTarget target, int level, int internalformat, int width, int height, int border, PixelFormat format, PixelType type, ReadOnlySpan<T1> pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels)
            {
                TexImage2D(target, level, internalformat, width, height, border, format, type, pixels_ptr);
            }
        }
        /// <summary> Specify a two-dimensional texture image. </summary>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_2D.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. Must be greater or equal 0.</param>
        /// <param name="internalformat">Specifies the color components in the texture. Must be same as format. The following symbolic values are accepted: GL_ALPHA, GL_RGB, GL_RGBA, GL_LUMINANCE, or GL_LUMINANCE_ALPHA.</param>
        /// <param name="width">Specifies the width of the texture image. Must be 2n for some integer n. All implementations support texture images that are at least 64 texels wide.</param>
        /// <param name="height">Specifies the height of the texture image. Must be 2m for some integer m. All implementations support texture images that are at least 64 texels high.</param>
        /// <param name="border">Specifies the width of the border. Must be 0.</param>
        /// <param name="format">Specifies the format of the pixel data. Must be same as internalformat. The following symbolic values are accepted: GL_ALPHA, GL_RGB, GL_RGBA, GL_LUMINANCE, and GL_LUMINANCE_ALPHA.</param>
        /// <param name="type">Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_4_4_4_4, and GL_UNSIGNED_SHORT_5_5_5_1.</param>
        /// <param name="pixels">Specifies a pointer to the image data in memory.</param>
        public static unsafe void TexImage2D<T1>(TextureTarget target, int level, int internalformat, int width, int height, int border, PixelFormat format, PixelType type, T1[] pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels)
            {
                TexImage2D(target, level, internalformat, width, height, border, format, type, pixels_ptr);
            }
        }
        /// <summary> Specify a two-dimensional texture image. </summary>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_2D.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. Must be greater or equal 0.</param>
        /// <param name="internalformat">Specifies the color components in the texture. Must be same as format. The following symbolic values are accepted: GL_ALPHA, GL_RGB, GL_RGBA, GL_LUMINANCE, or GL_LUMINANCE_ALPHA.</param>
        /// <param name="width">Specifies the width of the texture image. Must be 2n for some integer n. All implementations support texture images that are at least 64 texels wide.</param>
        /// <param name="height">Specifies the height of the texture image. Must be 2m for some integer m. All implementations support texture images that are at least 64 texels high.</param>
        /// <param name="border">Specifies the width of the border. Must be 0.</param>
        /// <param name="format">Specifies the format of the pixel data. Must be same as internalformat. The following symbolic values are accepted: GL_ALPHA, GL_RGB, GL_RGBA, GL_LUMINANCE, and GL_LUMINANCE_ALPHA.</param>
        /// <param name="type">Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_4_4_4_4, and GL_UNSIGNED_SHORT_5_5_5_1.</param>
        /// <param name="pixels">Specifies a pointer to the image data in memory.</param>
        public static unsafe void TexImage2D<T1>(TextureTarget target, int level, int internalformat, int width, int height, int border, PixelFormat format, PixelType type, in T1 pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = &pixels)
            {
                TexImage2D(target, level, internalformat, width, height, border, format, type, pixels_ptr);
            }
        }
        public static unsafe void TexParameteri(TextureTarget target, TextureParameterName pname, ReadOnlySpan<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                TexParameteriv(target, pname, parameters_ptr);
            }
        }
        public static unsafe void TexParameteri(TextureTarget target, TextureParameterName pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                TexParameteriv(target, pname, parameters_ptr);
            }
        }
        public static unsafe void TexParameteri(TextureTarget target, TextureParameterName pname, in int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                TexParameteriv(target, pname, parameters_ptr);
            }
        }
        public static unsafe void TexParameterx(TextureTarget target, GetTextureParameter pname, ReadOnlySpan<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                TexParameterxv(target, pname, parameters_ptr);
            }
        }
        public static unsafe void TexParameterx(TextureTarget target, GetTextureParameter pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                TexParameterxv(target, pname, parameters_ptr);
            }
        }
        public static unsafe void TexParameterx(TextureTarget target, GetTextureParameter pname, in int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                TexParameterxv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Specify a two-dimensional texture subimage. </summary>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_2D.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="yoffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="format">Specifies the of the pixel data. The following symbolic values are accepted: GL_ALPHA, GL_RGB, GL_RGBA, GL_LUMINANCE, and GL_LUMINANCE_ALPHA.</param>
        /// <param name="type">Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_4_4_4_4, and GL_UNSIGNED_SHORT_5_5_5_1.</param>
        /// <param name="pixels">Specifies a pointer to the image data in memory.</param>
        public static unsafe void TexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, IntPtr pixels)
        {
            void* pixels_vptr = (void*)pixels;
            TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels_vptr);
        }
        /// <summary> Specify a two-dimensional texture subimage. </summary>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_2D.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="yoffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="format">Specifies the of the pixel data. The following symbolic values are accepted: GL_ALPHA, GL_RGB, GL_RGBA, GL_LUMINANCE, and GL_LUMINANCE_ALPHA.</param>
        /// <param name="type">Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_4_4_4_4, and GL_UNSIGNED_SHORT_5_5_5_1.</param>
        /// <param name="pixels">Specifies a pointer to the image data in memory.</param>
        public static unsafe void TexSubImage2D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, ReadOnlySpan<T1> pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels)
            {
                TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels_ptr);
            }
        }
        /// <summary> Specify a two-dimensional texture subimage. </summary>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_2D.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="yoffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="format">Specifies the of the pixel data. The following symbolic values are accepted: GL_ALPHA, GL_RGB, GL_RGBA, GL_LUMINANCE, and GL_LUMINANCE_ALPHA.</param>
        /// <param name="type">Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_4_4_4_4, and GL_UNSIGNED_SHORT_5_5_5_1.</param>
        /// <param name="pixels">Specifies a pointer to the image data in memory.</param>
        public static unsafe void TexSubImage2D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, T1[] pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels)
            {
                TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels_ptr);
            }
        }
        /// <summary> Specify a two-dimensional texture subimage. </summary>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_2D.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="yoffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="format">Specifies the of the pixel data. The following symbolic values are accepted: GL_ALPHA, GL_RGB, GL_RGBA, GL_LUMINANCE, and GL_LUMINANCE_ALPHA.</param>
        /// <param name="type">Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_4_4_4_4, and GL_UNSIGNED_SHORT_5_5_5_1.</param>
        /// <param name="pixels">Specifies a pointer to the image data in memory.</param>
        public static unsafe void TexSubImage2D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, in T1 pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = &pixels)
            {
                TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels_ptr);
            }
        }
        /// <summary> Define an array of vertex coordinates. </summary>
        /// <param name="size">Specifies the number of coordinates per vertex. Must be 2, 3, or 4. The initial value is 4.</param>
        /// <param name="type">Specifies the data type of each vertex coordinate in the array. Symbolic constants GL_BYTE, GL_SHORT, and GL_FIXED, are accepted. However, the initial value is GL_FLOAT.</param>
        /// <param name="stride">Specifies the byte offset between consecutive vertices. If stride is 0, the vertices are understood to be tightly packed in the array. The initial value is 0.</param>
        /// <param name="pointer">Specifies a pointer to the first coordinate of the first vertex in the array. The initial value is 0.</param>
        public static unsafe void VertexPointer(int size, VertexPointerType type, int stride, IntPtr pointer)
        {
            void* pointer_vptr = (void*)pointer;
            VertexPointer(size, type, stride, pointer_vptr);
        }
        /// <summary> Define an array of vertex coordinates. </summary>
        /// <param name="size">Specifies the number of coordinates per vertex. Must be 2, 3, or 4. The initial value is 4.</param>
        /// <param name="type">Specifies the data type of each vertex coordinate in the array. Symbolic constants GL_BYTE, GL_SHORT, and GL_FIXED, are accepted. However, the initial value is GL_FLOAT.</param>
        /// <param name="stride">Specifies the byte offset between consecutive vertices. If stride is 0, the vertices are understood to be tightly packed in the array. The initial value is 0.</param>
        /// <param name="pointer">Specifies a pointer to the first coordinate of the first vertex in the array. The initial value is 0.</param>
        public static unsafe void VertexPointer<T1>(int size, VertexPointerType type, int stride, ReadOnlySpan<T1> pointer)
            where T1 : unmanaged
        {
            fixed (void* pointer_ptr = pointer)
            {
                VertexPointer(size, type, stride, pointer_ptr);
            }
        }
        /// <summary> Define an array of vertex coordinates. </summary>
        /// <param name="size">Specifies the number of coordinates per vertex. Must be 2, 3, or 4. The initial value is 4.</param>
        /// <param name="type">Specifies the data type of each vertex coordinate in the array. Symbolic constants GL_BYTE, GL_SHORT, and GL_FIXED, are accepted. However, the initial value is GL_FLOAT.</param>
        /// <param name="stride">Specifies the byte offset between consecutive vertices. If stride is 0, the vertices are understood to be tightly packed in the array. The initial value is 0.</param>
        /// <param name="pointer">Specifies a pointer to the first coordinate of the first vertex in the array. The initial value is 0.</param>
        public static unsafe void VertexPointer<T1>(int size, VertexPointerType type, int stride, T1[] pointer)
            where T1 : unmanaged
        {
            fixed (void* pointer_ptr = pointer)
            {
                VertexPointer(size, type, stride, pointer_ptr);
            }
        }
        /// <summary> Define an array of vertex coordinates. </summary>
        /// <param name="size">Specifies the number of coordinates per vertex. Must be 2, 3, or 4. The initial value is 4.</param>
        /// <param name="type">Specifies the data type of each vertex coordinate in the array. Symbolic constants GL_BYTE, GL_SHORT, and GL_FIXED, are accepted. However, the initial value is GL_FLOAT.</param>
        /// <param name="stride">Specifies the byte offset between consecutive vertices. If stride is 0, the vertices are understood to be tightly packed in the array. The initial value is 0.</param>
        /// <param name="pointer">Specifies a pointer to the first coordinate of the first vertex in the array. The initial value is 0.</param>
        public static unsafe void VertexPointer<T1>(int size, VertexPointerType type, int stride, in T1 pointer)
            where T1 : unmanaged
        {
            fixed (void* pointer_ptr = &pointer)
            {
                VertexPointer(size, type, stride, pointer_ptr);
            }
        }
        public static unsafe partial class APPLE
        {
            public static unsafe void GetInteger64vAPPLE(GetPName pname, ref long parameters)
            {
                fixed (long* parameters_ptr = &parameters)
                {
                    GetInteger64vAPPLE(pname, parameters_ptr);
                }
            }
            public static unsafe void GetSyncivAPPLE(GLSync sync, SyncParameterName pname, ref int length, Span<int> values)
            {
                fixed (int* length_ptr = &length)
                {
                    int count = (int)(values.Length);
                    fixed (int* values_ptr = values)
                    {
                        GetSyncivAPPLE(sync, pname, count, length_ptr, values_ptr);
                    }
                }
            }
            public static unsafe void GetSyncivAPPLE(GLSync sync, SyncParameterName pname, ref int length, int[] values)
            {
                fixed (int* length_ptr = &length)
                {
                    int count = (int)(values.Length);
                    fixed (int* values_ptr = values)
                    {
                        GetSyncivAPPLE(sync, pname, count, length_ptr, values_ptr);
                    }
                }
            }
            public static unsafe void GetSyncivAPPLE(GLSync sync, SyncParameterName pname, int count, ref int length, ref int values)
            {
                fixed (int* length_ptr = &length)
                fixed (int* values_ptr = &values)
                {
                    GetSyncivAPPLE(sync, pname, count, length_ptr, values_ptr);
                }
            }
        }
        public static unsafe partial class EXT
        {
            public static unsafe void InsertEventMarkerEXT(int length, string marker)
            {
                byte* marker_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(marker);
                InsertEventMarkerEXT(length, marker_ptr);
                Marshal.FreeCoTaskMem((IntPtr)marker_ptr);
            }
            public static unsafe void PushGroupMarkerEXT(int length, string marker)
            {
                byte* marker_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(marker);
                PushGroupMarkerEXT(length, marker_ptr);
                Marshal.FreeCoTaskMem((IntPtr)marker_ptr);
            }
            public static unsafe void DiscardFramebufferEXT(FramebufferTarget target, ReadOnlySpan<InvalidateFramebufferAttachment> attachments)
            {
                int numAttachments = (int)(attachments.Length);
                fixed (InvalidateFramebufferAttachment* attachments_ptr = attachments)
                {
                    DiscardFramebufferEXT(target, numAttachments, attachments_ptr);
                }
            }
            public static unsafe void DiscardFramebufferEXT(FramebufferTarget target, InvalidateFramebufferAttachment[] attachments)
            {
                int numAttachments = (int)(attachments.Length);
                fixed (InvalidateFramebufferAttachment* attachments_ptr = attachments)
                {
                    DiscardFramebufferEXT(target, numAttachments, attachments_ptr);
                }
            }
            public static unsafe void DiscardFramebufferEXT(FramebufferTarget target, int numAttachments, in InvalidateFramebufferAttachment attachments)
            {
                fixed (InvalidateFramebufferAttachment* attachments_ptr = &attachments)
                {
                    DiscardFramebufferEXT(target, numAttachments, attachments_ptr);
                }
            }
            public static unsafe void MultiDrawArraysEXT(PrimitiveType mode, ReadOnlySpan<int> first, ReadOnlySpan<int> count, int primcount)
            {
                fixed (int* first_ptr = first)
                {
                    fixed (int* count_ptr = count)
                    {
                        MultiDrawArraysEXT(mode, first_ptr, count_ptr, primcount);
                    }
                }
            }
            public static unsafe void MultiDrawArraysEXT(PrimitiveType mode, int[] first, int[] count, int primcount)
            {
                fixed (int* first_ptr = first)
                {
                    fixed (int* count_ptr = count)
                    {
                        MultiDrawArraysEXT(mode, first_ptr, count_ptr, primcount);
                    }
                }
            }
            public static unsafe void MultiDrawArraysEXT(PrimitiveType mode, in int first, in int count, int primcount)
            {
                fixed (int* first_ptr = &first)
                fixed (int* count_ptr = &count)
                {
                    MultiDrawArraysEXT(mode, first_ptr, count_ptr, primcount);
                }
            }
            public static unsafe void MultiDrawElementsEXT(PrimitiveType mode, ReadOnlySpan<int> count, DrawElementsType type, void** indices, int primcount)
            {
                fixed (int* count_ptr = count)
                {
                    MultiDrawElementsEXT(mode, count_ptr, type, indices, primcount);
                }
            }
            public static unsafe void MultiDrawElementsEXT(PrimitiveType mode, int[] count, DrawElementsType type, void** indices, int primcount)
            {
                fixed (int* count_ptr = count)
                {
                    MultiDrawElementsEXT(mode, count_ptr, type, indices, primcount);
                }
            }
            public static unsafe void MultiDrawElementsEXT(PrimitiveType mode, in int count, DrawElementsType type, void** indices, int primcount)
            {
                fixed (int* count_ptr = &count)
                {
                    MultiDrawElementsEXT(mode, count_ptr, type, indices, primcount);
                }
            }
            public static unsafe void ReadnPixelsEXT(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, IntPtr data)
            {
                void* data_vptr = (void*)data;
                ReadnPixelsEXT(x, y, width, height, format, type, bufSize, data_vptr);
            }
            public static unsafe void ReadnPixelsEXT<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, Span<T1> data)
                where T1 : unmanaged
            {
                int bufSize = (int)(data.Length * sizeof(T1));
                fixed (void* data_ptr = data)
                {
                    ReadnPixelsEXT(x, y, width, height, format, type, bufSize, data_ptr);
                }
            }
            public static unsafe void ReadnPixelsEXT<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, T1[] data)
                where T1 : unmanaged
            {
                int bufSize = (int)(data.Length * sizeof(T1));
                fixed (void* data_ptr = data)
                {
                    ReadnPixelsEXT(x, y, width, height, format, type, bufSize, data_ptr);
                }
            }
            public static unsafe void ReadnPixelsEXT<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, ref T1 data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    ReadnPixelsEXT(x, y, width, height, format, type, bufSize, data_ptr);
                }
            }
            public static unsafe void GetnUniformfvEXT(ProgramHandle program, int location, Span<float> parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (float* parameters_ptr = parameters)
                {
                    GetnUniformfvEXT(program, location, bufSize, parameters_ptr);
                }
            }
            public static unsafe void GetnUniformfvEXT(ProgramHandle program, int location, float[] parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (float* parameters_ptr = parameters)
                {
                    GetnUniformfvEXT(program, location, bufSize, parameters_ptr);
                }
            }
            public static unsafe void GetnUniformfvEXT(ProgramHandle program, int location, int bufSize, ref float parameters)
            {
                fixed (float* parameters_ptr = &parameters)
                {
                    GetnUniformfvEXT(program, location, bufSize, parameters_ptr);
                }
            }
            public static unsafe void GetnUniformivEXT(ProgramHandle program, int location, Span<int> parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (int* parameters_ptr = parameters)
                {
                    GetnUniformivEXT(program, location, bufSize, parameters_ptr);
                }
            }
            public static unsafe void GetnUniformivEXT(ProgramHandle program, int location, int[] parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (int* parameters_ptr = parameters)
                {
                    GetnUniformivEXT(program, location, bufSize, parameters_ptr);
                }
            }
            public static unsafe void GetnUniformivEXT(ProgramHandle program, int location, int bufSize, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetnUniformivEXT(program, location, bufSize, parameters_ptr);
                }
            }
        }
        public static unsafe partial class IMG
        {
            public static unsafe void ClipPlanefIMG(ClipPlaneName p, ReadOnlySpan<float> eqn)
            {
                fixed (float* eqn_ptr = eqn)
                {
                    ClipPlanefIMG(p, eqn_ptr);
                }
            }
            public static unsafe void ClipPlanefIMG(ClipPlaneName p, float[] eqn)
            {
                fixed (float* eqn_ptr = eqn)
                {
                    ClipPlanefIMG(p, eqn_ptr);
                }
            }
            public static unsafe void ClipPlanefIMG(ClipPlaneName p, in float eqn)
            {
                fixed (float* eqn_ptr = &eqn)
                {
                    ClipPlanefIMG(p, eqn_ptr);
                }
            }
            public static unsafe void ClipPlanexIMG(ClipPlaneName p, ReadOnlySpan<int> eqn)
            {
                fixed (int* eqn_ptr = eqn)
                {
                    ClipPlanexIMG(p, eqn_ptr);
                }
            }
            public static unsafe void ClipPlanexIMG(ClipPlaneName p, int[] eqn)
            {
                fixed (int* eqn_ptr = eqn)
                {
                    ClipPlanexIMG(p, eqn_ptr);
                }
            }
            public static unsafe void ClipPlanexIMG(ClipPlaneName p, in int eqn)
            {
                fixed (int* eqn_ptr = &eqn)
                {
                    ClipPlanexIMG(p, eqn_ptr);
                }
            }
        }
        public static unsafe partial class KHR
        {
            public static unsafe void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, ReadOnlySpan<uint> ids, bool enabled)
            {
                int count = (int)(ids.Length);
                fixed (uint* ids_ptr = ids)
                {
                    byte enabled_byte = (byte)(enabled ? 1 : 0);
                    DebugMessageControl(source, type, severity, count, ids_ptr, enabled_byte);
                }
            }
            public static unsafe void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, uint[] ids, bool enabled)
            {
                int count = (int)(ids.Length);
                fixed (uint* ids_ptr = ids)
                {
                    byte enabled_byte = (byte)(enabled ? 1 : 0);
                    DebugMessageControl(source, type, severity, count, ids_ptr, enabled_byte);
                }
            }
            public static unsafe void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, int count, in uint ids, bool enabled)
            {
                fixed (uint* ids_ptr = &ids)
                {
                    byte enabled_byte = (byte)(enabled ? 1 : 0);
                    DebugMessageControl(source, type, severity, count, ids_ptr, enabled_byte);
                }
            }
            public static unsafe void DebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, string buf)
            {
                byte* buf_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(buf);
                DebugMessageInsert(source, type, id, severity, length, buf_ptr);
                Marshal.FreeCoTaskMem((IntPtr)buf_ptr);
            }
            public static unsafe void DebugMessageCallback(GLDebugProc callback, IntPtr userParam)
            {
                void* userParam_vptr = (void*)userParam;
                IntPtr callback_ptr = Marshal.GetFunctionPointerForDelegate(callback);
                DebugMessageCallback(callback_ptr, userParam_vptr);
            }
            public static unsafe void DebugMessageCallback<T1>(GLDebugProc callback, in T1 userParam)
                where T1 : unmanaged
            {
                fixed (void* userParam_ptr = &userParam)
                {
                    IntPtr callback_ptr = Marshal.GetFunctionPointerForDelegate(callback);
                    DebugMessageCallback(callback_ptr, userParam_ptr);
                }
            }
            public static unsafe uint GetDebugMessageLog(uint count, int bufSize, Span<DebugSource> sources, Span<DebugType> types, Span<uint> ids, Span<DebugSeverity> severities, Span<int> lengths, out string messageLog)
            {
                uint returnValue;
                fixed (DebugSource* sources_ptr = sources)
                {
                    fixed (DebugType* types_ptr = types)
                    {
                        fixed (uint* ids_ptr = ids)
                        {
                            fixed (DebugSeverity* severities_ptr = severities)
                            {
                                fixed (int* lengths_ptr = lengths)
                                {
                                    var messageLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                                    returnValue = GetDebugMessageLog(count, bufSize, sources_ptr, types_ptr, ids_ptr, severities_ptr, lengths_ptr, messageLog_ptr);
                                    messageLog = Marshal.PtrToStringUTF8((IntPtr)messageLog_ptr)!;
                                    Marshal.FreeCoTaskMem((IntPtr)messageLog_ptr);
                                }
                            }
                        }
                    }
                }
                return returnValue;
            }
            public static unsafe uint GetDebugMessageLog(uint count, int bufSize, DebugSource[] sources, DebugType[] types, uint[] ids, DebugSeverity[] severities, int[] lengths, out string messageLog)
            {
                uint returnValue;
                fixed (DebugSource* sources_ptr = sources)
                {
                    fixed (DebugType* types_ptr = types)
                    {
                        fixed (uint* ids_ptr = ids)
                        {
                            fixed (DebugSeverity* severities_ptr = severities)
                            {
                                fixed (int* lengths_ptr = lengths)
                                {
                                    var messageLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                                    returnValue = GetDebugMessageLog(count, bufSize, sources_ptr, types_ptr, ids_ptr, severities_ptr, lengths_ptr, messageLog_ptr);
                                    messageLog = Marshal.PtrToStringUTF8((IntPtr)messageLog_ptr)!;
                                    Marshal.FreeCoTaskMem((IntPtr)messageLog_ptr);
                                }
                            }
                        }
                    }
                }
                return returnValue;
            }
            public static unsafe uint GetDebugMessageLog(uint count, int bufSize, ref DebugSource sources, ref DebugType types, ref uint ids, ref DebugSeverity severities, ref int lengths, out string messageLog)
            {
                uint returnValue;
                fixed (DebugSource* sources_ptr = &sources)
                fixed (DebugType* types_ptr = &types)
                fixed (uint* ids_ptr = &ids)
                fixed (DebugSeverity* severities_ptr = &severities)
                fixed (int* lengths_ptr = &lengths)
                {
                    var messageLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    returnValue = GetDebugMessageLog(count, bufSize, sources_ptr, types_ptr, ids_ptr, severities_ptr, lengths_ptr, messageLog_ptr);
                    messageLog = Marshal.PtrToStringUTF8((IntPtr)messageLog_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)messageLog_ptr);
                }
                return returnValue;
            }
            public static unsafe void PushDebugGroup(DebugSource source, uint id, int length, string message)
            {
                byte* message_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(message);
                PushDebugGroup(source, id, length, message_ptr);
                Marshal.FreeCoTaskMem((IntPtr)message_ptr);
            }
            public static unsafe void ObjectLabel(ObjectIdentifier identifier, uint name, int length, string label)
            {
                byte* label_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(label);
                ObjectLabel(identifier, name, length, label_ptr);
                Marshal.FreeCoTaskMem((IntPtr)label_ptr);
            }
            public static unsafe string GetObjectLabel(ObjectIdentifier identifier, uint name, int bufSize, Span<int> length)
            {
                string label;
                fixed (int* length_ptr = length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetObjectLabel(identifier, name, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
                return label;
            }
            public static unsafe void GetObjectLabel(ObjectIdentifier identifier, uint name, int bufSize, Span<int> length, out string label)
            {
                fixed (int* length_ptr = length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetObjectLabel(identifier, name, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
            }
            public static unsafe string GetObjectLabel(ObjectIdentifier identifier, uint name, int bufSize, int[] length)
            {
                string label;
                fixed (int* length_ptr = length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetObjectLabel(identifier, name, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
                return label;
            }
            public static unsafe void GetObjectLabel(ObjectIdentifier identifier, uint name, int bufSize, int[] length, out string label)
            {
                fixed (int* length_ptr = length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetObjectLabel(identifier, name, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
            }
            public static unsafe string GetObjectLabel(ObjectIdentifier identifier, uint name, int bufSize, ref int length)
            {
                string label;
                fixed (int* length_ptr = &length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetObjectLabel(identifier, name, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
                return label;
            }
            public static unsafe void GetObjectLabel(ObjectIdentifier identifier, uint name, int bufSize, ref int length, out string label)
            {
                fixed (int* length_ptr = &length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetObjectLabel(identifier, name, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
            }
            public static unsafe void ObjectPtrLabel(IntPtr ptr, int length, string label)
            {
                byte* label_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(label);
                void* ptr_vptr = (void*)ptr;
                ObjectPtrLabel(ptr_vptr, length, label_ptr);
                Marshal.FreeCoTaskMem((IntPtr)label_ptr);
            }
            public static unsafe void ObjectPtrLabel<T1>(in T1 ptr, int length, string label)
                where T1 : unmanaged
            {
                fixed (void* ptr_ptr = &ptr)
                {
                    byte* label_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(label);
                    ObjectPtrLabel(ptr_ptr, length, label_ptr);
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
            }
            public static unsafe string GetObjectPtrLabel(IntPtr ptr, int bufSize, Span<int> length)
            {
                string label;
                fixed (int* length_ptr = length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    void* ptr_vptr = (void*)ptr;
                    GetObjectPtrLabel(ptr_vptr, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
                return label;
            }
            public static unsafe void GetObjectPtrLabel(IntPtr ptr, int bufSize, Span<int> length, out string label)
            {
                fixed (int* length_ptr = length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    void* ptr_vptr = (void*)ptr;
                    GetObjectPtrLabel(ptr_vptr, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
            }
            public static unsafe string GetObjectPtrLabel(IntPtr ptr, int bufSize, int[] length)
            {
                string label;
                fixed (int* length_ptr = length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    void* ptr_vptr = (void*)ptr;
                    GetObjectPtrLabel(ptr_vptr, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
                return label;
            }
            public static unsafe void GetObjectPtrLabel(IntPtr ptr, int bufSize, int[] length, out string label)
            {
                fixed (int* length_ptr = length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    void* ptr_vptr = (void*)ptr;
                    GetObjectPtrLabel(ptr_vptr, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
            }
            public static unsafe string GetObjectPtrLabel(IntPtr ptr, int bufSize, ref int length)
            {
                string label;
                fixed (int* length_ptr = &length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    void* ptr_vptr = (void*)ptr;
                    GetObjectPtrLabel(ptr_vptr, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
                return label;
            }
            public static unsafe void GetObjectPtrLabel(IntPtr ptr, int bufSize, ref int length, out string label)
            {
                fixed (int* length_ptr = &length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    void* ptr_vptr = (void*)ptr;
                    GetObjectPtrLabel(ptr_vptr, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
            }
            public static unsafe string GetObjectPtrLabel<T1>(in T1 ptr, int bufSize, Span<int> length)
                where T1 : unmanaged
            {
                string label;
                fixed (void* ptr_ptr = &ptr)
                {
                    fixed (int* length_ptr = length)
                    {
                        var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                        GetObjectPtrLabel(ptr_ptr, bufSize, length_ptr, label_ptr);
                        label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                        Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                    }
                }
                return label;
            }
            public static unsafe void GetObjectPtrLabel<T1>(in T1 ptr, int bufSize, Span<int> length, out string label)
                where T1 : unmanaged
            {
                fixed (void* ptr_ptr = &ptr)
                {
                    fixed (int* length_ptr = length)
                    {
                        var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                        GetObjectPtrLabel(ptr_ptr, bufSize, length_ptr, label_ptr);
                        label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                        Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                    }
                }
            }
            public static unsafe string GetObjectPtrLabel<T1>(in T1 ptr, int bufSize, int[] length)
                where T1 : unmanaged
            {
                string label;
                fixed (void* ptr_ptr = &ptr)
                {
                    fixed (int* length_ptr = length)
                    {
                        var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                        GetObjectPtrLabel(ptr_ptr, bufSize, length_ptr, label_ptr);
                        label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                        Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                    }
                }
                return label;
            }
            public static unsafe void GetObjectPtrLabel<T1>(in T1 ptr, int bufSize, int[] length, out string label)
                where T1 : unmanaged
            {
                fixed (void* ptr_ptr = &ptr)
                {
                    fixed (int* length_ptr = length)
                    {
                        var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                        GetObjectPtrLabel(ptr_ptr, bufSize, length_ptr, label_ptr);
                        label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                        Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                    }
                }
            }
            public static unsafe string GetObjectPtrLabel<T1>(in T1 ptr, int bufSize, ref int length)
                where T1 : unmanaged
            {
                string label;
                fixed (void* ptr_ptr = &ptr)
                fixed (int* length_ptr = &length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetObjectPtrLabel(ptr_ptr, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
                return label;
            }
            public static unsafe void GetObjectPtrLabel<T1>(in T1 ptr, int bufSize, ref int length, out string label)
                where T1 : unmanaged
            {
                fixed (void* ptr_ptr = &ptr)
                fixed (int* length_ptr = &length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetObjectPtrLabel(ptr_ptr, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
            }
            /// <summary> Return the address of the specified pointer. </summary>
            /// <param name="pname"> Specifies the array or buffer pointer to be returned. Accepted symbolic names are GL_COLOR_ARRAY_POINTER, GL_MATRIX_INDEX_ARRAY_POINTER_OES, GL_NORMAL_ARRAY_POINTER, GL_POINT_SIZE_ARRAY_POINTER_OES, GL_TEXTURE_COORD_ARRAY_POINTER, and GL_VERTEX_ARRAY_POINTER., and GL_WEIGHT_ARRAY_POINTER_OES. </param>
            public static unsafe void GetPointer(GetPointervPName pname, void** parameters)
            {
                GetPointerv(pname, parameters);
            }
            public static unsafe void DebugMessageControlKHR(DebugSource source, DebugType type, DebugSeverity severity, int count, in uint ids, bool enabled)
            {
                fixed (uint* ids_ptr = &ids)
                {
                    byte enabled_byte = (byte)(enabled ? 1 : 0);
                    DebugMessageControlKHR(source, type, severity, count, ids_ptr, enabled_byte);
                }
            }
            public static unsafe void DebugMessageInsertKHR(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, string buf)
            {
                byte* buf_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(buf);
                DebugMessageInsertKHR(source, type, id, severity, length, buf_ptr);
                Marshal.FreeCoTaskMem((IntPtr)buf_ptr);
            }
            public static unsafe void DebugMessageCallbackKHR(GLDebugProcKHR callback, IntPtr userParam)
            {
                void* userParam_vptr = (void*)userParam;
                IntPtr callback_ptr = Marshal.GetFunctionPointerForDelegate(callback);
                DebugMessageCallbackKHR(callback_ptr, userParam_vptr);
            }
            public static unsafe void DebugMessageCallbackKHR<T1>(GLDebugProcKHR callback, in T1 userParam)
                where T1 : unmanaged
            {
                fixed (void* userParam_ptr = &userParam)
                {
                    IntPtr callback_ptr = Marshal.GetFunctionPointerForDelegate(callback);
                    DebugMessageCallbackKHR(callback_ptr, userParam_ptr);
                }
            }
            public static unsafe uint GetDebugMessageLogKHR(uint count, int bufSize, Span<DebugSource> sources, Span<DebugType> types, Span<uint> ids, Span<DebugSeverity> severities, Span<int> lengths, out string messageLog)
            {
                uint returnValue;
                fixed (DebugSource* sources_ptr = sources)
                {
                    fixed (DebugType* types_ptr = types)
                    {
                        fixed (uint* ids_ptr = ids)
                        {
                            fixed (DebugSeverity* severities_ptr = severities)
                            {
                                fixed (int* lengths_ptr = lengths)
                                {
                                    var messageLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                                    returnValue = GetDebugMessageLogKHR(count, bufSize, sources_ptr, types_ptr, ids_ptr, severities_ptr, lengths_ptr, messageLog_ptr);
                                    messageLog = Marshal.PtrToStringUTF8((IntPtr)messageLog_ptr)!;
                                    Marshal.FreeCoTaskMem((IntPtr)messageLog_ptr);
                                }
                            }
                        }
                    }
                }
                return returnValue;
            }
            public static unsafe uint GetDebugMessageLogKHR(uint count, int bufSize, DebugSource[] sources, DebugType[] types, uint[] ids, DebugSeverity[] severities, int[] lengths, out string messageLog)
            {
                uint returnValue;
                fixed (DebugSource* sources_ptr = sources)
                {
                    fixed (DebugType* types_ptr = types)
                    {
                        fixed (uint* ids_ptr = ids)
                        {
                            fixed (DebugSeverity* severities_ptr = severities)
                            {
                                fixed (int* lengths_ptr = lengths)
                                {
                                    var messageLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                                    returnValue = GetDebugMessageLogKHR(count, bufSize, sources_ptr, types_ptr, ids_ptr, severities_ptr, lengths_ptr, messageLog_ptr);
                                    messageLog = Marshal.PtrToStringUTF8((IntPtr)messageLog_ptr)!;
                                    Marshal.FreeCoTaskMem((IntPtr)messageLog_ptr);
                                }
                            }
                        }
                    }
                }
                return returnValue;
            }
            public static unsafe uint GetDebugMessageLogKHR(uint count, int bufSize, ref DebugSource sources, ref DebugType types, ref uint ids, ref DebugSeverity severities, ref int lengths, out string messageLog)
            {
                uint returnValue;
                fixed (DebugSource* sources_ptr = &sources)
                fixed (DebugType* types_ptr = &types)
                fixed (uint* ids_ptr = &ids)
                fixed (DebugSeverity* severities_ptr = &severities)
                fixed (int* lengths_ptr = &lengths)
                {
                    var messageLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    returnValue = GetDebugMessageLogKHR(count, bufSize, sources_ptr, types_ptr, ids_ptr, severities_ptr, lengths_ptr, messageLog_ptr);
                    messageLog = Marshal.PtrToStringUTF8((IntPtr)messageLog_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)messageLog_ptr);
                }
                return returnValue;
            }
            public static unsafe void PushDebugGroupKHR(DebugSource source, uint id, int length, string message)
            {
                byte* message_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(message);
                PushDebugGroupKHR(source, id, length, message_ptr);
                Marshal.FreeCoTaskMem((IntPtr)message_ptr);
            }
            public static unsafe void ObjectLabelKHR(ObjectIdentifier identifier, uint name, int length, string label)
            {
                byte* label_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(label);
                ObjectLabelKHR(identifier, name, length, label_ptr);
                Marshal.FreeCoTaskMem((IntPtr)label_ptr);
            }
            public static unsafe string GetObjectLabelKHR(All identifier, uint name, int bufSize, ref int length)
            {
                string label;
                fixed (int* length_ptr = &length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetObjectLabelKHR(identifier, name, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
                return label;
            }
            public static unsafe void GetObjectLabelKHR(All identifier, uint name, int bufSize, ref int length, out string label)
            {
                fixed (int* length_ptr = &length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetObjectLabelKHR(identifier, name, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
            }
            public static unsafe void ObjectPtrLabelKHR(IntPtr ptr, int length, string label)
            {
                byte* label_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(label);
                void* ptr_vptr = (void*)ptr;
                ObjectPtrLabelKHR(ptr_vptr, length, label_ptr);
                Marshal.FreeCoTaskMem((IntPtr)label_ptr);
            }
            public static unsafe void ObjectPtrLabelKHR<T1>(in T1 ptr, int length, string label)
                where T1 : unmanaged
            {
                fixed (void* ptr_ptr = &ptr)
                {
                    byte* label_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(label);
                    ObjectPtrLabelKHR(ptr_ptr, length, label_ptr);
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
            }
            public static unsafe string GetObjectPtrLabelKHR(IntPtr ptr, int bufSize, Span<int> length)
            {
                string label;
                fixed (int* length_ptr = length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    void* ptr_vptr = (void*)ptr;
                    GetObjectPtrLabelKHR(ptr_vptr, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
                return label;
            }
            public static unsafe void GetObjectPtrLabelKHR(IntPtr ptr, int bufSize, Span<int> length, out string label)
            {
                fixed (int* length_ptr = length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    void* ptr_vptr = (void*)ptr;
                    GetObjectPtrLabelKHR(ptr_vptr, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
            }
            public static unsafe string GetObjectPtrLabelKHR(IntPtr ptr, int bufSize, int[] length)
            {
                string label;
                fixed (int* length_ptr = length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    void* ptr_vptr = (void*)ptr;
                    GetObjectPtrLabelKHR(ptr_vptr, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
                return label;
            }
            public static unsafe void GetObjectPtrLabelKHR(IntPtr ptr, int bufSize, int[] length, out string label)
            {
                fixed (int* length_ptr = length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    void* ptr_vptr = (void*)ptr;
                    GetObjectPtrLabelKHR(ptr_vptr, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
            }
            public static unsafe string GetObjectPtrLabelKHR(IntPtr ptr, int bufSize, ref int length)
            {
                string label;
                fixed (int* length_ptr = &length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    void* ptr_vptr = (void*)ptr;
                    GetObjectPtrLabelKHR(ptr_vptr, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
                return label;
            }
            public static unsafe void GetObjectPtrLabelKHR(IntPtr ptr, int bufSize, ref int length, out string label)
            {
                fixed (int* length_ptr = &length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    void* ptr_vptr = (void*)ptr;
                    GetObjectPtrLabelKHR(ptr_vptr, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
            }
            public static unsafe string GetObjectPtrLabelKHR<T1>(in T1 ptr, int bufSize, Span<int> length)
                where T1 : unmanaged
            {
                string label;
                fixed (void* ptr_ptr = &ptr)
                {
                    fixed (int* length_ptr = length)
                    {
                        var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                        GetObjectPtrLabelKHR(ptr_ptr, bufSize, length_ptr, label_ptr);
                        label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                        Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                    }
                }
                return label;
            }
            public static unsafe void GetObjectPtrLabelKHR<T1>(in T1 ptr, int bufSize, Span<int> length, out string label)
                where T1 : unmanaged
            {
                fixed (void* ptr_ptr = &ptr)
                {
                    fixed (int* length_ptr = length)
                    {
                        var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                        GetObjectPtrLabelKHR(ptr_ptr, bufSize, length_ptr, label_ptr);
                        label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                        Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                    }
                }
            }
            public static unsafe string GetObjectPtrLabelKHR<T1>(in T1 ptr, int bufSize, int[] length)
                where T1 : unmanaged
            {
                string label;
                fixed (void* ptr_ptr = &ptr)
                {
                    fixed (int* length_ptr = length)
                    {
                        var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                        GetObjectPtrLabelKHR(ptr_ptr, bufSize, length_ptr, label_ptr);
                        label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                        Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                    }
                }
                return label;
            }
            public static unsafe void GetObjectPtrLabelKHR<T1>(in T1 ptr, int bufSize, int[] length, out string label)
                where T1 : unmanaged
            {
                fixed (void* ptr_ptr = &ptr)
                {
                    fixed (int* length_ptr = length)
                    {
                        var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                        GetObjectPtrLabelKHR(ptr_ptr, bufSize, length_ptr, label_ptr);
                        label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                        Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                    }
                }
            }
            public static unsafe string GetObjectPtrLabelKHR<T1>(in T1 ptr, int bufSize, ref int length)
                where T1 : unmanaged
            {
                string label;
                fixed (void* ptr_ptr = &ptr)
                fixed (int* length_ptr = &length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetObjectPtrLabelKHR(ptr_ptr, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
                return label;
            }
            public static unsafe void GetObjectPtrLabelKHR<T1>(in T1 ptr, int bufSize, ref int length, out string label)
                where T1 : unmanaged
            {
                fixed (void* ptr_ptr = &ptr)
                fixed (int* length_ptr = &length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetObjectPtrLabelKHR(ptr_ptr, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
            }
        }
        public static unsafe partial class NV
        {
            public static unsafe void DeleteFencesNV(ReadOnlySpan<uint> fences)
            {
                int n = (int)(fences.Length);
                fixed (uint* fences_ptr = fences)
                {
                    DeleteFencesNV(n, fences_ptr);
                }
            }
            public static unsafe void DeleteFencesNV(uint[] fences)
            {
                int n = (int)(fences.Length);
                fixed (uint* fences_ptr = fences)
                {
                    DeleteFencesNV(n, fences_ptr);
                }
            }
            public static unsafe void DeleteFencesNV(int n, in uint fences)
            {
                fixed (uint* fences_ptr = &fences)
                {
                    DeleteFencesNV(n, fences_ptr);
                }
            }
            public static unsafe void GenFencesNV(Span<uint> fences)
            {
                int n = (int)(fences.Length);
                fixed (uint* fences_ptr = fences)
                {
                    GenFencesNV(n, fences_ptr);
                }
            }
            public static unsafe void GenFencesNV(uint[] fences)
            {
                int n = (int)(fences.Length);
                fixed (uint* fences_ptr = fences)
                {
                    GenFencesNV(n, fences_ptr);
                }
            }
            public static unsafe void GenFencesNV(int n, ref uint fences)
            {
                fixed (uint* fences_ptr = &fences)
                {
                    GenFencesNV(n, fences_ptr);
                }
            }
            public static unsafe void GetFenceivNV(uint fence, FenceParameterNameNV pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetFenceivNV(fence, pname, parameters_ptr);
                }
            }
            public static unsafe void GetFenceivNV(uint fence, FenceParameterNameNV pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetFenceivNV(fence, pname, parameters_ptr);
                }
            }
            public static unsafe void GetFenceivNV(uint fence, FenceParameterNameNV pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetFenceivNV(fence, pname, parameters_ptr);
                }
            }
        }
        public static unsafe partial class OES
        {
            public static unsafe void EGLImageTargetTexture2DOES(All target, IntPtr image)
            {
                void* image_vptr = (void*)image;
                EGLImageTargetTexture2DOES(target, image_vptr);
            }
            public static unsafe void EGLImageTargetTexture2DOES<T1>(All target, ref T1 image)
                where T1 : unmanaged
            {
                fixed (void* image_ptr = &image)
                {
                    EGLImageTargetTexture2DOES(target, image_ptr);
                }
            }
            public static unsafe void EGLImageTargetRenderbufferStorageOES(All target, IntPtr image)
            {
                void* image_vptr = (void*)image;
                EGLImageTargetRenderbufferStorageOES(target, image_vptr);
            }
            public static unsafe void EGLImageTargetRenderbufferStorageOES<T1>(All target, ref T1 image)
                where T1 : unmanaged
            {
                fixed (void* image_ptr = &image)
                {
                    EGLImageTargetRenderbufferStorageOES(target, image_ptr);
                }
            }
            public static unsafe void MultiTexCoord1bvOES(TextureUnit texture, ReadOnlySpan<sbyte> coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    MultiTexCoord1bvOES(texture, coords_ptr);
                }
            }
            public static unsafe void MultiTexCoord1bvOES(TextureUnit texture, sbyte[] coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    MultiTexCoord1bvOES(texture, coords_ptr);
                }
            }
            public static unsafe void MultiTexCoord1bvOES(TextureUnit texture, in sbyte coords)
            {
                fixed (sbyte* coords_ptr = &coords)
                {
                    MultiTexCoord1bvOES(texture, coords_ptr);
                }
            }
            public static unsafe void MultiTexCoord2bvOES(TextureUnit texture, ReadOnlySpan<sbyte> coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    MultiTexCoord2bvOES(texture, coords_ptr);
                }
            }
            public static unsafe void MultiTexCoord2bvOES(TextureUnit texture, sbyte[] coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    MultiTexCoord2bvOES(texture, coords_ptr);
                }
            }
            public static unsafe void MultiTexCoord2bvOES(TextureUnit texture, in sbyte coords)
            {
                fixed (sbyte* coords_ptr = &coords)
                {
                    MultiTexCoord2bvOES(texture, coords_ptr);
                }
            }
            public static unsafe void MultiTexCoord3bvOES(TextureUnit texture, ReadOnlySpan<sbyte> coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    MultiTexCoord3bvOES(texture, coords_ptr);
                }
            }
            public static unsafe void MultiTexCoord3bvOES(TextureUnit texture, sbyte[] coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    MultiTexCoord3bvOES(texture, coords_ptr);
                }
            }
            public static unsafe void MultiTexCoord3bvOES(TextureUnit texture, in sbyte coords)
            {
                fixed (sbyte* coords_ptr = &coords)
                {
                    MultiTexCoord3bvOES(texture, coords_ptr);
                }
            }
            public static unsafe void MultiTexCoord4bvOES(TextureUnit texture, ReadOnlySpan<sbyte> coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    MultiTexCoord4bvOES(texture, coords_ptr);
                }
            }
            public static unsafe void MultiTexCoord4bvOES(TextureUnit texture, sbyte[] coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    MultiTexCoord4bvOES(texture, coords_ptr);
                }
            }
            public static unsafe void MultiTexCoord4bvOES(TextureUnit texture, in sbyte coords)
            {
                fixed (sbyte* coords_ptr = &coords)
                {
                    MultiTexCoord4bvOES(texture, coords_ptr);
                }
            }
            public static unsafe void TexCoord1bvOES(ReadOnlySpan<sbyte> coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    TexCoord1bvOES(coords_ptr);
                }
            }
            public static unsafe void TexCoord1bvOES(sbyte[] coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    TexCoord1bvOES(coords_ptr);
                }
            }
            public static unsafe void TexCoord1bvOES(in sbyte coords)
            {
                fixed (sbyte* coords_ptr = &coords)
                {
                    TexCoord1bvOES(coords_ptr);
                }
            }
            public static unsafe void TexCoord2bvOES(ReadOnlySpan<sbyte> coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    TexCoord2bvOES(coords_ptr);
                }
            }
            public static unsafe void TexCoord2bvOES(sbyte[] coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    TexCoord2bvOES(coords_ptr);
                }
            }
            public static unsafe void TexCoord2bvOES(in sbyte coords)
            {
                fixed (sbyte* coords_ptr = &coords)
                {
                    TexCoord2bvOES(coords_ptr);
                }
            }
            public static unsafe void TexCoord3bvOES(ReadOnlySpan<sbyte> coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    TexCoord3bvOES(coords_ptr);
                }
            }
            public static unsafe void TexCoord3bvOES(sbyte[] coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    TexCoord3bvOES(coords_ptr);
                }
            }
            public static unsafe void TexCoord3bvOES(in sbyte coords)
            {
                fixed (sbyte* coords_ptr = &coords)
                {
                    TexCoord3bvOES(coords_ptr);
                }
            }
            public static unsafe void TexCoord4bvOES(ReadOnlySpan<sbyte> coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    TexCoord4bvOES(coords_ptr);
                }
            }
            public static unsafe void TexCoord4bvOES(sbyte[] coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    TexCoord4bvOES(coords_ptr);
                }
            }
            public static unsafe void TexCoord4bvOES(in sbyte coords)
            {
                fixed (sbyte* coords_ptr = &coords)
                {
                    TexCoord4bvOES(coords_ptr);
                }
            }
            public static unsafe void Vertex2bvOES(ReadOnlySpan<sbyte> coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    Vertex2bvOES(coords_ptr);
                }
            }
            public static unsafe void Vertex2bvOES(sbyte[] coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    Vertex2bvOES(coords_ptr);
                }
            }
            public static unsafe void Vertex2bvOES(in sbyte coords)
            {
                fixed (sbyte* coords_ptr = &coords)
                {
                    Vertex2bvOES(coords_ptr);
                }
            }
            public static unsafe void Vertex3bvOES(ReadOnlySpan<sbyte> coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    Vertex3bvOES(coords_ptr);
                }
            }
            public static unsafe void Vertex3bvOES(sbyte[] coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    Vertex3bvOES(coords_ptr);
                }
            }
            public static unsafe void Vertex3bvOES(in sbyte coords)
            {
                fixed (sbyte* coords_ptr = &coords)
                {
                    Vertex3bvOES(coords_ptr);
                }
            }
            public static unsafe void Vertex4bvOES(ReadOnlySpan<sbyte> coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    Vertex4bvOES(coords_ptr);
                }
            }
            public static unsafe void Vertex4bvOES(sbyte[] coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    Vertex4bvOES(coords_ptr);
                }
            }
            public static unsafe void Vertex4bvOES(in sbyte coords)
            {
                fixed (sbyte* coords_ptr = &coords)
                {
                    Vertex4bvOES(coords_ptr);
                }
            }
            public static unsafe void DrawTexsvOES(ReadOnlySpan<short> coords)
            {
                fixed (short* coords_ptr = coords)
                {
                    DrawTexsvOES(coords_ptr);
                }
            }
            public static unsafe void DrawTexsvOES(short[] coords)
            {
                fixed (short* coords_ptr = coords)
                {
                    DrawTexsvOES(coords_ptr);
                }
            }
            public static unsafe void DrawTexsvOES(in short coords)
            {
                fixed (short* coords_ptr = &coords)
                {
                    DrawTexsvOES(coords_ptr);
                }
            }
            public static unsafe void DrawTexivOES(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    DrawTexivOES(coords_ptr);
                }
            }
            public static unsafe void DrawTexivOES(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    DrawTexivOES(coords_ptr);
                }
            }
            public static unsafe void DrawTexivOES(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    DrawTexivOES(coords_ptr);
                }
            }
            public static unsafe void DrawTexxvOES(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    DrawTexxvOES(coords_ptr);
                }
            }
            public static unsafe void DrawTexxvOES(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    DrawTexxvOES(coords_ptr);
                }
            }
            public static unsafe void DrawTexxvOES(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    DrawTexxvOES(coords_ptr);
                }
            }
            public static unsafe void DrawTexfvOES(ReadOnlySpan<float> coords)
            {
                fixed (float* coords_ptr = coords)
                {
                    DrawTexfvOES(coords_ptr);
                }
            }
            public static unsafe void DrawTexfvOES(float[] coords)
            {
                fixed (float* coords_ptr = coords)
                {
                    DrawTexfvOES(coords_ptr);
                }
            }
            public static unsafe void DrawTexfvOES(in float coords)
            {
                fixed (float* coords_ptr = &coords)
                {
                    DrawTexfvOES(coords_ptr);
                }
            }
            public static unsafe void ClipPlanexOES(ClipPlaneName plane, ReadOnlySpan<int> equation)
            {
                fixed (int* equation_ptr = equation)
                {
                    ClipPlanexOES(plane, equation_ptr);
                }
            }
            public static unsafe void ClipPlanexOES(ClipPlaneName plane, int[] equation)
            {
                fixed (int* equation_ptr = equation)
                {
                    ClipPlanexOES(plane, equation_ptr);
                }
            }
            public static unsafe void ClipPlanexOES(ClipPlaneName plane, in int equation)
            {
                fixed (int* equation_ptr = &equation)
                {
                    ClipPlanexOES(plane, equation_ptr);
                }
            }
            public static unsafe void FogxvOES(FogPName pname, ReadOnlySpan<int> param)
            {
                fixed (int* param_ptr = param)
                {
                    FogxvOES(pname, param_ptr);
                }
            }
            public static unsafe void FogxvOES(FogPName pname, int[] param)
            {
                fixed (int* param_ptr = param)
                {
                    FogxvOES(pname, param_ptr);
                }
            }
            public static unsafe void FogxvOES(FogPName pname, in int param)
            {
                fixed (int* param_ptr = &param)
                {
                    FogxvOES(pname, param_ptr);
                }
            }
            public static unsafe void GetClipPlanexOES(ClipPlaneName plane, Span<int> equation)
            {
                fixed (int* equation_ptr = equation)
                {
                    GetClipPlanexOES(plane, equation_ptr);
                }
            }
            public static unsafe void GetClipPlanexOES(ClipPlaneName plane, int[] equation)
            {
                fixed (int* equation_ptr = equation)
                {
                    GetClipPlanexOES(plane, equation_ptr);
                }
            }
            public static unsafe void GetClipPlanexOES(ClipPlaneName plane, ref int equation)
            {
                fixed (int* equation_ptr = &equation)
                {
                    GetClipPlanexOES(plane, equation_ptr);
                }
            }
            public static unsafe void GetFixedvOES(GetPName pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetFixedvOES(pname, parameters_ptr);
                }
            }
            public static unsafe void GetFixedvOES(GetPName pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetFixedvOES(pname, parameters_ptr);
                }
            }
            public static unsafe void GetFixedvOES(GetPName pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetFixedvOES(pname, parameters_ptr);
                }
            }
            public static unsafe void GetTexEnvxvOES(TextureEnvTarget target, TextureEnvParameter pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexEnvxvOES(target, pname, parameters_ptr);
                }
            }
            public static unsafe void GetTexEnvxvOES(TextureEnvTarget target, TextureEnvParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexEnvxvOES(target, pname, parameters_ptr);
                }
            }
            public static unsafe void GetTexEnvxvOES(TextureEnvTarget target, TextureEnvParameter pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetTexEnvxvOES(target, pname, parameters_ptr);
                }
            }
            public static unsafe void GetTexParameterxvOES(TextureTarget target, GetTextureParameter pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexParameterxvOES(target, pname, parameters_ptr);
                }
            }
            public static unsafe void GetTexParameterxvOES(TextureTarget target, GetTextureParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexParameterxvOES(target, pname, parameters_ptr);
                }
            }
            public static unsafe void GetTexParameterxvOES(TextureTarget target, GetTextureParameter pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetTexParameterxvOES(target, pname, parameters_ptr);
                }
            }
            public static unsafe void LightModelxvOES(LightModelParameter pname, ReadOnlySpan<int> param)
            {
                fixed (int* param_ptr = param)
                {
                    LightModelxvOES(pname, param_ptr);
                }
            }
            public static unsafe void LightModelxvOES(LightModelParameter pname, int[] param)
            {
                fixed (int* param_ptr = param)
                {
                    LightModelxvOES(pname, param_ptr);
                }
            }
            public static unsafe void LightModelxvOES(LightModelParameter pname, in int param)
            {
                fixed (int* param_ptr = &param)
                {
                    LightModelxvOES(pname, param_ptr);
                }
            }
            public static unsafe void LightxvOES(LightName light, LightParameter pname, ReadOnlySpan<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    LightxvOES(light, pname, parameters_ptr);
                }
            }
            public static unsafe void LightxvOES(LightName light, LightParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    LightxvOES(light, pname, parameters_ptr);
                }
            }
            public static unsafe void LightxvOES(LightName light, LightParameter pname, in int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    LightxvOES(light, pname, parameters_ptr);
                }
            }
            public static unsafe void LoadMatrixxOES(ReadOnlySpan<int> m)
            {
                fixed (int* m_ptr = m)
                {
                    LoadMatrixxOES(m_ptr);
                }
            }
            public static unsafe void LoadMatrixxOES(int[] m)
            {
                fixed (int* m_ptr = m)
                {
                    LoadMatrixxOES(m_ptr);
                }
            }
            public static unsafe void LoadMatrixxOES(in int m)
            {
                fixed (int* m_ptr = &m)
                {
                    LoadMatrixxOES(m_ptr);
                }
            }
            public static unsafe void MaterialxvOES(MaterialFace face, MaterialParameter pname, ReadOnlySpan<int> param)
            {
                fixed (int* param_ptr = param)
                {
                    MaterialxvOES(face, pname, param_ptr);
                }
            }
            public static unsafe void MaterialxvOES(MaterialFace face, MaterialParameter pname, int[] param)
            {
                fixed (int* param_ptr = param)
                {
                    MaterialxvOES(face, pname, param_ptr);
                }
            }
            public static unsafe void MaterialxvOES(MaterialFace face, MaterialParameter pname, in int param)
            {
                fixed (int* param_ptr = &param)
                {
                    MaterialxvOES(face, pname, param_ptr);
                }
            }
            public static unsafe void MultMatrixxOES(ReadOnlySpan<int> m)
            {
                fixed (int* m_ptr = m)
                {
                    MultMatrixxOES(m_ptr);
                }
            }
            public static unsafe void MultMatrixxOES(int[] m)
            {
                fixed (int* m_ptr = m)
                {
                    MultMatrixxOES(m_ptr);
                }
            }
            public static unsafe void MultMatrixxOES(in int m)
            {
                fixed (int* m_ptr = &m)
                {
                    MultMatrixxOES(m_ptr);
                }
            }
            public static unsafe void PointParameterxvOES(PointParameterNameARB pname, ReadOnlySpan<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    PointParameterxvOES(pname, parameters_ptr);
                }
            }
            public static unsafe void PointParameterxvOES(PointParameterNameARB pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    PointParameterxvOES(pname, parameters_ptr);
                }
            }
            public static unsafe void PointParameterxvOES(PointParameterNameARB pname, in int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    PointParameterxvOES(pname, parameters_ptr);
                }
            }
            public static unsafe void TexEnvxvOES(TextureEnvTarget target, TextureEnvParameter pname, ReadOnlySpan<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    TexEnvxvOES(target, pname, parameters_ptr);
                }
            }
            public static unsafe void TexEnvxvOES(TextureEnvTarget target, TextureEnvParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    TexEnvxvOES(target, pname, parameters_ptr);
                }
            }
            public static unsafe void TexEnvxvOES(TextureEnvTarget target, TextureEnvParameter pname, in int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    TexEnvxvOES(target, pname, parameters_ptr);
                }
            }
            public static unsafe void TexParameterxvOES(TextureTarget target, GetTextureParameter pname, ReadOnlySpan<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    TexParameterxvOES(target, pname, parameters_ptr);
                }
            }
            public static unsafe void TexParameterxvOES(TextureTarget target, GetTextureParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    TexParameterxvOES(target, pname, parameters_ptr);
                }
            }
            public static unsafe void TexParameterxvOES(TextureTarget target, GetTextureParameter pname, in int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    TexParameterxvOES(target, pname, parameters_ptr);
                }
            }
            public static unsafe void GetLightxvOES(LightName light, LightParameter pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetLightxvOES(light, pname, parameters_ptr);
                }
            }
            public static unsafe void GetLightxvOES(LightName light, LightParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetLightxvOES(light, pname, parameters_ptr);
                }
            }
            public static unsafe void GetLightxvOES(LightName light, LightParameter pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetLightxvOES(light, pname, parameters_ptr);
                }
            }
            public static unsafe void GetMaterialxvOES(MaterialFace face, MaterialParameter pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetMaterialxvOES(face, pname, parameters_ptr);
                }
            }
            public static unsafe void GetMaterialxvOES(MaterialFace face, MaterialParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetMaterialxvOES(face, pname, parameters_ptr);
                }
            }
            public static unsafe void GetMaterialxvOES(MaterialFace face, MaterialParameter pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetMaterialxvOES(face, pname, parameters_ptr);
                }
            }
            public static unsafe void SampleCoveragexOES(int value, bool invert)
            {
                byte invert_byte = (byte)(invert ? 1 : 0);
                SampleCoveragexOES(value, invert_byte);
            }
            public static unsafe void BitmapxOES(int width, int height, int xorig, int yorig, int xmove, int ymove, ReadOnlySpan<byte> bitmap)
            {
                fixed (byte* bitmap_ptr = bitmap)
                {
                    BitmapxOES(width, height, xorig, yorig, xmove, ymove, bitmap_ptr);
                }
            }
            public static unsafe void BitmapxOES(int width, int height, int xorig, int yorig, int xmove, int ymove, byte[] bitmap)
            {
                fixed (byte* bitmap_ptr = bitmap)
                {
                    BitmapxOES(width, height, xorig, yorig, xmove, ymove, bitmap_ptr);
                }
            }
            public static unsafe void BitmapxOES(int width, int height, int xorig, int yorig, int xmove, int ymove, in byte bitmap)
            {
                fixed (byte* bitmap_ptr = &bitmap)
                {
                    BitmapxOES(width, height, xorig, yorig, xmove, ymove, bitmap_ptr);
                }
            }
            public static unsafe void Color3xvOES(ReadOnlySpan<int> components)
            {
                fixed (int* components_ptr = components)
                {
                    Color3xvOES(components_ptr);
                }
            }
            public static unsafe void Color3xvOES(int[] components)
            {
                fixed (int* components_ptr = components)
                {
                    Color3xvOES(components_ptr);
                }
            }
            public static unsafe void Color3xvOES(in int components)
            {
                fixed (int* components_ptr = &components)
                {
                    Color3xvOES(components_ptr);
                }
            }
            public static unsafe void Color4xvOES(ReadOnlySpan<int> components)
            {
                fixed (int* components_ptr = components)
                {
                    Color4xvOES(components_ptr);
                }
            }
            public static unsafe void Color4xvOES(int[] components)
            {
                fixed (int* components_ptr = components)
                {
                    Color4xvOES(components_ptr);
                }
            }
            public static unsafe void Color4xvOES(in int components)
            {
                fixed (int* components_ptr = &components)
                {
                    Color4xvOES(components_ptr);
                }
            }
            public static unsafe void ConvolutionParameterxvOES(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, ReadOnlySpan<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    ConvolutionParameterxvOES(target, pname, parameters_ptr);
                }
            }
            public static unsafe void ConvolutionParameterxvOES(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    ConvolutionParameterxvOES(target, pname, parameters_ptr);
                }
            }
            public static unsafe void ConvolutionParameterxvOES(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, in int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    ConvolutionParameterxvOES(target, pname, parameters_ptr);
                }
            }
            public static unsafe void EvalCoord1xvOES(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    EvalCoord1xvOES(coords_ptr);
                }
            }
            public static unsafe void EvalCoord1xvOES(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    EvalCoord1xvOES(coords_ptr);
                }
            }
            public static unsafe void EvalCoord1xvOES(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    EvalCoord1xvOES(coords_ptr);
                }
            }
            public static unsafe void EvalCoord2xvOES(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    EvalCoord2xvOES(coords_ptr);
                }
            }
            public static unsafe void EvalCoord2xvOES(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    EvalCoord2xvOES(coords_ptr);
                }
            }
            public static unsafe void EvalCoord2xvOES(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    EvalCoord2xvOES(coords_ptr);
                }
            }
            public static unsafe void FeedbackBufferxOES(All type, ReadOnlySpan<int> buffer)
            {
                int n = (int)(buffer.Length);
                fixed (int* buffer_ptr = buffer)
                {
                    FeedbackBufferxOES(n, type, buffer_ptr);
                }
            }
            public static unsafe void FeedbackBufferxOES(All type, int[] buffer)
            {
                int n = (int)(buffer.Length);
                fixed (int* buffer_ptr = buffer)
                {
                    FeedbackBufferxOES(n, type, buffer_ptr);
                }
            }
            public static unsafe void FeedbackBufferxOES(int n, All type, in int buffer)
            {
                fixed (int* buffer_ptr = &buffer)
                {
                    FeedbackBufferxOES(n, type, buffer_ptr);
                }
            }
            public static unsafe void GetConvolutionParameterxvOES(All target, All pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetConvolutionParameterxvOES(target, pname, parameters_ptr);
                }
            }
            public static unsafe void GetConvolutionParameterxvOES(All target, All pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetConvolutionParameterxvOES(target, pname, parameters_ptr);
                }
            }
            public static unsafe void GetConvolutionParameterxvOES(All target, All pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetConvolutionParameterxvOES(target, pname, parameters_ptr);
                }
            }
            public static unsafe void GetHistogramParameterxvOES(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetHistogramParameterxvOES(target, pname, parameters_ptr);
                }
            }
            public static unsafe void GetHistogramParameterxvOES(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetHistogramParameterxvOES(target, pname, parameters_ptr);
                }
            }
            public static unsafe void GetHistogramParameterxvOES(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetHistogramParameterxvOES(target, pname, parameters_ptr);
                }
            }
            public static unsafe void GetLightxOES(LightName light, LightParameter pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetLightxOES(light, pname, parameters_ptr);
                }
            }
            public static unsafe void GetLightxOES(LightName light, LightParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetLightxOES(light, pname, parameters_ptr);
                }
            }
            public static unsafe void GetLightxOES(LightName light, LightParameter pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetLightxOES(light, pname, parameters_ptr);
                }
            }
            public static unsafe void GetMapxvOES(MapTarget target, GetMapQuery query, Span<int> v)
            {
                fixed (int* v_ptr = v)
                {
                    GetMapxvOES(target, query, v_ptr);
                }
            }
            public static unsafe void GetMapxvOES(MapTarget target, GetMapQuery query, int[] v)
            {
                fixed (int* v_ptr = v)
                {
                    GetMapxvOES(target, query, v_ptr);
                }
            }
            public static unsafe void GetMapxvOES(MapTarget target, GetMapQuery query, ref int v)
            {
                fixed (int* v_ptr = &v)
                {
                    GetMapxvOES(target, query, v_ptr);
                }
            }
            public static unsafe void GetPixelMapx(PixelMap map, Span<int> values)
            {
                int size = (int)(values.Length);
                fixed (int* values_ptr = values)
                {
                    GetPixelMapxv(map, size, values_ptr);
                }
            }
            public static unsafe void GetPixelMapx(PixelMap map, int[] values)
            {
                int size = (int)(values.Length);
                fixed (int* values_ptr = values)
                {
                    GetPixelMapxv(map, size, values_ptr);
                }
            }
            public static unsafe void GetPixelMapx(PixelMap map, int size, ref int values)
            {
                fixed (int* values_ptr = &values)
                {
                    GetPixelMapxv(map, size, values_ptr);
                }
            }
            public static unsafe void GetTexGenxvOES(TextureCoordName coord, TextureGenParameter pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexGenxvOES(coord, pname, parameters_ptr);
                }
            }
            public static unsafe void GetTexGenxvOES(TextureCoordName coord, TextureGenParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexGenxvOES(coord, pname, parameters_ptr);
                }
            }
            public static unsafe void GetTexGenxvOES(TextureCoordName coord, TextureGenParameter pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetTexGenxvOES(coord, pname, parameters_ptr);
                }
            }
            public static unsafe void GetTexLevelParameterxvOES(TextureTarget target, int level, GetTextureParameter pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexLevelParameterxvOES(target, level, pname, parameters_ptr);
                }
            }
            public static unsafe void GetTexLevelParameterxvOES(TextureTarget target, int level, GetTextureParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexLevelParameterxvOES(target, level, pname, parameters_ptr);
                }
            }
            public static unsafe void GetTexLevelParameterxvOES(TextureTarget target, int level, GetTextureParameter pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetTexLevelParameterxvOES(target, level, pname, parameters_ptr);
                }
            }
            public static unsafe void IndexxvOES(ReadOnlySpan<int> component)
            {
                fixed (int* component_ptr = component)
                {
                    IndexxvOES(component_ptr);
                }
            }
            public static unsafe void IndexxvOES(int[] component)
            {
                fixed (int* component_ptr = component)
                {
                    IndexxvOES(component_ptr);
                }
            }
            public static unsafe void IndexxvOES(in int component)
            {
                fixed (int* component_ptr = &component)
                {
                    IndexxvOES(component_ptr);
                }
            }
            public static unsafe void LoadTransposeMatrixxOES(ReadOnlySpan<int> m)
            {
                fixed (int* m_ptr = m)
                {
                    LoadTransposeMatrixxOES(m_ptr);
                }
            }
            public static unsafe void LoadTransposeMatrixxOES(int[] m)
            {
                fixed (int* m_ptr = m)
                {
                    LoadTransposeMatrixxOES(m_ptr);
                }
            }
            public static unsafe void LoadTransposeMatrixxOES(in int m)
            {
                fixed (int* m_ptr = &m)
                {
                    LoadTransposeMatrixxOES(m_ptr);
                }
            }
            public static unsafe void MultTransposeMatrixxOES(ReadOnlySpan<int> m)
            {
                fixed (int* m_ptr = m)
                {
                    MultTransposeMatrixxOES(m_ptr);
                }
            }
            public static unsafe void MultTransposeMatrixxOES(int[] m)
            {
                fixed (int* m_ptr = m)
                {
                    MultTransposeMatrixxOES(m_ptr);
                }
            }
            public static unsafe void MultTransposeMatrixxOES(in int m)
            {
                fixed (int* m_ptr = &m)
                {
                    MultTransposeMatrixxOES(m_ptr);
                }
            }
            public static unsafe void MultiTexCoord1xvOES(TextureUnit texture, ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    MultiTexCoord1xvOES(texture, coords_ptr);
                }
            }
            public static unsafe void MultiTexCoord1xvOES(TextureUnit texture, int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    MultiTexCoord1xvOES(texture, coords_ptr);
                }
            }
            public static unsafe void MultiTexCoord1xvOES(TextureUnit texture, in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    MultiTexCoord1xvOES(texture, coords_ptr);
                }
            }
            public static unsafe void MultiTexCoord2xvOES(TextureUnit texture, ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    MultiTexCoord2xvOES(texture, coords_ptr);
                }
            }
            public static unsafe void MultiTexCoord2xvOES(TextureUnit texture, int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    MultiTexCoord2xvOES(texture, coords_ptr);
                }
            }
            public static unsafe void MultiTexCoord2xvOES(TextureUnit texture, in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    MultiTexCoord2xvOES(texture, coords_ptr);
                }
            }
            public static unsafe void MultiTexCoord3xvOES(TextureUnit texture, ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    MultiTexCoord3xvOES(texture, coords_ptr);
                }
            }
            public static unsafe void MultiTexCoord3xvOES(TextureUnit texture, int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    MultiTexCoord3xvOES(texture, coords_ptr);
                }
            }
            public static unsafe void MultiTexCoord3xvOES(TextureUnit texture, in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    MultiTexCoord3xvOES(texture, coords_ptr);
                }
            }
            public static unsafe void MultiTexCoord4xvOES(TextureUnit texture, ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    MultiTexCoord4xvOES(texture, coords_ptr);
                }
            }
            public static unsafe void MultiTexCoord4xvOES(TextureUnit texture, int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    MultiTexCoord4xvOES(texture, coords_ptr);
                }
            }
            public static unsafe void MultiTexCoord4xvOES(TextureUnit texture, in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    MultiTexCoord4xvOES(texture, coords_ptr);
                }
            }
            public static unsafe void Normal3xvOES(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    Normal3xvOES(coords_ptr);
                }
            }
            public static unsafe void Normal3xvOES(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    Normal3xvOES(coords_ptr);
                }
            }
            public static unsafe void Normal3xvOES(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    Normal3xvOES(coords_ptr);
                }
            }
            public static unsafe void PixelMapx(PixelMap map, ReadOnlySpan<int> values)
            {
                int size = (int)(values.Length);
                fixed (int* values_ptr = values)
                {
                    PixelMapx(map, size, values_ptr);
                }
            }
            public static unsafe void PixelMapx(PixelMap map, int[] values)
            {
                int size = (int)(values.Length);
                fixed (int* values_ptr = values)
                {
                    PixelMapx(map, size, values_ptr);
                }
            }
            public static unsafe void PixelMapx(PixelMap map, int size, in int values)
            {
                fixed (int* values_ptr = &values)
                {
                    PixelMapx(map, size, values_ptr);
                }
            }
            public static unsafe void PrioritizeTexturesxOES(int n, ReadOnlySpan<TextureHandle> textures, ReadOnlySpan<int> priorities)
            {
                fixed (TextureHandle* textures_ptr = textures)
                {
                    fixed (int* priorities_ptr = priorities)
                    {
                        PrioritizeTexturesxOES(n, textures_ptr, priorities_ptr);
                    }
                }
            }
            public static unsafe void PrioritizeTexturesxOES(int n, TextureHandle[] textures, int[] priorities)
            {
                fixed (TextureHandle* textures_ptr = textures)
                {
                    fixed (int* priorities_ptr = priorities)
                    {
                        PrioritizeTexturesxOES(n, textures_ptr, priorities_ptr);
                    }
                }
            }
            public static unsafe void PrioritizeTexturesxOES(int n, in TextureHandle textures, in int priorities)
            {
                fixed (TextureHandle* textures_ptr = &textures)
                fixed (int* priorities_ptr = &priorities)
                {
                    PrioritizeTexturesxOES(n, textures_ptr, priorities_ptr);
                }
            }
            public static unsafe void RasterPos2xvOES(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    RasterPos2xvOES(coords_ptr);
                }
            }
            public static unsafe void RasterPos2xvOES(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    RasterPos2xvOES(coords_ptr);
                }
            }
            public static unsafe void RasterPos2xvOES(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    RasterPos2xvOES(coords_ptr);
                }
            }
            public static unsafe void RasterPos3xvOES(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    RasterPos3xvOES(coords_ptr);
                }
            }
            public static unsafe void RasterPos3xvOES(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    RasterPos3xvOES(coords_ptr);
                }
            }
            public static unsafe void RasterPos3xvOES(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    RasterPos3xvOES(coords_ptr);
                }
            }
            public static unsafe void RasterPos4xvOES(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    RasterPos4xvOES(coords_ptr);
                }
            }
            public static unsafe void RasterPos4xvOES(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    RasterPos4xvOES(coords_ptr);
                }
            }
            public static unsafe void RasterPos4xvOES(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    RasterPos4xvOES(coords_ptr);
                }
            }
            public static unsafe void RectxvOES(ReadOnlySpan<int> v1, ReadOnlySpan<int> v2)
            {
                fixed (int* v1_ptr = v1)
                {
                    fixed (int* v2_ptr = v2)
                    {
                        RectxvOES(v1_ptr, v2_ptr);
                    }
                }
            }
            public static unsafe void RectxvOES(int[] v1, int[] v2)
            {
                fixed (int* v1_ptr = v1)
                {
                    fixed (int* v2_ptr = v2)
                    {
                        RectxvOES(v1_ptr, v2_ptr);
                    }
                }
            }
            public static unsafe void RectxvOES(in int v1, in int v2)
            {
                fixed (int* v1_ptr = &v1)
                fixed (int* v2_ptr = &v2)
                {
                    RectxvOES(v1_ptr, v2_ptr);
                }
            }
            public static unsafe void TexCoord1xvOES(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    TexCoord1xvOES(coords_ptr);
                }
            }
            public static unsafe void TexCoord1xvOES(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    TexCoord1xvOES(coords_ptr);
                }
            }
            public static unsafe void TexCoord1xvOES(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    TexCoord1xvOES(coords_ptr);
                }
            }
            public static unsafe void TexCoord2xvOES(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    TexCoord2xvOES(coords_ptr);
                }
            }
            public static unsafe void TexCoord2xvOES(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    TexCoord2xvOES(coords_ptr);
                }
            }
            public static unsafe void TexCoord2xvOES(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    TexCoord2xvOES(coords_ptr);
                }
            }
            public static unsafe void TexCoord3xvOES(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    TexCoord3xvOES(coords_ptr);
                }
            }
            public static unsafe void TexCoord3xvOES(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    TexCoord3xvOES(coords_ptr);
                }
            }
            public static unsafe void TexCoord3xvOES(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    TexCoord3xvOES(coords_ptr);
                }
            }
            public static unsafe void TexCoord4xvOES(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    TexCoord4xvOES(coords_ptr);
                }
            }
            public static unsafe void TexCoord4xvOES(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    TexCoord4xvOES(coords_ptr);
                }
            }
            public static unsafe void TexCoord4xvOES(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    TexCoord4xvOES(coords_ptr);
                }
            }
            public static unsafe void TexGenxvOES(TextureCoordName coord, TextureGenParameter pname, ReadOnlySpan<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    TexGenxvOES(coord, pname, parameters_ptr);
                }
            }
            public static unsafe void TexGenxvOES(TextureCoordName coord, TextureGenParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    TexGenxvOES(coord, pname, parameters_ptr);
                }
            }
            public static unsafe void TexGenxvOES(TextureCoordName coord, TextureGenParameter pname, in int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    TexGenxvOES(coord, pname, parameters_ptr);
                }
            }
            public static unsafe void Vertex2xvOES(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    Vertex2xvOES(coords_ptr);
                }
            }
            public static unsafe void Vertex2xvOES(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    Vertex2xvOES(coords_ptr);
                }
            }
            public static unsafe void Vertex2xvOES(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    Vertex2xvOES(coords_ptr);
                }
            }
            public static unsafe void Vertex3xvOES(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    Vertex3xvOES(coords_ptr);
                }
            }
            public static unsafe void Vertex3xvOES(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    Vertex3xvOES(coords_ptr);
                }
            }
            public static unsafe void Vertex3xvOES(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    Vertex3xvOES(coords_ptr);
                }
            }
            public static unsafe void Vertex4xvOES(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    Vertex4xvOES(coords_ptr);
                }
            }
            public static unsafe void Vertex4xvOES(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    Vertex4xvOES(coords_ptr);
                }
            }
            public static unsafe void Vertex4xvOES(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    Vertex4xvOES(coords_ptr);
                }
            }
            public static unsafe void DeleteRenderbuffersOES(ReadOnlySpan<RenderbufferHandle> renderbuffers)
            {
                int n = (int)(renderbuffers.Length);
                fixed (RenderbufferHandle* renderbuffers_ptr = renderbuffers)
                {
                    DeleteRenderbuffersOES(n, renderbuffers_ptr);
                }
            }
            public static unsafe void DeleteRenderbuffersOES(RenderbufferHandle[] renderbuffers)
            {
                int n = (int)(renderbuffers.Length);
                fixed (RenderbufferHandle* renderbuffers_ptr = renderbuffers)
                {
                    DeleteRenderbuffersOES(n, renderbuffers_ptr);
                }
            }
            public static unsafe void DeleteRenderbuffersOES(int n, in RenderbufferHandle renderbuffers)
            {
                fixed (RenderbufferHandle* renderbuffers_ptr = &renderbuffers)
                {
                    DeleteRenderbuffersOES(n, renderbuffers_ptr);
                }
            }
            public static unsafe void GenRenderbuffersOES(Span<RenderbufferHandle> renderbuffers)
            {
                int n = (int)(renderbuffers.Length);
                fixed (RenderbufferHandle* renderbuffers_ptr = renderbuffers)
                {
                    GenRenderbuffersOES(n, renderbuffers_ptr);
                }
            }
            public static unsafe void GenRenderbuffersOES(RenderbufferHandle[] renderbuffers)
            {
                int n = (int)(renderbuffers.Length);
                fixed (RenderbufferHandle* renderbuffers_ptr = renderbuffers)
                {
                    GenRenderbuffersOES(n, renderbuffers_ptr);
                }
            }
            public static unsafe void GenRenderbuffersOES(int n, ref RenderbufferHandle renderbuffers)
            {
                fixed (RenderbufferHandle* renderbuffers_ptr = &renderbuffers)
                {
                    GenRenderbuffersOES(n, renderbuffers_ptr);
                }
            }
            public static unsafe void GetRenderbufferParameterivOES(RenderbufferTarget target, RenderbufferParameterName pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetRenderbufferParameterivOES(target, pname, parameters_ptr);
                }
            }
            public static unsafe void GetRenderbufferParameterivOES(RenderbufferTarget target, RenderbufferParameterName pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetRenderbufferParameterivOES(target, pname, parameters_ptr);
                }
            }
            public static unsafe void GetRenderbufferParameterivOES(RenderbufferTarget target, RenderbufferParameterName pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetRenderbufferParameterivOES(target, pname, parameters_ptr);
                }
            }
            public static unsafe void DeleteFramebuffersOES(ReadOnlySpan<FramebufferHandle> framebuffers)
            {
                int n = (int)(framebuffers.Length);
                fixed (FramebufferHandle* framebuffers_ptr = framebuffers)
                {
                    DeleteFramebuffersOES(n, framebuffers_ptr);
                }
            }
            public static unsafe void DeleteFramebuffersOES(FramebufferHandle[] framebuffers)
            {
                int n = (int)(framebuffers.Length);
                fixed (FramebufferHandle* framebuffers_ptr = framebuffers)
                {
                    DeleteFramebuffersOES(n, framebuffers_ptr);
                }
            }
            public static unsafe void DeleteFramebuffersOES(int n, in FramebufferHandle framebuffers)
            {
                fixed (FramebufferHandle* framebuffers_ptr = &framebuffers)
                {
                    DeleteFramebuffersOES(n, framebuffers_ptr);
                }
            }
            public static unsafe void GenFramebuffersOES(Span<FramebufferHandle> framebuffers)
            {
                int n = (int)(framebuffers.Length);
                fixed (FramebufferHandle* framebuffers_ptr = framebuffers)
                {
                    GenFramebuffersOES(n, framebuffers_ptr);
                }
            }
            public static unsafe void GenFramebuffersOES(FramebufferHandle[] framebuffers)
            {
                int n = (int)(framebuffers.Length);
                fixed (FramebufferHandle* framebuffers_ptr = framebuffers)
                {
                    GenFramebuffersOES(n, framebuffers_ptr);
                }
            }
            public static unsafe void GenFramebuffersOES(int n, ref FramebufferHandle framebuffers)
            {
                fixed (FramebufferHandle* framebuffers_ptr = &framebuffers)
                {
                    GenFramebuffersOES(n, framebuffers_ptr);
                }
            }
            public static unsafe void GetFramebufferAttachmentParameterivOES(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetFramebufferAttachmentParameterivOES(target, attachment, pname, parameters_ptr);
                }
            }
            public static unsafe void GetFramebufferAttachmentParameterivOES(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetFramebufferAttachmentParameterivOES(target, attachment, pname, parameters_ptr);
                }
            }
            public static unsafe void GetFramebufferAttachmentParameterivOES(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetFramebufferAttachmentParameterivOES(target, attachment, pname, parameters_ptr);
                }
            }
            /// <summary> Define an array of matrix indices. </summary>
            /// <param name="size"> Specifies the number of matrix indices per vertex. Must be is less than or equal to GL_MAX_VERTEX_UNITS_OES. The initial value is 0. </param>
            /// <param name="type"> Specifies the data type of each matrix index in the array. Symbolic constant GL_UNSIGNED_BYTE is accepted. The initial value is GL_UNSIGNED_BYTE. </param>
            /// <param name="stride"> Specifies the byte offset between consecutive matrix indices. If stride is 0, the matrix indices are understood to be tightly packed in the array. The initial value is 0. </param>
            /// <param name="pointer"> Specifies a pointer to the first matrix index of the first vertex in the array. The initial value is 0. </param>
            public static unsafe void MatrixIndexPointerOES(int size, MatrixIndexPointerTypeARB type, int stride, IntPtr pointer)
            {
                void* pointer_vptr = (void*)pointer;
                MatrixIndexPointerOES(size, type, stride, pointer_vptr);
            }
            /// <summary> Define an array of matrix indices. </summary>
            /// <param name="size"> Specifies the number of matrix indices per vertex. Must be is less than or equal to GL_MAX_VERTEX_UNITS_OES. The initial value is 0. </param>
            /// <param name="type"> Specifies the data type of each matrix index in the array. Symbolic constant GL_UNSIGNED_BYTE is accepted. The initial value is GL_UNSIGNED_BYTE. </param>
            /// <param name="stride"> Specifies the byte offset between consecutive matrix indices. If stride is 0, the matrix indices are understood to be tightly packed in the array. The initial value is 0. </param>
            /// <param name="pointer"> Specifies a pointer to the first matrix index of the first vertex in the array. The initial value is 0. </param>
            public static unsafe void MatrixIndexPointerOES<T1>(int size, MatrixIndexPointerTypeARB type, int stride, ReadOnlySpan<T1> pointer)
                where T1 : unmanaged
            {
                fixed (void* pointer_ptr = pointer)
                {
                    MatrixIndexPointerOES(size, type, stride, pointer_ptr);
                }
            }
            /// <summary> Define an array of matrix indices. </summary>
            /// <param name="size"> Specifies the number of matrix indices per vertex. Must be is less than or equal to GL_MAX_VERTEX_UNITS_OES. The initial value is 0. </param>
            /// <param name="type"> Specifies the data type of each matrix index in the array. Symbolic constant GL_UNSIGNED_BYTE is accepted. The initial value is GL_UNSIGNED_BYTE. </param>
            /// <param name="stride"> Specifies the byte offset between consecutive matrix indices. If stride is 0, the matrix indices are understood to be tightly packed in the array. The initial value is 0. </param>
            /// <param name="pointer"> Specifies a pointer to the first matrix index of the first vertex in the array. The initial value is 0. </param>
            public static unsafe void MatrixIndexPointerOES<T1>(int size, MatrixIndexPointerTypeARB type, int stride, T1[] pointer)
                where T1 : unmanaged
            {
                fixed (void* pointer_ptr = pointer)
                {
                    MatrixIndexPointerOES(size, type, stride, pointer_ptr);
                }
            }
            /// <summary> Define an array of matrix indices. </summary>
            /// <param name="size"> Specifies the number of matrix indices per vertex. Must be is less than or equal to GL_MAX_VERTEX_UNITS_OES. The initial value is 0. </param>
            /// <param name="type"> Specifies the data type of each matrix index in the array. Symbolic constant GL_UNSIGNED_BYTE is accepted. The initial value is GL_UNSIGNED_BYTE. </param>
            /// <param name="stride"> Specifies the byte offset between consecutive matrix indices. If stride is 0, the matrix indices are understood to be tightly packed in the array. The initial value is 0. </param>
            /// <param name="pointer"> Specifies a pointer to the first matrix index of the first vertex in the array. The initial value is 0. </param>
            public static unsafe void MatrixIndexPointerOES<T1>(int size, MatrixIndexPointerTypeARB type, int stride, in T1 pointer)
                where T1 : unmanaged
            {
                fixed (void* pointer_ptr = &pointer)
                {
                    MatrixIndexPointerOES(size, type, stride, pointer_ptr);
                }
            }
            /// <summary> Define an array of weights. </summary>
            /// <param name="size"> Specifies the number of weights per vertex. Must be is less than or equal to GL_MAX_VERTEX_UNITS_OES. The initial value is 0. </param>
            /// <param name="type"> Specifies the data type of each weight in the array. Symbolic constant GL_FIXED is accepted. However, the common profile also accepts the symbolic constant GL_FLOAT as well. The initial value is GL_FIXED for the common lite profile, or GL_FLOAT for the common profile. </param>
            /// <param name="stride"> Specifies the byte offset between consecutive weights. If stride is 0, the weights are understood to be tightly packed in the array. The initial value is 0. </param>
            /// <param name="pointer"> Specifies a pointer to the first weight of the first vertex in the array. The initial value is 0. </param>
            public static unsafe void WeightPointerOES(int size, All type, int stride, IntPtr pointer)
            {
                void* pointer_vptr = (void*)pointer;
                WeightPointerOES(size, type, stride, pointer_vptr);
            }
            /// <summary> Define an array of weights. </summary>
            /// <param name="size"> Specifies the number of weights per vertex. Must be is less than or equal to GL_MAX_VERTEX_UNITS_OES. The initial value is 0. </param>
            /// <param name="type"> Specifies the data type of each weight in the array. Symbolic constant GL_FIXED is accepted. However, the common profile also accepts the symbolic constant GL_FLOAT as well. The initial value is GL_FIXED for the common lite profile, or GL_FLOAT for the common profile. </param>
            /// <param name="stride"> Specifies the byte offset between consecutive weights. If stride is 0, the weights are understood to be tightly packed in the array. The initial value is 0. </param>
            /// <param name="pointer"> Specifies a pointer to the first weight of the first vertex in the array. The initial value is 0. </param>
            public static unsafe void WeightPointerOES<T1>(int size, All type, int stride, ReadOnlySpan<T1> pointer)
                where T1 : unmanaged
            {
                fixed (void* pointer_ptr = pointer)
                {
                    WeightPointerOES(size, type, stride, pointer_ptr);
                }
            }
            /// <summary> Define an array of weights. </summary>
            /// <param name="size"> Specifies the number of weights per vertex. Must be is less than or equal to GL_MAX_VERTEX_UNITS_OES. The initial value is 0. </param>
            /// <param name="type"> Specifies the data type of each weight in the array. Symbolic constant GL_FIXED is accepted. However, the common profile also accepts the symbolic constant GL_FLOAT as well. The initial value is GL_FIXED for the common lite profile, or GL_FLOAT for the common profile. </param>
            /// <param name="stride"> Specifies the byte offset between consecutive weights. If stride is 0, the weights are understood to be tightly packed in the array. The initial value is 0. </param>
            /// <param name="pointer"> Specifies a pointer to the first weight of the first vertex in the array. The initial value is 0. </param>
            public static unsafe void WeightPointerOES<T1>(int size, All type, int stride, T1[] pointer)
                where T1 : unmanaged
            {
                fixed (void* pointer_ptr = pointer)
                {
                    WeightPointerOES(size, type, stride, pointer_ptr);
                }
            }
            /// <summary> Define an array of weights. </summary>
            /// <param name="size"> Specifies the number of weights per vertex. Must be is less than or equal to GL_MAX_VERTEX_UNITS_OES. The initial value is 0. </param>
            /// <param name="type"> Specifies the data type of each weight in the array. Symbolic constant GL_FIXED is accepted. However, the common profile also accepts the symbolic constant GL_FLOAT as well. The initial value is GL_FIXED for the common lite profile, or GL_FLOAT for the common profile. </param>
            /// <param name="stride"> Specifies the byte offset between consecutive weights. If stride is 0, the weights are understood to be tightly packed in the array. The initial value is 0. </param>
            /// <param name="pointer"> Specifies a pointer to the first weight of the first vertex in the array. The initial value is 0. </param>
            public static unsafe void WeightPointerOES<T1>(int size, All type, int stride, in T1 pointer)
                where T1 : unmanaged
            {
                fixed (void* pointer_ptr = &pointer)
                {
                    WeightPointerOES(size, type, stride, pointer_ptr);
                }
            }
            /// <summary> Define an array of point sizes. </summary>
            /// <param name="type"> Specifies the data type of each point size in the array. Symbolic constant GL_FIXED is accepted. However, the common profile also accepts the symbolic constant GL_FLOAT. The initial value is GL_FIXED for the common lite profile, or GL_FLOAT for the common profile. </param>
            /// <param name="stride"> Specifies the byte offset between consecutive point sizes. If stride is 0, the point sizes are understood to be tightly packed in the array. The initial value is 0. </param>
            /// <param name="pointer"> Specifies a pointer to the point size of the first vertex in the array. The initial value is 0. </param>
            public static unsafe void PointSizePointerOES(All type, int stride, IntPtr pointer)
            {
                void* pointer_vptr = (void*)pointer;
                PointSizePointerOES(type, stride, pointer_vptr);
            }
            /// <summary> Define an array of point sizes. </summary>
            /// <param name="type"> Specifies the data type of each point size in the array. Symbolic constant GL_FIXED is accepted. However, the common profile also accepts the symbolic constant GL_FLOAT. The initial value is GL_FIXED for the common lite profile, or GL_FLOAT for the common profile. </param>
            /// <param name="stride"> Specifies the byte offset between consecutive point sizes. If stride is 0, the point sizes are understood to be tightly packed in the array. The initial value is 0. </param>
            /// <param name="pointer"> Specifies a pointer to the point size of the first vertex in the array. The initial value is 0. </param>
            public static unsafe void PointSizePointerOES<T1>(All type, int stride, ReadOnlySpan<T1> pointer)
                where T1 : unmanaged
            {
                fixed (void* pointer_ptr = pointer)
                {
                    PointSizePointerOES(type, stride, pointer_ptr);
                }
            }
            /// <summary> Define an array of point sizes. </summary>
            /// <param name="type"> Specifies the data type of each point size in the array. Symbolic constant GL_FIXED is accepted. However, the common profile also accepts the symbolic constant GL_FLOAT. The initial value is GL_FIXED for the common lite profile, or GL_FLOAT for the common profile. </param>
            /// <param name="stride"> Specifies the byte offset between consecutive point sizes. If stride is 0, the point sizes are understood to be tightly packed in the array. The initial value is 0. </param>
            /// <param name="pointer"> Specifies a pointer to the point size of the first vertex in the array. The initial value is 0. </param>
            public static unsafe void PointSizePointerOES<T1>(All type, int stride, T1[] pointer)
                where T1 : unmanaged
            {
                fixed (void* pointer_ptr = pointer)
                {
                    PointSizePointerOES(type, stride, pointer_ptr);
                }
            }
            /// <summary> Define an array of point sizes. </summary>
            /// <param name="type"> Specifies the data type of each point size in the array. Symbolic constant GL_FIXED is accepted. However, the common profile also accepts the symbolic constant GL_FLOAT. The initial value is GL_FIXED for the common lite profile, or GL_FLOAT for the common profile. </param>
            /// <param name="stride"> Specifies the byte offset between consecutive point sizes. If stride is 0, the point sizes are understood to be tightly packed in the array. The initial value is 0. </param>
            /// <param name="pointer"> Specifies a pointer to the point size of the first vertex in the array. The initial value is 0. </param>
            public static unsafe void PointSizePointerOES<T1>(All type, int stride, in T1 pointer)
                where T1 : unmanaged
            {
                fixed (void* pointer_ptr = &pointer)
                {
                    PointSizePointerOES(type, stride, pointer_ptr);
                }
            }
            /// <summary> Return the values of the current matrix. </summary>
            /// <param name="mantissa">Returns the mantissa values of the current matrix.</param>
            /// <param name="exponent">Returns the exponents of the current matrix.</param>
            public static unsafe All QueryMatrixxOES(Span<int> mantissa, Span<int> exponent)
            {
                All returnValue;
                fixed (int* mantissa_ptr = mantissa)
                {
                    fixed (int* exponent_ptr = exponent)
                    {
                        returnValue = QueryMatrixxOES(mantissa_ptr, exponent_ptr);
                    }
                }
                return returnValue;
            }
            /// <summary> Return the values of the current matrix. </summary>
            /// <param name="mantissa">Returns the mantissa values of the current matrix.</param>
            /// <param name="exponent">Returns the exponents of the current matrix.</param>
            public static unsafe All QueryMatrixxOES(int[] mantissa, int[] exponent)
            {
                All returnValue;
                fixed (int* mantissa_ptr = mantissa)
                {
                    fixed (int* exponent_ptr = exponent)
                    {
                        returnValue = QueryMatrixxOES(mantissa_ptr, exponent_ptr);
                    }
                }
                return returnValue;
            }
            /// <summary> Return the values of the current matrix. </summary>
            /// <param name="mantissa">Returns the mantissa values of the current matrix.</param>
            /// <param name="exponent">Returns the exponents of the current matrix.</param>
            public static unsafe All QueryMatrixxOES(ref int mantissa, ref int exponent)
            {
                All returnValue;
                fixed (int* mantissa_ptr = &mantissa)
                fixed (int* exponent_ptr = &exponent)
                {
                    returnValue = QueryMatrixxOES(mantissa_ptr, exponent_ptr);
                }
                return returnValue;
            }
            public static unsafe void ClipPlanefOES(ClipPlaneName plane, ReadOnlySpan<float> equation)
            {
                fixed (float* equation_ptr = equation)
                {
                    ClipPlanefOES(plane, equation_ptr);
                }
            }
            public static unsafe void ClipPlanefOES(ClipPlaneName plane, float[] equation)
            {
                fixed (float* equation_ptr = equation)
                {
                    ClipPlanefOES(plane, equation_ptr);
                }
            }
            public static unsafe void ClipPlanefOES(ClipPlaneName plane, in float equation)
            {
                fixed (float* equation_ptr = &equation)
                {
                    ClipPlanefOES(plane, equation_ptr);
                }
            }
            public static unsafe void GetClipPlanefOES(ClipPlaneName plane, Span<float> equation)
            {
                fixed (float* equation_ptr = equation)
                {
                    GetClipPlanefOES(plane, equation_ptr);
                }
            }
            public static unsafe void GetClipPlanefOES(ClipPlaneName plane, float[] equation)
            {
                fixed (float* equation_ptr = equation)
                {
                    GetClipPlanefOES(plane, equation_ptr);
                }
            }
            public static unsafe void GetClipPlanefOES(ClipPlaneName plane, ref float equation)
            {
                fixed (float* equation_ptr = &equation)
                {
                    GetClipPlanefOES(plane, equation_ptr);
                }
            }
            public static unsafe void TexGenfvOES(TextureCoordName coord, TextureGenParameter pname, ReadOnlySpan<float> parameters)
            {
                fixed (float* parameters_ptr = parameters)
                {
                    TexGenfvOES(coord, pname, parameters_ptr);
                }
            }
            public static unsafe void TexGenfvOES(TextureCoordName coord, TextureGenParameter pname, float[] parameters)
            {
                fixed (float* parameters_ptr = parameters)
                {
                    TexGenfvOES(coord, pname, parameters_ptr);
                }
            }
            public static unsafe void TexGenfvOES(TextureCoordName coord, TextureGenParameter pname, in float parameters)
            {
                fixed (float* parameters_ptr = &parameters)
                {
                    TexGenfvOES(coord, pname, parameters_ptr);
                }
            }
            public static unsafe void TexGenivOES(TextureCoordName coord, TextureGenParameter pname, ReadOnlySpan<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    TexGenivOES(coord, pname, parameters_ptr);
                }
            }
            public static unsafe void TexGenivOES(TextureCoordName coord, TextureGenParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    TexGenivOES(coord, pname, parameters_ptr);
                }
            }
            public static unsafe void TexGenivOES(TextureCoordName coord, TextureGenParameter pname, in int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    TexGenivOES(coord, pname, parameters_ptr);
                }
            }
            public static unsafe void GetTexGenfvOES(TextureCoordName coord, TextureGenParameter pname, Span<float> parameters)
            {
                fixed (float* parameters_ptr = parameters)
                {
                    GetTexGenfvOES(coord, pname, parameters_ptr);
                }
            }
            public static unsafe void GetTexGenfvOES(TextureCoordName coord, TextureGenParameter pname, float[] parameters)
            {
                fixed (float* parameters_ptr = parameters)
                {
                    GetTexGenfvOES(coord, pname, parameters_ptr);
                }
            }
            public static unsafe void GetTexGenfvOES(TextureCoordName coord, TextureGenParameter pname, ref float parameters)
            {
                fixed (float* parameters_ptr = &parameters)
                {
                    GetTexGenfvOES(coord, pname, parameters_ptr);
                }
            }
            public static unsafe void GetTexGenivOES(TextureCoordName coord, TextureGenParameter pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexGenivOES(coord, pname, parameters_ptr);
                }
            }
            public static unsafe void GetTexGenivOES(TextureCoordName coord, TextureGenParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexGenivOES(coord, pname, parameters_ptr);
                }
            }
            public static unsafe void GetTexGenivOES(TextureCoordName coord, TextureGenParameter pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetTexGenivOES(coord, pname, parameters_ptr);
                }
            }
            public static unsafe void DeleteVertexArraysOES(ReadOnlySpan<VertexArrayHandle> arrays)
            {
                int n = (int)(arrays.Length);
                fixed (VertexArrayHandle* arrays_ptr = arrays)
                {
                    DeleteVertexArraysOES(n, arrays_ptr);
                }
            }
            public static unsafe void DeleteVertexArraysOES(VertexArrayHandle[] arrays)
            {
                int n = (int)(arrays.Length);
                fixed (VertexArrayHandle* arrays_ptr = arrays)
                {
                    DeleteVertexArraysOES(n, arrays_ptr);
                }
            }
            public static unsafe void DeleteVertexArraysOES(int n, in VertexArrayHandle arrays)
            {
                fixed (VertexArrayHandle* arrays_ptr = &arrays)
                {
                    DeleteVertexArraysOES(n, arrays_ptr);
                }
            }
            public static unsafe void GenVertexArraysOES(Span<VertexArrayHandle> arrays)
            {
                int n = (int)(arrays.Length);
                fixed (VertexArrayHandle* arrays_ptr = arrays)
                {
                    GenVertexArraysOES(n, arrays_ptr);
                }
            }
            public static unsafe void GenVertexArraysOES(VertexArrayHandle[] arrays)
            {
                int n = (int)(arrays.Length);
                fixed (VertexArrayHandle* arrays_ptr = arrays)
                {
                    GenVertexArraysOES(n, arrays_ptr);
                }
            }
            public static unsafe void GenVertexArraysOES(int n, ref VertexArrayHandle arrays)
            {
                fixed (VertexArrayHandle* arrays_ptr = &arrays)
                {
                    GenVertexArraysOES(n, arrays_ptr);
                }
            }
        }
        public static unsafe partial class QCOM
        {
            public static unsafe void GetDriverControlsQCOM(ref int num, Span<uint> driverControls)
            {
                fixed (int* num_ptr = &num)
                {
                    int size = (int)(driverControls.Length);
                    fixed (uint* driverControls_ptr = driverControls)
                    {
                        GetDriverControlsQCOM(num_ptr, size, driverControls_ptr);
                    }
                }
            }
            public static unsafe void GetDriverControlsQCOM(ref int num, uint[] driverControls)
            {
                fixed (int* num_ptr = &num)
                {
                    int size = (int)(driverControls.Length);
                    fixed (uint* driverControls_ptr = driverControls)
                    {
                        GetDriverControlsQCOM(num_ptr, size, driverControls_ptr);
                    }
                }
            }
            public static unsafe void GetDriverControlsQCOM(ref int num, int size, ref uint driverControls)
            {
                fixed (int* num_ptr = &num)
                fixed (uint* driverControls_ptr = &driverControls)
                {
                    GetDriverControlsQCOM(num_ptr, size, driverControls_ptr);
                }
            }
            public static unsafe string GetDriverControlStringQCOM(uint driverControl, int bufSize, ref int length)
            {
                string driverControlString;
                fixed (int* length_ptr = &length)
                {
                    var driverControlString_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetDriverControlStringQCOM(driverControl, bufSize, length_ptr, driverControlString_ptr);
                    driverControlString = Marshal.PtrToStringUTF8((IntPtr)driverControlString_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)driverControlString_ptr);
                }
                return driverControlString;
            }
            public static unsafe void GetDriverControlStringQCOM(uint driverControl, int bufSize, ref int length, out string driverControlString)
            {
                fixed (int* length_ptr = &length)
                {
                    var driverControlString_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetDriverControlStringQCOM(driverControl, bufSize, length_ptr, driverControlString_ptr);
                    driverControlString = Marshal.PtrToStringUTF8((IntPtr)driverControlString_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)driverControlString_ptr);
                }
            }
            public static unsafe void ExtGetTexturesQCOM(ref TextureHandle textures, int maxTextures, ref int numTextures)
            {
                fixed (TextureHandle* textures_ptr = &textures)
                fixed (int* numTextures_ptr = &numTextures)
                {
                    ExtGetTexturesQCOM(textures_ptr, maxTextures, numTextures_ptr);
                }
            }
            public static unsafe void ExtGetBuffersQCOM(Span<BufferHandle> buffers, Span<int> numBuffers)
            {
                int maxBuffers = (int)(buffers.Length);
                fixed (BufferHandle* buffers_ptr = buffers)
                {
                    fixed (int* numBuffers_ptr = numBuffers)
                    {
                        ExtGetBuffersQCOM(buffers_ptr, maxBuffers, numBuffers_ptr);
                    }
                }
            }
            public static unsafe void ExtGetBuffersQCOM(BufferHandle[] buffers, int[] numBuffers)
            {
                int maxBuffers = (int)(buffers.Length);
                fixed (BufferHandle* buffers_ptr = buffers)
                {
                    fixed (int* numBuffers_ptr = numBuffers)
                    {
                        ExtGetBuffersQCOM(buffers_ptr, maxBuffers, numBuffers_ptr);
                    }
                }
            }
            public static unsafe void ExtGetBuffersQCOM(ref BufferHandle buffers, int maxBuffers, ref int numBuffers)
            {
                fixed (BufferHandle* buffers_ptr = &buffers)
                fixed (int* numBuffers_ptr = &numBuffers)
                {
                    ExtGetBuffersQCOM(buffers_ptr, maxBuffers, numBuffers_ptr);
                }
            }
            public static unsafe void ExtGetRenderbuffersQCOM(Span<RenderbufferHandle> renderbuffers, Span<int> numRenderbuffers)
            {
                int maxRenderbuffers = (int)(renderbuffers.Length);
                fixed (RenderbufferHandle* renderbuffers_ptr = renderbuffers)
                {
                    fixed (int* numRenderbuffers_ptr = numRenderbuffers)
                    {
                        ExtGetRenderbuffersQCOM(renderbuffers_ptr, maxRenderbuffers, numRenderbuffers_ptr);
                    }
                }
            }
            public static unsafe void ExtGetRenderbuffersQCOM(RenderbufferHandle[] renderbuffers, int[] numRenderbuffers)
            {
                int maxRenderbuffers = (int)(renderbuffers.Length);
                fixed (RenderbufferHandle* renderbuffers_ptr = renderbuffers)
                {
                    fixed (int* numRenderbuffers_ptr = numRenderbuffers)
                    {
                        ExtGetRenderbuffersQCOM(renderbuffers_ptr, maxRenderbuffers, numRenderbuffers_ptr);
                    }
                }
            }
            public static unsafe void ExtGetRenderbuffersQCOM(ref RenderbufferHandle renderbuffers, int maxRenderbuffers, ref int numRenderbuffers)
            {
                fixed (RenderbufferHandle* renderbuffers_ptr = &renderbuffers)
                fixed (int* numRenderbuffers_ptr = &numRenderbuffers)
                {
                    ExtGetRenderbuffersQCOM(renderbuffers_ptr, maxRenderbuffers, numRenderbuffers_ptr);
                }
            }
            public static unsafe void ExtGetFramebuffersQCOM(Span<FramebufferHandle> framebuffers, Span<int> numFramebuffers)
            {
                int maxFramebuffers = (int)(framebuffers.Length);
                fixed (FramebufferHandle* framebuffers_ptr = framebuffers)
                {
                    fixed (int* numFramebuffers_ptr = numFramebuffers)
                    {
                        ExtGetFramebuffersQCOM(framebuffers_ptr, maxFramebuffers, numFramebuffers_ptr);
                    }
                }
            }
            public static unsafe void ExtGetFramebuffersQCOM(FramebufferHandle[] framebuffers, int[] numFramebuffers)
            {
                int maxFramebuffers = (int)(framebuffers.Length);
                fixed (FramebufferHandle* framebuffers_ptr = framebuffers)
                {
                    fixed (int* numFramebuffers_ptr = numFramebuffers)
                    {
                        ExtGetFramebuffersQCOM(framebuffers_ptr, maxFramebuffers, numFramebuffers_ptr);
                    }
                }
            }
            public static unsafe void ExtGetFramebuffersQCOM(ref FramebufferHandle framebuffers, int maxFramebuffers, ref int numFramebuffers)
            {
                fixed (FramebufferHandle* framebuffers_ptr = &framebuffers)
                fixed (int* numFramebuffers_ptr = &numFramebuffers)
                {
                    ExtGetFramebuffersQCOM(framebuffers_ptr, maxFramebuffers, numFramebuffers_ptr);
                }
            }
            public static unsafe void ExtGetTexLevelParameterivQCOM(TextureHandle texture, All face, int level, All pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    ExtGetTexLevelParameterivQCOM(texture, face, level, pname, parameters_ptr);
                }
            }
            public static unsafe void ExtGetTexSubImageQCOM(All target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr texels)
            {
                void* texels_vptr = (void*)texels;
                ExtGetTexSubImageQCOM(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, texels_vptr);
            }
            public static unsafe void ExtGetTexSubImageQCOM<T1>(All target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, ref T1 texels)
                where T1 : unmanaged
            {
                fixed (void* texels_ptr = &texels)
                {
                    ExtGetTexSubImageQCOM(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, texels_ptr);
                }
            }
            public static unsafe void ExtGetShadersQCOM(Span<ShaderHandle> shaders, Span<int> numShaders)
            {
                int maxShaders = (int)(shaders.Length);
                fixed (ShaderHandle* shaders_ptr = shaders)
                {
                    fixed (int* numShaders_ptr = numShaders)
                    {
                        ExtGetShadersQCOM(shaders_ptr, maxShaders, numShaders_ptr);
                    }
                }
            }
            public static unsafe void ExtGetShadersQCOM(ShaderHandle[] shaders, int[] numShaders)
            {
                int maxShaders = (int)(shaders.Length);
                fixed (ShaderHandle* shaders_ptr = shaders)
                {
                    fixed (int* numShaders_ptr = numShaders)
                    {
                        ExtGetShadersQCOM(shaders_ptr, maxShaders, numShaders_ptr);
                    }
                }
            }
            public static unsafe void ExtGetShadersQCOM(ref ShaderHandle shaders, int maxShaders, ref int numShaders)
            {
                fixed (ShaderHandle* shaders_ptr = &shaders)
                fixed (int* numShaders_ptr = &numShaders)
                {
                    ExtGetShadersQCOM(shaders_ptr, maxShaders, numShaders_ptr);
                }
            }
            public static unsafe void ExtGetProgramsQCOM(Span<ProgramHandle> programs, Span<int> numPrograms)
            {
                int maxPrograms = (int)(programs.Length);
                fixed (ProgramHandle* programs_ptr = programs)
                {
                    fixed (int* numPrograms_ptr = numPrograms)
                    {
                        ExtGetProgramsQCOM(programs_ptr, maxPrograms, numPrograms_ptr);
                    }
                }
            }
            public static unsafe void ExtGetProgramsQCOM(ProgramHandle[] programs, int[] numPrograms)
            {
                int maxPrograms = (int)(programs.Length);
                fixed (ProgramHandle* programs_ptr = programs)
                {
                    fixed (int* numPrograms_ptr = numPrograms)
                    {
                        ExtGetProgramsQCOM(programs_ptr, maxPrograms, numPrograms_ptr);
                    }
                }
            }
            public static unsafe void ExtGetProgramsQCOM(ref ProgramHandle programs, int maxPrograms, ref int numPrograms)
            {
                fixed (ProgramHandle* programs_ptr = &programs)
                fixed (int* numPrograms_ptr = &numPrograms)
                {
                    ExtGetProgramsQCOM(programs_ptr, maxPrograms, numPrograms_ptr);
                }
            }
            public static unsafe void ExtGetProgramBinarySourceQCOM(ProgramHandle program, ShaderType shadertype, byte* source, ref int length)
            {
                fixed (int* length_ptr = &length)
                {
                    ExtGetProgramBinarySourceQCOM(program, shadertype, source, length_ptr);
                }
            }
        }
    }
}
