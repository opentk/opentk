// This file is auto generated, do not edit.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using OpenTK.Mathematics;
using OpenTK.Graphics;

namespace OpenTK.Graphics.OpenGLES2
{
#pragma warning disable CS0419 // Ambiguous reference in cref attribute
    public static unsafe partial class GL
    {
        /// <inheritdoc cref="BindAttribLocation(int, uint, byte*)"/>
        public static unsafe void BindAttribLocation(int program, uint index, string name)
        {
            byte* name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(name);
            BindAttribLocation(program, index, name_ptr);
            Marshal.FreeCoTaskMem((IntPtr)name_ptr);
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
        /// <inheritdoc cref="DeleteFramebuffers(int, int*)"/>
        public static unsafe void DeleteFramebuffer(in int framebuffer)
        {
            int n = 1;
            fixed(int* framebuffers_handle = &framebuffer)
            {
                DeleteFramebuffers(n, framebuffers_handle);
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
        /// <inheritdoc cref="DeleteRenderbuffers(int, int*)"/>
        public static unsafe void DeleteRenderbuffer(in int renderbuffer)
        {
            int n = 1;
            fixed(int* renderbuffers_handle = &renderbuffer)
            {
                DeleteRenderbuffers(n, renderbuffers_handle);
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
        /// <inheritdoc cref="GenFramebuffers(int, int*)"/>
        public static unsafe int GenFramebuffer()
        {
            int framebuffer;
            int n = 1;
            Unsafe.SkipInit(out framebuffer);
            // FIXME: This could be a problem for the overloads that take an out parameter
            // as this parameter could *potentially* move while inside of this function
            // which would mean that the new value never gets written to the out parameter.
            // Making for a nasty bug.
            // The reason we don't use a fixed expression here is because of the "single out parameter to return value" overloading step
            // that will make it so this tries to fix a local variable which is not allowed in C# for some reason.
            // If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk
            // - 2021-05-18
            int* framebuffers_handle = (int*)Unsafe.AsPointer(ref framebuffer);
            GenFramebuffers(n, framebuffers_handle);
            return framebuffer;
        }
        /// <inheritdoc cref="GenFramebuffers(int, int*)"/>
        public static unsafe void GenFramebuffer(out int framebuffer)
        {
            int n = 1;
            Unsafe.SkipInit(out framebuffer);
            // FIXME: This could be a problem for the overloads that take an out parameter
            // as this parameter could *potentially* move while inside of this function
            // which would mean that the new value never gets written to the out parameter.
            // Making for a nasty bug.
            // The reason we don't use a fixed expression here is because of the "single out parameter to return value" overloading step
            // that will make it so this tries to fix a local variable which is not allowed in C# for some reason.
            // If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk
            // - 2021-05-18
            int* framebuffers_handle = (int*)Unsafe.AsPointer(ref framebuffer);
            GenFramebuffers(n, framebuffers_handle);
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
        /// <inheritdoc cref="GenRenderbuffers(int, int*)"/>
        public static unsafe int GenRenderbuffer()
        {
            int renderbuffer;
            int n = 1;
            Unsafe.SkipInit(out renderbuffer);
            // FIXME: This could be a problem for the overloads that take an out parameter
            // as this parameter could *potentially* move while inside of this function
            // which would mean that the new value never gets written to the out parameter.
            // Making for a nasty bug.
            // The reason we don't use a fixed expression here is because of the "single out parameter to return value" overloading step
            // that will make it so this tries to fix a local variable which is not allowed in C# for some reason.
            // If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk
            // - 2021-05-18
            int* renderbuffers_handle = (int*)Unsafe.AsPointer(ref renderbuffer);
            GenRenderbuffers(n, renderbuffers_handle);
            return renderbuffer;
        }
        /// <inheritdoc cref="GenRenderbuffers(int, int*)"/>
        public static unsafe void GenRenderbuffer(out int renderbuffer)
        {
            int n = 1;
            Unsafe.SkipInit(out renderbuffer);
            // FIXME: This could be a problem for the overloads that take an out parameter
            // as this parameter could *potentially* move while inside of this function
            // which would mean that the new value never gets written to the out parameter.
            // Making for a nasty bug.
            // The reason we don't use a fixed expression here is because of the "single out parameter to return value" overloading step
            // that will make it so this tries to fix a local variable which is not allowed in C# for some reason.
            // If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk
            // - 2021-05-18
            int* renderbuffers_handle = (int*)Unsafe.AsPointer(ref renderbuffer);
            GenRenderbuffers(n, renderbuffers_handle);
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
        /// <inheritdoc cref="GetActiveAttrib(int, uint, int, int*, int*, AttributeType*, byte*)"/>
        public static unsafe string GetActiveAttrib(int program, uint index, int bufSize, Span<int> length, Span<int> size, Span<AttributeType> type)
        {
            string name;
            fixed (int* length_ptr = length)
            {
                fixed (int* size_ptr = size)
                {
                    fixed (AttributeType* type_ptr = type)
                    {
                        var name_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                        GetActiveAttrib(program, index, bufSize, length_ptr, size_ptr, type_ptr, name_ptr);
                        name = Marshal.PtrToStringUTF8((IntPtr)name_ptr)!;
                        Marshal.FreeCoTaskMem((IntPtr)name_ptr);
                    }
                }
            }
            return name;
        }
        /// <inheritdoc cref="GetActiveAttrib(int, uint, int, int*, int*, AttributeType*, byte*)"/>
        public static unsafe void GetActiveAttrib(int program, uint index, int bufSize, Span<int> length, Span<int> size, Span<AttributeType> type, out string name)
        {
            fixed (int* length_ptr = length)
            {
                fixed (int* size_ptr = size)
                {
                    fixed (AttributeType* type_ptr = type)
                    {
                        var name_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                        GetActiveAttrib(program, index, bufSize, length_ptr, size_ptr, type_ptr, name_ptr);
                        name = Marshal.PtrToStringUTF8((IntPtr)name_ptr)!;
                        Marshal.FreeCoTaskMem((IntPtr)name_ptr);
                    }
                }
            }
        }
        /// <inheritdoc cref="GetActiveAttrib(int, uint, int, int*, int*, AttributeType*, byte*)"/>
        public static unsafe string GetActiveAttrib(int program, uint index, int bufSize, int[] length, int[] size, AttributeType[] type)
        {
            string name;
            fixed (int* length_ptr = length)
            {
                fixed (int* size_ptr = size)
                {
                    fixed (AttributeType* type_ptr = type)
                    {
                        var name_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                        GetActiveAttrib(program, index, bufSize, length_ptr, size_ptr, type_ptr, name_ptr);
                        name = Marshal.PtrToStringUTF8((IntPtr)name_ptr)!;
                        Marshal.FreeCoTaskMem((IntPtr)name_ptr);
                    }
                }
            }
            return name;
        }
        /// <inheritdoc cref="GetActiveAttrib(int, uint, int, int*, int*, AttributeType*, byte*)"/>
        public static unsafe void GetActiveAttrib(int program, uint index, int bufSize, int[] length, int[] size, AttributeType[] type, out string name)
        {
            fixed (int* length_ptr = length)
            {
                fixed (int* size_ptr = size)
                {
                    fixed (AttributeType* type_ptr = type)
                    {
                        var name_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                        GetActiveAttrib(program, index, bufSize, length_ptr, size_ptr, type_ptr, name_ptr);
                        name = Marshal.PtrToStringUTF8((IntPtr)name_ptr)!;
                        Marshal.FreeCoTaskMem((IntPtr)name_ptr);
                    }
                }
            }
        }
        /// <inheritdoc cref="GetActiveAttrib(int, uint, int, int*, int*, AttributeType*, byte*)"/>
        public static unsafe string GetActiveAttrib(int program, uint index, int bufSize, ref int length, ref int size, ref AttributeType type)
        {
            string name;
            fixed (int* length_ptr = &length)
            fixed (int* size_ptr = &size)
            fixed (AttributeType* type_ptr = &type)
            {
                var name_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetActiveAttrib(program, index, bufSize, length_ptr, size_ptr, type_ptr, name_ptr);
                name = Marshal.PtrToStringUTF8((IntPtr)name_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)name_ptr);
            }
            return name;
        }
        /// <inheritdoc cref="GetActiveAttrib(int, uint, int, int*, int*, AttributeType*, byte*)"/>
        public static unsafe void GetActiveAttrib(int program, uint index, int bufSize, ref int length, ref int size, ref AttributeType type, out string name)
        {
            fixed (int* length_ptr = &length)
            fixed (int* size_ptr = &size)
            fixed (AttributeType* type_ptr = &type)
            {
                var name_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetActiveAttrib(program, index, bufSize, length_ptr, size_ptr, type_ptr, name_ptr);
                name = Marshal.PtrToStringUTF8((IntPtr)name_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)name_ptr);
            }
        }
        /// <inheritdoc cref="GetActiveUniform(int, uint, int, int*, int*, UniformType*, byte*)"/>
        public static unsafe string GetActiveUniform(int program, uint index, int bufSize, Span<int> length, Span<int> size, Span<UniformType> type)
        {
            string name;
            fixed (int* length_ptr = length)
            {
                fixed (int* size_ptr = size)
                {
                    fixed (UniformType* type_ptr = type)
                    {
                        var name_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                        GetActiveUniform(program, index, bufSize, length_ptr, size_ptr, type_ptr, name_ptr);
                        name = Marshal.PtrToStringUTF8((IntPtr)name_ptr)!;
                        Marshal.FreeCoTaskMem((IntPtr)name_ptr);
                    }
                }
            }
            return name;
        }
        /// <inheritdoc cref="GetActiveUniform(int, uint, int, int*, int*, UniformType*, byte*)"/>
        public static unsafe void GetActiveUniform(int program, uint index, int bufSize, Span<int> length, Span<int> size, Span<UniformType> type, out string name)
        {
            fixed (int* length_ptr = length)
            {
                fixed (int* size_ptr = size)
                {
                    fixed (UniformType* type_ptr = type)
                    {
                        var name_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                        GetActiveUniform(program, index, bufSize, length_ptr, size_ptr, type_ptr, name_ptr);
                        name = Marshal.PtrToStringUTF8((IntPtr)name_ptr)!;
                        Marshal.FreeCoTaskMem((IntPtr)name_ptr);
                    }
                }
            }
        }
        /// <inheritdoc cref="GetActiveUniform(int, uint, int, int*, int*, UniformType*, byte*)"/>
        public static unsafe string GetActiveUniform(int program, uint index, int bufSize, int[] length, int[] size, UniformType[] type)
        {
            string name;
            fixed (int* length_ptr = length)
            {
                fixed (int* size_ptr = size)
                {
                    fixed (UniformType* type_ptr = type)
                    {
                        var name_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                        GetActiveUniform(program, index, bufSize, length_ptr, size_ptr, type_ptr, name_ptr);
                        name = Marshal.PtrToStringUTF8((IntPtr)name_ptr)!;
                        Marshal.FreeCoTaskMem((IntPtr)name_ptr);
                    }
                }
            }
            return name;
        }
        /// <inheritdoc cref="GetActiveUniform(int, uint, int, int*, int*, UniformType*, byte*)"/>
        public static unsafe void GetActiveUniform(int program, uint index, int bufSize, int[] length, int[] size, UniformType[] type, out string name)
        {
            fixed (int* length_ptr = length)
            {
                fixed (int* size_ptr = size)
                {
                    fixed (UniformType* type_ptr = type)
                    {
                        var name_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                        GetActiveUniform(program, index, bufSize, length_ptr, size_ptr, type_ptr, name_ptr);
                        name = Marshal.PtrToStringUTF8((IntPtr)name_ptr)!;
                        Marshal.FreeCoTaskMem((IntPtr)name_ptr);
                    }
                }
            }
        }
        /// <inheritdoc cref="GetActiveUniform(int, uint, int, int*, int*, UniformType*, byte*)"/>
        public static unsafe string GetActiveUniform(int program, uint index, int bufSize, ref int length, ref int size, ref UniformType type)
        {
            string name;
            fixed (int* length_ptr = &length)
            fixed (int* size_ptr = &size)
            fixed (UniformType* type_ptr = &type)
            {
                var name_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetActiveUniform(program, index, bufSize, length_ptr, size_ptr, type_ptr, name_ptr);
                name = Marshal.PtrToStringUTF8((IntPtr)name_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)name_ptr);
            }
            return name;
        }
        /// <inheritdoc cref="GetActiveUniform(int, uint, int, int*, int*, UniformType*, byte*)"/>
        public static unsafe void GetActiveUniform(int program, uint index, int bufSize, ref int length, ref int size, ref UniformType type, out string name)
        {
            fixed (int* length_ptr = &length)
            fixed (int* size_ptr = &size)
            fixed (UniformType* type_ptr = &type)
            {
                var name_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetActiveUniform(program, index, bufSize, length_ptr, size_ptr, type_ptr, name_ptr);
                name = Marshal.PtrToStringUTF8((IntPtr)name_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)name_ptr);
            }
        }
        /// <inheritdoc cref="GetAttachedShaders(int, int, int*, int*)"/>
        public static unsafe void GetAttachedShaders(int program, Span<int> count, Span<int> shaders)
        {
            fixed (int* count_ptr = count)
            {
                int maxCount = (int)(shaders.Length);
                fixed (int* shaders_ptr = shaders)
                {
                    GetAttachedShaders(program, maxCount, count_ptr, shaders_ptr);
                }
            }
        }
        /// <inheritdoc cref="GetAttachedShaders(int, int, int*, int*)"/>
        public static unsafe void GetAttachedShaders(int program, int[] count, int[] shaders)
        {
            fixed (int* count_ptr = count)
            {
                int maxCount = (int)(shaders.Length);
                fixed (int* shaders_ptr = shaders)
                {
                    GetAttachedShaders(program, maxCount, count_ptr, shaders_ptr);
                }
            }
        }
        /// <inheritdoc cref="GetAttachedShaders(int, int, int*, int*)"/>
        public static unsafe void GetAttachedShaders(int program, int maxCount, ref int count, ref int shaders)
        {
            fixed (int* count_ptr = &count)
            fixed (int* shaders_ptr = &shaders)
            {
                GetAttachedShaders(program, maxCount, count_ptr, shaders_ptr);
            }
        }
        /// <inheritdoc cref="GetAttribLocation(int, byte*)"/>
        public static unsafe int GetAttribLocation(int program, string name)
        {
            int returnValue;
            byte* name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(name);
            returnValue = GetAttribLocation(program, name_ptr);
            Marshal.FreeCoTaskMem((IntPtr)name_ptr);
            return returnValue;
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
        /// <inheritdoc cref="GetFramebufferAttachmentParameteriv(FramebufferTarget, FramebufferAttachment, FramebufferAttachmentParameterName, int*)"/>
        public static unsafe void GetFramebufferAttachmentParameteri(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetFramebufferAttachmentParameteriv(target, attachment, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetFramebufferAttachmentParameteriv(FramebufferTarget, FramebufferAttachment, FramebufferAttachmentParameterName, int*)"/>
        public static unsafe void GetFramebufferAttachmentParameteri(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetFramebufferAttachmentParameteriv(target, attachment, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetFramebufferAttachmentParameteriv(FramebufferTarget, FramebufferAttachment, FramebufferAttachmentParameterName, int*)"/>
        public static unsafe void GetFramebufferAttachmentParameteri(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetFramebufferAttachmentParameteriv(target, attachment, pname, parameters_ptr);
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
        /// <inheritdoc cref="GetProgramiv(int, ProgramPropertyARB, int*)"/>
        public static unsafe void GetProgrami(int program, ProgramPropertyARB pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetProgramiv(program, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramiv(int, ProgramPropertyARB, int*)"/>
        public static unsafe void GetProgrami(int program, ProgramPropertyARB pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetProgramiv(program, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramiv(int, ProgramPropertyARB, int*)"/>
        public static unsafe void GetProgrami(int program, ProgramPropertyARB pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetProgramiv(program, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramInfoLog(int, int, int*, byte*)"/>
        public static unsafe string GetProgramInfoLog(int program, int bufSize, Span<int> length)
        {
            string infoLog;
            fixed (int* length_ptr = length)
            {
                var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetProgramInfoLog(program, bufSize, length_ptr, infoLog_ptr);
                infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
            }
            return infoLog;
        }
        /// <inheritdoc cref="GetProgramInfoLog(int, int, int*, byte*)"/>
        public static unsafe void GetProgramInfoLog(int program, int bufSize, Span<int> length, out string infoLog)
        {
            fixed (int* length_ptr = length)
            {
                var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetProgramInfoLog(program, bufSize, length_ptr, infoLog_ptr);
                infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramInfoLog(int, int, int*, byte*)"/>
        public static unsafe string GetProgramInfoLog(int program, int bufSize, int[] length)
        {
            string infoLog;
            fixed (int* length_ptr = length)
            {
                var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetProgramInfoLog(program, bufSize, length_ptr, infoLog_ptr);
                infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
            }
            return infoLog;
        }
        /// <inheritdoc cref="GetProgramInfoLog(int, int, int*, byte*)"/>
        public static unsafe void GetProgramInfoLog(int program, int bufSize, int[] length, out string infoLog)
        {
            fixed (int* length_ptr = length)
            {
                var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetProgramInfoLog(program, bufSize, length_ptr, infoLog_ptr);
                infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramInfoLog(int, int, int*, byte*)"/>
        public static unsafe string GetProgramInfoLog(int program, int bufSize, ref int length)
        {
            string infoLog;
            fixed (int* length_ptr = &length)
            {
                var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetProgramInfoLog(program, bufSize, length_ptr, infoLog_ptr);
                infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
            }
            return infoLog;
        }
        /// <inheritdoc cref="GetProgramInfoLog(int, int, int*, byte*)"/>
        public static unsafe void GetProgramInfoLog(int program, int bufSize, ref int length, out string infoLog)
        {
            fixed (int* length_ptr = &length)
            {
                var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetProgramInfoLog(program, bufSize, length_ptr, infoLog_ptr);
                infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
            }
        }
        /// <inheritdoc cref="GetRenderbufferParameteriv(RenderbufferTarget, RenderbufferParameterName, int*)"/>
        public static unsafe void GetRenderbufferParameteri(RenderbufferTarget target, RenderbufferParameterName pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetRenderbufferParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetRenderbufferParameteriv(RenderbufferTarget, RenderbufferParameterName, int*)"/>
        public static unsafe void GetRenderbufferParameteri(RenderbufferTarget target, RenderbufferParameterName pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetRenderbufferParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetRenderbufferParameteriv(RenderbufferTarget, RenderbufferParameterName, int*)"/>
        public static unsafe void GetRenderbufferParameteri(RenderbufferTarget target, RenderbufferParameterName pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetRenderbufferParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetShaderiv(int, ShaderParameterName, int*)"/>
        public static unsafe void GetShaderi(int shader, ShaderParameterName pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetShaderiv(shader, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetShaderiv(int, ShaderParameterName, int*)"/>
        public static unsafe void GetShaderi(int shader, ShaderParameterName pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetShaderiv(shader, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetShaderiv(int, ShaderParameterName, int*)"/>
        public static unsafe void GetShaderi(int shader, ShaderParameterName pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetShaderiv(shader, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetShaderInfoLog(int, int, int*, byte*)"/>
        public static unsafe string GetShaderInfoLog(int shader, int bufSize, Span<int> length)
        {
            string infoLog;
            fixed (int* length_ptr = length)
            {
                var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetShaderInfoLog(shader, bufSize, length_ptr, infoLog_ptr);
                infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
            }
            return infoLog;
        }
        /// <inheritdoc cref="GetShaderInfoLog(int, int, int*, byte*)"/>
        public static unsafe void GetShaderInfoLog(int shader, int bufSize, Span<int> length, out string infoLog)
        {
            fixed (int* length_ptr = length)
            {
                var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetShaderInfoLog(shader, bufSize, length_ptr, infoLog_ptr);
                infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
            }
        }
        /// <inheritdoc cref="GetShaderInfoLog(int, int, int*, byte*)"/>
        public static unsafe string GetShaderInfoLog(int shader, int bufSize, int[] length)
        {
            string infoLog;
            fixed (int* length_ptr = length)
            {
                var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetShaderInfoLog(shader, bufSize, length_ptr, infoLog_ptr);
                infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
            }
            return infoLog;
        }
        /// <inheritdoc cref="GetShaderInfoLog(int, int, int*, byte*)"/>
        public static unsafe void GetShaderInfoLog(int shader, int bufSize, int[] length, out string infoLog)
        {
            fixed (int* length_ptr = length)
            {
                var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetShaderInfoLog(shader, bufSize, length_ptr, infoLog_ptr);
                infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
            }
        }
        /// <inheritdoc cref="GetShaderInfoLog(int, int, int*, byte*)"/>
        public static unsafe string GetShaderInfoLog(int shader, int bufSize, ref int length)
        {
            string infoLog;
            fixed (int* length_ptr = &length)
            {
                var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetShaderInfoLog(shader, bufSize, length_ptr, infoLog_ptr);
                infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
            }
            return infoLog;
        }
        /// <inheritdoc cref="GetShaderInfoLog(int, int, int*, byte*)"/>
        public static unsafe void GetShaderInfoLog(int shader, int bufSize, ref int length, out string infoLog)
        {
            fixed (int* length_ptr = &length)
            {
                var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetShaderInfoLog(shader, bufSize, length_ptr, infoLog_ptr);
                infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
            }
        }
        /// <inheritdoc cref="GetShaderPrecisionFormat(ShaderType, PrecisionType, int*, int*)"/>
        public static unsafe void GetShaderPrecisionFormat(ShaderType shadertype, PrecisionType precisiontype, Span<int> range, Span<int> precision)
        {
            fixed (int* range_ptr = range)
            {
                fixed (int* precision_ptr = precision)
                {
                    GetShaderPrecisionFormat(shadertype, precisiontype, range_ptr, precision_ptr);
                }
            }
        }
        /// <inheritdoc cref="GetShaderPrecisionFormat(ShaderType, PrecisionType, int*, int*)"/>
        public static unsafe void GetShaderPrecisionFormat(ShaderType shadertype, PrecisionType precisiontype, int[] range, int[] precision)
        {
            fixed (int* range_ptr = range)
            {
                fixed (int* precision_ptr = precision)
                {
                    GetShaderPrecisionFormat(shadertype, precisiontype, range_ptr, precision_ptr);
                }
            }
        }
        /// <inheritdoc cref="GetShaderPrecisionFormat(ShaderType, PrecisionType, int*, int*)"/>
        public static unsafe void GetShaderPrecisionFormat(ShaderType shadertype, PrecisionType precisiontype, ref int range, ref int precision)
        {
            fixed (int* range_ptr = &range)
            fixed (int* precision_ptr = &precision)
            {
                GetShaderPrecisionFormat(shadertype, precisiontype, range_ptr, precision_ptr);
            }
        }
        /// <inheritdoc cref="GetShaderSource(int, int, int*, byte*)"/>
        public static unsafe string GetShaderSource(int shader, int bufSize, Span<int> length)
        {
            string source;
            fixed (int* length_ptr = length)
            {
                var source_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetShaderSource(shader, bufSize, length_ptr, source_ptr);
                source = Marshal.PtrToStringUTF8((IntPtr)source_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)source_ptr);
            }
            return source;
        }
        /// <inheritdoc cref="GetShaderSource(int, int, int*, byte*)"/>
        public static unsafe void GetShaderSource(int shader, int bufSize, Span<int> length, out string source)
        {
            fixed (int* length_ptr = length)
            {
                var source_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetShaderSource(shader, bufSize, length_ptr, source_ptr);
                source = Marshal.PtrToStringUTF8((IntPtr)source_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)source_ptr);
            }
        }
        /// <inheritdoc cref="GetShaderSource(int, int, int*, byte*)"/>
        public static unsafe string GetShaderSource(int shader, int bufSize, int[] length)
        {
            string source;
            fixed (int* length_ptr = length)
            {
                var source_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetShaderSource(shader, bufSize, length_ptr, source_ptr);
                source = Marshal.PtrToStringUTF8((IntPtr)source_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)source_ptr);
            }
            return source;
        }
        /// <inheritdoc cref="GetShaderSource(int, int, int*, byte*)"/>
        public static unsafe void GetShaderSource(int shader, int bufSize, int[] length, out string source)
        {
            fixed (int* length_ptr = length)
            {
                var source_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetShaderSource(shader, bufSize, length_ptr, source_ptr);
                source = Marshal.PtrToStringUTF8((IntPtr)source_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)source_ptr);
            }
        }
        /// <inheritdoc cref="GetShaderSource(int, int, int*, byte*)"/>
        public static unsafe string GetShaderSource(int shader, int bufSize, ref int length)
        {
            string source;
            fixed (int* length_ptr = &length)
            {
                var source_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetShaderSource(shader, bufSize, length_ptr, source_ptr);
                source = Marshal.PtrToStringUTF8((IntPtr)source_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)source_ptr);
            }
            return source;
        }
        /// <inheritdoc cref="GetShaderSource(int, int, int*, byte*)"/>
        public static unsafe void GetShaderSource(int shader, int bufSize, ref int length, out string source)
        {
            fixed (int* length_ptr = &length)
            {
                var source_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetShaderSource(shader, bufSize, length_ptr, source_ptr);
                source = Marshal.PtrToStringUTF8((IntPtr)source_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)source_ptr);
            }
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
        /// <inheritdoc cref="GetUniformfv(int, int, float*)"/>
        public static unsafe void GetUniformf(int program, int location, Span<float> parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetUniformfv(program, location, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetUniformfv(int, int, float*)"/>
        public static unsafe void GetUniformf(int program, int location, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetUniformfv(program, location, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetUniformfv(int, int, float*)"/>
        public static unsafe void GetUniformf(int program, int location, ref float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                GetUniformfv(program, location, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetUniformiv(int, int, int*)"/>
        public static unsafe void GetUniformi(int program, int location, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetUniformiv(program, location, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetUniformiv(int, int, int*)"/>
        public static unsafe void GetUniformi(int program, int location, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetUniformiv(program, location, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetUniformiv(int, int, int*)"/>
        public static unsafe void GetUniformi(int program, int location, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetUniformiv(program, location, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetUniformLocation(int, byte*)"/>
        public static unsafe int GetUniformLocation(int program, string name)
        {
            int returnValue;
            byte* name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(name);
            returnValue = GetUniformLocation(program, name_ptr);
            Marshal.FreeCoTaskMem((IntPtr)name_ptr);
            return returnValue;
        }
        /// <inheritdoc cref="GetVertexAttribfv(uint, VertexAttribPropertyARB, float*)"/>
        public static unsafe void GetVertexAttribf(uint index, VertexAttribPropertyARB pname, Span<float> parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetVertexAttribfv(index, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetVertexAttribfv(uint, VertexAttribPropertyARB, float*)"/>
        public static unsafe void GetVertexAttribf(uint index, VertexAttribPropertyARB pname, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetVertexAttribfv(index, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetVertexAttribfv(uint, VertexAttribPropertyARB, float*)"/>
        public static unsafe void GetVertexAttribf(uint index, VertexAttribPropertyARB pname, ref float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                GetVertexAttribfv(index, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetVertexAttribiv(uint, VertexAttribPropertyARB, int*)"/>
        public static unsafe void GetVertexAttribi(uint index, VertexAttribPropertyARB pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetVertexAttribiv(index, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetVertexAttribiv(uint, VertexAttribPropertyARB, int*)"/>
        public static unsafe void GetVertexAttribi(uint index, VertexAttribPropertyARB pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetVertexAttribiv(index, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetVertexAttribiv(uint, VertexAttribPropertyARB, int*)"/>
        public static unsafe void GetVertexAttribi(uint index, VertexAttribPropertyARB pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetVertexAttribiv(index, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetVertexAttribPointerv(uint, VertexAttribPointerPropertyARB, void**)"/>
        public static unsafe void GetVertexAttribPointer(uint index, VertexAttribPointerPropertyARB pname, void** pointer)
        {
            GetVertexAttribPointerv(index, pname, pointer);
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
        /// <inheritdoc cref="ShaderBinary(int, int*, ShaderBinaryFormat, void*, int)"/>
        public static unsafe void ShaderBinary(ReadOnlySpan<int> shaders, ShaderBinaryFormat binaryFormat, IntPtr binary, int length)
        {
            int count = (int)(shaders.Length);
            fixed (int* shaders_ptr = shaders)
            {
                void* binary_vptr = (void*)binary;
                ShaderBinary(count, shaders_ptr, binaryFormat, binary_vptr, length);
            }
        }
        /// <inheritdoc cref="ShaderBinary(int, int*, ShaderBinaryFormat, void*, int)"/>
        public static unsafe void ShaderBinary(int[] shaders, ShaderBinaryFormat binaryFormat, IntPtr binary, int length)
        {
            int count = (int)(shaders.Length);
            fixed (int* shaders_ptr = shaders)
            {
                void* binary_vptr = (void*)binary;
                ShaderBinary(count, shaders_ptr, binaryFormat, binary_vptr, length);
            }
        }
        /// <inheritdoc cref="ShaderBinary(int, int*, ShaderBinaryFormat, void*, int)"/>
        public static unsafe void ShaderBinary(int count, in int shaders, ShaderBinaryFormat binaryFormat, IntPtr binary, int length)
        {
            fixed (int* shaders_ptr = &shaders)
            {
                void* binary_vptr = (void*)binary;
                ShaderBinary(count, shaders_ptr, binaryFormat, binary_vptr, length);
            }
        }
        /// <inheritdoc cref="ShaderBinary(int, int*, ShaderBinaryFormat, void*, int)"/>
        public static unsafe void ShaderBinary<T1>(ReadOnlySpan<int> shaders, ShaderBinaryFormat binaryFormat, ReadOnlySpan<T1> binary)
            where T1 : unmanaged
        {
            int count = (int)(shaders.Length);
            fixed (int* shaders_ptr = shaders)
            {
                int length = (int)(binary.Length * sizeof(T1));
                fixed (void* binary_ptr = binary)
                {
                    ShaderBinary(count, shaders_ptr, binaryFormat, binary_ptr, length);
                }
            }
        }
        /// <inheritdoc cref="ShaderBinary(int, int*, ShaderBinaryFormat, void*, int)"/>
        public static unsafe void ShaderBinary<T1>(int[] shaders, ShaderBinaryFormat binaryFormat, T1[] binary)
            where T1 : unmanaged
        {
            int count = (int)(shaders.Length);
            fixed (int* shaders_ptr = shaders)
            {
                int length = (int)(binary.Length * sizeof(T1));
                fixed (void* binary_ptr = binary)
                {
                    ShaderBinary(count, shaders_ptr, binaryFormat, binary_ptr, length);
                }
            }
        }
        /// <inheritdoc cref="ShaderBinary(int, int*, ShaderBinaryFormat, void*, int)"/>
        public static unsafe void ShaderBinary<T1>(int count, in int shaders, ShaderBinaryFormat binaryFormat, in T1 binary, int length)
            where T1 : unmanaged
        {
            fixed (int* shaders_ptr = &shaders)
            fixed (void* binary_ptr = &binary)
            {
                ShaderBinary(count, shaders_ptr, binaryFormat, binary_ptr, length);
            }
        }
        /// <inheritdoc cref="ShaderSource(int, int, byte**, int*)"/>
        public static unsafe void ShaderSource(int shader, int count, byte** str, ReadOnlySpan<int> length)
        {
            fixed (int* length_ptr = length)
            {
                ShaderSource(shader, count, str, length_ptr);
            }
        }
        /// <inheritdoc cref="ShaderSource(int, int, byte**, int*)"/>
        public static unsafe void ShaderSource(int shader, int count, byte** str, int[] length)
        {
            fixed (int* length_ptr = length)
            {
                ShaderSource(shader, count, str, length_ptr);
            }
        }
        /// <inheritdoc cref="ShaderSource(int, int, byte**, int*)"/>
        public static unsafe void ShaderSource(int shader, int count, byte** str, in int length)
        {
            fixed (int* length_ptr = &length)
            {
                ShaderSource(shader, count, str, length_ptr);
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
        /// <inheritdoc cref="Uniform1fv(int, int, float*)"/>
        public static unsafe void Uniform1f(int location, int count, in float value)
        {
            fixed (float* tmp_value = &value)
            {
                float* value_ptr = (float*)tmp_value;
                Uniform1fv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform1fv(int, int, float*)"/>
        public static unsafe void Uniform1f(int location, int count, ReadOnlySpan<float> value)
        {
            fixed (float* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                Uniform1fv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform1fv(int, int, float*)"/>
        public static unsafe void Uniform1f(int location, int count, float[] value)
        {
            fixed (float* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                Uniform1fv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform1iv(int, int, int*)"/>
        public static unsafe void Uniform1i(int location, int count, in int value)
        {
            fixed (int* tmp_value = &value)
            {
                int* value_ptr = (int*)tmp_value;
                Uniform1iv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform1iv(int, int, int*)"/>
        public static unsafe void Uniform1i(int location, int count, ReadOnlySpan<int> value)
        {
            fixed (int* tmp_value = value)
            {
                int* value_ptr = (int*)tmp_value;
                Uniform1iv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform1iv(int, int, int*)"/>
        public static unsafe void Uniform1i(int location, int count, int[] value)
        {
            fixed (int* tmp_value = value)
            {
                int* value_ptr = (int*)tmp_value;
                Uniform1iv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform2fv(int, int, float*)"/>
        public static unsafe void Uniform2f(int location, int count, in Vector2 value)
        {
            fixed (Vector2* tmp_value = &value)
            {
                float* value_ptr = (float*)tmp_value;
                Uniform2fv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform2fv(int, int, float*)"/>
        public static unsafe void Uniform2f(int location, int count, ReadOnlySpan<Vector2> value)
        {
            fixed (Vector2* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                Uniform2fv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform2fv(int, int, float*)"/>
        public static unsafe void Uniform2f(int location, int count, Vector2[] value)
        {
            fixed (Vector2* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                Uniform2fv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform2fv(int, int, float*)"/>
        public static unsafe void Uniform2f(int location, int count, in System.Numerics.Vector2 value)
        {
            fixed (System.Numerics.Vector2* tmp_value = &value)
            {
                float* value_ptr = (float*)tmp_value;
                Uniform2fv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform2fv(int, int, float*)"/>
        public static unsafe void Uniform2f(int location, int count, ReadOnlySpan<System.Numerics.Vector2> value)
        {
            fixed (System.Numerics.Vector2* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                Uniform2fv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform2fv(int, int, float*)"/>
        public static unsafe void Uniform2f(int location, int count, System.Numerics.Vector2[] value)
        {
            fixed (System.Numerics.Vector2* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                Uniform2fv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform2iv(int, int, int*)"/>
        public static unsafe void Uniform2i(int location, int count, in Vector2i value)
        {
            fixed (Vector2i* tmp_value = &value)
            {
                int* value_ptr = (int*)tmp_value;
                Uniform2iv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform2iv(int, int, int*)"/>
        public static unsafe void Uniform2i(int location, int count, ReadOnlySpan<Vector2i> value)
        {
            fixed (Vector2i* tmp_value = value)
            {
                int* value_ptr = (int*)tmp_value;
                Uniform2iv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform2iv(int, int, int*)"/>
        public static unsafe void Uniform2i(int location, int count, Vector2i[] value)
        {
            fixed (Vector2i* tmp_value = value)
            {
                int* value_ptr = (int*)tmp_value;
                Uniform2iv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform3fv(int, int, float*)"/>
        public static unsafe void Uniform3f(int location, int count, in Vector3 value)
        {
            fixed (Vector3* tmp_value = &value)
            {
                float* value_ptr = (float*)tmp_value;
                Uniform3fv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform3fv(int, int, float*)"/>
        public static unsafe void Uniform3f(int location, int count, ReadOnlySpan<Vector3> value)
        {
            fixed (Vector3* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                Uniform3fv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform3fv(int, int, float*)"/>
        public static unsafe void Uniform3f(int location, int count, Vector3[] value)
        {
            fixed (Vector3* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                Uniform3fv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform3fv(int, int, float*)"/>
        public static unsafe void Uniform3f(int location, int count, in System.Numerics.Vector3 value)
        {
            fixed (System.Numerics.Vector3* tmp_value = &value)
            {
                float* value_ptr = (float*)tmp_value;
                Uniform3fv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform3fv(int, int, float*)"/>
        public static unsafe void Uniform3f(int location, int count, ReadOnlySpan<System.Numerics.Vector3> value)
        {
            fixed (System.Numerics.Vector3* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                Uniform3fv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform3fv(int, int, float*)"/>
        public static unsafe void Uniform3f(int location, int count, System.Numerics.Vector3[] value)
        {
            fixed (System.Numerics.Vector3* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                Uniform3fv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform3iv(int, int, int*)"/>
        public static unsafe void Uniform3i(int location, int count, in Vector3i value)
        {
            fixed (Vector3i* tmp_value = &value)
            {
                int* value_ptr = (int*)tmp_value;
                Uniform3iv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform3iv(int, int, int*)"/>
        public static unsafe void Uniform3i(int location, int count, ReadOnlySpan<Vector3i> value)
        {
            fixed (Vector3i* tmp_value = value)
            {
                int* value_ptr = (int*)tmp_value;
                Uniform3iv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform3iv(int, int, int*)"/>
        public static unsafe void Uniform3i(int location, int count, Vector3i[] value)
        {
            fixed (Vector3i* tmp_value = value)
            {
                int* value_ptr = (int*)tmp_value;
                Uniform3iv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform4fv(int, int, float*)"/>
        public static unsafe void Uniform4f(int location, int count, in Vector4 value)
        {
            fixed (Vector4* tmp_value = &value)
            {
                float* value_ptr = (float*)tmp_value;
                Uniform4fv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform4fv(int, int, float*)"/>
        public static unsafe void Uniform4f(int location, int count, ReadOnlySpan<Vector4> value)
        {
            fixed (Vector4* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                Uniform4fv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform4fv(int, int, float*)"/>
        public static unsafe void Uniform4f(int location, int count, Vector4[] value)
        {
            fixed (Vector4* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                Uniform4fv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform4fv(int, int, float*)"/>
        public static unsafe void Uniform4f(int location, int count, in System.Numerics.Vector4 value)
        {
            fixed (System.Numerics.Vector4* tmp_value = &value)
            {
                float* value_ptr = (float*)tmp_value;
                Uniform4fv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform4fv(int, int, float*)"/>
        public static unsafe void Uniform4f(int location, int count, ReadOnlySpan<System.Numerics.Vector4> value)
        {
            fixed (System.Numerics.Vector4* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                Uniform4fv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform4fv(int, int, float*)"/>
        public static unsafe void Uniform4f(int location, int count, System.Numerics.Vector4[] value)
        {
            fixed (System.Numerics.Vector4* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                Uniform4fv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform4iv(int, int, int*)"/>
        public static unsafe void Uniform4i(int location, int count, in Vector4i value)
        {
            fixed (Vector4i* tmp_value = &value)
            {
                int* value_ptr = (int*)tmp_value;
                Uniform4iv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform4iv(int, int, int*)"/>
        public static unsafe void Uniform4i(int location, int count, ReadOnlySpan<Vector4i> value)
        {
            fixed (Vector4i* tmp_value = value)
            {
                int* value_ptr = (int*)tmp_value;
                Uniform4iv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform4iv(int, int, int*)"/>
        public static unsafe void Uniform4i(int location, int count, Vector4i[] value)
        {
            fixed (Vector4i* tmp_value = value)
            {
                int* value_ptr = (int*)tmp_value;
                Uniform4iv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix2fv(int, int, bool, float*)"/>
        public static unsafe void UniformMatrix2f(int location, int count, bool transpose, in Matrix2 value)
        {
            fixed (Matrix2* tmp_value = &value)
            {
                float* value_ptr = (float*)tmp_value;
                UniformMatrix2fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix2fv(int, int, bool, float*)"/>
        public static unsafe void UniformMatrix2f(int location, int count, bool transpose, ReadOnlySpan<Matrix2> value)
        {
            fixed (Matrix2* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                UniformMatrix2fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix2fv(int, int, bool, float*)"/>
        public static unsafe void UniformMatrix2f(int location, int count, bool transpose, Matrix2[] value)
        {
            fixed (Matrix2* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                UniformMatrix2fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix3fv(int, int, bool, float*)"/>
        public static unsafe void UniformMatrix3f(int location, int count, bool transpose, in Matrix3 value)
        {
            fixed (Matrix3* tmp_value = &value)
            {
                float* value_ptr = (float*)tmp_value;
                UniformMatrix3fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix3fv(int, int, bool, float*)"/>
        public static unsafe void UniformMatrix3f(int location, int count, bool transpose, ReadOnlySpan<Matrix3> value)
        {
            fixed (Matrix3* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                UniformMatrix3fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix3fv(int, int, bool, float*)"/>
        public static unsafe void UniformMatrix3f(int location, int count, bool transpose, Matrix3[] value)
        {
            fixed (Matrix3* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                UniformMatrix3fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix4fv(int, int, bool, float*)"/>
        public static unsafe void UniformMatrix4f(int location, int count, bool transpose, in Matrix4 value)
        {
            fixed (Matrix4* tmp_value = &value)
            {
                float* value_ptr = (float*)tmp_value;
                UniformMatrix4fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix4fv(int, int, bool, float*)"/>
        public static unsafe void UniformMatrix4f(int location, int count, bool transpose, ReadOnlySpan<Matrix4> value)
        {
            fixed (Matrix4* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                UniformMatrix4fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix4fv(int, int, bool, float*)"/>
        public static unsafe void UniformMatrix4f(int location, int count, bool transpose, Matrix4[] value)
        {
            fixed (Matrix4* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                UniformMatrix4fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix4fv(int, int, bool, float*)"/>
        public static unsafe void UniformMatrix4f(int location, int count, bool transpose, in System.Numerics.Matrix4x4 value)
        {
            fixed (System.Numerics.Matrix4x4* tmp_value = &value)
            {
                float* value_ptr = (float*)tmp_value;
                UniformMatrix4fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix4fv(int, int, bool, float*)"/>
        public static unsafe void UniformMatrix4f(int location, int count, bool transpose, ReadOnlySpan<System.Numerics.Matrix4x4> value)
        {
            fixed (System.Numerics.Matrix4x4* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                UniformMatrix4fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix4fv(int, int, bool, float*)"/>
        public static unsafe void UniformMatrix4f(int location, int count, bool transpose, System.Numerics.Matrix4x4[] value)
        {
            fixed (System.Numerics.Matrix4x4* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                UniformMatrix4fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="VertexAttrib1fv(uint, float*)"/>
        public static unsafe void VertexAttrib1f(uint index, in float v)
        {
            fixed (float* tmp_v = &v)
            {
                float* v_ptr = (float*)tmp_v;
                VertexAttrib1fv(index, v_ptr);
            }
        }
        /// <inheritdoc cref="VertexAttrib2fv(uint, float*)"/>
        public static unsafe void VertexAttrib2f(uint index, in Vector2 v)
        {
            fixed (Vector2* tmp_v = &v)
            {
                float* v_ptr = (float*)tmp_v;
                VertexAttrib2fv(index, v_ptr);
            }
        }
        /// <inheritdoc cref="VertexAttrib2fv(uint, float*)"/>
        public static unsafe void VertexAttrib2f(uint index, in System.Numerics.Vector2 v)
        {
            fixed (System.Numerics.Vector2* tmp_v = &v)
            {
                float* v_ptr = (float*)tmp_v;
                VertexAttrib2fv(index, v_ptr);
            }
        }
        /// <inheritdoc cref="VertexAttrib2fv(uint, float*)"/>
        public static unsafe void VertexAttrib2f(uint index, ReadOnlySpan<System.Numerics.Vector2> v)
        {
            fixed (System.Numerics.Vector2* tmp_v = v)
            {
                float* v_ptr = (float*)tmp_v;
                VertexAttrib2fv(index, v_ptr);
            }
        }
        /// <inheritdoc cref="VertexAttrib2fv(uint, float*)"/>
        public static unsafe void VertexAttrib2f(uint index, System.Numerics.Vector2[] v)
        {
            fixed (System.Numerics.Vector2* tmp_v = v)
            {
                float* v_ptr = (float*)tmp_v;
                VertexAttrib2fv(index, v_ptr);
            }
        }
        /// <inheritdoc cref="VertexAttrib3fv(uint, float*)"/>
        public static unsafe void VertexAttrib3f(uint index, in Vector3 v)
        {
            fixed (Vector3* tmp_v = &v)
            {
                float* v_ptr = (float*)tmp_v;
                VertexAttrib3fv(index, v_ptr);
            }
        }
        /// <inheritdoc cref="VertexAttrib3fv(uint, float*)"/>
        public static unsafe void VertexAttrib3f(uint index, in System.Numerics.Vector3 v)
        {
            fixed (System.Numerics.Vector3* tmp_v = &v)
            {
                float* v_ptr = (float*)tmp_v;
                VertexAttrib3fv(index, v_ptr);
            }
        }
        /// <inheritdoc cref="VertexAttrib3fv(uint, float*)"/>
        public static unsafe void VertexAttrib3f(uint index, ReadOnlySpan<System.Numerics.Vector3> v)
        {
            fixed (System.Numerics.Vector3* tmp_v = v)
            {
                float* v_ptr = (float*)tmp_v;
                VertexAttrib3fv(index, v_ptr);
            }
        }
        /// <inheritdoc cref="VertexAttrib3fv(uint, float*)"/>
        public static unsafe void VertexAttrib3f(uint index, System.Numerics.Vector3[] v)
        {
            fixed (System.Numerics.Vector3* tmp_v = v)
            {
                float* v_ptr = (float*)tmp_v;
                VertexAttrib3fv(index, v_ptr);
            }
        }
        /// <inheritdoc cref="VertexAttrib4fv(uint, float*)"/>
        public static unsafe void VertexAttrib4f(uint index, in Vector4 v)
        {
            fixed (Vector4* tmp_v = &v)
            {
                float* v_ptr = (float*)tmp_v;
                VertexAttrib4fv(index, v_ptr);
            }
        }
        /// <inheritdoc cref="VertexAttrib4fv(uint, float*)"/>
        public static unsafe void VertexAttrib4f(uint index, in System.Numerics.Vector4 v)
        {
            fixed (System.Numerics.Vector4* tmp_v = &v)
            {
                float* v_ptr = (float*)tmp_v;
                VertexAttrib4fv(index, v_ptr);
            }
        }
        /// <inheritdoc cref="VertexAttrib4fv(uint, float*)"/>
        public static unsafe void VertexAttrib4f(uint index, ReadOnlySpan<System.Numerics.Vector4> v)
        {
            fixed (System.Numerics.Vector4* tmp_v = v)
            {
                float* v_ptr = (float*)tmp_v;
                VertexAttrib4fv(index, v_ptr);
            }
        }
        /// <inheritdoc cref="VertexAttrib4fv(uint, float*)"/>
        public static unsafe void VertexAttrib4f(uint index, System.Numerics.Vector4[] v)
        {
            fixed (System.Numerics.Vector4* tmp_v = v)
            {
                float* v_ptr = (float*)tmp_v;
                VertexAttrib4fv(index, v_ptr);
            }
        }
        /// <inheritdoc cref="VertexAttribPointer(uint, int, VertexAttribPointerType, bool, int, void*)"/>
        public static unsafe void VertexAttribPointer(uint index, int size, VertexAttribPointerType type, bool normalized, int stride, nint offset)
        {
            void* pointer = (void*)offset;
            VertexAttribPointer(index, size, type, normalized, stride, pointer);
        }
        /// <inheritdoc cref="DrawRangeElements(PrimitiveType, uint, uint, int, DrawElementsType, void*)"/>
        public static unsafe void DrawRangeElements(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, nint offset)
        {
            void* indices = (void*)offset;
            DrawRangeElements(mode, start, end, count, type, indices);
        }
        /// <inheritdoc cref="TexImage3D(TextureTarget, int, InternalFormat, int, int, int, int, PixelFormat, PixelType, void*)"/>
        public static unsafe void TexImage3D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, IntPtr pixels)
        {
            void* pixels_vptr = (void*)pixels;
            TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels_vptr);
        }
        /// <inheritdoc cref="TexImage3D(TextureTarget, int, InternalFormat, int, int, int, int, PixelFormat, PixelType, void*)"/>
        public static unsafe void TexImage3D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, ReadOnlySpan<T1> pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels)
            {
                TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels_ptr);
            }
        }
        /// <inheritdoc cref="TexImage3D(TextureTarget, int, InternalFormat, int, int, int, int, PixelFormat, PixelType, void*)"/>
        public static unsafe void TexImage3D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, T1[] pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels)
            {
                TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels_ptr);
            }
        }
        /// <inheritdoc cref="TexImage3D(TextureTarget, int, InternalFormat, int, int, int, int, PixelFormat, PixelType, void*)"/>
        public static unsafe void TexImage3D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, in T1 pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = &pixels)
            {
                TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels_ptr);
            }
        }
        /// <inheritdoc cref="TexSubImage3D(TextureTarget, int, int, int, int, int, int, int, PixelFormat, PixelType, void*)"/>
        public static unsafe void TexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels)
        {
            void* pixels_vptr = (void*)pixels;
            TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels_vptr);
        }
        /// <inheritdoc cref="TexSubImage3D(TextureTarget, int, int, int, int, int, int, int, PixelFormat, PixelType, void*)"/>
        public static unsafe void TexSubImage3D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, ReadOnlySpan<T1> pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels)
            {
                TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels_ptr);
            }
        }
        /// <inheritdoc cref="TexSubImage3D(TextureTarget, int, int, int, int, int, int, int, PixelFormat, PixelType, void*)"/>
        public static unsafe void TexSubImage3D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, T1[] pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels)
            {
                TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels_ptr);
            }
        }
        /// <inheritdoc cref="TexSubImage3D(TextureTarget, int, int, int, int, int, int, int, PixelFormat, PixelType, void*)"/>
        public static unsafe void TexSubImage3D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, in T1 pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = &pixels)
            {
                TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels_ptr);
            }
        }
        /// <inheritdoc cref="CompressedTexImage3D(TextureTarget, int, InternalFormat, int, int, int, int, int, void*)"/>
        public static unsafe void CompressedTexImage3D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data)
        {
            void* data_vptr = (void*)data;
            CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data_vptr);
        }
        /// <inheritdoc cref="CompressedTexImage3D(TextureTarget, int, InternalFormat, int, int, int, int, int, void*)"/>
        public static unsafe void CompressedTexImage3D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, ReadOnlySpan<T1> data)
            where T1 : unmanaged
        {
            int imageSize = (int)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data_ptr);
            }
        }
        /// <inheritdoc cref="CompressedTexImage3D(TextureTarget, int, InternalFormat, int, int, int, int, int, void*)"/>
        public static unsafe void CompressedTexImage3D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, T1[] data)
            where T1 : unmanaged
        {
            int imageSize = (int)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data_ptr);
            }
        }
        /// <inheritdoc cref="CompressedTexImage3D(TextureTarget, int, InternalFormat, int, int, int, int, int, void*)"/>
        public static unsafe void CompressedTexImage3D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, in T1 data)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = &data)
            {
                CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data_ptr);
            }
        }
        /// <inheritdoc cref="CompressedTexSubImage3D(TextureTarget, int, int, int, int, int, int, int, InternalFormat, int, void*)"/>
        public static unsafe void CompressedTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, InternalFormat format, int imageSize, IntPtr data)
        {
            void* data_vptr = (void*)data;
            CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data_vptr);
        }
        /// <inheritdoc cref="CompressedTexSubImage3D(TextureTarget, int, int, int, int, int, int, int, InternalFormat, int, void*)"/>
        public static unsafe void CompressedTexSubImage3D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, InternalFormat format, ReadOnlySpan<T1> data)
            where T1 : unmanaged
        {
            int imageSize = (int)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data_ptr);
            }
        }
        /// <inheritdoc cref="CompressedTexSubImage3D(TextureTarget, int, int, int, int, int, int, int, InternalFormat, int, void*)"/>
        public static unsafe void CompressedTexSubImage3D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, InternalFormat format, T1[] data)
            where T1 : unmanaged
        {
            int imageSize = (int)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data_ptr);
            }
        }
        /// <inheritdoc cref="CompressedTexSubImage3D(TextureTarget, int, int, int, int, int, int, int, InternalFormat, int, void*)"/>
        public static unsafe void CompressedTexSubImage3D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, InternalFormat format, int imageSize, in T1 data)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = &data)
            {
                CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data_ptr);
            }
        }
        /// <inheritdoc cref="GenQueries(int, int*)"/>
        public static unsafe int GenQuery()
        {
            int id;
            int n = 1;
            Unsafe.SkipInit(out id);
            // FIXME: This could be a problem for the overloads that take an out parameter
            // as this parameter could *potentially* move while inside of this function
            // which would mean that the new value never gets written to the out parameter.
            // Making for a nasty bug.
            // The reason we don't use a fixed expression here is because of the "single out parameter to return value" overloading step
            // that will make it so this tries to fix a local variable which is not allowed in C# for some reason.
            // If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk
            // - 2021-05-18
            int* ids_handle = (int*)Unsafe.AsPointer(ref id);
            GenQueries(n, ids_handle);
            return id;
        }
        /// <inheritdoc cref="GenQueries(int, int*)"/>
        public static unsafe void GenQuery(out int id)
        {
            int n = 1;
            Unsafe.SkipInit(out id);
            // FIXME: This could be a problem for the overloads that take an out parameter
            // as this parameter could *potentially* move while inside of this function
            // which would mean that the new value never gets written to the out parameter.
            // Making for a nasty bug.
            // The reason we don't use a fixed expression here is because of the "single out parameter to return value" overloading step
            // that will make it so this tries to fix a local variable which is not allowed in C# for some reason.
            // If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk
            // - 2021-05-18
            int* ids_handle = (int*)Unsafe.AsPointer(ref id);
            GenQueries(n, ids_handle);
        }
        /// <inheritdoc cref="GenQueries(int, int*)"/>
        public static unsafe void GenQueries(Span<int> ids)
        {
            int n = (int)(ids.Length);
            fixed (int* ids_ptr = ids)
            {
                GenQueries(n, ids_ptr);
            }
        }
        /// <inheritdoc cref="GenQueries(int, int*)"/>
        public static unsafe void GenQueries(int[] ids)
        {
            int n = (int)(ids.Length);
            fixed (int* ids_ptr = ids)
            {
                GenQueries(n, ids_ptr);
            }
        }
        /// <inheritdoc cref="GenQueries(int, int*)"/>
        public static unsafe void GenQueries(int n, ref int ids)
        {
            fixed (int* ids_ptr = &ids)
            {
                GenQueries(n, ids_ptr);
            }
        }
        /// <inheritdoc cref="DeleteQueries(int, int*)"/>
        public static unsafe void DeleteQuery(in int id)
        {
            int n = 1;
            fixed(int* ids_handle = &id)
            {
                DeleteQueries(n, ids_handle);
            }
        }
        /// <inheritdoc cref="DeleteQueries(int, int*)"/>
        public static unsafe void DeleteQueries(ReadOnlySpan<int> ids)
        {
            int n = (int)(ids.Length);
            fixed (int* ids_ptr = ids)
            {
                DeleteQueries(n, ids_ptr);
            }
        }
        /// <inheritdoc cref="DeleteQueries(int, int*)"/>
        public static unsafe void DeleteQueries(int[] ids)
        {
            int n = (int)(ids.Length);
            fixed (int* ids_ptr = ids)
            {
                DeleteQueries(n, ids_ptr);
            }
        }
        /// <inheritdoc cref="DeleteQueries(int, int*)"/>
        public static unsafe void DeleteQueries(int n, in int ids)
        {
            fixed (int* ids_ptr = &ids)
            {
                DeleteQueries(n, ids_ptr);
            }
        }
        /// <inheritdoc cref="GetQueryiv(QueryTarget, QueryParameterName, int*)"/>
        public static unsafe void GetQueryi(QueryTarget target, QueryParameterName pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetQueryiv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetQueryiv(QueryTarget, QueryParameterName, int*)"/>
        public static unsafe void GetQueryi(QueryTarget target, QueryParameterName pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetQueryiv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetQueryiv(QueryTarget, QueryParameterName, int*)"/>
        public static unsafe void GetQueryi(QueryTarget target, QueryParameterName pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetQueryiv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetQueryObjectuiv(int, QueryObjectParameterName, uint*)"/>
        public static unsafe void GetQueryObjectui(int id, QueryObjectParameterName pname, Span<uint> parameters)
        {
            fixed (uint* parameters_ptr = parameters)
            {
                GetQueryObjectuiv(id, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetQueryObjectuiv(int, QueryObjectParameterName, uint*)"/>
        public static unsafe void GetQueryObjectui(int id, QueryObjectParameterName pname, uint[] parameters)
        {
            fixed (uint* parameters_ptr = parameters)
            {
                GetQueryObjectuiv(id, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetQueryObjectuiv(int, QueryObjectParameterName, uint*)"/>
        public static unsafe void GetQueryObjectui(int id, QueryObjectParameterName pname, ref uint parameters)
        {
            fixed (uint* parameters_ptr = &parameters)
            {
                GetQueryObjectuiv(id, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferPointerv(BufferTargetARB, BufferPointerNameARB, void**)"/>
        public static unsafe void GetBufferPointer(BufferTargetARB target, BufferPointerNameARB pname, void** parameters)
        {
            GetBufferPointerv(target, pname, parameters);
        }
        /// <inheritdoc cref="DrawBuffers(int, DrawBufferMode*)"/>
        public static unsafe void DrawBuffers(ReadOnlySpan<DrawBufferMode> bufs)
        {
            int n = (int)(bufs.Length);
            fixed (DrawBufferMode* bufs_ptr = bufs)
            {
                DrawBuffers(n, bufs_ptr);
            }
        }
        /// <inheritdoc cref="DrawBuffers(int, DrawBufferMode*)"/>
        public static unsafe void DrawBuffers(DrawBufferMode[] bufs)
        {
            int n = (int)(bufs.Length);
            fixed (DrawBufferMode* bufs_ptr = bufs)
            {
                DrawBuffers(n, bufs_ptr);
            }
        }
        /// <inheritdoc cref="DrawBuffers(int, DrawBufferMode*)"/>
        public static unsafe void DrawBuffers(int n, in DrawBufferMode bufs)
        {
            fixed (DrawBufferMode* bufs_ptr = &bufs)
            {
                DrawBuffers(n, bufs_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix2x3fv(int, int, bool, float*)"/>
        public static unsafe void UniformMatrix2x3f(int location, int count, bool transpose, in Matrix2x3 value)
        {
            fixed (Matrix2x3* tmp_value = &value)
            {
                float* value_ptr = (float*)tmp_value;
                UniformMatrix2x3fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix2x3fv(int, int, bool, float*)"/>
        public static unsafe void UniformMatrix2x3f(int location, int count, bool transpose, ReadOnlySpan<Matrix2x3> value)
        {
            fixed (Matrix2x3* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                UniformMatrix2x3fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix2x3fv(int, int, bool, float*)"/>
        public static unsafe void UniformMatrix2x3f(int location, int count, bool transpose, Matrix2x3[] value)
        {
            fixed (Matrix2x3* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                UniformMatrix2x3fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix3x2fv(int, int, bool, float*)"/>
        public static unsafe void UniformMatrix3x2f(int location, int count, bool transpose, in Matrix3x2 value)
        {
            fixed (Matrix3x2* tmp_value = &value)
            {
                float* value_ptr = (float*)tmp_value;
                UniformMatrix3x2fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix3x2fv(int, int, bool, float*)"/>
        public static unsafe void UniformMatrix3x2f(int location, int count, bool transpose, ReadOnlySpan<Matrix3x2> value)
        {
            fixed (Matrix3x2* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                UniformMatrix3x2fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix3x2fv(int, int, bool, float*)"/>
        public static unsafe void UniformMatrix3x2f(int location, int count, bool transpose, Matrix3x2[] value)
        {
            fixed (Matrix3x2* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                UniformMatrix3x2fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix3x2fv(int, int, bool, float*)"/>
        public static unsafe void UniformMatrix3x2f(int location, int count, bool transpose, in System.Numerics.Matrix3x2 value)
        {
            fixed (System.Numerics.Matrix3x2* tmp_value = &value)
            {
                float* value_ptr = (float*)tmp_value;
                UniformMatrix3x2fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix3x2fv(int, int, bool, float*)"/>
        public static unsafe void UniformMatrix3x2f(int location, int count, bool transpose, ReadOnlySpan<System.Numerics.Matrix3x2> value)
        {
            fixed (System.Numerics.Matrix3x2* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                UniformMatrix3x2fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix3x2fv(int, int, bool, float*)"/>
        public static unsafe void UniformMatrix3x2f(int location, int count, bool transpose, System.Numerics.Matrix3x2[] value)
        {
            fixed (System.Numerics.Matrix3x2* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                UniformMatrix3x2fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix2x4fv(int, int, bool, float*)"/>
        public static unsafe void UniformMatrix2x4f(int location, int count, bool transpose, in Matrix2x4 value)
        {
            fixed (Matrix2x4* tmp_value = &value)
            {
                float* value_ptr = (float*)tmp_value;
                UniformMatrix2x4fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix2x4fv(int, int, bool, float*)"/>
        public static unsafe void UniformMatrix2x4f(int location, int count, bool transpose, ReadOnlySpan<Matrix2x4> value)
        {
            fixed (Matrix2x4* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                UniformMatrix2x4fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix2x4fv(int, int, bool, float*)"/>
        public static unsafe void UniformMatrix2x4f(int location, int count, bool transpose, Matrix2x4[] value)
        {
            fixed (Matrix2x4* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                UniformMatrix2x4fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix4x2fv(int, int, bool, float*)"/>
        public static unsafe void UniformMatrix4x2f(int location, int count, bool transpose, in Matrix4x2 value)
        {
            fixed (Matrix4x2* tmp_value = &value)
            {
                float* value_ptr = (float*)tmp_value;
                UniformMatrix4x2fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix4x2fv(int, int, bool, float*)"/>
        public static unsafe void UniformMatrix4x2f(int location, int count, bool transpose, ReadOnlySpan<Matrix4x2> value)
        {
            fixed (Matrix4x2* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                UniformMatrix4x2fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix4x2fv(int, int, bool, float*)"/>
        public static unsafe void UniformMatrix4x2f(int location, int count, bool transpose, Matrix4x2[] value)
        {
            fixed (Matrix4x2* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                UniformMatrix4x2fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix3x4fv(int, int, bool, float*)"/>
        public static unsafe void UniformMatrix3x4f(int location, int count, bool transpose, in Matrix3x4 value)
        {
            fixed (Matrix3x4* tmp_value = &value)
            {
                float* value_ptr = (float*)tmp_value;
                UniformMatrix3x4fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix3x4fv(int, int, bool, float*)"/>
        public static unsafe void UniformMatrix3x4f(int location, int count, bool transpose, ReadOnlySpan<Matrix3x4> value)
        {
            fixed (Matrix3x4* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                UniformMatrix3x4fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix3x4fv(int, int, bool, float*)"/>
        public static unsafe void UniformMatrix3x4f(int location, int count, bool transpose, Matrix3x4[] value)
        {
            fixed (Matrix3x4* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                UniformMatrix3x4fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix4x3fv(int, int, bool, float*)"/>
        public static unsafe void UniformMatrix4x3f(int location, int count, bool transpose, in Matrix4x3 value)
        {
            fixed (Matrix4x3* tmp_value = &value)
            {
                float* value_ptr = (float*)tmp_value;
                UniformMatrix4x3fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix4x3fv(int, int, bool, float*)"/>
        public static unsafe void UniformMatrix4x3f(int location, int count, bool transpose, ReadOnlySpan<Matrix4x3> value)
        {
            fixed (Matrix4x3* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                UniformMatrix4x3fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix4x3fv(int, int, bool, float*)"/>
        public static unsafe void UniformMatrix4x3f(int location, int count, bool transpose, Matrix4x3[] value)
        {
            fixed (Matrix4x3* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                UniformMatrix4x3fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="DeleteVertexArrays(int, int*)"/>
        public static unsafe void DeleteVertexArray(in int array)
        {
            int n = 1;
            fixed(int* arrays_handle = &array)
            {
                DeleteVertexArrays(n, arrays_handle);
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
        public static unsafe int GenVertexArray()
        {
            int array;
            int n = 1;
            Unsafe.SkipInit(out array);
            // FIXME: This could be a problem for the overloads that take an out parameter
            // as this parameter could *potentially* move while inside of this function
            // which would mean that the new value never gets written to the out parameter.
            // Making for a nasty bug.
            // The reason we don't use a fixed expression here is because of the "single out parameter to return value" overloading step
            // that will make it so this tries to fix a local variable which is not allowed in C# for some reason.
            // If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk
            // - 2021-05-18
            int* arrays_handle = (int*)Unsafe.AsPointer(ref array);
            GenVertexArrays(n, arrays_handle);
            return array;
        }
        /// <inheritdoc cref="GenVertexArrays(int, int*)"/>
        public static unsafe void GenVertexArray(out int array)
        {
            int n = 1;
            Unsafe.SkipInit(out array);
            // FIXME: This could be a problem for the overloads that take an out parameter
            // as this parameter could *potentially* move while inside of this function
            // which would mean that the new value never gets written to the out parameter.
            // Making for a nasty bug.
            // The reason we don't use a fixed expression here is because of the "single out parameter to return value" overloading step
            // that will make it so this tries to fix a local variable which is not allowed in C# for some reason.
            // If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk
            // - 2021-05-18
            int* arrays_handle = (int*)Unsafe.AsPointer(ref array);
            GenVertexArrays(n, arrays_handle);
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
        /// <inheritdoc cref="GetIntegeri_v(GetPName, uint, int*)"/>
        public static unsafe void GetInteger(GetPName target, uint index, Span<int> data)
        {
            fixed (int* data_ptr = data)
            {
                GetIntegeri_v(target, index, data_ptr);
            }
        }
        /// <inheritdoc cref="GetIntegeri_v(GetPName, uint, int*)"/>
        public static unsafe void GetInteger(GetPName target, uint index, int[] data)
        {
            fixed (int* data_ptr = data)
            {
                GetIntegeri_v(target, index, data_ptr);
            }
        }
        /// <inheritdoc cref="GetIntegeri_v(GetPName, uint, int*)"/>
        public static unsafe void GetInteger(GetPName target, uint index, ref int data)
        {
            fixed (int* data_ptr = &data)
            {
                GetIntegeri_v(target, index, data_ptr);
            }
        }
        /// <inheritdoc cref="GetTransformFeedbackVarying(int, uint, int, int*, int*, AttributeType*, byte*)"/>
        public static unsafe string GetTransformFeedbackVarying(int program, uint index, int bufSize, Span<int> length, Span<int> size, Span<AttributeType> type)
        {
            string name;
            fixed (int* length_ptr = length)
            {
                fixed (int* size_ptr = size)
                {
                    fixed (AttributeType* type_ptr = type)
                    {
                        var name_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                        GetTransformFeedbackVarying(program, index, bufSize, length_ptr, size_ptr, type_ptr, name_ptr);
                        name = Marshal.PtrToStringUTF8((IntPtr)name_ptr)!;
                        Marshal.FreeCoTaskMem((IntPtr)name_ptr);
                    }
                }
            }
            return name;
        }
        /// <inheritdoc cref="GetTransformFeedbackVarying(int, uint, int, int*, int*, AttributeType*, byte*)"/>
        public static unsafe void GetTransformFeedbackVarying(int program, uint index, int bufSize, Span<int> length, Span<int> size, Span<AttributeType> type, out string name)
        {
            fixed (int* length_ptr = length)
            {
                fixed (int* size_ptr = size)
                {
                    fixed (AttributeType* type_ptr = type)
                    {
                        var name_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                        GetTransformFeedbackVarying(program, index, bufSize, length_ptr, size_ptr, type_ptr, name_ptr);
                        name = Marshal.PtrToStringUTF8((IntPtr)name_ptr)!;
                        Marshal.FreeCoTaskMem((IntPtr)name_ptr);
                    }
                }
            }
        }
        /// <inheritdoc cref="GetTransformFeedbackVarying(int, uint, int, int*, int*, AttributeType*, byte*)"/>
        public static unsafe string GetTransformFeedbackVarying(int program, uint index, int bufSize, int[] length, int[] size, AttributeType[] type)
        {
            string name;
            fixed (int* length_ptr = length)
            {
                fixed (int* size_ptr = size)
                {
                    fixed (AttributeType* type_ptr = type)
                    {
                        var name_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                        GetTransformFeedbackVarying(program, index, bufSize, length_ptr, size_ptr, type_ptr, name_ptr);
                        name = Marshal.PtrToStringUTF8((IntPtr)name_ptr)!;
                        Marshal.FreeCoTaskMem((IntPtr)name_ptr);
                    }
                }
            }
            return name;
        }
        /// <inheritdoc cref="GetTransformFeedbackVarying(int, uint, int, int*, int*, AttributeType*, byte*)"/>
        public static unsafe void GetTransformFeedbackVarying(int program, uint index, int bufSize, int[] length, int[] size, AttributeType[] type, out string name)
        {
            fixed (int* length_ptr = length)
            {
                fixed (int* size_ptr = size)
                {
                    fixed (AttributeType* type_ptr = type)
                    {
                        var name_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                        GetTransformFeedbackVarying(program, index, bufSize, length_ptr, size_ptr, type_ptr, name_ptr);
                        name = Marshal.PtrToStringUTF8((IntPtr)name_ptr)!;
                        Marshal.FreeCoTaskMem((IntPtr)name_ptr);
                    }
                }
            }
        }
        /// <inheritdoc cref="GetTransformFeedbackVarying(int, uint, int, int*, int*, AttributeType*, byte*)"/>
        public static unsafe string GetTransformFeedbackVarying(int program, uint index, int bufSize, ref int length, ref int size, ref AttributeType type)
        {
            string name;
            fixed (int* length_ptr = &length)
            fixed (int* size_ptr = &size)
            fixed (AttributeType* type_ptr = &type)
            {
                var name_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetTransformFeedbackVarying(program, index, bufSize, length_ptr, size_ptr, type_ptr, name_ptr);
                name = Marshal.PtrToStringUTF8((IntPtr)name_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)name_ptr);
            }
            return name;
        }
        /// <inheritdoc cref="GetTransformFeedbackVarying(int, uint, int, int*, int*, AttributeType*, byte*)"/>
        public static unsafe void GetTransformFeedbackVarying(int program, uint index, int bufSize, ref int length, ref int size, ref AttributeType type, out string name)
        {
            fixed (int* length_ptr = &length)
            fixed (int* size_ptr = &size)
            fixed (AttributeType* type_ptr = &type)
            {
                var name_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetTransformFeedbackVarying(program, index, bufSize, length_ptr, size_ptr, type_ptr, name_ptr);
                name = Marshal.PtrToStringUTF8((IntPtr)name_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)name_ptr);
            }
        }
        /// <inheritdoc cref="VertexAttribIPointer(uint, int, VertexAttribIType, int, void*)"/>
        public static unsafe void VertexAttribIPointer(uint index, int size, VertexAttribIType type, int stride, nint offset)
        {
            void* pointer = (void*)offset;
            VertexAttribIPointer(index, size, type, stride, pointer);
        }
        /// <inheritdoc cref="GetVertexAttribIiv(uint, VertexAttribEnum, int*)"/>
        public static unsafe void GetVertexAttribIi(uint index, VertexAttribEnum pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetVertexAttribIiv(index, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetVertexAttribIiv(uint, VertexAttribEnum, int*)"/>
        public static unsafe void GetVertexAttribIi(uint index, VertexAttribEnum pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetVertexAttribIiv(index, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetVertexAttribIiv(uint, VertexAttribEnum, int*)"/>
        public static unsafe void GetVertexAttribIi(uint index, VertexAttribEnum pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetVertexAttribIiv(index, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetVertexAttribIuiv(uint, VertexAttribEnum, uint*)"/>
        public static unsafe void GetVertexAttribIui(uint index, VertexAttribEnum pname, Span<uint> parameters)
        {
            fixed (uint* parameters_ptr = parameters)
            {
                GetVertexAttribIuiv(index, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetVertexAttribIuiv(uint, VertexAttribEnum, uint*)"/>
        public static unsafe void GetVertexAttribIui(uint index, VertexAttribEnum pname, uint[] parameters)
        {
            fixed (uint* parameters_ptr = parameters)
            {
                GetVertexAttribIuiv(index, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetVertexAttribIuiv(uint, VertexAttribEnum, uint*)"/>
        public static unsafe void GetVertexAttribIui(uint index, VertexAttribEnum pname, ref uint parameters)
        {
            fixed (uint* parameters_ptr = &parameters)
            {
                GetVertexAttribIuiv(index, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="VertexAttribI4iv(uint, int*)"/>
        public static unsafe void VertexAttribI4i(uint index, in Vector4i v)
        {
            fixed (Vector4i* tmp_v = &v)
            {
                int* v_ptr = (int*)tmp_v;
                VertexAttribI4iv(index, v_ptr);
            }
        }
        /// <inheritdoc cref="VertexAttribI4uiv(uint, uint*)"/>
        public static unsafe void VertexAttribI4ui(uint index, ReadOnlySpan<uint> v)
        {
            fixed (uint* v_ptr = v)
            {
                VertexAttribI4uiv(index, v_ptr);
            }
        }
        /// <inheritdoc cref="VertexAttribI4uiv(uint, uint*)"/>
        public static unsafe void VertexAttribI4ui(uint index, uint[] v)
        {
            fixed (uint* v_ptr = v)
            {
                VertexAttribI4uiv(index, v_ptr);
            }
        }
        /// <inheritdoc cref="VertexAttribI4uiv(uint, uint*)"/>
        public static unsafe void VertexAttribI4ui(uint index, in uint v)
        {
            fixed (uint* v_ptr = &v)
            {
                VertexAttribI4uiv(index, v_ptr);
            }
        }
        /// <inheritdoc cref="GetUniformuiv(int, int, uint*)"/>
        public static unsafe void GetUniformui(int program, int location, Span<uint> parameters)
        {
            fixed (uint* parameters_ptr = parameters)
            {
                GetUniformuiv(program, location, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetUniformuiv(int, int, uint*)"/>
        public static unsafe void GetUniformui(int program, int location, uint[] parameters)
        {
            fixed (uint* parameters_ptr = parameters)
            {
                GetUniformuiv(program, location, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetUniformuiv(int, int, uint*)"/>
        public static unsafe void GetUniformui(int program, int location, ref uint parameters)
        {
            fixed (uint* parameters_ptr = &parameters)
            {
                GetUniformuiv(program, location, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetFragDataLocation(int, byte*)"/>
        public static unsafe int GetFragDataLocation(int program, string name)
        {
            int returnValue;
            byte* name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(name);
            returnValue = GetFragDataLocation(program, name_ptr);
            Marshal.FreeCoTaskMem((IntPtr)name_ptr);
            return returnValue;
        }
        /// <inheritdoc cref="Uniform1uiv(int, int, uint*)"/>
        public static unsafe void Uniform1ui(int location, int count, in uint value)
        {
            fixed (uint* tmp_value = &value)
            {
                uint* value_ptr = (uint*)tmp_value;
                Uniform1uiv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform1uiv(int, int, uint*)"/>
        public static unsafe void Uniform1ui(int location, int count, ReadOnlySpan<uint> value)
        {
            fixed (uint* tmp_value = value)
            {
                uint* value_ptr = (uint*)tmp_value;
                Uniform1uiv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform1uiv(int, int, uint*)"/>
        public static unsafe void Uniform1ui(int location, int count, uint[] value)
        {
            fixed (uint* tmp_value = value)
            {
                uint* value_ptr = (uint*)tmp_value;
                Uniform1uiv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform2uiv(int, int, uint*)"/>
        public static unsafe void Uniform2ui(int location, int count, in Vector2i value)
        {
            fixed (Vector2i* tmp_value = &value)
            {
                uint* value_ptr = (uint*)tmp_value;
                Uniform2uiv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform2uiv(int, int, uint*)"/>
        public static unsafe void Uniform2ui(int location, int count, ReadOnlySpan<Vector2i> value)
        {
            fixed (Vector2i* tmp_value = value)
            {
                uint* value_ptr = (uint*)tmp_value;
                Uniform2uiv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform2uiv(int, int, uint*)"/>
        public static unsafe void Uniform2ui(int location, int count, Vector2i[] value)
        {
            fixed (Vector2i* tmp_value = value)
            {
                uint* value_ptr = (uint*)tmp_value;
                Uniform2uiv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform3uiv(int, int, uint*)"/>
        public static unsafe void Uniform3ui(int location, int count, in Vector3i value)
        {
            fixed (Vector3i* tmp_value = &value)
            {
                uint* value_ptr = (uint*)tmp_value;
                Uniform3uiv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform3uiv(int, int, uint*)"/>
        public static unsafe void Uniform3ui(int location, int count, ReadOnlySpan<Vector3i> value)
        {
            fixed (Vector3i* tmp_value = value)
            {
                uint* value_ptr = (uint*)tmp_value;
                Uniform3uiv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform3uiv(int, int, uint*)"/>
        public static unsafe void Uniform3ui(int location, int count, Vector3i[] value)
        {
            fixed (Vector3i* tmp_value = value)
            {
                uint* value_ptr = (uint*)tmp_value;
                Uniform3uiv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform4uiv(int, int, uint*)"/>
        public static unsafe void Uniform4ui(int location, int count, in Vector4i value)
        {
            fixed (Vector4i* tmp_value = &value)
            {
                uint* value_ptr = (uint*)tmp_value;
                Uniform4uiv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform4uiv(int, int, uint*)"/>
        public static unsafe void Uniform4ui(int location, int count, ReadOnlySpan<Vector4i> value)
        {
            fixed (Vector4i* tmp_value = value)
            {
                uint* value_ptr = (uint*)tmp_value;
                Uniform4uiv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform4uiv(int, int, uint*)"/>
        public static unsafe void Uniform4ui(int location, int count, Vector4i[] value)
        {
            fixed (Vector4i* tmp_value = value)
            {
                uint* value_ptr = (uint*)tmp_value;
                Uniform4uiv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ClearBufferiv(Buffer, int, int*)"/>
        public static unsafe void ClearBufferi(Buffer buffer, int drawbuffer, ReadOnlySpan<int> value)
        {
            fixed (int* value_ptr = value)
            {
                ClearBufferiv(buffer, drawbuffer, value_ptr);
            }
        }
        /// <inheritdoc cref="ClearBufferiv(Buffer, int, int*)"/>
        public static unsafe void ClearBufferi(Buffer buffer, int drawbuffer, int[] value)
        {
            fixed (int* value_ptr = value)
            {
                ClearBufferiv(buffer, drawbuffer, value_ptr);
            }
        }
        /// <inheritdoc cref="ClearBufferiv(Buffer, int, int*)"/>
        public static unsafe void ClearBufferi(Buffer buffer, int drawbuffer, in int value)
        {
            fixed (int* value_ptr = &value)
            {
                ClearBufferiv(buffer, drawbuffer, value_ptr);
            }
        }
        /// <inheritdoc cref="ClearBufferuiv(Buffer, int, uint*)"/>
        public static unsafe void ClearBufferui(Buffer buffer, int drawbuffer, ReadOnlySpan<uint> value)
        {
            fixed (uint* value_ptr = value)
            {
                ClearBufferuiv(buffer, drawbuffer, value_ptr);
            }
        }
        /// <inheritdoc cref="ClearBufferuiv(Buffer, int, uint*)"/>
        public static unsafe void ClearBufferui(Buffer buffer, int drawbuffer, uint[] value)
        {
            fixed (uint* value_ptr = value)
            {
                ClearBufferuiv(buffer, drawbuffer, value_ptr);
            }
        }
        /// <inheritdoc cref="ClearBufferuiv(Buffer, int, uint*)"/>
        public static unsafe void ClearBufferui(Buffer buffer, int drawbuffer, in uint value)
        {
            fixed (uint* value_ptr = &value)
            {
                ClearBufferuiv(buffer, drawbuffer, value_ptr);
            }
        }
        /// <inheritdoc cref="ClearBufferfv(Buffer, int, float*)"/>
        public static unsafe void ClearBufferf(Buffer buffer, int drawbuffer, ReadOnlySpan<float> value)
        {
            fixed (float* value_ptr = value)
            {
                ClearBufferfv(buffer, drawbuffer, value_ptr);
            }
        }
        /// <inheritdoc cref="ClearBufferfv(Buffer, int, float*)"/>
        public static unsafe void ClearBufferf(Buffer buffer, int drawbuffer, float[] value)
        {
            fixed (float* value_ptr = value)
            {
                ClearBufferfv(buffer, drawbuffer, value_ptr);
            }
        }
        /// <inheritdoc cref="ClearBufferfv(Buffer, int, float*)"/>
        public static unsafe void ClearBufferf(Buffer buffer, int drawbuffer, in float value)
        {
            fixed (float* value_ptr = &value)
            {
                ClearBufferfv(buffer, drawbuffer, value_ptr);
            }
        }
        /// <inheritdoc cref="ClearBufferfi(Buffer, int, float, int)"/>
        public static unsafe void ClearBuffer(Buffer buffer, int drawbuffer, float depth, int stencil)
        {
            ClearBufferfi(buffer, drawbuffer, depth, stencil);
        }
        /// <inheritdoc cref="GetStringi(StringName, uint)"/>
        public static unsafe string? GetStringi(StringName name, uint index)
        {
            byte* returnValue;
            string? returnValue_str;
            returnValue = GetStringi_(name, index);
            returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
            return returnValue_str;
        }
        /// <inheritdoc cref="GetUniformIndices(int, int, byte**, uint*)"/>
        public static unsafe void GetUniformIndices(int program, int uniformCount, byte** uniformNames, Span<uint> uniformIndices)
        {
            fixed (uint* uniformIndices_ptr = uniformIndices)
            {
                GetUniformIndices(program, uniformCount, uniformNames, uniformIndices_ptr);
            }
        }
        /// <inheritdoc cref="GetUniformIndices(int, int, byte**, uint*)"/>
        public static unsafe void GetUniformIndices(int program, int uniformCount, byte** uniformNames, uint[] uniformIndices)
        {
            fixed (uint* uniformIndices_ptr = uniformIndices)
            {
                GetUniformIndices(program, uniformCount, uniformNames, uniformIndices_ptr);
            }
        }
        /// <inheritdoc cref="GetUniformIndices(int, int, byte**, uint*)"/>
        public static unsafe void GetUniformIndices(int program, int uniformCount, byte** uniformNames, ref uint uniformIndices)
        {
            fixed (uint* uniformIndices_ptr = &uniformIndices)
            {
                GetUniformIndices(program, uniformCount, uniformNames, uniformIndices_ptr);
            }
        }
        /// <inheritdoc cref="GetActiveUniformsiv(int, int, uint*, UniformPName, int*)"/>
        public static unsafe void GetActiveUniformsi(int program, ReadOnlySpan<uint> uniformIndices, UniformPName pname, Span<int> parameters)
        {
            int uniformCount = (int)(uniformIndices.Length);
            fixed (uint* uniformIndices_ptr = uniformIndices)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetActiveUniformsiv(program, uniformCount, uniformIndices_ptr, pname, parameters_ptr);
                }
            }
        }
        /// <inheritdoc cref="GetActiveUniformsiv(int, int, uint*, UniformPName, int*)"/>
        public static unsafe void GetActiveUniformsi(int program, uint[] uniformIndices, UniformPName pname, int[] parameters)
        {
            int uniformCount = (int)(uniformIndices.Length);
            fixed (uint* uniformIndices_ptr = uniformIndices)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetActiveUniformsiv(program, uniformCount, uniformIndices_ptr, pname, parameters_ptr);
                }
            }
        }
        /// <inheritdoc cref="GetActiveUniformsiv(int, int, uint*, UniformPName, int*)"/>
        public static unsafe void GetActiveUniformsi(int program, int uniformCount, in uint uniformIndices, UniformPName pname, ref int parameters)
        {
            fixed (uint* uniformIndices_ptr = &uniformIndices)
            fixed (int* parameters_ptr = &parameters)
            {
                GetActiveUniformsiv(program, uniformCount, uniformIndices_ptr, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetUniformBlockIndex(int, byte*)"/>
        public static unsafe uint GetUniformBlockIndex(int program, string uniformBlockName)
        {
            uint returnValue;
            byte* uniformBlockName_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(uniformBlockName);
            returnValue = GetUniformBlockIndex(program, uniformBlockName_ptr);
            Marshal.FreeCoTaskMem((IntPtr)uniformBlockName_ptr);
            return returnValue;
        }
        /// <inheritdoc cref="GetActiveUniformBlockiv(int, uint, UniformBlockPName, int*)"/>
        public static unsafe void GetActiveUniformBlocki(int program, uint uniformBlockIndex, UniformBlockPName pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetActiveUniformBlockiv(program, uniformBlockIndex, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetActiveUniformBlockiv(int, uint, UniformBlockPName, int*)"/>
        public static unsafe void GetActiveUniformBlocki(int program, uint uniformBlockIndex, UniformBlockPName pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetActiveUniformBlockiv(program, uniformBlockIndex, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetActiveUniformBlockiv(int, uint, UniformBlockPName, int*)"/>
        public static unsafe void GetActiveUniformBlocki(int program, uint uniformBlockIndex, UniformBlockPName pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetActiveUniformBlockiv(program, uniformBlockIndex, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetActiveUniformBlockName(int, uint, int, int*, byte*)"/>
        public static unsafe string GetActiveUniformBlockName(int program, uint uniformBlockIndex, int bufSize, Span<int> length)
        {
            string uniformBlockName;
            fixed (int* length_ptr = length)
            {
                var uniformBlockName_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length_ptr, uniformBlockName_ptr);
                uniformBlockName = Marshal.PtrToStringUTF8((IntPtr)uniformBlockName_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)uniformBlockName_ptr);
            }
            return uniformBlockName;
        }
        /// <inheritdoc cref="GetActiveUniformBlockName(int, uint, int, int*, byte*)"/>
        public static unsafe void GetActiveUniformBlockName(int program, uint uniformBlockIndex, int bufSize, Span<int> length, out string uniformBlockName)
        {
            fixed (int* length_ptr = length)
            {
                var uniformBlockName_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length_ptr, uniformBlockName_ptr);
                uniformBlockName = Marshal.PtrToStringUTF8((IntPtr)uniformBlockName_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)uniformBlockName_ptr);
            }
        }
        /// <inheritdoc cref="GetActiveUniformBlockName(int, uint, int, int*, byte*)"/>
        public static unsafe string GetActiveUniformBlockName(int program, uint uniformBlockIndex, int bufSize, int[] length)
        {
            string uniformBlockName;
            fixed (int* length_ptr = length)
            {
                var uniformBlockName_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length_ptr, uniformBlockName_ptr);
                uniformBlockName = Marshal.PtrToStringUTF8((IntPtr)uniformBlockName_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)uniformBlockName_ptr);
            }
            return uniformBlockName;
        }
        /// <inheritdoc cref="GetActiveUniformBlockName(int, uint, int, int*, byte*)"/>
        public static unsafe void GetActiveUniformBlockName(int program, uint uniformBlockIndex, int bufSize, int[] length, out string uniformBlockName)
        {
            fixed (int* length_ptr = length)
            {
                var uniformBlockName_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length_ptr, uniformBlockName_ptr);
                uniformBlockName = Marshal.PtrToStringUTF8((IntPtr)uniformBlockName_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)uniformBlockName_ptr);
            }
        }
        /// <inheritdoc cref="GetActiveUniformBlockName(int, uint, int, int*, byte*)"/>
        public static unsafe string GetActiveUniformBlockName(int program, uint uniformBlockIndex, int bufSize, ref int length)
        {
            string uniformBlockName;
            fixed (int* length_ptr = &length)
            {
                var uniformBlockName_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length_ptr, uniformBlockName_ptr);
                uniformBlockName = Marshal.PtrToStringUTF8((IntPtr)uniformBlockName_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)uniformBlockName_ptr);
            }
            return uniformBlockName;
        }
        /// <inheritdoc cref="GetActiveUniformBlockName(int, uint, int, int*, byte*)"/>
        public static unsafe void GetActiveUniformBlockName(int program, uint uniformBlockIndex, int bufSize, ref int length, out string uniformBlockName)
        {
            fixed (int* length_ptr = &length)
            {
                var uniformBlockName_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length_ptr, uniformBlockName_ptr);
                uniformBlockName = Marshal.PtrToStringUTF8((IntPtr)uniformBlockName_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)uniformBlockName_ptr);
            }
        }
        /// <inheritdoc cref="DrawElementsInstanced(PrimitiveType, int, DrawElementsType, void*, int)"/>
        public static unsafe void DrawElementsInstanced(PrimitiveType mode, int count, DrawElementsType type, nint offset, int instancecount)
        {
            void* indices = (void*)offset;
            DrawElementsInstanced(mode, count, type, indices, instancecount);
        }
        /// <inheritdoc cref="GetInteger64v(GetPName, long*)"/>
        public static unsafe void GetInteger64(GetPName pname, Span<long> data)
        {
            fixed (long* data_ptr = data)
            {
                GetInteger64v(pname, data_ptr);
            }
        }
        /// <inheritdoc cref="GetInteger64v(GetPName, long*)"/>
        public static unsafe void GetInteger64(GetPName pname, long[] data)
        {
            fixed (long* data_ptr = data)
            {
                GetInteger64v(pname, data_ptr);
            }
        }
        /// <inheritdoc cref="GetInteger64v(GetPName, long*)"/>
        public static unsafe void GetInteger64(GetPName pname, ref long data)
        {
            fixed (long* data_ptr = &data)
            {
                GetInteger64v(pname, data_ptr);
            }
        }
        /// <inheritdoc cref="GetSynciv(GLSync, SyncParameterName, int, int*, int*)"/>
        public static unsafe void GetSynci(GLSync sync, SyncParameterName pname, Span<int> length, Span<int> values)
        {
            fixed (int* length_ptr = length)
            {
                int count = (int)(values.Length);
                fixed (int* values_ptr = values)
                {
                    GetSynciv(sync, pname, count, length_ptr, values_ptr);
                }
            }
        }
        /// <inheritdoc cref="GetSynciv(GLSync, SyncParameterName, int, int*, int*)"/>
        public static unsafe void GetSynci(GLSync sync, SyncParameterName pname, int[] length, int[] values)
        {
            fixed (int* length_ptr = length)
            {
                int count = (int)(values.Length);
                fixed (int* values_ptr = values)
                {
                    GetSynciv(sync, pname, count, length_ptr, values_ptr);
                }
            }
        }
        /// <inheritdoc cref="GetSynciv(GLSync, SyncParameterName, int, int*, int*)"/>
        public static unsafe void GetSynci(GLSync sync, SyncParameterName pname, int count, ref int length, ref int values)
        {
            fixed (int* length_ptr = &length)
            fixed (int* values_ptr = &values)
            {
                GetSynciv(sync, pname, count, length_ptr, values_ptr);
            }
        }
        /// <inheritdoc cref="GetInteger64i_v(GetPName, uint, long*)"/>
        public static unsafe void GetInteger64(GetPName target, uint index, Span<long> data)
        {
            fixed (long* data_ptr = data)
            {
                GetInteger64i_v(target, index, data_ptr);
            }
        }
        /// <inheritdoc cref="GetInteger64i_v(GetPName, uint, long*)"/>
        public static unsafe void GetInteger64(GetPName target, uint index, long[] data)
        {
            fixed (long* data_ptr = data)
            {
                GetInteger64i_v(target, index, data_ptr);
            }
        }
        /// <inheritdoc cref="GetInteger64i_v(GetPName, uint, long*)"/>
        public static unsafe void GetInteger64(GetPName target, uint index, ref long data)
        {
            fixed (long* data_ptr = &data)
            {
                GetInteger64i_v(target, index, data_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferParameteri64v(BufferTargetARB, BufferPNameARB, long*)"/>
        public static unsafe void GetBufferParameteri64(BufferTargetARB target, BufferPNameARB pname, Span<long> parameters)
        {
            fixed (long* parameters_ptr = parameters)
            {
                GetBufferParameteri64v(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferParameteri64v(BufferTargetARB, BufferPNameARB, long*)"/>
        public static unsafe void GetBufferParameteri64(BufferTargetARB target, BufferPNameARB pname, long[] parameters)
        {
            fixed (long* parameters_ptr = parameters)
            {
                GetBufferParameteri64v(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferParameteri64v(BufferTargetARB, BufferPNameARB, long*)"/>
        public static unsafe void GetBufferParameteri64(BufferTargetARB target, BufferPNameARB pname, ref long parameters)
        {
            fixed (long* parameters_ptr = &parameters)
            {
                GetBufferParameteri64v(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GenSamplers(int, int*)"/>
        public static unsafe int GenSampler()
        {
            int sampler;
            int count = 1;
            Unsafe.SkipInit(out sampler);
            // FIXME: This could be a problem for the overloads that take an out parameter
            // as this parameter could *potentially* move while inside of this function
            // which would mean that the new value never gets written to the out parameter.
            // Making for a nasty bug.
            // The reason we don't use a fixed expression here is because of the "single out parameter to return value" overloading step
            // that will make it so this tries to fix a local variable which is not allowed in C# for some reason.
            // If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk
            // - 2021-05-18
            int* samplers_handle = (int*)Unsafe.AsPointer(ref sampler);
            GenSamplers(count, samplers_handle);
            return sampler;
        }
        /// <inheritdoc cref="GenSamplers(int, int*)"/>
        public static unsafe void GenSampler(out int sampler)
        {
            int count = 1;
            Unsafe.SkipInit(out sampler);
            // FIXME: This could be a problem for the overloads that take an out parameter
            // as this parameter could *potentially* move while inside of this function
            // which would mean that the new value never gets written to the out parameter.
            // Making for a nasty bug.
            // The reason we don't use a fixed expression here is because of the "single out parameter to return value" overloading step
            // that will make it so this tries to fix a local variable which is not allowed in C# for some reason.
            // If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk
            // - 2021-05-18
            int* samplers_handle = (int*)Unsafe.AsPointer(ref sampler);
            GenSamplers(count, samplers_handle);
        }
        /// <inheritdoc cref="GenSamplers(int, int*)"/>
        public static unsafe void GenSamplers(Span<int> samplers)
        {
            int count = (int)(samplers.Length);
            fixed (int* samplers_ptr = samplers)
            {
                GenSamplers(count, samplers_ptr);
            }
        }
        /// <inheritdoc cref="GenSamplers(int, int*)"/>
        public static unsafe void GenSamplers(int[] samplers)
        {
            int count = (int)(samplers.Length);
            fixed (int* samplers_ptr = samplers)
            {
                GenSamplers(count, samplers_ptr);
            }
        }
        /// <inheritdoc cref="GenSamplers(int, int*)"/>
        public static unsafe void GenSamplers(int count, ref int samplers)
        {
            fixed (int* samplers_ptr = &samplers)
            {
                GenSamplers(count, samplers_ptr);
            }
        }
        /// <inheritdoc cref="DeleteSamplers(int, int*)"/>
        public static unsafe void DeleteSampler(in int sampler)
        {
            int count = 1;
            fixed(int* samplers_handle = &sampler)
            {
                DeleteSamplers(count, samplers_handle);
            }
        }
        /// <inheritdoc cref="DeleteSamplers(int, int*)"/>
        public static unsafe void DeleteSamplers(ReadOnlySpan<int> samplers)
        {
            int count = (int)(samplers.Length);
            fixed (int* samplers_ptr = samplers)
            {
                DeleteSamplers(count, samplers_ptr);
            }
        }
        /// <inheritdoc cref="DeleteSamplers(int, int*)"/>
        public static unsafe void DeleteSamplers(int[] samplers)
        {
            int count = (int)(samplers.Length);
            fixed (int* samplers_ptr = samplers)
            {
                DeleteSamplers(count, samplers_ptr);
            }
        }
        /// <inheritdoc cref="DeleteSamplers(int, int*)"/>
        public static unsafe void DeleteSamplers(int count, in int samplers)
        {
            fixed (int* samplers_ptr = &samplers)
            {
                DeleteSamplers(count, samplers_ptr);
            }
        }
        /// <inheritdoc cref="SamplerParameteriv(int, SamplerParameterI, int*)"/>
        public static unsafe void SamplerParameteri(int sampler, SamplerParameterI pname, ReadOnlySpan<int> param)
        {
            fixed (int* param_ptr = param)
            {
                SamplerParameteriv(sampler, pname, param_ptr);
            }
        }
        /// <inheritdoc cref="SamplerParameteriv(int, SamplerParameterI, int*)"/>
        public static unsafe void SamplerParameteri(int sampler, SamplerParameterI pname, int[] param)
        {
            fixed (int* param_ptr = param)
            {
                SamplerParameteriv(sampler, pname, param_ptr);
            }
        }
        /// <inheritdoc cref="SamplerParameteriv(int, SamplerParameterI, int*)"/>
        public static unsafe void SamplerParameteri(int sampler, SamplerParameterI pname, in int param)
        {
            fixed (int* param_ptr = &param)
            {
                SamplerParameteriv(sampler, pname, param_ptr);
            }
        }
        /// <inheritdoc cref="SamplerParameterfv(int, SamplerParameterF, float*)"/>
        public static unsafe void SamplerParameterf(int sampler, SamplerParameterF pname, ReadOnlySpan<float> param)
        {
            fixed (float* param_ptr = param)
            {
                SamplerParameterfv(sampler, pname, param_ptr);
            }
        }
        /// <inheritdoc cref="SamplerParameterfv(int, SamplerParameterF, float*)"/>
        public static unsafe void SamplerParameterf(int sampler, SamplerParameterF pname, float[] param)
        {
            fixed (float* param_ptr = param)
            {
                SamplerParameterfv(sampler, pname, param_ptr);
            }
        }
        /// <inheritdoc cref="SamplerParameterfv(int, SamplerParameterF, float*)"/>
        public static unsafe void SamplerParameterf(int sampler, SamplerParameterF pname, in float param)
        {
            fixed (float* param_ptr = &param)
            {
                SamplerParameterfv(sampler, pname, param_ptr);
            }
        }
        /// <inheritdoc cref="GetSamplerParameteriv(int, SamplerParameterI, int*)"/>
        public static unsafe void GetSamplerParameteri(int sampler, SamplerParameterI pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetSamplerParameteriv(sampler, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetSamplerParameteriv(int, SamplerParameterI, int*)"/>
        public static unsafe void GetSamplerParameteri(int sampler, SamplerParameterI pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetSamplerParameteriv(sampler, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetSamplerParameteriv(int, SamplerParameterI, int*)"/>
        public static unsafe void GetSamplerParameteri(int sampler, SamplerParameterI pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetSamplerParameteriv(sampler, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetSamplerParameterfv(int, SamplerParameterF, float*)"/>
        public static unsafe void GetSamplerParameterf(int sampler, SamplerParameterF pname, Span<float> parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetSamplerParameterfv(sampler, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetSamplerParameterfv(int, SamplerParameterF, float*)"/>
        public static unsafe void GetSamplerParameterf(int sampler, SamplerParameterF pname, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetSamplerParameterfv(sampler, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetSamplerParameterfv(int, SamplerParameterF, float*)"/>
        public static unsafe void GetSamplerParameterf(int sampler, SamplerParameterF pname, ref float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                GetSamplerParameterfv(sampler, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="DeleteTransformFeedbacks(int, int*)"/>
        public static unsafe void DeleteTransformFeedback(in int id)
        {
            int n = 1;
            fixed(int* ids_handle = &id)
            {
                DeleteTransformFeedbacks(n, ids_handle);
            }
        }
        /// <inheritdoc cref="DeleteTransformFeedbacks(int, int*)"/>
        public static unsafe void DeleteTransformFeedbacks(ReadOnlySpan<int> ids)
        {
            int n = (int)(ids.Length);
            fixed (int* ids_ptr = ids)
            {
                DeleteTransformFeedbacks(n, ids_ptr);
            }
        }
        /// <inheritdoc cref="DeleteTransformFeedbacks(int, int*)"/>
        public static unsafe void DeleteTransformFeedbacks(int[] ids)
        {
            int n = (int)(ids.Length);
            fixed (int* ids_ptr = ids)
            {
                DeleteTransformFeedbacks(n, ids_ptr);
            }
        }
        /// <inheritdoc cref="DeleteTransformFeedbacks(int, int*)"/>
        public static unsafe void DeleteTransformFeedbacks(int n, in int ids)
        {
            fixed (int* ids_ptr = &ids)
            {
                DeleteTransformFeedbacks(n, ids_ptr);
            }
        }
        /// <inheritdoc cref="GenTransformFeedbacks(int, int*)"/>
        public static unsafe int GenTransformFeedback()
        {
            int id;
            int n = 1;
            Unsafe.SkipInit(out id);
            // FIXME: This could be a problem for the overloads that take an out parameter
            // as this parameter could *potentially* move while inside of this function
            // which would mean that the new value never gets written to the out parameter.
            // Making for a nasty bug.
            // The reason we don't use a fixed expression here is because of the "single out parameter to return value" overloading step
            // that will make it so this tries to fix a local variable which is not allowed in C# for some reason.
            // If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk
            // - 2021-05-18
            int* ids_handle = (int*)Unsafe.AsPointer(ref id);
            GenTransformFeedbacks(n, ids_handle);
            return id;
        }
        /// <inheritdoc cref="GenTransformFeedbacks(int, int*)"/>
        public static unsafe void GenTransformFeedback(out int id)
        {
            int n = 1;
            Unsafe.SkipInit(out id);
            // FIXME: This could be a problem for the overloads that take an out parameter
            // as this parameter could *potentially* move while inside of this function
            // which would mean that the new value never gets written to the out parameter.
            // Making for a nasty bug.
            // The reason we don't use a fixed expression here is because of the "single out parameter to return value" overloading step
            // that will make it so this tries to fix a local variable which is not allowed in C# for some reason.
            // If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk
            // - 2021-05-18
            int* ids_handle = (int*)Unsafe.AsPointer(ref id);
            GenTransformFeedbacks(n, ids_handle);
        }
        /// <inheritdoc cref="GenTransformFeedbacks(int, int*)"/>
        public static unsafe void GenTransformFeedbacks(Span<int> ids)
        {
            int n = (int)(ids.Length);
            fixed (int* ids_ptr = ids)
            {
                GenTransformFeedbacks(n, ids_ptr);
            }
        }
        /// <inheritdoc cref="GenTransformFeedbacks(int, int*)"/>
        public static unsafe void GenTransformFeedbacks(int[] ids)
        {
            int n = (int)(ids.Length);
            fixed (int* ids_ptr = ids)
            {
                GenTransformFeedbacks(n, ids_ptr);
            }
        }
        /// <inheritdoc cref="GenTransformFeedbacks(int, int*)"/>
        public static unsafe void GenTransformFeedbacks(int n, ref int ids)
        {
            fixed (int* ids_ptr = &ids)
            {
                GenTransformFeedbacks(n, ids_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramBinary(int, int, int*, All*, void*)"/>
        public static unsafe void GetProgramBinary(int program, int bufSize, Span<int> length, Span<All> binaryFormat, IntPtr binary)
        {
            fixed (int* length_ptr = length)
            {
                fixed (All* binaryFormat_ptr = binaryFormat)
                {
                    void* binary_vptr = (void*)binary;
                    GetProgramBinary(program, bufSize, length_ptr, binaryFormat_ptr, binary_vptr);
                }
            }
        }
        /// <inheritdoc cref="GetProgramBinary(int, int, int*, All*, void*)"/>
        public static unsafe void GetProgramBinary(int program, int bufSize, int[] length, All[] binaryFormat, IntPtr binary)
        {
            fixed (int* length_ptr = length)
            {
                fixed (All* binaryFormat_ptr = binaryFormat)
                {
                    void* binary_vptr = (void*)binary;
                    GetProgramBinary(program, bufSize, length_ptr, binaryFormat_ptr, binary_vptr);
                }
            }
        }
        /// <inheritdoc cref="GetProgramBinary(int, int, int*, All*, void*)"/>
        public static unsafe void GetProgramBinary(int program, int bufSize, ref int length, ref All binaryFormat, IntPtr binary)
        {
            fixed (int* length_ptr = &length)
            fixed (All* binaryFormat_ptr = &binaryFormat)
            {
                void* binary_vptr = (void*)binary;
                GetProgramBinary(program, bufSize, length_ptr, binaryFormat_ptr, binary_vptr);
            }
        }
        /// <inheritdoc cref="GetProgramBinary(int, int, int*, All*, void*)"/>
        public static unsafe void GetProgramBinary<T1>(int program, Span<int> length, Span<All> binaryFormat, Span<T1> binary)
            where T1 : unmanaged
        {
            fixed (int* length_ptr = length)
            {
                fixed (All* binaryFormat_ptr = binaryFormat)
                {
                    int bufSize = (int)(binary.Length * sizeof(T1));
                    fixed (void* binary_ptr = binary)
                    {
                        GetProgramBinary(program, bufSize, length_ptr, binaryFormat_ptr, binary_ptr);
                    }
                }
            }
        }
        /// <inheritdoc cref="GetProgramBinary(int, int, int*, All*, void*)"/>
        public static unsafe void GetProgramBinary<T1>(int program, int[] length, All[] binaryFormat, T1[] binary)
            where T1 : unmanaged
        {
            fixed (int* length_ptr = length)
            {
                fixed (All* binaryFormat_ptr = binaryFormat)
                {
                    int bufSize = (int)(binary.Length * sizeof(T1));
                    fixed (void* binary_ptr = binary)
                    {
                        GetProgramBinary(program, bufSize, length_ptr, binaryFormat_ptr, binary_ptr);
                    }
                }
            }
        }
        /// <inheritdoc cref="GetProgramBinary(int, int, int*, All*, void*)"/>
        public static unsafe void GetProgramBinary<T1>(int program, int bufSize, ref int length, ref All binaryFormat, ref T1 binary)
            where T1 : unmanaged
        {
            fixed (int* length_ptr = &length)
            fixed (All* binaryFormat_ptr = &binaryFormat)
            fixed (void* binary_ptr = &binary)
            {
                GetProgramBinary(program, bufSize, length_ptr, binaryFormat_ptr, binary_ptr);
            }
        }
        /// <inheritdoc cref="ProgramBinary(int, All, void*, int)"/>
        public static unsafe void ProgramBinary(int program, All binaryFormat, IntPtr binary, int length)
        {
            void* binary_vptr = (void*)binary;
            ProgramBinary(program, binaryFormat, binary_vptr, length);
        }
        /// <inheritdoc cref="ProgramBinary(int, All, void*, int)"/>
        public static unsafe void ProgramBinary<T1>(int program, All binaryFormat, ReadOnlySpan<T1> binary)
            where T1 : unmanaged
        {
            int length = (int)(binary.Length * sizeof(T1));
            fixed (void* binary_ptr = binary)
            {
                ProgramBinary(program, binaryFormat, binary_ptr, length);
            }
        }
        /// <inheritdoc cref="ProgramBinary(int, All, void*, int)"/>
        public static unsafe void ProgramBinary<T1>(int program, All binaryFormat, T1[] binary)
            where T1 : unmanaged
        {
            int length = (int)(binary.Length * sizeof(T1));
            fixed (void* binary_ptr = binary)
            {
                ProgramBinary(program, binaryFormat, binary_ptr, length);
            }
        }
        /// <inheritdoc cref="ProgramBinary(int, All, void*, int)"/>
        public static unsafe void ProgramBinary<T1>(int program, All binaryFormat, in T1 binary, int length)
            where T1 : unmanaged
        {
            fixed (void* binary_ptr = &binary)
            {
                ProgramBinary(program, binaryFormat, binary_ptr, length);
            }
        }
        /// <inheritdoc cref="InvalidateFramebuffer(FramebufferTarget, int, InvalidateFramebufferAttachment*)"/>
        public static unsafe void InvalidateFramebuffer(FramebufferTarget target, ReadOnlySpan<InvalidateFramebufferAttachment> attachments)
        {
            int numAttachments = (int)(attachments.Length);
            fixed (InvalidateFramebufferAttachment* attachments_ptr = attachments)
            {
                InvalidateFramebuffer(target, numAttachments, attachments_ptr);
            }
        }
        /// <inheritdoc cref="InvalidateFramebuffer(FramebufferTarget, int, InvalidateFramebufferAttachment*)"/>
        public static unsafe void InvalidateFramebuffer(FramebufferTarget target, InvalidateFramebufferAttachment[] attachments)
        {
            int numAttachments = (int)(attachments.Length);
            fixed (InvalidateFramebufferAttachment* attachments_ptr = attachments)
            {
                InvalidateFramebuffer(target, numAttachments, attachments_ptr);
            }
        }
        /// <inheritdoc cref="InvalidateFramebuffer(FramebufferTarget, int, InvalidateFramebufferAttachment*)"/>
        public static unsafe void InvalidateFramebuffer(FramebufferTarget target, int numAttachments, in InvalidateFramebufferAttachment attachments)
        {
            fixed (InvalidateFramebufferAttachment* attachments_ptr = &attachments)
            {
                InvalidateFramebuffer(target, numAttachments, attachments_ptr);
            }
        }
        /// <inheritdoc cref="InvalidateSubFramebuffer(FramebufferTarget, int, InvalidateFramebufferAttachment*, int, int, int, int)"/>
        public static unsafe void InvalidateSubFramebuffer(FramebufferTarget target, ReadOnlySpan<InvalidateFramebufferAttachment> attachments, int x, int y, int width, int height)
        {
            int numAttachments = (int)(attachments.Length);
            fixed (InvalidateFramebufferAttachment* attachments_ptr = attachments)
            {
                InvalidateSubFramebuffer(target, numAttachments, attachments_ptr, x, y, width, height);
            }
        }
        /// <inheritdoc cref="InvalidateSubFramebuffer(FramebufferTarget, int, InvalidateFramebufferAttachment*, int, int, int, int)"/>
        public static unsafe void InvalidateSubFramebuffer(FramebufferTarget target, InvalidateFramebufferAttachment[] attachments, int x, int y, int width, int height)
        {
            int numAttachments = (int)(attachments.Length);
            fixed (InvalidateFramebufferAttachment* attachments_ptr = attachments)
            {
                InvalidateSubFramebuffer(target, numAttachments, attachments_ptr, x, y, width, height);
            }
        }
        /// <inheritdoc cref="InvalidateSubFramebuffer(FramebufferTarget, int, InvalidateFramebufferAttachment*, int, int, int, int)"/>
        public static unsafe void InvalidateSubFramebuffer(FramebufferTarget target, int numAttachments, in InvalidateFramebufferAttachment attachments, int x, int y, int width, int height)
        {
            fixed (InvalidateFramebufferAttachment* attachments_ptr = &attachments)
            {
                InvalidateSubFramebuffer(target, numAttachments, attachments_ptr, x, y, width, height);
            }
        }
        /// <inheritdoc cref="GetInternalformativ(TextureTarget, InternalFormat, InternalFormatPName, int, int*)"/>
        public static unsafe void GetInternalformati(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, Span<int> parameters)
        {
            int count = (int)(parameters.Length);
            fixed (int* parameters_ptr = parameters)
            {
                GetInternalformativ(target, internalformat, pname, count, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetInternalformativ(TextureTarget, InternalFormat, InternalFormatPName, int, int*)"/>
        public static unsafe void GetInternalformati(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, int[] parameters)
        {
            int count = (int)(parameters.Length);
            fixed (int* parameters_ptr = parameters)
            {
                GetInternalformativ(target, internalformat, pname, count, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetInternalformativ(TextureTarget, InternalFormat, InternalFormatPName, int, int*)"/>
        public static unsafe void GetInternalformati(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, int count, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetInternalformativ(target, internalformat, pname, count, parameters_ptr);
            }
        }
        /// <inheritdoc cref="DrawArraysIndirect(PrimitiveType, void*)"/>
        public static unsafe void DrawArraysIndirect(PrimitiveType mode, IntPtr indirect)
        {
            void* indirect_vptr = (void*)indirect;
            DrawArraysIndirect(mode, indirect_vptr);
        }
        /// <inheritdoc cref="DrawArraysIndirect(PrimitiveType, void*)"/>
        public static unsafe void DrawArraysIndirect<T1>(PrimitiveType mode, in T1 indirect)
            where T1 : unmanaged
        {
            fixed (void* indirect_ptr = &indirect)
            {
                DrawArraysIndirect(mode, indirect_ptr);
            }
        }
        /// <inheritdoc cref="DrawElementsIndirect(PrimitiveType, DrawElementsType, void*)"/>
        public static unsafe void DrawElementsIndirect(PrimitiveType mode, DrawElementsType type, IntPtr indirect)
        {
            void* indirect_vptr = (void*)indirect;
            DrawElementsIndirect(mode, type, indirect_vptr);
        }
        /// <inheritdoc cref="DrawElementsIndirect(PrimitiveType, DrawElementsType, void*)"/>
        public static unsafe void DrawElementsIndirect<T1>(PrimitiveType mode, DrawElementsType type, in T1 indirect)
            where T1 : unmanaged
        {
            fixed (void* indirect_ptr = &indirect)
            {
                DrawElementsIndirect(mode, type, indirect_ptr);
            }
        }
        /// <inheritdoc cref="GetFramebufferParameteriv(FramebufferTarget, FramebufferAttachmentParameterName, int*)"/>
        public static unsafe void GetFramebufferParameteri(FramebufferTarget target, FramebufferAttachmentParameterName pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetFramebufferParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetFramebufferParameteriv(FramebufferTarget, FramebufferAttachmentParameterName, int*)"/>
        public static unsafe void GetFramebufferParameteri(FramebufferTarget target, FramebufferAttachmentParameterName pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetFramebufferParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetFramebufferParameteriv(FramebufferTarget, FramebufferAttachmentParameterName, int*)"/>
        public static unsafe void GetFramebufferParameteri(FramebufferTarget target, FramebufferAttachmentParameterName pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetFramebufferParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramInterfaceiv(int, ProgramInterface, ProgramInterfacePName, int*)"/>
        public static unsafe void GetProgramInterfacei(int program, ProgramInterface programInterface, ProgramInterfacePName pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetProgramInterfaceiv(program, programInterface, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramInterfaceiv(int, ProgramInterface, ProgramInterfacePName, int*)"/>
        public static unsafe void GetProgramInterfacei(int program, ProgramInterface programInterface, ProgramInterfacePName pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetProgramInterfaceiv(program, programInterface, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramInterfaceiv(int, ProgramInterface, ProgramInterfacePName, int*)"/>
        public static unsafe void GetProgramInterfacei(int program, ProgramInterface programInterface, ProgramInterfacePName pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetProgramInterfaceiv(program, programInterface, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramResourceIndex(int, ProgramInterface, byte*)"/>
        public static unsafe uint GetProgramResourceIndex(int program, ProgramInterface programInterface, string name)
        {
            uint returnValue;
            byte* name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(name);
            returnValue = GetProgramResourceIndex(program, programInterface, name_ptr);
            Marshal.FreeCoTaskMem((IntPtr)name_ptr);
            return returnValue;
        }
        /// <inheritdoc cref="GetProgramResourceName(int, ProgramInterface, uint, int, int*, byte*)"/>
        public static unsafe string GetProgramResourceName(int program, ProgramInterface programInterface, uint index, int bufSize, Span<int> length)
        {
            string name;
            fixed (int* length_ptr = length)
            {
                var name_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetProgramResourceName(program, programInterface, index, bufSize, length_ptr, name_ptr);
                name = Marshal.PtrToStringUTF8((IntPtr)name_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)name_ptr);
            }
            return name;
        }
        /// <inheritdoc cref="GetProgramResourceName(int, ProgramInterface, uint, int, int*, byte*)"/>
        public static unsafe void GetProgramResourceName(int program, ProgramInterface programInterface, uint index, int bufSize, Span<int> length, out string name)
        {
            fixed (int* length_ptr = length)
            {
                var name_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetProgramResourceName(program, programInterface, index, bufSize, length_ptr, name_ptr);
                name = Marshal.PtrToStringUTF8((IntPtr)name_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)name_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramResourceName(int, ProgramInterface, uint, int, int*, byte*)"/>
        public static unsafe string GetProgramResourceName(int program, ProgramInterface programInterface, uint index, int bufSize, int[] length)
        {
            string name;
            fixed (int* length_ptr = length)
            {
                var name_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetProgramResourceName(program, programInterface, index, bufSize, length_ptr, name_ptr);
                name = Marshal.PtrToStringUTF8((IntPtr)name_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)name_ptr);
            }
            return name;
        }
        /// <inheritdoc cref="GetProgramResourceName(int, ProgramInterface, uint, int, int*, byte*)"/>
        public static unsafe void GetProgramResourceName(int program, ProgramInterface programInterface, uint index, int bufSize, int[] length, out string name)
        {
            fixed (int* length_ptr = length)
            {
                var name_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetProgramResourceName(program, programInterface, index, bufSize, length_ptr, name_ptr);
                name = Marshal.PtrToStringUTF8((IntPtr)name_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)name_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramResourceName(int, ProgramInterface, uint, int, int*, byte*)"/>
        public static unsafe string GetProgramResourceName(int program, ProgramInterface programInterface, uint index, int bufSize, ref int length)
        {
            string name;
            fixed (int* length_ptr = &length)
            {
                var name_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetProgramResourceName(program, programInterface, index, bufSize, length_ptr, name_ptr);
                name = Marshal.PtrToStringUTF8((IntPtr)name_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)name_ptr);
            }
            return name;
        }
        /// <inheritdoc cref="GetProgramResourceName(int, ProgramInterface, uint, int, int*, byte*)"/>
        public static unsafe void GetProgramResourceName(int program, ProgramInterface programInterface, uint index, int bufSize, ref int length, out string name)
        {
            fixed (int* length_ptr = &length)
            {
                var name_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetProgramResourceName(program, programInterface, index, bufSize, length_ptr, name_ptr);
                name = Marshal.PtrToStringUTF8((IntPtr)name_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)name_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramResourceiv(int, ProgramInterface, uint, int, ProgramResourceProperty*, int, int*, int*)"/>
        public static unsafe void GetProgramResourcei(int program, ProgramInterface programInterface, uint index, ReadOnlySpan<ProgramResourceProperty> props, Span<int> length, Span<int> parameters)
        {
            int propCount = (int)(props.Length);
            fixed (ProgramResourceProperty* props_ptr = props)
            {
                fixed (int* length_ptr = length)
                {
                    int count = (int)(parameters.Length);
                    fixed (int* parameters_ptr = parameters)
                    {
                        GetProgramResourceiv(program, programInterface, index, propCount, props_ptr, count, length_ptr, parameters_ptr);
                    }
                }
            }
        }
        /// <inheritdoc cref="GetProgramResourceiv(int, ProgramInterface, uint, int, ProgramResourceProperty*, int, int*, int*)"/>
        public static unsafe void GetProgramResourcei(int program, ProgramInterface programInterface, uint index, ProgramResourceProperty[] props, int[] length, int[] parameters)
        {
            int propCount = (int)(props.Length);
            fixed (ProgramResourceProperty* props_ptr = props)
            {
                fixed (int* length_ptr = length)
                {
                    int count = (int)(parameters.Length);
                    fixed (int* parameters_ptr = parameters)
                    {
                        GetProgramResourceiv(program, programInterface, index, propCount, props_ptr, count, length_ptr, parameters_ptr);
                    }
                }
            }
        }
        /// <inheritdoc cref="GetProgramResourceiv(int, ProgramInterface, uint, int, ProgramResourceProperty*, int, int*, int*)"/>
        public static unsafe void GetProgramResourcei(int program, ProgramInterface programInterface, uint index, int propCount, in ProgramResourceProperty props, int count, ref int length, ref int parameters)
        {
            fixed (ProgramResourceProperty* props_ptr = &props)
            fixed (int* length_ptr = &length)
            fixed (int* parameters_ptr = &parameters)
            {
                GetProgramResourceiv(program, programInterface, index, propCount, props_ptr, count, length_ptr, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramResourceLocation(int, ProgramInterface, byte*)"/>
        public static unsafe int GetProgramResourceLocation(int program, ProgramInterface programInterface, string name)
        {
            int returnValue;
            byte* name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(name);
            returnValue = GetProgramResourceLocation(program, programInterface, name_ptr);
            Marshal.FreeCoTaskMem((IntPtr)name_ptr);
            return returnValue;
        }
        /// <inheritdoc cref="CreateShaderProgramv(ShaderType, int, byte**)"/>
        public static unsafe int CreateShaderProgram(ShaderType type, int count, byte** strings)
        {
            int returnValue;
            returnValue = CreateShaderProgramv(type, count, strings);
            return returnValue;
        }
        /// <inheritdoc cref="DeleteProgramPipelines(int, int*)"/>
        public static unsafe void DeleteProgramPipeline(in int pipeline)
        {
            int n = 1;
            fixed(int* pipelines_handle = &pipeline)
            {
                DeleteProgramPipelines(n, pipelines_handle);
            }
        }
        /// <inheritdoc cref="DeleteProgramPipelines(int, int*)"/>
        public static unsafe void DeleteProgramPipelines(ReadOnlySpan<int> pipelines)
        {
            int n = (int)(pipelines.Length);
            fixed (int* pipelines_ptr = pipelines)
            {
                DeleteProgramPipelines(n, pipelines_ptr);
            }
        }
        /// <inheritdoc cref="DeleteProgramPipelines(int, int*)"/>
        public static unsafe void DeleteProgramPipelines(int[] pipelines)
        {
            int n = (int)(pipelines.Length);
            fixed (int* pipelines_ptr = pipelines)
            {
                DeleteProgramPipelines(n, pipelines_ptr);
            }
        }
        /// <inheritdoc cref="DeleteProgramPipelines(int, int*)"/>
        public static unsafe void DeleteProgramPipelines(int n, in int pipelines)
        {
            fixed (int* pipelines_ptr = &pipelines)
            {
                DeleteProgramPipelines(n, pipelines_ptr);
            }
        }
        /// <inheritdoc cref="GenProgramPipelines(int, int*)"/>
        public static unsafe int GenProgramPipeline()
        {
            int pipeline;
            int n = 1;
            Unsafe.SkipInit(out pipeline);
            // FIXME: This could be a problem for the overloads that take an out parameter
            // as this parameter could *potentially* move while inside of this function
            // which would mean that the new value never gets written to the out parameter.
            // Making for a nasty bug.
            // The reason we don't use a fixed expression here is because of the "single out parameter to return value" overloading step
            // that will make it so this tries to fix a local variable which is not allowed in C# for some reason.
            // If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk
            // - 2021-05-18
            int* pipelines_handle = (int*)Unsafe.AsPointer(ref pipeline);
            GenProgramPipelines(n, pipelines_handle);
            return pipeline;
        }
        /// <inheritdoc cref="GenProgramPipelines(int, int*)"/>
        public static unsafe void GenProgramPipeline(out int pipeline)
        {
            int n = 1;
            Unsafe.SkipInit(out pipeline);
            // FIXME: This could be a problem for the overloads that take an out parameter
            // as this parameter could *potentially* move while inside of this function
            // which would mean that the new value never gets written to the out parameter.
            // Making for a nasty bug.
            // The reason we don't use a fixed expression here is because of the "single out parameter to return value" overloading step
            // that will make it so this tries to fix a local variable which is not allowed in C# for some reason.
            // If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk
            // - 2021-05-18
            int* pipelines_handle = (int*)Unsafe.AsPointer(ref pipeline);
            GenProgramPipelines(n, pipelines_handle);
        }
        /// <inheritdoc cref="GenProgramPipelines(int, int*)"/>
        public static unsafe void GenProgramPipelines(Span<int> pipelines)
        {
            int n = (int)(pipelines.Length);
            fixed (int* pipelines_ptr = pipelines)
            {
                GenProgramPipelines(n, pipelines_ptr);
            }
        }
        /// <inheritdoc cref="GenProgramPipelines(int, int*)"/>
        public static unsafe void GenProgramPipelines(int[] pipelines)
        {
            int n = (int)(pipelines.Length);
            fixed (int* pipelines_ptr = pipelines)
            {
                GenProgramPipelines(n, pipelines_ptr);
            }
        }
        /// <inheritdoc cref="GenProgramPipelines(int, int*)"/>
        public static unsafe void GenProgramPipelines(int n, ref int pipelines)
        {
            fixed (int* pipelines_ptr = &pipelines)
            {
                GenProgramPipelines(n, pipelines_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramPipelineiv(int, PipelineParameterName, int*)"/>
        public static unsafe void GetProgramPipelinei(int pipeline, PipelineParameterName pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetProgramPipelineiv(pipeline, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramPipelineiv(int, PipelineParameterName, int*)"/>
        public static unsafe void GetProgramPipelinei(int pipeline, PipelineParameterName pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetProgramPipelineiv(pipeline, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramPipelineiv(int, PipelineParameterName, int*)"/>
        public static unsafe void GetProgramPipelinei(int pipeline, PipelineParameterName pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetProgramPipelineiv(pipeline, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform1iv(int, int, int, int*)"/>
        public static unsafe void ProgramUniform1i(int program, int location, int count, in int value)
        {
            fixed (int* tmp_value = &value)
            {
                int* value_ptr = (int*)tmp_value;
                ProgramUniform1iv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform2iv(int, int, int, int*)"/>
        public static unsafe void ProgramUniform2i(int program, int location, int count, in Vector2i value)
        {
            fixed (Vector2i* tmp_value = &value)
            {
                int* value_ptr = (int*)tmp_value;
                ProgramUniform2iv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform2iv(int, int, int, int*)"/>
        public static unsafe void ProgramUniform2i(int program, int location, int count, ReadOnlySpan<Vector2i> value)
        {
            fixed (Vector2i* tmp_value = value)
            {
                int* value_ptr = (int*)tmp_value;
                ProgramUniform2iv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform2iv(int, int, int, int*)"/>
        public static unsafe void ProgramUniform2i(int program, int location, int count, Vector2i[] value)
        {
            fixed (Vector2i* tmp_value = value)
            {
                int* value_ptr = (int*)tmp_value;
                ProgramUniform2iv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform3iv(int, int, int, int*)"/>
        public static unsafe void ProgramUniform3i(int program, int location, int count, in Vector3i value)
        {
            fixed (Vector3i* tmp_value = &value)
            {
                int* value_ptr = (int*)tmp_value;
                ProgramUniform3iv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform3iv(int, int, int, int*)"/>
        public static unsafe void ProgramUniform3i(int program, int location, int count, ReadOnlySpan<Vector3i> value)
        {
            fixed (Vector3i* tmp_value = value)
            {
                int* value_ptr = (int*)tmp_value;
                ProgramUniform3iv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform3iv(int, int, int, int*)"/>
        public static unsafe void ProgramUniform3i(int program, int location, int count, Vector3i[] value)
        {
            fixed (Vector3i* tmp_value = value)
            {
                int* value_ptr = (int*)tmp_value;
                ProgramUniform3iv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform4iv(int, int, int, int*)"/>
        public static unsafe void ProgramUniform4i(int program, int location, int count, in Vector4i value)
        {
            fixed (Vector4i* tmp_value = &value)
            {
                int* value_ptr = (int*)tmp_value;
                ProgramUniform4iv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform4iv(int, int, int, int*)"/>
        public static unsafe void ProgramUniform4i(int program, int location, int count, ReadOnlySpan<Vector4i> value)
        {
            fixed (Vector4i* tmp_value = value)
            {
                int* value_ptr = (int*)tmp_value;
                ProgramUniform4iv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform4iv(int, int, int, int*)"/>
        public static unsafe void ProgramUniform4i(int program, int location, int count, Vector4i[] value)
        {
            fixed (Vector4i* tmp_value = value)
            {
                int* value_ptr = (int*)tmp_value;
                ProgramUniform4iv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform1uiv(int, int, int, uint*)"/>
        public static unsafe void ProgramUniform1ui(int program, int location, int count, in uint value)
        {
            fixed (uint* tmp_value = &value)
            {
                uint* value_ptr = (uint*)tmp_value;
                ProgramUniform1uiv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform2uiv(int, int, int, uint*)"/>
        public static unsafe void ProgramUniform2ui(int program, int location, int count, in Vector2i value)
        {
            fixed (Vector2i* tmp_value = &value)
            {
                uint* value_ptr = (uint*)tmp_value;
                ProgramUniform2uiv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform2uiv(int, int, int, uint*)"/>
        public static unsafe void ProgramUniform2ui(int program, int location, int count, ReadOnlySpan<Vector2i> value)
        {
            fixed (Vector2i* tmp_value = value)
            {
                uint* value_ptr = (uint*)tmp_value;
                ProgramUniform2uiv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform2uiv(int, int, int, uint*)"/>
        public static unsafe void ProgramUniform2ui(int program, int location, int count, Vector2i[] value)
        {
            fixed (Vector2i* tmp_value = value)
            {
                uint* value_ptr = (uint*)tmp_value;
                ProgramUniform2uiv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform3uiv(int, int, int, uint*)"/>
        public static unsafe void ProgramUniform3ui(int program, int location, int count, in Vector3i value)
        {
            fixed (Vector3i* tmp_value = &value)
            {
                uint* value_ptr = (uint*)tmp_value;
                ProgramUniform3uiv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform3uiv(int, int, int, uint*)"/>
        public static unsafe void ProgramUniform3ui(int program, int location, int count, ReadOnlySpan<Vector3i> value)
        {
            fixed (Vector3i* tmp_value = value)
            {
                uint* value_ptr = (uint*)tmp_value;
                ProgramUniform3uiv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform3uiv(int, int, int, uint*)"/>
        public static unsafe void ProgramUniform3ui(int program, int location, int count, Vector3i[] value)
        {
            fixed (Vector3i* tmp_value = value)
            {
                uint* value_ptr = (uint*)tmp_value;
                ProgramUniform3uiv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform4uiv(int, int, int, uint*)"/>
        public static unsafe void ProgramUniform4ui(int program, int location, int count, in Vector4i value)
        {
            fixed (Vector4i* tmp_value = &value)
            {
                uint* value_ptr = (uint*)tmp_value;
                ProgramUniform4uiv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform4uiv(int, int, int, uint*)"/>
        public static unsafe void ProgramUniform4ui(int program, int location, int count, ReadOnlySpan<Vector4i> value)
        {
            fixed (Vector4i* tmp_value = value)
            {
                uint* value_ptr = (uint*)tmp_value;
                ProgramUniform4uiv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform4uiv(int, int, int, uint*)"/>
        public static unsafe void ProgramUniform4ui(int program, int location, int count, Vector4i[] value)
        {
            fixed (Vector4i* tmp_value = value)
            {
                uint* value_ptr = (uint*)tmp_value;
                ProgramUniform4uiv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform1fv(int, int, int, float*)"/>
        public static unsafe void ProgramUniform1f(int program, int location, int count, in float value)
        {
            fixed (float* tmp_value = &value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniform1fv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform2fv(int, int, int, float*)"/>
        public static unsafe void ProgramUniform2f(int program, int location, int count, in Vector2 value)
        {
            fixed (Vector2* tmp_value = &value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniform2fv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform2fv(int, int, int, float*)"/>
        public static unsafe void ProgramUniform2f(int program, int location, int count, ReadOnlySpan<Vector2> value)
        {
            fixed (Vector2* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniform2fv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform2fv(int, int, int, float*)"/>
        public static unsafe void ProgramUniform2f(int program, int location, int count, Vector2[] value)
        {
            fixed (Vector2* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniform2fv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform2fv(int, int, int, float*)"/>
        public static unsafe void ProgramUniform2f(int program, int location, int count, in System.Numerics.Vector2 value)
        {
            fixed (System.Numerics.Vector2* tmp_value = &value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniform2fv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform2fv(int, int, int, float*)"/>
        public static unsafe void ProgramUniform2f(int program, int location, int count, ReadOnlySpan<System.Numerics.Vector2> value)
        {
            fixed (System.Numerics.Vector2* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniform2fv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform2fv(int, int, int, float*)"/>
        public static unsafe void ProgramUniform2f(int program, int location, int count, System.Numerics.Vector2[] value)
        {
            fixed (System.Numerics.Vector2* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniform2fv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform3fv(int, int, int, float*)"/>
        public static unsafe void ProgramUniform3f(int program, int location, int count, in Vector3 value)
        {
            fixed (Vector3* tmp_value = &value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniform3fv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform3fv(int, int, int, float*)"/>
        public static unsafe void ProgramUniform3f(int program, int location, int count, ReadOnlySpan<Vector3> value)
        {
            fixed (Vector3* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniform3fv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform3fv(int, int, int, float*)"/>
        public static unsafe void ProgramUniform3f(int program, int location, int count, Vector3[] value)
        {
            fixed (Vector3* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniform3fv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform3fv(int, int, int, float*)"/>
        public static unsafe void ProgramUniform3f(int program, int location, int count, in System.Numerics.Vector3 value)
        {
            fixed (System.Numerics.Vector3* tmp_value = &value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniform3fv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform3fv(int, int, int, float*)"/>
        public static unsafe void ProgramUniform3f(int program, int location, int count, ReadOnlySpan<System.Numerics.Vector3> value)
        {
            fixed (System.Numerics.Vector3* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniform3fv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform3fv(int, int, int, float*)"/>
        public static unsafe void ProgramUniform3f(int program, int location, int count, System.Numerics.Vector3[] value)
        {
            fixed (System.Numerics.Vector3* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniform3fv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform4fv(int, int, int, float*)"/>
        public static unsafe void ProgramUniform4f(int program, int location, int count, in Vector4 value)
        {
            fixed (Vector4* tmp_value = &value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniform4fv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform4fv(int, int, int, float*)"/>
        public static unsafe void ProgramUniform4f(int program, int location, int count, ReadOnlySpan<Vector4> value)
        {
            fixed (Vector4* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniform4fv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform4fv(int, int, int, float*)"/>
        public static unsafe void ProgramUniform4f(int program, int location, int count, Vector4[] value)
        {
            fixed (Vector4* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniform4fv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform4fv(int, int, int, float*)"/>
        public static unsafe void ProgramUniform4f(int program, int location, int count, in System.Numerics.Vector4 value)
        {
            fixed (System.Numerics.Vector4* tmp_value = &value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniform4fv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform4fv(int, int, int, float*)"/>
        public static unsafe void ProgramUniform4f(int program, int location, int count, ReadOnlySpan<System.Numerics.Vector4> value)
        {
            fixed (System.Numerics.Vector4* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniform4fv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform4fv(int, int, int, float*)"/>
        public static unsafe void ProgramUniform4f(int program, int location, int count, System.Numerics.Vector4[] value)
        {
            fixed (System.Numerics.Vector4* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniform4fv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix2fv(int, int, int, bool, float*)"/>
        public static unsafe void ProgramUniformMatrix2f(int program, int location, int count, bool transpose, in Matrix2 value)
        {
            fixed (Matrix2* tmp_value = &value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniformMatrix2fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix2fv(int, int, int, bool, float*)"/>
        public static unsafe void ProgramUniformMatrix2f(int program, int location, int count, bool transpose, ReadOnlySpan<Matrix2> value)
        {
            fixed (Matrix2* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniformMatrix2fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix2fv(int, int, int, bool, float*)"/>
        public static unsafe void ProgramUniformMatrix2f(int program, int location, int count, bool transpose, Matrix2[] value)
        {
            fixed (Matrix2* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniformMatrix2fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix3fv(int, int, int, bool, float*)"/>
        public static unsafe void ProgramUniformMatrix3f(int program, int location, int count, bool transpose, in Matrix3 value)
        {
            fixed (Matrix3* tmp_value = &value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniformMatrix3fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix3fv(int, int, int, bool, float*)"/>
        public static unsafe void ProgramUniformMatrix3f(int program, int location, int count, bool transpose, ReadOnlySpan<Matrix3> value)
        {
            fixed (Matrix3* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniformMatrix3fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix3fv(int, int, int, bool, float*)"/>
        public static unsafe void ProgramUniformMatrix3f(int program, int location, int count, bool transpose, Matrix3[] value)
        {
            fixed (Matrix3* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniformMatrix3fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix4fv(int, int, int, bool, float*)"/>
        public static unsafe void ProgramUniformMatrix4f(int program, int location, int count, bool transpose, in Matrix4 value)
        {
            fixed (Matrix4* tmp_value = &value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniformMatrix4fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix4fv(int, int, int, bool, float*)"/>
        public static unsafe void ProgramUniformMatrix4f(int program, int location, int count, bool transpose, ReadOnlySpan<Matrix4> value)
        {
            fixed (Matrix4* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniformMatrix4fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix4fv(int, int, int, bool, float*)"/>
        public static unsafe void ProgramUniformMatrix4f(int program, int location, int count, bool transpose, Matrix4[] value)
        {
            fixed (Matrix4* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniformMatrix4fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix4fv(int, int, int, bool, float*)"/>
        public static unsafe void ProgramUniformMatrix4f(int program, int location, int count, bool transpose, in System.Numerics.Matrix4x4 value)
        {
            fixed (System.Numerics.Matrix4x4* tmp_value = &value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniformMatrix4fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix4fv(int, int, int, bool, float*)"/>
        public static unsafe void ProgramUniformMatrix4f(int program, int location, int count, bool transpose, ReadOnlySpan<System.Numerics.Matrix4x4> value)
        {
            fixed (System.Numerics.Matrix4x4* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniformMatrix4fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix4fv(int, int, int, bool, float*)"/>
        public static unsafe void ProgramUniformMatrix4f(int program, int location, int count, bool transpose, System.Numerics.Matrix4x4[] value)
        {
            fixed (System.Numerics.Matrix4x4* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniformMatrix4fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix2x3fv(int, int, int, bool, float*)"/>
        public static unsafe void ProgramUniformMatrix2x3f(int program, int location, int count, bool transpose, in Matrix2x3 value)
        {
            fixed (Matrix2x3* tmp_value = &value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniformMatrix2x3fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix2x3fv(int, int, int, bool, float*)"/>
        public static unsafe void ProgramUniformMatrix2x3f(int program, int location, int count, bool transpose, ReadOnlySpan<Matrix2x3> value)
        {
            fixed (Matrix2x3* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniformMatrix2x3fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix2x3fv(int, int, int, bool, float*)"/>
        public static unsafe void ProgramUniformMatrix2x3f(int program, int location, int count, bool transpose, Matrix2x3[] value)
        {
            fixed (Matrix2x3* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniformMatrix2x3fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix3x2fv(int, int, int, bool, float*)"/>
        public static unsafe void ProgramUniformMatrix3x2f(int program, int location, int count, bool transpose, in Matrix3x2 value)
        {
            fixed (Matrix3x2* tmp_value = &value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniformMatrix3x2fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix3x2fv(int, int, int, bool, float*)"/>
        public static unsafe void ProgramUniformMatrix3x2f(int program, int location, int count, bool transpose, ReadOnlySpan<Matrix3x2> value)
        {
            fixed (Matrix3x2* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniformMatrix3x2fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix3x2fv(int, int, int, bool, float*)"/>
        public static unsafe void ProgramUniformMatrix3x2f(int program, int location, int count, bool transpose, Matrix3x2[] value)
        {
            fixed (Matrix3x2* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniformMatrix3x2fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix3x2fv(int, int, int, bool, float*)"/>
        public static unsafe void ProgramUniformMatrix3x2f(int program, int location, int count, bool transpose, in System.Numerics.Matrix3x2 value)
        {
            fixed (System.Numerics.Matrix3x2* tmp_value = &value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniformMatrix3x2fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix3x2fv(int, int, int, bool, float*)"/>
        public static unsafe void ProgramUniformMatrix3x2f(int program, int location, int count, bool transpose, ReadOnlySpan<System.Numerics.Matrix3x2> value)
        {
            fixed (System.Numerics.Matrix3x2* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniformMatrix3x2fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix3x2fv(int, int, int, bool, float*)"/>
        public static unsafe void ProgramUniformMatrix3x2f(int program, int location, int count, bool transpose, System.Numerics.Matrix3x2[] value)
        {
            fixed (System.Numerics.Matrix3x2* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniformMatrix3x2fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix2x4fv(int, int, int, bool, float*)"/>
        public static unsafe void ProgramUniformMatrix2x4f(int program, int location, int count, bool transpose, in Matrix2x4 value)
        {
            fixed (Matrix2x4* tmp_value = &value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniformMatrix2x4fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix2x4fv(int, int, int, bool, float*)"/>
        public static unsafe void ProgramUniformMatrix2x4f(int program, int location, int count, bool transpose, ReadOnlySpan<Matrix2x4> value)
        {
            fixed (Matrix2x4* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniformMatrix2x4fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix2x4fv(int, int, int, bool, float*)"/>
        public static unsafe void ProgramUniformMatrix2x4f(int program, int location, int count, bool transpose, Matrix2x4[] value)
        {
            fixed (Matrix2x4* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniformMatrix2x4fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix4x2fv(int, int, int, bool, float*)"/>
        public static unsafe void ProgramUniformMatrix4x2f(int program, int location, int count, bool transpose, in Matrix4x2 value)
        {
            fixed (Matrix4x2* tmp_value = &value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniformMatrix4x2fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix4x2fv(int, int, int, bool, float*)"/>
        public static unsafe void ProgramUniformMatrix4x2f(int program, int location, int count, bool transpose, ReadOnlySpan<Matrix4x2> value)
        {
            fixed (Matrix4x2* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniformMatrix4x2fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix4x2fv(int, int, int, bool, float*)"/>
        public static unsafe void ProgramUniformMatrix4x2f(int program, int location, int count, bool transpose, Matrix4x2[] value)
        {
            fixed (Matrix4x2* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniformMatrix4x2fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix3x4fv(int, int, int, bool, float*)"/>
        public static unsafe void ProgramUniformMatrix3x4f(int program, int location, int count, bool transpose, in Matrix3x4 value)
        {
            fixed (Matrix3x4* tmp_value = &value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniformMatrix3x4fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix3x4fv(int, int, int, bool, float*)"/>
        public static unsafe void ProgramUniformMatrix3x4f(int program, int location, int count, bool transpose, ReadOnlySpan<Matrix3x4> value)
        {
            fixed (Matrix3x4* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniformMatrix3x4fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix3x4fv(int, int, int, bool, float*)"/>
        public static unsafe void ProgramUniformMatrix3x4f(int program, int location, int count, bool transpose, Matrix3x4[] value)
        {
            fixed (Matrix3x4* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniformMatrix3x4fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix4x3fv(int, int, int, bool, float*)"/>
        public static unsafe void ProgramUniformMatrix4x3f(int program, int location, int count, bool transpose, in Matrix4x3 value)
        {
            fixed (Matrix4x3* tmp_value = &value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniformMatrix4x3fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix4x3fv(int, int, int, bool, float*)"/>
        public static unsafe void ProgramUniformMatrix4x3f(int program, int location, int count, bool transpose, ReadOnlySpan<Matrix4x3> value)
        {
            fixed (Matrix4x3* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniformMatrix4x3fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix4x3fv(int, int, int, bool, float*)"/>
        public static unsafe void ProgramUniformMatrix4x3f(int program, int location, int count, bool transpose, Matrix4x3[] value)
        {
            fixed (Matrix4x3* tmp_value = value)
            {
                float* value_ptr = (float*)tmp_value;
                ProgramUniformMatrix4x3fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramPipelineInfoLog(int, int, int*, byte*)"/>
        public static unsafe string GetProgramPipelineInfoLog(int pipeline, int bufSize, Span<int> length)
        {
            string infoLog;
            fixed (int* length_ptr = length)
            {
                var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetProgramPipelineInfoLog(pipeline, bufSize, length_ptr, infoLog_ptr);
                infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
            }
            return infoLog;
        }
        /// <inheritdoc cref="GetProgramPipelineInfoLog(int, int, int*, byte*)"/>
        public static unsafe void GetProgramPipelineInfoLog(int pipeline, int bufSize, Span<int> length, out string infoLog)
        {
            fixed (int* length_ptr = length)
            {
                var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetProgramPipelineInfoLog(pipeline, bufSize, length_ptr, infoLog_ptr);
                infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramPipelineInfoLog(int, int, int*, byte*)"/>
        public static unsafe string GetProgramPipelineInfoLog(int pipeline, int bufSize, int[] length)
        {
            string infoLog;
            fixed (int* length_ptr = length)
            {
                var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetProgramPipelineInfoLog(pipeline, bufSize, length_ptr, infoLog_ptr);
                infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
            }
            return infoLog;
        }
        /// <inheritdoc cref="GetProgramPipelineInfoLog(int, int, int*, byte*)"/>
        public static unsafe void GetProgramPipelineInfoLog(int pipeline, int bufSize, int[] length, out string infoLog)
        {
            fixed (int* length_ptr = length)
            {
                var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetProgramPipelineInfoLog(pipeline, bufSize, length_ptr, infoLog_ptr);
                infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramPipelineInfoLog(int, int, int*, byte*)"/>
        public static unsafe string GetProgramPipelineInfoLog(int pipeline, int bufSize, ref int length)
        {
            string infoLog;
            fixed (int* length_ptr = &length)
            {
                var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetProgramPipelineInfoLog(pipeline, bufSize, length_ptr, infoLog_ptr);
                infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
            }
            return infoLog;
        }
        /// <inheritdoc cref="GetProgramPipelineInfoLog(int, int, int*, byte*)"/>
        public static unsafe void GetProgramPipelineInfoLog(int pipeline, int bufSize, ref int length, out string infoLog)
        {
            fixed (int* length_ptr = &length)
            {
                var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetProgramPipelineInfoLog(pipeline, bufSize, length_ptr, infoLog_ptr);
                infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
            }
        }
        /// <inheritdoc cref="GetBooleani_v(BufferTargetARB, uint, bool*)"/>
        public static unsafe void GetBoolean(BufferTargetARB target, uint index, Span<bool> data)
        {
            fixed (bool* data_ptr = data)
            {
                GetBooleani_v(target, index, data_ptr);
            }
        }
        /// <inheritdoc cref="GetBooleani_v(BufferTargetARB, uint, bool*)"/>
        public static unsafe void GetBoolean(BufferTargetARB target, uint index, bool[] data)
        {
            fixed (bool* data_ptr = data)
            {
                GetBooleani_v(target, index, data_ptr);
            }
        }
        /// <inheritdoc cref="GetBooleani_v(BufferTargetARB, uint, bool*)"/>
        public static unsafe void GetBoolean(BufferTargetARB target, uint index, ref bool data)
        {
            fixed (bool* data_ptr = &data)
            {
                GetBooleani_v(target, index, data_ptr);
            }
        }
        /// <inheritdoc cref="GetMultisamplefv(GetMultisamplePNameNV, uint, float*)"/>
        public static unsafe void GetMultisamplef(GetMultisamplePNameNV pname, uint index, Span<float> val)
        {
            fixed (float* val_ptr = val)
            {
                GetMultisamplefv(pname, index, val_ptr);
            }
        }
        /// <inheritdoc cref="GetMultisamplefv(GetMultisamplePNameNV, uint, float*)"/>
        public static unsafe void GetMultisamplef(GetMultisamplePNameNV pname, uint index, float[] val)
        {
            fixed (float* val_ptr = val)
            {
                GetMultisamplefv(pname, index, val_ptr);
            }
        }
        /// <inheritdoc cref="GetMultisamplefv(GetMultisamplePNameNV, uint, float*)"/>
        public static unsafe void GetMultisamplef(GetMultisamplePNameNV pname, uint index, ref float val)
        {
            fixed (float* val_ptr = &val)
            {
                GetMultisamplefv(pname, index, val_ptr);
            }
        }
        /// <inheritdoc cref="GetTexLevelParameteriv(TextureTarget, int, GetTextureParameter, int*)"/>
        public static unsafe void GetTexLevelParameteri(TextureTarget target, int level, GetTextureParameter pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetTexLevelParameteriv(target, level, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexLevelParameteriv(TextureTarget, int, GetTextureParameter, int*)"/>
        public static unsafe void GetTexLevelParameteri(TextureTarget target, int level, GetTextureParameter pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetTexLevelParameteriv(target, level, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexLevelParameteriv(TextureTarget, int, GetTextureParameter, int*)"/>
        public static unsafe void GetTexLevelParameteri(TextureTarget target, int level, GetTextureParameter pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetTexLevelParameteriv(target, level, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexLevelParameterfv(TextureTarget, int, GetTextureParameter, float*)"/>
        public static unsafe void GetTexLevelParameterf(TextureTarget target, int level, GetTextureParameter pname, Span<float> parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetTexLevelParameterfv(target, level, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexLevelParameterfv(TextureTarget, int, GetTextureParameter, float*)"/>
        public static unsafe void GetTexLevelParameterf(TextureTarget target, int level, GetTextureParameter pname, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetTexLevelParameterfv(target, level, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexLevelParameterfv(TextureTarget, int, GetTextureParameter, float*)"/>
        public static unsafe void GetTexLevelParameterf(TextureTarget target, int level, GetTextureParameter pname, ref float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                GetTexLevelParameterfv(target, level, pname, parameters_ptr);
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
        /// <inheritdoc cref="DrawElementsBaseVertex(PrimitiveType, int, DrawElementsType, void*, int)"/>
        public static unsafe void DrawElementsBaseVertex(PrimitiveType mode, int count, DrawElementsType type, nint offset, int basevertex)
        {
            void* indices = (void*)offset;
            DrawElementsBaseVertex(mode, count, type, indices, basevertex);
        }
        /// <inheritdoc cref="DrawRangeElementsBaseVertex(PrimitiveType, uint, uint, int, DrawElementsType, void*, int)"/>
        public static unsafe void DrawRangeElementsBaseVertex(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, nint offset, int basevertex)
        {
            void* indices = (void*)offset;
            DrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
        }
        /// <inheritdoc cref="DrawElementsInstancedBaseVertex(PrimitiveType, int, DrawElementsType, void*, int, int)"/>
        public static unsafe void DrawElementsInstancedBaseVertex(PrimitiveType mode, int count, DrawElementsType type, nint offset, int instancecount, int basevertex)
        {
            void* indices = (void*)offset;
            DrawElementsInstancedBaseVertex(mode, count, type, indices, instancecount, basevertex);
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
        public static unsafe void GetnUniformf(int program, int location, Span<float> parameters)
        {
            int bufSize = (int)(parameters.Length * 4);
            fixed (float* parameters_ptr = parameters)
            {
                GetnUniformfv(program, location, bufSize, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetnUniformfv(int, int, int, float*)"/>
        public static unsafe void GetnUniformf(int program, int location, float[] parameters)
        {
            int bufSize = (int)(parameters.Length * 4);
            fixed (float* parameters_ptr = parameters)
            {
                GetnUniformfv(program, location, bufSize, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetnUniformfv(int, int, int, float*)"/>
        public static unsafe void GetnUniformf(int program, int location, int bufSize, ref float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                GetnUniformfv(program, location, bufSize, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetnUniformiv(int, int, int, int*)"/>
        public static unsafe void GetnUniformi(int program, int location, Span<int> parameters)
        {
            int bufSize = (int)(parameters.Length * 4);
            fixed (int* parameters_ptr = parameters)
            {
                GetnUniformiv(program, location, bufSize, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetnUniformiv(int, int, int, int*)"/>
        public static unsafe void GetnUniformi(int program, int location, int[] parameters)
        {
            int bufSize = (int)(parameters.Length * 4);
            fixed (int* parameters_ptr = parameters)
            {
                GetnUniformiv(program, location, bufSize, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetnUniformiv(int, int, int, int*)"/>
        public static unsafe void GetnUniformi(int program, int location, int bufSize, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetnUniformiv(program, location, bufSize, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetnUniformuiv(int, int, int, uint*)"/>
        public static unsafe void GetnUniformui(int program, int location, Span<uint> parameters)
        {
            int bufSize = (int)(parameters.Length * 4);
            fixed (uint* parameters_ptr = parameters)
            {
                GetnUniformuiv(program, location, bufSize, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetnUniformuiv(int, int, int, uint*)"/>
        public static unsafe void GetnUniformui(int program, int location, uint[] parameters)
        {
            int bufSize = (int)(parameters.Length * 4);
            fixed (uint* parameters_ptr = parameters)
            {
                GetnUniformuiv(program, location, bufSize, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetnUniformuiv(int, int, int, uint*)"/>
        public static unsafe void GetnUniformui(int program, int location, int bufSize, ref uint parameters)
        {
            fixed (uint* parameters_ptr = &parameters)
            {
                GetnUniformuiv(program, location, bufSize, parameters_ptr);
            }
        }
        /// <inheritdoc cref="TexParameterIiv(TextureTarget, TextureParameterName, int*)"/>
        public static unsafe void TexParameterIi(TextureTarget target, TextureParameterName pname, ReadOnlySpan<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                TexParameterIiv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="TexParameterIiv(TextureTarget, TextureParameterName, int*)"/>
        public static unsafe void TexParameterIi(TextureTarget target, TextureParameterName pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                TexParameterIiv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="TexParameterIiv(TextureTarget, TextureParameterName, int*)"/>
        public static unsafe void TexParameterIi(TextureTarget target, TextureParameterName pname, in int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                TexParameterIiv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="TexParameterIuiv(TextureTarget, TextureParameterName, uint*)"/>
        public static unsafe void TexParameterIui(TextureTarget target, TextureParameterName pname, ReadOnlySpan<uint> parameters)
        {
            fixed (uint* parameters_ptr = parameters)
            {
                TexParameterIuiv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="TexParameterIuiv(TextureTarget, TextureParameterName, uint*)"/>
        public static unsafe void TexParameterIui(TextureTarget target, TextureParameterName pname, uint[] parameters)
        {
            fixed (uint* parameters_ptr = parameters)
            {
                TexParameterIuiv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="TexParameterIuiv(TextureTarget, TextureParameterName, uint*)"/>
        public static unsafe void TexParameterIui(TextureTarget target, TextureParameterName pname, in uint parameters)
        {
            fixed (uint* parameters_ptr = &parameters)
            {
                TexParameterIuiv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexParameterIiv(TextureTarget, GetTextureParameter, int*)"/>
        public static unsafe void GetTexParameterIi(TextureTarget target, GetTextureParameter pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetTexParameterIiv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexParameterIiv(TextureTarget, GetTextureParameter, int*)"/>
        public static unsafe void GetTexParameterIi(TextureTarget target, GetTextureParameter pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetTexParameterIiv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexParameterIiv(TextureTarget, GetTextureParameter, int*)"/>
        public static unsafe void GetTexParameterIi(TextureTarget target, GetTextureParameter pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetTexParameterIiv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexParameterIuiv(TextureTarget, GetTextureParameter, uint*)"/>
        public static unsafe void GetTexParameterIui(TextureTarget target, GetTextureParameter pname, Span<uint> parameters)
        {
            fixed (uint* parameters_ptr = parameters)
            {
                GetTexParameterIuiv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexParameterIuiv(TextureTarget, GetTextureParameter, uint*)"/>
        public static unsafe void GetTexParameterIui(TextureTarget target, GetTextureParameter pname, uint[] parameters)
        {
            fixed (uint* parameters_ptr = parameters)
            {
                GetTexParameterIuiv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexParameterIuiv(TextureTarget, GetTextureParameter, uint*)"/>
        public static unsafe void GetTexParameterIui(TextureTarget target, GetTextureParameter pname, ref uint parameters)
        {
            fixed (uint* parameters_ptr = &parameters)
            {
                GetTexParameterIuiv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="SamplerParameterIiv(int, SamplerParameterI, int*)"/>
        public static unsafe void SamplerParameterIi(int sampler, SamplerParameterI pname, ReadOnlySpan<int> param)
        {
            fixed (int* param_ptr = param)
            {
                SamplerParameterIiv(sampler, pname, param_ptr);
            }
        }
        /// <inheritdoc cref="SamplerParameterIiv(int, SamplerParameterI, int*)"/>
        public static unsafe void SamplerParameterIi(int sampler, SamplerParameterI pname, int[] param)
        {
            fixed (int* param_ptr = param)
            {
                SamplerParameterIiv(sampler, pname, param_ptr);
            }
        }
        /// <inheritdoc cref="SamplerParameterIiv(int, SamplerParameterI, int*)"/>
        public static unsafe void SamplerParameterIi(int sampler, SamplerParameterI pname, in int param)
        {
            fixed (int* param_ptr = &param)
            {
                SamplerParameterIiv(sampler, pname, param_ptr);
            }
        }
        /// <inheritdoc cref="SamplerParameterIuiv(int, SamplerParameterI, uint*)"/>
        public static unsafe void SamplerParameterIui(int sampler, SamplerParameterI pname, ReadOnlySpan<uint> param)
        {
            fixed (uint* param_ptr = param)
            {
                SamplerParameterIuiv(sampler, pname, param_ptr);
            }
        }
        /// <inheritdoc cref="SamplerParameterIuiv(int, SamplerParameterI, uint*)"/>
        public static unsafe void SamplerParameterIui(int sampler, SamplerParameterI pname, uint[] param)
        {
            fixed (uint* param_ptr = param)
            {
                SamplerParameterIuiv(sampler, pname, param_ptr);
            }
        }
        /// <inheritdoc cref="SamplerParameterIuiv(int, SamplerParameterI, uint*)"/>
        public static unsafe void SamplerParameterIui(int sampler, SamplerParameterI pname, in uint param)
        {
            fixed (uint* param_ptr = &param)
            {
                SamplerParameterIuiv(sampler, pname, param_ptr);
            }
        }
        /// <inheritdoc cref="GetSamplerParameterIiv(int, SamplerParameterI, int*)"/>
        public static unsafe void GetSamplerParameterIi(int sampler, SamplerParameterI pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetSamplerParameterIiv(sampler, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetSamplerParameterIiv(int, SamplerParameterI, int*)"/>
        public static unsafe void GetSamplerParameterIi(int sampler, SamplerParameterI pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetSamplerParameterIiv(sampler, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetSamplerParameterIiv(int, SamplerParameterI, int*)"/>
        public static unsafe void GetSamplerParameterIi(int sampler, SamplerParameterI pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetSamplerParameterIiv(sampler, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetSamplerParameterIuiv(int, SamplerParameterI, uint*)"/>
        public static unsafe void GetSamplerParameterIui(int sampler, SamplerParameterI pname, Span<uint> parameters)
        {
            fixed (uint* parameters_ptr = parameters)
            {
                GetSamplerParameterIuiv(sampler, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetSamplerParameterIuiv(int, SamplerParameterI, uint*)"/>
        public static unsafe void GetSamplerParameterIui(int sampler, SamplerParameterI pname, uint[] parameters)
        {
            fixed (uint* parameters_ptr = parameters)
            {
                GetSamplerParameterIuiv(sampler, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetSamplerParameterIuiv(int, SamplerParameterI, uint*)"/>
        public static unsafe void GetSamplerParameterIui(int sampler, SamplerParameterI pname, ref uint parameters)
        {
            fixed (uint* parameters_ptr = &parameters)
            {
                GetSamplerParameterIuiv(sampler, pname, parameters_ptr);
            }
        }
        public static unsafe partial class AMD
        {
            /// <inheritdoc cref="GetPerfMonitorGroups(int*, int, uint*)"/>
            public static unsafe void GetPerfMonitorGroups(Span<int> numGroups, Span<uint> groups)
            {
                fixed (int* numGroups_ptr = numGroups)
                {
                    int groupsSize = (int)(groups.Length);
                    fixed (uint* groups_ptr = groups)
                    {
                        GetPerfMonitorGroups(numGroups_ptr, groupsSize, groups_ptr);
                    }
                }
            }
            /// <inheritdoc cref="GetPerfMonitorGroups(int*, int, uint*)"/>
            public static unsafe void GetPerfMonitorGroups(int[] numGroups, uint[] groups)
            {
                fixed (int* numGroups_ptr = numGroups)
                {
                    int groupsSize = (int)(groups.Length);
                    fixed (uint* groups_ptr = groups)
                    {
                        GetPerfMonitorGroups(numGroups_ptr, groupsSize, groups_ptr);
                    }
                }
            }
            /// <inheritdoc cref="GetPerfMonitorGroups(int*, int, uint*)"/>
            public static unsafe void GetPerfMonitorGroups(ref int numGroups, int groupsSize, ref uint groups)
            {
                fixed (int* numGroups_ptr = &numGroups)
                fixed (uint* groups_ptr = &groups)
                {
                    GetPerfMonitorGroups(numGroups_ptr, groupsSize, groups_ptr);
                }
            }
            /// <inheritdoc cref="GetPerfMonitorCounters(uint, int*, int*, int, uint*)"/>
            public static unsafe void GetPerfMonitorCounters(uint group, Span<int> numCounters, Span<int> maxActiveCounters, Span<uint> counters)
            {
                fixed (int* numCounters_ptr = numCounters)
                {
                    fixed (int* maxActiveCounters_ptr = maxActiveCounters)
                    {
                        int counterSize = (int)(counters.Length);
                        fixed (uint* counters_ptr = counters)
                        {
                            GetPerfMonitorCounters(group, numCounters_ptr, maxActiveCounters_ptr, counterSize, counters_ptr);
                        }
                    }
                }
            }
            /// <inheritdoc cref="GetPerfMonitorCounters(uint, int*, int*, int, uint*)"/>
            public static unsafe void GetPerfMonitorCounters(uint group, int[] numCounters, int[] maxActiveCounters, uint[] counters)
            {
                fixed (int* numCounters_ptr = numCounters)
                {
                    fixed (int* maxActiveCounters_ptr = maxActiveCounters)
                    {
                        int counterSize = (int)(counters.Length);
                        fixed (uint* counters_ptr = counters)
                        {
                            GetPerfMonitorCounters(group, numCounters_ptr, maxActiveCounters_ptr, counterSize, counters_ptr);
                        }
                    }
                }
            }
            /// <inheritdoc cref="GetPerfMonitorCounters(uint, int*, int*, int, uint*)"/>
            public static unsafe void GetPerfMonitorCounters(uint group, ref int numCounters, ref int maxActiveCounters, int counterSize, ref uint counters)
            {
                fixed (int* numCounters_ptr = &numCounters)
                fixed (int* maxActiveCounters_ptr = &maxActiveCounters)
                fixed (uint* counters_ptr = &counters)
                {
                    GetPerfMonitorCounters(group, numCounters_ptr, maxActiveCounters_ptr, counterSize, counters_ptr);
                }
            }
            /// <inheritdoc cref="GetPerfMonitorGroupString(uint, int, int*, byte*)"/>
            public static unsafe string GetPerfMonitorGroupString(uint group, int bufSize, Span<int> length)
            {
                string groupString;
                fixed (int* length_ptr = length)
                {
                    var groupString_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetPerfMonitorGroupString(group, bufSize, length_ptr, groupString_ptr);
                    groupString = Marshal.PtrToStringUTF8((IntPtr)groupString_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)groupString_ptr);
                }
                return groupString;
            }
            /// <inheritdoc cref="GetPerfMonitorGroupString(uint, int, int*, byte*)"/>
            public static unsafe void GetPerfMonitorGroupString(uint group, int bufSize, Span<int> length, out string groupString)
            {
                fixed (int* length_ptr = length)
                {
                    var groupString_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetPerfMonitorGroupString(group, bufSize, length_ptr, groupString_ptr);
                    groupString = Marshal.PtrToStringUTF8((IntPtr)groupString_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)groupString_ptr);
                }
            }
            /// <inheritdoc cref="GetPerfMonitorGroupString(uint, int, int*, byte*)"/>
            public static unsafe string GetPerfMonitorGroupString(uint group, int bufSize, int[] length)
            {
                string groupString;
                fixed (int* length_ptr = length)
                {
                    var groupString_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetPerfMonitorGroupString(group, bufSize, length_ptr, groupString_ptr);
                    groupString = Marshal.PtrToStringUTF8((IntPtr)groupString_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)groupString_ptr);
                }
                return groupString;
            }
            /// <inheritdoc cref="GetPerfMonitorGroupString(uint, int, int*, byte*)"/>
            public static unsafe void GetPerfMonitorGroupString(uint group, int bufSize, int[] length, out string groupString)
            {
                fixed (int* length_ptr = length)
                {
                    var groupString_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetPerfMonitorGroupString(group, bufSize, length_ptr, groupString_ptr);
                    groupString = Marshal.PtrToStringUTF8((IntPtr)groupString_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)groupString_ptr);
                }
            }
            /// <inheritdoc cref="GetPerfMonitorGroupString(uint, int, int*, byte*)"/>
            public static unsafe string GetPerfMonitorGroupString(uint group, int bufSize, ref int length)
            {
                string groupString;
                fixed (int* length_ptr = &length)
                {
                    var groupString_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetPerfMonitorGroupString(group, bufSize, length_ptr, groupString_ptr);
                    groupString = Marshal.PtrToStringUTF8((IntPtr)groupString_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)groupString_ptr);
                }
                return groupString;
            }
            /// <inheritdoc cref="GetPerfMonitorGroupString(uint, int, int*, byte*)"/>
            public static unsafe void GetPerfMonitorGroupString(uint group, int bufSize, ref int length, out string groupString)
            {
                fixed (int* length_ptr = &length)
                {
                    var groupString_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetPerfMonitorGroupString(group, bufSize, length_ptr, groupString_ptr);
                    groupString = Marshal.PtrToStringUTF8((IntPtr)groupString_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)groupString_ptr);
                }
            }
            /// <inheritdoc cref="GetPerfMonitorCounterString(uint, uint, int, int*, byte*)"/>
            public static unsafe string GetPerfMonitorCounterString(uint group, uint counter, int bufSize, Span<int> length)
            {
                string counterString;
                fixed (int* length_ptr = length)
                {
                    var counterString_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetPerfMonitorCounterString(group, counter, bufSize, length_ptr, counterString_ptr);
                    counterString = Marshal.PtrToStringUTF8((IntPtr)counterString_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)counterString_ptr);
                }
                return counterString;
            }
            /// <inheritdoc cref="GetPerfMonitorCounterString(uint, uint, int, int*, byte*)"/>
            public static unsafe void GetPerfMonitorCounterString(uint group, uint counter, int bufSize, Span<int> length, out string counterString)
            {
                fixed (int* length_ptr = length)
                {
                    var counterString_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetPerfMonitorCounterString(group, counter, bufSize, length_ptr, counterString_ptr);
                    counterString = Marshal.PtrToStringUTF8((IntPtr)counterString_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)counterString_ptr);
                }
            }
            /// <inheritdoc cref="GetPerfMonitorCounterString(uint, uint, int, int*, byte*)"/>
            public static unsafe string GetPerfMonitorCounterString(uint group, uint counter, int bufSize, int[] length)
            {
                string counterString;
                fixed (int* length_ptr = length)
                {
                    var counterString_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetPerfMonitorCounterString(group, counter, bufSize, length_ptr, counterString_ptr);
                    counterString = Marshal.PtrToStringUTF8((IntPtr)counterString_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)counterString_ptr);
                }
                return counterString;
            }
            /// <inheritdoc cref="GetPerfMonitorCounterString(uint, uint, int, int*, byte*)"/>
            public static unsafe void GetPerfMonitorCounterString(uint group, uint counter, int bufSize, int[] length, out string counterString)
            {
                fixed (int* length_ptr = length)
                {
                    var counterString_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetPerfMonitorCounterString(group, counter, bufSize, length_ptr, counterString_ptr);
                    counterString = Marshal.PtrToStringUTF8((IntPtr)counterString_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)counterString_ptr);
                }
            }
            /// <inheritdoc cref="GetPerfMonitorCounterString(uint, uint, int, int*, byte*)"/>
            public static unsafe string GetPerfMonitorCounterString(uint group, uint counter, int bufSize, ref int length)
            {
                string counterString;
                fixed (int* length_ptr = &length)
                {
                    var counterString_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetPerfMonitorCounterString(group, counter, bufSize, length_ptr, counterString_ptr);
                    counterString = Marshal.PtrToStringUTF8((IntPtr)counterString_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)counterString_ptr);
                }
                return counterString;
            }
            /// <inheritdoc cref="GetPerfMonitorCounterString(uint, uint, int, int*, byte*)"/>
            public static unsafe void GetPerfMonitorCounterString(uint group, uint counter, int bufSize, ref int length, out string counterString)
            {
                fixed (int* length_ptr = &length)
                {
                    var counterString_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetPerfMonitorCounterString(group, counter, bufSize, length_ptr, counterString_ptr);
                    counterString = Marshal.PtrToStringUTF8((IntPtr)counterString_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)counterString_ptr);
                }
            }
            /// <inheritdoc cref="GetPerfMonitorCounterInfo(uint, uint, All, void*)"/>
            public static unsafe void GetPerfMonitorCounterInfo(uint group, uint counter, All pname, IntPtr data)
            {
                void* data_vptr = (void*)data;
                GetPerfMonitorCounterInfo(group, counter, pname, data_vptr);
            }
            /// <inheritdoc cref="GetPerfMonitorCounterInfo(uint, uint, All, void*)"/>
            public static unsafe void GetPerfMonitorCounterInfo<T1>(uint group, uint counter, All pname, Span<T1> data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    GetPerfMonitorCounterInfo(group, counter, pname, data_ptr);
                }
            }
            /// <inheritdoc cref="GetPerfMonitorCounterInfo(uint, uint, All, void*)"/>
            public static unsafe void GetPerfMonitorCounterInfo<T1>(uint group, uint counter, All pname, T1[] data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    GetPerfMonitorCounterInfo(group, counter, pname, data_ptr);
                }
            }
            /// <inheritdoc cref="GetPerfMonitorCounterInfo(uint, uint, All, void*)"/>
            public static unsafe void GetPerfMonitorCounterInfo<T1>(uint group, uint counter, All pname, ref T1 data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    GetPerfMonitorCounterInfo(group, counter, pname, data_ptr);
                }
            }
            /// <inheritdoc cref="GenPerfMonitors(int, uint*)"/>
            public static unsafe void GenPerfMonitors(Span<uint> monitors)
            {
                int n = (int)(monitors.Length);
                fixed (uint* monitors_ptr = monitors)
                {
                    GenPerfMonitors(n, monitors_ptr);
                }
            }
            /// <inheritdoc cref="GenPerfMonitors(int, uint*)"/>
            public static unsafe void GenPerfMonitors(uint[] monitors)
            {
                int n = (int)(monitors.Length);
                fixed (uint* monitors_ptr = monitors)
                {
                    GenPerfMonitors(n, monitors_ptr);
                }
            }
            /// <inheritdoc cref="GenPerfMonitors(int, uint*)"/>
            public static unsafe void GenPerfMonitors(int n, ref uint monitors)
            {
                fixed (uint* monitors_ptr = &monitors)
                {
                    GenPerfMonitors(n, monitors_ptr);
                }
            }
            /// <inheritdoc cref="DeletePerfMonitors(int, uint*)"/>
            public static unsafe void DeletePerfMonitors(Span<uint> monitors)
            {
                int n = (int)(monitors.Length);
                fixed (uint* monitors_ptr = monitors)
                {
                    DeletePerfMonitors(n, monitors_ptr);
                }
            }
            /// <inheritdoc cref="DeletePerfMonitors(int, uint*)"/>
            public static unsafe void DeletePerfMonitors(uint[] monitors)
            {
                int n = (int)(monitors.Length);
                fixed (uint* monitors_ptr = monitors)
                {
                    DeletePerfMonitors(n, monitors_ptr);
                }
            }
            /// <inheritdoc cref="DeletePerfMonitors(int, uint*)"/>
            public static unsafe void DeletePerfMonitors(int n, ref uint monitors)
            {
                fixed (uint* monitors_ptr = &monitors)
                {
                    DeletePerfMonitors(n, monitors_ptr);
                }
            }
            /// <inheritdoc cref="SelectPerfMonitorCounters(uint, bool, uint, int, uint*)"/>
            public static unsafe void SelectPerfMonitorCounters(uint monitor, bool enable, uint group, Span<uint> counterList)
            {
                int numCounters = (int)(counterList.Length);
                fixed (uint* counterList_ptr = counterList)
                {
                    SelectPerfMonitorCounters(monitor, enable, group, numCounters, counterList_ptr);
                }
            }
            /// <inheritdoc cref="SelectPerfMonitorCounters(uint, bool, uint, int, uint*)"/>
            public static unsafe void SelectPerfMonitorCounters(uint monitor, bool enable, uint group, uint[] counterList)
            {
                int numCounters = (int)(counterList.Length);
                fixed (uint* counterList_ptr = counterList)
                {
                    SelectPerfMonitorCounters(monitor, enable, group, numCounters, counterList_ptr);
                }
            }
            /// <inheritdoc cref="SelectPerfMonitorCounters(uint, bool, uint, int, uint*)"/>
            public static unsafe void SelectPerfMonitorCounters(uint monitor, bool enable, uint group, int numCounters, ref uint counterList)
            {
                fixed (uint* counterList_ptr = &counterList)
                {
                    SelectPerfMonitorCounters(monitor, enable, group, numCounters, counterList_ptr);
                }
            }
            /// <inheritdoc cref="GetPerfMonitorCounterData(uint, All, int, uint*, int*)"/>
            public static unsafe void GetPerfMonitorCounterData(uint monitor, All pname, Span<uint> data, Span<int> bytesWritten)
            {
                int dataSize = (int)(data.Length * 4);
                fixed (uint* data_ptr = data)
                {
                    fixed (int* bytesWritten_ptr = bytesWritten)
                    {
                        GetPerfMonitorCounterData(monitor, pname, dataSize, data_ptr, bytesWritten_ptr);
                    }
                }
            }
            /// <inheritdoc cref="GetPerfMonitorCounterData(uint, All, int, uint*, int*)"/>
            public static unsafe void GetPerfMonitorCounterData(uint monitor, All pname, uint[] data, int[] bytesWritten)
            {
                int dataSize = (int)(data.Length * 4);
                fixed (uint* data_ptr = data)
                {
                    fixed (int* bytesWritten_ptr = bytesWritten)
                    {
                        GetPerfMonitorCounterData(monitor, pname, dataSize, data_ptr, bytesWritten_ptr);
                    }
                }
            }
            /// <inheritdoc cref="GetPerfMonitorCounterData(uint, All, int, uint*, int*)"/>
            public static unsafe void GetPerfMonitorCounterData(uint monitor, All pname, int dataSize, ref uint data, ref int bytesWritten)
            {
                fixed (uint* data_ptr = &data)
                fixed (int* bytesWritten_ptr = &bytesWritten)
                {
                    GetPerfMonitorCounterData(monitor, pname, dataSize, data_ptr, bytesWritten_ptr);
                }
            }
        }
        public static unsafe partial class ANGLE
        {
            /// <inheritdoc cref="DrawElementsInstanced(PrimitiveType, int, DrawElementsType, void*, int)"/>
            public static unsafe void DrawElementsInstanced(PrimitiveType mode, int count, DrawElementsType type, nint offset, int primcount)
            {
                void* indices = (void*)offset;
                DrawElementsInstanced(mode, count, type, indices, primcount);
            }
            /// <inheritdoc cref="GetTranslatedShaderSource(int, int, int*, byte*)"/>
            public static unsafe string GetTranslatedShaderSource(int shader, int bufSize, Span<int> length)
            {
                string source;
                fixed (int* length_ptr = length)
                {
                    var source_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetTranslatedShaderSource(shader, bufSize, length_ptr, source_ptr);
                    source = Marshal.PtrToStringUTF8((IntPtr)source_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)source_ptr);
                }
                return source;
            }
            /// <inheritdoc cref="GetTranslatedShaderSource(int, int, int*, byte*)"/>
            public static unsafe void GetTranslatedShaderSource(int shader, int bufSize, Span<int> length, out string source)
            {
                fixed (int* length_ptr = length)
                {
                    var source_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetTranslatedShaderSource(shader, bufSize, length_ptr, source_ptr);
                    source = Marshal.PtrToStringUTF8((IntPtr)source_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)source_ptr);
                }
            }
            /// <inheritdoc cref="GetTranslatedShaderSource(int, int, int*, byte*)"/>
            public static unsafe string GetTranslatedShaderSource(int shader, int bufSize, int[] length)
            {
                string source;
                fixed (int* length_ptr = length)
                {
                    var source_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetTranslatedShaderSource(shader, bufSize, length_ptr, source_ptr);
                    source = Marshal.PtrToStringUTF8((IntPtr)source_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)source_ptr);
                }
                return source;
            }
            /// <inheritdoc cref="GetTranslatedShaderSource(int, int, int*, byte*)"/>
            public static unsafe void GetTranslatedShaderSource(int shader, int bufSize, int[] length, out string source)
            {
                fixed (int* length_ptr = length)
                {
                    var source_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetTranslatedShaderSource(shader, bufSize, length_ptr, source_ptr);
                    source = Marshal.PtrToStringUTF8((IntPtr)source_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)source_ptr);
                }
            }
            /// <inheritdoc cref="GetTranslatedShaderSource(int, int, int*, byte*)"/>
            public static unsafe string GetTranslatedShaderSource(int shader, int bufSize, ref int length)
            {
                string source;
                fixed (int* length_ptr = &length)
                {
                    var source_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetTranslatedShaderSource(shader, bufSize, length_ptr, source_ptr);
                    source = Marshal.PtrToStringUTF8((IntPtr)source_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)source_ptr);
                }
                return source;
            }
            /// <inheritdoc cref="GetTranslatedShaderSource(int, int, int*, byte*)"/>
            public static unsafe void GetTranslatedShaderSource(int shader, int bufSize, ref int length, out string source)
            {
                fixed (int* length_ptr = &length)
                {
                    var source_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetTranslatedShaderSource(shader, bufSize, length_ptr, source_ptr);
                    source = Marshal.PtrToStringUTF8((IntPtr)source_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)source_ptr);
                }
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
            /// <inheritdoc cref="EGLImageTargetTexStorage(All, void*, int*)"/>
            public static unsafe void EGLImageTargetTexStorage(All target, IntPtr image, in int attrib_list)
            {
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    void* image_vptr = (void*)image;
                    EGLImageTargetTexStorage(target, image_vptr, attrib_list_ptr);
                }
            }
            /// <inheritdoc cref="EGLImageTargetTexStorage(All, void*, int*)"/>
            public static unsafe void EGLImageTargetTexStorage<T1>(All target, ref T1 image, in int attrib_list)
                where T1 : unmanaged
            {
                fixed (void* image_ptr = &image)
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    EGLImageTargetTexStorage(target, image_ptr, attrib_list_ptr);
                }
            }
            /// <inheritdoc cref="EGLImageTargetTextureStorage(int, void*, int*)"/>
            public static unsafe void EGLImageTargetTextureStorage(int texture, IntPtr image, in int attrib_list)
            {
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    void* image_vptr = (void*)image;
                    EGLImageTargetTextureStorage(texture, image_vptr, attrib_list_ptr);
                }
            }
            /// <inheritdoc cref="EGLImageTargetTextureStorage(int, void*, int*)"/>
            public static unsafe void EGLImageTargetTextureStorage<T1>(int texture, ref T1 image, in int attrib_list)
                where T1 : unmanaged
            {
                fixed (void* image_ptr = &image)
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    EGLImageTargetTextureStorage(texture, image_ptr, attrib_list_ptr);
                }
            }
            /// <inheritdoc cref="DrawElementsInstancedBaseInstance(PrimitiveType, int, DrawElementsType, void*, int, uint)"/>
            public static unsafe void DrawElementsInstancedBaseInstance(PrimitiveType mode, int count, DrawElementsType type, nint offset, int instancecount, uint baseinstance)
            {
                void* indices = (void*)offset;
                DrawElementsInstancedBaseInstance(mode, count, type, indices, instancecount, baseinstance);
            }
            /// <inheritdoc cref="DrawElementsInstancedBaseVertexBaseInstance(PrimitiveType, int, DrawElementsType, void*, int, int, uint)"/>
            public static unsafe void DrawElementsInstancedBaseVertexBaseInstance(PrimitiveType mode, int count, DrawElementsType type, nint offset, int instancecount, int basevertex, uint baseinstance)
            {
                void* indices = (void*)offset;
                DrawElementsInstancedBaseVertexBaseInstance(mode, count, type, indices, instancecount, basevertex, baseinstance);
            }
            /// <inheritdoc cref="BindFragDataLocationIndexed(int, uint, uint, byte*)"/>
            public static unsafe void BindFragDataLocationIndexed(int program, uint colorNumber, uint index, string name)
            {
                byte* name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(name);
                BindFragDataLocationIndexed(program, colorNumber, index, name_ptr);
                Marshal.FreeCoTaskMem((IntPtr)name_ptr);
            }
            /// <inheritdoc cref="BindFragDataLocation(int, uint, byte*)"/>
            public static unsafe void BindFragDataLocation(int program, uint color, string name)
            {
                byte* name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(name);
                BindFragDataLocation(program, color, name_ptr);
                Marshal.FreeCoTaskMem((IntPtr)name_ptr);
            }
            /// <inheritdoc cref="GetProgramResourceLocationIndex(int, ProgramInterface, byte*)"/>
            public static unsafe int GetProgramResourceLocationIndex(int program, ProgramInterface programInterface, string name)
            {
                int returnValue;
                byte* name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(name);
                returnValue = GetProgramResourceLocationIndex(program, programInterface, name_ptr);
                Marshal.FreeCoTaskMem((IntPtr)name_ptr);
                return returnValue;
            }
            /// <inheritdoc cref="GetFragDataIndex(int, byte*)"/>
            public static unsafe int GetFragDataIndex(int program, string name)
            {
                int returnValue;
                byte* name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(name);
                returnValue = GetFragDataIndex(program, name_ptr);
                Marshal.FreeCoTaskMem((IntPtr)name_ptr);
                return returnValue;
            }
            /// <inheritdoc cref="BufferStorage(BufferStorageTarget, nint, void*, BufferStorageMask)"/>
            public static unsafe void BufferStorage(BufferStorageTarget target, nint size, IntPtr data, BufferStorageMask flags)
            {
                void* data_vptr = (void*)data;
                BufferStorage(target, size, data_vptr, flags);
            }
            /// <inheritdoc cref="BufferStorage(BufferStorageTarget, nint, void*, BufferStorageMask)"/>
            public static unsafe void BufferStorage<T1>(BufferStorageTarget target, ReadOnlySpan<T1> data, BufferStorageMask flags)
                where T1 : unmanaged
            {
                nint size = (nint)(data.Length * sizeof(T1));
                fixed (void* data_ptr = data)
                {
                    BufferStorage(target, size, data_ptr, flags);
                }
            }
            /// <inheritdoc cref="BufferStorage(BufferStorageTarget, nint, void*, BufferStorageMask)"/>
            public static unsafe void BufferStorage<T1>(BufferStorageTarget target, T1[] data, BufferStorageMask flags)
                where T1 : unmanaged
            {
                nint size = (nint)(data.Length * sizeof(T1));
                fixed (void* data_ptr = data)
                {
                    BufferStorage(target, size, data_ptr, flags);
                }
            }
            /// <inheritdoc cref="BufferStorage(BufferStorageTarget, nint, void*, BufferStorageMask)"/>
            public static unsafe void BufferStorage<T1>(BufferStorageTarget target, nint size, in T1 data, BufferStorageMask flags)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    BufferStorage(target, size, data_ptr, flags);
                }
            }
            /// <inheritdoc cref="ClearTexImage(int, int, PixelFormat, PixelType, void*)"/>
            public static unsafe void ClearTexImage(int texture, int level, PixelFormat format, PixelType type, IntPtr data)
            {
                void* data_vptr = (void*)data;
                ClearTexImage(texture, level, format, type, data_vptr);
            }
            /// <inheritdoc cref="ClearTexImage(int, int, PixelFormat, PixelType, void*)"/>
            public static unsafe void ClearTexImage<T1>(int texture, int level, PixelFormat format, PixelType type, ReadOnlySpan<T1> data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    ClearTexImage(texture, level, format, type, data_ptr);
                }
            }
            /// <inheritdoc cref="ClearTexImage(int, int, PixelFormat, PixelType, void*)"/>
            public static unsafe void ClearTexImage<T1>(int texture, int level, PixelFormat format, PixelType type, T1[] data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    ClearTexImage(texture, level, format, type, data_ptr);
                }
            }
            /// <inheritdoc cref="ClearTexImage(int, int, PixelFormat, PixelType, void*)"/>
            public static unsafe void ClearTexImage<T1>(int texture, int level, PixelFormat format, PixelType type, in T1 data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    ClearTexImage(texture, level, format, type, data_ptr);
                }
            }
            /// <inheritdoc cref="ClearTexSubImage(int, int, int, int, int, int, int, int, PixelFormat, PixelType, void*)"/>
            public static unsafe void ClearTexSubImage(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr data)
            {
                void* data_vptr = (void*)data;
                ClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data_vptr);
            }
            /// <inheritdoc cref="ClearTexSubImage(int, int, int, int, int, int, int, int, PixelFormat, PixelType, void*)"/>
            public static unsafe void ClearTexSubImage<T1>(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, ReadOnlySpan<T1> data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    ClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data_ptr);
                }
            }
            /// <inheritdoc cref="ClearTexSubImage(int, int, int, int, int, int, int, int, PixelFormat, PixelType, void*)"/>
            public static unsafe void ClearTexSubImage<T1>(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, T1[] data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    ClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data_ptr);
                }
            }
            /// <inheritdoc cref="ClearTexSubImage(int, int, int, int, int, int, int, int, PixelFormat, PixelType, void*)"/>
            public static unsafe void ClearTexSubImage<T1>(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, in T1 data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    ClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data_ptr);
                }
            }
            /// <inheritdoc cref="LabelObject(All, uint, int, byte*)"/>
            public static unsafe void LabelObject(All type, uint obj, int length, string label)
            {
                byte* label_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(label);
                LabelObject(type, obj, length, label_ptr);
                Marshal.FreeCoTaskMem((IntPtr)label_ptr);
            }
            /// <inheritdoc cref="GetObjectLabel(All, uint, int, int*, byte*)"/>
            public static unsafe string GetObjectLabel(All type, uint obj, int bufSize, Span<int> length)
            {
                string label;
                fixed (int* length_ptr = length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetObjectLabel(type, obj, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
                return label;
            }
            /// <inheritdoc cref="GetObjectLabel(All, uint, int, int*, byte*)"/>
            public static unsafe void GetObjectLabel(All type, uint obj, int bufSize, Span<int> length, out string label)
            {
                fixed (int* length_ptr = length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetObjectLabel(type, obj, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
            }
            /// <inheritdoc cref="GetObjectLabel(All, uint, int, int*, byte*)"/>
            public static unsafe string GetObjectLabel(All type, uint obj, int bufSize, int[] length)
            {
                string label;
                fixed (int* length_ptr = length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetObjectLabel(type, obj, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
                return label;
            }
            /// <inheritdoc cref="GetObjectLabel(All, uint, int, int*, byte*)"/>
            public static unsafe void GetObjectLabel(All type, uint obj, int bufSize, int[] length, out string label)
            {
                fixed (int* length_ptr = length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetObjectLabel(type, obj, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
            }
            /// <inheritdoc cref="GetObjectLabel(All, uint, int, int*, byte*)"/>
            public static unsafe string GetObjectLabel(All type, uint obj, int bufSize, ref int length)
            {
                string label;
                fixed (int* length_ptr = &length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetObjectLabel(type, obj, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
                return label;
            }
            /// <inheritdoc cref="GetObjectLabel(All, uint, int, int*, byte*)"/>
            public static unsafe void GetObjectLabel(All type, uint obj, int bufSize, ref int length, out string label)
            {
                fixed (int* length_ptr = &length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetObjectLabel(type, obj, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
            }
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
            /// <inheritdoc cref="GenQueries(int, int*)"/>
            public static unsafe void GenQueries(Span<int> ids)
            {
                int n = (int)(ids.Length);
                fixed (int* ids_ptr = ids)
                {
                    GenQueries(n, ids_ptr);
                }
            }
            /// <inheritdoc cref="GenQueries(int, int*)"/>
            public static unsafe void GenQueries(int[] ids)
            {
                int n = (int)(ids.Length);
                fixed (int* ids_ptr = ids)
                {
                    GenQueries(n, ids_ptr);
                }
            }
            /// <inheritdoc cref="GenQueries(int, int*)"/>
            public static unsafe void GenQueries(int n, ref int ids)
            {
                fixed (int* ids_ptr = &ids)
                {
                    GenQueries(n, ids_ptr);
                }
            }
            /// <inheritdoc cref="DeleteQueries(int, int*)"/>
            public static unsafe void DeleteQueries(ReadOnlySpan<int> ids)
            {
                int n = (int)(ids.Length);
                fixed (int* ids_ptr = ids)
                {
                    DeleteQueries(n, ids_ptr);
                }
            }
            /// <inheritdoc cref="DeleteQueries(int, int*)"/>
            public static unsafe void DeleteQueries(int[] ids)
            {
                int n = (int)(ids.Length);
                fixed (int* ids_ptr = ids)
                {
                    DeleteQueries(n, ids_ptr);
                }
            }
            /// <inheritdoc cref="DeleteQueries(int, int*)"/>
            public static unsafe void DeleteQueries(int n, in int ids)
            {
                fixed (int* ids_ptr = &ids)
                {
                    DeleteQueries(n, ids_ptr);
                }
            }
            /// <inheritdoc cref="GetQueryiv(QueryTarget, QueryParameterName, int*)"/>
            public static unsafe void GetQueryiv(QueryTarget target, QueryParameterName pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetQueryiv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetQueryiv(QueryTarget, QueryParameterName, int*)"/>
            public static unsafe void GetQueryiv(QueryTarget target, QueryParameterName pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetQueryiv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetQueryiv(QueryTarget, QueryParameterName, int*)"/>
            public static unsafe void GetQueryiv(QueryTarget target, QueryParameterName pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetQueryiv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetQueryObjectiv(int, QueryObjectParameterName, int*)"/>
            public static unsafe void GetQueryObjectiv(int id, QueryObjectParameterName pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetQueryObjectiv(id, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetQueryObjectiv(int, QueryObjectParameterName, int*)"/>
            public static unsafe void GetQueryObjectiv(int id, QueryObjectParameterName pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetQueryObjectiv(id, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetQueryObjectiv(int, QueryObjectParameterName, int*)"/>
            public static unsafe void GetQueryObjectiv(int id, QueryObjectParameterName pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetQueryObjectiv(id, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetQueryObjectuiv(int, QueryObjectParameterName, uint*)"/>
            public static unsafe void GetQueryObjectuiv(int id, QueryObjectParameterName pname, Span<uint> parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    GetQueryObjectuiv(id, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetQueryObjectuiv(int, QueryObjectParameterName, uint*)"/>
            public static unsafe void GetQueryObjectuiv(int id, QueryObjectParameterName pname, uint[] parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    GetQueryObjectuiv(id, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetQueryObjectuiv(int, QueryObjectParameterName, uint*)"/>
            public static unsafe void GetQueryObjectuiv(int id, QueryObjectParameterName pname, ref uint parameters)
            {
                fixed (uint* parameters_ptr = &parameters)
                {
                    GetQueryObjectuiv(id, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetQueryObjecti64v(int, QueryObjectParameterName, long*)"/>
            public static unsafe void GetQueryObjecti64v(int id, QueryObjectParameterName pname, Span<long> parameters)
            {
                fixed (long* parameters_ptr = parameters)
                {
                    GetQueryObjecti64v(id, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetQueryObjecti64v(int, QueryObjectParameterName, long*)"/>
            public static unsafe void GetQueryObjecti64v(int id, QueryObjectParameterName pname, long[] parameters)
            {
                fixed (long* parameters_ptr = parameters)
                {
                    GetQueryObjecti64v(id, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetQueryObjecti64v(int, QueryObjectParameterName, long*)"/>
            public static unsafe void GetQueryObjecti64v(int id, QueryObjectParameterName pname, ref long parameters)
            {
                fixed (long* parameters_ptr = &parameters)
                {
                    GetQueryObjecti64v(id, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetQueryObjectui64v(int, QueryObjectParameterName, ulong*)"/>
            public static unsafe void GetQueryObjectui64v(int id, QueryObjectParameterName pname, Span<ulong> parameters)
            {
                fixed (ulong* parameters_ptr = parameters)
                {
                    GetQueryObjectui64v(id, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetQueryObjectui64v(int, QueryObjectParameterName, ulong*)"/>
            public static unsafe void GetQueryObjectui64v(int id, QueryObjectParameterName pname, ulong[] parameters)
            {
                fixed (ulong* parameters_ptr = parameters)
                {
                    GetQueryObjectui64v(id, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetQueryObjectui64v(int, QueryObjectParameterName, ulong*)"/>
            public static unsafe void GetQueryObjectui64v(int id, QueryObjectParameterName pname, ref ulong parameters)
            {
                fixed (ulong* parameters_ptr = &parameters)
                {
                    GetQueryObjectui64v(id, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetInteger64v(GetPName, long*)"/>
            public static unsafe void GetInteger64v(GetPName pname, Span<long> data)
            {
                fixed (long* data_ptr = data)
                {
                    GetInteger64v(pname, data_ptr);
                }
            }
            /// <inheritdoc cref="GetInteger64v(GetPName, long*)"/>
            public static unsafe void GetInteger64v(GetPName pname, long[] data)
            {
                fixed (long* data_ptr = data)
                {
                    GetInteger64v(pname, data_ptr);
                }
            }
            /// <inheritdoc cref="GetInteger64v(GetPName, long*)"/>
            public static unsafe void GetInteger64v(GetPName pname, ref long data)
            {
                fixed (long* data_ptr = &data)
                {
                    GetInteger64v(pname, data_ptr);
                }
            }
            /// <inheritdoc cref="DrawBuffers(int, All*)"/>
            public static unsafe void DrawBuffers(ReadOnlySpan<All> bufs)
            {
                int n = (int)(bufs.Length);
                fixed (All* bufs_ptr = bufs)
                {
                    DrawBuffers(n, bufs_ptr);
                }
            }
            /// <inheritdoc cref="DrawBuffers(int, All*)"/>
            public static unsafe void DrawBuffers(All[] bufs)
            {
                int n = (int)(bufs.Length);
                fixed (All* bufs_ptr = bufs)
                {
                    DrawBuffers(n, bufs_ptr);
                }
            }
            /// <inheritdoc cref="DrawBuffers(int, All*)"/>
            public static unsafe void DrawBuffers(int n, in All bufs)
            {
                fixed (All* bufs_ptr = &bufs)
                {
                    DrawBuffers(n, bufs_ptr);
                }
            }
            /// <inheritdoc cref="DrawElementsBaseVertex(PrimitiveType, int, DrawElementsType, void*, int)"/>
            public static unsafe void DrawElementsBaseVertex(PrimitiveType mode, int count, DrawElementsType type, nint offset, int basevertex)
            {
                void* indices = (void*)offset;
                DrawElementsBaseVertex(mode, count, type, indices, basevertex);
            }
            /// <inheritdoc cref="DrawRangeElementsBaseVertex(PrimitiveType, uint, uint, int, DrawElementsType, void*, int)"/>
            public static unsafe void DrawRangeElementsBaseVertex(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, nint offset, int basevertex)
            {
                void* indices = (void*)offset;
                DrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
            }
            /// <inheritdoc cref="DrawElementsInstancedBaseVertex(PrimitiveType, int, DrawElementsType, void*, int, int)"/>
            public static unsafe void DrawElementsInstancedBaseVertex(PrimitiveType mode, int count, DrawElementsType type, nint offset, int instancecount, int basevertex)
            {
                void* indices = (void*)offset;
                DrawElementsInstancedBaseVertex(mode, count, type, indices, instancecount, basevertex);
            }
            /// <inheritdoc cref="MultiDrawElementsBaseVertex(PrimitiveType, int*, DrawElementsType, void**, int, int*)"/>
            public static unsafe void MultiDrawElementsBaseVertex(PrimitiveType mode, ReadOnlySpan<int> count, DrawElementsType type, void** indices, int drawcount, ReadOnlySpan<int> basevertex)
            {
                fixed (int* count_ptr = count)
                {
                    fixed (int* basevertex_ptr = basevertex)
                    {
                        MultiDrawElementsBaseVertex(mode, count_ptr, type, indices, drawcount, basevertex_ptr);
                    }
                }
            }
            /// <inheritdoc cref="MultiDrawElementsBaseVertex(PrimitiveType, int*, DrawElementsType, void**, int, int*)"/>
            public static unsafe void MultiDrawElementsBaseVertex(PrimitiveType mode, int[] count, DrawElementsType type, void** indices, int drawcount, int[] basevertex)
            {
                fixed (int* count_ptr = count)
                {
                    fixed (int* basevertex_ptr = basevertex)
                    {
                        MultiDrawElementsBaseVertex(mode, count_ptr, type, indices, drawcount, basevertex_ptr);
                    }
                }
            }
            /// <inheritdoc cref="MultiDrawElementsBaseVertex(PrimitiveType, int*, DrawElementsType, void**, int, int*)"/>
            public static unsafe void MultiDrawElementsBaseVertex(PrimitiveType mode, in int count, DrawElementsType type, void** indices, int drawcount, in int basevertex)
            {
                fixed (int* count_ptr = &count)
                fixed (int* basevertex_ptr = &basevertex)
                {
                    MultiDrawElementsBaseVertex(mode, count_ptr, type, indices, drawcount, basevertex_ptr);
                }
            }
            /// <inheritdoc cref="DrawElementsInstanced(PrimitiveType, int, DrawElementsType, void*, int)"/>
            public static unsafe void DrawElementsInstanced(PrimitiveType mode, int count, DrawElementsType type, nint offset, int primcount)
            {
                void* indices = (void*)offset;
                DrawElementsInstanced(mode, count, type, indices, primcount);
            }
            /// <inheritdoc cref="BufferStorageExternal(All, IntPtr, nint, void*, BufferStorageMask)"/>
            public static unsafe void BufferStorageExternal(All target, IntPtr offset, nint size, IntPtr clientBuffer, BufferStorageMask flags)
            {
                void* clientBuffer_vptr = (void*)clientBuffer;
                BufferStorageExternal(target, offset, size, clientBuffer_vptr, flags);
            }
            /// <inheritdoc cref="BufferStorageExternal(All, IntPtr, nint, void*, BufferStorageMask)"/>
            public static unsafe void BufferStorageExternal<T1>(All target, IntPtr offset, nint size, ref T1 clientBuffer, BufferStorageMask flags)
                where T1 : unmanaged
            {
                fixed (void* clientBuffer_ptr = &clientBuffer)
                {
                    BufferStorageExternal(target, offset, size, clientBuffer_ptr, flags);
                }
            }
            /// <inheritdoc cref="NamedBufferStorageExternal(int, IntPtr, nint, void*, BufferStorageMask)"/>
            public static unsafe void NamedBufferStorageExternal(int buffer, IntPtr offset, nint size, IntPtr clientBuffer, BufferStorageMask flags)
            {
                void* clientBuffer_vptr = (void*)clientBuffer;
                NamedBufferStorageExternal(buffer, offset, size, clientBuffer_vptr, flags);
            }
            /// <inheritdoc cref="NamedBufferStorageExternal(int, IntPtr, nint, void*, BufferStorageMask)"/>
            public static unsafe void NamedBufferStorageExternal<T1>(int buffer, IntPtr offset, nint size, ref T1 clientBuffer, BufferStorageMask flags)
                where T1 : unmanaged
            {
                fixed (void* clientBuffer_ptr = &clientBuffer)
                {
                    NamedBufferStorageExternal(buffer, offset, size, clientBuffer_ptr, flags);
                }
            }
            /// <inheritdoc cref="GetFragmentShadingRates(int, int, int*, ShadingRate*)"/>
            public static unsafe void GetFragmentShadingRates(int samples, Span<int> count, Span<ShadingRate> shadingRates)
            {
                fixed (int* count_ptr = count)
                {
                    int maxCount = (int)(shadingRates.Length);
                    fixed (ShadingRate* shadingRates_ptr = shadingRates)
                    {
                        GetFragmentShadingRates(samples, maxCount, count_ptr, shadingRates_ptr);
                    }
                }
            }
            /// <inheritdoc cref="GetFragmentShadingRates(int, int, int*, ShadingRate*)"/>
            public static unsafe void GetFragmentShadingRates(int samples, int[] count, ShadingRate[] shadingRates)
            {
                fixed (int* count_ptr = count)
                {
                    int maxCount = (int)(shadingRates.Length);
                    fixed (ShadingRate* shadingRates_ptr = shadingRates)
                    {
                        GetFragmentShadingRates(samples, maxCount, count_ptr, shadingRates_ptr);
                    }
                }
            }
            /// <inheritdoc cref="GetFragmentShadingRates(int, int, int*, ShadingRate*)"/>
            public static unsafe void GetFragmentShadingRates(int samples, int maxCount, ref int count, ref ShadingRate shadingRates)
            {
                fixed (int* count_ptr = &count)
                fixed (ShadingRate* shadingRates_ptr = &shadingRates)
                {
                    GetFragmentShadingRates(samples, maxCount, count_ptr, shadingRates_ptr);
                }
            }
            /// <inheritdoc cref="GetUnsignedBytev(GetPName, byte*)"/>
            public static unsafe void GetUnsignedBytev(GetPName pname, Span<byte> data)
            {
                fixed (byte* data_ptr = data)
                {
                    GetUnsignedBytev(pname, data_ptr);
                }
            }
            /// <inheritdoc cref="GetUnsignedBytev(GetPName, byte*)"/>
            public static unsafe void GetUnsignedBytev(GetPName pname, byte[] data)
            {
                fixed (byte* data_ptr = data)
                {
                    GetUnsignedBytev(pname, data_ptr);
                }
            }
            /// <inheritdoc cref="GetUnsignedBytev(GetPName, byte*)"/>
            public static unsafe void GetUnsignedBytev(GetPName pname, ref byte data)
            {
                fixed (byte* data_ptr = &data)
                {
                    GetUnsignedBytev(pname, data_ptr);
                }
            }
            /// <inheritdoc cref="GetUnsignedBytei_v(All, uint, byte*)"/>
            public static unsafe void GetUnsignedBytei_v(All target, uint index, Span<byte> data)
            {
                fixed (byte* data_ptr = data)
                {
                    GetUnsignedBytei_v(target, index, data_ptr);
                }
            }
            /// <inheritdoc cref="GetUnsignedBytei_v(All, uint, byte*)"/>
            public static unsafe void GetUnsignedBytei_v(All target, uint index, byte[] data)
            {
                fixed (byte* data_ptr = data)
                {
                    GetUnsignedBytei_v(target, index, data_ptr);
                }
            }
            /// <inheritdoc cref="GetUnsignedBytei_v(All, uint, byte*)"/>
            public static unsafe void GetUnsignedBytei_v(All target, uint index, ref byte data)
            {
                fixed (byte* data_ptr = &data)
                {
                    GetUnsignedBytei_v(target, index, data_ptr);
                }
            }
            /// <inheritdoc cref="DeleteMemoryObjects(int, uint*)"/>
            public static unsafe void DeleteMemoryObjects(ReadOnlySpan<uint> memoryObjects)
            {
                int n = (int)(memoryObjects.Length);
                fixed (uint* memoryObjects_ptr = memoryObjects)
                {
                    DeleteMemoryObjects(n, memoryObjects_ptr);
                }
            }
            /// <inheritdoc cref="DeleteMemoryObjects(int, uint*)"/>
            public static unsafe void DeleteMemoryObjects(uint[] memoryObjects)
            {
                int n = (int)(memoryObjects.Length);
                fixed (uint* memoryObjects_ptr = memoryObjects)
                {
                    DeleteMemoryObjects(n, memoryObjects_ptr);
                }
            }
            /// <inheritdoc cref="DeleteMemoryObjects(int, uint*)"/>
            public static unsafe void DeleteMemoryObjects(int n, in uint memoryObjects)
            {
                fixed (uint* memoryObjects_ptr = &memoryObjects)
                {
                    DeleteMemoryObjects(n, memoryObjects_ptr);
                }
            }
            /// <inheritdoc cref="CreateMemoryObjects(int, uint*)"/>
            public static unsafe void CreateMemoryObjects(int n, ref uint memoryObjects)
            {
                fixed (uint* memoryObjects_ptr = &memoryObjects)
                {
                    CreateMemoryObjects(n, memoryObjects_ptr);
                }
            }
            /// <inheritdoc cref="MemoryObjectParameteriv(uint, MemoryObjectParameterName, int*)"/>
            public static unsafe void MemoryObjectParameteriv(uint memoryObject, MemoryObjectParameterName pname, in int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    MemoryObjectParameteriv(memoryObject, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetMemoryObjectParameteriv(uint, MemoryObjectParameterName, int*)"/>
            public static unsafe void GetMemoryObjectParameteriv(uint memoryObject, MemoryObjectParameterName pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetMemoryObjectParameteriv(memoryObject, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="ImportMemoryWin32Handle(uint, ulong, ExternalHandleType, void*)"/>
            public static unsafe void ImportMemoryWin32Handle(uint memory, ulong size, ExternalHandleType handleType, IntPtr handle)
            {
                void* handle_vptr = (void*)handle;
                ImportMemoryWin32Handle(memory, size, handleType, handle_vptr);
            }
            /// <inheritdoc cref="ImportMemoryWin32Handle(uint, ulong, ExternalHandleType, void*)"/>
            public static unsafe void ImportMemoryWin32Handle<T1>(uint memory, ulong size, ExternalHandleType handleType, ref T1 handle)
                where T1 : unmanaged
            {
                fixed (void* handle_ptr = &handle)
                {
                    ImportMemoryWin32Handle(memory, size, handleType, handle_ptr);
                }
            }
            /// <inheritdoc cref="ImportMemoryWin32Name(uint, ulong, ExternalHandleType, void*)"/>
            public static unsafe void ImportMemoryWin32Name(uint memory, ulong size, ExternalHandleType handleType, IntPtr name)
            {
                void* name_vptr = (void*)name;
                ImportMemoryWin32Name(memory, size, handleType, name_vptr);
            }
            /// <inheritdoc cref="ImportMemoryWin32Name(uint, ulong, ExternalHandleType, void*)"/>
            public static unsafe void ImportMemoryWin32Name<T1>(uint memory, ulong size, ExternalHandleType handleType, in T1 name)
                where T1 : unmanaged
            {
                fixed (void* name_ptr = &name)
                {
                    ImportMemoryWin32Name(memory, size, handleType, name_ptr);
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
            /// <inheritdoc cref="MultiDrawArraysIndirect(PrimitiveType, void*, int, int)"/>
            public static unsafe void MultiDrawArraysIndirect(PrimitiveType mode, IntPtr indirect, int drawcount, int stride)
            {
                void* indirect_vptr = (void*)indirect;
                MultiDrawArraysIndirect(mode, indirect_vptr, drawcount, stride);
            }
            /// <inheritdoc cref="MultiDrawArraysIndirect(PrimitiveType, void*, int, int)"/>
            public static unsafe void MultiDrawArraysIndirect<T1>(PrimitiveType mode, ReadOnlySpan<T1> indirect, int drawcount, int stride)
                where T1 : unmanaged
            {
                fixed (void* indirect_ptr = indirect)
                {
                    MultiDrawArraysIndirect(mode, indirect_ptr, drawcount, stride);
                }
            }
            /// <inheritdoc cref="MultiDrawArraysIndirect(PrimitiveType, void*, int, int)"/>
            public static unsafe void MultiDrawArraysIndirect<T1>(PrimitiveType mode, T1[] indirect, int drawcount, int stride)
                where T1 : unmanaged
            {
                fixed (void* indirect_ptr = indirect)
                {
                    MultiDrawArraysIndirect(mode, indirect_ptr, drawcount, stride);
                }
            }
            /// <inheritdoc cref="MultiDrawArraysIndirect(PrimitiveType, void*, int, int)"/>
            public static unsafe void MultiDrawArraysIndirect<T1>(PrimitiveType mode, in T1 indirect, int drawcount, int stride)
                where T1 : unmanaged
            {
                fixed (void* indirect_ptr = &indirect)
                {
                    MultiDrawArraysIndirect(mode, indirect_ptr, drawcount, stride);
                }
            }
            /// <inheritdoc cref="MultiDrawElementsIndirect(PrimitiveType, DrawElementsType, void*, int, int)"/>
            public static unsafe void MultiDrawElementsIndirect(PrimitiveType mode, DrawElementsType type, IntPtr indirect, int drawcount, int stride)
            {
                void* indirect_vptr = (void*)indirect;
                MultiDrawElementsIndirect(mode, type, indirect_vptr, drawcount, stride);
            }
            /// <inheritdoc cref="MultiDrawElementsIndirect(PrimitiveType, DrawElementsType, void*, int, int)"/>
            public static unsafe void MultiDrawElementsIndirect<T1>(PrimitiveType mode, DrawElementsType type, ReadOnlySpan<T1> indirect, int drawcount, int stride)
                where T1 : unmanaged
            {
                fixed (void* indirect_ptr = indirect)
                {
                    MultiDrawElementsIndirect(mode, type, indirect_ptr, drawcount, stride);
                }
            }
            /// <inheritdoc cref="MultiDrawElementsIndirect(PrimitiveType, DrawElementsType, void*, int, int)"/>
            public static unsafe void MultiDrawElementsIndirect<T1>(PrimitiveType mode, DrawElementsType type, T1[] indirect, int drawcount, int stride)
                where T1 : unmanaged
            {
                fixed (void* indirect_ptr = indirect)
                {
                    MultiDrawElementsIndirect(mode, type, indirect_ptr, drawcount, stride);
                }
            }
            /// <inheritdoc cref="MultiDrawElementsIndirect(PrimitiveType, DrawElementsType, void*, int, int)"/>
            public static unsafe void MultiDrawElementsIndirect<T1>(PrimitiveType mode, DrawElementsType type, in T1 indirect, int drawcount, int stride)
                where T1 : unmanaged
            {
                fixed (void* indirect_ptr = &indirect)
                {
                    MultiDrawElementsIndirect(mode, type, indirect_ptr, drawcount, stride);
                }
            }
            /// <inheritdoc cref="DrawBuffersIndexed(int, All*, int*)"/>
            public static unsafe void DrawBuffersIndexed(int n, ReadOnlySpan<All> location, ReadOnlySpan<int> indices)
            {
                fixed (All* location_ptr = location)
                {
                    fixed (int* indices_ptr = indices)
                    {
                        DrawBuffersIndexed(n, location_ptr, indices_ptr);
                    }
                }
            }
            /// <inheritdoc cref="DrawBuffersIndexed(int, All*, int*)"/>
            public static unsafe void DrawBuffersIndexed(int n, All[] location, int[] indices)
            {
                fixed (All* location_ptr = location)
                {
                    fixed (int* indices_ptr = indices)
                    {
                        DrawBuffersIndexed(n, location_ptr, indices_ptr);
                    }
                }
            }
            /// <inheritdoc cref="DrawBuffersIndexed(int, All*, int*)"/>
            public static unsafe void DrawBuffersIndexed(int n, in All location, in int indices)
            {
                fixed (All* location_ptr = &location)
                fixed (int* indices_ptr = &indices)
                {
                    DrawBuffersIndexed(n, location_ptr, indices_ptr);
                }
            }
            /// <inheritdoc cref="GetIntegeri_v(GetPName, uint, int*)"/>
            public static unsafe void GetIntegeri_v(GetPName target, uint index, ref int data)
            {
                fixed (int* data_ptr = &data)
                {
                    GetIntegeri_v(target, index, data_ptr);
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
            /// <inheritdoc cref="GenSemaphores(int, uint*)"/>
            public static unsafe void GenSemaphores(Span<uint> semaphores)
            {
                int n = (int)(semaphores.Length);
                fixed (uint* semaphores_ptr = semaphores)
                {
                    GenSemaphores(n, semaphores_ptr);
                }
            }
            /// <inheritdoc cref="GenSemaphores(int, uint*)"/>
            public static unsafe void GenSemaphores(uint[] semaphores)
            {
                int n = (int)(semaphores.Length);
                fixed (uint* semaphores_ptr = semaphores)
                {
                    GenSemaphores(n, semaphores_ptr);
                }
            }
            /// <inheritdoc cref="GenSemaphores(int, uint*)"/>
            public static unsafe void GenSemaphores(int n, ref uint semaphores)
            {
                fixed (uint* semaphores_ptr = &semaphores)
                {
                    GenSemaphores(n, semaphores_ptr);
                }
            }
            /// <inheritdoc cref="DeleteSemaphores(int, uint*)"/>
            public static unsafe void DeleteSemaphores(ReadOnlySpan<uint> semaphores)
            {
                int n = (int)(semaphores.Length);
                fixed (uint* semaphores_ptr = semaphores)
                {
                    DeleteSemaphores(n, semaphores_ptr);
                }
            }
            /// <inheritdoc cref="DeleteSemaphores(int, uint*)"/>
            public static unsafe void DeleteSemaphores(uint[] semaphores)
            {
                int n = (int)(semaphores.Length);
                fixed (uint* semaphores_ptr = semaphores)
                {
                    DeleteSemaphores(n, semaphores_ptr);
                }
            }
            /// <inheritdoc cref="DeleteSemaphores(int, uint*)"/>
            public static unsafe void DeleteSemaphores(int n, in uint semaphores)
            {
                fixed (uint* semaphores_ptr = &semaphores)
                {
                    DeleteSemaphores(n, semaphores_ptr);
                }
            }
            /// <inheritdoc cref="SemaphoreParameterui64v(uint, SemaphoreParameterName, ulong*)"/>
            public static unsafe void SemaphoreParameterui64v(uint semaphore, SemaphoreParameterName pname, in ulong parameters)
            {
                fixed (ulong* parameters_ptr = &parameters)
                {
                    SemaphoreParameterui64v(semaphore, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetSemaphoreParameterui64v(uint, SemaphoreParameterName, ulong*)"/>
            public static unsafe void GetSemaphoreParameterui64v(uint semaphore, SemaphoreParameterName pname, ref ulong parameters)
            {
                fixed (ulong* parameters_ptr = &parameters)
                {
                    GetSemaphoreParameterui64v(semaphore, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="WaitSemaphore(uint, uint, int*, uint, int*, TextureLayout*)"/>
            public static unsafe void WaitSemaphore(uint semaphore, uint numBufferBarriers, ReadOnlySpan<int> buffers, uint numTextureBarriers, ReadOnlySpan<int> textures, ReadOnlySpan<TextureLayout> srcLayouts)
            {
                fixed (int* buffers_ptr = buffers)
                {
                    fixed (int* textures_ptr = textures)
                    {
                        fixed (TextureLayout* srcLayouts_ptr = srcLayouts)
                        {
                            WaitSemaphore(semaphore, numBufferBarriers, buffers_ptr, numTextureBarriers, textures_ptr, srcLayouts_ptr);
                        }
                    }
                }
            }
            /// <inheritdoc cref="WaitSemaphore(uint, uint, int*, uint, int*, TextureLayout*)"/>
            public static unsafe void WaitSemaphore(uint semaphore, uint numBufferBarriers, int[] buffers, uint numTextureBarriers, int[] textures, TextureLayout[] srcLayouts)
            {
                fixed (int* buffers_ptr = buffers)
                {
                    fixed (int* textures_ptr = textures)
                    {
                        fixed (TextureLayout* srcLayouts_ptr = srcLayouts)
                        {
                            WaitSemaphore(semaphore, numBufferBarriers, buffers_ptr, numTextureBarriers, textures_ptr, srcLayouts_ptr);
                        }
                    }
                }
            }
            /// <inheritdoc cref="WaitSemaphore(uint, uint, int*, uint, int*, TextureLayout*)"/>
            public static unsafe void WaitSemaphore(uint semaphore, uint numBufferBarriers, in int buffers, uint numTextureBarriers, in int textures, in TextureLayout srcLayouts)
            {
                fixed (int* buffers_ptr = &buffers)
                fixed (int* textures_ptr = &textures)
                fixed (TextureLayout* srcLayouts_ptr = &srcLayouts)
                {
                    WaitSemaphore(semaphore, numBufferBarriers, buffers_ptr, numTextureBarriers, textures_ptr, srcLayouts_ptr);
                }
            }
            /// <inheritdoc cref="SignalSemaphore(uint, uint, int*, uint, int*, TextureLayout*)"/>
            public static unsafe void SignalSemaphore(uint semaphore, uint numBufferBarriers, ReadOnlySpan<int> buffers, uint numTextureBarriers, ReadOnlySpan<int> textures, ReadOnlySpan<TextureLayout> dstLayouts)
            {
                fixed (int* buffers_ptr = buffers)
                {
                    fixed (int* textures_ptr = textures)
                    {
                        fixed (TextureLayout* dstLayouts_ptr = dstLayouts)
                        {
                            SignalSemaphore(semaphore, numBufferBarriers, buffers_ptr, numTextureBarriers, textures_ptr, dstLayouts_ptr);
                        }
                    }
                }
            }
            /// <inheritdoc cref="SignalSemaphore(uint, uint, int*, uint, int*, TextureLayout*)"/>
            public static unsafe void SignalSemaphore(uint semaphore, uint numBufferBarriers, int[] buffers, uint numTextureBarriers, int[] textures, TextureLayout[] dstLayouts)
            {
                fixed (int* buffers_ptr = buffers)
                {
                    fixed (int* textures_ptr = textures)
                    {
                        fixed (TextureLayout* dstLayouts_ptr = dstLayouts)
                        {
                            SignalSemaphore(semaphore, numBufferBarriers, buffers_ptr, numTextureBarriers, textures_ptr, dstLayouts_ptr);
                        }
                    }
                }
            }
            /// <inheritdoc cref="SignalSemaphore(uint, uint, int*, uint, int*, TextureLayout*)"/>
            public static unsafe void SignalSemaphore(uint semaphore, uint numBufferBarriers, in int buffers, uint numTextureBarriers, in int textures, in TextureLayout dstLayouts)
            {
                fixed (int* buffers_ptr = &buffers)
                fixed (int* textures_ptr = &textures)
                fixed (TextureLayout* dstLayouts_ptr = &dstLayouts)
                {
                    SignalSemaphore(semaphore, numBufferBarriers, buffers_ptr, numTextureBarriers, textures_ptr, dstLayouts_ptr);
                }
            }
            /// <inheritdoc cref="ImportSemaphoreWin32Handle(uint, ExternalHandleType, void*)"/>
            public static unsafe void ImportSemaphoreWin32Handle(uint semaphore, ExternalHandleType handleType, IntPtr handle)
            {
                void* handle_vptr = (void*)handle;
                ImportSemaphoreWin32Handle(semaphore, handleType, handle_vptr);
            }
            /// <inheritdoc cref="ImportSemaphoreWin32Handle(uint, ExternalHandleType, void*)"/>
            public static unsafe void ImportSemaphoreWin32Handle<T1>(uint semaphore, ExternalHandleType handleType, ref T1 handle)
                where T1 : unmanaged
            {
                fixed (void* handle_ptr = &handle)
                {
                    ImportSemaphoreWin32Handle(semaphore, handleType, handle_ptr);
                }
            }
            /// <inheritdoc cref="ImportSemaphoreWin32Name(uint, ExternalHandleType, void*)"/>
            public static unsafe void ImportSemaphoreWin32Name(uint semaphore, ExternalHandleType handleType, IntPtr name)
            {
                void* name_vptr = (void*)name;
                ImportSemaphoreWin32Name(semaphore, handleType, name_vptr);
            }
            /// <inheritdoc cref="ImportSemaphoreWin32Name(uint, ExternalHandleType, void*)"/>
            public static unsafe void ImportSemaphoreWin32Name<T1>(uint semaphore, ExternalHandleType handleType, in T1 name)
                where T1 : unmanaged
            {
                fixed (void* name_ptr = &name)
                {
                    ImportSemaphoreWin32Name(semaphore, handleType, name_ptr);
                }
            }
            /// <inheritdoc cref="CreateShaderProgram(ShaderType, byte*)"/>
            public static unsafe int CreateShaderProgram(ShaderType type, string str)
            {
                int returnValue;
                byte* str_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(str);
                returnValue = CreateShaderProgram(type, str_ptr);
                Marshal.FreeCoTaskMem((IntPtr)str_ptr);
                return returnValue;
            }
            /// <inheritdoc cref="DeleteProgramPipelines(int, int*)"/>
            public static unsafe void DeleteProgramPipelines(ReadOnlySpan<int> pipelines)
            {
                int n = (int)(pipelines.Length);
                fixed (int* pipelines_ptr = pipelines)
                {
                    DeleteProgramPipelines(n, pipelines_ptr);
                }
            }
            /// <inheritdoc cref="DeleteProgramPipelines(int, int*)"/>
            public static unsafe void DeleteProgramPipelines(int[] pipelines)
            {
                int n = (int)(pipelines.Length);
                fixed (int* pipelines_ptr = pipelines)
                {
                    DeleteProgramPipelines(n, pipelines_ptr);
                }
            }
            /// <inheritdoc cref="DeleteProgramPipelines(int, int*)"/>
            public static unsafe void DeleteProgramPipelines(int n, in int pipelines)
            {
                fixed (int* pipelines_ptr = &pipelines)
                {
                    DeleteProgramPipelines(n, pipelines_ptr);
                }
            }
            /// <inheritdoc cref="GenProgramPipelines(int, int*)"/>
            public static unsafe void GenProgramPipelines(Span<int> pipelines)
            {
                int n = (int)(pipelines.Length);
                fixed (int* pipelines_ptr = pipelines)
                {
                    GenProgramPipelines(n, pipelines_ptr);
                }
            }
            /// <inheritdoc cref="GenProgramPipelines(int, int*)"/>
            public static unsafe void GenProgramPipelines(int[] pipelines)
            {
                int n = (int)(pipelines.Length);
                fixed (int* pipelines_ptr = pipelines)
                {
                    GenProgramPipelines(n, pipelines_ptr);
                }
            }
            /// <inheritdoc cref="GenProgramPipelines(int, int*)"/>
            public static unsafe void GenProgramPipelines(int n, ref int pipelines)
            {
                fixed (int* pipelines_ptr = &pipelines)
                {
                    GenProgramPipelines(n, pipelines_ptr);
                }
            }
            /// <inheritdoc cref="GetProgramPipelineInfoLog(int, int, int*, byte*)"/>
            public static unsafe string GetProgramPipelineInfoLog(int pipeline, int bufSize, Span<int> length)
            {
                string infoLog;
                fixed (int* length_ptr = length)
                {
                    var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetProgramPipelineInfoLog(pipeline, bufSize, length_ptr, infoLog_ptr);
                    infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
                }
                return infoLog;
            }
            /// <inheritdoc cref="GetProgramPipelineInfoLog(int, int, int*, byte*)"/>
            public static unsafe void GetProgramPipelineInfoLog(int pipeline, int bufSize, Span<int> length, out string infoLog)
            {
                fixed (int* length_ptr = length)
                {
                    var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetProgramPipelineInfoLog(pipeline, bufSize, length_ptr, infoLog_ptr);
                    infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
                }
            }
            /// <inheritdoc cref="GetProgramPipelineInfoLog(int, int, int*, byte*)"/>
            public static unsafe string GetProgramPipelineInfoLog(int pipeline, int bufSize, int[] length)
            {
                string infoLog;
                fixed (int* length_ptr = length)
                {
                    var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetProgramPipelineInfoLog(pipeline, bufSize, length_ptr, infoLog_ptr);
                    infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
                }
                return infoLog;
            }
            /// <inheritdoc cref="GetProgramPipelineInfoLog(int, int, int*, byte*)"/>
            public static unsafe void GetProgramPipelineInfoLog(int pipeline, int bufSize, int[] length, out string infoLog)
            {
                fixed (int* length_ptr = length)
                {
                    var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetProgramPipelineInfoLog(pipeline, bufSize, length_ptr, infoLog_ptr);
                    infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
                }
            }
            /// <inheritdoc cref="GetProgramPipelineInfoLog(int, int, int*, byte*)"/>
            public static unsafe string GetProgramPipelineInfoLog(int pipeline, int bufSize, ref int length)
            {
                string infoLog;
                fixed (int* length_ptr = &length)
                {
                    var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetProgramPipelineInfoLog(pipeline, bufSize, length_ptr, infoLog_ptr);
                    infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
                }
                return infoLog;
            }
            /// <inheritdoc cref="GetProgramPipelineInfoLog(int, int, int*, byte*)"/>
            public static unsafe void GetProgramPipelineInfoLog(int pipeline, int bufSize, ref int length, out string infoLog)
            {
                fixed (int* length_ptr = &length)
                {
                    var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetProgramPipelineInfoLog(pipeline, bufSize, length_ptr, infoLog_ptr);
                    infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
                }
            }
            /// <inheritdoc cref="GetProgramPipelineiv(int, PipelineParameterName, int*)"/>
            public static unsafe void GetProgramPipelineiv(int pipeline, PipelineParameterName pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetProgramPipelineiv(pipeline, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform1fv(int, int, int, float*)"/>
            public static unsafe void ProgramUniform1fv(int program, int location, int count, in float value)
            {
                fixed (float* tmp_value = &value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniform1fv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform1iv(int, int, int, int*)"/>
            public static unsafe void ProgramUniform1iv(int program, int location, int count, in int value)
            {
                fixed (int* tmp_value = &value)
                {
                    int* value_ptr = (int*)tmp_value;
                    ProgramUniform1iv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2fv(int, int, int, float*)"/>
            public static unsafe void ProgramUniform2fv(int program, int location, int count, in Vector2 value)
            {
                fixed (Vector2* tmp_value = &value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniform2fv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2fv(int, int, int, float*)"/>
            public static unsafe void ProgramUniform2fv(int program, int location, int count, ReadOnlySpan<Vector2> value)
            {
                fixed (Vector2* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniform2fv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2fv(int, int, int, float*)"/>
            public static unsafe void ProgramUniform2fv(int program, int location, int count, Vector2[] value)
            {
                fixed (Vector2* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniform2fv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2fv(int, int, int, float*)"/>
            public static unsafe void ProgramUniform2fv(int program, int location, int count, in System.Numerics.Vector2 value)
            {
                fixed (System.Numerics.Vector2* tmp_value = &value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniform2fv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2fv(int, int, int, float*)"/>
            public static unsafe void ProgramUniform2fv(int program, int location, int count, ReadOnlySpan<System.Numerics.Vector2> value)
            {
                fixed (System.Numerics.Vector2* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniform2fv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2fv(int, int, int, float*)"/>
            public static unsafe void ProgramUniform2fv(int program, int location, int count, System.Numerics.Vector2[] value)
            {
                fixed (System.Numerics.Vector2* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniform2fv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2iv(int, int, int, int*)"/>
            public static unsafe void ProgramUniform2iv(int program, int location, int count, in Vector2i value)
            {
                fixed (Vector2i* tmp_value = &value)
                {
                    int* value_ptr = (int*)tmp_value;
                    ProgramUniform2iv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2iv(int, int, int, int*)"/>
            public static unsafe void ProgramUniform2iv(int program, int location, int count, ReadOnlySpan<Vector2i> value)
            {
                fixed (Vector2i* tmp_value = value)
                {
                    int* value_ptr = (int*)tmp_value;
                    ProgramUniform2iv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2iv(int, int, int, int*)"/>
            public static unsafe void ProgramUniform2iv(int program, int location, int count, Vector2i[] value)
            {
                fixed (Vector2i* tmp_value = value)
                {
                    int* value_ptr = (int*)tmp_value;
                    ProgramUniform2iv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3fv(int, int, int, float*)"/>
            public static unsafe void ProgramUniform3fv(int program, int location, int count, in Vector3 value)
            {
                fixed (Vector3* tmp_value = &value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniform3fv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3fv(int, int, int, float*)"/>
            public static unsafe void ProgramUniform3fv(int program, int location, int count, ReadOnlySpan<Vector3> value)
            {
                fixed (Vector3* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniform3fv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3fv(int, int, int, float*)"/>
            public static unsafe void ProgramUniform3fv(int program, int location, int count, Vector3[] value)
            {
                fixed (Vector3* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniform3fv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3fv(int, int, int, float*)"/>
            public static unsafe void ProgramUniform3fv(int program, int location, int count, in System.Numerics.Vector3 value)
            {
                fixed (System.Numerics.Vector3* tmp_value = &value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniform3fv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3fv(int, int, int, float*)"/>
            public static unsafe void ProgramUniform3fv(int program, int location, int count, ReadOnlySpan<System.Numerics.Vector3> value)
            {
                fixed (System.Numerics.Vector3* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniform3fv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3fv(int, int, int, float*)"/>
            public static unsafe void ProgramUniform3fv(int program, int location, int count, System.Numerics.Vector3[] value)
            {
                fixed (System.Numerics.Vector3* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniform3fv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3iv(int, int, int, int*)"/>
            public static unsafe void ProgramUniform3iv(int program, int location, int count, in Vector3i value)
            {
                fixed (Vector3i* tmp_value = &value)
                {
                    int* value_ptr = (int*)tmp_value;
                    ProgramUniform3iv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3iv(int, int, int, int*)"/>
            public static unsafe void ProgramUniform3iv(int program, int location, int count, ReadOnlySpan<Vector3i> value)
            {
                fixed (Vector3i* tmp_value = value)
                {
                    int* value_ptr = (int*)tmp_value;
                    ProgramUniform3iv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3iv(int, int, int, int*)"/>
            public static unsafe void ProgramUniform3iv(int program, int location, int count, Vector3i[] value)
            {
                fixed (Vector3i* tmp_value = value)
                {
                    int* value_ptr = (int*)tmp_value;
                    ProgramUniform3iv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4fv(int, int, int, float*)"/>
            public static unsafe void ProgramUniform4fv(int program, int location, int count, in Vector4 value)
            {
                fixed (Vector4* tmp_value = &value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniform4fv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4fv(int, int, int, float*)"/>
            public static unsafe void ProgramUniform4fv(int program, int location, int count, ReadOnlySpan<Vector4> value)
            {
                fixed (Vector4* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniform4fv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4fv(int, int, int, float*)"/>
            public static unsafe void ProgramUniform4fv(int program, int location, int count, Vector4[] value)
            {
                fixed (Vector4* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniform4fv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4fv(int, int, int, float*)"/>
            public static unsafe void ProgramUniform4fv(int program, int location, int count, in System.Numerics.Vector4 value)
            {
                fixed (System.Numerics.Vector4* tmp_value = &value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniform4fv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4fv(int, int, int, float*)"/>
            public static unsafe void ProgramUniform4fv(int program, int location, int count, ReadOnlySpan<System.Numerics.Vector4> value)
            {
                fixed (System.Numerics.Vector4* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniform4fv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4fv(int, int, int, float*)"/>
            public static unsafe void ProgramUniform4fv(int program, int location, int count, System.Numerics.Vector4[] value)
            {
                fixed (System.Numerics.Vector4* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniform4fv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4iv(int, int, int, int*)"/>
            public static unsafe void ProgramUniform4iv(int program, int location, int count, in Vector4i value)
            {
                fixed (Vector4i* tmp_value = &value)
                {
                    int* value_ptr = (int*)tmp_value;
                    ProgramUniform4iv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4iv(int, int, int, int*)"/>
            public static unsafe void ProgramUniform4iv(int program, int location, int count, ReadOnlySpan<Vector4i> value)
            {
                fixed (Vector4i* tmp_value = value)
                {
                    int* value_ptr = (int*)tmp_value;
                    ProgramUniform4iv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4iv(int, int, int, int*)"/>
            public static unsafe void ProgramUniform4iv(int program, int location, int count, Vector4i[] value)
            {
                fixed (Vector4i* tmp_value = value)
                {
                    int* value_ptr = (int*)tmp_value;
                    ProgramUniform4iv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix2fv(int, int, int, bool, float*)"/>
            public static unsafe void ProgramUniformMatrix2fv(int program, int location, int count, bool transpose, in Matrix2 value)
            {
                fixed (Matrix2* tmp_value = &value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniformMatrix2fv(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix2fv(int, int, int, bool, float*)"/>
            public static unsafe void ProgramUniformMatrix2fv(int program, int location, int count, bool transpose, ReadOnlySpan<Matrix2> value)
            {
                fixed (Matrix2* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniformMatrix2fv(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix2fv(int, int, int, bool, float*)"/>
            public static unsafe void ProgramUniformMatrix2fv(int program, int location, int count, bool transpose, Matrix2[] value)
            {
                fixed (Matrix2* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniformMatrix2fv(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix3fv(int, int, int, bool, float*)"/>
            public static unsafe void ProgramUniformMatrix3fv(int program, int location, int count, bool transpose, in Matrix3 value)
            {
                fixed (Matrix3* tmp_value = &value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniformMatrix3fv(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix3fv(int, int, int, bool, float*)"/>
            public static unsafe void ProgramUniformMatrix3fv(int program, int location, int count, bool transpose, ReadOnlySpan<Matrix3> value)
            {
                fixed (Matrix3* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniformMatrix3fv(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix3fv(int, int, int, bool, float*)"/>
            public static unsafe void ProgramUniformMatrix3fv(int program, int location, int count, bool transpose, Matrix3[] value)
            {
                fixed (Matrix3* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniformMatrix3fv(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix4fv(int, int, int, bool, float*)"/>
            public static unsafe void ProgramUniformMatrix4fv(int program, int location, int count, bool transpose, in Matrix4 value)
            {
                fixed (Matrix4* tmp_value = &value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniformMatrix4fv(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix4fv(int, int, int, bool, float*)"/>
            public static unsafe void ProgramUniformMatrix4fv(int program, int location, int count, bool transpose, ReadOnlySpan<Matrix4> value)
            {
                fixed (Matrix4* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniformMatrix4fv(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix4fv(int, int, int, bool, float*)"/>
            public static unsafe void ProgramUniformMatrix4fv(int program, int location, int count, bool transpose, Matrix4[] value)
            {
                fixed (Matrix4* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniformMatrix4fv(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix4fv(int, int, int, bool, float*)"/>
            public static unsafe void ProgramUniformMatrix4fv(int program, int location, int count, bool transpose, in System.Numerics.Matrix4x4 value)
            {
                fixed (System.Numerics.Matrix4x4* tmp_value = &value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniformMatrix4fv(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix4fv(int, int, int, bool, float*)"/>
            public static unsafe void ProgramUniformMatrix4fv(int program, int location, int count, bool transpose, ReadOnlySpan<System.Numerics.Matrix4x4> value)
            {
                fixed (System.Numerics.Matrix4x4* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniformMatrix4fv(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix4fv(int, int, int, bool, float*)"/>
            public static unsafe void ProgramUniformMatrix4fv(int program, int location, int count, bool transpose, System.Numerics.Matrix4x4[] value)
            {
                fixed (System.Numerics.Matrix4x4* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniformMatrix4fv(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform1uiv(int, int, int, uint*)"/>
            public static unsafe void ProgramUniform1uiv(int program, int location, int count, in uint value)
            {
                fixed (uint* tmp_value = &value)
                {
                    uint* value_ptr = (uint*)tmp_value;
                    ProgramUniform1uiv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2uiv(int, int, int, uint*)"/>
            public static unsafe void ProgramUniform2uiv(int program, int location, int count, in Vector2i value)
            {
                fixed (Vector2i* tmp_value = &value)
                {
                    uint* value_ptr = (uint*)tmp_value;
                    ProgramUniform2uiv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2uiv(int, int, int, uint*)"/>
            public static unsafe void ProgramUniform2uiv(int program, int location, int count, ReadOnlySpan<Vector2i> value)
            {
                fixed (Vector2i* tmp_value = value)
                {
                    uint* value_ptr = (uint*)tmp_value;
                    ProgramUniform2uiv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2uiv(int, int, int, uint*)"/>
            public static unsafe void ProgramUniform2uiv(int program, int location, int count, Vector2i[] value)
            {
                fixed (Vector2i* tmp_value = value)
                {
                    uint* value_ptr = (uint*)tmp_value;
                    ProgramUniform2uiv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3uiv(int, int, int, uint*)"/>
            public static unsafe void ProgramUniform3uiv(int program, int location, int count, in Vector3i value)
            {
                fixed (Vector3i* tmp_value = &value)
                {
                    uint* value_ptr = (uint*)tmp_value;
                    ProgramUniform3uiv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3uiv(int, int, int, uint*)"/>
            public static unsafe void ProgramUniform3uiv(int program, int location, int count, ReadOnlySpan<Vector3i> value)
            {
                fixed (Vector3i* tmp_value = value)
                {
                    uint* value_ptr = (uint*)tmp_value;
                    ProgramUniform3uiv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3uiv(int, int, int, uint*)"/>
            public static unsafe void ProgramUniform3uiv(int program, int location, int count, Vector3i[] value)
            {
                fixed (Vector3i* tmp_value = value)
                {
                    uint* value_ptr = (uint*)tmp_value;
                    ProgramUniform3uiv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4uiv(int, int, int, uint*)"/>
            public static unsafe void ProgramUniform4uiv(int program, int location, int count, in Vector4i value)
            {
                fixed (Vector4i* tmp_value = &value)
                {
                    uint* value_ptr = (uint*)tmp_value;
                    ProgramUniform4uiv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4uiv(int, int, int, uint*)"/>
            public static unsafe void ProgramUniform4uiv(int program, int location, int count, ReadOnlySpan<Vector4i> value)
            {
                fixed (Vector4i* tmp_value = value)
                {
                    uint* value_ptr = (uint*)tmp_value;
                    ProgramUniform4uiv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4uiv(int, int, int, uint*)"/>
            public static unsafe void ProgramUniform4uiv(int program, int location, int count, Vector4i[] value)
            {
                fixed (Vector4i* tmp_value = value)
                {
                    uint* value_ptr = (uint*)tmp_value;
                    ProgramUniform4uiv(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix2x3fv(int, int, int, bool, float*)"/>
            public static unsafe void ProgramUniformMatrix2x3fv(int program, int location, int count, bool transpose, in Matrix2x3 value)
            {
                fixed (Matrix2x3* tmp_value = &value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniformMatrix2x3fv(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix2x3fv(int, int, int, bool, float*)"/>
            public static unsafe void ProgramUniformMatrix2x3fv(int program, int location, int count, bool transpose, ReadOnlySpan<Matrix2x3> value)
            {
                fixed (Matrix2x3* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniformMatrix2x3fv(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix2x3fv(int, int, int, bool, float*)"/>
            public static unsafe void ProgramUniformMatrix2x3fv(int program, int location, int count, bool transpose, Matrix2x3[] value)
            {
                fixed (Matrix2x3* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniformMatrix2x3fv(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix3x2fv(int, int, int, bool, float*)"/>
            public static unsafe void ProgramUniformMatrix3x2fv(int program, int location, int count, bool transpose, in Matrix3x2 value)
            {
                fixed (Matrix3x2* tmp_value = &value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniformMatrix3x2fv(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix3x2fv(int, int, int, bool, float*)"/>
            public static unsafe void ProgramUniformMatrix3x2fv(int program, int location, int count, bool transpose, ReadOnlySpan<Matrix3x2> value)
            {
                fixed (Matrix3x2* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniformMatrix3x2fv(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix3x2fv(int, int, int, bool, float*)"/>
            public static unsafe void ProgramUniformMatrix3x2fv(int program, int location, int count, bool transpose, Matrix3x2[] value)
            {
                fixed (Matrix3x2* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniformMatrix3x2fv(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix3x2fv(int, int, int, bool, float*)"/>
            public static unsafe void ProgramUniformMatrix3x2fv(int program, int location, int count, bool transpose, in System.Numerics.Matrix3x2 value)
            {
                fixed (System.Numerics.Matrix3x2* tmp_value = &value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniformMatrix3x2fv(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix3x2fv(int, int, int, bool, float*)"/>
            public static unsafe void ProgramUniformMatrix3x2fv(int program, int location, int count, bool transpose, ReadOnlySpan<System.Numerics.Matrix3x2> value)
            {
                fixed (System.Numerics.Matrix3x2* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniformMatrix3x2fv(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix3x2fv(int, int, int, bool, float*)"/>
            public static unsafe void ProgramUniformMatrix3x2fv(int program, int location, int count, bool transpose, System.Numerics.Matrix3x2[] value)
            {
                fixed (System.Numerics.Matrix3x2* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniformMatrix3x2fv(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix2x4fv(int, int, int, bool, float*)"/>
            public static unsafe void ProgramUniformMatrix2x4fv(int program, int location, int count, bool transpose, in Matrix2x4 value)
            {
                fixed (Matrix2x4* tmp_value = &value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniformMatrix2x4fv(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix2x4fv(int, int, int, bool, float*)"/>
            public static unsafe void ProgramUniformMatrix2x4fv(int program, int location, int count, bool transpose, ReadOnlySpan<Matrix2x4> value)
            {
                fixed (Matrix2x4* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniformMatrix2x4fv(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix2x4fv(int, int, int, bool, float*)"/>
            public static unsafe void ProgramUniformMatrix2x4fv(int program, int location, int count, bool transpose, Matrix2x4[] value)
            {
                fixed (Matrix2x4* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniformMatrix2x4fv(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix4x2fv(int, int, int, bool, float*)"/>
            public static unsafe void ProgramUniformMatrix4x2fv(int program, int location, int count, bool transpose, in Matrix4x2 value)
            {
                fixed (Matrix4x2* tmp_value = &value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniformMatrix4x2fv(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix4x2fv(int, int, int, bool, float*)"/>
            public static unsafe void ProgramUniformMatrix4x2fv(int program, int location, int count, bool transpose, ReadOnlySpan<Matrix4x2> value)
            {
                fixed (Matrix4x2* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniformMatrix4x2fv(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix4x2fv(int, int, int, bool, float*)"/>
            public static unsafe void ProgramUniformMatrix4x2fv(int program, int location, int count, bool transpose, Matrix4x2[] value)
            {
                fixed (Matrix4x2* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniformMatrix4x2fv(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix3x4fv(int, int, int, bool, float*)"/>
            public static unsafe void ProgramUniformMatrix3x4fv(int program, int location, int count, bool transpose, in Matrix3x4 value)
            {
                fixed (Matrix3x4* tmp_value = &value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniformMatrix3x4fv(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix3x4fv(int, int, int, bool, float*)"/>
            public static unsafe void ProgramUniformMatrix3x4fv(int program, int location, int count, bool transpose, ReadOnlySpan<Matrix3x4> value)
            {
                fixed (Matrix3x4* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniformMatrix3x4fv(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix3x4fv(int, int, int, bool, float*)"/>
            public static unsafe void ProgramUniformMatrix3x4fv(int program, int location, int count, bool transpose, Matrix3x4[] value)
            {
                fixed (Matrix3x4* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniformMatrix3x4fv(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix4x3fv(int, int, int, bool, float*)"/>
            public static unsafe void ProgramUniformMatrix4x3fv(int program, int location, int count, bool transpose, in Matrix4x3 value)
            {
                fixed (Matrix4x3* tmp_value = &value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniformMatrix4x3fv(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix4x3fv(int, int, int, bool, float*)"/>
            public static unsafe void ProgramUniformMatrix4x3fv(int program, int location, int count, bool transpose, ReadOnlySpan<Matrix4x3> value)
            {
                fixed (Matrix4x3* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniformMatrix4x3fv(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix4x3fv(int, int, int, bool, float*)"/>
            public static unsafe void ProgramUniformMatrix4x3fv(int program, int location, int count, bool transpose, Matrix4x3[] value)
            {
                fixed (Matrix4x3* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    ProgramUniformMatrix4x3fv(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ClearPixelLocalStorageui(int, int, uint*)"/>
            public static unsafe void ClearPixelLocalStorageui(int offset, ReadOnlySpan<uint> values)
            {
                int n = (int)(values.Length);
                fixed (uint* values_ptr = values)
                {
                    ClearPixelLocalStorageui(offset, n, values_ptr);
                }
            }
            /// <inheritdoc cref="ClearPixelLocalStorageui(int, int, uint*)"/>
            public static unsafe void ClearPixelLocalStorageui(int offset, uint[] values)
            {
                int n = (int)(values.Length);
                fixed (uint* values_ptr = values)
                {
                    ClearPixelLocalStorageui(offset, n, values_ptr);
                }
            }
            /// <inheritdoc cref="ClearPixelLocalStorageui(int, int, uint*)"/>
            public static unsafe void ClearPixelLocalStorageui(int offset, int n, in uint values)
            {
                fixed (uint* values_ptr = &values)
                {
                    ClearPixelLocalStorageui(offset, n, values_ptr);
                }
            }
            /// <inheritdoc cref="TexParameterIiv(TextureTarget, TextureParameterName, int*)"/>
            public static unsafe void TexParameterIiv(TextureTarget target, TextureParameterName pname, ReadOnlySpan<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    TexParameterIiv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexParameterIiv(TextureTarget, TextureParameterName, int*)"/>
            public static unsafe void TexParameterIiv(TextureTarget target, TextureParameterName pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    TexParameterIiv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexParameterIiv(TextureTarget, TextureParameterName, int*)"/>
            public static unsafe void TexParameterIiv(TextureTarget target, TextureParameterName pname, in int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    TexParameterIiv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexParameterIuiv(TextureTarget, TextureParameterName, uint*)"/>
            public static unsafe void TexParameterIuiv(TextureTarget target, TextureParameterName pname, ReadOnlySpan<uint> parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    TexParameterIuiv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexParameterIuiv(TextureTarget, TextureParameterName, uint*)"/>
            public static unsafe void TexParameterIuiv(TextureTarget target, TextureParameterName pname, uint[] parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    TexParameterIuiv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexParameterIuiv(TextureTarget, TextureParameterName, uint*)"/>
            public static unsafe void TexParameterIuiv(TextureTarget target, TextureParameterName pname, in uint parameters)
            {
                fixed (uint* parameters_ptr = &parameters)
                {
                    TexParameterIuiv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexParameterIiv(TextureTarget, GetTextureParameter, int*)"/>
            public static unsafe void GetTexParameterIiv(TextureTarget target, GetTextureParameter pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexParameterIiv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexParameterIiv(TextureTarget, GetTextureParameter, int*)"/>
            public static unsafe void GetTexParameterIiv(TextureTarget target, GetTextureParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexParameterIiv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexParameterIiv(TextureTarget, GetTextureParameter, int*)"/>
            public static unsafe void GetTexParameterIiv(TextureTarget target, GetTextureParameter pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetTexParameterIiv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexParameterIuiv(TextureTarget, GetTextureParameter, uint*)"/>
            public static unsafe void GetTexParameterIuiv(TextureTarget target, GetTextureParameter pname, Span<uint> parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    GetTexParameterIuiv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexParameterIuiv(TextureTarget, GetTextureParameter, uint*)"/>
            public static unsafe void GetTexParameterIuiv(TextureTarget target, GetTextureParameter pname, uint[] parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    GetTexParameterIuiv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexParameterIuiv(TextureTarget, GetTextureParameter, uint*)"/>
            public static unsafe void GetTexParameterIuiv(TextureTarget target, GetTextureParameter pname, ref uint parameters)
            {
                fixed (uint* parameters_ptr = &parameters)
                {
                    GetTexParameterIuiv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="SamplerParameterIiv(int, SamplerParameterI, int*)"/>
            public static unsafe void SamplerParameterIiv(int sampler, SamplerParameterI pname, ReadOnlySpan<int> param)
            {
                fixed (int* param_ptr = param)
                {
                    SamplerParameterIiv(sampler, pname, param_ptr);
                }
            }
            /// <inheritdoc cref="SamplerParameterIiv(int, SamplerParameterI, int*)"/>
            public static unsafe void SamplerParameterIiv(int sampler, SamplerParameterI pname, int[] param)
            {
                fixed (int* param_ptr = param)
                {
                    SamplerParameterIiv(sampler, pname, param_ptr);
                }
            }
            /// <inheritdoc cref="SamplerParameterIiv(int, SamplerParameterI, int*)"/>
            public static unsafe void SamplerParameterIiv(int sampler, SamplerParameterI pname, in int param)
            {
                fixed (int* param_ptr = &param)
                {
                    SamplerParameterIiv(sampler, pname, param_ptr);
                }
            }
            /// <inheritdoc cref="SamplerParameterIuiv(int, SamplerParameterI, uint*)"/>
            public static unsafe void SamplerParameterIuiv(int sampler, SamplerParameterI pname, ReadOnlySpan<uint> param)
            {
                fixed (uint* param_ptr = param)
                {
                    SamplerParameterIuiv(sampler, pname, param_ptr);
                }
            }
            /// <inheritdoc cref="SamplerParameterIuiv(int, SamplerParameterI, uint*)"/>
            public static unsafe void SamplerParameterIuiv(int sampler, SamplerParameterI pname, uint[] param)
            {
                fixed (uint* param_ptr = param)
                {
                    SamplerParameterIuiv(sampler, pname, param_ptr);
                }
            }
            /// <inheritdoc cref="SamplerParameterIuiv(int, SamplerParameterI, uint*)"/>
            public static unsafe void SamplerParameterIuiv(int sampler, SamplerParameterI pname, in uint param)
            {
                fixed (uint* param_ptr = &param)
                {
                    SamplerParameterIuiv(sampler, pname, param_ptr);
                }
            }
            /// <inheritdoc cref="GetSamplerParameterIiv(int, SamplerParameterI, int*)"/>
            public static unsafe void GetSamplerParameterIiv(int sampler, SamplerParameterI pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetSamplerParameterIiv(sampler, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetSamplerParameterIiv(int, SamplerParameterI, int*)"/>
            public static unsafe void GetSamplerParameterIiv(int sampler, SamplerParameterI pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetSamplerParameterIiv(sampler, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetSamplerParameterIiv(int, SamplerParameterI, int*)"/>
            public static unsafe void GetSamplerParameterIiv(int sampler, SamplerParameterI pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetSamplerParameterIiv(sampler, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetSamplerParameterIuiv(int, SamplerParameterI, uint*)"/>
            public static unsafe void GetSamplerParameterIuiv(int sampler, SamplerParameterI pname, Span<uint> parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    GetSamplerParameterIuiv(sampler, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetSamplerParameterIuiv(int, SamplerParameterI, uint*)"/>
            public static unsafe void GetSamplerParameterIuiv(int sampler, SamplerParameterI pname, uint[] parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    GetSamplerParameterIuiv(sampler, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetSamplerParameterIuiv(int, SamplerParameterI, uint*)"/>
            public static unsafe void GetSamplerParameterIuiv(int sampler, SamplerParameterI pname, ref uint parameters)
            {
                fixed (uint* parameters_ptr = &parameters)
                {
                    GetSamplerParameterIuiv(sampler, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexStorageAttribs2D(TextureTarget, int, SizedInternalFormat, int, int, TexStorageAttribs*)"/>
            public static unsafe void TexStorageAttribs2D(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height, in TexStorageAttribs attrib_list)
            {
                fixed (TexStorageAttribs* attrib_list_ptr = &attrib_list)
                {
                    TexStorageAttribs2D(target, levels, internalformat, width, height, attrib_list_ptr);
                }
            }
            /// <inheritdoc cref="TexStorageAttribs3D(TextureTarget, int, SizedInternalFormat, int, int, int, TexStorageAttribs*)"/>
            public static unsafe void TexStorageAttribs3D(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height, int depth, in TexStorageAttribs attrib_list)
            {
                fixed (TexStorageAttribs* attrib_list_ptr = &attrib_list)
                {
                    TexStorageAttribs3D(target, levels, internalformat, width, height, depth, attrib_list_ptr);
                }
            }
            /// <inheritdoc cref="WindowRectangles(All, int, int*)"/>
            public static unsafe void WindowRectangles(All mode, int count, ReadOnlySpan<int> box)
            {
                fixed (int* box_ptr = box)
                {
                    WindowRectangles(mode, count, box_ptr);
                }
            }
            /// <inheritdoc cref="WindowRectangles(All, int, int*)"/>
            public static unsafe void WindowRectangles(All mode, int count, int[] box)
            {
                fixed (int* box_ptr = box)
                {
                    WindowRectangles(mode, count, box_ptr);
                }
            }
            /// <inheritdoc cref="WindowRectangles(All, int, int*)"/>
            public static unsafe void WindowRectangles(All mode, int count, in int box)
            {
                fixed (int* box_ptr = &box)
                {
                    WindowRectangles(mode, count, box_ptr);
                }
            }
        }
        public static unsafe partial class NV
        {
            /// <inheritdoc cref="CreateSemaphores(int, uint*)"/>
            public static unsafe void CreateSemaphores(Span<uint> semaphores)
            {
                int n = (int)(semaphores.Length);
                fixed (uint* semaphores_ptr = semaphores)
                {
                    CreateSemaphores(n, semaphores_ptr);
                }
            }
            /// <inheritdoc cref="CreateSemaphores(int, uint*)"/>
            public static unsafe void CreateSemaphores(uint[] semaphores)
            {
                int n = (int)(semaphores.Length);
                fixed (uint* semaphores_ptr = semaphores)
                {
                    CreateSemaphores(n, semaphores_ptr);
                }
            }
            /// <inheritdoc cref="CreateSemaphores(int, uint*)"/>
            public static unsafe void CreateSemaphores(int n, ref uint semaphores)
            {
                fixed (uint* semaphores_ptr = &semaphores)
                {
                    CreateSemaphores(n, semaphores_ptr);
                }
            }
            /// <inheritdoc cref="SemaphoreParameteriv(uint, SemaphoreParameterName, int*)"/>
            public static unsafe void SemaphoreParameteriv(uint semaphore, SemaphoreParameterName pname, in int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    SemaphoreParameteriv(semaphore, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetSemaphoreParameteriv(uint, SemaphoreParameterName, int*)"/>
            public static unsafe void GetSemaphoreParameteriv(uint semaphore, SemaphoreParameterName pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetSemaphoreParameteriv(semaphore, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="UniformHandleui64v(int, int, ulong*)"/>
            public static unsafe void UniformHandleui64v(int location, ReadOnlySpan<ulong> value)
            {
                int count = (int)(value.Length);
                fixed (ulong* value_ptr = value)
                {
                    UniformHandleui64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformHandleui64v(int, int, ulong*)"/>
            public static unsafe void UniformHandleui64v(int location, ulong[] value)
            {
                int count = (int)(value.Length);
                fixed (ulong* value_ptr = value)
                {
                    UniformHandleui64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformHandleui64v(int, int, ulong*)"/>
            public static unsafe void UniformHandleui64v(int location, int count, in ulong value)
            {
                fixed (ulong* value_ptr = &value)
                {
                    UniformHandleui64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformHandleui64v(int, int, int, ulong*)"/>
            public static unsafe void ProgramUniformHandleui64v(int program, int location, ReadOnlySpan<ulong> values)
            {
                int count = (int)(values.Length);
                fixed (ulong* values_ptr = values)
                {
                    ProgramUniformHandleui64v(program, location, count, values_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformHandleui64v(int, int, int, ulong*)"/>
            public static unsafe void ProgramUniformHandleui64v(int program, int location, ulong[] values)
            {
                int count = (int)(values.Length);
                fixed (ulong* values_ptr = values)
                {
                    ProgramUniformHandleui64v(program, location, count, values_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformHandleui64v(int, int, int, ulong*)"/>
            public static unsafe void ProgramUniformHandleui64v(int program, int location, int count, in ulong values)
            {
                fixed (ulong* values_ptr = &values)
                {
                    ProgramUniformHandleui64v(program, location, count, values_ptr);
                }
            }
            /// <inheritdoc cref="DrawBuffers(int, All*)"/>
            public static unsafe void DrawBuffers(ReadOnlySpan<All> bufs)
            {
                int n = (int)(bufs.Length);
                fixed (All* bufs_ptr = bufs)
                {
                    DrawBuffers(n, bufs_ptr);
                }
            }
            /// <inheritdoc cref="DrawBuffers(int, All*)"/>
            public static unsafe void DrawBuffers(All[] bufs)
            {
                int n = (int)(bufs.Length);
                fixed (All* bufs_ptr = bufs)
                {
                    DrawBuffers(n, bufs_ptr);
                }
            }
            /// <inheritdoc cref="DrawBuffers(int, All*)"/>
            public static unsafe void DrawBuffers(int n, in All bufs)
            {
                fixed (All* bufs_ptr = &bufs)
                {
                    DrawBuffers(n, bufs_ptr);
                }
            }
            /// <inheritdoc cref="DrawElementsInstanced(PrimitiveType, int, DrawElementsType, void*, int)"/>
            public static unsafe void DrawElementsInstanced(PrimitiveType mode, int count, DrawElementsType type, nint offset, int primcount)
            {
                void* indices = (void*)offset;
                DrawElementsInstanced(mode, count, type, indices, primcount);
            }
            /// <inheritdoc cref="GetVkProcAddr(byte*)"/>
            public static unsafe IntPtr GetVkProcAddr(string name)
            {
                IntPtr returnValue;
                byte* name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(name);
                returnValue = GetVkProcAddr(name_ptr);
                Marshal.FreeCoTaskMem((IntPtr)name_ptr);
                return returnValue;
            }
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
            /// <inheritdoc cref="CoverageModulationTable(int, float*)"/>
            public static unsafe void CoverageModulationTable(ReadOnlySpan<float> v)
            {
                int n = (int)(v.Length);
                fixed (float* v_ptr = v)
                {
                    CoverageModulationTable(n, v_ptr);
                }
            }
            /// <inheritdoc cref="CoverageModulationTable(int, float*)"/>
            public static unsafe void CoverageModulationTable(float[] v)
            {
                int n = (int)(v.Length);
                fixed (float* v_ptr = v)
                {
                    CoverageModulationTable(n, v_ptr);
                }
            }
            /// <inheritdoc cref="CoverageModulationTable(int, float*)"/>
            public static unsafe void CoverageModulationTable(int n, in float v)
            {
                fixed (float* v_ptr = &v)
                {
                    CoverageModulationTable(n, v_ptr);
                }
            }
            /// <inheritdoc cref="GetCoverageModulationTable(int, float*)"/>
            public static unsafe void GetCoverageModulationTable(int bufSize, ref float v)
            {
                fixed (float* v_ptr = &v)
                {
                    GetCoverageModulationTable(bufSize, v_ptr);
                }
            }
            /// <inheritdoc cref="Uniform1i64v(int, int, long*)"/>
            public static unsafe void Uniform1i64v(int location, int count, in long value)
            {
                fixed (long* tmp_value = &value)
                {
                    long* value_ptr = (long*)tmp_value;
                    Uniform1i64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform1i64v(int, int, long*)"/>
            public static unsafe void Uniform1i64v(int location, int count, ReadOnlySpan<long> value)
            {
                fixed (long* tmp_value = value)
                {
                    long* value_ptr = (long*)tmp_value;
                    Uniform1i64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform1i64v(int, int, long*)"/>
            public static unsafe void Uniform1i64v(int location, int count, long[] value)
            {
                fixed (long* tmp_value = value)
                {
                    long* value_ptr = (long*)tmp_value;
                    Uniform1i64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform2i64v(int, int, long*)"/>
            public static unsafe void Uniform2i64v(int location, int count, in Vector2 value)
            {
                fixed (Vector2* tmp_value = &value)
                {
                    long* value_ptr = (long*)tmp_value;
                    Uniform2i64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform2i64v(int, int, long*)"/>
            public static unsafe void Uniform2i64v(int location, int count, ReadOnlySpan<Vector2> value)
            {
                fixed (Vector2* tmp_value = value)
                {
                    long* value_ptr = (long*)tmp_value;
                    Uniform2i64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform2i64v(int, int, long*)"/>
            public static unsafe void Uniform2i64v(int location, int count, Vector2[] value)
            {
                fixed (Vector2* tmp_value = value)
                {
                    long* value_ptr = (long*)tmp_value;
                    Uniform2i64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform2i64v(int, int, long*)"/>
            public static unsafe void Uniform2i64v(int location, int count, in System.Numerics.Vector2 value)
            {
                fixed (System.Numerics.Vector2* tmp_value = &value)
                {
                    long* value_ptr = (long*)tmp_value;
                    Uniform2i64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform2i64v(int, int, long*)"/>
            public static unsafe void Uniform2i64v(int location, int count, ReadOnlySpan<System.Numerics.Vector2> value)
            {
                fixed (System.Numerics.Vector2* tmp_value = value)
                {
                    long* value_ptr = (long*)tmp_value;
                    Uniform2i64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform2i64v(int, int, long*)"/>
            public static unsafe void Uniform2i64v(int location, int count, System.Numerics.Vector2[] value)
            {
                fixed (System.Numerics.Vector2* tmp_value = value)
                {
                    long* value_ptr = (long*)tmp_value;
                    Uniform2i64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform3i64v(int, int, long*)"/>
            public static unsafe void Uniform3i64v(int location, int count, in Vector3 value)
            {
                fixed (Vector3* tmp_value = &value)
                {
                    long* value_ptr = (long*)tmp_value;
                    Uniform3i64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform3i64v(int, int, long*)"/>
            public static unsafe void Uniform3i64v(int location, int count, ReadOnlySpan<Vector3> value)
            {
                fixed (Vector3* tmp_value = value)
                {
                    long* value_ptr = (long*)tmp_value;
                    Uniform3i64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform3i64v(int, int, long*)"/>
            public static unsafe void Uniform3i64v(int location, int count, Vector3[] value)
            {
                fixed (Vector3* tmp_value = value)
                {
                    long* value_ptr = (long*)tmp_value;
                    Uniform3i64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform3i64v(int, int, long*)"/>
            public static unsafe void Uniform3i64v(int location, int count, in System.Numerics.Vector3 value)
            {
                fixed (System.Numerics.Vector3* tmp_value = &value)
                {
                    long* value_ptr = (long*)tmp_value;
                    Uniform3i64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform3i64v(int, int, long*)"/>
            public static unsafe void Uniform3i64v(int location, int count, ReadOnlySpan<System.Numerics.Vector3> value)
            {
                fixed (System.Numerics.Vector3* tmp_value = value)
                {
                    long* value_ptr = (long*)tmp_value;
                    Uniform3i64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform3i64v(int, int, long*)"/>
            public static unsafe void Uniform3i64v(int location, int count, System.Numerics.Vector3[] value)
            {
                fixed (System.Numerics.Vector3* tmp_value = value)
                {
                    long* value_ptr = (long*)tmp_value;
                    Uniform3i64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform4i64v(int, int, long*)"/>
            public static unsafe void Uniform4i64v(int location, int count, in Vector4 value)
            {
                fixed (Vector4* tmp_value = &value)
                {
                    long* value_ptr = (long*)tmp_value;
                    Uniform4i64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform4i64v(int, int, long*)"/>
            public static unsafe void Uniform4i64v(int location, int count, ReadOnlySpan<Vector4> value)
            {
                fixed (Vector4* tmp_value = value)
                {
                    long* value_ptr = (long*)tmp_value;
                    Uniform4i64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform4i64v(int, int, long*)"/>
            public static unsafe void Uniform4i64v(int location, int count, Vector4[] value)
            {
                fixed (Vector4* tmp_value = value)
                {
                    long* value_ptr = (long*)tmp_value;
                    Uniform4i64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform4i64v(int, int, long*)"/>
            public static unsafe void Uniform4i64v(int location, int count, in System.Numerics.Vector4 value)
            {
                fixed (System.Numerics.Vector4* tmp_value = &value)
                {
                    long* value_ptr = (long*)tmp_value;
                    Uniform4i64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform4i64v(int, int, long*)"/>
            public static unsafe void Uniform4i64v(int location, int count, ReadOnlySpan<System.Numerics.Vector4> value)
            {
                fixed (System.Numerics.Vector4* tmp_value = value)
                {
                    long* value_ptr = (long*)tmp_value;
                    Uniform4i64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform4i64v(int, int, long*)"/>
            public static unsafe void Uniform4i64v(int location, int count, System.Numerics.Vector4[] value)
            {
                fixed (System.Numerics.Vector4* tmp_value = value)
                {
                    long* value_ptr = (long*)tmp_value;
                    Uniform4i64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform1ui64v(int, int, ulong*)"/>
            public static unsafe void Uniform1ui64v(int location, int count, in ulong value)
            {
                fixed (ulong* tmp_value = &value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    Uniform1ui64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform1ui64v(int, int, ulong*)"/>
            public static unsafe void Uniform1ui64v(int location, int count, ReadOnlySpan<ulong> value)
            {
                fixed (ulong* tmp_value = value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    Uniform1ui64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform1ui64v(int, int, ulong*)"/>
            public static unsafe void Uniform1ui64v(int location, int count, ulong[] value)
            {
                fixed (ulong* tmp_value = value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    Uniform1ui64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform2ui64v(int, int, ulong*)"/>
            public static unsafe void Uniform2ui64v(int location, int count, in Vector2 value)
            {
                fixed (Vector2* tmp_value = &value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    Uniform2ui64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform2ui64v(int, int, ulong*)"/>
            public static unsafe void Uniform2ui64v(int location, int count, ReadOnlySpan<Vector2> value)
            {
                fixed (Vector2* tmp_value = value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    Uniform2ui64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform2ui64v(int, int, ulong*)"/>
            public static unsafe void Uniform2ui64v(int location, int count, Vector2[] value)
            {
                fixed (Vector2* tmp_value = value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    Uniform2ui64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform2ui64v(int, int, ulong*)"/>
            public static unsafe void Uniform2ui64v(int location, int count, in System.Numerics.Vector2 value)
            {
                fixed (System.Numerics.Vector2* tmp_value = &value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    Uniform2ui64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform2ui64v(int, int, ulong*)"/>
            public static unsafe void Uniform2ui64v(int location, int count, ReadOnlySpan<System.Numerics.Vector2> value)
            {
                fixed (System.Numerics.Vector2* tmp_value = value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    Uniform2ui64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform2ui64v(int, int, ulong*)"/>
            public static unsafe void Uniform2ui64v(int location, int count, System.Numerics.Vector2[] value)
            {
                fixed (System.Numerics.Vector2* tmp_value = value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    Uniform2ui64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform3ui64v(int, int, ulong*)"/>
            public static unsafe void Uniform3ui64v(int location, int count, in Vector3 value)
            {
                fixed (Vector3* tmp_value = &value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    Uniform3ui64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform3ui64v(int, int, ulong*)"/>
            public static unsafe void Uniform3ui64v(int location, int count, ReadOnlySpan<Vector3> value)
            {
                fixed (Vector3* tmp_value = value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    Uniform3ui64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform3ui64v(int, int, ulong*)"/>
            public static unsafe void Uniform3ui64v(int location, int count, Vector3[] value)
            {
                fixed (Vector3* tmp_value = value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    Uniform3ui64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform3ui64v(int, int, ulong*)"/>
            public static unsafe void Uniform3ui64v(int location, int count, in System.Numerics.Vector3 value)
            {
                fixed (System.Numerics.Vector3* tmp_value = &value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    Uniform3ui64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform3ui64v(int, int, ulong*)"/>
            public static unsafe void Uniform3ui64v(int location, int count, ReadOnlySpan<System.Numerics.Vector3> value)
            {
                fixed (System.Numerics.Vector3* tmp_value = value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    Uniform3ui64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform3ui64v(int, int, ulong*)"/>
            public static unsafe void Uniform3ui64v(int location, int count, System.Numerics.Vector3[] value)
            {
                fixed (System.Numerics.Vector3* tmp_value = value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    Uniform3ui64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform4ui64v(int, int, ulong*)"/>
            public static unsafe void Uniform4ui64v(int location, int count, in Vector4 value)
            {
                fixed (Vector4* tmp_value = &value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    Uniform4ui64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform4ui64v(int, int, ulong*)"/>
            public static unsafe void Uniform4ui64v(int location, int count, ReadOnlySpan<Vector4> value)
            {
                fixed (Vector4* tmp_value = value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    Uniform4ui64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform4ui64v(int, int, ulong*)"/>
            public static unsafe void Uniform4ui64v(int location, int count, Vector4[] value)
            {
                fixed (Vector4* tmp_value = value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    Uniform4ui64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform4ui64v(int, int, ulong*)"/>
            public static unsafe void Uniform4ui64v(int location, int count, in System.Numerics.Vector4 value)
            {
                fixed (System.Numerics.Vector4* tmp_value = &value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    Uniform4ui64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform4ui64v(int, int, ulong*)"/>
            public static unsafe void Uniform4ui64v(int location, int count, ReadOnlySpan<System.Numerics.Vector4> value)
            {
                fixed (System.Numerics.Vector4* tmp_value = value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    Uniform4ui64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform4ui64v(int, int, ulong*)"/>
            public static unsafe void Uniform4ui64v(int location, int count, System.Numerics.Vector4[] value)
            {
                fixed (System.Numerics.Vector4* tmp_value = value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    Uniform4ui64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="GetUniformi64v(int, int, long*)"/>
            public static unsafe void GetUniformi64v(int program, int location, Span<long> parameters)
            {
                fixed (long* parameters_ptr = parameters)
                {
                    GetUniformi64v(program, location, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetUniformi64v(int, int, long*)"/>
            public static unsafe void GetUniformi64v(int program, int location, long[] parameters)
            {
                fixed (long* parameters_ptr = parameters)
                {
                    GetUniformi64v(program, location, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetUniformi64v(int, int, long*)"/>
            public static unsafe void GetUniformi64v(int program, int location, ref long parameters)
            {
                fixed (long* parameters_ptr = &parameters)
                {
                    GetUniformi64v(program, location, parameters_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform1i64v(int, int, int, long*)"/>
            public static unsafe void ProgramUniform1i64v(int program, int location, int count, in long value)
            {
                fixed (long* tmp_value = &value)
                {
                    long* value_ptr = (long*)tmp_value;
                    ProgramUniform1i64v(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2i64v(int, int, int, long*)"/>
            public static unsafe void ProgramUniform2i64v(int program, int location, int count, in Vector2 value)
            {
                fixed (Vector2* tmp_value = &value)
                {
                    long* value_ptr = (long*)tmp_value;
                    ProgramUniform2i64v(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2i64v(int, int, int, long*)"/>
            public static unsafe void ProgramUniform2i64v(int program, int location, int count, ReadOnlySpan<Vector2> value)
            {
                fixed (Vector2* tmp_value = value)
                {
                    long* value_ptr = (long*)tmp_value;
                    ProgramUniform2i64v(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2i64v(int, int, int, long*)"/>
            public static unsafe void ProgramUniform2i64v(int program, int location, int count, Vector2[] value)
            {
                fixed (Vector2* tmp_value = value)
                {
                    long* value_ptr = (long*)tmp_value;
                    ProgramUniform2i64v(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2i64v(int, int, int, long*)"/>
            public static unsafe void ProgramUniform2i64v(int program, int location, int count, in System.Numerics.Vector2 value)
            {
                fixed (System.Numerics.Vector2* tmp_value = &value)
                {
                    long* value_ptr = (long*)tmp_value;
                    ProgramUniform2i64v(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2i64v(int, int, int, long*)"/>
            public static unsafe void ProgramUniform2i64v(int program, int location, int count, ReadOnlySpan<System.Numerics.Vector2> value)
            {
                fixed (System.Numerics.Vector2* tmp_value = value)
                {
                    long* value_ptr = (long*)tmp_value;
                    ProgramUniform2i64v(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2i64v(int, int, int, long*)"/>
            public static unsafe void ProgramUniform2i64v(int program, int location, int count, System.Numerics.Vector2[] value)
            {
                fixed (System.Numerics.Vector2* tmp_value = value)
                {
                    long* value_ptr = (long*)tmp_value;
                    ProgramUniform2i64v(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3i64v(int, int, int, long*)"/>
            public static unsafe void ProgramUniform3i64v(int program, int location, int count, in Vector3 value)
            {
                fixed (Vector3* tmp_value = &value)
                {
                    long* value_ptr = (long*)tmp_value;
                    ProgramUniform3i64v(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3i64v(int, int, int, long*)"/>
            public static unsafe void ProgramUniform3i64v(int program, int location, int count, ReadOnlySpan<Vector3> value)
            {
                fixed (Vector3* tmp_value = value)
                {
                    long* value_ptr = (long*)tmp_value;
                    ProgramUniform3i64v(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3i64v(int, int, int, long*)"/>
            public static unsafe void ProgramUniform3i64v(int program, int location, int count, Vector3[] value)
            {
                fixed (Vector3* tmp_value = value)
                {
                    long* value_ptr = (long*)tmp_value;
                    ProgramUniform3i64v(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3i64v(int, int, int, long*)"/>
            public static unsafe void ProgramUniform3i64v(int program, int location, int count, in System.Numerics.Vector3 value)
            {
                fixed (System.Numerics.Vector3* tmp_value = &value)
                {
                    long* value_ptr = (long*)tmp_value;
                    ProgramUniform3i64v(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3i64v(int, int, int, long*)"/>
            public static unsafe void ProgramUniform3i64v(int program, int location, int count, ReadOnlySpan<System.Numerics.Vector3> value)
            {
                fixed (System.Numerics.Vector3* tmp_value = value)
                {
                    long* value_ptr = (long*)tmp_value;
                    ProgramUniform3i64v(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3i64v(int, int, int, long*)"/>
            public static unsafe void ProgramUniform3i64v(int program, int location, int count, System.Numerics.Vector3[] value)
            {
                fixed (System.Numerics.Vector3* tmp_value = value)
                {
                    long* value_ptr = (long*)tmp_value;
                    ProgramUniform3i64v(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4i64v(int, int, int, long*)"/>
            public static unsafe void ProgramUniform4i64v(int program, int location, int count, in Vector4 value)
            {
                fixed (Vector4* tmp_value = &value)
                {
                    long* value_ptr = (long*)tmp_value;
                    ProgramUniform4i64v(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4i64v(int, int, int, long*)"/>
            public static unsafe void ProgramUniform4i64v(int program, int location, int count, ReadOnlySpan<Vector4> value)
            {
                fixed (Vector4* tmp_value = value)
                {
                    long* value_ptr = (long*)tmp_value;
                    ProgramUniform4i64v(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4i64v(int, int, int, long*)"/>
            public static unsafe void ProgramUniform4i64v(int program, int location, int count, Vector4[] value)
            {
                fixed (Vector4* tmp_value = value)
                {
                    long* value_ptr = (long*)tmp_value;
                    ProgramUniform4i64v(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4i64v(int, int, int, long*)"/>
            public static unsafe void ProgramUniform4i64v(int program, int location, int count, in System.Numerics.Vector4 value)
            {
                fixed (System.Numerics.Vector4* tmp_value = &value)
                {
                    long* value_ptr = (long*)tmp_value;
                    ProgramUniform4i64v(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4i64v(int, int, int, long*)"/>
            public static unsafe void ProgramUniform4i64v(int program, int location, int count, ReadOnlySpan<System.Numerics.Vector4> value)
            {
                fixed (System.Numerics.Vector4* tmp_value = value)
                {
                    long* value_ptr = (long*)tmp_value;
                    ProgramUniform4i64v(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4i64v(int, int, int, long*)"/>
            public static unsafe void ProgramUniform4i64v(int program, int location, int count, System.Numerics.Vector4[] value)
            {
                fixed (System.Numerics.Vector4* tmp_value = value)
                {
                    long* value_ptr = (long*)tmp_value;
                    ProgramUniform4i64v(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform1ui64v(int, int, int, ulong*)"/>
            public static unsafe void ProgramUniform1ui64v(int program, int location, int count, in ulong value)
            {
                fixed (ulong* tmp_value = &value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    ProgramUniform1ui64v(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2ui64v(int, int, int, ulong*)"/>
            public static unsafe void ProgramUniform2ui64v(int program, int location, int count, in Vector2 value)
            {
                fixed (Vector2* tmp_value = &value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    ProgramUniform2ui64v(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2ui64v(int, int, int, ulong*)"/>
            public static unsafe void ProgramUniform2ui64v(int program, int location, int count, ReadOnlySpan<Vector2> value)
            {
                fixed (Vector2* tmp_value = value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    ProgramUniform2ui64v(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2ui64v(int, int, int, ulong*)"/>
            public static unsafe void ProgramUniform2ui64v(int program, int location, int count, Vector2[] value)
            {
                fixed (Vector2* tmp_value = value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    ProgramUniform2ui64v(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2ui64v(int, int, int, ulong*)"/>
            public static unsafe void ProgramUniform2ui64v(int program, int location, int count, in System.Numerics.Vector2 value)
            {
                fixed (System.Numerics.Vector2* tmp_value = &value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    ProgramUniform2ui64v(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2ui64v(int, int, int, ulong*)"/>
            public static unsafe void ProgramUniform2ui64v(int program, int location, int count, ReadOnlySpan<System.Numerics.Vector2> value)
            {
                fixed (System.Numerics.Vector2* tmp_value = value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    ProgramUniform2ui64v(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2ui64v(int, int, int, ulong*)"/>
            public static unsafe void ProgramUniform2ui64v(int program, int location, int count, System.Numerics.Vector2[] value)
            {
                fixed (System.Numerics.Vector2* tmp_value = value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    ProgramUniform2ui64v(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3ui64v(int, int, int, ulong*)"/>
            public static unsafe void ProgramUniform3ui64v(int program, int location, int count, in Vector3 value)
            {
                fixed (Vector3* tmp_value = &value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    ProgramUniform3ui64v(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3ui64v(int, int, int, ulong*)"/>
            public static unsafe void ProgramUniform3ui64v(int program, int location, int count, ReadOnlySpan<Vector3> value)
            {
                fixed (Vector3* tmp_value = value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    ProgramUniform3ui64v(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3ui64v(int, int, int, ulong*)"/>
            public static unsafe void ProgramUniform3ui64v(int program, int location, int count, Vector3[] value)
            {
                fixed (Vector3* tmp_value = value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    ProgramUniform3ui64v(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3ui64v(int, int, int, ulong*)"/>
            public static unsafe void ProgramUniform3ui64v(int program, int location, int count, in System.Numerics.Vector3 value)
            {
                fixed (System.Numerics.Vector3* tmp_value = &value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    ProgramUniform3ui64v(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3ui64v(int, int, int, ulong*)"/>
            public static unsafe void ProgramUniform3ui64v(int program, int location, int count, ReadOnlySpan<System.Numerics.Vector3> value)
            {
                fixed (System.Numerics.Vector3* tmp_value = value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    ProgramUniform3ui64v(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3ui64v(int, int, int, ulong*)"/>
            public static unsafe void ProgramUniform3ui64v(int program, int location, int count, System.Numerics.Vector3[] value)
            {
                fixed (System.Numerics.Vector3* tmp_value = value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    ProgramUniform3ui64v(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4ui64v(int, int, int, ulong*)"/>
            public static unsafe void ProgramUniform4ui64v(int program, int location, int count, in Vector4 value)
            {
                fixed (Vector4* tmp_value = &value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    ProgramUniform4ui64v(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4ui64v(int, int, int, ulong*)"/>
            public static unsafe void ProgramUniform4ui64v(int program, int location, int count, ReadOnlySpan<Vector4> value)
            {
                fixed (Vector4* tmp_value = value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    ProgramUniform4ui64v(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4ui64v(int, int, int, ulong*)"/>
            public static unsafe void ProgramUniform4ui64v(int program, int location, int count, Vector4[] value)
            {
                fixed (Vector4* tmp_value = value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    ProgramUniform4ui64v(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4ui64v(int, int, int, ulong*)"/>
            public static unsafe void ProgramUniform4ui64v(int program, int location, int count, in System.Numerics.Vector4 value)
            {
                fixed (System.Numerics.Vector4* tmp_value = &value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    ProgramUniform4ui64v(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4ui64v(int, int, int, ulong*)"/>
            public static unsafe void ProgramUniform4ui64v(int program, int location, int count, ReadOnlySpan<System.Numerics.Vector4> value)
            {
                fixed (System.Numerics.Vector4* tmp_value = value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    ProgramUniform4ui64v(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4ui64v(int, int, int, ulong*)"/>
            public static unsafe void ProgramUniform4ui64v(int program, int location, int count, System.Numerics.Vector4[] value)
            {
                fixed (System.Numerics.Vector4* tmp_value = value)
                {
                    ulong* value_ptr = (ulong*)tmp_value;
                    ProgramUniform4ui64v(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="GetInternalformatSampleiv(TextureTarget, InternalFormat, int, InternalFormatPName, int, int*)"/>
            public static unsafe void GetInternalformatSampleiv(TextureTarget target, InternalFormat internalformat, int samples, InternalFormatPName pname, Span<int> parameters)
            {
                int count = (int)(parameters.Length);
                fixed (int* parameters_ptr = parameters)
                {
                    GetInternalformatSampleiv(target, internalformat, samples, pname, count, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetInternalformatSampleiv(TextureTarget, InternalFormat, int, InternalFormatPName, int, int*)"/>
            public static unsafe void GetInternalformatSampleiv(TextureTarget target, InternalFormat internalformat, int samples, InternalFormatPName pname, int[] parameters)
            {
                int count = (int)(parameters.Length);
                fixed (int* parameters_ptr = parameters)
                {
                    GetInternalformatSampleiv(target, internalformat, samples, pname, count, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetInternalformatSampleiv(TextureTarget, InternalFormat, int, InternalFormatPName, int, int*)"/>
            public static unsafe void GetInternalformatSampleiv(TextureTarget target, InternalFormat internalformat, int samples, InternalFormatPName pname, int count, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetInternalformatSampleiv(target, internalformat, samples, pname, count, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetMemoryObjectDetachedResourcesuiv(uint, All, int, int, uint*)"/>
            public static unsafe void GetMemoryObjectDetachedResourcesuiv(uint memory, All pname, int first, int count, ref uint parameters)
            {
                fixed (uint* parameters_ptr = &parameters)
                {
                    GetMemoryObjectDetachedResourcesuiv(memory, pname, first, count, parameters_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix2x3fv(int, int, bool, float*)"/>
            public static unsafe void UniformMatrix2x3fv(int location, int count, bool transpose, in Matrix2x3 value)
            {
                fixed (Matrix2x3* tmp_value = &value)
                {
                    float* value_ptr = (float*)tmp_value;
                    UniformMatrix2x3fv(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix2x3fv(int, int, bool, float*)"/>
            public static unsafe void UniformMatrix2x3fv(int location, int count, bool transpose, ReadOnlySpan<Matrix2x3> value)
            {
                fixed (Matrix2x3* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    UniformMatrix2x3fv(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix2x3fv(int, int, bool, float*)"/>
            public static unsafe void UniformMatrix2x3fv(int location, int count, bool transpose, Matrix2x3[] value)
            {
                fixed (Matrix2x3* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    UniformMatrix2x3fv(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix3x2fv(int, int, bool, float*)"/>
            public static unsafe void UniformMatrix3x2fv(int location, int count, bool transpose, in Matrix3x2 value)
            {
                fixed (Matrix3x2* tmp_value = &value)
                {
                    float* value_ptr = (float*)tmp_value;
                    UniformMatrix3x2fv(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix3x2fv(int, int, bool, float*)"/>
            public static unsafe void UniformMatrix3x2fv(int location, int count, bool transpose, ReadOnlySpan<Matrix3x2> value)
            {
                fixed (Matrix3x2* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    UniformMatrix3x2fv(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix3x2fv(int, int, bool, float*)"/>
            public static unsafe void UniformMatrix3x2fv(int location, int count, bool transpose, Matrix3x2[] value)
            {
                fixed (Matrix3x2* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    UniformMatrix3x2fv(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix3x2fv(int, int, bool, float*)"/>
            public static unsafe void UniformMatrix3x2fv(int location, int count, bool transpose, in System.Numerics.Matrix3x2 value)
            {
                fixed (System.Numerics.Matrix3x2* tmp_value = &value)
                {
                    float* value_ptr = (float*)tmp_value;
                    UniformMatrix3x2fv(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix3x2fv(int, int, bool, float*)"/>
            public static unsafe void UniformMatrix3x2fv(int location, int count, bool transpose, ReadOnlySpan<System.Numerics.Matrix3x2> value)
            {
                fixed (System.Numerics.Matrix3x2* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    UniformMatrix3x2fv(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix3x2fv(int, int, bool, float*)"/>
            public static unsafe void UniformMatrix3x2fv(int location, int count, bool transpose, System.Numerics.Matrix3x2[] value)
            {
                fixed (System.Numerics.Matrix3x2* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    UniformMatrix3x2fv(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix2x4fv(int, int, bool, float*)"/>
            public static unsafe void UniformMatrix2x4fv(int location, int count, bool transpose, in Matrix2x4 value)
            {
                fixed (Matrix2x4* tmp_value = &value)
                {
                    float* value_ptr = (float*)tmp_value;
                    UniformMatrix2x4fv(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix2x4fv(int, int, bool, float*)"/>
            public static unsafe void UniformMatrix2x4fv(int location, int count, bool transpose, ReadOnlySpan<Matrix2x4> value)
            {
                fixed (Matrix2x4* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    UniformMatrix2x4fv(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix2x4fv(int, int, bool, float*)"/>
            public static unsafe void UniformMatrix2x4fv(int location, int count, bool transpose, Matrix2x4[] value)
            {
                fixed (Matrix2x4* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    UniformMatrix2x4fv(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix4x2fv(int, int, bool, float*)"/>
            public static unsafe void UniformMatrix4x2fv(int location, int count, bool transpose, in Matrix4x2 value)
            {
                fixed (Matrix4x2* tmp_value = &value)
                {
                    float* value_ptr = (float*)tmp_value;
                    UniformMatrix4x2fv(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix4x2fv(int, int, bool, float*)"/>
            public static unsafe void UniformMatrix4x2fv(int location, int count, bool transpose, ReadOnlySpan<Matrix4x2> value)
            {
                fixed (Matrix4x2* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    UniformMatrix4x2fv(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix4x2fv(int, int, bool, float*)"/>
            public static unsafe void UniformMatrix4x2fv(int location, int count, bool transpose, Matrix4x2[] value)
            {
                fixed (Matrix4x2* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    UniformMatrix4x2fv(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix3x4fv(int, int, bool, float*)"/>
            public static unsafe void UniformMatrix3x4fv(int location, int count, bool transpose, in Matrix3x4 value)
            {
                fixed (Matrix3x4* tmp_value = &value)
                {
                    float* value_ptr = (float*)tmp_value;
                    UniformMatrix3x4fv(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix3x4fv(int, int, bool, float*)"/>
            public static unsafe void UniformMatrix3x4fv(int location, int count, bool transpose, ReadOnlySpan<Matrix3x4> value)
            {
                fixed (Matrix3x4* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    UniformMatrix3x4fv(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix3x4fv(int, int, bool, float*)"/>
            public static unsafe void UniformMatrix3x4fv(int location, int count, bool transpose, Matrix3x4[] value)
            {
                fixed (Matrix3x4* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    UniformMatrix3x4fv(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix4x3fv(int, int, bool, float*)"/>
            public static unsafe void UniformMatrix4x3fv(int location, int count, bool transpose, in Matrix4x3 value)
            {
                fixed (Matrix4x3* tmp_value = &value)
                {
                    float* value_ptr = (float*)tmp_value;
                    UniformMatrix4x3fv(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix4x3fv(int, int, bool, float*)"/>
            public static unsafe void UniformMatrix4x3fv(int location, int count, bool transpose, ReadOnlySpan<Matrix4x3> value)
            {
                fixed (Matrix4x3* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    UniformMatrix4x3fv(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix4x3fv(int, int, bool, float*)"/>
            public static unsafe void UniformMatrix4x3fv(int location, int count, bool transpose, Matrix4x3[] value)
            {
                fixed (Matrix4x3* tmp_value = value)
                {
                    float* value_ptr = (float*)tmp_value;
                    UniformMatrix4x3fv(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="PathCommands(uint, int, byte*, int, PathCoordType, void*)"/>
            public static unsafe void PathCommands(uint path, ReadOnlySpan<byte> commands, int numCoords, PathCoordType coordType, IntPtr coords)
            {
                int numCommands = (int)(commands.Length);
                fixed (byte* commands_ptr = commands)
                {
                    void* coords_vptr = (void*)coords;
                    PathCommands(path, numCommands, commands_ptr, numCoords, coordType, coords_vptr);
                }
            }
            /// <inheritdoc cref="PathCommands(uint, int, byte*, int, PathCoordType, void*)"/>
            public static unsafe void PathCommands(uint path, byte[] commands, int numCoords, PathCoordType coordType, IntPtr coords)
            {
                int numCommands = (int)(commands.Length);
                fixed (byte* commands_ptr = commands)
                {
                    void* coords_vptr = (void*)coords;
                    PathCommands(path, numCommands, commands_ptr, numCoords, coordType, coords_vptr);
                }
            }
            /// <inheritdoc cref="PathCommands(uint, int, byte*, int, PathCoordType, void*)"/>
            public static unsafe void PathCommands(uint path, int numCommands, in byte commands, int numCoords, PathCoordType coordType, IntPtr coords)
            {
                fixed (byte* commands_ptr = &commands)
                {
                    void* coords_vptr = (void*)coords;
                    PathCommands(path, numCommands, commands_ptr, numCoords, coordType, coords_vptr);
                }
            }
            /// <inheritdoc cref="PathCommands(uint, int, byte*, int, PathCoordType, void*)"/>
            public static unsafe void PathCommands<T1>(uint path, ReadOnlySpan<byte> commands, int numCoords, PathCoordType coordType, ReadOnlySpan<T1> coords)
                where T1 : unmanaged
            {
                int numCommands = (int)(commands.Length);
                fixed (byte* commands_ptr = commands)
                {
                    fixed (void* coords_ptr = coords)
                    {
                        PathCommands(path, numCommands, commands_ptr, numCoords, coordType, coords_ptr);
                    }
                }
            }
            /// <inheritdoc cref="PathCommands(uint, int, byte*, int, PathCoordType, void*)"/>
            public static unsafe void PathCommands<T1>(uint path, byte[] commands, int numCoords, PathCoordType coordType, T1[] coords)
                where T1 : unmanaged
            {
                int numCommands = (int)(commands.Length);
                fixed (byte* commands_ptr = commands)
                {
                    fixed (void* coords_ptr = coords)
                    {
                        PathCommands(path, numCommands, commands_ptr, numCoords, coordType, coords_ptr);
                    }
                }
            }
            /// <inheritdoc cref="PathCommands(uint, int, byte*, int, PathCoordType, void*)"/>
            public static unsafe void PathCommands<T1>(uint path, int numCommands, in byte commands, int numCoords, PathCoordType coordType, in T1 coords)
                where T1 : unmanaged
            {
                fixed (byte* commands_ptr = &commands)
                fixed (void* coords_ptr = &coords)
                {
                    PathCommands(path, numCommands, commands_ptr, numCoords, coordType, coords_ptr);
                }
            }
            /// <inheritdoc cref="PathCoords(uint, int, PathCoordType, void*)"/>
            public static unsafe void PathCoords(uint path, int numCoords, PathCoordType coordType, IntPtr coords)
            {
                void* coords_vptr = (void*)coords;
                PathCoords(path, numCoords, coordType, coords_vptr);
            }
            /// <inheritdoc cref="PathCoords(uint, int, PathCoordType, void*)"/>
            public static unsafe void PathCoords<T1>(uint path, int numCoords, PathCoordType coordType, ReadOnlySpan<T1> coords)
                where T1 : unmanaged
            {
                fixed (void* coords_ptr = coords)
                {
                    PathCoords(path, numCoords, coordType, coords_ptr);
                }
            }
            /// <inheritdoc cref="PathCoords(uint, int, PathCoordType, void*)"/>
            public static unsafe void PathCoords<T1>(uint path, int numCoords, PathCoordType coordType, T1[] coords)
                where T1 : unmanaged
            {
                fixed (void* coords_ptr = coords)
                {
                    PathCoords(path, numCoords, coordType, coords_ptr);
                }
            }
            /// <inheritdoc cref="PathCoords(uint, int, PathCoordType, void*)"/>
            public static unsafe void PathCoords<T1>(uint path, int numCoords, PathCoordType coordType, in T1 coords)
                where T1 : unmanaged
            {
                fixed (void* coords_ptr = &coords)
                {
                    PathCoords(path, numCoords, coordType, coords_ptr);
                }
            }
            /// <inheritdoc cref="PathSubCommands(uint, int, int, int, byte*, int, PathCoordType, void*)"/>
            public static unsafe void PathSubCommands(uint path, int commandStart, int commandsToDelete, ReadOnlySpan<byte> commands, int numCoords, PathCoordType coordType, IntPtr coords)
            {
                int numCommands = (int)(commands.Length);
                fixed (byte* commands_ptr = commands)
                {
                    void* coords_vptr = (void*)coords;
                    PathSubCommands(path, commandStart, commandsToDelete, numCommands, commands_ptr, numCoords, coordType, coords_vptr);
                }
            }
            /// <inheritdoc cref="PathSubCommands(uint, int, int, int, byte*, int, PathCoordType, void*)"/>
            public static unsafe void PathSubCommands(uint path, int commandStart, int commandsToDelete, byte[] commands, int numCoords, PathCoordType coordType, IntPtr coords)
            {
                int numCommands = (int)(commands.Length);
                fixed (byte* commands_ptr = commands)
                {
                    void* coords_vptr = (void*)coords;
                    PathSubCommands(path, commandStart, commandsToDelete, numCommands, commands_ptr, numCoords, coordType, coords_vptr);
                }
            }
            /// <inheritdoc cref="PathSubCommands(uint, int, int, int, byte*, int, PathCoordType, void*)"/>
            public static unsafe void PathSubCommands(uint path, int commandStart, int commandsToDelete, int numCommands, in byte commands, int numCoords, PathCoordType coordType, IntPtr coords)
            {
                fixed (byte* commands_ptr = &commands)
                {
                    void* coords_vptr = (void*)coords;
                    PathSubCommands(path, commandStart, commandsToDelete, numCommands, commands_ptr, numCoords, coordType, coords_vptr);
                }
            }
            /// <inheritdoc cref="PathSubCommands(uint, int, int, int, byte*, int, PathCoordType, void*)"/>
            public static unsafe void PathSubCommands<T1>(uint path, int commandStart, int commandsToDelete, ReadOnlySpan<byte> commands, int numCoords, PathCoordType coordType, ReadOnlySpan<T1> coords)
                where T1 : unmanaged
            {
                int numCommands = (int)(commands.Length);
                fixed (byte* commands_ptr = commands)
                {
                    fixed (void* coords_ptr = coords)
                    {
                        PathSubCommands(path, commandStart, commandsToDelete, numCommands, commands_ptr, numCoords, coordType, coords_ptr);
                    }
                }
            }
            /// <inheritdoc cref="PathSubCommands(uint, int, int, int, byte*, int, PathCoordType, void*)"/>
            public static unsafe void PathSubCommands<T1>(uint path, int commandStart, int commandsToDelete, byte[] commands, int numCoords, PathCoordType coordType, T1[] coords)
                where T1 : unmanaged
            {
                int numCommands = (int)(commands.Length);
                fixed (byte* commands_ptr = commands)
                {
                    fixed (void* coords_ptr = coords)
                    {
                        PathSubCommands(path, commandStart, commandsToDelete, numCommands, commands_ptr, numCoords, coordType, coords_ptr);
                    }
                }
            }
            /// <inheritdoc cref="PathSubCommands(uint, int, int, int, byte*, int, PathCoordType, void*)"/>
            public static unsafe void PathSubCommands<T1>(uint path, int commandStart, int commandsToDelete, int numCommands, in byte commands, int numCoords, PathCoordType coordType, in T1 coords)
                where T1 : unmanaged
            {
                fixed (byte* commands_ptr = &commands)
                fixed (void* coords_ptr = &coords)
                {
                    PathSubCommands(path, commandStart, commandsToDelete, numCommands, commands_ptr, numCoords, coordType, coords_ptr);
                }
            }
            /// <inheritdoc cref="PathSubCoords(uint, int, int, PathCoordType, void*)"/>
            public static unsafe void PathSubCoords(uint path, int coordStart, int numCoords, PathCoordType coordType, IntPtr coords)
            {
                void* coords_vptr = (void*)coords;
                PathSubCoords(path, coordStart, numCoords, coordType, coords_vptr);
            }
            /// <inheritdoc cref="PathSubCoords(uint, int, int, PathCoordType, void*)"/>
            public static unsafe void PathSubCoords<T1>(uint path, int coordStart, int numCoords, PathCoordType coordType, ReadOnlySpan<T1> coords)
                where T1 : unmanaged
            {
                fixed (void* coords_ptr = coords)
                {
                    PathSubCoords(path, coordStart, numCoords, coordType, coords_ptr);
                }
            }
            /// <inheritdoc cref="PathSubCoords(uint, int, int, PathCoordType, void*)"/>
            public static unsafe void PathSubCoords<T1>(uint path, int coordStart, int numCoords, PathCoordType coordType, T1[] coords)
                where T1 : unmanaged
            {
                fixed (void* coords_ptr = coords)
                {
                    PathSubCoords(path, coordStart, numCoords, coordType, coords_ptr);
                }
            }
            /// <inheritdoc cref="PathSubCoords(uint, int, int, PathCoordType, void*)"/>
            public static unsafe void PathSubCoords<T1>(uint path, int coordStart, int numCoords, PathCoordType coordType, in T1 coords)
                where T1 : unmanaged
            {
                fixed (void* coords_ptr = &coords)
                {
                    PathSubCoords(path, coordStart, numCoords, coordType, coords_ptr);
                }
            }
            /// <inheritdoc cref="PathString(uint, PathStringFormat, int, void*)"/>
            public static unsafe void PathString(uint path, PathStringFormat format, int length, IntPtr pathString)
            {
                void* pathString_vptr = (void*)pathString;
                PathString(path, format, length, pathString_vptr);
            }
            /// <inheritdoc cref="PathString(uint, PathStringFormat, int, void*)"/>
            public static unsafe void PathString<T1>(uint path, PathStringFormat format, ReadOnlySpan<T1> pathString)
                where T1 : unmanaged
            {
                int length = (int)(pathString.Length * sizeof(T1));
                fixed (void* pathString_ptr = pathString)
                {
                    PathString(path, format, length, pathString_ptr);
                }
            }
            /// <inheritdoc cref="PathString(uint, PathStringFormat, int, void*)"/>
            public static unsafe void PathString<T1>(uint path, PathStringFormat format, T1[] pathString)
                where T1 : unmanaged
            {
                int length = (int)(pathString.Length * sizeof(T1));
                fixed (void* pathString_ptr = pathString)
                {
                    PathString(path, format, length, pathString_ptr);
                }
            }
            /// <inheritdoc cref="PathString(uint, PathStringFormat, int, void*)"/>
            public static unsafe void PathString<T1>(uint path, PathStringFormat format, int length, in T1 pathString)
                where T1 : unmanaged
            {
                fixed (void* pathString_ptr = &pathString)
                {
                    PathString(path, format, length, pathString_ptr);
                }
            }
            /// <inheritdoc cref="PathGlyphs(uint, PathFontTarget, void*, PathFontStyle, int, PathElementType, void*, PathHandleMissingGlyphs, uint, float)"/>
            public static unsafe void PathGlyphs(uint firstPathName, PathFontTarget fontTarget, IntPtr fontName, PathFontStyle fontStyle, int numGlyphs, PathElementType type, IntPtr charcodes, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale)
            {
                void* fontName_vptr = (void*)fontName;
                void* charcodes_vptr = (void*)charcodes;
                PathGlyphs(firstPathName, fontTarget, fontName_vptr, fontStyle, numGlyphs, type, charcodes_vptr, handleMissingGlyphs, pathParameterTemplate, emScale);
            }
            /// <inheritdoc cref="PathGlyphs(uint, PathFontTarget, void*, PathFontStyle, int, PathElementType, void*, PathHandleMissingGlyphs, uint, float)"/>
            public static unsafe void PathGlyphs<T1, T2>(uint firstPathName, PathFontTarget fontTarget, ReadOnlySpan<T2> fontName, PathFontStyle fontStyle, int numGlyphs, PathElementType type, ReadOnlySpan<T1> charcodes, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                fixed (void* fontName_ptr = fontName)
                {
                    fixed (void* charcodes_ptr = charcodes)
                    {
                        PathGlyphs(firstPathName, fontTarget, fontName_ptr, fontStyle, numGlyphs, type, charcodes_ptr, handleMissingGlyphs, pathParameterTemplate, emScale);
                    }
                }
            }
            /// <inheritdoc cref="PathGlyphs(uint, PathFontTarget, void*, PathFontStyle, int, PathElementType, void*, PathHandleMissingGlyphs, uint, float)"/>
            public static unsafe void PathGlyphs<T1, T2>(uint firstPathName, PathFontTarget fontTarget, T2[] fontName, PathFontStyle fontStyle, int numGlyphs, PathElementType type, T1[] charcodes, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                fixed (void* fontName_ptr = fontName)
                {
                    fixed (void* charcodes_ptr = charcodes)
                    {
                        PathGlyphs(firstPathName, fontTarget, fontName_ptr, fontStyle, numGlyphs, type, charcodes_ptr, handleMissingGlyphs, pathParameterTemplate, emScale);
                    }
                }
            }
            /// <inheritdoc cref="PathGlyphs(uint, PathFontTarget, void*, PathFontStyle, int, PathElementType, void*, PathHandleMissingGlyphs, uint, float)"/>
            public static unsafe void PathGlyphs<T1, T2>(uint firstPathName, PathFontTarget fontTarget, in T1 fontName, PathFontStyle fontStyle, int numGlyphs, PathElementType type, in T2 charcodes, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                fixed (void* fontName_ptr = &fontName)
                fixed (void* charcodes_ptr = &charcodes)
                {
                    PathGlyphs(firstPathName, fontTarget, fontName_ptr, fontStyle, numGlyphs, type, charcodes_ptr, handleMissingGlyphs, pathParameterTemplate, emScale);
                }
            }
            /// <inheritdoc cref="PathGlyphRange(uint, PathFontTarget, void*, PathFontStyle, uint, int, PathHandleMissingGlyphs, uint, float)"/>
            public static unsafe void PathGlyphRange(uint firstPathName, PathFontTarget fontTarget, IntPtr fontName, PathFontStyle fontStyle, uint firstGlyph, int numGlyphs, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale)
            {
                void* fontName_vptr = (void*)fontName;
                PathGlyphRange(firstPathName, fontTarget, fontName_vptr, fontStyle, firstGlyph, numGlyphs, handleMissingGlyphs, pathParameterTemplate, emScale);
            }
            /// <inheritdoc cref="PathGlyphRange(uint, PathFontTarget, void*, PathFontStyle, uint, int, PathHandleMissingGlyphs, uint, float)"/>
            public static unsafe void PathGlyphRange<T1>(uint firstPathName, PathFontTarget fontTarget, ReadOnlySpan<T1> fontName, PathFontStyle fontStyle, uint firstGlyph, int numGlyphs, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale)
                where T1 : unmanaged
            {
                fixed (void* fontName_ptr = fontName)
                {
                    PathGlyphRange(firstPathName, fontTarget, fontName_ptr, fontStyle, firstGlyph, numGlyphs, handleMissingGlyphs, pathParameterTemplate, emScale);
                }
            }
            /// <inheritdoc cref="PathGlyphRange(uint, PathFontTarget, void*, PathFontStyle, uint, int, PathHandleMissingGlyphs, uint, float)"/>
            public static unsafe void PathGlyphRange<T1>(uint firstPathName, PathFontTarget fontTarget, T1[] fontName, PathFontStyle fontStyle, uint firstGlyph, int numGlyphs, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale)
                where T1 : unmanaged
            {
                fixed (void* fontName_ptr = fontName)
                {
                    PathGlyphRange(firstPathName, fontTarget, fontName_ptr, fontStyle, firstGlyph, numGlyphs, handleMissingGlyphs, pathParameterTemplate, emScale);
                }
            }
            /// <inheritdoc cref="PathGlyphRange(uint, PathFontTarget, void*, PathFontStyle, uint, int, PathHandleMissingGlyphs, uint, float)"/>
            public static unsafe void PathGlyphRange<T1>(uint firstPathName, PathFontTarget fontTarget, in T1 fontName, PathFontStyle fontStyle, uint firstGlyph, int numGlyphs, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale)
                where T1 : unmanaged
            {
                fixed (void* fontName_ptr = &fontName)
                {
                    PathGlyphRange(firstPathName, fontTarget, fontName_ptr, fontStyle, firstGlyph, numGlyphs, handleMissingGlyphs, pathParameterTemplate, emScale);
                }
            }
            /// <inheritdoc cref="WeightPaths(uint, int, uint*, float*)"/>
            public static unsafe void WeightPaths(uint resultPath, int numPaths, ReadOnlySpan<uint> paths, ReadOnlySpan<float> weights)
            {
                fixed (uint* paths_ptr = paths)
                {
                    fixed (float* weights_ptr = weights)
                    {
                        WeightPaths(resultPath, numPaths, paths_ptr, weights_ptr);
                    }
                }
            }
            /// <inheritdoc cref="WeightPaths(uint, int, uint*, float*)"/>
            public static unsafe void WeightPaths(uint resultPath, int numPaths, uint[] paths, float[] weights)
            {
                fixed (uint* paths_ptr = paths)
                {
                    fixed (float* weights_ptr = weights)
                    {
                        WeightPaths(resultPath, numPaths, paths_ptr, weights_ptr);
                    }
                }
            }
            /// <inheritdoc cref="WeightPaths(uint, int, uint*, float*)"/>
            public static unsafe void WeightPaths(uint resultPath, int numPaths, in uint paths, in float weights)
            {
                fixed (uint* paths_ptr = &paths)
                fixed (float* weights_ptr = &weights)
                {
                    WeightPaths(resultPath, numPaths, paths_ptr, weights_ptr);
                }
            }
            /// <inheritdoc cref="TransformPath(uint, uint, PathTransformType, float*)"/>
            public static unsafe void TransformPath(uint resultPath, uint srcPath, PathTransformType transformType, ReadOnlySpan<float> transformValues)
            {
                fixed (float* transformValues_ptr = transformValues)
                {
                    TransformPath(resultPath, srcPath, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="TransformPath(uint, uint, PathTransformType, float*)"/>
            public static unsafe void TransformPath(uint resultPath, uint srcPath, PathTransformType transformType, float[] transformValues)
            {
                fixed (float* transformValues_ptr = transformValues)
                {
                    TransformPath(resultPath, srcPath, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="TransformPath(uint, uint, PathTransformType, float*)"/>
            public static unsafe void TransformPath(uint resultPath, uint srcPath, PathTransformType transformType, in float transformValues)
            {
                fixed (float* transformValues_ptr = &transformValues)
                {
                    TransformPath(resultPath, srcPath, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="PathParameteriv(uint, PathParameter, int*)"/>
            public static unsafe void PathParameteriv(uint path, PathParameter pname, ReadOnlySpan<int> value)
            {
                fixed (int* value_ptr = value)
                {
                    PathParameteriv(path, pname, value_ptr);
                }
            }
            /// <inheritdoc cref="PathParameteriv(uint, PathParameter, int*)"/>
            public static unsafe void PathParameteriv(uint path, PathParameter pname, int[] value)
            {
                fixed (int* value_ptr = value)
                {
                    PathParameteriv(path, pname, value_ptr);
                }
            }
            /// <inheritdoc cref="PathParameteriv(uint, PathParameter, int*)"/>
            public static unsafe void PathParameteriv(uint path, PathParameter pname, in int value)
            {
                fixed (int* value_ptr = &value)
                {
                    PathParameteriv(path, pname, value_ptr);
                }
            }
            /// <inheritdoc cref="PathParameterfv(uint, PathParameter, float*)"/>
            public static unsafe void PathParameterfv(uint path, PathParameter pname, ReadOnlySpan<float> value)
            {
                fixed (float* value_ptr = value)
                {
                    PathParameterfv(path, pname, value_ptr);
                }
            }
            /// <inheritdoc cref="PathParameterfv(uint, PathParameter, float*)"/>
            public static unsafe void PathParameterfv(uint path, PathParameter pname, float[] value)
            {
                fixed (float* value_ptr = value)
                {
                    PathParameterfv(path, pname, value_ptr);
                }
            }
            /// <inheritdoc cref="PathParameterfv(uint, PathParameter, float*)"/>
            public static unsafe void PathParameterfv(uint path, PathParameter pname, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    PathParameterfv(path, pname, value_ptr);
                }
            }
            /// <inheritdoc cref="PathDashArray(uint, int, float*)"/>
            public static unsafe void PathDashArray(uint path, ReadOnlySpan<float> dashArray)
            {
                int dashCount = (int)(dashArray.Length);
                fixed (float* dashArray_ptr = dashArray)
                {
                    PathDashArray(path, dashCount, dashArray_ptr);
                }
            }
            /// <inheritdoc cref="PathDashArray(uint, int, float*)"/>
            public static unsafe void PathDashArray(uint path, float[] dashArray)
            {
                int dashCount = (int)(dashArray.Length);
                fixed (float* dashArray_ptr = dashArray)
                {
                    PathDashArray(path, dashCount, dashArray_ptr);
                }
            }
            /// <inheritdoc cref="PathDashArray(uint, int, float*)"/>
            public static unsafe void PathDashArray(uint path, int dashCount, in float dashArray)
            {
                fixed (float* dashArray_ptr = &dashArray)
                {
                    PathDashArray(path, dashCount, dashArray_ptr);
                }
            }
            /// <inheritdoc cref="StencilFillPathInstanced(int, PathElementType, void*, uint, PathFillMode, uint, PathTransformType, float*)"/>
            public static unsafe void StencilFillPathInstanced(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, PathFillMode fillMode, uint mask, PathTransformType transformType, ReadOnlySpan<float> transformValues)
            {
                fixed (float* transformValues_ptr = transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    StencilFillPathInstanced(numPaths, pathNameType, paths_vptr, pathBase, fillMode, mask, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="StencilFillPathInstanced(int, PathElementType, void*, uint, PathFillMode, uint, PathTransformType, float*)"/>
            public static unsafe void StencilFillPathInstanced(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, PathFillMode fillMode, uint mask, PathTransformType transformType, float[] transformValues)
            {
                fixed (float* transformValues_ptr = transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    StencilFillPathInstanced(numPaths, pathNameType, paths_vptr, pathBase, fillMode, mask, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="StencilFillPathInstanced(int, PathElementType, void*, uint, PathFillMode, uint, PathTransformType, float*)"/>
            public static unsafe void StencilFillPathInstanced(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, PathFillMode fillMode, uint mask, PathTransformType transformType, in float transformValues)
            {
                fixed (float* transformValues_ptr = &transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    StencilFillPathInstanced(numPaths, pathNameType, paths_vptr, pathBase, fillMode, mask, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="StencilFillPathInstanced(int, PathElementType, void*, uint, PathFillMode, uint, PathTransformType, float*)"/>
            public static unsafe void StencilFillPathInstanced<T1>(int numPaths, PathElementType pathNameType, ReadOnlySpan<T1> paths, uint pathBase, PathFillMode fillMode, uint mask, PathTransformType transformType, ReadOnlySpan<float> transformValues)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = paths)
                {
                    fixed (float* transformValues_ptr = transformValues)
                    {
                        StencilFillPathInstanced(numPaths, pathNameType, paths_ptr, pathBase, fillMode, mask, transformType, transformValues_ptr);
                    }
                }
            }
            /// <inheritdoc cref="StencilFillPathInstanced(int, PathElementType, void*, uint, PathFillMode, uint, PathTransformType, float*)"/>
            public static unsafe void StencilFillPathInstanced<T1>(int numPaths, PathElementType pathNameType, T1[] paths, uint pathBase, PathFillMode fillMode, uint mask, PathTransformType transformType, float[] transformValues)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = paths)
                {
                    fixed (float* transformValues_ptr = transformValues)
                    {
                        StencilFillPathInstanced(numPaths, pathNameType, paths_ptr, pathBase, fillMode, mask, transformType, transformValues_ptr);
                    }
                }
            }
            /// <inheritdoc cref="StencilFillPathInstanced(int, PathElementType, void*, uint, PathFillMode, uint, PathTransformType, float*)"/>
            public static unsafe void StencilFillPathInstanced<T1>(int numPaths, PathElementType pathNameType, in T1 paths, uint pathBase, PathFillMode fillMode, uint mask, PathTransformType transformType, in float transformValues)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = &paths)
                fixed (float* transformValues_ptr = &transformValues)
                {
                    StencilFillPathInstanced(numPaths, pathNameType, paths_ptr, pathBase, fillMode, mask, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="StencilStrokePathInstanced(int, PathElementType, void*, uint, int, uint, PathTransformType, float*)"/>
            public static unsafe void StencilStrokePathInstanced(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, int reference, uint mask, PathTransformType transformType, ReadOnlySpan<float> transformValues)
            {
                fixed (float* transformValues_ptr = transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    StencilStrokePathInstanced(numPaths, pathNameType, paths_vptr, pathBase, reference, mask, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="StencilStrokePathInstanced(int, PathElementType, void*, uint, int, uint, PathTransformType, float*)"/>
            public static unsafe void StencilStrokePathInstanced(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, int reference, uint mask, PathTransformType transformType, float[] transformValues)
            {
                fixed (float* transformValues_ptr = transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    StencilStrokePathInstanced(numPaths, pathNameType, paths_vptr, pathBase, reference, mask, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="StencilStrokePathInstanced(int, PathElementType, void*, uint, int, uint, PathTransformType, float*)"/>
            public static unsafe void StencilStrokePathInstanced(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, int reference, uint mask, PathTransformType transformType, in float transformValues)
            {
                fixed (float* transformValues_ptr = &transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    StencilStrokePathInstanced(numPaths, pathNameType, paths_vptr, pathBase, reference, mask, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="StencilStrokePathInstanced(int, PathElementType, void*, uint, int, uint, PathTransformType, float*)"/>
            public static unsafe void StencilStrokePathInstanced<T1>(int numPaths, PathElementType pathNameType, ReadOnlySpan<T1> paths, uint pathBase, int reference, uint mask, PathTransformType transformType, ReadOnlySpan<float> transformValues)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = paths)
                {
                    fixed (float* transformValues_ptr = transformValues)
                    {
                        StencilStrokePathInstanced(numPaths, pathNameType, paths_ptr, pathBase, reference, mask, transformType, transformValues_ptr);
                    }
                }
            }
            /// <inheritdoc cref="StencilStrokePathInstanced(int, PathElementType, void*, uint, int, uint, PathTransformType, float*)"/>
            public static unsafe void StencilStrokePathInstanced<T1>(int numPaths, PathElementType pathNameType, T1[] paths, uint pathBase, int reference, uint mask, PathTransformType transformType, float[] transformValues)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = paths)
                {
                    fixed (float* transformValues_ptr = transformValues)
                    {
                        StencilStrokePathInstanced(numPaths, pathNameType, paths_ptr, pathBase, reference, mask, transformType, transformValues_ptr);
                    }
                }
            }
            /// <inheritdoc cref="StencilStrokePathInstanced(int, PathElementType, void*, uint, int, uint, PathTransformType, float*)"/>
            public static unsafe void StencilStrokePathInstanced<T1>(int numPaths, PathElementType pathNameType, in T1 paths, uint pathBase, int reference, uint mask, PathTransformType transformType, in float transformValues)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = &paths)
                fixed (float* transformValues_ptr = &transformValues)
                {
                    StencilStrokePathInstanced(numPaths, pathNameType, paths_ptr, pathBase, reference, mask, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="CoverFillPathInstanced(int, PathElementType, void*, uint, InstancedPathCoverMode, PathTransformType, float*)"/>
            public static unsafe void CoverFillPathInstanced(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, InstancedPathCoverMode coverMode, PathTransformType transformType, ReadOnlySpan<float> transformValues)
            {
                fixed (float* transformValues_ptr = transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    CoverFillPathInstanced(numPaths, pathNameType, paths_vptr, pathBase, coverMode, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="CoverFillPathInstanced(int, PathElementType, void*, uint, InstancedPathCoverMode, PathTransformType, float*)"/>
            public static unsafe void CoverFillPathInstanced(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, InstancedPathCoverMode coverMode, PathTransformType transformType, float[] transformValues)
            {
                fixed (float* transformValues_ptr = transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    CoverFillPathInstanced(numPaths, pathNameType, paths_vptr, pathBase, coverMode, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="CoverFillPathInstanced(int, PathElementType, void*, uint, InstancedPathCoverMode, PathTransformType, float*)"/>
            public static unsafe void CoverFillPathInstanced(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, InstancedPathCoverMode coverMode, PathTransformType transformType, in float transformValues)
            {
                fixed (float* transformValues_ptr = &transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    CoverFillPathInstanced(numPaths, pathNameType, paths_vptr, pathBase, coverMode, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="CoverFillPathInstanced(int, PathElementType, void*, uint, InstancedPathCoverMode, PathTransformType, float*)"/>
            public static unsafe void CoverFillPathInstanced<T1>(int numPaths, PathElementType pathNameType, ReadOnlySpan<T1> paths, uint pathBase, InstancedPathCoverMode coverMode, PathTransformType transformType, ReadOnlySpan<float> transformValues)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = paths)
                {
                    fixed (float* transformValues_ptr = transformValues)
                    {
                        CoverFillPathInstanced(numPaths, pathNameType, paths_ptr, pathBase, coverMode, transformType, transformValues_ptr);
                    }
                }
            }
            /// <inheritdoc cref="CoverFillPathInstanced(int, PathElementType, void*, uint, InstancedPathCoverMode, PathTransformType, float*)"/>
            public static unsafe void CoverFillPathInstanced<T1>(int numPaths, PathElementType pathNameType, T1[] paths, uint pathBase, InstancedPathCoverMode coverMode, PathTransformType transformType, float[] transformValues)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = paths)
                {
                    fixed (float* transformValues_ptr = transformValues)
                    {
                        CoverFillPathInstanced(numPaths, pathNameType, paths_ptr, pathBase, coverMode, transformType, transformValues_ptr);
                    }
                }
            }
            /// <inheritdoc cref="CoverFillPathInstanced(int, PathElementType, void*, uint, InstancedPathCoverMode, PathTransformType, float*)"/>
            public static unsafe void CoverFillPathInstanced<T1>(int numPaths, PathElementType pathNameType, in T1 paths, uint pathBase, InstancedPathCoverMode coverMode, PathTransformType transformType, in float transformValues)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = &paths)
                fixed (float* transformValues_ptr = &transformValues)
                {
                    CoverFillPathInstanced(numPaths, pathNameType, paths_ptr, pathBase, coverMode, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="CoverStrokePathInstanced(int, PathElementType, void*, uint, InstancedPathCoverMode, PathTransformType, float*)"/>
            public static unsafe void CoverStrokePathInstanced(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, InstancedPathCoverMode coverMode, PathTransformType transformType, ReadOnlySpan<float> transformValues)
            {
                fixed (float* transformValues_ptr = transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    CoverStrokePathInstanced(numPaths, pathNameType, paths_vptr, pathBase, coverMode, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="CoverStrokePathInstanced(int, PathElementType, void*, uint, InstancedPathCoverMode, PathTransformType, float*)"/>
            public static unsafe void CoverStrokePathInstanced(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, InstancedPathCoverMode coverMode, PathTransformType transformType, float[] transformValues)
            {
                fixed (float* transformValues_ptr = transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    CoverStrokePathInstanced(numPaths, pathNameType, paths_vptr, pathBase, coverMode, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="CoverStrokePathInstanced(int, PathElementType, void*, uint, InstancedPathCoverMode, PathTransformType, float*)"/>
            public static unsafe void CoverStrokePathInstanced(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, InstancedPathCoverMode coverMode, PathTransformType transformType, in float transformValues)
            {
                fixed (float* transformValues_ptr = &transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    CoverStrokePathInstanced(numPaths, pathNameType, paths_vptr, pathBase, coverMode, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="CoverStrokePathInstanced(int, PathElementType, void*, uint, InstancedPathCoverMode, PathTransformType, float*)"/>
            public static unsafe void CoverStrokePathInstanced<T1>(int numPaths, PathElementType pathNameType, ReadOnlySpan<T1> paths, uint pathBase, InstancedPathCoverMode coverMode, PathTransformType transformType, ReadOnlySpan<float> transformValues)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = paths)
                {
                    fixed (float* transformValues_ptr = transformValues)
                    {
                        CoverStrokePathInstanced(numPaths, pathNameType, paths_ptr, pathBase, coverMode, transformType, transformValues_ptr);
                    }
                }
            }
            /// <inheritdoc cref="CoverStrokePathInstanced(int, PathElementType, void*, uint, InstancedPathCoverMode, PathTransformType, float*)"/>
            public static unsafe void CoverStrokePathInstanced<T1>(int numPaths, PathElementType pathNameType, T1[] paths, uint pathBase, InstancedPathCoverMode coverMode, PathTransformType transformType, float[] transformValues)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = paths)
                {
                    fixed (float* transformValues_ptr = transformValues)
                    {
                        CoverStrokePathInstanced(numPaths, pathNameType, paths_ptr, pathBase, coverMode, transformType, transformValues_ptr);
                    }
                }
            }
            /// <inheritdoc cref="CoverStrokePathInstanced(int, PathElementType, void*, uint, InstancedPathCoverMode, PathTransformType, float*)"/>
            public static unsafe void CoverStrokePathInstanced<T1>(int numPaths, PathElementType pathNameType, in T1 paths, uint pathBase, InstancedPathCoverMode coverMode, PathTransformType transformType, in float transformValues)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = &paths)
                fixed (float* transformValues_ptr = &transformValues)
                {
                    CoverStrokePathInstanced(numPaths, pathNameType, paths_ptr, pathBase, coverMode, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="GetPathParameteriv(uint, PathParameter, int*)"/>
            public static unsafe void GetPathParameteriv(uint path, PathParameter pname, Span<int> value)
            {
                fixed (int* value_ptr = value)
                {
                    GetPathParameteriv(path, pname, value_ptr);
                }
            }
            /// <inheritdoc cref="GetPathParameteriv(uint, PathParameter, int*)"/>
            public static unsafe void GetPathParameteriv(uint path, PathParameter pname, int[] value)
            {
                fixed (int* value_ptr = value)
                {
                    GetPathParameteriv(path, pname, value_ptr);
                }
            }
            /// <inheritdoc cref="GetPathParameteriv(uint, PathParameter, int*)"/>
            public static unsafe void GetPathParameteriv(uint path, PathParameter pname, ref int value)
            {
                fixed (int* value_ptr = &value)
                {
                    GetPathParameteriv(path, pname, value_ptr);
                }
            }
            /// <inheritdoc cref="GetPathParameterfv(uint, PathParameter, float*)"/>
            public static unsafe void GetPathParameterfv(uint path, PathParameter pname, Span<float> value)
            {
                fixed (float* value_ptr = value)
                {
                    GetPathParameterfv(path, pname, value_ptr);
                }
            }
            /// <inheritdoc cref="GetPathParameterfv(uint, PathParameter, float*)"/>
            public static unsafe void GetPathParameterfv(uint path, PathParameter pname, float[] value)
            {
                fixed (float* value_ptr = value)
                {
                    GetPathParameterfv(path, pname, value_ptr);
                }
            }
            /// <inheritdoc cref="GetPathParameterfv(uint, PathParameter, float*)"/>
            public static unsafe void GetPathParameterfv(uint path, PathParameter pname, ref float value)
            {
                fixed (float* value_ptr = &value)
                {
                    GetPathParameterfv(path, pname, value_ptr);
                }
            }
            /// <inheritdoc cref="GetPathCommands(uint, byte*)"/>
            public static unsafe void GetPathCommands(uint path, Span<byte> commands)
            {
                fixed (byte* commands_ptr = commands)
                {
                    GetPathCommands(path, commands_ptr);
                }
            }
            /// <inheritdoc cref="GetPathCommands(uint, byte*)"/>
            public static unsafe void GetPathCommands(uint path, byte[] commands)
            {
                fixed (byte* commands_ptr = commands)
                {
                    GetPathCommands(path, commands_ptr);
                }
            }
            /// <inheritdoc cref="GetPathCommands(uint, byte*)"/>
            public static unsafe void GetPathCommands(uint path, ref byte commands)
            {
                fixed (byte* commands_ptr = &commands)
                {
                    GetPathCommands(path, commands_ptr);
                }
            }
            /// <inheritdoc cref="GetPathCoords(uint, float*)"/>
            public static unsafe void GetPathCoords(uint path, Span<float> coords)
            {
                fixed (float* coords_ptr = coords)
                {
                    GetPathCoords(path, coords_ptr);
                }
            }
            /// <inheritdoc cref="GetPathCoords(uint, float*)"/>
            public static unsafe void GetPathCoords(uint path, float[] coords)
            {
                fixed (float* coords_ptr = coords)
                {
                    GetPathCoords(path, coords_ptr);
                }
            }
            /// <inheritdoc cref="GetPathCoords(uint, float*)"/>
            public static unsafe void GetPathCoords(uint path, ref float coords)
            {
                fixed (float* coords_ptr = &coords)
                {
                    GetPathCoords(path, coords_ptr);
                }
            }
            /// <inheritdoc cref="GetPathDashArray(uint, float*)"/>
            public static unsafe void GetPathDashArray(uint path, Span<float> dashArray)
            {
                fixed (float* dashArray_ptr = dashArray)
                {
                    GetPathDashArray(path, dashArray_ptr);
                }
            }
            /// <inheritdoc cref="GetPathDashArray(uint, float*)"/>
            public static unsafe void GetPathDashArray(uint path, float[] dashArray)
            {
                fixed (float* dashArray_ptr = dashArray)
                {
                    GetPathDashArray(path, dashArray_ptr);
                }
            }
            /// <inheritdoc cref="GetPathDashArray(uint, float*)"/>
            public static unsafe void GetPathDashArray(uint path, ref float dashArray)
            {
                fixed (float* dashArray_ptr = &dashArray)
                {
                    GetPathDashArray(path, dashArray_ptr);
                }
            }
            /// <inheritdoc cref="GetPathMetrics(PathMetricMask, int, PathElementType, void*, uint, int, float*)"/>
            public static unsafe void GetPathMetrics(PathMetricMask metricQueryMask, int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, int stride, Span<float> metrics)
            {
                fixed (float* metrics_ptr = metrics)
                {
                    void* paths_vptr = (void*)paths;
                    GetPathMetrics(metricQueryMask, numPaths, pathNameType, paths_vptr, pathBase, stride, metrics_ptr);
                }
            }
            /// <inheritdoc cref="GetPathMetrics(PathMetricMask, int, PathElementType, void*, uint, int, float*)"/>
            public static unsafe void GetPathMetrics(PathMetricMask metricQueryMask, int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, int stride, float[] metrics)
            {
                fixed (float* metrics_ptr = metrics)
                {
                    void* paths_vptr = (void*)paths;
                    GetPathMetrics(metricQueryMask, numPaths, pathNameType, paths_vptr, pathBase, stride, metrics_ptr);
                }
            }
            /// <inheritdoc cref="GetPathMetrics(PathMetricMask, int, PathElementType, void*, uint, int, float*)"/>
            public static unsafe void GetPathMetrics(PathMetricMask metricQueryMask, int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, int stride, ref float metrics)
            {
                fixed (float* metrics_ptr = &metrics)
                {
                    void* paths_vptr = (void*)paths;
                    GetPathMetrics(metricQueryMask, numPaths, pathNameType, paths_vptr, pathBase, stride, metrics_ptr);
                }
            }
            /// <inheritdoc cref="GetPathMetrics(PathMetricMask, int, PathElementType, void*, uint, int, float*)"/>
            public static unsafe void GetPathMetrics<T1>(PathMetricMask metricQueryMask, int numPaths, PathElementType pathNameType, ReadOnlySpan<T1> paths, uint pathBase, int stride, Span<float> metrics)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = paths)
                {
                    fixed (float* metrics_ptr = metrics)
                    {
                        GetPathMetrics(metricQueryMask, numPaths, pathNameType, paths_ptr, pathBase, stride, metrics_ptr);
                    }
                }
            }
            /// <inheritdoc cref="GetPathMetrics(PathMetricMask, int, PathElementType, void*, uint, int, float*)"/>
            public static unsafe void GetPathMetrics<T1>(PathMetricMask metricQueryMask, int numPaths, PathElementType pathNameType, T1[] paths, uint pathBase, int stride, float[] metrics)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = paths)
                {
                    fixed (float* metrics_ptr = metrics)
                    {
                        GetPathMetrics(metricQueryMask, numPaths, pathNameType, paths_ptr, pathBase, stride, metrics_ptr);
                    }
                }
            }
            /// <inheritdoc cref="GetPathMetrics(PathMetricMask, int, PathElementType, void*, uint, int, float*)"/>
            public static unsafe void GetPathMetrics<T1>(PathMetricMask metricQueryMask, int numPaths, PathElementType pathNameType, in T1 paths, uint pathBase, int stride, ref float metrics)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = &paths)
                fixed (float* metrics_ptr = &metrics)
                {
                    GetPathMetrics(metricQueryMask, numPaths, pathNameType, paths_ptr, pathBase, stride, metrics_ptr);
                }
            }
            /// <inheritdoc cref="GetPathMetricRange(PathMetricMask, uint, int, int, float*)"/>
            public static unsafe void GetPathMetricRange(PathMetricMask metricQueryMask, uint firstPathName, int numPaths, int stride, Span<float> metrics)
            {
                fixed (float* metrics_ptr = metrics)
                {
                    GetPathMetricRange(metricQueryMask, firstPathName, numPaths, stride, metrics_ptr);
                }
            }
            /// <inheritdoc cref="GetPathMetricRange(PathMetricMask, uint, int, int, float*)"/>
            public static unsafe void GetPathMetricRange(PathMetricMask metricQueryMask, uint firstPathName, int numPaths, int stride, float[] metrics)
            {
                fixed (float* metrics_ptr = metrics)
                {
                    GetPathMetricRange(metricQueryMask, firstPathName, numPaths, stride, metrics_ptr);
                }
            }
            /// <inheritdoc cref="GetPathMetricRange(PathMetricMask, uint, int, int, float*)"/>
            public static unsafe void GetPathMetricRange(PathMetricMask metricQueryMask, uint firstPathName, int numPaths, int stride, ref float metrics)
            {
                fixed (float* metrics_ptr = &metrics)
                {
                    GetPathMetricRange(metricQueryMask, firstPathName, numPaths, stride, metrics_ptr);
                }
            }
            /// <inheritdoc cref="GetPathSpacing(PathListMode, int, PathElementType, void*, uint, float, float, PathTransformType, float*)"/>
            public static unsafe void GetPathSpacing(PathListMode pathListMode, int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, float advanceScale, float kerningScale, PathTransformType transformType, Span<float> returnedSpacing)
            {
                fixed (float* returnedSpacing_ptr = returnedSpacing)
                {
                    void* paths_vptr = (void*)paths;
                    GetPathSpacing(pathListMode, numPaths, pathNameType, paths_vptr, pathBase, advanceScale, kerningScale, transformType, returnedSpacing_ptr);
                }
            }
            /// <inheritdoc cref="GetPathSpacing(PathListMode, int, PathElementType, void*, uint, float, float, PathTransformType, float*)"/>
            public static unsafe void GetPathSpacing(PathListMode pathListMode, int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, float advanceScale, float kerningScale, PathTransformType transformType, float[] returnedSpacing)
            {
                fixed (float* returnedSpacing_ptr = returnedSpacing)
                {
                    void* paths_vptr = (void*)paths;
                    GetPathSpacing(pathListMode, numPaths, pathNameType, paths_vptr, pathBase, advanceScale, kerningScale, transformType, returnedSpacing_ptr);
                }
            }
            /// <inheritdoc cref="GetPathSpacing(PathListMode, int, PathElementType, void*, uint, float, float, PathTransformType, float*)"/>
            public static unsafe void GetPathSpacing(PathListMode pathListMode, int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, float advanceScale, float kerningScale, PathTransformType transformType, ref float returnedSpacing)
            {
                fixed (float* returnedSpacing_ptr = &returnedSpacing)
                {
                    void* paths_vptr = (void*)paths;
                    GetPathSpacing(pathListMode, numPaths, pathNameType, paths_vptr, pathBase, advanceScale, kerningScale, transformType, returnedSpacing_ptr);
                }
            }
            /// <inheritdoc cref="GetPathSpacing(PathListMode, int, PathElementType, void*, uint, float, float, PathTransformType, float*)"/>
            public static unsafe void GetPathSpacing<T1>(PathListMode pathListMode, int numPaths, PathElementType pathNameType, ReadOnlySpan<T1> paths, uint pathBase, float advanceScale, float kerningScale, PathTransformType transformType, Span<float> returnedSpacing)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = paths)
                {
                    fixed (float* returnedSpacing_ptr = returnedSpacing)
                    {
                        GetPathSpacing(pathListMode, numPaths, pathNameType, paths_ptr, pathBase, advanceScale, kerningScale, transformType, returnedSpacing_ptr);
                    }
                }
            }
            /// <inheritdoc cref="GetPathSpacing(PathListMode, int, PathElementType, void*, uint, float, float, PathTransformType, float*)"/>
            public static unsafe void GetPathSpacing<T1>(PathListMode pathListMode, int numPaths, PathElementType pathNameType, T1[] paths, uint pathBase, float advanceScale, float kerningScale, PathTransformType transformType, float[] returnedSpacing)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = paths)
                {
                    fixed (float* returnedSpacing_ptr = returnedSpacing)
                    {
                        GetPathSpacing(pathListMode, numPaths, pathNameType, paths_ptr, pathBase, advanceScale, kerningScale, transformType, returnedSpacing_ptr);
                    }
                }
            }
            /// <inheritdoc cref="GetPathSpacing(PathListMode, int, PathElementType, void*, uint, float, float, PathTransformType, float*)"/>
            public static unsafe void GetPathSpacing<T1>(PathListMode pathListMode, int numPaths, PathElementType pathNameType, in T1 paths, uint pathBase, float advanceScale, float kerningScale, PathTransformType transformType, ref float returnedSpacing)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = &paths)
                fixed (float* returnedSpacing_ptr = &returnedSpacing)
                {
                    GetPathSpacing(pathListMode, numPaths, pathNameType, paths_ptr, pathBase, advanceScale, kerningScale, transformType, returnedSpacing_ptr);
                }
            }
            /// <inheritdoc cref="PointAlongPath(uint, int, int, float, float*, float*, float*, float*)"/>
            public static unsafe bool PointAlongPath(uint path, int startSegment, int numSegments, float distance, Span<float> x, Span<float> y, Span<float> tangentX, Span<float> tangentY)
            {
                bool returnValue;
                fixed (float* x_ptr = x)
                {
                    fixed (float* y_ptr = y)
                    {
                        fixed (float* tangentX_ptr = tangentX)
                        {
                            fixed (float* tangentY_ptr = tangentY)
                            {
                                returnValue = PointAlongPath(path, startSegment, numSegments, distance, x_ptr, y_ptr, tangentX_ptr, tangentY_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="PointAlongPath(uint, int, int, float, float*, float*, float*, float*)"/>
            public static unsafe bool PointAlongPath(uint path, int startSegment, int numSegments, float distance, float[] x, float[] y, float[] tangentX, float[] tangentY)
            {
                bool returnValue;
                fixed (float* x_ptr = x)
                {
                    fixed (float* y_ptr = y)
                    {
                        fixed (float* tangentX_ptr = tangentX)
                        {
                            fixed (float* tangentY_ptr = tangentY)
                            {
                                returnValue = PointAlongPath(path, startSegment, numSegments, distance, x_ptr, y_ptr, tangentX_ptr, tangentY_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="PointAlongPath(uint, int, int, float, float*, float*, float*, float*)"/>
            public static unsafe bool PointAlongPath(uint path, int startSegment, int numSegments, float distance, ref float x, ref float y, ref float tangentX, ref float tangentY)
            {
                bool returnValue;
                fixed (float* x_ptr = &x)
                fixed (float* y_ptr = &y)
                fixed (float* tangentX_ptr = &tangentX)
                fixed (float* tangentY_ptr = &tangentY)
                {
                    returnValue = PointAlongPath(path, startSegment, numSegments, distance, x_ptr, y_ptr, tangentX_ptr, tangentY_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="MatrixLoad3x2f(All, float*)"/>
            public static unsafe void MatrixLoad3x2f(All matrixMode, in float m)
            {
                fixed (float* m_ptr = &m)
                {
                    MatrixLoad3x2f(matrixMode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixLoad3x3f(All, float*)"/>
            public static unsafe void MatrixLoad3x3f(All matrixMode, in float m)
            {
                fixed (float* m_ptr = &m)
                {
                    MatrixLoad3x3f(matrixMode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixLoadTranspose3x3f(All, float*)"/>
            public static unsafe void MatrixLoadTranspose3x3f(All matrixMode, in float m)
            {
                fixed (float* m_ptr = &m)
                {
                    MatrixLoadTranspose3x3f(matrixMode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixMult3x2f(All, float*)"/>
            public static unsafe void MatrixMult3x2f(All matrixMode, in float m)
            {
                fixed (float* m_ptr = &m)
                {
                    MatrixMult3x2f(matrixMode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixMult3x3f(All, float*)"/>
            public static unsafe void MatrixMult3x3f(All matrixMode, in float m)
            {
                fixed (float* m_ptr = &m)
                {
                    MatrixMult3x3f(matrixMode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixMultTranspose3x3f(All, float*)"/>
            public static unsafe void MatrixMultTranspose3x3f(All matrixMode, in float m)
            {
                fixed (float* m_ptr = &m)
                {
                    MatrixMultTranspose3x3f(matrixMode, m_ptr);
                }
            }
            /// <inheritdoc cref="StencilThenCoverFillPathInstanced(int, PathElementType, void*, uint, PathFillMode, uint, InstancedPathCoverMode, PathTransformType, float*)"/>
            public static unsafe void StencilThenCoverFillPathInstanced(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, PathFillMode fillMode, uint mask, InstancedPathCoverMode coverMode, PathTransformType transformType, ReadOnlySpan<float> transformValues)
            {
                fixed (float* transformValues_ptr = transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    StencilThenCoverFillPathInstanced(numPaths, pathNameType, paths_vptr, pathBase, fillMode, mask, coverMode, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="StencilThenCoverFillPathInstanced(int, PathElementType, void*, uint, PathFillMode, uint, InstancedPathCoverMode, PathTransformType, float*)"/>
            public static unsafe void StencilThenCoverFillPathInstanced(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, PathFillMode fillMode, uint mask, InstancedPathCoverMode coverMode, PathTransformType transformType, float[] transformValues)
            {
                fixed (float* transformValues_ptr = transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    StencilThenCoverFillPathInstanced(numPaths, pathNameType, paths_vptr, pathBase, fillMode, mask, coverMode, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="StencilThenCoverFillPathInstanced(int, PathElementType, void*, uint, PathFillMode, uint, InstancedPathCoverMode, PathTransformType, float*)"/>
            public static unsafe void StencilThenCoverFillPathInstanced(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, PathFillMode fillMode, uint mask, InstancedPathCoverMode coverMode, PathTransformType transformType, in float transformValues)
            {
                fixed (float* transformValues_ptr = &transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    StencilThenCoverFillPathInstanced(numPaths, pathNameType, paths_vptr, pathBase, fillMode, mask, coverMode, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="StencilThenCoverFillPathInstanced(int, PathElementType, void*, uint, PathFillMode, uint, InstancedPathCoverMode, PathTransformType, float*)"/>
            public static unsafe void StencilThenCoverFillPathInstanced<T1>(int numPaths, PathElementType pathNameType, ReadOnlySpan<T1> paths, uint pathBase, PathFillMode fillMode, uint mask, InstancedPathCoverMode coverMode, PathTransformType transformType, ReadOnlySpan<float> transformValues)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = paths)
                {
                    fixed (float* transformValues_ptr = transformValues)
                    {
                        StencilThenCoverFillPathInstanced(numPaths, pathNameType, paths_ptr, pathBase, fillMode, mask, coverMode, transformType, transformValues_ptr);
                    }
                }
            }
            /// <inheritdoc cref="StencilThenCoverFillPathInstanced(int, PathElementType, void*, uint, PathFillMode, uint, InstancedPathCoverMode, PathTransformType, float*)"/>
            public static unsafe void StencilThenCoverFillPathInstanced<T1>(int numPaths, PathElementType pathNameType, T1[] paths, uint pathBase, PathFillMode fillMode, uint mask, InstancedPathCoverMode coverMode, PathTransformType transformType, float[] transformValues)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = paths)
                {
                    fixed (float* transformValues_ptr = transformValues)
                    {
                        StencilThenCoverFillPathInstanced(numPaths, pathNameType, paths_ptr, pathBase, fillMode, mask, coverMode, transformType, transformValues_ptr);
                    }
                }
            }
            /// <inheritdoc cref="StencilThenCoverFillPathInstanced(int, PathElementType, void*, uint, PathFillMode, uint, InstancedPathCoverMode, PathTransformType, float*)"/>
            public static unsafe void StencilThenCoverFillPathInstanced<T1>(int numPaths, PathElementType pathNameType, in T1 paths, uint pathBase, PathFillMode fillMode, uint mask, InstancedPathCoverMode coverMode, PathTransformType transformType, in float transformValues)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = &paths)
                fixed (float* transformValues_ptr = &transformValues)
                {
                    StencilThenCoverFillPathInstanced(numPaths, pathNameType, paths_ptr, pathBase, fillMode, mask, coverMode, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="StencilThenCoverStrokePathInstanced(int, PathElementType, void*, uint, int, uint, InstancedPathCoverMode, PathTransformType, float*)"/>
            public static unsafe void StencilThenCoverStrokePathInstanced(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, int reference, uint mask, InstancedPathCoverMode coverMode, PathTransformType transformType, ReadOnlySpan<float> transformValues)
            {
                fixed (float* transformValues_ptr = transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    StencilThenCoverStrokePathInstanced(numPaths, pathNameType, paths_vptr, pathBase, reference, mask, coverMode, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="StencilThenCoverStrokePathInstanced(int, PathElementType, void*, uint, int, uint, InstancedPathCoverMode, PathTransformType, float*)"/>
            public static unsafe void StencilThenCoverStrokePathInstanced(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, int reference, uint mask, InstancedPathCoverMode coverMode, PathTransformType transformType, float[] transformValues)
            {
                fixed (float* transformValues_ptr = transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    StencilThenCoverStrokePathInstanced(numPaths, pathNameType, paths_vptr, pathBase, reference, mask, coverMode, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="StencilThenCoverStrokePathInstanced(int, PathElementType, void*, uint, int, uint, InstancedPathCoverMode, PathTransformType, float*)"/>
            public static unsafe void StencilThenCoverStrokePathInstanced(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, int reference, uint mask, InstancedPathCoverMode coverMode, PathTransformType transformType, in float transformValues)
            {
                fixed (float* transformValues_ptr = &transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    StencilThenCoverStrokePathInstanced(numPaths, pathNameType, paths_vptr, pathBase, reference, mask, coverMode, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="StencilThenCoverStrokePathInstanced(int, PathElementType, void*, uint, int, uint, InstancedPathCoverMode, PathTransformType, float*)"/>
            public static unsafe void StencilThenCoverStrokePathInstanced<T1>(int numPaths, PathElementType pathNameType, ReadOnlySpan<T1> paths, uint pathBase, int reference, uint mask, InstancedPathCoverMode coverMode, PathTransformType transformType, ReadOnlySpan<float> transformValues)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = paths)
                {
                    fixed (float* transformValues_ptr = transformValues)
                    {
                        StencilThenCoverStrokePathInstanced(numPaths, pathNameType, paths_ptr, pathBase, reference, mask, coverMode, transformType, transformValues_ptr);
                    }
                }
            }
            /// <inheritdoc cref="StencilThenCoverStrokePathInstanced(int, PathElementType, void*, uint, int, uint, InstancedPathCoverMode, PathTransformType, float*)"/>
            public static unsafe void StencilThenCoverStrokePathInstanced<T1>(int numPaths, PathElementType pathNameType, T1[] paths, uint pathBase, int reference, uint mask, InstancedPathCoverMode coverMode, PathTransformType transformType, float[] transformValues)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = paths)
                {
                    fixed (float* transformValues_ptr = transformValues)
                    {
                        StencilThenCoverStrokePathInstanced(numPaths, pathNameType, paths_ptr, pathBase, reference, mask, coverMode, transformType, transformValues_ptr);
                    }
                }
            }
            /// <inheritdoc cref="StencilThenCoverStrokePathInstanced(int, PathElementType, void*, uint, int, uint, InstancedPathCoverMode, PathTransformType, float*)"/>
            public static unsafe void StencilThenCoverStrokePathInstanced<T1>(int numPaths, PathElementType pathNameType, in T1 paths, uint pathBase, int reference, uint mask, InstancedPathCoverMode coverMode, PathTransformType transformType, in float transformValues)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = &paths)
                fixed (float* transformValues_ptr = &transformValues)
                {
                    StencilThenCoverStrokePathInstanced(numPaths, pathNameType, paths_ptr, pathBase, reference, mask, coverMode, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="PathGlyphIndexRange(All, void*, PathFontStyle, uint, float, uint*)"/>
            public static unsafe All PathGlyphIndexRange(All fontTarget, IntPtr fontName, PathFontStyle fontStyle, uint pathParameterTemplate, float emScale, Span<uint> baseAndCount)
            {
                All returnValue;
                fixed (uint* baseAndCount_ptr = baseAndCount)
                {
                    void* fontName_vptr = (void*)fontName;
                    returnValue = PathGlyphIndexRange(fontTarget, fontName_vptr, fontStyle, pathParameterTemplate, emScale, baseAndCount_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="PathGlyphIndexRange(All, void*, PathFontStyle, uint, float, uint*)"/>
            public static unsafe All PathGlyphIndexRange(All fontTarget, IntPtr fontName, PathFontStyle fontStyle, uint pathParameterTemplate, float emScale, uint[] baseAndCount)
            {
                All returnValue;
                fixed (uint* baseAndCount_ptr = baseAndCount)
                {
                    void* fontName_vptr = (void*)fontName;
                    returnValue = PathGlyphIndexRange(fontTarget, fontName_vptr, fontStyle, pathParameterTemplate, emScale, baseAndCount_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="PathGlyphIndexRange(All, void*, PathFontStyle, uint, float, uint*)"/>
            public static unsafe All PathGlyphIndexRange(All fontTarget, IntPtr fontName, PathFontStyle fontStyle, uint pathParameterTemplate, float emScale, ref uint baseAndCount)
            {
                All returnValue;
                fixed (uint* baseAndCount_ptr = &baseAndCount)
                {
                    void* fontName_vptr = (void*)fontName;
                    returnValue = PathGlyphIndexRange(fontTarget, fontName_vptr, fontStyle, pathParameterTemplate, emScale, baseAndCount_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="PathGlyphIndexRange(All, void*, PathFontStyle, uint, float, uint*)"/>
            public static unsafe All PathGlyphIndexRange<T1>(All fontTarget, in T1 fontName, PathFontStyle fontStyle, uint pathParameterTemplate, float emScale, Span<uint> baseAndCount)
                where T1 : unmanaged
            {
                All returnValue;
                fixed (void* fontName_ptr = &fontName)
                {
                    fixed (uint* baseAndCount_ptr = baseAndCount)
                    {
                        returnValue = PathGlyphIndexRange(fontTarget, fontName_ptr, fontStyle, pathParameterTemplate, emScale, baseAndCount_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="PathGlyphIndexRange(All, void*, PathFontStyle, uint, float, uint*)"/>
            public static unsafe All PathGlyphIndexRange<T1>(All fontTarget, in T1 fontName, PathFontStyle fontStyle, uint pathParameterTemplate, float emScale, uint[] baseAndCount)
                where T1 : unmanaged
            {
                All returnValue;
                fixed (void* fontName_ptr = &fontName)
                {
                    fixed (uint* baseAndCount_ptr = baseAndCount)
                    {
                        returnValue = PathGlyphIndexRange(fontTarget, fontName_ptr, fontStyle, pathParameterTemplate, emScale, baseAndCount_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="PathGlyphIndexRange(All, void*, PathFontStyle, uint, float, uint*)"/>
            public static unsafe All PathGlyphIndexRange<T1>(All fontTarget, in T1 fontName, PathFontStyle fontStyle, uint pathParameterTemplate, float emScale, ref uint baseAndCount)
                where T1 : unmanaged
            {
                All returnValue;
                fixed (void* fontName_ptr = &fontName)
                fixed (uint* baseAndCount_ptr = &baseAndCount)
                {
                    returnValue = PathGlyphIndexRange(fontTarget, fontName_ptr, fontStyle, pathParameterTemplate, emScale, baseAndCount_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="PathGlyphIndexArray(uint, All, void*, PathFontStyle, uint, int, uint, float)"/>
            public static unsafe All PathGlyphIndexArray(uint firstPathName, All fontTarget, IntPtr fontName, PathFontStyle fontStyle, uint firstGlyphIndex, int numGlyphs, uint pathParameterTemplate, float emScale)
            {
                All returnValue;
                void* fontName_vptr = (void*)fontName;
                returnValue = PathGlyphIndexArray(firstPathName, fontTarget, fontName_vptr, fontStyle, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);
                return returnValue;
            }
            /// <inheritdoc cref="PathGlyphIndexArray(uint, All, void*, PathFontStyle, uint, int, uint, float)"/>
            public static unsafe All PathGlyphIndexArray<T1>(uint firstPathName, All fontTarget, in T1 fontName, PathFontStyle fontStyle, uint firstGlyphIndex, int numGlyphs, uint pathParameterTemplate, float emScale)
                where T1 : unmanaged
            {
                All returnValue;
                fixed (void* fontName_ptr = &fontName)
                {
                    returnValue = PathGlyphIndexArray(firstPathName, fontTarget, fontName_ptr, fontStyle, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);
                }
                return returnValue;
            }
            /// <inheritdoc cref="PathMemoryGlyphIndexArray(uint, All, nint, void*, int, uint, int, uint, float)"/>
            public static unsafe All PathMemoryGlyphIndexArray(uint firstPathName, All fontTarget, nint fontSize, IntPtr fontData, int faceIndex, uint firstGlyphIndex, int numGlyphs, uint pathParameterTemplate, float emScale)
            {
                All returnValue;
                void* fontData_vptr = (void*)fontData;
                returnValue = PathMemoryGlyphIndexArray(firstPathName, fontTarget, fontSize, fontData_vptr, faceIndex, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);
                return returnValue;
            }
            /// <inheritdoc cref="PathMemoryGlyphIndexArray(uint, All, nint, void*, int, uint, int, uint, float)"/>
            public static unsafe All PathMemoryGlyphIndexArray<T1>(uint firstPathName, All fontTarget, nint fontSize, in T1 fontData, int faceIndex, uint firstGlyphIndex, int numGlyphs, uint pathParameterTemplate, float emScale)
                where T1 : unmanaged
            {
                All returnValue;
                fixed (void* fontData_ptr = &fontData)
                {
                    returnValue = PathMemoryGlyphIndexArray(firstPathName, fontTarget, fontSize, fontData_ptr, faceIndex, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ProgramPathFragmentInputGen(int, int, All, int, float*)"/>
            public static unsafe void ProgramPathFragmentInputGen(int program, int location, All genMode, int components, in float coeffs)
            {
                fixed (float* coeffs_ptr = &coeffs)
                {
                    ProgramPathFragmentInputGen(program, location, genMode, components, coeffs_ptr);
                }
            }
            /// <inheritdoc cref="GetProgramResourcefv(int, ProgramInterface, uint, int, All*, int, int*, float*)"/>
            public static unsafe void GetProgramResourcefv(int program, ProgramInterface programInterface, uint index, int propCount, in All props, Span<int> length, Span<float> parameters)
            {
                fixed (All* props_ptr = &props)
                {
                    fixed (int* length_ptr = length)
                    {
                        int count = (int)(parameters.Length);
                        fixed (float* parameters_ptr = parameters)
                        {
                            GetProgramResourcefv(program, programInterface, index, propCount, props_ptr, count, length_ptr, parameters_ptr);
                        }
                    }
                }
            }
            /// <inheritdoc cref="GetProgramResourcefv(int, ProgramInterface, uint, int, All*, int, int*, float*)"/>
            public static unsafe void GetProgramResourcefv(int program, ProgramInterface programInterface, uint index, int propCount, in All props, int[] length, float[] parameters)
            {
                fixed (All* props_ptr = &props)
                {
                    fixed (int* length_ptr = length)
                    {
                        int count = (int)(parameters.Length);
                        fixed (float* parameters_ptr = parameters)
                        {
                            GetProgramResourcefv(program, programInterface, index, propCount, props_ptr, count, length_ptr, parameters_ptr);
                        }
                    }
                }
            }
            /// <inheritdoc cref="GetProgramResourcefv(int, ProgramInterface, uint, int, All*, int, int*, float*)"/>
            public static unsafe void GetProgramResourcefv(int program, ProgramInterface programInterface, uint index, int propCount, in All props, int count, ref int length, ref float parameters)
            {
                fixed (All* props_ptr = &props)
                fixed (int* length_ptr = &length)
                fixed (float* parameters_ptr = &parameters)
                {
                    GetProgramResourcefv(program, programInterface, index, propCount, props_ptr, count, length_ptr, parameters_ptr);
                }
            }
            /// <inheritdoc cref="MatrixLoadTransposefEXT(MatrixMode, float*)"/>
            public static unsafe void MatrixLoadTransposefEXT(MatrixMode mode, ReadOnlySpan<float> m)
            {
                fixed (float* m_ptr = m)
                {
                    MatrixLoadTransposefEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixLoadTransposefEXT(MatrixMode, float*)"/>
            public static unsafe void MatrixLoadTransposefEXT(MatrixMode mode, float[] m)
            {
                fixed (float* m_ptr = m)
                {
                    MatrixLoadTransposefEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixLoadTransposefEXT(MatrixMode, float*)"/>
            public static unsafe void MatrixLoadTransposefEXT(MatrixMode mode, in float m)
            {
                fixed (float* m_ptr = &m)
                {
                    MatrixLoadTransposefEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixLoadTransposedEXT(MatrixMode, double*)"/>
            public static unsafe void MatrixLoadTransposedEXT(MatrixMode mode, ReadOnlySpan<double> m)
            {
                fixed (double* m_ptr = m)
                {
                    MatrixLoadTransposedEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixLoadTransposedEXT(MatrixMode, double*)"/>
            public static unsafe void MatrixLoadTransposedEXT(MatrixMode mode, double[] m)
            {
                fixed (double* m_ptr = m)
                {
                    MatrixLoadTransposedEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixLoadTransposedEXT(MatrixMode, double*)"/>
            public static unsafe void MatrixLoadTransposedEXT(MatrixMode mode, in double m)
            {
                fixed (double* m_ptr = &m)
                {
                    MatrixLoadTransposedEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixLoadfEXT(MatrixMode, float*)"/>
            public static unsafe void MatrixLoadfEXT(MatrixMode mode, ReadOnlySpan<float> m)
            {
                fixed (float* m_ptr = m)
                {
                    MatrixLoadfEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixLoadfEXT(MatrixMode, float*)"/>
            public static unsafe void MatrixLoadfEXT(MatrixMode mode, float[] m)
            {
                fixed (float* m_ptr = m)
                {
                    MatrixLoadfEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixLoadfEXT(MatrixMode, float*)"/>
            public static unsafe void MatrixLoadfEXT(MatrixMode mode, in float m)
            {
                fixed (float* m_ptr = &m)
                {
                    MatrixLoadfEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixLoaddEXT(MatrixMode, double*)"/>
            public static unsafe void MatrixLoaddEXT(MatrixMode mode, ReadOnlySpan<double> m)
            {
                fixed (double* m_ptr = m)
                {
                    MatrixLoaddEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixLoaddEXT(MatrixMode, double*)"/>
            public static unsafe void MatrixLoaddEXT(MatrixMode mode, double[] m)
            {
                fixed (double* m_ptr = m)
                {
                    MatrixLoaddEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixLoaddEXT(MatrixMode, double*)"/>
            public static unsafe void MatrixLoaddEXT(MatrixMode mode, in double m)
            {
                fixed (double* m_ptr = &m)
                {
                    MatrixLoaddEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixMultTransposefEXT(MatrixMode, float*)"/>
            public static unsafe void MatrixMultTransposefEXT(MatrixMode mode, ReadOnlySpan<float> m)
            {
                fixed (float* m_ptr = m)
                {
                    MatrixMultTransposefEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixMultTransposefEXT(MatrixMode, float*)"/>
            public static unsafe void MatrixMultTransposefEXT(MatrixMode mode, float[] m)
            {
                fixed (float* m_ptr = m)
                {
                    MatrixMultTransposefEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixMultTransposefEXT(MatrixMode, float*)"/>
            public static unsafe void MatrixMultTransposefEXT(MatrixMode mode, in float m)
            {
                fixed (float* m_ptr = &m)
                {
                    MatrixMultTransposefEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixMultTransposedEXT(MatrixMode, double*)"/>
            public static unsafe void MatrixMultTransposedEXT(MatrixMode mode, ReadOnlySpan<double> m)
            {
                fixed (double* m_ptr = m)
                {
                    MatrixMultTransposedEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixMultTransposedEXT(MatrixMode, double*)"/>
            public static unsafe void MatrixMultTransposedEXT(MatrixMode mode, double[] m)
            {
                fixed (double* m_ptr = m)
                {
                    MatrixMultTransposedEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixMultTransposedEXT(MatrixMode, double*)"/>
            public static unsafe void MatrixMultTransposedEXT(MatrixMode mode, in double m)
            {
                fixed (double* m_ptr = &m)
                {
                    MatrixMultTransposedEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixMultfEXT(MatrixMode, float*)"/>
            public static unsafe void MatrixMultfEXT(MatrixMode mode, ReadOnlySpan<float> m)
            {
                fixed (float* m_ptr = m)
                {
                    MatrixMultfEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixMultfEXT(MatrixMode, float*)"/>
            public static unsafe void MatrixMultfEXT(MatrixMode mode, float[] m)
            {
                fixed (float* m_ptr = m)
                {
                    MatrixMultfEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixMultfEXT(MatrixMode, float*)"/>
            public static unsafe void MatrixMultfEXT(MatrixMode mode, in float m)
            {
                fixed (float* m_ptr = &m)
                {
                    MatrixMultfEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixMultdEXT(MatrixMode, double*)"/>
            public static unsafe void MatrixMultdEXT(MatrixMode mode, ReadOnlySpan<double> m)
            {
                fixed (double* m_ptr = m)
                {
                    MatrixMultdEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixMultdEXT(MatrixMode, double*)"/>
            public static unsafe void MatrixMultdEXT(MatrixMode mode, double[] m)
            {
                fixed (double* m_ptr = m)
                {
                    MatrixMultdEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixMultdEXT(MatrixMode, double*)"/>
            public static unsafe void MatrixMultdEXT(MatrixMode mode, in double m)
            {
                fixed (double* m_ptr = &m)
                {
                    MatrixMultdEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="FramebufferSampleLocationsfv(FramebufferTarget, uint, int, float*)"/>
            public static unsafe void FramebufferSampleLocationsfv(FramebufferTarget target, uint start, int count, in float v)
            {
                fixed (float* v_ptr = &v)
                {
                    FramebufferSampleLocationsfv(target, start, count, v_ptr);
                }
            }
            /// <inheritdoc cref="NamedFramebufferSampleLocationsfv(int, uint, int, float*)"/>
            public static unsafe void NamedFramebufferSampleLocationsfv(int framebuffer, uint start, int count, in float v)
            {
                fixed (float* v_ptr = &v)
                {
                    NamedFramebufferSampleLocationsfv(framebuffer, start, count, v_ptr);
                }
            }
            /// <inheritdoc cref="ScissorExclusiveArrayv(uint, int, int*)"/>
            public static unsafe void ScissorExclusiveArrayv(uint first, int count, ReadOnlySpan<int> v)
            {
                fixed (int* v_ptr = v)
                {
                    ScissorExclusiveArrayv(first, count, v_ptr);
                }
            }
            /// <inheritdoc cref="ScissorExclusiveArrayv(uint, int, int*)"/>
            public static unsafe void ScissorExclusiveArrayv(uint first, int count, int[] v)
            {
                fixed (int* v_ptr = v)
                {
                    ScissorExclusiveArrayv(first, count, v_ptr);
                }
            }
            /// <inheritdoc cref="ScissorExclusiveArrayv(uint, int, int*)"/>
            public static unsafe void ScissorExclusiveArrayv(uint first, int count, in int v)
            {
                fixed (int* v_ptr = &v)
                {
                    ScissorExclusiveArrayv(first, count, v_ptr);
                }
            }
            /// <inheritdoc cref="GetShadingRateImagePalette(uint, uint, All*)"/>
            public static unsafe void GetShadingRateImagePalette(uint viewport, uint entry, Span<All> rate)
            {
                fixed (All* rate_ptr = rate)
                {
                    GetShadingRateImagePalette(viewport, entry, rate_ptr);
                }
            }
            /// <inheritdoc cref="GetShadingRateImagePalette(uint, uint, All*)"/>
            public static unsafe void GetShadingRateImagePalette(uint viewport, uint entry, All[] rate)
            {
                fixed (All* rate_ptr = rate)
                {
                    GetShadingRateImagePalette(viewport, entry, rate_ptr);
                }
            }
            /// <inheritdoc cref="GetShadingRateImagePalette(uint, uint, All*)"/>
            public static unsafe void GetShadingRateImagePalette(uint viewport, uint entry, ref All rate)
            {
                fixed (All* rate_ptr = &rate)
                {
                    GetShadingRateImagePalette(viewport, entry, rate_ptr);
                }
            }
            /// <inheritdoc cref="GetShadingRateSampleLocationiv(All, uint, uint, int*)"/>
            public static unsafe void GetShadingRateSampleLocationiv(All rate, uint samples, uint index, Span<int> location)
            {
                fixed (int* location_ptr = location)
                {
                    GetShadingRateSampleLocationiv(rate, samples, index, location_ptr);
                }
            }
            /// <inheritdoc cref="GetShadingRateSampleLocationiv(All, uint, uint, int*)"/>
            public static unsafe void GetShadingRateSampleLocationiv(All rate, uint samples, uint index, int[] location)
            {
                fixed (int* location_ptr = location)
                {
                    GetShadingRateSampleLocationiv(rate, samples, index, location_ptr);
                }
            }
            /// <inheritdoc cref="GetShadingRateSampleLocationiv(All, uint, uint, int*)"/>
            public static unsafe void GetShadingRateSampleLocationiv(All rate, uint samples, uint index, ref int location)
            {
                fixed (int* location_ptr = &location)
                {
                    GetShadingRateSampleLocationiv(rate, samples, index, location_ptr);
                }
            }
            /// <inheritdoc cref="ShadingRateImagePalette(uint, uint, int, All*)"/>
            public static unsafe void ShadingRateImagePalette(uint viewport, uint first, ReadOnlySpan<All> rates)
            {
                int count = (int)(rates.Length);
                fixed (All* rates_ptr = rates)
                {
                    ShadingRateImagePalette(viewport, first, count, rates_ptr);
                }
            }
            /// <inheritdoc cref="ShadingRateImagePalette(uint, uint, int, All*)"/>
            public static unsafe void ShadingRateImagePalette(uint viewport, uint first, All[] rates)
            {
                int count = (int)(rates.Length);
                fixed (All* rates_ptr = rates)
                {
                    ShadingRateImagePalette(viewport, first, count, rates_ptr);
                }
            }
            /// <inheritdoc cref="ShadingRateImagePalette(uint, uint, int, All*)"/>
            public static unsafe void ShadingRateImagePalette(uint viewport, uint first, int count, in All rates)
            {
                fixed (All* rates_ptr = &rates)
                {
                    ShadingRateImagePalette(viewport, first, count, rates_ptr);
                }
            }
            /// <inheritdoc cref="ShadingRateSampleOrderCustom(All, uint, int*)"/>
            public static unsafe void ShadingRateSampleOrderCustom(All rate, uint samples, ReadOnlySpan<int> locations)
            {
                fixed (int* locations_ptr = locations)
                {
                    ShadingRateSampleOrderCustom(rate, samples, locations_ptr);
                }
            }
            /// <inheritdoc cref="ShadingRateSampleOrderCustom(All, uint, int*)"/>
            public static unsafe void ShadingRateSampleOrderCustom(All rate, uint samples, int[] locations)
            {
                fixed (int* locations_ptr = locations)
                {
                    ShadingRateSampleOrderCustom(rate, samples, locations_ptr);
                }
            }
            /// <inheritdoc cref="ShadingRateSampleOrderCustom(All, uint, int*)"/>
            public static unsafe void ShadingRateSampleOrderCustom(All rate, uint samples, in int locations)
            {
                fixed (int* locations_ptr = &locations)
                {
                    ShadingRateSampleOrderCustom(rate, samples, locations_ptr);
                }
            }
            /// <inheritdoc cref="ViewportArrayv(uint, int, float*)"/>
            public static unsafe void ViewportArrayv(uint first, int count, ReadOnlySpan<float> v)
            {
                fixed (float* v_ptr = v)
                {
                    ViewportArrayv(first, count, v_ptr);
                }
            }
            /// <inheritdoc cref="ViewportArrayv(uint, int, float*)"/>
            public static unsafe void ViewportArrayv(uint first, int count, float[] v)
            {
                fixed (float* v_ptr = v)
                {
                    ViewportArrayv(first, count, v_ptr);
                }
            }
            /// <inheritdoc cref="ViewportArrayv(uint, int, float*)"/>
            public static unsafe void ViewportArrayv(uint first, int count, in float v)
            {
                fixed (float* v_ptr = &v)
                {
                    ViewportArrayv(first, count, v_ptr);
                }
            }
            /// <inheritdoc cref="ViewportIndexedfv(uint, float*)"/>
            public static unsafe void ViewportIndexedfv(uint index, ReadOnlySpan<float> v)
            {
                fixed (float* v_ptr = v)
                {
                    ViewportIndexedfv(index, v_ptr);
                }
            }
            /// <inheritdoc cref="ViewportIndexedfv(uint, float*)"/>
            public static unsafe void ViewportIndexedfv(uint index, float[] v)
            {
                fixed (float* v_ptr = v)
                {
                    ViewportIndexedfv(index, v_ptr);
                }
            }
            /// <inheritdoc cref="ViewportIndexedfv(uint, float*)"/>
            public static unsafe void ViewportIndexedfv(uint index, in float v)
            {
                fixed (float* v_ptr = &v)
                {
                    ViewportIndexedfv(index, v_ptr);
                }
            }
            /// <inheritdoc cref="ScissorArrayv(uint, int, int*)"/>
            public static unsafe void ScissorArrayv(uint first, int count, ReadOnlySpan<int> v)
            {
                fixed (int* v_ptr = v)
                {
                    ScissorArrayv(first, count, v_ptr);
                }
            }
            /// <inheritdoc cref="ScissorArrayv(uint, int, int*)"/>
            public static unsafe void ScissorArrayv(uint first, int count, int[] v)
            {
                fixed (int* v_ptr = v)
                {
                    ScissorArrayv(first, count, v_ptr);
                }
            }
            /// <inheritdoc cref="ScissorArrayv(uint, int, int*)"/>
            public static unsafe void ScissorArrayv(uint first, int count, in int v)
            {
                fixed (int* v_ptr = &v)
                {
                    ScissorArrayv(first, count, v_ptr);
                }
            }
            /// <inheritdoc cref="ScissorIndexedv(uint, int*)"/>
            public static unsafe void ScissorIndexedv(uint index, ReadOnlySpan<int> v)
            {
                fixed (int* v_ptr = v)
                {
                    ScissorIndexedv(index, v_ptr);
                }
            }
            /// <inheritdoc cref="ScissorIndexedv(uint, int*)"/>
            public static unsafe void ScissorIndexedv(uint index, int[] v)
            {
                fixed (int* v_ptr = v)
                {
                    ScissorIndexedv(index, v_ptr);
                }
            }
            /// <inheritdoc cref="ScissorIndexedv(uint, int*)"/>
            public static unsafe void ScissorIndexedv(uint index, in int v)
            {
                fixed (int* v_ptr = &v)
                {
                    ScissorIndexedv(index, v_ptr);
                }
            }
            /// <inheritdoc cref="DepthRangeArrayfv(uint, int, float*)"/>
            public static unsafe void DepthRangeArrayfv(uint first, int count, in float v)
            {
                fixed (float* v_ptr = &v)
                {
                    DepthRangeArrayfv(first, count, v_ptr);
                }
            }
            /// <inheritdoc cref="GetFloati_v(GetPName, uint, float*)"/>
            public static unsafe void GetFloati_v(GetPName target, uint index, Span<float> data)
            {
                fixed (float* data_ptr = data)
                {
                    GetFloati_v(target, index, data_ptr);
                }
            }
            /// <inheritdoc cref="GetFloati_v(GetPName, uint, float*)"/>
            public static unsafe void GetFloati_v(GetPName target, uint index, float[] data)
            {
                fixed (float* data_ptr = data)
                {
                    GetFloati_v(target, index, data_ptr);
                }
            }
            /// <inheritdoc cref="GetFloati_v(GetPName, uint, float*)"/>
            public static unsafe void GetFloati_v(GetPName target, uint index, ref float data)
            {
                fixed (float* data_ptr = &data)
                {
                    GetFloati_v(target, index, data_ptr);
                }
            }
        }
        public static unsafe partial class IMG
        {
            /// <inheritdoc cref="UniformHandleui64v(int, int, ulong*)"/>
            public static unsafe void UniformHandleui64v(int location, ReadOnlySpan<ulong> value)
            {
                int count = (int)(value.Length);
                fixed (ulong* value_ptr = value)
                {
                    UniformHandleui64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformHandleui64v(int, int, ulong*)"/>
            public static unsafe void UniformHandleui64v(int location, ulong[] value)
            {
                int count = (int)(value.Length);
                fixed (ulong* value_ptr = value)
                {
                    UniformHandleui64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformHandleui64v(int, int, ulong*)"/>
            public static unsafe void UniformHandleui64v(int location, int count, in ulong value)
            {
                fixed (ulong* value_ptr = &value)
                {
                    UniformHandleui64v(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformHandleui64v(int, int, int, ulong*)"/>
            public static unsafe void ProgramUniformHandleui64v(int program, int location, ReadOnlySpan<ulong> values)
            {
                int count = (int)(values.Length);
                fixed (ulong* values_ptr = values)
                {
                    ProgramUniformHandleui64v(program, location, count, values_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformHandleui64v(int, int, int, ulong*)"/>
            public static unsafe void ProgramUniformHandleui64v(int program, int location, ulong[] values)
            {
                int count = (int)(values.Length);
                fixed (ulong* values_ptr = values)
                {
                    ProgramUniformHandleui64v(program, location, count, values_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformHandleui64v(int, int, int, ulong*)"/>
            public static unsafe void ProgramUniformHandleui64v(int program, int location, int count, in ulong values)
            {
                fixed (ulong* values_ptr = &values)
                {
                    ProgramUniformHandleui64v(program, location, count, values_ptr);
                }
            }
        }
        public static unsafe partial class INTEL
        {
            /// <inheritdoc cref="CreatePerfQuery(uint, uint*)"/>
            public static unsafe void CreatePerfQuery(uint queryId, ref uint queryHandle)
            {
                fixed (uint* queryHandle_ptr = &queryHandle)
                {
                    CreatePerfQuery(queryId, queryHandle_ptr);
                }
            }
            /// <inheritdoc cref="GetFirstPerfQueryId(uint*)"/>
            public static unsafe void GetFirstPerfQueryId(ref uint queryId)
            {
                fixed (uint* queryId_ptr = &queryId)
                {
                    GetFirstPerfQueryId(queryId_ptr);
                }
            }
            /// <inheritdoc cref="GetNextPerfQueryId(uint, uint*)"/>
            public static unsafe void GetNextPerfQueryId(uint queryId, ref uint nextQueryId)
            {
                fixed (uint* nextQueryId_ptr = &nextQueryId)
                {
                    GetNextPerfQueryId(queryId, nextQueryId_ptr);
                }
            }
            /// <inheritdoc cref="GetPerfCounterInfo(uint, uint, uint, byte*, uint, byte*, uint*, uint*, uint*, uint*, ulong*)"/>
            public static unsafe void GetPerfCounterInfo(uint queryId, uint counterId, uint counterNameLength, out string counterName, uint counterDescLength, out string counterDesc, ref uint counterOffset, ref uint counterDataSize, ref uint counterTypeEnum, ref uint counterDataTypeEnum, ref ulong rawCounterMaxValue)
            {
                fixed (uint* counterOffset_ptr = &counterOffset)
                fixed (uint* counterDataSize_ptr = &counterDataSize)
                fixed (uint* counterTypeEnum_ptr = &counterTypeEnum)
                fixed (uint* counterDataTypeEnum_ptr = &counterDataTypeEnum)
                fixed (ulong* rawCounterMaxValue_ptr = &rawCounterMaxValue)
                {
                    var counterName_ptr = (byte*)Marshal.AllocCoTaskMem((int)counterNameLength);
                    var counterDesc_ptr = (byte*)Marshal.AllocCoTaskMem((int)counterDescLength);
                    GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName_ptr, counterDescLength, counterDesc_ptr, counterOffset_ptr, counterDataSize_ptr, counterTypeEnum_ptr, counterDataTypeEnum_ptr, rawCounterMaxValue_ptr);
                    counterDesc = Marshal.PtrToStringUTF8((IntPtr)counterDesc_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)counterDesc_ptr);
                    counterName = Marshal.PtrToStringUTF8((IntPtr)counterName_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)counterName_ptr);
                }
            }
            /// <inheritdoc cref="GetPerfQueryData(uint, uint, int, void*, uint*)"/>
            public static unsafe void GetPerfQueryData(uint queryHandle, uint flags, int dataSize, IntPtr data, ref uint bytesWritten)
            {
                fixed (uint* bytesWritten_ptr = &bytesWritten)
                {
                    void* data_vptr = (void*)data;
                    GetPerfQueryData(queryHandle, flags, dataSize, data_vptr, bytesWritten_ptr);
                }
            }
            /// <inheritdoc cref="GetPerfQueryData(uint, uint, int, void*, uint*)"/>
            public static unsafe void GetPerfQueryData<T1>(uint queryHandle, uint flags, int dataSize, ref T1 data, ref uint bytesWritten)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                fixed (uint* bytesWritten_ptr = &bytesWritten)
                {
                    GetPerfQueryData(queryHandle, flags, dataSize, data_ptr, bytesWritten_ptr);
                }
            }
            /// <inheritdoc cref="GetPerfQueryIdByName(byte*, uint*)"/>
            public static unsafe void GetPerfQueryIdByName(byte* queryName, ref uint queryId)
            {
                fixed (uint* queryId_ptr = &queryId)
                {
                    GetPerfQueryIdByName(queryName, queryId_ptr);
                }
            }
            /// <inheritdoc cref="GetPerfQueryInfo(uint, uint, byte*, uint*, uint*, uint*, PerformanceQueryCapsMaskINTEL*)"/>
            public static unsafe string GetPerfQueryInfo(uint queryId, uint queryNameLength, ref uint dataSize, ref uint noCounters, ref uint noInstances, ref PerformanceQueryCapsMaskINTEL capsMask)
            {
                string queryName;
                fixed (uint* dataSize_ptr = &dataSize)
                fixed (uint* noCounters_ptr = &noCounters)
                fixed (uint* noInstances_ptr = &noInstances)
                fixed (PerformanceQueryCapsMaskINTEL* capsMask_ptr = &capsMask)
                {
                    var queryName_ptr = (byte*)Marshal.AllocCoTaskMem((int)queryNameLength);
                    GetPerfQueryInfo(queryId, queryNameLength, queryName_ptr, dataSize_ptr, noCounters_ptr, noInstances_ptr, capsMask_ptr);
                    queryName = Marshal.PtrToStringUTF8((IntPtr)queryName_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)queryName_ptr);
                }
                return queryName;
            }
            /// <inheritdoc cref="GetPerfQueryInfo(uint, uint, byte*, uint*, uint*, uint*, PerformanceQueryCapsMaskINTEL*)"/>
            public static unsafe void GetPerfQueryInfo(uint queryId, uint queryNameLength, out string queryName, ref uint dataSize, ref uint noCounters, ref uint noInstances, ref PerformanceQueryCapsMaskINTEL capsMask)
            {
                fixed (uint* dataSize_ptr = &dataSize)
                fixed (uint* noCounters_ptr = &noCounters)
                fixed (uint* noInstances_ptr = &noInstances)
                fixed (PerformanceQueryCapsMaskINTEL* capsMask_ptr = &capsMask)
                {
                    var queryName_ptr = (byte*)Marshal.AllocCoTaskMem((int)queryNameLength);
                    GetPerfQueryInfo(queryId, queryNameLength, queryName_ptr, dataSize_ptr, noCounters_ptr, noInstances_ptr, capsMask_ptr);
                    queryName = Marshal.PtrToStringUTF8((IntPtr)queryName_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)queryName_ptr);
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
            public static unsafe void GetnUniformf(int program, int location, Span<float> parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (float* parameters_ptr = parameters)
                {
                    GetnUniformfv(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformfv(int, int, int, float*)"/>
            public static unsafe void GetnUniformf(int program, int location, float[] parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (float* parameters_ptr = parameters)
                {
                    GetnUniformfv(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformfv(int, int, int, float*)"/>
            public static unsafe void GetnUniformf(int program, int location, int bufSize, ref float parameters)
            {
                fixed (float* parameters_ptr = &parameters)
                {
                    GetnUniformfv(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformiv(int, int, int, int*)"/>
            public static unsafe void GetnUniformi(int program, int location, Span<int> parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (int* parameters_ptr = parameters)
                {
                    GetnUniformiv(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformiv(int, int, int, int*)"/>
            public static unsafe void GetnUniformi(int program, int location, int[] parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (int* parameters_ptr = parameters)
                {
                    GetnUniformiv(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformiv(int, int, int, int*)"/>
            public static unsafe void GetnUniformi(int program, int location, int bufSize, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetnUniformiv(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformuiv(int, int, int, uint*)"/>
            public static unsafe void GetnUniformui(int program, int location, Span<uint> parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (uint* parameters_ptr = parameters)
                {
                    GetnUniformuiv(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformuiv(int, int, int, uint*)"/>
            public static unsafe void GetnUniformui(int program, int location, uint[] parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (uint* parameters_ptr = parameters)
                {
                    GetnUniformuiv(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformuiv(int, int, int, uint*)"/>
            public static unsafe void GetnUniformui(int program, int location, int bufSize, ref uint parameters)
            {
                fixed (uint* parameters_ptr = &parameters)
                {
                    GetnUniformuiv(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="ReadnPixelsKHR(int, int, int, int, PixelFormat, PixelType, int, void*)"/>
            public static unsafe void ReadnPixelsKHR(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, IntPtr data)
            {
                void* data_vptr = (void*)data;
                ReadnPixelsKHR(x, y, width, height, format, type, bufSize, data_vptr);
            }
            /// <inheritdoc cref="ReadnPixelsKHR(int, int, int, int, PixelFormat, PixelType, int, void*)"/>
            public static unsafe void ReadnPixelsKHR<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, Span<T1> data)
                where T1 : unmanaged
            {
                int bufSize = (int)(data.Length * sizeof(T1));
                fixed (void* data_ptr = data)
                {
                    ReadnPixelsKHR(x, y, width, height, format, type, bufSize, data_ptr);
                }
            }
            /// <inheritdoc cref="ReadnPixelsKHR(int, int, int, int, PixelFormat, PixelType, int, void*)"/>
            public static unsafe void ReadnPixelsKHR<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, T1[] data)
                where T1 : unmanaged
            {
                int bufSize = (int)(data.Length * sizeof(T1));
                fixed (void* data_ptr = data)
                {
                    ReadnPixelsKHR(x, y, width, height, format, type, bufSize, data_ptr);
                }
            }
            /// <inheritdoc cref="ReadnPixelsKHR(int, int, int, int, PixelFormat, PixelType, int, void*)"/>
            public static unsafe void ReadnPixelsKHR<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, ref T1 data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    ReadnPixelsKHR(x, y, width, height, format, type, bufSize, data_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformfvKHR(int, int, int, float*)"/>
            public static unsafe void GetnUniformfvKHR(int program, int location, Span<float> parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (float* parameters_ptr = parameters)
                {
                    GetnUniformfvKHR(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformfvKHR(int, int, int, float*)"/>
            public static unsafe void GetnUniformfvKHR(int program, int location, float[] parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (float* parameters_ptr = parameters)
                {
                    GetnUniformfvKHR(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformfvKHR(int, int, int, float*)"/>
            public static unsafe void GetnUniformfvKHR(int program, int location, int bufSize, ref float parameters)
            {
                fixed (float* parameters_ptr = &parameters)
                {
                    GetnUniformfvKHR(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformivKHR(int, int, int, int*)"/>
            public static unsafe void GetnUniformivKHR(int program, int location, Span<int> parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (int* parameters_ptr = parameters)
                {
                    GetnUniformivKHR(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformivKHR(int, int, int, int*)"/>
            public static unsafe void GetnUniformivKHR(int program, int location, int[] parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (int* parameters_ptr = parameters)
                {
                    GetnUniformivKHR(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformivKHR(int, int, int, int*)"/>
            public static unsafe void GetnUniformivKHR(int program, int location, int bufSize, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetnUniformivKHR(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformuivKHR(int, int, int, uint*)"/>
            public static unsafe void GetnUniformuivKHR(int program, int location, Span<uint> parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (uint* parameters_ptr = parameters)
                {
                    GetnUniformuivKHR(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformuivKHR(int, int, int, uint*)"/>
            public static unsafe void GetnUniformuivKHR(int program, int location, uint[] parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (uint* parameters_ptr = parameters)
                {
                    GetnUniformuivKHR(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformuivKHR(int, int, int, uint*)"/>
            public static unsafe void GetnUniformuivKHR(int program, int location, int bufSize, ref uint parameters)
            {
                fixed (uint* parameters_ptr = &parameters)
                {
                    GetnUniformuivKHR(program, location, bufSize, parameters_ptr);
                }
            }
        }
        public static unsafe partial class MESA
        {
            /// <inheritdoc cref="GetFramebufferParameteriv(FramebufferTarget, FramebufferAttachmentParameterName, int*)"/>
            public static unsafe void GetFramebufferParameteriv(FramebufferTarget target, FramebufferAttachmentParameterName pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetFramebufferParameteriv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetFramebufferParameteriv(FramebufferTarget, FramebufferAttachmentParameterName, int*)"/>
            public static unsafe void GetFramebufferParameteriv(FramebufferTarget target, FramebufferAttachmentParameterName pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetFramebufferParameteriv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetFramebufferParameteriv(FramebufferTarget, FramebufferAttachmentParameterName, int*)"/>
            public static unsafe void GetFramebufferParameteriv(FramebufferTarget target, FramebufferAttachmentParameterName pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetFramebufferParameteriv(target, pname, parameters_ptr);
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
            /// <inheritdoc cref="DrawElementsBaseVertex(PrimitiveType, int, DrawElementsType, void*, int)"/>
            public static unsafe void DrawElementsBaseVertex(PrimitiveType mode, int count, DrawElementsType type, nint offset, int basevertex)
            {
                void* indices = (void*)offset;
                DrawElementsBaseVertex(mode, count, type, indices, basevertex);
            }
            /// <inheritdoc cref="DrawRangeElementsBaseVertex(PrimitiveType, uint, uint, int, DrawElementsType, void*, int)"/>
            public static unsafe void DrawRangeElementsBaseVertex(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, nint offset, int basevertex)
            {
                void* indices = (void*)offset;
                DrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
            }
            /// <inheritdoc cref="DrawElementsInstancedBaseVertex(PrimitiveType, int, DrawElementsType, void*, int, int)"/>
            public static unsafe void DrawElementsInstancedBaseVertex(PrimitiveType mode, int count, DrawElementsType type, nint offset, int instancecount, int basevertex)
            {
                void* indices = (void*)offset;
                DrawElementsInstancedBaseVertex(mode, count, type, indices, instancecount, basevertex);
            }
            /// <inheritdoc cref="MultiDrawElementsBaseVertexEXT(PrimitiveType, int*, DrawElementsType, void**, int, int*)"/>
            public static unsafe void MultiDrawElementsBaseVertexEXT(PrimitiveType mode, ReadOnlySpan<int> count, DrawElementsType type, void** indices, int drawcount, ReadOnlySpan<int> basevertex)
            {
                fixed (int* count_ptr = count)
                {
                    fixed (int* basevertex_ptr = basevertex)
                    {
                        MultiDrawElementsBaseVertexEXT(mode, count_ptr, type, indices, drawcount, basevertex_ptr);
                    }
                }
            }
            /// <inheritdoc cref="MultiDrawElementsBaseVertexEXT(PrimitiveType, int*, DrawElementsType, void**, int, int*)"/>
            public static unsafe void MultiDrawElementsBaseVertexEXT(PrimitiveType mode, int[] count, DrawElementsType type, void** indices, int drawcount, int[] basevertex)
            {
                fixed (int* count_ptr = count)
                {
                    fixed (int* basevertex_ptr = basevertex)
                    {
                        MultiDrawElementsBaseVertexEXT(mode, count_ptr, type, indices, drawcount, basevertex_ptr);
                    }
                }
            }
            /// <inheritdoc cref="MultiDrawElementsBaseVertexEXT(PrimitiveType, int*, DrawElementsType, void**, int, int*)"/>
            public static unsafe void MultiDrawElementsBaseVertexEXT(PrimitiveType mode, in int count, DrawElementsType type, void** indices, int drawcount, in int basevertex)
            {
                fixed (int* count_ptr = &count)
                fixed (int* basevertex_ptr = &basevertex)
                {
                    MultiDrawElementsBaseVertexEXT(mode, count_ptr, type, indices, drawcount, basevertex_ptr);
                }
            }
            /// <inheritdoc cref="GetProgramBinary(int, int, int*, All*, void*)"/>
            public static unsafe void GetProgramBinary(int program, int bufSize, Span<int> length, Span<All> binaryFormat, IntPtr binary)
            {
                fixed (int* length_ptr = length)
                {
                    fixed (All* binaryFormat_ptr = binaryFormat)
                    {
                        void* binary_vptr = (void*)binary;
                        GetProgramBinary(program, bufSize, length_ptr, binaryFormat_ptr, binary_vptr);
                    }
                }
            }
            /// <inheritdoc cref="GetProgramBinary(int, int, int*, All*, void*)"/>
            public static unsafe void GetProgramBinary(int program, int bufSize, int[] length, All[] binaryFormat, IntPtr binary)
            {
                fixed (int* length_ptr = length)
                {
                    fixed (All* binaryFormat_ptr = binaryFormat)
                    {
                        void* binary_vptr = (void*)binary;
                        GetProgramBinary(program, bufSize, length_ptr, binaryFormat_ptr, binary_vptr);
                    }
                }
            }
            /// <inheritdoc cref="GetProgramBinary(int, int, int*, All*, void*)"/>
            public static unsafe void GetProgramBinary(int program, int bufSize, ref int length, ref All binaryFormat, IntPtr binary)
            {
                fixed (int* length_ptr = &length)
                fixed (All* binaryFormat_ptr = &binaryFormat)
                {
                    void* binary_vptr = (void*)binary;
                    GetProgramBinary(program, bufSize, length_ptr, binaryFormat_ptr, binary_vptr);
                }
            }
            /// <inheritdoc cref="GetProgramBinary(int, int, int*, All*, void*)"/>
            public static unsafe void GetProgramBinary<T1>(int program, Span<int> length, Span<All> binaryFormat, Span<T1> binary)
                where T1 : unmanaged
            {
                fixed (int* length_ptr = length)
                {
                    fixed (All* binaryFormat_ptr = binaryFormat)
                    {
                        int bufSize = (int)(binary.Length * sizeof(T1));
                        fixed (void* binary_ptr = binary)
                        {
                            GetProgramBinary(program, bufSize, length_ptr, binaryFormat_ptr, binary_ptr);
                        }
                    }
                }
            }
            /// <inheritdoc cref="GetProgramBinary(int, int, int*, All*, void*)"/>
            public static unsafe void GetProgramBinary<T1>(int program, int[] length, All[] binaryFormat, T1[] binary)
                where T1 : unmanaged
            {
                fixed (int* length_ptr = length)
                {
                    fixed (All* binaryFormat_ptr = binaryFormat)
                    {
                        int bufSize = (int)(binary.Length * sizeof(T1));
                        fixed (void* binary_ptr = binary)
                        {
                            GetProgramBinary(program, bufSize, length_ptr, binaryFormat_ptr, binary_ptr);
                        }
                    }
                }
            }
            /// <inheritdoc cref="GetProgramBinary(int, int, int*, All*, void*)"/>
            public static unsafe void GetProgramBinary<T1>(int program, int bufSize, ref int length, ref All binaryFormat, ref T1 binary)
                where T1 : unmanaged
            {
                fixed (int* length_ptr = &length)
                fixed (All* binaryFormat_ptr = &binaryFormat)
                fixed (void* binary_ptr = &binary)
                {
                    GetProgramBinary(program, bufSize, length_ptr, binaryFormat_ptr, binary_ptr);
                }
            }
            /// <inheritdoc cref="ProgramBinary(int, All, void*, int)"/>
            public static unsafe void ProgramBinary(int program, All binaryFormat, IntPtr binary, int length)
            {
                void* binary_vptr = (void*)binary;
                ProgramBinary(program, binaryFormat, binary_vptr, length);
            }
            /// <inheritdoc cref="ProgramBinary(int, All, void*, int)"/>
            public static unsafe void ProgramBinary<T1>(int program, All binaryFormat, ReadOnlySpan<T1> binary)
                where T1 : unmanaged
            {
                int length = (int)(binary.Length * sizeof(T1));
                fixed (void* binary_ptr = binary)
                {
                    ProgramBinary(program, binaryFormat, binary_ptr, length);
                }
            }
            /// <inheritdoc cref="ProgramBinary(int, All, void*, int)"/>
            public static unsafe void ProgramBinary<T1>(int program, All binaryFormat, T1[] binary)
                where T1 : unmanaged
            {
                int length = (int)(binary.Length * sizeof(T1));
                fixed (void* binary_ptr = binary)
                {
                    ProgramBinary(program, binaryFormat, binary_ptr, length);
                }
            }
            /// <inheritdoc cref="ProgramBinary(int, All, void*, int)"/>
            public static unsafe void ProgramBinary<T1>(int program, All binaryFormat, in T1 binary, int length)
                where T1 : unmanaged
            {
                fixed (void* binary_ptr = &binary)
                {
                    ProgramBinary(program, binaryFormat, binary_ptr, length);
                }
            }
            /// <inheritdoc cref="TexImage3D(TextureTarget, int, InternalFormat, int, int, int, int, PixelFormat, PixelType, void*)"/>
            public static unsafe void TexImage3D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, IntPtr pixels)
            {
                void* pixels_vptr = (void*)pixels;
                TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels_vptr);
            }
            /// <inheritdoc cref="TexImage3D(TextureTarget, int, InternalFormat, int, int, int, int, PixelFormat, PixelType, void*)"/>
            public static unsafe void TexImage3D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, ReadOnlySpan<T1> pixels)
                where T1 : unmanaged
            {
                fixed (void* pixels_ptr = pixels)
                {
                    TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels_ptr);
                }
            }
            /// <inheritdoc cref="TexImage3D(TextureTarget, int, InternalFormat, int, int, int, int, PixelFormat, PixelType, void*)"/>
            public static unsafe void TexImage3D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, T1[] pixels)
                where T1 : unmanaged
            {
                fixed (void* pixels_ptr = pixels)
                {
                    TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels_ptr);
                }
            }
            /// <inheritdoc cref="TexImage3D(TextureTarget, int, InternalFormat, int, int, int, int, PixelFormat, PixelType, void*)"/>
            public static unsafe void TexImage3D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, in T1 pixels)
                where T1 : unmanaged
            {
                fixed (void* pixels_ptr = &pixels)
                {
                    TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels_ptr);
                }
            }
            /// <inheritdoc cref="TexSubImage3D(TextureTarget, int, int, int, int, int, int, int, PixelFormat, PixelType, void*)"/>
            public static unsafe void TexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels)
            {
                void* pixels_vptr = (void*)pixels;
                TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels_vptr);
            }
            /// <inheritdoc cref="TexSubImage3D(TextureTarget, int, int, int, int, int, int, int, PixelFormat, PixelType, void*)"/>
            public static unsafe void TexSubImage3D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, ReadOnlySpan<T1> pixels)
                where T1 : unmanaged
            {
                fixed (void* pixels_ptr = pixels)
                {
                    TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels_ptr);
                }
            }
            /// <inheritdoc cref="TexSubImage3D(TextureTarget, int, int, int, int, int, int, int, PixelFormat, PixelType, void*)"/>
            public static unsafe void TexSubImage3D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, T1[] pixels)
                where T1 : unmanaged
            {
                fixed (void* pixels_ptr = pixels)
                {
                    TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels_ptr);
                }
            }
            /// <inheritdoc cref="TexSubImage3D(TextureTarget, int, int, int, int, int, int, int, PixelFormat, PixelType, void*)"/>
            public static unsafe void TexSubImage3D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, in T1 pixels)
                where T1 : unmanaged
            {
                fixed (void* pixels_ptr = &pixels)
                {
                    TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels_ptr);
                }
            }
            /// <inheritdoc cref="CompressedTexImage3D(TextureTarget, int, InternalFormat, int, int, int, int, int, void*)"/>
            public static unsafe void CompressedTexImage3D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data)
            {
                void* data_vptr = (void*)data;
                CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data_vptr);
            }
            /// <inheritdoc cref="CompressedTexImage3D(TextureTarget, int, InternalFormat, int, int, int, int, int, void*)"/>
            public static unsafe void CompressedTexImage3D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, ReadOnlySpan<T1> data)
                where T1 : unmanaged
            {
                int imageSize = (int)(data.Length * sizeof(T1));
                fixed (void* data_ptr = data)
                {
                    CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data_ptr);
                }
            }
            /// <inheritdoc cref="CompressedTexImage3D(TextureTarget, int, InternalFormat, int, int, int, int, int, void*)"/>
            public static unsafe void CompressedTexImage3D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, T1[] data)
                where T1 : unmanaged
            {
                int imageSize = (int)(data.Length * sizeof(T1));
                fixed (void* data_ptr = data)
                {
                    CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data_ptr);
                }
            }
            /// <inheritdoc cref="CompressedTexImage3D(TextureTarget, int, InternalFormat, int, int, int, int, int, void*)"/>
            public static unsafe void CompressedTexImage3D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, in T1 data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data_ptr);
                }
            }
            /// <inheritdoc cref="CompressedTexSubImage3D(TextureTarget, int, int, int, int, int, int, int, InternalFormat, int, void*)"/>
            public static unsafe void CompressedTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, InternalFormat format, int imageSize, IntPtr data)
            {
                void* data_vptr = (void*)data;
                CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data_vptr);
            }
            /// <inheritdoc cref="CompressedTexSubImage3D(TextureTarget, int, int, int, int, int, int, int, InternalFormat, int, void*)"/>
            public static unsafe void CompressedTexSubImage3D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, InternalFormat format, ReadOnlySpan<T1> data)
                where T1 : unmanaged
            {
                int imageSize = (int)(data.Length * sizeof(T1));
                fixed (void* data_ptr = data)
                {
                    CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data_ptr);
                }
            }
            /// <inheritdoc cref="CompressedTexSubImage3D(TextureTarget, int, int, int, int, int, int, int, InternalFormat, int, void*)"/>
            public static unsafe void CompressedTexSubImage3D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, InternalFormat format, T1[] data)
                where T1 : unmanaged
            {
                int imageSize = (int)(data.Length * sizeof(T1));
                fixed (void* data_ptr = data)
                {
                    CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data_ptr);
                }
            }
            /// <inheritdoc cref="CompressedTexSubImage3D(TextureTarget, int, int, int, int, int, int, int, InternalFormat, int, void*)"/>
            public static unsafe void CompressedTexSubImage3D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, InternalFormat format, int imageSize, in T1 data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data_ptr);
                }
            }
            /// <inheritdoc cref="TexParameterIiv(TextureTarget, TextureParameterName, int*)"/>
            public static unsafe void TexParameterIiv(TextureTarget target, TextureParameterName pname, ReadOnlySpan<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    TexParameterIiv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexParameterIiv(TextureTarget, TextureParameterName, int*)"/>
            public static unsafe void TexParameterIiv(TextureTarget target, TextureParameterName pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    TexParameterIiv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexParameterIiv(TextureTarget, TextureParameterName, int*)"/>
            public static unsafe void TexParameterIiv(TextureTarget target, TextureParameterName pname, in int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    TexParameterIiv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexParameterIuiv(TextureTarget, TextureParameterName, uint*)"/>
            public static unsafe void TexParameterIuiv(TextureTarget target, TextureParameterName pname, ReadOnlySpan<uint> parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    TexParameterIuiv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexParameterIuiv(TextureTarget, TextureParameterName, uint*)"/>
            public static unsafe void TexParameterIuiv(TextureTarget target, TextureParameterName pname, uint[] parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    TexParameterIuiv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexParameterIuiv(TextureTarget, TextureParameterName, uint*)"/>
            public static unsafe void TexParameterIuiv(TextureTarget target, TextureParameterName pname, in uint parameters)
            {
                fixed (uint* parameters_ptr = &parameters)
                {
                    TexParameterIuiv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexParameterIiv(TextureTarget, GetTextureParameter, int*)"/>
            public static unsafe void GetTexParameterIiv(TextureTarget target, GetTextureParameter pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexParameterIiv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexParameterIiv(TextureTarget, GetTextureParameter, int*)"/>
            public static unsafe void GetTexParameterIiv(TextureTarget target, GetTextureParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexParameterIiv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexParameterIiv(TextureTarget, GetTextureParameter, int*)"/>
            public static unsafe void GetTexParameterIiv(TextureTarget target, GetTextureParameter pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetTexParameterIiv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexParameterIuiv(TextureTarget, GetTextureParameter, uint*)"/>
            public static unsafe void GetTexParameterIuiv(TextureTarget target, GetTextureParameter pname, Span<uint> parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    GetTexParameterIuiv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexParameterIuiv(TextureTarget, GetTextureParameter, uint*)"/>
            public static unsafe void GetTexParameterIuiv(TextureTarget target, GetTextureParameter pname, uint[] parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    GetTexParameterIuiv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexParameterIuiv(TextureTarget, GetTextureParameter, uint*)"/>
            public static unsafe void GetTexParameterIuiv(TextureTarget target, GetTextureParameter pname, ref uint parameters)
            {
                fixed (uint* parameters_ptr = &parameters)
                {
                    GetTexParameterIuiv(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="SamplerParameterIiv(int, SamplerParameterI, int*)"/>
            public static unsafe void SamplerParameterIiv(int sampler, SamplerParameterI pname, ReadOnlySpan<int> param)
            {
                fixed (int* param_ptr = param)
                {
                    SamplerParameterIiv(sampler, pname, param_ptr);
                }
            }
            /// <inheritdoc cref="SamplerParameterIiv(int, SamplerParameterI, int*)"/>
            public static unsafe void SamplerParameterIiv(int sampler, SamplerParameterI pname, int[] param)
            {
                fixed (int* param_ptr = param)
                {
                    SamplerParameterIiv(sampler, pname, param_ptr);
                }
            }
            /// <inheritdoc cref="SamplerParameterIiv(int, SamplerParameterI, int*)"/>
            public static unsafe void SamplerParameterIiv(int sampler, SamplerParameterI pname, in int param)
            {
                fixed (int* param_ptr = &param)
                {
                    SamplerParameterIiv(sampler, pname, param_ptr);
                }
            }
            /// <inheritdoc cref="SamplerParameterIuiv(int, SamplerParameterI, uint*)"/>
            public static unsafe void SamplerParameterIuiv(int sampler, SamplerParameterI pname, ReadOnlySpan<uint> param)
            {
                fixed (uint* param_ptr = param)
                {
                    SamplerParameterIuiv(sampler, pname, param_ptr);
                }
            }
            /// <inheritdoc cref="SamplerParameterIuiv(int, SamplerParameterI, uint*)"/>
            public static unsafe void SamplerParameterIuiv(int sampler, SamplerParameterI pname, uint[] param)
            {
                fixed (uint* param_ptr = param)
                {
                    SamplerParameterIuiv(sampler, pname, param_ptr);
                }
            }
            /// <inheritdoc cref="SamplerParameterIuiv(int, SamplerParameterI, uint*)"/>
            public static unsafe void SamplerParameterIuiv(int sampler, SamplerParameterI pname, in uint param)
            {
                fixed (uint* param_ptr = &param)
                {
                    SamplerParameterIuiv(sampler, pname, param_ptr);
                }
            }
            /// <inheritdoc cref="GetSamplerParameterIiv(int, SamplerParameterI, int*)"/>
            public static unsafe void GetSamplerParameterIiv(int sampler, SamplerParameterI pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetSamplerParameterIiv(sampler, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetSamplerParameterIiv(int, SamplerParameterI, int*)"/>
            public static unsafe void GetSamplerParameterIiv(int sampler, SamplerParameterI pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetSamplerParameterIiv(sampler, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetSamplerParameterIiv(int, SamplerParameterI, int*)"/>
            public static unsafe void GetSamplerParameterIiv(int sampler, SamplerParameterI pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetSamplerParameterIiv(sampler, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetSamplerParameterIuiv(int, SamplerParameterI, uint*)"/>
            public static unsafe void GetSamplerParameterIuiv(int sampler, SamplerParameterI pname, Span<uint> parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    GetSamplerParameterIuiv(sampler, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetSamplerParameterIuiv(int, SamplerParameterI, uint*)"/>
            public static unsafe void GetSamplerParameterIuiv(int sampler, SamplerParameterI pname, uint[] parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    GetSamplerParameterIuiv(sampler, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetSamplerParameterIuiv(int, SamplerParameterI, uint*)"/>
            public static unsafe void GetSamplerParameterIuiv(int sampler, SamplerParameterI pname, ref uint parameters)
            {
                fixed (uint* parameters_ptr = &parameters)
                {
                    GetSamplerParameterIuiv(sampler, pname, parameters_ptr);
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
            /// <inheritdoc cref="ViewportArrayv(uint, int, float*)"/>
            public static unsafe void ViewportArrayv(uint first, int count, ReadOnlySpan<float> v)
            {
                fixed (float* v_ptr = v)
                {
                    ViewportArrayv(first, count, v_ptr);
                }
            }
            /// <inheritdoc cref="ViewportArrayv(uint, int, float*)"/>
            public static unsafe void ViewportArrayv(uint first, int count, float[] v)
            {
                fixed (float* v_ptr = v)
                {
                    ViewportArrayv(first, count, v_ptr);
                }
            }
            /// <inheritdoc cref="ViewportArrayv(uint, int, float*)"/>
            public static unsafe void ViewportArrayv(uint first, int count, in float v)
            {
                fixed (float* v_ptr = &v)
                {
                    ViewportArrayv(first, count, v_ptr);
                }
            }
            /// <inheritdoc cref="ViewportIndexedfv(uint, float*)"/>
            public static unsafe void ViewportIndexedfv(uint index, ReadOnlySpan<float> v)
            {
                fixed (float* v_ptr = v)
                {
                    ViewportIndexedfv(index, v_ptr);
                }
            }
            /// <inheritdoc cref="ViewportIndexedfv(uint, float*)"/>
            public static unsafe void ViewportIndexedfv(uint index, float[] v)
            {
                fixed (float* v_ptr = v)
                {
                    ViewportIndexedfv(index, v_ptr);
                }
            }
            /// <inheritdoc cref="ViewportIndexedfv(uint, float*)"/>
            public static unsafe void ViewportIndexedfv(uint index, in float v)
            {
                fixed (float* v_ptr = &v)
                {
                    ViewportIndexedfv(index, v_ptr);
                }
            }
            /// <inheritdoc cref="ScissorArrayv(uint, int, int*)"/>
            public static unsafe void ScissorArrayv(uint first, int count, ReadOnlySpan<int> v)
            {
                fixed (int* v_ptr = v)
                {
                    ScissorArrayv(first, count, v_ptr);
                }
            }
            /// <inheritdoc cref="ScissorArrayv(uint, int, int*)"/>
            public static unsafe void ScissorArrayv(uint first, int count, int[] v)
            {
                fixed (int* v_ptr = v)
                {
                    ScissorArrayv(first, count, v_ptr);
                }
            }
            /// <inheritdoc cref="ScissorArrayv(uint, int, int*)"/>
            public static unsafe void ScissorArrayv(uint first, int count, in int v)
            {
                fixed (int* v_ptr = &v)
                {
                    ScissorArrayv(first, count, v_ptr);
                }
            }
            /// <inheritdoc cref="ScissorIndexedv(uint, int*)"/>
            public static unsafe void ScissorIndexedv(uint index, ReadOnlySpan<int> v)
            {
                fixed (int* v_ptr = v)
                {
                    ScissorIndexedv(index, v_ptr);
                }
            }
            /// <inheritdoc cref="ScissorIndexedv(uint, int*)"/>
            public static unsafe void ScissorIndexedv(uint index, int[] v)
            {
                fixed (int* v_ptr = v)
                {
                    ScissorIndexedv(index, v_ptr);
                }
            }
            /// <inheritdoc cref="ScissorIndexedv(uint, int*)"/>
            public static unsafe void ScissorIndexedv(uint index, in int v)
            {
                fixed (int* v_ptr = &v)
                {
                    ScissorIndexedv(index, v_ptr);
                }
            }
            /// <inheritdoc cref="DepthRangeArrayfv(uint, int, float*)"/>
            public static unsafe void DepthRangeArrayfv(uint first, int count, in float v)
            {
                fixed (float* v_ptr = &v)
                {
                    DepthRangeArrayfv(first, count, v_ptr);
                }
            }
            /// <inheritdoc cref="GetFloati_v(GetPName, uint, float*)"/>
            public static unsafe void GetFloati_v(GetPName target, uint index, Span<float> data)
            {
                fixed (float* data_ptr = data)
                {
                    GetFloati_v(target, index, data_ptr);
                }
            }
            /// <inheritdoc cref="GetFloati_v(GetPName, uint, float*)"/>
            public static unsafe void GetFloati_v(GetPName target, uint index, float[] data)
            {
                fixed (float* data_ptr = data)
                {
                    GetFloati_v(target, index, data_ptr);
                }
            }
            /// <inheritdoc cref="GetFloati_v(GetPName, uint, float*)"/>
            public static unsafe void GetFloati_v(GetPName target, uint index, ref float data)
            {
                fixed (float* data_ptr = &data)
                {
                    GetFloati_v(target, index, data_ptr);
                }
            }
        }
        public static unsafe partial class OVR
        {
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
            /// <inheritdoc cref="FramebufferFoveationConfig(int, uint, uint, uint, uint*)"/>
            public static unsafe void FramebufferFoveationConfig(int framebuffer, uint numLayers, uint focalPointsPerLayer, uint requestedFeatures, Span<uint> providedFeatures)
            {
                fixed (uint* providedFeatures_ptr = providedFeatures)
                {
                    FramebufferFoveationConfig(framebuffer, numLayers, focalPointsPerLayer, requestedFeatures, providedFeatures_ptr);
                }
            }
            /// <inheritdoc cref="FramebufferFoveationConfig(int, uint, uint, uint, uint*)"/>
            public static unsafe void FramebufferFoveationConfig(int framebuffer, uint numLayers, uint focalPointsPerLayer, uint requestedFeatures, uint[] providedFeatures)
            {
                fixed (uint* providedFeatures_ptr = providedFeatures)
                {
                    FramebufferFoveationConfig(framebuffer, numLayers, focalPointsPerLayer, requestedFeatures, providedFeatures_ptr);
                }
            }
            /// <inheritdoc cref="FramebufferFoveationConfig(int, uint, uint, uint, uint*)"/>
            public static unsafe void FramebufferFoveationConfig(int framebuffer, uint numLayers, uint focalPointsPerLayer, uint requestedFeatures, ref uint providedFeatures)
            {
                fixed (uint* providedFeatures_ptr = &providedFeatures)
                {
                    FramebufferFoveationConfig(framebuffer, numLayers, focalPointsPerLayer, requestedFeatures, providedFeatures_ptr);
                }
            }
        }
    }
#pragma warning restore CS0419 // Ambiguous reference in cref attribute
}
