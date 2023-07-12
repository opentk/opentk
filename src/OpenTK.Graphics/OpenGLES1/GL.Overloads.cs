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
        /// <inheritdoc cref="GetBooleanv(GetPName, bool*)"/>
        public static unsafe bool GetBoolean(GetPName pname)
        {
            bool data_val;
            bool* data = &data_val;
            GetBooleanv(pname, data);
            return data_val;
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
        /// <inheritdoc cref="GetBufferParameteriv(BufferTargetARB, BufferPNameARB, int*)"/>
        public static unsafe int GetBufferParameteri(BufferTargetARB target, BufferPNameARB pname)
        {
            int parameters_val;
            int* parameters = &parameters_val;
            GetBufferParameteriv(target, pname, parameters);
            return parameters_val;
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
        /// <inheritdoc cref="GetClipPlanef(ClipPlaneName, float*)"/>
        public static unsafe float GetClipPlanef(ClipPlaneName plane)
        {
            float equation_val;
            float* equation = &equation_val;
            GetClipPlanef(plane, equation);
            return equation_val;
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
        /// <inheritdoc cref="GetClipPlanex(ClipPlaneName, int*)"/>
        public static unsafe int GetClipPlanex(ClipPlaneName plane)
        {
            int equation_val;
            int* equation = &equation_val;
            GetClipPlanex(plane, equation);
            return equation_val;
        }
        /// <inheritdoc cref="GetFixedv(GetPName, int*)"/>
        public static unsafe void GetFixed(GetPName pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetFixedv(pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetFixedv(GetPName, int*)"/>
        public static unsafe int GetFixed(GetPName pname)
        {
            int parameters_val;
            int* parameters = &parameters_val;
            GetFixedv(pname, parameters);
            return parameters_val;
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
        /// <inheritdoc cref="GetFloatv(GetPName, float*)"/>
        public static unsafe float GetFloat(GetPName pname)
        {
            float data_val;
            float* data = &data_val;
            GetFloatv(pname, data);
            return data_val;
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
        /// <inheritdoc cref="GetIntegerv(GetPName, int*)"/>
        public static unsafe int GetInteger(GetPName pname)
        {
            int data_val;
            int* data = &data_val;
            GetIntegerv(pname, data);
            return data_val;
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
        /// <inheritdoc cref="GetLightfv(LightName, LightParameter, float*)"/>
        public static unsafe float GetLightf(LightName light, LightParameter pname)
        {
            float parameters_val;
            float* parameters = &parameters_val;
            GetLightfv(light, pname, parameters);
            return parameters_val;
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
        /// <inheritdoc cref="GetLightxv(LightName, LightParameter, int*)"/>
        public static unsafe int GetLightx(LightName light, LightParameter pname)
        {
            int parameters_val;
            int* parameters = &parameters_val;
            GetLightxv(light, pname, parameters);
            return parameters_val;
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
        /// <inheritdoc cref="GetMaterialfv(TriangleFace, MaterialParameter, float*)"/>
        public static unsafe float GetMaterialf(TriangleFace face, MaterialParameter pname)
        {
            float parameters_val;
            float* parameters = &parameters_val;
            GetMaterialfv(face, pname, parameters);
            return parameters_val;
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
        /// <inheritdoc cref="GetMaterialxv(TriangleFace, MaterialParameter, int*)"/>
        public static unsafe int GetMaterialx(TriangleFace face, MaterialParameter pname)
        {
            int parameters_val;
            int* parameters = &parameters_val;
            GetMaterialxv(face, pname, parameters);
            return parameters_val;
        }
        /// <inheritdoc cref="GetPointerv(GetPointervPName, void**)"/>
        public static unsafe void GetPointer(GetPointervPName pname, void** parameters)
        {
            GetPointerv(pname, parameters);
        }
        /// <inheritdoc cref="GetPointerv(GetPointervPName, void**)"/>
        public static unsafe void* GetPointer(GetPointervPName pname)
        {
            void* parameters_val;
            void** parameters = &parameters_val;
            GetPointerv(pname, parameters);
            return parameters_val;
        }
        /// <inheritdoc cref="GetString(StringName)"/>
        public static unsafe string? GetString(StringName name)
        {
            string? returnValue_str;
            byte* returnValue;
            returnValue = GetString_(name);
            returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
            return returnValue_str;
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
        /// <inheritdoc cref="GetTexEnvfv(TextureEnvTarget, TextureEnvParameter, float*)"/>
        public static unsafe float GetTexEnvf(TextureEnvTarget target, TextureEnvParameter pname)
        {
            float parameters_val;
            float* parameters = &parameters_val;
            GetTexEnvfv(target, pname, parameters);
            return parameters_val;
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
        /// <inheritdoc cref="GetTexEnviv(TextureEnvTarget, TextureEnvParameter, int*)"/>
        public static unsafe int GetTexEnvi(TextureEnvTarget target, TextureEnvParameter pname)
        {
            int parameters_val;
            int* parameters = &parameters_val;
            GetTexEnviv(target, pname, parameters);
            return parameters_val;
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
        /// <inheritdoc cref="GetTexEnvxv(TextureEnvTarget, TextureEnvParameter, int*)"/>
        public static unsafe int GetTexEnvx(TextureEnvTarget target, TextureEnvParameter pname)
        {
            int parameters_val;
            int* parameters = &parameters_val;
            GetTexEnvxv(target, pname, parameters);
            return parameters_val;
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
        /// <inheritdoc cref="GetTexParameterfv(TextureTarget, GetTextureParameter, float*)"/>
        public static unsafe float GetTexParameterf(TextureTarget target, GetTextureParameter pname)
        {
            float parameters_val;
            float* parameters = &parameters_val;
            GetTexParameterfv(target, pname, parameters);
            return parameters_val;
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
        /// <inheritdoc cref="GetTexParameteriv(TextureTarget, GetTextureParameter, int*)"/>
        public static unsafe int GetTexParameteri(TextureTarget target, GetTextureParameter pname)
        {
            int parameters_val;
            int* parameters = &parameters_val;
            GetTexParameteriv(target, pname, parameters);
            return parameters_val;
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
        /// <inheritdoc cref="GetTexParameterxv(TextureTarget, GetTextureParameter, int*)"/>
        public static unsafe int GetTexParameterx(TextureTarget target, GetTextureParameter pname)
        {
            int parameters_val;
            int* parameters = &parameters_val;
            GetTexParameterxv(target, pname, parameters);
            return parameters_val;
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
            /// <inheritdoc cref="GetInteger64vAPPLE(GetPName, long*)"/>
            public static unsafe void GetInteger64vAPPLE(GetPName pname, ref long parameters)
            {
                fixed (long* parameters_ptr = &parameters)
                {
                    GetInteger64vAPPLE(pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetInteger64vAPPLE(GetPName, long*)"/>
            public static unsafe long GetInteger64vAPPLE(GetPName pname)
            {
                long parameters_val;
                long* parameters = &parameters_val;
                GetInteger64vAPPLE(pname, parameters);
                return parameters_val;
            }
            /// <inheritdoc cref="GetSyncivAPPLE(GLSync, SyncParameterName, int, int*, int*)"/>
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
            /// <inheritdoc cref="GetSyncivAPPLE(GLSync, SyncParameterName, int, int*, int*)"/>
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
            /// <inheritdoc cref="GetSyncivAPPLE(GLSync, SyncParameterName, int, int*, int*)"/>
            public static unsafe void GetSyncivAPPLE(GLSync sync, SyncParameterName pname, int count, ref int length, ref int values)
            {
                fixed (int* length_ptr = &length)
                fixed (int* values_ptr = &values)
                {
                    GetSyncivAPPLE(sync, pname, count, length_ptr, values_ptr);
                }
            }
            /// <inheritdoc cref="GetSyncivAPPLE(GLSync, SyncParameterName, int, int*, int*)"/>
            public static unsafe int GetSyncivAPPLE(GLSync sync, SyncParameterName pname, int count, ref int length)
            {
                int values_val;
                fixed (int* length_ptr = &length)
                {
                    int* values = &values_val;
                    GetSyncivAPPLE(sync, pname, count, length_ptr, values);
                }
                return values_val;
            }
        }
        public static unsafe partial class EXT
        {
            /// <inheritdoc cref="DiscardFramebufferEXT(FramebufferTarget, int, InvalidateFramebufferAttachment*)"/>
            public static unsafe void DiscardFramebufferEXT(FramebufferTarget target, ReadOnlySpan<InvalidateFramebufferAttachment> attachments)
            {
                int numAttachments = (int)(attachments.Length);
                fixed (InvalidateFramebufferAttachment* attachments_ptr = attachments)
                {
                    DiscardFramebufferEXT(target, numAttachments, attachments_ptr);
                }
            }
            /// <inheritdoc cref="DiscardFramebufferEXT(FramebufferTarget, int, InvalidateFramebufferAttachment*)"/>
            public static unsafe void DiscardFramebufferEXT(FramebufferTarget target, InvalidateFramebufferAttachment[] attachments)
            {
                int numAttachments = (int)(attachments.Length);
                fixed (InvalidateFramebufferAttachment* attachments_ptr = attachments)
                {
                    DiscardFramebufferEXT(target, numAttachments, attachments_ptr);
                }
            }
            /// <inheritdoc cref="DiscardFramebufferEXT(FramebufferTarget, int, InvalidateFramebufferAttachment*)"/>
            public static unsafe void DiscardFramebufferEXT(FramebufferTarget target, int numAttachments, in InvalidateFramebufferAttachment attachments)
            {
                fixed (InvalidateFramebufferAttachment* attachments_ptr = &attachments)
                {
                    DiscardFramebufferEXT(target, numAttachments, attachments_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformfvEXT(int, int, int, float*)"/>
            public static unsafe void GetnUniformfvEXT(int program, int location, Span<float> parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (float* parameters_ptr = parameters)
                {
                    GetnUniformfvEXT(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformfvEXT(int, int, int, float*)"/>
            public static unsafe void GetnUniformfvEXT(int program, int location, float[] parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (float* parameters_ptr = parameters)
                {
                    GetnUniformfvEXT(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformfvEXT(int, int, int, float*)"/>
            public static unsafe void GetnUniformfvEXT(int program, int location, int bufSize, ref float parameters)
            {
                fixed (float* parameters_ptr = &parameters)
                {
                    GetnUniformfvEXT(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformfvEXT(int, int, int, float*)"/>
            public static unsafe float GetnUniformfvEXT(int program, int location, int bufSize)
            {
                float parameters_val;
                float* parameters = &parameters_val;
                GetnUniformfvEXT(program, location, bufSize, parameters);
                return parameters_val;
            }
            /// <inheritdoc cref="GetnUniformivEXT(int, int, int, int*)"/>
            public static unsafe void GetnUniformivEXT(int program, int location, Span<int> parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (int* parameters_ptr = parameters)
                {
                    GetnUniformivEXT(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformivEXT(int, int, int, int*)"/>
            public static unsafe void GetnUniformivEXT(int program, int location, int[] parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (int* parameters_ptr = parameters)
                {
                    GetnUniformivEXT(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformivEXT(int, int, int, int*)"/>
            public static unsafe void GetnUniformivEXT(int program, int location, int bufSize, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetnUniformivEXT(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformivEXT(int, int, int, int*)"/>
            public static unsafe int GetnUniformivEXT(int program, int location, int bufSize)
            {
                int parameters_val;
                int* parameters = &parameters_val;
                GetnUniformivEXT(program, location, bufSize, parameters);
                return parameters_val;
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
                fixed (int* first_ptr = first)
                {
                    fixed (int* count_ptr = count)
                    {
                        MultiDrawArraysEXT(mode, first_ptr, count_ptr, primcount);
                    }
                }
            }
            /// <inheritdoc cref="MultiDrawArraysEXT(PrimitiveType, int*, int*, int)"/>
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
            /// <inheritdoc cref="MultiDrawArraysEXT(PrimitiveType, int*, int*, int)"/>
            public static unsafe void MultiDrawArraysEXT(PrimitiveType mode, in int first, in int count, int primcount)
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
            public static unsafe void MultiDrawElementsEXT(PrimitiveType mode, in int count, DrawElementsType type, void** indices, int primcount)
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
            public static unsafe void ReadnPixelsEXT<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, Span<T1> data)
                where T1 : unmanaged
            {
                int bufSize = (int)(data.Length * sizeof(T1));
                fixed (void* data_ptr = data)
                {
                    ReadnPixelsEXT(x, y, width, height, format, type, bufSize, data_ptr);
                }
            }
            /// <inheritdoc cref="ReadnPixelsEXT(int, int, int, int, PixelFormat, PixelType, int, void*)"/>
            public static unsafe void ReadnPixelsEXT<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, T1[] data)
                where T1 : unmanaged
            {
                int bufSize = (int)(data.Length * sizeof(T1));
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
            public static unsafe void ClipPlanefIMG(ClipPlaneName p, in float eqn)
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
            /// <inheritdoc cref="DebugMessageControlKHR(DebugSource, DebugType, DebugSeverity, int, uint*, bool)"/>
            public static unsafe void DebugMessageControlKHR(DebugSource source, DebugType type, DebugSeverity severity, int count, in uint ids, bool enabled)
            {
                fixed (uint* ids_ptr = &ids)
                {
                    DebugMessageControlKHR(source, type, severity, count, ids_ptr, enabled);
                }
            }
            /// <inheritdoc cref="DebugMessageInsert(DebugSource, DebugType, uint, DebugSeverity, int, byte*)"/>
            public static unsafe void DebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, string buf)
            {
                byte* buf_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(buf);
                DebugMessageInsert(source, type, id, severity, length, buf_ptr);
                Marshal.FreeCoTaskMem((IntPtr)buf_ptr);
            }
            /// <inheritdoc cref="DebugMessageInsertKHR(DebugSource, DebugType, uint, DebugSeverity, int, byte*)"/>
            public static unsafe void DebugMessageInsertKHR(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, string buf)
            {
                byte* buf_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(buf);
                DebugMessageInsertKHR(source, type, id, severity, length, buf_ptr);
                Marshal.FreeCoTaskMem((IntPtr)buf_ptr);
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
            /// <inheritdoc cref="GetPointerv(GetPointervPName, void**)"/>
            public static unsafe void GetPointer(GetPointervPName pname, void** parameters)
            {
                GetPointerv(pname, parameters);
            }
            /// <inheritdoc cref="GetPointerv(GetPointervPName, void**)"/>
            public static unsafe void* GetPointer(GetPointervPName pname)
            {
                void* parameters_val;
                void** parameters = &parameters_val;
                GetPointerv(pname, parameters);
                return parameters_val;
            }
            /// <inheritdoc cref="GetPointervKHR(All, void**)"/>
            public static unsafe void GetPointervKHR(All pname, void** parameters)
            {
                GetPointervKHR_(pname, parameters);
            }
            /// <inheritdoc cref="GetPointervKHR(All, void**)"/>
            public static unsafe void* GetPointervKHR(All pname)
            {
                void* parameters_val;
                void** parameters = &parameters_val;
                GetPointervKHR_(pname, parameters);
                return parameters_val;
            }
            /// <inheritdoc cref="ObjectLabel(ObjectIdentifier, uint, int, byte*)"/>
            public static unsafe void ObjectLabel(ObjectIdentifier identifier, uint name, int length, string label)
            {
                byte* label_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(label);
                ObjectLabel(identifier, name, length, label_ptr);
                Marshal.FreeCoTaskMem((IntPtr)label_ptr);
            }
            /// <inheritdoc cref="ObjectLabelKHR(ObjectIdentifier, uint, int, byte*)"/>
            public static unsafe void ObjectLabelKHR(ObjectIdentifier identifier, uint name, int length, string label)
            {
                byte* label_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(label);
                ObjectLabelKHR(identifier, name, length, label_ptr);
                Marshal.FreeCoTaskMem((IntPtr)label_ptr);
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
            /// <inheritdoc cref="PushDebugGroup(DebugSource, uint, int, byte*)"/>
            public static unsafe void PushDebugGroup(DebugSource source, uint id, int length, string message)
            {
                byte* message_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(message);
                PushDebugGroup(source, id, length, message_ptr);
                Marshal.FreeCoTaskMem((IntPtr)message_ptr);
            }
            /// <inheritdoc cref="PushDebugGroupKHR(DebugSource, uint, int, byte*)"/>
            public static unsafe void PushDebugGroupKHR(DebugSource source, uint id, int length, string message)
            {
                byte* message_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(message);
                PushDebugGroupKHR(source, id, length, message_ptr);
                Marshal.FreeCoTaskMem((IntPtr)message_ptr);
            }
        }
        public static unsafe partial class NV
        {
            /// <inheritdoc cref="DeleteFencesNV(int, uint*)"/>
            public static unsafe void DeleteFencesNV(ReadOnlySpan<uint> fences)
            {
                int n = (int)(fences.Length);
                fixed (uint* fences_ptr = fences)
                {
                    DeleteFencesNV(n, fences_ptr);
                }
            }
            /// <inheritdoc cref="DeleteFencesNV(int, uint*)"/>
            public static unsafe void DeleteFencesNV(uint[] fences)
            {
                int n = (int)(fences.Length);
                fixed (uint* fences_ptr = fences)
                {
                    DeleteFencesNV(n, fences_ptr);
                }
            }
            /// <inheritdoc cref="DeleteFencesNV(int, uint*)"/>
            public static unsafe void DeleteFencesNV(int n, in uint fences)
            {
                fixed (uint* fences_ptr = &fences)
                {
                    DeleteFencesNV(n, fences_ptr);
                }
            }
            /// <inheritdoc cref="GenFencesNV(int, uint*)"/>
            public static unsafe void GenFencesNV(Span<uint> fences)
            {
                int n = (int)(fences.Length);
                fixed (uint* fences_ptr = fences)
                {
                    GenFencesNV(n, fences_ptr);
                }
            }
            /// <inheritdoc cref="GenFencesNV(int, uint*)"/>
            public static unsafe void GenFencesNV(uint[] fences)
            {
                int n = (int)(fences.Length);
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
            public static unsafe void GetFenceivNV(uint fence, FenceParameterNameNV pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetFenceivNV(fence, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetFenceivNV(uint, FenceParameterNameNV, int*)"/>
            public static unsafe void GetFenceivNV(uint fence, FenceParameterNameNV pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetFenceivNV(fence, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetFenceivNV(uint, FenceParameterNameNV, int*)"/>
            public static unsafe void GetFenceivNV(uint fence, FenceParameterNameNV pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetFenceivNV(fence, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetFenceivNV(uint, FenceParameterNameNV, int*)"/>
            public static unsafe int GetFenceivNV(uint fence, FenceParameterNameNV pname)
            {
                int parameters_val;
                int* parameters = &parameters_val;
                GetFenceivNV(fence, pname, parameters);
                return parameters_val;
            }
        }
        public static unsafe partial class OES
        {
            /// <inheritdoc cref="BitmapxOES(int, int, int, int, int, int, byte*)"/>
            public static unsafe void BitmapxOES(int width, int height, int xorig, int yorig, int xmove, int ymove, ReadOnlySpan<byte> bitmap)
            {
                fixed (byte* bitmap_ptr = bitmap)
                {
                    BitmapxOES(width, height, xorig, yorig, xmove, ymove, bitmap_ptr);
                }
            }
            /// <inheritdoc cref="BitmapxOES(int, int, int, int, int, int, byte*)"/>
            public static unsafe void BitmapxOES(int width, int height, int xorig, int yorig, int xmove, int ymove, byte[] bitmap)
            {
                fixed (byte* bitmap_ptr = bitmap)
                {
                    BitmapxOES(width, height, xorig, yorig, xmove, ymove, bitmap_ptr);
                }
            }
            /// <inheritdoc cref="BitmapxOES(int, int, int, int, int, int, byte*)"/>
            public static unsafe void BitmapxOES(int width, int height, int xorig, int yorig, int xmove, int ymove, in byte bitmap)
            {
                fixed (byte* bitmap_ptr = &bitmap)
                {
                    BitmapxOES(width, height, xorig, yorig, xmove, ymove, bitmap_ptr);
                }
            }
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
            public static unsafe void ClipPlanefOES(ClipPlaneName plane, in float equation)
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
            public static unsafe void ClipPlanexOES(ClipPlaneName plane, in int equation)
            {
                fixed (int* equation_ptr = &equation)
                {
                    ClipPlanexOES(plane, equation_ptr);
                }
            }
            /// <inheritdoc cref="Color3xvOES(int*)"/>
            public static unsafe void Color3xvOES(ReadOnlySpan<int> components)
            {
                fixed (int* components_ptr = components)
                {
                    Color3xvOES(components_ptr);
                }
            }
            /// <inheritdoc cref="Color3xvOES(int*)"/>
            public static unsafe void Color3xvOES(int[] components)
            {
                fixed (int* components_ptr = components)
                {
                    Color3xvOES(components_ptr);
                }
            }
            /// <inheritdoc cref="Color3xvOES(int*)"/>
            public static unsafe void Color3xvOES(in int components)
            {
                fixed (int* components_ptr = &components)
                {
                    Color3xvOES(components_ptr);
                }
            }
            /// <inheritdoc cref="Color4xvOES(int*)"/>
            public static unsafe void Color4xvOES(ReadOnlySpan<int> components)
            {
                fixed (int* components_ptr = components)
                {
                    Color4xvOES(components_ptr);
                }
            }
            /// <inheritdoc cref="Color4xvOES(int*)"/>
            public static unsafe void Color4xvOES(int[] components)
            {
                fixed (int* components_ptr = components)
                {
                    Color4xvOES(components_ptr);
                }
            }
            /// <inheritdoc cref="Color4xvOES(int*)"/>
            public static unsafe void Color4xvOES(in int components)
            {
                fixed (int* components_ptr = &components)
                {
                    Color4xvOES(components_ptr);
                }
            }
            /// <inheritdoc cref="ConvolutionParameterxvOES(ConvolutionTargetEXT, ConvolutionParameter, int*)"/>
            public static unsafe void ConvolutionParameterxvOES(ConvolutionTargetEXT target, ConvolutionParameter pname, ReadOnlySpan<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    ConvolutionParameterxvOES(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="ConvolutionParameterxvOES(ConvolutionTargetEXT, ConvolutionParameter, int*)"/>
            public static unsafe void ConvolutionParameterxvOES(ConvolutionTargetEXT target, ConvolutionParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    ConvolutionParameterxvOES(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="ConvolutionParameterxvOES(ConvolutionTargetEXT, ConvolutionParameter, int*)"/>
            public static unsafe void ConvolutionParameterxvOES(ConvolutionTargetEXT target, ConvolutionParameter pname, in int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    ConvolutionParameterxvOES(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="DeleteFramebuffersOES(int, int*)"/>
            public static unsafe void DeleteFramebuffersOES(ReadOnlySpan<int> framebuffers)
            {
                int n = (int)(framebuffers.Length);
                fixed (int* framebuffers_ptr = framebuffers)
                {
                    DeleteFramebuffersOES(n, framebuffers_ptr);
                }
            }
            /// <inheritdoc cref="DeleteFramebuffersOES(int, int*)"/>
            public static unsafe void DeleteFramebuffersOES(int[] framebuffers)
            {
                int n = (int)(framebuffers.Length);
                fixed (int* framebuffers_ptr = framebuffers)
                {
                    DeleteFramebuffersOES(n, framebuffers_ptr);
                }
            }
            /// <inheritdoc cref="DeleteFramebuffersOES(int, int*)"/>
            public static unsafe void DeleteFramebuffersOES(int n, in int framebuffers)
            {
                fixed (int* framebuffers_ptr = &framebuffers)
                {
                    DeleteFramebuffersOES(n, framebuffers_ptr);
                }
            }
            /// <inheritdoc cref="DeleteRenderbuffersOES(int, int*)"/>
            public static unsafe void DeleteRenderbuffersOES(ReadOnlySpan<int> renderbuffers)
            {
                int n = (int)(renderbuffers.Length);
                fixed (int* renderbuffers_ptr = renderbuffers)
                {
                    DeleteRenderbuffersOES(n, renderbuffers_ptr);
                }
            }
            /// <inheritdoc cref="DeleteRenderbuffersOES(int, int*)"/>
            public static unsafe void DeleteRenderbuffersOES(int[] renderbuffers)
            {
                int n = (int)(renderbuffers.Length);
                fixed (int* renderbuffers_ptr = renderbuffers)
                {
                    DeleteRenderbuffersOES(n, renderbuffers_ptr);
                }
            }
            /// <inheritdoc cref="DeleteRenderbuffersOES(int, int*)"/>
            public static unsafe void DeleteRenderbuffersOES(int n, in int renderbuffers)
            {
                fixed (int* renderbuffers_ptr = &renderbuffers)
                {
                    DeleteRenderbuffersOES(n, renderbuffers_ptr);
                }
            }
            /// <inheritdoc cref="DeleteVertexArraysOES(int, int*)"/>
            public static unsafe void DeleteVertexArraysOES(ReadOnlySpan<int> arrays)
            {
                int n = (int)(arrays.Length);
                fixed (int* arrays_ptr = arrays)
                {
                    DeleteVertexArraysOES(n, arrays_ptr);
                }
            }
            /// <inheritdoc cref="DeleteVertexArraysOES(int, int*)"/>
            public static unsafe void DeleteVertexArraysOES(int[] arrays)
            {
                int n = (int)(arrays.Length);
                fixed (int* arrays_ptr = arrays)
                {
                    DeleteVertexArraysOES(n, arrays_ptr);
                }
            }
            /// <inheritdoc cref="DeleteVertexArraysOES(int, int*)"/>
            public static unsafe void DeleteVertexArraysOES(int n, in int arrays)
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
            public static unsafe void DrawTexfvOES(in float coords)
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
            public static unsafe void DrawTexivOES(in int coords)
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
            public static unsafe void DrawTexsvOES(in short coords)
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
            public static unsafe void DrawTexxvOES(in int coords)
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
            public static unsafe void EGLImageTargetTexture2DOES<T1>(All target, ref T1 image)
                where T1 : unmanaged
            {
                fixed (void* image_ptr = &image)
                {
                    EGLImageTargetTexture2DOES(target, image_ptr);
                }
            }
            /// <inheritdoc cref="EvalCoord1xvOES(int*)"/>
            public static unsafe void EvalCoord1xvOES(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    EvalCoord1xvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="EvalCoord1xvOES(int*)"/>
            public static unsafe void EvalCoord1xvOES(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    EvalCoord1xvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="EvalCoord1xvOES(int*)"/>
            public static unsafe void EvalCoord1xvOES(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    EvalCoord1xvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="EvalCoord2xvOES(int*)"/>
            public static unsafe void EvalCoord2xvOES(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    EvalCoord2xvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="EvalCoord2xvOES(int*)"/>
            public static unsafe void EvalCoord2xvOES(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    EvalCoord2xvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="EvalCoord2xvOES(int*)"/>
            public static unsafe void EvalCoord2xvOES(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    EvalCoord2xvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="FeedbackBufferxOES(int, All, int*)"/>
            public static unsafe void FeedbackBufferxOES(All type, ReadOnlySpan<int> buffer)
            {
                int n = (int)(buffer.Length);
                fixed (int* buffer_ptr = buffer)
                {
                    FeedbackBufferxOES(n, type, buffer_ptr);
                }
            }
            /// <inheritdoc cref="FeedbackBufferxOES(int, All, int*)"/>
            public static unsafe void FeedbackBufferxOES(All type, int[] buffer)
            {
                int n = (int)(buffer.Length);
                fixed (int* buffer_ptr = buffer)
                {
                    FeedbackBufferxOES(n, type, buffer_ptr);
                }
            }
            /// <inheritdoc cref="FeedbackBufferxOES(int, All, int*)"/>
            public static unsafe void FeedbackBufferxOES(int n, All type, in int buffer)
            {
                fixed (int* buffer_ptr = &buffer)
                {
                    FeedbackBufferxOES(n, type, buffer_ptr);
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
            public static unsafe void FogxvOES(FogPName pname, in int param)
            {
                fixed (int* param_ptr = &param)
                {
                    FogxvOES(pname, param_ptr);
                }
            }
            /// <inheritdoc cref="GenFramebuffersOES(int, int*)"/>
            public static unsafe void GenFramebuffersOES(Span<int> framebuffers)
            {
                int n = (int)(framebuffers.Length);
                fixed (int* framebuffers_ptr = framebuffers)
                {
                    GenFramebuffersOES(n, framebuffers_ptr);
                }
            }
            /// <inheritdoc cref="GenFramebuffersOES(int, int*)"/>
            public static unsafe void GenFramebuffersOES(int[] framebuffers)
            {
                int n = (int)(framebuffers.Length);
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
            public static unsafe void GenRenderbuffersOES(Span<int> renderbuffers)
            {
                int n = (int)(renderbuffers.Length);
                fixed (int* renderbuffers_ptr = renderbuffers)
                {
                    GenRenderbuffersOES(n, renderbuffers_ptr);
                }
            }
            /// <inheritdoc cref="GenRenderbuffersOES(int, int*)"/>
            public static unsafe void GenRenderbuffersOES(int[] renderbuffers)
            {
                int n = (int)(renderbuffers.Length);
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
            public static unsafe void GenVertexArraysOES(Span<int> arrays)
            {
                int n = (int)(arrays.Length);
                fixed (int* arrays_ptr = arrays)
                {
                    GenVertexArraysOES(n, arrays_ptr);
                }
            }
            /// <inheritdoc cref="GenVertexArraysOES(int, int*)"/>
            public static unsafe void GenVertexArraysOES(int[] arrays)
            {
                int n = (int)(arrays.Length);
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
            /// <inheritdoc cref="GetBufferPointervOES(BufferTargetARB, BufferPointerNameARB, void**)"/>
            public static unsafe void GetBufferPointervOES(BufferTargetARB target, BufferPointerNameARB pname, void** parameters)
            {
                GetBufferPointervOES_(target, pname, parameters);
            }
            /// <inheritdoc cref="GetBufferPointervOES(BufferTargetARB, BufferPointerNameARB, void**)"/>
            public static unsafe void* GetBufferPointervOES(BufferTargetARB target, BufferPointerNameARB pname)
            {
                void* parameters_val;
                void** parameters = &parameters_val;
                GetBufferPointervOES_(target, pname, parameters);
                return parameters_val;
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
            /// <inheritdoc cref="GetClipPlanefOES(ClipPlaneName, float*)"/>
            public static unsafe float GetClipPlanefOES(ClipPlaneName plane)
            {
                float equation_val;
                float* equation = &equation_val;
                GetClipPlanefOES(plane, equation);
                return equation_val;
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
            /// <inheritdoc cref="GetClipPlanexOES(ClipPlaneName, int*)"/>
            public static unsafe int GetClipPlanexOES(ClipPlaneName plane)
            {
                int equation_val;
                int* equation = &equation_val;
                GetClipPlanexOES(plane, equation);
                return equation_val;
            }
            /// <inheritdoc cref="GetConvolutionParameterxvOES(All, All, int*)"/>
            public static unsafe void GetConvolutionParameterxvOES(All target, All pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetConvolutionParameterxvOES(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetConvolutionParameterxvOES(All, All, int*)"/>
            public static unsafe void GetConvolutionParameterxvOES(All target, All pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetConvolutionParameterxvOES(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetConvolutionParameterxvOES(All, All, int*)"/>
            public static unsafe void GetConvolutionParameterxvOES(All target, All pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetConvolutionParameterxvOES(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetConvolutionParameterxvOES(All, All, int*)"/>
            public static unsafe int GetConvolutionParameterxvOES(All target, All pname)
            {
                int parameters_val;
                int* parameters = &parameters_val;
                GetConvolutionParameterxvOES(target, pname, parameters);
                return parameters_val;
            }
            /// <inheritdoc cref="GetFixedvOES(GetPName, int*)"/>
            public static unsafe void GetFixedvOES(GetPName pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetFixedvOES(pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetFixedvOES(GetPName, int*)"/>
            public static unsafe void GetFixedvOES(GetPName pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetFixedvOES(pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetFixedvOES(GetPName, int*)"/>
            public static unsafe void GetFixedvOES(GetPName pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetFixedvOES(pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetFixedvOES(GetPName, int*)"/>
            public static unsafe int GetFixedvOES(GetPName pname)
            {
                int parameters_val;
                int* parameters = &parameters_val;
                GetFixedvOES(pname, parameters);
                return parameters_val;
            }
            /// <inheritdoc cref="GetFramebufferAttachmentParameterivOES(FramebufferTarget, FramebufferAttachment, FramebufferAttachmentParameterName, int*)"/>
            public static unsafe void GetFramebufferAttachmentParameterivOES(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetFramebufferAttachmentParameterivOES(target, attachment, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetFramebufferAttachmentParameterivOES(FramebufferTarget, FramebufferAttachment, FramebufferAttachmentParameterName, int*)"/>
            public static unsafe void GetFramebufferAttachmentParameterivOES(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetFramebufferAttachmentParameterivOES(target, attachment, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetFramebufferAttachmentParameterivOES(FramebufferTarget, FramebufferAttachment, FramebufferAttachmentParameterName, int*)"/>
            public static unsafe void GetFramebufferAttachmentParameterivOES(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetFramebufferAttachmentParameterivOES(target, attachment, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetFramebufferAttachmentParameterivOES(FramebufferTarget, FramebufferAttachment, FramebufferAttachmentParameterName, int*)"/>
            public static unsafe int GetFramebufferAttachmentParameterivOES(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname)
            {
                int parameters_val;
                int* parameters = &parameters_val;
                GetFramebufferAttachmentParameterivOES(target, attachment, pname, parameters);
                return parameters_val;
            }
            /// <inheritdoc cref="GetHistogramParameterxvOES(HistogramTargetEXT, GetHistogramParameterPNameEXT, int*)"/>
            public static unsafe void GetHistogramParameterxvOES(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetHistogramParameterxvOES(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetHistogramParameterxvOES(HistogramTargetEXT, GetHistogramParameterPNameEXT, int*)"/>
            public static unsafe void GetHistogramParameterxvOES(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetHistogramParameterxvOES(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetHistogramParameterxvOES(HistogramTargetEXT, GetHistogramParameterPNameEXT, int*)"/>
            public static unsafe void GetHistogramParameterxvOES(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetHistogramParameterxvOES(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetHistogramParameterxvOES(HistogramTargetEXT, GetHistogramParameterPNameEXT, int*)"/>
            public static unsafe int GetHistogramParameterxvOES(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname)
            {
                int parameters_val;
                int* parameters = &parameters_val;
                GetHistogramParameterxvOES(target, pname, parameters);
                return parameters_val;
            }
            /// <inheritdoc cref="GetLightxOES(LightName, LightParameter, int*)"/>
            public static unsafe void GetLightxOES(LightName light, LightParameter pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetLightxOES(light, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetLightxOES(LightName, LightParameter, int*)"/>
            public static unsafe void GetLightxOES(LightName light, LightParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetLightxOES(light, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetLightxOES(LightName, LightParameter, int*)"/>
            public static unsafe void GetLightxOES(LightName light, LightParameter pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetLightxOES(light, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetLightxOES(LightName, LightParameter, int*)"/>
            public static unsafe int GetLightxOES(LightName light, LightParameter pname)
            {
                int parameters_val;
                int* parameters = &parameters_val;
                GetLightxOES(light, pname, parameters);
                return parameters_val;
            }
            /// <inheritdoc cref="GetLightxvOES(LightName, LightParameter, int*)"/>
            public static unsafe void GetLightxvOES(LightName light, LightParameter pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetLightxvOES(light, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetLightxvOES(LightName, LightParameter, int*)"/>
            public static unsafe void GetLightxvOES(LightName light, LightParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetLightxvOES(light, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetLightxvOES(LightName, LightParameter, int*)"/>
            public static unsafe void GetLightxvOES(LightName light, LightParameter pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetLightxvOES(light, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetLightxvOES(LightName, LightParameter, int*)"/>
            public static unsafe int GetLightxvOES(LightName light, LightParameter pname)
            {
                int parameters_val;
                int* parameters = &parameters_val;
                GetLightxvOES(light, pname, parameters);
                return parameters_val;
            }
            /// <inheritdoc cref="GetMapxvOES(MapTarget, GetMapQuery, int*)"/>
            public static unsafe void GetMapxvOES(MapTarget target, GetMapQuery query, Span<int> v)
            {
                fixed (int* v_ptr = v)
                {
                    GetMapxvOES(target, query, v_ptr);
                }
            }
            /// <inheritdoc cref="GetMapxvOES(MapTarget, GetMapQuery, int*)"/>
            public static unsafe void GetMapxvOES(MapTarget target, GetMapQuery query, int[] v)
            {
                fixed (int* v_ptr = v)
                {
                    GetMapxvOES(target, query, v_ptr);
                }
            }
            /// <inheritdoc cref="GetMapxvOES(MapTarget, GetMapQuery, int*)"/>
            public static unsafe void GetMapxvOES(MapTarget target, GetMapQuery query, ref int v)
            {
                fixed (int* v_ptr = &v)
                {
                    GetMapxvOES(target, query, v_ptr);
                }
            }
            /// <inheritdoc cref="GetMapxvOES(MapTarget, GetMapQuery, int*)"/>
            public static unsafe int GetMapxvOES(MapTarget target, GetMapQuery query)
            {
                int v_val;
                int* v = &v_val;
                GetMapxvOES(target, query, v);
                return v_val;
            }
            /// <inheritdoc cref="GetMaterialxvOES(TriangleFace, MaterialParameter, int*)"/>
            public static unsafe void GetMaterialxvOES(TriangleFace face, MaterialParameter pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetMaterialxvOES(face, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetMaterialxvOES(TriangleFace, MaterialParameter, int*)"/>
            public static unsafe void GetMaterialxvOES(TriangleFace face, MaterialParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetMaterialxvOES(face, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetMaterialxvOES(TriangleFace, MaterialParameter, int*)"/>
            public static unsafe void GetMaterialxvOES(TriangleFace face, MaterialParameter pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetMaterialxvOES(face, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetMaterialxvOES(TriangleFace, MaterialParameter, int*)"/>
            public static unsafe int GetMaterialxvOES(TriangleFace face, MaterialParameter pname)
            {
                int parameters_val;
                int* parameters = &parameters_val;
                GetMaterialxvOES(face, pname, parameters);
                return parameters_val;
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
            /// <inheritdoc cref="GetPixelMapxv(PixelMap, int, int*)"/>
            public static unsafe int GetPixelMapx(PixelMap map, int size)
            {
                int values_val;
                int* values = &values_val;
                GetPixelMapxv(map, size, values);
                return values_val;
            }
            /// <inheritdoc cref="GetRenderbufferParameterivOES(RenderbufferTarget, RenderbufferParameterName, int*)"/>
            public static unsafe void GetRenderbufferParameterivOES(RenderbufferTarget target, RenderbufferParameterName pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetRenderbufferParameterivOES(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetRenderbufferParameterivOES(RenderbufferTarget, RenderbufferParameterName, int*)"/>
            public static unsafe void GetRenderbufferParameterivOES(RenderbufferTarget target, RenderbufferParameterName pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetRenderbufferParameterivOES(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetRenderbufferParameterivOES(RenderbufferTarget, RenderbufferParameterName, int*)"/>
            public static unsafe void GetRenderbufferParameterivOES(RenderbufferTarget target, RenderbufferParameterName pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetRenderbufferParameterivOES(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetRenderbufferParameterivOES(RenderbufferTarget, RenderbufferParameterName, int*)"/>
            public static unsafe int GetRenderbufferParameterivOES(RenderbufferTarget target, RenderbufferParameterName pname)
            {
                int parameters_val;
                int* parameters = &parameters_val;
                GetRenderbufferParameterivOES(target, pname, parameters);
                return parameters_val;
            }
            /// <inheritdoc cref="GetTexEnvxvOES(TextureEnvTarget, TextureEnvParameter, int*)"/>
            public static unsafe void GetTexEnvxvOES(TextureEnvTarget target, TextureEnvParameter pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexEnvxvOES(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexEnvxvOES(TextureEnvTarget, TextureEnvParameter, int*)"/>
            public static unsafe void GetTexEnvxvOES(TextureEnvTarget target, TextureEnvParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexEnvxvOES(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexEnvxvOES(TextureEnvTarget, TextureEnvParameter, int*)"/>
            public static unsafe void GetTexEnvxvOES(TextureEnvTarget target, TextureEnvParameter pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetTexEnvxvOES(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexEnvxvOES(TextureEnvTarget, TextureEnvParameter, int*)"/>
            public static unsafe int GetTexEnvxvOES(TextureEnvTarget target, TextureEnvParameter pname)
            {
                int parameters_val;
                int* parameters = &parameters_val;
                GetTexEnvxvOES(target, pname, parameters);
                return parameters_val;
            }
            /// <inheritdoc cref="GetTexGenfvOES(TextureCoordName, TextureGenParameter, float*)"/>
            public static unsafe void GetTexGenfvOES(TextureCoordName coord, TextureGenParameter pname, Span<float> parameters)
            {
                fixed (float* parameters_ptr = parameters)
                {
                    GetTexGenfvOES(coord, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexGenfvOES(TextureCoordName, TextureGenParameter, float*)"/>
            public static unsafe void GetTexGenfvOES(TextureCoordName coord, TextureGenParameter pname, float[] parameters)
            {
                fixed (float* parameters_ptr = parameters)
                {
                    GetTexGenfvOES(coord, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexGenfvOES(TextureCoordName, TextureGenParameter, float*)"/>
            public static unsafe void GetTexGenfvOES(TextureCoordName coord, TextureGenParameter pname, ref float parameters)
            {
                fixed (float* parameters_ptr = &parameters)
                {
                    GetTexGenfvOES(coord, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexGenfvOES(TextureCoordName, TextureGenParameter, float*)"/>
            public static unsafe float GetTexGenfvOES(TextureCoordName coord, TextureGenParameter pname)
            {
                float parameters_val;
                float* parameters = &parameters_val;
                GetTexGenfvOES(coord, pname, parameters);
                return parameters_val;
            }
            /// <inheritdoc cref="GetTexGenivOES(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe void GetTexGenivOES(TextureCoordName coord, TextureGenParameter pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexGenivOES(coord, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexGenivOES(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe void GetTexGenivOES(TextureCoordName coord, TextureGenParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexGenivOES(coord, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexGenivOES(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe void GetTexGenivOES(TextureCoordName coord, TextureGenParameter pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetTexGenivOES(coord, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexGenivOES(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe int GetTexGenivOES(TextureCoordName coord, TextureGenParameter pname)
            {
                int parameters_val;
                int* parameters = &parameters_val;
                GetTexGenivOES(coord, pname, parameters);
                return parameters_val;
            }
            /// <inheritdoc cref="GetTexGenxvOES(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe void GetTexGenxvOES(TextureCoordName coord, TextureGenParameter pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexGenxvOES(coord, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexGenxvOES(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe void GetTexGenxvOES(TextureCoordName coord, TextureGenParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexGenxvOES(coord, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexGenxvOES(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe void GetTexGenxvOES(TextureCoordName coord, TextureGenParameter pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetTexGenxvOES(coord, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexGenxvOES(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe int GetTexGenxvOES(TextureCoordName coord, TextureGenParameter pname)
            {
                int parameters_val;
                int* parameters = &parameters_val;
                GetTexGenxvOES(coord, pname, parameters);
                return parameters_val;
            }
            /// <inheritdoc cref="GetTexLevelParameterxvOES(TextureTarget, int, GetTextureParameter, int*)"/>
            public static unsafe void GetTexLevelParameterxvOES(TextureTarget target, int level, GetTextureParameter pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexLevelParameterxvOES(target, level, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexLevelParameterxvOES(TextureTarget, int, GetTextureParameter, int*)"/>
            public static unsafe void GetTexLevelParameterxvOES(TextureTarget target, int level, GetTextureParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexLevelParameterxvOES(target, level, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexLevelParameterxvOES(TextureTarget, int, GetTextureParameter, int*)"/>
            public static unsafe void GetTexLevelParameterxvOES(TextureTarget target, int level, GetTextureParameter pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetTexLevelParameterxvOES(target, level, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexLevelParameterxvOES(TextureTarget, int, GetTextureParameter, int*)"/>
            public static unsafe int GetTexLevelParameterxvOES(TextureTarget target, int level, GetTextureParameter pname)
            {
                int parameters_val;
                int* parameters = &parameters_val;
                GetTexLevelParameterxvOES(target, level, pname, parameters);
                return parameters_val;
            }
            /// <inheritdoc cref="GetTexParameterxvOES(TextureTarget, GetTextureParameter, int*)"/>
            public static unsafe void GetTexParameterxvOES(TextureTarget target, GetTextureParameter pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexParameterxvOES(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexParameterxvOES(TextureTarget, GetTextureParameter, int*)"/>
            public static unsafe void GetTexParameterxvOES(TextureTarget target, GetTextureParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexParameterxvOES(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexParameterxvOES(TextureTarget, GetTextureParameter, int*)"/>
            public static unsafe void GetTexParameterxvOES(TextureTarget target, GetTextureParameter pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetTexParameterxvOES(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexParameterxvOES(TextureTarget, GetTextureParameter, int*)"/>
            public static unsafe int GetTexParameterxvOES(TextureTarget target, GetTextureParameter pname)
            {
                int parameters_val;
                int* parameters = &parameters_val;
                GetTexParameterxvOES(target, pname, parameters);
                return parameters_val;
            }
            /// <inheritdoc cref="IndexxvOES(int*)"/>
            public static unsafe void IndexxvOES(ReadOnlySpan<int> component)
            {
                fixed (int* component_ptr = component)
                {
                    IndexxvOES(component_ptr);
                }
            }
            /// <inheritdoc cref="IndexxvOES(int*)"/>
            public static unsafe void IndexxvOES(int[] component)
            {
                fixed (int* component_ptr = component)
                {
                    IndexxvOES(component_ptr);
                }
            }
            /// <inheritdoc cref="IndexxvOES(int*)"/>
            public static unsafe void IndexxvOES(in int component)
            {
                fixed (int* component_ptr = &component)
                {
                    IndexxvOES(component_ptr);
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
            public static unsafe void LightModelxvOES(LightModelParameter pname, in int param)
            {
                fixed (int* param_ptr = &param)
                {
                    LightModelxvOES(pname, param_ptr);
                }
            }
            /// <inheritdoc cref="LightxvOES(LightName, LightParameter, int*)"/>
            public static unsafe void LightxvOES(LightName light, LightParameter pname, ReadOnlySpan<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    LightxvOES(light, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="LightxvOES(LightName, LightParameter, int*)"/>
            public static unsafe void LightxvOES(LightName light, LightParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    LightxvOES(light, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="LightxvOES(LightName, LightParameter, int*)"/>
            public static unsafe void LightxvOES(LightName light, LightParameter pname, in int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    LightxvOES(light, pname, parameters_ptr);
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
            public static unsafe void LoadMatrixxOES(in int m)
            {
                fixed (int* m_ptr = &m)
                {
                    LoadMatrixxOES(m_ptr);
                }
            }
            /// <inheritdoc cref="LoadTransposeMatrixxOES(int*)"/>
            public static unsafe void LoadTransposeMatrixxOES(ReadOnlySpan<int> m)
            {
                fixed (int* m_ptr = m)
                {
                    LoadTransposeMatrixxOES(m_ptr);
                }
            }
            /// <inheritdoc cref="LoadTransposeMatrixxOES(int*)"/>
            public static unsafe void LoadTransposeMatrixxOES(int[] m)
            {
                fixed (int* m_ptr = m)
                {
                    LoadTransposeMatrixxOES(m_ptr);
                }
            }
            /// <inheritdoc cref="LoadTransposeMatrixxOES(int*)"/>
            public static unsafe void LoadTransposeMatrixxOES(in int m)
            {
                fixed (int* m_ptr = &m)
                {
                    LoadTransposeMatrixxOES(m_ptr);
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
            public static unsafe void MaterialxvOES(TriangleFace face, MaterialParameter pname, in int param)
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
            public static unsafe void MatrixIndexPointerOES<T1>(int size, MatrixIndexPointerTypeARB type, int stride, in T1 pointer)
                where T1 : unmanaged
            {
                fixed (void* pointer_ptr = &pointer)
                {
                    MatrixIndexPointerOES(size, type, stride, pointer_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord1bvOES(TextureUnit, sbyte*)"/>
            public static unsafe void MultiTexCoord1bvOES(TextureUnit texture, ReadOnlySpan<sbyte> coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    MultiTexCoord1bvOES(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord1bvOES(TextureUnit, sbyte*)"/>
            public static unsafe void MultiTexCoord1bvOES(TextureUnit texture, sbyte[] coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    MultiTexCoord1bvOES(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord1bvOES(TextureUnit, sbyte*)"/>
            public static unsafe void MultiTexCoord1bvOES(TextureUnit texture, in sbyte coords)
            {
                fixed (sbyte* coords_ptr = &coords)
                {
                    MultiTexCoord1bvOES(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord1xvOES(TextureUnit, int*)"/>
            public static unsafe void MultiTexCoord1xvOES(TextureUnit texture, ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    MultiTexCoord1xvOES(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord1xvOES(TextureUnit, int*)"/>
            public static unsafe void MultiTexCoord1xvOES(TextureUnit texture, int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    MultiTexCoord1xvOES(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord1xvOES(TextureUnit, int*)"/>
            public static unsafe void MultiTexCoord1xvOES(TextureUnit texture, in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    MultiTexCoord1xvOES(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord2bvOES(TextureUnit, sbyte*)"/>
            public static unsafe void MultiTexCoord2bvOES(TextureUnit texture, ReadOnlySpan<sbyte> coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    MultiTexCoord2bvOES(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord2bvOES(TextureUnit, sbyte*)"/>
            public static unsafe void MultiTexCoord2bvOES(TextureUnit texture, sbyte[] coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    MultiTexCoord2bvOES(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord2bvOES(TextureUnit, sbyte*)"/>
            public static unsafe void MultiTexCoord2bvOES(TextureUnit texture, in sbyte coords)
            {
                fixed (sbyte* coords_ptr = &coords)
                {
                    MultiTexCoord2bvOES(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord2xvOES(TextureUnit, int*)"/>
            public static unsafe void MultiTexCoord2xvOES(TextureUnit texture, ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    MultiTexCoord2xvOES(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord2xvOES(TextureUnit, int*)"/>
            public static unsafe void MultiTexCoord2xvOES(TextureUnit texture, int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    MultiTexCoord2xvOES(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord2xvOES(TextureUnit, int*)"/>
            public static unsafe void MultiTexCoord2xvOES(TextureUnit texture, in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    MultiTexCoord2xvOES(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord3bvOES(TextureUnit, sbyte*)"/>
            public static unsafe void MultiTexCoord3bvOES(TextureUnit texture, ReadOnlySpan<sbyte> coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    MultiTexCoord3bvOES(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord3bvOES(TextureUnit, sbyte*)"/>
            public static unsafe void MultiTexCoord3bvOES(TextureUnit texture, sbyte[] coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    MultiTexCoord3bvOES(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord3bvOES(TextureUnit, sbyte*)"/>
            public static unsafe void MultiTexCoord3bvOES(TextureUnit texture, in sbyte coords)
            {
                fixed (sbyte* coords_ptr = &coords)
                {
                    MultiTexCoord3bvOES(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord3xvOES(TextureUnit, int*)"/>
            public static unsafe void MultiTexCoord3xvOES(TextureUnit texture, ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    MultiTexCoord3xvOES(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord3xvOES(TextureUnit, int*)"/>
            public static unsafe void MultiTexCoord3xvOES(TextureUnit texture, int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    MultiTexCoord3xvOES(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord3xvOES(TextureUnit, int*)"/>
            public static unsafe void MultiTexCoord3xvOES(TextureUnit texture, in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    MultiTexCoord3xvOES(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord4bvOES(TextureUnit, sbyte*)"/>
            public static unsafe void MultiTexCoord4bvOES(TextureUnit texture, ReadOnlySpan<sbyte> coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    MultiTexCoord4bvOES(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord4bvOES(TextureUnit, sbyte*)"/>
            public static unsafe void MultiTexCoord4bvOES(TextureUnit texture, sbyte[] coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    MultiTexCoord4bvOES(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord4bvOES(TextureUnit, sbyte*)"/>
            public static unsafe void MultiTexCoord4bvOES(TextureUnit texture, in sbyte coords)
            {
                fixed (sbyte* coords_ptr = &coords)
                {
                    MultiTexCoord4bvOES(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord4xvOES(TextureUnit, int*)"/>
            public static unsafe void MultiTexCoord4xvOES(TextureUnit texture, ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    MultiTexCoord4xvOES(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord4xvOES(TextureUnit, int*)"/>
            public static unsafe void MultiTexCoord4xvOES(TextureUnit texture, int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    MultiTexCoord4xvOES(texture, coords_ptr);
                }
            }
            /// <inheritdoc cref="MultiTexCoord4xvOES(TextureUnit, int*)"/>
            public static unsafe void MultiTexCoord4xvOES(TextureUnit texture, in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    MultiTexCoord4xvOES(texture, coords_ptr);
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
            public static unsafe void MultMatrixxOES(in int m)
            {
                fixed (int* m_ptr = &m)
                {
                    MultMatrixxOES(m_ptr);
                }
            }
            /// <inheritdoc cref="MultTransposeMatrixxOES(int*)"/>
            public static unsafe void MultTransposeMatrixxOES(ReadOnlySpan<int> m)
            {
                fixed (int* m_ptr = m)
                {
                    MultTransposeMatrixxOES(m_ptr);
                }
            }
            /// <inheritdoc cref="MultTransposeMatrixxOES(int*)"/>
            public static unsafe void MultTransposeMatrixxOES(int[] m)
            {
                fixed (int* m_ptr = m)
                {
                    MultTransposeMatrixxOES(m_ptr);
                }
            }
            /// <inheritdoc cref="MultTransposeMatrixxOES(int*)"/>
            public static unsafe void MultTransposeMatrixxOES(in int m)
            {
                fixed (int* m_ptr = &m)
                {
                    MultTransposeMatrixxOES(m_ptr);
                }
            }
            /// <inheritdoc cref="Normal3xvOES(int*)"/>
            public static unsafe void Normal3xvOES(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    Normal3xvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="Normal3xvOES(int*)"/>
            public static unsafe void Normal3xvOES(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    Normal3xvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="Normal3xvOES(int*)"/>
            public static unsafe void Normal3xvOES(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    Normal3xvOES(coords_ptr);
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
            /// <inheritdoc cref="PointParameterxvOES(PointParameterNameARB, int*)"/>
            public static unsafe void PointParameterxvOES(PointParameterNameARB pname, ReadOnlySpan<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    PointParameterxvOES(pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="PointParameterxvOES(PointParameterNameARB, int*)"/>
            public static unsafe void PointParameterxvOES(PointParameterNameARB pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    PointParameterxvOES(pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="PointParameterxvOES(PointParameterNameARB, int*)"/>
            public static unsafe void PointParameterxvOES(PointParameterNameARB pname, in int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    PointParameterxvOES(pname, parameters_ptr);
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
            public static unsafe void PointSizePointerOES<T1>(All type, int stride, in T1 pointer)
                where T1 : unmanaged
            {
                fixed (void* pointer_ptr = &pointer)
                {
                    PointSizePointerOES(type, stride, pointer_ptr);
                }
            }
            /// <inheritdoc cref="PrioritizeTexturesxOES(int, int*, int*)"/>
            public static unsafe void PrioritizeTexturesxOES(int n, ReadOnlySpan<int> textures, ReadOnlySpan<int> priorities)
            {
                fixed (int* textures_ptr = textures)
                {
                    fixed (int* priorities_ptr = priorities)
                    {
                        PrioritizeTexturesxOES(n, textures_ptr, priorities_ptr);
                    }
                }
            }
            /// <inheritdoc cref="PrioritizeTexturesxOES(int, int*, int*)"/>
            public static unsafe void PrioritizeTexturesxOES(int n, int[] textures, int[] priorities)
            {
                fixed (int* textures_ptr = textures)
                {
                    fixed (int* priorities_ptr = priorities)
                    {
                        PrioritizeTexturesxOES(n, textures_ptr, priorities_ptr);
                    }
                }
            }
            /// <inheritdoc cref="PrioritizeTexturesxOES(int, int*, int*)"/>
            public static unsafe void PrioritizeTexturesxOES(int n, in int textures, in int priorities)
            {
                fixed (int* textures_ptr = &textures)
                fixed (int* priorities_ptr = &priorities)
                {
                    PrioritizeTexturesxOES(n, textures_ptr, priorities_ptr);
                }
            }
            /// <inheritdoc cref="QueryMatrixxOES(int*, int*)"/>
            public static unsafe uint QueryMatrixxOES(Span<int> mantissa, Span<int> exponent)
            {
                uint returnValue;
                fixed (int* mantissa_ptr = mantissa)
                {
                    fixed (int* exponent_ptr = exponent)
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
                fixed (int* mantissa_ptr = mantissa)
                {
                    fixed (int* exponent_ptr = exponent)
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
            /// <inheritdoc cref="RasterPos2xvOES(int*)"/>
            public static unsafe void RasterPos2xvOES(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    RasterPos2xvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="RasterPos2xvOES(int*)"/>
            public static unsafe void RasterPos2xvOES(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    RasterPos2xvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="RasterPos2xvOES(int*)"/>
            public static unsafe void RasterPos2xvOES(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    RasterPos2xvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="RasterPos3xvOES(int*)"/>
            public static unsafe void RasterPos3xvOES(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    RasterPos3xvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="RasterPos3xvOES(int*)"/>
            public static unsafe void RasterPos3xvOES(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    RasterPos3xvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="RasterPos3xvOES(int*)"/>
            public static unsafe void RasterPos3xvOES(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    RasterPos3xvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="RasterPos4xvOES(int*)"/>
            public static unsafe void RasterPos4xvOES(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    RasterPos4xvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="RasterPos4xvOES(int*)"/>
            public static unsafe void RasterPos4xvOES(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    RasterPos4xvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="RasterPos4xvOES(int*)"/>
            public static unsafe void RasterPos4xvOES(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    RasterPos4xvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="RectxvOES(int*, int*)"/>
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
            /// <inheritdoc cref="RectxvOES(int*, int*)"/>
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
            /// <inheritdoc cref="RectxvOES(int*, int*)"/>
            public static unsafe void RectxvOES(in int v1, in int v2)
            {
                fixed (int* v1_ptr = &v1)
                fixed (int* v2_ptr = &v2)
                {
                    RectxvOES(v1_ptr, v2_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord1bvOES(sbyte*)"/>
            public static unsafe void TexCoord1bvOES(ReadOnlySpan<sbyte> coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    TexCoord1bvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord1bvOES(sbyte*)"/>
            public static unsafe void TexCoord1bvOES(sbyte[] coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    TexCoord1bvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord1bvOES(sbyte*)"/>
            public static unsafe void TexCoord1bvOES(in sbyte coords)
            {
                fixed (sbyte* coords_ptr = &coords)
                {
                    TexCoord1bvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord1xvOES(int*)"/>
            public static unsafe void TexCoord1xvOES(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    TexCoord1xvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord1xvOES(int*)"/>
            public static unsafe void TexCoord1xvOES(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    TexCoord1xvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord1xvOES(int*)"/>
            public static unsafe void TexCoord1xvOES(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    TexCoord1xvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord2bvOES(sbyte*)"/>
            public static unsafe void TexCoord2bvOES(ReadOnlySpan<sbyte> coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    TexCoord2bvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord2bvOES(sbyte*)"/>
            public static unsafe void TexCoord2bvOES(sbyte[] coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    TexCoord2bvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord2bvOES(sbyte*)"/>
            public static unsafe void TexCoord2bvOES(in sbyte coords)
            {
                fixed (sbyte* coords_ptr = &coords)
                {
                    TexCoord2bvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord2xvOES(int*)"/>
            public static unsafe void TexCoord2xvOES(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    TexCoord2xvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord2xvOES(int*)"/>
            public static unsafe void TexCoord2xvOES(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    TexCoord2xvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord2xvOES(int*)"/>
            public static unsafe void TexCoord2xvOES(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    TexCoord2xvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord3bvOES(sbyte*)"/>
            public static unsafe void TexCoord3bvOES(ReadOnlySpan<sbyte> coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    TexCoord3bvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord3bvOES(sbyte*)"/>
            public static unsafe void TexCoord3bvOES(sbyte[] coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    TexCoord3bvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord3bvOES(sbyte*)"/>
            public static unsafe void TexCoord3bvOES(in sbyte coords)
            {
                fixed (sbyte* coords_ptr = &coords)
                {
                    TexCoord3bvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord3xvOES(int*)"/>
            public static unsafe void TexCoord3xvOES(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    TexCoord3xvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord3xvOES(int*)"/>
            public static unsafe void TexCoord3xvOES(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    TexCoord3xvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord3xvOES(int*)"/>
            public static unsafe void TexCoord3xvOES(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    TexCoord3xvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord4bvOES(sbyte*)"/>
            public static unsafe void TexCoord4bvOES(ReadOnlySpan<sbyte> coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    TexCoord4bvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord4bvOES(sbyte*)"/>
            public static unsafe void TexCoord4bvOES(sbyte[] coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    TexCoord4bvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord4bvOES(sbyte*)"/>
            public static unsafe void TexCoord4bvOES(in sbyte coords)
            {
                fixed (sbyte* coords_ptr = &coords)
                {
                    TexCoord4bvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord4xvOES(int*)"/>
            public static unsafe void TexCoord4xvOES(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    TexCoord4xvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord4xvOES(int*)"/>
            public static unsafe void TexCoord4xvOES(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    TexCoord4xvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexCoord4xvOES(int*)"/>
            public static unsafe void TexCoord4xvOES(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    TexCoord4xvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="TexEnvxvOES(TextureEnvTarget, TextureEnvParameter, int*)"/>
            public static unsafe void TexEnvxvOES(TextureEnvTarget target, TextureEnvParameter pname, ReadOnlySpan<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    TexEnvxvOES(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexEnvxvOES(TextureEnvTarget, TextureEnvParameter, int*)"/>
            public static unsafe void TexEnvxvOES(TextureEnvTarget target, TextureEnvParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    TexEnvxvOES(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexEnvxvOES(TextureEnvTarget, TextureEnvParameter, int*)"/>
            public static unsafe void TexEnvxvOES(TextureEnvTarget target, TextureEnvParameter pname, in int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    TexEnvxvOES(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexGenfvOES(TextureCoordName, TextureGenParameter, float*)"/>
            public static unsafe void TexGenfvOES(TextureCoordName coord, TextureGenParameter pname, ReadOnlySpan<float> parameters)
            {
                fixed (float* parameters_ptr = parameters)
                {
                    TexGenfvOES(coord, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexGenfvOES(TextureCoordName, TextureGenParameter, float*)"/>
            public static unsafe void TexGenfvOES(TextureCoordName coord, TextureGenParameter pname, float[] parameters)
            {
                fixed (float* parameters_ptr = parameters)
                {
                    TexGenfvOES(coord, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexGenfvOES(TextureCoordName, TextureGenParameter, float*)"/>
            public static unsafe void TexGenfvOES(TextureCoordName coord, TextureGenParameter pname, in float parameters)
            {
                fixed (float* parameters_ptr = &parameters)
                {
                    TexGenfvOES(coord, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexGenivOES(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe void TexGenivOES(TextureCoordName coord, TextureGenParameter pname, ReadOnlySpan<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    TexGenivOES(coord, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexGenivOES(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe void TexGenivOES(TextureCoordName coord, TextureGenParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    TexGenivOES(coord, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexGenivOES(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe void TexGenivOES(TextureCoordName coord, TextureGenParameter pname, in int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    TexGenivOES(coord, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexGenxvOES(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe void TexGenxvOES(TextureCoordName coord, TextureGenParameter pname, ReadOnlySpan<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    TexGenxvOES(coord, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexGenxvOES(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe void TexGenxvOES(TextureCoordName coord, TextureGenParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    TexGenxvOES(coord, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexGenxvOES(TextureCoordName, TextureGenParameter, int*)"/>
            public static unsafe void TexGenxvOES(TextureCoordName coord, TextureGenParameter pname, in int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    TexGenxvOES(coord, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexParameterxvOES(TextureTarget, GetTextureParameter, int*)"/>
            public static unsafe void TexParameterxvOES(TextureTarget target, GetTextureParameter pname, ReadOnlySpan<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    TexParameterxvOES(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexParameterxvOES(TextureTarget, GetTextureParameter, int*)"/>
            public static unsafe void TexParameterxvOES(TextureTarget target, GetTextureParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    TexParameterxvOES(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexParameterxvOES(TextureTarget, GetTextureParameter, int*)"/>
            public static unsafe void TexParameterxvOES(TextureTarget target, GetTextureParameter pname, in int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    TexParameterxvOES(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="Vertex2bvOES(sbyte*)"/>
            public static unsafe void Vertex2bvOES(ReadOnlySpan<sbyte> coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    Vertex2bvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="Vertex2bvOES(sbyte*)"/>
            public static unsafe void Vertex2bvOES(sbyte[] coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    Vertex2bvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="Vertex2bvOES(sbyte*)"/>
            public static unsafe void Vertex2bvOES(in sbyte coords)
            {
                fixed (sbyte* coords_ptr = &coords)
                {
                    Vertex2bvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="Vertex2xvOES(int*)"/>
            public static unsafe void Vertex2xvOES(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    Vertex2xvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="Vertex2xvOES(int*)"/>
            public static unsafe void Vertex2xvOES(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    Vertex2xvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="Vertex2xvOES(int*)"/>
            public static unsafe void Vertex2xvOES(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    Vertex2xvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="Vertex3bvOES(sbyte*)"/>
            public static unsafe void Vertex3bvOES(ReadOnlySpan<sbyte> coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    Vertex3bvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="Vertex3bvOES(sbyte*)"/>
            public static unsafe void Vertex3bvOES(sbyte[] coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    Vertex3bvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="Vertex3bvOES(sbyte*)"/>
            public static unsafe void Vertex3bvOES(in sbyte coords)
            {
                fixed (sbyte* coords_ptr = &coords)
                {
                    Vertex3bvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="Vertex3xvOES(int*)"/>
            public static unsafe void Vertex3xvOES(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    Vertex3xvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="Vertex3xvOES(int*)"/>
            public static unsafe void Vertex3xvOES(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    Vertex3xvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="Vertex3xvOES(int*)"/>
            public static unsafe void Vertex3xvOES(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    Vertex3xvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="Vertex4bvOES(sbyte*)"/>
            public static unsafe void Vertex4bvOES(ReadOnlySpan<sbyte> coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    Vertex4bvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="Vertex4bvOES(sbyte*)"/>
            public static unsafe void Vertex4bvOES(sbyte[] coords)
            {
                fixed (sbyte* coords_ptr = coords)
                {
                    Vertex4bvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="Vertex4bvOES(sbyte*)"/>
            public static unsafe void Vertex4bvOES(in sbyte coords)
            {
                fixed (sbyte* coords_ptr = &coords)
                {
                    Vertex4bvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="Vertex4xvOES(int*)"/>
            public static unsafe void Vertex4xvOES(ReadOnlySpan<int> coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    Vertex4xvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="Vertex4xvOES(int*)"/>
            public static unsafe void Vertex4xvOES(int[] coords)
            {
                fixed (int* coords_ptr = coords)
                {
                    Vertex4xvOES(coords_ptr);
                }
            }
            /// <inheritdoc cref="Vertex4xvOES(int*)"/>
            public static unsafe void Vertex4xvOES(in int coords)
            {
                fixed (int* coords_ptr = &coords)
                {
                    Vertex4xvOES(coords_ptr);
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
            public static unsafe void WeightPointerOES<T1>(int size, All type, int stride, in T1 pointer)
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
            public static unsafe void ExtGetBuffersQCOM(Span<int> buffers, Span<int> numBuffers)
            {
                int maxBuffers = (int)(buffers.Length);
                fixed (int* buffers_ptr = buffers)
                {
                    fixed (int* numBuffers_ptr = numBuffers)
                    {
                        ExtGetBuffersQCOM(buffers_ptr, maxBuffers, numBuffers_ptr);
                    }
                }
            }
            /// <inheritdoc cref="ExtGetBuffersQCOM(int*, int, int*)"/>
            public static unsafe void ExtGetBuffersQCOM(int[] buffers, int[] numBuffers)
            {
                int maxBuffers = (int)(buffers.Length);
                fixed (int* buffers_ptr = buffers)
                {
                    fixed (int* numBuffers_ptr = numBuffers)
                    {
                        ExtGetBuffersQCOM(buffers_ptr, maxBuffers, numBuffers_ptr);
                    }
                }
            }
            /// <inheritdoc cref="ExtGetBuffersQCOM(int*, int, int*)"/>
            public static unsafe void ExtGetBuffersQCOM(ref int buffers, int maxBuffers, ref int numBuffers)
            {
                fixed (int* buffers_ptr = &buffers)
                fixed (int* numBuffers_ptr = &numBuffers)
                {
                    ExtGetBuffersQCOM(buffers_ptr, maxBuffers, numBuffers_ptr);
                }
            }
            /// <inheritdoc cref="ExtGetFramebuffersQCOM(int*, int, int*)"/>
            public static unsafe void ExtGetFramebuffersQCOM(Span<int> framebuffers, Span<int> numFramebuffers)
            {
                int maxFramebuffers = (int)(framebuffers.Length);
                fixed (int* framebuffers_ptr = framebuffers)
                {
                    fixed (int* numFramebuffers_ptr = numFramebuffers)
                    {
                        ExtGetFramebuffersQCOM(framebuffers_ptr, maxFramebuffers, numFramebuffers_ptr);
                    }
                }
            }
            /// <inheritdoc cref="ExtGetFramebuffersQCOM(int*, int, int*)"/>
            public static unsafe void ExtGetFramebuffersQCOM(int[] framebuffers, int[] numFramebuffers)
            {
                int maxFramebuffers = (int)(framebuffers.Length);
                fixed (int* framebuffers_ptr = framebuffers)
                {
                    fixed (int* numFramebuffers_ptr = numFramebuffers)
                    {
                        ExtGetFramebuffersQCOM(framebuffers_ptr, maxFramebuffers, numFramebuffers_ptr);
                    }
                }
            }
            /// <inheritdoc cref="ExtGetFramebuffersQCOM(int*, int, int*)"/>
            public static unsafe void ExtGetFramebuffersQCOM(ref int framebuffers, int maxFramebuffers, ref int numFramebuffers)
            {
                fixed (int* framebuffers_ptr = &framebuffers)
                fixed (int* numFramebuffers_ptr = &numFramebuffers)
                {
                    ExtGetFramebuffersQCOM(framebuffers_ptr, maxFramebuffers, numFramebuffers_ptr);
                }
            }
            /// <inheritdoc cref="ExtGetProgramBinarySourceQCOM(int, ShaderType, byte*, int*)"/>
            public static unsafe string ExtGetProgramBinarySourceQCOM(int program, ShaderType shadertype, ref int length)
            {
                string source;
                fixed (int* length_ptr = &length)
                {
                    var source_ptr = (byte*)Marshal.AllocCoTaskMem(*length_ptr);
                    ExtGetProgramBinarySourceQCOM(program, shadertype, source_ptr, length_ptr);
                    source = Marshal.PtrToStringUTF8((IntPtr)source_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)source_ptr);
                }
                return source;
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
            public static unsafe void ExtGetProgramsQCOM(Span<int> programs, Span<int> numPrograms)
            {
                int maxPrograms = (int)(programs.Length);
                fixed (int* programs_ptr = programs)
                {
                    fixed (int* numPrograms_ptr = numPrograms)
                    {
                        ExtGetProgramsQCOM(programs_ptr, maxPrograms, numPrograms_ptr);
                    }
                }
            }
            /// <inheritdoc cref="ExtGetProgramsQCOM(int*, int, int*)"/>
            public static unsafe void ExtGetProgramsQCOM(int[] programs, int[] numPrograms)
            {
                int maxPrograms = (int)(programs.Length);
                fixed (int* programs_ptr = programs)
                {
                    fixed (int* numPrograms_ptr = numPrograms)
                    {
                        ExtGetProgramsQCOM(programs_ptr, maxPrograms, numPrograms_ptr);
                    }
                }
            }
            /// <inheritdoc cref="ExtGetProgramsQCOM(int*, int, int*)"/>
            public static unsafe void ExtGetProgramsQCOM(ref int programs, int maxPrograms, ref int numPrograms)
            {
                fixed (int* programs_ptr = &programs)
                fixed (int* numPrograms_ptr = &numPrograms)
                {
                    ExtGetProgramsQCOM(programs_ptr, maxPrograms, numPrograms_ptr);
                }
            }
            /// <inheritdoc cref="ExtGetRenderbuffersQCOM(int*, int, int*)"/>
            public static unsafe void ExtGetRenderbuffersQCOM(Span<int> renderbuffers, Span<int> numRenderbuffers)
            {
                int maxRenderbuffers = (int)(renderbuffers.Length);
                fixed (int* renderbuffers_ptr = renderbuffers)
                {
                    fixed (int* numRenderbuffers_ptr = numRenderbuffers)
                    {
                        ExtGetRenderbuffersQCOM(renderbuffers_ptr, maxRenderbuffers, numRenderbuffers_ptr);
                    }
                }
            }
            /// <inheritdoc cref="ExtGetRenderbuffersQCOM(int*, int, int*)"/>
            public static unsafe void ExtGetRenderbuffersQCOM(int[] renderbuffers, int[] numRenderbuffers)
            {
                int maxRenderbuffers = (int)(renderbuffers.Length);
                fixed (int* renderbuffers_ptr = renderbuffers)
                {
                    fixed (int* numRenderbuffers_ptr = numRenderbuffers)
                    {
                        ExtGetRenderbuffersQCOM(renderbuffers_ptr, maxRenderbuffers, numRenderbuffers_ptr);
                    }
                }
            }
            /// <inheritdoc cref="ExtGetRenderbuffersQCOM(int*, int, int*)"/>
            public static unsafe void ExtGetRenderbuffersQCOM(ref int renderbuffers, int maxRenderbuffers, ref int numRenderbuffers)
            {
                fixed (int* renderbuffers_ptr = &renderbuffers)
                fixed (int* numRenderbuffers_ptr = &numRenderbuffers)
                {
                    ExtGetRenderbuffersQCOM(renderbuffers_ptr, maxRenderbuffers, numRenderbuffers_ptr);
                }
            }
            /// <inheritdoc cref="ExtGetShadersQCOM(int*, int, int*)"/>
            public static unsafe void ExtGetShadersQCOM(Span<int> shaders, Span<int> numShaders)
            {
                int maxShaders = (int)(shaders.Length);
                fixed (int* shaders_ptr = shaders)
                {
                    fixed (int* numShaders_ptr = numShaders)
                    {
                        ExtGetShadersQCOM(shaders_ptr, maxShaders, numShaders_ptr);
                    }
                }
            }
            /// <inheritdoc cref="ExtGetShadersQCOM(int*, int, int*)"/>
            public static unsafe void ExtGetShadersQCOM(int[] shaders, int[] numShaders)
            {
                int maxShaders = (int)(shaders.Length);
                fixed (int* shaders_ptr = shaders)
                {
                    fixed (int* numShaders_ptr = numShaders)
                    {
                        ExtGetShadersQCOM(shaders_ptr, maxShaders, numShaders_ptr);
                    }
                }
            }
            /// <inheritdoc cref="ExtGetShadersQCOM(int*, int, int*)"/>
            public static unsafe void ExtGetShadersQCOM(ref int shaders, int maxShaders, ref int numShaders)
            {
                fixed (int* shaders_ptr = &shaders)
                fixed (int* numShaders_ptr = &numShaders)
                {
                    ExtGetShadersQCOM(shaders_ptr, maxShaders, numShaders_ptr);
                }
            }
            /// <inheritdoc cref="ExtGetTexLevelParameterivQCOM(int, All, int, All, int*)"/>
            public static unsafe void ExtGetTexLevelParameterivQCOM(int texture, All face, int level, All pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    ExtGetTexLevelParameterivQCOM(texture, face, level, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="ExtGetTexSubImageQCOM(All, int, int, int, int, int, int, int, PixelFormat, PixelType, void*)"/>
            public static unsafe void ExtGetTexSubImageQCOM(All target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr texels)
            {
                void* texels_vptr = (void*)texels;
                ExtGetTexSubImageQCOM(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, texels_vptr);
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
            public static unsafe void ExtGetTexturesQCOM(ref int textures, int maxTextures, ref int numTextures)
            {
                fixed (int* textures_ptr = &textures)
                fixed (int* numTextures_ptr = &numTextures)
                {
                    ExtGetTexturesQCOM(textures_ptr, maxTextures, numTextures_ptr);
                }
            }
            /// <inheritdoc cref="GetDriverControlsQCOM(int*, int, uint*)"/>
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
            /// <inheritdoc cref="GetDriverControlsQCOM(int*, int, uint*)"/>
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
            /// <inheritdoc cref="GetDriverControlsQCOM(int*, int, uint*)"/>
            public static unsafe void GetDriverControlsQCOM(ref int num, int size, ref uint driverControls)
            {
                fixed (int* num_ptr = &num)
                fixed (uint* driverControls_ptr = &driverControls)
                {
                    GetDriverControlsQCOM(num_ptr, size, driverControls_ptr);
                }
            }
            /// <inheritdoc cref="GetDriverControlsQCOM(int*, int, uint*)"/>
            public static unsafe uint GetDriverControlsQCOM(ref int num, int size)
            {
                uint driverControls_val;
                fixed (int* num_ptr = &num)
                {
                    uint* driverControls = &driverControls_val;
                    GetDriverControlsQCOM(num_ptr, size, driverControls);
                }
                return driverControls_val;
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
