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
        /// <summary> Associates a generic vertex attribute index with a named attribute variable. </summary>
        /// <param name="program">Specifies the handle of the program object in which the association is to be made.</param>
        /// <param name="index">Specifies the index of the generic vertex attribute to be bound.</param>
        /// <param name="name">Specifies a null terminated string containing the name of the vertex shader attribute variable to which index is to be bound.</param>
        public static unsafe void BindAttribLocation(ProgramHandle program, uint index, string name)
        {
            byte* name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(name);
            BindAttribLocation(program, index, name_ptr);
            Marshal.FreeCoTaskMem((IntPtr)name_ptr);
        }
        /// <summary> Creates and initializes a buffer object's data store. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glBufferData, which must be one of the buffer binding targets in the following table: </param>
        /// <param name="size"> Specifies the size in bytes of the buffer object's new data store. </param>
        /// <param name="data"> Specifies a pointer to data that will be copied into the data store for initialization, or NULL if no data is to be copied. </param>
        /// <param name="usage"> Specifies the expected usage pattern of the data store. The symbolic constant must be GL_STREAM_DRAW, GL_STREAM_READ, GL_STREAM_COPY, GL_STATIC_DRAW, GL_STATIC_READ, GL_STATIC_COPY, GL_DYNAMIC_DRAW, GL_DYNAMIC_READ, or GL_DYNAMIC_COPY. </param>
        public static unsafe void BufferData(BufferTargetARB target, nint size, IntPtr data, BufferUsageARB usage)
        {
            void* data_vptr = (void*)data;
            BufferData(target, size, data_vptr, usage);
        }
        /// <summary> Creates and initializes a buffer object's data store. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glBufferData, which must be one of the buffer binding targets in the following table: </param>
        /// <param name="data"> Specifies a pointer to data that will be copied into the data store for initialization, or NULL if no data is to be copied. </param>
        /// <param name="usage"> Specifies the expected usage pattern of the data store. The symbolic constant must be GL_STREAM_DRAW, GL_STREAM_READ, GL_STREAM_COPY, GL_STATIC_DRAW, GL_STATIC_READ, GL_STATIC_COPY, GL_DYNAMIC_DRAW, GL_DYNAMIC_READ, or GL_DYNAMIC_COPY. </param>
        public static unsafe void BufferData<T1>(BufferTargetARB target, ReadOnlySpan<T1> data, BufferUsageARB usage)
            where T1 : unmanaged
        {
            nint size = (nint)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                BufferData(target, size, data_ptr, usage);
            }
        }
        /// <summary> Creates and initializes a buffer object's data store. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glBufferData, which must be one of the buffer binding targets in the following table: </param>
        /// <param name="data"> Specifies a pointer to data that will be copied into the data store for initialization, or NULL if no data is to be copied. </param>
        /// <param name="usage"> Specifies the expected usage pattern of the data store. The symbolic constant must be GL_STREAM_DRAW, GL_STREAM_READ, GL_STREAM_COPY, GL_STATIC_DRAW, GL_STATIC_READ, GL_STATIC_COPY, GL_DYNAMIC_DRAW, GL_DYNAMIC_READ, or GL_DYNAMIC_COPY. </param>
        public static unsafe void BufferData<T1>(BufferTargetARB target, T1[] data, BufferUsageARB usage)
            where T1 : unmanaged
        {
            nint size = (nint)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                BufferData(target, size, data_ptr, usage);
            }
        }
        /// <summary> Creates and initializes a buffer object's data store. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glBufferData, which must be one of the buffer binding targets in the following table: </param>
        /// <param name="size"> Specifies the size in bytes of the buffer object's new data store. </param>
        /// <param name="data"> Specifies a pointer to data that will be copied into the data store for initialization, or NULL if no data is to be copied. </param>
        /// <param name="usage"> Specifies the expected usage pattern of the data store. The symbolic constant must be GL_STREAM_DRAW, GL_STREAM_READ, GL_STREAM_COPY, GL_STATIC_DRAW, GL_STATIC_READ, GL_STATIC_COPY, GL_DYNAMIC_DRAW, GL_DYNAMIC_READ, or GL_DYNAMIC_COPY. </param>
        public static unsafe void BufferData<T1>(BufferTargetARB target, nint size, in T1 data, BufferUsageARB usage)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = &data)
            {
                BufferData(target, size, data_ptr, usage);
            }
        }
        /// <summary> Updates a subset of a buffer object's data store. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glBufferSubData, which must be one of the buffer binding targets in the following table: </param>
        /// <param name="offset"> Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes. </param>
        /// <param name="size"> Specifies the size in bytes of the data store region being replaced. </param>
        /// <param name="data"> Specifies a pointer to the new data that will be copied into the data store. </param>
        public static unsafe void BufferSubData(BufferTargetARB target, IntPtr offset, nint size, IntPtr data)
        {
            void* data_vptr = (void*)data;
            BufferSubData(target, offset, size, data_vptr);
        }
        /// <summary> Updates a subset of a buffer object's data store. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glBufferSubData, which must be one of the buffer binding targets in the following table: </param>
        /// <param name="offset"> Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes. </param>
        /// <param name="data"> Specifies a pointer to the new data that will be copied into the data store. </param>
        public static unsafe void BufferSubData<T1>(BufferTargetARB target, IntPtr offset, ReadOnlySpan<T1> data)
            where T1 : unmanaged
        {
            nint size = (nint)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                BufferSubData(target, offset, size, data_ptr);
            }
        }
        /// <summary> Updates a subset of a buffer object's data store. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glBufferSubData, which must be one of the buffer binding targets in the following table: </param>
        /// <param name="offset"> Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes. </param>
        /// <param name="data"> Specifies a pointer to the new data that will be copied into the data store. </param>
        public static unsafe void BufferSubData<T1>(BufferTargetARB target, IntPtr offset, T1[] data)
            where T1 : unmanaged
        {
            nint size = (nint)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                BufferSubData(target, offset, size, data_ptr);
            }
        }
        /// <summary> Updates a subset of a buffer object's data store. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glBufferSubData, which must be one of the buffer binding targets in the following table: </param>
        /// <param name="offset"> Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes. </param>
        /// <param name="size"> Specifies the size in bytes of the data store region being replaced. </param>
        /// <param name="data"> Specifies a pointer to the new data that will be copied into the data store. </param>
        public static unsafe void BufferSubData<T1>(BufferTargetARB target, IntPtr offset, nint size, in T1 data)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = &data)
            {
                BufferSubData(target, offset, size, data_ptr);
            }
        }
        /// <summary> Enable and disable writing of frame buffer color components. </summary>
        /// <param name="red"> Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written. </param>
        /// <param name="green"> Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written. </param>
        /// <param name="blue"> Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written. </param>
        /// <param name="alpha"> Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written. </param>
        public static unsafe void ColorMask(bool red, bool green, bool blue, bool alpha)
        {
            byte red_byte = (byte)(red ? 1 : 0);
            byte green_byte = (byte)(green ? 1 : 0);
            byte blue_byte = (byte)(blue ? 1 : 0);
            byte alpha_byte = (byte)(alpha ? 1 : 0);
            ColorMask(red_byte, green_byte, blue_byte, alpha_byte);
        }
        /// <summary> Specify a two-dimensional texture image in a compressed format. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="internalformat"> Specifies the format of the compressed image data stored at address data. </param>
        /// <param name="width"> Specifies the width of the texture image. All implementations support 2D and cube-mapped texture images that are at least 2048 texels wide. </param>
        /// <param name="height"> Specifies the height of the texture image. All implementations support 2D and cube-mapped texture images that are at least 2048 texels high. </param>
        /// <param name="border"> This value must be 0. </param>
        /// <param name="imageSize"> Specifies the number of unsigned bytes of image data starting at the address specified by data. </param>
        /// <param name="data"> Specifies a pointer to the compressed image data in memory. </param>
        public static unsafe void CompressedTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, IntPtr data)
        {
            void* data_vptr = (void*)data;
            CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data_vptr);
        }
        /// <summary> Specify a two-dimensional texture image in a compressed format. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="internalformat"> Specifies the format of the compressed image data stored at address data. </param>
        /// <param name="width"> Specifies the width of the texture image. All implementations support 2D and cube-mapped texture images that are at least 2048 texels wide. </param>
        /// <param name="height"> Specifies the height of the texture image. All implementations support 2D and cube-mapped texture images that are at least 2048 texels high. </param>
        /// <param name="border"> This value must be 0. </param>
        /// <param name="data"> Specifies a pointer to the compressed image data in memory. </param>
        public static unsafe void CompressedTexImage2D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, ReadOnlySpan<T1> data)
            where T1 : unmanaged
        {
            int imageSize = (int)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data_ptr);
            }
        }
        /// <summary> Specify a two-dimensional texture image in a compressed format. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="internalformat"> Specifies the format of the compressed image data stored at address data. </param>
        /// <param name="width"> Specifies the width of the texture image. All implementations support 2D and cube-mapped texture images that are at least 2048 texels wide. </param>
        /// <param name="height"> Specifies the height of the texture image. All implementations support 2D and cube-mapped texture images that are at least 2048 texels high. </param>
        /// <param name="border"> This value must be 0. </param>
        /// <param name="data"> Specifies a pointer to the compressed image data in memory. </param>
        public static unsafe void CompressedTexImage2D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, T1[] data)
            where T1 : unmanaged
        {
            int imageSize = (int)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data_ptr);
            }
        }
        /// <summary> Specify a two-dimensional texture image in a compressed format. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="internalformat"> Specifies the format of the compressed image data stored at address data. </param>
        /// <param name="width"> Specifies the width of the texture image. All implementations support 2D and cube-mapped texture images that are at least 2048 texels wide. </param>
        /// <param name="height"> Specifies the height of the texture image. All implementations support 2D and cube-mapped texture images that are at least 2048 texels high. </param>
        /// <param name="border"> This value must be 0. </param>
        /// <param name="imageSize"> Specifies the number of unsigned bytes of image data starting at the address specified by data. </param>
        /// <param name="data"> Specifies a pointer to the compressed image data in memory. </param>
        public static unsafe void CompressedTexImage2D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, in T1 data)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = &data)
            {
                CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data_ptr);
            }
        }
        /// <summary> Specify a two-dimensional texture subimage in a compressed format. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="xoffset"> Specifies a texel offset in the x direction within the texture array. </param>
        /// <param name="yoffset"> Specifies a texel offset in the y direction within the texture array. </param>
        /// <param name="width"> Specifies the width of the texture subimage. </param>
        /// <param name="height"> Specifies the height of the texture subimage. </param>
        /// <param name="format"> Specifies the format of the compressed image data stored at address data. </param>
        /// <param name="imageSize"> Specifies the number of unsigned bytes of image data starting at the address specified by data. </param>
        /// <param name="data"> Specifies a pointer to the compressed image data in memory. </param>
        public static unsafe void CompressedTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, IntPtr data)
        {
            void* data_vptr = (void*)data;
            CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data_vptr);
        }
        /// <summary> Specify a two-dimensional texture subimage in a compressed format. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="xoffset"> Specifies a texel offset in the x direction within the texture array. </param>
        /// <param name="yoffset"> Specifies a texel offset in the y direction within the texture array. </param>
        /// <param name="width"> Specifies the width of the texture subimage. </param>
        /// <param name="height"> Specifies the height of the texture subimage. </param>
        /// <param name="format"> Specifies the format of the compressed image data stored at address data. </param>
        /// <param name="data"> Specifies a pointer to the compressed image data in memory. </param>
        public static unsafe void CompressedTexSubImage2D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, ReadOnlySpan<T1> data)
            where T1 : unmanaged
        {
            int imageSize = (int)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data_ptr);
            }
        }
        /// <summary> Specify a two-dimensional texture subimage in a compressed format. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="xoffset"> Specifies a texel offset in the x direction within the texture array. </param>
        /// <param name="yoffset"> Specifies a texel offset in the y direction within the texture array. </param>
        /// <param name="width"> Specifies the width of the texture subimage. </param>
        /// <param name="height"> Specifies the height of the texture subimage. </param>
        /// <param name="format"> Specifies the format of the compressed image data stored at address data. </param>
        /// <param name="data"> Specifies a pointer to the compressed image data in memory. </param>
        public static unsafe void CompressedTexSubImage2D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, T1[] data)
            where T1 : unmanaged
        {
            int imageSize = (int)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data_ptr);
            }
        }
        /// <summary> Specify a two-dimensional texture subimage in a compressed format. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="xoffset"> Specifies a texel offset in the x direction within the texture array. </param>
        /// <param name="yoffset"> Specifies a texel offset in the y direction within the texture array. </param>
        /// <param name="width"> Specifies the width of the texture subimage. </param>
        /// <param name="height"> Specifies the height of the texture subimage. </param>
        /// <param name="format"> Specifies the format of the compressed image data stored at address data. </param>
        /// <param name="imageSize"> Specifies the number of unsigned bytes of image data starting at the address specified by data. </param>
        /// <param name="data"> Specifies a pointer to the compressed image data in memory. </param>
        public static unsafe void CompressedTexSubImage2D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, in T1 data)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = &data)
            {
                CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data_ptr);
            }
        }
        /// <summary> Delete named buffer objects. </summary>
        /// <param name="buffers"> Specifies an array of buffer objects to be deleted. </param>
        public static unsafe void DeleteBuffer(in BufferHandle buffers)
        {
            int n = 1;
            fixed(BufferHandle* buffers_handle = &buffers)
            {
                DeleteBuffers(n, buffers_handle);
            }
        }
        /// <summary> Delete named buffer objects. </summary>
        /// <param name="buffers"> Specifies an array of buffer objects to be deleted. </param>
        public static unsafe void DeleteBuffers(ReadOnlySpan<BufferHandle> buffers)
        {
            int n = (int)(buffers.Length);
            fixed (BufferHandle* buffers_ptr = buffers)
            {
                DeleteBuffers(n, buffers_ptr);
            }
        }
        /// <summary> Delete named buffer objects. </summary>
        /// <param name="buffers"> Specifies an array of buffer objects to be deleted. </param>
        public static unsafe void DeleteBuffers(BufferHandle[] buffers)
        {
            int n = (int)(buffers.Length);
            fixed (BufferHandle* buffers_ptr = buffers)
            {
                DeleteBuffers(n, buffers_ptr);
            }
        }
        /// <summary> Delete named buffer objects. </summary>
        /// <param name="n"> Specifies the number of buffer objects to be deleted. </param>
        /// <param name="buffers"> Specifies an array of buffer objects to be deleted. </param>
        public static unsafe void DeleteBuffers(int n, in BufferHandle buffers)
        {
            fixed (BufferHandle* buffers_ptr = &buffers)
            {
                DeleteBuffers(n, buffers_ptr);
            }
        }
        /// <summary> Delete framebuffer objects. </summary>
        /// <param name="framebuffers"> A pointer to an array containing n framebuffer objects to be deleted. </param>
        public static unsafe void DeleteFramebuffer(in FramebufferHandle framebuffers)
        {
            int n = 1;
            fixed(FramebufferHandle* framebuffers_handle = &framebuffers)
            {
                DeleteFramebuffers(n, framebuffers_handle);
            }
        }
        /// <summary> Delete framebuffer objects. </summary>
        /// <param name="framebuffers"> A pointer to an array containing n framebuffer objects to be deleted. </param>
        public static unsafe void DeleteFramebuffers(ReadOnlySpan<FramebufferHandle> framebuffers)
        {
            int n = (int)(framebuffers.Length);
            fixed (FramebufferHandle* framebuffers_ptr = framebuffers)
            {
                DeleteFramebuffers(n, framebuffers_ptr);
            }
        }
        /// <summary> Delete framebuffer objects. </summary>
        /// <param name="framebuffers"> A pointer to an array containing n framebuffer objects to be deleted. </param>
        public static unsafe void DeleteFramebuffers(FramebufferHandle[] framebuffers)
        {
            int n = (int)(framebuffers.Length);
            fixed (FramebufferHandle* framebuffers_ptr = framebuffers)
            {
                DeleteFramebuffers(n, framebuffers_ptr);
            }
        }
        /// <summary> Delete framebuffer objects. </summary>
        /// <param name="n"> Specifies the number of framebuffer objects to be deleted. </param>
        /// <param name="framebuffers"> A pointer to an array containing n framebuffer objects to be deleted. </param>
        public static unsafe void DeleteFramebuffers(int n, in FramebufferHandle framebuffers)
        {
            fixed (FramebufferHandle* framebuffers_ptr = &framebuffers)
            {
                DeleteFramebuffers(n, framebuffers_ptr);
            }
        }
        /// <summary> Delete renderbuffer objects. </summary>
        /// <param name="renderbuffers"> A pointer to an array containing n renderbuffer objects to be deleted. </param>
        public static unsafe void DeleteRenderbuffer(in RenderbufferHandle renderbuffers)
        {
            int n = 1;
            fixed(RenderbufferHandle* renderbuffers_handle = &renderbuffers)
            {
                DeleteRenderbuffers(n, renderbuffers_handle);
            }
        }
        /// <summary> Delete renderbuffer objects. </summary>
        /// <param name="renderbuffers"> A pointer to an array containing n renderbuffer objects to be deleted. </param>
        public static unsafe void DeleteRenderbuffers(ReadOnlySpan<RenderbufferHandle> renderbuffers)
        {
            int n = (int)(renderbuffers.Length);
            fixed (RenderbufferHandle* renderbuffers_ptr = renderbuffers)
            {
                DeleteRenderbuffers(n, renderbuffers_ptr);
            }
        }
        /// <summary> Delete renderbuffer objects. </summary>
        /// <param name="renderbuffers"> A pointer to an array containing n renderbuffer objects to be deleted. </param>
        public static unsafe void DeleteRenderbuffers(RenderbufferHandle[] renderbuffers)
        {
            int n = (int)(renderbuffers.Length);
            fixed (RenderbufferHandle* renderbuffers_ptr = renderbuffers)
            {
                DeleteRenderbuffers(n, renderbuffers_ptr);
            }
        }
        /// <summary> Delete renderbuffer objects. </summary>
        /// <param name="n"> Specifies the number of renderbuffer objects to be deleted. </param>
        /// <param name="renderbuffers"> A pointer to an array containing n renderbuffer objects to be deleted. </param>
        public static unsafe void DeleteRenderbuffers(int n, in RenderbufferHandle renderbuffers)
        {
            fixed (RenderbufferHandle* renderbuffers_ptr = &renderbuffers)
            {
                DeleteRenderbuffers(n, renderbuffers_ptr);
            }
        }
        /// <summary> Delete named textures. </summary>
        /// <param name="textures"> Specifies an array of textures to be deleted. </param>
        public static unsafe void DeleteTexture(in TextureHandle textures)
        {
            int n = 1;
            fixed(TextureHandle* textures_handle = &textures)
            {
                DeleteTextures(n, textures_handle);
            }
        }
        /// <summary> Delete named textures. </summary>
        /// <param name="textures"> Specifies an array of textures to be deleted. </param>
        public static unsafe void DeleteTextures(ReadOnlySpan<TextureHandle> textures)
        {
            int n = (int)(textures.Length);
            fixed (TextureHandle* textures_ptr = textures)
            {
                DeleteTextures(n, textures_ptr);
            }
        }
        /// <summary> Delete named textures. </summary>
        /// <param name="textures"> Specifies an array of textures to be deleted. </param>
        public static unsafe void DeleteTextures(TextureHandle[] textures)
        {
            int n = (int)(textures.Length);
            fixed (TextureHandle* textures_ptr = textures)
            {
                DeleteTextures(n, textures_ptr);
            }
        }
        /// <summary> Delete named textures. </summary>
        /// <param name="n"> Specifies the number of textures to be deleted. </param>
        /// <param name="textures"> Specifies an array of textures to be deleted. </param>
        public static unsafe void DeleteTextures(int n, in TextureHandle textures)
        {
            fixed (TextureHandle* textures_ptr = &textures)
            {
                DeleteTextures(n, textures_ptr);
            }
        }
        /// <summary> Enable or disable writing into the depth buffer. </summary>
        /// <param name="flag"> Specifies whether the depth buffer is enabled for writing. If flag is GL_FALSE, depth buffer writing is disabled. Otherwise, it is enabled. Initially, depth buffer writing is enabled. </param>
        public static unsafe void DepthMask(bool flag)
        {
            byte flag_byte = (byte)(flag ? 1 : 0);
            DepthMask(flag_byte);
        }
        /// <summary> Render primitives from array data. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="count"> Specifies the number of elements to be rendered. </param>
        /// <param name="type"> Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT. </param>
        public static unsafe void DrawElements(PrimitiveType mode, int count, DrawElementsType type, nint offset)
        {
            void* indices = (void*)offset;
            DrawElements(mode, count, type, indices);
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
        /// <param name="buffers"> Specifies an array in which the generated buffer object names are stored. </param>
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
        /// <param name="buffers"> Specifies an array in which the generated buffer object names are stored. </param>
        public static unsafe void GenBuffers(Span<BufferHandle> buffers)
        {
            int n = (int)(buffers.Length);
            fixed (BufferHandle* buffers_ptr = buffers)
            {
                GenBuffers(n, buffers_ptr);
            }
        }
        /// <summary> Generate buffer object names. </summary>
        /// <param name="buffers"> Specifies an array in which the generated buffer object names are stored. </param>
        public static unsafe void GenBuffers(BufferHandle[] buffers)
        {
            int n = (int)(buffers.Length);
            fixed (BufferHandle* buffers_ptr = buffers)
            {
                GenBuffers(n, buffers_ptr);
            }
        }
        /// <summary> Generate buffer object names. </summary>
        /// <param name="n"> Specifies the number of buffer object names to be generated. </param>
        /// <param name="buffers"> Specifies an array in which the generated buffer object names are stored. </param>
        public static unsafe void GenBuffers(int n, ref BufferHandle buffers)
        {
            fixed (BufferHandle* buffers_ptr = &buffers)
            {
                GenBuffers(n, buffers_ptr);
            }
        }
        /// <summary> Generate framebuffer object names. </summary>
        public static unsafe FramebufferHandle GenFramebuffer()
        {
            FramebufferHandle framebuffers;
            int n = 1;
            Unsafe.SkipInit(out framebuffers);
            // FIXME: This could be a problem for the overloads that take an out parameter
            // as this parameter could *potentially* move while inside of this function
            // which would mean that the new value never gets written to the out parameter.
            // Making for a nasty bug.
            // The reason we don't use a fixed expression here is because of the "single out parameter to return value" overloading step
            // that will make it so this tries to fix a local variable which is not allowed in C# for some reason.
            // If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk
            // - 2021-05-18
            FramebufferHandle* framebuffers_handle = (FramebufferHandle*)Unsafe.AsPointer(ref framebuffers);
            GenFramebuffers(n, framebuffers_handle);
            return framebuffers;
        }
        /// <summary> Generate framebuffer object names. </summary>
        /// <param name="framebuffers"> Specifies an array in which the generated framebuffer object names are stored. </param>
        public static unsafe void GenFramebuffer(out FramebufferHandle framebuffers)
        {
            int n = 1;
            Unsafe.SkipInit(out framebuffers);
            // FIXME: This could be a problem for the overloads that take an out parameter
            // as this parameter could *potentially* move while inside of this function
            // which would mean that the new value never gets written to the out parameter.
            // Making for a nasty bug.
            // The reason we don't use a fixed expression here is because of the "single out parameter to return value" overloading step
            // that will make it so this tries to fix a local variable which is not allowed in C# for some reason.
            // If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk
            // - 2021-05-18
            FramebufferHandle* framebuffers_handle = (FramebufferHandle*)Unsafe.AsPointer(ref framebuffers);
            GenFramebuffers(n, framebuffers_handle);
        }
        /// <summary> Generate framebuffer object names. </summary>
        /// <param name="framebuffers"> Specifies an array in which the generated framebuffer object names are stored. </param>
        public static unsafe void GenFramebuffers(Span<FramebufferHandle> framebuffers)
        {
            int n = (int)(framebuffers.Length);
            fixed (FramebufferHandle* framebuffers_ptr = framebuffers)
            {
                GenFramebuffers(n, framebuffers_ptr);
            }
        }
        /// <summary> Generate framebuffer object names. </summary>
        /// <param name="framebuffers"> Specifies an array in which the generated framebuffer object names are stored. </param>
        public static unsafe void GenFramebuffers(FramebufferHandle[] framebuffers)
        {
            int n = (int)(framebuffers.Length);
            fixed (FramebufferHandle* framebuffers_ptr = framebuffers)
            {
                GenFramebuffers(n, framebuffers_ptr);
            }
        }
        /// <summary> Generate framebuffer object names. </summary>
        /// <param name="n"> Specifies the number of framebuffer object names to generate. </param>
        /// <param name="framebuffers"> Specifies an array in which the generated framebuffer object names are stored. </param>
        public static unsafe void GenFramebuffers(int n, ref FramebufferHandle framebuffers)
        {
            fixed (FramebufferHandle* framebuffers_ptr = &framebuffers)
            {
                GenFramebuffers(n, framebuffers_ptr);
            }
        }
        /// <summary> Generate renderbuffer object names. </summary>
        public static unsafe RenderbufferHandle GenRenderbuffer()
        {
            RenderbufferHandle renderbuffers;
            int n = 1;
            Unsafe.SkipInit(out renderbuffers);
            // FIXME: This could be a problem for the overloads that take an out parameter
            // as this parameter could *potentially* move while inside of this function
            // which would mean that the new value never gets written to the out parameter.
            // Making for a nasty bug.
            // The reason we don't use a fixed expression here is because of the "single out parameter to return value" overloading step
            // that will make it so this tries to fix a local variable which is not allowed in C# for some reason.
            // If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk
            // - 2021-05-18
            RenderbufferHandle* renderbuffers_handle = (RenderbufferHandle*)Unsafe.AsPointer(ref renderbuffers);
            GenRenderbuffers(n, renderbuffers_handle);
            return renderbuffers;
        }
        /// <summary> Generate renderbuffer object names. </summary>
        /// <param name="renderbuffers"> Specifies an array in which the generated renderbuffer object names are stored. </param>
        public static unsafe void GenRenderbuffer(out RenderbufferHandle renderbuffers)
        {
            int n = 1;
            Unsafe.SkipInit(out renderbuffers);
            // FIXME: This could be a problem for the overloads that take an out parameter
            // as this parameter could *potentially* move while inside of this function
            // which would mean that the new value never gets written to the out parameter.
            // Making for a nasty bug.
            // The reason we don't use a fixed expression here is because of the "single out parameter to return value" overloading step
            // that will make it so this tries to fix a local variable which is not allowed in C# for some reason.
            // If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk
            // - 2021-05-18
            RenderbufferHandle* renderbuffers_handle = (RenderbufferHandle*)Unsafe.AsPointer(ref renderbuffers);
            GenRenderbuffers(n, renderbuffers_handle);
        }
        /// <summary> Generate renderbuffer object names. </summary>
        /// <param name="renderbuffers"> Specifies an array in which the generated renderbuffer object names are stored. </param>
        public static unsafe void GenRenderbuffers(Span<RenderbufferHandle> renderbuffers)
        {
            int n = (int)(renderbuffers.Length);
            fixed (RenderbufferHandle* renderbuffers_ptr = renderbuffers)
            {
                GenRenderbuffers(n, renderbuffers_ptr);
            }
        }
        /// <summary> Generate renderbuffer object names. </summary>
        /// <param name="renderbuffers"> Specifies an array in which the generated renderbuffer object names are stored. </param>
        public static unsafe void GenRenderbuffers(RenderbufferHandle[] renderbuffers)
        {
            int n = (int)(renderbuffers.Length);
            fixed (RenderbufferHandle* renderbuffers_ptr = renderbuffers)
            {
                GenRenderbuffers(n, renderbuffers_ptr);
            }
        }
        /// <summary> Generate renderbuffer object names. </summary>
        /// <param name="n"> Specifies the number of renderbuffer object names to generate. </param>
        /// <param name="renderbuffers"> Specifies an array in which the generated renderbuffer object names are stored. </param>
        public static unsafe void GenRenderbuffers(int n, ref RenderbufferHandle renderbuffers)
        {
            fixed (RenderbufferHandle* renderbuffers_ptr = &renderbuffers)
            {
                GenRenderbuffers(n, renderbuffers_ptr);
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
        /// <param name="textures"> Specifies an array in which the generated texture names are stored. </param>
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
        /// <param name="textures"> Specifies an array in which the generated texture names are stored. </param>
        public static unsafe void GenTextures(Span<TextureHandle> textures)
        {
            int n = (int)(textures.Length);
            fixed (TextureHandle* textures_ptr = textures)
            {
                GenTextures(n, textures_ptr);
            }
        }
        /// <summary> Generate texture names. </summary>
        /// <param name="textures"> Specifies an array in which the generated texture names are stored. </param>
        public static unsafe void GenTextures(TextureHandle[] textures)
        {
            int n = (int)(textures.Length);
            fixed (TextureHandle* textures_ptr = textures)
            {
                GenTextures(n, textures_ptr);
            }
        }
        /// <summary> Generate texture names. </summary>
        /// <param name="n"> Specifies the number of texture names to be generated. </param>
        /// <param name="textures"> Specifies an array in which the generated texture names are stored. </param>
        public static unsafe void GenTextures(int n, ref TextureHandle textures)
        {
            fixed (TextureHandle* textures_ptr = &textures)
            {
                GenTextures(n, textures_ptr);
            }
        }
        /// <summary> Returns information about an active attribute variable for the specified program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="index">Specifies the index of the attribute variable to be queried.</param>
        /// <param name="bufSize">Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.</param>
        /// <param name="length">Returns the number of characters actually written by OpenGL in the string indicated by name (excluding the null terminator) if a value other than NULL is passed.</param>
        /// <param name="size">Returns the size of the attribute variable.</param>
        /// <param name="type">Returns the data type of the attribute variable.</param>
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
        /// <summary> Returns information about an active attribute variable for the specified program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="index">Specifies the index of the attribute variable to be queried.</param>
        /// <param name="bufSize">Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.</param>
        /// <param name="length">Returns the number of characters actually written by OpenGL in the string indicated by name (excluding the null terminator) if a value other than NULL is passed.</param>
        /// <param name="size">Returns the size of the attribute variable.</param>
        /// <param name="type">Returns the data type of the attribute variable.</param>
        /// <param name="name">Returns a null terminated string containing the name of the attribute variable.</param>
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
        /// <summary> Returns information about an active attribute variable for the specified program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="index">Specifies the index of the attribute variable to be queried.</param>
        /// <param name="bufSize">Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.</param>
        /// <param name="length">Returns the number of characters actually written by OpenGL in the string indicated by name (excluding the null terminator) if a value other than NULL is passed.</param>
        /// <param name="size">Returns the size of the attribute variable.</param>
        /// <param name="type">Returns the data type of the attribute variable.</param>
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
        /// <summary> Returns information about an active attribute variable for the specified program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="index">Specifies the index of the attribute variable to be queried.</param>
        /// <param name="bufSize">Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.</param>
        /// <param name="length">Returns the number of characters actually written by OpenGL in the string indicated by name (excluding the null terminator) if a value other than NULL is passed.</param>
        /// <param name="size">Returns the size of the attribute variable.</param>
        /// <param name="type">Returns the data type of the attribute variable.</param>
        /// <param name="name">Returns a null terminated string containing the name of the attribute variable.</param>
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
        /// <summary> Returns information about an active attribute variable for the specified program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="index">Specifies the index of the attribute variable to be queried.</param>
        /// <param name="bufSize">Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.</param>
        /// <param name="length">Returns the number of characters actually written by OpenGL in the string indicated by name (excluding the null terminator) if a value other than NULL is passed.</param>
        /// <param name="size">Returns the size of the attribute variable.</param>
        /// <param name="type">Returns the data type of the attribute variable.</param>
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
        /// <summary> Returns information about an active attribute variable for the specified program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="index">Specifies the index of the attribute variable to be queried.</param>
        /// <param name="bufSize">Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.</param>
        /// <param name="length">Returns the number of characters actually written by OpenGL in the string indicated by name (excluding the null terminator) if a value other than NULL is passed.</param>
        /// <param name="size">Returns the size of the attribute variable.</param>
        /// <param name="type">Returns the data type of the attribute variable.</param>
        /// <param name="name">Returns a null terminated string containing the name of the attribute variable.</param>
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
        /// <summary> Returns information about an active uniform variable for the specified program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="index">Specifies the index of the uniform variable to be queried.</param>
        /// <param name="bufSize">Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.</param>
        /// <param name="length">Returns the number of characters actually written by OpenGL in the string indicated by name (excluding the null terminator) if a value other than NULL is passed.</param>
        /// <param name="size">Returns the size of the uniform variable.</param>
        /// <param name="type">Returns the data type of the uniform variable.</param>
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
        /// <summary> Returns information about an active uniform variable for the specified program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="index">Specifies the index of the uniform variable to be queried.</param>
        /// <param name="bufSize">Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.</param>
        /// <param name="length">Returns the number of characters actually written by OpenGL in the string indicated by name (excluding the null terminator) if a value other than NULL is passed.</param>
        /// <param name="size">Returns the size of the uniform variable.</param>
        /// <param name="type">Returns the data type of the uniform variable.</param>
        /// <param name="name">Returns a null terminated string containing the name of the uniform variable.</param>
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
        /// <summary> Returns information about an active uniform variable for the specified program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="index">Specifies the index of the uniform variable to be queried.</param>
        /// <param name="bufSize">Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.</param>
        /// <param name="length">Returns the number of characters actually written by OpenGL in the string indicated by name (excluding the null terminator) if a value other than NULL is passed.</param>
        /// <param name="size">Returns the size of the uniform variable.</param>
        /// <param name="type">Returns the data type of the uniform variable.</param>
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
        /// <summary> Returns information about an active uniform variable for the specified program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="index">Specifies the index of the uniform variable to be queried.</param>
        /// <param name="bufSize">Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.</param>
        /// <param name="length">Returns the number of characters actually written by OpenGL in the string indicated by name (excluding the null terminator) if a value other than NULL is passed.</param>
        /// <param name="size">Returns the size of the uniform variable.</param>
        /// <param name="type">Returns the data type of the uniform variable.</param>
        /// <param name="name">Returns a null terminated string containing the name of the uniform variable.</param>
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
        /// <summary> Returns information about an active uniform variable for the specified program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="index">Specifies the index of the uniform variable to be queried.</param>
        /// <param name="bufSize">Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.</param>
        /// <param name="length">Returns the number of characters actually written by OpenGL in the string indicated by name (excluding the null terminator) if a value other than NULL is passed.</param>
        /// <param name="size">Returns the size of the uniform variable.</param>
        /// <param name="type">Returns the data type of the uniform variable.</param>
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
        /// <summary> Returns information about an active uniform variable for the specified program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="index">Specifies the index of the uniform variable to be queried.</param>
        /// <param name="bufSize">Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.</param>
        /// <param name="length">Returns the number of characters actually written by OpenGL in the string indicated by name (excluding the null terminator) if a value other than NULL is passed.</param>
        /// <param name="size">Returns the size of the uniform variable.</param>
        /// <param name="type">Returns the data type of the uniform variable.</param>
        /// <param name="name">Returns a null terminated string containing the name of the uniform variable.</param>
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
        /// <summary> Returns the handles of the shader objects attached to a program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="count">Returns the number of names actually returned in shaders.</param>
        /// <param name="shaders">Specifies an array that is used to return the names of attached shader objects.</param>
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
        /// <summary> Returns the handles of the shader objects attached to a program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="count">Returns the number of names actually returned in shaders.</param>
        /// <param name="shaders">Specifies an array that is used to return the names of attached shader objects.</param>
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
        /// <summary> Returns the handles of the shader objects attached to a program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="maxCount">Specifies the size of the array for storing the returned object names.</param>
        /// <param name="count">Returns the number of names actually returned in shaders.</param>
        /// <param name="shaders">Specifies an array that is used to return the names of attached shader objects.</param>
        public static unsafe void GetAttachedShaders(ProgramHandle program, int maxCount, ref int count, ref ShaderHandle shaders)
        {
            fixed (int* count_ptr = &count)
            fixed (ShaderHandle* shaders_ptr = &shaders)
            {
                GetAttachedShaders(program, maxCount, count_ptr, shaders_ptr);
            }
        }
        /// <summary> Returns the location of an attribute variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="name">Points to a null terminated string containing the name of the attribute variable whose location is to be queried.</param>
        public static unsafe int GetAttribLocation(ProgramHandle program, string name)
        {
            int returnValue;
            byte* name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(name);
            returnValue = GetAttribLocation(program, name_ptr);
            Marshal.FreeCoTaskMem((IntPtr)name_ptr);
            return returnValue;
        }
        /// <summary> Return the value or values of a selected parameter. </summary>
        /// <param name="pname"> Specifies the parameter value to be returned. The symbolic constants in the list below are accepted. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        public static unsafe void GetBoolean(GetPName pname, Span<byte> data)
        {
            fixed (byte* data_ptr = data)
            {
                GetBooleanv(pname, data_ptr);
            }
        }
        /// <summary> Return the value or values of a selected parameter. </summary>
        /// <param name="pname"> Specifies the parameter value to be returned. The symbolic constants in the list below are accepted. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        public static unsafe void GetBoolean(GetPName pname, byte[] data)
        {
            fixed (byte* data_ptr = data)
            {
                GetBooleanv(pname, data_ptr);
            }
        }
        /// <summary> Return the value or values of a selected parameter. </summary>
        /// <param name="pname"> Specifies the parameter value to be returned. The symbolic constants in the list below are accepted. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        public static unsafe void GetBoolean(GetPName pname, ref byte data)
        {
            fixed (byte* data_ptr = &data)
            {
                GetBooleanv(pname, data_ptr);
            }
        }
        /// <summary> Return parameters of a buffer object. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glGetBufferParameteriv and glGetBufferParameteri64v. Must be one of the buffer binding targets in the following table: </param>
        public static unsafe void GetBufferParameteri(BufferTargetARB target, BufferPNameARB pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetBufferParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Return parameters of a buffer object. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glGetBufferParameteriv and glGetBufferParameteri64v. Must be one of the buffer binding targets in the following table: </param>
        public static unsafe void GetBufferParameteri(BufferTargetARB target, BufferPNameARB pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetBufferParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Return parameters of a buffer object. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glGetBufferParameteriv and glGetBufferParameteri64v. Must be one of the buffer binding targets in the following table: </param>
        public static unsafe void GetBufferParameteri(BufferTargetARB target, BufferPNameARB pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetBufferParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Return the value or values of a selected parameter. </summary>
        /// <param name="pname"> Specifies the parameter value to be returned. The symbolic constants in the list below are accepted. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        public static unsafe void GetFloat(GetPName pname, Span<float> data)
        {
            fixed (float* data_ptr = data)
            {
                GetFloatv(pname, data_ptr);
            }
        }
        /// <summary> Return the value or values of a selected parameter. </summary>
        /// <param name="pname"> Specifies the parameter value to be returned. The symbolic constants in the list below are accepted. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        public static unsafe void GetFloat(GetPName pname, float[] data)
        {
            fixed (float* data_ptr = data)
            {
                GetFloatv(pname, data_ptr);
            }
        }
        /// <summary> Return the value or values of a selected parameter. </summary>
        /// <param name="pname"> Specifies the parameter value to be returned. The symbolic constants in the list below are accepted. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        public static unsafe void GetFloat(GetPName pname, ref float data)
        {
            fixed (float* data_ptr = &data)
            {
                GetFloatv(pname, data_ptr);
            }
        }
        /// <summary> Retrieve information about attachments of a bound framebuffer object. </summary>
        /// <param name="target"> Specifies the target of the query operation. </param>
        /// <param name="attachment"> Specifies the attachment within target </param>
        /// <param name="pname"> Specifies the parameter of attachment to query. </param>
        public static unsafe void GetFramebufferAttachmentParameteri(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetFramebufferAttachmentParameteriv(target, attachment, pname, parameters_ptr);
            }
        }
        /// <summary> Retrieve information about attachments of a bound framebuffer object. </summary>
        /// <param name="target"> Specifies the target of the query operation. </param>
        /// <param name="attachment"> Specifies the attachment within target </param>
        /// <param name="pname"> Specifies the parameter of attachment to query. </param>
        public static unsafe void GetFramebufferAttachmentParameteri(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetFramebufferAttachmentParameteriv(target, attachment, pname, parameters_ptr);
            }
        }
        /// <summary> Retrieve information about attachments of a bound framebuffer object. </summary>
        /// <param name="target"> Specifies the target of the query operation. </param>
        /// <param name="attachment"> Specifies the attachment within target </param>
        /// <param name="pname"> Specifies the parameter of attachment to query. </param>
        public static unsafe void GetFramebufferAttachmentParameteri(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetFramebufferAttachmentParameteriv(target, attachment, pname, parameters_ptr);
            }
        }
        /// <summary> Return the value or values of a selected parameter. </summary>
        /// <param name="pname"> Specifies the parameter value to be returned. The symbolic constants in the list below are accepted. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        public static unsafe void GetInteger(GetPName pname, Span<int> data)
        {
            fixed (int* data_ptr = data)
            {
                GetIntegerv(pname, data_ptr);
            }
        }
        /// <summary> Return the value or values of a selected parameter. </summary>
        /// <param name="pname"> Specifies the parameter value to be returned. The symbolic constants in the list below are accepted. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        public static unsafe void GetInteger(GetPName pname, int[] data)
        {
            fixed (int* data_ptr = data)
            {
                GetIntegerv(pname, data_ptr);
            }
        }
        /// <summary> Return the value or values of a selected parameter. </summary>
        /// <param name="pname"> Specifies the parameter value to be returned. The symbolic constants in the list below are accepted. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        public static unsafe void GetInteger(GetPName pname, ref int data)
        {
            fixed (int* data_ptr = &data)
            {
                GetIntegerv(pname, data_ptr);
            }
        }
        /// <summary> Returns a parameter from a program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="pname">Specifies the object parameter. Accepted symbolic names are GL_ACTIVE_ATOMIC_COUNTER_BUFFERS, GL_ACTIVE_ATTRIBUTES, GL_ACTIVE_ATTRIBUTE_MAX_LENGTH, GL_ACTIVE_UNIFORMS, GL_ACTIVE_UNIFORM_BLOCKS, GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH, GL_ACTIVE_UNIFORM_MAX_LENGTH, GL_ATTACHED_SHADERS, GL_COMPUTE_WORK_GROUP_SIZE, GL_DELETE_STATUS, GL_GEOMETRY_LINKED_INPUT_TYPE, GL_GEOMETRY_LINKED_OUTPUT_TYPE, GL_GEOMETRY_LINKED_VERTICES_OUT, GL_GEOMETRY_SHADER_INVOCATIONS, GL_INFO_LOG_LENGTH, GL_LINK_STATUS, GL_PROGRAM_BINARY_RETRIEVABLE_HINT, GL_PROGRAM_SEPARABLE, GL_TESS_CONTROL_OUTPUT_VERTICES, GL_TESS_GEN_MODE, GL_TESS_GEN_POINT_MODE, GL_TESS_GEN_SPACING, GL_TESS_GEN_VERTEX_ORDER, GL_TRANSFORM_FEEDBACK_BUFFER_MODE, GL_TRANSFORM_FEEDBACK_VARYINGS, GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH and GL_VALIDATE_STATUS.</param>
        public static unsafe void GetProgrami(ProgramHandle program, ProgramPropertyARB pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetProgramiv(program, pname, parameters_ptr);
            }
        }
        /// <summary> Returns a parameter from a program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="pname">Specifies the object parameter. Accepted symbolic names are GL_ACTIVE_ATOMIC_COUNTER_BUFFERS, GL_ACTIVE_ATTRIBUTES, GL_ACTIVE_ATTRIBUTE_MAX_LENGTH, GL_ACTIVE_UNIFORMS, GL_ACTIVE_UNIFORM_BLOCKS, GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH, GL_ACTIVE_UNIFORM_MAX_LENGTH, GL_ATTACHED_SHADERS, GL_COMPUTE_WORK_GROUP_SIZE, GL_DELETE_STATUS, GL_GEOMETRY_LINKED_INPUT_TYPE, GL_GEOMETRY_LINKED_OUTPUT_TYPE, GL_GEOMETRY_LINKED_VERTICES_OUT, GL_GEOMETRY_SHADER_INVOCATIONS, GL_INFO_LOG_LENGTH, GL_LINK_STATUS, GL_PROGRAM_BINARY_RETRIEVABLE_HINT, GL_PROGRAM_SEPARABLE, GL_TESS_CONTROL_OUTPUT_VERTICES, GL_TESS_GEN_MODE, GL_TESS_GEN_POINT_MODE, GL_TESS_GEN_SPACING, GL_TESS_GEN_VERTEX_ORDER, GL_TRANSFORM_FEEDBACK_BUFFER_MODE, GL_TRANSFORM_FEEDBACK_VARYINGS, GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH and GL_VALIDATE_STATUS.</param>
        public static unsafe void GetProgrami(ProgramHandle program, ProgramPropertyARB pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetProgramiv(program, pname, parameters_ptr);
            }
        }
        /// <summary> Returns a parameter from a program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="pname">Specifies the object parameter. Accepted symbolic names are GL_ACTIVE_ATOMIC_COUNTER_BUFFERS, GL_ACTIVE_ATTRIBUTES, GL_ACTIVE_ATTRIBUTE_MAX_LENGTH, GL_ACTIVE_UNIFORMS, GL_ACTIVE_UNIFORM_BLOCKS, GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH, GL_ACTIVE_UNIFORM_MAX_LENGTH, GL_ATTACHED_SHADERS, GL_COMPUTE_WORK_GROUP_SIZE, GL_DELETE_STATUS, GL_GEOMETRY_LINKED_INPUT_TYPE, GL_GEOMETRY_LINKED_OUTPUT_TYPE, GL_GEOMETRY_LINKED_VERTICES_OUT, GL_GEOMETRY_SHADER_INVOCATIONS, GL_INFO_LOG_LENGTH, GL_LINK_STATUS, GL_PROGRAM_BINARY_RETRIEVABLE_HINT, GL_PROGRAM_SEPARABLE, GL_TESS_CONTROL_OUTPUT_VERTICES, GL_TESS_GEN_MODE, GL_TESS_GEN_POINT_MODE, GL_TESS_GEN_SPACING, GL_TESS_GEN_VERTEX_ORDER, GL_TRANSFORM_FEEDBACK_BUFFER_MODE, GL_TRANSFORM_FEEDBACK_VARYINGS, GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH and GL_VALIDATE_STATUS.</param>
        public static unsafe void GetProgrami(ProgramHandle program, ProgramPropertyARB pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetProgramiv(program, pname, parameters_ptr);
            }
        }
        /// <summary> Returns the information log for a program object. </summary>
        /// <param name="program">Specifies the program object whose information log is to be queried.</param>
        /// <param name="length">Returns the length of the string returned in infoLog (excluding the null terminator).</param>
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
        /// <summary> Returns the information log for a program object. </summary>
        /// <param name="program">Specifies the program object whose information log is to be queried.</param>
        /// <param name="length">Returns the length of the string returned in infoLog (excluding the null terminator).</param>
        /// <param name="infoLog">Specifies an array of characters that is used to return the information log.</param>
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
        /// <summary> Returns the information log for a program object. </summary>
        /// <param name="program">Specifies the program object whose information log is to be queried.</param>
        /// <param name="length">Returns the length of the string returned in infoLog (excluding the null terminator).</param>
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
        /// <summary> Returns the information log for a program object. </summary>
        /// <param name="program">Specifies the program object whose information log is to be queried.</param>
        /// <param name="length">Returns the length of the string returned in infoLog (excluding the null terminator).</param>
        /// <param name="infoLog">Specifies an array of characters that is used to return the information log.</param>
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
        /// <summary> Returns the information log for a program object. </summary>
        /// <param name="program">Specifies the program object whose information log is to be queried.</param>
        /// <param name="length">Returns the length of the string returned in infoLog (excluding the null terminator).</param>
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
        /// <summary> Returns the information log for a program object. </summary>
        /// <param name="program">Specifies the program object whose information log is to be queried.</param>
        /// <param name="length">Returns the length of the string returned in infoLog (excluding the null terminator).</param>
        /// <param name="infoLog">Specifies an array of characters that is used to return the information log.</param>
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
        /// <summary> Retrieve information about a bound renderbuffer object. </summary>
        /// <param name="target"> Specifies the target of the query operation. target must be GL_RENDERBUFFER. </param>
        /// <param name="pname"> Specifies the parameter whose value to retrieve from the renderbuffer bound to target. </param>
        public static unsafe void GetRenderbufferParameteri(RenderbufferTarget target, RenderbufferParameterName pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetRenderbufferParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Retrieve information about a bound renderbuffer object. </summary>
        /// <param name="target"> Specifies the target of the query operation. target must be GL_RENDERBUFFER. </param>
        /// <param name="pname"> Specifies the parameter whose value to retrieve from the renderbuffer bound to target. </param>
        public static unsafe void GetRenderbufferParameteri(RenderbufferTarget target, RenderbufferParameterName pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetRenderbufferParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Retrieve information about a bound renderbuffer object. </summary>
        /// <param name="target"> Specifies the target of the query operation. target must be GL_RENDERBUFFER. </param>
        /// <param name="pname"> Specifies the parameter whose value to retrieve from the renderbuffer bound to target. </param>
        public static unsafe void GetRenderbufferParameteri(RenderbufferTarget target, RenderbufferParameterName pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetRenderbufferParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Returns a parameter from a shader object. </summary>
        /// <param name="shader">Specifies the shader object to be queried.</param>
        /// <param name="pname">Specifies the object parameter. Accepted symbolic names are GL_SHADER_TYPE, GL_DELETE_STATUS, GL_COMPILE_STATUS, GL_INFO_LOG_LENGTH, GL_SHADER_SOURCE_LENGTH.</param>
        public static unsafe void GetShaderi(ShaderHandle shader, ShaderParameterName pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetShaderiv(shader, pname, parameters_ptr);
            }
        }
        /// <summary> Returns a parameter from a shader object. </summary>
        /// <param name="shader">Specifies the shader object to be queried.</param>
        /// <param name="pname">Specifies the object parameter. Accepted symbolic names are GL_SHADER_TYPE, GL_DELETE_STATUS, GL_COMPILE_STATUS, GL_INFO_LOG_LENGTH, GL_SHADER_SOURCE_LENGTH.</param>
        public static unsafe void GetShaderi(ShaderHandle shader, ShaderParameterName pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetShaderiv(shader, pname, parameters_ptr);
            }
        }
        /// <summary> Returns a parameter from a shader object. </summary>
        /// <param name="shader">Specifies the shader object to be queried.</param>
        /// <param name="pname">Specifies the object parameter. Accepted symbolic names are GL_SHADER_TYPE, GL_DELETE_STATUS, GL_COMPILE_STATUS, GL_INFO_LOG_LENGTH, GL_SHADER_SOURCE_LENGTH.</param>
        public static unsafe void GetShaderi(ShaderHandle shader, ShaderParameterName pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetShaderiv(shader, pname, parameters_ptr);
            }
        }
        /// <summary> Returns the information log for a shader object. </summary>
        /// <param name="shader">Specifies the shader object whose information log is to be queried.</param>
        /// <param name="length">Returns the length of the string returned in infoLog (excluding the null terminator).</param>
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
        /// <summary> Returns the information log for a shader object. </summary>
        /// <param name="shader">Specifies the shader object whose information log is to be queried.</param>
        /// <param name="length">Returns the length of the string returned in infoLog (excluding the null terminator).</param>
        /// <param name="infoLog">Specifies an array of characters that is used to return the information log.</param>
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
        /// <summary> Returns the information log for a shader object. </summary>
        /// <param name="shader">Specifies the shader object whose information log is to be queried.</param>
        /// <param name="length">Returns the length of the string returned in infoLog (excluding the null terminator).</param>
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
        /// <summary> Returns the information log for a shader object. </summary>
        /// <param name="shader">Specifies the shader object whose information log is to be queried.</param>
        /// <param name="length">Returns the length of the string returned in infoLog (excluding the null terminator).</param>
        /// <param name="infoLog">Specifies an array of characters that is used to return the information log.</param>
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
        /// <summary> Returns the information log for a shader object. </summary>
        /// <param name="shader">Specifies the shader object whose information log is to be queried.</param>
        /// <param name="length">Returns the length of the string returned in infoLog (excluding the null terminator).</param>
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
        /// <summary> Returns the information log for a shader object. </summary>
        /// <param name="shader">Specifies the shader object whose information log is to be queried.</param>
        /// <param name="length">Returns the length of the string returned in infoLog (excluding the null terminator).</param>
        /// <param name="infoLog">Specifies an array of characters that is used to return the information log.</param>
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
        /// <summary> Retrieve the range and precision for numeric formats supported by the shader compiler. </summary>
        /// <param name="range"> Specifies the address of array of two integers into which encodings of the implementation's numeric range are returned. </param>
        /// <param name="precision"> Specifies the address of an integer into which the numeric precision of the implementation is written. </param>
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
        /// <summary> Retrieve the range and precision for numeric formats supported by the shader compiler. </summary>
        /// <param name="range"> Specifies the address of array of two integers into which encodings of the implementation's numeric range are returned. </param>
        /// <param name="precision"> Specifies the address of an integer into which the numeric precision of the implementation is written. </param>
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
        /// <summary> Retrieve the range and precision for numeric formats supported by the shader compiler. </summary>
        /// <param name="range"> Specifies the address of array of two integers into which encodings of the implementation's numeric range are returned. </param>
        /// <param name="precision"> Specifies the address of an integer into which the numeric precision of the implementation is written. </param>
        public static unsafe void GetShaderPrecisionFormat(ShaderType shadertype, PrecisionType precisiontype, ref int range, ref int precision)
        {
            fixed (int* range_ptr = &range)
            fixed (int* precision_ptr = &precision)
            {
                GetShaderPrecisionFormat(shadertype, precisiontype, range_ptr, precision_ptr);
            }
        }
        /// <summary> Returns the source code string from a shader object. </summary>
        /// <param name="shader">Specifies the shader object to be queried.</param>
        /// <param name="bufSize">Specifies the size of the character buffer for storing the returned source code string.</param>
        /// <param name="length">Returns the length of the string returned in source (excluding the null terminator).</param>
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
        /// <summary> Returns the source code string from a shader object. </summary>
        /// <param name="shader">Specifies the shader object to be queried.</param>
        /// <param name="bufSize">Specifies the size of the character buffer for storing the returned source code string.</param>
        /// <param name="length">Returns the length of the string returned in source (excluding the null terminator).</param>
        /// <param name="source">Specifies an array of characters that is used to return the source code string.</param>
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
        /// <summary> Returns the source code string from a shader object. </summary>
        /// <param name="shader">Specifies the shader object to be queried.</param>
        /// <param name="bufSize">Specifies the size of the character buffer for storing the returned source code string.</param>
        /// <param name="length">Returns the length of the string returned in source (excluding the null terminator).</param>
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
        /// <summary> Returns the source code string from a shader object. </summary>
        /// <param name="shader">Specifies the shader object to be queried.</param>
        /// <param name="bufSize">Specifies the size of the character buffer for storing the returned source code string.</param>
        /// <param name="length">Returns the length of the string returned in source (excluding the null terminator).</param>
        /// <param name="source">Specifies an array of characters that is used to return the source code string.</param>
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
        /// <summary> Returns the source code string from a shader object. </summary>
        /// <param name="shader">Specifies the shader object to be queried.</param>
        /// <param name="bufSize">Specifies the size of the character buffer for storing the returned source code string.</param>
        /// <param name="length">Returns the length of the string returned in source (excluding the null terminator).</param>
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
        /// <summary> Returns the source code string from a shader object. </summary>
        /// <param name="shader">Specifies the shader object to be queried.</param>
        /// <param name="bufSize">Specifies the size of the character buffer for storing the returned source code string.</param>
        /// <param name="length">Returns the length of the string returned in source (excluding the null terminator).</param>
        /// <param name="source">Specifies an array of characters that is used to return the source code string.</param>
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
        /// <summary> Return a string describing the current GL connection. </summary>
        /// <param name="name"> Specifies a symbolic constant, one of GL_EXTENSIONS, GL_RENDERER, GL_SHADING_LANGUAGE_VERSION, GL_VENDOR, or GL_VERSION. glGetStringi accepts only the GL_EXTENSIONS token. </param>
        public static unsafe string? GetString(StringName name)
        {
            byte* returnValue;
            string? returnValue_str;
            returnValue = GetString_(name);
            returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
            return returnValue_str;
        }
        /// <summary> Return texture parameter values. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture. GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE,GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        public static unsafe void GetTexParameterf(TextureTarget target, GetTextureParameter pname, Span<float> parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetTexParameterfv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Return texture parameter values. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture. GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE,GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        public static unsafe void GetTexParameterf(TextureTarget target, GetTextureParameter pname, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetTexParameterfv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Return texture parameter values. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture. GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE,GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        public static unsafe void GetTexParameterf(TextureTarget target, GetTextureParameter pname, ref float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                GetTexParameterfv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Return texture parameter values. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture. GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE,GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        public static unsafe void GetTexParameteri(TextureTarget target, GetTextureParameter pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetTexParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Return texture parameter values. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture. GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE,GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        public static unsafe void GetTexParameteri(TextureTarget target, GetTextureParameter pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetTexParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Return texture parameter values. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture. GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE,GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        public static unsafe void GetTexParameteri(TextureTarget target, GetTextureParameter pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetTexParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        public static unsafe void GetUniformf(ProgramHandle program, int location, Span<float> parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetUniformfv(program, location, parameters_ptr);
            }
        }
        /// <summary> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        public static unsafe void GetUniformf(ProgramHandle program, int location, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetUniformfv(program, location, parameters_ptr);
            }
        }
        /// <summary> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        public static unsafe void GetUniformf(ProgramHandle program, int location, ref float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                GetUniformfv(program, location, parameters_ptr);
            }
        }
        /// <summary> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        public static unsafe void GetUniformi(ProgramHandle program, int location, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetUniformiv(program, location, parameters_ptr);
            }
        }
        /// <summary> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        public static unsafe void GetUniformi(ProgramHandle program, int location, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetUniformiv(program, location, parameters_ptr);
            }
        }
        /// <summary> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        public static unsafe void GetUniformi(ProgramHandle program, int location, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetUniformiv(program, location, parameters_ptr);
            }
        }
        /// <summary> Returns the location of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="name">Points to a null terminated string containing the name of the uniform variable whose location is to be queried.</param>
        public static unsafe int GetUniformLocation(ProgramHandle program, string name)
        {
            int returnValue;
            byte* name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(name);
            returnValue = GetUniformLocation(program, name_ptr);
            Marshal.FreeCoTaskMem((IntPtr)name_ptr);
            return returnValue;
        }
        /// <summary> Return a generic vertex attribute parameter. </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be queried.</param>
        /// <param name="pname">Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are GL_CURRENT_VERTEX_ATTRIB, GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, GL_VERTEX_ATTRIB_ARRAY_ENABLED, GL_VERTEX_ATTRIB_ARRAY_SIZE, GL_VERTEX_ATTRIB_ARRAY_STRIDE, GL_VERTEX_ATTRIB_ARRAY_TYPE, GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, GL_VERTEX_ATTRIB_ARRAY_INTEGER, GL_VERTEX_ATTRIB_ARRAY_DIVISOR, or GL_VERTEX_ATTRIB_BINDING.</param>
        public static unsafe void GetVertexAttribf(uint index, VertexAttribPropertyARB pname, Span<float> parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetVertexAttribfv(index, pname, parameters_ptr);
            }
        }
        /// <summary> Return a generic vertex attribute parameter. </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be queried.</param>
        /// <param name="pname">Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are GL_CURRENT_VERTEX_ATTRIB, GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, GL_VERTEX_ATTRIB_ARRAY_ENABLED, GL_VERTEX_ATTRIB_ARRAY_SIZE, GL_VERTEX_ATTRIB_ARRAY_STRIDE, GL_VERTEX_ATTRIB_ARRAY_TYPE, GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, GL_VERTEX_ATTRIB_ARRAY_INTEGER, GL_VERTEX_ATTRIB_ARRAY_DIVISOR, or GL_VERTEX_ATTRIB_BINDING.</param>
        public static unsafe void GetVertexAttribf(uint index, VertexAttribPropertyARB pname, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetVertexAttribfv(index, pname, parameters_ptr);
            }
        }
        /// <summary> Return a generic vertex attribute parameter. </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be queried.</param>
        /// <param name="pname">Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are GL_CURRENT_VERTEX_ATTRIB, GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, GL_VERTEX_ATTRIB_ARRAY_ENABLED, GL_VERTEX_ATTRIB_ARRAY_SIZE, GL_VERTEX_ATTRIB_ARRAY_STRIDE, GL_VERTEX_ATTRIB_ARRAY_TYPE, GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, GL_VERTEX_ATTRIB_ARRAY_INTEGER, GL_VERTEX_ATTRIB_ARRAY_DIVISOR, or GL_VERTEX_ATTRIB_BINDING.</param>
        public static unsafe void GetVertexAttribf(uint index, VertexAttribPropertyARB pname, ref float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                GetVertexAttribfv(index, pname, parameters_ptr);
            }
        }
        /// <summary> Return a generic vertex attribute parameter. </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be queried.</param>
        /// <param name="pname">Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are GL_CURRENT_VERTEX_ATTRIB, GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, GL_VERTEX_ATTRIB_ARRAY_ENABLED, GL_VERTEX_ATTRIB_ARRAY_SIZE, GL_VERTEX_ATTRIB_ARRAY_STRIDE, GL_VERTEX_ATTRIB_ARRAY_TYPE, GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, GL_VERTEX_ATTRIB_ARRAY_INTEGER, GL_VERTEX_ATTRIB_ARRAY_DIVISOR, or GL_VERTEX_ATTRIB_BINDING.</param>
        public static unsafe void GetVertexAttribi(uint index, VertexAttribPropertyARB pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetVertexAttribiv(index, pname, parameters_ptr);
            }
        }
        /// <summary> Return a generic vertex attribute parameter. </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be queried.</param>
        /// <param name="pname">Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are GL_CURRENT_VERTEX_ATTRIB, GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, GL_VERTEX_ATTRIB_ARRAY_ENABLED, GL_VERTEX_ATTRIB_ARRAY_SIZE, GL_VERTEX_ATTRIB_ARRAY_STRIDE, GL_VERTEX_ATTRIB_ARRAY_TYPE, GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, GL_VERTEX_ATTRIB_ARRAY_INTEGER, GL_VERTEX_ATTRIB_ARRAY_DIVISOR, or GL_VERTEX_ATTRIB_BINDING.</param>
        public static unsafe void GetVertexAttribi(uint index, VertexAttribPropertyARB pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetVertexAttribiv(index, pname, parameters_ptr);
            }
        }
        /// <summary> Return a generic vertex attribute parameter. </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be queried.</param>
        /// <param name="pname">Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are GL_CURRENT_VERTEX_ATTRIB, GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, GL_VERTEX_ATTRIB_ARRAY_ENABLED, GL_VERTEX_ATTRIB_ARRAY_SIZE, GL_VERTEX_ATTRIB_ARRAY_STRIDE, GL_VERTEX_ATTRIB_ARRAY_TYPE, GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, GL_VERTEX_ATTRIB_ARRAY_INTEGER, GL_VERTEX_ATTRIB_ARRAY_DIVISOR, or GL_VERTEX_ATTRIB_BINDING.</param>
        public static unsafe void GetVertexAttribi(uint index, VertexAttribPropertyARB pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetVertexAttribiv(index, pname, parameters_ptr);
            }
        }
        /// <summary> Return the address of the specified generic vertex attribute pointer. </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be returned.</param>
        /// <param name="pname">Specifies the symbolic name of the generic vertex attribute parameter to be returned. Must be GL_VERTEX_ATTRIB_ARRAY_POINTER.</param>
        /// <param name="pointer">Returns the pointer value.</param>
        public static unsafe void GetVertexAttribPointer(uint index, VertexAttribPointerPropertyARB pname, void** pointer)
        {
            GetVertexAttribPointerv(index, pname, pointer);
        }
        /// <summary> Read a block of pixels from the frame buffer. </summary>
        /// <param name="x"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
        /// <param name="y"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
        /// <param name="width"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
        /// <param name="height"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
        /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RGBA, and GL_RGBA_INTEGER. An implementation-chosen format will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_FORMAT. </param>
        /// <param name="type"> Specifies the data type of the pixel data. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_INT, GL_UNSIGNED_INT_2_10_10_10_REV, GL_INT, or GL_FLOAT. An implementation-chosen type will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_TYPE. </param>
        public static unsafe void ReadPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, IntPtr pixels)
        {
            void* pixels_vptr = (void*)pixels;
            ReadPixels(x, y, width, height, format, type, pixels_vptr);
        }
        /// <summary> Read a block of pixels from the frame buffer. </summary>
        /// <param name="x"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
        /// <param name="y"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
        /// <param name="width"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
        /// <param name="height"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
        /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RGBA, and GL_RGBA_INTEGER. An implementation-chosen format will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_FORMAT. </param>
        /// <param name="type"> Specifies the data type of the pixel data. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_INT, GL_UNSIGNED_INT_2_10_10_10_REV, GL_INT, or GL_FLOAT. An implementation-chosen type will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_TYPE. </param>
        public static unsafe void ReadPixels<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, Span<T1> pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels)
            {
                ReadPixels(x, y, width, height, format, type, pixels_ptr);
            }
        }
        /// <summary> Read a block of pixels from the frame buffer. </summary>
        /// <param name="x"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
        /// <param name="y"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
        /// <param name="width"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
        /// <param name="height"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
        /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RGBA, and GL_RGBA_INTEGER. An implementation-chosen format will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_FORMAT. </param>
        /// <param name="type"> Specifies the data type of the pixel data. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_INT, GL_UNSIGNED_INT_2_10_10_10_REV, GL_INT, or GL_FLOAT. An implementation-chosen type will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_TYPE. </param>
        public static unsafe void ReadPixels<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, T1[] pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels)
            {
                ReadPixels(x, y, width, height, format, type, pixels_ptr);
            }
        }
        /// <summary> Read a block of pixels from the frame buffer. </summary>
        /// <param name="x"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
        /// <param name="y"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
        /// <param name="width"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
        /// <param name="height"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
        /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RGBA, and GL_RGBA_INTEGER. An implementation-chosen format will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_FORMAT. </param>
        /// <param name="type"> Specifies the data type of the pixel data. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_INT, GL_UNSIGNED_INT_2_10_10_10_REV, GL_INT, or GL_FLOAT. An implementation-chosen type will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_TYPE. </param>
        public static unsafe void ReadPixels<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, ref T1 pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = &pixels)
            {
                ReadPixels(x, y, width, height, format, type, pixels_ptr);
            }
        }
        /// <summary> Specify multisample coverage parameters. </summary>
        /// <param name="value"> Specify a single floating-point sample coverage value. The value is clamped to the range 0 1 . The initial value is 1.0. </param>
        /// <param name="invert"> Specify a single boolean value representing if the coverage masks should be inverted. GL_TRUE and GL_FALSE are accepted. The initial value is GL_FALSE. </param>
        public static unsafe void SampleCoverage(float value, bool invert)
        {
            byte invert_byte = (byte)(invert ? 1 : 0);
            SampleCoverage(value, invert_byte);
        }
        /// <summary> Load pre-compiled shader binaries. </summary>
        /// <param name="shaders"> Specifies the address of an array of shader handles into which to load pre-compiled shader binaries. </param>
        /// <param name="binaryFormat"> Specifies the format of the shader binaries contained in binary. </param>
        /// <param name="binary"> Specifies the address of an array of bytes containing pre-compiled binary shader code. </param>
        /// <param name="length"> Specifies the length of the array whose address is given in binary. </param>
        public static unsafe void ShaderBinary(ReadOnlySpan<ShaderHandle> shaders, ShaderBinaryFormat binaryFormat, IntPtr binary, int length)
        {
            int count = (int)(shaders.Length);
            fixed (ShaderHandle* shaders_ptr = shaders)
            {
                void* binary_vptr = (void*)binary;
                ShaderBinary(count, shaders_ptr, binaryFormat, binary_vptr, length);
            }
        }
        /// <summary> Load pre-compiled shader binaries. </summary>
        /// <param name="shaders"> Specifies the address of an array of shader handles into which to load pre-compiled shader binaries. </param>
        /// <param name="binaryFormat"> Specifies the format of the shader binaries contained in binary. </param>
        /// <param name="binary"> Specifies the address of an array of bytes containing pre-compiled binary shader code. </param>
        /// <param name="length"> Specifies the length of the array whose address is given in binary. </param>
        public static unsafe void ShaderBinary(ShaderHandle[] shaders, ShaderBinaryFormat binaryFormat, IntPtr binary, int length)
        {
            int count = (int)(shaders.Length);
            fixed (ShaderHandle* shaders_ptr = shaders)
            {
                void* binary_vptr = (void*)binary;
                ShaderBinary(count, shaders_ptr, binaryFormat, binary_vptr, length);
            }
        }
        /// <summary> Load pre-compiled shader binaries. </summary>
        /// <param name="count"> Specifies the number of shader object handles contained in shaders. </param>
        /// <param name="shaders"> Specifies the address of an array of shader handles into which to load pre-compiled shader binaries. </param>
        /// <param name="binaryFormat"> Specifies the format of the shader binaries contained in binary. </param>
        /// <param name="binary"> Specifies the address of an array of bytes containing pre-compiled binary shader code. </param>
        /// <param name="length"> Specifies the length of the array whose address is given in binary. </param>
        public static unsafe void ShaderBinary(int count, in ShaderHandle shaders, ShaderBinaryFormat binaryFormat, IntPtr binary, int length)
        {
            fixed (ShaderHandle* shaders_ptr = &shaders)
            {
                void* binary_vptr = (void*)binary;
                ShaderBinary(count, shaders_ptr, binaryFormat, binary_vptr, length);
            }
        }
        /// <summary> Load pre-compiled shader binaries. </summary>
        /// <param name="shaders"> Specifies the address of an array of shader handles into which to load pre-compiled shader binaries. </param>
        /// <param name="binaryFormat"> Specifies the format of the shader binaries contained in binary. </param>
        /// <param name="binary"> Specifies the address of an array of bytes containing pre-compiled binary shader code. </param>
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
        /// <summary> Load pre-compiled shader binaries. </summary>
        /// <param name="shaders"> Specifies the address of an array of shader handles into which to load pre-compiled shader binaries. </param>
        /// <param name="binaryFormat"> Specifies the format of the shader binaries contained in binary. </param>
        /// <param name="binary"> Specifies the address of an array of bytes containing pre-compiled binary shader code. </param>
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
        /// <summary> Load pre-compiled shader binaries. </summary>
        /// <param name="count"> Specifies the number of shader object handles contained in shaders. </param>
        /// <param name="shaders"> Specifies the address of an array of shader handles into which to load pre-compiled shader binaries. </param>
        /// <param name="binaryFormat"> Specifies the format of the shader binaries contained in binary. </param>
        /// <param name="binary"> Specifies the address of an array of bytes containing pre-compiled binary shader code. </param>
        /// <param name="length"> Specifies the length of the array whose address is given in binary. </param>
        public static unsafe void ShaderBinary<T1>(int count, in ShaderHandle shaders, ShaderBinaryFormat binaryFormat, in T1 binary, int length)
            where T1 : unmanaged
        {
            fixed (ShaderHandle* shaders_ptr = &shaders)
            fixed (void* binary_ptr = &binary)
            {
                ShaderBinary(count, shaders_ptr, binaryFormat, binary_ptr, length);
            }
        }
        /// <summary> Replaces the source code in a shader object. </summary>
        /// <param name="shader">Specifies the handle of the shader object whose source code is to be replaced.</param>
        /// <param name="count">Specifies the number of elements in the string and length arrays.</param>
        /// <param name="length">Specifies an array of string lengths.</param>
        public static unsafe void ShaderSource(ShaderHandle shader, int count, byte** str, ReadOnlySpan<int> length)
        {
            fixed (int* length_ptr = length)
            {
                ShaderSource(shader, count, str, length_ptr);
            }
        }
        /// <summary> Replaces the source code in a shader object. </summary>
        /// <param name="shader">Specifies the handle of the shader object whose source code is to be replaced.</param>
        /// <param name="count">Specifies the number of elements in the string and length arrays.</param>
        /// <param name="length">Specifies an array of string lengths.</param>
        public static unsafe void ShaderSource(ShaderHandle shader, int count, byte** str, int[] length)
        {
            fixed (int* length_ptr = length)
            {
                ShaderSource(shader, count, str, length_ptr);
            }
        }
        /// <summary> Replaces the source code in a shader object. </summary>
        /// <param name="shader">Specifies the handle of the shader object whose source code is to be replaced.</param>
        /// <param name="count">Specifies the number of elements in the string and length arrays.</param>
        /// <param name="length">Specifies an array of string lengths.</param>
        public static unsafe void ShaderSource(ShaderHandle shader, int count, byte** str, in int length)
        {
            fixed (int* length_ptr = &length)
            {
                ShaderSource(shader, count, str, length_ptr);
            }
        }
        /// <summary> Specify a two-dimensional texture image. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="width"> Specifies the width of the texture image. All implementations support texture images that are at least 2048 texels wide. </param>
        /// <param name="height"> Specifies the height of the texture image. All implementations support texture images that are at least 2048 texels high. </param>
        /// <param name="border"> This value must be 0. </param>
        /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RED_INTEGER, GL_RG, GL_RG_INTEGER, GL_RGB, GL_RGB_INTEGER, GL_RGBA, GL_RGBA_INTEGER, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL,GL_STENCIL_INDEX, GL_LUMINANCE_ALPHA, GL_LUMINANCE, and GL_ALPHA. </param>
        /// <param name="type"> Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_HALF_FLOAT, GL_FLOAT, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_INT_2_10_10_10_REV, GL_UNSIGNED_INT_10F_11F_11F_REV, GL_UNSIGNED_INT_5_9_9_9_REV, GL_UNSIGNED_INT_24_8, and GL_FLOAT_32_UNSIGNED_INT_24_8_REV. </param>
        public static unsafe void TexImage2D(TextureTarget target, int level, int internalformat, int width, int height, int border, PixelFormat format, PixelType type, IntPtr pixels)
        {
            void* pixels_vptr = (void*)pixels;
            TexImage2D(target, level, internalformat, width, height, border, format, type, pixels_vptr);
        }
        /// <summary> Specify a two-dimensional texture image. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="width"> Specifies the width of the texture image. All implementations support texture images that are at least 2048 texels wide. </param>
        /// <param name="height"> Specifies the height of the texture image. All implementations support texture images that are at least 2048 texels high. </param>
        /// <param name="border"> This value must be 0. </param>
        /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RED_INTEGER, GL_RG, GL_RG_INTEGER, GL_RGB, GL_RGB_INTEGER, GL_RGBA, GL_RGBA_INTEGER, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL,GL_STENCIL_INDEX, GL_LUMINANCE_ALPHA, GL_LUMINANCE, and GL_ALPHA. </param>
        /// <param name="type"> Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_HALF_FLOAT, GL_FLOAT, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_INT_2_10_10_10_REV, GL_UNSIGNED_INT_10F_11F_11F_REV, GL_UNSIGNED_INT_5_9_9_9_REV, GL_UNSIGNED_INT_24_8, and GL_FLOAT_32_UNSIGNED_INT_24_8_REV. </param>
        public static unsafe void TexImage2D<T1>(TextureTarget target, int level, int internalformat, int width, int height, int border, PixelFormat format, PixelType type, ReadOnlySpan<T1> pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels)
            {
                TexImage2D(target, level, internalformat, width, height, border, format, type, pixels_ptr);
            }
        }
        /// <summary> Specify a two-dimensional texture image. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="width"> Specifies the width of the texture image. All implementations support texture images that are at least 2048 texels wide. </param>
        /// <param name="height"> Specifies the height of the texture image. All implementations support texture images that are at least 2048 texels high. </param>
        /// <param name="border"> This value must be 0. </param>
        /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RED_INTEGER, GL_RG, GL_RG_INTEGER, GL_RGB, GL_RGB_INTEGER, GL_RGBA, GL_RGBA_INTEGER, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL,GL_STENCIL_INDEX, GL_LUMINANCE_ALPHA, GL_LUMINANCE, and GL_ALPHA. </param>
        /// <param name="type"> Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_HALF_FLOAT, GL_FLOAT, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_INT_2_10_10_10_REV, GL_UNSIGNED_INT_10F_11F_11F_REV, GL_UNSIGNED_INT_5_9_9_9_REV, GL_UNSIGNED_INT_24_8, and GL_FLOAT_32_UNSIGNED_INT_24_8_REV. </param>
        public static unsafe void TexImage2D<T1>(TextureTarget target, int level, int internalformat, int width, int height, int border, PixelFormat format, PixelType type, T1[] pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels)
            {
                TexImage2D(target, level, internalformat, width, height, border, format, type, pixels_ptr);
            }
        }
        /// <summary> Specify a two-dimensional texture image. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="width"> Specifies the width of the texture image. All implementations support texture images that are at least 2048 texels wide. </param>
        /// <param name="height"> Specifies the height of the texture image. All implementations support texture images that are at least 2048 texels high. </param>
        /// <param name="border"> This value must be 0. </param>
        /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RED_INTEGER, GL_RG, GL_RG_INTEGER, GL_RGB, GL_RGB_INTEGER, GL_RGBA, GL_RGBA_INTEGER, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL,GL_STENCIL_INDEX, GL_LUMINANCE_ALPHA, GL_LUMINANCE, and GL_ALPHA. </param>
        /// <param name="type"> Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_HALF_FLOAT, GL_FLOAT, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_INT_2_10_10_10_REV, GL_UNSIGNED_INT_10F_11F_11F_REV, GL_UNSIGNED_INT_5_9_9_9_REV, GL_UNSIGNED_INT_24_8, and GL_FLOAT_32_UNSIGNED_INT_24_8_REV. </param>
        public static unsafe void TexImage2D<T1>(TextureTarget target, int level, int internalformat, int width, int height, int border, PixelFormat format, PixelType type, in T1 pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = &pixels)
            {
                TexImage2D(target, level, internalformat, width, height, border, format, type, pixels_ptr);
            }
        }
        /// <summary> Set texture parameters. </summary>
        /// <param name="target"> Specifies the target texture, which must be either GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R. </param>
        public static unsafe void TexParameterf(TextureTarget target, TextureParameterName pname, ReadOnlySpan<float> parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                TexParameterfv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Set texture parameters. </summary>
        /// <param name="target"> Specifies the target texture, which must be either GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R. </param>
        public static unsafe void TexParameterf(TextureTarget target, TextureParameterName pname, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                TexParameterfv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Set texture parameters. </summary>
        /// <param name="target"> Specifies the target texture, which must be either GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R. </param>
        public static unsafe void TexParameterf(TextureTarget target, TextureParameterName pname, in float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                TexParameterfv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Set texture parameters. </summary>
        /// <param name="target"> Specifies the target texture, which must be either GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R. </param>
        public static unsafe void TexParameteri(TextureTarget target, TextureParameterName pname, ReadOnlySpan<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                TexParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Set texture parameters. </summary>
        /// <param name="target"> Specifies the target texture, which must be either GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R. </param>
        public static unsafe void TexParameteri(TextureTarget target, TextureParameterName pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                TexParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Set texture parameters. </summary>
        /// <param name="target"> Specifies the target texture, which must be either GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R. </param>
        public static unsafe void TexParameteri(TextureTarget target, TextureParameterName pname, in int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                TexParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Specify a two-dimensional texture subimage. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="xoffset"> Specifies a texel offset in the x direction within the texture array. </param>
        /// <param name="yoffset"> Specifies a texel offset in the y direction within the texture array. </param>
        /// <param name="width"> Specifies the width of the texture subimage. </param>
        /// <param name="height"> Specifies the height of the texture subimage. </param>
        /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RED_INTEGER, GL_RG, GL_RG_INTEGER, GL_RGB, GL_RGB_INTEGER, GL_RGBA, GL_RGBA_INTEGER, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL, GL_LUMINANCE_ALPHA, GL_LUMINANCE, and GL_ALPHA. </param>
        /// <param name="type"> Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_HALF_FLOAT, GL_FLOAT, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_INT_2_10_10_10_REV, GL_UNSIGNED_INT_10F_11F_11F_REV, GL_UNSIGNED_INT_5_9_9_9_REV, GL_UNSIGNED_INT_24_8, and GL_FLOAT_32_UNSIGNED_INT_24_8_REV. </param>
        public static unsafe void TexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, IntPtr pixels)
        {
            void* pixels_vptr = (void*)pixels;
            TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels_vptr);
        }
        /// <summary> Specify a two-dimensional texture subimage. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="xoffset"> Specifies a texel offset in the x direction within the texture array. </param>
        /// <param name="yoffset"> Specifies a texel offset in the y direction within the texture array. </param>
        /// <param name="width"> Specifies the width of the texture subimage. </param>
        /// <param name="height"> Specifies the height of the texture subimage. </param>
        /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RED_INTEGER, GL_RG, GL_RG_INTEGER, GL_RGB, GL_RGB_INTEGER, GL_RGBA, GL_RGBA_INTEGER, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL, GL_LUMINANCE_ALPHA, GL_LUMINANCE, and GL_ALPHA. </param>
        /// <param name="type"> Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_HALF_FLOAT, GL_FLOAT, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_INT_2_10_10_10_REV, GL_UNSIGNED_INT_10F_11F_11F_REV, GL_UNSIGNED_INT_5_9_9_9_REV, GL_UNSIGNED_INT_24_8, and GL_FLOAT_32_UNSIGNED_INT_24_8_REV. </param>
        public static unsafe void TexSubImage2D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, ReadOnlySpan<T1> pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels)
            {
                TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels_ptr);
            }
        }
        /// <summary> Specify a two-dimensional texture subimage. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="xoffset"> Specifies a texel offset in the x direction within the texture array. </param>
        /// <param name="yoffset"> Specifies a texel offset in the y direction within the texture array. </param>
        /// <param name="width"> Specifies the width of the texture subimage. </param>
        /// <param name="height"> Specifies the height of the texture subimage. </param>
        /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RED_INTEGER, GL_RG, GL_RG_INTEGER, GL_RGB, GL_RGB_INTEGER, GL_RGBA, GL_RGBA_INTEGER, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL, GL_LUMINANCE_ALPHA, GL_LUMINANCE, and GL_ALPHA. </param>
        /// <param name="type"> Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_HALF_FLOAT, GL_FLOAT, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_INT_2_10_10_10_REV, GL_UNSIGNED_INT_10F_11F_11F_REV, GL_UNSIGNED_INT_5_9_9_9_REV, GL_UNSIGNED_INT_24_8, and GL_FLOAT_32_UNSIGNED_INT_24_8_REV. </param>
        public static unsafe void TexSubImage2D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, T1[] pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels)
            {
                TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels_ptr);
            }
        }
        /// <summary> Specify a two-dimensional texture subimage. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="xoffset"> Specifies a texel offset in the x direction within the texture array. </param>
        /// <param name="yoffset"> Specifies a texel offset in the y direction within the texture array. </param>
        /// <param name="width"> Specifies the width of the texture subimage. </param>
        /// <param name="height"> Specifies the height of the texture subimage. </param>
        /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RED_INTEGER, GL_RG, GL_RG_INTEGER, GL_RGB, GL_RGB_INTEGER, GL_RGBA, GL_RGBA_INTEGER, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL, GL_LUMINANCE_ALPHA, GL_LUMINANCE, and GL_ALPHA. </param>
        /// <param name="type"> Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_HALF_FLOAT, GL_FLOAT, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_INT_2_10_10_10_REV, GL_UNSIGNED_INT_10F_11F_11F_REV, GL_UNSIGNED_INT_5_9_9_9_REV, GL_UNSIGNED_INT_24_8, and GL_FLOAT_32_UNSIGNED_INT_24_8_REV. </param>
        public static unsafe void TexSubImage2D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, in T1 pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = &pixels)
            {
                TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void Uniform1f(int location, in float value)
        {
            int count = 1;
            fixed (float* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                Uniform1fv(location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void Uniform1f(int location, int count, ReadOnlySpan<float> value)
        {
            fixed (float* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                Uniform1fv(location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void Uniform1f(int location, int count, float[] value)
        {
            fixed (float* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                Uniform1fv(location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void Uniform1i(int location, in int value)
        {
            int count = 1;
            fixed (int* tmp_vecPtr = &value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                Uniform1iv(location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void Uniform1i(int location, int count, ReadOnlySpan<int> value)
        {
            fixed (int* tmp_vecPtr = value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                Uniform1iv(location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void Uniform1i(int location, int count, int[] value)
        {
            fixed (int* tmp_vecPtr = value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                Uniform1iv(location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void Uniform2f(int location, in Vector2 value)
        {
            int count = 1;
            fixed (Vector2* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                Uniform2fv(location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void Uniform2f(int location, int count, ReadOnlySpan<Vector2> value)
        {
            fixed (Vector2* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                Uniform2fv(location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void Uniform2f(int location, int count, Vector2[] value)
        {
            fixed (Vector2* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                Uniform2fv(location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void Uniform2i(int location, in Vector2i value)
        {
            int count = 1;
            fixed (Vector2i* tmp_vecPtr = &value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                Uniform2iv(location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void Uniform2i(int location, int count, ReadOnlySpan<Vector2i> value)
        {
            fixed (Vector2i* tmp_vecPtr = value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                Uniform2iv(location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void Uniform2i(int location, int count, Vector2i[] value)
        {
            fixed (Vector2i* tmp_vecPtr = value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                Uniform2iv(location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void Uniform3f(int location, in Vector3 value)
        {
            int count = 1;
            fixed (Vector3* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                Uniform3fv(location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void Uniform3f(int location, int count, ReadOnlySpan<Vector3> value)
        {
            fixed (Vector3* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                Uniform3fv(location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void Uniform3f(int location, int count, Vector3[] value)
        {
            fixed (Vector3* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                Uniform3fv(location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void Uniform3i(int location, in Vector3i value)
        {
            int count = 1;
            fixed (Vector3i* tmp_vecPtr = &value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                Uniform3iv(location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void Uniform3i(int location, int count, ReadOnlySpan<Vector3i> value)
        {
            fixed (Vector3i* tmp_vecPtr = value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                Uniform3iv(location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void Uniform3i(int location, int count, Vector3i[] value)
        {
            fixed (Vector3i* tmp_vecPtr = value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                Uniform3iv(location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void Uniform4f(int location, in Vector4 value)
        {
            int count = 1;
            fixed (Vector4* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                Uniform4fv(location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void Uniform4f(int location, int count, ReadOnlySpan<Vector4> value)
        {
            fixed (Vector4* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                Uniform4fv(location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void Uniform4f(int location, int count, Vector4[] value)
        {
            fixed (Vector4* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                Uniform4fv(location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void Uniform4i(int location, in Vector4i value)
        {
            int count = 1;
            fixed (Vector4i* tmp_vecPtr = &value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                Uniform4iv(location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void Uniform4i(int location, int count, ReadOnlySpan<Vector4i> value)
        {
            fixed (Vector4i* tmp_vecPtr = value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                Uniform4iv(location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void Uniform4i(int location, int count, Vector4i[] value)
        {
            fixed (Vector4i* tmp_vecPtr = value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                Uniform4iv(location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void UniformMatrix2f(int location, bool transpose, in Matrix2 value)
        {
            int count = 1;
            fixed (Matrix2* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                UniformMatrix2fv(location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void UniformMatrix2f(int location, int count, bool transpose, ReadOnlySpan<Matrix2> value)
        {
            fixed (Matrix2* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                UniformMatrix2fv(location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void UniformMatrix2f(int location, int count, bool transpose, Matrix2[] value)
        {
            fixed (Matrix2* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                UniformMatrix2fv(location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void UniformMatrix3f(int location, bool transpose, in Matrix3 value)
        {
            int count = 1;
            fixed (Matrix3* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                UniformMatrix3fv(location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void UniformMatrix3f(int location, int count, bool transpose, ReadOnlySpan<Matrix3> value)
        {
            fixed (Matrix3* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                UniformMatrix3fv(location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void UniformMatrix3f(int location, int count, bool transpose, Matrix3[] value)
        {
            fixed (Matrix3* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                UniformMatrix3fv(location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void UniformMatrix4f(int location, bool transpose, in Matrix4 value)
        {
            int count = 1;
            fixed (Matrix4* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                UniformMatrix4fv(location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void UniformMatrix4f(int location, int count, bool transpose, ReadOnlySpan<Matrix4> value)
        {
            fixed (Matrix4* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                UniformMatrix4fv(location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void UniformMatrix4f(int location, int count, bool transpose, Matrix4[] value)
        {
            fixed (Matrix4* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                UniformMatrix4fv(location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        public static unsafe void VertexAttrib1fv(uint index, ReadOnlySpan<float> v)
        {
            fixed (float* v_ptr = v)
            {
                VertexAttrib1fv(index, v_ptr);
            }
        }
        /// <summary> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        public static unsafe void VertexAttrib1fv(uint index, float[] v)
        {
            fixed (float* v_ptr = v)
            {
                VertexAttrib1fv(index, v_ptr);
            }
        }
        /// <summary> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        public static unsafe void VertexAttrib1fv(uint index, in float v)
        {
            fixed (float* v_ptr = &v)
            {
                VertexAttrib1fv(index, v_ptr);
            }
        }
        /// <summary> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        public static unsafe void VertexAttrib2fv(uint index, ReadOnlySpan<float> v)
        {
            fixed (float* v_ptr = v)
            {
                VertexAttrib2fv(index, v_ptr);
            }
        }
        /// <summary> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        public static unsafe void VertexAttrib2fv(uint index, float[] v)
        {
            fixed (float* v_ptr = v)
            {
                VertexAttrib2fv(index, v_ptr);
            }
        }
        /// <summary> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        public static unsafe void VertexAttrib2fv(uint index, in float v)
        {
            fixed (float* v_ptr = &v)
            {
                VertexAttrib2fv(index, v_ptr);
            }
        }
        /// <summary> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        public static unsafe void VertexAttrib3fv(uint index, ReadOnlySpan<float> v)
        {
            fixed (float* v_ptr = v)
            {
                VertexAttrib3fv(index, v_ptr);
            }
        }
        /// <summary> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        public static unsafe void VertexAttrib3fv(uint index, float[] v)
        {
            fixed (float* v_ptr = v)
            {
                VertexAttrib3fv(index, v_ptr);
            }
        }
        /// <summary> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        public static unsafe void VertexAttrib3fv(uint index, in float v)
        {
            fixed (float* v_ptr = &v)
            {
                VertexAttrib3fv(index, v_ptr);
            }
        }
        /// <summary> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        public static unsafe void VertexAttrib4fv(uint index, ReadOnlySpan<float> v)
        {
            fixed (float* v_ptr = v)
            {
                VertexAttrib4fv(index, v_ptr);
            }
        }
        /// <summary> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        public static unsafe void VertexAttrib4fv(uint index, float[] v)
        {
            fixed (float* v_ptr = v)
            {
                VertexAttrib4fv(index, v_ptr);
            }
        }
        /// <summary> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        public static unsafe void VertexAttrib4fv(uint index, in float v)
        {
            fixed (float* v_ptr = &v)
            {
                VertexAttrib4fv(index, v_ptr);
            }
        }
        /// <summary> Define an array of generic vertex attribute data. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="size">Specifies the number of components per generic vertex attribute. Must be 1, 2, 3, 4. The initial value is 4.</param>
        /// <param name="type">Specifies the data type of each component in the array. The symbolic constants GL_BYTE, GL_UNSIGNED_BYTE, GL_SHORT, GL_UNSIGNED_SHORT, GL_INT, and GL_UNSIGNED_INT are accepted by both functions. Additionally GL_HALF_FLOAT, GL_FLOAT, GL_FIXED, GL_INT_2_10_10_10_REV, and GL_UNSIGNED_INT_2_10_10_10_REV are accepted by glVertexAttribPointer. The initial value is GL_FLOAT.</param>
        /// <param name="normalized">For glVertexAttribPointer, specifies whether fixed-point data values should be normalized (GL_TRUE) or converted directly as fixed-point values (GL_FALSE) when they are accessed. This parameter is ignored if type is GL_FIXED.</param>
        /// <param name="stride"> Specifies the byte offset between consecutive generic vertex attributes. If stride is 0, the generic vertex attributes are understood to be tightly packed in the array. The initial value is 0. </param>
        public static unsafe void VertexAttribPointer(uint index, int size, VertexAttribPointerType type, bool normalized, int stride, nint offset)
        {
            void* pointer = (void*)offset;
            byte normalized_byte = (byte)(normalized ? 1 : 0);
            VertexAttribPointer(index, size, type, normalized_byte, stride, pointer);
        }
        /// <summary> Render primitives from array data. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="start"> Specifies the minimum array index contained in indices. </param>
        /// <param name="end"> Specifies the maximum array index contained in indices. </param>
        /// <param name="count"> Specifies the number of elements to be rendered. </param>
        /// <param name="type"> Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT. </param>
        public static unsafe void DrawRangeElements(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, nint offset)
        {
            void* indices = (void*)offset;
            DrawRangeElements(mode, start, end, count, type, indices);
        }
        /// <summary> Specify a three-dimensional texture image. </summary>
        /// <param name="target"> Specifies the target texture. Must be one of GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the n th mipmap reduction image. </param>
        /// <param name="width"> Specifies the width of the texture image. All implementations support 3D texture images that are at least 256 texels wide. </param>
        /// <param name="height"> Specifies the height of the texture image. All implementations support 3D texture images that are at least 256 texels high. </param>
        /// <param name="depth"> Specifies the depth of the texture image, or the number of layers in a texture array. All implementations support 3D texture images that are at least 256 texels deep, and texture arrays that are at least 256 layers deep. </param>
        /// <param name="border"> This value must be 0. </param>
        /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RED_INTEGER, GL_RG, GL_RG_INTEGER, GL_RGB, GL_RGB_INTEGER, GL_RGBA, GL_RGBA_INTEGER, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL, GL_STENCIL_INDEX, GL_LUMINANCE_ALPHA, GL_LUMINANCE, and GL_ALPHA. </param>
        /// <param name="type"> Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_HALF_FLOAT, GL_FLOAT, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_INT_2_10_10_10_REV, GL_UNSIGNED_INT_10F_11F_11F_REV, GL_UNSIGNED_INT_5_9_9_9_REV, GL_UNSIGNED_INT_24_8, and GL_FLOAT_32_UNSIGNED_INT_24_8_REV. </param>
        public static unsafe void TexImage3D(TextureTarget target, int level, int internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, IntPtr pixels)
        {
            void* pixels_vptr = (void*)pixels;
            TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels_vptr);
        }
        /// <summary> Specify a three-dimensional texture image. </summary>
        /// <param name="target"> Specifies the target texture. Must be one of GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the n th mipmap reduction image. </param>
        /// <param name="width"> Specifies the width of the texture image. All implementations support 3D texture images that are at least 256 texels wide. </param>
        /// <param name="height"> Specifies the height of the texture image. All implementations support 3D texture images that are at least 256 texels high. </param>
        /// <param name="depth"> Specifies the depth of the texture image, or the number of layers in a texture array. All implementations support 3D texture images that are at least 256 texels deep, and texture arrays that are at least 256 layers deep. </param>
        /// <param name="border"> This value must be 0. </param>
        /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RED_INTEGER, GL_RG, GL_RG_INTEGER, GL_RGB, GL_RGB_INTEGER, GL_RGBA, GL_RGBA_INTEGER, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL, GL_STENCIL_INDEX, GL_LUMINANCE_ALPHA, GL_LUMINANCE, and GL_ALPHA. </param>
        /// <param name="type"> Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_HALF_FLOAT, GL_FLOAT, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_INT_2_10_10_10_REV, GL_UNSIGNED_INT_10F_11F_11F_REV, GL_UNSIGNED_INT_5_9_9_9_REV, GL_UNSIGNED_INT_24_8, and GL_FLOAT_32_UNSIGNED_INT_24_8_REV. </param>
        public static unsafe void TexImage3D<T1>(TextureTarget target, int level, int internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, ReadOnlySpan<T1> pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels)
            {
                TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels_ptr);
            }
        }
        /// <summary> Specify a three-dimensional texture image. </summary>
        /// <param name="target"> Specifies the target texture. Must be one of GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the n th mipmap reduction image. </param>
        /// <param name="width"> Specifies the width of the texture image. All implementations support 3D texture images that are at least 256 texels wide. </param>
        /// <param name="height"> Specifies the height of the texture image. All implementations support 3D texture images that are at least 256 texels high. </param>
        /// <param name="depth"> Specifies the depth of the texture image, or the number of layers in a texture array. All implementations support 3D texture images that are at least 256 texels deep, and texture arrays that are at least 256 layers deep. </param>
        /// <param name="border"> This value must be 0. </param>
        /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RED_INTEGER, GL_RG, GL_RG_INTEGER, GL_RGB, GL_RGB_INTEGER, GL_RGBA, GL_RGBA_INTEGER, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL, GL_STENCIL_INDEX, GL_LUMINANCE_ALPHA, GL_LUMINANCE, and GL_ALPHA. </param>
        /// <param name="type"> Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_HALF_FLOAT, GL_FLOAT, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_INT_2_10_10_10_REV, GL_UNSIGNED_INT_10F_11F_11F_REV, GL_UNSIGNED_INT_5_9_9_9_REV, GL_UNSIGNED_INT_24_8, and GL_FLOAT_32_UNSIGNED_INT_24_8_REV. </param>
        public static unsafe void TexImage3D<T1>(TextureTarget target, int level, int internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, T1[] pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels)
            {
                TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels_ptr);
            }
        }
        /// <summary> Specify a three-dimensional texture image. </summary>
        /// <param name="target"> Specifies the target texture. Must be one of GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the n th mipmap reduction image. </param>
        /// <param name="width"> Specifies the width of the texture image. All implementations support 3D texture images that are at least 256 texels wide. </param>
        /// <param name="height"> Specifies the height of the texture image. All implementations support 3D texture images that are at least 256 texels high. </param>
        /// <param name="depth"> Specifies the depth of the texture image, or the number of layers in a texture array. All implementations support 3D texture images that are at least 256 texels deep, and texture arrays that are at least 256 layers deep. </param>
        /// <param name="border"> This value must be 0. </param>
        /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RED_INTEGER, GL_RG, GL_RG_INTEGER, GL_RGB, GL_RGB_INTEGER, GL_RGBA, GL_RGBA_INTEGER, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL, GL_STENCIL_INDEX, GL_LUMINANCE_ALPHA, GL_LUMINANCE, and GL_ALPHA. </param>
        /// <param name="type"> Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_HALF_FLOAT, GL_FLOAT, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_INT_2_10_10_10_REV, GL_UNSIGNED_INT_10F_11F_11F_REV, GL_UNSIGNED_INT_5_9_9_9_REV, GL_UNSIGNED_INT_24_8, and GL_FLOAT_32_UNSIGNED_INT_24_8_REV. </param>
        public static unsafe void TexImage3D<T1>(TextureTarget target, int level, int internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, in T1 pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = &pixels)
            {
                TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels_ptr);
            }
        }
        /// <summary> Specify a three-dimensional texture subimage. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="xoffset"> Specifies a texel offset in the x direction within the texture array. </param>
        /// <param name="yoffset"> Specifies a texel offset in the y direction within the texture array. </param>
        /// <param name="zoffset"> Specifies a texel offset in the z direction within the texture array. </param>
        /// <param name="width"> Specifies the width of the texture subimage. </param>
        /// <param name="height"> Specifies the height of the texture subimage. </param>
        /// <param name="depth"> Specifies the depth of the texture subimage. </param>
        /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RED_INTEGER, GL_RG, GL_RG_INTEGER, GL_RGB, GL_RGB_INTEGER, GL_RGBA, GL_RGBA_INTEGER, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL, GL_LUMINANCE_ALPHA, GL_LUMINANCE, and GL_ALPHA. </param>
        /// <param name="type"> Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_HALF_FLOAT, GL_FLOAT, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_INT_2_10_10_10_REV, GL_UNSIGNED_INT_10F_11F_11F_REV, GL_UNSIGNED_INT_5_9_9_9_REV, GL_UNSIGNED_INT_24_8, and GL_FLOAT_32_UNSIGNED_INT_24_8_REV. </param>
        public static unsafe void TexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels)
        {
            void* pixels_vptr = (void*)pixels;
            TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels_vptr);
        }
        /// <summary> Specify a three-dimensional texture subimage. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="xoffset"> Specifies a texel offset in the x direction within the texture array. </param>
        /// <param name="yoffset"> Specifies a texel offset in the y direction within the texture array. </param>
        /// <param name="zoffset"> Specifies a texel offset in the z direction within the texture array. </param>
        /// <param name="width"> Specifies the width of the texture subimage. </param>
        /// <param name="height"> Specifies the height of the texture subimage. </param>
        /// <param name="depth"> Specifies the depth of the texture subimage. </param>
        /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RED_INTEGER, GL_RG, GL_RG_INTEGER, GL_RGB, GL_RGB_INTEGER, GL_RGBA, GL_RGBA_INTEGER, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL, GL_LUMINANCE_ALPHA, GL_LUMINANCE, and GL_ALPHA. </param>
        /// <param name="type"> Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_HALF_FLOAT, GL_FLOAT, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_INT_2_10_10_10_REV, GL_UNSIGNED_INT_10F_11F_11F_REV, GL_UNSIGNED_INT_5_9_9_9_REV, GL_UNSIGNED_INT_24_8, and GL_FLOAT_32_UNSIGNED_INT_24_8_REV. </param>
        public static unsafe void TexSubImage3D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, ReadOnlySpan<T1> pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels)
            {
                TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels_ptr);
            }
        }
        /// <summary> Specify a three-dimensional texture subimage. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="xoffset"> Specifies a texel offset in the x direction within the texture array. </param>
        /// <param name="yoffset"> Specifies a texel offset in the y direction within the texture array. </param>
        /// <param name="zoffset"> Specifies a texel offset in the z direction within the texture array. </param>
        /// <param name="width"> Specifies the width of the texture subimage. </param>
        /// <param name="height"> Specifies the height of the texture subimage. </param>
        /// <param name="depth"> Specifies the depth of the texture subimage. </param>
        /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RED_INTEGER, GL_RG, GL_RG_INTEGER, GL_RGB, GL_RGB_INTEGER, GL_RGBA, GL_RGBA_INTEGER, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL, GL_LUMINANCE_ALPHA, GL_LUMINANCE, and GL_ALPHA. </param>
        /// <param name="type"> Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_HALF_FLOAT, GL_FLOAT, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_INT_2_10_10_10_REV, GL_UNSIGNED_INT_10F_11F_11F_REV, GL_UNSIGNED_INT_5_9_9_9_REV, GL_UNSIGNED_INT_24_8, and GL_FLOAT_32_UNSIGNED_INT_24_8_REV. </param>
        public static unsafe void TexSubImage3D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, T1[] pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels)
            {
                TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels_ptr);
            }
        }
        /// <summary> Specify a three-dimensional texture subimage. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="xoffset"> Specifies a texel offset in the x direction within the texture array. </param>
        /// <param name="yoffset"> Specifies a texel offset in the y direction within the texture array. </param>
        /// <param name="zoffset"> Specifies a texel offset in the z direction within the texture array. </param>
        /// <param name="width"> Specifies the width of the texture subimage. </param>
        /// <param name="height"> Specifies the height of the texture subimage. </param>
        /// <param name="depth"> Specifies the depth of the texture subimage. </param>
        /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RED_INTEGER, GL_RG, GL_RG_INTEGER, GL_RGB, GL_RGB_INTEGER, GL_RGBA, GL_RGBA_INTEGER, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL, GL_LUMINANCE_ALPHA, GL_LUMINANCE, and GL_ALPHA. </param>
        /// <param name="type"> Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_HALF_FLOAT, GL_FLOAT, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_INT_2_10_10_10_REV, GL_UNSIGNED_INT_10F_11F_11F_REV, GL_UNSIGNED_INT_5_9_9_9_REV, GL_UNSIGNED_INT_24_8, and GL_FLOAT_32_UNSIGNED_INT_24_8_REV. </param>
        public static unsafe void TexSubImage3D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, in T1 pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = &pixels)
            {
                TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels_ptr);
            }
        }
        /// <summary> Specify a three-dimensional texture image in a compressed format. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="internalformat"> Specifies the format of the compressed image data stored at address data. </param>
        /// <param name="width"> Specifies the width of the texture image. </param>
        /// <param name="height"> Specifies the height of the texture image. </param>
        /// <param name="depth"> Specifies the depth of the texture image. </param>
        /// <param name="border"> This value must be 0. </param>
        /// <param name="imageSize"> Specifies the number of unsigned bytes of image data starting at the address specified by data. </param>
        /// <param name="data"> Specifies a pointer to the compressed image data in memory. </param>
        public static unsafe void CompressedTexImage3D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data)
        {
            void* data_vptr = (void*)data;
            CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data_vptr);
        }
        /// <summary> Specify a three-dimensional texture image in a compressed format. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="internalformat"> Specifies the format of the compressed image data stored at address data. </param>
        /// <param name="width"> Specifies the width of the texture image. </param>
        /// <param name="height"> Specifies the height of the texture image. </param>
        /// <param name="depth"> Specifies the depth of the texture image. </param>
        /// <param name="border"> This value must be 0. </param>
        /// <param name="data"> Specifies a pointer to the compressed image data in memory. </param>
        public static unsafe void CompressedTexImage3D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, ReadOnlySpan<T1> data)
            where T1 : unmanaged
        {
            int imageSize = (int)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data_ptr);
            }
        }
        /// <summary> Specify a three-dimensional texture image in a compressed format. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="internalformat"> Specifies the format of the compressed image data stored at address data. </param>
        /// <param name="width"> Specifies the width of the texture image. </param>
        /// <param name="height"> Specifies the height of the texture image. </param>
        /// <param name="depth"> Specifies the depth of the texture image. </param>
        /// <param name="border"> This value must be 0. </param>
        /// <param name="data"> Specifies a pointer to the compressed image data in memory. </param>
        public static unsafe void CompressedTexImage3D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, T1[] data)
            where T1 : unmanaged
        {
            int imageSize = (int)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data_ptr);
            }
        }
        /// <summary> Specify a three-dimensional texture image in a compressed format. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="internalformat"> Specifies the format of the compressed image data stored at address data. </param>
        /// <param name="width"> Specifies the width of the texture image. </param>
        /// <param name="height"> Specifies the height of the texture image. </param>
        /// <param name="depth"> Specifies the depth of the texture image. </param>
        /// <param name="border"> This value must be 0. </param>
        /// <param name="imageSize"> Specifies the number of unsigned bytes of image data starting at the address specified by data. </param>
        /// <param name="data"> Specifies a pointer to the compressed image data in memory. </param>
        public static unsafe void CompressedTexImage3D<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, in T1 data)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = &data)
            {
                CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data_ptr);
            }
        }
        /// <summary> Specify a three-dimensional texture subimage in a compressed format. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="xoffset"> Specifies a texel offset in the x direction within the texture array. </param>
        /// <param name="yoffset"> Specifies a texel offset in the y direction within the texture array. </param>
        /// <param name="zoffset"> Specifies a texel offset in the z direction within the texture array. </param>
        /// <param name="width"> Specifies the width of the texture subimage. </param>
        /// <param name="height"> Specifies the height of the texture subimage. </param>
        /// <param name="depth"> Specifies the depth of the texture subimage. </param>
        /// <param name="format"> Specifies the format of the compressed image data stored at address data. </param>
        /// <param name="imageSize"> Specifies the number of unsigned bytes of image data starting at the address specified by data. </param>
        /// <param name="data"> Specifies a pointer to the compressed image data in memory. </param>
        public static unsafe void CompressedTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, IntPtr data)
        {
            void* data_vptr = (void*)data;
            CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data_vptr);
        }
        /// <summary> Specify a three-dimensional texture subimage in a compressed format. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="xoffset"> Specifies a texel offset in the x direction within the texture array. </param>
        /// <param name="yoffset"> Specifies a texel offset in the y direction within the texture array. </param>
        /// <param name="zoffset"> Specifies a texel offset in the z direction within the texture array. </param>
        /// <param name="width"> Specifies the width of the texture subimage. </param>
        /// <param name="height"> Specifies the height of the texture subimage. </param>
        /// <param name="depth"> Specifies the depth of the texture subimage. </param>
        /// <param name="format"> Specifies the format of the compressed image data stored at address data. </param>
        /// <param name="data"> Specifies a pointer to the compressed image data in memory. </param>
        public static unsafe void CompressedTexSubImage3D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, ReadOnlySpan<T1> data)
            where T1 : unmanaged
        {
            int imageSize = (int)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data_ptr);
            }
        }
        /// <summary> Specify a three-dimensional texture subimage in a compressed format. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="xoffset"> Specifies a texel offset in the x direction within the texture array. </param>
        /// <param name="yoffset"> Specifies a texel offset in the y direction within the texture array. </param>
        /// <param name="zoffset"> Specifies a texel offset in the z direction within the texture array. </param>
        /// <param name="width"> Specifies the width of the texture subimage. </param>
        /// <param name="height"> Specifies the height of the texture subimage. </param>
        /// <param name="depth"> Specifies the depth of the texture subimage. </param>
        /// <param name="format"> Specifies the format of the compressed image data stored at address data. </param>
        /// <param name="data"> Specifies a pointer to the compressed image data in memory. </param>
        public static unsafe void CompressedTexSubImage3D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, T1[] data)
            where T1 : unmanaged
        {
            int imageSize = (int)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data_ptr);
            }
        }
        /// <summary> Specify a three-dimensional texture subimage in a compressed format. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="xoffset"> Specifies a texel offset in the x direction within the texture array. </param>
        /// <param name="yoffset"> Specifies a texel offset in the y direction within the texture array. </param>
        /// <param name="zoffset"> Specifies a texel offset in the z direction within the texture array. </param>
        /// <param name="width"> Specifies the width of the texture subimage. </param>
        /// <param name="height"> Specifies the height of the texture subimage. </param>
        /// <param name="depth"> Specifies the depth of the texture subimage. </param>
        /// <param name="format"> Specifies the format of the compressed image data stored at address data. </param>
        /// <param name="imageSize"> Specifies the number of unsigned bytes of image data starting at the address specified by data. </param>
        /// <param name="data"> Specifies a pointer to the compressed image data in memory. </param>
        public static unsafe void CompressedTexSubImage3D<T1>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, in T1 data)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = &data)
            {
                CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data_ptr);
            }
        }
        /// <summary> Generate query object names. </summary>
        public static unsafe QueryHandle GenQuerie()
        {
            QueryHandle ids;
            int n = 1;
            Unsafe.SkipInit(out ids);
            // FIXME: This could be a problem for the overloads that take an out parameter
            // as this parameter could *potentially* move while inside of this function
            // which would mean that the new value never gets written to the out parameter.
            // Making for a nasty bug.
            // The reason we don't use a fixed expression here is because of the "single out parameter to return value" overloading step
            // that will make it so this tries to fix a local variable which is not allowed in C# for some reason.
            // If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk
            // - 2021-05-18
            QueryHandle* ids_handle = (QueryHandle*)Unsafe.AsPointer(ref ids);
            GenQueries(n, ids_handle);
            return ids;
        }
        /// <summary> Generate query object names. </summary>
        /// <param name="ids"> Specifies an array in which the generated query object names are stored. </param>
        public static unsafe void GenQuerie(out QueryHandle ids)
        {
            int n = 1;
            Unsafe.SkipInit(out ids);
            // FIXME: This could be a problem for the overloads that take an out parameter
            // as this parameter could *potentially* move while inside of this function
            // which would mean that the new value never gets written to the out parameter.
            // Making for a nasty bug.
            // The reason we don't use a fixed expression here is because of the "single out parameter to return value" overloading step
            // that will make it so this tries to fix a local variable which is not allowed in C# for some reason.
            // If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk
            // - 2021-05-18
            QueryHandle* ids_handle = (QueryHandle*)Unsafe.AsPointer(ref ids);
            GenQueries(n, ids_handle);
        }
        /// <summary> Generate query object names. </summary>
        /// <param name="ids"> Specifies an array in which the generated query object names are stored. </param>
        public static unsafe void GenQueries(Span<QueryHandle> ids)
        {
            int n = (int)(ids.Length);
            fixed (QueryHandle* ids_ptr = ids)
            {
                GenQueries(n, ids_ptr);
            }
        }
        /// <summary> Generate query object names. </summary>
        /// <param name="ids"> Specifies an array in which the generated query object names are stored. </param>
        public static unsafe void GenQueries(QueryHandle[] ids)
        {
            int n = (int)(ids.Length);
            fixed (QueryHandle* ids_ptr = ids)
            {
                GenQueries(n, ids_ptr);
            }
        }
        /// <summary> Generate query object names. </summary>
        /// <param name="n"> Specifies the number of query object names to be generated. </param>
        /// <param name="ids"> Specifies an array in which the generated query object names are stored. </param>
        public static unsafe void GenQueries(int n, ref QueryHandle ids)
        {
            fixed (QueryHandle* ids_ptr = &ids)
            {
                GenQueries(n, ids_ptr);
            }
        }
        /// <summary> Delete named query objects. </summary>
        /// <param name="ids"> Specifies an array of query objects to be deleted. </param>
        public static unsafe void DeleteQuerie(in QueryHandle ids)
        {
            int n = 1;
            fixed(QueryHandle* ids_handle = &ids)
            {
                DeleteQueries(n, ids_handle);
            }
        }
        /// <summary> Delete named query objects. </summary>
        /// <param name="ids"> Specifies an array of query objects to be deleted. </param>
        public static unsafe void DeleteQueries(ReadOnlySpan<QueryHandle> ids)
        {
            int n = (int)(ids.Length);
            fixed (QueryHandle* ids_ptr = ids)
            {
                DeleteQueries(n, ids_ptr);
            }
        }
        /// <summary> Delete named query objects. </summary>
        /// <param name="ids"> Specifies an array of query objects to be deleted. </param>
        public static unsafe void DeleteQueries(QueryHandle[] ids)
        {
            int n = (int)(ids.Length);
            fixed (QueryHandle* ids_ptr = ids)
            {
                DeleteQueries(n, ids_ptr);
            }
        }
        /// <summary> Delete named query objects. </summary>
        /// <param name="n"> Specifies the number of query objects to be deleted. </param>
        /// <param name="ids"> Specifies an array of query objects to be deleted. </param>
        public static unsafe void DeleteQueries(int n, in QueryHandle ids)
        {
            fixed (QueryHandle* ids_ptr = &ids)
            {
                DeleteQueries(n, ids_ptr);
            }
        }
        /// <summary> Return parameters of a query object target. </summary>
        /// <param name="target"> Specifies a query object target. Must be GL_ANY_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED_CONSERVATIVE, GL_PRIMITIVES_GENERATED, or GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN. </param>
        /// <param name="pname"> Specifies the symbolic name of a query object target parameter. Must be GL_CURRENT_QUERY. </param>
        public static unsafe void GetQueryi(QueryTarget target, QueryParameterName pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetQueryiv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Return parameters of a query object target. </summary>
        /// <param name="target"> Specifies a query object target. Must be GL_ANY_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED_CONSERVATIVE, GL_PRIMITIVES_GENERATED, or GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN. </param>
        /// <param name="pname"> Specifies the symbolic name of a query object target parameter. Must be GL_CURRENT_QUERY. </param>
        public static unsafe void GetQueryi(QueryTarget target, QueryParameterName pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetQueryiv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Return parameters of a query object target. </summary>
        /// <param name="target"> Specifies a query object target. Must be GL_ANY_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED_CONSERVATIVE, GL_PRIMITIVES_GENERATED, or GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN. </param>
        /// <param name="pname"> Specifies the symbolic name of a query object target parameter. Must be GL_CURRENT_QUERY. </param>
        public static unsafe void GetQueryi(QueryTarget target, QueryParameterName pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetQueryiv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Return parameters of a query object. </summary>
        /// <param name="id"> Specifies the name of a query object. </param>
        /// <param name="pname"> Specifies the symbolic name of a query object parameter. Accepted values are GL_QUERY_RESULT or GL_QUERY_RESULT_AVAILABLE. </param>
        public static unsafe void GetQueryObjectui(QueryHandle id, QueryObjectParameterName pname, Span<uint> parameters)
        {
            fixed (uint* parameters_ptr = parameters)
            {
                GetQueryObjectuiv(id, pname, parameters_ptr);
            }
        }
        /// <summary> Return parameters of a query object. </summary>
        /// <param name="id"> Specifies the name of a query object. </param>
        /// <param name="pname"> Specifies the symbolic name of a query object parameter. Accepted values are GL_QUERY_RESULT or GL_QUERY_RESULT_AVAILABLE. </param>
        public static unsafe void GetQueryObjectui(QueryHandle id, QueryObjectParameterName pname, uint[] parameters)
        {
            fixed (uint* parameters_ptr = parameters)
            {
                GetQueryObjectuiv(id, pname, parameters_ptr);
            }
        }
        /// <summary> Return parameters of a query object. </summary>
        /// <param name="id"> Specifies the name of a query object. </param>
        /// <param name="pname"> Specifies the symbolic name of a query object parameter. Accepted values are GL_QUERY_RESULT or GL_QUERY_RESULT_AVAILABLE. </param>
        public static unsafe void GetQueryObjectui(QueryHandle id, QueryObjectParameterName pname, ref uint parameters)
        {
            fixed (uint* parameters_ptr = &parameters)
            {
                GetQueryObjectuiv(id, pname, parameters_ptr);
            }
        }
        /// <summary> Return the pointer to a mapped buffer object's data store. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glGetBufferPointerv, which must be one of the buffer binding targets in the following table: </param>
        /// <param name="pname"> Specifies the pointer to be returned. The symbolic constant must be GL_BUFFER_MAP_POINTER. </param>
        public static unsafe void GetBufferPointer(BufferTargetARB target, BufferPointerNameARB pname, void** parameters)
        {
            GetBufferPointerv(target, pname, parameters);
        }
        /// <summary> Specifies a list of color buffers to be drawn into. </summary>
        /// <param name="bufs">Points to an array of symbolic constants specifying the buffers into which fragment colors or data values will be written.</param>
        public static unsafe void DrawBuffers(ReadOnlySpan<DrawBufferMode> bufs)
        {
            int n = (int)(bufs.Length);
            fixed (DrawBufferMode* bufs_ptr = bufs)
            {
                DrawBuffers(n, bufs_ptr);
            }
        }
        /// <summary> Specifies a list of color buffers to be drawn into. </summary>
        /// <param name="bufs">Points to an array of symbolic constants specifying the buffers into which fragment colors or data values will be written.</param>
        public static unsafe void DrawBuffers(DrawBufferMode[] bufs)
        {
            int n = (int)(bufs.Length);
            fixed (DrawBufferMode* bufs_ptr = bufs)
            {
                DrawBuffers(n, bufs_ptr);
            }
        }
        /// <summary> Specifies a list of color buffers to be drawn into. </summary>
        /// <param name="n">Specifies the number of buffers in bufs.</param>
        /// <param name="bufs">Points to an array of symbolic constants specifying the buffers into which fragment colors or data values will be written.</param>
        public static unsafe void DrawBuffers(int n, in DrawBufferMode bufs)
        {
            fixed (DrawBufferMode* bufs_ptr = &bufs)
            {
                DrawBuffers(n, bufs_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void UniformMatrix2x3f(int location, bool transpose, in Matrix2x3 value)
        {
            int count = 1;
            fixed (Matrix2x3* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                UniformMatrix2x3fv(location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void UniformMatrix2x3f(int location, int count, bool transpose, ReadOnlySpan<Matrix2x3> value)
        {
            fixed (Matrix2x3* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                UniformMatrix2x3fv(location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void UniformMatrix2x3f(int location, int count, bool transpose, Matrix2x3[] value)
        {
            fixed (Matrix2x3* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                UniformMatrix2x3fv(location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void UniformMatrix3x2f(int location, bool transpose, in Matrix3x2 value)
        {
            int count = 1;
            fixed (Matrix3x2* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                UniformMatrix3x2fv(location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void UniformMatrix3x2f(int location, int count, bool transpose, ReadOnlySpan<Matrix3x2> value)
        {
            fixed (Matrix3x2* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                UniformMatrix3x2fv(location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void UniformMatrix3x2f(int location, int count, bool transpose, Matrix3x2[] value)
        {
            fixed (Matrix3x2* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                UniformMatrix3x2fv(location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void UniformMatrix2x4f(int location, bool transpose, in Matrix2x4 value)
        {
            int count = 1;
            fixed (Matrix2x4* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                UniformMatrix2x4fv(location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void UniformMatrix2x4f(int location, int count, bool transpose, ReadOnlySpan<Matrix2x4> value)
        {
            fixed (Matrix2x4* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                UniformMatrix2x4fv(location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void UniformMatrix2x4f(int location, int count, bool transpose, Matrix2x4[] value)
        {
            fixed (Matrix2x4* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                UniformMatrix2x4fv(location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void UniformMatrix4x2f(int location, bool transpose, in Matrix4x2 value)
        {
            int count = 1;
            fixed (Matrix4x2* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                UniformMatrix4x2fv(location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void UniformMatrix4x2f(int location, int count, bool transpose, ReadOnlySpan<Matrix4x2> value)
        {
            fixed (Matrix4x2* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                UniformMatrix4x2fv(location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void UniformMatrix4x2f(int location, int count, bool transpose, Matrix4x2[] value)
        {
            fixed (Matrix4x2* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                UniformMatrix4x2fv(location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void UniformMatrix3x4f(int location, bool transpose, in Matrix3x4 value)
        {
            int count = 1;
            fixed (Matrix3x4* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                UniformMatrix3x4fv(location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void UniformMatrix3x4f(int location, int count, bool transpose, ReadOnlySpan<Matrix3x4> value)
        {
            fixed (Matrix3x4* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                UniformMatrix3x4fv(location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void UniformMatrix3x4f(int location, int count, bool transpose, Matrix3x4[] value)
        {
            fixed (Matrix3x4* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                UniformMatrix3x4fv(location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void UniformMatrix4x3f(int location, bool transpose, in Matrix4x3 value)
        {
            int count = 1;
            fixed (Matrix4x3* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                UniformMatrix4x3fv(location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void UniformMatrix4x3f(int location, int count, bool transpose, ReadOnlySpan<Matrix4x3> value)
        {
            fixed (Matrix4x3* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                UniformMatrix4x3fv(location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void UniformMatrix4x3f(int location, int count, bool transpose, Matrix4x3[] value)
        {
            fixed (Matrix4x3* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                UniformMatrix4x3fv(location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Delete vertex array objects. </summary>
        /// <param name="arrays"> Specifies the address of an array containing the n names of the objects to be deleted. </param>
        public static unsafe void DeleteVertexArray(in VertexArrayHandle arrays)
        {
            int n = 1;
            fixed(VertexArrayHandle* arrays_handle = &arrays)
            {
                DeleteVertexArrays(n, arrays_handle);
            }
        }
        /// <summary> Delete vertex array objects. </summary>
        /// <param name="arrays"> Specifies the address of an array containing the n names of the objects to be deleted. </param>
        public static unsafe void DeleteVertexArrays(ReadOnlySpan<VertexArrayHandle> arrays)
        {
            int n = (int)(arrays.Length);
            fixed (VertexArrayHandle* arrays_ptr = arrays)
            {
                DeleteVertexArrays(n, arrays_ptr);
            }
        }
        /// <summary> Delete vertex array objects. </summary>
        /// <param name="arrays"> Specifies the address of an array containing the n names of the objects to be deleted. </param>
        public static unsafe void DeleteVertexArrays(VertexArrayHandle[] arrays)
        {
            int n = (int)(arrays.Length);
            fixed (VertexArrayHandle* arrays_ptr = arrays)
            {
                DeleteVertexArrays(n, arrays_ptr);
            }
        }
        /// <summary> Delete vertex array objects. </summary>
        /// <param name="n"> Specifies the number of vertex array objects to be deleted. </param>
        /// <param name="arrays"> Specifies the address of an array containing the n names of the objects to be deleted. </param>
        public static unsafe void DeleteVertexArrays(int n, in VertexArrayHandle arrays)
        {
            fixed (VertexArrayHandle* arrays_ptr = &arrays)
            {
                DeleteVertexArrays(n, arrays_ptr);
            }
        }
        /// <summary> Generate vertex array object names. </summary>
        public static unsafe VertexArrayHandle GenVertexArray()
        {
            VertexArrayHandle arrays;
            int n = 1;
            Unsafe.SkipInit(out arrays);
            // FIXME: This could be a problem for the overloads that take an out parameter
            // as this parameter could *potentially* move while inside of this function
            // which would mean that the new value never gets written to the out parameter.
            // Making for a nasty bug.
            // The reason we don't use a fixed expression here is because of the "single out parameter to return value" overloading step
            // that will make it so this tries to fix a local variable which is not allowed in C# for some reason.
            // If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk
            // - 2021-05-18
            VertexArrayHandle* arrays_handle = (VertexArrayHandle*)Unsafe.AsPointer(ref arrays);
            GenVertexArrays(n, arrays_handle);
            return arrays;
        }
        /// <summary> Generate vertex array object names. </summary>
        /// <param name="arrays"> Specifies an array in which the generated vertex array object names are stored. </param>
        public static unsafe void GenVertexArray(out VertexArrayHandle arrays)
        {
            int n = 1;
            Unsafe.SkipInit(out arrays);
            // FIXME: This could be a problem for the overloads that take an out parameter
            // as this parameter could *potentially* move while inside of this function
            // which would mean that the new value never gets written to the out parameter.
            // Making for a nasty bug.
            // The reason we don't use a fixed expression here is because of the "single out parameter to return value" overloading step
            // that will make it so this tries to fix a local variable which is not allowed in C# for some reason.
            // If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk
            // - 2021-05-18
            VertexArrayHandle* arrays_handle = (VertexArrayHandle*)Unsafe.AsPointer(ref arrays);
            GenVertexArrays(n, arrays_handle);
        }
        /// <summary> Generate vertex array object names. </summary>
        /// <param name="arrays"> Specifies an array in which the generated vertex array object names are stored. </param>
        public static unsafe void GenVertexArrays(Span<VertexArrayHandle> arrays)
        {
            int n = (int)(arrays.Length);
            fixed (VertexArrayHandle* arrays_ptr = arrays)
            {
                GenVertexArrays(n, arrays_ptr);
            }
        }
        /// <summary> Generate vertex array object names. </summary>
        /// <param name="arrays"> Specifies an array in which the generated vertex array object names are stored. </param>
        public static unsafe void GenVertexArrays(VertexArrayHandle[] arrays)
        {
            int n = (int)(arrays.Length);
            fixed (VertexArrayHandle* arrays_ptr = arrays)
            {
                GenVertexArrays(n, arrays_ptr);
            }
        }
        /// <summary> Generate vertex array object names. </summary>
        /// <param name="n"> Specifies the number of vertex array object names to generate. </param>
        /// <param name="arrays"> Specifies an array in which the generated vertex array object names are stored. </param>
        public static unsafe void GenVertexArrays(int n, ref VertexArrayHandle arrays)
        {
            fixed (VertexArrayHandle* arrays_ptr = &arrays)
            {
                GenVertexArrays(n, arrays_ptr);
            }
        }
        /// <summary> Return the value or values of a selected parameter. </summary>
        /// <param name="target"> Specifies the parameter value to be returned for indexed versions of glGet. The symbolic constants in the list below are accepted. </param>
        /// <param name="index"> Specifies the index of the particular element being queried. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        public static unsafe void GetInteger(GetPName target, uint index, Span<int> data)
        {
            fixed (int* data_ptr = data)
            {
                GetIntegeri_v(target, index, data_ptr);
            }
        }
        /// <summary> Return the value or values of a selected parameter. </summary>
        /// <param name="target"> Specifies the parameter value to be returned for indexed versions of glGet. The symbolic constants in the list below are accepted. </param>
        /// <param name="index"> Specifies the index of the particular element being queried. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        public static unsafe void GetInteger(GetPName target, uint index, int[] data)
        {
            fixed (int* data_ptr = data)
            {
                GetIntegeri_v(target, index, data_ptr);
            }
        }
        /// <summary> Return the value or values of a selected parameter. </summary>
        /// <param name="target"> Specifies the parameter value to be returned for indexed versions of glGet. The symbolic constants in the list below are accepted. </param>
        /// <param name="index"> Specifies the index of the particular element being queried. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        public static unsafe void GetInteger(GetPName target, uint index, ref int data)
        {
            fixed (int* data_ptr = &data)
            {
                GetIntegeri_v(target, index, data_ptr);
            }
        }
        /// <summary> Retrieve information about varying variables selected for transform feedback. </summary>
        /// <param name="program"> The name of the target program object. </param>
        /// <param name="index"> The index of the varying variable whose information to retrieve. </param>
        /// <param name="bufSize"> The maximum number of characters, including the null terminator, that may be written into name. </param>
        /// <param name="length"> The address of a variable which will receive the number of characters written into name, excluding the null-terminator. If length is NULL no length is returned. </param>
        /// <param name="size"> The address of a variable that will receive the size of the varying. </param>
        /// <param name="type"> The address of a variable that will receive the type of the varying. </param>
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
        /// <summary> Retrieve information about varying variables selected for transform feedback. </summary>
        /// <param name="program"> The name of the target program object. </param>
        /// <param name="index"> The index of the varying variable whose information to retrieve. </param>
        /// <param name="bufSize"> The maximum number of characters, including the null terminator, that may be written into name. </param>
        /// <param name="length"> The address of a variable which will receive the number of characters written into name, excluding the null-terminator. If length is NULL no length is returned. </param>
        /// <param name="size"> The address of a variable that will receive the size of the varying. </param>
        /// <param name="type"> The address of a variable that will receive the type of the varying. </param>
        /// <param name="name"> The address of a buffer into which will be written the name of the varying. </param>
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
        /// <summary> Retrieve information about varying variables selected for transform feedback. </summary>
        /// <param name="program"> The name of the target program object. </param>
        /// <param name="index"> The index of the varying variable whose information to retrieve. </param>
        /// <param name="bufSize"> The maximum number of characters, including the null terminator, that may be written into name. </param>
        /// <param name="length"> The address of a variable which will receive the number of characters written into name, excluding the null-terminator. If length is NULL no length is returned. </param>
        /// <param name="size"> The address of a variable that will receive the size of the varying. </param>
        /// <param name="type"> The address of a variable that will receive the type of the varying. </param>
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
        /// <summary> Retrieve information about varying variables selected for transform feedback. </summary>
        /// <param name="program"> The name of the target program object. </param>
        /// <param name="index"> The index of the varying variable whose information to retrieve. </param>
        /// <param name="bufSize"> The maximum number of characters, including the null terminator, that may be written into name. </param>
        /// <param name="length"> The address of a variable which will receive the number of characters written into name, excluding the null-terminator. If length is NULL no length is returned. </param>
        /// <param name="size"> The address of a variable that will receive the size of the varying. </param>
        /// <param name="type"> The address of a variable that will receive the type of the varying. </param>
        /// <param name="name"> The address of a buffer into which will be written the name of the varying. </param>
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
        /// <summary> Retrieve information about varying variables selected for transform feedback. </summary>
        /// <param name="program"> The name of the target program object. </param>
        /// <param name="index"> The index of the varying variable whose information to retrieve. </param>
        /// <param name="bufSize"> The maximum number of characters, including the null terminator, that may be written into name. </param>
        /// <param name="length"> The address of a variable which will receive the number of characters written into name, excluding the null-terminator. If length is NULL no length is returned. </param>
        /// <param name="size"> The address of a variable that will receive the size of the varying. </param>
        /// <param name="type"> The address of a variable that will receive the type of the varying. </param>
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
        /// <summary> Retrieve information about varying variables selected for transform feedback. </summary>
        /// <param name="program"> The name of the target program object. </param>
        /// <param name="index"> The index of the varying variable whose information to retrieve. </param>
        /// <param name="bufSize"> The maximum number of characters, including the null terminator, that may be written into name. </param>
        /// <param name="length"> The address of a variable which will receive the number of characters written into name, excluding the null-terminator. If length is NULL no length is returned. </param>
        /// <param name="size"> The address of a variable that will receive the size of the varying. </param>
        /// <param name="type"> The address of a variable that will receive the type of the varying. </param>
        /// <param name="name"> The address of a buffer into which will be written the name of the varying. </param>
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
        /// <summary> Define an array of generic vertex attribute data. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="size">Specifies the number of components per generic vertex attribute. Must be 1, 2, 3, 4. The initial value is 4.</param>
        /// <param name="type">Specifies the data type of each component in the array. The symbolic constants GL_BYTE, GL_UNSIGNED_BYTE, GL_SHORT, GL_UNSIGNED_SHORT, GL_INT, and GL_UNSIGNED_INT are accepted by both functions. Additionally GL_HALF_FLOAT, GL_FLOAT, GL_FIXED, GL_INT_2_10_10_10_REV, and GL_UNSIGNED_INT_2_10_10_10_REV are accepted by glVertexAttribPointer. The initial value is GL_FLOAT.</param>
        /// <param name="stride"> Specifies the byte offset between consecutive generic vertex attributes. If stride is 0, the generic vertex attributes are understood to be tightly packed in the array. The initial value is 0. </param>
        public static unsafe void VertexAttribIPointer(uint index, int size, VertexAttribIType type, int stride, nint offset)
        {
            void* pointer = (void*)offset;
            VertexAttribIPointer(index, size, type, stride, pointer);
        }
        /// <summary> Return a generic vertex attribute parameter. </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be queried.</param>
        /// <param name="pname">Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are GL_CURRENT_VERTEX_ATTRIB, GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, GL_VERTEX_ATTRIB_ARRAY_ENABLED, GL_VERTEX_ATTRIB_ARRAY_SIZE, GL_VERTEX_ATTRIB_ARRAY_STRIDE, GL_VERTEX_ATTRIB_ARRAY_TYPE, GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, GL_VERTEX_ATTRIB_ARRAY_INTEGER, GL_VERTEX_ATTRIB_ARRAY_DIVISOR, or GL_VERTEX_ATTRIB_BINDING.</param>
        public static unsafe void GetVertexAttribIi(uint index, VertexAttribEnum pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetVertexAttribIiv(index, pname, parameters_ptr);
            }
        }
        /// <summary> Return a generic vertex attribute parameter. </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be queried.</param>
        /// <param name="pname">Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are GL_CURRENT_VERTEX_ATTRIB, GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, GL_VERTEX_ATTRIB_ARRAY_ENABLED, GL_VERTEX_ATTRIB_ARRAY_SIZE, GL_VERTEX_ATTRIB_ARRAY_STRIDE, GL_VERTEX_ATTRIB_ARRAY_TYPE, GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, GL_VERTEX_ATTRIB_ARRAY_INTEGER, GL_VERTEX_ATTRIB_ARRAY_DIVISOR, or GL_VERTEX_ATTRIB_BINDING.</param>
        public static unsafe void GetVertexAttribIi(uint index, VertexAttribEnum pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetVertexAttribIiv(index, pname, parameters_ptr);
            }
        }
        /// <summary> Return a generic vertex attribute parameter. </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be queried.</param>
        /// <param name="pname">Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are GL_CURRENT_VERTEX_ATTRIB, GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, GL_VERTEX_ATTRIB_ARRAY_ENABLED, GL_VERTEX_ATTRIB_ARRAY_SIZE, GL_VERTEX_ATTRIB_ARRAY_STRIDE, GL_VERTEX_ATTRIB_ARRAY_TYPE, GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, GL_VERTEX_ATTRIB_ARRAY_INTEGER, GL_VERTEX_ATTRIB_ARRAY_DIVISOR, or GL_VERTEX_ATTRIB_BINDING.</param>
        public static unsafe void GetVertexAttribIi(uint index, VertexAttribEnum pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetVertexAttribIiv(index, pname, parameters_ptr);
            }
        }
        /// <summary> Return a generic vertex attribute parameter. </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be queried.</param>
        /// <param name="pname">Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are GL_CURRENT_VERTEX_ATTRIB, GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, GL_VERTEX_ATTRIB_ARRAY_ENABLED, GL_VERTEX_ATTRIB_ARRAY_SIZE, GL_VERTEX_ATTRIB_ARRAY_STRIDE, GL_VERTEX_ATTRIB_ARRAY_TYPE, GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, GL_VERTEX_ATTRIB_ARRAY_INTEGER, GL_VERTEX_ATTRIB_ARRAY_DIVISOR, or GL_VERTEX_ATTRIB_BINDING.</param>
        public static unsafe void GetVertexAttribIui(uint index, VertexAttribEnum pname, Span<uint> parameters)
        {
            fixed (uint* parameters_ptr = parameters)
            {
                GetVertexAttribIuiv(index, pname, parameters_ptr);
            }
        }
        /// <summary> Return a generic vertex attribute parameter. </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be queried.</param>
        /// <param name="pname">Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are GL_CURRENT_VERTEX_ATTRIB, GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, GL_VERTEX_ATTRIB_ARRAY_ENABLED, GL_VERTEX_ATTRIB_ARRAY_SIZE, GL_VERTEX_ATTRIB_ARRAY_STRIDE, GL_VERTEX_ATTRIB_ARRAY_TYPE, GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, GL_VERTEX_ATTRIB_ARRAY_INTEGER, GL_VERTEX_ATTRIB_ARRAY_DIVISOR, or GL_VERTEX_ATTRIB_BINDING.</param>
        public static unsafe void GetVertexAttribIui(uint index, VertexAttribEnum pname, uint[] parameters)
        {
            fixed (uint* parameters_ptr = parameters)
            {
                GetVertexAttribIuiv(index, pname, parameters_ptr);
            }
        }
        /// <summary> Return a generic vertex attribute parameter. </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be queried.</param>
        /// <param name="pname">Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are GL_CURRENT_VERTEX_ATTRIB, GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, GL_VERTEX_ATTRIB_ARRAY_ENABLED, GL_VERTEX_ATTRIB_ARRAY_SIZE, GL_VERTEX_ATTRIB_ARRAY_STRIDE, GL_VERTEX_ATTRIB_ARRAY_TYPE, GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, GL_VERTEX_ATTRIB_ARRAY_INTEGER, GL_VERTEX_ATTRIB_ARRAY_DIVISOR, or GL_VERTEX_ATTRIB_BINDING.</param>
        public static unsafe void GetVertexAttribIui(uint index, VertexAttribEnum pname, ref uint parameters)
        {
            fixed (uint* parameters_ptr = &parameters)
            {
                GetVertexAttribIuiv(index, pname, parameters_ptr);
            }
        }
        /// <summary> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        public static unsafe void VertexAttribI4iv(uint index, ReadOnlySpan<int> v)
        {
            fixed (int* v_ptr = v)
            {
                VertexAttribI4iv(index, v_ptr);
            }
        }
        /// <summary> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        public static unsafe void VertexAttribI4iv(uint index, int[] v)
        {
            fixed (int* v_ptr = v)
            {
                VertexAttribI4iv(index, v_ptr);
            }
        }
        /// <summary> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        public static unsafe void VertexAttribI4iv(uint index, in int v)
        {
            fixed (int* v_ptr = &v)
            {
                VertexAttribI4iv(index, v_ptr);
            }
        }
        /// <summary> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        public static unsafe void VertexAttribI4ui(uint index, ReadOnlySpan<uint> v)
        {
            fixed (uint* v_ptr = v)
            {
                VertexAttribI4uiv(index, v_ptr);
            }
        }
        /// <summary> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        public static unsafe void VertexAttribI4ui(uint index, uint[] v)
        {
            fixed (uint* v_ptr = v)
            {
                VertexAttribI4uiv(index, v_ptr);
            }
        }
        /// <summary> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        public static unsafe void VertexAttribI4ui(uint index, in uint v)
        {
            fixed (uint* v_ptr = &v)
            {
                VertexAttribI4uiv(index, v_ptr);
            }
        }
        /// <summary> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        public static unsafe void GetUniformui(ProgramHandle program, int location, Span<uint> parameters)
        {
            fixed (uint* parameters_ptr = parameters)
            {
                GetUniformuiv(program, location, parameters_ptr);
            }
        }
        /// <summary> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        public static unsafe void GetUniformui(ProgramHandle program, int location, uint[] parameters)
        {
            fixed (uint* parameters_ptr = parameters)
            {
                GetUniformuiv(program, location, parameters_ptr);
            }
        }
        /// <summary> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        public static unsafe void GetUniformui(ProgramHandle program, int location, ref uint parameters)
        {
            fixed (uint* parameters_ptr = &parameters)
            {
                GetUniformuiv(program, location, parameters_ptr);
            }
        }
        /// <summary> Query the bindings of color numbers to user-defined varying out variables. </summary>
        /// <param name="program"> The name of the program containing varying out variable whose binding to query </param>
        /// <param name="name"> The name of the user-defined varying out variable whose binding to query </param>
        public static unsafe int GetFragDataLocation(ProgramHandle program, string name)
        {
            int returnValue;
            byte* name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(name);
            returnValue = GetFragDataLocation(program, name_ptr);
            Marshal.FreeCoTaskMem((IntPtr)name_ptr);
            return returnValue;
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void Uniform1ui(int location, ReadOnlySpan<uint> value)
        {
            int count = (int)(value.Length / 1);
            fixed (uint* value_ptr = value)
            {
                Uniform1uiv(location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void Uniform1ui(int location, uint[] value)
        {
            int count = (int)(value.Length / 1);
            fixed (uint* value_ptr = value)
            {
                Uniform1uiv(location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void Uniform1ui(int location, int count, in uint value)
        {
            fixed (uint* value_ptr = &value)
            {
                Uniform1uiv(location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void Uniform2ui(int location, ReadOnlySpan<uint> value)
        {
            int count = (int)(value.Length / 2);
            fixed (uint* value_ptr = value)
            {
                Uniform2uiv(location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void Uniform2ui(int location, uint[] value)
        {
            int count = (int)(value.Length / 2);
            fixed (uint* value_ptr = value)
            {
                Uniform2uiv(location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void Uniform2ui(int location, int count, in uint value)
        {
            fixed (uint* value_ptr = &value)
            {
                Uniform2uiv(location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void Uniform3ui(int location, ReadOnlySpan<uint> value)
        {
            int count = (int)(value.Length / 3);
            fixed (uint* value_ptr = value)
            {
                Uniform3uiv(location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void Uniform3ui(int location, uint[] value)
        {
            int count = (int)(value.Length / 3);
            fixed (uint* value_ptr = value)
            {
                Uniform3uiv(location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void Uniform3ui(int location, int count, in uint value)
        {
            fixed (uint* value_ptr = &value)
            {
                Uniform3uiv(location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void Uniform4ui(int location, ReadOnlySpan<uint> value)
        {
            int count = (int)(value.Length / 4);
            fixed (uint* value_ptr = value)
            {
                Uniform4uiv(location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void Uniform4ui(int location, uint[] value)
        {
            int count = (int)(value.Length / 4);
            fixed (uint* value_ptr = value)
            {
                Uniform4uiv(location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void Uniform4ui(int location, int count, in uint value)
        {
            fixed (uint* value_ptr = &value)
            {
                Uniform4uiv(location, count, value_ptr);
            }
        }
        /// <summary> Clear individual buffers of the currently bound draw framebuffer. </summary>
        /// <param name="buffer"> Specify the buffer to clear. </param>
        /// <param name="value"> For color buffers, a pointer to a four-element vector specifying R, G, B and A values to clear the buffer to. For depth buffers, a pointer to a single depth value to clear the buffer to. For stencil buffers, a pointer to a single stencil value to clear the buffer to. </param>
        public static unsafe void ClearBufferi(Buffer buffer, int drawbuffer, ReadOnlySpan<int> value)
        {
            fixed (int* value_ptr = value)
            {
                ClearBufferiv(buffer, drawbuffer, value_ptr);
            }
        }
        /// <summary> Clear individual buffers of the currently bound draw framebuffer. </summary>
        /// <param name="buffer"> Specify the buffer to clear. </param>
        /// <param name="value"> For color buffers, a pointer to a four-element vector specifying R, G, B and A values to clear the buffer to. For depth buffers, a pointer to a single depth value to clear the buffer to. For stencil buffers, a pointer to a single stencil value to clear the buffer to. </param>
        public static unsafe void ClearBufferi(Buffer buffer, int drawbuffer, int[] value)
        {
            fixed (int* value_ptr = value)
            {
                ClearBufferiv(buffer, drawbuffer, value_ptr);
            }
        }
        /// <summary> Clear individual buffers of the currently bound draw framebuffer. </summary>
        /// <param name="buffer"> Specify the buffer to clear. </param>
        /// <param name="value"> For color buffers, a pointer to a four-element vector specifying R, G, B and A values to clear the buffer to. For depth buffers, a pointer to a single depth value to clear the buffer to. For stencil buffers, a pointer to a single stencil value to clear the buffer to. </param>
        public static unsafe void ClearBufferi(Buffer buffer, int drawbuffer, in int value)
        {
            fixed (int* value_ptr = &value)
            {
                ClearBufferiv(buffer, drawbuffer, value_ptr);
            }
        }
        /// <summary> Clear individual buffers of the currently bound draw framebuffer. </summary>
        /// <param name="buffer"> Specify the buffer to clear. </param>
        /// <param name="value"> For color buffers, a pointer to a four-element vector specifying R, G, B and A values to clear the buffer to. For depth buffers, a pointer to a single depth value to clear the buffer to. For stencil buffers, a pointer to a single stencil value to clear the buffer to. </param>
        public static unsafe void ClearBufferui(Buffer buffer, int drawbuffer, ReadOnlySpan<uint> value)
        {
            fixed (uint* value_ptr = value)
            {
                ClearBufferuiv(buffer, drawbuffer, value_ptr);
            }
        }
        /// <summary> Clear individual buffers of the currently bound draw framebuffer. </summary>
        /// <param name="buffer"> Specify the buffer to clear. </param>
        /// <param name="value"> For color buffers, a pointer to a four-element vector specifying R, G, B and A values to clear the buffer to. For depth buffers, a pointer to a single depth value to clear the buffer to. For stencil buffers, a pointer to a single stencil value to clear the buffer to. </param>
        public static unsafe void ClearBufferui(Buffer buffer, int drawbuffer, uint[] value)
        {
            fixed (uint* value_ptr = value)
            {
                ClearBufferuiv(buffer, drawbuffer, value_ptr);
            }
        }
        /// <summary> Clear individual buffers of the currently bound draw framebuffer. </summary>
        /// <param name="buffer"> Specify the buffer to clear. </param>
        /// <param name="value"> For color buffers, a pointer to a four-element vector specifying R, G, B and A values to clear the buffer to. For depth buffers, a pointer to a single depth value to clear the buffer to. For stencil buffers, a pointer to a single stencil value to clear the buffer to. </param>
        public static unsafe void ClearBufferui(Buffer buffer, int drawbuffer, in uint value)
        {
            fixed (uint* value_ptr = &value)
            {
                ClearBufferuiv(buffer, drawbuffer, value_ptr);
            }
        }
        /// <summary> Clear individual buffers of the currently bound draw framebuffer. </summary>
        /// <param name="buffer"> Specify the buffer to clear. </param>
        /// <param name="value"> For color buffers, a pointer to a four-element vector specifying R, G, B and A values to clear the buffer to. For depth buffers, a pointer to a single depth value to clear the buffer to. For stencil buffers, a pointer to a single stencil value to clear the buffer to. </param>
        public static unsafe void ClearBufferf(Buffer buffer, int drawbuffer, ReadOnlySpan<float> value)
        {
            fixed (float* value_ptr = value)
            {
                ClearBufferfv(buffer, drawbuffer, value_ptr);
            }
        }
        /// <summary> Clear individual buffers of the currently bound draw framebuffer. </summary>
        /// <param name="buffer"> Specify the buffer to clear. </param>
        /// <param name="value"> For color buffers, a pointer to a four-element vector specifying R, G, B and A values to clear the buffer to. For depth buffers, a pointer to a single depth value to clear the buffer to. For stencil buffers, a pointer to a single stencil value to clear the buffer to. </param>
        public static unsafe void ClearBufferf(Buffer buffer, int drawbuffer, float[] value)
        {
            fixed (float* value_ptr = value)
            {
                ClearBufferfv(buffer, drawbuffer, value_ptr);
            }
        }
        /// <summary> Clear individual buffers of the currently bound draw framebuffer. </summary>
        /// <param name="buffer"> Specify the buffer to clear. </param>
        /// <param name="value"> For color buffers, a pointer to a four-element vector specifying R, G, B and A values to clear the buffer to. For depth buffers, a pointer to a single depth value to clear the buffer to. For stencil buffers, a pointer to a single stencil value to clear the buffer to. </param>
        public static unsafe void ClearBufferf(Buffer buffer, int drawbuffer, in float value)
        {
            fixed (float* value_ptr = &value)
            {
                ClearBufferfv(buffer, drawbuffer, value_ptr);
            }
        }
        /// <summary> Clear individual buffers of the currently bound draw framebuffer. </summary>
        /// <param name="buffer"> Specify the buffer to clear. </param>
        /// <param name="depth"> The value to clear a depth render buffer to. </param>
        /// <param name="stencil"> The value to clear a stencil render buffer to. </param>
        public static unsafe void ClearBuffer(Buffer buffer, int drawbuffer, float depth, int stencil)
        {
            ClearBufferfi(buffer, drawbuffer, depth, stencil);
        }
        /// <summary> Return a string describing the current GL connection. </summary>
        /// <param name="name"> Specifies a symbolic constant, one of GL_EXTENSIONS, GL_RENDERER, GL_SHADING_LANGUAGE_VERSION, GL_VENDOR, or GL_VERSION. glGetStringi accepts only the GL_EXTENSIONS token. </param>
        /// <param name="index"> For glGetStringi, specifies the index of the string to return. </param>
        public static unsafe string? GetStringi(StringName name, uint index)
        {
            byte* returnValue;
            string? returnValue_str;
            returnValue = GetStringi_(name, index);
            returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
            return returnValue_str;
        }
        /// <summary> Retrieve the index of a named uniform block. </summary>
        /// <param name="program"> Specifies the name of a program containing uniforms whose indices to query. </param>
        /// <param name="uniformCount"> Specifies the number of uniforms whose indices to query. </param>
        /// <param name="uniformNames"> Specifies the address of an array of pointers to buffers containing the names of the queried uniforms. </param>
        /// <param name="uniformIndices"> Specifies the address of an array that will receive the indices of the uniforms. </param>
        public static unsafe void GetUniformIndices(ProgramHandle program, int uniformCount, byte** uniformNames, Span<uint> uniformIndices)
        {
            fixed (uint* uniformIndices_ptr = uniformIndices)
            {
                GetUniformIndices(program, uniformCount, uniformNames, uniformIndices_ptr);
            }
        }
        /// <summary> Retrieve the index of a named uniform block. </summary>
        /// <param name="program"> Specifies the name of a program containing uniforms whose indices to query. </param>
        /// <param name="uniformCount"> Specifies the number of uniforms whose indices to query. </param>
        /// <param name="uniformNames"> Specifies the address of an array of pointers to buffers containing the names of the queried uniforms. </param>
        /// <param name="uniformIndices"> Specifies the address of an array that will receive the indices of the uniforms. </param>
        public static unsafe void GetUniformIndices(ProgramHandle program, int uniformCount, byte** uniformNames, uint[] uniformIndices)
        {
            fixed (uint* uniformIndices_ptr = uniformIndices)
            {
                GetUniformIndices(program, uniformCount, uniformNames, uniformIndices_ptr);
            }
        }
        /// <summary> Retrieve the index of a named uniform block. </summary>
        /// <param name="program"> Specifies the name of a program containing uniforms whose indices to query. </param>
        /// <param name="uniformCount"> Specifies the number of uniforms whose indices to query. </param>
        /// <param name="uniformNames"> Specifies the address of an array of pointers to buffers containing the names of the queried uniforms. </param>
        /// <param name="uniformIndices"> Specifies the address of an array that will receive the indices of the uniforms. </param>
        public static unsafe void GetUniformIndices(ProgramHandle program, int uniformCount, byte** uniformNames, ref uint uniformIndices)
        {
            fixed (uint* uniformIndices_ptr = &uniformIndices)
            {
                GetUniformIndices(program, uniformCount, uniformNames, uniformIndices_ptr);
            }
        }
        /// <summary> Returns information about several active uniform variables for the specified program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="uniformIndices">Specifies the address of an array of uniformCount integers containing the indices of uniforms within program whose parameter pname should be queried.</param>
        /// <param name="pname">Specifies the property of each uniform in uniformIndices that should be written into the corresponding element of params.</param>
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
        /// <summary> Returns information about several active uniform variables for the specified program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="uniformIndices">Specifies the address of an array of uniformCount integers containing the indices of uniforms within program whose parameter pname should be queried.</param>
        /// <param name="pname">Specifies the property of each uniform in uniformIndices that should be written into the corresponding element of params.</param>
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
        /// <summary> Returns information about several active uniform variables for the specified program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="uniformCount">Specifies both the number of elements in the array of indices uniformIndices and the number of parameters written to params upon successful return.</param>
        /// <param name="uniformIndices">Specifies the address of an array of uniformCount integers containing the indices of uniforms within program whose parameter pname should be queried.</param>
        /// <param name="pname">Specifies the property of each uniform in uniformIndices that should be written into the corresponding element of params.</param>
        public static unsafe void GetActiveUniformsi(ProgramHandle program, int uniformCount, in uint uniformIndices, UniformPName pname, ref int parameters)
        {
            fixed (uint* uniformIndices_ptr = &uniformIndices)
            fixed (int* parameters_ptr = &parameters)
            {
                GetActiveUniformsiv(program, uniformCount, uniformIndices_ptr, pname, parameters_ptr);
            }
        }
        /// <summary> Retrieve the index of a named uniform block. </summary>
        /// <param name="program"> Specifies the name of a program containing the uniform block. </param>
        /// <param name="uniformBlockName"> Specifies the address an array of characters containing the name of the uniform block whose index to retrieve. </param>
        public static unsafe uint GetUniformBlockIndex(ProgramHandle program, string uniformBlockName)
        {
            uint returnValue;
            byte* uniformBlockName_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(uniformBlockName);
            returnValue = GetUniformBlockIndex(program, uniformBlockName_ptr);
            Marshal.FreeCoTaskMem((IntPtr)uniformBlockName_ptr);
            return returnValue;
        }
        /// <summary> Query information about an active uniform block. </summary>
        /// <param name="program"> Specifies the name of a program containing the uniform block. </param>
        /// <param name="uniformBlockIndex"> Specifies the index of the uniform block within program. </param>
        /// <param name="pname"> Specifies the name of the parameter to query. </param>
        public static unsafe void GetActiveUniformBlocki(ProgramHandle program, uint uniformBlockIndex, UniformBlockPName pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetActiveUniformBlockiv(program, uniformBlockIndex, pname, parameters_ptr);
            }
        }
        /// <summary> Query information about an active uniform block. </summary>
        /// <param name="program"> Specifies the name of a program containing the uniform block. </param>
        /// <param name="uniformBlockIndex"> Specifies the index of the uniform block within program. </param>
        /// <param name="pname"> Specifies the name of the parameter to query. </param>
        public static unsafe void GetActiveUniformBlocki(ProgramHandle program, uint uniformBlockIndex, UniformBlockPName pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetActiveUniformBlockiv(program, uniformBlockIndex, pname, parameters_ptr);
            }
        }
        /// <summary> Query information about an active uniform block. </summary>
        /// <param name="program"> Specifies the name of a program containing the uniform block. </param>
        /// <param name="uniformBlockIndex"> Specifies the index of the uniform block within program. </param>
        /// <param name="pname"> Specifies the name of the parameter to query. </param>
        public static unsafe void GetActiveUniformBlocki(ProgramHandle program, uint uniformBlockIndex, UniformBlockPName pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetActiveUniformBlockiv(program, uniformBlockIndex, pname, parameters_ptr);
            }
        }
        /// <summary> Retrieve the name of an active uniform block. </summary>
        /// <param name="program"> Specifies the name of a program containing the uniform block. </param>
        /// <param name="uniformBlockIndex"> Specifies the index of the uniform block within program. </param>
        /// <param name="bufSize"> Specifies the size of the buffer addressed by uniformBlockName. </param>
        /// <param name="length"> Specifies the address of a variable to receive the number of characters that were written to uniformBlockName. </param>
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
        /// <summary> Retrieve the name of an active uniform block. </summary>
        /// <param name="program"> Specifies the name of a program containing the uniform block. </param>
        /// <param name="uniformBlockIndex"> Specifies the index of the uniform block within program. </param>
        /// <param name="bufSize"> Specifies the size of the buffer addressed by uniformBlockName. </param>
        /// <param name="length"> Specifies the address of a variable to receive the number of characters that were written to uniformBlockName. </param>
        /// <param name="uniformBlockName"> Specifies the address an array of characters to receive the name of the uniform block at uniformBlockIndex. </param>
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
        /// <summary> Retrieve the name of an active uniform block. </summary>
        /// <param name="program"> Specifies the name of a program containing the uniform block. </param>
        /// <param name="uniformBlockIndex"> Specifies the index of the uniform block within program. </param>
        /// <param name="bufSize"> Specifies the size of the buffer addressed by uniformBlockName. </param>
        /// <param name="length"> Specifies the address of a variable to receive the number of characters that were written to uniformBlockName. </param>
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
        /// <summary> Retrieve the name of an active uniform block. </summary>
        /// <param name="program"> Specifies the name of a program containing the uniform block. </param>
        /// <param name="uniformBlockIndex"> Specifies the index of the uniform block within program. </param>
        /// <param name="bufSize"> Specifies the size of the buffer addressed by uniformBlockName. </param>
        /// <param name="length"> Specifies the address of a variable to receive the number of characters that were written to uniformBlockName. </param>
        /// <param name="uniformBlockName"> Specifies the address an array of characters to receive the name of the uniform block at uniformBlockIndex. </param>
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
        /// <summary> Retrieve the name of an active uniform block. </summary>
        /// <param name="program"> Specifies the name of a program containing the uniform block. </param>
        /// <param name="uniformBlockIndex"> Specifies the index of the uniform block within program. </param>
        /// <param name="bufSize"> Specifies the size of the buffer addressed by uniformBlockName. </param>
        /// <param name="length"> Specifies the address of a variable to receive the number of characters that were written to uniformBlockName. </param>
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
        /// <summary> Retrieve the name of an active uniform block. </summary>
        /// <param name="program"> Specifies the name of a program containing the uniform block. </param>
        /// <param name="uniformBlockIndex"> Specifies the index of the uniform block within program. </param>
        /// <param name="bufSize"> Specifies the size of the buffer addressed by uniformBlockName. </param>
        /// <param name="length"> Specifies the address of a variable to receive the number of characters that were written to uniformBlockName. </param>
        /// <param name="uniformBlockName"> Specifies the address an array of characters to receive the name of the uniform block at uniformBlockIndex. </param>
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
        /// <summary> Draw multiple instances of a set of elements. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="count"> Specifies the number of elements to be rendered. </param>
        /// <param name="type"> Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT. </param>
        public static unsafe void DrawElementsInstanced(PrimitiveType mode, int count, DrawElementsType type, nint offset, int instancecount)
        {
            void* indices = (void*)offset;
            DrawElementsInstanced(mode, count, type, indices, instancecount);
        }
        /// <summary> Return the value or values of a selected parameter. </summary>
        /// <param name="pname"> Specifies the parameter value to be returned. The symbolic constants in the list below are accepted. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        public static unsafe void GetInteger64(GetPName pname, Span<long> data)
        {
            fixed (long* data_ptr = data)
            {
                GetInteger64v(pname, data_ptr);
            }
        }
        /// <summary> Return the value or values of a selected parameter. </summary>
        /// <param name="pname"> Specifies the parameter value to be returned. The symbolic constants in the list below are accepted. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        public static unsafe void GetInteger64(GetPName pname, long[] data)
        {
            fixed (long* data_ptr = data)
            {
                GetInteger64v(pname, data_ptr);
            }
        }
        /// <summary> Return the value or values of a selected parameter. </summary>
        /// <param name="pname"> Specifies the parameter value to be returned. The symbolic constants in the list below are accepted. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        public static unsafe void GetInteger64(GetPName pname, ref long data)
        {
            fixed (long* data_ptr = &data)
            {
                GetInteger64v(pname, data_ptr);
            }
        }
        /// <summary> Query the properties of a sync object. </summary>
        /// <param name="sync"> Specifies the sync object whose properties to query. </param>
        /// <param name="pname"> Specifies the parameter whose value to retrieve from the sync object specified in sync. </param>
        /// <param name="length"> Specifies the address of an variable to receive the number of integers placed in values. </param>
        /// <param name="values"> Specifies the address of an array to receive the values of the queried parameter. </param>
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
        /// <summary> Query the properties of a sync object. </summary>
        /// <param name="sync"> Specifies the sync object whose properties to query. </param>
        /// <param name="pname"> Specifies the parameter whose value to retrieve from the sync object specified in sync. </param>
        /// <param name="length"> Specifies the address of an variable to receive the number of integers placed in values. </param>
        /// <param name="values"> Specifies the address of an array to receive the values of the queried parameter. </param>
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
        /// <summary> Query the properties of a sync object. </summary>
        /// <param name="sync"> Specifies the sync object whose properties to query. </param>
        /// <param name="pname"> Specifies the parameter whose value to retrieve from the sync object specified in sync. </param>
        /// <param name="length"> Specifies the address of an variable to receive the number of integers placed in values. </param>
        /// <param name="values"> Specifies the address of an array to receive the values of the queried parameter. </param>
        public static unsafe void GetSynci(GLSync sync, SyncParameterName pname, int count, ref int length, ref int values)
        {
            fixed (int* length_ptr = &length)
            fixed (int* values_ptr = &values)
            {
                GetSynciv(sync, pname, count, length_ptr, values_ptr);
            }
        }
        /// <summary> Return the value or values of a selected parameter. </summary>
        /// <param name="target"> Specifies the parameter value to be returned for indexed versions of glGet. The symbolic constants in the list below are accepted. </param>
        /// <param name="index"> Specifies the index of the particular element being queried. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        public static unsafe void GetInteger64(GetPName target, uint index, Span<long> data)
        {
            fixed (long* data_ptr = data)
            {
                GetInteger64i_v(target, index, data_ptr);
            }
        }
        /// <summary> Return the value or values of a selected parameter. </summary>
        /// <param name="target"> Specifies the parameter value to be returned for indexed versions of glGet. The symbolic constants in the list below are accepted. </param>
        /// <param name="index"> Specifies the index of the particular element being queried. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        public static unsafe void GetInteger64(GetPName target, uint index, long[] data)
        {
            fixed (long* data_ptr = data)
            {
                GetInteger64i_v(target, index, data_ptr);
            }
        }
        /// <summary> Return the value or values of a selected parameter. </summary>
        /// <param name="target"> Specifies the parameter value to be returned for indexed versions of glGet. The symbolic constants in the list below are accepted. </param>
        /// <param name="index"> Specifies the index of the particular element being queried. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        public static unsafe void GetInteger64(GetPName target, uint index, ref long data)
        {
            fixed (long* data_ptr = &data)
            {
                GetInteger64i_v(target, index, data_ptr);
            }
        }
        /// <summary> Return parameters of a buffer object. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glGetBufferParameteriv and glGetBufferParameteri64v. Must be one of the buffer binding targets in the following table: </param>
        public static unsafe void GetBufferParameteri64(BufferTargetARB target, BufferPNameARB pname, Span<long> parameters)
        {
            fixed (long* parameters_ptr = parameters)
            {
                GetBufferParameteri64v(target, pname, parameters_ptr);
            }
        }
        /// <summary> Return parameters of a buffer object. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glGetBufferParameteriv and glGetBufferParameteri64v. Must be one of the buffer binding targets in the following table: </param>
        public static unsafe void GetBufferParameteri64(BufferTargetARB target, BufferPNameARB pname, long[] parameters)
        {
            fixed (long* parameters_ptr = parameters)
            {
                GetBufferParameteri64v(target, pname, parameters_ptr);
            }
        }
        /// <summary> Return parameters of a buffer object. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glGetBufferParameteriv and glGetBufferParameteri64v. Must be one of the buffer binding targets in the following table: </param>
        public static unsafe void GetBufferParameteri64(BufferTargetARB target, BufferPNameARB pname, ref long parameters)
        {
            fixed (long* parameters_ptr = &parameters)
            {
                GetBufferParameteri64v(target, pname, parameters_ptr);
            }
        }
        /// <summary> Generate sampler object names. </summary>
        public static unsafe SamplerHandle GenSampler()
        {
            SamplerHandle samplers;
            int count = 1;
            Unsafe.SkipInit(out samplers);
            // FIXME: This could be a problem for the overloads that take an out parameter
            // as this parameter could *potentially* move while inside of this function
            // which would mean that the new value never gets written to the out parameter.
            // Making for a nasty bug.
            // The reason we don't use a fixed expression here is because of the "single out parameter to return value" overloading step
            // that will make it so this tries to fix a local variable which is not allowed in C# for some reason.
            // If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk
            // - 2021-05-18
            SamplerHandle* samplers_handle = (SamplerHandle*)Unsafe.AsPointer(ref samplers);
            GenSamplers(count, samplers_handle);
            return samplers;
        }
        /// <summary> Generate sampler object names. </summary>
        /// <param name="samplers"> Specifies an array in which the generated sampler object names are stored. </param>
        public static unsafe void GenSampler(out SamplerHandle samplers)
        {
            int count = 1;
            Unsafe.SkipInit(out samplers);
            // FIXME: This could be a problem for the overloads that take an out parameter
            // as this parameter could *potentially* move while inside of this function
            // which would mean that the new value never gets written to the out parameter.
            // Making for a nasty bug.
            // The reason we don't use a fixed expression here is because of the "single out parameter to return value" overloading step
            // that will make it so this tries to fix a local variable which is not allowed in C# for some reason.
            // If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk
            // - 2021-05-18
            SamplerHandle* samplers_handle = (SamplerHandle*)Unsafe.AsPointer(ref samplers);
            GenSamplers(count, samplers_handle);
        }
        /// <summary> Generate sampler object names. </summary>
        /// <param name="samplers"> Specifies an array in which the generated sampler object names are stored. </param>
        public static unsafe void GenSamplers(Span<SamplerHandle> samplers)
        {
            int count = (int)(samplers.Length);
            fixed (SamplerHandle* samplers_ptr = samplers)
            {
                GenSamplers(count, samplers_ptr);
            }
        }
        /// <summary> Generate sampler object names. </summary>
        /// <param name="samplers"> Specifies an array in which the generated sampler object names are stored. </param>
        public static unsafe void GenSamplers(SamplerHandle[] samplers)
        {
            int count = (int)(samplers.Length);
            fixed (SamplerHandle* samplers_ptr = samplers)
            {
                GenSamplers(count, samplers_ptr);
            }
        }
        /// <summary> Generate sampler object names. </summary>
        /// <param name="samplers"> Specifies an array in which the generated sampler object names are stored. </param>
        public static unsafe void GenSamplers(int count, ref SamplerHandle samplers)
        {
            fixed (SamplerHandle* samplers_ptr = &samplers)
            {
                GenSamplers(count, samplers_ptr);
            }
        }
        /// <summary> Delete named sampler objects. </summary>
        /// <param name="samplers"> Specifies an array of sampler objects to be deleted. </param>
        public static unsafe void DeleteSampler(in SamplerHandle samplers)
        {
            int count = 1;
            fixed(SamplerHandle* samplers_handle = &samplers)
            {
                DeleteSamplers(count, samplers_handle);
            }
        }
        /// <summary> Delete named sampler objects. </summary>
        /// <param name="samplers"> Specifies an array of sampler objects to be deleted. </param>
        public static unsafe void DeleteSamplers(ReadOnlySpan<SamplerHandle> samplers)
        {
            int count = (int)(samplers.Length);
            fixed (SamplerHandle* samplers_ptr = samplers)
            {
                DeleteSamplers(count, samplers_ptr);
            }
        }
        /// <summary> Delete named sampler objects. </summary>
        /// <param name="samplers"> Specifies an array of sampler objects to be deleted. </param>
        public static unsafe void DeleteSamplers(SamplerHandle[] samplers)
        {
            int count = (int)(samplers.Length);
            fixed (SamplerHandle* samplers_ptr = samplers)
            {
                DeleteSamplers(count, samplers_ptr);
            }
        }
        /// <summary> Delete named sampler objects. </summary>
        /// <param name="samplers"> Specifies an array of sampler objects to be deleted. </param>
        public static unsafe void DeleteSamplers(int count, in SamplerHandle samplers)
        {
            fixed (SamplerHandle* samplers_ptr = &samplers)
            {
                DeleteSamplers(count, samplers_ptr);
            }
        }
        /// <summary> Set sampler parameters. </summary>
        /// <param name="sampler"> Specifies the sampler object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued sampler parameter. pname can be one of the following: GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC. </param>
        public static unsafe void SamplerParameteri(SamplerHandle sampler, SamplerParameterI pname, ReadOnlySpan<int> param)
        {
            fixed (int* param_ptr = param)
            {
                SamplerParameteriv(sampler, pname, param_ptr);
            }
        }
        /// <summary> Set sampler parameters. </summary>
        /// <param name="sampler"> Specifies the sampler object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued sampler parameter. pname can be one of the following: GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC. </param>
        public static unsafe void SamplerParameteri(SamplerHandle sampler, SamplerParameterI pname, int[] param)
        {
            fixed (int* param_ptr = param)
            {
                SamplerParameteriv(sampler, pname, param_ptr);
            }
        }
        /// <summary> Set sampler parameters. </summary>
        /// <param name="sampler"> Specifies the sampler object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued sampler parameter. pname can be one of the following: GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC. </param>
        public static unsafe void SamplerParameteri(SamplerHandle sampler, SamplerParameterI pname, in int param)
        {
            fixed (int* param_ptr = &param)
            {
                SamplerParameteriv(sampler, pname, param_ptr);
            }
        }
        /// <summary> Set sampler parameters. </summary>
        /// <param name="sampler"> Specifies the sampler object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued sampler parameter. pname can be one of the following: GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC. </param>
        public static unsafe void SamplerParameterf(SamplerHandle sampler, SamplerParameterF pname, ReadOnlySpan<float> param)
        {
            fixed (float* param_ptr = param)
            {
                SamplerParameterfv(sampler, pname, param_ptr);
            }
        }
        /// <summary> Set sampler parameters. </summary>
        /// <param name="sampler"> Specifies the sampler object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued sampler parameter. pname can be one of the following: GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC. </param>
        public static unsafe void SamplerParameterf(SamplerHandle sampler, SamplerParameterF pname, float[] param)
        {
            fixed (float* param_ptr = param)
            {
                SamplerParameterfv(sampler, pname, param_ptr);
            }
        }
        /// <summary> Set sampler parameters. </summary>
        /// <param name="sampler"> Specifies the sampler object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued sampler parameter. pname can be one of the following: GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC. </param>
        public static unsafe void SamplerParameterf(SamplerHandle sampler, SamplerParameterF pname, in float param)
        {
            fixed (float* param_ptr = &param)
            {
                SamplerParameterfv(sampler, pname, param_ptr);
            }
        }
        /// <summary> Return sampler parameter values. </summary>
        /// <param name="sampler"> Specifies name of the sampler object from which to retrieve parameters. </param>
        /// <param name="pname"> Specifies the symbolic name of a sampler parameter. GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        public static unsafe void GetSamplerParameteri(SamplerHandle sampler, SamplerParameterI pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetSamplerParameteriv(sampler, pname, parameters_ptr);
            }
        }
        /// <summary> Return sampler parameter values. </summary>
        /// <param name="sampler"> Specifies name of the sampler object from which to retrieve parameters. </param>
        /// <param name="pname"> Specifies the symbolic name of a sampler parameter. GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        public static unsafe void GetSamplerParameteri(SamplerHandle sampler, SamplerParameterI pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetSamplerParameteriv(sampler, pname, parameters_ptr);
            }
        }
        /// <summary> Return sampler parameter values. </summary>
        /// <param name="sampler"> Specifies name of the sampler object from which to retrieve parameters. </param>
        /// <param name="pname"> Specifies the symbolic name of a sampler parameter. GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        public static unsafe void GetSamplerParameteri(SamplerHandle sampler, SamplerParameterI pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetSamplerParameteriv(sampler, pname, parameters_ptr);
            }
        }
        /// <summary> Return sampler parameter values. </summary>
        /// <param name="sampler"> Specifies name of the sampler object from which to retrieve parameters. </param>
        /// <param name="pname"> Specifies the symbolic name of a sampler parameter. GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        public static unsafe void GetSamplerParameterf(SamplerHandle sampler, SamplerParameterF pname, Span<float> parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetSamplerParameterfv(sampler, pname, parameters_ptr);
            }
        }
        /// <summary> Return sampler parameter values. </summary>
        /// <param name="sampler"> Specifies name of the sampler object from which to retrieve parameters. </param>
        /// <param name="pname"> Specifies the symbolic name of a sampler parameter. GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        public static unsafe void GetSamplerParameterf(SamplerHandle sampler, SamplerParameterF pname, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetSamplerParameterfv(sampler, pname, parameters_ptr);
            }
        }
        /// <summary> Return sampler parameter values. </summary>
        /// <param name="sampler"> Specifies name of the sampler object from which to retrieve parameters. </param>
        /// <param name="pname"> Specifies the symbolic name of a sampler parameter. GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        public static unsafe void GetSamplerParameterf(SamplerHandle sampler, SamplerParameterF pname, ref float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                GetSamplerParameterfv(sampler, pname, parameters_ptr);
            }
        }
        /// <summary> Delete transform feedback objects. </summary>
        /// <param name="ids"> Specifies an array of names of transform feedback objects to delete. </param>
        public static unsafe void DeleteTransformFeedback(in TransformFeedbackHandle ids)
        {
            int n = 1;
            fixed(TransformFeedbackHandle* ids_handle = &ids)
            {
                DeleteTransformFeedbacks(n, ids_handle);
            }
        }
        /// <summary> Delete transform feedback objects. </summary>
        /// <param name="ids"> Specifies an array of names of transform feedback objects to delete. </param>
        public static unsafe void DeleteTransformFeedbacks(ReadOnlySpan<TransformFeedbackHandle> ids)
        {
            int n = (int)(ids.Length);
            fixed (TransformFeedbackHandle* ids_ptr = ids)
            {
                DeleteTransformFeedbacks(n, ids_ptr);
            }
        }
        /// <summary> Delete transform feedback objects. </summary>
        /// <param name="ids"> Specifies an array of names of transform feedback objects to delete. </param>
        public static unsafe void DeleteTransformFeedbacks(TransformFeedbackHandle[] ids)
        {
            int n = (int)(ids.Length);
            fixed (TransformFeedbackHandle* ids_ptr = ids)
            {
                DeleteTransformFeedbacks(n, ids_ptr);
            }
        }
        /// <summary> Delete transform feedback objects. </summary>
        /// <param name="n"> Specifies the number of transform feedback objects to delete. </param>
        /// <param name="ids"> Specifies an array of names of transform feedback objects to delete. </param>
        public static unsafe void DeleteTransformFeedbacks(int n, in TransformFeedbackHandle ids)
        {
            fixed (TransformFeedbackHandle* ids_ptr = &ids)
            {
                DeleteTransformFeedbacks(n, ids_ptr);
            }
        }
        /// <summary> Reserve transform feedback object names. </summary>
        public static unsafe TransformFeedbackHandle GenTransformFeedback()
        {
            TransformFeedbackHandle ids;
            int n = 1;
            Unsafe.SkipInit(out ids);
            // FIXME: This could be a problem for the overloads that take an out parameter
            // as this parameter could *potentially* move while inside of this function
            // which would mean that the new value never gets written to the out parameter.
            // Making for a nasty bug.
            // The reason we don't use a fixed expression here is because of the "single out parameter to return value" overloading step
            // that will make it so this tries to fix a local variable which is not allowed in C# for some reason.
            // If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk
            // - 2021-05-18
            TransformFeedbackHandle* ids_handle = (TransformFeedbackHandle*)Unsafe.AsPointer(ref ids);
            GenTransformFeedbacks(n, ids_handle);
            return ids;
        }
        /// <summary> Reserve transform feedback object names. </summary>
        /// <param name="ids"> Specifies an array of into which the reserved names will be written. </param>
        public static unsafe void GenTransformFeedback(out TransformFeedbackHandle ids)
        {
            int n = 1;
            Unsafe.SkipInit(out ids);
            // FIXME: This could be a problem for the overloads that take an out parameter
            // as this parameter could *potentially* move while inside of this function
            // which would mean that the new value never gets written to the out parameter.
            // Making for a nasty bug.
            // The reason we don't use a fixed expression here is because of the "single out parameter to return value" overloading step
            // that will make it so this tries to fix a local variable which is not allowed in C# for some reason.
            // If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk
            // - 2021-05-18
            TransformFeedbackHandle* ids_handle = (TransformFeedbackHandle*)Unsafe.AsPointer(ref ids);
            GenTransformFeedbacks(n, ids_handle);
        }
        /// <summary> Reserve transform feedback object names. </summary>
        /// <param name="ids"> Specifies an array of into which the reserved names will be written. </param>
        public static unsafe void GenTransformFeedbacks(Span<TransformFeedbackHandle> ids)
        {
            int n = (int)(ids.Length);
            fixed (TransformFeedbackHandle* ids_ptr = ids)
            {
                GenTransformFeedbacks(n, ids_ptr);
            }
        }
        /// <summary> Reserve transform feedback object names. </summary>
        /// <param name="ids"> Specifies an array of into which the reserved names will be written. </param>
        public static unsafe void GenTransformFeedbacks(TransformFeedbackHandle[] ids)
        {
            int n = (int)(ids.Length);
            fixed (TransformFeedbackHandle* ids_ptr = ids)
            {
                GenTransformFeedbacks(n, ids_ptr);
            }
        }
        /// <summary> Reserve transform feedback object names. </summary>
        /// <param name="n"> Specifies the number of transform feedback object names to reserve. </param>
        /// <param name="ids"> Specifies an array of into which the reserved names will be written. </param>
        public static unsafe void GenTransformFeedbacks(int n, ref TransformFeedbackHandle ids)
        {
            fixed (TransformFeedbackHandle* ids_ptr = &ids)
            {
                GenTransformFeedbacks(n, ids_ptr);
            }
        }
        /// <summary> Return a binary representation of a program object's compiled and linked executable source. </summary>
        /// <param name="program"> Specifies the name of a program object whose binary representation to retrieve. </param>
        /// <param name="length"> Specifies the address of a variable to receive the number of bytes written into binary. </param>
        /// <param name="binaryFormat"> Specifies the address of a variable to receive a token indicating the format of the binary data returned by the GL. </param>
        /// <param name="binary"> Specifies the address an array into which the GL will return program's binary representation. </param>
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
        /// <summary> Return a binary representation of a program object's compiled and linked executable source. </summary>
        /// <param name="program"> Specifies the name of a program object whose binary representation to retrieve. </param>
        /// <param name="length"> Specifies the address of a variable to receive the number of bytes written into binary. </param>
        /// <param name="binaryFormat"> Specifies the address of a variable to receive a token indicating the format of the binary data returned by the GL. </param>
        /// <param name="binary"> Specifies the address an array into which the GL will return program's binary representation. </param>
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
        /// <summary> Return a binary representation of a program object's compiled and linked executable source. </summary>
        /// <param name="program"> Specifies the name of a program object whose binary representation to retrieve. </param>
        /// <param name="length"> Specifies the address of a variable to receive the number of bytes written into binary. </param>
        /// <param name="binaryFormat"> Specifies the address of a variable to receive a token indicating the format of the binary data returned by the GL. </param>
        /// <param name="binary"> Specifies the address an array into which the GL will return program's binary representation. </param>
        public static unsafe void GetProgramBinary(ProgramHandle program, int bufSize, ref int length, ref All binaryFormat, IntPtr binary)
        {
            fixed (int* length_ptr = &length)
            fixed (All* binaryFormat_ptr = &binaryFormat)
            {
                void* binary_vptr = (void*)binary;
                GetProgramBinary(program, bufSize, length_ptr, binaryFormat_ptr, binary_vptr);
            }
        }
        /// <summary> Return a binary representation of a program object's compiled and linked executable source. </summary>
        /// <param name="program"> Specifies the name of a program object whose binary representation to retrieve. </param>
        /// <param name="length"> Specifies the address of a variable to receive the number of bytes written into binary. </param>
        /// <param name="binaryFormat"> Specifies the address of a variable to receive a token indicating the format of the binary data returned by the GL. </param>
        /// <param name="binary"> Specifies the address an array into which the GL will return program's binary representation. </param>
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
        /// <summary> Return a binary representation of a program object's compiled and linked executable source. </summary>
        /// <param name="program"> Specifies the name of a program object whose binary representation to retrieve. </param>
        /// <param name="length"> Specifies the address of a variable to receive the number of bytes written into binary. </param>
        /// <param name="binaryFormat"> Specifies the address of a variable to receive a token indicating the format of the binary data returned by the GL. </param>
        /// <param name="binary"> Specifies the address an array into which the GL will return program's binary representation. </param>
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
        /// <summary> Return a binary representation of a program object's compiled and linked executable source. </summary>
        /// <param name="program"> Specifies the name of a program object whose binary representation to retrieve. </param>
        /// <param name="length"> Specifies the address of a variable to receive the number of bytes written into binary. </param>
        /// <param name="binaryFormat"> Specifies the address of a variable to receive a token indicating the format of the binary data returned by the GL. </param>
        /// <param name="binary"> Specifies the address an array into which the GL will return program's binary representation. </param>
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
        /// <summary> Load a program object with a program binary. </summary>
        /// <param name="program"> Specifies the name of a program object into which to load a program binary. </param>
        /// <param name="binaryFormat"> Specifies the format of the binary data in binary. </param>
        /// <param name="binary"> Specifies the address of an array containing the binary to be loaded into program. </param>
        /// <param name="length"> Specifies the number of bytes contained in binary. </param>
        public static unsafe void ProgramBinary(ProgramHandle program, All binaryFormat, IntPtr binary, int length)
        {
            void* binary_vptr = (void*)binary;
            ProgramBinary(program, binaryFormat, binary_vptr, length);
        }
        /// <summary> Load a program object with a program binary. </summary>
        /// <param name="program"> Specifies the name of a program object into which to load a program binary. </param>
        /// <param name="binaryFormat"> Specifies the format of the binary data in binary. </param>
        /// <param name="binary"> Specifies the address of an array containing the binary to be loaded into program. </param>
        public static unsafe void ProgramBinary<T1>(ProgramHandle program, All binaryFormat, ReadOnlySpan<T1> binary)
            where T1 : unmanaged
        {
            int length = (int)(binary.Length * sizeof(T1));
            fixed (void* binary_ptr = binary)
            {
                ProgramBinary(program, binaryFormat, binary_ptr, length);
            }
        }
        /// <summary> Load a program object with a program binary. </summary>
        /// <param name="program"> Specifies the name of a program object into which to load a program binary. </param>
        /// <param name="binaryFormat"> Specifies the format of the binary data in binary. </param>
        /// <param name="binary"> Specifies the address of an array containing the binary to be loaded into program. </param>
        public static unsafe void ProgramBinary<T1>(ProgramHandle program, All binaryFormat, T1[] binary)
            where T1 : unmanaged
        {
            int length = (int)(binary.Length * sizeof(T1));
            fixed (void* binary_ptr = binary)
            {
                ProgramBinary(program, binaryFormat, binary_ptr, length);
            }
        }
        /// <summary> Load a program object with a program binary. </summary>
        /// <param name="program"> Specifies the name of a program object into which to load a program binary. </param>
        /// <param name="binaryFormat"> Specifies the format of the binary data in binary. </param>
        /// <param name="binary"> Specifies the address of an array containing the binary to be loaded into program. </param>
        /// <param name="length"> Specifies the number of bytes contained in binary. </param>
        public static unsafe void ProgramBinary<T1>(ProgramHandle program, All binaryFormat, in T1 binary, int length)
            where T1 : unmanaged
        {
            fixed (void* binary_ptr = &binary)
            {
                ProgramBinary(program, binaryFormat, binary_ptr, length);
            }
        }
        /// <summary> Invalidate the contents of attachments within a framebuffer. </summary>
        /// <param name="target"> Specifies the target of the invalidate operation. </param>
        /// <param name="attachments"> A list of numAttachments attachments to invalidate. </param>
        public static unsafe void InvalidateFramebuffer(FramebufferTarget target, ReadOnlySpan<InvalidateFramebufferAttachment> attachments)
        {
            int numAttachments = (int)(attachments.Length);
            fixed (InvalidateFramebufferAttachment* attachments_ptr = attachments)
            {
                InvalidateFramebuffer(target, numAttachments, attachments_ptr);
            }
        }
        /// <summary> Invalidate the contents of attachments within a framebuffer. </summary>
        /// <param name="target"> Specifies the target of the invalidate operation. </param>
        /// <param name="attachments"> A list of numAttachments attachments to invalidate. </param>
        public static unsafe void InvalidateFramebuffer(FramebufferTarget target, InvalidateFramebufferAttachment[] attachments)
        {
            int numAttachments = (int)(attachments.Length);
            fixed (InvalidateFramebufferAttachment* attachments_ptr = attachments)
            {
                InvalidateFramebuffer(target, numAttachments, attachments_ptr);
            }
        }
        /// <summary> Invalidate the contents of attachments within a framebuffer. </summary>
        /// <param name="target"> Specifies the target of the invalidate operation. </param>
        /// <param name="numAttachments"> Specifies how many attachments are supplied in the attachments list. </param>
        /// <param name="attachments"> A list of numAttachments attachments to invalidate. </param>
        public static unsafe void InvalidateFramebuffer(FramebufferTarget target, int numAttachments, in InvalidateFramebufferAttachment attachments)
        {
            fixed (InvalidateFramebufferAttachment* attachments_ptr = &attachments)
            {
                InvalidateFramebuffer(target, numAttachments, attachments_ptr);
            }
        }
        /// <summary> Invalidate portions of the contents of attachments within a framebuffer. </summary>
        /// <param name="target"> Specifies the target of the invalidate operation. </param>
        /// <param name="attachments"> A list of numAttachments attachments to invalidate. </param>
        /// <param name="x"> Specifies the left origin of the pixel rectangle to invalidate, with lower left hand corner at (0,0). </param>
        /// <param name="y"> Specifies the bottom origin of the pixel rectangle to invalidate, with lower left hand corner at (0,0). </param>
        /// <param name="width"> Specifies the width of the pixel rectangle to invalidate. </param>
        /// <param name="height"> Specifies the height of the pixel rectangle to invalidate. </param>
        public static unsafe void InvalidateSubFramebuffer(FramebufferTarget target, ReadOnlySpan<InvalidateFramebufferAttachment> attachments, int x, int y, int width, int height)
        {
            int numAttachments = (int)(attachments.Length);
            fixed (InvalidateFramebufferAttachment* attachments_ptr = attachments)
            {
                InvalidateSubFramebuffer(target, numAttachments, attachments_ptr, x, y, width, height);
            }
        }
        /// <summary> Invalidate portions of the contents of attachments within a framebuffer. </summary>
        /// <param name="target"> Specifies the target of the invalidate operation. </param>
        /// <param name="attachments"> A list of numAttachments attachments to invalidate. </param>
        /// <param name="x"> Specifies the left origin of the pixel rectangle to invalidate, with lower left hand corner at (0,0). </param>
        /// <param name="y"> Specifies the bottom origin of the pixel rectangle to invalidate, with lower left hand corner at (0,0). </param>
        /// <param name="width"> Specifies the width of the pixel rectangle to invalidate. </param>
        /// <param name="height"> Specifies the height of the pixel rectangle to invalidate. </param>
        public static unsafe void InvalidateSubFramebuffer(FramebufferTarget target, InvalidateFramebufferAttachment[] attachments, int x, int y, int width, int height)
        {
            int numAttachments = (int)(attachments.Length);
            fixed (InvalidateFramebufferAttachment* attachments_ptr = attachments)
            {
                InvalidateSubFramebuffer(target, numAttachments, attachments_ptr, x, y, width, height);
            }
        }
        /// <summary> Invalidate portions of the contents of attachments within a framebuffer. </summary>
        /// <param name="target"> Specifies the target of the invalidate operation. </param>
        /// <param name="numAttachments"> Specifies how many attachments are supplied in the attachments list. </param>
        /// <param name="attachments"> A list of numAttachments attachments to invalidate. </param>
        /// <param name="x"> Specifies the left origin of the pixel rectangle to invalidate, with lower left hand corner at (0,0). </param>
        /// <param name="y"> Specifies the bottom origin of the pixel rectangle to invalidate, with lower left hand corner at (0,0). </param>
        /// <param name="width"> Specifies the width of the pixel rectangle to invalidate. </param>
        /// <param name="height"> Specifies the height of the pixel rectangle to invalidate. </param>
        public static unsafe void InvalidateSubFramebuffer(FramebufferTarget target, int numAttachments, in InvalidateFramebufferAttachment attachments, int x, int y, int width, int height)
        {
            fixed (InvalidateFramebufferAttachment* attachments_ptr = &attachments)
            {
                InvalidateSubFramebuffer(target, numAttachments, attachments_ptr, x, y, width, height);
            }
        }
        /// <summary> Retrieve information about implementation-dependent support for internal formats. </summary>
        /// <param name="target"> Indicates the usage of the internal format. target must be GL_RENDERBUFFER, GL_TEXTURE_2D_MULTISAMPLE, or GL_TEXTURE_2D_MULTISAMPLE_ARRAY. </param>
        /// <param name="internalformat"> Specifies the internal format about which to retrieve information. </param>
        /// <param name="pname"> Specifies the type of information to query. </param>
        public static unsafe void GetInternalformati(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, Span<int> parameters)
        {
            int count = (int)(parameters.Length);
            fixed (int* parameters_ptr = parameters)
            {
                GetInternalformativ(target, internalformat, pname, count, parameters_ptr);
            }
        }
        /// <summary> Retrieve information about implementation-dependent support for internal formats. </summary>
        /// <param name="target"> Indicates the usage of the internal format. target must be GL_RENDERBUFFER, GL_TEXTURE_2D_MULTISAMPLE, or GL_TEXTURE_2D_MULTISAMPLE_ARRAY. </param>
        /// <param name="internalformat"> Specifies the internal format about which to retrieve information. </param>
        /// <param name="pname"> Specifies the type of information to query. </param>
        public static unsafe void GetInternalformati(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, int[] parameters)
        {
            int count = (int)(parameters.Length);
            fixed (int* parameters_ptr = parameters)
            {
                GetInternalformativ(target, internalformat, pname, count, parameters_ptr);
            }
        }
        /// <summary> Retrieve information about implementation-dependent support for internal formats. </summary>
        /// <param name="target"> Indicates the usage of the internal format. target must be GL_RENDERBUFFER, GL_TEXTURE_2D_MULTISAMPLE, or GL_TEXTURE_2D_MULTISAMPLE_ARRAY. </param>
        /// <param name="internalformat"> Specifies the internal format about which to retrieve information. </param>
        /// <param name="pname"> Specifies the type of information to query. </param>
        public static unsafe void GetInternalformati(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, int count, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetInternalformativ(target, internalformat, pname, count, parameters_ptr);
            }
        }
        /// <summary> Render primitives from array data, taking parameters from memory. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="indirect"> Specifies the address of a structure containing the draw parameters. </param>
        public static unsafe void DrawArraysIndirect(PrimitiveType mode, IntPtr indirect)
        {
            void* indirect_vptr = (void*)indirect;
            DrawArraysIndirect(mode, indirect_vptr);
        }
        /// <summary> Render primitives from array data, taking parameters from memory. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="indirect"> Specifies the address of a structure containing the draw parameters. </param>
        public static unsafe void DrawArraysIndirect<T1>(PrimitiveType mode, in T1 indirect)
            where T1 : unmanaged
        {
            fixed (void* indirect_ptr = &indirect)
            {
                DrawArraysIndirect(mode, indirect_ptr);
            }
        }
        /// <summary> Render indexed primitives from array data, taking parameters from memory. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted. </param>
        /// <param name="type"> Specifies the type of data in the buffer bound to the GL_ELEMENT_ARRAY_BUFFER binding. </param>
        /// <param name="indirect"> Specifies the address of a structure containing the draw parameters. </param>
        public static unsafe void DrawElementsIndirect(PrimitiveType mode, DrawElementsType type, IntPtr indirect)
        {
            void* indirect_vptr = (void*)indirect;
            DrawElementsIndirect(mode, type, indirect_vptr);
        }
        /// <summary> Render indexed primitives from array data, taking parameters from memory. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted. </param>
        /// <param name="type"> Specifies the type of data in the buffer bound to the GL_ELEMENT_ARRAY_BUFFER binding. </param>
        /// <param name="indirect"> Specifies the address of a structure containing the draw parameters. </param>
        public static unsafe void DrawElementsIndirect<T1>(PrimitiveType mode, DrawElementsType type, in T1 indirect)
            where T1 : unmanaged
        {
            fixed (void* indirect_ptr = &indirect)
            {
                DrawElementsIndirect(mode, type, indirect_ptr);
            }
        }
        /// <summary> Retrieve a named parameter from a framebuffer. </summary>
        /// <param name="target"> The target of the operation, which must be GL_READ_FRAMEBUFFER, GL_DRAW_FRAMEBUFFER or GL_FRAMEBUFFER. </param>
        /// <param name="pname"> A token indicating the parameter to be retrieved. </param>
        public static unsafe void GetFramebufferParameteri(FramebufferTarget target, FramebufferAttachmentParameterName pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetFramebufferParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Retrieve a named parameter from a framebuffer. </summary>
        /// <param name="target"> The target of the operation, which must be GL_READ_FRAMEBUFFER, GL_DRAW_FRAMEBUFFER or GL_FRAMEBUFFER. </param>
        /// <param name="pname"> A token indicating the parameter to be retrieved. </param>
        public static unsafe void GetFramebufferParameteri(FramebufferTarget target, FramebufferAttachmentParameterName pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetFramebufferParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Retrieve a named parameter from a framebuffer. </summary>
        /// <param name="target"> The target of the operation, which must be GL_READ_FRAMEBUFFER, GL_DRAW_FRAMEBUFFER or GL_FRAMEBUFFER. </param>
        /// <param name="pname"> A token indicating the parameter to be retrieved. </param>
        public static unsafe void GetFramebufferParameteri(FramebufferTarget target, FramebufferAttachmentParameterName pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetFramebufferParameteriv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Query a property of an interface in a program. </summary>
        /// <param name="program"> The name of a program object whose interface to query. </param>
        /// <param name="programInterface"> A token identifying the interface within program to query. </param>
        /// <param name="pname"> The name of the parameter within programInterface to query. </param>
        public static unsafe void GetProgramInterfacei(ProgramHandle program, ProgramInterface programInterface, ProgramInterfacePName pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetProgramInterfaceiv(program, programInterface, pname, parameters_ptr);
            }
        }
        /// <summary> Query a property of an interface in a program. </summary>
        /// <param name="program"> The name of a program object whose interface to query. </param>
        /// <param name="programInterface"> A token identifying the interface within program to query. </param>
        /// <param name="pname"> The name of the parameter within programInterface to query. </param>
        public static unsafe void GetProgramInterfacei(ProgramHandle program, ProgramInterface programInterface, ProgramInterfacePName pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetProgramInterfaceiv(program, programInterface, pname, parameters_ptr);
            }
        }
        /// <summary> Query a property of an interface in a program. </summary>
        /// <param name="program"> The name of a program object whose interface to query. </param>
        /// <param name="programInterface"> A token identifying the interface within program to query. </param>
        /// <param name="pname"> The name of the parameter within programInterface to query. </param>
        public static unsafe void GetProgramInterfacei(ProgramHandle program, ProgramInterface programInterface, ProgramInterfacePName pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetProgramInterfaceiv(program, programInterface, pname, parameters_ptr);
            }
        }
        /// <summary> Query the index of a named resource within a program. </summary>
        /// <param name="program"> The name of a program object whose resources to query. </param>
        /// <param name="programInterface"> A token identifying the interface within program containing the resource named name. </param>
        /// <param name="name"> The name of the resource to query the index of. </param>
        public static unsafe uint GetProgramResourceIndex(ProgramHandle program, ProgramInterface programInterface, string name)
        {
            uint returnValue;
            byte* name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(name);
            returnValue = GetProgramResourceIndex(program, programInterface, name_ptr);
            Marshal.FreeCoTaskMem((IntPtr)name_ptr);
            return returnValue;
        }
        /// <summary> Query the name of an indexed resource within a program. </summary>
        /// <param name="program"> The name of a program object whose resources to query. </param>
        /// <param name="programInterface"> A token identifying the interface within program containing the indexed resource. </param>
        /// <param name="index"> The index of the resource within programInterface of program. </param>
        /// <param name="bufSize"> The size of the character array whose address is given by name. </param>
        /// <param name="length"> The address of a variable which will receive the length of the resource name. </param>
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
        /// <summary> Query the name of an indexed resource within a program. </summary>
        /// <param name="program"> The name of a program object whose resources to query. </param>
        /// <param name="programInterface"> A token identifying the interface within program containing the indexed resource. </param>
        /// <param name="index"> The index of the resource within programInterface of program. </param>
        /// <param name="bufSize"> The size of the character array whose address is given by name. </param>
        /// <param name="length"> The address of a variable which will receive the length of the resource name. </param>
        /// <param name="name"> The address of a character array into which will be written the name of the resource. </param>
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
        /// <summary> Query the name of an indexed resource within a program. </summary>
        /// <param name="program"> The name of a program object whose resources to query. </param>
        /// <param name="programInterface"> A token identifying the interface within program containing the indexed resource. </param>
        /// <param name="index"> The index of the resource within programInterface of program. </param>
        /// <param name="bufSize"> The size of the character array whose address is given by name. </param>
        /// <param name="length"> The address of a variable which will receive the length of the resource name. </param>
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
        /// <summary> Query the name of an indexed resource within a program. </summary>
        /// <param name="program"> The name of a program object whose resources to query. </param>
        /// <param name="programInterface"> A token identifying the interface within program containing the indexed resource. </param>
        /// <param name="index"> The index of the resource within programInterface of program. </param>
        /// <param name="bufSize"> The size of the character array whose address is given by name. </param>
        /// <param name="length"> The address of a variable which will receive the length of the resource name. </param>
        /// <param name="name"> The address of a character array into which will be written the name of the resource. </param>
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
        /// <summary> Query the name of an indexed resource within a program. </summary>
        /// <param name="program"> The name of a program object whose resources to query. </param>
        /// <param name="programInterface"> A token identifying the interface within program containing the indexed resource. </param>
        /// <param name="index"> The index of the resource within programInterface of program. </param>
        /// <param name="bufSize"> The size of the character array whose address is given by name. </param>
        /// <param name="length"> The address of a variable which will receive the length of the resource name. </param>
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
        /// <summary> Query the name of an indexed resource within a program. </summary>
        /// <param name="program"> The name of a program object whose resources to query. </param>
        /// <param name="programInterface"> A token identifying the interface within program containing the indexed resource. </param>
        /// <param name="index"> The index of the resource within programInterface of program. </param>
        /// <param name="bufSize"> The size of the character array whose address is given by name. </param>
        /// <param name="length"> The address of a variable which will receive the length of the resource name. </param>
        /// <param name="name"> The address of a character array into which will be written the name of the resource. </param>
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
        /// <summary> Retrieve values for multiple properties of a single active resource within a program object. </summary>
        /// <param name="program"> The name of a program object whose resources to query. </param>
        /// <param name="programInterface"> A token identifying the interface within program containing the resource named name. </param>
        /// <param name="index">!!missing documentation!!</param>
        /// <param name="props">!!missing documentation!!</param>
        /// <param name="length">!!missing documentation!!</param>
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
        /// <summary> Retrieve values for multiple properties of a single active resource within a program object. </summary>
        /// <param name="program"> The name of a program object whose resources to query. </param>
        /// <param name="programInterface"> A token identifying the interface within program containing the resource named name. </param>
        /// <param name="index">!!missing documentation!!</param>
        /// <param name="props">!!missing documentation!!</param>
        /// <param name="length">!!missing documentation!!</param>
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
        /// <summary> Retrieve values for multiple properties of a single active resource within a program object. </summary>
        /// <param name="program"> The name of a program object whose resources to query. </param>
        /// <param name="programInterface"> A token identifying the interface within program containing the resource named name. </param>
        /// <param name="index">!!missing documentation!!</param>
        /// <param name="propCount">!!missing documentation!!</param>
        /// <param name="props">!!missing documentation!!</param>
        /// <param name="length">!!missing documentation!!</param>
        public static unsafe void GetProgramResourcei(ProgramHandle program, ProgramInterface programInterface, uint index, int propCount, in ProgramResourceProperty props, int count, ref int length, ref int parameters)
        {
            fixed (ProgramResourceProperty* props_ptr = &props)
            fixed (int* length_ptr = &length)
            fixed (int* parameters_ptr = &parameters)
            {
                GetProgramResourceiv(program, programInterface, index, propCount, props_ptr, count, length_ptr, parameters_ptr);
            }
        }
        /// <summary> Query the location of a named resource within a program. </summary>
        /// <param name="program"> The name of a program object whose resources to query. </param>
        /// <param name="programInterface"> A token identifying the interface within program containing the resource named name. </param>
        /// <param name="name"> The name of the resource to query the location of. </param>
        public static unsafe int GetProgramResourceLocation(ProgramHandle program, ProgramInterface programInterface, string name)
        {
            int returnValue;
            byte* name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(name);
            returnValue = GetProgramResourceLocation(program, programInterface, name_ptr);
            Marshal.FreeCoTaskMem((IntPtr)name_ptr);
            return returnValue;
        }
        /// <summary> Create a stand-alone program from an array of null-terminated source code strings. </summary>
        /// <param name="type"> Specifies the type of shader to create. </param>
        /// <param name="count"> Specifies the number of source code strings in the array strings. </param>
        /// <param name="strings"> Specifies the address of an array of pointers to source code strings from which to create the program object. </param>
        public static unsafe ProgramHandle CreateShaderProgram(ShaderType type, int count, byte** strings)
        {
            ProgramHandle returnValue;
            returnValue = CreateShaderProgramv(type, count, strings);
            return returnValue;
        }
        /// <summary> Delete program pipeline objects. </summary>
        /// <param name="pipelines"> Specifies an array of names of program pipeline objects to delete. </param>
        public static unsafe void DeleteProgramPipeline(in ProgramPipelineHandle pipelines)
        {
            int n = 1;
            fixed(ProgramPipelineHandle* pipelines_handle = &pipelines)
            {
                DeleteProgramPipelines(n, pipelines_handle);
            }
        }
        /// <summary> Delete program pipeline objects. </summary>
        /// <param name="pipelines"> Specifies an array of names of program pipeline objects to delete. </param>
        public static unsafe void DeleteProgramPipelines(ReadOnlySpan<ProgramPipelineHandle> pipelines)
        {
            int n = (int)(pipelines.Length);
            fixed (ProgramPipelineHandle* pipelines_ptr = pipelines)
            {
                DeleteProgramPipelines(n, pipelines_ptr);
            }
        }
        /// <summary> Delete program pipeline objects. </summary>
        /// <param name="pipelines"> Specifies an array of names of program pipeline objects to delete. </param>
        public static unsafe void DeleteProgramPipelines(ProgramPipelineHandle[] pipelines)
        {
            int n = (int)(pipelines.Length);
            fixed (ProgramPipelineHandle* pipelines_ptr = pipelines)
            {
                DeleteProgramPipelines(n, pipelines_ptr);
            }
        }
        /// <summary> Delete program pipeline objects. </summary>
        /// <param name="n"> Specifies the number of program pipeline objects to delete. </param>
        /// <param name="pipelines"> Specifies an array of names of program pipeline objects to delete. </param>
        public static unsafe void DeleteProgramPipelines(int n, in ProgramPipelineHandle pipelines)
        {
            fixed (ProgramPipelineHandle* pipelines_ptr = &pipelines)
            {
                DeleteProgramPipelines(n, pipelines_ptr);
            }
        }
        /// <summary> Reserve program pipeline object names. </summary>
        public static unsafe ProgramPipelineHandle GenProgramPipeline()
        {
            ProgramPipelineHandle pipelines;
            int n = 1;
            Unsafe.SkipInit(out pipelines);
            // FIXME: This could be a problem for the overloads that take an out parameter
            // as this parameter could *potentially* move while inside of this function
            // which would mean that the new value never gets written to the out parameter.
            // Making for a nasty bug.
            // The reason we don't use a fixed expression here is because of the "single out parameter to return value" overloading step
            // that will make it so this tries to fix a local variable which is not allowed in C# for some reason.
            // If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk
            // - 2021-05-18
            ProgramPipelineHandle* pipelines_handle = (ProgramPipelineHandle*)Unsafe.AsPointer(ref pipelines);
            GenProgramPipelines(n, pipelines_handle);
            return pipelines;
        }
        /// <summary> Reserve program pipeline object names. </summary>
        /// <param name="pipelines"> Specifies an array of into which the reserved names will be written. </param>
        public static unsafe void GenProgramPipeline(out ProgramPipelineHandle pipelines)
        {
            int n = 1;
            Unsafe.SkipInit(out pipelines);
            // FIXME: This could be a problem for the overloads that take an out parameter
            // as this parameter could *potentially* move while inside of this function
            // which would mean that the new value never gets written to the out parameter.
            // Making for a nasty bug.
            // The reason we don't use a fixed expression here is because of the "single out parameter to return value" overloading step
            // that will make it so this tries to fix a local variable which is not allowed in C# for some reason.
            // If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk
            // - 2021-05-18
            ProgramPipelineHandle* pipelines_handle = (ProgramPipelineHandle*)Unsafe.AsPointer(ref pipelines);
            GenProgramPipelines(n, pipelines_handle);
        }
        /// <summary> Reserve program pipeline object names. </summary>
        /// <param name="pipelines"> Specifies an array of into which the reserved names will be written. </param>
        public static unsafe void GenProgramPipelines(Span<ProgramPipelineHandle> pipelines)
        {
            int n = (int)(pipelines.Length);
            fixed (ProgramPipelineHandle* pipelines_ptr = pipelines)
            {
                GenProgramPipelines(n, pipelines_ptr);
            }
        }
        /// <summary> Reserve program pipeline object names. </summary>
        /// <param name="pipelines"> Specifies an array of into which the reserved names will be written. </param>
        public static unsafe void GenProgramPipelines(ProgramPipelineHandle[] pipelines)
        {
            int n = (int)(pipelines.Length);
            fixed (ProgramPipelineHandle* pipelines_ptr = pipelines)
            {
                GenProgramPipelines(n, pipelines_ptr);
            }
        }
        /// <summary> Reserve program pipeline object names. </summary>
        /// <param name="n"> Specifies the number of program pipeline object names to reserve. </param>
        /// <param name="pipelines"> Specifies an array of into which the reserved names will be written. </param>
        public static unsafe void GenProgramPipelines(int n, ref ProgramPipelineHandle pipelines)
        {
            fixed (ProgramPipelineHandle* pipelines_ptr = &pipelines)
            {
                GenProgramPipelines(n, pipelines_ptr);
            }
        }
        /// <summary> Retrieve properties of a program pipeline object. </summary>
        /// <param name="pipeline"> Specifies the name of a program pipeline object whose parameter retrieve. </param>
        /// <param name="pname"> Specifies the name of the parameter to retrieve. </param>
        public static unsafe void GetProgramPipelinei(ProgramPipelineHandle pipeline, PipelineParameterName pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetProgramPipelineiv(pipeline, pname, parameters_ptr);
            }
        }
        /// <summary> Retrieve properties of a program pipeline object. </summary>
        /// <param name="pipeline"> Specifies the name of a program pipeline object whose parameter retrieve. </param>
        /// <param name="pname"> Specifies the name of the parameter to retrieve. </param>
        public static unsafe void GetProgramPipelinei(ProgramPipelineHandle pipeline, PipelineParameterName pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetProgramPipelineiv(pipeline, pname, parameters_ptr);
            }
        }
        /// <summary> Retrieve properties of a program pipeline object. </summary>
        /// <param name="pipeline"> Specifies the name of a program pipeline object whose parameter retrieve. </param>
        /// <param name="pname"> Specifies the name of the parameter to retrieve. </param>
        public static unsafe void GetProgramPipelinei(ProgramPipelineHandle pipeline, PipelineParameterName pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetProgramPipelineiv(pipeline, pname, parameters_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniform1iv(ProgramHandle program, int location, ReadOnlySpan<int> value)
        {
            int count = (int)(value.Length);
            fixed (int* value_ptr = value)
            {
                ProgramUniform1iv(program, location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniform1iv(ProgramHandle program, int location, int[] value)
        {
            int count = (int)(value.Length);
            fixed (int* value_ptr = value)
            {
                ProgramUniform1iv(program, location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniform1iv(ProgramHandle program, int location, int count, in int value)
        {
            fixed (int* value_ptr = &value)
            {
                ProgramUniform1iv(program, location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniform2i(ProgramHandle program, int location, in Vector2i value)
        {
            int count = 1;
            fixed (Vector2i* tmp_vecPtr = &value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                ProgramUniform2iv(program, location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniform2i(ProgramHandle program, int location, int count, ReadOnlySpan<Vector2i> value)
        {
            fixed (Vector2i* tmp_vecPtr = value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                ProgramUniform2iv(program, location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniform2i(ProgramHandle program, int location, int count, Vector2i[] value)
        {
            fixed (Vector2i* tmp_vecPtr = value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                ProgramUniform2iv(program, location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniform3i(ProgramHandle program, int location, in Vector3i value)
        {
            int count = 1;
            fixed (Vector3i* tmp_vecPtr = &value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                ProgramUniform3iv(program, location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniform3i(ProgramHandle program, int location, int count, ReadOnlySpan<Vector3i> value)
        {
            fixed (Vector3i* tmp_vecPtr = value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                ProgramUniform3iv(program, location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniform3i(ProgramHandle program, int location, int count, Vector3i[] value)
        {
            fixed (Vector3i* tmp_vecPtr = value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                ProgramUniform3iv(program, location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniform4i(ProgramHandle program, int location, in Vector4i value)
        {
            int count = 1;
            fixed (Vector4i* tmp_vecPtr = &value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                ProgramUniform4iv(program, location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniform4i(ProgramHandle program, int location, int count, ReadOnlySpan<Vector4i> value)
        {
            fixed (Vector4i* tmp_vecPtr = value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                ProgramUniform4iv(program, location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniform4i(ProgramHandle program, int location, int count, Vector4i[] value)
        {
            fixed (Vector4i* tmp_vecPtr = value)
            {
                int* value_ptr = (int*)tmp_vecPtr;
                ProgramUniform4iv(program, location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniform1ui(ProgramHandle program, int location, ReadOnlySpan<uint> value)
        {
            int count = (int)(value.Length);
            fixed (uint* value_ptr = value)
            {
                ProgramUniform1uiv(program, location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniform1ui(ProgramHandle program, int location, uint[] value)
        {
            int count = (int)(value.Length);
            fixed (uint* value_ptr = value)
            {
                ProgramUniform1uiv(program, location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniform1ui(ProgramHandle program, int location, int count, in uint value)
        {
            fixed (uint* value_ptr = &value)
            {
                ProgramUniform1uiv(program, location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniform2ui(ProgramHandle program, int location, ReadOnlySpan<uint> value)
        {
            int count = (int)(value.Length / 2);
            fixed (uint* value_ptr = value)
            {
                ProgramUniform2uiv(program, location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniform2ui(ProgramHandle program, int location, uint[] value)
        {
            int count = (int)(value.Length / 2);
            fixed (uint* value_ptr = value)
            {
                ProgramUniform2uiv(program, location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniform2ui(ProgramHandle program, int location, int count, in uint value)
        {
            fixed (uint* value_ptr = &value)
            {
                ProgramUniform2uiv(program, location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniform3ui(ProgramHandle program, int location, ReadOnlySpan<uint> value)
        {
            int count = (int)(value.Length / 3);
            fixed (uint* value_ptr = value)
            {
                ProgramUniform3uiv(program, location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniform3ui(ProgramHandle program, int location, uint[] value)
        {
            int count = (int)(value.Length / 3);
            fixed (uint* value_ptr = value)
            {
                ProgramUniform3uiv(program, location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniform3ui(ProgramHandle program, int location, int count, in uint value)
        {
            fixed (uint* value_ptr = &value)
            {
                ProgramUniform3uiv(program, location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniform4ui(ProgramHandle program, int location, ReadOnlySpan<uint> value)
        {
            int count = (int)(value.Length / 4);
            fixed (uint* value_ptr = value)
            {
                ProgramUniform4uiv(program, location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniform4ui(ProgramHandle program, int location, uint[] value)
        {
            int count = (int)(value.Length / 4);
            fixed (uint* value_ptr = value)
            {
                ProgramUniform4uiv(program, location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniform4ui(ProgramHandle program, int location, int count, in uint value)
        {
            fixed (uint* value_ptr = &value)
            {
                ProgramUniform4uiv(program, location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniform1fv(ProgramHandle program, int location, ReadOnlySpan<float> value)
        {
            int count = (int)(value.Length);
            fixed (float* value_ptr = value)
            {
                ProgramUniform1fv(program, location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniform1fv(ProgramHandle program, int location, float[] value)
        {
            int count = (int)(value.Length);
            fixed (float* value_ptr = value)
            {
                ProgramUniform1fv(program, location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniform1fv(ProgramHandle program, int location, int count, in float value)
        {
            fixed (float* value_ptr = &value)
            {
                ProgramUniform1fv(program, location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniform2f(ProgramHandle program, int location, in Vector2 value)
        {
            int count = 1;
            fixed (Vector2* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniform2fv(program, location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniform2f(ProgramHandle program, int location, int count, ReadOnlySpan<Vector2> value)
        {
            fixed (Vector2* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniform2fv(program, location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniform2f(ProgramHandle program, int location, int count, Vector2[] value)
        {
            fixed (Vector2* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniform2fv(program, location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniform3f(ProgramHandle program, int location, in Vector3 value)
        {
            int count = 1;
            fixed (Vector3* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniform3fv(program, location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniform3f(ProgramHandle program, int location, int count, ReadOnlySpan<Vector3> value)
        {
            fixed (Vector3* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniform3fv(program, location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniform3f(ProgramHandle program, int location, int count, Vector3[] value)
        {
            fixed (Vector3* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniform3fv(program, location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniform4f(ProgramHandle program, int location, in Vector4 value)
        {
            int count = 1;
            fixed (Vector4* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniform4fv(program, location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniform4f(ProgramHandle program, int location, int count, ReadOnlySpan<Vector4> value)
        {
            fixed (Vector4* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniform4fv(program, location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniform4f(ProgramHandle program, int location, int count, Vector4[] value)
        {
            fixed (Vector4* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                ProgramUniform4fv(program, location, count, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniformMatrix2f(ProgramHandle program, int location, bool transpose, in Matrix2 value)
        {
            int count = 1;
            fixed (Matrix2* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                ProgramUniformMatrix2fv(program, location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniformMatrix2f(ProgramHandle program, int location, int count, bool transpose, ReadOnlySpan<Matrix2> value)
        {
            fixed (Matrix2* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                ProgramUniformMatrix2fv(program, location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniformMatrix2f(ProgramHandle program, int location, int count, bool transpose, Matrix2[] value)
        {
            fixed (Matrix2* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                ProgramUniformMatrix2fv(program, location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniformMatrix3f(ProgramHandle program, int location, bool transpose, in Matrix3 value)
        {
            int count = 1;
            fixed (Matrix3* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                ProgramUniformMatrix3fv(program, location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniformMatrix3f(ProgramHandle program, int location, int count, bool transpose, ReadOnlySpan<Matrix3> value)
        {
            fixed (Matrix3* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                ProgramUniformMatrix3fv(program, location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniformMatrix3f(ProgramHandle program, int location, int count, bool transpose, Matrix3[] value)
        {
            fixed (Matrix3* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                ProgramUniformMatrix3fv(program, location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniformMatrix4f(ProgramHandle program, int location, bool transpose, in Matrix4 value)
        {
            int count = 1;
            fixed (Matrix4* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                ProgramUniformMatrix4fv(program, location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniformMatrix4f(ProgramHandle program, int location, int count, bool transpose, ReadOnlySpan<Matrix4> value)
        {
            fixed (Matrix4* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                ProgramUniformMatrix4fv(program, location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniformMatrix4f(ProgramHandle program, int location, int count, bool transpose, Matrix4[] value)
        {
            fixed (Matrix4* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                ProgramUniformMatrix4fv(program, location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniformMatrix2x3f(ProgramHandle program, int location, bool transpose, in Matrix2x3 value)
        {
            int count = 1;
            fixed (Matrix2x3* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                ProgramUniformMatrix2x3fv(program, location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniformMatrix2x3f(ProgramHandle program, int location, int count, bool transpose, ReadOnlySpan<Matrix2x3> value)
        {
            fixed (Matrix2x3* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                ProgramUniformMatrix2x3fv(program, location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniformMatrix2x3f(ProgramHandle program, int location, int count, bool transpose, Matrix2x3[] value)
        {
            fixed (Matrix2x3* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                ProgramUniformMatrix2x3fv(program, location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniformMatrix3x2f(ProgramHandle program, int location, bool transpose, in Matrix3x2 value)
        {
            int count = 1;
            fixed (Matrix3x2* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                ProgramUniformMatrix3x2fv(program, location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniformMatrix3x2f(ProgramHandle program, int location, int count, bool transpose, ReadOnlySpan<Matrix3x2> value)
        {
            fixed (Matrix3x2* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                ProgramUniformMatrix3x2fv(program, location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniformMatrix3x2f(ProgramHandle program, int location, int count, bool transpose, Matrix3x2[] value)
        {
            fixed (Matrix3x2* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                ProgramUniformMatrix3x2fv(program, location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniformMatrix2x4f(ProgramHandle program, int location, bool transpose, in Matrix2x4 value)
        {
            int count = 1;
            fixed (Matrix2x4* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                ProgramUniformMatrix2x4fv(program, location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniformMatrix2x4f(ProgramHandle program, int location, int count, bool transpose, ReadOnlySpan<Matrix2x4> value)
        {
            fixed (Matrix2x4* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                ProgramUniformMatrix2x4fv(program, location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniformMatrix2x4f(ProgramHandle program, int location, int count, bool transpose, Matrix2x4[] value)
        {
            fixed (Matrix2x4* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                ProgramUniformMatrix2x4fv(program, location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniformMatrix4x2f(ProgramHandle program, int location, bool transpose, in Matrix4x2 value)
        {
            int count = 1;
            fixed (Matrix4x2* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                ProgramUniformMatrix4x2fv(program, location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniformMatrix4x2f(ProgramHandle program, int location, int count, bool transpose, ReadOnlySpan<Matrix4x2> value)
        {
            fixed (Matrix4x2* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                ProgramUniformMatrix4x2fv(program, location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniformMatrix4x2f(ProgramHandle program, int location, int count, bool transpose, Matrix4x2[] value)
        {
            fixed (Matrix4x2* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                ProgramUniformMatrix4x2fv(program, location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniformMatrix3x4f(ProgramHandle program, int location, bool transpose, in Matrix3x4 value)
        {
            int count = 1;
            fixed (Matrix3x4* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                ProgramUniformMatrix3x4fv(program, location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniformMatrix3x4f(ProgramHandle program, int location, int count, bool transpose, ReadOnlySpan<Matrix3x4> value)
        {
            fixed (Matrix3x4* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                ProgramUniformMatrix3x4fv(program, location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniformMatrix3x4f(ProgramHandle program, int location, int count, bool transpose, Matrix3x4[] value)
        {
            fixed (Matrix3x4* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                ProgramUniformMatrix3x4fv(program, location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniformMatrix4x3f(ProgramHandle program, int location, bool transpose, in Matrix4x3 value)
        {
            int count = 1;
            fixed (Matrix4x3* tmp_vecPtr = &value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                ProgramUniformMatrix4x3fv(program, location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniformMatrix4x3f(ProgramHandle program, int location, int count, bool transpose, ReadOnlySpan<Matrix4x3> value)
        {
            fixed (Matrix4x3* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                ProgramUniformMatrix4x3fv(program, location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static unsafe void ProgramUniformMatrix4x3f(ProgramHandle program, int location, int count, bool transpose, Matrix4x3[] value)
        {
            fixed (Matrix4x3* tmp_vecPtr = value)
            {
                float* value_ptr = (float*)tmp_vecPtr;
                byte transpose_byte = (byte)(transpose ? 1 : 0);
                ProgramUniformMatrix4x3fv(program, location, count, transpose_byte, value_ptr);
            }
        }
        /// <summary> Retrieve the info log string from a program pipeline object. </summary>
        /// <param name="pipeline"> Specifies the name of a program pipeline object from which to retrieve the info log. </param>
        /// <param name="bufSize"> Specifies the maximum number of characters, including the null terminator, that may be written into infoLog. </param>
        /// <param name="length"> Specifies the address of a variable into which will be written the number of characters written into infoLog. </param>
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
        /// <summary> Retrieve the info log string from a program pipeline object. </summary>
        /// <param name="pipeline"> Specifies the name of a program pipeline object from which to retrieve the info log. </param>
        /// <param name="bufSize"> Specifies the maximum number of characters, including the null terminator, that may be written into infoLog. </param>
        /// <param name="length"> Specifies the address of a variable into which will be written the number of characters written into infoLog. </param>
        /// <param name="infoLog"> Specifies the address of an array of characters into which will be written the info log for pipeline. </param>
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
        /// <summary> Retrieve the info log string from a program pipeline object. </summary>
        /// <param name="pipeline"> Specifies the name of a program pipeline object from which to retrieve the info log. </param>
        /// <param name="bufSize"> Specifies the maximum number of characters, including the null terminator, that may be written into infoLog. </param>
        /// <param name="length"> Specifies the address of a variable into which will be written the number of characters written into infoLog. </param>
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
        /// <summary> Retrieve the info log string from a program pipeline object. </summary>
        /// <param name="pipeline"> Specifies the name of a program pipeline object from which to retrieve the info log. </param>
        /// <param name="bufSize"> Specifies the maximum number of characters, including the null terminator, that may be written into infoLog. </param>
        /// <param name="length"> Specifies the address of a variable into which will be written the number of characters written into infoLog. </param>
        /// <param name="infoLog"> Specifies the address of an array of characters into which will be written the info log for pipeline. </param>
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
        /// <summary> Retrieve the info log string from a program pipeline object. </summary>
        /// <param name="pipeline"> Specifies the name of a program pipeline object from which to retrieve the info log. </param>
        /// <param name="bufSize"> Specifies the maximum number of characters, including the null terminator, that may be written into infoLog. </param>
        /// <param name="length"> Specifies the address of a variable into which will be written the number of characters written into infoLog. </param>
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
        /// <summary> Retrieve the info log string from a program pipeline object. </summary>
        /// <param name="pipeline"> Specifies the name of a program pipeline object from which to retrieve the info log. </param>
        /// <param name="bufSize"> Specifies the maximum number of characters, including the null terminator, that may be written into infoLog. </param>
        /// <param name="length"> Specifies the address of a variable into which will be written the number of characters written into infoLog. </param>
        /// <param name="infoLog"> Specifies the address of an array of characters into which will be written the info log for pipeline. </param>
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
        /// <summary> Bind a level of a texture to an image unit. </summary>
        /// <param name="unit"> Specifies the index of the image unit to which to bind the texture </param>
        /// <param name="texture"> Specifies the name of the texture to bind to the image unit. </param>
        /// <param name="level"> Specifies the level of the texture that is to be bound. </param>
        /// <param name="layered"> Specifies whether a layered texture binding is to be established. </param>
        /// <param name="layer"> If layered is GL_FALSE, specifies the layer of texture to be bound to the image unit. Ignored otherwise. </param>
        /// <param name="access"> Specifies a token indicating the type of access that will be performed on the image. </param>
        /// <param name="format"> Specifies the format that the elements of the image will be treated as for the purposes of formatted loads and stores. </param>
        public static unsafe void BindImageTexture(uint unit, TextureHandle texture, int level, bool layered, int layer, BufferAccessARB access, InternalFormat format)
        {
            byte layered_byte = (byte)(layered ? 1 : 0);
            BindImageTexture(unit, texture, level, layered_byte, layer, access, format);
        }
        /// <summary> Return the value or values of a selected parameter. </summary>
        /// <param name="target"> Specifies the parameter value to be returned for indexed versions of glGet. The symbolic constants in the list below are accepted. </param>
        /// <param name="index"> Specifies the index of the particular element being queried. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        public static unsafe void GetBoolean(BufferTargetARB target, uint index, Span<byte> data)
        {
            fixed (byte* data_ptr = data)
            {
                GetBooleani_v(target, index, data_ptr);
            }
        }
        /// <summary> Return the value or values of a selected parameter. </summary>
        /// <param name="target"> Specifies the parameter value to be returned for indexed versions of glGet. The symbolic constants in the list below are accepted. </param>
        /// <param name="index"> Specifies the index of the particular element being queried. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        public static unsafe void GetBoolean(BufferTargetARB target, uint index, byte[] data)
        {
            fixed (byte* data_ptr = data)
            {
                GetBooleani_v(target, index, data_ptr);
            }
        }
        /// <summary> Return the value or values of a selected parameter. </summary>
        /// <param name="target"> Specifies the parameter value to be returned for indexed versions of glGet. The symbolic constants in the list below are accepted. </param>
        /// <param name="index"> Specifies the index of the particular element being queried. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        public static unsafe void GetBoolean(BufferTargetARB target, uint index, ref byte data)
        {
            fixed (byte* data_ptr = &data)
            {
                GetBooleani_v(target, index, data_ptr);
            }
        }
        /// <summary> Specify storage for a two-dimensional multisample texture. </summary>
        /// <param name="target"> Specify the target of the operation. target must be GL_TEXTURE_2D_MULTISAMPLE. </param>
        /// <param name="samples"> Specify the number of samples in the texture. </param>
        /// <param name="internalformat"> Specifies the sized internal format to be used to store texture image data. </param>
        /// <param name="width"> Specifies the width of the texture, in texels. </param>
        /// <param name="height"> Specifies the height of the texture, in texels. </param>
        /// <param name="fixedsamplelocations"> Specifies whether the image will use identical sample locations and the same number of samples for all texels in the image, and the sample locations will not depend on the internal format or size of the image. </param>
        public static unsafe void TexStorage2DMultisample(TextureTarget target, int samples, SizedInternalFormat internalformat, int width, int height, bool fixedsamplelocations)
        {
            byte fixedsamplelocations_byte = (byte)(fixedsamplelocations ? 1 : 0);
            TexStorage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations_byte);
        }
        /// <summary> Retrieve the location of a sample. </summary>
        /// <param name="pname"> Specifies the sample parameter name. pname must be GL_SAMPLE_POSITION. </param>
        /// <param name="index"> Specifies the index of the sample whose position to query. </param>
        /// <param name="val"> Specifies the address of an array to receive the position of the sample. </param>
        public static unsafe void GetMultisamplef(GetMultisamplePNameNV pname, uint index, Span<float> val)
        {
            fixed (float* val_ptr = val)
            {
                GetMultisamplefv(pname, index, val_ptr);
            }
        }
        /// <summary> Retrieve the location of a sample. </summary>
        /// <param name="pname"> Specifies the sample parameter name. pname must be GL_SAMPLE_POSITION. </param>
        /// <param name="index"> Specifies the index of the sample whose position to query. </param>
        /// <param name="val"> Specifies the address of an array to receive the position of the sample. </param>
        public static unsafe void GetMultisamplef(GetMultisamplePNameNV pname, uint index, float[] val)
        {
            fixed (float* val_ptr = val)
            {
                GetMultisamplefv(pname, index, val_ptr);
            }
        }
        /// <summary> Retrieve the location of a sample. </summary>
        /// <param name="pname"> Specifies the sample parameter name. pname must be GL_SAMPLE_POSITION. </param>
        /// <param name="index"> Specifies the index of the sample whose position to query. </param>
        /// <param name="val"> Specifies the address of an array to receive the position of the sample. </param>
        public static unsafe void GetMultisamplef(GetMultisamplePNameNV pname, uint index, ref float val)
        {
            fixed (float* val_ptr = &val)
            {
                GetMultisamplefv(pname, index, val_ptr);
            }
        }
        /// <summary> Return texture parameter values for a specific level of detail. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture, one of GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, GL_TEXTURE_CUBE_MAP_ARRAY, or GL_TEXTURE_BUFFER. </param>
        /// <param name="level"> Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_TEXTURE_WIDTH, GL_TEXTURE_HEIGHT, GL_TEXTURE_DEPTH, GL_TEXTURE_INTERNAL_FORMAT, GL_TEXTURE_SAMPLES, GL_TEXTURE_FIXED_SAMPLE_LOCATIONS, GL_TEXTURE_RED_SIZE, GL_TEXTURE_GREEN_SIZE, GL_TEXTURE_BLUE_SIZE, GL_TEXTURE_ALPHA_SIZE, GL_TEXTURE_DEPTH_SIZE, GL_TEXTURE_STENCIL_SIZE, GL_TEXTURE_SHARED_SIZE, GL_TEXTURE_RED_TYPE, GL_TEXTURE_GREEN_TYPE, GL_TEXTURE_BLUE_TYPE, GL_TEXTURE_ALPHA_TYPE, GL_TEXTURE_DEPTH_TYPE, GL_TEXTURE_COMPRESSED, GL_TEXTURE_BUFFER_DATA_STORE_BINDING, GL_TEXTURE_BUFFER_OFFSET, and GL_TEXTURE_BUFFER_SIZE are accepted. </param>
        public static unsafe void GetTexLevelParameteri(TextureTarget target, int level, GetTextureParameter pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetTexLevelParameteriv(target, level, pname, parameters_ptr);
            }
        }
        /// <summary> Return texture parameter values for a specific level of detail. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture, one of GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, GL_TEXTURE_CUBE_MAP_ARRAY, or GL_TEXTURE_BUFFER. </param>
        /// <param name="level"> Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_TEXTURE_WIDTH, GL_TEXTURE_HEIGHT, GL_TEXTURE_DEPTH, GL_TEXTURE_INTERNAL_FORMAT, GL_TEXTURE_SAMPLES, GL_TEXTURE_FIXED_SAMPLE_LOCATIONS, GL_TEXTURE_RED_SIZE, GL_TEXTURE_GREEN_SIZE, GL_TEXTURE_BLUE_SIZE, GL_TEXTURE_ALPHA_SIZE, GL_TEXTURE_DEPTH_SIZE, GL_TEXTURE_STENCIL_SIZE, GL_TEXTURE_SHARED_SIZE, GL_TEXTURE_RED_TYPE, GL_TEXTURE_GREEN_TYPE, GL_TEXTURE_BLUE_TYPE, GL_TEXTURE_ALPHA_TYPE, GL_TEXTURE_DEPTH_TYPE, GL_TEXTURE_COMPRESSED, GL_TEXTURE_BUFFER_DATA_STORE_BINDING, GL_TEXTURE_BUFFER_OFFSET, and GL_TEXTURE_BUFFER_SIZE are accepted. </param>
        public static unsafe void GetTexLevelParameteri(TextureTarget target, int level, GetTextureParameter pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetTexLevelParameteriv(target, level, pname, parameters_ptr);
            }
        }
        /// <summary> Return texture parameter values for a specific level of detail. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture, one of GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, GL_TEXTURE_CUBE_MAP_ARRAY, or GL_TEXTURE_BUFFER. </param>
        /// <param name="level"> Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_TEXTURE_WIDTH, GL_TEXTURE_HEIGHT, GL_TEXTURE_DEPTH, GL_TEXTURE_INTERNAL_FORMAT, GL_TEXTURE_SAMPLES, GL_TEXTURE_FIXED_SAMPLE_LOCATIONS, GL_TEXTURE_RED_SIZE, GL_TEXTURE_GREEN_SIZE, GL_TEXTURE_BLUE_SIZE, GL_TEXTURE_ALPHA_SIZE, GL_TEXTURE_DEPTH_SIZE, GL_TEXTURE_STENCIL_SIZE, GL_TEXTURE_SHARED_SIZE, GL_TEXTURE_RED_TYPE, GL_TEXTURE_GREEN_TYPE, GL_TEXTURE_BLUE_TYPE, GL_TEXTURE_ALPHA_TYPE, GL_TEXTURE_DEPTH_TYPE, GL_TEXTURE_COMPRESSED, GL_TEXTURE_BUFFER_DATA_STORE_BINDING, GL_TEXTURE_BUFFER_OFFSET, and GL_TEXTURE_BUFFER_SIZE are accepted. </param>
        public static unsafe void GetTexLevelParameteri(TextureTarget target, int level, GetTextureParameter pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetTexLevelParameteriv(target, level, pname, parameters_ptr);
            }
        }
        /// <summary> Return texture parameter values for a specific level of detail. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture, one of GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, GL_TEXTURE_CUBE_MAP_ARRAY, or GL_TEXTURE_BUFFER. </param>
        /// <param name="level"> Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_TEXTURE_WIDTH, GL_TEXTURE_HEIGHT, GL_TEXTURE_DEPTH, GL_TEXTURE_INTERNAL_FORMAT, GL_TEXTURE_SAMPLES, GL_TEXTURE_FIXED_SAMPLE_LOCATIONS, GL_TEXTURE_RED_SIZE, GL_TEXTURE_GREEN_SIZE, GL_TEXTURE_BLUE_SIZE, GL_TEXTURE_ALPHA_SIZE, GL_TEXTURE_DEPTH_SIZE, GL_TEXTURE_STENCIL_SIZE, GL_TEXTURE_SHARED_SIZE, GL_TEXTURE_RED_TYPE, GL_TEXTURE_GREEN_TYPE, GL_TEXTURE_BLUE_TYPE, GL_TEXTURE_ALPHA_TYPE, GL_TEXTURE_DEPTH_TYPE, GL_TEXTURE_COMPRESSED, GL_TEXTURE_BUFFER_DATA_STORE_BINDING, GL_TEXTURE_BUFFER_OFFSET, and GL_TEXTURE_BUFFER_SIZE are accepted. </param>
        public static unsafe void GetTexLevelParameterf(TextureTarget target, int level, GetTextureParameter pname, Span<float> parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetTexLevelParameterfv(target, level, pname, parameters_ptr);
            }
        }
        /// <summary> Return texture parameter values for a specific level of detail. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture, one of GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, GL_TEXTURE_CUBE_MAP_ARRAY, or GL_TEXTURE_BUFFER. </param>
        /// <param name="level"> Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_TEXTURE_WIDTH, GL_TEXTURE_HEIGHT, GL_TEXTURE_DEPTH, GL_TEXTURE_INTERNAL_FORMAT, GL_TEXTURE_SAMPLES, GL_TEXTURE_FIXED_SAMPLE_LOCATIONS, GL_TEXTURE_RED_SIZE, GL_TEXTURE_GREEN_SIZE, GL_TEXTURE_BLUE_SIZE, GL_TEXTURE_ALPHA_SIZE, GL_TEXTURE_DEPTH_SIZE, GL_TEXTURE_STENCIL_SIZE, GL_TEXTURE_SHARED_SIZE, GL_TEXTURE_RED_TYPE, GL_TEXTURE_GREEN_TYPE, GL_TEXTURE_BLUE_TYPE, GL_TEXTURE_ALPHA_TYPE, GL_TEXTURE_DEPTH_TYPE, GL_TEXTURE_COMPRESSED, GL_TEXTURE_BUFFER_DATA_STORE_BINDING, GL_TEXTURE_BUFFER_OFFSET, and GL_TEXTURE_BUFFER_SIZE are accepted. </param>
        public static unsafe void GetTexLevelParameterf(TextureTarget target, int level, GetTextureParameter pname, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters)
            {
                GetTexLevelParameterfv(target, level, pname, parameters_ptr);
            }
        }
        /// <summary> Return texture parameter values for a specific level of detail. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture, one of GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, GL_TEXTURE_CUBE_MAP_ARRAY, or GL_TEXTURE_BUFFER. </param>
        /// <param name="level"> Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_TEXTURE_WIDTH, GL_TEXTURE_HEIGHT, GL_TEXTURE_DEPTH, GL_TEXTURE_INTERNAL_FORMAT, GL_TEXTURE_SAMPLES, GL_TEXTURE_FIXED_SAMPLE_LOCATIONS, GL_TEXTURE_RED_SIZE, GL_TEXTURE_GREEN_SIZE, GL_TEXTURE_BLUE_SIZE, GL_TEXTURE_ALPHA_SIZE, GL_TEXTURE_DEPTH_SIZE, GL_TEXTURE_STENCIL_SIZE, GL_TEXTURE_SHARED_SIZE, GL_TEXTURE_RED_TYPE, GL_TEXTURE_GREEN_TYPE, GL_TEXTURE_BLUE_TYPE, GL_TEXTURE_ALPHA_TYPE, GL_TEXTURE_DEPTH_TYPE, GL_TEXTURE_COMPRESSED, GL_TEXTURE_BUFFER_DATA_STORE_BINDING, GL_TEXTURE_BUFFER_OFFSET, and GL_TEXTURE_BUFFER_SIZE are accepted. </param>
        public static unsafe void GetTexLevelParameterf(TextureTarget target, int level, GetTextureParameter pname, ref float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                GetTexLevelParameterfv(target, level, pname, parameters_ptr);
            }
        }
        /// <summary> Specify the organization of vertex arrays. </summary>
        /// <param name="attribindex"> The generic vertex attribute array being described. </param>
        /// <param name="size"> The number of values per vertex that are stored in the array. </param>
        /// <param name="type"> The type of the data stored in the array. </param>
        /// <param name="normalized"> Specifies whether fixed-point data values should be normalized (GL_TRUE) or converted directly as fixed-point values (GL_FALSE) when they are accessed. This parameter is ignored if type is GL_FIXED. </param>
        /// <param name="relativeoffset"> An offset to the first element relative to the start of the vertex buffer binding. </param>
        public static unsafe void VertexAttribFormat(uint attribindex, int size, VertexAttribType type, bool normalized, uint relativeoffset)
        {
            byte normalized_byte = (byte)(normalized ? 1 : 0);
            VertexAttribFormat(attribindex, size, type, normalized_byte, relativeoffset);
        }
        /// <summary> Control the reporting of debug messages in a debug context. </summary>
        /// <param name="source"> The source of debug messages to enable or disable. </param>
        /// <param name="type"> The type of debug messages to enable or disable. </param>
        /// <param name="severity"> The severity of debug messages to enable or disable. </param>
        /// <param name="ids"> The address of an array of unsigned integers contianing the ids of the messages to enable or disable. </param>
        /// <param name="enabled"> A Boolean flag determining whether the selected messages should be enabled or disabled. </param>
        public static unsafe void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, ReadOnlySpan<uint> ids, bool enabled)
        {
            int count = (int)(ids.Length);
            fixed (uint* ids_ptr = ids)
            {
                byte enabled_byte = (byte)(enabled ? 1 : 0);
                DebugMessageControl(source, type, severity, count, ids_ptr, enabled_byte);
            }
        }
        /// <summary> Control the reporting of debug messages in a debug context. </summary>
        /// <param name="source"> The source of debug messages to enable or disable. </param>
        /// <param name="type"> The type of debug messages to enable or disable. </param>
        /// <param name="severity"> The severity of debug messages to enable or disable. </param>
        /// <param name="ids"> The address of an array of unsigned integers contianing the ids of the messages to enable or disable. </param>
        /// <param name="enabled"> A Boolean flag determining whether the selected messages should be enabled or disabled. </param>
        public static unsafe void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, uint[] ids, bool enabled)
        {
            int count = (int)(ids.Length);
            fixed (uint* ids_ptr = ids)
            {
                byte enabled_byte = (byte)(enabled ? 1 : 0);
                DebugMessageControl(source, type, severity, count, ids_ptr, enabled_byte);
            }
        }
        /// <summary> Control the reporting of debug messages in a debug context. </summary>
        /// <param name="source"> The source of debug messages to enable or disable. </param>
        /// <param name="type"> The type of debug messages to enable or disable. </param>
        /// <param name="severity"> The severity of debug messages to enable or disable. </param>
        /// <param name="count"> The length of the array ids. </param>
        /// <param name="ids"> The address of an array of unsigned integers contianing the ids of the messages to enable or disable. </param>
        /// <param name="enabled"> A Boolean flag determining whether the selected messages should be enabled or disabled. </param>
        public static unsafe void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, int count, in uint ids, bool enabled)
        {
            fixed (uint* ids_ptr = &ids)
            {
                byte enabled_byte = (byte)(enabled ? 1 : 0);
                DebugMessageControl(source, type, severity, count, ids_ptr, enabled_byte);
            }
        }
        /// <summary> Inject an application-supplied message into the debug message queue. </summary>
        /// <param name="source"> The source of the debug message to insert. </param>
        /// <param name="type"> The type of the debug message insert. </param>
        /// <param name="id"> The user-supplied identifier of the message to insert. </param>
        /// <param name="severity"> The severity of the debug messages to insert. </param>
        /// <param name="length"> The length string contained in the character array whose address is given by message. </param>
        public static unsafe void DebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, string buf)
        {
            byte* buf_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(buf);
            DebugMessageInsert(source, type, id, severity, length, buf_ptr);
            Marshal.FreeCoTaskMem((IntPtr)buf_ptr);
        }
        /// <summary> Specify a callback to receive debugging messages from the GL. </summary>
        /// <param name="callback"> The address of a callback function that will be called when a debug message is generated. </param>
        /// <param name="userParam"> A user supplied pointer that will be passed on each invocation of callback. </param>
        public static unsafe void DebugMessageCallback(GLDebugProc callback, IntPtr userParam)
        {
            void* userParam_vptr = (void*)userParam;
            IntPtr callback_ptr = Marshal.GetFunctionPointerForDelegate(callback);
            DebugMessageCallback(callback_ptr, userParam_vptr);
        }
        /// <summary> Specify a callback to receive debugging messages from the GL. </summary>
        /// <param name="callback"> The address of a callback function that will be called when a debug message is generated. </param>
        /// <param name="userParam"> A user supplied pointer that will be passed on each invocation of callback. </param>
        public static unsafe void DebugMessageCallback<T1>(GLDebugProc callback, in T1 userParam)
            where T1 : unmanaged
        {
            fixed (void* userParam_ptr = &userParam)
            {
                IntPtr callback_ptr = Marshal.GetFunctionPointerForDelegate(callback);
                DebugMessageCallback(callback_ptr, userParam_ptr);
            }
        }
        /// <summary> Retrieve messages from the debug message log. </summary>
        /// <param name="count"> The number of debug messages to retrieve from the log. </param>
        /// <param name="bufSize"> The size of the buffer whose address is given by messageLog. </param>
        /// <param name="sources"> The address of an array of variables to receive the sources of the retrieved messages. </param>
        /// <param name="types"> The address of an array of variables to receive the types of the retrieved messages. </param>
        /// <param name="ids"> The address of an array of unsigned integers to receive the ids of the retrieved messages. </param>
        /// <param name="severities"> The address of an array of variables to receive the severites of the retrieved messages. </param>
        /// <param name="lengths"> The address of an array of variables to receive the lengths of the received messages. </param>
        /// <param name="messageLog"> The address of an array of characters that will receive the messages. </param>
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
        /// <summary> Retrieve messages from the debug message log. </summary>
        /// <param name="count"> The number of debug messages to retrieve from the log. </param>
        /// <param name="bufSize"> The size of the buffer whose address is given by messageLog. </param>
        /// <param name="sources"> The address of an array of variables to receive the sources of the retrieved messages. </param>
        /// <param name="types"> The address of an array of variables to receive the types of the retrieved messages. </param>
        /// <param name="ids"> The address of an array of unsigned integers to receive the ids of the retrieved messages. </param>
        /// <param name="severities"> The address of an array of variables to receive the severites of the retrieved messages. </param>
        /// <param name="lengths"> The address of an array of variables to receive the lengths of the received messages. </param>
        /// <param name="messageLog"> The address of an array of characters that will receive the messages. </param>
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
        /// <summary> Retrieve messages from the debug message log. </summary>
        /// <param name="count"> The number of debug messages to retrieve from the log. </param>
        /// <param name="bufSize"> The size of the buffer whose address is given by messageLog. </param>
        /// <param name="sources"> The address of an array of variables to receive the sources of the retrieved messages. </param>
        /// <param name="types"> The address of an array of variables to receive the types of the retrieved messages. </param>
        /// <param name="ids"> The address of an array of unsigned integers to receive the ids of the retrieved messages. </param>
        /// <param name="severities"> The address of an array of variables to receive the severites of the retrieved messages. </param>
        /// <param name="lengths"> The address of an array of variables to receive the lengths of the received messages. </param>
        /// <param name="messageLog"> The address of an array of characters that will receive the messages. </param>
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
        /// <summary> Push a named debug group into the command stream. </summary>
        /// <param name="source"> The source of the debug message. </param>
        /// <param name="id"> The identifier of the message. </param>
        /// <param name="length"> The length of the message to be sent to the debug output stream. </param>
        /// <param name="message"> The a string containing the message to be sent to the debug output stream. </param>
        public static unsafe void PushDebugGroup(DebugSource source, uint id, int length, string message)
        {
            byte* message_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(message);
            PushDebugGroup(source, id, length, message_ptr);
            Marshal.FreeCoTaskMem((IntPtr)message_ptr);
        }
        /// <summary> Label a named object identified within a namespace. </summary>
        /// <param name="identifier"> The namespace from which the name of the object is allocated. </param>
        /// <param name="name"> The name of the object to label. </param>
        /// <param name="length"> The length of the label to be used for the object. </param>
        /// <param name="label"> The address of a string containing the label to assign to the object. </param>
        public static unsafe void ObjectLabel(ObjectIdentifier identifier, uint name, int length, string label)
        {
            byte* label_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(label);
            ObjectLabel(identifier, name, length, label_ptr);
            Marshal.FreeCoTaskMem((IntPtr)label_ptr);
        }
        /// <summary> Retrieve the label of a named object identified within a namespace. </summary>
        /// <param name="identifier"> The namespace from which the name of the object is allocated. </param>
        /// <param name="name"> The name of the object whose label to retrieve. </param>
        /// <param name="length"> The address of a variable to receive the length of the object label. </param>
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
        /// <summary> Retrieve the label of a named object identified within a namespace. </summary>
        /// <param name="identifier"> The namespace from which the name of the object is allocated. </param>
        /// <param name="name"> The name of the object whose label to retrieve. </param>
        /// <param name="length"> The address of a variable to receive the length of the object label. </param>
        /// <param name="label"> The address of a string that will receive the object label. </param>
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
        /// <summary> Retrieve the label of a named object identified within a namespace. </summary>
        /// <param name="identifier"> The namespace from which the name of the object is allocated. </param>
        /// <param name="name"> The name of the object whose label to retrieve. </param>
        /// <param name="length"> The address of a variable to receive the length of the object label. </param>
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
        /// <summary> Retrieve the label of a named object identified within a namespace. </summary>
        /// <param name="identifier"> The namespace from which the name of the object is allocated. </param>
        /// <param name="name"> The name of the object whose label to retrieve. </param>
        /// <param name="length"> The address of a variable to receive the length of the object label. </param>
        /// <param name="label"> The address of a string that will receive the object label. </param>
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
        /// <summary> Retrieve the label of a named object identified within a namespace. </summary>
        /// <param name="identifier"> The namespace from which the name of the object is allocated. </param>
        /// <param name="name"> The name of the object whose label to retrieve. </param>
        /// <param name="length"> The address of a variable to receive the length of the object label. </param>
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
        /// <summary> Retrieve the label of a named object identified within a namespace. </summary>
        /// <param name="identifier"> The namespace from which the name of the object is allocated. </param>
        /// <param name="name"> The name of the object whose label to retrieve. </param>
        /// <param name="length"> The address of a variable to receive the length of the object label. </param>
        /// <param name="label"> The address of a string that will receive the object label. </param>
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
        /// <summary> Label a sync object identified by a pointer. </summary>
        /// <param name="ptr"> A pointer identifying a sync object. </param>
        /// <param name="length"> The length of the label to be used for the object. </param>
        /// <param name="label"> The address of a string containing the label to assign to the object. </param>
        public static unsafe void ObjectPtrLabel(IntPtr ptr, int length, string label)
        {
            byte* label_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(label);
            void* ptr_vptr = (void*)ptr;
            ObjectPtrLabel(ptr_vptr, length, label_ptr);
            Marshal.FreeCoTaskMem((IntPtr)label_ptr);
        }
        /// <summary> Label a sync object identified by a pointer. </summary>
        /// <param name="ptr"> A pointer identifying a sync object. </param>
        /// <param name="length"> The length of the label to be used for the object. </param>
        /// <param name="label"> The address of a string containing the label to assign to the object. </param>
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
        /// <summary> Retrieve the label of a sync object identified by a pointer. </summary>
        /// <param name="ptr"> The name of the sync object whose label to retrieve. </param>
        /// <param name="length"> The address of a variable to receive the length of the object label. </param>
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
        /// <summary> Retrieve the label of a sync object identified by a pointer. </summary>
        /// <param name="ptr"> The name of the sync object whose label to retrieve. </param>
        /// <param name="length"> The address of a variable to receive the length of the object label. </param>
        /// <param name="label"> The address of a string that will receive the object label. </param>
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
        /// <summary> Retrieve the label of a sync object identified by a pointer. </summary>
        /// <param name="ptr"> The name of the sync object whose label to retrieve. </param>
        /// <param name="length"> The address of a variable to receive the length of the object label. </param>
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
        /// <summary> Retrieve the label of a sync object identified by a pointer. </summary>
        /// <param name="ptr"> The name of the sync object whose label to retrieve. </param>
        /// <param name="length"> The address of a variable to receive the length of the object label. </param>
        /// <param name="label"> The address of a string that will receive the object label. </param>
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
        /// <summary> Retrieve the label of a sync object identified by a pointer. </summary>
        /// <param name="ptr"> The name of the sync object whose label to retrieve. </param>
        /// <param name="length"> The address of a variable to receive the length of the object label. </param>
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
        /// <summary> Retrieve the label of a sync object identified by a pointer. </summary>
        /// <param name="ptr"> The name of the sync object whose label to retrieve. </param>
        /// <param name="length"> The address of a variable to receive the length of the object label. </param>
        /// <param name="label"> The address of a string that will receive the object label. </param>
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
        /// <summary> Retrieve the label of a sync object identified by a pointer. </summary>
        /// <param name="ptr"> The name of the sync object whose label to retrieve. </param>
        /// <param name="length"> The address of a variable to receive the length of the object label. </param>
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
        /// <summary> Retrieve the label of a sync object identified by a pointer. </summary>
        /// <param name="ptr"> The name of the sync object whose label to retrieve. </param>
        /// <param name="length"> The address of a variable to receive the length of the object label. </param>
        /// <param name="label"> The address of a string that will receive the object label. </param>
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
        /// <summary> Retrieve the label of a sync object identified by a pointer. </summary>
        /// <param name="ptr"> The name of the sync object whose label to retrieve. </param>
        /// <param name="length"> The address of a variable to receive the length of the object label. </param>
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
        /// <summary> Retrieve the label of a sync object identified by a pointer. </summary>
        /// <param name="ptr"> The name of the sync object whose label to retrieve. </param>
        /// <param name="length"> The address of a variable to receive the length of the object label. </param>
        /// <param name="label"> The address of a string that will receive the object label. </param>
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
        /// <summary> Retrieve the label of a sync object identified by a pointer. </summary>
        /// <param name="ptr"> The name of the sync object whose label to retrieve. </param>
        /// <param name="length"> The address of a variable to receive the length of the object label. </param>
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
        /// <summary> Retrieve the label of a sync object identified by a pointer. </summary>
        /// <param name="ptr"> The name of the sync object whose label to retrieve. </param>
        /// <param name="length"> The address of a variable to receive the length of the object label. </param>
        /// <param name="label"> The address of a string that will receive the object label. </param>
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
        /// <param name="pname"> Specifies the pointer to be returned. Must be one of GL_DEBUG_CALLBACK_FUNCTION or GL_DEBUG_CALLBACK_USER_PARAM. </param>
        public static unsafe void GetPointer(GetPointervPName pname, void** parameters)
        {
            GetPointerv(pname, parameters);
        }
        /// <summary> Enable and disable writing of frame buffer color components. </summary>
        public static unsafe void ColorMaski(uint index, bool r, bool g, bool b, bool a)
        {
            byte r_byte = (byte)(r ? 1 : 0);
            byte g_byte = (byte)(g ? 1 : 0);
            byte b_byte = (byte)(b ? 1 : 0);
            byte a_byte = (byte)(a ? 1 : 0);
            ColorMaski(index, r_byte, g_byte, b_byte, a_byte);
        }
        /// <summary> Render primitives from array data with a per-element offset. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_LINES_ADJACENCY, GL_LINE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, GL_TRIANGLE_STRIP_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="count"> Specifies the number of elements to be rendered. </param>
        /// <param name="type"> Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT. </param>
        /// <param name="basevertex"> Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex arrays. </param>
        public static unsafe void DrawElementsBaseVertex(PrimitiveType mode, int count, DrawElementsType type, nint offset, int basevertex)
        {
            void* indices = (void*)offset;
            DrawElementsBaseVertex(mode, count, type, indices, basevertex);
        }
        /// <summary> Render primitives from array data with a per-element offset. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_LINES_ADJACENCY, GL_LINE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, GL_TRIANGLE_STRIP_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="start"> Specifies the minimum array index contained in indices. </param>
        /// <param name="end"> Specifies the maximum array index contained in indices. </param>
        /// <param name="count"> Specifies the number of elements to be rendered. </param>
        /// <param name="type"> Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT. </param>
        /// <param name="basevertex"> Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex arrays. </param>
        public static unsafe void DrawRangeElementsBaseVertex(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, nint offset, int basevertex)
        {
            void* indices = (void*)offset;
            DrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
        }
        /// <summary> Render multiple instances of a set of primitives from array data with a per-element offset. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_LINES_ADJACENCY, GL_LINE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, GL_TRIANGLE_STRIP_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="count"> Specifies the number of elements to be rendered. </param>
        /// <param name="type"> Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT. </param>
        /// <param name="basevertex"> Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex arrays. </param>
        public static unsafe void DrawElementsInstancedBaseVertex(PrimitiveType mode, int count, DrawElementsType type, nint offset, int instancecount, int basevertex)
        {
            void* indices = (void*)offset;
            DrawElementsInstancedBaseVertex(mode, count, type, indices, instancecount, basevertex);
        }
        /// <summary> Read a block of pixels from the frame buffer. </summary>
        /// <param name="x"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
        /// <param name="y"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
        /// <param name="width"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
        /// <param name="height"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
        /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RGBA, and GL_RGBA_INTEGER. An implementation-chosen format will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_FORMAT. </param>
        /// <param name="type"> Specifies the data type of the pixel data. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_INT, GL_UNSIGNED_INT_2_10_10_10_REV, GL_INT, or GL_FLOAT. An implementation-chosen type will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_TYPE. </param>
        /// <param name="bufSize"> Specifies the size of the buffer data for glReadnPixels function. </param>
        /// <param name="data"> Returns the pixel data. </param>
        public static unsafe void ReadnPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, IntPtr data)
        {
            void* data_vptr = (void*)data;
            ReadnPixels(x, y, width, height, format, type, bufSize, data_vptr);
        }
        /// <summary> Read a block of pixels from the frame buffer. </summary>
        /// <param name="x"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
        /// <param name="y"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
        /// <param name="width"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
        /// <param name="height"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
        /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RGBA, and GL_RGBA_INTEGER. An implementation-chosen format will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_FORMAT. </param>
        /// <param name="type"> Specifies the data type of the pixel data. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_INT, GL_UNSIGNED_INT_2_10_10_10_REV, GL_INT, or GL_FLOAT. An implementation-chosen type will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_TYPE. </param>
        /// <param name="data"> Returns the pixel data. </param>
        public static unsafe void ReadnPixels<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, Span<T1> data)
            where T1 : unmanaged
        {
            int bufSize = (int)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                ReadnPixels(x, y, width, height, format, type, bufSize, data_ptr);
            }
        }
        /// <summary> Read a block of pixels from the frame buffer. </summary>
        /// <param name="x"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
        /// <param name="y"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
        /// <param name="width"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
        /// <param name="height"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
        /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RGBA, and GL_RGBA_INTEGER. An implementation-chosen format will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_FORMAT. </param>
        /// <param name="type"> Specifies the data type of the pixel data. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_INT, GL_UNSIGNED_INT_2_10_10_10_REV, GL_INT, or GL_FLOAT. An implementation-chosen type will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_TYPE. </param>
        /// <param name="data"> Returns the pixel data. </param>
        public static unsafe void ReadnPixels<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, T1[] data)
            where T1 : unmanaged
        {
            int bufSize = (int)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data)
            {
                ReadnPixels(x, y, width, height, format, type, bufSize, data_ptr);
            }
        }
        /// <summary> Read a block of pixels from the frame buffer. </summary>
        /// <param name="x"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
        /// <param name="y"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
        /// <param name="width"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
        /// <param name="height"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
        /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RGBA, and GL_RGBA_INTEGER. An implementation-chosen format will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_FORMAT. </param>
        /// <param name="type"> Specifies the data type of the pixel data. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_INT, GL_UNSIGNED_INT_2_10_10_10_REV, GL_INT, or GL_FLOAT. An implementation-chosen type will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_TYPE. </param>
        /// <param name="bufSize"> Specifies the size of the buffer data for glReadnPixels function. </param>
        /// <param name="data"> Returns the pixel data. </param>
        public static unsafe void ReadnPixels<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, ref T1 data)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = &data)
            {
                ReadnPixels(x, y, width, height, format, type, bufSize, data_ptr);
            }
        }
        /// <summary> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        public static unsafe void GetnUniformf(ProgramHandle program, int location, Span<float> parameters)
        {
            int bufSize = (int)(parameters.Length * 4);
            fixed (float* parameters_ptr = parameters)
            {
                GetnUniformfv(program, location, bufSize, parameters_ptr);
            }
        }
        /// <summary> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        public static unsafe void GetnUniformf(ProgramHandle program, int location, float[] parameters)
        {
            int bufSize = (int)(parameters.Length * 4);
            fixed (float* parameters_ptr = parameters)
            {
                GetnUniformfv(program, location, bufSize, parameters_ptr);
            }
        }
        /// <summary> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        /// <param name="bufSize">Specifies the size of the buffer params. </param>
        public static unsafe void GetnUniformf(ProgramHandle program, int location, int bufSize, ref float parameters)
        {
            fixed (float* parameters_ptr = &parameters)
            {
                GetnUniformfv(program, location, bufSize, parameters_ptr);
            }
        }
        /// <summary> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        public static unsafe void GetnUniformi(ProgramHandle program, int location, Span<int> parameters)
        {
            int bufSize = (int)(parameters.Length * 4);
            fixed (int* parameters_ptr = parameters)
            {
                GetnUniformiv(program, location, bufSize, parameters_ptr);
            }
        }
        /// <summary> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        public static unsafe void GetnUniformi(ProgramHandle program, int location, int[] parameters)
        {
            int bufSize = (int)(parameters.Length * 4);
            fixed (int* parameters_ptr = parameters)
            {
                GetnUniformiv(program, location, bufSize, parameters_ptr);
            }
        }
        /// <summary> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        /// <param name="bufSize">Specifies the size of the buffer params. </param>
        public static unsafe void GetnUniformi(ProgramHandle program, int location, int bufSize, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetnUniformiv(program, location, bufSize, parameters_ptr);
            }
        }
        /// <summary> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        public static unsafe void GetnUniformui(ProgramHandle program, int location, Span<uint> parameters)
        {
            int bufSize = (int)(parameters.Length * 4);
            fixed (uint* parameters_ptr = parameters)
            {
                GetnUniformuiv(program, location, bufSize, parameters_ptr);
            }
        }
        /// <summary> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        public static unsafe void GetnUniformui(ProgramHandle program, int location, uint[] parameters)
        {
            int bufSize = (int)(parameters.Length * 4);
            fixed (uint* parameters_ptr = parameters)
            {
                GetnUniformuiv(program, location, bufSize, parameters_ptr);
            }
        }
        /// <summary> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        /// <param name="bufSize">Specifies the size of the buffer params. </param>
        public static unsafe void GetnUniformui(ProgramHandle program, int location, int bufSize, ref uint parameters)
        {
            fixed (uint* parameters_ptr = &parameters)
            {
                GetnUniformuiv(program, location, bufSize, parameters_ptr);
            }
        }
        /// <summary> Set texture parameters. </summary>
        /// <param name="target"> Specifies the target texture, which must be either GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R. </param>
        public static unsafe void TexParameterIi(TextureTarget target, TextureParameterName pname, ReadOnlySpan<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                TexParameterIiv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Set texture parameters. </summary>
        /// <param name="target"> Specifies the target texture, which must be either GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R. </param>
        public static unsafe void TexParameterIi(TextureTarget target, TextureParameterName pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                TexParameterIiv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Set texture parameters. </summary>
        /// <param name="target"> Specifies the target texture, which must be either GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R. </param>
        public static unsafe void TexParameterIi(TextureTarget target, TextureParameterName pname, in int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                TexParameterIiv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Set texture parameters. </summary>
        /// <param name="target"> Specifies the target texture, which must be either GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R. </param>
        public static unsafe void TexParameterIui(TextureTarget target, TextureParameterName pname, ReadOnlySpan<uint> parameters)
        {
            fixed (uint* parameters_ptr = parameters)
            {
                TexParameterIuiv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Set texture parameters. </summary>
        /// <param name="target"> Specifies the target texture, which must be either GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R. </param>
        public static unsafe void TexParameterIui(TextureTarget target, TextureParameterName pname, uint[] parameters)
        {
            fixed (uint* parameters_ptr = parameters)
            {
                TexParameterIuiv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Set texture parameters. </summary>
        /// <param name="target"> Specifies the target texture, which must be either GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R. </param>
        public static unsafe void TexParameterIui(TextureTarget target, TextureParameterName pname, in uint parameters)
        {
            fixed (uint* parameters_ptr = &parameters)
            {
                TexParameterIuiv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Return texture parameter values. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture. GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE,GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        public static unsafe void GetTexParameterIi(TextureTarget target, GetTextureParameter pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetTexParameterIiv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Return texture parameter values. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture. GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE,GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        public static unsafe void GetTexParameterIi(TextureTarget target, GetTextureParameter pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetTexParameterIiv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Return texture parameter values. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture. GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE,GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        public static unsafe void GetTexParameterIi(TextureTarget target, GetTextureParameter pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetTexParameterIiv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Return texture parameter values. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture. GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE,GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        public static unsafe void GetTexParameterIui(TextureTarget target, GetTextureParameter pname, Span<uint> parameters)
        {
            fixed (uint* parameters_ptr = parameters)
            {
                GetTexParameterIuiv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Return texture parameter values. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture. GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE,GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        public static unsafe void GetTexParameterIui(TextureTarget target, GetTextureParameter pname, uint[] parameters)
        {
            fixed (uint* parameters_ptr = parameters)
            {
                GetTexParameterIuiv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Return texture parameter values. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture. GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE,GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        public static unsafe void GetTexParameterIui(TextureTarget target, GetTextureParameter pname, ref uint parameters)
        {
            fixed (uint* parameters_ptr = &parameters)
            {
                GetTexParameterIuiv(target, pname, parameters_ptr);
            }
        }
        /// <summary> Set sampler parameters. </summary>
        /// <param name="sampler"> Specifies the sampler object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued sampler parameter. pname can be one of the following: GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC. </param>
        public static unsafe void SamplerParameterIi(SamplerHandle sampler, SamplerParameterI pname, ReadOnlySpan<int> param)
        {
            fixed (int* param_ptr = param)
            {
                SamplerParameterIiv(sampler, pname, param_ptr);
            }
        }
        /// <summary> Set sampler parameters. </summary>
        /// <param name="sampler"> Specifies the sampler object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued sampler parameter. pname can be one of the following: GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC. </param>
        public static unsafe void SamplerParameterIi(SamplerHandle sampler, SamplerParameterI pname, int[] param)
        {
            fixed (int* param_ptr = param)
            {
                SamplerParameterIiv(sampler, pname, param_ptr);
            }
        }
        /// <summary> Set sampler parameters. </summary>
        /// <param name="sampler"> Specifies the sampler object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued sampler parameter. pname can be one of the following: GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC. </param>
        public static unsafe void SamplerParameterIi(SamplerHandle sampler, SamplerParameterI pname, in int param)
        {
            fixed (int* param_ptr = &param)
            {
                SamplerParameterIiv(sampler, pname, param_ptr);
            }
        }
        /// <summary> Set sampler parameters. </summary>
        /// <param name="sampler"> Specifies the sampler object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued sampler parameter. pname can be one of the following: GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC. </param>
        public static unsafe void SamplerParameterIui(SamplerHandle sampler, SamplerParameterI pname, ReadOnlySpan<uint> param)
        {
            fixed (uint* param_ptr = param)
            {
                SamplerParameterIuiv(sampler, pname, param_ptr);
            }
        }
        /// <summary> Set sampler parameters. </summary>
        /// <param name="sampler"> Specifies the sampler object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued sampler parameter. pname can be one of the following: GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC. </param>
        public static unsafe void SamplerParameterIui(SamplerHandle sampler, SamplerParameterI pname, uint[] param)
        {
            fixed (uint* param_ptr = param)
            {
                SamplerParameterIuiv(sampler, pname, param_ptr);
            }
        }
        /// <summary> Set sampler parameters. </summary>
        /// <param name="sampler"> Specifies the sampler object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued sampler parameter. pname can be one of the following: GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC. </param>
        public static unsafe void SamplerParameterIui(SamplerHandle sampler, SamplerParameterI pname, in uint param)
        {
            fixed (uint* param_ptr = &param)
            {
                SamplerParameterIuiv(sampler, pname, param_ptr);
            }
        }
        /// <summary> Return sampler parameter values. </summary>
        /// <param name="sampler"> Specifies name of the sampler object from which to retrieve parameters. </param>
        /// <param name="pname"> Specifies the symbolic name of a sampler parameter. GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        public static unsafe void GetSamplerParameterIi(SamplerHandle sampler, SamplerParameterI pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetSamplerParameterIiv(sampler, pname, parameters_ptr);
            }
        }
        /// <summary> Return sampler parameter values. </summary>
        /// <param name="sampler"> Specifies name of the sampler object from which to retrieve parameters. </param>
        /// <param name="pname"> Specifies the symbolic name of a sampler parameter. GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        public static unsafe void GetSamplerParameterIi(SamplerHandle sampler, SamplerParameterI pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters)
            {
                GetSamplerParameterIiv(sampler, pname, parameters_ptr);
            }
        }
        /// <summary> Return sampler parameter values. </summary>
        /// <param name="sampler"> Specifies name of the sampler object from which to retrieve parameters. </param>
        /// <param name="pname"> Specifies the symbolic name of a sampler parameter. GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        public static unsafe void GetSamplerParameterIi(SamplerHandle sampler, SamplerParameterI pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters)
            {
                GetSamplerParameterIiv(sampler, pname, parameters_ptr);
            }
        }
        /// <summary> Return sampler parameter values. </summary>
        /// <param name="sampler"> Specifies name of the sampler object from which to retrieve parameters. </param>
        /// <param name="pname"> Specifies the symbolic name of a sampler parameter. GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        public static unsafe void GetSamplerParameterIui(SamplerHandle sampler, SamplerParameterI pname, Span<uint> parameters)
        {
            fixed (uint* parameters_ptr = parameters)
            {
                GetSamplerParameterIuiv(sampler, pname, parameters_ptr);
            }
        }
        /// <summary> Return sampler parameter values. </summary>
        /// <param name="sampler"> Specifies name of the sampler object from which to retrieve parameters. </param>
        /// <param name="pname"> Specifies the symbolic name of a sampler parameter. GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        public static unsafe void GetSamplerParameterIui(SamplerHandle sampler, SamplerParameterI pname, uint[] parameters)
        {
            fixed (uint* parameters_ptr = parameters)
            {
                GetSamplerParameterIuiv(sampler, pname, parameters_ptr);
            }
        }
        /// <summary> Return sampler parameter values. </summary>
        /// <param name="sampler"> Specifies name of the sampler object from which to retrieve parameters. </param>
        /// <param name="pname"> Specifies the symbolic name of a sampler parameter. GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        public static unsafe void GetSamplerParameterIui(SamplerHandle sampler, SamplerParameterI pname, ref uint parameters)
        {
            fixed (uint* parameters_ptr = &parameters)
            {
                GetSamplerParameterIuiv(sampler, pname, parameters_ptr);
            }
        }
        /// <summary> Specify storage for a two-dimensional multisample array texture. </summary>
        /// <param name="target"> Specifies the target to which the texture object is bound for glTexStorage3DMultisample. Must be GL_TEXTURE_2D_MULTISAMPLE_ARRAY. </param>
        /// <param name="samples"> Specify the number of samples in the texture. </param>
        /// <param name="internalformat"> Specifies the sized internal format to be used to store texture image data. </param>
        /// <param name="width"> Specifies the width of the texture, in texels. </param>
        /// <param name="height"> Specifies the height of the texture, in texels. </param>
        /// <param name="depth"> Specifies the depth of the texture, in layers. </param>
        /// <param name="fixedsamplelocations"> Specifies whether the image will use identical sample locations and the same number of samples for all texels in the image, and the sample locations will not depend on the internal format or size of the image. </param>
        public static unsafe void TexStorage3DMultisample(TextureTarget target, int samples, SizedInternalFormat internalformat, int width, int height, int depth, bool fixedsamplelocations)
        {
            byte fixedsamplelocations_byte = (byte)(fixedsamplelocations ? 1 : 0);
            TexStorage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations_byte);
        }
        public static unsafe partial class AMD
        {
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
            public static unsafe void GetPerfMonitorGroupsAMD(ref int numGroups, int groupsSize, ref uint groups)
            {
                fixed (int* numGroups_ptr = &numGroups)
                fixed (uint* groups_ptr = &groups)
                {
                    GetPerfMonitorGroupsAMD(numGroups_ptr, groupsSize, groups_ptr);
                }
            }
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
            public static unsafe void GetPerfMonitorCountersAMD(uint group, ref int numCounters, ref int maxActiveCounters, int counterSize, ref uint counters)
            {
                fixed (int* numCounters_ptr = &numCounters)
                fixed (int* maxActiveCounters_ptr = &maxActiveCounters)
                fixed (uint* counters_ptr = &counters)
                {
                    GetPerfMonitorCountersAMD(group, numCounters_ptr, maxActiveCounters_ptr, counterSize, counters_ptr);
                }
            }
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
            public static unsafe void GetPerfMonitorCounterInfoAMD(uint group, uint counter, All pname, IntPtr data)
            {
                void* data_vptr = (void*)data;
                GetPerfMonitorCounterInfoAMD(group, counter, pname, data_vptr);
            }
            public static unsafe void GetPerfMonitorCounterInfoAMD<T1>(uint group, uint counter, All pname, Span<T1> data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    GetPerfMonitorCounterInfoAMD(group, counter, pname, data_ptr);
                }
            }
            public static unsafe void GetPerfMonitorCounterInfoAMD<T1>(uint group, uint counter, All pname, T1[] data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    GetPerfMonitorCounterInfoAMD(group, counter, pname, data_ptr);
                }
            }
            public static unsafe void GetPerfMonitorCounterInfoAMD<T1>(uint group, uint counter, All pname, ref T1 data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    GetPerfMonitorCounterInfoAMD(group, counter, pname, data_ptr);
                }
            }
            public static unsafe void GenPerfMonitorsAMD(Span<uint> monitors)
            {
                int n = (int)(monitors.Length);
                fixed (uint* monitors_ptr = monitors)
                {
                    GenPerfMonitorsAMD(n, monitors_ptr);
                }
            }
            public static unsafe void GenPerfMonitorsAMD(uint[] monitors)
            {
                int n = (int)(monitors.Length);
                fixed (uint* monitors_ptr = monitors)
                {
                    GenPerfMonitorsAMD(n, monitors_ptr);
                }
            }
            public static unsafe void GenPerfMonitorsAMD(int n, ref uint monitors)
            {
                fixed (uint* monitors_ptr = &monitors)
                {
                    GenPerfMonitorsAMD(n, monitors_ptr);
                }
            }
            public static unsafe void DeletePerfMonitorsAMD(Span<uint> monitors)
            {
                int n = (int)(monitors.Length);
                fixed (uint* monitors_ptr = monitors)
                {
                    DeletePerfMonitorsAMD(n, monitors_ptr);
                }
            }
            public static unsafe void DeletePerfMonitorsAMD(uint[] monitors)
            {
                int n = (int)(monitors.Length);
                fixed (uint* monitors_ptr = monitors)
                {
                    DeletePerfMonitorsAMD(n, monitors_ptr);
                }
            }
            public static unsafe void DeletePerfMonitorsAMD(int n, ref uint monitors)
            {
                fixed (uint* monitors_ptr = &monitors)
                {
                    DeletePerfMonitorsAMD(n, monitors_ptr);
                }
            }
            public static unsafe void SelectPerfMonitorCountersAMD(uint monitor, bool enable, uint group, Span<uint> counterList)
            {
                int numCounters = (int)(counterList.Length);
                fixed (uint* counterList_ptr = counterList)
                {
                    byte enable_byte = (byte)(enable ? 1 : 0);
                    SelectPerfMonitorCountersAMD(monitor, enable_byte, group, numCounters, counterList_ptr);
                }
            }
            public static unsafe void SelectPerfMonitorCountersAMD(uint monitor, bool enable, uint group, uint[] counterList)
            {
                int numCounters = (int)(counterList.Length);
                fixed (uint* counterList_ptr = counterList)
                {
                    byte enable_byte = (byte)(enable ? 1 : 0);
                    SelectPerfMonitorCountersAMD(monitor, enable_byte, group, numCounters, counterList_ptr);
                }
            }
            public static unsafe void SelectPerfMonitorCountersAMD(uint monitor, bool enable, uint group, int numCounters, ref uint counterList)
            {
                fixed (uint* counterList_ptr = &counterList)
                {
                    byte enable_byte = (byte)(enable ? 1 : 0);
                    SelectPerfMonitorCountersAMD(monitor, enable_byte, group, numCounters, counterList_ptr);
                }
            }
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
            public static unsafe void DrawElementsInstancedANGLE(PrimitiveType mode, int count, PrimitiveType type, nint offset, int primcount)
            {
                void* indices = (void*)offset;
                DrawElementsInstancedANGLE(mode, count, type, indices, primcount);
            }
            public static unsafe void GetTranslatedShaderSourceANGLE(ShaderHandle shader, int bufSize, Span<int> length, byte* source)
            {
                fixed (int* length_ptr = length)
                {
                    GetTranslatedShaderSourceANGLE(shader, bufSize, length_ptr, source);
                }
            }
            public static unsafe void GetTranslatedShaderSourceANGLE(ShaderHandle shader, int bufSize, int[] length, byte* source)
            {
                fixed (int* length_ptr = length)
                {
                    GetTranslatedShaderSourceANGLE(shader, bufSize, length_ptr, source);
                }
            }
            public static unsafe void GetTranslatedShaderSourceANGLE(ShaderHandle shader, int bufSize, ref int length, byte* source)
            {
                fixed (int* length_ptr = &length)
                {
                    GetTranslatedShaderSourceANGLE(shader, bufSize, length_ptr, source);
                }
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
            public static unsafe void EGLImageTargetTexStorageEXT(All target, IntPtr image, in int attrib_list)
            {
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    void* image_vptr = (void*)image;
                    EGLImageTargetTexStorageEXT(target, image_vptr, attrib_list_ptr);
                }
            }
            public static unsafe void EGLImageTargetTexStorageEXT<T1>(All target, ref T1 image, in int attrib_list)
                where T1 : unmanaged
            {
                fixed (void* image_ptr = &image)
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    EGLImageTargetTexStorageEXT(target, image_ptr, attrib_list_ptr);
                }
            }
            public static unsafe void EGLImageTargetTextureStorageEXT(TextureHandle texture, IntPtr image, in int attrib_list)
            {
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    void* image_vptr = (void*)image;
                    EGLImageTargetTextureStorageEXT(texture, image_vptr, attrib_list_ptr);
                }
            }
            public static unsafe void EGLImageTargetTextureStorageEXT<T1>(TextureHandle texture, ref T1 image, in int attrib_list)
                where T1 : unmanaged
            {
                fixed (void* image_ptr = &image)
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    EGLImageTargetTextureStorageEXT(texture, image_ptr, attrib_list_ptr);
                }
            }
            public static unsafe void DrawElementsInstancedBaseInstanceEXT(PrimitiveType mode, int count, PrimitiveType type, nint offset, int instancecount, uint baseinstance)
            {
                void* indices = (void*)offset;
                DrawElementsInstancedBaseInstanceEXT(mode, count, type, indices, instancecount, baseinstance);
            }
            public static unsafe void DrawElementsInstancedBaseVertexBaseInstanceEXT(PrimitiveType mode, int count, DrawElementsType type, nint offset, int instancecount, int basevertex, uint baseinstance)
            {
                void* indices = (void*)offset;
                DrawElementsInstancedBaseVertexBaseInstanceEXT(mode, count, type, indices, instancecount, basevertex, baseinstance);
            }
            public static unsafe void BindFragDataLocationIndexedEXT(ProgramHandle program, uint colorNumber, uint index, string name)
            {
                byte* name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(name);
                BindFragDataLocationIndexedEXT(program, colorNumber, index, name_ptr);
                Marshal.FreeCoTaskMem((IntPtr)name_ptr);
            }
            public static unsafe void BindFragDataLocationEXT(ProgramHandle program, uint color, string name)
            {
                byte* name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(name);
                BindFragDataLocationEXT(program, color, name_ptr);
                Marshal.FreeCoTaskMem((IntPtr)name_ptr);
            }
            public static unsafe int GetProgramResourceLocationIndexEXT(ProgramHandle program, ProgramInterface programInterface, string name)
            {
                int returnValue;
                byte* name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(name);
                returnValue = GetProgramResourceLocationIndexEXT(program, programInterface, name_ptr);
                Marshal.FreeCoTaskMem((IntPtr)name_ptr);
                return returnValue;
            }
            public static unsafe int GetFragDataIndexEXT(ProgramHandle program, string name)
            {
                int returnValue;
                byte* name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(name);
                returnValue = GetFragDataIndexEXT(program, name_ptr);
                Marshal.FreeCoTaskMem((IntPtr)name_ptr);
                return returnValue;
            }
            public static unsafe void BufferStorageEXT(BufferStorageTarget target, nint size, IntPtr data, BufferStorageMask flags)
            {
                void* data_vptr = (void*)data;
                BufferStorageEXT(target, size, data_vptr, flags);
            }
            public static unsafe void BufferStorageEXT<T1>(BufferStorageTarget target, ReadOnlySpan<T1> data, BufferStorageMask flags)
                where T1 : unmanaged
            {
                nint size = (nint)(data.Length * sizeof(T1));
                fixed (void* data_ptr = data)
                {
                    BufferStorageEXT(target, size, data_ptr, flags);
                }
            }
            public static unsafe void BufferStorageEXT<T1>(BufferStorageTarget target, T1[] data, BufferStorageMask flags)
                where T1 : unmanaged
            {
                nint size = (nint)(data.Length * sizeof(T1));
                fixed (void* data_ptr = data)
                {
                    BufferStorageEXT(target, size, data_ptr, flags);
                }
            }
            public static unsafe void BufferStorageEXT<T1>(BufferStorageTarget target, nint size, in T1 data, BufferStorageMask flags)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    BufferStorageEXT(target, size, data_ptr, flags);
                }
            }
            public static unsafe void ClearTexImageEXT(TextureHandle texture, int level, PixelFormat format, PixelType type, IntPtr data)
            {
                void* data_vptr = (void*)data;
                ClearTexImageEXT(texture, level, format, type, data_vptr);
            }
            public static unsafe void ClearTexImageEXT<T1>(TextureHandle texture, int level, PixelFormat format, PixelType type, ReadOnlySpan<T1> data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    ClearTexImageEXT(texture, level, format, type, data_ptr);
                }
            }
            public static unsafe void ClearTexImageEXT<T1>(TextureHandle texture, int level, PixelFormat format, PixelType type, T1[] data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    ClearTexImageEXT(texture, level, format, type, data_ptr);
                }
            }
            public static unsafe void ClearTexImageEXT<T1>(TextureHandle texture, int level, PixelFormat format, PixelType type, in T1 data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    ClearTexImageEXT(texture, level, format, type, data_ptr);
                }
            }
            public static unsafe void ClearTexSubImageEXT(TextureHandle texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr data)
            {
                void* data_vptr = (void*)data;
                ClearTexSubImageEXT(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data_vptr);
            }
            public static unsafe void ClearTexSubImageEXT<T1>(TextureHandle texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, ReadOnlySpan<T1> data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    ClearTexSubImageEXT(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data_ptr);
                }
            }
            public static unsafe void ClearTexSubImageEXT<T1>(TextureHandle texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, T1[] data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    ClearTexSubImageEXT(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data_ptr);
                }
            }
            public static unsafe void ClearTexSubImageEXT<T1>(TextureHandle texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, in T1 data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    ClearTexSubImageEXT(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data_ptr);
                }
            }
            public static unsafe void LabelObjectEXT(All type, uint obj, int length, string label)
            {
                byte* label_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(label);
                LabelObjectEXT(type, obj, length, label_ptr);
                Marshal.FreeCoTaskMem((IntPtr)label_ptr);
            }
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
            public static unsafe void GenQueriesEXT(Span<QueryHandle> ids)
            {
                int n = (int)(ids.Length);
                fixed (QueryHandle* ids_ptr = ids)
                {
                    GenQueriesEXT(n, ids_ptr);
                }
            }
            public static unsafe void GenQueriesEXT(QueryHandle[] ids)
            {
                int n = (int)(ids.Length);
                fixed (QueryHandle* ids_ptr = ids)
                {
                    GenQueriesEXT(n, ids_ptr);
                }
            }
            public static unsafe void GenQueriesEXT(int n, ref QueryHandle ids)
            {
                fixed (QueryHandle* ids_ptr = &ids)
                {
                    GenQueriesEXT(n, ids_ptr);
                }
            }
            public static unsafe void DeleteQueriesEXT(ReadOnlySpan<QueryHandle> ids)
            {
                int n = (int)(ids.Length);
                fixed (QueryHandle* ids_ptr = ids)
                {
                    DeleteQueriesEXT(n, ids_ptr);
                }
            }
            public static unsafe void DeleteQueriesEXT(QueryHandle[] ids)
            {
                int n = (int)(ids.Length);
                fixed (QueryHandle* ids_ptr = ids)
                {
                    DeleteQueriesEXT(n, ids_ptr);
                }
            }
            public static unsafe void DeleteQueriesEXT(int n, in QueryHandle ids)
            {
                fixed (QueryHandle* ids_ptr = &ids)
                {
                    DeleteQueriesEXT(n, ids_ptr);
                }
            }
            public static unsafe void GetQueryivEXT(QueryTarget target, QueryParameterName pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetQueryivEXT(target, pname, parameters_ptr);
                }
            }
            public static unsafe void GetQueryivEXT(QueryTarget target, QueryParameterName pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetQueryivEXT(target, pname, parameters_ptr);
                }
            }
            public static unsafe void GetQueryivEXT(QueryTarget target, QueryParameterName pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetQueryivEXT(target, pname, parameters_ptr);
                }
            }
            public static unsafe void GetQueryObjectivEXT(QueryHandle id, QueryObjectParameterName pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetQueryObjectivEXT(id, pname, parameters_ptr);
                }
            }
            public static unsafe void GetQueryObjectivEXT(QueryHandle id, QueryObjectParameterName pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetQueryObjectivEXT(id, pname, parameters_ptr);
                }
            }
            public static unsafe void GetQueryObjectivEXT(QueryHandle id, QueryObjectParameterName pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetQueryObjectivEXT(id, pname, parameters_ptr);
                }
            }
            public static unsafe void GetQueryObjectuivEXT(QueryHandle id, QueryObjectParameterName pname, Span<uint> parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    GetQueryObjectuivEXT(id, pname, parameters_ptr);
                }
            }
            public static unsafe void GetQueryObjectuivEXT(QueryHandle id, QueryObjectParameterName pname, uint[] parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    GetQueryObjectuivEXT(id, pname, parameters_ptr);
                }
            }
            public static unsafe void GetQueryObjectuivEXT(QueryHandle id, QueryObjectParameterName pname, ref uint parameters)
            {
                fixed (uint* parameters_ptr = &parameters)
                {
                    GetQueryObjectuivEXT(id, pname, parameters_ptr);
                }
            }
            public static unsafe void GetQueryObjecti64vEXT(QueryHandle id, QueryObjectParameterName pname, Span<long> parameters)
            {
                fixed (long* parameters_ptr = parameters)
                {
                    GetQueryObjecti64vEXT(id, pname, parameters_ptr);
                }
            }
            public static unsafe void GetQueryObjecti64vEXT(QueryHandle id, QueryObjectParameterName pname, long[] parameters)
            {
                fixed (long* parameters_ptr = parameters)
                {
                    GetQueryObjecti64vEXT(id, pname, parameters_ptr);
                }
            }
            public static unsafe void GetQueryObjecti64vEXT(QueryHandle id, QueryObjectParameterName pname, ref long parameters)
            {
                fixed (long* parameters_ptr = &parameters)
                {
                    GetQueryObjecti64vEXT(id, pname, parameters_ptr);
                }
            }
            public static unsafe void GetQueryObjectui64vEXT(QueryHandle id, QueryObjectParameterName pname, Span<ulong> parameters)
            {
                fixed (ulong* parameters_ptr = parameters)
                {
                    GetQueryObjectui64vEXT(id, pname, parameters_ptr);
                }
            }
            public static unsafe void GetQueryObjectui64vEXT(QueryHandle id, QueryObjectParameterName pname, ulong[] parameters)
            {
                fixed (ulong* parameters_ptr = parameters)
                {
                    GetQueryObjectui64vEXT(id, pname, parameters_ptr);
                }
            }
            public static unsafe void GetQueryObjectui64vEXT(QueryHandle id, QueryObjectParameterName pname, ref ulong parameters)
            {
                fixed (ulong* parameters_ptr = &parameters)
                {
                    GetQueryObjectui64vEXT(id, pname, parameters_ptr);
                }
            }
            public static unsafe void GetInteger64vEXT(GetPName pname, Span<long> data)
            {
                fixed (long* data_ptr = data)
                {
                    GetInteger64vEXT(pname, data_ptr);
                }
            }
            public static unsafe void GetInteger64vEXT(GetPName pname, long[] data)
            {
                fixed (long* data_ptr = data)
                {
                    GetInteger64vEXT(pname, data_ptr);
                }
            }
            public static unsafe void GetInteger64vEXT(GetPName pname, ref long data)
            {
                fixed (long* data_ptr = &data)
                {
                    GetInteger64vEXT(pname, data_ptr);
                }
            }
            public static unsafe void DrawBuffersEXT(ReadOnlySpan<All> bufs)
            {
                int n = (int)(bufs.Length);
                fixed (All* bufs_ptr = bufs)
                {
                    DrawBuffersEXT(n, bufs_ptr);
                }
            }
            public static unsafe void DrawBuffersEXT(All[] bufs)
            {
                int n = (int)(bufs.Length);
                fixed (All* bufs_ptr = bufs)
                {
                    DrawBuffersEXT(n, bufs_ptr);
                }
            }
            public static unsafe void DrawBuffersEXT(int n, in All bufs)
            {
                fixed (All* bufs_ptr = &bufs)
                {
                    DrawBuffersEXT(n, bufs_ptr);
                }
            }
            public static unsafe void ColorMaskiEXT(uint index, bool r, bool g, bool b, bool a)
            {
                byte r_byte = (byte)(r ? 1 : 0);
                byte g_byte = (byte)(g ? 1 : 0);
                byte b_byte = (byte)(b ? 1 : 0);
                byte a_byte = (byte)(a ? 1 : 0);
                ColorMaskiEXT(index, r_byte, g_byte, b_byte, a_byte);
            }
            public static unsafe void DrawElementsBaseVertexEXT(PrimitiveType mode, int count, DrawElementsType type, nint offset, int basevertex)
            {
                void* indices = (void*)offset;
                DrawElementsBaseVertexEXT(mode, count, type, indices, basevertex);
            }
            public static unsafe void DrawRangeElementsBaseVertexEXT(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, nint offset, int basevertex)
            {
                void* indices = (void*)offset;
                DrawRangeElementsBaseVertexEXT(mode, start, end, count, type, indices, basevertex);
            }
            public static unsafe void DrawElementsInstancedBaseVertexEXT(PrimitiveType mode, int count, DrawElementsType type, nint offset, int instancecount, int basevertex)
            {
                void* indices = (void*)offset;
                DrawElementsInstancedBaseVertexEXT(mode, count, type, indices, instancecount, basevertex);
            }
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
            public static unsafe void MultiDrawElementsBaseVertexEXT(PrimitiveType mode, in int count, DrawElementsType type, void** indices, int drawcount, in int basevertex)
            {
                fixed (int* count_ptr = &count)
                fixed (int* basevertex_ptr = &basevertex)
                {
                    MultiDrawElementsBaseVertexEXT(mode, count_ptr, type, indices, drawcount, basevertex_ptr);
                }
            }
            public static unsafe void DrawElementsInstancedEXT(PrimitiveType mode, int count, DrawElementsType type, nint offset, int primcount)
            {
                void* indices = (void*)offset;
                DrawElementsInstancedEXT(mode, count, type, indices, primcount);
            }
            public static unsafe void BufferStorageExternalEXT(All target, IntPtr offset, nint size, IntPtr clientBuffer, BufferStorageMask flags)
            {
                void* clientBuffer_vptr = (void*)clientBuffer;
                BufferStorageExternalEXT(target, offset, size, clientBuffer_vptr, flags);
            }
            public static unsafe void BufferStorageExternalEXT<T1>(All target, IntPtr offset, nint size, ref T1 clientBuffer, BufferStorageMask flags)
                where T1 : unmanaged
            {
                fixed (void* clientBuffer_ptr = &clientBuffer)
                {
                    BufferStorageExternalEXT(target, offset, size, clientBuffer_ptr, flags);
                }
            }
            public static unsafe void NamedBufferStorageExternalEXT(BufferHandle buffer, IntPtr offset, nint size, IntPtr clientBuffer, BufferStorageMask flags)
            {
                void* clientBuffer_vptr = (void*)clientBuffer;
                NamedBufferStorageExternalEXT(buffer, offset, size, clientBuffer_vptr, flags);
            }
            public static unsafe void NamedBufferStorageExternalEXT<T1>(BufferHandle buffer, IntPtr offset, nint size, ref T1 clientBuffer, BufferStorageMask flags)
                where T1 : unmanaged
            {
                fixed (void* clientBuffer_ptr = &clientBuffer)
                {
                    NamedBufferStorageExternalEXT(buffer, offset, size, clientBuffer_ptr, flags);
                }
            }
            public static unsafe void GetUnsignedBytevEXT(GetPName pname, Span<byte> data)
            {
                fixed (byte* data_ptr = data)
                {
                    GetUnsignedBytevEXT(pname, data_ptr);
                }
            }
            public static unsafe void GetUnsignedBytevEXT(GetPName pname, byte[] data)
            {
                fixed (byte* data_ptr = data)
                {
                    GetUnsignedBytevEXT(pname, data_ptr);
                }
            }
            public static unsafe void GetUnsignedBytevEXT(GetPName pname, ref byte data)
            {
                fixed (byte* data_ptr = &data)
                {
                    GetUnsignedBytevEXT(pname, data_ptr);
                }
            }
            public static unsafe void GetUnsignedBytei_vEXT(All target, uint index, Span<byte> data)
            {
                fixed (byte* data_ptr = data)
                {
                    GetUnsignedBytei_vEXT(target, index, data_ptr);
                }
            }
            public static unsafe void GetUnsignedBytei_vEXT(All target, uint index, byte[] data)
            {
                fixed (byte* data_ptr = data)
                {
                    GetUnsignedBytei_vEXT(target, index, data_ptr);
                }
            }
            public static unsafe void GetUnsignedBytei_vEXT(All target, uint index, ref byte data)
            {
                fixed (byte* data_ptr = &data)
                {
                    GetUnsignedBytei_vEXT(target, index, data_ptr);
                }
            }
            public static unsafe void DeleteMemoryObjectsEXT(ReadOnlySpan<uint> memoryObjects)
            {
                int n = (int)(memoryObjects.Length);
                fixed (uint* memoryObjects_ptr = memoryObjects)
                {
                    DeleteMemoryObjectsEXT(n, memoryObjects_ptr);
                }
            }
            public static unsafe void DeleteMemoryObjectsEXT(uint[] memoryObjects)
            {
                int n = (int)(memoryObjects.Length);
                fixed (uint* memoryObjects_ptr = memoryObjects)
                {
                    DeleteMemoryObjectsEXT(n, memoryObjects_ptr);
                }
            }
            public static unsafe void DeleteMemoryObjectsEXT(int n, in uint memoryObjects)
            {
                fixed (uint* memoryObjects_ptr = &memoryObjects)
                {
                    DeleteMemoryObjectsEXT(n, memoryObjects_ptr);
                }
            }
            public static unsafe void CreateMemoryObjectsEXT(int n, ref uint memoryObjects)
            {
                fixed (uint* memoryObjects_ptr = &memoryObjects)
                {
                    CreateMemoryObjectsEXT(n, memoryObjects_ptr);
                }
            }
            public static unsafe void MemoryObjectParameterivEXT(uint memoryObject, MemoryObjectParameterName pname, in int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    MemoryObjectParameterivEXT(memoryObject, pname, parameters_ptr);
                }
            }
            public static unsafe void GetMemoryObjectParameterivEXT(uint memoryObject, MemoryObjectParameterName pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetMemoryObjectParameterivEXT(memoryObject, pname, parameters_ptr);
                }
            }
            public static unsafe void TexStorageMem2DMultisampleEXT(TextureTarget target, int samples, SizedInternalFormat internalFormat, int width, int height, bool fixedSampleLocations, uint memory, ulong offset)
            {
                byte fixedSampleLocations_byte = (byte)(fixedSampleLocations ? 1 : 0);
                TexStorageMem2DMultisampleEXT(target, samples, internalFormat, width, height, fixedSampleLocations_byte, memory, offset);
            }
            public static unsafe void TexStorageMem3DMultisampleEXT(TextureTarget target, int samples, SizedInternalFormat internalFormat, int width, int height, int depth, bool fixedSampleLocations, uint memory, ulong offset)
            {
                byte fixedSampleLocations_byte = (byte)(fixedSampleLocations ? 1 : 0);
                TexStorageMem3DMultisampleEXT(target, samples, internalFormat, width, height, depth, fixedSampleLocations_byte, memory, offset);
            }
            public static unsafe void TextureStorageMem2DMultisampleEXT(TextureHandle texture, int samples, SizedInternalFormat internalFormat, int width, int height, bool fixedSampleLocations, uint memory, ulong offset)
            {
                byte fixedSampleLocations_byte = (byte)(fixedSampleLocations ? 1 : 0);
                TextureStorageMem2DMultisampleEXT(texture, samples, internalFormat, width, height, fixedSampleLocations_byte, memory, offset);
            }
            public static unsafe void TextureStorageMem3DMultisampleEXT(TextureHandle texture, int samples, SizedInternalFormat internalFormat, int width, int height, int depth, bool fixedSampleLocations, uint memory, ulong offset)
            {
                byte fixedSampleLocations_byte = (byte)(fixedSampleLocations ? 1 : 0);
                TextureStorageMem3DMultisampleEXT(texture, samples, internalFormat, width, height, depth, fixedSampleLocations_byte, memory, offset);
            }
            public static unsafe void ImportMemoryWin32HandleEXT(uint memory, ulong size, ExternalHandleType handleType, IntPtr handle)
            {
                void* handle_vptr = (void*)handle;
                ImportMemoryWin32HandleEXT(memory, size, handleType, handle_vptr);
            }
            public static unsafe void ImportMemoryWin32HandleEXT<T1>(uint memory, ulong size, ExternalHandleType handleType, ref T1 handle)
                where T1 : unmanaged
            {
                fixed (void* handle_ptr = &handle)
                {
                    ImportMemoryWin32HandleEXT(memory, size, handleType, handle_ptr);
                }
            }
            public static unsafe void ImportMemoryWin32NameEXT(uint memory, ulong size, ExternalHandleType handleType, IntPtr name)
            {
                void* name_vptr = (void*)name;
                ImportMemoryWin32NameEXT(memory, size, handleType, name_vptr);
            }
            public static unsafe void ImportMemoryWin32NameEXT<T1>(uint memory, ulong size, ExternalHandleType handleType, in T1 name)
                where T1 : unmanaged
            {
                fixed (void* name_ptr = &name)
                {
                    ImportMemoryWin32NameEXT(memory, size, handleType, name_ptr);
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
            public static unsafe void MultiDrawArraysIndirectEXT(PrimitiveType mode, IntPtr indirect, int drawcount, int stride)
            {
                void* indirect_vptr = (void*)indirect;
                MultiDrawArraysIndirectEXT(mode, indirect_vptr, drawcount, stride);
            }
            public static unsafe void MultiDrawArraysIndirectEXT<T1>(PrimitiveType mode, ReadOnlySpan<T1> indirect, int drawcount, int stride)
                where T1 : unmanaged
            {
                fixed (void* indirect_ptr = indirect)
                {
                    MultiDrawArraysIndirectEXT(mode, indirect_ptr, drawcount, stride);
                }
            }
            public static unsafe void MultiDrawArraysIndirectEXT<T1>(PrimitiveType mode, T1[] indirect, int drawcount, int stride)
                where T1 : unmanaged
            {
                fixed (void* indirect_ptr = indirect)
                {
                    MultiDrawArraysIndirectEXT(mode, indirect_ptr, drawcount, stride);
                }
            }
            public static unsafe void MultiDrawArraysIndirectEXT<T1>(PrimitiveType mode, in T1 indirect, int drawcount, int stride)
                where T1 : unmanaged
            {
                fixed (void* indirect_ptr = &indirect)
                {
                    MultiDrawArraysIndirectEXT(mode, indirect_ptr, drawcount, stride);
                }
            }
            public static unsafe void MultiDrawElementsIndirectEXT(PrimitiveType mode, DrawElementsType type, IntPtr indirect, int drawcount, int stride)
            {
                void* indirect_vptr = (void*)indirect;
                MultiDrawElementsIndirectEXT(mode, type, indirect_vptr, drawcount, stride);
            }
            public static unsafe void MultiDrawElementsIndirectEXT<T1>(PrimitiveType mode, DrawElementsType type, ReadOnlySpan<T1> indirect, int drawcount, int stride)
                where T1 : unmanaged
            {
                fixed (void* indirect_ptr = indirect)
                {
                    MultiDrawElementsIndirectEXT(mode, type, indirect_ptr, drawcount, stride);
                }
            }
            public static unsafe void MultiDrawElementsIndirectEXT<T1>(PrimitiveType mode, DrawElementsType type, T1[] indirect, int drawcount, int stride)
                where T1 : unmanaged
            {
                fixed (void* indirect_ptr = indirect)
                {
                    MultiDrawElementsIndirectEXT(mode, type, indirect_ptr, drawcount, stride);
                }
            }
            public static unsafe void MultiDrawElementsIndirectEXT<T1>(PrimitiveType mode, DrawElementsType type, in T1 indirect, int drawcount, int stride)
                where T1 : unmanaged
            {
                fixed (void* indirect_ptr = &indirect)
                {
                    MultiDrawElementsIndirectEXT(mode, type, indirect_ptr, drawcount, stride);
                }
            }
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
            public static unsafe void DrawBuffersIndexedEXT(int n, in All location, in int indices)
            {
                fixed (All* location_ptr = &location)
                fixed (int* indices_ptr = &indices)
                {
                    DrawBuffersIndexedEXT(n, location_ptr, indices_ptr);
                }
            }
            public static unsafe void GetIntegeri_vEXT(GetPName target, uint index, ref int data)
            {
                fixed (int* data_ptr = &data)
                {
                    GetIntegeri_vEXT(target, index, data_ptr);
                }
            }
            public static unsafe void RasterSamplesEXT(uint samples, bool fixedsamplelocations)
            {
                byte fixedsamplelocations_byte = (byte)(fixedsamplelocations ? 1 : 0);
                RasterSamplesEXT(samples, fixedsamplelocations_byte);
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
            public static unsafe void GenSemaphoresEXT(Span<uint> semaphores)
            {
                int n = (int)(semaphores.Length);
                fixed (uint* semaphores_ptr = semaphores)
                {
                    GenSemaphoresEXT(n, semaphores_ptr);
                }
            }
            public static unsafe void GenSemaphoresEXT(uint[] semaphores)
            {
                int n = (int)(semaphores.Length);
                fixed (uint* semaphores_ptr = semaphores)
                {
                    GenSemaphoresEXT(n, semaphores_ptr);
                }
            }
            public static unsafe void GenSemaphoresEXT(int n, ref uint semaphores)
            {
                fixed (uint* semaphores_ptr = &semaphores)
                {
                    GenSemaphoresEXT(n, semaphores_ptr);
                }
            }
            public static unsafe void DeleteSemaphoresEXT(ReadOnlySpan<uint> semaphores)
            {
                int n = (int)(semaphores.Length);
                fixed (uint* semaphores_ptr = semaphores)
                {
                    DeleteSemaphoresEXT(n, semaphores_ptr);
                }
            }
            public static unsafe void DeleteSemaphoresEXT(uint[] semaphores)
            {
                int n = (int)(semaphores.Length);
                fixed (uint* semaphores_ptr = semaphores)
                {
                    DeleteSemaphoresEXT(n, semaphores_ptr);
                }
            }
            public static unsafe void DeleteSemaphoresEXT(int n, in uint semaphores)
            {
                fixed (uint* semaphores_ptr = &semaphores)
                {
                    DeleteSemaphoresEXT(n, semaphores_ptr);
                }
            }
            public static unsafe void SemaphoreParameterui64vEXT(uint semaphore, SemaphoreParameterName pname, in ulong parameters)
            {
                fixed (ulong* parameters_ptr = &parameters)
                {
                    SemaphoreParameterui64vEXT(semaphore, pname, parameters_ptr);
                }
            }
            public static unsafe void GetSemaphoreParameterui64vEXT(uint semaphore, SemaphoreParameterName pname, ref ulong parameters)
            {
                fixed (ulong* parameters_ptr = &parameters)
                {
                    GetSemaphoreParameterui64vEXT(semaphore, pname, parameters_ptr);
                }
            }
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
            public static unsafe void WaitSemaphoreEXT(uint semaphore, uint numBufferBarriers, in BufferHandle buffers, uint numTextureBarriers, in TextureHandle textures, in TextureLayout srcLayouts)
            {
                fixed (BufferHandle* buffers_ptr = &buffers)
                fixed (TextureHandle* textures_ptr = &textures)
                fixed (TextureLayout* srcLayouts_ptr = &srcLayouts)
                {
                    WaitSemaphoreEXT(semaphore, numBufferBarriers, buffers_ptr, numTextureBarriers, textures_ptr, srcLayouts_ptr);
                }
            }
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
            public static unsafe void SignalSemaphoreEXT(uint semaphore, uint numBufferBarriers, in BufferHandle buffers, uint numTextureBarriers, in TextureHandle textures, in TextureLayout dstLayouts)
            {
                fixed (BufferHandle* buffers_ptr = &buffers)
                fixed (TextureHandle* textures_ptr = &textures)
                fixed (TextureLayout* dstLayouts_ptr = &dstLayouts)
                {
                    SignalSemaphoreEXT(semaphore, numBufferBarriers, buffers_ptr, numTextureBarriers, textures_ptr, dstLayouts_ptr);
                }
            }
            public static unsafe void ImportSemaphoreWin32HandleEXT(uint semaphore, ExternalHandleType handleType, IntPtr handle)
            {
                void* handle_vptr = (void*)handle;
                ImportSemaphoreWin32HandleEXT(semaphore, handleType, handle_vptr);
            }
            public static unsafe void ImportSemaphoreWin32HandleEXT<T1>(uint semaphore, ExternalHandleType handleType, ref T1 handle)
                where T1 : unmanaged
            {
                fixed (void* handle_ptr = &handle)
                {
                    ImportSemaphoreWin32HandleEXT(semaphore, handleType, handle_ptr);
                }
            }
            public static unsafe void ImportSemaphoreWin32NameEXT(uint semaphore, ExternalHandleType handleType, IntPtr name)
            {
                void* name_vptr = (void*)name;
                ImportSemaphoreWin32NameEXT(semaphore, handleType, name_vptr);
            }
            public static unsafe void ImportSemaphoreWin32NameEXT<T1>(uint semaphore, ExternalHandleType handleType, in T1 name)
                where T1 : unmanaged
            {
                fixed (void* name_ptr = &name)
                {
                    ImportSemaphoreWin32NameEXT(semaphore, handleType, name_ptr);
                }
            }
            public static unsafe ProgramHandle CreateShaderProgramEXT(ShaderType type, string str)
            {
                ProgramHandle returnValue;
                byte* str_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(str);
                returnValue = CreateShaderProgramEXT(type, str_ptr);
                Marshal.FreeCoTaskMem((IntPtr)str_ptr);
                return returnValue;
            }
            public static unsafe void DeleteProgramPipelinesEXT(ReadOnlySpan<ProgramPipelineHandle> pipelines)
            {
                int n = (int)(pipelines.Length);
                fixed (ProgramPipelineHandle* pipelines_ptr = pipelines)
                {
                    DeleteProgramPipelinesEXT(n, pipelines_ptr);
                }
            }
            public static unsafe void DeleteProgramPipelinesEXT(ProgramPipelineHandle[] pipelines)
            {
                int n = (int)(pipelines.Length);
                fixed (ProgramPipelineHandle* pipelines_ptr = pipelines)
                {
                    DeleteProgramPipelinesEXT(n, pipelines_ptr);
                }
            }
            public static unsafe void DeleteProgramPipelinesEXT(int n, in ProgramPipelineHandle pipelines)
            {
                fixed (ProgramPipelineHandle* pipelines_ptr = &pipelines)
                {
                    DeleteProgramPipelinesEXT(n, pipelines_ptr);
                }
            }
            public static unsafe void GenProgramPipelinesEXT(Span<ProgramPipelineHandle> pipelines)
            {
                int n = (int)(pipelines.Length);
                fixed (ProgramPipelineHandle* pipelines_ptr = pipelines)
                {
                    GenProgramPipelinesEXT(n, pipelines_ptr);
                }
            }
            public static unsafe void GenProgramPipelinesEXT(ProgramPipelineHandle[] pipelines)
            {
                int n = (int)(pipelines.Length);
                fixed (ProgramPipelineHandle* pipelines_ptr = pipelines)
                {
                    GenProgramPipelinesEXT(n, pipelines_ptr);
                }
            }
            public static unsafe void GenProgramPipelinesEXT(int n, ref ProgramPipelineHandle pipelines)
            {
                fixed (ProgramPipelineHandle* pipelines_ptr = &pipelines)
                {
                    GenProgramPipelinesEXT(n, pipelines_ptr);
                }
            }
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
            public static unsafe void GetProgramPipelineivEXT(ProgramPipelineHandle pipeline, PipelineParameterName pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetProgramPipelineivEXT(pipeline, pname, parameters_ptr);
                }
            }
            public static unsafe void ProgramUniform1fvEXT(ProgramHandle program, int location, ReadOnlySpan<float> value)
            {
                int count = (int)(value.Length);
                fixed (float* value_ptr = value)
                {
                    ProgramUniform1fvEXT(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform1fvEXT(ProgramHandle program, int location, float[] value)
            {
                int count = (int)(value.Length);
                fixed (float* value_ptr = value)
                {
                    ProgramUniform1fvEXT(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform1fvEXT(ProgramHandle program, int location, int count, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    ProgramUniform1fvEXT(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform1ivEXT(ProgramHandle program, int location, ReadOnlySpan<int> value)
            {
                int count = (int)(value.Length);
                fixed (int* value_ptr = value)
                {
                    ProgramUniform1ivEXT(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform1ivEXT(ProgramHandle program, int location, int[] value)
            {
                int count = (int)(value.Length);
                fixed (int* value_ptr = value)
                {
                    ProgramUniform1ivEXT(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform1ivEXT(ProgramHandle program, int location, int count, in int value)
            {
                fixed (int* value_ptr = &value)
                {
                    ProgramUniform1ivEXT(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform2fvEXT(ProgramHandle program, int location, ReadOnlySpan<float> value)
            {
                int count = (int)(value.Length / 2);
                fixed (float* value_ptr = value)
                {
                    ProgramUniform2fvEXT(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform2fvEXT(ProgramHandle program, int location, float[] value)
            {
                int count = (int)(value.Length / 2);
                fixed (float* value_ptr = value)
                {
                    ProgramUniform2fvEXT(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform2fvEXT(ProgramHandle program, int location, int count, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    ProgramUniform2fvEXT(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform2ivEXT(ProgramHandle program, int location, ReadOnlySpan<int> value)
            {
                int count = (int)(value.Length / 2);
                fixed (int* value_ptr = value)
                {
                    ProgramUniform2ivEXT(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform2ivEXT(ProgramHandle program, int location, int[] value)
            {
                int count = (int)(value.Length / 2);
                fixed (int* value_ptr = value)
                {
                    ProgramUniform2ivEXT(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform2ivEXT(ProgramHandle program, int location, int count, in int value)
            {
                fixed (int* value_ptr = &value)
                {
                    ProgramUniform2ivEXT(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform3fvEXT(ProgramHandle program, int location, ReadOnlySpan<float> value)
            {
                int count = (int)(value.Length / 3);
                fixed (float* value_ptr = value)
                {
                    ProgramUniform3fvEXT(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform3fvEXT(ProgramHandle program, int location, float[] value)
            {
                int count = (int)(value.Length / 3);
                fixed (float* value_ptr = value)
                {
                    ProgramUniform3fvEXT(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform3fvEXT(ProgramHandle program, int location, int count, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    ProgramUniform3fvEXT(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform3ivEXT(ProgramHandle program, int location, ReadOnlySpan<int> value)
            {
                int count = (int)(value.Length / 3);
                fixed (int* value_ptr = value)
                {
                    ProgramUniform3ivEXT(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform3ivEXT(ProgramHandle program, int location, int[] value)
            {
                int count = (int)(value.Length / 3);
                fixed (int* value_ptr = value)
                {
                    ProgramUniform3ivEXT(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform3ivEXT(ProgramHandle program, int location, int count, in int value)
            {
                fixed (int* value_ptr = &value)
                {
                    ProgramUniform3ivEXT(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform4fvEXT(ProgramHandle program, int location, ReadOnlySpan<float> value)
            {
                int count = (int)(value.Length / 4);
                fixed (float* value_ptr = value)
                {
                    ProgramUniform4fvEXT(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform4fvEXT(ProgramHandle program, int location, float[] value)
            {
                int count = (int)(value.Length / 4);
                fixed (float* value_ptr = value)
                {
                    ProgramUniform4fvEXT(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform4fvEXT(ProgramHandle program, int location, int count, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    ProgramUniform4fvEXT(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform4ivEXT(ProgramHandle program, int location, ReadOnlySpan<int> value)
            {
                int count = (int)(value.Length / 4);
                fixed (int* value_ptr = value)
                {
                    ProgramUniform4ivEXT(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform4ivEXT(ProgramHandle program, int location, int[] value)
            {
                int count = (int)(value.Length / 4);
                fixed (int* value_ptr = value)
                {
                    ProgramUniform4ivEXT(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform4ivEXT(ProgramHandle program, int location, int count, in int value)
            {
                fixed (int* value_ptr = &value)
                {
                    ProgramUniform4ivEXT(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniformMatrix2fvEXT(ProgramHandle program, int location, bool transpose, ReadOnlySpan<float> value)
            {
                int count = (int)(value.Length / 4);
                fixed (float* value_ptr = value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    ProgramUniformMatrix2fvEXT(program, location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void ProgramUniformMatrix2fvEXT(ProgramHandle program, int location, bool transpose, float[] value)
            {
                int count = (int)(value.Length / 4);
                fixed (float* value_ptr = value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    ProgramUniformMatrix2fvEXT(program, location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void ProgramUniformMatrix2fvEXT(ProgramHandle program, int location, int count, bool transpose, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    ProgramUniformMatrix2fvEXT(program, location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void ProgramUniformMatrix3fvEXT(ProgramHandle program, int location, bool transpose, ReadOnlySpan<float> value)
            {
                int count = (int)(value.Length / 9);
                fixed (float* value_ptr = value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    ProgramUniformMatrix3fvEXT(program, location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void ProgramUniformMatrix3fvEXT(ProgramHandle program, int location, bool transpose, float[] value)
            {
                int count = (int)(value.Length / 9);
                fixed (float* value_ptr = value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    ProgramUniformMatrix3fvEXT(program, location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void ProgramUniformMatrix3fvEXT(ProgramHandle program, int location, int count, bool transpose, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    ProgramUniformMatrix3fvEXT(program, location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void ProgramUniformMatrix4fvEXT(ProgramHandle program, int location, bool transpose, ReadOnlySpan<float> value)
            {
                int count = (int)(value.Length / 16);
                fixed (float* value_ptr = value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    ProgramUniformMatrix4fvEXT(program, location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void ProgramUniformMatrix4fvEXT(ProgramHandle program, int location, bool transpose, float[] value)
            {
                int count = (int)(value.Length / 16);
                fixed (float* value_ptr = value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    ProgramUniformMatrix4fvEXT(program, location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void ProgramUniformMatrix4fvEXT(ProgramHandle program, int location, int count, bool transpose, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    ProgramUniformMatrix4fvEXT(program, location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void ProgramUniform1uivEXT(ProgramHandle program, int location, ReadOnlySpan<uint> value)
            {
                int count = (int)(value.Length);
                fixed (uint* value_ptr = value)
                {
                    ProgramUniform1uivEXT(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform1uivEXT(ProgramHandle program, int location, uint[] value)
            {
                int count = (int)(value.Length);
                fixed (uint* value_ptr = value)
                {
                    ProgramUniform1uivEXT(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform1uivEXT(ProgramHandle program, int location, int count, in uint value)
            {
                fixed (uint* value_ptr = &value)
                {
                    ProgramUniform1uivEXT(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform2uivEXT(ProgramHandle program, int location, ReadOnlySpan<uint> value)
            {
                int count = (int)(value.Length / 2);
                fixed (uint* value_ptr = value)
                {
                    ProgramUniform2uivEXT(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform2uivEXT(ProgramHandle program, int location, uint[] value)
            {
                int count = (int)(value.Length / 2);
                fixed (uint* value_ptr = value)
                {
                    ProgramUniform2uivEXT(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform2uivEXT(ProgramHandle program, int location, int count, in uint value)
            {
                fixed (uint* value_ptr = &value)
                {
                    ProgramUniform2uivEXT(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform3uivEXT(ProgramHandle program, int location, ReadOnlySpan<uint> value)
            {
                int count = (int)(value.Length / 3);
                fixed (uint* value_ptr = value)
                {
                    ProgramUniform3uivEXT(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform3uivEXT(ProgramHandle program, int location, uint[] value)
            {
                int count = (int)(value.Length / 3);
                fixed (uint* value_ptr = value)
                {
                    ProgramUniform3uivEXT(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform3uivEXT(ProgramHandle program, int location, int count, in uint value)
            {
                fixed (uint* value_ptr = &value)
                {
                    ProgramUniform3uivEXT(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform4uivEXT(ProgramHandle program, int location, ReadOnlySpan<uint> value)
            {
                int count = (int)(value.Length / 4);
                fixed (uint* value_ptr = value)
                {
                    ProgramUniform4uivEXT(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform4uivEXT(ProgramHandle program, int location, uint[] value)
            {
                int count = (int)(value.Length / 4);
                fixed (uint* value_ptr = value)
                {
                    ProgramUniform4uivEXT(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform4uivEXT(ProgramHandle program, int location, int count, in uint value)
            {
                fixed (uint* value_ptr = &value)
                {
                    ProgramUniform4uivEXT(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniformMatrix2x3fvEXT(ProgramHandle program, int location, bool transpose, ReadOnlySpan<float> value)
            {
                int count = (int)(value.Length / 6);
                fixed (float* value_ptr = value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    ProgramUniformMatrix2x3fvEXT(program, location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void ProgramUniformMatrix2x3fvEXT(ProgramHandle program, int location, bool transpose, float[] value)
            {
                int count = (int)(value.Length / 6);
                fixed (float* value_ptr = value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    ProgramUniformMatrix2x3fvEXT(program, location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void ProgramUniformMatrix2x3fvEXT(ProgramHandle program, int location, int count, bool transpose, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    ProgramUniformMatrix2x3fvEXT(program, location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void ProgramUniformMatrix3x2fvEXT(ProgramHandle program, int location, bool transpose, ReadOnlySpan<float> value)
            {
                int count = (int)(value.Length / 6);
                fixed (float* value_ptr = value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    ProgramUniformMatrix3x2fvEXT(program, location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void ProgramUniformMatrix3x2fvEXT(ProgramHandle program, int location, bool transpose, float[] value)
            {
                int count = (int)(value.Length / 6);
                fixed (float* value_ptr = value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    ProgramUniformMatrix3x2fvEXT(program, location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void ProgramUniformMatrix3x2fvEXT(ProgramHandle program, int location, int count, bool transpose, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    ProgramUniformMatrix3x2fvEXT(program, location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void ProgramUniformMatrix2x4fvEXT(ProgramHandle program, int location, bool transpose, ReadOnlySpan<float> value)
            {
                int count = (int)(value.Length / 8);
                fixed (float* value_ptr = value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    ProgramUniformMatrix2x4fvEXT(program, location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void ProgramUniformMatrix2x4fvEXT(ProgramHandle program, int location, bool transpose, float[] value)
            {
                int count = (int)(value.Length / 8);
                fixed (float* value_ptr = value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    ProgramUniformMatrix2x4fvEXT(program, location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void ProgramUniformMatrix2x4fvEXT(ProgramHandle program, int location, int count, bool transpose, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    ProgramUniformMatrix2x4fvEXT(program, location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void ProgramUniformMatrix4x2fvEXT(ProgramHandle program, int location, bool transpose, ReadOnlySpan<float> value)
            {
                int count = (int)(value.Length / 8);
                fixed (float* value_ptr = value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    ProgramUniformMatrix4x2fvEXT(program, location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void ProgramUniformMatrix4x2fvEXT(ProgramHandle program, int location, bool transpose, float[] value)
            {
                int count = (int)(value.Length / 8);
                fixed (float* value_ptr = value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    ProgramUniformMatrix4x2fvEXT(program, location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void ProgramUniformMatrix4x2fvEXT(ProgramHandle program, int location, int count, bool transpose, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    ProgramUniformMatrix4x2fvEXT(program, location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void ProgramUniformMatrix3x4fvEXT(ProgramHandle program, int location, bool transpose, ReadOnlySpan<float> value)
            {
                int count = (int)(value.Length / 12);
                fixed (float* value_ptr = value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    ProgramUniformMatrix3x4fvEXT(program, location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void ProgramUniformMatrix3x4fvEXT(ProgramHandle program, int location, bool transpose, float[] value)
            {
                int count = (int)(value.Length / 12);
                fixed (float* value_ptr = value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    ProgramUniformMatrix3x4fvEXT(program, location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void ProgramUniformMatrix3x4fvEXT(ProgramHandle program, int location, int count, bool transpose, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    ProgramUniformMatrix3x4fvEXT(program, location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void ProgramUniformMatrix4x3fvEXT(ProgramHandle program, int location, bool transpose, ReadOnlySpan<float> value)
            {
                int count = (int)(value.Length / 12);
                fixed (float* value_ptr = value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    ProgramUniformMatrix4x3fvEXT(program, location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void ProgramUniformMatrix4x3fvEXT(ProgramHandle program, int location, bool transpose, float[] value)
            {
                int count = (int)(value.Length / 12);
                fixed (float* value_ptr = value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    ProgramUniformMatrix4x3fvEXT(program, location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void ProgramUniformMatrix4x3fvEXT(ProgramHandle program, int location, int count, bool transpose, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    ProgramUniformMatrix4x3fvEXT(program, location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void ClearPixelLocalStorageuiEXT(int offset, ReadOnlySpan<uint> values)
            {
                int n = (int)(values.Length);
                fixed (uint* values_ptr = values)
                {
                    ClearPixelLocalStorageuiEXT(offset, n, values_ptr);
                }
            }
            public static unsafe void ClearPixelLocalStorageuiEXT(int offset, uint[] values)
            {
                int n = (int)(values.Length);
                fixed (uint* values_ptr = values)
                {
                    ClearPixelLocalStorageuiEXT(offset, n, values_ptr);
                }
            }
            public static unsafe void ClearPixelLocalStorageuiEXT(int offset, int n, in uint values)
            {
                fixed (uint* values_ptr = &values)
                {
                    ClearPixelLocalStorageuiEXT(offset, n, values_ptr);
                }
            }
            public static unsafe void TexPageCommitmentEXT(All target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, bool commit)
            {
                byte commit_byte = (byte)(commit ? 1 : 0);
                TexPageCommitmentEXT(target, level, xoffset, yoffset, zoffset, width, height, depth, commit_byte);
            }
            public static unsafe void TexParameterIivEXT(TextureTarget target, TextureParameterName pname, ReadOnlySpan<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    TexParameterIivEXT(target, pname, parameters_ptr);
                }
            }
            public static unsafe void TexParameterIivEXT(TextureTarget target, TextureParameterName pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    TexParameterIivEXT(target, pname, parameters_ptr);
                }
            }
            public static unsafe void TexParameterIivEXT(TextureTarget target, TextureParameterName pname, in int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    TexParameterIivEXT(target, pname, parameters_ptr);
                }
            }
            public static unsafe void TexParameterIuivEXT(TextureTarget target, TextureParameterName pname, ReadOnlySpan<uint> parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    TexParameterIuivEXT(target, pname, parameters_ptr);
                }
            }
            public static unsafe void TexParameterIuivEXT(TextureTarget target, TextureParameterName pname, uint[] parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    TexParameterIuivEXT(target, pname, parameters_ptr);
                }
            }
            public static unsafe void TexParameterIuivEXT(TextureTarget target, TextureParameterName pname, in uint parameters)
            {
                fixed (uint* parameters_ptr = &parameters)
                {
                    TexParameterIuivEXT(target, pname, parameters_ptr);
                }
            }
            public static unsafe void GetTexParameterIivEXT(TextureTarget target, GetTextureParameter pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexParameterIivEXT(target, pname, parameters_ptr);
                }
            }
            public static unsafe void GetTexParameterIivEXT(TextureTarget target, GetTextureParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexParameterIivEXT(target, pname, parameters_ptr);
                }
            }
            public static unsafe void GetTexParameterIivEXT(TextureTarget target, GetTextureParameter pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetTexParameterIivEXT(target, pname, parameters_ptr);
                }
            }
            public static unsafe void GetTexParameterIuivEXT(TextureTarget target, GetTextureParameter pname, Span<uint> parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    GetTexParameterIuivEXT(target, pname, parameters_ptr);
                }
            }
            public static unsafe void GetTexParameterIuivEXT(TextureTarget target, GetTextureParameter pname, uint[] parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    GetTexParameterIuivEXT(target, pname, parameters_ptr);
                }
            }
            public static unsafe void GetTexParameterIuivEXT(TextureTarget target, GetTextureParameter pname, ref uint parameters)
            {
                fixed (uint* parameters_ptr = &parameters)
                {
                    GetTexParameterIuivEXT(target, pname, parameters_ptr);
                }
            }
            public static unsafe void SamplerParameterIivEXT(SamplerHandle sampler, SamplerParameterI pname, ReadOnlySpan<int> param)
            {
                fixed (int* param_ptr = param)
                {
                    SamplerParameterIivEXT(sampler, pname, param_ptr);
                }
            }
            public static unsafe void SamplerParameterIivEXT(SamplerHandle sampler, SamplerParameterI pname, int[] param)
            {
                fixed (int* param_ptr = param)
                {
                    SamplerParameterIivEXT(sampler, pname, param_ptr);
                }
            }
            public static unsafe void SamplerParameterIivEXT(SamplerHandle sampler, SamplerParameterI pname, in int param)
            {
                fixed (int* param_ptr = &param)
                {
                    SamplerParameterIivEXT(sampler, pname, param_ptr);
                }
            }
            public static unsafe void SamplerParameterIuivEXT(SamplerHandle sampler, SamplerParameterI pname, ReadOnlySpan<uint> param)
            {
                fixed (uint* param_ptr = param)
                {
                    SamplerParameterIuivEXT(sampler, pname, param_ptr);
                }
            }
            public static unsafe void SamplerParameterIuivEXT(SamplerHandle sampler, SamplerParameterI pname, uint[] param)
            {
                fixed (uint* param_ptr = param)
                {
                    SamplerParameterIuivEXT(sampler, pname, param_ptr);
                }
            }
            public static unsafe void SamplerParameterIuivEXT(SamplerHandle sampler, SamplerParameterI pname, in uint param)
            {
                fixed (uint* param_ptr = &param)
                {
                    SamplerParameterIuivEXT(sampler, pname, param_ptr);
                }
            }
            public static unsafe void GetSamplerParameterIivEXT(SamplerHandle sampler, SamplerParameterI pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetSamplerParameterIivEXT(sampler, pname, parameters_ptr);
                }
            }
            public static unsafe void GetSamplerParameterIivEXT(SamplerHandle sampler, SamplerParameterI pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetSamplerParameterIivEXT(sampler, pname, parameters_ptr);
                }
            }
            public static unsafe void GetSamplerParameterIivEXT(SamplerHandle sampler, SamplerParameterI pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetSamplerParameterIivEXT(sampler, pname, parameters_ptr);
                }
            }
            public static unsafe void GetSamplerParameterIuivEXT(SamplerHandle sampler, SamplerParameterI pname, Span<uint> parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    GetSamplerParameterIuivEXT(sampler, pname, parameters_ptr);
                }
            }
            public static unsafe void GetSamplerParameterIuivEXT(SamplerHandle sampler, SamplerParameterI pname, uint[] parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    GetSamplerParameterIuivEXT(sampler, pname, parameters_ptr);
                }
            }
            public static unsafe void GetSamplerParameterIuivEXT(SamplerHandle sampler, SamplerParameterI pname, ref uint parameters)
            {
                fixed (uint* parameters_ptr = &parameters)
                {
                    GetSamplerParameterIuivEXT(sampler, pname, parameters_ptr);
                }
            }
            public static unsafe void WindowRectanglesEXT(All mode, int count, ReadOnlySpan<int> box)
            {
                fixed (int* box_ptr = box)
                {
                    WindowRectanglesEXT(mode, count, box_ptr);
                }
            }
            public static unsafe void WindowRectanglesEXT(All mode, int count, int[] box)
            {
                fixed (int* box_ptr = box)
                {
                    WindowRectanglesEXT(mode, count, box_ptr);
                }
            }
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
            public static unsafe void CreateSemaphoresNV(Span<uint> semaphores)
            {
                int n = (int)(semaphores.Length);
                fixed (uint* semaphores_ptr = semaphores)
                {
                    CreateSemaphoresNV(n, semaphores_ptr);
                }
            }
            public static unsafe void CreateSemaphoresNV(uint[] semaphores)
            {
                int n = (int)(semaphores.Length);
                fixed (uint* semaphores_ptr = semaphores)
                {
                    CreateSemaphoresNV(n, semaphores_ptr);
                }
            }
            public static unsafe void CreateSemaphoresNV(int n, ref uint semaphores)
            {
                fixed (uint* semaphores_ptr = &semaphores)
                {
                    CreateSemaphoresNV(n, semaphores_ptr);
                }
            }
            public static unsafe void SemaphoreParameterivNV(uint semaphore, SemaphoreParameterName pname, in int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    SemaphoreParameterivNV(semaphore, pname, parameters_ptr);
                }
            }
            public static unsafe void GetSemaphoreParameterivNV(uint semaphore, SemaphoreParameterName pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetSemaphoreParameterivNV(semaphore, pname, parameters_ptr);
                }
            }
            public static unsafe ulong GetImageHandleNV(TextureHandle texture, int level, bool layered, int layer, PixelFormat format)
            {
                ulong returnValue;
                byte layered_byte = (byte)(layered ? 1 : 0);
                returnValue = GetImageHandleNV(texture, level, layered_byte, layer, format);
                return returnValue;
            }
            public static unsafe void UniformHandleui64vNV(int location, ReadOnlySpan<ulong> value)
            {
                int count = (int)(value.Length);
                fixed (ulong* value_ptr = value)
                {
                    UniformHandleui64vNV(location, count, value_ptr);
                }
            }
            public static unsafe void UniformHandleui64vNV(int location, ulong[] value)
            {
                int count = (int)(value.Length);
                fixed (ulong* value_ptr = value)
                {
                    UniformHandleui64vNV(location, count, value_ptr);
                }
            }
            public static unsafe void UniformHandleui64vNV(int location, int count, in ulong value)
            {
                fixed (ulong* value_ptr = &value)
                {
                    UniformHandleui64vNV(location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniformHandleui64vNV(ProgramHandle program, int location, ReadOnlySpan<ulong> values)
            {
                int count = (int)(values.Length);
                fixed (ulong* values_ptr = values)
                {
                    ProgramUniformHandleui64vNV(program, location, count, values_ptr);
                }
            }
            public static unsafe void ProgramUniformHandleui64vNV(ProgramHandle program, int location, ulong[] values)
            {
                int count = (int)(values.Length);
                fixed (ulong* values_ptr = values)
                {
                    ProgramUniformHandleui64vNV(program, location, count, values_ptr);
                }
            }
            public static unsafe void ProgramUniformHandleui64vNV(ProgramHandle program, int location, int count, in ulong values)
            {
                fixed (ulong* values_ptr = &values)
                {
                    ProgramUniformHandleui64vNV(program, location, count, values_ptr);
                }
            }
            public static unsafe void CoverageMaskNV(bool mask)
            {
                byte mask_byte = (byte)(mask ? 1 : 0);
                CoverageMaskNV(mask_byte);
            }
            public static unsafe void DrawBuffersNV(ReadOnlySpan<All> bufs)
            {
                int n = (int)(bufs.Length);
                fixed (All* bufs_ptr = bufs)
                {
                    DrawBuffersNV(n, bufs_ptr);
                }
            }
            public static unsafe void DrawBuffersNV(All[] bufs)
            {
                int n = (int)(bufs.Length);
                fixed (All* bufs_ptr = bufs)
                {
                    DrawBuffersNV(n, bufs_ptr);
                }
            }
            public static unsafe void DrawBuffersNV(int n, in All bufs)
            {
                fixed (All* bufs_ptr = &bufs)
                {
                    DrawBuffersNV(n, bufs_ptr);
                }
            }
            public static unsafe void DrawElementsInstancedNV(PrimitiveType mode, int count, PrimitiveType type, nint offset, int primcount)
            {
                void* indices = (void*)offset;
                DrawElementsInstancedNV(mode, count, type, indices, primcount);
            }
            public static unsafe IntPtr GetVkProcAddrNV(string name)
            {
                IntPtr returnValue;
                byte* name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(name);
                returnValue = GetVkProcAddrNV(name_ptr);
                Marshal.FreeCoTaskMem((IntPtr)name_ptr);
                return returnValue;
            }
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
            public static unsafe void RasterSamplesEXT(uint samples, bool fixedsamplelocations)
            {
                byte fixedsamplelocations_byte = (byte)(fixedsamplelocations ? 1 : 0);
                RasterSamplesEXT(samples, fixedsamplelocations_byte);
            }
            public static unsafe void CoverageModulationTableNV(ReadOnlySpan<float> v)
            {
                int n = (int)(v.Length);
                fixed (float* v_ptr = v)
                {
                    CoverageModulationTableNV(n, v_ptr);
                }
            }
            public static unsafe void CoverageModulationTableNV(float[] v)
            {
                int n = (int)(v.Length);
                fixed (float* v_ptr = v)
                {
                    CoverageModulationTableNV(n, v_ptr);
                }
            }
            public static unsafe void CoverageModulationTableNV(int n, in float v)
            {
                fixed (float* v_ptr = &v)
                {
                    CoverageModulationTableNV(n, v_ptr);
                }
            }
            public static unsafe void GetCoverageModulationTableNV(int bufSize, ref float v)
            {
                fixed (float* v_ptr = &v)
                {
                    GetCoverageModulationTableNV(bufSize, v_ptr);
                }
            }
            public static unsafe void Uniform1i64vNV(int location, ReadOnlySpan<long> value)
            {
                int count = (int)(value.Length / 1);
                fixed (long* value_ptr = value)
                {
                    Uniform1i64vNV(location, count, value_ptr);
                }
            }
            public static unsafe void Uniform1i64vNV(int location, long[] value)
            {
                int count = (int)(value.Length / 1);
                fixed (long* value_ptr = value)
                {
                    Uniform1i64vNV(location, count, value_ptr);
                }
            }
            public static unsafe void Uniform1i64vNV(int location, int count, in long value)
            {
                fixed (long* value_ptr = &value)
                {
                    Uniform1i64vNV(location, count, value_ptr);
                }
            }
            public static unsafe void Uniform2i64vNV(int location, ReadOnlySpan<long> value)
            {
                int count = (int)(value.Length / 2);
                fixed (long* value_ptr = value)
                {
                    Uniform2i64vNV(location, count, value_ptr);
                }
            }
            public static unsafe void Uniform2i64vNV(int location, long[] value)
            {
                int count = (int)(value.Length / 2);
                fixed (long* value_ptr = value)
                {
                    Uniform2i64vNV(location, count, value_ptr);
                }
            }
            public static unsafe void Uniform2i64vNV(int location, int count, in long value)
            {
                fixed (long* value_ptr = &value)
                {
                    Uniform2i64vNV(location, count, value_ptr);
                }
            }
            public static unsafe void Uniform3i64vNV(int location, ReadOnlySpan<long> value)
            {
                int count = (int)(value.Length / 3);
                fixed (long* value_ptr = value)
                {
                    Uniform3i64vNV(location, count, value_ptr);
                }
            }
            public static unsafe void Uniform3i64vNV(int location, long[] value)
            {
                int count = (int)(value.Length / 3);
                fixed (long* value_ptr = value)
                {
                    Uniform3i64vNV(location, count, value_ptr);
                }
            }
            public static unsafe void Uniform3i64vNV(int location, int count, in long value)
            {
                fixed (long* value_ptr = &value)
                {
                    Uniform3i64vNV(location, count, value_ptr);
                }
            }
            public static unsafe void Uniform4i64vNV(int location, ReadOnlySpan<long> value)
            {
                int count = (int)(value.Length / 4);
                fixed (long* value_ptr = value)
                {
                    Uniform4i64vNV(location, count, value_ptr);
                }
            }
            public static unsafe void Uniform4i64vNV(int location, long[] value)
            {
                int count = (int)(value.Length / 4);
                fixed (long* value_ptr = value)
                {
                    Uniform4i64vNV(location, count, value_ptr);
                }
            }
            public static unsafe void Uniform4i64vNV(int location, int count, in long value)
            {
                fixed (long* value_ptr = &value)
                {
                    Uniform4i64vNV(location, count, value_ptr);
                }
            }
            public static unsafe void Uniform1ui64vNV(int location, ReadOnlySpan<ulong> value)
            {
                int count = (int)(value.Length / 1);
                fixed (ulong* value_ptr = value)
                {
                    Uniform1ui64vNV(location, count, value_ptr);
                }
            }
            public static unsafe void Uniform1ui64vNV(int location, ulong[] value)
            {
                int count = (int)(value.Length / 1);
                fixed (ulong* value_ptr = value)
                {
                    Uniform1ui64vNV(location, count, value_ptr);
                }
            }
            public static unsafe void Uniform1ui64vNV(int location, int count, in ulong value)
            {
                fixed (ulong* value_ptr = &value)
                {
                    Uniform1ui64vNV(location, count, value_ptr);
                }
            }
            public static unsafe void Uniform2ui64vNV(int location, ReadOnlySpan<ulong> value)
            {
                int count = (int)(value.Length / 2);
                fixed (ulong* value_ptr = value)
                {
                    Uniform2ui64vNV(location, count, value_ptr);
                }
            }
            public static unsafe void Uniform2ui64vNV(int location, ulong[] value)
            {
                int count = (int)(value.Length / 2);
                fixed (ulong* value_ptr = value)
                {
                    Uniform2ui64vNV(location, count, value_ptr);
                }
            }
            public static unsafe void Uniform2ui64vNV(int location, int count, in ulong value)
            {
                fixed (ulong* value_ptr = &value)
                {
                    Uniform2ui64vNV(location, count, value_ptr);
                }
            }
            public static unsafe void Uniform3ui64vNV(int location, ReadOnlySpan<ulong> value)
            {
                int count = (int)(value.Length / 3);
                fixed (ulong* value_ptr = value)
                {
                    Uniform3ui64vNV(location, count, value_ptr);
                }
            }
            public static unsafe void Uniform3ui64vNV(int location, ulong[] value)
            {
                int count = (int)(value.Length / 3);
                fixed (ulong* value_ptr = value)
                {
                    Uniform3ui64vNV(location, count, value_ptr);
                }
            }
            public static unsafe void Uniform3ui64vNV(int location, int count, in ulong value)
            {
                fixed (ulong* value_ptr = &value)
                {
                    Uniform3ui64vNV(location, count, value_ptr);
                }
            }
            public static unsafe void Uniform4ui64vNV(int location, ReadOnlySpan<ulong> value)
            {
                int count = (int)(value.Length / 4);
                fixed (ulong* value_ptr = value)
                {
                    Uniform4ui64vNV(location, count, value_ptr);
                }
            }
            public static unsafe void Uniform4ui64vNV(int location, ulong[] value)
            {
                int count = (int)(value.Length / 4);
                fixed (ulong* value_ptr = value)
                {
                    Uniform4ui64vNV(location, count, value_ptr);
                }
            }
            public static unsafe void Uniform4ui64vNV(int location, int count, in ulong value)
            {
                fixed (ulong* value_ptr = &value)
                {
                    Uniform4ui64vNV(location, count, value_ptr);
                }
            }
            public static unsafe void GetUniformi64vNV(ProgramHandle program, int location, Span<long> parameters)
            {
                fixed (long* parameters_ptr = parameters)
                {
                    GetUniformi64vNV(program, location, parameters_ptr);
                }
            }
            public static unsafe void GetUniformi64vNV(ProgramHandle program, int location, long[] parameters)
            {
                fixed (long* parameters_ptr = parameters)
                {
                    GetUniformi64vNV(program, location, parameters_ptr);
                }
            }
            public static unsafe void GetUniformi64vNV(ProgramHandle program, int location, ref long parameters)
            {
                fixed (long* parameters_ptr = &parameters)
                {
                    GetUniformi64vNV(program, location, parameters_ptr);
                }
            }
            public static unsafe void ProgramUniform1i64vNV(ProgramHandle program, int location, ReadOnlySpan<long> value)
            {
                int count = (int)(value.Length);
                fixed (long* value_ptr = value)
                {
                    ProgramUniform1i64vNV(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform1i64vNV(ProgramHandle program, int location, long[] value)
            {
                int count = (int)(value.Length);
                fixed (long* value_ptr = value)
                {
                    ProgramUniform1i64vNV(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform1i64vNV(ProgramHandle program, int location, int count, in long value)
            {
                fixed (long* value_ptr = &value)
                {
                    ProgramUniform1i64vNV(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform2i64vNV(ProgramHandle program, int location, ReadOnlySpan<long> value)
            {
                int count = (int)(value.Length / 2);
                fixed (long* value_ptr = value)
                {
                    ProgramUniform2i64vNV(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform2i64vNV(ProgramHandle program, int location, long[] value)
            {
                int count = (int)(value.Length / 2);
                fixed (long* value_ptr = value)
                {
                    ProgramUniform2i64vNV(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform2i64vNV(ProgramHandle program, int location, int count, in long value)
            {
                fixed (long* value_ptr = &value)
                {
                    ProgramUniform2i64vNV(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform3i64vNV(ProgramHandle program, int location, ReadOnlySpan<long> value)
            {
                int count = (int)(value.Length / 3);
                fixed (long* value_ptr = value)
                {
                    ProgramUniform3i64vNV(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform3i64vNV(ProgramHandle program, int location, long[] value)
            {
                int count = (int)(value.Length / 3);
                fixed (long* value_ptr = value)
                {
                    ProgramUniform3i64vNV(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform3i64vNV(ProgramHandle program, int location, int count, in long value)
            {
                fixed (long* value_ptr = &value)
                {
                    ProgramUniform3i64vNV(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform4i64vNV(ProgramHandle program, int location, ReadOnlySpan<long> value)
            {
                int count = (int)(value.Length / 4);
                fixed (long* value_ptr = value)
                {
                    ProgramUniform4i64vNV(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform4i64vNV(ProgramHandle program, int location, long[] value)
            {
                int count = (int)(value.Length / 4);
                fixed (long* value_ptr = value)
                {
                    ProgramUniform4i64vNV(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform4i64vNV(ProgramHandle program, int location, int count, in long value)
            {
                fixed (long* value_ptr = &value)
                {
                    ProgramUniform4i64vNV(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform1ui64vNV(ProgramHandle program, int location, ReadOnlySpan<ulong> value)
            {
                int count = (int)(value.Length);
                fixed (ulong* value_ptr = value)
                {
                    ProgramUniform1ui64vNV(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform1ui64vNV(ProgramHandle program, int location, ulong[] value)
            {
                int count = (int)(value.Length);
                fixed (ulong* value_ptr = value)
                {
                    ProgramUniform1ui64vNV(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform1ui64vNV(ProgramHandle program, int location, int count, in ulong value)
            {
                fixed (ulong* value_ptr = &value)
                {
                    ProgramUniform1ui64vNV(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform2ui64vNV(ProgramHandle program, int location, ReadOnlySpan<ulong> value)
            {
                int count = (int)(value.Length / 2);
                fixed (ulong* value_ptr = value)
                {
                    ProgramUniform2ui64vNV(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform2ui64vNV(ProgramHandle program, int location, ulong[] value)
            {
                int count = (int)(value.Length / 2);
                fixed (ulong* value_ptr = value)
                {
                    ProgramUniform2ui64vNV(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform2ui64vNV(ProgramHandle program, int location, int count, in ulong value)
            {
                fixed (ulong* value_ptr = &value)
                {
                    ProgramUniform2ui64vNV(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform3ui64vNV(ProgramHandle program, int location, ReadOnlySpan<ulong> value)
            {
                int count = (int)(value.Length / 3);
                fixed (ulong* value_ptr = value)
                {
                    ProgramUniform3ui64vNV(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform3ui64vNV(ProgramHandle program, int location, ulong[] value)
            {
                int count = (int)(value.Length / 3);
                fixed (ulong* value_ptr = value)
                {
                    ProgramUniform3ui64vNV(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform3ui64vNV(ProgramHandle program, int location, int count, in ulong value)
            {
                fixed (ulong* value_ptr = &value)
                {
                    ProgramUniform3ui64vNV(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform4ui64vNV(ProgramHandle program, int location, ReadOnlySpan<ulong> value)
            {
                int count = (int)(value.Length / 4);
                fixed (ulong* value_ptr = value)
                {
                    ProgramUniform4ui64vNV(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform4ui64vNV(ProgramHandle program, int location, ulong[] value)
            {
                int count = (int)(value.Length / 4);
                fixed (ulong* value_ptr = value)
                {
                    ProgramUniform4ui64vNV(program, location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniform4ui64vNV(ProgramHandle program, int location, int count, in ulong value)
            {
                fixed (ulong* value_ptr = &value)
                {
                    ProgramUniform4ui64vNV(program, location, count, value_ptr);
                }
            }
            public static unsafe void GetInternalformatSampleivNV(TextureTarget target, InternalFormat internalformat, int samples, InternalFormatPName pname, Span<int> parameters)
            {
                int count = (int)(parameters.Length);
                fixed (int* parameters_ptr = parameters)
                {
                    GetInternalformatSampleivNV(target, internalformat, samples, pname, count, parameters_ptr);
                }
            }
            public static unsafe void GetInternalformatSampleivNV(TextureTarget target, InternalFormat internalformat, int samples, InternalFormatPName pname, int[] parameters)
            {
                int count = (int)(parameters.Length);
                fixed (int* parameters_ptr = parameters)
                {
                    GetInternalformatSampleivNV(target, internalformat, samples, pname, count, parameters_ptr);
                }
            }
            public static unsafe void GetInternalformatSampleivNV(TextureTarget target, InternalFormat internalformat, int samples, InternalFormatPName pname, int count, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetInternalformatSampleivNV(target, internalformat, samples, pname, count, parameters_ptr);
                }
            }
            public static unsafe void GetMemoryObjectDetachedResourcesuivNV(uint memory, All pname, int first, int count, ref uint parameters)
            {
                fixed (uint* parameters_ptr = &parameters)
                {
                    GetMemoryObjectDetachedResourcesuivNV(memory, pname, first, count, parameters_ptr);
                }
            }
            public static unsafe void BufferPageCommitmentMemNV(BufferStorageTarget target, IntPtr offset, nint size, uint memory, ulong memOffset, bool commit)
            {
                byte commit_byte = (byte)(commit ? 1 : 0);
                BufferPageCommitmentMemNV(target, offset, size, memory, memOffset, commit_byte);
            }
            public static unsafe void TexPageCommitmentMemNV(TextureTarget target, int layer, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint memory, ulong offset, bool commit)
            {
                byte commit_byte = (byte)(commit ? 1 : 0);
                TexPageCommitmentMemNV(target, layer, level, xoffset, yoffset, zoffset, width, height, depth, memory, offset, commit_byte);
            }
            public static unsafe void NamedBufferPageCommitmentMemNV(BufferHandle buffer, IntPtr offset, nint size, uint memory, ulong memOffset, bool commit)
            {
                byte commit_byte = (byte)(commit ? 1 : 0);
                NamedBufferPageCommitmentMemNV(buffer, offset, size, memory, memOffset, commit_byte);
            }
            public static unsafe void TexturePageCommitmentMemNV(TextureHandle texture, int layer, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint memory, ulong offset, bool commit)
            {
                byte commit_byte = (byte)(commit ? 1 : 0);
                TexturePageCommitmentMemNV(texture, layer, level, xoffset, yoffset, zoffset, width, height, depth, memory, offset, commit_byte);
            }
            public static unsafe void UniformMatrix2x3fvNV(int location, bool transpose, ReadOnlySpan<float> value)
            {
                int count = (int)(value.Length / 6);
                fixed (float* value_ptr = value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    UniformMatrix2x3fvNV(location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void UniformMatrix2x3fvNV(int location, bool transpose, float[] value)
            {
                int count = (int)(value.Length / 6);
                fixed (float* value_ptr = value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    UniformMatrix2x3fvNV(location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void UniformMatrix2x3fvNV(int location, int count, bool transpose, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    UniformMatrix2x3fvNV(location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void UniformMatrix3x2fvNV(int location, bool transpose, ReadOnlySpan<float> value)
            {
                int count = (int)(value.Length / 6);
                fixed (float* value_ptr = value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    UniformMatrix3x2fvNV(location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void UniformMatrix3x2fvNV(int location, bool transpose, float[] value)
            {
                int count = (int)(value.Length / 6);
                fixed (float* value_ptr = value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    UniformMatrix3x2fvNV(location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void UniformMatrix3x2fvNV(int location, int count, bool transpose, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    UniformMatrix3x2fvNV(location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void UniformMatrix2x4fvNV(int location, bool transpose, ReadOnlySpan<float> value)
            {
                int count = (int)(value.Length / 8);
                fixed (float* value_ptr = value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    UniformMatrix2x4fvNV(location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void UniformMatrix2x4fvNV(int location, bool transpose, float[] value)
            {
                int count = (int)(value.Length / 8);
                fixed (float* value_ptr = value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    UniformMatrix2x4fvNV(location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void UniformMatrix2x4fvNV(int location, int count, bool transpose, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    UniformMatrix2x4fvNV(location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void UniformMatrix4x2fvNV(int location, bool transpose, ReadOnlySpan<float> value)
            {
                int count = (int)(value.Length / 8);
                fixed (float* value_ptr = value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    UniformMatrix4x2fvNV(location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void UniformMatrix4x2fvNV(int location, bool transpose, float[] value)
            {
                int count = (int)(value.Length / 8);
                fixed (float* value_ptr = value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    UniformMatrix4x2fvNV(location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void UniformMatrix4x2fvNV(int location, int count, bool transpose, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    UniformMatrix4x2fvNV(location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void UniformMatrix3x4fvNV(int location, bool transpose, ReadOnlySpan<float> value)
            {
                int count = (int)(value.Length / 12);
                fixed (float* value_ptr = value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    UniformMatrix3x4fvNV(location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void UniformMatrix3x4fvNV(int location, bool transpose, float[] value)
            {
                int count = (int)(value.Length / 12);
                fixed (float* value_ptr = value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    UniformMatrix3x4fvNV(location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void UniformMatrix3x4fvNV(int location, int count, bool transpose, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    UniformMatrix3x4fvNV(location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void UniformMatrix4x3fvNV(int location, bool transpose, ReadOnlySpan<float> value)
            {
                int count = (int)(value.Length / 12);
                fixed (float* value_ptr = value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    UniformMatrix4x3fvNV(location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void UniformMatrix4x3fvNV(int location, bool transpose, float[] value)
            {
                int count = (int)(value.Length / 12);
                fixed (float* value_ptr = value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    UniformMatrix4x3fvNV(location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void UniformMatrix4x3fvNV(int location, int count, bool transpose, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    byte transpose_byte = (byte)(transpose ? 1 : 0);
                    UniformMatrix4x3fvNV(location, count, transpose_byte, value_ptr);
                }
            }
            public static unsafe void PathCommandsNV(uint path, ReadOnlySpan<byte> commands, int numCoords, PathCoordType coordType, IntPtr coords)
            {
                int numCommands = (int)(commands.Length);
                fixed (byte* commands_ptr = commands)
                {
                    void* coords_vptr = (void*)coords;
                    PathCommandsNV(path, numCommands, commands_ptr, numCoords, coordType, coords_vptr);
                }
            }
            public static unsafe void PathCommandsNV(uint path, byte[] commands, int numCoords, PathCoordType coordType, IntPtr coords)
            {
                int numCommands = (int)(commands.Length);
                fixed (byte* commands_ptr = commands)
                {
                    void* coords_vptr = (void*)coords;
                    PathCommandsNV(path, numCommands, commands_ptr, numCoords, coordType, coords_vptr);
                }
            }
            public static unsafe void PathCommandsNV(uint path, int numCommands, in byte commands, int numCoords, PathCoordType coordType, IntPtr coords)
            {
                fixed (byte* commands_ptr = &commands)
                {
                    void* coords_vptr = (void*)coords;
                    PathCommandsNV(path, numCommands, commands_ptr, numCoords, coordType, coords_vptr);
                }
            }
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
            public static unsafe void PathCommandsNV<T1>(uint path, int numCommands, in byte commands, int numCoords, PathCoordType coordType, in T1 coords)
                where T1 : unmanaged
            {
                fixed (byte* commands_ptr = &commands)
                fixed (void* coords_ptr = &coords)
                {
                    PathCommandsNV(path, numCommands, commands_ptr, numCoords, coordType, coords_ptr);
                }
            }
            public static unsafe void PathCoordsNV(uint path, int numCoords, PathCoordType coordType, IntPtr coords)
            {
                void* coords_vptr = (void*)coords;
                PathCoordsNV(path, numCoords, coordType, coords_vptr);
            }
            public static unsafe void PathCoordsNV<T1>(uint path, int numCoords, PathCoordType coordType, ReadOnlySpan<T1> coords)
                where T1 : unmanaged
            {
                fixed (void* coords_ptr = coords)
                {
                    PathCoordsNV(path, numCoords, coordType, coords_ptr);
                }
            }
            public static unsafe void PathCoordsNV<T1>(uint path, int numCoords, PathCoordType coordType, T1[] coords)
                where T1 : unmanaged
            {
                fixed (void* coords_ptr = coords)
                {
                    PathCoordsNV(path, numCoords, coordType, coords_ptr);
                }
            }
            public static unsafe void PathCoordsNV<T1>(uint path, int numCoords, PathCoordType coordType, in T1 coords)
                where T1 : unmanaged
            {
                fixed (void* coords_ptr = &coords)
                {
                    PathCoordsNV(path, numCoords, coordType, coords_ptr);
                }
            }
            public static unsafe void PathSubCommandsNV(uint path, int commandStart, int commandsToDelete, ReadOnlySpan<byte> commands, int numCoords, PathCoordType coordType, IntPtr coords)
            {
                int numCommands = (int)(commands.Length);
                fixed (byte* commands_ptr = commands)
                {
                    void* coords_vptr = (void*)coords;
                    PathSubCommandsNV(path, commandStart, commandsToDelete, numCommands, commands_ptr, numCoords, coordType, coords_vptr);
                }
            }
            public static unsafe void PathSubCommandsNV(uint path, int commandStart, int commandsToDelete, byte[] commands, int numCoords, PathCoordType coordType, IntPtr coords)
            {
                int numCommands = (int)(commands.Length);
                fixed (byte* commands_ptr = commands)
                {
                    void* coords_vptr = (void*)coords;
                    PathSubCommandsNV(path, commandStart, commandsToDelete, numCommands, commands_ptr, numCoords, coordType, coords_vptr);
                }
            }
            public static unsafe void PathSubCommandsNV(uint path, int commandStart, int commandsToDelete, int numCommands, in byte commands, int numCoords, PathCoordType coordType, IntPtr coords)
            {
                fixed (byte* commands_ptr = &commands)
                {
                    void* coords_vptr = (void*)coords;
                    PathSubCommandsNV(path, commandStart, commandsToDelete, numCommands, commands_ptr, numCoords, coordType, coords_vptr);
                }
            }
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
            public static unsafe void PathSubCommandsNV<T1>(uint path, int commandStart, int commandsToDelete, int numCommands, in byte commands, int numCoords, PathCoordType coordType, in T1 coords)
                where T1 : unmanaged
            {
                fixed (byte* commands_ptr = &commands)
                fixed (void* coords_ptr = &coords)
                {
                    PathSubCommandsNV(path, commandStart, commandsToDelete, numCommands, commands_ptr, numCoords, coordType, coords_ptr);
                }
            }
            public static unsafe void PathSubCoordsNV(uint path, int coordStart, int numCoords, PathCoordType coordType, IntPtr coords)
            {
                void* coords_vptr = (void*)coords;
                PathSubCoordsNV(path, coordStart, numCoords, coordType, coords_vptr);
            }
            public static unsafe void PathSubCoordsNV<T1>(uint path, int coordStart, int numCoords, PathCoordType coordType, ReadOnlySpan<T1> coords)
                where T1 : unmanaged
            {
                fixed (void* coords_ptr = coords)
                {
                    PathSubCoordsNV(path, coordStart, numCoords, coordType, coords_ptr);
                }
            }
            public static unsafe void PathSubCoordsNV<T1>(uint path, int coordStart, int numCoords, PathCoordType coordType, T1[] coords)
                where T1 : unmanaged
            {
                fixed (void* coords_ptr = coords)
                {
                    PathSubCoordsNV(path, coordStart, numCoords, coordType, coords_ptr);
                }
            }
            public static unsafe void PathSubCoordsNV<T1>(uint path, int coordStart, int numCoords, PathCoordType coordType, in T1 coords)
                where T1 : unmanaged
            {
                fixed (void* coords_ptr = &coords)
                {
                    PathSubCoordsNV(path, coordStart, numCoords, coordType, coords_ptr);
                }
            }
            public static unsafe void PathStringNV(uint path, PathStringFormat format, int length, IntPtr pathString)
            {
                void* pathString_vptr = (void*)pathString;
                PathStringNV(path, format, length, pathString_vptr);
            }
            public static unsafe void PathStringNV<T1>(uint path, PathStringFormat format, ReadOnlySpan<T1> pathString)
                where T1 : unmanaged
            {
                int length = (int)(pathString.Length * sizeof(T1));
                fixed (void* pathString_ptr = pathString)
                {
                    PathStringNV(path, format, length, pathString_ptr);
                }
            }
            public static unsafe void PathStringNV<T1>(uint path, PathStringFormat format, T1[] pathString)
                where T1 : unmanaged
            {
                int length = (int)(pathString.Length * sizeof(T1));
                fixed (void* pathString_ptr = pathString)
                {
                    PathStringNV(path, format, length, pathString_ptr);
                }
            }
            public static unsafe void PathStringNV<T1>(uint path, PathStringFormat format, int length, in T1 pathString)
                where T1 : unmanaged
            {
                fixed (void* pathString_ptr = &pathString)
                {
                    PathStringNV(path, format, length, pathString_ptr);
                }
            }
            public static unsafe void PathGlyphsNV(uint firstPathName, PathFontTarget fontTarget, IntPtr fontName, PathFontStyle fontStyle, int numGlyphs, PathElementType type, IntPtr charcodes, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale)
            {
                void* fontName_vptr = (void*)fontName;
                void* charcodes_vptr = (void*)charcodes;
                PathGlyphsNV(firstPathName, fontTarget, fontName_vptr, fontStyle, numGlyphs, type, charcodes_vptr, handleMissingGlyphs, pathParameterTemplate, emScale);
            }
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
            public static unsafe void PathGlyphRangeNV(uint firstPathName, PathFontTarget fontTarget, IntPtr fontName, PathFontStyle fontStyle, uint firstGlyph, int numGlyphs, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale)
            {
                void* fontName_vptr = (void*)fontName;
                PathGlyphRangeNV(firstPathName, fontTarget, fontName_vptr, fontStyle, firstGlyph, numGlyphs, handleMissingGlyphs, pathParameterTemplate, emScale);
            }
            public static unsafe void PathGlyphRangeNV<T1>(uint firstPathName, PathFontTarget fontTarget, ReadOnlySpan<T1> fontName, PathFontStyle fontStyle, uint firstGlyph, int numGlyphs, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale)
                where T1 : unmanaged
            {
                fixed (void* fontName_ptr = fontName)
                {
                    PathGlyphRangeNV(firstPathName, fontTarget, fontName_ptr, fontStyle, firstGlyph, numGlyphs, handleMissingGlyphs, pathParameterTemplate, emScale);
                }
            }
            public static unsafe void PathGlyphRangeNV<T1>(uint firstPathName, PathFontTarget fontTarget, T1[] fontName, PathFontStyle fontStyle, uint firstGlyph, int numGlyphs, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale)
                where T1 : unmanaged
            {
                fixed (void* fontName_ptr = fontName)
                {
                    PathGlyphRangeNV(firstPathName, fontTarget, fontName_ptr, fontStyle, firstGlyph, numGlyphs, handleMissingGlyphs, pathParameterTemplate, emScale);
                }
            }
            public static unsafe void PathGlyphRangeNV<T1>(uint firstPathName, PathFontTarget fontTarget, in T1 fontName, PathFontStyle fontStyle, uint firstGlyph, int numGlyphs, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale)
                where T1 : unmanaged
            {
                fixed (void* fontName_ptr = &fontName)
                {
                    PathGlyphRangeNV(firstPathName, fontTarget, fontName_ptr, fontStyle, firstGlyph, numGlyphs, handleMissingGlyphs, pathParameterTemplate, emScale);
                }
            }
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
            public static unsafe void WeightPathsNV(uint resultPath, int numPaths, in uint paths, in float weights)
            {
                fixed (uint* paths_ptr = &paths)
                fixed (float* weights_ptr = &weights)
                {
                    WeightPathsNV(resultPath, numPaths, paths_ptr, weights_ptr);
                }
            }
            public static unsafe void TransformPathNV(uint resultPath, uint srcPath, PathTransformType transformType, ReadOnlySpan<float> transformValues)
            {
                fixed (float* transformValues_ptr = transformValues)
                {
                    TransformPathNV(resultPath, srcPath, transformType, transformValues_ptr);
                }
            }
            public static unsafe void TransformPathNV(uint resultPath, uint srcPath, PathTransformType transformType, float[] transformValues)
            {
                fixed (float* transformValues_ptr = transformValues)
                {
                    TransformPathNV(resultPath, srcPath, transformType, transformValues_ptr);
                }
            }
            public static unsafe void TransformPathNV(uint resultPath, uint srcPath, PathTransformType transformType, in float transformValues)
            {
                fixed (float* transformValues_ptr = &transformValues)
                {
                    TransformPathNV(resultPath, srcPath, transformType, transformValues_ptr);
                }
            }
            public static unsafe void PathParameterivNV(uint path, PathParameter pname, ReadOnlySpan<int> value)
            {
                fixed (int* value_ptr = value)
                {
                    PathParameterivNV(path, pname, value_ptr);
                }
            }
            public static unsafe void PathParameterivNV(uint path, PathParameter pname, int[] value)
            {
                fixed (int* value_ptr = value)
                {
                    PathParameterivNV(path, pname, value_ptr);
                }
            }
            public static unsafe void PathParameterivNV(uint path, PathParameter pname, in int value)
            {
                fixed (int* value_ptr = &value)
                {
                    PathParameterivNV(path, pname, value_ptr);
                }
            }
            public static unsafe void PathParameterfvNV(uint path, PathParameter pname, ReadOnlySpan<float> value)
            {
                fixed (float* value_ptr = value)
                {
                    PathParameterfvNV(path, pname, value_ptr);
                }
            }
            public static unsafe void PathParameterfvNV(uint path, PathParameter pname, float[] value)
            {
                fixed (float* value_ptr = value)
                {
                    PathParameterfvNV(path, pname, value_ptr);
                }
            }
            public static unsafe void PathParameterfvNV(uint path, PathParameter pname, in float value)
            {
                fixed (float* value_ptr = &value)
                {
                    PathParameterfvNV(path, pname, value_ptr);
                }
            }
            public static unsafe void PathDashArrayNV(uint path, ReadOnlySpan<float> dashArray)
            {
                int dashCount = (int)(dashArray.Length);
                fixed (float* dashArray_ptr = dashArray)
                {
                    PathDashArrayNV(path, dashCount, dashArray_ptr);
                }
            }
            public static unsafe void PathDashArrayNV(uint path, float[] dashArray)
            {
                int dashCount = (int)(dashArray.Length);
                fixed (float* dashArray_ptr = dashArray)
                {
                    PathDashArrayNV(path, dashCount, dashArray_ptr);
                }
            }
            public static unsafe void PathDashArrayNV(uint path, int dashCount, in float dashArray)
            {
                fixed (float* dashArray_ptr = &dashArray)
                {
                    PathDashArrayNV(path, dashCount, dashArray_ptr);
                }
            }
            public static unsafe void StencilFillPathInstancedNV(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, PathFillMode fillMode, uint mask, PathTransformType transformType, ReadOnlySpan<float> transformValues)
            {
                fixed (float* transformValues_ptr = transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    StencilFillPathInstancedNV(numPaths, pathNameType, paths_vptr, pathBase, fillMode, mask, transformType, transformValues_ptr);
                }
            }
            public static unsafe void StencilFillPathInstancedNV(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, PathFillMode fillMode, uint mask, PathTransformType transformType, float[] transformValues)
            {
                fixed (float* transformValues_ptr = transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    StencilFillPathInstancedNV(numPaths, pathNameType, paths_vptr, pathBase, fillMode, mask, transformType, transformValues_ptr);
                }
            }
            public static unsafe void StencilFillPathInstancedNV(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, PathFillMode fillMode, uint mask, PathTransformType transformType, in float transformValues)
            {
                fixed (float* transformValues_ptr = &transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    StencilFillPathInstancedNV(numPaths, pathNameType, paths_vptr, pathBase, fillMode, mask, transformType, transformValues_ptr);
                }
            }
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
            public static unsafe void StencilFillPathInstancedNV<T1>(int numPaths, PathElementType pathNameType, in T1 paths, uint pathBase, PathFillMode fillMode, uint mask, PathTransformType transformType, in float transformValues)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = &paths)
                fixed (float* transformValues_ptr = &transformValues)
                {
                    StencilFillPathInstancedNV(numPaths, pathNameType, paths_ptr, pathBase, fillMode, mask, transformType, transformValues_ptr);
                }
            }
            public static unsafe void StencilStrokePathInstancedNV(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, int reference, uint mask, PathTransformType transformType, ReadOnlySpan<float> transformValues)
            {
                fixed (float* transformValues_ptr = transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    StencilStrokePathInstancedNV(numPaths, pathNameType, paths_vptr, pathBase, reference, mask, transformType, transformValues_ptr);
                }
            }
            public static unsafe void StencilStrokePathInstancedNV(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, int reference, uint mask, PathTransformType transformType, float[] transformValues)
            {
                fixed (float* transformValues_ptr = transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    StencilStrokePathInstancedNV(numPaths, pathNameType, paths_vptr, pathBase, reference, mask, transformType, transformValues_ptr);
                }
            }
            public static unsafe void StencilStrokePathInstancedNV(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, int reference, uint mask, PathTransformType transformType, in float transformValues)
            {
                fixed (float* transformValues_ptr = &transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    StencilStrokePathInstancedNV(numPaths, pathNameType, paths_vptr, pathBase, reference, mask, transformType, transformValues_ptr);
                }
            }
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
            public static unsafe void StencilStrokePathInstancedNV<T1>(int numPaths, PathElementType pathNameType, in T1 paths, uint pathBase, int reference, uint mask, PathTransformType transformType, in float transformValues)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = &paths)
                fixed (float* transformValues_ptr = &transformValues)
                {
                    StencilStrokePathInstancedNV(numPaths, pathNameType, paths_ptr, pathBase, reference, mask, transformType, transformValues_ptr);
                }
            }
            public static unsafe void CoverFillPathInstancedNV(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, PathCoverMode coverMode, PathTransformType transformType, ReadOnlySpan<float> transformValues)
            {
                fixed (float* transformValues_ptr = transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    CoverFillPathInstancedNV(numPaths, pathNameType, paths_vptr, pathBase, coverMode, transformType, transformValues_ptr);
                }
            }
            public static unsafe void CoverFillPathInstancedNV(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, PathCoverMode coverMode, PathTransformType transformType, float[] transformValues)
            {
                fixed (float* transformValues_ptr = transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    CoverFillPathInstancedNV(numPaths, pathNameType, paths_vptr, pathBase, coverMode, transformType, transformValues_ptr);
                }
            }
            public static unsafe void CoverFillPathInstancedNV(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, PathCoverMode coverMode, PathTransformType transformType, in float transformValues)
            {
                fixed (float* transformValues_ptr = &transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    CoverFillPathInstancedNV(numPaths, pathNameType, paths_vptr, pathBase, coverMode, transformType, transformValues_ptr);
                }
            }
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
            public static unsafe void CoverFillPathInstancedNV<T1>(int numPaths, PathElementType pathNameType, in T1 paths, uint pathBase, PathCoverMode coverMode, PathTransformType transformType, in float transformValues)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = &paths)
                fixed (float* transformValues_ptr = &transformValues)
                {
                    CoverFillPathInstancedNV(numPaths, pathNameType, paths_ptr, pathBase, coverMode, transformType, transformValues_ptr);
                }
            }
            public static unsafe void CoverStrokePathInstancedNV(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, PathCoverMode coverMode, PathTransformType transformType, ReadOnlySpan<float> transformValues)
            {
                fixed (float* transformValues_ptr = transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    CoverStrokePathInstancedNV(numPaths, pathNameType, paths_vptr, pathBase, coverMode, transformType, transformValues_ptr);
                }
            }
            public static unsafe void CoverStrokePathInstancedNV(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, PathCoverMode coverMode, PathTransformType transformType, float[] transformValues)
            {
                fixed (float* transformValues_ptr = transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    CoverStrokePathInstancedNV(numPaths, pathNameType, paths_vptr, pathBase, coverMode, transformType, transformValues_ptr);
                }
            }
            public static unsafe void CoverStrokePathInstancedNV(int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, PathCoverMode coverMode, PathTransformType transformType, in float transformValues)
            {
                fixed (float* transformValues_ptr = &transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    CoverStrokePathInstancedNV(numPaths, pathNameType, paths_vptr, pathBase, coverMode, transformType, transformValues_ptr);
                }
            }
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
            public static unsafe void CoverStrokePathInstancedNV<T1>(int numPaths, PathElementType pathNameType, in T1 paths, uint pathBase, PathCoverMode coverMode, PathTransformType transformType, in float transformValues)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = &paths)
                fixed (float* transformValues_ptr = &transformValues)
                {
                    CoverStrokePathInstancedNV(numPaths, pathNameType, paths_ptr, pathBase, coverMode, transformType, transformValues_ptr);
                }
            }
            public static unsafe void GetPathParameterivNV(uint path, PathParameter pname, Span<int> value)
            {
                fixed (int* value_ptr = value)
                {
                    GetPathParameterivNV(path, pname, value_ptr);
                }
            }
            public static unsafe void GetPathParameterivNV(uint path, PathParameter pname, int[] value)
            {
                fixed (int* value_ptr = value)
                {
                    GetPathParameterivNV(path, pname, value_ptr);
                }
            }
            public static unsafe void GetPathParameterivNV(uint path, PathParameter pname, ref int value)
            {
                fixed (int* value_ptr = &value)
                {
                    GetPathParameterivNV(path, pname, value_ptr);
                }
            }
            public static unsafe void GetPathParameterfvNV(uint path, PathParameter pname, Span<float> value)
            {
                fixed (float* value_ptr = value)
                {
                    GetPathParameterfvNV(path, pname, value_ptr);
                }
            }
            public static unsafe void GetPathParameterfvNV(uint path, PathParameter pname, float[] value)
            {
                fixed (float* value_ptr = value)
                {
                    GetPathParameterfvNV(path, pname, value_ptr);
                }
            }
            public static unsafe void GetPathParameterfvNV(uint path, PathParameter pname, ref float value)
            {
                fixed (float* value_ptr = &value)
                {
                    GetPathParameterfvNV(path, pname, value_ptr);
                }
            }
            public static unsafe void GetPathCommandsNV(uint path, Span<byte> commands)
            {
                fixed (byte* commands_ptr = commands)
                {
                    GetPathCommandsNV(path, commands_ptr);
                }
            }
            public static unsafe void GetPathCommandsNV(uint path, byte[] commands)
            {
                fixed (byte* commands_ptr = commands)
                {
                    GetPathCommandsNV(path, commands_ptr);
                }
            }
            public static unsafe void GetPathCommandsNV(uint path, ref byte commands)
            {
                fixed (byte* commands_ptr = &commands)
                {
                    GetPathCommandsNV(path, commands_ptr);
                }
            }
            public static unsafe void GetPathCoordsNV(uint path, Span<float> coords)
            {
                fixed (float* coords_ptr = coords)
                {
                    GetPathCoordsNV(path, coords_ptr);
                }
            }
            public static unsafe void GetPathCoordsNV(uint path, float[] coords)
            {
                fixed (float* coords_ptr = coords)
                {
                    GetPathCoordsNV(path, coords_ptr);
                }
            }
            public static unsafe void GetPathCoordsNV(uint path, ref float coords)
            {
                fixed (float* coords_ptr = &coords)
                {
                    GetPathCoordsNV(path, coords_ptr);
                }
            }
            public static unsafe void GetPathDashArrayNV(uint path, Span<float> dashArray)
            {
                fixed (float* dashArray_ptr = dashArray)
                {
                    GetPathDashArrayNV(path, dashArray_ptr);
                }
            }
            public static unsafe void GetPathDashArrayNV(uint path, float[] dashArray)
            {
                fixed (float* dashArray_ptr = dashArray)
                {
                    GetPathDashArrayNV(path, dashArray_ptr);
                }
            }
            public static unsafe void GetPathDashArrayNV(uint path, ref float dashArray)
            {
                fixed (float* dashArray_ptr = &dashArray)
                {
                    GetPathDashArrayNV(path, dashArray_ptr);
                }
            }
            public static unsafe void GetPathMetricsNV(PathMetricMask metricQueryMask, int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, int stride, Span<float> metrics)
            {
                fixed (float* metrics_ptr = metrics)
                {
                    void* paths_vptr = (void*)paths;
                    GetPathMetricsNV(metricQueryMask, numPaths, pathNameType, paths_vptr, pathBase, stride, metrics_ptr);
                }
            }
            public static unsafe void GetPathMetricsNV(PathMetricMask metricQueryMask, int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, int stride, float[] metrics)
            {
                fixed (float* metrics_ptr = metrics)
                {
                    void* paths_vptr = (void*)paths;
                    GetPathMetricsNV(metricQueryMask, numPaths, pathNameType, paths_vptr, pathBase, stride, metrics_ptr);
                }
            }
            public static unsafe void GetPathMetricsNV(PathMetricMask metricQueryMask, int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, int stride, ref float metrics)
            {
                fixed (float* metrics_ptr = &metrics)
                {
                    void* paths_vptr = (void*)paths;
                    GetPathMetricsNV(metricQueryMask, numPaths, pathNameType, paths_vptr, pathBase, stride, metrics_ptr);
                }
            }
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
            public static unsafe void GetPathMetricsNV<T1>(PathMetricMask metricQueryMask, int numPaths, PathElementType pathNameType, in T1 paths, uint pathBase, int stride, ref float metrics)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = &paths)
                fixed (float* metrics_ptr = &metrics)
                {
                    GetPathMetricsNV(metricQueryMask, numPaths, pathNameType, paths_ptr, pathBase, stride, metrics_ptr);
                }
            }
            public static unsafe void GetPathMetricRangeNV(PathMetricMask metricQueryMask, uint firstPathName, int numPaths, int stride, Span<float> metrics)
            {
                fixed (float* metrics_ptr = metrics)
                {
                    GetPathMetricRangeNV(metricQueryMask, firstPathName, numPaths, stride, metrics_ptr);
                }
            }
            public static unsafe void GetPathMetricRangeNV(PathMetricMask metricQueryMask, uint firstPathName, int numPaths, int stride, float[] metrics)
            {
                fixed (float* metrics_ptr = metrics)
                {
                    GetPathMetricRangeNV(metricQueryMask, firstPathName, numPaths, stride, metrics_ptr);
                }
            }
            public static unsafe void GetPathMetricRangeNV(PathMetricMask metricQueryMask, uint firstPathName, int numPaths, int stride, ref float metrics)
            {
                fixed (float* metrics_ptr = &metrics)
                {
                    GetPathMetricRangeNV(metricQueryMask, firstPathName, numPaths, stride, metrics_ptr);
                }
            }
            public static unsafe void GetPathSpacingNV(PathListMode pathListMode, int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, float advanceScale, float kerningScale, PathTransformType transformType, Span<float> returnedSpacing)
            {
                fixed (float* returnedSpacing_ptr = returnedSpacing)
                {
                    void* paths_vptr = (void*)paths;
                    GetPathSpacingNV(pathListMode, numPaths, pathNameType, paths_vptr, pathBase, advanceScale, kerningScale, transformType, returnedSpacing_ptr);
                }
            }
            public static unsafe void GetPathSpacingNV(PathListMode pathListMode, int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, float advanceScale, float kerningScale, PathTransformType transformType, float[] returnedSpacing)
            {
                fixed (float* returnedSpacing_ptr = returnedSpacing)
                {
                    void* paths_vptr = (void*)paths;
                    GetPathSpacingNV(pathListMode, numPaths, pathNameType, paths_vptr, pathBase, advanceScale, kerningScale, transformType, returnedSpacing_ptr);
                }
            }
            public static unsafe void GetPathSpacingNV(PathListMode pathListMode, int numPaths, PathElementType pathNameType, IntPtr paths, uint pathBase, float advanceScale, float kerningScale, PathTransformType transformType, ref float returnedSpacing)
            {
                fixed (float* returnedSpacing_ptr = &returnedSpacing)
                {
                    void* paths_vptr = (void*)paths;
                    GetPathSpacingNV(pathListMode, numPaths, pathNameType, paths_vptr, pathBase, advanceScale, kerningScale, transformType, returnedSpacing_ptr);
                }
            }
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
            public static unsafe void GetPathSpacingNV<T1>(PathListMode pathListMode, int numPaths, PathElementType pathNameType, in T1 paths, uint pathBase, float advanceScale, float kerningScale, PathTransformType transformType, ref float returnedSpacing)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = &paths)
                fixed (float* returnedSpacing_ptr = &returnedSpacing)
                {
                    GetPathSpacingNV(pathListMode, numPaths, pathNameType, paths_ptr, pathBase, advanceScale, kerningScale, transformType, returnedSpacing_ptr);
                }
            }
            public static unsafe byte PointAlongPathNV(uint path, int startSegment, int numSegments, float distance, Span<float> x, Span<float> y, Span<float> tangentX, Span<float> tangentY)
            {
                byte returnValue;
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
            public static unsafe byte PointAlongPathNV(uint path, int startSegment, int numSegments, float distance, float[] x, float[] y, float[] tangentX, float[] tangentY)
            {
                byte returnValue;
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
            public static unsafe byte PointAlongPathNV(uint path, int startSegment, int numSegments, float distance, ref float x, ref float y, ref float tangentX, ref float tangentY)
            {
                byte returnValue;
                fixed (float* x_ptr = &x)
                fixed (float* y_ptr = &y)
                fixed (float* tangentX_ptr = &tangentX)
                fixed (float* tangentY_ptr = &tangentY)
                {
                    returnValue = PointAlongPathNV(path, startSegment, numSegments, distance, x_ptr, y_ptr, tangentX_ptr, tangentY_ptr);
                }
                return returnValue;
            }
            public static unsafe void MatrixLoad3x2fNV(All matrixMode, in float m)
            {
                fixed (float* m_ptr = &m)
                {
                    MatrixLoad3x2fNV(matrixMode, m_ptr);
                }
            }
            public static unsafe void MatrixLoad3x3fNV(All matrixMode, in float m)
            {
                fixed (float* m_ptr = &m)
                {
                    MatrixLoad3x3fNV(matrixMode, m_ptr);
                }
            }
            public static unsafe void MatrixLoadTranspose3x3fNV(All matrixMode, in float m)
            {
                fixed (float* m_ptr = &m)
                {
                    MatrixLoadTranspose3x3fNV(matrixMode, m_ptr);
                }
            }
            public static unsafe void MatrixMult3x2fNV(All matrixMode, in float m)
            {
                fixed (float* m_ptr = &m)
                {
                    MatrixMult3x2fNV(matrixMode, m_ptr);
                }
            }
            public static unsafe void MatrixMult3x3fNV(All matrixMode, in float m)
            {
                fixed (float* m_ptr = &m)
                {
                    MatrixMult3x3fNV(matrixMode, m_ptr);
                }
            }
            public static unsafe void MatrixMultTranspose3x3fNV(All matrixMode, in float m)
            {
                fixed (float* m_ptr = &m)
                {
                    MatrixMultTranspose3x3fNV(matrixMode, m_ptr);
                }
            }
            public static unsafe void StencilThenCoverFillPathInstancedNV(int numPaths, All pathNameType, IntPtr paths, uint pathBase, All fillMode, uint mask, All coverMode, All transformType, in float transformValues)
            {
                fixed (float* transformValues_ptr = &transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    StencilThenCoverFillPathInstancedNV(numPaths, pathNameType, paths_vptr, pathBase, fillMode, mask, coverMode, transformType, transformValues_ptr);
                }
            }
            public static unsafe void StencilThenCoverFillPathInstancedNV<T1>(int numPaths, All pathNameType, in T1 paths, uint pathBase, All fillMode, uint mask, All coverMode, All transformType, in float transformValues)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = &paths)
                fixed (float* transformValues_ptr = &transformValues)
                {
                    StencilThenCoverFillPathInstancedNV(numPaths, pathNameType, paths_ptr, pathBase, fillMode, mask, coverMode, transformType, transformValues_ptr);
                }
            }
            public static unsafe void StencilThenCoverStrokePathInstancedNV(int numPaths, All pathNameType, IntPtr paths, uint pathBase, int reference, uint mask, All coverMode, All transformType, in float transformValues)
            {
                fixed (float* transformValues_ptr = &transformValues)
                {
                    void* paths_vptr = (void*)paths;
                    StencilThenCoverStrokePathInstancedNV(numPaths, pathNameType, paths_vptr, pathBase, reference, mask, coverMode, transformType, transformValues_ptr);
                }
            }
            public static unsafe void StencilThenCoverStrokePathInstancedNV<T1>(int numPaths, All pathNameType, in T1 paths, uint pathBase, int reference, uint mask, All coverMode, All transformType, in float transformValues)
                where T1 : unmanaged
            {
                fixed (void* paths_ptr = &paths)
                fixed (float* transformValues_ptr = &transformValues)
                {
                    StencilThenCoverStrokePathInstancedNV(numPaths, pathNameType, paths_ptr, pathBase, reference, mask, coverMode, transformType, transformValues_ptr);
                }
            }
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
            public static unsafe All PathGlyphIndexArrayNV(uint firstPathName, All fontTarget, IntPtr fontName, PathFontStyle fontStyle, uint firstGlyphIndex, int numGlyphs, uint pathParameterTemplate, float emScale)
            {
                All returnValue;
                void* fontName_vptr = (void*)fontName;
                returnValue = PathGlyphIndexArrayNV(firstPathName, fontTarget, fontName_vptr, fontStyle, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);
                return returnValue;
            }
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
            public static unsafe All PathMemoryGlyphIndexArrayNV(uint firstPathName, All fontTarget, nint fontSize, IntPtr fontData, int faceIndex, uint firstGlyphIndex, int numGlyphs, uint pathParameterTemplate, float emScale)
            {
                All returnValue;
                void* fontData_vptr = (void*)fontData;
                returnValue = PathMemoryGlyphIndexArrayNV(firstPathName, fontTarget, fontSize, fontData_vptr, faceIndex, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);
                return returnValue;
            }
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
            public static unsafe void ProgramPathFragmentInputGenNV(ProgramHandle program, int location, All genMode, int components, in float coeffs)
            {
                fixed (float* coeffs_ptr = &coeffs)
                {
                    ProgramPathFragmentInputGenNV(program, location, genMode, components, coeffs_ptr);
                }
            }
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
            public static unsafe void GetProgramResourcefvNV(ProgramHandle program, ProgramInterface programInterface, uint index, int propCount, in All props, int count, ref int length, ref float parameters)
            {
                fixed (All* props_ptr = &props)
                fixed (int* length_ptr = &length)
                fixed (float* parameters_ptr = &parameters)
                {
                    GetProgramResourcefvNV(program, programInterface, index, propCount, props_ptr, count, length_ptr, parameters_ptr);
                }
            }
            public static unsafe void MatrixLoadTransposefEXT(MatrixMode mode, ReadOnlySpan<float> m)
            {
                fixed (float* m_ptr = m)
                {
                    MatrixLoadTransposefEXT(mode, m_ptr);
                }
            }
            public static unsafe void MatrixLoadTransposefEXT(MatrixMode mode, float[] m)
            {
                fixed (float* m_ptr = m)
                {
                    MatrixLoadTransposefEXT(mode, m_ptr);
                }
            }
            public static unsafe void MatrixLoadTransposefEXT(MatrixMode mode, in float m)
            {
                fixed (float* m_ptr = &m)
                {
                    MatrixLoadTransposefEXT(mode, m_ptr);
                }
            }
            public static unsafe void MatrixLoadTransposedEXT(MatrixMode mode, ReadOnlySpan<double> m)
            {
                fixed (double* m_ptr = m)
                {
                    MatrixLoadTransposedEXT(mode, m_ptr);
                }
            }
            public static unsafe void MatrixLoadTransposedEXT(MatrixMode mode, double[] m)
            {
                fixed (double* m_ptr = m)
                {
                    MatrixLoadTransposedEXT(mode, m_ptr);
                }
            }
            public static unsafe void MatrixLoadTransposedEXT(MatrixMode mode, in double m)
            {
                fixed (double* m_ptr = &m)
                {
                    MatrixLoadTransposedEXT(mode, m_ptr);
                }
            }
            public static unsafe void MatrixLoadfEXT(MatrixMode mode, ReadOnlySpan<float> m)
            {
                fixed (float* m_ptr = m)
                {
                    MatrixLoadfEXT(mode, m_ptr);
                }
            }
            public static unsafe void MatrixLoadfEXT(MatrixMode mode, float[] m)
            {
                fixed (float* m_ptr = m)
                {
                    MatrixLoadfEXT(mode, m_ptr);
                }
            }
            public static unsafe void MatrixLoadfEXT(MatrixMode mode, in float m)
            {
                fixed (float* m_ptr = &m)
                {
                    MatrixLoadfEXT(mode, m_ptr);
                }
            }
            public static unsafe void MatrixLoaddEXT(MatrixMode mode, ReadOnlySpan<double> m)
            {
                fixed (double* m_ptr = m)
                {
                    MatrixLoaddEXT(mode, m_ptr);
                }
            }
            public static unsafe void MatrixLoaddEXT(MatrixMode mode, double[] m)
            {
                fixed (double* m_ptr = m)
                {
                    MatrixLoaddEXT(mode, m_ptr);
                }
            }
            public static unsafe void MatrixLoaddEXT(MatrixMode mode, in double m)
            {
                fixed (double* m_ptr = &m)
                {
                    MatrixLoaddEXT(mode, m_ptr);
                }
            }
            public static unsafe void MatrixMultTransposefEXT(MatrixMode mode, ReadOnlySpan<float> m)
            {
                fixed (float* m_ptr = m)
                {
                    MatrixMultTransposefEXT(mode, m_ptr);
                }
            }
            public static unsafe void MatrixMultTransposefEXT(MatrixMode mode, float[] m)
            {
                fixed (float* m_ptr = m)
                {
                    MatrixMultTransposefEXT(mode, m_ptr);
                }
            }
            public static unsafe void MatrixMultTransposefEXT(MatrixMode mode, in float m)
            {
                fixed (float* m_ptr = &m)
                {
                    MatrixMultTransposefEXT(mode, m_ptr);
                }
            }
            public static unsafe void MatrixMultTransposedEXT(MatrixMode mode, ReadOnlySpan<double> m)
            {
                fixed (double* m_ptr = m)
                {
                    MatrixMultTransposedEXT(mode, m_ptr);
                }
            }
            public static unsafe void MatrixMultTransposedEXT(MatrixMode mode, double[] m)
            {
                fixed (double* m_ptr = m)
                {
                    MatrixMultTransposedEXT(mode, m_ptr);
                }
            }
            public static unsafe void MatrixMultTransposedEXT(MatrixMode mode, in double m)
            {
                fixed (double* m_ptr = &m)
                {
                    MatrixMultTransposedEXT(mode, m_ptr);
                }
            }
            public static unsafe void MatrixMultfEXT(MatrixMode mode, ReadOnlySpan<float> m)
            {
                fixed (float* m_ptr = m)
                {
                    MatrixMultfEXT(mode, m_ptr);
                }
            }
            public static unsafe void MatrixMultfEXT(MatrixMode mode, float[] m)
            {
                fixed (float* m_ptr = m)
                {
                    MatrixMultfEXT(mode, m_ptr);
                }
            }
            public static unsafe void MatrixMultfEXT(MatrixMode mode, in float m)
            {
                fixed (float* m_ptr = &m)
                {
                    MatrixMultfEXT(mode, m_ptr);
                }
            }
            public static unsafe void MatrixMultdEXT(MatrixMode mode, ReadOnlySpan<double> m)
            {
                fixed (double* m_ptr = m)
                {
                    MatrixMultdEXT(mode, m_ptr);
                }
            }
            public static unsafe void MatrixMultdEXT(MatrixMode mode, double[] m)
            {
                fixed (double* m_ptr = m)
                {
                    MatrixMultdEXT(mode, m_ptr);
                }
            }
            public static unsafe void MatrixMultdEXT(MatrixMode mode, in double m)
            {
                fixed (double* m_ptr = &m)
                {
                    MatrixMultdEXT(mode, m_ptr);
                }
            }
            public static unsafe void FramebufferSampleLocationsfvNV(FramebufferTarget target, uint start, int count, in float v)
            {
                fixed (float* v_ptr = &v)
                {
                    FramebufferSampleLocationsfvNV(target, start, count, v_ptr);
                }
            }
            public static unsafe void NamedFramebufferSampleLocationsfvNV(FramebufferHandle framebuffer, uint start, int count, in float v)
            {
                fixed (float* v_ptr = &v)
                {
                    NamedFramebufferSampleLocationsfvNV(framebuffer, start, count, v_ptr);
                }
            }
            public static unsafe void ScissorExclusiveArrayvNV(uint first, int count, ReadOnlySpan<int> v)
            {
                fixed (int* v_ptr = v)
                {
                    ScissorExclusiveArrayvNV(first, count, v_ptr);
                }
            }
            public static unsafe void ScissorExclusiveArrayvNV(uint first, int count, int[] v)
            {
                fixed (int* v_ptr = v)
                {
                    ScissorExclusiveArrayvNV(first, count, v_ptr);
                }
            }
            public static unsafe void ScissorExclusiveArrayvNV(uint first, int count, in int v)
            {
                fixed (int* v_ptr = &v)
                {
                    ScissorExclusiveArrayvNV(first, count, v_ptr);
                }
            }
            public static unsafe void GetShadingRateImagePaletteNV(uint viewport, uint entry, Span<All> rate)
            {
                fixed (All* rate_ptr = rate)
                {
                    GetShadingRateImagePaletteNV(viewport, entry, rate_ptr);
                }
            }
            public static unsafe void GetShadingRateImagePaletteNV(uint viewport, uint entry, All[] rate)
            {
                fixed (All* rate_ptr = rate)
                {
                    GetShadingRateImagePaletteNV(viewport, entry, rate_ptr);
                }
            }
            public static unsafe void GetShadingRateImagePaletteNV(uint viewport, uint entry, ref All rate)
            {
                fixed (All* rate_ptr = &rate)
                {
                    GetShadingRateImagePaletteNV(viewport, entry, rate_ptr);
                }
            }
            public static unsafe void GetShadingRateSampleLocationivNV(All rate, uint samples, uint index, Span<int> location)
            {
                fixed (int* location_ptr = location)
                {
                    GetShadingRateSampleLocationivNV(rate, samples, index, location_ptr);
                }
            }
            public static unsafe void GetShadingRateSampleLocationivNV(All rate, uint samples, uint index, int[] location)
            {
                fixed (int* location_ptr = location)
                {
                    GetShadingRateSampleLocationivNV(rate, samples, index, location_ptr);
                }
            }
            public static unsafe void GetShadingRateSampleLocationivNV(All rate, uint samples, uint index, ref int location)
            {
                fixed (int* location_ptr = &location)
                {
                    GetShadingRateSampleLocationivNV(rate, samples, index, location_ptr);
                }
            }
            public static unsafe void ShadingRateImageBarrierNV(bool synchronize)
            {
                byte synchronize_byte = (byte)(synchronize ? 1 : 0);
                ShadingRateImageBarrierNV(synchronize_byte);
            }
            public static unsafe void ShadingRateImagePaletteNV(uint viewport, uint first, ReadOnlySpan<All> rates)
            {
                int count = (int)(rates.Length);
                fixed (All* rates_ptr = rates)
                {
                    ShadingRateImagePaletteNV(viewport, first, count, rates_ptr);
                }
            }
            public static unsafe void ShadingRateImagePaletteNV(uint viewport, uint first, All[] rates)
            {
                int count = (int)(rates.Length);
                fixed (All* rates_ptr = rates)
                {
                    ShadingRateImagePaletteNV(viewport, first, count, rates_ptr);
                }
            }
            public static unsafe void ShadingRateImagePaletteNV(uint viewport, uint first, int count, in All rates)
            {
                fixed (All* rates_ptr = &rates)
                {
                    ShadingRateImagePaletteNV(viewport, first, count, rates_ptr);
                }
            }
            public static unsafe void ShadingRateSampleOrderCustomNV(All rate, uint samples, ReadOnlySpan<int> locations)
            {
                fixed (int* locations_ptr = locations)
                {
                    ShadingRateSampleOrderCustomNV(rate, samples, locations_ptr);
                }
            }
            public static unsafe void ShadingRateSampleOrderCustomNV(All rate, uint samples, int[] locations)
            {
                fixed (int* locations_ptr = locations)
                {
                    ShadingRateSampleOrderCustomNV(rate, samples, locations_ptr);
                }
            }
            public static unsafe void ShadingRateSampleOrderCustomNV(All rate, uint samples, in int locations)
            {
                fixed (int* locations_ptr = &locations)
                {
                    ShadingRateSampleOrderCustomNV(rate, samples, locations_ptr);
                }
            }
            public static unsafe void ViewportArrayvNV(uint first, ReadOnlySpan<float> v)
            {
                int count = (int)(v.Length / 4);
                fixed (float* v_ptr = v)
                {
                    ViewportArrayvNV(first, count, v_ptr);
                }
            }
            public static unsafe void ViewportArrayvNV(uint first, float[] v)
            {
                int count = (int)(v.Length / 4);
                fixed (float* v_ptr = v)
                {
                    ViewportArrayvNV(first, count, v_ptr);
                }
            }
            public static unsafe void ViewportArrayvNV(uint first, int count, in float v)
            {
                fixed (float* v_ptr = &v)
                {
                    ViewportArrayvNV(first, count, v_ptr);
                }
            }
            public static unsafe void ViewportIndexedfvNV(uint index, ReadOnlySpan<float> v)
            {
                fixed (float* v_ptr = v)
                {
                    ViewportIndexedfvNV(index, v_ptr);
                }
            }
            public static unsafe void ViewportIndexedfvNV(uint index, float[] v)
            {
                fixed (float* v_ptr = v)
                {
                    ViewportIndexedfvNV(index, v_ptr);
                }
            }
            public static unsafe void ViewportIndexedfvNV(uint index, in float v)
            {
                fixed (float* v_ptr = &v)
                {
                    ViewportIndexedfvNV(index, v_ptr);
                }
            }
            public static unsafe void ScissorArrayvNV(uint first, ReadOnlySpan<int> v)
            {
                int count = (int)(v.Length / 4);
                fixed (int* v_ptr = v)
                {
                    ScissorArrayvNV(first, count, v_ptr);
                }
            }
            public static unsafe void ScissorArrayvNV(uint first, int[] v)
            {
                int count = (int)(v.Length / 4);
                fixed (int* v_ptr = v)
                {
                    ScissorArrayvNV(first, count, v_ptr);
                }
            }
            public static unsafe void ScissorArrayvNV(uint first, int count, in int v)
            {
                fixed (int* v_ptr = &v)
                {
                    ScissorArrayvNV(first, count, v_ptr);
                }
            }
            public static unsafe void ScissorIndexedvNV(uint index, ReadOnlySpan<int> v)
            {
                fixed (int* v_ptr = v)
                {
                    ScissorIndexedvNV(index, v_ptr);
                }
            }
            public static unsafe void ScissorIndexedvNV(uint index, int[] v)
            {
                fixed (int* v_ptr = v)
                {
                    ScissorIndexedvNV(index, v_ptr);
                }
            }
            public static unsafe void ScissorIndexedvNV(uint index, in int v)
            {
                fixed (int* v_ptr = &v)
                {
                    ScissorIndexedvNV(index, v_ptr);
                }
            }
            public static unsafe void DepthRangeArrayfvNV(uint first, int count, in float v)
            {
                fixed (float* v_ptr = &v)
                {
                    DepthRangeArrayfvNV(first, count, v_ptr);
                }
            }
            public static unsafe void GetFloati_vNV(GetPName target, uint index, Span<float> data)
            {
                fixed (float* data_ptr = data)
                {
                    GetFloati_vNV(target, index, data_ptr);
                }
            }
            public static unsafe void GetFloati_vNV(GetPName target, uint index, float[] data)
            {
                fixed (float* data_ptr = data)
                {
                    GetFloati_vNV(target, index, data_ptr);
                }
            }
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
            public static unsafe void UniformHandleui64vIMG(int location, ReadOnlySpan<ulong> value)
            {
                int count = (int)(value.Length);
                fixed (ulong* value_ptr = value)
                {
                    UniformHandleui64vIMG(location, count, value_ptr);
                }
            }
            public static unsafe void UniformHandleui64vIMG(int location, ulong[] value)
            {
                int count = (int)(value.Length);
                fixed (ulong* value_ptr = value)
                {
                    UniformHandleui64vIMG(location, count, value_ptr);
                }
            }
            public static unsafe void UniformHandleui64vIMG(int location, int count, in ulong value)
            {
                fixed (ulong* value_ptr = &value)
                {
                    UniformHandleui64vIMG(location, count, value_ptr);
                }
            }
            public static unsafe void ProgramUniformHandleui64vIMG(ProgramHandle program, int location, ReadOnlySpan<ulong> values)
            {
                int count = (int)(values.Length);
                fixed (ulong* values_ptr = values)
                {
                    ProgramUniformHandleui64vIMG(program, location, count, values_ptr);
                }
            }
            public static unsafe void ProgramUniformHandleui64vIMG(ProgramHandle program, int location, ulong[] values)
            {
                int count = (int)(values.Length);
                fixed (ulong* values_ptr = values)
                {
                    ProgramUniformHandleui64vIMG(program, location, count, values_ptr);
                }
            }
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
            public static unsafe void CreatePerfQueryINTEL(uint queryId, ref uint queryHandle)
            {
                fixed (uint* queryHandle_ptr = &queryHandle)
                {
                    CreatePerfQueryINTEL(queryId, queryHandle_ptr);
                }
            }
            public static unsafe void GetFirstPerfQueryIdINTEL(ref uint queryId)
            {
                fixed (uint* queryId_ptr = &queryId)
                {
                    GetFirstPerfQueryIdINTEL(queryId_ptr);
                }
            }
            public static unsafe void GetNextPerfQueryIdINTEL(uint queryId, ref uint nextQueryId)
            {
                fixed (uint* nextQueryId_ptr = &nextQueryId)
                {
                    GetNextPerfQueryIdINTEL(queryId, nextQueryId_ptr);
                }
            }
            public static unsafe void GetPerfCounterInfoINTEL(uint queryId, uint counterId, uint counterNameLength, byte* counterName, uint counterDescLength, byte* counterDesc, ref uint counterOffset, ref uint counterDataSize, ref uint counterTypeEnum, ref uint counterDataTypeEnum, ref ulong rawCounterMaxValue)
            {
                fixed (uint* counterOffset_ptr = &counterOffset)
                fixed (uint* counterDataSize_ptr = &counterDataSize)
                fixed (uint* counterTypeEnum_ptr = &counterTypeEnum)
                fixed (uint* counterDataTypeEnum_ptr = &counterDataTypeEnum)
                fixed (ulong* rawCounterMaxValue_ptr = &rawCounterMaxValue)
                {
                    GetPerfCounterInfoINTEL(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset_ptr, counterDataSize_ptr, counterTypeEnum_ptr, counterDataTypeEnum_ptr, rawCounterMaxValue_ptr);
                }
            }
            public static unsafe void GetPerfQueryDataINTEL(uint queryHandle, uint flags, int dataSize, IntPtr data, ref uint bytesWritten)
            {
                fixed (uint* bytesWritten_ptr = &bytesWritten)
                {
                    void* data_vptr = (void*)data;
                    GetPerfQueryDataINTEL(queryHandle, flags, dataSize, data_vptr, bytesWritten_ptr);
                }
            }
            public static unsafe void GetPerfQueryDataINTEL<T1>(uint queryHandle, uint flags, int dataSize, ref T1 data, ref uint bytesWritten)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                fixed (uint* bytesWritten_ptr = &bytesWritten)
                {
                    GetPerfQueryDataINTEL(queryHandle, flags, dataSize, data_ptr, bytesWritten_ptr);
                }
            }
            public static unsafe void GetPerfQueryIdByNameINTEL(byte* queryName, ref uint queryId)
            {
                fixed (uint* queryId_ptr = &queryId)
                {
                    GetPerfQueryIdByNameINTEL(queryName, queryId_ptr);
                }
            }
            public static unsafe void GetPerfQueryInfoINTEL(uint queryId, uint queryNameLength, byte* queryName, ref uint dataSize, ref uint noCounters, ref uint noInstances, ref uint capsMask)
            {
                fixed (uint* dataSize_ptr = &dataSize)
                fixed (uint* noCounters_ptr = &noCounters)
                fixed (uint* noInstances_ptr = &noInstances)
                fixed (uint* capsMask_ptr = &capsMask)
                {
                    GetPerfQueryInfoINTEL(queryId, queryNameLength, queryName, dataSize_ptr, noCounters_ptr, noInstances_ptr, capsMask_ptr);
                }
            }
        }
        public static unsafe partial class KHR
        {
            /// <summary> Control the reporting of debug messages in a debug context. </summary>
            /// <param name="source"> The source of debug messages to enable or disable. </param>
            /// <param name="type"> The type of debug messages to enable or disable. </param>
            /// <param name="severity"> The severity of debug messages to enable or disable. </param>
            /// <param name="ids"> The address of an array of unsigned integers contianing the ids of the messages to enable or disable. </param>
            /// <param name="enabled"> A Boolean flag determining whether the selected messages should be enabled or disabled. </param>
            public static unsafe void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, ReadOnlySpan<uint> ids, bool enabled)
            {
                int count = (int)(ids.Length);
                fixed (uint* ids_ptr = ids)
                {
                    byte enabled_byte = (byte)(enabled ? 1 : 0);
                    DebugMessageControl(source, type, severity, count, ids_ptr, enabled_byte);
                }
            }
            /// <summary> Control the reporting of debug messages in a debug context. </summary>
            /// <param name="source"> The source of debug messages to enable or disable. </param>
            /// <param name="type"> The type of debug messages to enable or disable. </param>
            /// <param name="severity"> The severity of debug messages to enable or disable. </param>
            /// <param name="ids"> The address of an array of unsigned integers contianing the ids of the messages to enable or disable. </param>
            /// <param name="enabled"> A Boolean flag determining whether the selected messages should be enabled or disabled. </param>
            public static unsafe void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, uint[] ids, bool enabled)
            {
                int count = (int)(ids.Length);
                fixed (uint* ids_ptr = ids)
                {
                    byte enabled_byte = (byte)(enabled ? 1 : 0);
                    DebugMessageControl(source, type, severity, count, ids_ptr, enabled_byte);
                }
            }
            /// <summary> Control the reporting of debug messages in a debug context. </summary>
            /// <param name="source"> The source of debug messages to enable or disable. </param>
            /// <param name="type"> The type of debug messages to enable or disable. </param>
            /// <param name="severity"> The severity of debug messages to enable or disable. </param>
            /// <param name="count"> The length of the array ids. </param>
            /// <param name="ids"> The address of an array of unsigned integers contianing the ids of the messages to enable or disable. </param>
            /// <param name="enabled"> A Boolean flag determining whether the selected messages should be enabled or disabled. </param>
            public static unsafe void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, int count, in uint ids, bool enabled)
            {
                fixed (uint* ids_ptr = &ids)
                {
                    byte enabled_byte = (byte)(enabled ? 1 : 0);
                    DebugMessageControl(source, type, severity, count, ids_ptr, enabled_byte);
                }
            }
            /// <summary> Inject an application-supplied message into the debug message queue. </summary>
            /// <param name="source"> The source of the debug message to insert. </param>
            /// <param name="type"> The type of the debug message insert. </param>
            /// <param name="id"> The user-supplied identifier of the message to insert. </param>
            /// <param name="severity"> The severity of the debug messages to insert. </param>
            /// <param name="length"> The length string contained in the character array whose address is given by message. </param>
            public static unsafe void DebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, string buf)
            {
                byte* buf_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(buf);
                DebugMessageInsert(source, type, id, severity, length, buf_ptr);
                Marshal.FreeCoTaskMem((IntPtr)buf_ptr);
            }
            /// <summary> Specify a callback to receive debugging messages from the GL. </summary>
            /// <param name="callback"> The address of a callback function that will be called when a debug message is generated. </param>
            /// <param name="userParam"> A user supplied pointer that will be passed on each invocation of callback. </param>
            public static unsafe void DebugMessageCallback(GLDebugProc callback, IntPtr userParam)
            {
                void* userParam_vptr = (void*)userParam;
                IntPtr callback_ptr = Marshal.GetFunctionPointerForDelegate(callback);
                DebugMessageCallback(callback_ptr, userParam_vptr);
            }
            /// <summary> Specify a callback to receive debugging messages from the GL. </summary>
            /// <param name="callback"> The address of a callback function that will be called when a debug message is generated. </param>
            /// <param name="userParam"> A user supplied pointer that will be passed on each invocation of callback. </param>
            public static unsafe void DebugMessageCallback<T1>(GLDebugProc callback, in T1 userParam)
                where T1 : unmanaged
            {
                fixed (void* userParam_ptr = &userParam)
                {
                    IntPtr callback_ptr = Marshal.GetFunctionPointerForDelegate(callback);
                    DebugMessageCallback(callback_ptr, userParam_ptr);
                }
            }
            /// <summary> Retrieve messages from the debug message log. </summary>
            /// <param name="count"> The number of debug messages to retrieve from the log. </param>
            /// <param name="bufSize"> The size of the buffer whose address is given by messageLog. </param>
            /// <param name="sources"> The address of an array of variables to receive the sources of the retrieved messages. </param>
            /// <param name="types"> The address of an array of variables to receive the types of the retrieved messages. </param>
            /// <param name="ids"> The address of an array of unsigned integers to receive the ids of the retrieved messages. </param>
            /// <param name="severities"> The address of an array of variables to receive the severites of the retrieved messages. </param>
            /// <param name="lengths"> The address of an array of variables to receive the lengths of the received messages. </param>
            /// <param name="messageLog"> The address of an array of characters that will receive the messages. </param>
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
            /// <summary> Retrieve messages from the debug message log. </summary>
            /// <param name="count"> The number of debug messages to retrieve from the log. </param>
            /// <param name="bufSize"> The size of the buffer whose address is given by messageLog. </param>
            /// <param name="sources"> The address of an array of variables to receive the sources of the retrieved messages. </param>
            /// <param name="types"> The address of an array of variables to receive the types of the retrieved messages. </param>
            /// <param name="ids"> The address of an array of unsigned integers to receive the ids of the retrieved messages. </param>
            /// <param name="severities"> The address of an array of variables to receive the severites of the retrieved messages. </param>
            /// <param name="lengths"> The address of an array of variables to receive the lengths of the received messages. </param>
            /// <param name="messageLog"> The address of an array of characters that will receive the messages. </param>
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
            /// <summary> Retrieve messages from the debug message log. </summary>
            /// <param name="count"> The number of debug messages to retrieve from the log. </param>
            /// <param name="bufSize"> The size of the buffer whose address is given by messageLog. </param>
            /// <param name="sources"> The address of an array of variables to receive the sources of the retrieved messages. </param>
            /// <param name="types"> The address of an array of variables to receive the types of the retrieved messages. </param>
            /// <param name="ids"> The address of an array of unsigned integers to receive the ids of the retrieved messages. </param>
            /// <param name="severities"> The address of an array of variables to receive the severites of the retrieved messages. </param>
            /// <param name="lengths"> The address of an array of variables to receive the lengths of the received messages. </param>
            /// <param name="messageLog"> The address of an array of characters that will receive the messages. </param>
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
            /// <summary> Push a named debug group into the command stream. </summary>
            /// <param name="source"> The source of the debug message. </param>
            /// <param name="id"> The identifier of the message. </param>
            /// <param name="length"> The length of the message to be sent to the debug output stream. </param>
            /// <param name="message"> The a string containing the message to be sent to the debug output stream. </param>
            public static unsafe void PushDebugGroup(DebugSource source, uint id, int length, string message)
            {
                byte* message_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(message);
                PushDebugGroup(source, id, length, message_ptr);
                Marshal.FreeCoTaskMem((IntPtr)message_ptr);
            }
            /// <summary> Label a named object identified within a namespace. </summary>
            /// <param name="identifier"> The namespace from which the name of the object is allocated. </param>
            /// <param name="name"> The name of the object to label. </param>
            /// <param name="length"> The length of the label to be used for the object. </param>
            /// <param name="label"> The address of a string containing the label to assign to the object. </param>
            public static unsafe void ObjectLabel(ObjectIdentifier identifier, uint name, int length, string label)
            {
                byte* label_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(label);
                ObjectLabel(identifier, name, length, label_ptr);
                Marshal.FreeCoTaskMem((IntPtr)label_ptr);
            }
            /// <summary> Retrieve the label of a named object identified within a namespace. </summary>
            /// <param name="identifier"> The namespace from which the name of the object is allocated. </param>
            /// <param name="name"> The name of the object whose label to retrieve. </param>
            /// <param name="length"> The address of a variable to receive the length of the object label. </param>
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
            /// <summary> Retrieve the label of a named object identified within a namespace. </summary>
            /// <param name="identifier"> The namespace from which the name of the object is allocated. </param>
            /// <param name="name"> The name of the object whose label to retrieve. </param>
            /// <param name="length"> The address of a variable to receive the length of the object label. </param>
            /// <param name="label"> The address of a string that will receive the object label. </param>
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
            /// <summary> Retrieve the label of a named object identified within a namespace. </summary>
            /// <param name="identifier"> The namespace from which the name of the object is allocated. </param>
            /// <param name="name"> The name of the object whose label to retrieve. </param>
            /// <param name="length"> The address of a variable to receive the length of the object label. </param>
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
            /// <summary> Retrieve the label of a named object identified within a namespace. </summary>
            /// <param name="identifier"> The namespace from which the name of the object is allocated. </param>
            /// <param name="name"> The name of the object whose label to retrieve. </param>
            /// <param name="length"> The address of a variable to receive the length of the object label. </param>
            /// <param name="label"> The address of a string that will receive the object label. </param>
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
            /// <summary> Retrieve the label of a named object identified within a namespace. </summary>
            /// <param name="identifier"> The namespace from which the name of the object is allocated. </param>
            /// <param name="name"> The name of the object whose label to retrieve. </param>
            /// <param name="length"> The address of a variable to receive the length of the object label. </param>
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
            /// <summary> Retrieve the label of a named object identified within a namespace. </summary>
            /// <param name="identifier"> The namespace from which the name of the object is allocated. </param>
            /// <param name="name"> The name of the object whose label to retrieve. </param>
            /// <param name="length"> The address of a variable to receive the length of the object label. </param>
            /// <param name="label"> The address of a string that will receive the object label. </param>
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
            /// <summary> Label a sync object identified by a pointer. </summary>
            /// <param name="ptr"> A pointer identifying a sync object. </param>
            /// <param name="length"> The length of the label to be used for the object. </param>
            /// <param name="label"> The address of a string containing the label to assign to the object. </param>
            public static unsafe void ObjectPtrLabel(IntPtr ptr, int length, string label)
            {
                byte* label_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(label);
                void* ptr_vptr = (void*)ptr;
                ObjectPtrLabel(ptr_vptr, length, label_ptr);
                Marshal.FreeCoTaskMem((IntPtr)label_ptr);
            }
            /// <summary> Label a sync object identified by a pointer. </summary>
            /// <param name="ptr"> A pointer identifying a sync object. </param>
            /// <param name="length"> The length of the label to be used for the object. </param>
            /// <param name="label"> The address of a string containing the label to assign to the object. </param>
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
            /// <summary> Retrieve the label of a sync object identified by a pointer. </summary>
            /// <param name="ptr"> The name of the sync object whose label to retrieve. </param>
            /// <param name="length"> The address of a variable to receive the length of the object label. </param>
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
            /// <summary> Retrieve the label of a sync object identified by a pointer. </summary>
            /// <param name="ptr"> The name of the sync object whose label to retrieve. </param>
            /// <param name="length"> The address of a variable to receive the length of the object label. </param>
            /// <param name="label"> The address of a string that will receive the object label. </param>
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
            /// <summary> Retrieve the label of a sync object identified by a pointer. </summary>
            /// <param name="ptr"> The name of the sync object whose label to retrieve. </param>
            /// <param name="length"> The address of a variable to receive the length of the object label. </param>
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
            /// <summary> Retrieve the label of a sync object identified by a pointer. </summary>
            /// <param name="ptr"> The name of the sync object whose label to retrieve. </param>
            /// <param name="length"> The address of a variable to receive the length of the object label. </param>
            /// <param name="label"> The address of a string that will receive the object label. </param>
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
            /// <summary> Retrieve the label of a sync object identified by a pointer. </summary>
            /// <param name="ptr"> The name of the sync object whose label to retrieve. </param>
            /// <param name="length"> The address of a variable to receive the length of the object label. </param>
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
            /// <summary> Retrieve the label of a sync object identified by a pointer. </summary>
            /// <param name="ptr"> The name of the sync object whose label to retrieve. </param>
            /// <param name="length"> The address of a variable to receive the length of the object label. </param>
            /// <param name="label"> The address of a string that will receive the object label. </param>
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
            /// <summary> Retrieve the label of a sync object identified by a pointer. </summary>
            /// <param name="ptr"> The name of the sync object whose label to retrieve. </param>
            /// <param name="length"> The address of a variable to receive the length of the object label. </param>
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
            /// <summary> Retrieve the label of a sync object identified by a pointer. </summary>
            /// <param name="ptr"> The name of the sync object whose label to retrieve. </param>
            /// <param name="length"> The address of a variable to receive the length of the object label. </param>
            /// <param name="label"> The address of a string that will receive the object label. </param>
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
            /// <summary> Retrieve the label of a sync object identified by a pointer. </summary>
            /// <param name="ptr"> The name of the sync object whose label to retrieve. </param>
            /// <param name="length"> The address of a variable to receive the length of the object label. </param>
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
            /// <summary> Retrieve the label of a sync object identified by a pointer. </summary>
            /// <param name="ptr"> The name of the sync object whose label to retrieve. </param>
            /// <param name="length"> The address of a variable to receive the length of the object label. </param>
            /// <param name="label"> The address of a string that will receive the object label. </param>
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
            /// <summary> Retrieve the label of a sync object identified by a pointer. </summary>
            /// <param name="ptr"> The name of the sync object whose label to retrieve. </param>
            /// <param name="length"> The address of a variable to receive the length of the object label. </param>
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
            /// <summary> Retrieve the label of a sync object identified by a pointer. </summary>
            /// <param name="ptr"> The name of the sync object whose label to retrieve. </param>
            /// <param name="length"> The address of a variable to receive the length of the object label. </param>
            /// <param name="label"> The address of a string that will receive the object label. </param>
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
            /// <param name="pname"> Specifies the pointer to be returned. Must be one of GL_DEBUG_CALLBACK_FUNCTION or GL_DEBUG_CALLBACK_USER_PARAM. </param>
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
            /// <summary> Read a block of pixels from the frame buffer. </summary>
            /// <param name="x"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
            /// <param name="y"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
            /// <param name="width"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
            /// <param name="height"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
            /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RGBA, and GL_RGBA_INTEGER. An implementation-chosen format will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_FORMAT. </param>
            /// <param name="type"> Specifies the data type of the pixel data. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_INT, GL_UNSIGNED_INT_2_10_10_10_REV, GL_INT, or GL_FLOAT. An implementation-chosen type will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_TYPE. </param>
            /// <param name="bufSize"> Specifies the size of the buffer data for glReadnPixels function. </param>
            /// <param name="data"> Returns the pixel data. </param>
            public static unsafe void ReadnPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, IntPtr data)
            {
                void* data_vptr = (void*)data;
                ReadnPixels(x, y, width, height, format, type, bufSize, data_vptr);
            }
            /// <summary> Read a block of pixels from the frame buffer. </summary>
            /// <param name="x"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
            /// <param name="y"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
            /// <param name="width"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
            /// <param name="height"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
            /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RGBA, and GL_RGBA_INTEGER. An implementation-chosen format will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_FORMAT. </param>
            /// <param name="type"> Specifies the data type of the pixel data. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_INT, GL_UNSIGNED_INT_2_10_10_10_REV, GL_INT, or GL_FLOAT. An implementation-chosen type will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_TYPE. </param>
            /// <param name="data"> Returns the pixel data. </param>
            public static unsafe void ReadnPixels<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, Span<T1> data)
                where T1 : unmanaged
            {
                int bufSize = (int)(data.Length * sizeof(T1));
                fixed (void* data_ptr = data)
                {
                    ReadnPixels(x, y, width, height, format, type, bufSize, data_ptr);
                }
            }
            /// <summary> Read a block of pixels from the frame buffer. </summary>
            /// <param name="x"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
            /// <param name="y"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
            /// <param name="width"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
            /// <param name="height"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
            /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RGBA, and GL_RGBA_INTEGER. An implementation-chosen format will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_FORMAT. </param>
            /// <param name="type"> Specifies the data type of the pixel data. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_INT, GL_UNSIGNED_INT_2_10_10_10_REV, GL_INT, or GL_FLOAT. An implementation-chosen type will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_TYPE. </param>
            /// <param name="data"> Returns the pixel data. </param>
            public static unsafe void ReadnPixels<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, T1[] data)
                where T1 : unmanaged
            {
                int bufSize = (int)(data.Length * sizeof(T1));
                fixed (void* data_ptr = data)
                {
                    ReadnPixels(x, y, width, height, format, type, bufSize, data_ptr);
                }
            }
            /// <summary> Read a block of pixels from the frame buffer. </summary>
            /// <param name="x"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
            /// <param name="y"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
            /// <param name="width"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
            /// <param name="height"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
            /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RGBA, and GL_RGBA_INTEGER. An implementation-chosen format will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_FORMAT. </param>
            /// <param name="type"> Specifies the data type of the pixel data. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_INT, GL_UNSIGNED_INT_2_10_10_10_REV, GL_INT, or GL_FLOAT. An implementation-chosen type will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_TYPE. </param>
            /// <param name="bufSize"> Specifies the size of the buffer data for glReadnPixels function. </param>
            /// <param name="data"> Returns the pixel data. </param>
            public static unsafe void ReadnPixels<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, ref T1 data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    ReadnPixels(x, y, width, height, format, type, bufSize, data_ptr);
                }
            }
            /// <summary> Returns the value of a uniform variable. </summary>
            /// <param name="program">Specifies the program object to be queried.</param>
            /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
            public static unsafe void GetnUniformf(ProgramHandle program, int location, Span<float> parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (float* parameters_ptr = parameters)
                {
                    GetnUniformfv(program, location, bufSize, parameters_ptr);
                }
            }
            /// <summary> Returns the value of a uniform variable. </summary>
            /// <param name="program">Specifies the program object to be queried.</param>
            /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
            public static unsafe void GetnUniformf(ProgramHandle program, int location, float[] parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (float* parameters_ptr = parameters)
                {
                    GetnUniformfv(program, location, bufSize, parameters_ptr);
                }
            }
            /// <summary> Returns the value of a uniform variable. </summary>
            /// <param name="program">Specifies the program object to be queried.</param>
            /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
            /// <param name="bufSize">Specifies the size of the buffer params. </param>
            public static unsafe void GetnUniformf(ProgramHandle program, int location, int bufSize, ref float parameters)
            {
                fixed (float* parameters_ptr = &parameters)
                {
                    GetnUniformfv(program, location, bufSize, parameters_ptr);
                }
            }
            /// <summary> Returns the value of a uniform variable. </summary>
            /// <param name="program">Specifies the program object to be queried.</param>
            /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
            public static unsafe void GetnUniformi(ProgramHandle program, int location, Span<int> parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (int* parameters_ptr = parameters)
                {
                    GetnUniformiv(program, location, bufSize, parameters_ptr);
                }
            }
            /// <summary> Returns the value of a uniform variable. </summary>
            /// <param name="program">Specifies the program object to be queried.</param>
            /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
            public static unsafe void GetnUniformi(ProgramHandle program, int location, int[] parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (int* parameters_ptr = parameters)
                {
                    GetnUniformiv(program, location, bufSize, parameters_ptr);
                }
            }
            /// <summary> Returns the value of a uniform variable. </summary>
            /// <param name="program">Specifies the program object to be queried.</param>
            /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
            /// <param name="bufSize">Specifies the size of the buffer params. </param>
            public static unsafe void GetnUniformi(ProgramHandle program, int location, int bufSize, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetnUniformiv(program, location, bufSize, parameters_ptr);
                }
            }
            /// <summary> Returns the value of a uniform variable. </summary>
            /// <param name="program">Specifies the program object to be queried.</param>
            /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
            public static unsafe void GetnUniformui(ProgramHandle program, int location, Span<uint> parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (uint* parameters_ptr = parameters)
                {
                    GetnUniformuiv(program, location, bufSize, parameters_ptr);
                }
            }
            /// <summary> Returns the value of a uniform variable. </summary>
            /// <param name="program">Specifies the program object to be queried.</param>
            /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
            public static unsafe void GetnUniformui(ProgramHandle program, int location, uint[] parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (uint* parameters_ptr = parameters)
                {
                    GetnUniformuiv(program, location, bufSize, parameters_ptr);
                }
            }
            /// <summary> Returns the value of a uniform variable. </summary>
            /// <param name="program">Specifies the program object to be queried.</param>
            /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
            /// <param name="bufSize">Specifies the size of the buffer params. </param>
            public static unsafe void GetnUniformui(ProgramHandle program, int location, int bufSize, ref uint parameters)
            {
                fixed (uint* parameters_ptr = &parameters)
                {
                    GetnUniformuiv(program, location, bufSize, parameters_ptr);
                }
            }
            public static unsafe void ReadnPixelsKHR(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, IntPtr data)
            {
                void* data_vptr = (void*)data;
                ReadnPixelsKHR(x, y, width, height, format, type, bufSize, data_vptr);
            }
            public static unsafe void ReadnPixelsKHR<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, Span<T1> data)
                where T1 : unmanaged
            {
                int bufSize = (int)(data.Length * sizeof(T1));
                fixed (void* data_ptr = data)
                {
                    ReadnPixelsKHR(x, y, width, height, format, type, bufSize, data_ptr);
                }
            }
            public static unsafe void ReadnPixelsKHR<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, T1[] data)
                where T1 : unmanaged
            {
                int bufSize = (int)(data.Length * sizeof(T1));
                fixed (void* data_ptr = data)
                {
                    ReadnPixelsKHR(x, y, width, height, format, type, bufSize, data_ptr);
                }
            }
            public static unsafe void ReadnPixelsKHR<T1>(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, ref T1 data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    ReadnPixelsKHR(x, y, width, height, format, type, bufSize, data_ptr);
                }
            }
            public static unsafe void GetnUniformfvKHR(ProgramHandle program, int location, Span<float> parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (float* parameters_ptr = parameters)
                {
                    GetnUniformfvKHR(program, location, bufSize, parameters_ptr);
                }
            }
            public static unsafe void GetnUniformfvKHR(ProgramHandle program, int location, float[] parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (float* parameters_ptr = parameters)
                {
                    GetnUniformfvKHR(program, location, bufSize, parameters_ptr);
                }
            }
            public static unsafe void GetnUniformfvKHR(ProgramHandle program, int location, int bufSize, ref float parameters)
            {
                fixed (float* parameters_ptr = &parameters)
                {
                    GetnUniformfvKHR(program, location, bufSize, parameters_ptr);
                }
            }
            public static unsafe void GetnUniformivKHR(ProgramHandle program, int location, Span<int> parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (int* parameters_ptr = parameters)
                {
                    GetnUniformivKHR(program, location, bufSize, parameters_ptr);
                }
            }
            public static unsafe void GetnUniformivKHR(ProgramHandle program, int location, int[] parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (int* parameters_ptr = parameters)
                {
                    GetnUniformivKHR(program, location, bufSize, parameters_ptr);
                }
            }
            public static unsafe void GetnUniformivKHR(ProgramHandle program, int location, int bufSize, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetnUniformivKHR(program, location, bufSize, parameters_ptr);
                }
            }
            public static unsafe void GetnUniformuivKHR(ProgramHandle program, int location, Span<uint> parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (uint* parameters_ptr = parameters)
                {
                    GetnUniformuivKHR(program, location, bufSize, parameters_ptr);
                }
            }
            public static unsafe void GetnUniformuivKHR(ProgramHandle program, int location, uint[] parameters)
            {
                int bufSize = (int)(parameters.Length * 4);
                fixed (uint* parameters_ptr = parameters)
                {
                    GetnUniformuivKHR(program, location, bufSize, parameters_ptr);
                }
            }
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
            public static unsafe void GetFramebufferParameterivMESA(FramebufferTarget target, FramebufferAttachmentParameterName pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetFramebufferParameterivMESA(target, pname, parameters_ptr);
                }
            }
            public static unsafe void GetFramebufferParameterivMESA(FramebufferTarget target, FramebufferAttachmentParameterName pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetFramebufferParameterivMESA(target, pname, parameters_ptr);
                }
            }
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
            public static unsafe void ColorMaskiOES(uint index, bool r, bool g, bool b, bool a)
            {
                byte r_byte = (byte)(r ? 1 : 0);
                byte g_byte = (byte)(g ? 1 : 0);
                byte b_byte = (byte)(b ? 1 : 0);
                byte a_byte = (byte)(a ? 1 : 0);
                ColorMaskiOES(index, r_byte, g_byte, b_byte, a_byte);
            }
            public static unsafe void DrawElementsBaseVertexOES(PrimitiveType mode, int count, DrawElementsType type, nint offset, int basevertex)
            {
                void* indices = (void*)offset;
                DrawElementsBaseVertexOES(mode, count, type, indices, basevertex);
            }
            public static unsafe void DrawRangeElementsBaseVertexOES(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, nint offset, int basevertex)
            {
                void* indices = (void*)offset;
                DrawRangeElementsBaseVertexOES(mode, start, end, count, type, indices, basevertex);
            }
            public static unsafe void DrawElementsInstancedBaseVertexOES(PrimitiveType mode, int count, DrawElementsType type, nint offset, int instancecount, int basevertex)
            {
                void* indices = (void*)offset;
                DrawElementsInstancedBaseVertexOES(mode, count, type, indices, instancecount, basevertex);
            }
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
            public static unsafe void MultiDrawElementsBaseVertexEXT(PrimitiveType mode, in int count, DrawElementsType type, void** indices, int drawcount, in int basevertex)
            {
                fixed (int* count_ptr = &count)
                fixed (int* basevertex_ptr = &basevertex)
                {
                    MultiDrawElementsBaseVertexEXT(mode, count_ptr, type, indices, drawcount, basevertex_ptr);
                }
            }
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
            public static unsafe void GetProgramBinaryOES(ProgramHandle program, int bufSize, ref int length, ref All binaryFormat, IntPtr binary)
            {
                fixed (int* length_ptr = &length)
                fixed (All* binaryFormat_ptr = &binaryFormat)
                {
                    void* binary_vptr = (void*)binary;
                    GetProgramBinaryOES(program, bufSize, length_ptr, binaryFormat_ptr, binary_vptr);
                }
            }
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
            public static unsafe void ProgramBinaryOES(ProgramHandle program, All binaryFormat, IntPtr binary, int length)
            {
                void* binary_vptr = (void*)binary;
                ProgramBinaryOES(program, binaryFormat, binary_vptr, length);
            }
            public static unsafe void ProgramBinaryOES<T1>(ProgramHandle program, All binaryFormat, ReadOnlySpan<T1> binary)
                where T1 : unmanaged
            {
                int length = (int)(binary.Length * sizeof(T1));
                fixed (void* binary_ptr = binary)
                {
                    ProgramBinaryOES(program, binaryFormat, binary_ptr, length);
                }
            }
            public static unsafe void ProgramBinaryOES<T1>(ProgramHandle program, All binaryFormat, T1[] binary)
                where T1 : unmanaged
            {
                int length = (int)(binary.Length * sizeof(T1));
                fixed (void* binary_ptr = binary)
                {
                    ProgramBinaryOES(program, binaryFormat, binary_ptr, length);
                }
            }
            public static unsafe void ProgramBinaryOES<T1>(ProgramHandle program, All binaryFormat, in T1 binary, int length)
                where T1 : unmanaged
            {
                fixed (void* binary_ptr = &binary)
                {
                    ProgramBinaryOES(program, binaryFormat, binary_ptr, length);
                }
            }
            public static unsafe void TexImage3DOES(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, IntPtr pixels)
            {
                void* pixels_vptr = (void*)pixels;
                TexImage3DOES(target, level, internalformat, width, height, depth, border, format, type, pixels_vptr);
            }
            public static unsafe void TexImage3DOES<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, ReadOnlySpan<T1> pixels)
                where T1 : unmanaged
            {
                fixed (void* pixels_ptr = pixels)
                {
                    TexImage3DOES(target, level, internalformat, width, height, depth, border, format, type, pixels_ptr);
                }
            }
            public static unsafe void TexImage3DOES<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, T1[] pixels)
                where T1 : unmanaged
            {
                fixed (void* pixels_ptr = pixels)
                {
                    TexImage3DOES(target, level, internalformat, width, height, depth, border, format, type, pixels_ptr);
                }
            }
            public static unsafe void TexImage3DOES<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, in T1 pixels)
                where T1 : unmanaged
            {
                fixed (void* pixels_ptr = &pixels)
                {
                    TexImage3DOES(target, level, internalformat, width, height, depth, border, format, type, pixels_ptr);
                }
            }
            public static unsafe void TexSubImage3DOES(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels)
            {
                void* pixels_vptr = (void*)pixels;
                TexSubImage3DOES(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels_vptr);
            }
            public static unsafe void TexSubImage3DOES<T1>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, ReadOnlySpan<T1> pixels)
                where T1 : unmanaged
            {
                fixed (void* pixels_ptr = pixels)
                {
                    TexSubImage3DOES(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels_ptr);
                }
            }
            public static unsafe void TexSubImage3DOES<T1>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, T1[] pixels)
                where T1 : unmanaged
            {
                fixed (void* pixels_ptr = pixels)
                {
                    TexSubImage3DOES(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels_ptr);
                }
            }
            public static unsafe void TexSubImage3DOES<T1>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, in T1 pixels)
                where T1 : unmanaged
            {
                fixed (void* pixels_ptr = &pixels)
                {
                    TexSubImage3DOES(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels_ptr);
                }
            }
            public static unsafe void CompressedTexImage3DOES(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data)
            {
                void* data_vptr = (void*)data;
                CompressedTexImage3DOES(target, level, internalformat, width, height, depth, border, imageSize, data_vptr);
            }
            public static unsafe void CompressedTexImage3DOES<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, ReadOnlySpan<T1> data)
                where T1 : unmanaged
            {
                int imageSize = (int)(data.Length * sizeof(T1));
                fixed (void* data_ptr = data)
                {
                    CompressedTexImage3DOES(target, level, internalformat, width, height, depth, border, imageSize, data_ptr);
                }
            }
            public static unsafe void CompressedTexImage3DOES<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, T1[] data)
                where T1 : unmanaged
            {
                int imageSize = (int)(data.Length * sizeof(T1));
                fixed (void* data_ptr = data)
                {
                    CompressedTexImage3DOES(target, level, internalformat, width, height, depth, border, imageSize, data_ptr);
                }
            }
            public static unsafe void CompressedTexImage3DOES<T1>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, in T1 data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    CompressedTexImage3DOES(target, level, internalformat, width, height, depth, border, imageSize, data_ptr);
                }
            }
            public static unsafe void CompressedTexSubImage3DOES(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, IntPtr data)
            {
                void* data_vptr = (void*)data;
                CompressedTexSubImage3DOES(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data_vptr);
            }
            public static unsafe void CompressedTexSubImage3DOES<T1>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, ReadOnlySpan<T1> data)
                where T1 : unmanaged
            {
                int imageSize = (int)(data.Length * sizeof(T1));
                fixed (void* data_ptr = data)
                {
                    CompressedTexSubImage3DOES(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data_ptr);
                }
            }
            public static unsafe void CompressedTexSubImage3DOES<T1>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, T1[] data)
                where T1 : unmanaged
            {
                int imageSize = (int)(data.Length * sizeof(T1));
                fixed (void* data_ptr = data)
                {
                    CompressedTexSubImage3DOES(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data_ptr);
                }
            }
            public static unsafe void CompressedTexSubImage3DOES<T1>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, in T1 data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    CompressedTexSubImage3DOES(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data_ptr);
                }
            }
            public static unsafe void TexParameterIivOES(TextureTarget target, TextureParameterName pname, ReadOnlySpan<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    TexParameterIivOES(target, pname, parameters_ptr);
                }
            }
            public static unsafe void TexParameterIivOES(TextureTarget target, TextureParameterName pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    TexParameterIivOES(target, pname, parameters_ptr);
                }
            }
            public static unsafe void TexParameterIivOES(TextureTarget target, TextureParameterName pname, in int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    TexParameterIivOES(target, pname, parameters_ptr);
                }
            }
            public static unsafe void TexParameterIuivOES(TextureTarget target, TextureParameterName pname, ReadOnlySpan<uint> parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    TexParameterIuivOES(target, pname, parameters_ptr);
                }
            }
            public static unsafe void TexParameterIuivOES(TextureTarget target, TextureParameterName pname, uint[] parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    TexParameterIuivOES(target, pname, parameters_ptr);
                }
            }
            public static unsafe void TexParameterIuivOES(TextureTarget target, TextureParameterName pname, in uint parameters)
            {
                fixed (uint* parameters_ptr = &parameters)
                {
                    TexParameterIuivOES(target, pname, parameters_ptr);
                }
            }
            public static unsafe void GetTexParameterIivOES(TextureTarget target, GetTextureParameter pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexParameterIivOES(target, pname, parameters_ptr);
                }
            }
            public static unsafe void GetTexParameterIivOES(TextureTarget target, GetTextureParameter pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetTexParameterIivOES(target, pname, parameters_ptr);
                }
            }
            public static unsafe void GetTexParameterIivOES(TextureTarget target, GetTextureParameter pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetTexParameterIivOES(target, pname, parameters_ptr);
                }
            }
            public static unsafe void GetTexParameterIuivOES(TextureTarget target, GetTextureParameter pname, Span<uint> parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    GetTexParameterIuivOES(target, pname, parameters_ptr);
                }
            }
            public static unsafe void GetTexParameterIuivOES(TextureTarget target, GetTextureParameter pname, uint[] parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    GetTexParameterIuivOES(target, pname, parameters_ptr);
                }
            }
            public static unsafe void GetTexParameterIuivOES(TextureTarget target, GetTextureParameter pname, ref uint parameters)
            {
                fixed (uint* parameters_ptr = &parameters)
                {
                    GetTexParameterIuivOES(target, pname, parameters_ptr);
                }
            }
            public static unsafe void SamplerParameterIivOES(SamplerHandle sampler, SamplerParameterI pname, ReadOnlySpan<int> param)
            {
                fixed (int* param_ptr = param)
                {
                    SamplerParameterIivOES(sampler, pname, param_ptr);
                }
            }
            public static unsafe void SamplerParameterIivOES(SamplerHandle sampler, SamplerParameterI pname, int[] param)
            {
                fixed (int* param_ptr = param)
                {
                    SamplerParameterIivOES(sampler, pname, param_ptr);
                }
            }
            public static unsafe void SamplerParameterIivOES(SamplerHandle sampler, SamplerParameterI pname, in int param)
            {
                fixed (int* param_ptr = &param)
                {
                    SamplerParameterIivOES(sampler, pname, param_ptr);
                }
            }
            public static unsafe void SamplerParameterIuivOES(SamplerHandle sampler, SamplerParameterI pname, ReadOnlySpan<uint> param)
            {
                fixed (uint* param_ptr = param)
                {
                    SamplerParameterIuivOES(sampler, pname, param_ptr);
                }
            }
            public static unsafe void SamplerParameterIuivOES(SamplerHandle sampler, SamplerParameterI pname, uint[] param)
            {
                fixed (uint* param_ptr = param)
                {
                    SamplerParameterIuivOES(sampler, pname, param_ptr);
                }
            }
            public static unsafe void SamplerParameterIuivOES(SamplerHandle sampler, SamplerParameterI pname, in uint param)
            {
                fixed (uint* param_ptr = &param)
                {
                    SamplerParameterIuivOES(sampler, pname, param_ptr);
                }
            }
            public static unsafe void GetSamplerParameterIivOES(SamplerHandle sampler, SamplerParameterI pname, Span<int> parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetSamplerParameterIivOES(sampler, pname, parameters_ptr);
                }
            }
            public static unsafe void GetSamplerParameterIivOES(SamplerHandle sampler, SamplerParameterI pname, int[] parameters)
            {
                fixed (int* parameters_ptr = parameters)
                {
                    GetSamplerParameterIivOES(sampler, pname, parameters_ptr);
                }
            }
            public static unsafe void GetSamplerParameterIivOES(SamplerHandle sampler, SamplerParameterI pname, ref int parameters)
            {
                fixed (int* parameters_ptr = &parameters)
                {
                    GetSamplerParameterIivOES(sampler, pname, parameters_ptr);
                }
            }
            public static unsafe void GetSamplerParameterIuivOES(SamplerHandle sampler, SamplerParameterI pname, Span<uint> parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    GetSamplerParameterIuivOES(sampler, pname, parameters_ptr);
                }
            }
            public static unsafe void GetSamplerParameterIuivOES(SamplerHandle sampler, SamplerParameterI pname, uint[] parameters)
            {
                fixed (uint* parameters_ptr = parameters)
                {
                    GetSamplerParameterIuivOES(sampler, pname, parameters_ptr);
                }
            }
            public static unsafe void GetSamplerParameterIuivOES(SamplerHandle sampler, SamplerParameterI pname, ref uint parameters)
            {
                fixed (uint* parameters_ptr = &parameters)
                {
                    GetSamplerParameterIuivOES(sampler, pname, parameters_ptr);
                }
            }
            public static unsafe void TexStorage3DMultisampleOES(TextureTarget target, int samples, SizedInternalFormat internalformat, int width, int height, int depth, bool fixedsamplelocations)
            {
                byte fixedsamplelocations_byte = (byte)(fixedsamplelocations ? 1 : 0);
                TexStorage3DMultisampleOES(target, samples, internalformat, width, height, depth, fixedsamplelocations_byte);
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
            public static unsafe void ViewportArrayvOES(uint first, ReadOnlySpan<float> v)
            {
                int count = (int)(v.Length / 4);
                fixed (float* v_ptr = v)
                {
                    ViewportArrayvOES(first, count, v_ptr);
                }
            }
            public static unsafe void ViewportArrayvOES(uint first, float[] v)
            {
                int count = (int)(v.Length / 4);
                fixed (float* v_ptr = v)
                {
                    ViewportArrayvOES(first, count, v_ptr);
                }
            }
            public static unsafe void ViewportArrayvOES(uint first, int count, in float v)
            {
                fixed (float* v_ptr = &v)
                {
                    ViewportArrayvOES(first, count, v_ptr);
                }
            }
            public static unsafe void ViewportIndexedfvOES(uint index, ReadOnlySpan<float> v)
            {
                fixed (float* v_ptr = v)
                {
                    ViewportIndexedfvOES(index, v_ptr);
                }
            }
            public static unsafe void ViewportIndexedfvOES(uint index, float[] v)
            {
                fixed (float* v_ptr = v)
                {
                    ViewportIndexedfvOES(index, v_ptr);
                }
            }
            public static unsafe void ViewportIndexedfvOES(uint index, in float v)
            {
                fixed (float* v_ptr = &v)
                {
                    ViewportIndexedfvOES(index, v_ptr);
                }
            }
            public static unsafe void ScissorArrayvOES(uint first, ReadOnlySpan<int> v)
            {
                int count = (int)(v.Length / 4);
                fixed (int* v_ptr = v)
                {
                    ScissorArrayvOES(first, count, v_ptr);
                }
            }
            public static unsafe void ScissorArrayvOES(uint first, int[] v)
            {
                int count = (int)(v.Length / 4);
                fixed (int* v_ptr = v)
                {
                    ScissorArrayvOES(first, count, v_ptr);
                }
            }
            public static unsafe void ScissorArrayvOES(uint first, int count, in int v)
            {
                fixed (int* v_ptr = &v)
                {
                    ScissorArrayvOES(first, count, v_ptr);
                }
            }
            public static unsafe void ScissorIndexedvOES(uint index, ReadOnlySpan<int> v)
            {
                fixed (int* v_ptr = v)
                {
                    ScissorIndexedvOES(index, v_ptr);
                }
            }
            public static unsafe void ScissorIndexedvOES(uint index, int[] v)
            {
                fixed (int* v_ptr = v)
                {
                    ScissorIndexedvOES(index, v_ptr);
                }
            }
            public static unsafe void ScissorIndexedvOES(uint index, in int v)
            {
                fixed (int* v_ptr = &v)
                {
                    ScissorIndexedvOES(index, v_ptr);
                }
            }
            public static unsafe void DepthRangeArrayfvOES(uint first, int count, in float v)
            {
                fixed (float* v_ptr = &v)
                {
                    DepthRangeArrayfvOES(first, count, v_ptr);
                }
            }
            public static unsafe void GetFloati_vOES(GetPName target, uint index, Span<float> data)
            {
                fixed (float* data_ptr = data)
                {
                    GetFloati_vOES(target, index, data_ptr);
                }
            }
            public static unsafe void GetFloati_vOES(GetPName target, uint index, float[] data)
            {
                fixed (float* data_ptr = data)
                {
                    GetFloati_vOES(target, index, data_ptr);
                }
            }
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
            public static unsafe void FramebufferFoveationConfigQCOM(FramebufferHandle framebuffer, uint numLayers, uint focalPointsPerLayer, uint requestedFeatures, Span<uint> providedFeatures)
            {
                fixed (uint* providedFeatures_ptr = providedFeatures)
                {
                    FramebufferFoveationConfigQCOM(framebuffer, numLayers, focalPointsPerLayer, requestedFeatures, providedFeatures_ptr);
                }
            }
            public static unsafe void FramebufferFoveationConfigQCOM(FramebufferHandle framebuffer, uint numLayers, uint focalPointsPerLayer, uint requestedFeatures, uint[] providedFeatures)
            {
                fixed (uint* providedFeatures_ptr = providedFeatures)
                {
                    FramebufferFoveationConfigQCOM(framebuffer, numLayers, focalPointsPerLayer, requestedFeatures, providedFeatures_ptr);
                }
            }
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
