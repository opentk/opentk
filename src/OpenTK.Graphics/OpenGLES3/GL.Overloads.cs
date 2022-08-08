// This file is auto generated, do not edit.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using OpenTK.Mathematics;
using OpenTK.Graphics;

namespace OpenTK.Graphics.OpenGLES3
{
    public static unsafe partial class GL
    {
        /// <inheritdoc cref="BindAttribLocation"/>
        public static unsafe void BindAttribLocation(ProgramHandle program, uint index, string name)
        {
            byte* name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(name);
            BindAttribLocation(program, index, name_ptr);
            Marshal.FreeCoTaskMem((IntPtr)name_ptr);
        }
        /// <inheritdoc cref="BufferData"/>
        public static unsafe void BufferData(BufferTargetARB target, nint size, IntPtr data, BufferUsageARB usage)
        {
            void* data_vptr = (void*)data;
            BufferData(target, size, data_vptr, usage);
        }
        /// <inheritdoc cref="BufferData"/>
        public static unsafe void BufferData<T1>(BufferTargetARB target, ReadOnlySpan<T1> data, BufferUsageARB usage)
            where T1 : unmanaged
        {
            nint size = (nint)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                BufferData(target, size, data_ptr, usage);
            }
        }
        /// <inheritdoc cref="BufferData"/>
        public static unsafe void BufferData<T1>(BufferTargetARB target, T1[] data, BufferUsageARB usage)
            where T1 : unmanaged
        {
            nint size = (nint)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                BufferData(target, size, data_ptr, usage);
            }
        }
        /// <inheritdoc cref="BufferData"/>
        public static unsafe void BufferData<T1>(BufferTargetARB target, nint size, in T1 data, BufferUsageARB usage)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = &data)
            {
                BufferData(target, size, data_ptr, usage);
            }
        }
        /// <inheritdoc cref="BufferSubData"/>
        public static unsafe void BufferSubData(BufferTargetARB target, IntPtr offset, nint size, IntPtr data)
        {
            void* data_vptr = (void*)data;
            BufferSubData(target, offset, size, data_vptr);
        }
        /// <inheritdoc cref="BufferSubData"/>
        public static unsafe void BufferSubData<T1>(BufferTargetARB target, IntPtr offset, ReadOnlySpan<T1> data)
            where T1 : unmanaged
        {
            nint size = (nint)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                BufferSubData(target, offset, size, data_ptr);
            }
        }
        /// <inheritdoc cref="BufferSubData"/>
        public static unsafe void BufferSubData<T1>(BufferTargetARB target, IntPtr offset, T1[] data)
            where T1 : unmanaged
        {
            nint size = (nint)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                BufferSubData(target, offset, size, data_ptr);
            }
        }
        /// <inheritdoc cref="BufferSubData"/>
        public static unsafe void BufferSubData<T1>(BufferTargetARB target, IntPtr offset, nint size, in T1 data)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = &data)
            {
                BufferSubData(target, offset, size, data_ptr);
            }
        }
        /// <inheritdoc cref="CompressedTexImage2D"/>
        public static unsafe void CompressedTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, IntPtr data)
        {
            void* data_vptr = (void*)data;
            CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data_vptr);
        }
        /// <inheritdoc cref="CompressedTexImage2D"/>
        public static unsafe void CompressedTexImage2D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, ReadOnlySpan<T1> data)
            where T1 : unmanaged
        {
            int imageSize = (int)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data_ptr);
            }
        }
        /// <inheritdoc cref="CompressedTexImage2D"/>
        public static unsafe void CompressedTexImage2D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, T1[] data)
            where T1 : unmanaged
        {
            int imageSize = (int)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data_ptr);
            }
        }
        /// <inheritdoc cref="CompressedTexImage2D"/>
        public static unsafe void CompressedTexImage2D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, in T1 data)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = &data)
            {
                CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data_ptr);
            }
        }
        /// <inheritdoc cref="CompressedTexSubImage2D"/>
        public static unsafe void CompressedTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, InternalFormat format, int imageSize, IntPtr data)
        {
            void* data_vptr = (void*)data;
            CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data_vptr);
        }
        /// <inheritdoc cref="CompressedTexSubImage2D"/>
        public static unsafe void CompressedTexSubImage2D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, InternalFormat format, ReadOnlySpan<T1> data)
            where T1 : unmanaged
        {
            int imageSize = (int)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data_ptr);
            }
        }
        /// <inheritdoc cref="CompressedTexSubImage2D"/>
        public static unsafe void CompressedTexSubImage2D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, InternalFormat format, T1[] data)
            where T1 : unmanaged
        {
            int imageSize = (int)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data_ptr);
            }
        }
        /// <inheritdoc cref="CompressedTexSubImage2D"/>
        public static unsafe void CompressedTexSubImage2D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, InternalFormat format, int imageSize, in T1 data)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = &data)
            {
                CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data_ptr);
            }
        }
        /// <inheritdoc cref="DeleteBuffers"/>
        public static unsafe void DeleteBuffer(in BufferHandle buffer)
        {
            int n = 1;
            fixed(BufferHandle* buffers_handle = &buffer)
            {
                DeleteBuffers(n, buffers_handle);
            }
        }
        /// <inheritdoc cref="DeleteBuffers"/>
        public static unsafe void DeleteBuffers(ReadOnlySpan<BufferHandle> buffers)
        {
            int n = (int)(buffers.Length);
            fixed (BufferHandle* buffers_ptr = buffers)
            {
                DeleteBuffers(n, buffers_ptr);
            }
        }
        /// <inheritdoc cref="DeleteBuffers"/>
        public static unsafe void DeleteBuffers(BufferHandle[] buffers)
        {
            int n = (int)(buffers.Length);
            fixed (BufferHandle* buffers_ptr = buffers)
            {
                DeleteBuffers(n, buffers_ptr);
            }
        }
        /// <inheritdoc cref="DeleteBuffers"/>
        public static unsafe void DeleteBuffers(int n, in BufferHandle buffers)
        {
            fixed (BufferHandle* buffers_ptr = &buffers)
            {
                DeleteBuffers(n, buffers_ptr);
            }
        }
        /// <inheritdoc cref="DeleteFramebuffers"/>
        public static unsafe void DeleteFramebuffer(in FramebufferHandle framebuffer)
        {
            int n = 1;
            fixed(FramebufferHandle* framebuffers_handle = &framebuffer)
            {
                DeleteFramebuffers(n, framebuffers_handle);
            }
        }
        /// <inheritdoc cref="DeleteFramebuffers"/>
        public static unsafe void DeleteFramebuffers(ReadOnlySpan<FramebufferHandle> framebuffers)
        {
            int n = (int)(framebuffers.Length);
            fixed (FramebufferHandle* framebuffers_ptr = framebuffers)
            {
                DeleteFramebuffers(n, framebuffers_ptr);
            }
        }
        /// <inheritdoc cref="DeleteFramebuffers"/>
        public static unsafe void DeleteFramebuffers(FramebufferHandle[] framebuffers)
        {
            int n = (int)(framebuffers.Length);
            fixed (FramebufferHandle* framebuffers_ptr = framebuffers)
            {
                DeleteFramebuffers(n, framebuffers_ptr);
            }
        }
        /// <inheritdoc cref="DeleteFramebuffers"/>
        public static unsafe void DeleteFramebuffers(int n, in FramebufferHandle framebuffers)
        {
            fixed (FramebufferHandle* framebuffers_ptr = &framebuffers)
            {
                DeleteFramebuffers(n, framebuffers_ptr);
            }
        }
        /// <inheritdoc cref="DeleteRenderbuffers"/>
        public static unsafe void DeleteRenderbuffer(in RenderbufferHandle renderbuffer)
        {
            int n = 1;
            fixed(RenderbufferHandle* renderbuffers_handle = &renderbuffer)
            {
                DeleteRenderbuffers(n, renderbuffers_handle);
            }
        }
        /// <inheritdoc cref="DeleteRenderbuffers"/>
        public static unsafe void DeleteRenderbuffers(ReadOnlySpan<RenderbufferHandle> renderbuffers)
        {
            int n = (int)(renderbuffers.Length);
            fixed (RenderbufferHandle* renderbuffers_ptr = renderbuffers)
            {
                DeleteRenderbuffers(n, renderbuffers_ptr);
            }
        }
        /// <inheritdoc cref="DeleteRenderbuffers"/>
        public static unsafe void DeleteRenderbuffers(RenderbufferHandle[] renderbuffers)
        {
            int n = (int)(renderbuffers.Length);
            fixed (RenderbufferHandle* renderbuffers_ptr = renderbuffers)
            {
                DeleteRenderbuffers(n, renderbuffers_ptr);
            }
        }
        /// <inheritdoc cref="DeleteRenderbuffers"/>
        public static unsafe void DeleteRenderbuffers(int n, in RenderbufferHandle renderbuffers)
        {
            fixed (RenderbufferHandle* renderbuffers_ptr = &renderbuffers)
            {
                DeleteRenderbuffers(n, renderbuffers_ptr);
            }
        }
        /// <inheritdoc cref="DeleteTextures"/>
        public static unsafe void DeleteTexture(in TextureHandle texture)
        {
            int n = 1;
            fixed(TextureHandle* textures_handle = &texture)
            {
                DeleteTextures(n, textures_handle);
            }
        }
        /// <inheritdoc cref="DeleteTextures"/>
        public static unsafe void DeleteTextures(ReadOnlySpan<TextureHandle> textures)
        {
            int n = (int)(textures.Length);
            fixed (TextureHandle* textures_ptr = textures)
            {
                DeleteTextures(n, textures_ptr);
            }
        }
        /// <inheritdoc cref="DeleteTextures"/>
        public static unsafe void DeleteTextures(TextureHandle[] textures)
        {
            int n = (int)(textures.Length);
            fixed (TextureHandle* textures_ptr = textures)
            {
                DeleteTextures(n, textures_ptr);
            }
        }
        /// <inheritdoc cref="DeleteTextures"/>
        public static unsafe void DeleteTextures(int n, in TextureHandle textures)
        {
            fixed (TextureHandle* textures_ptr = &textures)
            {
                DeleteTextures(n, textures_ptr);
            }
        }
        /// <inheritdoc cref="DrawElements"/>
        public static unsafe void DrawElements(PrimitiveType mode, int count, DrawElementsType type, nint offset)
        {
            void* indices = (void*)offset;
            DrawElements(mode, count, type, indices);
        }
        /// <inheritdoc cref="GenBuffers"/>
        public static unsafe BufferHandle GenBuffer()
        {
            BufferHandle buffer;
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
            BufferHandle* buffers_handle = (BufferHandle*)Unsafe.AsPointer(ref buffer);
            GenBuffers(n, buffers_handle);
            return buffer;
        }
        /// <inheritdoc cref="GenBuffers"/>
        public static unsafe void GenBuffer(out BufferHandle buffer)
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
            BufferHandle* buffers_handle = (BufferHandle*)Unsafe.AsPointer(ref buffer);
            GenBuffers(n, buffers_handle);
        }
        /// <inheritdoc cref="GenBuffers"/>
        public static unsafe void GenBuffers(Span<BufferHandle> buffers)
        {
            int n = (int)(buffers.Length);
            fixed (BufferHandle* buffers_ptr = buffers)
            {
                GenBuffers(n, buffers_ptr);
            }
        }
        /// <inheritdoc cref="GenBuffers"/>
        public static unsafe void GenBuffers(BufferHandle[] buffers)
        {
            int n = (int)(buffers.Length);
            fixed (BufferHandle* buffers_ptr = buffers)
            {
                GenBuffers(n, buffers_ptr);
            }
        }
        /// <inheritdoc cref="GenBuffers"/>
        public static unsafe void GenBuffers(int n, ref BufferHandle buffers)
        {
            fixed (BufferHandle* buffers_ptr = &buffers)
            {
                GenBuffers(n, buffers_ptr);
            }
        }
        /// <inheritdoc cref="GenFramebuffers"/>
        public static unsafe FramebufferHandle GenFramebuffer()
        {
            FramebufferHandle framebuffer;
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
            FramebufferHandle* framebuffers_handle = (FramebufferHandle*)Unsafe.AsPointer(ref framebuffer);
            GenFramebuffers(n, framebuffers_handle);
            return framebuffer;
        }
        /// <inheritdoc cref="GenFramebuffers"/>
        public static unsafe void GenFramebuffer(out FramebufferHandle framebuffer)
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
            FramebufferHandle* framebuffers_handle = (FramebufferHandle*)Unsafe.AsPointer(ref framebuffer);
            GenFramebuffers(n, framebuffers_handle);
        }
        /// <inheritdoc cref="GenFramebuffers"/>
        public static unsafe void GenFramebuffers(Span<FramebufferHandle> framebuffers)
        {
            int n = (int)(framebuffers.Length);
            fixed (FramebufferHandle* framebuffers_ptr = framebuffers)
            {
                GenFramebuffers(n, framebuffers_ptr);
            }
        }
        /// <inheritdoc cref="GenFramebuffers"/>
        public static unsafe void GenFramebuffers(FramebufferHandle[] framebuffers)
        {
            int n = (int)(framebuffers.Length);
            fixed (FramebufferHandle* framebuffers_ptr = framebuffers)
            {
                GenFramebuffers(n, framebuffers_ptr);
            }
        }
        /// <inheritdoc cref="GenFramebuffers"/>
        public static unsafe void GenFramebuffers(int n, ref FramebufferHandle framebuffers)
        {
            fixed (FramebufferHandle* framebuffers_ptr = &framebuffers)
            {
                GenFramebuffers(n, framebuffers_ptr);
            }
        }
        /// <inheritdoc cref="GenRenderbuffers"/>
        public static unsafe RenderbufferHandle GenRenderbuffer()
        {
            RenderbufferHandle renderbuffer;
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
            RenderbufferHandle* renderbuffers_handle = (RenderbufferHandle*)Unsafe.AsPointer(ref renderbuffer);
            GenRenderbuffers(n, renderbuffers_handle);
            return renderbuffer;
        }
        /// <inheritdoc cref="GenRenderbuffers"/>
        public static unsafe void GenRenderbuffer(out RenderbufferHandle renderbuffer)
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
            RenderbufferHandle* renderbuffers_handle = (RenderbufferHandle*)Unsafe.AsPointer(ref renderbuffer);
            GenRenderbuffers(n, renderbuffers_handle);
        }
        /// <inheritdoc cref="GenRenderbuffers"/>
        public static unsafe void GenRenderbuffers(Span<RenderbufferHandle> renderbuffers)
        {
            int n = (int)(renderbuffers.Length);
            fixed (RenderbufferHandle* renderbuffers_ptr = renderbuffers)
            {
                GenRenderbuffers(n, renderbuffers_ptr);
            }
        }
        /// <inheritdoc cref="GenRenderbuffers"/>
        public static unsafe void GenRenderbuffers(RenderbufferHandle[] renderbuffers)
        {
            int n = (int)(renderbuffers.Length);
            fixed (RenderbufferHandle* renderbuffers_ptr = renderbuffers)
            {
                GenRenderbuffers(n, renderbuffers_ptr);
            }
        }
        /// <inheritdoc cref="GenRenderbuffers"/>
        public static unsafe void GenRenderbuffers(int n, ref RenderbufferHandle renderbuffers)
        {
            fixed (RenderbufferHandle* renderbuffers_ptr = &renderbuffers)
            {
                GenRenderbuffers(n, renderbuffers_ptr);
            }
        }
        /// <inheritdoc cref="GenTextures"/>
        public static unsafe TextureHandle GenTexture()
        {
            TextureHandle texture;
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
            TextureHandle* textures_handle = (TextureHandle*)Unsafe.AsPointer(ref texture);
            GenTextures(n, textures_handle);
            return texture;
        }
        /// <inheritdoc cref="GenTextures"/>
        public static unsafe void GenTexture(out TextureHandle texture)
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
            TextureHandle* textures_handle = (TextureHandle*)Unsafe.AsPointer(ref texture);
            GenTextures(n, textures_handle);
        }
        /// <inheritdoc cref="GenTextures"/>
        public static unsafe void GenTextures(Span<TextureHandle> textures)
        {
            int n = (int)(textures.Length);
            fixed (TextureHandle* textures_ptr = textures)
            {
                GenTextures(n, textures_ptr);
            }
        }
        /// <inheritdoc cref="GenTextures"/>
        public static unsafe void GenTextures(TextureHandle[] textures)
        {
            int n = (int)(textures.Length);
            fixed (TextureHandle* textures_ptr = textures)
            {
                GenTextures(n, textures_ptr);
            }
        }
        /// <inheritdoc cref="GenTextures"/>
        public static unsafe void GenTextures(int n, ref TextureHandle textures)
        {
            fixed (TextureHandle* textures_ptr = &textures)
            {
                GenTextures(n, textures_ptr);
            }
        }
        /// <inheritdoc cref="GetActiveAttrib"/>
        public static unsafe string GetActiveAttrib(ProgramHandle program, uint index, int bufSize, Span<int> length, Span<int> size, Span<AttributeType> type)
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
        /// <inheritdoc cref="GetActiveAttrib"/>
        public static unsafe void GetActiveAttrib(ProgramHandle program, uint index, int bufSize, Span<int> length, Span<int> size, Span<AttributeType> type, out string name)
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
        /// <inheritdoc cref="GetActiveAttrib"/>
        public static unsafe string GetActiveAttrib(ProgramHandle program, uint index, int bufSize, int[] length, int[] size, AttributeType[] type)
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
        /// <inheritdoc cref="GetActiveAttrib"/>
        public static unsafe void GetActiveAttrib(ProgramHandle program, uint index, int bufSize, int[] length, int[] size, AttributeType[] type, out string name)
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
        /// <inheritdoc cref="GetActiveAttrib"/>
        public static unsafe string GetActiveAttrib(ProgramHandle program, uint index, int bufSize, ref int length, ref int size, ref AttributeType type)
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
        /// <inheritdoc cref="GetActiveAttrib"/>
        public static unsafe void GetActiveAttrib(ProgramHandle program, uint index, int bufSize, ref int length, ref int size, ref AttributeType type, out string name)
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
        /// <inheritdoc cref="GetActiveUniform"/>
        public static unsafe string GetActiveUniform(ProgramHandle program, uint index, int bufSize, Span<int> length, Span<int> size, Span<UniformType> type)
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
        /// <inheritdoc cref="GetActiveUniform"/>
        public static unsafe void GetActiveUniform(ProgramHandle program, uint index, int bufSize, Span<int> length, Span<int> size, Span<UniformType> type, out string name)
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
        /// <inheritdoc cref="GetActiveUniform"/>
        public static unsafe string GetActiveUniform(ProgramHandle program, uint index, int bufSize, int[] length, int[] size, UniformType[] type)
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
        /// <inheritdoc cref="GetActiveUniform"/>
        public static unsafe void GetActiveUniform(ProgramHandle program, uint index, int bufSize, int[] length, int[] size, UniformType[] type, out string name)
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
        /// <inheritdoc cref="GetActiveUniform"/>
        public static unsafe string GetActiveUniform(ProgramHandle program, uint index, int bufSize, ref int length, ref int size, ref UniformType type)
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
        /// <inheritdoc cref="GetActiveUniform"/>
        public static unsafe void GetActiveUniform(ProgramHandle program, uint index, int bufSize, ref int length, ref int size, ref UniformType type, out string name)
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
        /// <inheritdoc cref="GetAttachedShaders"/>
        public static unsafe void GetAttachedShaders(ProgramHandle program, Span<int> count, Span<ShaderHandle> shaders)
        {
            fixed (int* count_ptr = count)
            {
                int maxCount = (int)(shaders.Length);
                fixed (ShaderHandle* shaders_ptr = shaders)
                {
                    GetAttachedShaders(program, maxCount, count_ptr, shaders_ptr);
                }
            }
        }
        /// <inheritdoc cref="GetAttachedShaders"/>
        public static unsafe void GetAttachedShaders(ProgramHandle program, int[] count, ShaderHandle[] shaders)
        {
            fixed (int* count_ptr = count)
            {
                int maxCount = (int)(shaders.Length);
                fixed (ShaderHandle* shaders_ptr = shaders)
                {
                    GetAttachedShaders(program, maxCount, count_ptr, shaders_ptr);
                }
            }
        }
        /// <inheritdoc cref="GetAttachedShaders"/>
        public static unsafe void GetAttachedShaders(ProgramHandle program, int maxCount, ref int count, ref ShaderHandle shaders)
        {
            fixed (int* count_ptr = &count)
            fixed (ShaderHandle* shaders_ptr = &shaders)
            {
                GetAttachedShaders(program, maxCount, count_ptr, shaders_ptr);
            }
        }
        /// <inheritdoc cref="GetAttribLocation"/>
        public static unsafe int GetAttribLocation(ProgramHandle program, string name)
        {
            int returnValue;
            byte* name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(name);
            returnValue = GetAttribLocation(program, name_ptr);
            Marshal.FreeCoTaskMem((IntPtr)name_ptr);
            return returnValue;
        }
        /// <inheritdoc cref="GetBooleanv"/>
        public static unsafe void GetBoolean(GetPName pname, Span<bool> data)
        {
            fixed (bool* data_ptr = data)
            {
                GetBooleanv(pname, data_ptr);
            }
        }
        /// <inheritdoc cref="GetBooleanv"/>
        public static unsafe void GetBoolean(GetPName pname, bool[] data)
        {
            fixed (bool* data_ptr = data)
            {
                GetBooleanv(pname, data_ptr);
            }
        }
        /// <inheritdoc cref="GetBooleanv"/>
        public static unsafe void GetBoolean(GetPName pname, ref bool data)
        {
            fixed (bool* data_ptr = &data)
            {
                GetBooleanv(pname, data_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferParameteriv"/>
        public static unsafe void GetBufferParameteri(BufferTargetARB target, BufferPNameARB pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetBufferParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferParameteriv"/>
        public static unsafe void GetBufferParameteri(BufferTargetARB target, BufferPNameARB pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetBufferParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferParameteriv"/>
        public static unsafe void GetBufferParameteri(BufferTargetARB target, BufferPNameARB pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetBufferParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetFloatv"/>
        public static unsafe void GetFloat(GetPName pname, Span<float> data)
        {
            fixed (float* data_ptr = data)
            {
                GetFloatv(pname, data_ptr);
            }
        }
        /// <inheritdoc cref="GetFloatv"/>
        public static unsafe void GetFloat(GetPName pname, float[] data)
        {
            fixed (float* data_ptr = data)
            {
                GetFloatv(pname, data_ptr);
            }
        }
        /// <inheritdoc cref="GetFloatv"/>
        public static unsafe void GetFloat(GetPName pname, ref float data)
        {
            fixed (float* data_ptr = &data)
            {
                GetFloatv(pname, data_ptr);
            }
        }
        /// <inheritdoc cref="GetFramebufferAttachmentParameteriv"/>
        public static unsafe void GetFramebufferAttachmentParameteri(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetFramebufferAttachmentParameteriv(target, attachment, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetFramebufferAttachmentParameteriv"/>
        public static unsafe void GetFramebufferAttachmentParameteri(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetFramebufferAttachmentParameteriv(target, attachment, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetFramebufferAttachmentParameteriv"/>
        public static unsafe void GetFramebufferAttachmentParameteri(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetFramebufferAttachmentParameteriv(target, attachment, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetIntegerv"/>
        public static unsafe void GetInteger(GetPName pname, Span<int> data)
        {
            fixed (int* data_ptr = data)
            {
                GetIntegerv(pname, data_ptr);
            }
        }
        /// <inheritdoc cref="GetIntegerv"/>
        public static unsafe void GetInteger(GetPName pname, int[] data)
        {
            fixed (int* data_ptr = data)
            {
                GetIntegerv(pname, data_ptr);
            }
        }
        /// <inheritdoc cref="GetIntegerv"/>
        public static unsafe void GetInteger(GetPName pname, ref int data)
        {
            fixed (int* data_ptr = &data)
            {
                GetIntegerv(pname, data_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramiv"/>
        public static unsafe void GetProgrami(ProgramHandle program, ProgramPropertyARB pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetProgramiv(program, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramiv"/>
        public static unsafe void GetProgrami(ProgramHandle program, ProgramPropertyARB pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetProgramiv(program, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramiv"/>
        public static unsafe void GetProgrami(ProgramHandle program, ProgramPropertyARB pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetProgramiv(program, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramInfoLog"/>
        public static unsafe string GetProgramInfoLog(ProgramHandle program, int bufSize, Span<int> length)
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
        /// <inheritdoc cref="GetProgramInfoLog"/>
        public static unsafe void GetProgramInfoLog(ProgramHandle program, int bufSize, Span<int> length, out string infoLog)
        {
            fixed (int* length_ptr = length)
            {
                var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetProgramInfoLog(program, bufSize, length_ptr, infoLog_ptr);
                infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramInfoLog"/>
        public static unsafe string GetProgramInfoLog(ProgramHandle program, int bufSize, int[] length)
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
        /// <inheritdoc cref="GetProgramInfoLog"/>
        public static unsafe void GetProgramInfoLog(ProgramHandle program, int bufSize, int[] length, out string infoLog)
        {
            fixed (int* length_ptr = length)
            {
                var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetProgramInfoLog(program, bufSize, length_ptr, infoLog_ptr);
                infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramInfoLog"/>
        public static unsafe string GetProgramInfoLog(ProgramHandle program, int bufSize, ref int length)
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
        /// <inheritdoc cref="GetProgramInfoLog"/>
        public static unsafe void GetProgramInfoLog(ProgramHandle program, int bufSize, ref int length, out string infoLog)
        {
            fixed (int* length_ptr = &length)
            {
                var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetProgramInfoLog(program, bufSize, length_ptr, infoLog_ptr);
                infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
            }
        }
        /// <inheritdoc cref="GetRenderbufferParameteriv"/>
        public static unsafe void GetRenderbufferParameteri(RenderbufferTarget target, RenderbufferParameterName pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetRenderbufferParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetRenderbufferParameteriv"/>
        public static unsafe void GetRenderbufferParameteri(RenderbufferTarget target, RenderbufferParameterName pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetRenderbufferParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetRenderbufferParameteriv"/>
        public static unsafe void GetRenderbufferParameteri(RenderbufferTarget target, RenderbufferParameterName pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetRenderbufferParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetShaderiv"/>
        public static unsafe void GetShaderi(ShaderHandle shader, ShaderParameterName pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetShaderiv(shader, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetShaderiv"/>
        public static unsafe void GetShaderi(ShaderHandle shader, ShaderParameterName pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetShaderiv(shader, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetShaderiv"/>
        public static unsafe void GetShaderi(ShaderHandle shader, ShaderParameterName pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetShaderiv(shader, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetShaderInfoLog"/>
        public static unsafe string GetShaderInfoLog(ShaderHandle shader, int bufSize, Span<int> length)
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
        /// <inheritdoc cref="GetShaderInfoLog"/>
        public static unsafe void GetShaderInfoLog(ShaderHandle shader, int bufSize, Span<int> length, out string infoLog)
        {
            fixed (int* length_ptr = length)
            {
                var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetShaderInfoLog(shader, bufSize, length_ptr, infoLog_ptr);
                infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
            }
        }
        /// <inheritdoc cref="GetShaderInfoLog"/>
        public static unsafe string GetShaderInfoLog(ShaderHandle shader, int bufSize, int[] length)
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
        /// <inheritdoc cref="GetShaderInfoLog"/>
        public static unsafe void GetShaderInfoLog(ShaderHandle shader, int bufSize, int[] length, out string infoLog)
        {
            fixed (int* length_ptr = length)
            {
                var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetShaderInfoLog(shader, bufSize, length_ptr, infoLog_ptr);
                infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
            }
        }
        /// <inheritdoc cref="GetShaderInfoLog"/>
        public static unsafe string GetShaderInfoLog(ShaderHandle shader, int bufSize, ref int length)
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
        /// <inheritdoc cref="GetShaderInfoLog"/>
        public static unsafe void GetShaderInfoLog(ShaderHandle shader, int bufSize, ref int length, out string infoLog)
        {
            fixed (int* length_ptr = &length)
            {
                var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetShaderInfoLog(shader, bufSize, length_ptr, infoLog_ptr);
                infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
            }
        }
        /// <inheritdoc cref="GetShaderPrecisionFormat"/>
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
        /// <inheritdoc cref="GetShaderPrecisionFormat"/>
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
        /// <inheritdoc cref="GetShaderPrecisionFormat"/>
        public static unsafe void GetShaderPrecisionFormat(ShaderType shadertype, PrecisionType precisiontype, ref int range, ref int precision)
        {
            fixed (int* range_ptr = &range)
            fixed (int* precision_ptr = &precision)
            {
                GetShaderPrecisionFormat(shadertype, precisiontype, range_ptr, precision_ptr);
            }
        }
        /// <inheritdoc cref="GetShaderSource"/>
        public static unsafe string GetShaderSource(ShaderHandle shader, int bufSize, Span<int> length)
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
        /// <inheritdoc cref="GetShaderSource"/>
        public static unsafe void GetShaderSource(ShaderHandle shader, int bufSize, Span<int> length, out string source)
        {
            fixed (int* length_ptr = length)
            {
                var source_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetShaderSource(shader, bufSize, length_ptr, source_ptr);
                source = Marshal.PtrToStringUTF8((IntPtr)source_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)source_ptr);
            }
        }
        /// <inheritdoc cref="GetShaderSource"/>
        public static unsafe string GetShaderSource(ShaderHandle shader, int bufSize, int[] length)
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
        /// <inheritdoc cref="GetShaderSource"/>
        public static unsafe void GetShaderSource(ShaderHandle shader, int bufSize, int[] length, out string source)
        {
            fixed (int* length_ptr = length)
            {
                var source_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetShaderSource(shader, bufSize, length_ptr, source_ptr);
                source = Marshal.PtrToStringUTF8((IntPtr)source_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)source_ptr);
            }
        }
        /// <inheritdoc cref="GetShaderSource"/>
        public static unsafe string GetShaderSource(ShaderHandle shader, int bufSize, ref int length)
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
        /// <inheritdoc cref="GetShaderSource"/>
        public static unsafe void GetShaderSource(ShaderHandle shader, int bufSize, ref int length, out string source)
        {
            fixed (int* length_ptr = &length)
            {
                var source_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetShaderSource(shader, bufSize, length_ptr, source_ptr);
                source = Marshal.PtrToStringUTF8((IntPtr)source_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)source_ptr);
            }
        }
        /// <inheritdoc cref="GetString"/>
        public static unsafe string? GetString(StringName name)
        {
            byte* returnValue;
            string? returnValue_str;
            returnValue = GetString_(name);
            returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
            return returnValue_str;
        }
        /// <inheritdoc cref="GetTexParameterfv"/>
        public static unsafe void GetTexParameterf(TextureTarget target, GetTextureParameter pname, Span<float> parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetTexParameterfv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexParameterfv"/>
        public static unsafe void GetTexParameterf(TextureTarget target, GetTextureParameter pname, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetTexParameterfv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexParameterfv"/>
        public static unsafe void GetTexParameterf(TextureTarget target, GetTextureParameter pname, ref float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                GetTexParameterfv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexParameteriv"/>
        public static unsafe void GetTexParameteri(TextureTarget target, GetTextureParameter pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetTexParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexParameteriv"/>
        public static unsafe void GetTexParameteri(TextureTarget target, GetTextureParameter pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetTexParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexParameteriv"/>
        public static unsafe void GetTexParameteri(TextureTarget target, GetTextureParameter pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetTexParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetUniformfv"/>
        public static unsafe void GetUniformf(ProgramHandle program, int location, Span<float> parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetUniformfv(program, location, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetUniformfv"/>
        public static unsafe void GetUniformf(ProgramHandle program, int location, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetUniformfv(program, location, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetUniformfv"/>
        public static unsafe void GetUniformf(ProgramHandle program, int location, ref float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                GetUniformfv(program, location, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetUniformiv"/>
        public static unsafe void GetUniformi(ProgramHandle program, int location, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetUniformiv(program, location, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetUniformiv"/>
        public static unsafe void GetUniformi(ProgramHandle program, int location, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetUniformiv(program, location, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetUniformiv"/>
        public static unsafe void GetUniformi(ProgramHandle program, int location, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetUniformiv(program, location, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetUniformLocation"/>
        public static unsafe int GetUniformLocation(ProgramHandle program, string name)
        {
            int returnValue;
            byte* name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(name);
            returnValue = GetUniformLocation(program, name_ptr);
            Marshal.FreeCoTaskMem((IntPtr)name_ptr);
            return returnValue;
        }
        /// <inheritdoc cref="GetVertexAttribfv"/>
        public static unsafe void GetVertexAttribf(uint index, VertexAttribPropertyARB pname, Span<float> parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetVertexAttribfv(index, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetVertexAttribfv"/>
        public static unsafe void GetVertexAttribf(uint index, VertexAttribPropertyARB pname, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetVertexAttribfv(index, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetVertexAttribfv"/>
        public static unsafe void GetVertexAttribf(uint index, VertexAttribPropertyARB pname, ref float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                GetVertexAttribfv(index, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetVertexAttribiv"/>
        public static unsafe void GetVertexAttribi(uint index, VertexAttribPropertyARB pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetVertexAttribiv(index, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetVertexAttribiv"/>
        public static unsafe void GetVertexAttribi(uint index, VertexAttribPropertyARB pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetVertexAttribiv(index, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetVertexAttribiv"/>
        public static unsafe void GetVertexAttribi(uint index, VertexAttribPropertyARB pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetVertexAttribiv(index, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetVertexAttribPointerv"/>
        public static unsafe void GetVertexAttribPointer(uint index, VertexAttribPointerPropertyARB pname, void** pointer)
        {
            GetVertexAttribPointerv(index, pname, pointer);
        }
        /// <inheritdoc cref="ReadPixels"/>
        public static unsafe void ReadPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, IntPtr pixels)
        {
            void* pixels_vptr = (void*)pixels;
            ReadPixels(x, y, width, height, format, type, pixels_vptr);
        }
        /// <inheritdoc cref="ReadPixels"/>
        public static unsafe void ReadPixels<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, Span<T1> pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels)
            {
                ReadPixels(x, y, width, height, format, type, pixels_ptr);
            }
        }
        /// <inheritdoc cref="ReadPixels"/>
        public static unsafe void ReadPixels<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, T1[] pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels)
            {
                ReadPixels(x, y, width, height, format, type, pixels_ptr);
            }
        }
        /// <inheritdoc cref="ReadPixels"/>
        public static unsafe void ReadPixels<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, ref T1 pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = &pixels)
            {
                ReadPixels(x, y, width, height, format, type, pixels_ptr);
            }
        }
        /// <inheritdoc cref="ShaderBinary"/>
        public static unsafe void ShaderBinary(ReadOnlySpan<ShaderHandle> shaders, ShaderBinaryFormat binaryFormat, IntPtr binary, int length)
        {
            int count = (int)(shaders.Length);
            fixed (ShaderHandle* shaders_ptr = shaders)
            {
                void* binary_vptr = (void*)binary;
                ShaderBinary(count, shaders_ptr, binaryFormat, binary_vptr, length);
            }
        }
        /// <inheritdoc cref="ShaderBinary"/>
        public static unsafe void ShaderBinary(ShaderHandle[] shaders, ShaderBinaryFormat binaryFormat, IntPtr binary, int length)
        {
            int count = (int)(shaders.Length);
            fixed (ShaderHandle* shaders_ptr = shaders)
            {
                void* binary_vptr = (void*)binary;
                ShaderBinary(count, shaders_ptr, binaryFormat, binary_vptr, length);
            }
        }
        /// <inheritdoc cref="ShaderBinary"/>
        public static unsafe void ShaderBinary(int count, in ShaderHandle shaders, ShaderBinaryFormat binaryFormat, IntPtr binary, int length)
        {
            fixed (ShaderHandle* shaders_ptr = &shaders)
            {
                void* binary_vptr = (void*)binary;
                ShaderBinary(count, shaders_ptr, binaryFormat, binary_vptr, length);
            }
        }
        /// <inheritdoc cref="ShaderBinary"/>
        public static unsafe void ShaderBinary<T1>(ReadOnlySpan<ShaderHandle> shaders, ShaderBinaryFormat binaryFormat, ReadOnlySpan<T1> binary)
            where T1 : unmanaged
        {
            int count = (int)(shaders.Length);
            fixed (ShaderHandle* shaders_ptr = shaders)
            {
                int length = (int)(binary.Length * sizeof(T1));
                fixed (void* binary_ptr = binary)
                {
                    ShaderBinary(count, shaders_ptr, binaryFormat, binary_ptr, length);
                }
            }
        }
        /// <inheritdoc cref="ShaderBinary"/>
        public static unsafe void ShaderBinary<T1>(ShaderHandle[] shaders, ShaderBinaryFormat binaryFormat, T1[] binary)
            where T1 : unmanaged
        {
            int count = (int)(shaders.Length);
            fixed (ShaderHandle* shaders_ptr = shaders)
            {
                int length = (int)(binary.Length * sizeof(T1));
                fixed (void* binary_ptr = binary)
                {
                    ShaderBinary(count, shaders_ptr, binaryFormat, binary_ptr, length);
                }
            }
        }
        /// <inheritdoc cref="ShaderBinary"/>
        public static unsafe void ShaderBinary<T1>(int count, in ShaderHandle shaders, ShaderBinaryFormat binaryFormat, in T1 binary, int length)
            where T1 : unmanaged
        {
            fixed (ShaderHandle* shaders_ptr = &shaders)
            fixed (void* binary_ptr = &binary)
            {
                ShaderBinary(count, shaders_ptr, binaryFormat, binary_ptr, length);
            }
        }
        /// <inheritdoc cref="ShaderSource"/>
        public static unsafe void ShaderSource(ShaderHandle shader, int count, byte** str, ReadOnlySpan<int> length)
        {
            fixed (int* length_ptr = length)
            {
                ShaderSource(shader, count, str, length_ptr);
            }
        }
        /// <inheritdoc cref="ShaderSource"/>
        public static unsafe void ShaderSource(ShaderHandle shader, int count, byte** str, int[] length)
        {
            fixed (int* length_ptr = length)
            {
                ShaderSource(shader, count, str, length_ptr);
            }
        }
        /// <inheritdoc cref="ShaderSource"/>
        public static unsafe void ShaderSource(ShaderHandle shader, int count, byte** str, in int length)
        {
            fixed (int* length_ptr = &length)
            {
                ShaderSource(shader, count, str, length_ptr);
            }
        }
        /// <inheritdoc cref="TexImage2D"/>
        public static unsafe void TexImage2D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, PixelFormat format, PixelType type, IntPtr pixels)
        {
            void* pixels_vptr = (void*)pixels;
            TexImage2D(target, level, internalformat, width, height, border, format, type, pixels_vptr);
        }
        /// <inheritdoc cref="TexImage2D"/>
        public static unsafe void TexImage2D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, PixelFormat format, PixelType type, ReadOnlySpan<T1> pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels)
            {
                TexImage2D(target, level, internalformat, width, height, border, format, type, pixels_ptr);
            }
        }
        /// <inheritdoc cref="TexImage2D"/>
        public static unsafe void TexImage2D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, PixelFormat format, PixelType type, T1[] pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels)
            {
                TexImage2D(target, level, internalformat, width, height, border, format, type, pixels_ptr);
            }
        }
        /// <inheritdoc cref="TexImage2D"/>
        public static unsafe void TexImage2D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, PixelFormat format, PixelType type, in T1 pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = &pixels)
            {
                TexImage2D(target, level, internalformat, width, height, border, format, type, pixels_ptr);
            }
        }
        /// <inheritdoc cref="TexParameterfv"/>
        public static unsafe void TexParameterf(TextureTarget target, TextureParameterName pname, ReadOnlySpan<float> parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                TexParameterfv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="TexParameterfv"/>
        public static unsafe void TexParameterf(TextureTarget target, TextureParameterName pname, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                TexParameterfv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="TexParameterfv"/>
        public static unsafe void TexParameterf(TextureTarget target, TextureParameterName pname, in float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                TexParameterfv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="TexParameteriv"/>
        public static unsafe void TexParameteri(TextureTarget target, TextureParameterName pname, ReadOnlySpan<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                TexParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="TexParameteriv"/>
        public static unsafe void TexParameteri(TextureTarget target, TextureParameterName pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                TexParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="TexParameteriv"/>
        public static unsafe void TexParameteri(TextureTarget target, TextureParameterName pname, in int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                TexParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="TexSubImage2D"/>
        public static unsafe void TexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, IntPtr pixels)
        {
            void* pixels_vptr = (void*)pixels;
            TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels_vptr);
        }
        /// <inheritdoc cref="TexSubImage2D"/>
        public static unsafe void TexSubImage2D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, ReadOnlySpan<T1> pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels)
            {
                TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels_ptr);
            }
        }
        /// <inheritdoc cref="TexSubImage2D"/>
        public static unsafe void TexSubImage2D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, T1[] pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels)
            {
                TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels_ptr);
            }
        }
        /// <inheritdoc cref="TexSubImage2D"/>
        public static unsafe void TexSubImage2D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, in T1 pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = &pixels)
            {
                TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels_ptr);
            }
        }
        /// <inheritdoc cref="Uniform1fv"/>
        public static unsafe void Uniform1f(int location, in float value)
        {
            int count = 1;
            fixed (float* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                Uniform1fv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform1fv"/>
        public static unsafe void Uniform1f(int location, int count, ReadOnlySpan<float> value)
        {
            fixed (float* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                Uniform1fv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform1fv"/>
        public static unsafe void Uniform1f(int location, int count, float[] value)
        {
            fixed (float* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                Uniform1fv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform1iv"/>
        public static unsafe void Uniform1i(int location, in int value)
        {
            int count = 1;
            fixed (int* tmp_vecPtr = &value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                Uniform1iv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform1iv"/>
        public static unsafe void Uniform1i(int location, int count, ReadOnlySpan<int> value)
        {
            fixed (int* tmp_vecPtr = value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                Uniform1iv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform1iv"/>
        public static unsafe void Uniform1i(int location, int count, int[] value)
        {
            fixed (int* tmp_vecPtr = value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                Uniform1iv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform2fv"/>
        public static unsafe void Uniform2f(int location, in Vector2 value)
        {
            int count = 1;
            fixed (Vector2* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                Uniform2fv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform2fv"/>
        public static unsafe void Uniform2f(int location, int count, ReadOnlySpan<Vector2> value)
        {
            fixed (Vector2* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                Uniform2fv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform2fv"/>
        public static unsafe void Uniform2f(int location, int count, Vector2[] value)
        {
            fixed (Vector2* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                Uniform2fv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform2iv"/>
        public static unsafe void Uniform2i(int location, in Vector2i value)
        {
            int count = 1;
            fixed (Vector2i* tmp_vecPtr = &value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                Uniform2iv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform2iv"/>
        public static unsafe void Uniform2i(int location, int count, ReadOnlySpan<Vector2i> value)
        {
            fixed (Vector2i* tmp_vecPtr = value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                Uniform2iv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform2iv"/>
        public static unsafe void Uniform2i(int location, int count, Vector2i[] value)
        {
            fixed (Vector2i* tmp_vecPtr = value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                Uniform2iv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform3fv"/>
        public static unsafe void Uniform3f(int location, in Vector3 value)
        {
            int count = 1;
            fixed (Vector3* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                Uniform3fv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform3fv"/>
        public static unsafe void Uniform3f(int location, int count, ReadOnlySpan<Vector3> value)
        {
            fixed (Vector3* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                Uniform3fv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform3fv"/>
        public static unsafe void Uniform3f(int location, int count, Vector3[] value)
        {
            fixed (Vector3* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                Uniform3fv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform3iv"/>
        public static unsafe void Uniform3i(int location, in Vector3i value)
        {
            int count = 1;
            fixed (Vector3i* tmp_vecPtr = &value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                Uniform3iv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform3iv"/>
        public static unsafe void Uniform3i(int location, int count, ReadOnlySpan<Vector3i> value)
        {
            fixed (Vector3i* tmp_vecPtr = value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                Uniform3iv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform3iv"/>
        public static unsafe void Uniform3i(int location, int count, Vector3i[] value)
        {
            fixed (Vector3i* tmp_vecPtr = value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                Uniform3iv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform4fv"/>
        public static unsafe void Uniform4f(int location, in Vector4 value)
        {
            int count = 1;
            fixed (Vector4* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                Uniform4fv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform4fv"/>
        public static unsafe void Uniform4f(int location, int count, ReadOnlySpan<Vector4> value)
        {
            fixed (Vector4* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                Uniform4fv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform4fv"/>
        public static unsafe void Uniform4f(int location, int count, Vector4[] value)
        {
            fixed (Vector4* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                Uniform4fv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform4iv"/>
        public static unsafe void Uniform4i(int location, in Vector4i value)
        {
            int count = 1;
            fixed (Vector4i* tmp_vecPtr = &value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                Uniform4iv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform4iv"/>
        public static unsafe void Uniform4i(int location, int count, ReadOnlySpan<Vector4i> value)
        {
            fixed (Vector4i* tmp_vecPtr = value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                Uniform4iv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform4iv"/>
        public static unsafe void Uniform4i(int location, int count, Vector4i[] value)
        {
            fixed (Vector4i* tmp_vecPtr = value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                Uniform4iv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix2fv"/>
        public static unsafe void UniformMatrix2f(int location, bool transpose, in Matrix2 value)
        {
            int count = 1;
            fixed (Matrix2* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                UniformMatrix2fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix2fv"/>
        public static unsafe void UniformMatrix2f(int location, int count, bool transpose, ReadOnlySpan<Matrix2> value)
        {
            fixed (Matrix2* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                UniformMatrix2fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix2fv"/>
        public static unsafe void UniformMatrix2f(int location, int count, bool transpose, Matrix2[] value)
        {
            fixed (Matrix2* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                UniformMatrix2fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix3fv"/>
        public static unsafe void UniformMatrix3f(int location, bool transpose, in Matrix3 value)
        {
            int count = 1;
            fixed (Matrix3* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                UniformMatrix3fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix3fv"/>
        public static unsafe void UniformMatrix3f(int location, int count, bool transpose, ReadOnlySpan<Matrix3> value)
        {
            fixed (Matrix3* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                UniformMatrix3fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix3fv"/>
        public static unsafe void UniformMatrix3f(int location, int count, bool transpose, Matrix3[] value)
        {
            fixed (Matrix3* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                UniformMatrix3fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix4fv"/>
        public static unsafe void UniformMatrix4f(int location, bool transpose, in Matrix4 value)
        {
            int count = 1;
            fixed (Matrix4* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                UniformMatrix4fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix4fv"/>
        public static unsafe void UniformMatrix4f(int location, int count, bool transpose, ReadOnlySpan<Matrix4> value)
        {
            fixed (Matrix4* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                UniformMatrix4fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix4fv"/>
        public static unsafe void UniformMatrix4f(int location, int count, bool transpose, Matrix4[] value)
        {
            fixed (Matrix4* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                UniformMatrix4fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="VertexAttrib1fv"/>
        public static unsafe void VertexAttrib1fv(uint index, ReadOnlySpan<float> v)
        {
            fixed (float* v_ptr = v)
            {
                VertexAttrib1fv(index, v_ptr);
            }
        }
        /// <inheritdoc cref="VertexAttrib1fv"/>
        public static unsafe void VertexAttrib1fv(uint index, float[] v)
        {
            fixed (float* v_ptr = v)
            {
                VertexAttrib1fv(index, v_ptr);
            }
        }
        /// <inheritdoc cref="VertexAttrib1fv"/>
        public static unsafe void VertexAttrib1fv(uint index, in float v)
        {
            fixed (float* v_ptr = &v)
            {
                VertexAttrib1fv(index, v_ptr);
            }
        }
        /// <inheritdoc cref="VertexAttrib2fv"/>
        public static unsafe void VertexAttrib2fv(uint index, ReadOnlySpan<float> v)
        {
            fixed (float* v_ptr = v)
            {
                VertexAttrib2fv(index, v_ptr);
            }
        }
        /// <inheritdoc cref="VertexAttrib2fv"/>
        public static unsafe void VertexAttrib2fv(uint index, float[] v)
        {
            fixed (float* v_ptr = v)
            {
                VertexAttrib2fv(index, v_ptr);
            }
        }
        /// <inheritdoc cref="VertexAttrib2fv"/>
        public static unsafe void VertexAttrib2fv(uint index, in float v)
        {
            fixed (float* v_ptr = &v)
            {
                VertexAttrib2fv(index, v_ptr);
            }
        }
        /// <inheritdoc cref="VertexAttrib3fv"/>
        public static unsafe void VertexAttrib3fv(uint index, ReadOnlySpan<float> v)
        {
            fixed (float* v_ptr = v)
            {
                VertexAttrib3fv(index, v_ptr);
            }
        }
        /// <inheritdoc cref="VertexAttrib3fv"/>
        public static unsafe void VertexAttrib3fv(uint index, float[] v)
        {
            fixed (float* v_ptr = v)
            {
                VertexAttrib3fv(index, v_ptr);
            }
        }
        /// <inheritdoc cref="VertexAttrib3fv"/>
        public static unsafe void VertexAttrib3fv(uint index, in float v)
        {
            fixed (float* v_ptr = &v)
            {
                VertexAttrib3fv(index, v_ptr);
            }
        }
        /// <inheritdoc cref="VertexAttrib4fv"/>
        public static unsafe void VertexAttrib4fv(uint index, ReadOnlySpan<float> v)
        {
            fixed (float* v_ptr = v)
            {
                VertexAttrib4fv(index, v_ptr);
            }
        }
        /// <inheritdoc cref="VertexAttrib4fv"/>
        public static unsafe void VertexAttrib4fv(uint index, float[] v)
        {
            fixed (float* v_ptr = v)
            {
                VertexAttrib4fv(index, v_ptr);
            }
        }
        /// <inheritdoc cref="VertexAttrib4fv"/>
        public static unsafe void VertexAttrib4fv(uint index, in float v)
        {
            fixed (float* v_ptr = &v)
            {
                VertexAttrib4fv(index, v_ptr);
            }
        }
        /// <inheritdoc cref="VertexAttribPointer"/>
        public static unsafe void VertexAttribPointer(uint index, int size, VertexAttribPointerType type, bool normalized, int stride, nint offset)
        {
            void* pointer = (void*)offset;
            VertexAttribPointer(index, size, type, normalized, stride, pointer);
        }
        /// <inheritdoc cref="DrawRangeElements"/>
        public static unsafe void DrawRangeElements(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, nint offset)
        {
            void* indices = (void*)offset;
            DrawRangeElements(mode, start, end, count, type, indices);
        }
        /// <inheritdoc cref="TexImage3D"/>
        public static unsafe void TexImage3D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, IntPtr pixels)
        {
            void* pixels_vptr = (void*)pixels;
            TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels_vptr);
        }
        /// <inheritdoc cref="TexImage3D"/>
        public static unsafe void TexImage3D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, ReadOnlySpan<T1> pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels)
            {
                TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels_ptr);
            }
        }
        /// <inheritdoc cref="TexImage3D"/>
        public static unsafe void TexImage3D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, T1[] pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels)
            {
                TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels_ptr);
            }
        }
        /// <inheritdoc cref="TexImage3D"/>
        public static unsafe void TexImage3D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, in T1 pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = &pixels)
            {
                TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels_ptr);
            }
        }
        /// <inheritdoc cref="TexSubImage3D"/>
        public static unsafe void TexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels)
        {
            void* pixels_vptr = (void*)pixels;
            TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels_vptr);
        }
        /// <inheritdoc cref="TexSubImage3D"/>
        public static unsafe void TexSubImage3D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, ReadOnlySpan<T1> pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels)
            {
                TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels_ptr);
            }
        }
        /// <inheritdoc cref="TexSubImage3D"/>
        public static unsafe void TexSubImage3D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, T1[] pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels)
            {
                TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels_ptr);
            }
        }
        /// <inheritdoc cref="TexSubImage3D"/>
        public static unsafe void TexSubImage3D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, in T1 pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = &pixels)
            {
                TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels_ptr);
            }
        }
        /// <inheritdoc cref="CompressedTexImage3D"/>
        public static unsafe void CompressedTexImage3D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data)
        {
            void* data_vptr = (void*)data;
            CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data_vptr);
        }
        /// <inheritdoc cref="CompressedTexImage3D"/>
        public static unsafe void CompressedTexImage3D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, ReadOnlySpan<T1> data)
            where T1 : unmanaged
        {
            int imageSize = (int)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data_ptr);
            }
        }
        /// <inheritdoc cref="CompressedTexImage3D"/>
        public static unsafe void CompressedTexImage3D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, T1[] data)
            where T1 : unmanaged
        {
            int imageSize = (int)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data_ptr);
            }
        }
        /// <inheritdoc cref="CompressedTexImage3D"/>
        public static unsafe void CompressedTexImage3D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, in T1 data)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = &data)
            {
                CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data_ptr);
            }
        }
        /// <inheritdoc cref="CompressedTexSubImage3D"/>
        public static unsafe void CompressedTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, InternalFormat format, int imageSize, IntPtr data)
        {
            void* data_vptr = (void*)data;
            CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data_vptr);
        }
        /// <inheritdoc cref="CompressedTexSubImage3D"/>
        public static unsafe void CompressedTexSubImage3D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, InternalFormat format, ReadOnlySpan<T1> data)
            where T1 : unmanaged
        {
            int imageSize = (int)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data_ptr);
            }
        }
        /// <inheritdoc cref="CompressedTexSubImage3D"/>
        public static unsafe void CompressedTexSubImage3D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, InternalFormat format, T1[] data)
            where T1 : unmanaged
        {
            int imageSize = (int)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data_ptr);
            }
        }
        /// <inheritdoc cref="CompressedTexSubImage3D"/>
        public static unsafe void CompressedTexSubImage3D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, InternalFormat format, int imageSize, in T1 data)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = &data)
            {
                CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data_ptr);
            }
        }
        /// <inheritdoc cref="GenQueries"/>
        public static unsafe QueryHandle GenQuery()
        {
            QueryHandle id;
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
            QueryHandle* ids_handle = (QueryHandle*)Unsafe.AsPointer(ref id);
            GenQueries(n, ids_handle);
            return id;
        }
        /// <inheritdoc cref="GenQueries"/>
        public static unsafe void GenQuery(out QueryHandle id)
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
            QueryHandle* ids_handle = (QueryHandle*)Unsafe.AsPointer(ref id);
            GenQueries(n, ids_handle);
        }
        /// <inheritdoc cref="GenQueries"/>
        public static unsafe void GenQueries(Span<QueryHandle> ids)
        {
            int n = (int)(ids.Length);
            fixed (QueryHandle* ids_ptr = ids)
            {
                GenQueries(n, ids_ptr);
            }
        }
        /// <inheritdoc cref="GenQueries"/>
        public static unsafe void GenQueries(QueryHandle[] ids)
        {
            int n = (int)(ids.Length);
            fixed (QueryHandle* ids_ptr = ids)
            {
                GenQueries(n, ids_ptr);
            }
        }
        /// <inheritdoc cref="GenQueries"/>
        public static unsafe void GenQueries(int n, ref QueryHandle ids)
        {
            fixed (QueryHandle* ids_ptr = &ids)
            {
                GenQueries(n, ids_ptr);
            }
        }
        /// <inheritdoc cref="DeleteQueries"/>
        public static unsafe void DeleteQuery(in QueryHandle id)
        {
            int n = 1;
            fixed(QueryHandle* ids_handle = &id)
            {
                DeleteQueries(n, ids_handle);
            }
        }
        /// <inheritdoc cref="DeleteQueries"/>
        public static unsafe void DeleteQueries(ReadOnlySpan<QueryHandle> ids)
        {
            int n = (int)(ids.Length);
            fixed (QueryHandle* ids_ptr = ids)
            {
                DeleteQueries(n, ids_ptr);
            }
        }
        /// <inheritdoc cref="DeleteQueries"/>
        public static unsafe void DeleteQueries(QueryHandle[] ids)
        {
            int n = (int)(ids.Length);
            fixed (QueryHandle* ids_ptr = ids)
            {
                DeleteQueries(n, ids_ptr);
            }
        }
        /// <inheritdoc cref="DeleteQueries"/>
        public static unsafe void DeleteQueries(int n, in QueryHandle ids)
        {
            fixed (QueryHandle* ids_ptr = &ids)
            {
                DeleteQueries(n, ids_ptr);
            }
        }
        /// <inheritdoc cref="GetQueryiv"/>
        public static unsafe void GetQueryi(QueryTarget target, QueryParameterName pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetQueryiv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetQueryiv"/>
        public static unsafe void GetQueryi(QueryTarget target, QueryParameterName pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetQueryiv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetQueryiv"/>
        public static unsafe void GetQueryi(QueryTarget target, QueryParameterName pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetQueryiv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetQueryObjectuiv"/>
        public static unsafe void GetQueryObjectui(QueryHandle id, QueryObjectParameterName pname, Span<uint> parameters)
        {
            fixed (uint* parameters_ptr = parameters)
            {
                GetQueryObjectuiv(id, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetQueryObjectuiv"/>
        public static unsafe void GetQueryObjectui(QueryHandle id, QueryObjectParameterName pname, uint[] parameters)
        {
            fixed (uint* parameters_ptr = parameters)
            {
                GetQueryObjectuiv(id, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetQueryObjectuiv"/>
        public static unsafe void GetQueryObjectui(QueryHandle id, QueryObjectParameterName pname, ref uint parameters)
        {
            fixed (uint* parameters_ptr = &parameters)
            {
                GetQueryObjectuiv(id, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferPointerv"/>
        public static unsafe void GetBufferPointer(BufferTargetARB target, BufferPointerNameARB pname, void** parameters)
        {
            GetBufferPointerv(target, pname, parameters);
        }
        /// <inheritdoc cref="DrawBuffers"/>
        public static unsafe void DrawBuffers(ReadOnlySpan<DrawBufferMode> bufs)
        {
            int n = (int)(bufs.Length);
            fixed (DrawBufferMode* bufs_ptr = bufs)
            {
                DrawBuffers(n, bufs_ptr);
            }
        }
        /// <inheritdoc cref="DrawBuffers"/>
        public static unsafe void DrawBuffers(DrawBufferMode[] bufs)
        {
            int n = (int)(bufs.Length);
            fixed (DrawBufferMode* bufs_ptr = bufs)
            {
                DrawBuffers(n, bufs_ptr);
            }
        }
        /// <inheritdoc cref="DrawBuffers"/>
        public static unsafe void DrawBuffers(int n, in DrawBufferMode bufs)
        {
            fixed (DrawBufferMode* bufs_ptr = &bufs)
            {
                DrawBuffers(n, bufs_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix2x3fv"/>
        public static unsafe void UniformMatrix2x3f(int location, bool transpose, in Matrix2x3 value)
        {
            int count = 1;
            fixed (Matrix2x3* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                UniformMatrix2x3fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix2x3fv"/>
        public static unsafe void UniformMatrix2x3f(int location, int count, bool transpose, ReadOnlySpan<Matrix2x3> value)
        {
            fixed (Matrix2x3* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                UniformMatrix2x3fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix2x3fv"/>
        public static unsafe void UniformMatrix2x3f(int location, int count, bool transpose, Matrix2x3[] value)
        {
            fixed (Matrix2x3* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                UniformMatrix2x3fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix3x2fv"/>
        public static unsafe void UniformMatrix3x2f(int location, bool transpose, in Matrix3x2 value)
        {
            int count = 1;
            fixed (Matrix3x2* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                UniformMatrix3x2fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix3x2fv"/>
        public static unsafe void UniformMatrix3x2f(int location, int count, bool transpose, ReadOnlySpan<Matrix3x2> value)
        {
            fixed (Matrix3x2* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                UniformMatrix3x2fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix3x2fv"/>
        public static unsafe void UniformMatrix3x2f(int location, int count, bool transpose, Matrix3x2[] value)
        {
            fixed (Matrix3x2* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                UniformMatrix3x2fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix2x4fv"/>
        public static unsafe void UniformMatrix2x4f(int location, bool transpose, in Matrix2x4 value)
        {
            int count = 1;
            fixed (Matrix2x4* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                UniformMatrix2x4fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix2x4fv"/>
        public static unsafe void UniformMatrix2x4f(int location, int count, bool transpose, ReadOnlySpan<Matrix2x4> value)
        {
            fixed (Matrix2x4* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                UniformMatrix2x4fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix2x4fv"/>
        public static unsafe void UniformMatrix2x4f(int location, int count, bool transpose, Matrix2x4[] value)
        {
            fixed (Matrix2x4* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                UniformMatrix2x4fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix4x2fv"/>
        public static unsafe void UniformMatrix4x2f(int location, bool transpose, in Matrix4x2 value)
        {
            int count = 1;
            fixed (Matrix4x2* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                UniformMatrix4x2fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix4x2fv"/>
        public static unsafe void UniformMatrix4x2f(int location, int count, bool transpose, ReadOnlySpan<Matrix4x2> value)
        {
            fixed (Matrix4x2* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                UniformMatrix4x2fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix4x2fv"/>
        public static unsafe void UniformMatrix4x2f(int location, int count, bool transpose, Matrix4x2[] value)
        {
            fixed (Matrix4x2* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                UniformMatrix4x2fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix3x4fv"/>
        public static unsafe void UniformMatrix3x4f(int location, bool transpose, in Matrix3x4 value)
        {
            int count = 1;
            fixed (Matrix3x4* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                UniformMatrix3x4fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix3x4fv"/>
        public static unsafe void UniformMatrix3x4f(int location, int count, bool transpose, ReadOnlySpan<Matrix3x4> value)
        {
            fixed (Matrix3x4* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                UniformMatrix3x4fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix3x4fv"/>
        public static unsafe void UniformMatrix3x4f(int location, int count, bool transpose, Matrix3x4[] value)
        {
            fixed (Matrix3x4* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                UniformMatrix3x4fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix4x3fv"/>
        public static unsafe void UniformMatrix4x3f(int location, bool transpose, in Matrix4x3 value)
        {
            int count = 1;
            fixed (Matrix4x3* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                UniformMatrix4x3fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix4x3fv"/>
        public static unsafe void UniformMatrix4x3f(int location, int count, bool transpose, ReadOnlySpan<Matrix4x3> value)
        {
            fixed (Matrix4x3* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                UniformMatrix4x3fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="UniformMatrix4x3fv"/>
        public static unsafe void UniformMatrix4x3f(int location, int count, bool transpose, Matrix4x3[] value)
        {
            fixed (Matrix4x3* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                UniformMatrix4x3fv(location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="DeleteVertexArrays"/>
        public static unsafe void DeleteVertexArray(in VertexArrayHandle array)
        {
            int n = 1;
            fixed(VertexArrayHandle* arrays_handle = &array)
            {
                DeleteVertexArrays(n, arrays_handle);
            }
        }
        /// <inheritdoc cref="DeleteVertexArrays"/>
        public static unsafe void DeleteVertexArrays(ReadOnlySpan<VertexArrayHandle> arrays)
        {
            int n = (int)(arrays.Length);
            fixed (VertexArrayHandle* arrays_ptr = arrays)
            {
                DeleteVertexArrays(n, arrays_ptr);
            }
        }
        /// <inheritdoc cref="DeleteVertexArrays"/>
        public static unsafe void DeleteVertexArrays(VertexArrayHandle[] arrays)
        {
            int n = (int)(arrays.Length);
            fixed (VertexArrayHandle* arrays_ptr = arrays)
            {
                DeleteVertexArrays(n, arrays_ptr);
            }
        }
        /// <inheritdoc cref="DeleteVertexArrays"/>
        public static unsafe void DeleteVertexArrays(int n, in VertexArrayHandle arrays)
        {
            fixed (VertexArrayHandle* arrays_ptr = &arrays)
            {
                DeleteVertexArrays(n, arrays_ptr);
            }
        }
        /// <inheritdoc cref="GenVertexArrays"/>
        public static unsafe VertexArrayHandle GenVertexArray()
        {
            VertexArrayHandle array;
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
            VertexArrayHandle* arrays_handle = (VertexArrayHandle*)Unsafe.AsPointer(ref array);
            GenVertexArrays(n, arrays_handle);
            return array;
        }
        /// <inheritdoc cref="GenVertexArrays"/>
        public static unsafe void GenVertexArray(out VertexArrayHandle array)
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
            VertexArrayHandle* arrays_handle = (VertexArrayHandle*)Unsafe.AsPointer(ref array);
            GenVertexArrays(n, arrays_handle);
        }
        /// <inheritdoc cref="GenVertexArrays"/>
        public static unsafe void GenVertexArrays(Span<VertexArrayHandle> arrays)
        {
            int n = (int)(arrays.Length);
            fixed (VertexArrayHandle* arrays_ptr = arrays)
            {
                GenVertexArrays(n, arrays_ptr);
            }
        }
        /// <inheritdoc cref="GenVertexArrays"/>
        public static unsafe void GenVertexArrays(VertexArrayHandle[] arrays)
        {
            int n = (int)(arrays.Length);
            fixed (VertexArrayHandle* arrays_ptr = arrays)
            {
                GenVertexArrays(n, arrays_ptr);
            }
        }
        /// <inheritdoc cref="GenVertexArrays"/>
        public static unsafe void GenVertexArrays(int n, ref VertexArrayHandle arrays)
        {
            fixed (VertexArrayHandle* arrays_ptr = &arrays)
            {
                GenVertexArrays(n, arrays_ptr);
            }
        }
        /// <inheritdoc cref="GetIntegeri_v"/>
        public static unsafe void GetInteger(GetPName target, uint index, Span<int> data)
        {
            fixed (int* data_ptr = data)
            {
                GetIntegeri_v(target, index, data_ptr);
            }
        }
        /// <inheritdoc cref="GetIntegeri_v"/>
        public static unsafe void GetInteger(GetPName target, uint index, int[] data)
        {
            fixed (int* data_ptr = data)
            {
                GetIntegeri_v(target, index, data_ptr);
            }
        }
        /// <inheritdoc cref="GetIntegeri_v"/>
        public static unsafe void GetInteger(GetPName target, uint index, ref int data)
        {
            fixed (int* data_ptr = &data)
            {
                GetIntegeri_v(target, index, data_ptr);
            }
        }
        /// <inheritdoc cref="GetTransformFeedbackVarying"/>
        public static unsafe string GetTransformFeedbackVarying(ProgramHandle program, uint index, int bufSize, Span<int> length, Span<int> size, Span<AttributeType> type)
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
        /// <inheritdoc cref="GetTransformFeedbackVarying"/>
        public static unsafe void GetTransformFeedbackVarying(ProgramHandle program, uint index, int bufSize, Span<int> length, Span<int> size, Span<AttributeType> type, out string name)
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
        /// <inheritdoc cref="GetTransformFeedbackVarying"/>
        public static unsafe string GetTransformFeedbackVarying(ProgramHandle program, uint index, int bufSize, int[] length, int[] size, AttributeType[] type)
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
        /// <inheritdoc cref="GetTransformFeedbackVarying"/>
        public static unsafe void GetTransformFeedbackVarying(ProgramHandle program, uint index, int bufSize, int[] length, int[] size, AttributeType[] type, out string name)
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
        /// <inheritdoc cref="GetTransformFeedbackVarying"/>
        public static unsafe string GetTransformFeedbackVarying(ProgramHandle program, uint index, int bufSize, ref int length, ref int size, ref AttributeType type)
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
        /// <inheritdoc cref="GetTransformFeedbackVarying"/>
        public static unsafe void GetTransformFeedbackVarying(ProgramHandle program, uint index, int bufSize, ref int length, ref int size, ref AttributeType type, out string name)
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
        /// <inheritdoc cref="VertexAttribIPointer"/>
        public static unsafe void VertexAttribIPointer(uint index, int size, VertexAttribIType type, int stride, nint offset)
        {
            void* pointer = (void*)offset;
            VertexAttribIPointer(index, size, type, stride, pointer);
        }
        /// <inheritdoc cref="GetVertexAttribIiv"/>
        public static unsafe void GetVertexAttribIi(uint index, VertexAttribEnum pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetVertexAttribIiv(index, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetVertexAttribIiv"/>
        public static unsafe void GetVertexAttribIi(uint index, VertexAttribEnum pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetVertexAttribIiv(index, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetVertexAttribIiv"/>
        public static unsafe void GetVertexAttribIi(uint index, VertexAttribEnum pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetVertexAttribIiv(index, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetVertexAttribIuiv"/>
        public static unsafe void GetVertexAttribIui(uint index, VertexAttribEnum pname, Span<uint> parameters)
        {
            fixed (uint* parameters_ptr = parameters)
            {
                GetVertexAttribIuiv(index, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetVertexAttribIuiv"/>
        public static unsafe void GetVertexAttribIui(uint index, VertexAttribEnum pname, uint[] parameters)
        {
            fixed (uint* parameters_ptr = parameters)
            {
                GetVertexAttribIuiv(index, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetVertexAttribIuiv"/>
        public static unsafe void GetVertexAttribIui(uint index, VertexAttribEnum pname, ref uint parameters)
        {
            fixed (uint* parameters_ptr = &parameters)
            {
                GetVertexAttribIuiv(index, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="VertexAttribI4iv"/>
        public static unsafe void VertexAttribI4iv(uint index, ReadOnlySpan<int> v)
        {
            fixed (int* v_ptr = v)
            {
                VertexAttribI4iv(index, v_ptr);
            }
        }
        /// <inheritdoc cref="VertexAttribI4iv"/>
        public static unsafe void VertexAttribI4iv(uint index, int[] v)
        {
            fixed (int* v_ptr = v)
            {
                VertexAttribI4iv(index, v_ptr);
            }
        }
        /// <inheritdoc cref="VertexAttribI4iv"/>
        public static unsafe void VertexAttribI4iv(uint index, in int v)
        {
            fixed (int* v_ptr = &v)
            {
                VertexAttribI4iv(index, v_ptr);
            }
        }
        /// <inheritdoc cref="VertexAttribI4uiv"/>
        public static unsafe void VertexAttribI4ui(uint index, ReadOnlySpan<uint> v)
        {
            fixed (uint* v_ptr = v)
            {
                VertexAttribI4uiv(index, v_ptr);
            }
        }
        /// <inheritdoc cref="VertexAttribI4uiv"/>
        public static unsafe void VertexAttribI4ui(uint index, uint[] v)
        {
            fixed (uint* v_ptr = v)
            {
                VertexAttribI4uiv(index, v_ptr);
            }
        }
        /// <inheritdoc cref="VertexAttribI4uiv"/>
        public static unsafe void VertexAttribI4ui(uint index, in uint v)
        {
            fixed (uint* v_ptr = &v)
            {
                VertexAttribI4uiv(index, v_ptr);
            }
        }
        /// <inheritdoc cref="GetUniformuiv"/>
        public static unsafe void GetUniformui(ProgramHandle program, int location, Span<uint> parameters)
        {
            fixed (uint* parameters_ptr = parameters)
            {
                GetUniformuiv(program, location, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetUniformuiv"/>
        public static unsafe void GetUniformui(ProgramHandle program, int location, uint[] parameters)
        {
            fixed (uint* parameters_ptr = parameters)
            {
                GetUniformuiv(program, location, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetUniformuiv"/>
        public static unsafe void GetUniformui(ProgramHandle program, int location, ref uint parameters)
        {
            fixed (uint* parameters_ptr = &parameters)
            {
                GetUniformuiv(program, location, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetFragDataLocation"/>
        public static unsafe int GetFragDataLocation(ProgramHandle program, string name)
        {
            int returnValue;
            byte* name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(name);
            returnValue = GetFragDataLocation(program, name_ptr);
            Marshal.FreeCoTaskMem((IntPtr)name_ptr);
            return returnValue;
        }
        /// <inheritdoc cref="Uniform1uiv"/>
        public static unsafe void Uniform1ui(int location, ReadOnlySpan<uint> value)
        {
            int count = (int)(value.Length / 1);
            fixed (uint* value_ptr = value)
            {
                Uniform1uiv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform1uiv"/>
        public static unsafe void Uniform1ui(int location, uint[] value)
        {
            int count = (int)(value.Length / 1);
            fixed (uint* value_ptr = value)
            {
                Uniform1uiv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform1uiv"/>
        public static unsafe void Uniform1ui(int location, int count, in uint value)
        {
            fixed (uint* value_ptr = &value)
            {
                Uniform1uiv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform2uiv"/>
        public static unsafe void Uniform2ui(int location, ReadOnlySpan<uint> value)
        {
            int count = (int)(value.Length / 2);
            fixed (uint* value_ptr = value)
            {
                Uniform2uiv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform2uiv"/>
        public static unsafe void Uniform2ui(int location, uint[] value)
        {
            int count = (int)(value.Length / 2);
            fixed (uint* value_ptr = value)
            {
                Uniform2uiv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform2uiv"/>
        public static unsafe void Uniform2ui(int location, int count, in uint value)
        {
            fixed (uint* value_ptr = &value)
            {
                Uniform2uiv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform3uiv"/>
        public static unsafe void Uniform3ui(int location, ReadOnlySpan<uint> value)
        {
            int count = (int)(value.Length / 3);
            fixed (uint* value_ptr = value)
            {
                Uniform3uiv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform3uiv"/>
        public static unsafe void Uniform3ui(int location, uint[] value)
        {
            int count = (int)(value.Length / 3);
            fixed (uint* value_ptr = value)
            {
                Uniform3uiv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform3uiv"/>
        public static unsafe void Uniform3ui(int location, int count, in uint value)
        {
            fixed (uint* value_ptr = &value)
            {
                Uniform3uiv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform4uiv"/>
        public static unsafe void Uniform4ui(int location, ReadOnlySpan<uint> value)
        {
            int count = (int)(value.Length / 4);
            fixed (uint* value_ptr = value)
            {
                Uniform4uiv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform4uiv"/>
        public static unsafe void Uniform4ui(int location, uint[] value)
        {
            int count = (int)(value.Length / 4);
            fixed (uint* value_ptr = value)
            {
                Uniform4uiv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="Uniform4uiv"/>
        public static unsafe void Uniform4ui(int location, int count, in uint value)
        {
            fixed (uint* value_ptr = &value)
            {
                Uniform4uiv(location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ClearBufferiv"/>
        public static unsafe void ClearBufferi(Buffer buffer, int drawbuffer, ReadOnlySpan<int> value)
        {
            fixed (int* value_ptr = value)
            {
                ClearBufferiv(buffer, drawbuffer, value_ptr);
            }
        }
        /// <inheritdoc cref="ClearBufferiv"/>
        public static unsafe void ClearBufferi(Buffer buffer, int drawbuffer, int[] value)
        {
            fixed (int* value_ptr = value)
            {
                ClearBufferiv(buffer, drawbuffer, value_ptr);
            }
        }
        /// <inheritdoc cref="ClearBufferiv"/>
        public static unsafe void ClearBufferi(Buffer buffer, int drawbuffer, in int value)
        {
            fixed (int* value_ptr = &value)
            {
                ClearBufferiv(buffer, drawbuffer, value_ptr);
            }
        }
        /// <inheritdoc cref="ClearBufferuiv"/>
        public static unsafe void ClearBufferui(Buffer buffer, int drawbuffer, ReadOnlySpan<uint> value)
        {
            fixed (uint* value_ptr = value)
            {
                ClearBufferuiv(buffer, drawbuffer, value_ptr);
            }
        }
        /// <inheritdoc cref="ClearBufferuiv"/>
        public static unsafe void ClearBufferui(Buffer buffer, int drawbuffer, uint[] value)
        {
            fixed (uint* value_ptr = value)
            {
                ClearBufferuiv(buffer, drawbuffer, value_ptr);
            }
        }
        /// <inheritdoc cref="ClearBufferuiv"/>
        public static unsafe void ClearBufferui(Buffer buffer, int drawbuffer, in uint value)
        {
            fixed (uint* value_ptr = &value)
            {
                ClearBufferuiv(buffer, drawbuffer, value_ptr);
            }
        }
        /// <inheritdoc cref="ClearBufferfv"/>
        public static unsafe void ClearBufferf(Buffer buffer, int drawbuffer, ReadOnlySpan<float> value)
        {
            fixed (float* value_ptr = value)
            {
                ClearBufferfv(buffer, drawbuffer, value_ptr);
            }
        }
        /// <inheritdoc cref="ClearBufferfv"/>
        public static unsafe void ClearBufferf(Buffer buffer, int drawbuffer, float[] value)
        {
            fixed (float* value_ptr = value)
            {
                ClearBufferfv(buffer, drawbuffer, value_ptr);
            }
        }
        /// <inheritdoc cref="ClearBufferfv"/>
        public static unsafe void ClearBufferf(Buffer buffer, int drawbuffer, in float value)
        {
            fixed (float* value_ptr = &value)
            {
                ClearBufferfv(buffer, drawbuffer, value_ptr);
            }
        }
        /// <inheritdoc cref="ClearBufferfi"/>
        public static unsafe void ClearBuffer(Buffer buffer, int drawbuffer, float depth, int stencil)
        {
            ClearBufferfi(buffer, drawbuffer, depth, stencil);
        }
        /// <inheritdoc cref="GetStringi"/>
        public static unsafe string? GetStringi(StringName name, uint index)
        {
            byte* returnValue;
            string? returnValue_str;
            returnValue = GetStringi_(name, index);
            returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
            return returnValue_str;
        }
        /// <inheritdoc cref="GetUniformIndices"/>
        public static unsafe void GetUniformIndices(ProgramHandle program, int uniformCount, byte** uniformNames, Span<uint> uniformIndices)
        {
            fixed (uint* uniformIndices_ptr = uniformIndices)
            {
                GetUniformIndices(program, uniformCount, uniformNames, uniformIndices_ptr);
            }
        }
        /// <inheritdoc cref="GetUniformIndices"/>
        public static unsafe void GetUniformIndices(ProgramHandle program, int uniformCount, byte** uniformNames, uint[] uniformIndices)
        {
            fixed (uint* uniformIndices_ptr = uniformIndices)
            {
                GetUniformIndices(program, uniformCount, uniformNames, uniformIndices_ptr);
            }
        }
        /// <inheritdoc cref="GetUniformIndices"/>
        public static unsafe void GetUniformIndices(ProgramHandle program, int uniformCount, byte** uniformNames, ref uint uniformIndices)
        {
            fixed (uint* uniformIndices_ptr = &uniformIndices)
            {
                GetUniformIndices(program, uniformCount, uniformNames, uniformIndices_ptr);
            }
        }
        /// <inheritdoc cref="GetActiveUniformsiv"/>
        public static unsafe void GetActiveUniformsi(ProgramHandle program, ReadOnlySpan<uint> uniformIndices, UniformPName pname, Span<int> parameters)
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
        /// <inheritdoc cref="GetActiveUniformsiv"/>
        public static unsafe void GetActiveUniformsi(ProgramHandle program, uint[] uniformIndices, UniformPName pname, int[] parameters)
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
        /// <inheritdoc cref="GetActiveUniformsiv"/>
        public static unsafe void GetActiveUniformsi(ProgramHandle program, int uniformCount, in uint uniformIndices, UniformPName pname, ref int parameters)
        {
            fixed (uint* uniformIndices_ptr = &uniformIndices)
            fixed (int* parameters_ptr = &parameters)
            {
                GetActiveUniformsiv(program, uniformCount, uniformIndices_ptr, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetUniformBlockIndex"/>
        public static unsafe uint GetUniformBlockIndex(ProgramHandle program, string uniformBlockName)
        {
            uint returnValue;
            byte* uniformBlockName_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(uniformBlockName);
            returnValue = GetUniformBlockIndex(program, uniformBlockName_ptr);
            Marshal.FreeCoTaskMem((IntPtr)uniformBlockName_ptr);
            return returnValue;
        }
        /// <inheritdoc cref="GetActiveUniformBlockiv"/>
        public static unsafe void GetActiveUniformBlocki(ProgramHandle program, uint uniformBlockIndex, UniformBlockPName pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetActiveUniformBlockiv(program, uniformBlockIndex, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetActiveUniformBlockiv"/>
        public static unsafe void GetActiveUniformBlocki(ProgramHandle program, uint uniformBlockIndex, UniformBlockPName pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetActiveUniformBlockiv(program, uniformBlockIndex, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetActiveUniformBlockiv"/>
        public static unsafe void GetActiveUniformBlocki(ProgramHandle program, uint uniformBlockIndex, UniformBlockPName pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetActiveUniformBlockiv(program, uniformBlockIndex, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetActiveUniformBlockName"/>
        public static unsafe string GetActiveUniformBlockName(ProgramHandle program, uint uniformBlockIndex, int bufSize, Span<int> length)
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
        /// <inheritdoc cref="GetActiveUniformBlockName"/>
        public static unsafe void GetActiveUniformBlockName(ProgramHandle program, uint uniformBlockIndex, int bufSize, Span<int> length, out string uniformBlockName)
        {
            fixed (int* length_ptr = length)
            {
                var uniformBlockName_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length_ptr, uniformBlockName_ptr);
                uniformBlockName = Marshal.PtrToStringUTF8((IntPtr)uniformBlockName_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)uniformBlockName_ptr);
            }
        }
        /// <inheritdoc cref="GetActiveUniformBlockName"/>
        public static unsafe string GetActiveUniformBlockName(ProgramHandle program, uint uniformBlockIndex, int bufSize, int[] length)
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
        /// <inheritdoc cref="GetActiveUniformBlockName"/>
        public static unsafe void GetActiveUniformBlockName(ProgramHandle program, uint uniformBlockIndex, int bufSize, int[] length, out string uniformBlockName)
        {
            fixed (int* length_ptr = length)
            {
                var uniformBlockName_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length_ptr, uniformBlockName_ptr);
                uniformBlockName = Marshal.PtrToStringUTF8((IntPtr)uniformBlockName_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)uniformBlockName_ptr);
            }
        }
        /// <inheritdoc cref="GetActiveUniformBlockName"/>
        public static unsafe string GetActiveUniformBlockName(ProgramHandle program, uint uniformBlockIndex, int bufSize, ref int length)
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
        /// <inheritdoc cref="GetActiveUniformBlockName"/>
        public static unsafe void GetActiveUniformBlockName(ProgramHandle program, uint uniformBlockIndex, int bufSize, ref int length, out string uniformBlockName)
        {
            fixed (int* length_ptr = &length)
            {
                var uniformBlockName_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length_ptr, uniformBlockName_ptr);
                uniformBlockName = Marshal.PtrToStringUTF8((IntPtr)uniformBlockName_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)uniformBlockName_ptr);
            }
        }
        /// <inheritdoc cref="DrawElementsInstanced"/>
        public static unsafe void DrawElementsInstanced(PrimitiveType mode, int count, DrawElementsType type, nint offset, int instancecount)
        {
            void* indices = (void*)offset;
            DrawElementsInstanced(mode, count, type, indices, instancecount);
        }
        /// <inheritdoc cref="GetInteger64v"/>
        public static unsafe void GetInteger64(GetPName pname, Span<long> data)
        {
            fixed (long* data_ptr = data)
            {
                GetInteger64v(pname, data_ptr);
            }
        }
        /// <inheritdoc cref="GetInteger64v"/>
        public static unsafe void GetInteger64(GetPName pname, long[] data)
        {
            fixed (long* data_ptr = data)
            {
                GetInteger64v(pname, data_ptr);
            }
        }
        /// <inheritdoc cref="GetInteger64v"/>
        public static unsafe void GetInteger64(GetPName pname, ref long data)
        {
            fixed (long* data_ptr = &data)
            {
                GetInteger64v(pname, data_ptr);
            }
        }
        /// <inheritdoc cref="GetSynciv"/>
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
        /// <inheritdoc cref="GetSynciv"/>
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
        /// <inheritdoc cref="GetSynciv"/>
        public static unsafe void GetSynci(GLSync sync, SyncParameterName pname, int count, ref int length, ref int values)
        {
            fixed (int* length_ptr = &length)
            fixed (int* values_ptr = &values)
            {
                GetSynciv(sync, pname, count, length_ptr, values_ptr);
            }
        }
        /// <inheritdoc cref="GetInteger64i_v"/>
        public static unsafe void GetInteger64(GetPName target, uint index, Span<long> data)
        {
            fixed (long* data_ptr = data)
            {
                GetInteger64i_v(target, index, data_ptr);
            }
        }
        /// <inheritdoc cref="GetInteger64i_v"/>
        public static unsafe void GetInteger64(GetPName target, uint index, long[] data)
        {
            fixed (long* data_ptr = data)
            {
                GetInteger64i_v(target, index, data_ptr);
            }
        }
        /// <inheritdoc cref="GetInteger64i_v"/>
        public static unsafe void GetInteger64(GetPName target, uint index, ref long data)
        {
            fixed (long* data_ptr = &data)
            {
                GetInteger64i_v(target, index, data_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferParameteri64v"/>
        public static unsafe void GetBufferParameteri64(BufferTargetARB target, BufferPNameARB pname, Span<long> parameters)
        {
            fixed (long* parameters_ptr = parameters)
            {
                GetBufferParameteri64v(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferParameteri64v"/>
        public static unsafe void GetBufferParameteri64(BufferTargetARB target, BufferPNameARB pname, long[] parameters)
        {
            fixed (long* parameters_ptr = parameters)
            {
                GetBufferParameteri64v(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferParameteri64v"/>
        public static unsafe void GetBufferParameteri64(BufferTargetARB target, BufferPNameARB pname, ref long parameters)
        {
            fixed (long* parameters_ptr = &parameters)
            {
                GetBufferParameteri64v(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GenSamplers"/>
        public static unsafe SamplerHandle GenSampler()
        {
            SamplerHandle sampler;
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
            SamplerHandle* samplers_handle = (SamplerHandle*)Unsafe.AsPointer(ref sampler);
            GenSamplers(count, samplers_handle);
            return sampler;
        }
        /// <inheritdoc cref="GenSamplers"/>
        public static unsafe void GenSampler(out SamplerHandle sampler)
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
            SamplerHandle* samplers_handle = (SamplerHandle*)Unsafe.AsPointer(ref sampler);
            GenSamplers(count, samplers_handle);
        }
        /// <inheritdoc cref="GenSamplers"/>
        public static unsafe void GenSamplers(Span<SamplerHandle> samplers)
        {
            int count = (int)(samplers.Length);
            fixed (SamplerHandle* samplers_ptr = samplers)
            {
                GenSamplers(count, samplers_ptr);
            }
        }
        /// <inheritdoc cref="GenSamplers"/>
        public static unsafe void GenSamplers(SamplerHandle[] samplers)
        {
            int count = (int)(samplers.Length);
            fixed (SamplerHandle* samplers_ptr = samplers)
            {
                GenSamplers(count, samplers_ptr);
            }
        }
        /// <inheritdoc cref="GenSamplers"/>
        public static unsafe void GenSamplers(int count, ref SamplerHandle samplers)
        {
            fixed (SamplerHandle* samplers_ptr = &samplers)
            {
                GenSamplers(count, samplers_ptr);
            }
        }
        /// <inheritdoc cref="DeleteSamplers"/>
        public static unsafe void DeleteSampler(in SamplerHandle sampler)
        {
            int count = 1;
            fixed(SamplerHandle* samplers_handle = &sampler)
            {
                DeleteSamplers(count, samplers_handle);
            }
        }
        /// <inheritdoc cref="DeleteSamplers"/>
        public static unsafe void DeleteSamplers(ReadOnlySpan<SamplerHandle> samplers)
        {
            int count = (int)(samplers.Length);
            fixed (SamplerHandle* samplers_ptr = samplers)
            {
                DeleteSamplers(count, samplers_ptr);
            }
        }
        /// <inheritdoc cref="DeleteSamplers"/>
        public static unsafe void DeleteSamplers(SamplerHandle[] samplers)
        {
            int count = (int)(samplers.Length);
            fixed (SamplerHandle* samplers_ptr = samplers)
            {
                DeleteSamplers(count, samplers_ptr);
            }
        }
        /// <inheritdoc cref="DeleteSamplers"/>
        public static unsafe void DeleteSamplers(int count, in SamplerHandle samplers)
        {
            fixed (SamplerHandle* samplers_ptr = &samplers)
            {
                DeleteSamplers(count, samplers_ptr);
            }
        }
        /// <inheritdoc cref="SamplerParameteriv"/>
        public static unsafe void SamplerParameteri(SamplerHandle sampler, SamplerParameterI pname, ReadOnlySpan<int> param)
        {
            fixed (int* param_ptr = param)
            {
                SamplerParameteriv(sampler, pname, param_ptr);
            }
        }
        /// <inheritdoc cref="SamplerParameteriv"/>
        public static unsafe void SamplerParameteri(SamplerHandle sampler, SamplerParameterI pname, int[] param)
        {
            fixed (int* param_ptr = param)
            {
                SamplerParameteriv(sampler, pname, param_ptr);
            }
        }
        /// <inheritdoc cref="SamplerParameteriv"/>
        public static unsafe void SamplerParameteri(SamplerHandle sampler, SamplerParameterI pname, in int param)
        {
            fixed (int* param_ptr = &param)
            {
                SamplerParameteriv(sampler, pname, param_ptr);
            }
        }
        /// <inheritdoc cref="SamplerParameterfv"/>
        public static unsafe void SamplerParameterf(SamplerHandle sampler, SamplerParameterF pname, ReadOnlySpan<float> param)
        {
            fixed (float* param_ptr = param)
            {
                SamplerParameterfv(sampler, pname, param_ptr);
            }
        }
        /// <inheritdoc cref="SamplerParameterfv"/>
        public static unsafe void SamplerParameterf(SamplerHandle sampler, SamplerParameterF pname, float[] param)
        {
            fixed (float* param_ptr = param)
            {
                SamplerParameterfv(sampler, pname, param_ptr);
            }
        }
        /// <inheritdoc cref="SamplerParameterfv"/>
        public static unsafe void SamplerParameterf(SamplerHandle sampler, SamplerParameterF pname, in float param)
        {
            fixed (float* param_ptr = &param)
            {
                SamplerParameterfv(sampler, pname, param_ptr);
            }
        }
        /// <inheritdoc cref="GetSamplerParameteriv"/>
        public static unsafe void GetSamplerParameteri(SamplerHandle sampler, SamplerParameterI pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetSamplerParameteriv(sampler, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetSamplerParameteriv"/>
        public static unsafe void GetSamplerParameteri(SamplerHandle sampler, SamplerParameterI pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetSamplerParameteriv(sampler, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetSamplerParameteriv"/>
        public static unsafe void GetSamplerParameteri(SamplerHandle sampler, SamplerParameterI pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetSamplerParameteriv(sampler, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetSamplerParameterfv"/>
        public static unsafe void GetSamplerParameterf(SamplerHandle sampler, SamplerParameterF pname, Span<float> parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetSamplerParameterfv(sampler, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetSamplerParameterfv"/>
        public static unsafe void GetSamplerParameterf(SamplerHandle sampler, SamplerParameterF pname, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetSamplerParameterfv(sampler, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetSamplerParameterfv"/>
        public static unsafe void GetSamplerParameterf(SamplerHandle sampler, SamplerParameterF pname, ref float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                GetSamplerParameterfv(sampler, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="DeleteTransformFeedbacks"/>
        public static unsafe void DeleteTransformFeedback(in TransformFeedbackHandle id)
        {
            int n = 1;
            fixed(TransformFeedbackHandle* ids_handle = &id)
            {
                DeleteTransformFeedbacks(n, ids_handle);
            }
        }
        /// <inheritdoc cref="DeleteTransformFeedbacks"/>
        public static unsafe void DeleteTransformFeedbacks(ReadOnlySpan<TransformFeedbackHandle> ids)
        {
            int n = (int)(ids.Length);
            fixed (TransformFeedbackHandle* ids_ptr = ids)
            {
                DeleteTransformFeedbacks(n, ids_ptr);
            }
        }
        /// <inheritdoc cref="DeleteTransformFeedbacks"/>
        public static unsafe void DeleteTransformFeedbacks(TransformFeedbackHandle[] ids)
        {
            int n = (int)(ids.Length);
            fixed (TransformFeedbackHandle* ids_ptr = ids)
            {
                DeleteTransformFeedbacks(n, ids_ptr);
            }
        }
        /// <inheritdoc cref="DeleteTransformFeedbacks"/>
        public static unsafe void DeleteTransformFeedbacks(int n, in TransformFeedbackHandle ids)
        {
            fixed (TransformFeedbackHandle* ids_ptr = &ids)
            {
                DeleteTransformFeedbacks(n, ids_ptr);
            }
        }
        /// <inheritdoc cref="GenTransformFeedbacks"/>
        public static unsafe TransformFeedbackHandle GenTransformFeedback()
        {
            TransformFeedbackHandle id;
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
            TransformFeedbackHandle* ids_handle = (TransformFeedbackHandle*)Unsafe.AsPointer(ref id);
            GenTransformFeedbacks(n, ids_handle);
            return id;
        }
        /// <inheritdoc cref="GenTransformFeedbacks"/>
        public static unsafe void GenTransformFeedback(out TransformFeedbackHandle id)
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
            TransformFeedbackHandle* ids_handle = (TransformFeedbackHandle*)Unsafe.AsPointer(ref id);
            GenTransformFeedbacks(n, ids_handle);
        }
        /// <inheritdoc cref="GenTransformFeedbacks"/>
        public static unsafe void GenTransformFeedbacks(Span<TransformFeedbackHandle> ids)
        {
            int n = (int)(ids.Length);
            fixed (TransformFeedbackHandle* ids_ptr = ids)
            {
                GenTransformFeedbacks(n, ids_ptr);
            }
        }
        /// <inheritdoc cref="GenTransformFeedbacks"/>
        public static unsafe void GenTransformFeedbacks(TransformFeedbackHandle[] ids)
        {
            int n = (int)(ids.Length);
            fixed (TransformFeedbackHandle* ids_ptr = ids)
            {
                GenTransformFeedbacks(n, ids_ptr);
            }
        }
        /// <inheritdoc cref="GenTransformFeedbacks"/>
        public static unsafe void GenTransformFeedbacks(int n, ref TransformFeedbackHandle ids)
        {
            fixed (TransformFeedbackHandle* ids_ptr = &ids)
            {
                GenTransformFeedbacks(n, ids_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramBinary"/>
        public static unsafe void GetProgramBinary(ProgramHandle program, int bufSize, Span<int> length, Span<All> binaryFormat, IntPtr binary)
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
        /// <inheritdoc cref="GetProgramBinary"/>
        public static unsafe void GetProgramBinary(ProgramHandle program, int bufSize, int[] length, All[] binaryFormat, IntPtr binary)
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
        /// <inheritdoc cref="GetProgramBinary"/>
        public static unsafe void GetProgramBinary(ProgramHandle program, int bufSize, ref int length, ref All binaryFormat, IntPtr binary)
        {
            fixed (int* length_ptr = &length)
            fixed (All* binaryFormat_ptr = &binaryFormat)
            {
                void* binary_vptr = (void*)binary;
                GetProgramBinary(program, bufSize, length_ptr, binaryFormat_ptr, binary_vptr);
            }
        }
        /// <inheritdoc cref="GetProgramBinary"/>
        public static unsafe void GetProgramBinary<T1>(ProgramHandle program, Span<int> length, Span<All> binaryFormat, Span<T1> binary)
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
        /// <inheritdoc cref="GetProgramBinary"/>
        public static unsafe void GetProgramBinary<T1>(ProgramHandle program, int[] length, All[] binaryFormat, T1[] binary)
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
        /// <inheritdoc cref="GetProgramBinary"/>
        public static unsafe void GetProgramBinary<T1>(ProgramHandle program, int bufSize, ref int length, ref All binaryFormat, ref T1 binary)
            where T1 : unmanaged
        {
            fixed (int* length_ptr = &length)
            fixed (All* binaryFormat_ptr = &binaryFormat)
            fixed (void* binary_ptr = &binary)
            {
                GetProgramBinary(program, bufSize, length_ptr, binaryFormat_ptr, binary_ptr);
            }
        }
        /// <inheritdoc cref="ProgramBinary"/>
        public static unsafe void ProgramBinary(ProgramHandle program, All binaryFormat, IntPtr binary, int length)
        {
            void* binary_vptr = (void*)binary;
            ProgramBinary(program, binaryFormat, binary_vptr, length);
        }
        /// <inheritdoc cref="ProgramBinary"/>
        public static unsafe void ProgramBinary<T1>(ProgramHandle program, All binaryFormat, ReadOnlySpan<T1> binary)
            where T1 : unmanaged
        {
            int length = (int)(binary.Length * sizeof(T1));
            fixed (void* binary_ptr = binary)
            {
                ProgramBinary(program, binaryFormat, binary_ptr, length);
            }
        }
        /// <inheritdoc cref="ProgramBinary"/>
        public static unsafe void ProgramBinary<T1>(ProgramHandle program, All binaryFormat, T1[] binary)
            where T1 : unmanaged
        {
            int length = (int)(binary.Length * sizeof(T1));
            fixed (void* binary_ptr = binary)
            {
                ProgramBinary(program, binaryFormat, binary_ptr, length);
            }
        }
        /// <inheritdoc cref="ProgramBinary"/>
        public static unsafe void ProgramBinary<T1>(ProgramHandle program, All binaryFormat, in T1 binary, int length)
            where T1 : unmanaged
        {
            fixed (void* binary_ptr = &binary)
            {
                ProgramBinary(program, binaryFormat, binary_ptr, length);
            }
        }
        /// <inheritdoc cref="InvalidateFramebuffer"/>
        public static unsafe void InvalidateFramebuffer(FramebufferTarget target, ReadOnlySpan<InvalidateFramebufferAttachment> attachments)
        {
            int numAttachments = (int)(attachments.Length);
            fixed (InvalidateFramebufferAttachment* attachments_ptr = attachments)
            {
                InvalidateFramebuffer(target, numAttachments, attachments_ptr);
            }
        }
        /// <inheritdoc cref="InvalidateFramebuffer"/>
        public static unsafe void InvalidateFramebuffer(FramebufferTarget target, InvalidateFramebufferAttachment[] attachments)
        {
            int numAttachments = (int)(attachments.Length);
            fixed (InvalidateFramebufferAttachment* attachments_ptr = attachments)
            {
                InvalidateFramebuffer(target, numAttachments, attachments_ptr);
            }
        }
        /// <inheritdoc cref="InvalidateFramebuffer"/>
        public static unsafe void InvalidateFramebuffer(FramebufferTarget target, int numAttachments, in InvalidateFramebufferAttachment attachments)
        {
            fixed (InvalidateFramebufferAttachment* attachments_ptr = &attachments)
            {
                InvalidateFramebuffer(target, numAttachments, attachments_ptr);
            }
        }
        /// <inheritdoc cref="InvalidateSubFramebuffer"/>
        public static unsafe void InvalidateSubFramebuffer(FramebufferTarget target, ReadOnlySpan<InvalidateFramebufferAttachment> attachments, int x, int y, int width, int height)
        {
            int numAttachments = (int)(attachments.Length);
            fixed (InvalidateFramebufferAttachment* attachments_ptr = attachments)
            {
                InvalidateSubFramebuffer(target, numAttachments, attachments_ptr, x, y, width, height);
            }
        }
        /// <inheritdoc cref="InvalidateSubFramebuffer"/>
        public static unsafe void InvalidateSubFramebuffer(FramebufferTarget target, InvalidateFramebufferAttachment[] attachments, int x, int y, int width, int height)
        {
            int numAttachments = (int)(attachments.Length);
            fixed (InvalidateFramebufferAttachment* attachments_ptr = attachments)
            {
                InvalidateSubFramebuffer(target, numAttachments, attachments_ptr, x, y, width, height);
            }
        }
        /// <inheritdoc cref="InvalidateSubFramebuffer"/>
        public static unsafe void InvalidateSubFramebuffer(FramebufferTarget target, int numAttachments, in InvalidateFramebufferAttachment attachments, int x, int y, int width, int height)
        {
            fixed (InvalidateFramebufferAttachment* attachments_ptr = &attachments)
            {
                InvalidateSubFramebuffer(target, numAttachments, attachments_ptr, x, y, width, height);
            }
        }
        /// <inheritdoc cref="GetInternalformativ"/>
        public static unsafe void GetInternalformati(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, Span<int> parameters)
        {
            int count = (int)(parameters.Length);
            fixed (int* parameters_ptr = parameters)
            {
                GetInternalformativ(target, internalformat, pname, count, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetInternalformativ"/>
        public static unsafe void GetInternalformati(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, int[] parameters)
        {
            int count = (int)(parameters.Length);
            fixed (int* parameters_ptr = parameters)
            {
                GetInternalformativ(target, internalformat, pname, count, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetInternalformativ"/>
        public static unsafe void GetInternalformati(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, int count, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetInternalformativ(target, internalformat, pname, count, parameters_ptr);
            }
        }
        /// <inheritdoc cref="DrawArraysIndirect"/>
        public static unsafe void DrawArraysIndirect(PrimitiveType mode, IntPtr indirect)
        {
            void* indirect_vptr = (void*)indirect;
            DrawArraysIndirect(mode, indirect_vptr);
        }
        /// <inheritdoc cref="DrawArraysIndirect"/>
        public static unsafe void DrawArraysIndirect<T1>(PrimitiveType mode, in T1 indirect)
            where T1 : unmanaged
        {
            fixed (void* indirect_ptr = &indirect)
            {
                DrawArraysIndirect(mode, indirect_ptr);
            }
        }
        /// <inheritdoc cref="DrawElementsIndirect"/>
        public static unsafe void DrawElementsIndirect(PrimitiveType mode, DrawElementsType type, IntPtr indirect)
        {
            void* indirect_vptr = (void*)indirect;
            DrawElementsIndirect(mode, type, indirect_vptr);
        }
        /// <inheritdoc cref="DrawElementsIndirect"/>
        public static unsafe void DrawElementsIndirect<T1>(PrimitiveType mode, DrawElementsType type, in T1 indirect)
            where T1 : unmanaged
        {
            fixed (void* indirect_ptr = &indirect)
            {
                DrawElementsIndirect(mode, type, indirect_ptr);
            }
        }
        /// <inheritdoc cref="GetFramebufferParameteriv"/>
        public static unsafe void GetFramebufferParameteri(FramebufferTarget target, FramebufferAttachmentParameterName pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetFramebufferParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetFramebufferParameteriv"/>
        public static unsafe void GetFramebufferParameteri(FramebufferTarget target, FramebufferAttachmentParameterName pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetFramebufferParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetFramebufferParameteriv"/>
        public static unsafe void GetFramebufferParameteri(FramebufferTarget target, FramebufferAttachmentParameterName pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetFramebufferParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramInterfaceiv"/>
        public static unsafe void GetProgramInterfacei(ProgramHandle program, ProgramInterface programInterface, ProgramInterfacePName pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetProgramInterfaceiv(program, programInterface, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramInterfaceiv"/>
        public static unsafe void GetProgramInterfacei(ProgramHandle program, ProgramInterface programInterface, ProgramInterfacePName pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetProgramInterfaceiv(program, programInterface, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramInterfaceiv"/>
        public static unsafe void GetProgramInterfacei(ProgramHandle program, ProgramInterface programInterface, ProgramInterfacePName pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetProgramInterfaceiv(program, programInterface, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramResourceIndex"/>
        public static unsafe uint GetProgramResourceIndex(ProgramHandle program, ProgramInterface programInterface, string name)
        {
            uint returnValue;
            byte* name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(name);
            returnValue = GetProgramResourceIndex(program, programInterface, name_ptr);
            Marshal.FreeCoTaskMem((IntPtr)name_ptr);
            return returnValue;
        }
        /// <inheritdoc cref="GetProgramResourceName"/>
        public static unsafe string GetProgramResourceName(ProgramHandle program, ProgramInterface programInterface, uint index, int bufSize, Span<int> length)
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
        /// <inheritdoc cref="GetProgramResourceName"/>
        public static unsafe void GetProgramResourceName(ProgramHandle program, ProgramInterface programInterface, uint index, int bufSize, Span<int> length, out string name)
        {
            fixed (int* length_ptr = length)
            {
                var name_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetProgramResourceName(program, programInterface, index, bufSize, length_ptr, name_ptr);
                name = Marshal.PtrToStringUTF8((IntPtr)name_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)name_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramResourceName"/>
        public static unsafe string GetProgramResourceName(ProgramHandle program, ProgramInterface programInterface, uint index, int bufSize, int[] length)
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
        /// <inheritdoc cref="GetProgramResourceName"/>
        public static unsafe void GetProgramResourceName(ProgramHandle program, ProgramInterface programInterface, uint index, int bufSize, int[] length, out string name)
        {
            fixed (int* length_ptr = length)
            {
                var name_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetProgramResourceName(program, programInterface, index, bufSize, length_ptr, name_ptr);
                name = Marshal.PtrToStringUTF8((IntPtr)name_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)name_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramResourceName"/>
        public static unsafe string GetProgramResourceName(ProgramHandle program, ProgramInterface programInterface, uint index, int bufSize, ref int length)
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
        /// <inheritdoc cref="GetProgramResourceName"/>
        public static unsafe void GetProgramResourceName(ProgramHandle program, ProgramInterface programInterface, uint index, int bufSize, ref int length, out string name)
        {
            fixed (int* length_ptr = &length)
            {
                var name_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetProgramResourceName(program, programInterface, index, bufSize, length_ptr, name_ptr);
                name = Marshal.PtrToStringUTF8((IntPtr)name_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)name_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramResourceiv"/>
        public static unsafe void GetProgramResourcei(ProgramHandle program, ProgramInterface programInterface, uint index, ReadOnlySpan<ProgramResourceProperty> props, Span<int> length, Span<int> parameters)
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
        /// <inheritdoc cref="GetProgramResourceiv"/>
        public static unsafe void GetProgramResourcei(ProgramHandle program, ProgramInterface programInterface, uint index, ProgramResourceProperty[] props, int[] length, int[] parameters)
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
        /// <inheritdoc cref="GetProgramResourceiv"/>
        public static unsafe void GetProgramResourcei(ProgramHandle program, ProgramInterface programInterface, uint index, int propCount, in ProgramResourceProperty props, int count, ref int length, ref int parameters)
        {
            fixed (ProgramResourceProperty* props_ptr = &props)
            fixed (int* length_ptr = &length)
            fixed (int* parameters_ptr = &parameters)
            {
                GetProgramResourceiv(program, programInterface, index, propCount, props_ptr, count, length_ptr, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramResourceLocation"/>
        public static unsafe int GetProgramResourceLocation(ProgramHandle program, ProgramInterface programInterface, string name)
        {
            int returnValue;
            byte* name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(name);
            returnValue = GetProgramResourceLocation(program, programInterface, name_ptr);
            Marshal.FreeCoTaskMem((IntPtr)name_ptr);
            return returnValue;
        }
        /// <inheritdoc cref="CreateShaderProgramv"/>
        public static unsafe ProgramHandle CreateShaderProgram(ShaderType type, int count, byte** strings)
        {
            ProgramHandle returnValue;
            returnValue = CreateShaderProgramv(type, count, strings);
            return returnValue;
        }
        /// <inheritdoc cref="DeleteProgramPipelines"/>
        public static unsafe void DeleteProgramPipeline(in ProgramPipelineHandle pipeline)
        {
            int n = 1;
            fixed(ProgramPipelineHandle* pipelines_handle = &pipeline)
            {
                DeleteProgramPipelines(n, pipelines_handle);
            }
        }
        /// <inheritdoc cref="DeleteProgramPipelines"/>
        public static unsafe void DeleteProgramPipelines(ReadOnlySpan<ProgramPipelineHandle> pipelines)
        {
            int n = (int)(pipelines.Length);
            fixed (ProgramPipelineHandle* pipelines_ptr = pipelines)
            {
                DeleteProgramPipelines(n, pipelines_ptr);
            }
        }
        /// <inheritdoc cref="DeleteProgramPipelines"/>
        public static unsafe void DeleteProgramPipelines(ProgramPipelineHandle[] pipelines)
        {
            int n = (int)(pipelines.Length);
            fixed (ProgramPipelineHandle* pipelines_ptr = pipelines)
            {
                DeleteProgramPipelines(n, pipelines_ptr);
            }
        }
        /// <inheritdoc cref="DeleteProgramPipelines"/>
        public static unsafe void DeleteProgramPipelines(int n, in ProgramPipelineHandle pipelines)
        {
            fixed (ProgramPipelineHandle* pipelines_ptr = &pipelines)
            {
                DeleteProgramPipelines(n, pipelines_ptr);
            }
        }
        /// <inheritdoc cref="GenProgramPipelines"/>
        public static unsafe ProgramPipelineHandle GenProgramPipeline()
        {
            ProgramPipelineHandle pipeline;
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
            ProgramPipelineHandle* pipelines_handle = (ProgramPipelineHandle*)Unsafe.AsPointer(ref pipeline);
            GenProgramPipelines(n, pipelines_handle);
            return pipeline;
        }
        /// <inheritdoc cref="GenProgramPipelines"/>
        public static unsafe void GenProgramPipeline(out ProgramPipelineHandle pipeline)
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
            ProgramPipelineHandle* pipelines_handle = (ProgramPipelineHandle*)Unsafe.AsPointer(ref pipeline);
            GenProgramPipelines(n, pipelines_handle);
        }
        /// <inheritdoc cref="GenProgramPipelines"/>
        public static unsafe void GenProgramPipelines(Span<ProgramPipelineHandle> pipelines)
        {
            int n = (int)(pipelines.Length);
            fixed (ProgramPipelineHandle* pipelines_ptr = pipelines)
            {
                GenProgramPipelines(n, pipelines_ptr);
            }
        }
        /// <inheritdoc cref="GenProgramPipelines"/>
        public static unsafe void GenProgramPipelines(ProgramPipelineHandle[] pipelines)
        {
            int n = (int)(pipelines.Length);
            fixed (ProgramPipelineHandle* pipelines_ptr = pipelines)
            {
                GenProgramPipelines(n, pipelines_ptr);
            }
        }
        /// <inheritdoc cref="GenProgramPipelines"/>
        public static unsafe void GenProgramPipelines(int n, ref ProgramPipelineHandle pipelines)
        {
            fixed (ProgramPipelineHandle* pipelines_ptr = &pipelines)
            {
                GenProgramPipelines(n, pipelines_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramPipelineiv"/>
        public static unsafe void GetProgramPipelinei(ProgramPipelineHandle pipeline, PipelineParameterName pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetProgramPipelineiv(pipeline, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramPipelineiv"/>
        public static unsafe void GetProgramPipelinei(ProgramPipelineHandle pipeline, PipelineParameterName pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetProgramPipelineiv(pipeline, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramPipelineiv"/>
        public static unsafe void GetProgramPipelinei(ProgramPipelineHandle pipeline, PipelineParameterName pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetProgramPipelineiv(pipeline, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform1iv"/>
        public static unsafe void ProgramUniform1iv(ProgramHandle program, int location, ReadOnlySpan<int> value)
        {
            int count = (int)(value.Length);
            fixed (int* value_ptr = value)
            {
                ProgramUniform1iv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform1iv"/>
        public static unsafe void ProgramUniform1iv(ProgramHandle program, int location, int[] value)
        {
            int count = (int)(value.Length);
            fixed (int* value_ptr = value)
            {
                ProgramUniform1iv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform1iv"/>
        public static unsafe void ProgramUniform1iv(ProgramHandle program, int location, int count, in int value)
        {
            fixed (int* value_ptr = &value)
            {
                ProgramUniform1iv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform2iv"/>
        public static unsafe void ProgramUniform2i(ProgramHandle program, int location, in Vector2i value)
        {
            int count = 1;
            fixed (Vector2i* tmp_vecPtr = &value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                ProgramUniform2iv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform2iv"/>
        public static unsafe void ProgramUniform2i(ProgramHandle program, int location, int count, ReadOnlySpan<Vector2i> value)
        {
            fixed (Vector2i* tmp_vecPtr = value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                ProgramUniform2iv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform2iv"/>
        public static unsafe void ProgramUniform2i(ProgramHandle program, int location, int count, Vector2i[] value)
        {
            fixed (Vector2i* tmp_vecPtr = value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                ProgramUniform2iv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform3iv"/>
        public static unsafe void ProgramUniform3i(ProgramHandle program, int location, in Vector3i value)
        {
            int count = 1;
            fixed (Vector3i* tmp_vecPtr = &value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                ProgramUniform3iv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform3iv"/>
        public static unsafe void ProgramUniform3i(ProgramHandle program, int location, int count, ReadOnlySpan<Vector3i> value)
        {
            fixed (Vector3i* tmp_vecPtr = value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                ProgramUniform3iv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform3iv"/>
        public static unsafe void ProgramUniform3i(ProgramHandle program, int location, int count, Vector3i[] value)
        {
            fixed (Vector3i* tmp_vecPtr = value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                ProgramUniform3iv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform4iv"/>
        public static unsafe void ProgramUniform4i(ProgramHandle program, int location, in Vector4i value)
        {
            int count = 1;
            fixed (Vector4i* tmp_vecPtr = &value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                ProgramUniform4iv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform4iv"/>
        public static unsafe void ProgramUniform4i(ProgramHandle program, int location, int count, ReadOnlySpan<Vector4i> value)
        {
            fixed (Vector4i* tmp_vecPtr = value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                ProgramUniform4iv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform4iv"/>
        public static unsafe void ProgramUniform4i(ProgramHandle program, int location, int count, Vector4i[] value)
        {
            fixed (Vector4i* tmp_vecPtr = value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                ProgramUniform4iv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform1uiv"/>
        public static unsafe void ProgramUniform1ui(ProgramHandle program, int location, ReadOnlySpan<uint> value)
        {
            int count = (int)(value.Length);
            fixed (uint* value_ptr = value)
            {
                ProgramUniform1uiv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform1uiv"/>
        public static unsafe void ProgramUniform1ui(ProgramHandle program, int location, uint[] value)
        {
            int count = (int)(value.Length);
            fixed (uint* value_ptr = value)
            {
                ProgramUniform1uiv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform1uiv"/>
        public static unsafe void ProgramUniform1ui(ProgramHandle program, int location, int count, in uint value)
        {
            fixed (uint* value_ptr = &value)
            {
                ProgramUniform1uiv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform2uiv"/>
        public static unsafe void ProgramUniform2ui(ProgramHandle program, int location, ReadOnlySpan<uint> value)
        {
            int count = (int)(value.Length / 2);
            fixed (uint* value_ptr = value)
            {
                ProgramUniform2uiv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform2uiv"/>
        public static unsafe void ProgramUniform2ui(ProgramHandle program, int location, uint[] value)
        {
            int count = (int)(value.Length / 2);
            fixed (uint* value_ptr = value)
            {
                ProgramUniform2uiv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform2uiv"/>
        public static unsafe void ProgramUniform2ui(ProgramHandle program, int location, int count, in uint value)
        {
            fixed (uint* value_ptr = &value)
            {
                ProgramUniform2uiv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform3uiv"/>
        public static unsafe void ProgramUniform3ui(ProgramHandle program, int location, ReadOnlySpan<uint> value)
        {
            int count = (int)(value.Length / 3);
            fixed (uint* value_ptr = value)
            {
                ProgramUniform3uiv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform3uiv"/>
        public static unsafe void ProgramUniform3ui(ProgramHandle program, int location, uint[] value)
        {
            int count = (int)(value.Length / 3);
            fixed (uint* value_ptr = value)
            {
                ProgramUniform3uiv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform3uiv"/>
        public static unsafe void ProgramUniform3ui(ProgramHandle program, int location, int count, in uint value)
        {
            fixed (uint* value_ptr = &value)
            {
                ProgramUniform3uiv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform4uiv"/>
        public static unsafe void ProgramUniform4ui(ProgramHandle program, int location, ReadOnlySpan<uint> value)
        {
            int count = (int)(value.Length / 4);
            fixed (uint* value_ptr = value)
            {
                ProgramUniform4uiv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform4uiv"/>
        public static unsafe void ProgramUniform4ui(ProgramHandle program, int location, uint[] value)
        {
            int count = (int)(value.Length / 4);
            fixed (uint* value_ptr = value)
            {
                ProgramUniform4uiv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform4uiv"/>
        public static unsafe void ProgramUniform4ui(ProgramHandle program, int location, int count, in uint value)
        {
            fixed (uint* value_ptr = &value)
            {
                ProgramUniform4uiv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform1fv"/>
        public static unsafe void ProgramUniform1fv(ProgramHandle program, int location, ReadOnlySpan<float> value)
        {
            int count = (int)(value.Length);
            fixed (float* value_ptr = value)
            {
                ProgramUniform1fv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform1fv"/>
        public static unsafe void ProgramUniform1fv(ProgramHandle program, int location, float[] value)
        {
            int count = (int)(value.Length);
            fixed (float* value_ptr = value)
            {
                ProgramUniform1fv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform1fv"/>
        public static unsafe void ProgramUniform1fv(ProgramHandle program, int location, int count, in float value)
        {
            fixed (float* value_ptr = &value)
            {
                ProgramUniform1fv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform2fv"/>
        public static unsafe void ProgramUniform2f(ProgramHandle program, int location, in Vector2 value)
        {
            int count = 1;
            fixed (Vector2* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniform2fv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform2fv"/>
        public static unsafe void ProgramUniform2f(ProgramHandle program, int location, int count, ReadOnlySpan<Vector2> value)
        {
            fixed (Vector2* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniform2fv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform2fv"/>
        public static unsafe void ProgramUniform2f(ProgramHandle program, int location, int count, Vector2[] value)
        {
            fixed (Vector2* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniform2fv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform3fv"/>
        public static unsafe void ProgramUniform3f(ProgramHandle program, int location, in Vector3 value)
        {
            int count = 1;
            fixed (Vector3* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniform3fv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform3fv"/>
        public static unsafe void ProgramUniform3f(ProgramHandle program, int location, int count, ReadOnlySpan<Vector3> value)
        {
            fixed (Vector3* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniform3fv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform3fv"/>
        public static unsafe void ProgramUniform3f(ProgramHandle program, int location, int count, Vector3[] value)
        {
            fixed (Vector3* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniform3fv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform4fv"/>
        public static unsafe void ProgramUniform4f(ProgramHandle program, int location, in Vector4 value)
        {
            int count = 1;
            fixed (Vector4* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniform4fv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform4fv"/>
        public static unsafe void ProgramUniform4f(ProgramHandle program, int location, int count, ReadOnlySpan<Vector4> value)
        {
            fixed (Vector4* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniform4fv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniform4fv"/>
        public static unsafe void ProgramUniform4f(ProgramHandle program, int location, int count, Vector4[] value)
        {
            fixed (Vector4* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniform4fv(program, location, count, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix2fv"/>
        public static unsafe void ProgramUniformMatrix2f(ProgramHandle program, int location, bool transpose, in Matrix2 value)
        {
            int count = 1;
            fixed (Matrix2* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniformMatrix2fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix2fv"/>
        public static unsafe void ProgramUniformMatrix2f(ProgramHandle program, int location, int count, bool transpose, ReadOnlySpan<Matrix2> value)
        {
            fixed (Matrix2* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniformMatrix2fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix2fv"/>
        public static unsafe void ProgramUniformMatrix2f(ProgramHandle program, int location, int count, bool transpose, Matrix2[] value)
        {
            fixed (Matrix2* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniformMatrix2fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix3fv"/>
        public static unsafe void ProgramUniformMatrix3f(ProgramHandle program, int location, bool transpose, in Matrix3 value)
        {
            int count = 1;
            fixed (Matrix3* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniformMatrix3fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix3fv"/>
        public static unsafe void ProgramUniformMatrix3f(ProgramHandle program, int location, int count, bool transpose, ReadOnlySpan<Matrix3> value)
        {
            fixed (Matrix3* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniformMatrix3fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix3fv"/>
        public static unsafe void ProgramUniformMatrix3f(ProgramHandle program, int location, int count, bool transpose, Matrix3[] value)
        {
            fixed (Matrix3* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniformMatrix3fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix4fv"/>
        public static unsafe void ProgramUniformMatrix4f(ProgramHandle program, int location, bool transpose, in Matrix4 value)
        {
            int count = 1;
            fixed (Matrix4* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniformMatrix4fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix4fv"/>
        public static unsafe void ProgramUniformMatrix4f(ProgramHandle program, int location, int count, bool transpose, ReadOnlySpan<Matrix4> value)
        {
            fixed (Matrix4* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniformMatrix4fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix4fv"/>
        public static unsafe void ProgramUniformMatrix4f(ProgramHandle program, int location, int count, bool transpose, Matrix4[] value)
        {
            fixed (Matrix4* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniformMatrix4fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix2x3fv"/>
        public static unsafe void ProgramUniformMatrix2x3f(ProgramHandle program, int location, bool transpose, in Matrix2x3 value)
        {
            int count = 1;
            fixed (Matrix2x3* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniformMatrix2x3fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix2x3fv"/>
        public static unsafe void ProgramUniformMatrix2x3f(ProgramHandle program, int location, int count, bool transpose, ReadOnlySpan<Matrix2x3> value)
        {
            fixed (Matrix2x3* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniformMatrix2x3fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix2x3fv"/>
        public static unsafe void ProgramUniformMatrix2x3f(ProgramHandle program, int location, int count, bool transpose, Matrix2x3[] value)
        {
            fixed (Matrix2x3* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniformMatrix2x3fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix3x2fv"/>
        public static unsafe void ProgramUniformMatrix3x2f(ProgramHandle program, int location, bool transpose, in Matrix3x2 value)
        {
            int count = 1;
            fixed (Matrix3x2* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniformMatrix3x2fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix3x2fv"/>
        public static unsafe void ProgramUniformMatrix3x2f(ProgramHandle program, int location, int count, bool transpose, ReadOnlySpan<Matrix3x2> value)
        {
            fixed (Matrix3x2* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniformMatrix3x2fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix3x2fv"/>
        public static unsafe void ProgramUniformMatrix3x2f(ProgramHandle program, int location, int count, bool transpose, Matrix3x2[] value)
        {
            fixed (Matrix3x2* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniformMatrix3x2fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix2x4fv"/>
        public static unsafe void ProgramUniformMatrix2x4f(ProgramHandle program, int location, bool transpose, in Matrix2x4 value)
        {
            int count = 1;
            fixed (Matrix2x4* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniformMatrix2x4fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix2x4fv"/>
        public static unsafe void ProgramUniformMatrix2x4f(ProgramHandle program, int location, int count, bool transpose, ReadOnlySpan<Matrix2x4> value)
        {
            fixed (Matrix2x4* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniformMatrix2x4fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix2x4fv"/>
        public static unsafe void ProgramUniformMatrix2x4f(ProgramHandle program, int location, int count, bool transpose, Matrix2x4[] value)
        {
            fixed (Matrix2x4* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniformMatrix2x4fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix4x2fv"/>
        public static unsafe void ProgramUniformMatrix4x2f(ProgramHandle program, int location, bool transpose, in Matrix4x2 value)
        {
            int count = 1;
            fixed (Matrix4x2* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniformMatrix4x2fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix4x2fv"/>
        public static unsafe void ProgramUniformMatrix4x2f(ProgramHandle program, int location, int count, bool transpose, ReadOnlySpan<Matrix4x2> value)
        {
            fixed (Matrix4x2* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniformMatrix4x2fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix4x2fv"/>
        public static unsafe void ProgramUniformMatrix4x2f(ProgramHandle program, int location, int count, bool transpose, Matrix4x2[] value)
        {
            fixed (Matrix4x2* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniformMatrix4x2fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix3x4fv"/>
        public static unsafe void ProgramUniformMatrix3x4f(ProgramHandle program, int location, bool transpose, in Matrix3x4 value)
        {
            int count = 1;
            fixed (Matrix3x4* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniformMatrix3x4fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix3x4fv"/>
        public static unsafe void ProgramUniformMatrix3x4f(ProgramHandle program, int location, int count, bool transpose, ReadOnlySpan<Matrix3x4> value)
        {
            fixed (Matrix3x4* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniformMatrix3x4fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix3x4fv"/>
        public static unsafe void ProgramUniformMatrix3x4f(ProgramHandle program, int location, int count, bool transpose, Matrix3x4[] value)
        {
            fixed (Matrix3x4* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniformMatrix3x4fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix4x3fv"/>
        public static unsafe void ProgramUniformMatrix4x3f(ProgramHandle program, int location, bool transpose, in Matrix4x3 value)
        {
            int count = 1;
            fixed (Matrix4x3* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniformMatrix4x3fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix4x3fv"/>
        public static unsafe void ProgramUniformMatrix4x3f(ProgramHandle program, int location, int count, bool transpose, ReadOnlySpan<Matrix4x3> value)
        {
            fixed (Matrix4x3* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniformMatrix4x3fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="ProgramUniformMatrix4x3fv"/>
        public static unsafe void ProgramUniformMatrix4x3f(ProgramHandle program, int location, int count, bool transpose, Matrix4x3[] value)
        {
            fixed (Matrix4x3* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniformMatrix4x3fv(program, location, count, transpose, value_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramPipelineInfoLog"/>
        public static unsafe string GetProgramPipelineInfoLog(ProgramPipelineHandle pipeline, int bufSize, Span<int> length)
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
        /// <inheritdoc cref="GetProgramPipelineInfoLog"/>
        public static unsafe void GetProgramPipelineInfoLog(ProgramPipelineHandle pipeline, int bufSize, Span<int> length, out string infoLog)
        {
            fixed (int* length_ptr = length)
            {
                var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetProgramPipelineInfoLog(pipeline, bufSize, length_ptr, infoLog_ptr);
                infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramPipelineInfoLog"/>
        public static unsafe string GetProgramPipelineInfoLog(ProgramPipelineHandle pipeline, int bufSize, int[] length)
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
        /// <inheritdoc cref="GetProgramPipelineInfoLog"/>
        public static unsafe void GetProgramPipelineInfoLog(ProgramPipelineHandle pipeline, int bufSize, int[] length, out string infoLog)
        {
            fixed (int* length_ptr = length)
            {
                var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetProgramPipelineInfoLog(pipeline, bufSize, length_ptr, infoLog_ptr);
                infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
            }
        }
        /// <inheritdoc cref="GetProgramPipelineInfoLog"/>
        public static unsafe string GetProgramPipelineInfoLog(ProgramPipelineHandle pipeline, int bufSize, ref int length)
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
        /// <inheritdoc cref="GetProgramPipelineInfoLog"/>
        public static unsafe void GetProgramPipelineInfoLog(ProgramPipelineHandle pipeline, int bufSize, ref int length, out string infoLog)
        {
            fixed (int* length_ptr = &length)
            {
                var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                GetProgramPipelineInfoLog(pipeline, bufSize, length_ptr, infoLog_ptr);
                infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
            }
        }
        /// <inheritdoc cref="GetBooleani_v"/>
        public static unsafe void GetBoolean(BufferTargetARB target, uint index, Span<bool> data)
        {
            fixed (bool* data_ptr = data)
            {
                GetBooleani_v(target, index, data_ptr);
            }
        }
        /// <inheritdoc cref="GetBooleani_v"/>
        public static unsafe void GetBoolean(BufferTargetARB target, uint index, bool[] data)
        {
            fixed (bool* data_ptr = data)
            {
                GetBooleani_v(target, index, data_ptr);
            }
        }
        /// <inheritdoc cref="GetBooleani_v"/>
        public static unsafe void GetBoolean(BufferTargetARB target, uint index, ref bool data)
        {
            fixed (bool* data_ptr = &data)
            {
                GetBooleani_v(target, index, data_ptr);
            }
        }
        /// <inheritdoc cref="GetMultisamplefv"/>
        public static unsafe void GetMultisamplef(GetMultisamplePNameNV pname, uint index, Span<float> val)
        {
            fixed (float* val_ptr = val)
            {
                GetMultisamplefv(pname, index, val_ptr);
            }
        }
        /// <inheritdoc cref="GetMultisamplefv"/>
        public static unsafe void GetMultisamplef(GetMultisamplePNameNV pname, uint index, float[] val)
        {
            fixed (float* val_ptr = val)
            {
                GetMultisamplefv(pname, index, val_ptr);
            }
        }
        /// <inheritdoc cref="GetMultisamplefv"/>
        public static unsafe void GetMultisamplef(GetMultisamplePNameNV pname, uint index, ref float val)
        {
            fixed (float* val_ptr = &val)
            {
                GetMultisamplefv(pname, index, val_ptr);
            }
        }
        /// <inheritdoc cref="GetTexLevelParameteriv"/>
        public static unsafe void GetTexLevelParameteri(TextureTarget target, int level, GetTextureParameter pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetTexLevelParameteriv(target, level, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexLevelParameteriv"/>
        public static unsafe void GetTexLevelParameteri(TextureTarget target, int level, GetTextureParameter pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetTexLevelParameteriv(target, level, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexLevelParameteriv"/>
        public static unsafe void GetTexLevelParameteri(TextureTarget target, int level, GetTextureParameter pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetTexLevelParameteriv(target, level, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexLevelParameterfv"/>
        public static unsafe void GetTexLevelParameterf(TextureTarget target, int level, GetTextureParameter pname, Span<float> parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetTexLevelParameterfv(target, level, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexLevelParameterfv"/>
        public static unsafe void GetTexLevelParameterf(TextureTarget target, int level, GetTextureParameter pname, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetTexLevelParameterfv(target, level, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexLevelParameterfv"/>
        public static unsafe void GetTexLevelParameterf(TextureTarget target, int level, GetTextureParameter pname, ref float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                GetTexLevelParameterfv(target, level, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="DebugMessageControl"/>
        public static unsafe void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, ReadOnlySpan<uint> ids, bool enabled)
        {
            int count = (int)(ids.Length);
            fixed (uint* ids_ptr = ids)
            {
                DebugMessageControl(source, type, severity, count, ids_ptr, enabled);
            }
        }
        /// <inheritdoc cref="DebugMessageControl"/>
        public static unsafe void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, uint[] ids, bool enabled)
        {
            int count = (int)(ids.Length);
            fixed (uint* ids_ptr = ids)
            {
                DebugMessageControl(source, type, severity, count, ids_ptr, enabled);
            }
        }
        /// <inheritdoc cref="DebugMessageControl"/>
        public static unsafe void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, int count, in uint ids, bool enabled)
        {
            fixed (uint* ids_ptr = &ids)
            {
                DebugMessageControl(source, type, severity, count, ids_ptr, enabled);
            }
        }
        /// <inheritdoc cref="DebugMessageInsert"/>
        public static unsafe void DebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, string buf)
        {
            byte* buf_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(buf);
            DebugMessageInsert(source, type, id, severity, length, buf_ptr);
            Marshal.FreeCoTaskMem((IntPtr)buf_ptr);
        }
        /// <inheritdoc cref="DebugMessageCallback"/>
        public static unsafe void DebugMessageCallback(GLDebugProc callback, IntPtr userParam)
        {
            void* userParam_vptr = (void*)userParam;
            IntPtr callback_ptr = Marshal.GetFunctionPointerForDelegate(callback);
            DebugMessageCallback(callback_ptr, userParam_vptr);
        }
        /// <inheritdoc cref="DebugMessageCallback"/>
        public static unsafe void DebugMessageCallback<T1>(GLDebugProc callback, in T1 userParam)
            where T1 : unmanaged
        {
            fixed (void* userParam_ptr = &userParam)
            {
                IntPtr callback_ptr = Marshal.GetFunctionPointerForDelegate(callback);
                DebugMessageCallback(callback_ptr, userParam_ptr);
            }
        }
        /// <inheritdoc cref="GetDebugMessageLog"/>
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
        /// <inheritdoc cref="GetDebugMessageLog"/>
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
        /// <inheritdoc cref="GetDebugMessageLog"/>
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
        /// <inheritdoc cref="PushDebugGroup"/>
        public static unsafe void PushDebugGroup(DebugSource source, uint id, int length, string message)
        {
            byte* message_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(message);
            PushDebugGroup(source, id, length, message_ptr);
            Marshal.FreeCoTaskMem((IntPtr)message_ptr);
        }
        /// <inheritdoc cref="ObjectLabel"/>
        public static unsafe void ObjectLabel(ObjectIdentifier identifier, uint name, int length, string label)
        {
            byte* label_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(label);
            ObjectLabel(identifier, name, length, label_ptr);
            Marshal.FreeCoTaskMem((IntPtr)label_ptr);
        }
        /// <inheritdoc cref="GetObjectLabel"/>
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
        /// <inheritdoc cref="GetObjectLabel"/>
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
        /// <inheritdoc cref="GetObjectLabel"/>
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
        /// <inheritdoc cref="GetObjectLabel"/>
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
        /// <inheritdoc cref="GetObjectLabel"/>
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
        /// <inheritdoc cref="GetObjectLabel"/>
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
        /// <inheritdoc cref="ObjectPtrLabel"/>
        public static unsafe void ObjectPtrLabel(IntPtr ptr, int length, string label)
        {
            byte* label_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(label);
            void* ptr_vptr = (void*)ptr;
            ObjectPtrLabel(ptr_vptr, length, label_ptr);
            Marshal.FreeCoTaskMem((IntPtr)label_ptr);
        }
        /// <inheritdoc cref="ObjectPtrLabel"/>
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
        /// <inheritdoc cref="GetObjectPtrLabel"/>
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
        /// <inheritdoc cref="GetObjectPtrLabel"/>
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
        /// <inheritdoc cref="GetObjectPtrLabel"/>
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
        /// <inheritdoc cref="GetObjectPtrLabel"/>
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
        /// <inheritdoc cref="GetObjectPtrLabel"/>
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
        /// <inheritdoc cref="GetObjectPtrLabel"/>
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
        /// <inheritdoc cref="GetObjectPtrLabel"/>
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
        /// <inheritdoc cref="GetObjectPtrLabel"/>
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
        /// <inheritdoc cref="GetObjectPtrLabel"/>
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
        /// <inheritdoc cref="GetObjectPtrLabel"/>
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
        /// <inheritdoc cref="GetObjectPtrLabel"/>
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
        /// <inheritdoc cref="GetObjectPtrLabel"/>
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
        /// <inheritdoc cref="GetPointerv"/>
        public static unsafe void GetPointer(GetPointervPName pname, void** parameters)
        {
            GetPointerv(pname, parameters);
        }
        /// <inheritdoc cref="DrawElementsBaseVertex"/>
        public static unsafe void DrawElementsBaseVertex(PrimitiveType mode, int count, DrawElementsType type, nint offset, int basevertex)
        {
            void* indices = (void*)offset;
            DrawElementsBaseVertex(mode, count, type, indices, basevertex);
        }
        /// <inheritdoc cref="DrawRangeElementsBaseVertex"/>
        public static unsafe void DrawRangeElementsBaseVertex(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, nint offset, int basevertex)
        {
            void* indices = (void*)offset;
            DrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
        }
        /// <inheritdoc cref="DrawElementsInstancedBaseVertex"/>
        public static unsafe void DrawElementsInstancedBaseVertex(PrimitiveType mode, int count, DrawElementsType type, nint offset, int instancecount, int basevertex)
        {
            void* indices = (void*)offset;
            DrawElementsInstancedBaseVertex(mode, count, type, indices, instancecount, basevertex);
        }
        /// <inheritdoc cref="ReadnPixels"/>
        public static unsafe void ReadnPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, IntPtr data)
        {
            void* data_vptr = (void*)data;
            ReadnPixels(x, y, width, height, format, type, bufSize, data_vptr);
        }
        /// <inheritdoc cref="ReadnPixels"/>
        public static unsafe void ReadnPixels<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, Span<T1> data)
            where T1 : unmanaged
        {
            int bufSize = (int)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                ReadnPixels(x, y, width, height, format, type, bufSize, data_ptr);
            }
        }
        /// <inheritdoc cref="ReadnPixels"/>
        public static unsafe void ReadnPixels<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, T1[] data)
            where T1 : unmanaged
        {
            int bufSize = (int)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                ReadnPixels(x, y, width, height, format, type, bufSize, data_ptr);
            }
        }
        /// <inheritdoc cref="ReadnPixels"/>
        public static unsafe void ReadnPixels<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, ref T1 data)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = &data)
            {
                ReadnPixels(x, y, width, height, format, type, bufSize, data_ptr);
            }
        }
        /// <inheritdoc cref="GetnUniformfv"/>
        public static unsafe void GetnUniformf(ProgramHandle program, int location, Span<float> parameters)
        {
            int bufSize = (int)(parameters.Length * 4);
            fixed (float* parameters_ptr = parameters)
            {
                GetnUniformfv(program, location, bufSize, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetnUniformfv"/>
        public static unsafe void GetnUniformf(ProgramHandle program, int location, float[] parameters)
        {
            int bufSize = (int)(parameters.Length * 4);
            fixed (float* parameters_ptr = parameters)
            {
                GetnUniformfv(program, location, bufSize, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetnUniformfv"/>
        public static unsafe void GetnUniformf(ProgramHandle program, int location, int bufSize, ref float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                GetnUniformfv(program, location, bufSize, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetnUniformiv"/>
        public static unsafe void GetnUniformi(ProgramHandle program, int location, Span<int> parameters)
        {
            int bufSize = (int)(parameters.Length * 4);
            fixed (int* parameters_ptr = parameters)
            {
                GetnUniformiv(program, location, bufSize, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetnUniformiv"/>
        public static unsafe void GetnUniformi(ProgramHandle program, int location, int[] parameters)
        {
            int bufSize = (int)(parameters.Length * 4);
            fixed (int* parameters_ptr = parameters)
            {
                GetnUniformiv(program, location, bufSize, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetnUniformiv"/>
        public static unsafe void GetnUniformi(ProgramHandle program, int location, int bufSize, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetnUniformiv(program, location, bufSize, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetnUniformuiv"/>
        public static unsafe void GetnUniformui(ProgramHandle program, int location, Span<uint> parameters)
        {
            int bufSize = (int)(parameters.Length * 4);
            fixed (uint* parameters_ptr = parameters)
            {
                GetnUniformuiv(program, location, bufSize, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetnUniformuiv"/>
        public static unsafe void GetnUniformui(ProgramHandle program, int location, uint[] parameters)
        {
            int bufSize = (int)(parameters.Length * 4);
            fixed (uint* parameters_ptr = parameters)
            {
                GetnUniformuiv(program, location, bufSize, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetnUniformuiv"/>
        public static unsafe void GetnUniformui(ProgramHandle program, int location, int bufSize, ref uint parameters)
        {
            fixed (uint* parameters_ptr = &parameters)
            {
                GetnUniformuiv(program, location, bufSize, parameters_ptr);
            }
        }
        /// <inheritdoc cref="TexParameterIiv"/>
        public static unsafe void TexParameterIi(TextureTarget target, TextureParameterName pname, ReadOnlySpan<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                TexParameterIiv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="TexParameterIiv"/>
        public static unsafe void TexParameterIi(TextureTarget target, TextureParameterName pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                TexParameterIiv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="TexParameterIiv"/>
        public static unsafe void TexParameterIi(TextureTarget target, TextureParameterName pname, in int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                TexParameterIiv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="TexParameterIuiv"/>
        public static unsafe void TexParameterIui(TextureTarget target, TextureParameterName pname, ReadOnlySpan<uint> parameters)
        {
            fixed (uint* parameters_ptr = parameters)
            {
                TexParameterIuiv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="TexParameterIuiv"/>
        public static unsafe void TexParameterIui(TextureTarget target, TextureParameterName pname, uint[] parameters)
        {
            fixed (uint* parameters_ptr = parameters)
            {
                TexParameterIuiv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="TexParameterIuiv"/>
        public static unsafe void TexParameterIui(TextureTarget target, TextureParameterName pname, in uint parameters)
        {
            fixed (uint* parameters_ptr = &parameters)
            {
                TexParameterIuiv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexParameterIiv"/>
        public static unsafe void GetTexParameterIi(TextureTarget target, GetTextureParameter pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetTexParameterIiv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexParameterIiv"/>
        public static unsafe void GetTexParameterIi(TextureTarget target, GetTextureParameter pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetTexParameterIiv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexParameterIiv"/>
        public static unsafe void GetTexParameterIi(TextureTarget target, GetTextureParameter pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetTexParameterIiv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexParameterIuiv"/>
        public static unsafe void GetTexParameterIui(TextureTarget target, GetTextureParameter pname, Span<uint> parameters)
        {
            fixed (uint* parameters_ptr = parameters)
            {
                GetTexParameterIuiv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexParameterIuiv"/>
        public static unsafe void GetTexParameterIui(TextureTarget target, GetTextureParameter pname, uint[] parameters)
        {
            fixed (uint* parameters_ptr = parameters)
            {
                GetTexParameterIuiv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetTexParameterIuiv"/>
        public static unsafe void GetTexParameterIui(TextureTarget target, GetTextureParameter pname, ref uint parameters)
        {
            fixed (uint* parameters_ptr = &parameters)
            {
                GetTexParameterIuiv(target, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="SamplerParameterIiv"/>
        public static unsafe void SamplerParameterIi(SamplerHandle sampler, SamplerParameterI pname, ReadOnlySpan<int> param)
        {
            fixed (int* param_ptr = param)
            {
                SamplerParameterIiv(sampler, pname, param_ptr);
            }
        }
        /// <inheritdoc cref="SamplerParameterIiv"/>
        public static unsafe void SamplerParameterIi(SamplerHandle sampler, SamplerParameterI pname, int[] param)
        {
            fixed (int* param_ptr = param)
            {
                SamplerParameterIiv(sampler, pname, param_ptr);
            }
        }
        /// <inheritdoc cref="SamplerParameterIiv"/>
        public static unsafe void SamplerParameterIi(SamplerHandle sampler, SamplerParameterI pname, in int param)
        {
            fixed (int* param_ptr = &param)
            {
                SamplerParameterIiv(sampler, pname, param_ptr);
            }
        }
        /// <inheritdoc cref="SamplerParameterIuiv"/>
        public static unsafe void SamplerParameterIui(SamplerHandle sampler, SamplerParameterI pname, ReadOnlySpan<uint> param)
        {
            fixed (uint* param_ptr = param)
            {
                SamplerParameterIuiv(sampler, pname, param_ptr);
            }
        }
        /// <inheritdoc cref="SamplerParameterIuiv"/>
        public static unsafe void SamplerParameterIui(SamplerHandle sampler, SamplerParameterI pname, uint[] param)
        {
            fixed (uint* param_ptr = param)
            {
                SamplerParameterIuiv(sampler, pname, param_ptr);
            }
        }
        /// <inheritdoc cref="SamplerParameterIuiv"/>
        public static unsafe void SamplerParameterIui(SamplerHandle sampler, SamplerParameterI pname, in uint param)
        {
            fixed (uint* param_ptr = &param)
            {
                SamplerParameterIuiv(sampler, pname, param_ptr);
            }
        }
        /// <inheritdoc cref="GetSamplerParameterIiv"/>
        public static unsafe void GetSamplerParameterIi(SamplerHandle sampler, SamplerParameterI pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetSamplerParameterIiv(sampler, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetSamplerParameterIiv"/>
        public static unsafe void GetSamplerParameterIi(SamplerHandle sampler, SamplerParameterI pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetSamplerParameterIiv(sampler, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetSamplerParameterIiv"/>
        public static unsafe void GetSamplerParameterIi(SamplerHandle sampler, SamplerParameterI pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetSamplerParameterIiv(sampler, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetSamplerParameterIuiv"/>
        public static unsafe void GetSamplerParameterIui(SamplerHandle sampler, SamplerParameterI pname, Span<uint> parameters)
        {
            fixed (uint* parameters_ptr = parameters)
            {
                GetSamplerParameterIuiv(sampler, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetSamplerParameterIuiv"/>
        public static unsafe void GetSamplerParameterIui(SamplerHandle sampler, SamplerParameterI pname, uint[] parameters)
        {
            fixed (uint* parameters_ptr = parameters)
            {
                GetSamplerParameterIuiv(sampler, pname, parameters_ptr);
            }
        }
        /// <inheritdoc cref="GetSamplerParameterIuiv"/>
        public static unsafe void GetSamplerParameterIui(SamplerHandle sampler, SamplerParameterI pname, ref uint parameters)
        {
            fixed (uint* parameters_ptr = &parameters)
            {
                GetSamplerParameterIuiv(sampler, pname, parameters_ptr);
            }
        }
        public static unsafe partial class AMD
        {
            /// <inheritdoc cref="GetPerfMonitorGroupsAMD"/>
            public static unsafe void GetPerfMonitorGroupsAMD(Span<int> numGroups, Span<uint> groups)
            {
                fixed (int* numGroups_ptr = numGroups)
                {
                    int groupsSize = (int)(groups.Length);
                    fixed (uint* groups_ptr = groups)
                    {
                        GetPerfMonitorGroupsAMD(numGroups_ptr, groupsSize, groups_ptr);
                    }
                }
            }
            /// <inheritdoc cref="GetPerfMonitorGroupsAMD"/>
            public static unsafe void GetPerfMonitorGroupsAMD(int[] numGroups, uint[] groups)
            {
                fixed (int* numGroups_ptr = numGroups)
                {
                    int groupsSize = (int)(groups.Length);
                    fixed (uint* groups_ptr = groups)
                    {
                        GetPerfMonitorGroupsAMD(numGroups_ptr, groupsSize, groups_ptr);
                    }
                }
            }
            /// <inheritdoc cref="GetPerfMonitorGroupsAMD"/>
            public static unsafe void GetPerfMonitorGroupsAMD(ref int numGroups, int groupsSize, ref uint groups)
            {
                fixed (int* numGroups_ptr = &numGroups)
                fixed (uint* groups_ptr = &groups)
                {
                    GetPerfMonitorGroupsAMD(numGroups_ptr, groupsSize, groups_ptr);
                }
            }
            /// <inheritdoc cref="GetPerfMonitorCountersAMD"/>
            public static unsafe void GetPerfMonitorCountersAMD(uint group, Span<int> numCounters, Span<int> maxActiveCounters, Span<uint> counters)
            {
                fixed (int* numCounters_ptr = numCounters)
                {
                    fixed (int* maxActiveCounters_ptr = maxActiveCounters)
                    {
                        int counterSize = (int)(counters.Length);
                        fixed (uint* counters_ptr = counters)
                        {
                            GetPerfMonitorCountersAMD(group, numCounters_ptr, maxActiveCounters_ptr, counterSize, counters_ptr);
                        }
                    }
                }
            }
            /// <inheritdoc cref="GetPerfMonitorCountersAMD"/>
            public static unsafe void GetPerfMonitorCountersAMD(uint group, int[] numCounters, int[] maxActiveCounters, uint[] counters)
            {
                fixed (int* numCounters_ptr = numCounters)
                {
                    fixed (int* maxActiveCounters_ptr = maxActiveCounters)
                    {
                        int counterSize = (int)(counters.Length);
                        fixed (uint* counters_ptr = counters)
                        {
                            GetPerfMonitorCountersAMD(group, numCounters_ptr, maxActiveCounters_ptr, counterSize, counters_ptr);
                        }
                    }
                }
            }
            /// <inheritdoc cref="GetPerfMonitorCountersAMD"/>
            public static unsafe void GetPerfMonitorCountersAMD(uint group, ref int numCounters, ref int maxActiveCounters, int counterSize, ref uint counters)
            {
                fixed (int* numCounters_ptr = &numCounters)
                fixed (int* maxActiveCounters_ptr = &maxActiveCounters)
                fixed (uint* counters_ptr = &counters)
                {
                    GetPerfMonitorCountersAMD(group, numCounters_ptr, maxActiveCounters_ptr, counterSize, counters_ptr);
                }
            }
            /// <inheritdoc cref="GetPerfMonitorGroupStringAMD"/>
            public static unsafe string GetPerfMonitorGroupStringAMD(uint group, int bufSize, Span<int> length)
            {
                string groupString;
                fixed (int* length_ptr = length)
                {
                    var groupString_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetPerfMonitorGroupStringAMD(group, bufSize, length_ptr, groupString_ptr);
                    groupString = Marshal.PtrToStringUTF8((IntPtr)groupString_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)groupString_ptr);
                }
                return groupString;
            }
            /// <inheritdoc cref="GetPerfMonitorGroupStringAMD"/>
            public static unsafe void GetPerfMonitorGroupStringAMD(uint group, int bufSize, Span<int> length, out string groupString)
            {
                fixed (int* length_ptr = length)
                {
                    var groupString_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetPerfMonitorGroupStringAMD(group, bufSize, length_ptr, groupString_ptr);
                    groupString = Marshal.PtrToStringUTF8((IntPtr)groupString_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)groupString_ptr);
                }
            }
            /// <inheritdoc cref="GetPerfMonitorGroupStringAMD"/>
            public static unsafe string GetPerfMonitorGroupStringAMD(uint group, int bufSize, int[] length)
            {
                string groupString;
                fixed (int* length_ptr = length)
                {
                    var groupString_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetPerfMonitorGroupStringAMD(group, bufSize, length_ptr, groupString_ptr);
                    groupString = Marshal.PtrToStringUTF8((IntPtr)groupString_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)groupString_ptr);
                }
                return groupString;
            }
            /// <inheritdoc cref="GetPerfMonitorGroupStringAMD"/>
            public static unsafe void GetPerfMonitorGroupStringAMD(uint group, int bufSize, int[] length, out string groupString)
            {
                fixed (int* length_ptr = length)
                {
                    var groupString_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetPerfMonitorGroupStringAMD(group, bufSize, length_ptr, groupString_ptr);
                    groupString = Marshal.PtrToStringUTF8((IntPtr)groupString_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)groupString_ptr);
                }
            }
            /// <inheritdoc cref="GetPerfMonitorGroupStringAMD"/>
            public static unsafe string GetPerfMonitorGroupStringAMD(uint group, int bufSize, ref int length)
            {
                string groupString;
                fixed (int* length_ptr = &length)
                {
                    var groupString_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetPerfMonitorGroupStringAMD(group, bufSize, length_ptr, groupString_ptr);
                    groupString = Marshal.PtrToStringUTF8((IntPtr)groupString_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)groupString_ptr);
                }
                return groupString;
            }
            /// <inheritdoc cref="GetPerfMonitorGroupStringAMD"/>
            public static unsafe void GetPerfMonitorGroupStringAMD(uint group, int bufSize, ref int length, out string groupString)
            {
                fixed (int* length_ptr = &length)
                {
                    var groupString_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetPerfMonitorGroupStringAMD(group, bufSize, length_ptr, groupString_ptr);
                    groupString = Marshal.PtrToStringUTF8((IntPtr)groupString_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)groupString_ptr);
                }
            }
            /// <inheritdoc cref="GetPerfMonitorCounterStringAMD"/>
            public static unsafe string GetPerfMonitorCounterStringAMD(uint group, uint counter, int bufSize, Span<int> length)
            {
                string counterString;
                fixed (int* length_ptr = length)
                {
                    var counterString_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetPerfMonitorCounterStringAMD(group, counter, bufSize, length_ptr, counterString_ptr);
                    counterString = Marshal.PtrToStringUTF8((IntPtr)counterString_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)counterString_ptr);
                }
                return counterString;
            }
            /// <inheritdoc cref="GetPerfMonitorCounterStringAMD"/>
            public static unsafe void GetPerfMonitorCounterStringAMD(uint group, uint counter, int bufSize, Span<int> length, out string counterString)
            {
                fixed (int* length_ptr = length)
                {
                    var counterString_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetPerfMonitorCounterStringAMD(group, counter, bufSize, length_ptr, counterString_ptr);
                    counterString = Marshal.PtrToStringUTF8((IntPtr)counterString_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)counterString_ptr);
                }
            }
            /// <inheritdoc cref="GetPerfMonitorCounterStringAMD"/>
            public static unsafe string GetPerfMonitorCounterStringAMD(uint group, uint counter, int bufSize, int[] length)
            {
                string counterString;
                fixed (int* length_ptr = length)
                {
                    var counterString_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetPerfMonitorCounterStringAMD(group, counter, bufSize, length_ptr, counterString_ptr);
                    counterString = Marshal.PtrToStringUTF8((IntPtr)counterString_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)counterString_ptr);
                }
                return counterString;
            }
            /// <inheritdoc cref="GetPerfMonitorCounterStringAMD"/>
            public static unsafe void GetPerfMonitorCounterStringAMD(uint group, uint counter, int bufSize, int[] length, out string counterString)
            {
                fixed (int* length_ptr = length)
                {
                    var counterString_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetPerfMonitorCounterStringAMD(group, counter, bufSize, length_ptr, counterString_ptr);
                    counterString = Marshal.PtrToStringUTF8((IntPtr)counterString_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)counterString_ptr);
                }
            }
            /// <inheritdoc cref="GetPerfMonitorCounterStringAMD"/>
            public static unsafe string GetPerfMonitorCounterStringAMD(uint group, uint counter, int bufSize, ref int length)
            {
                string counterString;
                fixed (int* length_ptr = &length)
                {
                    var counterString_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetPerfMonitorCounterStringAMD(group, counter, bufSize, length_ptr, counterString_ptr);
                    counterString = Marshal.PtrToStringUTF8((IntPtr)counterString_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)counterString_ptr);
                }
                return counterString;
            }
            /// <inheritdoc cref="GetPerfMonitorCounterStringAMD"/>
            public static unsafe void GetPerfMonitorCounterStringAMD(uint group, uint counter, int bufSize, ref int length, out string counterString)
            {
                fixed (int* length_ptr = &length)
                {
                    var counterString_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetPerfMonitorCounterStringAMD(group, counter, bufSize, length_ptr, counterString_ptr);
                    counterString = Marshal.PtrToStringUTF8((IntPtr)counterString_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)counterString_ptr);
                }
            }
            /// <inheritdoc cref="GetPerfMonitorCounterInfoAMD"/>
            public static unsafe void GetPerfMonitorCounterInfoAMD(uint group, uint counter, All pname, IntPtr data)
            {
                void* data_vptr = (void*)data;
                GetPerfMonitorCounterInfoAMD(group, counter, pname, data_vptr);
            }
            /// <inheritdoc cref="GetPerfMonitorCounterInfoAMD"/>
            public static unsafe void GetPerfMonitorCounterInfoAMD<T1>(uint group, uint counter, All pname, Span<T1> data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    GetPerfMonitorCounterInfoAMD(group, counter, pname, data_ptr);
                }
            }
            /// <inheritdoc cref="GetPerfMonitorCounterInfoAMD"/>
            public static unsafe void GetPerfMonitorCounterInfoAMD<T1>(uint group, uint counter, All pname, T1[] data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    GetPerfMonitorCounterInfoAMD(group, counter, pname, data_ptr);
                }
            }
            /// <inheritdoc cref="GetPerfMonitorCounterInfoAMD"/>
            public static unsafe void GetPerfMonitorCounterInfoAMD<T1>(uint group, uint counter, All pname, ref T1 data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    GetPerfMonitorCounterInfoAMD(group, counter, pname, data_ptr);
                }
            }
            /// <inheritdoc cref="GenPerfMonitorsAMD"/>
            public static unsafe void GenPerfMonitorsAMD(Span<uint> monitors)
            {
                int n = (int)(monitors.Length);
                fixed (uint* monitors_ptr = monitors)
                {
                    GenPerfMonitorsAMD(n, monitors_ptr);
                }
            }
            /// <inheritdoc cref="GenPerfMonitorsAMD"/>
            public static unsafe void GenPerfMonitorsAMD(uint[] monitors)
            {
                int n = (int)(monitors.Length);
                fixed (uint* monitors_ptr = monitors)
                {
                    GenPerfMonitorsAMD(n, monitors_ptr);
                }
            }
            /// <inheritdoc cref="GenPerfMonitorsAMD"/>
            public static unsafe void GenPerfMonitorsAMD(int n, ref uint monitors)
            {
                fixed (uint* monitors_ptr = &monitors)
                {
                    GenPerfMonitorsAMD(n, monitors_ptr);
                }
            }
            /// <inheritdoc cref="DeletePerfMonitorsAMD"/>
            public static unsafe void DeletePerfMonitorsAMD(Span<uint> monitors)
            {
                int n = (int)(monitors.Length);
                fixed (uint* monitors_ptr = monitors)
                {
                    DeletePerfMonitorsAMD(n, monitors_ptr);
                }
            }
            /// <inheritdoc cref="DeletePerfMonitorsAMD"/>
            public static unsafe void DeletePerfMonitorsAMD(uint[] monitors)
            {
                int n = (int)(monitors.Length);
                fixed (uint* monitors_ptr = monitors)
                {
                    DeletePerfMonitorsAMD(n, monitors_ptr);
                }
            }
            /// <inheritdoc cref="DeletePerfMonitorsAMD"/>
            public static unsafe void DeletePerfMonitorsAMD(int n, ref uint monitors)
            {
                fixed (uint* monitors_ptr = &monitors)
                {
                    DeletePerfMonitorsAMD(n, monitors_ptr);
                }
            }
            /// <inheritdoc cref="SelectPerfMonitorCountersAMD"/>
            public static unsafe void SelectPerfMonitorCountersAMD(uint monitor, bool enable, uint group, Span<uint> counterList)
            {
                int numCounters = (int)(counterList.Length);
                fixed (uint* counterList_ptr = counterList)
                {
                    SelectPerfMonitorCountersAMD(monitor, enable, group, numCounters, counterList_ptr);
                }
            }
            /// <inheritdoc cref="SelectPerfMonitorCountersAMD"/>
            public static unsafe void SelectPerfMonitorCountersAMD(uint monitor, bool enable, uint group, uint[] counterList)
            {
                int numCounters = (int)(counterList.Length);
                fixed (uint* counterList_ptr = counterList)
                {
                    SelectPerfMonitorCountersAMD(monitor, enable, group, numCounters, counterList_ptr);
                }
            }
            /// <inheritdoc cref="SelectPerfMonitorCountersAMD"/>
            public static unsafe void SelectPerfMonitorCountersAMD(uint monitor, bool enable, uint group, int numCounters, ref uint counterList)
            {
                fixed (uint* counterList_ptr = &counterList)
                {
                    SelectPerfMonitorCountersAMD(monitor, enable, group, numCounters, counterList_ptr);
                }
            }
            /// <inheritdoc cref="GetPerfMonitorCounterDataAMD"/>
            public static unsafe void GetPerfMonitorCounterDataAMD(uint monitor, All pname, Span<uint> data, Span<int> bytesWritten)
            {
                int dataSize = (int)(data.Length * 4);
                fixed (uint* data_ptr = data)
                {
                    fixed (int* bytesWritten_ptr = bytesWritten)
                    {
                        GetPerfMonitorCounterDataAMD(monitor, pname, dataSize, data_ptr, bytesWritten_ptr);
                    }
                }
            }
            /// <inheritdoc cref="GetPerfMonitorCounterDataAMD"/>
            public static unsafe void GetPerfMonitorCounterDataAMD(uint monitor, All pname, uint[] data, int[] bytesWritten)
            {
                int dataSize = (int)(data.Length * 4);
                fixed (uint* data_ptr = data)
                {
                    fixed (int* bytesWritten_ptr = bytesWritten)
                    {
                        GetPerfMonitorCounterDataAMD(monitor, pname, dataSize, data_ptr, bytesWritten_ptr);
                    }
                }
            }
            /// <inheritdoc cref="GetPerfMonitorCounterDataAMD"/>
            public static unsafe void GetPerfMonitorCounterDataAMD(uint monitor, All pname, int dataSize, ref uint data, ref int bytesWritten)
            {
                fixed (uint* data_ptr = &data)
                fixed (int* bytesWritten_ptr = &bytesWritten)
                {
                    GetPerfMonitorCounterDataAMD(monitor, pname, dataSize, data_ptr, bytesWritten_ptr);
                }
            }
        }
        public static unsafe partial class ANGLE
        {
            /// <inheritdoc cref="DrawElementsInstancedANGLE"/>
            public static unsafe void DrawElementsInstancedANGLE(PrimitiveType mode, int count, PrimitiveType type, nint offset, int primcount)
            {
                void* indices = (void*)offset;
                DrawElementsInstancedANGLE(mode, count, type, indices, primcount);
            }
            /// <inheritdoc cref="GetTranslatedShaderSourceANGLE"/>
            public static unsafe string GetTranslatedShaderSourceANGLE(ShaderHandle shader, int bufSize, Span<int> length)
            {
                string source;
                fixed (int* length_ptr = length)
                {
                    var source_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetTranslatedShaderSourceANGLE(shader, bufSize, length_ptr, source_ptr);
                    source = Marshal.PtrToStringUTF8((IntPtr)source_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)source_ptr);
                }
                return source;
            }
            /// <inheritdoc cref="GetTranslatedShaderSourceANGLE"/>
            public static unsafe void GetTranslatedShaderSourceANGLE(ShaderHandle shader, int bufSize, Span<int> length, out string source)
            {
                fixed (int* length_ptr = length)
                {
                    var source_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetTranslatedShaderSourceANGLE(shader, bufSize, length_ptr, source_ptr);
                    source = Marshal.PtrToStringUTF8((IntPtr)source_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)source_ptr);
                }
            }
            /// <inheritdoc cref="GetTranslatedShaderSourceANGLE"/>
            public static unsafe string GetTranslatedShaderSourceANGLE(ShaderHandle shader, int bufSize, int[] length)
            {
                string source;
                fixed (int* length_ptr = length)
                {
                    var source_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetTranslatedShaderSourceANGLE(shader, bufSize, length_ptr, source_ptr);
                    source = Marshal.PtrToStringUTF8((IntPtr)source_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)source_ptr);
                }
                return source;
            }
            /// <inheritdoc cref="GetTranslatedShaderSourceANGLE"/>
            public static unsafe void GetTranslatedShaderSourceANGLE(ShaderHandle shader, int bufSize, int[] length, out string source)
            {
                fixed (int* length_ptr = length)
                {
                    var source_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetTranslatedShaderSourceANGLE(shader, bufSize, length_ptr, source_ptr);
                    source = Marshal.PtrToStringUTF8((IntPtr)source_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)source_ptr);
                }
            }
            /// <inheritdoc cref="GetTranslatedShaderSourceANGLE"/>
            public static unsafe string GetTranslatedShaderSourceANGLE(ShaderHandle shader, int bufSize, ref int length)
            {
                string source;
                fixed (int* length_ptr = &length)
                {
                    var source_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetTranslatedShaderSourceANGLE(shader, bufSize, length_ptr, source_ptr);
                    source = Marshal.PtrToStringUTF8((IntPtr)source_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)source_ptr);
                }
                return source;
            }
            /// <inheritdoc cref="GetTranslatedShaderSourceANGLE"/>
            public static unsafe void GetTranslatedShaderSourceANGLE(ShaderHandle shader, int bufSize, ref int length, out string source)
            {
                fixed (int* length_ptr = &length)
                {
                    var source_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetTranslatedShaderSourceANGLE(shader, bufSize, length_ptr, source_ptr);
                    source = Marshal.PtrToStringUTF8((IntPtr)source_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)source_ptr);
                }
            }
        }
        public static unsafe partial class APPLE
        {
            /// <inheritdoc cref="GetInteger64vAPPLE"/>
            public static unsafe void GetInteger64vAPPLE(GetPName pname, ref long parameters)
            {
                fixed (long* parameters_ptr = &parameters)
                {
                    GetInteger64vAPPLE(pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetSyncivAPPLE"/>
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
            /// <inheritdoc cref="GetSyncivAPPLE"/>
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
            /// <inheritdoc cref="GetSyncivAPPLE"/>
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
            /// <inheritdoc cref="EGLImageTargetTexStorageEXT"/>
            public static unsafe void EGLImageTargetTexStorageEXT(All target, IntPtr image, in int attrib_list)
            {
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    void* image_vptr = (void*)image;
                    EGLImageTargetTexStorageEXT(target, image_vptr, attrib_list_ptr);
                }
            }
            /// <inheritdoc cref="EGLImageTargetTexStorageEXT"/>
            public static unsafe void EGLImageTargetTexStorageEXT<T1>(All target, ref T1 image, in int attrib_list)
                where T1 : unmanaged
            {
                fixed (void* image_ptr = &image)
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    EGLImageTargetTexStorageEXT(target, image_ptr, attrib_list_ptr);
                }
            }
            /// <inheritdoc cref="EGLImageTargetTextureStorageEXT"/>
            public static unsafe void EGLImageTargetTextureStorageEXT(TextureHandle texture, IntPtr image, in int attrib_list)
            {
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    void* image_vptr = (void*)image;
                    EGLImageTargetTextureStorageEXT(texture, image_vptr, attrib_list_ptr);
                }
            }
            /// <inheritdoc cref="EGLImageTargetTextureStorageEXT"/>
            public static unsafe void EGLImageTargetTextureStorageEXT<T1>(TextureHandle texture, ref T1 image, in int attrib_list)
                where T1 : unmanaged
            {
                fixed (void* image_ptr = &image)
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    EGLImageTargetTextureStorageEXT(texture, image_ptr, attrib_list_ptr);
                }
            }
            /// <inheritdoc cref="DrawElementsInstancedBaseInstanceEXT"/>
            public static unsafe void DrawElementsInstancedBaseInstanceEXT(PrimitiveType mode, int count, PrimitiveType type, nint offset, int instancecount, uint baseinstance)
            {
                void* indices = (void*)offset;
                DrawElementsInstancedBaseInstanceEXT(mode, count, type, indices, instancecount, baseinstance);
            }
            /// <inheritdoc cref="DrawElementsInstancedBaseVertexBaseInstanceEXT"/>
            public static unsafe void DrawElementsInstancedBaseVertexBaseInstanceEXT(PrimitiveType mode, int count, DrawElementsType type, nint offset, int instancecount, int basevertex, uint baseinstance)
            {
                void* indices = (void*)offset;
                DrawElementsInstancedBaseVertexBaseInstanceEXT(mode, count, type, indices, instancecount, basevertex, baseinstance);
            }
            /// <inheritdoc cref="BindFragDataLocationIndexedEXT"/>
            public static unsafe void BindFragDataLocationIndexedEXT(ProgramHandle program, uint colorNumber, uint index, string name)
            {
                byte* name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(name);
                BindFragDataLocationIndexedEXT(program, colorNumber, index, name_ptr);
                Marshal.FreeCoTaskMem((IntPtr)name_ptr);
            }
            /// <inheritdoc cref="BindFragDataLocationEXT"/>
            public static unsafe void BindFragDataLocationEXT(ProgramHandle program, uint color, string name)
            {
                byte* name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(name);
                BindFragDataLocationEXT(program, color, name_ptr);
                Marshal.FreeCoTaskMem((IntPtr)name_ptr);
            }
            /// <inheritdoc cref="GetProgramResourceLocationIndexEXT"/>
            public static unsafe int GetProgramResourceLocationIndexEXT(ProgramHandle program, ProgramInterface programInterface, string name)
            {
                int returnValue;
                byte* name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(name);
                returnValue = GetProgramResourceLocationIndexEXT(program, programInterface, name_ptr);
                Marshal.FreeCoTaskMem((IntPtr)name_ptr);
                return returnValue;
            }
            /// <inheritdoc cref="GetFragDataIndexEXT"/>
            public static unsafe int GetFragDataIndexEXT(ProgramHandle program, string name)
            {
                int returnValue;
                byte* name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(name);
                returnValue = GetFragDataIndexEXT(program, name_ptr);
                Marshal.FreeCoTaskMem((IntPtr)name_ptr);
                return returnValue;
            }
            /// <inheritdoc cref="BufferStorageEXT"/>
            public static unsafe void BufferStorageEXT(BufferStorageTarget target, nint size, IntPtr data, BufferStorageMask flags)
            {
                void* data_vptr = (void*)data;
                BufferStorageEXT(target, size, data_vptr, flags);
            }
            /// <inheritdoc cref="BufferStorageEXT"/>
            public static unsafe void BufferStorageEXT<T1>(BufferStorageTarget target, ReadOnlySpan<T1> data, BufferStorageMask flags)
                where T1 : unmanaged
            {
                nint size = (nint)(data.Length * sizeof(T1));
                fixed (void* data_ptr = data)
                {
                    BufferStorageEXT(target, size, data_ptr, flags);
                }
            }
            /// <inheritdoc cref="BufferStorageEXT"/>
            public static unsafe void BufferStorageEXT<T1>(BufferStorageTarget target, T1[] data, BufferStorageMask flags)
                where T1 : unmanaged
            {
                nint size = (nint)(data.Length * sizeof(T1));
                fixed (void* data_ptr = data)
                {
                    BufferStorageEXT(target, size, data_ptr, flags);
                }
            }
            /// <inheritdoc cref="BufferStorageEXT"/>
            public static unsafe void BufferStorageEXT<T1>(BufferStorageTarget target, nint size, in T1 data, BufferStorageMask flags)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    BufferStorageEXT(target, size, data_ptr, flags);
                }
            }
            /// <inheritdoc cref="ClearTexImageEXT"/>
            public static unsafe void ClearTexImageEXT(TextureHandle texture, int level, PixelFormat format, PixelType type, IntPtr data)
            {
                void* data_vptr = (void*)data;
                ClearTexImageEXT(texture, level, format, type, data_vptr);
            }
            /// <inheritdoc cref="ClearTexImageEXT"/>
            public static unsafe void ClearTexImageEXT<T1>(TextureHandle texture, int level, PixelFormat format, PixelType type, ReadOnlySpan<T1> data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    ClearTexImageEXT(texture, level, format, type, data_ptr);
                }
            }
            /// <inheritdoc cref="ClearTexImageEXT"/>
            public static unsafe void ClearTexImageEXT<T1>(TextureHandle texture, int level, PixelFormat format, PixelType type, T1[] data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    ClearTexImageEXT(texture, level, format, type, data_ptr);
                }
            }
            /// <inheritdoc cref="ClearTexImageEXT"/>
            public static unsafe void ClearTexImageEXT<T1>(TextureHandle texture, int level, PixelFormat format, PixelType type, in T1 data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    ClearTexImageEXT(texture, level, format, type, data_ptr);
                }
            }
            /// <inheritdoc cref="ClearTexSubImageEXT"/>
            public static unsafe void ClearTexSubImageEXT(TextureHandle texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr data)
            {
                void* data_vptr = (void*)data;
                ClearTexSubImageEXT(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data_vptr);
            }
            /// <inheritdoc cref="ClearTexSubImageEXT"/>
            public static unsafe void ClearTexSubImageEXT<T1>(TextureHandle texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, ReadOnlySpan<T1> data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    ClearTexSubImageEXT(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data_ptr);
                }
            }
            /// <inheritdoc cref="ClearTexSubImageEXT"/>
            public static unsafe void ClearTexSubImageEXT<T1>(TextureHandle texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, T1[] data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    ClearTexSubImageEXT(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data_ptr);
                }
            }
            /// <inheritdoc cref="ClearTexSubImageEXT"/>
            public static unsafe void ClearTexSubImageEXT<T1>(TextureHandle texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, in T1 data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    ClearTexSubImageEXT(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data_ptr);
                }
            }
            /// <inheritdoc cref="LabelObjectEXT"/>
            public static unsafe void LabelObjectEXT(All type, uint obj, int length, string label)
            {
                byte* label_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(label);
                LabelObjectEXT(type, obj, length, label_ptr);
                Marshal.FreeCoTaskMem((IntPtr)label_ptr);
            }
            /// <inheritdoc cref="GetObjectLabelEXT"/>
            public static unsafe string GetObjectLabelEXT(All type, uint obj, int bufSize, Span<int> length)
            {
                string label;
                fixed (int* length_ptr = length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetObjectLabelEXT(type, obj, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
                return label;
            }
            /// <inheritdoc cref="GetObjectLabelEXT"/>
            public static unsafe void GetObjectLabelEXT(All type, uint obj, int bufSize, Span<int> length, out string label)
            {
                fixed (int* length_ptr = length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetObjectLabelEXT(type, obj, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
            }
            /// <inheritdoc cref="GetObjectLabelEXT"/>
            public static unsafe string GetObjectLabelEXT(All type, uint obj, int bufSize, int[] length)
            {
                string label;
                fixed (int* length_ptr = length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetObjectLabelEXT(type, obj, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
                return label;
            }
            /// <inheritdoc cref="GetObjectLabelEXT"/>
            public static unsafe void GetObjectLabelEXT(All type, uint obj, int bufSize, int[] length, out string label)
            {
                fixed (int* length_ptr = length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetObjectLabelEXT(type, obj, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
            }
            /// <inheritdoc cref="GetObjectLabelEXT"/>
            public static unsafe string GetObjectLabelEXT(All type, uint obj, int bufSize, ref int length)
            {
                string label;
                fixed (int* length_ptr = &length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetObjectLabelEXT(type, obj, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
                return label;
            }
            /// <inheritdoc cref="GetObjectLabelEXT"/>
            public static unsafe void GetObjectLabelEXT(All type, uint obj, int bufSize, ref int length, out string label)
            {
                fixed (int* length_ptr = &length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetObjectLabelEXT(type, obj, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
            }
            /// <inheritdoc cref="InsertEventMarkerEXT"/>
            public static unsafe void InsertEventMarkerEXT(int length, string marker)
            {
                byte* marker_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(marker);
                InsertEventMarkerEXT(length, marker_ptr);
                Marshal.FreeCoTaskMem((IntPtr)marker_ptr);
            }
            /// <inheritdoc cref="PushGroupMarkerEXT"/>
            public static unsafe void PushGroupMarkerEXT(int length, string marker)
            {
                byte* marker_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(marker);
                PushGroupMarkerEXT(length, marker_ptr);
                Marshal.FreeCoTaskMem((IntPtr)marker_ptr);
            }
            /// <inheritdoc cref="DiscardFramebufferEXT"/>
            public static unsafe void DiscardFramebufferEXT(FramebufferTarget target, ReadOnlySpan<InvalidateFramebufferAttachment> attachments)
            {
                int numAttachments = (int)(attachments.Length);
                fixed (InvalidateFramebufferAttachment* attachments_ptr = attachments)
                {
                    DiscardFramebufferEXT(target, numAttachments, attachments_ptr);
                }
            }
            /// <inheritdoc cref="DiscardFramebufferEXT"/>
            public static unsafe void DiscardFramebufferEXT(FramebufferTarget target, InvalidateFramebufferAttachment[] attachments)
            {
                int numAttachments = (int)(attachments.Length);
                fixed (InvalidateFramebufferAttachment* attachments_ptr = attachments)
                {
                    DiscardFramebufferEXT(target, numAttachments, attachments_ptr);
                }
            }
            /// <inheritdoc cref="DiscardFramebufferEXT"/>
            public static unsafe void DiscardFramebufferEXT(FramebufferTarget target, int numAttachments, in InvalidateFramebufferAttachment attachments)
            {
                fixed (InvalidateFramebufferAttachment* attachments_ptr = &attachments)
                {
                    DiscardFramebufferEXT(target, numAttachments, attachments_ptr);
                }
            }
            /// <inheritdoc cref="GenQueriesEXT"/>
            public static unsafe void GenQueriesEXT(Span<QueryHandle> ids)
            {
                int n = (int)(ids.Length);
                fixed (QueryHandle* ids_ptr = ids)
                {
                    GenQueriesEXT(n, ids_ptr);
                }
            }
            /// <inheritdoc cref="GenQueriesEXT"/>
            public static unsafe void GenQueriesEXT(QueryHandle[] ids)
            {
                int n = (int)(ids.Length);
                fixed (QueryHandle* ids_ptr = ids)
                {
                    GenQueriesEXT(n, ids_ptr);
                }
            }
            /// <inheritdoc cref="GenQueriesEXT"/>
            public static unsafe void GenQueriesEXT(int n, ref QueryHandle ids)
            {
                fixed (QueryHandle* ids_ptr = &ids)
                {
                    GenQueriesEXT(n, ids_ptr);
                }
            }
            /// <inheritdoc cref="DeleteQueriesEXT"/>
            public static unsafe void DeleteQueriesEXT(ReadOnlySpan<QueryHandle> ids)
            {
                int n = (int)(ids.Length);
                fixed (QueryHandle* ids_ptr = ids)
                {
                    DeleteQueriesEXT(n, ids_ptr);
                }
            }
            /// <inheritdoc cref="DeleteQueriesEXT"/>
            public static unsafe void DeleteQueriesEXT(QueryHandle[] ids)
            {
                int n = (int)(ids.Length);
                fixed (QueryHandle* ids_ptr = ids)
                {
                    DeleteQueriesEXT(n, ids_ptr);
                }
            }
            /// <inheritdoc cref="DeleteQueriesEXT"/>
            public static unsafe void DeleteQueriesEXT(int n, in QueryHandle ids)
            {
                fixed (QueryHandle* ids_ptr = &ids)
                {
                    DeleteQueriesEXT(n, ids_ptr);
                }
            }
            /// <inheritdoc cref="GetQueryivEXT"/>
            public static unsafe void GetQueryivEXT(QueryTarget target, QueryParameterName pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetQueryivEXT(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetQueryivEXT"/>
            public static unsafe void GetQueryivEXT(QueryTarget target, QueryParameterName pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetQueryivEXT(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetQueryivEXT"/>
            public static unsafe void GetQueryivEXT(QueryTarget target, QueryParameterName pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetQueryivEXT(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetQueryObjectivEXT"/>
            public static unsafe void GetQueryObjectivEXT(QueryHandle id, QueryObjectParameterName pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetQueryObjectivEXT(id, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetQueryObjectivEXT"/>
            public static unsafe void GetQueryObjectivEXT(QueryHandle id, QueryObjectParameterName pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetQueryObjectivEXT(id, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetQueryObjectivEXT"/>
            public static unsafe void GetQueryObjectivEXT(QueryHandle id, QueryObjectParameterName pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetQueryObjectivEXT(id, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetQueryObjectuivEXT"/>
            public static unsafe void GetQueryObjectuivEXT(QueryHandle id, QueryObjectParameterName pname, Span<uint> parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    GetQueryObjectuivEXT(id, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetQueryObjectuivEXT"/>
            public static unsafe void GetQueryObjectuivEXT(QueryHandle id, QueryObjectParameterName pname, uint[] parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    GetQueryObjectuivEXT(id, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetQueryObjectuivEXT"/>
            public static unsafe void GetQueryObjectuivEXT(QueryHandle id, QueryObjectParameterName pname, ref uint parameters)
            {
                fixed (uint* parameters_ptr = &parameters)
                {
                    GetQueryObjectuivEXT(id, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetQueryObjecti64vEXT"/>
            public static unsafe void GetQueryObjecti64vEXT(QueryHandle id, QueryObjectParameterName pname, Span<long> parameters)
            {
                fixed (long* parameters_ptr = parameters)
                {
                    GetQueryObjecti64vEXT(id, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetQueryObjecti64vEXT"/>
            public static unsafe void GetQueryObjecti64vEXT(QueryHandle id, QueryObjectParameterName pname, long[] parameters)
            {
                fixed (long* parameters_ptr = parameters)
                {
                    GetQueryObjecti64vEXT(id, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetQueryObjecti64vEXT"/>
            public static unsafe void GetQueryObjecti64vEXT(QueryHandle id, QueryObjectParameterName pname, ref long parameters)
            {
                fixed (long* parameters_ptr = &parameters)
                {
                    GetQueryObjecti64vEXT(id, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetQueryObjectui64vEXT"/>
            public static unsafe void GetQueryObjectui64vEXT(QueryHandle id, QueryObjectParameterName pname, Span<ulong> parameters)
            {
                fixed (ulong* parameters_ptr = parameters)
                {
                    GetQueryObjectui64vEXT(id, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetQueryObjectui64vEXT"/>
            public static unsafe void GetQueryObjectui64vEXT(QueryHandle id, QueryObjectParameterName pname, ulong[] parameters)
            {
                fixed (ulong* parameters_ptr = parameters)
                {
                    GetQueryObjectui64vEXT(id, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetQueryObjectui64vEXT"/>
            public static unsafe void GetQueryObjectui64vEXT(QueryHandle id, QueryObjectParameterName pname, ref ulong parameters)
            {
                fixed (ulong* parameters_ptr = &parameters)
                {
                    GetQueryObjectui64vEXT(id, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetInteger64vEXT"/>
            public static unsafe void GetInteger64vEXT(GetPName pname, Span<long> data)
            {
                fixed (long* data_ptr = data)
                {
                    GetInteger64vEXT(pname, data_ptr);
                }
            }
            /// <inheritdoc cref="GetInteger64vEXT"/>
            public static unsafe void GetInteger64vEXT(GetPName pname, long[] data)
            {
                fixed (long* data_ptr = data)
                {
                    GetInteger64vEXT(pname, data_ptr);
                }
            }
            /// <inheritdoc cref="GetInteger64vEXT"/>
            public static unsafe void GetInteger64vEXT(GetPName pname, ref long data)
            {
                fixed (long* data_ptr = &data)
                {
                    GetInteger64vEXT(pname, data_ptr);
                }
            }
            /// <inheritdoc cref="DrawBuffersEXT"/>
            public static unsafe void DrawBuffersEXT(ReadOnlySpan<All> bufs)
            {
                int n = (int)(bufs.Length);
                fixed (All* bufs_ptr = bufs)
                {
                    DrawBuffersEXT(n, bufs_ptr);
                }
            }
            /// <inheritdoc cref="DrawBuffersEXT"/>
            public static unsafe void DrawBuffersEXT(All[] bufs)
            {
                int n = (int)(bufs.Length);
                fixed (All* bufs_ptr = bufs)
                {
                    DrawBuffersEXT(n, bufs_ptr);
                }
            }
            /// <inheritdoc cref="DrawBuffersEXT"/>
            public static unsafe void DrawBuffersEXT(int n, in All bufs)
            {
                fixed (All* bufs_ptr = &bufs)
                {
                    DrawBuffersEXT(n, bufs_ptr);
                }
            }
            /// <inheritdoc cref="DrawElementsBaseVertexEXT"/>
            public static unsafe void DrawElementsBaseVertexEXT(PrimitiveType mode, int count, DrawElementsType type, nint offset, int basevertex)
            {
                void* indices = (void*)offset;
                DrawElementsBaseVertexEXT(mode, count, type, indices, basevertex);
            }
            /// <inheritdoc cref="DrawRangeElementsBaseVertexEXT"/>
            public static unsafe void DrawRangeElementsBaseVertexEXT(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, nint offset, int basevertex)
            {
                void* indices = (void*)offset;
                DrawRangeElementsBaseVertexEXT(mode, start, end, count, type, indices, basevertex);
            }
            /// <inheritdoc cref="DrawElementsInstancedBaseVertexEXT"/>
            public static unsafe void DrawElementsInstancedBaseVertexEXT(PrimitiveType mode, int count, DrawElementsType type, nint offset, int instancecount, int basevertex)
            {
                void* indices = (void*)offset;
                DrawElementsInstancedBaseVertexEXT(mode, count, type, indices, instancecount, basevertex);
            }
            /// <inheritdoc cref="MultiDrawElementsBaseVertexEXT"/>
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
            /// <inheritdoc cref="MultiDrawElementsBaseVertexEXT"/>
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
            /// <inheritdoc cref="MultiDrawElementsBaseVertexEXT"/>
            public static unsafe void MultiDrawElementsBaseVertexEXT(PrimitiveType mode, in int count, DrawElementsType type, void** indices, int drawcount, in int basevertex)
            {
                fixed (int* count_ptr = &count)
                fixed (int* basevertex_ptr = &basevertex)
                {
                    MultiDrawElementsBaseVertexEXT(mode, count_ptr, type, indices, drawcount, basevertex_ptr);
                }
            }
            /// <inheritdoc cref="DrawElementsInstancedEXT"/>
            public static unsafe void DrawElementsInstancedEXT(PrimitiveType mode, int count, DrawElementsType type, nint offset, int primcount)
            {
                void* indices = (void*)offset;
                DrawElementsInstancedEXT(mode, count, type, indices, primcount);
            }
            /// <inheritdoc cref="BufferStorageExternalEXT"/>
            public static unsafe void BufferStorageExternalEXT(All target, IntPtr offset, nint size, IntPtr clientBuffer, BufferStorageMask flags)
            {
                void* clientBuffer_vptr = (void*)clientBuffer;
                BufferStorageExternalEXT(target, offset, size, clientBuffer_vptr, flags);
            }
            /// <inheritdoc cref="BufferStorageExternalEXT"/>
            public static unsafe void BufferStorageExternalEXT<T1>(All target, IntPtr offset, nint size, ref T1 clientBuffer, BufferStorageMask flags)
                where T1 : unmanaged
            {
                fixed (void* clientBuffer_ptr = &clientBuffer)
                {
                    BufferStorageExternalEXT(target, offset, size, clientBuffer_ptr, flags);
                }
            }
            /// <inheritdoc cref="NamedBufferStorageExternalEXT"/>
            public static unsafe void NamedBufferStorageExternalEXT(BufferHandle buffer, IntPtr offset, nint size, IntPtr clientBuffer, BufferStorageMask flags)
            {
                void* clientBuffer_vptr = (void*)clientBuffer;
                NamedBufferStorageExternalEXT(buffer, offset, size, clientBuffer_vptr, flags);
            }
            /// <inheritdoc cref="NamedBufferStorageExternalEXT"/>
            public static unsafe void NamedBufferStorageExternalEXT<T1>(BufferHandle buffer, IntPtr offset, nint size, ref T1 clientBuffer, BufferStorageMask flags)
                where T1 : unmanaged
            {
                fixed (void* clientBuffer_ptr = &clientBuffer)
                {
                    NamedBufferStorageExternalEXT(buffer, offset, size, clientBuffer_ptr, flags);
                }
            }
            /// <inheritdoc cref="GetFragmentShadingRatesEXT"/>
            public static unsafe void GetFragmentShadingRatesEXT(int samples, Span<int> count, Span<ShadingRate> shadingRates)
            {
                fixed (int* count_ptr = count)
                {
                    int maxCount = (int)(shadingRates.Length);
                    fixed (ShadingRate* shadingRates_ptr = shadingRates)
                    {
                        GetFragmentShadingRatesEXT(samples, maxCount, count_ptr, shadingRates_ptr);
                    }
                }
            }
            /// <inheritdoc cref="GetFragmentShadingRatesEXT"/>
            public static unsafe void GetFragmentShadingRatesEXT(int samples, int[] count, ShadingRate[] shadingRates)
            {
                fixed (int* count_ptr = count)
                {
                    int maxCount = (int)(shadingRates.Length);
                    fixed (ShadingRate* shadingRates_ptr = shadingRates)
                    {
                        GetFragmentShadingRatesEXT(samples, maxCount, count_ptr, shadingRates_ptr);
                    }
                }
            }
            /// <inheritdoc cref="GetFragmentShadingRatesEXT"/>
            public static unsafe void GetFragmentShadingRatesEXT(int samples, int maxCount, ref int count, ref ShadingRate shadingRates)
            {
                fixed (int* count_ptr = &count)
                fixed (ShadingRate* shadingRates_ptr = &shadingRates)
                {
                    GetFragmentShadingRatesEXT(samples, maxCount, count_ptr, shadingRates_ptr);
                }
            }
            /// <inheritdoc cref="GetUnsignedBytevEXT"/>
            public static unsafe void GetUnsignedBytevEXT(GetPName pname, Span<byte> data)
            {
                fixed (byte* data_ptr = data)
                {
                    GetUnsignedBytevEXT(pname, data_ptr);
                }
            }
            /// <inheritdoc cref="GetUnsignedBytevEXT"/>
            public static unsafe void GetUnsignedBytevEXT(GetPName pname, byte[] data)
            {
                fixed (byte* data_ptr = data)
                {
                    GetUnsignedBytevEXT(pname, data_ptr);
                }
            }
            /// <inheritdoc cref="GetUnsignedBytevEXT"/>
            public static unsafe void GetUnsignedBytevEXT(GetPName pname, ref byte data)
            {
                fixed (byte* data_ptr = &data)
                {
                    GetUnsignedBytevEXT(pname, data_ptr);
                }
            }
            /// <inheritdoc cref="GetUnsignedBytei_vEXT"/>
            public static unsafe void GetUnsignedBytei_vEXT(All target, uint index, Span<byte> data)
            {
                fixed (byte* data_ptr = data)
                {
                    GetUnsignedBytei_vEXT(target, index, data_ptr);
                }
            }
            /// <inheritdoc cref="GetUnsignedBytei_vEXT"/>
            public static unsafe void GetUnsignedBytei_vEXT(All target, uint index, byte[] data)
            {
                fixed (byte* data_ptr = data)
                {
                    GetUnsignedBytei_vEXT(target, index, data_ptr);
                }
            }
            /// <inheritdoc cref="GetUnsignedBytei_vEXT"/>
            public static unsafe void GetUnsignedBytei_vEXT(All target, uint index, ref byte data)
            {
                fixed (byte* data_ptr = &data)
                {
                    GetUnsignedBytei_vEXT(target, index, data_ptr);
                }
            }
            /// <inheritdoc cref="DeleteMemoryObjectsEXT"/>
            public static unsafe void DeleteMemoryObjectsEXT(ReadOnlySpan<uint> memoryObjects)
            {
                int n = (int)(memoryObjects.Length);
                fixed (uint* memoryObjects_ptr = memoryObjects)
                {
                    DeleteMemoryObjectsEXT(n, memoryObjects_ptr);
                }
            }
            /// <inheritdoc cref="DeleteMemoryObjectsEXT"/>
            public static unsafe void DeleteMemoryObjectsEXT(uint[] memoryObjects)
            {
                int n = (int)(memoryObjects.Length);
                fixed (uint* memoryObjects_ptr = memoryObjects)
                {
                    DeleteMemoryObjectsEXT(n, memoryObjects_ptr);
                }
            }
            /// <inheritdoc cref="DeleteMemoryObjectsEXT"/>
            public static unsafe void DeleteMemoryObjectsEXT(int n, in uint memoryObjects)
            {
                fixed (uint* memoryObjects_ptr = &memoryObjects)
                {
                    DeleteMemoryObjectsEXT(n, memoryObjects_ptr);
                }
            }
            /// <inheritdoc cref="CreateMemoryObjectsEXT"/>
            public static unsafe void CreateMemoryObjectsEXT(int n, ref uint memoryObjects)
            {
                fixed (uint* memoryObjects_ptr = &memoryObjects)
                {
                    CreateMemoryObjectsEXT(n, memoryObjects_ptr);
                }
            }
            /// <inheritdoc cref="MemoryObjectParameterivEXT"/>
            public static unsafe void MemoryObjectParameterivEXT(uint memoryObject, MemoryObjectParameterName pname, in int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    MemoryObjectParameterivEXT(memoryObject, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetMemoryObjectParameterivEXT"/>
            public static unsafe void GetMemoryObjectParameterivEXT(uint memoryObject, MemoryObjectParameterName pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetMemoryObjectParameterivEXT(memoryObject, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="ImportMemoryWin32HandleEXT"/>
            public static unsafe void ImportMemoryWin32HandleEXT(uint memory, ulong size, ExternalHandleType handleType, IntPtr handle)
            {
                void* handle_vptr = (void*)handle;
                ImportMemoryWin32HandleEXT(memory, size, handleType, handle_vptr);
            }
            /// <inheritdoc cref="ImportMemoryWin32HandleEXT"/>
            public static unsafe void ImportMemoryWin32HandleEXT<T1>(uint memory, ulong size, ExternalHandleType handleType, ref T1 handle)
                where T1 : unmanaged
            {
                fixed (void* handle_ptr = &handle)
                {
                    ImportMemoryWin32HandleEXT(memory, size, handleType, handle_ptr);
                }
            }
            /// <inheritdoc cref="ImportMemoryWin32NameEXT"/>
            public static unsafe void ImportMemoryWin32NameEXT(uint memory, ulong size, ExternalHandleType handleType, IntPtr name)
            {
                void* name_vptr = (void*)name;
                ImportMemoryWin32NameEXT(memory, size, handleType, name_vptr);
            }
            /// <inheritdoc cref="ImportMemoryWin32NameEXT"/>
            public static unsafe void ImportMemoryWin32NameEXT<T1>(uint memory, ulong size, ExternalHandleType handleType, in T1 name)
                where T1 : unmanaged
            {
                fixed (void* name_ptr = &name)
                {
                    ImportMemoryWin32NameEXT(memory, size, handleType, name_ptr);
                }
            }
            /// <inheritdoc cref="MultiDrawArraysEXT"/>
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
            /// <inheritdoc cref="MultiDrawArraysEXT"/>
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
            /// <inheritdoc cref="MultiDrawArraysEXT"/>
            public static unsafe void MultiDrawArraysEXT(PrimitiveType mode, in int first, in int count, int primcount)
            {
                fixed (int* first_ptr = &first)
                fixed (int* count_ptr = &count)
                {
                    MultiDrawArraysEXT(mode, first_ptr, count_ptr, primcount);
                }
            }
            /// <inheritdoc cref="MultiDrawElementsEXT"/>
            public static unsafe void MultiDrawElementsEXT(PrimitiveType mode, ReadOnlySpan<int> count, DrawElementsType type, void** indices, int primcount)
            {
                fixed (int* count_ptr = count)
                {
                    MultiDrawElementsEXT(mode, count_ptr, type, indices, primcount);
                }
            }
            /// <inheritdoc cref="MultiDrawElementsEXT"/>
            public static unsafe void MultiDrawElementsEXT(PrimitiveType mode, int[] count, DrawElementsType type, void** indices, int primcount)
            {
                fixed (int* count_ptr = count)
                {
                    MultiDrawElementsEXT(mode, count_ptr, type, indices, primcount);
                }
            }
            /// <inheritdoc cref="MultiDrawElementsEXT"/>
            public static unsafe void MultiDrawElementsEXT(PrimitiveType mode, in int count, DrawElementsType type, void** indices, int primcount)
            {
                fixed (int* count_ptr = &count)
                {
                    MultiDrawElementsEXT(mode, count_ptr, type, indices, primcount);
                }
            }
            /// <inheritdoc cref="MultiDrawArraysIndirectEXT"/>
            public static unsafe void MultiDrawArraysIndirectEXT(PrimitiveType mode, IntPtr indirect, int drawcount, int stride)
            {
                void* indirect_vptr = (void*)indirect;
                MultiDrawArraysIndirectEXT(mode, indirect_vptr, drawcount, stride);
            }
            /// <inheritdoc cref="MultiDrawArraysIndirectEXT"/>
            public static unsafe void MultiDrawArraysIndirectEXT<T1>(PrimitiveType mode, ReadOnlySpan<T1> indirect, int drawcount, int stride)
                where T1 : unmanaged
            {
                fixed (void* indirect_ptr = indirect)
                {
                    MultiDrawArraysIndirectEXT(mode, indirect_ptr, drawcount, stride);
                }
            }
            /// <inheritdoc cref="MultiDrawArraysIndirectEXT"/>
            public static unsafe void MultiDrawArraysIndirectEXT<T1>(PrimitiveType mode, T1[] indirect, int drawcount, int stride)
                where T1 : unmanaged
            {
                fixed (void* indirect_ptr = indirect)
                {
                    MultiDrawArraysIndirectEXT(mode, indirect_ptr, drawcount, stride);
                }
            }
            /// <inheritdoc cref="MultiDrawArraysIndirectEXT"/>
            public static unsafe void MultiDrawArraysIndirectEXT<T1>(PrimitiveType mode, in T1 indirect, int drawcount, int stride)
                where T1 : unmanaged
            {
                fixed (void* indirect_ptr = &indirect)
                {
                    MultiDrawArraysIndirectEXT(mode, indirect_ptr, drawcount, stride);
                }
            }
            /// <inheritdoc cref="MultiDrawElementsIndirectEXT"/>
            public static unsafe void MultiDrawElementsIndirectEXT(PrimitiveType mode, DrawElementsType type, IntPtr indirect, int drawcount, int stride)
            {
                void* indirect_vptr = (void*)indirect;
                MultiDrawElementsIndirectEXT(mode, type, indirect_vptr, drawcount, stride);
            }
            /// <inheritdoc cref="MultiDrawElementsIndirectEXT"/>
            public static unsafe void MultiDrawElementsIndirectEXT<T1>(PrimitiveType mode, DrawElementsType type, ReadOnlySpan<T1> indirect, int drawcount, int stride)
                where T1 : unmanaged
            {
                fixed (void* indirect_ptr = indirect)
                {
                    MultiDrawElementsIndirectEXT(mode, type, indirect_ptr, drawcount, stride);
                }
            }
            /// <inheritdoc cref="MultiDrawElementsIndirectEXT"/>
            public static unsafe void MultiDrawElementsIndirectEXT<T1>(PrimitiveType mode, DrawElementsType type, T1[] indirect, int drawcount, int stride)
                where T1 : unmanaged
            {
                fixed (void* indirect_ptr = indirect)
                {
                    MultiDrawElementsIndirectEXT(mode, type, indirect_ptr, drawcount, stride);
                }
            }
            /// <inheritdoc cref="MultiDrawElementsIndirectEXT"/>
            public static unsafe void MultiDrawElementsIndirectEXT<T1>(PrimitiveType mode, DrawElementsType type, in T1 indirect, int drawcount, int stride)
                where T1 : unmanaged
            {
                fixed (void* indirect_ptr = &indirect)
                {
                    MultiDrawElementsIndirectEXT(mode, type, indirect_ptr, drawcount, stride);
                }
            }
            /// <inheritdoc cref="DrawBuffersIndexedEXT"/>
            public static unsafe void DrawBuffersIndexedEXT(int n, ReadOnlySpan<All> location, ReadOnlySpan<int> indices)
            {
                fixed (All* location_ptr = location)
                {
                    fixed (int* indices_ptr = indices)
                    {
                        DrawBuffersIndexedEXT(n, location_ptr, indices_ptr);
                    }
                }
            }
            /// <inheritdoc cref="DrawBuffersIndexedEXT"/>
            public static unsafe void DrawBuffersIndexedEXT(int n, All[] location, int[] indices)
            {
                fixed (All* location_ptr = location)
                {
                    fixed (int* indices_ptr = indices)
                    {
                        DrawBuffersIndexedEXT(n, location_ptr, indices_ptr);
                    }
                }
            }
            /// <inheritdoc cref="DrawBuffersIndexedEXT"/>
            public static unsafe void DrawBuffersIndexedEXT(int n, in All location, in int indices)
            {
                fixed (All* location_ptr = &location)
                fixed (int* indices_ptr = &indices)
                {
                    DrawBuffersIndexedEXT(n, location_ptr, indices_ptr);
                }
            }
            /// <inheritdoc cref="GetIntegeri_vEXT"/>
            public static unsafe void GetIntegeri_vEXT(GetPName target, uint index, ref int data)
            {
                fixed (int* data_ptr = &data)
                {
                    GetIntegeri_vEXT(target, index, data_ptr);
                }
            }
            /// <inheritdoc cref="ReadnPixelsEXT"/>
            public static unsafe void ReadnPixelsEXT(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, IntPtr data)
            {
                void* data_vptr = (void*)data;
                ReadnPixelsEXT(x, y, width, height, format, type, bufSize, data_vptr);
            }
            /// <inheritdoc cref="ReadnPixelsEXT"/>
            public static unsafe void ReadnPixelsEXT<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, Span<T1> data)
                where T1 : unmanaged
            {
                int bufSize = (int)(data.Length * sizeof(T1));
                fixed (void* data_ptr = data)
                {
                    ReadnPixelsEXT(x, y, width, height, format, type, bufSize, data_ptr);
                }
            }
            /// <inheritdoc cref="ReadnPixelsEXT"/>
            public static unsafe void ReadnPixelsEXT<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, T1[] data)
                where T1 : unmanaged
            {
                int bufSize = (int)(data.Length * sizeof(T1));
                fixed (void* data_ptr = data)
                {
                    ReadnPixelsEXT(x, y, width, height, format, type, bufSize, data_ptr);
                }
            }
            /// <inheritdoc cref="ReadnPixelsEXT"/>
            public static unsafe void ReadnPixelsEXT<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, ref T1 data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    ReadnPixelsEXT(x, y, width, height, format, type, bufSize, data_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformfvEXT"/>
            public static unsafe void GetnUniformfvEXT(ProgramHandle program, int location, Span<float> parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (float* parameters_ptr = parameters)
                {
                    GetnUniformfvEXT(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformfvEXT"/>
            public static unsafe void GetnUniformfvEXT(ProgramHandle program, int location, float[] parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (float* parameters_ptr = parameters)
                {
                    GetnUniformfvEXT(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformfvEXT"/>
            public static unsafe void GetnUniformfvEXT(ProgramHandle program, int location, int bufSize, ref float parameters)
            {
                fixed (float* parameters_ptr = &parameters)
                {
                    GetnUniformfvEXT(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformivEXT"/>
            public static unsafe void GetnUniformivEXT(ProgramHandle program, int location, Span<int> parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (int* parameters_ptr = parameters)
                {
                    GetnUniformivEXT(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformivEXT"/>
            public static unsafe void GetnUniformivEXT(ProgramHandle program, int location, int[] parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (int* parameters_ptr = parameters)
                {
                    GetnUniformivEXT(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformivEXT"/>
            public static unsafe void GetnUniformivEXT(ProgramHandle program, int location, int bufSize, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetnUniformivEXT(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GenSemaphoresEXT"/>
            public static unsafe void GenSemaphoresEXT(Span<uint> semaphores)
            {
                int n = (int)(semaphores.Length);
                fixed (uint* semaphores_ptr = semaphores)
                {
                    GenSemaphoresEXT(n, semaphores_ptr);
                }
            }
            /// <inheritdoc cref="GenSemaphoresEXT"/>
            public static unsafe void GenSemaphoresEXT(uint[] semaphores)
            {
                int n = (int)(semaphores.Length);
                fixed (uint* semaphores_ptr = semaphores)
                {
                    GenSemaphoresEXT(n, semaphores_ptr);
                }
            }
            /// <inheritdoc cref="GenSemaphoresEXT"/>
            public static unsafe void GenSemaphoresEXT(int n, ref uint semaphores)
            {
                fixed (uint* semaphores_ptr = &semaphores)
                {
                    GenSemaphoresEXT(n, semaphores_ptr);
                }
            }
            /// <inheritdoc cref="DeleteSemaphoresEXT"/>
            public static unsafe void DeleteSemaphoresEXT(ReadOnlySpan<uint> semaphores)
            {
                int n = (int)(semaphores.Length);
                fixed (uint* semaphores_ptr = semaphores)
                {
                    DeleteSemaphoresEXT(n, semaphores_ptr);
                }
            }
            /// <inheritdoc cref="DeleteSemaphoresEXT"/>
            public static unsafe void DeleteSemaphoresEXT(uint[] semaphores)
            {
                int n = (int)(semaphores.Length);
                fixed (uint* semaphores_ptr = semaphores)
                {
                    DeleteSemaphoresEXT(n, semaphores_ptr);
                }
            }
            /// <inheritdoc cref="DeleteSemaphoresEXT"/>
            public static unsafe void DeleteSemaphoresEXT(int n, in uint semaphores)
            {
                fixed (uint* semaphores_ptr = &semaphores)
                {
                    DeleteSemaphoresEXT(n, semaphores_ptr);
                }
            }
            /// <inheritdoc cref="SemaphoreParameterui64vEXT"/>
            public static unsafe void SemaphoreParameterui64vEXT(uint semaphore, SemaphoreParameterName pname, in ulong parameters)
            {
                fixed (ulong* parameters_ptr = &parameters)
                {
                    SemaphoreParameterui64vEXT(semaphore, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetSemaphoreParameterui64vEXT"/>
            public static unsafe void GetSemaphoreParameterui64vEXT(uint semaphore, SemaphoreParameterName pname, ref ulong parameters)
            {
                fixed (ulong* parameters_ptr = &parameters)
                {
                    GetSemaphoreParameterui64vEXT(semaphore, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="WaitSemaphoreEXT"/>
            public static unsafe void WaitSemaphoreEXT(uint semaphore, uint numBufferBarriers, ReadOnlySpan<BufferHandle> buffers, uint numTextureBarriers, ReadOnlySpan<TextureHandle> textures, ReadOnlySpan<TextureLayout> srcLayouts)
            {
                fixed (BufferHandle* buffers_ptr = buffers)
                {
                    fixed (TextureHandle* textures_ptr = textures)
                    {
                        fixed (TextureLayout* srcLayouts_ptr = srcLayouts)
                        {
                            WaitSemaphoreEXT(semaphore, numBufferBarriers, buffers_ptr, numTextureBarriers, textures_ptr, srcLayouts_ptr);
                        }
                    }
                }
            }
            /// <inheritdoc cref="WaitSemaphoreEXT"/>
            public static unsafe void WaitSemaphoreEXT(uint semaphore, uint numBufferBarriers, BufferHandle[] buffers, uint numTextureBarriers, TextureHandle[] textures, TextureLayout[] srcLayouts)
            {
                fixed (BufferHandle* buffers_ptr = buffers)
                {
                    fixed (TextureHandle* textures_ptr = textures)
                    {
                        fixed (TextureLayout* srcLayouts_ptr = srcLayouts)
                        {
                            WaitSemaphoreEXT(semaphore, numBufferBarriers, buffers_ptr, numTextureBarriers, textures_ptr, srcLayouts_ptr);
                        }
                    }
                }
            }
            /// <inheritdoc cref="WaitSemaphoreEXT"/>
            public static unsafe void WaitSemaphoreEXT(uint semaphore, uint numBufferBarriers, in BufferHandle buffers, uint numTextureBarriers, in TextureHandle textures, in TextureLayout srcLayouts)
            {
                fixed (BufferHandle* buffers_ptr = &buffers)
                fixed (TextureHandle* textures_ptr = &textures)
                fixed (TextureLayout* srcLayouts_ptr = &srcLayouts)
                {
                    WaitSemaphoreEXT(semaphore, numBufferBarriers, buffers_ptr, numTextureBarriers, textures_ptr, srcLayouts_ptr);
                }
            }
            /// <inheritdoc cref="SignalSemaphoreEXT"/>
            public static unsafe void SignalSemaphoreEXT(uint semaphore, uint numBufferBarriers, ReadOnlySpan<BufferHandle> buffers, uint numTextureBarriers, ReadOnlySpan<TextureHandle> textures, ReadOnlySpan<TextureLayout> dstLayouts)
            {
                fixed (BufferHandle* buffers_ptr = buffers)
                {
                    fixed (TextureHandle* textures_ptr = textures)
                    {
                        fixed (TextureLayout* dstLayouts_ptr = dstLayouts)
                        {
                            SignalSemaphoreEXT(semaphore, numBufferBarriers, buffers_ptr, numTextureBarriers, textures_ptr, dstLayouts_ptr);
                        }
                    }
                }
            }
            /// <inheritdoc cref="SignalSemaphoreEXT"/>
            public static unsafe void SignalSemaphoreEXT(uint semaphore, uint numBufferBarriers, BufferHandle[] buffers, uint numTextureBarriers, TextureHandle[] textures, TextureLayout[] dstLayouts)
            {
                fixed (BufferHandle* buffers_ptr = buffers)
                {
                    fixed (TextureHandle* textures_ptr = textures)
                    {
                        fixed (TextureLayout* dstLayouts_ptr = dstLayouts)
                        {
                            SignalSemaphoreEXT(semaphore, numBufferBarriers, buffers_ptr, numTextureBarriers, textures_ptr, dstLayouts_ptr);
                        }
                    }
                }
            }
            /// <inheritdoc cref="SignalSemaphoreEXT"/>
            public static unsafe void SignalSemaphoreEXT(uint semaphore, uint numBufferBarriers, in BufferHandle buffers, uint numTextureBarriers, in TextureHandle textures, in TextureLayout dstLayouts)
            {
                fixed (BufferHandle* buffers_ptr = &buffers)
                fixed (TextureHandle* textures_ptr = &textures)
                fixed (TextureLayout* dstLayouts_ptr = &dstLayouts)
                {
                    SignalSemaphoreEXT(semaphore, numBufferBarriers, buffers_ptr, numTextureBarriers, textures_ptr, dstLayouts_ptr);
                }
            }
            /// <inheritdoc cref="ImportSemaphoreWin32HandleEXT"/>
            public static unsafe void ImportSemaphoreWin32HandleEXT(uint semaphore, ExternalHandleType handleType, IntPtr handle)
            {
                void* handle_vptr = (void*)handle;
                ImportSemaphoreWin32HandleEXT(semaphore, handleType, handle_vptr);
            }
            /// <inheritdoc cref="ImportSemaphoreWin32HandleEXT"/>
            public static unsafe void ImportSemaphoreWin32HandleEXT<T1>(uint semaphore, ExternalHandleType handleType, ref T1 handle)
                where T1 : unmanaged
            {
                fixed (void* handle_ptr = &handle)
                {
                    ImportSemaphoreWin32HandleEXT(semaphore, handleType, handle_ptr);
                }
            }
            /// <inheritdoc cref="ImportSemaphoreWin32NameEXT"/>
            public static unsafe void ImportSemaphoreWin32NameEXT(uint semaphore, ExternalHandleType handleType, IntPtr name)
            {
                void* name_vptr = (void*)name;
                ImportSemaphoreWin32NameEXT(semaphore, handleType, name_vptr);
            }
            /// <inheritdoc cref="ImportSemaphoreWin32NameEXT"/>
            public static unsafe void ImportSemaphoreWin32NameEXT<T1>(uint semaphore, ExternalHandleType handleType, in T1 name)
                where T1 : unmanaged
            {
                fixed (void* name_ptr = &name)
                {
                    ImportSemaphoreWin32NameEXT(semaphore, handleType, name_ptr);
                }
            }
            /// <inheritdoc cref="CreateShaderProgramEXT"/>
            public static unsafe ProgramHandle CreateShaderProgramEXT(ShaderType type, string str)
            {
                ProgramHandle returnValue;
                byte* str_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(str);
                returnValue = CreateShaderProgramEXT(type, str_ptr);
                Marshal.FreeCoTaskMem((IntPtr)str_ptr);
                return returnValue;
            }
            /// <inheritdoc cref="DeleteProgramPipelinesEXT"/>
            public static unsafe void DeleteProgramPipelinesEXT(ReadOnlySpan<ProgramPipelineHandle> pipelines)
            {
                int n = (int)(pipelines.Length);
                fixed (ProgramPipelineHandle* pipelines_ptr = pipelines)
                {
                    DeleteProgramPipelinesEXT(n, pipelines_ptr);
                }
            }
            /// <inheritdoc cref="DeleteProgramPipelinesEXT"/>
            public static unsafe void DeleteProgramPipelinesEXT(ProgramPipelineHandle[] pipelines)
            {
                int n = (int)(pipelines.Length);
                fixed (ProgramPipelineHandle* pipelines_ptr = pipelines)
                {
                    DeleteProgramPipelinesEXT(n, pipelines_ptr);
                }
            }
            /// <inheritdoc cref="DeleteProgramPipelinesEXT"/>
            public static unsafe void DeleteProgramPipelinesEXT(int n, in ProgramPipelineHandle pipelines)
            {
                fixed (ProgramPipelineHandle* pipelines_ptr = &pipelines)
                {
                    DeleteProgramPipelinesEXT(n, pipelines_ptr);
                }
            }
            /// <inheritdoc cref="GenProgramPipelinesEXT"/>
            public static unsafe void GenProgramPipelinesEXT(Span<ProgramPipelineHandle> pipelines)
            {
                int n = (int)(pipelines.Length);
                fixed (ProgramPipelineHandle* pipelines_ptr = pipelines)
                {
                    GenProgramPipelinesEXT(n, pipelines_ptr);
                }
            }
            /// <inheritdoc cref="GenProgramPipelinesEXT"/>
            public static unsafe void GenProgramPipelinesEXT(ProgramPipelineHandle[] pipelines)
            {
                int n = (int)(pipelines.Length);
                fixed (ProgramPipelineHandle* pipelines_ptr = pipelines)
                {
                    GenProgramPipelinesEXT(n, pipelines_ptr);
                }
            }
            /// <inheritdoc cref="GenProgramPipelinesEXT"/>
            public static unsafe void GenProgramPipelinesEXT(int n, ref ProgramPipelineHandle pipelines)
            {
                fixed (ProgramPipelineHandle* pipelines_ptr = &pipelines)
                {
                    GenProgramPipelinesEXT(n, pipelines_ptr);
                }
            }
            /// <inheritdoc cref="GetProgramPipelineInfoLogEXT"/>
            public static unsafe string GetProgramPipelineInfoLogEXT(ProgramPipelineHandle pipeline, int bufSize, Span<int> length)
            {
                string infoLog;
                fixed (int* length_ptr = length)
                {
                    var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetProgramPipelineInfoLogEXT(pipeline, bufSize, length_ptr, infoLog_ptr);
                    infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
                }
                return infoLog;
            }
            /// <inheritdoc cref="GetProgramPipelineInfoLogEXT"/>
            public static unsafe void GetProgramPipelineInfoLogEXT(ProgramPipelineHandle pipeline, int bufSize, Span<int> length, out string infoLog)
            {
                fixed (int* length_ptr = length)
                {
                    var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetProgramPipelineInfoLogEXT(pipeline, bufSize, length_ptr, infoLog_ptr);
                    infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
                }
            }
            /// <inheritdoc cref="GetProgramPipelineInfoLogEXT"/>
            public static unsafe string GetProgramPipelineInfoLogEXT(ProgramPipelineHandle pipeline, int bufSize, int[] length)
            {
                string infoLog;
                fixed (int* length_ptr = length)
                {
                    var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetProgramPipelineInfoLogEXT(pipeline, bufSize, length_ptr, infoLog_ptr);
                    infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
                }
                return infoLog;
            }
            /// <inheritdoc cref="GetProgramPipelineInfoLogEXT"/>
            public static unsafe void GetProgramPipelineInfoLogEXT(ProgramPipelineHandle pipeline, int bufSize, int[] length, out string infoLog)
            {
                fixed (int* length_ptr = length)
                {
                    var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetProgramPipelineInfoLogEXT(pipeline, bufSize, length_ptr, infoLog_ptr);
                    infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
                }
            }
            /// <inheritdoc cref="GetProgramPipelineInfoLogEXT"/>
            public static unsafe string GetProgramPipelineInfoLogEXT(ProgramPipelineHandle pipeline, int bufSize, ref int length)
            {
                string infoLog;
                fixed (int* length_ptr = &length)
                {
                    var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetProgramPipelineInfoLogEXT(pipeline, bufSize, length_ptr, infoLog_ptr);
                    infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
                }
                return infoLog;
            }
            /// <inheritdoc cref="GetProgramPipelineInfoLogEXT"/>
            public static unsafe void GetProgramPipelineInfoLogEXT(ProgramPipelineHandle pipeline, int bufSize, ref int length, out string infoLog)
            {
                fixed (int* length_ptr = &length)
                {
                    var infoLog_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetProgramPipelineInfoLogEXT(pipeline, bufSize, length_ptr, infoLog_ptr);
                    infoLog = Marshal.PtrToStringUTF8((IntPtr)infoLog_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)infoLog_ptr);
                }
            }
            /// <inheritdoc cref="GetProgramPipelineivEXT"/>
            public static unsafe void GetProgramPipelineivEXT(ProgramPipelineHandle pipeline, PipelineParameterName pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetProgramPipelineivEXT(pipeline, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform1fvEXT"/>
            public static unsafe void ProgramUniform1fvEXT(ProgramHandle program, int location, ReadOnlySpan<float> value)
            {
                int count = (int)(value.Length);
                fixed (float* value_ptr = value)
                {
                    ProgramUniform1fvEXT(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform1fvEXT"/>
            public static unsafe void ProgramUniform1fvEXT(ProgramHandle program, int location, float[] value)
            {
                int count = (int)(value.Length);
                fixed (float* value_ptr = value)
                {
                    ProgramUniform1fvEXT(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform1fvEXT"/>
            public static unsafe void ProgramUniform1fvEXT(ProgramHandle program, int location, int count, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    ProgramUniform1fvEXT(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform1ivEXT"/>
            public static unsafe void ProgramUniform1ivEXT(ProgramHandle program, int location, ReadOnlySpan<int> value)
            {
                int count = (int)(value.Length);
                fixed (int* value_ptr = value)
                {
                    ProgramUniform1ivEXT(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform1ivEXT"/>
            public static unsafe void ProgramUniform1ivEXT(ProgramHandle program, int location, int[] value)
            {
                int count = (int)(value.Length);
                fixed (int* value_ptr = value)
                {
                    ProgramUniform1ivEXT(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform1ivEXT"/>
            public static unsafe void ProgramUniform1ivEXT(ProgramHandle program, int location, int count, in int value)
            {
                fixed (int* value_ptr = &value)
                {
                    ProgramUniform1ivEXT(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2fvEXT"/>
            public static unsafe void ProgramUniform2fvEXT(ProgramHandle program, int location, ReadOnlySpan<float> value)
            {
                int count = (int)(value.Length / 2);
                fixed (float* value_ptr = value)
                {
                    ProgramUniform2fvEXT(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2fvEXT"/>
            public static unsafe void ProgramUniform2fvEXT(ProgramHandle program, int location, float[] value)
            {
                int count = (int)(value.Length / 2);
                fixed (float* value_ptr = value)
                {
                    ProgramUniform2fvEXT(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2fvEXT"/>
            public static unsafe void ProgramUniform2fvEXT(ProgramHandle program, int location, int count, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    ProgramUniform2fvEXT(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2ivEXT"/>
            public static unsafe void ProgramUniform2ivEXT(ProgramHandle program, int location, ReadOnlySpan<int> value)
            {
                int count = (int)(value.Length / 2);
                fixed (int* value_ptr = value)
                {
                    ProgramUniform2ivEXT(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2ivEXT"/>
            public static unsafe void ProgramUniform2ivEXT(ProgramHandle program, int location, int[] value)
            {
                int count = (int)(value.Length / 2);
                fixed (int* value_ptr = value)
                {
                    ProgramUniform2ivEXT(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2ivEXT"/>
            public static unsafe void ProgramUniform2ivEXT(ProgramHandle program, int location, int count, in int value)
            {
                fixed (int* value_ptr = &value)
                {
                    ProgramUniform2ivEXT(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3fvEXT"/>
            public static unsafe void ProgramUniform3fvEXT(ProgramHandle program, int location, ReadOnlySpan<float> value)
            {
                int count = (int)(value.Length / 3);
                fixed (float* value_ptr = value)
                {
                    ProgramUniform3fvEXT(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3fvEXT"/>
            public static unsafe void ProgramUniform3fvEXT(ProgramHandle program, int location, float[] value)
            {
                int count = (int)(value.Length / 3);
                fixed (float* value_ptr = value)
                {
                    ProgramUniform3fvEXT(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3fvEXT"/>
            public static unsafe void ProgramUniform3fvEXT(ProgramHandle program, int location, int count, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    ProgramUniform3fvEXT(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3ivEXT"/>
            public static unsafe void ProgramUniform3ivEXT(ProgramHandle program, int location, ReadOnlySpan<int> value)
            {
                int count = (int)(value.Length / 3);
                fixed (int* value_ptr = value)
                {
                    ProgramUniform3ivEXT(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3ivEXT"/>
            public static unsafe void ProgramUniform3ivEXT(ProgramHandle program, int location, int[] value)
            {
                int count = (int)(value.Length / 3);
                fixed (int* value_ptr = value)
                {
                    ProgramUniform3ivEXT(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3ivEXT"/>
            public static unsafe void ProgramUniform3ivEXT(ProgramHandle program, int location, int count, in int value)
            {
                fixed (int* value_ptr = &value)
                {
                    ProgramUniform3ivEXT(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4fvEXT"/>
            public static unsafe void ProgramUniform4fvEXT(ProgramHandle program, int location, ReadOnlySpan<float> value)
            {
                int count = (int)(value.Length / 4);
                fixed (float* value_ptr = value)
                {
                    ProgramUniform4fvEXT(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4fvEXT"/>
            public static unsafe void ProgramUniform4fvEXT(ProgramHandle program, int location, float[] value)
            {
                int count = (int)(value.Length / 4);
                fixed (float* value_ptr = value)
                {
                    ProgramUniform4fvEXT(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4fvEXT"/>
            public static unsafe void ProgramUniform4fvEXT(ProgramHandle program, int location, int count, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    ProgramUniform4fvEXT(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4ivEXT"/>
            public static unsafe void ProgramUniform4ivEXT(ProgramHandle program, int location, ReadOnlySpan<int> value)
            {
                int count = (int)(value.Length / 4);
                fixed (int* value_ptr = value)
                {
                    ProgramUniform4ivEXT(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4ivEXT"/>
            public static unsafe void ProgramUniform4ivEXT(ProgramHandle program, int location, int[] value)
            {
                int count = (int)(value.Length / 4);
                fixed (int* value_ptr = value)
                {
                    ProgramUniform4ivEXT(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4ivEXT"/>
            public static unsafe void ProgramUniform4ivEXT(ProgramHandle program, int location, int count, in int value)
            {
                fixed (int* value_ptr = &value)
                {
                    ProgramUniform4ivEXT(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix2fvEXT"/>
            public static unsafe void ProgramUniformMatrix2fvEXT(ProgramHandle program, int location, bool transpose, ReadOnlySpan<float> value)
            {
                int count = (int)(value.Length / 4);
                fixed (float* value_ptr = value)
                {
                    ProgramUniformMatrix2fvEXT(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix2fvEXT"/>
            public static unsafe void ProgramUniformMatrix2fvEXT(ProgramHandle program, int location, bool transpose, float[] value)
            {
                int count = (int)(value.Length / 4);
                fixed (float* value_ptr = value)
                {
                    ProgramUniformMatrix2fvEXT(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix2fvEXT"/>
            public static unsafe void ProgramUniformMatrix2fvEXT(ProgramHandle program, int location, int count, bool transpose, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    ProgramUniformMatrix2fvEXT(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix3fvEXT"/>
            public static unsafe void ProgramUniformMatrix3fvEXT(ProgramHandle program, int location, bool transpose, ReadOnlySpan<float> value)
            {
                int count = (int)(value.Length / 9);
                fixed (float* value_ptr = value)
                {
                    ProgramUniformMatrix3fvEXT(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix3fvEXT"/>
            public static unsafe void ProgramUniformMatrix3fvEXT(ProgramHandle program, int location, bool transpose, float[] value)
            {
                int count = (int)(value.Length / 9);
                fixed (float* value_ptr = value)
                {
                    ProgramUniformMatrix3fvEXT(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix3fvEXT"/>
            public static unsafe void ProgramUniformMatrix3fvEXT(ProgramHandle program, int location, int count, bool transpose, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    ProgramUniformMatrix3fvEXT(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix4fvEXT"/>
            public static unsafe void ProgramUniformMatrix4fvEXT(ProgramHandle program, int location, bool transpose, ReadOnlySpan<float> value)
            {
                int count = (int)(value.Length / 16);
                fixed (float* value_ptr = value)
                {
                    ProgramUniformMatrix4fvEXT(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix4fvEXT"/>
            public static unsafe void ProgramUniformMatrix4fvEXT(ProgramHandle program, int location, bool transpose, float[] value)
            {
                int count = (int)(value.Length / 16);
                fixed (float* value_ptr = value)
                {
                    ProgramUniformMatrix4fvEXT(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix4fvEXT"/>
            public static unsafe void ProgramUniformMatrix4fvEXT(ProgramHandle program, int location, int count, bool transpose, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    ProgramUniformMatrix4fvEXT(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform1uivEXT"/>
            public static unsafe void ProgramUniform1uivEXT(ProgramHandle program, int location, ReadOnlySpan<uint> value)
            {
                int count = (int)(value.Length);
                fixed (uint* value_ptr = value)
                {
                    ProgramUniform1uivEXT(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform1uivEXT"/>
            public static unsafe void ProgramUniform1uivEXT(ProgramHandle program, int location, uint[] value)
            {
                int count = (int)(value.Length);
                fixed (uint* value_ptr = value)
                {
                    ProgramUniform1uivEXT(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform1uivEXT"/>
            public static unsafe void ProgramUniform1uivEXT(ProgramHandle program, int location, int count, in uint value)
            {
                fixed (uint* value_ptr = &value)
                {
                    ProgramUniform1uivEXT(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2uivEXT"/>
            public static unsafe void ProgramUniform2uivEXT(ProgramHandle program, int location, ReadOnlySpan<uint> value)
            {
                int count = (int)(value.Length / 2);
                fixed (uint* value_ptr = value)
                {
                    ProgramUniform2uivEXT(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2uivEXT"/>
            public static unsafe void ProgramUniform2uivEXT(ProgramHandle program, int location, uint[] value)
            {
                int count = (int)(value.Length / 2);
                fixed (uint* value_ptr = value)
                {
                    ProgramUniform2uivEXT(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2uivEXT"/>
            public static unsafe void ProgramUniform2uivEXT(ProgramHandle program, int location, int count, in uint value)
            {
                fixed (uint* value_ptr = &value)
                {
                    ProgramUniform2uivEXT(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3uivEXT"/>
            public static unsafe void ProgramUniform3uivEXT(ProgramHandle program, int location, ReadOnlySpan<uint> value)
            {
                int count = (int)(value.Length / 3);
                fixed (uint* value_ptr = value)
                {
                    ProgramUniform3uivEXT(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3uivEXT"/>
            public static unsafe void ProgramUniform3uivEXT(ProgramHandle program, int location, uint[] value)
            {
                int count = (int)(value.Length / 3);
                fixed (uint* value_ptr = value)
                {
                    ProgramUniform3uivEXT(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3uivEXT"/>
            public static unsafe void ProgramUniform3uivEXT(ProgramHandle program, int location, int count, in uint value)
            {
                fixed (uint* value_ptr = &value)
                {
                    ProgramUniform3uivEXT(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4uivEXT"/>
            public static unsafe void ProgramUniform4uivEXT(ProgramHandle program, int location, ReadOnlySpan<uint> value)
            {
                int count = (int)(value.Length / 4);
                fixed (uint* value_ptr = value)
                {
                    ProgramUniform4uivEXT(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4uivEXT"/>
            public static unsafe void ProgramUniform4uivEXT(ProgramHandle program, int location, uint[] value)
            {
                int count = (int)(value.Length / 4);
                fixed (uint* value_ptr = value)
                {
                    ProgramUniform4uivEXT(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4uivEXT"/>
            public static unsafe void ProgramUniform4uivEXT(ProgramHandle program, int location, int count, in uint value)
            {
                fixed (uint* value_ptr = &value)
                {
                    ProgramUniform4uivEXT(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix2x3fvEXT"/>
            public static unsafe void ProgramUniformMatrix2x3fvEXT(ProgramHandle program, int location, bool transpose, ReadOnlySpan<float> value)
            {
                int count = (int)(value.Length / 6);
                fixed (float* value_ptr = value)
                {
                    ProgramUniformMatrix2x3fvEXT(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix2x3fvEXT"/>
            public static unsafe void ProgramUniformMatrix2x3fvEXT(ProgramHandle program, int location, bool transpose, float[] value)
            {
                int count = (int)(value.Length / 6);
                fixed (float* value_ptr = value)
                {
                    ProgramUniformMatrix2x3fvEXT(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix2x3fvEXT"/>
            public static unsafe void ProgramUniformMatrix2x3fvEXT(ProgramHandle program, int location, int count, bool transpose, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    ProgramUniformMatrix2x3fvEXT(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix3x2fvEXT"/>
            public static unsafe void ProgramUniformMatrix3x2fvEXT(ProgramHandle program, int location, bool transpose, ReadOnlySpan<float> value)
            {
                int count = (int)(value.Length / 6);
                fixed (float* value_ptr = value)
                {
                    ProgramUniformMatrix3x2fvEXT(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix3x2fvEXT"/>
            public static unsafe void ProgramUniformMatrix3x2fvEXT(ProgramHandle program, int location, bool transpose, float[] value)
            {
                int count = (int)(value.Length / 6);
                fixed (float* value_ptr = value)
                {
                    ProgramUniformMatrix3x2fvEXT(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix3x2fvEXT"/>
            public static unsafe void ProgramUniformMatrix3x2fvEXT(ProgramHandle program, int location, int count, bool transpose, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    ProgramUniformMatrix3x2fvEXT(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix2x4fvEXT"/>
            public static unsafe void ProgramUniformMatrix2x4fvEXT(ProgramHandle program, int location, bool transpose, ReadOnlySpan<float> value)
            {
                int count = (int)(value.Length / 8);
                fixed (float* value_ptr = value)
                {
                    ProgramUniformMatrix2x4fvEXT(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix2x4fvEXT"/>
            public static unsafe void ProgramUniformMatrix2x4fvEXT(ProgramHandle program, int location, bool transpose, float[] value)
            {
                int count = (int)(value.Length / 8);
                fixed (float* value_ptr = value)
                {
                    ProgramUniformMatrix2x4fvEXT(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix2x4fvEXT"/>
            public static unsafe void ProgramUniformMatrix2x4fvEXT(ProgramHandle program, int location, int count, bool transpose, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    ProgramUniformMatrix2x4fvEXT(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix4x2fvEXT"/>
            public static unsafe void ProgramUniformMatrix4x2fvEXT(ProgramHandle program, int location, bool transpose, ReadOnlySpan<float> value)
            {
                int count = (int)(value.Length / 8);
                fixed (float* value_ptr = value)
                {
                    ProgramUniformMatrix4x2fvEXT(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix4x2fvEXT"/>
            public static unsafe void ProgramUniformMatrix4x2fvEXT(ProgramHandle program, int location, bool transpose, float[] value)
            {
                int count = (int)(value.Length / 8);
                fixed (float* value_ptr = value)
                {
                    ProgramUniformMatrix4x2fvEXT(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix4x2fvEXT"/>
            public static unsafe void ProgramUniformMatrix4x2fvEXT(ProgramHandle program, int location, int count, bool transpose, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    ProgramUniformMatrix4x2fvEXT(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix3x4fvEXT"/>
            public static unsafe void ProgramUniformMatrix3x4fvEXT(ProgramHandle program, int location, bool transpose, ReadOnlySpan<float> value)
            {
                int count = (int)(value.Length / 12);
                fixed (float* value_ptr = value)
                {
                    ProgramUniformMatrix3x4fvEXT(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix3x4fvEXT"/>
            public static unsafe void ProgramUniformMatrix3x4fvEXT(ProgramHandle program, int location, bool transpose, float[] value)
            {
                int count = (int)(value.Length / 12);
                fixed (float* value_ptr = value)
                {
                    ProgramUniformMatrix3x4fvEXT(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix3x4fvEXT"/>
            public static unsafe void ProgramUniformMatrix3x4fvEXT(ProgramHandle program, int location, int count, bool transpose, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    ProgramUniformMatrix3x4fvEXT(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix4x3fvEXT"/>
            public static unsafe void ProgramUniformMatrix4x3fvEXT(ProgramHandle program, int location, bool transpose, ReadOnlySpan<float> value)
            {
                int count = (int)(value.Length / 12);
                fixed (float* value_ptr = value)
                {
                    ProgramUniformMatrix4x3fvEXT(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix4x3fvEXT"/>
            public static unsafe void ProgramUniformMatrix4x3fvEXT(ProgramHandle program, int location, bool transpose, float[] value)
            {
                int count = (int)(value.Length / 12);
                fixed (float* value_ptr = value)
                {
                    ProgramUniformMatrix4x3fvEXT(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformMatrix4x3fvEXT"/>
            public static unsafe void ProgramUniformMatrix4x3fvEXT(ProgramHandle program, int location, int count, bool transpose, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    ProgramUniformMatrix4x3fvEXT(program, location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="ClearPixelLocalStorageuiEXT"/>
            public static unsafe void ClearPixelLocalStorageuiEXT(int offset, ReadOnlySpan<uint> values)
            {
                int n = (int)(values.Length);
                fixed (uint* values_ptr = values)
                {
                    ClearPixelLocalStorageuiEXT(offset, n, values_ptr);
                }
            }
            /// <inheritdoc cref="ClearPixelLocalStorageuiEXT"/>
            public static unsafe void ClearPixelLocalStorageuiEXT(int offset, uint[] values)
            {
                int n = (int)(values.Length);
                fixed (uint* values_ptr = values)
                {
                    ClearPixelLocalStorageuiEXT(offset, n, values_ptr);
                }
            }
            /// <inheritdoc cref="ClearPixelLocalStorageuiEXT"/>
            public static unsafe void ClearPixelLocalStorageuiEXT(int offset, int n, in uint values)
            {
                fixed (uint* values_ptr = &values)
                {
                    ClearPixelLocalStorageuiEXT(offset, n, values_ptr);
                }
            }
            /// <inheritdoc cref="TexParameterIivEXT"/>
            public static unsafe void TexParameterIivEXT(TextureTarget target, TextureParameterName pname, ReadOnlySpan<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    TexParameterIivEXT(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexParameterIivEXT"/>
            public static unsafe void TexParameterIivEXT(TextureTarget target, TextureParameterName pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    TexParameterIivEXT(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexParameterIivEXT"/>
            public static unsafe void TexParameterIivEXT(TextureTarget target, TextureParameterName pname, in int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    TexParameterIivEXT(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexParameterIuivEXT"/>
            public static unsafe void TexParameterIuivEXT(TextureTarget target, TextureParameterName pname, ReadOnlySpan<uint> parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    TexParameterIuivEXT(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexParameterIuivEXT"/>
            public static unsafe void TexParameterIuivEXT(TextureTarget target, TextureParameterName pname, uint[] parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    TexParameterIuivEXT(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexParameterIuivEXT"/>
            public static unsafe void TexParameterIuivEXT(TextureTarget target, TextureParameterName pname, in uint parameters)
            {
                fixed (uint* parameters_ptr = &parameters)
                {
                    TexParameterIuivEXT(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexParameterIivEXT"/>
            public static unsafe void GetTexParameterIivEXT(TextureTarget target, GetTextureParameter pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexParameterIivEXT(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexParameterIivEXT"/>
            public static unsafe void GetTexParameterIivEXT(TextureTarget target, GetTextureParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexParameterIivEXT(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexParameterIivEXT"/>
            public static unsafe void GetTexParameterIivEXT(TextureTarget target, GetTextureParameter pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetTexParameterIivEXT(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexParameterIuivEXT"/>
            public static unsafe void GetTexParameterIuivEXT(TextureTarget target, GetTextureParameter pname, Span<uint> parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    GetTexParameterIuivEXT(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexParameterIuivEXT"/>
            public static unsafe void GetTexParameterIuivEXT(TextureTarget target, GetTextureParameter pname, uint[] parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    GetTexParameterIuivEXT(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexParameterIuivEXT"/>
            public static unsafe void GetTexParameterIuivEXT(TextureTarget target, GetTextureParameter pname, ref uint parameters)
            {
                fixed (uint* parameters_ptr = &parameters)
                {
                    GetTexParameterIuivEXT(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="SamplerParameterIivEXT"/>
            public static unsafe void SamplerParameterIivEXT(SamplerHandle sampler, SamplerParameterI pname, ReadOnlySpan<int> param)
            {
                fixed (int* param_ptr = param)
                {
                    SamplerParameterIivEXT(sampler, pname, param_ptr);
                }
            }
            /// <inheritdoc cref="SamplerParameterIivEXT"/>
            public static unsafe void SamplerParameterIivEXT(SamplerHandle sampler, SamplerParameterI pname, int[] param)
            {
                fixed (int* param_ptr = param)
                {
                    SamplerParameterIivEXT(sampler, pname, param_ptr);
                }
            }
            /// <inheritdoc cref="SamplerParameterIivEXT"/>
            public static unsafe void SamplerParameterIivEXT(SamplerHandle sampler, SamplerParameterI pname, in int param)
            {
                fixed (int* param_ptr = &param)
                {
                    SamplerParameterIivEXT(sampler, pname, param_ptr);
                }
            }
            /// <inheritdoc cref="SamplerParameterIuivEXT"/>
            public static unsafe void SamplerParameterIuivEXT(SamplerHandle sampler, SamplerParameterI pname, ReadOnlySpan<uint> param)
            {
                fixed (uint* param_ptr = param)
                {
                    SamplerParameterIuivEXT(sampler, pname, param_ptr);
                }
            }
            /// <inheritdoc cref="SamplerParameterIuivEXT"/>
            public static unsafe void SamplerParameterIuivEXT(SamplerHandle sampler, SamplerParameterI pname, uint[] param)
            {
                fixed (uint* param_ptr = param)
                {
                    SamplerParameterIuivEXT(sampler, pname, param_ptr);
                }
            }
            /// <inheritdoc cref="SamplerParameterIuivEXT"/>
            public static unsafe void SamplerParameterIuivEXT(SamplerHandle sampler, SamplerParameterI pname, in uint param)
            {
                fixed (uint* param_ptr = &param)
                {
                    SamplerParameterIuivEXT(sampler, pname, param_ptr);
                }
            }
            /// <inheritdoc cref="GetSamplerParameterIivEXT"/>
            public static unsafe void GetSamplerParameterIivEXT(SamplerHandle sampler, SamplerParameterI pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetSamplerParameterIivEXT(sampler, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetSamplerParameterIivEXT"/>
            public static unsafe void GetSamplerParameterIivEXT(SamplerHandle sampler, SamplerParameterI pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetSamplerParameterIivEXT(sampler, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetSamplerParameterIivEXT"/>
            public static unsafe void GetSamplerParameterIivEXT(SamplerHandle sampler, SamplerParameterI pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetSamplerParameterIivEXT(sampler, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetSamplerParameterIuivEXT"/>
            public static unsafe void GetSamplerParameterIuivEXT(SamplerHandle sampler, SamplerParameterI pname, Span<uint> parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    GetSamplerParameterIuivEXT(sampler, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetSamplerParameterIuivEXT"/>
            public static unsafe void GetSamplerParameterIuivEXT(SamplerHandle sampler, SamplerParameterI pname, uint[] parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    GetSamplerParameterIuivEXT(sampler, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetSamplerParameterIuivEXT"/>
            public static unsafe void GetSamplerParameterIuivEXT(SamplerHandle sampler, SamplerParameterI pname, ref uint parameters)
            {
                fixed (uint* parameters_ptr = &parameters)
                {
                    GetSamplerParameterIuivEXT(sampler, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexStorageAttribs2DEXT"/>
            public static unsafe void TexStorageAttribs2DEXT(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height, in TexStorageAttribs attrib_list)
            {
                fixed (TexStorageAttribs* attrib_list_ptr = &attrib_list)
                {
                    TexStorageAttribs2DEXT(target, levels, internalformat, width, height, attrib_list_ptr);
                }
            }
            /// <inheritdoc cref="TexStorageAttribs3DEXT"/>
            public static unsafe void TexStorageAttribs3DEXT(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height, int depth, in TexStorageAttribs attrib_list)
            {
                fixed (TexStorageAttribs* attrib_list_ptr = &attrib_list)
                {
                    TexStorageAttribs3DEXT(target, levels, internalformat, width, height, depth, attrib_list_ptr);
                }
            }
            /// <inheritdoc cref="WindowRectanglesEXT"/>
            public static unsafe void WindowRectanglesEXT(All mode, int count, ReadOnlySpan<int> box)
            {
                fixed (int* box_ptr = box)
                {
                    WindowRectanglesEXT(mode, count, box_ptr);
                }
            }
            /// <inheritdoc cref="WindowRectanglesEXT"/>
            public static unsafe void WindowRectanglesEXT(All mode, int count, int[] box)
            {
                fixed (int* box_ptr = box)
                {
                    WindowRectanglesEXT(mode, count, box_ptr);
                }
            }
            /// <inheritdoc cref="WindowRectanglesEXT"/>
            public static unsafe void WindowRectanglesEXT(All mode, int count, in int box)
            {
                fixed (int* box_ptr = &box)
                {
                    WindowRectanglesEXT(mode, count, box_ptr);
                }
            }
        }
        public static unsafe partial class NV
        {
            /// <inheritdoc cref="CreateSemaphoresNV"/>
            public static unsafe void CreateSemaphoresNV(Span<uint> semaphores)
            {
                int n = (int)(semaphores.Length);
                fixed (uint* semaphores_ptr = semaphores)
                {
                    CreateSemaphoresNV(n, semaphores_ptr);
                }
            }
            /// <inheritdoc cref="CreateSemaphoresNV"/>
            public static unsafe void CreateSemaphoresNV(uint[] semaphores)
            {
                int n = (int)(semaphores.Length);
                fixed (uint* semaphores_ptr = semaphores)
                {
                    CreateSemaphoresNV(n, semaphores_ptr);
                }
            }
            /// <inheritdoc cref="CreateSemaphoresNV"/>
            public static unsafe void CreateSemaphoresNV(int n, ref uint semaphores)
            {
                fixed (uint* semaphores_ptr = &semaphores)
                {
                    CreateSemaphoresNV(n, semaphores_ptr);
                }
            }
            /// <inheritdoc cref="SemaphoreParameterivNV"/>
            public static unsafe void SemaphoreParameterivNV(uint semaphore, SemaphoreParameterName pname, in int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    SemaphoreParameterivNV(semaphore, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetSemaphoreParameterivNV"/>
            public static unsafe void GetSemaphoreParameterivNV(uint semaphore, SemaphoreParameterName pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetSemaphoreParameterivNV(semaphore, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="UniformHandleui64vNV"/>
            public static unsafe void UniformHandleui64vNV(int location, ReadOnlySpan<ulong> value)
            {
                int count = (int)(value.Length);
                fixed (ulong* value_ptr = value)
                {
                    UniformHandleui64vNV(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformHandleui64vNV"/>
            public static unsafe void UniformHandleui64vNV(int location, ulong[] value)
            {
                int count = (int)(value.Length);
                fixed (ulong* value_ptr = value)
                {
                    UniformHandleui64vNV(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformHandleui64vNV"/>
            public static unsafe void UniformHandleui64vNV(int location, int count, in ulong value)
            {
                fixed (ulong* value_ptr = &value)
                {
                    UniformHandleui64vNV(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformHandleui64vNV"/>
            public static unsafe void ProgramUniformHandleui64vNV(ProgramHandle program, int location, ReadOnlySpan<ulong> values)
            {
                int count = (int)(values.Length);
                fixed (ulong* values_ptr = values)
                {
                    ProgramUniformHandleui64vNV(program, location, count, values_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformHandleui64vNV"/>
            public static unsafe void ProgramUniformHandleui64vNV(ProgramHandle program, int location, ulong[] values)
            {
                int count = (int)(values.Length);
                fixed (ulong* values_ptr = values)
                {
                    ProgramUniformHandleui64vNV(program, location, count, values_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformHandleui64vNV"/>
            public static unsafe void ProgramUniformHandleui64vNV(ProgramHandle program, int location, int count, in ulong values)
            {
                fixed (ulong* values_ptr = &values)
                {
                    ProgramUniformHandleui64vNV(program, location, count, values_ptr);
                }
            }
            /// <inheritdoc cref="DrawBuffersNV"/>
            public static unsafe void DrawBuffersNV(ReadOnlySpan<All> bufs)
            {
                int n = (int)(bufs.Length);
                fixed (All* bufs_ptr = bufs)
                {
                    DrawBuffersNV(n, bufs_ptr);
                }
            }
            /// <inheritdoc cref="DrawBuffersNV"/>
            public static unsafe void DrawBuffersNV(All[] bufs)
            {
                int n = (int)(bufs.Length);
                fixed (All* bufs_ptr = bufs)
                {
                    DrawBuffersNV(n, bufs_ptr);
                }
            }
            /// <inheritdoc cref="DrawBuffersNV"/>
            public static unsafe void DrawBuffersNV(int n, in All bufs)
            {
                fixed (All* bufs_ptr = &bufs)
                {
                    DrawBuffersNV(n, bufs_ptr);
                }
            }
            /// <inheritdoc cref="DrawElementsInstancedNV"/>
            public static unsafe void DrawElementsInstancedNV(PrimitiveType mode, int count, PrimitiveType type, nint offset, int primcount)
            {
                void* indices = (void*)offset;
                DrawElementsInstancedNV(mode, count, type, indices, primcount);
            }
            /// <inheritdoc cref="GetVkProcAddrNV"/>
            public static unsafe IntPtr GetVkProcAddrNV(string name)
            {
                IntPtr returnValue;
                byte* name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(name);
                returnValue = GetVkProcAddrNV(name_ptr);
                Marshal.FreeCoTaskMem((IntPtr)name_ptr);
                return returnValue;
            }
            /// <inheritdoc cref="DeleteFencesNV"/>
            public static unsafe void DeleteFencesNV(ReadOnlySpan<uint> fences)
            {
                int n = (int)(fences.Length);
                fixed (uint* fences_ptr = fences)
                {
                    DeleteFencesNV(n, fences_ptr);
                }
            }
            /// <inheritdoc cref="DeleteFencesNV"/>
            public static unsafe void DeleteFencesNV(uint[] fences)
            {
                int n = (int)(fences.Length);
                fixed (uint* fences_ptr = fences)
                {
                    DeleteFencesNV(n, fences_ptr);
                }
            }
            /// <inheritdoc cref="DeleteFencesNV"/>
            public static unsafe void DeleteFencesNV(int n, in uint fences)
            {
                fixed (uint* fences_ptr = &fences)
                {
                    DeleteFencesNV(n, fences_ptr);
                }
            }
            /// <inheritdoc cref="GenFencesNV"/>
            public static unsafe void GenFencesNV(Span<uint> fences)
            {
                int n = (int)(fences.Length);
                fixed (uint* fences_ptr = fences)
                {
                    GenFencesNV(n, fences_ptr);
                }
            }
            /// <inheritdoc cref="GenFencesNV"/>
            public static unsafe void GenFencesNV(uint[] fences)
            {
                int n = (int)(fences.Length);
                fixed (uint* fences_ptr = fences)
                {
                    GenFencesNV(n, fences_ptr);
                }
            }
            /// <inheritdoc cref="GenFencesNV"/>
            public static unsafe void GenFencesNV(int n, ref uint fences)
            {
                fixed (uint* fences_ptr = &fences)
                {
                    GenFencesNV(n, fences_ptr);
                }
            }
            /// <inheritdoc cref="GetFenceivNV"/>
            public static unsafe void GetFenceivNV(uint fence, FenceParameterNameNV pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetFenceivNV(fence, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetFenceivNV"/>
            public static unsafe void GetFenceivNV(uint fence, FenceParameterNameNV pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetFenceivNV(fence, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetFenceivNV"/>
            public static unsafe void GetFenceivNV(uint fence, FenceParameterNameNV pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetFenceivNV(fence, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="CoverageModulationTableNV"/>
            public static unsafe void CoverageModulationTableNV(ReadOnlySpan<float> v)
            {
                int n = (int)(v.Length);
                fixed (float* v_ptr = v)
                {
                    CoverageModulationTableNV(n, v_ptr);
                }
            }
            /// <inheritdoc cref="CoverageModulationTableNV"/>
            public static unsafe void CoverageModulationTableNV(float[] v)
            {
                int n = (int)(v.Length);
                fixed (float* v_ptr = v)
                {
                    CoverageModulationTableNV(n, v_ptr);
                }
            }
            /// <inheritdoc cref="CoverageModulationTableNV"/>
            public static unsafe void CoverageModulationTableNV(int n, in float v)
            {
                fixed (float* v_ptr = &v)
                {
                    CoverageModulationTableNV(n, v_ptr);
                }
            }
            /// <inheritdoc cref="GetCoverageModulationTableNV"/>
            public static unsafe void GetCoverageModulationTableNV(int bufSize, ref float v)
            {
                fixed (float* v_ptr = &v)
                {
                    GetCoverageModulationTableNV(bufSize, v_ptr);
                }
            }
            /// <inheritdoc cref="Uniform1i64vNV"/>
            public static unsafe void Uniform1i64vNV(int location, ReadOnlySpan<long> value)
            {
                int count = (int)(value.Length / 1);
                fixed (long* value_ptr = value)
                {
                    Uniform1i64vNV(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform1i64vNV"/>
            public static unsafe void Uniform1i64vNV(int location, long[] value)
            {
                int count = (int)(value.Length / 1);
                fixed (long* value_ptr = value)
                {
                    Uniform1i64vNV(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform1i64vNV"/>
            public static unsafe void Uniform1i64vNV(int location, int count, in long value)
            {
                fixed (long* value_ptr = &value)
                {
                    Uniform1i64vNV(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform2i64vNV"/>
            public static unsafe void Uniform2i64vNV(int location, ReadOnlySpan<long> value)
            {
                int count = (int)(value.Length / 2);
                fixed (long* value_ptr = value)
                {
                    Uniform2i64vNV(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform2i64vNV"/>
            public static unsafe void Uniform2i64vNV(int location, long[] value)
            {
                int count = (int)(value.Length / 2);
                fixed (long* value_ptr = value)
                {
                    Uniform2i64vNV(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform2i64vNV"/>
            public static unsafe void Uniform2i64vNV(int location, int count, in long value)
            {
                fixed (long* value_ptr = &value)
                {
                    Uniform2i64vNV(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform3i64vNV"/>
            public static unsafe void Uniform3i64vNV(int location, ReadOnlySpan<long> value)
            {
                int count = (int)(value.Length / 3);
                fixed (long* value_ptr = value)
                {
                    Uniform3i64vNV(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform3i64vNV"/>
            public static unsafe void Uniform3i64vNV(int location, long[] value)
            {
                int count = (int)(value.Length / 3);
                fixed (long* value_ptr = value)
                {
                    Uniform3i64vNV(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform3i64vNV"/>
            public static unsafe void Uniform3i64vNV(int location, int count, in long value)
            {
                fixed (long* value_ptr = &value)
                {
                    Uniform3i64vNV(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform4i64vNV"/>
            public static unsafe void Uniform4i64vNV(int location, ReadOnlySpan<long> value)
            {
                int count = (int)(value.Length / 4);
                fixed (long* value_ptr = value)
                {
                    Uniform4i64vNV(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform4i64vNV"/>
            public static unsafe void Uniform4i64vNV(int location, long[] value)
            {
                int count = (int)(value.Length / 4);
                fixed (long* value_ptr = value)
                {
                    Uniform4i64vNV(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform4i64vNV"/>
            public static unsafe void Uniform4i64vNV(int location, int count, in long value)
            {
                fixed (long* value_ptr = &value)
                {
                    Uniform4i64vNV(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform1ui64vNV"/>
            public static unsafe void Uniform1ui64vNV(int location, ReadOnlySpan<ulong> value)
            {
                int count = (int)(value.Length / 1);
                fixed (ulong* value_ptr = value)
                {
                    Uniform1ui64vNV(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform1ui64vNV"/>
            public static unsafe void Uniform1ui64vNV(int location, ulong[] value)
            {
                int count = (int)(value.Length / 1);
                fixed (ulong* value_ptr = value)
                {
                    Uniform1ui64vNV(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform1ui64vNV"/>
            public static unsafe void Uniform1ui64vNV(int location, int count, in ulong value)
            {
                fixed (ulong* value_ptr = &value)
                {
                    Uniform1ui64vNV(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform2ui64vNV"/>
            public static unsafe void Uniform2ui64vNV(int location, ReadOnlySpan<ulong> value)
            {
                int count = (int)(value.Length / 2);
                fixed (ulong* value_ptr = value)
                {
                    Uniform2ui64vNV(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform2ui64vNV"/>
            public static unsafe void Uniform2ui64vNV(int location, ulong[] value)
            {
                int count = (int)(value.Length / 2);
                fixed (ulong* value_ptr = value)
                {
                    Uniform2ui64vNV(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform2ui64vNV"/>
            public static unsafe void Uniform2ui64vNV(int location, int count, in ulong value)
            {
                fixed (ulong* value_ptr = &value)
                {
                    Uniform2ui64vNV(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform3ui64vNV"/>
            public static unsafe void Uniform3ui64vNV(int location, ReadOnlySpan<ulong> value)
            {
                int count = (int)(value.Length / 3);
                fixed (ulong* value_ptr = value)
                {
                    Uniform3ui64vNV(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform3ui64vNV"/>
            public static unsafe void Uniform3ui64vNV(int location, ulong[] value)
            {
                int count = (int)(value.Length / 3);
                fixed (ulong* value_ptr = value)
                {
                    Uniform3ui64vNV(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform3ui64vNV"/>
            public static unsafe void Uniform3ui64vNV(int location, int count, in ulong value)
            {
                fixed (ulong* value_ptr = &value)
                {
                    Uniform3ui64vNV(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform4ui64vNV"/>
            public static unsafe void Uniform4ui64vNV(int location, ReadOnlySpan<ulong> value)
            {
                int count = (int)(value.Length / 4);
                fixed (ulong* value_ptr = value)
                {
                    Uniform4ui64vNV(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform4ui64vNV"/>
            public static unsafe void Uniform4ui64vNV(int location, ulong[] value)
            {
                int count = (int)(value.Length / 4);
                fixed (ulong* value_ptr = value)
                {
                    Uniform4ui64vNV(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="Uniform4ui64vNV"/>
            public static unsafe void Uniform4ui64vNV(int location, int count, in ulong value)
            {
                fixed (ulong* value_ptr = &value)
                {
                    Uniform4ui64vNV(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="GetUniformi64vNV"/>
            public static unsafe void GetUniformi64vNV(ProgramHandle program, int location, Span<long> parameters)
            {
                fixed (long* parameters_ptr = parameters)
                {
                    GetUniformi64vNV(program, location, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetUniformi64vNV"/>
            public static unsafe void GetUniformi64vNV(ProgramHandle program, int location, long[] parameters)
            {
                fixed (long* parameters_ptr = parameters)
                {
                    GetUniformi64vNV(program, location, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetUniformi64vNV"/>
            public static unsafe void GetUniformi64vNV(ProgramHandle program, int location, ref long parameters)
            {
                fixed (long* parameters_ptr = &parameters)
                {
                    GetUniformi64vNV(program, location, parameters_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform1i64vNV"/>
            public static unsafe void ProgramUniform1i64vNV(ProgramHandle program, int location, ReadOnlySpan<long> value)
            {
                int count = (int)(value.Length);
                fixed (long* value_ptr = value)
                {
                    ProgramUniform1i64vNV(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform1i64vNV"/>
            public static unsafe void ProgramUniform1i64vNV(ProgramHandle program, int location, long[] value)
            {
                int count = (int)(value.Length);
                fixed (long* value_ptr = value)
                {
                    ProgramUniform1i64vNV(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform1i64vNV"/>
            public static unsafe void ProgramUniform1i64vNV(ProgramHandle program, int location, int count, in long value)
            {
                fixed (long* value_ptr = &value)
                {
                    ProgramUniform1i64vNV(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2i64vNV"/>
            public static unsafe void ProgramUniform2i64vNV(ProgramHandle program, int location, ReadOnlySpan<long> value)
            {
                int count = (int)(value.Length / 2);
                fixed (long* value_ptr = value)
                {
                    ProgramUniform2i64vNV(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2i64vNV"/>
            public static unsafe void ProgramUniform2i64vNV(ProgramHandle program, int location, long[] value)
            {
                int count = (int)(value.Length / 2);
                fixed (long* value_ptr = value)
                {
                    ProgramUniform2i64vNV(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2i64vNV"/>
            public static unsafe void ProgramUniform2i64vNV(ProgramHandle program, int location, int count, in long value)
            {
                fixed (long* value_ptr = &value)
                {
                    ProgramUniform2i64vNV(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3i64vNV"/>
            public static unsafe void ProgramUniform3i64vNV(ProgramHandle program, int location, ReadOnlySpan<long> value)
            {
                int count = (int)(value.Length / 3);
                fixed (long* value_ptr = value)
                {
                    ProgramUniform3i64vNV(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3i64vNV"/>
            public static unsafe void ProgramUniform3i64vNV(ProgramHandle program, int location, long[] value)
            {
                int count = (int)(value.Length / 3);
                fixed (long* value_ptr = value)
                {
                    ProgramUniform3i64vNV(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3i64vNV"/>
            public static unsafe void ProgramUniform3i64vNV(ProgramHandle program, int location, int count, in long value)
            {
                fixed (long* value_ptr = &value)
                {
                    ProgramUniform3i64vNV(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4i64vNV"/>
            public static unsafe void ProgramUniform4i64vNV(ProgramHandle program, int location, ReadOnlySpan<long> value)
            {
                int count = (int)(value.Length / 4);
                fixed (long* value_ptr = value)
                {
                    ProgramUniform4i64vNV(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4i64vNV"/>
            public static unsafe void ProgramUniform4i64vNV(ProgramHandle program, int location, long[] value)
            {
                int count = (int)(value.Length / 4);
                fixed (long* value_ptr = value)
                {
                    ProgramUniform4i64vNV(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4i64vNV"/>
            public static unsafe void ProgramUniform4i64vNV(ProgramHandle program, int location, int count, in long value)
            {
                fixed (long* value_ptr = &value)
                {
                    ProgramUniform4i64vNV(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform1ui64vNV"/>
            public static unsafe void ProgramUniform1ui64vNV(ProgramHandle program, int location, ReadOnlySpan<ulong> value)
            {
                int count = (int)(value.Length);
                fixed (ulong* value_ptr = value)
                {
                    ProgramUniform1ui64vNV(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform1ui64vNV"/>
            public static unsafe void ProgramUniform1ui64vNV(ProgramHandle program, int location, ulong[] value)
            {
                int count = (int)(value.Length);
                fixed (ulong* value_ptr = value)
                {
                    ProgramUniform1ui64vNV(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform1ui64vNV"/>
            public static unsafe void ProgramUniform1ui64vNV(ProgramHandle program, int location, int count, in ulong value)
            {
                fixed (ulong* value_ptr = &value)
                {
                    ProgramUniform1ui64vNV(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2ui64vNV"/>
            public static unsafe void ProgramUniform2ui64vNV(ProgramHandle program, int location, ReadOnlySpan<ulong> value)
            {
                int count = (int)(value.Length / 2);
                fixed (ulong* value_ptr = value)
                {
                    ProgramUniform2ui64vNV(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2ui64vNV"/>
            public static unsafe void ProgramUniform2ui64vNV(ProgramHandle program, int location, ulong[] value)
            {
                int count = (int)(value.Length / 2);
                fixed (ulong* value_ptr = value)
                {
                    ProgramUniform2ui64vNV(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform2ui64vNV"/>
            public static unsafe void ProgramUniform2ui64vNV(ProgramHandle program, int location, int count, in ulong value)
            {
                fixed (ulong* value_ptr = &value)
                {
                    ProgramUniform2ui64vNV(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3ui64vNV"/>
            public static unsafe void ProgramUniform3ui64vNV(ProgramHandle program, int location, ReadOnlySpan<ulong> value)
            {
                int count = (int)(value.Length / 3);
                fixed (ulong* value_ptr = value)
                {
                    ProgramUniform3ui64vNV(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3ui64vNV"/>
            public static unsafe void ProgramUniform3ui64vNV(ProgramHandle program, int location, ulong[] value)
            {
                int count = (int)(value.Length / 3);
                fixed (ulong* value_ptr = value)
                {
                    ProgramUniform3ui64vNV(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform3ui64vNV"/>
            public static unsafe void ProgramUniform3ui64vNV(ProgramHandle program, int location, int count, in ulong value)
            {
                fixed (ulong* value_ptr = &value)
                {
                    ProgramUniform3ui64vNV(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4ui64vNV"/>
            public static unsafe void ProgramUniform4ui64vNV(ProgramHandle program, int location, ReadOnlySpan<ulong> value)
            {
                int count = (int)(value.Length / 4);
                fixed (ulong* value_ptr = value)
                {
                    ProgramUniform4ui64vNV(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4ui64vNV"/>
            public static unsafe void ProgramUniform4ui64vNV(ProgramHandle program, int location, ulong[] value)
            {
                int count = (int)(value.Length / 4);
                fixed (ulong* value_ptr = value)
                {
                    ProgramUniform4ui64vNV(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniform4ui64vNV"/>
            public static unsafe void ProgramUniform4ui64vNV(ProgramHandle program, int location, int count, in ulong value)
            {
                fixed (ulong* value_ptr = &value)
                {
                    ProgramUniform4ui64vNV(program, location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="GetInternalformatSampleivNV"/>
            public static unsafe void GetInternalformatSampleivNV(TextureTarget target, InternalFormat internalformat, int samples, InternalFormatPName pname, Span<int> parameters)
            {
                int count = (int)(parameters.Length);
                fixed (int* parameters_ptr = parameters)
                {
                    GetInternalformatSampleivNV(target, internalformat, samples, pname, count, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetInternalformatSampleivNV"/>
            public static unsafe void GetInternalformatSampleivNV(TextureTarget target, InternalFormat internalformat, int samples, InternalFormatPName pname, int[] parameters)
            {
                int count = (int)(parameters.Length);
                fixed (int* parameters_ptr = parameters)
                {
                    GetInternalformatSampleivNV(target, internalformat, samples, pname, count, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetInternalformatSampleivNV"/>
            public static unsafe void GetInternalformatSampleivNV(TextureTarget target, InternalFormat internalformat, int samples, InternalFormatPName pname, int count, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetInternalformatSampleivNV(target, internalformat, samples, pname, count, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetMemoryObjectDetachedResourcesuivNV"/>
            public static unsafe void GetMemoryObjectDetachedResourcesuivNV(uint memory, All pname, int first, int count, ref uint parameters)
            {
                fixed (uint* parameters_ptr = &parameters)
                {
                    GetMemoryObjectDetachedResourcesuivNV(memory, pname, first, count, parameters_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix2x3fvNV"/>
            public static unsafe void UniformMatrix2x3fvNV(int location, bool transpose, ReadOnlySpan<float> value)
            {
                int count = (int)(value.Length / 6);
                fixed (float* value_ptr = value)
                {
                    UniformMatrix2x3fvNV(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix2x3fvNV"/>
            public static unsafe void UniformMatrix2x3fvNV(int location, bool transpose, float[] value)
            {
                int count = (int)(value.Length / 6);
                fixed (float* value_ptr = value)
                {
                    UniformMatrix2x3fvNV(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix2x3fvNV"/>
            public static unsafe void UniformMatrix2x3fvNV(int location, int count, bool transpose, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    UniformMatrix2x3fvNV(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix3x2fvNV"/>
            public static unsafe void UniformMatrix3x2fvNV(int location, bool transpose, ReadOnlySpan<float> value)
            {
                int count = (int)(value.Length / 6);
                fixed (float* value_ptr = value)
                {
                    UniformMatrix3x2fvNV(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix3x2fvNV"/>
            public static unsafe void UniformMatrix3x2fvNV(int location, bool transpose, float[] value)
            {
                int count = (int)(value.Length / 6);
                fixed (float* value_ptr = value)
                {
                    UniformMatrix3x2fvNV(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix3x2fvNV"/>
            public static unsafe void UniformMatrix3x2fvNV(int location, int count, bool transpose, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    UniformMatrix3x2fvNV(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix2x4fvNV"/>
            public static unsafe void UniformMatrix2x4fvNV(int location, bool transpose, ReadOnlySpan<float> value)
            {
                int count = (int)(value.Length / 8);
                fixed (float* value_ptr = value)
                {
                    UniformMatrix2x4fvNV(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix2x4fvNV"/>
            public static unsafe void UniformMatrix2x4fvNV(int location, bool transpose, float[] value)
            {
                int count = (int)(value.Length / 8);
                fixed (float* value_ptr = value)
                {
                    UniformMatrix2x4fvNV(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix2x4fvNV"/>
            public static unsafe void UniformMatrix2x4fvNV(int location, int count, bool transpose, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    UniformMatrix2x4fvNV(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix4x2fvNV"/>
            public static unsafe void UniformMatrix4x2fvNV(int location, bool transpose, ReadOnlySpan<float> value)
            {
                int count = (int)(value.Length / 8);
                fixed (float* value_ptr = value)
                {
                    UniformMatrix4x2fvNV(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix4x2fvNV"/>
            public static unsafe void UniformMatrix4x2fvNV(int location, bool transpose, float[] value)
            {
                int count = (int)(value.Length / 8);
                fixed (float* value_ptr = value)
                {
                    UniformMatrix4x2fvNV(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix4x2fvNV"/>
            public static unsafe void UniformMatrix4x2fvNV(int location, int count, bool transpose, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    UniformMatrix4x2fvNV(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix3x4fvNV"/>
            public static unsafe void UniformMatrix3x4fvNV(int location, bool transpose, ReadOnlySpan<float> value)
            {
                int count = (int)(value.Length / 12);
                fixed (float* value_ptr = value)
                {
                    UniformMatrix3x4fvNV(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix3x4fvNV"/>
            public static unsafe void UniformMatrix3x4fvNV(int location, bool transpose, float[] value)
            {
                int count = (int)(value.Length / 12);
                fixed (float* value_ptr = value)
                {
                    UniformMatrix3x4fvNV(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix3x4fvNV"/>
            public static unsafe void UniformMatrix3x4fvNV(int location, int count, bool transpose, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    UniformMatrix3x4fvNV(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix4x3fvNV"/>
            public static unsafe void UniformMatrix4x3fvNV(int location, bool transpose, ReadOnlySpan<float> value)
            {
                int count = (int)(value.Length / 12);
                fixed (float* value_ptr = value)
                {
                    UniformMatrix4x3fvNV(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix4x3fvNV"/>
            public static unsafe void UniformMatrix4x3fvNV(int location, bool transpose, float[] value)
            {
                int count = (int)(value.Length / 12);
                fixed (float* value_ptr = value)
                {
                    UniformMatrix4x3fvNV(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformMatrix4x3fvNV"/>
            public static unsafe void UniformMatrix4x3fvNV(int location, int count, bool transpose, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    UniformMatrix4x3fvNV(location, count, transpose, value_ptr);
                }
            }
            /// <inheritdoc cref="PathCommandsNV"/>
            public static unsafe void PathCommandsNV(uint path, ReadOnlySpan<byte> commands, int numCoords, PathCoordType coordType, IntPtr coords)
            {
                int numCommands = (int)(commands.Length);
                fixed (byte* commands_ptr = commands)
                {
                    void* coords_vptr = (void*)coords;
                    PathCommandsNV(path, numCommands, commands_ptr, numCoords, coordType, coords_vptr);
                }
            }
            /// <inheritdoc cref="PathCommandsNV"/>
            public static unsafe void PathCommandsNV(uint path, byte[] commands, int numCoords, PathCoordType coordType, IntPtr coords)
            {
                int numCommands = (int)(commands.Length);
                fixed (byte* commands_ptr = commands)
                {
                    void* coords_vptr = (void*)coords;
                    PathCommandsNV(path, numCommands, commands_ptr, numCoords, coordType, coords_vptr);
                }
            }
            /// <inheritdoc cref="PathCommandsNV"/>
            public static unsafe void PathCommandsNV(uint path, int numCommands, in byte commands, int numCoords, PathCoordType coordType, IntPtr coords)
            {
                fixed (byte* commands_ptr = &commands)
                {
                    void* coords_vptr = (void*)coords;
                    PathCommandsNV(path, numCommands, commands_ptr, numCoords, coordType, coords_vptr);
                }
            }
            /// <inheritdoc cref="PathCommandsNV"/>
            public static unsafe void PathCommandsNV<T1>(uint path, ReadOnlySpan<byte> commands, int numCoords, PathCoordType coordType, ReadOnlySpan<T1> coords)
                where T1 : unmanaged
            {
                int numCommands = (int)(commands.Length);
                fixed (byte* commands_ptr = commands)
                {
                    fixed (void* coords_ptr = coords)
                    {
                        PathCommandsNV(path, numCommands, commands_ptr, numCoords, coordType, coords_ptr);
                    }
                }
            }
            /// <inheritdoc cref="PathCommandsNV"/>
            public static unsafe void PathCommandsNV<T1>(uint path, byte[] commands, int numCoords, PathCoordType coordType, T1[] coords)
                where T1 : unmanaged
            {
                int numCommands = (int)(commands.Length);
                fixed (byte* commands_ptr = commands)
                {
                    fixed (void* coords_ptr = coords)
                    {
                        PathCommandsNV(path, numCommands, commands_ptr, numCoords, coordType, coords_ptr);
                    }
                }
            }
            /// <inheritdoc cref="PathCommandsNV"/>
            public static unsafe void PathCommandsNV<T1>(uint path, int numCommands, in byte commands, int numCoords, PathCoordType coordType, in T1 coords)
                where T1 : unmanaged
            {
                fixed (byte* commands_ptr = &commands)
                fixed (void* coords_ptr = &coords)
                {
                    PathCommandsNV(path, numCommands, commands_ptr, numCoords, coordType, coords_ptr);
                }
            }
            /// <inheritdoc cref="PathCoordsNV"/>
            public static unsafe void PathCoordsNV(uint path, int numCoords, PathCoordType coordType, IntPtr coords)
            {
                void* coords_vptr = (void*)coords;
                PathCoordsNV(path, numCoords, coordType, coords_vptr);
            }
            /// <inheritdoc cref="PathCoordsNV"/>
            public static unsafe void PathCoordsNV<T1>(uint path, int numCoords, PathCoordType coordType, ReadOnlySpan<T1> coords)
                where T1 : unmanaged
            {
                fixed (void* coords_ptr = coords)
                {
                    PathCoordsNV(path, numCoords, coordType, coords_ptr);
                }
            }
            /// <inheritdoc cref="PathCoordsNV"/>
            public static unsafe void PathCoordsNV<T1>(uint path, int numCoords, PathCoordType coordType, T1[] coords)
                where T1 : unmanaged
            {
                fixed (void* coords_ptr = coords)
                {
                    PathCoordsNV(path, numCoords, coordType, coords_ptr);
                }
            }
            /// <inheritdoc cref="PathCoordsNV"/>
            public static unsafe void PathCoordsNV<T1>(uint path, int numCoords, PathCoordType coordType, in T1 coords)
                where T1 : unmanaged
            {
                fixed (void* coords_ptr = &coords)
                {
                    PathCoordsNV(path, numCoords, coordType, coords_ptr);
                }
            }
            /// <inheritdoc cref="PathSubCommandsNV"/>
            public static unsafe void PathSubCommandsNV(uint path, int commandStart, int commandsToDelete, ReadOnlySpan<byte> commands, int numCoords, PathCoordType coordType, IntPtr coords)
            {
                int numCommands = (int)(commands.Length);
                fixed (byte* commands_ptr = commands)
                {
                    void* coords_vptr = (void*)coords;
                    PathSubCommandsNV(path, commandStart, commandsToDelete, numCommands, commands_ptr, numCoords, coordType, coords_vptr);
                }
            }
            /// <inheritdoc cref="PathSubCommandsNV"/>
            public static unsafe void PathSubCommandsNV(uint path, int commandStart, int commandsToDelete, byte[] commands, int numCoords, PathCoordType coordType, IntPtr coords)
            {
                int numCommands = (int)(commands.Length);
                fixed (byte* commands_ptr = commands)
                {
                    void* coords_vptr = (void*)coords;
                    PathSubCommandsNV(path, commandStart, commandsToDelete, numCommands, commands_ptr, numCoords, coordType, coords_vptr);
                }
            }
            /// <inheritdoc cref="PathSubCommandsNV"/>
            public static unsafe void PathSubCommandsNV(uint path, int commandStart, int commandsToDelete, int numCommands, in byte commands, int numCoords, PathCoordType coordType, IntPtr coords)
            {
                fixed (byte* commands_ptr = &commands)
                {
                    void* coords_vptr = (void*)coords;
                    PathSubCommandsNV(path, commandStart, commandsToDelete, numCommands, commands_ptr, numCoords, coordType, coords_vptr);
                }
            }
            /// <inheritdoc cref="PathSubCommandsNV"/>
            public static unsafe void PathSubCommandsNV<T1>(uint path, int commandStart, int commandsToDelete, ReadOnlySpan<byte> commands, int numCoords, PathCoordType coordType, ReadOnlySpan<T1> coords)
                where T1 : unmanaged
            {
                int numCommands = (int)(commands.Length);
                fixed (byte* commands_ptr = commands)
                {
                    fixed (void* coords_ptr = coords)
                    {
                        PathSubCommandsNV(path, commandStart, commandsToDelete, numCommands, commands_ptr, numCoords, coordType, coords_ptr);
                    }
                }
            }
            /// <inheritdoc cref="PathSubCommandsNV"/>
            public static unsafe void PathSubCommandsNV<T1>(uint path, int commandStart, int commandsToDelete, byte[] commands, int numCoords, PathCoordType coordType, T1[] coords)
                where T1 : unmanaged
            {
                int numCommands = (int)(commands.Length);
                fixed (byte* commands_ptr = commands)
                {
                    fixed (void* coords_ptr = coords)
                    {
                        PathSubCommandsNV(path, commandStart, commandsToDelete, numCommands, commands_ptr, numCoords, coordType, coords_ptr);
                    }
                }
            }
            /// <inheritdoc cref="PathSubCommandsNV"/>
            public static unsafe void PathSubCommandsNV<T1>(uint path, int commandStart, int commandsToDelete, int numCommands, in byte commands, int numCoords, PathCoordType coordType, in T1 coords)
                where T1 : unmanaged
            {
                fixed (byte* commands_ptr = &commands)
                fixed (void* coords_ptr = &coords)
                {
                    PathSubCommandsNV(path, commandStart, commandsToDelete, numCommands, commands_ptr, numCoords, coordType, coords_ptr);
                }
            }
            /// <inheritdoc cref="PathSubCoordsNV"/>
            public static unsafe void PathSubCoordsNV(uint path, int coordStart, int numCoords, PathCoordType coordType, IntPtr coords)
            {
                void* coords_vptr = (void*)coords;
                PathSubCoordsNV(path, coordStart, numCoords, coordType, coords_vptr);
            }
            /// <inheritdoc cref="PathSubCoordsNV"/>
            public static unsafe void PathSubCoordsNV<T1>(uint path, int coordStart, int numCoords, PathCoordType coordType, ReadOnlySpan<T1> coords)
                where T1 : unmanaged
            {
                fixed (void* coords_ptr = coords)
                {
                    PathSubCoordsNV(path, coordStart, numCoords, coordType, coords_ptr);
                }
            }
            /// <inheritdoc cref="PathSubCoordsNV"/>
            public static unsafe void PathSubCoordsNV<T1>(uint path, int coordStart, int numCoords, PathCoordType coordType, T1[] coords)
                where T1 : unmanaged
            {
                fixed (void* coords_ptr = coords)
                {
                    PathSubCoordsNV(path, coordStart, numCoords, coordType, coords_ptr);
                }
            }
            /// <inheritdoc cref="PathSubCoordsNV"/>
            public static unsafe void PathSubCoordsNV<T1>(uint path, int coordStart, int numCoords, PathCoordType coordType, in T1 coords)
                where T1 : unmanaged
            {
                fixed (void* coords_ptr = &coords)
                {
                    PathSubCoordsNV(path, coordStart, numCoords, coordType, coords_ptr);
                }
            }
            /// <inheritdoc cref="PathStringNV"/>
            public static unsafe void PathStringNV(uint path, PathStringFormat format, int length, IntPtr pathString)
            {
                void* pathString_vptr = (void*)pathString;
                PathStringNV(path, format, length, pathString_vptr);
            }
            /// <inheritdoc cref="PathStringNV"/>
            public static unsafe void PathStringNV<T1>(uint path, PathStringFormat format, ReadOnlySpan<T1> pathString)
                where T1 : unmanaged
            {
                int length = (int)(pathString.Length * sizeof(T1));
                fixed (void* pathString_ptr = pathString)
                {
                    PathStringNV(path, format, length, pathString_ptr);
                }
            }
            /// <inheritdoc cref="PathStringNV"/>
            public static unsafe void PathStringNV<T1>(uint path, PathStringFormat format, T1[] pathString)
                where T1 : unmanaged
            {
                int length = (int)(pathString.Length * sizeof(T1));
                fixed (void* pathString_ptr = pathString)
                {
                    PathStringNV(path, format, length, pathString_ptr);
                }
            }
            /// <inheritdoc cref="PathStringNV"/>
            public static unsafe void PathStringNV<T1>(uint path, PathStringFormat format, int length, in T1 pathString)
                where T1 : unmanaged
            {
                fixed (void* pathString_ptr = &pathString)
                {
                    PathStringNV(path, format, length, pathString_ptr);
                }
            }
            /// <inheritdoc cref="PathGlyphsNV"/>
            public static unsafe void PathGlyphsNV(uint firstPathName, PathFontTarget fontTarget, IntPtr fontName, PathFontStyle fontStyle, int numGlyphs, PathElementType type, IntPtr charcodes, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale)
            {
                void* fontName_vptr = (void*)fontName;
                void* charcodes_vptr = (void*)charcodes;
                PathGlyphsNV(firstPathName, fontTarget, fontName_vptr, fontStyle, numGlyphs, type, charcodes_vptr, handleMissingGlyphs, pathParameterTemplate, emScale);
            }
            /// <inheritdoc cref="PathGlyphsNV"/>
            public static unsafe void PathGlyphsNV<T1, T2>(uint firstPathName, PathFontTarget fontTarget, ReadOnlySpan<T2> fontName, PathFontStyle fontStyle, int numGlyphs, PathElementType type, ReadOnlySpan<T1> charcodes, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                fixed (void* fontName_ptr = fontName)
                {
                    fixed (void* charcodes_ptr = charcodes)
                    {
                        PathGlyphsNV(firstPathName, fontTarget, fontName_ptr, fontStyle, numGlyphs, type, charcodes_ptr, handleMissingGlyphs, pathParameterTemplate, emScale);
                    }
                }
            }
            /// <inheritdoc cref="PathGlyphsNV"/>
            public static unsafe void PathGlyphsNV<T1, T2>(uint firstPathName, PathFontTarget fontTarget, T2[] fontName, PathFontStyle fontStyle, int numGlyphs, PathElementType type, T1[] charcodes, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                fixed (void* fontName_ptr = fontName)
                {
                    fixed (void* charcodes_ptr = charcodes)
                    {
                        PathGlyphsNV(firstPathName, fontTarget, fontName_ptr, fontStyle, numGlyphs, type, charcodes_ptr, handleMissingGlyphs, pathParameterTemplate, emScale);
                    }
                }
            }
            /// <inheritdoc cref="PathGlyphsNV"/>
            public static unsafe void PathGlyphsNV<T1, T2>(uint firstPathName, PathFontTarget fontTarget, in T1 fontName, PathFontStyle fontStyle, int numGlyphs, PathElementType type, in T2 charcodes, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                fixed (void* fontName_ptr = &fontName)
                fixed (void* charcodes_ptr = &charcodes)
                {
                    PathGlyphsNV(firstPathName, fontTarget, fontName_ptr, fontStyle, numGlyphs, type, charcodes_ptr, handleMissingGlyphs, pathParameterTemplate, emScale);
                }
            }
            /// <inheritdoc cref="PathGlyphRangeNV"/>
            public static unsafe void PathGlyphRangeNV(uint firstPathName, PathFontTarget fontTarget, IntPtr fontName, PathFontStyle fontStyle, uint firstGlyph, int numGlyphs, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale)
            {
                void* fontName_vptr = (void*)fontName;
                PathGlyphRangeNV(firstPathName, fontTarget, fontName_vptr, fontStyle, firstGlyph, numGlyphs, handleMissingGlyphs, pathParameterTemplate, emScale);
            }
            /// <inheritdoc cref="PathGlyphRangeNV"/>
            public static unsafe void PathGlyphRangeNV<T1>(uint firstPathName, PathFontTarget fontTarget, ReadOnlySpan<T1> fontName, PathFontStyle fontStyle, uint firstGlyph, int numGlyphs, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale)
                where T1 : unmanaged
            {
                fixed (void* fontName_ptr = fontName)
                {
                    PathGlyphRangeNV(firstPathName, fontTarget, fontName_ptr, fontStyle, firstGlyph, numGlyphs, handleMissingGlyphs, pathParameterTemplate, emScale);
                }
            }
            /// <inheritdoc cref="PathGlyphRangeNV"/>
            public static unsafe void PathGlyphRangeNV<T1>(uint firstPathName, PathFontTarget fontTarget, T1[] fontName, PathFontStyle fontStyle, uint firstGlyph, int numGlyphs, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale)
                where T1 : unmanaged
            {
                fixed (void* fontName_ptr = fontName)
                {
                    PathGlyphRangeNV(firstPathName, fontTarget, fontName_ptr, fontStyle, firstGlyph, numGlyphs, handleMissingGlyphs, pathParameterTemplate, emScale);
                }
            }
            /// <inheritdoc cref="PathGlyphRangeNV"/>
            public static unsafe void PathGlyphRangeNV<T1>(uint firstPathName, PathFontTarget fontTarget, in T1 fontName, PathFontStyle fontStyle, uint firstGlyph, int numGlyphs, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale)
                where T1 : unmanaged
            {
                fixed (void* fontName_ptr = &fontName)
                {
                    PathGlyphRangeNV(firstPathName, fontTarget, fontName_ptr, fontStyle, firstGlyph, numGlyphs, handleMissingGlyphs, pathParameterTemplate, emScale);
                }
            }
            /// <inheritdoc cref="WeightPathsNV"/>
            public static unsafe void WeightPathsNV(uint resultPath, int numPaths, ReadOnlySpan<uint> paths, ReadOnlySpan<float> weights)
            {
                fixed (uint* paths_ptr = paths)
                {
                    fixed (float* weights_ptr = weights)
                    {
                        WeightPathsNV(resultPath, numPaths, paths_ptr, weights_ptr);
                    }
                }
            }
            /// <inheritdoc cref="WeightPathsNV"/>
            public static unsafe void WeightPathsNV(uint resultPath, int numPaths, uint[] paths, float[] weights)
            {
                fixed (uint* paths_ptr = paths)
                {
                    fixed (float* weights_ptr = weights)
                    {
                        WeightPathsNV(resultPath, numPaths, paths_ptr, weights_ptr);
                    }
                }
            }
            /// <inheritdoc cref="WeightPathsNV"/>
            public static unsafe void WeightPathsNV(uint resultPath, int numPaths, in uint paths, in float weights)
            {
                fixed (uint* paths_ptr = &paths)
                fixed (float* weights_ptr = &weights)
                {
                    WeightPathsNV(resultPath, numPaths, paths_ptr, weights_ptr);
                }
            }
            /// <inheritdoc cref="TransformPathNV"/>
            public static unsafe void TransformPathNV(uint resultPath, uint srcPath, PathTransformType transformType, ReadOnlySpan<float> transformValues)
            {
                fixed (float* transformValues_ptr = transformValues)
                {
                    TransformPathNV(resultPath, srcPath, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="TransformPathNV"/>
            public static unsafe void TransformPathNV(uint resultPath, uint srcPath, PathTransformType transformType, float[] transformValues)
            {
                fixed (float* transformValues_ptr = transformValues)
                {
                    TransformPathNV(resultPath, srcPath, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="TransformPathNV"/>
            public static unsafe void TransformPathNV(uint resultPath, uint srcPath, PathTransformType transformType, in float transformValues)
            {
                fixed (float* transformValues_ptr = &transformValues)
                {
                    TransformPathNV(resultPath, srcPath, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="PathParameterivNV"/>
            public static unsafe void PathParameterivNV(uint path, PathParameter pname, ReadOnlySpan<int> value)
            {
                fixed (int* value_ptr = value)
                {
                    PathParameterivNV(path, pname, value_ptr);
                }
            }
            /// <inheritdoc cref="PathParameterivNV"/>
            public static unsafe void PathParameterivNV(uint path, PathParameter pname, int[] value)
            {
                fixed (int* value_ptr = value)
                {
                    PathParameterivNV(path, pname, value_ptr);
                }
            }
            /// <inheritdoc cref="PathParameterivNV"/>
            public static unsafe void PathParameterivNV(uint path, PathParameter pname, in int value)
            {
                fixed (int* value_ptr = &value)
                {
                    PathParameterivNV(path, pname, value_ptr);
                }
            }
            /// <inheritdoc cref="PathParameterfvNV"/>
            public static unsafe void PathParameterfvNV(uint path, PathParameter pname, ReadOnlySpan<float> value)
            {
                fixed (float* value_ptr = value)
                {
                    PathParameterfvNV(path, pname, value_ptr);
                }
            }
            /// <inheritdoc cref="PathParameterfvNV"/>
            public static unsafe void PathParameterfvNV(uint path, PathParameter pname, float[] value)
            {
                fixed (float* value_ptr = value)
                {
                    PathParameterfvNV(path, pname, value_ptr);
                }
            }
            /// <inheritdoc cref="PathParameterfvNV"/>
            public static unsafe void PathParameterfvNV(uint path, PathParameter pname, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    PathParameterfvNV(path, pname, value_ptr);
                }
            }
            /// <inheritdoc cref="PathDashArrayNV"/>
            public static unsafe void PathDashArrayNV(uint path, ReadOnlySpan<float> dashArray)
            {
                int dashCount = (int)(dashArray.Length);
                fixed (float* dashArray_ptr = dashArray)
                {
                    PathDashArrayNV(path, dashCount, dashArray_ptr);
                }
            }
            /// <inheritdoc cref="PathDashArrayNV"/>
            public static unsafe void PathDashArrayNV(uint path, float[] dashArray)
            {
                int dashCount = (int)(dashArray.Length);
                fixed (float* dashArray_ptr = dashArray)
                {
                    PathDashArrayNV(path, dashCount, dashArray_ptr);
                }
            }
            /// <inheritdoc cref="PathDashArrayNV"/>
            public static unsafe void PathDashArrayNV(uint path, int dashCount, in float dashArray)
            {
                fixed (float* dashArray_ptr = &dashArray)
                {
                    PathDashArrayNV(path, dashCount, dashArray_ptr);
                }
            }
            /// <inheritdoc cref="StencilFillPathInstancedNV"/>
            public static unsafe void StencilFillPathInstancedNV(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, PathFillMode fillMode, uint mask, PathTransformType transformType, ReadOnlySpan<float> transformValues)
            {
                fixed (float* transformValues_ptr = transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    StencilFillPathInstancedNV(numPaths, pathNameType, paths_vptr, pathBase, fillMode, mask, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="StencilFillPathInstancedNV"/>
            public static unsafe void StencilFillPathInstancedNV(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, PathFillMode fillMode, uint mask, PathTransformType transformType, float[] transformValues)
            {
                fixed (float* transformValues_ptr = transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    StencilFillPathInstancedNV(numPaths, pathNameType, paths_vptr, pathBase, fillMode, mask, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="StencilFillPathInstancedNV"/>
            public static unsafe void StencilFillPathInstancedNV(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, PathFillMode fillMode, uint mask, PathTransformType transformType, in float transformValues)
            {
                fixed (float* transformValues_ptr = &transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    StencilFillPathInstancedNV(numPaths, pathNameType, paths_vptr, pathBase, fillMode, mask, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="StencilFillPathInstancedNV"/>
            public static unsafe void StencilFillPathInstancedNV<T1>(int numPaths, PathElementType pathNameType, ReadOnlySpan<T1> paths, uint pathBase, PathFillMode fillMode, uint mask, PathTransformType transformType, ReadOnlySpan<float> transformValues)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = paths)
                {
                    fixed (float* transformValues_ptr = transformValues)
                    {
                        StencilFillPathInstancedNV(numPaths, pathNameType, paths_ptr, pathBase, fillMode, mask, transformType, transformValues_ptr);
                    }
                }
            }
            /// <inheritdoc cref="StencilFillPathInstancedNV"/>
            public static unsafe void StencilFillPathInstancedNV<T1>(int numPaths, PathElementType pathNameType, T1[] paths, uint pathBase, PathFillMode fillMode, uint mask, PathTransformType transformType, float[] transformValues)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = paths)
                {
                    fixed (float* transformValues_ptr = transformValues)
                    {
                        StencilFillPathInstancedNV(numPaths, pathNameType, paths_ptr, pathBase, fillMode, mask, transformType, transformValues_ptr);
                    }
                }
            }
            /// <inheritdoc cref="StencilFillPathInstancedNV"/>
            public static unsafe void StencilFillPathInstancedNV<T1>(int numPaths, PathElementType pathNameType, in T1 paths, uint pathBase, PathFillMode fillMode, uint mask, PathTransformType transformType, in float transformValues)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = &paths)
                fixed (float* transformValues_ptr = &transformValues)
                {
                    StencilFillPathInstancedNV(numPaths, pathNameType, paths_ptr, pathBase, fillMode, mask, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="StencilStrokePathInstancedNV"/>
            public static unsafe void StencilStrokePathInstancedNV(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, int reference, uint mask, PathTransformType transformType, ReadOnlySpan<float> transformValues)
            {
                fixed (float* transformValues_ptr = transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    StencilStrokePathInstancedNV(numPaths, pathNameType, paths_vptr, pathBase, reference, mask, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="StencilStrokePathInstancedNV"/>
            public static unsafe void StencilStrokePathInstancedNV(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, int reference, uint mask, PathTransformType transformType, float[] transformValues)
            {
                fixed (float* transformValues_ptr = transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    StencilStrokePathInstancedNV(numPaths, pathNameType, paths_vptr, pathBase, reference, mask, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="StencilStrokePathInstancedNV"/>
            public static unsafe void StencilStrokePathInstancedNV(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, int reference, uint mask, PathTransformType transformType, in float transformValues)
            {
                fixed (float* transformValues_ptr = &transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    StencilStrokePathInstancedNV(numPaths, pathNameType, paths_vptr, pathBase, reference, mask, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="StencilStrokePathInstancedNV"/>
            public static unsafe void StencilStrokePathInstancedNV<T1>(int numPaths, PathElementType pathNameType, ReadOnlySpan<T1> paths, uint pathBase, int reference, uint mask, PathTransformType transformType, ReadOnlySpan<float> transformValues)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = paths)
                {
                    fixed (float* transformValues_ptr = transformValues)
                    {
                        StencilStrokePathInstancedNV(numPaths, pathNameType, paths_ptr, pathBase, reference, mask, transformType, transformValues_ptr);
                    }
                }
            }
            /// <inheritdoc cref="StencilStrokePathInstancedNV"/>
            public static unsafe void StencilStrokePathInstancedNV<T1>(int numPaths, PathElementType pathNameType, T1[] paths, uint pathBase, int reference, uint mask, PathTransformType transformType, float[] transformValues)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = paths)
                {
                    fixed (float* transformValues_ptr = transformValues)
                    {
                        StencilStrokePathInstancedNV(numPaths, pathNameType, paths_ptr, pathBase, reference, mask, transformType, transformValues_ptr);
                    }
                }
            }
            /// <inheritdoc cref="StencilStrokePathInstancedNV"/>
            public static unsafe void StencilStrokePathInstancedNV<T1>(int numPaths, PathElementType pathNameType, in T1 paths, uint pathBase, int reference, uint mask, PathTransformType transformType, in float transformValues)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = &paths)
                fixed (float* transformValues_ptr = &transformValues)
                {
                    StencilStrokePathInstancedNV(numPaths, pathNameType, paths_ptr, pathBase, reference, mask, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="CoverFillPathInstancedNV"/>
            public static unsafe void CoverFillPathInstancedNV(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, PathCoverMode coverMode, PathTransformType transformType, ReadOnlySpan<float> transformValues)
            {
                fixed (float* transformValues_ptr = transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    CoverFillPathInstancedNV(numPaths, pathNameType, paths_vptr, pathBase, coverMode, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="CoverFillPathInstancedNV"/>
            public static unsafe void CoverFillPathInstancedNV(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, PathCoverMode coverMode, PathTransformType transformType, float[] transformValues)
            {
                fixed (float* transformValues_ptr = transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    CoverFillPathInstancedNV(numPaths, pathNameType, paths_vptr, pathBase, coverMode, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="CoverFillPathInstancedNV"/>
            public static unsafe void CoverFillPathInstancedNV(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, PathCoverMode coverMode, PathTransformType transformType, in float transformValues)
            {
                fixed (float* transformValues_ptr = &transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    CoverFillPathInstancedNV(numPaths, pathNameType, paths_vptr, pathBase, coverMode, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="CoverFillPathInstancedNV"/>
            public static unsafe void CoverFillPathInstancedNV<T1>(int numPaths, PathElementType pathNameType, ReadOnlySpan<T1> paths, uint pathBase, PathCoverMode coverMode, PathTransformType transformType, ReadOnlySpan<float> transformValues)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = paths)
                {
                    fixed (float* transformValues_ptr = transformValues)
                    {
                        CoverFillPathInstancedNV(numPaths, pathNameType, paths_ptr, pathBase, coverMode, transformType, transformValues_ptr);
                    }
                }
            }
            /// <inheritdoc cref="CoverFillPathInstancedNV"/>
            public static unsafe void CoverFillPathInstancedNV<T1>(int numPaths, PathElementType pathNameType, T1[] paths, uint pathBase, PathCoverMode coverMode, PathTransformType transformType, float[] transformValues)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = paths)
                {
                    fixed (float* transformValues_ptr = transformValues)
                    {
                        CoverFillPathInstancedNV(numPaths, pathNameType, paths_ptr, pathBase, coverMode, transformType, transformValues_ptr);
                    }
                }
            }
            /// <inheritdoc cref="CoverFillPathInstancedNV"/>
            public static unsafe void CoverFillPathInstancedNV<T1>(int numPaths, PathElementType pathNameType, in T1 paths, uint pathBase, PathCoverMode coverMode, PathTransformType transformType, in float transformValues)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = &paths)
                fixed (float* transformValues_ptr = &transformValues)
                {
                    CoverFillPathInstancedNV(numPaths, pathNameType, paths_ptr, pathBase, coverMode, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="CoverStrokePathInstancedNV"/>
            public static unsafe void CoverStrokePathInstancedNV(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, PathCoverMode coverMode, PathTransformType transformType, ReadOnlySpan<float> transformValues)
            {
                fixed (float* transformValues_ptr = transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    CoverStrokePathInstancedNV(numPaths, pathNameType, paths_vptr, pathBase, coverMode, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="CoverStrokePathInstancedNV"/>
            public static unsafe void CoverStrokePathInstancedNV(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, PathCoverMode coverMode, PathTransformType transformType, float[] transformValues)
            {
                fixed (float* transformValues_ptr = transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    CoverStrokePathInstancedNV(numPaths, pathNameType, paths_vptr, pathBase, coverMode, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="CoverStrokePathInstancedNV"/>
            public static unsafe void CoverStrokePathInstancedNV(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, PathCoverMode coverMode, PathTransformType transformType, in float transformValues)
            {
                fixed (float* transformValues_ptr = &transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    CoverStrokePathInstancedNV(numPaths, pathNameType, paths_vptr, pathBase, coverMode, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="CoverStrokePathInstancedNV"/>
            public static unsafe void CoverStrokePathInstancedNV<T1>(int numPaths, PathElementType pathNameType, ReadOnlySpan<T1> paths, uint pathBase, PathCoverMode coverMode, PathTransformType transformType, ReadOnlySpan<float> transformValues)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = paths)
                {
                    fixed (float* transformValues_ptr = transformValues)
                    {
                        CoverStrokePathInstancedNV(numPaths, pathNameType, paths_ptr, pathBase, coverMode, transformType, transformValues_ptr);
                    }
                }
            }
            /// <inheritdoc cref="CoverStrokePathInstancedNV"/>
            public static unsafe void CoverStrokePathInstancedNV<T1>(int numPaths, PathElementType pathNameType, T1[] paths, uint pathBase, PathCoverMode coverMode, PathTransformType transformType, float[] transformValues)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = paths)
                {
                    fixed (float* transformValues_ptr = transformValues)
                    {
                        CoverStrokePathInstancedNV(numPaths, pathNameType, paths_ptr, pathBase, coverMode, transformType, transformValues_ptr);
                    }
                }
            }
            /// <inheritdoc cref="CoverStrokePathInstancedNV"/>
            public static unsafe void CoverStrokePathInstancedNV<T1>(int numPaths, PathElementType pathNameType, in T1 paths, uint pathBase, PathCoverMode coverMode, PathTransformType transformType, in float transformValues)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = &paths)
                fixed (float* transformValues_ptr = &transformValues)
                {
                    CoverStrokePathInstancedNV(numPaths, pathNameType, paths_ptr, pathBase, coverMode, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="GetPathParameterivNV"/>
            public static unsafe void GetPathParameterivNV(uint path, PathParameter pname, Span<int> value)
            {
                fixed (int* value_ptr = value)
                {
                    GetPathParameterivNV(path, pname, value_ptr);
                }
            }
            /// <inheritdoc cref="GetPathParameterivNV"/>
            public static unsafe void GetPathParameterivNV(uint path, PathParameter pname, int[] value)
            {
                fixed (int* value_ptr = value)
                {
                    GetPathParameterivNV(path, pname, value_ptr);
                }
            }
            /// <inheritdoc cref="GetPathParameterivNV"/>
            public static unsafe void GetPathParameterivNV(uint path, PathParameter pname, ref int value)
            {
                fixed (int* value_ptr = &value)
                {
                    GetPathParameterivNV(path, pname, value_ptr);
                }
            }
            /// <inheritdoc cref="GetPathParameterfvNV"/>
            public static unsafe void GetPathParameterfvNV(uint path, PathParameter pname, Span<float> value)
            {
                fixed (float* value_ptr = value)
                {
                    GetPathParameterfvNV(path, pname, value_ptr);
                }
            }
            /// <inheritdoc cref="GetPathParameterfvNV"/>
            public static unsafe void GetPathParameterfvNV(uint path, PathParameter pname, float[] value)
            {
                fixed (float* value_ptr = value)
                {
                    GetPathParameterfvNV(path, pname, value_ptr);
                }
            }
            /// <inheritdoc cref="GetPathParameterfvNV"/>
            public static unsafe void GetPathParameterfvNV(uint path, PathParameter pname, ref float value)
            {
                fixed (float* value_ptr = &value)
                {
                    GetPathParameterfvNV(path, pname, value_ptr);
                }
            }
            /// <inheritdoc cref="GetPathCommandsNV"/>
            public static unsafe void GetPathCommandsNV(uint path, Span<byte> commands)
            {
                fixed (byte* commands_ptr = commands)
                {
                    GetPathCommandsNV(path, commands_ptr);
                }
            }
            /// <inheritdoc cref="GetPathCommandsNV"/>
            public static unsafe void GetPathCommandsNV(uint path, byte[] commands)
            {
                fixed (byte* commands_ptr = commands)
                {
                    GetPathCommandsNV(path, commands_ptr);
                }
            }
            /// <inheritdoc cref="GetPathCommandsNV"/>
            public static unsafe void GetPathCommandsNV(uint path, ref byte commands)
            {
                fixed (byte* commands_ptr = &commands)
                {
                    GetPathCommandsNV(path, commands_ptr);
                }
            }
            /// <inheritdoc cref="GetPathCoordsNV"/>
            public static unsafe void GetPathCoordsNV(uint path, Span<float> coords)
            {
                fixed (float* coords_ptr = coords)
                {
                    GetPathCoordsNV(path, coords_ptr);
                }
            }
            /// <inheritdoc cref="GetPathCoordsNV"/>
            public static unsafe void GetPathCoordsNV(uint path, float[] coords)
            {
                fixed (float* coords_ptr = coords)
                {
                    GetPathCoordsNV(path, coords_ptr);
                }
            }
            /// <inheritdoc cref="GetPathCoordsNV"/>
            public static unsafe void GetPathCoordsNV(uint path, ref float coords)
            {
                fixed (float* coords_ptr = &coords)
                {
                    GetPathCoordsNV(path, coords_ptr);
                }
            }
            /// <inheritdoc cref="GetPathDashArrayNV"/>
            public static unsafe void GetPathDashArrayNV(uint path, Span<float> dashArray)
            {
                fixed (float* dashArray_ptr = dashArray)
                {
                    GetPathDashArrayNV(path, dashArray_ptr);
                }
            }
            /// <inheritdoc cref="GetPathDashArrayNV"/>
            public static unsafe void GetPathDashArrayNV(uint path, float[] dashArray)
            {
                fixed (float* dashArray_ptr = dashArray)
                {
                    GetPathDashArrayNV(path, dashArray_ptr);
                }
            }
            /// <inheritdoc cref="GetPathDashArrayNV"/>
            public static unsafe void GetPathDashArrayNV(uint path, ref float dashArray)
            {
                fixed (float* dashArray_ptr = &dashArray)
                {
                    GetPathDashArrayNV(path, dashArray_ptr);
                }
            }
            /// <inheritdoc cref="GetPathMetricsNV"/>
            public static unsafe void GetPathMetricsNV(PathMetricMask metricQueryMask, int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, int stride, Span<float> metrics)
            {
                fixed (float* metrics_ptr = metrics)
                {
                    void* paths_vptr = (void*)paths;
                    GetPathMetricsNV(metricQueryMask, numPaths, pathNameType, paths_vptr, pathBase, stride, metrics_ptr);
                }
            }
            /// <inheritdoc cref="GetPathMetricsNV"/>
            public static unsafe void GetPathMetricsNV(PathMetricMask metricQueryMask, int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, int stride, float[] metrics)
            {
                fixed (float* metrics_ptr = metrics)
                {
                    void* paths_vptr = (void*)paths;
                    GetPathMetricsNV(metricQueryMask, numPaths, pathNameType, paths_vptr, pathBase, stride, metrics_ptr);
                }
            }
            /// <inheritdoc cref="GetPathMetricsNV"/>
            public static unsafe void GetPathMetricsNV(PathMetricMask metricQueryMask, int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, int stride, ref float metrics)
            {
                fixed (float* metrics_ptr = &metrics)
                {
                    void* paths_vptr = (void*)paths;
                    GetPathMetricsNV(metricQueryMask, numPaths, pathNameType, paths_vptr, pathBase, stride, metrics_ptr);
                }
            }
            /// <inheritdoc cref="GetPathMetricsNV"/>
            public static unsafe void GetPathMetricsNV<T1>(PathMetricMask metricQueryMask, int numPaths, PathElementType pathNameType, ReadOnlySpan<T1> paths, uint pathBase, int stride, Span<float> metrics)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = paths)
                {
                    fixed (float* metrics_ptr = metrics)
                    {
                        GetPathMetricsNV(metricQueryMask, numPaths, pathNameType, paths_ptr, pathBase, stride, metrics_ptr);
                    }
                }
            }
            /// <inheritdoc cref="GetPathMetricsNV"/>
            public static unsafe void GetPathMetricsNV<T1>(PathMetricMask metricQueryMask, int numPaths, PathElementType pathNameType, T1[] paths, uint pathBase, int stride, float[] metrics)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = paths)
                {
                    fixed (float* metrics_ptr = metrics)
                    {
                        GetPathMetricsNV(metricQueryMask, numPaths, pathNameType, paths_ptr, pathBase, stride, metrics_ptr);
                    }
                }
            }
            /// <inheritdoc cref="GetPathMetricsNV"/>
            public static unsafe void GetPathMetricsNV<T1>(PathMetricMask metricQueryMask, int numPaths, PathElementType pathNameType, in T1 paths, uint pathBase, int stride, ref float metrics)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = &paths)
                fixed (float* metrics_ptr = &metrics)
                {
                    GetPathMetricsNV(metricQueryMask, numPaths, pathNameType, paths_ptr, pathBase, stride, metrics_ptr);
                }
            }
            /// <inheritdoc cref="GetPathMetricRangeNV"/>
            public static unsafe void GetPathMetricRangeNV(PathMetricMask metricQueryMask, uint firstPathName, int numPaths, int stride, Span<float> metrics)
            {
                fixed (float* metrics_ptr = metrics)
                {
                    GetPathMetricRangeNV(metricQueryMask, firstPathName, numPaths, stride, metrics_ptr);
                }
            }
            /// <inheritdoc cref="GetPathMetricRangeNV"/>
            public static unsafe void GetPathMetricRangeNV(PathMetricMask metricQueryMask, uint firstPathName, int numPaths, int stride, float[] metrics)
            {
                fixed (float* metrics_ptr = metrics)
                {
                    GetPathMetricRangeNV(metricQueryMask, firstPathName, numPaths, stride, metrics_ptr);
                }
            }
            /// <inheritdoc cref="GetPathMetricRangeNV"/>
            public static unsafe void GetPathMetricRangeNV(PathMetricMask metricQueryMask, uint firstPathName, int numPaths, int stride, ref float metrics)
            {
                fixed (float* metrics_ptr = &metrics)
                {
                    GetPathMetricRangeNV(metricQueryMask, firstPathName, numPaths, stride, metrics_ptr);
                }
            }
            /// <inheritdoc cref="GetPathSpacingNV"/>
            public static unsafe void GetPathSpacingNV(PathListMode pathListMode, int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, float advanceScale, float kerningScale, PathTransformType transformType, Span<float> returnedSpacing)
            {
                fixed (float* returnedSpacing_ptr = returnedSpacing)
                {
                    void* paths_vptr = (void*)paths;
                    GetPathSpacingNV(pathListMode, numPaths, pathNameType, paths_vptr, pathBase, advanceScale, kerningScale, transformType, returnedSpacing_ptr);
                }
            }
            /// <inheritdoc cref="GetPathSpacingNV"/>
            public static unsafe void GetPathSpacingNV(PathListMode pathListMode, int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, float advanceScale, float kerningScale, PathTransformType transformType, float[] returnedSpacing)
            {
                fixed (float* returnedSpacing_ptr = returnedSpacing)
                {
                    void* paths_vptr = (void*)paths;
                    GetPathSpacingNV(pathListMode, numPaths, pathNameType, paths_vptr, pathBase, advanceScale, kerningScale, transformType, returnedSpacing_ptr);
                }
            }
            /// <inheritdoc cref="GetPathSpacingNV"/>
            public static unsafe void GetPathSpacingNV(PathListMode pathListMode, int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, float advanceScale, float kerningScale, PathTransformType transformType, ref float returnedSpacing)
            {
                fixed (float* returnedSpacing_ptr = &returnedSpacing)
                {
                    void* paths_vptr = (void*)paths;
                    GetPathSpacingNV(pathListMode, numPaths, pathNameType, paths_vptr, pathBase, advanceScale, kerningScale, transformType, returnedSpacing_ptr);
                }
            }
            /// <inheritdoc cref="GetPathSpacingNV"/>
            public static unsafe void GetPathSpacingNV<T1>(PathListMode pathListMode, int numPaths, PathElementType pathNameType, ReadOnlySpan<T1> paths, uint pathBase, float advanceScale, float kerningScale, PathTransformType transformType, Span<float> returnedSpacing)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = paths)
                {
                    fixed (float* returnedSpacing_ptr = returnedSpacing)
                    {
                        GetPathSpacingNV(pathListMode, numPaths, pathNameType, paths_ptr, pathBase, advanceScale, kerningScale, transformType, returnedSpacing_ptr);
                    }
                }
            }
            /// <inheritdoc cref="GetPathSpacingNV"/>
            public static unsafe void GetPathSpacingNV<T1>(PathListMode pathListMode, int numPaths, PathElementType pathNameType, T1[] paths, uint pathBase, float advanceScale, float kerningScale, PathTransformType transformType, float[] returnedSpacing)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = paths)
                {
                    fixed (float* returnedSpacing_ptr = returnedSpacing)
                    {
                        GetPathSpacingNV(pathListMode, numPaths, pathNameType, paths_ptr, pathBase, advanceScale, kerningScale, transformType, returnedSpacing_ptr);
                    }
                }
            }
            /// <inheritdoc cref="GetPathSpacingNV"/>
            public static unsafe void GetPathSpacingNV<T1>(PathListMode pathListMode, int numPaths, PathElementType pathNameType, in T1 paths, uint pathBase, float advanceScale, float kerningScale, PathTransformType transformType, ref float returnedSpacing)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = &paths)
                fixed (float* returnedSpacing_ptr = &returnedSpacing)
                {
                    GetPathSpacingNV(pathListMode, numPaths, pathNameType, paths_ptr, pathBase, advanceScale, kerningScale, transformType, returnedSpacing_ptr);
                }
            }
            /// <inheritdoc cref="PointAlongPathNV"/>
            public static unsafe bool PointAlongPathNV(uint path, int startSegment, int numSegments, float distance, Span<float> x, Span<float> y, Span<float> tangentX, Span<float> tangentY)
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
                                returnValue = PointAlongPathNV(path, startSegment, numSegments, distance, x_ptr, y_ptr, tangentX_ptr, tangentY_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="PointAlongPathNV"/>
            public static unsafe bool PointAlongPathNV(uint path, int startSegment, int numSegments, float distance, float[] x, float[] y, float[] tangentX, float[] tangentY)
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
                                returnValue = PointAlongPathNV(path, startSegment, numSegments, distance, x_ptr, y_ptr, tangentX_ptr, tangentY_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="PointAlongPathNV"/>
            public static unsafe bool PointAlongPathNV(uint path, int startSegment, int numSegments, float distance, ref float x, ref float y, ref float tangentX, ref float tangentY)
            {
                bool returnValue;
                fixed (float* x_ptr = &x)
                fixed (float* y_ptr = &y)
                fixed (float* tangentX_ptr = &tangentX)
                fixed (float* tangentY_ptr = &tangentY)
                {
                    returnValue = PointAlongPathNV(path, startSegment, numSegments, distance, x_ptr, y_ptr, tangentX_ptr, tangentY_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="MatrixLoad3x2fNV"/>
            public static unsafe void MatrixLoad3x2fNV(All matrixMode, in float m)
            {
                fixed (float* m_ptr = &m)
                {
                    MatrixLoad3x2fNV(matrixMode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixLoad3x3fNV"/>
            public static unsafe void MatrixLoad3x3fNV(All matrixMode, in float m)
            {
                fixed (float* m_ptr = &m)
                {
                    MatrixLoad3x3fNV(matrixMode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixLoadTranspose3x3fNV"/>
            public static unsafe void MatrixLoadTranspose3x3fNV(All matrixMode, in float m)
            {
                fixed (float* m_ptr = &m)
                {
                    MatrixLoadTranspose3x3fNV(matrixMode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixMult3x2fNV"/>
            public static unsafe void MatrixMult3x2fNV(All matrixMode, in float m)
            {
                fixed (float* m_ptr = &m)
                {
                    MatrixMult3x2fNV(matrixMode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixMult3x3fNV"/>
            public static unsafe void MatrixMult3x3fNV(All matrixMode, in float m)
            {
                fixed (float* m_ptr = &m)
                {
                    MatrixMult3x3fNV(matrixMode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixMultTranspose3x3fNV"/>
            public static unsafe void MatrixMultTranspose3x3fNV(All matrixMode, in float m)
            {
                fixed (float* m_ptr = &m)
                {
                    MatrixMultTranspose3x3fNV(matrixMode, m_ptr);
                }
            }
            /// <inheritdoc cref="StencilThenCoverFillPathInstancedNV"/>
            public static unsafe void StencilThenCoverFillPathInstancedNV(int numPaths, All pathNameType, IntPtr paths, uint pathBase, All fillMode, uint mask, All coverMode, All transformType, in float transformValues)
            {
                fixed (float* transformValues_ptr = &transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    StencilThenCoverFillPathInstancedNV(numPaths, pathNameType, paths_vptr, pathBase, fillMode, mask, coverMode, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="StencilThenCoverFillPathInstancedNV"/>
            public static unsafe void StencilThenCoverFillPathInstancedNV<T1>(int numPaths, All pathNameType, in T1 paths, uint pathBase, All fillMode, uint mask, All coverMode, All transformType, in float transformValues)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = &paths)
                fixed (float* transformValues_ptr = &transformValues)
                {
                    StencilThenCoverFillPathInstancedNV(numPaths, pathNameType, paths_ptr, pathBase, fillMode, mask, coverMode, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="StencilThenCoverStrokePathInstancedNV"/>
            public static unsafe void StencilThenCoverStrokePathInstancedNV(int numPaths, All pathNameType, IntPtr paths, uint pathBase, int reference, uint mask, All coverMode, All transformType, in float transformValues)
            {
                fixed (float* transformValues_ptr = &transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    StencilThenCoverStrokePathInstancedNV(numPaths, pathNameType, paths_vptr, pathBase, reference, mask, coverMode, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="StencilThenCoverStrokePathInstancedNV"/>
            public static unsafe void StencilThenCoverStrokePathInstancedNV<T1>(int numPaths, All pathNameType, in T1 paths, uint pathBase, int reference, uint mask, All coverMode, All transformType, in float transformValues)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = &paths)
                fixed (float* transformValues_ptr = &transformValues)
                {
                    StencilThenCoverStrokePathInstancedNV(numPaths, pathNameType, paths_ptr, pathBase, reference, mask, coverMode, transformType, transformValues_ptr);
                }
            }
            /// <inheritdoc cref="PathGlyphIndexRangeNV"/>
            public static unsafe All PathGlyphIndexRangeNV(All fontTarget, IntPtr fontName, PathFontStyle fontStyle, uint pathParameterTemplate, float emScale, Span<uint> baseAndCount)
            {
                All returnValue;
                fixed (uint* baseAndCount_ptr = baseAndCount)
                {
                    void* fontName_vptr = (void*)fontName;
                    returnValue = PathGlyphIndexRangeNV(fontTarget, fontName_vptr, fontStyle, pathParameterTemplate, emScale, baseAndCount_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="PathGlyphIndexRangeNV"/>
            public static unsafe All PathGlyphIndexRangeNV(All fontTarget, IntPtr fontName, PathFontStyle fontStyle, uint pathParameterTemplate, float emScale, uint[] baseAndCount)
            {
                All returnValue;
                fixed (uint* baseAndCount_ptr = baseAndCount)
                {
                    void* fontName_vptr = (void*)fontName;
                    returnValue = PathGlyphIndexRangeNV(fontTarget, fontName_vptr, fontStyle, pathParameterTemplate, emScale, baseAndCount_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="PathGlyphIndexRangeNV"/>
            public static unsafe All PathGlyphIndexRangeNV(All fontTarget, IntPtr fontName, PathFontStyle fontStyle, uint pathParameterTemplate, float emScale, ref uint baseAndCount)
            {
                All returnValue;
                fixed (uint* baseAndCount_ptr = &baseAndCount)
                {
                    void* fontName_vptr = (void*)fontName;
                    returnValue = PathGlyphIndexRangeNV(fontTarget, fontName_vptr, fontStyle, pathParameterTemplate, emScale, baseAndCount_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="PathGlyphIndexRangeNV"/>
            public static unsafe All PathGlyphIndexRangeNV<T1>(All fontTarget, in T1 fontName, PathFontStyle fontStyle, uint pathParameterTemplate, float emScale, Span<uint> baseAndCount)
                where T1 : unmanaged
            {
                All returnValue;
                fixed (void* fontName_ptr = &fontName)
                {
                    fixed (uint* baseAndCount_ptr = baseAndCount)
                    {
                        returnValue = PathGlyphIndexRangeNV(fontTarget, fontName_ptr, fontStyle, pathParameterTemplate, emScale, baseAndCount_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="PathGlyphIndexRangeNV"/>
            public static unsafe All PathGlyphIndexRangeNV<T1>(All fontTarget, in T1 fontName, PathFontStyle fontStyle, uint pathParameterTemplate, float emScale, uint[] baseAndCount)
                where T1 : unmanaged
            {
                All returnValue;
                fixed (void* fontName_ptr = &fontName)
                {
                    fixed (uint* baseAndCount_ptr = baseAndCount)
                    {
                        returnValue = PathGlyphIndexRangeNV(fontTarget, fontName_ptr, fontStyle, pathParameterTemplate, emScale, baseAndCount_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="PathGlyphIndexRangeNV"/>
            public static unsafe All PathGlyphIndexRangeNV<T1>(All fontTarget, in T1 fontName, PathFontStyle fontStyle, uint pathParameterTemplate, float emScale, ref uint baseAndCount)
                where T1 : unmanaged
            {
                All returnValue;
                fixed (void* fontName_ptr = &fontName)
                fixed (uint* baseAndCount_ptr = &baseAndCount)
                {
                    returnValue = PathGlyphIndexRangeNV(fontTarget, fontName_ptr, fontStyle, pathParameterTemplate, emScale, baseAndCount_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="PathGlyphIndexArrayNV"/>
            public static unsafe All PathGlyphIndexArrayNV(uint firstPathName, All fontTarget, IntPtr fontName, PathFontStyle fontStyle, uint firstGlyphIndex, int numGlyphs, uint pathParameterTemplate, float emScale)
            {
                All returnValue;
                void* fontName_vptr = (void*)fontName;
                returnValue = PathGlyphIndexArrayNV(firstPathName, fontTarget, fontName_vptr, fontStyle, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);
                return returnValue;
            }
            /// <inheritdoc cref="PathGlyphIndexArrayNV"/>
            public static unsafe All PathGlyphIndexArrayNV<T1>(uint firstPathName, All fontTarget, in T1 fontName, PathFontStyle fontStyle, uint firstGlyphIndex, int numGlyphs, uint pathParameterTemplate, float emScale)
                where T1 : unmanaged
            {
                All returnValue;
                fixed (void* fontName_ptr = &fontName)
                {
                    returnValue = PathGlyphIndexArrayNV(firstPathName, fontTarget, fontName_ptr, fontStyle, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);
                }
                return returnValue;
            }
            /// <inheritdoc cref="PathMemoryGlyphIndexArrayNV"/>
            public static unsafe All PathMemoryGlyphIndexArrayNV(uint firstPathName, All fontTarget, nint fontSize, IntPtr fontData, int faceIndex, uint firstGlyphIndex, int numGlyphs, uint pathParameterTemplate, float emScale)
            {
                All returnValue;
                void* fontData_vptr = (void*)fontData;
                returnValue = PathMemoryGlyphIndexArrayNV(firstPathName, fontTarget, fontSize, fontData_vptr, faceIndex, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);
                return returnValue;
            }
            /// <inheritdoc cref="PathMemoryGlyphIndexArrayNV"/>
            public static unsafe All PathMemoryGlyphIndexArrayNV<T1>(uint firstPathName, All fontTarget, nint fontSize, in T1 fontData, int faceIndex, uint firstGlyphIndex, int numGlyphs, uint pathParameterTemplate, float emScale)
                where T1 : unmanaged
            {
                All returnValue;
                fixed (void* fontData_ptr = &fontData)
                {
                    returnValue = PathMemoryGlyphIndexArrayNV(firstPathName, fontTarget, fontSize, fontData_ptr, faceIndex, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ProgramPathFragmentInputGenNV"/>
            public static unsafe void ProgramPathFragmentInputGenNV(ProgramHandle program, int location, All genMode, int components, in float coeffs)
            {
                fixed (float* coeffs_ptr = &coeffs)
                {
                    ProgramPathFragmentInputGenNV(program, location, genMode, components, coeffs_ptr);
                }
            }
            /// <inheritdoc cref="GetProgramResourcefvNV"/>
            public static unsafe void GetProgramResourcefvNV(ProgramHandle program, ProgramInterface programInterface, uint index, int propCount, in All props, Span<int> length, Span<float> parameters)
            {
                fixed (All* props_ptr = &props)
                {
                    fixed (int* length_ptr = length)
                    {
                        int count = (int)(parameters.Length);
                        fixed (float* parameters_ptr = parameters)
                        {
                            GetProgramResourcefvNV(program, programInterface, index, propCount, props_ptr, count, length_ptr, parameters_ptr);
                        }
                    }
                }
            }
            /// <inheritdoc cref="GetProgramResourcefvNV"/>
            public static unsafe void GetProgramResourcefvNV(ProgramHandle program, ProgramInterface programInterface, uint index, int propCount, in All props, int[] length, float[] parameters)
            {
                fixed (All* props_ptr = &props)
                {
                    fixed (int* length_ptr = length)
                    {
                        int count = (int)(parameters.Length);
                        fixed (float* parameters_ptr = parameters)
                        {
                            GetProgramResourcefvNV(program, programInterface, index, propCount, props_ptr, count, length_ptr, parameters_ptr);
                        }
                    }
                }
            }
            /// <inheritdoc cref="GetProgramResourcefvNV"/>
            public static unsafe void GetProgramResourcefvNV(ProgramHandle program, ProgramInterface programInterface, uint index, int propCount, in All props, int count, ref int length, ref float parameters)
            {
                fixed (All* props_ptr = &props)
                fixed (int* length_ptr = &length)
                fixed (float* parameters_ptr = &parameters)
                {
                    GetProgramResourcefvNV(program, programInterface, index, propCount, props_ptr, count, length_ptr, parameters_ptr);
                }
            }
            /// <inheritdoc cref="MatrixLoadTransposefEXT"/>
            public static unsafe void MatrixLoadTransposefEXT(MatrixMode mode, ReadOnlySpan<float> m)
            {
                fixed (float* m_ptr = m)
                {
                    MatrixLoadTransposefEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixLoadTransposefEXT"/>
            public static unsafe void MatrixLoadTransposefEXT(MatrixMode mode, float[] m)
            {
                fixed (float* m_ptr = m)
                {
                    MatrixLoadTransposefEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixLoadTransposefEXT"/>
            public static unsafe void MatrixLoadTransposefEXT(MatrixMode mode, in float m)
            {
                fixed (float* m_ptr = &m)
                {
                    MatrixLoadTransposefEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixLoadTransposedEXT"/>
            public static unsafe void MatrixLoadTransposedEXT(MatrixMode mode, ReadOnlySpan<double> m)
            {
                fixed (double* m_ptr = m)
                {
                    MatrixLoadTransposedEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixLoadTransposedEXT"/>
            public static unsafe void MatrixLoadTransposedEXT(MatrixMode mode, double[] m)
            {
                fixed (double* m_ptr = m)
                {
                    MatrixLoadTransposedEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixLoadTransposedEXT"/>
            public static unsafe void MatrixLoadTransposedEXT(MatrixMode mode, in double m)
            {
                fixed (double* m_ptr = &m)
                {
                    MatrixLoadTransposedEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixLoadfEXT"/>
            public static unsafe void MatrixLoadfEXT(MatrixMode mode, ReadOnlySpan<float> m)
            {
                fixed (float* m_ptr = m)
                {
                    MatrixLoadfEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixLoadfEXT"/>
            public static unsafe void MatrixLoadfEXT(MatrixMode mode, float[] m)
            {
                fixed (float* m_ptr = m)
                {
                    MatrixLoadfEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixLoadfEXT"/>
            public static unsafe void MatrixLoadfEXT(MatrixMode mode, in float m)
            {
                fixed (float* m_ptr = &m)
                {
                    MatrixLoadfEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixLoaddEXT"/>
            public static unsafe void MatrixLoaddEXT(MatrixMode mode, ReadOnlySpan<double> m)
            {
                fixed (double* m_ptr = m)
                {
                    MatrixLoaddEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixLoaddEXT"/>
            public static unsafe void MatrixLoaddEXT(MatrixMode mode, double[] m)
            {
                fixed (double* m_ptr = m)
                {
                    MatrixLoaddEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixLoaddEXT"/>
            public static unsafe void MatrixLoaddEXT(MatrixMode mode, in double m)
            {
                fixed (double* m_ptr = &m)
                {
                    MatrixLoaddEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixMultTransposefEXT"/>
            public static unsafe void MatrixMultTransposefEXT(MatrixMode mode, ReadOnlySpan<float> m)
            {
                fixed (float* m_ptr = m)
                {
                    MatrixMultTransposefEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixMultTransposefEXT"/>
            public static unsafe void MatrixMultTransposefEXT(MatrixMode mode, float[] m)
            {
                fixed (float* m_ptr = m)
                {
                    MatrixMultTransposefEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixMultTransposefEXT"/>
            public static unsafe void MatrixMultTransposefEXT(MatrixMode mode, in float m)
            {
                fixed (float* m_ptr = &m)
                {
                    MatrixMultTransposefEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixMultTransposedEXT"/>
            public static unsafe void MatrixMultTransposedEXT(MatrixMode mode, ReadOnlySpan<double> m)
            {
                fixed (double* m_ptr = m)
                {
                    MatrixMultTransposedEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixMultTransposedEXT"/>
            public static unsafe void MatrixMultTransposedEXT(MatrixMode mode, double[] m)
            {
                fixed (double* m_ptr = m)
                {
                    MatrixMultTransposedEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixMultTransposedEXT"/>
            public static unsafe void MatrixMultTransposedEXT(MatrixMode mode, in double m)
            {
                fixed (double* m_ptr = &m)
                {
                    MatrixMultTransposedEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixMultfEXT"/>
            public static unsafe void MatrixMultfEXT(MatrixMode mode, ReadOnlySpan<float> m)
            {
                fixed (float* m_ptr = m)
                {
                    MatrixMultfEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixMultfEXT"/>
            public static unsafe void MatrixMultfEXT(MatrixMode mode, float[] m)
            {
                fixed (float* m_ptr = m)
                {
                    MatrixMultfEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixMultfEXT"/>
            public static unsafe void MatrixMultfEXT(MatrixMode mode, in float m)
            {
                fixed (float* m_ptr = &m)
                {
                    MatrixMultfEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixMultdEXT"/>
            public static unsafe void MatrixMultdEXT(MatrixMode mode, ReadOnlySpan<double> m)
            {
                fixed (double* m_ptr = m)
                {
                    MatrixMultdEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixMultdEXT"/>
            public static unsafe void MatrixMultdEXT(MatrixMode mode, double[] m)
            {
                fixed (double* m_ptr = m)
                {
                    MatrixMultdEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="MatrixMultdEXT"/>
            public static unsafe void MatrixMultdEXT(MatrixMode mode, in double m)
            {
                fixed (double* m_ptr = &m)
                {
                    MatrixMultdEXT(mode, m_ptr);
                }
            }
            /// <inheritdoc cref="FramebufferSampleLocationsfvNV"/>
            public static unsafe void FramebufferSampleLocationsfvNV(FramebufferTarget target, uint start, int count, in float v)
            {
                fixed (float* v_ptr = &v)
                {
                    FramebufferSampleLocationsfvNV(target, start, count, v_ptr);
                }
            }
            /// <inheritdoc cref="NamedFramebufferSampleLocationsfvNV"/>
            public static unsafe void NamedFramebufferSampleLocationsfvNV(FramebufferHandle framebuffer, uint start, int count, in float v)
            {
                fixed (float* v_ptr = &v)
                {
                    NamedFramebufferSampleLocationsfvNV(framebuffer, start, count, v_ptr);
                }
            }
            /// <inheritdoc cref="ScissorExclusiveArrayvNV"/>
            public static unsafe void ScissorExclusiveArrayvNV(uint first, int count, ReadOnlySpan<int> v)
            {
                fixed (int* v_ptr = v)
                {
                    ScissorExclusiveArrayvNV(first, count, v_ptr);
                }
            }
            /// <inheritdoc cref="ScissorExclusiveArrayvNV"/>
            public static unsafe void ScissorExclusiveArrayvNV(uint first, int count, int[] v)
            {
                fixed (int* v_ptr = v)
                {
                    ScissorExclusiveArrayvNV(first, count, v_ptr);
                }
            }
            /// <inheritdoc cref="ScissorExclusiveArrayvNV"/>
            public static unsafe void ScissorExclusiveArrayvNV(uint first, int count, in int v)
            {
                fixed (int* v_ptr = &v)
                {
                    ScissorExclusiveArrayvNV(first, count, v_ptr);
                }
            }
            /// <inheritdoc cref="GetShadingRateImagePaletteNV"/>
            public static unsafe void GetShadingRateImagePaletteNV(uint viewport, uint entry, Span<All> rate)
            {
                fixed (All* rate_ptr = rate)
                {
                    GetShadingRateImagePaletteNV(viewport, entry, rate_ptr);
                }
            }
            /// <inheritdoc cref="GetShadingRateImagePaletteNV"/>
            public static unsafe void GetShadingRateImagePaletteNV(uint viewport, uint entry, All[] rate)
            {
                fixed (All* rate_ptr = rate)
                {
                    GetShadingRateImagePaletteNV(viewport, entry, rate_ptr);
                }
            }
            /// <inheritdoc cref="GetShadingRateImagePaletteNV"/>
            public static unsafe void GetShadingRateImagePaletteNV(uint viewport, uint entry, ref All rate)
            {
                fixed (All* rate_ptr = &rate)
                {
                    GetShadingRateImagePaletteNV(viewport, entry, rate_ptr);
                }
            }
            /// <inheritdoc cref="GetShadingRateSampleLocationivNV"/>
            public static unsafe void GetShadingRateSampleLocationivNV(All rate, uint samples, uint index, Span<int> location)
            {
                fixed (int* location_ptr = location)
                {
                    GetShadingRateSampleLocationivNV(rate, samples, index, location_ptr);
                }
            }
            /// <inheritdoc cref="GetShadingRateSampleLocationivNV"/>
            public static unsafe void GetShadingRateSampleLocationivNV(All rate, uint samples, uint index, int[] location)
            {
                fixed (int* location_ptr = location)
                {
                    GetShadingRateSampleLocationivNV(rate, samples, index, location_ptr);
                }
            }
            /// <inheritdoc cref="GetShadingRateSampleLocationivNV"/>
            public static unsafe void GetShadingRateSampleLocationivNV(All rate, uint samples, uint index, ref int location)
            {
                fixed (int* location_ptr = &location)
                {
                    GetShadingRateSampleLocationivNV(rate, samples, index, location_ptr);
                }
            }
            /// <inheritdoc cref="ShadingRateImagePaletteNV"/>
            public static unsafe void ShadingRateImagePaletteNV(uint viewport, uint first, ReadOnlySpan<All> rates)
            {
                int count = (int)(rates.Length);
                fixed (All* rates_ptr = rates)
                {
                    ShadingRateImagePaletteNV(viewport, first, count, rates_ptr);
                }
            }
            /// <inheritdoc cref="ShadingRateImagePaletteNV"/>
            public static unsafe void ShadingRateImagePaletteNV(uint viewport, uint first, All[] rates)
            {
                int count = (int)(rates.Length);
                fixed (All* rates_ptr = rates)
                {
                    ShadingRateImagePaletteNV(viewport, first, count, rates_ptr);
                }
            }
            /// <inheritdoc cref="ShadingRateImagePaletteNV"/>
            public static unsafe void ShadingRateImagePaletteNV(uint viewport, uint first, int count, in All rates)
            {
                fixed (All* rates_ptr = &rates)
                {
                    ShadingRateImagePaletteNV(viewport, first, count, rates_ptr);
                }
            }
            /// <inheritdoc cref="ShadingRateSampleOrderCustomNV"/>
            public static unsafe void ShadingRateSampleOrderCustomNV(All rate, uint samples, ReadOnlySpan<int> locations)
            {
                fixed (int* locations_ptr = locations)
                {
                    ShadingRateSampleOrderCustomNV(rate, samples, locations_ptr);
                }
            }
            /// <inheritdoc cref="ShadingRateSampleOrderCustomNV"/>
            public static unsafe void ShadingRateSampleOrderCustomNV(All rate, uint samples, int[] locations)
            {
                fixed (int* locations_ptr = locations)
                {
                    ShadingRateSampleOrderCustomNV(rate, samples, locations_ptr);
                }
            }
            /// <inheritdoc cref="ShadingRateSampleOrderCustomNV"/>
            public static unsafe void ShadingRateSampleOrderCustomNV(All rate, uint samples, in int locations)
            {
                fixed (int* locations_ptr = &locations)
                {
                    ShadingRateSampleOrderCustomNV(rate, samples, locations_ptr);
                }
            }
            /// <inheritdoc cref="ViewportArrayvNV"/>
            public static unsafe void ViewportArrayvNV(uint first, int count, ReadOnlySpan<float> v)
            {
                fixed (float* v_ptr = v)
                {
                    ViewportArrayvNV(first, count, v_ptr);
                }
            }
            /// <inheritdoc cref="ViewportArrayvNV"/>
            public static unsafe void ViewportArrayvNV(uint first, int count, float[] v)
            {
                fixed (float* v_ptr = v)
                {
                    ViewportArrayvNV(first, count, v_ptr);
                }
            }
            /// <inheritdoc cref="ViewportArrayvNV"/>
            public static unsafe void ViewportArrayvNV(uint first, int count, in float v)
            {
                fixed (float* v_ptr = &v)
                {
                    ViewportArrayvNV(first, count, v_ptr);
                }
            }
            /// <inheritdoc cref="ViewportIndexedfvNV"/>
            public static unsafe void ViewportIndexedfvNV(uint index, ReadOnlySpan<float> v)
            {
                fixed (float* v_ptr = v)
                {
                    ViewportIndexedfvNV(index, v_ptr);
                }
            }
            /// <inheritdoc cref="ViewportIndexedfvNV"/>
            public static unsafe void ViewportIndexedfvNV(uint index, float[] v)
            {
                fixed (float* v_ptr = v)
                {
                    ViewportIndexedfvNV(index, v_ptr);
                }
            }
            /// <inheritdoc cref="ViewportIndexedfvNV"/>
            public static unsafe void ViewportIndexedfvNV(uint index, in float v)
            {
                fixed (float* v_ptr = &v)
                {
                    ViewportIndexedfvNV(index, v_ptr);
                }
            }
            /// <inheritdoc cref="ScissorArrayvNV"/>
            public static unsafe void ScissorArrayvNV(uint first, int count, ReadOnlySpan<int> v)
            {
                fixed (int* v_ptr = v)
                {
                    ScissorArrayvNV(first, count, v_ptr);
                }
            }
            /// <inheritdoc cref="ScissorArrayvNV"/>
            public static unsafe void ScissorArrayvNV(uint first, int count, int[] v)
            {
                fixed (int* v_ptr = v)
                {
                    ScissorArrayvNV(first, count, v_ptr);
                }
            }
            /// <inheritdoc cref="ScissorArrayvNV"/>
            public static unsafe void ScissorArrayvNV(uint first, int count, in int v)
            {
                fixed (int* v_ptr = &v)
                {
                    ScissorArrayvNV(first, count, v_ptr);
                }
            }
            /// <inheritdoc cref="ScissorIndexedvNV"/>
            public static unsafe void ScissorIndexedvNV(uint index, ReadOnlySpan<int> v)
            {
                fixed (int* v_ptr = v)
                {
                    ScissorIndexedvNV(index, v_ptr);
                }
            }
            /// <inheritdoc cref="ScissorIndexedvNV"/>
            public static unsafe void ScissorIndexedvNV(uint index, int[] v)
            {
                fixed (int* v_ptr = v)
                {
                    ScissorIndexedvNV(index, v_ptr);
                }
            }
            /// <inheritdoc cref="ScissorIndexedvNV"/>
            public static unsafe void ScissorIndexedvNV(uint index, in int v)
            {
                fixed (int* v_ptr = &v)
                {
                    ScissorIndexedvNV(index, v_ptr);
                }
            }
            /// <inheritdoc cref="DepthRangeArrayfvNV"/>
            public static unsafe void DepthRangeArrayfvNV(uint first, int count, in float v)
            {
                fixed (float* v_ptr = &v)
                {
                    DepthRangeArrayfvNV(first, count, v_ptr);
                }
            }
            /// <inheritdoc cref="GetFloati_vNV"/>
            public static unsafe void GetFloati_vNV(GetPName target, uint index, Span<float> data)
            {
                fixed (float* data_ptr = data)
                {
                    GetFloati_vNV(target, index, data_ptr);
                }
            }
            /// <inheritdoc cref="GetFloati_vNV"/>
            public static unsafe void GetFloati_vNV(GetPName target, uint index, float[] data)
            {
                fixed (float* data_ptr = data)
                {
                    GetFloati_vNV(target, index, data_ptr);
                }
            }
            /// <inheritdoc cref="GetFloati_vNV"/>
            public static unsafe void GetFloati_vNV(GetPName target, uint index, ref float data)
            {
                fixed (float* data_ptr = &data)
                {
                    GetFloati_vNV(target, index, data_ptr);
                }
            }
        }
        public static unsafe partial class IMG
        {
            /// <inheritdoc cref="UniformHandleui64vIMG"/>
            public static unsafe void UniformHandleui64vIMG(int location, ReadOnlySpan<ulong> value)
            {
                int count = (int)(value.Length);
                fixed (ulong* value_ptr = value)
                {
                    UniformHandleui64vIMG(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformHandleui64vIMG"/>
            public static unsafe void UniformHandleui64vIMG(int location, ulong[] value)
            {
                int count = (int)(value.Length);
                fixed (ulong* value_ptr = value)
                {
                    UniformHandleui64vIMG(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="UniformHandleui64vIMG"/>
            public static unsafe void UniformHandleui64vIMG(int location, int count, in ulong value)
            {
                fixed (ulong* value_ptr = &value)
                {
                    UniformHandleui64vIMG(location, count, value_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformHandleui64vIMG"/>
            public static unsafe void ProgramUniformHandleui64vIMG(ProgramHandle program, int location, ReadOnlySpan<ulong> values)
            {
                int count = (int)(values.Length);
                fixed (ulong* values_ptr = values)
                {
                    ProgramUniformHandleui64vIMG(program, location, count, values_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformHandleui64vIMG"/>
            public static unsafe void ProgramUniformHandleui64vIMG(ProgramHandle program, int location, ulong[] values)
            {
                int count = (int)(values.Length);
                fixed (ulong* values_ptr = values)
                {
                    ProgramUniformHandleui64vIMG(program, location, count, values_ptr);
                }
            }
            /// <inheritdoc cref="ProgramUniformHandleui64vIMG"/>
            public static unsafe void ProgramUniformHandleui64vIMG(ProgramHandle program, int location, int count, in ulong values)
            {
                fixed (ulong* values_ptr = &values)
                {
                    ProgramUniformHandleui64vIMG(program, location, count, values_ptr);
                }
            }
        }
        public static unsafe partial class INTEL
        {
            /// <inheritdoc cref="CreatePerfQueryINTEL"/>
            public static unsafe void CreatePerfQueryINTEL(uint queryId, ref uint queryHandle)
            {
                fixed (uint* queryHandle_ptr = &queryHandle)
                {
                    CreatePerfQueryINTEL(queryId, queryHandle_ptr);
                }
            }
            /// <inheritdoc cref="GetFirstPerfQueryIdINTEL"/>
            public static unsafe void GetFirstPerfQueryIdINTEL(ref uint queryId)
            {
                fixed (uint* queryId_ptr = &queryId)
                {
                    GetFirstPerfQueryIdINTEL(queryId_ptr);
                }
            }
            /// <inheritdoc cref="GetNextPerfQueryIdINTEL"/>
            public static unsafe void GetNextPerfQueryIdINTEL(uint queryId, ref uint nextQueryId)
            {
                fixed (uint* nextQueryId_ptr = &nextQueryId)
                {
                    GetNextPerfQueryIdINTEL(queryId, nextQueryId_ptr);
                }
            }
            /// <inheritdoc cref="GetPerfCounterInfoINTEL"/>
            public static unsafe void GetPerfCounterInfoINTEL(uint queryId, uint counterId, uint counterNameLength, out string counterName, uint counterDescLength, out string counterDesc, ref uint counterOffset, ref uint counterDataSize, ref uint counterTypeEnum, ref uint counterDataTypeEnum, ref ulong rawCounterMaxValue)
            {
                fixed (uint* counterOffset_ptr = &counterOffset)
                fixed (uint* counterDataSize_ptr = &counterDataSize)
                fixed (uint* counterTypeEnum_ptr = &counterTypeEnum)
                fixed (uint* counterDataTypeEnum_ptr = &counterDataTypeEnum)
                fixed (ulong* rawCounterMaxValue_ptr = &rawCounterMaxValue)
                {
                    var counterName_ptr = (byte*)Marshal.AllocCoTaskMem((int)counterNameLength);
                    var counterDesc_ptr = (byte*)Marshal.AllocCoTaskMem((int)counterDescLength);
                    GetPerfCounterInfoINTEL(queryId, counterId, counterNameLength, counterName_ptr, counterDescLength, counterDesc_ptr, counterOffset_ptr, counterDataSize_ptr, counterTypeEnum_ptr, counterDataTypeEnum_ptr, rawCounterMaxValue_ptr);
                    counterDesc = Marshal.PtrToStringUTF8((IntPtr)counterDesc_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)counterDesc_ptr);
                    counterName = Marshal.PtrToStringUTF8((IntPtr)counterName_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)counterName_ptr);
                }
            }
            /// <inheritdoc cref="GetPerfQueryDataINTEL"/>
            public static unsafe void GetPerfQueryDataINTEL(uint queryHandle, uint flags, int dataSize, IntPtr data, ref uint bytesWritten)
            {
                fixed (uint* bytesWritten_ptr = &bytesWritten)
                {
                    void* data_vptr = (void*)data;
                    GetPerfQueryDataINTEL(queryHandle, flags, dataSize, data_vptr, bytesWritten_ptr);
                }
            }
            /// <inheritdoc cref="GetPerfQueryDataINTEL"/>
            public static unsafe void GetPerfQueryDataINTEL<T1>(uint queryHandle, uint flags, int dataSize, ref T1 data, ref uint bytesWritten)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                fixed (uint* bytesWritten_ptr = &bytesWritten)
                {
                    GetPerfQueryDataINTEL(queryHandle, flags, dataSize, data_ptr, bytesWritten_ptr);
                }
            }
            /// <inheritdoc cref="GetPerfQueryIdByNameINTEL"/>
            public static unsafe void GetPerfQueryIdByNameINTEL(byte* queryName, ref uint queryId)
            {
                fixed (uint* queryId_ptr = &queryId)
                {
                    GetPerfQueryIdByNameINTEL(queryName, queryId_ptr);
                }
            }
            /// <inheritdoc cref="GetPerfQueryInfoINTEL"/>
            public static unsafe string GetPerfQueryInfoINTEL(uint queryId, uint queryNameLength, ref uint dataSize, ref uint noCounters, ref uint noInstances, ref uint capsMask)
            {
                string queryName;
                fixed (uint* dataSize_ptr = &dataSize)
                fixed (uint* noCounters_ptr = &noCounters)
                fixed (uint* noInstances_ptr = &noInstances)
                fixed (uint* capsMask_ptr = &capsMask)
                {
                    var queryName_ptr = (byte*)Marshal.AllocCoTaskMem((int)queryNameLength);
                    GetPerfQueryInfoINTEL(queryId, queryNameLength, queryName_ptr, dataSize_ptr, noCounters_ptr, noInstances_ptr, capsMask_ptr);
                    queryName = Marshal.PtrToStringUTF8((IntPtr)queryName_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)queryName_ptr);
                }
                return queryName;
            }
            /// <inheritdoc cref="GetPerfQueryInfoINTEL"/>
            public static unsafe void GetPerfQueryInfoINTEL(uint queryId, uint queryNameLength, out string queryName, ref uint dataSize, ref uint noCounters, ref uint noInstances, ref uint capsMask)
            {
                fixed (uint* dataSize_ptr = &dataSize)
                fixed (uint* noCounters_ptr = &noCounters)
                fixed (uint* noInstances_ptr = &noInstances)
                fixed (uint* capsMask_ptr = &capsMask)
                {
                    var queryName_ptr = (byte*)Marshal.AllocCoTaskMem((int)queryNameLength);
                    GetPerfQueryInfoINTEL(queryId, queryNameLength, queryName_ptr, dataSize_ptr, noCounters_ptr, noInstances_ptr, capsMask_ptr);
                    queryName = Marshal.PtrToStringUTF8((IntPtr)queryName_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)queryName_ptr);
                }
            }
        }
        public static unsafe partial class KHR
        {
            /// <inheritdoc cref="DebugMessageControl"/>
            public static unsafe void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, ReadOnlySpan<uint> ids, bool enabled)
            {
                int count = (int)(ids.Length);
                fixed (uint* ids_ptr = ids)
                {
                    DebugMessageControl(source, type, severity, count, ids_ptr, enabled);
                }
            }
            /// <inheritdoc cref="DebugMessageControl"/>
            public static unsafe void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, uint[] ids, bool enabled)
            {
                int count = (int)(ids.Length);
                fixed (uint* ids_ptr = ids)
                {
                    DebugMessageControl(source, type, severity, count, ids_ptr, enabled);
                }
            }
            /// <inheritdoc cref="DebugMessageControl"/>
            public static unsafe void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, int count, in uint ids, bool enabled)
            {
                fixed (uint* ids_ptr = &ids)
                {
                    DebugMessageControl(source, type, severity, count, ids_ptr, enabled);
                }
            }
            /// <inheritdoc cref="DebugMessageInsert"/>
            public static unsafe void DebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, string buf)
            {
                byte* buf_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(buf);
                DebugMessageInsert(source, type, id, severity, length, buf_ptr);
                Marshal.FreeCoTaskMem((IntPtr)buf_ptr);
            }
            /// <inheritdoc cref="DebugMessageCallback"/>
            public static unsafe void DebugMessageCallback(GLDebugProc callback, IntPtr userParam)
            {
                void* userParam_vptr = (void*)userParam;
                IntPtr callback_ptr = Marshal.GetFunctionPointerForDelegate(callback);
                DebugMessageCallback(callback_ptr, userParam_vptr);
            }
            /// <inheritdoc cref="DebugMessageCallback"/>
            public static unsafe void DebugMessageCallback<T1>(GLDebugProc callback, in T1 userParam)
                where T1 : unmanaged
            {
                fixed (void* userParam_ptr = &userParam)
                {
                    IntPtr callback_ptr = Marshal.GetFunctionPointerForDelegate(callback);
                    DebugMessageCallback(callback_ptr, userParam_ptr);
                }
            }
            /// <inheritdoc cref="GetDebugMessageLog"/>
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
            /// <inheritdoc cref="GetDebugMessageLog"/>
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
            /// <inheritdoc cref="GetDebugMessageLog"/>
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
            /// <inheritdoc cref="PushDebugGroup"/>
            public static unsafe void PushDebugGroup(DebugSource source, uint id, int length, string message)
            {
                byte* message_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(message);
                PushDebugGroup(source, id, length, message_ptr);
                Marshal.FreeCoTaskMem((IntPtr)message_ptr);
            }
            /// <inheritdoc cref="ObjectLabel"/>
            public static unsafe void ObjectLabel(ObjectIdentifier identifier, uint name, int length, string label)
            {
                byte* label_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(label);
                ObjectLabel(identifier, name, length, label_ptr);
                Marshal.FreeCoTaskMem((IntPtr)label_ptr);
            }
            /// <inheritdoc cref="GetObjectLabel"/>
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
            /// <inheritdoc cref="GetObjectLabel"/>
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
            /// <inheritdoc cref="GetObjectLabel"/>
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
            /// <inheritdoc cref="GetObjectLabel"/>
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
            /// <inheritdoc cref="GetObjectLabel"/>
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
            /// <inheritdoc cref="GetObjectLabel"/>
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
            /// <inheritdoc cref="ObjectPtrLabel"/>
            public static unsafe void ObjectPtrLabel(IntPtr ptr, int length, string label)
            {
                byte* label_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(label);
                void* ptr_vptr = (void*)ptr;
                ObjectPtrLabel(ptr_vptr, length, label_ptr);
                Marshal.FreeCoTaskMem((IntPtr)label_ptr);
            }
            /// <inheritdoc cref="ObjectPtrLabel"/>
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
            /// <inheritdoc cref="GetObjectPtrLabel"/>
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
            /// <inheritdoc cref="GetObjectPtrLabel"/>
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
            /// <inheritdoc cref="GetObjectPtrLabel"/>
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
            /// <inheritdoc cref="GetObjectPtrLabel"/>
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
            /// <inheritdoc cref="GetObjectPtrLabel"/>
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
            /// <inheritdoc cref="GetObjectPtrLabel"/>
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
            /// <inheritdoc cref="GetObjectPtrLabel"/>
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
            /// <inheritdoc cref="GetObjectPtrLabel"/>
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
            /// <inheritdoc cref="GetObjectPtrLabel"/>
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
            /// <inheritdoc cref="GetObjectPtrLabel"/>
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
            /// <inheritdoc cref="GetObjectPtrLabel"/>
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
            /// <inheritdoc cref="GetObjectPtrLabel"/>
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
            /// <inheritdoc cref="GetPointerv"/>
            public static unsafe void GetPointer(GetPointervPName pname, void** parameters)
            {
                GetPointerv(pname, parameters);
            }
            /// <inheritdoc cref="DebugMessageControlKHR"/>
            public static unsafe void DebugMessageControlKHR(DebugSource source, DebugType type, DebugSeverity severity, int count, in uint ids, bool enabled)
            {
                fixed (uint* ids_ptr = &ids)
                {
                    DebugMessageControlKHR(source, type, severity, count, ids_ptr, enabled);
                }
            }
            /// <inheritdoc cref="DebugMessageInsertKHR"/>
            public static unsafe void DebugMessageInsertKHR(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, string buf)
            {
                byte* buf_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(buf);
                DebugMessageInsertKHR(source, type, id, severity, length, buf_ptr);
                Marshal.FreeCoTaskMem((IntPtr)buf_ptr);
            }
            /// <inheritdoc cref="DebugMessageCallbackKHR"/>
            public static unsafe void DebugMessageCallbackKHR(GLDebugProcKHR callback, IntPtr userParam)
            {
                void* userParam_vptr = (void*)userParam;
                IntPtr callback_ptr = Marshal.GetFunctionPointerForDelegate(callback);
                DebugMessageCallbackKHR(callback_ptr, userParam_vptr);
            }
            /// <inheritdoc cref="DebugMessageCallbackKHR"/>
            public static unsafe void DebugMessageCallbackKHR<T1>(GLDebugProcKHR callback, in T1 userParam)
                where T1 : unmanaged
            {
                fixed (void* userParam_ptr = &userParam)
                {
                    IntPtr callback_ptr = Marshal.GetFunctionPointerForDelegate(callback);
                    DebugMessageCallbackKHR(callback_ptr, userParam_ptr);
                }
            }
            /// <inheritdoc cref="GetDebugMessageLogKHR"/>
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
            /// <inheritdoc cref="GetDebugMessageLogKHR"/>
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
            /// <inheritdoc cref="GetDebugMessageLogKHR"/>
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
            /// <inheritdoc cref="PushDebugGroupKHR"/>
            public static unsafe void PushDebugGroupKHR(DebugSource source, uint id, int length, string message)
            {
                byte* message_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(message);
                PushDebugGroupKHR(source, id, length, message_ptr);
                Marshal.FreeCoTaskMem((IntPtr)message_ptr);
            }
            /// <inheritdoc cref="ObjectLabelKHR"/>
            public static unsafe void ObjectLabelKHR(ObjectIdentifier identifier, uint name, int length, string label)
            {
                byte* label_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(label);
                ObjectLabelKHR(identifier, name, length, label_ptr);
                Marshal.FreeCoTaskMem((IntPtr)label_ptr);
            }
            /// <inheritdoc cref="GetObjectLabelKHR"/>
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
            /// <inheritdoc cref="GetObjectLabelKHR"/>
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
            /// <inheritdoc cref="ObjectPtrLabelKHR"/>
            public static unsafe void ObjectPtrLabelKHR(IntPtr ptr, int length, string label)
            {
                byte* label_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(label);
                void* ptr_vptr = (void*)ptr;
                ObjectPtrLabelKHR(ptr_vptr, length, label_ptr);
                Marshal.FreeCoTaskMem((IntPtr)label_ptr);
            }
            /// <inheritdoc cref="ObjectPtrLabelKHR"/>
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
            /// <inheritdoc cref="GetObjectPtrLabelKHR"/>
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
            /// <inheritdoc cref="GetObjectPtrLabelKHR"/>
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
            /// <inheritdoc cref="GetObjectPtrLabelKHR"/>
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
            /// <inheritdoc cref="GetObjectPtrLabelKHR"/>
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
            /// <inheritdoc cref="GetObjectPtrLabelKHR"/>
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
            /// <inheritdoc cref="GetObjectPtrLabelKHR"/>
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
            /// <inheritdoc cref="GetObjectPtrLabelKHR"/>
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
            /// <inheritdoc cref="GetObjectPtrLabelKHR"/>
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
            /// <inheritdoc cref="GetObjectPtrLabelKHR"/>
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
            /// <inheritdoc cref="GetObjectPtrLabelKHR"/>
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
            /// <inheritdoc cref="GetObjectPtrLabelKHR"/>
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
            /// <inheritdoc cref="GetObjectPtrLabelKHR"/>
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
            /// <inheritdoc cref="ReadnPixels"/>
            public static unsafe void ReadnPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, IntPtr data)
            {
                void* data_vptr = (void*)data;
                ReadnPixels(x, y, width, height, format, type, bufSize, data_vptr);
            }
            /// <inheritdoc cref="ReadnPixels"/>
            public static unsafe void ReadnPixels<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, Span<T1> data)
                where T1 : unmanaged
            {
                int bufSize = (int)(data.Length * sizeof(T1));
                fixed (void* data_ptr = data)
                {
                    ReadnPixels(x, y, width, height, format, type, bufSize, data_ptr);
                }
            }
            /// <inheritdoc cref="ReadnPixels"/>
            public static unsafe void ReadnPixels<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, T1[] data)
                where T1 : unmanaged
            {
                int bufSize = (int)(data.Length * sizeof(T1));
                fixed (void* data_ptr = data)
                {
                    ReadnPixels(x, y, width, height, format, type, bufSize, data_ptr);
                }
            }
            /// <inheritdoc cref="ReadnPixels"/>
            public static unsafe void ReadnPixels<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, ref T1 data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    ReadnPixels(x, y, width, height, format, type, bufSize, data_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformfv"/>
            public static unsafe void GetnUniformf(ProgramHandle program, int location, Span<float> parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (float* parameters_ptr = parameters)
                {
                    GetnUniformfv(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformfv"/>
            public static unsafe void GetnUniformf(ProgramHandle program, int location, float[] parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (float* parameters_ptr = parameters)
                {
                    GetnUniformfv(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformfv"/>
            public static unsafe void GetnUniformf(ProgramHandle program, int location, int bufSize, ref float parameters)
            {
                fixed (float* parameters_ptr = &parameters)
                {
                    GetnUniformfv(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformiv"/>
            public static unsafe void GetnUniformi(ProgramHandle program, int location, Span<int> parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (int* parameters_ptr = parameters)
                {
                    GetnUniformiv(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformiv"/>
            public static unsafe void GetnUniformi(ProgramHandle program, int location, int[] parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (int* parameters_ptr = parameters)
                {
                    GetnUniformiv(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformiv"/>
            public static unsafe void GetnUniformi(ProgramHandle program, int location, int bufSize, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetnUniformiv(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformuiv"/>
            public static unsafe void GetnUniformui(ProgramHandle program, int location, Span<uint> parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (uint* parameters_ptr = parameters)
                {
                    GetnUniformuiv(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformuiv"/>
            public static unsafe void GetnUniformui(ProgramHandle program, int location, uint[] parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (uint* parameters_ptr = parameters)
                {
                    GetnUniformuiv(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformuiv"/>
            public static unsafe void GetnUniformui(ProgramHandle program, int location, int bufSize, ref uint parameters)
            {
                fixed (uint* parameters_ptr = &parameters)
                {
                    GetnUniformuiv(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="ReadnPixelsKHR"/>
            public static unsafe void ReadnPixelsKHR(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, IntPtr data)
            {
                void* data_vptr = (void*)data;
                ReadnPixelsKHR(x, y, width, height, format, type, bufSize, data_vptr);
            }
            /// <inheritdoc cref="ReadnPixelsKHR"/>
            public static unsafe void ReadnPixelsKHR<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, Span<T1> data)
                where T1 : unmanaged
            {
                int bufSize = (int)(data.Length * sizeof(T1));
                fixed (void* data_ptr = data)
                {
                    ReadnPixelsKHR(x, y, width, height, format, type, bufSize, data_ptr);
                }
            }
            /// <inheritdoc cref="ReadnPixelsKHR"/>
            public static unsafe void ReadnPixelsKHR<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, T1[] data)
                where T1 : unmanaged
            {
                int bufSize = (int)(data.Length * sizeof(T1));
                fixed (void* data_ptr = data)
                {
                    ReadnPixelsKHR(x, y, width, height, format, type, bufSize, data_ptr);
                }
            }
            /// <inheritdoc cref="ReadnPixelsKHR"/>
            public static unsafe void ReadnPixelsKHR<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, ref T1 data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    ReadnPixelsKHR(x, y, width, height, format, type, bufSize, data_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformfvKHR"/>
            public static unsafe void GetnUniformfvKHR(ProgramHandle program, int location, Span<float> parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (float* parameters_ptr = parameters)
                {
                    GetnUniformfvKHR(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformfvKHR"/>
            public static unsafe void GetnUniformfvKHR(ProgramHandle program, int location, float[] parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (float* parameters_ptr = parameters)
                {
                    GetnUniformfvKHR(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformfvKHR"/>
            public static unsafe void GetnUniformfvKHR(ProgramHandle program, int location, int bufSize, ref float parameters)
            {
                fixed (float* parameters_ptr = &parameters)
                {
                    GetnUniformfvKHR(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformivKHR"/>
            public static unsafe void GetnUniformivKHR(ProgramHandle program, int location, Span<int> parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (int* parameters_ptr = parameters)
                {
                    GetnUniformivKHR(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformivKHR"/>
            public static unsafe void GetnUniformivKHR(ProgramHandle program, int location, int[] parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (int* parameters_ptr = parameters)
                {
                    GetnUniformivKHR(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformivKHR"/>
            public static unsafe void GetnUniformivKHR(ProgramHandle program, int location, int bufSize, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetnUniformivKHR(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformuivKHR"/>
            public static unsafe void GetnUniformuivKHR(ProgramHandle program, int location, Span<uint> parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (uint* parameters_ptr = parameters)
                {
                    GetnUniformuivKHR(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformuivKHR"/>
            public static unsafe void GetnUniformuivKHR(ProgramHandle program, int location, uint[] parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (uint* parameters_ptr = parameters)
                {
                    GetnUniformuivKHR(program, location, bufSize, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetnUniformuivKHR"/>
            public static unsafe void GetnUniformuivKHR(ProgramHandle program, int location, int bufSize, ref uint parameters)
            {
                fixed (uint* parameters_ptr = &parameters)
                {
                    GetnUniformuivKHR(program, location, bufSize, parameters_ptr);
                }
            }
        }
        public static unsafe partial class MESA
        {
            /// <inheritdoc cref="GetFramebufferParameterivMESA"/>
            public static unsafe void GetFramebufferParameterivMESA(FramebufferTarget target, FramebufferAttachmentParameterName pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetFramebufferParameterivMESA(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetFramebufferParameterivMESA"/>
            public static unsafe void GetFramebufferParameterivMESA(FramebufferTarget target, FramebufferAttachmentParameterName pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetFramebufferParameterivMESA(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetFramebufferParameterivMESA"/>
            public static unsafe void GetFramebufferParameterivMESA(FramebufferTarget target, FramebufferAttachmentParameterName pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetFramebufferParameterivMESA(target, pname, parameters_ptr);
                }
            }
        }
        public static unsafe partial class OES
        {
            /// <inheritdoc cref="EGLImageTargetTexture2DOES"/>
            public static unsafe void EGLImageTargetTexture2DOES(All target, IntPtr image)
            {
                void* image_vptr = (void*)image;
                EGLImageTargetTexture2DOES(target, image_vptr);
            }
            /// <inheritdoc cref="EGLImageTargetTexture2DOES"/>
            public static unsafe void EGLImageTargetTexture2DOES<T1>(All target, ref T1 image)
                where T1 : unmanaged
            {
                fixed (void* image_ptr = &image)
                {
                    EGLImageTargetTexture2DOES(target, image_ptr);
                }
            }
            /// <inheritdoc cref="EGLImageTargetRenderbufferStorageOES"/>
            public static unsafe void EGLImageTargetRenderbufferStorageOES(All target, IntPtr image)
            {
                void* image_vptr = (void*)image;
                EGLImageTargetRenderbufferStorageOES(target, image_vptr);
            }
            /// <inheritdoc cref="EGLImageTargetRenderbufferStorageOES"/>
            public static unsafe void EGLImageTargetRenderbufferStorageOES<T1>(All target, ref T1 image)
                where T1 : unmanaged
            {
                fixed (void* image_ptr = &image)
                {
                    EGLImageTargetRenderbufferStorageOES(target, image_ptr);
                }
            }
            /// <inheritdoc cref="DrawElementsBaseVertexOES"/>
            public static unsafe void DrawElementsBaseVertexOES(PrimitiveType mode, int count, DrawElementsType type, nint offset, int basevertex)
            {
                void* indices = (void*)offset;
                DrawElementsBaseVertexOES(mode, count, type, indices, basevertex);
            }
            /// <inheritdoc cref="DrawRangeElementsBaseVertexOES"/>
            public static unsafe void DrawRangeElementsBaseVertexOES(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, nint offset, int basevertex)
            {
                void* indices = (void*)offset;
                DrawRangeElementsBaseVertexOES(mode, start, end, count, type, indices, basevertex);
            }
            /// <inheritdoc cref="DrawElementsInstancedBaseVertexOES"/>
            public static unsafe void DrawElementsInstancedBaseVertexOES(PrimitiveType mode, int count, DrawElementsType type, nint offset, int instancecount, int basevertex)
            {
                void* indices = (void*)offset;
                DrawElementsInstancedBaseVertexOES(mode, count, type, indices, instancecount, basevertex);
            }
            /// <inheritdoc cref="MultiDrawElementsBaseVertexEXT"/>
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
            /// <inheritdoc cref="MultiDrawElementsBaseVertexEXT"/>
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
            /// <inheritdoc cref="MultiDrawElementsBaseVertexEXT"/>
            public static unsafe void MultiDrawElementsBaseVertexEXT(PrimitiveType mode, in int count, DrawElementsType type, void** indices, int drawcount, in int basevertex)
            {
                fixed (int* count_ptr = &count)
                fixed (int* basevertex_ptr = &basevertex)
                {
                    MultiDrawElementsBaseVertexEXT(mode, count_ptr, type, indices, drawcount, basevertex_ptr);
                }
            }
            /// <inheritdoc cref="GetProgramBinaryOES"/>
            public static unsafe void GetProgramBinaryOES(ProgramHandle program, int bufSize, Span<int> length, Span<All> binaryFormat, IntPtr binary)
            {
                fixed (int* length_ptr = length)
                {
                    fixed (All* binaryFormat_ptr = binaryFormat)
                    {
                        void* binary_vptr = (void*)binary;
                        GetProgramBinaryOES(program, bufSize, length_ptr, binaryFormat_ptr, binary_vptr);
                    }
                }
            }
            /// <inheritdoc cref="GetProgramBinaryOES"/>
            public static unsafe void GetProgramBinaryOES(ProgramHandle program, int bufSize, int[] length, All[] binaryFormat, IntPtr binary)
            {
                fixed (int* length_ptr = length)
                {
                    fixed (All* binaryFormat_ptr = binaryFormat)
                    {
                        void* binary_vptr = (void*)binary;
                        GetProgramBinaryOES(program, bufSize, length_ptr, binaryFormat_ptr, binary_vptr);
                    }
                }
            }
            /// <inheritdoc cref="GetProgramBinaryOES"/>
            public static unsafe void GetProgramBinaryOES(ProgramHandle program, int bufSize, ref int length, ref All binaryFormat, IntPtr binary)
            {
                fixed (int* length_ptr = &length)
                fixed (All* binaryFormat_ptr = &binaryFormat)
                {
                    void* binary_vptr = (void*)binary;
                    GetProgramBinaryOES(program, bufSize, length_ptr, binaryFormat_ptr, binary_vptr);
                }
            }
            /// <inheritdoc cref="GetProgramBinaryOES"/>
            public static unsafe void GetProgramBinaryOES<T1>(ProgramHandle program, Span<int> length, Span<All> binaryFormat, Span<T1> binary)
                where T1 : unmanaged
            {
                fixed (int* length_ptr = length)
                {
                    fixed (All* binaryFormat_ptr = binaryFormat)
                    {
                        int bufSize = (int)(binary.Length * sizeof(T1));
                        fixed (void* binary_ptr = binary)
                        {
                            GetProgramBinaryOES(program, bufSize, length_ptr, binaryFormat_ptr, binary_ptr);
                        }
                    }
                }
            }
            /// <inheritdoc cref="GetProgramBinaryOES"/>
            public static unsafe void GetProgramBinaryOES<T1>(ProgramHandle program, int[] length, All[] binaryFormat, T1[] binary)
                where T1 : unmanaged
            {
                fixed (int* length_ptr = length)
                {
                    fixed (All* binaryFormat_ptr = binaryFormat)
                    {
                        int bufSize = (int)(binary.Length * sizeof(T1));
                        fixed (void* binary_ptr = binary)
                        {
                            GetProgramBinaryOES(program, bufSize, length_ptr, binaryFormat_ptr, binary_ptr);
                        }
                    }
                }
            }
            /// <inheritdoc cref="GetProgramBinaryOES"/>
            public static unsafe void GetProgramBinaryOES<T1>(ProgramHandle program, int bufSize, ref int length, ref All binaryFormat, ref T1 binary)
                where T1 : unmanaged
            {
                fixed (int* length_ptr = &length)
                fixed (All* binaryFormat_ptr = &binaryFormat)
                fixed (void* binary_ptr = &binary)
                {
                    GetProgramBinaryOES(program, bufSize, length_ptr, binaryFormat_ptr, binary_ptr);
                }
            }
            /// <inheritdoc cref="ProgramBinaryOES"/>
            public static unsafe void ProgramBinaryOES(ProgramHandle program, All binaryFormat, IntPtr binary, int length)
            {
                void* binary_vptr = (void*)binary;
                ProgramBinaryOES(program, binaryFormat, binary_vptr, length);
            }
            /// <inheritdoc cref="ProgramBinaryOES"/>
            public static unsafe void ProgramBinaryOES<T1>(ProgramHandle program, All binaryFormat, ReadOnlySpan<T1> binary)
                where T1 : unmanaged
            {
                int length = (int)(binary.Length * sizeof(T1));
                fixed (void* binary_ptr = binary)
                {
                    ProgramBinaryOES(program, binaryFormat, binary_ptr, length);
                }
            }
            /// <inheritdoc cref="ProgramBinaryOES"/>
            public static unsafe void ProgramBinaryOES<T1>(ProgramHandle program, All binaryFormat, T1[] binary)
                where T1 : unmanaged
            {
                int length = (int)(binary.Length * sizeof(T1));
                fixed (void* binary_ptr = binary)
                {
                    ProgramBinaryOES(program, binaryFormat, binary_ptr, length);
                }
            }
            /// <inheritdoc cref="ProgramBinaryOES"/>
            public static unsafe void ProgramBinaryOES<T1>(ProgramHandle program, All binaryFormat, in T1 binary, int length)
                where T1 : unmanaged
            {
                fixed (void* binary_ptr = &binary)
                {
                    ProgramBinaryOES(program, binaryFormat, binary_ptr, length);
                }
            }
            /// <inheritdoc cref="TexImage3DOES"/>
            public static unsafe void TexImage3DOES(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, IntPtr pixels)
            {
                void* pixels_vptr = (void*)pixels;
                TexImage3DOES(target, level, internalformat, width, height, depth, border, format, type, pixels_vptr);
            }
            /// <inheritdoc cref="TexImage3DOES"/>
            public static unsafe void TexImage3DOES<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, ReadOnlySpan<T1> pixels)
                where T1 : unmanaged
            {
                fixed (void* pixels_ptr = pixels)
                {
                    TexImage3DOES(target, level, internalformat, width, height, depth, border, format, type, pixels_ptr);
                }
            }
            /// <inheritdoc cref="TexImage3DOES"/>
            public static unsafe void TexImage3DOES<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, T1[] pixels)
                where T1 : unmanaged
            {
                fixed (void* pixels_ptr = pixels)
                {
                    TexImage3DOES(target, level, internalformat, width, height, depth, border, format, type, pixels_ptr);
                }
            }
            /// <inheritdoc cref="TexImage3DOES"/>
            public static unsafe void TexImage3DOES<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, in T1 pixels)
                where T1 : unmanaged
            {
                fixed (void* pixels_ptr = &pixels)
                {
                    TexImage3DOES(target, level, internalformat, width, height, depth, border, format, type, pixels_ptr);
                }
            }
            /// <inheritdoc cref="TexSubImage3DOES"/>
            public static unsafe void TexSubImage3DOES(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels)
            {
                void* pixels_vptr = (void*)pixels;
                TexSubImage3DOES(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels_vptr);
            }
            /// <inheritdoc cref="TexSubImage3DOES"/>
            public static unsafe void TexSubImage3DOES<T1>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, ReadOnlySpan<T1> pixels)
                where T1 : unmanaged
            {
                fixed (void* pixels_ptr = pixels)
                {
                    TexSubImage3DOES(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels_ptr);
                }
            }
            /// <inheritdoc cref="TexSubImage3DOES"/>
            public static unsafe void TexSubImage3DOES<T1>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, T1[] pixels)
                where T1 : unmanaged
            {
                fixed (void* pixels_ptr = pixels)
                {
                    TexSubImage3DOES(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels_ptr);
                }
            }
            /// <inheritdoc cref="TexSubImage3DOES"/>
            public static unsafe void TexSubImage3DOES<T1>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, in T1 pixels)
                where T1 : unmanaged
            {
                fixed (void* pixels_ptr = &pixels)
                {
                    TexSubImage3DOES(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels_ptr);
                }
            }
            /// <inheritdoc cref="CompressedTexImage3DOES"/>
            public static unsafe void CompressedTexImage3DOES(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data)
            {
                void* data_vptr = (void*)data;
                CompressedTexImage3DOES(target, level, internalformat, width, height, depth, border, imageSize, data_vptr);
            }
            /// <inheritdoc cref="CompressedTexImage3DOES"/>
            public static unsafe void CompressedTexImage3DOES<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, ReadOnlySpan<T1> data)
                where T1 : unmanaged
            {
                int imageSize = (int)(data.Length * sizeof(T1));
                fixed (void* data_ptr = data)
                {
                    CompressedTexImage3DOES(target, level, internalformat, width, height, depth, border, imageSize, data_ptr);
                }
            }
            /// <inheritdoc cref="CompressedTexImage3DOES"/>
            public static unsafe void CompressedTexImage3DOES<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, T1[] data)
                where T1 : unmanaged
            {
                int imageSize = (int)(data.Length * sizeof(T1));
                fixed (void* data_ptr = data)
                {
                    CompressedTexImage3DOES(target, level, internalformat, width, height, depth, border, imageSize, data_ptr);
                }
            }
            /// <inheritdoc cref="CompressedTexImage3DOES"/>
            public static unsafe void CompressedTexImage3DOES<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, in T1 data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    CompressedTexImage3DOES(target, level, internalformat, width, height, depth, border, imageSize, data_ptr);
                }
            }
            /// <inheritdoc cref="CompressedTexSubImage3DOES"/>
            public static unsafe void CompressedTexSubImage3DOES(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, InternalFormat format, int imageSize, IntPtr data)
            {
                void* data_vptr = (void*)data;
                CompressedTexSubImage3DOES(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data_vptr);
            }
            /// <inheritdoc cref="CompressedTexSubImage3DOES"/>
            public static unsafe void CompressedTexSubImage3DOES<T1>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, InternalFormat format, ReadOnlySpan<T1> data)
                where T1 : unmanaged
            {
                int imageSize = (int)(data.Length * sizeof(T1));
                fixed (void* data_ptr = data)
                {
                    CompressedTexSubImage3DOES(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data_ptr);
                }
            }
            /// <inheritdoc cref="CompressedTexSubImage3DOES"/>
            public static unsafe void CompressedTexSubImage3DOES<T1>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, InternalFormat format, T1[] data)
                where T1 : unmanaged
            {
                int imageSize = (int)(data.Length * sizeof(T1));
                fixed (void* data_ptr = data)
                {
                    CompressedTexSubImage3DOES(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data_ptr);
                }
            }
            /// <inheritdoc cref="CompressedTexSubImage3DOES"/>
            public static unsafe void CompressedTexSubImage3DOES<T1>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, InternalFormat format, int imageSize, in T1 data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    CompressedTexSubImage3DOES(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data_ptr);
                }
            }
            /// <inheritdoc cref="TexParameterIivOES"/>
            public static unsafe void TexParameterIivOES(TextureTarget target, TextureParameterName pname, ReadOnlySpan<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    TexParameterIivOES(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexParameterIivOES"/>
            public static unsafe void TexParameterIivOES(TextureTarget target, TextureParameterName pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    TexParameterIivOES(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexParameterIivOES"/>
            public static unsafe void TexParameterIivOES(TextureTarget target, TextureParameterName pname, in int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    TexParameterIivOES(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexParameterIuivOES"/>
            public static unsafe void TexParameterIuivOES(TextureTarget target, TextureParameterName pname, ReadOnlySpan<uint> parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    TexParameterIuivOES(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexParameterIuivOES"/>
            public static unsafe void TexParameterIuivOES(TextureTarget target, TextureParameterName pname, uint[] parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    TexParameterIuivOES(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="TexParameterIuivOES"/>
            public static unsafe void TexParameterIuivOES(TextureTarget target, TextureParameterName pname, in uint parameters)
            {
                fixed (uint* parameters_ptr = &parameters)
                {
                    TexParameterIuivOES(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexParameterIivOES"/>
            public static unsafe void GetTexParameterIivOES(TextureTarget target, GetTextureParameter pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexParameterIivOES(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexParameterIivOES"/>
            public static unsafe void GetTexParameterIivOES(TextureTarget target, GetTextureParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexParameterIivOES(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexParameterIivOES"/>
            public static unsafe void GetTexParameterIivOES(TextureTarget target, GetTextureParameter pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetTexParameterIivOES(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexParameterIuivOES"/>
            public static unsafe void GetTexParameterIuivOES(TextureTarget target, GetTextureParameter pname, Span<uint> parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    GetTexParameterIuivOES(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexParameterIuivOES"/>
            public static unsafe void GetTexParameterIuivOES(TextureTarget target, GetTextureParameter pname, uint[] parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    GetTexParameterIuivOES(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetTexParameterIuivOES"/>
            public static unsafe void GetTexParameterIuivOES(TextureTarget target, GetTextureParameter pname, ref uint parameters)
            {
                fixed (uint* parameters_ptr = &parameters)
                {
                    GetTexParameterIuivOES(target, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="SamplerParameterIivOES"/>
            public static unsafe void SamplerParameterIivOES(SamplerHandle sampler, SamplerParameterI pname, ReadOnlySpan<int> param)
            {
                fixed (int* param_ptr = param)
                {
                    SamplerParameterIivOES(sampler, pname, param_ptr);
                }
            }
            /// <inheritdoc cref="SamplerParameterIivOES"/>
            public static unsafe void SamplerParameterIivOES(SamplerHandle sampler, SamplerParameterI pname, int[] param)
            {
                fixed (int* param_ptr = param)
                {
                    SamplerParameterIivOES(sampler, pname, param_ptr);
                }
            }
            /// <inheritdoc cref="SamplerParameterIivOES"/>
            public static unsafe void SamplerParameterIivOES(SamplerHandle sampler, SamplerParameterI pname, in int param)
            {
                fixed (int* param_ptr = &param)
                {
                    SamplerParameterIivOES(sampler, pname, param_ptr);
                }
            }
            /// <inheritdoc cref="SamplerParameterIuivOES"/>
            public static unsafe void SamplerParameterIuivOES(SamplerHandle sampler, SamplerParameterI pname, ReadOnlySpan<uint> param)
            {
                fixed (uint* param_ptr = param)
                {
                    SamplerParameterIuivOES(sampler, pname, param_ptr);
                }
            }
            /// <inheritdoc cref="SamplerParameterIuivOES"/>
            public static unsafe void SamplerParameterIuivOES(SamplerHandle sampler, SamplerParameterI pname, uint[] param)
            {
                fixed (uint* param_ptr = param)
                {
                    SamplerParameterIuivOES(sampler, pname, param_ptr);
                }
            }
            /// <inheritdoc cref="SamplerParameterIuivOES"/>
            public static unsafe void SamplerParameterIuivOES(SamplerHandle sampler, SamplerParameterI pname, in uint param)
            {
                fixed (uint* param_ptr = &param)
                {
                    SamplerParameterIuivOES(sampler, pname, param_ptr);
                }
            }
            /// <inheritdoc cref="GetSamplerParameterIivOES"/>
            public static unsafe void GetSamplerParameterIivOES(SamplerHandle sampler, SamplerParameterI pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetSamplerParameterIivOES(sampler, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetSamplerParameterIivOES"/>
            public static unsafe void GetSamplerParameterIivOES(SamplerHandle sampler, SamplerParameterI pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetSamplerParameterIivOES(sampler, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetSamplerParameterIivOES"/>
            public static unsafe void GetSamplerParameterIivOES(SamplerHandle sampler, SamplerParameterI pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetSamplerParameterIivOES(sampler, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetSamplerParameterIuivOES"/>
            public static unsafe void GetSamplerParameterIuivOES(SamplerHandle sampler, SamplerParameterI pname, Span<uint> parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    GetSamplerParameterIuivOES(sampler, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetSamplerParameterIuivOES"/>
            public static unsafe void GetSamplerParameterIuivOES(SamplerHandle sampler, SamplerParameterI pname, uint[] parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    GetSamplerParameterIuivOES(sampler, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="GetSamplerParameterIuivOES"/>
            public static unsafe void GetSamplerParameterIuivOES(SamplerHandle sampler, SamplerParameterI pname, ref uint parameters)
            {
                fixed (uint* parameters_ptr = &parameters)
                {
                    GetSamplerParameterIuivOES(sampler, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="DeleteVertexArraysOES"/>
            public static unsafe void DeleteVertexArraysOES(ReadOnlySpan<VertexArrayHandle> arrays)
            {
                int n = (int)(arrays.Length);
                fixed (VertexArrayHandle* arrays_ptr = arrays)
                {
                    DeleteVertexArraysOES(n, arrays_ptr);
                }
            }
            /// <inheritdoc cref="DeleteVertexArraysOES"/>
            public static unsafe void DeleteVertexArraysOES(VertexArrayHandle[] arrays)
            {
                int n = (int)(arrays.Length);
                fixed (VertexArrayHandle* arrays_ptr = arrays)
                {
                    DeleteVertexArraysOES(n, arrays_ptr);
                }
            }
            /// <inheritdoc cref="DeleteVertexArraysOES"/>
            public static unsafe void DeleteVertexArraysOES(int n, in VertexArrayHandle arrays)
            {
                fixed (VertexArrayHandle* arrays_ptr = &arrays)
                {
                    DeleteVertexArraysOES(n, arrays_ptr);
                }
            }
            /// <inheritdoc cref="GenVertexArraysOES"/>
            public static unsafe void GenVertexArraysOES(Span<VertexArrayHandle> arrays)
            {
                int n = (int)(arrays.Length);
                fixed (VertexArrayHandle* arrays_ptr = arrays)
                {
                    GenVertexArraysOES(n, arrays_ptr);
                }
            }
            /// <inheritdoc cref="GenVertexArraysOES"/>
            public static unsafe void GenVertexArraysOES(VertexArrayHandle[] arrays)
            {
                int n = (int)(arrays.Length);
                fixed (VertexArrayHandle* arrays_ptr = arrays)
                {
                    GenVertexArraysOES(n, arrays_ptr);
                }
            }
            /// <inheritdoc cref="GenVertexArraysOES"/>
            public static unsafe void GenVertexArraysOES(int n, ref VertexArrayHandle arrays)
            {
                fixed (VertexArrayHandle* arrays_ptr = &arrays)
                {
                    GenVertexArraysOES(n, arrays_ptr);
                }
            }
            /// <inheritdoc cref="ViewportArrayvOES"/>
            public static unsafe void ViewportArrayvOES(uint first, int count, ReadOnlySpan<float> v)
            {
                fixed (float* v_ptr = v)
                {
                    ViewportArrayvOES(first, count, v_ptr);
                }
            }
            /// <inheritdoc cref="ViewportArrayvOES"/>
            public static unsafe void ViewportArrayvOES(uint first, int count, float[] v)
            {
                fixed (float* v_ptr = v)
                {
                    ViewportArrayvOES(first, count, v_ptr);
                }
            }
            /// <inheritdoc cref="ViewportArrayvOES"/>
            public static unsafe void ViewportArrayvOES(uint first, int count, in float v)
            {
                fixed (float* v_ptr = &v)
                {
                    ViewportArrayvOES(first, count, v_ptr);
                }
            }
            /// <inheritdoc cref="ViewportIndexedfvOES"/>
            public static unsafe void ViewportIndexedfvOES(uint index, ReadOnlySpan<float> v)
            {
                fixed (float* v_ptr = v)
                {
                    ViewportIndexedfvOES(index, v_ptr);
                }
            }
            /// <inheritdoc cref="ViewportIndexedfvOES"/>
            public static unsafe void ViewportIndexedfvOES(uint index, float[] v)
            {
                fixed (float* v_ptr = v)
                {
                    ViewportIndexedfvOES(index, v_ptr);
                }
            }
            /// <inheritdoc cref="ViewportIndexedfvOES"/>
            public static unsafe void ViewportIndexedfvOES(uint index, in float v)
            {
                fixed (float* v_ptr = &v)
                {
                    ViewportIndexedfvOES(index, v_ptr);
                }
            }
            /// <inheritdoc cref="ScissorArrayvOES"/>
            public static unsafe void ScissorArrayvOES(uint first, int count, ReadOnlySpan<int> v)
            {
                fixed (int* v_ptr = v)
                {
                    ScissorArrayvOES(first, count, v_ptr);
                }
            }
            /// <inheritdoc cref="ScissorArrayvOES"/>
            public static unsafe void ScissorArrayvOES(uint first, int count, int[] v)
            {
                fixed (int* v_ptr = v)
                {
                    ScissorArrayvOES(first, count, v_ptr);
                }
            }
            /// <inheritdoc cref="ScissorArrayvOES"/>
            public static unsafe void ScissorArrayvOES(uint first, int count, in int v)
            {
                fixed (int* v_ptr = &v)
                {
                    ScissorArrayvOES(first, count, v_ptr);
                }
            }
            /// <inheritdoc cref="ScissorIndexedvOES"/>
            public static unsafe void ScissorIndexedvOES(uint index, ReadOnlySpan<int> v)
            {
                fixed (int* v_ptr = v)
                {
                    ScissorIndexedvOES(index, v_ptr);
                }
            }
            /// <inheritdoc cref="ScissorIndexedvOES"/>
            public static unsafe void ScissorIndexedvOES(uint index, int[] v)
            {
                fixed (int* v_ptr = v)
                {
                    ScissorIndexedvOES(index, v_ptr);
                }
            }
            /// <inheritdoc cref="ScissorIndexedvOES"/>
            public static unsafe void ScissorIndexedvOES(uint index, in int v)
            {
                fixed (int* v_ptr = &v)
                {
                    ScissorIndexedvOES(index, v_ptr);
                }
            }
            /// <inheritdoc cref="DepthRangeArrayfvOES"/>
            public static unsafe void DepthRangeArrayfvOES(uint first, int count, in float v)
            {
                fixed (float* v_ptr = &v)
                {
                    DepthRangeArrayfvOES(first, count, v_ptr);
                }
            }
            /// <inheritdoc cref="GetFloati_vOES"/>
            public static unsafe void GetFloati_vOES(GetPName target, uint index, Span<float> data)
            {
                fixed (float* data_ptr = data)
                {
                    GetFloati_vOES(target, index, data_ptr);
                }
            }
            /// <inheritdoc cref="GetFloati_vOES"/>
            public static unsafe void GetFloati_vOES(GetPName target, uint index, float[] data)
            {
                fixed (float* data_ptr = data)
                {
                    GetFloati_vOES(target, index, data_ptr);
                }
            }
            /// <inheritdoc cref="GetFloati_vOES"/>
            public static unsafe void GetFloati_vOES(GetPName target, uint index, ref float data)
            {
                fixed (float* data_ptr = &data)
                {
                    GetFloati_vOES(target, index, data_ptr);
                }
            }
        }
        public static unsafe partial class OVR
        {
        }
        public static unsafe partial class QCOM
        {
            /// <inheritdoc cref="GetDriverControlsQCOM"/>
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
            /// <inheritdoc cref="GetDriverControlsQCOM"/>
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
            /// <inheritdoc cref="GetDriverControlsQCOM"/>
            public static unsafe void GetDriverControlsQCOM(ref int num, int size, ref uint driverControls)
            {
                fixed (int* num_ptr = &num)
                fixed (uint* driverControls_ptr = &driverControls)
                {
                    GetDriverControlsQCOM(num_ptr, size, driverControls_ptr);
                }
            }
            /// <inheritdoc cref="GetDriverControlStringQCOM"/>
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
            /// <inheritdoc cref="GetDriverControlStringQCOM"/>
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
            /// <inheritdoc cref="ExtGetTexturesQCOM"/>
            public static unsafe void ExtGetTexturesQCOM(ref TextureHandle textures, int maxTextures, ref int numTextures)
            {
                fixed (TextureHandle* textures_ptr = &textures)
                fixed (int* numTextures_ptr = &numTextures)
                {
                    ExtGetTexturesQCOM(textures_ptr, maxTextures, numTextures_ptr);
                }
            }
            /// <inheritdoc cref="ExtGetBuffersQCOM"/>
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
            /// <inheritdoc cref="ExtGetBuffersQCOM"/>
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
            /// <inheritdoc cref="ExtGetBuffersQCOM"/>
            public static unsafe void ExtGetBuffersQCOM(ref BufferHandle buffers, int maxBuffers, ref int numBuffers)
            {
                fixed (BufferHandle* buffers_ptr = &buffers)
                fixed (int* numBuffers_ptr = &numBuffers)
                {
                    ExtGetBuffersQCOM(buffers_ptr, maxBuffers, numBuffers_ptr);
                }
            }
            /// <inheritdoc cref="ExtGetRenderbuffersQCOM"/>
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
            /// <inheritdoc cref="ExtGetRenderbuffersQCOM"/>
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
            /// <inheritdoc cref="ExtGetRenderbuffersQCOM"/>
            public static unsafe void ExtGetRenderbuffersQCOM(ref RenderbufferHandle renderbuffers, int maxRenderbuffers, ref int numRenderbuffers)
            {
                fixed (RenderbufferHandle* renderbuffers_ptr = &renderbuffers)
                fixed (int* numRenderbuffers_ptr = &numRenderbuffers)
                {
                    ExtGetRenderbuffersQCOM(renderbuffers_ptr, maxRenderbuffers, numRenderbuffers_ptr);
                }
            }
            /// <inheritdoc cref="ExtGetFramebuffersQCOM"/>
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
            /// <inheritdoc cref="ExtGetFramebuffersQCOM"/>
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
            /// <inheritdoc cref="ExtGetFramebuffersQCOM"/>
            public static unsafe void ExtGetFramebuffersQCOM(ref FramebufferHandle framebuffers, int maxFramebuffers, ref int numFramebuffers)
            {
                fixed (FramebufferHandle* framebuffers_ptr = &framebuffers)
                fixed (int* numFramebuffers_ptr = &numFramebuffers)
                {
                    ExtGetFramebuffersQCOM(framebuffers_ptr, maxFramebuffers, numFramebuffers_ptr);
                }
            }
            /// <inheritdoc cref="ExtGetTexLevelParameterivQCOM"/>
            public static unsafe void ExtGetTexLevelParameterivQCOM(TextureHandle texture, All face, int level, All pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    ExtGetTexLevelParameterivQCOM(texture, face, level, pname, parameters_ptr);
                }
            }
            /// <inheritdoc cref="ExtGetTexSubImageQCOM"/>
            public static unsafe void ExtGetTexSubImageQCOM(All target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr texels)
            {
                void* texels_vptr = (void*)texels;
                ExtGetTexSubImageQCOM(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, texels_vptr);
            }
            /// <inheritdoc cref="ExtGetTexSubImageQCOM"/>
            public static unsafe void ExtGetTexSubImageQCOM<T1>(All target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, ref T1 texels)
                where T1 : unmanaged
            {
                fixed (void* texels_ptr = &texels)
                {
                    ExtGetTexSubImageQCOM(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, texels_ptr);
                }
            }
            /// <inheritdoc cref="ExtGetShadersQCOM"/>
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
            /// <inheritdoc cref="ExtGetShadersQCOM"/>
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
            /// <inheritdoc cref="ExtGetShadersQCOM"/>
            public static unsafe void ExtGetShadersQCOM(ref ShaderHandle shaders, int maxShaders, ref int numShaders)
            {
                fixed (ShaderHandle* shaders_ptr = &shaders)
                fixed (int* numShaders_ptr = &numShaders)
                {
                    ExtGetShadersQCOM(shaders_ptr, maxShaders, numShaders_ptr);
                }
            }
            /// <inheritdoc cref="ExtGetProgramsQCOM"/>
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
            /// <inheritdoc cref="ExtGetProgramsQCOM"/>
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
            /// <inheritdoc cref="ExtGetProgramsQCOM"/>
            public static unsafe void ExtGetProgramsQCOM(ref ProgramHandle programs, int maxPrograms, ref int numPrograms)
            {
                fixed (ProgramHandle* programs_ptr = &programs)
                fixed (int* numPrograms_ptr = &numPrograms)
                {
                    ExtGetProgramsQCOM(programs_ptr, maxPrograms, numPrograms_ptr);
                }
            }
            /// <inheritdoc cref="ExtGetProgramBinarySourceQCOM"/>
            public static unsafe string ExtGetProgramBinarySourceQCOM(ProgramHandle program, ShaderType shadertype, ref int length)
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
            /// <inheritdoc cref="ExtGetProgramBinarySourceQCOM"/>
            public static unsafe void ExtGetProgramBinarySourceQCOM(ProgramHandle program, ShaderType shadertype, out string source, ref int length)
            {
                fixed (int* length_ptr = &length)
                {
                    var source_ptr = (byte*)Marshal.AllocCoTaskMem(*length_ptr);
                    ExtGetProgramBinarySourceQCOM(program, shadertype, source_ptr, length_ptr);
                    source = Marshal.PtrToStringUTF8((IntPtr)source_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)source_ptr);
                }
            }
            /// <inheritdoc cref="FramebufferFoveationConfigQCOM"/>
            public static unsafe void FramebufferFoveationConfigQCOM(FramebufferHandle framebuffer, uint numLayers, uint focalPointsPerLayer, uint requestedFeatures, Span<uint> providedFeatures)
            {
                fixed (uint* providedFeatures_ptr = providedFeatures)
                {
                    FramebufferFoveationConfigQCOM(framebuffer, numLayers, focalPointsPerLayer, requestedFeatures, providedFeatures_ptr);
                }
            }
            /// <inheritdoc cref="FramebufferFoveationConfigQCOM"/>
            public static unsafe void FramebufferFoveationConfigQCOM(FramebufferHandle framebuffer, uint numLayers, uint focalPointsPerLayer, uint requestedFeatures, uint[] providedFeatures)
            {
                fixed (uint* providedFeatures_ptr = providedFeatures)
                {
                    FramebufferFoveationConfigQCOM(framebuffer, numLayers, focalPointsPerLayer, requestedFeatures, providedFeatures_ptr);
                }
            }
            /// <inheritdoc cref="FramebufferFoveationConfigQCOM"/>
            public static unsafe void FramebufferFoveationConfigQCOM(FramebufferHandle framebuffer, uint numLayers, uint focalPointsPerLayer, uint requestedFeatures, ref uint providedFeatures)
            {
                fixed (uint* providedFeatures_ptr = &providedFeatures)
                {
                    FramebufferFoveationConfigQCOM(framebuffer, numLayers, focalPointsPerLayer, requestedFeatures, providedFeatures_ptr);
                }
            }
        }
    }
}
