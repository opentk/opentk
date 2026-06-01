// This file is auto generated, do not edit.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using OpenTK.Core.Native;
using OpenTK.Mathematics;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics.Wgl;
using OpenTK.Graphics.Glx;

namespace OpenTK.Graphics.OpenGLES1
{
    public static unsafe partial class GL
    {
        /// <inheritdoc cref="BufferData(BufferTarget, nint, void*, BufferUsage)"/>
        public static unsafe void BufferData(BufferTarget target, nint size, IntPtr data, BufferUsage usage)
        {
            void* data_vptr = (void*)data;
            BufferData(target, size, data_vptr, usage);
        }
        /// <inheritdoc cref="BufferData(BufferTarget, nint, void*, BufferUsage)"/>
        public static unsafe void BufferData<T1>(BufferTarget target, nint size, ReadOnlySpan<T1> data, BufferUsage usage)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = data)
            {
                BufferData(target, size, data_ptr, usage);
            }
        }
        /// <inheritdoc cref="BufferData(BufferTarget, nint, void*, BufferUsage)"/>
        public static unsafe void BufferData<T1>(BufferTarget target, nint size, T1[] data, BufferUsage usage)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = data)
            {
                BufferData(target, size, data_ptr, usage);
            }
        }
        /// <inheritdoc cref="BufferData(BufferTarget, nint, void*, BufferUsage)"/>
        public static unsafe void BufferData<T1>(BufferTarget target, nint size, ref readonly T1 data, BufferUsage usage)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = &data)
            {
                BufferData(target, size, data_ptr, usage);
            }
        }
        /// <inheritdoc cref="BufferSubData(BufferTarget, IntPtr, nint, void*)"/>
        public static unsafe void BufferSubData(BufferTarget target, IntPtr offset, nint size, IntPtr data)
        {
            void* data_vptr = (void*)data;
            BufferSubData(target, offset, size, data_vptr);
        }
        /// <inheritdoc cref="BufferSubData(BufferTarget, IntPtr, nint, void*)"/>
        public static unsafe void BufferSubData<T1>(BufferTarget target, IntPtr offset, nint size, ReadOnlySpan<T1> data)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = data)
            {
                BufferSubData(target, offset, size, data_ptr);
            }
        }
        /// <inheritdoc cref="BufferSubData(BufferTarget, IntPtr, nint, void*)"/>
        public static unsafe void BufferSubData<T1>(BufferTarget target, IntPtr offset, nint size, T1[] data)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = data)
            {
                BufferSubData(target, offset, size, data_ptr);
            }
        }
        /// <inheritdoc cref="BufferSubData(BufferTarget, IntPtr, nint, void*)"/>
        public static unsafe void BufferSubData<T1>(BufferTarget target, IntPtr offset, nint size, ref readonly T1 data)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = &data)
            {
                BufferSubData(target, offset, size, data_ptr);
            }
        }
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
        public static unsafe void ClipPlanef(ClipPlaneName p, ref readonly float eqn)
        {
            fixed (float* eqn_ptr = &eqn)
            {
                ClipPlanef(p, eqn_ptr);
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
        public static unsafe void ClipPlanex(ClipPlaneName plane, ref readonly int equation)
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
        public static unsafe void ColorPointer<T1>(int size, ColorPointerType type, int stride, ref readonly T1 pointer)
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
        public static unsafe void CompressedTexImage2D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, ReadOnlySpan<T1> data)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = data)
            {
                CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data_ptr);
            }
        }
        /// <inheritdoc cref="CompressedTexImage2D(TextureTarget, int, InternalFormat, int, int, int, int, void*)"/>
        public static unsafe void CompressedTexImage2D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, T1[] data)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = data)
            {
                CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data_ptr);
            }
        }
        /// <inheritdoc cref="CompressedTexImage2D(TextureTarget, int, InternalFormat, int, int, int, int, void*)"/>
        public static unsafe void CompressedTexImage2D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, ref readonly T1 data)
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
        public static unsafe void CompressedTexSubImage2D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, InternalFormat format, int imageSize, ReadOnlySpan<T1> data)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = data)
            {
                CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data_ptr);
            }
        }
        /// <inheritdoc cref="CompressedTexSubImage2D(TextureTarget, int, int, int, int, int, InternalFormat, int, void*)"/>
        public static unsafe void CompressedTexSubImage2D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, InternalFormat format, int imageSize, T1[] data)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = data)
            {
                CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data_ptr);
            }
        }
        /// <inheritdoc cref="CompressedTexSubImage2D(TextureTarget, int, int, int, int, int, InternalFormat, int, void*)"/>
        public static unsafe void CompressedTexSubImage2D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, InternalFormat format, int imageSize, ref readonly T1 data)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = &data)
            {
                CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data_ptr);
            }
        }
        /// <inheritdoc cref="DeleteBuffers(int, int*)"/>
        public static unsafe void DeleteBuffer(int buffer)
        {
            int n = 1;
            int* buffers_handle = &buffer;
            DeleteBuffers(n, buffers_handle);
        }
        /// <inheritdoc cref="DeleteBuffers(int, int*)"/>
        public static unsafe void DeleteBuffers(int n, ReadOnlySpan<int> buffers)
        {
            fixed (int* buffers_ptr = buffers)
            {
                DeleteBuffers(n, buffers_ptr);
            }
        }
        /// <inheritdoc cref="DeleteBuffers(int, int*)"/>
        public static unsafe void DeleteBuffers(int n, int[] buffers)
        {
            fixed (int* buffers_ptr = buffers)
            {
                DeleteBuffers(n, buffers_ptr);
            }
        }
        /// <inheritdoc cref="DeleteBuffers(int, int*)"/>
        public static unsafe void DeleteBuffers(int n, ref readonly int buffers)
        {
            fixed (int* buffers_ptr = &buffers)
            {
                DeleteBuffers(n, buffers_ptr);
            }
        }
        /// <inheritdoc cref="DeleteTextures(int, int*)"/>
        public static unsafe void DeleteTexture(int texture)
        {
            int n = 1;
            int* textures_handle = &texture;
            DeleteTextures(n, textures_handle);
        }
        /// <inheritdoc cref="DeleteTextures(int, int*)"/>
        public static unsafe void DeleteTextures(int n, ReadOnlySpan<int> textures)
        {
            fixed (int* textures_ptr = textures)
            {
                DeleteTextures(n, textures_ptr);
            }
        }
        /// <inheritdoc cref="DeleteTextures(int, int*)"/>
        public static unsafe void DeleteTextures(int n, int[] textures)
        {
            fixed (int* textures_ptr = textures)
            {
                DeleteTextures(n, textures_ptr);
            }
        }
        /// <inheritdoc cref="DeleteTextures(int, int*)"/>
        public static unsafe void DeleteTextures(int n, ref readonly int textures)
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
        /// <inheritdoc cref="Fogfv(FogParameter, float*)"/>
        public static unsafe void Fogf(FogParameter pname, ReadOnlySpan<float> @params)
        {
            fixed (float* @params_ptr = @params)
            {
                Fogfv(pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="Fogfv(FogParameter, float*)"/>
        public static unsafe void Fogf(FogParameter pname, float[] @params)
        {
            fixed (float* @params_ptr = @params)
            {
                Fogfv(pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="Fogfv(FogParameter, float*)"/>
        public static unsafe void Fogf(FogParameter pname, ref readonly float @params)
        {
            fixed (float* @params_ptr = &@params)
            {
                Fogfv(pname, @params_ptr);
            }
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
        public static unsafe void Fogx(FogPName pname, ref readonly int param)
        {
            fixed (int* param_ptr = &param)
            {
                Fogxv(pname, param_ptr);
            }
        }
        /// <inheritdoc cref="GenBuffers(int, int*)"/>
        public static unsafe int GenBuffer()
        {
            int buffer;
            int n = 1;
            Unsafe.SkipInit(out buffer);
            int* buffers_handle = &buffer;
            GenBuffers(n, buffers_handle);
            return buffer;
        }
        /// <inheritdoc cref="GenBuffers(int, int*)"/>
        public static unsafe void GenBuffer(out int buffer)
        {
            int n = 1;
            Unsafe.SkipInit(out buffer);
            fixed(int* buffers_handle = &buffer)
            {
                GenBuffers(n, buffers_handle);
            }
        }
        /// <inheritdoc cref="GenBuffers(int, int*)"/>
        public static unsafe void GenBuffers(int n, Span<int> buffers)
        {
            fixed (int* buffers_ptr = buffers)
            {
                GenBuffers(n, buffers_ptr);
            }
        }
        /// <inheritdoc cref="GenBuffers(int, int*)"/>
        public static unsafe void GenBuffers(int n, int[] buffers)
        {
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
            int* textures_handle = &texture;
            GenTextures(n, textures_handle);
            return texture;
        }
        /// <inheritdoc cref="GenTextures(int, int*)"/>
        public static unsafe void GenTexture(out int texture)
        {
            int n = 1;
            Unsafe.SkipInit(out texture);
            fixed(int* textures_handle = &texture)
            {
                GenTextures(n, textures_handle);
            }
        }
        /// <inheritdoc cref="GenTextures(int, int*)"/>
        public static unsafe void GenTextures(int n, Span<int> textures)
        {
            fixed (int* textures_ptr = textures)
            {
                GenTextures(n, textures_ptr);
            }
        }
        /// <inheritdoc cref="GenTextures(int, int*)"/>
        public static unsafe void GenTextures(int n, int[] textures)
        {
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
        public static unsafe bool GetBoolean(GetPName pname)
        {
            bool data;
            bool* data_ptr = &data;
            {
                GetBooleanv(pname, data_ptr);
            }
            return data;
        }
        /// <inheritdoc cref="GetBooleanv(GetPName, bool*)"/>
        public static unsafe void GetBoolean(GetPName pname, out bool data)
        {
            fixed (bool* data_ptr = &data)
            {
                GetBooleanv(pname, data_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferParameteriv(BufferTarget, BufferPName, int*)"/>
        public static unsafe void GetBufferParameteri(BufferTarget target, BufferPName pname, Span<int> @params)
        {
            fixed (int* @params_ptr = @params)
            {
                GetBufferParameteriv(target, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferParameteriv(BufferTarget, BufferPName, int*)"/>
        public static unsafe void GetBufferParameteri(BufferTarget target, BufferPName pname, int[] @params)
        {
            fixed (int* @params_ptr = @params)
            {
                GetBufferParameteriv(target, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferParameteriv(BufferTarget, BufferPName, int*)"/>
        public static unsafe int GetBufferParameteri(BufferTarget target, BufferPName pname)
        {
            int @params;
            int* @params_ptr = &@params;
            {
                GetBufferParameteriv(target, pname, @params_ptr);
            }
            return @params;
        }
        /// <inheritdoc cref="GetBufferParameteriv(BufferTarget, BufferPName, int*)"/>
        public static unsafe void GetBufferParameteri(BufferTarget target, BufferPName pname, out int @params)
        {
            fixed (int* @params_ptr = &@params)
            {
                GetBufferParameteriv(target, pname, @params_ptr);
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
        public static unsafe void GetFixed(GetPName pname, Span<int> @params)
        {
            fixed (int* @params_ptr = @params)
            {
                GetFixedv(pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="GetFixedv(GetPName, int*)"/>
        public static unsafe void GetFixed(GetPName pname, int[] @params)
        {
            fixed (int* @params_ptr = @params)
            {
                GetFixedv(pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="GetFixedv(GetPName, int*)"/>
        public static unsafe void GetFixed(GetPName pname, ref int @params)
        {
            fixed (int* @params_ptr = &@params)
            {
                GetFixedv(pname, @params_ptr);
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
        public static unsafe float GetFloat(GetPName pname)
        {
            float data;
            float* data_ptr = &data;
            {
                GetFloatv(pname, data_ptr);
            }
            return data;
        }
        /// <inheritdoc cref="GetFloatv(GetPName, float*)"/>
        public static unsafe void GetFloat(GetPName pname, out float data)
        {
            fixed (float* data_ptr = &data)
            {
                GetFloatv(pname, data_ptr);
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
        public static unsafe int GetInteger(GetPName pname)
        {
            int data;
            int* data_ptr = &data;
            {
                GetIntegerv(pname, data_ptr);
            }
            return data;
        }
        /// <inheritdoc cref="GetIntegerv(GetPName, int*)"/>
        public static unsafe void GetInteger(GetPName pname, out int data)
        {
            fixed (int* data_ptr = &data)
            {
                GetIntegerv(pname, data_ptr);
            }
        }
        /// <inheritdoc cref="GetLightfv(LightName, LightParameter, float*)"/>
        public static unsafe void GetLightf(LightName light, LightParameter pname, Span<float> @params)
        {
            fixed (float* @params_ptr = @params)
            {
                GetLightfv(light, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="GetLightfv(LightName, LightParameter, float*)"/>
        public static unsafe void GetLightf(LightName light, LightParameter pname, float[] @params)
        {
            fixed (float* @params_ptr = @params)
            {
                GetLightfv(light, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="GetLightfv(LightName, LightParameter, float*)"/>
        public static unsafe float GetLightf(LightName light, LightParameter pname)
        {
            float @params;
            float* @params_ptr = &@params;
            {
                GetLightfv(light, pname, @params_ptr);
            }
            return @params;
        }
        /// <inheritdoc cref="GetLightfv(LightName, LightParameter, float*)"/>
        public static unsafe void GetLightf(LightName light, LightParameter pname, out float @params)
        {
            fixed (float* @params_ptr = &@params)
            {
                GetLightfv(light, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="GetLightxv(LightName, LightParameter, int*)"/>
        public static unsafe void GetLightx(LightName light, LightParameter pname, Span<int> @params)
        {
            fixed (int* @params_ptr = @params)
            {
                GetLightxv(light, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="GetLightxv(LightName, LightParameter, int*)"/>
        public static unsafe void GetLightx(LightName light, LightParameter pname, int[] @params)
        {
            fixed (int* @params_ptr = @params)
            {
                GetLightxv(light, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="GetLightxv(LightName, LightParameter, int*)"/>
        public static unsafe int GetLightx(LightName light, LightParameter pname)
        {
            int @params;
            int* @params_ptr = &@params;
            {
                GetLightxv(light, pname, @params_ptr);
            }
            return @params;
        }
        /// <inheritdoc cref="GetLightxv(LightName, LightParameter, int*)"/>
        public static unsafe void GetLightx(LightName light, LightParameter pname, out int @params)
        {
            fixed (int* @params_ptr = &@params)
            {
                GetLightxv(light, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="GetMaterialfv(TriangleFace, MaterialParameter, float*)"/>
        public static unsafe void GetMaterialf(TriangleFace face, MaterialParameter pname, Span<float> @params)
        {
            fixed (float* @params_ptr = @params)
            {
                GetMaterialfv(face, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="GetMaterialfv(TriangleFace, MaterialParameter, float*)"/>
        public static unsafe void GetMaterialf(TriangleFace face, MaterialParameter pname, float[] @params)
        {
            fixed (float* @params_ptr = @params)
            {
                GetMaterialfv(face, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="GetMaterialfv(TriangleFace, MaterialParameter, float*)"/>
        public static unsafe float GetMaterialf(TriangleFace face, MaterialParameter pname)
        {
            float @params;
            float* @params_ptr = &@params;
            {
                GetMaterialfv(face, pname, @params_ptr);
            }
            return @params;
        }
        /// <inheritdoc cref="GetMaterialfv(TriangleFace, MaterialParameter, float*)"/>
        public static unsafe void GetMaterialf(TriangleFace face, MaterialParameter pname, out float @params)
        {
            fixed (float* @params_ptr = &@params)
            {
                GetMaterialfv(face, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="GetMaterialxv(TriangleFace, MaterialParameter, int*)"/>
        public static unsafe void GetMaterialx(TriangleFace face, MaterialParameter pname, Span<int> @params)
        {
            fixed (int* @params_ptr = @params)
            {
                GetMaterialxv(face, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="GetMaterialxv(TriangleFace, MaterialParameter, int*)"/>
        public static unsafe void GetMaterialx(TriangleFace face, MaterialParameter pname, int[] @params)
        {
            fixed (int* @params_ptr = @params)
            {
                GetMaterialxv(face, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="GetMaterialxv(TriangleFace, MaterialParameter, int*)"/>
        public static unsafe int GetMaterialx(TriangleFace face, MaterialParameter pname)
        {
            int @params;
            int* @params_ptr = &@params;
            {
                GetMaterialxv(face, pname, @params_ptr);
            }
            return @params;
        }
        /// <inheritdoc cref="GetMaterialxv(TriangleFace, MaterialParameter, int*)"/>
        public static unsafe void GetMaterialx(TriangleFace face, MaterialParameter pname, out int @params)
        {
            fixed (int* @params_ptr = &@params)
            {
                GetMaterialxv(face, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="GetPointerv(GetPointervPName, void**)"/>
        public static unsafe void GetPointer(GetPointervPName pname, void** @params)
        {
            GetPointerv(pname, @params);
        }
        /// <inheritdoc cref="GetString_(StringName)"/>
        public static unsafe string? GetString(StringName name)
        {
            string? returnValue_str;
            byte* returnValue;
            returnValue = GetString_(name);
            returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
            return returnValue_str;
        }
        /// <inheritdoc cref="GetTexEnvfv(TextureEnvTarget, TextureEnvParameter, float*)"/>
        public static unsafe void GetTexEnvf(TextureEnvTarget target, TextureEnvParameter pname, Span<float> @params)
        {
            fixed (float* @params_ptr = @params)
            {
                GetTexEnvfv(target, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="GetTexEnvfv(TextureEnvTarget, TextureEnvParameter, float*)"/>
        public static unsafe void GetTexEnvf(TextureEnvTarget target, TextureEnvParameter pname, float[] @params)
        {
            fixed (float* @params_ptr = @params)
            {
                GetTexEnvfv(target, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="GetTexEnvfv(TextureEnvTarget, TextureEnvParameter, float*)"/>
        public static unsafe float GetTexEnvf(TextureEnvTarget target, TextureEnvParameter pname)
        {
            float @params;
            float* @params_ptr = &@params;
            {
                GetTexEnvfv(target, pname, @params_ptr);
            }
            return @params;
        }
        /// <inheritdoc cref="GetTexEnvfv(TextureEnvTarget, TextureEnvParameter, float*)"/>
        public static unsafe void GetTexEnvf(TextureEnvTarget target, TextureEnvParameter pname, out float @params)
        {
            fixed (float* @params_ptr = &@params)
            {
                GetTexEnvfv(target, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="GetTexEnviv(TextureEnvTarget, TextureEnvParameter, int*)"/>
        public static unsafe void GetTexEnvi(TextureEnvTarget target, TextureEnvParameter pname, Span<int> @params)
        {
            fixed (int* @params_ptr = @params)
            {
                GetTexEnviv(target, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="GetTexEnviv(TextureEnvTarget, TextureEnvParameter, int*)"/>
        public static unsafe void GetTexEnvi(TextureEnvTarget target, TextureEnvParameter pname, int[] @params)
        {
            fixed (int* @params_ptr = @params)
            {
                GetTexEnviv(target, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="GetTexEnviv(TextureEnvTarget, TextureEnvParameter, int*)"/>
        public static unsafe int GetTexEnvi(TextureEnvTarget target, TextureEnvParameter pname)
        {
            int @params;
            int* @params_ptr = &@params;
            {
                GetTexEnviv(target, pname, @params_ptr);
            }
            return @params;
        }
        /// <inheritdoc cref="GetTexEnviv(TextureEnvTarget, TextureEnvParameter, int*)"/>
        public static unsafe void GetTexEnvi(TextureEnvTarget target, TextureEnvParameter pname, out int @params)
        {
            fixed (int* @params_ptr = &@params)
            {
                GetTexEnviv(target, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="GetTexEnvxv(TextureEnvTarget, TextureEnvParameter, int*)"/>
        public static unsafe void GetTexEnvx(TextureEnvTarget target, TextureEnvParameter pname, Span<int> @params)
        {
            fixed (int* @params_ptr = @params)
            {
                GetTexEnvxv(target, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="GetTexEnvxv(TextureEnvTarget, TextureEnvParameter, int*)"/>
        public static unsafe void GetTexEnvx(TextureEnvTarget target, TextureEnvParameter pname, int[] @params)
        {
            fixed (int* @params_ptr = @params)
            {
                GetTexEnvxv(target, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="GetTexEnvxv(TextureEnvTarget, TextureEnvParameter, int*)"/>
        public static unsafe int GetTexEnvx(TextureEnvTarget target, TextureEnvParameter pname)
        {
            int @params;
            int* @params_ptr = &@params;
            {
                GetTexEnvxv(target, pname, @params_ptr);
            }
            return @params;
        }
        /// <inheritdoc cref="GetTexEnvxv(TextureEnvTarget, TextureEnvParameter, int*)"/>
        public static unsafe void GetTexEnvx(TextureEnvTarget target, TextureEnvParameter pname, out int @params)
        {
            fixed (int* @params_ptr = &@params)
            {
                GetTexEnvxv(target, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="GetTexParameterfv(TextureTarget, GetTextureParameter, float*)"/>
        public static unsafe void GetTexParameterf(TextureTarget target, GetTextureParameter pname, Span<float> @params)
        {
            fixed (float* @params_ptr = @params)
            {
                GetTexParameterfv(target, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="GetTexParameterfv(TextureTarget, GetTextureParameter, float*)"/>
        public static unsafe void GetTexParameterf(TextureTarget target, GetTextureParameter pname, float[] @params)
        {
            fixed (float* @params_ptr = @params)
            {
                GetTexParameterfv(target, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="GetTexParameterfv(TextureTarget, GetTextureParameter, float*)"/>
        public static unsafe float GetTexParameterf(TextureTarget target, GetTextureParameter pname)
        {
            float @params;
            float* @params_ptr = &@params;
            {
                GetTexParameterfv(target, pname, @params_ptr);
            }
            return @params;
        }
        /// <inheritdoc cref="GetTexParameterfv(TextureTarget, GetTextureParameter, float*)"/>
        public static unsafe void GetTexParameterf(TextureTarget target, GetTextureParameter pname, out float @params)
        {
            fixed (float* @params_ptr = &@params)
            {
                GetTexParameterfv(target, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="GetTexParameteriv(TextureTarget, GetTextureParameter, int*)"/>
        public static unsafe void GetTexParameteri(TextureTarget target, GetTextureParameter pname, Span<int> @params)
        {
            fixed (int* @params_ptr = @params)
            {
                GetTexParameteriv(target, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="GetTexParameteriv(TextureTarget, GetTextureParameter, int*)"/>
        public static unsafe void GetTexParameteri(TextureTarget target, GetTextureParameter pname, int[] @params)
        {
            fixed (int* @params_ptr = @params)
            {
                GetTexParameteriv(target, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="GetTexParameteriv(TextureTarget, GetTextureParameter, int*)"/>
        public static unsafe int GetTexParameteri(TextureTarget target, GetTextureParameter pname)
        {
            int @params;
            int* @params_ptr = &@params;
            {
                GetTexParameteriv(target, pname, @params_ptr);
            }
            return @params;
        }
        /// <inheritdoc cref="GetTexParameteriv(TextureTarget, GetTextureParameter, int*)"/>
        public static unsafe void GetTexParameteri(TextureTarget target, GetTextureParameter pname, out int @params)
        {
            fixed (int* @params_ptr = &@params)
            {
                GetTexParameteriv(target, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="GetTexParameterxv(TextureTarget, GetTextureParameter, int*)"/>
        public static unsafe void GetTexParameterx(TextureTarget target, GetTextureParameter pname, Span<int> @params)
        {
            fixed (int* @params_ptr = @params)
            {
                GetTexParameterxv(target, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="GetTexParameterxv(TextureTarget, GetTextureParameter, int*)"/>
        public static unsafe void GetTexParameterx(TextureTarget target, GetTextureParameter pname, int[] @params)
        {
            fixed (int* @params_ptr = @params)
            {
                GetTexParameterxv(target, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="GetTexParameterxv(TextureTarget, GetTextureParameter, int*)"/>
        public static unsafe int GetTexParameterx(TextureTarget target, GetTextureParameter pname)
        {
            int @params;
            int* @params_ptr = &@params;
            {
                GetTexParameterxv(target, pname, @params_ptr);
            }
            return @params;
        }
        /// <inheritdoc cref="GetTexParameterxv(TextureTarget, GetTextureParameter, int*)"/>
        public static unsafe void GetTexParameterx(TextureTarget target, GetTextureParameter pname, out int @params)
        {
            fixed (int* @params_ptr = &@params)
            {
                GetTexParameterxv(target, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="Lightfv(LightName, LightParameter, float*)"/>
        public static unsafe void Lightf(LightName light, LightParameter pname, ReadOnlySpan<float> @params)
        {
            fixed (float* @params_ptr = @params)
            {
                Lightfv(light, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="Lightfv(LightName, LightParameter, float*)"/>
        public static unsafe void Lightf(LightName light, LightParameter pname, float[] @params)
        {
            fixed (float* @params_ptr = @params)
            {
                Lightfv(light, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="Lightfv(LightName, LightParameter, float*)"/>
        public static unsafe void Lightf(LightName light, LightParameter pname, ref readonly float @params)
        {
            fixed (float* @params_ptr = &@params)
            {
                Lightfv(light, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="LightModelfv(LightModelParameter, float*)"/>
        public static unsafe void LightModelf(LightModelParameter pname, ReadOnlySpan<float> @params)
        {
            fixed (float* @params_ptr = @params)
            {
                LightModelfv(pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="LightModelfv(LightModelParameter, float*)"/>
        public static unsafe void LightModelf(LightModelParameter pname, float[] @params)
        {
            fixed (float* @params_ptr = @params)
            {
                LightModelfv(pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="LightModelfv(LightModelParameter, float*)"/>
        public static unsafe void LightModelf(LightModelParameter pname, ref readonly float @params)
        {
            fixed (float* @params_ptr = &@params)
            {
                LightModelfv(pname, @params_ptr);
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
        public static unsafe void LightModelx(LightModelParameter pname, ref readonly int param)
        {
            fixed (int* param_ptr = &param)
            {
                LightModelxv(pname, param_ptr);
            }
        }
        /// <inheritdoc cref="Lightxv(LightName, LightParameter, int*)"/>
        public static unsafe void Lightx(LightName light, LightParameter pname, ReadOnlySpan<int> @params)
        {
            fixed (int* @params_ptr = @params)
            {
                Lightxv(light, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="Lightxv(LightName, LightParameter, int*)"/>
        public static unsafe void Lightx(LightName light, LightParameter pname, int[] @params)
        {
            fixed (int* @params_ptr = @params)
            {
                Lightxv(light, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="Lightxv(LightName, LightParameter, int*)"/>
        public static unsafe void Lightx(LightName light, LightParameter pname, ref readonly int @params)
        {
            fixed (int* @params_ptr = &@params)
            {
                Lightxv(light, pname, @params_ptr);
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
        public static unsafe void LoadMatrixf(ref readonly float m)
        {
            fixed (float* m_ptr = &m)
            {
                LoadMatrixf(m_ptr);
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
        public static unsafe void LoadMatrixx(ref readonly int m)
        {
            fixed (int* m_ptr = &m)
            {
                LoadMatrixx(m_ptr);
            }
        }
        /// <inheritdoc cref="Materialfv(TriangleFace, MaterialParameter, float*)"/>
        public static unsafe void Materialf(TriangleFace face, MaterialParameter pname, ReadOnlySpan<float> @params)
        {
            fixed (float* @params_ptr = @params)
            {
                Materialfv(face, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="Materialfv(TriangleFace, MaterialParameter, float*)"/>
        public static unsafe void Materialf(TriangleFace face, MaterialParameter pname, float[] @params)
        {
            fixed (float* @params_ptr = @params)
            {
                Materialfv(face, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="Materialfv(TriangleFace, MaterialParameter, float*)"/>
        public static unsafe void Materialf(TriangleFace face, MaterialParameter pname, ref readonly float @params)
        {
            fixed (float* @params_ptr = &@params)
            {
                Materialfv(face, pname, @params_ptr);
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
        public static unsafe void Materialx(TriangleFace face, MaterialParameter pname, ref readonly int param)
        {
            fixed (int* param_ptr = &param)
            {
                Materialxv(face, pname, param_ptr);
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
        public static unsafe void MultMatrixf(ref readonly float m)
        {
            fixed (float* m_ptr = &m)
            {
                MultMatrixf(m_ptr);
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
        public static unsafe void MultMatrixx(ref readonly int m)
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
        public static unsafe void NormalPointer<T1>(NormalPointerType type, int stride, ref readonly T1 pointer)
            where T1 : unmanaged
        {
            fixed (void* pointer_ptr = &pointer)
            {
                NormalPointer(type, stride, pointer_ptr);
            }
        }
        /// <inheritdoc cref="PointParameterfv(PointParameterNameARB, float*)"/>
        public static unsafe void PointParameterf(PointParameterNameARB pname, ReadOnlySpan<float> @params)
        {
            fixed (float* @params_ptr = @params)
            {
                PointParameterfv(pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="PointParameterfv(PointParameterNameARB, float*)"/>
        public static unsafe void PointParameterf(PointParameterNameARB pname, float[] @params)
        {
            fixed (float* @params_ptr = @params)
            {
                PointParameterfv(pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="PointParameterfv(PointParameterNameARB, float*)"/>
        public static unsafe void PointParameterf(PointParameterNameARB pname, ref readonly float @params)
        {
            fixed (float* @params_ptr = &@params)
            {
                PointParameterfv(pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="PointParameterxv(PointParameterNameARB, int*)"/>
        public static unsafe void PointParameterx(PointParameterNameARB pname, ReadOnlySpan<int> @params)
        {
            fixed (int* @params_ptr = @params)
            {
                PointParameterxv(pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="PointParameterxv(PointParameterNameARB, int*)"/>
        public static unsafe void PointParameterx(PointParameterNameARB pname, int[] @params)
        {
            fixed (int* @params_ptr = @params)
            {
                PointParameterxv(pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="PointParameterxv(PointParameterNameARB, int*)"/>
        public static unsafe void PointParameterx(PointParameterNameARB pname, ref readonly int @params)
        {
            fixed (int* @params_ptr = &@params)
            {
                PointParameterxv(pname, @params_ptr);
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
        public static unsafe void TexCoordPointer<T1>(int size, TexCoordPointerType type, int stride, ref readonly T1 pointer)
            where T1 : unmanaged
        {
            fixed (void* pointer_ptr = &pointer)
            {
                TexCoordPointer(size, type, stride, pointer_ptr);
            }
        }
        /// <inheritdoc cref="TexEnvfv(TextureEnvTarget, TextureEnvParameter, float*)"/>
        public static unsafe void TexEnvf(TextureEnvTarget target, TextureEnvParameter pname, ReadOnlySpan<float> @params)
        {
            fixed (float* @params_ptr = @params)
            {
                TexEnvfv(target, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="TexEnvfv(TextureEnvTarget, TextureEnvParameter, float*)"/>
        public static unsafe void TexEnvf(TextureEnvTarget target, TextureEnvParameter pname, float[] @params)
        {
            fixed (float* @params_ptr = @params)
            {
                TexEnvfv(target, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="TexEnvfv(TextureEnvTarget, TextureEnvParameter, float*)"/>
        public static unsafe void TexEnvf(TextureEnvTarget target, TextureEnvParameter pname, ref readonly float @params)
        {
            fixed (float* @params_ptr = &@params)
            {
                TexEnvfv(target, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="TexEnviv(TextureEnvTarget, TextureEnvParameter, int*)"/>
        public static unsafe void TexEnvi(TextureEnvTarget target, TextureEnvParameter pname, ReadOnlySpan<int> @params)
        {
            fixed (int* @params_ptr = @params)
            {
                TexEnviv(target, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="TexEnviv(TextureEnvTarget, TextureEnvParameter, int*)"/>
        public static unsafe void TexEnvi(TextureEnvTarget target, TextureEnvParameter pname, int[] @params)
        {
            fixed (int* @params_ptr = @params)
            {
                TexEnviv(target, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="TexEnviv(TextureEnvTarget, TextureEnvParameter, int*)"/>
        public static unsafe void TexEnvi(TextureEnvTarget target, TextureEnvParameter pname, ref readonly int @params)
        {
            fixed (int* @params_ptr = &@params)
            {
                TexEnviv(target, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="TexEnvxv(TextureEnvTarget, TextureEnvParameter, int*)"/>
        public static unsafe void TexEnvx(TextureEnvTarget target, TextureEnvParameter pname, ReadOnlySpan<int> @params)
        {
            fixed (int* @params_ptr = @params)
            {
                TexEnvxv(target, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="TexEnvxv(TextureEnvTarget, TextureEnvParameter, int*)"/>
        public static unsafe void TexEnvx(TextureEnvTarget target, TextureEnvParameter pname, int[] @params)
        {
            fixed (int* @params_ptr = @params)
            {
                TexEnvxv(target, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="TexEnvxv(TextureEnvTarget, TextureEnvParameter, int*)"/>
        public static unsafe void TexEnvx(TextureEnvTarget target, TextureEnvParameter pname, ref readonly int @params)
        {
            fixed (int* @params_ptr = &@params)
            {
                TexEnvxv(target, pname, @params_ptr);
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
        public static unsafe void TexImage2D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, PixelFormat format, PixelType type, ref readonly T1 pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = &pixels)
            {
                TexImage2D(target, level, internalformat, width, height, border, format, type, pixels_ptr);
            }
        }
        /// <inheritdoc cref="TexParameterfv(TextureTarget, TextureParameterName, float*)"/>
        public static unsafe void TexParameterf(TextureTarget target, TextureParameterName pname, ReadOnlySpan<float> @params)
        {
            fixed (float* @params_ptr = @params)
            {
                TexParameterfv(target, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="TexParameterfv(TextureTarget, TextureParameterName, float*)"/>
        public static unsafe void TexParameterf(TextureTarget target, TextureParameterName pname, float[] @params)
        {
            fixed (float* @params_ptr = @params)
            {
                TexParameterfv(target, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="TexParameterfv(TextureTarget, TextureParameterName, float*)"/>
        public static unsafe void TexParameterf(TextureTarget target, TextureParameterName pname, ref readonly float @params)
        {
            fixed (float* @params_ptr = &@params)
            {
                TexParameterfv(target, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="TexParameteriv(TextureTarget, TextureParameterName, int*)"/>
        public static unsafe void TexParameteri(TextureTarget target, TextureParameterName pname, ReadOnlySpan<int> @params)
        {
            fixed (int* @params_ptr = @params)
            {
                TexParameteriv(target, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="TexParameteriv(TextureTarget, TextureParameterName, int*)"/>
        public static unsafe void TexParameteri(TextureTarget target, TextureParameterName pname, int[] @params)
        {
            fixed (int* @params_ptr = @params)
            {
                TexParameteriv(target, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="TexParameteriv(TextureTarget, TextureParameterName, int*)"/>
        public static unsafe void TexParameteri(TextureTarget target, TextureParameterName pname, ref readonly int @params)
        {
            fixed (int* @params_ptr = &@params)
            {
                TexParameteriv(target, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="TexParameterxv(TextureTarget, GetTextureParameter, int*)"/>
        public static unsafe void TexParameterx(TextureTarget target, GetTextureParameter pname, ReadOnlySpan<int> @params)
        {
            fixed (int* @params_ptr = @params)
            {
                TexParameterxv(target, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="TexParameterxv(TextureTarget, GetTextureParameter, int*)"/>
        public static unsafe void TexParameterx(TextureTarget target, GetTextureParameter pname, int[] @params)
        {
            fixed (int* @params_ptr = @params)
            {
                TexParameterxv(target, pname, @params_ptr);
            }
        }
        /// <inheritdoc cref="TexParameterxv(TextureTarget, GetTextureParameter, int*)"/>
        public static unsafe void TexParameterx(TextureTarget target, GetTextureParameter pname, ref readonly int @params)
        {
            fixed (int* @params_ptr = &@params)
            {
                TexParameterxv(target, pname, @params_ptr);
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
        public static unsafe void TexSubImage2D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, ref readonly T1 pixels)
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
        public static unsafe void VertexPointer<T1>(int size, VertexPointerType type, int stride, ref readonly T1 pointer)
            where T1 : unmanaged
        {
            fixed (void* pointer_ptr = &pointer)
            {
                VertexPointer(size, type, stride, pointer_ptr);
            }
        }
        public static unsafe partial class APPLE
        {
            /// <inheritdoc cref="GetInteger64vAPPLE(GetPName, long*)"/>
            public static unsafe void GetInteger64vAPPLE(GetPName pname, Span<long> @params)
            {
                fixed (long* @params_ptr = @params)
                {
                    GetInteger64vAPPLE(pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetInteger64vAPPLE(GetPName, long*)"/>
            public static unsafe void GetInteger64vAPPLE(GetPName pname, long[] @params)
            {
                fixed (long* @params_ptr = @params)
                {
                    GetInteger64vAPPLE(pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetInteger64vAPPLE(GetPName, long*)"/>
            public static unsafe void GetInteger64vAPPLE(GetPName pname, ref long @params)
            {
                fixed (long* @params_ptr = &@params)
                {
                    GetInteger64vAPPLE(pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetSyncivAPPLE(GLSync, SyncParameterName, int, int*, int*)"/>
            public static unsafe void GetSyncivAPPLE(GLSync sync, SyncParameterName pname, int count, Span<int> length, Span<int> values)
            {
                fixed (int* values_ptr = values)
                {
                    fixed (int* length_ptr = length)
                    {
                        GetSyncivAPPLE(sync, pname, count, length_ptr, values_ptr);
                    }
                }
            }
            /// <inheritdoc cref="GetSyncivAPPLE(GLSync, SyncParameterName, int, int*, int*)"/>
            public static unsafe void GetSyncivAPPLE(GLSync sync, SyncParameterName pname, int count, int[] length, int[] values)
            {
                fixed (int* values_ptr = values)
                {
                    fixed (int* length_ptr = length)
                    {
                        GetSyncivAPPLE(sync, pname, count, length_ptr, values_ptr);
                    }
                }
            }
            /// <inheritdoc cref="GetSyncivAPPLE(GLSync, SyncParameterName, int, int*, int*)"/>
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
            /// <inheritdoc cref="DiscardFramebufferEXT(FramebufferTarget, int, InvalidateFramebufferAttachment*)"/>
            public static unsafe void DiscardFramebufferEXT(FramebufferTarget target, int numAttachments, ReadOnlySpan<InvalidateFramebufferAttachment> attachments)
            {
                fixed (InvalidateFramebufferAttachment* attachments_ptr = attachments)
                {
                    DiscardFramebufferEXT(target, numAttachments, attachments_ptr);
                }
            }
            /// <inheritdoc cref="DiscardFramebufferEXT(FramebufferTarget, int, InvalidateFramebufferAttachment*)"/>
            public static unsafe void DiscardFramebufferEXT(FramebufferTarget target, int numAttachments, InvalidateFramebufferAttachment[] attachments)
            {
                fixed (InvalidateFramebufferAttachment* attachments_ptr = attachments)
                {
                    DiscardFramebufferEXT(target, numAttachments, attachments_ptr);
                }
            }
            /// <inheritdoc cref="DiscardFramebufferEXT(FramebufferTarget, int, InvalidateFramebufferAttachment*)"/>
            public static unsafe void DiscardFramebufferEXT(FramebufferTarget target, int numAttachments, ref readonly InvalidateFramebufferAttachment attachments)
            {
                fixed (InvalidateFramebufferAttachment* attachments_ptr = &attachments)
                {
                    DiscardFramebufferEXT(target, numAttachments, attachments_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformfvEXT(int, int, int, float*)"/>
            public static unsafe void GetnUniformfvEXT(int program, int location, int bufSize, Span<float> @params)
            {
                fixed (float* @params_ptr = @params)
                {
                    GetnUniformfvEXT(program, location, bufSize, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformfvEXT(int, int, int, float*)"/>
            public static unsafe void GetnUniformfvEXT(int program, int location, int bufSize, float[] @params)
            {
                fixed (float* @params_ptr = @params)
                {
                    GetnUniformfvEXT(program, location, bufSize, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformfvEXT(int, int, int, float*)"/>
            public static unsafe void GetnUniformfvEXT(int program, int location, int bufSize, ref float @params)
            {
                fixed (float* @params_ptr = &@params)
                {
                    GetnUniformfvEXT(program, location, bufSize, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformivEXT(int, int, int, int*)"/>
            public static unsafe void GetnUniformivEXT(int program, int location, int bufSize, Span<int> @params)
            {
                fixed (int* @params_ptr = @params)
                {
                    GetnUniformivEXT(program, location, bufSize, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformivEXT(int, int, int, int*)"/>
            public static unsafe void GetnUniformivEXT(int program, int location, int bufSize, int[] @params)
            {
                fixed (int* @params_ptr = @params)
                {
                    GetnUniformivEXT(program, location, bufSize, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformivEXT(int, int, int, int*)"/>
            public static unsafe void GetnUniformivEXT(int program, int location, int bufSize, ref int @params)
            {
                fixed (int* @params_ptr = &@params)
                {
                    GetnUniformivEXT(program, location, bufSize, @params_ptr);
                }
            }
            /// <inheritdoc cref="InsertEventMarkerEXT(int, byte*)"/>
            public static unsafe void InsertEventMarkerEXT(int length, string marker)
            {
                byte* marker_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(marker);
                InsertEventMarkerEXT(length, marker_ptr);
                Marshal.FreeCoTaskMem((IntPtr)marker_ptr);
            }
            /// <inheritdoc cref="MultiDrawArraysEXT(PrimitiveType, int*, int*, int)"/>
            public static unsafe void MultiDrawArraysEXT(PrimitiveType mode, ReadOnlySpan<int> first, ReadOnlySpan<int> count, int primcount)
            {
                fixed (int* count_ptr = count)
                {
                    fixed (int* first_ptr = first)
                    {
                        MultiDrawArraysEXT(mode, first_ptr, count_ptr, primcount);
                    }
                }
            }
            /// <inheritdoc cref="MultiDrawArraysEXT(PrimitiveType, int*, int*, int)"/>
            public static unsafe void MultiDrawArraysEXT(PrimitiveType mode, int[] first, int[] count, int primcount)
            {
                fixed (int* count_ptr = count)
                {
                    fixed (int* first_ptr = first)
                    {
                        MultiDrawArraysEXT(mode, first_ptr, count_ptr, primcount);
                    }
                }
            }
            /// <inheritdoc cref="MultiDrawArraysEXT(PrimitiveType, int*, int*, int)"/>
            public static unsafe void MultiDrawArraysEXT(PrimitiveType mode, ref readonly int first, ref readonly int count, int primcount)
            {
                fixed (int* first_ptr = &first)
                fixed (int* count_ptr = &count)
                {
                    MultiDrawArraysEXT(mode, first_ptr, count_ptr, primcount);
                }
            }
            /// <inheritdoc cref="MultiDrawElementsEXT(PrimitiveType, int*, DrawElementsType, void**, int)"/>
            public static unsafe void MultiDrawElementsEXT(PrimitiveType mode, ReadOnlySpan<int> count, DrawElementsType type, void** indices, int primcount)
            {
                fixed (int* count_ptr = count)
                {
                    MultiDrawElementsEXT(mode, count_ptr, type, indices, primcount);
                }
            }
            /// <inheritdoc cref="MultiDrawElementsEXT(PrimitiveType, int*, DrawElementsType, void**, int)"/>
            public static unsafe void MultiDrawElementsEXT(PrimitiveType mode, int[] count, DrawElementsType type, void** indices, int primcount)
            {
                fixed (int* count_ptr = count)
                {
                    MultiDrawElementsEXT(mode, count_ptr, type, indices, primcount);
                }
            }
            /// <inheritdoc cref="MultiDrawElementsEXT(PrimitiveType, int*, DrawElementsType, void**, int)"/>
            public static unsafe void MultiDrawElementsEXT(PrimitiveType mode, ref readonly int count, DrawElementsType type, void** indices, int primcount)
            {
                fixed (int* count_ptr = &count)
                {
                    MultiDrawElementsEXT(mode, count_ptr, type, indices, primcount);
                }
            }
            /// <inheritdoc cref="PushGroupMarkerEXT(int, byte*)"/>
            public static unsafe void PushGroupMarkerEXT(int length, string marker)
            {
                byte* marker_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(marker);
                PushGroupMarkerEXT(length, marker_ptr);
                Marshal.FreeCoTaskMem((IntPtr)marker_ptr);
            }
            /// <inheritdoc cref="ReadnPixelsEXT(int, int, int, int, PixelFormat, PixelType, int, void*)"/>
            public static unsafe void ReadnPixelsEXT(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, IntPtr data)
            {
                void* data_vptr = (void*)data;
                ReadnPixelsEXT(x, y, width, height, format, type, bufSize, data_vptr);
            }
            /// <inheritdoc cref="ReadnPixelsEXT(int, int, int, int, PixelFormat, PixelType, int, void*)"/>
            public static unsafe void ReadnPixelsEXT<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, Span<T1> data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    ReadnPixelsEXT(x, y, width, height, format, type, bufSize, data_ptr);
                }
            }
            /// <inheritdoc cref="ReadnPixelsEXT(int, int, int, int, PixelFormat, PixelType, int, void*)"/>
            public static unsafe void ReadnPixelsEXT<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, T1[] data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    ReadnPixelsEXT(x, y, width, height, format, type, bufSize, data_ptr);
                }
            }
            /// <inheritdoc cref="ReadnPixelsEXT(int, int, int, int, PixelFormat, PixelType, int, void*)"/>
            public static unsafe void ReadnPixelsEXT<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, ref T1 data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    ReadnPixelsEXT(x, y, width, height, format, type, bufSize, data_ptr);
                }
            }
        }
        public static unsafe partial class IMG
        {
            /// <inheritdoc cref="ClipPlanefIMG(ClipPlaneName, float*)"/>
            public static unsafe void ClipPlanefIMG(ClipPlaneName p, ReadOnlySpan<float> eqn)
            {
                fixed (float* eqn_ptr = eqn)
                {
                    ClipPlanefIMG(p, eqn_ptr);
                }
            }
            /// <inheritdoc cref="ClipPlanefIMG(ClipPlaneName, float*)"/>
            public static unsafe void ClipPlanefIMG(ClipPlaneName p, float[] eqn)
            {
                fixed (float* eqn_ptr = eqn)
                {
                    ClipPlanefIMG(p, eqn_ptr);
                }
            }
            /// <inheritdoc cref="ClipPlanefIMG(ClipPlaneName, float*)"/>
            public static unsafe void ClipPlanefIMG(ClipPlaneName p, ref readonly float eqn)
            {
                fixed (float* eqn_ptr = &eqn)
                {
                    ClipPlanefIMG(p, eqn_ptr);
                }
            }
            /// <inheritdoc cref="ClipPlanexIMG(ClipPlaneName, int*)"/>
            public static unsafe void ClipPlanexIMG(ClipPlaneName p, ReadOnlySpan<int> eqn)
            {
                fixed (int* eqn_ptr = eqn)
                {
                    ClipPlanexIMG(p, eqn_ptr);
                }
            }
            /// <inheritdoc cref="ClipPlanexIMG(ClipPlaneName, int*)"/>
            public static unsafe void ClipPlanexIMG(ClipPlaneName p, int[] eqn)
            {
                fixed (int* eqn_ptr = eqn)
                {
                    ClipPlanexIMG(p, eqn_ptr);
                }
            }
            /// <inheritdoc cref="ClipPlanexIMG(ClipPlaneName, int*)"/>
            public static unsafe void ClipPlanexIMG(ClipPlaneName p, ref readonly int eqn)
            {
                fixed (int* eqn_ptr = &eqn)
                {
                    ClipPlanexIMG(p, eqn_ptr);
                }
            }
        }
        public static unsafe partial class NV
        {
            /// <inheritdoc cref="DeleteFencesNV(int, uint*)"/>
            public static unsafe void DeleteFencesNV(int n, ReadOnlySpan<uint> fences)
            {
                fixed (uint* fences_ptr = fences)
                {
                    DeleteFencesNV(n, fences_ptr);
                }
            }
            /// <inheritdoc cref="DeleteFencesNV(int, uint*)"/>
            public static unsafe void DeleteFencesNV(int n, uint[] fences)
            {
                fixed (uint* fences_ptr = fences)
                {
                    DeleteFencesNV(n, fences_ptr);
                }
            }
            /// <inheritdoc cref="DeleteFencesNV(int, uint*)"/>
            public static unsafe void DeleteFencesNV(int n, ref readonly uint fences)
            {
                fixed (uint* fences_ptr = &fences)
                {
                    DeleteFencesNV(n, fences_ptr);
                }
            }
            /// <inheritdoc cref="GenFencesNV(int, uint*)"/>
            public static unsafe void GenFencesNV(int n, Span<uint> fences)
            {
                fixed (uint* fences_ptr = fences)
                {
                    GenFencesNV(n, fences_ptr);
                }
            }
            /// <inheritdoc cref="GenFencesNV(int, uint*)"/>
            public static unsafe void GenFencesNV(int n, uint[] fences)
            {
                fixed (uint* fences_ptr = fences)
                {
                    GenFencesNV(n, fences_ptr);
                }
            }
            /// <inheritdoc cref="GenFencesNV(int, uint*)"/>
            public static unsafe void GenFencesNV(int n, ref uint fences)
            {
                fixed (uint* fences_ptr = &fences)
                {
                    GenFencesNV(n, fences_ptr);
                }
            }
            /// <inheritdoc cref="GetFenceivNV(uint, FenceParameterNameNV, int*)"/>
            public static unsafe void GetFenceivNV(uint fence, FenceParameterNameNV pname, Span<int> @params)
            {
                fixed (int* @params_ptr = @params)
                {
                    GetFenceivNV(fence, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetFenceivNV(uint, FenceParameterNameNV, int*)"/>
            public static unsafe void GetFenceivNV(uint fence, FenceParameterNameNV pname, int[] @params)
            {
                fixed (int* @params_ptr = @params)
                {
                    GetFenceivNV(fence, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetFenceivNV(uint, FenceParameterNameNV, int*)"/>
            public static unsafe int GetFenceivNV(uint fence, FenceParameterNameNV pname)
            {
                int @params;
                int* @params_ptr = &@params;
                {
                    GetFenceivNV(fence, pname, @params_ptr);
                }
                return @params;
            }
            /// <inheritdoc cref="GetFenceivNV(uint, FenceParameterNameNV, int*)"/>
            public static unsafe void GetFenceivNV(uint fence, FenceParameterNameNV pname, out int @params)
            {
                fixed (int* @params_ptr = &@params)
                {
                    GetFenceivNV(fence, pname, @params_ptr);
                }
            }
        }
        public static unsafe partial class OES
        {
            /// <inheritdoc cref="ClipPlanefOES(ClipPlaneName, float*)"/>
            public static unsafe void ClipPlanefOES(ClipPlaneName plane, ReadOnlySpan<float> equation)
            {
                fixed (float* equation_ptr = equation)
                {
                    ClipPlanefOES(plane, equation_ptr);
                }
            }
            /// <inheritdoc cref="ClipPlanefOES(ClipPlaneName, float*)"/>
            public static unsafe void ClipPlanefOES(ClipPlaneName plane, float[] equation)
            {
                fixed (float* equation_ptr = equation)
                {
                    ClipPlanefOES(plane, equation_ptr);
                }
            }
            /// <inheritdoc cref="ClipPlanefOES(ClipPlaneName, float*)"/>
            public static unsafe void ClipPlanefOES(ClipPlaneName plane, ref readonly float equation)
            {
                fixed (float* equation_ptr = &equation)
                {
                    ClipPlanefOES(plane, equation_ptr);
                }
            }
            /// <inheritdoc cref="ClipPlanexOES(ClipPlaneName, int*)"/>
            public static unsafe void ClipPlanexOES(ClipPlaneName plane, ReadOnlySpan<int> equation)
            {
                fixed (int* equation_ptr = equation)
                {
                    ClipPlanexOES(plane, equation_ptr);
                }
            }
            /// <inheritdoc cref="ClipPlanexOES(ClipPlaneName, int*)"/>
            public static unsafe void ClipPlanexOES(ClipPlaneName plane, int[] equation)
            {
                fixed (int* equation_ptr = equation)
                {
                    ClipPlanexOES(plane, equation_ptr);
                }
            }
            /// <inheritdoc cref="ClipPlanexOES(ClipPlaneName, int*)"/>
            public static unsafe void ClipPlanexOES(ClipPlaneName plane, ref readonly int equation)
            {
                fixed (int* equation_ptr = &equation)
                {
                    ClipPlanexOES(plane, equation_ptr);
                }
            }
            /// <inheritdoc cref="DeleteFramebuffersOES(int, int*)"/>
            public static unsafe void DeleteFramebuffersOES(int n, ReadOnlySpan<int> framebuffers)
            {
                fixed (int* framebuffers_ptr = framebuffers)
                {
                    DeleteFramebuffersOES(n, framebuffers_ptr);
                }
            }
            /// <inheritdoc cref="DeleteFramebuffersOES(int, int*)"/>
            public static unsafe void DeleteFramebuffersOES(int n, int[] framebuffers)
            {
                fixed (int* framebuffers_ptr = framebuffers)
                {
                    DeleteFramebuffersOES(n, framebuffers_ptr);
                }
            }
            /// <inheritdoc cref="DeleteFramebuffersOES(int, int*)"/>
            public static unsafe void DeleteFramebuffersOES(int n, ref readonly int framebuffers)
            {
                fixed (int* framebuffers_ptr = &framebuffers)
                {
                    DeleteFramebuffersOES(n, framebuffers_ptr);
                }
            }
            /// <inheritdoc cref="DeleteRenderbuffersOES(int, int*)"/>
            public static unsafe void DeleteRenderbuffersOES(int n, ReadOnlySpan<int> renderbuffers)
            {
                fixed (int* renderbuffers_ptr = renderbuffers)
                {
                    DeleteRenderbuffersOES(n, renderbuffers_ptr);
                }
            }
            /// <inheritdoc cref="DeleteRenderbuffersOES(int, int*)"/>
            public static unsafe void DeleteRenderbuffersOES(int n, int[] renderbuffers)
            {
                fixed (int* renderbuffers_ptr = renderbuffers)
                {
                    DeleteRenderbuffersOES(n, renderbuffers_ptr);
                }
            }
            /// <inheritdoc cref="DeleteRenderbuffersOES(int, int*)"/>
            public static unsafe void DeleteRenderbuffersOES(int n, ref readonly int renderbuffers)
            {
                fixed (int* renderbuffers_ptr = &renderbuffers)
                {
                    DeleteRenderbuffersOES(n, renderbuffers_ptr);
                }
            }
            /// <inheritdoc cref="DeleteVertexArraysOES(int, int*)"/>
            public static unsafe void DeleteVertexArraysOES(int n, ReadOnlySpan<int> arrays)
            {
                fixed (int* arrays_ptr = arrays)
                {
                    DeleteVertexArraysOES(n, arrays_ptr);
                }
            }
            /// <inheritdoc cref="DeleteVertexArraysOES(int, int*)"/>
            public static unsafe void DeleteVertexArraysOES(int n, int[] arrays)
            {
                fixed (int* arrays_ptr = arrays)
                {
                    DeleteVertexArraysOES(n, arrays_ptr);
                }
            }
            /// <inheritdoc cref="DeleteVertexArraysOES(int, int*)"/>
            public static unsafe void DeleteVertexArraysOES(int n, ref readonly int arrays)
            {
                fixed (int* arrays_ptr = &arrays)
                {
                    DeleteVertexArraysOES(n, arrays_ptr);
                }
            }
            /// <inheritdoc cref="DrawTexfvOES(float*)"/>
            public static unsafe void DrawTexfvOES(ReadOnlySpan<float> coords)
            {
                fixed (float* coords_ptr = coords)
                {
                    DrawTexfvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="DrawTexfvOES(float*)"/>
            public static unsafe void DrawTexfvOES(float[] coords)
            {
                fixed (float* coords_ptr = coords)
                {
                    DrawTexfvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="DrawTexfvOES(float*)"/>
            public static unsafe void DrawTexfvOES(ref readonly float coords)
            {
                fixed (float* coords_ptr = &coords)
                {
                    DrawTexfvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="DrawTexivOES(int*)"/>
            public static unsafe void DrawTexivOES(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    DrawTexivOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="DrawTexivOES(int*)"/>
            public static unsafe void DrawTexivOES(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    DrawTexivOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="DrawTexivOES(int*)"/>
            public static unsafe void DrawTexivOES(ref readonly int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    DrawTexivOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="DrawTexsvOES(short*)"/>
            public static unsafe void DrawTexsvOES(ReadOnlySpan<short> coords)
            {
                fixed (short* coords_ptr = coords)
                {
                    DrawTexsvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="DrawTexsvOES(short*)"/>
            public static unsafe void DrawTexsvOES(short[] coords)
            {
                fixed (short* coords_ptr = coords)
                {
                    DrawTexsvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="DrawTexsvOES(short*)"/>
            public static unsafe void DrawTexsvOES(ref readonly short coords)
            {
                fixed (short* coords_ptr = &coords)
                {
                    DrawTexsvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="DrawTexxvOES(int*)"/>
            public static unsafe void DrawTexxvOES(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    DrawTexxvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="DrawTexxvOES(int*)"/>
            public static unsafe void DrawTexxvOES(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    DrawTexxvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="DrawTexxvOES(int*)"/>
            public static unsafe void DrawTexxvOES(ref readonly int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    DrawTexxvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="EGLImageTargetRenderbufferStorageOES(All, void*)"/>
            public static unsafe void EGLImageTargetRenderbufferStorageOES(All target, IntPtr image)
            {
                void* image_vptr = (void*)image;
                EGLImageTargetRenderbufferStorageOES(target, image_vptr);
            }
            /// <inheritdoc cref="EGLImageTargetRenderbufferStorageOES(All, void*)"/>
            public static unsafe void EGLImageTargetRenderbufferStorageOES<T1>(All target, Span<T1> image)
                where T1 : unmanaged
            {
                fixed (void* image_ptr = image)
                {
                    EGLImageTargetRenderbufferStorageOES(target, image_ptr);
                }
            }
            /// <inheritdoc cref="EGLImageTargetRenderbufferStorageOES(All, void*)"/>
            public static unsafe void EGLImageTargetRenderbufferStorageOES<T1>(All target, T1[] image)
                where T1 : unmanaged
            {
                fixed (void* image_ptr = image)
                {
                    EGLImageTargetRenderbufferStorageOES(target, image_ptr);
                }
            }
            /// <inheritdoc cref="EGLImageTargetRenderbufferStorageOES(All, void*)"/>
            public static unsafe void EGLImageTargetRenderbufferStorageOES<T1>(All target, ref T1 image)
                where T1 : unmanaged
            {
                fixed (void* image_ptr = &image)
                {
                    EGLImageTargetRenderbufferStorageOES(target, image_ptr);
                }
            }
            /// <inheritdoc cref="EGLImageTargetTexture2DOES(All, void*)"/>
            public static unsafe void EGLImageTargetTexture2DOES(All target, IntPtr image)
            {
                void* image_vptr = (void*)image;
                EGLImageTargetTexture2DOES(target, image_vptr);
            }
            /// <inheritdoc cref="EGLImageTargetTexture2DOES(All, void*)"/>
            public static unsafe void EGLImageTargetTexture2DOES<T1>(All target, Span<T1> image)
                where T1 : unmanaged
            {
                fixed (void* image_ptr = image)
                {
                    EGLImageTargetTexture2DOES(target, image_ptr);
                }
            }
            /// <inheritdoc cref="EGLImageTargetTexture2DOES(All, void*)"/>
            public static unsafe void EGLImageTargetTexture2DOES<T1>(All target, T1[] image)
                where T1 : unmanaged
            {
                fixed (void* image_ptr = image)
                {
                    EGLImageTargetTexture2DOES(target, image_ptr);
                }
            }
            /// <inheritdoc cref="EGLImageTargetTexture2DOES(All, void*)"/>
            public static unsafe void EGLImageTargetTexture2DOES<T1>(All target, ref T1 image)
                where T1 : unmanaged
            {
                fixed (void* image_ptr = &image)
                {
                    EGLImageTargetTexture2DOES(target, image_ptr);
                }
            }
            /// <inheritdoc cref="FogxvOES(FogPName, int*)"/>
            public static unsafe void FogxvOES(FogPName pname, ReadOnlySpan<int> param)
            {
                fixed (int* param_ptr = param)
                {
                    FogxvOES(pname, param_ptr);
                }
            }
            /// <inheritdoc cref="FogxvOES(FogPName, int*)"/>
            public static unsafe void FogxvOES(FogPName pname, int[] param)
            {
                fixed (int* param_ptr = param)
                {
                    FogxvOES(pname, param_ptr);
                }
            }
            /// <inheritdoc cref="FogxvOES(FogPName, int*)"/>
            public static unsafe void FogxvOES(FogPName pname, ref readonly int param)
            {
                fixed (int* param_ptr = &param)
                {
                    FogxvOES(pname, param_ptr);
                }
            }
            /// <inheritdoc cref="GenFramebuffersOES(int, int*)"/>
            public static unsafe void GenFramebuffersOES(int n, Span<int> framebuffers)
            {
                fixed (int* framebuffers_ptr = framebuffers)
                {
                    GenFramebuffersOES(n, framebuffers_ptr);
                }
            }
            /// <inheritdoc cref="GenFramebuffersOES(int, int*)"/>
            public static unsafe void GenFramebuffersOES(int n, int[] framebuffers)
            {
                fixed (int* framebuffers_ptr = framebuffers)
                {
                    GenFramebuffersOES(n, framebuffers_ptr);
                }
            }
            /// <inheritdoc cref="GenFramebuffersOES(int, int*)"/>
            public static unsafe void GenFramebuffersOES(int n, ref int framebuffers)
            {
                fixed (int* framebuffers_ptr = &framebuffers)
                {
                    GenFramebuffersOES(n, framebuffers_ptr);
                }
            }
            /// <inheritdoc cref="GenRenderbuffersOES(int, int*)"/>
            public static unsafe void GenRenderbuffersOES(int n, Span<int> renderbuffers)
            {
                fixed (int* renderbuffers_ptr = renderbuffers)
                {
                    GenRenderbuffersOES(n, renderbuffers_ptr);
                }
            }
            /// <inheritdoc cref="GenRenderbuffersOES(int, int*)"/>
            public static unsafe void GenRenderbuffersOES(int n, int[] renderbuffers)
            {
                fixed (int* renderbuffers_ptr = renderbuffers)
                {
                    GenRenderbuffersOES(n, renderbuffers_ptr);
                }
            }
            /// <inheritdoc cref="GenRenderbuffersOES(int, int*)"/>
            public static unsafe void GenRenderbuffersOES(int n, ref int renderbuffers)
            {
                fixed (int* renderbuffers_ptr = &renderbuffers)
                {
                    GenRenderbuffersOES(n, renderbuffers_ptr);
                }
            }
            /// <inheritdoc cref="GenVertexArraysOES(int, int*)"/>
            public static unsafe void GenVertexArraysOES(int n, Span<int> arrays)
            {
                fixed (int* arrays_ptr = arrays)
                {
                    GenVertexArraysOES(n, arrays_ptr);
                }
            }
            /// <inheritdoc cref="GenVertexArraysOES(int, int*)"/>
            public static unsafe void GenVertexArraysOES(int n, int[] arrays)
            {
                fixed (int* arrays_ptr = arrays)
                {
                    GenVertexArraysOES(n, arrays_ptr);
                }
            }
            /// <inheritdoc cref="GenVertexArraysOES(int, int*)"/>
            public static unsafe void GenVertexArraysOES(int n, ref int arrays)
            {
                fixed (int* arrays_ptr = &arrays)
                {
                    GenVertexArraysOES(n, arrays_ptr);
                }
            }
            /// <inheritdoc cref="GetClipPlanefOES(ClipPlaneName, float*)"/>
            public static unsafe void GetClipPlanefOES(ClipPlaneName plane, Span<float> equation)
            {
                fixed (float* equation_ptr = equation)
                {
                    GetClipPlanefOES(plane, equation_ptr);
                }
            }
            /// <inheritdoc cref="GetClipPlanefOES(ClipPlaneName, float*)"/>
            public static unsafe void GetClipPlanefOES(ClipPlaneName plane, float[] equation)
            {
                fixed (float* equation_ptr = equation)
                {
                    GetClipPlanefOES(plane, equation_ptr);
                }
            }
            /// <inheritdoc cref="GetClipPlanefOES(ClipPlaneName, float*)"/>
            public static unsafe void GetClipPlanefOES(ClipPlaneName plane, ref float equation)
            {
                fixed (float* equation_ptr = &equation)
                {
                    GetClipPlanefOES(plane, equation_ptr);
                }
            }
            /// <inheritdoc cref="GetClipPlanexOES(ClipPlaneName, int*)"/>
            public static unsafe void GetClipPlanexOES(ClipPlaneName plane, Span<int> equation)
            {
                fixed (int* equation_ptr = equation)
                {
                    GetClipPlanexOES(plane, equation_ptr);
                }
            }
            /// <inheritdoc cref="GetClipPlanexOES(ClipPlaneName, int*)"/>
            public static unsafe void GetClipPlanexOES(ClipPlaneName plane, int[] equation)
            {
                fixed (int* equation_ptr = equation)
                {
                    GetClipPlanexOES(plane, equation_ptr);
                }
            }
            /// <inheritdoc cref="GetClipPlanexOES(ClipPlaneName, int*)"/>
            public static unsafe void GetClipPlanexOES(ClipPlaneName plane, ref int equation)
            {
                fixed (int* equation_ptr = &equation)
                {
                    GetClipPlanexOES(plane, equation_ptr);
                }
            }
            /// <inheritdoc cref="GetFixedvOES(GetPName, int*)"/>
            public static unsafe void GetFixedvOES(GetPName pname, Span<int> @params)
            {
                fixed (int* @params_ptr = @params)
                {
                    GetFixedvOES(pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetFixedvOES(GetPName, int*)"/>
            public static unsafe void GetFixedvOES(GetPName pname, int[] @params)
            {
                fixed (int* @params_ptr = @params)
                {
                    GetFixedvOES(pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetFixedvOES(GetPName, int*)"/>
            public static unsafe int GetFixedvOES(GetPName pname)
            {
                int @params;
                int* @params_ptr = &@params;
                {
                    GetFixedvOES(pname, @params_ptr);
                }
                return @params;
            }
            /// <inheritdoc cref="GetFixedvOES(GetPName, int*)"/>
            public static unsafe void GetFixedvOES(GetPName pname, out int @params)
            {
                fixed (int* @params_ptr = &@params)
                {
                    GetFixedvOES(pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetFramebufferAttachmentParameterivOES(FramebufferTarget, FramebufferAttachment, FramebufferAttachmentParameterName, int*)"/>
            public static unsafe void GetFramebufferAttachmentParameterivOES(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, Span<int> @params)
            {
                fixed (int* @params_ptr = @params)
                {
                    GetFramebufferAttachmentParameterivOES(target, attachment, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetFramebufferAttachmentParameterivOES(FramebufferTarget, FramebufferAttachment, FramebufferAttachmentParameterName, int*)"/>
            public static unsafe void GetFramebufferAttachmentParameterivOES(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int[] @params)
            {
                fixed (int* @params_ptr = @params)
                {
                    GetFramebufferAttachmentParameterivOES(target, attachment, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetFramebufferAttachmentParameterivOES(FramebufferTarget, FramebufferAttachment, FramebufferAttachmentParameterName, int*)"/>
            public static unsafe int GetFramebufferAttachmentParameterivOES(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname)
            {
                int @params;
                int* @params_ptr = &@params;
                {
                    GetFramebufferAttachmentParameterivOES(target, attachment, pname, @params_ptr);
                }
                return @params;
            }
            /// <inheritdoc cref="GetFramebufferAttachmentParameterivOES(FramebufferTarget, FramebufferAttachment, FramebufferAttachmentParameterName, int*)"/>
            public static unsafe void GetFramebufferAttachmentParameterivOES(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, out int @params)
            {
                fixed (int* @params_ptr = &@params)
                {
                    GetFramebufferAttachmentParameterivOES(target, attachment, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetLightxvOES(LightName, LightParameter, int*)"/>
            public static unsafe void GetLightxvOES(LightName light, LightParameter pname, Span<int> @params)
            {
                fixed (int* @params_ptr = @params)
                {
                    GetLightxvOES(light, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetLightxvOES(LightName, LightParameter, int*)"/>
            public static unsafe void GetLightxvOES(LightName light, LightParameter pname, int[] @params)
            {
                fixed (int* @params_ptr = @params)
                {
                    GetLightxvOES(light, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetLightxvOES(LightName, LightParameter, int*)"/>
            public static unsafe int GetLightxvOES(LightName light, LightParameter pname)
            {
                int @params;
                int* @params_ptr = &@params;
                {
                    GetLightxvOES(light, pname, @params_ptr);
                }
                return @params;
            }
            /// <inheritdoc cref="GetLightxvOES(LightName, LightParameter, int*)"/>
            public static unsafe void GetLightxvOES(LightName light, LightParameter pname, out int @params)
            {
                fixed (int* @params_ptr = &@params)
                {
                    GetLightxvOES(light, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetMaterialxvOES(TriangleFace, MaterialParameter, int*)"/>
            public static unsafe void GetMaterialxvOES(TriangleFace face, MaterialParameter pname, Span<int> @params)
            {
                fixed (int* @params_ptr = @params)
                {
                    GetMaterialxvOES(face, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetMaterialxvOES(TriangleFace, MaterialParameter, int*)"/>
            public static unsafe void GetMaterialxvOES(TriangleFace face, MaterialParameter pname, int[] @params)
            {
                fixed (int* @params_ptr = @params)
                {
                    GetMaterialxvOES(face, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetMaterialxvOES(TriangleFace, MaterialParameter, int*)"/>
            public static unsafe int GetMaterialxvOES(TriangleFace face, MaterialParameter pname)
            {
                int @params;
                int* @params_ptr = &@params;
                {
                    GetMaterialxvOES(face, pname, @params_ptr);
                }
                return @params;
            }
            /// <inheritdoc cref="GetMaterialxvOES(TriangleFace, MaterialParameter, int*)"/>
            public static unsafe void GetMaterialxvOES(TriangleFace face, MaterialParameter pname, out int @params)
            {
                fixed (int* @params_ptr = &@params)
                {
                    GetMaterialxvOES(face, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetRenderbufferParameterivOES(RenderbufferTarget, RenderbufferParameterName, int*)"/>
            public static unsafe void GetRenderbufferParameterivOES(RenderbufferTarget target, RenderbufferParameterName pname, Span<int> @params)
            {
                fixed (int* @params_ptr = @params)
                {
                    GetRenderbufferParameterivOES(target, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetRenderbufferParameterivOES(RenderbufferTarget, RenderbufferParameterName, int*)"/>
            public static unsafe void GetRenderbufferParameterivOES(RenderbufferTarget target, RenderbufferParameterName pname, int[] @params)
            {
                fixed (int* @params_ptr = @params)
                {
                    GetRenderbufferParameterivOES(target, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetRenderbufferParameterivOES(RenderbufferTarget, RenderbufferParameterName, int*)"/>
            public static unsafe int GetRenderbufferParameterivOES(RenderbufferTarget target, RenderbufferParameterName pname)
            {
                int @params;
                int* @params_ptr = &@params;
                {
                    GetRenderbufferParameterivOES(target, pname, @params_ptr);
                }
                return @params;
            }
            /// <inheritdoc cref="GetRenderbufferParameterivOES(RenderbufferTarget, RenderbufferParameterName, int*)"/>
            public static unsafe void GetRenderbufferParameterivOES(RenderbufferTarget target, RenderbufferParameterName pname, out int @params)
            {
                fixed (int* @params_ptr = &@params)
                {
                    GetRenderbufferParameterivOES(target, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetTexEnvxvOES(TextureEnvTarget, TextureEnvParameter, int*)"/>
            public static unsafe void GetTexEnvxvOES(TextureEnvTarget target, TextureEnvParameter pname, Span<int> @params)
            {
                fixed (int* @params_ptr = @params)
                {
                    GetTexEnvxvOES(target, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetTexEnvxvOES(TextureEnvTarget, TextureEnvParameter, int*)"/>
            public static unsafe void GetTexEnvxvOES(TextureEnvTarget target, TextureEnvParameter pname, int[] @params)
            {
                fixed (int* @params_ptr = @params)
                {
                    GetTexEnvxvOES(target, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetTexEnvxvOES(TextureEnvTarget, TextureEnvParameter, int*)"/>
            public static unsafe int GetTexEnvxvOES(TextureEnvTarget target, TextureEnvParameter pname)
            {
                int @params;
                int* @params_ptr = &@params;
                {
                    GetTexEnvxvOES(target, pname, @params_ptr);
                }
                return @params;
            }
            /// <inheritdoc cref="GetTexEnvxvOES(TextureEnvTarget, TextureEnvParameter, int*)"/>
            public static unsafe void GetTexEnvxvOES(TextureEnvTarget target, TextureEnvParameter pname, out int @params)
            {
                fixed (int* @params_ptr = &@params)
                {
                    GetTexEnvxvOES(target, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetTexGenfvOES(TextureCoordName, TextureGenParameter, float*)"/>
            public static unsafe void GetTexGenfvOES(TextureCoordName coord, TextureGenParameter pname, Span<float> @params)
            {
                fixed (float* @params_ptr = @params)
                {
                    GetTexGenfvOES(coord, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetTexGenfvOES(TextureCoordName, TextureGenParameter, float*)"/>
            public static unsafe void GetTexGenfvOES(TextureCoordName coord, TextureGenParameter pname, float[] @params)
            {
                fixed (float* @params_ptr = @params)
                {
                    GetTexGenfvOES(coord, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetTexGenfvOES(TextureCoordName, TextureGenParameter, float*)"/>
            public static unsafe float GetTexGenfvOES(TextureCoordName coord, TextureGenParameter pname)
            {
                float @params;
                float* @params_ptr = &@params;
                {
                    GetTexGenfvOES(coord, pname, @params_ptr);
                }
                return @params;
            }
            /// <inheritdoc cref="GetTexGenfvOES(TextureCoordName, TextureGenParameter, float*)"/>
            public static unsafe void GetTexGenfvOES(TextureCoordName coord, TextureGenParameter pname, out float @params)
            {
                fixed (float* @params_ptr = &@params)
                {
                    GetTexGenfvOES(coord, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetTexGenivOES(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe void GetTexGenivOES(TextureCoordName coord, TextureGenParameter pname, Span<int> @params)
            {
                fixed (int* @params_ptr = @params)
                {
                    GetTexGenivOES(coord, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetTexGenivOES(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe void GetTexGenivOES(TextureCoordName coord, TextureGenParameter pname, int[] @params)
            {
                fixed (int* @params_ptr = @params)
                {
                    GetTexGenivOES(coord, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetTexGenivOES(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe int GetTexGenivOES(TextureCoordName coord, TextureGenParameter pname)
            {
                int @params;
                int* @params_ptr = &@params;
                {
                    GetTexGenivOES(coord, pname, @params_ptr);
                }
                return @params;
            }
            /// <inheritdoc cref="GetTexGenivOES(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe void GetTexGenivOES(TextureCoordName coord, TextureGenParameter pname, out int @params)
            {
                fixed (int* @params_ptr = &@params)
                {
                    GetTexGenivOES(coord, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetTexGenxvOES(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe void GetTexGenxvOES(TextureCoordName coord, TextureGenParameter pname, Span<int> @params)
            {
                fixed (int* @params_ptr = @params)
                {
                    GetTexGenxvOES(coord, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetTexGenxvOES(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe void GetTexGenxvOES(TextureCoordName coord, TextureGenParameter pname, int[] @params)
            {
                fixed (int* @params_ptr = @params)
                {
                    GetTexGenxvOES(coord, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetTexGenxvOES(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe int GetTexGenxvOES(TextureCoordName coord, TextureGenParameter pname)
            {
                int @params;
                int* @params_ptr = &@params;
                {
                    GetTexGenxvOES(coord, pname, @params_ptr);
                }
                return @params;
            }
            /// <inheritdoc cref="GetTexGenxvOES(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe void GetTexGenxvOES(TextureCoordName coord, TextureGenParameter pname, out int @params)
            {
                fixed (int* @params_ptr = &@params)
                {
                    GetTexGenxvOES(coord, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetTexParameterxvOES(TextureTarget, GetTextureParameter, int*)"/>
            public static unsafe void GetTexParameterxvOES(TextureTarget target, GetTextureParameter pname, Span<int> @params)
            {
                fixed (int* @params_ptr = @params)
                {
                    GetTexParameterxvOES(target, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetTexParameterxvOES(TextureTarget, GetTextureParameter, int*)"/>
            public static unsafe void GetTexParameterxvOES(TextureTarget target, GetTextureParameter pname, int[] @params)
            {
                fixed (int* @params_ptr = @params)
                {
                    GetTexParameterxvOES(target, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="GetTexParameterxvOES(TextureTarget, GetTextureParameter, int*)"/>
            public static unsafe int GetTexParameterxvOES(TextureTarget target, GetTextureParameter pname)
            {
                int @params;
                int* @params_ptr = &@params;
                {
                    GetTexParameterxvOES(target, pname, @params_ptr);
                }
                return @params;
            }
            /// <inheritdoc cref="GetTexParameterxvOES(TextureTarget, GetTextureParameter, int*)"/>
            public static unsafe void GetTexParameterxvOES(TextureTarget target, GetTextureParameter pname, out int @params)
            {
                fixed (int* @params_ptr = &@params)
                {
                    GetTexParameterxvOES(target, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="LightModelxvOES(LightModelParameter, int*)"/>
            public static unsafe void LightModelxvOES(LightModelParameter pname, ReadOnlySpan<int> param)
            {
                fixed (int* param_ptr = param)
                {
                    LightModelxvOES(pname, param_ptr);
                }
            }
            /// <inheritdoc cref="LightModelxvOES(LightModelParameter, int*)"/>
            public static unsafe void LightModelxvOES(LightModelParameter pname, int[] param)
            {
                fixed (int* param_ptr = param)
                {
                    LightModelxvOES(pname, param_ptr);
                }
            }
            /// <inheritdoc cref="LightModelxvOES(LightModelParameter, int*)"/>
            public static unsafe void LightModelxvOES(LightModelParameter pname, ref readonly int param)
            {
                fixed (int* param_ptr = &param)
                {
                    LightModelxvOES(pname, param_ptr);
                }
            }
            /// <inheritdoc cref="LightxvOES(LightName, LightParameter, int*)"/>
            public static unsafe void LightxvOES(LightName light, LightParameter pname, ReadOnlySpan<int> @params)
            {
                fixed (int* @params_ptr = @params)
                {
                    LightxvOES(light, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="LightxvOES(LightName, LightParameter, int*)"/>
            public static unsafe void LightxvOES(LightName light, LightParameter pname, int[] @params)
            {
                fixed (int* @params_ptr = @params)
                {
                    LightxvOES(light, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="LightxvOES(LightName, LightParameter, int*)"/>
            public static unsafe void LightxvOES(LightName light, LightParameter pname, ref readonly int @params)
            {
                fixed (int* @params_ptr = &@params)
                {
                    LightxvOES(light, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="LoadMatrixxOES(int*)"/>
            public static unsafe void LoadMatrixxOES(ReadOnlySpan<int> m)
            {
                fixed (int* m_ptr = m)
                {
                    LoadMatrixxOES(m_ptr);
                }
            }
            /// <inheritdoc cref="LoadMatrixxOES(int*)"/>
            public static unsafe void LoadMatrixxOES(int[] m)
            {
                fixed (int* m_ptr = m)
                {
                    LoadMatrixxOES(m_ptr);
                }
            }
            /// <inheritdoc cref="LoadMatrixxOES(int*)"/>
            public static unsafe void LoadMatrixxOES(ref readonly int m)
            {
                fixed (int* m_ptr = &m)
                {
                    LoadMatrixxOES(m_ptr);
                }
            }
            /// <inheritdoc cref="MaterialxvOES(TriangleFace, MaterialParameter, int*)"/>
            public static unsafe void MaterialxvOES(TriangleFace face, MaterialParameter pname, ReadOnlySpan<int> param)
            {
                fixed (int* param_ptr = param)
                {
                    MaterialxvOES(face, pname, param_ptr);
                }
            }
            /// <inheritdoc cref="MaterialxvOES(TriangleFace, MaterialParameter, int*)"/>
            public static unsafe void MaterialxvOES(TriangleFace face, MaterialParameter pname, int[] param)
            {
                fixed (int* param_ptr = param)
                {
                    MaterialxvOES(face, pname, param_ptr);
                }
            }
            /// <inheritdoc cref="MaterialxvOES(TriangleFace, MaterialParameter, int*)"/>
            public static unsafe void MaterialxvOES(TriangleFace face, MaterialParameter pname, ref readonly int param)
            {
                fixed (int* param_ptr = &param)
                {
                    MaterialxvOES(face, pname, param_ptr);
                }
            }
            /// <inheritdoc cref="MatrixIndexPointerOES(int, MatrixIndexPointerTypeARB, int, void*)"/>
            public static unsafe void MatrixIndexPointerOES(int size, MatrixIndexPointerTypeARB type, int stride, IntPtr pointer)
            {
                void* pointer_vptr = (void*)pointer;
                MatrixIndexPointerOES(size, type, stride, pointer_vptr);
            }
            /// <inheritdoc cref="MatrixIndexPointerOES(int, MatrixIndexPointerTypeARB, int, void*)"/>
            public static unsafe void MatrixIndexPointerOES<T1>(int size, MatrixIndexPointerTypeARB type, int stride, ReadOnlySpan<T1> pointer)
                where T1 : unmanaged
            {
                fixed (void* pointer_ptr = pointer)
                {
                    MatrixIndexPointerOES(size, type, stride, pointer_ptr);
                }
            }
            /// <inheritdoc cref="MatrixIndexPointerOES(int, MatrixIndexPointerTypeARB, int, void*)"/>
            public static unsafe void MatrixIndexPointerOES<T1>(int size, MatrixIndexPointerTypeARB type, int stride, T1[] pointer)
                where T1 : unmanaged
            {
                fixed (void* pointer_ptr = pointer)
                {
                    MatrixIndexPointerOES(size, type, stride, pointer_ptr);
                }
            }
            /// <inheritdoc cref="MatrixIndexPointerOES(int, MatrixIndexPointerTypeARB, int, void*)"/>
            public static unsafe void MatrixIndexPointerOES<T1>(int size, MatrixIndexPointerTypeARB type, int stride, ref readonly T1 pointer)
                where T1 : unmanaged
            {
                fixed (void* pointer_ptr = &pointer)
                {
                    MatrixIndexPointerOES(size, type, stride, pointer_ptr);
                }
            }
            /// <inheritdoc cref="MultMatrixxOES(int*)"/>
            public static unsafe void MultMatrixxOES(ReadOnlySpan<int> m)
            {
                fixed (int* m_ptr = m)
                {
                    MultMatrixxOES(m_ptr);
                }
            }
            /// <inheritdoc cref="MultMatrixxOES(int*)"/>
            public static unsafe void MultMatrixxOES(int[] m)
            {
                fixed (int* m_ptr = m)
                {
                    MultMatrixxOES(m_ptr);
                }
            }
            /// <inheritdoc cref="MultMatrixxOES(int*)"/>
            public static unsafe void MultMatrixxOES(ref readonly int m)
            {
                fixed (int* m_ptr = &m)
                {
                    MultMatrixxOES(m_ptr);
                }
            }
            /// <inheritdoc cref="PointParameterxvOES(PointParameterNameARB, int*)"/>
            public static unsafe void PointParameterxvOES(PointParameterNameARB pname, ReadOnlySpan<int> @params)
            {
                fixed (int* @params_ptr = @params)
                {
                    PointParameterxvOES(pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="PointParameterxvOES(PointParameterNameARB, int*)"/>
            public static unsafe void PointParameterxvOES(PointParameterNameARB pname, int[] @params)
            {
                fixed (int* @params_ptr = @params)
                {
                    PointParameterxvOES(pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="PointParameterxvOES(PointParameterNameARB, int*)"/>
            public static unsafe void PointParameterxvOES(PointParameterNameARB pname, ref readonly int @params)
            {
                fixed (int* @params_ptr = &@params)
                {
                    PointParameterxvOES(pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="PointSizePointerOES(All, int, void*)"/>
            public static unsafe void PointSizePointerOES(All type, int stride, IntPtr pointer)
            {
                void* pointer_vptr = (void*)pointer;
                PointSizePointerOES(type, stride, pointer_vptr);
            }
            /// <inheritdoc cref="PointSizePointerOES(All, int, void*)"/>
            public static unsafe void PointSizePointerOES<T1>(All type, int stride, ReadOnlySpan<T1> pointer)
                where T1 : unmanaged
            {
                fixed (void* pointer_ptr = pointer)
                {
                    PointSizePointerOES(type, stride, pointer_ptr);
                }
            }
            /// <inheritdoc cref="PointSizePointerOES(All, int, void*)"/>
            public static unsafe void PointSizePointerOES<T1>(All type, int stride, T1[] pointer)
                where T1 : unmanaged
            {
                fixed (void* pointer_ptr = pointer)
                {
                    PointSizePointerOES(type, stride, pointer_ptr);
                }
            }
            /// <inheritdoc cref="PointSizePointerOES(All, int, void*)"/>
            public static unsafe void PointSizePointerOES<T1>(All type, int stride, ref readonly T1 pointer)
                where T1 : unmanaged
            {
                fixed (void* pointer_ptr = &pointer)
                {
                    PointSizePointerOES(type, stride, pointer_ptr);
                }
            }
            /// <inheritdoc cref="QueryMatrixxOES(int*, int*)"/>
            public static unsafe uint QueryMatrixxOES(Span<int> mantissa, Span<int> exponent)
            {
                uint returnValue;
                fixed (int* exponent_ptr = exponent)
                {
                    fixed (int* mantissa_ptr = mantissa)
                    {
                        returnValue = QueryMatrixxOES(mantissa_ptr, exponent_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryMatrixxOES(int*, int*)"/>
            public static unsafe uint QueryMatrixxOES(int[] mantissa, int[] exponent)
            {
                uint returnValue;
                fixed (int* exponent_ptr = exponent)
                {
                    fixed (int* mantissa_ptr = mantissa)
                    {
                        returnValue = QueryMatrixxOES(mantissa_ptr, exponent_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryMatrixxOES(int*, int*)"/>
            public static unsafe uint QueryMatrixxOES(ref int mantissa, ref int exponent)
            {
                uint returnValue;
                fixed (int* mantissa_ptr = &mantissa)
                fixed (int* exponent_ptr = &exponent)
                {
                    returnValue = QueryMatrixxOES(mantissa_ptr, exponent_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="TexEnvxvOES(TextureEnvTarget, TextureEnvParameter, int*)"/>
            public static unsafe void TexEnvxvOES(TextureEnvTarget target, TextureEnvParameter pname, ReadOnlySpan<int> @params)
            {
                fixed (int* @params_ptr = @params)
                {
                    TexEnvxvOES(target, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="TexEnvxvOES(TextureEnvTarget, TextureEnvParameter, int*)"/>
            public static unsafe void TexEnvxvOES(TextureEnvTarget target, TextureEnvParameter pname, int[] @params)
            {
                fixed (int* @params_ptr = @params)
                {
                    TexEnvxvOES(target, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="TexEnvxvOES(TextureEnvTarget, TextureEnvParameter, int*)"/>
            public static unsafe void TexEnvxvOES(TextureEnvTarget target, TextureEnvParameter pname, ref readonly int @params)
            {
                fixed (int* @params_ptr = &@params)
                {
                    TexEnvxvOES(target, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="TexGenfvOES(TextureCoordName, TextureGenParameter, float*)"/>
            public static unsafe void TexGenfvOES(TextureCoordName coord, TextureGenParameter pname, ReadOnlySpan<float> @params)
            {
                fixed (float* @params_ptr = @params)
                {
                    TexGenfvOES(coord, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="TexGenfvOES(TextureCoordName, TextureGenParameter, float*)"/>
            public static unsafe void TexGenfvOES(TextureCoordName coord, TextureGenParameter pname, float[] @params)
            {
                fixed (float* @params_ptr = @params)
                {
                    TexGenfvOES(coord, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="TexGenfvOES(TextureCoordName, TextureGenParameter, float*)"/>
            public static unsafe void TexGenfvOES(TextureCoordName coord, TextureGenParameter pname, ref readonly float @params)
            {
                fixed (float* @params_ptr = &@params)
                {
                    TexGenfvOES(coord, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="TexGenivOES(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe void TexGenivOES(TextureCoordName coord, TextureGenParameter pname, ReadOnlySpan<int> @params)
            {
                fixed (int* @params_ptr = @params)
                {
                    TexGenivOES(coord, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="TexGenivOES(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe void TexGenivOES(TextureCoordName coord, TextureGenParameter pname, int[] @params)
            {
                fixed (int* @params_ptr = @params)
                {
                    TexGenivOES(coord, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="TexGenivOES(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe void TexGenivOES(TextureCoordName coord, TextureGenParameter pname, ref readonly int @params)
            {
                fixed (int* @params_ptr = &@params)
                {
                    TexGenivOES(coord, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="TexGenxvOES(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe void TexGenxvOES(TextureCoordName coord, TextureGenParameter pname, ReadOnlySpan<int> @params)
            {
                fixed (int* @params_ptr = @params)
                {
                    TexGenxvOES(coord, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="TexGenxvOES(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe void TexGenxvOES(TextureCoordName coord, TextureGenParameter pname, int[] @params)
            {
                fixed (int* @params_ptr = @params)
                {
                    TexGenxvOES(coord, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="TexGenxvOES(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe void TexGenxvOES(TextureCoordName coord, TextureGenParameter pname, ref readonly int @params)
            {
                fixed (int* @params_ptr = &@params)
                {
                    TexGenxvOES(coord, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="TexParameterxvOES(TextureTarget, GetTextureParameter, int*)"/>
            public static unsafe void TexParameterxvOES(TextureTarget target, GetTextureParameter pname, ReadOnlySpan<int> @params)
            {
                fixed (int* @params_ptr = @params)
                {
                    TexParameterxvOES(target, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="TexParameterxvOES(TextureTarget, GetTextureParameter, int*)"/>
            public static unsafe void TexParameterxvOES(TextureTarget target, GetTextureParameter pname, int[] @params)
            {
                fixed (int* @params_ptr = @params)
                {
                    TexParameterxvOES(target, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="TexParameterxvOES(TextureTarget, GetTextureParameter, int*)"/>
            public static unsafe void TexParameterxvOES(TextureTarget target, GetTextureParameter pname, ref readonly int @params)
            {
                fixed (int* @params_ptr = &@params)
                {
                    TexParameterxvOES(target, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="WeightPointerOES(int, All, int, void*)"/>
            public static unsafe void WeightPointerOES(int size, All type, int stride, IntPtr pointer)
            {
                void* pointer_vptr = (void*)pointer;
                WeightPointerOES(size, type, stride, pointer_vptr);
            }
            /// <inheritdoc cref="WeightPointerOES(int, All, int, void*)"/>
            public static unsafe void WeightPointerOES<T1>(int size, All type, int stride, ReadOnlySpan<T1> pointer)
                where T1 : unmanaged
            {
                fixed (void* pointer_ptr = pointer)
                {
                    WeightPointerOES(size, type, stride, pointer_ptr);
                }
            }
            /// <inheritdoc cref="WeightPointerOES(int, All, int, void*)"/>
            public static unsafe void WeightPointerOES<T1>(int size, All type, int stride, T1[] pointer)
                where T1 : unmanaged
            {
                fixed (void* pointer_ptr = pointer)
                {
                    WeightPointerOES(size, type, stride, pointer_ptr);
                }
            }
            /// <inheritdoc cref="WeightPointerOES(int, All, int, void*)"/>
            public static unsafe void WeightPointerOES<T1>(int size, All type, int stride, ref readonly T1 pointer)
                where T1 : unmanaged
            {
                fixed (void* pointer_ptr = &pointer)
                {
                    WeightPointerOES(size, type, stride, pointer_ptr);
                }
            }
        }
        public static unsafe partial class QCOM
        {
            /// <inheritdoc cref="ExtGetBuffersQCOM(int*, int, int*)"/>
            public static unsafe int ExtGetBuffersQCOM(Span<int> buffers, int maxBuffers)
            {
                int numBuffers;
                int* numBuffers_ptr = &numBuffers;
                {
                    fixed (int* buffers_ptr = buffers)
                    {
                        ExtGetBuffersQCOM(buffers_ptr, maxBuffers, numBuffers_ptr);
                    }
                }
                return numBuffers;
            }
            /// <inheritdoc cref="ExtGetBuffersQCOM(int*, int, int*)"/>
            public static unsafe void ExtGetBuffersQCOM(Span<int> buffers, int maxBuffers, out int numBuffers)
            {
                fixed (int* numBuffers_ptr = &numBuffers)
                {
                    fixed (int* buffers_ptr = buffers)
                    {
                        ExtGetBuffersQCOM(buffers_ptr, maxBuffers, numBuffers_ptr);
                    }
                }
            }
            /// <inheritdoc cref="ExtGetBuffersQCOM(int*, int, int*)"/>
            public static unsafe int ExtGetBuffersQCOM(int[] buffers, int maxBuffers)
            {
                int numBuffers;
                int* numBuffers_ptr = &numBuffers;
                {
                    fixed (int* buffers_ptr = buffers)
                    {
                        ExtGetBuffersQCOM(buffers_ptr, maxBuffers, numBuffers_ptr);
                    }
                }
                return numBuffers;
            }
            /// <inheritdoc cref="ExtGetBuffersQCOM(int*, int, int*)"/>
            public static unsafe void ExtGetBuffersQCOM(int[] buffers, int maxBuffers, out int numBuffers)
            {
                fixed (int* numBuffers_ptr = &numBuffers)
                {
                    fixed (int* buffers_ptr = buffers)
                    {
                        ExtGetBuffersQCOM(buffers_ptr, maxBuffers, numBuffers_ptr);
                    }
                }
            }
            /// <inheritdoc cref="ExtGetBuffersQCOM(int*, int, int*)"/>
            public static unsafe int ExtGetBuffersQCOM(ref int buffers, int maxBuffers)
            {
                int numBuffers;
                int* numBuffers_ptr = &numBuffers;
                fixed (int* buffers_ptr = &buffers)
                {
                    ExtGetBuffersQCOM(buffers_ptr, maxBuffers, numBuffers_ptr);
                }
                return numBuffers;
            }
            /// <inheritdoc cref="ExtGetBuffersQCOM(int*, int, int*)"/>
            public static unsafe void ExtGetBuffersQCOM(ref int buffers, int maxBuffers, out int numBuffers)
            {
                fixed (int* buffers_ptr = &buffers)
                fixed (int* numBuffers_ptr = &numBuffers)
                {
                    ExtGetBuffersQCOM(buffers_ptr, maxBuffers, numBuffers_ptr);
                }
            }
            /// <inheritdoc cref="ExtGetFramebuffersQCOM(int*, int, int*)"/>
            public static unsafe int ExtGetFramebuffersQCOM(Span<int> framebuffers, int maxFramebuffers)
            {
                int numFramebuffers;
                int* numFramebuffers_ptr = &numFramebuffers;
                {
                    fixed (int* framebuffers_ptr = framebuffers)
                    {
                        ExtGetFramebuffersQCOM(framebuffers_ptr, maxFramebuffers, numFramebuffers_ptr);
                    }
                }
                return numFramebuffers;
            }
            /// <inheritdoc cref="ExtGetFramebuffersQCOM(int*, int, int*)"/>
            public static unsafe void ExtGetFramebuffersQCOM(Span<int> framebuffers, int maxFramebuffers, out int numFramebuffers)
            {
                fixed (int* numFramebuffers_ptr = &numFramebuffers)
                {
                    fixed (int* framebuffers_ptr = framebuffers)
                    {
                        ExtGetFramebuffersQCOM(framebuffers_ptr, maxFramebuffers, numFramebuffers_ptr);
                    }
                }
            }
            /// <inheritdoc cref="ExtGetFramebuffersQCOM(int*, int, int*)"/>
            public static unsafe int ExtGetFramebuffersQCOM(int[] framebuffers, int maxFramebuffers)
            {
                int numFramebuffers;
                int* numFramebuffers_ptr = &numFramebuffers;
                {
                    fixed (int* framebuffers_ptr = framebuffers)
                    {
                        ExtGetFramebuffersQCOM(framebuffers_ptr, maxFramebuffers, numFramebuffers_ptr);
                    }
                }
                return numFramebuffers;
            }
            /// <inheritdoc cref="ExtGetFramebuffersQCOM(int*, int, int*)"/>
            public static unsafe void ExtGetFramebuffersQCOM(int[] framebuffers, int maxFramebuffers, out int numFramebuffers)
            {
                fixed (int* numFramebuffers_ptr = &numFramebuffers)
                {
                    fixed (int* framebuffers_ptr = framebuffers)
                    {
                        ExtGetFramebuffersQCOM(framebuffers_ptr, maxFramebuffers, numFramebuffers_ptr);
                    }
                }
            }
            /// <inheritdoc cref="ExtGetFramebuffersQCOM(int*, int, int*)"/>
            public static unsafe int ExtGetFramebuffersQCOM(ref int framebuffers, int maxFramebuffers)
            {
                int numFramebuffers;
                int* numFramebuffers_ptr = &numFramebuffers;
                fixed (int* framebuffers_ptr = &framebuffers)
                {
                    ExtGetFramebuffersQCOM(framebuffers_ptr, maxFramebuffers, numFramebuffers_ptr);
                }
                return numFramebuffers;
            }
            /// <inheritdoc cref="ExtGetFramebuffersQCOM(int*, int, int*)"/>
            public static unsafe void ExtGetFramebuffersQCOM(ref int framebuffers, int maxFramebuffers, out int numFramebuffers)
            {
                fixed (int* framebuffers_ptr = &framebuffers)
                fixed (int* numFramebuffers_ptr = &numFramebuffers)
                {
                    ExtGetFramebuffersQCOM(framebuffers_ptr, maxFramebuffers, numFramebuffers_ptr);
                }
            }
            /// <inheritdoc cref="ExtGetProgramBinarySourceQCOM(int, ShaderType, byte*, int*)"/>
            public static unsafe void ExtGetProgramBinarySourceQCOM(int program, ShaderType shadertype, out string source, Span<int> length)
            {
                fixed (int* length_ptr = length)
                {
                    var source_ptr = (byte*)Marshal.AllocCoTaskMem(*length_ptr);
                    ExtGetProgramBinarySourceQCOM(program, shadertype, source_ptr, length_ptr);
                    source = Marshal.PtrToStringUTF8((IntPtr)source_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)source_ptr);
                }
            }
            /// <inheritdoc cref="ExtGetProgramBinarySourceQCOM(int, ShaderType, byte*, int*)"/>
            public static unsafe void ExtGetProgramBinarySourceQCOM(int program, ShaderType shadertype, out string source, int[] length)
            {
                fixed (int* length_ptr = length)
                {
                    var source_ptr = (byte*)Marshal.AllocCoTaskMem(*length_ptr);
                    ExtGetProgramBinarySourceQCOM(program, shadertype, source_ptr, length_ptr);
                    source = Marshal.PtrToStringUTF8((IntPtr)source_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)source_ptr);
                }
            }
            /// <inheritdoc cref="ExtGetProgramBinarySourceQCOM(int, ShaderType, byte*, int*)"/>
            public static unsafe void ExtGetProgramBinarySourceQCOM(int program, ShaderType shadertype, out string source, ref int length)
            {
                fixed (int* length_ptr = &length)
                {
                    var source_ptr = (byte*)Marshal.AllocCoTaskMem(*length_ptr);
                    ExtGetProgramBinarySourceQCOM(program, shadertype, source_ptr, length_ptr);
                    source = Marshal.PtrToStringUTF8((IntPtr)source_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)source_ptr);
                }
            }
            /// <inheritdoc cref="ExtGetProgramsQCOM(int*, int, int*)"/>
            public static unsafe int ExtGetProgramsQCOM(Span<int> programs, int maxPrograms)
            {
                int numPrograms;
                int* numPrograms_ptr = &numPrograms;
                {
                    fixed (int* programs_ptr = programs)
                    {
                        ExtGetProgramsQCOM(programs_ptr, maxPrograms, numPrograms_ptr);
                    }
                }
                return numPrograms;
            }
            /// <inheritdoc cref="ExtGetProgramsQCOM(int*, int, int*)"/>
            public static unsafe void ExtGetProgramsQCOM(Span<int> programs, int maxPrograms, out int numPrograms)
            {
                fixed (int* numPrograms_ptr = &numPrograms)
                {
                    fixed (int* programs_ptr = programs)
                    {
                        ExtGetProgramsQCOM(programs_ptr, maxPrograms, numPrograms_ptr);
                    }
                }
            }
            /// <inheritdoc cref="ExtGetProgramsQCOM(int*, int, int*)"/>
            public static unsafe int ExtGetProgramsQCOM(int[] programs, int maxPrograms)
            {
                int numPrograms;
                int* numPrograms_ptr = &numPrograms;
                {
                    fixed (int* programs_ptr = programs)
                    {
                        ExtGetProgramsQCOM(programs_ptr, maxPrograms, numPrograms_ptr);
                    }
                }
                return numPrograms;
            }
            /// <inheritdoc cref="ExtGetProgramsQCOM(int*, int, int*)"/>
            public static unsafe void ExtGetProgramsQCOM(int[] programs, int maxPrograms, out int numPrograms)
            {
                fixed (int* numPrograms_ptr = &numPrograms)
                {
                    fixed (int* programs_ptr = programs)
                    {
                        ExtGetProgramsQCOM(programs_ptr, maxPrograms, numPrograms_ptr);
                    }
                }
            }
            /// <inheritdoc cref="ExtGetProgramsQCOM(int*, int, int*)"/>
            public static unsafe int ExtGetProgramsQCOM(ref int programs, int maxPrograms)
            {
                int numPrograms;
                int* numPrograms_ptr = &numPrograms;
                fixed (int* programs_ptr = &programs)
                {
                    ExtGetProgramsQCOM(programs_ptr, maxPrograms, numPrograms_ptr);
                }
                return numPrograms;
            }
            /// <inheritdoc cref="ExtGetProgramsQCOM(int*, int, int*)"/>
            public static unsafe void ExtGetProgramsQCOM(ref int programs, int maxPrograms, out int numPrograms)
            {
                fixed (int* programs_ptr = &programs)
                fixed (int* numPrograms_ptr = &numPrograms)
                {
                    ExtGetProgramsQCOM(programs_ptr, maxPrograms, numPrograms_ptr);
                }
            }
            /// <inheritdoc cref="ExtGetRenderbuffersQCOM(int*, int, int*)"/>
            public static unsafe int ExtGetRenderbuffersQCOM(Span<int> renderbuffers, int maxRenderbuffers)
            {
                int numRenderbuffers;
                int* numRenderbuffers_ptr = &numRenderbuffers;
                {
                    fixed (int* renderbuffers_ptr = renderbuffers)
                    {
                        ExtGetRenderbuffersQCOM(renderbuffers_ptr, maxRenderbuffers, numRenderbuffers_ptr);
                    }
                }
                return numRenderbuffers;
            }
            /// <inheritdoc cref="ExtGetRenderbuffersQCOM(int*, int, int*)"/>
            public static unsafe void ExtGetRenderbuffersQCOM(Span<int> renderbuffers, int maxRenderbuffers, out int numRenderbuffers)
            {
                fixed (int* numRenderbuffers_ptr = &numRenderbuffers)
                {
                    fixed (int* renderbuffers_ptr = renderbuffers)
                    {
                        ExtGetRenderbuffersQCOM(renderbuffers_ptr, maxRenderbuffers, numRenderbuffers_ptr);
                    }
                }
            }
            /// <inheritdoc cref="ExtGetRenderbuffersQCOM(int*, int, int*)"/>
            public static unsafe int ExtGetRenderbuffersQCOM(int[] renderbuffers, int maxRenderbuffers)
            {
                int numRenderbuffers;
                int* numRenderbuffers_ptr = &numRenderbuffers;
                {
                    fixed (int* renderbuffers_ptr = renderbuffers)
                    {
                        ExtGetRenderbuffersQCOM(renderbuffers_ptr, maxRenderbuffers, numRenderbuffers_ptr);
                    }
                }
                return numRenderbuffers;
            }
            /// <inheritdoc cref="ExtGetRenderbuffersQCOM(int*, int, int*)"/>
            public static unsafe void ExtGetRenderbuffersQCOM(int[] renderbuffers, int maxRenderbuffers, out int numRenderbuffers)
            {
                fixed (int* numRenderbuffers_ptr = &numRenderbuffers)
                {
                    fixed (int* renderbuffers_ptr = renderbuffers)
                    {
                        ExtGetRenderbuffersQCOM(renderbuffers_ptr, maxRenderbuffers, numRenderbuffers_ptr);
                    }
                }
            }
            /// <inheritdoc cref="ExtGetRenderbuffersQCOM(int*, int, int*)"/>
            public static unsafe int ExtGetRenderbuffersQCOM(ref int renderbuffers, int maxRenderbuffers)
            {
                int numRenderbuffers;
                int* numRenderbuffers_ptr = &numRenderbuffers;
                fixed (int* renderbuffers_ptr = &renderbuffers)
                {
                    ExtGetRenderbuffersQCOM(renderbuffers_ptr, maxRenderbuffers, numRenderbuffers_ptr);
                }
                return numRenderbuffers;
            }
            /// <inheritdoc cref="ExtGetRenderbuffersQCOM(int*, int, int*)"/>
            public static unsafe void ExtGetRenderbuffersQCOM(ref int renderbuffers, int maxRenderbuffers, out int numRenderbuffers)
            {
                fixed (int* renderbuffers_ptr = &renderbuffers)
                fixed (int* numRenderbuffers_ptr = &numRenderbuffers)
                {
                    ExtGetRenderbuffersQCOM(renderbuffers_ptr, maxRenderbuffers, numRenderbuffers_ptr);
                }
            }
            /// <inheritdoc cref="ExtGetShadersQCOM(int*, int, int*)"/>
            public static unsafe int ExtGetShadersQCOM(Span<int> shaders, int maxShaders)
            {
                int numShaders;
                int* numShaders_ptr = &numShaders;
                {
                    fixed (int* shaders_ptr = shaders)
                    {
                        ExtGetShadersQCOM(shaders_ptr, maxShaders, numShaders_ptr);
                    }
                }
                return numShaders;
            }
            /// <inheritdoc cref="ExtGetShadersQCOM(int*, int, int*)"/>
            public static unsafe void ExtGetShadersQCOM(Span<int> shaders, int maxShaders, out int numShaders)
            {
                fixed (int* numShaders_ptr = &numShaders)
                {
                    fixed (int* shaders_ptr = shaders)
                    {
                        ExtGetShadersQCOM(shaders_ptr, maxShaders, numShaders_ptr);
                    }
                }
            }
            /// <inheritdoc cref="ExtGetShadersQCOM(int*, int, int*)"/>
            public static unsafe int ExtGetShadersQCOM(int[] shaders, int maxShaders)
            {
                int numShaders;
                int* numShaders_ptr = &numShaders;
                {
                    fixed (int* shaders_ptr = shaders)
                    {
                        ExtGetShadersQCOM(shaders_ptr, maxShaders, numShaders_ptr);
                    }
                }
                return numShaders;
            }
            /// <inheritdoc cref="ExtGetShadersQCOM(int*, int, int*)"/>
            public static unsafe void ExtGetShadersQCOM(int[] shaders, int maxShaders, out int numShaders)
            {
                fixed (int* numShaders_ptr = &numShaders)
                {
                    fixed (int* shaders_ptr = shaders)
                    {
                        ExtGetShadersQCOM(shaders_ptr, maxShaders, numShaders_ptr);
                    }
                }
            }
            /// <inheritdoc cref="ExtGetShadersQCOM(int*, int, int*)"/>
            public static unsafe int ExtGetShadersQCOM(ref int shaders, int maxShaders)
            {
                int numShaders;
                int* numShaders_ptr = &numShaders;
                fixed (int* shaders_ptr = &shaders)
                {
                    ExtGetShadersQCOM(shaders_ptr, maxShaders, numShaders_ptr);
                }
                return numShaders;
            }
            /// <inheritdoc cref="ExtGetShadersQCOM(int*, int, int*)"/>
            public static unsafe void ExtGetShadersQCOM(ref int shaders, int maxShaders, out int numShaders)
            {
                fixed (int* shaders_ptr = &shaders)
                fixed (int* numShaders_ptr = &numShaders)
                {
                    ExtGetShadersQCOM(shaders_ptr, maxShaders, numShaders_ptr);
                }
            }
            /// <inheritdoc cref="ExtGetTexLevelParameterivQCOM(int, All, int, All, int*)"/>
            public static unsafe void ExtGetTexLevelParameterivQCOM(int texture, All face, int level, All pname, Span<int> @params)
            {
                fixed (int* @params_ptr = @params)
                {
                    ExtGetTexLevelParameterivQCOM(texture, face, level, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="ExtGetTexLevelParameterivQCOM(int, All, int, All, int*)"/>
            public static unsafe void ExtGetTexLevelParameterivQCOM(int texture, All face, int level, All pname, int[] @params)
            {
                fixed (int* @params_ptr = @params)
                {
                    ExtGetTexLevelParameterivQCOM(texture, face, level, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="ExtGetTexLevelParameterivQCOM(int, All, int, All, int*)"/>
            public static unsafe void ExtGetTexLevelParameterivQCOM(int texture, All face, int level, All pname, ref int @params)
            {
                fixed (int* @params_ptr = &@params)
                {
                    ExtGetTexLevelParameterivQCOM(texture, face, level, pname, @params_ptr);
                }
            }
            /// <inheritdoc cref="ExtGetTexSubImageQCOM(All, int, int, int, int, int, int, int, PixelFormat, PixelType, void*)"/>
            public static unsafe void ExtGetTexSubImageQCOM(All target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr texels)
            {
                void* texels_vptr = (void*)texels;
                ExtGetTexSubImageQCOM(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, texels_vptr);
            }
            /// <inheritdoc cref="ExtGetTexSubImageQCOM(All, int, int, int, int, int, int, int, PixelFormat, PixelType, void*)"/>
            public static unsafe void ExtGetTexSubImageQCOM<T1>(All target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, Span<T1> texels)
                where T1 : unmanaged
            {
                fixed (void* texels_ptr = texels)
                {
                    ExtGetTexSubImageQCOM(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, texels_ptr);
                }
            }
            /// <inheritdoc cref="ExtGetTexSubImageQCOM(All, int, int, int, int, int, int, int, PixelFormat, PixelType, void*)"/>
            public static unsafe void ExtGetTexSubImageQCOM<T1>(All target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, T1[] texels)
                where T1 : unmanaged
            {
                fixed (void* texels_ptr = texels)
                {
                    ExtGetTexSubImageQCOM(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, texels_ptr);
                }
            }
            /// <inheritdoc cref="ExtGetTexSubImageQCOM(All, int, int, int, int, int, int, int, PixelFormat, PixelType, void*)"/>
            public static unsafe void ExtGetTexSubImageQCOM<T1>(All target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, ref T1 texels)
                where T1 : unmanaged
            {
                fixed (void* texels_ptr = &texels)
                {
                    ExtGetTexSubImageQCOM(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, texels_ptr);
                }
            }
            /// <inheritdoc cref="ExtGetTexturesQCOM(int*, int, int*)"/>
            public static unsafe void ExtGetTexturesQCOM(Span<int> textures, int maxTextures, Span<int> numTextures)
            {
                fixed (int* numTextures_ptr = numTextures)
                {
                    fixed (int* textures_ptr = textures)
                    {
                        ExtGetTexturesQCOM(textures_ptr, maxTextures, numTextures_ptr);
                    }
                }
            }
            /// <inheritdoc cref="ExtGetTexturesQCOM(int*, int, int*)"/>
            public static unsafe void ExtGetTexturesQCOM(int[] textures, int maxTextures, int[] numTextures)
            {
                fixed (int* numTextures_ptr = numTextures)
                {
                    fixed (int* textures_ptr = textures)
                    {
                        ExtGetTexturesQCOM(textures_ptr, maxTextures, numTextures_ptr);
                    }
                }
            }
            /// <inheritdoc cref="ExtGetTexturesQCOM(int*, int, int*)"/>
            public static unsafe void ExtGetTexturesQCOM(ref int textures, int maxTextures, ref int numTextures)
            {
                fixed (int* textures_ptr = &textures)
                fixed (int* numTextures_ptr = &numTextures)
                {
                    ExtGetTexturesQCOM(textures_ptr, maxTextures, numTextures_ptr);
                }
            }
            /// <inheritdoc cref="GetDriverControlsQCOM(int*, int, uint*)"/>
            public static unsafe void GetDriverControlsQCOM(Span<int> num, int size, Span<uint> driverControls)
            {
                fixed (uint* driverControls_ptr = driverControls)
                {
                    fixed (int* num_ptr = num)
                    {
                        GetDriverControlsQCOM(num_ptr, size, driverControls_ptr);
                    }
                }
            }
            /// <inheritdoc cref="GetDriverControlsQCOM(int*, int, uint*)"/>
            public static unsafe void GetDriverControlsQCOM(int[] num, int size, uint[] driverControls)
            {
                fixed (uint* driverControls_ptr = driverControls)
                {
                    fixed (int* num_ptr = num)
                    {
                        GetDriverControlsQCOM(num_ptr, size, driverControls_ptr);
                    }
                }
            }
            /// <inheritdoc cref="GetDriverControlsQCOM(int*, int, uint*)"/>
            public static unsafe void GetDriverControlsQCOM(ref int num, int size, ref uint driverControls)
            {
                fixed (int* num_ptr = &num)
                fixed (uint* driverControls_ptr = &driverControls)
                {
                    GetDriverControlsQCOM(num_ptr, size, driverControls_ptr);
                }
            }
            /// <inheritdoc cref="GetDriverControlStringQCOM(uint, int, int*, byte*)"/>
            public static unsafe string GetDriverControlStringQCOM(uint driverControl, int bufSize, Span<int> length)
            {
                string driverControlString;
                fixed (int* length_ptr = length)
                {
                    var driverControlString_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetDriverControlStringQCOM(driverControl, bufSize, length_ptr, driverControlString_ptr);
                    driverControlString = Marshal.PtrToStringUTF8((IntPtr)driverControlString_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)driverControlString_ptr);
                }
                return driverControlString;
            }
            /// <inheritdoc cref="GetDriverControlStringQCOM(uint, int, int*, byte*)"/>
            public static unsafe void GetDriverControlStringQCOM(uint driverControl, int bufSize, Span<int> length, out string driverControlString)
            {
                fixed (int* length_ptr = length)
                {
                    var driverControlString_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetDriverControlStringQCOM(driverControl, bufSize, length_ptr, driverControlString_ptr);
                    driverControlString = Marshal.PtrToStringUTF8((IntPtr)driverControlString_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)driverControlString_ptr);
                }
            }
            /// <inheritdoc cref="GetDriverControlStringQCOM(uint, int, int*, byte*)"/>
            public static unsafe string GetDriverControlStringQCOM(uint driverControl, int bufSize, int[] length)
            {
                string driverControlString;
                fixed (int* length_ptr = length)
                {
                    var driverControlString_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetDriverControlStringQCOM(driverControl, bufSize, length_ptr, driverControlString_ptr);
                    driverControlString = Marshal.PtrToStringUTF8((IntPtr)driverControlString_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)driverControlString_ptr);
                }
                return driverControlString;
            }
            /// <inheritdoc cref="GetDriverControlStringQCOM(uint, int, int*, byte*)"/>
            public static unsafe void GetDriverControlStringQCOM(uint driverControl, int bufSize, int[] length, out string driverControlString)
            {
                fixed (int* length_ptr = length)
                {
                    var driverControlString_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetDriverControlStringQCOM(driverControl, bufSize, length_ptr, driverControlString_ptr);
                    driverControlString = Marshal.PtrToStringUTF8((IntPtr)driverControlString_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)driverControlString_ptr);
                }
            }
            /// <inheritdoc cref="GetDriverControlStringQCOM(uint, int, int*, byte*)"/>
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
            /// <inheritdoc cref="GetDriverControlStringQCOM(uint, int, int*, byte*)"/>
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
        }
    }
}
