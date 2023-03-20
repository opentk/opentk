// This file is auto generated, do not edit.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using OpenTK.Mathematics;
using OpenTK.Graphics;

namespace OpenTK.Graphics.OpenGLES1
{
#pragma warning disable CS0419 // Ambiguous reference in cref attribute
    public static unsafe partial class GL
    {
        /// <inheritdoc cref="ClipPlanef(ClipPlaneName, float*)"/>
        public static unsafe void ClipPlanef(ClipPlaneName p, ReadOnlySpan<float> eqn)
        {
            fixed (float* eqn_ptr = eqn)
            {
                ClipPlanef(p, eqn_ptr);
            }
        }
        /// <inheritdoc cref="ClipPlanef(ClipPlaneName, float*)"/>
        public static unsafe void ClipPlanef(ClipPlaneName p, float[] eqn)
        {
            fixed (float* eqn_ptr = eqn)
            {
                ClipPlanef(p, eqn_ptr);
            }
        }
        /// <inheritdoc cref="ClipPlanef(ClipPlaneName, float*)"/>
        public static unsafe void ClipPlanef(ClipPlaneName p, in float eqn)
        {
            fixed (float* eqn_ptr = &eqn)
            {
                ClipPlanef(p, eqn_ptr);
            }
        }
        /// <inheritdoc cref="Fogfv(FogParameter, float*)"/>
        public static unsafe void Fogf(FogParameter pname, ReadOnlySpan<float> parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                Fogfv(pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="Fogfv(FogParameter, float*)"/>
        public static unsafe void Fogf(FogParameter pname, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                Fogfv(pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="Fogfv(FogParameter, float*)"/>
        public static unsafe void Fogf(FogParameter pname, in float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                Fogfv(pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetClipPlanef(ClipPlaneName, float*)"/>
        public static unsafe void GetClipPlanef(ClipPlaneName plane, Span<float> equation)
        {
            fixed (float* equation_ptr = equation)
            {
                GetClipPlanef(plane, equation_ptr);
            }
        }
        /// <inheritdoc cref="GetClipPlanef(ClipPlaneName, float*)"/>
        public static unsafe void GetClipPlanef(ClipPlaneName plane, float[] equation)
        {
            fixed (float* equation_ptr = equation)
            {
                GetClipPlanef(plane, equation_ptr);
            }
        }
        /// <inheritdoc cref="GetClipPlanef(ClipPlaneName, float*)"/>
        public static unsafe void GetClipPlanef(ClipPlaneName plane, ref float equation)
        {
            fixed (float* equation_ptr = &equation)
            {
                GetClipPlanef(plane, equation_ptr);
            }
        }
        /// <inheritdoc cref="GetFloatv(GetPName, float*)"/>
        public static unsafe void GetFloat(GetPName pname, Span<float> data)
        {
            fixed (float* data_ptr = data)
            {
                GetFloatv(pname, data_ptr);
            }
        }
        /// <inheritdoc cref="GetFloatv(GetPName, float*)"/>
        public static unsafe void GetFloat(GetPName pname, float[] data)
        {
            fixed (float* data_ptr = data)
            {
                GetFloatv(pname, data_ptr);
            }
        }
        /// <inheritdoc cref="GetFloatv(GetPName, float*)"/>
        public static unsafe void GetFloat(GetPName pname, ref float data)
        {
            fixed (float* data_ptr = &data)
            {
                GetFloatv(pname, data_ptr);
            }
        }
        /// <inheritdoc cref="GetLightfv(LightName, LightParameter, float*)"/>
        public static unsafe void GetLightf(LightName light, LightParameter pname, Span<float> parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetLightfv(light, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetLightfv(LightName, LightParameter, float*)"/>
        public static unsafe void GetLightf(LightName light, LightParameter pname, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetLightfv(light, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetLightfv(LightName, LightParameter, float*)"/>
        public static unsafe void GetLightf(LightName light, LightParameter pname, ref float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                GetLightfv(light, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetMaterialfv(TriangleFace, MaterialParameter, float*)"/>
        public static unsafe void GetMaterialf(TriangleFace face, MaterialParameter pname, Span<float> parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetMaterialfv(face, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetMaterialfv(TriangleFace, MaterialParameter, float*)"/>
        public static unsafe void GetMaterialf(TriangleFace face, MaterialParameter pname, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetMaterialfv(face, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetMaterialfv(TriangleFace, MaterialParameter, float*)"/>
        public static unsafe void GetMaterialf(TriangleFace face, MaterialParameter pname, ref float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                GetMaterialfv(face, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexEnvfv(TextureEnvTarget, TextureEnvParameter, float*)"/>
        public static unsafe void GetTexEnvf(TextureEnvTarget target, TextureEnvParameter pname, Span<float> parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetTexEnvfv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexEnvfv(TextureEnvTarget, TextureEnvParameter, float*)"/>
        public static unsafe void GetTexEnvf(TextureEnvTarget target, TextureEnvParameter pname, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetTexEnvfv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexEnvfv(TextureEnvTarget, TextureEnvParameter, float*)"/>
        public static unsafe void GetTexEnvf(TextureEnvTarget target, TextureEnvParameter pname, ref float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                GetTexEnvfv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexParameterfv(TextureTarget, GetTextureParameter, float*)"/>
        public static unsafe void GetTexParameterf(TextureTarget target, GetTextureParameter pname, Span<float> parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetTexParameterfv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexParameterfv(TextureTarget, GetTextureParameter, float*)"/>
        public static unsafe void GetTexParameterf(TextureTarget target, GetTextureParameter pname, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetTexParameterfv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexParameterfv(TextureTarget, GetTextureParameter, float*)"/>
        public static unsafe void GetTexParameterf(TextureTarget target, GetTextureParameter pname, ref float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                GetTexParameterfv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="LightModelfv(LightModelParameter, float*)"/>
        public static unsafe void LightModelf(LightModelParameter pname, ReadOnlySpan<float> parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                LightModelfv(pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="LightModelfv(LightModelParameter, float*)"/>
        public static unsafe void LightModelf(LightModelParameter pname, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                LightModelfv(pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="LightModelfv(LightModelParameter, float*)"/>
        public static unsafe void LightModelf(LightModelParameter pname, in float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                LightModelfv(pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="Lightfv(LightName, LightParameter, float*)"/>
        public static unsafe void Lightf(LightName light, LightParameter pname, ReadOnlySpan<float> parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                Lightfv(light, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="Lightfv(LightName, LightParameter, float*)"/>
        public static unsafe void Lightf(LightName light, LightParameter pname, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                Lightfv(light, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="Lightfv(LightName, LightParameter, float*)"/>
        public static unsafe void Lightf(LightName light, LightParameter pname, in float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                Lightfv(light, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="LoadMatrixf(float*)"/>
        public static unsafe void LoadMatrixf(ReadOnlySpan<float> m)
        {
            fixed (float* m_ptr = m)
            {
                LoadMatrixf(m_ptr);
            }
        }
        /// <inheritdoc cref="LoadMatrixf(float*)"/>
        public static unsafe void LoadMatrixf(float[] m)
        {
            fixed (float* m_ptr = m)
            {
                LoadMatrixf(m_ptr);
            }
        }
        /// <inheritdoc cref="LoadMatrixf(float*)"/>
        public static unsafe void LoadMatrixf(in float m)
        {
            fixed (float* m_ptr = &m)
            {
                LoadMatrixf(m_ptr);
            }
        }
        /// <inheritdoc cref="Materialfv(TriangleFace, MaterialParameter, float*)"/>
        public static unsafe void Materialf(TriangleFace face, MaterialParameter pname, ReadOnlySpan<float> parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                Materialfv(face, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="Materialfv(TriangleFace, MaterialParameter, float*)"/>
        public static unsafe void Materialf(TriangleFace face, MaterialParameter pname, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                Materialfv(face, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="Materialfv(TriangleFace, MaterialParameter, float*)"/>
        public static unsafe void Materialf(TriangleFace face, MaterialParameter pname, in float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                Materialfv(face, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="MultMatrixf(float*)"/>
        public static unsafe void MultMatrixf(ReadOnlySpan<float> m)
        {
            fixed (float* m_ptr = m)
            {
                MultMatrixf(m_ptr);
            }
        }
        /// <inheritdoc cref="MultMatrixf(float*)"/>
        public static unsafe void MultMatrixf(float[] m)
        {
            fixed (float* m_ptr = m)
            {
                MultMatrixf(m_ptr);
            }
        }
        /// <inheritdoc cref="MultMatrixf(float*)"/>
        public static unsafe void MultMatrixf(in float m)
        {
            fixed (float* m_ptr = &m)
            {
                MultMatrixf(m_ptr);
            }
        }
        /// <inheritdoc cref="PointParameterfv(PointParameterNameARB, float*)"/>
        public static unsafe void PointParameterf(PointParameterNameARB pname, ReadOnlySpan<float> parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                PointParameterfv(pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="PointParameterfv(PointParameterNameARB, float*)"/>
        public static unsafe void PointParameterf(PointParameterNameARB pname, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                PointParameterfv(pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="PointParameterfv(PointParameterNameARB, float*)"/>
        public static unsafe void PointParameterf(PointParameterNameARB pname, in float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                PointParameterfv(pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="TexEnvfv(TextureEnvTarget, TextureEnvParameter, float*)"/>
        public static unsafe void TexEnvf(TextureEnvTarget target, TextureEnvParameter pname, ReadOnlySpan<float> parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                TexEnvfv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="TexEnvfv(TextureEnvTarget, TextureEnvParameter, float*)"/>
        public static unsafe void TexEnvf(TextureEnvTarget target, TextureEnvParameter pname, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                TexEnvfv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="TexEnvfv(TextureEnvTarget, TextureEnvParameter, float*)"/>
        public static unsafe void TexEnvf(TextureEnvTarget target, TextureEnvParameter pname, in float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                TexEnvfv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="TexParameterfv(TextureTarget, TextureParameterName, float*)"/>
        public static unsafe void TexParameterf(TextureTarget target, TextureParameterName pname, ReadOnlySpan<float> parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                TexParameterfv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="TexParameterfv(TextureTarget, TextureParameterName, float*)"/>
        public static unsafe void TexParameterf(TextureTarget target, TextureParameterName pname, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                TexParameterfv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="TexParameterfv(TextureTarget, TextureParameterName, float*)"/>
        public static unsafe void TexParameterf(TextureTarget target, TextureParameterName pname, in float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                TexParameterfv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="BufferData(BufferTargetARB, nint, void*, BufferUsageARB)"/>
        public static unsafe void BufferData(BufferTargetARB target, nint size, IntPtr data, BufferUsageARB usage)
        {
            void* data_vptr = (void*)data;
            BufferData(target, size, data_vptr, usage);
        }
        /// <inheritdoc cref="BufferData(BufferTargetARB, nint, void*, BufferUsageARB)"/>
        public static unsafe void BufferData<T1>(BufferTargetARB target, ReadOnlySpan<T1> data, BufferUsageARB usage)
            where T1 : unmanaged
        {
            nint size = (nint)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                BufferData(target, size, data_ptr, usage);
            }
        }
        /// <inheritdoc cref="BufferData(BufferTargetARB, nint, void*, BufferUsageARB)"/>
        public static unsafe void BufferData<T1>(BufferTargetARB target, T1[] data, BufferUsageARB usage)
            where T1 : unmanaged
        {
            nint size = (nint)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                BufferData(target, size, data_ptr, usage);
            }
        }
        /// <inheritdoc cref="BufferData(BufferTargetARB, nint, void*, BufferUsageARB)"/>
        public static unsafe void BufferData<T1>(BufferTargetARB target, nint size, in T1 data, BufferUsageARB usage)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = &data)
            {
                BufferData(target, size, data_ptr, usage);
            }
        }
        /// <inheritdoc cref="BufferSubData(BufferTargetARB, IntPtr, nint, void*)"/>
        public static unsafe void BufferSubData(BufferTargetARB target, IntPtr offset, nint size, IntPtr data)
        {
            void* data_vptr = (void*)data;
            BufferSubData(target, offset, size, data_vptr);
        }
        /// <inheritdoc cref="BufferSubData(BufferTargetARB, IntPtr, nint, void*)"/>
        public static unsafe void BufferSubData<T1>(BufferTargetARB target, IntPtr offset, ReadOnlySpan<T1> data)
            where T1 : unmanaged
        {
            nint size = (nint)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                BufferSubData(target, offset, size, data_ptr);
            }
        }
        /// <inheritdoc cref="BufferSubData(BufferTargetARB, IntPtr, nint, void*)"/>
        public static unsafe void BufferSubData<T1>(BufferTargetARB target, IntPtr offset, T1[] data)
            where T1 : unmanaged
        {
            nint size = (nint)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                BufferSubData(target, offset, size, data_ptr);
            }
        }
        /// <inheritdoc cref="BufferSubData(BufferTargetARB, IntPtr, nint, void*)"/>
        public static unsafe void BufferSubData<T1>(BufferTargetARB target, IntPtr offset, nint size, in T1 data)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = &data)
            {
                BufferSubData(target, offset, size, data_ptr);
            }
        }
        /// <inheritdoc cref="ClipPlanex(ClipPlaneName, int*)"/>
        public static unsafe void ClipPlanex(ClipPlaneName plane, ReadOnlySpan<int> equation)
        {
            fixed (int* equation_ptr = equation)
            {
                ClipPlanex(plane, equation_ptr);
            }
        }
        /// <inheritdoc cref="ClipPlanex(ClipPlaneName, int*)"/>
        public static unsafe void ClipPlanex(ClipPlaneName plane, int[] equation)
        {
            fixed (int* equation_ptr = equation)
            {
                ClipPlanex(plane, equation_ptr);
            }
        }
        /// <inheritdoc cref="ClipPlanex(ClipPlaneName, int*)"/>
        public static unsafe void ClipPlanex(ClipPlaneName plane, in int equation)
        {
            fixed (int* equation_ptr = &equation)
            {
                ClipPlanex(plane, equation_ptr);
            }
        }
        /// <inheritdoc cref="Color4ub(byte, byte, byte, byte)"/>
        public static unsafe void Color4(byte red, byte green, byte blue, byte alpha)
        {
            Color4ub(red, green, blue, alpha);
        }
        /// <inheritdoc cref="ColorPointer(int, ColorPointerType, int, void*)"/>
        public static unsafe void ColorPointer(int size, ColorPointerType type, int stride, IntPtr pointer)
        {
            void* pointer_vptr = (void*)pointer;
            ColorPointer(size, type, stride, pointer_vptr);
        }
        /// <inheritdoc cref="ColorPointer(int, ColorPointerType, int, void*)"/>
        public static unsafe void ColorPointer<T1>(int size, ColorPointerType type, int stride, ReadOnlySpan<T1> pointer)
            where T1 : unmanaged
        {
            fixed (void* pointer_ptr = pointer)
            {
                ColorPointer(size, type, stride, pointer_ptr);
            }
        }
        /// <inheritdoc cref="ColorPointer(int, ColorPointerType, int, void*)"/>
        public static unsafe void ColorPointer<T1>(int size, ColorPointerType type, int stride, T1[] pointer)
            where T1 : unmanaged
        {
            fixed (void* pointer_ptr = pointer)
            {
                ColorPointer(size, type, stride, pointer_ptr);
            }
        }
        /// <inheritdoc cref="ColorPointer(int, ColorPointerType, int, void*)"/>
        public static unsafe void ColorPointer<T1>(int size, ColorPointerType type, int stride, in T1 pointer)
            where T1 : unmanaged
        {
            fixed (void* pointer_ptr = &pointer)
            {
                ColorPointer(size, type, stride, pointer_ptr);
            }
        }
        /// <inheritdoc cref="CompressedTexImage2D(TextureTarget, int, InternalFormat, int, int, int, int, void*)"/>
        public static unsafe void CompressedTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, IntPtr data)
        {
            void* data_vptr = (void*)data;
            CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data_vptr);
        }
        /// <inheritdoc cref="CompressedTexImage2D(TextureTarget, int, InternalFormat, int, int, int, int, void*)"/>
        public static unsafe void CompressedTexImage2D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, ReadOnlySpan<T1> data)
            where T1 : unmanaged
        {
            int imageSize = (int)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data_ptr);
            }
        }
        /// <inheritdoc cref="CompressedTexImage2D(TextureTarget, int, InternalFormat, int, int, int, int, void*)"/>
        public static unsafe void CompressedTexImage2D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, T1[] data)
            where T1 : unmanaged
        {
            int imageSize = (int)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data_ptr);
            }
        }
        /// <inheritdoc cref="CompressedTexImage2D(TextureTarget, int, InternalFormat, int, int, int, int, void*)"/>
        public static unsafe void CompressedTexImage2D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, in T1 data)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = &data)
            {
                CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data_ptr);
            }
        }
        /// <inheritdoc cref="CompressedTexSubImage2D(TextureTarget, int, int, int, int, int, InternalFormat, int, void*)"/>
        public static unsafe void CompressedTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, InternalFormat format, int imageSize, IntPtr data)
        {
            void* data_vptr = (void*)data;
            CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data_vptr);
        }
        /// <inheritdoc cref="CompressedTexSubImage2D(TextureTarget, int, int, int, int, int, InternalFormat, int, void*)"/>
        public static unsafe void CompressedTexSubImage2D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, InternalFormat format, ReadOnlySpan<T1> data)
            where T1 : unmanaged
        {
            int imageSize = (int)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data_ptr);
            }
        }
        /// <inheritdoc cref="CompressedTexSubImage2D(TextureTarget, int, int, int, int, int, InternalFormat, int, void*)"/>
        public static unsafe void CompressedTexSubImage2D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, InternalFormat format, T1[] data)
            where T1 : unmanaged
        {
            int imageSize = (int)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data_ptr);
            }
        }
        /// <inheritdoc cref="CompressedTexSubImage2D(TextureTarget, int, int, int, int, int, InternalFormat, int, void*)"/>
        public static unsafe void CompressedTexSubImage2D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, InternalFormat format, int imageSize, in T1 data)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = &data)
            {
                CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data_ptr);
            }
        }
        /// <inheritdoc cref="DeleteBuffers(int, int*)"/>
        public static unsafe void DeleteBuffer(in int buffer)
        {
            int n = 1;
            fixed(int* buffers_handle = &buffer)
            {
                DeleteBuffers(n, buffers_handle);
            }
        }
        /// <inheritdoc cref="DeleteBuffers(int, int*)"/>
        public static unsafe void DeleteBuffers(ReadOnlySpan<int> buffers)
        {
            int n = (int)(buffers.Length);
            fixed (int* buffers_ptr = buffers)
            {
                DeleteBuffers(n, buffers_ptr);
            }
        }
        /// <inheritdoc cref="DeleteBuffers(int, int*)"/>
        public static unsafe void DeleteBuffers(int[] buffers)
        {
            int n = (int)(buffers.Length);
            fixed (int* buffers_ptr = buffers)
            {
                DeleteBuffers(n, buffers_ptr);
            }
        }
        /// <inheritdoc cref="DeleteBuffers(int, int*)"/>
        public static unsafe void DeleteBuffers(int n, in int buffers)
        {
            fixed (int* buffers_ptr = &buffers)
            {
                DeleteBuffers(n, buffers_ptr);
            }
        }
        /// <inheritdoc cref="DeleteTextures(int, int*)"/>
        public static unsafe void DeleteTexture(in int texture)
        {
            int n = 1;
            fixed(int* textures_handle = &texture)
            {
                DeleteTextures(n, textures_handle);
            }
        }
        /// <inheritdoc cref="DeleteTextures(int, int*)"/>
        public static unsafe void DeleteTextures(ReadOnlySpan<int> textures)
        {
            int n = (int)(textures.Length);
            fixed (int* textures_ptr = textures)
            {
                DeleteTextures(n, textures_ptr);
            }
        }
        /// <inheritdoc cref="DeleteTextures(int, int*)"/>
        public static unsafe void DeleteTextures(int[] textures)
        {
            int n = (int)(textures.Length);
            fixed (int* textures_ptr = textures)
            {
                DeleteTextures(n, textures_ptr);
            }
        }
        /// <inheritdoc cref="DeleteTextures(int, int*)"/>
        public static unsafe void DeleteTextures(int n, in int textures)
        {
            fixed (int* textures_ptr = &textures)
            {
                DeleteTextures(n, textures_ptr);
            }
        }
        /// <inheritdoc cref="DrawElements(PrimitiveType, int, DrawElementsType, void*)"/>
        public static unsafe void DrawElements(PrimitiveType mode, int count, DrawElementsType type, nint offset)
        {
            void* indices = (void*)offset;
            DrawElements(mode, count, type, indices);
        }
        /// <inheritdoc cref="Fogxv(FogPName, int*)"/>
        public static unsafe void Fogx(FogPName pname, ReadOnlySpan<int> param)
        {
            fixed (int* param_ptr = param)
            {
                Fogxv(pname, param_ptr);
            }
        }
        /// <inheritdoc cref="Fogxv(FogPName, int*)"/>
        public static unsafe void Fogx(FogPName pname, int[] param)
        {
            fixed (int* param_ptr = param)
            {
                Fogxv(pname, param_ptr);
            }
        }
        /// <inheritdoc cref="Fogxv(FogPName, int*)"/>
        public static unsafe void Fogx(FogPName pname, in int param)
        {
            fixed (int* param_ptr = &param)
            {
                Fogxv(pname, param_ptr);
            }
        }
        /// <inheritdoc cref="GetBooleanv(GetPName, bool*)"/>
        public static unsafe void GetBoolean(GetPName pname, Span<bool> data)
        {
            fixed (bool* data_ptr = data)
            {
                GetBooleanv(pname, data_ptr);
            }
        }
        /// <inheritdoc cref="GetBooleanv(GetPName, bool*)"/>
        public static unsafe void GetBoolean(GetPName pname, bool[] data)
        {
            fixed (bool* data_ptr = data)
            {
                GetBooleanv(pname, data_ptr);
            }
        }
        /// <inheritdoc cref="GetBooleanv(GetPName, bool*)"/>
        public static unsafe void GetBoolean(GetPName pname, ref bool data)
        {
            fixed (bool* data_ptr = &data)
            {
                GetBooleanv(pname, data_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferParameteriv(BufferTargetARB, BufferPNameARB, int*)"/>
        public static unsafe void GetBufferParameteri(BufferTargetARB target, BufferPNameARB pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetBufferParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferParameteriv(BufferTargetARB, BufferPNameARB, int*)"/>
        public static unsafe void GetBufferParameteri(BufferTargetARB target, BufferPNameARB pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetBufferParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferParameteriv(BufferTargetARB, BufferPNameARB, int*)"/>
        public static unsafe void GetBufferParameteri(BufferTargetARB target, BufferPNameARB pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetBufferParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetClipPlanex(ClipPlaneName, int*)"/>
        public static unsafe void GetClipPlanex(ClipPlaneName plane, Span<int> equation)
        {
            fixed (int* equation_ptr = equation)
            {
                GetClipPlanex(plane, equation_ptr);
            }
        }
        /// <inheritdoc cref="GetClipPlanex(ClipPlaneName, int*)"/>
        public static unsafe void GetClipPlanex(ClipPlaneName plane, int[] equation)
        {
            fixed (int* equation_ptr = equation)
            {
                GetClipPlanex(plane, equation_ptr);
            }
        }
        /// <inheritdoc cref="GetClipPlanex(ClipPlaneName, int*)"/>
        public static unsafe void GetClipPlanex(ClipPlaneName plane, ref int equation)
        {
            fixed (int* equation_ptr = &equation)
            {
                GetClipPlanex(plane, equation_ptr);
            }
        }
        /// <inheritdoc cref="GenBuffers(int, int*)"/>
        public static unsafe int GenBuffer()
        {
            int buffer;
            int n = 1;
            Unsafe.SkipInit(out buffer);
            // FIXME: This could be a problem for the overloads that take an out parameter
            // as this parameter could *potentially* move while inside of this function
            // which would mean that the new value never gets written to the out parameter.
            // Making for a nasty bug.
            // The reason we don't use a fixed expression here is because of the "single out parameter to return value" overloading step
            // that will make it so this tries to fix a local variable which is not allowed in C# for some reason.
            // If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk
            // - 2021-05-18
            int* buffers_handle = (int*)Unsafe.AsPointer(ref buffer);
            GenBuffers(n, buffers_handle);
            return buffer;
        }
        /// <inheritdoc cref="GenBuffers(int, int*)"/>
        public static unsafe void GenBuffer(out int buffer)
        {
            int n = 1;
            Unsafe.SkipInit(out buffer);
            // FIXME: This could be a problem for the overloads that take an out parameter
            // as this parameter could *potentially* move while inside of this function
            // which would mean that the new value never gets written to the out parameter.
            // Making for a nasty bug.
            // The reason we don't use a fixed expression here is because of the "single out parameter to return value" overloading step
            // that will make it so this tries to fix a local variable which is not allowed in C# for some reason.
            // If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk
            // - 2021-05-18
            int* buffers_handle = (int*)Unsafe.AsPointer(ref buffer);
            GenBuffers(n, buffers_handle);
        }
        /// <inheritdoc cref="GenBuffers(int, int*)"/>
        public static unsafe void GenBuffers(Span<int> buffers)
        {
            int n = (int)(buffers.Length);
            fixed (int* buffers_ptr = buffers)
            {
                GenBuffers(n, buffers_ptr);
            }
        }
        /// <inheritdoc cref="GenBuffers(int, int*)"/>
        public static unsafe void GenBuffers(int[] buffers)
        {
            int n = (int)(buffers.Length);
            fixed (int* buffers_ptr = buffers)
            {
                GenBuffers(n, buffers_ptr);
            }
        }
        /// <inheritdoc cref="GenBuffers(int, int*)"/>
        public static unsafe void GenBuffers(int n, ref int buffers)
        {
            fixed (int* buffers_ptr = &buffers)
            {
                GenBuffers(n, buffers_ptr);
            }
        }
        /// <inheritdoc cref="GenTextures(int, int*)"/>
        public static unsafe int GenTexture()
        {
            int texture;
            int n = 1;
            Unsafe.SkipInit(out texture);
            // FIXME: This could be a problem for the overloads that take an out parameter
            // as this parameter could *potentially* move while inside of this function
            // which would mean that the new value never gets written to the out parameter.
            // Making for a nasty bug.
            // The reason we don't use a fixed expression here is because of the "single out parameter to return value" overloading step
            // that will make it so this tries to fix a local variable which is not allowed in C# for some reason.
            // If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk
            // - 2021-05-18
            int* textures_handle = (int*)Unsafe.AsPointer(ref texture);
            GenTextures(n, textures_handle);
            return texture;
        }
        /// <inheritdoc cref="GenTextures(int, int*)"/>
        public static unsafe void GenTexture(out int texture)
        {
            int n = 1;
            Unsafe.SkipInit(out texture);
            // FIXME: This could be a problem for the overloads that take an out parameter
            // as this parameter could *potentially* move while inside of this function
            // which would mean that the new value never gets written to the out parameter.
            // Making for a nasty bug.
            // The reason we don't use a fixed expression here is because of the "single out parameter to return value" overloading step
            // that will make it so this tries to fix a local variable which is not allowed in C# for some reason.
            // If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk
            // - 2021-05-18
            int* textures_handle = (int*)Unsafe.AsPointer(ref texture);
            GenTextures(n, textures_handle);
        }
        /// <inheritdoc cref="GenTextures(int, int*)"/>
        public static unsafe void GenTextures(Span<int> textures)
        {
            int n = (int)(textures.Length);
            fixed (int* textures_ptr = textures)
            {
                GenTextures(n, textures_ptr);
            }
        }
        /// <inheritdoc cref="GenTextures(int, int*)"/>
        public static unsafe void GenTextures(int[] textures)
        {
            int n = (int)(textures.Length);
            fixed (int* textures_ptr = textures)
            {
                GenTextures(n, textures_ptr);
            }
        }
        /// <inheritdoc cref="GenTextures(int, int*)"/>
        public static unsafe void GenTextures(int n, ref int textures)
        {
            fixed (int* textures_ptr = &textures)
            {
                GenTextures(n, textures_ptr);
            }
        }
        /// <inheritdoc cref="GetFixedv(GetPName, int*)"/>
        public static unsafe void GetFixed(GetPName pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetFixedv(pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetIntegerv(GetPName, int*)"/>
        public static unsafe void GetInteger(GetPName pname, Span<int> data)
        {
            fixed (int* data_ptr = data)
            {
                GetIntegerv(pname, data_ptr);
            }
        }
        /// <inheritdoc cref="GetIntegerv(GetPName, int*)"/>
        public static unsafe void GetInteger(GetPName pname, int[] data)
        {
            fixed (int* data_ptr = data)
            {
                GetIntegerv(pname, data_ptr);
            }
        }
        /// <inheritdoc cref="GetIntegerv(GetPName, int*)"/>
        public static unsafe void GetInteger(GetPName pname, ref int data)
        {
            fixed (int* data_ptr = &data)
            {
                GetIntegerv(pname, data_ptr);
            }
        }
        /// <inheritdoc cref="GetLightxv(LightName, LightParameter, int*)"/>
        public static unsafe void GetLightx(LightName light, LightParameter pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetLightxv(light, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetLightxv(LightName, LightParameter, int*)"/>
        public static unsafe void GetLightx(LightName light, LightParameter pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetLightxv(light, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetLightxv(LightName, LightParameter, int*)"/>
        public static unsafe void GetLightx(LightName light, LightParameter pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetLightxv(light, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetMaterialxv(TriangleFace, MaterialParameter, int*)"/>
        public static unsafe void GetMaterialx(TriangleFace face, MaterialParameter pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetMaterialxv(face, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetMaterialxv(TriangleFace, MaterialParameter, int*)"/>
        public static unsafe void GetMaterialx(TriangleFace face, MaterialParameter pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetMaterialxv(face, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetMaterialxv(TriangleFace, MaterialParameter, int*)"/>
        public static unsafe void GetMaterialx(TriangleFace face, MaterialParameter pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetMaterialxv(face, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetPointerv(GetPointervPName, void**)"/>
        public static unsafe void GetPointer(GetPointervPName pname, void** parameters)
        {
            GetPointerv(pname, parameters);
        }
        /// <inheritdoc cref="GetString(StringName)"/>
        public static unsafe string? GetString(StringName name)
        {
            byte* returnValue;
            string? returnValue_str;
            returnValue = GetString_(name);
            returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
            return returnValue_str;
        }
        /// <inheritdoc cref="GetTexEnviv(TextureEnvTarget, TextureEnvParameter, int*)"/>
        public static unsafe void GetTexEnvi(TextureEnvTarget target, TextureEnvParameter pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetTexEnviv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexEnviv(TextureEnvTarget, TextureEnvParameter, int*)"/>
        public static unsafe void GetTexEnvi(TextureEnvTarget target, TextureEnvParameter pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetTexEnviv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexEnviv(TextureEnvTarget, TextureEnvParameter, int*)"/>
        public static unsafe void GetTexEnvi(TextureEnvTarget target, TextureEnvParameter pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetTexEnviv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexEnvxv(TextureEnvTarget, TextureEnvParameter, int*)"/>
        public static unsafe void GetTexEnvx(TextureEnvTarget target, TextureEnvParameter pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetTexEnvxv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexEnvxv(TextureEnvTarget, TextureEnvParameter, int*)"/>
        public static unsafe void GetTexEnvx(TextureEnvTarget target, TextureEnvParameter pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetTexEnvxv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexEnvxv(TextureEnvTarget, TextureEnvParameter, int*)"/>
        public static unsafe void GetTexEnvx(TextureEnvTarget target, TextureEnvParameter pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetTexEnvxv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexParameteriv(TextureTarget, GetTextureParameter, int*)"/>
        public static unsafe void GetTexParameteri(TextureTarget target, GetTextureParameter pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetTexParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexParameteriv(TextureTarget, GetTextureParameter, int*)"/>
        public static unsafe void GetTexParameteri(TextureTarget target, GetTextureParameter pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetTexParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexParameteriv(TextureTarget, GetTextureParameter, int*)"/>
        public static unsafe void GetTexParameteri(TextureTarget target, GetTextureParameter pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetTexParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexParameterxv(TextureTarget, GetTextureParameter, int*)"/>
        public static unsafe void GetTexParameterx(TextureTarget target, GetTextureParameter pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetTexParameterxv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexParameterxv(TextureTarget, GetTextureParameter, int*)"/>
        public static unsafe void GetTexParameterx(TextureTarget target, GetTextureParameter pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetTexParameterxv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexParameterxv(TextureTarget, GetTextureParameter, int*)"/>
        public static unsafe void GetTexParameterx(TextureTarget target, GetTextureParameter pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetTexParameterxv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="LightModelxv(LightModelParameter, int*)"/>
        public static unsafe void LightModelx(LightModelParameter pname, ReadOnlySpan<int> param)
        {
            fixed (int* param_ptr = param)
            {
                LightModelxv(pname, param_ptr);
            }
        }
        /// <inheritdoc cref="LightModelxv(LightModelParameter, int*)"/>
        public static unsafe void LightModelx(LightModelParameter pname, int[] param)
        {
            fixed (int* param_ptr = param)
            {
                LightModelxv(pname, param_ptr);
            }
        }
        /// <inheritdoc cref="LightModelxv(LightModelParameter, int*)"/>
        public static unsafe void LightModelx(LightModelParameter pname, in int param)
        {
            fixed (int* param_ptr = &param)
            {
                LightModelxv(pname, param_ptr);
            }
        }
        /// <inheritdoc cref="Lightxv(LightName, LightParameter, int*)"/>
        public static unsafe void Lightx(LightName light, LightParameter pname, ReadOnlySpan<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                Lightxv(light, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="Lightxv(LightName, LightParameter, int*)"/>
        public static unsafe void Lightx(LightName light, LightParameter pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                Lightxv(light, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="Lightxv(LightName, LightParameter, int*)"/>
        public static unsafe void Lightx(LightName light, LightParameter pname, in int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                Lightxv(light, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="LoadMatrixx(int*)"/>
        public static unsafe void LoadMatrixx(ReadOnlySpan<int> m)
        {
            fixed (int* m_ptr = m)
            {
                LoadMatrixx(m_ptr);
            }
        }
        /// <inheritdoc cref="LoadMatrixx(int*)"/>
        public static unsafe void LoadMatrixx(int[] m)
        {
            fixed (int* m_ptr = m)
            {
                LoadMatrixx(m_ptr);
            }
        }
        /// <inheritdoc cref="LoadMatrixx(int*)"/>
        public static unsafe void LoadMatrixx(in int m)
        {
            fixed (int* m_ptr = &m)
            {
                LoadMatrixx(m_ptr);
            }
        }
        /// <inheritdoc cref="Materialxv(TriangleFace, MaterialParameter, int*)"/>
        public static unsafe void Materialx(TriangleFace face, MaterialParameter pname, ReadOnlySpan<int> param)
        {
            fixed (int* param_ptr = param)
            {
                Materialxv(face, pname, param_ptr);
            }
        }
        /// <inheritdoc cref="Materialxv(TriangleFace, MaterialParameter, int*)"/>
        public static unsafe void Materialx(TriangleFace face, MaterialParameter pname, int[] param)
        {
            fixed (int* param_ptr = param)
            {
                Materialxv(face, pname, param_ptr);
            }
        }
        /// <inheritdoc cref="Materialxv(TriangleFace, MaterialParameter, int*)"/>
        public static unsafe void Materialx(TriangleFace face, MaterialParameter pname, in int param)
        {
            fixed (int* param_ptr = &param)
            {
                Materialxv(face, pname, param_ptr);
            }
        }
        /// <inheritdoc cref="MultMatrixx(int*)"/>
        public static unsafe void MultMatrixx(ReadOnlySpan<int> m)
        {
            fixed (int* m_ptr = m)
            {
                MultMatrixx(m_ptr);
            }
        }
        /// <inheritdoc cref="MultMatrixx(int*)"/>
        public static unsafe void MultMatrixx(int[] m)
        {
            fixed (int* m_ptr = m)
            {
                MultMatrixx(m_ptr);
            }
        }
        /// <inheritdoc cref="MultMatrixx(int*)"/>
        public static unsafe void MultMatrixx(in int m)
        {
            fixed (int* m_ptr = &m)
            {
                MultMatrixx(m_ptr);
            }
        }
        /// <inheritdoc cref="NormalPointer(NormalPointerType, int, void*)"/>
        public static unsafe void NormalPointer(NormalPointerType type, int stride, IntPtr pointer)
        {
            void* pointer_vptr = (void*)pointer;
            NormalPointer(type, stride, pointer_vptr);
        }
        /// <inheritdoc cref="NormalPointer(NormalPointerType, int, void*)"/>
        public static unsafe void NormalPointer<T1>(NormalPointerType type, int stride, ReadOnlySpan<T1> pointer)
            where T1 : unmanaged
        {
            fixed (void* pointer_ptr = pointer)
            {
                NormalPointer(type, stride, pointer_ptr);
            }
        }
        /// <inheritdoc cref="NormalPointer(NormalPointerType, int, void*)"/>
        public static unsafe void NormalPointer<T1>(NormalPointerType type, int stride, T1[] pointer)
            where T1 : unmanaged
        {
            fixed (void* pointer_ptr = pointer)
            {
                NormalPointer(type, stride, pointer_ptr);
            }
        }
        /// <inheritdoc cref="NormalPointer(NormalPointerType, int, void*)"/>
        public static unsafe void NormalPointer<T1>(NormalPointerType type, int stride, in T1 pointer)
            where T1 : unmanaged
        {
            fixed (void* pointer_ptr = &pointer)
            {
                NormalPointer(type, stride, pointer_ptr);
            }
        }
        /// <inheritdoc cref="PointParameterxv(PointParameterNameARB, int*)"/>
        public static unsafe void PointParameterx(PointParameterNameARB pname, ReadOnlySpan<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                PointParameterxv(pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="PointParameterxv(PointParameterNameARB, int*)"/>
        public static unsafe void PointParameterx(PointParameterNameARB pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                PointParameterxv(pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="PointParameterxv(PointParameterNameARB, int*)"/>
        public static unsafe void PointParameterx(PointParameterNameARB pname, in int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                PointParameterxv(pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="ReadPixels(int, int, int, int, PixelFormat, PixelType, void*)"/>
        public static unsafe void ReadPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, IntPtr pixels)
        {
            void* pixels_vptr = (void*)pixels;
            ReadPixels(x, y, width, height, format, type, pixels_vptr);
        }
        /// <inheritdoc cref="ReadPixels(int, int, int, int, PixelFormat, PixelType, void*)"/>
        public static unsafe void ReadPixels<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, Span<T1> pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels)
            {
                ReadPixels(x, y, width, height, format, type, pixels_ptr);
            }
        }
        /// <inheritdoc cref="ReadPixels(int, int, int, int, PixelFormat, PixelType, void*)"/>
        public static unsafe void ReadPixels<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, T1[] pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels)
            {
                ReadPixels(x, y, width, height, format, type, pixels_ptr);
            }
        }
        /// <inheritdoc cref="ReadPixels(int, int, int, int, PixelFormat, PixelType, void*)"/>
        public static unsafe void ReadPixels<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, ref T1 pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = &pixels)
            {
                ReadPixels(x, y, width, height, format, type, pixels_ptr);
            }
        }
        /// <inheritdoc cref="TexCoordPointer(int, TexCoordPointerType, int, void*)"/>
        public static unsafe void TexCoordPointer(int size, TexCoordPointerType type, int stride, IntPtr pointer)
        {
            void* pointer_vptr = (void*)pointer;
            TexCoordPointer(size, type, stride, pointer_vptr);
        }
        /// <inheritdoc cref="TexCoordPointer(int, TexCoordPointerType, int, void*)"/>
        public static unsafe void TexCoordPointer<T1>(int size, TexCoordPointerType type, int stride, ReadOnlySpan<T1> pointer)
            where T1 : unmanaged
        {
            fixed (void* pointer_ptr = pointer)
            {
                TexCoordPointer(size, type, stride, pointer_ptr);
            }
        }
        /// <inheritdoc cref="TexCoordPointer(int, TexCoordPointerType, int, void*)"/>
        public static unsafe void TexCoordPointer<T1>(int size, TexCoordPointerType type, int stride, T1[] pointer)
            where T1 : unmanaged
        {
            fixed (void* pointer_ptr = pointer)
            {
                TexCoordPointer(size, type, stride, pointer_ptr);
            }
        }
        /// <inheritdoc cref="TexCoordPointer(int, TexCoordPointerType, int, void*)"/>
        public static unsafe void TexCoordPointer<T1>(int size, TexCoordPointerType type, int stride, in T1 pointer)
            where T1 : unmanaged
        {
            fixed (void* pointer_ptr = &pointer)
            {
                TexCoordPointer(size, type, stride, pointer_ptr);
            }
        }
        /// <inheritdoc cref="TexEnviv(TextureEnvTarget, TextureEnvParameter, int*)"/>
        public static unsafe void TexEnvi(TextureEnvTarget target, TextureEnvParameter pname, ReadOnlySpan<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                TexEnviv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="TexEnviv(TextureEnvTarget, TextureEnvParameter, int*)"/>
        public static unsafe void TexEnvi(TextureEnvTarget target, TextureEnvParameter pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                TexEnviv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="TexEnviv(TextureEnvTarget, TextureEnvParameter, int*)"/>
        public static unsafe void TexEnvi(TextureEnvTarget target, TextureEnvParameter pname, in int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                TexEnviv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="TexEnvxv(TextureEnvTarget, TextureEnvParameter, int*)"/>
        public static unsafe void TexEnvx(TextureEnvTarget target, TextureEnvParameter pname, ReadOnlySpan<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                TexEnvxv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="TexEnvxv(TextureEnvTarget, TextureEnvParameter, int*)"/>
        public static unsafe void TexEnvx(TextureEnvTarget target, TextureEnvParameter pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                TexEnvxv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="TexEnvxv(TextureEnvTarget, TextureEnvParameter, int*)"/>
        public static unsafe void TexEnvx(TextureEnvTarget target, TextureEnvParameter pname, in int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                TexEnvxv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="TexImage2D(TextureTarget, int, InternalFormat, int, int, int, PixelFormat, PixelType, void*)"/>
        public static unsafe void TexImage2D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, PixelFormat format, PixelType type, IntPtr pixels)
        {
            void* pixels_vptr = (void*)pixels;
            TexImage2D(target, level, internalformat, width, height, border, format, type, pixels_vptr);
        }
        /// <inheritdoc cref="TexImage2D(TextureTarget, int, InternalFormat, int, int, int, PixelFormat, PixelType, void*)"/>
        public static unsafe void TexImage2D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, PixelFormat format, PixelType type, ReadOnlySpan<T1> pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels)
            {
                TexImage2D(target, level, internalformat, width, height, border, format, type, pixels_ptr);
            }
        }
        /// <inheritdoc cref="TexImage2D(TextureTarget, int, InternalFormat, int, int, int, PixelFormat, PixelType, void*)"/>
        public static unsafe void TexImage2D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, PixelFormat format, PixelType type, T1[] pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels)
            {
                TexImage2D(target, level, internalformat, width, height, border, format, type, pixels_ptr);
            }
        }
        /// <inheritdoc cref="TexImage2D(TextureTarget, int, InternalFormat, int, int, int, PixelFormat, PixelType, void*)"/>
        public static unsafe void TexImage2D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, PixelFormat format, PixelType type, in T1 pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = &pixels)
            {
                TexImage2D(target, level, internalformat, width, height, border, format, type, pixels_ptr);
            }
        }
        /// <inheritdoc cref="TexParameteriv(TextureTarget, TextureParameterName, int*)"/>
        public static unsafe void TexParameteri(TextureTarget target, TextureParameterName pname, ReadOnlySpan<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                TexParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="TexParameteriv(TextureTarget, TextureParameterName, int*)"/>
        public static unsafe void TexParameteri(TextureTarget target, TextureParameterName pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                TexParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="TexParameteriv(TextureTarget, TextureParameterName, int*)"/>
        public static unsafe void TexParameteri(TextureTarget target, TextureParameterName pname, in int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                TexParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="TexParameterxv(TextureTarget, GetTextureParameter, int*)"/>
        public static unsafe void TexParameterx(TextureTarget target, GetTextureParameter pname, ReadOnlySpan<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                TexParameterxv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="TexParameterxv(TextureTarget, GetTextureParameter, int*)"/>
        public static unsafe void TexParameterx(TextureTarget target, GetTextureParameter pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                TexParameterxv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="TexParameterxv(TextureTarget, GetTextureParameter, int*)"/>
        public static unsafe void TexParameterx(TextureTarget target, GetTextureParameter pname, in int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                TexParameterxv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="TexSubImage2D(TextureTarget, int, int, int, int, int, PixelFormat, PixelType, void*)"/>
        public static unsafe void TexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, IntPtr pixels)
        {
            void* pixels_vptr = (void*)pixels;
            TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels_vptr);
        }
        /// <inheritdoc cref="TexSubImage2D(TextureTarget, int, int, int, int, int, PixelFormat, PixelType, void*)"/>
        public static unsafe void TexSubImage2D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, ReadOnlySpan<T1> pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels)
            {
                TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels_ptr);
            }
        }
        /// <inheritdoc cref="TexSubImage2D(TextureTarget, int, int, int, int, int, PixelFormat, PixelType, void*)"/>
        public static unsafe void TexSubImage2D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, T1[] pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels)
            {
                TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels_ptr);
            }
        }
        /// <inheritdoc cref="TexSubImage2D(TextureTarget, int, int, int, int, int, PixelFormat, PixelType, void*)"/>
        public static unsafe void TexSubImage2D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, in T1 pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = &pixels)
            {
                TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels_ptr);
            }
        }
        /// <inheritdoc cref="VertexPointer(int, VertexPointerType, int, void*)"/>
        public static unsafe void VertexPointer(int size, VertexPointerType type, int stride, IntPtr pointer)
        {
            void* pointer_vptr = (void*)pointer;
            VertexPointer(size, type, stride, pointer_vptr);
        }
        /// <inheritdoc cref="VertexPointer(int, VertexPointerType, int, void*)"/>
        public static unsafe void VertexPointer<T1>(int size, VertexPointerType type, int stride, ReadOnlySpan<T1> pointer)
            where T1 : unmanaged
        {
            fixed (void* pointer_ptr = pointer)
            {
                VertexPointer(size, type, stride, pointer_ptr);
            }
        }
        /// <inheritdoc cref="VertexPointer(int, VertexPointerType, int, void*)"/>
        public static unsafe void VertexPointer<T1>(int size, VertexPointerType type, int stride, T1[] pointer)
            where T1 : unmanaged
        {
            fixed (void* pointer_ptr = pointer)
            {
                VertexPointer(size, type, stride, pointer_ptr);
            }
        }
        /// <inheritdoc cref="VertexPointer(int, VertexPointerType, int, void*)"/>
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
            /// <inheritdoc cref="GetInteger64v(GetPName, long*)"/>
            public static unsafe void GetInteger64v(GetPName pname, ref long parameters)
            {
                fixed (long* parameters_ptr = &parameters)
                {
                    GetInteger64v(pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetSynciv(GLSync, SyncParameterName, int, int*, int*)"/>
            public static unsafe void GetSynciv(GLSync sync, SyncParameterName pname, ref int length, Span<int> values)
            {
                fixed (int* length_ptr = &length)
                {
                    int count = (int)(values.Length);
                    fixed (int* values_ptr = values)
                    {
                        GetSynciv(sync, pname, count, length_ptr, values_ptr);
                    }
                }
            }
            /// <inheritdoc cref="GetSynciv(GLSync, SyncParameterName, int, int*, int*)"/>
            public static unsafe void GetSynciv(GLSync sync, SyncParameterName pname, ref int length, int[] values)
            {
                fixed (int* length_ptr = &length)
                {
                    int count = (int)(values.Length);
                    fixed (int* values_ptr = values)
                    {
                        GetSynciv(sync, pname, count, length_ptr, values_ptr);
                    }
                }
            }
            /// <inheritdoc cref="GetSynciv(GLSync, SyncParameterName, int, int*, int*)"/>
            public static unsafe void GetSynciv(GLSync sync, SyncParameterName pname, int count, ref int length, ref int values)
            {
                fixed (int* length_ptr = &length)
                fixed (int* values_ptr = &values)
                {
                    GetSynciv(sync, pname, count, length_ptr, values_ptr);
                }
            }
        }
        public static unsafe partial class EXT
        {
            /// <inheritdoc cref="InsertEventMarker(int, byte*)"/>
            public static unsafe void InsertEventMarker(int length, string marker)
            {
                byte* marker_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(marker);
                InsertEventMarker(length, marker_ptr);
                Marshal.FreeCoTaskMem((IntPtr)marker_ptr);
            }
            /// <inheritdoc cref="PushGroupMarker(int, byte*)"/>
            public static unsafe void PushGroupMarker(int length, string marker)
            {
                byte* marker_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(marker);
                PushGroupMarker(length, marker_ptr);
                Marshal.FreeCoTaskMem((IntPtr)marker_ptr);
            }
            /// <inheritdoc cref="DiscardFramebuffer(FramebufferTarget, int, InvalidateFramebufferAttachment*)"/>
            public static unsafe void DiscardFramebuffer(FramebufferTarget target, ReadOnlySpan<InvalidateFramebufferAttachment> attachments)
            {
                int numAttachments = (int)(attachments.Length);
                fixed (InvalidateFramebufferAttachment* attachments_ptr = attachments)
                {
                    DiscardFramebuffer(target, numAttachments, attachments_ptr);
                }
            }
            /// <inheritdoc cref="DiscardFramebuffer(FramebufferTarget, int, InvalidateFramebufferAttachment*)"/>
            public static unsafe void DiscardFramebuffer(FramebufferTarget target, InvalidateFramebufferAttachment[] attachments)
            {
                int numAttachments = (int)(attachments.Length);
                fixed (InvalidateFramebufferAttachment* attachments_ptr = attachments)
                {
                    DiscardFramebuffer(target, numAttachments, attachments_ptr);
                }
            }
            /// <inheritdoc cref="DiscardFramebuffer(FramebufferTarget, int, InvalidateFramebufferAttachment*)"/>
            public static unsafe void DiscardFramebuffer(FramebufferTarget target, int numAttachments, in InvalidateFramebufferAttachment attachments)
            {
                fixed (InvalidateFramebufferAttachment* attachments_ptr = &attachments)
                {
                    DiscardFramebuffer(target, numAttachments, attachments_ptr);
                }
            }
            /// <inheritdoc cref="MultiDrawArrays(PrimitiveType, int*, int*, int)"/>
            public static unsafe void MultiDrawArrays(PrimitiveType mode, ReadOnlySpan<int> first, ReadOnlySpan<int> count, int primcount)
            {
                fixed (int* first_ptr = first)
                {
                    fixed (int* count_ptr = count)
                    {
                        MultiDrawArrays(mode, first_ptr, count_ptr, primcount);
                    }
                }
            }
            /// <inheritdoc cref="MultiDrawArrays(PrimitiveType, int*, int*, int)"/>
            public static unsafe void MultiDrawArrays(PrimitiveType mode, int[] first, int[] count, int primcount)
            {
                fixed (int* first_ptr = first)
                {
                    fixed (int* count_ptr = count)
                    {
                        MultiDrawArrays(mode, first_ptr, count_ptr, primcount);
                    }
                }
            }
            /// <inheritdoc cref="MultiDrawArrays(PrimitiveType, int*, int*, int)"/>
            public static unsafe void MultiDrawArrays(PrimitiveType mode, in int first, in int count, int primcount)
            {
                fixed (int* first_ptr = &first)
                fixed (int* count_ptr = &count)
                {
                    MultiDrawArrays(mode, first_ptr, count_ptr, primcount);
                }
            }
            /// <inheritdoc cref="MultiDrawElements(PrimitiveType, int*, DrawElementsType, void**, int)"/>
            public static unsafe void MultiDrawElements(PrimitiveType mode, ReadOnlySpan<int> count, DrawElementsType type, void** indices, int primcount)
            {
                fixed (int* count_ptr = count)
                {
                    MultiDrawElements(mode, count_ptr, type, indices, primcount);
                }
            }
            /// <inheritdoc cref="MultiDrawElements(PrimitiveType, int*, DrawElementsType, void**, int)"/>
            public static unsafe void MultiDrawElements(PrimitiveType mode, int[] count, DrawElementsType type, void** indices, int primcount)
            {
                fixed (int* count_ptr = count)
                {
                    MultiDrawElements(mode, count_ptr, type, indices, primcount);
                }
            }
            /// <inheritdoc cref="MultiDrawElements(PrimitiveType, int*, DrawElementsType, void**, int)"/>
            public static unsafe void MultiDrawElements(PrimitiveType mode, in int count, DrawElementsType type, void** indices, int primcount)
            {
                fixed (int* count_ptr = &count)
                {
                    MultiDrawElements(mode, count_ptr, type, indices, primcount);
                }
            }
            /// <inheritdoc cref="ReadnPixels(int, int, int, int, PixelFormat, PixelType, int, void*)"/>
            public static unsafe void ReadnPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, IntPtr data)
            {
                void* data_vptr = (void*)data;
                ReadnPixels(x, y, width, height, format, type, bufSize, data_vptr);
            }
            /// <inheritdoc cref="ReadnPixels(int, int, int, int, PixelFormat, PixelType, int, void*)"/>
            public static unsafe void ReadnPixels<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, Span<T1> data)
                where T1 : unmanaged
            {
                int bufSize = (int)(data.Length * sizeof(T1));
                fixed (void* data_ptr = data)
                {
                    ReadnPixels(x, y, width, height, format, type, bufSize, data_ptr);
                }
            }
            /// <inheritdoc cref="ReadnPixels(int, int, int, int, PixelFormat, PixelType, int, void*)"/>
            public static unsafe void ReadnPixels<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, T1[] data)
                where T1 : unmanaged
            {
                int bufSize = (int)(data.Length * sizeof(T1));
                fixed (void* data_ptr = data)
                {
                    ReadnPixels(x, y, width, height, format, type, bufSize, data_ptr);
                }
            }
            /// <inheritdoc cref="ReadnPixels(int, int, int, int, PixelFormat, PixelType, int, void*)"/>
            public static unsafe void ReadnPixels<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, ref T1 data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    ReadnPixels(x, y, width, height, format, type, bufSize, data_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformfv(int, int, int, float*)"/>
            public static unsafe void GetnUniformfv(int program, int location, Span<float> parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (float* parameters_ptr = parameters)
                {
                    GetnUniformfv(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformfv(int, int, int, float*)"/>
            public static unsafe void GetnUniformfv(int program, int location, float[] parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (float* parameters_ptr = parameters)
                {
                    GetnUniformfv(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformfv(int, int, int, float*)"/>
            public static unsafe void GetnUniformfv(int program, int location, int bufSize, ref float parameters)
            {
                fixed (float* parameters_ptr = &parameters)
                {
                    GetnUniformfv(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformiv(int, int, int, int*)"/>
            public static unsafe void GetnUniformiv(int program, int location, Span<int> parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (int* parameters_ptr = parameters)
                {
                    GetnUniformiv(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformiv(int, int, int, int*)"/>
            public static unsafe void GetnUniformiv(int program, int location, int[] parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (int* parameters_ptr = parameters)
                {
                    GetnUniformiv(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformiv(int, int, int, int*)"/>
            public static unsafe void GetnUniformiv(int program, int location, int bufSize, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetnUniformiv(program, location, bufSize, parameters_ptr);
                }
            }
        }
        public static unsafe partial class IMG
        {
            /// <inheritdoc cref="ClipPlanef(ClipPlaneName, float*)"/>
            public static unsafe void ClipPlanef(ClipPlaneName p, ReadOnlySpan<float> eqn)
            {
                fixed (float* eqn_ptr = eqn)
                {
                    ClipPlanef(p, eqn_ptr);
                }
            }
            /// <inheritdoc cref="ClipPlanef(ClipPlaneName, float*)"/>
            public static unsafe void ClipPlanef(ClipPlaneName p, float[] eqn)
            {
                fixed (float* eqn_ptr = eqn)
                {
                    ClipPlanef(p, eqn_ptr);
                }
            }
            /// <inheritdoc cref="ClipPlanef(ClipPlaneName, float*)"/>
            public static unsafe void ClipPlanef(ClipPlaneName p, in float eqn)
            {
                fixed (float* eqn_ptr = &eqn)
                {
                    ClipPlanef(p, eqn_ptr);
                }
            }
            /// <inheritdoc cref="ClipPlanex(ClipPlaneName, int*)"/>
            public static unsafe void ClipPlanex(ClipPlaneName p, ReadOnlySpan<int> eqn)
            {
                fixed (int* eqn_ptr = eqn)
                {
                    ClipPlanex(p, eqn_ptr);
                }
            }
            /// <inheritdoc cref="ClipPlanex(ClipPlaneName, int*)"/>
            public static unsafe void ClipPlanex(ClipPlaneName p, int[] eqn)
            {
                fixed (int* eqn_ptr = eqn)
                {
                    ClipPlanex(p, eqn_ptr);
                }
            }
            /// <inheritdoc cref="ClipPlanex(ClipPlaneName, int*)"/>
            public static unsafe void ClipPlanex(ClipPlaneName p, in int eqn)
            {
                fixed (int* eqn_ptr = &eqn)
                {
                    ClipPlanex(p, eqn_ptr);
                }
            }
        }
        public static unsafe partial class KHR
        {
            /// <inheritdoc cref="DebugMessageControl(DebugSource, DebugType, DebugSeverity, int, uint*, bool)"/>
            public static unsafe void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, ReadOnlySpan<uint> ids, bool enabled)
            {
                int count = (int)(ids.Length);
                fixed (uint* ids_ptr = ids)
                {
                    DebugMessageControl(source, type, severity, count, ids_ptr, enabled);
                }
            }
            /// <inheritdoc cref="DebugMessageControl(DebugSource, DebugType, DebugSeverity, int, uint*, bool)"/>
            public static unsafe void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, uint[] ids, bool enabled)
            {
                int count = (int)(ids.Length);
                fixed (uint* ids_ptr = ids)
                {
                    DebugMessageControl(source, type, severity, count, ids_ptr, enabled);
                }
            }
            /// <inheritdoc cref="DebugMessageControl(DebugSource, DebugType, DebugSeverity, int, uint*, bool)"/>
            public static unsafe void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, int count, in uint ids, bool enabled)
            {
                fixed (uint* ids_ptr = &ids)
                {
                    DebugMessageControl(source, type, severity, count, ids_ptr, enabled);
                }
            }
            /// <inheritdoc cref="DebugMessageInsert(DebugSource, DebugType, uint, DebugSeverity, int, byte*)"/>
            public static unsafe void DebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, string buf)
            {
                byte* buf_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(buf);
                DebugMessageInsert(source, type, id, severity, length, buf_ptr);
                Marshal.FreeCoTaskMem((IntPtr)buf_ptr);
            }
            /// <inheritdoc cref="DebugMessageCallback(IntPtr, void*)"/>
            public static unsafe void DebugMessageCallback(GLDebugProc callback, IntPtr userParam)
            {
                void* userParam_vptr = (void*)userParam;
                IntPtr callback_ptr = Marshal.GetFunctionPointerForDelegate(callback);
                DebugMessageCallback(callback_ptr, userParam_vptr);
            }
            /// <inheritdoc cref="DebugMessageCallback(IntPtr, void*)"/>
            public static unsafe void DebugMessageCallback<T1>(GLDebugProc callback, in T1 userParam)
                where T1 : unmanaged
            {
                fixed (void* userParam_ptr = &userParam)
                {
                    IntPtr callback_ptr = Marshal.GetFunctionPointerForDelegate(callback);
                    DebugMessageCallback(callback_ptr, userParam_ptr);
                }
            }
            /// <inheritdoc cref="GetDebugMessageLog(uint, int, DebugSource*, DebugType*, uint*, DebugSeverity*, int*, byte*)"/>
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
            /// <inheritdoc cref="GetDebugMessageLog(uint, int, DebugSource*, DebugType*, uint*, DebugSeverity*, int*, byte*)"/>
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
            /// <inheritdoc cref="GetDebugMessageLog(uint, int, DebugSource*, DebugType*, uint*, DebugSeverity*, int*, byte*)"/>
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
            /// <inheritdoc cref="PushDebugGroup(DebugSource, uint, int, byte*)"/>
            public static unsafe void PushDebugGroup(DebugSource source, uint id, int length, string message)
            {
                byte* message_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(message);
                PushDebugGroup(source, id, length, message_ptr);
                Marshal.FreeCoTaskMem((IntPtr)message_ptr);
            }
            /// <inheritdoc cref="ObjectLabel(ObjectIdentifier, uint, int, byte*)"/>
            public static unsafe void ObjectLabel(ObjectIdentifier identifier, uint name, int length, string label)
            {
                byte* label_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(label);
                ObjectLabel(identifier, name, length, label_ptr);
                Marshal.FreeCoTaskMem((IntPtr)label_ptr);
            }
            /// <inheritdoc cref="GetObjectLabel(ObjectIdentifier, uint, int, int*, byte*)"/>
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
            /// <inheritdoc cref="GetObjectLabel(ObjectIdentifier, uint, int, int*, byte*)"/>
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
            /// <inheritdoc cref="GetObjectLabel(ObjectIdentifier, uint, int, int*, byte*)"/>
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
            /// <inheritdoc cref="GetObjectLabel(ObjectIdentifier, uint, int, int*, byte*)"/>
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
            /// <inheritdoc cref="GetObjectLabel(ObjectIdentifier, uint, int, int*, byte*)"/>
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
            /// <inheritdoc cref="GetObjectLabel(ObjectIdentifier, uint, int, int*, byte*)"/>
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
            /// <inheritdoc cref="ObjectPtrLabel(void*, int, byte*)"/>
            public static unsafe void ObjectPtrLabel(IntPtr ptr, int length, string label)
            {
                byte* label_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(label);
                void* ptr_vptr = (void*)ptr;
                ObjectPtrLabel(ptr_vptr, length, label_ptr);
                Marshal.FreeCoTaskMem((IntPtr)label_ptr);
            }
            /// <inheritdoc cref="ObjectPtrLabel(void*, int, byte*)"/>
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
            /// <inheritdoc cref="GetObjectPtrLabel(void*, int, int*, byte*)"/>
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
            /// <inheritdoc cref="GetObjectPtrLabel(void*, int, int*, byte*)"/>
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
            /// <inheritdoc cref="GetObjectPtrLabel(void*, int, int*, byte*)"/>
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
            /// <inheritdoc cref="GetObjectPtrLabel(void*, int, int*, byte*)"/>
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
            /// <inheritdoc cref="GetObjectPtrLabel(void*, int, int*, byte*)"/>
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
            /// <inheritdoc cref="GetObjectPtrLabel(void*, int, int*, byte*)"/>
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
            /// <inheritdoc cref="GetObjectPtrLabel(void*, int, int*, byte*)"/>
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
            /// <inheritdoc cref="GetObjectPtrLabel(void*, int, int*, byte*)"/>
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
            /// <inheritdoc cref="GetObjectPtrLabel(void*, int, int*, byte*)"/>
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
            /// <inheritdoc cref="GetObjectPtrLabel(void*, int, int*, byte*)"/>
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
            /// <inheritdoc cref="GetObjectPtrLabel(void*, int, int*, byte*)"/>
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
            /// <inheritdoc cref="GetObjectPtrLabel(void*, int, int*, byte*)"/>
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
            /// <inheritdoc cref="GetPointerv(GetPointervPName, void**)"/>
            public static unsafe void GetPointer(GetPointervPName pname, void** parameters)
            {
                GetPointerv(pname, parameters);
            }
            /// <inheritdoc cref="DebugMessageControlKHR(DebugSource, DebugType, DebugSeverity, int, uint*, bool)"/>
            public static unsafe void DebugMessageControlKHR(DebugSource source, DebugType type, DebugSeverity severity, int count, in uint ids, bool enabled)
            {
                fixed (uint* ids_ptr = &ids)
                {
                    DebugMessageControlKHR(source, type, severity, count, ids_ptr, enabled);
                }
            }
            /// <inheritdoc cref="DebugMessageInsertKHR(DebugSource, DebugType, uint, DebugSeverity, int, byte*)"/>
            public static unsafe void DebugMessageInsertKHR(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, string buf)
            {
                byte* buf_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(buf);
                DebugMessageInsertKHR(source, type, id, severity, length, buf_ptr);
                Marshal.FreeCoTaskMem((IntPtr)buf_ptr);
            }
            /// <inheritdoc cref="DebugMessageCallbackKHR(IntPtr, void*)"/>
            public static unsafe void DebugMessageCallbackKHR(GLDebugProcKHR callback, IntPtr userParam)
            {
                void* userParam_vptr = (void*)userParam;
                IntPtr callback_ptr = Marshal.GetFunctionPointerForDelegate(callback);
                DebugMessageCallbackKHR(callback_ptr, userParam_vptr);
            }
            /// <inheritdoc cref="DebugMessageCallbackKHR(IntPtr, void*)"/>
            public static unsafe void DebugMessageCallbackKHR<T1>(GLDebugProcKHR callback, in T1 userParam)
                where T1 : unmanaged
            {
                fixed (void* userParam_ptr = &userParam)
                {
                    IntPtr callback_ptr = Marshal.GetFunctionPointerForDelegate(callback);
                    DebugMessageCallbackKHR(callback_ptr, userParam_ptr);
                }
            }
            /// <inheritdoc cref="GetDebugMessageLogKHR(uint, int, DebugSource*, DebugType*, uint*, DebugSeverity*, int*, byte*)"/>
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
            /// <inheritdoc cref="GetDebugMessageLogKHR(uint, int, DebugSource*, DebugType*, uint*, DebugSeverity*, int*, byte*)"/>
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
            /// <inheritdoc cref="GetDebugMessageLogKHR(uint, int, DebugSource*, DebugType*, uint*, DebugSeverity*, int*, byte*)"/>
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
            /// <inheritdoc cref="PushDebugGroupKHR(DebugSource, uint, int, byte*)"/>
            public static unsafe void PushDebugGroupKHR(DebugSource source, uint id, int length, string message)
            {
                byte* message_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(message);
                PushDebugGroupKHR(source, id, length, message_ptr);
                Marshal.FreeCoTaskMem((IntPtr)message_ptr);
            }
            /// <inheritdoc cref="ObjectLabelKHR(ObjectIdentifier, uint, int, byte*)"/>
            public static unsafe void ObjectLabelKHR(ObjectIdentifier identifier, uint name, int length, string label)
            {
                byte* label_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(label);
                ObjectLabelKHR(identifier, name, length, label_ptr);
                Marshal.FreeCoTaskMem((IntPtr)label_ptr);
            }
            /// <inheritdoc cref="GetObjectLabelKHR(All, uint, int, int*, byte*)"/>
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
            /// <inheritdoc cref="GetObjectLabelKHR(All, uint, int, int*, byte*)"/>
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
            /// <inheritdoc cref="ObjectPtrLabelKHR(void*, int, byte*)"/>
            public static unsafe void ObjectPtrLabelKHR(IntPtr ptr, int length, string label)
            {
                byte* label_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(label);
                void* ptr_vptr = (void*)ptr;
                ObjectPtrLabelKHR(ptr_vptr, length, label_ptr);
                Marshal.FreeCoTaskMem((IntPtr)label_ptr);
            }
            /// <inheritdoc cref="ObjectPtrLabelKHR(void*, int, byte*)"/>
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
            /// <inheritdoc cref="GetObjectPtrLabelKHR(void*, int, int*, byte*)"/>
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
            /// <inheritdoc cref="GetObjectPtrLabelKHR(void*, int, int*, byte*)"/>
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
            /// <inheritdoc cref="GetObjectPtrLabelKHR(void*, int, int*, byte*)"/>
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
            /// <inheritdoc cref="GetObjectPtrLabelKHR(void*, int, int*, byte*)"/>
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
            /// <inheritdoc cref="GetObjectPtrLabelKHR(void*, int, int*, byte*)"/>
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
            /// <inheritdoc cref="GetObjectPtrLabelKHR(void*, int, int*, byte*)"/>
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
            /// <inheritdoc cref="GetObjectPtrLabelKHR(void*, int, int*, byte*)"/>
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
            /// <inheritdoc cref="GetObjectPtrLabelKHR(void*, int, int*, byte*)"/>
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
            /// <inheritdoc cref="GetObjectPtrLabelKHR(void*, int, int*, byte*)"/>
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
            /// <inheritdoc cref="GetObjectPtrLabelKHR(void*, int, int*, byte*)"/>
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
            /// <inheritdoc cref="GetObjectPtrLabelKHR(void*, int, int*, byte*)"/>
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
            /// <inheritdoc cref="GetObjectPtrLabelKHR(void*, int, int*, byte*)"/>
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
            /// <inheritdoc cref="DeleteFences(int, uint*)"/>
            public static unsafe void DeleteFences(ReadOnlySpan<uint> fences)
            {
                int n = (int)(fences.Length);
                fixed (uint* fences_ptr = fences)
                {
                    DeleteFences(n, fences_ptr);
                }
            }
            /// <inheritdoc cref="DeleteFences(int, uint*)"/>
            public static unsafe void DeleteFences(uint[] fences)
            {
                int n = (int)(fences.Length);
                fixed (uint* fences_ptr = fences)
                {
                    DeleteFences(n, fences_ptr);
                }
            }
            /// <inheritdoc cref="DeleteFences(int, uint*)"/>
            public static unsafe void DeleteFences(int n, in uint fences)
            {
                fixed (uint* fences_ptr = &fences)
                {
                    DeleteFences(n, fences_ptr);
                }
            }
            /// <inheritdoc cref="GenFences(int, uint*)"/>
            public static unsafe void GenFences(Span<uint> fences)
            {
                int n = (int)(fences.Length);
                fixed (uint* fences_ptr = fences)
                {
                    GenFences(n, fences_ptr);
                }
            }
            /// <inheritdoc cref="GenFences(int, uint*)"/>
            public static unsafe void GenFences(uint[] fences)
            {
                int n = (int)(fences.Length);
                fixed (uint* fences_ptr = fences)
                {
                    GenFences(n, fences_ptr);
                }
            }
            /// <inheritdoc cref="GenFences(int, uint*)"/>
            public static unsafe void GenFences(int n, ref uint fences)
            {
                fixed (uint* fences_ptr = &fences)
                {
                    GenFences(n, fences_ptr);
                }
            }
            /// <inheritdoc cref="GetFenceiv(uint, FenceParameterNameNV, int*)"/>
            public static unsafe void GetFenceiv(uint fence, FenceParameterNameNV pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetFenceiv(fence, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetFenceiv(uint, FenceParameterNameNV, int*)"/>
            public static unsafe void GetFenceiv(uint fence, FenceParameterNameNV pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetFenceiv(fence, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetFenceiv(uint, FenceParameterNameNV, int*)"/>
            public static unsafe void GetFenceiv(uint fence, FenceParameterNameNV pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetFenceiv(fence, pname, parameters_ptr);
                }
            }
        }
        public static unsafe partial class OES
        {
            /// <inheritdoc cref="EGLImageTargetTexture2D(All, void*)"/>
            public static unsafe void EGLImageTargetTexture2D(All target, IntPtr image)
            {
                void* image_vptr = (void*)image;
                EGLImageTargetTexture2D(target, image_vptr);
            }
            /// <inheritdoc cref="EGLImageTargetTexture2D(All, void*)"/>
            public static unsafe void EGLImageTargetTexture2D<T1>(All target, ref T1 image)
                where T1 : unmanaged
            {
                fixed (void* image_ptr = &image)
                {
                    EGLImageTargetTexture2D(target, image_ptr);
                }
            }
            /// <inheritdoc cref="EGLImageTargetRenderbufferStorage(All, void*)"/>
            public static unsafe void EGLImageTargetRenderbufferStorage(All target, IntPtr image)
            {
                void* image_vptr = (void*)image;
                EGLImageTargetRenderbufferStorage(target, image_vptr);
            }
            /// <inheritdoc cref="EGLImageTargetRenderbufferStorage(All, void*)"/>
            public static unsafe void EGLImageTargetRenderbufferStorage<T1>(All target, ref T1 image)
                where T1 : unmanaged
            {
                fixed (void* image_ptr = &image)
                {
                    EGLImageTargetRenderbufferStorage(target, image_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord1bv(TextureUnit, sbyte*)"/>
            public static unsafe void MultiTexCoord1bv(TextureUnit texture, ReadOnlySpan<sbyte> coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    MultiTexCoord1bv(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord1bv(TextureUnit, sbyte*)"/>
            public static unsafe void MultiTexCoord1bv(TextureUnit texture, sbyte[] coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    MultiTexCoord1bv(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord1bv(TextureUnit, sbyte*)"/>
            public static unsafe void MultiTexCoord1bv(TextureUnit texture, in sbyte coords)
            {
                fixed (sbyte* coords_ptr = &coords)
                {
                    MultiTexCoord1bv(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord2bv(TextureUnit, sbyte*)"/>
            public static unsafe void MultiTexCoord2bv(TextureUnit texture, ReadOnlySpan<sbyte> coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    MultiTexCoord2bv(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord2bv(TextureUnit, sbyte*)"/>
            public static unsafe void MultiTexCoord2bv(TextureUnit texture, sbyte[] coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    MultiTexCoord2bv(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord2bv(TextureUnit, sbyte*)"/>
            public static unsafe void MultiTexCoord2bv(TextureUnit texture, in sbyte coords)
            {
                fixed (sbyte* coords_ptr = &coords)
                {
                    MultiTexCoord2bv(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord3bv(TextureUnit, sbyte*)"/>
            public static unsafe void MultiTexCoord3bv(TextureUnit texture, ReadOnlySpan<sbyte> coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    MultiTexCoord3bv(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord3bv(TextureUnit, sbyte*)"/>
            public static unsafe void MultiTexCoord3bv(TextureUnit texture, sbyte[] coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    MultiTexCoord3bv(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord3bv(TextureUnit, sbyte*)"/>
            public static unsafe void MultiTexCoord3bv(TextureUnit texture, in sbyte coords)
            {
                fixed (sbyte* coords_ptr = &coords)
                {
                    MultiTexCoord3bv(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord4bv(TextureUnit, sbyte*)"/>
            public static unsafe void MultiTexCoord4bv(TextureUnit texture, ReadOnlySpan<sbyte> coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    MultiTexCoord4bv(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord4bv(TextureUnit, sbyte*)"/>
            public static unsafe void MultiTexCoord4bv(TextureUnit texture, sbyte[] coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    MultiTexCoord4bv(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord4bv(TextureUnit, sbyte*)"/>
            public static unsafe void MultiTexCoord4bv(TextureUnit texture, in sbyte coords)
            {
                fixed (sbyte* coords_ptr = &coords)
                {
                    MultiTexCoord4bv(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord1bv(sbyte*)"/>
            public static unsafe void TexCoord1bv(ReadOnlySpan<sbyte> coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    TexCoord1bv(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord1bv(sbyte*)"/>
            public static unsafe void TexCoord1bv(sbyte[] coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    TexCoord1bv(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord1bv(sbyte*)"/>
            public static unsafe void TexCoord1bv(in sbyte coords)
            {
                fixed (sbyte* coords_ptr = &coords)
                {
                    TexCoord1bv(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord2bv(sbyte*)"/>
            public static unsafe void TexCoord2bv(ReadOnlySpan<sbyte> coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    TexCoord2bv(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord2bv(sbyte*)"/>
            public static unsafe void TexCoord2bv(sbyte[] coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    TexCoord2bv(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord2bv(sbyte*)"/>
            public static unsafe void TexCoord2bv(in sbyte coords)
            {
                fixed (sbyte* coords_ptr = &coords)
                {
                    TexCoord2bv(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord3bv(sbyte*)"/>
            public static unsafe void TexCoord3bv(ReadOnlySpan<sbyte> coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    TexCoord3bv(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord3bv(sbyte*)"/>
            public static unsafe void TexCoord3bv(sbyte[] coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    TexCoord3bv(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord3bv(sbyte*)"/>
            public static unsafe void TexCoord3bv(in sbyte coords)
            {
                fixed (sbyte* coords_ptr = &coords)
                {
                    TexCoord3bv(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord4bv(sbyte*)"/>
            public static unsafe void TexCoord4bv(ReadOnlySpan<sbyte> coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    TexCoord4bv(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord4bv(sbyte*)"/>
            public static unsafe void TexCoord4bv(sbyte[] coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    TexCoord4bv(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord4bv(sbyte*)"/>
            public static unsafe void TexCoord4bv(in sbyte coords)
            {
                fixed (sbyte* coords_ptr = &coords)
                {
                    TexCoord4bv(coords_ptr);
                }
            }
            /// <inheritdoc cref="Vertex2bv(sbyte*)"/>
            public static unsafe void Vertex2bv(ReadOnlySpan<sbyte> coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    Vertex2bv(coords_ptr);
                }
            }
            /// <inheritdoc cref="Vertex2bv(sbyte*)"/>
            public static unsafe void Vertex2bv(sbyte[] coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    Vertex2bv(coords_ptr);
                }
            }
            /// <inheritdoc cref="Vertex2bv(sbyte*)"/>
            public static unsafe void Vertex2bv(in sbyte coords)
            {
                fixed (sbyte* coords_ptr = &coords)
                {
                    Vertex2bv(coords_ptr);
                }
            }
            /// <inheritdoc cref="Vertex3bv(sbyte*)"/>
            public static unsafe void Vertex3bv(ReadOnlySpan<sbyte> coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    Vertex3bv(coords_ptr);
                }
            }
            /// <inheritdoc cref="Vertex3bv(sbyte*)"/>
            public static unsafe void Vertex3bv(sbyte[] coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    Vertex3bv(coords_ptr);
                }
            }
            /// <inheritdoc cref="Vertex3bv(sbyte*)"/>
            public static unsafe void Vertex3bv(in sbyte coords)
            {
                fixed (sbyte* coords_ptr = &coords)
                {
                    Vertex3bv(coords_ptr);
                }
            }
            /// <inheritdoc cref="Vertex4bv(sbyte*)"/>
            public static unsafe void Vertex4bv(ReadOnlySpan<sbyte> coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    Vertex4bv(coords_ptr);
                }
            }
            /// <inheritdoc cref="Vertex4bv(sbyte*)"/>
            public static unsafe void Vertex4bv(sbyte[] coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    Vertex4bv(coords_ptr);
                }
            }
            /// <inheritdoc cref="Vertex4bv(sbyte*)"/>
            public static unsafe void Vertex4bv(in sbyte coords)
            {
                fixed (sbyte* coords_ptr = &coords)
                {
                    Vertex4bv(coords_ptr);
                }
            }
            /// <inheritdoc cref="DrawTexsv(short*)"/>
            public static unsafe void DrawTexsv(ReadOnlySpan<short> coords)
            {
                fixed (short* coords_ptr = coords)
                {
                    DrawTexsv(coords_ptr);
                }
            }
            /// <inheritdoc cref="DrawTexsv(short*)"/>
            public static unsafe void DrawTexsv(short[] coords)
            {
                fixed (short* coords_ptr = coords)
                {
                    DrawTexsv(coords_ptr);
                }
            }
            /// <inheritdoc cref="DrawTexsv(short*)"/>
            public static unsafe void DrawTexsv(in short coords)
            {
                fixed (short* coords_ptr = &coords)
                {
                    DrawTexsv(coords_ptr);
                }
            }
            /// <inheritdoc cref="DrawTexiv(int*)"/>
            public static unsafe void DrawTexiv(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    DrawTexiv(coords_ptr);
                }
            }
            /// <inheritdoc cref="DrawTexiv(int*)"/>
            public static unsafe void DrawTexiv(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    DrawTexiv(coords_ptr);
                }
            }
            /// <inheritdoc cref="DrawTexiv(int*)"/>
            public static unsafe void DrawTexiv(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    DrawTexiv(coords_ptr);
                }
            }
            /// <inheritdoc cref="DrawTexxv(int*)"/>
            public static unsafe void DrawTexxv(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    DrawTexxv(coords_ptr);
                }
            }
            /// <inheritdoc cref="DrawTexxv(int*)"/>
            public static unsafe void DrawTexxv(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    DrawTexxv(coords_ptr);
                }
            }
            /// <inheritdoc cref="DrawTexxv(int*)"/>
            public static unsafe void DrawTexxv(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    DrawTexxv(coords_ptr);
                }
            }
            /// <inheritdoc cref="DrawTexfv(float*)"/>
            public static unsafe void DrawTexfv(ReadOnlySpan<float> coords)
            {
                fixed (float* coords_ptr = coords)
                {
                    DrawTexfv(coords_ptr);
                }
            }
            /// <inheritdoc cref="DrawTexfv(float*)"/>
            public static unsafe void DrawTexfv(float[] coords)
            {
                fixed (float* coords_ptr = coords)
                {
                    DrawTexfv(coords_ptr);
                }
            }
            /// <inheritdoc cref="DrawTexfv(float*)"/>
            public static unsafe void DrawTexfv(in float coords)
            {
                fixed (float* coords_ptr = &coords)
                {
                    DrawTexfv(coords_ptr);
                }
            }
            /// <inheritdoc cref="ClipPlanex(ClipPlaneName, int*)"/>
            public static unsafe void ClipPlanex(ClipPlaneName plane, ReadOnlySpan<int> equation)
            {
                fixed (int* equation_ptr = equation)
                {
                    ClipPlanex(plane, equation_ptr);
                }
            }
            /// <inheritdoc cref="ClipPlanex(ClipPlaneName, int*)"/>
            public static unsafe void ClipPlanex(ClipPlaneName plane, int[] equation)
            {
                fixed (int* equation_ptr = equation)
                {
                    ClipPlanex(plane, equation_ptr);
                }
            }
            /// <inheritdoc cref="ClipPlanex(ClipPlaneName, int*)"/>
            public static unsafe void ClipPlanex(ClipPlaneName plane, in int equation)
            {
                fixed (int* equation_ptr = &equation)
                {
                    ClipPlanex(plane, equation_ptr);
                }
            }
            /// <inheritdoc cref="Fogxv(FogPName, int*)"/>
            public static unsafe void Fogxv(FogPName pname, ReadOnlySpan<int> param)
            {
                fixed (int* param_ptr = param)
                {
                    Fogxv(pname, param_ptr);
                }
            }
            /// <inheritdoc cref="Fogxv(FogPName, int*)"/>
            public static unsafe void Fogxv(FogPName pname, int[] param)
            {
                fixed (int* param_ptr = param)
                {
                    Fogxv(pname, param_ptr);
                }
            }
            /// <inheritdoc cref="Fogxv(FogPName, int*)"/>
            public static unsafe void Fogxv(FogPName pname, in int param)
            {
                fixed (int* param_ptr = &param)
                {
                    Fogxv(pname, param_ptr);
                }
            }
            /// <inheritdoc cref="GetClipPlanex(ClipPlaneName, int*)"/>
            public static unsafe void GetClipPlanex(ClipPlaneName plane, Span<int> equation)
            {
                fixed (int* equation_ptr = equation)
                {
                    GetClipPlanex(plane, equation_ptr);
                }
            }
            /// <inheritdoc cref="GetClipPlanex(ClipPlaneName, int*)"/>
            public static unsafe void GetClipPlanex(ClipPlaneName plane, int[] equation)
            {
                fixed (int* equation_ptr = equation)
                {
                    GetClipPlanex(plane, equation_ptr);
                }
            }
            /// <inheritdoc cref="GetClipPlanex(ClipPlaneName, int*)"/>
            public static unsafe void GetClipPlanex(ClipPlaneName plane, ref int equation)
            {
                fixed (int* equation_ptr = &equation)
                {
                    GetClipPlanex(plane, equation_ptr);
                }
            }
            /// <inheritdoc cref="GetFixedv(GetPName, int*)"/>
            public static unsafe void GetFixedv(GetPName pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetFixedv(pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetFixedv(GetPName, int*)"/>
            public static unsafe void GetFixedv(GetPName pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetFixedv(pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetFixedv(GetPName, int*)"/>
            public static unsafe void GetFixedv(GetPName pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetFixedv(pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexEnvxv(TextureEnvTarget, TextureEnvParameter, int*)"/>
            public static unsafe void GetTexEnvxv(TextureEnvTarget target, TextureEnvParameter pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexEnvxv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexEnvxv(TextureEnvTarget, TextureEnvParameter, int*)"/>
            public static unsafe void GetTexEnvxv(TextureEnvTarget target, TextureEnvParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexEnvxv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexEnvxv(TextureEnvTarget, TextureEnvParameter, int*)"/>
            public static unsafe void GetTexEnvxv(TextureEnvTarget target, TextureEnvParameter pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetTexEnvxv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexParameterxv(TextureTarget, GetTextureParameter, int*)"/>
            public static unsafe void GetTexParameterxv(TextureTarget target, GetTextureParameter pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexParameterxv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexParameterxv(TextureTarget, GetTextureParameter, int*)"/>
            public static unsafe void GetTexParameterxv(TextureTarget target, GetTextureParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexParameterxv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexParameterxv(TextureTarget, GetTextureParameter, int*)"/>
            public static unsafe void GetTexParameterxv(TextureTarget target, GetTextureParameter pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetTexParameterxv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="LightModelxv(LightModelParameter, int*)"/>
            public static unsafe void LightModelxv(LightModelParameter pname, ReadOnlySpan<int> param)
            {
                fixed (int* param_ptr = param)
                {
                    LightModelxv(pname, param_ptr);
                }
            }
            /// <inheritdoc cref="LightModelxv(LightModelParameter, int*)"/>
            public static unsafe void LightModelxv(LightModelParameter pname, int[] param)
            {
                fixed (int* param_ptr = param)
                {
                    LightModelxv(pname, param_ptr);
                }
            }
            /// <inheritdoc cref="LightModelxv(LightModelParameter, int*)"/>
            public static unsafe void LightModelxv(LightModelParameter pname, in int param)
            {
                fixed (int* param_ptr = &param)
                {
                    LightModelxv(pname, param_ptr);
                }
            }
            /// <inheritdoc cref="Lightxv(LightName, LightParameter, int*)"/>
            public static unsafe void Lightxv(LightName light, LightParameter pname, ReadOnlySpan<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    Lightxv(light, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="Lightxv(LightName, LightParameter, int*)"/>
            public static unsafe void Lightxv(LightName light, LightParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    Lightxv(light, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="Lightxv(LightName, LightParameter, int*)"/>
            public static unsafe void Lightxv(LightName light, LightParameter pname, in int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    Lightxv(light, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="LoadMatrixx(int*)"/>
            public static unsafe void LoadMatrixx(ReadOnlySpan<int> m)
            {
                fixed (int* m_ptr = m)
                {
                    LoadMatrixx(m_ptr);
                }
            }
            /// <inheritdoc cref="LoadMatrixx(int*)"/>
            public static unsafe void LoadMatrixx(int[] m)
            {
                fixed (int* m_ptr = m)
                {
                    LoadMatrixx(m_ptr);
                }
            }
            /// <inheritdoc cref="LoadMatrixx(int*)"/>
            public static unsafe void LoadMatrixx(in int m)
            {
                fixed (int* m_ptr = &m)
                {
                    LoadMatrixx(m_ptr);
                }
            }
            /// <inheritdoc cref="Materialxv(TriangleFace, MaterialParameter, int*)"/>
            public static unsafe void Materialxv(TriangleFace face, MaterialParameter pname, ReadOnlySpan<int> param)
            {
                fixed (int* param_ptr = param)
                {
                    Materialxv(face, pname, param_ptr);
                }
            }
            /// <inheritdoc cref="Materialxv(TriangleFace, MaterialParameter, int*)"/>
            public static unsafe void Materialxv(TriangleFace face, MaterialParameter pname, int[] param)
            {
                fixed (int* param_ptr = param)
                {
                    Materialxv(face, pname, param_ptr);
                }
            }
            /// <inheritdoc cref="Materialxv(TriangleFace, MaterialParameter, int*)"/>
            public static unsafe void Materialxv(TriangleFace face, MaterialParameter pname, in int param)
            {
                fixed (int* param_ptr = &param)
                {
                    Materialxv(face, pname, param_ptr);
                }
            }
            /// <inheritdoc cref="MultMatrixx(int*)"/>
            public static unsafe void MultMatrixx(ReadOnlySpan<int> m)
            {
                fixed (int* m_ptr = m)
                {
                    MultMatrixx(m_ptr);
                }
            }
            /// <inheritdoc cref="MultMatrixx(int*)"/>
            public static unsafe void MultMatrixx(int[] m)
            {
                fixed (int* m_ptr = m)
                {
                    MultMatrixx(m_ptr);
                }
            }
            /// <inheritdoc cref="MultMatrixx(int*)"/>
            public static unsafe void MultMatrixx(in int m)
            {
                fixed (int* m_ptr = &m)
                {
                    MultMatrixx(m_ptr);
                }
            }
            /// <inheritdoc cref="PointParameterxv(PointParameterNameARB, int*)"/>
            public static unsafe void PointParameterxv(PointParameterNameARB pname, ReadOnlySpan<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    PointParameterxv(pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="PointParameterxv(PointParameterNameARB, int*)"/>
            public static unsafe void PointParameterxv(PointParameterNameARB pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    PointParameterxv(pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="PointParameterxv(PointParameterNameARB, int*)"/>
            public static unsafe void PointParameterxv(PointParameterNameARB pname, in int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    PointParameterxv(pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexEnvxv(TextureEnvTarget, TextureEnvParameter, int*)"/>
            public static unsafe void TexEnvxv(TextureEnvTarget target, TextureEnvParameter pname, ReadOnlySpan<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    TexEnvxv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexEnvxv(TextureEnvTarget, TextureEnvParameter, int*)"/>
            public static unsafe void TexEnvxv(TextureEnvTarget target, TextureEnvParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    TexEnvxv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexEnvxv(TextureEnvTarget, TextureEnvParameter, int*)"/>
            public static unsafe void TexEnvxv(TextureEnvTarget target, TextureEnvParameter pname, in int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    TexEnvxv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexParameterxv(TextureTarget, GetTextureParameter, int*)"/>
            public static unsafe void TexParameterxv(TextureTarget target, GetTextureParameter pname, ReadOnlySpan<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    TexParameterxv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexParameterxv(TextureTarget, GetTextureParameter, int*)"/>
            public static unsafe void TexParameterxv(TextureTarget target, GetTextureParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    TexParameterxv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexParameterxv(TextureTarget, GetTextureParameter, int*)"/>
            public static unsafe void TexParameterxv(TextureTarget target, GetTextureParameter pname, in int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    TexParameterxv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetLightxv(LightName, LightParameter, int*)"/>
            public static unsafe void GetLightxv(LightName light, LightParameter pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetLightxv(light, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetLightxv(LightName, LightParameter, int*)"/>
            public static unsafe void GetLightxv(LightName light, LightParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetLightxv(light, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetLightxv(LightName, LightParameter, int*)"/>
            public static unsafe void GetLightxv(LightName light, LightParameter pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetLightxv(light, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetMaterialxv(TriangleFace, MaterialParameter, int*)"/>
            public static unsafe void GetMaterialxv(TriangleFace face, MaterialParameter pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetMaterialxv(face, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetMaterialxv(TriangleFace, MaterialParameter, int*)"/>
            public static unsafe void GetMaterialxv(TriangleFace face, MaterialParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetMaterialxv(face, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetMaterialxv(TriangleFace, MaterialParameter, int*)"/>
            public static unsafe void GetMaterialxv(TriangleFace face, MaterialParameter pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetMaterialxv(face, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="Bitmapx(int, int, int, int, int, int, byte*)"/>
            public static unsafe void Bitmapx(int width, int height, int xorig, int yorig, int xmove, int ymove, ReadOnlySpan<byte> bitmap)
            {
                fixed (byte* bitmap_ptr = bitmap)
                {
                    Bitmapx(width, height, xorig, yorig, xmove, ymove, bitmap_ptr);
                }
            }
            /// <inheritdoc cref="Bitmapx(int, int, int, int, int, int, byte*)"/>
            public static unsafe void Bitmapx(int width, int height, int xorig, int yorig, int xmove, int ymove, byte[] bitmap)
            {
                fixed (byte* bitmap_ptr = bitmap)
                {
                    Bitmapx(width, height, xorig, yorig, xmove, ymove, bitmap_ptr);
                }
            }
            /// <inheritdoc cref="Bitmapx(int, int, int, int, int, int, byte*)"/>
            public static unsafe void Bitmapx(int width, int height, int xorig, int yorig, int xmove, int ymove, in byte bitmap)
            {
                fixed (byte* bitmap_ptr = &bitmap)
                {
                    Bitmapx(width, height, xorig, yorig, xmove, ymove, bitmap_ptr);
                }
            }
            /// <inheritdoc cref="Color3xv(int*)"/>
            public static unsafe void Color3xv(ReadOnlySpan<int> components)
            {
                fixed (int* components_ptr = components)
                {
                    Color3xv(components_ptr);
                }
            }
            /// <inheritdoc cref="Color3xv(int*)"/>
            public static unsafe void Color3xv(int[] components)
            {
                fixed (int* components_ptr = components)
                {
                    Color3xv(components_ptr);
                }
            }
            /// <inheritdoc cref="Color3xv(int*)"/>
            public static unsafe void Color3xv(in int components)
            {
                fixed (int* components_ptr = &components)
                {
                    Color3xv(components_ptr);
                }
            }
            /// <inheritdoc cref="Color4xv(int*)"/>
            public static unsafe void Color4xv(ReadOnlySpan<int> components)
            {
                fixed (int* components_ptr = components)
                {
                    Color4xv(components_ptr);
                }
            }
            /// <inheritdoc cref="Color4xv(int*)"/>
            public static unsafe void Color4xv(int[] components)
            {
                fixed (int* components_ptr = components)
                {
                    Color4xv(components_ptr);
                }
            }
            /// <inheritdoc cref="Color4xv(int*)"/>
            public static unsafe void Color4xv(in int components)
            {
                fixed (int* components_ptr = &components)
                {
                    Color4xv(components_ptr);
                }
            }
            /// <inheritdoc cref="ConvolutionParameterxv(ConvolutionTargetEXT, ConvolutionParameter, int*)"/>
            public static unsafe void ConvolutionParameterxv(ConvolutionTargetEXT target, ConvolutionParameter pname, ReadOnlySpan<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    ConvolutionParameterxv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="ConvolutionParameterxv(ConvolutionTargetEXT, ConvolutionParameter, int*)"/>
            public static unsafe void ConvolutionParameterxv(ConvolutionTargetEXT target, ConvolutionParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    ConvolutionParameterxv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="ConvolutionParameterxv(ConvolutionTargetEXT, ConvolutionParameter, int*)"/>
            public static unsafe void ConvolutionParameterxv(ConvolutionTargetEXT target, ConvolutionParameter pname, in int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    ConvolutionParameterxv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="EvalCoord1xv(int*)"/>
            public static unsafe void EvalCoord1xv(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    EvalCoord1xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="EvalCoord1xv(int*)"/>
            public static unsafe void EvalCoord1xv(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    EvalCoord1xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="EvalCoord1xv(int*)"/>
            public static unsafe void EvalCoord1xv(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    EvalCoord1xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="EvalCoord2xv(int*)"/>
            public static unsafe void EvalCoord2xv(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    EvalCoord2xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="EvalCoord2xv(int*)"/>
            public static unsafe void EvalCoord2xv(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    EvalCoord2xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="EvalCoord2xv(int*)"/>
            public static unsafe void EvalCoord2xv(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    EvalCoord2xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="FeedbackBufferx(int, All, int*)"/>
            public static unsafe void FeedbackBufferx(All type, ReadOnlySpan<int> buffer)
            {
                int n = (int)(buffer.Length);
                fixed (int* buffer_ptr = buffer)
                {
                    FeedbackBufferx(n, type, buffer_ptr);
                }
            }
            /// <inheritdoc cref="FeedbackBufferx(int, All, int*)"/>
            public static unsafe void FeedbackBufferx(All type, int[] buffer)
            {
                int n = (int)(buffer.Length);
                fixed (int* buffer_ptr = buffer)
                {
                    FeedbackBufferx(n, type, buffer_ptr);
                }
            }
            /// <inheritdoc cref="FeedbackBufferx(int, All, int*)"/>
            public static unsafe void FeedbackBufferx(int n, All type, in int buffer)
            {
                fixed (int* buffer_ptr = &buffer)
                {
                    FeedbackBufferx(n, type, buffer_ptr);
                }
            }
            /// <inheritdoc cref="GetConvolutionParameterxv(All, All, int*)"/>
            public static unsafe void GetConvolutionParameterxv(All target, All pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetConvolutionParameterxv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetConvolutionParameterxv(All, All, int*)"/>
            public static unsafe void GetConvolutionParameterxv(All target, All pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetConvolutionParameterxv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetConvolutionParameterxv(All, All, int*)"/>
            public static unsafe void GetConvolutionParameterxv(All target, All pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetConvolutionParameterxv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetHistogramParameterxv(HistogramTargetEXT, GetHistogramParameterPNameEXT, int*)"/>
            public static unsafe void GetHistogramParameterxv(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetHistogramParameterxv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetHistogramParameterxv(HistogramTargetEXT, GetHistogramParameterPNameEXT, int*)"/>
            public static unsafe void GetHistogramParameterxv(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetHistogramParameterxv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetHistogramParameterxv(HistogramTargetEXT, GetHistogramParameterPNameEXT, int*)"/>
            public static unsafe void GetHistogramParameterxv(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetHistogramParameterxv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetLightx(LightName, LightParameter, int*)"/>
            public static unsafe void GetLightx(LightName light, LightParameter pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetLightx(light, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetLightx(LightName, LightParameter, int*)"/>
            public static unsafe void GetLightx(LightName light, LightParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetLightx(light, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetLightx(LightName, LightParameter, int*)"/>
            public static unsafe void GetLightx(LightName light, LightParameter pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetLightx(light, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetMapxv(MapTarget, GetMapQuery, int*)"/>
            public static unsafe void GetMapxv(MapTarget target, GetMapQuery query, Span<int> v)
            {
                fixed (int* v_ptr = v)
                {
                    GetMapxv(target, query, v_ptr);
                }
            }
            /// <inheritdoc cref="GetMapxv(MapTarget, GetMapQuery, int*)"/>
            public static unsafe void GetMapxv(MapTarget target, GetMapQuery query, int[] v)
            {
                fixed (int* v_ptr = v)
                {
                    GetMapxv(target, query, v_ptr);
                }
            }
            /// <inheritdoc cref="GetMapxv(MapTarget, GetMapQuery, int*)"/>
            public static unsafe void GetMapxv(MapTarget target, GetMapQuery query, ref int v)
            {
                fixed (int* v_ptr = &v)
                {
                    GetMapxv(target, query, v_ptr);
                }
            }
            /// <inheritdoc cref="GetPixelMapxv(PixelMap, int, int*)"/>
            public static unsafe void GetPixelMapx(PixelMap map, Span<int> values)
            {
                int size = (int)(values.Length);
                fixed (int* values_ptr = values)
                {
                    GetPixelMapxv(map, size, values_ptr);
                }
            }
            /// <inheritdoc cref="GetPixelMapxv(PixelMap, int, int*)"/>
            public static unsafe void GetPixelMapx(PixelMap map, int[] values)
            {
                int size = (int)(values.Length);
                fixed (int* values_ptr = values)
                {
                    GetPixelMapxv(map, size, values_ptr);
                }
            }
            /// <inheritdoc cref="GetPixelMapxv(PixelMap, int, int*)"/>
            public static unsafe void GetPixelMapx(PixelMap map, int size, ref int values)
            {
                fixed (int* values_ptr = &values)
                {
                    GetPixelMapxv(map, size, values_ptr);
                }
            }
            /// <inheritdoc cref="GetTexGenxv(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe void GetTexGenxv(TextureCoordName coord, TextureGenParameter pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexGenxv(coord, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexGenxv(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe void GetTexGenxv(TextureCoordName coord, TextureGenParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexGenxv(coord, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexGenxv(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe void GetTexGenxv(TextureCoordName coord, TextureGenParameter pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetTexGenxv(coord, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexLevelParameterxv(TextureTarget, int, GetTextureParameter, int*)"/>
            public static unsafe void GetTexLevelParameterxv(TextureTarget target, int level, GetTextureParameter pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexLevelParameterxv(target, level, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexLevelParameterxv(TextureTarget, int, GetTextureParameter, int*)"/>
            public static unsafe void GetTexLevelParameterxv(TextureTarget target, int level, GetTextureParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexLevelParameterxv(target, level, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexLevelParameterxv(TextureTarget, int, GetTextureParameter, int*)"/>
            public static unsafe void GetTexLevelParameterxv(TextureTarget target, int level, GetTextureParameter pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetTexLevelParameterxv(target, level, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="Indexxv(int*)"/>
            public static unsafe void Indexxv(ReadOnlySpan<int> component)
            {
                fixed (int* component_ptr = component)
                {
                    Indexxv(component_ptr);
                }
            }
            /// <inheritdoc cref="Indexxv(int*)"/>
            public static unsafe void Indexxv(int[] component)
            {
                fixed (int* component_ptr = component)
                {
                    Indexxv(component_ptr);
                }
            }
            /// <inheritdoc cref="Indexxv(int*)"/>
            public static unsafe void Indexxv(in int component)
            {
                fixed (int* component_ptr = &component)
                {
                    Indexxv(component_ptr);
                }
            }
            /// <inheritdoc cref="LoadTransposeMatrixx(int*)"/>
            public static unsafe void LoadTransposeMatrixx(ReadOnlySpan<int> m)
            {
                fixed (int* m_ptr = m)
                {
                    LoadTransposeMatrixx(m_ptr);
                }
            }
            /// <inheritdoc cref="LoadTransposeMatrixx(int*)"/>
            public static unsafe void LoadTransposeMatrixx(int[] m)
            {
                fixed (int* m_ptr = m)
                {
                    LoadTransposeMatrixx(m_ptr);
                }
            }
            /// <inheritdoc cref="LoadTransposeMatrixx(int*)"/>
            public static unsafe void LoadTransposeMatrixx(in int m)
            {
                fixed (int* m_ptr = &m)
                {
                    LoadTransposeMatrixx(m_ptr);
                }
            }
            /// <inheritdoc cref="MultTransposeMatrixx(int*)"/>
            public static unsafe void MultTransposeMatrixx(ReadOnlySpan<int> m)
            {
                fixed (int* m_ptr = m)
                {
                    MultTransposeMatrixx(m_ptr);
                }
            }
            /// <inheritdoc cref="MultTransposeMatrixx(int*)"/>
            public static unsafe void MultTransposeMatrixx(int[] m)
            {
                fixed (int* m_ptr = m)
                {
                    MultTransposeMatrixx(m_ptr);
                }
            }
            /// <inheritdoc cref="MultTransposeMatrixx(int*)"/>
            public static unsafe void MultTransposeMatrixx(in int m)
            {
                fixed (int* m_ptr = &m)
                {
                    MultTransposeMatrixx(m_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord1xv(TextureUnit, int*)"/>
            public static unsafe void MultiTexCoord1xv(TextureUnit texture, ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    MultiTexCoord1xv(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord1xv(TextureUnit, int*)"/>
            public static unsafe void MultiTexCoord1xv(TextureUnit texture, int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    MultiTexCoord1xv(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord1xv(TextureUnit, int*)"/>
            public static unsafe void MultiTexCoord1xv(TextureUnit texture, in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    MultiTexCoord1xv(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord2xv(TextureUnit, int*)"/>
            public static unsafe void MultiTexCoord2xv(TextureUnit texture, ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    MultiTexCoord2xv(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord2xv(TextureUnit, int*)"/>
            public static unsafe void MultiTexCoord2xv(TextureUnit texture, int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    MultiTexCoord2xv(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord2xv(TextureUnit, int*)"/>
            public static unsafe void MultiTexCoord2xv(TextureUnit texture, in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    MultiTexCoord2xv(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord3xv(TextureUnit, int*)"/>
            public static unsafe void MultiTexCoord3xv(TextureUnit texture, ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    MultiTexCoord3xv(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord3xv(TextureUnit, int*)"/>
            public static unsafe void MultiTexCoord3xv(TextureUnit texture, int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    MultiTexCoord3xv(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord3xv(TextureUnit, int*)"/>
            public static unsafe void MultiTexCoord3xv(TextureUnit texture, in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    MultiTexCoord3xv(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord4xv(TextureUnit, int*)"/>
            public static unsafe void MultiTexCoord4xv(TextureUnit texture, ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    MultiTexCoord4xv(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord4xv(TextureUnit, int*)"/>
            public static unsafe void MultiTexCoord4xv(TextureUnit texture, int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    MultiTexCoord4xv(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord4xv(TextureUnit, int*)"/>
            public static unsafe void MultiTexCoord4xv(TextureUnit texture, in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    MultiTexCoord4xv(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="Normal3xv(int*)"/>
            public static unsafe void Normal3xv(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    Normal3xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="Normal3xv(int*)"/>
            public static unsafe void Normal3xv(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    Normal3xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="Normal3xv(int*)"/>
            public static unsafe void Normal3xv(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    Normal3xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="PixelMapx(PixelMap, int, int*)"/>
            public static unsafe void PixelMapx(PixelMap map, ReadOnlySpan<int> values)
            {
                int size = (int)(values.Length);
                fixed (int* values_ptr = values)
                {
                    PixelMapx(map, size, values_ptr);
                }
            }
            /// <inheritdoc cref="PixelMapx(PixelMap, int, int*)"/>
            public static unsafe void PixelMapx(PixelMap map, int[] values)
            {
                int size = (int)(values.Length);
                fixed (int* values_ptr = values)
                {
                    PixelMapx(map, size, values_ptr);
                }
            }
            /// <inheritdoc cref="PixelMapx(PixelMap, int, int*)"/>
            public static unsafe void PixelMapx(PixelMap map, int size, in int values)
            {
                fixed (int* values_ptr = &values)
                {
                    PixelMapx(map, size, values_ptr);
                }
            }
            /// <inheritdoc cref="PrioritizeTexturesx(int, int*, int*)"/>
            public static unsafe void PrioritizeTexturesx(int n, ReadOnlySpan<int> textures, ReadOnlySpan<int> priorities)
            {
                fixed (int* textures_ptr = textures)
                {
                    fixed (int* priorities_ptr = priorities)
                    {
                        PrioritizeTexturesx(n, textures_ptr, priorities_ptr);
                    }
                }
            }
            /// <inheritdoc cref="PrioritizeTexturesx(int, int*, int*)"/>
            public static unsafe void PrioritizeTexturesx(int n, int[] textures, int[] priorities)
            {
                fixed (int* textures_ptr = textures)
                {
                    fixed (int* priorities_ptr = priorities)
                    {
                        PrioritizeTexturesx(n, textures_ptr, priorities_ptr);
                    }
                }
            }
            /// <inheritdoc cref="PrioritizeTexturesx(int, int*, int*)"/>
            public static unsafe void PrioritizeTexturesx(int n, in int textures, in int priorities)
            {
                fixed (int* textures_ptr = &textures)
                fixed (int* priorities_ptr = &priorities)
                {
                    PrioritizeTexturesx(n, textures_ptr, priorities_ptr);
                }
            }
            /// <inheritdoc cref="RasterPos2xv(int*)"/>
            public static unsafe void RasterPos2xv(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    RasterPos2xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="RasterPos2xv(int*)"/>
            public static unsafe void RasterPos2xv(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    RasterPos2xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="RasterPos2xv(int*)"/>
            public static unsafe void RasterPos2xv(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    RasterPos2xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="RasterPos3xv(int*)"/>
            public static unsafe void RasterPos3xv(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    RasterPos3xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="RasterPos3xv(int*)"/>
            public static unsafe void RasterPos3xv(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    RasterPos3xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="RasterPos3xv(int*)"/>
            public static unsafe void RasterPos3xv(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    RasterPos3xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="RasterPos4xv(int*)"/>
            public static unsafe void RasterPos4xv(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    RasterPos4xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="RasterPos4xv(int*)"/>
            public static unsafe void RasterPos4xv(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    RasterPos4xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="RasterPos4xv(int*)"/>
            public static unsafe void RasterPos4xv(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    RasterPos4xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="Rectxv(int*, int*)"/>
            public static unsafe void Rectxv(ReadOnlySpan<int> v1, ReadOnlySpan<int> v2)
            {
                fixed (int* v1_ptr = v1)
                {
                    fixed (int* v2_ptr = v2)
                    {
                        Rectxv(v1_ptr, v2_ptr);
                    }
                }
            }
            /// <inheritdoc cref="Rectxv(int*, int*)"/>
            public static unsafe void Rectxv(int[] v1, int[] v2)
            {
                fixed (int* v1_ptr = v1)
                {
                    fixed (int* v2_ptr = v2)
                    {
                        Rectxv(v1_ptr, v2_ptr);
                    }
                }
            }
            /// <inheritdoc cref="Rectxv(int*, int*)"/>
            public static unsafe void Rectxv(in int v1, in int v2)
            {
                fixed (int* v1_ptr = &v1)
                fixed (int* v2_ptr = &v2)
                {
                    Rectxv(v1_ptr, v2_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord1xv(int*)"/>
            public static unsafe void TexCoord1xv(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    TexCoord1xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord1xv(int*)"/>
            public static unsafe void TexCoord1xv(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    TexCoord1xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord1xv(int*)"/>
            public static unsafe void TexCoord1xv(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    TexCoord1xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord2xv(int*)"/>
            public static unsafe void TexCoord2xv(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    TexCoord2xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord2xv(int*)"/>
            public static unsafe void TexCoord2xv(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    TexCoord2xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord2xv(int*)"/>
            public static unsafe void TexCoord2xv(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    TexCoord2xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord3xv(int*)"/>
            public static unsafe void TexCoord3xv(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    TexCoord3xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord3xv(int*)"/>
            public static unsafe void TexCoord3xv(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    TexCoord3xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord3xv(int*)"/>
            public static unsafe void TexCoord3xv(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    TexCoord3xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord4xv(int*)"/>
            public static unsafe void TexCoord4xv(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    TexCoord4xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord4xv(int*)"/>
            public static unsafe void TexCoord4xv(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    TexCoord4xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord4xv(int*)"/>
            public static unsafe void TexCoord4xv(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    TexCoord4xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexGenxv(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe void TexGenxv(TextureCoordName coord, TextureGenParameter pname, ReadOnlySpan<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    TexGenxv(coord, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexGenxv(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe void TexGenxv(TextureCoordName coord, TextureGenParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    TexGenxv(coord, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexGenxv(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe void TexGenxv(TextureCoordName coord, TextureGenParameter pname, in int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    TexGenxv(coord, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="Vertex2xv(int*)"/>
            public static unsafe void Vertex2xv(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    Vertex2xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="Vertex2xv(int*)"/>
            public static unsafe void Vertex2xv(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    Vertex2xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="Vertex2xv(int*)"/>
            public static unsafe void Vertex2xv(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    Vertex2xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="Vertex3xv(int*)"/>
            public static unsafe void Vertex3xv(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    Vertex3xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="Vertex3xv(int*)"/>
            public static unsafe void Vertex3xv(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    Vertex3xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="Vertex3xv(int*)"/>
            public static unsafe void Vertex3xv(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    Vertex3xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="Vertex4xv(int*)"/>
            public static unsafe void Vertex4xv(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    Vertex4xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="Vertex4xv(int*)"/>
            public static unsafe void Vertex4xv(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    Vertex4xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="Vertex4xv(int*)"/>
            public static unsafe void Vertex4xv(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    Vertex4xv(coords_ptr);
                }
            }
            /// <inheritdoc cref="DeleteRenderbuffers(int, int*)"/>
            public static unsafe void DeleteRenderbuffers(ReadOnlySpan<int> renderbuffers)
            {
                int n = (int)(renderbuffers.Length);
                fixed (int* renderbuffers_ptr = renderbuffers)
                {
                    DeleteRenderbuffers(n, renderbuffers_ptr);
                }
            }
            /// <inheritdoc cref="DeleteRenderbuffers(int, int*)"/>
            public static unsafe void DeleteRenderbuffers(int[] renderbuffers)
            {
                int n = (int)(renderbuffers.Length);
                fixed (int* renderbuffers_ptr = renderbuffers)
                {
                    DeleteRenderbuffers(n, renderbuffers_ptr);
                }
            }
            /// <inheritdoc cref="DeleteRenderbuffers(int, int*)"/>
            public static unsafe void DeleteRenderbuffers(int n, in int renderbuffers)
            {
                fixed (int* renderbuffers_ptr = &renderbuffers)
                {
                    DeleteRenderbuffers(n, renderbuffers_ptr);
                }
            }
            /// <inheritdoc cref="GenRenderbuffers(int, int*)"/>
            public static unsafe void GenRenderbuffers(Span<int> renderbuffers)
            {
                int n = (int)(renderbuffers.Length);
                fixed (int* renderbuffers_ptr = renderbuffers)
                {
                    GenRenderbuffers(n, renderbuffers_ptr);
                }
            }
            /// <inheritdoc cref="GenRenderbuffers(int, int*)"/>
            public static unsafe void GenRenderbuffers(int[] renderbuffers)
            {
                int n = (int)(renderbuffers.Length);
                fixed (int* renderbuffers_ptr = renderbuffers)
                {
                    GenRenderbuffers(n, renderbuffers_ptr);
                }
            }
            /// <inheritdoc cref="GenRenderbuffers(int, int*)"/>
            public static unsafe void GenRenderbuffers(int n, ref int renderbuffers)
            {
                fixed (int* renderbuffers_ptr = &renderbuffers)
                {
                    GenRenderbuffers(n, renderbuffers_ptr);
                }
            }
            /// <inheritdoc cref="GetRenderbufferParameteriv(RenderbufferTarget, RenderbufferParameterName, int*)"/>
            public static unsafe void GetRenderbufferParameteriv(RenderbufferTarget target, RenderbufferParameterName pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetRenderbufferParameteriv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetRenderbufferParameteriv(RenderbufferTarget, RenderbufferParameterName, int*)"/>
            public static unsafe void GetRenderbufferParameteriv(RenderbufferTarget target, RenderbufferParameterName pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetRenderbufferParameteriv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetRenderbufferParameteriv(RenderbufferTarget, RenderbufferParameterName, int*)"/>
            public static unsafe void GetRenderbufferParameteriv(RenderbufferTarget target, RenderbufferParameterName pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetRenderbufferParameteriv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="DeleteFramebuffers(int, int*)"/>
            public static unsafe void DeleteFramebuffers(ReadOnlySpan<int> framebuffers)
            {
                int n = (int)(framebuffers.Length);
                fixed (int* framebuffers_ptr = framebuffers)
                {
                    DeleteFramebuffers(n, framebuffers_ptr);
                }
            }
            /// <inheritdoc cref="DeleteFramebuffers(int, int*)"/>
            public static unsafe void DeleteFramebuffers(int[] framebuffers)
            {
                int n = (int)(framebuffers.Length);
                fixed (int* framebuffers_ptr = framebuffers)
                {
                    DeleteFramebuffers(n, framebuffers_ptr);
                }
            }
            /// <inheritdoc cref="DeleteFramebuffers(int, int*)"/>
            public static unsafe void DeleteFramebuffers(int n, in int framebuffers)
            {
                fixed (int* framebuffers_ptr = &framebuffers)
                {
                    DeleteFramebuffers(n, framebuffers_ptr);
                }
            }
            /// <inheritdoc cref="GenFramebuffers(int, int*)"/>
            public static unsafe void GenFramebuffers(Span<int> framebuffers)
            {
                int n = (int)(framebuffers.Length);
                fixed (int* framebuffers_ptr = framebuffers)
                {
                    GenFramebuffers(n, framebuffers_ptr);
                }
            }
            /// <inheritdoc cref="GenFramebuffers(int, int*)"/>
            public static unsafe void GenFramebuffers(int[] framebuffers)
            {
                int n = (int)(framebuffers.Length);
                fixed (int* framebuffers_ptr = framebuffers)
                {
                    GenFramebuffers(n, framebuffers_ptr);
                }
            }
            /// <inheritdoc cref="GenFramebuffers(int, int*)"/>
            public static unsafe void GenFramebuffers(int n, ref int framebuffers)
            {
                fixed (int* framebuffers_ptr = &framebuffers)
                {
                    GenFramebuffers(n, framebuffers_ptr);
                }
            }
            /// <inheritdoc cref="GetFramebufferAttachmentParameteriv(FramebufferTarget, FramebufferAttachment, FramebufferAttachmentParameterName, int*)"/>
            public static unsafe void GetFramebufferAttachmentParameteriv(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetFramebufferAttachmentParameteriv(target, attachment, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetFramebufferAttachmentParameteriv(FramebufferTarget, FramebufferAttachment, FramebufferAttachmentParameterName, int*)"/>
            public static unsafe void GetFramebufferAttachmentParameteriv(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetFramebufferAttachmentParameteriv(target, attachment, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetFramebufferAttachmentParameteriv(FramebufferTarget, FramebufferAttachment, FramebufferAttachmentParameterName, int*)"/>
            public static unsafe void GetFramebufferAttachmentParameteriv(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetFramebufferAttachmentParameteriv(target, attachment, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="MatrixIndexPointer(int, MatrixIndexPointerTypeARB, int, void*)"/>
            public static unsafe void MatrixIndexPointer(int size, MatrixIndexPointerTypeARB type, int stride, IntPtr pointer)
            {
                void* pointer_vptr = (void*)pointer;
                MatrixIndexPointer(size, type, stride, pointer_vptr);
            }
            /// <inheritdoc cref="MatrixIndexPointer(int, MatrixIndexPointerTypeARB, int, void*)"/>
            public static unsafe void MatrixIndexPointer<T1>(int size, MatrixIndexPointerTypeARB type, int stride, ReadOnlySpan<T1> pointer)
                where T1 : unmanaged
            {
                fixed (void* pointer_ptr = pointer)
                {
                    MatrixIndexPointer(size, type, stride, pointer_ptr);
                }
            }
            /// <inheritdoc cref="MatrixIndexPointer(int, MatrixIndexPointerTypeARB, int, void*)"/>
            public static unsafe void MatrixIndexPointer<T1>(int size, MatrixIndexPointerTypeARB type, int stride, T1[] pointer)
                where T1 : unmanaged
            {
                fixed (void* pointer_ptr = pointer)
                {
                    MatrixIndexPointer(size, type, stride, pointer_ptr);
                }
            }
            /// <inheritdoc cref="MatrixIndexPointer(int, MatrixIndexPointerTypeARB, int, void*)"/>
            public static unsafe void MatrixIndexPointer<T1>(int size, MatrixIndexPointerTypeARB type, int stride, in T1 pointer)
                where T1 : unmanaged
            {
                fixed (void* pointer_ptr = &pointer)
                {
                    MatrixIndexPointer(size, type, stride, pointer_ptr);
                }
            }
            /// <inheritdoc cref="WeightPointer(int, All, int, void*)"/>
            public static unsafe void WeightPointer(int size, All type, int stride, IntPtr pointer)
            {
                void* pointer_vptr = (void*)pointer;
                WeightPointer(size, type, stride, pointer_vptr);
            }
            /// <inheritdoc cref="WeightPointer(int, All, int, void*)"/>
            public static unsafe void WeightPointer<T1>(int size, All type, int stride, ReadOnlySpan<T1> pointer)
                where T1 : unmanaged
            {
                fixed (void* pointer_ptr = pointer)
                {
                    WeightPointer(size, type, stride, pointer_ptr);
                }
            }
            /// <inheritdoc cref="WeightPointer(int, All, int, void*)"/>
            public static unsafe void WeightPointer<T1>(int size, All type, int stride, T1[] pointer)
                where T1 : unmanaged
            {
                fixed (void* pointer_ptr = pointer)
                {
                    WeightPointer(size, type, stride, pointer_ptr);
                }
            }
            /// <inheritdoc cref="WeightPointer(int, All, int, void*)"/>
            public static unsafe void WeightPointer<T1>(int size, All type, int stride, in T1 pointer)
                where T1 : unmanaged
            {
                fixed (void* pointer_ptr = &pointer)
                {
                    WeightPointer(size, type, stride, pointer_ptr);
                }
            }
            /// <inheritdoc cref="PointSizePointer(All, int, void*)"/>
            public static unsafe void PointSizePointer(All type, int stride, IntPtr pointer)
            {
                void* pointer_vptr = (void*)pointer;
                PointSizePointer(type, stride, pointer_vptr);
            }
            /// <inheritdoc cref="PointSizePointer(All, int, void*)"/>
            public static unsafe void PointSizePointer<T1>(All type, int stride, ReadOnlySpan<T1> pointer)
                where T1 : unmanaged
            {
                fixed (void* pointer_ptr = pointer)
                {
                    PointSizePointer(type, stride, pointer_ptr);
                }
            }
            /// <inheritdoc cref="PointSizePointer(All, int, void*)"/>
            public static unsafe void PointSizePointer<T1>(All type, int stride, T1[] pointer)
                where T1 : unmanaged
            {
                fixed (void* pointer_ptr = pointer)
                {
                    PointSizePointer(type, stride, pointer_ptr);
                }
            }
            /// <inheritdoc cref="PointSizePointer(All, int, void*)"/>
            public static unsafe void PointSizePointer<T1>(All type, int stride, in T1 pointer)
                where T1 : unmanaged
            {
                fixed (void* pointer_ptr = &pointer)
                {
                    PointSizePointer(type, stride, pointer_ptr);
                }
            }
            /// <inheritdoc cref="QueryMatrixx(int*, int*)"/>
            public static unsafe uint QueryMatrixx(Span<int> mantissa, Span<int> exponent)
            {
                uint returnValue;
                fixed (int* mantissa_ptr = mantissa)
                {
                    fixed (int* exponent_ptr = exponent)
                    {
                        returnValue = QueryMatrixx(mantissa_ptr, exponent_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryMatrixx(int*, int*)"/>
            public static unsafe uint QueryMatrixx(int[] mantissa, int[] exponent)
            {
                uint returnValue;
                fixed (int* mantissa_ptr = mantissa)
                {
                    fixed (int* exponent_ptr = exponent)
                    {
                        returnValue = QueryMatrixx(mantissa_ptr, exponent_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryMatrixx(int*, int*)"/>
            public static unsafe uint QueryMatrixx(ref int mantissa, ref int exponent)
            {
                uint returnValue;
                fixed (int* mantissa_ptr = &mantissa)
                fixed (int* exponent_ptr = &exponent)
                {
                    returnValue = QueryMatrixx(mantissa_ptr, exponent_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ClipPlanef(ClipPlaneName, float*)"/>
            public static unsafe void ClipPlanef(ClipPlaneName plane, ReadOnlySpan<float> equation)
            {
                fixed (float* equation_ptr = equation)
                {
                    ClipPlanef(plane, equation_ptr);
                }
            }
            /// <inheritdoc cref="ClipPlanef(ClipPlaneName, float*)"/>
            public static unsafe void ClipPlanef(ClipPlaneName plane, float[] equation)
            {
                fixed (float* equation_ptr = equation)
                {
                    ClipPlanef(plane, equation_ptr);
                }
            }
            /// <inheritdoc cref="ClipPlanef(ClipPlaneName, float*)"/>
            public static unsafe void ClipPlanef(ClipPlaneName plane, in float equation)
            {
                fixed (float* equation_ptr = &equation)
                {
                    ClipPlanef(plane, equation_ptr);
                }
            }
            /// <inheritdoc cref="GetClipPlanef(ClipPlaneName, float*)"/>
            public static unsafe void GetClipPlanef(ClipPlaneName plane, Span<float> equation)
            {
                fixed (float* equation_ptr = equation)
                {
                    GetClipPlanef(plane, equation_ptr);
                }
            }
            /// <inheritdoc cref="GetClipPlanef(ClipPlaneName, float*)"/>
            public static unsafe void GetClipPlanef(ClipPlaneName plane, float[] equation)
            {
                fixed (float* equation_ptr = equation)
                {
                    GetClipPlanef(plane, equation_ptr);
                }
            }
            /// <inheritdoc cref="GetClipPlanef(ClipPlaneName, float*)"/>
            public static unsafe void GetClipPlanef(ClipPlaneName plane, ref float equation)
            {
                fixed (float* equation_ptr = &equation)
                {
                    GetClipPlanef(plane, equation_ptr);
                }
            }
            /// <inheritdoc cref="TexGenfv(TextureCoordName, TextureGenParameter, float*)"/>
            public static unsafe void TexGenfv(TextureCoordName coord, TextureGenParameter pname, ReadOnlySpan<float> parameters)
            {
                fixed (float* parameters_ptr = parameters)
                {
                    TexGenfv(coord, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexGenfv(TextureCoordName, TextureGenParameter, float*)"/>
            public static unsafe void TexGenfv(TextureCoordName coord, TextureGenParameter pname, float[] parameters)
            {
                fixed (float* parameters_ptr = parameters)
                {
                    TexGenfv(coord, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexGenfv(TextureCoordName, TextureGenParameter, float*)"/>
            public static unsafe void TexGenfv(TextureCoordName coord, TextureGenParameter pname, in float parameters)
            {
                fixed (float* parameters_ptr = &parameters)
                {
                    TexGenfv(coord, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexGeniv(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe void TexGeniv(TextureCoordName coord, TextureGenParameter pname, ReadOnlySpan<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    TexGeniv(coord, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexGeniv(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe void TexGeniv(TextureCoordName coord, TextureGenParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    TexGeniv(coord, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexGeniv(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe void TexGeniv(TextureCoordName coord, TextureGenParameter pname, in int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    TexGeniv(coord, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexGenfv(TextureCoordName, TextureGenParameter, float*)"/>
            public static unsafe void GetTexGenfv(TextureCoordName coord, TextureGenParameter pname, Span<float> parameters)
            {
                fixed (float* parameters_ptr = parameters)
                {
                    GetTexGenfv(coord, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexGenfv(TextureCoordName, TextureGenParameter, float*)"/>
            public static unsafe void GetTexGenfv(TextureCoordName coord, TextureGenParameter pname, float[] parameters)
            {
                fixed (float* parameters_ptr = parameters)
                {
                    GetTexGenfv(coord, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexGenfv(TextureCoordName, TextureGenParameter, float*)"/>
            public static unsafe void GetTexGenfv(TextureCoordName coord, TextureGenParameter pname, ref float parameters)
            {
                fixed (float* parameters_ptr = &parameters)
                {
                    GetTexGenfv(coord, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexGeniv(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe void GetTexGeniv(TextureCoordName coord, TextureGenParameter pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexGeniv(coord, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexGeniv(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe void GetTexGeniv(TextureCoordName coord, TextureGenParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexGeniv(coord, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexGeniv(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe void GetTexGeniv(TextureCoordName coord, TextureGenParameter pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetTexGeniv(coord, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="DeleteVertexArrays(int, int*)"/>
            public static unsafe void DeleteVertexArrays(ReadOnlySpan<int> arrays)
            {
                int n = (int)(arrays.Length);
                fixed (int* arrays_ptr = arrays)
                {
                    DeleteVertexArrays(n, arrays_ptr);
                }
            }
            /// <inheritdoc cref="DeleteVertexArrays(int, int*)"/>
            public static unsafe void DeleteVertexArrays(int[] arrays)
            {
                int n = (int)(arrays.Length);
                fixed (int* arrays_ptr = arrays)
                {
                    DeleteVertexArrays(n, arrays_ptr);
                }
            }
            /// <inheritdoc cref="DeleteVertexArrays(int, int*)"/>
            public static unsafe void DeleteVertexArrays(int n, in int arrays)
            {
                fixed (int* arrays_ptr = &arrays)
                {
                    DeleteVertexArrays(n, arrays_ptr);
                }
            }
            /// <inheritdoc cref="GenVertexArrays(int, int*)"/>
            public static unsafe void GenVertexArrays(Span<int> arrays)
            {
                int n = (int)(arrays.Length);
                fixed (int* arrays_ptr = arrays)
                {
                    GenVertexArrays(n, arrays_ptr);
                }
            }
            /// <inheritdoc cref="GenVertexArrays(int, int*)"/>
            public static unsafe void GenVertexArrays(int[] arrays)
            {
                int n = (int)(arrays.Length);
                fixed (int* arrays_ptr = arrays)
                {
                    GenVertexArrays(n, arrays_ptr);
                }
            }
            /// <inheritdoc cref="GenVertexArrays(int, int*)"/>
            public static unsafe void GenVertexArrays(int n, ref int arrays)
            {
                fixed (int* arrays_ptr = &arrays)
                {
                    GenVertexArrays(n, arrays_ptr);
                }
            }
        }
        public static unsafe partial class QCOM
        {
            /// <inheritdoc cref="GetDriverControls(int*, int, uint*)"/>
            public static unsafe void GetDriverControls(ref int num, Span<uint> driverControls)
            {
                fixed (int* num_ptr = &num)
                {
                    int size = (int)(driverControls.Length);
                    fixed (uint* driverControls_ptr = driverControls)
                    {
                        GetDriverControls(num_ptr, size, driverControls_ptr);
                    }
                }
            }
            /// <inheritdoc cref="GetDriverControls(int*, int, uint*)"/>
            public static unsafe void GetDriverControls(ref int num, uint[] driverControls)
            {
                fixed (int* num_ptr = &num)
                {
                    int size = (int)(driverControls.Length);
                    fixed (uint* driverControls_ptr = driverControls)
                    {
                        GetDriverControls(num_ptr, size, driverControls_ptr);
                    }
                }
            }
            /// <inheritdoc cref="GetDriverControls(int*, int, uint*)"/>
            public static unsafe void GetDriverControls(ref int num, int size, ref uint driverControls)
            {
                fixed (int* num_ptr = &num)
                fixed (uint* driverControls_ptr = &driverControls)
                {
                    GetDriverControls(num_ptr, size, driverControls_ptr);
                }
            }
            /// <inheritdoc cref="GetDriverControlString(uint, int, int*, byte*)"/>
            public static unsafe string GetDriverControlString(uint driverControl, int bufSize, ref int length)
            {
                string driverControlString;
                fixed (int* length_ptr = &length)
                {
                    var driverControlString_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetDriverControlString(driverControl, bufSize, length_ptr, driverControlString_ptr);
                    driverControlString = Marshal.PtrToStringUTF8((IntPtr)driverControlString_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)driverControlString_ptr);
                }
                return driverControlString;
            }
            /// <inheritdoc cref="GetDriverControlString(uint, int, int*, byte*)"/>
            public static unsafe void GetDriverControlString(uint driverControl, int bufSize, ref int length, out string driverControlString)
            {
                fixed (int* length_ptr = &length)
                {
                    var driverControlString_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetDriverControlString(driverControl, bufSize, length_ptr, driverControlString_ptr);
                    driverControlString = Marshal.PtrToStringUTF8((IntPtr)driverControlString_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)driverControlString_ptr);
                }
            }
            /// <inheritdoc cref="ExtGetTextures(int*, int, int*)"/>
            public static unsafe void ExtGetTextures(ref int textures, int maxTextures, ref int numTextures)
            {
                fixed (int* textures_ptr = &textures)
                fixed (int* numTextures_ptr = &numTextures)
                {
                    ExtGetTextures(textures_ptr, maxTextures, numTextures_ptr);
                }
            }
            /// <inheritdoc cref="ExtGetBuffers(int*, int, int*)"/>
            public static unsafe void ExtGetBuffers(Span<int> buffers, Span<int> numBuffers)
            {
                int maxBuffers = (int)(buffers.Length);
                fixed (int* buffers_ptr = buffers)
                {
                    fixed (int* numBuffers_ptr = numBuffers)
                    {
                        ExtGetBuffers(buffers_ptr, maxBuffers, numBuffers_ptr);
                    }
                }
            }
            /// <inheritdoc cref="ExtGetBuffers(int*, int, int*)"/>
            public static unsafe void ExtGetBuffers(int[] buffers, int[] numBuffers)
            {
                int maxBuffers = (int)(buffers.Length);
                fixed (int* buffers_ptr = buffers)
                {
                    fixed (int* numBuffers_ptr = numBuffers)
                    {
                        ExtGetBuffers(buffers_ptr, maxBuffers, numBuffers_ptr);
                    }
                }
            }
            /// <inheritdoc cref="ExtGetBuffers(int*, int, int*)"/>
            public static unsafe void ExtGetBuffers(ref int buffers, int maxBuffers, ref int numBuffers)
            {
                fixed (int* buffers_ptr = &buffers)
                fixed (int* numBuffers_ptr = &numBuffers)
                {
                    ExtGetBuffers(buffers_ptr, maxBuffers, numBuffers_ptr);
                }
            }
            /// <inheritdoc cref="ExtGetRenderbuffers(int*, int, int*)"/>
            public static unsafe void ExtGetRenderbuffers(Span<int> renderbuffers, Span<int> numRenderbuffers)
            {
                int maxRenderbuffers = (int)(renderbuffers.Length);
                fixed (int* renderbuffers_ptr = renderbuffers)
                {
                    fixed (int* numRenderbuffers_ptr = numRenderbuffers)
                    {
                        ExtGetRenderbuffers(renderbuffers_ptr, maxRenderbuffers, numRenderbuffers_ptr);
                    }
                }
            }
            /// <inheritdoc cref="ExtGetRenderbuffers(int*, int, int*)"/>
            public static unsafe void ExtGetRenderbuffers(int[] renderbuffers, int[] numRenderbuffers)
            {
                int maxRenderbuffers = (int)(renderbuffers.Length);
                fixed (int* renderbuffers_ptr = renderbuffers)
                {
                    fixed (int* numRenderbuffers_ptr = numRenderbuffers)
                    {
                        ExtGetRenderbuffers(renderbuffers_ptr, maxRenderbuffers, numRenderbuffers_ptr);
                    }
                }
            }
            /// <inheritdoc cref="ExtGetRenderbuffers(int*, int, int*)"/>
            public static unsafe void ExtGetRenderbuffers(ref int renderbuffers, int maxRenderbuffers, ref int numRenderbuffers)
            {
                fixed (int* renderbuffers_ptr = &renderbuffers)
                fixed (int* numRenderbuffers_ptr = &numRenderbuffers)
                {
                    ExtGetRenderbuffers(renderbuffers_ptr, maxRenderbuffers, numRenderbuffers_ptr);
                }
            }
            /// <inheritdoc cref="ExtGetFramebuffers(int*, int, int*)"/>
            public static unsafe void ExtGetFramebuffers(Span<int> framebuffers, Span<int> numFramebuffers)
            {
                int maxFramebuffers = (int)(framebuffers.Length);
                fixed (int* framebuffers_ptr = framebuffers)
                {
                    fixed (int* numFramebuffers_ptr = numFramebuffers)
                    {
                        ExtGetFramebuffers(framebuffers_ptr, maxFramebuffers, numFramebuffers_ptr);
                    }
                }
            }
            /// <inheritdoc cref="ExtGetFramebuffers(int*, int, int*)"/>
            public static unsafe void ExtGetFramebuffers(int[] framebuffers, int[] numFramebuffers)
            {
                int maxFramebuffers = (int)(framebuffers.Length);
                fixed (int* framebuffers_ptr = framebuffers)
                {
                    fixed (int* numFramebuffers_ptr = numFramebuffers)
                    {
                        ExtGetFramebuffers(framebuffers_ptr, maxFramebuffers, numFramebuffers_ptr);
                    }
                }
            }
            /// <inheritdoc cref="ExtGetFramebuffers(int*, int, int*)"/>
            public static unsafe void ExtGetFramebuffers(ref int framebuffers, int maxFramebuffers, ref int numFramebuffers)
            {
                fixed (int* framebuffers_ptr = &framebuffers)
                fixed (int* numFramebuffers_ptr = &numFramebuffers)
                {
                    ExtGetFramebuffers(framebuffers_ptr, maxFramebuffers, numFramebuffers_ptr);
                }
            }
            /// <inheritdoc cref="ExtGetTexLevelParameteriv(int, All, int, All, int*)"/>
            public static unsafe void ExtGetTexLevelParameteriv(int texture, All face, int level, All pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    ExtGetTexLevelParameteriv(texture, face, level, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="ExtGetTexSubImage(All, int, int, int, int, int, int, int, PixelFormat, PixelType, void*)"/>
            public static unsafe void ExtGetTexSubImage(All target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr texels)
            {
                void* texels_vptr = (void*)texels;
                ExtGetTexSubImage(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, texels_vptr);
            }
            /// <inheritdoc cref="ExtGetTexSubImage(All, int, int, int, int, int, int, int, PixelFormat, PixelType, void*)"/>
            public static unsafe void ExtGetTexSubImage<T1>(All target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, ref T1 texels)
                where T1 : unmanaged
            {
                fixed (void* texels_ptr = &texels)
                {
                    ExtGetTexSubImage(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, texels_ptr);
                }
            }
            /// <inheritdoc cref="ExtGetShaders(int*, int, int*)"/>
            public static unsafe void ExtGetShaders(Span<int> shaders, Span<int> numShaders)
            {
                int maxShaders = (int)(shaders.Length);
                fixed (int* shaders_ptr = shaders)
                {
                    fixed (int* numShaders_ptr = numShaders)
                    {
                        ExtGetShaders(shaders_ptr, maxShaders, numShaders_ptr);
                    }
                }
            }
            /// <inheritdoc cref="ExtGetShaders(int*, int, int*)"/>
            public static unsafe void ExtGetShaders(int[] shaders, int[] numShaders)
            {
                int maxShaders = (int)(shaders.Length);
                fixed (int* shaders_ptr = shaders)
                {
                    fixed (int* numShaders_ptr = numShaders)
                    {
                        ExtGetShaders(shaders_ptr, maxShaders, numShaders_ptr);
                    }
                }
            }
            /// <inheritdoc cref="ExtGetShaders(int*, int, int*)"/>
            public static unsafe void ExtGetShaders(ref int shaders, int maxShaders, ref int numShaders)
            {
                fixed (int* shaders_ptr = &shaders)
                fixed (int* numShaders_ptr = &numShaders)
                {
                    ExtGetShaders(shaders_ptr, maxShaders, numShaders_ptr);
                }
            }
            /// <inheritdoc cref="ExtGetPrograms(int*, int, int*)"/>
            public static unsafe void ExtGetPrograms(Span<int> programs, Span<int> numPrograms)
            {
                int maxPrograms = (int)(programs.Length);
                fixed (int* programs_ptr = programs)
                {
                    fixed (int* numPrograms_ptr = numPrograms)
                    {
                        ExtGetPrograms(programs_ptr, maxPrograms, numPrograms_ptr);
                    }
                }
            }
            /// <inheritdoc cref="ExtGetPrograms(int*, int, int*)"/>
            public static unsafe void ExtGetPrograms(int[] programs, int[] numPrograms)
            {
                int maxPrograms = (int)(programs.Length);
                fixed (int* programs_ptr = programs)
                {
                    fixed (int* numPrograms_ptr = numPrograms)
                    {
                        ExtGetPrograms(programs_ptr, maxPrograms, numPrograms_ptr);
                    }
                }
            }
            /// <inheritdoc cref="ExtGetPrograms(int*, int, int*)"/>
            public static unsafe void ExtGetPrograms(ref int programs, int maxPrograms, ref int numPrograms)
            {
                fixed (int* programs_ptr = &programs)
                fixed (int* numPrograms_ptr = &numPrograms)
                {
                    ExtGetPrograms(programs_ptr, maxPrograms, numPrograms_ptr);
                }
            }
            /// <inheritdoc cref="ExtGetProgramBinarySource(int, ShaderType, byte*, int*)"/>
            public static unsafe string ExtGetProgramBinarySource(int program, ShaderType shadertype, ref int length)
            {
                string source;
                fixed (int* length_ptr = &length)
                {
                    var source_ptr = (byte*)Marshal.AllocCoTaskMem(*length_ptr);
                    ExtGetProgramBinarySource(program, shadertype, source_ptr, length_ptr);
                    source = Marshal.PtrToStringUTF8((IntPtr)source_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)source_ptr);
                }
                return source;
            }
            /// <inheritdoc cref="ExtGetProgramBinarySource(int, ShaderType, byte*, int*)"/>
            public static unsafe void ExtGetProgramBinarySource(int program, ShaderType shadertype, out string source, ref int length)
            {
                fixed (int* length_ptr = &length)
                {
                    var source_ptr = (byte*)Marshal.AllocCoTaskMem(*length_ptr);
                    ExtGetProgramBinarySource(program, shadertype, source_ptr, length_ptr);
                    source = Marshal.PtrToStringUTF8((IntPtr)source_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)source_ptr);
                }
            }
        }
    }
#pragma warning restore CS0419 // Ambiguous reference in cref attribute
}
